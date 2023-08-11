SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		HoanVo
-- Create date: 17/11/2020
-- Description:	CheckDocumentMissICtransaction
-- =============================================
CREATE PROCEDURE [dbo].[ICTransactions_CheckDocumentMissICtransaction]
	@StockID	INT = NULL,
    @FromDate	DATETIME,
	@ToDate		DATETIME
WITH RECOMPILE 
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT r.ICReceiptNo AS ICTransactionReferenceNo
	FROM dbo.ICReceipts r
	WHERE	r.AAStatus = 'Alive'
	AND r.ICReceiptPostedStatus <> 'Posted'
	AND (@StockID IS NULL OR r.FK_ICStockID = @StockID)
	AND DATEDIFF(DD,@FromDate, r.ICReceiptDate)>=0
	AND DATEDIFF(DD, r.ICReceiptDate, @ToDate)>=0	

UNION ALL
	SELECT s.ICShipmentNo AS ICTransactionReferenceNo
	FROM dbo.ICShipments s
	WHERE	s.AAStatus = 'Alive'
	AND s.ICShipmentPostedStatus <> 'Posted'
	AND (@StockID IS NULL OR s.FK_ICStockID = @StockID)
	AND DATEDIFF(DD,@FromDate, s.ICShipmentDate)>=0
	AND DATEDIFF(DD, s.ICShipmentDate, @ToDate)>=0

UNION ALL	
	SELECT t.ICTransferNo AS ICTransactionReferenceNo
	FROM dbo.ICTransfers t
	WHERE t.AAStatus = 'Alive'
	AND t.ICTransferPostedStatus <> 'Posted'
	AND (@StockID IS NULL OR t.FK_ICFromStockID = @StockID OR t.FK_ICToStockID = @StockID)
	AND DATEDIFF(DD,@FromDate, t.ICTransferDate)>=0
	AND DATEDIFF(DD, t.ICTransferDate, @ToDate)>=0	

UNION ALL
	SELECT pc.ICProductConversionNo AS ICTransactionReferenceNo
	FROM dbo.ICProductConversions pc
	WHERE pc.AAStatus = 'Alive'
	AND pc.ICProductConversionPostedStatus <> 'Posted'
	AND (@StockID IS NULL OR pc.FK_ICFromStockID = @StockID OR pc.FK_ICToStockID = @StockID)
	AND DATEDIFF(DD,@FromDate, pc.ICProductConversionDate)>=0
	AND DATEDIFF(DD, pc.ICProductConversionDate, @ToDate)>=0	

UNION ALL
	SELECT sr.ARSaleReturnNo AS ICTransactionReferenceNo
	FROM dbo.ARSaleReturns sr
	WHERE sr.AAStatus = 'Alive'
	AND sr.ARSaleReturnPostedStatus <> 'Posted'
	AND (@StockID IS NULL OR sr.FK_ICStockID = @StockID)
	AND DATEDIFF(DD,@FromDate, sr.ARSaleReturnDate)>=0
	AND DATEDIFF(DD, sr.ARSaleReturnDate, @ToDate)>=0	
END
GO

