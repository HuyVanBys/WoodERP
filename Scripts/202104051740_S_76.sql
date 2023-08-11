SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		<Anh Nguyen>
-- Create date: <21/06/2016>
-- Description:	<Get Purchase Order Item For Checking Cancel Voucher Valid Qty>
-- =============================================
ALTER PROCEDURE [dbo].[ARPurchaseOrderItems_GetPurchaseOrderItemForCheckingCancelPurchaseValidQty] 
	@APPurchaseOrderItemID int,
	@APCancelPurchaseID int = null 
AS
BEGIN
	
	SET NOCOUNT ON;
     
     /* Số lượng có thể hủy = Số lượng - Số lượng đã đặt mua - Số lượng đã hủy  */
   
	SELECT *,
	 (
	 APPurchaseOrderItemProductExchangeQty -
	 ISNULL((SELECT SUM(rci.ICReceiptItemProductExchangeQty) FROM ICReceiptItems rci WHERE rci.AAStatus = 'Alive' AND rci.FK_APPurchaseOrderItemID = APPurchaseOrderItemID), 0) /* Số lượng đã đặt mua */
	-  ISNULL((SELECT SUM(cpoi.APCancelPurchaseOrderItemProductExchangeQty) FROM APCancelPurchaseOrderItems cpoi WHERE cpoi.AAStatus = 'Alive' AND cpoi.FK_APPurchaseOrderItemID = APPurchaseOrderItemID AND (@APCancelPurchaseID is null or cpoi.APCancelPurchaseOrderItemID not in (@APCancelPurchaseID) )), 0) /* Số lượng đã hủy */
	 ) / APPurchaseOrderItemProductFactor as APPurchaseOrderItemRemainedQty
	FROM APPurchaseOrderItems
	WHERE AAStatus ='Alive'
	AND APPurchaseOrderItemID = @APPurchaseOrderItemID
END

GO

