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

    public class PollHelper
    {
        private CIMData.SCADAInfo myDev = null;
        private bool stopFlag = false;
        private ChannelState chState;
        TestScadaControl th = null;
        Thread uthread = null;

        public PollHelper(CIMData.SCADAInfo dev, TestScadaControl tcontrol)
        {
            myDev = dev;
            th = tcontrol;
        }

        public ChannelState ChannelState
        {
            get { return chState; }
            set { chState = value; }
        }

        public bool isPolling()
        {
            if ((myDev != null) && myDev.Connected)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void updateDisplay()
        {
            while (!stopFlag)
            {
                th.updateListView(getMRID());

                Thread.Sleep(5000);
            }
            Console.WriteLine("stopping polling for " + getMRID());

        }

        public void startPolling()
        {
            // start thread, update state
            stopFlag = false;

            uthread = new Thread(new ThreadStart(this.updateDisplay));
            uthread.Start();
        }

        public void stopPolling()
        {
            if (!isPolling())
            {
                Console.WriteLine("Nothing to do, device: " + myDev.Name + " was not polling");
            }
            else
            {
                // kill thread
                stopFlag = true;
                // update state

                myDev.Master.Disable();
             //   myDev.Channel.Shutdown();
             //   myDev.Channel = null;
                myDev.Connected = false;
            }
        }

        public string getMRID()
        {
            if (myDev != null)
            {
                return myDev.Mrid;
            }

            return null;
        }

        public void logConnectionStatus(String mrid, ChannelState state)
        {
            // find match
            if (getMRID().Equals(mrid))
            {
                string tmps = "channel state: " + state + " for dev: " + myDev.Name + " addr: " + myDev.Dnp.IPAddress;
                th.updateState(tmps);
                chState = state;
            }
        }
    }

    public partial class TestScadaControl : UserControl
    {

        private CIMData.SCADAInfo scada = null;
        private List<ControlPointGroup> _cgs = null;
        public List<PollHelper> _phelpers = new List<PollHelper>();

        public TestScadaControl()
        {
            InitializeComponent();
        }

        public void updateState(string tmps)
        {
            MethodInvoker inv = delegate
            {
                
                label1.Text = tmps;
                //listBox2.Items.Add(tmps);
            };
            this.Invoke(inv);
        }

        PollHelper findPollingHelper(string mrid)
        {
            foreach (var ph in _phelpers)
            {
                if (ph.getMRID().Equals(mrid)) 
                {
                    return ph;
                }
            }

            return null;
        }

        private void TestScadaControl_Load(object sender, EventArgs e)
        {
            Console.WriteLine(" in testscada control load");

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Console.Write("Polling should start now");
            // find polling helper
            PollHelper ph = findPollingHelper(scada.Mrid);

            if ((ph != null) && ph.isPolling()) // this code is never actually called now
            {
                //TODO add stop polling code
                ph.stopPolling();
                button1.Enabled = true;
            }
            else
            {
                // find/create polling helper, call start
                if (ph == null)
                {
                    ph = new PollHelper(scada, this);
                    _phelpers.Add(ph);
                }
                SCADAIFace.TestDevice(scada);
                scada.Channel.AddStateListener(state => ph.logConnectionStatus(scada.Mrid, state));
                ph.startPolling();

                button1.Enabled = false;
            }

             
             // start thread to update values on start
            // stop thread on stop
            

        }



        public void updateListView(string mrid)
        {
            if (mrid == null) {
                MethodInvoker inv = delegate
                {
                    listView1.Items.Clear();
                };
                this.Invoke(inv);

            } else if (mrid.Equals(scada.Mrid))
            {

                MethodInvoker inv = delegate
                {
                    listView1.Items.Clear();

                    listView1.Items.Add(new ListViewItem(new string[] { "ANALOG INPUTS ", "", "_____________" }));
                    foreach (var cp in scada.Dnp.Analog_input_points)
                    {
                        // create string
                        listView1.Items.Add(new ListViewItem(new string[] { cp.Name, cp.Pvalue.ToString(), cp.Descr }));
                        /*
                        string tmps = string.Format("    {0,-12}  :  {1,-12}   :  {2,-15}", 
                             cp.Name, cp.Pvalue.ToString(), cp.Descr);
                        listView1.Items.Add(tmps);
                         * */
                    }

                    if (scada.Dnp.Binary_input_points.Count > 0)
                    {
                        listView1.Items.Add(new ListViewItem(new string[] { "Binary INPUTS", "", "_____________" }));
                    }
                    foreach (var cp in scada.Dnp.Binary_input_points)
                    {
                        // create string
                        listView1.Items.Add(new ListViewItem(new string[] { cp.Name, cp.Pvalue.ToString(), cp.Descr }));

                    }
                };
                this.Invoke(inv);

                /*
                System.IO.StringWriter s = new System.IO.StringWriter();
                System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(CIMData.SCADAInfo));
                writer.Serialize(s, scada);
                 */

                //Console.WriteLine(s.ToString());
            }

        }

        public void bindDataSource(CIMData.SCADAInfo scada)
        {
            this.scada = scada;

            changeGroupControls();

            // clear listbox
            updateListView(scada.Mrid);

            PollHelper ph = findPollingHelper(scada.Mrid);

            // clear state
            if (ph != null)
            {
                ph.logConnectionStatus(scada.Mrid, ph.ChannelState);
            }
            else
            {
                updateState("current state: CLOSED");
            }
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     }
}
