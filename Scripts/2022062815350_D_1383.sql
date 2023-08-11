INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'Transfer'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnDuplicate',  -- STToolbarName - nvarchar(50)
    N'Duplicate',  -- STToolbarDesc - nvarchar(255)
    'Duplicate',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Tạo bản sao',  -- STToolbarCaption - nvarchar(50)
    N'Action',  -- STToolbarGroup - nvarchar(50)
    8,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'Duplicate',  -- STToolbarPrivilege - nvarchar(50)
    0,    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

