using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.AdjustIncreaseOrDecreaseAsset
{
    public class AdjustIncreaseOrDecreaseAssetEntities : BaseTransactionEntities
    {
        #region Public Properties
        public BOSList<ACAdjustIncreaseOrDecreaseAssetItemsInfo> AdjustIncreaseOrDecreaseAssetItemsList { get; set; }
        #endregion
        public AdjustIncreaseOrDecreaseAssetEntities()
            : base()
        {
            AdjustIncreaseOrDecreaseAssetItemsList = new BOSList<ACAdjustIncreaseOrDecreaseAssetItemsInfo>();
        }

        #region Init Main and Module Object
        public override void InitMainObject()
        {
            MainObject = new ACAdjustIncreaseOrDecreaseAssetsInfo();
            SearchObject = new ACAdjustIncreaseOrDecreaseAssetsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ACAdjustIncreaseOrDecreaseAssetItemsTableName, new ACAdjustIncreaseOrDecreaseAssetItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            AdjustIncreaseOrDecreaseAssetItemsList.InitBOSList(this,
                                             TableName.ACAdjustIncreaseOrDecreaseAssetsTableName,
                                             TableName.ACAdjustIncreaseOrDecreaseAssetItemsTableName,
                                             BOSList<ACAdjustIncreaseOrDecreaseAssetItemsInfo>.cstRelationForeign);
            AdjustIncreaseOrDecreaseAssetItemsList.ItemTableForeignKey = "FK_ACAdjustIncreaseOrDecreaseAssetID";
            DocumentEntryList.InitBOSList(this,
                                             TableName.ACDocumentsTableName,
                                             TableName.ACDocumentEntrysTableName,
                                             BOSList<ACDocumentEntrysInfo>.cstRelationForeign);
            DocumentEntryList.ItemTableForeignKey = "FK_ACDocumentID";
        }

        public override void InitGridControlInBOSList()
        {
            AdjustIncreaseOrDecreaseAssetItemsList.InitBOSListGridControl();
            DocumentEntryList.InitBOSListGridControl(AdjustIncreaseOrDecreaseAssetModule.DocumentEntryGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                AdjustIncreaseOrDecreaseAssetItemsList.SetDefaultListAndRefreshGridControl();
                DocumentEntryList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ACAdjustIncreaseOrDecreaseAssetsInfo objAdjustIncreaseOrDecreaseAssetsInfo = (ACAdjustIncreaseOrDecreaseAssetsInfo)MainObject;
            objAdjustIncreaseOrDecreaseAssetsInfo.ACAdjustIncreaseOrDecreaseAssetDate = DateTime.Now;
            objAdjustIncreaseOrDecreaseAssetsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GEPurchaseCurrencyID;
            objAdjustIncreaseOrDecreaseAssetsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objAdjustIncreaseOrDecreaseAssetsInfo.ACAdjustIncreaseOrDecreaseAssetExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanyPurchaseExchangeRate;
            objAdjustIncreaseOrDecreaseAssetsInfo.ACAdjustIncreaseOrDecreaseAssetType = AdjustIncreaseOrDecreaseAssetType.Increase.ToString();
            UpdateMainObjectBindingSource();
        }
        #endregion

        public void SetValuesAfterValidateAsset(int assetID, BusinessObject item)
        {
            ACAssetsController objAssetsController = new ACAssetsController();
            ACAssetsInfo objAssetsInfo = (ACAssetsInfo)objAssetsController.GetObjectByID(assetID);
            if (objAssetsInfo != null)
            {
                ACDepreciationAssetTransController objDepreciationAssetTransController = new ACDepreciationAssetTransController();
                int depreciatedMonths = objDepreciationAssetTransController.GetDepreciationAssetTransByAssetID(assetID).Count;
                ACAdjustIncreaseOrDecreaseAssetItemsInfo AdjustIncreaseOrDecreaseAssetItem = (ACAdjustIncreaseOrDecreaseAssetItemsInfo)item;
                AdjustIncreaseOrDecreaseAssetItem.FK_ACAssetID = objAssetsInfo.ACAssetID;
                AdjustIncreaseOrDecreaseAssetItem.ACAdjustIncreaseOrDecreaseAssetItemNo = objAssetsInfo.ACAssetNo;
                AdjustIncreaseOrDecreaseAssetItem.FK_ACAccountID = objAssetsInfo.FK_ACAccountID;
                AdjustIncreaseOrDecreaseAssetItem.ACAdjustIncreaseOrDecreaseAssetItemName = objAssetsInfo.ACAssetName;
                AdjustIncreaseOrDecreaseAssetItem.ACAdjustIncreaseOrDecreaseAssetItemRemainDepreciation = objAssetsInfo.ACAssetExpiryMonths - depreciatedMonths;
                AdjustIncreaseOrDecreaseAssetItem.ACAdjustIncreaseOrDecreaseAssetItemBeginDate = DateTime.Now;
            }
            UpdateModuleObjectBindingSource(TableName.ACAdjustIncreaseOrDecreaseAssetItemsTableName);
        }

        public override void SaveModuleObjects()
        {
            AdjustIncreaseOrDecreaseAssetItemsList.SaveItemObjects();
            //Save accounting data
            SaveAccountingData();
        }

        public override bool SaveAccountingData()
        {
            ACAdjustIncreaseOrDecreaseAssetsInfo objAdjustIncreaseOrDecreaseAssetsInfo = (ACAdjustIncreaseOrDecreaseAssetsInfo)MainObject;
            foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
            {
                BOSUtil.CopyObject(objAdjustIncreaseOrDecreaseAssetsInfo, objDocumentsInfo);
                objDocumentsInfo.FK_ACObjectID = objAdjustIncreaseOrDecreaseAssetsInfo.FK_ACObjectID;
                objDocumentsInfo.ACObjectType = objAdjustIncreaseOrDecreaseAssetsInfo.ACObjectType;
                objDocumentsInfo.ACDocumentObjectTaxNumber = objAdjustIncreaseOrDecreaseAssetsInfo.ACObjectTaxNumber;
            }
            return base.SaveAccountingData();
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ACAdjustIncreaseOrDecreaseAssetItemsController objAdjustIncreaseOrDecreaseAssetItemsController = new ACAdjustIncreaseOrDecreaseAssetItemsController();
            List<ACAdjustIncreaseOrDecreaseAssetItemsInfo> items = objAdjustIncreaseOrDecreaseAssetItemsController.GetItemsByAdjustIODAssetID(iObjectID);
            AdjustIncreaseOrDecreaseAssetItemsList.Invalidate(items);
        }
    }
}
