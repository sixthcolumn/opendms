package com.sixthc.spring;

import java.util.List;

import org.multispeak.v5_0.sandbox.ApparentPowerRating;
import org.multispeak.v5_0.sandbox.ApparentPowerRatings;
import org.springframework.beans.factory.FactoryBean;

public class ApparentPowerRatingsFactoryBean implements
		FactoryBean<ApparentPowerRatings> {
	private ApparentPowerRatings pn = new ApparentPowerRatings();

	public void setApparentPowerRatings(List<ApparentPowerRating> items) {
		pn.getApparentPowerRating().addAll(items);
	}

	@Override
	public ApparentPowerRatings getObject() throws Exception {
		return pn;
	}

	@Override
	public Class<?> getObjectType() {
		return ApparentPowerRatings.class;
	}

	@Override
	public boolean isSingleton() {
		return true;
	}
}
