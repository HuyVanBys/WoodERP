SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		<Loc Truong>
-- Create date: <08/01/2019>
-- Description:	<Get inventory quantity>
-- =============================================
ALTER PROCEDURE [dbo].[ICTransactions_GetListInventoryStockQtyForInventoryStockCount]
	@Type_SomeParaInventoryStocks Type_SomeParaInventoryStocks READONLY
AS
BEGIN
	DECLARE @ToDate DATETIME
		, @StartDate DATETIME
	
	SELECT DISTINCT *
	INTO #SomeParaInventoryStocks
	FROM @Type_SomeParaInventoryStocks

	SELECT TOP 1 @ToDate = ToDate FROM #SomeParaInventoryStocks
	SELECT TOP 1 @StartDate = CSCompanyAccountingBeginDateConfig-1 from CSCompanys where CSCompanyAccountingBeginDateConfig IS NOT NULL

	SELECT p.ICProductID
		, p.FK_ICProductBasicUnitID
		, CASE 
			WHEN pcm.ICPriceCalculationMethodMethod = 'Average' THEN 'Average'
			ELSE 'Specific'
		  END AS CalculationMethodType
	INTO #Products
	FROM #SomeParaInventoryStocks inv
		INNER JOIN dbo.ICProducts (NOLOCK) p ON inv.ProductID = p.ICProductID
		LEFT JOIN dbo.ICPriceCalculationMethods pcm ON pcm.ICPriceCalculationMethodID = p.FK_ICPriceCalculationMethodID  
	WHERE p.AAStatus = 'Alive'

	SELECT p.ICProductID
		, p.FK_ICProductBasicUnitID
		, p.CalculationMethodType
		, inv.FK_ICStockID
		, MAX(inv.ICInvBalanceDate) AS LockDate
		, (CASE WHEN p.CalculationMethodType = 'Average' THEN '' ELSE pr.SeriaNo END) AS SeriaNo
	INTO #InventoryDateLocks
	FROM #Products p
		INNER JOIN dbo.ICInvBalances inv ON inv.FK_ICProductID = p.ICProductID
		OUTER APPLY (
			SELECT *
			FROM #SomeParaInventoryStocks pr
			WHERE pr.ProductID = inv.FK_ICProductID
				AND pr.StockID = inv.FK_ICStockID
				AND (p.CalculationMethodType = 'Average' OR (pr.SeriaNo IS NOT NULL AND inv.ICInvBalanceReceiptSerialNo = pr.SeriaNo))
		) AS pr
	WHERE inv.AAStatus = 'Alive'
		AND DATEDIFF(DD, inv.ICInvBalanceDate, @ToDate) >= 0
		AND DATEDIFF(DD, @StartDate, inv.ICInvBalanceDate) >= 0
		AND pr.ProductID IS NOT NULL
	GROUP BY p.ICProductID
		, p.FK_ICProductBasicUnitID
		, p.CalculationMethodType
		, inv.FK_ICStockID
		, CASE WHEN p.CalculationMethodType = 'Average' THEN '' ELSE pr.SeriaNo END 

	CREATE TABLE #UnitCost 
	(
		FK_ICStockID INT ,
		FK_ICProductID INT ,
		ICProductSerieNo NVARCHAR(100) ,
		ICTransactionExchangeTotalCost	decimal(18,5), 
		ICTransactionExchangeQty		DECIMAL(18,6),
		ICTransactionQty1				DECIMAL(18,6),
		ICTransactionDate datetime
	)
	CREATE TABLE #UnitCostLaster
	(
		FK_ICStockID INT ,
		FK_ICProductID INT ,
		ICProductSerieNo NVARCHAR(100) ,
		ICTransactionExchangeTotalCost	decimal(18,5), 
		ICTransactionExchangeQty		DECIMAL(18,6),
		ICTransactionQty1				DECIMAL(18,6),
		ICTransactionDate datetime
	)

	insert into #UnitCost
	SELECT 
		b.FK_ICStockID
		, b.FK_ICProductID
		, ISNULL(b.ICInvBalanceReceiptSerialNo,'')
		, b.ICInvBalanceExchangeTotalCost
		, b.ICInvBalanceExchangeQty
		, b.ICInvBalanceQty1
		, b.ICInvBalanceDate
	FROM #InventoryDateLocks ld
		INNER JOIN ICInvBalances b ON b.FK_ICProductID = ld.ICProductID 
			AND b.FK_ICStockID = ld.FK_ICStockID
			AND b.ICInvBalanceDate = ld.LockDate
			AND b.AAStatus = 'Alive'
	WHERE (ld.CalculationMethodType = 'Average' OR ISNULL(b.ICInvBalanceReceiptSerialNo,'') = ld.SeriaNo)

	INSERT INTO #UnitCost
	SELECT t.FK_ICStockID
		, t.FK_ICProductID
		, ISNULL(t.ICTransactionReceiptSerialNo,'')
		, (CASE WHEN t.ICTransactionType = 1 THEN t.ICTransactionExchangeTotalCost ELSE -t.ICTransactionExchangeTotalCost END) AS ICTransactionExchangeTotalCost
		, (CASE WHEN t.ICTransactionType = 1 THEN t.ICTransactionExchangeQty ELSE -t.ICTransactionExchangeQty END) AS ICTransactionExchangeQty
		, (CASE WHEN t.ICTransactionType = 1 THEN t.ICTransactionQty1 ELSE -t.ICTransactionQty1 END) AS ICTransactionQty1
		, t.ICTransactionDate
	FROM #SomeParaInventoryStocks p 
		INNER JOIN  ICTransactions t ON t.AAStatus = 'Alive'
			AND t.FK_ICStockID = p.StockID
			AND t.FK_ICProductID = p.ProductID
		OUTER APPLY 
		(
			SELECT 
				TOP 1 pss.ICProductSerieNo 
			FROM dbo.ICProductSeries pss
			WHERE CAST(t.ICTransactionReceiptSerialNo AS NVARCHAR(100)) = pss.ICProductSerieNo
				AND t.ICTransactionReceiptLotNo = pss.ICProductSerieLotNo 
				AND t.FK_ICProductID = pss.FK_ICProductID 
				AND pss.ICProductSerieNo <> ''
				AND pss.AAStatus = 'Alive'
		) AS ps
		OUTER APPLY (
			SELECT 
				TOP 1 
				ISNULL(ld.LockDate, @StartDate) AS LockDate
			FROM #InventoryDateLocks ld
			WHERE ld.ICProductID = p.ProductID
				AND ld.FK_ICStockID = p.StockID
				AND (ld.CalculationMethodType = 'Average' OR ISNULL(ps.ICProductSerieNo,'') = ld.SeriaNo)
		) AS ld	
	WHERE t.AAStatus = 'Alive'
		AND (ISNULL(p.SeriaNo,'') = '' OR ps.ICProductSerieNo = p.SeriaNo)
		AND (ld.LockDate IS NULL OR DATEDIFF(DAY, ld.LockDate, t.ICTransactionDate) > 0)		
		AND DATEDIFF(DAY, t.ICTransactionDate, @ToDate) >= 0
		--and t.ICTransactionType = 1

	INSERT INTO #UnitCostLaster
	SELECT
		t.FK_ICStockID
		, t.FK_ICProductID
		, ISNULL(t.ICTransactionReceiptSerialNo,'')
		, (CASE WHEN t.ICTransactionType = 1 THEN t.ICTransactionExchangeTotalCost ELSE -t.ICTransactionExchangeTotalCost END) AS ICTransactionExchangeTotalCost
		, (CASE WHEN t.ICTransactionType = 1 THEN t.ICTransactionExchangeQty ELSE -t.ICTransactionExchangeQty END) AS ICTransactionExchangeQty
		, (CASE WHEN t.ICTransactionType = 1 THEN t.ICTransactionQty1 ELSE -t.ICTransactionQty1 END) AS ICTransactionQty1
		, t.ICTransactionDate
	FROM #SomeParaInventoryStocks p 
		INNER JOIN ICTransactions t ON t.AAStatus = 'Alive'
			AND t.FK_ICStockID = p.StockID
			AND t.FK_ICProductID = p.ProductID
		OUTER APPLY 
		(
			SELECT 
				TOP 1 pss.ICProductSerieNo 
			FROM dbo.ICProductSeries pss
			WHERE CAST(t.ICTransactionReceiptSerialNo AS NVARCHAR(100)) = pss.ICProductSerieNo
				AND t.ICTransactionReceiptLotNo = pss.ICProductSerieLotNo 
				AND t.FK_ICProductID = pss.FK_ICProductID 
				AND pss.ICProductSerieNo <> ''
				AND pss.AAStatus = 'Alive'
		) AS ps
	WHERE t.AAStatus = 'Alive'
		AND (ISNULL(p.SeriaNo,'') = '' OR ps.ICProductSerieNo = p.SeriaNo)
		AND DATEDIFF(DAY, @ToDate, t.ICTransactionDate) > 0		
		AND DATEDIFF(DAY, t.ICTransactionDate, '9999/12/31') >= 0

	INSERT INTO #UnitCost
	SELECT
	    FK_ICStockID,
	    FK_ICProductID,
	    ICProductSerieNo,
	    ICTransactionExchangeTotalCost,
	    ICTransactionExchangeQty,
	    ICTransactionQty1,
	    ICTransactionDate
	FROM #UnitCostLaster uc
	--WHERE uc.ICTransactionExchangeQty < 0

	SELECT t.FK_ICStockID
		, t.FK_ICProductID
		, CASE WHEN ICPriceCalculationMethodMethod = 'Average' THEN '' ELSE  t.ICProductSerieNo END AS ICTransactionReceiptSerialNo
		, SUM(t.ICTransactionExchangeTotalCost) AS ICTransactionExchangeTotalCost
		, SUM(t.ICTransactionExchangeQty) AS ICTransactionExchangeQty
		, SUM(t.ICTransactionQty1) AS ICTransactionQty1
	FROM #UnitCost t 
		OUTER APPLY 
		(
			SELECT 
				p.FK_ICPriceCalculationMethodID 
			FROM dbo.ICProducts p
			WHERE p.AAStatus = 'Alive'
				AND p.ICProductID = t.FK_ICProductID
		) AS p
		OUTER APPLY 
		(
			SELECT 
				m.ICPriceCalculationMethodMethod 
			FROM dbo.ICPriceCalculationMethods m
			WHERE m.AAStatus = 'Alive'
				AND m.ICPriceCalculationMethodID =  p.FK_ICPriceCalculationMethodID
		) AS mt
	GROUP BY t.FK_ICStockID
		, t.FK_ICProductID
		, CASE WHEN ICPriceCalculationMethodMethod = 'Average' THEN '' ELSE  t.ICProductSerieNo END 

	DROP TABLE #UnitCost
	DROP TABLE #UnitCostLaster
	DROP TABLE #SomeParaInventoryStocks
	DROP TABLE #InventoryDateLocks
	DROP TABLE #Products
END
GO

