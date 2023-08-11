SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO

ALTER PROCEDURE [dbo].[RP_PurchaseOrderPacking]
	@STModuleName VARCHAR(50),
	@FK_APPurchaseOrderID		INT
AS
BEGIN	
	SET NOCOUNT ON;

	SELECT  po.APPurchaseOrderID
		, poi.APPurchaseOrderItemID
		, po.APPurchaseOrderNo
		, po.APPurchaseOrderDate
		, po.APPurchaseOrderDesc
		, po.APPurchaseOrderContractNo
		, o.ACObjectName
		, o.ACObjectContactAddressLine3
		, o.ACObjectContactPhone
		, o.ACObjectMail
		, contact.APSupplierContactName AS APSupplierContactName
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
		, poi.APPurchaseOrderItemProductDesc
		, pa.ICProductAttributeValue AS TTMT
		, ct.GECountryName
		, mu.ICMeasureUnitName
		, p.ICProductInsideDimensionLength
		, p.ICProductInsideDimensionWidth
		, p.ICProductInsideDimensionHeight
		, poi.APPurchaseOrderItemProductQty
		, poi.APPurchaseOrderItemProductUnitCost
		, poi.APPurchaseOrderItemTotalCost
		, poi.APPurchaseOrderItemComment
		, po.APPurchaseOrderComment
		, po.APPurchaseOrderSubTotalCost
		, po.APPurchaseOrderShippingFees
		, po.APPurchaseOrderTaxPercent
		, po.APPurchaseOrderTaxAmount
		, po.APPurchaseOrderTotalCost
		, poe.HREmployeeName AS APPurchasingStaffName
		, poe.HREmployeeTel1 AS APPurchasingStaffPhone
		, currency.GECurrencyNo
		, p.ICProductBoxArea
		, p.ICProductBoxUnitPrice
		, (SELECT dbo.FConvertAmountToWord(po.APPurchaseOrderTotalCost, '',currency.GECurrencyDesc)) AS BangChu
		, STUFF((SELECT DISTINCT '; ' + bp.MMBatchProductNo FROM dbo.MMBatchProducts bp
					INNER JOIN APPurchaseOrderItems poi1 ON poi1.FK_MMBatchProductID = bp.MMBatchProductID
					WHERE bp.AAStatus = 'Alive'
						AND poi1.FK_APPurchaseOrderID = po.APPurchaseOrderID
					FOR XML PATH ('')),1,1,'') AS MMBatchProductNo
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
		OUTER APPLY
		(
			SELECT * FROM  dbo.APSupplierContacts spc
			WHERE spc.AAStatus = 'Alive'
			AND spc.FK_APSupplierID = po.FK_ACObjectID AND po.APObjectType = 'Supplier'
			) contact
		OUTER APPLY
		(
			SELECT GECurrencyNo, GECurrencyDesc FROM  dbo.GECurrencies
			WHERE AAStatus = 'Alive'
			AND GECurrencyID = po.FK_GECurrencyID
			) AS currency
	WHERE	po.AAStatus = 'Alive'
		AND poi.AAStatus = 'Alive'
		AND (po.APPurchaseOrderID = @FK_APPurchaseOrderID)
-----Company info
	SELECT * FROM dbo.ThongTinCty(1)
END




GO

