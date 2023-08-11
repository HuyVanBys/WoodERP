UPDATE dbo.STToolbars
SET AAStatus = 'Delete' 
WHERE AAStatus = 'Alive' 
AND STToolbarTag = 'Complete'
AND STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'SupplierPayment') 

UPDATE dbo.APSupplierPayments 
SET APSupplierPaymentStatus = 'Approved'
WHERE APSupplierPaymentStatus = 'Completed'

