

INSERT INTO dbo.STFieldFormats
VALUES
(   'Barcode', -- STFieldFormatModuleName - varchar(50)
    'ICBarcodeItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM  dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupQtyN2'),  -- STFieldFormatGroupID - int
    'ICBarCodeItemPrice'  -- STFieldFormatColumnName - varchar(100)
    )
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'Barcode', -- STFieldFormatModuleName - varchar(50)
    'ICBarcodeItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM  dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupQtyN2'),  -- STFieldFormatGroupID - int
    'ICBarCodeItemInventoryQty'  -- STFieldFormatColumnName - varchar(100)
    )
GO


INSERT INTO dbo.STFieldFormats
VALUES
(   'Barcode', -- STFieldFormatModuleName - varchar(50)
    'ICBarcodeItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM  dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupQtyN2'),  -- STFieldFormatGroupID - int
    'ICBarCodeItemBarcodeQty'  -- STFieldFormatColumnName - varchar(100)
    )
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ICBarCodeItemBarcode',   -- AAColumnAliasName - varchar(255)
    N'Mã vạch',  -- AAColumnAliasCaption - nvarchar(255)
    'ICBarcodeItems',   -- AATableName - varchar(50)
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
    'FK_ICProductID',   -- AAColumnAliasName - varchar(255)
    N'Mã sản phẩm',  -- AAColumnAliasCaption - nvarchar(255)
    'ICBarcodeItems',   -- AATableName - varchar(50)
    'ICProducts',   -- AAReferenceTable - varchar(512)
    'ICProductNo',   -- AADisplayedMember - varchar(512)
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
    'ICProductSupplierNumber',   -- AAColumnAliasName - varchar(255)
    N'Mã sản phẩm NCC',  -- AAColumnAliasCaption - nvarchar(255)
    'ICBarcodeItems',   -- AATableName - varchar(50)
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
    'ICBarCodeItemDesc',   -- AAColumnAliasName - varchar(255)
    N'Mô tả',  -- AAColumnAliasCaption - nvarchar(255)
    'ICBarcodeItems',   -- AATableName - varchar(50)
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
    'FK_ICProductGroupID',   -- AAColumnAliasName - varchar(255)
    N'Nhóm hàng',  -- AAColumnAliasCaption - nvarchar(255)
    'ICBarcodeItems',   -- AATableName - varchar(50)
    'ICProductGroups',   -- AAReferenceTable - varchar(512)
    'ICProductGroupName',   -- AADisplayedMember - varchar(512)
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
    'ICBarCodeItemInventoryQty',   -- AAColumnAliasName - varchar(255)
    N'Số lượng tồn',  -- AAColumnAliasCaption - nvarchar(255)
    'ICBarcodeItems',   -- AATableName - varchar(50)
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
    'ICBarCodeItemBarcodeQty',   -- AAColumnAliasName - varchar(255)
    N'Số lượng mã vạch cần in',  -- AAColumnAliasCaption - nvarchar(255)
    'ICBarcodeItems',   -- AATableName - varchar(50)
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
    'ICBarCodeItemPrice',   -- AAColumnAliasName - varchar(255)
    N'Giá bán',  -- AAColumnAliasCaption - nvarchar(255)
    'ICBarcodeItems',   -- AATableName - varchar(50)
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
    'ICBarcodeNo',   -- AAColumnAliasName - varchar(255)
    N'Mã chứng từ',  -- AAColumnAliasCaption - nvarchar(255)
    'ICBarcodes',   -- AATableName - varchar(50)
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
    'ICBarcodeDesc',   -- AAColumnAliasName - varchar(255)
    N'Mô tả',  -- AAColumnAliasCaption - nvarchar(255)
    'ICBarcodes',   -- AATableName - varchar(50)
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
    'ICBarcodeDate',   -- AAColumnAliasName - varchar(255)
    N'Ngày chứng từ',  -- AAColumnAliasCaption - nvarchar(255)
    'ICBarcodes',   -- AATableName - varchar(50)
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
    'FK_HREmployeeID',   -- AAColumnAliasName - varchar(255)
    N'Nhân viên',  -- AAColumnAliasCaption - nvarchar(255)
    'ICBarcodes',   -- AATableName - varchar(50)
    'HREmployees',   -- AAReferenceTable - varchar(512)
    'HREmployeeName',   -- AADisplayedMember - varchar(512)
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
    'ICBarcodeStatus',   -- AAColumnAliasName - varchar(255)
    N'Tình trạng',  -- AAColumnAliasCaption - nvarchar(255)
    'ICBarcodes',   -- AATableName - varchar(50)
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
    'ICBarcodeReference',   -- AAColumnAliasName - varchar(255)
    N'Mã tham chiếu',  -- AAColumnAliasCaption - nvarchar(255)
    'ICBarcodes',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    NULL  -- AAColumnAliasIsSaveHistory - bit
    )
	GO

INSERT INTO dbo.STScreens
VALUES
(   'SMBC100',   -- STScreenNumber - varchar(100)
    N'Tim kiếm',  -- STScreenText - nvarchar(255)
    'guiBarcodeSearch',   -- STScreenName - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'Barcode'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    -1838594,    -- STScreenBackColor - int
    -16777216,    -- STScreenForeColor - int
    N'Tahoma',  -- STScreenFontName - nvarchar(500)
    8.25,  -- STScreenFontSize - float
    'Regular',   -- STScreenFontStyle - varchar(100)
    'SM',   -- STScreenTag - varchar(50)
    0,    -- STScreenSizeWidth - int
    0,    -- STScreenSizeHeight - int
    0,    -- STScreenLocationX - int
    0,    -- STScreenLocationY - int
    1, -- STScreenShowModal - bit
    1, -- STScreenTopMost - bit
    N'',  -- STScreenMatchCode01 - nvarchar(50)
    0, -- STScreenShowInfoPanel - bit
    -1,    -- STScreenSortOrder - int
    N'',  -- STScreenPrivilege - nvarchar(50)
    1  -- STScreenVisible - bit
    )

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'BarcodeStatusNew', -- ADConfigKey - nvarchar(100)
    N'New', -- ADConfigKeyValue - nvarchar(100)
    N'Tạo mới', -- ADConfigText - nvarchar(1000)
    N'BarcodeStatusNew', -- ADConfigKeyDesc - nvarchar(500)
    N'BarcodeStatus', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
    )
GO
INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'BarcodeStatusPrinted', -- ADConfigKey - nvarchar(100)
    N'Printed', -- ADConfigKeyValue - nvarchar(100)
    N'Đã in', -- ADConfigText - nvarchar(1000)
    N'BarcodeStatusPrinted', -- ADConfigKeyDesc - nvarchar(500)
    N'BarcodeStatus', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
    )
GO

INSERT INTO dbo.GENumbering
VALUES
(   N'',       -- AACreatedUser - nvarchar(50)
    GETDATE(), -- AACreatedDate - datetime
    N'',       -- AAUpdatedUser - nvarchar(50)
    GETDATE(), -- AAUpdatedDate - datetime
    'Alive',        -- AAStatus - varchar(10)
    N'Barcode',       -- GENumberingName - nvarchar(50)
    N'BC-',       -- GENumberingPrefix - nvarchar(50)
    6,         -- GENumberingLength - int
    1,         -- GENumberingStart - int
    N'In mã vạch',       -- GENumberingDesc - nvarchar(255)
    1,         -- FK_BRBranchID - int
    1,      -- GENumberingPrefixHaveYear - bit
    1,      -- GENumberingPrefixHaveMonth - bit
    0,      -- GENumberingPrefixHaveDay - bit
    0,      -- GENumberingPrefixHaveStock - bit
    0,      -- GENumberingPrefixHaveBankAbbreviation - bit
    N'{1}{2}.{7}'        -- GENumberingFormat - nvarchar(50)
    )
INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'Barcode'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnSave',  -- STToolbarName - nvarchar(50)
    N'Lưu',  -- STToolbarDesc - nvarchar(255)
    'Save',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Lưu (F8)',  -- STToolbarCaption - nvarchar(50)
    N'Action',  -- STToolbarGroup - nvarchar(50)
    3,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    0,    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'Barcode'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnEdit',  -- STToolbarName - nvarchar(50)
    N'Sửa',  -- STToolbarDesc - nvarchar(255)
    'Edit',   -- STToolbarTag - varchar(50)
    'Check',   -- STToolbarStyle - varchar(50)
    N'Sửa (F5)',  -- STToolbarCaption - nvarchar(50)
    N'Action',  -- STToolbarGroup - nvarchar(50)
    1,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'Edit',  -- STToolbarPrivilege - nvarchar(50)
    0,    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'Barcode'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnCancel',  -- STToolbarName - nvarchar(50)
    N'Hủy',  -- STToolbarDesc - nvarchar(255)
    'Cancel',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Hủy (F7)',  -- STToolbarCaption - nvarchar(50)
    N'Action',  -- STToolbarGroup - nvarchar(50)
    2,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    0,    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'Barcode'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnDelete',  -- STToolbarName - nvarchar(50)
    N'Delete',  -- STToolbarDesc - nvarchar(255)
    'Delete',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Xóa (F6)',  -- STToolbarCaption - nvarchar(50)
    N'Action',  -- STToolbarGroup - nvarchar(50)
    4,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    0,    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO
INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ICBarCodeItemProductName',   -- AAColumnAliasName - varchar(255)
    N'Tên sản phẩm',  -- AAColumnAliasCaption - nvarchar(255)
    'ICBarcodeItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    NULL  -- AAColumnAliasIsSaveHistory - bit
    )
	GO

IF (SELECT COUNT(1) FROM dbo.ICBarcodes WHERE ICBarcodeID = 0) = 0
BEGIN
	SET IDENTITY_INSERT ICBarcodes ON 
	INSERT INTO [dbo].[ICBarcodes](
		[ICBarcodeID],
		[AACreatedDate],
		[AACreatedUser],
		[AAUpdatedDate],
		[AAUpdatedUser],
		[AAStatus],
		[ICBarcodeNo],
		[ICBarcodeDate],
		[ICBarcodeDesc],
		[ICBarcodeReference],
		[ICBarcodeStatus],
		[FK_HREmployeeID]
	) VALUES ( 
		0,
		NULL,
		'',
		NULL,
		'',
		'',
		'',
		NULL,
		'',
		'',
		'',
		0
	)
	SET IDENTITY_INSERT ICBarcodes OFF 
END
GO

IF (SELECT COUNT(1) FROM dbo.ICBarcodeItems WHERE ICBarcodeItemID = 0) = 0
BEGIN
	SET IDENTITY_INSERT ICBarcodeItems ON 
	INSERT INTO [dbo].[ICBarcodeItems](
		[ICBarcodeItemID],
		[AAStatus],
		[FK_ICBarcodeID],
		[ICBarCodeItemBarcode],
		[FK_ICProductID],
		[ICProductSupplierNumber],
		[ICBarCodeItemDesc],
		[FK_ICProductGroupID],
		[ICBarCodeItemInventoryQty],
		[ICBarCodeItemBarcodeQty],
		[ICBarCodeItemPrice]
	) VALUES ( 
		0,
		'',
		0,
		'',
		0,
		'',
		'',
		0,
		0.0,
		0.0,
		0.0
	)
	SET IDENTITY_INSERT ICBarcodeItems OFF 
END
GO











