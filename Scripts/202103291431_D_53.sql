UPDATE mdd
SET mdd.STModuleDescriptionDescription = N'Ngành hàng - Nhóm hàng'
FROM dbo.STModules md INNER JOIN dbo.STModuleDescriptions mdd ON mdd.STModuleID = md.STModuleID
WHERE md.STModuleName = 'Department'