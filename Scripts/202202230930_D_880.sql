IF (SELECT COUNT(1) FROM dbo.ARSaleOrderItemOtherFees WHERE ARSaleOrderItemOtherFeeID = 0) = 0
BEGIN
	SET IDENTITY_INSERT ARSaleOrderItemOtherFees ON 
	INSERT INTO [dbo].[ARSaleOrderItemOtherFees](
		[ARSaleOrderItemOtherFeeID],
		[AAStatus],
		[AACreatedDate],
		[AACreatedUser],
		[AAUpdatedDate],
		[AAUpdatedUser],
		[FK_ARSaleOrderID],
		[ARSaleOrderItemOtherFeeName],
		[ARSaleOrderItemOtherFeeQty],
		[ARSaleOrderItemOtherFeeUnitPrice],
		[ARSaleOrderItemOtherFeeTotalPrice]
	) VALUES ( 
		0,
		'',
		NULL,
		'',
		NULL,
		'',
		0,
		'',
		0.0,
		0.0,
		0.0
	)
	SET IDENTITY_INSERT ARSaleOrderItemOtherFees OFF 
END

IF (SELECT COUNT(1) FROM dbo.ARSaleOrderItemAllocationFees WHERE ARSaleOrderItemAllocationFeeID = 0) = 0
BEGIN
	SET IDENTITY_INSERT ARSaleOrderItemAllocationFees ON 
	INSERT INTO [dbo].[ARSaleOrderItemAllocationFees](
		[ARSaleOrderItemAllocationFeeID],
		[AAStatus],
		[AACreatedUser],
		[AAUpdatedUser],
		[AACreatedDate],
		[AAUpdatedDate],
		[FK_ICProductID],
		[FK_ARSaleOrderID],
		[ARSaleOrderItemAllocationFeeProductNo],
		[ARSaleOrderItemAllocationFeeProductName],
		[ARSaleOrderItemAllocationFeeProductNoOfOldSys],
		[ARSaleOrderItemAllocationFeeFeePercent],
		[ARSaleOrderItemAllocationFeeFeeAmount]
	) VALUES ( 
		0,
		'',
		'',
		'',
		NULL,
		NULL,
		0,
		0,
		'',
		'',
		'',
		0.0,
		0.0
	)
	SET IDENTITY_INSERT ARSaleOrderItemAllocationFees OFF 
END

INSERT INTO dbo.STScreens
VALUES
(   'DMSO106',   -- STScreenNumber - varchar(100)
    N'Chi phí cộng thêm',  -- STScreenText - nvarchar(255)
    'guiOtherFee',   -- STScreenName - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'SaleOrder'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    -1,    -- STScreenBackColor - int
    -16777216,    -- STScreenForeColor - int
    N'Tahoma',  -- STScreenFontName - nvarchar(500)
    8.25,  -- STScreenFontSize - float
    'Regular',   -- STScreenFontStyle - varchar(100)
    'DM',   -- STScreenTag - varchar(50)
    0,    -- STScreenSizeWidth - int
    0,    -- STScreenSizeHeight - int
    0,    -- STScreenLocationX - int
    0,    -- STScreenLocationY - int
    1, -- STScreenShowModal - bit
    1, -- STScreenTopMost - bit
    N'',  -- STScreenMatchCode01 - nvarchar(50)
    0, -- STScreenShowInfoPanel - bit
    7,    -- STScreenSortOrder - int
    N'',  -- STScreenPrivilege - nvarchar(50)
    1  -- STScreenVisible - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARSaleOrderItemOtherFeeName',   -- AAColumnAliasName - varchar(255)
    N'Tên chi phí',  -- AAColumnAliasCaption - nvarchar(255)
    'ARSaleOrderItemOtherFees',   -- AATableName - varchar(50)
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
    'ARSaleOrderItemOtherFeeQty',   -- AAColumnAliasName - varchar(255)
    N'Số lượng',  -- AAColumnAliasCaption - nvarchar(255)
    'ARSaleOrderItemOtherFees',   -- AATableName - varchar(50)
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
    'ARSaleOrderItemOtherFeeUnitPrice',   -- AAColumnAliasName - varchar(255)
    N'Đơn giá',  -- AAColumnAliasCaption - nvarchar(255)
    'ARSaleOrderItemOtherFees',   -- AATableName - varchar(50)
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
    'ARSaleOrderItemOtherFeeTotalPrice',   -- AAColumnAliasName - varchar(255)
    N'Thành tiền',  -- AAColumnAliasCaption - nvarchar(255)
    'ARSaleOrderItemOtherFees',   -- AATableName - varchar(50)
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
    'ARSaleOrderItemAllocationFeeProductNo',   -- AAColumnAliasName - varchar(255)
    N'Mã sản phẩm',  -- AAColumnAliasCaption - nvarchar(255)
    'ARSaleOrderItemAllocationFees',   -- AATableName - varchar(50)
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
    'ARSaleOrderItemAllocationFeeProductName',   -- AAColumnAliasName - varchar(255)
    N'Tên sản phẩm',  -- AAColumnAliasCaption - nvarchar(255)
    'ARSaleOrderItemAllocationFees',   -- AATableName - varchar(50)
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
    'ARSaleOrderItemAllocationFeeProductNoOfOldSys',   -- AAColumnAliasName - varchar(255)
    N'Mã HT cũ',  -- AAColumnAliasCaption - nvarchar(255)
    'ARSaleOrderItemAllocationFees',   -- AATableName - varchar(50)
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
    'ARSaleOrderItemAllocationFeeFeePercent',   -- AAColumnAliasName - varchar(255)
    N'% phân bổ',  -- AAColumnAliasCaption - nvarchar(255)
    'ARSaleOrderItemAllocationFees',   -- AATableName - varchar(50)
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
    'ARSaleOrderItemAllocationFeeFeeAmount',   -- AAColumnAliasName - varchar(255)
    N'Thành tiền phân bổ',  -- AAColumnAliasCaption - nvarchar(255)
    'ARSaleOrderItemAllocationFees',   -- AATableName - varchar(50)
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
(   'SaleOrder', -- STFieldFormatModuleName - varchar(50)
    'ARSaleOrderItemOtherFees', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPriceByCurrency'),  -- STFieldFormatGroupID - int
    'ARSaleOrderItemOtherFeeQty'  -- STFieldFormatColumnName - varchar(100)
)
GO
INSERT INTO dbo.STFieldFormats
VALUES
(   'SaleOrder', -- STFieldFormatModuleName - varchar(50)
    'ARSaleOrderItemOtherFees', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPriceByCurrency'),  -- STFieldFormatGroupID - int
    'ARSaleOrderItemOtherFeeUnitPrice'  -- STFieldFormatColumnName - varchar(100)
)
GO
INSERT INTO dbo.STFieldFormats
VALUES
(   'SaleOrder', -- STFieldFormatModuleName - varchar(50)
    'ARSaleOrderItemOtherFees', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPriceByCurrency'),  -- STFieldFormatGroupID - int
    'ARSaleOrderItemOtherFeeTotalPrice'  -- STFieldFormatColumnName - varchar(100)
)
GO
INSERT INTO dbo.STFieldFormats
VALUES
(   'SaleOrder', -- STFieldFormatModuleName - varchar(50)
    'ARSaleOrderItemAllocationFees', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPriceByCurrency'),  -- STFieldFormatGroupID - int
    'ARSaleOrderItemAllocationFeeFeePercent'  -- STFieldFormatColumnName - varchar(100)
)
GO
INSERT INTO dbo.STFieldFormats
VALUES
(   'SaleOrder', -- STFieldFormatModuleName - varchar(50)
    'ARSaleOrderItemAllocationFees', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPriceByCurrency'),  -- STFieldFormatGroupID - int
    'ARSaleOrderItemAllocationFeeFeeAmount'  -- STFieldFormatColumnName - varchar(100)
)
GO