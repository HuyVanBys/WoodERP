SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		<NNGiang>
-- Create date: <08-06-2016>
-- Description:	<Get Item For Cancel Purchase Oder>
-- =============================================
ALTER PROCEDURE [dbo].[APPurchaseOrderItems_GetListItemForCancel]
AS
BEGIN
	SET NOCOUNT ON;
	Select s.APPurchaseOrderNo
			,(k.APPurchaseOrderItemProductExchangeQty 
			- isnull((select  sum(rci.ICReceiptItemProductExchangeQty)
				from ICReceipts rc
					inner join ICReceiptItems rci on rc.ICReceiptID=rci.FK_ICReceiptID
				where rc.AAStatus='Alive'and rci.AAStatus='Alive'
					and rci.FK_APInvoiceInItemID = 0
					and rci.FK_APPurchaseOrderItemID=k.APPurchaseOrderItemID),0)
			- isnull((select SUM(cpoi.APCancelPurchaseOrderItemProductExchangeQty)
					from APCancelPurchaseOrders cpo
						inner join APCancelPurchaseOrderitems cpoi on cpo.APCancelPurchaseOrderID=cpoi.FK_APCancelPurchaseOrderID
					where cpo.AAStatus='Alive' and cpoi.AAStatus='Alive'
						and cpoi.FK_APPurchaseOrderItemID = k.APPurchaseOrderItemID),0)
			- isnull((select SUM(isnull(ii2.APInvoiceInItemProductExchangeQty,0)) 
				FROM APInvoiceInItems ii2 
				WHERE ii2.AAStatus ='Alive'
					AND ii2.FK_APPurchaseOrderItemID = k.APPurchaseOrderItemID
					AND ii2.FK_ICReceiptItemID = 0 ),0)) / k.APPurchaseOrderItemProductFactor AS APPurchaseOrderItemProductQty
			,k.*
			,vo.ACObjectName
			,s.FK_APPurchaseContractID
			,s.FK_PMProjectID
	from APPurchaseOrderItems k
		inner join APPurchaseOrders s on s.APPurchaseOrderID = k.FK_APPurchaseOrderID
		--left join APInvoiceInItems iii on iii.FK_APPurchaseOrderItemID = k.APPurchaseOrderItemID
		left join V_ACObjects vo on vo.ACObjectID = s.FK_ACObjectID
						and  vo.ACObjectType = s.APObjectType
	where 
	s.AAStatus ='Alive'
	and k.AAStatus='Alive'
	and APPurchaseOrderStatus in ('Approved','Incompleted')
	and	(k.APPurchaseOrderItemProductExchangeQty 
			- isnull((select  sum(rci.ICReceiptItemProductExchangeQty)
				from ICReceipts rc
					inner join ICReceiptItems rci on rc.ICReceiptID=rci.FK_ICReceiptID
				where rc.AAStatus='Alive'and rci.AAStatus='Alive'
					and rci.FK_APInvoiceInItemID = 0
					and rci.FK_APPurchaseOrderItemID=k.APPurchaseOrderItemID),0)
			- isnull((select SUM(cpoi.APCancelPurchaseOrderItemProductExchangeQty)
					from APCancelPurchaseOrders cpo
						inner join APCancelPurchaseOrderitems cpoi on cpo.APCancelPurchaseOrderID=cpoi.FK_APCancelPurchaseOrderID
					where cpo.AAStatus='Alive' and cpoi.AAStatus='Alive'
						and cpoi.FK_APPurchaseOrderItemID = k.APPurchaseOrderItemID),0)
			- isnull((select SUM(isnull(ii2.APInvoiceInItemProductExchangeQty,0)) 
				from APInvoiceInItems ii2 
				where ii2.AAStatus ='Alive'
					and ii2.FK_APPurchaseOrderItemID = k.APPurchaseOrderItemID
					and ii2.FK_ICReceiptItemID = 0 ),0)) > 0
END

GO

