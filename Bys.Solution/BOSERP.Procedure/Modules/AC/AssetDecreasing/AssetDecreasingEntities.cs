using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.AssetDecreasing
{
    public class AssetDecreasingEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the item list of the shipment
        /// </summary>
        public BOSItemsEntityList<ICShipmentItemsInfo> ShipmentItemList { get; set; }
        #endregion

        #region Constructor
        public AssetDecreasingEntities()
            : base()
        {
            ShipmentItemList = new BOSItemsEntityList<ICShipmentItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICShipmentsInfo();
            SearchObject = new ICShipmentsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICShipmentItemsTableName, new ICShipmentItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            ShipmentItemList.InitBOSList(
                                        this,
                                        TableName.ICShipmentsTableName,
                                        TableName.ICShipmentItemsTableName,
                                        BOSList<ICShipmentItemsInfo>.cstRelationForeign);
            ShipmentItemList.ItemTableForeignKey = "FK_ICShipmentID";
        }

        public override void InitGridControlInBOSList()
        {
            ShipmentItemList.InitBOSListGridControl(AssetDecreasingModule.ShipmentItemGridControlName);
            DocumentEntryList.InitBOSListGridControl(AssetDecreasingModule.DocumentEntryGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ShipmentItemList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentDate = DateTime.Now;
            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.New.ToString();
            objShipmentsInfo.ICShipmentTypeCombo = ShipmentType.AssetShipment.ToString();
            objShipmentsInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            objShipmentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objShipmentsInfo.ICShipmentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objShipmentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            //objShipmentsInfo.ICShipmentStatus = ShipmentStatus.Complete.ToString();

            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> items = objShipmentItemsController.GetItemsByShipmentID(iObjectID);
            ShipmentItemList.Invalidate(items);
        }
        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            ACAssetsController objAssetsController = new ACAssetsController();
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACAssetShipmentItemsController objAssetShipmentItemsController = new ACAssetShipmentItemsController();
            ICShipmentsInfo objshipmentsInfo = (ICShipmentsInfo)MainObject;
            ShipmentItemList.SaveItemObjects();
            SaveAccountingData();
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)objDocumentsController.GetObjectByNo(objshipmentsInfo.ICShipmentNo);
            if (objDocumentsInfo != null)
            {
                foreach (ICShipmentItemsInfo item in ShipmentItemList)
                {
                    ACAssetShipmentItemsInfo objAssetShipmentItemsInfo = new ACAssetShipmentItemsInfo();
                    objAssetShipmentItemsInfo = (ACAssetShipmentItemsInfo)objAssetShipmentItemsController.GetItemsByDocumentIDAndAssetID(objDocumentsInfo.ACDocumentID, item.FK_ACAssetID);
                    if (objAssetShipmentItemsInfo != null)
                    {
                        objAssetShipmentItemsInfo.FK_ACAssetID = item.FK_ACAssetID;
                        objAssetShipmentItemsInfo.FK_HRDepartmentID = item.FK_HRDepartmentID;
                        objAssetShipmentItemsInfo.ACAssetShipmentItemQty = item.ICShipmentItemProductQty;
                        objAssetShipmentItemsInfo.ACAssetShipmentItemDepreciatedAmount = item.ICShipmentItemProductUnitPrice;
                        objAssetShipmentItemsInfo.FK_ACDocumentID = objDocumentsInfo.ACDocumentID;
                        objAssetShipmentItemsInfo.FK_HRDepartmentRoomGroupID = item.FK_HRDepartmentRoomGroupID;
                        objAssetShipmentItemsInfo.FK_HRDepartmentRoomGroupItemID = item.FK_HRDepartmentRoomGroupItemID;
                        objAssetShipmentItemsInfo.FK_HRDepartmentRoomID = item.FK_HRDepartmentRoomID;
                        objAssetShipmentItemsInfo.FK_HREmployeeUserID = item.FK_HREmployeeUserID;
                        objAssetShipmentItemsInfo.FK_MMLineID = item.FK_MMLineID;
                        objAssetShipmentItemsInfo.FK_MMWorkShopID = item.FK_MMWorkShopID;

                        objAssetShipmentItemsController.UpdateObject(objAssetShipmentItemsInfo);
                    }
                    else
                    {
                        ACAssetShipmentItemsInfo assetShipmentItemsInfo = new ACAssetShipmentItemsInfo();
                        assetShipmentItemsInfo.FK_ACAssetID = item.FK_ACAssetID;
                        assetShipmentItemsInfo.FK_HRDepartmentID = item.FK_HRDepartmentID;
                        assetShipmentItemsInfo.ACAssetShipmentItemQty = item.ICShipmentItemProductQty;
                        assetShipmentItemsInfo.ACAssetShipmentItemDepreciatedAmount = item.ICShipmentItemProductUnitPrice;
                        assetShipmentItemsInfo.FK_ACDocumentID = objDocumentsInfo.ACDocumentID;
                        assetShipmentItemsInfo.FK_HRDepartmentRoomGroupID = item.FK_HRDepartmentRoomGroupID;
                        assetShipmentItemsInfo.FK_HRDepartmentRoomGroupItemID = item.FK_HRDepartmentRoomGroupItemID;
                        assetShipmentItemsInfo.FK_HRDepartmentRoomID = item.FK_HRDepartmentRoomID;
                        assetShipmentItemsInfo.FK_HREmployeeUserID = item.FK_HREmployeeUserID;
                        assetShipmentItemsInfo.FK_MMLineID = item.FK_MMLineID;
                        assetShipmentItemsInfo.FK_MMWorkShopID = item.FK_MMWorkShopID;

                        objAssetShipmentItemsController.CreateObject(assetShipmentItemsInfo);
                    }
                }
            }
        }
        #endregion

        public override bool IsInvalidInventory()
        {
            //comments out the code for updating old data
            return ShipmentItemList.IsInvalidInventory(TransactionUtil.cstInventoryShipment);
            //return false;
        }

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(iICProductID);
            if (objProductsInfo != null)
            {
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
                ICShipmentItemsInfo objShipmentItemsInfo = (ICShipmentItemsInfo)ModuleObjects[TableName.ICShipmentItemsTableName];
                objShipmentItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                SetDefaultValuesFromProduct(objProductsInfo.ICProductID);
                objShipmentItemsInfo.FK_ICStockID = objShipmentsInfo.FK_ICStockID;
                objShipmentItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductSaleUnitID;
                objShipmentItemsInfo.ICProductDepreciationMethod = objProductsInfo.ICProductDepreciationMethod;
                objShipmentItemsInfo.ICShipmentItemProductRemainedQty = objShipmentItemsInfo.ICShipmentItemProductQty;
                ACAccountsController objAccountsController = new ACAccountsController();
                objShipmentItemsInfo.FK_ACDepreciationCostAccountID = objProductsInfo.FK_ACDepreciationCostAccountID;
                UpdateModuleObjectBindingSource(TableName.ICShipmentItemsTableName);
            }
        }

        #region Accounting
        //public override bool SaveAccountingData()
        //{
        //    ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
        //    foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
        //    {
        //        BOSUtil.CopyObject(objShipmentsInfo, objDocumentsInfo);                
        //    }
        //    return base.SaveAccountingData();
        //}
        #endregion
        public override bool CompleteTransaction()
        {
            //Update shipment status
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.Complete.ToString();
            ICProductSeriesInfo objProductSeriesInfo = new ICProductSeriesInfo();
            ACAssetsController objAssetsController = new ACAssetsController();
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            UpdateMainObject();
            MMAllocationProposalItemsController objAllocationProposalItemsController = new MMAllocationProposalItemsController();
            ICProductIdentifiedEquipmentsController objProductIdentifiedEquipmentsController = new ICProductIdentifiedEquipmentsController();

            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentItemList = new List<ICShipmentItemsInfo>();

            ShipmentItemList.SaveItemObjects();
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();

            foreach (ICShipmentItemsInfo item in ShipmentItemList)
            {
                ACAssetsInfo objAssetsInfo = (ACAssetsInfo)objAssetsController.GetObjectByID(item.FK_ACAssetID);
                if (objAssetsInfo != null && objAssetsInfo.FK_ICProductSerieID == 0)
                {
                    objAssetsInfo.FK_ICProductSerieID = item.FK_ICProductSerieID;
                    objAssetsInfo.ACAssetStatus = AssetStatus.Using.ToString();
                    objAssetsController.UpdateObject(objAssetsInfo);
                }
                else
                {
                    throw new Exception("Sản phẩm " + item.ICShipmentItemProductDesc + " đã được xuất kho. Vui lòng kiểm tra lại");
                }
            }
                ((AssetDecreasingModule)Module).GeneralAssetReceipt();
            ((AssetDecreasingModule)Module).UpdateAAlocationProposalItemQty();


            //SaveAccountingData();

            return true;
        }
    }
}
