using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERMSInterface
{
    public class Multispeak
    {
        private reqDER.MultiSpeakRequestMsgHeader _header = null;
        private string _endPoint = null;

        public string EndPoint
        {
            get { return _endPoint; }
            set { _endPoint = value; }
        }

        private string _responseAddress = null;
        public const string endPointName = "DERRequestImplPort";
        private string _endPointName = null;
        private reqDER.DERRequest_PortClient _client;

        public Multispeak(string endPointName)
        {
            initClass(endPointName, null, null, null);
        }

        public Multispeak(string endPointName, string endPoint, reqDER.MultiSpeakRequestMsgHeader header, string responseAddress)
        {
            initClass(endPointName, endPoint, header, responseAddress);
        }

        public void getDERGroup() {
            CIMGetDERGroup.GetDERGroup_PortClient client = new CIMGetDERGroup.GetDERGroup_PortClient("GetDERGroupImplPort");
            CIMGetDERGroup.HeaderType cimheader = new CIMGetDERGroup.HeaderType();
            CIMGetDERGroup.GetDERGroupRequestType req = new CIMGetDERGroup.GetDERGroupRequestType();
            CIMGetDERGroup.DERGroupPayloadType payload = new CIMGetDERGroup.DERGroupPayloadType();

            req.ID = new string[1];
            req.ID[0] = "DER1";
            
            CIMGetDERGroup.ReplyType reply = client.GetDERGroup(ref cimheader, req, ref payload);
        }




       
        public reqDER.DER[] getDERGroups(String endpoint, reqDER.MultiSpeakRequestMsgHeader header, reqDER.DERID[] ders)
        {
            reqDER.DERRequest_PortClient client = new reqDER.DERRequest_PortClient(_endPointName);
            return client.GetDERsByDERID(endpoint, header, ders);
        }

        public reqDER.DER[] getDERGroups(reqDER.DERID[] ders)
        {
            return getDERGroups(_endPoint, _header, ders);
        }


        public void dispatchDERGroup(string endpoint, reqDER.MultiSpeakRequestMsgHeader header, reqDER.DERGroupDispatchRequest[] request)
        {
            reqDER.DERRequest_PortClient client = new reqDER.DERRequest_PortClient(_endPointName);
            client.InitiateDERGroupDispatchRequests(endpoint, header, _responseAddress, getUUID(), request);
        }

        public void dispatchDERGroup(reqDER.DERGroupDispatchRequest[] request)
        {
            dispatchDERGroup(_endPoint, _header, request);
        }

        private String getUUID()
        {
            return System.Guid.NewGuid().ToString();
        }

        private void initClass(string endPointName, string endPoint, reqDER.MultiSpeakRequestMsgHeader header, string responseAddress)
        {
            _endPointName = endPointName;
            _client = new reqDER.DERRequest_PortClient(_endPointName);
            if (endPoint == null)
                _endPoint = _client.Endpoint.Address.ToString();
            else
                _endPoint = endPoint;

            if (responseAddress == null)
                _responseAddress = _client.Endpoint.ListenUri.ToString();
            else
            _responseAddress = responseAddress;


            if (header == null)
            {
                // create default, bogus header for all messages
                _header = new reqDER.MultiSpeakRequestMsgHeader();
                _header.MessageID = getUUID();
                _header.Caller = new reqDER.Caller();
                _header.Caller.AppName = "DermsInterface";
                _header.Caller.AppVersion = "1";
                _header.Caller.Company = "EEcorp";
                _header.Caller.SystemID = "12.3";
                _header.MultiSpeakVersion = new reqDER.MultiSpeakVersion();
                _header.MultiSpeakVersion.Build = "123";
                _header.MultiSpeakVersion.Branch = "0";
                _header.MultiSpeakVersion.MajorVersion = "1";
                _header.MultiSpeakVersion.MinorVersion = "0";
                _header.Caller.AuditID = "aid";
                _header.Caller.AuditPassword = "secret";
            }
        }
    }
}
