UPDATE dbo.STToolbars
SET AAStatus = 'Delete'
WHERE STModuleID = (SELECT STModuleID FROM  STmodules WHERE STModuleName = 'FeePayment')
AND STToolbarName IN ('fld_barbtnInvoiceInternalReceipt','fld_barbtnPurchaseReceipt','fld_barbtnTransferReceipt')

INSERT INTO dbo.STToolbarFunctions
VALUES
(   '', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM  STmodules WHERE STModuleName = 'FeePayment') AND STToolbarName = 'fld_barbtnNewHinterLandFeePayment'),  -- STToolbarID - int
    'NewPurchaseReceipt', -- STToolbarFunctionName - varchar(250)
    'void NewPurchaseReceipt()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.FeePayment.FeePaymentModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
    )