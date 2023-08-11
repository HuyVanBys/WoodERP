UPDATE dbo.ADReports 
SET AAStatus = 'Alive'
WHERE ADReportNo IN ('RP176', 'RP177')

-- Delete
DELETE ADReportViewRefParams WHERE FK_ADReportViewRefID in (select ADReportViewRefID From ADReportViewRefs where ADReportViewRefNo = 'SeekOrigin')
DELETE ADReportViewRefs WHERE ADReportViewRefNo = 'SeekOrigin'
DELETE STFieldFormats WHERE STFieldFormatTableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'SeekOrigin')
DELETE AAColumnAlias WHERE AATableName in (select ADTemplateDataSource From ADTemplates where ADTemplateNo = 'SeekOrigin')
DELETE ADReportTemplates WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'SeekOrigin')
DELETE ADReportPermissions WHERE FK_ADReportID in (select ADReportID From ADReports where ADReportNo = 'SeekOrigin')
DELETE ADReports WHERE ADReportNo = 'SeekOrigin'
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'SeekOrigin')
DELETE ADTemplates WHERE ADTemplateNo = 'SeekOrigin'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'SeekOrigin',N'Báo cáo truy xuất nguồn gốc nguyên liệu',N'Báo cáo truy xuất nguồn gốc nguyên liệu',N'RP_SeekOrigin',N'Alive',N'SeekOrigin',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Delete',N'FromDate',N'Từ ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'SeekOrigin'),0,N'DateTime',N'',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Delete',N'ToDate',N'Đến ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'SeekOrigin'),0,N'DateTime',N'',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'FK_MMBatchProductID',N'Lệnh sản xuất',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'SeekOrigin'),1,N'Number',N'MMBatchProducts',N'',N'AAStatus = ''Alive'' and MMBatchProductID > 0',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'SaleOrderID',N'Số PI/PO',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'SeekOrigin'),0,N'Number',N'ARSaleOrders',N'',N'AAStatus = ''Alive'' and ARSaleOrderID > 0',N'',N'',0
INSERT INTO ADReports (AACreatedDate,AACreatedUser,AAUpdatedDate,AAUpdatedUser,AAStatus,FK_GELanguageID,ADReportNo,ADReportName,ADReportDesc,ADReportType,ADReportSection,ADReportViewType,ADReportSortOrder,ADReportCopies) SELECT 'Oct 23 2020  5:15:05:723PM',N'','Oct 23 2020  5:15:05:723PM',N'',N'Alive',1,N'SeekOrigin',N'Báo cáo truy xuất nguồn gốc nguyên liệu',N'Báo cáo truy xuất nguồn gốc nguyên liệu',N'Inventory',N'Kho',N'PrintViewer',333335,0
INSERT INTO ADReportTemplates (FK_ADReportID,FK_ADTemplateID) SELECT (select ADReportID from ADReports where ADReportNo = 'SeekOrigin'),(select ADTemplateID from ADTemplates where ADTemplateNo = 'SeekOrigin')
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ShipmentRef',N'Số-Phiếu  xuất kho',N'SeekOrigin',N'',N'',N'',N'',NULL,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'SupplierName',N'Nhà cung cấp',N'SeekOrigin',N'',N'',N'',N'',NULL,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'PORef',N'Số-Hợp đồng',N'SeekOrigin',N'',N'',N'',N'',NULL,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'PIRef',N'Số-Đơn hàng',N'SeekOrigin',N'',N'',N'',N'',NULL,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'ProductName',N'Tên nguyên liệu',N'SeekOrigin',N'',N'',N'',N'',NULL,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'OriginName',N'Nguồn gốc',N'SeekOrigin',N'',N'',N'',N'',NULL,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'TKHDRef',N'Số-Tờ khai NK/ Hóa đơn',N'SeekOrigin',N'',N'',N'',N'',NULL,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'Qty',N'Khối lượng sử dụng',N'SeekOrigin',N'',N'',N'',N'',NULL,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'CustomerName',N'Khách hàng',N'SeekOrigin',N'',N'',N'',N'',NULL,0
INSERT INTO AAColumnAlias (AANumberInt,AANumberString,AAStatus,AAColumnAliasName,AAColumnAliasCaption,AATableName,AAReferenceTable,AADisplayedMember,AAFilteredColumn,AAFilteredValues,AAAllowDummy,AAColumnAliasIsSaveHistory) SELECT 0,N'',N'Alive',N'TTMT',N'Tình trạng môi trường',N'SeekOrigin',N'',N'',N'',N'',NULL,0
INSERT INTO STFieldFormats (STFieldFormatModuleName,STFieldFormatTableName,STFieldFormatGroupID,STFieldFormatColumnName) SELECT N'Report',N'SeekOrigin',4,N'Qty'
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'RP_SeekOrigin') DROP PROCEDURE RP_SeekOrigin
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RP_SeekOrigin]
--@FromDate DateTime,
--@ToDate DateTime,
@SaleOrderID  INT = NULL,
@BatchProductID  INT = NULL
AS
BEGIN

	SET NOCOUNT ON;

	SELECT 
		s.ICShipmentID,
		s.ICShipmentNo,
		s.FK_MMBatchProductID,
		s.FK_ICProductAttributeTTMTID
	INTO #Shipments
	FROM dbo.ICShipments (NOLOCK) s
		LEFT JOIN dbo.MMBatchProducts (NOLOCK) bp
			ON bp.MMBatchProductID = s.FK_MMBatchProductID
	WHERE s.AAStatus = 'Alive'
		AND (@BatchProductID IS NULL OR bp.MMBatchProductID = @BatchProductID)
		AND s.ICShipmentStatus = 'Complete'
		AND s.ICShipmentTypeCombo = 'DryLumber'

	SELECT
		bpi.MMBatchProductItemID,
		bpi.FK_ARSaleOrderID,
		bpi.FK_MMBatchProductID,
		bpi.FK_ACObjectID,
		bpi.ARObjectType,
		so.ARSaleOrderNo,
		so.ARSaleOrderPONo
	INTO #BachProductItems
	FROM dbo.MMBatchProducts(NOLOCK) bp
		LEFT JOIN dbo.MMBatchProductItems (NOLOCK) bpi ON bpi.FK_MMBatchProductID = bp.MMBatchProductID
		LEFT JOIN dbo.ARSaleOrders (NOLOCK) so ON so.ARSaleOrderID = bpi.FK_ARSaleOrderID
	WHERE bp.AAStatus = 'Alive'
		AND bpi.AAStatus = 'Alive'
		AND (@BatchProductID IS NULL OR bp.MMBatchProductID = @BatchProductID)
		AND (@SaleOrderID IS NULL OR bpi.FK_ARSaleOrderID = @SaleOrderID);

	SELECT 
		s.ICShipmentNo
		, so.ARSaleOrderNo
		, so.ARSaleOrderPONo
		, si.FK_ICProductID
		, si.FK_ICProductAttributeTTMTID
		, si.FK_GECountryID
		, si.ICShipmentItemProductExchangeQty
		, si.FK_ICProductSerieID
		, si.FK_ICStockID
		, si.ICShipmentItemProductName
		, si.FK_MMBatchProductItemID
		, vo.ACObjectName AS CustomerName
	INTO #ShipmentItems
	FROM #Shipments s
		INNER JOIN dbo.ICShipmentItems (NOLOCK) si ON si.FK_ICShipmentID = s.ICShipmentID
		INNER JOIN #BachProductItems (NOLOCK) bpi ON si.FK_MMBatchProductItemID = bpi.MMBatchProductItemID
		OUTER APPLY (
			SELECT 
				so.ARSaleOrderNo
				, so.ARSaleOrderPONo
			FROM dbo.ARSaleOrders (NOLOCK) so 
			WHERE so.AAStatus = 'Alive'
				AND so.ARSaleOrderID = bpi.FK_ARSaleOrderID
		) AS so
		OUTER APPLY (
			SELECT * FROM  dbo.V_ACObjects (NOLOCK) vo
			WHERE vo.ACObjectID = bpi.FK_ACObjectID
				AND vo.ACObjectType = bpi.ARObjectType
		) AS vo
	WHERE si.AAStatus = 'Alive'
		AND si.ICShipmentItemProductExchangeQty> 0 

	SELECT 
		ISNULL(cvi.ICReceiptID, ri.ICReceiptID) AS ICReceiptID
		, ISNULL(cvi.ICReceiptNo, ri.ICReceiptNo) AS ICReceiptNo
		, si.FK_ICStockID
		, si.FK_ICProductID
		, si.FK_ICProductSerieID
		, ISNULL(cvi.FK_APPurchaseOrderID, ri.FK_APPurchaseOrderID) AS FK_APPurchaseOrderID
		, CASE 
			WHEN ISNULL(cvi.FK_APInvoiceInID, 0) = 0 THEN  ri.FK_APInvoiceInID 
			ELSE cvi.FK_APInvoiceInID
		  END AS FK_APInvoiceInID
		, CASE 
			WHEN ISNULL(cvi.FK_ACAssObjectID, 0) = 0 THEN  ri.FK_ACAssObjectID 
			ELSE cvi.FK_ACAssObjectID
		  END AS FK_ACObjectID
		, CASE 
			WHEN ISNULL(cvi.ICAssObjectType, '') = '' THEN  ri.ICAssObjectType 
			ELSE cvi.ICAssObjectType
		  END AS ACObjectType
	INTO #ReceiptItems
	FROM #ShipmentItems si
		OUTER APPLY (
			SELECT 
				r.ICReceiptID
				, r.ICReceiptNo
				, ri.FK_ICProductID
				, ri.FK_ICProductSerieID
				, ri.FK_ICStockID
				, ri.ICReceiptItemProductSerialNo
				, ri.FK_APPurchaseOrderID
				, ri.FK_APInvoiceInID
				, r.FK_ACAssObjectID
				, r.ICAssObjectType
			FROM dbo.ICReceiptItems ri
				INNER JOIN dbo.ICReceipts r ON r.ICReceiptID = ri.FK_ICReceiptID
			WHERE ri.FK_ICProductID = si.FK_ICProductID
				AND ri.FK_ICStockID = si.FK_ICStockID
				AND ri.FK_ICProductSerieID = si.FK_ICProductSerieID
		) AS ri
		OUTER APPLY (
			SELECT 
				pci.FK_ICProductSerieID
				, pci.ICProductConversionItemProductSerialNo
				, pci.FK_ICStockID
				, pci.FK_ICReceiptItemID
				, pci.FK_ICProductID
				, parent.FK_ICProductID AS ParentProductID
				, parent.FK_ICStockID AS ParentStockID 
				, parent.FK_ICProductSerieID AS ParentSerieID
			FROM dbo.ICProductConversions pc
				INNER JOIN dbo.ICProductConversionItems pci ON pci.FK_ICProductConversionID = pc.ICProductConversionID
				OUTER APPLY (
					SELECT * 
					FROM dbo.ICProductConversionItems parent
					WHERE parent.AAStatus = 'Alive'
						--AND parent.ICProductConversionItemType = 'Source'
						AND parent.ICProductConversionItemID = pci.ICProductConversionItemParentID
				) AS parent
			WHERE pc.AAStatus = 'Alive'
				AND pci.AAStatus = 'Alive'
				--AND pci.ICProductConversionItemType = 'Target'
				AND pci.FK_ICProductID = si.FK_ICProductID
				AND pci.FK_ICStockID = si.FK_ICStockID
				AND pci.FK_ICProductSerieID = si.FK_ICProductSerieID
		) AS pci
		OUTER APPLY (
				SELECT 
					r2.ICReceiptID
					, r2.ICReceiptNo
					, ri2.FK_APPurchaseOrderID
					, ri2.FK_APInvoiceInID
					, r2.FK_ACAssObjectID
					, r2.ICAssObjectType
				FROM dbo.ICReceipts (NOLOCK) r2
					INNER JOIN dbo.ICReceiptItems (NOLOCK) ri2 ON ri2.FK_ICReceiptID = r2.ICReceiptID
				WHERE ri2.AAStatus = 'Alive'
					AND ri2.FK_ICProductID = ISNULL(pci.ParentProductID ,pci.FK_ICProductID)
					--AND ri2.FK_ICStockID = ISNULL(pci.ParentStockID, pci.FK_ICStockID)
					AND ri2.FK_ICProductSerieID = ISNULL(pci.ParentSerieID, pci.FK_ICProductSerieID)
		) AS cvi
	WHERE ISNULL(cvi.ICReceiptID, ri.ICReceiptID) IS NOT NULL

	SELECT 
		si.ICShipmentNo
		, si.ARSaleOrderNo
		, si.ARSaleOrderPONo
		, si.CustomerName
		, ICShipmentItemProductName
		, si.FK_ICProductID
		, ISNULL(c.GECountryName, '') AS GECountryName
		, ISNULL(pa.ICProductAttributeValue, '') AS TTMT
		, si.ICShipmentItemProductExchangeQty
		, ISNULL(iv.APInvoiceInNoRef, '') AS APInvoiceInNoNDRef
		, ISNULL(bill.APInvoiceInSupplierNo,'') AS APInvoiceInNoNKRef
		, ISNULL(bill.APBillOfLadingNoRef,'') AS APBillOfLadingNoRef
		, ISNULL(s.ACObjectName, '') AS SupplierName
		, si.FK_ICProductSerieID
	INTO #DataResult
	FROM #ShipmentItems si
		INNER JOIN dbo.ICProductSeries ps ON ps.ICProductSerieID = si.FK_ICProductSerieID
		OUTER APPLY (
			SELECT TOP 1 inv.FK_ACAssObjectID,
			inv.APAssObjectType
			FROM dbo.APInvoiceIns inv 
			WHERE inv.APInvoiceInPackNo = ps.ICProductSerieLotNo
			AND inv.AAStatus = 'Alive'
			AND inv.APInvoiceInType <> 'OutSourcing'
		) ncc
		OUTER APPLY (
			SELECT 
				c.GECountryName
			FROM dbo.GECountrys (NOLOCK) c
			WHERE c.AAStatus = 'Alive'
				AND c.GECountryID = ps.FK_GECountryID
		) AS c
		OUTER APPLY (
			SELECT 
				pa.ICProductAttributeValue
			FROM dbo.ICProductAttributes (NOLOCK) pa
			WHERE pa.AAStatus = 'Alive'
				AND pa.ICProductAttributeID = ps.FK_ICProductAttributeTTMTID
		) AS pa
		OUTER APPLY (
			SELECT 
				TOP 1
				ri.*
			FROM #ReceiptItems ri
			WHERE ri.FK_ICStockID = si.FK_ICStockID
				AND ri.FK_ICProductID = si.FK_ICProductID
				AND ri.FK_ICProductSerieID = si.FK_ICProductSerieID
		) AS r
		OUTER APPLY (
			SELECT 
				ac.ACObjectName
			FROM dbo.V_ACObjects (NOLOCK) ac
			WHERE ac.ACObjectID = ncc.FK_ACAssObjectID
				AND ac.ACObjectType = ncc.APAssObjectType
		) AS s
		-- Nội địa
		OUTER APPLY(
			SELECT 
				STUFF((SELECT   LTRIM(i.APInvoiceInSupplierNo) + ', '  
				FROM APInvoiceIns (NOLOCK) i
					INNER JOIN dbo.APInvoiceInItems (NOLOCK) ii ON ii.FK_APInvoiceInID = i.APInvoiceInID 
					WHERE ii.AAStatus = 'Alive'
						AND i.AAStatus = 'Alive'
						AND  ISNULL( LTRIM(i.APInvoiceInSupplierNo),'') <> ''
						AND ii.FK_ICReceiptID = r.ICReceiptID
				GROUP BY APInvoiceInSupplierNo FOR XML PATH ('')), 1, 1, '') AS APInvoiceInNoRef
		) AS iv
		--Nhập khẩu
		OUTER APPLY(
			SELECT
				LTRIM(i.APInvoiceInSupplierNo) AS APInvoiceInSupplierNo
				, STUFF((SELECT ', ' +  LTRIM(b.APBillOfLadingNo) FROM APBillOfLadings (NOLOCK) b WHERE b.FK_APInvoiceInID = i.APInvoiceInID
				AND ISNULL( LTRIM(APBillOfLadingNo), '') <> '' GROUP BY APBillOfLadingNo FOR XML PATH ('')), 1, 1, '')  AS APBillOfLadingNoRef
			FROM dbo.APInvoiceIns (NOLOCK) i
			WHERE i.APInvoiceInID = r.FK_APInvoiceInID
				AND  i.AAStatus = 'Alive'
		) AS bill

	SELECT 
		rs.CustomerName
		, rs.ICShipmentItemProductName AS ProductName
		, rs.FK_ICProductID
		, rs.TTMT
		, rs.GECountryName AS OriginName
		, rs.SupplierName
		, SUM(rs.ICShipmentItemProductExchangeQty) AS Qty--ShipmentQty  
		, ref.ShipmentRef
		, ref.SaleOrderNoRef AS PIRef
		, ref.SaleOrderPoNoRef AS PORef
		, ref.BillNoRef AS TKHDRef
	FROM #DataResult rs
		OUTER APPLY (
			SELECT
				(
					STUFF((SELECT
						', ' + s.ICShipmentNo
					FROM #DataResult s 
					WHERE s.CustomerName = rs.CustomerName
						AND s.FK_ICProductID = rs.FK_ICProductID
						AND s.TTMT = rs.TTMT
						AND s.GECountryName = rs.GECountryName
						AND s.SupplierName = rs.SupplierName
					GROUP BY s.ICShipmentNo
					FOR XML PATH ('')), 1, 1, '')
				) AS ShipmentRef,
				(
					STUFF((SELECT
						', ' + s.ARSaleOrderNo
					FROM #DataResult s 
					WHERE s.CustomerName = rs.CustomerName
						AND s.FK_ICProductID = rs.FK_ICProductID
						AND s.TTMT = rs.TTMT
						AND s.GECountryName = rs.GECountryName
						AND s.SupplierName = rs.SupplierName
					GROUP BY s.ARSaleOrderNo
					FOR XML PATH ('')), 1, 1, '')
				) AS SaleOrderNoRef,
				(
					STUFF((SELECT
						', ' + s.ARSaleOrderPONo
					FROM #DataResult s 
					WHERE s.CustomerName = rs.CustomerName
						AND s.FK_ICProductID = rs.FK_ICProductID
						AND s.TTMT = rs.TTMT
						AND s.GECountryName = rs.GECountryName
						AND s.SupplierName = rs.SupplierName
						AND ISNULL(s.ARSaleOrderPONo, '') <> ''
					GROUP BY s.ARSaleOrderPONo
					FOR XML PATH ('')), 1, 1, '')
				) AS SaleOrderPoNoRef,
				(
					STUFF((SELECT
						  CASE	
								WHEN s.APInvoiceInNoNDRef = '' AND s.APInvoiceInNoNKRef = '' THEN s.APBillOfLadingNoRef
								WHEN (s.APInvoiceInNoNDRef = '' OR s.APInvoiceInNoNKRef <> '') AND s.APBillOfLadingNoRef <> '' THEN s.APInvoiceInNoNKRef +  s.APInvoiceInNoNKRef + '(' + APBillOfLadingNoRef + ')'
								ELSE s.APInvoiceInNoNKRef +  s.APInvoiceInNoNDRef 
							END 
					FROM #DataResult s 
					WHERE s.CustomerName = rs.CustomerName
						AND s.FK_ICProductID = rs.FK_ICProductID
						AND s.TTMT = rs.TTMT
						AND s.GECountryName = rs.GECountryName
						AND s.SupplierName = rs.SupplierName
					GROUP BY s.APInvoiceInNoNDRef
						, s.APInvoiceInNoNKRef
						, APBillOfLadingNoRef
					FOR XML PATH ('')), 1, 1, '')
				) AS BillNoRef
		) AS ref
	GROUP BY rs.CustomerName
		, rs.ICShipmentItemProductName
		, rs.FK_ICProductID
		, rs.TTMT
		, rs.GECountryName
		, rs.SupplierName
		, ref.ShipmentRef
		, ref.SaleOrderNoRef
		, ref.SaleOrderPoNoRef
		, ref.BillNoRef

	DROP TABLE #Shipments;
	DROP TABLE #BachProductItems;
	DROP TABLE #ShipmentItems
	DROP TABLE #DataResult
	DROP TABLE #ReceiptItems
			
END
