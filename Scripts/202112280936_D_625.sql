INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'FK_MMBatchProductID',   -- AAColumnAliasName - varchar(255)
    N'Lệnh sản xuất',  -- AAColumnAliasCaption - nvarchar(255)
    'ICTransfers',   -- AATableName - varchar(50)
    'MMBatchProducts',   -- AAReferenceTable - varchar(512)
    'MMBatchProductNo',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    NULL  -- AAColumnAliasIsSaveHistory - bit
    )
GO
INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'FK_APPurchaseOrderID',   -- AAColumnAliasName - varchar(255)
    N'Đơn mua hàng',  -- AAColumnAliasCaption - nvarchar(255)
    'ICTransfers',   -- AATableName - varchar(50)
    'APPurchaseOrders',   -- AAReferenceTable - varchar(512)
    'APPurchaseOrderNo',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    NULL  -- AAColumnAliasIsSaveHistory - bit
    )
GO

update dbo.AAColumnAlias SET AAColumnAliasCaption = N'Trạng thái' WHERE AAColumnAliasCaption = N'Status'AND AATableName = 'ARSaleOrderPaymentTimes'
GO