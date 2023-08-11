SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO


-- =============================================
-- Author:		<LuuNguyen>
-- Create date: <2018-12-17>
-- Description:	<Posted Nhập kho>
-- =============================================
ALTER PROCEDURE [dbo].[IC_PostedSOICShipmentItems]
	@ModuleName nvarchar(256),
	@ICShipmentID int,
	@IsPosted bit
AS
BEGIN
	declare @TransactionDate datetime = (select ICShipmentDate from ICShipments with (nolock) where ICShipmentID = @ICShipmentID)

	declare @LockDate datetime
	select @LockDate = max(ADLockToDate) from ADLocks

	if 	DATEDIFF(DAY, @TransactionDate, @LockDate) >= 0
		return

	declare @StockID int
	select top 1 @StockID = ICStockID from ICStocks where ICStockType = 'SaleOrder'

	if exists(select ICVitualTransactionReferenceID from ICVitualTransactions with (nolock) where ICVitualTransactionReferenceID = @ICShipmentID and ICVitualTransactionModuleName = @ModuleName and FK_ICStockID = @StockID)
		delete from ICVitualTransactions where ICVitualTransactionReferenceID = @ICShipmentID and ICVitualTransactionModuleName = @ModuleName and FK_ICStockID = @StockID
	
	if(@IsPosted = 0)
		return
	
	insert into ICVitualTransactions
	SELECT
		s.AAStatus
		, GETDATE()
		, s.AACreatedUser
		, GETDATE()
		, s.AAUpdatedUser
		, s.ICShipmentID
		, s.ICShipmentNo
		, @ModuleName
		, s.ICShipmentType
		, s.ICShipmentDate
		, si.ICShipmentItemID
		, s.FK_HREmployeeID
		, s.FK_BRBranchID
		, s.FK_ACObjectID
		, s.ICObjectType as ACObjectType
		, e.HREmployeeName
		, s.ICShipmentDesc
		, si.ICShipmentItemProductDesc
		, s.FK_GECurrencyID
		, s.ICShipmentExchangeRate
		, @StockID
		, 2 --Nhập xuất (1:Nhập, 2: Xuất)
		, 0
		, 0
		, 0
		, si.FK_ICProductID
		, ''
		, soi.ARSaleOrderItemProductSerialNo
		, si.FK_ICMeasureUnitID
		, si.ICShipmentItemProductQty
		, si.ICShipmentItemProductFactor
		,  si.ICShipmentItemProductExchangeQty
		, si.ICShipmentItemWoodQty as ICTransactionQty1
		, case when soi.ARSaleOrderItemGrantedFrom = 'Inventory' then si.ICShipmentItemProductQty else 0 end --0 as ICTransactionQty2 : SL dat ban
		, 0 as ICTransactionQty3
		, '' as ICTransactionFeePaymentType
		, si.ICShipmentItemProductUnitCost
		, si.ICShipmentItemTotalCost
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0 as FK_ACCostCenterID
		, 0
		, s.FK_MMBatchProductID
		, 0 as FK_ARSaleOrderID
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0 as FK_PMProjectID
		, si.FK_ACAssetID
		, si.FK_ICProductEquipmentID
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
		, si.ICShipmentItemLength
		, si.ICShipmentItemWidth
		, si.ICShipmentItemHeight
		, ''
		, case when soi.ARSaleOrderItemGrantedFrom = 'Inventory' then si.FK_ICStockID  else 0 end
	from ICShipmentItems si  with (nolock)
		inner join ICShipments s with (nolock) on si.FK_ICShipmentID = s.ICShipmentID
		left join HREmployees e with (nolock) on s.FK_HREmployeeID = e.HREmployeeID
		left join ARSaleOrderItems soi with (nolock) on soi.ARSaleOrderItemID = si.FK_ARSaleOrderItemID and soi.AAStatus = 'Alive'
	where si.AAStatus = 'Alive'
		and s.AAStatus = 'Alive'
		and s.ICShipmentID = @ICShipmentID
		and si.FK_ARSaleOrderItemID > 0
UNION ALL
	SELECT
		s.AAStatus
		, GETDATE()
		, s.AACreatedUser
		, GETDATE()
		, s.AAUpdatedUser
		, s.ICShipmentID
		, s.ICShipmentNo
		, @ModuleName
		, s.ICShipmentType
		, s.ICShipmentDate
		, si.ICShipmentItemID
		, s.FK_HREmployeeID
		, s.FK_BRBranchID
		, s.FK_ACObjectID
		, s.ICObjectType as ACObjectType
		, e.HREmployeeName
		, s.ICShipmentDesc
		, p.ICProductDesc
		, s.FK_GECurrencyID
		, s.ICShipmentExchangeRate
		, @StockID
		, 2 --Nhập xuất (1:Nhập, 2: Xuất)
		, 0
		, 0
		, 0
		, sic.FK_ICProductID
		, ''
		, ps.ICProductSerieNo
		, si.FK_ICMeasureUnitID
		, sic.ICShipmentItemComponentQty
		, si.ICShipmentItemProductFactor
		, sic.ICShipmentItemComponentQty
		, si.ICShipmentItemWoodQty as ICTransactionQty1
		, case when soi.ARSaleOrderItemGrantedFrom = 'Inventory' then sic.ICShipmentItemComponentQty else 0 end --0 as ICTransactionQty2 : SL dat ban
		, 0 as ICTransactionQty3
		, '' as ICTransactionFeePaymentType
		, si.ICShipmentItemProductUnitCost
		, si.ICShipmentItemTotalCost
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0 as FK_ACCostCenterID
		, 0
		, s.FK_MMBatchProductID
		, 0 as FK_ARSaleOrderID
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0 as FK_PMProjectID
		, si.FK_ACAssetID
		, si.FK_ICProductEquipmentID
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
		, si.ICShipmentItemLength
		, si.ICShipmentItemWidth
		, si.ICShipmentItemHeight
		, ''
		, case when soi.ARSaleOrderItemGrantedFrom = 'Inventory' then si.FK_ICStockID  else 0 end
	from ICShipmentItems si  with (nolock)
		INNER JOIN ICShipmentItemComponents sic WITH (NOLOCK) ON sic.FK_ICShipmentItemID = si.ICShipmentItemID
		INNER JOIN dbo.ICProducts p WITH (NOLOCK) ON sic.FK_ICProductID = p.ICProductID
		inner join ICShipments s with (nolock) on si.FK_ICShipmentID = s.ICShipmentID
		left join HREmployees e with (nolock) on s.FK_HREmployeeID = e.HREmployeeID
		left join ARSaleOrderItems soi with (nolock) on soi.ARSaleOrderItemID = si.FK_ARSaleOrderItemID and soi.AAStatus = 'Alive'
		OUTER APPLY (SELECT ICProductSerieNo, ICProductSerieLotNo FROM dbo.ICProductSeries c WHERE c.ICProductSerieID = sic.FK_ICProductSerieID) AS ps
	where si.AAStatus = 'Alive'
		and s.AAStatus = 'Alive'
		AND sic.AAStatus = 'Alive'
		and s.ICShipmentID = @ICShipmentID
		and si.FK_ARSaleOrderItemID > 0
END		


--exec IC_PostedICShipmentItems  'SaleOrder', 885, 1

GO

