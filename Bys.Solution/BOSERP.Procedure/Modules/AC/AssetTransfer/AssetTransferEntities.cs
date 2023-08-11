using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.AssetTransfer
{
    public class AssetTransferEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the list of asset transfer items
        /// </summary>
        public BOSList<ACAssetTransferItemsInfo> AssetTransferItemList { get; set; }
        #endregion

        #region Constructor
        public AssetTransferEntities()
            : base()
        {
            AssetTransferItemList = new BOSList<ACAssetTransferItemsInfo>();
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
            ModuleObjects.Add(TableName.ACAssetTransferItemsTableName, new ACAssetTransferItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            AssetTransferItemList.InitBOSList(this,
                                            TableName.ACDocumentsTableName,
                                            TableName.ACAssetTransferItemsTableName,
                                            BOSList<ACAssetTransferItemsInfo>.cstRelationForeign);
            AssetTransferItemList.ItemTableForeignKey = "FK_ACDocumentID";
        }

        public override void InitGridControlInBOSList()
        {
            AssetTransferItemList.InitBOSListGridControl(AssetTransferModule.AssetTransferItemGridControlName);
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
                AssetTransferItemList.SetDefaultListAndRefreshGridControl();
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
            ACAssetTransferItemsController objAssetTransferItemsController = new ACAssetTransferItemsController();
            List<ACAssetTransferItemsInfo> items = objAssetTransferItemsController.GetItemsByDocumentID(iObjectID);
            AssetTransferItemList.Invalidate(items);
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
            AssetTransferItemList.SaveItemObjects();

            ACAssetsController objAssetsController = new ACAssetsController();
            foreach (ACAssetTransferItemsInfo item in AssetTransferItemList)
            {
                //Change the asset's room to the target room
                ACAssetsInfo objAssetsInfo = objAssetsController.GetAssetByAssetIDAndRoomID(item.FK_ACAssetID, item.FK_HRFromRoomID);
                if (objAssetsInfo != null)
                {
                    objAssetsInfo.FK_HRDepartmentRoomID = item.FK_HRToRoomID;
                    objAssetsInfo.FK_ACDepreciationCostAccountID = item.FK_ACDepreciationCostAccountID;
                    objAssetsInfo.FK_MMWorkShopID = item.FK_MMWorkShopID;
                    objAssetsInfo.FK_MMLineID = item.FK_MMLineID;
                    objAssetsInfo.FK_HRDepartmentRoomGroupItemID = item.FK_HRDepartmentRoomGroupItemID;
                    objAssetsInfo.FK_HREmployeeUserID = item.FK_HREmployeeUserID;
                    objAssetsInfo.FK_HRDepartmentID = item.FK_HRToDepartmentID;
                    objAssetsInfo.FK_ACCostCenterID = item.FK_ACCostCenterID;
                    objAssetsInfo.FK_ACSegmentID = item.FK_ACSegmentID;
                    objAssetsController.UpdateObject(objAssetsInfo);

                }
            }
        }
        #endregion        

        public override void SetValuesAfterValidatingAsset(BusinessObject item)
        {
            ACAssetTransferItemsInfo assetTransferItem = (ACAssetTransferItemsInfo)item;
            base.SetDefaultValuesFromAsset(assetTransferItem.FK_ACAssetID, assetTransferItem);
            assetTransferItem.FK_HRFromRoomID = assetTransferItem.FK_HRDepartmentRoomID;
            assetTransferItem.FK_HRToRoomID = 0;
            ACAssetsController objAssetsController = new ACAssetsController();
            ACAssetsInfo objAssetsInfo = objAssetsController.GetAssetByAssetIDAndRoomID(assetTransferItem.FK_ACAssetID, assetTransferItem.FK_HRFromRoomID);
            if (objAssetsInfo != null)
            {
                assetTransferItem.ACAssetTransferItemQty = 1;
                assetTransferItem.AssetReceiptedQty = objAssetsInfo.AssetReceiptedQty;
                assetTransferItem.AssetShippedQty = objAssetsInfo.AssetShippedQty;
                assetTransferItem.FK_ACDepreciationCostAccountID = objAssetsInfo.FK_ACDepreciationCostAccountID;
                assetTransferItem.ACAssetOriginalAmount = objAssetsInfo.ACAssetOriginalAmount;
                assetTransferItem.ACAssetTransferItemDepreciatedAmount = objAssetsInfo.ACAssetDepreciatedAmount;
                assetTransferItem.ACAssetRemainedAmount = objAssetsInfo.ACAssetRemainedAmount;
                assetTransferItem.FK_MMWorkShopID = objAssetsInfo.FK_MMWorkShopID;
                assetTransferItem.FK_MMLineID = objAssetsInfo.FK_MMLineID;
                assetTransferItem.FK_HRDepartmentRoomGroupItemID = objAssetsInfo.FK_HRDepartmentRoomGroupItemID;
                assetTransferItem.FK_HREmployeeUserID = objAssetsInfo.FK_HREmployeeUserID;
                assetTransferItem.FK_HRDepartmentID = objAssetsInfo.FK_HRDepartmentID;
                assetTransferItem.FK_ACCostCenterID = objAssetsInfo.FK_ACCostCenterID;
                assetTransferItem.FK_ACSegmentID = objAssetsInfo.FK_ACSegmentID;
            }
        }
    }
}
