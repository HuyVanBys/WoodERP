INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'SaleOrder'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnPrintRP_SaleOrderExportDraft',  -- STToolbarName - nvarchar(50)
    N'In nháp đơn bán hàng',  -- STToolbarDesc - nvarchar(255)
    'PrintRP_SaleOrderExportDraft',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'In nháp đơn bán hàng',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    1,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars 
		WHERE AAStatus = 'Alive' AND STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'SaleOrder') AND STToolbarTag = 'Print'),    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

INSERT INTO dbo.STToolbarFunctions
VALUES
(   '', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars 
		WHERE AAStatus = 'Alive' AND STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'SaleOrder') AND STToolbarTag = 'PrintRP_SaleOrderExportDraft'),  -- STToolbarID - int
    'ActionPrintTemplate', -- STToolbarFunctionName - varchar(250)
    'Void ActionPrintTemplate()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.SaleOrder.SaleOrderModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
)
GO

INSERT INTO dbo.ADTemplates
VALUES
(   N'RP_SaleOrderExportDraft', -- ADTemplateNo - nvarchar(50)
    N'In nháp đơn bán hàng', -- ADTemplateName - nvarchar(100)
    N'In nháp đơn bán hàng', -- ADTemplateDesc - nvarchar(512)
    N'RP_PrintSaleOrder', -- ADTemplateStoreProc - nvarchar(256)
    'Alive',  -- AAStatus - varchar(50)
    N'', -- ADTemplateDataSource - nvarchar(100)
    0 -- ADTemplateAutoLoad - bit
)
GO

INSERT INTO dbo.ADTemplateToolbars
VALUES
(   (SELECT ADTemplateID FROM dbo.ADTemplates WHERE ADTemplateNo = 'RP_SaleOrderExportDraft'), -- FK_ADTemplateID - int
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STToolbarTag = 'PrintRP_SaleOrderExportDraft')  -- FK_STToolbarID - int
)
GO
