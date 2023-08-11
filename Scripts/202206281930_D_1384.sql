
UPDATE t  SET t.STToolbarCaption = N'Bản sao(F10)'
FROM dbo.STToolbars t LEFT JOIN dbo.STModules m ON m.STModuleID = t.STModuleID
LEFT JOIN dbo.STModuleDescriptions d ON d.STModuleID = m.STModuleID
WHERE STToolbarTag IN ('Duplicate')
AND t.AAStatus = 'Alive'