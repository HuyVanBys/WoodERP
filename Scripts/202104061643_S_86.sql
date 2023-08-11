SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO


ALTER  PROCEDURE [dbo].[ICShipments_UpdateShipedQtySaleOrderAndDeliveryPlan]
		@ICShipmentID			INT,
		@userName			NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	-- SaleForecast
	UPDATE sf SET sf.ARSaleOrderItemShippedQty =  ISNULL(sQty.ICShipmentItemProductQty,0)
	, sf.AAUpdatedDate = GETDATE()
	, sf.AAUpdatedUser = @userName
	FROM  dbo.ICShipmentItems si
	INNER JOIN dbo.ARSaleOrderItems sf ON sf.ARSaleOrderItemID = si.FK_ARSaleOrderItemID
	AND si.FK_ICShipmentID = @ICShipmentID
	OUTER APPLY (
		SELECT SUM(ICShipmentItemProductQty) AS ICShipmentItemProductQty
		FROM ICShipmentItems si INNER JOIN dbo.ICShipments s ON si.FK_ICShipmentID = s.ICShipmentID
		AND s.ICShipmentStatus = 'Complete'
		WHERE si.AAStatus = 'Alive' AND s.AAStatus ='Alive'
		AND si.FK_ARSaleOrderItemID = sf.ARSaleOrderItemID
	) sQty
	WHERE si.FK_ICShipmentID = @ICShipmentID
	AND si.AAStatus = 'Alive'
	AND sf.AAStatus = 'Alive'
	--- Update Components
	UPDATE soic SET soic.ARSOItemComponentShippedQty = ISNULL(sQty.ICShipmentItemComponentQty,0)
	FROM dbo.ARSOItemComponents soic
	INNER JOIN dbo.ARSaleOrderItems soi ON soi.ARSaleOrderItemID = soic.FK_ARSaleOrderItemID
	INNER JOIN dbo.ICShipmentItems si ON si.FK_ARSaleOrderItemID = soi.ARSaleOrderItemID AND si.FK_ICShipmentID = @ICShipmentID
	OUTER APPLY
		(
			SELECT SUM(sic.ICShipmentItemComponentQty) AS ICShipmentItemComponentQty FROM  ICShipmentItemComponents sic
			INNER JOIN dbo.ICShipmentItems si ON si.ICShipmentItemID = sic.FK_ICShipmentItemID
			INNER JOIN dbo.ICShipments s ON s.ICShipmentID = si.FK_ICShipmentID AND s.ICShipmentStatus = 'Complete'
			WHERE si.AAStatus = 'Alive' AND sic.AAStatus = 'Alive'
			AND si.FK_ARSaleOrderItemID = soi.ARSaleOrderItemID
			AND sic.FK_ICProductID = soic.FK_ICProductID
			) AS sQty
	WHERE si.AAStatus = 'Alive'
	AND soi.AAStatus = 'Alive'
	AND soic.AAStatus = 'Alive'
	AND si.FK_ICShipmentID = @ICShipmentID
	--- DeliveryPlan 
	UPDATE sf 
	SET sf.ARDeliveryPlanItemShipmentQty = ISNULL(sQty.ICShipmentItemProductQty,0) /sf.ARDeliveryPlanItemProductFactor
	,	sf.ARDeliveryPlanItemDeliveryQty = ISNULL(sQty.ICShipmentItemProductQty,0) /sf.ARDeliveryPlanItemProductFactor
	FROM  dbo.ICShipmentItems si
	INNER JOIN dbo.ARDeliveryPlanItems sf ON sf.ARDeliveryPlanItemID = si.FK_ARDeliveryPlanItemID
	AND si.FK_ICShipmentID = @ICShipmentID
	OUTER APPLY (
		SELECT SUM(si.ICShipmentItemProductExchangeQty) AS ICShipmentItemProductQty
		FROM ICShipmentItems si INNER JOIN dbo.ICShipments s ON si.FK_ICShipmentID = s.ICShipmentID
		AND s.ICShipmentStatus = 'Complete'
		WHERE si.AAStatus = 'Alive' AND s.AAStatus ='Alive'
		AND si.FK_ARDeliveryPlanItemID = sf.ARDeliveryPlanItemID
	) sQty
	WHERE si.FK_ICShipmentID = @ICShipmentID
	AND si.AAStatus = 'Alive'
	AND sf.AAStatus = 'Alive'
END



GO

