IF (SELECT COUNT(1) FROM dbo.ARPriceSheets WHERE ARPriceSheetID = 0) = 0
BEGIN
	SET IDENTITY_INSERT ARPriceSheets ON 
	INSERT INTO [dbo].[ARPriceSheets](
		[ARPriceSheetID],
		[AACreatedDate],
		[AACreatedUser],
		[AAUpdatedDate],
		[AAUpdatedUser],
		[AAStatus],
		[FK_BRBranchID],
		[FK_HREmployeeID],
		[ARPriceSheetNo],
		[ARPriceSheetName],
		[ARPriceSheetDesc],
		[ARPriceSheetDate],
		[ARPriceSheetStartDate],
		[ARPriceSheetEndDate],
		[ARPriceSheetStatus],
		[ARCustomerType]
	) VALUES ( 
		0,
		NULL,
		'',
		NULL,
		'',
		'',
		0,
		0,
		'',
		'',
		'',
		NULL,
		NULL,
		NULL,
		'',
		''
	)
	SET IDENTITY_INSERT ARPriceSheets OFF 
END

IF (SELECT COUNT(1) FROM dbo.ARPriceSheets WHERE ARPriceSheetID = 0) = 0
BEGIN
	SET IDENTITY_INSERT ARPriceSheets ON 
	INSERT INTO [dbo].[ARPriceSheets](
		[ARPriceSheetID],
		[AACreatedDate],
		[AACreatedUser],
		[AAUpdatedDate],
		[AAUpdatedUser],
		[AAStatus],
		[FK_BRBranchID],
		[FK_HREmployeeID],
		[ARPriceSheetNo],
		[ARPriceSheetName],
		[ARPriceSheetDesc],
		[ARPriceSheetDate],
		[ARPriceSheetStartDate],
		[ARPriceSheetEndDate],
		[ARPriceSheetStatus],
		[ARCustomerType]
	) VALUES ( 
		0,
		NULL,
		'',
		NULL,
		'',
		'',
		0,
		0,
		'',
		'',
		'',
		NULL,
		NULL,
		NULL,
		'',
		''
	)
	SET IDENTITY_INSERT ARPriceSheets OFF 
END

IF (SELECT COUNT(1) FROM dbo.ARPriceSheetItemWorks WHERE ARPriceSheetItemWorkID = 0) = 0
BEGIN
	SET IDENTITY_INSERT ARPriceSheetItemWorks ON 
	INSERT INTO [dbo].[ARPriceSheetItemWorks](
		[ARPriceSheetItemWorkID],
		[AAStatus],
		[AACreatedUser],
		[AAUpdatedUser],
		[AACreatedDate],
		[AAUpdatedDate],
		[FK_ICProductID],
		[FK_ICProductGroupID],
		[FK_ICDepartmentID],
		[FK_ICMeasureUnitID],
		[FK_ARPriceSheetItemID],
		[FK_ARPriceSheetID],
		[ARPriceSheetItemWorkProductNo],
		[ARPriceSheetItemWorkProductName],
		[ARPriceSheetItemWorkProductDesc],
		[ARPriceSheetItemWorkProductQty],
		[ARPriceSheetItemWorkProductType],
		[ARPriceSheetItemWorkProductUnitPrice],
		[ARPriceSheetItemWorkTotalAmount],
		[ARPriceSheetItemWorkSubTotalAmount],
		[ARPriceSheetItemWorkProductChargeCheck],
		[ARPriceSheetItemWorkStatus],
		[ARPriceSheetItemWorkType],
		[ARPriceSheetItemWorkParentID],
		[ARPriceSheetItemWorkComment],
		[ARPriceSheetItemWorkDiscountAmount],
		[ARPriceSheetItemWorkDiscountPerCent]
	) VALUES ( 
		0,
		'',
		'',
		'',
		NULL,
		NULL,
		0,
		0,
		0,
		0,
		0,
		0,
		'',
		'',
		'',
		0.0,
		'',
		0.0,
		0.0,
		0.0,
		0,
		'',
		'',
		0,
		'',
		0.0,
		0.0
	)
	SET IDENTITY_INSERT ARPriceSheetItemWorks OFF 
END
