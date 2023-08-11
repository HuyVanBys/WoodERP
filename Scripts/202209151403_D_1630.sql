
INSERT INTO dbo.GENumbering
VALUES
(   N'Import',       -- AACreatedUser - nvarchar(50)
    GETDATE(), -- AACreatedDate - datetime
    N'',       -- AAUpdatedUser - nvarchar(50)
    GETDATE(), -- AAUpdatedDate - datetime
    'Alive',        -- AAStatus - varchar(10)
    N'SaleReturnSerialNo',       -- GENumberingName - nvarchar(50)
    N'HBTL',       -- GENumberingPrefix - nvarchar(50)
    3,         -- GENumberingLength - int
    1,         -- GENumberingStart - int
    N'Mã lô hàng bán trả lại',       -- GENumberingDesc - nvarchar(255)
    1,         -- FK_BRBranchID - int
    1,      -- GENumberingPrefixHaveYear - bit
    1,      -- GENumberingPrefixHaveMonth - bit
    0,      -- GENumberingPrefixHaveDay - bit
    0,      -- GENumberingPrefixHaveStock - bit
    0,      -- GENumberingPrefixHaveBankAbbreviation - bit
    N'{1}/{2}/{3}/{7}'        -- GENumberingFormat - nvarchar(50)
)
GO
