INSERT INTO dbo.STFieldFormats
VALUES
(   'MaterialReceipt', -- STFieldFormatModuleName - varchar(50)
    'ICReceiptItems', -- STFieldFormatTableName - varchar(50)
    (SELECT TOP 1 STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN6'),  -- STFieldFormatGroupID - int
    'ICReceiptItemProductQty'  -- STFieldFormatColumnName - varchar(100)
)
GO


