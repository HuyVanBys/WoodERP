
UPDATE dbo.STToolbars
SET AAStatus = 'Delete'
WHERE STModuleID IN (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'MaterialReceipt')
AND STToolbarTag IN ('NewFormHardware','NewFromIngredientPaint','NewFromIngredientPackaging','NewFromOther','NewFromLCP1'
,'NewFormHardware1', 'NewFromIngredientPaint1', 'NewFromIngredientPackaging1', 'NewFromOther1', 'NewFromLCP')

