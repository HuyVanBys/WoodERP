SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO

ALTER PROCEDURE [dbo].[ARSaleOrderItems_GeSaleOrderItemsForShipmentSaleOrder]
AS
BEGIN
	set nocount on;

	SELECT
		(soi.ARSaleOrderItemProductQty - ISNULL(soi.ARSaleOrderItemCanceledQty,0) -Isnull(shipped.shippedQty,0.00)) AS ARSaleOrderItemProductQty
		, soi.*
		, so.ARSaleOrderNo
		, b.BRBranchName
		, vo.ACObjectName
		, so.ARSaleOrderSaleAgreement
		, so.FK_PMTemplateID
		, (SELECT PMTemplateItemProductName FROM dbo.PMTemplateItems WHERE AAStatus ='Alive' AND PMTemplateItemID = soi.FK_PMTemplateItemID) AS PMTemplateItemProductName
		, (SELECT ARProposalTemplateItemProductName FROM dbo.ARProposalTemplateItems WHERE ARProposalTemplateItemID = soi.FK_ARProposalTemplateItemID AND AAStatus = 'Alive') AS ARProposalTemplateItemProductName
	from [dbo].[ARSaleOrderItems] soi
		INNER JOIN dbo.ICProducts p ON p.ICProductID = soi.FK_ICProductID
		inner join ARSaleOrders so on soi.FK_ARSaleOrderID = so.ARSaleOrderID
		inner join dbo.BRBranchs b on b.BRBranchID = so.FK_BRBranchID
		left join V_ACObjects vo on so.FK_ACObjectID = vo.ACObjectID and so.ARObjectType = vo.ACObjectType		
		OUTER APPLY (select ISNULL(sum(si.ICShipmentItemProductQty),0.00) AS shippedQty from ICShipmentItems si
			where si.FK_ARSaleOrderItemID = soi.ARSaleOrderItemID
				AND si.AAStatus = 'Alive') AS shipped
	where	so.AAStatus = 'Alive'
		and	soi.AAStatus = 'Alive'
		AND p.AAStatus = 'Alive'
		and soi.ARSaleOrderItemIsDeliveryPlan = 0
		and soi.ARSaleOrderItemIsSaleOrderShipment = 1
		AND (p.ICProductIsFollowInventoryStock = 1 OR p.HasComponent = 1)
		AND	so.ARSaleOrderStatus not in ('New','Closed')
and		(soi.ARSaleOrderItemProductQty 
			- ISNULL(soi.ARSaleOrderItemCanceledQty,0.00) 
			- shipped.shippedQty) > 0
		AND soi.ARSaleOrderItemProductQty - Isnull(soi.ARSaleOrderItemCanceledQty,0.00) - Isnull(soi.ARSaleOrderItemShippedQty,0.00) > 0
END


GO

