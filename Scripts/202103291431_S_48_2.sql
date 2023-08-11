SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO

-- =============================================
-- Author:		<BinhNguyen>
-- Create date: <2018-12-17>
-- Description:	<Posted Xuất kho>
-- =============================================
ALTER PROCEDURE [dbo].[ICTransactions_PostedARInvoiceItems]
	@ModuleName nvarchar(256),
	@ARInvoiceID int,
	@IsPosted bit
AS
BEGIN
	declare @TransactionDate datetime = (select ARInvoiceDate from dbo.ARInvoices with (nolock) where ARInvoiceID = @ARInvoiceID)

	declare @RoundNo decimal(18,5)
	select @RoundNo = ISNULL(GECurrencyDecimalNumber,0) From GECurrencies WHERE GECurrencyID = (select FK_GECurrencyID from dbo.ARInvoices with (nolock) where ARInvoiceID = @ARInvoiceID)

	declare @LockDate datetime
	select @LockDate = max(ADLockToDate) from ADLocks WHERE AAStatus = 'Alive' AND IsLocked = 1

	if 	DATEDIFF(DAY, @TransactionDate, @LockDate) >= 0
		return

	if exists(select ICTransactionReferenceID from ICTransactions with (nolock) where ICTransactionReferenceID = @ARInvoiceID and ICTransactionModuleName = @ModuleName)
		delete from ICTransactions where ICTransactionReferenceID = @ARInvoiceID and ICTransactionModuleName = @ModuleName

	if(@IsPosted = 0)
		return

-----Get items-----
	SELECT ii.AAStatus
		, i.AACreatedUser
		, i.AAUpdatedUser
		, i.ARInvoiceID
		, i.ARInvoiceNo
		, i.ARInvoiceTypeCombo
		, i.ARInvoiceDate
		, ii.ARInvoiceItemID
		, i.FK_HREmployeeID
		, i.FK_BRBranchID
		, i.FK_ACObjectID
		, i.ARObjectType
		, e.HREmployeeName
		, i.ARInvoiceDesc
		, p.ICProductDesc AS ARInvoiceItemProductDesc
		, i.FK_GECurrencyID
		, i.ARInvoiceExchangeRate
		, ic.FK_ICStockID
		, ii.ARInvoiceItemIsSpecificCalculation
		, CASE
			WHEN (SELECT ICPriceCalculationMethodMethod FROM dbo.ICPriceCalculationMethods WHERE ICPriceCalculationMethodID = p.FK_ICPriceCalculationMethodID AND AAStatus = 'Alive') = 'Specific' THEN 0
			ELSE 1
		  END AS PriceCalculationMethod
		, ic.FK_ICProductID
		, ps.ICProductSerieLotNo AS ARInvoiceItemLotNo
		, ps.ICProductSerieNo AS ARInvoiceItemProductSerialNo
		, p.FK_ICProductBasicUnitID AS FK_ICMeasureUnitID
		, ic.ARInvoiceItemComponentQty AS ARInvoiceItemProductQty
		, ii.ARInvoiceItemProductFactor
		, ic.ARInvoiceItemComponentQty * ii.ARInvoiceItemProductFactor AS ARInvoiceItemProductExchangeQty
		, 0 AS ICTransactionQty1
		, 0 AS ARInvoiceItemProductUnitCost
		--, round(ii.ARInvoiceItemTotalCost,@RoundNo) AS ARInvoiceItemTotalCost
		--, round(ii.ARInvoiceItemExchangeUnitCost,0) AS ARInvoiceItemExchangeUnitCost
		--, round(ii.ARinvoiceItemExchangeTotalCost,0) AS ARinvoiceItemExchangeTotalCost
		,  CASE WHEN i.ARInvoiceExchangeRate > 1 THEN
						ROUND(cost.ICTransactionExchangeUnitCost / i.ARInvoiceExchangeRate,@RoundNo)
					ELSE cost.ICTransactionExchangeUnitCost END  * ic.ARInvoiceItemComponentQty AS ARInvoiceItemTotalCost
		, cost.ICTransactionExchangeUnitCost AS ARInvoiceItemExchangeUnitCost
		, cost.ICTransactionExchangeUnitCost * ic.ARInvoiceItemComponentQty  AS ARinvoiceItemExchangeTotalCost
		, st.FK_ACAccountID
		, p.ICProductLength		AS ARInvoiceItemLength
		, p.ICProductWidth		AS ARInvoiceItemWidth
		, p.ICProductHeight		AS ARInvoiceItemHeight
		, p.ICProductMinLength	AS ARInvoiceItemLengthMin
		, p.ICProductWidth		AS ARInvoiceItemWidthMin 
		, p.ICProductHeight		AS ARInvoiceItemHeightMin
		, p.ICProductLength		AS ARInvoiceItemLentghMax
		, p.ICProductWidth		AS ARInvoiceItemWidthMax
		, p.ICProductMaxHeight	AS ARInvoiceItemHeightMax
		, ii.ARInvoiceItemPerimeter
	INTO #InvoiceItemPosted
	FROM [dbo].[ARInvoiceItems] ii (NOLOCK)
		INNER JOIN [dbo].[ARInvoices] i (NOLOCK) ON i.ARInvoiceID = ii.FK_ARInvoiceID AND i.AAStatus = 'Alive'
		INNER JOIN [dbo].[ARInvoiceItemComponents] ic (NOLOCK) ON ic.FK_ARInvoiceItemID = ii.ARInvoiceItemID AND ic.AAStatus = 'Alive'
		INNER JOIN dbo.ICProducts p (NOLOCK) ON p.ICProductID = ic.FK_ICProductID
		OUTER APPLY (SELECT FK_ACAccountID FROM dbo.ICStocks WHERE ICStockID = ic.FK_ICStockID) AS st
		OUTER APPLY (SELECT ICProductSerieNo, ICProductSerieLotNo FROM dbo.ICProductSeries c WHERE c.ICProductSerieID = ic.FK_ICProductSerieID) AS ps
		OUTER APPLY (SELECT HREmployeeName FROM dbo.HREmployees WHERE HREmployeeID = i.FK_HREmployeeID) AS e
		OUTER APPLY (
					SELECT TOP 1 t.ICTransactionExchangeUnitCost 
					FROM dbo.ICTransactions t 
					WHERE t.ICTransactionReceiptSerialNo = ps.ICProductSerieNo
					AND t.FK_ICProductID = ic.FK_ICProductID
					AND t.ICTransactionType = 1
					AND t.AAStatus ='Alive'
				) cost
	WHERE ii.AAStatus = 'Alive'
		AND i.ARInvoiceID = @ARInvoiceID
		AND p.ICProductIsFollowInventoryStock = 1
		AND i.ARInvoiceTypeCombo = 'InvoiceAndShipment'
			
UNION ALL
	SELECT ii.AAStatus
		, i.AACreatedUser
		, i.AAUpdatedUser
		, i.ARInvoiceID
		, i.ARInvoiceNo
		, i.ARInvoiceTypeCombo
		, i.ARInvoiceDate
		, ii.ARInvoiceItemID
		, i.FK_HREmployeeID
		, i.FK_BRBranchID
		, i.FK_ACObjectID
		, i.ARObjectType
		, e.HREmployeeName
		, i.ARInvoiceDesc
		, ii.ARInvoiceItemProductDesc
		, i.FK_GECurrencyID
		, i.ARInvoiceExchangeRate
		, ii.FK_ICStockID
		, ii.ARInvoiceItemIsSpecificCalculation
		, CASE
			WHEN (SELECT ICPriceCalculationMethodMethod FROM dbo.ICPriceCalculationMethods WHERE ICPriceCalculationMethodID = p.FK_ICPriceCalculationMethodID AND AAStatus = 'Alive') = 'Specific' THEN 0
			ELSE 1
		  END AS PriceCalculationMethod
		, ii.FK_ICProductID
		, ii.ARInvoiceItemLotNo
		, ii.ARInvoiceItemProductSerialNo
		, ii.FK_ICMeasureUnitID
		, ii.ARInvoiceItemProductQty
		, ii.ARInvoiceItemProductFactor
		, ii.ARInvoiceItemProductExchangeQty
		, ii.ARInvoiceItemWoodQty as ICTransactionQty1
		, ii.ARInvoiceItemProductUnitCost
		, round(ii.ARInvoiceItemTotalCost,@RoundNo) AS ARInvoiceItemTotalCost
		, round(ii.ARInvoiceItemExchangeUnitCost,0) AS ARInvoiceItemExchangeUnitCost
		, round(ii.ARinvoiceItemExchangeTotalCost,0) AS ARinvoiceItemExchangeTotalCost
		, st.FK_ACAccountID
		, ii.ARInvoiceItemLength
		, ii.ARInvoiceItemWidth
		, ii.ARInvoiceItemHeight
		, ii.ARInvoiceItemLengthMin
		, ii.ARInvoiceItemWidthMin 
		, ii.ARInvoiceItemHeightMin
		, ii.ARInvoiceItemLentghMax
		, ii.ARInvoiceItemWidthMax
		, ii.ARInvoiceItemHeightMax
		, ii.ARInvoiceItemPerimeter
	FROM [dbo].[ARInvoiceItems] ii (NOLOCK)
		INNER JOIN [dbo].[ARInvoices] i (NOLOCK) ON i.ARInvoiceID = ii.FK_ARInvoiceID AND i.AAStatus = 'Alive'
		INNER JOIN dbo.ICProducts p (NOLOCK) ON p.ICProductID = ii.FK_ICProductID
		OUTER APPLY (SELECT FK_ACAccountID FROM dbo.ICStocks WHERE ICStockID = ii.FK_ICStockID) AS st
		OUTER APPLY (SELECT HREmployeeName FROM dbo.HREmployees WHERE HREmployeeID = i.FK_HREmployeeID) AS e
	WHERE ii.AAStatus = 'Alive'
		AND i.ARInvoiceID = @ARInvoiceID
		AND p.ICProductIsFollowInventoryStock = 1
		AND i.ARInvoiceTypeCombo = 'InvoiceAndShipment'
		AND p.HasComponent = 0

----------Post sổ----------
	INSERT INTO ICTransactions
	SELECT i.AAStatus
		, GETDATE()
		, i.AACreatedUser
		, GETDATE()
		, i.AAUpdatedUser
		, i.ARInvoiceID
		, i.ARInvoiceNo
		, @ModuleName
		, i.ARInvoiceTypeCombo
		, i.ARInvoiceDate
		, i.ARInvoiceItemID
		, i.FK_HREmployeeID
		, i.FK_BRBranchID
		, i.FK_ACObjectID
		, i.ARObjectType
		, i.HREmployeeName
		, i.ARInvoiceDesc
		, i.ARInvoiceItemProductDesc
		, i.FK_GECurrencyID
		, i.ARInvoiceExchangeRate
		, i.FK_ICStockID
		, 2 --Nhập xuất (1:Nhập, 2: Xuất)
		, 0
		, i.ARInvoiceItemIsSpecificCalculation
		, i.PriceCalculationMethod
		, i.FK_ICProductID
		, i.ARInvoiceItemLotNo
		, i.ARInvoiceItemProductSerialNo
		, i.FK_ICMeasureUnitID
		, i.ARInvoiceItemProductQty
		, i.ARInvoiceItemProductFactor
		, i.ARInvoiceItemProductExchangeQty
		, i.ICTransactionQty1
		, 0 as ICTransactionQty2
		, 0 as ICTransactionQty3
		, '' as ICTransactionFeePaymentType
		, i.ARInvoiceItemProductUnitCost
		, round(i.ARInvoiceItemTotalCost,@RoundNo) AS ARInvoiceItemTotalCost
		, round(i.ARInvoiceItemExchangeUnitCost,0) AS ARInvoiceItemExchangeUnitCost
		, round(i.ARinvoiceItemExchangeTotalCost,0) AS ARinvoiceItemExchangeTotalCost
		, i.FK_ACAccountID
		, 0
		, 0
		, 0 
		, 0
		, 0
		, 0 
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0 
		, 0
		, ''
		, ''
		, ''
		, ''
		, ''
		, ''
		, ''
		, ''
		, ''
		, ''
		, 0
		, 0
		, i.ARInvoiceItemLength
		, i.ARInvoiceItemWidth
		, i.ARInvoiceItemHeight
		, ''
		, 0
		, 0
		, 0
		, NULL
		, i.ARInvoiceItemLengthMin
		, i.ARInvoiceItemWidthMin 
		, i.ARInvoiceItemHeightMin
		, i.ARInvoiceItemLentghMax
		, i.ARInvoiceItemWidthMax
		, i.ARInvoiceItemHeightMax
		, i.ARInvoiceItemPerimeter
	FROM #InvoiceItemPosted i

	DROP TABLE #InvoiceItemPosted
END


GO

