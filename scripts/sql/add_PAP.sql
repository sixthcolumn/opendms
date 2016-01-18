
insert into package (id, name) values (27, 'Deploy');
insert into vendor_role_type (id, name, active_flag) values (27, 'DRAS', 1)
insert into interface (id, name, package_id, proxy_flag, required_flag, vendor_role_type_id)
values (50, 'DemandResponseDeployment', 27, 0, 0, 27);
insert into interface (id, name, package_id, proxy_flag, required_flag, vendor_role_type_id)
values (51, 'DemandResponseDeploymentResponse', 27, 0, 0, 27);
