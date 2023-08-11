UPDATE dbo.STToolbars
SET STToolbarCaption = N'Phiếu xuất kho bán hàng'
WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'ShipmentSaleOrder')
AND STToolbarTag = 'PrintShipmentSaleOrderTV'
