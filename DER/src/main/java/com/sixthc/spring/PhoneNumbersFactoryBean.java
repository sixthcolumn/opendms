package com.sixthc.spring;

import java.util.List;

import org.multispeak.v5_0.commontypes.PhoneNumber;
import org.multispeak.v5_0.commontypes.PhoneNumbers;
import org.springframework.beans.factory.FactoryBean;

public class PhoneNumbersFactoryBean implements FactoryBean<PhoneNumbers>{
	private PhoneNumbers pn = new PhoneNumbers();
	
	public void setPhoneNumbers(List<PhoneNumber> items) {
		pn.getPhoneNumber().addAll(items);
	}
	
	@Override
	public PhoneNumbers getObject() throws Exception {
		return pn;
	}

	@Override
	public Class<?> getObjectType() {
		return PhoneNumbers.class;
	}

	@Override
	public boolean isSingleton() {
		return true;
	}
}
