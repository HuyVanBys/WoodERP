-- Delete
DELETE ADReportViewRefParams WHERE FK_ADReportViewRefID in (select ADReportViewRefID From ADReportViewRefs where ADReportViewRefNo = 'RPBatchProductProgress')
DELETE ADReportViewRefs WHERE ADReportViewRefNo = 'RPBatchProductProgress'
DELETE STFieldFormats WHERE STFieldFormatTableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RPBatchProductProgress')
DELETE AAColumnAlias WHERE AATableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RPBatchProductProgress')
DELETE ADReportTemplates WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RPBatchProductProgress')
DELETE ADReportPermissions WHERE FK_ADReportID in (select ADReportID From ADReports where ADReportNo = 'RPBatchProductProgress')
DELETE ADReports WHERE ADReportNo = 'RPBatchProductProgress'
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RPBatchProductProgress')
DELETE ADTemplates WHERE ADTemplateNo = 'RPBatchProductProgress'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RPBatchProductProgress',N'Báo cáo tổng hợp tiến độ sản xuất',N'Báo cáo tổng hợp tiến độ sản xuất',N'RPBatchProductProgress_GetData',N'Alive',N'RPBatchProductProgress',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'FromDate',N'Từ ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RPBatchProductProgress'),0,N'Date',N'',N'',N'',N'',N'',1
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'Todate',N'Đến ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RPBatchProductProgress'),1,N'Date',N'',N'',N'',N'',N'',1
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'SaleOrderID',N'Đơn bán hàng',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RPBatchProductProgress'),2,N'Number',N'ARSaleOrders',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'ObjectID',N'Đối tượng',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RPBatchProductProgress'),3,N'Text',N'ACObjects',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'BatchProductID',N'Lệnh sản xuất',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RPBatchProductProgress'),4,N'Number',N'MMBatchProducts',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'OperationID',N'Công đoạn',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RPBatchProductProgress'),5,N'Number',N'ADCustomizeLookups',N'ADCustomizeLookupID,ADCustomizeLookupNo,Ten',N'SELECT MMOperationID ADCustomizeLookupID,MMOperationNo ADCustomizeLookupNo ,MMOperationName Ten FROM dbo.MMOperations WHERE AAStatus =''Alive''',N'',N'',0
INSERT INTO ADReports (AACreatedDate,AACreatedUser,AAUpdatedDate,AAUpdatedUser,AAStatus,FK_GELanguageID,ADReportNo,ADReportName,ADReportDesc,ADReportType,ADReportSection,ADReportViewType,ADReportSortOrder,ADReportCopies) SELECT 'Mar  8 2022 11:33:00:147AM',N'Admin','Mar  8 2022 11:33:00:147AM',N'',N'Alive',1,N'RPBatchProductProgress',N'Báo cáo tổng hợp tiến độ sản xuất',N'Xem tổng hợp tiến độ sản xuất',N'Produce',N'Sản xuất',N'PrintViewer',245,0
INSERT INTO ADReportTemplates (FK_ADReportID,FK_ADTemplateID) SELECT (select ADReportID from ADReports where ADReportNo = 'RPBatchProductProgress'),(select ADTemplateID from ADTemplates where ADTemplateNo = 'RPBatchProductProgress')
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'FK_ARSaleOrderID',N'Mã đơn bán hàng',N'RPBatchProductProgress',N'ARSaleOrders',N'ARSaleOrderNo',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'FK_ARProductionPlanningID',N'Mã đề nghị sản xuất',N'RPBatchProductProgress',N'ARProductionPlannings',N'ARProductionPlanningNo',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'FK_MMBatchProductID',N'Lệnh sản xuất',N'RPBatchProductProgress',N'MMBatchProducts',N'MMBatchProductNo',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ACObjectName',N'Đối tượng',N'RPBatchProductProgress',N'',N'',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'DienGiai',N'Diễn giải',N'RPBatchProductProgress',N'',N'',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'FK_MMWorkShopID',N'Xưởng',N'RPBatchProductProgress',N'MMWorkShops',N'MMWorkShopName',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'FK_MMOperationID',N'Công đoạn',N'RPBatchProductProgress',N'MMOperations',N'MMOperationName',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'M3LSX',N'M3 tinh LSX',N'RPBatchProductProgress',N'',N'',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'M3KeHoach',N'M3 tinh kế hoạch',N'RPBatchProductProgress',N'',N'',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'M3SinhThe',N'M3 tinh đã sinh thẻ',N'RPBatchProductProgress',N'',N'',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'M3NhapKho',N'M3 tinh đã nhập kho',N'RPBatchProductProgress',N'',N'',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'M3ConLai',N'M3 tinh còn lại',N'RPBatchProductProgress',N'',N'',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'SLLSX',N'SL BTP LSX',N'RPBatchProductProgress',N'',N'',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'SLKeHoach',N'SL kế hoạch',N'RPBatchProductProgress',N'',N'',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'SLSinhThe',N'SL đã sinh thẻ',N'RPBatchProductProgress',N'',N'',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'SLNhapKho',N'SL đã nhập kho',N'RPBatchProductProgress',N'',N'',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'SLConLai',N'SL còn lại',N'RPBatchProductProgress',N'',N'',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'TyLeHoanThanh',N'% Hoàn thành',N'RPBatchProductProgress',N'',N'',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'NgayGiaoDBH',N'Ngày giao ĐBH',N'RPBatchProductProgress',N'',N'',N'',N'',1,0
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RPBatchProductProgress',15,N'M3LSX'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RPBatchProductProgress',15,N'M3KeHoach'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RPBatchProductProgress',15,N'M3SinhThe'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RPBatchProductProgress',15,N'M3NhapKho'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RPBatchProductProgress',15,N'M3ConLai'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RPBatchProductProgress',4,N'SLLSX'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RPBatchProductProgress',4,N'SLKeHoach'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RPBatchProductProgress',4,N'SLSinhThe'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RPBatchProductProgress',4,N'SLNhapKho'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RPBatchProductProgress',4,N'SLConLai'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RPBatchProductProgress',4,N'TyLeHoanThanh'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RPBatchProductProgress',13,N'NgayGiaoDBH'
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'RPBatchProductProgress_GetData') DROP PROCEDURE RPBatchProductProgress_GetData
GO
CREATE PROCEDURE [dbo].[RPBatchProductProgress_GetData] 
	@FromDate			DATETIME = NULL,
	@Todate				DATETIME = NULL,
	@SaleOrderID		INT = NULL,
	@Object				NVARCHAR(50) = NULL,
	@BatchProductID		INT = NULL,
	@OperationID		INT = NULL
AS
BEGIN
	SET NOCOUNT ON;

    DECLARE @ObjectID INT = null
	DECLARE @ObjectType NVARCHAR(50) = NULL
	IF @Object is null or @Object =''
		BEGIN
		    SET @ObjectID = null
			SET @ObjectType = null
		END		
	ELSE	
		BEGIN
			SELECT TOP 1 @ObjectID = convert(int,a.splitdata) FROM dbo.fnSplitString(@Object,';') a order by a.splitdata asc 
			SELECT TOP 1 @ObjectType = convert(nvarchar(50),a.splitdata) FROM dbo.fnSplitString(@Object,';') a order by a.splitdata desc
		END
	
		SELECT	bpi.FK_ARSaleOrderID
		,	bpi.FK_ARProductionPlanningID
		,	bpi.MMBatchProductItemID
		,	bp.MMBatchProductID AS FK_MMBatchProductID
		,   so.ARObjectType
		,   so.FK_ACObjectID
		,	bp.MMBatchProductDesc AS DienGiai
		,	bp.FK_MMWorkShopID
		,	pc.FK_MMOperationID
		,	bpptn.MMBatchProductProductionNormItemBlockPerOne * bpptn.MMBatchProductProductionNormItemQuantity AS M3LSX
		,	bpptn.MMBatchProductProductionNormItemBlockPerOne * op.SLKeHoach AS M3KeHoach
		,	bpptn.MMBatchProductProductionNormItemBlockPerOne * ISNULL(opj.SLSinhThe,0) AS M3SinhThe
		,	bpptn.MMBatchProductProductionNormItemBlockPerOne * ISNULL(rc.ReceiptQty,0) AS M3NhapKho
		,	(bpptn.MMBatchProductProductionNormItemBlockPerOne * bpptn.MMBatchProductProductionNormItemQuantity) - bpptn.MMBatchProductProductionNormItemBlockPerOne * ISNULL(rc.ReceiptQty,0) AS M3ConLai
		,	bpptn.MMBatchProductProductionNormItemQuantity AS SLLSX
		,	ISNULL(op.SLKeHoach,0) AS SLKeHoach
		,	ISNULL(opj.SLSinhThe,0) AS SLSinhThe
		,	ISNULL(rc.ReceiptQty,0) AS SLNhapKho
		,	bpptn.MMBatchProductProductionNormItemQuantity - ISNULL(rc.ReceiptQty,0) AS SLConLai
		,	0 AS TyLeHoanThanh
		,	so.ARSaleOrderDeliveryDate AS NgayGiaoDBH
	 INTO #Temp
	FROM MMBatchProductItems (NOLOCK) bpi 
	INNER JOIN dbo.MMBatchProducts  (NOLOCK) bp ON bp.MMBatchProductID = bpi.FK_MMBatchProductID
	INNER JOIN	MMBatchProductProductionNormItems (NOLOCK) bpptn ON bpptn.FK_MMBatchProductItemID = bpi.MMBatchProductItemID 
																AND bpptn.MMBatchProductProductionNormItemGroup = 'SemiProduct'
																AND bpptn.AAStatus = 'Alive'
																AND  bpptn.MMBatchProductProductionNormItemQuantity > 0
	INNER JOIN dbo.MMBatchProductProductionNormItemProcesss pc ON pc.FK_MMBatchProductProductionNormItemID = bpptn.MMBatchProductProductionNormItemID
	AND pc.AAStatus = 'Alive'
	AND (ISNULL(@OperationID, 0) = 0 OR pc.FK_MMOperationID = @OperationID)
	OUTER APPLY
	(  SELECT SUM(c.MMOperationDetailPlanItemChildPlanProductQty) AS SLKeHoach
		FROM  dbo.MMOperationDetailPlanItemChilds c 
		WHERE c.FK_MMBatchProductProductionNormItemID = bpptn.MMBatchProductProductionNormItemID
		AND c.AAStatus = 'Alive'
		AND c.FK_MMOperationID = pc.FK_MMOperationID
		AND c.MMOperationDetailPlanItemChildStatus <> 'Canceled'
	) AS op 
	OUTER APPLY
	(  SELECT SUM(c.MMOperationDetailPlanItemChildPlanProductQty) AS SLSinhThe
		FROM  dbo.MMOperationDetailPlanItemChilds c 
		WHERE c.FK_MMBatchProductProductionNormItemID = bpptn.MMBatchProductProductionNormItemID
		AND c.AAStatus = 'Alive'
		AND c.FK_MMOperationID = pc.FK_MMOperationID
		AND c.MMOperationDetailPlanItemChildStatus in ('JobCreated','Closed')
	) AS opj 
	OUTER APPLY(
				SELECT  SUM(ri.ICReceiptItemProductQty) AS ReceiptQty
				FROM dbo.ICReceiptItems (NOLOCK) ri 
				LEFT JOIN dbo.ICReceipts r ON r.ICReceiptID = ri.FK_ICReceiptID
				WHERE 
					 ri.FK_MMOperationID = pc.FK_MMOperationID
					 AND ri.FK_MMBatchProductProductionNormItemID = bpptn.MMBatchProductProductionNormItemID
					 AND r.ICReceiptStatus ='Complete'
					 AND ri.AAStatus = 'Alive' 
	) AS rc
	OUTER APPLY
	(
		SELECT  so.ARObjectType, so.FK_ACObjectID, so.ARSaleOrderDeliveryDate
		FROM ARSaleOrders (NOLOCK) so 
		WHERE so.AAStatus = 'Alive' 
		AND so.ARSaleOrderID = bpi.FK_ARSaleOrderID
	) AS so
	WHERE  bp.AAStatus = 'Alive'
	AND (ISNULL(@BatchProductID, 0) = 0 OR bpi.FK_MMBatchProductID = @BatchProductID)
	AND (ISNULL(@OperationID, 0) = 0 OR pc.FK_MMOperationID = @OperationID)
	AND (@ObjectID IS NULL OR so.FK_ACObjectID = @ObjectID)
	AND (@ObjectType IS NULL OR so.ARObjectType = @ObjectType)
	AND ((@FromDate IS NULL OR	DATEDIFF(DAY, bp.MMBatchProductFromDate, @FromDate) >= 0)
	OR	(@Todate IS NULL OR DATEDIFF(DAY, bp.MMBatchProductToDate, @Todate) >= 0))
	AND (@SaleOrderID IS NULL OR bpi.FK_ARSaleOrderID = @SaleOrderID)

	SELECT t.FK_ARSaleOrderID
		,	t.FK_ARProductionPlanningID
		,	t.FK_MMBatchProductID
		,   t.ARObjectType
		,   t.FK_ACObjectID
		,	t.DienGiai
		,	t.FK_MMWorkShopID
		,	t.FK_MMOperationID
		,   t.NgayGiaoDBH
		,   t.MMBatchProductItemID
		, SUM(M3LSX) AS M3LSX
		, SUM(SLLSX) AS SLLSX
		, SUM(M3KeHoach) AS M3KeHoach
		, SUM(M3SinhThe) AS M3SinhThe
		, SUM(M3NhapKho) AS M3NhapKho
		, SUM(M3ConLai) AS M3ConLai
		, SUM(SLKeHoach) AS SLKeHoach
		, SUM(SLSinhThe) AS SLSinhThe
		, SUM(SLNhapKho) AS SLNhapKho
		, SUM(SLConLai) AS SLConLai
		
	INTO #result
	FROM #Temp t
	GROUP BY t.FK_ARSaleOrderID
		,	t.FK_ARProductionPlanningID
		,	t.FK_MMBatchProductID
		,   t.ARObjectType
		,   t.FK_ACObjectID
		,	t.DienGiai
		,	t.FK_MMWorkShopID
		,	t.FK_MMOperationID
		,   t.NgayGiaoDBH
		,   t.MMBatchProductItemID


	SELECT 
		v.ACObjectName
	,   r.FK_ARSaleOrderID
	,	r.FK_ARProductionPlanningID
	,	r.FK_MMBatchProductID
	,	r.DienGiai
	,	r.FK_MMWorkShopID
	,	r.FK_MMOperationID
	,   r.NgayGiaoDBH
	,   SUM(SLLSX) AS SLLSX
	,	SUM(M3LSX) AS M3LSX
	,	SUM(M3KeHoach) AS M3KeHoach
	,	SUM(M3SinhThe) AS M3SinhThe
	,	SUM(M3NhapKho) AS M3NhapKho
	,	SUM(M3ConLai) AS M3ConLai
	,	SUM(SLKeHoach) AS SLKeHoach
	,   SUM(SLNhapKho) AS SLNhapKho
	,	SUM(SLSinhThe) AS SLSinhThe
	,	SUM(SLConLai) AS SLConLai
	,  CASE WHEN SUM(SLLSX) = 0 THEN 1 ELSE ROUND(SUM(SLNhapKho) /SUM(SLLSX),2) * 100 END AS TyLeHoanThanh
	FROM #result r
	LEFT JOIN dbo.V_ACObjects v ON  v.ACObjectID = r.FK_ACObjectID 
					AND v.ACObjectType = r.ARObjectType
	GROUP BY 
		v.ACObjectName
	,   r.FK_ARSaleOrderID
	,	r.FK_ARProductionPlanningID
	,	r.FK_MMBatchProductID
	,	r.DienGiai
	,	r.FK_MMWorkShopID
	,	r.FK_MMOperationID
	,   r.NgayGiaoDBH
	DROP TABLE #Temp
	DROP TABLE #result

END

