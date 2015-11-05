package com.sixthc.server.ws;

import java.util.List;
import java.util.Vector;

import org.apache.log4j.Logger;
import org.multispeak.v5.Attachment;
import org.multispeak.v5.DomainMember;
import org.multispeak.v5_0.commonarrays.ArrayOfAttachmentContainer;
import org.multispeak.v5_0.commonarrays.ArrayOfAttachmentUnlinkContainer;
import org.multispeak.v5_0.commonarrays.ArrayOfObjectRef;
import org.multispeak.v5_0.commontypes.Duration;
import org.multispeak.v5_0.commontypes.ObjectID;
import org.multispeak.v5_0.commontypes.TimePeriod;
import org.multispeak.v5_0.sandbox.DER;
import org.multispeak.v5_0.sandbox.DERGroupForecast;
import org.multispeak.v5_0.sandbox.DERGroupStatus;
import org.multispeak.v5_0.sandboxarrays.ArrayOfDERGroup;
import org.multispeak.v5_0.sandboxarrays.ArrayOfDERGroupDispatchRequest;
import org.multispeak.v5_0.sandboxarrays.ArrayOfDERGroupID;
import org.multispeak.v5_0.sandboxarrays.ArrayOfDERID;
import org.multispeak.v5_0.sandboxarrays.ArrayOfRequestedCapability;
import org.multispeak.v5_0.ws.request.MultiSpeakRequestMsgHeader;
import org.springframework.beans.BeansException;
import org.springframework.context.ApplicationContext;
import org.springframework.context.ApplicationContextAware;

import com.sixthc.client.DERGroupsClient;
import com.sixthc.wsdl.der_request.DERRequestPort;

public class DERRequestImpl implements DERRequestPort, ApplicationContextAware {
	private static org.apache.log4j.Logger log = Logger
			.getLogger(DERRequestImpl.class);
	DERGroupsClient client;
	ApplicationContext appContext;

	public DERGroupsClient getClient() {
		return client;
	}

	public void setClient(DERGroupsClient client) {
		this.client = client;
	}


	@Override
	public List<DomainMember> getDomainMembers(String address,
			MultiSpeakRequestMsgHeader multispeakMsgHeader, String domainName) {
		log.debug("REQUEST : getDomainMembers");
		return client
				.getDomainMembers(address, multispeakMsgHeader, domainName)
				.getDomainMember();
	}

	@Override
	public void insertDERsInDERGroup(String address,
			MultiSpeakRequestMsgHeader multiSpeakMsgHeader,
			ArrayOfDERID arayOfDERID, String responseURL, String transactionID,
			ObjectID derGroup) {
		log.debug("REQUEST : insertDERsInDERGroup");
		client.insertDERsInDERGroup(address, multiSpeakMsgHeader, arayOfDERID,
				responseURL, transactionID, derGroup);
	}

	@Override
	public void removeDERsFromDERGroup(String address,
			MultiSpeakRequestMsgHeader multiSpeakMsgHeader,
			ArrayOfDERID arayOfDERID, String responseURL, String transactionID,
			ObjectID derGroup) {
		log.debug("REQUEST : removeDERsFromDERGroup");
		client.removeDERsFromDERGroup(address, multiSpeakMsgHeader,
				arayOfDERID, responseURL, transactionID, derGroup);
	}

	@Override
	public List<Attachment> getAttachmentsByObjectRefs(String address,
			MultiSpeakRequestMsgHeader multiSpeakMsgHeader,
			ArrayOfObjectRef arrayOfObjectRef) {
		log.debug("REQUEST : getAttachmentsByObjectRefs");
		return client.getAttachmentsByObjectRefs(address, multiSpeakMsgHeader,
				arrayOfObjectRef).getAttachment();
	}

	@Override
	public List<String> getMethods(String address,
			MultiSpeakRequestMsgHeader multiSpeakMsgHeader) {
		log.debug("REQUEST : getMethods");
		Vector<String> list = new Vector<String>();
		list.add("method1");
		list.add("method2");
		return list;
	}

	@Override
	public List<DERGroupForecast> getDERGroupForecasts(String address,
			Duration foreCastInterval, TimePeriod foreCastPeriod,
			ArrayOfDERGroup arrayOfDERGroup,
			ArrayOfRequestedCapability arrayOfRequestedCapability,
			MultiSpeakRequestMsgHeader multiSpeakMsgHeader) {
		log.debug("REQUEST : getDERGroupForecasts");
		return client.getDERGroupForecasts(address, foreCastInterval,
				foreCastPeriod, arrayOfDERGroup, arrayOfRequestedCapability,
				multiSpeakMsgHeader).getDERGroupForecast();
	}

	@Override
	public void initiateDERGroupDispatchRequests(String address,
			MultiSpeakRequestMsgHeader multSpeakMsgHeader, String responseURL,
			String transactionID,
			ArrayOfDERGroupDispatchRequest arrayOfDERGroupDispatchRequest) {
		log.debug("REQUEST : initiateDERGroupDispatchRequests");
		client.initiateDERGroupDispatchRequests(address, multSpeakMsgHeader,
				responseURL, transactionID, arrayOfDERGroupDispatchRequest);
	}

	@Override
	public void linkAttachmentsToObjects(String address,
			MultiSpeakRequestMsgHeader multiSpeakMsgHeader,
			ArrayOfAttachmentContainer arrayOfAttachmentContainer) {
		log.debug("REQUEST : linkAttachmentsToObjects");
		client.linkAttachmentsToObjects(address, multiSpeakMsgHeader,
				arrayOfAttachmentContainer);
	}

	@Override
	public List<DER> getDERsByDERID(String address,
			MultiSpeakRequestMsgHeader multiSpeakMsgHeader,
			ArrayOfDERID arayOfDERID) {
		log.debug("REQUEST : getDERsByDERID");
		return client.getDERsByDERID(address, multiSpeakMsgHeader, arayOfDERID)
				.getDER();
	}


	@Override
	public List<DERGroupStatus> getDERGroupStatusesByDERGroupIDs(
			String address, MultiSpeakRequestMsgHeader multiSpeakMsgHeader,
			ArrayOfDERGroupID arrayOfDERGroupID) {
		log.debug("REQUEST : getDERGroupStatusesByDERGroupIDs");
		return client.getDERGroupStatusesByDERGroupIDs(address,
				multiSpeakMsgHeader, arrayOfDERGroupID).getDERGroupStatus();
	}

	@Override
	public void unlinkAttachmentsFromObjects(String address,
			MultiSpeakRequestMsgHeader multiSpeakMsgHeader,
			ArrayOfAttachmentUnlinkContainer arrayOfAttachmentUnlinkContainer) {
		log.debug("REQUEST : unlinkAttachmentsFromObjects");
		client.unlinkAttachmentsFromObjects(address, multiSpeakMsgHeader,
				arrayOfAttachmentUnlinkContainer);
	}

	@Override
	public void pingURL(String address,
			MultiSpeakRequestMsgHeader multiSpeakMsgHeader) {
		log.debug("REQUEST : pingURL");
		client.pingURL(address, multiSpeakMsgHeader);
	}

	@Override
	public List<DER> getAllDERs(String address, String lastReceived,
			MultiSpeakRequestMsgHeader multiSpeakMsgHeader) {
		log.debug("REQUEST : getAllDERs");
		return client.getAllDERs(address, lastReceived, multiSpeakMsgHeader)
				.getDER();
	}

	@Override
	public List<String> getDomainNames(String address,
			MultiSpeakRequestMsgHeader multiSpeakMsgHeader) {
		log.debug("REQUEST : getDomainNames");
		return client.getDomainNames(address, multiSpeakMsgHeader)
				.getTheString();
	}



	@Override
	public void setApplicationContext(ApplicationContext arg0)
			throws BeansException {
		appContext = arg0;
		
	}
	
	@Override
	public void deleteDERGroups(String address,
			MultiSpeakRequestMsgHeader multiSpeakMsgHeader, String responseURL,
			String transactionID, ArrayOfDERGroupID arrayOfDERGroupID) {
		log.debug("REQUEST : deleteDERGroups");
		client.deleteDERGroups(address, multiSpeakMsgHeader, responseURL,
				transactionID, arrayOfDERGroupID);
	}

	@Override
	public void createDERGroups(String address, String responseURL,
			String transactionID,
			MultiSpeakRequestMsgHeader multiSpeakMsgHeader,
			ArrayOfDERGroup arrayOfDERGroup) {
		client.createDERGroups(address, multiSpeakMsgHeader, responseURL, transactionID, arrayOfDERGroup);
		
	}

	

}
