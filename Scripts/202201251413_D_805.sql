update dbo.AAColumnAlias SET AAColumnAliasCaption = N'Tỷ giá bán' WHERE AATableName = 'GECurrencyExchangeRates' AND AAColumnAliasName = 'GECurrencyExchangeRateExchangeRate'
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'GECurrencyExchangeRateTransferExchangeRate',   -- AAColumnAliasName - varchar(255)
    N'Tỷ giá mua chuyển khoản',  -- AAColumnAliasCaption - nvarchar(255)
    'GECurrencyExchangeRates',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    NULL, -- AAAllowDummy - bit
    NULL  -- AAColumnAliasIsSaveHistory - bit
    )
GO


update GECurrencyExchangeRates SET GECurrencyExchangeRateTransferExchangeRate = 1 WHERE FK_GECurrencyID = 100000
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'CompanyConstant', -- STFieldFormatModuleName - varchar(50)
    'GECurrencyExchangeRates', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPrice'),  -- STFieldFormatGroupID - int
    'GECurrencyExchangeRateTransferExchangeRate'  -- STFieldFormatColumnName - varchar(100)
    )
GO


