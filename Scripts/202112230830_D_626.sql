DELETE dbo.ADConfigValues WHERE ADConfigKeyGroup = 'SaleOrderPaymentTimeStatus'

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'SaleOrderPaymentTimeStatusNew', -- ADConfigKey - nvarchar(100)
    N'New', -- ADConfigKeyValue - nvarchar(100)
    N'Tạo mới', -- ADConfigText - nvarchar(1000)
    N'SaleOrderPaymentTimeStatusNew', -- ADConfigKeyDesc - nvarchar(500)
    N'SaleOrderPaymentTimeStatus', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'SaleOrderPaymentTimeStatusInProcess', -- ADConfigKey - nvarchar(100)
    N'InProcess', -- ADConfigKeyValue - nvarchar(100)
    N'Đang thanh toán', -- ADConfigText - nvarchar(1000)
    N'SaleOrderPaymentTimeStatusInProcess', -- ADConfigKeyDesc - nvarchar(500)
    N'SaleOrderPaymentTimeStatus', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'SaleOrderPaymentTimeStatusCanceled', -- ADConfigKey - nvarchar(100)
    N'Canceled', -- ADConfigKeyValue - nvarchar(100)
    N'Đã hủy', -- ADConfigText - nvarchar(1000)
    N'SaleOrderPaymentTimeStatusCanceled', -- ADConfigKeyDesc - nvarchar(500)
    N'SaleOrderPaymentTimeStatus', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'SaleOrderPaymentTimeStatusPaid', -- ADConfigKey - nvarchar(100)
    N'Paid', -- ADConfigKeyValue - nvarchar(100)
    N'Đã thanh toán', -- ADConfigText - nvarchar(1000)
    N'SaleOrderPaymentTimeStatusPaid', -- ADConfigKeyDesc - nvarchar(500)
    N'SaleOrderPaymentTimeStatus', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARSaleOrderPaymentTimeCanceledAmount',   -- AAColumnAliasName - varchar(255)
    N'Số tiền bị hủy',  -- AAColumnAliasCaption - nvarchar(255)
    'ARSaleOrderPaymentTimes',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'SaleOrder', -- STFieldFormatModuleName - varchar(50)
    'ARSaleOrderPaymentTimes', -- STFieldFormatTableName - varchar(50)
    (SELECT TOP 1 STFieldFormatGroupID FROM STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),  -- STFieldFormatGroupID - int
    'ARSaleOrderPaymentTimeCanceledAmount'  -- STFieldFormatColumnName - varchar(100)
)
GO

