SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO




ALTER PROCEDURE [dbo].[Shipment_Print001]
	@STModuleName VARCHAR(50), 
	@APInvoiceInID INT
AS
BEGIN
	SET NOCOUNT ON;
	--declare @id int;
	--set @id = (Select item.ICShipmentItemID 
	--		   from ICShipmentItems item 
	--				join ICShipments i on item.FK_ICShipmentID= i.ICShipmentID
	--			where i.ICShipmentID = @APInvoiceInID)
    -- Master
select
	m.ICShipmentNo
	,m.ICShipmentDate
	,m.ICShipmentName
	,m.ICShipmentDeliveryContactName
	,m.ICShipmentDesc
	,hr.HREmployeeName
	,m.ICShipmentExchangeRate
	,m.ICShipmentShippingExtraFees
	,cr.GECurrencyNo
	,ob.APSupplierName
	,m.ICShipmentCustomerName
	,m.ICShipmentDeliveryAddressLine1
	,m.ICOutputVATInvoiceNoCombo
	,m.ICShipmentSymbol
	,m.ICShipmentInvoiceDate
	,m.ICShipmentDeliveryDate
	,rs.ICImportAndExportReasonNo
	, (select ACDebitAccountNo from ACTransactionLedger (@STModuleName,@APInvoiceInID)) as ACDebitAccountNo
	,(select ACCreditAccountNo from ACTransactionLedger (@STModuleName,@APInvoiceInID)) as ACCreditAccountNo
	,dbo.FConvertAmountToWord((select sum (d.ICShipmentItemPrice) from ICShipmentItems d where d.FK_ICShipmentID = @APInvoiceInID and d.AAStatus ='Alive'),'0',N'đồng') as BangChu
	,m.ICShipmentContainerNumber
	,m.ICShipmentContainerSealNumber
	,m.ICShipmentTractorTrailerNumber
	,m.ICShipmentShipNumber
	,m.ICShipmentETDDate
	From ICShipments m 
	left join GECurrencies cr on m.FK_GECurrencyID =cr.GECurrencyID and cr.AAStatus ='Alive'
	left join HREmployees hr on m.FK_HREmployeeID = hr.HREmployeeID and hr.AAStatus ='Alive'
	left join HRDepartments dpt on hr.FK_HRDepartmentID =dpt.HRDepartmentID and dpt.AAStatus='Alive'
	left join HRLevels cb on hr.FK_HRLevelID = cb.HRLevelID and cb.AAStatus ='Alive'
	left join APSuppliers ob on m.FK_APSupplierID = ob.APSupplierID and ob.AAStatus ='Alive'
	left join ICImportAndExportReasons rs on rs.ICImportAndExportReasonID = m.FK_ICImportAndExportReasonID and rs.AAStatus ='Alive'
	where m.ICShipmentID = @APInvoiceInID
	-- Detail
	select  
		pr.ICProductNo
		,pr.ICProductName
		,pr.ICProductNoOfOldSys
		,pr.ICProductDesc
		,d.ICShipmentItemProductDesc
		,dvt.ICMeasureUnitName
		,kho.ICStockName
		,d.ICShipmentItemProductQty
		,d.ICShipmentItemProductFactor
		,d.ICShipmentItemProductExchangeQty
		,d.ICShipmentItemProductUnitCost
		,d.ICShipmentItemExchangeTotalCost
		,dpt.HRDepartmentName
		,d.ICShipmentItemLotNo
		,d.ICShipmentItemProductSerialNo
		,cc.ICProductIdentifiedEquipmentNo as [ICProductIdentifiedEquipmentNo]
		,cc.ICProductIdentifiedEquipmentDesc  
		,d.ICShipmentItemProductUnitPrice
		,d.ICShipmentItemTotalAmount as [ICShipmentItemRemainedAmount]
	From ICShipmentItems d
		left join ICProducts pr on d.FK_ICProductID = pr.ICProductID
		left join ICMeasureUnits  dvt on d.FK_ICMeasureUnitID =dvt.ICMeasureUnitID
		left join HRDepartments dpt on dpt.HRDepartmentID = d.FK_HRDepartmentID and dpt.AAStatus ='Alive'
		left join ICStocks kho on kho.ICStockID = d.FK_ICStockID
		left join ICProductIdentifiedEquipments cc on cc.ICProductIdentifiedEquipmentID = d.FK_ICProductIdentifiedEquipmentID and cc.AAStatus ='Alive'
	where d.FK_ICShipmentID = @APInvoiceInID and d.AAStatus ='Alive'

	--select top 1 
	--BRBranchContactAddressLine1
	--,BRBranchContactFax
	--,BRBranchCompanyName
	--,BRBranchContactPhone
	--, (select top 1 c.CSCompanyTaxNumber from CSCompanys c where c.CSCompanyID= 1) as CSCompanyTaxNumber
	--From BRBranchs b
	--where b.BRBranchID in (select FK_BRBranchID from ACDocuments where ACDocumentID = @APInvoiceInID)
	select * from dbo.ThongTinCty(1)
	-- exec Shipment_Print001 'Shipment','283'
END

GO

