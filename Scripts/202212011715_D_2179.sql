-----Đã chạy DB test-----
INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'GiaVon',   -- AAColumnAliasName - varchar(255)
    N'Giá vốn',  -- AAColumnAliasCaption - nvarchar(255)
    'RP_InventoryStockProductSeries',   -- AATableName - varchar(50)
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
    'TienVon',   -- AAColumnAliasName - varchar(255)
    N'Tiền vốn',  -- AAColumnAliasCaption - nvarchar(255)
    'RP_InventoryStockProductSeries',   -- AATableName - varchar(50)
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
(   'Report',   -- STFieldFormatModuleName - varchar(50)
    'RP_InventoryStockProductSeries',   -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN6'),    -- STFieldFormatGroupID - int
    'GiaVon',   -- STFieldFormatColumnName - varchar(100)
    0, -- STChangeByCurrency - bit
    0  -- STChangeByDepartment - bit
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'Report',   -- STFieldFormatModuleName - varchar(50)
    'RP_InventoryStockProductSeries',   -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN6'),    -- STFieldFormatGroupID - int
    'TienVon',   -- STFieldFormatColumnName - varchar(100)
    0, -- STChangeByCurrency - bit
    0  -- STChangeByDepartment - bit
)
GO