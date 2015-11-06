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
    public partial class GetDERStatusForm : Form
    {
        DERMSInterface.CIMData _cim = null;
        int _row = -1;
        Boolean _showXML = false;
        XMLForm _log = null;
        DERMSInterface.quantity _q;


        public GetDERStatusForm(DERMSInterface.CIMData cim, int row)
        {
            _cim = cim;
            _row = row;
            InitializeComponent();
        }

        private void log(string text)
        {
            if (_log != null)
                _log.addText(text);
        }

        private void logBold(string text)
        {
            if (_log != null)
                _log.addBoldText(text);
        }

        private void logShow()
        {
            if (_log != null)
                _log.Show();
        }


        public GetDERStatusForm()
        {
            InitializeComponent();
        }



        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            DERMSInterface.CIM cs = new DERMSInterface.CIM(_cim);
            if (_showXML == true)
                _log = new XMLForm();

            int rc = 0;

            try
            {
                DERMSInterface.CIMData.DERStatus reply = cs.getDERGroupStatus(_cim.Groups[_row].GroupName, _q);
                this.minValueText.Text = reply.PresentMinCapability.ToString();
                this.currentValueText.Text = reply.PresentValue.ToString();
                this.maxValueText.Text = reply.PresentMaxCapability.ToString();
                this.MRIDReturnText.Text = reply.Mrid;
                this.quantityText.Text = _q.ToString();
                logBold("Return Code : " + rc.ToString() + Environment.NewLine + Environment.NewLine);
                MessageBox.Show("Return code : " + rc.ToString(), "Get DER Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
            catch (Exception ex)
            {
                logBold("Exception...");
                log(ex.ToString());
            }
            finally
            {
                logBold("Message Sent..." + Environment.NewLine + Environment.NewLine);
                log(cs.LastMessageSent + Environment.NewLine + Environment.NewLine);
                logBold("Message Received..." + Environment.NewLine + Environment.NewLine);
                log(cs.LastMessageReceived + Environment.NewLine + Environment.NewLine);
            }
            logShow();
        }

        private void realRadio_CheckedChanged(object sender, EventArgs e)
        {
            _q = DERMSInterface.quantity.RealPower;
        }

        private void reactiveRadio_CheckedChanged(object sender, EventArgs e)
        {
            _q = DERMSInterface.quantity.Reactive;
        }

        private void GetDERStatusForm_Load(object sender, EventArgs e)
        {

            string DERGroupName = DERMSInterface.CIMData.operations.getDERStatus.ToString();
            DERMSInterface.CIMData.header header = _cim.Headers.Find(x => x.Name.Equals(DERGroupName));
            if (header != null)
            {
                this.endPointText.Text = header.EndPoint;
                this.messageTypeText.Text = "Get DER Status";
                this.replyAddressText.Text = header.ReplyAddress;
                this.userIDText.Text = header.UserID;
                this.organizationText.Text = header.UserOrganization;
                this.contextText.Text = header.Context;
                this.verbText.Text = header.Verb;
                this.ackRequiredCheck.Checked = header.AckRequired;
                this.commentText.Text = header.Comment;
            }

            this.realRadio.Checked = true;

            if (_row >= 0 && _cim.Groups.Count > _row)
            {

                DERMSInterface.CIMData.DERGroup group = _cim.Groups[_row];
                DERGroupNameText.Text = group.GroupName;
                DERGroupMRIDText.Text = group.Mrid;
                // TODO : we do not set count, reactive and total power values, they are derived    
            }
        }

        private void showXMLBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            _showXML = check.Checked;
        }


    }
}
