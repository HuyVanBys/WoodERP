ALTER TABLE dbo.ICShipments
ADD ICShipmentContainerNumber VARCHAR(50),
	ICShipmentContainerSealNumber VARCHAR(50),
	ICShipmentTractorTrailerNumber VARCHAR(50),
	ICShipmentShipNumber nVARCHAR(50),
	ICShipmentETDDate DATETIME

ALTER TABLE dbo.ICShipmentItems
ADD ICShipmentItemContainerNumber VARCHAR(50),
	ICShipmentItemContainerSealNumber VARCHAR(50),
	ICShipmentItemTractorTrailerNumber VARCHAR(50),
	ICShipmentItemShipNumber NVARCHAR(50),
	ICShipmentItemETDDate DATETIME