SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		<Loc Truong>
-- Create date: <30/07/2018>
-- Description:	<Get InvoiceIn For FeePayment>
-- =============================================
ALTER PROCEDURE [dbo].[APInvoiceIns_GetInvoiceInForFeePayment]
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

	insert into @permissionTable 
		select	FK_BRBranchID 
		from	ADDataViewPermissions
		where	AAStatus = 'Alive' 
				and FK_ADUserID = @userID
				and FK_STModuleOrReportID = @moduleID
				and ADDataViewPermissionType = @permissionType
	
    SELECT ii.*
    ,	vo.ACObjectName AS	ACObjectName
    FROM APInvoiceIns ii
    LEFT JOIN dbo.V_ACObjects vo ON vo.ACObjectID = ii.FK_ACAssObjectID
			AND vo.ACObjectType = ii.APAssObjectType
    WHERE ii.AAStatus ='Alive'
	and EXISTS (select 1 from ACTransactions where ACTransactionReferenceNo = ii.APInvoiceInNo )
    and ii.APInvoiceInChannel = 'Import'
    and		(
				ii.FK_BRBranchID in (select BranchID from @permissionTable)
			)
  --  AND NOT EXISTS
		--(
		--	SELECT 1 FROM  dbo.APFeePaymentInvoiceIns
		--	WHERE ii.APInvoiceInID = FK_APInvoiceInID
		--	AND AAStatus = 'Alive'
		--	)
END

GO
