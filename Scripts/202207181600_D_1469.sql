INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM  dbo.STModules WHERE STModuleName = 'Transfer'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnExportTemplate',  -- STToolbarName - nvarchar(50)
    N'Export Template',  -- STToolbarDesc - nvarchar(255)
    'ExportTemplate',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Export Template',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    (SELECT MAX(STToolbarOrder) + 1 FROM  dbo.STToolbars WHERE AAStatus = 'Alive' AND STModuleID = (SELECT STModuleID FROM  dbo.STModules WHERE STModuleName = 'Transfer' AND STToolbarGroup = 'Utility')),    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    0,    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

INSERT INTO dbo.STToolbarFunctions
VALUES
(   '', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM  dbo.STModules WHERE STModuleName = 'Transfer') AND STToolbarName = 'fld_barbtnExportTemplate'),  -- STToolbarID - int
    'ExportPriceSheetTemplate', -- STToolbarFunctionName - varchar(250)
    'Void ExportPriceSheetTemplate()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.Transfer.TransferModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
)
GO

