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

import ch.iec.tc57._2011.getdergroupstatus.FaultMessage;
import ch.iec.tc57._2011.getdergroupstatus.GetDERGroupStatusPort;
import ch.iec.tc57._2011.getdergroupstatusmessage.DERGroupStatusPayloadType;
import ch.iec.tc57._2011.getdergroupstatusmessage.GetDERGroupStatusRequestType;
import ch.iec.tc57._2011.schema.message.HeaderType;
import ch.iec.tc57._2011.schema.message.ReplyType;

import com.epri._2013.derstatus.ActivePower;
import com.epri._2013.derstatus.ApparentPower;
import com.epri._2013.derstatus.DERGroups;
import com.epri._2013.derstatus.DERMember;
import com.epri._2013.derstatus.DERMember.CapabilityList;
import com.epri._2013.derstatus.EndDeviceGroup;
import com.epri._2013.derstatus.EndDeviceGroup.Version;
import com.epri._2013.derstatus.ReactivePower;

public class GetDERGroupStatusImpl implements GetDERGroupStatusPort,
		ApplicationContextAware {
	private static org.apache.log4j.Logger log = Logger
			.getLogger(GetDERGroupStatusImpl.class);
	ApplicationContext appContext;

	@Override
	public void setApplicationContext(ApplicationContext arg0)
			throws BeansException {
		appContext = arg0;

	}

	@Override
	public void getDERGroupStatus(Holder<HeaderType> header,
			GetDERGroupStatusRequestType request,
			Holder<DERGroupStatusPayloadType> payload, Holder<ReplyType> reply)
			throws FaultMessage {

	//	DERGroups e = appContext.getBean("CIMDERGroupStatus", DERGroups.class);

		EndDeviceGroup group = new EndDeviceGroup();
		group.setMRID("1234");
		group.setName("Der1");

		DERMember der = new DERMember();
		group.getEndDevice().add(der);
		der.setMRID("1234");
		der.setName("der1");
		CapabilityList cap1 = new CapabilityList();
		der.setCapabilityList(cap1);
		ActivePower ap = new ActivePower();
		ap.setMultiplier("k");
		ap.setValue((float) 12.5);
		ap.setUnit("W");
		ApparentPower app = new ApparentPower();
		app.setMultiplier("k");
		app.setValue((float) 10.5);
		app.setUnit("VA");
		ReactivePower rp = new ReactivePower();
		rp.setMultiplier("k");
		rp.setValue((float) 11.0);
		rp.setUnit("VAr");
		cap1.setActivePower(ap);
		cap1.setApparentPower(app);
		cap1.setReactivePower(rp);

		com.epri._2013.derstatus.EndDeviceGroup.CapabilityList cap2 = new com.epri._2013.derstatus.EndDeviceGroup.CapabilityList();
		cap2.setCurrentActivePower(setActivePower(11.1));
		cap2.setMaxActivePower(setActivePower(12.0));
		cap2.setMinActivePower(setActivePower(10.1));
		
		cap2.setCurrentApparentPower(setApparentPower(12.7));
		cap2.setMinApparentPower(setApparentPower(11.1));
		cap2.setMaxApparentPower(setApparentPower(13.1));;
		
		cap2.setCurrentReactivePower(setReactivePower(12.0));
		cap2.setMinReactivePower(setReactivePower(11.1));
		cap2.setMaxReactivePower(setReactivePower(13.7));
		cap2.setCurrentReactivePower(rp);
		group.setCapabilityList(cap2);

		Version v = new Version();
		v.setMajor(BigInteger.valueOf(1));
		v.setMinor(BigInteger.valueOf(72));
		v.setRevision(BigInteger.valueOf(2));

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

		group.setVersion(v);

		payload.value.getDERGroupStatuses().getEndDeviceGroup().clear();
		payload.value.getDERGroupStatuses().getEndDeviceGroup().add(group);

		ReplyType r = appContext.getBean(("ReplyTypeBean"), ReplyType.class);
		reply.value = r;

	}
	
	private ActivePower setActivePower(double value) {
		ActivePower ap = new ActivePower();
		ap.setValue((float)value);
		ap.setMultiplier("k");
		ap.setUnit("W");		
		return ap;
	}
	
	private ReactivePower setReactivePower(double value) {
		ReactivePower ap = new ReactivePower();
		ap.setValue((float)value);
		ap.setMultiplier("k");
		ap.setUnit("VAr");		
		return ap;
	}
	
	private ApparentPower setApparentPower(double value) {
		ApparentPower ap = new ApparentPower();
		ap.setValue((float)value);
		ap.setMultiplier("k");
		ap.setUnit("VA");		
		return ap;
	}

	//	@Override
	//	public void getDERGroupStatus(Holder<HeaderType> header,
	//			GetDERGroupStatusRequestType request,
	//			Holder<DERGroupStatusPayloadType> payload, Holder<ReplyType> reply)
	//			throws FaultMessage {
	//		log.debug("***** OPERATION : getDERGroupStatus");
	//		
	//		DERGroupStatus e =  appContext.getBean(
	//				"CIMDERGroupStatus",
	//				DERGroupStatus.class);
	//		
	//		payload.value.getDERGroupStatuses().getDERGroupStatuses().clear();
	//		payload.value.getDERGroupStatuses().getDERGroupStatuses().add(e);
	//		
	//		ReplyType r = appContext.getBean(("ReplyTypeBean"), ReplyType.class);
	//		reply.value = r;
	//		
	//	}

}
