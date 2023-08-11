
DELETE FROM dbo.AAColumnAlias WHERE AATableName = 'ICInventoryStockCountItems' AND AAStatus = 'Alive'
INSERT INTO AAColumnAlias VALUES(0,'','Alive','FK_ICProductID', N'Mã sản phẩm','ICInventoryStockCountItems','ICProducts','ICProductNo','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','FK_ICStockID', N'Mã kho','ICInventoryStockCountItems','ICStocks','ICStockName','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','ICInventoryStockCountItemQuantity', N'Tồn kho chương trình','ICInventoryStockCountItems','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','ICInventoryStockCountItemActualQuantity', N'Tồn kho thực tế','ICInventoryStockCountItems','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','ICInventoryStockCountItemICProductSupplierNumber', N'Mã sản phẩm NCC','ICInventoryStockCountItems','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','ICInventoryStockCountItemICProductDesc', N'Mô tả sản phẩm','ICInventoryStockCountItems','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','ICInventoryStockActualUnitCost', N'Giá vốn thực tế','ICInventoryStockCountItems','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','ICInventoryStockCountItemPackageBarcode', N'Mã vạch kiện','ICInventoryStockCountItems','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','ICInventoryStockCountItemProductSerialNo', N'Mã lô','ICInventoryStockCountItems','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','ICInventoryStockCountItemDesc', N'Ghi chú','ICInventoryStockCountItems','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','ICMeasureUnitName', N'Đơn vị tính','ICInventoryStockCountItems','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','ICProductGroupName', N'Nhóm hàng','ICInventoryStockCountItems','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','ICDepartmentName', N'Ngành hàng','ICInventoryStockCountItems','','','','','0','0')
--INSERT INTO AAColumnAlias VALUES(0,'','Alive','ICInventoryStockCountItemIsSpecificCalculation', N'Áp giá trung bình','ICInventoryStockCountItems','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','ICInventoryStockCountItemIsSpecificCalculation', N'Áp giá đích danh','ICInventoryStockCountItems','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','ICInventoryStockCountItemQuantityVariance', N'Chênh lệch','ICInventoryStockCountItems','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','ICInventoryStockUnitCostAVG', N'Giá vốn các lô','ICInventoryStockCountItems','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','ICInventoryStockActualTotalCost', N'Giá trị chênh lệch','ICInventoryStockCountItems','','','','','0','0')

--SELECT * FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'InventoryStockCount')

INSERT INTO dbo.STToolbars
select   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'InventoryStockCount'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnPosted',  -- STToolbarName - nvarchar(50)
    N'Posted',  -- STToolbarDesc - nvarchar(255)
    'Posted',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Post sổ',  -- STToolbarCaption - nvarchar(50)
    N'Action',  -- STToolbarGroup - nvarchar(50)
    7,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    0,    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
    
INSERT INTO dbo.STToolbars
select   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'InventoryStockCount'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnUnPosted',  -- STToolbarName - nvarchar(50)
    N'UnPosted',  -- STToolbarDesc - nvarchar(255)
    'UnPosted',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Hủy Post sổ',  -- STToolbarCaption - nvarchar(50)
    N'Action',  -- STToolbarGroup - nvarchar(50)
    8,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    0,    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
    
INSERT INTO dbo.STToolbars
select   'Alive',   -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'InventoryStockCount'),    -- STModuleID - int
    1,    -- STUserGroupID - int
    N'fld_barbtnExportInventoryCount',  -- STToolbarName - nvarchar(50)
    N'Xuất dữ liệu tồn kho',  -- STToolbarDesc - nvarchar(255)
    'ExportInventoryCount',   -- STToolbarTag - varchar(50)
    'Default',   -- STToolbarStyle - varchar(50)
    N'Xuất dữ liệu tồn kho',  -- STToolbarCaption - nvarchar(50)
    N'Extra',  -- STToolbarGroup - nvarchar(50)
    1,    -- STToolbarOrder - int
    1, -- STToolbarVisible - bit
    N'',  -- STToolbarPrivilege - nvarchar(50)
    0,    -- STToolbarParentID - int
    N''   -- STToolbarImage - nvarchar(50)
    

	INSERT INTO dbo.STToolbarFunctions
	select  '', -- STToolbarFunctionIDString - varchar(50)
	    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = 133 AND STToolbarName = 'fld_barbtnPosted'),  -- STToolbarID - int
	    'ActionPosted', -- STToolbarFunctionName - varchar(250)
	    'void ActionPosted()', -- STToolbarFunctionFullName - varchar(500)
	    'BOSERP.Modules.InventoryStockCount.InventoryStockCountModule', -- STToolbarFunctionClass - varchar(250)
	    1   -- STToolbarFunctionSortOrder - int

	INSERT INTO dbo.STToolbarFunctions
	select  '', -- STToolbarFunctionIDString - varchar(50)
	    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = 133 AND STToolbarName = 'fld_barbtnUnPosted'),  -- STToolbarID - int
	    'ActionUnPosted', -- STToolbarFunctionName - varchar(250)
	    'void ActionUnPosted()', -- STToolbarFunctionFullName - varchar(500)
	    'BOSERP.Modules.InventoryStockCount.InventoryStockCountModule', -- STToolbarFunctionClass - varchar(250)
	    1   -- STToolbarFunctionSortOrder - int
	INSERT INTO dbo.STToolbarFunctions
	select  '', -- STToolbarFunctionIDString - varchar(50)
	    (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = 133 AND STToolbarName = 'fld_barbtnExportInventoryCount'),  -- STToolbarID - int
	    'ExportTeamplateFile', -- STToolbarFunctionName - varchar(250)
	    'Void ExportTeamplateFile()', -- STToolbarFunctionFullName - varchar(500)
	    'BOSERP.Modules.InventoryStockCount.InventoryStockCountModule', -- STToolbarFunctionClass - varchar(250)
	    1   -- STToolbarFunctionSortOrder - int
	      


UPDATE STToolbars SET AAStatus ='Delete' WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'InventoryStockCount') AND STToolbarName = 'fld_barbtnApproved'
		
--SELECT * FROM [ERPAChauTest].dbo.AAColumnAlias WHERE  AAStatus = 'Alive' AND AATableName = 'IPInventoryStockCounts'

INSERT INTO AAColumnAlias VALUES(0,'','Alive','StockNo', N'Mã kho','IPInventoryStockCounts','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','StockName', N'Tên kho','IPInventoryStockCounts','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','ProductNo', N'Mã sản phẩm','IPInventoryStockCounts','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','ProductName', N'Tên sản phẩm','IPInventoryStockCounts','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','ProductDesc', N'Mô tả','IPInventoryStockCounts','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','MeasureUnitName', N'ĐVT','IPInventoryStockCounts','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','ProductSerieNo', N'Mã lô','IPInventoryStockCounts','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','ProgramInventoryQty', N'Tồn kho chương trình','IPInventoryStockCounts','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','ActualInventoryQty', N'Tồn kho thực tế','IPInventoryStockCounts','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','InventoryStockCountNote', N'Ghi chú','IPInventoryStockCounts','','','','','0','0')
INSERT INTO AAColumnAlias VALUES(0,'','Alive','STT', N'STT','IPInventoryStockCounts','','','','','0','0')

--SELECT * FROM dbo.ADConfigValues WHERE ADConfigKeyGroup = 'InventoryStockCountType'

--INSERT INTO dbo.ADConfigValues SELECT 'Alive',N'InventoryStockCountTypePackage',N'Package',N'Theo lô/kiện',N'Theo lô/kiện',N'InventoryStockCountType',1
INSERT INTO dbo.STFieldFormats VALUES (   'InventoryStockCount','ICInventoryStockCountItems',9,'ICInventoryStockCountItemQuantity')
INSERT INTO dbo.STFieldFormats VALUES (   'InventoryStockCount','ICInventoryStockCountItems',9,'ICInventoryStockCountItemActualQuantity')
INSERT INTO dbo.STFieldFormats VALUES (   'InventoryStockCount','ICInventoryStockCountItems',10,'ICInventoryStockActualUnitCost')
INSERT INTO dbo.STFieldFormats VALUES (   'InventoryStockCount','ICInventoryStockCountItems',9,'ICInventoryStockCountItemQuantityVariance')
INSERT INTO dbo.STFieldFormats VALUES (   'InventoryStockCount','ICInventoryStockCountItems',10,'ICInventoryStockUnitCostAVG')
INSERT INTO dbo.STFieldFormats VALUES (   'InventoryStockCount','ICInventoryStockCountItems',10,'ICInventoryStockActualTotalCost')


INSERT INTO dbo.STModulePostings
SELECT 'Alive', -- AAStatus - varchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'InventoryStockCount'),  -- STModuleID - int
    'ACTransactions_ICInventoryStockCountPosting', -- STModulePostingAccountingFunction - varchar(512)
    'IC_PostedICInventoryStockCountItems', -- STModulePostingStockFunction - varchar(512)
    '', -- STModulePostingPurchaseFunction - varchar(256)
    '', -- STModulePostingAllocationPlanFunction - varchar(256)
    '', -- STModulePostingSaleOrderFunction - varchar(256)
    '', -- STModulePostingTransitInFunction - varchar(256)
    '', -- STModulePostingTransitOutFunction - varchar(256)
    '', -- STModulePostingInvoiceTransFunction - varchar(256)
    ''  -- STModulePostingInvoiceInTransFunction - varchar(256)
    


INSERT INTO dbo.ACDocTypeEntryFunctionMappings
SELECT   N'Alive', -- AAStatus - nvarchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'InventoryStockCount'),   -- FK_STModuleID - int
    ( SELECT STToolbarID FROM STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'InventoryStockCount') AND STToolbarName = 'fld_barbtnNew' AND AAStatus = 'Alive'),   -- FK_STToolbarID - int
    (SELECT ACDocumentTypeID FROM dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'KiemKho' AND AAStatus = 'Alive'),   -- FK_ACDocumentTypeID - int
    (SELECT ACEntryTypeID FROM dbo.ACEntryTypes WHERE ACEntryTypeName = 'NhapKhoDieuChinh' AND AAStatus = 'Alive')    -- FK_ACEntryTypeID - int

INSERT INTO dbo.ACDocTypeEntryFunctionMappings
SELECT   N'Alive', -- AAStatus - nvarchar(50)
    (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'InventoryStockCount'),   -- FK_STModuleID - int
    ( SELECT STToolbarID FROM STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'InventoryStockCount') AND STToolbarName = 'fld_barbtnNew' AND AAStatus = 'Alive'),   -- FK_STToolbarID - int
    (SELECT ACDocumentTypeID FROM dbo.ACDocumentTypes WHERE ACDocumentTypeName = 'KiemKho' AND AAStatus = 'Alive'),   -- FK_ACDocumentTypeID - int
    (SELECT ACEntryTypeID FROM dbo.ACEntryTypes WHERE ACEntryTypeName = 'XuatKhoDieuChinh' AND AAStatus = 'Alive')    -- FK_ACEntryTypeID - int
