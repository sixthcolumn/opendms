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
    public partial class DNP3Advanced : UserControl
    {
        CIMData.DNP dnp;

        public DNP3Advanced()
        {
            InitializeComponent();
            maxFragSizeText.KeyPress += numericVerify_KeyPress;
            frameRetriesText.KeyPress += numericVerify_KeyPress;
            ResponseTimeoutText.KeyPress += numericVerify_KeyPress;
            fragSizeText.KeyPress += numericVerify_KeyPress;
            taskRetryRateText.KeyPress += numericVerify_KeyPress;
            linkRetriesText.KeyPress += numericVerify_KeyPress;
            confirmTimeoutText.KeyPress += numericVerify_KeyPress;
            taskRetryRateText.KeyPress += numericVerify_KeyPress;
            this.Enabled = false;
        }

        public void clear()
        {
            maxFragSizeText.Text = "";
            frameRetriesText.Text = "";
            ResponseTimeoutText.Text = "";
            fragSizeText.Text = "";
            taskRetryRateText.Text = "";
            linkRetriesText.Text = "";
            confirmTimeoutText.Text = "";
            taskRetryRateText.Text = "";
        }

        public void reset()
        {
            dnp = new CIMData.DNP();
            bindDNPData(dnp);
            clear();
            this.Enabled = false;
        }

        /// <summary>
        /// whenever a new row from the datagrid view (scada) is selected, this re-binds
        /// this form to the current row
        /// </summary>
        /// <param name="dnp"></param>
        public void bindDNPData(CIMData.DNP dnp)
        {
            // todo : For all numerics (timeouts, etc...), is there a default value, use 0, or null if not set?
            this.dnp = dnp;

            maxFragSizeText.Text = dnp.MaxFragSize.ToString();
            frameRetriesText.Text = dnp.FrameRetries.ToString();
            ResponseTimeoutText.Text = dnp.ResponseTimeout.ToString();
            fragSizeText.Text = dnp.FragSize.ToString();
            taskRetryRateText.Text = dnp.TaskRetryRate.ToString();
            linkRetriesText.Text = dnp.NumRetries.ToString();
            confirmTimeoutText.Text = dnp.ConfirmationTimeout.ToString();
            taskRetryRateText.Text = dnp.RetryTimeout.ToString();
            this.Enabled = true;
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

        private void maxFragSizeText_TextChanged(object sender, EventArgs e)
        {
            dnp.MaxFragSize = ((TextBox)sender).Text;
        }

        private void frameRetriesText_TextChanged(object sender, EventArgs e)
        {
            dnp.FrameRetries = ((TextBox)sender).Text;
        }

        private void ResponseTimeoutText_TextChanged(object sender, EventArgs e)
        {
            dnp.ResponseTimeout = ((TextBox)sender).Text;
        }

        private void fragSizeText_TextChanged(object sender, EventArgs e)
        {
            dnp.FragSize = ((TextBox)sender).Text;
        }

        private void taskRetryRateText_TextChanged(object sender, EventArgs e)
        {
            dnp.TaskRetryRate = ((TextBox)sender).Text;
        }

        private void linkRetriesText_TextChanged(object sender, EventArgs e)
        {
            dnp.NumRetries = ((TextBox)sender).Text;
        }

        private void confirmTimeoutText_TextChanged(object sender, EventArgs e)
        {
            dnp.ConfirmationTimeout = ((TextBox)sender).Text;
        }

        private void physicalRetriesText_TextChanged(object sender, EventArgs e)
        {
            dnp.RetryTimeout = ((TextBox)sender).Text;
        }
    }
}
