-- Delete
DELETE ADReportViewRefParams WHERE FK_ADReportViewRefID in (select ADReportViewRefID From ADReportViewRefs where ADReportViewRefNo = 'RP_GetPurchaseOrderItemsBySomeCriteria')
DELETE ADReportViewRefs WHERE ADReportViewRefNo = 'RP_GetPurchaseOrderItemsBySomeCriteria'
DELETE STFieldFormats WHERE STFieldFormatTableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RP_GetPurchaseOrderItemsBySomeCriteria')
DELETE AAColumnAlias WHERE AATableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RP_GetPurchaseOrderItemsBySomeCriteria')
DELETE ADReportTemplates WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_GetPurchaseOrderItemsBySomeCriteria')
DELETE ADReportPermissions WHERE FK_ADReportID in (select ADReportID From ADReports where ADReportNo = 'RP_GetPurchaseOrderItemsBySomeCriteria')
DELETE ADReports WHERE ADReportNo = 'RP_GetPurchaseOrderItemsBySomeCriteria'
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_GetPurchaseOrderItemsBySomeCriteria')
DELETE ADTemplates WHERE ADTemplateNo = 'RP_GetPurchaseOrderItemsBySomeCriteria'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_GetPurchaseOrderItemsBySomeCriteria',N'Danh sách hàng đặt mua',N'Danh sách hàng đặt mua',N'RP_GetPurchaseOrderItemsBySomeCriteria',N'Alive',N'RP00001',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'APPurchaseOrderItemDeliveryDateFrom',N'Từ ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_GetPurchaseOrderItemsBySomeCriteria'),0,N'Date',N'',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'APPurchaseOrderItemDeliveryDateTo',N'Đến ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_GetPurchaseOrderItemsBySomeCriteria'),1,N'Date',N'',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Delete',N'FK_GELocationID',N'Vị trí',N'',0,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_GetPurchaseOrderItemsBySomeCriteria'),2,N'int',N'GELocations',N'',N'',NULL,NULL,0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'FK_BRBranchID',N'Chi nhánh',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_GetPurchaseOrderItemsBySomeCriteria'),2,N'Number',N'BRBranchs',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'FK_ICDepartmentID',N'Ngành hàng',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_GetPurchaseOrderItemsBySomeCriteria'),3,N'Number',N'ICDepartments',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'FK_ICProductGroupID',N'Nhóm hàng',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_GetPurchaseOrderItemsBySomeCriteria'),4,N'Number',N'ICProductGroups',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'APSupplierID',N'Khách hàng',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_GetPurchaseOrderItemsBySomeCriteria'),5,N'Number',N'APSuppliers',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Delete',N'APObjectType',N'Loại khách hàng',N'',0,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_GetPurchaseOrderItemsBySomeCriteria'),7,N'char',N'',N'',N'',NULL,NULL,0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'APPurchaseOrderStatus',N'Tình trạng',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_GetPurchaseOrderItemsBySomeCriteria'),6,N'Text',N'',N'',N'',N'',N'',0
INSERT INTO ADReports (AACreatedDate,AACreatedUser,AAUpdatedDate,AAUpdatedUser,AAStatus,FK_GELanguageID,ADReportNo,ADReportName,ADReportDesc,ADReportType,ADReportSection,ADReportViewType,ADReportSortOrder,ADReportCopies) SELECT 'Sep 19 2019 10:24:18:813AM',N'ADMIN','Sep 19 2019 10:24:18:813AM',N'BAOLE',N'Alive',0,N'RP_GetPurchaseOrderItemsBySomeCriteria',N'Danh sách hàng đặt mua',N'Xem danh sách hàng đặt mua',N'Purchasing',N'Mua hàng',N'PrintViewer',408,0
INSERT INTO ADReportTemplates (FK_ADReportID,FK_ADTemplateID) SELECT (select ADReportID from ADReports where ADReportNo = 'RP_GetPurchaseOrderItemsBySomeCriteria'),(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_GetPurchaseOrderItemsBySomeCriteria')
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APPurchaseOrderItemProductCanceledQty',N'SL Hủy',N'RP00001',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APPurchaseOrderItemReceiptedQty',N'SL Đã nhận',N'RP00001',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APPurchaseOrderItemProductTaxPercent',N'% Thuế',N'RP00001',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APPurchaseOrderItemTaxAmount',N'Tiền thuế',N'RP00001',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APPurchaseOrderItemProductDiscount',N'% Chiết khấu',N'RP00001',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APPurchaseOrderItemDiscountAmount',N'Tiền chiết khấu',N'RP00001',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APPurchaseOrderNo',N'Mã đơn hàng',N'RP00001',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APPurchaseOrderItemTotalCost',N'Thành tiền',N'RP00001',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APPurchaseOrderDepositBalance',N'Đặt cọc',N'RP00001',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APPurchaseOrderDate',N'Ngày chứng từ',N'RP00001',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APPurchaseOrderDeliveryDate',N'Ngày giao hàng',N'RP00001',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APPurchaseOrderComment',N'Ghi chú',N'RP00001',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ACObjectName',N'Khách hàng',N'RP00001',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APPurchaseOrderItemProductUnitCost',N'Đơn giá',N'RP00001',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APPurchaseOrderItemProductQty',N'Số lượng',N'RP00001',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICMeasureUnitName',N'ĐVT',N'RP00001',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APPurchaseOrderItemProductName',N'Tên sản phẩm',N'RP00001',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APPurchaseOrderItemProductAttribute',N'Thuộc tính',N'RP00001',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APSupplierContactPhone1',N'SĐT Khách Hàng',N'RP00001',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APPurchaseOrderStatusDisplayText',N'Tình trạng',N'RP00001',N'',N'',N'',N'',0,NULL
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'APPurchaseOrderItemRemainedQty',N'SL Còn lại',N'RP00001',N'',N'',N'',N'',0,NULL
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP00001',10,N'APPurchaseOrderItemProductCanceledQty'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP00001',10,N'APPurchaseOrderItemReceiptedQty'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP00001',4,N'APPurchaseOrderItemProductTaxPercent'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP00001',1,N'APPurchaseOrderItemTaxAmount'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP00001',4,N'APPurchaseOrderItemProductDiscount'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP00001',1,N'APPurchaseOrderItemDiscountAmount'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP00001',1,N'APPurchaseOrderTotalCost'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP00001',1,N'APPurchaseOrderDepositBalance'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP00001',13,N'APPurchaseOrderDate'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP00001',13,N'APPurchaseOrderDeliveryDate'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP00001',1,N'APPurchaseOrderItemProductUnitCost'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP00001',10,N'APPurchaseOrderItemProductQty'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP00001',10,N'APPurchaseOrderItemRemainedQty'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP00001',1,N'APPurchaseOrderItemTotalCost'
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'RP00001',1,N'APPurchaseOrderItemExtCost'
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'RP_GetPurchaseOrderItemsBySomeCriteria') DROP PROCEDURE RP_GetPurchaseOrderItemsBySomeCriteria
GO
-- =============================================
-- Editor:		PhuongThuy
-- Create date: 12/09/2011
-- Description:	Get purchase order items by some criteria
-- =============================================
CREATE PROCEDURE [dbo].[RP_GetPurchaseOrderItemsBySomeCriteria]
	@APPurchaseOrderItemDeliveryDateFrom	DATETIME		=	NULL,
	@APPurchaseOrderItemDeliveryDateTo		DATETIME		=	NULL,
	@FK_BRBranchID							INT				=	NULL,
	@FK_ICDepartmentID						INT				=	NULL,	
	@FK_ICProductGroupID					INT				=	NULL,
	@FK_ACObjectID						    INT				=	NULL,
	@APPurchaseOrderStatus					NVARCHAR(50)	=	NULL	
AS
BEGIN	
	set nocount on;

	select	
		APPurchaseOrderItemProductQty - ISNULL(APPurchaseOrderItemProductCanceledQty,0.000) - ISNULL(APPurchaseOrderItemReceiptedQty,0.000) AS APPurchaseOrderItemRemainedQty
		,  ISNULL(STUFF((SELECT 
				 DISTINCT ',' +  i.APInvoiceInNo 
			FROM dbo.APInvoiceInItems ii 
				INNER JOIN dbo.APInvoiceIns i ON i.APInvoiceInID = ii.FK_APInvoiceInID
			WHERE ii.AAStatus = 'Alive'
				AND i.AAStatus = 'Alive'
				AND ii.FK_APPurchaseOrderItemID = poi.APPurchaseOrderItemID
			FOR XML PATH('')), 1, 1, ''),'') AS APInvoiceInNoRef
		,	ISNULL(STUFF((SELECT 
				 DISTINCT ',' +  r.ICReceiptNo 
			FROM dbo.ICReceipts r 
				INNER JOIN dbo.ICReceiptItems ri ON ri.FK_ICReceiptID = r.ICReceiptID
			WHERE ri.AAStatus = 'Alive'
				AND r.AAStatus = 'Alive'
				AND ri.FK_APPurchaseOrderItemID = poi.APPurchaseOrderItemID
			FOR XML PATH('')), 1, 1, ''),'') AS ICReceipteNoRef
		,	(	select	c.ADConfigText
					from	[dbo].[ADConfigValues] c
					where	c.AAStatus = 'Alive'
					and		c.ADConfigKeyGroup = 'PurchaseOrderType'
					and		c.ADConfigKeyValue = po.APPurchaseOrderType
			)	as	APPurchaseOrderTypeDisplayText
		,		(	select	c.ADConfigText
					from	[dbo].[ADConfigValues] c
					where	c.AAStatus = 'Alive'
					and		c.ADConfigKeyGroup = 'PurchaseOrderStatus'
					and		c.ADConfigKeyValue = po.APPurchaseOrderStatus
				)	as	APPurchaseOrderStatusDisplayText
		,		(	select  mu.ICMeasureUnitName
					from	[dbo].[ICMeasureUnits]	mu
					where	mu.AAStatus = 'Alive'
					and		mu.ICMeasureUnitID = poi.FK_ICMeasureUnitID
				)ICMeasureUnitName
		,		(	select  s.APSupplierContactPhone
					from	[dbo].[APSuppliers]	s
					where	s.AAStatus = 'Alive'
					and		s.APSupplierID = po.FK_APSupplierID
				)APSupplierContactPhone1
		,		(	select  s.APSupplierContactPhone1
					from	[dbo].[APSuppliers]	s
					where	s.AAStatus = 'Alive'
					and		s.APSupplierID = po.FK_APSupplierID
				)APSupplierContactPhone2
		,		poi.APPurchaseOrderItemProductQty
		,		poi.APPurchaseOrderItemProductCanceledQty
		,		poi.APPurchaseOrderItemReceiptedQty
		,		poi.APPurchaseOrderItemProductTaxPercent
		,		poi.APPurchaseOrderItemTaxAmount
		,		poi.APPurchaseOrderItemProductDiscount
		,		poi.APPurchaseOrderItemDiscountAmount
		,		poi.APPurchaseOrderItemProductUnitCost
		,		poi.APPurchaseOrderItemProductName
		,		poi.APPurchaseOrderItemProductAttribute
		,		poi.APPurchaseOrderItemTotalCost
		,		poi.APPurchaseOrderItemExtCost
		,		p.ICProductNo
		,		po.APPurchaseOrderNo
		,		po.APPurchaseOrderTotalCost
		,		po.APPurchaseOrderDepositBalance
		,		po.APPurchaseOrderBalanceDue
		,		po.APPurchaseOrderVolume
		,		po.APPurchaseOrderDate
		,		po.APPurchaseOrderDeliveryDate
		,		po.APPurchaseOrderPackingDate
		,		po.APPurchaseOrderComment
		,		sup.APSupplierName as ACObjectName
			
	from	[dbo].[APPurchaseOrderItems]	poi															
		inner join [dbo].[APPurchaseOrders]		po  ON po.AAStatus = 'Alive' AND poi.FK_APPurchaseOrderID = po.APPurchaseOrderID		
		inner join [dbo].[ICProducts]			p	ON p.AAStatus = 'Alive' AND	poi.FK_ICProductID = p.ICProductID	
		left join dbo.APSuppliers				sup ON sup.AAStatus = 'Alive' AND po.FK_APSupplierID = sup.APSupplierID	
	where	poi.AAStatus	=	'Alive'
	and		(@FK_BRBranchID							is  null    or  po.FK_BRBranchID = @FK_BRBranchID)
	and		(@FK_ICDepartmentID						is	null	or	p.FK_ICDepartmentID = @FK_ICDepartmentID)
	and		(@FK_ACObjectID							IS  NULL	OR	PO.FK_APSupplierID = @FK_ACObjectID)
	and		(@FK_ICProductGroupID					is	null	or	dbo.ICProductGroups_IsChild(p.FK_ICProductGroupID, @FK_ICProductGroupID) = 1)		
	and		(@APPurchaseOrderStatus					is	null	or	po.APPurchaseOrderStatus = @APPurchaseOrderStatus)
	and		(@APPurchaseOrderItemDeliveryDateFrom	is	null	or	datediff(DD, @APPurchaseOrderItemDeliveryDateFrom, po.APPurchaseOrderDeliveryDate) >= 0)
	and		(@APPurchaseOrderItemDeliveryDateTo		is	null	or	datediff(DD, @APPurchaseOrderItemDeliveryDateTo, po.APPurchaseOrderDeliveryDate) <= 0)		
	order by
			po.APPurchaseOrderNo
END



