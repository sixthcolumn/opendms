using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.InteropServices;




namespace DERMSInterface
{
    public enum quantity
    {
        RealPower,
        Reactive,
    }

    public enum headerVerb
    {
        cancel,
        canceled,
        change,
        changed,
        create,
        created,
        close,
        closed,
        delete,
        deleted,
        get,
        reply,
        execute,
        executed,
    }

    public class CIM
    {
        private String _endPoint = "";
        private String _lastMessageSent = "";
        private String _lastMessageReceived = "";
        private CIMData _data = new CIMData();





        public CIM() { }

        public CIM(CIMData d)
        {
            _data = d;
        }

        public static CIM loadConfigFile(string path)
        {
            CIM c = new CIM();
            c._data = DERMSInterface.CIMData.read(path);
            return c;
        }

        public static int CreateDERGroup(String derGroup, string path)
        {
            CIM c = new CIM();
            c._data = DERMSInterface.CIMData.read(path);
            return c.createDERGroup(derGroup, null);
        }

        public String LastMessageReceived
        {
            get { return _lastMessageReceived; }
        }

        public String LastMessageSent
        {
            get { return _lastMessageSent; }
        }

        public String EndPoint
        {
            get { return _endPoint; }
            set { _endPoint = value; }
        }

        public CIMData Defaults
        {
            get { return _data; }
            set { _data = value; }
        }

        public int DispatchDERGroup(String id, double value, quantity q)
        {
            CIMDERGroupDispatch.DERGroupDispatch_PortClient client;

            if (_endPoint != null && _endPoint.Length > 0)
                client = new CIMDERGroupDispatch.DERGroupDispatch_PortClient("DERGroupDispatch_Port", _endPoint);
            else
                client = new CIMDERGroupDispatch.DERGroupDispatch_PortClient();

            DERMSInterface.CIMDERGroupDispatch.DERGroupDispatchRequestMessageType req = new CIMDERGroupDispatch.DERGroupDispatchRequestMessageType();
            CIMDERGroupDispatch.HeaderType to = new CIMDERGroupDispatch.HeaderType();
            CIMDERGroupDispatch.DERGroupDispatchPayloadType payload = new CIMDERGroupDispatch.DERGroupDispatchPayloadType();
            req.Header = to;
            req.Payload = payload;

            CIMData.header from = _data.Headers.Find(x => x.Name.Equals(CIMData.operations.dispatchDER.ToString()));
            if (from == null)
                throw new HeaderNotFoundException("Config file does not contain header data for dispatchDER");
            CIMDERGroupDispatch.HeaderTypeVerb v = new CIMDERGroupDispatch.HeaderTypeVerb();
            if (Enum.TryParse(from.Verb, out v))
                to.Verb = v;
            to.Noun = from.Noun;
            to.ReplyAddress = from.ReplyAddress;
            to.Revision = from.Revision;
            to.Source = from.Source;
            to.User.Organization = from.UserOrganization;
            to.User.UserID = from.UserID;

            payload.DERGroupDispatches = new CIMDERGroupDispatch.DERGroupDispatch[1];
            payload.DERGroupDispatches[0] = new CIMDERGroupDispatch.DERGroupDispatch();
            payload.DERGroupDispatches[0].DERGroup = new CIMDERGroupDispatch.DERGroup();
            payload.DERGroupDispatches[0].DERGroup.mRID = id;
            // TODO : Docs say mrid, but name is required in wsdl. Ask Gerry.
            payload.DERGroupDispatches[0].DERGroup.name = id;
            payload.DERGroupDispatches[0].RequestedCapability = new CIMDERGroupDispatch.RequestedCapability();
            payload.DERGroupDispatches[0].RequestedCapability.capabilityType = (CIMDERGroupDispatch.capabilityType)Enum.Parse(typeof(CIMDERGroupDispatch.capabilityType), q.ToString());

            _lastMessageSent = logMessage<DERMSInterface.CIMDERGroupDispatch.DERGroupDispatchRequestMessageType>(req);
            CIMDERGroupDispatch.DERGroupDispatchResponseMessageType reply = client.CreateDERGroupDispatch(req);
            _lastMessageReceived = logMessage<CIMDERGroupDispatch.DERGroupDispatchResponseMessageType>(reply);


            if (reply.Reply.Result.CompareTo(CIMDERGroupDispatch.ReplyTypeResult.OK) == 0)
                return 0;
            else
                return 1;
        }




        /*
         * Creates a new DER Group with children
         */

        public int createDERGroup(String name, String[] members)
        {
            /*
             * TODO : 'string[] members' implies that the members weren't present in config already,
             * which they are, or that you are only choosing to upload some of the der members, which
             * doesn't make sense. ie: this function should only have argument of 'name'
             * */
            if (name == null || name.Length < 1)
                throw new ConfigureException("createDERGroup illegal argument, name not set");

            CIMChangeDERGroup.DERGroup_PortClient client;

            if (_endPoint != null && _endPoint.Length > 0)
                client = new CIMChangeDERGroup.DERGroup_PortClient("DERGroup_Port", _endPoint);
            else
                client = new CIMChangeDERGroup.DERGroup_PortClient();

            // Build header string
            DERMSInterface.CIMChangeDERGroup.DERGroupRequestMessageType req = new DERMSInterface.CIMChangeDERGroup.DERGroupRequestMessageType();
            CIMChangeDERGroup.HeaderType to = new CIMChangeDERGroup.HeaderType();
            req.Header = to;

            // build header
            CIMData.header from = _data.Headers.Find(x => x.Name.Equals(CIMData.operations.createDER.ToString()));
            if (from == null)
                throw new HeaderNotFoundException("Config file does not contain header data for createDER");
            CIMChangeDERGroup.HeaderTypeVerb v = new CIMChangeDERGroup.HeaderTypeVerb();
            if (Enum.TryParse(from.Verb, out v))
                to.Verb = v;
            to.Noun = from.Noun;
            to.ReplyAddress = from.ReplyAddress;
            to.Revision = from.Revision;
            to.Source = from.Source;
            to.User = new CIMChangeDERGroup.UserType();
            to.User.Organization = from.UserOrganization;
            to.User.UserID = from.UserID;

            // initialize the payload
            req.Payload = new CIMChangeDERGroup.DERGroupPayloadType();
            req.Payload.DERGroups = new CIMChangeDERGroup.EndDeviceGroup[1];
            req.Payload.DERGroups[0] = new CIMChangeDERGroup.EndDeviceGroup();

            req.Payload.DERGroups[0].Version = new CIMChangeDERGroup.EndDeviceGroupVersion();
            req.Payload.DERGroups[0].Version.major = "1";
            req.Payload.DERGroups[0].Version.minor = "46";
            req.Payload.DERGroups[0].Version.revision = "1";
            req.Payload.DERGroups[0].Version.versionDate = System.DateTime.Now;


            CIMData.DERGroup group = _data.Groups.Find(x => x.GroupName.Equals(name));
            if (group != null)
            {
                req.Payload.DERGroups[0].name = group.GroupName;
                req.Payload.DERGroups[0].mRID = group.Mrid;
                List<CIMChangeDERGroup.DERMember> DERMembers = new List<CIMChangeDERGroup.DERMember>();
                foreach (CIMData.device dev in group.Devices)
                {
                    // todo : Is the purpose of members to filter our DERS to be created?
                    if (members == null || (members != null && Array.Find(members, x => x.Equals(dev.Name)) != null))
                    {
                        CIMChangeDERGroup.DERMember d = new CIMChangeDERGroup.DERMember();
                        DERMembers.Add(d);
                        d.name = dev.Name;
                        d.mRID = dev.Mrid;
                        d.CapabilityList = new CIMChangeDERGroup.DERMemberCapabilityList();
                        d.CapabilityList.ActivePower = new CIMChangeDERGroup.ActivePower();
                        d.CapabilityList.ActivePower.value = (float)dev.WattCapacity;
                        d.CapabilityList.ActivePower.multiplier = CIMChangeDERGroup.multiplier.k;
                        d.CapabilityList.ActivePower.unit = "W";
                        d.CapabilityList.ReactivePower = new CIMChangeDERGroup.ReactivePower();
                        d.CapabilityList.ReactivePower.value = (float)dev.VarCapacity;
                        d.CapabilityList.ReactivePower.multiplier = CIMChangeDERGroup.multiplier.k;
                        d.CapabilityList.ReactivePower.unit = "VAr";

                        // TODO : New xsd, add the watts etc...
                    }

                }
                req.Payload.DERGroups[0].EndDevice = DERMembers.ToArray();

            }
            else
                throw new ConfigureException("DERGroup Name " + name + " not found in configuration file");

            // Send the message to DER Server
            _lastMessageSent = logMessage<DERMSInterface.CIMChangeDERGroup.DERGroupRequestMessageType>(req);
            DERMSInterface.CIMChangeDERGroup.DERGroupResponseMessageType reply = client.CreateDERGroup(req);
            _lastMessageReceived = logMessage<DERMSInterface.CIMChangeDERGroup.DERGroupResponseMessageType>(reply);

            if (reply.Reply.Result.CompareTo(CIMChangeDERGroup.ReplyTypeResult.OK) == 0)
                return 0;
            return 1;
        }


        /*
         * getDERGroupStatus
         */
        public CIMData.DERStatus getDERGroupStatus(String mrid, quantity q)
        {
            CIMGetDERGroupStatus.GetDERGroupStatus_PortClient client;
            if (_endPoint != null && _endPoint.Length > 0)
                client = new CIMGetDERGroupStatus.GetDERGroupStatus_PortClient("GetDERGroupStatus_Port", _endPoint);
            else
                client = new CIMGetDERGroupStatus.GetDERGroupStatus_PortClient();

            CIMGetDERGroupStatus.GetDERGroupStatusRequestMessageType req = new CIMGetDERGroupStatus.GetDERGroupStatusRequestMessageType();
            CIMGetDERGroupStatus.DERGroupStatusPayloadType payload = new CIMGetDERGroupStatus.DERGroupStatusPayloadType();
            CIMGetDERGroupStatus.HeaderType to = new CIMGetDERGroupStatus.HeaderType();
            req.Payload = payload;
            req.Header = to;
            req.Request = new CIMGetDERGroupStatus.GetDERGroupStatusRequestType();

            // build header
            CIMData.header from = _data.Headers.Find(x => x.Name.Equals(CIMData.operations.getDERStatus.ToString()));
            if (from == null)
                throw new HeaderNotFoundException("Config file does not contain header data for getDERStatus");
            CIMGetDERGroupStatus.HeaderTypeVerb v = new CIMGetDERGroupStatus.HeaderTypeVerb();
            if (Enum.TryParse(from.Verb, out v))
                to.Verb = v;
            to.Noun = from.Noun;
            to.ReplyAddress = from.ReplyAddress;
            to.Revision = from.Revision;
            to.Source = from.Source;
            to.User = new CIMGetDERGroupStatus.UserType();
            to.User.Organization = from.UserOrganization;
            to.User.UserID = from.UserID;


            payload.DERGroupStatuses = new CIMGetDERGroupStatus.EndDeviceGroup[1];
            payload.DERGroupStatuses[0] = new CIMGetDERGroupStatus.EndDeviceGroup();
            payload.DERGroupStatuses[0].mRID = mrid;

            req.Payload.DERGroupStatuses[0].Version = new CIMGetDERGroupStatus.EndDeviceGroupVersion();
            req.Payload.DERGroupStatuses[0].Version.major = "1";
            req.Payload.DERGroupStatuses[0].Version.minor = "46";
            req.Payload.DERGroupStatuses[0].Version.revision = "1";
            req.Payload.DERGroupStatuses[0].Version.versionDate = System.DateTime.Now;

            _lastMessageSent = logMessage<CIMGetDERGroupStatus.GetDERGroupStatusRequestMessageType>(req);
            CIMGetDERGroupStatus.DERGroupStatusResponseMessageType reply = client.GetDERGroupStatus(req);
            _lastMessageReceived = logMessage<CIMGetDERGroupStatus.DERGroupStatusResponseMessageType>(reply);

            CIMGetDERGroupStatus.EndDeviceGroup[] statuses = reply.Payload.DERGroupStatuses;
            if (statuses.Length > 1)
            {
                throw new DERResponseException("GETDERGroupStatus returned multiple DER Groups.");
            }
            else
            {
                CIMData.DERStatus status = new CIMData.DERStatus();
                status.Mrid = reply.Payload.DERGroupStatuses[0].mRID;

                if (statuses[0].CapabilityList == null)
                    return status;

                CIMGetDERGroupStatus.EndDeviceGroupCapabilityList cap = statuses[0].CapabilityList;
                if (q.Equals(quantity.RealPower))
                {
                    if (cap.currentActivePower != null)
                        status.PresentValue = cap.currentActivePower.value;
                    if (cap.minActivePower != null)
                        status.PresentMinCapability = cap.minActivePower.value;
                    if (cap.maxActivePower != null)
                        status.PresentMaxCapability = cap.maxActivePower.value;
                    // TODO : Doesn't handle case where ders have diff multipliers
                }
                else if (q.Equals(quantity.Reactive))
                {
                    if (cap.currentReactivePower != null)
                        status.PresentValue = cap.currentReactivePower.value;
                    if (cap.minReactivePower != null)
                        status.PresentMinCapability = cap.minReactivePower.value;
                    if (cap.maxReactivePower != null)
                        status.PresentMaxCapability = cap.maxReactivePower.value;
                }
                return status;
            }
        }

        /*
         * Returns information on existing DER groups
         */
        public String[] requestDERGroupMembers(String group)
        {
            CIMGetDERGroup.GetDERGroup_PortClient client;
            if (_endPoint != null && _endPoint.Length > 0)
                client = new CIMGetDERGroup.GetDERGroup_PortClient("GetDERGroupImplPort", _endPoint);
            else
                client = new CIMGetDERGroup.GetDERGroup_PortClient();

            CIMGetDERGroup.GetDERGroupRequestType req = new CIMGetDERGroup.GetDERGroupRequestType();
            CIMGetDERGroup.DERGroupPayloadType payload = new CIMGetDERGroup.DERGroupPayloadType();
            CIMGetDERGroup.HeaderType to = new CIMGetDERGroup.HeaderType();

            // build header
            CIMData.header from = _data.Headers.Find(x => x.Name.Equals(CIMData.operations.getDER.ToString()));
            if (from == null)
                throw new HeaderNotFoundException("Config file does not contain header data for getDER");
            CIMGetDERGroup.HeaderType v = new CIMGetDERGroup.HeaderType();
            to.Verb = from.Verb;
            to.Noun = from.Noun;
            to.ReplyAddress = from.ReplyAddress;
            to.Revision = from.Revision;
            to.Source = from.Source;
            to.User = new CIMGetDERGroup.UserType();
            to.User.Organization = from.UserOrganization;
            to.User.UserID = from.UserID;


            req = new CIMGetDERGroup.GetDERGroupRequestType();
            req.ID = new string[1];
            req.ID[0] = group;

            XmlSerializer xmlSerializer = new XmlSerializer(to.GetType());
            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, to);
                _lastMessageSent = textWriter.ToString() + Environment.NewLine + Environment.NewLine;
            }

            _lastMessageSent = logMessage<CIMGetDERGroup.GetDERGroupRequestType>(req);
            CIMGetDERGroup.ReplyType reply = client.GetDERGroup(ref to, req, ref payload);
            _lastMessageReceived = logMessage<CIMGetDERGroup.ReplyType>(reply);

            String[] dergroups = null;
            if (reply.Result.CompareTo("OK") == 0 && payload.DERGroups.Length > 0)
            {
                List<String> ders = new List<string>();
                dergroups = new String[payload.DERGroups.Length];
                for (int i = 0; i < payload.DERGroups.Length; i++)
                {
                    if (payload.DERGroups[i].DERMember != null)
                        foreach (CIMGetDERGroup.DERMember der in payload.DERGroups[i].DERMember)
                        {
                            // TODO : Verify it's mrid not name, which is required...
                            ders.Add(der.name);
                        }
                }
                return ders.ToArray();
            }
            return null;
        }

        public static String getUUID()
        {
            return System.Guid.NewGuid().ToString();
        }

        private String logMessage<T>(T item)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, item);
                return textWriter.ToString();
            }
        }
    }
}
