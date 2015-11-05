package com.sixthc.client;

import java.net.URL;
import java.util.GregorianCalendar;

import javax.xml.datatype.DatatypeConfigurationException;
import javax.xml.datatype.DatatypeFactory;
import javax.xml.datatype.XMLGregorianCalendar;
import javax.xml.namespace.QName;
import javax.xml.ws.BindingProvider;

import org.apache.cxf.endpoint.Client;
import org.apache.cxf.frontend.ClientProxy;
import org.apache.log4j.Logger;
import org.multispeak.v5_0.commonarrays.ArrayOfAttachment;
import org.multispeak.v5_0.commonarrays.ArrayOfAttachmentContainer;
import org.multispeak.v5_0.commonarrays.ArrayOfAttachmentUnlinkContainer;
import org.multispeak.v5_0.commonarrays.ArrayOfDomainMember;
import org.multispeak.v5_0.commonarrays.ArrayOfObjectRef;
import org.multispeak.v5_0.commonarrays.ArrayOfString;
import org.multispeak.v5_0.commontypes.Duration;
import org.multispeak.v5_0.commontypes.ObjectID;
import org.multispeak.v5_0.commontypes.TimePeriod;
import org.multispeak.v5_0.sandboxarrays.ArrayOfDER;
import org.multispeak.v5_0.sandboxarrays.ArrayOfDERGroup;
import org.multispeak.v5_0.sandboxarrays.ArrayOfDERGroupDispatchRequest;
import org.multispeak.v5_0.sandboxarrays.ArrayOfDERGroupForecast;
import org.multispeak.v5_0.sandboxarrays.ArrayOfDERGroupID;
import org.multispeak.v5_0.sandboxarrays.ArrayOfDERGroupStatus;
import org.multispeak.v5_0.sandboxarrays.ArrayOfDERID;
import org.multispeak.v5_0.sandboxarrays.ArrayOfRequestedCapability;
import org.multispeak.v5_0.ws.request.MultiSpeakRequestMsgHeader;
import org.multispeak.v5_0.ws.response.MultiSpeakResponseMsgHeader;
import org.multispeak.v5_0.wsdl.sb_der_server.CreateDERGroups;
import org.multispeak.v5_0.wsdl.sb_der_server.SBDERServer;
import org.multispeak.v5_0.wsdl.sb_der_server.SBDERServerSoap;
import org.springframework.stereotype.Component;

@Component
public class DERGroupsClient extends RequestClient {

	private static org.apache.log4j.Logger log = Logger
			.getLogger(DERGroupsClient.class);

	URL wsdlURL = DERGroupsClient.class
			.getResource("/resources/wsdl/SB_DER_Server.wsdl");
	QName SERVICE_NAME = new QName(
			"http://www.multispeak.org/V5.0/wsdl/SB_DER_Server",
			"SB_DER_Server");

	public DERGroupsClient() {
		super();
	}

	public void createDERGroups(String address,
			MultiSpeakRequestMsgHeader multiSpeakMsgHeader, String responseURL,
			String transactionID, ArrayOfDERGroup arrayOfDERGroup) {

		SBDERServerSoap port = getPort(address);
		
		CreateDERGroups parameters = new CreateDERGroups();
		parameters.setArrayOfDERGroup(arrayOfDERGroup);
		parameters.setResponseURL(responseURL);
		parameters.setTransactionID(transactionID);
		
		port.createDERGroups(arrayOfDERGroup, responseURL, transactionID, multiSpeakMsgHeader, null);
	}

	public void deleteDERGroups(String address,
			MultiSpeakRequestMsgHeader multiSpeakMsgHeader, String responseURL,
			String transactionID, ArrayOfDERGroupID arrayOfDERGroupID) {

		SBDERServerSoap port = getPort(address);

		port.deleteDERGroups(arrayOfDERGroupID, responseURL, transactionID,
				multiSpeakMsgHeader, null);
	}

	/*
	 * 
	 */
	public ArrayOfDER getDERsByDERID(String address,
			MultiSpeakRequestMsgHeader multiSpeakMsgHeader,
			ArrayOfDERID arayOfDERID) {

		SBDERServerSoap port = getPort(address);

		ArrayOfDER a = port.getDERsByDERID(arayOfDERID, multiSpeakMsgHeader,
				null);
		return a;
	}

	/*
	 * 
	 */
	public ArrayOfAttachment getAttachmentsByObjectRefs(String address,
			MultiSpeakRequestMsgHeader header, ArrayOfObjectRef arrayOfObjectRef) {
		SBDERServerSoap port = getPort(address);

		ArrayOfAttachment a = port.getAttachmentsByObjectRefs(arrayOfObjectRef,
				header, null);
		return a;
	}

	public ArrayOfDomainMember getDomainMembers(String address,
			MultiSpeakRequestMsgHeader header, String domainName) {
		SBDERServerSoap port = getPort(address);

		ArrayOfDomainMember a = port.getDomainMembers(domainName, header, null);
		return a;
	}

	public void insertDERsInDERGroup(String address,
			MultiSpeakRequestMsgHeader header, ArrayOfDERID arayOfDERID,
			String responseURL, String transactionID, ObjectID derGroup) {
		SBDERServerSoap port = getPort(address);
		port.insertDERsInDERGroup(arayOfDERID, derGroup, responseURL,
				transactionID, header, null);
	}

	public ArrayOfDER getAllDERs(String address, String lastReceived,
			MultiSpeakRequestMsgHeader header) {
		SBDERServerSoap port = getPort(address);
		return port.getAllDERs(lastReceived, header, null);
	}

	public void unlinkAttachmentsFromObjects(String address,
			MultiSpeakRequestMsgHeader multiSpeakMsgHeader,
			ArrayOfAttachmentUnlinkContainer arrayOfAttachmentUnlinkContainer) {
		SBDERServerSoap port = getPort(address);
		port.unlinkAttachmentsFromObjects(arrayOfAttachmentUnlinkContainer,
				multiSpeakMsgHeader, null);
	}

	public ArrayOfString getMethods(String address,
			MultiSpeakRequestMsgHeader header) {
		SBDERServerSoap port = getPort(address);
		return port.getMethods(header, null);
	}

	public void removeDERsFromDERGroup(String address,
			MultiSpeakRequestMsgHeader header, ArrayOfDERID arayOfDERID,
			String responseURL, String transactionID, ObjectID derGroup) {
		SBDERServerSoap port = getPort(address);
		port.removeDERsFromDERGroup(arayOfDERID, derGroup, responseURL,
				transactionID, header, null);
	}

	public ArrayOfString getDomainNames(String address,
			MultiSpeakRequestMsgHeader multiSpeakMsgHeader) {
		SBDERServerSoap port = getPort(address);
		return port.getDomainNames(multiSpeakMsgHeader, null);
	}

	public void pingURL(String address,
			MultiSpeakRequestMsgHeader multiSpeakMsgHeader) {
		SBDERServerSoap port = getPort(address);
		port.pingURL(multiSpeakMsgHeader, null);

	}

	public ArrayOfDERGroupStatus getDERGroupStatusesByDERGroupIDs(
			String address, MultiSpeakRequestMsgHeader multiSpeakMsgHeader,
			ArrayOfDERGroupID arrayOfDERGroupID) {
		SBDERServerSoap port = getPort(address);
		return port.getDERGroupStatusesByDERGroupIDs(arrayOfDERGroupID,
				multiSpeakMsgHeader, null);
	}

	public void linkAttachmentsToObjects(String address,
			MultiSpeakRequestMsgHeader multiSpeakMsgHeader,
			ArrayOfAttachmentContainer arrayOfAttachmentContainer) {
		SBDERServerSoap port = getPort(address);
		port.linkAttachmentsToObjects(arrayOfAttachmentContainer,
				multiSpeakMsgHeader, null);
	}

	public void initiateDERGroupDispatchRequests(String address,
			MultiSpeakRequestMsgHeader header, String responseURL,
			String transactionID,
			ArrayOfDERGroupDispatchRequest arrayOfDERGroupDispatchRequest) {
		SBDERServerSoap port = getPort(address);
		port.initiateDERGroupDispatchRequests(arrayOfDERGroupDispatchRequest,
				responseURL, transactionID, header, null);
	}

	public ArrayOfDERGroupForecast getDERGroupForecasts(String address,
			Duration foreCastInterval, TimePeriod foreCastPeriod,
			ArrayOfDERGroup arrayOfDERGroup,
			ArrayOfRequestedCapability arrayOfRequestedCapability,
			MultiSpeakRequestMsgHeader header) {
		SBDERServerSoap port = getPort(address);
		return port.getDERGroupForecasts(foreCastInterval, foreCastPeriod,
				arrayOfDERGroup, arrayOfRequestedCapability, header, null);
	}

	private SBDERServerSoap getPort(String address) {
		log.debug("wsdlURL " + wsdlURL);
		log.debug("SERVICE_NAME " + SERVICE_NAME);

		SBDERServer ss = new SBDERServer(wsdlURL, SERVICE_NAME);
		SBDERServerSoap port = ss.getSBDERServerSoap();
		BindingProvider provider = (BindingProvider) port;

		provider.getRequestContext().put(
				BindingProvider.ENDPOINT_ADDRESS_PROPERTY, address);

		// Register all the logging interceptors
		Client cxfClient = ClientProxy.getClient(port);

		cxfClient.getInInterceptors().add(loggingInInterceptor);
		cxfClient.getInFaultInterceptors().add(loggingInFaultInterceptor);
		cxfClient.getOutInterceptors().add(loggingOutInterceptor);
		cxfClient.getOutFaultInterceptors().add(loggingOutFaultInterceptor);

		return port;
	}

	public static MultiSpeakResponseMsgHeader createMultiSpeakResponseMsgHeader() {
		MultiSpeakResponseMsgHeader h = new MultiSpeakResponseMsgHeader();
		h.setDefaultRegisteredName("epritest");
		h.setMessageID("467");
		h.setDefaultSystemName("test server");

		try {
			GregorianCalendar gcal = (GregorianCalendar) GregorianCalendar
					.getInstance();
			XMLGregorianCalendar xgcal;
			xgcal = DatatypeFactory.newInstance().newXMLGregorianCalendar(gcal);
			h.setTimeStamp(xgcal);
		} catch (DatatypeConfigurationException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return h;

	}

}
