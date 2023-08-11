IF (SELECT COUNT(1) FROM dbo.MMProductionComplexityByOperations WHERE AAStatus = 'Dummy') = 0
BEGIN
	SET IDENTITY_INSERT MMProductionComplexityByOperations ON 
	INSERT INTO [dbo].[MMProductionComplexityByOperations](
		[MMProductionComplexityByOperationID],
		[AACreatedUser],
		[AACreatedDate],
		[AAUpdatedUser],
		[AAUpdatedDate],
		[AAStatus],
		[FK_MMOperationID],
		[MMConfigProductionComplexityType],
		[MMUnitTime]
	) VALUES ( 
		0,
		'',
		NULL,
		'',
		NULL,
		'Dummy',
		0,
		'',
		0.0
	)
	SET IDENTITY_INSERT MMProductionComplexityByOperations OFF 
END

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'MMConfigProductionComplexityType',   -- AAColumnAliasName - varchar(255)
    N'Độ phức tạp sản xuất',  -- AAColumnAliasCaption - nvarchar(255)
    'MMProductionComplexityByOperations',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    NULL  -- AAColumnAliasIsSaveHistory - bit
    )
GO 

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'MMUnitTime',   -- AAColumnAliasName - varchar(255)
    N'Unit Time (Phút)',  -- AAColumnAliasCaption - nvarchar(255)
    'MMProductionComplexityByOperations',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    NULL  -- AAColumnAliasIsSaveHistory - bit
    )
GO 

INSERT INTO dbo.STFieldFormats
VALUES
(   'Operation', -- STFieldFormatModuleName - varchar(50)
    'MMProductionComplexityByOperations', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM  dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupQtyN2'),  -- STFieldFormatGroupID - int 9
    'MMUnitTime'  -- STFieldFormatColumnName - varchar(100)
    )
GO 
