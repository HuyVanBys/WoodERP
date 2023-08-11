INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PurchaseOrder' AND AAStatus = 'Alive'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnPrintOutSourcing',  -- STToolbarName - nvarchar(50)
    N'Đơn mua hàng (gia công)',  -- STToolbarDesc - nvarchar(255)
    'PrintOutSourcing',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Đơn mua hàng (gia công)',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    7,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    (SELECT STToolbarID FROM STToolbars where STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PurchaseOrder' AND AAStatus = 'Alive') and STToolbarTag = 'Print' and AAStatus = 'Alive'),    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
    )
GO
INSERT INTO dbo.STToolbarFunctions
VALUES
(   '', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM STToolbars where STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PurchaseOrder' AND AAStatus = 'Alive') and STToolbarTag = 'PrintOutSourcing' and AAStatus = 'Alive'),  -- STToolbarID - int
    'ActionPrintTemplate', -- STToolbarFunctionName - varchar(250)
    'Void ActionPrintTemplate()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.PurchaseOrder.PurchaseOrderModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
    )
GO

INSERT INTO dbo.ADTemplates
VALUES
(   N'RP_PurchaseOrderOutSourcing', -- ADTemplateNo - nvarchar(50)
    N'Đơn mua hàng (Gia công)', -- ADTemplateName - nvarchar(100)
    N'Đơn mua hàng (Gia công)', -- ADTemplateDesc - nvarchar(512)
    N'RP_PurchaseOrder', -- ADTemplateStoreProc - nvarchar(256)
    'Alive',  -- AAStatus - varchar(50)
    N'RP_PurchaseOrderEquip', -- ADTemplateDataSource - nvarchar(100)
    0 -- ADTemplateAutoLoad - bit
    )
GO

INSERT INTO dbo.ADTemplateToolbars
VALUES
(   (SELECT ADTemplateID FROM  ADTemplates WHERE ADTemplateNo = 'RP_PurchaseOrderOutSourcing'), -- FK_ADTemplateID - int
    (SELECT STToolbarID FROM STToolbars where STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PurchaseOrder' AND AAStatus = 'Alive') and STToolbarTag = 'PrintOutSourcing' and AAStatus = 'Alive')  -- FK_STToolbarID - int
    )
GO

