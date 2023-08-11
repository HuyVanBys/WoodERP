SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		Trung Nguyen
-- Create date: 23/12/2010
-- Description:	Get the product list and their inventory based on some criteria
-- =============================================
ALTER PROCEDURE [dbo].[ICProducts_GetProductList]
	@CSCompanyID				int,
	@ICProductNo				nvarchar(50)	= null,
	@ICProductSupplierNumber	nvarchar(50)	= null,
	@ICProductType				varchar(50)		= null,
	@ICProductDesc				nvarchar(512)	= null,
	@ICDepartmentID				int				= null,
	@ICProductGroupID			int				= null,
	@APSupplierID				int				= null,
	@ICProductBarCode			varchar(50)		= null,
	@ACAccountID				int				= null
	
AS
BEGIN	
	SET NOCOUNT ON;
    
    declare @CurrentBranchID int
	select	@CurrentBranchID = c.FK_BRBranchID
	from	[dbo].[CSCompanys] c
	where	c.AAStatus = 'Alive' and c.CSCompanyID = @CSCompanyID
	
	select	p.ICProductID
		,	isnull((	select top 1
								pp.ICProductBranchPrice
						from	[dbo].[ICProductBranchPrices] pp
						where	pp.AAStatus = 'Alive'
						and		pp.FK_BRBranchID = @CurrentBranchID
						and		pp.FK_ICProductID = p.ICProductID						
						and		pp.ICProductBranchPriceType = 'Sale'
    		), p.ICProductPrice01) as ICProductPrice01
		--,	p.*		
		,	p.ICProductCustomerNumber
		,	p.FK_ICProductAttributeWoodTypeID
		,	p.FK_ICProductAttributeColorID
		,	p.FK_ICProductAttributeFinishingID		
		,	p.ICProductID
		,	p.ICProductNo
		,	p.ICProductName
		,	p.ICProductDesc
		,	p.ICProductSupplierNumber
		,	p.ICProductBarCode
		,	p.ICProductType
		,	p.FK_ICDepartmentID
		,	p.FK_ICProductBasicUnitID
		,	p.FK_ICProductGroupID
		,	p.FK_ICProductPurchaseUnitID
		,	p.FK_ICProductSaleUnitID
		,	p.FK_APSupplierID
		,	p.ICProductSupplierPrice	
		,	P.ICProductNoOfOldSys
		,	p.ICProductStockMax
		,	p.ICProductStockMaxDateFrom
		,	p.ICProductStockMaxDateTo
		,	p.ICProductStockMin
		,	p.ICProductStockMinDateFrom
		,	p.ICProductStockMinDateTo
		,	p.ICProductLength
		,	p.ICProductHeight
		,	p.ICProductWidth
		,	p.FK_GEVATID
			
		,	(	select	mu.ICMeasureUnitName
				from	[dbo].[ICMeasureUnits]	mu							
				where	mu.AAStatus = 'Alive'
				and		mu.ICMeasureUnitID = p.FK_ICProductBasicUnitID
			)	as	ICMeasureUnitName
		,	c.ARCustomerName
	from	[dbo].[ICProducts] p											left join
			[dbo].[ICProductGroups] pg	on	p.FK_ICProductGroupID = pg.ICProductGroupID	
			LEFT JOIN dbo.ARCustomers c ON c.ARCustomerID = p.FK_ARCustomerID
	where	p.AAStatus = 'Alive'		
	and		(@ICProductNo is null or p.ICProductNo like '%' + @ICProductNo + '%')
	and		(@ICProductSupplierNumber is null or p.ICProductSupplierNumber like '%' + @ICProductSupplierNumber + '%')
	and		(@ICProductType is null or p.ICProductType = @ICProductType)
	and		(@ICProductDesc is null or p.ICProductDesc like '%' + @ICProductDesc + '%')
	and		(@ICDepartmentID is null or p.FK_ICDepartmentID = @ICDepartmentID)
	and		(@ICProductGroupID is null or pg.ICProductGroupID = @ICProductGroupID or pg.ICProductGroupParentID = @ICProductGroupID)
	and		(@APSupplierID is null or p.FK_APSupplierID = @APSupplierID)
	and		(@ICProductBarCode is null or p.ICProductBarCode = @ICProductBarCode)
	and		(@ACAccountID is null or p.FK_ACAccountID = @ACAccountID)
	order by
			p.ICProductName
		,	p.ICProductSupplierNumber
		,	p.ICProductDesc
END
GO

