--SELECT * FROM dbo.ADConfigValues WHERE ADConfigKeyGroup = 'ProductType'

UPDATE ADConfigValues SET ADConfigText =N'Nguyên liệu khác' WHERE ADConfigKeyGroup = 'ProductType' AND ADConfigKeyValue = 'Material'
update dbo.MMMaterialDepartments SET MMMaterialIsUseWoodPlan = 1 WHERE ICProducType = 'Material'