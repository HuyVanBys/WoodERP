UPDATE tb
SET tb.STToolbarCaption = N'Từ Đề nghị xuất kho'
FROM dbo.STToolbars tb
WHERE tb.STModuleID = (SELECT md.STModuleID FROM  dbo.STModules md WHERE md.STModuleName = 'ShipmentSaleOrder')
AND tb.STToolbarTag = 'NewDelivery'