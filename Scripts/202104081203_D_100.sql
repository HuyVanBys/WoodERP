INSERT INTO dbo.STFieldFormats
(
    STFieldFormatModuleName,
    STFieldFormatTableName,
    STFieldFormatGroupID,
    STFieldFormatColumnName
)
VALUES
(   'ReturnSupplier', -- STFieldFormatModuleName - varchar(50)
    'APReturnSuppliers', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPercent'),  -- STFieldFormatGroupID - int
    'APReturnSupplierTaxPercent'  -- STFieldFormatColumnName - varchar(100)
    )
INSERT INTO dbo.STFieldFormats
(
    STFieldFormatModuleName,
    STFieldFormatTableName,
    STFieldFormatGroupID,
    STFieldFormatColumnName
)
VALUES
(   'ReturnSupplier', -- STFieldFormatModuleName - varchar(50)
    'APReturnSuppliers', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPriceByCurrency'),  -- STFieldFormatGroupID - int
    'APReturnSupplierTaxAmount'  -- STFieldFormatColumnName - varchar(100)
    )