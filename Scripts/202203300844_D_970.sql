--PaymentVoucher
Insert into STToolbars 
Values (
	'Alive',
	(select STModuleID from STModules Where STModuleName = 'PaymentVoucher'),
	1,
	'fld_barbtnDuplicate',
	'Duplicate',
	'Duplicate',
	'Default',
	N'Tạo bản sao',
	'Extra',
	(Select Max(STToolbarOrder) + 1 from STToolbars Where STModuleID = (select STModuleID from STModules Where STModuleName = 'PaymentVoucher') and STToolbarGroup = 'Extra'),
	1,
	'',
	0,
	''
	)
Insert into STToolbarFunctions
Values(
	'',
	(Select STToolbarID from STToolbars Where STModuleID = (select STModuleID from STModules Where STModuleName = 'PaymentVoucher') and STToolbarName = 'fld_barbtnDuplicate'),
	'ActionDuplicate',
	'Void ActionDuplicate()',
	'BOSERP.Modules.PaymentVoucher.PaymentVoucherModule',
	1
	)
--PaymentOrder
Insert into STToolbars 
Values (
	'Alive',
	(select STModuleID from STModules Where STModuleName = 'PaymentOrder'),
	1,
	'fld_barbtnDuplicate',
	'Duplicate',
	'Duplicate',
	'Default',
	N'Tạo bản sao',
	'Extra',
	(Select Max(STToolbarOrder) + 1 from STToolbars Where STModuleID = (select STModuleID from STModules Where STModuleName = 'PaymentOrder') and STToolbarGroup = 'Extra'),
	1,
	'',
	0,
	''
	)
Insert into STToolbarFunctions
Values(
	'',
	(Select STToolbarID from STToolbars Where STModuleID = (select STModuleID from STModules Where STModuleName = 'PaymentOrder') and STToolbarName = 'fld_barbtnDuplicate'),
	'ActionDuplicate',
	'Void ActionDuplicate()',
	'BOSERP.Modules.PaymentOrder.PaymentOrderModule',
	1
	)
--ReceiptVoucher
Insert into STToolbars 
Values (
	'Alive',
	(select STModuleID from STModules Where STModuleName = 'ReceiptVoucher'),
	1,
	'fld_barbtnDuplicate',
	'Duplicate',
	'Duplicate',
	'Default',
	N'Tạo bản sao',
	'Extra',
	(Select Max(STToolbarOrder) + 1 from STToolbars Where STModuleID = (select STModuleID from STModules Where STModuleName = 'ReceiptVoucher') and STToolbarGroup = 'Extra'),
	1,
	'',
	0,
	''
	)
Insert into STToolbarFunctions
Values(
	'',
	(Select STToolbarID from STToolbars Where STModuleID = (select STModuleID from STModules Where STModuleName = 'ReceiptVoucher') and STToolbarName = 'fld_barbtnDuplicate'),
	'ActionDuplicate',
	'Void ActionDuplicate()',
	'BOSERP.Modules.ReceiptVoucher.ReceiptVoucherModule',
	1
	)
--BankTransaction
Insert into STToolbars 
Values (
	'Alive',
	(select STModuleID from STModules Where STModuleName = 'BankTransaction'),
	1,
	'fld_barbtnDuplicate',
	'Duplicate',
	'Duplicate',
	'Default',
	N'Tạo bản sao',
	'Extra',
	(Select Max(STToolbarOrder) + 1 from STToolbars Where STModuleID = (select STModuleID from STModules Where STModuleName = 'BankTransaction') and STToolbarGroup = 'Extra'),
	1,
	'',
	0,
	''
	)
Insert into STToolbarFunctions
Values(
	'',
	(Select STToolbarID from STToolbars Where STModuleID = (select STModuleID from STModules Where STModuleName = 'BankTransaction') and STToolbarName = 'fld_barbtnDuplicate'),
	'ActionDuplicate',
	'Void ActionDuplicate()',
	'BOSERP.Modules.BankTransaction.BankTransactionModule',
	1
	)