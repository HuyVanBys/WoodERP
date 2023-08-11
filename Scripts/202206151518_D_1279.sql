INSERT INTO dbo.AAColumnAlias
Values
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARSaleOrderItemQuantityOfBox',   -- AAColumnAliasName - varchar(255)
    N'Số thùng',  -- AAColumnAliasCaption - nvarchar(255)
    'ARSaleOrderItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    0, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
    )

INSERT INTO dbo.AAColumnAlias
Values
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARDeliveryPlanItemQuantityOfBox',   -- AAColumnAliasName - varchar(255)
    N'Số thùng',  -- AAColumnAliasCaption - nvarchar(255)
    'ARDeliveryPlanItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    0, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
    )
--
INSERT INTO dbo.STFieldFormats
VALUES
(   'SaleOrder', -- STFieldFormatModuleName - varchar(50)
    'ARSaleOrderItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM  dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPrice'),  -- STFieldFormatGroupID - int
    'ARSaleOrderItemQuantityOfBox'  -- STFieldFormatColumnName - varchar(100)
    )
INSERT INTO dbo.STFieldFormats
VALUES
(   'DeliveryPlan', -- STFieldFormatModuleName - varchar(50)
    'ARDeliveryPlanItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM  dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPrice'),  -- STFieldFormatGroupID - int
    'ARDeliveryPlanItemQuantityOfBox'  -- STFieldFormatColumnName - varchar(100)
    )
INSERT INTO dbo.STFieldFormats
VALUES
(   'ShipmentSaleOrder', -- STFieldFormatModuleName - varchar(50)
    'ICShipmentItems', -- STFieldFormatTableName - varchar(50)
    (SELECT STFieldFormatGroupID FROM  dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPrice'),  -- STFieldFormatGroupID - int
    'ICShipmentItemQuantityOfBox'  -- STFieldFormatColumnName - varchar(100)
    )