using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.AssetIncreasing
{
    public class AssetIncreasingEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the receipt item list
        /// </summary>
        public BOSItemsEntityList<ICReceiptItemsInfo> ReceiptItemList { get; set; }
        #endregion

        #region Constructor
        public AssetIncreasingEntities()
            : base()
        {
            ReceiptItemList = new BOSItemsEntityList<ICReceiptItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICReceiptsInfo();
            SearchObject = new ICReceiptsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICReceiptItemsTableName, new ICReceiptItemsInfo());
        }

        public override void InitModuleObjectList()
        {

            ReceiptItemList.InitBOSList(
                                        this,
                                        TableName.ICReceiptsTableName,
                                        TableName.ICReceiptItemsTableName,
                                        BOSItemsEntityList<ICReceiptItemsInfo>.cstRelationForeign);
            ReceiptItemList.ItemTableForeignKey = "FK_ICReceiptID";
        }

        public override void InitGridControlInBOSList()
        {
            ReceiptItemList.InitBOSListGridControl(AssetIncreasingModule.ReceiptItemGridControlName);
            DocumentEntryList.InitBOSListGridControl(AssetIncreasingModule.DocumentEntryGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ReceiptItemList.SetDefaultListAndRefreshGridControl();
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

            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            objReceiptsInfo.ICReceiptDate = DateTime.Now;
            objReceiptsInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            objReceiptsInfo.ICReceiptTypeCombo = ReceiptType.AssetIncreasing.ToString();
            objReceiptsInfo.ICReceiptStatus = ReceiptStatus.New.ToString();
            objReceiptsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objReceiptsInfo.ICReceiptExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objReceiptsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            //objReceiptsInfo.ICReceiptStatus = ReceiptStatus.Complete.ToString();
            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects Functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<ICReceiptItemsInfo> receiptItems = objReceiptItemsController.GetItemsByReceiptID(iObjectID);
            ReceiptItemList.Invalidate(receiptItems);
        }
        #endregion

        #region Save Module Objects Functions
        public override int SaveMainObject()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            objReceiptsInfo.FK_ACObjectID = objReceiptsInfo.FK_APSupplierID;
            objReceiptsInfo.ICObjectType = ObjectType.Supplier.ToString();
            int receiptID = base.SaveMainObject();
            return receiptID;
        }

        public override void SaveModuleObjects()
        {
            //Generate product series
            ICReceiptsInfo receipt = (ICReceiptsInfo)MainObject;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo objProductSeriesInfo;
            //foreach (ICReceiptItemsInfo item in ReceiptItemList)
            //{
            //   // ICProductSeriesInfo objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.ICReceiptItemProductSerialNo);
            //    /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
            //    objProductSeriesInfo = objProductSeriesController.GetProductSerieForEquipment(item.FK_ICProductID, item.ICReceiptItemProductSerialNo, item.FK_ICModelID, item.FK_ICModelDetailID);
            //    /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */
            //    if (objProductSeriesInfo == null)
            //    {
            //        objProductSeriesInfo = new ICProductSeriesInfo();
            //        objProductSeriesInfo.AACreatedDate = DateTime.Now;
            //        objProductSeriesInfo.FK_ICProductID = item.FK_ICProductID;
            //        objProductSeriesInfo.ICProductSerieNo = item.ICReceiptItemProductSerialNo;
            //        objProductSeriesInfo.ICProductSerieReceiptDate = receipt.ICReceiptDate;
            //        /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
            //        objProductSeriesInfo.FK_ICModelID = item.FK_ICModelID;
            //        objProductSeriesInfo.FK_ICModelDetailID = item.FK_ICModelDetailID;
            //        /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */
            //        objProductSeriesController.CreateObject(objProductSeriesInfo);
            //    }
            //    item.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
            //}

            ReceiptItemList.SaveItemObjects();

            ////Rollback on-hand quantity
            //foreach (ICReceiptItemsInfo item in ReceiptItemList.BackupList)
            //{
            //    TransactionUtil.UpdateInventoryStock(
            //                                    item.FK_ICProductID,
            //                                    item.FK_ICStockID,
            //                                    item.FK_ICProductSerieID,
            //                                    item.ICReceiptItemProductQty,
            //                                    item.ICReceiptItemInventoryCost,
            //                                    TransactionUtil.cstInventoryShipment);
            //}

            ////Update on-hand quantity
            //foreach (ICReceiptItemsInfo item in ReceiptItemList)
            //{
            //    int result = 0;
            //    result = TransactionUtil.UpdateInventoryStock(
            //                                    item.FK_ICProductID,
            //                                    item.FK_ICStockID,
            //                                    item.FK_ICProductSerieID,
            //                                    item.ICReceiptItemProductQty,
            //                                    item.ICReceiptItemInventoryCost,
            //                                    TransactionUtil.cstInventoryReceipt);
            //    if (result == 0)
            //    {
            //        throw new Exception("Sản phẩm " + item.ICReceiptItemProductDesc + " không đủ số lượng tồn kho. Vui lòng kiểm tra lại!");
            //    }
            //}

            SaveAccountingData();
        }

        public override bool IsInvalidInventory()
        {
            return ReceiptItemList.IsInvalidInventory(TransactionUtil.cstInventoryReceipt);
        }
        #endregion

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            ICReceiptsInfo objICReceiptsInfo = (ICReceiptsInfo)MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(iICProductID);
            if (objProductsInfo != null)
            {
                ICReceiptItemsInfo objICReceiptItemsInfo = (ICReceiptItemsInfo)ModuleObjects[TableName.ICReceiptItemsTableName];
                objICReceiptItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                SetDefaultValuesFromProduct(iICProductID);
                SetProductCost(objICReceiptItemsInfo);
                objICReceiptItemsInfo.FK_ICStockID = objICReceiptsInfo.FK_ICStockID;
                objICReceiptItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductPurchaseUnitID;
                UpdateModuleObjectBindingSource(TableName.ICReceiptItemsTableName);
            }
        }
        public override int CreateMainObject()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            int iObjectID = 0;
            bool editObjectNo = true;
            if (objReceiptsInfo.ICReceiptNo.Equals(cstNewObjectText))
            {
                editObjectNo = false;
            }
            iObjectID = base.CreateMainObject();
            if (!editObjectNo && iObjectID > 0)
            {
                GENumberingController objGENumberingController = new GENumberingController();
                GENumberingInfo objGENumberingInfo = (GENumberingInfo)objGENumberingController.GetObjectByName("ProductSerialNo");
                if (objGENumberingInfo != null)
                {

                    // if (objReceiptsInfo.ICReceiptReference.Trim() == string.Empty)
                    {
                        UpdateProductLotNo(objGENumberingInfo.GENumberingStart);
                    }
                    foreach (ICReceiptItemsInfo item in ReceiptItemList)
                    {
                        if ((item.ICReceiptItemLotNo == null || item.ICReceiptItemLotNo == string.Empty))
                        {
                            item.ICReceiptItemLotNo = objReceiptsInfo.ICReceiptPackNo;
                        }
                    }
                }
            }
            return iObjectID;
        }

        #region Accounting
        public override bool SaveAccountingData()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
            {
                BOSUtil.CopyObject(objReceiptsInfo, objDocumentsInfo);
                objDocumentsInfo.FK_ACObjectID = objReceiptsInfo.FK_APSupplierID;
                objDocumentsInfo.ACObjectType = ObjectType.Supplier.ToString();
            }
            return base.SaveAccountingData();
        }
        #endregion
        public override bool CompleteTransaction()
        {
            ICReceiptsInfo receipt = (ICReceiptsInfo)MainObject;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            receipt.ICReceiptStatus = ReceiptStatus.Complete.ToString();
            UpdateMainObject();
            ICProductSeriesInfo objProductSeriesInfo = new ICProductSeriesInfo();
            foreach (ICReceiptItemsInfo item in ReceiptItemList)
            {
                // ICProductSeriesInfo objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.ICReceiptItemProductSerialNo);
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
                objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.ICReceiptItemProductSerialNo);
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */
                if (objProductSeriesInfo == null)
                {
                    objProductSeriesInfo = new ICProductSeriesInfo();
                    objProductSeriesInfo.AACreatedDate = DateTime.Now;
                    objProductSeriesInfo.FK_ICProductID = item.FK_ICProductID;
                    objProductSeriesInfo.ICProductSerieNo = item.ICReceiptItemProductSerialNo;
                    objProductSeriesInfo.ICProductSerieReceiptDate = receipt.ICReceiptDate;
                    objProductSeriesController.CreateObject(objProductSeriesInfo);
                }
                item.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
            }


            ReceiptItemList.SaveItemObjects();
            SaveAccountingData();
            return true;
        }
    }
}
