INSERT INTO dbo.STFieldFormats
(
    STFieldFormatModuleName,
    STFieldFormatTableName,
    STFieldFormatGroupID,
    STFieldFormatColumnName
)
VALUES
(   'BatchProductShedule', -- STFieldFormatModuleName - varchar(50)
    'MMAllocationPlanItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM  dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN4'),  -- STFieldFormatGroupID - int
    'MMAllocationPlanItemBPQty'  -- STFieldFormatColumnName - varchar(100)
    )