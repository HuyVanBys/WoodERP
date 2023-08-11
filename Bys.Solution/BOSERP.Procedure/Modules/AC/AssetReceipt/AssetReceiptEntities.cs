using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.AssetReceipt
{
    public class AssetReceiptEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the list of asset receipt items
        /// </summary>
        public BOSList<ACAssetReceiptItemsInfo> AssetReceiptItemList { get; set; }
        #endregion

        #region Constructor
        public AssetReceiptEntities()
            : base()
        {
            AssetReceiptItemList = new BOSList<ACAssetReceiptItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACAssetReceiptsInfo();
            SearchObject = new ACAssetReceiptsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ACAssetReceiptItemsTableName, new ACAssetReceiptItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            AssetReceiptItemList.InitBOSList(this,
                                            TableName.ACAssetReceiptsTableName,
                                            TableName.ACAssetReceiptItemsTableName,
                                            BOSList<ACAssetReceiptItemsInfo>.cstRelationForeign);
            AssetReceiptItemList.ItemTableForeignKey = "FK_ACAssetReceiptID";
        }

        public override void InitGridControlInBOSList()
        {
            AssetReceiptItemList.InitBOSListGridControl(AssetReceiptModule.AssetReceiptItemGridControlName);
            DocumentEntryList.InitBOSListGridControl(AssetReceiptModule.DocumentEntryGridControlName);
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ACAssetReceiptsInfo objAssetReceiptsInfo = (ACAssetReceiptsInfo)MainObject;
            objAssetReceiptsInfo.ACAssetReceiptDate = DateTime.Now;
            objAssetReceiptsInfo.ACAssetReceiptStatus = AssetReceiptStatus.New.ToString();
            objAssetReceiptsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objAssetReceiptsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objAssetReceiptsInfo.ACAssetReceiptExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            UpdateMainObjectBindingSource();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                AssetReceiptItemList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        public override void SetValuesAfterValidatingAsset(BusinessObject item)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            int assetID = dbUtil.GetPropertyIntValue(item, "FK_ACAssetID");
            CalculateItemCost(item);
        }
        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            SetValuesAfterValidateProduct(iICProductID, ModuleObjects[TableName.ACAssetReceiptItemsTableName]);
            UpdateModuleObjectBindingSource(TableName.ACAssetReceiptItemsTableName);
        }

        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ACAssetReceiptItemsController objAssetReceiptItemsController = new ACAssetReceiptItemsController();
            List<ACAssetReceiptItemsInfo> items = objAssetReceiptItemsController.GetItemsByAssetReceiptID(iObjectID);
            AssetReceiptItemList.Invalidate(items);
        }
        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            AssetReceiptItemList.SaveItemObjects();
            SaveAccountingData();
        }
        #endregion

        #region Accounting
        #endregion

        public override bool CompleteTransaction()
        {
            ACAssetReceiptsInfo AssetReceipt = (ACAssetReceiptsInfo)MainObject;
            SetPropertyChangeEventLock(false);
            AssetReceipt.ACAssetReceiptStatus = ReceiptStatus.Complete.ToString();
            UpdateMainObject();
            SetPropertyChangeEventLock(true);
            if (AssetReceipt.ACAssetReceiptType == AssetReceiptType.Receipt.ToString())
            {
                //Tự động sinh tài sản
                GenerateAsset();
            }
            else
            {
                //Cập nhật thông tin tài sản
                UpdateAssetByAssetReceipt(false);
            }
            return base.CompleteTransaction();
        }

        public void GenerateAsset()
        {
            ACAssetReceiptsInfo AssetReceipt = (ACAssetReceiptsInfo)MainObject;
            if (AssetReceiptItemList != null && AssetReceiptItemList.Count() > 0)
            {
                ACAssetsController objAssetsController = new ACAssetsController();
                ACAssetReceiptItemsController objAssetReceiptItemsController = new ACAssetReceiptItemsController();
                ICProductsController objProductsController = new ICProductsController();
                AssetReceiptItemList.ForEach(o =>
                {
                    int id = 0;
                    ACAssetsInfo objAssetsInfo = new ACAssetsInfo();
                    objAssetsInfo.ACAssetNo = BOSApp.GetMainObjectNo(ModuleName.Asset, objAssetsInfo);
                    objAssetsInfo.ACAssetStatus = AssetStatus.Purchased.ToString();
                    objAssetsInfo.ACAssetDepreciationMethod = AssetDepreciationMethod.StraightLine.ToString();
                    objAssetsInfo.ACAssetPurchasedDate = BOSApp.GetCurrentServerDate();
                    objAssetsInfo.ACAssetUsedDate = BOSApp.GetCurrentServerDate();
                    objAssetsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                    objAssetsInfo.ACAssetDepreciationDate = BOSApp.GetCurrentServerDate();
                    ACAccountsController objAccountsController = new ACAccountsController();
                    int accountID = objAccountsController.GetObjectIDByNo(AccAccount.Acc6424);
                    objAssetsInfo.FK_ACDepreciationCostAccountID = accountID;
                    objAssetsInfo.FK_ICProductID = o.FK_ICProductID;
                    objAssetsInfo.ACAssetName = o.ACAssetReceiptItemProductName;
                    objAssetsInfo.FK_HREmployeeUserID = o.FK_HREmployeeUserID;
                    objAssetsInfo.FK_HRDepartmentID = o.FK_HRDepartmentID;
                    objAssetsInfo.FK_HRDepartmentRoomID = o.FK_HRDepartmentRoomID;
                    objAssetsInfo.FK_HRDepartmentRoomGroupItemID = o.FK_HRDepartmentRoomGroupItemID;
                    objAssetsInfo.FK_MMLineID = o.FK_MMLineID;
                    objAssetsInfo.FK_MMWorkShopID = o.FK_MMWorkShopID;
                    objAssetsInfo.FK_APSupplierID = AssetReceipt.FK_APSupplierID;
                    objAssetsInfo.FK_ACUnfinishedConstructionCostID = o.FK_ACUnfinishedConstructionCostID;
                    objAssetsInfo.ACAssetCost += o.ACAssetReceiptItemUnitCost * AssetReceipt.ACAssetReceiptExchangeRate;
                    objAssetsInfo.ACAssetOriginalAmount += o.ACAssetReceiptItemOriginalAmount * AssetReceipt.ACAssetReceiptExchangeRate;
                    objAssetsInfo.ACAssetRemainedAmount = objAssetsInfo.ACAssetOriginalAmount - objAssetsInfo.ACAssetDepreciatedAmount;
                    if (objAssetsInfo.ACAssetExpiryMonths > 0)
                    {
                        objAssetsInfo.ACAssetDepreciationAmount = objAssetsInfo.ACAssetOriginalAmount / objAssetsInfo.ACAssetExpiryMonths;
                        if (objAssetsInfo.ACAssetOriginalAmount > 0)
                        {
                            objAssetsInfo.ACAssetDepreciationPercent = objAssetsInfo.ACAssetDepreciationAmount / objAssetsInfo.ACAssetOriginalAmount * 100;
                        }
                    }
                    ICProductsInfo objProductsInfo = objProductsController.GetObjectByID(o.FK_ICProductID) as ICProductsInfo;
                    if (objProductsInfo != null)
                    {
                        objAssetsInfo.ACAssetType = objProductsInfo.ICProductType == ProductType.MMTB.ToString() ? AssetType.Machine.ToString() : AssetType.Other.ToString();
                        //objAssetsInfo.FK_ACAssetTypeAccountConfigID = objProductsInfo.FK_ICProductTypeAccountConfigID;
                        objAssetsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                    }    
                    id = objAssetsController.CreateObject(objAssetsInfo);
                    BOSApp.UpdateObjectNumbering(ModuleName.Asset);
                    o.FK_ACAssetID = id;
                    objAssetReceiptItemsController.UpdateObject(o);
                });
            }
        }

        private void UpdateAssetByAssetReceipt(bool isRollBack)
        {
            ACAssetReceiptsInfo mainObject = (ACAssetReceiptsInfo)MainObject;
            ACAssetReceiptsController objAssetReceiptsController = new ACAssetReceiptsController();
            objAssetReceiptsController.UpdateAssetDataByAssetReceipt(mainObject.ACAssetReceiptID, isRollBack);
        }

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            ACAssetReceiptsInfo mainObject = (ACAssetReceiptsInfo)MainObject;
            if (mainObject.ACAssetReceiptType == AssetReceiptType.Receipt.ToString())
            {
                //Xóa tài sản
                ACAssetReceiptsController objAssetReceiptsController = new ACAssetReceiptsController();
                objAssetReceiptsController.DeleteAssetByPurchaseAssetReceipt(mainObject.ACAssetReceiptID);
            }
            else
            {
                //Cập nhật thông tin tài sản
                UpdateAssetByAssetReceipt(true);
            }

            base.DeleteObjectRelations(strTableName, iObjectID);
            string strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            if (MainObject != null && strTableName == strMainObjectTableName)
            {
                AssetReceiptItemList.DeleteItemObjects();
            }
        }

        public override bool CancelCompleteTransaction()
        {
            ACAssetReceiptsInfo mainObject = (ACAssetReceiptsInfo)MainObject;
            if (mainObject.ACAssetReceiptType == AssetReceiptType.Receipt.ToString())
            {
                //Xóa tài sản
                ACAssetReceiptsController objAssetReceiptsController = new ACAssetReceiptsController();
                objAssetReceiptsController.DeleteAssetByPurchaseAssetReceipt(mainObject.ACAssetReceiptID);
            }
            else
            {
                //Cập nhật thông tin tài sản
                UpdateAssetByAssetReceipt(true);
            }
            return base.CancelCompleteTransaction();
        }
    }
}
