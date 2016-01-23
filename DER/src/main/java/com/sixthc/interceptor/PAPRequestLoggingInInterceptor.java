package com.sixthc.interceptor;

import org.apache.log4j.Logger;

public class PAPRequestLoggingInInterceptor extends LoggingInInterceptor {

	private static org.apache.log4j.Logger log = Logger
			.getLogger(PAPRequestLoggingInInterceptor.class);

	@Override
	public String inferInterface(String action) {
		String interfaceName = "unknownInterface";

		if (action.toLowerCase().contains("createdemandresponsedeployment"))
			interfaceName = "PAP(requestCreateDemandResponseDeployment)";
		else if (action.toLowerCase().contains(
				"createddemandresponsedeploymentresponse"))
			interfaceName = "PAP(requestCreateDemandResponseDeploymentResponse)";
		else
			log.warn("Interface name for " + action + " not found");

		log.debug("infer Interface : action = " + action + ", inteface = "
				+ interfaceName);
		return interfaceName;
	}

}
