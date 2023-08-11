-- Delete
DELETE STToolbarFunctions WHERE STToolbarID in (select FK_STToolbarID From ADTemplates a Join ADTemplateToolbars b On a.ADTemplateID = b.FK_ADTemplateID Where ADTemplateNo = 'RP_PurchaseProposalGeneralMaterial')
DELETE STToolbars WHERE STToolbarID in (select FK_STToolbarID From ADTemplateToolbars a Join ADTemplates b On a.FK_ADTemplateID = b.ADTemplateID Where ADTemplateNo = 'RP_PurchaseProposalGeneralMaterial')
DELETE ADTemplateToolbars WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PurchaseProposalGeneralMaterial')
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_PurchaseProposalGeneralMaterial')
DELETE ADTemplates WHERE ADTemplateNo = 'RP_PurchaseProposalGeneralMaterial'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_PurchaseProposalGeneralMaterial',N'Phiếu đề nghị mua vật tư',N'Phiếu đề nghị mua vật tư',N'RP_PurchaseProposalGeneralMaterial',N'Alive',N'',0
INSERT INTO STToolbars (AAStatus,STModuleID,STUserGroupID,STToolbarName,STToolbarDesc,STToolbarTag,STToolbarStyle,STToolbarCaption,STToolbarGroup,STToolbarOrder,STToolbarVisible,STToolbarPrivilege,STToolbarParentID,STToolbarImage) SELECT N'Alive',91,1,N'fld_barbtnPrintRP_PurchaseProposalGeneralMaterial',N'Phiếu đề nghị mua vật tư',N'PrintRP_PurchaseProposalGeneralMaterial',N'Default',N'Phiếu đề nghị mua vật tư',N'Utility',5,1,N'',3319,N''
INSERT INTO ADTemplateToolbars (FK_ADTemplateID,FK_STToolbarID) SELECT (Select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PurchaseProposalGeneralMaterial'),(select MAX(STToolbarID) From STToolbars)
INSERT INTO STToolbarFunctions (STToolbarFunctionIDString,STToolbarID,STToolbarFunctionName,STToolbarFunctionFullName,STToolbarFunctionClass,STToolbarFunctionSortOrder) SELECT N'',(select MAX(STToolbarID) From STToolbars),N'ActionPrintTemplate',N'Void ActionPrintTemplate()',N'BOSERP.Modules.PurchaseProposal.PurchaseProposalModule',1
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'RP_PurchaseProposalGeneralMaterial') DROP PROCEDURE RP_PurchaseProposalGeneralMaterial
GO

CREATE PROCEDURE [dbo].[RP_PurchaseProposalGeneralMaterial]
	@STModuleName VARCHAR(50),
	@FK_APProposalID		INT
AS
BEGIN	
	SET NOCOUNT ON;

	SELECT	
		psi.APProposalItemID,
		ps.APProposalNo,
		ps.APProposalDate,
		ps.APProposalDesc,
		ps.APProposalNeedTime,
		ps.APProposalComment,
		ps.APProposalNeedToTime,
		psi.APProposalItemNeedTime,
		psi.APProposalItemNeedToTime,
		dr.HRDepartmentRoomName,
		hr.HREmployeeName,
		hr.HREmployeeTel1,
		hr.HREmployeeEmail1,
		cv.HRLevelName,
		CASE WHEN cv.HRLevelID = 7 THEN hr.HREmployeeName ELSE '' END AS TruongBoPhan,
		CASE WHEN cv.HRLevelID = 3 THEN hr.HREmployeeName ELSE '' END AS GiamDoc,
		p.ICProductID,
		p.ICProductName,
		p.ICProductNo,
		p.ICProductLength,
		p.ICProductWidth,
		p.ICProductHeight,
		psi.APProposalItemComment,
		psi.APProposalItemProductQty,
		cast(0 as decimal(18,5)) as ICInventoryStockQty,
		m.ICMeasureUnitName,
		p.ICProductOtherSize,
		b.BRBranchName,
		bp.MMBatchProductNo
	into #result
	FROM	[dbo].[APProposalItems]	psi														INNER JOIN
			[dbo].[APProposals]		ps	ON	psi.FK_APProposalID	= ps.APProposalID			INNER JOIN
			[dbo].[MMBatchProducts] bp ON bp.MMBatchProductID = psi.FK_MMBatchProductID     LEFT JOIN
			[dbo].[BRBranchs]		b	ON  ps.FK_BRBranchID	= b.BRBranchID				LEFT JOIN
			[dbo].[HRDepartmentRooms] dr ON dr.HRDepartmentRoomID = ps.FK_HRDepartmentRoomID LEFT JOIN 
			dbo.HREmployees hr ON ps.FK_HREmployeeID = hr.HREmployeeID						LEFT JOIN
			dbo.V_ACObjects v on v.ACObjectID = ps.FK_ACObjectID AND v.ACObjectType = ps.APObjectType LEFT JOIN
            dbo.ICProducts p on psi.FK_ICProductID = p.ICProductID						left JOIN 
			dbo.ICMeasureUnits m ON psi.FK_ICMeasureUnitID = m.ICMeasureUnitID            LEFT JOIN 
			dbo.HRLevels cv ON cv.HRLevelID = hr.FK_HRLevelID
	WHERE	psi.AAStatus	=	'Alive'
	AND		ps.AAStatus		=	'Alive'
	AND		psi.FK_APProposalID	= @FK_APProposalID
	AND		psi.APPurchaseProposalItemStatus<>'Canceled'
	ORDER BY psi.APProposalItemSortOrder ASC

--Update ICInventoryStockQty
	Create table #SanPham
	(
		ICProductID int,
		Qty decimal(18,5)
		)
	Insert into #SanPham
	Select Distinct ICProductID, 0
	from #result

	Declare @proposalItemID int, @productID int 
	Declare cur_Update Cursor for 
	Select APProposalItemID, ICProductID from #result
	open cur_Update
	Fetch next from cur_Update into @proposalItemID, @productID
	WHILE @@FETCH_STATUS = 0
	BEGIN 
		Declare @Qty decimal(18,5)
		Set @Qty = dbo.[FGetInventoryStockQty](null, @productID, null,GetDate())

		Update rs
		Set rs.ICInventoryStockQty = @Qty - sp.Qty
		from #result rs
		inner join #SanPham sp on rs.ICProductID = sp.ICProductID
		Where rs.APProposalItemID = @proposalItemID

		Update sp
		Set sp.Qty = rs.APProposalItemProductQty
		from #result rs
		inner join #SanPham sp on rs.ICProductID = sp.ICProductID
		Where rs.APProposalItemID = @proposalItemID

		Fetch next from cur_Update into @proposalItemID, @productID
	END
	Close cur_Update
	Deallocate cur_Update

	Select * from #result
	drop table #result
	drop table #SanPham
-----Company info
	SELECT * FROM dbo.ThongTinCty(1)


END


Completion time: 2022-10-18T16:36:07.6582971+07:00
