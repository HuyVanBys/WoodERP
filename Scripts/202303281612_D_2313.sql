-- Delete
DELETE ADReportViewRefParams WHERE FK_ADReportViewRefID in (select ADReportViewRefID From ADReportViewRefs where ADReportViewRefNo = 'RP_IncomeStatement')
DELETE ADReportViewRefs WHERE ADReportViewRefNo = 'RP_IncomeStatement'
DELETE STFieldFormats WHERE STFieldFormatTableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RP_IncomeStatement')
DELETE AAColumnAlias WHERE AATableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'RP_IncomeStatement')
DELETE ADReportTemplates WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_IncomeStatement')
DELETE ADReportPermissions WHERE FK_ADReportID in (select ADReportID From ADReports where ADReportNo = 'RP_IncomeStatement')
DELETE ADReports WHERE ADReportNo = 'RP_IncomeStatement'
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_IncomeStatement')
DELETE ADTemplates WHERE ADTemplateNo = 'RP_IncomeStatement'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_IncomeStatement',N'Báo cáo kinh doanh chi tiết',N'Báo cáo kinh doanh chi tiết',N'RP_IncomeStatement',N'Alive',N'RP_IncomeStatement',1
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'FromDate',N'Từ ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_IncomeStatement'),0,N'Date',N'',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'ToDate',N'Đến ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_IncomeStatement'),1,N'Date',N'',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'ARCustomerID',N'Đối tượng',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_IncomeStatement'),2,N'Number',N'ARCustomers',N'',N'AAStatus = ''Alive''',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'ARSaleOrderSaleType',N'Hình thức bán hàng',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_IncomeStatement'),3,N'String',N'ADConfigValues',N'',N'AAStatus = ''Dummy'' or AAStatus = ''Alive'' and ADConfigKeyGroup = ''SaleOrderSaleType''',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'ARCustomerType',N'Loại khách hàng',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_IncomeStatement'),4,N'String',N'ADConfigValues',N'',N'AAStatus = ''Dummy'' or AAStatus = ''Alive'' and ADConfigKeyGroup = ''CustomerType''',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'ICProductID',N'Sản phẩm',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_IncomeStatement'),5,N'Number',N'ICProducts',N'',N'AAStatus = ''Alive''',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Delete',N'SalesOrRevenue',N'Doanh số',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_IncomeStatement'),6,N'Bit',N'',N'',N'',N'',N'',1
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Delete',N'SalesOrRevenueCombo',N'Doanh số & Doanh thu',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_IncomeStatement'),7,N'String',N'ADConfigValues',N'',N'AAStatus = ''Dummy'' or AAStatus = ''Alive'' and ADConfigKeyGroup = ''SalesOrRevenue''',N'',N'',1
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'ARSalesOrRevenueCombo',N'Doanh số & Doanh thu',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_IncomeStatement'),7,N'String',N'',N'',N'AAStatus = ''Alive'' and ADConfigKeyGroup = ''SalesOrRevenue''',N'',N'',1
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'HREmployeeID',N'Nhân viên bán hàng',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_IncomeStatement'),6,N'Number',N'HREmployees',N'',N'AAStatus = ''Alive''',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'ICProductGroupID',N'Nhóm hàng',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_IncomeStatement'),8,N'multiselect',N'ICProductGroups',N'ICProductGroupName',N'AAStatus = ''Alive''',N'',N'',0
INSERT INTO ADReports (AACreatedDate,AACreatedUser,AAUpdatedDate,AAUpdatedUser,AAStatus,FK_GELanguageID,ADReportNo,ADReportName,ADReportDesc,ADReportType,ADReportSection,ADReportViewType,ADReportSortOrder,ADReportCopies) SELECT 'Mar 24 2023  3:02:10:850PM',N'Admin','Mar 24 2023  3:02:10:850PM',N'Admin',N'Alive',1,N'RP_IncomeStatement',N'Báo cáo kinh doanh chi tiết',N'Báo cáo kinh doanh chi tiết',N'Sale',N'Bán hàng',N'PrintViewer',333342,0
INSERT INTO ADReportTemplates (FK_ADReportID,FK_ADTemplateID) SELECT (select ADReportID from ADReports where ADReportNo = 'RP_IncomeStatement'),(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP_IncomeStatement')
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ARSaleOrderNo',N'Mã đơn hàng',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ARInvoiceNo',N'Mã hoá đơn',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICShipmentNo',N'Mã xuất kho bán hàng',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'GECurrencyName',N'Loại tiền tệ',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ARListOfSalesChannelType',N'Kênh bán hàng',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICDepartmentName',N'Ngành hàng',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICProductGroupName',N'Nhóm hàng',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICProductNoOfOldSys',N'Mã hệ thống cũ',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICProductNo',N'Mã sản phẩm',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICProductName',N'Tên sản phẩm',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ARSaleOrderItemProductUnitPrice',N'Đơn giá',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ARSaleOrderItemProductQty',N'Số lượng',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ARSaleOrderItemTaxAmount',N'Tiền thuế',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ARSaleOrderItemDiscountAmount',N'Tiền chiết khấu',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ARSaleOrderItemDiscountPrice',N'Giá trước chiết khấu',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ARSaleOrderItemGroupDiscount',N'Giá sau chiết khấu',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ICProductCustomerNumber',N'Mã sản phẩm khách hàng',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ARSaleOrderItemTotalAmount',N'Thành tiền ngoại tệ',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'DoanhThuTruocThue',N'Doanh thu trước thuế',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'DoanhThuSauThue',N'Doanh thu sau thuế',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ARCustomerName',N'Tên khách hàng',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ARCustomerType',N'Loại khách hàng',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'HREmployeeName',N'Nhân viên bán hàng',N'RP_IncomeStatement',N'',N'',N'',N'',1,1
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName,STChangeByCurrency,STChangeByDepartment) SELECT N'Report',N'RP_IncomeStatement',8,N'ARSaleOrderItemProductUnitPrice',1,0
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName,STChangeByCurrency,STChangeByDepartment) SELECT N'Report',N'RP_IncomeStatement',8,N'ARSaleOrderItemProductQty',1,0
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName,STChangeByCurrency,STChangeByDepartment) SELECT N'Report',N'RP_IncomeStatement',8,N'ARSaleOrderItemTaxAmount',1,0
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName,STChangeByCurrency,STChangeByDepartment) SELECT N'Report',N'RP_IncomeStatement',8,N'ARSaleOrderItemDiscountAmount',1,0
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName,STChangeByCurrency,STChangeByDepartment) SELECT N'Report',N'RP_IncomeStatement',8,N'ARSaleOrderItemGroupDiscount',1,0
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName,STChangeByCurrency,STChangeByDepartment) SELECT N'Report',N'RP_IncomeStatement',8,N'ARSaleOrderItemDiscountPrice',1,0
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName,STChangeByCurrency,STChangeByDepartment) SELECT N'Report',N'RP_IncomeStatement',8,N'ARSaleOrderItemTotalAmount',1,0
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName,STChangeByCurrency,STChangeByDepartment) SELECT N'Report',N'RP_IncomeStatement',8,N'DoanhThuTruocThue',1,0
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName,STChangeByCurrency,STChangeByDepartment) SELECT N'Report',N'RP_IncomeStatement',8,N'DoanhThuSauThue',1,0
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'RP_IncomeStatement') DROP PROCEDURE RP_IncomeStatement
GO
CREATE Procedure [dbo].[RP_IncomeStatement] 
	@FromDate datetime,
	@ToDate datetime,
	@CustomerID int = null,
	@SaleOrderSaleType nvarchar(50) = null,
	@CustomerType nvarchar(50) = null,
	@ProductID int = null,
	@HREmployeeID int = null,
	@SaleOrRevenue nvarchar(50),
	@ICProductGroupID nvarchar(200)
as
begin
	set nocount on;
	Declare @ProductGroups table(
		ProductGroupID int
		)
	INSERT INTO @ProductGroups
	SELECT ICProductGroupID FROM dbo.ICProductGroups s 
	WHERE s.AAStatus ='Alive'
	AND ( @ICProductGroupID IS NULL OR s.ICProductGroupID IN ((SELECT * FROM dbo.FSplitStringByCharater(@ICProductGroupID,','))))

	Create table #SaleOrder(
		ARSaleOrderID int
		)

	if @SaleOrRevenue = 'Sales'
	begin
	insert into #SaleOrder
	Select distinct ARSaleOrderID
	from ARSaleOrders so
	inner join ARSaleOrderItems soi on soi.AAStatus = 'Alive' and soi.FK_ARSaleOrderID = so.ARSaleOrderID
	inner join ARCustomers c on c.AAStatus = 'Alive' and c.ARCustomerID = so.FK_ACObjectID and so.ARObjectType = 'Customer'
	inner join ICProducts p on p.AAStatus = 'Alive' and p.ICProductID = soi.FK_ICProductID
	inner join @ProductGroups pg on p.FK_ICProductGroupID = pg.ProductGroupID
	Where so.AAStatus = 'Alive'
	and DateDiff(dd, ARSaleOrderDate, @FromDate) <= 0
	and DateDiff(dd, ARSaleOrderDate, @ToDate) >= 0
	and ARSaleOrderStatus in ('Confirmed', 'Shipped','Incomplete','Complete')
	and (@SaleOrderSaleType is null or @SaleOrderSaleType = ARSaleOrderSaleType)
	and (@CustomerType is null or @CustomerType = c.ARCustomerTypeCombo)
	and (@ProductID is null or @ProductID = soi.FK_ICProductID)
	and (@HREmployeeID is null or @HREmployeeID = so.FK_ARSellerID)

	end
	else if @SaleOrRevenue = 'Revenue'
	begin
	insert into #SaleOrder
	Select distinct ARSaleOrderID
	from ARSaleOrders so
	inner join ARSaleOrderItems soi on soi.AAStatus = 'Alive' and soi.FK_ARSaleOrderID = so.ARSaleOrderID
	inner join ARInvoiceItems ii on ii.AAStatus = 'Alive' and ii.FK_ARSaleOrderID = so.ARSaleOrderID
	inner join ARInvoices i on ii.FK_ARInvoiceID = i.ARInvoiceID and i.AAStatus = 'ALive'
	inner join ARCustomers c on c.ARCustomerID = so.FK_ACObjectID and so.ARObjectType = 'Customer'
	inner join ICProducts p on p.AAStatus = 'Alive' and p.ICProductID = soi.FK_ICProductID
	inner join @ProductGroups pg on p.FK_ICProductGroupID = pg.ProductGroupID
	Where so.AAStatus = 'Alive'
	and DateDiff(dd, ARSaleOrderDate, @FromDate) <= 0
	and DateDiff(dd, ARSaleOrderDate, @ToDate) >= 0
	and (@SaleOrderSaleType is null or @SaleOrderSaleType = so.ARSaleOrderSaleType)
	and (@CustomerType is null or @CustomerType = c.ARCustomerTypeCombo)
	and (@ProductID is null or @ProductID = soi.FK_ICProductID)
	end
	Create table #result(
		sort int,
		ARSaleOrderNo nvarchar(200),
		ARInvoiceNo nvarchar(512),
		ICShipmentNo nvarchar(512),
		GECurrencyName nvarchar(20),
		ARListOfSalesChannelType nvarchar(200),
		ICDepartmentName nvarchar(200),
		ICProductGroupName nvarchar(200),
		ICProductNoOfOldSys nvarchar(200),
		ICProductCustomerNumber nvarchar(200),
		ICProductNo nvarchar(200),
		ICProductName nvarchar(512),
		ARSaleOrderItemProductUnitPrice  decimal(18,5),
		ARSaleOrderItemProductQty decimal(18,5),
		ARSaleOrderItemTaxAmount decimal(18,5),
		ARSaleOrderItemDiscountAmount decimal(18,5),
		ARSaleOrderItemDiscountPrice decimal(18,5),
		ARSaleOrderItemGroupDiscount decimal(18,5),
		ARSaleOrderItemTotalAmount decimal(18,5),
		DoanhThuTruocThue decimal(18,5),
		DoanhThuSauThue decimal(18,5),
		ARCustomerName nvarchar(100),
		ARCustomerType nvarchar(100),
		HREmployeeName nvarchar(100)
		)
-- Chi tiết
	insert into #result
	Select
		1 as sort,
		so.ARSaleOrderNo,
		isnull(Stuff((Select Distinct ',' +  ARInvoiceNo
				from ARInvoices i
				inner join ARInvoiceItems ii on i.ARInvoiceID = ii.FK_ARInvoiceID
				Where ii.FK_ARSaleOrderID = so.ARSaleOrderID
			 for XML PATH ('')
			 ), 1,1, ''),'') as ARInvoiceNo,
		isnull(Stuff((Select Distinct ',' + ICShipmentNo  
				from ICShipments i
				inner join ICShipmentItems ii on i.ICShipmentID = ii.FK_ICShipmentID
				Where ii.FK_ARSaleOrderID = so.ARSaleOrderID
			 for XML PATH ('')
			 ), 1,1, ''),'') as ICShipmentNo,
		cu.GECurrencyName,
		cv.ADConfigText as ARListOfSalesChannelType,
		d.ICDepartmentName as ICDepartmentName,
		pg.ICProductGroupName as ICProductGroupName,
		p.ICProductNoOfOldSys as ICProductNoOfOldSys,
		p.ICProductCustomerNumber as ICProductCustomerNumber,
		p.ICProductNo as ICProductNo,
		p.ICProductName as ICProductName,
		soi.ARSaleOrderItemProductUnitPrice as ARSaleOrderItemProductUnitPrice,
		soi.ARSaleOrderItemProductQty as ARSaleOrderItemProductQty,
		soi.ARSaleOrderItemTaxAmount as ARSaleOrderItemTaxAmount,
		soi.ARSaleOrderItemDiscountAmount as ARSaleOrderItemDiscountAmount,
		soi.ARSaleOrderItemProductUnitPrice as ARSaleOrderItemDiscountPrice,
		soi.ARSaleOrderItemProductGroupDiscount as ARSaleOrderItemGroupDiscount,
		soi.ARSaleOrderItemTotalAmount,
		DoanhThu.DoanhThuTruocThue,
		DoanhThu.DoanhThuSauThue,
		c.ARCustomerName,
		lkh.ADConfigText as ARCustomerType,
		e.HREmployeeName
	from  ARSaleOrders so
	inner join ARSaleOrderItems soi on soi.AAStatus = 'Alive' and soi.FK_ARSaleOrderID = so.ARSaleOrderID
	inner join ICProducts p on p.AAStatus = 'Alive' and p.ICProductID = soi.FK_ICProductID
	inner join ICDepartments d on d.AAStatus = 'Alive' and d.ICDepartmentID = p.FK_ICDepartmentID
	inner join ICProductGroups pg on pg.AAStatus = 'Alive' and pg.ICProductGroupID = p.FK_ICProductGroupID
	inner join ARCustomers c on c.ARCustomerID = so.FK_ACObjectID and so.ARObjectType = 'Customer'
	left join ADConfigValues lkh on lkh.AAStatus = 'Alive' and lkh.ADConfigKeyValue = c.ARCustomerTypeCombo and lkh.ADConfigKeyGroup = 'CustomerType'
	left join GECurrencies cu on cu.AAStatus = 'Alive' and cu.GECurrencyID = so.FK_GECurrencyID
	left join ADConfigValues cv on cv.AAStatus = 'Alive' and cv.ADConfigKeyValue = so.ARListOfSalesChannelType and cv.ADConfigKeyGroup = 'ListOfSalesChannelType'
	left join HREmployees e on e.AAStatus = 'Alive' and e.HREmployeeID = so.FK_ARSellerID
	outer apply (
		Select Sum(ii.ARInvoiceItemTotalAmount) as DoanhThuTruocThue,
				Sum(ii.ARInvoiceItemTotalAmount * i.ARInvoiceTaxPercent / 100) as DoanhThuSauThue
		from ARInvoiceItems ii
		inner join ARInvoices i on i.AAStatus = 'Alive' and i.ARInvoiceID = ii.FK_ARInvoiceID
		Where ii.AAStatus = 'Alive'
		and ii.FK_ARSaleOrderItemID = soi.ARSaleORderItemID
		) as DoanhThu
	Where so.ARSaleOrderID in (Select * from #SaleOrder)
	and (@ProductID is null or soi.FK_ICProductID = @ProductID)
	and pg.ICProductGroupID in (select * from @ProductGroups)
Select * from #result
Order by ARSaleOrderNo, sort

drop table #SaleOrder
drop table #result
end
