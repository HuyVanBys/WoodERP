update dbo.STToolbars SET AAStatus = 'Delete' WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'SemiProductReceipt') AND STToolbarCaption = N'Nhập thành phẩm'
GO
update dbo.STToolbars SET AAStatus = 'Delete' WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'SemiProductShipment') AND STToolbarCaption = N'Phiếu xuất kho Thành Vinh'
GO
update dbo.STToolbars SET AAStatus = 'Delete' WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'BatchShipmentDryLumber') AND STToolbarCaption = N'Phiếu xuất kho thành vinh'
GO
update dbo.AAColumnAlias SET AAStatus = 'Delete' WHERE AAColumnAliasCaption = N'loại địa chỉ' AND AATableName = 'ARCustomerContacts'
GO
update dbo.STToolbars SET AAStatus = 'Delete' WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'MaterialReceipt') AND STToolbarCaption = N'Từ lệnh cấp phát(đổi trả)'
GO
update dbo.STToolbars SET AAStatus = 'Delete' WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'MaterialReceipt') AND STToolbarCaption = N'Từ lệnh cấp phát(dư thừa)'
GO
update dbo.STToolbars SET AAStatus = 'Delete' WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'MaterialReceipt') AND STToolbarCaption = N'Phiếu nhập kho Thành Vinh'
GO


