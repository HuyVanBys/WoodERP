-----Đã chạy DB dev, test
INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'FK_ICMeasureUnitID',   -- AAColumnAliasName - varchar(255)
    N'Đơn vị tính',  -- AAColumnAliasCaption - nvarchar(255)
    'ARSaleReturnItems',   -- AATableName - varchar(50)
    'ICMeasureUnits',   -- AAReferenceTable - varchar(512)
    'ICMeasureUnitName',   -- AADisplayedMember - varchar(512)
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
    'ARSaleReturnItemProductFactor',   -- AAColumnAliasName - varchar(255)
    N'Hệ số',  -- AAColumnAliasCaption - nvarchar(255)
    'ARSaleReturnItems',   -- AATableName - varchar(50)
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
    'ARSaleReturnItemProductExchangeQty',   -- AAColumnAliasName - varchar(255)
    N'SL quy đổi',  -- AAColumnAliasCaption - nvarchar(255)
    'ARSaleReturnItems',   -- AATableName - varchar(50)
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
(   'SaleReturn', -- STFieldFormatModuleName - varchar(50)
    'ARSaleReturnItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ARSaleReturnItemProductExchangeQty'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'SaleReturn', -- STFieldFormatModuleName - varchar(50)
    'ARSaleReturnItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN5'),  -- STFieldFormatGroupID - int
    'ARSaleReturnItemProductFactor'  -- STFieldFormatColumnName - varchar(100)
)
GO

