SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		Thinh Nguyen
-- Create date: 18/07/2016
-- Description:	Get Active purchase proposal item by user's permission
-- =============================================
ALTER PROCEDURE [dbo].[APProposalItems_GetActiveProposalItemByUserPermission]
	@userID			int,
	@moduleName		nvarchar(50),
	@permissionType nvarchar(50) 
		
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @moduleID INT

	SELECT	@moduleID = STModuleID 
	FROM	STModules 
	WHERE	AAStatus = 'Alive' 
		AND STModuleName = @moduleName

	DECLARE @permissionTable TABLE
	(
		BranchID INT
	)

	INSERT INTO @permissionTable 
		SELECT	FK_BRBranchID 
		FROM	ADDataViewPermissions
		WHERE	AAStatus = 'Alive' 
			AND FK_ADUserID = @userID
			AND FK_STModuleOrReportID = @moduleID
			AND ADDataViewPermissionType = @permissionType
			
	SELECT pit.APProposalItemProductQty as APProposalItemProductQtyOld
		,	(pit.APProposalItemProductQty - PurchaseOrderQty.Qty - ISNULL(pit.APProposalItemCanceledQty	,0)) AS APProposalItemProductQty
		,	(pit.APProposalItemWoodQty -
				(SELECT ISNULL(sum(poi.APPurchaseOrderItemWoodQty),0)- ISNULL(SUM(poi.APPurchaseOrderItemCanceledWoodQty) ,0)
					FROM APPurchaseOrderItems poi 
						INNER JOIN APPurchaseOrders po on po.APPurchaseOrderID  = poi.FK_APPurchaseOrderID
					WHERE po.AAStatus ='Alive'
						AND	poi.AAStatus ='Alive' 
						AND	po.APPurchaseOrderStatus <> 'Canceled'
						AND	poi.FK_APProposalItemID = pit.APProposalItemID)
					- ISNULL(pit.APProposalItemCanceledWoodQty	,0)) AS APProposalItemWoodQty
		,	p.APProposalNo as APProposalNo
		,	p.APProposalAPTypeCombo as APProposalAPTypeCombo
		,	PurchaseOrderQty.Qty AS APCancelPurchaseProposalItemPurchaseOrderQtyByNewAndPurchased
		,	(select ICProductType from ICProducts where ICProductID = pit.FK_ICProductID) as APProposalItemProductType
		,	ISNULL((select ADConfigText from ADConfigValues where ADConfigKeyGroup = 'PurchaseProposalType' and ADConfigKeyValue = p.APPurchaseProposalType),p.APPurchaseProposalType) as APPurchaseProposalTypeVN
		,   p.APPurchaseProposalType as APPurchaseProposalType
		,	vo.ACObjectName as ACObjectName
		,	pit.* 
	FROM	[dbo].[APProposalItems] pit (NOLOCK)
		INNER JOIN [dbo].[APProposals] p (NOLOCK) ON p.APProposalID = pit.FK_APProposalID
		LEFT JOIN V_ACObjects vo on p.FK_ACObjectID = vo.ACObjectID	AND p.APObjectType = vo.ACObjectType
		OUTER APPLY (SELECT ISNULL(sum(poi.APPurchaseOrderItemProductExchangeQty),0)- ISNULL(SUM(poi.APPurchaseOrderItemProductCanceledQty * poi.APPurchaseOrderItemProductFactor) ,0) AS Qty
					FROM APPurchaseOrderItems poi 
						INNER JOIN APPurchaseOrders po on po.APPurchaseOrderID  = poi.FK_APPurchaseOrderID
					WHERE	po.AAStatus ='Alive'
						AND	poi.AAStatus ='Alive' 
						AND	po.APPurchaseOrderStatus <> 'Canceled'
						AND	poi.FK_APProposalItemID = pit.APProposalItemID) AS PurchaseOrderQty
	WHERE	pit.AAStatus						=	'Alive'
		AND pit.APPurchaseProposalItemStatus	!=	'Canceled'
		AND	pit.APPurchaseProposalItemStatus	!= 'Purchased'
		AND	p.AAStatus							=	'Alive'
		AND	p.APPurchaseProposalStatus			NOT IN ('Canceled','New','Confirmed')
		AND	p.FK_BRBranchID in (SELECT BranchID FROM @permissionTable)
		AND (pit.APProposalItemProductQty - PurchaseOrderQty.Qty - ISNULL(pit.APProposalItemCanceledQty,0)) > 0
		AND NOT EXISTS (SELECT 1 
						FROM dbo.APCancelPurchaseProposalItems ppi 
							INNER JOIN dbo.APCancelPurchaseProposals pp ON pp.AAStatus = 'Alive' AND pp.APCancelPurchaseProposalID = ppi.FK_APCancelPurchaseProposalID
						WHERE ppi.AAStatus = 'Alive'
							AND pp.APCancelPurchaseProposalStatus = 'New'
							AND ppi.FK_APProposalItemID = pit.APProposalItemID)	
END



GO

