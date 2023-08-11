-----Đã chạy DB test, dev
INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'RetailVAT'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnUpLoadDataToHDDT',  -- STToolbarName - nvarchar(50)
    N'Chuyển dữ liệu HĐĐT',  -- STToolbarDesc - nvarchar(255)
    'UpLoadDataToHDDT',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Chuyển dữ liệu HĐĐT',  -- STToolbarCaption - nvarchar(50)
    N'Extra',  -- STToolbarGroup - nvarchar(50)
    1,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    0,    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

INSERT INTO dbo.STToolbarFunctions
VALUES
(   '0', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STToolbarTag = 'UpLoadDataToHDDT' AND STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'RetailVAT')),  -- STToolbarID - int
    'UpLoadDataToHDDT', -- STToolbarFunctionName - varchar(250)
    'Void UpLoadDataToHDDT()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.RetailVAT.RetailVATModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
)
GO