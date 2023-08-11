--đã dev test 
--v2 demo happy
INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'ShipmentSaleOrder'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnPrintPackingListHP',  -- STToolbarName - nvarchar(100)
    N'',  -- STToolbarDesc - nvarchar(255)
    N'PrintPackingListHP',  -- STToolbarTag - nvarchar(100)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Packing List',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    5,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'ShipmentSaleOrder') AND STToolbarTag = 'Print' AND AAStatus = 'Alive'),    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

INSERT INTO dbo.STToolbarFunctions
VALUES
(   '0', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'ShipmentSaleOrder') AND STToolbarTag = 'PrintPackingListHP'),  -- STToolbarID - int
    'PrintPackingListHP', -- STToolbarFunctionName - varchar(250)
    'Void PrintPackingListHP()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.ShipmentSaleOrder.ShipmentSaleOrderModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
    )
GO