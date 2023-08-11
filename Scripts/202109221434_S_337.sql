SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO

ALTER PROCEDURE [dbo].[ARDeliveryPlanItems_GetAllDeliveryPlanItemsByDeliveryPlanCompletedAndProductQty]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT (dpi.ARDeliveryPlanItemProductQty - ISNULL(cancel.CanceledDeliveryPlanItemQty,0) + ISNULL(dt.ICReceiptItemProductQty, 0)) AS ARDeliveryPlanItemProductQty
		,	ISNULL(cancel.CanceledDeliveryPlanItemQty, 0) AS ARDeliveryPlanItemCancelQty
		,	ISNULL(ship.ShipmentItemProductQty, 0) AS ARDeliveryPlanItemShipmentQty
		,   dpi.*
		,	soi.ARSaleOrderItemProductUnitPrice
		,	soi.ARSaleOrderItemProductUnitCost
		,	soi.FK_ICStockID
		,	soi.ARSaleOrderItemID
		,	soi.ARSaleOrderItemPrice
		,	soi.ARSaleOrderItemTotalAmount
		,	soi.ARSaleOrderItemProductSerialNo
		,	soi.ARSaleOrderItemProductAttribute
		,	soi.FK_ICProductSerieID
		,	soi.FK_ICStockID
		,	soi.FK_ICDepartmentID
		,	ISNULL(p.FK_ACAccountID,0) as FK_ACAccountID
		,	di.ARDeliveryPlanNo
		,	b.BRBranchName
		,   vo.ACObjectName
		,	soi.ARSaleOrderSaleAgreement
		,	STUFF((SELECT ',' + t.ARDeliveryPlanTruckName 
					FROM ARDeliveryPlanTruckItems ti
					inner join ARDeliveryPlanTrucks t on ti.FK_ARDeliveryPlanTruckID = T.ARDeliveryPlanTruckID
					WHERE t.AAStatus = 'Alive'
					and ti.AAStatus = 'Alive'
					and ti.FK_ARDeliveryPlanItemID = dpi.ARDeliveryPlanItemID
					FOR XML PATH('')), 1, 1, '') as ARDeliveryPlanTruckName
		,	soi.ARSaleOrderItemOneLevelArea AS ARDeliveryPlanItemOneLevelArea
		,	soi.ARSaleOrderItemTwoLevelArea AS ARDeliveryPlanItemTwoLevelArea
		,	soi.ARSaleOrderItemThreeLevelArea AS ARDeliveryPlanItemThreeLevelArea
		,	di.FK_ACCostCenterID AS FK_ACCostCenterID
		,	di.FK_PMTemplateID
		,  (SELECT PMTemplateItemProductName FROM dbo.PMTemplateItems WHERE AAStatus ='Alive' AND PMTemplateItemID = soi.FK_PMTemplateItemID) AS PMTemplateItemProductName
		, (SELECT ARProposalTemplateItemProductName FROM dbo.ARProposalTemplateItems WHERE ARProposalTemplateItemID = dpi.FK_ARProposalTemplateItemID AND AAStatus = 'Alive') AS ARProposalTemplateItemProductName
	FROM	[dbo].[ARDeliveryPlanItems] dpi
		INNER JOIN ARDeliveryPlans di on dpi.FK_ARDeliveryPlanID = di.ARDeliveryPlanID
		OUTER APPLY
		(
			SELECT soii.ARSaleOrderItemOneLevelArea, soii.ARSaleOrderItemTwoLevelArea, soii.ARSaleOrderItemThreeLevelArea
				, soii.ARSaleOrderItemProductUnitPrice, soii.ARSaleOrderItemProductUnitCost, soii.FK_ICStockID, soii.ARSaleOrderItemID
				, soii.ARSaleOrderItemPrice, soii.ARSaleOrderItemTotalAmount,	soii.ARSaleOrderItemProductSerialNo,	soii.ARSaleOrderItemProductAttribute
				, soii.FK_ICProductSerieID, soii.FK_ICDepartmentID, so.ARSaleOrderSaleAgreement, so.ARSaleOrderStatus, soii.FK_PMTemplateItemID
				, soii.ARSaleOrderItemProductQty, soii.ARSaleOrderItemCanceledQty, soii.ARSaleOrderItemShippedQty, soii.ARSaleOrderItemIsSaleOrderShipment
			FROM [dbo].[ARSaleOrderItems] soii
			INNER JOIN dbo.ARSaleOrders so on soii.FK_ARSaleOrderID = so.ARSaleOrderID 
			WHERE soii.AAStatus = 'Alive'
				AND dpi.FK_ARSaleOrderItemID = soii.ARSaleOrderItemID
		) AS soi
		OUTER APPLY
		(
			SELECT SUM(ISNULL(si.ICShipmentItemProductQty, 0))  AS ShipmentItemProductQty
			FROM dbo.ICShipmentItems si (NOLOCK)
			WHERE si.AAStatus = 'Alive'
				AND si.FK_ARDeliveryPlanItemID = dpi.ARDeliveryPlanItemID
		) AS ship
		OUTER APPLY
		(
			SELECT SUM(ISNULL(cd.ARCanceledDeliveryPlanItemQty, 0)) AS CanceledDeliveryPlanItemQty
			FROM dbo.ARCanceledDeliveryPlanItems cd
			WHERE cd.AAStatus = 'Alive'
				AND cd.FK_ARDeliveryPlanItemID = dpi.ARDeliveryPlanItemID
		) AS cancel
		OUTER APPLY
		(
			SELECT p.FK_ACAccountID, p.ICProductIsFollowInventoryStock, p.HasComponent
			FROM dbo.ICProducts p
			WHERE p.ICProductID = dpi.FK_ICProductID
		) AS p
		OUTER APPLY
		(
			SELECT b.BRBranchName
			FROM dbo.BRBranchs b
			WHERE b.BRBranchID = di.FK_BRBranchID
		) AS b	
		left join V_ACObjects vo on dpi.FK_ACObjectID = vo.ACObjectID and dpi.ARObjectType = vo.ACObjectType
		OUTER APPLY
		(
			SELECT SUM(ISNULL(ri.ICReceiptItemProductQty, 0)) AS ICReceiptItemProductQty
			FROM dbo.ICReceiptItems ri
			INNER JOIN ICReceipts r ON r.AAStatus = 'Alive' AND r.ICReceiptID = ri.FK_ICReceiptID
			OUTER APPLY
			(
				SELECT si.FK_ARSaleOrderItemID
				FROM dbo.ICShipmentItems si
				WHERE si.AAStatus = 'Alive'
					AND si.ICShipmentItemID = ri.FK_ICShipmentItemID
			) AS sii
			WHERE ri.AAStatus = 'Alive'
				AND ri.ICReceiptItemReturnShippingType = 'Replace'
				AND sii.FK_ARSaleOrderItemID = soi.ARSaleOrderItemID
				AND r.ICReceiptPostedStatus = 'Posted'
		) AS dt
	WHERE	dpi.AAStatus = 'Alive'
	AND		di.AAStatus = 'Alive'
	AND		soi.ARSaleOrderStatus <> 'Closed'
	AND		di.ARDeliveryPlanStatus IN ('Completed', 'Shipmented')
	AND		di.ARDeliveryPlanType = 'Day'
	--AND	NOT EXISTS(
	--	SELECT 	
	--		dpi1.ARDeliveryPlanItemID 
	--	FROM [dbo].[ARDeliveryPlanItems] dpi1 
	--		INNER join ARDeliveryPlans di1 on dpi1.FK_ARDeliveryPlanID = di1.ARDeliveryPlanID
	--	WHERE dpi.AAStatus = 'Alive'
	--		AND di1.AAStatus = 'Alive'
	--		AND	di1.ARDeliveryPlanType = 'Day'
	--		AND dpi1.FK_ARDeliveryPlanID <> dpi.FK_ARDeliveryPlanID
	--		AND dpi1.FK_ARSaleOrderItemID = dpi.FK_ARSaleOrderItemID
	--		AND dpi1.AACreatedDate > dpi.AACreatedDate
	--)
	AND		(dpi.ARDeliveryPlanItemProductQty 
				- ISNULL(cancel.CanceledDeliveryPlanItemQty,0.00)
				+ ISNULL(dt.ICReceiptItemProductQty, 0.00)
				- ISNULL(ship.ShipmentItemProductQty, 0)) > 0
	AND		soi.ARSaleOrderItemProductQty - Isnull(soi.ARSaleOrderItemCanceledQty,0.00) - Isnull(soi.ARSaleOrderItemShippedQty,0.00) + ISNULL(dt.ICReceiptItemProductQty, 0.00) > 0
	AND		(p.ICProductIsFollowInventoryStock = 1 OR p.HasComponent = 1)
	AND		soi.ARSaleOrderItemIsSaleOrderShipment = 1
END

GO

