
DELETE dbo.ADConfigValues WHERE ADConfigKeyGroup = 'ReturnSupplierReceiptType'

INSERT INTO dbo.ADConfigValues
SELECT   'Alive',  -- AAStatus - varchar(10)
    N'ReturnSupplierReceiptType' + a.ADConfigKeyValue, -- ADConfigKey - nvarchar(100)
    a.ADConfigKeyValue, -- ADConfigKeyValue - nvarchar(100)
    a.ADConfigText, -- ADConfigText - nvarchar(1000)
    N'ReturnSupplierReceiptType' + a.ADConfigKeyValue, -- ADConfigKeyDesc - nvarchar(500)
    N'ReturnSupplierReceiptType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
FROM dbo.ADConfigValues a
WHERE a.AAStatus = 'Alive' 
AND a.ADConfigKeyGroup = 'ReceiptReceiptType'
