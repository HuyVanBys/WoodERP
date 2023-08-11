
INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'PurchaseOrderPaymentTimeStatusInProcess', -- ADConfigKey - nvarchar(100)
    N'InProcess', -- ADConfigKeyValue - nvarchar(100)
    N'Đang thanh toán', -- ADConfigText - nvarchar(1000)
    N'PurchaseOrderPaymentTimeStatusInProcess', -- ADConfigKeyDesc - nvarchar(500)
    N'PurchaseOrderPaymentTimeStatus', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

UPDATE dbo.ADConfigValues
SET ADConfigText = N'Đã thanh toán'
WHERE ADConfigKeyGroup = 'PurchaseOrderPaymentTimeStatus'
AND ADConfigKeyValue = 'Paid'
