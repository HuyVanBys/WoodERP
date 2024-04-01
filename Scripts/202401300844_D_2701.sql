insert into STModules Values ('Alive', 'FalseConditional', 'FC', 1, 1, 'OnlyERP')

Insert into STModuleDescriptions values ((Select STModuleID from STModules Where STModuleName = 'FalseConditional'), 1, N'Kiểm tra chất lượng đầu vào gỗ nguyên liệu')

Insert into STScreens values ('DMFC100', N'Thông tin', 'guiFalseConditionalModule', (Select STModuleID from STModules Where STModuleName = 'FalseConditional'),1, '-1644826', '-16777216', 'Tahoma', '8.25', 'Regular', 'DM', 0,0,0,0,1,1,'',0,0,'',1)
Insert into STScreens values ('SMFC100', N'Tìm kiếm', 'guiFalseConditionalSearch', (Select STModuleID from STModules Where STModuleName = 'FalseConditional'),1, '-1644826', '-16777216', 'Tahoma', '8.25', 'Regular', 'SM', 0,0,0,0,1,1,'',0,0,'',1)

Insert into AAColumnAlias values ('0', '', 'Alive', 'MMFalseConditionalNo', N'Mã chứng từ', 'MMFalseConditionals', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMFalseConditionalDate', N'Ngày chứng từ', 'MMFalseConditionals', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMFalseConditionalStatus', N'Tình trạng', 'MMFalseConditionals', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'ACObjectName', N'Nhà cung cấp', 'MMFalseConditionals', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMFalseConditionalPONo', N'Số DMH', 'MMFalseConditionals', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMFalseConditionalSerialNo', N'Số kiện giao', 'MMFalseConditionals', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMFalseConditionalPercentNorm', N'Định mức % lỗi', 'MMFalseConditionals', '', '', '', '', 1, '')


Insert into AAColumnAlias values ('0', '', 'Alive', 'FK_ICProductSerieID', N'Mã kiện', 'MMFalseConditionalItems', 'ICProductSeries', 'ICProductSerieNo', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'FK_ICProductAttributeQualityID', N'Chất lượng', 'MMFalseConditionalItems', 'ICProductAttributes', 'ICProductAttributeValue', 'ICProductAttributeGroup', 'Quality', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMFalseConditionalItemHumidity', N'Độ ẩm', 'MMFalseConditionalItems', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMFalseConditionalItemProductLength', N'Dài', 'MMFalseConditionalItems', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMFalseConditionalItemProductWidth', N'Rộng', 'MMFalseConditionalItems', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMFalseConditionalItemProductHeight', N'Cao', 'MMFalseConditionalItems', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMFalseConditionalItemWoodQty', N'Số thanh kiện', 'MMFalseConditionalItems', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMFalseConditionalItemInventoryWoodQty', N'Số thanh kiểm', 'MMFalseConditionalItems', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMFalseConditionalItemFaultPercent', N'Tổng % lỗi / kiện', 'MMFalseConditionalItems', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMFalseConditionalItemGoodPercent', N'% Đạt', 'MMFalseConditionalItems', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMFalseConditionalItemResult', N'Kết luận', 'MMFalseConditionalItems', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMFalseConditionalItemComment', N'Ghi chú', 'MMFalseConditionalItems', '', '', '', '', 1, '')

Insert into ADConfigValues values ('Alive', 'FalseConditionalStatusNew', 'New', N'Tạo mới', N'Tạo mới', 'FalseConditionalStatus', 1)
Insert into ADConfigValues values ('Alive', 'FalseConditionalStatusApproved', 'Approved', N'Hoàn tất', N'Hoàn tất', 'FalseConditionalStatus', 1)


Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'FalseConditional'), 1, 'fld_barbtnNew', '', 'New', 'Default', N'Tạo mới', 'Action', 0, 1, '', 0, '')
Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'FalseConditional'), 1,'fld_barbtnEdit', '', 'Edit', 'Default', N'Sửa', 'Action', 1, 1, '', 0, '')
Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'FalseConditional'), 1,'fld_barbtnCancel', '', 'Cancel', 'Default', N'Hủy', 'Action', 2, 1, '', 0, '')
Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'FalseConditional'), 1,'fld_barbtnSave', '', 'Save', 'Default', N'Lưu', 'Action', 3, 1, '', 0, '')
Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'FalseConditional'), 1,'fld_barbtnComplete', '', 'Complete', 'Default', N'Hoàn tất', 'Action', 4, 1, '', 0, '')

Insert into AAColumnAlias values ('0', '', 'Alive', 'MMFalseConditionalDetailName', N'Tên lỗi', 'MMFalseConditionalDetails', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMFalseConditionalDetailLimit', N'Giới hạn % tối đa cho phép', 'MMFalseConditionalDetails', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMFalseConditionalDetailPercent', N'% Lỗi', 'MMFalseConditionalDetails', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMFalseConditionalDetailQty', N'Số lượng', 'MMFalseConditionalDetails', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMFalseConditionalDetailComment', N'Ghi chú', 'MMFalseConditionalDetails', '', '', '', '', 1, '')

Insert into STFieldFormats values ('FalseConditional', 'MMFalseConditionalItems', 1, 'MMFalseConditionalItemWoodQty', 0, 0)
Insert into STFieldFormats values ('FalseConditional', 'MMFalseConditionalItems', 1, 'MMFalseConditionalItemInventoryWoodQty', 0, 0)
Insert into STFieldFormats values ('FalseConditional', 'MMFalseConditionalItems', 1, 'MMFalseConditionalItemProductLength', 0, 0)
Insert into STFieldFormats values ('FalseConditional', 'MMFalseConditionalItems', 1, 'MMFalseConditionalItemProductWidth', 0, 0)
Insert into STFieldFormats values ('FalseConditional', 'MMFalseConditionalItems', 1, 'MMFalseConditionalItemProductHeight', 0, 0)
Insert into STFieldFormats values ('FalseConditional', 'MMFalseConditionalItems', 4, 'MMFalseConditionalItemHumidity', 0, 0)
Insert into STFieldFormats values ('FalseConditional', 'MMFalseConditionalItems', 4, 'MMFalseConditionalItemFaultPercent', 0, 0)
Insert into STFieldFormats values ('FalseConditional', 'MMFalseConditionalItems', 4, 'MMFalseConditionalItemGoodPercent', 0, 0)

Insert into STFieldFormats values ('FalseConditional', 'MMFalseConditionalDetails', 4, 'MMFalseConditionalDetailLimit', 0, 0)
Insert into STFieldFormats values ('FalseConditional', 'MMFalseConditionalDetails', 4, 'MMFalseConditionalDetailPercent', 0, 0)
Insert into STFieldFormats values ('FalseConditional', 'MMFalseConditionalDetails', 1, 'MMFalseConditionalDetailQty', 0, 0)

Insert into ADConfigValues values ('Alive', 'FalseConditionalResultAccept', 'Accept', N'Chấp thuận', N'Chấp thuận', 'FalseConditionalResult', 1)
Insert into ADConfigValues values ('Alive', 'FalseConditionalResultLimitAccept', 'LimitAccept', N'Chấp thuận có điều kiện', N'Chấp thuận có điều kiện', 'FalseConditionalResult', 1)
Insert into ADConfigValues values ('Alive', 'FalseConditionalResultNoAccept', 'NoAccept', N'Không chấp thuận', N'Không chấp thuận', 'FalseConditionalResult', 1)

Insert into ADConfigValues values ('Alive', 'FalseConditionalConditionSize', 'Size', N'Qui cách', N'Qui cách', 'FalseConditionalCondition', 1)
Insert into ADConfigValues values ('Alive', 'FalseConditionalConditionDiscount', 'Discount', N'Giảm giá', N'Giảm giá', 'FalseConditionalCondition', 1)

Insert into GENumbering values ('ADMIN', GETDATE(), 'ADMIN', GETDATE(), 'Alive', 'FalseConditional', 'KTCL-', 6,1, N'Kiểm tra chất lượng đầu vào gỗ nguyên liệu',1,1,1,0,0,0,'{1}{2}.{3}.{7}')
