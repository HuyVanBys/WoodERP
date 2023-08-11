-----ĐÃ CHẠY DB TEST-----
IF (SELECT COUNT(1) FROM dbo.ACRetailVATs WHERE ACRetailVATID = 0) = 0
BEGIN
	SET IDENTITY_INSERT ACRetailVATs ON 
	INSERT INTO [dbo].[ACRetailVATs](
		[ACRetailVATID],
		[AACreatedDate],
		[AACreatedUser],
		[AAUpdatedDate],
		[AAUpdatedUser],
		[AAStatus],
		[FK_GECurrencyID],
		[FK_BRBranchID],
		[FK_ARSellerID],
		[FK_HREmployeeID],
		[FK_ACTaxUnitID],
		[FK_ACEInvoiceTypeID],
		[ACRetailVATNo],
		[ACRetailVATName],
		[ACRetailVATDesc],
		[ACRetailVATDate],
		[FK_ACObjectID],
		[ARObjectType],
		[ACRetailVATExchangeRate],
		[ACRetailVATTaxNumber],
		[ARPaymentMethodCombo],
		[ACRetailVATSOContactName],
		[ACRetailVATInvoiceRequest],
		[ACRetailVATStatus],
		[ACRetailVATReference],
		[ACRetailVATSubTotalAmount],
		[ACRetailVATTaxPercent],
		[ACRetailVATTaxAmount],
		[ACRetailVATDiscountPerCent],
		[ACRetailVATDiscountAmount],
		[ACRetailVATTotalAmount],
		[ACRetailVATComment],
		[AROutputVATDocumentType],
		[ACRetailVATVATFormNo],
		[ACRetailVATVATSymbol],
		[ACRetailVATVATInvoiceNo],
		[ACRetailVATVATPaymentContactInformation],
		[AROutputVATInvoiceNoCombo]
	) VALUES ( 
		0,
		NULL,
		'',
		NULL,
		'',
		'',
		0,
		0,
		0,
		0,
		0,
		0,
		'',
		'',
		'',
		NULL,
		0,
		'',
		0.0,
		'',
		'',
		'',
		'',
		'',
		'',
		0.0,
		0.0,
		0.0,
		0.0,
		0.0,
		0.0,
		'',
		'',
		'',
		'',
		'',
		'',
		''
	)
	SET IDENTITY_INSERT ACRetailVATs OFF 
END

IF (SELECT COUNT(1) FROM dbo.ACRetailVATItems WHERE ACRetailVATItemID = 0) = 0
BEGIN
	SET IDENTITY_INSERT ACRetailVATItems ON 
	INSERT INTO [dbo].[ACRetailVATItems](
		[ACRetailVATItemID],
		[AAStatus],
		[FK_ACRetailVATID],
		[FK_ICProductID],
		[FK_ICMeasureUnitID],
		[FK_ARInvoiceItemID],
		[ACRetailVATItemSortOrder],
		[ACRetailVATItemProductNo],
		[ACRetailVATItemProductName],
		[ACRetailVATItemProductName2],
		[ACRetailVATItemProductDesc],
		[ACRetailVATItemProductNoOfOldSys],
		[ACRetailVATItemProductUnitPrice],
		[ACRetailVATItemProductQty],
		[ACRetailVATItemProductDiscountPercent],
		[ACRetailVATItemDiscountAmount],
		[ACRetailVATItemProductTaxPercent],
		[ACRetailVATItemTaxAmount],
		[ACRetailVATItemTotalAmount],
		[ACRetailVATItemComment]
	) VALUES ( 
		0,
		'',
		0,
		0,
		0,
		0,
		0,
		'',
		'',
		'',
		'',
		'',
		0.0,
		0.0,
		0.0,
		0.0,
		0.0,
		0.0,
		0.0,
		''
	)
	SET IDENTITY_INSERT ACRetailVATItems OFF 
END

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATItemSortOrder',   -- AAColumnAliasName - varchar(255)
    N'STT',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATItemProductNo',   -- AAColumnAliasName - varchar(255)
    N'Mã sản phẩm',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATItemProductName',   -- AAColumnAliasName - varchar(255)
    N'Tên sản phẩm',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATItemProductNoOfOldSys',   -- AAColumnAliasName - varchar(255)
    N'Mã HT cũ',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATItemProductDesc',   -- AAColumnAliasName - varchar(255)
    N'Mô tả',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATItemProductName2',   -- AAColumnAliasName - varchar(255)
    N'Tên SP tiếng việt',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'FK_ICMeasureUnitID',   -- AAColumnAliasName - varchar(255)
    N'Đơn vị tính',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATItems',   -- AATableName - varchar(50)
    'ICMeasureUnits',   -- AAReferenceTable - varchar(512)
    'ICMeasureUnitName',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATItemProductQty',   -- AAColumnAliasName - varchar(255)
    N'Số lượng',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATItemProductUnitPrice',   -- AAColumnAliasName - varchar(255)
    N'Đơn giá',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATItemSubTotalAmount',   -- AAColumnAliasName - varchar(255)
    N'Tổng giá bán',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATItemProductDiscountPercent',   -- AAColumnAliasName - varchar(255)
    N'%CK',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATItemDiscountAmount',   -- AAColumnAliasName - varchar(255)
    N'Tiền chiết khấu',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATItemProductTaxPercent',   -- AAColumnAliasName - varchar(255)
    N'% thuế',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATItemTaxAmount',   -- AAColumnAliasName - varchar(255)
    N'Tiền thuế',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATItemTotalAmount',   -- AAColumnAliasName - varchar(255)
    N'Thành tiền',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATItemComment',   -- AAColumnAliasName - varchar(255)
    N'Ghi chú',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATItems',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATNo',   -- AAColumnAliasName - varchar(255)
    N'Mã chứng từ',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATs',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATDesc',   -- AAColumnAliasName - varchar(255)
    N'Diễn giải',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATs',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATVATFormNo',   -- AAColumnAliasName - varchar(255)
    N'Mẫu số',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATs',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATVATSymbol',   -- AAColumnAliasName - varchar(255)
    N'Ký hiệu',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATs',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATVATInvoiceNo',   -- AAColumnAliasName - varchar(255)
    N'Số hóa đơn',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATs',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATDate',   -- AAColumnAliasName - varchar(255)
    N'Ngày hóa đơn',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATs',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATSOContactName',   -- AAColumnAliasName - varchar(255)
    N'Người mua hàng',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATs',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATTaxNumber',   -- AAColumnAliasName - varchar(255)
    N'Mã số thuế',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATs',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ARInvoiceTotalAmount',   -- AAColumnAliasName - varchar(255)
    N'Thành tiền',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATs',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACRetailVATComment',   -- AAColumnAliasName - varchar(255)
    N'Ghi chú',  -- AAColumnAliasCaption - nvarchar(255)
    'ACRetailVATs',   -- AATableName - varchar(50)
    '',   -- AAReferenceTable - varchar(512)
    '',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO
