UPDATE dbo.STFieldFormats 
SET STFieldFormatGroupID = (SELECT TOP 1 STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN6')
WHERE STFieldFormatColumnName IN ('ICProductConversionItemProductQty', 'ICProductConversionItemProductExchangeQty')
