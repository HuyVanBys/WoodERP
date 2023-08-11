DELETE dbo.MMCalculatorProductionNormCostItems
DELETE dbo.MMCalculatorProductionNormCosts

DBCC CHECKIDENT('MMCalculatorProductionNormCosts', RESEED, 0)
DBCC CHECKIDENT('MMCalculatorProductionNormCostItems', RESEED, 0)

IF (SELECT COUNT(1) FROM dbo.MMCalculatorProductionNormCosts WHERE MMCalculatorProductionNormCostID = 0) = 0
BEGIN
	SET IDENTITY_INSERT MMCalculatorProductionNormCosts ON 
	INSERT INTO [dbo].[MMCalculatorProductionNormCosts](
		[MMCalculatorProductionNormCostID],
		[AAStatus],
		[AACreatedUser],
		[AACreatedDate],
		[AAUpdatedUser],
		[AAUpdatedDate],
		[FK_ICProductGroupID],
		[FK_ICProductID],
		[FK_MMProductionNormID],
		[FK_MMProcessID],
		[MMCalculatorProductionNormCostNo],
		[MMCalculatorProductionNormCostDate],
		[MMCalculatorProductionNormCostType],
		[MMCalculatorProductionNormCostStatus],
		[MMCalculatorProductionNormCostEffectiveDate],
		[MMCalculatorProductionNormCostCostPrice],
		[FK_GECurrencyID],
		[MMCalculatorProductionNormCostExchangeRate],
		[FK_MMBatchProductID],
		[MMPriceType],
		[ARCustomerType],
		[FK_ARCustomerID],
		[MMCalculatorProductionNormCostBasicPrice],
		[MMCalculatorProductionNormCostNetPrice],
		[MMCalculatorProductionNormCostGrossPrice],
		[MMCalculatorProductionNormCostSOQPrice]
	) VALUES ( 
		0,
		'',
		'',
		NULL,
		'',
		NULL,
		0,
		0,
		0,
		0,
		'',
		NULL,
		'',
		'',
		NULL,
		0.0,
		0,
		0.0,
		0,
		'',
		'',
		0,
		0.0,
		0.0,
		0.0,
		0.0
	)
	SET IDENTITY_INSERT MMCalculatorProductionNormCosts OFF 
END


IF (SELECT COUNT(1) FROM dbo.MMCalculatorProductionNormCostItems WHERE MMCalculatorProductionNormCostItemID = 0) = 0
BEGIN
	SET IDENTITY_INSERT MMCalculatorProductionNormCostItems ON 
	INSERT INTO [dbo].[MMCalculatorProductionNormCostItems](
		[MMCalculatorProductionNormCostItemID],
		[AAStatus],
		[AACreatedUser],
		[AACreatedDate],
		[AAUpdatedUser],
		[AAUpdatedDate],
		[MMCalculatorProductionNormCostItemNumber],
		[MMCalculatorProductionNormCostItemNo],
		[MMCalculatorProductionNormCostItemName],
		[MMCalculatorProductionNormCostItemCostPrice],
		[MMCalculatorProductionNormCostItemCostPriceExchange],
		[FK_MMCalculatorProductionNormCostID],
		[MMProductionNormCostFactorProductGroup]
	) VALUES ( 
		0,
		'',
		'',
		NULL,
		'',
		NULL,
		0,
		'',
		'',
		0.0,
		0.0,
		0,
		''
	)
	SET IDENTITY_INSERT MMCalculatorProductionNormCostItems OFF 
END
