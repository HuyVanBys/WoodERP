DELETE dbo.STToolbarFunctions
WHERE STToolbarID IN (SELECT STToolbarID 
						FROM dbo.STToolbars 
						WHERE AAStatus = 'Alive'
						AND STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'SaleReturn')
						AND STToolbarTag IN ('Print','PrintView'))
GO

DELETE dbo.STToolbars
WHERE STToolbarID IN (SELECT STToolbarID 
						FROM dbo.STToolbars 
						WHERE AAStatus = 'Alive'
						AND STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'SaleReturn')
						AND STToolbarTag IN ('Print','PrintView'))
GO

-- Delete
DELETE STToolbarFunctions WHERE STToolbarID in (select FK_STToolbarID From ADTemplates a Join ADTemplateToolbars b On a.ADTemplateID = b.FK_ADTemplateID Where ADTemplateNo = 'RP_PrintSaleReturn')
DELETE STToolbars WHERE STToolbarID in (select FK_STToolbarID From ADTemplateToolbars a Join ADTemplates b On a.FK_ADTemplateID = b.ADTemplateID Where ADTemplateNo = 'RP_PrintSaleReturn')
DELETE ADTemplateToolbars WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PrintSaleReturn')
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_PrintSaleReturn')
DELETE ADTemplates WHERE ADTemplateNo = 'RP_PrintSaleReturn'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_PrintSaleReturn',N'In hàng bán trả lại',N'In hàng bán trả lại',N'RP_PrintSaleReturn',N'Alive',N'RP_PrintSaleReturn',1
INSERT INTO STToolbars (AAStatus,STModuleID,STUserGroupID,STToolbarName,STToolbarDesc,STToolbarTag,STToolbarStyle,STToolbarCaption,STToolbarGroup,STToolbarOrder,STToolbarVisible,STToolbarPrivilege,STToolbarParentID,STToolbarImage) SELECT N'Alive',31,1,N'fld_barbtnPrintView',N'Print view',N'PrintView',N'Default',N'Xem bản in',N'Utility',1,1,N'',0,N''
INSERT INTO ADTemplateToolbars (FK_ADTemplateID,FK_STToolbarID) SELECT (Select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PrintSaleReturn'),(select MAX(STToolbarID) From STToolbars)
INSERT INTO STToolbarFunctions (STToolbarFunctionIDString,STToolbarID,STToolbarFunctionName,STToolbarFunctionFullName,STToolbarFunctionClass,STToolbarFunctionSortOrder) SELECT N'0',(select MAX(STToolbarID) From STToolbars),N'ActionPrintTemplate',N'Void ActionPrintTemplate()',N'BOSERP.Modules.SaleReturn.SaleReturnModule',1
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'RP_PrintSaleReturn') DROP PROCEDURE RP_PrintSaleReturn
GO
CREATE PROCEDURE [dbo].[RP_PrintSaleReturn]
	@STModuleName	VARCHAR(50), 
	@SaleReturnID	INT
AS
BEGIN
	SET NOCOUNT ON;

	-- Detail
	SELECT	FORMAT(sri.ARSaleReturnItemProductUnitPrice, 'N2')	AS DonGia
		,	FORMAT(sri.ARSaleReturnItemProductQty, 'N3')		AS SoLuong
		,	sri.ARSaleReturnItemProductName						AS SanPham
		,	FORMAT(sri.ARSaleReturnItemTotalAmount, 'N2')		AS ThanhTien
		,	ISNULL(s.ICStockName, '')							AS Kho
		,	ISNULL(m.ICMeasureUnitName, '')						AS DVT
		,	sri.ARSaleReturnItemComment							AS GhiChu
	FROM dbo.ARSaleReturnItems sri (NOLOCK)
	OUTER APPLY
	(
		SELECT a.ICStockName
		FROM dbo.ICStocks a (NOLOCK)
		WHERE a.AAStatus = 'Alive' 
		AND a.ICStockID = sri.FK_ICStockID
	) AS s
	OUTER APPLY
	(
		SELECT b.ICMeasureUnitName
		FROM dbo.ICMeasureUnits b (NOLOCK)
		WHERE b.AAStatus = 'Alive'
		AND b.ICMeasureUnitID = sri.FK_ICMeasureUnitID
	) AS m
	WHERE sri.AAStatus = 'Alive'
	AND sri.FK_ARSaleReturnID = @SaleReturnID

	SELECT	sr.ARSaleReturnNo							AS MaChungTu
		,	sr.ARSaleReturnDate							AS NgayChungTu
		,	v.ACObjectName								AS TenKhachHang
		,	v.ACObjectContactAddressLine3				AS DiaChi
		,	v.ACObjectContactPhone						AS DienThoai
		,	v.ACObjectTaxNumber							AS MaSoThue
		,	iv.ARInvoiceNo								AS MaHoaDon
		,	iv.ARInvoiceDate							AS NgayHoaDon
		,	''											AS TKNo
		,	''											AS TKCo
		,	sr.ARSaleReturnDesc							AS GhiChu
		,	FORMAT(sr.ARSaleReturnSubTotalAmount,'N2')	AS TongCong
		,	FORMAT(sr.ARSaleReturnDiscountPerCent,'N0')	AS DiscountPerCent
		,	FORMAT(sr.ARSaleReturnDiscountFix, 'N2')	AS DiscountFix
		,	FORMAT(sr.ARSaleReturnTaxPercent, 'N0')		AS TaxPercent
		,	FORMAT(sr.ARSaleReturnTaxAmount, 'N2')		AS TaxAmount
		,	FORMAT(sr.ARSaleReturnTotalAmount, 'N2')	AS ThanhTien
		,	h.HREmployeeName							AS NhanVien
		,	dbo.FConvertAmountToWord(sr.ARSaleReturnTotalAmount,'2', ISNULL(cr.GECurrencyNo, 'VND')) as BangChu
	FROM dbo.ARSaleReturns sr (NOLOCK)
	OUTER APPLY
	(
		SELECT a.ACObjectName, a.ACObjectContactAddressLine3, a.ACObjectContactPhone, a.ACObjectTaxNumber
		FROM dbo.V_ACObjects a (NOLOCK)
		WHERE a.ACObjectID = sr.FK_ACObjectID
		AND	a.ACObjectType = sr.ARObjectType
	) AS v
	OUTER APPLY
	(
		SELECT b.ARInvoiceNo,	b.ARInvoiceDate
		FROM dbo.ARInvoices b (NOLOCK)
		WHERE b.AAStatus = 'Alive'
		AND b.ARInvoiceID = sr.FK_ARInvoiceID
	) AS iv
	OUTER APPLY
	(
		SELECT c.HREmployeeName
		FROM dbo.HREmployees c (NOLOCK)
		WHERE c.AAStatus = 'Alive'
		AND c.HREmployeeID = sr.FK_HREmployeeID
	) AS h
	OUTER APPLY
	(
		SELECT d.GECurrencyNo
		FROM dbo.GECurrencies d (NOLOCK)
		WHERE d.AAStatus = 'Alive'
			AND d.GECurrencyID = sr.FK_GECurrencyID
	) cr
	WHERE sr.AAStatus = 'Alive'
	AND sr.ARSaleReturnID = @SaleReturnID

	SELECT *
	FROM ThongTinCty(1)
END



