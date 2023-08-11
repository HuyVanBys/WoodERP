
UPDATE dbo.STFieldFormats SET STFieldFormatGroupID = (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupQty') WHERE STFieldFormatColumnName = 'ARPriceSheetItemQty'
GO

update dbo.STToolbars SET STToolbarCaption = N'Duyệt (F9)' WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'SaleOrder' AND AAStatus = 'Alive') AND AAStatus = 'Alive' AND STToolbarCaption LIKE N'%Hoàn tất (F9)%'
GO

update dbo.STToolbars SET STToolbarCaption = N'Duyệt (F9)' WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'Invoice' AND AAStatus = 'Alive') AND AAStatus = 'Alive' AND STToolbarCaption LIKE N'%Hoàn tất (F9)%'
GO

