-- Đề nghị thanh toán trực tiếp
UPDATE STToolbars
SET STToolbarDesc = N'Đề nghị thanh toán trực tiếp', STToolbarCaption = N'Đề nghị thanh toán trực tiếp'
WHERE STToolbarTag = 'AdvanceRefundDirect001' AND STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'AdvanceRefundDirect')
-- Tạm ứng
UPDATE STToolbars
SET STToolbarDesc = N'Tạm ứng', STToolbarCaption = N'Tạm ứng'
WHERE STToolbarTag = 'PrintAdvanceRequest001' AND STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'AdvanceRequest')

-- Giảm tài sản
UPDATE STToolbars
SET STToolbarDesc = N'Giảm tài sản', STToolbarCaption = N'Giảm tài sản'
WHERE STToolbarTag = 'PrintAssetShipment001' AND STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'AssetShipment')

-- Điều chuyển tài sản
UPDATE STToolbars
SET STToolbarDesc = N'Điều chuyển tài sản', STToolbarCaption = N'Điều chuyển tài sản'
WHERE STToolbarTag = 'PrintAssetTransfer001' AND STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'AssetTransfer')

-- Xuất kho CCDC
UPDATE STToolbars
SET STToolbarDesc = N'Xuất kho CCDC', STToolbarCaption = N'Xuất kho CCDC'
WHERE STToolbarTag = 'PrintEquipmentShipment001' AND STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'EquipmentShipment')

-- Ghi giảm CCDC
UPDATE STToolbars
SET STToolbarDesc = N'Ghi giảm CCDC', STToolbarCaption = N'Ghi giảm CCDC'
WHERE STToolbarTag = 'PrintEquipmentDecreasing001' AND STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'EquipmentDecreasing')

-- Điều chuyển CCDC
UPDATE STToolbars
SET STToolbarDesc = N'Điều chuyển CCDC', STToolbarCaption = N'Điều chuyển CCDC'
WHERE STToolbarTag = 'PrintEquipmentTransfer001' AND STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'EquipmentTransfer')

-- Nghiệp vụ tổng hợp
UPDATE STToolbars
SET STToolbarDesc = N'Nghiệp vụ tổng hợp', STToolbarCaption = N'Nghiệp vụ tổng hợp'
WHERE STToolbarTag = 'PR008' AND STModuleID = (SELECT STModuleID FROM  STModules WHERE STModuleName = 'GeneralAccounting')