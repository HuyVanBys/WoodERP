-- Delete
DELETE ADReportViewRefParams WHERE FK_ADReportViewRefID in (select ADReportViewRefID From ADReportViewRefs where ADReportViewRefNo = 'RP_AssembleProductSeries')
DELETE ADReportViewRefs WHERE ADReportViewRefNo = 'RP_AssembleProductSeries'
DELETE STFieldFormats WHERE STFieldFormatTableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RP_AssembleProductSeries')
DELETE AAColumnAlias WHERE AATableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RP_AssembleProductSeries')
DELETE ADReportTemplates WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_AssembleProductSeries')
DELETE ADReportPermissions WHERE FK_ADReportID in (select ADReportID From ADReports where ADReportNo = 'RP_AssembleProductSeries')
DELETE ADReports WHERE ADReportNo = 'RP_AssembleProductSeries'
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_AssembleProductSeries')
DELETE ADTemplates WHERE ADTemplateNo = 'RP_AssembleProductSeries'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_AssembleProductSeries',N'Báo cáo danh sách đóng kiện',N'Xem báo cáo danh sách đóng kiện',N'RP_AssembleProductSeries',N'Alive',N'RP_AssembleProductSeries',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'FromDate',N'Từ ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_AssembleProductSeries'),0,N'Date',N'',N'',N'',N'',N'',1
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'ToDate',N'Đến ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_AssembleProductSeries'),1,N'Date',N'',N'',N'',N'',N'',1
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'DepartmentID',N'Ngành hàng',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_AssembleProductSeries'),2,N'Number',N'ICDepartments',N'',N'AAStatus = ''Alive''',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'ICProductConversionType',N'Loại',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_AssembleProductSeries'),3,N'String',N'ICProductConversions',N'',N'',N'',N'',0
INSERT INTO ADReports (AACreatedDate,AACreatedUser,AAUpdatedDate,AAUpdatedUser,AAStatus,FK_GELanguageID,ADReportNo,ADReportName,ADReportDesc,ADReportType,ADReportSection,ADReportViewType,ADReportSortOrder,ADReportCopies) SELECT 'Nov 29 2022 12:34:52:727PM',N'Import','Nov 29 2022 12:34:52:727PM',N'',N'Alive',1,N'RP_AssembleProductSeries',N'Báo cáo danh sách đóng kiện',N'Xem báo cáo danh sách đóng kiện',N'Inventory',N'Kho',N'PrintViewer',333337,0
INSERT INTO ADReportTemplates (FK_ADReportID,FK_ADTemplateID) SELECT (select ADReportID from ADReports where ADReportNo = 'RP_AssembleProductSeries'),(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_AssembleProductSeries')
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'MaChungTu',N'Mã chứng từ',N'RP_AssembleProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'NgayChungTu',N'Ngày chứng từ',N'RP_AssembleProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'LoaiChungTu',N'Loại chứng từ',N'RP_AssembleProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'MaSanPham',N'Mã sản phẩm',N'RP_AssembleProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'TenSanPham',N'Tên sản phẩm',N'RP_AssembleProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'MaKien',N'Mã kiện/ mã lô đích',N'RP_AssembleProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'DoDay',N'Dày',N'RP_AssembleProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'Rong',N'Rộng',N'RP_AssembleProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ChieuDai',N'Dài',N'RP_AssembleProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'SoThanh',N'SL Thanh',N'RP_AssembleProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'M3',N'm3',N'RP_AssembleProductSeries',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'NhaCungCap',N'Nhà cung cấp',N'RP_AssembleProductSeries',N'',N'',N'',N'',1,1
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_AssembleProductSeries',13,N'NgayChungTu'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_AssembleProductSeries',1,N'DoDay'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_AssembleProductSeries',1,N'Rong'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_AssembleProductSeries',1,N'ChieuDai'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_AssembleProductSeries',1,N'SoThanh'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_AssembleProductSeries',15,N'M3'
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'RP_AssembleProductSeries') DROP PROCEDURE RP_AssembleProductSeries
GO
CREATE PROCEDURE [dbo].[RP_AssembleProductSeries]
	@FromDate					DATE,
	@ToDate						DATE,
	@DepartmentID				INT = NULL,
	@ICProductConversionType	VARCHAR(100) = NULL
AS
BEGIN
	SET NOCOUNT ON;

	CREATE TABLE #Result
	(
		MaChungTu	NVARCHAR(100),
		NgayChungTu	DATE,
		LoaiChungTu	NVARCHAR(500),
		MaSanPham	NVARCHAR(100),
		TenSanPham	NVARCHAR(1000),
		MaKien		NVARCHAR(100),
		DoDay		DECIMAL(18,5),
		Rong		DECIMAL(18,5),
		ChieuDai	DECIMAL(18,5),
		SoThanh		DECIMAL(18,5),
		M3			DECIMAL(18,5),
		NhaCungCap	NVARCHAR(1000)
	)
	
	INSERT INTO #Result
	SELECT	i.ICProductConversionNo
		,	i.ICProductConversionDate
		,	ISNULL(a.ADConfigText, '')
		,	p.ICProductNo
		,	p.ICProductName
		,	ic.ICProductConversionItemProductSerialNo
		,	ic.ICProductConversionItemProductHeight
		,	ic.ICProductConversionItemProductWidth
		,	ic.ICProductConversionItemProductLength
		,	ic.ICProductConversionItemWoodQty
		,	ic.ICProductConversionItemProductQty
		,	ISNULL(n1.NCC, ISNULL(n2.NCC, ''))
	FROM dbo.ICProductConversionItems ic (NOLOCK)
	INNER JOIN dbo.ICProductConversions i (NOLOCK) ON i.AAStatus = 'Alive' AND i.ICProductConversionID = ic.FK_ICProductConversionID
	INNER JOIN dbo.ICProducts p (NOLOCK) ON p.AAStatus = 'Alive' AND p.ICProductID = ic.FK_ICProductID
	LEFT JOIN dbo.ADConfigValues a (NOLOCK) ON a.AAStatus = 'Alive' AND a.ADConfigKeyGroup = 'ProductConversionType' AND i.ICProductConversionType = a.ADConfigKeyValue 
	OUTER APPLY
	(
		SELECT STUFF((SELECT DISTINCT ', ' + v.ACObjectName 
						FROM [dbo].[ICProductConversionItems] pv (NOLOCK)
							INNER JOIN dbo.ICTransactions t (NOLOCK) ON t.AAStatus = 'Alive' AND t.ICTransactionType = 1 
																	AND t.ICTransactionModuleName = 'PurchaseReceipt'
																	AND t.FK_ICProductID = pv.FK_ICProductID
																	AND t.ICTransactionReceiptSerialNo = pv.ICProductConversionItemProductSerialNo
							INNER JOIN dbo.V_ACObjects v ON v.ACObjectID = t.FK_ACObjectID AND v.ACObjectType = t.ACObjectType
						WHERE pv.AAStatus = 'Alive'
							AND pv.VirtualID = ic.VirtualParentID
						FOR XML PATH('')), 1, 2, '') as NCC
	) AS n1
	OUTER APPLY
	(
		SELECT STUFF((SELECT DISTINCT ', ' + v.ACObjectName 
						FROM [dbo].[ICProductConversionItems] pv (NOLOCK)
							INNER JOIN dbo.ICTransactions t (NOLOCK) ON t.AAStatus = 'Alive' AND t.ICTransactionType = 1 
																	AND t.ICTransactionModuleName = 'PurchaseReceipt'
																	AND t.FK_ICProductID = pv.FK_ICProductID
																	AND t.ICTransactionReceiptSerialNo = pv.ICProductConversionItemProductSerialNo
							INNER JOIN dbo.V_ACObjects v ON v.ACObjectID = t.FK_ACObjectID AND v.ACObjectType = t.ACObjectType
						WHERE pv.AAStatus = 'Alive'
							AND pv.VirtualParentID = ic.VirtualID
						FOR XML PATH('')), 1, 2, '') as NCC
	) AS n2
	WHERE ic.AAStatus = 'Alive'
	AND ic.ICProductConversionItemType = 'Target'
	AND	DATEDIFF(DAY, @FromDate, i.ICProductConversionDate) >= 0
	AND	DATEDIFF(DAY, i.ICProductConversionDate, @ToDate) >= 0
	AND (ISNULL(@DepartmentID, 0) = 0 OR @DepartmentID = p.FK_ICDepartmentID)
	AND (ISNULL(@ICProductConversionType, '') = '' OR @ICProductConversionType = i.ICProductConversionType)

----------Return----------
	SELECT	r.*
		,	FORMAT(r.DoDay, 'N0') + 'x' + FORMAT(r.Rong, 'N0') + 'x' + FORMAT(r.ChieuDai, 'N0') AS MaPhoi
		,	FORMAT(r.NgayChungTu, 'dd/MM/yyyy') AS NgayDong
	FROM #Result r

	SELECT N'Từ ngày ' + FORMAT(@FromDate, 'dd/MM/yyyy') + N' đến ngày ' + FORMAT(@ToDate, 'dd/MM/yyyy') AS TuNgayDenNgay
		,	N'Ngày ' + FORMAT(GETDATE(), 'dd') + N' tháng ' + FORMAT(GETDATE(), 'MM') + N' năm ' + FORMAT(GETDATE(), 'yyyy') AS NgayBaoCao
	DROP TABLE #Result

END
