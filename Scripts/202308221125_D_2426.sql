Insert into ADConfigValues values ('Alive','PaintProcessesStatusNew', 'New', N'Tạo mới', 'PaintProcessesStatusNew', 'PaintProcessesStatus', 1)
Insert into ADConfigValues values ('Alive','PaintProcessesStatusApprove', 'Approve', N'Đã duyệt', 'PaintProcessesStatusApprove', 'PaintProcessesStatus', 1)

Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'PaintProcesses'), 1, 'fld_barbtnComplete', N'Duyệt','Complete', 'Default', N'Duyệt', 'Action',1,1,'',0,'')
Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'PaintProcesses'), 1, 'fld_barbtnCancelComplete', N'Mở chứng từ','CancelComplete', 'Default', N'Mở chứng từ', 'Action',2,1,'',0,'')
