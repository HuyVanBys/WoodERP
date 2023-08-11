-----Đã chạy Db test
INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACObjectName',   -- AAColumnAliasName - varchar(255)
    N'Đối tượng',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATs',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

UPDATE dbo.AAColumnAlias
SET AAColumnAliasName = 'ACRetailVATTotalAmount'
WHERE AATableName = 'ACRetailVATs'
AND AAColumnAliasName = 'ARInvoiceTotalAmount'

INSERT INTO dbo.STFieldFormats
VALUES
(   'RetailVAT', -- STFieldFormatModuleName - varchar(50)
    'ACRetailVATItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ACRetailVATItemSubTotalAmount'  -- STFieldFormatColumnName - varchar(100)
)
GO