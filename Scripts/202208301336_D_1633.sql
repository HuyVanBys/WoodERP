INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM  dbo.STModules WHERE STModuleName = 'SupplierPriceSheet'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnDelete',  -- STToolbarName - nvarchar(50)
    N'Xóa (F6)',  -- STToolbarDesc - nvarchar(255)
    'Delete',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Xóa (F6)',  -- STToolbarCaption - nvarchar(50)
    N'Action',  -- STToolbarGroup - nvarchar(50)
    (SELECT MAX(STToolbarOrder + 1) FROM  dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM  dbo.STModules WHERE STModuleName = 'SupplierPriceSheet') AND STToolbarGroup = 'Action'),    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    0,    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
    )