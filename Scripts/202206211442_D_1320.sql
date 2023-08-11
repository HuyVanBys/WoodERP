INSERT INTO dbo.STFieldColumns
VALUES
(   '',  -- STFieldColumnIDString - varchar(50)
    38964,   -- STFieldID - int
    N'colMMProductionNormItemTotalQuantity', -- STFieldColumnName - nvarchar(256)
    N'Số lượng', -- STFieldColumnCaption - nvarchar(255)
    N'MMProductionNormItemTotalQuantity', -- STFieldColumnFieldName - nvarchar(256)
    '',  -- STFieldColumnFormatString - varchar(50)
    '',  -- STFieldColumnFormatType - varchar(50)
    63,   -- STFieldColumnWidth - int
    6,   -- STFieldColumnVisibleIndex - int
    N''  -- STFieldColumnCommodityType - nvarchar(50)
    )
INSERT INTO dbo.STFieldColumns
VALUES
(   '',  -- STFieldColumnIDString - varchar(50)
    38964,   -- STFieldID - int
    N'colMMProductionNormItemDepreciationRate', -- STFieldColumnName - nvarchar(256)
    N'% TL tiêu hao', -- STFieldColumnCaption - nvarchar(255)
    N'MMProductionNormItemDepreciationRate', -- STFieldColumnFieldName - nvarchar(256)
    '',  -- STFieldColumnFormatString - varchar(50)
    '',  -- STFieldColumnFormatType - varchar(50)
    63,   -- STFieldColumnWidth - int
    7,   -- STFieldColumnVisibleIndex - int
    N''  -- STFieldColumnCommodityType - nvarchar(50)
    )
UPDATE dbo.STFieldColumns
SET STFieldColumnVisibleIndex = 8
WHERE STFieldID = 38964 AND STFieldColumnFieldName = 'MMProductionNormItemComment'

UPDATE dbo.STFieldFormats
SET STFieldFormatGroupID = (SELECT STFieldFormatGroupID FROM  dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN4')
WHERE  STFieldFormatTableName = 'MMProductionNormItems' AND STFieldFormatColumnName = 'MMProductionNormItemTotalQuantity'

INSERT INTO dbo.STFieldFormats
VALUES
(   'ProductionNorm', -- STFieldFormatModuleName - varchar(50)
    'MMProductionNormItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM  dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPercent'),  -- STFieldFormatGroupID - int
    'MMProductionNormItemDepreciationRate'  -- STFieldFormatColumnName - varchar(100)
    )
