update dbo.ADConfigValues SET ADConfigText = N'Mua gỗ Phách/Thanh' WHERE ADConfigKeyGroup = 'PurchaseOrderReceiptType' AND ADConfigText =  N'Mua gỗ phách'
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARDiscountProgramItemProductNoOfOldSys',   -- AAColumnAliasName - varchar(255)
    N'Mã HT cũ',  -- AAColumnAliasCaption - nvarchar(255)
    'ARDiscountProgramItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
    )
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARDiscountProgramItemProductCustomerNumber',   -- AAColumnAliasName - varchar(255)
    N'Mã SP đối tác',  -- AAColumnAliasCaption - nvarchar(255)
    'ARDiscountProgramItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
    )
GO

