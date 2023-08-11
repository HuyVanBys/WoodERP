UPDATE dbo.STFieldFormats
SET STFieldFormatGroupID = (SELECT STFieldFormatGroupID FROM  dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPriceByCurrency')
WHERE STFieldFormatModuleName = 'Product' AND STFieldFormatColumnName IN ('ICProductSupplierPrice','ICProductPrice01') AND STFieldFormatTableName = 'ICProducts'