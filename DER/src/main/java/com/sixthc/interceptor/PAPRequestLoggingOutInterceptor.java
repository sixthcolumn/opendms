package com.sixthc.interceptor;

import org.apache.log4j.Logger;

public class PAPRequestLoggingOutInterceptor extends LoggingOutInterceptor {

	private static org.apache.log4j.Logger log = Logger
			.getLogger(PAPRequestLoggingOutInterceptor.class);

	@Override
	public String inferInterface(String action) {
		String interfaceName = "unknownInterface";

		// due to overlap of some items (ie: changeDerGroup) order
		// is important!
		if (action.toLowerCase().contains("createdemandresponsedeployment"))
			interfaceName = "PAP(requestCreateDemandResponseDeployment)";
		else if (action.toLowerCase().contains(
				"createddemandresponsedeploymentresponse"))
			interfaceName = "PAP(requestCreateDemandResponseDeploymentResponse)";
		else
			log.warn("Interface name for " + action + " not found");

		log.debug("infer Interface : action = " + action + ", inteface = " + interfaceName);
		return interfaceName;
	}

}
