UPDATE dbo.STFieldFormats 
SET STFieldFormatGroupID = (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupQtyN2')
WHERE STFieldFormatTableName = 'RPTKT002'
AND STFieldFormatColumnName IN ('ICTransactionExchangeUnitCost', 'ICTransactionExchangeTotalCost')
