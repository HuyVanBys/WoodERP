SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[ICShipmentItemComponents_GetShipmentItemComponentListByShipmentItemID]
	@FK_ICShipmentItemID			int
AS
BEGIN	
	set nocount on;

	select	sic.*
	,		p.ICProductSupplierNumber as ICProductSupplierNo
	,		p.ICProductDesc		
	,		(	select top 1
						pc.ICProductComponentQty
				from	[dbo].[ICProductComponents] pc
				where	pc.AAStatus = 'Alive'
				and		pc.FK_ICProductComponentParentID = si.FK_ICProductID
				and		pc.FK_ICProductComponentChildID = sic.FK_ICProductID				
			)	as	ICProductComponentQty
	,		(	select	ps.ICProductSerieNo
				from	[dbo].[ICProductSeries] ps
				where	ps.AAStatus = 'Alive'
				and		ps.ICProductSerieID = sic.FK_ICProductSerieID
			)	as	ICProductSerieNo
	from	[dbo].ICShipmentItemComponents	sic															inner join
			[dbo].ICShipmentItems si	on	sic.FK_ICShipmentItemID = si.ICShipmentItemID		inner join
			[dbo].[ICProducts]			p	on	sic.FK_ICProductID	=	p.ICProductID					left join
			[dbo].[ICProductSeries] ps		on	sic.FK_ICProductSerieID = ps.ICProductSerieID
	where	sic.AAStatus			=	'Alive'
	and		si.AAStatus			=	'Alive'
	and		p.AAStatus				=	'Alive'	
	and		sic.FK_ICShipmentItemID	=	@FK_ICShipmentItemID				
END
GO

