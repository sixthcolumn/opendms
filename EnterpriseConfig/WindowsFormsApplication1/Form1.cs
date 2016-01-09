using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DERMSInterface;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string _filepath;
        public static DERMSInterface.CIMData _cim = new CIMData();
        private BindingSource DERGroupBindingSource = new BindingSource();
        private BindingSource DERBindingSource = new BindingSource();
        private BindingSource ScadaBindingSource = new BindingSource();


        /// <summary>
        /// initializes the form and the event handlers
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            DERGroupBindingSource.DataSource = _cim.Groups;
            DERGroupsView.DataSource = DERGroupBindingSource;
            DERGroupBindingSource.ResetBindings(false);

            scadaControl.BindDataSource(_cim.Scada);

            DERGroupsView.RowEnter += new DataGridViewCellEventHandler(DERGroupRow_enter);
            DERGroupsView.RowLeave += new DataGridViewCellEventHandler(DERGroupRow_leave);
            DERGroupsView.CellClick += new DataGridViewCellEventHandler(DERGroupCell_Clicked);
            DERGroupsView.CellValueChanged += new DataGridViewCellEventHandler(DERGroupCell_Changed);
            DERGroupsView.UserDeletedRow += new DataGridViewRowEventHandler(DERGroupRow_Deleted);
            DERView.CellValueChanged += new DataGridViewCellEventHandler(DERCellValue_Updated);
            DERView.CellValidating += new DataGridViewCellValidatingEventHandler(DERCell_Validating);
            DERView.ReadOnly = true;
            DERGroupsView.AllowUserToAddRows = true;

            // todo : Set default verb, I removed code, probably belongs in the DERheaderControl.cs
        }


        /// <summary>
        /// re-binds the DERs gridview whenever the user selects a different DER Group
        /// </summary>
        /// <param name="row">DER Group row</param>
        private void BindDERBindingSource(int row)
        {
            if (_cim.Groups.Count > 0)
            {
                string name = _cim.Groups[row].GroupName;
                if (name != null && name.Length > 0)
                {
                    // DERS can only be accessed if their parent is named
                    // TODO : Design flaw? Not really. You can't have an un-named DERGroup
                    bindDevices(_cim.Groups[row]);
                    DERView.ReadOnly = false;
                    return;
                }

            }

            // No DERGroups or no named DERGroups
            bindDevices(null);
            DERView.ReadOnly = true;

        }

        /// <summary>
        /// returns the row number of the currently selected group
        /// </summary>
        /// <param name="valid">a single row is selected</param>
        /// <returns></returns>
        private int getSingleSelectedRow(ref Boolean valid)
        {
            if (DERGroupsView.SelectedRows.Count != 1)
            {
                valid = false;
                return -1;
            }
            valid = true;
            return DERGroupsView.SelectedRows[0].Index;
        }

        /// <summary>
        /// save the in memory cim data to a file
        /// </summary>
        /// <param name="_filepath">file name</param>
        private void saveFile(string _filepath)
        {
            foreach (CIMData.DERGroup group in _cim.Groups)
            {
                if (group.GroupName == null || group.GroupName.Length < 1)
                {
                    MessageBox.Show("Please set DERGroup names", "File Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            _cim.write(_filepath);
        }

        /// <summary>
        /// loads cim config file into memory
        /// </summary>
        /// <param name="path">file name</param>
        private void openFile(string path)
        {
            // currently four diff headers: create, get, dispatch, status
            string name = derHeaderControl1.MessageTypeComboText;

            // read the xml config file
            this._filepath = path;
            _cim = DERMSInterface.CIMData.read(path);

            // load the header form based on which header type is set in combobox
            derHeaderControl1.loadHeader(_cim, name);
            DERGroupBindingSource.DataSource = _cim.Groups;
            updateDERGroupViewReadOnlyCells();
            scadaControl.BindDataSource(_cim.Scada);

            if (DERGroupsView.Rows.Count > 0)
            {
                DERGroupsView.Rows[0].Selected = true;
                BindDERBindingSource(0);
            }
            else
                bindDevices(null);
        }

        /// <summary>
        /// When changes are made to DER (child) members watt/var this updates
        /// the read only values in the DER group gridview with new values
        /// </summary>
        private void updateDERGroupViewReadOnlyCells()
        {
            for (int i = 0; i < DERGroupsView.RowCount && i < _cim.Groups.Count; i++)
            {
                if (_cim.Groups[i].Devices != null)
                {
                    DERGroupsView.Rows[i].Cells[6].Value = _cim.Groups[i].Devices.Count;
                    DERGroupsView.Rows[i].Cells[7].Value = _cim.Groups[i].getWattCapacity();
                    DERGroupsView.Rows[i].Cells[8].Value = _cim.Groups[i].getVarCapacity();
                }
            }
        }


        /// <summary>
        /// event handler. displays create DER form to send SOAP messages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean isValid = false;
            int row = getSingleSelectedRow(ref isValid);

            if (isValid == true)
            {
                // name must be defined
                if (_cim.Groups[row].GroupName == null || _cim.Groups[row].GroupName.Length < 1)
                    MessageBox.Show("Name required to create DER Group", "Create DER", MessageBoxButtons.OK);
                else
                    new CreateDERForm(_cim.clone(), DERGroupsView.SelectedRows[0].Index).Show();
            }
            else if (DERGroupsView.SelectedRows.Count == 0)
            {
                if (_cim.Groups.Count == 0)
                    MessageBox.Show("Please create and then select a DER Group", "Create DER", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Please select a DER Group ROW", "Create DER", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Please selected a SINGLE row", "Create DER", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// event handler. Displays the GET DER Status form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getDERStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean isValid = false;
            int row = getSingleSelectedRow(ref isValid);

            if (isValid == true)
            {
                // name must be defined
                if (_cim.Groups[row].GroupName == null || _cim.Groups[row].GroupName.Length < 1)
                    MessageBox.Show("Name required to create DER Group", "Create DER", MessageBoxButtons.OK);
                else
                    new GetDERStatusForm(_cim.clone(), DERGroupsView.SelectedRows[0].Index).Show();
            }
            else if (DERGroupsView.SelectedRows.Count == 0)
            {
                if (_cim.Groups.Count == 0)
                    MessageBox.Show("Please create and then select a DER Group", "Create DER", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Please select a DER Group ROW", "Create DER", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Please selected a SINGLE row", "Create DER", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// event handler. Displays the Dispatch DER form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dispatchDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean isValid = false;
            int row = getSingleSelectedRow(ref isValid);

            if (isValid == true)
            {
                if (_cim.Groups[row].Mrid == null || _cim.Groups[row].Mrid.Length < 1)
                    MessageBox.Show("MRID requried to dispatch DER Group", "Dispatch DER", MessageBoxButtons.OK);
                else
                    new DispatchDERForm(_cim.clone(), DERGroupsView.SelectedRows[0].Index).Show();
            }
        }

        /// <summary>
        /// event handler. Displays the get DER form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getDERsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean isValid = false;
            int row = getSingleSelectedRow(ref isValid);

            if (isValid == true)
            {
                if (_cim.Groups[row].Mrid == null || _cim.Groups[row].Mrid.Length < 1)
                    MessageBox.Show("MRID requried to dispatch DER Group", "Dispatch DER", MessageBoxButtons.OK);
                else
                    new GetDERGroupForm(_cim.clone(), DERGroupsView.SelectedRows[0].Index).Show();
            }
        }

        /// <summary>
        /// binds the DER children to the newly selected DERGroup user just clicked on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DERGroupRow_enter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
                return;

            BindDERBindingSource(e.RowIndex);
        }

        /// <summary>
        /// When user deletes a row, moves selection back to first DER Group row.
        /// Why? I don't know.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DERGroupRow_Deleted(object sender, DataGridViewRowEventArgs e)
        {
            DERGroupsView.Rows[0].Selected = true;
            BindDERBindingSource(0);
        }

        /// <summary>
        /// complains when user enters non float value into DER member power cells
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DERCell_Validating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            double d;
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
            {
                if (!double.TryParse(Convert.ToString(e.FormattedValue), out d))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter floating point number", "Cell Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// binds the DER member data grid to the just newly selected der group
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DERGroupCell_Clicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) // header
                return;
            BindDERBindingSource(e.RowIndex);
        }

        /// <summary>
        /// possibly deprecated...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DERGroupCell_Changed(object sender, DataGridViewCellEventArgs e)
        {
            // TODO : This might be buggy. Not sure why I set it...
            BindDERBindingSource(e.RowIndex);
        }

        /// <summary>
        /// When a DER member cell value changes, update the readonly DER group cells
        /// with new summed/counted values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DERCellValue_Updated(object sender, DataGridViewCellEventArgs e)
        {
            updateDERGroupViewReadOnlyCells();
        }

        /// <summary>
        /// read kludge below
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DERGroupRow_leave(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == 0)
                return;
            /*
             * kludge. When you select DER (child) cell, the datagrid unselects the
             * NEW row, and selects the previous row, but leaves the cell you have
             * selected in the new row hilited. This unselects that cell, which selects
             * first cell of previous (existing row). trust me.
             */
            if (DERGroupsView.NewRowIndex == e.RowIndex)
                DERGroupsView.Rows[e.RowIndex].Cells[0].Selected = false;
        }


        /// <summary>
        /// binds the DER Group and DER Members to the group passed
        /// </summary>
        /// <param name="group"></param>
        private void bindDevices(CIMData.DERGroup group)
        {
            if (group == null)
            {
                DERBindingSource.DataSource = null;
                DERView.DataSource = null;
                DERBindingSource.Clear();
            }
            else
            {
                if (group.Devices == null)
                    group.Devices = new List<CIMData.device>();
                DERBindingSource = new BindingSource();
                DERBindingSource.DataSource = group.Devices;
                DERView.DataSource = DERBindingSource;
                DERBindingSource.ResetBindings(false);
            }
        }


        /// <summary>
        /// displays open file widget and opens new config file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "XML|*.xml";
            d.Title = "Save Header File";
            d.ShowDialog();

            if (d.FileName != "")
            {
                openFile(d.FileName);
            }
        }

        /// <summary>
        /// saves config information to file. If file name not set, calls save as...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _cim.Groups.ToString();
            // if _filepath not set, send them to 'save as'
            if (_filepath == null || _filepath.Length < 1)
                saveAsToolStripMenuItem_Click(sender, e);
            else
                saveFile(_filepath);
        }

        /// <summary>
        /// when the user selects different header (create, get, get status, dispatch) this
        /// re-initializes the form fields on the screen to show that header's
        /// data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void messageTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = ((ComboBox)sender).Text;
            derHeaderControl1.loadHeader(_cim, name);
        }

        /// <summary>
        /// displays file save as menu, and saves config to xml file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = "XML|*.xml";
            d.Title = "Save Header File";
            d.ShowDialog();

            if (d.FileName != "")
            {
                this._filepath = d.FileName;
                saveFile(d.FileName);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _cim = new CIMData();
            string name = derHeaderControl1.MessageTypeComboText;
            derHeaderControl1.loadHeader(_cim, name);
            DERGroupBindingSource.DataSource = _cim.Groups;
            bindDevices(null);
            scadaControl.reset();
            scadaControl.BindDataSource(_cim.Scada);
            updateDERGroupViewReadOnlyCells();
        }

    }
}
