UPDATE dbo.ADConfigValues
SET AAStatus = 'Delete'
WHERE ADConfigKeyValue IN ('Process','Budget') AND ADConfigKeyGroup = 'ProductionNormCostFactorSourceData'

UPDATE dbo.AAColumnAlias
SET AAStatus = 'Delete'
WHERE AATableName = 'MMProductionNormCostFactors' AND AAColumnAliasName IN ('MMProductionNormCostFactorUpdatingType', 'MMProductionNormCostFactorAllocation', 'FK_MMProductionCostFactorID', 'MMProductionNormCostFactorPriceType', 'MMPriceType')
UPDATE dbo.AAColumnAlias SET AAStatus = 'Delete' WHERE AATableName = 'MMProductionNormFactors' AND AAColumnAliasName IN ('MMProductionNormFactorStatus','MMProductionNormFactorNumber')

UPDATE dbo.AAColumnAlias SET AAStatus = 'Delete' WHERE AATableName = 'MMProductionNormCostFactors' AND AAColumnAliasName IN ('FK_MMOperationID','MMProductionNormCostFactorNo','MMProductionNormCostFactorName'
, 'MMProductionNormCostFactorFormula', 'FK_ICMeasureUnitID', 'MMProductionNormCostFactorIsSetCostPrice')

INSERT INTO dbo.ADConfigValues
SELECT   
	'Delete',  -- AAStatus - varchar(10)
    N'ProductionNormCostFactorCalculatorPurchaseReceipt', -- ADConfigKey - nvarchar(100)
    N'PurchaseReceipt', -- ADConfigKeyValue - nvarchar(100)
    N'Nhập kho mua hàng gần nhất', -- ADConfigText - nvarchar(1000)
    N'Nhập kho mua hàng gần nhất', -- ADConfigKeyDesc - nvarchar(500)
    N'ProductionNormCostFactorCalculator', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
    
INSERT INTO dbo.ADConfigValues
SELECT	   
	'Alive',  -- AAStatus - varchar(10)
    N'ProductionNormCostFactorCalculatorSupplierPriceSheet', -- ADConfigKey - nvarchar(100)
    N'SupplierPriceSheet', -- ADConfigKeyValue - nvarchar(100)
    N'Bảng giá nhà cung cấp', -- ADConfigText - nvarchar(1000)
    N'Bảng giá nhà cung cấp', -- ADConfigKeyDesc - nvarchar(500)
    N'ProductionNormCostFactorCalculator', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
 
 INSERT INTO dbo.ADConfigValues
SELECT	   
	'Delete',  -- AAStatus - varchar(10)
    N'ProductionNormCostFactorCalculatorAverageStockPrice', -- ADConfigKey - nvarchar(100)
    N'AverageStockPrice', -- ADConfigKeyValue - nvarchar(100)
    N'Trung bình giá tồn kho', -- ADConfigText - nvarchar(1000)
    N'Trung bình giá tồn kho', -- ADConfigKeyDesc - nvarchar(500)
    N'ProductionNormCostFactorCalculator', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
   
UPDATE ADConfigValues SET ADConfigKeyValue = 'Difficulty', ADConfigText = N'Độ phức tạp', ADConfigKey = 'ProductionNormCostFactorAllocationTypeDifficulty', ADConfigKeyDesc = N'Độ phức tạp'
WHERE ADConfigKeyGroup = 'ProductionNormCostFactorAllocationType' AND ADConfigKeyValue = 'Factor'