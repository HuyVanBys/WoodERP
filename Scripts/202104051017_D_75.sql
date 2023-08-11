DELETE dbo.ADConfigValues WHERE ADConfigKeyGroup = 'ReceiptItemReturnShippingType'

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'ReceiptItemReturnShippingTypeReplace', -- ADConfigKey - nvarchar(100)
    N'Replace', -- ADConfigKeyValue - nvarchar(100)
    N'Đổi hàng', -- ADConfigText - nvarchar(1000)
    N'Đổi hàng', -- ADConfigKeyDesc - nvarchar(500)
    N'ReceiptItemReturnShippingType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'ReceiptItemReturnShippingTypeReturn', -- ADConfigKey - nvarchar(100)
    N'Return', -- ADConfigKeyValue - nvarchar(100)
    N'Trả hàng', -- ADConfigText - nvarchar(1000)
    N'Trả hàng', -- ADConfigKeyDesc - nvarchar(500)
    N'ReceiptItemReturnShippingType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

UPDATE dbo.STModulePostings
SET STModulePostingSaleOrderFunction = 'IC_PostedReturnShippingItems'
WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'ReturnShipping')
