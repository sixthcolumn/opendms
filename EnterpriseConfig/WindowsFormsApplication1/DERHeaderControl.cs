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
    public partial class DERHeaderControl : UserControl
    {
        // the loadHeader is the 'init' method. It saves the CIM passed
        // as a local for further access
        DERMSInterface.CIMData _cim;

        public DERHeaderControl()
        {
            InitializeComponent();
        }

        public void bindDataSource(DERMSInterface.CIMData cim)
        {
            _cim = cim;
            string name = messageTypeCombo.Text;
            loadHeader();
        }

        private void loadHeader() {
            string name = messageTypeCombo.Text;

            DERMSInterface.CIMData.header h = getHeader(name);
            endPointText.Text = h.EndPoint;
            replyAddressText.Text = h.ReplyAddress;
            ackRequiredCheck.Checked = h.AckRequired;
            // hardcoded!
            setDefaultVerb(h, h.Name);
            nounText.Text = h.Noun = h.Noun;

            userIDText.Text = h.UserID;
            organizationText.Text = h.UserOrganization;
            contextText.Text = h.Context;
            commentText.Text = h.Comment;

            majorVersionText.Text = _cim.Version.Major;
            minorVersionText.Text = _cim.Version.Minor;
            revVersionText.Text = _cim.Version.Revision;
            if (_cim.Version.Date < dateVersionPicker.MinDate)
                dateVersionPicker.Value = System.DateTime.Now;
            else
                dateVersionPicker.Value = _cim.Version.Date;
        }


        // convenience function to return correct verb based on message type
        public void setDefaultVerb(DERMSInterface.CIMData.header h, String name)
        {
            if (name.Equals("createDER") || name.Equals("dispatchDER"))
                verbText.Text = h.Verb = "create";
            else if (name.Equals("getDER") || name.Equals("getDERStatus"))
                verbText.Text = h.Verb =  "get";
        }

        public void setDefaultVerb(DERMSInterface.CIMData.header h)
        {
            setDefaultVerb(h, messageTypeCombo.Text);
        }

        /// <summary>
        /// retrieves correct header based on name. If that header doesn't currently exist
        /// in memory, intializes it
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
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

        // -----
        // Text Changed events
        // -----
        #region value changed event handlers
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

        private void nounText_TextChanged(object sender, EventArgs e)
        {
            getHeader(messageTypeCombo.Text).Noun = ((TextBox)sender).Text;
        }


        private void minorVersionText_TextChanged(object sender, EventArgs e)
        {
            _cim.Version.Minor = ((TextBox)sender).Text;
        }

        private void dateVersionPicker_ValueChanged(object sender, EventArgs e)
        {
            _cim.Version.Date = ((DateTimePicker)sender).Value;
        }

        private void majorVersionText_TextChanged(object sender, EventArgs e)
        {
            _cim.Version.Major = ((TextBox)sender).Text;
        }

        private void revVersionText_TextChanged(object sender, EventArgs e)
        {
            _cim.Version.Revision = ((TextBox)sender).Text;
        }

        private void messageTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadHeader();
        }
        #endregion




        // -----
        // end text change event handlers
        // -----
    }
}
