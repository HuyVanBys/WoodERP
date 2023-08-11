
UPDATE dbo.STFieldFormats
SET STFieldFormatGroupID = (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupExchangeRate')
WHERE STFieldFormatTableName = 'ACLoanReceipts'
AND STFieldFormatColumnName = 'ACLoanReceiptExchangeRate'