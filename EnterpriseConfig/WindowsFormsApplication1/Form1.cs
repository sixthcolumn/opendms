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
        DERMSInterface.CIMData _cim = new CIMData();
        private BindingSource DERGroupBindingSource = new BindingSource();
        private BindingSource DERBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            DERGroupBindingSource.DataSource = _cim.Groups;
            DERGroupsView.DataSource = DERGroupBindingSource;
            DERGroupBindingSource.ResetBindings(false);
            DERGroupsView.RowEnter += new DataGridViewCellEventHandler(DERGroupRow_enter);
            DERGroupsView.RowLeave += new DataGridViewCellEventHandler(DERGroupRow_leave);
            DERGroupsView.CellClick += new DataGridViewCellEventHandler(DERGroupCell_Clicked);
            DERGroupsView.CellValueChanged += new DataGridViewCellEventHandler(DERGroupCell_Changed);
            DERGroupsView.UserDeletedRow += new DataGridViewRowEventHandler(DERGroupRow_Deleted);
            DERView.CellValueChanged += new DataGridViewCellEventHandler(DERCellValue_Updated);
            DERView.CellValidating += new DataGridViewCellValidatingEventHandler(DERCell_Validating);
            DERView.ReadOnly = true;
            DERGroupsView.AllowUserToAddRows = true;
            verbText.Text = verb(messageTypeCombo.Text);
        }


        private void DERGroupRow_enter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
                return;

            BindDERBindingSource(e.RowIndex);
        }

        
        private void DERGroupRow_Deleted(object sender, DataGridViewRowEventArgs e)
        {
           DERGroupsView.Rows[0].Selected = true;
           BindDERBindingSource(0);
        }

        // Validates that the value in reactive and real cells are legal floating point
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

        // when a dergroup is selected, makes the DER data grid show the DERGroups children DERs  
        private void BindDERBindingSource(int row)
        {
            string name = _cim.Groups[row].GroupName;
            if (name != null && name.Length > 0)
            {
                // DERS can only be accessed if their parent is named
                // TODO : Design flaw? Not really. You can't have an un-named DERGroup
                bindDevices(_cim.Groups[row]);
                DERView.ReadOnly = false;
            }
            else
            {
                // DERGroup has not been named yet, don't let them edit DER
                bindDevices(null);
                DERView.ReadOnly = true;
            }
        }

        // returns index of currently selected row. valid == true if
        // one row selected, exactly. Not 0 and not 2.
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

        private void DERGroupCell_Clicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) // header
                return;
            BindDERBindingSource(e.RowIndex);
        }


        private void DERGroupCell_Changed(object sender, DataGridViewCellEventArgs e)
        {
            // TODO : This might be buggy. Not sure why I set it...
            BindDERBindingSource(e.RowIndex);
        }

        /*
         * update handlers for DERS, when certain cells are changed, we modify
         * the readonly summation cells in DERGroup
         * 
         * eg: DER count, sum(watts), sum(var)
         */
        private void DERCellValue_Updated(object sender, DataGridViewCellEventArgs e)
        {
            updateDERGroupViewReadOnlyCells();
        }

        // row selected
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

        // re-initialize the binding source for DERGroup
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

        // open file menu item
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

        // save file menu item
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _cim.Groups.ToString();
            // if _filepath not set, send them to 'save as'
            if (_filepath == null || _filepath.Length < 1)
                saveAsToolStripMenuItem_Click(sender, e);
            else
                saveFile(_filepath);
        }

        // saves the to xml format
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

        // reads in the config file
        private void openFile(string path)
        {
            // currently four diff headers: create, get, dispatch, status
            string name = messageTypeCombo.Text;
           
            // read the xml config file
            this._filepath = path;
            _cim = DERMSInterface.CIMData.read(path);

            // load the header form based on which header type is set in combobox
            loadHeader(name);
            DERGroupBindingSource.DataSource = _cim.Groups;
            updateDERGroupViewReadOnlyCells();

            if (DERGroupsView.Rows.Count > 0)
            {
                DERGroupsView.Rows[0].Selected = true;
                BindDERBindingSource(0);
            }
        }

        /*
         * Some of the DERGroup cells are readonly and are populated by
         * summing values in the children DER. This updates those
         * read only cells
         */
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

        // convenience function to return correct verb based on message type
        private string verb(String name)
        {
            if (name.Equals("createDER") || name.Equals("dispatchDER"))
                return "create";
            else if (name.Equals("getDER") || name.Equals("getDERStatus"))
                return "get";
            else
                return null;
        }

        // file save as menu item
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

        /*
         * on the header page, when user changes value of the DERGroup type:
         * createDERGroup, Get, etc... this loads the values from the correct
         * config header onto the header form.
         */
        private void messageTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = ((ComboBox)sender).Text;
            loadHeader(name);
        }

        // loads the correct header type from config (createDERGroup, get...) onto header form
        private void loadHeader(string name)
        {
            DERMSInterface.CIMData.header h = getHeader(name);
            endPointText.Text = h.EndPoint;
            replyAddressText.Text = h.ReplyAddress;
            ackRequiredCheck.Checked = h.AckRequired;
            // hardcoded!
            verbText.Text = h.Verb = verb(name);
            nounText.Text = h.Noun = "DER Request";

            userIDText.Text = h.UserID;
            organizationText.Text = h.UserOrganization;
            contextText.Text = h.Context;
            commentText.Text = h.Comment;
        }

        // get the cim headers, instantiate if currently null
        private DERMSInterface.CIMData.header getHeader(string name)
        {
            DERMSInterface.CIMData.header h = _cim.Headers.Find(x => x.Name.Equals(name));
            // if it doesn't exist, we'll create it
            if (h == null)
            {
                h = new DERMSInterface.CIMData.header();
                h.Name = name;
                _cim.Headers.Add(h);
            }
            return h;
        }

        // the following handlers sync data objects with cells
        private void endPointText_TextChanged(object sender, EventArgs e)
        {
            getHeader(messageTypeCombo.Text).EndPoint = ((TextBox)sender).Text;
        }

        private void replyAddressText_TextChanged(object sender, EventArgs e)
        {
            getHeader(messageTypeCombo.Text).ReplyAddress = ((TextBox)sender).Text;
        }

        private void ackRequiredCheck_CheckedChanged(object sender, EventArgs e)
        {
            getHeader(messageTypeCombo.Text).AckRequired = ((CheckBox)sender).Checked;
        }

        private void commentText_TextChanged(object sender, EventArgs e)
        {
            getHeader(messageTypeCombo.Text).Comment = ((TextBox)sender).Text;
        }

        private void userIDText_TextChanged(object sender, EventArgs e)
        {
            getHeader(messageTypeCombo.Text).UserID = ((TextBox)sender).Text;
        }

        private void organizationText_TextChanged(object sender, EventArgs e)
        {
            getHeader(messageTypeCombo.Text).UserOrganization = ((TextBox)sender).Text;
        }

        private void contextText_TextChanged(object sender, EventArgs e)
        {
            getHeader(messageTypeCombo.Text).Context = ((TextBox)sender).Text;
        }



        // Sends a test create der group message
        private void createDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean isValid = false;
            int row = getSingleSelectedRow(ref isValid);

            if (isValid == true) { 
                // name must be defined
                if (_cim.Groups[row].GroupName == null || _cim.Groups[row].GroupName.Length < 1)
                    MessageBox.Show("Name required to create DER Group", "Create DER", MessageBoxButtons.OK);
                else
                    new CreateDERForm(_cim, DERGroupsView.SelectedRows[0].Index).Show();
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
                    new GetDERStatusForm(_cim, DERGroupsView.SelectedRows[0].Index).Show();
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

        private void dispatchDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean isValid = false;
            int row = getSingleSelectedRow(ref isValid);

            if (isValid == true)
            {
                if (_cim.Groups[row].Mrid == null || _cim.Groups[row].Mrid.Length < 1)
                    MessageBox.Show("MRID requried to dispatch DER Group", "Dispatch DER", MessageBoxButtons.OK);
                else
                    new DispatchDERForm(_cim, DERGroupsView.SelectedRows[0].Index).Show();
            }
        }


    }
}
