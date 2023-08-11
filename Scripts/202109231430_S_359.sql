SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
ALTER PROCEDURE [dbo].[ARSaleOrderItems_GetAllInvoiceAndShipment]

AS
BEGIN
	set nocount on;
	SELECT	so.ARSaleOrderNo
		, dp.ARDeliveryPlanNo
		,	ISNULL(dpi.ARDeliveryPlanItemProductExchangeQty, 0.000)
			-  cancelDelivery.qty
			-  invoiceQty.value  /  
				CASE WHEN dpi.ARDeliveryPlanItemProductFactor = 0 THEN 1 ELSE dpi.ARDeliveryPlanItemProductFactor END 
					AS ARSaleOrderItemProductQty
		,	dpi.ARDeliveryPlanItemID AS FK_ARDeliveryPlanItemID
		,	dpi.ARDeliveryPlanItemProductFactor AS ARSaleOrderItemProductFactor
		,	ISNULL(dpi.ARDeliveryPlanItemProductExchangeQty, 0.000)
			- cancelDelivery.qty * dpi.ARDeliveryPlanItemProductFactor
			- invoiceQty.value AS ARSaleOrderItemProductExchangeQty
		,	dpi.FK_ICMeasureUnitID AS FK_ICMeasureUnitID
		,	soi.FK_ICMeasureUnitID AS FK_ICMeasureUnitBeforeChangeID
		,	dpi.FK_ICStockID
		,	dpi.ARDeliveryPlanItemWoodQty - cancelDelivery.woodQty AS ARSaleOrderItemWoodQty
		,	CASE WHEN dpi.FK_ICProductSerieID > 0
				THEN dpi.FK_ICProductSerieID
				ELSE (SELECT TOP 1 ps.ICProductSerieID 
						FROM dbo.ICProductSeries ps 
						WHERE ps.AAStatus = 'Alive' 
							AND ps.ICProductSerieLotNo = dpi.ARDeliveryPlanItemLotNo 
							AND ps.ICProductSerieNo = dpi.ARDeliveryPlanItemProductSerialNo)
				END AS FK_ICProductSerieID
		,	dpi.ARDeliveryPlanItemProductSerialNo AS ARSaleOrderItemProductSerialNo
		,	dpi.ARDeliveryPlanItemLotNo AS ARSaleOrderItemLotNo
		,	so.FK_CSCompanyBankID
		,	v.ACObjectName AS ACObjectName
		,	soi.*
	FROM	dbo.ARSaleOrderItems soi
		INNER JOIN dbo.ARSaleOrders so ON so.ARSaleOrderID = soi.FK_ARSaleOrderID
		INNER JOIN dbo.ARDeliveryPlanItems dpi ON dpi.FK_ARSaleOrderItemID = soi.ARSaleOrderItemID
		INNER JOIN dbo.ARDeliveryPlans dp ON dp.ARDeliveryPlanID = dpi.FK_ARDeliveryPlanID
		INNER JOIN dbo.ICProducts p ON p.ICProductID = soi.FK_ICProductID
		LEFT JOIN dbo.V_ACObjects v ON v.ACObjectID = so.FK_ACObjectID AND v.ACObjectType = so.ARObjectType
		OUTER APPLY
		(
			(SELECT ISNULL(SUM(cdpi.ARCanceledDeliveryPlanItemQty), 0.000) AS qty,
					ISNULL(SUM(cdpi.ARCanceledDeliveryPlanItemWoodQty), 0.000) AS woodQty
				FROM dbo.ARCanceledDeliveryPlanItems cdpi
				WHERE cdpi.FK_ARDeliveryPlanItemID = dpi.ARDeliveryPlanItemID
				AND cdpi.AAStatus = 'Alive')
		) cancelDelivery
		OUTER APPLY
		(
			SELECT ISNULL(SUM(ii.ARInvoiceItemProductExchangeQty), 0.000) AS value
				FROM dbo.ARInvoiceItems ii
				WHERE ii.FK_ARDeliveryPlanItemID = dpi.ARDeliveryPlanItemID
				AND ii.AAStatus = 'Alive'
		) invoiceQty
	WHERE	soi.AAStatus = 'Alive'
		AND dpi.AAStatus = 'Alive'
		AND dp.AAStatus = 'Alive'
		AND p.AAStatus = 'Alive'
		AND dp.ARDeliveryPlanType = 'Day'
		AND dp.ARDeliveryPlanStatus = 'Completed'
		AND ((soi.ARSaleOrderItemIsAcceptance = 0 AND soi.ARSaleOrderItemIsSaleOrderShipment = 0 AND soi.ARSaleOrderItemIsInvoiceAndShipment = 1)
				or soi.ARSaleOrderItemIsContainerLoader = 1)
		AND ISNULL(dpi.ARDeliveryPlanItemProductExchangeQty, 0.000)
			- cancelDelivery.qty * dpi.ARDeliveryPlanItemProductFactor
			-  invoiceQty.value > 0
	UNION

	SELECT	so.ARSaleOrderNo
		, '' AS ARDeliveryPlanNo
		,	(ISNULL(soi.ARSaleOrderItemProductQty, 0.000)
			- cancelQty.value
			- invoiceQty.value) AS ARSaleOrderItemProductQty
		,	0 AS FK_ARDeliveryPlanItemID
		,	0
		,	0
		,	soi.FK_ICMeasureUnitID AS FK_ICMeasureUnitID
		,	0 AS FK_ICMeasureUnitBeforeChangeID
		,	soi.FK_ICStockID
		,	soi.ARSaleOrderItemWoodQty
		,	CASE WHEN soi.FK_ICProductSerieID > 0
				THEN soi.FK_ICProductSerieID
				ELSE (SELECT TOP 1 ps.ICProductSerieID 
						FROM dbo.ICProductSeries ps 
						WHERE ps.AAStatus = 'Alive' 
							AND ps.ICProductSerieLotNo = soi.ARSaleOrderItemLotNo 
							AND ps.ICProductSerieNo = soi.ARSaleOrderItemProductSerialNo)
				END AS FK_ICProductSerieID
		,	soi.ARSaleOrderItemProductSerialNo
		,	soi.ARSaleOrderItemLotNo
		,	so.FK_CSCompanyBankID
		,	v.ACObjectType AS ACObjectName
		,	soi.*
	FROM	dbo.ARSaleOrderItems soi
		INNER JOIN dbo.ARSaleOrders so ON so.ARSaleOrderID = soi.FK_ARSaleOrderID
		INNER JOIN dbo.ICProducts p ON p.ICProductID = soi.FK_ICProductID
		LEFT JOIN dbo.V_ACObjects v ON v.ACObjectID = so.FK_ACObjectID AND v.ACObjectType = so.ARObjectType
		OUTER APPLY
		(
			SELECT ISNULL(SUM(cvi.ARCancelVoucherItemProductQty), 0.000) AS value
				FROM dbo.ARCancelVoucherItems cvi
				WHERE cvi.FK_ARSaleOrderItemID = soi.ARSaleOrderItemID
				AND cvi.AAStatus = 'Alive'
		) cancelQty
		OUTER APPLY
		(
			SELECT ISNULL(SUM(ii.ARInvoiceItemProductExchangeQty /
					CASE WHEN ii.ARInvoiceItemProductFactor = 0 THEN 1 ELSE ii.ARInvoiceItemProductFactor END 
					), 0.000) AS value
				FROM dbo.ARInvoiceItems ii 
				WHERE ii.FK_ARSaleOrderItemID = soi.ARSaleOrderItemID 
				AND ii.AAStatus = 'Alive'
		) invoiceQty
	WHERE	soi.AAStatus = 'Alive'
		AND p.AAStatus = 'Alive'
		AND so.AAStatus = 'Alive'
		AND so.ARSaleOrderStatus in ('Confirmed','Complete','Incomplete')
		AND soi.ARSaleOrderItemIsInvoiceAndShipment = 1
		AND soi.ARSaleOrderItemIsDeliveryPlan = 0
		AND soi.ARSaleOrderItemIsAcceptance = 0
		AND soi.ARSaleOrderItemIsSaleOrderShipment = 0
		AND (ISNULL(soi.ARSaleOrderItemProductQty, 0.000)
			- cancelQty.value
			- invoiceQty.value) > 0
END




GO

