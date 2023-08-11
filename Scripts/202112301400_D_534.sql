UPDATE dbo.STModuleDescriptions
SET STModuleDescriptionDescription = N'Khuyến mãi'
WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'DiscountProgram')

UPDATE dbo.STModules
SET AAStatus = 'Delete'
WHERE STModuleName = 'Promotion'

DELETE dbo.AAColumnAlias WHERE AATableName IN ('ARDiscountPrograms', 'ARDiscountProgramItems')

 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramNo', N'Mã chứng từ', 'ARDiscountPrograms', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramName', N'Tên chương trình', 'ARDiscountPrograms', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramDesc', N'Mô tả', 'ARDiscountPrograms', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramDate', N'Ngày chứng từ', 'ARDiscountPrograms', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramBeginDate', N'Ngày áp dụng', 'ARDiscountPrograms', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramEndDate', N'Ngày kết thúc', 'ARDiscountPrograms', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramType', N'Loại chương trình', 'ARDiscountPrograms', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramApplyOn', N'Tính trên', 'ARDiscountPrograms', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramStatus', N'Tình trạng', 'ARDiscountPrograms', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'FK_HREmployeeID', N'Người tạo', 'ARDiscountPrograms', 'HREmployees', 'HREmployeeName', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramCode', N'Mã giảm giá', 'ARDiscountPrograms', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramDate', N'Ngày chứng từ', 'ARDiscountPrograms', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramStatus', N'Tình trạng', 'ARDiscountPrograms', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramApplyType', N'Loại khuyến mãi', 'ARDiscountPrograms', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramName', N'Tên chương trình', 'ARDiscountPrograms', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramBeginDate', N'Ngày áp dụng', 'ARDiscountPrograms', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramEndDate', N'Ngày kết thúc', 'ARDiscountPrograms', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramNo', N'Mã khuyến mãi', 'ARDiscountPrograms', '', '', '', '', 1, 1)

 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramItemProductName', N'Tên sản phẩm', 'ARDiscountProgramItems', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'FK_ICProductID', N'Mã sản phẩm', 'ARDiscountProgramItems', 'ICProducts', 'ICProductNo', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramItemProductDesc', N'Mô tả', 'ARDiscountProgramItems', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramItemBasicPrice', N'Đơn giá gốc', 'ARDiscountProgramItems', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramItemProductUnitPrice', N'Đơn giá mua bán', 'ARDiscountProgramItems', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramItemIsExhibit', N'Hỗ trợ trưng bày', 'ARDiscountProgramItems', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramItemApplyOn', N'Áp dụng CK', 'ARDiscountProgramItems', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramItemValue', N'Tiền/Phần trăm', 'ARDiscountProgramItems', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramItemPriorityQty', N'Đạt mức', 'ARDiscountProgramItems', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramItemPriorityPrice', N'Giá ưu tiên', 'ARDiscountProgramItems', '', '', '', '', 1, 1)
 INSERT INTO dbo.AAColumnAlias VALUES (0, '', 'Alive', 'ARDiscountProgramItemBonusAmount', N'Tiền hỗ trợ', 'ARDiscountProgramItems', '', '', '', '', 1, 1)

