UPDATE dbo.STToolbars
SET STToolbarDesc = N'Phiếu thu tiền mặt', STToolbarCaption = N'Phiếu thu tiền mặt'
WHERE STModuleID = (SELECT STModuleID FROM  dbo.STModules WHERE STModuleName = 'CustomerPaymentTimePayment') AND STToolbarTag = 'PrintCustomerPaymentTimePayment001'
