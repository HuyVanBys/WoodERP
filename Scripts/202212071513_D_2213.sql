-----Đã chạy DB ERPWood_Test -----
INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARInvoiceItemProductName2',   -- AAColumnAliasName - varchar(255)
    N'Tên SP (HĐĐT)',  -- AAColumnAliasCaption - nvarchar(255)
    'ARInvoiceItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

UPDATE dbo.AAColumnAlias
SET AAColumnAliasCaption = N'Tên SP (HĐĐT)'
WHERE AATableName = 'ACRetailVATItems'
AND AAColumnAliasName = 'ACRetailVATItemProductName2'