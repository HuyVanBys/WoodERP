------Đã chạy D dev-test-----
INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARSaleOrderItemAllocationFeeProductQty',   -- AAColumnAliasName - varchar(255)
    N'Số lượng',  -- AAColumnAliasCaption - nvarchar(255)
    'ARSaleOrderItemAllocationFees',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.STFieldFormats
VALUES
(   'SaleOrder',   -- STFieldFormatModuleName - varchar(50)
    'ARSaleOrderItemAllocationFees',   -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupN3'),    -- STFieldFormatGroupID - int
    'ARSaleOrderItemAllocationFeeProductQty',   -- STFieldFormatColumnName - varchar(100)
    1, -- STChangeByCurrency - bit
    1  -- STChangeByDepartment - bit
)
GO

