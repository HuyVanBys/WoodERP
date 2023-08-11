INSERT INTO dbo.ADConfigValues
(
    AAStatus,
    ADConfigKey,
    ADConfigKeyValue,
    ADConfigText,
    ADConfigKeyDesc,
    ADConfigKeyGroup,
    IsActive
)
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'ProductUsesInternalAndSale', -- ADConfigKey - nvarchar(100)
    N'InternalAndSale', -- ADConfigKeyValue - nvarchar(100)
    N'Sử dụng và bán', -- ADConfigText - nvarchar(1000)
    N'ProductUsesInternalAndSale', -- ADConfigKeyDesc - nvarchar(500)
    N'ProductUses', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
    )