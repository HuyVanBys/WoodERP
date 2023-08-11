INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'DeliveryPlan'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnCancelComplete',  -- STToolbarName - nvarchar(50)
    N'Mở chứng từ',  -- STToolbarDesc - nvarchar(255)
    'CancelComplete',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Mở chứng từ',  -- STToolbarCaption - nvarchar(50)
    N'Action',  -- STToolbarGroup - nvarchar(50)
    7,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    0,    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'DeliveryPlan'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnDelete',  -- STToolbarName - nvarchar(50)
    N'Xóa',  -- STToolbarDesc - nvarchar(255)
    'Delete',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Xóa (F6)',  -- STToolbarCaption - nvarchar(50)
    N'Action',  -- STToolbarGroup - nvarchar(50)
    6,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    0,    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

