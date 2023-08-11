INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'FK_HREmployeeID',   -- AAColumnAliasName - varchar(255)
    N'Nhân viên',  -- AAColumnAliasCaption - nvarchar(255)
    'ICProductConversions',   -- AATableName - varchar(50)
    'HREmployees',   -- AAReferenceTable - varchar(512)
    'HREmployeeName',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    NULL  -- AAColumnAliasIsSaveHistory - bit
    )
	GO
INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ICProductCustomerPackagingInfoVietnam',   -- AAColumnAliasName - varchar(255)
    N'Thông tin đóng gói Tiếng Việt',  -- AAColumnAliasCaption - nvarchar(255)
    'ICProductCustomers',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    NULL  -- AAColumnAliasIsSaveHistory - bit
    )
	GO
