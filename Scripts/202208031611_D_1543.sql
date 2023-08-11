CREATE TABLE #Temp (
	AAColumnAliasID INT,
	AAColumnAliasName NVARCHAR(200),
	AAColumnAliasCaption NVARCHAR(200)
	)
INSERT INTO #Temp
SELECT AAColumnAliasID,
		AAColumnAliasName,
		AAColumnAliasCaption
FROM  dbo.AAColumnAlias
WHERE AATableName = 'ICProductItemMaterials'
AND AAStatus = 'Alive'

UPDATE dbo.AAColumnAlias
SET AAColumnAliasName = 'ICProductItemMaterialHeigth', AAColumnAliasCaption = N'Dày'
WHERE AAColumnAliasID = (SELECT AAColumnAliasID FROM  #Temp WHERE AAColumnAliasName = 'ICProductItemMaterialLength')

UPDATE dbo.AAColumnAlias
SET AAColumnAliasName = 'ICProductItemMaterialLength', AAColumnAliasCaption = N'Dài'
WHERE AAColumnAliasID = (SELECT AAColumnAliasID FROM  #Temp WHERE AAColumnAliasName = 'ICProductItemMaterialHeigth')

DROP TABLE #Temp