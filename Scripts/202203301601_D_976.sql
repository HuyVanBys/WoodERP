INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACAssetIsInventory',   -- AAColumnAliasName - varchar(255)
    N'Kiểm kê',  -- AAColumnAliasCaption - nvarchar(255)
    'ACAssets',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ICProductIsInventory',   -- AAColumnAliasName - varchar(255)
    N'Kiểm kê',  -- AAColumnAliasCaption - nvarchar(255)
    'ICProducts',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

update ACAssets SET ACAssetIsInventory = 0 WHERE ACAssetIsInventory IS NULL
GO 

update ICProducts SET ICProductIsInventory = 0 WHERE ICProductIsInventory IS NULL
GO 

INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'AccountingBill'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnPrintTransaction',  -- STToolbarName - nvarchar(100)
    N'Phiếu hạch toán',  -- STToolbarDesc - nvarchar(255)
    N'PrintTransaction',  -- STToolbarTag - nvarchar(100)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Phiếu hạch toán',  -- STToolbarCaption - nvarchar(50)
    N'Utility',  -- STToolbarGroup - nvarchar(50)
    2,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'AccountingBill') AND STToolbarTag = 'Print'),    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
    )
GO 

INSERT INTO dbo.STToolbarFunctions
VALUES
(   '0', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'AccountingBill') AND STToolbarTag = 'PrintTransaction'),  -- STToolbarID - int
    'ActionPrintTemplate', -- STToolbarFunctionName - varchar(250)
    'Void ActionPrintTemplate()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.EquipmentReceipt.EquipmentReceiptModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
    )
GO

--SELECT * FROM dbo.ADTemplates WHERE ADTemplateNo LIKE N'%AccountingBill%'


INSERT INTO dbo.ADTemplates
VALUES
(   N'AccountingBill_Print004', -- ADTemplateNo - nvarchar(50)
    N'Phiếu hạch toán', -- ADTemplateName - nvarchar(100)
    N'Phiếu hạch toán', -- ADTemplateDesc - nvarchar(512)
    N'AccountingBill_Print004', -- ADTemplateStoreProc - nvarchar(256)
    'Alive',  -- AAStatus - varchar(50)
    N'', -- ADTemplateDataSource - nvarchar(100)
    0 -- ADTemplateAutoLoad - bit
    )
GO 

INSERT INTO dbo.ADTemplateToolbars
(
    FK_ADTemplateID,
    FK_STToolbarID
)
VALUES
(   (SELECT ADTemplateID FROM  dbo.ADTemplates WHERE ADTemplateNo = 'AccountingBill_Print004'), -- FK_ADTemplateID - int
    (SELECT STToolbarID FROM  dbo.STToolbars WHERE AAStatus = 'Alive' AND STToolbarName = 'fld_barbtnPrintTransaction' AND STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'AccountingBill'))  -- FK_STToolbarID - int
    )
GO