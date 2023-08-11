IF (SELECT COUNT(1) FROM dbo.ICConversionProposals WHERE ICConversionProposalID = 0) = 0
BEGIN
	SET IDENTITY_INSERT ICConversionProposals ON 
	INSERT INTO [dbo].[ICConversionProposals](
		[ICConversionProposalID],
		[AACreatedDate],
		[AACreatedUser],
		[AAUpdatedDate],
		[AAUpdatedUser],
		[AAStatus],
		[FK_ICStockID],
		[FK_BRBranchID],
		[FK_HREmployeeID],
		[ICConversionProposalNo],
		[ICConversionProposalName],
		[ICConversionProposalDesc],
		[ICConversionProposalDate],
		[ICConversionProposalStatus],
		[ICConversionProposalEmployeeRecever]
	) VALUES ( 
		0,
		NULL,
		'',
		NULL,
		'',
		'',
		0,
		0,
		0,
		'',
		'',
		'',
		NULL,
		'',
		''
	)
	SET IDENTITY_INSERT ICConversionProposals OFF 
END
IF (SELECT COUNT(1) FROM dbo.ICConversionProposalItems WHERE ICConversionProposalItemID = 0) = 0
BEGIN
	SET IDENTITY_INSERT ICConversionProposalItems ON 
	INSERT INTO [dbo].[ICConversionProposalItems](
		[ICConversionProposalItemID],
		[AAStatus],
		[FK_ICConversionProposalID],
		[FK_ICDepartmentID],
		[FK_ICProductGroupID],
		[FK_ICProductID],
		[FK_ICProductSerieID],
		[FK_ICStockID],
		[FK_ICMeasureUnitID],
		[ICConversionProposalItemSortOrder],
		[ICConversionProposalItemProductType],
		[ICConversionProposalItemProductNo],
		[ICConversionProposalItemProductName],
		[ICConversionProposalItemProductDesc],
		[ICConversionProposalItemProductNoOfOldSys],
		[ICConversionProposalItemProductSerialNo],
		[ICConversionProposalItemProductLotNo],
		[ICConversionProposalItemSupplierName],
		[ICConversionProposalItemProductQty],
		[ICConversionProposalItemWoodQty],
		[ICConversionProposalItemComment],
		[ICConversionProposalItemLocation],
		[ICConversionProposalItemProductHeight],
		[ICConversionProposalItemProductWidth],
		[ICConversionProposalItemProductLength]
	) VALUES ( 
		0,
		'',
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		'',
		'',
		'',
		'',
		'',
		'',
		'',
		'',
		0.0,
		0.0,
		'',
		'',
		0.0,
		0.0,
		0.0
	)
	SET IDENTITY_INSERT ICConversionProposalItems OFF 
END

INSERT INTO dbo.STModules
VALUES
(   'Alive', -- AAStatus - varchar(50)
    'ConversionProposal', -- STModuleName - varchar(50)
    'PCP', -- STModuleCode - varchar(20)
    1,  -- STModuleMain - int
    1,  -- IsVisible - int
    N'OnlyERP' -- STModuleViewType - nvarchar(50)
)
GO

INSERT INTO dbo.STModuleDescriptions
VALUES
(   (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'ConversionProposal'),  -- STModuleID - int
    1,  -- STLanguageID - int
    N'Đề nghị chuyển mã' -- STModuleDescriptionDescription - nvarchar(255)
)
GO

INSERT INTO dbo.STScreens 
VALUES
(   'DMPCP100',   -- STScreenNumber - varchar(100)
    N'Thông tin',  -- STScreenText - nvarchar(255)
    'guiConversionProposal',   -- STScreenName - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'ConversionProposal'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    0,    -- STScreenBackColor - int
    0,    -- STScreenForeColor - int
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
    0,    -- STScreenSortOrder - int
    N'',  -- STScreenPrivilege - nvarchar(50)
    1  -- STScreenVisible - bit
)
GO

INSERT INTO dbo.STScreens 
VALUES
(   'SMPCP100',   -- STScreenNumber - varchar(100)
    N'Tìm kiếm',  -- STScreenText - nvarchar(255)
    'guiSearchConversionProposal',   -- STScreenName - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'ConversionProposal'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    0,    -- STScreenBackColor - int
    0,    -- STScreenForeColor - int
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
    0,    -- STScreenSortOrder - int
    N'',  -- STScreenPrivilege - nvarchar(50)
    1  -- STScreenVisible - bit
)
GO

INSERT INTO dbo.GENumbering
VALUES
(   N'Admin',       -- AACreatedUser - nvarchar(50)
    GETDATE(), -- AACreatedDate - datetime
    N'',       -- AAUpdatedUser - nvarchar(50)
    GETDATE(), -- AAUpdatedDate - datetime
    'Alive',        -- AAStatus - varchar(10)
    N'ConversionProposal',       -- GENumberingName - nvarchar(50)
    N'DNCM-',       -- GENumberingPrefix - nvarchar(50)
    6,         -- GENumberingLength - int
    1,         -- GENumberingStart - int
    N'Đề nghị chuyển mã',       -- GENumberingDesc - nvarchar(255)
    (SELECT TOP 1 BRBranchID FROM dbo.BRBranchs WHERE AAStatus = 'Alive' ORDER BY BRBranchID),         -- FK_BRBranchID - int
    1,      -- GENumberingPrefixHaveYear - bit
    1,      -- GENumberingPrefixHaveMonth - bit
    0,      -- GENumberingPrefixHaveDay - bit
    0,      -- GENumberingPrefixHaveStock - bit
    0,      -- GENumberingPrefixHaveBankAbbreviation - bit
    N'{1}{2}.{3}.{7}'        -- GENumberingFormat - nvarchar(50)
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'ConversionProposalStatusNew', -- ADConfigKey - nvarchar(100)
    N'New', -- ADConfigKeyValue - nvarchar(100)
    N'Tạo mới', -- ADConfigText - nvarchar(1000)
    N'Tạo mới', -- ADConfigKeyDesc - nvarchar(500)
    N'ConversionProposalStatus', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'ConversionProposalStatusCompleted', -- ADConfigKey - nvarchar(100)
    N'Completed', -- ADConfigKeyValue - nvarchar(100)
    N'Hoàn tất', -- ADConfigText - nvarchar(1000)
    N'Hoàn tất', -- ADConfigKeyDesc - nvarchar(500)
    N'ConversionProposalStatus', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO STToolbars VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ConversionProposal'), 1,N'fld_barbtnNew',N'Tạo mới (F4)',N'New',N'Default',N'Tạo mới (F4)',N'Action',0,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ConversionProposal') AND STToolbarTag = ''),0),N'')
INSERT INTO STToolbars VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ConversionProposal'), 1,N'fld_barbtnEdit',N'Sửa (F5)',N'Edit',N'Default',N'Sửa (F5)',N'Action',1,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ConversionProposal') AND STToolbarTag = ''),0),N'')
INSERT INTO STToolbars VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ConversionProposal'), 1,N'fld_barbtnCancel',N'Hủy',N'Cancel',N'Default',N'Hủy (F7)',N'Action',2,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ConversionProposal') AND STToolbarTag = ''),0),N'')
INSERT INTO STToolbars VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ConversionProposal'), 1,N'fld_barbtnSave',N'Lưu',N'Save',N'Default',N'Lưu (F8)',N'Action',3,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ConversionProposal') AND STToolbarTag = ''),0),N'')
INSERT INTO STToolbars VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ConversionProposal'), 1,N'fld_barbtnComplete',N'Hoàn tất (F9)',N'Complete',N'Default',N'Hoàn tất',N'Action',4,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ConversionProposal') AND STToolbarTag = ''),0),N'')
INSERT INTO STToolbars VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ConversionProposal'), 1,N'fld_barbtnCancelComplete',N'Mở chứng từ',N'CancelComplete',N'Default',N'Mở chứng từ',N'Action',5,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ConversionProposal') AND STToolbarTag = ''),0),N'')
--INSERT INTO STToolbars VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ConversionProposal'), 1,N'fld_barbtnPrint',N'In',N'Print',N'Default',N'In',N'Utility',1,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ConversionProposal') AND STToolbarTag = ''),0),N'')
--INSERT INTO dbo.STToolbarFunctions VALUES   ('',(SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'ConversionProposal') AND STToolbarTag = 'Print'),'ActionPrintTemplate','Void ActionPrintTemplate()','BOSERP.Modules.ConversionProposal.ConversionProposalModule',1)

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ICConversionProposalNo',   -- AAColumnAliasName - varchar(255)
    N'Mã chứng từ',  -- AAColumnAliasCaption - nvarchar(255)
    'ICConversionProposals',   -- AATableName - varchar(50)
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
    'ICConversionProposalDesc',   -- AAColumnAliasName - varchar(255)
    N'Diễn giải',  -- AAColumnAliasCaption - nvarchar(255)
    'ICConversionProposals',   -- AATableName - varchar(50)
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
    'ICConversionProposalDate',   -- AAColumnAliasName - varchar(255)
    N'Ngày chứng từ',  -- AAColumnAliasCaption - nvarchar(255)
    'ICConversionProposals',   -- AATableName - varchar(50)
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
    'ICConversionProposalStatus',   -- AAColumnAliasName - varchar(255)
    N'Tình trạng',  -- AAColumnAliasCaption - nvarchar(255)
    'ICConversionProposals',   -- AATableName - varchar(50)
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
    'ICConversionProposalEmployeeRecever',   -- AAColumnAliasName - varchar(255)
    N'Người nhận',  -- AAColumnAliasCaption - nvarchar(255)
    'ICConversionProposals',   -- AATableName - varchar(50)
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
    'FK_ICStockID',   -- AAColumnAliasName - varchar(255)
    N'Kho',  -- AAColumnAliasCaption - nvarchar(255)
    'ICConversionProposals',   -- AATableName - varchar(50)
    'ICStocks',   -- AAReferenceTable - varchar(512)
    'ICStockName',   -- AADisplayedMember - varchar(512)
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
    'ICConversionProposalItemProductNo',   -- AAColumnAliasName - varchar(255)
    N'Mã sản phẩm',  -- AAColumnAliasCaption - nvarchar(255)
    'ICConversionProposalItems',   -- AATableName - varchar(50)
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
    'ICConversionProposalItemProductName',   -- AAColumnAliasName - varchar(255)
    N'Tên sản phẩm',  -- AAColumnAliasCaption - nvarchar(255)
    'ICConversionProposalItems',   -- AATableName - varchar(50)
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
    'ICConversionProposalItemProductDesc',   -- AAColumnAliasName - varchar(255)
    N'Mô tả',  -- AAColumnAliasCaption - nvarchar(255)
    'ICConversionProposalItems',   -- AATableName - varchar(50)
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
    'FK_ICMeasureUnitID',   -- AAColumnAliasName - varchar(255)
    N'Đơn vị tính',  -- AAColumnAliasCaption - nvarchar(255)
    'ICConversionProposalItems',   -- AATableName - varchar(50)
    'ICMeasureUnits',   -- AAReferenceTable - varchar(512)
    'ICMeasureUnitName',   -- AADisplayedMember - varchar(512)
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
    'ICConversionProposalItemProductHeight',   -- AAColumnAliasName - varchar(255)
    N'Dày (mm)',  -- AAColumnAliasCaption - nvarchar(255)
    'ICConversionProposalItems',   -- AATableName - varchar(50)
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
    'ICConversionProposalItemProductWidth',   -- AAColumnAliasName - varchar(255)
    N'Rộng (mm)',  -- AAColumnAliasCaption - nvarchar(255)
    'ICConversionProposalItems',   -- AATableName - varchar(50)
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
    'ICConversionProposalItemProductLength',   -- AAColumnAliasName - varchar(255)
    N'Dài (mm)',  -- AAColumnAliasCaption - nvarchar(255)
    'ICConversionProposalItems',   -- AATableName - varchar(50)
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
    'FK_ICStockID',   -- AAColumnAliasName - varchar(255)
    N'Kho',  -- AAColumnAliasCaption - nvarchar(255)
    'ICConversionProposalItems',   -- AATableName - varchar(50)
    'ICStocks',   -- AAReferenceTable - varchar(512)
    'ICStockName',   -- AADisplayedMember - varchar(512)
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
    'ICConversionProposalItemProductLotNo',   -- AAColumnAliasName - varchar(255)
    N'Mã lô hàng',  -- AAColumnAliasCaption - nvarchar(255)
    'ICConversionProposalItems',   -- AATableName - varchar(50)
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
    'ICConversionProposalItemProductSerialNo',   -- AAColumnAliasName - varchar(255)
    N'Mã kiện',  -- AAColumnAliasCaption - nvarchar(255)
    'ICConversionProposalItems',   -- AATableName - varchar(50)
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
    'ICConversionProposalItemSupplierName',   -- AAColumnAliasName - varchar(255)
    N'Nhà cung cấp',  -- AAColumnAliasCaption - nvarchar(255)
    'ICConversionProposalItems',   -- AATableName - varchar(50)
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
    'ICConversionProposalItemProductQty',   -- AAColumnAliasName - varchar(255)
    N'Số lượng/ Khối lượng',  -- AAColumnAliasCaption - nvarchar(255)
    'ICConversionProposalItems',   -- AATableName - varchar(50)
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
    'ICConversionProposalItemWoodQty',   -- AAColumnAliasName - varchar(255)
    N'Số thanh tấm',  -- AAColumnAliasCaption - nvarchar(255)
    'ICConversionProposalItems',   -- AATableName - varchar(50)
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
    'ICConversionProposalItemComment',   -- AAColumnAliasName - varchar(255)
    N'Ghi chú',  -- AAColumnAliasCaption - nvarchar(255)
    'ICConversionProposalItems',   -- AATableName - varchar(50)
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
    'ICConversionProposalItemLocation',   -- AAColumnAliasName - varchar(255)
    N'Vị trí',  -- AAColumnAliasCaption - nvarchar(255)
    'ICConversionProposalItems',   -- AATableName - varchar(50)
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
(   'ConversionProposal', -- STFieldFormatModuleName - varchar(50)
    'ICConversionProposalItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ICConversionProposalItemProductHeight'  -- STFieldFormatColumnName - varchar(100)
)
GO
INSERT INTO dbo.STFieldFormats
VALUES
(   'ConversionProposal', -- STFieldFormatModuleName - varchar(50)
    'ICConversionProposalItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ICConversionProposalItemProductWidth'  -- STFieldFormatColumnName - varchar(100)
)
GO
INSERT INTO dbo.STFieldFormats
VALUES
(   'ConversionProposal', -- STFieldFormatModuleName - varchar(50)
    'ICConversionProposalItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ICConversionProposalItemProductLength'  -- STFieldFormatColumnName - varchar(100)
)
GO
INSERT INTO dbo.STFieldFormats
VALUES
(   'ConversionProposal', -- STFieldFormatModuleName - varchar(50)
    'ICConversionProposalItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN6'),  -- STFieldFormatGroupID - int
    'ICConversionProposalItemProductQty'  -- STFieldFormatColumnName - varchar(100)
)
GO
INSERT INTO dbo.STFieldFormats
VALUES
(   'ConversionProposal', -- STFieldFormatModuleName - varchar(50)
    'ICConversionProposalItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN6'),  -- STFieldFormatGroupID - int
    'ICConversionProposalItemWoodQty'  -- STFieldFormatColumnName - varchar(100)
)
GO
-- Delete
DELETE STToolbarFunctions WHERE STToolbarID in (select FK_STToolbarID From ADTemplates a Join ADTemplateToolbars b On a.ADTemplateID = b.FK_ADTemplateID Where ADTemplateNo = 'RP_PrintConversionProposal')
DELETE STToolbars WHERE STToolbarID in (select FK_STToolbarID From ADTemplateToolbars a Join ADTemplates b On a.FK_ADTemplateID = b.ADTemplateID Where ADTemplateNo = 'RP_PrintConversionProposal')
DELETE ADTemplateToolbars WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PrintConversionProposal')
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_PrintConversionProposal')
DELETE ADTemplates WHERE ADTemplateNo = 'RP_PrintConversionProposal'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_PrintConversionProposal',N'Đề nghị chuyển mã',N'Đề nghị chuyển mã',N'RP_PrintConversionProposal',N'Alive',N'',1
INSERT INTO STToolbars (AAStatus,STModuleID,STUserGroupID,STToolbarName,STToolbarDesc,STToolbarTag,STToolbarStyle,STToolbarCaption,STToolbarGroup,STToolbarOrder,STToolbarVisible,STToolbarPrivilege,STToolbarParentID,STToolbarImage) SELECT N'Alive',1379,1,N'fld_barbtnPrint',N'In',N'Print',N'Default',N'In',N'Utility',1,1,N'',0,N''
INSERT INTO ADTemplateToolbars (FK_ADTemplateID,FK_STToolbarID) SELECT (Select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PrintConversionProposal'),(select MAX(STToolbarID) From STToolbars)
INSERT INTO STToolbarFunctions (STToolbarFunctionIDString,STToolbarID,STToolbarFunctionName,STToolbarFunctionFullName,STToolbarFunctionClass,STToolbarFunctionSortOrder) SELECT N'',(select MAX(STToolbarID) From STToolbars),N'ActionPrintTemplate',N'Void ActionPrintTemplate()',N'BOSERP.Modules.ConversionProposal.ConversionProposalModule',1
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'RP_PrintConversionProposal') DROP PROCEDURE RP_PrintConversionProposal
GO
CREATE PROCEDURE [dbo].[RP_PrintConversionProposal]
	@STModuleName	VARCHAR(50), 
	@ConversionProposalID		INT
AS
BEGIN	
	SET NOCOUNT ON;

    SELECT	si.ICConversionProposalItemProductNo	AS MaSanPham
		,	si.ICConversionProposalItemProductName	AS TenSanPham
		,	si.ICConversionProposalItemProductDesc	AS MoTa
		,	si.ICConversionProposalItemProductSerialNo	AS MaKien
		,	si.ICConversionProposalItemProductLotNo		AS MaLo
		,	RTRIM(LTRIM(FORMAT(si.ICConversionProposalItemProductHeight, '### ### ### ##0.0##')))
			+ ' x ' + RTRIM(LTRIM(FORMAT(si.ICConversionProposalItemProductWidth, '### ### ### ##0.0##')))
			+ ' x ' + RTRIM(LTRIM(FORMAT(si.ICConversionProposalItemProductLength, '### ### ### ##0.0##'))) AS QuyCach
		,	si.ICConversionProposalItemSupplierName		AS NhaCungCap
		,	RTRIM(LTRIM(FORMAT(si.ICConversionProposalItemProductQty, '### ### ### ##0.0#####')))	AS SoLuong
		,	RTRIM(LTRIM(FORMAT(si.ICConversionProposalItemWoodQty, '### ### ### ##0.0#####')))		AS SoThanh
		,	si.ICConversionProposalItemLocation	AS ViTri
		,	si.ICConversionProposalItemComment	AS GhiChu
    FROM	[dbo].[ICConversionProposalItems] si (NOLOCK)
    WHERE	si.AAStatus = 'Alive' 
    AND		si.FK_ICConversionProposalID = @ConversionProposalID
	
	SELECT	s.ICConversionProposalNo				AS MaChungTu
		,	s.ICConversionProposalDesc				AS DienGiai
		,	s.ICConversionProposalEmployeeRecever	AS NguoiNhan
		,	ISNULL(k.ICStockName, '')				AS Kho
		,	ISNULL(h.HREmployeeName, '')			AS NguoiLapPhieu
		,	N'Ngày ' + FORMAT(s.ICConversionProposalDate, 'dd')
			+ N' tháng ' + FORMAT(s.ICConversionProposalDate, 'MM')
			+ N' năm ' + FORMAT(s.ICConversionProposalDate, 'yyyy') AS NgayChungTu
    FROM [dbo].[ICConversionProposals] s	(NOLOCK)
	LEFT JOIN dbo.ICStocks k (NOLOCK) ON k.AAStatus = 'Alive' AND k.ICStockID = s.FK_ICStockID
	LEFT JOIN dbo.HREmployees h (NOLOCK) ON h.AAStatus = 'Alive' AND h.HREmployeeID = s.FK_HREmployeeID
	WHERE s.ICConversionProposalID = @ConversionProposalID

	SELECT *
	FROM ThongTinCty(1)   
END














