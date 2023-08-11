SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
Create PROCEDURE [dbo].[ARDeliveryPlanItems_GetRemainSaleOrderItemQtyByShipmentItemID]
	@ShipmentItemID		INT = NULL,
	@SaleOrderItemID	INT
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT ISNULL(soi.ARSaleOrderItemProductQty,0) - ISNULL(ship.ShipmentItemProductQty, 0) - ISNULL(cancel.CanceledDeliveryPlanItemQty,0) AS ARSaleOrderItemProductQty
		,   soi.*
	FROM	dbo.ARSaleOrderItems soi
		OUTER APPLY
		(
			SELECT SUM(ISNULL(si.ICShipmentItemProductQty, 0))  AS ShipmentItemProductQty
			FROM dbo.ICShipmentItems si (NOLOCK)
			WHERE si.AAStatus = 'Alive'
				AND si.FK_ARSaleOrderItemID = soi.ARSaleOrderItemID
				AND (@ShipmentItemID IS NULL OR si.ICShipmentItemID <> @ShipmentItemID)
		) AS ship
		OUTER APPLY
		(
			SELECT SUM(ISNULL(cd.ARCancelVoucherItemProductQty, 0)) AS CanceledDeliveryPlanItemQty
			FROM dbo.ARCancelVoucherItems cd
			WHERE cd.AAStatus = 'Alive'
				AND cd.FK_ARSaleOrderItemID = soi.ARSaleOrderItemID
		) AS cancel
	WHERE	soi.AAStatus = 'Alive'
		AND	soi.ARSaleOrderItemID = @SaleOrderItemID	
END

GO

