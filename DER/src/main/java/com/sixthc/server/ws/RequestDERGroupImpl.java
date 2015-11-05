package com.sixthc.server.ws;

import javax.xml.ws.Holder;

import org.apache.log4j.Logger;
import org.springframework.beans.BeansException;
import org.springframework.context.ApplicationContext;
import org.springframework.context.ApplicationContextAware;

import ch.iec.tc57._2011.dergroupmessage.DERGroupPayloadType;
import ch.iec.tc57._2011.requestdergroup.DERGroupPort;
import ch.iec.tc57._2011.requestdergroup.FaultMessage;
import ch.iec.tc57._2011.schema.message.HeaderType;
import ch.iec.tc57._2011.schema.message.ReplyType;
import ch.iec.tc57._2011.schema.message.RequestType;

import com.epri._2013.dergroup.DERGroups;
import com.epri._2013.dergroup.EndDeviceGroup;




public class RequestDERGroupImpl implements DERGroupPort, ApplicationContextAware {

	private static org.apache.log4j.Logger log = Logger
			.getLogger(RequestDERGroupImpl.class);
	
	
	ApplicationContext appContext;
	
	@Override
	public void setApplicationContext(ApplicationContext arg0)
			throws BeansException {
		appContext = arg0;
	}



	@Override
	public void deleteDERGroup(Holder<HeaderType> header, RequestType request,
			Holder<DERGroupPayloadType> payload, Holder<ReplyType> reply)
			throws FaultMessage {
		log.debug("***** OPERATION : deleteDERGroup");
		
		DERGroups groups = new DERGroups();
		EndDeviceGroup e =  appContext.getBean(
				"CMIDERGroupPower",
				EndDeviceGroup.class);
		groups.getEndDeviceGroup().add(e);

		
		payload.value.getDERGroups().getEndDeviceGroup().clear();
		payload.value.setDERGroups(groups);
		
		ReplyType r = appContext.getBean(("ReplyTypeBean"), ReplyType.class);
		reply.value = r;
	}

	@Override
	public void cancelDERGroup(Holder<HeaderType> header, RequestType request,
			Holder<DERGroupPayloadType> payload, Holder<ReplyType> reply)
			throws FaultMessage {
		log.error("***** OPERATION : cancelDERGroup");
		throw new FaultMessage("Operation not supported");
	}

	@Override
	public void changeDERGroup(Holder<HeaderType> header, RequestType request,
			Holder<DERGroupPayloadType> payload, Holder<ReplyType> reply)
			throws FaultMessage {

		log.debug("***** OPERATION : changeDERGroup");
		
		DERGroups groups = new DERGroups();
		EndDeviceGroup e =  appContext.getBean(
				"CMIDERGroupPower",
				EndDeviceGroup.class);
		groups.getEndDeviceGroup().add(e);

		
		payload.value.getDERGroups().getEndDeviceGroup().clear();
		payload.value.setDERGroups(groups);
		
		ReplyType r = appContext.getBean(("ReplyTypeBean"), ReplyType.class);
		reply.value = r;
		
	}

	@Override
	public void createDERGroup(Holder<HeaderType> header, RequestType request,
			Holder<DERGroupPayloadType> payload, Holder<ReplyType> reply)
			throws FaultMessage {

		log.debug("***** OPERATION : createDERGroup");
		
		DERGroups groups = new DERGroups();
		EndDeviceGroup e =  appContext.getBean(
				"CMIDERGroupPower",
				EndDeviceGroup.class);
		groups.getEndDeviceGroup().add(e);

		
		payload.value.getDERGroups().getEndDeviceGroup().clear();
		payload.value.setDERGroups(groups);
		
		ReplyType r = appContext.getBean(("ReplyTypeBean"), ReplyType.class);
		reply.value = r;
		
	}

	@Override
	public void closeDERGroup(Holder<HeaderType> header, RequestType request,
			Holder<DERGroupPayloadType> payload, Holder<ReplyType> reply)
			throws FaultMessage {
		log.error("***** OPERATION : closeDERGroup");
		throw new FaultMessage("Operation not supported");
		
	}

}
