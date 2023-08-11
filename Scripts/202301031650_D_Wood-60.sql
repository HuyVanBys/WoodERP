-- Delete
DELETE ADReportViewRefParams WHERE FK_ADReportViewRefID in (select ADReportViewRefID From ADReportViewRefs where ADReportViewRefNo = 'RP_FollowCreatedDocument')
DELETE ADReportViewRefs WHERE ADReportViewRefNo = 'RP_FollowCreatedDocument'
DELETE STFieldFormats WHERE STFieldFormatTableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RP_FollowCreatedDocument')
DELETE AAColumnAlias WHERE AATableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RP_FollowCreatedDocument')
DELETE ADReportTemplates WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_FollowCreatedDocument')
DELETE ADReportPermissions WHERE FK_ADReportID in (select ADReportID From ADReports where ADReportNo = 'RP_FollowCreatedDocument')
DELETE ADReports WHERE ADReportNo = 'RP_FollowCreatedDocument'
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_FollowCreatedDocument')
DELETE ADTemplates WHERE ADTemplateNo = 'RP_FollowCreatedDocument'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_FollowCreatedDocument',N'Báo cáo chi tiết chứng từ đã tạo trên phần mềm',N'Xem danh sách các chứng từ đã tạo trên phần mềm',N'RP_FollowCreatedDocument',N'Alive',N'RP_FollowCreatedDocument',1
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'FromDate',N'Từ ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_FollowCreatedDocument'),0,N'Date',N'',N'',N'',N'',N'',1
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'ToDate',N'Đến ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_FollowCreatedDocument'),1,N'Date',N'',N'',N'',N'',N'',1
INSERT INTO ADReports (AACreatedDate,AACreatedUser,AAUpdatedDate,AAUpdatedUser,AAStatus,FK_GELanguageID,ADReportNo,ADReportName,ADReportDesc,ADReportType,ADReportSection,ADReportViewType,ADReportSortOrder,ADReportCopies) SELECT 'Jan  3 2023  2:22:26:913PM',N'HoanVo','Jan  3 2023  2:22:26:913PM',N'',N'Alive',1,N'RP_FollowCreatedDocument',N'Báo cáo chi tiết chứng từ đã tạo trên phần mềm',N'Xem danh sách các chứng từ đã tạo trên phần mềm',N'Accounting',N'Hệ thống',N'PrintViewer',1,0
INSERT INTO ADReportTemplates (FK_ADReportID,FK_ADTemplateID) SELECT (select ADReportID from ADReports where ADReportNo = 'RP_FollowCreatedDocument'),(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_FollowCreatedDocument')
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'UserName',N'User tạo',N'RP_FollowCreatedDocument',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'EmployeeName',N'Tên nhân viên',N'RP_FollowCreatedDocument',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ModuleName',N'Module',N'RP_FollowCreatedDocument',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'DocumentNo',N'Mã chứng từ',N'RP_FollowCreatedDocument',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'CreateDate',N'Ngày tạo',N'RP_FollowCreatedDocument',N'',N'',N'',N'',1,1
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'RP_FollowCreatedDocument') DROP PROCEDURE RP_FollowCreatedDocument
GO

CREATE PROCEDURE [dbo].[RP_FollowCreatedDocument]
	@FromDate	DATE,
	@ToDate		DATE
AS
BEGIN
	CREATE TABLE #Doc
	(
		UserID			INT,
		UserName		NVARCHAR(100),
		TableName		NVARCHAR(100),
		DocumentID		INT,
		DocumentNo		NVARCHAR(100),
		DocumentDate	DATETIME,
		ModuleName		NVARCHAR(100)
	)

	INSERT INTO #Doc
	SELECT DISTINCT  a.ADUserID,        -- UserID - int
	    a.ADUserName,      -- UserName - nvarchar(100)
	    a.ACHistoryObjectName,      -- TableName - nvarchar(100)
	    a.ACHistoryObjectID,        -- DocumentID - int
	    a.ACHistoryObjectNo,      -- DocumentNo - nvarchar(100)
	    a.ACHistoryDate, -- DocumentDate - datetime
		''
	FROM dbo.ACHistorys a (NOLOCK)
	WHERE a.AAStatus = 'Alive' 
	AND a.ACHistoryAction = 'Create' 
	AND ISNULL(a.ACHistoryObjectNo, '') != ''
	AND DATEDIFF(DAY, @FromDate, a.ACHistoryDate) >= 0
	AND DATEDIFF(DAY, a.ACHistoryDate, @ToDate) >= 0
UNION
	SELECT DISTINCT  a.ADUserID,        -- UserID - int
	    a.ADUserName,      -- UserName - nvarchar(100)
	    a.ICHistoryObjectName,      -- TableName - nvarchar(100)
	    a.ICHistoryObjectID,        -- DocumentID - int
	    a.ICHistoryObjectNo,      -- DocumentNo - nvarchar(100)
	    a.ICHistoryDate, -- DocumentDate - datetime
		''
	FROM dbo.ICHistorys a
	WHERE a.AAStatus = 'Alive' 
	AND a.ICHistoryAction = 'Create' 
	AND ISNULL(a.ICHistoryObjectNo, '') != ''
	AND DATEDIFF(DAY, @FromDate, a.ICHistoryDate) >= 0
	AND DATEDIFF(DAY, a.ICHistoryDate, @ToDate) >= 0
UNION
	SELECT DISTINCT  a.ADUserID,        -- UserID - int
	    a.ADUserName,      -- UserName - nvarchar(100)
	    a.ADHistoryObjectName,      -- TableName - nvarchar(100)
	    a.ADHistoryObjectID,        -- DocumentID - int
	    a.ADHistoryObjectNo,      -- DocumentNo - nvarchar(100)
	    a.ADHistoryDate, -- DocumentDate - datetime
		''
	FROM dbo.ADHistorys a
	WHERE a.AAStatus = 'Alive' 
	AND a.ADHistoryAction = 'Create' 
	AND ISNULL(a.ADHistoryObjectNo, '') != ''
	AND DATEDIFF(DAY, @FromDate, a.ADHistoryDate) >= 0
	AND DATEDIFF(DAY, a.ADHistoryDate, @ToDate) >= 0
UNION
	SELECT DISTINCT  a.ADUserID,        -- UserID - int
	    a.ADUserName,      -- UserName - nvarchar(100)
	    a.APHistoryObjectName,      -- TableName - nvarchar(100)
	    a.APHistoryObjectID,        -- DocumentID - int
	    a.APHistoryObjectNo,      -- DocumentNo - nvarchar(100)
	    a.APHistoryDate, -- DocumentDate - datetime
		''
	FROM dbo.APHistorys a
	WHERE a.AAStatus = 'Alive' 
	AND a.APHistoryAction = 'Create' 
	AND ISNULL(a.APHistoryObjectNo, '') != ''
	AND DATEDIFF(DAY, @FromDate, a.APHistoryDate) >= 0
	AND DATEDIFF(DAY, a.APHistoryDate, @ToDate) >= 0
UNION
	SELECT DISTINCT  a.ADUserID,        -- UserID - int
	    a.ADUserName,      -- UserName - nvarchar(100)
	    a.ARHistoryObjectName,      -- TableName - nvarchar(100)
	    a.ARHistoryObjectID,        -- DocumentID - int
	    a.ARHistoryObjectNo,      -- DocumentNo - nvarchar(100)
	    a.ARHistoryDate, -- DocumentDate - datetime
		''
	FROM dbo.ARHistorys a
	WHERE a.AAStatus = 'Alive' 
	AND a.ARHistoryAction = 'Create' 
	AND ISNULL(a.ARHistoryObjectNo, '') != ''
	AND DATEDIFF(DAY, @FromDate, a.ARHistoryDate) >= 0
	AND DATEDIFF(DAY, a.ARHistoryDate, @ToDate) >= 0
UNION
	SELECT DISTINCT  a.ADUserID,        -- UserID - int
	    a.ADUserName,      -- UserName - nvarchar(100)
	    a.MMHistoryObjectName,      -- TableName - nvarchar(100)
	    a.MMHistoryObjectID,        -- DocumentID - int
	    a.MMHistoryObjectNo,      -- DocumentNo - nvarchar(100)
	    a.MMHistoryDate, -- DocumentDate - datetime
		''
	FROM dbo.MMHistorys a
	WHERE a.AAStatus = 'Alive' 
	AND a.MMHistoryAction = 'Create' 
	AND ISNULL(a.MMHistoryObjectNo, '') != ''
	AND DATEDIFF(DAY, @FromDate, a.MMHistoryDate) >= 0
	AND DATEDIFF(DAY, a.MMHistoryDate, @ToDate) >= 0
UNION
	SELECT DISTINCT  a.ADUserID,        -- UserID - int
	    a.ADUserName,      -- UserName - nvarchar(100)
	    a.PMHistoryObjectName,      -- TableName - nvarchar(100)
	    a.PMHistoryObjectID,        -- DocumentID - int
	    a.PMHistoryObjectNo,      -- DocumentNo - nvarchar(100)
	    a.PMHistoryDate, -- DocumentDate - datetime
		''
	FROM dbo.PMHistorys a
	WHERE a.AAStatus = 'Alive' 
	AND a.PMHistoryAction = 'Create' 
	AND ISNULL(a.PMHistoryObjectNo, '') != ''
	AND DATEDIFF(DAY, @FromDate, a.PMHistoryDate) >= 0
	AND DATEDIFF(DAY, a.PMHistoryDate, @ToDate) >= 0
UNION
	SELECT DISTINCT  a.ADUserID,        -- UserID - int
	    a.ADUserName,      -- UserName - nvarchar(100)
	    a.BRHistoryObjectName,      -- TableName - nvarchar(100)
	    a.BRHistoryObjectID,        -- DocumentID - int
	    a.BRHistoryObjectNo,      -- DocumentNo - nvarchar(100)
	    a.BRHistoryDate, -- DocumentDate - datetime
		''
	FROM dbo.BRHistorys a
	WHERE a.AAStatus = 'Alive' 
	AND a.BRHistoryAction = 'Create' 
	AND ISNULL(a.BRHistoryObjectNo, '') != ''
	AND DATEDIFF(DAY, @FromDate, a.BRHistoryDate) >= 0
	AND DATEDIFF(DAY, a.BRHistoryDate, @ToDate) >= 0
UNION
	SELECT DISTINCT  a.ADUserID,        -- UserID - int
	    a.ADUserName,      -- UserName - nvarchar(100)
	    a.VMHistoryObjectName,      -- TableName - nvarchar(100)
	    a.VMHistoryObjectID,        -- DocumentID - int
	    a.VMHistoryObjectNo,      -- DocumentNo - nvarchar(100)
	    a.VMHistoryDate, -- DocumentDate - datetime
		''
	FROM dbo.VMHistorys a
	WHERE a.AAStatus = 'Alive' 
	AND a.VMHistoryAction = 'Create' 
	AND ISNULL(a.VMHistoryObjectNo, '') != ''
	AND DATEDIFF(DAY, @FromDate, a.VMHistoryDate) >= 0
	AND DATEDIFF(DAY, a.VMHistoryDate, @ToDate) >= 0

----select module name-----
	UPDATE a
	SET a.ModuleName = SUBSTRING(a.TableName, 3, LEN(a.TableName) - 3)
	FROM #Doc a

	-----Ngoại lệ-----
	UPDATE a
	SET a.ModuleName = N'CustomerPaymentTimePayment'
	FROM #Doc a
	WHERE a.ModuleName = 'CustomerPayment'

	UPDATE a
	SET a.ModuleName = N'Chi phí bán hàng/ mua hàng/ Nghiệp vụ tổng hợp'
	FROM #Doc a
	WHERE a.ModuleName = 'Document'

	UPDATE a
	SET a.ModuleName = N'Hóa đơn điện tử'
	FROM #Doc a
	WHERE a.ModuleName = 'EInvoiceGeneral'

	UPDATE a
	SET a.ModuleName = N'Processs'
	FROM #Doc a
	WHERE a.ModuleName = 'Process'
	
	UPDATE a
	SET a.ModuleName = N'Kế hoạch sử dụng NPL/ Kế hoạch SD thông thường'
	FROM #Doc a
	WHERE a.ModuleName = 'AllocationPlan'
	
	SELECT k.UserName					AS UserName
	,	ISNULL(e.HREmployeeName, '')	AS EmployeeName
	,	ISNULL(md.STModuleDescriptionDescription, k.ModuleName)					AS ModuleName
	,	k.DocumentNo					AS DocumentNo
	,	k.DocumentDate					AS CreateDate
	FROM #Doc k
	LEFT JOIN dbo.ADUsers u ON u.ADUserID = k.UserID
	LEFT JOIN dbo.HREmployees e ON e.HREmployeeID = u.FK_HREmployeeID
	LEFT JOIN dbo.STModules m ON m.AAStatus = 'Alive' AND REPLACE(m.STModuleName, ' ', '') = REPLACE(k.ModuleName, ' ', '')
	LEFT JOIN dbo.STModuleDescriptions md ON md.STModuleID = m.STModuleID AND ISNULL(md.STLanguageID, 0) <= 1
	ORDER BY k.DocumentDate

	DROP TABLE #Doc
-----------
END

