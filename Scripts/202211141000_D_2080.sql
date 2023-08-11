-- Delete
DELETE ADReportViewRefParams WHERE FK_ADReportViewRefID in (select ADReportViewRefID From ADReportViewRefs where ADReportViewRefNo = 'RP_ClearInvoiceDetail')
DELETE ADReportViewRefs WHERE ADReportViewRefNo = 'RP_ClearInvoiceDetail'
DELETE STFieldFormats WHERE STFieldFormatTableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RP_ClearInvoiceDetail')
DELETE AAColumnAlias WHERE AATableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RP_ClearInvoiceDetail')
DELETE ADReportTemplates WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_ClearInvoiceDetail')
DELETE ADReportPermissions WHERE FK_ADReportID in (select ADReportID From ADReports where ADReportNo = 'RP_ClearInvoiceDetail')
DELETE ADReports WHERE ADReportNo = 'RP_ClearInvoiceDetail'
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_ClearInvoiceDetail')
DELETE ADTemplates WHERE ADTemplateNo = 'RP_ClearInvoiceDetail'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_ClearInvoiceDetail',N'Báo cáo chi tiết Phân bổ tiền cho hóa đơn bán hàng',N'Xem thông tin chi tiết Phân bổ tiền cho hóa đơn bán hàng',N'RP_ClearInvoiceDetail',N'Alive',N'RP_ClearInvoiceDetail',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'FromDate',N'Từ ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_ClearInvoiceDetail'),0,N'Date',N'',N'',N'',N'',N'',1
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'ToDate',N'Đến ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_ClearInvoiceDetail'),1,N'Date',N'',N'',N'',N'',N'',1
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'ObjectAccessKey',N'Đối tượng',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_ClearInvoiceDetail'),2,N'Text',N'ACObjects',N'',N'',N'',N'',0
INSERT INTO ADReports (AACreatedDate,AACreatedUser,AAUpdatedDate,AAUpdatedUser,AAStatus,FK_GELanguageID,ADReportNo,ADReportName,ADReportDesc,ADReportType,ADReportSection,ADReportViewType,ADReportSortOrder,ADReportCopies) SELECT 'Nov 14 2022  8:23:51:047AM',N'Import','Nov 14 2022  8:23:51:047AM',N'',N'Alive',1,N'RP_ClearInvoiceDetail',N'Báo cáo chi tiết Phân bổ tiền cho hóa đơn bán hàng',N'Xem thông tin chi tiết Phân bổ tiền cho hóa đơn bán hàng',N'Accounting',N'Bán hàng',N'PrintViewer',338,0
INSERT INTO ADReportTemplates (FK_ADReportID,FK_ADTemplateID) SELECT (select ADReportID from ADReports where ADReportNo = 'RP_ClearInvoiceDetail'),(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_ClearInvoiceDetail')
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'MaChungTu',N'Mã chứng từ PBTCHDBH',N'RP_ClearInvoiceDetail',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'MaHoaDon',N'Mã chứng từ được phân bổ',N'RP_ClearInvoiceDetail',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'NgayHoaDon',N'Ngày chứng từ được phân bổ',N'RP_ClearInvoiceDetail',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'SoHoaDon',N'Số hóa đơn được phân bổ',N'RP_ClearInvoiceDetail',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'LoaiTienTe',N'Loại tiền tệ hóa đơn',N'RP_ClearInvoiceDetail',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'TyGia',N'Tỷ giá chứng từ được phân bổ',N'RP_ClearInvoiceDetail',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'TienHoaDon',N'Thành tiền chứng từ được phân bổ',N'RP_ClearInvoiceDetail',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'MaCTPB',N'Mã chứng từ phân bổ',N'RP_ClearInvoiceDetail',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'NgayCTPB',N'Ngày chứng từ phân bổ',N'RP_ClearInvoiceDetail',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'LoaiTienTeCTPB',N'Loại tiền tệ chứng từ được phân bổ',N'RP_ClearInvoiceDetail',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'TyGiaCTPB',N'Tỷ giá chứng từ được phân bổ',N'RP_ClearInvoiceDetail',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'TienCTPB',N'Thành tiền chứng từ phân bổ',N'RP_ClearInvoiceDetail',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'TienPhanBo',N'Tiền phân bổ',N'RP_ClearInvoiceDetail',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'MaDoiTuong',N'Mã đối tượng',N'RP_ClearInvoiceDetail',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'TenDoiTuong',N'Tên đối tượng',N'RP_ClearInvoiceDetail',N'',N'',N'',N'',1,1
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_ClearInvoiceDetail',13,N'NgayHoaDon'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_ClearInvoiceDetail',13,N'NgayCTPB'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_ClearInvoiceDetail',8,N'TyGia'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_ClearInvoiceDetail',8,N'TienHoaDon'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_ClearInvoiceDetail',8,N'TyGiaCTPB'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_ClearInvoiceDetail',8,N'TienCTPB'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_ClearInvoiceDetail',8,N'TienPhanBo'
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'RP_ClearInvoiceDetail') DROP PROCEDURE RP_ClearInvoiceDetail
GO
CREATE PROCEDURE [dbo].[RP_ClearInvoiceDetail]
	@FromDate			DATETIME
,	@ToDate				DATETIME 
,	@ObjectAccessKey	VARCHAR(100) = NULL
AS
BEGIN
	DECLARE @ObjectID int = null
	DECLARE @ObjectType nvarchar(50) = NULL

    IF(CHARINDEX(';',@ObjectAccessKey)> 0)
		SET @ObjectID = CONVERT(INT,(SELECT SUBSTRING(@ObjectAccessKey,0,CHARINDEX(';',@ObjectAccessKey))))
		SET @ObjectType = (SELECT SUBSTRING(@ObjectAccessKey,CHARINDEX(';',@ObjectAccessKey)+1,LEN(@ObjectAccessKey) - CHARINDEX(';',@ObjectAccessKey)))
	
	CREATE TABLE #Result
	(
		MaChungTu	NVARCHAR(100),
		NgayChungTu	DATE,
		MaDoiTuong	NVARCHAR(100),
		TenDoiTuong	NVARCHAR(1000),
		MaHoaDon	NVARCHAR(100),
		NgayHoaDon	DATE,
		SoHoaDon	NVARCHAR(100),
		IDLoaiTienTe	INT,
		TyGia		DECIMAL(18,6),
		TienHoaDon	DECIMAL(18,6),
		MaCTPB	NVARCHAR(100),
		--NgayCTPB	DATE,
		IDLoaiTienTeCTPB	INT,
		TyGiaCTPB		DECIMAL(18,6),
		TienCTPB	DECIMAL(18,6),
		TienPhanBo	DECIMAL(18,6)
	)
	
	INSERT INTO #Result
	SELECT	i.ARClearInvoiceNo
		,	i.ARClearInvoiceDate
		,	v.ACObjectNo
		,	v.ACObjectName
		,	iv.ARClearInvoiceInvoiceNo
		,	iv.ARClearInvoiceInvoiceDate
		,	iv.ARClearInvoiceInvoiceNumber
		,	iv.FK_GECurrencyID
		,	iv.ARClearInvoiceInvoiceExchangeRate
		,	iv.ARClearInvoiceInvoiceAmount
		,	id.ARClearInvoiceDocumentNo
		,	id.FK_GECurrencyID
		,	id.ARClearInvoiceDocumentExchangeRate
		,	id.ARClearInvoiceDocumentAmount
		,	iv.ARClearInvoiceInvoiceAllocationAmount
	FROM dbo.ARClearInvoiceInvoices iv (NOLOCK)
	INNER JOIN dbo.ARClearInvoices i (NOLOCK) ON i.ARClearInvoiceID = iv.FK_ARClearInvoiceID AND i.AAStatus = 'Alive'
	INNER JOIN dbo.ARClearInvoiceDocuments id (NOLOCK) ON id.FK_ARClearInvoiceID = i.ARClearInvoiceID AND id.AAStatus = 'Alive'
	LEFT JOIN dbo.V_ACObjects v ON v.ACObjectID = i.FK_ACObjectID AND v.ACObjectType = i.ARObjectType
	WHERE	iv.AAStatus = 'Alive'
		AND	(ISNULL(@ObjectID, 0) = 0 OR @ObjectID = i.FK_ACObjectID)
		AND	(ISNULL(@ObjectType, '') = '' OR @ObjectType = i.ARObjectType)
		AND	DATEDIFF(DAY, @FromDate, i.ARClearInvoiceDate) >= 0
		AND	DATEDIFF(DAY, i.ARClearInvoiceDate, @ToDate) >= 0
		
----------Return----------
	SELECT	r.*
		,	g1.GECurrencyNo AS LoaiTienTe
		,	g2.GECurrencyNo	AS LoaiTienTeCTPB
		,	n.ACTransactionDate AS NgayCTPB
	FROM #Result r
	LEFT JOIN dbo.GECurrencies g1 ON g1.GECurrencyID = r.IDLoaiTienTe
	LEFT JOIN dbo.GECurrencies g2 ON g2.GECurrencyID = r.IDLoaiTienTeCTPB
	OUTER APPLY
	(
		SELECT TOP 1 c.ACTransactionDate
		FROM dbo.ACTransactions c
		WHERE c.AAStatus = 'Alive'
		AND c.ACTransactionNo = r.MaCTPB
	) AS n

	DROP TABLE #Result

END


