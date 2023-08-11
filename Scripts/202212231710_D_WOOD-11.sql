-- Delete
DELETE STToolbarFunctions WHERE STToolbarID in (select FK_STToolbarID From ADTemplates a Join ADTemplateToolbars b On a.ADTemplateID = b.FK_ADTemplateID Where ADTemplateNo = 'RP_PrintReceiptInvoiceIn')
DELETE STToolbars WHERE STToolbarID in (select FK_STToolbarID From ADTemplateToolbars a Join ADTemplates b On a.FK_ADTemplateID = b.ADTemplateID Where ADTemplateNo = 'RP_PrintReceiptInvoiceIn')
DELETE ADTemplateToolbars WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PrintReceiptInvoiceIn')
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_PrintReceiptInvoiceIn')
DELETE ADTemplates WHERE ADTemplateNo = 'RP_PrintReceiptInvoiceIn'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_PrintReceiptInvoiceIn',N'Phiếu nhập kho',N'Phiếu nhập kho',N'RP_PrintReceiptInvoiceIn',N'Alive',N'',1
INSERT INTO STToolbars (AAStatus,STModuleID,STUserGroupID,STToolbarName,STToolbarDesc,STToolbarTag,STToolbarStyle,STToolbarCaption,STToolbarGroup,STToolbarOrder,STToolbarVisible,STToolbarPrivilege,STToolbarParentID,STToolbarImage) SELECT N'Alive',59,1,N'fld_barbtnPrintReceipt',N'Phiếu nhập kho',N'PrintReceipt',N'Default',N'Phiếu nhập kho',N'Utility',3,1,N'',4115,N''
INSERT INTO ADTemplateToolbars (FK_ADTemplateID,FK_STToolbarID) SELECT (Select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PrintReceiptInvoiceIn'),(select MAX(STToolbarID) From STToolbars)
INSERT INTO STToolbarFunctions (STToolbarFunctionIDString,STToolbarID,STToolbarFunctionName,STToolbarFunctionFullName,STToolbarFunctionClass,STToolbarFunctionSortOrder) SELECT N'',(select MAX(STToolbarID) From STToolbars),N'ActionPrintTemplate',N'Void ActionPrintTemplate()',N'BOSERP.Modules.InvoiceIn.InvoiceInModule',1
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'RP_PrintReceiptInvoiceIn') DROP PROCEDURE RP_PrintReceiptInvoiceIn
GO

CREATE PROCEDURE [dbo].[RP_PrintReceiptInvoiceIn]
	@STModulename Varchar(50),
	@FK_InvoiceInID int
AS
BEGIN
	
	SET NOCOUNT ON;

    select iv.APInvoiceInNo
			, iv.APInvoiceInSupplierNo
			, iv.APInvoiceInDate
			, iv.APInvoiceInVATDate
			, iv.APInvoiceInComment
			, r.ICReceiptNo
			, r.ICReceiptDate
			, r.ICReceiptDeliveryContactName
			, s.ICStockName
			, ri.ICReceiptItemProductName
			, p.ICProductNoOfOldSys
			, m.ICMeasureUnitName
			, po.APPurchaseOrderItemProductQty
			, ri.ICReceiptItemProductQty
			, ri.ICReceiptItemProductUnitCost
			, ri.ICReceiptItemTotalCost
			, tkNo.AccountNo as DebitAccountNo
			, tkCo.AccountNo as CreditAccountNo
			--,dbo.FConvertAmountToWord(round(ts.ACTransactionDebitAmount,0),'0',N' đồng') as BangChu
			,dbo.FConvertAmountToWord(round(r.ICReceiptSubTotalCost,0),' 0 ', cr.GECurrencyDesc) as BangChu
    from APInvoiceIns iv 
		inner join APInvoiceInItems ivi on iv.APInvoiceInID = ivi.FK_APInvoiceInID
		inner join ICReceiptItems ri on ri.ICReceiptItemID = ivi.FK_ICReceiptItemID
		inner join ICReceipts r on r.ICReceiptID = ri.FK_ICReceiptID
		left join GECurrencies cr on cr.AAStatus = 'Alive' and cr.GECurrencyID = r.FK_GECurrencyID
		left join ICStocks s on s.ICStockID = ri.FK_ICStockID
		left join ICMeasureUnits m on m.AAStatus = 'Alive' and m.ICMeasureUnitID = ri.FK_ICMeasureUnitID
		outer apply (
				Select ICProductNoOfOldSys from ICProducts
				Where AAStatus = 'Alive'
				and ICProductID = ri.FK_ICProductID
				) as p
		outer apply (
				Select APPurchaseOrderItemProductQty from APPurchaseOrderItems
				Where AAStatus = 'Alive'
				and APPurchaseOrderItemID = ri.FK_APPurchaseOrderItemID
				) as po
		OUTER APPLY
		(
			SELECT STUFF((SELECT DISTINCT ',' + db.ACAccountNo
					FROM [dbo].[ACTransactions] t	(NOLOCK)
					INNER JOIN dbo.ACAccounts db		(NOLOCK) ON db.AAStatus = 'Alive' AND db.ACAccountID = t.FK_ACAccountID
					WHERE t.AAStatus = 'Alive'
					AND t.ACTransactionNo = r.ICReceiptNo 
					AND t.ACTransactionReferenceID = r.ICReceiptID
					AND t.ACTransactionDebitExchangeAmount > 0
							FOR XML PATH('')), 1, 1, '') as AccountNo
		) AS tkNo
		OUTER APPLY
		(
			SELECT STUFF((SELECT DISTINCT ',' + db.ACAccountNo
					FROM [dbo].[ACTransactions] t	(NOLOCK)
					INNER JOIN dbo.ACAccounts db		(NOLOCK) ON db.AAStatus = 'Alive' AND db.ACAccountID = t.FK_ACOffsetAccountID
					WHERE t.AAStatus = 'Alive'
					AND t.ACTransactionNo = r.ICReceiptNo 
					AND t.ACTransactionReferenceID = r.ICReceiptID
					AND t.ACTransactionDebitExchangeAmount > 0
							FOR XML PATH('')), 1, 1, '') as AccountNo
		) AS tkCo
		--inner join APSuppliers	s on iv.FK_APSupplierID = s.APSupplierID
    where		
		iv.AAStatus = 'Alive'  and ivi.AAStatus='Alive'  and ri.AAStatus ='Alive' and r.AAStatus = 'Alive'
		and iv.APInvoiceInID = @FK_InvoiceInID

	Select * from ThongTinCty(1)
END

