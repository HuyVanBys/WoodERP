﻿-- Delete
DELETE ADReportViewRefParams WHERE FK_ADReportViewRefID in (select ADReportViewRefID From ADReportViewRefs where ADReportViewRefNo = 'RP403')
DELETE ADReportViewRefs WHERE ADReportViewRefNo = 'RP403'
DELETE STFieldFormats WHERE STFieldFormatTableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RP403')
DELETE AAColumnAlias WHERE AATableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RP403')
DELETE ADReportTemplates WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP403')
DELETE ADReportPermissions WHERE FK_ADReportID in (select ADReportID From ADReports where ADReportNo = 'RP403')
DELETE ADReports WHERE ADReportNo = 'RP403'
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP403')
DELETE ADTemplates WHERE ADTemplateNo = 'RP403'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP403',N'Tổng hợp doanh thu theo kênh bán hàng',N'Tổng hợp doanh thu theo kênh bán hàng',N'ACTransactions_RevenueBySalesChannel',N'Alive',N'RP403',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'FromDate',N'Từ ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP403'),0,N'Date',N'',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'ToDate',N'Đến ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP403'),1,N'Date',N'',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'ARListOfSalesChannelType',N'Kênh bán hàng',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP403'),3,N'Number',N'ADConfigValues',N'',N'AAStatus <> ''Alive'' and ADConfigKeyGroup = ''ListOfSalesChannelType''',N'',N'',0
INSERT INTO ADReports (AACreatedDate,AACreatedUser,AAUpdatedDate,AAUpdatedUser,AAStatus,FK_GELanguageID,ADReportNo,ADReportName,ADReportDesc,ADReportType,ADReportSection,ADReportViewType,ADReportSortOrder,ADReportCopies) SELECT 'Dec 15 2022  3:43:52:547PM',N'','Dec 15 2022  3:43:52:547PM',N'',N'Alive',1,N'RP403',N'Tổng hợp doanh thu theo kênh bán hàng',N'Tổng hợp doanh thu theo kênh bán hàng',N'Accounting',N'Bán hàng',N'PrintViewer',333338,0
INSERT INTO ADReportTemplates (FK_ADReportID,FK_ADTemplateID) SELECT (select ADReportID from ADReports where ADReportNo = 'RP403'),(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP403')
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ACObjectNo',N'Mã đối tượng',N'RP403',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ACObjectName',N'Tên đối tượng',N'RP403',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ARInvoiceTotalAmount',N'Số tiền',N'RP403',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'KenhBanHang',N'Kênh',N'RP403',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'KenhBanHang',N'Kênh',N'RP403',N'',N'',N'',N'',1,1
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName,STChangeByCurrency,STChangeByDepartment) SELECT N'Report',N'RP403',1,N'ARInvoiceTotalAmount',0,0