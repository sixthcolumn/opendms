package com.sixthc.interceptor;

import org.apache.log4j.Logger;

public class MultispeakLoggingOutInterceptor extends LoggingOutInterceptor {
	private static org.apache.log4j.Logger log = Logger
			.getLogger(MultispeakLoggingOutInterceptor.class);

	@Override
	public String inferInterface(String action) {
		String interfaceName = "unknownInterface";
		log.debug("infer loggingOut : given action of " + action);

		if (action.toLowerCase().contains("getdomainmembers"))
			interfaceName = "GetDomainMembers";
		else if (action.toLowerCase().contains("getdomainnames"))
			interfaceName = "GetDomainNames";
		else if (action.toLowerCase().contains("createdergroups"))
			interfaceName = "CreateDERGroups";
		else if (action.toLowerCase().contains("createdergroup"))
			interfaceName = "CreateDERGroup";
		else if (action.toLowerCase().contains("deletedergroups"))
			interfaceName = "DeleteDERGroups";
		else if (action.toLowerCase().contains("getallders"))
			interfaceName = "GetAllDERs";
		else if (action.toLowerCase().contains("getattachmentsbyobjectrefs"))
			interfaceName = "GetAttachmentsByObjectRefs";
		else if (action.toLowerCase().contains("getdergroupforecasts"))
			interfaceName = "GetDERGroupForecasts";
		else if (action.toLowerCase().contains(
				"getdergroupstatusesbydergroupids"))
			interfaceName = "GetDERGroupStatusesByDERGroupIDs";
		else if (action.toLowerCase().contains("getdersbyderid"))
			interfaceName = "GetDERsByDERID";
		else if (action.toLowerCase().contains("getmethods"))
			interfaceName = "GetMethods";
		else if (action.toLowerCase().contains(
				"initiatedergroupdispatchrequests"))
			interfaceName = "InitiateDERGroupDispatchRequests";
		else if (action.toLowerCase().contains("insertdersindergroup"))
			interfaceName = "InsertDERsInDERGroup";
		else if (action.toLowerCase().contains("linkattachmentstoobjects"))
			interfaceName = "LinkAttachmentsToObjects";
		else if (action.toLowerCase().contains("pingurl"))
			interfaceName = "PingURL";
		else if (action.toLowerCase().contains("removedersfromdergroup"))
			interfaceName = "RemoveDERsFromDERGroup";
		else if (action.toLowerCase().contains("unlinkattachmentsfromobjects"))
			interfaceName = "UnlinkAttachmentsFromObjects";
		log.warn("Interface name for " + action + " not found");

		log.debug("infer logOut interface returning " + interfaceName);
		return interfaceName;
	}
}
