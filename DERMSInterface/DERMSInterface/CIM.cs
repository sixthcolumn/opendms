using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace DERMSInterface
{
    public enum quantity
    {
        Watts,
        RealPower,
        ApparentPower,
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

        public int createDERGroup(CIMData.header header, CIMData.DERGroup group)
        {
            CIMChangeDERGroup.DERGroup_PortClient client;

            client = new CIMChangeDERGroup.DERGroup_PortClient("DERGroup_Port", header.EndPoint);

            // Build header string
            DERMSInterface.CIMChangeDERGroup.DERGroupRequestMessageType req = new DERMSInterface.CIMChangeDERGroup.DERGroupRequestMessageType();
            CIMChangeDERGroup.HeaderType to = new CIMChangeDERGroup.HeaderType();
            req.Header = to;

            CIMChangeDERGroup.HeaderTypeVerb v = new CIMChangeDERGroup.HeaderTypeVerb();
            if (Enum.TryParse(header.Verb, out v))
                to.Verb = v;
            to.Noun = header.Noun;
            to.ReplyAddress = header.ReplyAddress;
            to.Revision = header.Revision;
            to.Source = header.Source;
            if (header.UserID != null || header.UserOrganization != null)
            {
                to.User = new CIMChangeDERGroup.UserType();
                to.User.Organization = header.UserOrganization;
                to.User.UserID = header.UserID;
            }

            // initialize the payload
            req.Payload = new CIMChangeDERGroup.DERGroupPayloadType();
            req.Payload.DERGroups = new CIMChangeDERGroup.DERGroupsDERGroup[1];
            req.Payload.DERGroups[0] = new CIMChangeDERGroup.DERGroupsDERGroup();

            if (group != null)
            {
                req.Payload.DERGroups[0].name = group.GroupName;
                req.Payload.DERGroups[0].mRID = group.Mrid;

                if( group.Devices.Count > 0 ) {
                List<CIMChangeDERGroup.DERMember> DERMembers = new List<CIMChangeDERGroup.DERMember>();
                foreach( CIMData.device dev in group.Devices ) {
                    CIMChangeDERGroup.DERMember d = new CIMChangeDERGroup.DERMember();
                    DERMembers.Add(d);
                    d.name = dev.Name;
                    d.mRID = dev.Mrid;
                    // TODO : Change xsd to allow for reactive, real, etc...
                }

                req.Payload.DERGroups[0].DERMember = DERMembers.ToArray();
                }
            }

            // Send the message to DER Server
            _lastMessageSent = logMessage<DERMSInterface.CIMChangeDERGroup.DERGroupRequestMessageType>(req);
            DERMSInterface.CIMChangeDERGroup.DERGroupResponseMessageType reply = client.CreateDERGroup(req);
            _lastMessageReceived = logMessage<DERMSInterface.CIMChangeDERGroup.DERGroupResponseMessageType>(reply);

            if (reply.Reply.Result.CompareTo(CIMChangeDERGroup.ReplyTypeResult.OK) == 0)
                return 0;
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
            to.User.Organization = from.UserOrganization;
            to.User.UserID = from.UserID;

            // initialize the payload
            req.Payload = new CIMChangeDERGroup.DERGroupPayloadType();
            req.Payload.DERGroups = new CIMChangeDERGroup.DERGroupsDERGroup[1];
            req.Payload.DERGroups[0] = new CIMChangeDERGroup.DERGroupsDERGroup();

            CIMData.DERGroup group = _data.Groups.Find(x => x.GroupName.Equals(name));
            if (group != null)
            {
                req.Payload.DERGroups[0].name = group.GroupName;
                req.Payload.DERGroups[0].mRID = group.Mrid;
                List<CIMChangeDERGroup.DERMember> DERMembers = new List<CIMChangeDERGroup.DERMember>();
                foreach (CIMData.device dev in group.Devices)
                {
                    CIMChangeDERGroup.DERMember d = new CIMChangeDERGroup.DERMember();
                    DERMembers.Add(d);
                    d.name = dev.Name;
                    d.mRID = dev.Mrid;
                    // TODO : New xsd, add the watts etc...
                }
                req.Payload.DERGroups[0].DERMember = DERMembers.ToArray();
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
        public DERGroupStatusResponse getDERGroupStatus(String[] groups, quantity q)
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
            to.User.Organization = from.UserOrganization;
            to.User.UserID = from.UserID;

            for (int i = 0; i < groups.Length; i++)
            {
                if (payload.DERGroupStatuses == null)
                    payload.DERGroupStatuses = new CIMGetDERGroupStatus.DERGroupStatus[groups.Length];
                payload.DERGroupStatuses[i] = new CIMGetDERGroupStatus.DERGroupStatus();
                payload.DERGroupStatuses[i].DERGroup = new CIMGetDERGroupStatus.DERGroup();
                payload.DERGroupStatuses[i].DERGroup.name = groups[i];
                payload.DERGroupStatuses[i].RequestedCapability = (CIMGetDERGroupStatus.RequestedCapability)Enum.Parse(typeof(CIMGetDERGroupStatus.RequestedCapability), q.ToString());
            }

            _lastMessageSent = logMessage<CIMGetDERGroupStatus.GetDERGroupStatusRequestMessageType>(req);
            CIMGetDERGroupStatus.DERGroupStatusResponseMessageType reply = client.GetDERGroupStatus(req);
            _lastMessageReceived = logMessage<CIMGetDERGroupStatus.DERGroupStatusResponseMessageType>(reply);

            DERGroupStatusResponse resp = new DERGroupStatusResponse();
            return resp;
        }

        /*
         * Returns information on existing DER groups
         */
        public String[] getDERGroup(String[] groups)
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
            to.User.Organization = from.UserOrganization;
            to.User.UserID = from.UserID;


            req = new CIMGetDERGroup.GetDERGroupRequestType();
            req.ID = new string[groups.Length];
            int count = 0;
            foreach (String s in groups)
            {
                req.ID[count] = s;
                count++;
            }

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
                dergroups = new String[payload.DERGroups.Length];
                for (int i = 0; i < payload.DERGroups.Length; i++)
                    dergroups[i] = payload.DERGroups[i].mRID;
                // TODO : Verify it's mrid not name, which is required...
            }
            return dergroups;
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
