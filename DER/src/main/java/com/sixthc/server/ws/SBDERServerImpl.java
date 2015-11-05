package com.sixthc.server.ws;

import javax.xml.ws.Holder;

import org.apache.log4j.Logger;
import org.multispeak.v5.Attachment;
import org.multispeak.v5.DomainMember;
import org.multispeak.v5_0.commonarrays.ArrayOfAttachment;
import org.multispeak.v5_0.commonarrays.ArrayOfAttachmentContainer;
import org.multispeak.v5_0.commonarrays.ArrayOfAttachmentUnlinkContainer;
import org.multispeak.v5_0.commonarrays.ArrayOfDomainMember;
import org.multispeak.v5_0.commonarrays.ArrayOfObjectRef;
import org.multispeak.v5_0.commonarrays.ArrayOfString;
import org.multispeak.v5_0.commontypes.Duration;
import org.multispeak.v5_0.commontypes.ObjectID;
import org.multispeak.v5_0.commontypes.TimePeriod;
import org.multispeak.v5_0.sandbox.DER;
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
import org.springframework.beans.BeansException;
import org.springframework.context.ApplicationContext;
import org.springframework.context.ApplicationContextAware;

public class SBDERServerImpl implements
		org.multispeak.v5_0.wsdl.sb_der_server.SBDERServerSoap,
		ApplicationContextAware {

	ApplicationContext appContext;

	private static org.apache.log4j.Logger log = Logger
			.getLogger(SBDERServerImpl.class);

	@Override
	public ArrayOfDER getDERsByDERID(ArrayOfDERID arrayOfDERID,
			MultiSpeakRequestMsgHeader multiSpeakRequestMsgHeader,
			Holder<MultiSpeakResponseMsgHeader> multiSpeakResponseMsgHeader) {

		// get default header from spring file
		multiSpeakResponseMsgHeader.value = appContext.getBean(
				"multiSpeakResponseMsgHeader",
				MultiSpeakResponseMsgHeader.class);

		// get default DER bean from spring
		DER bean = appContext.getBean("DERBean", DER.class);

		// intialize, load and return the array of DER
		ArrayOfDER a = new ArrayOfDER();
		a.getDER().add(bean);

		return a;
	}

	@Override
	public ArrayOfAttachment getAttachmentsByObjectRefs(
			ArrayOfObjectRef arrayOfObjectRef,
			MultiSpeakRequestMsgHeader multiSpeakRequestMsgHeader,
			Holder<MultiSpeakResponseMsgHeader> multiSpeakResponseMsgHeader) {

		multiSpeakResponseMsgHeader.value = appContext.getBean(
				"multiSpeakResponseMsgHeader",
				MultiSpeakResponseMsgHeader.class);

		Attachment bean = appContext
				.getBean("AttachmentBean", Attachment.class);
		ArrayOfAttachment aoa = new ArrayOfAttachment();
		aoa.getAttachment().add(bean);
		return aoa;
	}

	@Override
	public ArrayOfDERGroupForecast getDERGroupForecasts(
			Duration forecastInterval, TimePeriod forecastPeriod,
			ArrayOfDERGroup arrayOfDERGroup,
			ArrayOfRequestedCapability arrayOfRequestedCapability,
			MultiSpeakRequestMsgHeader multiSpeakRequestMsgHeader,
			Holder<MultiSpeakResponseMsgHeader> multiSpeakResponseMsgHeader) {

		multiSpeakResponseMsgHeader.value = appContext.getBean(
				"multiSpeakResponseMsgHeader",
				MultiSpeakResponseMsgHeader.class);

		ArrayOfDERGroupForecast af = new ArrayOfDERGroupForecast();

		return af;
	}

	@Override
	public ArrayOfDomainMember getDomainMembers(String domainName,
			MultiSpeakRequestMsgHeader multiSpeakRequestMsgHeader,
			Holder<MultiSpeakResponseMsgHeader> multiSpeakResponseMsgHeader) {

		multiSpeakResponseMsgHeader.value = appContext.getBean(
				"multiSpeakResponseMsgHeader",
				MultiSpeakResponseMsgHeader.class);

		ArrayOfDomainMember aod = new ArrayOfDomainMember();
		DomainMember bean = appContext
				.getBean("CMIDomainMember", DomainMember.class);
		
		aod.getDomainMember().add(bean);

		return aod;
	}

	@Override
	public ArrayOfDERGroupStatus getDERGroupStatusesByDERGroupIDs(
			ArrayOfDERGroupID arrayOfDERGroupID,
			MultiSpeakRequestMsgHeader multiSpeakRequestMsgHeader,
			Holder<MultiSpeakResponseMsgHeader> multiSpeakResponseMsgHeader) {

		multiSpeakResponseMsgHeader.value = appContext.getBean(
				"multiSpeakResponseMsgHeader",
				MultiSpeakResponseMsgHeader.class);

		ArrayOfDERGroupStatus adg = new ArrayOfDERGroupStatus();
	
		return adg;
	}

	@Override
	public void linkAttachmentsToObjects(
			ArrayOfAttachmentContainer arrayOfAttachmentContainer,
			MultiSpeakRequestMsgHeader multiSpeakRequestMsgHeader,
			Holder<MultiSpeakResponseMsgHeader> multiSpeakResponseMsgHeader) {

		multiSpeakResponseMsgHeader.value = appContext.getBean(
				"multiSpeakResponseMsgHeader",
				MultiSpeakResponseMsgHeader.class);

	}

	@Override
	public ArrayOfString getDomainNames(
			MultiSpeakRequestMsgHeader multiSpeakRequestMsgHeader,
			Holder<MultiSpeakResponseMsgHeader> multiSpeakResponseMsgHeader) {

		multiSpeakResponseMsgHeader.value = appContext.getBean(
				"multiSpeakResponseMsgHeader",
				MultiSpeakResponseMsgHeader.class);

		ArrayOfString aos = new ArrayOfString();
		aos.getTheString().add("string1");
		aos.getTheString().add("string2");

		return aos;
	}

	@Override
	public void insertDERsInDERGroup(ArrayOfDERID arrayOfDERID,
			ObjectID derGroupID, String responseURL, String transactionID,
			MultiSpeakRequestMsgHeader multiSpeakRequestMsgHeader,
			Holder<MultiSpeakResponseMsgHeader> multiSpeakResponseMsgHeader) {

		multiSpeakResponseMsgHeader.value = appContext.getBean(
				"multiSpeakResponseMsgHeader",
				MultiSpeakResponseMsgHeader.class);

	}

	@Override
	public void unlinkAttachmentsFromObjects(
			ArrayOfAttachmentUnlinkContainer arrayOfAttachmentUnlinkContainer,
			MultiSpeakRequestMsgHeader multiSpeakRequestMsgHeader,
			Holder<MultiSpeakResponseMsgHeader> multiSpeakResponseMsgHeader) {

		multiSpeakResponseMsgHeader.value = appContext.getBean(
				"multiSpeakResponseMsgHeader",
				MultiSpeakResponseMsgHeader.class);

	}

	@Override
	public ArrayOfString getMethods(
			MultiSpeakRequestMsgHeader multiSpeakRequestMsgHeader,
			Holder<MultiSpeakResponseMsgHeader> multiSpeakResponseMsgHeader) {

		multiSpeakResponseMsgHeader.value = appContext.getBean(
				"multiSpeakResponseMsgHeader",
				MultiSpeakResponseMsgHeader.class);
		ArrayOfString aos = new ArrayOfString();
		aos.getTheString().add("string1");
		aos.getTheString().add("string2");

		return aos;
	}

	@Override
	public void pingURL(MultiSpeakRequestMsgHeader multiSpeakRequestMsgHeader,
			Holder<MultiSpeakResponseMsgHeader> multiSpeakResponseMsgHeader) {
		multiSpeakResponseMsgHeader.value = appContext.getBean(
				"multiSpeakResponseMsgHeader",
				MultiSpeakResponseMsgHeader.class);
	}

	@Override
	public ArrayOfDER getAllDERs(String lastReceived,
			MultiSpeakRequestMsgHeader multiSpeakRequestMsgHeader,
			Holder<MultiSpeakResponseMsgHeader> multiSpeakResponseMsgHeader) {

		multiSpeakResponseMsgHeader.value = appContext.getBean(
				"multiSpeakResponseMsgHeader",
				MultiSpeakResponseMsgHeader.class);
		// get default DER bean from spring
		DER bean = appContext.getBean("DERBean", DER.class);

		// intialize, load and return the array of DER
		ArrayOfDER a = new ArrayOfDER();
		a.getDER().add(bean);

		return a;
	}

	@Override
	public void removeDERsFromDERGroup(ArrayOfDERID arrayOfDERID,
			ObjectID derGroupID, String responseURL, String transactionID,
			MultiSpeakRequestMsgHeader multiSpeakRequestMsgHeader,
			Holder<MultiSpeakResponseMsgHeader> multiSpeakResponseMsgHeader) {

		multiSpeakResponseMsgHeader.value = appContext.getBean(
				"multiSpeakResponseMsgHeader",
				MultiSpeakResponseMsgHeader.class);

	}

	@Override
	public void initiateDERGroupDispatchRequests(
			ArrayOfDERGroupDispatchRequest arrayOfDERGroupDispatchRequest,
			String responseURL, String transactionID,
			MultiSpeakRequestMsgHeader multiSpeakRequestMsgHeader,
			Holder<MultiSpeakResponseMsgHeader> multiSpeakResponseMsgHeader) {

		multiSpeakResponseMsgHeader.value = appContext.getBean(
				"multiSpeakResponseMsgHeader",
				MultiSpeakResponseMsgHeader.class);

	}

	@Override
	public void deleteDERGroups(ArrayOfDERGroupID arrayOfDERGroupID,
			String responseURL, String transactionID,
			MultiSpeakRequestMsgHeader multiSpeakRequestMsgHeader,
			Holder<MultiSpeakResponseMsgHeader> multiSpeakResponseMsgHeader) {
		multiSpeakResponseMsgHeader.value = appContext.getBean(
				"multiSpeakResponseMsgHeader",
				MultiSpeakResponseMsgHeader.class);

	}

	@Override
	public void setApplicationContext(ApplicationContext arg0)
			throws BeansException {
		appContext = arg0;

	}


	@Override
	public void createDERGroups(ArrayOfDERGroup arrayOfDERGroup,
			String responseURL, String transactionID,
			MultiSpeakRequestMsgHeader multiSpeakRequestMsgHeader,
			Holder<MultiSpeakResponseMsgHeader> multiSpeakResponseMsgHeader) {
		multiSpeakResponseMsgHeader.value = appContext.getBean(
				"multiSpeakResponseMsgHeader",
				MultiSpeakResponseMsgHeader.class);
		
	}

}
