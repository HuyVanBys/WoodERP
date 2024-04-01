Insert into STModules values ('Alive', 'PaintProcessConfig', 'PPC', 1,1,'OnlyERP')
Insert into STModuleDescriptions values ((Select STModuleID from STModules Where STModuleName = 'PaintProcessConfig'), 1, N'Cấu hình quy trình sơn')
Insert into STScreens values ('DMPPC100', N'Thông tin', 'guiPaintProcessConfig', (Select STModuleID from STModules Where STModuleName = 'PaintProcessConfig'), 1, '-1644826', '-16777216', 'Tahoma', '8.25', 'Regular', 'DM', 0, 0, 0, 0, 1,1, '', 0, 0,'',1)
Insert into STScreens values ('SMPPC100', N'Tìm kiếm', 'guiPaintProcessConfigSearch', (Select STModuleID from STModules Where STModuleName = 'PaintProcessConfig'), 1, '-1644826', '-16777216', 'Tahoma', '8.25', 'Regular', 'SM', 0, 0, 0, 0, 1,1, '', 0, 0,'',1)

Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'PaintProcessConfig'), 1, 'fld_barbtnNew', N'Tạo mới', 'New', 'Default', N'Tạo mới (F4)', 'Action', 0, 1, '', 0, '')
Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'PaintProcessConfig'), 1, 'fld_barbtnEdit', N'Sửa', 'Edit', 'Default', N'Sửa (F5)', 'Action', 1, 1, '', 0, '')
Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'PaintProcessConfig'), 1, 'fld_barbtnCancel', N'Hủy', 'Cancel', 'Default', N'Hủy (F7)', 'Action', 2, 1, '', 0, '')
Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'PaintProcessConfig'), 1, 'fld_barbtnSave', N'Lưu', 'Save', 'Default', N'Lưu (F8)', 'Action', 3, 1, '', 0, '')
Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'PaintProcessConfig'), 1, 'fld_barbtnComplete', N'Duyệt', 'Complete', 'Default', N'Duyệt', 'Action', 4, 1, '', 0, '')
Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'PaintProcessConfig'), 1, 'fld_barbtnCancelComplete', N'Mở chứng từ', 'CancelComplete', 'Default', N'Mở chứng từ', 'Extra', 0, 1, '', 0, '')
Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'PaintProcessConfig'), 1, 'fld_barbtnDelete', N'Xóa (F6)', 'Delete', 'Default', N'Xóa (F6)', 'Extra', 1, 1, '', 0, '')

Insert into STToolbarFunctions values (0, (Select STToolbarID from STToolbars Where STModuleID = (Select STModuleID from STModules Where STModuleName = 'PaintProcessConfig') and STToolbarName = 'fld_barbtnComplete'), 'ApprovePaintProcessConfig', 'Void ApprovePaintProcessConfig()', 'BOSERP.Modules.PaintProcessConfig.PaintProcessConfigModule',1)

Insert into ADConfigValues values ('Alive', 'PaintProcessConfigStatusNew', 'New', N'Tạo mới', N'Tạo mới', 'PaintProcessConfigStatus', 1)
Insert into ADConfigValues values ('Alive', 'PaintProcessConfigStatusApproved', 'Approved', N'Đã duyệt', N'Đã duyệt', 'PaintProcessConfigStatus', 1)

insert into GENumbering values ('', GETDATE(), 'ADMIN', GETDATE(), 'Alive', 'PaintProcessConfig', 'QTS-', 6,6,N'Cấu hình quy trình sơn',1,1,0,0,0,0,'{1}{2}.{7}')

insert into AAColumnAlias values (0, '', 'Alive', 'MMPaintProcessConfigNo', N'Mã chứng từ', 'MMPaintProcessConfigs', '','','','',1,0)
insert into AAColumnAlias values (0, '', 'Alive', 'MMPaintProcessConfigName', N'Tên chứng từ', 'MMPaintProcessConfigs', '','','','',1,0)
insert into AAColumnAlias values (0, '', 'Alive', 'MMPaintProcessConfigDesc', N'Mô tả', 'MMPaintProcessConfigs', '','','','',1,0)
insert into AAColumnAlias values (0, '', 'Alive', 'MMPaintProcessConfigStatus', N'Tình trạng', 'MMPaintProcessConfigs', '','','','',1,0)


INSERT INTO GELookupTables SELECT 'Alive', 'MMPaintProcessConfigs', N'Cấu hình QTS', 'MMPaintProcessConfigName', '' ,''