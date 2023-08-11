INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'PaymentMethodCashOrBankTransfer', -- ADConfigKey - nvarchar(100)
    N'CashOrBankTransfer', -- ADConfigKeyValue - nvarchar(100)
    N'Tiền mặt/ Chuyển khoản', -- ADConfigText - nvarchar(1000)
    N'PaymentMethodCashOrBankTransfer', -- ADConfigKeyDesc - nvarchar(500)
    N'PaymentMethod', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.ACEInvoicePaymentMethods
VALUES
(   N'Admin',       -- AACreatedUser - nvarchar(50)
    GETDATE(), -- AACreatedDate - datetime
    N'',       -- AAUpdatedUser - nvarchar(50)
    GETDATE(), -- AAUpdatedDate - datetime
    'Alive',        -- AAStatus - varchar(50)
    N'CashOrBankTransfer',       -- ACEInvoicePaymentMethodNo - nvarchar(100)
    N'CashTransfer',       -- ACEInvoicePaymentMethodName - nvarchar(512)
    N'Tiền mặt/ Chuyển khoản'        -- ACEInvoiceSytemPaymentMethodName - nvarchar(512)
)
GO