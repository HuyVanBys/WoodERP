DELETE dbo.AAColumnAlias WHERE AATableName = 'ARPriceSheetItems'

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARPriceSheetItemProductNo',   -- AAColumnAliasName - varchar(255)
    N'Mã sản phẩm',  -- AAColumnAliasCaption - nvarchar(255)
    'ARPriceSheetItems',   -- AATableName - varchar(50)
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
    'ARPriceSheetItemProductName',   -- AAColumnAliasName - varchar(255)
    N'Tên sản phẩm',  -- AAColumnAliasCaption - nvarchar(255)
    'ARPriceSheetItems',   -- AATableName - varchar(50)
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
    'ARPriceSheetItemProductDesc',   -- AAColumnAliasName - varchar(255)
    N'Mô tả',  -- AAColumnAliasCaption - nvarchar(255)
    'ARPriceSheetItems',   -- AATableName - varchar(50)
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
    'ARPriceSheetItemProductNoOfOldSys',   -- AAColumnAliasName - varchar(255)
    N'Mã HT cũ',  -- AAColumnAliasCaption - nvarchar(255)
    'ARPriceSheetItems',   -- AATableName - varchar(50)
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
    'ARPriceSheetItemProductCustomerNumber',   -- AAColumnAliasName - varchar(255)
    N'Mã SP đối tác',  -- AAColumnAliasCaption - nvarchar(255)
    'ARPriceSheetItems',   -- AATableName - varchar(50)
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
    'FK_ICMeasureUnitID',   -- AAColumnAliasName - varchar(255)
    N'Đơn vị tính',  -- AAColumnAliasCaption - nvarchar(255)
    'ARPriceSheetItems',   -- AATableName - varchar(50)
    'ICMeasureUnits',   -- AAReferenceTable - varchar(512)
    'ICMeasureUnitName',   -- AADisplayedMember - varchar(512)
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
    'ARPriceSheetItemBasicPrice',   -- AAColumnAliasName - varchar(255)
    N'Đơn giá gốc',  -- AAColumnAliasCaption - nvarchar(255)
    'ARPriceSheetItems',   -- AATableName - varchar(50)
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
    'ARPriceSheetItemQty',   -- AAColumnAliasName - varchar(255)
    N'Mua từ',  -- AAColumnAliasCaption - nvarchar(255)
    'ARPriceSheetItems',   -- AATableName - varchar(50)
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
    'ARPriceSheetItemPrice',   -- AAColumnAliasName - varchar(255)
    N'Đơn giá',  -- AAColumnAliasCaption - nvarchar(255)
    'ARPriceSheetItems',   -- AATableName - varchar(50)
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
    'ARPriceSheetItemCommand',   -- AAColumnAliasName - varchar(255)
    N'Ghi chú',  -- AAColumnAliasCaption - nvarchar(255)
    'ARPriceSheetItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

DELETE dbo.STFieldFormats WHERE STFieldFormatTableName = 'ARPriceSheetItems'

INSERT INTO dbo.STFieldFormats
VALUES
(   'PriceSheet', -- STFieldFormatModuleName - varchar(50)
    'ARPriceSheetItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupQtyN2'),  -- STFieldFormatGroupID - int
    'ARPriceSheetItemBasicPrice'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'PriceSheet', -- STFieldFormatModuleName - varchar(50)
    'ARPriceSheetItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupQtyN2'),  -- STFieldFormatGroupID - int
    'ARPriceSheetItemPrice'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'PriceSheet', -- STFieldFormatModuleName - varchar(50)
    'ARPriceSheetItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ARPriceSheetItemQty'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'PriceSheetApprovedStatusIsActive', -- ADConfigKey - nvarchar(100)
    N'IsActive', -- ADConfigKeyValue - nvarchar(100)
    N'Đang hiệu lực', -- ADConfigText - nvarchar(1000)
    N'PriceSheetApprovedStatusIsActive', -- ADConfigKeyDesc - nvarchar(500)
    N'PriceSheetApprovedStatus', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'PriceSheetApprovedStatusNotActive', -- ADConfigKey - nvarchar(100)
    N'NotActive', -- ADConfigKeyValue - nvarchar(100)
    N'Chưa hiệu lực', -- ADConfigText - nvarchar(1000)
    N'PriceSheetApprovedStatusNotActive', -- ADConfigKeyDesc - nvarchar(500)
    N'PriceSheetApprovedStatus', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'PriceSheetApprovedStatusOutOfActive', -- ADConfigKey - nvarchar(100)
    N'OutOfActive', -- ADConfigKeyValue - nvarchar(100)
    N'Hết hiệu lực', -- ADConfigText - nvarchar(1000)
    N'PriceSheetApprovedStatusOutOfActive', -- ADConfigKeyDesc - nvarchar(500)
    N'PriceSheetApprovedStatus', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO


DELETE dbo.AAColumnAlias WHERE AATableName = 'ARPriceSheets'

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARPriceSheetNo',   -- AAColumnAliasName - varchar(255)
    N'Mã chứng từ',  -- AAColumnAliasCaption - nvarchar(255)
    'ARPriceSheets',   -- AATableName - varchar(50)
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
    'ARPriceSheetName',   -- AAColumnAliasName - varchar(255)
    N'Tên chứng từ',  -- AAColumnAliasCaption - nvarchar(255)
    'ARPriceSheets',   -- AATableName - varchar(50)
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
    'ARPriceSheetDesc',   -- AAColumnAliasName - varchar(255)
    N'Mô tả',  -- AAColumnAliasCaption - nvarchar(255)
    'ARPriceSheets',   -- AATableName - varchar(50)
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
    'ARPriceSheetDate',   -- AAColumnAliasName - varchar(255)
    N'Ngày chứng từ',  -- AAColumnAliasCaption - nvarchar(255)
    'ARPriceSheets',   -- AATableName - varchar(50)
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
    'ARPriceSheetStartDate',   -- AAColumnAliasName - varchar(255)
    N'Hiệu lực từ ngày',  -- AAColumnAliasCaption - nvarchar(255)
    'ARPriceSheets',   -- AATableName - varchar(50)
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
    'ARPriceSheetEndDate',   -- AAColumnAliasName - varchar(255)
    N'Ngày hết hạn',  -- AAColumnAliasCaption - nvarchar(255)
    'ARPriceSheets',   -- AATableName - varchar(50)
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
    'ARPriceSheetStatus',   -- AAColumnAliasName - varchar(255)
    N'Tình trạng',  -- AAColumnAliasCaption - nvarchar(255)
    'ARPriceSheets',   -- AATableName - varchar(50)
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
    'ARPriceSheetApprovedStatus',   -- AAColumnAliasName - varchar(255)
    N'Tình trạng hiệu lực',  -- AAColumnAliasCaption - nvarchar(255)
    'ARPriceSheets',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO


INSERT INTO STToolbars       VALUES('Alive',(SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'PriceSheet'), 1,N'fld_barbtnImportPriceSheetExcel',N'Import Bảng giá',N'ImportPriceSheetExcel',N'',N'Import Bảng giá',N'Extra',2,1,N'',ISNULL((SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'PriceSheet') AND STToolbarTag = ''),0),N'')
INSERT INTO dbo.STToolbarFunctions   VALUES   ('',(SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE AAStatus = 'Alive'AND STModuleName= 'PriceSheet') AND STToolbarTag = 'ImportPriceSheetExcel'),'ImportPriceSheetExcel','void ImportPriceSheetExcel()','BOSERP.Modules.PriceSheet.PriceSheetModule',1)