SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].ICReceiptItems_CheckExistBillOfLadings
	@FK_APBillOfLadingItemID int = null
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT TOP 1 ri.* 
	FROM dbo.ICReceiptItems ri
	WHERE 
		AAStatus = 'Alive'
	AND ri.FK_APBillOfLadingItemID = @FK_APBillOfLadingItemID
END


GO
SELECT * FROM  dbo.GEVersions
