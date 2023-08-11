
INSERT INTO dbo.AAColumnAlias
SELECT 0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'MMBatchProductSOName',   -- AAColumnAliasName - varchar(255)
    N'Mã ĐH nội bộ',  -- AAColumnAliasCaption - nvarchar(255)
    'APProposals',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    0, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
    