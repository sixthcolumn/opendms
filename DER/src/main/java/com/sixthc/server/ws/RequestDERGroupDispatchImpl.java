package com.sixthc.server.ws;

import javax.xml.ws.Holder;

import org.apache.log4j.Logger;
import org.springframework.beans.BeansException;
import org.springframework.context.ApplicationContext;
import org.springframework.context.ApplicationContextAware;

import ch.iec.tc57._2011.dergroupdispatchmessage.DERGroupDispatchPayloadType;
import ch.iec.tc57._2011.requestdergroupdispatch.DERGroupDispatchPort;
import ch.iec.tc57._2011.schema.message.HeaderType;
import ch.iec.tc57._2011.schema.message.ReplyType;
import ch.iec.tc57._2011.schema.message.RequestType;

import com.epri._2013.dergroupdispatch.CapabilityType;
import com.epri._2013.dergroupdispatch.DERGroup;
import com.epri._2013.dergroupdispatch.DERGroupDispatch;
import com.epri._2013.dergroupdispatch.RequestedCapability;

public class RequestDERGroupDispatchImpl implements DERGroupDispatchPort,
		ApplicationContextAware {

	private static org.apache.log4j.Logger log = Logger
			.getLogger(RequestDERGroupDispatchImpl.class);

	ApplicationContext appContext;

	@Override
	public void setApplicationContext(ApplicationContext arg0)
			throws BeansException {
		appContext = arg0;
	}

	@Override
	public void createDERGroupDispatch(Holder<HeaderType> header,
			RequestType request, Holder<DERGroupDispatchPayloadType> payload,
			Holder<ReplyType> reply)
			throws ch.iec.tc57._2011.requestdergroupdispatch.FaultMessage {
		log.debug("***** OPERATION : createDERGroupDispatch");

		DERGroupDispatch e = appContext.getBean("CMIDERGroupDispatch",
				DERGroupDispatch.class);

		DERGroup dg = appContext.getBean("CMIDERGroup2", DERGroup.class);
		e.setDERGroup(dg);
		RequestedCapability rc = new RequestedCapability();
		rc.setCapabilityMultiplier("M");
		rc.setCapabilityType(CapabilityType.REAL_POWER);
		rc.setCapabilityUnits("VA");
		rc.setValue((float) 1.70);
		e.setRequestedCapability(rc);

		payload.value.getDERGroupDispatches().getDERGroupDispatch().clear();
		payload.value.getDERGroupDispatches().getDERGroupDispatch().add(e);

		ReplyType r = appContext.getBean(("ReplyTypeBean"), ReplyType.class);
		reply.value = r;

	}

	@Override
	public void cancelDERGroupDispatch(Holder<HeaderType> header,
			RequestType request, Holder<DERGroupDispatchPayloadType> payload,
			Holder<ReplyType> reply)
			throws ch.iec.tc57._2011.requestdergroupdispatch.FaultMessage {
		log.debug("***** OPERATION : cancelDERGroupDispatch");
		throw new ch.iec.tc57._2011.requestdergroupdispatch.FaultMessage(
				"Operation Not Supported");

	}

	@Override
	public void deleteDERGroupDispatch(Holder<HeaderType> header,
			RequestType request, Holder<DERGroupDispatchPayloadType> payload,
			Holder<ReplyType> reply)
			throws ch.iec.tc57._2011.requestdergroupdispatch.FaultMessage {
		log.debug("***** OPERATION : deleteDERGroupDispatch");
		throw new ch.iec.tc57._2011.requestdergroupdispatch.FaultMessage(
				"Operation Not Supported");

	}

	@Override
	public void closeDERGroupDispatch(Holder<HeaderType> header,
			RequestType request, Holder<DERGroupDispatchPayloadType> payload,
			Holder<ReplyType> reply)
			throws ch.iec.tc57._2011.requestdergroupdispatch.FaultMessage {
		log.debug("***** OPERATION : closeDERGroupDispatch");
		throw new ch.iec.tc57._2011.requestdergroupdispatch.FaultMessage(
				"Operation Not Supported");

	}

	@Override
	public void changeDERGroupDispatch(Holder<HeaderType> header,
			RequestType request, Holder<DERGroupDispatchPayloadType> payload,
			Holder<ReplyType> reply)
			throws ch.iec.tc57._2011.requestdergroupdispatch.FaultMessage {
		log.debug("***** OPERATION : changeDERGroupDispatch");
		throw new ch.iec.tc57._2011.requestdergroupdispatch.FaultMessage(
				"Operation Not Supported");

	}

}
