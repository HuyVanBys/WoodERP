DELETE dbo.AAColumnAlias
WHERE AATableName = 'ACEInvoiceConfigs'

DELETE dbo.AAColumnAlias WHERE AATableName IN ('ACEInvoiceGenerals','ACEInvoiceDetails')
DELETE dbo.STFieldFormats WHERE STFieldFormatTableName IN ('ACEInvoiceGenerals','ACEInvoiceDetails')

INSERT INTO dbo.ADConfigValues
VALUES
(   'Alive',  -- AAStatus - varchar(10)
    N'OutputVATDocumentTypeInvoiceType6', -- ADConfigKey - nvarchar(100)
    N'InvoiceType6', -- ADConfigKeyValue - nvarchar(100)
    N'6. Hàng hóa, dịch vụ chịu thuế suất thuế GTGT 8%:', -- ADConfigText - nvarchar(1000)
    N'OutputVATDocumentTypeInvoiceType6', -- ADConfigKeyDesc - nvarchar(500)
    N'OutputVATDocumentType', -- ADConfigKeyGroup - nvarchar(50)
    1 -- IsActive - bit
)
GO

INSERT INTO dbo.AAColumnAlias
VALUES
(   0,    -- AANumberInt - int
    '',   -- AANumberString - varchar(50)
    'Alive',   -- AAStatus - varchar(50)
    'ACTaxUnitNo',   -- AAColumnAliasName - varchar(255)
    N'Mã đơn vị thuế',  -- AAColumnAliasCaption - nvarchar(255)
    'ACTaxUnits',   -- AATableName - varchar(50)
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
    'ACTaxUnitName',   -- AAColumnAliasName - varchar(255)
    N'Tên đơn vị thuế',  -- AAColumnAliasCaption - nvarchar(255)
    'ACTaxUnits',   -- AATableName - varchar(50)
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
    'FK_BRBranchID',   -- AAColumnAliasName - varchar(255)
    N'Chi nhánh',  -- AAColumnAliasCaption - nvarchar(255)
    'ACTaxUnits',   -- AATableName - varchar(50)
    'BRBranchs',   -- AAReferenceTable - varchar(512)
    'BRBranchName',   -- AADisplayedMember - varchar(512)
    '',   -- AAFilteredColumn - varchar(512)
    '',   -- AAFilteredValues - varchar(512)
    1, -- AAAllowDummy - bit
    1  -- AAColumnAliasIsSaveHistory - bit
)
GO

INSERT INTO dbo.GELookupTables
VALUES
(   'Alive',  -- AAStatus - varchar(50)
    N'ACTaxUnits', -- GELookupTableName - nvarchar(200)
    N'Tên đơn vị thuế', -- GELookupTableDesc - nvarchar(200)
    N'ACTaxUnitName', -- GELookupTableDisplayColumn - nvarchar(200)
    'ACTaxUnitID',  -- GELookupTableValueColumn - varchar(512)
    'ACTaxUnitName'   -- GELookupTableLookupColumns - varchar(512)
)
GO

INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ItemCode', N'Mã hàng hóa', 'ACEInvoiceDetails', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ItemName', N'Tên hàng hóa', 'ACEInvoiceDetails', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'UnitCode', N'Mã đơn vị tính', 'ACEInvoiceDetails', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'UnitName', N'Tên đơn vị tính', 'ACEInvoiceDetails', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'UnitPrice', N'Đơn giá', 'ACEInvoiceDetails', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'Quantity', N'Số lượng', 'ACEInvoiceDetails', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'VatPercentage', N'Thuế suất(%)', 'ACEInvoiceDetails', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'VatAmount', N'Tổng tiền thuế', 'ACEInvoiceDetails', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ACEInvoiceDetailFunction', N'Chức năng', 'ACEInvoiceDetails', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'InvoiceType', N'Mã loại HĐ', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'TemplateCode', N'Mã mẫu HĐ', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'InvoiceSeries', N'Ký hiệu HĐ ', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'InvoiceNumber', N'Số hóa đơn', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'InvoiceName', N'Tên hóa đơn', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'InvoiceIssuedDate', N'Ngày nhập HĐ', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ContractNumber', N'Số hợp đồng ', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ContractDate', N'Ngày hợp đồng', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'CurrencyCode', N'Mã tiền tệ', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ExchangeRate', N'Tỷ giá', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'InvoiceNote', N'Ghi chú HĐ', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'BuyerCode', N'Mã khách hàng', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'BuyerBankNumber', N'Số tài khoản', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'BuyerBankAccount', N'Tên tài khoản ngân hàng', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'BuyerBankName', N'Tên ngân hàng', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'BuyerType', N'Loại khách hàng', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ACEInvoiceGeneralPaymentMethod', N'PT thanh toán', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ACEInvoiceGeneralNo', N'Mã chứng từ', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'BuyerLegalName', N'Tên khách hàng', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'TotalAmountWithVAT', N'Tổng tiền', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ACEInvoiceGeneralStatus', N'Tình trạng', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'SubmittedDate', N'Ngày phát hành', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'EmployeeCreateInvoiceName', N'NV tạo hóa đơn', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'EmployeeUpLoadDataToEInvoiceName', N'NV đẩy dữ liệu hóa đơn', 'ACEInvoiceGenerals', '', '', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'FK_ACTaxUnitID', N'Đơn vị tính thuế', 'ACEInvoiceGenerals', 'ACTaxUnits', 'ACTaxUnitName', '', '', 1, 1)
INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'LineNumber', N'Thứ tự', 'ACEInvoiceDetails', '', '', '', '', 1, 1)

INSERT INTO dbo.STFieldFormats VALUES ('ElectronicInvoice', N'ACEInvoiceDetails',(ISNULL((SELECT STFieldFormatGroupID from STFieldFormatGroups WHERE STFieldFormatGroupName ='FormatGroupPriceByCurrency2'), 1)),'UnitPrice')
INSERT INTO dbo.STFieldFormats VALUES ('ElectronicInvoice', N'ACEInvoiceDetails',(ISNULL((SELECT STFieldFormatGroupID from STFieldFormatGroups WHERE STFieldFormatGroupName ='FormatGroupPriceByCurrency2'), 1)),'VatAmount')

IF (SELECT COUNT(1) FROM dbo.ACTaxUnits WHERE ACTaxUnitID = 0) = 0
BEGIN
	SET IDENTITY_INSERT ACTaxUnits ON 
	INSERT INTO [dbo].[ACTaxUnits](
		[ACTaxUnitID],
		[AAStatus],
		[AACreatedDate],
		[AACreatedUser],
		[AAUpdatedDate],
		[AAUpdatedUser],
		[FK_BRBranchID],
		[ACTaxUnitNo],
		[ACTaxUnitName]
	) VALUES ( 
		0,
		'',
		NULL,
		'',
		NULL,
		'',
		0,
		'',
		''
	)
	SET IDENTITY_INSERT ACTaxUnits OFF 
END
