----ONLY FOR HAPPY UAT
INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'GenerateSemiProductNoForHappyTrue', -- ADConfigKey - nvarchar(100)
    N'true', -- ADConfigKeyValue - nvarchar(100)
    N'true', -- ADConfigText - nvarchar(1000)
    N'', -- ADConfigKeyDesc - nvarchar(500)
    N'GenerateSemiProductNoForHappy', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
    )