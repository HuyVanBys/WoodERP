ALTER TABLE ARInvoices
ADD ARListOfSalesChannelType NVARCHAR(50) 
UPDATE ARInvoices SET ARListOfSalesChannelType = 'Kenhcongty'
ALTER TABLE ARInvoices
ALTER COLUMN ARListOfSalesChannelType NVARCHAR(50) NOT NULL

ALTER TABLE ARSaleOrders
ADD ARListOfSalesChannelType NVARCHAR(50) 
UPDATE ARSaleOrders SET ARListOfSalesChannelType = 'Kenhcongty'
ALTER TABLE ARSaleOrders
ALTER COLUMN ARListOfSalesChannelType NVARCHAR(50) NOT NULL

ALTER TABLE ICShipments
ADD ICListOfSalesChannelType NVARCHAR(50) 

------------------------------------------------------------------------------------------------------------------
ALTER TABLE ARSaleReturnItems
ADD ARListOfSalesChannelType NVARCHAR(50) 
UPDATE ARSaleReturnItems SET ARListOfSalesChannelType = ''
ALTER TABLE ARSaleReturnItems
ALTER COLUMN ARListOfSalesChannelType NVARCHAR(50) NOT NULL


INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARListOfSalesChannelType',   -- AAColumnAliasName - varchar(255)
    N'Kênh bán hàng',  -- AAColumnAliasCaption - nvarchar(255)
    'ARSaleReturnItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
    )
GO

