INSERT INTO STToolbars       VALUES('Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'PriceSheet'), 1,N'fld_barbtnExportPriceSheetTemplate',N'ExportPriceSheetTemplate',N'ExportPriceSheetTemplate',N'Default',N'Export Template',N'Extra',1,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'PriceSheet') AND STToolbarTag = ''),0),N'')
INSERT INTO dbo.STToolbarFunctions   VALUES   ('',(SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'PriceSheet') AND STToolbarTag = 'ExportPriceSheetTemplate'),'ExportPriceSheetTemplate','Void ExportPriceSheetTemplate()','BOSERP.Modules.PriceSheet.PriceSheetModule',1)

