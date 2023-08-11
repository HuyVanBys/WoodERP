using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Linq;

namespace BOSERP.Modules.BatchReceiptFreshLumber
{
    class BatchReceiptFreshLumberEntities : BaseTransactionEntities
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


        #endregion

        #region Constructor
        public BatchReceiptFreshLumberEntities()
            : base()
        {
            ReceiptItemsList = new BOSItemsEntityList<ICReceiptItemsInfo>();
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
        }
        public override void InitGridControlInBOSList()
        {
            ReceiptItemsList.InitBOSListGridControl(BatchReceiptFreshLumberModule.ReceiptItemGridControlName);
            DocumentEntryList.InitBOSListGridControl(BatchReceiptFreshLumberModule.DocumentGridControlName);
        }
        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ReceiptItemsList.SetDefaultListAndRefreshGridControl();
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
            ICStocksController objStockController = new ICStocksController();
            ICStocksInfo objStockInfo = (ICStocksInfo)objStockController.GetObjectByNo(StockNo.FreshLumberStock.ToString());
            objReceiptsInfo.ICReceiptTypeCombo = ReceiptType.LumberReceipt.ToString();
            objReceiptsInfo.ICReceiptDate = DateTime.Now;
            //hardcode
            objReceiptsInfo.FK_ICStockID = objStockInfo.ICStockID;
            objReceiptsInfo.ICReceiptStatus = ReceiptStatus.New.ToString();
            objReceiptsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objReceiptsInfo.ICReceiptExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objReceiptsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objReceiptsInfo.ICReceiptPackNo = GetProductWoodLotNo();
            UpdateMainObjectBindingSource();
        }
        #region Invalidate Module Objects Functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ReceiptItemsList.Invalidate(iObjectID);
        }
        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            ReceiptItemsList.SaveItemObjects();
            SaveAccountingData();
        }
        public void UpdateProductQty()
        {
            //ICReceiptItemsInfo objReceiptItemsInfo = (ICReceiptItemsInfo)ReceiptItemsList[ReceiptItemsList.CurrentIndex];
            //objReceiptItemsInfo.ICReceiptItemProductQty = 0;
            //if (objReceiptItemsInfo != null)
            //    objReceiptItemsInfo.ICReceiptItemProductQty = objReceiptItemsInfo.ICReceiptItemProductLength * objReceiptItemsInfo.ICReceiptItemProductPerimeter *
            //                                                objReceiptItemsInfo.ICReceiptItemWoodQty;
            //foreach (ICReceiptItemsInfo objReceiptItemsInfo in ReceiptItemsList)
            //{
            //    objReceiptItemsInfo.ICReceiptItemProductQty = objReceiptItemsInfo.ICReceiptItemProductLength * objReceiptItemsInfo.ICReceiptItemProductPerimeter *
            //                                                objReceiptItemsInfo.ICReceiptItemWoodQty;
            //}
            ReceiptItemsList.GridControl.RefreshDataSource();
            SaveAccountingData();
        }
        public void ApprovedReceipt()
        {
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICReceiptsInfo receipt = (ICReceiptsInfo)MainObject;
            receipt.ICReceiptStatus = ReceiptStatus.Complete.ToString();
            UpdateMainObject();
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
            }
            ReceiptItemsList.SaveItemObjects();
            SaveAccountingData();

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
        #endregion
    }
}
