SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		<Loc Truong>
-- Create date: <21/06/2016>
-- Description:	<Get Sale Order Item For Checking Cancel Voucher Valid Qty>
-- =============================================
ALTER PROCEDURE [dbo].[ARSaleOrderItems_GetSaleOrderItemForCheckingCancelVoucherValidQty] 
	@ARSaleOrderItemID int,
	@ARCancelVoucherID int = null 
AS
BEGIN
	
	SET NOCOUNT ON;
     
     /* Số lượng có thể hủy = Số lượng - Số lượng đã đề nghị - Số lượng đã hủy  */
   
	SELECT *,
	 (
	 ARSaleOrderItemProductQty -
	 ISNULL((SELECT SUM(dpi.ARDeliveryPlanItemProductQty  - dpi.ARDeliveryPlanItemCancelQty) 
	         FROM dbo.ARDeliveryPlanItems dpi 
				INNER JOIN dbo.ARDeliveryPlans dp ON dp.AAStatus = 'Alive' AND dp.ARDeliveryPlanID = dpi.FK_ARDeliveryPlanID
	         WHERE dpi.AAStatus = 'Alive' 
				AND dp.ARDeliveryPlanStatus <> 'Canceled'
				AND dpi.FK_ARSaleOrderItemID = ARSaleOrderItemID), 0) /* Số lượng đã đề nghị */
	 - ISNULL((SELECT SUM(acli.ARContainerLoaderItemProductQty)
				FROM ARContainerLoaders acl 
				INNER join ARContainerLoaderItems acli ON acl.ARContainerLoaderID = acli.FK_ARContainerLoaderID
														AND acl.AAStatus ='Alive'
														AND acli.AAStatus ='Alive'
														AND acli.FK_ARSaleOrderItemID = ARSaleOrderItemID),0)
	-  ISNULL((SELECT SUM(ARCancelVoucherItemProductQty) 
	           FROM ARCancelVoucherItems cvi 
	           WHERE cvi.AAStatus = 'Alive' 
					AND cvi.FK_ARSaleOrderItemID = ARSaleOrderItemID 
					AND (@ARCancelVoucherID is null or cvi.ARCancelVoucherItemID not in (@ARCancelVoucherID) )), 0) /* Số lượng đã hủy */
	 ) AS ARSaleOrderItemRemainedQty
	FROM ARSaleOrderItems
	WHERE AAStatus ='Alive'
	AND ARSaleOrderItemID = @ARSaleOrderItemID
END

GO

