using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DERGroupViewControl : UserControl
    {

        public DERMSInterface.CIMData _cim;

        public DERGroupViewControl()
        {
            InitializeComponent();

            DERGroupsView.RowEnter += new DataGridViewCellEventHandler(DERGroupRow_enter);
            DERGroupsView.RowLeave += new DataGridViewCellEventHandler(DERGroupRow_leave);
            DERGroupsView.CellClick += new DataGridViewCellEventHandler(DERGroupCell_Clicked);
            DERGroupsView.CellValueChanged += new DataGridViewCellEventHandler(DERGroupCell_Changed);
            DERGroupsView.UserDeletedRow += new DataGridViewRowEventHandler(DERGroupRow_Deleted);
            DERView.CellValueChanged += new DataGridViewCellEventHandler(DERCellValue_Updated);
            DERView.CellValidating += new DataGridViewCellValidatingEventHandler(DERCell_Validating);
            DERView.ReadOnly = true;
            DERGroupsView.AllowUserToAddRows = true;
        }


        /// <summary>
        /// returns the row number of the currently selected group
        /// </summary>
        /// <param name="valid">a single row is selected</param>
        /// <returns></returns>
        public int getSingleSelectedRow(ref Boolean valid)
        {
            if (DERGroupsView.SelectedRows.Count != 1)
            {
                valid = false;
                return -1;
            }
            valid = true;
            return DERGroupsView.SelectedRows[0].Index;
        }

        public void bindDataSource(DERMSInterface.CIMData cim)
        {
            _cim = cim;
            dERGroupBindingSource.DataSource = _cim.Groups;
            DERGroupsView.DataSource = dERGroupBindingSource;

            if (DERGroupsView.Rows.Count > 0)
            {
                DERGroupsView.Rows[0].Selected = true;
                BindDERBindingSource(0);
            }
            else
                bindDevices(null);
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
        /// When changes are made to DER (child) members watt/var this updates
        /// the read only values in the DER group gridview with new values
        /// </summary>
        public void updateDERGroupViewReadOnlyCells()
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
        private void bindDevices(DERMSInterface.CIMData.DERGroup group)
        {
            if (group == null)
            {
                dERGroupBindingSource.DataSource = null;
                DERView.DataSource = null;
                dERGroupBindingSource.Clear();
            }
            else
            {
                if (group.Devices == null)
                    group.Devices = new List<DERMSInterface.CIMData.device>();
                dERGroupBindingSource = new BindingSource();
                dERGroupBindingSource.DataSource = group.Devices;
                DERView.DataSource = dERGroupBindingSource;
                dERGroupBindingSource.ResetBindings(false);
            }
        }
    }
}
