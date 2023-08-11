INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM  STModules WHERE STModuleName = 'BatchProduct'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnExportGeneralMaterial',  -- STToolbarName - nvarchar(50)
    N'Xuất GeneralMaterial',  -- STToolbarDesc - nvarchar(255)
    'ExportGeneralMaterial',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Xuất GeneralMaterial',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    4,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    (SELECT STToolbarID FROM  STToolbars	WHERE STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'BatchProduct') AND STToolbarTag = 'ExportExcel' AND AAStatus = 'Alive'),    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
    )

INSERT dbo.STToolbarFunctions
VALUES
(   0, -- STToolbarFunctionIDString - varchar(50)
     (SELECT STToolbarID FROM  STToolbars	WHERE STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'BatchProduct') AND STToolbarTag = 'ExportGeneralMaterial' AND AAStatus = 'Alive'),  -- STToolbarID - int
    'ExportGeneralMaterial', -- STToolbarFunctionName - varchar(250)
    'Void ExportGeneralMaterial()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.BatchProduct.BatchProductModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
    )
