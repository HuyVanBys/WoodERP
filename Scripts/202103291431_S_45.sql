SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
ALTER PROCEDURE [dbo].[ARSaleOrderItems_GetSaleOrderItemForDeliveryPlansByUserPermission]
	@userID int,
	@moduleName nvarchar(50),
	@permissionType nvarchar(50),
	@ARSaleOrderItemDeliveryDateFrom datetime = null,
	@ARSaleOrderItemDeliveryDateTo datetime = null,
	@FK_ARSaleOrderID int = null,
	@FK_ARCustomerID int = null,
	@ARSaleOrderSaleAgreement nvarchar(50) = null,
	@FK_ARDeliveryPlanID int = null,
	@DeliveryPlanAddNewType nvarchar(50)
AS
BEGIN
	set nocount on;

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

	if @DeliveryPlanAddNewType <> 'Incomplete'
	   (select so.ARSaleOrderDeliveryAddressLine3
			, (CASE WHEN ps.ICProductSerieProductWidth IS NULL THEN p.ICProductWidth ELSE ps.ICProductSerieProductWidth END) AS ICProductWidth
			, (CASE WHEN ps.ICProductSerieProductLength IS NULL THEN p.ICProductLength ELSE ps.ICProductSerieProductLength END) AS ICProductLength
			, (CASE WHEN ps.ICProductSerieProductHeight IS NULL THEN p.ICProductHeight ELSE ps.ICProductSerieProductHeight END) AS ICProductHeight
			, so.ARSaleOrderNo
			, p.ICProductNo as ARSaleOrderItemProductNo
			,(soi.ARSaleOrderItemProductQty - isnull(soi.ARSaleOrderItemCanceledQty,0) - isnull(soi.ARSaleOrderItemPlanQty,0)) as ARSaleOrderItemProductQty
			, so.FK_ARCustomerID
			, so.ARSaleOrderComment
			, so.ARSaleOrderInternalComment
			, c.ARCustomerPaymentAddressWard as ARCustomerDeliveryAddressWard
			, c.ARCustomerDeliveryAddressStreet
			, c.FK_GEDeliveryDistrictID
			, c.FK_GEDeliveryStateProvinceID
			, bpi.FK_MMBatchProductID
			, soi.*
			, IsNull(v.ACObjectName,'') as ACObjectName
			, IsNull(p.ICProductTemplateType,'') as	ARSaleOrderItemProductTemplateType
			, so.ARSaleOrderSaleAgreement
			, IsNull(v.ACObjectID,'') as FK_ACObjectID
			, IsNull(v.ACObjectType,'') as ARObjectType
			, (SELECT b.BRBranchName FROM dbo.BRBranchs b WHERE b.BRBranchID = so.FK_BRBranchID) AS BRBranchName
			, so.FK_PMTemplateID
			, so.FK_PMProjectID
			, so.FK_ARSaleContractID
			, so.ARSaleOrderProductType
			, (SELECT PMTemplateItemProductName FROM dbo.PMTemplateItems WHERE AAStatus ='Alive' AND PMTemplateItemID = soi.FK_PMTemplateItemID) AS PMTemplateItemProductName
			, soi.FK_ARProposalTemplateItemID
			, (SELECT ARProposalTemplateItemProductName FROM dbo.ARProposalTemplateItems WHERE ARProposalTemplateItemID = soi.FK_ARProposalTemplateItemID AND AAStatus = 'Alive') AS ARProposalTemplateItemProductName
		from ARSaleOrderItems soi
			inner join ARSaleOrders so on soi.FK_ARSaleOrderID = so.ARSaleOrderID
			inner join ICProducts p on soi.FK_ICProductID = p.ICProductID
			left join ARCustomers c on so.FK_ACObjectID = c.ARCustomerID
			left join V_ACObjects v on so.FK_ACObjectID = v.ACObjectID and so.ARObjectType = v.ACObjectType
			OUTER APPLY
			(
				SELECT TOP 1 ps.ICProductSerieProductWidth,
					         ps.ICProductSerieProductHeight,
							 ps.ICProductSerieProductLength
				FROM dbo.ICProductSeries ps
				WHERE soi.FK_ICProductSerieID = ps.ICProductSerieID 
				AND ps.AAStatus = 'Alive'
			) ps
			OUTER APPLY
			(
				SELECT TOP 1 bpi.FK_MMBatchProductID
				FROM dbo.MMBatchProductItems bpi
				WHERE bpi.FK_ARSaleOrderItemID = soi.ARSaleOrderItemID 
				AND bpi.AAStatus = 'Alive'
			) bpi
			OUTER APPLY
			(select SUM(dpi.ARDeliveryPlanItemCancelQty) AS canceledQty
							from ARDeliveryPlanItems dpi
								inner join ARDeliveryPlans dp on dpi.FK_ARDeliveryPlanID = dp.ARDeliveryPlanID AND dp.AAStatus = 'Alive'
								inner join ARSaleOrderItems soi2 on dpi.FK_ARSaleOrderItemID = soi.ARSaleOrderItemID AND soi2.AAStatus =	'Alive'
							where dpi.AAStatus = 'Alive'
								and soi2.ARSaleOrderItemID = soi.ARSaleOrderItemID
								and dp.ARDeliveryPlanType = 'Day'
								and dpi.ARDeliveryPlanItemReferenceID = 0
			) AS canceledDeliveryPlan
		where soi.AAStatus =	'Alive'
			and so.AAStatus = 'Alive'
			and soi.ARSaleOrderItemIsDeliveryPlan = 1
			and so.ARSaleOrderStatus in ('Confirmed','Incomplete')
			and DATEDIFF(DAY,@ARSaleOrderItemDeliveryDateFrom,so.ARSaleOrderDeliveryActualDate) >= 0
			and DATEDIFF(DAY,so.ARSaleOrderDeliveryActualDate,@ARSaleOrderItemDeliveryDateTo) >= 0
			and (@FK_ARSaleOrderID is null or so.ARSaleOrderID = @FK_ARSaleOrderID)
			and (@FK_ARCustomerID is null or so.FK_ARCustomerID = @FK_ARCustomerID)
			and (@ARSaleOrderSaleAgreement is null or so.ARSaleOrderSaleAgreement like N'%'+@ARSaleOrderSaleAgreement+'%')
			and	so.FK_BRBranchID in (select BranchID from @permissionTable)
			and (soi.ARSaleOrderItemProductQty - isnull(soi.ARSaleOrderItemCanceledQty,0) - isnull(soi.ARSaleOrderItemPlanQty,0)) > 0
			AND p.ICProductType NOT IN ('Service','Work')
			and (soi.ARSaleOrderItemProductQty - isnull(soi.ARSaleOrderItemCanceledQty,0) - isnull(soi.ARSaleOrderItemShippedQty,0)) > 0
		)
	
	else
		select distinct 
			so.ARSaleOrderDeliveryAddressLine3
			, (CASE WHEN ps.ICProductSerieProductWidth IS NULL THEN p.ICProductWidth ELSE ps.ICProductSerieProductWidth END) AS ICProductWidth
			, (CASE WHEN ps.ICProductSerieProductLength IS NULL THEN p.ICProductLength ELSE ps.ICProductSerieProductLength END) AS ICProductLength
			, (CASE WHEN ps.ICProductSerieProductHeight IS NULL THEN p.ICProductHeight ELSE ps.ICProductSerieProductHeight END) AS ICProductHeight
			, so.ARSaleOrderNo
			, p.ICProductNo as ARSaleOrderItemProductNo
			, Isnull((Isnull(dpi.ARDeliveryPlanItemProductQty,0) - Isnull(dpi.ARDeliveryPlanItemCancelQty,0) - Isnull(dpi.ARDeliveryPlanItemShipmentQty,0)),0) as ARSaleOrderItemProductQty
			, so.FK_ARCustomerID
			, so.ARSaleOrderComment
			, so.ARSaleOrderInternalComment
			, dpi.ARDeliveryPlanItemDeliveryAddressStreet as ARCustomerDeliveryAddressStreet 
			, dpi.ARDeliveryPlanItemDeliveryAddressWard as ARCustomerDeliveryAddressWard
			, dpi.FK_GEDeliveryDistrictID as FK_GEDeliveryDistrictID
			, dpi.FK_GEDeliveryStateProvinceID as FK_GEDeliveryStateProvinceID
			, bpi.FK_MMBatchProductID
			, soi.*
			, v.ACObjectName
			, IsNull(p.ICProductTemplateType,'') as	ARSaleOrderItemProductTemplateType
			, so.ARSaleOrderSaleAgreement
			, IsNull(v.ACObjectID,'') as FK_ACObjectID
			, IsNull(v.ACObjectType,'') as ARObjectType
			,(SELECT b.BRBranchName FROM dbo.BRBranchs b WHERE b.BRBranchID = so.FK_BRBranchID) AS BRBranchName
			, so.FK_PMTemplateID
			, so.FK_PMProjectID
			, so.FK_ARSaleContractID
			, so.ARSaleOrderProductType
			, (SELECT PMTemplateItemProductName FROM dbo.PMTemplateItems WHERE AAStatus ='Alive' AND PMTemplateItemID = soi.FK_PMTemplateItemID) AS PMTemplateItemProductNam
			, soi.FK_ARProposalTemplateItemID
			, (SELECT ARProposalTemplateItemProductName FROM dbo.ARProposalTemplateItems WHERE ARProposalTemplateItemID = soi.FK_ARProposalTemplateItemID AND AAStatus = 'Alive') AS ARProposalTemplateItemProductName
		from ARDeliveryPlanItems dpi 
			inner join ARDeliveryPlans dp on dpi.FK_ARDeliveryPlanID = dp.ARDeliveryPlanID
			inner join ARSaleOrderItems soi on dpi.FK_ARSaleOrderItemID = soi.ARSaleOrderItemID
			inner join ARSaleOrders so on soi.FK_ARSaleOrderID = so.ARSaleOrderID
			inner join ICProducts p on soi.FK_ICProductID = p.ICProductID
			left join V_ACObjects v on so.FK_ACObjectID = v.ACObjectID and so.ARObjectType = v.ACObjectType
			OUTER APPLY
			(
				SELECT TOP 1 ps.ICProductSerieProductWidth,
					         ps.ICProductSerieProductHeight,
							 ps.ICProductSerieProductLength
				FROM dbo.ICProductSeries ps
				WHERE soi.FK_ICProductSerieID = ps.ICProductSerieID 
				AND ps.AAStatus = 'Alive'
			) ps
			OUTER APPLY
			(
				SELECT TOP 1 bpi.FK_MMBatchProductID
				FROM dbo.MMBatchProductItems bpi
				WHERE bpi.FK_ARSaleOrderItemID = dpi.FK_ARSaleOrderItemID 
				AND bpi.AAStatus = 'Alive'
			) bpi
		where soi.AAStatus =	'Alive'
			and so.AAStatus = 'Alive'
			and soi.ARSaleOrderItemIsDeliveryPlan = 1
			and so.ARSaleOrderStatus in ('Confirmed','Incomplete')
			and DATEDIFF(DAY,@ARSaleOrderItemDeliveryDateFrom,so.ARSaleOrderDeliveryActualDate) >= 0
			and DATEDIFF(DAY,so.ARSaleOrderDeliveryActualDate,@ARSaleOrderItemDeliveryDateTo) >= 0
			and (@FK_ARSaleOrderID is null or so.ARSaleOrderID = @FK_ARSaleOrderID)
			and (@FK_ARCustomerID is null or so.FK_ARCustomerID = @FK_ARCustomerID)
			and (@FK_ARDeliveryPlanID is null or dpi.FK_ARDeliveryPlanID = @FK_ARDeliveryPlanID)
			and (@ARSaleOrderSaleAgreement is null or so.ARSaleOrderSaleAgreement like N'%'+@ARSaleOrderSaleAgreement+'%')
			and	so.FK_BRBranchID in (select BranchID from @permissionTable)
			and Isnull((Isnull(dpi.ARDeliveryPlanItemProductQty,0) - Isnull(dpi.ARDeliveryPlanItemCancelQty,0) - Isnull(dpi.ARDeliveryPlanItemShipmentQty,0)),0) > 0
			AND p.ICProductType NOT IN ('Service','Work')


END








GO

