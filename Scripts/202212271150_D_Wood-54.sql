INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'FK_ARCustomerID',   -- AAColumnAliasName - varchar(255)
    N'Khách hàng',  -- AAColumnAliasCaption - nvarchar(255)
    'ARPriceSheetItems',   -- AATableName - varchar(50)
    'ARCustomers',   -- AAReferenceTable - varchar(512)
    'ARCustomerName',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
)
GO
