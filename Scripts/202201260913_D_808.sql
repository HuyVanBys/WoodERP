update dbo.STFieldFormats SET STFieldFormatGroupID = (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPriceByCurrency') WHERE STFieldFormatColumnName in 
('ACLoanReceiptAmount','ACLoanReceiptExchangeAmount','ACLoanReceiptOpeningPaidAmount','ACLoanReceiptPaidAmount','ACLoanReceiptRemainAmount','ACLoanReceiptPaymentForMonth','ACLoanReceiptItemTotalAmount'
,'ACLoanReceiptPayDocTotalAmount','ACLoanReceiptPayDocsDebtRootPaid','ACLoanReceiptPayDocsInterestPaid','ACLoanReceiptPayDocsPenaltyPaid','ACLoanReceiptPaymentPlanOpeningBalance'
,'ACLoanReceiptPaymentPlanRootPayment','ACLoanReceiptPaymentPlanProfitsPayment','ACLoanReceiptPaymentPlanPayment','ACLoanReceiptPaymentPlanActualRootPayment','ACLoanReceiptPaymentPlanActialProfitsPayment')
GO

update dbo.STFieldFormats SET STFieldFormatGroupID = (SELECT STFieldFormatGroupID FROM dbo.STFieldFormatGroups WHERE STFieldFormatGroupName = 'FormatGroupPriceByCurrency')  
WHERE STFieldFormatColumnName in 
('ACLoanAgreementTotalLimit','ACLoanAgreementAmount','ACLoanAgreementReceiptAmount','ACLoanAgreementLCLimit','ACLoanAgreementRemainAmount')
AND STFieldFormatTableName = 'ACLoanAgreements'

update dbo.AAColumnAlias SET AADisplayedMember = 'ACAssetNo' WHERE AATableName = 'ACDepreciationAssetTrans' AND AAColumnAliasName = 'FK_ACAssetID'
GO
