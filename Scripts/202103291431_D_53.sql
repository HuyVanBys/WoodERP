UPDATE mdd
SET mdd.STModuleDescriptionDescription = N'Ng�nh h�ng - Nh�m h�ng'
FROM dbo.STModules md INNER JOIN dbo.STModuleDescriptions mdd ON mdd.STModuleID = md.STModuleID
WHERE md.STModuleName = 'Department'