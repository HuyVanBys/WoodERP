SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		<Bys Tan Hoa>
-- Editor:		Luan Tran
-- Copy:		Nhi Dang <07/04/2020>
-- Create date: <2020/02/11>
-- Description:	<Proposal>
-- =============================================
ALTER PROCEDURE [dbo].[RP_PrintProposal]
    @STModuleName VARCHAR(50),
    @ARProposalID INT
AS
BEGIN
SET NOCOUNT ON;
       -- Master
    SELECT 
		p.ARProposalNo
		,p.ARProposalDate
		,p.ARProposalValidateDate
		,p.ARProposalDesc
		,o.ACObjectName
		,o.ACObjectNo
		,o.ACObjectContactPhone
		,o.ACObjectMail
		,o.ACObjectContactAddressLine3
		,o.ACObjectTaxNumber
		,p.ARProposalName
		,(SELECT ADConfigText FROM dbo.ADConfigValues WHERE ADConfigKeyGroup = 'PaymentMethod' AND ADConfigKeyValue =p.ARPaymentMethodCombo)AS PaymentMethod
		,(SELECT ADConfigText FROM dbo.ADConfigValues WHERE ADConfigKeyGroup = 'ProposalQuotationType' AND ADConfigKeyValue =p.ARProposalQuotationType) AS QuotationType
		,b.BRBranchName
		,h.HREmployeeName
		,p.ARProposalSubTotalAmount
		,p.ARProposalTotalAmount
		,p.ARProposalTotalCost
		,p.ARProposalNetAmount
		,p.ARProposalTaxAmount
		,p.ARProposalTaxPercent
		,p.ARProposalDiscountPerCent
		,p.ARProposalDiscountFix
		,cr.GECurrencyName
	FROM dbo.ARProposals p
		LEFT JOIN dbo.HREmployees h ON h.HREmployeeID = p.FK_HREmployeeID
		LEFT JOIN dbo.BRBranchs b ON b.BRBranchID = p.FK_BRBranchID
		LEFT JOIN dbo.V_ACObjects o ON o.ACObjectID = p.FK_ACObjectID AND o.ACObjectType = p.ARObjectType
		LEFT JOIN dbo.GECurrencies cr ON cr.GECurrencyID = p.FK_GECurrencyID
	WHERE p.ARProposalID = @ARProposalID
		AND p.ARProposalStatus != 'New'
	--Detail
	SELECT 
		pi.ARProposalItemProductName
		,sp.ICProductNo
		,sp.ICProductName
		,sp.ICProductDesc
		,pi.ARProposalItemProductQty
		,m.ICMeasureUnitName
		,pi.ARProposalItemDiscountAmount
		,pi.ARProposalItemPrice
		,pi.ARProposalItemComment
		,pi.ARProposalItemDiscountFix
		,pi.ARProposalItemTotalAmount
		,pi.ARProposalItemNetAmount
		,pi.ARProposalItemTaxAmount
		,pi.ARProposalItemProductTaxPercent
		,pi.ARProposalItemTotalAmount/pi.ARProposalItemProductQty AS Dongiasauthuevachietkhau
		,REPLACE(REPLACE(sp.ICProductImageFile, '/view?usp=sharing', ''), 'https://drive.google.com/file/d/', 'https://drive.google.com/uc?id=') AS ICProductImageFile
		,(pi.ARProposalItemWidth * pi.ARProposalItemHeight * pi.ARProposalItemLength) AS CBM
		,sp.ICProductQtyInBox
		,sp.ICProductNetWeight
		,sp.ICProductGrossWeight
		,pi.ARProposalItemDesc
		,woodType.ICProductAttributeValue AS WoodTypeValue
		,sp.ICProductAttributeFinishingText
		,pi.ARProposalItemWidth
		,pi.ARProposalItemHeight
		,pi.ARProposalItemLength
		,dcQty.ICProductContainerDetailQty AS dcQty
		,hcQty.ICProductContainerDetailQty AS hcQty
	FROM dbo.ARProposalItems pi
		inner join ARProposals p	on p.ARProposalID = pi.FK_ARProposalID
		LEFT JOIN dbo.ICProducts sp ON sp.ICProductID =pi.FK_ICProductID
		LEFT JOIN dbo.ICMeasureUnits m ON m.ICMeasureUnitID =pi.FK_ICMeasureUnitID
	OUTER APPLY
	(
		SELECT pcd.ICProductContainerDetailQty 
		FROM ICProductContainerDetails pcd 
		WHERE FK_ICProductID = pi.FK_ICProductID 
		AND pcd.AAStatus = 'Alive'
		AND ICProductContainerType = '20DC'
	) dcQty
	OUTER APPLY
	(
		SELECT pcd.ICProductContainerDetailQty 
		FROM ICProductContainerDetails pcd 
		WHERE FK_ICProductID = pi.FK_ICProductID 
		AND pcd.AAStatus = 'Alive'
		AND ICProductContainerType = '40HC'
	) hcQty
	OUTER APPLY
	(
		SELECT ICProductAttributeValue 
		FROM dbo.ICProductAttributes
		WHERE AAStatus = 'Alive'
		AND ICProductAttributeGroup = 'WoodType'
		AND ICProductAttributeID = sp.FK_ICProductAttributeWoodTypeID
		) AS woodType

	WHERE pi.FK_ARProposalID = @ARProposalID AND pi.AAStatus = 'Alive'
		AND p.ARProposalStatus != 'New'
	ORDER BY pi.ARProposalItemSortOrder


	-- Company công ty

	SELECT * FROM dbo.ThongTinCty(1) 
	END;



GO

