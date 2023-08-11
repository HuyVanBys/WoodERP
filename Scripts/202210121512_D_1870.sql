INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'CommissionTypeCommission', -- ADConfigKey - nvarchar(100)
    N'Commission', -- ADConfigKeyValue - nvarchar(100)
    N'Hoa hồng', -- ADConfigText - nvarchar(1000)
    N'CommissionTypeCommission', -- ADConfigKeyDesc - nvarchar(500)
    N'CommissionType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
    )
INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'CommissionTypeReduce', -- ADConfigKey - nvarchar(100)
    N'Reduce', -- ADConfigKeyValue - nvarchar(100)
    N'Giảm trừ', -- ADConfigText - nvarchar(1000)
    N'CommissionTypeReduce', -- ADConfigKeyDesc - nvarchar(500)
    N'CommissionType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
    )

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARCommissionType',   -- AAColumnAliasName - varchar(255)
    N'Loại chi phí',  -- AAColumnAliasCaption - nvarchar(255)
    'ARCommissions',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    NULL  -- AAColumnAliasIsSaveHistory - bit
    )
INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARCommissionDesc',   -- AAColumnAliasName - varchar(255)
    N'Diễn giải',  -- AAColumnAliasCaption - nvarchar(255)
    'ARCommissions',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    NULL  -- AAColumnAliasIsSaveHistory - bit
    )

UPDATE dbo.AAColumnAlias
SET AAColumnAliasCaption = N'% Giới thiệu/Giảm trừ'
WHERE AATableName = 'ARCommissions' AND AAColumnAliasName = 'ARCommissionPercent'

UPDATE dbo.AAColumnAlias
SET AAColumnAliasCaption = N'Tiền Giới thiệu/Giảm trừ'
WHERE AATableName = 'ARCommissions' AND AAColumnAliasName = 'ARCommissionAmount'