package com.sixthc.server.ws;

import java.util.GregorianCalendar;

import javax.xml.datatype.DatatypeConfigurationException;
import javax.xml.datatype.DatatypeFactory;
import javax.xml.datatype.XMLGregorianCalendar;
import javax.xml.ws.Holder;

import org.apache.log4j.Logger;
import org.springframework.beans.BeansException;
import org.springframework.context.ApplicationContext;
import org.springframework.context.ApplicationContextAware;

import ch.iec.tc57._2011.getdergroup.FaultMessage;
import ch.iec.tc57._2011.getdergroup.GetDERGroupPort;
import ch.iec.tc57._2011.getdergroupmessage.DERGroupPayloadType;
import ch.iec.tc57._2011.getdergroupmessage.GetDERGroupRequestType;
import ch.iec.tc57._2011.schema.message.HeaderType;
import ch.iec.tc57._2011.schema.message.ReplyType;

import com.epri._2013.dergroup.DERGroups;
import com.epri._2013.dergroup.DERGroups.DERGroup;
import com.epri._2013.dergroup.Status;

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
		log.debug("***** OPERATION : getDERGroup");
		
		for( String s : request.getID()) {
			log.debug("request ID: " + s);
		}
		DERGroups dgs = new DERGroups();
		DERGroup dg = new DERGroup();
		dg.setComment("test epri server");
		dg.setDescription("test desc server");
		dg.setMRID("1234");
		dg.setName("name1");
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
	    status.setValue("value");;
	    dg.setStatus(status);
	    dgs.getDERGroup().add(dg);
		
		log.debug("payloud value = " + payload.value);
		log.debug("groups = " + payload.value.getDERGroups());
		
		payload.value.setDERGroups(dgs);
		
		ReplyType r = appContext.getBean(("ReplyTypeBean"), ReplyType.class);
		reply.value = r;

	}
}
