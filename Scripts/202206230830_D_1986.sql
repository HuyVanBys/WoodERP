INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM  dbo.STModules WHERE STModuleName = 'DeliveryPlan'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnUpdateDeliveryPlanDate',  -- STToolbarName - nvarchar(50)
    N'Cập nhật ngày chứng từ',  -- STToolbarDesc - nvarchar(255)
    'UpdateDeliveryPlanDate',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Cập nhật ngày chứng từ',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    (SELECT MAX(STToolbarOrder) + 1 FROM  dbo.STToolbars WHERE AAStatus = 'Alive' AND STModuleID = (SELECT STModuleID FROM  dbo.STModules WHERE STModuleName = 'DeliveryPlan' AND STToolbarGroup = 'Utility')),    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    0,    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
    )
INSERT INTO dbo.STToolbarFunctions
VALUES
(   '', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM  dbo.STModules WHERE STModuleName = 'DeliveryPlan') AND STToolbarName = 'fld_barbtnUpdateDeliveryPlanDate'),  -- STToolbarID - int
    'ChangeDeliveryPlanDate', -- STToolbarFunctionName - varchar(250)
    'Void ChangeDeliveryPlanDate()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.DeliveryPlan.DeliveryPlanModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
    )