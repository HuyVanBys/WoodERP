INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'BatchProduct'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnPrintBOMBTP',  -- STToolbarName - nvarchar(100)
    N'',  -- STToolbarDesc - nvarchar(255)
    N'PrintBOMBTP',  -- STToolbarTag - nvarchar(100)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Bảng định mức BTP',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    9,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'BatchProduct') AND STToolbarTag = 'PrintView'),    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

INSERT INTO dbo.STToolbarFunctions
VALUES
(   '0', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'BatchProduct') AND STToolbarTag = 'PrintBOMBTP'),  -- STToolbarID - int
    'ActionPrintTemplate', -- STToolbarFunctionName - varchar(250)
    'Void ActionPrintTemplate()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.BatchProduct.BatchProductModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
    )
GO
update dbo.STToolbars SET STToolbarCaption = N'ĐNSX' WHERE STToolbarCaption LIKE N'%đhsx%'
GO
