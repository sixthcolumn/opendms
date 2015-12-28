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
    public partial class ScadaInfoControl : UserControl
    {

        CIMData.SCADAInfo scada = new CIMData.SCADAInfo();
        DataGridView scadaDeviceView;

        public ScadaInfoControl()
        {
            InitializeComponent();
            this.Enabled = false;
        }


        public void setDeviceTypes(List<CIMData.DeviceType> devices)
        {
            List<String> deviceNames = new List<string>();
            foreach (var d in devices)
            {
                deviceNames.Add(d.Name);
            }
            typeCombo.Items.AddRange(deviceNames.ToArray<string>());
        }

        public System.Windows.Forms.TextBox FeederText
        {
            get { return feederText; }
            set { feederText = value; }
        }

        public System.Windows.Forms.TextBox MRIDText
        {
            get { return mridText; }
            set { mridText = value; }
        }

        public System.Windows.Forms.TextBox SubstationText
        {
            get { return substationText; }
            set { substationText = value; }
        }

        public System.Windows.Forms.TextBox NameText
        {
            get { return nameText; }
            set { nameText = value; }
        }

        public System.Windows.Forms.ComboBox TypeCombo
        {
            get { return typeCombo; }
            set { typeCombo = value; }
        }

        public System.Windows.Forms.ComboBox ProtocolCombo
        {
            get { return protocolCombo; }
            set { protocolCombo = value; }
        }

        public System.Windows.Forms.ComboBox LogLevelCombo
        {
            get { return logLevelCombo; }
            set { logLevelCombo = value; }
        }

        public void reset()
        {
            CIMData.SCADAInfo scada = new CIMData.SCADAInfo();
            this.Enabled = false;
            clear();
        }

        public void clear()
        {
                mridText.Text = "";
                nameText.Text = "";
                substationText.Text = "";
                feederText.Text = "";
                typeCombo.Text = "";
                protocolCombo.Text = "";
                descriptionText.Text = "";
                logLevelCombo.Text = "";
        }


        public void bindScadaRecord(CIMData.SCADAInfo row, DataGridView view)
        {
            this.scada = row;
            this.scadaDeviceView = view;
            mridText.Text = scada.Mrid;
            nameText.Text = scada.Name;
            substationText.Text = scada.Substation;
            feederText.Text = scada.Feeder;
            typeCombo.Text = scada.DeviceType;
            protocolCombo.Text = scada.Protocol;
            descriptionText.Text = scada.Description;
            logLevelCombo.Text = scada.LogLevel;
            this.Enabled = true;
        }

        private void mridText_TextChanged(object sender, EventArgs e)
        {
            scada.Mrid = ((TextBox)sender).Text;

        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            scada.Name = ((TextBox)sender).Text;
            if (scadaDeviceView != null)
                scadaDeviceView.Refresh();
        }


        private void substationText_TextChanged(object sender, EventArgs e)
        {
            scada.Substation = ((TextBox)sender).Text;
            if (scadaDeviceView != null)
                scadaDeviceView.Refresh();
        }

        private void feederText_TextChanged(object sender, EventArgs e)
        {
            scada.Feeder = ((TextBox)sender).Text;
            if (scadaDeviceView != null)
                scadaDeviceView.Refresh();
        }

        private void typeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            scada.DeviceType = ((ComboBox)sender).Text;
        }

        private void protocolCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            scada.Protocol = ((ComboBox)sender).Text;
        }

        private void logLevelCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            scada.LogLevel = ((ComboBox)sender).Text;
        }

        private void descriptionText_TextChanged(object sender, EventArgs e)
        {
            scada.Description = ((TextBox)sender).Text;
        }


    }
}
