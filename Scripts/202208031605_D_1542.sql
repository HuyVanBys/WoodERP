
--Đã chạy DB ERPWood_Test
INSERT INTO dbo.STFieldFormats
VALUES
(   'InventoryLeadger', -- STFieldFormatModuleName - varchar(50)
    'ICTransactions', -- STFieldFormatTableName - varchar(50)
    (SELECT TOP 1 STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN6'),  -- STFieldFormatGroupID - int
    'ICTransactionQty1'  -- STFieldFormatColumnName - varchar(100)
)
GO

