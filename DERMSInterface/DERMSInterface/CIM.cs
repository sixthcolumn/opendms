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

        /// <summary>
        /// base constructor. Do not use
        /// </summary>
        public CIM() { }

        /// <summary>
        /// creates a CIM object initialized with header and data
        /// </summary>
        /// <param name="d"></param>
        public CIM(CIMData d)
        {
            _data = d;
        }

        /// <summary>
        /// loads a CIM data file into memory, returns a CIM object
        /// </summary>
        /// <param name="path">file name</param>
        /// <returns></returns>
        public static CIM loadConfigFile(string path)
        {
            CIM c = new CIM();
            c._data = DERMSInterface.CIMData.read(path);
            return c;
        }

        /// <summary>
        /// convenience function reads CIMData file, calls createDER, returns all in one call
        /// </summary>
        /// <param name="DERGroupName">group to be created, must be in the config file</param>
        /// <param name="path">file name</param>
        /// <returns></returns>
        public static int CreateDERGroup(string path, String DERGroupName, String[] members, ref String SOAPMessage)
        {
            CIM c = new CIM();
            c._data = DERMSInterface.CIMData.read(path);
            int rc =  c.createDERGroup(DERGroupName, null);
            SOAPMessage = c.LastMessageSent + c.LastMessageReceived;
            return rc;
        }

        /// <summary>
        /// convenience function reads cimdata file, calls dispatch
        /// </summary>
        /// <param name="path"> filename</param>
        /// <param name="DERGroupName">DER group name</param>
        /// <param name="q">apparent or real</param>
        /// <param name="isOverride">send my own value, rather than pulling from config</param>
        /// <param name="overrideValue">value to send</param>
        /// <returns></returns>
        public static int DispatchDERGroup(String path, String DERGroupName, quantity q, ref String SOAPMessage, Boolean isOverride = false, double overrideValue = 0.0)
        {
            CIM c = new CIM();
            c._data = DERMSInterface.CIMData.read(path);
            int rc = c.DispatchDERGroup(DERGroupName, q, isOverride, overrideValue);
            SOAPMessage = c.LastMessageSent + c.LastMessageReceived;
            return rc;
        }

        /// <summary>
        /// convenience function, reads cimdata file, calls getGroupStatus, returns result
        /// </summary>
        /// <param name="path">file name</param>
        /// <param name="mrid">der group unique identifier</param>
        /// <param name="q">apparent or real</param>
        /// <returns></returns>
        public static CIMData.DERStatus getDERGroupStatus(String path, String mrid, quantity q, ref String SOAPMessage)
        {
            CIM c = new CIM();

            c._data = DERMSInterface.CIMData.read(path);
            CIMData.DERStatus status = c.getDERGroupStatus(mrid, q);
            SOAPMessage = c.LastMessageSent + c.LastMessageReceived;
            return status;
        }

        /// <summary>
        /// convenience function, loads config and requests der member info
        /// </summary>
        /// <param name="path">file name</param>
        /// <param name="mrid">unique identifier for DER group</param>
        /// <returns></returns>
        public static String[] requestDERGroupMembers(String path, String mrid, ref String SOAPMessage)
        {
            CIM c = new CIM();
            c._data = DERMSInterface.CIMData.read(path);
            String[] s = c.requestDERGroupMembers(mrid);
            SOAPMessage = c.LastMessageSent + c.LastMessageReceived;
            return s;
        }


        /// <summary>
        /// executes a create DERdispatch soap command
        /// </summary>
        /// <param name="DERGroupName">DERGroup name</param>
        /// <param name="q">realPower or reactivePower</param>
        /// <param name="isOverride">send overrideValue instead of value from cimdata</param>
        /// <param name="overrideValue">value to be used for dispatch</param>
        /// <returns></returns>
        public int DispatchDERGroup(String MRID, quantity q, Boolean isOverride = false, double overrideValue = 0.0)
        {
            CIMDERGroupDispatch.DERGroupDispatch_PortClient client;
            CIMData.header header = _data.DispatchDERHeader;

            if (!hasData(header.EndPoint))
                throw new DERConfigureException("End Point required");

            // initialize SOAP server
            client = new CIMDERGroupDispatch.DERGroupDispatch_PortClient("DERGroupDispatch_Port", header.EndPoint);

            // intiailize service arguments
            CIMDERGroupDispatch.HeaderType to = new CIMDERGroupDispatch.HeaderType();
            CIMDERGroupDispatch.DERGroupDispatchPayloadType payload = new CIMDERGroupDispatch.DERGroupDispatchPayloadType();
            CIMDERGroupDispatch.DERGroupDispatchRequestMessageType req = new CIMDERGroupDispatch.DERGroupDispatchRequestMessageType();
            req.Payload = payload;
            req.Header = to;

            // set service header arguments
            CIMDERGroupDispatch.HeaderTypeVerb v = new CIMDERGroupDispatch.HeaderTypeVerb();
            if (header.Verb != null && Enum.TryParse(header.Verb, out v))
                to.Verb = v;
            else
                to.Verb = CIMDERGroupDispatch.HeaderTypeVerb.create;
            to.Noun = header.Noun;
            to.ReplyAddress = header.ReplyAddress;
            to.Revision = header.Revision;
            to.Source = header.Source;
            to.AckRequired = header.AckRequired;
            if (to.AckRequired == true)
                to.AckRequiredSpecified = true;
            to.Comment = header.Comment;
            to.Context = header.Context;
            if (hasData(header.UserOrganization) || hasData(header.UserID))
            {
                to.User = new CIMDERGroupDispatch.UserType();
                to.User.UserID = (hasData(header.UserID)) ? header.UserID : "epri"; // required
                to.User.Organization = header.UserOrganization; // optional
            }

            // load the data for the SOAP call
            CIMData.DERGroup group = _data.Groups.Find(x => x.Mrid.Equals(MRID));
            if (group != null)
            {
                payload.DERGroupDispatches = new CIMDERGroupDispatch.DERGroupDispatch[1];
                payload.DERGroupDispatches[0] = new CIMDERGroupDispatch.DERGroupDispatch();
                payload.DERGroupDispatches[0].DERGroup = new CIMDERGroupDispatch.DERGroup();
                payload.DERGroupDispatches[0].DERGroup.mRID = group.Mrid;
                payload.DERGroupDispatches[0].DERGroup.name = group.GroupName;
                // TODO : Docs say mrid, but name is required in wsdl. Ask Gerry.
                payload.DERGroupDispatches[0].RequestedCapability = new CIMDERGroupDispatch.RequestedCapability();
                payload.DERGroupDispatches[0].RequestedCapability.capabilityType = (CIMDERGroupDispatch.capabilityType)Enum.Parse(typeof(CIMDERGroupDispatch.capabilityType), q.ToString());

                // load with value passed, or reactive value, or real value
                if (isOverride == true)
                    payload.DERGroupDispatches[0].RequestedCapability.value = (float)overrideValue;
                else if (q.Equals(quantity.ApparentPower))
                    payload.DERGroupDispatches[0].RequestedCapability.value = (float)group.getVarCapacity();
                else
                    payload.DERGroupDispatches[0].RequestedCapability.value = (float)group.getWattCapacity();

                // set the multiplier and units
                if (q.Equals(quantity.RealPower))
                {
                    payload.DERGroupDispatches[0].RequestedCapability.capabilityMultiplier = CIMDERGroupDispatch.UnitMultiplier.k;
                    payload.DERGroupDispatches[0].RequestedCapability.capabilityUnits = "W";
                }
                else
                {
                    payload.DERGroupDispatches[0].RequestedCapability.capabilityMultiplier = CIMDERGroupDispatch.UnitMultiplier.k;
                    payload.DERGroupDispatches[0].RequestedCapability.capabilityUnits = "VAr";
                }


                // log message to be sent, send message, log result
                _lastMessageSent = logMessage<DERMSInterface.CIMDERGroupDispatch.DERGroupDispatchRequestMessageType>(req);
                CIMDERGroupDispatch.DERGroupDispatchResponseMessageType reply = client.CreateDERGroupDispatch(req);
                _lastMessageReceived = logMessage<CIMDERGroupDispatch.DERGroupDispatchResponseMessageType>(reply);

                if (reply.Reply.Result.CompareTo(CIMDERGroupDispatch.ReplyTypeResult.OK) == 0)
                    return 0;
                else
                    return 1;
            }
            else
                throw new DERConfigureException("DERGroup MRID " + MRID + " not found in configuration file");
        }

        /// <summary>
        /// executes a create DER SOAP command
        /// </summary>
        /// <param name="DERGroupName">name of der group to create</param>
        /// <param name="members">list of der's (their names) to create, defaultNull = all</param>
        /// <returns></returns>
        public int createDERGroup(String DERGroupName, String[] members)
        {

            if (DERGroupName == null || DERGroupName.Length < 1)
                throw new DERConfigureException("createDERGroup illegal argument, DERGroup name not set");

            // intialize service
            CIMChangeDERGroup.DERGroup_PortClient client;
            CIMData.header header = _data.CreateDERHeader;

            if (!hasData(header.EndPoint))
                throw new DERConfigureException("End Point required");

            client = new CIMChangeDERGroup.DERGroup_PortClient("DERGroup_Port", header.EndPoint);

            // Initialize service vars
            DERMSInterface.CIMChangeDERGroup.DERGroupRequestMessageType req = new DERMSInterface.CIMChangeDERGroup.DERGroupRequestMessageType();
            CIMChangeDERGroup.HeaderType to = new CIMChangeDERGroup.HeaderType();
            req.Header = to;

            // initialize  header
            CIMChangeDERGroup.HeaderTypeVerb v = new CIMChangeDERGroup.HeaderTypeVerb();
            if (header.Verb != null && Enum.TryParse(header.Verb, out v))
                to.Verb = v;
            else
                to.Verb = CIMChangeDERGroup.HeaderTypeVerb.change;
            to.Noun = header.Noun;
            to.ReplyAddress = header.ReplyAddress;
            to.Revision = header.Revision;
            to.Source = header.Source;
            to.AckRequired = header.AckRequired;
            if (to.AckRequired == true)
                to.AckRequiredSpecified = true;

            to.Comment = header.Comment;
            to.Context = header.Context;
            if (hasData(header.UserOrganization) || hasData(header.UserID))
            {
                to.User = new CIMChangeDERGroup.UserType();
                to.User.UserID = (hasData(header.UserID)) ? header.UserID : "epri"; // required
                to.User.Organization = header.UserOrganization; // optional
            }

            // initialize the payload
            req.Payload = new CIMChangeDERGroup.DERGroupPayloadType();
            req.Payload.DERGroups = new CIMChangeDERGroup.EndDeviceGroup[1];
            req.Payload.DERGroups[0] = new CIMChangeDERGroup.EndDeviceGroup();
            req.Payload.DERGroups[0].Version = new CIMChangeDERGroup.EndDeviceGroupVersion();
            req.Payload.DERGroups[0].Version.major = _data.Version.Major;
            req.Payload.DERGroups[0].Version.minor = _data.Version.Minor;
            req.Payload.DERGroups[0].Version.revision = _data.Version.Revision;
            req.Payload.DERGroups[0].Version.versionDate = _data.Version.Date;

            // find the data that matches the DER name passed
            CIMData.DERGroup group = _data.Groups.Find(x => x.GroupName.Equals(DERGroupName));
            if (group == null)
                throw new DERConfigureException("DERGroup Name " + DERGroupName + " not found in configuration file");
            else
            {
                req.Payload.DERGroups[0].name = group.GroupName;
                req.Payload.DERGroups[0].mRID = group.Mrid;
                List<CIMChangeDERGroup.DERMember> DERMembers = new List<CIMChangeDERGroup.DERMember>();

                // load the ders that go with the DER Group
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

                // Log outbound, send the message to DER Server, log return message
                _lastMessageSent = logMessage<DERMSInterface.CIMChangeDERGroup.DERGroupRequestMessageType>(req);
                DERMSInterface.CIMChangeDERGroup.DERGroupResponseMessageType reply = client.CreateDERGroup(req);
                _lastMessageReceived = logMessage<DERMSInterface.CIMChangeDERGroup.DERGroupResponseMessageType>(reply);

                if (reply.Reply.Result.CompareTo(CIMChangeDERGroup.ReplyTypeResult.OK) == 0)
                    return 0;
                return 1;
            }
        }


        /// <summary>
        /// send Get DER Group status SOAP message, get the status of the der
        /// </summary>
        /// <param name="mrid">unique identifier of DER group to be retrieved</param>
        /// <param name="q">real power or reactive power</param>
        /// <returns></returns>
        public CIMData.DERStatus getDERGroupStatus(String mrid, quantity q)
        {
            // initialize the soap call
            CIMGetDERGroupStatus.GetDERGroupStatus_PortClient client;
            CIMData.header header = _data.GetDERStatusHeader;

            if (!hasData(header.EndPoint))
                throw new DERConfigureException("End Point required");

            client = new CIMGetDERGroupStatus.GetDERGroupStatus_PortClient("GetDERGroupStatus_Port", header.EndPoint);

            // initialize the vars used for the SOAP call
            CIMGetDERGroupStatus.GetDERGroupStatusRequestMessageType req = new CIMGetDERGroupStatus.GetDERGroupStatusRequestMessageType();
            CIMGetDERGroupStatus.DERGroupStatusPayloadType payload = new CIMGetDERGroupStatus.DERGroupStatusPayloadType();
            CIMGetDERGroupStatus.HeaderType to = new CIMGetDERGroupStatus.HeaderType();
            req.Payload = payload;
            req.Header = to;
            req.Request = new CIMGetDERGroupStatus.GetDERGroupStatusRequestType();

            // build header

            CIMGetDERGroupStatus.HeaderTypeVerb v = new CIMGetDERGroupStatus.HeaderTypeVerb();
            if (Enum.TryParse(header.Verb, out v))
                to.Verb = v;
            else
                to.Verb = CIMGetDERGroupStatus.HeaderTypeVerb.get;
            to.Noun = header.Noun;
            to.ReplyAddress = header.ReplyAddress;
            to.Revision = header.Revision;
            to.Source = header.Source;
            to.AckRequired = header.AckRequired;
            if (to.AckRequired == true)
                to.AckRequiredSpecified = true;
            to.Comment = header.Comment;
            to.Context = header.Context;

            if (hasData(header.UserOrganization) || hasData(header.UserID))
            {
                to.User = new CIMGetDERGroupStatus.UserType();
                to.User.UserID = (hasData(header.UserID)) ? header.UserID : "epri"; // required
                to.User.Organization = header.UserOrganization; // optional
            }

            // load up the payload
            payload.DERGroupStatuses = new CIMGetDERGroupStatus.EndDeviceGroup[1];
            payload.DERGroupStatuses[0] = new CIMGetDERGroupStatus.EndDeviceGroup();
            payload.DERGroupStatuses[0].mRID = mrid;
            req.Payload.DERGroupStatuses[0].Version = new CIMGetDERGroupStatus.EndDeviceGroupVersion();
            req.Payload.DERGroupStatuses[0].Version.major = _data.Version.Major;
            req.Payload.DERGroupStatuses[0].Version.minor = _data.Version.Minor;
            req.Payload.DERGroupStatuses[0].Version.revision = _data.Version.Revision;
            req.Payload.DERGroupStatuses[0].Version.versionDate = _data.Version.Date;

            // log outgoing, call soap, log return message
            _lastMessageSent = logMessage<CIMGetDERGroupStatus.GetDERGroupStatusRequestMessageType>(req);
            CIMGetDERGroupStatus.DERGroupStatusResponseMessageType reply = client.GetDERGroupStatus(req);
            _lastMessageReceived = logMessage<CIMGetDERGroupStatus.DERGroupStatusResponseMessageType>(reply);

            // it should never return multiple groups, but just in case...
            CIMGetDERGroupStatus.EndDeviceGroup[] statuses = reply.Payload.DERGroupStatuses;
            if (statuses.Length > 1)
                throw new DERResponseException("GETDERGroupStatus returned multiple DER Groups.");
            else if (statuses.Length < 1)
                throw new DERResponseException("GETDERGroupStatus returned NO DER Groups.");
            else
            {
                // we're loading up our own object, DERStatus
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
                else if (q.Equals(quantity.ApparentPower))
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



        /// <summary>
        /// SOAP call to get the list of DERs within a DERGroup
        /// </summary>
        /// <param name="name">name of DERGroup</param>
        /// <returns>array of strings of DER member names</returns>
        public String[] requestDERGroupMembers(String mrid)
        {
            // initialize SOAP call
            CIMGetDERGroup.GetDERGroup_PortClient client;
            CIMData.header header = _data.GetDERHeader;
            if (!hasData(header.EndPoint))
                throw new DERConfigureException("End Point required");
            client = new CIMGetDERGroup.GetDERGroup_PortClient("GetDERGroupImplPort", header.EndPoint);

            // initialize SOAP vars
            CIMGetDERGroup.GetDERGroupRequestMessageType req = new CIMGetDERGroup.GetDERGroupRequestMessageType();
            CIMGetDERGroup.DERGroupPayloadType payload = new CIMGetDERGroup.DERGroupPayloadType();
            req.Payload = payload;
            req.Request = new CIMGetDERGroup.GetDERGroupRequestType();
            req.Request.StartTime = System.DateTime.Now;
            CIMGetDERGroup.HeaderType to = new CIMGetDERGroup.HeaderType();
            req.Header = to;

            // build header

            CIMGetDERGroup.HeaderTypeVerb v = new CIMGetDERGroup.HeaderTypeVerb();
            if (Enum.TryParse(header.Verb, out v))
                to.Verb = v;
            to.Verb = CIMGetDERGroup.HeaderTypeVerb.get;
            to.Noun = header.Noun;
            to.ReplyAddress = header.ReplyAddress;
            to.Revision = header.Revision;
            to.Source = header.Source;
            to.AckRequired = header.AckRequired;
            if (to.AckRequired == true)
                to.AckRequiredSpecified = true;
            to.Comment = header.Comment;
            to.Context = header.Context;
            if (hasData(header.UserOrganization) || hasData(header.UserID))
            {
                to.User = new CIMGetDERGroup.UserType();
                to.User.UserID = (hasData(header.UserID)) ? header.UserID : "epri"; // required
                to.User.Organization = header.UserOrganization; // optional
            }

            // load the SOAP payload
            payload.DERGroups = new CIMGetDERGroup.EndDeviceGroup[1];
            payload.DERGroups[0] = new CIMGetDERGroup.EndDeviceGroup();
            payload.DERGroups[0].mRID = mrid;

            payload.DERGroups[0].Version = new CIMGetDERGroup.EndDeviceGroupVersion();
            payload.DERGroups[0].Version.major = _data.Version.Major;
            payload.DERGroups[0].Version.minor = _data.Version.Minor;
            payload.DERGroups[0].Version.revision = _data.Version.Revision;
            payload.DERGroups[0].Version.versionDate = _data.Version.Date;

            //' log out message, make call, log return message
            _lastMessageSent = logMessage<CIMGetDERGroup.GetDERGroupRequestMessageType>(req);
            CIMGetDERGroup.DERGroupResponseMessageType reply = client.GetDERGroup(req);
            _lastMessageReceived = logMessage<CIMGetDERGroup.DERGroupResponseMessageType>(reply);

            if (reply.Payload.DERGroups != null && reply.Payload.DERGroups.Length > 0)
            {
                List<String> ders = new List<string>();
                foreach (CIMGetDERGroup.EndDeviceGroup dev in reply.Payload.DERGroups)
                {
                    ders.Add(dev.name);
                }
                return ders.ToArray();
            }
            return null;
        }

        /// <summary>
        /// convenience method to determine if string is empty
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private Boolean hasData(string s)
        {
            return (s != null && s.Length > 0);
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
    }
}
