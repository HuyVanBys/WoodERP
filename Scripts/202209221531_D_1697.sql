IF (SELECT COUNT(1) FROM dbo.ICWidthGroups WHERE ICWidthGroupID = 0) = 0
BEGIN
	SET IDENTITY_INSERT ICWidthGroups ON 
	INSERT INTO [dbo].[ICWidthGroups](
		[ICWidthGroupID],
		[AAStatus],
		[AACreatedUser],
		[AACreatedDate],
		[AAUpdatedUser],
		[AAUpdatedDate],
		[ICWidthGroupName],
		[ICWidthGroupMinValue],
		[ICWidthGroupMaxValue]
	) VALUES ( 
		0,
		'',
		'',
		NULL,
		'',
		NULL,
		'',
		0.0,
		0.0
	)
	SET IDENTITY_INSERT ICWidthGroups OFF 
END

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ICWidthGroupName',   -- AAColumnAliasName - varchar(255)
    N'Tên nhóm',  -- AAColumnAliasCaption - nvarchar(255)
    'ICWidthGroups',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    0, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ICWidthGroupMinValue',   -- AAColumnAliasName - varchar(255)
    N'Rộng min',  -- AAColumnAliasCaption - nvarchar(255)
    'ICWidthGroups',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    0, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ICWidthGroupMaxValue',   -- AAColumnAliasName - varchar(255)
    N'Rộng max',  -- AAColumnAliasCaption - nvarchar(255)
    'ICWidthGroups',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    0, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   '', -- STFieldFormatModuleName - varchar(50)
    'ICWidthGroups', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN5'),  -- STFieldFormatGroupID - int
    'ICWidthGroupMaxValue'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   '', -- STFieldFormatModuleName - varchar(50)
    'ICWidthGroups', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN5'),  -- STFieldFormatGroupID - int
    'ICWidthGroupMinValue'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.GELookupTables
VALUES
(   'Alive',  -- AAStatus - varchar(50)
    N'ICWidthGroups', -- GELookupTableName - nvarchar(200)
    N'', -- GELookupTableDesc - nvarchar(200)
    N'ICWidthGroupName', -- GELookupTableDisplayColumn - nvarchar(200)
    'ICWidthGroupID',  -- GELookupTableValueColumn - varchar(512)
    'ICWidthGroupName'   -- GELookupTableLookupColumns - varchar(512)
)
GO
