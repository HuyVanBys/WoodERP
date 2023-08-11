UPDATE dbo.STToolbars
SET STToolbarName = 'fld_barbtnPrintDeliveryPlan001'
WHERE STToolbarTag = 'PrintDeliveryPlan001' AND STModuleID = (SELECT STModuleID FROM  dbo.STModules WHERE STModuleName = 'DeliveryPlan')

UPDATE dbo.STToolbars
SET STToolbarDesc = N'Thu tiền khách hàng', STToolbarCaption = N'Thu tiền khách hàng'
WHERE STToolbarTag = 'PrintCustomerPaymentTimePayment001'
AND STModuleID = (SELECT STModuleID FROM  dbo.STModules WHERE STModuleName = 'CustomerPaymentTimePayment')