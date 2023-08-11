
INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'BatchProduct'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnPrintDeliverySemiProduct',  -- STToolbarName - nvarchar(50)
    N'Giao nhận BTP',  -- STToolbarDesc - nvarchar(255)
    'PrintDeliverySemiProduct',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Giao nhận BTP',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    6,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE AAStatus = 'Alive' AND STToolbarTag = 'PrintView' AND STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'BatchProduct')),    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

INSERT INTO dbo.STToolbarFunctions
VALUES
(   '', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE AAStatus = 'Alive' AND STToolbarTag = 'PrintDeliverySemiProduct' AND STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'BatchProduct')),    -- STToolbarParentID - int
    'PrintDeliverySemiProduct', -- STToolbarFunctionName - varchar(250)
    'void PrintDeliverySemiProduct()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.BatchProduct.BatchProductModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
)
GO

