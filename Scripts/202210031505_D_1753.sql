INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM  dbo.STModules WHERE STModuleName = 'POS'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnCancelComplete',  -- STToolbarName - nvarchar(50)
    N'Mở chứng từ',  -- STToolbarDesc - nvarchar(255)
    'CancelComplete',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Mở chứng từ',  -- STToolbarCaption - nvarchar(50)
    N'Extra',  -- STToolbarGroup - nvarchar(50)
    (SELECT MAX(STToolbarOrder + 1) FROM  dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM  dbo.STModules WHERE STModuleName = 'POS') AND STToolbarGroup = 'Extra'),    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    0,    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
    )

INSERT INTO dbo.STToolbarFunctions
VALUES
(   '', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM  dbo.STModules WHERE STModuleName = 'POS') AND STToolbarTag = 'CancelComplete'),  -- STToolbarID - int
    'ActionCancelComplete', -- STToolbarFunctionName - varchar(250)
    'Void ActionCancelComplete()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.POS.POSModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
    )