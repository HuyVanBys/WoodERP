-----Đã chạy DB ERPWood_Test----
INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'ProductionNormCostFactorAllocationTypeUnitTime', -- ADConfigKey - nvarchar(100)
    N'UnitTime', -- ADConfigKeyValue - nvarchar(100)
    N'Unit Time', -- ADConfigText - nvarchar(1000)
    N'Unit Time', -- ADConfigKeyDesc - nvarchar(500)
    N'ProductionNormCostFactorAllocationType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'CalculatorProductionNormCost', -- STFieldFormatModuleName - varchar(50)
    'MMCalculatorProductionNormCostItems', -- STFieldFormatTableName - varchar(50)
    (SELECT TOP 1 STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPriceByCurrency'),  -- STFieldFormatGroupID - int
    'MMCalculatorProductionNormCostItemCostPrice'  -- STFieldFormatColumnName - varchar(100)
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'CalculatorProductionNormCost', -- STFieldFormatModuleName - varchar(50)
    'MMCalculatorProductionNormCostItems', -- STFieldFormatTableName - varchar(50)
    (SELECT TOP 1 STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPrice'),  -- STFieldFormatGroupID - int
    'MMCalculatorProductionNormCostItemCostPriceExchange'  -- STFieldFormatColumnName - varchar(100)
)
GO
