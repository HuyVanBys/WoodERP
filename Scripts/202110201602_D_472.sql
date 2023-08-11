UPDATE dbo.STToolbars 
SET AAStatus = 'Delete'
WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'ShipmentSaleOrder')
AND STToolbarTag = 'PrintProductCard'

UPDATE dbo.ADTemplateToolbars
SET FK_STToolbarID = (SELECT STToolbarID FROM dbo.STToolbars WHERE STModuleID = (SELECT STModuleID FROM dbo.STModules WHERE STModuleName = 'SemiProductReceipt') AND STToolbarTag = 'PrintProductCard')
WHERE FK_ADTemplateID = (SELECT ADTemplateID FROM dbo.ADTemplates WHERE ADTemplateNo = 'RP_PrintProductCard')

-- Delete
DELETE STToolbarFunctions WHERE STToolbarID in (select FK_STToolbarID From ADTemplates a Join ADTemplateToolbars b On a.ADTemplateID = b.FK_ADTemplateID Where ADTemplateNo = 'RP_PrintProductCard')
DELETE STToolbars WHERE STToolbarID in (select FK_STToolbarID From ADTemplateToolbars a Join ADTemplates b On a.FK_ADTemplateID = b.ADTemplateID Where ADTemplateNo = 'RP_PrintProductCard')
DELETE ADTemplateToolbars WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PrintProductCard')
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_PrintProductCard')
DELETE ADTemplates WHERE ADTemplateNo = 'RP_PrintProductCard'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_PrintProductCard',N'In thẻ kho thành phẩm',N'In thẻ kho thành phẩm',N'RP_PrintProductCard',N'Alive',N'',1
INSERT INTO STToolbars (AAStatus,STModuleID,STUserGroupID,STToolbarName,STToolbarDesc,STToolbarTag,STToolbarStyle,STToolbarCaption,STToolbarGroup,STToolbarOrder,STToolbarVisible,STToolbarPrivilege,STToolbarParentID,STToolbarImage) SELECT N'Alive',1205,1,N'fld_barbtnPrintProductCard',N'Thẻ kho thành phẩm',N'PrintProductCard',N'Default',N'Thẻ kho thành phẩm',N'Utility',3,1,N'',4043,N''
INSERT INTO ADTemplateToolbars (FK_ADTemplateID,FK_STToolbarID) SELECT (Select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PrintProductCard'),(select MAX(STToolbarID) From STToolbars)
INSERT INTO STToolbarFunctions (STToolbarFunctionIDString,STToolbarID,STToolbarFunctionName,STToolbarFunctionFullName,STToolbarFunctionClass,STToolbarFunctionSortOrder) SELECT N'',(select MAX(STToolbarID) From STToolbars),N'ActionPrintTemplate',N'Void ActionPrintTemplate()',N'BOSERP.Modules.SemiProductReceipt.SemiProductReceiptModule',1
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'RP_PrintProductCard') DROP PROCEDURE RP_PrintProductCard
GO
CREATE PROCEDURE [dbo].[RP_PrintProductCard]
	@STModuleName	VARCHAR(50), 
	@ReceiptID		INT
AS
BEGIN
	SET NOCOUNT ON;

	-- Detail
	SELECT	p.ICProductNo
		,	p.ICProductName
		,	p.ICProductNoOfOldSys
		,	REPLACE(REPLACE(p.ICProductImageFile, '/view?usp=sharing', ''), 'https://drive.google.com/file/d/', 'https://drive.google.com/uc?id=') AS ICProductImageFile
		,	so.ARSaleOrderNo		
		,	so.ARSaleOrderPONo				AS PONo
		,	o.ACObjectName					AS KhachHang
		,	p.ICProductCustomerNumber		AS MaSPDoiTac
		,	p.ICProductNo					AS MaSP
		,	ri.ICReceiptItemProductName		AS TenSP 
		,	FORMAT(soi.ARSaleOrderItemProductQty, 'N3') + ' ' + soi.MeasureUnitName AS SLSanPham
		,	FORMAT(soi.ARSaleOrderItemProductQty 
					/ CASE WHEN ISNULL(p.ICProductQtyInBox,0) = 0 THEN 1 ELSE p.ICProductQtyInBox END  
					* CASE WHEN ISNULL(packing.ICProductPackingDetailQty,0) = 0 THEN 1 ELSE packing.ICProductPackingDetailQty END, 'N0') + ' Box (es)' AS SLThung
		,	soi.ProductAttributeValue AS NguyenLieu
		,	FORMAT(p.ICProductNetWeight, 'N2') + ' kg'		AS NetWeight
		,	FORMAT(p.ICProductGrossWeight, 'N2') + ' kg'	AS GrossWeight
		,	FORMAT(packing.CBM, 'N3') + ' m3'				AS CBM
		,	p.MauSon 
		+	CASE WHEN ISNULL(p.ICProductColorAttribute, '') <> ''
				THEN ISNULL((SELECT '/' + ICProductAttributeValue
					FROM dbo.ICProductAttributes (NOLOCK)
					WHERE ICProductAttributeID IN (SELECT CAST(Name AS INT) FROM dbo.splitstring(p.ICProductColorAttribute))
					FOR XML PATH('')), '')
				ELSE '' END  AS MauSac
		,	CONCAT(CONVERT(varCHAR(5),p.ICProductQtyInBox),'/', CONVERT(varCHAR(10),CASE WHEN ISNULL(packing.ICProductPackingDetailQty,0) = 0 THEN 1 ELSE CONVERT(INT,packing.ICProductPackingDetailQty) END)) AS ICProductQtyInBox
		,	ISNULL((SELECT STUFF((SELECT DISTINCT CONCAT('/',NCHAR(10)) + FORMAT(ICProductPackingDetailLength, '#,###')
					FROM  dbo.ICProductPackingDetails (NOLOCK)
					WHERE AAStatus = 'Alive'
						AND FK_ICProductID = ri.FK_ICProductID
						AND ICProductPackingDetailLength > 0
						FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, '')
					),'0')
		+ 'x' + ISNULL((SELECT STUFF((SELECT DISTINCT CONCAT('/',NCHAR(10)) + FORMAT(ICProductPackingDetailWidth, '#,###')
					FROM  dbo.ICProductPackingDetails (NOLOCK)
					WHERE AAStatus = 'Alive'
						AND FK_ICProductID = ri.FK_ICProductID
						AND ICProductPackingDetailWidth > 0
						FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, '')
					),'0')
		+ 'x' + ISNULL((SELECT STUFF((SELECT DISTINCT CONCAT('/',NCHAR(10)) + FORMAT(ICProductPackingDetailHeight, '#,###')
					FROM  dbo.ICProductPackingDetails (NOLOCK)
					WHERE AAStatus = 'Alive'
						AND FK_ICProductID = ri.FK_ICProductID
						AND ICProductPackingDetailHeight > 0
						FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, '')
					),'0') + ' mm'AS CartonSize
	FROM dbo.ICReceiptItems ri (NOLOCK)
	INNER JOIN dbo.ICReceipts r (NOLOCK) ON r.AAStatus = 'Alive' AND r.ICReceiptID = ri.FK_ICReceiptID
	INNER JOIN dbo.MMBatchProductItems bpi ON bpi.MMBatchProductItemID = ri.FK_MMBatchProductItemID
	OUTER APPLY
	(
		SELECT a.ICProductNo, a.ICProductName, a.ICProductNoOfOldSys, a.ICProductDesc, a.ICProductWeight, a.ICProductLength, a.ICProductWidth, a.ICProductHeight
			,	a.ICProductNetWeight, a.ICProductGrossWeight, a.ICProductQtyInBox, a.ICProductImageFile, a.ICProductCustomerNumber,a.ICProductBlock, ISNULL(s.ICProductAttributeValue, '') AS MauSon, a.ICProductColorAttribute
		FROM dbo.ICProducts a (NOLOCK)
		LEFT JOIN dbo.ICProductAttributes s (NOLOCK) ON s.AAStatus = 'Alive' AND a.FK_ICProductAttributeColorID = s.ICProductAttributeID	
		WHERE a.AAStatus = 'Alive' 
		AND ri.FK_ICProductID = a.ICProductID
	) AS p
	OUTER APPLY
	(
		SELECT b.ARSaleOrderNo, b.ARSaleOrderPONo, b.FK_ACObjectID, b.ARObjectType
		FROM dbo.ARSaleOrders b (NOLOCK)
		WHERE b.AAStatus = 'Alive' 
		AND b.ARSaleOrderID = ri.FK_ARSaleOrderID
	) AS so
	OUTER APPLY
	(
		SELECT c.ARSaleOrderItemProductQty, ISNULL(m.ICMeasureUnitName, '') AS MeasureUnitName, ISNULL(ICProductAttributeValue, '') AS ProductAttributeValue
		FROM dbo.ARSaleOrderItems c (NOLOCK)
		LEFT JOIN dbo.ICMeasureUnits m (NOLOCK) ON m.AAStatus = 'Alive' AND m.ICMeasureUnitID = c.FK_ICMeasureUnitID
		LEFT JOIN dbo.ICProductAttributes pda (NOLOCK) ON pda.AAStatus = 'Alive' AND c.FK_ICProductAttributeWoodTypeID = pda.ICProductAttributeID	
		WHERE c.AAStatus = 'Alive' 
		AND c.FK_ARSaleOrderID = bpi.FK_ARSaleOrderID
		AND c.ARSaleOrderItemID = bpi.FK_ARSaleOrderItemID
	) AS soi
	OUTER APPLY
	(
		SELECT v.ACObjectName
		FROM dbo.V_ACObjects v
		WHERE v.ACObjectID = r.FK_ARCustomerID
		AND v.ACObjectType = 'Customer'
	) o
	OUTER APPLY
	(
		SELECT SUM(ICProductPackingDetailQty) AS ICProductPackingDetailQty,
			CAST(SUM(ICProductPackingDetailWidth * ICProductPackingDetailHeight * ICProductPackingDetailLength * ICProductPackingDetailQty/ 1000000000) AS DECIMAL(18,5)) AS CBM 
		FROM  dbo.ICProductPackingDetails (NOLOCK)
		WHERE AAStatus = 'Alive'
		AND FK_ICProductID = ri.FK_ICProductID
	) AS packing
	WHERE ri.AAStatus = 'Alive'
	AND r.ICReceiptID = @ReceiptID

	SELECT *
	FROM ThongTinCty(1)
END


