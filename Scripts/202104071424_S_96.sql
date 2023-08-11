SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		<Hoan Vo>
-- Create date: <27/09/2018>
-- Description:	<Get Receipt Item For Return Supplier>
-- =============================================
ALTER PROCEDURE [dbo].[ICReceiptItems_GetReceiptItemForReturnSupplier]
	@ObjectID  INT = NULL,
	@ObjectType nvarchar(50) = NULL,
	@FromDate DATETIME = NULL,
	@ToDate DATETIME = NULL

AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT
	    ICReceiptItemID,
		ri.ICReceiptItemProductQty - ISNULL((SELECT 
												SUM(APReturnSupplierItemProductQty) 
											 FROM dbo.APReturnSupplierItems 
											 WHERE AAStatus = 'Alive' and FK_ICReciptItemID = ri.ICReceiptItemID),0) AS ICReceiptItemProductQty
		, ri.ICReceiptItemProductQty 
		  - ISNULL((SELECT SUM(APReturnSupplierItemProductQty) 
				   FROM dbo.APReturnSupplierItems 
				   WHERE AAStatus = 'Alive' and FK_ICReciptItemID = ri.ICReceiptItemID),0)
		  - ISNULL((select SUM(APReturnSupplierItemProductQty) from APReturnSupplierItems where FK_ICReciptItemID = ri.ICReceiptItemID and AAStatus = 'Alive'),0) AS APInvoiceInItemReceiptedQty
		, r.ICReceiptTypeCombo
		, r.ICReceiptNo
		, r.ICReceiptPackNo
		, r.ICReceiptReceiptType
		, vo.ACObjectName
		, (SELECT ICStockName FROM dbo.ICStocks WHERE ICStockID = ri.FK_ICStockID) AS ICStockName
		, CASE WHEN (ri.FK_APInvoiceInItemID > 0)
			THEN ri.ICReceiptItemProductTaxPercent
			ELSE ISNULL(ii.APInvoiceInItemProductTaxPercent, 0)
			END AS ICReceiptItemProductTaxPercent
		, CASE WHEN (ri.FK_APInvoiceInItemID > 0)
			THEN ri.ICReceiptItemTaxAmount
			ELSE ISNULL(ii.APInvoiceInItemTaxAmount, 0)
			END AS ICReceiptItemTaxAmount
		, ri.*
	FROM dbo.ICReceiptItems ri WITH (NOLOCK)
		INNER JOIN dbo.ICReceipts r WITH (NOLOCK) ON r.ICReceiptID = ri.FK_ICReceiptID
		LEFT JOIN dbo.APInvoiceInItems ii WITH (NOLOCK) ON ii.AAStatus = 'Alive' AND ii.FK_ICReceiptItemID = ri.ICReceiptItemID
		LEFT JOIN  V_ACObjects	vo ON (vo.ACObjectID = r.FK_ACAssObjectID and vo.ACObjectType = r.ICAssObjectType)		
	WHERE ri.AAStatus = 'Alive'
		AND r.AAStatus ='Alive'
		AND r.ICReceiptTypeCombo ='PurchaseReceipt'
		AND (@ObjectID is null or @ObjectID = r.FK_ACAssObjectID)
		and	(@ObjectType is null or @ObjectType = r.ICAssObjectType)
		AND	(@FromDate IS NULL OR DATEDIFF(DD, @FromDate, r.ICReceiptDate) >= 0)
		AND	(@ToDate IS NULL OR DATEDIFF(DD, r.ICReceiptDate, @ToDate) >=0)
		AND ri.ICReceiptItemProductQty - ISNULL((SELECT SUM(APReturnSupplierItemProductQty) 
											 FROM dbo.APReturnSupplierItems 
											 WHERE AAStatus = 'Alive' and FK_ICReciptItemID = ri.ICReceiptItemID),0) > 0	
		AND NOT EXISTS (SELECT 1 
						FROM dbo.APReturnSupplierItems rsi WITH (NOLOCK)
							INNER JOIN dbo.APReturnSuppliers rs WITH (NOLOCK) ON rs.AAStatus = 'Alive' AND rs.APReturnSupplierID = rsi.FK_APReturnSupplierID
						WHERE rsi.AAStatus = 'Alive'
							AND rs.APReturnSupplierStatusCombo = 'New'
							AND rsi.FK_ICReciptItemID = ri.ICReceiptItemID)
END

GO

