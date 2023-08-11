GO
UPDATE dbo.STToolbars SET STToolbarOrder = STToolbarOrder + 1 
WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'batchproduct') AND AAStatus = 'Alive' 
AND STToolbarParentID = (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'batchproduct') AND AAStatus = 'Alive' AND STToolbarTag = 'ExportExcel') 
AND STToolbarTag <> 'ExportSemiProduct'
GO
INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'batchproduct'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnExportSemiProductM2',  -- STToolbarName - nvarchar(50)
    N'Xuất SemiProduct M2',  -- STToolbarDesc - nvarchar(255)
    'ExportSemiProductM2',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Xuất SemiProduct (m2)',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    1,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'batchproduct') AND AAStatus = 'Alive' AND STToolbarTag = 'ExportExcel'),    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO
INSERT INTO dbo.STToolbarFunctions
VALUES
(   '', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'batchproduct') AND AAStatus = 'Alive' AND STToolbarTag = 'ExportSemiProductM2'),  -- STToolbarID - int
    'ExportSemiProductM2', -- STToolbarFunctionName - varchar(250)
    'Void ExportSemiProductM2()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.BatchProduct.BatchProductModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
)
GO