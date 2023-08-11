INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PurchaseReceipt'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnPrintWoodPurchaseReceiptA4',  -- STToolbarName - nvarchar(100)
    N'',  -- STToolbarDesc - nvarchar(255)
    N'PrintWoodPurchaseReceiptA4',  -- STToolbarTag - nvarchar(100)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Nhập kho mua hàng (gỗ)',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    7,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PurchaseReceipt') AND STToolbarTag = 'Print'),    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

INSERT INTO dbo.STToolbarFunctions
VALUES
(   '0', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PurchaseReceipt') AND STToolbarTag = 'PrintWoodPurchaseReceiptA4'),  -- STToolbarID - int
    'PrintWoodPurchaseReceiptA4', -- STToolbarFunctionName - varchar(250)
    'Void PrintWoodPurchaseReceiptA4()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.PurchaseReceipt.PurchaseReceiptModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
    )
GO