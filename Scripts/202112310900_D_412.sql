INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'FK_HRDeliveryEmployeeID',   -- AAColumnAliasName - varchar(255)
    N'Người giao',  -- AAColumnAliasCaption - nvarchar(255)
    'ICReceipts',   -- AATableName - varchar(50)
    'HREmployees',   -- AAReferenceTable - varchar(512)
    'HREmployeeName',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    NULL  -- AAColumnAliasIsSaveHistory - bit
    )
GO
update dbo.AAColumnAlias SET AAColumnAliasName = 'ICShipmentProductType' WHERE AATableName = 'ICShipments' AND AAColumnAliasName = 'ICShipmentShipmentType'
GO
update dbo.AAColumnAlias SET AAColumnAliasName = 'ARSaleForecastDeliveryDate' WHERE AATableName = 'ARSaleForecasts' AND AAColumnAliasName = 'ARSaleForecastDeliveryTime'
GO
update dbo.AAColumnAlias SET AADisplayedMember = 'GECurrencyName' WHERE AATableName = 'ARClearInvoices' AND AAColumnAliasName = 'FK_GECurrencyID'
GO
update dbo.AAColumnAlias SET AADisplayedMember = 'GECurrencyName' WHERE AATableName = 'ARCustomerPayments' AND AAColumnAliasName = 'FK_GECurrencyID'
GO
update dbo.AAColumnAlias SET AAReferenceTable = '', AADisplayedMember = '', AAColumnAliasName = 'ARCustomerName' WHERE AATableName = 'ARCustomerPayments' AND AAColumnAliasName = 'FK_ARCustomerID'
GO
update dbo.AAColumnAlias SET AADisplayedMember = 'GECurrencyName' WHERE AATableName = 'ARInvoices' AND AAColumnAliasName = 'FK_GECurrencyID'
GO
update dbo.AAColumnAlias SET AADisplayedMember = 'GEVATName' WHERE AATableName = 'ICProducts' AND AAColumnAliasName = 'FK_GEVATID'
GO
update  dbo.AAColumnAlias  SET AAStatus = 'Delete' WHERE AATableName = 'ICShipments' AND AAColumnAliasName = 'ICShipmentPackNo'
GO
































