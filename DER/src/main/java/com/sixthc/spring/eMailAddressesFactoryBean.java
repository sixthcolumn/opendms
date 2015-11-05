package com.sixthc.spring;

import java.util.List;

import org.multispeak.v5_0.commontypes.EMailAddress;
import org.multispeak.v5_0.commontypes.EMailAddresses;
import org.springframework.beans.factory.FactoryBean;

public class eMailAddressesFactoryBean implements FactoryBean<EMailAddresses>{
	private EMailAddresses pn = new EMailAddresses();
	
	public void setEMailAddresses(List<EMailAddress> items) {
		pn.getEMailAddress().addAll(items);
	}
	
	@Override
	public EMailAddresses getObject() throws Exception {
		return pn;
	}

	@Override
	public Class<?> getObjectType() {
		return EMailAddresses.class;
	}

	@Override
	public boolean isSingleton() {
		return true;
	}
}
