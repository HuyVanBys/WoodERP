
INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'APPaymentProposalItemDiscountFix',   -- AAColumnAliasName - varchar(255)
    N'Chiết khấu thanh toán',  -- AAColumnAliasCaption - nvarchar(255)
    'APPaymentProposalItems',   -- AATableName - varchar(50)
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
    'APPaymentProposalPaymentDiscountFix',   -- AAColumnAliasName - varchar(255)
    N'Chiết khấu thanh toán',  -- AAColumnAliasCaption - nvarchar(255)
    'APPaymentProposalPayments',   -- AATableName - varchar(50)
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
(   'PaymentProposal',   -- STFieldFormatModuleName - varchar(50)
    'APPaymentProposalItems',   -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPriceByCurrency'),    -- STFieldFormatGroupID - int
    'APPaymentProposalItemDiscountFix',   -- STFieldFormatColumnName - varchar(100)
    1, -- STChangeByCurrency - bit
    0  -- STChangeByDepartment - bit
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'SupplierPayment',   -- STFieldFormatModuleName - varchar(50)
    'APPaymentProposalPayments',   -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPriceByCurrency'),    -- STFieldFormatGroupID - int
    'APPaymentProposalPaymentDiscountFix',   -- STFieldFormatColumnName - varchar(100)
    1, -- STChangeByCurrency - bit
    0  -- STChangeByDepartment - bit
)
GO