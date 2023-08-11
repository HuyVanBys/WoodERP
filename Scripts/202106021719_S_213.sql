SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO

ALTER PROCEDURE [dbo].[ICTransactions_GetInventoryStatistics1]   
--EXEC dbo.ICTransactions_GetInventoryStatistics '2020-01-27 09:02:18', '2020-04-27 09:02:18', null,null,null,null,3,0
	@FromDate		datetime,
	@ToDate		datetime,
	@FK_ICProductID nvarchar(50) = NULL,
	@ICDepartmentID INT = NULL,
	@ICProductGroupID INT = NULL,
	@FK_APSupplierID INT = NULL,
	@FK_ICStockID nvarchar(50) = NULL,
	@FK_MMBatchProductID INT = NULL,
	@IsGroupByStock bit

AS
BEGIN
	create table #rpt 
	(
		FK_ICProductID int
		, FK_ICStockID int
		, dkQty decimal(18,5)
		, dkAmt decimal(30,5)
		, inQty decimal(18,5)
		, inAmt decimal(30,5)
		, outQty decimal(18,5)
		, outAmt decimal(30,5)
		, ckQty decimal(18,5)
		, ckAmt decimal(30,5) 
	)

	Declare @LockDate datetime;

	select top 1 @LockDate = ICInvBalanceDate from ICInvBalances where DATEDIFF(DD,ICInvBalanceDate, @FromDate)>= 0 order by ICInvBalanceDate desc
	if @LockDate is null
		select top 1 @LockDate = CSCompanyAccountingBeginDateConfig FROM CSCompanys where CSCompanyAccountingBeginDateConfig is not NULL
        
	IF(@FK_MMBatchProductID > 0)
		BEGIN
			SELECT DISTINCT t.FK_ICProductID
			INTO #productIDs
			FROM dbo.ICTransactions t
			WHERE t.FK_MMBatchProductID = @FK_MMBatchProductID

			--Số dư dầu kỳ
			Insert into #rpt
			select FK_ICProductID
				, case when @IsGroupByStock = 1 then FK_ICStockID else null end
				--, Opening.FK_MMBatchProductID
				, sum(dkQty) 
				, sum(dkAmt)
				, 0
				, 0
				, 0
				, 0
				, 0
				, 0
			from
			(
				select ib.FK_ICProductID
					, ib.FK_ICStockID
					--, ib.FK_MMBatchProductID
					, case when ib.ICInvBalanceExchangeQty is null then 0 else isnull(ib.ICInvBalanceExchangeQty,0) end as dkQty
					, case when ib.ICInvBalanceExchangeTotalCost is null then 0 else isnull(ib.ICInvBalanceExchangeTotalCost,0) end as dkAmt
				FROM #productIDs pd
				INNER JOIN ICInvBalances ib ON pd.FK_ICProductID = ib.FK_ICProductID
					left join ICProducts p on ib.FK_ICProductID = p.ICProductID
					left join ICStocks st on ib.FK_ICStockID = st.ICStockID 
					left join ICMeasureUnits dvt on p.FK_ICProductBasicUnitID = dvt.ICMeasureUnitID
				where (ib.FK_ICProductID = @FK_ICProductID or @FK_ICProductID is null ) 
					and (p.FK_ICDepartmentID = @ICDepartmentID or @ICDepartmentID is null)
					and (p.FK_ICProductGroupID = @ICProductGroupID or @ICProductGroupID is null)
					and (p.FK_APSupplierID = @FK_APSupplierID or @FK_APSupplierID is null)
					and (ib.FK_ICStockID = @FK_ICStockID or @FK_ICStockID is null)
					--and (ib.FK_MMBatchProductID = @FK_MMBatchProductID or @FK_MMBatchProductID is null)
					and DATEDIFF(DD,ICInvBalanceDate, @LockDate) = 0  
					AND ib.AAStatus ='Alive'
				union all
				select t.FK_ICProductID
					, t.FK_ICStockID
					--, t.FK_MMBatchProductID
					, case when t.ICTransactionType = 1  then isnull(t.ICTransactionExchangeQty,0) else - isnull(t.ICTransactionExchangeQty,0) end  dkQty
					, case when t.ICTransactionType = 1 then isnull(t.ICTransactionExchangeTotalCost,0) else - isnull(t.ICTransactionExchangeTotalCost,0) end  dkAmt
				from #productIDs p
					INNER JOIN ICTransactions t ON p.FK_ICProductID = t.FK_ICProductID
					left join ICProducts Pr on t.FK_ICProductID = pr.ICProductID
					left join ICStocks st on t.FK_ICStockID = st.ICStockID 
					left join ICMeasureUnits dvt on Pr.FK_ICProductBasicUnitID = dvt.ICMeasureUnitID
				where  (t.FK_ICProductID = @FK_ICProductID or @FK_ICProductID is null ) 
					and (Pr.FK_ICDepartmentID = @ICDepartmentID or @ICDepartmentID is null)
					and (Pr.FK_ICProductGroupID = @ICProductGroupID or @ICProductGroupID is null)
					and (Pr.FK_APSupplierID = @FK_APSupplierID or @FK_APSupplierID is null)
					and (t.FK_ICStockID = @FK_ICStockID or @FK_ICStockID is null)
					and (t.FK_MMBatchProductID = @FK_MMBatchProductID or @FK_MMBatchProductID is NULL OR t.ICTransactionType = 1)
					and DATEDIFF(DD,ICTransactionDate, @LockDate) <= 0 
					and DATEDIFF(DD,@FromDate,ICTransactionDate) < 0  
					AND t.AAStatus ='Alive'
			) Opening 
			group by FK_ICProductID
				, (case when @IsGroupByStock = 1 then FK_ICStockID else null end)

			--Phát sinh trong kỳ
			insert into #rpt
			select  t.FK_ICProductID
				, t.FK_ICStockID
				--, t.FK_MMBatchProductID
				, 0
				, 0
				, case when t.ICTransactionType = 1  then isnull(t.ICTransactionExchangeQty,0) else 0 end  InQty
				, case when t.ICTransactionType = 1  then isnull(t.ICTransactionExchangeTotalCost,0) else 0 end  InAmt
				, case when t.ICTransactionType = 2 then isnull(t.ICTransactionExchangeQty,0) else 0 end  OutQty
				, case when t.ICTransactionType = 2 then isnull(t.ICTransactionExchangeTotalCost,0) else 0 end  OutAmt
				, 0
				, 0
			from #productIDs pd
				INNER JOIN ICTransactions t ON pd.FK_ICProductID = t.FK_ICProductID
				left join ICProducts p on t.FK_ICProductID = p.ICProductID
				left join ICStocks st on t.FK_ICStockID = st.ICStockID 
				left join ICMeasureUnits dvt on p.FK_ICProductBasicUnitID = dvt.ICMeasureUnitID
			where (t.FK_ICProductID = @FK_ICProductID or @FK_ICProductID is null ) 
				and (p.FK_ICDepartmentID = @ICDepartmentID or @ICDepartmentID is null)
				and (p.FK_ICProductGroupID = @ICProductGroupID or @ICProductGroupID is null)
				and (p.FK_APSupplierID = @FK_APSupplierID or @FK_APSupplierID is null)
				and (t.FK_ICStockID = @FK_ICStockID or @FK_ICStockID is null)
				and (t.FK_MMBatchProductID = @FK_MMBatchProductID or @FK_MMBatchProductID is NULL OR t.ICTransactionType = 1)
				and DATEDIFF(DD,ICTransactionDate,@FromDate) <= 0 
				and DATEDIFF(DD,@ToDate,ICTransactionDate) <= 0
				AND t.AAStatus ='Alive'

				DROP TABLE #productIDs
		END

	ELSE 
		BEGIN
			--Số dư dầu kỳ
			Insert into #rpt
			select FK_ICProductID
				, case when @IsGroupByStock = 1 then FK_ICStockID else null end
				--, Opening.FK_MMBatchProductID
				, sum(dkQty) 
				, sum(dkAmt)
				, 0
				, 0
				, 0
				, 0
				, 0
				, 0
			from
			(
				select FK_ICProductID
					, ib.FK_ICStockID
					--, ib.FK_MMBatchProductID
					, case when ib.ICInvBalanceExchangeQty is null then 0 else isnull(ib.ICInvBalanceExchangeQty,0) end as dkQty
					, case when ib.ICInvBalanceExchangeTotalCost is null then 0 else isnull(ib.ICInvBalanceExchangeTotalCost,0) end as dkAmt
				from ICInvBalances ib 
					left join ICProducts p on ib.FK_ICProductID = p.ICProductID
					left join ICStocks st on ib.FK_ICStockID = st.ICStockID 
					left join ICMeasureUnits dvt on p.FK_ICProductBasicUnitID = dvt.ICMeasureUnitID
				where (ib.FK_ICProductID = @FK_ICProductID or @FK_ICProductID is null ) 
					and (p.FK_ICDepartmentID = @ICDepartmentID or @ICDepartmentID is null)
					and (p.FK_ICProductGroupID = @ICProductGroupID or @ICProductGroupID is null)
					and (p.FK_APSupplierID = @FK_APSupplierID or @FK_APSupplierID is null)
					and (ib.FK_ICStockID = @FK_ICStockID or @FK_ICStockID is null)
					--and (ib.FK_MMBatchProductID = @FK_MMBatchProductID or @FK_MMBatchProductID is null)
					and DATEDIFF(DD,ICInvBalanceDate, @LockDate) = 0  
					AND ib.AAStatus ='Alive'
				union all
				select t.FK_ICProductID
					, t.FK_ICStockID
					--, t.FK_MMBatchProductID
					, case when t.ICTransactionType = 1  then isnull(t.ICTransactionExchangeQty,0) else - isnull(t.ICTransactionExchangeQty,0) end  dkQty
					, case when t.ICTransactionType = 1 then isnull(t.ICTransactionExchangeTotalCost,0) else - isnull(t.ICTransactionExchangeTotalCost,0) end  dkAmt
				from ICTransactions t 
					left join ICProducts Pr on t.FK_ICProductID = pr.ICProductID
					left join ICStocks st on t.FK_ICStockID = st.ICStockID 
					left join ICMeasureUnits dvt on Pr.FK_ICProductBasicUnitID = dvt.ICMeasureUnitID
				where  (t.FK_ICProductID = @FK_ICProductID or @FK_ICProductID is null ) 
					and (Pr.FK_ICDepartmentID = @ICDepartmentID or @ICDepartmentID is null)
					and (Pr.FK_ICProductGroupID = @ICProductGroupID or @ICProductGroupID is null)
					and (Pr.FK_APSupplierID = @FK_APSupplierID or @FK_APSupplierID is null)
					and (t.FK_ICStockID = @FK_ICStockID or @FK_ICStockID is null)
					and (t.FK_MMBatchProductID = @FK_MMBatchProductID or @FK_MMBatchProductID is NULL OR t.ICTransactionType = 1)
					and DATEDIFF(DD,ICTransactionDate, @LockDate) <= 0 
					and DATEDIFF(DD,@FromDate,ICTransactionDate) < 0  
					AND t.AAStatus ='Alive'
			) Opening 
			group by FK_ICProductID
				, (case when @IsGroupByStock = 1 then FK_ICStockID else null end)

			--Phát sinh trong kỳ
			insert into #rpt
			select  t.FK_ICProductID
				, t.FK_ICStockID
				--, t.FK_MMBatchProductID
				, 0
				, 0
				, case when t.ICTransactionType = 1  then isnull(t.ICTransactionExchangeQty,0) else 0 end  InQty
				, case when t.ICTransactionType = 1  then isnull(t.ICTransactionExchangeTotalCost,0) else 0 end  InAmt
				, case when t.ICTransactionType = 2 then isnull(t.ICTransactionExchangeQty,0) else 0 end  OutQty
				, case when t.ICTransactionType = 2 then isnull(t.ICTransactionExchangeTotalCost,0) else 0 end  OutAmt
				, 0
				, 0
			From ICTransactions t 
				left join ICProducts p on t.FK_ICProductID = p.ICProductID
				left join ICStocks st on t.FK_ICStockID = st.ICStockID 
				left join ICMeasureUnits dvt on p.FK_ICProductBasicUnitID = dvt.ICMeasureUnitID
			where (t.FK_ICProductID = @FK_ICProductID or @FK_ICProductID is null ) 
				and (p.FK_ICDepartmentID = @ICDepartmentID or @ICDepartmentID is null)
				and (p.FK_ICProductGroupID = @ICProductGroupID or @ICProductGroupID is null)
				and (p.FK_APSupplierID = @FK_APSupplierID or @FK_APSupplierID is null)
				and (t.FK_ICStockID = @FK_ICStockID or @FK_ICStockID is null)
				and (t.FK_MMBatchProductID = @FK_MMBatchProductID or @FK_MMBatchProductID is NULL OR t.ICTransactionType = 1)
				and DATEDIFF(DD,ICTransactionDate,@FromDate) <= 0 
				and DATEDIFF(DD,@ToDate,ICTransactionDate) <= 0
				AND t.AAStatus ='Alive'
		END 

-- Số dư cuối kỳ
	select FK_ICProductID
		, (case when @IsGroupByStock = 1 then FK_ICStockID else null end) as FK_ICStockID
		--, FK_MMBatchProductID
		, sum(dkQty) as dkQty
		, sum(dkAmt) as dkAmt
		, sum(inQty) as inQty
		, sum(inAmt) as inAmt
		, sum(outQty) as outQty
		, sum(outAmt) as outAmt
		, sum(dkQty) + sum(inQty) - sum(outQty) as ckQty
		, sum(dkAmt)+ sum(inAmt)- sum(outAmt) as ckAmt
	into #rpt2
	from #rpt 
	group by FK_ICProductID
		, (case when @IsGroupByStock = 1 then FK_ICStockID else null end)

	Delete #rpt2 
	where abs(dkQty) + abs(dkAmt) + abs(inQty) + abs(inAmt) + abs(outQty) + abs(outAmt) = 0

	select 
		FK_ICProductID 
		, FK_ICStockID
		, s.ICStockNo
		, s.ICStockName
		, p.ICProductNo
		, p.ICProductNoOfOldSys
		, p.ICProductDesc
		, dkQty as ICTransactionOpeningQty
		, dkAmt as ICTransactionOpeningBalance
		, inQty as ICTransactionReceiptQty
		, inAmt as ICTransactionReceiptBalance
		, outQty as ICTransactionShipmentQty
		, outAmt as ICTransactionShipmentBalance
		, ckQty as ICTransactionEndQty
		, ckAmt as  ICTransactionEndBalance
		, ac.ACAccountNo
		, p.ICProductName
		, dvt.ICMeasureUnitName
	from #rpt2 a 
		inner join ICProducts p on a.FK_ICProductID = p.ICProductID
		left join ACAccounts ac on p.FK_ACAccountID = ac.ACAccountID
		left join ICStocks s on a.FK_ICStockID = s.ICStockID
		left join ICMeasureUnits dvt on p.FK_ICProductBasicUnitID = dvt.ICMeasureUnitID
	ORDER by FK_ICProductID
	

	DROP TABLE #rpt
	DROP TABLE #rpt2
END


GO

