SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
ALTER PROCEDURE [dbo].[ICTransactions_GetInventoryStatistics]
	@FromDate		DATETIME,
	@ToDate			DATETIME,
	@FK_ICProductID	INT = NULL,
	@DepartmentID INT = NULL,
	@FK_ICStockID	INT = NULL,
	@IsGroupByStock	BIT,
	@IsGroupBySeriaNo BIT,
	@HasIncompleteProduct BIT,
	@IsGroupIncompleteProduct BIT NULL,
	@FK_BRBranchID	INT = NULL
AS
BEGIN
	DECLARE @StartDate DATETIME = GETDATE()
	SELECT TOP 1 @StartDate = CSCompanyAccountingBeginDateConfig-1 FROM CSCompanys WHERE AAStatus = 'Alive' AND CSCompanyAccountingBeginDateConfig IS NOT NULL

	SELECT
		p.ICProductID
		, p.FK_ICProductBasicUnitID
		, inv.FK_ICStockID
		, MAX(inv.ICInvBalanceDate) AS LockDate
		, (CASE WHEN ISNULL(pcm.CalculationMethodType, 'Specific') = 'Average' THEN '' ELSE inv.ICInvBalanceReceiptSerialNo END) AS SeriaNo
		, ISNULL(pcm.CalculationMethodType, 'Specific') CalculationMethodType
	INTO #InventoryDateLocks
	FROM dbo.ICInvBalances (NOLOCK) inv 
		INNER JOIN dbo.ICProducts (NOLOCK) p ON p.ICProductID = inv.FK_ICProductID
		OUTER APPLY (
			SELECT 
				pcm.ICPriceCalculationMethodMethod AS CalculationMethodType
			FROM  dbo.ICPriceCalculationMethods (NOLOCK) pcm 
			WHERE pcm.AAStatus = 'Alive'
				AND pcm.ICPriceCalculationMethodID = p.FK_ICPriceCalculationMethodID 
		) AS pcm
	WHERE inv.AAStatus = 'Alive'
		AND DATEDIFF(DD, inv.ICInvBalanceDate, @ToDate) > 0
		AND DATEDIFF(DD, @StartDate, inv.ICInvBalanceDate) >= 0
		AND (@FK_BRBranchID IS NULL OR inv.FK_BRBranchID = @FK_BRBranchID)
		AND (@FK_ICProductID is null OR inv.FK_ICProductID = @FK_ICProductID) 
		AND (@FK_ICStockID IS NULL OR inv.FK_ICStockID = @FK_ICStockID)
		AND (@DepartmentID IS NULL OR p.FK_ICDepartmentID = @DepartmentID)
	GROUP BY p.ICProductID
		, p.FK_ICProductBasicUnitID
		, ISNULL(pcm.CalculationMethodType, 'Specific')
		, inv.FK_ICStockID
		, CASE WHEN ISNULL(pcm.CalculationMethodType, 'Specific') = 'Average' THEN '' ELSE inv.ICInvBalanceReceiptSerialNo END 

	SELECT 
		t.ICTransactionID
		, t.ICTransactionDate
		, t.FK_ICProductID
		, t.FK_ICStockID
		, CASE WHEN ISNULL(pcm.CalculationMethodType, 'Specific') = 'Average' THEN '' ELSE t.ICTransactionReceiptSerialNo END AS ICTransactionReceiptSerialNo
		, t.ICTransactionQty
		, t.ICTransactionFactor
		, t.ICTransactionExchangeQty
		, t.ICTransactionUnitCost
		, t.ICTransactionExchangeUnitCost
		, t.FK_ICMeasureUnitID
		, t.ICTransactionType
		, t.ICTransactionExchangeTotalCost
		, t.ICTransactionModuleName
		, t.FK_BRBranchID
		, ISNULL(ld.LockDate, @StartDate) AS LockDate
		, pcm.CalculationMethodType
		, CASE
			WHEN (t.ICTransactionModuleName = 'SemiProductReceipt' AND ISNULL(t.ICTransactionCode01Combo, '') <> 'Product')
				OR (t.ICTransactionModuleName = 'SemiProductShipment' AND ISNULL(t.ICTransactionCode01Combo, '') <> 'Product') 
				THEN 'IncompleteProduct'
			ELSE 'Product'
		  END ICTransactionCode01Combo
	INTO #Transactions
	FROM dbo.ICTransactions (NOLOCK) t
		INNER JOIN dbo.ICProducts (NOLOCK) p ON p.ICProductID = t.FK_ICProductID
		OUTER APPLY (
			SELECT 
				TOP 1 
				pcm.ICPriceCalculationMethodMethod AS CalculationMethodType
			FROM  dbo.ICPriceCalculationMethods (NOLOCK) pcm 
			WHERE pcm.AAStatus = 'Alive'
				AND pcm.ICPriceCalculationMethodID = p.FK_ICPriceCalculationMethodID 
		) AS pcm
		OUTER APPLY (
			SELECT
				MAX(ld.LockDate) AS LockDate
			FROM #InventoryDateLocks ld
			WHERE ld.ICProductID = t.FK_ICProductID
				AND ld.FK_ICStockID = t.FK_ICStockID
				AND ld.SeriaNo = CASE WHEN ISNULL(pcm.CalculationMethodType, 'Specific') = 'Average' THEN '' ELSE t.ICTransactionReceiptSerialNo END 
		) AS ld
	WHERE t.AAStatus = 'Alive'
		AND (@FK_BRBranchID IS NULL OR t.FK_BRBranchID = @FK_BRBranchID)
		AND (@ToDate IS NULL OR DATEDIFF(DD, t.ICTransactionDate, @ToDate) >=0)
		AND (@FK_ICProductID is null OR t.FK_ICProductID = @FK_ICProductID) 
		AND (@DepartmentID IS NULL OR p.FK_ICDepartmentID = @DepartmentID)
		AND DATEDIFF(DD, ISNULL(ld.LockDate, @StartDate), t.ICTransactionDate) > 0
		AND (@FK_ICStockID IS NULL OR t.FK_ICStockID = @FK_ICStockID)
		AND (
				@HasIncompleteProduct = 1 
				OR (@HasIncompleteProduct = 0 AND (t.ICTransactionModuleName NOT IN ('SemiProductReceipt', 'ProductionReceipt', 'SemiProductShipment', 'ProductionShipment'))
				OR (@HasIncompleteProduct = 0 AND (t.ICTransactionModuleName = 'SemiProductReceipt' AND t.ICTransactionCode01Combo = 'Product'))
				OR (@HasIncompleteProduct = 0 AND (t.ICTransactionModuleName = 'SemiProductShipment' AND t.ICTransactionCode01Combo = 'Product'))
			))
	
	SELECT
		inv.*
		, ld.LockDate
		, ld.CalculationMethodType
	INTO #InvBalances
	FROM dbo.ICInvBalances inv
		INNER JOIN dbo.ICProducts (NOLOCK) p ON p.ICProductID = inv.FK_ICProductID
		OUTER APPLY (
			SELECT
				MAX(ld.LockDate) AS LockDate
				, ld.CalculationMethodType
			FROM #InventoryDateLocks ld
			WHERE ld.ICProductID = inv.FK_ICProductID
				AND ld.FK_ICStockID = inv.FK_ICStockID
				AND ld.SeriaNo = CASE WHEN ISNULL(ld.CalculationMethodType, 'Specific') = 'Average' THEN '' ELSE inv.ICInvBalanceReceiptSerialNo END 
			GROUP BY ld.CalculationMethodType
		) AS ld
	WHERE inv.AAStatus = 'Alive'
		AND ISNULL(ld.LockDate, @StartDate) = inv.ICInvBalanceDate 
		AND (@FK_ICProductID is null OR inv.FK_ICProductID = @FK_ICProductID) 
		AND (@DepartmentID IS NULL OR p.FK_ICDepartmentID = @DepartmentID)
		AND (@FK_BRBranchID IS NULL OR inv.FK_BRBranchID = @FK_BRBranchID)
		AND (@FK_ICStockID IS NULL OR inv.FK_ICStockID = @FK_ICStockID)

	CREATE TABLE #rpt 
	(
		FK_ICProductID int
		, FK_ICStockID INT
		, SerialNo NVARCHAR(100)
		, dkQty DECIMAL(20,6)
		, dkAmt DECIMAL(20,6)
		, inQty DECIMAL(20,6)
		, inAmt DECIMAL(20,6)
		, outQty DECIMAL(20,6)
		, outAmt DECIMAL(20,6)
		, ckQty DECIMAL(20,6)
		, ckAmt DECIMAL(20,6) 
		, Code01Combo VARCHAR(50)
	)
	Insert into #rpt
	select FK_ICProductID
		, case when @IsGroupByStock = 1 then FK_ICStockID else null END
		, Opening.SerialNo
		, sum(dkQty) 
		, sum(dkAmt)
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0
		, (CASE WHEN @IsGroupIncompleteProduct = 1 THEN ICInvBalanceCode01Combo ELSE null END)
	from
	(
		select FK_ICProductID
			, ib.FK_ICStockID
			, CASE WHEN ISNULL(ib.CalculationMethodType, 'Specific') = 'Average' OR @IsGroupBySeriaNo = 0 THEN '' ELSE ib.ICInvBalanceReceiptSerialNo END AS SerialNo
			, case when ib.ICInvBalanceExchangeQty is null then 0 else isnull(ib.ICInvBalanceExchangeQty,0) end as dkQty
			, case when ib.ICInvBalanceExchangeTotalCost is null then 0 else isnull(ib.ICInvBalanceExchangeTotalCost,0) end as dkAmt
			, CASE 
				WHEN ib.ICInvBalanceCode01Combo = 'IncompleteProduct' THEN 'IncompleteProduct'
				ELSE 'Product'
			  END AS ICInvBalanceCode01Combo
		from #InvBalances ib 
			left join ICProducts p on ib.FK_ICProductID = p.ICProductID
			left join ICStocks st on ib.FK_ICStockID = st.ICStockID 
		WHERE(@HasIncompleteProduct = 1 OR ISNULL(ib.ICInvBalanceCode01Combo, '') IN ('Product', ''))
		UNION ALL 
		SELECT t.FK_ICProductID
			, t.FK_ICStockID
			, CASE WHEN ISNULL(t.CalculationMethodType, 'Specific') = 'Average' OR @IsGroupBySeriaNo = 0 THEN '' ELSE t.ICTransactionReceiptSerialNo END AS SerialNo
			, case when t.ICTransactionType = 1  then isnull(t.ICTransactionExchangeQty,0) else - isnull(t.ICTransactionExchangeQty,0) end  dkQty
			, case when t.ICTransactionType = 1 then isnull(t.ICTransactionExchangeTotalCost,0) else - isnull(t.ICTransactionExchangeTotalCost,0) end  dkAmt
			, t.ICTransactionCode01Combo
		from #Transactions t 
		WHERE DATEDIFF(DD, @FromDate, ICTransactionDate) < 0  
	) Opening 
	GROUP BY FK_ICProductID
		, (CASE WHEN @IsGroupByStock = 1 THEN FK_ICStockID ELSE null END)
		, Opening.SerialNo
		, (CASE WHEN @IsGroupIncompleteProduct = 1 THEN ICInvBalanceCode01Combo ELSE null END)

	--Phát sinh trong kỳ
	insert into #rpt
	select  t.FK_ICProductID
		, t.FK_ICStockID
		, CASE WHEN ISNULL(t.CalculationMethodType, 'Specific') = 'Average' OR @IsGroupBySeriaNo = 0 THEN '' ELSE t.ICTransactionReceiptSerialNo END
		, 0
		, 0
		, case when t.ICTransactionType = 1  then isnull(t.ICTransactionExchangeQty,0) else 0 end  InQty
		, case when t.ICTransactionType = 1  then isnull(t.ICTransactionExchangeTotalCost,0) else 0 end  InAmt
		, case when t.ICTransactionType = 2 then isnull(t.ICTransactionExchangeQty,0) else 0 end  OutQty
		, case when t.ICTransactionType = 2 then isnull(t.ICTransactionExchangeTotalCost,0) else 0 end  OutAmt
		, 0
		, 0
		, t.ICTransactionCode01Combo
	From #Transactions t 
		LEFT JOIN ICProducts p on t.FK_ICProductID = p.ICProductID
	WHERE DATEDIFF(DD,ICTransactionDate, @FromDate) <= 0 
		AND DATEDIFF(DD,@ToDate, ICTransactionDate) <= 0

	select FK_ICProductID
		, (case when @IsGroupByStock = 1 then FK_ICStockID else null end) as FK_ICStockID
		, SerialNo
		, sum(dkQty) as dkQty
		, sum(dkAmt) as dkAmt
		, sum(inQty) as inQty
		, sum(inAmt) as inAmt
		, sum(outQty) as outQty
		, sum(outAmt) as outAmt
		, sum(dkQty) + sum(inQty) - sum(outQty) as ckQty
		, sum(dkAmt)+ sum(inAmt)- sum(outAmt) as ckAmt
		, (CASE WHEN @IsGroupIncompleteProduct = 1 THEN Code01Combo ELSE 'Product' END) AS Code01Combo
	into #rpt2
	from #rpt 
	group by FK_ICProductID
		, (case when @IsGroupByStock = 1 then FK_ICStockID else null end)
		, SerialNo
		, (CASE WHEN @IsGroupIncompleteProduct = 1 THEN Code01Combo ELSE 'Product' END)
	
	DELETE #rpt2 
	WHERE abs(dkQty) + abs(dkAmt) + abs(inQty) + abs(inAmt) + abs(outQty) + abs(outAmt) = 0

	select 
		a.FK_ICProductID 
		, a.FK_ICStockID
		, a.SerialNo AS ICInvBalanceReceiptSerialNo
		, s.ICStockNo
		, s.ICStockName
		, p.ICProductNo
		, p.ICProductNoOfOldSys
		, p.ICProductName
		, p.ICProductDesc
		, dkQty as ICTransactionOpeningQty
		, dkAmt as ICTransactionOpeningBalance
		, inQty as ICTransactionReceiptQty
		, inAmt as ICTransactionReceiptBalance
		, outQty as ICTransactionShipmentQty
		, outAmt as ICTransactionShipmentBalance
		, ckQty as ICTransactionEndQty
		, ckAmt as  ICTransactionEndBalance
		, CAST(ckAmt / iif(ckQty = 0, 1,ckQty) AS DECIMAL(18,0)) as ICTransactionUnitCost
		, ac.ACAccountID 
		, ac.ACAccountNo
		, s.FK_BRBranchID
		, a.Code01Combo AS ICInvBalanceCode01Combo
	FROM #rpt2 a 
		inner join ICProducts p on a.FK_ICProductID = p.ICProductID
		left join ACAccounts ac on p.FK_ACAccountID = ac.ACAccountID
		left join ICStocks s on a.FK_ICStockID = s.ICStockID
	ORDER BY FK_ICProductID

	DROP TABLE #Transactions
	DROP TABLE #InventoryDateLocks
	DROP TABLE #InvBalances
	DROP TABLE #rpt
	DROP TABLE #rpt2
END
GO

