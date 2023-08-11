UPDATE dbo.ICReceipts
SET ICReceiptReceiptType = 'OutSourcing'
WHERE ICReceiptReceiptType = 'Dichvuvagiacong'

UPDATE dbo.ADConfigValues
SET ADConfigKey = 'ReceiptReceiptTypeOutSourcing'
,	ADConfigKeyValue = 'OutSourcing'
WHERE AAStatus = 'Alive'
AND ADConfigKey = 'ReceiptReceiptTypeDichvuvagiacong'
