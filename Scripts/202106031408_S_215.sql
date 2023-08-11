SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
-- Stored Procedure

-- =============================================
-- Author:		Hoan Vo
-- Create date: 10/01/2020
-- Description:	Get InventoryStockCountItems Active in stock And Department
-- =============================================
ALTER PROCEDURE [dbo].[ICInventoryStockCountItems_GetICInventoryStockCountItemsActiveInStockAndDepartment]
	@FK_BRBranchID				INT = null,
	@FK_ICStockID				INT = null,
	@FK_ICProductGroupID		NVARCHAR(256) = null,
	@FK_ICDepartmentID			INT = null,
	@InventoryStockCountType	NVARCHAR(256) = null,
	@ToDate						DATETIME = null
AS
BEGIN	
	SET NOCOUNT ON;
	--DECLARE @FK_BRBranchID int = null,
	--	@FK_ICStockID int = 8,
	--	@FK_ICProductGroupID nvarchar(256) = null,
	--	@FK_ICDepartmentID int = 1,
	--	@InventoryStockCountType nvarchar(256) = 'Product',
	--	@ToDate datetime = '2020-12-31'

	DECLARE 
		@StartDate DATETIME = GETDATE()
		, @GECurrencyID INT 
		, @IsSemiProduct BIT = 0

	SELECT 
		TOP 1 @StartDate = CSCompanyAccountingBeginDateConfig-1 
		, @GECurrencyID = FK_GESaleCurrencyID
	FROM CSCompanys
	WHERE AAStatus = 'Alive' AND CSCompanyAccountingBeginDateConfig IS NOT NULL

	SELECT 
		@IsSemiProduct = ICStockIsSemiProduct 
	FROM dbo.ICStocks 
	WHERE AAStatus ='Alive' 
		AND ICStockID = @FK_ICStockID
		AND ICStockIsSemiProduct = 1

	CREATE TABLE #InventoryBalance 
	(
		FK_ICProductID INT,
		FK_ICStockID INT, 
		SeriaNo NVARCHAR(50),
		ICStockNo NVARCHAR(50),
		ICStockName NVARCHAR(255),
		ICProductNo NVARCHAR(50),
		ICProductNoOfOldSys NVARCHAR(50),
		ICProductName NVARCHAR(512),
		ICProductDesc NVARCHAR(1024),
		ICTransactionOpeningQty DECIMAL(20,6),
		ICTransactionOpeningBalance DECIMAL(20,6),
		ICTransactionReceiptQty DECIMAL(20,6),
		ICTransactionReceiptBalance DECIMAL(20,6),
		ICTransactionShipmentQty DECIMAL(20,6),
		ICTransactionShipmentBalance DECIMAL(20,6),
		ICTransactionEndQty DECIMAL(20,6),
		ICTransactionEndBalance DECIMAL(20,6),
		ICTransactionUnitCost DECIMAL(20,6), 
		FK_ACAccountID int,
		ACAccountNo NVARCHAR(50),
		FK_BRBranchID INT,
		ICInvBalanceCode01Combo NVARCHAR(50)
	)
	INSERT INTO #InventoryBalance
	EXEC dbo.ICTransactions_GetInventoryStatistics @FromDate = @StartDate,	 -- datetime
		                                            @ToDate = @ToDate,		 -- datetime
		                                            @FK_ICProductID = NULL,	 -- int
													@DepartmentID = @FK_ICDepartmentID, -- int
		                                            @FK_ICStockID = @FK_ICStockID, -- int
		                                            @IsGroupByStock = 1,		 -- bit
													@IsGroupBySeriaNo = 1,    -- bit
		                                            @HasIncompleteProduct = 1, --bit,
													@IsGroupIncompleteProduct = 0, -- bit,
		                                            @FK_BRBranchID = @FK_BRBranchID -- int

	

	SELECT 
		inv.FK_ICProductID
		, inv.FK_ICStockID
		, 0 FK_ICProductSerieID
		, inv.SeriaNo as ICInventoryStockCountItemProductSerialNo
		, (inv.ICProductNo + '-' + inv.SeriaNo) ICInventoryStockCountItemPackageBarcode
		, inv.ICProductNo ICInventoryStockCountItemProductNo
		, inv.ICProductNoOfOldSys ICInventoryStockCountItemICProductSupplierNumber
		, inv.ICProductDesc ICInventoryStockCountItemICProductDesc
		, mu.ICMeasureUnitName
		, ISNULL(SUM(inv.ICTransactionEndQty),0.000) ICInventoryStockCountItemQuantity
		, ROUND(AVG(inv.ICTransactionUnitCost), 2) ICInventoryStockUnitCostAVG
		, 0.00000 ICInventoryStockCountItemPackageQty
		, 0.00000 ICInventoryStockCountItemActualQuantity
		, 0 FK_ICProductPackageItemID
		, 0 FK_ICProductPackageID
	INTO #cal
	FROM #InventoryBalance inv
		INNER JOIN dbo.ICProducts p ON p.ICProductID = inv.FK_ICProductID
		INNER JOIN dbo.ICMeasureUnits mu ON mu.ICMeasureUnitID = p.FK_ICProductBasicUnitID
	WHERE ISNULL(p.HasComponent,0) = 0
	GROUP BY inv.FK_ICProductID
		, inv.FK_ICStockID
		, inv.SeriaNo
		, inv.ICProductNo
		, inv.ICProductNoOfOldSys
		, inv.ICProductDesc
		, mu.ICMeasureUnitName

------------Return------------
	IF(@InventoryStockCountType = 'Package')
		SELECT  
			  cal.FK_ICProductID
			, cal.FK_ICStockID
			, (cal.ICInventoryStockCountItemProductNo) ICInventoryStockCountItemPackageBarcode
			, cal.ICInventoryStockCountItemProductNo
			, cal.ICInventoryStockCountItemICProductSupplierNumber
			, cal.ICInventoryStockCountItemICProductDesc
			, cal.ICMeasureUnitName
			, cal.ICInventoryStockCountItemQuantity ICInventoryStockCountItemQuantity
			, cal.ICInventoryStockUnitCostAVG AS ICInventoryStockUnitCostAVG
			, 0.00000 ICInventoryStockCountItemPackageQty
			, 0.00000 ICInventoryStockCountItemActualQuantity
			, cal.ICInventoryStockCountItemQuantity AS ICInventoryStockCountItemQuantityVariance
			, cal.ICInventoryStockCountItemProductSerialNo 
			, ICInventoryStockUnitCostAVG as ICInventoryStockActualUnitCost
			, ICInventoryStockUnitCostAVG * cal.ICInventoryStockCountItemQuantity as ICInventoryStockActualTotalCost
			, p.ICProductNo
			, p.ICProductName
			, p.ICProductDesc
			, s.ICStockNo
			, s.ICStockName
			, cal.ICInventoryStockCountItemProductSerialNo AS ProductSerieNo
		FROM #cal cal
		INNER JOIN dbo.ICProducts p ON p.ICProductID = cal.FK_ICProductID
		INNER JOIN dbo.ICStocks s ON s.ICStockID = cal.FK_ICStockID
	ELSE
		BEGIN
			SELECT *
			INTO #UnitCost
			FROM dbo.ICTransactions_GetProductUnitCostForInventoryStockCount(@FK_ICStockID, @ToDate)

			SELECT cal.FK_ICProductID
			, cal.FK_ICStockID
			, (cal.ICInventoryStockCountItemProductNo) ICInventoryStockCountItemPackageBarcode
			, cal.ICInventoryStockCountItemProductNo
			, cal.ICInventoryStockCountItemICProductSupplierNumber
			, cal.ICInventoryStockCountItemICProductDesc
			, cal.ICMeasureUnitName
			, ISNULL(SUM(cal.ICInventoryStockCountItemQuantity), 0.000) ICInventoryStockCountItemQuantity
			, ROUND(AVG(cal.ICInventoryStockUnitCostAVG), 2) ICInventoryStockUnitCostAVG
			, 0.00000 ICInventoryStockCountItemPackageQty
			, 0.00000 ICInventoryStockCountItemActualQuantity
			, ISNULL(SUM(cal.ICInventoryStockCountItemQuantity) - SUM(cal.ICInventoryStockCountItemActualQuantity), 0.000) AS ICInventoryStockCountItemQuantityVariance
			, ISNULL(u.UnitCost, 0.000) ICInventoryStockActualUnitCost
			, ROUND(ISNULL(u.UnitCost, 0.000) * ISNULL(SUM(cal.ICInventoryStockCountItemQuantity) - SUM(cal.ICInventoryStockCountItemActualQuantity), 0.000), 0) ICInventoryStockActualTotalCost
			, p.ICProductNo
			, p.ICProductName
			, p.ICProductDesc
			, s.ICStockNo
			, s.ICStockName
		FROM #cal cal
			INNER JOIN dbo.ICProducts p ON p.ICProductID = cal.FK_ICProductID
			INNER JOIN dbo.ICStocks s ON s.ICStockID = cal.FK_ICStockID
			LEFT JOIN #UnitCost u ON u.FK_ICProductID = cal.FK_ICProductID
		GROUP BY cal.FK_ICProductID
			, cal.FK_ICStockID
			, cal.ICInventoryStockCountItemProductNo
			, cal.ICInventoryStockCountItemICProductSupplierNumber
			, cal.ICInventoryStockCountItemICProductDesc
			, cal.ICMeasureUnitName
			, u.UnitCost
			, p.ICProductNo
			, p.ICProductName
			, p.ICProductDesc
			, s.ICStockNo
			, s.ICStockName
		ORDER BY cal.FK_ICProductID

			DROP TABLE #UnitCost
		END
	DROP TABLE #cal
	
	DROP TABLE #InventoryBalance 
END
GO

