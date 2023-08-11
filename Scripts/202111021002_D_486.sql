-- Delete
DELETE STToolbarFunctions WHERE STToolbarID in (select FK_STToolbarID From ADTemplates a Join ADTemplateToolbars b On a.ADTemplateID = b.FK_ADTemplateID Where ADTemplateNo = 'RP_PrintShipment')
DELETE STToolbars WHERE STToolbarID in (select FK_STToolbarID From ADTemplateToolbars a Join ADTemplates b On a.FK_ADTemplateID = b.ADTemplateID Where ADTemplateNo = 'RP_PrintShipment')
DELETE ADTemplateToolbars WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PrintShipment')
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_PrintShipment')
DELETE ADTemplates WHERE ADTemplateNo = 'RP_PrintShipment'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_PrintShipment',N'Phiếu xuất',N'Phiếu xuất',N'RP_PrintShipment',N'Alive',N'',1
INSERT INTO STToolbars (AAStatus,STModuleID,STUserGroupID,STToolbarName,STToolbarDesc,STToolbarTag,STToolbarStyle,STToolbarCaption,STToolbarGroup,STToolbarOrder,STToolbarVisible,STToolbarPrivilege,STToolbarParentID,STToolbarImage) SELECT N'Alive',28,1,N'fld_barbtnPrintShipment',N'Phiếu xuất',N'PrintShipment',N'Default',N'Phiếu xuất',N'Utility',2,1,N'',3509,N''
INSERT INTO ADTemplateToolbars (FK_ADTemplateID,FK_STToolbarID) SELECT (Select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PrintShipment'),(select MAX(STToolbarID) From STToolbars)
INSERT INTO STToolbarFunctions (STToolbarFunctionIDString,STToolbarID,STToolbarFunctionName,STToolbarFunctionFullName,STToolbarFunctionClass,STToolbarFunctionSortOrder) SELECT N'',(select MAX(STToolbarID) From STToolbars),N'ActionPrintTemplate',N'Void ActionPrintTemplate()',N'BOSERP.Modules.Shipment.ShipmentModule',1
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'RP_PrintShipment') DROP PROCEDURE RP_PrintShipment
GO
CREATE PROCEDURE [dbo].[RP_PrintShipment]
	@STModuleName	VARCHAR(50), 
	@ShipmentID		INT
AS
BEGIN	
	SET NOCOUNT ON;

    select	cast(si.ICShipmentItemProductDesc as nvarchar(512)) + ' / ' + si.ICShipmentItemProductSerialNo as TenSP
		,	p.ICProductNo as MaSo		
		,	(	select	stk.ICStockName
				from	[dbo].[ICStocks] stk
				where	stk.AAStatus = 'Alive'
				and		stk.ICStockID = si.FK_ICStockID
			)	as	Kho
		,	(	select	m.ICMeasureUnitName
				from	[dbo].[ICMeasureUnits] m
				where	m.AAStatus = 'Alive'
				and		m.ICMeasureUnitID = p.FK_ICProductBasicUnitID
			)	as	DonViTinh
		,	si.ICShipmentItemProductUnitCost	AS DonGia
		,	si.ICShipmentItemProductQty			AS SoLuong
		,	si.ICShipmentItemTotalCost			AS ThanhTien
    from	[dbo].[ICShipmentItems] si																	
	INNER JOIN [dbo].[ICProducts] p		(NOLOCK)	ON	si.FK_ICProductID = p.ICProductID
    WHERE	si.AAStatus = 'Alive'
    AND		p.AAStatus = 'Alive'    
    AND		si.FK_ICShipmentID = @ShipmentID 
	
	select	ISNULL(tkNo.AccountNo, '')	AS DebitAccountNo
		,	ISNULL(tkCo.AccountNo, '')	AS CreditAccountNo		
		,	N'Số: ' + s.ICShipmentNo	AS ICShipmentNo
		,	N'Ngày: ' + FORMAT(s.ICShipmentDate, 'dd/MM/yyyy') AS ICShipmentDate
		,	s.ICShipmentDesc
		,	s.ICShipmentDeliveryContactName	AS NguoiNhan
		,	e.HREmployeeName				AS NguoiTao
		,	ld.ICImportAndExportReasonName AS LyDoXuat
		,	dbo.FConvertAmountToWord(item.ThanhTien,' 0 ',N' đồng chẵn') AS BangChu
    FROM [dbo].[ICShipments] s	(NOLOCK)
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
	OUTER APPLY
	(	
		SELECT	e.HREmployeeName
		FROM	[dbo].[HREmployees] e
		WHERE	e.AAStatus = 'Alive'
		AND		e.HREmployeeID = s.FK_HREmployeeID
	) AS e
	OUTER APPLY
	(	
		SELECT	i.ICImportAndExportReasonName
		FROM	[dbo].[ICImportAndExportReasons] i
		WHERE	i.AAStatus = 'Alive'
		AND		i.ICImportAndExportReasonID = s.FK_ICImportAndExportReasonID
	) AS ld
	OUTER APPLY
	(
		SELECT SUM(ISNULL(si.ICShipmentItemTotalCost, 0))			AS ThanhTien
		FROM	[dbo].[ICShipmentItems] si													
		WHERE	si.AAStatus = 'Alive'
		AND		si.FK_ICShipmentID = @ShipmentID 
	) AS item
    WHERE	s.AAStatus = 'Alive'   
    AND		s.ICShipmentID = @ShipmentID 

	SELECT *
	FROM ThongTinCty(1)   
END
