package com.sixthc.interceptor;

import org.apache.log4j.Logger;

public class CIMRequestLoggingInInterceptor extends LoggingInInterceptor {

	private static org.apache.log4j.Logger log = Logger
			.getLogger(CIMRequestLoggingInInterceptor.class);

	@Override
	public String inferInterface(String action) {
		String interfaceName = "unknownInterface";

		if (action.toLowerCase().contains("changeddergroupstatuses"))
			interfaceName = "CIM_DER(requestChangedDERGroupStatus)";
		else if (action.toLowerCase().contains("createdergroupdispatch"))
			interfaceName = "CIM_DER(requestCreateDERGroupDispatch)";
		else if (action.toLowerCase().contains("changeddergroupforecast"))
			interfaceName = "CIM_DER(requestCreateDERGroupForecast)";
		else if (action.toLowerCase().contains("changeddergroup"))
			interfaceName = "CIM_DER(requestChangedDERGroups)";
		else if (action.toLowerCase().contains("createdergroupcapability"))
			interfaceName = "CIM_DER(requestCreateDERGroupCapabilities)";
		else if (action.toLowerCase().contains("createderforecast"))
			interfaceName = "CIM_DER(requestCreateDERGroupForecast)";
		else if (action.toLowerCase().contains("createdergroupforecast"))
			interfaceName = "CIM_DER(requestCreateDERGroupForecast)";
		else if (action.toLowerCase().contains("createdergroup"))
			interfaceName = "CIM_DER(requestCreateDERGroup)";
		else if (action.toLowerCase().contains("deletedergroup"))
			interfaceName = "CIM_DER(requestDeleteDERGroup)";
		else if (action.toLowerCase().contains("getdergroupcapabilities"))
			interfaceName = "CIM_DER(requestGetDERGroupCapabilities)";
		else if (action.toLowerCase().contains("getdercapabilities"))
			interfaceName = "CIM_DER(requestGetDERGroupCapabilities)";
		else if (action.toLowerCase().contains("getdergroupstatus"))
			interfaceName = "CIM_DER(requestGetDERGroupStatus)";
		else if (action.toLowerCase().contains("getdergroup"))
			interfaceName = "CIM_DER(requestGetDERGroup)";
		else if (action.toLowerCase().contains("changedergroup"))
			interfaceName = "CIM_DER(requestChangedDERGroups)";
		else
			log.warn("Interface name for " + action + " not found");

		log.debug("infer Interface : action = " + action + ", inteface = " + interfaceName);
		return interfaceName;
	}

}
