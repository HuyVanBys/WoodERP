SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
-- ======================================================================
-- Author:		NHI DANG
-- Create date: 07/04/2020
-- Procedure Name:RP_PrintSaleOrder
-- ======================================================================

ALTER PROCEDURE [dbo].[RP_PrintSaleOrder]
	@STModulename Varchar(50),
	@ARSaleOrderID int
AS
BEGIN
SET NOCOUNT ON
	SELECT	
			 ISNULL(vo.ACObjectName,'')		as ACObjectName
			, vo.ACObjectNo						as ACObjectNo
			, vo.ACObjectTaxNumber				as ACObjectTaxNumber
			, vo.ACObjectContactAddressLine3	as ACObjectContactAddressLine3
			, vo.ACObjectContactPhone			as ACObjectContactPhone
			, vo.ACObjectMail
			, IIF(cu.ARCustomerInvoiceContactName IS NULL, vo.ACObjectName, cu.ARCustomerInvoiceContactName) AS ARCustomerInvoiceContactName
			, IIF(cu.ARCustomerInvoiceAddressLine1 IS NULL, vo.ACObjectContactAddressLine3, cu.ARCustomerInvoiceContactName) AS ARCustomerInvoiceAddressLine1
			, IIF(cu.ARCustomerInvoiceAddressTel IS NULL, vo.ACObjectContactPhone, cu.ARCustomerInvoiceAddressTel) AS ARCustomerInvoiceAddressTel
			, so.ARSaleOrderNo
			, so.ARSaleOrderDate
			, so.ARSaleOrderDeliveryDate
			, so.ARSaleOrderComment
			, so.ARSaleOrderInvoiceAddressLine3
			, so.ARSaleOrderDeliveryAddressLine3
			, so.ARSaleOrderDeliveryContactName
			, so.ARSaleOrderDeliveryAddressTel
			, so.ARSaleOrderSubTotalAmount
			, so.ARSaleOrderDiscountPerCent
			, so.ARSaleOrderDiscountFix
			, so.ARSaleOrderTaxPercent
			, so.ARSaleOrderTaxAmount
			, so.ARSaleOrderTotalAmount
			, so.ARSaleOrderPONo
			, pd.ICProductCustomerNumber
			, soi.ARSaleOrderItemProductNo
			, pd.ICProductDesc AS ARSaleOrderItemProductDesc
			, soi.ARSaleOrderItemProductName
			, soi.ARSaleOrderItemWidth
			, soi.ARSaleOrderItemHeight
			, soi.ARSaleOrderItemLength
			, (soi.ARSaleOrderItemWidth * soi.ARSaleOrderItemHeight * soi.ARSaleOrderItemLength) AS CBM
			, soi.ARSaleOrderItemProductQty
			, soi.ARSaleOrderItemProductUnitPrice
			, soi.ARSaleOrderItemProductDiscount
			, soi.ARSaleOrderItemProductTaxPercent
			, soi.ARSaleOrderItemTotalAmount
			, soi.ARSaleOrderItemRemark
			, so.ARSaleOrderBalanceDue
			, so.ARSaleOrderDepositBalance
			, (IIF(so.ARSaleOrderTotalAmount <> 0,(so.ARSaleOrderDepositBalance / so.ARSaleOrderTotalAmount * 100), 0.0))  AS DepositPercent
			, (IIF(so.ARSaleOrderTotalAmount <> 0,(so.ARSaleOrderBalanceDue / so.ARSaleOrderTotalAmount * 100), 0.0))  AS BalanceDuePercent
			, so.ARSaleOrderContQty
			, so.ARSaleOrderDesc
			, soi.ARSaleOrderItemComment
			, pd.ICProductQtyInBox*soi.ARSaleOrderItemProductQty AS TotalBoxes
			, REPLACE(REPLACE(pd.ICProductImageFile, '/view?usp=sharing', ''), 'https://drive.google.com/file/d/', 'https://drive.google.com/uc?id=') AS ICProductImageFile
			, pd.ICProductQtyInBox
			, cr.GECurrencyName
			, pmt.GEPaymentTermName
			, cs.CSCompanyBankCode
			, cs.CSCompanyBankName
			, cs.CSCompanyBankAccount
			, cs.CSCompanyBankAddress
			, cs.CSCompanyBankSwiftCode
			, (SELECT mu.ICMeasureUnitName FROM dbo.ICMeasureUnits mu	WHERE mu.ICMeasureUnitID = soi.FK_ICMeasureUnitID) AS ICMeasureUnitName
			, (SELECT pda.ICProductAttributeValue FROM dbo.ICProductAttributes pda WHERE pd.FK_ICProductAttributeWoodTypeID = pda.ICProductAttributeID)		as ARSaleOrderItemWoodTypeText
			, (select dbo.usp_fnNumToWords(so.ARSaleOrderBalanceDue ,'Y')) AS BalanceDueInWords
			, IIF(ARSaleOrderIsVehicleAllocation = 1, 'Allow', 'Not Allow') AS IsVehicleAllocation
			, IIF(ARSaleOrderIsContainerLoader = 1, 'Allow', 'Not Allow') AS IsContainerLoader
			, so.ARSaleOrderPortPartialShipmentText
			, so.ARSaleOrderPortTranShipmentText
			, cv.ADConfigText AS ShippingType
	FROM dbo.ARSaleOrderItems soi
	INNER JOIN dbo.ICProducts pd				ON pd.ICProductID = soi.FK_ICProductID
	INNER JOIN dbo.ARSaleOrders so				ON so.ARSaleOrderID = soi.FK_ARSaleOrderID
	LEFT JOIN dbo.V_ACObjects vo				ON vo.ACObjectType = so.ARObjectType AND so.FK_ACObjectID = vo.ACObjectID
	inner join CSCompanys cc on so.FK_BRBranchID = cc.FK_BRBranchID
	LEFT JOIN dbo.GECurrencies cr ON cr.GECurrencyID = so.FK_GECurrencyID
	LEFT JOIN dbo.GEPaymentTerms pmt ON pmt.GEPaymentTermID = so.FK_GEPaymentTermID
	LEFT JOIN CSCompanyBanks cs on so.FK_CSCompanyBankID = cs.CSCompanyBankID
	LEFT JOIN dbo.ADConfigValues cv ON cv.ADConfigKeyGroup = 'ShippingType' AND cv.AAStatus = 'Alive' AND cv.ADConfigKeyValue = so.ARShippingType
	OUTER APPLY 
	(
		SELECT ARCustomerInvoiceContactName
				, ARCustomerInvoiceAddressLine1
				, ARCustomerInvoiceAddressTel
		FROM dbo.ARCustomers 
		WHERE vo.ACObjectType = 'Customer' 
		AND ARCustomerID = vo.ACObjectID
		AND AAStatus = 'Alive'
	) cu
	WHERE soi.AAStatus = 'Alive' 
			AND so.ARSaleOrderID = @ARSaleOrderID
			AND	so.AAStatus = 'Alive'
			AND so.ARSaleOrderStatus != 'New'
SELECT * FROM dbo.ThongTinCty(1)
END


GO

