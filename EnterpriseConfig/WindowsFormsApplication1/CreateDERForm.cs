using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CreateDERForm : Form
    {
        DERMSInterface.CIMData _cim = null;
        int _row = -1;
        BindingSource bs = new BindingSource();
        XMLForm _log = null;
        string _key = DERMSInterface.CIMData.operations.createDER.ToString();

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="cim"></param>
        /// <param name="row"></param>
        public CreateDERForm(DERMSInterface.CIMData cim, int row)
        {
            _cim = cim;
            _row = row;
            InitializeComponent();
        }

        /// <summary>
        /// call the Create DER SOAP function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createButton_Click(object sender, EventArgs e)
        {
            DERMSInterface.CIM cs = new DERMSInterface.CIM(_cim);
            int rc = 1;
            try
            {
                _log = new XMLForm();
                // call the create DER SOAP method
                rc = cs.createDERGroup(_cim.Groups[_row].GroupName, null);
                _log.addBoldText("Return Code : " + rc.ToString() + Environment.NewLine + Environment.NewLine);
            }
            catch (Exception ex)
            {
                _log.addBoldText("Exception...");
                _log.addText(ex.ToString());
            }
            finally
            {
                _log.addBoldText("Message Sent..." + Environment.NewLine + Environment.NewLine);
                _log.addText(cs.LastMessageSent + Environment.NewLine + Environment.NewLine);
                _log.addBoldText("Message Received..." + Environment.NewLine + Environment.NewLine);
                _log.addText(cs.LastMessageReceived + Environment.NewLine + Environment.NewLine);
            }
            _log.Show();
            MessageBox.Show("Return code : " + rc.ToString(), "Create DER", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        ///  convenience function. get the create der header
        /// </summary>
        private DERMSInterface.CIMData.header header
        {
            get { return _cim.Headers.Find(x => x.Name.Equals(_key)); ; }
        }

        /// <summary>
        ///  convenience function. get the currently selected group
        /// </summary>
        private DERMSInterface.CIMData.DERGroup group
        {
            get { return _cim.Groups[_row]; }
        }

        /// <summary>
        /// initializes the form, loads the on screen widgets with data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLoad(object sender, System.EventArgs e)
        {
            DERMSInterface.CIMData.header header = _cim.CreateDERHeader;


            // header info
            this.endPointText.Text = header.EndPoint;
            this.messageTypeText.Text = "Create DER";
            this.replyAddressText.Text = header.ReplyAddress;
            this.userIDText.Text = header.UserID;
            this.organizationText.Text = header.UserOrganization;
            this.contextText.Text = header.Context;
            this.verbText.Text = header.Verb;
            this.ackRequiredCheck.Checked = header.AckRequired;
            this.commentText.Text = header.Comment;

            // group widgets
            DERMSInterface.CIMData.DERGroup group = _cim.Groups[_row];
            DERGroupNameText.Text = group.GroupName;
            DERGroupMRIDText.Text = group.Mrid;
            DERGroupRevisionText.Text = group.Revision;
            DERGroupSubText.Text = group.Substation;
            DERGroupFeederText.Text = group.Feeder;
            DERGroupSegmentText.Text = group.Segment;
            // TODO : we do not set count, reactive and total power values, they are derived

            int deviceCount = 0;
            double realPower = 0.0;
            double reactivePower = 0.0;

            // bind datasource to the currently selected DER group row
            bs = new BindingSource();
            bs.DataSource = group.Devices;
            DERView.DataSource = bs;
            bs.ResetBindings(false);

            // we allow editing/adding to DER members
            DERView.CellValueChanged += new DataGridViewCellEventHandler(DERCellValue_Updated);
            DERView.CellValidating += new DataGridViewCellValidatingEventHandler(DERCell_Validating);

            // first time, set the read-only sum/count vars for DERGRoup based
            // on the DER members
            group.Devices.ForEach(x =>
            {
                deviceCount++;
                realPower += x.WattCapacity;
                reactivePower += x.VarCapacity;
            });

            // editing for DER members, no edit on derived DER Group fields
            DERView.ReadOnly = false;
            DERGroupDeviceCountText.Enabled = false;
            DERGroupRealText.Enabled = false;
            DERGroupReactiveText.Enabled = false;

            // intialize readonly vars
            DERGroupDeviceCountText.Text = group.Devices.Count.ToString();
            DERGroupReactiveText.Text = group.getVarCapacity().ToString();
            DERGroupRealText.Text = group.getWattCapacity().ToString();

           // if (_editDER == true)
           //     DERView.CellValueChanged += new DataGridViewCellEventHandler(CellValue_Changed);


        }

        /// <summary>
        /// only allow float values for power
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
        /// when DER member changes, update readonly real/reactive of DERGroup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DERCellValue_Updated(object sender, DataGridViewCellEventArgs e)
        {
            DERGroupDeviceCountText.Text = group.Devices.Count.ToString();
            DERGroupReactiveText.Text = group.getVarCapacity().ToString();
            DERGroupRealText.Text = group.getWattCapacity().ToString();
        }

        /*
        private void CellValue_Changed(object sender, DataGridViewCellEventArgs e)
        {
            int count = 0;
            double reactive = 0.0;
            double real = 0.0;
            _cim.Groups[_row].Devices.ForEach(x =>
            {
                count += 1;
                reactive += x.VarCapacity;
                real += x.WattCapacity;
            });

            DERGroupReactiveText.Text = reactive.ToString();
            DERGroupRealText.Text = real.ToString();
            DERGroupDeviceCountText.Text = count.ToString();
        }
        */

        /// <summary>
        /// destroy form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // -----
        // form widget change handlers
        // -----
        #region value changed event handlers
        private void endPointText_TextChanged(object sender, EventArgs e)
        {
            header.EndPoint = ((TextBox)sender).Text;
        }

        private void messageTypeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void replyAddressText_TextChanged(object sender, EventArgs e)
        {
            header.ReplyAddress = ((TextBox)sender).Text;
        }

        private void userIDText_TextChanged(object sender, EventArgs e)
        {
            header.UserID = ((TextBox)sender).Text;
        }

        private void organizationText_TextChanged(object sender, EventArgs e)
        {
            header.UserOrganization = ((TextBox)sender).Text;
        }

        private void contextText_TextChanged(object sender, EventArgs e)
        {
            header.Context = ((TextBox)sender).Text;
        }

        private void ackRequiredCheck_CheckedChanged(object sender, EventArgs e)
        {
            header.AckRequired = ((CheckBox)sender).Checked;
        }

        private void commentText_TextChanged(object sender, EventArgs e)
        {
            header.Comment = ((TextBox)sender).Text;
        }

        private void DERGroupNameText_TextChanged(object sender, EventArgs e)
        {
            group.GroupName = ((TextBox)sender).Text;
        }

        private void DERGroupMRIDText_TextChanged(object sender, EventArgs e)
        {
            group.Mrid = ((TextBox)sender).Text;
        }

        private void DERGroupRevisionText_TextChanged(object sender, EventArgs e)
        {
            group.Revision = ((TextBox)sender).Text;
        }

        private void DERGroupSubText_TextChanged(object sender, EventArgs e)
        {
            group.Substation = ((TextBox)sender).Text;
        }

        private void DERGroupFeederText_TextChanged(object sender, EventArgs e)
        {
            group.Feeder = ((TextBox)sender).Text;
        }

        private void DERGroupSegmentText_TextChanged(object sender, EventArgs e)
        {
            group.Segment = ((TextBox)sender).Text;
        }
        #endregion
        // -----
        // END form widget change handlers
        // -----
    }
}
