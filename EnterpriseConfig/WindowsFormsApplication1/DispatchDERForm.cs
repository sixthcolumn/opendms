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
    public partial class DispatchDERForm : Form
    {
        DERMSInterface.CIMData _cim = null;
        DERMSInterface.CIMData.DERGroup _group = null;
        XMLForm _log = null;
        DERMSInterface.quantity _q;
        double realValue = 0.0;
        double reactiveValue = 0.0;

        /// <summary>
        /// convenience function to get the dispatch der header
        /// </summary>
        private DERMSInterface.CIMData.header header
        {
            get { return _cim.DispatchDERHeader; }
        }

        /// <summary>
        /// convenience function. Get the currently selected DER Group
        /// </summary>
        private DERMSInterface.CIMData.DERGroup group
        {
            get { return _group; }
        }

        /// <summary>
        /// convenience function. Returns the real/reactive power
        /// </summary>
        private double dispatchValue
        {
            get { return _q.Equals(DERMSInterface.quantity.RealPower) ? realValue : reactiveValue; }
        }

        /// <summary>
        /// default constructor, don't use
        /// </summary>
        public DispatchDERForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  constructor
        /// </summary>
        /// <param name="cim">the config data object</param>
        /// <param name="row">the row of data from the object to be sent</param>
        public DispatchDERForm(DERMSInterface.CIMData cim, DERMSInterface.CIMData.DERGroup group)
        {
            _cim = cim;
            _group = group;
            InitializeComponent();
        }

        /// <summary>
        /// call the SOAP dispatch method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dispatchButton_Click(object sender, EventArgs e)
        {
            DERMSInterface.CIM cs = new DERMSInterface.CIM(_cim);
            int rc = 1;

            try
            {
                // because we allow user to edit real/reactive values, we always force send it
                rc = cs.DispatchDERGroup(_group.Mrid, _q, true, dispatchValue);
                logControl1.addEntry(LogControl.entryType.OK, "Message Sent...", cs.LastMessageSent);
                logControl1.addEntry(LogControl.entryType.OK, "Message Received...", cs.LastMessageReceived);
            }
            catch (Exception ex)
            {
                if (cs.LastMessageSent.Length > 0)
                    logControl1.addEntry(LogControl.entryType.OK, "Message Sent...", cs.LastMessageSent);
                logControl1.addEntry(LogControl.entryType.FAIL, "Exception...", ex.ToString());
            }
        }

        /// <summary>
        /// initializes the form, loads up all its widgets with data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DispatchDERForm_Load(object sender, System.EventArgs e)
        {
            _log = new XMLForm();
            string DERGroupName = DERMSInterface.CIMData.operations.dispatchDER.ToString();
            DERMSInterface.CIMData.header header = _cim.DispatchDERHeader;
            this.endPointText.Text = header.EndPoint;
            this.messageTypeText.Text = "Dispatch DER";
            this.replyAddressText.Text = header.ReplyAddress;
            this.userIDText.Text = header.UserID;
            this.organizationText.Text = header.UserOrganization;
            this.contextText.Text = header.Context;
            this.verbText.Text = header.Verb;
            this.ackRequiredCheck.Checked = header.AckRequired;
            this.commentText.Text = header.Comment;

            // set to real by default. Why not?
            this.realRadio.Checked = true;
            DERMSInterface.CIMData.DERGroup group = this.group;
            DERGroupMRIDText.Text = group.Mrid;
            realValue = group.getWattCapacity();
            reactiveValue = group.getVarCapacity();
            realValueText.Text = realValue.ToString();
            reactiveValueText.Text = reactiveValue.ToString();
        }

        // -----
        // form values changed handlers
        // -----
        #region value changed event handlers
        private void realRadio_CheckedChanged(object sender, EventArgs e)
        {
            _q = DERMSInterface.quantity.RealPower;
        }

        private void reactiveRadio_CheckedChanged(object sender, EventArgs e)
        {
            _q = DERMSInterface.quantity.ApparentPower;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void endPointText_TextChanged(object sender, EventArgs e)
        {
            header.EndPoint = ((TextBox)sender).Text;
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

        private void DERGroupMRIDText_TextChanged(object sender, EventArgs e)
        {
            group.Mrid = ((TextBox)sender).Text;
        }

        private void realValueText_TextChanged(object sender, EventArgs e)
        {
            realValueText.Text = ((TextBox)sender).Text;
        }

        private void reactiveValueText_TextChanged(object sender, EventArgs e)
        {
            reactiveValueText.Text = ((TextBox)sender).Text;
        }
        #endregion
        // -----
        // END form values changed handlers
        // -----
    }
}
