-----Đã chạy DB dev, test
INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACEInvoiceDetailReferenceNo',   -- AAColumnAliasName - varchar(255)
    N'Mã hóa đơn bán hàng',  -- AAColumnAliasCaption - nvarchar(255)
    'ACEInvoiceDetails',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.STToolbars
VALUES
(   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'ElectronicInvoiceBKAV'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnNewFromInvoice',  -- STToolbarName - nvarchar(50)
    N'Từ Hóa đơn bán hàng',  -- STToolbarDesc - nvarchar(255)
    'NewFromInvoice',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Từ Hóa đơn bán hàng',  -- STToolbarCaption - nvarchar(50)
    N'Action',  -- STToolbarGroup - nvarchar(50)
    2,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE AAStatus = 'Alive' AND STToolbarName = 'fld_barbtnNew' 
	AND STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'ElectronicInvoiceBKAV')),    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
)
GO

INSERT INTO dbo.STToolbarFunctions
VALUES
(   '0', -- STToolbarFunctionIDString - varchar(50)
    (SELECT STToolbarID FROM dbo.STToolbars WHERE AAStatus = 'Alive' AND STToolbarName = 'fld_barbtnNewFromInvoice' 
	AND STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'ElectronicInvoiceBKAV')),  -- STToolbarID - int
    'ActionNewFromInvoice', -- STToolbarFunctionName - varchar(250)
    'void ActionNewFromInvoice()', -- STToolbarFunctionFullName - varchar(500)
    'BOSERP.Modules.ElectronicInvoiceBKAV.ElectronicInvoiceBKAVModule', -- STToolbarFunctionClass - varchar(250)
    1   -- STToolbarFunctionSortOrder - int
)
GO

UPDATE dbo.AAColumnAlias
SET AAColumnAliasCaption = N'Đơn vị mua hàng'
WHERE AAColumnAliasName = 'BuyerLegalName'
AND AATableName = 'ACEInvoiceGenerals'

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'BuyerDisplayName',   -- AAColumnAliasName - varchar(255)
    N'Người mua hàng',  -- AAColumnAliasCaption - nvarchar(255)
    'ACEInvoiceGenerals',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'ElectronicInvoice', -- STFieldFormatModuleName - varchar(50)
    'ACEInvoiceGenerals', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupExchangeRate'),  -- STFieldFormatGroupID - int
    'ExchangeRate'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'ElectronicInvoice', -- STFieldFormatModuleName - varchar(50)
    'ACEInvoiceGenerals', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPriceByCurrency'),  -- STFieldFormatGroupID - int
    'TotalAmountWithVAT'  -- STFieldFormatColumnName - varchar(100)
)
GO