SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO

-- =============================================
-- Author:  Thao Nguyen
-- Create date: 10/02/2014
-- Description: Get invoices for receipt by user's permission
-- =============================================
ALTER PROCEDURE [dbo].[APInvoiceIns_GetInvoicesForReceiptByUserPermission]
 @userID int,
 @moduleName nvarchar(50),
 @permissionType nvarchar(50) 
AS
BEGIN 
 SET NOCOUNT ON;

    declare @moduleID int

 select @moduleID = STModuleID 
 from STModules 
 where AAStatus = 'Alive' 
   and STModuleName = @moduleName

 declare @permissionTable table
 (
  BranchID int
 )

 insert into @permissionTable 
  select FK_BRBranchID 
  from ADDataViewPermissions
  where AAStatus = 'Alive' 
    and FK_ADUserID = @userID
    and FK_STModuleOrReportID = @moduleID
    and ADDataViewPermissionType = @permissionType

 select	 bol.APBillOfLadingID,
		 ii.*,
   (SELECT STUFF((
            SELECT ',' + po.APPurchaseOrderNo
            FROM dbo.APPurchaseOrders po
				INNER JOIN dbo.APInvoiceInItems iii ON iii.FK_APPurchaseOrderID = po.APPurchaseOrderID
			WHERE po.AAStatus = 'Alive'
				AND iii.AAStatus = 'Alive'
				AND iii.FK_APInvoiceInID = ii.APInvoiceInID
			GROUP BY po.APPurchaseOrderNo
            FOR XML PATH('')
            ), 1, 1, '')) AS APPurchaseOrderNo,
   vo.ACObjectName as ACObjectName
  from [dbo].[APInvoiceIns] ii WITH(NOLOCK)
   left join V_ACObjects vo on ii.FK_ACAssObjectID = vo.ACObjectID
    and ii.APAssObjectType = vo.ACObjectType
   OUTER APPLY	(SELECT APBillOfLadingID FROM dbo.APBillOfLadings bol
						 WHERE bol.FK_APInvoiceInID = ii.APInvoiceInID AND bol.AAStatus = 'Alive'
					) AS bol
  where ii.AAStatus = 'Alive'
  and  (ii.APInvoiceInStatus in('Completed', 'Incompleted'))
  and  ii.APInvoiceInType not in ('Service')
  and  ii.FK_BRBranchID in (select BranchID from @permissionTable)
  and  (select COUNT(APInvoiceInItemID) 
     from APInvoiceInItems iii  WITH(NOLOCK)
     inner join APInvoiceIns i  WITH(NOLOCK)
     on iii.FK_APInvoiceInID = i.APInvoiceInID
     where i.APInvoiceInID = ii.APInvoiceInID
     and iii.APInvoiceInItemProductType not in('Work','Service')
     and iii.APInvoiceInItemProductQty - iii.APInvoiceInItemReceiptedQty > 0) > 0
  and   (
				ii.APInvoiceInChannel = 'HinterLand'
			OR
				EXISTS (SELECT APBillOfLadingID FROM dbo.APBillOfLadings bol WHERE bol.FK_APInvoiceInID = ii.APInvoiceInID AND bol.AAStatus = 'Alive')
		)

 
END


GO
