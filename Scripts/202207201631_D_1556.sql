update dbo.STFieldFormats SET STFieldFormatGroupID = (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPriceByCurrency') WHERE STFieldFormatModuleName = 'PurchaseOrder' 
AND STFieldFormatTableName = 'APPurchaseOrderItems' AND STFieldFormatColumnName IN ('APPurchaseOrderItemProductUnitCost','APPurchaseOrderItemDiscountAmount','APPurchaseOrderItemTaxAmount','APPurchaseOrderItemTotalCost')
GO
update dbo.STFieldFormats SET STFieldFormatGroupID = (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPriceByCurrency') WHERE STFieldFormatModuleName = 'PurchaseReceipt' 
AND STFieldFormatTableName = 'ICReceiptItems' AND STFieldFormatColumnName IN ('ICReceiptItemProductUnitCost','ICReceiptItemDiscountAmount','ICReceiptItemTaxAmount','ICReceiptItemTotalCost')
GO
update dbo.STFieldFormats SET STFieldFormatGroupID = (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPriceByCurrency')
WHERE STFieldFormatModuleName = 'BillOfLading' AND STFieldFormatTableName = 'APBillOfLadingItems' 
AND STFieldFormatColumnName IN ('APBillOfLadingItemProductUnitCost','APBillOfLadingItemProductUnitCostExchange','APBillOfLadingItemTotalCost','APBillOfLadingItemTotalCostExchange'
,'APBillOfLadingItemImportTaxAmount','APBillOfLadingItemConsumptionTaxAmount','APBillOfLadingItemVATTaxAmount','APBillOfLadingItemEnviromentTaxAmount','APBillOfLadingItemTotalTaxAmount')
