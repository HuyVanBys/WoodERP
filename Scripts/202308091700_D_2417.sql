Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'DiscountProgram'), 1, 'fld_barbtnCancelComplete', N'Mở chứng từ', 'CancelComplete', 'Default', N'Mở chứng từ', 'Extra',3,1,0,0,'')
Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'DiscountProgram'), 1, 'fld_barbtnDelete', N'Xoá (F6)', 'Delete', 'Default', N'Xoá (F6)', 'Action',4,1,0,0,'')

insert into STToolbarFunctions values ('', (Select STToolbarID from STToolbars Where STModuleID = (Select STModuleID from STModules Where STModuleName = 'DiscountProgram') and STToolbarName = 'fld_barbtnCancelComplete'), 'ActionCancelComplete', 'void ActionCancelComplete()', 'BOSERP.Modules.DiscountProgram.DiscountProgramModule',1)
insert into STToolbarFunctions values ('', (Select STToolbarID from STToolbars Where STModuleID = (Select STModuleID from STModules Where STModuleName = 'DiscountProgram') and STToolbarName = 'fld_barbtnDelete'), 'ActionDelete', 'void ActionDelete()', 'BOSERP.Modules.DiscountProgram.DiscountProgramModule',1)

Update AAColumnAlias
Set AAStatus = 'Alive'
Where AAColumnAliasName in ('ARDiscountProgramItemBasicPrice','ARDiscountProgramItemProductUnitPrice') and AATableName = 'ARDiscountProgramItems'
