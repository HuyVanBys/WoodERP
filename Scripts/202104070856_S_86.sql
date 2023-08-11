SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO


-- =============================================
-- Author:		<LuuNguyen>
-- Create date: <2018-12-17>
-- Description:	<Posted Xuất kho>
-- =============================================
ALTER PROCEDURE [dbo].[IC_PostedICShipmentItems]
	@ModuleName NVARCHAR(256),
	@ICShipmentID INT,
	@IsPosted BIT
AS
BEGIN
	declare @TransactionDate datetime = (select ICShipmentDate from ICShipments with (nolock) where ICShipmentID = @ICShipmentID)

	declare @RoundNo decimal(18,5)
	select @RoundNo = ISNULL(GECurrencyDecimalNumber,0) From GECurrencies WHERE GECurrencyID = (select FK_GECurrencyID from ICShipments with (nolock) where ICShipmentID = @ICShipmentID)

	declare @LockDate datetime
	select @LockDate = max(ADLockToDate) from ADLocks WHERE AAStatus = 'Alive' AND IsLocked = 1

	if 	DATEDIFF(DAY, @TransactionDate, @LockDate) >= 0
		return

	if exists(select ICTransactionReferenceID from ICTransactions with (nolock) where ICTransactionReferenceID = @ICShipmentID and ICTransactionModuleName = @ModuleName)
		delete from ICTransactions where ICTransactionReferenceID = @ICShipmentID and ICTransactionModuleName = @ModuleName

	if(@IsPosted = 0)
		return
	
	SELECT * INTO #ConfigOperation FROM MMConfigAccountOperations

	INSERT INTO ICTransactions
	SELECT
		si.AAStatus
		, GETDATE()
		, s.AACreatedUser
		, GETDATE()
		, s.AAUpdatedUser
		, s.ICShipmentID
		, s.ICShipmentNo
		, @ModuleName
		, s.ICShipmentTypeCombo
		, s.ICShipmentDate
		, si.ICShipmentItemID
		, s.FK_HREmployeeID
		, s.FK_BRBranchID
		, s.FK_ACObjectID
		, s.ICObjectType
		, e.HREmployeeName
		, s.ICShipmentDesc
		, si.ICShipmentItemProductDesc
		, s.FK_GECurrencyID
		, s.ICShipmentExchangeRate
		, si.FK_ICStockID
		, 2 --Nhập xuất (1:Nhập, 2: Xuất)
		, si.FK_ICImportAndExportReasonID
		, si.ICShipmentItemIsSpecificCalculation
		, si.ICShipmentItemIsAverageCalculation
		, si.FK_ICProductID
		, si.ICShipmentItemLotNo
		, si.ICShipmentItemProductSerialNo
		, si.FK_ICMeasureUnitID
		, si.ICShipmentItemProductQty
		, si.ICShipmentItemProductFactor
		, si.ICShipmentItemProductExchangeQty
		, si.ICShipmentItemWoodQty AS ICTransactionQty1
		, 0 AS ICTransactionQty2
		, 0 AS ICTransactionQty3
		, '' AS ICTransactionFeePaymentType
		, si.ICShipmentItemProductUnitCost
		, ROUND(si.ICShipmentItemTotalCost,@RoundNo)
		, ROUND(si.ICShipmentItemExchangeUnitCost,0)
		, ROUND(si.ICShipmentItemExchangeTotalCost,0)
		--, si.FK_ACAccountID
		,	CASE WHEN (@ModuleName = 'MaterialShipment' OR @ModuleName = 'BatchShipmentDryLumber' OR @ModuleName = 'SemiProductShipment' ) 
						AND o.FK_ACCostAccountID > 0 THEN o.FK_ACCostAccountID
					ELSE si.FK_ACAccountID END
		--, si.FK_ACOffsetAccountID
		,	CASE WHEN (@ModuleName = 'BatchShipmentDryLumber' OR @ModuleName = 'SemiProductShipment' ) AND ISNULL(co.FK_ACCostAccountID,0) > 0 THEN ISNULL(co.FK_ACCostAccountID,0) 
			WHEN @ModuleName = 'MaterialShipment' AND cwo.FK_ACCostAccountID > 0 AND si.FK_ICProductForBatchID > 0 THEN cwo.FK_ACCostAccountID
			WHEN @ModuleName = 'MaterialShipment' AND cw.FK_ACCostAccountID > 0 AND si.FK_ICProductForBatchID = 0 THEN cw.FK_ACCostAccountID
			ELSE si.FK_ACOffsetAccountID END
		, si.FK_ACTransitInAccountID
		, 0 AS FK_ACCostCenterID
		, s.FK_ACSegmentID
		, CASE WHEN ISNULL(si.FK_MMBatchProductID,0) = 0 THEN s.FK_MMBatchProductID ELSE si.FK_MMBatchProductID END
		, ISNULL(bpi.FK_ARSaleOrderID,0) AS FK_ARSaleOrderID
		, s.FK_HRDepartmentID
		, s.FK_HRDepartmentRoomID
		, si.FK_MMWorkShopID
		, si.FK_MMOperationID
		, si.FK_MMLineID
		, si.FK_HRDepartmentRoomGroupItemID
		, s.FK_PMProjectID AS FK_PMProjectID
		, si.FK_ACAssetID
		, si.FK_ICProductEquipmentID
		, si.FK_ACCostObjectID
		, 0 AS FK_ACUnfinishedConstructionCostID
		, 0 AS FK_ACLoanReceiptID
		, si.ICShipmentItemCode01Combo
		, si.ICShipmentItemCode02Combo
		, si.ICShipmentItemCode03Combo
		, si.ICShipmentItemCode04Combo
		, si.ICShipmentItemCode05Combo
		, si.ICShipmentItemCode06Combo
		, si.ICShipmentItemCode07Combo
		, si.ICShipmentItemCode08Combo
		, si.ICShipmentItemCode09Combo
		, si.FK_MMBatchProductProductionNormItemID
		, si.FK_ICPerimeterGroupID
		, si.FK_ICLengthGroupID
		, si.ICShipmentItemLength
		, si.ICShipmentItemWidth
		, si.ICShipmentItemHeight
		, s.ICShipmentPurposeType
		, si.FK_ICProductAttributeQualityID
		, si.FK_MMBatchProductItemID
		, CASE WHEN si.FK_ICProductForBatchID = 0 THEN bpi.FK_ICProductForBatchID ELSE si.FK_ICProductForBatchID END --FK_ICProductForBatchID
		, NULL--ICTransactionExpiryDate
		, si.ICShipmentItemLengthMin
		, si.ICShipmentItemWidthMin
		, si.ICShipmentItemHeightMin
		, si.ICShipmentItemLengthMax
		, si.ICShipmentItemWidthMax
		, si.ICShipmentItemHeightMax
		, si.ICShipmentItemPerimeter
	FROM ICShipmentItems si  WITH (NOLOCK)
		INNER JOIN ICShipments s WITH (NOLOCK) ON si.FK_ICShipmentID = s.ICShipmentID
		LEFT JOIN HREmployees e WITH (NOLOCK) ON s.FK_HREmployeeID = e.HREmployeeID
		OUTER APPLY (	SELECT TOP 1 co.FK_ACCostAccountID 
								FROM  #ConfigOperation co 
								WHERE co.FK_MMOperationID = si.FK_MMOperationID AND co.AAStatus = 'Alive' 
								AND co.FK_MMWorkShopID = si.FK_MMWorkShopID
								AND co.MMConfigAccountOperationMainMaterial= 1 
								AND (@ModuleName = 'BatchShipmentDryLumber' OR @ModuleName = 'SemiProductShipment')
								AND co.MMConfigAccountOperationSpecifyBatchProduct = 1
								) co
		OUTER APPLY (	SELECT TOP 1 co.FK_ACCostAccountID 
								FROM  #ConfigOperation co 
								WHERE co.FK_MMOperationID = si.FK_MMOperationID AND co.AAStatus = 'Alive' 
								AND (co.FK_MMWorkShopID = si.FK_MMWorkShopID OR co.FK_MMWorkShopID = 0)
								AND si.FK_ICProductForBatchID > 0
								AND co.MMConfigAccountOperationMainMaterial = 0 
								AND co.MMConfigAccountOperationSpecifyBatchProduct = 1
								AND (@ModuleName = 'MaterialShipment')
								) cwo
		OUTER APPLY (	SELECT TOP 1 co.FK_ACCostAccountID 
								FROM  #ConfigOperation co 
								WHERE co.FK_MMOperationID = si.FK_MMOperationID AND co.AAStatus = 'Alive' 
								AND (co.FK_MMWorkShopID = si.FK_MMWorkShopID OR co.FK_MMWorkShopID = 0)
								AND co.MMConfigAccountOperationMainMaterial = 0 
								AND co.MMConfigAccountOperationSpecifyBatchProduct = 0
								AND (si.FK_MMBatchProductID = 0 OR si.FK_ICProductForBatchID = 0)
								AND (@ModuleName = 'MaterialShipment')
								) cw -- khong có lSX và có CD + Xưởng
		LEFT JOIN  MMOperations (NOLOCK)o on o.MMOperationID = si.FK_MMOperationID and o.AAStatus = 'Alive'
		OUTER APPLY (	SELECT TOP 1 bpi.FK_ARSaleOrderID, bpi.FK_ICProductID AS FK_ICProductForBatchID
						FROM  dbo.MMBatchProductItems bpi 
						WHERE bpi.AAStatus = 'Alive' 
						AND bpi.MMBatchProductItemID = si.FK_MMBatchProductItemID
						) bpi
	WHERE si.AAStatus = 'Alive'
		AND s.AAStatus = 'Alive'
		AND s.ICShipmentID = @ICShipmentID
		AND NOT EXISTS
			(
				SELECT 1 
				FROM  ICShipmentItemComponents sic
				WHERE sic.AAStatus = 'Alive'
				AND sic.FK_ICShipmentItemID = si.ICShipmentItemID
				)
UNION all
	SELECT
		si.AAStatus
		, GETDATE()
		, s.AACreatedUser
		, GETDATE()
		, s.AAUpdatedUser
		, s.ICShipmentID
		, s.ICShipmentNo
		, @ModuleName
		, s.ICShipmentTypeCombo
		, s.ICShipmentDate
		, si.ICShipmentItemID
		, s.FK_HREmployeeID
		, s.FK_BRBranchID
		, s.FK_ACObjectID
		, s.ICObjectType
		, e.HREmployeeName
		, s.ICShipmentDesc
		, p.ProductDesc
		, s.FK_GECurrencyID
		, s.ICShipmentExchangeRate
		, si.FK_ICStockID
		, 2 --Nhập xuất (1:Nhập, 2: Xuất)
		, si.FK_ICImportAndExportReasonID
		, si.ICShipmentItemIsSpecificCalculation
		, si.ICShipmentItemIsAverageCalculation
		, sic.FK_ICProductID
		, ps.ICProductSerieLotNo
		, ps.ICProductSerieNo
		, si.FK_ICMeasureUnitID
		, sic.ICShipmentItemComponentQty
		, si.ICShipmentItemProductFactor
		, sic.ICShipmentItemComponentQty * si.ICShipmentItemProductFactor
		, si.ICShipmentItemWoodQty AS ICTransactionQty1
		, 0 AS ICTransactionQty2
		, 0 AS ICTransactionQty3
		, '' AS ICTransactionFeePaymentType
		, si.ICShipmentItemProductUnitCost
		, CASE WHEN s.ICShipmentExchangeRate > 1 THEN
						ROUND(cost.ICTransactionExchangeUnitCost / s.ICShipmentExchangeRate,@RoundNo)
					ELSE cost.ICTransactionExchangeUnitCost END  * sic.ICShipmentItemComponentQty AS ARInvoiceItemTotalCost
		, cost.ICTransactionExchangeUnitCost
		, cost.ICTransactionExchangeUnitCost * sic.ICShipmentItemComponentQty
		--, si.FK_ACAccountID
		,	CASE WHEN (@ModuleName = 'MaterialShipment' OR @ModuleName = 'BatchShipmentDryLumber' OR @ModuleName = 'SemiProductShipment' ) 
						AND o.FK_ACCostAccountID > 0 THEN o.FK_ACCostAccountID
					ELSE si.FK_ACAccountID END
		--, si.FK_ACOffsetAccountID
		,	CASE WHEN (@ModuleName = 'BatchShipmentDryLumber' OR @ModuleName = 'SemiProductShipment' ) AND ISNULL(co.FK_ACCostAccountID,0) > 0 THEN ISNULL(co.FK_ACCostAccountID,0) 
			WHEN @ModuleName = 'MaterialShipment' AND cwo.FK_ACCostAccountID > 0 AND si.FK_ICProductForBatchID > 0 THEN cwo.FK_ACCostAccountID
			WHEN @ModuleName = 'MaterialShipment' AND cw.FK_ACCostAccountID > 0 AND si.FK_ICProductForBatchID = 0 THEN cw.FK_ACCostAccountID
			ELSE si.FK_ACOffsetAccountID END
		, si.FK_ACTransitInAccountID
		, 0 AS FK_ACCostCenterID
		, s.FK_ACSegmentID
		, CASE WHEN ISNULL(si.FK_MMBatchProductID,0) = 0 THEN s.FK_MMBatchProductID ELSE si.FK_MMBatchProductID END
		, ISNULL(bpi.FK_ARSaleOrderID,0) AS FK_ARSaleOrderID
		, s.FK_HRDepartmentID
		, s.FK_HRDepartmentRoomID
		, si.FK_MMWorkShopID
		, si.FK_MMOperationID
		, si.FK_MMLineID
		, si.FK_HRDepartmentRoomGroupItemID
		, s.FK_PMProjectID AS FK_PMProjectID
		, si.FK_ACAssetID
		, si.FK_ICProductEquipmentID
		, si.FK_ACCostObjectID
		, 0 AS FK_ACUnfinishedConstructionCostID
		, 0 AS FK_ACLoanReceiptID
		, si.ICShipmentItemCode01Combo
		, si.ICShipmentItemCode02Combo
		, si.ICShipmentItemCode03Combo
		, si.ICShipmentItemCode04Combo
		, si.ICShipmentItemCode05Combo
		, si.ICShipmentItemCode06Combo
		, si.ICShipmentItemCode07Combo
		, si.ICShipmentItemCode08Combo
		, si.ICShipmentItemCode09Combo
		, si.FK_MMBatchProductProductionNormItemID
		, si.FK_ICPerimeterGroupID
		, si.FK_ICLengthGroupID
		, si.ICShipmentItemLength
		, si.ICShipmentItemWidth
		, si.ICShipmentItemHeight
		, s.ICShipmentPurposeType
		, si.FK_ICProductAttributeQualityID
		, si.FK_MMBatchProductItemID
		, CASE WHEN si.FK_ICProductForBatchID = 0 THEN bpi.FK_ICProductForBatchID ELSE si.FK_ICProductForBatchID END --FK_ICProductForBatchID
		, NULL--ICTransactionExpiryDate
		, si.ICShipmentItemLengthMin
		, si.ICShipmentItemWidthMin
		, si.ICShipmentItemHeightMin
		, si.ICShipmentItemLengthMax
		, si.ICShipmentItemWidthMax
		, si.ICShipmentItemHeightMax
		, si.ICShipmentItemPerimeter
	FROM ICShipmentItems si  WITH (NOLOCK)
		INNER JOIN ICShipments s WITH (NOLOCK) ON si.FK_ICShipmentID = s.ICShipmentID
		INNER JOIN ICShipmentItemComponents sic WITH(NOLOCK) ON sic.FK_ICShipmentItemID = si.ICShipmentItemID
		INNER JOIN ICProducts p WITH (NOLOCK) ON p.ICProductID = sic.FK_ICProductID
		LEFT JOIN HREmployees e WITH (NOLOCK) ON s.FK_HREmployeeID = e.HREmployeeID
		OUTER APPLY (SELECT ICProductSerieNo, ICProductSerieLotNo FROM dbo.ICProductSeries c WHERE c.ICProductSerieID = sic.FK_ICProductSerieID) AS ps
		OUTER APPLY (	SELECT TOP 1 co.FK_ACCostAccountID 
								FROM  #ConfigOperation co 
								WHERE co.FK_MMOperationID = si.FK_MMOperationID AND co.AAStatus = 'Alive' 
								AND co.FK_MMWorkShopID = si.FK_MMWorkShopID
								AND co.MMConfigAccountOperationMainMaterial= 1 
								AND (@ModuleName = 'BatchShipmentDryLumber' OR @ModuleName = 'SemiProductShipment')
								AND co.MMConfigAccountOperationSpecifyBatchProduct = 1
								) co
		OUTER APPLY (	SELECT TOP 1 co.FK_ACCostAccountID 
								FROM  #ConfigOperation co 
								WHERE co.FK_MMOperationID = si.FK_MMOperationID AND co.AAStatus = 'Alive' 
								AND (co.FK_MMWorkShopID = si.FK_MMWorkShopID OR co.FK_MMWorkShopID = 0)
								AND si.FK_ICProductForBatchID > 0
								AND co.MMConfigAccountOperationMainMaterial = 0 
								AND co.MMConfigAccountOperationSpecifyBatchProduct = 1
								AND (@ModuleName = 'MaterialShipment')
								) cwo
		OUTER APPLY (	SELECT TOP 1 co.FK_ACCostAccountID 
								FROM  #ConfigOperation co 
								WHERE co.FK_MMOperationID = si.FK_MMOperationID AND co.AAStatus = 'Alive' 
								AND (co.FK_MMWorkShopID = si.FK_MMWorkShopID OR co.FK_MMWorkShopID = 0)
								AND co.MMConfigAccountOperationMainMaterial = 0 
								AND co.MMConfigAccountOperationSpecifyBatchProduct = 0
								AND (si.FK_MMBatchProductID = 0 OR si.FK_ICProductForBatchID = 0)
								AND (@ModuleName = 'MaterialShipment')
								) cw -- khong có lSX và có CD + Xưởng
		LEFT JOIN  MMOperations (NOLOCK)o on o.MMOperationID = si.FK_MMOperationID and o.AAStatus = 'Alive'
		OUTER APPLY (	SELECT TOP 1 bpi.FK_ARSaleOrderID, bpi.FK_ICProductID AS FK_ICProductForBatchID
						FROM  dbo.MMBatchProductItems bpi 
						WHERE bpi.AAStatus = 'Alive' 
						AND bpi.MMBatchProductItemID = si.FK_MMBatchProductItemID
						) bpi
		OUTER APPLY (
					SELECT TOP 1 t.ICTransactionExchangeUnitCost 
					FROM dbo.ICTransactions t 
					WHERE t.ICTransactionReceiptSerialNo = ps.ICProductSerieNo
					AND t.FK_ICProductID = sic.FK_ICProductID
					AND t.ICTransactionType = 1
					AND t.AAStatus ='Alive'
				) cost
	WHERE si.AAStatus = 'Alive'
		AND s.AAStatus = 'Alive'
		AND s.ICShipmentID = @ICShipmentID
	DROP TABLE #ConfigOperation
END



GO

