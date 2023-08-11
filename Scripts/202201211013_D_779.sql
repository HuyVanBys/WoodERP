update dbo.STToolbars SET AAStatus = 'Delete' WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'SupplierPayment' AND AAStatus = 'Alive') AND AAStatus = 'Alive' AND STToolbarCaption IN (N'UNC Vietcombank',N'UNC Vietinbank')
GO
update dbo.ADConfigValues SET ADConfigText = N'Mua gỗ Phách/Thanh' WHERE ADConfigKeyGroup = 'PurchaseOrderReceiptType' AND ADConfigText =  N'Mua gỗ phách'
GO