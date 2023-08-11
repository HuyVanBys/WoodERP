--SELECT f.STToolbarFunctionName,* FROM dbo.STToolbars s
--INNER JOIN dbo.STModules m ON m.STModuleID = s.STModuleID
--INNER JOIN dbo.STModuleDescriptions d ON d.STModuleID = m.STModuleID
--INNER JOIN dbo.STToolbarFunctions f ON f.STToolbarID = s.STToolbarID
--WHERE s.STToolbarTag = 'Delete'
--AND d.STModuleDescriptionDescription LIKE N'%Hàng bán trả lại%'

UPDATE s  SET s.AAStatus = 'Alive' FROM dbo.STToolbars s
INNER JOIN dbo.STModules m ON m.STModuleID = s.STModuleID
INNER JOIN dbo.STModuleDescriptions d ON d.STModuleID = m.STModuleID
WHERE s.STToolbarTag = 'Delete'
AND d.STModuleDescriptionDescription LIKE N'%Hàng bán trả lại%'

