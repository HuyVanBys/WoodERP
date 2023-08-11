SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO


ALTER PROCEDURE [dbo].[ARSaleOrderItems_UpdateInventoryStocks]
	@ARSaleOrderID int
AS
BEGIN
SET NOCOUNT ON
	DECLARE @ModuleName nvarchar(256) = 'SaleOrder',
	@IsPosted BIT = 1

	declare @TransactionDate datetime = (select ARSaleOrderDate from ARSaleOrders with (nolock) where ARSaleOrderID = @ARSaleOrderID)

	declare @LockDate datetime
	select @LockDate = max(ADLockToDate) from ADLocks

	if 	DATEDIFF(DAY, @TransactionDate, @LockDate) >= 0
		return

	declare @StockID int
	select top 1 @StockID = ICStockID from ICStocks where ICStockType = 'SaleOrder'



	if exists(select ICVitualTransactionReferenceID from ICVitualTransactions with (nolock) where ICVitualTransactionReferenceID = @ARSaleOrderID and ICVitualTransactionModuleName = @ModuleName and FK_ICStockID = @StockID)
		delete from ICVitualTransactions where ICVitualTransactionReferenceID = @ARSaleOrderID and ICVitualTransactionModuleName = @ModuleName and FK_ICStockID = @StockID
	
	if(@IsPosted = 0)
		return
	
	CREATE TABLE  #ARSaleOrderItems
	(
		  FK_ICProductID int
		, FK_ICStockID INT
        , ARSaleOrderItemID INT
		, AACreatedUser NVARCHAR(50)
		, AAUpdatedUser NVARCHAR(50)
		, FK_ARSaleOrderID INT
		, FK_ICMeasureUnitID INT 
        , ARSaleOrderItemProductSerialNo NVARCHAR(50)
		, ARSaleOrderItemProductFactor DECIMAL(18,5)
		, ARSaleOrderItemProductQty DECIMAL(18,5)
		, ARSaleOrderItemGrantedFrom NVARCHAR(50)
		, ARSaleOrderItemProductDesc NVARCHAR(4000)
		, ARSaleOrderItemWoodQty DECIMAL(18,5)
		, ARSaleOrderItemProductExchangeQty DECIMAL(18,5)
		, ARSaleOrderItemProductUnitCost DECIMAL(18,5)
		, ARSaleOrderItemTotalCost DECIMAL(18,5)
		, FK_ACAssetID INT 
		, FK_ICProductEquipmentID INT 
		, ARSaleOrderItemLength DECIMAL(18,5)
		, ARSaleOrderItemWidth DECIMAL(18,5)
		, ARSaleOrderItemHeight DECIMAL(18,5)
	)
	insert into #ARSaleOrderItems
	select soi.FK_ICProductID 
		,	soi.FK_ICStockID
		,	soi.ARSaleOrderItemID
		,	soi.AACreatedUser
		,	soi.AAUpdatedUser
		,	soi.FK_ARSaleOrderID
		,	soi.FK_ICMeasureUnitID
		,	soi.ARSaleOrderItemProductSerialNo
		,	soi.ARSaleOrderItemProductFactor
		,	ISNULL(ca.ARCancelVoucherItemProductQty,0)
			+ CASE WHEN ISNULL(si.ICShipmentItemProductQty,0) > ISNULL(inv.ARInvoiceItemProductQty,0) THEN ISNULL(si.ICShipmentItemProductQty,0) ELSE ISNULL(inv.ARInvoiceItemProductQty,0) END 
		,	soi.ARSaleOrderItemGrantedFrom
		,	soi.ARSaleOrderItemProductDesc
		,	soi.ARSaleOrderItemWoodQty
		,	soi.ARSaleOrderItemProductExchangeQty
		,	soi.ARSaleOrderItemProductUnitCost
		,	soi.ARSaleOrderItemTotalCost
		,	soi.FK_ACAssetID
		,	soi.FK_ICProductEquipmentID
		,	soi.ARSaleOrderItemLength
		,	soi.ARSaleOrderItemWidth
		,	 soi.ARSaleOrderItemHeight
	from ARSaleOrderItems soi 
	OUTER APPLY (select sum(cvi.ARCancelVoucherItemProductQty) AS ARCancelVoucherItemProductQty
			from ARCancelVoucherItems cvi 
				inner join ARCancelVouchers cv on cvi.FK_ARCancelVoucherID = cv.ARCancelVoucherID
			where cvi.FK_ARSaleOrderItemID = soi.ARSaleOrderItemID
				and cvi.AAStatus = 'Alive'
				and cv.AAStatus = 'Alive'
				and cv.ARCancelVoucherStatus = 'Complete') ca
	OUTER APPLY (select sum(si.ICShipmentItemProductQty) AS ICShipmentItemProductQty
			from ICShipmentItems si 
				inner join ICShipments s on si.FK_ICShipmentID = s.ICShipmentID
			where si.FK_ARSaleOrderItemID = soi.ARSaleOrderItemID
				and si.AAStatus = 'Alive'
				and s.AAStatus = 'Alive'
				and s.ICShipmentStatus = 'Complete') si
	OUTER APPLY (select sum(inv.ARInvoiceItemProductQty) AS ARInvoiceItemProductQty
			from dbo.ARInvoiceItems inv 
				inner join ARInvoices iv on inv.FK_ARInvoiceID = iv.ARInvoiceID
			where inv.FK_ARSaleOrderItemID = soi.ARSaleOrderItemID
				and inv.AAStatus = 'Alive'
				and iv.AAStatus = 'Alive'
				and iv.ARInvoiceStatus = 'Complete') inv
	where soi.FK_ARSaleOrderID = @ARSaleOrderID
	AND soi.AAStatus = 'Alive'


	insert into ICVitualTransactions
		SELECT
		'Alive'
		, GETDATE()
		, soi.AACreatedUser
		, GETDATE()
		, soi.AAUpdatedUser
		, so.ARSaleOrderID
		, so.ARSaleOrderNo
		, @ModuleName
		, so.ARSaleOrderType
		, so.ARSaleOrderDate
		, soi.ARSaleOrderItemID
		, so.FK_HREmployeeID
		, so.FK_BRBranchID
		, so.FK_ARCustomerID
		, 'Customer' as ACObjectType
		, e.HREmployeeName
		, so.ARSaleOrderDesc
		, p.ICProductDesc AS ARSaleOrderItemProductDesc
		, so.FK_GECurrencyID
		, so.ARSaleOrderExchangeRate
		, @StockID
		, 1 --Nhập xuất (1:Nhập, 2: Xuất)
		, 0
		, 0
		, 0
		, ic.FK_ICProductID
		, ''
		, soi.ARSaleOrderItemProductSerialNo
		, soi.FK_ICMeasureUnitID
		, ic.ARSOItemComponentQty AS ARSaleOrderItemProductQty
		, soi.ARSaleOrderItemProductFactor
		, ic.ARSOItemComponentQty * (SELECT dbo.FCalculateProductMeasureUnitFactor(soi.FK_ICProductID, soi.FK_ICMeasureUnitID, (SELECT TOP 1 FK_ICProductBasicUnitID FROM dbo.ICProducts WHERE ICProductID = soi.FK_ICProductID AND AAStatus = 'Alive'))) AS ARSaleOrderItemProductExchangeQty
		, 0 as ICTransactionQty1
		, case when soi.ARSaleOrderItemGrantedFrom = 'Inventory' then soi.ARSaleOrderItemProductQty else 0 end --0 as ICTransactionQty2 : SL dat ban
		, 0 as ICTransactionQty3
		, '' as ICTransactionFeePaymentType
		, 0 AS ARSaleOrderItemProductUnitCost
		, 0 AS ARSaleOrderItemTotalCost
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0 as FK_ACCostCenterID
		, 0
		, so.FK_MMBatchProductID
		, 0 as FK_ARSaleOrderID
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0 as FK_PMProjectID
		, 0 AS FK_ACAssetID
		, 0 AS FK_ICProductEquipmentID
		, 0
		, 0 as FK_ACUnfinishedConstructionCostID
		, 0 as FK_ACLoanReceiptID
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
		, 0 AS ARSaleOrderItemLength
		, 0 AS ARSaleOrderItemWidth
		, 0 AS ARSaleOrderItemHeight
		, ''
		, case when soi.ARSaleOrderItemGrantedFrom = 'Inventory' then soi.FK_ICStockID  else 0 end
	from #ARSaleOrderItems soi  with (nolock)
		inner join ARSaleOrders so with (nolock) on soi.FK_ARSaleOrderID = so.ARSaleOrderID
		INNER JOIN dbo.ARSOItemComponents ic WITH(NOLOCK) ON ic.FK_ARSaleOrderItemID = soi.ARSaleOrderItemID
		INNER JOIN dbo.ICProducts p WITH(NOLOCK) ON p.ICProductID = ic.FK_ICProductID
		left join HREmployees e with (nolock) on so.FK_HREmployeeID = e.HREmployeeID
	where  so.AAStatus = 'Alive'
		and so.ARSaleOrderID = @ARSaleOrderID
		AND p.ICProductIsFollowInventoryStock = 1
UNION all
	SELECT
		'Alive'
		, GETDATE()
		, soi.AACreatedUser
		, GETDATE()
		, soi.AAUpdatedUser
		, so.ARSaleOrderID
		, so.ARSaleOrderNo
		, @ModuleName
		, so.ARSaleOrderType
		, so.ARSaleOrderDate
		, soi.ARSaleOrderItemID
		, so.FK_HREmployeeID
		, so.FK_BRBranchID
		, so.FK_ARCustomerID
		, 'Customer' as ACObjectType
		, e.HREmployeeName
		, so.ARSaleOrderDesc
		, soi.ARSaleOrderItemProductDesc
		, so.FK_GECurrencyID
		, so.ARSaleOrderExchangeRate
		, @StockID
		, 1 --Nhập xuất (1:Nhập, 2: Xuất)
		, 0
		, 0
		, 0
		, soi.FK_ICProductID
		, ''
		, soi.ARSaleOrderItemProductSerialNo
		, soi.FK_ICMeasureUnitID
		, soi.ARSaleOrderItemProductQty * (SELECT dbo.FCalculateProductMeasureUnitFactor(soi.FK_ICProductID, soi.FK_ICMeasureUnitID, (SELECT TOP 1 FK_ICProductBasicUnitID FROM dbo.ICProducts WHERE ICProductID = soi.FK_ICProductID AND AAStatus = 'Alive')))
		, 1
		, soi.ARSaleOrderItemProductQty * (SELECT dbo.FCalculateProductMeasureUnitFactor(soi.FK_ICProductID, soi.FK_ICMeasureUnitID, (SELECT TOP 1 FK_ICProductBasicUnitID FROM dbo.ICProducts WHERE ICProductID = soi.FK_ICProductID AND AAStatus = 'Alive')))
		, soi.ARSaleOrderItemWoodQty as ICTransactionQty1
		, case when soi.ARSaleOrderItemGrantedFrom = 'Inventory' then soi.ARSaleOrderItemProductExchangeQty else 0 end --0 as ICTransactionQty2 : SL dat ban
		, 0 as ICTransactionQty3
		, '' as ICTransactionFeePaymentType
		, soi.ARSaleOrderItemProductUnitCost
		, soi.ARSaleOrderItemTotalCost
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0 as FK_ACCostCenterID
		, 0
		, so.FK_MMBatchProductID
		, 0 as FK_ARSaleOrderID
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0 as FK_PMProjectID
		, soi.FK_ACAssetID
		, soi.FK_ICProductEquipmentID
		, 0
		, 0 as FK_ACUnfinishedConstructionCostID
		, 0 as FK_ACLoanReceiptID
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
		, soi.ARSaleOrderItemLength
		, soi.ARSaleOrderItemWidth
		, soi.ARSaleOrderItemHeight
		, ''
		, case when soi.ARSaleOrderItemGrantedFrom = 'Inventory' then soi.FK_ICStockID  else 0 end
	from #ARSaleOrderItems soi  with (nolock)
		inner join ARSaleOrders so with (nolock) on soi.FK_ARSaleOrderID = so.ARSaleOrderID
		INNER JOIN dbo.ICProducts p WITH (NOLOCK) ON p.ICProductID = soi.FK_ICProductID
		left join HREmployees e with (nolock) on so.FK_HREmployeeID = e.HREmployeeID
	where so.AAStatus = 'Alive'
		AND p.AAStatus = 'Alive'
		AND (p.ICProductIsFollowInventoryStock = 1 OR p.HasComponent = 1)
		and so.ARSaleOrderID = @ARSaleOrderID
	DROP TABLE #ARSaleOrderItems
END
GO

