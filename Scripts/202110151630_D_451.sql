INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'BatchProduct'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnPrintOperation',  -- STToolbarName - nvarchar(50)
    N'Phiếu công đoạn',  -- STToolbarDesc - nvarchar(255)
    'PrintOperation',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Phiếu công đoạn',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    (SELECT MAX(STToolbarOrder + 1) FROM  dbo.STToolbars WHERE STToolbarParentID = (SELECT STToolbarID FROM  dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'BatchProduct') AND STToolbarName = 'fld_barbtnPrintView')),    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'BatchProduct') AND STToolbarName = 'fld_barbtnPrintView'),    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
    )

INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'BatchProduct'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnPrintDeliveryNote',  -- STToolbarName - nvarchar(50)
    N'Phiếu giao nhận',  -- STToolbarDesc - nvarchar(255)
    'PrintDeliveryNote',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Phiếu giao nhận',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    (SELECT MAX(STToolbarOrder + 1) FROM  dbo.STToolbars WHERE STToolbarParentID = (SELECT STToolbarID FROM  dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'BatchProduct') AND STToolbarName = 'fld_barbtnPrintView')),    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'BatchProduct') AND STToolbarName = 'fld_barbtnPrintView'),    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
    )

INSERT INTO dbo.STToolbarFunctions
VALUES
(   '', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'BatchProduct') AND STToolbarName = 'fld_barbtnPrintOperation'),  -- STToolbarID - int
    'PrintOperation', -- STToolbarFunctionName - varchar(250)
    'void PrintOperation()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.BatchProduct.BatchProductModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
    )
INSERT INTO dbo.STToolbarFunctions
VALUES
(   '', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'BatchProduct') AND STToolbarName = 'fld_barbtnPrintDeliveryNote'),  -- STToolbarID - int
    'PrintDeliveryNote', -- STToolbarFunctionName - varchar(250)
    'void PrintDeliveryNote()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.BatchProduct.BatchProductModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
    )