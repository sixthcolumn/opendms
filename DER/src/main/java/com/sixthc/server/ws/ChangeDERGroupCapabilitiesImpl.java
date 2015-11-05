package com.sixthc.server.ws;

import javax.xml.ws.Holder;

import org.apache.log4j.Logger;
import org.springframework.beans.BeansException;
import org.springframework.context.ApplicationContext;
import org.springframework.context.ApplicationContextAware;

import ch.iec.tc57._2011.getdergroupcapability.FaultMessage;
import ch.iec.tc57._2011.getdergroupcapability.GetDERGroupCapabilityPort;
import ch.iec.tc57._2011.getdergroupcapabilitymessage.GetDERGroupCapabilityPayloadType;
import ch.iec.tc57._2011.getdergroupcapabilitymessage.GetDERGroupCapabilityRequestType;
import ch.iec.tc57._2011.schema.message.HeaderType;
import ch.iec.tc57._2011.schema.message.ReplyType;


public class ChangeDERGroupCapabilitiesImpl implements
		GetDERGroupCapabilityPort, ApplicationContextAware {

	private static org.apache.log4j.Logger log = Logger
			.getLogger(ChangeDERGroupCapabilitiesImpl.class);

	ApplicationContext appContext;

	@Override
	public void setApplicationContext(ApplicationContext arg0)
			throws BeansException {
		appContext = arg0;
	}


	@Override
	public void getDERGroupCapability(Holder<HeaderType> header,
			GetDERGroupCapabilityRequestType request,
			Holder<GetDERGroupCapabilityPayloadType> payload,
			Holder<ReplyType> reply) throws FaultMessage {
		log.debug("getDERGroupCapability");
		
		ReplyType r = appContext.getBean(("ReplyTypeBean"), ReplyType.class);
		reply.value = r;
	}

}
