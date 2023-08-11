----ĐÃ CHẠY WOOD_TEST

-- Delete
DELETE STToolbarFunctions WHERE STToolbarID in (select FK_STToolbarID From ADTemplates a Join ADTemplateToolbars b On a.ADTemplateID = b.FK_ADTemplateID Where ADTemplateNo = 'RP332')
DELETE STToolbars WHERE STToolbarID in (select FK_STToolbarID From ADTemplateToolbars a Join ADTemplates b On a.FK_ADTemplateID = b.ADTemplateID Where ADTemplateNo = 'RP332')
DELETE ADTemplateToolbars WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP332')
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP332')
DELETE ADTemplates WHERE ADTemplateNo = 'RP332'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP332',N'BẢNG KÊ HÓA ĐƠN, CHỨNG TỪ HÀNG HÓA, DỊCH VỤ MUA VÀO ĐƯỢC HOÀN THUẾ (MẪU 01-1/HT, TT80)',N'Bảng kê HD, chứng từ HH, DV mua vào (01)',N'VAPInvoiceInVatIns_Reports',N'Alive',N'RP332',1
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'FromDate',N'Từ ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP332'),0,N'Date',N'',N'',N'',N'',N'',0
INSERT INTO ADTemplateParams (AAStatus,ADTemplateParamNo,ADTemplateParamName,ADTemplateParamValue,ADTemplateParamIsDisplay,FK_ADTemplateID,ADTemplateParamOrder,ADTemplateParamDataType,ADTemplateParamLookupEdit,ADTemplateParamColumns,ADTemplateParamFilter,ADTemplateParamParentField,ADTemplateParamFieldRelation,ADTemplateParamIsNotNull) SELECT N'Alive',N'ToDate',N'Đến ngày',N'',1,(select ADTemplateID from ADTemplates where ADTemplateNo = 'RP332'),1,N'Date',N'',N'',N'',N'',N'',0
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'VAPInvoiceInVatIns_Reports') DROP PROCEDURE VAPInvoiceInVatIns_Reports
GO
CREATE PROCEDURE [dbo].[VAPInvoiceInVatIns_Reports]
	@Fromdate date
	,@ToDate date
AS
BEGIN

	SET NOCOUNT ON;

select *
	, CONVERT(varchar, vat.APInvoiceInSupplierDate, 103) AS APInvoiceInSupplierDate2
into #rpts
from VAPInvoiceInVatInsForReports  vat
where DATEDIFF(DD,@Fromdate , vat.APInvoiceInReferenceDate) >= 0  
	and DATEDIFF(DD,vat.APInvoiceInReferenceDate ,@ToDate ) >= 0  
	and vat.APInvoiceInSupplierNo <>''
	--and vat.APInputVATDocumentType <> ''

	-----Xử lý chênh lệch thuế item và thuế tổng-----
	SELECT v.APInvoiceInReferenceNo
		, v.APInvoiceInReferenceID
		, v.APInvoiceInModuleName
		, v.FK_ACObjectID
		, v.ObjectType
		, v.APInvoiceInTotalTaxAmount - SUM(v.APInvoiceInTaxAmount) AS ChenhLechThue
	INTO #ChenhLech
	FROM #rpts v
	WHERE v.APInvoiceInTotalTaxAmount IS NOT NULL
	GROUP BY v.APInvoiceInReferenceNo
		, v.APInvoiceInReferenceID
		, v.APInvoiceInModuleName
		, v.FK_ACObjectID
		, v.ObjectType
		, v.APInvoiceInTotalTaxAmount
	HAVING v.APInvoiceInTotalTaxAmount - SUM(v.APInvoiceInTaxAmount) <> 0
	
	UPDATE a
	SET a.APInvoiceInTaxAmount = a.APInvoiceInTaxAmount + up.ChenhLechThue
	FROM #rpts a
	INNER JOIN #ChenhLech up ON up.APInvoiceInReferenceNo = a.APInvoiceInReferenceNo 
							AND up.APInvoiceInReferenceID = a.APInvoiceInReferenceID
							AND up.APInvoiceInModuleName = a.APInvoiceInModuleName
							AND up.FK_ACObjectID = a.FK_ACObjectID
							AND up.ObjectType = a.ObjectType
	WHERE a.APInvoiceInItemReferenceID = (SELECT MAX(b.APInvoiceInItemReferenceID) 
												FROM #rpts b
												WHERE up.APInvoiceInReferenceNo = b.APInvoiceInReferenceNo 
														AND up.APInvoiceInReferenceID = b.APInvoiceInReferenceID
														AND up.APInvoiceInModuleName = b.APInvoiceInModuleName
														AND up.FK_ACObjectID = b.FK_ACObjectID
														AND up.ObjectType = b.ObjectType)
	------ Return ------
	SELECT 0 as bold
		, (ROW_NUMBER() OVER (PARTITION BY isnull(tax.ADConfigText,'') ORDER BY ADConfigText, vat.APInvoiceInSupplierDate2)) as loadOrder
		, 0 as VatDocumentType
		, vat.APInvoiceInReferenceNo AS APInvoiceInNo
		, vat.APInvoiceInVATFormNo AS APInvoiceInVATFormNo
		, vat.APInvoiceInVATSymbol AS APInvoiceInVATSymbol
		, vat.APInvoiceInSupplierNo as APInvoiceInSupplierNo
		, vat.APInvoiceInSupplierDate2 AS APInvoiceInVATDate
		, CASE when vat.APInvoiceInContactVatName = '' 
			then obj.ACObjectName
			else vat.APInvoiceInContactVatName 
			end as APInvoiceInContactVatName
		, ISNULL(vat.APInvoiceInTaxNumber,'') as APInvoiceInTaxNumber
		, CAST(vat.APInvoiceInItemProductDesc AS NVARCHAR(100)) AS APInvoiceInItemProductDesc
		, ISNULL(ivi.ICMeasureUnitName,'') as ICMeasureUnitName
		, ivi.APInvoiceInItemProductQty
		, ivi.APInvoiceInItemProductUnitCost
		--, CAST(vat.APInvoiceInItemProductDesc AS NVARCHAR(100)) AS APInvoiceInItemProductDesc
		, SUM(vat.APInvoiceInNetAmount) + ISNULL(iv.APInvoiceInShippingFees, 0.000) + ISNULL(iv.APInvoiceInShippingExtraFees, 0.000)  as APInvoiceInNetAmount
		, vat.APInvoiceInTaxPercent
		, SUM(vat.APInvoiceInTaxAmount) as APInvoiceInTaxAmount
		, isnull(tax.ADConfigText,'') as ADConfigText
		, iv.APBillOfLadingNo
	into #Result
	FROM #rpts vat
		left join (
					select  ADConfigKeyValue,ADConfigText 
					From ADConfigValues 
					where ADConfigKeyGroup ='AccountingBillVATDocumentType' 
						and ADConfigKeyValue like N'InvoiceIn%'				
				) tax on vat.APInputVATDocumentType = tax.ADConfigKeyValue
		OUTER APPLY(SELECT * FROM dbo.V_ACObjects o
					WHERE o.ACObjectID = vat.FK_ACObjectID
					AND o.ACObjectType = vat.ObjectType) AS obj
		OUTER APPLY (SELECT i.APInvoiceInShippingFees, i.APInvoiceInShippingExtraFees, billoflanding.APBillOfLadingNo
						FROM dbo.APInvoiceIns i
						OUTER APPLY (SELECT bol.APBillOfLadingNo
										FROM  dbo.APBillOfLadings bol 
										WHERE bol.FK_APInvoiceInID = i.APInvoiceInID) AS billoflanding
						WHERE i.AAStatus = 'Alive'
						AND vat.APInvoiceInModuleName = 'InvoiceIn'
						AND vat.APInvoiceInReferenceNo = i.APInvoiceInNo
						AND vat.APInvoiceInReferenceID = i.APInvoiceInID) AS iv
		Outer Apply ( Select mu.ICMeasureUnitName,
							ii.APInvoiceInItemProductQty,
							ii.APInvoiceInItemProductUnitCost
						From APInvoiceInItems ii
						left join ICMeasureUnits mu on mu.AAStatus = 'Alive' and mu.ICMeasureUnitID = ii.FK_ICMeasureUnitID
						Where ii.AAStatus = 'Alive'
						and vat.APInvoiceInReferenceID = ii.FK_APInvoiceInID
						and vat.APInvoiceInItemReferenceID = ii.APInvoiceInItemID
						) as ivi

	group by vat.APInvoiceInSupplierNo,
			 vat.APInvoiceInSupplierDate2,
			 vat.APInvoiceInTaxNumber,
			 vat.APInvoiceInReferenceNo,
			 CAST(vat.APInvoiceInItemProductDesc AS NVARCHAR(100)),
			 ivi.ICMeasureUnitName,
			 ivi.APInvoiceInItemProductQty,
			 ivi.APInvoiceInItemProductUnitCost,
			 tax.ADConfigText,
			 vat.APInvoiceInVATFormNo, 
			 vat.APInvoiceInTaxPercent,
			 vat.APInvoiceInVATSymbol,
			 iv.APInvoiceInShippingFees, 
			 iv.APInvoiceInShippingExtraFees,
			 iv.APBillOfLadingNo,
			case when vat.APInvoiceInContactVatName = '' 
			then obj.ACObjectName 
			else vat.APInvoiceInContactVatName 
			END           
	ORDER BY ADConfigText, APInvoiceInVATDate

	Insert into #Result
	Select	
		1,
		0,
		(ROW_NUMBER() OVER (ORDER BY ADConfigText)),
		'',
		'',
		'',
		'',
		null,
		ADConfigText,
		'',
		'',
		'',
		0,
		0,
		Sum(APInvoiceInNetAmount),
		0,
		Sum(APInvoiceInTaxAmount),
		'',
		''
	from #Result
	group by ADConfigText

	Update #Result
	Set VatDocumentType = (Select top 1 VatDocumentType from #Result r Where r.APInvoiceInContactVatName = rs.ADConfigText and VatDocumentType > 0)
	from #Result rs
	Where bold = 0

	Insert into #Result
	Select	
		1,
		0,
		0,
		'',
		'',
		'',
		'',
		null,
		N'Tổng cộng',
		'',
		'',
		'',
		0,
		0,
		Sum(APInvoiceInNetAmount),
		0,
		Sum(APInvoiceInTaxAmount),
		'',
		''
	from #Result


	Select 
		CASE WHEN laplai.value = 0
				THEN rs.loadOrder
				ELSE (Select Top 1 loadOrder from #Result Where APInvoiceInNo = rs.APInvoiceInNo) 
			END AS loadOrder,
		rs.APInvoiceInNo,
		CASE WHEN laplai.value = 0
				THEN rs.APInvoiceInVATFormNo
				ELSE '' 
			END AS APInvoiceInVATFormNo,
		CASE WHEN laplai.value = 0
				THEN rs.APInvoiceInVATSymbol
				ELSE '' 
			END AS APInvoiceInVATSymbol,
		CASE WHEN laplai.value = 0
				THEN rs.APInvoiceInSupplierNo
				ELSE '' 
			END AS APInvoiceInSupplierNo,
		CASE WHEN laplai.value = 0
				THEN rs.APInvoiceInVATDate
				ELSE '' 
			END AS APInvoiceInVATDate,
		CASE WHEN laplai.value = 0
				THEN rs.APInvoiceInContactVatName
				ELSE '' 
			END AS APInvoiceInContactVatName,
		CASE WHEN laplai.value = 0
				THEN rs.APInvoiceInTaxNumber
				ELSE '' 
			END AS APInvoiceInTaxNumber,
		rs.APInvoiceInItemProductDesc,
		rs.ICMeasureUnitName,
		rs.APInvoiceInItemProductQty,
		rs.APInvoiceInItemProductUnitCost,
		rs.APInvoiceInNetAmount,
		rs.APInvoiceInTaxPercent,
		rs.APInvoiceInTaxAmount,
		rs.APBillOfLadingNo
	from #Result rs
	OUTER APPLY
		(
			SELECT ISNULL(COUNT(*),0) AS value
			FROM #Result refRS
			WHERE refRS.APInvoiceInNo = rs.APInvoiceInNo
			AND refRS.loadOrder < rs.loadOrder
			and refRS.bold = 0
		) laplai
	Order by VatDocumentType, bold desc, loadOrder
	 

	select @Fromdate as Fromdate  ,@ToDate as ToDate, * from ThongTinCty (1)
	 DROP TABLE #rpts
	  DROP TABLE #ChenhLech
	  DROP TABLE #Result

end

