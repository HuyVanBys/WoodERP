using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.AssetShipment
{
    public class AssetShipmentEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the list of asset shipment items
        /// </summary>
        public BOSList<ACAssetShipmentItemsInfo> AssetShipmentItemList { get; set; }
        public BOSList<ACFileAttachmentsInfo> AssetShipmentTemplateList { get; set; }
        public Dictionary<int, string> AssetShipmentTemplateURLDic { get; set; }
        #endregion

        #region Constructor
        public AssetShipmentEntities()
            : base()
        {
            AssetShipmentItemList = new BOSList<ACAssetShipmentItemsInfo>();
            AssetShipmentTemplateList = new BOSList<ACFileAttachmentsInfo>();
            AssetShipmentTemplateURLDic = new Dictionary<int, string>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACDocumentsInfo();
            SearchObject = new ACDocumentsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ACAssetShipmentItemsTableName, new ACAssetShipmentItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            AssetShipmentItemList.InitBOSList(this,
                                            TableName.ACDocumentsTableName,
                                            TableName.ACAssetShipmentItemsTableName,
                                            BOSList<ACAssetShipmentItemsInfo>.cstRelationForeign);
            AssetShipmentItemList.ItemTableForeignKey = "FK_ACDocumentID";

            AssetShipmentTemplateList.InitBOSList(this,
                                                 TableName.ACDocumentsTableName,
                                                 TableName.ACFileAttachmentsTableName,
                                                 BOSList<APFileAttachmentsInfo>.cstRelationForeign);
            AssetShipmentTemplateList.ItemTableForeignKey = "ACFileAttachmentObjectID";
        }

        public override void InitGridControlInBOSList()
        {
            AssetShipmentItemList.InitBOSListGridControl(AssetShipmentModule.AssetShipmentItemGridControlName);
            DocumentEntryList.InitBOSListGridControl(AssetShipmentModule.DocumentEntryGridControlName);
            AssetShipmentTemplateList.InitBOSListGridControl(AssetShipmentModule.AssetShipmentTemplatesGridControlName);
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)MainObject;
            objDocumentsInfo.FK_ACDocumentTypeID = DefaultDocumentTypeID;
            objDocumentsInfo.ACDocumentDate = DateTime.Now;
            objDocumentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objDocumentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objDocumentsInfo.ACDocumentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                AssetShipmentItemList.SetDefaultListAndRefreshGridControl();
                AssetShipmentTemplateList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ACAssetShipmentItemsController objAssetShipmentItemsController = new ACAssetShipmentItemsController();
            List<ACAssetShipmentItemsInfo> items = objAssetShipmentItemsController.GetItemsByDocumentID(iObjectID);
            AssetShipmentItemList.Invalidate(items);

            ACDocumentsInfo mainObject = (ACDocumentsInfo)MainObject;
            ACFileAttachmentsController objFileAttachmentsController = new ACFileAttachmentsController();
            List<ACFileAttachmentsInfo> fileAttachmentList = objFileAttachmentsController.GetFileAttachmentByModuleAndObjectRef(this.Module.Name, BOSUtil.GetTableNameFromBusinessObject(mainObject), mainObject.ACDocumentID, 0);
            AssetShipmentTemplateList.Invalidate(fileAttachmentList);
        }

        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)MainObject;
            objDocumentsInfo.ACDocumentTotalAmount = DocumentEntryList.Sum(e => e.ACDocumentEntryAmount);
            objDocumentsInfo.ACDocumentExchangeAmount = DocumentEntryList.Sum(e => e.ACDocumentEntryExchangeAmount);
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            AssetShipmentItemList.SaveItemObjects();

            ACAssetsController objAssetsController = new ACAssetsController();
            //foreach (ACAssetShipmentItemsInfo item in AssetShipmentItemList)
            //{
            //    ACAssetsInfo objAssetsInfo = objAssetsController.GetAssetByID(item.FK_ACAssetID);
            //    if (objAssetsInfo != null)
            //    {
            //        objAssetsInfo.ACAssetStatus = AssetStatus.Shipped.ToString();
            //        objAssetsInfo.FK_MMWorkShopID = item.FK_MMWorkShopID;
            //        objAssetsInfo.FK_MMLineID = item.FK_MMLineID;
            //        objAssetsInfo.FK_HRDepartmentRoomGroupItemID = item.FK_HRDepartmentRoomGroupItemID;
            //        objAssetsInfo.FK_ACCostCenterID = item.FK_ACCostCenterID;
            //        objAssetsInfo.FK_ACSegmentID = item.FK_ACSegmentID;
            //        objAssetsController.UpdateObject(objAssetsInfo);
            //    }
            //}
            List<ACDocumentEntrysInfo> removedItems = DocumentEntryList.Where(documentEntry => (documentEntry.ACEntryTypeName == AccEntryType.GiamTSCDHaoMon.ToString()
                                                                                            || documentEntry.ACEntryTypeName == AccEntryType.GiamTSCDGiaTriConLai.ToString()) &&
                                                        !AssetShipmentItemList.Any(item => item.FK_ACAccountID == documentEntry.FK_ACCreditAccountID
                                                                                    || item.FK_ACAccountID == documentEntry.FK_ACDebitAccountID)).ToList();
            if (removedItems != null && removedItems.Any())
            {
                foreach (ACDocumentEntrysInfo item in removedItems)
                    DocumentEntryList.Remove(item);
            }
            SaveDocumentEntrys((ACDocumentsInfo)MainObject);

            AssetShipmentTemplateList.SaveItemObjects();
            AssetShipmentTemplateURLDic = AssetShipmentTemplateList.ToDictionary(o => o.ACFileAttachmentID, o => o.FullPathFile);
        }
        #endregion

        public override void SetValuesAfterValidatingAsset(BusinessObject item)
        {
            ACAssetShipmentItemsInfo assetShipmentItem = (ACAssetShipmentItemsInfo)item;
            base.SetDefaultValuesFromAsset(assetShipmentItem.FK_ACAssetID, assetShipmentItem);
            ACAssetsController objAssetsController = new ACAssetsController();
            ACAssetsInfo objAssetsInfo = objAssetsController.GetAssetByAssetIDAndRoomID(assetShipmentItem.FK_ACAssetID, assetShipmentItem.FK_HRDepartmentRoomID);
            if (objAssetsInfo != null)
            {
                //if ((objAssetsInfo.AssetReceiptedQty - objAssetsInfo.AssetShippedQty) > 0)
                //{
                assetShipmentItem.ACAssetShipmentItemQty = 1;
                //}
                //else
                //{
                //    assetShipmentItem.ACAssetShipmentItemQty = 0;
                //}
                assetShipmentItem.AssetReceiptedQty = objAssetsInfo.AssetReceiptedQty;
                assetShipmentItem.AssetShippedQty = objAssetsInfo.AssetShippedQty;
                assetShipmentItem.ACAssetOriginalAmount = objAssetsInfo.ACAssetOriginalAmount;
                assetShipmentItem.ACAssetShipmentItemDepreciatedAmount = objAssetsInfo.ACAssetDepreciatedAmount;
                assetShipmentItem.ACAssetRemainedAmount = objAssetsInfo.ACAssetRemainedAmount;
                assetShipmentItem.FK_HREmployeeUserID = objAssetsInfo.FK_HREmployeeUserID;
                assetShipmentItem.FK_MMWorkShopID = objAssetsInfo.FK_MMWorkShopID;
                assetShipmentItem.FK_MMLineID = objAssetsInfo.FK_MMLineID;
                assetShipmentItem.FK_HRDepartmentRoomGroupItemID = objAssetsInfo.FK_HRDepartmentRoomGroupItemID;
                assetShipmentItem.FK_HRDepartmentID = objAssetsInfo.FK_HRDepartmentID;
                assetShipmentItem.FK_ACCostCenterID = objAssetsInfo.FK_ACCostCenterID;
                assetShipmentItem.FK_ACSegmentID = objAssetsInfo.FK_ACSegmentID;
            }
        }
        public void UpdateAssetStatus(string posted)
        {
            foreach (ACAssetShipmentItemsInfo item in AssetShipmentItemList)
            {
                ACAssetsController objAssetsController = new ACAssetsController();
                ACAssetsInfo objAssetsInfo = objAssetsController.GetAssetByID(item.FK_ACAssetID);
                if (objAssetsInfo != null)
                {
                    if (posted == PostedTransactionStatus.Posted.ToString())
                    {
                        objAssetsInfo.ACAssetStatus = AssetStatus.Shipped.ToString();
                        objAssetsInfo.FK_MMWorkShopID = item.FK_MMWorkShopID;
                        objAssetsInfo.FK_MMLineID = item.FK_MMLineID;
                        objAssetsInfo.FK_HRDepartmentRoomGroupItemID = item.FK_HRDepartmentRoomGroupItemID;
                        objAssetsInfo.FK_ACCostCenterID = item.FK_ACCostCenterID;
                        objAssetsInfo.FK_ACSegmentID = item.FK_ACSegmentID;

                    }
                    else
                    {
                        objAssetsInfo.ACAssetStatus = objAssetsInfo.ACAssetRemainedAmount > 0 ?
                                                        AssetStatus.Using.ToString() :
                                                        AssetStatus.UsingWithoutDepreciation.ToString();
                    }
                }
                objAssetsController.UpdateObject(objAssetsInfo);
            }
        }
    }
}
