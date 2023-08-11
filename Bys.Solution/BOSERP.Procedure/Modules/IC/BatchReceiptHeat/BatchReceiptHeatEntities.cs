using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.BatchReceiptHeat
{
    public class BatchReceiptHeatEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the receipt item list
        /// </summary>
        public BOSItemsEntityList<ICReceiptItemsInfo> ReceiptItemsList { get; set; }

        /// <summary>
        /// Gets or sets receipt item list including the item's components        
        /// </summary>
        public BOSItemsEntityList<ICReceiptItemsInfo> ComponentReceiptItemList { get; set; }
        #endregion

        #region Constructor
        public BatchReceiptHeatEntities()
            : base()
        {
            ReceiptItemsList = new BOSItemsEntityList<ICReceiptItemsInfo>();
            ComponentReceiptItemList = new BOSItemsEntityList<ICReceiptItemsInfo>();
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
            ReceiptItemsList.InitBOSList(this,
                                                              TableName.ICReceiptsTableName,
                                                              TableName.ICReceiptItemsTableName,
                                                              BOSItemsEntityList<ICReceiptItemsInfo>.cstRelationForeign);
            ReceiptItemsList.ItemTableForeignKey = "FK_ICReceiptID";

            ComponentReceiptItemList.InitBOSList(this,
                                                TableName.ICReceiptsTableName,
                                                TableName.ICReceiptItemsTableName,
                                                BOSItemsEntityList<ICReceiptItemsInfo>.cstRelationForeign);
            ComponentReceiptItemList.ItemTableForeignKey = "FK_ICReceiptID";
        }

        public override void InitGridControlInBOSList()
        {
            ReceiptItemsList.InitBOSListGridControl(BatchReceiptHeatModule.ReceiptItemGridControlName);
            DocumentEntryList.InitBOSListGridControl(BatchReceiptHeatModule.DocumentEntryGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ReceiptItemsList.SetDefaultListAndRefreshGridControl();
                ComponentReceiptItemList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }
        public void UpdateTotalCost()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            objReceiptsInfo.ICReceiptSubTotalCost = 0;
            foreach (ICReceiptItemsInfo entItem in ReceiptItemsList)
            {
                objReceiptsInfo.ICReceiptSubTotalCost += entItem.ICReceiptItemTotalCost;
                BOSApp.RoundByCurrency(entItem, objReceiptsInfo.FK_GECurrencyID);
            }
            objReceiptsInfo.ICReceiptTotalCost = objReceiptsInfo.ICReceiptSubTotalCost;
            BOSApp.RoundByCurrency(objReceiptsInfo, objReceiptsInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }

        public void ApprovedReceipt()
        {
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            //Update status of stock receipt
            ICReceiptsInfo receipt = (ICReceiptsInfo)MainObject;
            receipt.ICReceiptStatus = ReceiptStatus.Complete.ToString();
            UpdateMainObject();
            //Generate product series
            foreach (ICReceiptItemsInfo item in ReceiptItemsList)
            {
                if (item.ICReceiptItemLotNo.Trim() == string.Empty)
                    item.ICReceiptItemLotNo = receipt.ICReceiptPackNo;
            }
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            foreach (ICReceiptItemsInfo item in ReceiptItemsList)
            {
                if (!string.IsNullOrEmpty(item.ICReceiptItemProductSerialNo))
                {
                    objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                    if (objProductsInfo.ICProductType != ProductType.Service.ToString() && !objProductsInfo.IsAsset)
                    {
                        TransactionUtil.UpdateProductSerieQuantity(
                                                item.FK_ICProductID,
                                                item.FK_ICProductSerieID,
                                                TransactionUtil.cstInventoryReceipt,
                                                item.ICReceiptItemProductSerialNo,
                                                receipt.ICReceiptDate,
                                                item.FK_ICProductAttributeWoodTypeID,
                                                item.FK_ICProductAttributeTTMTID,
                                                item.FK_GECountryID,
                                                item.FK_ICProductAttributeQualityID,
                                                item.ICReceiptItemLotNo,
                                                item.ICReceiptItemWoodQty,
                                                item.ICReceiptItemLogListNo,
                                                item.ICReceiptItemContainerNo,
                                                item.ICReceiptItemProductDesc,
                                                item.ICReceiptItemProductHeight,
                                                item.ICReceiptItemProductWidth,
                                                item.ICReceiptItemProductLength,
                                                item.ICReceiptItemProductPerimeter,
                                                item.ICReceiptItemWidthMax,
                                                item.ICReceiptItemLenghtMax,
                                                item.ICReceiptItemProductPerimeterMax,
                                                item.ICReceiptItemWidthMin,
                                                item.ICReceiptItemLenghtMin);

                    }
                    ICProductSeriesInfo objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.ICReceiptItemProductSerialNo);
                    if (objProductSeriesInfo != null)
                    {
                        item.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                        if (!item.IsSubItem)
                        {
                            ICReceiptItemsInfo item1 = ReceiptItemsList.Where(i => i.Id == item.Id).FirstOrDefault();
                            if (item1 != null)
                            {
                                item1.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                            }
                        }
                    }
                }
                SaveAccountingData();
            }

            //Update product series to the items
            ReceiptItemsList.SaveItemObjects();
            SaveAccountingData();
        }

        #endregion

        #region Invalidate Module Objects Functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ReceiptItemsList.Invalidate(iObjectID);

            //Invalidate components
            InvalidateItemComponents();
        }
        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            ICStocksController objStockController = new ICStocksController();
            ICStocksInfo objStockInfo = (ICStocksInfo)objStockController.GetObjectByNo(StockNo.HeatStock.ToString());
            objReceiptsInfo.ICReceiptDate = DateTime.Now;
            //hardcode
            objReceiptsInfo.FK_ICStockID = objStockInfo.ICStockID;
            objReceiptsInfo.ICReceiptStatus = ReceiptStatus.New.ToString();
            objReceiptsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objReceiptsInfo.ICReceiptExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objReceiptsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objReceiptsInfo.ICReceiptPackNo = App.DefaultPackNo;
            objReceiptsInfo.ICReceiptTypeCombo = ReceiptType.ReceiptHeat.ToString();
            UpdateMainObjectBindingSource();

        }

        public override void SaveModuleObjects()
        {
            ReceiptItemsList.SaveItemObjects();
            SaveAccountingData();
        }
        public void InvalidateItemComponents()
        {
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            List<ICReceiptItemsInfo> items = objReceiptItemsController.GetComponentItemsByReceiptID(objReceiptsInfo.ICReceiptID);
            ComponentReceiptItemList.Clear();
            ComponentReceiptItemList.OriginalList.Clear();
            ComponentReceiptItemList.BackupList.Clear();
            foreach (ICReceiptItemsInfo item in items)
            {
                ComponentReceiptItemList.Add((ICReceiptItemsInfo)item.Clone());
            }

            foreach (ICReceiptItemsInfo item in ComponentReceiptItemList)
            {
                ComponentReceiptItemList.OriginalList.Add((ICReceiptItemsInfo)item.Clone());
            }

            foreach (ICReceiptItemsInfo item in ComponentReceiptItemList)
            {
                ComponentReceiptItemList.BackupList.Add((ICReceiptItemsInfo)item.Clone());
            }
        }
        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            SetValuesAfterValidateProduct(iICProductID, ModuleObjects[TableName.ICReceiptItemsTableName]);
            UpdateModuleObjectBindingSource(TableName.ICReceiptItemsTableName);
        }

        public override void SetValuesAfterValidateProduct(int productID, BusinessObject item)
        {
            ICReceiptsInfo objICReceiptsInfo = (ICReceiptsInfo)MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            if (objProductsInfo != null)
            {
                ICReceiptItemsInfo receiptItem = (ICReceiptItemsInfo)item;
                receiptItem.FK_ICProductID = objProductsInfo.ICProductID;
                SetDefaultValuesFromProduct(productID, receiptItem);
                SetProductCost(receiptItem);
                receiptItem.FK_ICStockID = objICReceiptsInfo.FK_ICStockID;
                receiptItem.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductPurchaseUnitID;
                receiptItem.FK_ICProductAttributeWoodTypeID = objICReceiptsInfo.FK_ICProductAttributeWoodTypeID;
                receiptItem.FK_GECountryID = objICReceiptsInfo.FK_GECountryID;
                receiptItem.FK_MMBatchProductID = objICReceiptsInfo.FK_MMBatchProductID;
                receiptItem.FK_ICProductAttributeTTMTID = objICReceiptsInfo.FK_ICProductAttributeTTMTID;
                receiptItem.ICReceiptItemWoodQty = objICReceiptsInfo.ICReceiptTotalQty;
                receiptItem.ICReceiptItemContainerNo = objICReceiptsInfo.ICReceiptContainerNo;
                receiptItem.FK_MMOperationID = objICReceiptsInfo.FK_MMOperationID;
                receiptItem.FK_ICStockID = objICReceiptsInfo.FK_ICStockID;
                receiptItem.ICReceiptItemLotNo = objICReceiptsInfo.ICReceiptPackNo;
            }
        }
        #region Accounting
        public override bool SaveAccountingData()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
            {
                BOSUtil.CopyObject(objReceiptsInfo, objDocumentsInfo);
            }
            return base.SaveAccountingData();
        }
        #endregion
        public override bool CompleteTransaction()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            objReceiptsInfo.ICReceiptStatus = ReceiptStatus.Complete.ToString();
            UpdateMainObject();
            ApprovedReceipt();


            return true;
        }
    }

}

