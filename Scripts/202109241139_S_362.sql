SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO



ALTER VIEW [dbo].[V_ICProducts]
AS

SELECT	p.ICProductID
		,	ISNULL(pp.ICProductBranchPrice, p.ICProductPrice01) AS ICProductPrice01 
		,	p.ICProductBarCode
		,	p.ICProductNo
		,	p.ICProductCode 
		,	p.ICProductName
		,	p.ICProductDesc
		,	p.ICProductSupplierNumber
		,	p.ICProductType
		,	p.ICProductJoinery 
		,	p.FK_ICProductAttributeWoodTypeID 
		,	p.FK_ICProdAttPackingMaterialWeightPerVolumeID
		,	p.FK_ICProdAttPackingMaterialSizeID
		,	p.FK_ICProdAttPackingMaterialSpecialityID
		,	p.ICProductInsideDimensionLength
		,	p.ICProductInsideDimensionWidth
		,	p.ICProductInsideDimensionHeight
		,   p.ICProductOverallDimensionLength
		,   p.ICProductOverallDimensionWidth
		,   p.ICProductOverallDimensionHeight
		,	p.FK_ICProductBasicUnitID 
		,	p.FK_ICProductSaleUnitID 
		,	p.FK_ICProductPurchaseUnitID
		,	(p.ICProductBarCode + ' ' + p.ICProductNo + ' ' + p.ICProductSupplierNumber + ' ' + p.ICProductDesc) AS LookupInfo
		,	mu.ICMeasureUnitName 
		,	p.FK_ICDepartmentID
		,	p.FK_ICProductGroupID
		,	p.ICProductNoOfOldSys 
		,	p.HasComponent 
		,	p.FK_ICProductCarcassID 
		,	p.FK_ACAccountID 
		,	p.FK_ACDepreciationCostAccountID 
		,	p.FK_ACDepreciationAccountID 
		,	p.FK_ACAccountRevenueInternalID 
		,	p.FK_ACAccountCostPriceID 
		,	p.FK_ACAccountRevenueID 
		,	p.FK_ACAccountSaleReturnID 
		,	p.FK_ACAccountDiscountID 
		,	p.ICProductStockMaxDateFrom 
		,	p.ICProductStockMaxDateTo 
		,	p.ICProductStockMax 
		,	p.ICProductVolume		 
		,	p.ICProductActiveCheck 
		,	p.ICProductDepreciationRate 
		,	p.ICProductDepreciationQty 
		,	p.ICProductCheckCarcass
		,	p.ICProductLength
		,	p.ICProductWidth
		,	p.ICProductHeight
		,	p.ICProductBlock
		,	p.FK_APSupplierID
		,	p.ICProductIsFollowInventoryStock
		,	pm.ICPriceCalculationMethodMethod
		,	p.FK_ICProductAttributeColorID
		,	pa.ICProductNo AS ICProductParentNo
		,	pa.ICProductName AS ICProductParentName
		,	p.ICProductConsumable
		,   p.ICProductCustomerNumber
		,	p.FK_ICPerimeterGroupID
		,	p.FK_ICLengthGroupID
		,   p.ICProductUsingMethod
		,	p.ICProductNetWeight
		,	p.ICProductGrossWeight
		,	p.ICProductSizeAndSpecifiCations
		,	p.ICProductOriginOfProduct
	FROM	[dbo].[ICProducts] (NOLOCK) p	
		OUTER APPLY 
		(
			SELECT TOP 1 ICMeasureUnitName FROM [dbo].[ICMeasureUnits] (NOLOCK) mu WHERE 	mu.ICMeasureUnitID = p.FK_ICProductBasicUnitID  
		) mu
		OUTER APPLY 
		(
			SELECT TOP 1 ICPriceCalculationMethodMethod FROM ICPriceCalculationMethods (NOLOCK) pm WHERE 	p.FK_ICPriceCalculationMethodID = pm.ICPriceCalculationMethodID
		) pm
		OUTER APPLY 
		(
			SELECT TOP 1  
							pp.ICProductBranchPrice  
					FROM	[dbo].[ICProductBranchPrices] (NOLOCK) pp  
					WHERE	pp.AAStatus = 'Alive'  
					AND		pp.FK_BRBranchID = 1  
					AND		pp.FK_ICProductID = p.ICProductID						  
					AND		pp.ICProductBranchPriceType = 'Sale'  
		) pp
		OUTER APPLY 
		(
			SELECT COUNT(1) AS countID 
			FROM ACAssets (NOLOCK) ass  
			WHERE ass.AAStatus = 'Alive'  
			AND ass.FK_ICProductID = p.ICProductID
		) a
		OUTER APPLY 
		(
			SELECT TOP 1 pt.ICProductNo
			,	pt.ICProductName
			FROM dbo.ICProducts pt 
			WHERE pt.AAStatus = 'Alive'  
			AND pt.ICProductID = p.FK_ICProductCarcassID
		) pa
	WHERE	p.AAStatus = 'Alive'
		--AND p.ICProductType not in ('SemiProduct')
		AND p.ICProductType <>'ProductProposal'	
	--ORDER BY
	--		p.ICProductNo 
	--	,	p.ICProductName 
	--	,	p.ICProductSupplierNumber
	--	,	p.ICProductDesc




GO
