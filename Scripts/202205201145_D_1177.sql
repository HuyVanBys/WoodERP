Update STFieldFormats
Set STFieldFormatGroupID = (Select STFieldFormatGroupID from STFieldFormatGroups Where STFieldFormatGroupName = 'FormatGroupN6')
Where STFieldFormatColumnName = 'ICProductDepreciationQty' and STFieldFormatTableName = 'ICProducts'