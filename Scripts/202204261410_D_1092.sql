Insert into STToolbars
Values (
	'Alive',
	(Select STModuleID From STModules Where STModuleName = 'Processs'),
	1,
	'fld_barbtnCancelComplete',
	N'Mở chứng từ',
	'CancelComplete',
	'Default',
	N'Mở chứng từ',
	'Extra',
	0,
	1,
	'',
	0,
	''
	)

Insert into STToolbars
Values (
	'Alive',
	(Select STModuleID From STModules Where STModuleName = 'Processs'),
	1,
	'fld_barbtnDelete',
	N'Xóa (F6)',
	'Delete',
	'Default',
	N'Xóa (F6)',
	'Extra',
	1,
	1,
	'',
	0,
	''
	)
