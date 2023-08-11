-- Delete
DELETE ADReportViewRefParams WHERE FK_ADReportViewRefID in (select ADReportViewRefID From ADReportViewRefs where ADReportViewRefNo = 'RP_ProductCustomer')
DELETE ADReportViewRefs WHERE ADReportViewRefNo = 'RP_ProductCustomer'
DELETE STFieldFormats WHERE STFieldFormatTableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RP_ProductCustomer')
DELETE AAColumnAlias WHERE AATableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RP_ProductCustomer')
DELETE ADReportTemplates WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_ProductCustomer')
DELETE ADReportPermissions WHERE FK_ADReportID in (select ADReportID From ADReports where ADReportNo = 'RP_ProductCustomer')
DELETE ADReports WHERE ADReportNo = 'RP_ProductCustomer'
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_ProductCustomer')
DELETE ADTemplates WHERE ADTemplateNo = 'RP_ProductCustomer'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_ProductCustomer',N'Thông tin SP theo khách hàng',N'Thông tin SP theo khách hàng',N'Rp_ProductCustomer',N'Alive',N'Rp_ProductCustomer',1
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'FK_ICProductGroupID',N'Nhóm hàng',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_ProductCustomer'),0,N'Number',N'ICProductGroups',N'',N'AAStatus = ''Alive''',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'FK_ICProductID',N'Sản phẩm',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_ProductCustomer'),1,N'Number',N'ICProducts',N'',N'AAStatus = ''Alive''',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'FK_ARCustomer',N'Khách hàng',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_ProductCustomer'),2,N'Number',N'ARCustomers',N'',N'AAStatus = ''Alive''',N'',N'',0
INSERT INTO ADReports (AACreatedDate,AACreatedUser,AAUpdatedDate,AAUpdatedUser,AAStatus,FK_GELanguageID,ADReportNo,ADReportName,ADReportDesc,ADReportType,ADReportSection,ADReportViewType,ADReportSortOrder,ADReportCopies) SELECT 'Aug 11 2022  4:42:45:360PM',N'ADMIN','Aug 11 2022  4:42:45:360PM',N'ADMIN',N'Alive',0,N'RP_ProductCustomer',N'Báo cáo thông tin SP theo khách hàng',N'Báo cáo thông tin SP theo khách hàng',N'Sale',N'Bán hàng',N'PrintViewer',333340,0
INSERT INTO ADReportTemplates (FK_ADReportID,FK_ADTemplateID) SELECT (select ADReportID from ADReports where ADReportNo = 'RP_ProductCustomer'),(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_ProductCustomer')
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICProductNo',N'Mã sản phẩm',N'Rp_ProductCustomer',N'',N'',N'',N'',0,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICProductNoOfOldSys',N'Mã HT cũ',N'Rp_ProductCustomer',N'',N'',N'',N'',0,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICProductName2',N'Tên tiếng việt',N'Rp_ProductCustomer',N'',N'',N'',N'',0,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICProductName',N'Tên sản phẩm',N'Rp_ProductCustomer',N'',N'',N'',N'',0,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICProductDesc',N'Mô tả',N'Rp_ProductCustomer',N'',N'',N'',N'',0,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICProductGroupName',N'Nhóm hàng',N'Rp_ProductCustomer',N'',N'',N'',N'',0,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICMeasureUnitName',N'ĐVT',N'Rp_ProductCustomer',N'',N'',N'',N'',0,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ARCustomerNo',N'Mã khách hàng',N'Rp_ProductCustomer',N'',N'',N'',N'',0,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ARCustomerName',N'Khách hàng',N'Rp_ProductCustomer',N'',N'',N'',N'',0,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICProductCustomerNumber',N'Mã sản phẩm đối tác',N'Rp_ProductCustomer',N'',N'',N'',N'',0,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICProductCustomerName',N'Tên SP theo khách hàng',N'Rp_ProductCustomer',N'',N'',N'',N'',0,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICProductCustomerProductionComment',N'Ghi chú sản xuất',N'Rp_ProductCustomer',N'',N'',N'',N'',0,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICProductCustomerPackagingDetail',N'Thông tin đóng gói',N'Rp_ProductCustomer',N'',N'',N'',N'',0,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICProductCustomerPackagingInfoVietnam',N'Thông tin đóng gói tiếng việt',N'Rp_ProductCustomer',N'',N'',N'',N'',0,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICProductCustomerLogoPrintingInstructions',N'Hướng dẫn in logo',N'Rp_ProductCustomer',N'',N'',N'',N'',0,0
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'Rp_ProductCustomer') DROP PROCEDURE Rp_ProductCustomer
GO

-- =============================================
CREATE PROCEDURE [dbo].[Rp_ProductCustomer]
	@FK_ICProductGroupID INT NULL,
		@FK_ICProductID INT NULL,
		@FK_ARCustomerID INT null
AS
BEGIN
	SET NOCOUNT ON;

	SELECT 
		p.ICProductID,
		p.ICProductNo,
		p.ICProductNoOfOldSys,
		p.ICProductName2,
		p.ICProductName,
		p.ICProductDesc,
		ISNULL(pg.ICProductGroupName,'') AS ICProductGroupName,
		ISNULL(mu.ICMeasureUnitName, '') AS ICMeasureUnitName,
		customer.ARCustomerNo,
		customer.ARCustomerName,
		pc.ICProductCustomerNumber,
		pc.ICProductCustomerName,
		pc.ICProductCustomerProductionComment,
		pc.ICProductCustomerPackagingDetail,
		pc.ICProductCustomerPackagingInfoVietnam,
		pc.ICProductCustomerLogoPrintingInstructions
	FROM dbo.ICProducts p
	INNER JOIN dbo.ICProductCustomers pc ON pc.FK_ICProductID = p.ICProductID
	LEFT JOIN dbo.ICProductGroups pg ON pg.ICProductGroupID = p.FK_ICProductGroupID AND pg.AAStatus = 'Alive'
	LEFT JOIN dbo.ICMeasureUnits mu ON mu.ICMeasureUnitID = p.FK_ICProductBasicUnitID AND mu.AAStatus = 'Alive'
	OUTER APPLY
		(
			SELECT ARCustomerNo,
					ARCustomerName FROM  dbo.ARCustomers
			WHERE AAStatus = 'Alive'
			AND ARCustomerID = pc.FK_ARCustomerID
			) AS customer
	WHERE p.AAStatus = 'Alive'
	AND pc.AAStatus = 'Alive'
	AND (@FK_ICProductGroupID IS NULL OR p.FK_ICProductGroupID = @FK_ICProductGroupID)
	AND (@FK_ICProductID IS NULL OR p.ICProductID = @FK_ICProductID)
	AND (@FK_ARCustomerID IS NULL OR pc.FK_ARCustomerID = @FK_ARCustomerID)

END 

