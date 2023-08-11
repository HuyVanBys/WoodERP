----ALTER TABLE ARInvoiceItems
----ADD ARInvoiceItemProductNoOfOldSys NVARCHAR(100);

--ALTER TABLE ARProposalItems
--ADD ARProposalItemProductNoOfOldSys NVARCHAR(100);

--ALTER TABLE ARProposalItems
--ADD ARProposalItemProductCustomerNumber NVARCHAR(50);

--ALTER TABLE ARDeliveryPlanItems
--ADD ARDeliveryPlanItemProductNoOfOldSys NVARCHAR(100);

--ALTER TABLE ARDeliveryPlanItems
--ADD ARDeliveryPlanItemProductCustomerNumber NVARCHAR(50);

--ALTER TABLE ARSaleForecastItems
--ADD ARSaleForecastItemProductNoOfOldSys NVARCHAR(100);

--ALTER TABLE ARCancelSaleForecastItems
--ADD ARCancelSaleForecastItemProductNoOfOldSys NVARCHAR(100);

--ALTER TABLE ARCancelSaleForecastItems
--ADD ARCancelSaleForecastItemProductCustomerNumber NVARCHAR(50);

--ALTER TABLE ARCancelVoucherItems
--ADD ARCancelVoucherItemProductNoOfOldSys NVARCHAR(100);

--ALTER TABLE ARCancelVoucherItems
--ADD ARCancelVoucherItemProductCustomerNumber NVARCHAR(50);

--ALTER TABLE ARCanceledDeliveryPlanItems
--ADD ARCanceledDeliveryPlanItemProductNoOfOldSys NVARCHAR(100);

--ALTER TABLE ARCanceledDeliveryPlanItems
--ADD ARCanceledDeliveryPlanItemProductCustomerNumber NVARCHAR(50);

--ALTER TABLE ARSaleReturnItems
--ADD ARSaleReturnItemProductNoOfOldSys NVARCHAR(100);

--ALTER TABLE ARSaleReturnItems
--ADD ARSaleReturnItemProductCustomerNumber NVARCHAR(50);

--ALTER TABLE APProposalItems
--ADD APProposalItemAverageUsageQty DECIMAL(18,5)




INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARInvoiceItemProductNoOfOldSys',   -- AAColumnAliasName - varchar(255)
    N'Mã HT cũ',  -- AAColumnAliasCaption - nvarchar(255)
    'ARInvoiceItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
    )
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARProposalItemProductNoOfOldSys',   -- AAColumnAliasName - varchar(255)
    N'Mã HT cũ',  -- AAColumnAliasCaption - nvarchar(255)
    'ARProposalItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
    )
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARProposalItemProductCustomerNumber',   -- AAColumnAliasName - varchar(255)
    N'Mã SP đối tác',  -- AAColumnAliasCaption - nvarchar(255)
    'ARProposalItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
    )
GO

-------

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARDeliveryPlanItemProductNoOfOldSys',   -- AAColumnAliasName - varchar(255)
    N'Mã HT cũ',  -- AAColumnAliasCaption - nvarchar(255)
    'ARDeliveryPlanItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
    )
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARDeliveryPlanItemProductCustomerNumber',   -- AAColumnAliasName - varchar(255)
    N'Mã SP đối tác',  -- AAColumnAliasCaption - nvarchar(255)
    'ARDeliveryPlanItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
    )
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARSaleForecastItemProductNoOfOldSys',   -- AAColumnAliasName - varchar(255)
    N'Mã HT cũ',  -- AAColumnAliasCaption - nvarchar(255)
    'ARSaleForecastItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
    )
GO
-------

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARCancelSaleForecastItemProductCustomerNumber',   -- AAColumnAliasName - varchar(255)
    N'Mã HT cũ',  -- AAColumnAliasCaption - nvarchar(255)
    'ARCancelSaleForecastItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
    )
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARCancelSaleForecastItemProductNoOfOldSys',   -- AAColumnAliasName - varchar(255)
    N'Mã SP đối tác',  -- AAColumnAliasCaption - nvarchar(255)
    'ARCancelSaleForecastItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
    )
GO

---------------------

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARCancelVoucherItemProductNoOfOldSys',   -- AAColumnAliasName - varchar(255)
    N'Mã HT cũ',  -- AAColumnAliasCaption - nvarchar(255)
    'ARCancelVoucherItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
    )
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARCancelVoucherItemProductCustomerNumber',   -- AAColumnAliasName - varchar(255)
    N'Mã SP đối tác',  -- AAColumnAliasCaption - nvarchar(255)
    'ARCancelVoucherItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
    )
GO

---------------------

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARCanceledDeliveryPlanItemProductNoOfOldSys',   -- AAColumnAliasName - varchar(255)
    N'Mã HT cũ',  -- AAColumnAliasCaption - nvarchar(255)
    'ARCanceledDeliveryPlanItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
    )
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARCanceledDeliveryPlanItemProductCustomerNumber',   -- AAColumnAliasName - varchar(255)
    N'Mã SP đối tác',  -- AAColumnAliasCaption - nvarchar(255)
    'ARCanceledDeliveryPlanItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
    )
GO
---------------------

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARSaleReturnItemProductNoOfOldSys',   -- AAColumnAliasName - varchar(255)
    N'Mã HT cũ',  -- AAColumnAliasCaption - nvarchar(255)
    'ARSaleReturnItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
    )
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARSaleReturnItemProductCustomerNumber',   -- AAColumnAliasName - varchar(255)
    N'Mã SP đối tác',  -- AAColumnAliasCaption - nvarchar(255)
    'ARSaleReturnItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
    )
GO
------------------------------------------------------------------------------------------------------------------------------------------------------------------
INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'APProposalItemAverageUsageQty',   -- AAColumnAliasName - varchar(255)
    N'Số lượng sử dụng bình quân',  -- AAColumnAliasCaption - nvarchar(255)
    'APProposalItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    0  -- AAColumnAliasIsSaveHistory - bit
    )
GO
