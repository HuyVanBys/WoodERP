-- Delete
DELETE ADReportViewRefParams WHERE FK_ADReportViewRefID in (select ADReportViewRefID From ADReportViewRefs where ADReportViewRefNo = 'RP_APProposalsList')
DELETE ADReportViewRefs WHERE ADReportViewRefNo = 'RP_APProposalsList'
DELETE STFieldFormats WHERE STFieldFormatTableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RP_APProposalsList')
DELETE AAColumnAlias WHERE AATableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RP_APProposalsList')
DELETE ADReportTemplates WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_APProposalsList')
DELETE ADReportPermissions WHERE FK_ADReportID in (select ADReportID From ADReports where ADReportNo = 'RP_APProposalsList')
DELETE ADReports WHERE ADReportNo = 'RP_APProposalsList'
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_APProposalsList')
DELETE ADTemplates WHERE ADTemplateNo = 'RP_APProposalsList'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_APProposalsList',N'Danh sách hàng đề nghị',N'Xem danh sách hàng đề nghị',N'RP_APProposalsList',N'Alive',N'RP_APProposalsList',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'APProposalDateFrom	',N'Từ ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_APProposalsList'),0,N'DateTime',N'',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Delete',N'APObjectType',N'',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_APProposalsList'),1,N'',N'',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'APProposalDateTo',N'Đến ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_APProposalsList'),1,N'DateTime',N'',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'FK_BRBranchID	',N'Chi nhánh',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_APProposalsList'),2,N'Number',N'BRBranchs',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'FK_ICDepartmentID',N'Ngành hàng',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_APProposalsList'),3,N'Number',N'ICDepartments',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'APPurchaseProposalItemStatus',N'Tình trạng',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_APProposalsList'),4,N'String',N'APProposalItems',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Delete',N'',N'',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_APProposalsList'),0,N'',N'',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Delete',N'FK_ICDepartmentID',N'Ngành hàng',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_APProposalsList'),0,N'Number',N'ICDepartments',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Delete',N'APPurchaseProposalItemStatus',N'Tình trạng',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_APProposalsList'),0,N'Text',N'APProposalItems',N'',N'',N'',N'',0
INSERT INTO ADReports (AACreatedDate,AACreatedUser,AAUpdatedDate,AAUpdatedUser,AAStatus,FK_GELanguageID,ADReportNo,ADReportName,ADReportDesc,ADReportType,ADReportSection,ADReportViewType,ADReportSortOrder,ADReportCopies) SELECT 'Dec 11 2019  5:17:06:777PM',N'ThuyPhuong','Dec 11 2019  5:17:06:777PM',N'BAOLE',N'Alive',1,N'RP_APProposalsList',N'Danh sách hàng đề nghị',N'Xem danh sách hàng đề nghị',N'Purchasing',N'Mua hàng',N'PrintViewer',407,0
INSERT INTO ADReportTemplates (FK_ADReportID,FK_ADTemplateID) SELECT (select ADReportID from ADReports where ADReportNo = 'RP_APProposalsList'),(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_APProposalsList')
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APProposalNo',N'Mã chứng từ',N'RP_APProposalsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APProposalItemProductDesc',N'Mô tả',N'RP_APProposalsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICMeasureUnitName',N'Đơn vị tính',N'RP_APProposalsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APProposalItemPurchaseOrderQty',N'Số lượng đã mua',N'RP_APProposalsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APSupplierName',N'Đối tượng',N'RP_APProposalsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APProposalItemProductQty',N'Số lượng',N'RP_APProposalsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APProposalItemProductSupplierNo',N'Mã sản phẩm NCC',N'RP_APProposalsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APPurchaseProposalItemStatusDisplayedText',N'Tình trạng',N'RP_APProposalsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APProposalDate',N'Ngày chứng từ',N'RP_APProposalsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'BRBranchName',N'Chi nhánh',N'RP_APProposalsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICProductNo',N'Mã sản phẩm',N'RP_APProposalsList',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APProposalDate',N'Ngày chứng từ',N'RP_APProposalsList',N'',N'',N'',N'',0,NULL
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'RP_APProposalsList') DROP PROCEDURE RP_APProposalsList
GO
-- Stored Procedure

CREATE PROCEDURE [dbo].[RP_APProposalsList]
	@APProposalDateFrom						datetime		=	null	,
	@APProposalDateTo						datetime		=	NULL	,
	@FK_BRBranchID							int				=	null	,
	@FK_ICDepartmentID						int				=	null	,	
	@APPurchaseProposalItemStatus			varchar(50)		=	null	
	
	AS
BEGIN	
	set nocount on;

	select	
	        p.APProposalItemProductDesc
		,	ps.APProposalNo
		,   ps.APProposalDate		
		,   p.APProposalItemProductQty
		,   p.APProposalItemPurchaseOrderQty
		,   icm.ICMeasureUnitName
		,   ad.ADConfigText as APPurchaseProposalItemStatusDisplayedText
		,	ic.ICProductNo
		,   v.ACObjectName as APSupplierName
		,   p.APProposalItemProductSupplierNo
		,   br.BRBranchName
	from	[dbo].[APProposalItems]	p															
		inner join [dbo].[APProposals]		ps	 on    p.FK_APProposalID	=   ps.APProposalID			
		inner join [dbo].[ICProducts]	    ic	 on	  p.FK_ICProductID		=	ic.ICProductID		
		left join [dbo].[V_ACObjects]		v	 on	  (p.FK_ACObjectID		=   v.ACObjectID	and p.APObjectType = v.ACObjectType	)	
		inner join [dbo].[ICMeasureUnits]   icm  on   icm.ICMeasureUnitID   = p.FK_ICMeasureUnitID
		inner join [dbo].[ADConfigValues]   ad   on    ad.ADConfigKeyValue  = p.APPurchaseProposalItemStatus
		inner join [dbo].[BRBranchs]        br   on    br.BRBranchID  =	p.FK_BRBranchID
	where	p.AAStatus	= 'Alive'
	and		ps.AAStatus	= 'Alive'
	and		p.AAStatus	= 'Alive'	
	and     br.AAStatus	= 'Alive'
	and   	ad.ADConfigKeyGroup = 'PurchaseProposalItemStatus'
	and		(@APPurchaseProposalItemStatus is null	or p.APPurchaseProposalItemStatus = @APPurchaseProposalItemStatus)
	and     (APProposalItemProductSupplierNo is null or p.APProposalItemProductSupplierNo = APProposalItemProductSupplierNo)
	and		(@FK_ICDepartmentID			is	null	or	p.FK_ICDepartmentID = @FK_ICDepartmentID)
	and		(@FK_BRBranchID				is	null	or	p.FK_BRBranchID = @FK_BRBranchID)
	and		(@APProposalDateFrom		is	null	or	datediff (dd, @APProposalDateFrom, ps.APProposalDate) >= 0)
	and		(@APProposalDateTo			is	null	or	datediff (dd, ps.APProposalDate, @APProposalDateTo) >= 0)
END
