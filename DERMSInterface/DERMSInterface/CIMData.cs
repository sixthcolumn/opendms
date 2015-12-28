using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Configuration;

namespace DERMSInterface
{
    /* raison d'etre. The various CIM objects do not share header namespaces. For that reason
     * we create a general base that is then inherited by specific CIM Headers for each
     * CIM operation type: ie getDer, createDer
     */
    public class CIMData
    {
        List<header> headers = new List<header>();
        List<DERGroup> groups = new List<DERGroup>();
        List<SCADAInfo> scada = new List<SCADAInfo>();


        private version _version = new version();

        /// <summary>
        /// represents the types of headers supported 
        /// </summary>
        public enum operations { createDER, getDER, dispatchDER, getDERStatus };

        /// <summary>
        /// constructor
        /// </summary>
        public CIMData()
        {
            Console.WriteLine("Creating cimdata");
        }

        /// <summary>
        /// clones the current object and returns the new object
        /// </summary>
        /// <returns></returns>
        public CIMData clone()
        {
            System.IO.StringWriter s = new System.IO.StringWriter();
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(CIMData));
            writer.Serialize(s, this);

            XmlSerializer serializer = new XmlSerializer(typeof(CIMData));
            System.IO.StringReader r = new System.IO.StringReader(s.ToString());
            CIMData data;
            data = (CIMData)serializer.Deserialize(r);

            return data;
        }

        /// <summary>
        /// writes itself out to a xml file
        /// </summary>
        /// <param name="path"></param>
        public void write(String path)
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(CIMData));

            //  var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//CIMHeader.xml";
            System.IO.FileStream file = System.IO.File.Create(path);
            writer.Serialize(file, this);
            file.Close();
        }

        /// <summary>
        /// reads from xml file and returns new cimdata object
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static CIMData read(String path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(CIMData));
            System.IO.FileStream file = new System.IO.FileStream(path, System.IO.FileMode.Open);
            CIMData data;
            try
            {
                data = (CIMData)serializer.Deserialize(file);
                return data;
            }
            finally
            {
                file.Close();
            }
        }

        public static String OpCreateDER
        {
            get { return operations.createDER.ToString(); }
        }

        public header CreateDERHeader
        {
            get
            {
                header h = this.Headers.Find(x => x.Name.Equals(OpCreateDER));
                if (h == null)
                {
                    h = new header();
                    h.Name = OpCreateDER;
                    this.headers.Add(h);
                }
                return h;

            }
        }

        public header GetDERHeader
        {
            get
            {
                header h = this.Headers.Find(x => x.Name.Equals(OpGetDER));
                if (h == null)
                {
                    h = new header();
                    h.Name = OpGetDER;
                    this.headers.Add(h);
                }
                return h;
            }
        }

        public header DispatchDERHeader
        {
            get
            {
                {
                    header h = this.Headers.Find(x => x.Name.Equals(OpDispatchDER));
                    if (h == null)
                    {
                        h = new header();
                        h.Name = OpDispatchDER;
                        this.headers.Add(h);
                    }
                    return h;
                }
            }
        }

        public header GetDERStatusHeader
        {
            get
            {
                {
                    header h = this.Headers.Find(x => x.Name.Equals(OpGetDERStatus));
                    if (h == null)
                    {
                        h = new header();
                        h.Name = OpGetDERStatus;
                        this.headers.Add(h);
                    }
                    return h;
                }
            }
        }

        public static String OpGetDER
        {
            get { return operations.getDER.ToString(); }
        }

        public static String OpGetDERStatus
        {
            get { return operations.getDERStatus.ToString(); }
        }

        public static String OpDispatchDER
        {
            get { return operations.dispatchDER.ToString(); }
        }

        public List<header> Headers
        {
            get { return headers; }
            set { headers = value; }
        }

        public List<DERGroup> Groups
        {
            get { return groups; }
            set { groups = value; }
        }

        public List<SCADAInfo> Scada
        {
            get { return scada; }
            set { scada = value; }
        }

        public version Version
        {
            get { return _version; }
            set { _version = value; }
        }

        public class header
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            private string endPoint;

            public string EndPoint
            {
                get { return endPoint; }
                set { endPoint = value; }
            }
            private String verb;

            public String Verb
            {
                get { return verb; }
                set { verb = value; }
            }
            private String noun;

            public String Noun
            {
                // Noun is required
                get
                {
                    if (noun == null || noun.Length < 1)
                        return "default";
                    else
                        return noun;
                }
                set { noun = value; }
            }
            private String replyAddress;

            public String ReplyAddress
            {
                get { return replyAddress; }
                set { replyAddress = value; }
            }
            private String source;

            public String Source
            {
                get { return source; }
                set { source = value; }
            }
            private string context;

            public string Context
            {
                get { return context; }
                set { context = value; }
            }
            private string revision;

            public string Revision
            {
                get { return revision; }
                set { revision = value; }
            }
            private string comment;

            public string Comment
            {
                get { return comment; }
                set { comment = value; }
            }
            private bool ackRequired;

            public bool AckRequired
            {
                get { return ackRequired; }
                set { ackRequired = value; }
            }
            private string userOrganization;

            public string UserOrganization
            {
                get { return userOrganization; }
                set { userOrganization = value; }
            }
            private string userID;

            public string UserID
            {
                get { return userID; }
                set { userID = value; }
            }

        }

        public class version
        {
            string major;
            string minor;
            DateTime date;
            string revision;

            public string Major
            {
                get
                {
                    // required field, can't be empty
                    if (major == null || major.Length < 1)
                        return "1";
                    return major;
                }
                set { major = value; }
            }


            public string Minor
            {
                get
                {
                    // required, can't be null
                    if (minor == null || minor.Length < 1)
                        return "1";
                    return minor;
                }
                set { minor = value; }
            }


            public string Revision
            {
                get
                {
                    // required, can't be null
                    if (revision == null || revision.Length < 1)
                        return "1";
                    return revision;
                }
                set { revision = value; }
            }


            public DateTime Date
            {
                get
                {
                    // required, can't be null
                    if (date == null)
                        return System.DateTime.Now;
                    return date;
                }
                set { date = value; }
            }

        }

        public class DERStatus
        {
            private float presentMaxCapability = 0;

            public float PresentMaxCapability
            {
                get { return presentMaxCapability; }
                set { presentMaxCapability = value; }
            }
            private float presentValue = 0;

            public float PresentValue
            {
                get { return presentValue; }
                set { presentValue = value; }
            }
            private float presentMinCapability = 0;

            public float PresentMinCapability
            {
                get { return presentMinCapability; }
                set { presentMinCapability = value; }
            }
            private string DERGroupID;

            public string DERGroupID1
            {
                get { return DERGroupID; }
                set { DERGroupID = value; }
            }
            private int quantity = 0;

            public int Quantity
            {
                get { return quantity; }
                set { quantity = value; }
            }

            private string mrid;

            public string Mrid
            {
                get { return mrid; }
                set { mrid = value; }
            }
        }

        public class SCADAInfo
        {
            private string _mrid;
            private string _logLevel;
            private string _name;
            private string _substation;
            private string _feeder;
            private string _description;
            private string _deviceType;
            private string _protocol;
            private DNP dnp = new DNP();

            public DNP Dnp
            {
                get { return dnp; }
                set { dnp = value; }
            }

            public string Mrid
            {
                get { return _mrid; }
                set { _mrid = value; }
            }


            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }


            public string Description
            {
                get { return _description; }
                set { _description = value; }
            }

            public string Substation
            {
                get { return _substation; }
                set { _substation = value; }
            }

            public string Feeder
            {
                get { return _feeder; }
                set { _feeder = value; }
            }


            public string DeviceType
            {
                get { return _deviceType; }
                set { _deviceType = value; }
            }


            public string Protocol
            {
                get { return _protocol; }
                set { _protocol = value; }
            }


            public string LogLevel
            {
                get { return _logLevel; }
                set { _logLevel = value; }
            }
        }

        public class DNP
        {
            // basic
            public enum transportEnum { TCP, UDP };
            public enum initiationEnum { Local, Remote };
            public enum DNPFunctionEnum { SB0, D0, DO_NOACK };
            private string ipAddress;
            private string remoteAddress;
            private string localAddress;
            private string port;
            private int integrityScanRate;
            private int saveInterval;
            private bool isUnsolictedOnStartup;
            private bool isEnableUnsolicited;
            private bool isTimeSync;
            private bool isUseConfirms;
            private transportEnum transport;
            private initiationEnum initiation;
            private DNPFunctionEnum dnpfunction;
            private bool class0;
            private bool class1;
            private bool class2;
            private bool class3;

            // advanced
            private int maxFragSize;
            private int frameRetries;
            private int responseTimeout;
            private int fragSize;
            private int taskRetryRate;
            private int numRetries;
            private int confirmationTimeout;
            private int retryTimeout;



            public int TaskRetryRate
            {
                get { return taskRetryRate; }
                set { taskRetryRate = value; }
            }

            public int FragSize
            {
                get { return fragSize; }
                set { fragSize = value; }
            }

            public int RetryTimeout
            {
                get { return retryTimeout; }
                set { retryTimeout = value; }
            }

            public int ConfirmationTimeout
            {
                get { return confirmationTimeout; }
                set { confirmationTimeout = value; }
            }

            public int NumRetries
            {
                get { return numRetries; }
                set { numRetries = value; }
            }

            public int ResponseTimeout
            {
                get { return responseTimeout; }
                set { responseTimeout = value; }
            }

            public int FrameRetries
            {
                get { return frameRetries; }
                set { frameRetries = value; }
            }

            public int MaxFragSize
            {
                get { return maxFragSize; }
                set { maxFragSize = value; }
            }

            public bool Class3
            {
                get { return class3; }
                set { class3 = value; }
            }

            public bool Class2
            {
                get { return class2; }
                set { class2 = value; }
            }

            public bool Class1
            {
                get { return class1; }
                set { class1 = value; }
            }

            public bool Class0
            {
                get { return class0; }
                set { class0 = value; }
            }

            public DNPFunctionEnum Dnpfunction
            {
                get { return dnpfunction; }
                set { dnpfunction = value; }
            }

            public initiationEnum Initiation
            {
                get { return initiation; }
                set { initiation = value; }
            }


            public transportEnum Transport
            {
                get { return transport; }
                set { transport = value; }
            }


            public bool IsUseConfirms
            {
                get { return isUseConfirms; }
                set { isUseConfirms = value; }
            }

            public bool IsTimeSync
            {
                get { return isTimeSync; }
                set { isTimeSync = value; }
            }

            public bool IsEnableUnsolicited
            {
                get { return isEnableUnsolicited; }
                set { isEnableUnsolicited = value; }
            }

            public bool IsUnsolictedOnStartup
            {
                get { return isUnsolictedOnStartup; }
                set { isUnsolictedOnStartup = value; }
            }

            public int SaveInterval
            {
                get { return saveInterval; }
                set { saveInterval = value; }
            }

            public int IntegrityScanRate
            {
                get { return integrityScanRate; }
                set { integrityScanRate = value; }
            }

            public string Port
            {
                get { return port; }
                set { port = value; }
            }

            public string LocalAddress
            {
                get { return localAddress; }
                set { localAddress = value; }
            }

            public string RemoteAddress
            {
                get { return remoteAddress; }
                set { remoteAddress = value; }
            }

            public string IPAddress
            {
                get { return ipAddress; }
                set { ipAddress = value; }
            }
        }

        public class DeviceType
        {
            private string name;
            private List<Protocol> protocols = new List<Protocol>();

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public List<Protocol> Protocols
            {
                get { return protocols; }
                set { protocols = value; }
            }

            public class Protocol
            {
                private string name;
                private List<DNP3PointTypeDef> _DNP3PointDefinitions = new List<DNP3PointTypeDef>();

                public string Name
                {
                    get { return name; }
                    set { name = value; }
                }

                public List<DNP3PointTypeDef> DNP3PointDefinitions
                {
                    get { return _DNP3PointDefinitions; }
                    set { _DNP3PointDefinitions = value; }
                }

            }

            public class DNP3PointTypeDef
            {
                private string _DNP3TypeName;
                private List<DNP3PointDef> _DNP3PointList = new List<DNP3PointDef>();

                public List<DNP3PointDef> DNP3PointList
                {
                    get { return _DNP3PointList; }
                    set { _DNP3PointList = value; }
                }

                public string DNP3TypeName
                {
                    get { return _DNP3TypeName; }
                    set { _DNP3TypeName = value; }
                }
            }

            public class DNP3PointDef
            {
                private int _DNP3PointNum;
                private string _DNP3PointName;
                private string _DNP3PointDesc;
                private int _DNP3EventClass;



                public string DNP3PointName
                {
                    get { return _DNP3PointName; }
                    set { _DNP3PointName = value; }
                }

                public int DNP3PointNum
                {
                    get { return _DNP3PointNum; }
                    set { _DNP3PointNum = value; }
                }

                public string DNP3PointDesc
                {
                    get { return _DNP3PointDesc; }
                    set { _DNP3PointDesc = value; }
                }

                public int DNP3EventClass
                {
                    get { return _DNP3EventClass; }
                    set { _DNP3EventClass = value; }
                }
            }

            List<DNP3PointDef> DNP3PointList;
        }


        /*
         * DERGroup
         */
        public class DERGroup
        {
            private string groupName;

            public string GroupName
            {
                get { return groupName; }
                set { groupName = value; }
            }
            private string mrid;

            public string Mrid
            {
                get { return mrid; }
                set { mrid = value; }
            }
            private string revision;

            public string Revision
            {
                get { return revision; }
                set { revision = value; }
            }
            private string substation;

            public string Substation
            {
                get { return substation; }
                set { substation = value; }
            }
            private string feeder;

            public string Feeder
            {
                get { return feeder; }
                set { feeder = value; }
            }
            private string segment;

            public string Segment
            {
                get { return segment; }
                set { segment = value; }
            }

            private List<device> devices;

            public List<device> Devices
            {
                get { return devices; }
                set { devices = value; }
            }

            public double getWattCapacity()
            {
                double wc = 0.0;
                devices.ForEach(x => wc += x.WattCapacity);
                return wc;
            }

            public double getVarCapacity()
            {
                double vc = 0.0;
                devices.ForEach(x => vc += x.VarCapacity);
                return vc;
            }


        }

        /*
         * device
         */
        public class device
        {
            string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            string mrid;

            public string Mrid
            {
                get { return mrid; }
                set { mrid = value; }
            }
            double wattCapacity;

            public double WattCapacity
            {
                get { return wattCapacity; }
                set { wattCapacity = value; }
            }
            double varCapacity;

            public double VarCapacity
            {
                get { return varCapacity; }
                set { varCapacity = value; }
            }


        }

    }
}

