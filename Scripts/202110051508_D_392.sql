
INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM  STModules WHERE STModuleName = 'ShipmentSaleOrder'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnPrintPackingList',  -- STToolbarName - nvarchar(50)
    N'Packing List',  -- STToolbarDesc - nvarchar(255)
    'PrintPackingList',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Packing List',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    1,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE STToolbarName = 'fld_barbtnPrint' AND AAStatus = 'Alive' AND STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'ShipmentSaleOrder')),    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
    )
INSERT INTO dbo.STToolbarFunctions
VALUES
(   '', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE AAStatus = 'Alive' AND STToolbarName = 'fld_barbtnPrintPackingList' AND STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'ShipmentSaleOrder')),  -- STToolbarID - int
    'ActionPrintTemplate', -- STToolbarFunctionName - varchar(250)
    'Void ActionPrintTemplate()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.ShipmentSaleOrder.ShipmentSaleOrderModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
    )

INSERT INTO dbo.ADTemplates
VALUES
(   N'RP_PrintPackingList', -- ADTemplateNo - nvarchar(50)
    N'In Packing List', -- ADTemplateName - nvarchar(100)
    N'In Packing List', -- ADTemplateDesc - nvarchar(512)
    N'RP_PrintPackingList', -- ADTemplateStoreProc - nvarchar(256)
    'Alive',  -- AAStatus - varchar(50)
    N'', -- ADTemplateDataSource - nvarchar(100)
    1 -- ADTemplateAutoLoad - bit
    )
INSERT INTO dbo.ADTemplateToolbars
(
    FK_ADTemplateID,
    FK_STToolbarID
)
VALUES
(   (SELECT ADTemplateID FROM  dbo.ADTemplates WHERE ADTemplateNo = 'RP_PrintPackingList'), -- FK_ADTemplateID - int
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE AAStatus = 'Alive' AND STToolbarName = 'fld_barbtnPrintPackingList' AND STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'ShipmentSaleOrder'))  -- FK_STToolbarID - int
    )