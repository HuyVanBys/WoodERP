-- Delete
DELETE STToolbarFunctions WHERE STToolbarID in (select FK_STToolbarID From ADTemplates a Join ADTemplateToolbars b On a.ADTemplateID = b.FK_ADTemplateID Where ADTemplateNo = 'RP_PurchaseOrderEn')
DELETE STToolbars WHERE STToolbarID in (select FK_STToolbarID From ADTemplateToolbars a Join ADTemplates b On a.FK_ADTemplateID = b.ADTemplateID Where ADTemplateNo = 'RP_PurchaseOrderEn')
DELETE ADTemplateToolbars WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PurchaseOrderEn')
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_PurchaseOrderEn')
DELETE ADTemplates WHERE ADTemplateNo = 'RP_PurchaseOrderEn'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_PurchaseOrderEn',N'Đơn mua hàng (Tiếng anh)',N'Đơn mua hàng (Tiếng anh)',N'RP_PurchaseOrderEn',N'Alive',N'',1
INSERT INTO STToolbars (AAStatus,STModuleID,STUserGroupID,STToolbarName,STToolbarDesc,STToolbarTag,STToolbarStyle,STToolbarCaption,STToolbarGroup,STToolbarOrder,STToolbarVisible,STToolbarPrivilege,STToolbarParentID,STToolbarImage) SELECT N'Alive',20,1,N'fld_barbtnPrintEn',N'Đơn mua hàng (tiếng anh)',N'PrintEn',N'Default',N'Đơn mua hàng (tiếng anh)',N'Utility',6,1,N'',3199,N''
INSERT INTO ADTemplateToolbars (FK_ADTemplateID,FK_STToolbarID) SELECT (Select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PurchaseOrderEn'),(select MAX(STToolbarID) From STToolbars)
INSERT INTO STToolbarFunctions (STToolbarFunctionIDString,STToolbarID,STToolbarFunctionName,STToolbarFunctionFullName,STToolbarFunctionClass,STToolbarFunctionSortOrder) SELECT N'',(select MAX(STToolbarID) From STToolbars),N'ActionPrintTemplate',N'Void ActionPrintTemplate()',N'BOSERP.Modules.PurchaseOrder.PurchaseOrderModule',1
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'RP_PurchaseOrderEn') DROP PROCEDURE RP_PurchaseOrderEn
GO

CREATE PROCEDURE [dbo].[RP_PurchaseOrderEn]
	@STModuleName VARCHAR(50),
	@FK_APPurchaseOrderID		INT
AS
BEGIN	
	SET NOCOUNT ON;

	SELECT  po.APPurchaseOrderID
		, poi.APPurchaseOrderItemID
		, po.APPurchaseOrderNo
		, po.APPurchaseOrderDate
		, po.APPurchaseOrderContractNo
		, o.ACObjectName
		, o.ACObjectContactAddressLine3
		, o.ACObjectContactPhone
		, o.ACObjectMail
		, (SELECT TOP 1 APSupplierContactName FROM dbo.APSupplierContacts WHERE po.FK_APSupplierID = FK_APSupplierID) AS APPurchasingStaffName
		, (SELECT TOP 1 APSupplierContactPhone FROM dbo.APSupplierContacts WHERE po.FK_APSupplierID = FK_APSupplierID) AS APPurchasingStaffPhone
		, (SELECT TOP 1 APSupplierContactEmail1 FROM dbo.APSupplierContacts WHERE po.FK_APSupplierID = FK_APSupplierID) AS APPurchasingStaffEmail
		, emp.HREmployeeName
		, emp.HREmployeeTel1 AS HREmployeeAllowancePhone
		, emp.HREmployeeEmail1
		, po.APPurchaseOrderDeliveryAddressLine3
		, po.APPurchaseOrderDeliveryDate
		, config.ADConfigText AS APPaymentMethodCombo
		, pt.GEPaymentTermName
		, p.ICProductNo
		, CASE WHEN cv.HRLevelID = 7 THEN emp.HREmployeeName ELSE '' END AS TruongBoPhan
		, CASE WHEN cv.HRLevelID = 3 THEN emp.HREmployeeName ELSE '' END AS GiamDoc
		,(SELECT dt.ICProductAttributeValue FROM dbo.ICProductAttributes dt WHERE dt.ICProductAttributeID = p.FK_ICProdAttPackingMaterialSpecialityID) KieuThung
		,(SELECT dt.ICProductAttributeValue FROM dbo.ICProductAttributes dt WHERE dt.ICProductAttributeID = p.FK_ICProdAttPackingMaterialWeightPerVolumeID) DinhLuong
		, poi.APPurchaseOrderItemProductName
		, pa.ICProductAttributeValue AS TTMT
		, ct.GECountryName
		, mu.ICMeasureUnitName
		, p.ICProductInsideDimensionLength
		, p.ICProductInsideDimensionWidth
		, p.ICProductInsideDimensionHeight
		, poi.APPurchaseOrderItemProductQty
		, poi.APPurchaseOrderItemProductUnitCost
		, poi.APPurchaseOrderItemTotalCost
		, po.APPurchaseOrderComment
		, po.APPurchaseOrderSubTotalCost
		, po.APPurchaseOrderShippingFees
		, po.APPurchaseOrderTaxPercent
		, po.APPurchaseOrderTaxAmount
		, po.APPurchaseOrderTotalCost
		, (select dbo.FConvertAmountToWord(po.APPurchaseOrderTotalCost, '',N' đồng')) AS BangChu
	FROM dbo.APPurchaseOrders po	
		INNER JOIN dbo.APPurchaseOrderItems poi ON po.APPurchaseOrderID = poi.FK_APPurchaseOrderID
		LEFT JOIN dbo.ICProductAttributes pa ON poi.FK_ICProductAttributeTTMTID = pa.ICProductAttributeID
		LEFT JOIN dbo.GECountrys ct ON poi.FK_GECountryID = ct.GECountryID
		LEFT JOIN dbo.ICMeasureUnits mu ON poi.FK_ICMeasureUnitID = mu.ICMeasureUnitID
		LEFT JOIN dbo.ICProducts p ON poi.FK_ICProductID = p.ICProductID
		LEFT JOIN dbo.HREmployees emp ON emp.HREmployeeID = po.FK_HREmployeeID
		LEFT JOIN dbo.HREmployees poe ON poe.HREmployeeID = po.FK_APPurchasingStaffID
		LEFT JOIN dbo.HRLevels cv ON cv.HRLevelID = emp.FK_HRLevelID
		LEFT JOIN dbo.GEPaymentTerms pt ON pt.GEPaymentTermID = po.FK_GEPaymentTermID
		LEFT JOIN dbo.V_ACObjects o ON po.FK_ACObjectID = o.ACObjectID AND po.APObjectType = o.ACObjectType
		OUTER APPLY 
		(
			SELECT TOP 1 ADConfigText 
			FROM dbo.ADConfigValues 
			WHERE AAStatus = 'Alive' 
				AND ADConfigKeyGroup = 'PaymentMethod' 
				AND ADConfigKeyValue = po.APPaymentMethodCombo
		) config
	WHERE	po.AAStatus = 'Alive'
		AND poi.AAStatus = 'Alive'
		AND (po.APPurchaseOrderID = @FK_APPurchaseOrderID)
-----Company info
	SELECT * FROM dbo.ThongTinCty(1)
END