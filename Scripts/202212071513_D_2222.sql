INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PriceSheet'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnPriceSheetWithVAT',  -- STToolbarName - nvarchar(100)
    N'',  -- STToolbarDesc - nvarchar(255)
    N'PriceSheetWithVAT',  -- STToolbarTag - nvarchar(100)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Bảng giá có VAT',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    (SELECT MAX(STToolbarOrder)+1 FROM dbo.STToolbars WHERE AAStatus = 'alive' and STToolbarParentID in (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PriceSheet') AND STToolbarTag = 'Print')),    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PriceSheet') AND STToolbarTag = 'Print'),    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

INSERT INTO dbo.STToolbarFunctions
VALUES
(   '0', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PriceSheet') AND STToolbarTag = 'PriceSheetWithVAT'),  -- STToolbarID - int
    'ActionPrintTemplate', -- STToolbarFunctionName - varchar(250)
    'Void ActionPrintTemplate()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.PriceSheet.PriceSheetModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
    )
GO

INSERT INTO dbo.ADTemplates
VALUES
(   N'RP_PriceSheetWithVAT', -- ADTemplateNo - nvarchar(50)
    N'Bảng giá có VAT', -- ADTemplateName - nvarchar(100)
    N'Bảng giá có VAT', -- ADTemplateDesc - nvarchar(512)
    N'RP_PriceSheetWithVAT', -- ADTemplateStoreProc - nvarchar(256)
    'Alive',  -- AAStatus - varchar(50)
    N'RP_PriceSheetWithVAT', -- ADTemplateDataSource - nvarchar(100)
    0 -- ADTemplateAutoLoad - bit
    )
GO 

INSERT INTO dbo.ADTemplateToolbars
(
    FK_ADTemplateID,
    FK_STToolbarID
)
VALUES
(   (SELECT ADTemplateID FROM  dbo.ADTemplates WHERE ADTemplateNo = 'RP_PriceSheetWithVAT'), -- FK_ADTemplateID - int
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE AAStatus = 'Alive' AND STToolbarTag = 'PriceSheetWithVAT' AND STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'PriceSheet'))  -- FK_STToolbarID - int
    )
GO


--------------------------------------
INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PriceSheet'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnPriceSheetWithoutVAT',  -- STToolbarName - nvarchar(100)
    N'',  -- STToolbarDesc - nvarchar(255)
    N'PriceSheetWithoutVAT',  -- STToolbarTag - nvarchar(100)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Bảng giá chưa VAT',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    (SELECT MAX(STToolbarOrder)+1 FROM dbo.STToolbars WHERE AAStatus = 'alive' and STToolbarParentID in (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PriceSheet') AND STToolbarTag = 'Print')),    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PriceSheet') AND STToolbarTag = 'Print'),    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

INSERT INTO dbo.STToolbarFunctions
VALUES
(   '0', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PriceSheet') AND STToolbarTag = 'PriceSheetWithoutVAT'),  -- STToolbarID - int
    'ActionPrintTemplate', -- STToolbarFunctionName - varchar(250)
    'Void ActionPrintTemplate()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.PriceSheet.PriceSheetModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
    )
GO

INSERT INTO dbo.ADTemplates
VALUES
(   N'RP_PriceSheetWithoutVAT', -- ADTemplateNo - nvarchar(50)
    N'Bảng giá chưa VAT', -- ADTemplateName - nvarchar(100)
    N'Bảng giá chưa VAT', -- ADTemplateDesc - nvarchar(512)
    N'RP_PriceSheetWithoutVAT', -- ADTemplateStoreProc - nvarchar(256)
    'Alive',  -- AAStatus - varchar(50)
    N'RP_PriceSheetWithoutVAT', -- ADTemplateDataSource - nvarchar(100)
    0 -- ADTemplateAutoLoad - bit
    )
GO 

INSERT INTO dbo.ADTemplateToolbars
(
    FK_ADTemplateID,
    FK_STToolbarID
)
VALUES
(   (SELECT ADTemplateID FROM  dbo.ADTemplates WHERE ADTemplateNo = 'RP_PriceSheetWithoutVAT'), -- FK_ADTemplateID - int
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE AAStatus = 'Alive' AND STToolbarTag = 'PriceSheetWithoutVAT' AND STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'PriceSheet'))  -- FK_STToolbarID - int
    )
GO

--------------------------------------
INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PriceSheet'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnPriceSheetPOS',  -- STToolbarName - nvarchar(100)
    N'',  -- STToolbarDesc - nvarchar(255)
    N'PriceSheetPOS',  -- STToolbarTag - nvarchar(100)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Bảng giá khách lẻ',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    (SELECT MAX(STToolbarOrder)+1 FROM dbo.STToolbars WHERE AAStatus = 'alive' and STToolbarParentID in (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PriceSheet') AND STToolbarTag = 'Print')),    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PriceSheet') AND STToolbarTag = 'Print'),    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

INSERT INTO dbo.STToolbarFunctions
VALUES
(   '0', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PriceSheet') AND STToolbarTag = 'PriceSheetPOS'),  -- STToolbarID - int
    'ActionPrintTemplate', -- STToolbarFunctionName - varchar(250)
    'Void ActionPrintTemplate()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.PriceSheet.PriceSheetModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
    )
GO

INSERT INTO dbo.ADTemplates
VALUES
(   N'RP_PriceSheetPOS', -- ADTemplateNo - nvarchar(50)
    N'Bảng giá khách lẻ', -- ADTemplateName - nvarchar(100)
    N'Bảng giá khách lẻ', -- ADTemplateDesc - nvarchar(512)
    N'RP_PriceSheetPOS', -- ADTemplateStoreProc - nvarchar(256)
    'Alive',  -- AAStatus - varchar(50)
    N'RP_PriceSheetPOS', -- ADTemplateDataSource - nvarchar(100)
    0 -- ADTemplateAutoLoad - bit
    )
GO 

INSERT INTO dbo.ADTemplateToolbars
(
    FK_ADTemplateID,
    FK_STToolbarID
)
VALUES
(   (SELECT ADTemplateID FROM  dbo.ADTemplates WHERE ADTemplateNo = 'RP_PriceSheetPOS'), -- FK_ADTemplateID - int
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE AAStatus = 'Alive' AND STToolbarTag = 'PriceSheetPOS' AND STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'PriceSheet'))  -- FK_STToolbarID - int
    )
GO

















