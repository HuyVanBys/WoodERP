insert into STModules Values ('Alive', 'RevenueForecast', 'RF', 1, 1, 'OnlyERP')

Insert into STModuleDescriptions values ((Select STModuleID from STModules Where STModuleName = 'RevenueForecast'), 1, N'Doanh thu dự kiến theo khách hàng')

Insert into STScreens values ('DMRF100', N'Thông tin', 'guiRevenueForecastModule', (Select STModuleID from STModules Where STModuleName = 'RevenueForecast'),1, '-1644826', '-16777216', 'Tahoma', '8.25', 'Regular', 'DM', 0,0,0,0,1,1,'',0,0,'',1)
Insert into STScreens values ('SMRF100', N'Tìm kiếm', 'guiRevenueForecastSearch', (Select STModuleID from STModules Where STModuleName = 'RevenueForecast'),1, '-1644826', '-16777216', 'Tahoma', '8.25', 'Regular', 'SM', 0,0,0,0,1,1,'',0,0,'',1)

Insert into AAColumnAlias values (0, '', 'Alive', 'ARRevenueForecastNo', N'Mã chứng từ', 'ARRevenueForecasts', '', '', '', '', 1, 0)
Insert into AAColumnAlias values (0, '', 'Alive', 'ARRevenueForecastDate', N'Ngày chứng từ', 'ARRevenueForecasts', '', '', '', '', 1, 0)
Insert into AAColumnAlias values (0, '', 'Alive', 'ARRevenueForecastYear', N'Năm', 'ARRevenueForecasts', '', '', '', '', 1, 0)
Insert into AAColumnAlias values (0, '', 'Alive', 'FK_ARCustomerID', N'Mã khách hàng', 'ARRevenueForecasts', 'ARCustomers', 'ARCustomerNo', '', '', 1, 0)
Insert into AAColumnAlias values (0, '', 'Alive', 'ARCustomerType', N'Nhóm khách hàng', 'ARRevenueForecasts', '', '', '', '', 1, 0)
Insert into AAColumnAlias values (0, '', 'Alive', 'ARRevenueForecastRate', N'Tỷ lệ tăng giảm dự kiến', 'ARRevenueForecasts', '', '', '', '', 1, 0)

Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'RevenueForecast'), 1, 'fld_barbtnNew', '', 'New', 'Default', N'Tạo mới', 'Action', 0, 1, '', 0, '')
Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'RevenueForecast'), 1,'fld_barbtnEdit', '', 'Edit', 'Default', N'Sửa', 'Action', 1, 1, '', 0, '')
Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'RevenueForecast'), 1,'fld_barbtnCancel', '', 'Cancel', 'Default', N'Hủy', 'Action', 2, 1, '', 0, '')
Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'RevenueForecast'), 1,'fld_barbtnSave', '', 'Save', 'Default', N'Lưu', 'Action', 3, 1, '', 0, '')
Insert into STToolbars values ('Alive', (Select STModuleID from STModules Where STModuleName = 'RevenueForecast'), 1,'fld_barbtnComplete', '', 'Complete', 'Default', N'Duyệt', 'Action', 4, 1, '', 0, '')


Insert into ADConfigValues values ('Alive', 'RevenueForecastStatusNew', 'New', N'Tạo mới', N'Tạo mới', 'RevenueForecastStatus', 1)
Insert into ADConfigValues values ('Alive', 'RevenueForecastStatusConfirmed', 'Confirmed', N'Duyệt', N'Duyệt', 'RevenueForecastStatus', 1)

Insert into ADConfigValues values ('Alive', 'RoundingNumber1','1', '1', '1', 'RoundingNumber',1)
Insert into ADConfigValues values ('Alive', 'RoundingNumber1000','1000', N'Ngàn', '1', 'RoundingNumber',1)
Insert into ADConfigValues values ('Alive', 'RoundingNumber1000000','1000000', N'Triệu', '1', 'RoundingNumber',1)
Insert into ADConfigValues values ('Alive', 'RoundingNumber1000000000','1000000000', N'Tỷ', '1', 'RoundingNumber',1)

Insert into ADReports values (GetDate(), 'ADMIN', GetDate(), 'ADMIN', 'Alive', 1, 'RP_RevenueByCustomer1', N'BÁO CÁO DOANH THU CHI TIẾT THEO KH', N'BÁO CÁO DOANH THU CHI TIẾT THEO KH', 'Sale', N'Bán hàng', 'PrintViewer', (Select Max(ADReportSortOrder + 1) from ADReports Where ADReportSection = N'Bán hàng' and ADReportType = 'Sale'), 0)

Insert into ADConfigValues values ('Alive', 'ViewTypeMonth','Month', N'Tháng', 'Month', 'ViewType',1)
Insert into ADConfigValues values ('Alive', 'ViewTypeQuarter','Quarter', N'Quý', 'Quarter', 'ViewType',1)
Insert into ADConfigValues values ('Alive', 'ViewTypeYear','Year', N'Năm', 'Year', 'ViewType',1)