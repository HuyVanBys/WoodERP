INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARSaleOrderName',   -- AAColumnAliasName - varchar(255)
    N'Mã đơn hàng nội bộ',  -- AAColumnAliasCaption - nvarchar(255)
    'ARSaleOrders',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    NULL  -- AAColumnAliasIsSaveHistory - bit
    )
INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ICShipmentSOName',   -- AAColumnAliasName - varchar(255)
    N'Mã đơn hàng nội bộ',  -- AAColumnAliasCaption - nvarchar(255)
    'ICShipments',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    NULL  -- AAColumnAliasIsSaveHistory - bit
    )
INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARProductionPlanningSaleOrderName',   -- AAColumnAliasName - varchar(255)
    N'Mã đơn hàng nội bộ',  -- AAColumnAliasCaption - nvarchar(255)
    'ARProductionPlannings',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    NULL  -- AAColumnAliasIsSaveHistory - bit
    )
INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'MMBatchProductSOName',   -- AAColumnAliasName - varchar(255)
    N'Mã đơn hàng nội bộ',  -- AAColumnAliasCaption - nvarchar(255)
    'MMBatchProducts',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    NULL  -- AAColumnAliasIsSaveHistory - bit
    )
INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'MMBatchProductItemSOName',   -- AAColumnAliasName - varchar(255)
    N'Mã đơn hàng nội bộ',  -- AAColumnAliasCaption - nvarchar(255)
    'MMBatchProductProductionNormItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    NULL  -- AAColumnAliasIsSaveHistory - bit
    )
INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ICReceiptSOName',   -- AAColumnAliasName - varchar(255)
    N'Mã đơn hàng nội bộ',  -- AAColumnAliasCaption - nvarchar(255)
    'ICReceipts',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    NULL  -- AAColumnAliasIsSaveHistory - bit
    )

INSERT INTO dbo.STFieldColumns
VALUES
(   '',  -- STFieldColumnIDString - varchar(50)
    (SELECT STFieldID FROM  dbo.STFields WHERE STFieldName = 'fld_lkeFK_MMBatchProductID' AND STScreenID = (SELECT STScreenID FROM  dbo.STScreens WHERE STScreenNumber = 'DMSPRC100')),   -- STFieldID - int
    N'MMBatchProductSOName', -- STFieldColumnName - nvarchar(256)
    N'Mã đơn hàng nội bộ', -- STFieldColumnCaption - nvarchar(255)
    N'MMBatchProductSOName', -- STFieldColumnFieldName - nvarchar(256)
    '',  -- STFieldColumnFormatString - varchar(50)
    'None',  -- STFieldColumnFormatType - varchar(50)
    30,   -- STFieldColumnWidth - int
    1,   -- STFieldColumnVisibleIndex - int
    N''  -- STFieldColumnCommodityType - nvarchar(50)
    )
