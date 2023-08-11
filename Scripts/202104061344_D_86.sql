IF (SELECT COUNT(1) FROM dbo.ICShipmentItemComponents WHERE ICShipmentItemComponentID = 0) = 0
BEGIN
	SET IDENTITY_INSERT ICShipmentItemComponents ON 
	INSERT INTO [dbo].[ICShipmentItemComponents](
		[ICShipmentItemComponentID],
		[AAStatus],
		[FK_ICShipmentItemID],
		[FK_ICStockID],
		[FK_ICProductID],
		[FK_ICProductSerieID],
		[ICShipmentItemComponentQty]
	) VALUES ( 
		0,
		'',
		0,
		0,
		0,
		0,
		0.0
	)
	SET IDENTITY_INSERT ICShipmentItemComponents OFF 
END

