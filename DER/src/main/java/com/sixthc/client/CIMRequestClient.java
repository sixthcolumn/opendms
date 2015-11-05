package com.sixthc.client;

import java.net.URL;

import javax.xml.namespace.QName;
import javax.xml.ws.BindingProvider;
import javax.xml.ws.Holder;

import org.apache.cxf.endpoint.Client;
import org.apache.cxf.frontend.ClientProxy;
import org.apache.log4j.Logger;

import ch.iec.tc57._2011.dergroupdispatchmessage.DERGroupDispatchPayloadType;
import ch.iec.tc57._2011.dergroupdispatchmessage.DERGroupDispatchRequestMessageType;
import ch.iec.tc57._2011.dergroupdispatchmessage.DERGroupDispatchResponseMessageType;
import ch.iec.tc57._2011.dergroupforecastmessage.DERGroupForecastPayloadType;
import ch.iec.tc57._2011.dergroupforecastmessage.DERGroupForecastResponseMessageType;
import ch.iec.tc57._2011.dergroupmessage.DERGroupPayloadType;
import ch.iec.tc57._2011.dergroupmessage.DERGroupResponseMessageType;
import ch.iec.tc57._2011.getdergroup.GetDERGroup;
import ch.iec.tc57._2011.getdergroup.GetDERGroupPort;
import ch.iec.tc57._2011.getdergroupcapability.GetDERGroupCapability;
import ch.iec.tc57._2011.getdergroupcapability.GetDERGroupCapabilityPort;
import ch.iec.tc57._2011.getdergroupcapabilitymessage.GetDERGroupCapabilityPayloadType;
import ch.iec.tc57._2011.getdergroupcapabilitymessage.GetDERGroupCapabilityResponseMessageType;
import ch.iec.tc57._2011.getdergroupstatus.GetDERGroupStatus;
import ch.iec.tc57._2011.getdergroupstatus.GetDERGroupStatusPort;
import ch.iec.tc57._2011.getdergroupstatusmessage.DERGroupStatusPayloadType;
import ch.iec.tc57._2011.getdergroupstatusmessage.DERGroupStatusResponseMessageType;
import ch.iec.tc57._2011.requestdergroup.DERGroupPort;
import ch.iec.tc57._2011.requestdergroup.FaultMessage;
import ch.iec.tc57._2011.requestdergroup.RequestDERGroup;
import ch.iec.tc57._2011.requestdergroupdispatch.DERGroupDispatchPort;
import ch.iec.tc57._2011.requestdergroupdispatch.RequestDERGroupDispatch;
import ch.iec.tc57._2011.requestdergroupforecast.DERGroupForecastPort;
import ch.iec.tc57._2011.requestdergroupforecast.RequestDERGroupForecast;
import ch.iec.tc57._2011.schema.message.HeaderType;
import ch.iec.tc57._2011.schema.message.ReplyType;
import ch.iec.tc57._2011.schema.message.RequestType;

import com.sixthc.cim.request.ChangeDERGroupCapabilityRequest;
import com.sixthc.cim.request.ChangeDERGroupForecastRequest;
import com.sixthc.cim.request.GetDERGroupCapabilityRequest;
import com.sixthc.cim.request.GetDERGroupStatusRequest;
import com.sixthc.cim.request.GetDERGroupsRequest;
import com.sixthc.cim.request.RequestDERGroupsRequest;

public class CIMRequestClient extends RequestClient {

	private static org.apache.log4j.Logger log = Logger
			.getLogger(DERGroupsClient.class);

	URL wsdlURL = DERGroupsClient.class
			.getResource("/resources/wsdl/SB_DER_Server.wsdl");
	QName SERVICE_NAME = new QName(
			"http://www.multispeak.org/V5.0/wsdl/SB_DER_Server",
			"SB_DER_Server");

	public CIMRequestClient() {
		super();
	}

	public DERGroupResponseMessageType changeDERGroup(
			RequestDERGroupsRequest message) throws FaultMessage {
		log.debug("client request :  changedDERGroup");
		URL wsdlURL = DERGroupsClient.class
				.getResource("/resources/wsdl/RequestDERGroup.wsdl");
		

		RequestDERGroup ss = new RequestDERGroup(wsdlURL);
		DERGroupPort port = ss.getDERGroupPort();
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

		Holder<ReplyType> replyTypeHolder = new Holder<ReplyType>();
		replyTypeHolder.value = new ReplyType();
		Holder<HeaderType> headerHolder = new Holder<HeaderType>();
		headerHolder.value = message.getPayload().getHeader();
		Holder<DERGroupPayloadType> payloadHolder = new Holder<DERGroupPayloadType>();
		payloadHolder.value = message.getPayload().getPayload();

		port.changeDERGroup(headerHolder, message.getPayload().getRequest(),
				payloadHolder, replyTypeHolder);

		DERGroupResponseMessageType response = new DERGroupResponseMessageType();
		response.setHeader(headerHolder.value);
		response.setPayload(payloadHolder.value);
		response.setReply(replyTypeHolder.value);

		return response;
	}

	public DERGroupResponseMessageType createDERGroup(
			RequestDERGroupsRequest message) throws FaultMessage {
		log.debug("client request :  changedDERGroup");
		URL wsdlURL = DERGroupsClient.class
				.getResource("/resources/wsdl/RequestDERGroup.wsdl");
		

		RequestDERGroup ss = new RequestDERGroup(wsdlURL);
		DERGroupPort port = ss.getDERGroupPort();
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

		Holder<ReplyType> replyTypeHolder = new Holder<ReplyType>();
		replyTypeHolder.value = new ReplyType();
		Holder<HeaderType> headerHolder = new Holder<HeaderType>();
		headerHolder.value = message.getPayload().getHeader();
		Holder<DERGroupPayloadType> payloadHolder = new Holder<DERGroupPayloadType>();
		payloadHolder.value = message.getPayload().getPayload();

		port.createDERGroup(headerHolder, message.getPayload().getRequest(),
				payloadHolder, replyTypeHolder);

		DERGroupResponseMessageType response = new DERGroupResponseMessageType();
		response.setHeader(headerHolder.value);
		response.setPayload(payloadHolder.value);
		response.setReply(replyTypeHolder.value);

		return response;
	}

	public DERGroupResponseMessageType deleteDERGroup(
			RequestDERGroupsRequest message) throws FaultMessage {
		URL wsdlURL = DERGroupsClient.class
				.getResource("/resources/wsdl/RequestDERGroup.wsdl");
		

		RequestDERGroup ss = new RequestDERGroup(wsdlURL);
		DERGroupPort port = ss.getDERGroupPort();
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

		Holder<ReplyType> replyTypeHolder = new Holder<ReplyType>();
		replyTypeHolder.value = new ReplyType();
		Holder<HeaderType> headerHolder = new Holder<HeaderType>();
		headerHolder.value = message.getPayload().getHeader();
		Holder<DERGroupPayloadType> payloadHolder = new Holder<DERGroupPayloadType>();
		payloadHolder.value = message.getPayload().getPayload();

		port.deleteDERGroup(headerHolder, message.getPayload().getRequest(),
				payloadHolder, replyTypeHolder);

		DERGroupResponseMessageType response = new DERGroupResponseMessageType();
		response.setHeader(headerHolder.value);
		response.setPayload(payloadHolder.value);
		response.setReply(replyTypeHolder.value);

		return response;
	}

	public ch.iec.tc57._2011.getdergroupmessage.DERGroupResponseMessageType getDERGroup(
			GetDERGroupsRequest message)
			throws ch.iec.tc57._2011.getdergroup.FaultMessage {
		log.debug("client request :  getDERGroups");
		URL wsdlURL = DERGroupsClient.class
				.getResource("/resources/wsdl/GetDERGroup.wsdl");
		

		GetDERGroup ss = new GetDERGroup(wsdlURL);
		GetDERGroupPort port = ss.getGetDERGroupPort();
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

		Holder<HeaderType> headerHolder = new Holder<HeaderType>();
		headerHolder.value = message.getPayload().getHeader();
		Holder<ch.iec.tc57._2011.getdergroupmessage.DERGroupPayloadType> payloadHolder = new Holder<ch.iec.tc57._2011.getdergroupmessage.DERGroupPayloadType>();
		payloadHolder.value = message.getPayload().getPayload();
		Holder<ReplyType> replyHolder = new Holder<ReplyType>();
		replyHolder.value = new ReplyType();

		port.getDERGroup(headerHolder, message.getPayload().getRequest(),
				payloadHolder, replyHolder);

		ch.iec.tc57._2011.getdergroupmessage.DERGroupResponseMessageType response = new ch.iec.tc57._2011.getdergroupmessage.DERGroupResponseMessageType();
		response.setHeader(headerHolder.value);
		response.setPayload(payloadHolder.value);
		response.setReply(replyHolder.value);

		return response;
	}


	public GetDERGroupCapabilityResponseMessageType getDERGroupCapabilities(
			GetDERGroupCapabilityRequest message) {
		log.debug("client request :  getDERGroupCapabilities");
		URL wsdlURL = DERGroupsClient.class
				.getResource("/resources/wsdl/GetDERGroupCapability.wsdl");
		

		GetDERGroupCapability ss = new GetDERGroupCapability(wsdlURL);
		GetDERGroupCapabilityPort port = ss.getGetDERGroupCapabilityPort();

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

		Holder<HeaderType> headerHolder = new Holder<HeaderType>();
		headerHolder.value = message.getPayload().getHeader();
		Holder<GetDERGroupCapabilityPayloadType> payloadHolder = new Holder<GetDERGroupCapabilityPayloadType>();
		payloadHolder.value = message.getPayload().getPayload();
		Holder<ReplyType> replyHolder = new Holder<ReplyType>();
		replyHolder.value = new ReplyType();

		try {
			port.getDERGroupCapability(headerHolder, message.getPayload()
					.getRequest(), payloadHolder, replyHolder);
			GetDERGroupCapabilityResponseMessageType response = new GetDERGroupCapabilityResponseMessageType();

			response.setHeader(headerHolder.value);
			response.setPayload(payloadHolder.value);
			response.setReply(replyHolder.value);

			return response;
		} catch (ch.iec.tc57._2011.getdergroupcapability.FaultMessage e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;

	}

	public DERGroupForecastResponseMessageType createDERGroupForecast(
			ChangeDERGroupForecastRequest message) {
		log.debug("client request :  createDERGroupForecast");
		URL wsdlURL = DERGroupsClient.class
				.getResource("/resources/wsdl/RequestDERGroupForecast.wsdl");
		
		RequestDERGroupForecast ss = new RequestDERGroupForecast(wsdlURL);
		DERGroupForecastPort port = ss.getDERGroupForecastPort();
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
		Holder<HeaderType> header = new Holder<HeaderType>();
		header.value = message.getPayload().getHeader();
		Holder<DERGroupForecastPayloadType> payload = new Holder<DERGroupForecastPayloadType>();
		payload.value = message.getPayload().getPayload();
		Holder<ReplyType> reply = new Holder<ReplyType>();
		reply.value = new ReplyType();

		try {
			port.createDERGroupForecast(header, message.getPayload()
					.getRequest(), payload, reply);
			DERGroupForecastResponseMessageType response = new DERGroupForecastResponseMessageType();

			response.setHeader(header.value);
			response.setPayload(payload.value);
			response.setReply(reply.value);
			return response;
		} catch (ch.iec.tc57._2011.requestdergroupforecast.FaultMessage e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;

	}

	public DERGroupStatusResponseMessageType getDERGroupStatuses(
			GetDERGroupStatusRequest message) {
		log.debug("client request :  changedDERGroupStatuses");
		URL wsdlURL = DERGroupsClient.class
				.getResource("/resources/wsdl/GetDERGroupStatus.wsdl");

		GetDERGroupStatus ss = new GetDERGroupStatus(wsdlURL);
		GetDERGroupStatusPort port = ss.getGetDERGroupStatusPort();
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

		Holder<HeaderType> header = new Holder<HeaderType>();
		header.value = message.getPayload().getHeader();

		Holder<DERGroupStatusPayloadType> payload = new Holder<DERGroupStatusPayloadType>();
		payload.value = message.getPayload().getPayload();
		Holder<ReplyType> reply = new Holder<ReplyType>();
		reply.value = new ReplyType();

		try {
			port.getDERGroupStatus(header, message.getPayload().getRequest(),
					payload, reply);
			DERGroupStatusResponseMessageType response = new DERGroupStatusResponseMessageType();

			response.setHeader(header.value);
			response.setPayload(payload.value);
			response.setReply(reply.value);
			return response;
		} catch (ch.iec.tc57._2011.getdergroupstatus.FaultMessage e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			return null;
		}

	}

	public DERGroupDispatchResponseMessageType createDERGroupDispatch(
			ChangeDERGroupCapabilityRequest message) throws ch.iec.tc57._2011.requestdergroupdispatch.FaultMessage {
		log.debug("client request :  createDERGroupDispatch");
		URL wsdlURL = DERGroupsClient.class
				.getResource("/resources/wsdl/RequestDERGroupDispatch.wsdl");
		
		RequestDERGroupDispatch ss = new RequestDERGroupDispatch(wsdlURL);
		DERGroupDispatchPort port = ss.getDERGroupDispatchPort();
		BindingProvider provider = (BindingProvider) port;

		provider.getRequestContext()
				.put(BindingProvider.ENDPOINT_ADDRESS_PROPERTY,
						message.getRequestURL());

		// Register all the logging interceptors
		Client cxfClient = ClientProxy.getClient(port);

		cxfClient.getInInterceptors().add(loggingInInterceptor);
		cxfClient.getInFaultInterceptors().add(loggingInFaultInterceptor);
		cxfClient.getOutInterceptors().add(loggingOutInterceptor);
		cxfClient.getOutFaultInterceptors().add(loggingOutFaultInterceptor);

		Holder<HeaderType> header = new Holder<HeaderType>();
		header.value = message.getPayload().getHeader();
		Holder<DERGroupDispatchPayloadType> payload = new Holder<DERGroupDispatchPayloadType>();
		payload.value = message.getPayload().getPayload();
		Holder<ReplyType> reply = new Holder<ReplyType>();
		reply.value = new ReplyType();

		port.createDERGroupDispatch(header, message.getPayload().getRequest(), payload,
				reply);

		DERGroupDispatchResponseMessageType response = new DERGroupDispatchResponseMessageType();
		response.setHeader(header.value);
		response.setPayload(payload.value);
		response.setReply(reply.value);

		return response;
	}
}
