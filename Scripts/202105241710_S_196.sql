SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
-- Stored Procedure

ALTER PROCEDURE [dbo].[ICProducts_GetAllProductsForLookupControl]
	@CSCompanyID				INT	
AS
BEGIN	
	SET NOCOUNT ON;

 --   declare @CurrentBranchID int
	--select	@CurrentBranchID = c.FK_BRBranchID
	--from	[dbo].[CSCompanys] c
	--where	c.AAStatus = 'Alive' and c.CSCompanyID = @CSCompanyID

	SELECT	
			p.ICProductID
		,	p.ICProductPrice01 
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
		,	p.LookupInfo
		,	p.ICMeasureUnitName 
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
		,	p.ICPriceCalculationMethodMethod
		,	p.FK_ICProductAttributeColorID
		,	p.ICProductParentNo
		,	ICProductParentName
		,	p.ICProductConsumable
		,   p.ICProductCustomerNumber
		,	p.FK_ICPerimeterGroupID
		,	p.FK_ICLengthGroupID
		,   p.ICProductUsingMethod
		,	p.ICProductNetWeight
		,	p.ICProductGrossWeight
		,	p.ICProductSizeAndSpecifiCations
	FROM	[dbo].[V_ICProducts] (NOLOCK) p	
	ORDER BY
			p.ICProductNo 
		,	p.ICProductName 
		,	p.ICProductSupplierNumber
		,	p.ICProductDesc
END


GO

