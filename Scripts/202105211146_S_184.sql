ALTER TABLE dbo.ARInvoices
ADD ARInvoiceContainerNumber VARCHAR(50),
	ARInvoiceContainerSealNumber VARCHAR(50),
	ARInvoiceTractorTrailerNumber VARCHAR(50),
	ARInvoiceShipNumber nVARCHAR(50),
	ARInvoiceETDDate DATETIME

ALTER TABLE dbo.ARInvoiceItems
ADD ARInvoiceItemContainerNumber VARCHAR(50),
	ARInvoiceItemContainerSealNumber VARCHAR(50),
	ARInvoiceItemTractorTrailerNumber VARCHAR(50),
	ARInvoiceItemShipNumber NVARCHAR(50),
	ARInvoiceItemETDDate DATETIME