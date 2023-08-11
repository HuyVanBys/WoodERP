SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
-- =============================================
-- Edit: DANG NHI
-- Edit date: 09/04/2020
-- Description:	Get purchase order item by purchase oder id
-- =============================================

ALTER PROCEDURE [dbo].[RP_PrintReceiptVoucher]
	@STModuleName VARCHAR(50), 
	@APInvoiceInID INT
AS
BEGIN
	SET NOCOUNT ON;
    -- Master
select
	m.ARReceiptVoucherNo
	,m.ARReceiptVoucherDate
	,m.ARReceiptVoucherName
	,m.ARReceiptVoucherDesc
	,m.ARReceiptVoucherSenderName
	,hr.HREmployeeName
	,vo.ACObjectContactAddressLine3
	,m.ARReceiptVoucherTotalAmount
	,m.ARReceiptVoucherExchangeRate
	,m.ARReceiptVoucherExchangeAmount
	,dpt.HRDepartmentName
	,cb.HRLevelName
	,vo.ACObjectContactPhone
	--,(select sum(mi.ARReceiptVoucherItemAmount) from ARReceiptVoucherItems mi where mi.FK_ARReceiptVoucherID = m.ARReceiptVoucherID ) as ARReceiptVoucherItemAmount
	--,(select sum(mi.ARReceiptVoucherItemExchangeAmount) from ARReceiptVoucherItems mi where mi.FK_ARReceiptVoucherID = m.ARReceiptVoucherID ) as ARReceiptVoucherItemExchangeAmount
	--,dbo.FConvertAmountToWord(round((select sum(mi.ARReceiptVoucherItemAmount) from ARReceiptVoucherItems mi where mi.FK_ARReceiptVoucherID = m.ARReceiptVoucherID ),0),'0', cr.GECurrencyDesc) as BangChu
	,vo.ACObjectName
	, (select ACDebitAccountNo from ACTransactionLedger (@STModuleName,@APInvoiceInID)) as ACDebitAccountNo
	,(select ACCreditAccountNo from ACTransactionLedger (@STModuleName,@APInvoiceInID)) as ACCreditAccountNo
	,cr.GECurrencyNo
	,dbo.FConvertAmountToWord(round(m.ARReceiptVoucherTotalAmount,2),'0',cr.GECurrencyDesc) as BangChu
	From ARReceiptVouchers m 
	left join GECurrencies cr on m.FK_GECurrencyID =cr.GECurrencyID and cr.AAStatus ='Alive'
	left join HREmployees hr on m.FK_HREmployeeID = hr.HREmployeeID and hr.AAStatus ='Alive'
	left join HRDepartments dpt on hr.FK_HRDepartmentID =dpt.HRDepartmentID and dpt.AAStatus='Alive'
	left join HRLevels cb on hr.FK_HRLevelID = cb.HRLevelID and cb.AAStatus ='Alive'
	LEFT JOIN dbo.V_ACObjects vo ON vo.ACObjectID = m.FK_ACObjectID AND vo.ACObjectType = m.ARObjectType
	where m.ARReceiptVoucherID = @APInvoiceInID
		and m.ARReceiptVoucherStatus != 'New'
	--Thông tin công ty
select * FROM dbo.ThongTinCty(1)
END

GO

