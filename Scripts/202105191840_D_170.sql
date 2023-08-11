-- Delete
DELETE STToolbarFunctions WHERE STToolbarID in (select FK_STToolbarID From ADTemplates a Join ADTemplateToolbars b On a.ADTemplateID = b.FK_ADTemplateID Where ADTemplateNo = 'RP_PaymentProposal')
DELETE STToolbars WHERE STToolbarID in (select FK_STToolbarID From ADTemplateToolbars a Join ADTemplates b On a.FK_ADTemplateID = b.ADTemplateID Where ADTemplateNo = 'RP_PaymentProposal')
DELETE ADTemplateToolbars WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PaymentProposal')
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_PaymentProposal')
DELETE ADTemplates WHERE ADTemplateNo = 'RP_PaymentProposal'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_PaymentProposal',N'Phiếu đề nghị thanh toán',N'Phiếu đề nghị thanh toán',N'RP_PrintPaymentProposal',N'Alive',N'',1
INSERT INTO STToolbars (AAStatus,STModuleID,STUserGroupID,STToolbarName,STToolbarDesc,STToolbarTag,STToolbarStyle,STToolbarCaption,STToolbarGroup,STToolbarOrder,STToolbarVisible,STToolbarPrivilege,STToolbarParentID,STToolbarImage) SELECT N'Alive',742,1,N'fld_barbtnPrint',N'',N'Print',N'Default',N'In',N'Utility',1,1,N'',0,N''
INSERT INTO ADTemplateToolbars (FK_ADTemplateID,FK_STToolbarID) SELECT (Select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PaymentProposal'),(select MAX(STToolbarID) From STToolbars)
INSERT INTO STToolbarFunctions (STToolbarFunctionIDString,STToolbarID,STToolbarFunctionName,STToolbarFunctionFullName,STToolbarFunctionClass,STToolbarFunctionSortOrder) SELECT N'',(select MAX(STToolbarID) From STToolbars),N'ActionPrintTemplate',N'void ActionPrintTemplate()',N'BOSERP.Modules.PaymentProposal.PaymentProposalModule',1
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'RP_PrintPaymentProposal') DROP PROCEDURE RP_PrintPaymentProposal
GO

-- =============================================
-- =============================================

CREATE PROCEDURE [dbo].[RP_PrintPaymentProposal]
	@STModuleName VARCHAR(50), 
	@APPaymentProposalID INT
AS
BEGIN
	SET NOCOUNT ON;
    -- Master

	SELECT 
		pp.APPaymentProposalNo
		,pp.APPaymentProposalDate
		,lv.HRLevelName
		,pb.HRDepartmentName
		,hr.HREmployeeName
		,pp.APPaymentProposalDesc
		,pp.APPaymentProposalTotalAmount
		,ob.ACObjectName
		,ob.ACObjectBankName
		,ob.ACObjectBankAccount1
		,dbo.FConvertAmountToWord(pp.APPaymentProposalTotalAmount,' 0 ',c.GECurrencyDesc) as BangChu
		,paymentMethod.ADConfigText AS PaymentMethod
		,c.GECurrencyNo
	FROM dbo.APPaymentProposals pp
		LEFT JOIN dbo.HREmployees hr ON hr.HREmployeeID = pp.FK_HREmployeeID
		LEFT JOIN dbo.HRLevels lv ON lv.HRLevelID = hr.FK_HRLevelID
		LEFT JOIN dbo.HRDepartments pb ON pb.HRDepartmentID = hr.FK_HRDepartmentID
		LEFT JOIN dbo.V_ACObjects ob ON pp.FK_ACObjectID = ob.ACObjectID AND pp.APObjectType = ob.ACObjectType
		LEFT JOIN dbo.GECurrencies c ON c.GECurrencyID = pp.FK_GECurrencyID AND c.AAStatus = 'Alive'
		OUTER APPLY
			(
				SELECT ADConfigText FROM  dbo.ADConfigValues
				WHERE ADConfigKeyGroup = 'PaymentProposalPaymentMethod'
				AND ADConfigKeyValue = pp.APPaymentProposalPaymentMethodCombo
				) AS paymentMethod
	WHERE APPaymentProposalID = @APPaymentProposalID
		
	-- Detail
	SELECT 
		pp.APPaymentProposalDesc
		,cr.GECurrencyNo
		,cr.GECurrencyDesc
		,SUBSTRING(( SELECT ','+c.APPaymentProposalItemInvoiceInNo FROM dbo.APPaymentProposalItems c WHERE c.FK_APPaymentProposalID = @APPaymentProposalID ORDER BY c.APPaymentProposalItemInvoiceInNo FOR XML PATH ('')), 2, 1000) InvoiceNoList
	FROM dbo.APPaymentProposalItems ppi 
		LEFT JOIN dbo.APPaymentProposals pp ON pp.APPaymentProposalID = ppi.FK_APPaymentProposalID
		LEFT JOIN dbo.V_ACObjects ob ON pp.FK_ACObjectID = ob.ACObjectID AND pp.APObjectType = ob.ACObjectType
		LEFT JOIN dbo.GECurrencies cr ON cr.GECurrencyID = ppi.FK_GECurrencyID
	WHERE APPaymentProposalID = @APPaymentProposalID
		------------------------------
	SELECT * FROM dbo.ThongTinCty(1)
END




