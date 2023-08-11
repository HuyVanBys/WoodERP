SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		<LuuNguyen>
-- Create date: <2018-12-17>
-- Description:	<Posted Nhập kho>
-- =============================================
ALTER PROCEDURE [dbo].[IC_PostedICReceiptItems]
	@ModuleName NVARCHAR(256),
	@ICReceiptID INT,
	@IsPosted BIT
AS
BEGIN
	--DECLARE @ModuleName NVARCHAR(256) = 'PurchaseReceipt',
	--	@ICReceiptID INT = 5777,
	--	@IsPosted BIT = 1

	DECLARE @TransactionDate DATETIME = (select ICReceiptDate from ICReceipts with (nolock) where ICReceiptID = @ICReceiptID)

	declare @RoundNo decimal(18,5)
	select @RoundNo = ISNULL(GECurrencyDecimalNumber,0) From GECurrencies WHERE GECurrencyID = (select FK_GECurrencyID from ICReceipts with (nolock) where ICReceiptID = @ICReceiptID)

	declare @LockDate datetime
	select @LockDate = max(ADLockToDate) from ADLocks WHERE AAStatus = 'Alive' AND IsLocked = 1

	if 	DATEDIFF(DAY, @TransactionDate, @LockDate) >= 0
		return

	if exists(select ICTransactionReferenceID from ICTransactions with (nolock) where ICTransactionReferenceID = @ICReceiptID and ICTransactionModuleName = @ModuleName)
		DELETE FROM ICTransactions where ICTransactionReferenceID = @ICReceiptID and ICTransactionModuleName = @ModuleName
	
	if(@IsPosted = 0)
		RETURN

	SELECT 
		TOP 1
		r.*
		, e.HREmployeeName
	INTO #Receipt 
	FROM dbo.ICReceipts r
		LEFT JOIN dbo.HREmployees (NOLOCK) e ON e.HREmployeeID = r.FK_HREmployeeID
	WHERE r.AAStatus = 'Alive'
		AND r.ICReceiptID = @ICReceiptID

	SELECT 
		ri.*
		, p.FK_ACAccountID AS ProductAccountID
		, o.FK_ACAccountID AS OperationAccountID
		, s.FK_ACAccountID AS StockAccountID
	INTO #ReceiptItems
	FROM #Receipt r
		INNER JOIN dbo.ICReceiptItems (NOLOCK) ri ON ri.FK_ICReceiptID = r.ICReceiptID
		LEFT JOIN ICProducts (NOLOCK) p on ri.FK_ICProductID = p.ICProductID
		LEFT JOIN ICStocks (NOLOCK) s on s.ICStockID = ri.FK_ICStockID
		LEFT JOIN  MMOperations (NOLOCK) o on o.MMOperationID = ri.FK_MMOperationID and o.AAStatus = 'Alive'
	WHERE ri.AAStatus = 'Alive'
		AND r.AAStatus = 'Alive'
		AND r.ICReceiptID = @ICReceiptID

	SELECT 
		rs.* 
	INTO #SamePurchaseOrder
	FROM #Receipt r
		INNER JOIN dbo.ICReceipts (NOLOCK) rs ON rs.FK_APPurchaseOrderID = r.FK_APPurchaseOrderID
	WHERE rs.AAStatus = 'Alive'
		AND r.ICReceiptID <> rs.ICReceiptID

	DECLARE @ReceiptProportion DECIMAL(18,5)
		, @ReceiptRemainProportion DECIMAL(18,5)
		, @totalReceiptQty DECIMAL(18,6)
		, @ReceiptItemShipmentTotalCost DECIMAL(18,6)
		, @ReceiptItemShipmentTotalReceiptCost DECIMAL(18,5)

	SELECT	
		@ReceiptProportion = ISNULL(i.ICReceiptProportion, 0.000)
		, @ReceiptRemainProportion	= 100.000 - ISNULL(Proportion.value, 0.000)
	FROM #Receipt (NOLOCK) i
		OUTER APPLY(
			SELECT 
				ISNULL(SUM(r2.ICReceiptProportion) , 0.000) AS value
			FROM #SamePurchaseOrder r2
			WHERE r2.AAStatus = 'Alive'
				AND r2.ICReceiptDate < i.ICReceiptDate
				AND r2.FK_APPurchaseOrderID = i.FK_APPurchaseOrderID
		) AS proportion
	WHERE i.AAStatus = 'Alive'
		AND i.ICReceiptID = @ICReceiptID
	
	SELECT @totalReceiptQty = SUM(ri.ICReceiptItemProductQty)
		, @ReceiptItemShipmentTotalCost = ISNULL(ri.ICReceiptItemQty3, 0.000)
	FROM #ReceiptItems ri
	WHERE ri.AAStatus = 'Alive'
		AND ri.FK_ICReceiptID = @ICReceiptID
	GROUP BY ri.ICReceiptItemQty3

	DECLARE @totalCost DECIMAL(18,5) = 
	(
		ISNULL((select 0 - ICReceiptDiscountFix + ICReceiptShippingFees +	ICReceiptShippingExtraFees
		FROM #Receipt		
		WHERE ICReceiptID = @ICReceiptID 
			AND AAStatus = 'Alive'),0)		
		+ 
		ISNULL(( SELECT sum(ric.APFeePaymentReceiptAllocationCost/r.ICReceiptExchangeRate)
			FROM #Receipt r 
				INNER JOIN dbo.APFeePaymentReceipts ric ON ric.FK_ICReceiptID = r.ICReceiptID
			WHERE r.AAStatus = 'Alive'
				AND ric.AAStatus = 'Alive'	
				AND r.ICReceiptID = @ICReceiptID),0)
	)

	SELECT 
		ROW_NUMBER() OVER( ORDER BY ri.ICReceiptItemID) AS OrderIndex
		, ri.ICReceiptItemID
		, ri.ICReceiptItemProductQty
		, CAST(0.000 AS decimal(18,5)) AS Cost
		, ri.FK_APPurchaseOrderItemID
	INTO #CalculatorCost
	from #ReceiptItems ri
	where ri.AAStatus = 'Alive'
		and ri.FK_ICReceiptID = @ICReceiptID

	DECLARE @CountItem int = (select count(1) from #CalculatorCost)

	SELECT 
		@ReceiptItemShipmentTotalReceiptCost = ISNULL(SUM(t.ACTransactionDebitAmount), 0.000)
	FROM dbo.ACTransactions (NOLOCK) t
		INNER JOIN #SamePurchaseOrder p ON p.ICReceiptNo = t.ACTransactionNo
	WHERE t.AAStatus = 'Alive'
		AND t.ACTransactionCode01Combo = 'OutSourcing'
		AND DATEDIFF(DD, t.ACTransactionDate, @TransactionDate) <= 0

	DECLARE @ReceiptOutSourcingTotalCost DECIMAL(18,5) = CASE WHEN (@ReceiptRemainProportion <= 0)
															THEN 0
															ELSE ISNULL((@ReceiptProportion / @ReceiptRemainProportion) 
																* (@ReceiptItemShipmentTotalCost - @ReceiptItemShipmentTotalReceiptCost), 0.000)
															END
	SET @totalCost = @totalCost + @ReceiptOutSourcingTotalCost

	update  #CalculatorCost 
	set Cost = cast(ICReceiptItemProductQty * (@totalCost / @totalReceiptQty) as decimal(18,5))
	where OrderIndex in (select top (@CountItem - 1) OrderIndex from #CalculatorCost order by OrderIndex asc)
	
	declare @totalCalculator decimal(18,5) = (select sum(Cost) from #CalculatorCost)

	update #CalculatorCost 
	set Cost = cast((@totalCost - @totalCalculator) as decimal(18,5))
	where OrderIndex in (select top 1 OrderIndex from #CalculatorCost order by OrderIndex desc)

	SELECT 
		ROW_NUMBER() OVER( ORDER BY ri.ICReceiptItemID) AS OrderIndex
		, ri.ICReceiptItemID
		, CAST(SUM((bol.APBillOfLadingItemImportTaxAmount + bol.APBillOfLadingItemConsumptionTaxAmount + bol.APBillOfLadingItemEnviromentTaxAmount)/r.ICReceiptExchangeRate) AS DECIMAL(18,5)) AS Cost
		, ii.APInvoiceInItemProductQty AS Qty
	INTO #CalculatorCost2
	FROM #ReceiptItems ri
		INNER JOIN dbo.APInvoiceInItems ii ON ii.APInvoiceInItemID = ri.FK_APInvoiceInItemID
		INNER JOIN #Receipt r ON r.ICReceiptID = ri.FK_ICReceiptID
		INNER JOIN dbo.APBillOfLadingItems bol ON bol.APBillOfLadingItemID = ri.FK_APBillOfLadingItemID
	WHERE ri.AAStatus = 'Alive'
		AND r.AAStatus = 'Alive'
		AND r.ICReceiptID = @ICReceiptID
	GROUP BY
		ri.ICReceiptItemID, ii.APInvoiceInItemProductQty

	SELECT * INTO #ConfigAccount FROM MMConfigAccountOperations WHERE AAStatus = 'Alive'
	INSERT INTO ICTransactions
	SELECT  
		ri.AAStatus
		, GETDATE()
		, ri.AACreatedUser
		, GETDATE()
		, ri.AAUpdatedUser
		, r.ICReceiptID
		, r.ICReceiptNo
		, @ModuleName
		, r.ICReceiptTypeCombo
		, r.ICReceiptDate
		, ri.ICReceiptItemID
		, r.FK_HREmployeeID
		, r.FK_BRBranchID
		, r.FK_ACObjectID
		, r.ICObjectType
		, r.HREmployeeName
		, r.ICReceiptDesc
		, ri.ICReceiptItemProductDesc
		, r.FK_GECurrencyID
		, r.ICReceiptExchangeRate
		, ri.FK_ICStockID
		, 1 --Nhập xuất (1:Nhập, 2: Xuất)
		, ri.FK_ICImportAndExportReasonID
		, ri.ICReceiptItemIsSpecificCalculation
		, ri.ICReceiptItemIsAverageCalculation
		, ri.FK_ICProductID
		, ri.ICReceiptItemLotNo
		, ri.ICReceiptItemProductSerialNo
		, ri.FK_ICMeasureUnitID
		, ri.ICReceiptItemProductQty
		, (CASE WHEN (ri.ICReceiptItemProductFactor IS NULL OR ri.ICReceiptItemProductFactor = 0) THEN 1 ELSE ri.ICReceiptItemProductFactor END)
		, ri.ICReceiptItemProductQty * (CASE WHEN (ri.ICReceiptItemProductFactor IS NULL OR ri.ICReceiptItemProductFactor = 0) THEN 1 ELSE ri.ICReceiptItemProductFactor END)
		, ri.ICReceiptItemWoodQty AS ICTransactionQty1
		, 0 AS ICTransactionQty2
		, 0 AS ICTransactionQty3
		, '' AS ICTransactionFeePaymentType
		, (((ri.ICReceiptItemProductUnitCost *  ri.ICReceiptItemProductQty) - ri.ICReceiptItemDiscountAmount ) / ri.ICReceiptItemProductQty)
			+ (ISNULL((SELECT cc.Cost FROM #CalculatorCost cc WHERE cc.ICReceiptItemID = ri.ICReceiptItemID),0) / ri.ICReceiptItemProductQty)
			+ (ISNULL((SELECT cc.Cost / cc.Qty FROM #CalculatorCost2 cc WHERE cc.ICReceiptItemID = ri.ICReceiptItemID),0))
		, ROUND(((ri.ICReceiptItemProductUnitCost *  ri.ICReceiptItemProductQty) - ri.ICReceiptItemDiscountAmount)
			+ ISNULL((SELECT cc.Cost FROM #CalculatorCost cc WHERE cc.ICReceiptItemID = ri.ICReceiptItemID),0)
			+ ISNULL((SELECT cc.Cost FROM #CalculatorCost2 cc WHERE cc.ICReceiptItemID = ri.ICReceiptItemID),0)
			,@RoundNo)
		, ROUND(((ri.ICReceiptItemProductUnitCost *  ri.ICReceiptItemProductQty) - ri.ICReceiptItemDiscountAmount) / ri.ICReceiptItemProductQty * r.ICReceiptExchangeRate
			+ (ISNULL((SELECT cc.Cost FROM #CalculatorCost cc WHERE cc.ICReceiptItemID = ri.ICReceiptItemID),0) / ri.ICReceiptItemProductQty * r.ICReceiptExchangeRate)
			+ (ISNULL((SELECT cc.Cost / cc.Qty FROM #CalculatorCost2 cc WHERE cc.ICReceiptItemID = ri.ICReceiptItemID),0)  * r.ICReceiptExchangeRate)
			,0)
		, CAST(ROUND(((ri.ICReceiptItemProductUnitCost *  ri.ICReceiptItemProductQty) - ri.ICReceiptItemDiscountAmount ) * r.ICReceiptExchangeRate
			+ (ISNULL((SELECT cc.Cost FROM #CalculatorCost cc WHERE cc.ICReceiptItemID = ri.ICReceiptItemID),0) * r.ICReceiptExchangeRate)
			+ ((ISNULL((SELECT cc.Cost FROM #CalculatorCost2 cc WHERE cc.ICReceiptItemID = ri.ICReceiptItemID),0)) * r.ICReceiptExchangeRate),0) AS DECIMAL(18,5))
		, CASE 
				WHEN (@ModuleName = 'MaterialReceipt' ) AND ISNULL(co.FK_ACCostAccountID,cwo.FK_ACCostAccountID) > 0 AND ri.FK_ICProductForBatchID > 0 THEN ISNULL(co.FK_ACCostAccountID,cwo.FK_ACCostAccountID) 
				WHEN (@ModuleName = 'MaterialReceipt' ) AND ISNULL(cw.FK_ACCostAccountID,0) > 0 AND (ri.FK_MMBatchProductID = 0 OR ri.FK_ICProductForBatchID = 0) THEN ISNULL(cw.FK_ACCostAccountID,0)
				WHEN ri.FK_ACAccountID <> 0 then ri.FK_ACAccountID
				WHEN ri.StockAccountID <> 0 THEN ri.StockAccountID
				WHEN ri.ProductAccountID <> 0 THEN ri.ProductAccountID
				WHEN ISNULL(ri.OperationAccountID,0) > 0 THEN ISNULL(ri.OperationAccountID,0) 
				ELSE ri.FK_ACAccountID
			END
		--, ri.FK_ACOffsetAccountID
		,	CASE WHEN (@ModuleName = 'SemiProductReceipt' OR (@ModuleName = 'Receipt' AND r.ICReceiptTypeCombo ='ReceiptError') ) AND ISNULL(co.FK_ACCostAccountID,cwo.FK_ACCostAccountID) > 0 
					THEN ISNULL(co.FK_ACCostAccountID,cwo.FK_ACCostAccountID) 
				 WHEN @ModuleName = 'MaterialReceipt' AND ri.ProductAccountID  > 0 THEN ri.ProductAccountID
			ELSE ri.FK_ACOffsetAccountID END
		, ri.FK_ACTransitInAccountID
		, 0 AS FK_ACCostCenterID
		, r.FK_ACSegmentID
		, CASE WHEN ISNULL(ri.FK_MMBatchProductID,0) = 0 THEN r.FK_MMBatchProductID ELSE ri.FK_MMBatchProductID END
		, CASE WHEN ri.FK_ARSaleOrderID = 0 THEN bp.FK_ARSaleOrderID ELSE ri.FK_ARSaleOrderID END 
		, r.FK_HRDepartmentID
		, r.FK_HRDepartmentRoomID
		, ri.FK_MMWorkShopID
		, ri.FK_MMOperationID
		, ri.FK_MMLineID
		, ri.FK_HRDepartmentRoomGroupItemID
		, r.FK_PMProjectID AS FK_PMProjectID
		, ri.FK_ACAssetID
		, ri.FK_ICProductEquipmentID
		, ri.FK_ACCostObjectID
		, 0 AS FK_ACUnfinishedConstructionCostID
		, 0 AS FK_ACLoanReceiptID
		, ri.ICReceiptItemCode01Combo
		, ri.ICReceiptItemCode02Combo
		, ri.ICReceiptItemCode03Combo
		, ri.ICReceiptItemCode04Combo
		, ri.ICReceiptItemCode05Combo
		, ri.ICReceiptItemCode06Combo
		, ri.ICReceiptItemCode07Combo
		, ri.ICReceiptItemCode08Combo
		, CASE WHEN @ModuleName = 'SemiProductReceipt' THEN r.ICReceiptCreateFrom ELSE ri.ICReceiptItemCode09Combo END
		, ri.FK_MMBatchProductProductionNormItemID --ICReceiptItemCode10Combo 
		, 0
		, 0
		, ri.ICReceiptItemProductLength
		, ri.ICReceiptItemProductWidth
		, ri.ICReceiptItemProductHeight
		, ''
		, ri.FK_ICProductAttributeQualityID
		, ri.FK_MMBatchProductItemID
		, CASE WHEN ri.FK_ICProductForBatchID = 0 THEN bp.FK_ICProductForBatchID ELSE ri.FK_ICProductForBatchID END --FK_ICProductForBatchID
		, NULL--ICTransactionExpiryDate
		, ri.ICReceiptItemLenghtMin
		, ri.ICReceiptItemWidthMin
		, 0 -- ICTransactionHeightMin
		, ri.ICReceiptItemLenghtMax
		, ri.ICReceiptItemWidthMax
		, ri.ICReceiptItemHeightMax
		, ri.ICReceiptItemProductPerimeter
	FROM #Receipt r 
		INNER JOIN #ReceiptItems ri ON r.ICReceiptID = ri.FK_ICReceiptID
		OUTER APPLY 
		(	
			SELECT 
				TOP 1 co.FK_ACCostAccountID 
			FROM  #ConfigAccount co 
			WHERE co.FK_MMOperationID = ri.FK_MMOperationID AND co.AAStatus = 'Alive' 
				AND co.FK_MMWorkShopID = ri.FK_MMWorkShopID
				AND co.MMConfigAccountOperationMainMaterial= 1 
				AND co.MMConfigAccountOperationSpecifyBatchProduct = 1
				AND @ModuleName = 'MaterialReceipt'
		) co
		OUTER APPLY 
		(	
			SELECT 
				TOP 1 co.FK_ACCostAccountID 
			FROM  #ConfigAccount co 
			WHERE co.FK_MMOperationID = ri.FK_MMOperationID AND co.AAStatus = 'Alive' 
				AND (co.FK_MMWorkShopID = ri.FK_MMWorkShopID OR co.FK_MMWorkShopID = 0)
				AND co.MMConfigAccountOperationMainMaterial = 0 
				AND co.MMConfigAccountOperationSpecifyBatchProduct = 1
				AND @ModuleName = 'MaterialReceipt'
		) cwo
		OUTER APPLY
		(	
			SELECT 
				TOP 1 co.FK_ACCostAccountID 
			FROM  #ConfigAccount co 
			WHERE co.FK_MMOperationID = ri.FK_MMOperationID AND co.AAStatus = 'Alive' 
				AND (co.FK_MMWorkShopID = ri.FK_MMWorkShopID OR co.FK_MMWorkShopID = 0)
				AND co.MMConfigAccountOperationMainMaterial = 0 
				AND co.MMConfigAccountOperationSpecifyBatchProduct = 0
				AND (ri.FK_MMBatchProductID = 0 OR ri.FK_ICProductForBatchID = 0)
				AND (@ModuleName = 'MaterialReceipt')
		) cw -- khong có lSX và có CD + Xưởng
		OUTER APPLY (SELECT TOP 1 bp.FK_ICProductID AS FK_ICProductForBatchID, bp.FK_ARSaleOrderID  FROM dbo.MMBatchProductItems (NOLOCK) bp WHERE  bp.MMBatchProductItemID = ri.FK_MMBatchProductItemID AND bp.AAStatus ='Alive') bp
	WHERE ri.AAStatus = 'Alive'
		AND r.AAStatus = 'Alive'
		AND r.ICReceiptID = @ICReceiptID
		AND ri.ICReceiptItemProductQty > 0

	DROP TABLE #ConfigAccount
	DROP TABLE #CalculatorCost
	DROP TABLE #Receipt
	DROP TABLE #ReceiptItems
	DROP TABLE #SamePurchaseOrder
	DROP TABLE #CalculatorCost2
END		






GO

