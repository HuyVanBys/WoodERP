INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'CustomerTypeAccountConfigSaleTypeNational', -- ADConfigKey - nvarchar(100)
    N'National', -- ADConfigKeyValue - nvarchar(100)
    N'Nội địa', -- ADConfigText - nvarchar(1000)
    N'CustomerTypeAccountConfigSaleTypeNational', -- ADConfigKeyDesc - nvarchar(500)
    N'CustomerTypeAccountConfigSaleType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
    )
INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'CustomerTypeAccountConfigSaleTypeInternational', -- ADConfigKey - nvarchar(100)
    N'International', -- ADConfigKeyValue - nvarchar(100)
    N'Quốc tế', -- ADConfigText - nvarchar(1000)
    N'CustomerTypeAccountConfigSaleTypeInternational', -- ADConfigKeyDesc - nvarchar(500)
    N'CustomerTypeAccountConfigSaleType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
    )

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARCustomerTypeAccountConfigSaleType',   -- AAColumnAliasName - varchar(255)
    N'Hình thức bán hàng',  -- AAColumnAliasCaption - nvarchar(255)
    'ARCustomerTypeAccountConfigs',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    NULL  -- AAColumnAliasIsSaveHistory - bit
    )

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'CompanyBankSaleTypeNational', -- ADConfigKey - nvarchar(100)
    N'National', -- ADConfigKeyValue - nvarchar(100)
    N'Nội địa', -- ADConfigText - nvarchar(1000)
    N'CompanyBankSaleTypeNational', -- ADConfigKeyDesc - nvarchar(500)
    N'CompanyBankSaleType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
    )
INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'CompanyBankSaleTypeInternational', -- ADConfigKey - nvarchar(100)
    N'International', -- ADConfigKeyValue - nvarchar(100)
    N'Quốc tế', -- ADConfigText - nvarchar(1000)
    N'CompanyBankSaleTypeInternational', -- ADConfigKeyDesc - nvarchar(500)
    N'CompanyBankSaleType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
    )

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'CSCompanyBankSaleType',   -- AAColumnAliasName - varchar(255)
    N'Hình thức bán hàng',  -- AAColumnAliasCaption - nvarchar(255)
    'CSCompanyBanks',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    NULL  -- AAColumnAliasIsSaveHistory - bit
    )

