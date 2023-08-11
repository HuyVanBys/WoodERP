SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		<LuuNguyen>
-- Create date: <2018-12-17>
-- Description:	<Posted Nhập kho>
-- =============================================
ALTER PROCEDURE [dbo].[IC_PostedARInvoiceItems]
	@ModuleName		NVARCHAR(256),
	@ARInvoiceID	INT,
	@IsPosted		BIT
AS
BEGIN
	DECLARE @TransactionDate DATETIME = (SELECT ARInvoiceDate FROM dbo.ARInvoices (NOLOCK) WHERE ARInvoiceID = @ARInvoiceID)

	DECLARE @LockDate DATETIME
	SELECT @LockDate = MAX(ADLockToDate) FROM dbo.ADLocks

	IF	DATEDIFF(DAY, @TransactionDate, @LockDate) >= 0
		RETURN

	DECLARE @StockID INT
	SELECT TOP 1 @StockID = ICStockID FROM dbo.ICStocks WHERE ICStockType = 'SaleOrder'

	IF EXISTS(SELECT ICVitualTransactionReferenceID FROM dbo.ICVitualTransactions (NOLOCK) WHERE ICVitualTransactionReferenceID = @ARInvoiceID and ICVitualTransactionModuleName = @ModuleName and FK_ICStockID = @StockID)
		DELETE FROM ICVitualTransactions WHERE ICVitualTransactionReferenceID = @ARInvoiceID and ICVitualTransactionModuleName = @ModuleName and FK_ICStockID = @StockID
	
	IF	(@IsPosted = 0)
		RETURN

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
		, ic.FK_ICProductID
		, ps.ICProductSerieLotNo AS ARInvoiceItemLotNo
		, ps.ICProductSerieNo	AS  ARInvoiceItemProductSerialNo
		, p.FK_ICProductBasicUnitID AS FK_ICMeasureUnitID
		, ic.ARInvoiceItemComponentQty * (SELECT dbo.FCalculateProductMeasureUnitFactor(ii.FK_ICProductID, ii.FK_ICMeasureUnitID, (SELECT TOP 1 FK_ICProductBasicUnitID FROM dbo.ICProducts WHERE ICProductID = ii.FK_ICProductID AND AAStatus = 'Alive'))) AS ExchangeQty
		, case when soi.ARSaleOrderItemGrantedFrom = 'Inventory' then ic.ARInvoiceItemComponentQty else 0 end  as ICTransactionQty2
		, 0 AS ARInvoiceItemProductUnitCost
		, 0 AS ARInvoiceItemTotalCost
		, p.ICProductLength AS ARInvoiceItemLength
		, p.ICProductWidth AS ARInvoiceItemWidth
		, p.ICProductHeight AS ARInvoiceItemHeight
		, case when soi.ARSaleOrderItemGrantedFrom = 'Inventory' then soi.FK_ICStockID  else 0 END AS ICStockID
	INTO #InvoiceItemPosted
	FROM [dbo].[ARInvoiceItems] ii (NOLOCK)
		INNER JOIN [dbo].[ARInvoices] i (NOLOCK) ON i.ARInvoiceID = ii.FK_ARInvoiceID AND i.AAStatus = 'Alive'
		INNER JOIN [dbo].[ARInvoiceItemComponents] ic (NOLOCK) ON ic.FK_ARInvoiceItemID = ii.ARInvoiceItemID AND ic.AAStatus = 'Alive'
		OUTER APPLY (SELECT ICProductSerieNo, ICProductSerieLotNo FROM dbo.ICProductSeries c WHERE c.ICProductSerieID = ic.FK_ICProductSerieID) AS ps
		INNER JOIN dbo.ICProducts p (NOLOCK) ON p.ICProductID = ic.FK_ICProductID
		LEFT JOIN dbo.ARSaleOrderItems soi with (nolock) on soi.ARSaleOrderItemID = ii.FK_ARSaleOrderItemID and soi.AAStatus = 'Alive'
		OUTER APPLY (SELECT HREmployeeName FROM dbo.HREmployees WHERE HREmployeeID = i.FK_HREmployeeID) AS e
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
		, I.ARObjectType
		, e.HREmployeeName
		, i.ARInvoiceDesc
		, ii.ARInvoiceItemProductDesc
		, i.FK_GECurrencyID
		, i.ARInvoiceExchangeRate
		, ii.FK_ICProductID
		, ii.ARInvoiceItemLotNo
		, ii.ARInvoiceItemProductSerialNo
		, ii.FK_ICMeasureUnitID
		, ii.ARInvoiceItemProductQty * (SELECT dbo.FCalculateProductMeasureUnitFactor(ii.FK_ICProductID, ii.FK_ICMeasureUnitID, (SELECT TOP 1 FK_ICProductBasicUnitID FROM dbo.ICProducts WHERE ICProductID = ii.FK_ICProductID AND AAStatus = 'Alive'))) AS ExchangeQty
		, case when soi.ARSaleOrderItemGrantedFrom = 'Inventory' then ii.ARInvoiceItemProductQty else 0 end  as ICTransactionQty2
		, ii.ARInvoiceItemProductUnitCost
		, ii.ARInvoiceItemTotalCost
		, ii.ARInvoiceItemLength
		, ii.ARInvoiceItemWidth
		, ii.ARInvoiceItemHeight
		, case when soi.ARSaleOrderItemGrantedFrom = 'Inventory' then soi.FK_ICStockID  else 0 END AS ICStockID
	FROM [dbo].[ARInvoiceItems] ii (NOLOCK)
		INNER JOIN [dbo].[ARInvoices] i (NOLOCK) ON i.ARInvoiceID = ii.FK_ARInvoiceID AND i.AAStatus = 'Alive'
		INNER JOIN dbo.ICProducts p (NOLOCK) ON p.ICProductID = ii.FK_ICProductID
		LEFT JOIN dbo.ARSaleOrderItems soi with (nolock) on soi.ARSaleOrderItemID = ii.FK_ARSaleOrderItemID and soi.AAStatus = 'Alive'
		OUTER APPLY (SELECT HREmployeeName FROM dbo.HREmployees WHERE HREmployeeID = i.FK_HREmployeeID) AS e
	WHERE ii.AAStatus = 'Alive'
		AND i.ARInvoiceID = @ARInvoiceID
		AND (p.ICProductIsFollowInventoryStock = 1 OR p.HasComponent = 1)
		AND i.ARInvoiceTypeCombo = 'InvoiceAndShipment'
		--AND NOT EXISTS (SELECT 1 FROM [dbo].[ARInvoiceItemComponents] c 
		--				WHERE c.AAStatus = 'Alive'
		--				AND c.FK_ARInvoiceItemID = ii.ARInvoiceItemID)

----------Post sổ----------
	INSERT INTO ICVitualTransactions
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
		, @StockID
		, 2 --Nhập xuất (1:Nhập, 2: Xuất)
		, 0
		, 0
		, 0
		, i.FK_ICProductID
		, i.ARInvoiceItemLotNo
		, i.ARInvoiceItemProductSerialNo
		, i.FK_ICMeasureUnitID
		, i.ExchangeQty
		, 1
		, i.ExchangeQty
		, 0 as ICTransactionQty1
		, i.ICTransactionQty2
		, 0 as ICTransactionQty3
		, '' as ICTransactionFeePaymentType
		, i.ARInvoiceItemProductUnitCost
		, i.ARInvoiceItemTotalCost
		, 0
		, 0
		, 0
		, 0
		, 0
		, 0 as FK_ACCostCenterID
		, 0
		, 0 as FK_MMBatchProductID
		, 0 as FK_ARInvoiceID
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
		, i.ARInvoiceItemLength
		, i.ARInvoiceItemWidth
		, i.ARInvoiceItemHeight
		, ''
		, i.ICStockID
	FROM #InvoiceItemPosted i

	DROP TABLE #InvoiceItemPosted
END		

GO

