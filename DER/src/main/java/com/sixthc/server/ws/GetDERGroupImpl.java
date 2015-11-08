package com.sixthc.server.ws;

import java.math.BigInteger;
import java.util.GregorianCalendar;
import java.util.List;

import javax.xml.datatype.DatatypeConfigurationException;
import javax.xml.datatype.DatatypeFactory;
import javax.xml.datatype.XMLGregorianCalendar;
import javax.xml.ws.Holder;

import org.apache.log4j.Logger;
import org.springframework.beans.BeansException;
import org.springframework.context.ApplicationContext;
import org.springframework.context.ApplicationContextAware;

import com.epri._2013.dergroup.DERGroups;
import com.epri._2013.dergroup.EndDeviceGroup;
import com.epri._2013.dergroup.Status;
import com.epri._2013.dergroup.EndDeviceGroup.Version;

import ch.iec.tc57._2011.getdergroup.FaultMessage;
import ch.iec.tc57._2011.getdergroup.GetDERGroupPort;
import ch.iec.tc57._2011.getdergroupmessage.DERGroupPayloadType;
import ch.iec.tc57._2011.getdergroupmessage.GetDERGroupRequestType;
import ch.iec.tc57._2011.schema.message.HeaderType;
import ch.iec.tc57._2011.schema.message.ReplyType;



public class GetDERGroupImpl implements GetDERGroupPort,
		ApplicationContextAware {
	private static org.apache.log4j.Logger log = Logger
			.getLogger(GetDERGroupImpl.class);
	ApplicationContext appContext;

	@Override
	public void setApplicationContext(ApplicationContext arg0)
			throws BeansException {
		appContext = arg0;

	}


	@Override
	public void getDERGroup(Holder<HeaderType> header,
			GetDERGroupRequestType request,
			Holder<DERGroupPayloadType> payload, Holder<ReplyType> reply)
			throws FaultMessage {
		// TODO Auto-generated method stub
		log.debug("***** OPERATION : getDERGroup");
		
		for( String s : request.getID()) {
			log.debug("request ID: " + s);
		}
		DERGroups derGroups = new DERGroups();
		EndDeviceGroup endDevice = new EndDeviceGroup();
		derGroups.getEndDeviceGroup().add(endDevice);
		endDevice.setComment("test epri server");
		endDevice.setDescription("test desc server");
		endDevice.setMRID("1234");
		endDevice.setName("name1");
		
		Version v = new Version();
		v.setMajor(BigInteger.valueOf(1));
		v.setMinor(BigInteger.valueOf(72));
		v.setRevision(BigInteger.valueOf(2));
		endDevice.setVersion(v);
				
		GregorianCalendar gregorianCalendar = new GregorianCalendar();
	    Status status = new Status();
	    DatatypeFactory datatypeFactory;
		try {
			datatypeFactory = DatatypeFactory.newInstance();
		    XMLGregorianCalendar now = 
		            datatypeFactory.newXMLGregorianCalendar(gregorianCalendar);
		    status.setDateTime(now);
		} catch (DatatypeConfigurationException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	    status.setReason("reason");
	    status.setRemark("remark");
	    status.setValue("value");
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
	    endDevice.setStatus(status);

		
		log.debug("payloud value = " + payload.value);
		log.debug("groups = " + payload.value.getDERGroups());
		
		payload.value.setDERGroups(derGroups);
		
		ReplyType r = appContext.getBean(("ReplyTypeBean"), ReplyType.class);
		reply.value = r;
		
	}
}
