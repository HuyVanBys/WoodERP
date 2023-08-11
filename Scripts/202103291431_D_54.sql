UPDATE mdd
SET mdd.STModuleDescriptionDescription = N'Ngành hàng khác'
FROM dbo.STModules md INNER JOIN dbo.STModuleDescriptions mdd ON mdd.STModuleID = md.STModuleID
WHERE md.STModuleName = 'OtherProduct'