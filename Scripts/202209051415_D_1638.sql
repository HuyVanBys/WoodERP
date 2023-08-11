UPDATE dbo.ADConfigValues
SET ADConfigKey = 'PurchaseOrderReceiptTypeOutSourcing'
,	ADConfigKeyValue = 'OutSourcing'
WHERE AAStatus = 'Alive'
AND ADConfigKey = 'PurchaseOrderReceiptTypeDichvuvagiacong'
AND ADConfigKeyGroup = 'PurchaseOrderReceiptType'

UPDATE dbo.APPurchaseOrders 
SET APPurchaseOrderReceiptTypeCombo = 'OutSourcing'
WHERE APPurchaseOrderReceiptTypeCombo = 'Dichvuvagiacong'

UPDATE ri
SET ri.ICReceiptItemQty2 = po.APPurchaseOrderItemProductUnitCost
,	ri.ICReceiptItemQty3 = ISNULL(xk.TongGiaVon, 0)
FROM dbo.ICReceipts r
INNER JOIN dbo.ICReceiptItems ri ON ri.AAStatus = 'Alive' AND ri.FK_ICReceiptID = r.ICReceiptID
INNER JOIN dbo.APPurchaseOrderItems po ON po.AAStatus = 'Alive' AND po.APPurchaseOrderItemID = ri.FK_APPurchaseOrderItemID
INNER JOIN dbo.APPurchaseOrders p ON p.AAStatus= 'Alive' AND po.FK_APPurchaseOrderID = p.APPurchaseOrderID
OUTER APPLY (SELECT SUM(si.ICShipmentItemTotalCost) AS TongGiaVon
							, ISNULL(ie.FK_ACAcountID, 0) AS FK_ACAcountID
						FROM dbo.ICShipmentItems si (NOLOCK)
							INNER JOIN dbo.ICShipments s (NOLOCK) ON s.AAStatus = 'Alive' AND s.ICShipmentID = si.FK_ICShipmentID
							LEFT JOIN dbo.ICImportAndExportReasons ie (NOLOCK) ON ie.AAStatus = 'Alive' AND ie.ICImportAndExportReasonID = s.FK_ICImportAndExportReasonID
						WHERE si.AAStatus = 'Alive'
							AND s.FK_APPurchaseOrderID = p.APPurchaseOrderID
							AND s.ICShipmentTypeCombo IN ('SemiProductShipment', 'DryLumber', 'MaterialShipment', 'RoundwoodShipment')
						GROUP BY ie.FK_ACAcountID) AS xk
WHERE r.AAStatus = 'Alive'
AND p.APPurchaseOrderReceiptTypeCombo IN ('WoodMDFOutSourcing', 'MechanicOutSourcing', 'OutSourcing')

