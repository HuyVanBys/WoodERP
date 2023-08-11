UPDATE dbo.ADConfigValues
SET AAStatus = 'Delete'
WHERE ADConfigKeyGroup = 'ReturnSupplierReceiptType'

INSERT dbo.ADConfigValues
SELECT 'Alive',
		REPLACE(cv.ADConfigKey,'ReceiptReceiptType', 'ReturnSupplierReceiptType') AS ADConfigKey,
		cv.ADConfigKeyValue,
		cv.ADConfigText,
		cv.ADConfigKeyDesc,
		'ReturnSupplierReceiptType' AS ADConfigKeyGroup,
		cv.IsActive
FROM dbo.ADConfigValues cv
WHERE cv.AAStatus = 'Alive'
AND cv.ADConfigKeyGroup = 'ReceiptReceiptType'

