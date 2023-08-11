UPDATE dbo.AAColumnAlias
SET AAColumnAliasCaption = N'Giá gross'
WHERE AAColumnAliasName = 'ARPriceSheetItemPrice'

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARPriceSheetItemNetPrice',   -- AAColumnAliasName - varchar(255)
    N'Giá net',  -- AAColumnAliasCaption - nvarchar(255)
    'ARPriceSheetItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARPriceSheetItemCostingPrice',   -- AAColumnAliasName - varchar(255)
    N'Giá costing',  -- AAColumnAliasCaption - nvarchar(255)
    'ARPriceSheetItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARPriceSheetItemSOL',   -- AAColumnAliasName - varchar(255)
    N'SOL',  -- AAColumnAliasCaption - nvarchar(255)
    'ARPriceSheetItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'PriceSheet', -- STFieldFormatModuleName - varchar(50)
    'ARPriceSheetItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupQtyN2'),  -- STFieldFormatGroupID - int
    'ARPriceSheetItemNetPrice'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'PriceSheet', -- STFieldFormatModuleName - varchar(50)
    'ARPriceSheetItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupQtyN2'),  -- STFieldFormatGroupID - int
    'ARPriceSheetItemCostingPrice'  -- STFieldFormatColumnName - varchar(100)
)
GO