SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
ALTER FUNCTION [dbo].[ICTransactions_GetProductUnitCostForInventoryStockCount]
(	
	@FK_ICStockID	INT = NULL,
    @ToDate			DATETIME
)
RETURNS @Result TABLE 
(
	FK_ICProductID	INT,
	UnitCost		DECIMAL(18,5)
)
AS
BEGIN
	DECLARE @StartDate DATETIME 
	SELECT TOP 1 @StartDate = CSCompanyAccountingBeginDateConfig-1 FROM dbo.CSCompanys (NOLOCK) WHERE CSCompanyAccountingBeginDateConfig IS NOT NULL
	
	DECLARE @LockIC TABLE
	(
		ProductID	INT,
		LockDate	DATETIME
	)
	
	INSERT INTO @LockIC
	SELECT inv.FK_ICProductID
		,	MAX(inv.ICInvBalanceDate)
	FROM dbo.ICInvBalances inv (NOLOCK)
	WHERE inv.AAStatus = 'Alive' 
		AND DATEDIFF(DD,inv.ICInvBalanceDate, @ToDate) >= 0 
		AND DATEDIFF(DD, @StartDate, inv.ICInvBalanceDate) >= 0
		--AND (@FK_ICStockID IS NULL OR @FK_ICStockID = inv.FK_ICStockID)
	GROUP BY inv.FK_ICProductID 
	
------------Lấy dữ liệu------------
	DECLARE @UnitCost TABLE
	(
		FK_ICStockID	INT,
		FK_ICProductID	INT,
		TotalCost		DECIMAL(18,5), 
		Qty				DECIMAL(18,5)
	)
	
	INSERT INTO @UnitCost
	SELECT b.FK_ICStockID
		,	b.FK_ICProductID
		,	ISNULL(b.ICInvBalanceExchangeTotalCost, 0)
		,	ISNULL(b.ICInvBalanceExchangeQty, 0)
	FROM dbo.ICInvBalances b (NOLOCK)
		INNER JOIN @LockIC l ON l.ProductID = b.FK_ICProductID AND DATEDIFF(DAY, l.LockDate, b.ICInvBalanceDate) = 0 
		OUTER APPLY (SELECT ICPriceCalculationMethodIsStock
						FROM dbo.ICProducts p (NOLOCK)
						INNER JOIN dbo.ICPriceCalculationMethods pcm (NOLOCK) ON p.FK_ICPriceCalculationMethodID = pcm.ICPriceCalculationMethodID
						WHERE p.AAStatus = 'Alive'
						AND b.FK_ICProductID = p.ICProductID) AS pro
	WHERE b.AAStatus = 'Alive'
		--AND (@FK_ICStockID IS NULL OR b.FK_ICStockID = @FK_ICStockID)
	ORDER BY b.ICInvBalanceDate DESC
			
	INSERT INTO @UnitCost
	SELECT	t.FK_ICStockID
		,	t.FK_ICProductID
		,	(CASE WHEN t.ICTransactionType = 1
					THEN ISNULL(t.ICTransactionExchangeTotalCost, 0)
				ELSE - ISNULL(t.ICTransactionExchangeTotalCost, 0) END) AS ICTransactionExchangeTotalCost
		,	(CASE WHEN t.ICTransactionType = 1
					THEN ISNULL(t.ICTransactionExchangeQty, 0)
				ELSE - ISNULL(t.ICTransactionExchangeQty, 0) END)	AS ICTransactionExchangeQty
	FROM dbo.ICTransactions t (NOLOCK)
		LEFT JOIN @LockIC l ON l.ProductID = t.FK_ICProductID
		OUTER APPLY 
		(
			SELECT ICPriceCalculationMethodIsStock
			FROM dbo.ICProducts p (NOLOCK)
			INNER JOIN dbo.ICPriceCalculationMethods pcm (NOLOCK) on p.FK_ICPriceCalculationMethodID = pcm.ICPriceCalculationMethodID
			WHERE p.AAStatus = 'Alive'
			AND t.FK_ICProductID = p.ICProductID
		) AS pro
	WHERE t.AAStatus = 'Alive'
		--AND (@FK_ICStockID IS NULL OR t.FK_ICStockID = @FK_ICStockID)
		AND DATEDIFF(DAY, ISNULL(l.LockDate, @StartDate), t.ICTransactionDate) > 0
		AND DATEDIFF(DAY, t.ICTransactionDate, @ToDate) >= 0
		AND ((YEAR(@ToDate) = YEAR(t.ICTransactionDate)
				AND MONTH(@ToDate) = MONTH(t.ICTransactionDate)
				AND t.ICTransactionModuleName in ('ProductConversion', 'PurchaseReceipt', 'Receipt', 'InvoiceIn','AllocationCost'))
			 OR YEAR(@ToDate) <> YEAR(t.ICTransactionDate)
			 OR MONTH(@ToDate) <> MONTH(t.ICTransactionDate))
		AND (t.ICTransactionModuleName NOT IN ('SemiProductReceipt', 'SemiProductShipment')
				OR (t.ICTransactionModuleName = 'SemiProductReceipt' AND t.ICTransactionCode01Combo = 'Product')
				OR (t.ICTransactionModuleName = 'SemiProductShipment' AND t.ICTransactionCode01Combo = 'Product'))
	
------------Tính giá vốn------------
	DECLARE @CalculatorUnitCost TABLE
	(
		FK_ICProductID	INT,
		TotalCost		DECIMAL(18,5), 
		Qty				DECIMAL(18,5)
	)

	INSERT INTO @CalculatorUnitCost
	SELECT u.FK_ICProductID
		,	SUM(u.TotalCost)
		,	SUM(u.Qty)
	FROM @UnitCost u
	GROUP BY u.FK_ICProductID

------------Trả kết quả------------
	INSERT INTO @Result
	SELECT c.FK_ICProductID
		,	CASE WHEN c.TotalCost <= 0 OR c.Qty <= 0
				THEN 0.000
				ELSE c.TotalCost / c.Qty
				END
	FROM @CalculatorUnitCost c
	--WHERE (@FK_ICStockID IS NULL OR @FK_ICStockID = C.FK_ICStockID)

RETURN 
END
GO

