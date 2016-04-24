using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DERMSInterface;

using SCADAInterface;
using Automatak.DNP3.Interface;


namespace WindowsFormsApplication1
{
    public partial class TestScadaControl : UserControl
    {

        private CIMData.SCADAInfo scada = null;
        private List<ControlPointGroup> _cgs = null;

        public TestScadaControl()
        {
            InitializeComponent();
        }

        private void TestScadaControl_Load(object sender, EventArgs e)
        {
            Console.WriteLine(" in testscada control load");

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Console.Write("Polling should start now");
            if (scada.Connected)
            {
                //TODO add stop polling code
            }
            else
            {
                SCADAIFace.TestDevice(scada);
            }

             if (scada.Connected)
             {
                 button1.Text = "Stop Polling";
             }
             else
             {
                 button1.Text = "Start Polling";

             }

             // start thread to update values on start
            // stop thread on stop
            Thread uthread = new Thread(new ThreadStart(this.updateListBox));
            uthread.Start();

        }

        public void updateListBox()
        {
            while (true)
            {
                // clear list box
                // add points
                MethodInvoker inv = delegate
                {
                    listBox1.Items.Clear();

                    foreach (var cp in scada.Dnp.Analog_input_points)
                    {
                        // create string
                        string tmps = cp.Name + " : " + cp.Pvalue + " : " + cp.Descr;
                        listBox1.Items.Add(tmps);
                    }
                };
                this.Invoke(inv);

                System.IO.StringWriter s = new System.IO.StringWriter();
                System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(CIMData.SCADAInfo));
                writer.Serialize(s, scada);

                //Console.WriteLine(s.ToString());

                Thread.Sleep(5000);
            }
        }

        public void bindDataSource(CIMData.SCADAInfo scada)
        {
            this.scada = scada;

            changeGroupControls();
        }

        public void changeGroupControls()
        {

            /*
            TODO - build control groups
             *     clear point list
             *     set polling button state
             * */

            SuspendLayout();

            if (_cgs != null)
            {
                foreach (var cpd in _cgs)
                {
                    if (flowLayoutPanel1.Controls.Contains(cpd))
                    {
                        flowLayoutPanel1.Controls.Remove(cpd);
                        cpd.Dispose();
                    }
                }
            }

            if ((scada == null) || (scada.Dnp.Control_points == null))
            {
                // change to popup - 
                Console.WriteLine("a device type must be selected!");
                return;
            }

            this._cgs = new List<ControlPointGroup>(scada.Dnp.Control_points.Count);

            // create radio controls
            foreach (var cp in scada.Dnp.Control_points)
            {
                ControlPointGroup cg = new ControlPointGroup(cp.Name);
                cg.PName = cp.Name;

                cg.CommandIndex = cp.Pindex;
                cg.Device_mrid = scada.Mrid;                
                _cgs.Add(cg);
                flowLayoutPanel1.Controls.Add(cg);
            }

            ResumeLayout();

            Invalidate();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string devfile = "twodevtest.xml";
            SCADAIFace.loadConfigFile(ref devfile);

            SCADAIFace.Init();

        }
    }
}
