package com.sixthc.interceptor;

import org.apache.log4j.Logger;

public class CIMLoggingInInterceptor extends LoggingInInterceptor {

	private static org.apache.log4j.Logger log = Logger
			.getLogger(CIMLoggingInInterceptor.class);

	@Override
	public String inferInterface(String action) {
		String interfaceName = "unknownInterface";

		if (action.toLowerCase().contains("changeddergroupstatuses"))
			interfaceName = "CIM_DER(changedDERGroupStatus)";
		else if (action.toLowerCase().contains("changeddergroupforecast"))
			interfaceName = "CIM_DER(createDERGroupForecast)";
		else if (action.toLowerCase().contains("createdergroupdispatch"))
			interfaceName = "CIM_DER(createDERGroupDispatch)";
		else if (action.toLowerCase().contains("changedergroup"))
			interfaceName = "CIM_DER(changedDERGroup)";
		else if (action.toLowerCase().contains("createdergroupcapability"))
			interfaceName = "CIM_DER(createDERGroupCapabilities)";
		else if (action.toLowerCase().contains("createderforecast"))
			interfaceName = "CIM_DER(createDERGroupForecast)";
		else if (action.toLowerCase().contains("createdergroupforecast"))
			interfaceName = "CIM_DER(createDERGroupForecast)";
		else if (action.toLowerCase().contains("createdergroup"))
			interfaceName = "CIM_DER(createDERGroup)";
		else if (action.toLowerCase().contains("deletedergroup"))
			interfaceName = "CIM_DER(deleteDERGroup)";
		else if (action.toLowerCase().contains("getdergroupcapability"))
			interfaceName = "CIM_DER(getDERGroupCapabilities)";
		else if (action.toLowerCase().contains("getdercapability"))
			interfaceName = "CIM_DER(getDERGroupCapabilities)";
		else if (action.toLowerCase().contains("getdergroupstatus"))
			interfaceName = "CIM_DER(getDERGroupStatus)";
		else if (action.toLowerCase().contains("getdergroup"))
			interfaceName = "CIM_DER(getDERGroup)";
		else
			log.warn("Interface name for " + action + " not found");

		log.debug("infer Interface : action = " + action + ", inteface = " + interfaceName);
		return interfaceName;
	}

}
