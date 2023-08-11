
INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'ProductionPlanning'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnPrintLabelProductionPlanning',  -- STToolbarName - nvarchar(100)
    N'',  -- STToolbarDesc - nvarchar(255)
    N'PrintLabelProductionPlanning',  -- STToolbarTag - nvarchar(100)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Nhãn ĐCSX',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    3,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'ProductionPlanning') AND STToolbarTag = 'Print'),    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

INSERT INTO dbo.STToolbarFunctions
VALUES
(   '0', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'ProductionPlanning') AND STToolbarTag = 'PrintLabelProductionPlanning'),  -- STToolbarID - int
    'ActionPrintTemplate', -- STToolbarFunctionName - varchar(250)
    'Void ActionPrintTemplate()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.ProductionPlanning.ProductionPlanningModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
    )
GO

INSERT INTO dbo.ADTemplates
VALUES
(   N'RP_PrintLabelProductionPlanning', -- ADTemplateNo - nvarchar(50)
    N'Nhãn ĐCSX', -- ADTemplateName - nvarchar(100)
    N'Nhãn ĐCSX', -- ADTemplateDesc - nvarchar(512)
    N'RP_PrintLabelProductionPlanning', -- ADTemplateStoreProc - nvarchar(256)
    'Alive',  -- AAStatus - varchar(50)
    N'RP_PrintLabelProductionPlanning', -- ADTemplateDataSource - nvarchar(100)
    0 -- ADTemplateAutoLoad - bit
    )
GO 

INSERT INTO dbo.ADTemplateToolbars
(
    FK_ADTemplateID,
    FK_STToolbarID
)
VALUES
(   (SELECT ADTemplateID FROM  dbo.ADTemplates WHERE ADTemplateNo = 'RP_PrintLabelProductionPlanning'), -- FK_ADTemplateID - int
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE AAStatus = 'Alive' AND STToolbarTag = 'PrintLabelProductionPlanning' AND STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'ProductionPlanning'))  -- FK_STToolbarID - int
    )
GO

