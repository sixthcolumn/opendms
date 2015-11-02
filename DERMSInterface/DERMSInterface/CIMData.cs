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

        public enum operations { createDER, getDER, dispatchDER, getDERStatus  };

        List<header> headers = new List<header>();
        public List<header> Headers
        {
            get { return headers; }
            set { headers = value; }
        }

        List<DERGroup> groups = new List<DERGroup>();
        public List<DERGroup> Groups
        {
            get { return groups; }
            set { groups = value; }
        }

     

        /*
        * Write a cim header out to xml file
        */
        public void write(String path)
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(CIMData));

            //  var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//CIMHeader.xml";
            System.IO.FileStream file = System.IO.File.Create(path);
            writer.Serialize(file, this);
            file.Close();
        }


        /*
         * read xml serialized cim header in from config file
         */
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
                get { return noun; }
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

