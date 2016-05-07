using RGiesecke.DllExport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DERMSInterface;


using Automatak.DNP3.Adapter;
using Automatak.DNP3.Interface;

namespace SCADAInterface
{
    public class SCADAIFace
    {
        private static CIMData _cim = new CIMData();
        private static bool _initialized = false;
        private static bool _config_file_loaded = false;
        

        public static ControlCode  DetermineOperationCode(string opstr)
        {
            if (opstr.Equals("Latch ON"))
            {
                return ControlCode.LATCH_ON;
            }
            else if (opstr.Equals("Latch OFF"))
            {
                return ControlCode.LATCH_OFF;
            } else if (opstr.Equals("Pulse ON"))
            {
                return ControlCode.PULSE_ON;
            } if (opstr.Equals("Pulse OFF"))
            {
                return ControlCode.PULSE_OFF;
            }

            // default
            return ControlCode.NUL;
        }

        public static void TestDevice(CIMData.SCADAInfo scadaDev)
        {
            _cim.Scada.Add(scadaDev);   // add to structure for testing
            InitDeviceConnection(scadaDev);
        }

        private static CIMData.SCADAInfo findDevice(string mrid)
        {

            foreach (var dv in _cim.Scada)
            {
                if (dv.Mrid.Equals(mrid))
                {
                    return dv;
                }
            }

            return null;
        }

        public static void OperateDevice(string mrid, string operation, ushort point_index)
        {
            CIMData.SCADAInfo dv = findDevice(mrid);
            
            if (dv == null)
            {
                Console.WriteLine("Error - device: " + mrid + " is not in the list of devices.   Be sure to start polling before controls are issued!");
            } else if (dv.Connected != true)
            {
                Console.WriteLine("Error - cannot operate device until while it is not connected");
            } else
            {
                var crob = new ControlRelayOutputBlock(DetermineOperationCode(operation), 1, 100, 100);
                var single = dv.Master.SelectAndOperate(crob, point_index, TaskConfig.Default);
                single.ContinueWith((result) => Console.WriteLine("Result: " + result.Result));
            }

        }

        public static void InitDeviceConnection(CIMData.SCADAInfo scadaDev)
        {
            IDNP3Manager mgr = DNP3ManagerFactory.CreateManager(1);
            //mgr.AddLogHandler(PrintingLogAdapter.Instance); //this is optional
            UInt16 sport = Convert.ToUInt16(scadaDev.Dnp.Port);

           scadaDev.Channel = mgr.AddTCPClient(scadaDev.Name, LogLevels.ALL, ChannelRetry.Default, scadaDev.Dnp.IPAddress, sport);
 
            //optionally, add a listener for the channel state
            scadaDev.Channel.AddStateListener(state => Console.WriteLine("channel state: " + state + " for dev: " + scadaDev.Name + " addr: " + scadaDev.Dnp.IPAddress));

            var config = new MasterStackConfig();

            //setup your stack configuration here.
            UInt16 laddr = Convert.ToUInt16(scadaDev.Dnp.LocalAddress);
            UInt16 raddr = Convert.ToUInt16(scadaDev.Dnp.RemoteAddress);

            config.link.localAddr = laddr;
            config.link.remoteAddr = raddr;

            var key = new byte[16];
            for (int i = 0; i < key.Length; ++i)
            {
                key[i] = 0xFF;
            }

            HandleSOEData hse = new HandleSOEData(scadaDev);

           scadaDev.Master = scadaDev.Channel.AddMaster("master", hse.getInstance(), DefaultMasterApplication.Instance, config);

            // you a can optionally add various kinds of polls
            var integrityPoll = scadaDev.Master.AddClassScan(ClassField.AllClasses, TimeSpan.FromMinutes(1), TaskConfig.Default);

            scadaDev.Master.Enable();

            scadaDev.Connected = true;
        }


        [DllExport("LoadScadaConfigFile", CallingConvention = CallingConvention.Cdecl)]
        public static void loadScadaConfigFile([MarshalAs(UnmanagedType.LPTStr)] String path)
        {
           Console.WriteLine("loading config file : " + path);

            _cim = DERMSInterface.CIMData.read(path);

            // SCADAIFace._config_file_loaded = true;
        }


        [DllExport("ScadaInit", CallingConvention = CallingConvention.Cdecl)]
        public static int Init()
        {
            if (!SCADAIFace._config_file_loaded)
            {
                // TODO:: add error message
                Console.WriteLine("Error - Init called, but config file not loaded");
                return 1;
            }

           // loop over all devices, start polling data for each
            foreach (var dev in _cim.Scada)
            {
                // call init
                InitDeviceConnection(dev);
            }

            SCADAIFace._initialized = true;
            return 0;
        }


        [DllExport("ReadMeter", CallingConvention = CallingConvention.Cdecl)]
        public static string ReadMeter(string site_name)
        {
            if (!SCADAIFace._initialized)
            {
                //TODO add error message
                Console.WriteLine("Error:  ReadMeter() called but system has not been initialized");
                return null;
            }

            return ReadDevice(site_name);
        }

        private static string ReadDevice(string mrid)
        {
            CIMData.SCADAInfo dv = findDevice(mrid);

            if (dv == null)
            {
                Console.WriteLine("Error - device: " + mrid + " is not in the list of devices.   Be sure to start polling before controls are issued!");
            }
            else if (dv.Connected != true)
            {
                Console.WriteLine("Error - cannot operate device until while it is not connected");
            }
            else
            {
                System.IO.StringWriter s = new System.IO.StringWriter();
                System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(CIMData.SCADAInfo));
                writer.Serialize(s, dv);
                return s.ToString();
            }

            return null;
        }

        [DllExport("CapControl", CallingConvention = CallingConvention.Cdecl)]
        public static string CapControl(string site_name, int cap_state)
        {
            if (!SCADAIFace._initialized)
            {
                //TODO add error message
                return null;
            }
            // validate cap_state value
            // find correct command index
            // send control command
            return null;
        }

        [DllExport("ReadCapData", CallingConvention = CallingConvention.Cdecl)]
        public static string ReadCapData(string site_name)
        {
            if (!SCADAIFace._initialized)
            {
                //TODO add error message
                return null;
            }

            return ReadDevice(site_name);
        }

        [DllExport("RegControl", CallingConvention = CallingConvention.Cdecl)]
        public static string RegControl(string site_name, int reg_tap_control)
        {
            if (!SCADAIFace._initialized)
            {
                //TODO add error message
                return null;
            }
            // validate reg_tap_control value
            // find matching entry in device list
            // send control command
            return null;
        }

        [DllExport("ReadRegData", CallingConvention = CallingConvention.Cdecl)]
        public static string ReadRegData(string site_name)
        {
            if (!SCADAIFace._initialized)
            {
                //TODO add error message
                return null;
            }

            return ReadDevice(site_name);
        }

    }
}
