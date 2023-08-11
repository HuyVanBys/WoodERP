-----------ONLY DUC THANH-----------

--SELECT * FROM STToolbars WHERE STModuleID = 1265
INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'DeliveryPlan'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnCustomsDeclarationContract',  -- STToolbarName - nvarchar(100)
    N'',  -- STToolbarDesc - nvarchar(255)
    N'CustomsDeclarationContract',  -- STToolbarTag - nvarchar(100)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Contract khai Hải quan',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    4,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'DeliveryPlan') AND STToolbarTag = 'Print'),    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

INSERT INTO dbo.STToolbarFunctions
VALUES
(   '0', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'DeliveryPlan') AND STToolbarTag = 'CustomsDeclarationContract'),  -- STToolbarID - int
    'ActionPrintTemplate', -- STToolbarFunctionName - varchar(250)
    'Void ActionPrintTemplate()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.DeliveryPlan.DeliveryPlanModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
    )
GO

INSERT INTO dbo.ADTemplates
VALUES
(   N'RP_CustomsDeclarationContract', -- ADTemplateNo - nvarchar(50)
    N'Contract khai Hải quan', -- ADTemplateName - nvarchar(100)
    N'Contract khai Hải quan', -- ADTemplateDesc - nvarchar(512)
    N'RP_CustomsDeclarationContract', -- ADTemplateStoreProc - nvarchar(256)
    'Alive',  -- AAStatus - varchar(50)
    N'RP_CustomsDeclarationContract', -- ADTemplateDataSource - nvarchar(100)
    0 -- ADTemplateAutoLoad - bit
    )
GO 

INSERT INTO dbo.ADTemplateToolbars
(
    FK_ADTemplateID,
    FK_STToolbarID
)
VALUES
(   (SELECT ADTemplateID FROM  dbo.ADTemplates WHERE ADTemplateNo = 'RP_CustomsDeclarationContract'), -- FK_ADTemplateID - int
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE AAStatus = 'Alive' AND STToolbarTag = 'CustomsDeclarationContract' AND STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'DeliveryPlan'))  -- FK_STToolbarID - int
    )
GO

