UPDATE dbo.STModuleDescriptions
SET STModuleDescriptionDescription = N'Tổng hợp nhập xuất tồn'
WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'InventoryStatistics')
