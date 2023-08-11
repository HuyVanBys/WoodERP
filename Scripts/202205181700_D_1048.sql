Update ADConfigValues
Set AAStatus = 'Delete'
Where ADConfigKeyGroup = 'ReceiptReceiptType' and AAStatus = 'Alive'

Insert into ADConfigValues
Values ('Alive', 'ReceiptReceiptTypeLumber','Lumber',N'Mua gỗ phách','','ReceiptReceiptType',1),
		('Alive', 'ReceiptReceiptTypeRoundwood','Roundwood',N'Mua gỗ tròn','','ReceiptReceiptType',1),
		('Alive', 'ReceiptReceiptTypeProduct','Product',N'Mua hàng hóa','','ReceiptReceiptType',1),
		('Alive', 'ReceiptReceiptTypeVerneer','Verneer',N'Verneer','','ReceiptReceiptType',1),
		('Alive', 'ReceiptReceiptTypeArtificialBoard','ArtificialBoard',N'Ván nhân tạo','','ReceiptReceiptType',1),
		('Alive', 'ReceiptReceiptTypeOther','Other',N'Khác','','ReceiptReceiptType',1),
		('Alive', 'ReceiptReceiptTypeAlloyCover','AlloyCover',N'Đắp hợp kim','','ReceiptReceiptType',1),
		('Alive', 'ReceiptReceiptTypeMechanicOutSourcing','MechanicOutSourcing',N'Gia công cơ khí','','ReceiptReceiptType',1),
		('Alive', 'ReceiptReceiptTypeHardware','Hardware',N'Hardware','','ReceiptReceiptType',1),
		('Alive', 'ReceiptReceiptTypeDichvuvagiacong','Dichvuvagiacong',N'Dịch vụ và gia công','','ReceiptReceiptType',1),
		('Alive', 'ReceiptReceiptTypeIngredientPackaging','IngredientPackaging',N'Phụ liệu đóng gói','','ReceiptReceiptType',1),
		('Alive', 'ReceiptReceiptTypeEquipment','Equipment',N'CCDC','','ReceiptReceiptType',1),
		('Alive', 'ReceiptReceiptTypeIngredientPaint','IngredientPaint',N'Sơn','','ReceiptReceiptType',1)

Update ADConfigValues
Set AAStatus = 'Delete'
Where ADConfigKeyGroup = 'InvoiceInType' and AAStatus = 'Alive'

Insert into ADConfigValues
Values ('Alive', 'InvoiceInTypeLumber','Lumber',N'Mua gỗ phách','','InvoiceInType',1),
		('Alive', 'InvoiceInTypeRoundwood','Roundwood',N'Mua gỗ tròn','','InvoiceInType',1),
		('Alive', 'InvoiceInTypeProduct','Product',N'Mua hàng hóa','','InvoiceInType',1),
		('Alive', 'InvoiceInTypeVerneer','Verneer',N'Verneer','','InvoiceInType',1),
		('Alive', 'InvoiceInTypeArtificialBoard','ArtificialBoard',N'Ván nhân tạo','','InvoiceInType',1),
		('Alive', 'InvoiceInTypeOther','Other',N'Khác','','InvoiceInType',1),
		('Alive', 'InvoiceInTypeAlloyCover','AlloyCover',N'Đắp hợp kim','','InvoiceInType',1),
		('Alive', 'InvoiceInTypeMechanicOutSourcing','MechanicOutSourcing',N'Gia công cơ khí','','InvoiceInType',1),
		('Alive', 'InvoiceInTypeHardware','Hardware',N'Hardware','','InvoiceInType',1),
		('Alive', 'InvoiceInTypeDichvuvagiacong','Dichvuvagiacong',N'Dịch vụ và gia công','','InvoiceInType',1),
		('Alive', 'InvoiceInTypeIngredientPackaging','IngredientPackaging',N'Phụ liệu đóng gói','','InvoiceInType',1),
		('Alive', 'InvoiceInTypeEquipment','Equipment',N'CCDC','','InvoiceInType',1),
		('Alive', 'InvoiceInTypeIngredientPaint','IngredientPaint',N'Sơn','','InvoiceInType',1)

--
Insert into AAColumnAlias
Values (0, '', 'Alive', 'ICReceiptItemProductionDate', N'Ngày sản xuất', 'ICReceiptItems', '', '' ,'' ,'' ,1 ,0),
	(0, '', 'Alive', 'ICReceiptItemExpiryDate', N'Ngày hết hạn', 'ICReceiptItems', '', '' ,'' ,'' ,1 ,0)

--
Insert into AAColumnAlias
Values (0, '', 'Alive', 'ICInventoryStockReceiptDate', N'Ngày sản xuất', 'ICInventoryStocks', '', '' ,'' ,'' ,1 ,0),
	(0, '', 'Alive', 'ICInventoryStockExpireDate', N'Hạn sử dụng', 'ICInventoryStocks', '', '' ,'' ,'' ,1 ,0)