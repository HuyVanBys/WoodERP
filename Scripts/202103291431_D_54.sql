UPDATE mdd
SET mdd.STModuleDescriptionDescription = N'Ng�nh h�ng kh�c'
FROM dbo.STModules md INNER JOIN dbo.STModuleDescriptions mdd ON mdd.STModuleID = md.STModuleID
WHERE md.STModuleName = 'OtherProduct'