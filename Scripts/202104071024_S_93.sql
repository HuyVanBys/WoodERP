SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		
-- Create date: 03/12/2018
-- Description:	ICReceiptItems_GetReceiptItemsForInvoicingByRef
-- =============================================
ALTER PROCEDURE [dbo].[ICReceiptItems_GetReceiptItemsForInvoicingByRef]
	@ReceiptRef NVARCHAR(512) = null
AS
BEGIN	
	SET NOCOUNT ON;

    select	
			poi2.APPurchaseOrderItemPackagedQty , poi2.APPurchaseOrderItemProductQty ,
			ISNull((SELECT TOP 1 ADConfigText
			 from ADConfigValues 
			 where ADConfigKeyGroup ='PurchaseOrderReceiptType' 
			 and ADConfigKeyValue = po.ICReceiptReceiptType),N'Không xác định')as ICReceiptPurchaseTypeCombo,
			poi.ICReceiptItemProductQty - (ISNULL((select SUM(APReturnSupplierItemProductQty) from APReturnSupplierItems where AAStatus = 'Alive' and FK_ICReciptItemID = poi.ICReceiptItemID),0)) as ICReceiptItemProductQty,
			poi.*,
			po.*,
			(select APSupplierName from APSuppliers where APSupplierID = po.FK_APSupplierID) as APSupplierName,
			isnull((select SUM (APInvoiceInItemProductQty) from APInvoiceInItems 
			where AAStatus = 'Alive' and FK_ICReceiptItemID = poi.ICReceiptItemID),0) as ICReceiptItemInvoiceInItemQty
	from	[dbo].[ICReceiptItems] poi 
		INNER JOIN [dbo].[ICReceipts] po on poi.FK_ICReceiptID = po.ICReceiptID 
		INNER JOIN APPurchaseOrders apo on po.FK_APPurchaseOrderID = apo.APPurchaseOrderID 
		LEFT JOIN [dbo].[APPurchaseOrderItems] poi2 on poi2.APPurchaseOrderItemID = poi.FK_APPurchaseOrderItemID 
			and poi2.APPurchaseOrderItemPackagedQty < poi2.APPurchaseOrderItemProductQty
			and	(po.ICReceiptReceiptType = 'Product' or po.ICReceiptReceiptType is null)
			and		poi2.AAStatus = 'Alive'	 
	where	po.AAStatus = 'Alive'
	and		po.ICReceiptStatus = 'Complete'
	AND		po.ICReceiptTypeCombo IN ('OutsourcingReceipt' , 'PurchaseReceipt')
	AND		poi.ICReceiptItemProductType NOT IN ('Work','Service')
	and		poi.AAStatus = 'Alive'
	and		( po.FK_APPurchaseOrderID = 0 or (Select APPurchaseOrderChannel from APPurchaseOrders where APPurchaseOrderID = po.FK_APPurchaseOrderID) = 'HinterLand')
	and		( poi.FK_APInvoiceInItemID = 0) 
	AND		poi.FK_ICReceiptID IN (SELECT * FROM dbo.FSplitStringByCharater(@ReceiptRef,','))
	and		poi.ICReceiptItemProductQty 
		    - ISNULL((select SUM(APReturnSupplierItemProductQty) from APReturnSupplierItems where AAStatus = 'Alive' and FK_ICReciptItemID = poi.ICReceiptItemID),0)
			- isnull((select SUM (APInvoiceInItemProductQty) from APInvoiceInItems 
			where AAStatus = 'Alive' and FK_ICReceiptItemID = poi.ICReceiptItemID),0) > 0
	
	
		
END




GO

