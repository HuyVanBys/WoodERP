INSERT INTO dbo.STFieldFormats
VALUES
(   'InventoryLeadger', -- STFieldFormatModuleName - varchar(50)
    'ICTransactions', -- STFieldFormatTableName - varchar(50)
    (SELECT TOP 1 STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN6'),  -- STFieldFormatGroupID - int
    'ICTransactionReceiptQty'  -- STFieldFormatColumnName - varchar(100)
)
GO
INSERT INTO dbo.STFieldFormats
VALUES
(   'InventoryLeadger', -- STFieldFormatModuleName - varchar(50)
    'ICTransactions', -- STFieldFormatTableName - varchar(50)
    (SELECT TOP 1 STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN6'),  -- STFieldFormatGroupID - int
    'ICTransactionShipmentQty'  -- STFieldFormatColumnName - varchar(100)
)
GO