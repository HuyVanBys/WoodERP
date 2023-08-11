-- Delete
DELETE ADReportViewRefParams WHERE FK_ADReportViewRefID in (select ADReportViewRefID From ADReportViewRefs where ADReportViewRefNo = 'RP_BillOfLadings')
DELETE ADReportViewRefs WHERE ADReportViewRefNo = 'RP_BillOfLadings'
DELETE STFieldFormats WHERE STFieldFormatTableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RP_BillOfLadings')
DELETE AAColumnAlias WHERE AATableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RP_BillOfLadings')
DELETE ADReportTemplates WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_BillOfLadings')
DELETE ADReportPermissions WHERE FK_ADReportID in (select ADReportID From ADReports where ADReportNo = 'RP_BillOfLadings')
DELETE ADReports WHERE ADReportNo = 'RP_BillOfLadings'
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_BillOfLadings')
DELETE ADTemplates WHERE ADTemplateNo = 'RP_BillOfLadings'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_BillOfLadings',N'Danh sách tờ khai hải quan thông qua dùng hoàn thuế',N'Danh sách tờ khai hải quan thông qua dùng hoàn thuế',N'RP_BillOfLadings',N'Alive',N'RP_BillOfLadings',1
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'fromDate',N'Từ ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_BillOfLadings'),0,N'Datetime',N'',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'toDate',N'Đến ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_BillOfLadings'),1,N'Datetime',N'',N'',N'',N'',N'',0
INSERT INTO ADReportTemplates (FK_ADReportID,FK_ADTemplateID) SELECT (select ADReportID from ADReports where ADReportNo = 'RP_BillOfLadings'),(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_BillOfLadings')
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APBillOfLadingDeclarationNumber',N'Số tờ khai',N'RP_BillOfLadings',N'',N'',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APBillOfLadingRegisDate',N'Ngày đăng ký',N'RP_BillOfLadings',N'',N'',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'GECountryName',N'Nước nhập khẩu',N'RP_BillOfLadings',N'',N'',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APBillOfLadingItemTotalCost',N'Trị giá ngoại tệ',N'RP_BillOfLadings',N'',N'',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APBillOfLadingItemTotalCostExchange',N'Trị giá (VND)',N'RP_BillOfLadings',N'',N'',N'',N'',1,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APBillOfLadingType',N'Mã loại hình',N'RP_BillOfLadings',N'',N'',N'',N'',1,0
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName,STChangeByCurrency,STChangeByDepartment) SELECT N'Report',N'RP_BillOfLadings',14,N'APBillOfLadingItemTotalCost',0,0
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName,STChangeByCurrency,STChangeByDepartment) SELECT N'Report',N'RP_BillOfLadings',1,N'APBillOfLadingItemTotalCostExchange',0,0
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'RP_BillOfLadings') DROP PROCEDURE RP_BillOfLadings
GO
-- Stored Procedure

CREATE PROCEDURE [dbo].[RP_BillOfLadings]
   @FromDate datetime,
   @ToDate datetime
AS
BEGIN
	set nocount on;

	Select 
		b.APBillOfLadingDeclarationNumber,
		b.APBillOfLadingRegisDate,
		isnull(country.GECountryName,'') as GECountryName,
		Sum(bi.APBillOfLadingItemTotalCost) as APBillOfLadingItemTotalCost,
		SUm(bi.APBillOfLadingItemTotalCostExchange) as APBillOfLadingItemTotalCostExchange,
		CONCAT(cast(Month(b.APBillOfLadingRegisDate) as varchar(10)),'/', cast(Year(b.APBillOfLadingRegisDate) as varchar(10))) as Month,
		isnull(lh.ADConfigText, '') as APBillOfLadingType
	from APBillOfLadings b
	inner join APBillOfLadingItems bi on b.APBillOfLadingID = bi.FK_APBillOfLadingID
	Outer Apply
		(
			Select c.GECountryName from APInvoiceIns ii
			inner join GECountrys c on ii.FK_GECountryID = c.GECountryID and c.AAStatus = 'Alive'
			Where ii.AAStatus = 'Alive'
			and b.FK_APInvoiceInID = ii.APInvoiceInID
			) country
	left join ADConfigValues lh on lh.AAStatus = 'Alive' and lh.ADConfigKeyGroup = 'BillOfLadingType' and lh.ADConfigKeyValue = b.APBillOfLadingType
	Where b.AAStatus = 'Alive'
		and bi.AAStatus = 'Alive'
		and DateDiff(dd, @FromDate, b.APBillOfLadingRegisDate) >= 0
		and DATEDIFF(dd, b.APBillOfLadingRegisDate, @ToDate) >= 0
		and b.APBillOfLadingImportExportType = 'Import'
		and APBillOfLadingStatus = 'Complete'	
	Group by
		b.APBillOfLadingDeclarationNumber,
		b.APBillOfLadingRegisDate,
		country.GECountryName,
		lh.ADConfigText

	Select @FromDate as FromDate, @ToDate as ToDate, * from ThongTinCty(1)
END
