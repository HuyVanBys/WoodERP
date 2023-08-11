UPDATE dbo.STModulePostings 
SET STModulePostingAccountingFunction = 'ACTransactions_ARClearInvoicePosting'
WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'ClearInvoice')

UPDATE dbo.STModulePostings 
SET STModulePostingAccountingFunction = 'ACTransactions_APClearInvoiceInPosting'
WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'ClearInvoiceIn')
