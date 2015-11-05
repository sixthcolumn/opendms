package com.sixthc.server.ws;

import java.math.BigInteger;
import java.util.GregorianCalendar;

import javax.xml.datatype.DatatypeConfigurationException;
import javax.xml.datatype.DatatypeFactory;
import javax.xml.datatype.XMLGregorianCalendar;
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
import com.epri._2013.dergroup.EndDeviceGroup.Version;



public class ChangeDERGroupImpl implements DERGroupPort, ApplicationContextAware {

	private static org.apache.log4j.Logger log = Logger
			.getLogger(ChangeDERGroupImpl.class);
	
	
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
		
		Version v = new Version();
		v.setMajor(BigInteger.valueOf(1));
		v.setMinor(BigInteger.valueOf(72));
		v.setRevision(BigInteger.valueOf(2));
		e.setVersion(v);
		GregorianCalendar c = new GregorianCalendar();
		c.setTimeInMillis(System.currentTimeMillis());
		XMLGregorianCalendar date2;
		try {
			date2 = DatatypeFactory.newInstance().newXMLGregorianCalendar(c);
			v.setVersionDate(date2);
		} catch (DatatypeConfigurationException ex) {
			// TODO Auto-generated catch block
			ex.printStackTrace();
		}

		
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
		
		Version v = new Version();
		v.setMajor(BigInteger.valueOf(1));
		v.setMinor(BigInteger.valueOf(72));
		v.setRevision(BigInteger.valueOf(2));
		e.setVersion(v);
		GregorianCalendar c = new GregorianCalendar();
		c.setTimeInMillis(System.currentTimeMillis());
		XMLGregorianCalendar date2;
		try {
			date2 = DatatypeFactory.newInstance().newXMLGregorianCalendar(c);
			v.setVersionDate(date2);
		} catch (DatatypeConfigurationException ex) {
			// TODO Auto-generated catch block
			ex.printStackTrace();
		}

		
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
		
		Version v = new Version();
		v.setMajor(BigInteger.valueOf(1));
		v.setMinor(BigInteger.valueOf(72));
		v.setRevision(BigInteger.valueOf(2));
		e.setVersion(v);
		GregorianCalendar c = new GregorianCalendar();
		c.setTimeInMillis(System.currentTimeMillis());
		XMLGregorianCalendar date2;
		try {
			date2 = DatatypeFactory.newInstance().newXMLGregorianCalendar(c);
			v.setVersionDate(date2);
		} catch (DatatypeConfigurationException ex) {
			// TODO Auto-generated catch block
			ex.printStackTrace();
		}

		
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
