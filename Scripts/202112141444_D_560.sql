INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'SupplierPaymentBankFeeTypeFeeIn', -- ADConfigKey - nvarchar(100)
    N'FeeIn', -- ADConfigKeyValue - nvarchar(100)
    N'Phí trong', -- ADConfigText - nvarchar(1000)
    N'SupplierPaymentBankFeeTypeFeeIn', -- ADConfigKeyDesc - nvarchar(500)
    N'SupplierPaymentBankFeeType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'SupplierPaymentBankFeeTypeFeeOut', -- ADConfigKey - nvarchar(100)
    N'FeeOut', -- ADConfigKeyValue - nvarchar(100)
    N'Phí ngoài', -- ADConfigText - nvarchar(1000)
    N'SupplierPaymentBankFeeTypeFeeOut', -- ADConfigKeyDesc - nvarchar(500)
    N'SupplierPaymentBankFeeType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO