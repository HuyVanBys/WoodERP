update STToolbarFunctions 
SET  STToolbarFunctionName = 'ActionPrintPriceLabel',
	STToolbarFunctionFullName = 'Void ActionPrintPriceLabel()'
WHERE STToolbarID = (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM  STmodules WHERE STModuleName = 'Proposal') AND STToolbarName = 'fld_barbtnPrintPriceLabel')
