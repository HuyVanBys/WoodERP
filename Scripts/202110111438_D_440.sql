INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'PurchaseOrderTypeOutSourcingService', -- ADConfigKey - nvarchar(100)
    N'OutSourcingService', -- ADConfigKeyValue - nvarchar(100)
    N'Dịch vụ gia công', -- ADConfigText - nvarchar(1000)
    N'PurchaseOrderTypeOutSourcingService', -- ADConfigKeyDesc - nvarchar(500)
    N'PurchaseOrderType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
    )