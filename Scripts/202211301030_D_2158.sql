-- Delete
DELETE ADReportViewRefParams WHERE FK_ADReportViewRefID in (select ADReportViewRefID From ADReportViewRefs where ADReportViewRefNo = 'RP_InventoryStockProductSeries')
DELETE ADReportViewRefs WHERE ADReportViewRefNo = 'RP_InventoryStockProductSeries'
DELETE STFieldFormats WHERE STFieldFormatTableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RP_InventoryStockProductSeries')
DELETE AAColumnAlias WHERE AATableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RP_InventoryStockProductSeries')
DELETE ADReportTemplates WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_InventoryStockProductSeries')
DELETE ADReportPermissions WHERE FK_ADReportID in (select ADReportID From ADReports where ADReportNo = 'RP_InventoryStockProductSeries')
DELETE ADReports WHERE ADReportNo = 'RP_InventoryStockProductSeries'
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_InventoryStockProductSeries')
DELETE ADTemplates WHERE ADTemplateNo = 'RP_InventoryStockProductSeries'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_InventoryStockProductSeries',N'Báo cáo tồn kho theo Lô/Kiện tại thời điểm',N'Xem báo cáo tồn kho theo Lô/Kiện tại thời điểm',N'RP_InventoryStockProductSeries',N'Alive',N'RP_InventoryStockProductSeries',1
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'DateReport',N'Ngày xem',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_InventoryStockProductSeries'),0,N'Date',N'',N'',N'',N'',N'',1
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'DepartmentID',N'Ngành hàng',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_InventoryStockProductSeries'),1,N'Number',N'ICDepartments',N'',N'AAStatus = ''Alive''',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'ProductGroupID',N'Nhóm hàng',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_InventoryStockProductSeries'),2,N'Number',N'ICProductGroups',N'',N'AAStatus = ''Alive''',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'ProductAttributeID',N'Loại nguyên liệu',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_InventoryStockProductSeries'),3,N'Number',N'ICProductAttributes',N'',N'AAStatus <> ''Delete'' and ICProductAttributeGroup = ''WoodType'' or AAStatus = ''Dummy''',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'StockID',N'Kho',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_InventoryStockProductSeries'),4,N'Number',N'ICStocks',N'',N'ICStockID IN (SELECT ICStockForReportID FROM dbo.V_ICStockForReports)',N'',N'',0
INSERT INTO ADReports (AACreatedDate,AACreatedUser,AAUpdatedDate,AAUpdatedUser,AAStatus,FK_GELanguageID,ADReportNo,ADReportName,ADReportDesc,ADReportType,ADReportSection,ADReportViewType,ADReportSortOrder,ADReportCopies) SELECT 'Nov 30 2022  8:10:16:103AM',N'','Nov 30 2022  8:10:16:103AM',N'',N'Alive',1,N'RP_InventoryStockProductSeries',N'Báo cáo tồn kho theo Lô/Kiện tại thời điểm',N'Xem báo cáo tồn kho theo Lô/Kiện tại thời điểm',N'Inventory',N'Kho',N'PrintViewer',333339,0
INSERT INTO ADReportTemplates (FK_ADReportID,FK_ADTemplateID) SELECT (select ADReportID from ADReports where ADReportNo = 'RP_InventoryStockProductSeries'),(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_InventoryStockProductSeries')
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'MaSanPham',N'Mã sản phẩm',N'RP_InventoryStockProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'MaHTCu',N'Mã HT cũ',N'RP_InventoryStockProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'TenSanPham',N'Tên sản phẩm',N'RP_InventoryStockProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'MoTa',N'Mô tả',N'RP_InventoryStockProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'DoDay',N'Dày',N'RP_InventoryStockProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'Rong',N'Rộng',N'RP_InventoryStockProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'Dai',N'Dài',N'RP_InventoryStockProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'DVT',N'Đơn vị tính',N'RP_InventoryStockProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'MaLo',N'Mã lô',N'RP_InventoryStockProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'MaKien',N'Mã kiện',N'RP_InventoryStockProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'Kho',N'Kho',N'RP_InventoryStockProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'NhaCungCap',N'Nhà cung cấp',N'RP_InventoryStockProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'SoThanh',N'Số thanh tấm',N'RP_InventoryStockProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'KhoiLuong',N'Số lượng/ khối lượng',N'RP_InventoryStockProductSeries',N'',N'',N'',N'',1,1
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_InventoryStockProductSeries',1,N'DoDay'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_InventoryStockProductSeries',1,N'Rong'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_InventoryStockProductSeries',1,N'Dai'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_InventoryStockProductSeries',1,N'SoThanh'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_InventoryStockProductSeries',15,N'KhoiLuong'
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'RP_InventoryStockProductSeries') DROP PROCEDURE RP_InventoryStockProductSeries
GO
CREATE PROCEDURE [dbo].[RP_InventoryStockProductSeries]
	@DateReport			DATE,
	@DepartmentID		INT = NULL,
	@ProductGroupID		INT = NULL,
	@ProductAttributeID	INT = NULL,
	@StockID			INT = NULL
AS
BEGIN
	SET NOCOUNT ON;

	CREATE TABLE #Result
	(
		ProductID	INT,
		StockID		INT,
		StockType	NVARCHAR(50),
		ProductNo	NVARCHAR(100),
		ProductName	NVARCHAR(1000),
		ProductNoOfOldSys	NVARCHAR(100),
		ProductDesc	NVARCHAR(1000),
		StockName	NVARCHAR(1000),
		ProductSerieID	INT,
		BatchProductID	INT,
		ProductSerieLotNo	NVARCHAR(100),
		ProductSerieNo		NVARCHAR(100),
		ProductHeight	DECIMAL(18,5),
		ProductWidth	DECIMAL(18,5),
		ProductWidthMax	DECIMAL(18,5),
		ProductLength	DECIMAL(18,5),
		ProductLengthMax	DECIMAL(18,5),
		ProductPerimeter	DECIMAL(18,5),
		ModelID			INT,
		ModelDetailID	INT,
		ProductSerieProductDesc	NVARCHAR(1000),
		ProductSerieContainerNo	NVARCHAR(1000),
		ProductAttributeQualityName NVARCHAR(1000),		
		MeasureUnitID	INT,
		ProductEquipmentID	INT,
		TransactionFactor	DECIMAL(18,5),
		SupplierName		NVARCHAR(1000),
		InventoryStockWoodQuantity	DECIMAL(18,5),
		InventoryStockQuantity		DECIMAL(18,5)
	)
	
	INSERT INTO #Result
	EXEC dbo.ICProductSeries_ShowInventoryStockProductSeries @DateReport, @DepartmentID, @ProductGroupID, @ProductAttributeID, @StockID, NULL, NULL, NULL
    
	SELECT	r.ProductNo						AS MaSanPham
		,	r.ProductNoOfOldSys				AS MaHTCu
		,	r.ProductName					AS TenSanPham
		,	r.ProductDesc					AS MoTa
		,	r.ProductHeight					AS DoDay
		,	r.ProductWidth					AS Rong
		,	r.ProductLength					AS Dai
		,	ISNULL(m.ICMeasureUnitName, '') AS DVT
		,	r.ProductSerieLotNo				AS MaLo
		,	r.ProductSerieNo				AS MaKien
		,	r.StockName						AS Kho
		,	r.SupplierName					AS NhaCungCap
		,	r.InventoryStockWoodQuantity	AS SoThanh
		,	r.InventoryStockQuantity		AS KhoiLuong
	FROM #Result r
	LEFT JOIN dbo.ICMeasureUnits m ON m.AAStatus = 'Alive' AND m.ICMeasureUnitID = r.MeasureUnitID

	DROP TABLE #Result
END
