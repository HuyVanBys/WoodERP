-- Delete
DELETE STToolbarFunctions WHERE STToolbarID in (select FK_STToolbarID From ADTemplates a Join ADTemplateToolbars b On a.ADTemplateID = b.FK_ADTemplateID Where ADTemplateNo = 'RP_PrintCommercialInvoice')
DELETE STToolbars WHERE STToolbarID in (select FK_STToolbarID From ADTemplateToolbars a Join ADTemplates b On a.FK_ADTemplateID = b.ADTemplateID Where ADTemplateNo = 'RP_PrintCommercialInvoice')
DELETE ADTemplateToolbars WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PrintCommercialInvoice')
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_PrintCommercialInvoice')
DELETE ADTemplates WHERE ADTemplateNo = 'RP_PrintCommercialInvoice'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_PrintCommercialInvoice',N'Commercial Invoice',N'Commercial Invoice',N'RP_PrintCommercialInvoice',N'Alive',N'',1
INSERT INTO STToolbars (AAStatus,STModuleID,STUserGroupID,STToolbarName,STToolbarDesc,STToolbarTag,STToolbarStyle,STToolbarCaption,STToolbarGroup,STToolbarOrder,STToolbarVisible,STToolbarPrivilege,STToolbarParentID,STToolbarImage) SELECT N'Alive',21,1,N'fld_barbtnPrintCommercialInvoice',N'Commercial Invoice',N'PrintCommercialInvoice',N'Default',N'Commercial Invoice',N'Utility',3,1,N'',3183,N''
INSERT INTO ADTemplateToolbars (FK_ADTemplateID,FK_STToolbarID) SELECT (Select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PrintCommercialInvoice'),(select MAX(STToolbarID) From STToolbars)
INSERT INTO STToolbarFunctions (STToolbarFunctionIDString,STToolbarID,STToolbarFunctionName,STToolbarFunctionFullName,STToolbarFunctionClass,STToolbarFunctionSortOrder) SELECT N'',(select MAX(STToolbarID) From STToolbars),N'ActionPrintTemplate',N'Void ActionPrintTemplate()',N'BOSERP.Modules.Invoice.InvoiceModule',1
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'RP_PrintCommercialInvoice') DROP PROCEDURE RP_PrintCommercialInvoice
GO
-- ======================================================================
-- Author:		Hoan Vo
-- Create date: 07/10/2021
-- Procedure Name:RP_PrintCommercialInvoice
-- ======================================================================
CREATE PROCEDURE [dbo].[RP_PrintCommercialInvoice]
	@STModulename	NVARCHAR(50),
	@InvoiceID		INT
AS
BEGIN
	SET NOCOUNT ON
	
	SELECT	* 
	INTO #Items
	FROM dbo.ARInvoiceItems ii
	WHERE ii.AAStatus = 'Alive'
		AND ii.FK_ARInvoiceID = @InvoiceID

	DECLARE @SaleOrderID INT = 0
	SET @SaleOrderID = (SELECT TOP 1 FK_ARSaleOrderID FROM #Items)

	SELECT	p.ICProductNo					AS SupplierCode
		,	p.ICProductCustomerNumber		AS CustomerCode
		,	p.ICProductName					AS DescriptionOfGoods
		,	ii.ARInvoiceItemHeight			AS ProductHeight
		,	ii.ARInvoiceItemWidth			AS ProductWidth
		,	ii.ARInvoiceItemLength			AS ProductLength
		,	ii.ARInvoiceItemProductQty		AS Quantity
		,	m.ICMeasureUnitName				AS UnitName
		,	ii.ARInvoiceItemProductUnitPrice AS UnitPrice
		,	ii.ARInvoiceItemTotalAmount		AS TotalAmount
	FROM #Items	ii
	LEFT JOIN dbo.ICProducts p ON p.AAStatus = 'Alive' AND p.ICProductID = ii.FK_ICProductID
	LEFT JOIN dbo.ICMeasureUnits m ON m.AAStatus = 'Alive' AND m.ICMeasureUnitID = ii.FK_ICMeasureUnitID

	SELECT	i.ARInvoiceNo
		,	i.ARInvoiceDate
		,	i.ARInvoiceTotalAmount
		,	de.deposit AS DepositAmount
		,	i.ARInvoiceTotalAmount - de.deposit AS BalanceAmount
		,	'Date: ' + FORMAT(i.ARInvoiceDate, 'MM/dd/yyyy') AS DateDisplay
		,	'Invoice No: ' + i.ARInvoiceNo					AS InvoiceNoDisplay
		,	ISNULL(t.GETerminalName, '')		AS PortOfLoading
		,	i.ARInvoicePortOFDischarge			AS PortOfDischarge
		,	i.ARInvoicePortEndShipmentText		AS FinalDestination
		,	i.ARInvoiceWaybillNumber			AS BillOfLadingNo
		,	STUFF((SELECT DISTINCT ',' + a.ARInvoiceItemShipNumber
					FROM #Items a
					FOR XML PATH('')), 1, 1, '') AS Vessel
		,	STUFF((SELECT DISTINCT ',' + a.ARInvoiceItemContainerNumber
					FROM #Items a
					FOR XML PATH('')), 1, 1, '') AS ContainerNumber
		,	STUFF((SELECT DISTINCT ',' + FORMAT(a.ARInvoiceItemETDDate, 'MM/dd/yyyy')
					FROM #Items a
					FOR XML PATH('')), 1, 1, '') AS ETD
		,	i.ARInvoicePONo						AS SaleOrderNo
		,	i.ARInvoiceSaleAgreement			AS PONo
		,	so.HTGiaoHang + ' ' + ISNULL(t.GETerminalName, '') AS PriceTerms
		,	N'VIETNAM'							AS CountryOfOrigin
		,	c.ARCustomerDeliveryContactName		AS ConsigneeName
		,	c.ARCustomerDeliveryAddressLine1	AS ConsigneeAddress
		,	c.ARCustomerPaymentContactName		AS NotifyName
		,	c.ARCustomerPaymentAddressLine1		AS NotifyAddress
		,	so.FSC								AS FSC
		,	''									AS BeneficiaryName
		,	so.BankName							AS BankName
		,	so.BankAddress						AS BankAddress
		,	so.BankSwiftCode					AS BankSwiftCode
		,	so.BankAccount						AS BankAccount
		,	so.PaymentTerm						AS PaymentTerm
		,	dbo.usp_fnNumToWords(round(i.ARInvoiceTotalAmount,2),'Y') as ReadTotalAmount
	FROM dbo.ARInvoices i
	LEFT JOIN dbo.ARCustomers c ON c.ARCustomerID = i.FK_ACObjectID AND i.ARObjectType = 'Customer'
	LEFT JOIN dbo.GETerminals t ON t.AAStatus = 'Alive' AND t.GETerminalID = i.FK_GETerminalID	
	OUTER APPLY
	(
		SELECT s.ARSaleOrderNo
			,	CASE WHEN mt.ICProductAttributeValue = 'FSC'
					THEN N'SGSHK-COC-370056'
					ELSE N'' 
				END										AS FSC
			,	ISNULL(b.CSCompanyBankName, '')			AS BankName
			,	ISNULL(b.CSCompanyBankAddress, '')		AS BankAddress
			,	ISNULL(b.CSCompanyBankSwiftCode, '')	AS BankSwiftCode
			,	ISNULL(b.CSCompanyBankAccount, '')		AS BankAccount
			,	ISNULL(ad.ADConfigText, '')				AS HTGiaoHang
			,	pt.GEPaymentTermName					AS PaymentTerm
		FROM dbo.ARSaleOrders s
		LEFT JOIN dbo.CSCompanyBanks b ON b.AAStatus = 'Alive' AND b.CSCompanyBankID = s.FK_CSCompanyBankID
		LEFT JOIN dbo.ICProductAttributes mt ON mt.AAStatus = 'Alive' AND mt.ICProductAttributeID = s.FK_ICProductAttributeTTMTID
		LEFT JOIN dbo.ADConfigValues ad ON ad.AAStatus = 'Alive' AND ad.ADConfigKeyGroup = 'ShippingType' AND ad.ADConfigKeyValue = s.ARShippingType
		LEFT JOIN dbo.GEPaymentTerms pt ON pt.AAStatus = 'Alive' AND pt.GEPaymentTermID = s.FK_GEPaymentTermID
		WHERE s.ARSaleOrderID = @SaleOrderID
	) AS so
	OUTER APPLY
	(
		SELECT SUM(t.ARInvoicePaymentAmount) AS deposit
		FROM dbo.ARInvoiceTransactions t
		WHERE t.AAStatus = 'Alive'
		AND t.ARInvoiceNo = i.ARInvoiceNo
		AND t.FK_ACObjectID = i.FK_ACObjectID
		AND t.ARObjectType = i.ARObjectType
		AND t.ARInvoicePaymentAmount > 0
	) AS de
	WHERE i.ARInvoiceID = @InvoiceID
	
	SELECT	a.Ten_Cong_Ty		AS TenCongTy
		,	a.Dia_Chi			AS DiaChi
		,	a.Dia_Chi_Giao_Hang AS DiaChiGiaoHang
		,	a.Mail				AS Email
		,	a.Website			AS Website
		,	a.SDT				AS Phone
		,	a.So_Fax			AS Fax
		,	a.Ma_So_Thue		AS MST
		,	N'+84-965 222 789'	AS Tel
	FROM dbo.ThongTinCty(1) a

	DROP TABLE #Items
END
