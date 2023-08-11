SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
ALTER PROCEDURE [dbo].[ACDocuments_GetDocumentListDatasetForFeePayment]
	@DocumentNo				nvarchar(50)	= null,
	@ACObjectID					int				= null,
	@ACObjectType				nvarchar(50)	= null,	
	@HREmployeeID				int				= null,
	@FromDate					datetime		= null,
	@ToDate						datetime		= null,
	@FK_BRBranchID				int				= null,
	@lotNo						nvarchar(50)    = NULL
WITH RECOMPILE
AS
BEGIN	
		SET NOCOUNT ON;

    SELECT			d.*
					, CASE WHEN d.ACDocumentFollowPosted = 1 THEN N'Đã phân bổ' ELSE N'Chưa phân bổ' END ACDocumentAllotment
					, obj.ACObjectName
    FROM			 ACDocuments		d	WITH(NOLOCK)
		LEFT JOIN	dbo.V_ACObjects obj	ON obj.ACObjectType = d.ACObjectType AND obj.ACObjectID=d.FK_ACObjectID
    WHERE d.AAStatus ='Alive'
		and (@DocumentNo is null or d.ACDocumentNo =@DocumentNo)
		and (@ACObjectID is null or d.FK_ACObjectID =@ACObjectID)
		and (@ACObjectType is null or d.ACObjectType =@ACObjectType)
		and (@HREmployeeID is null or d.FK_HREmployeeID =@HREmployeeID)
		and (@FromDate is null or DATEDIFF(DD,@FromDate,d.ACDocumentDate)>=0)
		and (@ToDate is null or DATEDIFF(DD,d.ACDocumentDate,@ToDate)>=0)
		and (@FK_BRBranchID is null or d.FK_BRBranchID = @FK_BRBranchID)
		and not exists (
			select 1 from APFeePaymentInvoices fpi WITH(NOLOCK)
			where fpi.AAStatus ='Alive'
				and fpi.FK_ACDocumentID =d.ACDocumentID
		)
		and NOT EXISTS
			(
			select 1 from ARFeePaymentCommissions fpc
			where fpc.AAStatus ='Alive'
				and fpc.FK_ACDocumentID =d.ACDocumentID)	
		and exists (
			select 1 from APFeePaymentFeeConfigs fpr WITH(NOLOCK)
			where fpr.AAStatus ='Alive'
				and fpr.FK_ACDocumentID = d.ACDocumentID
		) 
		and (@lotNo is null or exists (
						select 1 from APFeePaymentReceipts r
						inner join ICReceipts ir on ir.ICReceiptID = r.FK_ICReceiptID
						where r.AAStatus ='Alive'
						and ir.AAStatus= 'Alive'
						and r.FK_ACDocumentID = d.ACDocumentID
						and ir.ICReceiptPackNo = @lotNo
			))
		AND d.ACDocumentCreateFrom NOT IN ('NewNormal', 'NewPaymentCommission')
	END


GO

