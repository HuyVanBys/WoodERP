Update ADConfigValues
Set AAStatus = 'Delete'
Where ADConfigKeyGroup = 'ReturnSupplierReceiptType' and AAStatus = 'Alive'

Insert into ADConfigValues
Values ('Alive', 'ReturnSupplierReceiptTypeLumber','Lumber',N'Mua gỗ phách','','ReturnSupplierReceiptType',1),
		('Alive', 'ReturnSupplierReceiptTypeRoundwood','Roundwood',N'Mua gỗ tròn','','ReturnSupplierReceiptType',1),
		('Alive', 'ReturnSupplierReceiptTypeProduct','Product',N'Mua hàng hóa','','ReturnSupplierReceiptType',1),
		('Alive', 'ReturnSupplierReceiptTypeVerneer','Verneer',N'Verneer','','ReturnSupplierReceiptType',1),
		('Alive', 'ReturnSupplierReceiptTypeArtificialBoard','ArtificialBoard',N'Ván nhân tạo','','ReturnSupplierReceiptType',1),
		('Alive', 'ReturnSupplierReceiptTypeOther','Other',N'Khác','','ReturnSupplierReceiptType',1),
		('Alive', 'ReturnSupplierReceiptTypeAlloyCover','AlloyCover',N'Đắp hợp kim','','ReturnSupplierReceiptType',1),
		('Alive', 'ReturnSupplierReceiptTypeMechanicOutSourcing','MechanicOutSourcing',N'Gia công cơ khí','','ReturnSupplierReceiptType',1),
		('Alive', 'ReturnSupplierReceiptTypeHardware','Hardware',N'Hardware','','ReturnSupplierReceiptType',1),
		('Alive', 'ReturnSupplierReceiptTypeDichvuvagiacong','Dichvuvagiacong',N'Dịch vụ và gia công','','ReturnSupplierReceiptType',1),
		('Alive', 'ReturnSupplierReceiptTypeIngredientPackaging','IngredientPackaging',N'Phụ liệu đóng gói','','ReturnSupplierReceiptType',1),
		('Alive', 'ReturnSupplierReceiptTypeEquipment','Equipment',N'CCDC','','ReturnSupplierReceiptType',1),
		('Alive', 'ReturnSupplierReceiptTypeIngredientPaint','IngredientPaint',N'Sơn','','ReturnSupplierReceiptType',1)

