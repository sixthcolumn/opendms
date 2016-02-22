package com.sixthc.server.ws;

import javax.servlet.http.HttpServletRequest;
import javax.xml.ws.Holder;

import org.apache.commons.lang.StringUtils;
import org.apache.cxf.phase.PhaseInterceptorChain;
import org.apache.log4j.Logger;
import org.springframework.beans.BeansException;
import org.springframework.context.ApplicationContext;
import org.springframework.context.ApplicationContextAware;

import ch.iec.tc57._2011.schema.message.HeaderType;
import ch.iec.tc57._2011.schema.message.ReplyType;
import ch.iec.tc57._2011.schema.message.RequestType;

import com.epri._2013.dergroupdispatches.CapabilityType;
import com.epri._2013.dergroupdispatches.DERGroup;
import com.epri._2013.dergroupdispatches.DERGroupDispatch;
import com.epri._2013.dergroupdispatches.RequestedCapability;
import com.epri._2016.dergroupdispatchesmessage.DERGroupDispatchesPayloadType;
import com.epri._2016.executedergroupdispatches.DERGroupDispatchesPort;
import com.epri._2016.executedergroupdispatches.FaultMessage;

public class ChangeDERGroupDispatchImpl implements DERGroupDispatchesPort,
		ApplicationContextAware {



	private static org.apache.log4j.Logger log = Logger
			.getLogger(ChangeDERGroupDispatchImpl.class);

	ApplicationContext appContext;

	@Override
	public void setApplicationContext(ApplicationContext arg0)
			throws BeansException {
		appContext = arg0;
	}

	@Override
	public void createDERGroupDispatches(Holder<HeaderType> header,
			RequestType request, Holder<DERGroupDispatchesPayloadType> payload,
			Holder<ReplyType> reply) throws FaultMessage {

		log.debug("***** OPERATION : createDERGroupDispatch");

		DERGroupDispatch e = appContext.getBean("CMIDERGroupDispatch",
				DERGroupDispatch.class);
		
		HttpServletRequest request2 = (HttpServletRequest) PhaseInterceptorChain.getCurrentMessage().get("HTTP.REQUEST"); 
		log.debug("request : " + request2.getRemoteAddr());

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
		
		String messageID = header.value.getMessageID();
		if( StringUtils.isBlank(messageID) )
			log.warn("Message ID is empty");
		else
			header.value.setCorrelationID(messageID);

		ReplyType r = appContext.getBean(("ReplyTypeBean"), ReplyType.class);
		reply.value = r;

	}
}
