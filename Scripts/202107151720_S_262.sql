SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO

CREATE PROCEDURE dbo.ICProducts_GetAllProductForSaleToLookupEditBySaleOrderProductType
	@SaleOrderProductType NVARCHAR(256) = NULL
AS
BEGIN	
	SET NOCOUNT ON;

	CREATE TABLE #MappingProductType
	(
		SaleOrderProductType	NVARCHAR(50),
		DepartmentNo			NVARCHAR(50)
	)

	INSERT #MappingProductType	VALUES	(N'Roundwood', N'01')
	INSERT #MappingProductType	VALUES	(N'DryLumber', N'01')
	INSERT #MappingProductType	VALUES	(N'FreshLumber', N'01')
	INSERT #MappingProductType	VALUES	(N'ArtificialBoard', N'01')
	INSERT #MappingProductType	VALUES	(N'Verneer', N'01')
	INSERT #MappingProductType	VALUES	(N'Hardware', N'02')
	INSERT #MappingProductType	VALUES	(N'IngredientPaint', N'03')
	INSERT #MappingProductType	VALUES	(N'IngredientPackaging', N'04')
	INSERT #MappingProductType	VALUES	(N'SemiProduct', N'05')
	INSERT #MappingProductType	VALUES	(N'Product', N'06')
	

	select	p.ICProductID,
			p.ICProductNo,
			p.ICProductNoOfOldSys,
			p.ICProductBarCode,
			p.ICProductSupplierNumber,
			p.ICProductName,
			p.ICProductDesc,
			p.ICProductPrice01,
			p.ICProductHeight,
			p.ICProductWidth,
			p.ICProductType,
			p.ICProductLength,
			CASE WHEN p.ICProductActiveCheck = 1 THEN N'Hoạt động' ELSE N'Không hoạt động' END AS ICProductActiveCheckText
	from	[dbo].[ICProducts] p	
	INNER JOIN dbo.ICDepartments d ON d.AAStatus = 'Alive' AND d.ICDepartmentID = p.FK_ICDepartmentID																				 
	where	p.AAStatus = 'Alive'
		AND (@SaleOrderProductType IS NULL OR @SaleOrderProductType IN ('', 'Other')
				OR d.ICDepartmentNo IN (SELECT DepartmentNo FROM #MappingProductType WHERE SaleOrderProductType = @SaleOrderProductType))

	DROP TABLE #MappingProductType								
END

GO


