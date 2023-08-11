-- Delete
DELETE ADReportViewRefParams WHERE FK_ADReportViewRefID in (select ADReportViewRefID From ADReportViewRefs where ADReportViewRefNo = 'RP_GetAPInvoiceItemsList')
DELETE ADReportViewRefs WHERE ADReportViewRefNo = 'RP_GetAPInvoiceItemsList'
DELETE STFieldFormats WHERE STFieldFormatTableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RP_GetAPInvoiceItemsList')
DELETE AAColumnAlias WHERE AATableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RP_GetAPInvoiceItemsList')
DELETE ADReportTemplates WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_GetAPInvoiceItemsList')
DELETE ADReportPermissions WHERE FK_ADReportID in (select ADReportID From ADReports where ADReportNo = 'RP_GetAPInvoiceItemsList')
DELETE ADReports WHERE ADReportNo = 'RP_GetAPInvoiceItemsList'
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_GetAPInvoiceItemsList')
DELETE ADTemplates WHERE ADTemplateNo = 'RP_GetAPInvoiceItemsList'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_GetAPInvoiceItemsList',N'Danh sách hàng theo hoá đơn',N'Danh sách hàng theo hoá đơn',N'RP_GetAPInvoiceItemsList',N'Alive',N'RP_GetAPInvoiceItemsList',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'FromDate',N'Từ ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_GetAPInvoiceItemsList'),0,N'Date',N'',N'',N'',NULL,NULL,0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'ToDate',N'Đến ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_GetAPInvoiceItemsList'),1,N'Date',N'',N'',N'',NULL,NULL,0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'ObjectType',N'Nhà cung cấp',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_GetAPInvoiceItemsList'),2,N'Text',N'ACObjects',N'',N'',NULL,NULL,0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'FK_BRBranchID',N'Chi nhánh',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_GetAPInvoiceItemsList'),3,N'Number',N'BRBranchs',N'',N'',NULL,NULL,0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'FK_HREmployeeID',N'Nhân viên tạo',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_GetAPInvoiceItemsList'),4,N'Number',N'HREmployees',N'',N'',NULL,NULL,0
INSERT INTO ADReports (AACreatedDate,AACreatedUser,AAUpdatedDate,AAUpdatedUser,AAStatus,FK_GELanguageID,ADReportNo,ADReportName,ADReportDesc,ADReportType,ADReportSection,ADReportViewType,ADReportSortOrder,ADReportCopies) SELECT 'Apr 10 2020  4:21:44:977PM',N'BAOLE','Apr 10 2020  4:21:44:977PM',N'BAOLE',N'Alive',0,N'RP_GetAPInvoiceItemsList',N'Danh sách hàng theo hoá đơn',N'Xem danh sách hàng theo hóa đơn',N'Purchasing',N'Mua hàng',N'PrintViewer',409,0
INSERT INTO ADReportTemplates (FK_ADReportID,FK_ADTemplateID) SELECT (select ADReportID from ADReports where ADReportNo = 'RP_GetAPInvoiceItemsList'),(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_GetAPInvoiceItemsList')
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICProductNo',N'Mã sản phẩm',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemProductDesc',N'Mô tả',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemProductTaxPercent',N'% thuế',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemProductQty',N'Số lượng',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemTaxAmount',N'Tiền thuế',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICProductGroupName',N'Nhóm hàng',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemProductUnitCost',N'Đơn giá',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemTotalCost',N'Thành tiền',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemExtCost',N'Tổng giá mua',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICMeasureUnitName',N'ĐVT',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemProductDiscount',N'% CK',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemDiscountAmount',N'Tiền chiết khấu',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemReceiptedQty',N'Số lượng đã nhận',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemProductSupplierNo',N'Mã sản phẩm NCC',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemProductSerialNo',N'Mã đầu lóng',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemComment',N'Ghi chú',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemLogListNo',N'Số log list',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemLotNo',N'Lô sản phẩm',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemProductLength',N'Dài(mm)',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemProductPerimeter',N'Hoành (mm)',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemContainerNo',N'Container No',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemWoodQty',N'Khối lượng',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemQty1',N'Số lượng đã nhận',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemHasProductPackage',N'Đóng kiện',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemProductExchangeQty',N'SL quy đổi',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInItemProductFactor',N'Hệ số',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInNo',N'Mã hóa đơn',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ARSaleOrderNo',N'Mã đơn mua hàng',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ACObjectName',N'Tên NCC',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ACObjectNo',N'Mã NCC',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ACObjectContactPhone',N'SĐT',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ACObjectContactAddressLine3',N'Địa chỉ NCC',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'BRBranchName',N'Chi nhánh',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APInvoiceInDate',N'Ngày hóa đơn',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'InvoiceInStatus',N'Tình trạng hóa đơn',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'HREmployeeName',N'Tên nhân viên',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'HREmployeeNo',N'Mã nhân viên',N'RP_GetAPInvoiceItemsList',N'',N'',N'',N'',0,NULL
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_GetAPInvoiceItemsList',4,N'APInvoiceInItemProductTaxPercent'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_GetAPInvoiceItemsList',10,N'APInvoiceInItemProductQty'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_GetAPInvoiceItemsList',1,N'APInvoiceInItemTaxAmount'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_GetAPInvoiceItemsList',1,N'APInvoiceInItemProductUnitCost'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_GetAPInvoiceItemsList',1,N'APInvoiceInItemTotalCost'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_GetAPInvoiceItemsList',1,N'APInvoiceInItemExtCost'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_GetAPInvoiceItemsList',4,N'APInvoiceInItemProductDiscount'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_GetAPInvoiceItemsList',1,N'APInvoiceInItemDiscountAmount'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_GetAPInvoiceItemsList',10,N'APInvoiceInItemReceiptedQty'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_GetAPInvoiceItemsList',10,N'APInvoiceInItemProductLength'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_GetAPInvoiceItemsList',10,N'APInvoiceInItemProductPerimeter'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_GetAPInvoiceItemsList',10,N'APInvoiceInItemWoodQty'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_GetAPInvoiceItemsList',10,N'APInvoiceInItemQty1'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_GetAPInvoiceItemsList',10,N'APInvoiceInItemProductExchangeQty'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_GetAPInvoiceItemsList',4,N'APInvoiceInItemProductFactor'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP_GetAPInvoiceItemsList',13,N'APInvoiceInDate'
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'RP_GetAPInvoiceItemsList') DROP PROCEDURE RP_GetAPInvoiceItemsList
GO
CREATE PROC [dbo].[RP_GetAPInvoiceItemsList]
	@FromDate DATE ,
	@ToDate DATE ,
	@ObjectType NVARCHAR(50),
	@FK_BRBranchID INT,
	@FK_HREmployeeID INT
 --========================
 -- Author : Bao Le
 -- Date:	10-04-2020
 -- Edit by: Binh.Le
 -- Description: Danh sách hàng theo hoá đơn
--=========================
 AS
 BEGIN


set nocount on;
	declare @ObjectID int = null
	If @ObjectType is null or @ObjectType =''
	Begin
		set @ObjectID = null
		set @ObjectType = null
	End
	Else
	Begin
	select top 1 @ObjectID = convert(int,a.splitdata) from dbo.fnSplitString(@ObjectType,';') a order by a.splitdata asc 
	select top 1 @ObjectType = convert(nvarchar(50),a.splitdata) from dbo.fnSplitString(@ObjectType,';') a order by a.splitdata desc
	End
---===========================

SELECT p.ICProductNo,                     -- Mã sản phẩm
       APInvoiceInItemProductDesc,         -- Mô tả
       APInvoiceInItemProductTaxPercent,   -- % thuế
       APInvoiceInItemProductQty,          -- Số lượng
       APInvoiceInItemTaxAmount,           -- Tiền thuế
       (SELECT ICProductGroupName FROM dbo.ICProductGroups WHERE ICProductGroupID = ii.FK_ICProductGroupID) AS ICProductGroupName,                -- Nhóm hàng
       APInvoiceInItemProductUnitCost,     -- Đơn giá
       APInvoiceInItemTotalCost,           -- Thành tiền
       APInvoiceInItemExtCost,             -- Tổng giá mua
       m.ICMeasureUnitName,                 -- Đơn vị tính
       APInvoiceInItemProductDiscount,     -- % CK
       APInvoiceInItemDiscountAmount,      -- Tiền chiết khấu
       APInvoiceInItemReceiptedQty,        -- Số lượng đã nhận
       APInvoiceInItemProductSupplierNo,   -- Mã sản phẩm NCC
       APInvoiceInItemProductSerialNo,     -- Mã đầu lóng
       APInvoiceInItemComment,             -- Ghi chú
       APInvoiceInItemLogListNo,           -- Số log list
       APInvoiceInItemLotNo,               -- Lô sản phẩm
       APInvoiceInItemProductLength,       -- Dài(mm)
       APInvoiceInItemProductPerimeter,    -- Hoành (mm)
       APInvoiceInItemContainerNo,         -- Container No
       APInvoiceInItemWoodQty,             -- Khối lượng
       APInvoiceInItemQty1,                -- Số lượng đã nhận
       APInvoiceInItemHasProductPackage,   -- Đóng kiện
       APInvoiceInItemProductExchangeQty,  -- SL quy đổi
       APInvoiceInItemProductFactor,       -- Hệ số
       i.APInvoiceInNo,                   -- Mã hóa đơn
       --(SELECT ARSaleOrderNo FROM dbo.ARSaleOrders WHERE ARSaleOrderID = FK_ARSaleOrderID) AS ARSaleOrderNo,                   -- Đơn bán hàng
	   (SELECT ISNULL(APPurchaseOrderNo,'') FROM dbo.APPurchaseOrders po WHERE APPurchaseOrderID = ii.FK_APPurchaseOrderID AND po.AAStatus = 'Alive') AS APPurchaseOrderNo,       
	   ob.ACObjectName,
	   ob.ACObjectNo,
	   ob.ACObjectContactPhone,
	   ob.ACObjectContactAddressLine3,
	   (SELECT BRBranchName FROM dbo.BRBranchs WHERE BRBranchID = i.FK_BRBranchID) AS BRBranchName,
	   i.APInvoiceInDate,
	   (SELECT ADConfigText FROM dbo.ADConfigValues WHERE ADConfigKeyGroup = 'InvoiceInStatus' AND ADConfigKeyValue = i.APInvoiceInStatus) AS InvoiceInStatus,
	   h.HREmployeeName ---Tên nhân viên
	   
FROM dbo.APInvoiceInItems ii
    INNER JOIN dbo.APInvoiceIns i
        ON i.APInvoiceInID = ii.FK_APInvoiceInID
    LEFT JOIN dbo.ICProducts p
        ON p.ICProductID = ii.FK_ICProductID
	LEFT JOIN dbo.ICMeasureUnits m 
		ON m.ICMeasureUnitID = ii.FK_ICMeasureUnitID
	LEFT JOIN dbo.V_ACObjects ob
		ON i.FK_ACAssObjectID = ob.ACObjectID AND i.APAssObjectType = ob.ACObjectType
	LEFT JOIN dbo.HREmployees h ON h.HREmployeeID = i.FK_HREmployeeID
WHERE ii.AAStatus = 'Alive'
	AND DATEDIFF(DAY,@FromDate,i.APInvoiceInDate) >= 0
	AND DATEDIFF(DAY,i.APInvoiceInDate,@ToDate) >= 0
	AND (@ObjectID = i.FK_ACAssObjectID or @ObjectID is null or @ObjectID = '')
	AND (@ObjectType = i.APAssObjectType or @ObjectType is null or @ObjectType = '')
	AND (i.FK_BRBranchID = @FK_BRBranchID OR @FK_BRBranchID IS NULL)
	AND (i.FK_HREmployeeID = @FK_HREmployeeID OR @FK_HREmployeeID IS NULL);

	SELECT @FromDate as FromDate,@ToDate as ToDate, * FROM dbo.ThongTinCty(1)

END 