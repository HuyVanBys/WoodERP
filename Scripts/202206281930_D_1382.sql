--Shipment
Insert into STToolbars 
Values (
	'Alive',
	(select STModuleID from STModules Where STModuleName = 'Shipment'),
	1,
	'fld_barbtnDuplicate',
	'Duplicate',
	'Duplicate',
	'Default',
	N'Tạo bản sao',
	'Extra',
	(Select Max(STToolbarOrder) + 1 from STToolbars Where STModuleID = (select STModuleID from STModules Where STModuleName = 'Shipment') and STToolbarGroup = 'Extra'),
	1,
	'',
	0,
	''
	)