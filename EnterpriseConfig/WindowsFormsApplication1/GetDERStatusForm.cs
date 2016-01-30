using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class GetDERStatusForm : Form
    {
        DERMSInterface.CIMData _cim = null;
        DERMSInterface.CIMData.DERGroup _group = null;
        DERMSInterface.quantity _q;
        string _key = DERMSInterface.CIMData.operations.getDERStatus.ToString();


        /// <summary>
        /// convenience function returns the correct header for getDERStatus
        /// </summary>
        private DERMSInterface.CIMData.header header
        {
            get { return _cim.Headers.Find(x => x.Name.Equals(_key)); ; }
        }

        /// <summary>
        /// convenience function, returns the group by row number
        /// </summary>
        private DERMSInterface.CIMData.DERGroup group
        {
            get { return _group; }
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="cim">CIMData object</param>
        /// <param name="row">currently selected DERGroup row</param>
        public GetDERStatusForm(DERMSInterface.CIMData cim, DERMSInterface.CIMData.DERGroup group)
        {
            _cim = cim;
            _group = group;
            InitializeComponent();
        }

        /// <summary>
        /// default constructor, should not be called
        /// </summary>
        public GetDERStatusForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// destroy this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// execute the get der status SOAP call
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getButton_Click(object sender, EventArgs e)
        {
            DERMSInterface.CIM cs = new DERMSInterface.CIM(_cim);
            try
            {
                // call SOAP function
                DERMSInterface.CIMData.DERStatus reply = cs.getDERGroupStatus(_group.Mrid, _q);

                // load screen with return values from call
                this.minValueText.Text = reply.PresentMinCapability.ToString();
                this.currentValueText.Text = reply.PresentValue.ToString();
                this.maxValueText.Text = reply.PresentMaxCapability.ToString();
                this.MRIDReturnText.Text = reply.Mrid;
                this.quantityText.Text = _q.ToString();
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
        /// user wants to get real power in watts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void realRadio_CheckedChanged(object sender, EventArgs e)
        {
            _q = DERMSInterface.quantity.RealPower;
        }

        /// <summary>
        /// user wants to get reactive power in VAr
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reactiveRadio_CheckedChanged(object sender, EventArgs e)
        {
            _q = DERMSInterface.quantity.ApparentPower;
        }

        /// <summary>
        /// populate screen with values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetDERStatusForm_Load(object sender, EventArgs e)
        {

            string DERGroupName = DERMSInterface.CIMData.operations.getDERStatus.ToString();
            DERMSInterface.CIMData.header header = _cim.GetDERStatusHeader;
            this.endPointText.Text = header.EndPoint;
            this.messageTypeText.Text = "Get DER Status";
            this.replyAddressText.Text = header.ReplyAddress;
            this.userIDText.Text = header.UserID;
            this.organizationText.Text = header.UserOrganization;
            this.contextText.Text = header.Context;
            this.verbText.Text = header.Verb;
            this.ackRequiredCheck.Checked = header.AckRequired;
            this.commentText.Text = header.Comment;

            this.realRadio.Checked = true;


            DERMSInterface.CIMData.DERGroup group = _group;
            DERGroupNameText.Text = group.GroupName;
            DERGroupMRIDText.Text = group.Mrid;

        }

        // -----
        // value changed handlers
        // -----
        #region value changed event handlers
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

        private void DERGroupNameText_TextChanged(object sender, EventArgs e)
        {
            group.GroupName = ((TextBox)sender).Text;
        }

        private void DERGroupMRIDText_TextChanged(object sender, EventArgs e)
        {
            group.Mrid = ((TextBox)sender).Text;
        }
        #endregion
        // -----
        // end value changed handlers
        // -----
    }
}
