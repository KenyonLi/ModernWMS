-- 账号 admin  密码：1 

INSERT INTO menu (id, menu_name, module, vue_path, vue_path_detail, vue_directory, sort, tenant_id) VALUES (20, 'companySetting', 'baseModule', 'companySetting', '', 'base/companySetting', 1, 1);
INSERT INTO menu (id, menu_name, module, vue_path, vue_path_detail, vue_directory, sort, tenant_id) VALUES (21, 'userRoleSetting', 'baseModule', 'userRoleSetting', '', 'base/userRoleSetting', 2, 1);
INSERT INTO menu (id, menu_name, module, vue_path, vue_path_detail, vue_directory, sort, tenant_id) VALUES (22, 'roleMenu', 'baseModule', 'roleMenu', '', 'base/roleMenu', 3, 1);
INSERT INTO menu (id, menu_name, module, vue_path, vue_path_detail, vue_directory, sort, tenant_id) VALUES (23, 'userManagement', 'baseModule', 'userManagement', '', 'base/userManagement', 4, 1);
INSERT INTO menu (id, menu_name, module, vue_path, vue_path_detail, vue_directory, sort, tenant_id) VALUES (24, 'commodityCategorySetting', 'baseModule', 'commodityCategorySetting', '', 'base/commodityCategorySetting', 5, 1);
INSERT INTO menu (id, menu_name, module, vue_path, vue_path_detail, vue_directory, sort, tenant_id) VALUES (25, 'commodityManagement', 'baseModule', 'commodityManagement', '', 'base/commodityManagement', 6, 1);
INSERT INTO menu (id, menu_name, module, vue_path, vue_path_detail, vue_directory, sort, tenant_id) VALUES (26, 'supplier', 'baseModule', 'supplier', '', 'base/supplier', 7, 1);
INSERT INTO menu (id, menu_name, module, vue_path, vue_path_detail, vue_directory, sort, tenant_id) VALUES (27, 'warehouseSetting', 'baseModule', 'warehouseSetting', '', 'base/warehouseSetting', 8, 1);
INSERT INTO menu (id, menu_name, module, vue_path, vue_path_detail, vue_directory, sort, tenant_id) VALUES (28, 'ownerOfCargo', 'baseModule', 'ownerOfCargo', '', 'base/ownerOfCargo', 9, 1);
INSERT INTO menu (id, menu_name, module, vue_path, vue_path_detail, vue_directory, sort, tenant_id) VALUES (29, 'freightSetting', 'baseModule', 'freightSetting', '', 'base/freightSetting', 10, 1);
INSERT INTO menu (id, menu_name, module, vue_path, vue_path_detail, vue_directory, sort, tenant_id) VALUES (30, 'customer', 'baseModule', 'customer', '', 'base/customer', 12, 1);
INSERT INTO menu (id, menu_name, module, vue_path, vue_path_detail, vue_directory, sort, tenant_id) VALUES (31, 'stockManagement', '', 'stockManagement', '', 'wms/stockManagement', 12, 1);
INSERT INTO menu (id, menu_name, module, vue_path, vue_path_detail, vue_directory, sort, tenant_id) VALUES (32, 'warehouseProcessing', 'warehouseWorkingModule', 'warehouseProcessing', '', 'warehouseWorking/warehouseProcessing', 13, 1);
INSERT INTO menu (id, menu_name, module, vue_path, vue_path_detail, vue_directory, sort, tenant_id) VALUES (33, 'warehouseMove', 'warehouseWorkingModule', 'warehouseMove', '', 'warehouseWorking/warehouseMove', 14, 1);
INSERT INTO menu (id, menu_name, module, vue_path, vue_path_detail, vue_directory, sort, tenant_id) VALUES (34, 'warehouseFreeze', 'warehouseWorkingModule', 'warehouseFreeze', '', 'warehouseWorking/warehouseFreeze', 15, 1);
INSERT INTO menu (id, menu_name, module, vue_path, vue_path_detail, vue_directory, sort, tenant_id) VALUES (35, 'warehouseAdjust', 'warehouseWorkingModule', 'warehouseAdjust', '', 'warehouseWorking/warehouseAdjust', 16, 1);
INSERT INTO menu (id, menu_name, module, vue_path, vue_path_detail, vue_directory, sort, tenant_id) VALUES (36, 'warehouseTaking', 'warehouseWorkingModule', 'warehouseTaking', '', 'warehouseWorking/warehouseTaking', 17, 1);
INSERT INTO menu (id, menu_name, module, vue_path, vue_path_detail, vue_directory, sort, tenant_id) VALUES (37, 'stockAsn', '', 'stockAsn', '', 'wms/stockAsn', 18, 1);
INSERT INTO menu (id, menu_name, module, vue_path, vue_path_detail, vue_directory, sort, tenant_id) VALUES (38, 'deliveryManagement', 'deliveryManagement', 'deliveryManagement', '', 'deliveryManagement/deliveryManagement', 19, 1);


INSERT INTO rolemenu (id, userrole_id, menu_id, authority, create_time, last_update_time, tenant_id) VALUES (1, 1, 20, 1, '2023-01-06 14:14:34.3281933', '2023-01-06 14:14:34.3281933', 1);
INSERT INTO rolemenu (id, userrole_id, menu_id, authority, create_time, last_update_time, tenant_id) VALUES (2, 1, 21, 1, '2023-01-06 14:14:34.3281933', '2023-01-06 14:14:34.3281933', 1);
INSERT INTO rolemenu (id, userrole_id, menu_id, authority, create_time, last_update_time, tenant_id) VALUES (3, 1, 22, 1, '2023-01-06 14:14:34.3281933', '2023-01-06 14:14:34.3281933', 1);
INSERT INTO rolemenu (id, userrole_id, menu_id, authority, create_time, last_update_time, tenant_id) VALUES (4, 1, 23, 1, '2023-01-06 14:14:34.3281933', '2023-01-06 14:14:34.3281933', 1);
INSERT INTO rolemenu (id, userrole_id, menu_id, authority, create_time, last_update_time, tenant_id) VALUES (5, 1, 24, 1, '2023-01-06 14:14:34.3281933', '2023-01-06 14:14:34.3281933', 1);
INSERT INTO rolemenu (id, userrole_id, menu_id, authority, create_time, last_update_time, tenant_id) VALUES (6, 1, 25, 1, '2023-01-06 14:14:34.3281933', '2023-01-06 14:14:34.3281933', 1);
INSERT INTO rolemenu (id, userrole_id, menu_id, authority, create_time, last_update_time, tenant_id) VALUES (7, 1, 26, 1, '2023-01-06 14:14:34.3281933', '2023-01-06 14:14:34.3281933', 1);
INSERT INTO rolemenu (id, userrole_id, menu_id, authority, create_time, last_update_time, tenant_id) VALUES (8, 1, 27, 1, '2023-01-06 14:14:34.3281933', '2023-01-06 14:14:34.3281933', 1);
INSERT INTO rolemenu (id, userrole_id, menu_id, authority, create_time, last_update_time, tenant_id) VALUES (9, 1, 28, 1, '2023-01-06 14:14:34.3281933', '2023-01-06 14:14:34.3281933', 1);
INSERT INTO rolemenu (id, userrole_id, menu_id, authority, create_time, last_update_time, tenant_id) VALUES (10, 1, 29, 1, '2023-01-06 14:14:34.3281933', '2023-01-06 14:14:34.3281933', 1);
INSERT INTO rolemenu (id, userrole_id, menu_id, authority, create_time, last_update_time, tenant_id) VALUES (11, 1, 30, 1, '2023-01-06 14:14:34.3281933', '2023-01-06 14:14:34.3281933', 1);
INSERT INTO rolemenu (id, userrole_id, menu_id, authority, create_time, last_update_time, tenant_id) VALUES (12, 1, 31, 1, '2023-01-06 14:14:34.3281933', '2023-01-06 14:14:34.3281933', 1);
INSERT INTO rolemenu (id, userrole_id, menu_id, authority, create_time, last_update_time, tenant_id) VALUES (13, 1, 32, 1, '2023-01-06 14:14:34.3281933', '2023-01-06 14:14:34.3281933', 1);
INSERT INTO rolemenu (id, userrole_id, menu_id, authority, create_time, last_update_time, tenant_id) VALUES (14, 1, 33, 1, '2023-01-06 14:14:34.3281933', '2023-01-06 14:14:34.3281933', 1);
INSERT INTO rolemenu (id, userrole_id, menu_id, authority, create_time, last_update_time, tenant_id) VALUES (15, 1, 34, 1, '2023-01-06 14:14:34.3281933', '2023-01-06 14:14:34.3281933', 1);
INSERT INTO rolemenu (id, userrole_id, menu_id, authority, create_time, last_update_time, tenant_id) VALUES (16, 1, 35, 1, '2023-01-06 14:14:34.3281933', '2023-01-06 14:14:34.3281933', 1);
INSERT INTO rolemenu (id, userrole_id, menu_id, authority, create_time, last_update_time, tenant_id) VALUES (17, 1, 36, 1, '2023-01-06 14:14:34.3281933', '2023-01-06 14:14:34.3281933', 1);
INSERT INTO rolemenu (id, userrole_id, menu_id, authority, create_time, last_update_time, tenant_id) VALUES (18, 1, 37, 1, '2023-01-06 14:14:34.3281933', '2023-01-06 14:14:34.3281933', 1);
INSERT INTO rolemenu (id, userrole_id, menu_id, authority, create_time, last_update_time, tenant_id) VALUES (19, 1, 38, 1, '2023-01-06 14:14:34.3281933', '2023-01-06 14:14:34.3281933', 1);


INSERT INTO USER (id, user_num, user_name, contact_tel, user_role, sex, is_valid, auth_string, email, creator, create_time, last_update_time, tenant_id) VALUES (1, 'admin', 'admin', '', 'admin', 'male', 1, 'c4ca4238a0b923820dcc509a6f75849b', '7908990404@qq.com', 'admin', '2023-01-06 14:14:34.3281933', '2023-01-06 14:14:34.3281933', 1);

INSERT INTO userrole (id, role_name, is_valid, create_time, last_update_time, tenant_id) VALUES (1, 'admin', 1, '2023-01-06 14:14:34.3281933', '2023-01-06 14:14:34.3281933', 1);

