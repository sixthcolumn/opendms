package com.sixthc.server.ws;

import org.apache.log4j.Logger;
import org.springframework.beans.BeansException;
import org.springframework.context.ApplicationContext;
import org.springframework.context.ApplicationContextAware;

import com.epri._2016.demandresponsedeploymentmessage.DemandResponseDeploymentResponseMessageType;
import com.epri._2016.demandresponsedeploymentresponsemessage.DemandResponseDeploymentResponseResponseMessageType;
import com.sixthc.client.PAPRequestClient;
import com.sixthc.pap.PapRequestServerSoap;
import com.sixthc.pap.request.CreateDemandResponseDeploymentRequest;
import com.sixthc.pap.request.CreateDemandResponseDeploymentResponseRequest;

public class PAPRequestImpl implements PapRequestServerSoap,
		ApplicationContextAware {

	ApplicationContext appContext;
	private static org.apache.log4j.Logger log = Logger
			.getLogger(PAPRequestImpl.class);

	PAPRequestClient client;

	public PAPRequestClient getClient() {
		return client;
	}

	public void setClient(PAPRequestClient client) {
		this.client = client;

	}

	@Override
	public void setApplicationContext(ApplicationContext arg0)
			throws BeansException {

		appContext = arg0;

	}


	@Override
	public DemandResponseDeploymentResponseResponseMessageType createdDemandResponseDeploymentResponse(
			CreateDemandResponseDeploymentResponseRequest message) {
		log.debug("***** REQUEST : createdDemandResponseDeploymentResponse");

		try {
			return client.createdDemandResponseDeploymentResponse(message);
		} catch (com.epri._2016.receivedemandresponsedeploymentresponse.FaultMessage e) {
			log.error(e);
		}
		return null;

	}

	@Override
	public DemandResponseDeploymentResponseMessageType createDemandResponseDeployment(
			CreateDemandResponseDeploymentRequest message) {
		log.debug("***** REQUEST : createDemandResponseDeployment");
		try {
			return client.createDemandResponseDeployment(message);
		} catch (com.epri._2016.executedemandresponsedeployment.FaultMessage e) {
			log.error(e);
		}
		return null;
	}

}
