package com.sixthc.server.ws;

import org.multispeak.v5_0.ws.request.MultiSpeakRequestMsgHeader;

public class MultiSpeakHeader extends MultiSpeakRequestMsgHeader {

	String createdBy;

	public String getCreatedBy() {
		return createdBy;
	}

	public void setCreatedBy(String createdBy) {
		this.createdBy = createdBy;
	}
	
}
