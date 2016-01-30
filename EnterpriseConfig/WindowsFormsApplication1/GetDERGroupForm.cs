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
    public partial class GetDERGroupForm : Form
    {
        DERMSInterface.CIMData _cim = null;
        DERMSInterface.CIMData.DERGroup _group = null;
        XMLForm _log = null;
        string _key = DERMSInterface.CIMData.operations.createDER.ToString();

        /// <summary>
        /// convenience function to get the dispatch der header
        /// </summary>
        private DERMSInterface.CIMData.header header
        {
            get { return _cim.GetDERHeader; }
        }

        /// <summary>
        /// convenience function. Gets the currently selected DER group
        /// </summary>
        private DERMSInterface.CIMData.DERGroup group
        {
            get { return _group; }
        }

        /// <summary>
        ///  constructor, do not call this one
        /// </summary>
        public GetDERGroupForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="cim">the config object</param>
        /// <param name="row">the currently selected der group</param>
        public GetDERGroupForm(DERMSInterface.CIMData cim, DERMSInterface.CIMData.DERGroup group)
        {
            _cim = cim;
            _group = group;
            InitializeComponent();
        }

        /// <summary>
        /// call SOAP function get DER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getButton_Click(object sender, EventArgs e)
        {
            DERMSInterface.CIM cs = new DERMSInterface.CIM(_cim);

            try
            {
                // call SOAP Get DER
                string[] results = cs.requestDERGroupMembers(_group.Mrid);

                // takes list of DER members, add new lines and display to our result text box
                System.Text.StringBuilder buffer = new StringBuilder();
                if (results != null)
                {
                    foreach (string s in results)
                        buffer.Append(s + Environment.NewLine);
                }
                this.resultText.Text = buffer.ToString();

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
        /// initializes the form, filling in the values of all the widgets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetDERGroupForm_Load(object sender, System.EventArgs e)
        {
            _log = new XMLForm();
            string DERGroupName = DERMSInterface.CIMData.operations.getDER.ToString();
            DERMSInterface.CIMData.header header = _cim.GetDERHeader;
            this.endPointText.Text = header.EndPoint;
            this.messageTypeText.Text = "Dispatch DER";
            this.replyAddressText.Text = header.ReplyAddress;
            this.userIDText.Text = header.UserID;
            this.organizationText.Text = header.UserOrganization;
            this.contextText.Text = header.Context;
            this.verbText.Text = header.Verb;
            this.ackRequiredCheck.Checked = header.AckRequired;
            this.commentText.Text = header.Comment;
            DERGroupMRIDText.Text = group.Mrid;
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

        // -----
        // form widget change handlers
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

        private void commentText_TextChanged(object sender, EventArgs e)
        {
            header.Comment = ((TextBox)sender).Text;
        }

        private void ackRequiredCheck_CheckedChanged(object sender, EventArgs e)
        {
            header.AckRequired = ((CheckBox)sender).Checked;
        }

        private void DERGroupMRIDText_TextChanged(object sender, EventArgs e)
        {
            group.Mrid = ((TextBox)sender).Text;
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            group.GroupName = ((TextBox)sender).Text;
        }
        #endregion
        // -----
        // END form widget change handlers
        // -----
    }
}
