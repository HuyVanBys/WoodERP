INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'AdvanceRefund'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnAdvanceRefundA4',  -- STToolbarName - nvarchar(100)
    N'',  -- STToolbarDesc - nvarchar(255)
    N'AdvanceRefundA4',  -- STToolbarTag - nvarchar(100)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Phiếu hoàn ứng',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    3,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'AdvanceRefund') AND STToolbarTag = 'Print'),    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

INSERT INTO dbo.STToolbarFunctions
VALUES
(   '0', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'AdvanceRefund') AND STToolbarTag = 'AdvanceRefundA4'),  -- STToolbarID - int
    'PrintAdvanceRefundA4', -- STToolbarFunctionName - varchar(250)
    'Void PrintAdvanceRefundA4()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.AdvanceRefund.AdvanceRefundModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
    )
GO