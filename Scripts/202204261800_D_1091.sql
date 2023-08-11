DELETE dbo.STToolbars 
WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PaintProcesses') 
AND STToolbarTag = 'Delete'

INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'PaintProcesses'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnDelete',  -- STToolbarName - nvarchar(50)
    N'Xóa (F6)',  -- STToolbarDesc - nvarchar(255)
    'Delete',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Xóa (F6)',  -- STToolbarCaption - nvarchar(50)
    N'Extra',  -- STToolbarGroup - nvarchar(50)
    0,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    0,    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO
