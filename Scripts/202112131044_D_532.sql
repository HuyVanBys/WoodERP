IF (SELECT COUNT(1) FROM dbo.ARCustomerBusinessTypes WHERE ARCustomerBusinessTypeID = 0) = 0
BEGIN
	SET IDENTITY_INSERT ARCustomerBusinessTypes ON 
	INSERT INTO [dbo].[ARCustomerBusinessTypes](
		[ARCustomerBusinessTypeID],
		[AAStatus],
		[AACreatedUser],
		[AACreatedDate],
		[AAUpdatedUser],
		[AAUpdatedDate],
		[ARCustomerBusinessTypeNo],
		[ARCustomerBusinessTypeName],
		[ARCustomerBusinessTypeAbbreviation]
	) VALUES ( 
		0,
		'',
		'',
		NULL,
		'',
		NULL,
		'',
		'',
		''
	)
	SET IDENTITY_INSERT ARCustomerBusinessTypes OFF 
END


INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARCustomerBusinessTypeName',   -- AAColumnAliasName - varchar(255)
    N'Tên loại hình',  -- AAColumnAliasCaption - nvarchar(255)
    'ARCustomerBusinessTypes',   -- AATableName - varchar(50)
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
    'ARCustomerBusinessTypeAbbreviation',   -- AAColumnAliasName - varchar(255)
    N'Viết tắt',  -- AAColumnAliasCaption - nvarchar(255)
    'ARCustomerBusinessTypes',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.GELookupTables
VALUES
(   'Alive',  -- AAStatus - varchar(50)
    N'ARCustomerBusinessTypes', -- GELookupTableName - nvarchar(200)
    N'ARCustomerBusinessTypes', -- GELookupTableDesc - nvarchar(200)
    N'ARCustomerBusinessTypeName', -- GELookupTableDisplayColumn - nvarchar(200)
    'ARCustomerBusinessTypeID',  -- GELookupTableValueColumn - varchar(512)
    'ARCustomerBusinessTypeAbbreviation; ARCustomerBusinessTypeName'   -- GELookupTableLookupColumns - varchar(512)
)
GO
