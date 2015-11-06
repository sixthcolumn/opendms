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
        int _row = -1;
        Boolean _showXML = false;
        XMLForm _log = null;
        DERMSInterface.quantity _q;

        public DispatchDERForm()
        {
            InitializeComponent();
        }

        public DispatchDERForm(DERMSInterface.CIMData cim, int row)
        {
            _cim = cim;
            _row = row;
            InitializeComponent();
        }

        private void dispatchButton_Click(object sender, EventArgs e)
        {

        }

        private void DispatchDERForm_Load(object sender, System.EventArgs e)
        {
            string DERGroupName = DERMSInterface.CIMData.operations.dispatchDER.ToString();
            DERMSInterface.CIMData.header header = _cim.Headers.Find(x => x.Name.Equals(DERGroupName));
            if (header != null)
            {
                this.endPointText.Text = header.EndPoint;
                this.messageTypeText.Text = "Dispatch DER";
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
                DERGroupMRIDText.Text = group.Mrid;
                realValueText.Text = group.getWattCapacity().ToString();
                reactiveValueText.Text = group.getVarCapacity().ToString();
                // TODO : we do not set count, reactive and total power values, they are derived    
            }
        }

        private void realRadio_CheckedChanged(object sender, EventArgs e)
        {
            _q = DERMSInterface.quantity.RealPower;
        }

        private void reactiveRadio_CheckedChanged(object sender, EventArgs e)
        {
            _q = DERMSInterface.quantity.Reactive;
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
