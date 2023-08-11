--SCM 
-- Delete
DELETE STToolbarFunctions WHERE STToolbarID in (select FK_STToolbarID From ADTemplates a Join ADTemplateToolbars b On a.ADTemplateID = b.FK_ADTemplateID Where ADTemplateNo = 'RP_PrintShipmentSO')
DELETE STToolbars WHERE STToolbarID in (select FK_STToolbarID From ADTemplateToolbars a Join ADTemplates b On a.FK_ADTemplateID = b.ADTemplateID Where ADTemplateNo = 'RP_PrintShipmentSO')
DELETE ADTemplateToolbars WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PrintShipmentSO')
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_PrintShipmentSO')
DELETE ADTemplates WHERE ADTemplateNo = 'RP_PrintShipmentSO'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_PrintShipmentSO',N'Phiếu xuất kho',N'Phiếu xuất kho',N'RP_PrintShipmentSO',N'Alive',N'',0
INSERT INTO STToolbars (AAStatus,STModuleID,STUserGroupID,STToolbarName,STToolbarDesc,STToolbarTag,STToolbarStyle,STToolbarCaption,STToolbarGroup,STToolbarOrder,STToolbarVisible,STToolbarPrivilege,STToolbarParentID,STToolbarImage) SELECT N'Alive',1266,1,N'fld_barbtnPrintShipmentSO',N'Phiếu xuất kho',N'PrintShipmentSO',N'Default',N'Phiếu xuất kho',N'Utility',3,1,N'',4867,N''
INSERT INTO ADTemplateToolbars (FK_ADTemplateID,FK_STToolbarID) SELECT (Select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PrintShipmentSO'),(select MAX(STToolbarID) From STToolbars)
INSERT INTO STToolbarFunctions (STToolbarFunctionIDString,STToolbarID,STToolbarFunctionName,STToolbarFunctionFullName,STToolbarFunctionClass,STToolbarFunctionSortOrder) SELECT N'',(select MAX(STToolbarID) From STToolbars),N'ActionPrintTemplate',N'Void ActionPrintTemplate()',N'BOSERP.Modules.ShipmentSaleOrder.ShipmentSaleOrderModule',1
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'RP_PrintShipmentSO') DROP PROCEDURE RP_PrintShipmentSO
GO
-- Stored Procedure

CREATE PROCEDURE [dbo].[RP_PrintShipmentSO]
	@STModulename Varchar(50),
	@ICShipmentID int
AS
BEGIN
SET NOCOUNT ON

	DECLARE @ObjectID INT, @ObjectType NVARCHAR(50), @CongNo DECIMAL(18,5), @CongNoStr varchar(50)
	SELECT @ObjectID = FK_ACObjectID, @ObjectType = s.ICObjectType
	FROM dbo.ICShipments s	
	WHERE s.ICShipmentID = @ICShipmentID
	AND	  s.AAStatus = 'Alive'

	Declare @temp_table table
	(
	  CongNo DECIMAL(18,5)
	)
	Insert into @temp_table
	EXEC dbo.ACObjects_GetTotalOwing @FK_ACObjectID = @ObjectID, -- int
									 @ACObjectType = @ObjectType

	SELECT @CongNo = CongNo From @temp_table
	
	SET @CongNoStr = left(CONVERT(varchar(50), CAST(@CongNo AS money), 1), len(CONVERT(varchar(50), CAST(@CongNo AS money), 1)) - 3) 

	SELECT	
			 ISNULL(vo.ACObjectName,'')		as ACObjectName
			, vo.ACObjectNo						as ACObjectNo
			, vo.ACObjectTaxNumber				as ACObjectTaxNumber
			, vo.ACObjectContactAddressLine3	as ACObjectContactAddressLine3
			, vo.ACObjectContactPhone			as ACObjectContactPhone
			, vo.ACObjectMail
			, cu.ARCustomerContactAddressLine1
			, cu.ARCustomerContactName
			, cu.ARCustomerTaxNumber  AS TelFaxNo
			, IIF(charindex(' - ', IIF(cu.ARCustomerDeliveryContactName = '', '', cu.ARCustomerDeliveryContactName) + IIF(cu.ARCustomerDeliveryAddressTel = '', '', ' - ' + cu.ARCustomerDeliveryAddressTel) + IIF(cu.ARCustomerDeliveryAddressLine1 = '', '', ' - ' + cu.ARCustomerDeliveryAddressLine1)) = 1
				, SUBSTRING(IIF(cu.ARCustomerDeliveryContactName = '', '', cu.ARCustomerDeliveryContactName) + IIF(cu.ARCustomerDeliveryAddressTel = '', '', ' - ' + cu.ARCustomerDeliveryAddressTel) + IIF(cu.ARCustomerDeliveryAddressLine1 = '', '', ' - ' + cu.ARCustomerDeliveryAddressLine1), 4, 100)
				, IIF(cu.ARCustomerDeliveryContactName = '', '', cu.ARCustomerDeliveryContactName) + IIF(cu.ARCustomerDeliveryAddressTel = '', '', ' - ' + cu.ARCustomerDeliveryAddressTel) + IIF(cu.ARCustomerDeliveryAddressLine1 = '', '', ' - ' + cu.ARCustomerDeliveryAddressLine1))  AS DiaChiGiaoHangHCM
			, IIF(cu.ARCustomerDeliveryContactName IS NULL, vo.ACObjectName, cu.ARCustomerDeliveryContactName) AS ARCustomerDeliveryContactName
			, IIF(cu.ARCustomerDeliveryAddressLine1 IS NULL, vo.ACObjectContactAddressLine3, cu.ARCustomerDeliveryAddressLine1) AS ARCustomerDeliveryAddressLine1
			, IIF(cu.ARCustomerDeliveryAddressTel IS NULL, vo.ACObjectContactPhone, cu.ARCustomerDeliveryAddressTel) AS ARCustomerDeliveryAddressTel
			, IIF(charindex(' - ', IIF(cu.ARCustomerDeliveryAddressTel = '', '', cu.ARCustomerDeliveryAddressTel) + IIF(cu.ARCustomerDeliveryAddressEmail = '', '', ' - ' + cu.ARCustomerDeliveryAddressEmail)) = 1
				, SUBSTRING(IIF(cu.ARCustomerDeliveryAddressTel = '', '', cu.ARCustomerDeliveryAddressTel) + IIF(cu.ARCustomerDeliveryAddressEmail = '', '', ' - ' + cu.ARCustomerDeliveryAddressEmail), 4, 100)
				, IIF(cu.ARCustomerDeliveryAddressTel = '', '', cu.ARCustomerDeliveryAddressTel) + IIF(cu.ARCustomerDeliveryAddressEmail = '', '', ' - ' + cu.ARCustomerDeliveryAddressEmail)) AS SDTEmail
			, IIF(cu.ARCustomerDeliveryAddressEmail IS NULL, vo.ACObjectMail, cu.ARCustomerDeliveryAddressEmail) AS ARCustomerDeliveryAddressEmail
			, IIF(cu.ARCustomerPaymentContactName IS NULL, vo.ACObjectName, cu.ARCustomerPaymentContactName) AS ARCustomerPaymentContactName
			, IIF(cu.ARCustomerPaymentAddressLine1 IS NULL, vo.ACObjectContactAddressLine3, cu.ARCustomerPaymentAddressLine1) AS ARCustomerPaymentAddressLine1
			, IIF(cu.ARCustomerPaymentAddressTel IS NULL, vo.ACObjectContactPhone, cu.ARCustomerPaymentAddressTel) AS ARCustomerPaymentAddressTel
			, IIF(cu.ARCustomerPaymentAddressEmail IS NULL, vo.ACObjectMail, cu.ARCustomerPaymentAddressEmail) AS ARCustomerPaymentAddressEmail
			, '' AS ARCustomerPaymentAddressEmail
			, s.ICShipmentNo
			, s.ICShipmentDate
			, s.ICShipmentDesc
			, s.ICShipmentSubTotalAmount
			, s.ICShipmentDiscountPerCent
			, (N'Chiết khấu ' + CAST(CAST(CAST(soinfo.ARSaleOrderDiscountPerCent AS VARBINARY(20)) AS DECIMAL(10,0)) as varchar(10))  + '%') PhanTramChietKhau
			, (N'Thuế VAT ' + CAST(CAST(CAST(soinfo.ARSaleOrderTaxPercent AS VARBINARY(20)) AS DECIMAL(10,0)) as varchar(10))  + '%') PhanTramThue
			, IIF(@CongNo <= 0, ''
				, N'Công nợ quá hạn đến ngày: ' + convert(varchar, getdate(), 3) + N' là: ' + @CongNoStr + N', vui lòng thanh toán để chúng tôi được giao hàng cho quý khách. Cảm ơn!'  
			  ) AS EndDetail 
			, tkNo.AccountNo as DebitAccountNo
			, tkCo.AccountNo as CreditAccountNo
			, (	select	stk.ICStockName
				from	[dbo].[ICStocks] stk
				where	stk.AAStatus = 'Alive'
				and		stk.ICStockID = si.FK_ICStockID
			)	as	Kho
			, soinfo.ARSaleOrderDiscountFix AS ICShipmentDiscountFix
			, soinfo.ThanhTienSauChietKhau AS ThanhTienSauChietKhau
			, soinfo.ARSaleOrderTaxPercent ICShipmentTaxPercent
			, soinfo.ARSaleOrderTaxAmount AS ICShipmentTaxAmount
			, soinfo.ARSaleOrderTotalAmount AS ICShipmentTotalAmount
			,(SELECT dbo.FConvertAmountToWord(round(soinfo.ARSaleOrderTotalAmount,2),'2',cr.GECurrencyDesc)) AS  BangChu
			, (SELECT TOP 1 so.ARSaleOrderPONo FROM dbo.ICShipmentItems si JOIN dbo.ARSaleOrders so ON so.ARSaleOrderID = si.FK_ARSaleOrderID WHERE si.FK_ICShipmentID = @ICShipmentID AND si.AAStatus = 'Alive' AND si.FK_ARSaleOrderID > 0) AS ICShipmentPONo
			, pd.ICProductNo
			, pd.ICProductNoOfOldSys
			, pd.ICProductName
			, pd.ICProductBarCode
			, pd.ICProductCustomerNumber
			, delivery.ARDeliveryPlanItemProductQty 
			, si.ICShipmentItemProductQty
			, si.ICShipmentItemProductUnitPrice
			, si.ICShipmentItemTotalAmount
			--, s.ARSaleOrderPriceCostTotalAmount
			--, si.ARSaleOrderItemRemark
			--, s.ARSaleOrderDesc
			--, si.ARSaleOrderItemComment
			, REPLACE(REPLACE(pd.ICProductImageFile, '/view?usp=sharing', ''), 'https://drive.google.com/file/d/', 'https://drive.google.com/uc?id=') AS ICProductImageFile
			, cr.GECurrencyName
			--, si.ARSaleOrderItemProductNoOfOldSys
			--, si.ARSaleOrderItemProductCustomerNumber
			, (SELECT mu.ICMeasureUnitName FROM dbo.ICMeasureUnits mu	WHERE mu.ICMeasureUnitID = si.FK_ICMeasureUnitID) AS ICMeasureUnitName
			, (SELECT e.HREmployeeName FROM dbo.HREmployees e WHERE e.HREmployeeID = s.FK_HREmployeeID AND e.AAStatus = 'Alive') HREmployeeName
			, (SELECT e.HREmployeeName FROM dbo.HREmployees e WHERE e.HREmployeeID = soinfo.FK_HREmployeeID AND e.AAStatus = 'Alive') HREmployeeNameSO
			, GETDATE() AS Today
	FROM dbo.ICShipmentItems si
	INNER JOIN dbo.ICProducts pd				ON pd.ICProductID = si.FK_ICProductID
	INNER JOIN dbo.ICShipments s				ON s.ICShipmentID = si.FK_ICShipmentID
	LEFT JOIN dbo.V_ACObjects vo				ON vo.ACObjectType = s.ICObjectType AND s.FK_ACObjectID = vo.ACObjectID
	LEFT JOIN dbo.GECurrencies cr ON cr.GECurrencyID = s.FK_GECurrencyID
	OUTER APPLY 
	(
		SELECT ARCustomerDeliveryContactName
				, ARCustomerContactAddressLine1
				, ARCustomerContactPhone
				, ARCustomerContactFax
				, ARCustomerDeliveryAddressLine1
				, ARCustomerDeliveryAddressTel
				, ARCustomerDeliveryAddressEmail
				, ARCustomerPaymentContactName
				, ARCustomerPaymentAddressLine1
				, ARCustomerPaymentAddressTel
				, ARCustomerPaymentAddressEmail
				, ARCustomerID
				, ARCustomerTaxNumber
				, ARCustomerContactName
		FROM dbo.ARCustomers 
		WHERE vo.ACObjectType = 'Customer' 
		AND ARCustomerID = vo.ACObjectID
		AND AAStatus = 'Alive'
	) cu
	OUTER APPLY
	(
		SELECT TOP 1   so.ARSaleOrderDiscountPerCent
					 , so.ARSaleOrderTaxPercent
					 , so.ARSaleOrderTaxAmount
					 , so.ARSaleOrderDiscountFix
					 , (so.ARSaleOrderPriceCostTotalAmount - so.ARSaleOrderDiscountFix) AS ThanhTienSauChietKhau
					 , so.ARSaleOrderTotalAmount
					 , so.FK_HREmployeeID
		FROM dbo.ARSaleOrders so 
		WHERE so.ARSaleOrderID = si.FK_ARSaleOrderID 
			AND so.AAStatus = 'Alive'
	) soinfo
	outer apply
	(
		Select ARDeliveryPlanItemProductQty from ARDeliveryPlanItems
			Where AAStatus = 'Alive'
			and ARDeliveryPlanItemID = si.FK_ARDeliveryPlanItemID
			) as delivery
	OUTER APPLY
	(
		SELECT STUFF((SELECT DISTINCT ',' + db.ACAccountNo
				FROM [dbo].[ACTransactions] t	(NOLOCK)
				INNER JOIN dbo.ACAccounts db		(NOLOCK) ON db.AAStatus = 'Alive' AND db.ACAccountID = t.FK_ACAccountID
				WHERE t.AAStatus = 'Alive'
				AND t.ACTransactionNo = s.ICShipmentNo 
				AND t.ACTransactionReferenceID = s.ICShipmentID
				AND t.ACTransactionDebitExchangeAmount > 0
						FOR XML PATH('')), 1, 1, '') as AccountNo
	) AS tkNo
	OUTER APPLY
	(
		SELECT STUFF((SELECT DISTINCT ',' + db.ACAccountNo
				FROM [dbo].[ACTransactions] t	(NOLOCK)
				INNER JOIN dbo.ACAccounts db		(NOLOCK) ON db.AAStatus = 'Alive' AND db.ACAccountID = t.FK_ACOffsetAccountID
				WHERE t.AAStatus = 'Alive'
				AND t.ACTransactionNo = s.ICShipmentNo 
				AND t.ACTransactionReferenceID = s.ICShipmentID
				AND t.ACTransactionDebitExchangeAmount > 0
						FOR XML PATH('')), 1, 1, '') as AccountNo
	) AS tkCo
	WHERE si.AAStatus = 'Alive' 
			AND s.ICShipmentID = @ICShipmentID
			AND	s.AAStatus = 'Alive'
	ORDER BY si.ICShipmentItemID

	Select * from ThongTinCty(1)
END
