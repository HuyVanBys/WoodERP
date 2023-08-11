INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'DocumentTaxEntryTypeThueGTGTDuocKhauTru', -- ADConfigKey - nvarchar(100)
    N'ThueGTGTDuocKhauTru', -- ADConfigKeyValue - nvarchar(100)
    N'1. Thuế GTGT được khấu trừ', -- ADConfigText - nvarchar(1000)
    N'1. Thuế GTGT được khấu trừ', -- ADConfigKeyDesc - nvarchar(500)
    N'DocumentTaxEntryType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'DocumentTaxEntryTypeThueGTGTPhaiNop', -- ADConfigKey - nvarchar(100)
    N'ThueGTGTPhaiNop', -- ADConfigKeyValue - nvarchar(100)
    N'2. Thuế GTGT phải nộp', -- ADConfigText - nvarchar(1000)
    N'2. Thuế GTGT phải nộp', -- ADConfigKeyDesc - nvarchar(500)
    N'DocumentTaxEntryType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

