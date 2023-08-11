UPDATE dbo.STToolbars
SET AAStatus = 'Delete'
WHERE STModuleID = (SELECT STModuleID FROM  STmodules WHERE STModuleName = 'FeePayment')
AND STToolbarName IN ('fld_barbtnInvoiceInternalReceipt','fld_barbtnPurchaseReceipt','fld_barbtnTransferReceipt')

INSERT INTO dbo.STToolbarFunctions
VALUES
(   '', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM  STmodules WHERE STModuleName = 'FeePayment') AND STToolbarName = 'fld_barbtnNewHinterLandFeePayment'),  -- STToolbarID - int
    'NewPurchaseReceipt', -- STToolbarFunctionName - varchar(250)
    'void NewPurchaseReceipt()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.FeePayment.FeePaymentModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
    )

IF (SELECT COUNT(1) FROM dbo.APBillOfLadingItems WHERE APBillOfLadingItemID = 0) = 0
BEGIN
	SET IDENTITY_INSERT APBillOfLadingItems ON 
	INSERT INTO [dbo].[APBillOfLadingItems](
		[APBillOfLadingItemID],
		[AACreatedDate],
		[AACreatedUser],
		[AAUpdatedDate],
		[AAUpdatedUser],
		[AAStatus],
		[FK_APBillOfLadingID],
		[APBillOfLadingItemProductDesc],
		[FK_ICProductID],
		[APBillOfLadingItemHSCode],
		[APBillOfLadingItemProductQty],
		[FK_ICMeasureUnitID],
		[APBillOfLadingItemProductUnitCost],
		[APBillOfLadingItemProductUnitCostExchange],
		[APBillOfLadingItemTotalCost],
		[APBillOfLadingItemTotalCostExchange],
		[APBillOfLadingItemImportTaxPercent],
		[APBillOfLadingItemImportTaxAmount],
		[APBillOfLadingItemConsumptionTaxPercent],
		[APBillOfLadingItemConsumptionTaxAmount],
		[APBillOfLadingItemEnviromentTaxPercent],
		[APBillOfLadingItemEnviromentTaxAmount],
		[APBillOfLadingItemVATTaxPercent],
		[APBillOfLadingItemVATTaxAmount],
		[APBillOfLadingItemTotalTaxAmount],
		[APBillOfLadingItemDOFee],
		[APBillOfLadingItemCleaningContFee]
	) VALUES ( 
		0,
		NULL,
		'',
		NULL,
		'',
		'Dummy',
		0,
		'',
		0,
		'',
		0.0,
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
		0.0,
		0.0,
		0.0,
		0.0,
		0.0
	)
	SET IDENTITY_INSERT APBillOfLadingItems OFF 
END
------------
IF (SELECT COUNT(1) FROM dbo.APBillOfLadings WHERE APBillOfLadingID = 0) = 0
BEGIN
	SET IDENTITY_INSERT APBillOfLadings ON 
	INSERT INTO [dbo].[APBillOfLadings](
		[APBillOfLadingID],
		[AACreatedDate],
		[AACreatedUser],
		[AAUpdatedDate],
		[AAUpdatedUser],
		[AAStatus],
		[APBillOfLadingReference],
		[APBillOfLadingDeclarationNo],
		[APBillOfLadingDeclarationNumber],
		[APBillOfLadingRegisDate],
		[APBillOfLadingType],
		[APBillOfLadingNo],
		[APBillOfLadingDate],
		[APBillOfLadingStatus],
		[FK_ACObjectID],
		[APObjectType],
		[APBillOfLadingContractNo],
		[APBillOfLadingContractDate],
		[APBillOfLadingTaxNumber],
		[APBillOfLadingSupplierNo],
		[APBillOfLadingVATDate],
		[FK_GEPaymentTermID],
		[FK_GECurrencyID],
		[APBillOfLadingExchangeRate],
		[APBillOfLadingDesc],
		[FK_APInvoiceInID],
		[FK_ARInvoiceID],
		[FK_BRBranchID],
		[APBillOfLadingImportTaxPercent],
		[APBillOfLadingConsumptionTaxPercent],
		[APBillOfLadingEnviromentTaxPercent],
		[APBillOfLadingVATTaxPercent],
		[APBillOfLadingClearanceDate],
		[APBillOfLadingImportExportType],
		[APBillOfLadingBOLDate],
		[STToolbarActionName],
		[APBillOfLadingPostedStatus]
	) VALUES ( 
		0,
		NULL,
		'',
		NULL,
		'',
		'Dummy',
		'',
		'',
		'',
		'9999/12/31',
		'',
		'',
		NULL,
		'',
		0,
		'',
		'',
		NULL,
		'',
		'',
		NULL,
		0,
		0,
		0.0,
		'',
		0,
		0,
		0,
		0.0,
		0.0,
		0.0,
		0.0,
		NULL,
		'',
		NULL,
		'',
		''
	)
	SET IDENTITY_INSERT APBillOfLadings OFF 
END


INSERT INTO dbo.ACEntryTypes
VALUES
(   'Alive',        -- AAStatus - varchar(50)
    GETDATE(), -- AACreatedDate - datetime
    N'Admin',       -- AACreatedUser - nvarchar(50)
    GETDATE(), -- AAUpdatedDate - datetime
    N'Admin',       -- AAUpdatedUser - nvarchar(50)
    N'ThueXNK',       -- ACEntryTypeName - nvarchar(100)
    N'Thuế Xuất/Nhập khẩu'        -- ACEntryTypeDesc - nvarchar(512)
    )
INSERT INTO dbo.ACEntryTypes
VALUES
(   'Alive',        -- AAStatus - varchar(50)
    GETDATE(), -- AACreatedDate - datetime
    N'Admin',       -- AACreatedUser - nvarchar(50)
    GETDATE(), -- AAUpdatedDate - datetime
    N'Admin',       -- AAUpdatedUser - nvarchar(50)
    N'ThueTieuThu',       -- ACEntryTypeName - nvarchar(100)
    N'Thuế tiêu thụ đặc biệt'        -- ACEntryTypeDesc - nvarchar(512)
    )
INSERT INTO dbo.ACEntryTypes
VALUES
(   'Alive',        -- AAStatus - varchar(50)
    GETDATE(), -- AACreatedDate - datetime
    N'Admin',       -- AACreatedUser - nvarchar(50)
    GETDATE(), -- AAUpdatedDate - datetime
    N'Admin',       -- AAUpdatedUser - nvarchar(50)
    N'ThueBaoVeMoiTruong',       -- ACEntryTypeName - nvarchar(100)
    N'Thuế bảo vệ môi trường'        -- ACEntryTypeDesc - nvarchar(512)
    )

-------------
INSERT INTO dbo.ACDocTypeEntrys
VALUES
(   'Alive', -- AAStatus - varchar(50)
    (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon'),  -- FK_ACDocumentTypeID - int
    (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueXNK'),  -- FK_ACEntryTypeID - int
    4   -- ACDocTypeEntrySortOrder - int
    )
INSERT INTO dbo.ACDocTypeEntrys
VALUES
(   'Alive', -- AAStatus - varchar(50)
    (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon'),  -- FK_ACDocumentTypeID - int
    (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueTieuThu'),  -- FK_ACEntryTypeID - int
    5   -- ACDocTypeEntrySortOrder - int
    )
INSERT INTO dbo.ACDocTypeEntrys
VALUES
(   'Alive', -- AAStatus - varchar(50)
    (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon'),  -- FK_ACDocumentTypeID - int
    (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueBaoVeMoiTruong'),  -- FK_ACEntryTypeID - int
    6   -- ACDocTypeEntrySortOrder - int
    )
--------------------------------------
INSERT INTO dbo.ACDocTypeEntryAccounts
VALUES
(   'Alive',  -- AAStatus - varchar(50)
    (SELECT ACDocTypeEntryID FROM  dbo.ACDocTypeEntrys WHERE FK_ACDocumentTypeID = (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon') AND FK_ACEntryTypeID = (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueXNK')),   -- FK_ACDocTypeEntryID - int
    (SELECT ACAccountID FROM  dbo.ACAccounts WHERE ACAccountNo = '151'),   -- FK_ACAccountID - int
    'Credit',  -- ACPostingType - varchar(50)
    1 -- IsDefault - bit
    )
INSERT INTO dbo.ACDocTypeEntryAccounts
VALUES
(   'Alive',  -- AAStatus - varchar(50)
    (SELECT ACDocTypeEntryID FROM  dbo.ACDocTypeEntrys WHERE FK_ACDocumentTypeID = (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon') AND FK_ACEntryTypeID = (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueXNK')),   -- FK_ACDocTypeEntryID - int
    0,   -- FK_ACAccountID - int
    'Debit',  -- ACPostingType - varchar(50)
    0 -- IsDefault - bit
    )
INSERT INTO dbo.ACDocTypeEntryAccounts
VALUES
(   'Alive',  -- AAStatus - varchar(50)
    (SELECT ACDocTypeEntryID FROM  dbo.ACDocTypeEntrys WHERE FK_ACDocumentTypeID = (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon') AND FK_ACEntryTypeID = (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueTieuThu')),   -- FK_ACDocTypeEntryID - int
    (SELECT ACAccountID FROM  dbo.ACAccounts WHERE ACAccountNo = '151'),   -- FK_ACAccountID - int
    'Credit',  -- ACPostingType - varchar(50)
    1 -- IsDefault - bit
    )
INSERT INTO dbo.ACDocTypeEntryAccounts
VALUES
(   'Alive',  -- AAStatus - varchar(50)
    (SELECT ACDocTypeEntryID FROM  dbo.ACDocTypeEntrys WHERE FK_ACDocumentTypeID = (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon') AND FK_ACEntryTypeID = (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueTieuThu')),   -- FK_ACDocTypeEntryID - int
    0,   -- FK_ACAccountID - int
    'Debit',  -- ACPostingType - varchar(50)
    0 -- IsDefault - bit
    )
INSERT INTO dbo.ACDocTypeEntryAccounts
VALUES
(   'Alive',  -- AAStatus - varchar(50)
    (SELECT ACDocTypeEntryID FROM  dbo.ACDocTypeEntrys WHERE FK_ACDocumentTypeID = (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon') AND FK_ACEntryTypeID = (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueBaoVeMoiTruong')),   -- FK_ACDocTypeEntryID - int
    (SELECT ACAccountID FROM  dbo.ACAccounts WHERE ACAccountNo = '151'),   -- FK_ACAccountID - int
    'Credit',  -- ACPostingType - varchar(50)
    1 -- IsDefault - bit
    )
INSERT INTO dbo.ACDocTypeEntryAccounts
VALUES
(   'Alive',  -- AAStatus - varchar(50)
    (SELECT ACDocTypeEntryID FROM  dbo.ACDocTypeEntrys WHERE FK_ACDocumentTypeID = (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon') AND FK_ACEntryTypeID = (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueBaoVeMoiTruong')),   -- FK_ACDocTypeEntryID - int
    0,   -- FK_ACAccountID - int
    'Debit',  -- ACPostingType - varchar(50)
    0 -- IsDefault - bit
    )

----------------------------------------------
INSERT INTO dbo.ACDocTypeEntryFunctionMappings
VALUES
(   N'Alive', -- AAStatus - nvarchar(50)
    (SELECT STModuleID FROM  STModules WHERE STModuleName = 'PurchaseReceipt'),   -- FK_STModuleID - int
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'PurchaseReceipt') AND STToolbarTag = 'FromInvoice'),   -- FK_STToolbarID - int
    (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon'),   -- FK_ACDocumentTypeID - int
    (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueXNK')    -- FK_ACEntryTypeID - int
    )
INSERT INTO dbo.ACDocTypeEntryFunctionMappings
VALUES
(   N'Alive', -- AAStatus - nvarchar(50)
    (SELECT STModuleID FROM  STModules WHERE STModuleName = 'PurchaseReceipt'),   -- FK_STModuleID - int
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'PurchaseReceipt') AND STToolbarTag = 'FromInvoice'),   -- FK_STToolbarID - int
    (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon'),   -- FK_ACDocumentTypeID - int
    (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueTieuThu')    -- FK_ACEntryTypeID - int
    )
INSERT INTO dbo.ACDocTypeEntryFunctionMappings
VALUES
(   N'Alive', -- AAStatus - nvarchar(50)
    (SELECT STModuleID FROM  STModules WHERE STModuleName = 'PurchaseReceipt'),   -- FK_STModuleID - int
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'PurchaseReceipt') AND STToolbarTag = 'FromInvoice'),   -- FK_STToolbarID - int
    (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHangHoaDon'),   -- FK_ACDocumentTypeID - int
    (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ThueBaoVeMoiTruong')    -- FK_ACEntryTypeID - int
    )

--SELECT * FROM dbo.ADConfigValues WHERE ADConfigKeyGroup = 'DocumentAllocationCriteria'

UPDATE ADConfigValues SET IsActive = 0 WHERE ADConfigKeyGroup = 'DocumentAllocationCriteria' AND  ADConfigKey  = 'DocumentAllocationCriteriaQty'
--SELECT * FROM dbo.AAColumnAlias WHERE AATableName = 'ACDocuments'
INSERT INTO dbo.AAColumnAlias
select   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACDocumentStatus',   -- AAColumnAliasName - varchar(255)
    N'Tình trạng',  -- AAColumnAliasCaption - nvarchar(255)
    'ACDocuments',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    0, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
    

INSERT INTO dbo.ADConfigValues
SELECT 
   'Alive',  -- AAStatus - varchar(10)
    N'DocumentStatusNew', -- ADConfigKey - nvarchar(100)
    N'New', -- ADConfigKeyValue - nvarchar(100)
    N'Tạo mới', -- ADConfigText - nvarchar(1000)
    N'DocumentStatusNew', -- ADConfigKeyDesc - nvarchar(500)
    N'DocumentStatus', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
    
INSERT INTO dbo.ADConfigValues
SELECT 
   'Alive',  -- AAStatus - varchar(10)
    N'DocumentStatusComplete', -- ADConfigKey - nvarchar(100)
    N'Complete', -- ADConfigKeyValue - nvarchar(100)
    N'Hoàn tất', -- ADConfigText - nvarchar(1000)
    N'DocumentStatusComplete', -- ADConfigKeyDesc - nvarchar(500)
    N'DocumentStatus', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit

	--SELECT * FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'FeePayment')
	--SELECT * FROM dbo.STToolbarFunctions WHERE STToolbarID = 3337
	INSERT INTO dbo.STToolbars
	SELECT   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'FeePayment'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnComplete',  -- STToolbarName - nvarchar(50)
    N'Hoàn tất',  -- STToolbarDesc - nvarchar(255)
    'Complete',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Hoàn tất (F9)',  -- STToolbarCaption - nvarchar(50)
    N'Action',  -- STToolbarGroup - nvarchar(50)
    8,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    0,    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)

	INSERT INTO dbo.STToolbars
	SELECT   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'FeePayment'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnAllotment',  -- STToolbarName - nvarchar(50)
    N'Chạy phân bổ',  -- STToolbarDesc - nvarchar(255)
    'Allotment',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Chạy phân bổ',  -- STToolbarCaption - nvarchar(50)
    N'Action',  -- STToolbarGroup - nvarchar(50)
    9,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    0,    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)

INSERT INTO dbo.STToolbarFunctions
	select  '', -- STToolbarFunctionIDString - varchar(50)
	    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'FeePayment') AND STToolbarName = 'fld_barbtnAllotment'),  -- STToolbarID - int
	    'ActionAllotment', -- STToolbarFunctionName - varchar(250)
	    'void ActionAllotment()', -- STToolbarFunctionFullName - varchar(500)
	    'BOSERP.Modules.FeePayment.FeePaymentModule', -- STToolbarFunctionClass - varchar(250)
	    1   -- STToolbarFunctionSortOrder - int

--update dbo.AAColumnAlias SET AADisplayedMember  ='ICFeeConfigName,ICFeeType' WHERE AATableName = 'APFeePaymentFeeConfigs' AND AAColumnAliasName = 'FK_ICFeeConfigIwrD'
INSERT INTO dbo.ACDocTypeEntrys
VALUES
(   'Alive', -- AAStatus - varchar(50)
    (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHang'),  -- FK_ACDocumentTypeID - int
    (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ChiPhiMuaHang'),  -- FK_ACEntryTypeID - int
    3   -- ACDocTypeEntrySortOrder - int
    )

INSERT INTO dbo.ACDocTypeEntryAccounts
VALUES
(   'Alive',  -- AAStatus - varchar(50)
    (SELECT ACDocTypeEntryID FROM  dbo.ACDocTypeEntrys WHERE FK_ACDocumentTypeID = (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHang') AND FK_ACEntryTypeID = (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ChiPhiMuaHang')),   -- FK_ACDocTypeEntryID - int
    (SELECT ACAccountID FROM  dbo.ACAccounts WHERE ACAccountNo = '151'),   -- FK_ACAccountID - int
    'Credit',  -- ACPostingType - varchar(50)
    1 -- IsDefault - bit
    )
INSERT INTO dbo.ACDocTypeEntryAccounts
VALUES
(   'Alive',  -- AAStatus - varchar(50)
    (SELECT ACDocTypeEntryID FROM  dbo.ACDocTypeEntrys WHERE FK_ACDocumentTypeID = (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHang') AND FK_ACEntryTypeID = (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ChiPhiMuaHang')),   -- FK_ACDocTypeEntryID - int
    0,   -- FK_ACAccountID - int
    'Debit',  -- ACPostingType - varchar(50)
    0 -- IsDefault - bit
    )
INSERT INTO dbo.ACDocTypeEntryFunctionMappings
VALUES
(   N'Alive', -- AAStatus - nvarchar(50)
    (SELECT STModuleID FROM  STModules WHERE STModuleName = 'PurchaseReceipt'),   -- FK_STModuleID - int
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'PurchaseReceipt') AND STToolbarTag = 'FromPurchaseOrder'),   -- FK_STToolbarID - int
    (SELECT ACDocumentTypeID FROM  dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'NhapKhoMuaHang'),   -- FK_ACDocumentTypeID - int
    (SELECT ACEntryTypeID FROM  dbo.ACEntryTypes WHERE ACEntryTypeName = 'ChiPhiMuaHang')    -- FK_ACEntryTypeID - int
    )

----------
INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACDocumentAllotment',   -- AAColumnAliasName - varchar(255)
    N'Tình trạng phân bổ',  -- AAColumnAliasCaption - nvarchar(255)
    'ACDocuments',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
    )