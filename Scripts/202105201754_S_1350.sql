SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO

ALTER PROCEDURE [dbo].[MMBatchProductProductionNormItems_GetBatchProductProductionNormItemByBatchProductItemID]
	@batchProductID int,
	@ProductType nvarchar(50),
	@batchProductItemID int
AS
BEGIN

	SET NOCOUNT ON;

	if (@ProductType = 'SemiProduct')   
		(select  
				bp.MMBatchProductMultiCustomer AS ARCustomerName,
				bpp.*,
				bpi.*
				,(select mu.ICMeasureUnitName
				  from ICMeasureUnits mu
				  where mu.AAStatus='Alive'
						and mu.ICMeasureUnitID=bpp.FK_ICMeasureUnitID)as ICMeasureUnitName
				, isnull((select bppni.MMBatchProductProductionNormItemParentID 
						  from MMBatchProductProductionNormItems bppni 
						  where bppni.MMBatchProductProductionNormItemID = bpp.MMBatchProductProductionNormItemParentID),0) as ParentOfParentID
				, cd.MMOperationName
		from 
			MMBatchProducts bp 						inner join
			MMBatchProductItems bpi on bp.MMBatchProductID=bpi.FK_MMBatchProductID					inner join
			MMBatchProductProductionNormItems bpp	on bpp.FK_MMBatchProductItemID=bpi.MMBatchProductItemID
			OUTER APPLY
			(
				SELECT o.MMOperationName 
				FROM dbo.MMOperations o
				WHERE	o.MMOperationID = bpp.FK_MMOperationID
				AND		o.AAStatus = 'Alive'
			)	cd
		where bpp.AAStatus='Alive' 
		and bp.AAStatus='Alive' and bpi.AAStatus='Alive' 
			and bpp.MMBatchProductProductionNormItemGroup=@ProductType
			and bp.MMBatchProductID=@batchProductID
			and bpi.MMBatchProductItemID=@batchProductItemID
			and bpp.MMBatchProductProductionNormItemModifiedStatus <> 'Delete'
		)
	ELSE IF (@ProductType = 'Hardware' OR @ProductType = 'IngredientPackaging' OR @ProductType = 'GeneralMaterial')
		(select  
				bp.MMBatchProductMultiCustomer AS ARCustomerName,
				bp.MMBatchProductDesc,
				bpi.MMBatchProductItemProductSerial,
				bpps.MMBatchProductProductionNormItemProductName AS MMBPSemiProductName,
				bpp.*,
				bpi.*
				,(select mu.ICMeasureUnitName
				  from ICMeasureUnits mu
				  where mu.AAStatus='Alive'
						and mu.ICMeasureUnitID=bpp.FK_ICMeasureUnitID)as ICMeasureUnitName
				, isnull((select bppni.MMBatchProductProductionNormItemParentID 
						  from MMBatchProductProductionNormItems bppni 
						  where bppni.MMBatchProductProductionNormItemID = bpp.MMBatchProductProductionNormItemParentID),0) as ParentOfParentID
				, cd.MMOperationName
		from 
			MMBatchProducts bp 						inner join
			MMBatchProductItems bpi on bp.MMBatchProductID=bpi.FK_MMBatchProductID					inner join
			MMBatchProductProductionNormItems bpp	on bpp.FK_MMBatchProductItemID=bpi.MMBatchProductItemID
			OUTER APPLY
			(
				SELECT o.MMOperationName 
				FROM dbo.MMOperations o
				WHERE	o.MMOperationID = bpp.FK_MMOperationID
				AND		o.AAStatus = 'Alive'
			)	cd
			OUTER APPLY
			(
				SELECT bpps.MMBatchProductProductionNormItemProductName 
				FROM MMBatchProductProductionNormItems bpps 
				WHERE bpp.FK_MMBPSemiProductID = bpps.MMBatchProductProductionNormItemID 
				AND bpps.AAStatus = 'Alive'
			) bpps
		where bpp.AAStatus='Alive' 
		and bp.AAStatus='Alive' and bpi.AAStatus='Alive' 
		and bpp.MMBatchProductProductionNormItemGroup=@ProductType
		and bp.MMBatchProductID=@batchProductID
		and bpi.MMBatchProductItemID=@batchProductItemID
		and bpp.MMBatchProductProductionNormItemModifiedStatus <> 'Delete'
		)
	else 
		(select MMBatchProductProductionNormItemQuantityPerOne AS MMBatchProductProductionNormItemQuantityPerUnit, 
				bp.MMBatchProductMultiCustomer AS ARCustomerName,
				bpp.MMBatchProductProductionNormItemQuantityPerOne AS MMBatchProductProductionNormItemQuantityPerOne,
				bpp.*,
				bpi.*
				,(select mu.ICMeasureUnitName
				  from ICMeasureUnits mu
				  where mu.AAStatus='Alive'
						and mu.ICMeasureUnitID=bpp.FK_ICMeasureUnitID)as ICMeasureUnitName
				, isnull((select bppni.MMBatchProductProductionNormItemID 
						  from MMBatchProductProductionNormItems bppni 
						  where bppni.MMBatchProductProductionNormItemID = bpp.MMBatchProductProductionNormItemParentID),0) as ParentOfParentID
				, cd.MMOperationName
		from 
			MMBatchProducts bp 						inner join
			MMBatchProductItems bpi on bp.MMBatchProductID=bpi.FK_MMBatchProductID					inner join
			MMBatchProductProductionNormItems bpp	on bpp.FK_MMBatchProductItemID=bpi.MMBatchProductItemID
			OUTER APPLY
			(
				SELECT o.MMOperationName 
				FROM dbo.MMOperations o
				WHERE	o.MMOperationID = bpp.FK_MMOperationID
				AND		o.AAStatus = 'Alive'
			)	cd
		where bpp.AAStatus='Alive' 
		and bp.AAStatus='Alive' and bpi.AAStatus='Alive' 
			and bpp.MMBatchProductProductionNormItemGroup=@ProductType
			and bp.MMBatchProductID=@batchProductID
			and bpi.MMBatchProductItemID=@batchProductItemID
			and bpp.MMBatchProductProductionNormItemModifiedStatus <> 'Delete'
		)

END



GO

