INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'FK_APPurchasingStaffID',   -- AAColumnAliasName - varchar(255)
    N'Người mua hàng',  -- AAColumnAliasCaption - nvarchar(255)
    'APProposals',   -- AATableName - varchar(50)
    'HREmployees',   -- AAReferenceTable - varchar(512)
    'HREmployeeName',   -- AADisplayedMember - varchar(512)
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
    'APPurchaseOrderRef',   -- AAColumnAliasName - varchar(255)
    N'Mã đơn mua hàng',  -- AAColumnAliasCaption - nvarchar(255)
    'APProposals',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
)
GO



INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'ProductConverSizeFactorInch', -- ADConfigKey - nvarchar(100)
    N'Inch', -- ADConfigKeyValue - nvarchar(100)
    N'Hệ số quy đổi kích thước', -- ADConfigText - nvarchar(1000)
    N'0.039370', -- ADConfigKeyDesc - nvarchar(500)
    N'ProductConverSizeFactor', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
    )
GO

