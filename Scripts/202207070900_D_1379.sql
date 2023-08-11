-----Đã chạy DB ERPWood_Test-----
INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'SaleReturn'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnImport',  -- STToolbarName - nvarchar(50)
    N'Import',  -- STToolbarDesc - nvarchar(255)
    'Import',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Import',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    2,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    0,    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

INSERT INTO dbo.STToolbarFunctions
VALUES
(   '0', -- STToolbarFunctionIDString - varchar(50)
    (SELECT TOP 1 STToolbarID FROM dbo.STToolbars WHERE AAStatus = 'Alive' AND STToolbarTag = 'Import' AND STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'SaleReturn')),  -- STToolbarID - int
    'ActionImportProductFromExcel', -- STToolbarFunctionName - varchar(250)
    'Void ActionImportProductFromExcel()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.SaleReturn.SaleReturnModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
)
GO

