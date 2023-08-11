-- Delete
DELETE STToolbarFunctions WHERE STToolbarID in (select FK_STToolbarID From ADTemplates a Join ADTemplateToolbars b On a.ADTemplateID = b.FK_ADTemplateID Where ADTemplateNo = 'RP_PrintMaterialShipment')
DELETE STToolbars WHERE STToolbarID in (select FK_STToolbarID From ADTemplateToolbars a Join ADTemplates b On a.FK_ADTemplateID = b.ADTemplateID Where ADTemplateNo = 'RP_PrintMaterialShipment')
DELETE ADTemplateToolbars WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PrintMaterialShipment')
DELETE ADTemplateParams WHERE FK_ADTemplateID in (select ADTemplateID From ADTemplates where ADTemplateNo = 'RP_PrintMaterialShipment')
DELETE ADTemplates WHERE ADTemplateNo = 'RP_PrintMaterialShipment'
-- Insert
INSERT INTO ADTemplates (ADTemplateNo,ADTemplateName,ADTemplateDesc,ADTemplateStoreProc,AAStatus,ADTemplateDataSource,ADTemplateAutoLoad) SELECT N'RP_PrintMaterialShipment',N'Xuất kho vật tư',N'Xuất kho vật tư',N'RP_PrintMaterialShipment',N'Alive',N'',1
INSERT INTO STToolbars (AAStatus,STModuleID,STUserGroupID,STToolbarName,STToolbarDesc,STToolbarTag,STToolbarStyle,STToolbarCaption,STToolbarGroup,STToolbarOrder,STToolbarVisible,STToolbarPrivilege,STToolbarParentID,STToolbarImage) SELECT N'Alive',1203,1,N'fld_barbtnPrintMaterialShipment',N'Xuất kho vật tư',N'PrintMaterialShipment',N'Default',N'Xuất kho vật tư',N'Utility',6,1,N'',3946,N''
INSERT INTO ADTemplateToolbars (FK_ADTemplateID,FK_STToolbarID) SELECT (Select ADTemplateID From ADTemplates Where ADTemplateNo = 'RP_PrintMaterialShipment'),(select MAX(STToolbarID) From STToolbars)
INSERT INTO STToolbarFunctions (STToolbarFunctionIDString,STToolbarID,STToolbarFunctionName,STToolbarFunctionFullName,STToolbarFunctionClass,STToolbarFunctionSortOrder) SELECT N'',(select MAX(STToolbarID) From STToolbars),N'ActionPrintTemplate',N'Void ActionPrintTemplate()',N'BOSERP.Modules.MaterialShipment.MaterialShipmentModule',1
-- Store Procedure
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'RP_PrintMaterialShipment') DROP PROCEDURE RP_PrintMaterialShipment
GO
CREATE PROCEDURE [dbo].[RP_PrintMaterialShipment]
	-- Add the parameters for the stored procedure here
	@STModulename Varchar(50),
	@ICShipmentID int
	
AS
BEGIN
	SET NOCOUNT ON;
	Select 
		ICS.ICShipmentDate,
		ICS.ICShipmentNo,
		ICS.ICShipmentDesc,
		iaer.ICImportAndExportReasonName,
		ICI.ICShipmentItemProductSerialNo,
		(select MMBatchProductNo from MMBatchProducts bp where AAStatus='Alive' and ICS.FK_MMBatchProductID=bp.MMBatchProductID) as MMBatchProductNo,
		(Select ICMeasureUnitName from ICMeasureUnits ICU where AAStatus ='Alive' and ICU.ICMeasureUnitID = ICI.FK_ICMeasureUnitID)as ĐVT,
		(Select ICStockName from ICStocks ICS  where ICS.AAStatus ='Alive' and ICS.ICStockID = ICI.FK_ICStockID )AS Kho,
		(Select ACObjectName from V_ACObjects vo where ICS.FK_ACObjectID= vo.ACObjectID and ICS.ICObjectType = vo.ACObjectType) as ARCustomerName,
		(select ICProductAttributeValue from ICProductAttributes pa where AAStatus='Alive' and ICI.FK_ICProductAttributeQualityID=pa.ICProductAttributeID) as ICProductAttributeQuality,
		he.HREmployeeName as ICShipmentDeliveryContactName,
		he2.HREmployeeName,
		(select ICModelName from ICModels where AAStatus = 'Alive' and ICModelID = ICI.FK_ICModelID) as ICModelName,
		(select ICModelDetailsName from ICModelDetails where AAStatus = 'Alive' and ICModelDetailID = ICI.FK_ICModelDetailID) as ICModelDetailsName,
		cast(ICI.ICShipmentItemProductDesc as nvarchar(1000)) as ICShipmentItemProductDesc,
		ICI.ICShipmentItemProductSerialNo,
		ICI.ICShipmentItemLotNo,
		ICI.ICShipmentItemHeight,
		ICI.ICShipmentItemWidth,
		ICI.ICShipmentItemLength,
		ICI.ICShipmentItemComment,
		isnull(tkNo.AccountNo,'') as DebitAccountNo,
		isnull(tkCo.AccountNo,'') as CreditAccountNo,
		isnull(ws.MMWorkShopName,'') as MMWorkShopName,
		sum(ICI.ICShipmentItemWoodQty) as ICShipmentItemWoodQty,
		sum(ICI.ICShipmentItemProductQty) as ICShipmentItemProductQty,
		(select ICproductNo from ICProducts pd where pd.AAStatus='Alive' and pd.ICProductID=ICI.FK_ICProductID)as ICProductNo
	from ICShipments ICS 
		inner join ICShipmentItems ICI ON ICS.ICShipmentID = ICI.FK_ICShipmentID
		LEFT JOIN dbo.HREmployees he ON he.HREmployeeID = ICS.FK_HREmployeeReceverID
		LEFT JOIN dbo.HREmployees he2 ON he2.HREmployeeID = ICS.FK_HREmployeeID
		LEFT JOIN dbo.ICImportAndExportReasons iaer ON iaer.ICImportAndExportReasonID = ICS.FK_ICImportAndExportReasonID
		left join MMWorkShops ws on ws.MMWorkShopID = ICS.FK_MMWorkShopID
	OUTER APPLY
	(
		SELECT STUFF((SELECT DISTINCT ',' + db.ACAccountNo
				FROM [dbo].[ACTransactions] t	(NOLOCK)
				INNER JOIN dbo.ACAccounts db		(NOLOCK) ON db.AAStatus = 'Alive' AND db.ACAccountID = t.FK_ACAccountID
				WHERE t.AAStatus = 'Alive'
				AND t.ACTransactionNo = ICS.ICShipmentNo 
				AND t.ACTransactionReferenceID = ICS.ICShipmentID
				AND t.ACTransactionDebitExchangeAmount > 0
						FOR XML PATH('')), 1, 1, '') as AccountNo
	) AS tkNo
	OUTER APPLY
	(
		SELECT STUFF((SELECT DISTINCT ',' + db.ACAccountNo
				FROM [dbo].[ACTransactions] t	(NOLOCK)
				INNER JOIN dbo.ACAccounts db		(NOLOCK) ON db.AAStatus = 'Alive' AND db.ACAccountID = t.FK_ACOffsetAccountID
				WHERE t.AAStatus = 'Alive'
				AND t.ACTransactionNo = ICS.ICShipmentNo 
				AND t.ACTransactionReferenceID = ICS.ICShipmentID
				AND t.ACTransactionDebitExchangeAmount > 0
						FOR XML PATH('')), 1, 1, '') as AccountNo
	) AS tkCo
	where  ICS.AAStatus ='Alive'
		and ICI.AAStatus ='Alive'
		and ICS.ICShipmentID = @ICShipmentID 
	group by ICS.ICShipmentDate,
		ICS.ICShipmentNo,
		ICS.ICShipmentDesc,
		ICS.ICShipmentDeliveryContactName,
		iaer.ICImportAndExportReasonName,
		he.HREmployeeName,
		he2.HREmployeeName,
		cast(ICI.ICShipmentItemProductDesc as nvarchar(1000)),
		ICI.ICShipmentItemProductSerialNo,
		ICI.ICShipmentItemLotNo,
		ICI.ICShipmentItemHeight,
		ICI.ICShipmentItemWidth,
		ICI.ICShipmentItemLength,
		ICS.FK_MMBatchProductID,
		ICI.FK_ICMeasureUnitID,
		ICI.FK_ICStockID,
		ICS.FK_ACObjectID,
		ics.ICObjectType,
		ICI.FK_ICProductAttributeQualityID,
		ICI.FK_ICModelID,
		ICI.FK_ICModelDetailID,
		ICI.ICShipmentItemComment,
		ICI.FK_ICProductID,
		isnull(tkNo.AccountNo,''),
		isnull(tkCo.AccountNo,''),
		isnull(ws.MMWorkShopName,'')
	Select * from ThongTinCty(1)
END
--exec [RP_PrintMaterialShipment] 'MaterialShipment'