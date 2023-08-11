Insert into AAColumnAlias
Values 
(
	0,
	'',
	'Alive',
	'ARProductionPlanningItemProductQty',
	N'Số lượng đã Đề nghị sản xuất',
	'ARDeliveryPlanItems',
	'',
	'',
	'',
	'',
	1,
	0
	)

Insert into STFieldFormats
Values (
	'DeliveryPlan',
	'ARDeliveryPlanItems',
	(Select STFieldFormatGroupID from STFieldFormatGroups Where STFieldFormatGroupName = 'FormatGroupN3'),
	'ARProductionPlanningItemProductQty'
	)