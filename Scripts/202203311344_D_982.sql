INSERT INTO dbo.ADTemplateParams
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    'IsInventory',   -- ADTemplateParamNo - varchar(50)
    N'Kiểm kê',  -- ADTemplateParamName - nvarchar(250)
    '',   -- ADTemplateParamValue - varchar(50)
    1, -- ADTemplateParamIsDisplay - bit
    (SELECT ADTemplateID FROM dbo.ADTemplates WHERE AAStatus = 'Alive' AND ADTemplateNo = 'KT_RP_0006'),    -- FK_ADTemplateID - int
    4,    -- ADTemplateParamOrder - tinyint
    'Bit',   -- ADTemplateParamDataType - varchar(50)
    '',   -- ADTemplateParamLookupEdit - varchar(50)
    '',   -- ADTemplateParamColumns - varchar(250)
    N'',  -- ADTemplateParamFilter - nvarchar(4000)
    N'',  -- ADTemplateParamParentField - nvarchar(100)
    N'',  -- ADTemplateParamFieldRelation - nvarchar(100)
    0  -- ADTemplateParamIsNotNull - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   19,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACAssetIsInventory',   -- AAColumnAliasName - varchar(255)
    N'Kiểm kê',  -- AAColumnAliasCaption - nvarchar(255)
    'KT_RP_0006',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   19,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'IsInventory',   -- AAColumnAliasName - varchar(255)
    N'Kiểm kê',  -- AAColumnAliasCaption - nvarchar(255)
    'RP_GetEquipmentHistoryByRoom',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   19,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'IsInventory',   -- AAColumnAliasName - varchar(255)
    N'Kiểm kê',  -- AAColumnAliasCaption - nvarchar(255)
    'RP_GetAllEquipmentHistoryByRoom',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   19,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'IsInventory',   -- AAColumnAliasName - varchar(255)
    N'Kiểm kê',  -- AAColumnAliasCaption - nvarchar(255)
    'RP_GetAssetCard',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
)
GO