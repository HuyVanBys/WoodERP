-----ĐÃ CHẠY DB TEST-----
INSERT INTO dbo.STModules
VALUES
(   'Alive', -- AAStatus - varchar(50)
    'RetailVAT', -- STModuleName - varchar(50)
    'RVAT', -- STModuleCode - varchar(20)
    0,  -- STModuleMain - int
    1,  -- IsVisible - int
    N'OnlyERP' -- STModuleViewType - nvarchar(50)
)
GO

INSERT INTO dbo.STModuleDescriptions
VALUES
(   (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive' AND STModuleName = 'RetailVAT'),  -- STModuleID - int
    1,  -- STLanguageID - int
    N'Hóa đơn cho Bán lẻ' -- STModuleDescriptionDescription - nvarchar(255)
)
GO

INSERT INTO dbo.STScreens
VALUES
(   'DMRVAT100',   -- STScreenNumber - varchar(100)
    N'Thông tin',  -- STScreenText - nvarchar(255)
    'guiRetailVAT',   -- STScreenName - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive' AND STModuleName = 'RetailVAT'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    -1838594,    -- STScreenBackColor - int
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
    0,    -- STScreenSortOrder - int
    N'',  -- STScreenPrivilege - nvarchar(50)
    1  -- STScreenVisible - bit
)
GO

INSERT INTO dbo.STScreens
VALUES
(   'SMRVAT100',   -- STScreenNumber - varchar(100)
    N'Tìm kiếm',  -- STScreenText - nvarchar(255)
    'guiRetailVATSearch',   -- STScreenName - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive' AND STModuleName = 'RetailVAT'),    -- STModuleID - int
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
    0,    -- STScreenSortOrder - int
    N'',  -- STScreenPrivilege - nvarchar(50)
    1  -- STScreenVisible - bit
)
GO

INSERT INTO STToolbars VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'RetailVAT'), 1,N'fld_barbtnNew',N'Tạo mới',N'New',N'Default',N'Tạo mới (F4)',N'Action',0,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'RetailVAT') AND STToolbarTag = ''),0),N'')
INSERT INTO STToolbars VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'RetailVAT'), 1,N'fld_barbtnEdit',N'Sửa',N'Edit',N'Default',N'Sửa (F5)',N'Action',1,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'RetailVAT') AND STToolbarTag = ''),0),N'')
INSERT INTO STToolbars VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'RetailVAT'), 1,N'fld_barbtnCancel',N'Hủy',N'Cancel',N'Default',N'Hủy (F7)',N'Action',2,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'RetailVAT') AND STToolbarTag = ''),0),N'')
INSERT INTO STToolbars VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'RetailVAT'), 1,N'fld_barbtnSave',N'Lưu',N'Save',N'Default',N'Lưu (F8)',N'Action',3,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'RetailVAT') AND STToolbarTag = ''),0),N'')
INSERT INTO STToolbars VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'RetailVAT'), 1,N'fld_barbtnComplete',N'Hoàn tất',N'Complete',N'Default',N'Hoàn tất(F9)',N'Action',5,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'RetailVAT') AND STToolbarTag = ''),0),N'')
INSERT INTO STToolbars VALUES(N'Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'RetailVAT'), 1,N'fld_barbtnCancelComplete',N'Mở chứng từ',N'CancelComplete',N'Default',N'Mở chứng từ',N'Action',7,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'RetailVAT') AND STToolbarTag = ''),0),N'')

INSERT INTO dbo.STFieldFormats
VALUES
(   'RetailVAT', -- STFieldFormatModuleName - varchar(50)
    'ACRetailVATs', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ACRetailVATSubTotalAmount'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'RetailVAT', -- STFieldFormatModuleName - varchar(50)
    'ACRetailVATs', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ACRetailVATTotalAmount'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'RetailVAT', -- STFieldFormatModuleName - varchar(50)
    'ACRetailVATs', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ACRetailVATTaxAmount'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'RetailVAT', -- STFieldFormatModuleName - varchar(50)
    'ACRetailVATs', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ACRetailVATDiscountAmount'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'RetailVAT', -- STFieldFormatModuleName - varchar(50)
    'ACRetailVATs', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPercent'),  -- STFieldFormatGroupID - int
    'ACRetailVATDiscountPerCent'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'RetailVAT', -- STFieldFormatModuleName - varchar(50)
    'ACRetailVATs', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPercent'),  -- STFieldFormatGroupID - int
    'ACRetailVATTaxPercent'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'RetailVAT', -- STFieldFormatModuleName - varchar(50)
    'ACRetailVATs', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupExchangeRate'),  -- STFieldFormatGroupID - int
    'ACRetailVATExchangeRate'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'RetailVAT', -- STFieldFormatModuleName - varchar(50)
    'ACRetailVATItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ACRetailVATItemProductUnitPrice'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'RetailVAT', -- STFieldFormatModuleName - varchar(50)
    'ACRetailVATItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN5'),  -- STFieldFormatGroupID - int
    'ACRetailVATItemProductQty'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'RetailVAT', -- STFieldFormatModuleName - varchar(50)
    'ACRetailVATItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPercent'),  -- STFieldFormatGroupID - int
    'ACRetailVATItemProductDiscountPercent'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'RetailVAT', -- STFieldFormatModuleName - varchar(50)
    'ACRetailVATItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPercent'),  -- STFieldFormatGroupID - int
    'ACRetailVATItemProductTaxPercent'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'RetailVAT', -- STFieldFormatModuleName - varchar(50)
    'ACRetailVATItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ACRetailVATItemDiscountAmount'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'RetailVAT', -- STFieldFormatModuleName - varchar(50)
    'ACRetailVATItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ACRetailVATItemTaxAmount'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'RetailVAT', -- STFieldFormatModuleName - varchar(50)
    'ACRetailVATItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ACRetailVATItemTotalAmount'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'RetailVATStatusNew', -- ADConfigKey - nvarchar(100)
    N'New', -- ADConfigKeyValue - nvarchar(100)
    N'Tạo mới', -- ADConfigText - nvarchar(1000)
    N'Tạo mới', -- ADConfigKeyDesc - nvarchar(500)
    N'RetailVATStatus', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'RetailVATStatusCompleted', -- ADConfigKey - nvarchar(100)
    N'Completed', -- ADConfigKeyValue - nvarchar(100)
    N'Hoàn tất', -- ADConfigText - nvarchar(1000)
    N'Hoàn tất', -- ADConfigKeyDesc - nvarchar(500)
    N'RetailVATStatus', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'RetailVATStatusPostedVAT', -- ADConfigKey - nvarchar(100)
    N'PostedVAT', -- ADConfigKeyValue - nvarchar(100)
    N'Đã tạo Hóa đơn điện tử', -- ADConfigText - nvarchar(1000)
    N'Đã tạo Hóa đơn điện tử', -- ADConfigKeyDesc - nvarchar(500)
    N'RetailVATStatus', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.GENumbering
VALUES
(   N'Admin',       -- AACreatedUser - nvarchar(50)
    GETDATE(), -- AACreatedDate - datetime
    N'',       -- AAUpdatedUser - nvarchar(50)
    GETDATE(), -- AAUpdatedDate - datetime
    'Alive',        -- AAStatus - varchar(10)
    N'RetailVAT',       -- GENumberingName - nvarchar(50)
    N'HĐBL-',       -- GENumberingPrefix - nvarchar(50)
    5,         -- GENumberingLength - int
    1,         -- GENumberingStart - int
    N'Hóa đơn bán lẻ',       -- GENumberingDesc - nvarchar(255)
    1,         -- FK_BRBranchID - int
    1,      -- GENumberingPrefixHaveYear - bit
    1,       -- GENumberingPrefixHaveMonth - bit
	0,      -- GENumberingPrefixHaveDay - bit
    0,      -- GENumberingPrefixHaveStock - bit
    0,      -- GENumberingPrefixHaveBankAbbreviation - bit
    N'{1}{2}.{3}.{7}'        -- GENumberingFormat - nvarchar(50)
)
GO
