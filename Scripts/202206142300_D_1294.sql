INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'MMConfigMaterialShipmentUtilityType',   -- AAColumnAliasName - varchar(255)
    N'Tiện ích xuất kho NL',  -- AAColumnAliasCaption - nvarchar(255)
    'MMConfigMaterialShipmentUtilitys',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO
INSERT INTO dbo.MMConfigMaterialShipmentUtilitys
(
    AAStatus,
    AACreatedUser,
    AACreatedDate,
    AAUpdatedUser,
    AAUpdatedDate,
    MMConfigMaterialShipmentUtilityType
)
VALUES
(   'Alive',        -- AAStatus - varchar(50)
    N'',       -- AACreatedUser - nvarchar(50)
    GETDATE(), -- AACreatedDate - datetime
    N'',       -- AAUpdatedUser - nvarchar(50)
    GETDATE(), -- AAUpdatedDate - datetime
    N'ByMasterData'        -- MMConfigMaterialShipmentUtilityType - nvarchar(50)
    )
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'ConfigMaterialShipmentUtilityTypeByMasterData', -- ADConfigKey - nvarchar(100)
    N'ByMasterData', -- ADConfigKeyValue - nvarchar(100)
    N'Xuất gộp theo MasterData Nguyên Liệu', -- ADConfigText - nvarchar(1000)
    N'', -- ADConfigKeyDesc - nvarchar(500)
    N'ConfigMaterialShipmentUtilityType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'ConfigMaterialShipmentUtilityTypeBySemiProduct', -- ADConfigKey - nvarchar(100)
    N'BySemiProduct', -- ADConfigKeyValue - nvarchar(100)
    N'Xuất không gộp, theo BTP', -- ADConfigText - nvarchar(1000)
    N'', -- ADConfigKeyDesc - nvarchar(500)
    N'ConfigMaterialShipmentUtilityType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

IF (SELECT COUNT(1) FROM dbo.MMConfigMaterialShipmentUtilitys WHERE MMConfigMaterialShipmentUtilityID = 0) = 0
BEGIN
	SET IDENTITY_INSERT MMConfigMaterialShipmentUtilitys ON 
	INSERT INTO [dbo].[MMConfigMaterialShipmentUtilitys](
		[MMConfigMaterialShipmentUtilityID],
		[AAStatus],
		[AACreatedUser],
		[AACreatedDate],
		[AAUpdatedUser],
		[AAUpdatedDate],
		[MMConfigMaterialShipmentUtilityType]
	) VALUES ( 
		0,
		'',
		'',
		NULL,
		'',
		NULL,
		''
	)
	SET IDENTITY_INSERT MMConfigMaterialShipmentUtilitys OFF 
END
GO
