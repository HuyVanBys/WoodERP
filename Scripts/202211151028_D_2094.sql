Insert into STToolbars
Values ( 
	'Alive',
	(select STModuleID from STModules Where STModuleName = 'CostObject'),
	1,
	'fld_barbtnDuplicate',
	'Duplicate',
	'Duplicate',
	'Default',
	N'Bản sao(F10)',
	'Action',
	(Select Max(STToolbarOrder + 1) from STToolbars Where STModuleID = (select STModuleID from STModules Where STModuleName = 'CostObject') and STToolbarGroup = 'Action'),
	1,
	'',
	0,
	''
	)
