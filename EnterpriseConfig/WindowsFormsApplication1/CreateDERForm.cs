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
        Boolean _editDER = false;
        Boolean _showXML = false;
        XMLForm _log = null;

        public CreateDERForm(DERMSInterface.CIMData cim, int row)
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

        private void createButton_Click(object sender, EventArgs e)
        {
            DERMSInterface.CIM cs = new DERMSInterface.CIM(_cim);
            if (_showXML == true)
                _log = new XMLForm();

            int rc = 0;
            try
            {
                rc = cs.createDERGroup(_cim.Groups[_row].GroupName, null);
                logBold("Return Code : " + rc.ToString() + Environment.NewLine + Environment.NewLine);
                MessageBox.Show("Return code : " + rc.ToString(), "Create DER", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            this.Close();
        }

        private void FormLoad(object sender, System.EventArgs e)
        {

            string DERGroupName = DERMSInterface.CIMData.operations.createDER.ToString();
            DERMSInterface.CIMData.header header = _cim.Headers.Find(x => x.Name.Equals(DERGroupName));
            if (header != null)
            {
                this.endPointText.Text = header.EndPoint;
                this.messageTypeText.Text = "Create DER";
                this.replyAddressText.Text = header.ReplyAddress;
                this.userIDText.Text = header.UserID;
                this.organizationText.Text = header.UserOrganization;
                this.contextText.Text = header.Context;
                this.verbText.Text = header.Verb;
                this.ackRequiredCheck.Checked = header.AckRequired;
                this.commentText.Text = header.Comment;
            }

            if (_row >= 0 && _cim.Groups.Count > _row)
            {



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


                bs = new BindingSource();
                bs.DataSource = group.Devices;
                DERView.DataSource = bs;
                bs.ResetBindings(false);

                group.Devices.ForEach(x =>
                {
                    deviceCount++;
                    realPower += x.WattCapacity;
                    reactivePower += x.VarCapacity;
                });

                if (group != null && group.Devices.Count > 0)
                {
                    DERView.ReadOnly = true;
                    DERGroupDeviceCountText.Enabled = false;
                    DERGroupRealText.Enabled = false;
                    DERGroupReactiveText.Enabled = false;
                }


                DERGroupDeviceCountText.Text = deviceCount.ToString();
                DERGroupRealText.Text = realPower.ToString();
                DERGroupReactiveText.Text = reactivePower.ToString();
            }
            if (_editDER == true)
                DERView.CellValueChanged += new DataGridViewCellEventHandler(CellValue_Changed);


        }

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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showXMLBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            _showXML = check.Checked;
        }

    }
}
