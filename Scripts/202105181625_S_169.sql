SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO



ALTER PROCEDURE [dbo].[ARProductionPlanningItems_GetProductionPlanningItemsForBatchProduct]
	@PlaningID INT = NULL
	, @SaleOrderID INT = NULL
	, @ObjectID INT = NULL
	, @ObjectType NVARCHAR(50) = NULL
	, @FromDate DATETIME = NULL
	, @ToDate DATETIME = NULL
	, @UserID INT
	, @ModuleName NVARCHAR(50)
	, @PermissionType NVARCHAR(50)
	, @BranchID INT = NULL   
AS
BEGIN

	DECLARE @IsShowDataByBranch BIT
	SET @IsShowDataByBranch = ISNULL((SELECT TOP 1 CSCompanyIsShowDataByBranch FROM dbo.CSCompanys WHERE AAStatus = 'Alive'), 0)
	DECLARE @ModuleID int
	SELECT 	
		@ModuleID = STModuleID 
	FROM STModules 
	WHERE AAStatus = 'Alive' 
		AND STModuleName = @ModuleName
	declare @PermissionTable table
	(
		BranchID int
	)
	insert into @PermissionTable 
		select	FK_BRBranchID 
		from	ADDataViewPermissions
		where	AAStatus = 'Alive' 
				and FK_ADUserID = @UserID
				and FK_STModuleOrReportID = @ModuleID
				and ADDataViewPermissionType = @PermissionType

	SELECT 
		ppi.ARProductionPlanningItemProductQty - ISNULL(batchProductItem.Qty, 0.00) AS ARProductionPlanningItemProductQty
		,	so.FK_ACObjectID
		,	so.ARObjectType
		,	so.FK_PMProjectID
		,	po.FK_MMWorkShopID
		,	po.ARProductionPlanningFromDate
		,	po.ARProductionPlanningToDate
		,	CASE WHEN ISNULL(c.BOMCOUNT,0) = 1 THEN b.FK_MMProductionNormID ELSE 0 END AS FK_MMProductionNormID
		,	ppi.*
		,	vo.ACObjectName
		,	po.ARProductionPlanningSources
		,	CASE
				WHEN po.FK_ICProductAttributeTTMTID IS NULL OR po.FK_ICProductAttributeTTMTID = 0 
					THEN ttmt.FK_ICProductAttributeTTMTID
				ELSE po.FK_ICProductAttributeTTMTID
			END AS FK_ICProductAttributeTTMTID
		,	so.ARSaleOrderType
		,	po.ARProductionPlanningType
		,	ARSaleOrderItemHTID AS FK_ICProductAttributeHTTypeID
	FROM ARProductionPlanningItems ppi 
		INNER JOIN ARProductionPlannings po ON ppi.FK_ARProductionPlanningID = po.ARProductionPlanningID
		LEFT JOIN dbo.ARSaleOrders so ON so.ARSaleOrderID = ppi.FK_ARSaleOrderID
		LEFT JOIN dbo.V_ACObjects vo ON so.FK_ACObjectID = vo.ACObjectID
			AND so.ARObjectType = vo.ACObjectType
		OUTER APPLY (
			SELECT 
				SUM(CASE
						WHEN ISNULL(bpi.MMBatchProductItemStatus, '') <> 'Close' THEN MMBatchProductItemProductQty
						ELSE bpi.MMBatchProductItemProducedQty
					END) AS Qty
			FROM dbo.MMBatchProductItems bpi
			WHERE bpi.AAStatus = 'Alive'
				AND bpi.FK_ARProductionPlanningID = ppi.FK_ARProductionPlanningID
				AND bpi.FK_ARProductionPlanningItemID = ppi.ARProductionPlanningItemID
		) AS batchProductItem
		OUTER APPLY
		(
			SELECT COUNT(1) BOMCOUNT
			FROM dbo.MMProductionNorms n
			WHERE n.AAStatus ='Alive'
			AND n.MMProductionNormStatus = 'Approved'
			AND n.FK_ICProductID = ppi.FK_ICProductID
			AND n.MMProductionNormType <> 'Template'
		) c
		OUTER APPLY
		(
			SELECT TOP  1 MMProductionNormID AS FK_MMProductionNormID
			FROM dbo.MMProductionNorms n
			WHERE n.AAStatus ='Alive'
			AND n.FK_ICProductID = ppi.FK_ICProductID
			AND n.MMProductionNormType <> 'Template'
		) b
		OUTER APPLY
		(
			SELECT TOP 1 soi.FK_ICProductAttributeTTMTID ,soi.ARSaleOrderItemHTID
			FROM dbo.ARSaleOrderItems soi
			WHERE soi.AAStatus = 'Alive'
				AND soi.ARSaleOrderItemID = ppi.FK_ARSaleOrderItemID
		) ttmt
	WHERE ppi.AAStatus = 'Alive'
		AND po.AAStatus = 'Alive'
		AND po.ARProductionPlanningStatus = 'Complete'
		AND ppi.ARProductionPlanningItemStatus NOT IN ('Close', 'Canceled')
		AND	(CASE	
				WHEN @IsShowDataByBranch = 1 AND po.FK_BRBranchID = @BranchID THEN 1
				WHEN @IsShowDataByBranch = 0 AND po.FK_BRBranchID IN (SELECT * FROM @PermissionTable) THEN 1
				ELSE 0
			 END) = 1
		AND (@PlaningID IS NULL OR ppi.FK_ARProductionPlanningID = @PlaningID)
		AND (@ObjectID IS NULL OR so.FK_ACObjectID = @ObjectID)
		AND (@ObjectType IS NULL OR so.ARObjectType = @ObjectType)
		AND (@SaleOrderID IS NULL OR ppi.FK_ARSaleOrderID =  @SaleOrderID)
		AND (@FromDate IS NULL OR DATEDIFF(DD, @FromDate, po.ARProductionPlanningDate) >= 0)
		AND (@ToDate IS NULL OR DATEDIFF(DD, po.ARProductionPlanningDate, @ToDate) >= 0)
		AND ppi.ARProductionPlanningItemProductQty - ISNULL(batchProductItem.Qty, 0.00) > 0
END
GO

