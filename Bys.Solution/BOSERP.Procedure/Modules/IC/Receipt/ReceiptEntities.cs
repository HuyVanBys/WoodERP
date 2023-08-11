using BOSCommon;
using BOSCommon.Constants;
using BOSERP.GenaralLeadger;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.Receipt
{
    public class ReceiptEntities : GLReceiptEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public int CountItemsInReceiptPackageItemList = 0;

        /// <summary>
        /// Gets or sets receipt item list including the item's components        
        /// </summary>
        public BOSItemsEntityList<ICReceiptItemsInfo> ComponentReceiptItemList { get; set; }
        public BOSList<ICReceiptPackageItemsInfo> ReceiptPackageItemList { get; set; }
        public BOSList<ICReceiptPackageItemDetailsInfo> ReceiptPackageItemDetailShowList { get; set; }
        public BOSList<ICReceiptPackageItemDetailsInfo> ReceiptPackageItemDetailList { get; set; }
        public BOSList<ICReceiptPackageItemDetailsInfo> DeleteReceiptPackageItemDetailList { get; set; }
        public BOSList<ICReceiptPackageItemDetailsInfo> ReceiptPackageItemDetailReportList { get; set; }
        #endregion

        #region Constructor
        public ReceiptEntities()
            : base()
        {
            ReceiptItemsList = new BOSItemsEntityList<ICReceiptItemsInfo>();
            ComponentReceiptItemList = new BOSItemsEntityList<ICReceiptItemsInfo>();
            ReceiptPackageItemList = new BOSList<ICReceiptPackageItemsInfo>();
            ReceiptPackageItemDetailShowList = new BOSList<ICReceiptPackageItemDetailsInfo>();
            ReceiptPackageItemDetailList = new BOSList<ICReceiptPackageItemDetailsInfo>();
            DeleteReceiptPackageItemDetailList = new BOSList<ICReceiptPackageItemDetailsInfo>();
            ReceiptPackageItemDetailReportList = new BOSList<ICReceiptPackageItemDetailsInfo>();
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
            ModuleObjects.Add(TableName.ICReceiptPackageItemsTableName, new ICReceiptPackageItemsInfo());
            ModuleObjects.Add(TableName.ICReceiptPackageItemDetailsTableName, new ICReceiptPackageItemDetailsInfo());
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

            ReceiptPackageItemList.InitBOSList(this,
                                               TableName.ICReceiptsTableName,
                                               TableName.ICReceiptPackageItemsTableName,
                                               BOSList<ICReceiptPackageItemsInfo>.cstRelationForeign);
            ReceiptPackageItemList.ItemTableForeignKey = "FK_ICReceiptID";

            ReceiptPackageItemDetailShowList.InitBOSList(this,
                                               TableName.ICReceiptPackageItemsTableName,
                                               TableName.ICReceiptPackageItemDetailsTableName,
                                               BOSList<ICReceiptPackageItemDetailsInfo>.cstRelationForeign);
            ReceiptPackageItemDetailShowList.ItemTableForeignKey = "FK_ICReceiptPackageItemID";

            ReceiptPackageItemDetailList.InitBOSList(this,
                                               TableName.ICReceiptPackageItemsTableName,
                                               TableName.ICReceiptPackageItemDetailsTableName,
                                               BOSList<ICReceiptPackageItemDetailsInfo>.cstRelationForeign);
            ReceiptPackageItemDetailList.ItemTableForeignKey = "FK_ICReceiptPackageItemID";

            DeleteReceiptPackageItemDetailList.InitBOSList(this,
                                               TableName.ICReceiptPackageItemsTableName,
                                               TableName.ICReceiptPackageItemDetailsTableName,
                                               BOSList<ICReceiptPackageItemDetailsInfo>.cstRelationForeign);
            DeleteReceiptPackageItemDetailList.ItemTableForeignKey = "FK_ICReceiptPackageItemID";

            ReceiptPackageItemDetailReportList.InitBOSList(this,
                                               TableName.ICReceiptPackageItemsTableName,
                                               TableName.ICReceiptPackageItemDetailsTableName,
                                               BOSList<ICReceiptPackageItemDetailsInfo>.cstRelationForeign);
            ReceiptPackageItemDetailReportList.ItemTableForeignKey = "FK_ICReceiptPackageItemID";
        }

        public override void InitGridControlInBOSList()
        {
            ReceiptItemsList.InitBOSListGridControl(ReceiptModule.ReceiptItemGridControlName);
            DocumentEntryList.InitBOSListGridControl(ReceiptModule.DocumentEntryGridControlName);
            ReceiptPackageItemList.InitBOSListGridControl("fld_dgcICReceiptPackageItems");
            ReceiptPackageItemDetailShowList.InitBOSListGridControl("fld_dgcICReceiptPackageItemDetails");
            ReceiptPackageItemDetailList.InitBOSListGridControl();
            ReceiptPackageItemDetailReportList.InitBOSListGridControl("fld_dgcICReceiptPackageItemDetails2");
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ReceiptItemsList.SetDefaultListAndRefreshGridControl();
                ComponentReceiptItemList.SetDefaultListAndRefreshGridControl();
                ReceiptPackageItemList.SetDefaultListAndRefreshGridControl();
                ReceiptPackageItemDetailShowList.SetDefaultListAndRefreshGridControl();
                ReceiptPackageItemDetailList.SetDefaultListAndRefreshGridControl();
                DeleteReceiptPackageItemDetailList.SetDefaultListAndRefreshGridControl();
                ReceiptPackageItemDetailReportList.SetDefaultListAndRefreshGridControl();
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
            objReceiptsInfo.ICReceiptTypeCombo = ReceiptType.Receipt.ToString();
            objReceiptsInfo.ICReceiptStatus = ReceiptStatus.New.ToString();
            objReceiptsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objReceiptsInfo.ICReceiptExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objReceiptsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            CountItemsInReceiptPackageItemList = 0;
            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects Functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<ICReceiptItemsInfo> receiptItemsList = objReceiptItemsController.GetListItemByReceiptID(iObjectID);
            ReceiptItemsList.Invalidate(receiptItemsList.OrderBy(o => o.Id).ToList());

            //Invalidate components
            InvalidateItemComponents();

            CountItemsInReceiptPackageItemList = ReceiptPackageItemList.Count();
            ReceiptPackageItemList.Clear();

            bool isEditing = false;
            ReceiptPackageItemList.Invalidate(iObjectID);
            ReceiptPackageItemList.ForEach(o =>
            {
                if (o.ICReceiptPackageItemID == 0)
                {
                    isEditing = true;
                }
            });
            if (!isEditing)
            {
                ReceiptPackageItemDetailShowList.Clear();
                ReceiptPackageItemList.ForEach(o =>
                {
                    ICReceiptPackageItemDetailsController objReceiptPackageItemDetailsController = new ICReceiptPackageItemDetailsController();
                    List<ICReceiptPackageItemDetailsInfo> ReceiptPackageItemDetailList = objReceiptPackageItemDetailsController.GetPackageItemDetailsListByPackageItemID(o.ICReceiptPackageItemID);
                    ReceiptPackageItemDetailList.ForEach(x =>
                    {
                        ReceiptPackageItemDetailShowList.Add(x);
                    });
                });
            }
            ReceiptPackageItemDetailShowList.GridControl?.RefreshDataSource();
        }
        #endregion

        #region Save Module Objects Functions        
        public override void SaveModuleObjects()
        {
            //Update status of stock receipt
            ICReceiptsInfo receipt = (ICReceiptsInfo)MainObject;
            receipt.ICReceiptStatus = ReceiptStatus.Complete.ToString();
            receipt.ICReceiptPostedStatus = PostedTransactionStatus.Posted.ToString();
            UpdateMainObject();

            //Save item list
            //ReceiptItemsList.SaveItemObjects();

            // InvalidateItemComponents();

            //Generate product series
            //ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            //foreach (ICReceiptItemsInfo item in ReceiptItemsList)
            //{
            //    if (!string.IsNullOrEmpty(item.ICReceiptItemProductSerialNo))
            //    {
            //        ICProductSeriesInfo objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.ICReceiptItemProductSerialNo);
            //        if (objProductSeriesInfo == null)
            //        {
            //            objProductSeriesInfo = new ICProductSeriesInfo();
            //            objProductSeriesInfo.AACreatedDate = DateTime.Now;
            //            objProductSeriesInfo.FK_ICProductID = item.FK_ICProductID;
            //            objProductSeriesInfo.ICProductSerieNo = item.ICReceiptItemProductSerialNo;
            //            objProductSeriesInfo.ICProductSerieLotNo = item.ICReceiptItemLotNo;
            //            objProductSeriesInfo.ICProductSerieReceiptDate = receipt.ICReceiptDate;
            //            objProductSeriesInfo.ICProductSerieProductHeight = item.ICReceiptItemProductHeight;
            //            objProductSeriesInfo.ICProductSerieProductWidth = item.ICReceiptItemProductWidth;
            //            objProductSeriesInfo.ICProductSerieProductLength = item.ICReceiptItemProductLength;
            //            objProductSeriesInfo.ICProductSerieProductPerimeter = item.ICReceiptItemProductPerimeter;
            //            objProductSeriesController.CreateObject(objProductSeriesInfo);
            //        }
            //        item.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
            //    }
            //}

            ////Update product series to the items
            ReceiptItemsList.SaveItemObjects();
            GLHelper.PostedTransactions(this.Module.Name, receipt.ICReceiptID, ModulePostingType.Stock, ModulePostingType.Accounting);
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
        #endregion

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            SetValuesAfterValidateProduct(iICProductID, ModuleObjects[TableName.ICReceiptItemsTableName]);
            UpdateModuleObjectBindingSource(TableName.ICReceiptItemsTableName);
        }

        public override void SetValuesAfterValidateProduct(int productID, BusinessObject item)
        {
            ICReceiptsInfo objICReceiptsInfo = (ICReceiptsInfo)MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo != null)
            {
                ICReceiptItemsInfo receiptItem = (ICReceiptItemsInfo)item;
                receiptItem.FK_ICProductID = objProductsInfo.ICProductID;
                receiptItem.ICReceiptItemProductFactor = 1;
                receiptItem.ICReceiptItemIsAverageCalculation = false;
                SetDefaultValuesFromProduct(productID, receiptItem);
                SetProductCost(receiptItem);
                receiptItem.FK_ICStockID = objICReceiptsInfo.FK_ICStockID;
                if (objProductsInfo.FK_ICProductPurchaseUnitID != 0)
                {
                    receiptItem.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductPurchaseUnitID;
                }
                else
                {
                    receiptItem.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                }
            }
        }

        /// <summary>
        /// Invalidate item components of the receipt items
        /// </summary>
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

        public void RemoveOldReceiptPackageItemDetailItem(IBOSList<ICReceiptPackageItemDetailsInfo> ReceiptPackageItemDetailsList)
        {
            List<ICReceiptPackageItemDetailsInfo> RemovePackageItemDetailsList = (List<ICReceiptPackageItemDetailsInfo>)ReceiptPackageItemDetailsList;
            RemovePackageItemDetailsList.ForEach(o =>
            {
                ReceiptPackageItemDetailShowList.ForEach(x =>
                {
                    if (o.FK_APPOPackageItemID > 0)
                    {
                        if (x.FK_APPOPackageItemID == o.FK_APPOPackageItemID)
                            ReceiptPackageItemDetailShowList.Remove(x);
                    }
                    else if (o.FK_APInvoiceInPackageItemID > 0)
                    {
                        if (x.FK_APInvoiceInPackageItemID == o.FK_APInvoiceInPackageItemID)
                            ReceiptPackageItemDetailShowList.Remove(x);
                    }
                    else if (x.FK_ICReceiptPackageItemID == o.FK_ICReceiptPackageItemID)
                        ReceiptPackageItemDetailShowList.Remove(x);
                });
            });
        }

        public GECurrencyExchangeRatesInfo GetCurrencyExchangeRate(int currencyID, DateTime currentDate)
        {
            return (new GECurrencyExchangeRatesController()).GetCurrencyExchangeRateByCurrencyIDAnddate(currencyID, currentDate);
        }

        public override void AfterSaveTransaction()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;

            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            objProductSeriesController.GenerateProductSerieByReceiptID(objReceiptsInfo.ICReceiptID);

            GLHelper.PostedTransactions(this.Module.Name, objReceiptsInfo.ICReceiptID, ModulePostingType.Stock, ModulePostingType.Accounting);
        }
    }
}
