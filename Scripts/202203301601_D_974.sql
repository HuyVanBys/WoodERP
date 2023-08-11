Insert into STToolbars
Values (
	'Alive',
	(select STModuleID from STModules Where STModuleName = 'AssetReceipt'),
	1,
	'fld_barbtnPrintTransaction',
	N'Phiếu hạch toán',
	'PrintTransaction',
	'Default',
	N'Phiếu hạch toán',
	'Utility',
	2,
	1,
	'',
	(Select STToolbarID from STToolbars Where AAStatus = 'Alive' and STToolbarTag = 'Print' and STModuleID = (select STModuleID from STModules Where STModuleName = 'AssetReceipt')),
	''
	)
Insert into STToolbarFunctions
Values (
	'',
	(Select STToolbarID from STToolbars Where AAStatus = 'Alive' and STToolbarTag = 'PrintTransaction' and STModuleID = (select STModuleID from STModules Where STModuleName = 'AssetReceipt')),
	'ActionPrintTemplate',
	'Void ActionPrintTemplate()',
	'BOSERP.Modules.AssetReceipt.AssetReceiptModule',
	1
)

insert into ADTemplates
Values( 'AssetReceipt_Print002', N'Phiếu hạch toán', N'Phiếu hạch toán', 'AssetReceipt_Print002', 'Alive', 'PrintAssetReceipt001',0)
insert into ADTemplateToolbars
Values (
	(select ADTemplateID from ADTemplates Where ADTemplateNo = 'AssetReceipt_Print002'),
	(Select STToolbarID from STToolbars Where AAStatus = 'Alive' and STToolbarTag = 'PrintTransaction' and STModuleID = (select STModuleID from STModules Where STModuleName = 'AssetReceipt'))
	)

---CCDC
Insert into STToolbars
Values (
	'Alive',
	(select STModuleID from STModules Where STModuleName = 'EquipmentReceipt'),
	1,
	'fld_barbtnPrintTransaction',
	N'Phiếu hạch toán',
	'PrintTransaction',
	'Default',
	N'Phiếu hạch toán',
	'Utility',
	2,
	1,
	'',
	(Select STToolbarID from STToolbars Where AAStatus = 'Alive' and STToolbarTag = 'Print' and STModuleID = (select STModuleID from STModules Where STModuleName = 'EquipmentReceipt')),
	''
	)
Insert into STToolbarFunctions
Values (
	'',
	(Select STToolbarID from STToolbars Where AAStatus = 'Alive' and STToolbarTag = 'PrintTransaction' and STModuleID = (select STModuleID from STModules Where STModuleName = 'EquipmentReceipt')),
	'ActionPrintTemplate',
	'Void ActionPrintTemplate()',
	'BOSERP.Modules.EquipmentReceipt.EquipmentReceiptModule',
	1
)
insert into ADTemplates
Values( 'EquipmentReceipt_Print002', N'Phiếu hạch toán', N'Phiếu hạch toán', 'EquipmentReceipt_Print002', 'Alive', '',0)
insert into ADTemplateToolbars
Values (
	(select ADTemplateID from ADTemplates Where ADTemplateNo = 'EquipmentReceipt_Print002'),
	(Select STToolbarID from STToolbars Where AAStatus = 'Alive' and STToolbarTag = 'PrintTransaction' and STModuleID = (select STModuleID from STModules Where STModuleName = 'EquipmentReceipt'))
	)