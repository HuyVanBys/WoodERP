DELETE dbo.AAColumnAlias 
WHERE AATableName = 'ARInvoiceItems' 
AND AAColumnAliasName = 'ARInvoiceItemProductSupplierNo'

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARInvoiceItemProductSupplierNo',   -- AAColumnAliasName - varchar(255)
    N' Mã SP đối tác',  -- AAColumnAliasCaption - nvarchar(255)
    'ARInvoiceItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

DELETE dbo.ADConfigValues WHERE ADConfigKeyGroup = 'CancelVoucherReason'

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'CancelVoucherReasonByCompany', -- ADConfigKey - nvarchar(100)
    N'ByCompany', -- ADConfigKeyValue - nvarchar(100)
    N'Công ty hủy', -- ADConfigText - nvarchar(1000)
    N'Công ty hủy', -- ADConfigKeyDesc - nvarchar(500)
    N'CancelVoucherReason', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'CancelVoucherReasonByCustomer', -- ADConfigKey - nvarchar(100)
    N'ByCustomer', -- ADConfigKeyValue - nvarchar(100)
    N'Khách hàng hủy', -- ADConfigText - nvarchar(1000)
    N'Khách hàng hủy', -- ADConfigKeyDesc - nvarchar(500)
    N'CancelVoucherReason', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO


