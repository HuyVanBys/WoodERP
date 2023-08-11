
UPDATE dbo.ADTemplateParams 
SET ADTemplateParamColumns = 'MMProductionNormNo,MMProductionNormProductNo,MMProductionNormOldProductNo,MMProductionNormICProductName'
WHERE AAStatus  = 'Alive'
AND FK_ADTemplateID = (SELECT ADTemplateID FROM dbo.ADTemplates WHERE ADTemplateNo = 'RP_GetMaterialsAndIngredientsInBOM')
AND ADTemplateParamNo = 'ProductionNormID'

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'MMProductionNormProductNo',   -- AAColumnAliasName - varchar(255)
    N'Mã sản phẩm',  -- AAColumnAliasCaption - nvarchar(255)
    'MMProductionNorms',   -- AATableName - varchar(50)
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
    'MMProductionNormICProductName',   -- AAColumnAliasName - varchar(255)
    N'Tên sản phẩm',  -- AAColumnAliasCaption - nvarchar(255)
    'MMProductionNorms',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO


