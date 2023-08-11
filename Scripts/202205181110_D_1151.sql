Update ADConfigValues
Set AAStatus = 'Delete'
Where ADConfigKeyGroup = 'PurchaseOrderReceiptType' and AAStatus = 'Alive'

Insert into ADConfigValues
Values ('Alive', 'PurchaseOrderReceiptTypeLumber','Lumber',N'Mua gỗ phách','','PurchaseOrderReceiptType',1),
		('Alive', 'PurchaseOrderReceiptTypeRoundwood','Roundwood',N'Mua gỗ tròn','','PurchaseOrderReceiptType',1),
		('Alive', 'PurchaseOrderReceiptTypeProduct','Product',N'Mua hàng hóa','','PurchaseOrderReceiptType',1),
		('Alive', 'PurchaseOrderReceiptTypeVerneer','Verneer',N'Verneer','','PurchaseOrderReceiptType',1),
		('Alive', 'PurchaseOrderReceiptTypeArtificialBoard','ArtificialBoard',N'Ván nhân tạo','','PurchaseOrderReceiptType',1),
		('Alive', 'PurchaseOrderReceiptTypeOther','Other',N'Khác','','PurchaseOrderReceiptType',1),
		('Alive', 'PurchaseOrderReceiptTypeAlloyCover','AlloyCover',N'Đắp hợp kim','','PurchaseOrderReceiptType',1),
		('Alive', 'PurchaseOrderReceiptTypeMechanicOutSourcing','MechanicOutSourcing',N'Gia công cơ khí','','PurchaseOrderReceiptType',1),
		('Alive', 'PurchaseOrderReceiptTypeHardware','Hardware',N'Hardware','','PurchaseOrderReceiptType',1),
		('Alive', 'PurchaseOrderReceiptTypeDichvuvagiacong','Dichvuvagiacong',N'Dịch vụ và gia công','','PurchaseOrderReceiptType',1),
		('Alive', 'PurchaseOrderReceiptTypeIngredientPackaging','IngredientPackaging',N'Phụ liệu đóng gói','','PurchaseOrderReceiptType',1),
		('Alive', 'PurchaseOrderReceiptTypeEquipment','Equipment',N'CCDC','','PurchaseOrderReceiptType',1),
		('Alive', 'PurchaseOrderReceiptTypeIngredientPaint','IngredientPaint',N'Sơn','','PurchaseOrderReceiptType',1)


Update ADConfigValues
Set AAStatus = 'Delete'
Where ADConfigKeyGroup = 'ProposalAPType' and AAStatus = 'Alive'

Insert into ADConfigValues
Values ('Alive', 'ProposalAPTypeLumber','Lumber',N'Mua gỗ phách','','ProposalAPType',1),
		('Alive', 'ProposalAPTypeRoundwood','Roundwood',N'Mua gỗ tròn','','ProposalAPType',1),
		('Alive', 'ProposalAPTypeProduct','Product',N'Mua hàng hóa','','ProposalAPType',1),
		('Alive', 'ProposalAPTypeVerneer','Verneer',N'Verneer','','ProposalAPType',1),
		('Alive', 'ProposalAPTypeArtificialBoard','ArtificialBoard',N'Ván nhân tạo','','ProposalAPType',1),
		('Alive', 'ProposalAPTypeOther','Other',N'Khác','','ProposalAPType',1),
		('Alive', 'ProposalAPTypeAlloyCover','AlloyCover',N'Đắp hợp kim','','ProposalAPType',1),
		('Alive', 'ProposalAPTypeMechanicOutSourcing','MechanicOutSourcing',N'Gia công cơ khí','','ProposalAPType',1),
		('Alive', 'ProposalAPTypeHardware','Hardware',N'Hardware','','ProposalAPType',1),
		('Alive', 'ProposalAPTypeDichvuvagiacong','Dichvuvagiacong',N'Dịch vụ và gia công','','ProposalAPType',1),
		('Alive', 'ProposalAPTypeIngredientPackaging','IngredientPackaging',N'Phụ liệu đóng gói','','ProposalAPType',1),
		('Alive', 'ProposalAPTypeEquipment','Equipment',N'CCDC','','ProposalAPType',1),
		('Alive', 'ProposalAPTypeIngredientPaint','IngredientPaint',N'Sơn','','ProposalAPType',1)