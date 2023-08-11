SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO

-- =============================================
-- Author:		<Loc Truong>
-- Create date: <08/01/2019>
-- Description:	<Get inventory quantity>
-- =============================================
ALTER PROCEDURE [dbo].[ICTransactions_GetListInventoryStockQty]
	@Type_SomeParaInventoryStocks Type_SomeParaInventoryStocks READONLY
AS
BEGIN
	DECLARE @ToDate DATETIME
	SELECT TOP 1 @ToDate = ToDate FROM @Type_SomeParaInventoryStocks

	declare @LockDate datetime 
	select top 1 @LockDate = ICInvBalanceDate from ICInvBalances where DATEDIFF(DD,ICInvBalanceDate, @ToDate)>0 order by ICInvBalanceDate desc
	if @LockDate is null
		select top 1 @LockDate = CSCompanyAccountingBeginDateConfig-1 from CSCompanys where CSCompanyAccountingBeginDateConfig is not null

	CREATE TABLE #UnitCost 
	(
		FK_ICStockID INT ,
		FK_ICProductID INT ,
		ICProductSerieNo NVARCHAR(50) ,
		ICTransactionExchangeTotalCost	decimal(18,5), 
		ICTransactionExchangeQty		DECIMAL(18,6),
		ICTransactionQty1				DECIMAL(18,6),
		ICTransactionDate datetime
	)
	
	insert into #UnitCost
	SELECT
			b.FK_ICStockID
		,	b.FK_ICProductID
		,	ISNULL(b.ICInvBalanceReceiptSerialNo,'')
		,	b.ICInvBalanceExchangeTotalCost
		,	b.ICInvBalanceExchangeQty
		,	b.ICInvBalanceQty1
		,	b.ICInvBalanceDate
		
	from @Type_SomeParaInventoryStocks p INNER JOIN 
		ICInvBalances b ON 
		 b.AAStatus = 'Alive'
		and b.FK_ICStockID = p.StockID
		and b.FK_ICProductID =  p.ProductID
		and ( ISNULL(p.SeriaNo,'') = '' OR b.ICInvBalanceReceiptSerialNo =  p.SeriaNo)
	WHERE DATEDIFF(DAY, b.ICInvBalanceDate, @LockDate) = 0
	order by b.ICInvBalanceDate asc
		
	set @LockDate = isnull((select top 1 ICTransactionDate from #UnitCost),@LockDate)
	
	INSERT INTO #UnitCost
	SELECT 
			t.FK_ICStockID
		,	t.FK_ICProductID
		,	ISNULL(t.ICTransactionReceiptSerialNo,'')
		,	(CASE WHEN t.ICTransactionType = 1 THEN t.ICTransactionExchangeTotalCost ELSE -t.ICTransactionExchangeTotalCost END) AS ICTransactionExchangeTotalCost
		,	(CASE WHEN t.ICTransactionType = 1 THEN t.ICTransactionExchangeQty ELSE -t.ICTransactionExchangeQty END) AS ICTransactionExchangeQty
		,	(CASE WHEN t.ICTransactionType = 1 THEN t.ICTransactionQty1 ELSE -t.ICTransactionQty1 END) AS ICTransactionQty1
		,	t.ICTransactionDate
	FROM @Type_SomeParaInventoryStocks p INNER JOIN  ICTransactions t 
	ON		t.AAStatus = 'Alive'
		AND t.FK_ICStockID = p.StockID
		AND t.FK_ICProductID = p.ProductID
		
	OUTER APPLY (SELECT TOP 1 pss.ICProductSerieNo 
						FROM dbo.ICProductSeries pss
						WHERE CAST(t.ICTransactionReceiptSerialNo AS NVARCHAR(100)) = pss.ICProductSerieNo
							--AND t.ICTransactionReceiptLotNo = pss.ICProductSerieLotNo 
							AND t.FK_ICProductID = pss.FK_ICProductID 
							AND pss.ICProductSerieNo <> ''
							AND pss.AAStatus = 'Alive') AS ps
	WHERE t.AAStatus = 'Alive'
		AND (ISNULL(p.SeriaNo,'') = '' OR ps.ICProductSerieNo = p.SeriaNo)
		AND (@LockDate = NULL OR DATEDIFF(DAY, @LockDate, t.ICTransactionDate) >= 0)		
		AND DATEDIFF(DAY, t.ICTransactionDate, @ToDate) >= 0
		--and t.ICTransactionType = 1
	
	INSERT INTO #UnitCost
	SELECT 
			t.FK_ICStockID
		,	t.FK_ICProductID
		,	ISNULL(t.ICTransactionReceiptSerialNo,'')
		,	-t.ICTransactionExchangeTotalCost AS ICTransactionExchangeTotalCost
		,	-t.ICTransactionExchangeQty AS ICTransactionExchangeQty
		,	-t.ICTransactionQty1 AS ICTransactionQty1
		,	t.ICTransactionDate
	FROM @Type_SomeParaInventoryStocks p INNER JOIN ICTransactions t ON		
			t.AAStatus = 'Alive'
		AND t.FK_ICStockID = p.StockID
		AND t.FK_ICProductID = p.ProductID
	OUTER APPLY (SELECT TOP 1 pss.ICProductSerieNo  
					FROM dbo.ICProductSeries pss
					WHERE CAST(t.ICTransactionReceiptSerialNo AS NVARCHAR(100)) = pss.ICProductSerieNo
						--AND t.ICTransactionReceiptLotNo = pss.ICProductSerieLotNo 
						AND t.FK_ICProductID = pss.FK_ICProductID 
						AND pss.ICProductSerieNo <> ''
						AND pss.AAStatus = 'Alive') AS ps
	OUTER APPLY (
	SELECT p.FK_ICPriceCalculationMethodID FROM 
		dbo.ICProducts p
		WHERE p.AAStatus = 'Alive'
		AND p.ICProductID = t.FK_ICProductID
	) pr
	OUTER APPLY (
	SELECT m.ICPriceCalculationMethodMethod FROM 
		dbo.ICPriceCalculationMethods m
		WHERE m.AAStatus = 'Alive'
		AND m.ICPriceCalculationMethodID =  pr.FK_ICPriceCalculationMethodID
	)mt
	WHERE t.AAStatus = 'Alive'
		AND (p.SeriaNo IS NULL OR ps.ICProductSerieNo = p.SeriaNo)
		AND DATEDIFF(DAY, @ToDate, t.ICTransactionDate) > 0		
		AND DATEDIFF(DAY, t.ICTransactionDate, '9999/01/01') >= 0
		AND t.ICTransactionType = 2
		AND mt.ICPriceCalculationMethodMethod = 'Average'

	
	SELECT t.FK_ICStockID
	,	t.FK_ICProductID
	,	CASE WHEN ICPriceCalculationMethodMethod = 'Average' THEN '' ELSE  t.ICProductSerieNo END AS ICTransactionReceiptSerialNo
	,	SUM(t.ICTransactionExchangeTotalCost) AS ICTransactionExchangeTotalCost
	,	ROUND(SUM(t.ICTransactionExchangeQty),5) AS ICTransactionExchangeQty
	,	ROUND(SUM(t.ICTransactionQty1),5) AS ICTransactionQty1
	FROM #UnitCost t 
	OUTER APPLY (
	SELECT p.FK_ICPriceCalculationMethodID FROM 
		dbo.ICProducts p
		WHERE p.AAStatus = 'Alive'
		AND p.ICProductID = t.FK_ICProductID
	) p
	OUTER APPLY (
	SELECT m.ICPriceCalculationMethodMethod FROM 
		dbo.ICPriceCalculationMethods m
		WHERE m.AAStatus = 'Alive'
		AND m.ICPriceCalculationMethodID =  p.FK_ICPriceCalculationMethodID
	)mt
	GROUP BY t.FK_ICStockID
	,	t.FK_ICProductID
	,	CASE WHEN ICPriceCalculationMethodMethod = 'Average' THEN '' ELSE  t.ICProductSerieNo END 


	DROP TABLE #UnitCost
END

GO

