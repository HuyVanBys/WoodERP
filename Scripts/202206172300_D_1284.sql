INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARInvoiceVATInvoiceNo',   -- AAColumnAliasName - varchar(255)
    N'Số hóa đơn (VAT)',  -- AAColumnAliasCaption - nvarchar(255)
    'ARCustomerPaymentTimePayments',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARInvoiceVATInvoiceDate',   -- AAColumnAliasName - varchar(255)
    N'Ngày hóa đơn (VAT)',  -- AAColumnAliasCaption - nvarchar(255)
    'ARCustomerPaymentTimePayments',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

