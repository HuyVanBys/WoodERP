IF (SELECT COUNT(1) FROM dbo.MMCalculatorProductionNormItemMaterials WHERE MMCalculatorProductionNormItemMaterialID = 0) = 0
BEGIN
	SET IDENTITY_INSERT MMCalculatorProductionNormItemMaterials ON 
	INSERT INTO [dbo].[MMCalculatorProductionNormItemMaterials](
		[MMCalculatorProductionNormItemMaterialID],
		[AACreatedUser],
		[AACreatedDate],
		[AAUpdatedUser],
		[AAUpdatedDate],
		[AAStatus],
		[FK_MMCalculatorProductionNormCostID],
		[FK_ICProductMaterialID],
		[MMCalculatorProductionNormItemMaterialHeigth],
		[MMCalculatorProductionNormItemMaterialLengthMin],
		[MMCalculatorProductionNormItemMaterialLengthMax],
		[MMCalculatorProductionNormItemMaterialWidthMin],
		[MMCalculatorProductionNormItemMaterialWidthMax],
		[MMCalculatorProductionNormItemMaterialDepreciationQty],
		[MMCalculatorProductionNormItemMaterialUnitCost],
		[MMCalculatorProductionNormItemMaterialTotalCost],
		[MMCalculatorProductionNormItemMaterialDepreciationFactor],
		[MMCalculatorProductionNormItemMaterialWoodQty],
		[FK_ICProductAttributeQualityID],
		[MMCalculatorProductionNormItemMaterialNo],
		[MMCalculatorProductionNormItemMaterialName],
		[MMCalculatorProductionNormItemMaterialDesc]
	) VALUES ( 
		0,
		'',
		NULL,
		'',
		NULL,
		'',
		0,
		0,
		0.0,
		0.0,
		0.0,
		0.0,
		0.0,
		0.0,
		0.0,
		0.0,
		0.0,
		0.0,
		0,
		'',
		'',
		''
	)
	SET IDENTITY_INSERT MMCalculatorProductionNormItemMaterials OFF 
END

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'MMCalculatorProductionNormItemMaterialNo',   -- AAColumnAliasName - varchar(255)
    N'Mã nguyên liệu',  -- AAColumnAliasCaption - nvarchar(255)
    'MMCalculatorProductionNormItemMaterials',   -- AATableName - varchar(50)
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
    'MMCalculatorProductionNormItemMaterialUnitCost',   -- AAColumnAliasName - varchar(255)
    N'Đơn giá',  -- AAColumnAliasCaption - nvarchar(255)
    'MMCalculatorProductionNormItemMaterials',   -- AATableName - varchar(50)
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
    'MMCalculatorProductionNormItemMaterialTotalCost',   -- AAColumnAliasName - varchar(255)
    N'Thành tiền',  -- AAColumnAliasCaption - nvarchar(255)
    'MMCalculatorProductionNormItemMaterials',   -- AATableName - varchar(50)
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
    'MMCalculatorProductionNormItemMaterialWoodQty',   -- AAColumnAliasName - varchar(255)
    N'Khối lượng',  -- AAColumnAliasCaption - nvarchar(255)
    'MMCalculatorProductionNormItemMaterials',   -- AATableName - varchar(50)
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
    'MMCalculatorProductionNormItemMaterialName',   -- AAColumnAliasName - varchar(255)
    N'Tên nguyên liệu',  -- AAColumnAliasCaption - nvarchar(255)
    'MMCalculatorProductionNormItemMaterials',   -- AATableName - varchar(50)
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
    'MMCalculatorProductionNormItemMaterialDesc',   -- AAColumnAliasName - varchar(255)
    N'Mô tả',  -- AAColumnAliasCaption - nvarchar(255)
    'MMCalculatorProductionNormItemMaterials',   -- AATableName - varchar(50)
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
(   'CalculatorProductionNormCost', -- STFieldFormatModuleName - varchar(50)
    'MMCalculatorProductionNormItemMaterials', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'MMCalculatorProductionNormItemMaterialWoodQty'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'CalculatorProductionNormCost', -- STFieldFormatModuleName - varchar(50)
    'MMCalculatorProductionNormItemMaterials', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'MMCalculatorProductionNormItemMaterialTotalCost'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'CalculatorProductionNormCost', -- STFieldFormatModuleName - varchar(50)
    'MMCalculatorProductionNormItemMaterials', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'MMCalculatorProductionNormItemMaterialUnitCost'  -- STFieldFormatColumnName - varchar(100)
)
GO


