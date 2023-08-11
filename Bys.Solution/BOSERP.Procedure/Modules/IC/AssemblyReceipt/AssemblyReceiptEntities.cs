using BOSCommon;
using BOSCommon.Constants;
using BOSERP.GenaralLeadger;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace BOSERP.Modules.AssemblyReceipt
{
    public class AssemblyReceiptEntities : GLReceiptEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        public BOSItemsEntityList<ICReceiptItemsInfo> ComponentReceiptItemList { get; set; }
        #endregion

        #region Constructor
        public AssemblyReceiptEntities()
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
            ReceiptItemsList.InitBOSListGridControl(AssemblyReceiptModule.ReceiptItemGridControlName);
            DocumentEntryList.InitBOSListGridControl(AssemblyReceiptModule.DocumentEntryGridControlName);
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

        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            objReceiptsInfo.ICReceiptDate = BOSApp.GetCurrentServerDate();
            objReceiptsInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            objReceiptsInfo.ICReceiptTypeCombo = ReceiptType.AssemblyReceipt.ToString();
            objReceiptsInfo.ICReceiptStatus = ReceiptStatus.New.ToString();
            objReceiptsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objReceiptsInfo.ICReceiptExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objReceiptsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects Functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ReceiptItemsList.Invalidate(iObjectID);

            InvalidateItemComponents();
        }
        #endregion

        #region Save Module Objects Functions
        public override void SaveModuleObjects()
        {
            //Update status of stock receipt
            ICReceiptsInfo receipt = (ICReceiptsInfo)MainObject;
            receipt.ICReceiptStatus = ReceiptStatus.Complete.ToString();
            UpdateMainObject();

            InvalidateItemComponents();

            //Generate product series
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();

            foreach (ICReceiptItemsInfo item in ComponentReceiptItemList)
            {
                if (string.IsNullOrEmpty(item.ICReceiptItemProductSerialNo))
                    continue;

                ICProductSeriesInfo objProductSeriesInfo = new ICProductSeriesInfo();
                if (item.ICReceiptItemProductType == ProductType.Lumber.ToString())
                    objProductSeriesInfo = objProductSeriesController.GetProductSeriesByNoAndProductHeight(item.FK_ICProductID,
                                                                                                           item.FK_ICStockID,
                                                                                                           item.ICReceiptItemProductSerialNo,
                                                                                                           item.ICReceiptItemProductHeight);
                else
                    objProductSeriesInfo = objProductSeriesController.GetProductSeriesByNoAndProductSize(item.FK_ICProductID,
                                                                                                         item.FK_ICStockID,
                                                                                                         item.ICReceiptItemProductSerialNo,
                                                                                                         item.ICReceiptItemProductLength,
                                                                                                         item.ICReceiptItemProductWidth,
                                                                                                         item.ICReceiptItemProductHeight);
                if (objProductSeriesInfo == null)
                {
                    objProductSeriesInfo = new ICProductSeriesInfo();
                    objProductSeriesInfo.AACreatedDate = BOSApp.GetCurrentServerDate();
                    objProductSeriesInfo.FK_ICProductID = item.FK_ICProductID;
                    objProductSeriesInfo.ICProductSerieNo = item.ICReceiptItemProductSerialNo;
                    objProductSeriesInfo.ICProductSerieReceiptDate = receipt.ICReceiptDate;
                    objProductSeriesInfo.ICProductSerieProductHeight = item.ICReceiptItemProductHeight;
                    if (item.ICReceiptItemProductType != ProductType.Lumber.ToString())
                    {
                        objProductSeriesInfo.ICProductSerieProductWidth = item.ICReceiptItemProductWidth;
                        objProductSeriesInfo.ICProductSerieProductLength = item.ICReceiptItemProductLength;
                    }

                    objProductSeriesController.CreateObject(objProductSeriesInfo);
                }
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
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            if (objProductsInfo != null)
            {
                ICReceiptItemsInfo receiptItem = (ICReceiptItemsInfo)item;
                receiptItem.FK_ICProductID = objProductsInfo.ICProductID;
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
    }
}
