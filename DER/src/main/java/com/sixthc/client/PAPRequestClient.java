package com.sixthc.client;

import java.net.URL;

import javax.xml.ws.BindingProvider;
import javax.xml.ws.Holder;

import org.apache.cxf.endpoint.Client;
import org.apache.cxf.frontend.ClientProxy;
import org.apache.log4j.Logger;

import ch.iec.tc57._2011.schema.message.HeaderType;
import ch.iec.tc57._2011.schema.message.ReplyType;

import com.epri._2016.demandresponsedeploymentmessage.DemandResponseDeploymentPayloadType;
import com.epri._2016.demandresponsedeploymentmessage.DemandResponseDeploymentResponseMessageType;
import com.epri._2016.demandresponsedeploymentresponsemessage.DemandResponseDeploymentResponsePayloadType;
import com.epri._2016.demandresponsedeploymentresponsemessage.DemandResponseDeploymentResponseResponseMessageType;
import com.epri._2016.executedemandresponsedeployment.DemandResponseDeploymentPort;
import com.epri._2016.executedemandresponsedeployment.ExecuteDemandResponseDeployment;
import com.epri._2016.receivedemandresponsedeploymentresponse.DemandResponseDeploymentResponsePort;
import com.epri._2016.receivedemandresponsedeploymentresponse.ReceiveDemandResponseDeploymentResponse;
import com.sixthc.pap.request.CreateDemandResponseDeploymentRequest;
import com.sixthc.pap.request.CreateDemandResponseDeploymentResponseRequest;

public class PAPRequestClient extends RequestClient {

	private static org.apache.log4j.Logger log = Logger
			.getLogger(PAPRequestClient.class);

	public PAPRequestClient() {
		super();
	}

	public DemandResponseDeploymentResponseMessageType createDemandResponseDeployment(
			CreateDemandResponseDeploymentRequest message)
			throws com.epri._2016.executedemandresponsedeployment.FaultMessage {
		log.debug("client request :  createDemandResponseDeployment");
		URL wsdlURL = DERGroupsClient.class
				.getResource("/resources/wsdl/ExecuteDemandResponseDeployment.wsdl");

		ExecuteDemandResponseDeployment ss = new ExecuteDemandResponseDeployment(
				wsdlURL);
		DemandResponseDeploymentPort port = ss
				.getDemandResponseDeploymentPort();
		BindingProvider provider = (BindingProvider) port;

		provider.getRequestContext().put(
				BindingProvider.ENDPOINT_ADDRESS_PROPERTY,
				message.getRequestURL());

		// Register all the logging interceptors
		Client cxfClient = ClientProxy.getClient(port);

		cxfClient.getInInterceptors().add(loggingInInterceptor);
		cxfClient.getInFaultInterceptors().add(loggingInFaultInterceptor);
		cxfClient.getOutInterceptors().add(loggingOutInterceptor);
		cxfClient.getOutFaultInterceptors().add(loggingOutFaultInterceptor);

		// build the outgoing message
		Holder<ReplyType> replyTypeHolder = new Holder<ReplyType>();
		replyTypeHolder.value = new ReplyType();
		Holder<HeaderType> headerHolder = new Holder<HeaderType>();
		headerHolder.value = message.getPayload().getHeader();
		Holder<DemandResponseDeploymentPayloadType> payloadHolder = new Holder<DemandResponseDeploymentPayloadType>();
		payloadHolder.value = message.getPayload().getPayload();

		// execute the client call to the remote
		port.createDemandResponseDeployment(headerHolder, message.getPayload()
				.getRequest(), payloadHolder, replyTypeHolder);

		// build and return response
		DemandResponseDeploymentResponseMessageType response = new DemandResponseDeploymentResponseMessageType();
		response.setHeader(headerHolder.value);
		response.setPayload(payloadHolder.value);
		response.setReply(replyTypeHolder.value);

		return response;
	}

	public DemandResponseDeploymentResponseResponseMessageType createdDemandResponseDeploymentResponse(
			CreateDemandResponseDeploymentResponseRequest message)
			throws com.epri._2016.receivedemandresponsedeploymentresponse.FaultMessage {
		log.debug("client request :  createdDemandResponseDeploymentResponse");
		URL wsdlURL = DERGroupsClient.class
				.getResource("/resources/wsdl/ReceiveDemandResponseDeploymentResponse.wsdl");

		ReceiveDemandResponseDeploymentResponse ss = new ReceiveDemandResponseDeploymentResponse(
				wsdlURL);
		DemandResponseDeploymentResponsePort port = ss
				.getDemandResponseDeploymentResponsePort();
		BindingProvider provider = (BindingProvider) port;

		provider.getRequestContext().put(
				BindingProvider.ENDPOINT_ADDRESS_PROPERTY,
				message.getRequestURL());

		// Register all the logging interceptors
		Client cxfClient = ClientProxy.getClient(port);

		cxfClient.getInInterceptors().add(loggingInInterceptor);
		cxfClient.getInFaultInterceptors().add(loggingInFaultInterceptor);
		cxfClient.getOutInterceptors().add(loggingOutInterceptor);
		cxfClient.getOutFaultInterceptors().add(loggingOutFaultInterceptor);

		// build the outgoing message
		Holder<ReplyType> replyTypeHolder = new Holder<ReplyType>();
		replyTypeHolder.value = new ReplyType();
		Holder<HeaderType> headerHolder = new Holder<HeaderType>();
		headerHolder.value = message.getPayload().getHeader();
		Holder<DemandResponseDeploymentResponsePayloadType> payloadHolder = new Holder<DemandResponseDeploymentResponsePayloadType>();
		payloadHolder.value = message.getPayload().getPayload();

		// execute the client command to the remote host
		port.createdDemandResponseDeploymentResponse(headerHolder,
				payloadHolder, replyTypeHolder);

		// build and return the response
		DemandResponseDeploymentResponseResponseMessageType response = new DemandResponseDeploymentResponseResponseMessageType();
		response.setHeader(headerHolder.value);
		response.setPayload(payloadHolder.value);
		response.setReply(replyTypeHolder.value);

		return response;

	}	
}
