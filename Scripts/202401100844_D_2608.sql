Insert into AAColumnAlias values ('0', '', 'Alive', 'FK_ICProductID', N'Mã sản phẩm', 'MMUpdatePositionItems', 'ICProducts', 'ICProductNo', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMUpdatePositionItemProductName', N'Tên sản phẩm', 'MMUpdatePositionItems', 'ICProducts', 'ICProductNo', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'FK_ICStockID', N'Kho', 'MMUpdatePositionItems', 'ICStocks', 'ICStockName', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'FK_ICProductSerieID', N'Mã kiện', 'MMUpdatePositionItems', 'ICProductSeries', 'ICProductSerieNo', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'FK_MMWSPositionID', N'Xưởng', 'MMUpdatePositionItems', 'MMPositions', 'MMPositionNo', 'MMPositionType', 'Line', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'FK_MMRangePositionID', N'Dãy', 'MMUpdatePositionItems', 'MMPositions', 'MMPositionNo', 'MMPositionType', 'Range', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'FK_MMRowPositionID', N'Dây', 'MMUpdatePositionItems', 'MMPositions', 'MMPositionNo', 'MMPositionType', 'Wire', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMUpdatePositionItemProductQty', N'Khối lượng', 'MMUpdatePositionItems', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMUpdatePositionItemProductWoodQty', N'Số thanh', 'MMUpdatePositionItems', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMUpdatePositionItemLength', N'Dài', 'MMUpdatePositionItems', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMUpdatePositionItemWidth', N'Rộng', 'MMUpdatePositionItems', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMUpdatePositionItemHeight', N'Dày', 'MMUpdatePositionItems', '', '', '', '', 1, '')
Insert into AAColumnAlias values ('0', '', 'Alive', 'MMUpdatePositionItemPositionName', N'Vị trí', 'MMUpdatePositionItems', '', '', '', '', 1, '')

Insert into ADConfigValues values ('Alive', 'UpdatePositionStatusNew', 'New', N'Tạo mới', N'Tạo mới', 'UpdatePositionStatus', 1)
Insert into ADConfigValues values ('Alive', 'UpdatePositionStatusApproved', 'Approved', N'Hoàn tất', N'Hoàn tất', 'UpdatePositionStatus', 1)


Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'UpdatePosition'), 1, 'fld_barbtnNew', '', 'New', 'Default', N'Tạo mới', 'Action', 0, 1, '', 0, '')
Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'UpdatePosition'), 1,'fld_barbtnEdit', '', 'Edit', 'Default', N'Sửa', 'Action', 1, 1, '', 0, '')
Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'UpdatePosition'), 1,'fld_barbtnCancel', '', 'Cancel', 'Default', N'Hủy', 'Action', 2, 1, '', 0, '')
Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'UpdatePosition'), 1,'fld_barbtnSave', '', 'Save', 'Default', N'Lưu', 'Action', 3, 1, '', 0, '')
Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'UpdatePosition'), 1,'fld_barbtnComplete', '', 'Complete', 'Default', N'Hoàn tất', 'Action', 4, 1, '', 0, '')

