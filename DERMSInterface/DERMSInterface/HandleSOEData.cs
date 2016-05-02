

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automatak.DNP3;
using DERMSInterface;


namespace Automatak.DNP3.Interface
{

    /// <summary>
    /// Singleton that prints all received values to the console.
    /// </summary>
    public class HandleSOEData : ISOEHandler
    {
        private static readonly ISOEHandler instance = new HandleSOEData(null);
        private DERMSInterface.CIMData.SCADAInfo _scadaDev = null;

        public static ISOEHandler Instance
        {
            get
            {
                return instance;
            }
        }

        public ISOEHandler getInstance() { return this; }

        public HandleSOEData(DERMSInterface.CIMData.SCADAInfo scadaDev)
        {
            Console.WriteLine("handleSOEData.instance");
            _scadaDev = scadaDev;
        }

        void ISOEHandler.Start()
        {}

        void ISOEHandler.End()
        {}

        private static void PrintHeaderInfo(HeaderInfo info)
        {
            Console.WriteLine(String.Format("Header: {0} : {1} : timestamps {2}", info.variation, info.qualifier, info.tsmode));
        }

        void ISOEHandler.Process(HeaderInfo info, IEnumerable<IndexedValue<Binary>> values)
        {
            foreach(var pair in values)
            {
                Print(pair.Value, pair.Index);
            }
        }

        void ISOEHandler.Process(HeaderInfo info, IEnumerable<IndexedValue<DoubleBitBinary>> values)
        {
            foreach (var pair in values)
            {
                Print(pair.Value, pair.Index);
            }
        }

        void ISOEHandler.Process(HeaderInfo info, IEnumerable<IndexedValue<Analog>> values)
        {
            DateTime utcNow = DateTime.UtcNow;
            DateTime localNow = DateTime.Now;

            foreach (var pair in values)
            {
                Print(pair.Value, pair.Index);
                foreach (var pv in _scadaDev.Dnp.Analog_input_points)
                {
                    if (pv.Pindex+1 == pair.Index)
                    {
                        pv.Pvalue = pair.Value.Value;
                        pv.Last_updated_tstamp = utcNow.ToString() + ", " + utcNow.Kind;

                    }
                }
            }
        }

        void ISOEHandler.Process(HeaderInfo info, IEnumerable<IndexedValue<Counter>> values)
        {

            DateTime utcNow = DateTime.UtcNow;
            DateTime localNow = DateTime.Now;
            foreach (var pair in values)
            {
                Print(pair.Value, pair.Index);

                foreach (var pv in _scadaDev.Dnp.Counter_points)
                {
                    if (pv.Pindex+1 == pair.Index)
                    {
                        pv.Pvalue = pair.Value.Value;
                        pv.Last_updated_tstamp = utcNow.ToString() + ", " + utcNow.Kind;

                    }
                }
            }
        }

        void ISOEHandler.Process(HeaderInfo info, IEnumerable<IndexedValue<FrozenCounter>> values)
        {
            foreach (var pair in values)
            {
                Print(pair.Value, pair.Index);
            }
        }

        void ISOEHandler.Process(HeaderInfo info, IEnumerable<IndexedValue<BinaryOutputStatus>> values)
        {

            DateTime utcNow = DateTime.UtcNow;
            DateTime localNow = DateTime.Now;

            foreach (var pair in values)
            {
                Print(pair.Value, pair.Index);
                foreach (var pv in _scadaDev.Dnp.Status_points)
                {
                    if (pv.Pindex+1 == pair.Index)
                    {
                        pv.Pvalue = pair.Value.Value;
                        pv.Last_updated_tstamp = utcNow.ToString() + ", " + utcNow.Kind;

                    }
                }
            }
        }

        void ISOEHandler.Process(HeaderInfo info, IEnumerable<IndexedValue<AnalogOutputStatus>> values)
        {
            foreach (var pair in values)
            {
                Print(pair.Value, pair.Index);
                DateTime utcNow = DateTime.UtcNow;
                DateTime localNow = DateTime.Now;
                // find value and set it
                foreach (var pv in _scadaDev.Dnp.Analog_output_points)
                {
                    if (pv.Pindex+1 == pair.Index)
                    {
                        pv.Pvalue = pair.Value.Value;
                        pv.Last_updated_tstamp = utcNow.ToString() + ", " + utcNow.Kind;

                    }
                }
            }
        }

        void ISOEHandler.Process(HeaderInfo info, IEnumerable<IndexedValue<OctetString>> values)
        {
            foreach (var pair in values)
            {
                Print(pair.Value, pair.Index);
            }
        }

        void ISOEHandler.Process(HeaderInfo info, IEnumerable<IndexedValue<TimeAndInterval>> values)
        {
            foreach (var pair in values)
            {
                Print(pair.Value, pair.Index);
            }
        }

        void ISOEHandler.Process(HeaderInfo info, IEnumerable<IndexedValue<BinaryCommandEvent>> values)
        {
            foreach (var pair in values)
            {
                Print(pair.Value, pair.Index);
            }
        }

        void ISOEHandler.Process(HeaderInfo info, IEnumerable<IndexedValue<AnalogCommandEvent>> values)
        {
            foreach (var pair in values)
            {
                Print(pair.Value, pair.Index);
            }
        }

        void ISOEHandler.Process(HeaderInfo info, IEnumerable<IndexedValue<SecurityStat>> values)
        {
            foreach (var pair in values)
            {
                Print(pair.Value, pair.Index);
            }
        }

        private void Print(Binary value, UInt16 index)
        {
            Console.WriteLine(_scadaDev.Name + ": Binary[" + index + "] " + value.ToString());                         
        }

        private void Print(DoubleBitBinary value, UInt16 index)
        {
            Console.WriteLine(_scadaDev.Name + ": DoubleBit[" + index + "] " + value.ToString());            
        }

        private void Print(Analog value, UInt16 index)
        {          
            Console.WriteLine(_scadaDev.Name + ": Analog[" + index + "] " + value.ToString());         
        }

        private void Print(Counter value, UInt16 index)
        {
            Console.WriteLine(_scadaDev.Name + ": Counter[" + index + "] " + value.ToString());            
        }

        private void Print(FrozenCounter value, UInt16 index)
        {
            Console.WriteLine(_scadaDev.Name + ": FrozenCounter[" + index + "] " + value.ToString());            
        }

        private void Print(BinaryOutputStatus value, UInt16 index)
        {
            Console.WriteLine(_scadaDev.Name + ": BinaryOutputStatus[" + index + "] " + value.ToString());            
        }

        private void Print(AnalogOutputStatus value, UInt16 index)
        {
            Console.WriteLine(_scadaDev.Name + ": AnalogOutputStatus[" + index + "] " + value.ToString());            
        }

        private void Print(OctetString value, UInt16 index)
        {
            Console.WriteLine(_scadaDev.Name + ": OctetString[" + index + "] lemgth: " + value.Bytes.Length);            
        }

        private void Print(TimeAndInterval value, UInt16 index)
        {
            Console.WriteLine(String.Format(_scadaDev.Name + ": TimeAndInterval[{0}] {1}", index, value));           
        }

        private void Print(BinaryCommandEvent value, UInt16 index)
        {
            Console.WriteLine(String.Format("BinaryCommandEvent[{0}] {1}", index, value));            
        }

        private void Print(AnalogCommandEvent value, UInt16 index)
        {
            Console.WriteLine(String.Format(_scadaDev.Name + ": AnalogCommandEvent[{0}] {1}", index, value));            
        }

        private void Print(SecurityStat value, UInt16 index)
        {
            Console.WriteLine(String.Format(_scadaDev.Name + ": SecurityStat[{0}] {1}", index, value.Value));
        }
        
    }    
}
