update CSCompanys SET CSSourceSellingPriceMethod = 'MasterData'
GO
INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'SourceSellingPriceMethodMasterData', -- ADConfigKey - nvarchar(100)
    N'MasterData', -- ADConfigKeyValue - nvarchar(100)
    N'Lấy giá từ Master Data', -- ADConfigText - nvarchar(1000)
    N'', -- ADConfigKeyDesc - nvarchar(500)
    N'SourceSellingPriceMethod', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
    )
GO
INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'SourceSellingPriceMethodPriceSheet', -- ADConfigKey - nvarchar(100)
    N'PriceSheet', -- ADConfigKeyValue - nvarchar(100)
    N'Lấy giá từ Bảng giá', -- ADConfigText - nvarchar(1000)
    N'', -- ADConfigKeyDesc - nvarchar(500)
    N'SourceSellingPriceMethod', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
    )
GO


