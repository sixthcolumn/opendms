using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DERMSInterface;

namespace WindowsFormsApplication1
{
    public partial class DNP3BasicControl : UserControl
    {
        private CIMData.DNP _dnp = new CIMData.DNP();

        public DNP3BasicControl()
        {
            InitializeComponent();
            integrityScanText.KeyPress += numericVerify_KeyPress;
            saveIntervalText.KeyPress += numericVerify_KeyPress;
            this.Enabled = false;
        }

        public void clear()
        {
            ipAddressText.Text = "";
            remoteAddressText.Text = "";
            localAddressText.Text = "";
            portText.Text = "";
            integrityScanText.Text = "";
            saveIntervalText.Text = "";
            UnsolicitedCheck.Checked = false;
            EnableUnsolCheck.Checked = false;
            timeSyncCheck.Checked = false;
            useConfirmsCheck.Checked = false;
            tcpRadio.Checked = false;
            udpRadio.Checked = false;
            localRadio.Checked = false;
            remoteRadio.Checked = false;
            SBORadio.Checked = false;
            DORadio.Checked = false;
            doNoAckRadio.Checked = false;
            class0Check.Checked = false;
            Class1Check.Checked = false;
            class2Check.Checked = false;
            class3Check.Checked = false;
        }

        /// <summary>
        /// some fields are numeric only. This insures user does not enter text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericVerify_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// whenever a new row from the datagrid view (scada) is selected, this re-binds
        /// this form to the current row
        /// </summary>
        /// <param name="dnp"></param>
        public void bindDataSource(CIMData.DNP dnp)
        {
            // todo : For all numerics (timeouts, etc...), is there a default value, use 0, or null if not set?
            this._dnp = dnp;
            ipAddressText.Text = dnp.IPAddress;
            remoteAddressText.Text = dnp.RemoteAddress;
            localAddressText.Text = dnp.LocalAddress;
            portText.Text = dnp.Port;
            integrityScanText.Text = dnp.IntegrityScanRate;
            saveIntervalText.Text = dnp.SaveInterval;
            UnsolicitedCheck.Checked = dnp.IsUnsolictedOnStartup;
            EnableUnsolCheck.Checked = dnp.IsEnableUnsolicited;
            timeSyncCheck.Checked = dnp.IsTimeSync;
            useConfirmsCheck.Checked = dnp.IsUseConfirms;
            tcpRadio.Checked = (dnp.Transport == CIMData.DNP.transportEnum.TCP) ? true : false;
            udpRadio.Checked = (dnp.Transport == CIMData.DNP.transportEnum.UDP) ? true : false;
            localRadio.Checked = (dnp.Initiation == CIMData.DNP.initiationEnum.Local) ? true : false;
            remoteRadio.Checked = (dnp.Initiation == CIMData.DNP.initiationEnum.Remote) ? true : false;
            SBORadio.Checked = (dnp.Dnpfunction == CIMData.DNP.DNPFunctionEnum.SB0) ? true : false;
            DORadio.Checked = (dnp.Dnpfunction == CIMData.DNP.DNPFunctionEnum.D0 ? true : false);
            doNoAckRadio.Checked = (dnp.Dnpfunction == CIMData.DNP.DNPFunctionEnum.DO_NOACK) ? true : false;
            class0Check.Checked = dnp.Class0;
            Class1Check.Checked = dnp.Class1;
            class2Check.Checked = dnp.Class2;
            class3Check.Checked = dnp.Class3;
            this.Enabled = true;
        }

        private void ipAddressText_TextChanged(object sender, EventArgs e)
        {
            _dnp.IPAddress = ((TextBox)sender).Text;
        }

        private void remoteAddressText_TextChanged(object sender, EventArgs e)
        {
            _dnp.RemoteAddress = ((TextBox)sender).Text;
        }

        private void localAddressText_TextChanged(object sender, EventArgs e)
        {
            _dnp.LocalAddress = ((TextBox)sender).Text;
        }

        private void portText_TextChanged(object sender, EventArgs e)
        {
            _dnp.Port = ((TextBox)sender).Text;
        }

        public static int parseInt(string text)
        {
            try
            {
                if (text != null && text.Length > 0)
                    return Int32.Parse(text);
            }
            catch (FormatException)
            {
                Console.WriteLine("illegal format for numeric text box. value = " + text);
            }
            return 0;
        }

        private void integrityScanText_TextChanged(object sender, EventArgs e)
        {
            _dnp.IntegrityScanRate = ((TextBox)sender).Text;

        }

        private void saveIntervalText_TextChanged(object sender, EventArgs e)
        {
            _dnp.SaveInterval = ((TextBox)sender).Text;
        }

        private void UnsolicitedCheck_CheckedChanged(object sender, EventArgs e)
        {
            _dnp.IsUnsolictedOnStartup = ((CheckBox)sender).Checked;
        }

        private void EnableUnsolCheck_CheckedChanged(object sender, EventArgs e)
        {
            _dnp.IsEnableUnsolicited = ((CheckBox)sender).Checked;
        }

        private void class0Check_CheckedChanged(object sender, EventArgs e)
        {
            _dnp.Class0 = ((CheckBox)sender).Checked;
        }

        private void Class1Check_CheckedChanged(object sender, EventArgs e)
        {
            _dnp.Class1 = ((CheckBox)sender).Checked;
        }

        private void class2Check_CheckedChanged(object sender, EventArgs e)
        {
            _dnp.Class2 = ((CheckBox)sender).Checked;
        }

        private void class3Check_CheckedChanged(object sender, EventArgs e)
        {
            _dnp.Class3 = ((CheckBox)sender).Checked;
        }

        private void timeSyncCheck_CheckedChanged(object sender, EventArgs e)
        {
            _dnp.IsTimeSync = ((CheckBox)sender).Checked;
        }

        private void useConfirmsCheck_CheckedChanged(object sender, EventArgs e)
        {
            _dnp.IsUseConfirms = ((CheckBox)sender).Checked;
        }

        private void tcpRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                _dnp.Transport = CIMData.DNP.transportEnum.TCP;
        }

        private void udpRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                _dnp.Transport = CIMData.DNP.transportEnum.UDP;
        }

        private void SBORadio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                _dnp.Dnpfunction = CIMData.DNP.DNPFunctionEnum.SB0;
        }

        private void DORadio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                _dnp.Dnpfunction = CIMData.DNP.DNPFunctionEnum.D0;
        }

        private void doNoAckRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                _dnp.Dnpfunction = CIMData.DNP.DNPFunctionEnum.DO_NOACK;
        }

        private void localRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                _dnp.Initiation = CIMData.DNP.initiationEnum.Local;
        }

        private void remoteRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                _dnp.Initiation = CIMData.DNP.initiationEnum.Remote;
        }
    }
}
