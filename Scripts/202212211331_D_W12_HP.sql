
--HP WV2 WDemo

INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'SaleOrder'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnPrintSaleOrderWoodHP',  -- STToolbarName - nvarchar(100)
    N'',  -- STToolbarDesc - nvarchar(255)
    N'PrintSaleOrderWoodHP',  -- STToolbarTag - nvarchar(100)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Đơn bán hàng gỗ',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    8,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'SaleOrder') AND STToolbarTag = 'Print'),    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

INSERT INTO dbo.STToolbarFunctions
VALUES
(   '0', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'SaleOrder') AND STToolbarTag = 'PrintSaleOrderWoodHP'),  -- STToolbarID - int
    'PrintSaleOrderWoodHP', -- STToolbarFunctionName - varchar(250)
    'Void PrintSaleOrderWoodHP()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.SaleOrder.SaleOrderModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
    )
GO
