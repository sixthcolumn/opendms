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
        List<CIMData.DeviceType> _devices;
        TestScadaControl _test_control;

        public ScadaInfoControl()
        {
            InitializeComponent();
            this.Enabled = false;
        }

        public void setTestControls(TestScadaControl testcontrol)
        {
            _test_control = testcontrol;
        }


        public void setDeviceTypes(List<CIMData.DeviceType> devices)
        {
            List<String> deviceNames = new List<string>();
            foreach (var d in devices)
            {
                deviceNames.Add(d.Name);
            }
            typeCombo.Items.AddRange(deviceNames.ToArray<string>());
            _devices = devices;  // keep a copy to build the points from list later
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
            //TODO:  find entry in _devices, create point arrays for this device

            foreach (var dt in _devices)
            {
                if (dt.Name.Equals(scada.DeviceType))
                {
                    Console.WriteLine("found match: " + dt.Name);

                    // allocate arrays
                    scada.Dnp.Analog_input_points = new List<CIMData.DNP.DNP3PointValue<double>>();
                    scada.Dnp.Analog_output_points = new List<CIMData.DNP.DNP3PointValue<double>>();
                    scada.Dnp.Control_points = new List<CIMData.DNP.DNP3PointValue<bool>>();
                    scada.Dnp.Counter_points = new List<CIMData.DNP.DNP3PointValue<uint>>();
                    scada.Dnp.Binary_input_points = new List<CIMData.DNP.DNP3PointValue<bool>>();

                    // copy over points
                    foreach (var pp in dt.Protocols)
                    {
                        // TODO add check for DNP3
                        foreach (var pd in pp.DNP3PointDefinitions)
                        {
                            foreach (var ppd in pd.DNP3PointList)
                            {
                                if (pd.DNP3TypeName.Equals("AnalogInput")) 
                                {
                                    scada.Dnp.Analog_input_points.Add(new CIMData.DNP.DNP3PointValue<double> { Name = ppd.DNP3PointName, Pindex = ppd.DNP3PointNum, Descr = ppd.DNP3PointDesc });

                                } else if (pd.DNP3TypeName.Equals("AnalogOutput")) 
                                {
                                    scada.Dnp.Analog_output_points.Add(new CIMData.DNP.DNP3PointValue<double> { Name = ppd.DNP3PointName, Pindex = ppd.DNP3PointNum, Descr = ppd.DNP3PointDesc });

                                } else if (pd.DNP3TypeName.Equals("Control"))  
                                {
                                    scada.Dnp.Control_points.Add(new CIMData.DNP.DNP3PointValue<bool> { Name = ppd.DNP3PointName, Pindex = ppd.DNP3PointNum, Descr = ppd.DNP3PointDesc });

                                } else if (pd.DNP3TypeName.Equals("BinaryInput")) 
                                {
                                    scada.Dnp.Binary_input_points.Add(new CIMData.DNP.DNP3PointValue<bool> { Name = ppd.DNP3PointName, Pindex = ppd.DNP3PointNum, Descr = ppd.DNP3PointDesc });

                                }
                                else if (pd.DNP3TypeName.Equals("Counter"))
                                {
                                    scada.Dnp.Counter_points.Add(new CIMData.DNP.DNP3PointValue<uint> { Name = ppd.DNP3PointName, Pindex = ppd.DNP3PointNum, Descr = ppd.DNP3PointDesc });
                                }
                                else
                                {
                                    Console.WriteLine("Error when setting up DNP3 points, unknown point type: " + pd.DNP3TypeName);
                                }

                            }
                        }
                    }

                    // TODO change out control group objects
                    _test_control.changeGroupControls();
                    break;
                }


            }
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
