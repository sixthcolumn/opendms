package com.sixthc.server.ws;

import javax.xml.ws.Holder;

import org.apache.log4j.Logger;
import org.springframework.beans.BeansException;
import org.springframework.context.ApplicationContext;
import org.springframework.context.ApplicationContextAware;

import ch.iec.tc57._2011.schema.message.HeaderType;
import ch.iec.tc57._2011.schema.message.ReplyType;
import ch.iec.tc57._2011.schema.message.RequestType;

import com.epri._2016.demandresponsedeploymentmessage.DemandResponseDeploymentPayloadType;
import com.epri._2016.demandresponsedeploymentresponsemessage.DemandResponseDeploymentResponsePayloadType;
import com.epri._2016.executedemandresponsedeployment.FaultMessage;
import com.epri._2016.receivedemandresponsedeploymentresponse.DemandResponseDeploymentResponsePort;

public class CreateDemandResponseDeploymentResponseImpl implements
		DemandResponseDeploymentResponsePort, ApplicationContextAware {
	private static org.apache.log4j.Logger log = Logger
			.getLogger(CreateDemandResponseDeploymentResponseImpl.class);
	ApplicationContext appContext;

	public void setApplicationContext(ApplicationContext arg0)
			throws BeansException {
		appContext = arg0;
	}

	public void createDemandResponseDeployment(Holder<HeaderType> header,
			RequestType request,
			Holder<DemandResponseDeploymentPayloadType> payload,
			Holder<ReplyType> reply) throws FaultMessage {
		
		log.debug("createDemandResponseDeployment");

		ReplyType r = appContext.getBean(("ReplyTypeBean"), ReplyType.class);
		reply.value = r;
	}

	@Override
	public void createdDemandResponseDeploymentResponse(
			Holder<HeaderType> header,
			Holder<DemandResponseDeploymentResponsePayloadType> payload,
			Holder<ReplyType> reply)
			throws com.epri._2016.receivedemandresponsedeploymentresponse.FaultMessage {
		log.debug("createDemandResponseDeploymentResponse");

		ReplyType r = appContext.getBean(("ReplyTypeBean"), ReplyType.class);
		reply.value = r;
	}

}
