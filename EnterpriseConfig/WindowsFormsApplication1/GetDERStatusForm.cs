﻿using System;
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
        int _row = -1;
        XMLForm _log = null;
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
            get { return _cim.Groups[_row]; }
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="cim">CIMData object</param>
        /// <param name="row">currently selected DERGroup row</param>
        public GetDERStatusForm(DERMSInterface.CIMData cim, int row)
        {
            _cim = cim;
            _row = row;
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
            int rc = 1;

            try
            {
                _log = new XMLForm();

                // call SOAP function
                DERMSInterface.CIMData.DERStatus reply = cs.getDERGroupStatus(_cim.Groups[_row].Mrid, _q);

                // load screen with return values from call
                this.minValueText.Text = reply.PresentMinCapability.ToString();
                this.currentValueText.Text = reply.PresentValue.ToString();
                this.maxValueText.Text = reply.PresentMaxCapability.ToString();
                this.MRIDReturnText.Text = reply.Mrid;
                this.quantityText.Text = _q.ToString();
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

            if (_row >= 0 && _cim.Groups.Count > _row)
            {

                DERMSInterface.CIMData.DERGroup group = _cim.Groups[_row];
                DERGroupNameText.Text = group.GroupName;
                DERGroupMRIDText.Text = group.Mrid;
                // TODO : we do not set count, reactive and total power values, they are derived    
            }
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