package com.sixthc.server.ws;

import org.apache.log4j.Logger;
import org.springframework.beans.BeansException;
import org.springframework.context.ApplicationContext;
import org.springframework.context.ApplicationContextAware;

import ch.iec.tc57._2011.dergroupdispatchmessage.DERGroupDispatchRequestMessageType;
import ch.iec.tc57._2011.dergroupdispatchmessage.DERGroupDispatchResponseMessageType;
import ch.iec.tc57._2011.dergroupforecastmessage.DERGroupForecastResponseMessageType;
import ch.iec.tc57._2011.dergroupmessage.DERGroupResponseMessageType;
import ch.iec.tc57._2011.getdergroupcapabilitymessage.GetDERGroupCapabilityResponseMessageType;
import ch.iec.tc57._2011.getdergroupstatusmessage.DERGroupStatusResponseMessageType;
import ch.iec.tc57._2011.requestdergroup.FaultMessage;
import ch.iec.tc57._2011.schema.message.ReplyType;

import com.sixthc.cim.der.CimDERGroupRequestServerSoap;
import com.sixthc.cim.request.ChangeDERGroupCapabilityRequest;
import com.sixthc.cim.request.ChangeDERGroupForecastRequest;
import com.sixthc.cim.request.GetDERGroupCapabilityRequest;
import com.sixthc.cim.request.GetDERGroupForecastRequest;
import com.sixthc.cim.request.GetDERGroupStatusRequest;
import com.sixthc.cim.request.GetDERGroupsRequest;
import com.sixthc.cim.request.RequestDERGroupsRequest;
import com.sixthc.client.CIMRequestClient;

public class CIMRequestImpl implements CimDERGroupRequestServerSoap,
		ApplicationContextAware {

	ApplicationContext appContext;
	private static org.apache.log4j.Logger log = Logger
			.getLogger(CIMRequestImpl.class);

	CIMRequestClient client;

	public CIMRequestClient getClient() {
		return client;
	}

	public void setClient(CIMRequestClient client) {
		this.client = client;

	}

	@Override
	public void setApplicationContext(ApplicationContext arg0)
			throws BeansException {

		appContext = arg0;

	}

	@Override
	public DERGroupForecastResponseMessageType createDERGroupForecasts(
			ChangeDERGroupForecastRequest message) {
		log.debug("***** REQUEST : createDERGroupForecasts");
		return client.createDERGroupForecast(message);

	}

	@Override
	public GetDERGroupCapabilityResponseMessageType getDERGroupCapabilities(
			GetDERGroupCapabilityRequest message) {
		return client.getDERGroupCapabilities(message);
	}

	@Override
	public DERGroupStatusResponseMessageType getDERGroupStatuses(
			GetDERGroupStatusRequest message) {
		return client.getDERGroupStatuses(message);

	}

	@Override
	public ch.iec.tc57._2011.getdergroupmessage.DERGroupResponseMessageType getDERGroup(
			GetDERGroupsRequest message) {
		log.debug("***** REQUEST : getDERGroup");

		try {
			return client.getDERGroup(message);
		} catch (ch.iec.tc57._2011.getdergroup.FaultMessage e) {
			ch.iec.tc57._2011.getdergroupmessage.DERGroupResponseMessageType response = new ch.iec.tc57._2011.getdergroupmessage.DERGroupResponseMessageType();
			ReplyType rt = new ReplyType();
			response.setReply(rt);
			rt.setResult("FAILED");
			return response;
		}

	}

	@Override
	public DERGroupResponseMessageType changeDERGroup(
			RequestDERGroupsRequest message) {
		log.debug("***** REQUEST : changeDERGroup");

		try {
			return client.changeDERGroup(message);
		} catch (FaultMessage e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;
	}

	// not implemented
	@Override
	public ch.iec.tc57._2011.getdergroupforecastmessage.DERGroupForecastResponseMessageType getDERGroupForecasts(
			GetDERGroupForecastRequest message) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public DERGroupResponseMessageType deleteDERGroup(
			RequestDERGroupsRequest message) {
		log.debug("***** REQUEST : deleteDERGroup");

		try {
			return client.deleteDERGroup(message);
		} catch (FaultMessage e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;
	}

	@Override
	public DERGroupResponseMessageType createDERGroup(
			RequestDERGroupsRequest message) {
		log.debug("***** REQUEST : createDERGroup");

		try {
			return client.createDERGroup(message);
		} catch (FaultMessage e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;
	}


	@Override
	public DERGroupDispatchResponseMessageType createDERGroupDispatch(
			ChangeDERGroupCapabilityRequest message) {
		log.debug("***** REQUEST : createDERGroupDispatch");

		try {
			return client.createDERGroupDispatch(message);
		} catch (ch.iec.tc57._2011.requestdergroupdispatch.FaultMessage e) {
			// TODO Auto-generated catch block
			log.error(e);
		}
		return null;
	}


}
