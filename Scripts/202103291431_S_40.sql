SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO


-- =============================================
-- Author:		<LuuNguyen>
-- Create date: <2018-12-17>
-- Description:	<Posted Nhập kho>
-- =============================================
ALTER PROCEDURE [dbo].[IC_PostedARCancelVoucherItems]
	@ModuleName nvarchar(256),
	@ARCancelVoucherID int,
	@IsPosted bit
AS
BEGIN
	declare @TransactionDate datetime = (select ARCancelVoucherDate from ARCancelVouchers with (nolock) where ARCancelVoucherID = @ARCancelVoucherID)

	declare @LockDate datetime
	select @LockDate = max(ADLockToDate) from ADLocks

	if 	DATEDIFF(DAY, @TransactionDate, @LockDate) >= 0
		return

	declare @StockID int
	select top 1 @StockID = ICStockID from ICStocks where ICStockType = 'SaleOrder'

	if exists(select ICVitualTransactionReferenceID from ICVitualTransactions with (nolock) where ICVitualTransactionReferenceID = @ARCancelVoucherID and ICVitualTransactionModuleName = @ModuleName and FK_ICStockID = @StockID)
		delete from ICVitualTransactions where ICVitualTransactionReferenceID = @ARCancelVoucherID and ICVitualTransactionModuleName = @ModuleName and FK_ICStockID = @StockID
	
	if(@IsPosted = 0)
		return
	
	insert into ICVitualTransactions
	select 
		cvi.AAStatus
		, GETDATE()
		, cv.AACreatedUser
		, GETDATE()
		, cv.AAUpdatedUser
		, cv.ARCancelVoucherID
		, cv.ARCancelVoucherNo
		, @ModuleName
		, cv.ARCancelVoucherType
		, cv.ARCancelVoucherDate
		, cvi.ARCancelVoucherItemID
		, cv.FK_HREmployeeID
		, cv.FK_BRBranchID
		, cv.FK_ACObjectID
		, cv.ARObjectType
		, e.HREmployeeName
		, cv.ARCancelVoucherDesc
		, p.ICProductDesc
		, cv.FK_GECurrencyID
		, cv.ARCancelVoucherExchangeRate
		, @StockID
		, 2 --Nhập xuất (1:Nhập, 2: Xuất)
		, 0
		, 0
		, 0
		, ic.FK_ICProductID
		, ''
		, cvi.ARCancelVoucherItemProductSerialNo
		, cvi.FK_ICMeasureUnitID
		, cvi.ARCancelVoucherItemProductQty * (ic.ARSOItemComponentQty/soi.ARSaleOrderItemProductQty)
		, (CASE WHEN pmu.ICProductMeasureUnitFactor IS NULL OR pmu.ICProductMeasureUnitFactor = 0
			THEN 1
			ELSE pmu.ICProductMeasureUnitFactor
			end
		)
		, (CASE WHEN pmu.ICProductMeasureUnitFactor IS NULL OR pmu.ICProductMeasureUnitFactor = 0
			THEN cvi.ARCancelVoucherItemProductQty * (ic.ARSOItemComponentQty/soi.ARSaleOrderItemProductQty)
			ELSE pmu.ICProductMeasureUnitFactor * (cvi.ARCancelVoucherItemProductQty * (ic.ARSOItemComponentQty/soi.ARSaleOrderItemProductQty))
			end
		)
		, 0 as ICTransactionQty1
		, case when soi.ARSaleOrderItemGrantedFrom = 'Inventory' THEN cvi.ARCancelVoucherItemProductQty * (ic.ARSOItemComponentQty/soi.ARSaleOrderItemProductQty) else 0 end --0 as ICTransactionQty2 : SL dat ban
		, 0 as ICTransactionQty3
		, '' as ICTransactionFeePaymentType
		, cvi.ARCancelVoucherItemProductUnitCost
		, cvi.ARCancelVoucherItemTotalCost
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0 as FK_ACCostCenterID
		, 0
		, 0 as FK_MMBatchProductID
		, 0 as FK_ARCancelVoucherID
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0 as FK_PMProjectID
		, 0 as FK_ACAssetID
		, 0 as FK_ICProductEquipmentID
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
		, 0
		, 0
		, 0
		, ''
		, case when soi.ARSaleOrderItemGrantedFrom = 'Inventory' then soi.FK_ICStockID  else 0 end
	from ARCancelVoucherItems cvi  (nolock)
		inner join ARCancelVouchers cv (nolock) on cvi.FK_ARCancelVoucherID = cv.ARCancelVoucherID
		left join  ARSaleOrderItems soi (nolock) on cvi.FK_ARSaleOrderItemID = soi.ARSaleOrderItemID and soi.AAStatus = 'Alive'
		INNER JOIN dbo.ARSOItemComponents ic (nolock) ON ic.FK_ARSaleOrderItemID = soi.ARSaleOrderItemID
			AND ic.AAStatus = 'Alive'
		INNER JOIN dbo.ICProducts p ON p.ICProductID = ic.FK_ICProductID
		left join HREmployees e (nolock) on cv.FK_HREmployeeID = e.HREmployeeID
		left join dbo.ICProductMeasureUnits pmu ON pmu.FK_ICProductID = cvi.FK_ICProductID 
												AND pmu.FK_ICMeasureUnitID = cvi.FK_ICMeasureUnitID
												AND pmu.AAStatus = 'Alive'
		
	where cvi.AAStatus = 'Alive'
		AND p.AAStatus = 'Alive'
		and cv.AAStatus = 'Alive'
		and cv.ARCancelVoucherID = @ARCancelVoucherID
	UNION ALL
    select 
		cvi.AAStatus
		, GETDATE()
		, cv.AACreatedUser
		, GETDATE()
		, cv.AAUpdatedUser
		, cv.ARCancelVoucherID
		, cv.ARCancelVoucherNo
		, @ModuleName
		, cv.ARCancelVoucherType
		, cv.ARCancelVoucherDate
		, cvi.ARCancelVoucherItemID
		, cv.FK_HREmployeeID
		, cv.FK_BRBranchID
		, cv.FK_ACObjectID
		, cv.ARObjectType
		, e.HREmployeeName
		, cv.ARCancelVoucherDesc
		, cvi.ARCancelVoucherItemProductDesc
		, cv.FK_GECurrencyID
		, cv.ARCancelVoucherExchangeRate
		, @StockID
		, 2 --Nhập xuất (1:Nhập, 2: Xuất)
		, 0
		, 0
		, 0
		, cvi.FK_ICProductID
		, ''
		, cvi.ARCancelVoucherItemProductSerialNo
		, cvi.FK_ICMeasureUnitID
		, cvi.ARCancelVoucherItemProductQty 
		, (CASE WHEN pmu.ICProductMeasureUnitFactor IS NULL OR pmu.ICProductMeasureUnitFactor = 0
			THEN 1
			ELSE pmu.ICProductMeasureUnitFactor
			end
		)
		, (CASE WHEN pmu.ICProductMeasureUnitFactor IS NULL OR pmu.ICProductMeasureUnitFactor = 0
			THEN cvi.ARCancelVoucherItemProductQty
			ELSE pmu.ICProductMeasureUnitFactor * cvi.ARCancelVoucherItemProductQty
			end
		)
		, 0 as ICTransactionQty1
		, case when soi.ARSaleOrderItemGrantedFrom = 'Inventory' then cvi.ARCancelVoucherItemProductQty else 0 end --0 as ICTransactionQty2 : SL dat ban
		, 0 as ICTransactionQty3
		, '' as ICTransactionFeePaymentType
		, cvi.ARCancelVoucherItemProductUnitCost
		, cvi.ARCancelVoucherItemTotalCost
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0 as FK_ACCostCenterID
		, 0
		, 0 as FK_MMBatchProductID
		, 0 as FK_ARCancelVoucherID
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0 as FK_PMProjectID
		, 0 as FK_ACAssetID
		, 0 as FK_ICProductEquipmentID
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
		, 0
		, 0
		, 0
		, ''
		, case when soi.ARSaleOrderItemGrantedFrom = 'Inventory' then soi.FK_ICStockID  else 0 end
	from ARCancelVoucherItems cvi  (nolock)
		INNER JOIN dbo.ICProducts p ON p.ICProductID = cvi.FK_ICProductID
		inner join ARCancelVouchers cv (nolock) on cvi.FK_ARCancelVoucherID = cv.ARCancelVoucherID
		left join  ARSaleOrderItems soi (nolock) on cvi.FK_ARSaleOrderItemID = soi.ARSaleOrderItemID and soi.AAStatus = 'Alive'
		left join HREmployees e (nolock) on cv.FK_HREmployeeID = e.HREmployeeID
		left join dbo.ICProductMeasureUnits pmu ON pmu.FK_ICProductID = cvi.FK_ICProductID 
												AND pmu.FK_ICMeasureUnitID = cvi.FK_ICMeasureUnitID
												AND pmu.AAStatus = 'Alive'
	where cvi.AAStatus = 'Alive'
		AND p.AAStatus = 'Alive'
		and cv.AAStatus = 'Alive'
		and cv.ARCancelVoucherID = @ARCancelVoucherID
		AND (p.ICProductIsFollowInventoryStock = 1 OR p.HasComponent = 1)
END		


--exec IC_PostedARCancelVoucherItems  'SaleOrder', 885, 1
GO

