SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		Thao Nguyen
-- Create date: 10/02/2014
-- Description:	Get receipts for fee payment by user's permission
-- =============================================
ALTER PROCEDURE [dbo].[ICReceipts_GetReceiptsForFeePaymentByUserPermission]
	@InvoiceInIDs NVARCHAR(max) = NULL,
	@userID int,
	@moduleName nvarchar(50),
	@permissionType nvarchar(50) 
AS
BEGIN	
	SET NOCOUNT ON;

	declare @moduleID int

	select	@moduleID = STModuleID 
	from	STModules 
	where	AAStatus = 'Alive' 
			and STModuleName = @moduleName

	declare @permissionTable table
	(
		BranchID int
	)
	DECLARE @InvoiceIn TABLE
	(
		APInvoiceInID INT
    )
	insert into @permissionTable 
		select	FK_BRBranchID 
		from	ADDataViewPermissions
		where	AAStatus = 'Alive' 
				and FK_ADUserID = @userID
				and FK_STModuleOrReportID = @moduleID
				and ADDataViewPermissionType = @permissionType
	INSERT INTO @InvoiceIn
	SELECT * FROM dbo.splitstring(@InvoiceInIDs)
    select	r.*
		,	(	select	s.APSupplierName
				from	[dbo].[APSuppliers] s
				where	s.AAStatus = 'Alive'
				and		s.APSupplierID = r.FK_APSupplierID
			)	as	APSupplierName
		, vo.ACObjectName AS ACAssObjectName
	from	[dbo].[ICReceipts] r
			LEFT JOIN dbo.V_ACObjects vo ON r.FK_ACAssObjectID = vo.ACObjectID
			AND r.ICAssObjectType = vo.ACObjectType
	where	r.AAStatus = 'Alive'
		and		r.ICReceiptTypeCombo = 'PurchaseReceipt'
		and		r.ICReceiptPostedStatus = 'Posted'
		and		r.ICReceiptStatus = 'Complete'
		AND		r.STToolbarActionName = 'FromPurchaseOrder'
		and		(
					r.FK_BRBranchID in (select BranchID from @permissionTable) or
					r.FK_BRTransferredBranchID in (select BranchID from @permissionTable) 
				)
		AND @InvoiceInIDs IS NULL		
union 
	select	r.*,
			(	select	s.APSupplierName
				from	[dbo].[APSuppliers] s
				where	s.AAStatus = 'Alive'
				and		s.APSupplierID = r.FK_APSupplierID
			)	as	APSupplierName
			, vo.ACObjectName AS ACAssObjectName
	from	ICReceipts r inner join MMBatchProducts bp on r.FK_MMBatchProductID = bp.MMBatchProductID
			LEFT JOIN dbo.V_ACObjects vo ON r.FK_ACAssObjectID = vo. ACObjectID
			AND r.ICAssObjectType = vo.ACObjectType
	where	r.AAStatus = 'Alive'
		and r.ICReceiptPostedStatus = 'Posted'
	and		bp.AAStatus = 'Alive'
	and		bp.FK_MMOperationID in (select MMOperationID from MMOperations where MMOperationNo = 'CD-110')
	and		r.ICReceiptStatus = 'Complete'
	and		bp.MMBatchProductStatus = 'Approved'
	and		(
				r.FK_BRBranchID in (select BranchID from @permissionTable) or
				r.FK_BRTransferredBranchID in (select BranchID from @permissionTable) 
			)
	
UNION
	 select	r.*
		,	(	select	s.APSupplierName
				from	[dbo].[APSuppliers] s
				where	s.AAStatus = 'Alive'
				and		s.APSupplierID = r.FK_APSupplierID
			)	as	APSupplierName
		, vo.ACObjectName AS ACAssObjectName
	from	[dbo].[ICReceipts] r
			LEFT JOIN dbo.V_ACObjects vo ON r.FK_ACAssObjectID = vo.ACObjectID
			AND r.ICAssObjectType = vo.ACObjectType
	where	r.AAStatus = 'Alive'
		and		r.ICReceiptTypeCombo = 'PurchaseReceipt'
		and		r.ICReceiptPostedStatus = 'Posted'
		and		r.ICReceiptStatus = 'Complete'
		AND		r.STToolbarActionName = 'FromInvoice'
		and		(
					r.FK_BRBranchID in (select BranchID from @permissionTable) or
					r.FK_BRTransferredBranchID in (select BranchID from @permissionTable) 
				)
		AND EXISTS
			(
				SELECT 1 FROM dbo.ICReceiptItems ri
					INNER JOIN dbo.APInvoiceIns ii ON ri.FK_APInvoiceInID = ii.APInvoiceInID
				WHERE ri.AAStatus = 'Alive'
				AND r.ICReceiptID = ri.FK_ICReceiptID
				AND ii.APInvoiceInID IN (SELECT APInvoiceInID FROM  @InvoiceIn)
				)
END


GO

