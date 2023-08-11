using BOSCommon;
using BOSCommon.Constants;
using BOSERP.GenaralLeadger;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;


namespace BOSERP.Modules.PurchaseReceipt
{
    public class PurchaseReceiptEntities : GLReceiptEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        /// <summary>
        /// Original receipt item id max
        /// </summary>
        //private int OriginalReceiptItemIDMax;
        #endregion

        #region Public Properties
        public int CountItemsInReceiptPackageItemList = 0;
        public SortedList<int, APPurchaseOrderItemsInfo> APReferencePurchaseOrderItemsList { get; set; }

        /// <summary>
        /// Gets or sets the package list
        /// </summary>
        public BOSList<ICPackagesInfo> PackageList { get; set; }
        /// <summary>
        /// Gets or sets the receipt component item list with a product more package
        /// </summary>
        public BOSList<ICReceiptComponentItemsInfo> MultiPackageReceiptComponentItemsList { get; set; }
        /// <summary>
        /// Gets or sets the receipt component item list with a package more product
        /// </summary>
        public BOSList<ICReceiptComponentItemsInfo> MultiProductReceiptComponentItemsList { get; set; }
        /// <summary>
        /// Gets or sets the receipt component item list with more package more product
        /// </summary>
        public BOSList<ICReceiptComponentItemsInfo> MultiReceiptComponentItemsList { get; set; }

        public BOSList<APPurchaseOrderItemsInfo> PurchaseOrderItemList { get; set; }

        /// <summary>
        /// Gets or sets the receipt item id max
        /// </summary>
        //public int ReceiptItemIDMax { get; set; }

        /// <summary>
        /// Gets or sets receipt item list including the item's components        
        /// </summary>
        public BOSItemsEntityList<ICReceiptItemsInfo> ComponentReceiptItemList { get; set; }

        /// <summary>
        /// Gets or sets the history detail list
        /// </summary>
        public BOSList<GEHistoryDetailsInfo> HistoryDetailList { get; set; }

        /// <summary>
        /// Gets or sets the receipt item log list
        /// </summary>
        public BOSList<ICReceiptItemLogsInfo> ReceiptItemLogList { get; set; }

        public BOSList<ICReceiptPackageItemsInfo> ReceiptPackageItemList { get; set; }
        public BOSList<ICReceiptPackageItemDetailsInfo> ReceiptPackageItemDetailShowList { get; set; }
        public BOSList<ICReceiptPackageItemDetailsInfo> ReceiptPackageItemDetailList { get; set; }
        public BOSList<ICReceiptPackageItemDetailsInfo> DeleteReceiptPackageItemDetailList { get; set; }
        public BOSList<ICReceiptPackageItemDetailsInfo> ReceiptPackageItemDetailReportList { get; set; }

        public BOSList<ICInventoryItemPackagesInfo> InventoryItemPackageList { get; set; }

        public BOSList<ICReceiptItemContsInfo> ReceiptItemContList { get; set; }
        public BOSList<ICReceiptItemContFeesInfo> ReceiptItemContFeeList { get; set; }

        #endregion

        #region Constructor
        public PurchaseReceiptEntities()
            : base()
        {
            APReferencePurchaseOrderItemsList = new SortedList<int, APPurchaseOrderItemsInfo>();
            PackageList = new BOSList<ICPackagesInfo>();
            ReceiptItemsList = new BOSItemsEntityList<ICReceiptItemsInfo>();
            MultiPackageReceiptComponentItemsList = new BOSList<ICReceiptComponentItemsInfo>();
            MultiProductReceiptComponentItemsList = new BOSList<ICReceiptComponentItemsInfo>();
            MultiReceiptComponentItemsList = new BOSList<ICReceiptComponentItemsInfo>();
            ComponentReceiptItemList = new BOSItemsEntityList<ICReceiptItemsInfo>();
            HistoryDetailList = new BOSList<GEHistoryDetailsInfo>();
            ReceiptItemLogList = new BOSList<ICReceiptItemLogsInfo>();
            PurchaseOrderItemList = new BOSItemsEntityList<APPurchaseOrderItemsInfo>();

            ReceiptPackageItemList = new BOSList<ICReceiptPackageItemsInfo>();
            ReceiptPackageItemDetailShowList = new BOSList<ICReceiptPackageItemDetailsInfo>();
            ReceiptPackageItemDetailList = new BOSList<ICReceiptPackageItemDetailsInfo>();
            DeleteReceiptPackageItemDetailList = new BOSList<ICReceiptPackageItemDetailsInfo>();
            ReceiptPackageItemDetailReportList = new BOSList<ICReceiptPackageItemDetailsInfo>();
            InventoryItemPackageList = new BOSList<ICInventoryItemPackagesInfo>();

            ReceiptItemContList = new BOSList<ICReceiptItemContsInfo>();
            ReceiptItemContFeeList = new BOSList<ICReceiptItemContFeesInfo>();
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
            ModuleObjects.Add(TableName.ICReceiptItemPackagesTableName, new ICReceiptItemPackagesInfo());
            ModuleObjects.Add(TableName.ICReceiptComponentItemsTableName, new ICReceiptComponentItemsInfo());
            ModuleObjects.Add(TableName.APPurchaseOrderItemsTableName, new APPurchaseOrderItemsInfo());
            ModuleObjects.Add(TableName.ICReceiptPackageItemsTableName, new ICReceiptPackageItemsInfo());
            ModuleObjects.Add(TableName.ICReceiptPackageItemDetailsTableName, new ICReceiptPackageItemDetailsInfo());

            ModuleObjects.Add(TableName.ICReceiptItemContsTableName, new ICReceiptItemContsInfo());
            ModuleObjects.Add(TableName.ICReceiptItemContFeesTableName, new ICReceiptItemContFeesInfo());
        }

        public override void InitModuleObjectList()
        {
            PackageList.InitBOSList(this, String.Empty, TableName.ICPackagesTableName, BOSList<ICPackagesInfo>.cstRelationNone);

            InventoryItemPackageList.InitBOSList(this, String.Empty, "ICInventoryItemPackages", BOSList<ICInventoryItemPackagesInfo>.cstRelationNone);

            ReceiptItemsList.InitBOSList(this,
                                                              TableName.ICReceiptsTableName,
                                                              TableName.ICReceiptItemsTableName,
                                                              BOSItemsEntityList<ICReceiptItemsInfo>.cstRelationForeign);
            ReceiptItemsList.ItemTableForeignKey = "FK_ICReceiptID";

            MultiPackageReceiptComponentItemsList.InitBOSList(this,
                                                              TableName.ICReceiptItemsTableName,
                                                              TableName.ICReceiptComponentItemsTableName,
                                                              BOSList<ICReceiptComponentItemsInfo>.cstRelationForeign);
            MultiPackageReceiptComponentItemsList.ItemTableForeignKey = "FK_ICReceiptItemID";

            MultiProductReceiptComponentItemsList.InitBOSList(this,
                                                              TableName.ICReceiptItemsTableName,
                                                              TableName.ICReceiptComponentItemsTableName,
                                                              BOSList<ICReceiptComponentItemsInfo>.cstRelationForeign);
            MultiProductReceiptComponentItemsList.ItemTableForeignKey = "FK_ICReceiptItemID";


            MultiReceiptComponentItemsList.InitBOSList(this,
                                                              TableName.ICReceiptItemsTableName,
                                                              TableName.ICReceiptComponentItemsTableName,
                                                              BOSList<ICReceiptComponentItemsInfo>.cstRelationForeign);
            MultiReceiptComponentItemsList.ItemTableForeignKey = "FK_ICReceiptItemID";

            ComponentReceiptItemList.InitBOSList(this,
                                                TableName.ICReceiptsTableName,
                                                TableName.ICReceiptItemsTableName,
                                                BOSItemsEntityList<ICReceiptItemsInfo>.cstRelationForeign);
            ComponentReceiptItemList.ItemTableForeignKey = "FK_ICReceiptID";

            HistoryDetailList.InitBOSList(this,
                                          TableName.GEObjectHistoryTableName,
                                          TableName.GEHistoryDetailsTableName,
                                          BOSList<GEHistoryDetailsInfo>.cstRelationForeign);
            HistoryDetailList.ItemTableForeignKey = "FK_GEObjectHistoryID";

            ReceiptItemLogList.InitBOSList(this,
                                          TableName.ICReceiptItemsTableName,
                                          TableName.ICReceiptItemLogsTableName,
                                          BOSList<ICReceiptItemLogsInfo>.cstRelationForeign);
            ReceiptItemLogList.ItemTableForeignKey = "FK_ICReceiptItemID";

            PurchaseOrderItemList.InitBOSList(this,
                                                 null,
                                                 TableName.APPurchaseOrderItemsTableName,
                                                 BOSList<APPurchaseOrderItemsInfo>.cstRelationNone);

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

            ReceiptItemContList.InitBOSList(this,
                                          TableName.ICReceiptsTableName,
                                          TableName.ICReceiptItemContsTableName,
                                          BOSList<ICReceiptItemContsInfo>.cstRelationForeign);
            ReceiptItemContList.ItemTableForeignKey = "FK_ICReceiptID";

            ReceiptItemContFeeList.InitBOSList(this,
                                          TableName.ICReceiptsTableName,
                                          TableName.ICReceiptItemContFeesTableName,
                                          BOSList<ICReceiptItemContFeesInfo>.cstRelationForeign);
            ReceiptItemContFeeList.ItemTableForeignKey = "FK_ICReceiptID";

        }

        public override void InitGridControlInBOSList()
        {
            ReceiptItemsList.InitBOSListGridControl();
            MultiPackageReceiptComponentItemsList.InitBOSListGridControl(PurchaseReceiptModule.MultiPackageReceiptItemGridControlName);
            MultiProductReceiptComponentItemsList.InitBOSListGridControl(PurchaseReceiptModule.MultiProductReceiptItemGridControlName);
            MultiReceiptComponentItemsList.InitBOSListGridControl(PurchaseReceiptModule.MultiReceiptItemGridControlName);
            HistoryDetailList.InitBOSListGridControl();
            ReceiptItemLogList.InitBOSListGridControl();
            DocumentEntryList.InitBOSListGridControl(PurchaseReceiptModule.DocumentEntryGridControlName);
            PurchaseOrderItemList.InitBOSListGridControl(PurchaseReceiptModule.APPurchaseOrderItemsGridControlName);
            ReceiptPackageItemList.InitBOSListGridControl("fld_dgcICReceiptPackageItems");
            ReceiptPackageItemDetailShowList.InitBOSListGridControl("fld_dgcICReceiptPackageItemDetails");
            ReceiptPackageItemDetailList.InitBOSListGridControl();
            ReceiptPackageItemDetailReportList.InitBOSListGridControl("fld_dgcICReceiptPackageItemDetails2");

            ReceiptItemContList.InitBOSListGridControl(PurchaseReceiptModule.ICReceiptItemContsControlName);
            ReceiptItemContFeeList.InitBOSListGridControl(PurchaseReceiptModule.ICReceiptItemContFeesControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ReceiptItemsList.SetDefaultListAndRefreshGridControl();
                MultiPackageReceiptComponentItemsList.SetDefaultListAndRefreshGridControl();
                MultiProductReceiptComponentItemsList.SetDefaultListAndRefreshGridControl();
                MultiReceiptComponentItemsList.SetDefaultListAndRefreshGridControl();
                ReceiptPackageItemList.SetDefaultListAndRefreshGridControl();
                ReceiptPackageItemDetailShowList.SetDefaultListAndRefreshGridControl();
                ReceiptPackageItemDetailList.SetDefaultListAndRefreshGridControl();
                DeleteReceiptPackageItemDetailList.SetDefaultListAndRefreshGridControl();
                ReceiptPackageItemDetailReportList.SetDefaultListAndRefreshGridControl();
                ReceiptItemContList.SetDefaultListAndRefreshGridControl();
                ReceiptItemContFeeList.SetDefaultListAndRefreshGridControl();

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
            objReceiptsInfo.ICReceiptDeliveryDate = DateTime.Now;
            objReceiptsInfo.ICReceiptValidateDate = DateTime.Now;
            objReceiptsInfo.ICReceiptInvoiceInDate = DateTime.Now;
            objReceiptsInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            objReceiptsInfo.ICReceiptTypeCombo = ReceiptType.PurchaseReceipt.ToString();
            objReceiptsInfo.ICReceiptStatus = ReceiptStatus.New.ToString();
            objReceiptsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objReceiptsInfo.ICReceiptExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objReceiptsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objReceiptsInfo.ICReceiptDesc = PurchaseReceiptLocalizedResources.PurchaseReceiptDefaultDesc;
            CountItemsInReceiptPackageItemList = 0;
            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects Functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            List<ICReceiptItemsInfo> receiptItems = objReceiptItemsController.GetItemsByReceiptID(iObjectID);
            receiptItems.ForEach(o =>
            {
                MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)objBatchProductsController.GetObjectByID(o.FK_MMBatchProductItemID);
                if (objBatchProductsInfo != null)
                {
                    o.ICReceiptItemSOName = objBatchProductsInfo.MMBatchProductSOName;
                }
            });
            receiptItems = receiptItems.OrderBy(item => item.Id).ToList();
            ReceiptItemsList.Invalidate(receiptItems);

            ICReceiptComponentItemsController objReceiptComponentItemsController = new ICReceiptComponentItemsController();
            List<ICReceiptComponentItemsInfo> receiptComponentItemList = objReceiptComponentItemsController.GetReceiptComponentItemByReceiptID(iObjectID);

            // Invalidate receipt item packages
            if (receiptComponentItemList.Count()> 0)
            {
                foreach (ICReceiptComponentItemsInfo objReceiptComponentItemsInfo in receiptComponentItemList)
                {
                    if (objReceiptComponentItemsInfo.ReceiptItemPackageList == null)
                    {
                        objReceiptComponentItemsInfo.ReceiptItemPackageList = new BOSList<ICReceiptItemPackagesInfo>();
                        objReceiptComponentItemsInfo.ReceiptItemPackageList.InitBOSList(
                                                            this,
                                                            TableName.ICReceiptComponentItemsTableName,
                                                            TableName.ICReceiptItemPackagesTableName,
                                                            BOSList<ICReceiptItemPackagesInfo>.cstRelationForeign);
                        objReceiptComponentItemsInfo.ReceiptItemPackageList.ItemTableForeignKey = "FK_ICReceiptComponentItemID";
                        objReceiptComponentItemsInfo.ReceiptItemPackageList.Invalidate(objReceiptComponentItemsInfo.ICReceiptComponentItemID);
                    }
                }

                //Invalidate multi package receipt item list
                List<ICReceiptComponentItemsInfo> multiPackageItemList = receiptComponentItemList.Where(i => i.ICReceiptComponentItemType == ReceiptItemType.MultiPackage.ToString()).ToList();
                MultiPackageReceiptComponentItemsList.InvalidateAndNotUpdateModuleObject(multiPackageItemList);
                MultiPackageReceiptComponentItemsList.GridView.RefreshData();

                //Invalidate multi product receipt item list
                List<ICReceiptComponentItemsInfo> multiProductItemList = receiptComponentItemList.Where(i => i.ICReceiptComponentItemType == ReceiptItemType.MultiProduct.ToString()).ToList();
                MultiProductReceiptComponentItemsList.InvalidateAndNotUpdateModuleObject(multiProductItemList);
                MultiProductReceiptComponentItemsList.GridView.RefreshData();

                //Invalidate multi receipt item list
                List<ICReceiptComponentItemsInfo> multiPackageProductItemList = receiptComponentItemList.Where(i => i.ICReceiptComponentItemType == ReceiptItemType.MultiPackageProduct.ToString()).ToList();
                MultiReceiptComponentItemsList.InvalidateAndNotUpdateModuleObject(multiPackageProductItemList);
                MultiReceiptComponentItemsList.GridView.RefreshData();
            }
            //Set receipt item id max
            //ReceiptItemIDMax = 0;
            //foreach (ICReceiptItemsInfo item in ReceiptItemsList)
            //{
            //    if (item.Id > ReceiptItemIDMax)
            //    {
            //        ReceiptItemIDMax = item.Id;
            //    }
            //}
            //OriginalReceiptItemIDMax = ReceiptItemIDMax;

            //Invalidate components
            InvalidateItemComponents();
            ReceiptItemContList.Invalidate(iObjectID);
            ReceiptItemContFeeList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects Functions

        public override void SaveModuleObjects()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            //foreach (ICReceiptItemsInfo itemEntity in ReceiptItemsList)
            //{
            //    itemEntity.OldReceiptItemID = itemEntity.Id;
            //    if (itemEntity.Id > OriginalReceiptItemIDMax)
            //        itemEntity.Id = 0;
            //}
            ReceiptItemsList.SaveItemObjects();

            ReceiptItemContList.SaveItemObjects();

            ReceiptItemContFeeList.SaveItemObjects();
            //Save receipt component item list
            foreach (ICReceiptComponentItemsInfo objReceiptComponentItemsInfo in MultiPackageReceiptComponentItemsList)
            {
                ICReceiptItemsInfo item = ReceiptItemsList.Where(i => i.OldReceiptItemID == objReceiptComponentItemsInfo.FK_ICReceiptItemID).FirstOrDefault();
                if (item != null)
                {
                    objReceiptComponentItemsInfo.FK_ICReceiptItemID = item.Id;
                }

            }
            MultiPackageReceiptComponentItemsList.SaveItemObjects();

            foreach (ICReceiptComponentItemsInfo objReceiptComponentItemsInfo in MultiProductReceiptComponentItemsList)
            {
                ICReceiptItemsInfo item = ReceiptItemsList.Where(i => i.OldReceiptItemID == objReceiptComponentItemsInfo.FK_ICReceiptItemID).FirstOrDefault();
                if (item != null)
                {
                    objReceiptComponentItemsInfo.FK_ICReceiptItemID = item.Id;
                }

            }
            MultiProductReceiptComponentItemsList.SaveItemObjects();

            foreach (ICReceiptComponentItemsInfo objReceiptComponentItemsInfo in MultiReceiptComponentItemsList)
            {
                ICReceiptItemsInfo item = ReceiptItemsList.Where(i => i.OldReceiptItemID == objReceiptComponentItemsInfo.FK_ICReceiptItemID).FirstOrDefault();
                if (item != null)
                {
                    objReceiptComponentItemsInfo.FK_ICReceiptItemID = item.Id;
                }

            }
            MultiReceiptComponentItemsList.SaveItemObjects();

            #region Save receipt item package list
            //Multi package receipt item list
            foreach (ICReceiptComponentItemsInfo objReceiptComponentItemsInfo in MultiPackageReceiptComponentItemsList)
            {
                if (objReceiptComponentItemsInfo.ReceiptItemPackageList != null)
                {
                    foreach (ICReceiptItemPackagesInfo objReceiptItemPackagesInfo in objReceiptComponentItemsInfo.ReceiptItemPackageList)
                    {
                        objReceiptItemPackagesInfo.FK_ICReceiptComponentItemID = objReceiptComponentItemsInfo.ICReceiptComponentItemID;
                    }
                    objReceiptComponentItemsInfo.ReceiptItemPackageList.SaveItemObjects();
                }
            }

            //Multi receipt item list
            foreach (ICReceiptComponentItemsInfo objReceiptComponentItemsInfo in MultiReceiptComponentItemsList)
            {
                if (objReceiptComponentItemsInfo.ReceiptItemPackageList != null)
                {
                    foreach (ICReceiptItemPackagesInfo objReceiptItemPackagesInfo in objReceiptComponentItemsInfo.ReceiptItemPackageList)
                    {
                        objReceiptItemPackagesInfo.FK_ICReceiptComponentItemID = objReceiptComponentItemsInfo.ICReceiptComponentItemID;
                    }
                    objReceiptComponentItemsInfo.ReceiptItemPackageList.SaveItemObjects();
                }
            }
            #endregion

            //SaveAccountingData();

        }

        /// <summary>
        /// Save receipt item log
        /// </summary>
        /// <param name="objectHistoryID">History id</param>
        /// <param name="originalItems">Original items before saving</param>
        public void SaveReceiptItemLog(int objectHistoryID, List<ICReceiptItemsInfo> originalItems)
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            ICReceiptItemLogsController objReceiptItemLogsController = new ICReceiptItemLogsController();
            BOSDbUtil dbUtil = new BOSDbUtil();
            PropertyInfo[] props = typeof(ICReceiptItemsInfo).GetProperties();
            foreach (ICReceiptItemsInfo originalItem in originalItems)
            {
                //In case the item is changed
                if (ReceiptItemsList.Exists("Id", originalItem.Id))
                {
                    ICReceiptItemsInfo item = ReceiptItemsList.First(i => i.Id == originalItem.Id);
                    foreach (PropertyInfo prop in props)
                    {
                        if (!prop.Name.StartsWith("AA"))
                        {
                            object oldValue = dbUtil.GetPropertyValue(originalItem, prop.Name);
                            object newValue = dbUtil.GetPropertyValue(item, prop.Name);
                            if (oldValue != null && newValue != null)
                            {
                                if (!newValue.Equals(oldValue))
                                {
                                    ICReceiptItemLogsInfo objReceiptItemLogsInfo = new ICReceiptItemLogsInfo();
                                    objReceiptItemLogsInfo.FK_ICReceiptID = objReceiptsInfo.ICReceiptID;
                                    objReceiptItemLogsInfo.ICReceiptItemLogColumnName = prop.Name;
                                    objReceiptItemLogsInfo.FK_GEObjectHistoryID = objectHistoryID;
                                    objReceiptItemLogsInfo.FK_ICReceiptItemID = originalItem.Id;
                                    objReceiptItemLogsInfo.ICObjectHistoryAction = ObjectHistoryAction.Change.ToString();
                                    objReceiptItemLogsInfo.ICReceiptItemLogOldValue = Convert.ToString(oldValue);
                                    objReceiptItemLogsInfo.ICReceiptItemLogNewValue = Convert.ToString(newValue);
                                    objReceiptItemLogsController.CreateObject(objReceiptItemLogsInfo);
                                }
                            }
                        }
                    }

                }
                //In case the item is removed
                else
                {
                    ICReceiptItemLogsInfo objReceiptItemLogsInfo = new ICReceiptItemLogsInfo();
                    objReceiptItemLogsInfo.FK_ICReceiptID = objReceiptsInfo.ICReceiptID;
                    objReceiptItemLogsInfo.ICReceiptItemLogColumnName = "ICReceiptItemProductQty";
                    objReceiptItemLogsInfo.FK_GEObjectHistoryID = objectHistoryID;
                    objReceiptItemLogsInfo.FK_ICReceiptItemID = originalItem.Id;
                    objReceiptItemLogsInfo.ICObjectHistoryAction = ObjectHistoryAction.Delete.ToString();
                    objReceiptItemLogsInfo.ICReceiptItemLogOldValue = originalItem.ICReceiptItemProductQty.ToString();
                    objReceiptItemLogsInfo.ICReceiptItemLogNewValue = String.Empty;
                    objReceiptItemLogsController.CreateObject(objReceiptItemLogsInfo);
                }
            }

            foreach (ICReceiptItemsInfo itemEntity in ReceiptItemsList)
            {
                //In case the item is created
                ICReceiptItemsInfo foundItem = originalItems.FirstOrDefault(item => item.Id == itemEntity.Id);
                if (foundItem == null)
                {
                    ICReceiptItemLogsInfo objReceiptItemLogsInfo = new ICReceiptItemLogsInfo();
                    objReceiptItemLogsInfo.FK_ICReceiptID = objReceiptsInfo.ICReceiptID;
                    objReceiptItemLogsInfo.ICReceiptItemLogColumnName = "ICReceiptItemProductQty";
                    objReceiptItemLogsInfo.FK_GEObjectHistoryID = objectHistoryID;
                    objReceiptItemLogsInfo.FK_ICReceiptItemID = itemEntity.Id;
                    objReceiptItemLogsInfo.ICObjectHistoryAction = ObjectHistoryAction.Create.ToString();
                    objReceiptItemLogsInfo.ICReceiptItemLogOldValue = String.Empty;
                    objReceiptItemLogsInfo.ICReceiptItemLogNewValue = itemEntity.ICReceiptItemProductQty.ToString();
                    objReceiptItemLogsController.CreateObject(objReceiptItemLogsInfo);
                }
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
            objReceiptsInfo.ICReceiptDiscountFix = objReceiptsInfo.ICReceiptSubTotalCost * objReceiptsInfo.ICReceiptDiscountPerCent / 100;
            BOSApp.RoundByCurrency(objReceiptsInfo, "ICReceiptDiscountFix", objReceiptsInfo.FK_GECurrencyID);

            objReceiptsInfo.ICReceiptTaxAmount = (objReceiptsInfo.ICReceiptSubTotalCost -
                                                 objReceiptsInfo.ICReceiptDiscountFix +
                                                 objReceiptsInfo.ICReceiptShippingFees +
                                                 objReceiptsInfo.ICReceiptShippingExtraFees) * objReceiptsInfo.ICReceiptTaxPercent / 100;
            BOSApp.RoundByCurrency(objReceiptsInfo, "ICReceiptTaxAmount", objReceiptsInfo.FK_GECurrencyID);

            objReceiptsInfo.ICReceiptTotalCost = objReceiptsInfo.ICReceiptSubTotalCost +
                                                 objReceiptsInfo.ICReceiptTaxAmount +
                                                 objReceiptsInfo.ICReceiptShippingFees +
                                                 objReceiptsInfo.ICReceiptShippingExtraFees -
                                                 objReceiptsInfo.ICReceiptDiscountFix;
            BOSApp.RoundByCurrency(objReceiptsInfo, "ICReceiptTotalCost", objReceiptsInfo.FK_GECurrencyID);

            BOSApp.RoundByCurrency(objReceiptsInfo, objReceiptsInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }
        public void UpdateReferencePurchaseOrder()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
            APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();

            if (objReceiptsInfo.ICReceiptCreateFrom == "PurchaseOrder")
            {
                ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
                List<string> OrderItemListID = ReceiptItemsList.Where(r => r.FK_APPurchaseOrderItemID > 0).Select(o => o.FK_APPurchaseOrderItemID.ToString()).Distinct().ToList();
                List<APPurchaseOrderItemsInfo> purchaseOrderItemList = objPurchaseOrderItemsController.GetPurchaseOrderItemsByListItemID(string.Join(",", OrderItemListID.ToArray()));
                List<ICReceiptItemsInfo> receiptedItemList = objReceiptItemsController.GetTotalReceiptItemQtyByPurchaseOrderItemListID(string.Join(",", OrderItemListID.ToArray()));
                if (purchaseOrderItemList != null && receiptedItemList != null)
                {
                    foreach (ICReceiptItemsInfo receiptItem in ReceiptItemsList)
                    {
                        APPurchaseOrderItemsInfo purchaseOrderItem = purchaseOrderItemList.Where(po => po.APPurchaseOrderItemID == receiptItem.FK_APPurchaseOrderItemID).FirstOrDefault();
                        if (purchaseOrderItem != null)
                        {
                            if (purchaseOrderItem.APPurchaseOrderItemProductQty >= purchaseOrderItem.APPurchaseOrderItemReceiptedQty)
                                purchaseOrderItem.APPurchaseOrderItemRemainedQty = purchaseOrderItem.APPurchaseOrderItemProductQty - purchaseOrderItem.APPurchaseOrderItemReceiptedQty;
                            List<ICReceiptItemsInfo> receiptedList = receiptedItemList.Where(r => r.FK_APPurchaseOrderItemID == receiptItem.FK_APPurchaseOrderItemID).ToList();

                            decimal receiptedTotalQty = receiptedList != null ? receiptedList.Sum(x => x.ICReceiptItemProductExchangeQty) : 0;
                            // decimal receiptedTotalBlock = receiptedItemList.Sum(x => x.ICReceiptItemProductBlock);
                            if (purchaseOrderItem != null)
                            {
                                purchaseOrderItem.APPurchaseOrderItemReceiptedQty = receiptedTotalQty;
                                purchaseOrderItem.APPurchaseOrderItemRemainedQty = purchaseOrderItem.APPurchaseOrderItemProductQty - purchaseOrderItem.APPurchaseOrderItemReceiptedQty;

                                //objPurchaseOrderItemsController.UpdateObject(purchaseOrderItem);
                                objPurchaseOrderItemsController.UpdatePurchaseReceiptQty(purchaseOrderItem.APPurchaseOrderItemID, purchaseOrderItem.APPurchaseOrderItemReceiptedQty);
                            }
                        }
                    }
                }
                //Update purchase order's status
                List<string> OrderListID = purchaseOrderItemList.Where(p => p.FK_APPurchaseOrderID > 0).Select(p => p.FK_APPurchaseOrderID.ToString()).Distinct().ToList();
                if (OrderListID != null && OrderListID.Count > 0)
                    objPurchaseOrdersController.UpdatePurchaseOrderStatus(string.Join(",", OrderListID.ToArray())
                                                                        , BOSApp.CurrentUsersInfo.ADUserName);
            }
        }
        public override bool CompleteTransaction()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            //Update status of stock receipt
            objReceiptsInfo.ICReceiptStatus = ReceiptStatus.Complete.ToString();
            UpdateMainObject();
            ////                Move out transaction                    /////
            //Update the reference invoice
            //if (!string.IsNullOrEmpty(objReceiptsInfo.ICReceiptReference))
            //{
            //    if (objReceiptsInfo.FK_APPurchaseOrderID == 0)
            //        UpdateReferenceInvoice();
            //    else
            //        UpdateReferencePurchaseOrder();
            //}
            ////                Move out transaction                    /////
            //bool isWoodType = BOSApp.IsWoodTypeDocument(objReceiptsInfo.ICReceiptReceiptType, ReceiptItemsList.FirstOrDefault());
            //foreach (ICReceiptItemsInfo item in ReceiptItemsList)
            //{
            //    if (item.ICReceiptItemLotNo.Trim() == string.Empty && isWoodType)
            //    {
            //        item.ICReceiptItemLotNo = objReceiptsInfo.ICReceiptPackNo;
            //    }
            //    if (item.ICReceiptItemProductSerialNo.Trim() == string.Empty && !isWoodType)
            //    {
            //        item.ICReceiptItemProductSerialNo = objReceiptsInfo.ICReceiptPackNo;
            //    }
            //}
            ////Generate product series
            //ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            //foreach (ICReceiptItemsInfo item in ReceiptItemsList)
            //{
            //    if (!string.IsNullOrEmpty(objReceiptsInfo.ICReceiptPackNo))
            //    {
            //        ICProductSeriesInfo objProductSeriesInfo = new ICProductSeriesInfo();
            //        objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.ICReceiptItemProductSerialNo);
            //        if (objProductSeriesInfo == null)
            //        {
            //            objProductSeriesInfo = new ICProductSeriesInfo();
            //            objProductSeriesInfo.AACreatedDate = DateTime.Now;
            //            objProductSeriesInfo.FK_ICProductID = item.FK_ICProductID;
            //            objProductSeriesInfo.ICProductSerieNo = item.ICReceiptItemProductSerialNo;
            //            objProductSeriesInfo.ICProductSerieLotNo = item.ICReceiptItemLotNo;
            //            objProductSeriesInfo.ICProductSerieReceiptDate = objReceiptsInfo.ICReceiptDate;
            //            objProductSeriesInfo.ICProductSerieProductDesc = item.ICReceiptItemProductDesc;
            //            objProductSeriesInfo.ICProductSerieProductHeight = item.ICReceiptItemProductHeight;
            //            objProductSeriesInfo.ICProductSerieProductWidth = item.ICReceiptItemProductWidth;
            //            objProductSeriesInfo.ICProductSerieProductLength = item.ICReceiptItemProductLength;
            //            objProductSeriesInfo.ICProductSerieProductPerimeter = item.ICReceiptItemProductPerimeter;
            //            objProductSeriesInfo.FK_ICModelID = item.FK_ICModelID;
            //            objProductSeriesInfo.FK_ICModelDetailID = item.FK_ICModelDetailID;
            //            objProductSeriesController.CreateObject(objProductSeriesInfo);
            //        }
            //        item.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
            //    }
            //}
            //ReceiptItemsList.SaveItemObjects();

            ////                Move out transaction                    /////
            //UpdateModuleObjectsBindingSource();

            //UpdatePurchaseOrdersStatus();
            ////                Move out transaction                    /////
            return true;
        }
        public override bool CancelCompleteTransaction()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            if (objReceiptsInfo.ICReceiptStatus == SaleOrderStatus.Complete.ToString())
            {
                objReceiptsInfo.ICReceiptStatus = SaleOrderStatus.New.ToString();
                objReceiptsInfo.ICReceiptPostedStatus = SaleOrderStatus.New.ToString();
                SaveMainObject();
            }
            return true;
        }
        public void UpdatePurchaseOrdersStatus()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
            List<APPurchaseOrderItemsInfo> purchaseOrderItemsList = new List<APPurchaseOrderItemsInfo>();
            APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
            APPurchaseOrdersInfo objPurchaseOrdersInfo = new APPurchaseOrdersInfo();
            int[] purchaseOrderIDs = ReceiptItemsList.Select(o => o.FK_APPurchaseOrderID).Distinct().ToArray();
            decimal countProductQty = 0;
            foreach (int objectID in purchaseOrderIDs)
            {
                purchaseOrderItemsList = objPurchaseOrderItemsController.GetPurchaseOrderItemAndReceiptQty(objectID);
                objPurchaseOrdersInfo = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByID(objectID);
                if (objPurchaseOrdersInfo != null)
                {
                    purchaseOrderItemsList.ForEach(o =>
                    {
                        countProductQty += (o.APPurchaseOrderItemProductQty - o.ICReceiptedQty) < 0 ? 0 : (o.APPurchaseOrderItemProductQty - o.ICReceiptedQty);
                    });
                    if (countProductQty > 0)
                    {
                        objPurchaseOrdersInfo.APPurchaseOrderStatus = PurchaseOrderStatus.Incompleted.ToString();
                    }
                    else
                    {
                        objPurchaseOrdersInfo.APPurchaseOrderStatus = PurchaseOrderStatus.Completed.ToString();
                    }
                    objPurchaseOrdersController.UpdateObject(objPurchaseOrdersInfo);
                }
            }
        }

        /// <summary>
        /// Update the reference invoice that the receipt has been created from
        /// </summary>
        public void UpdateReferenceInvoice()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            APInvoiceInsController objInvoicesController = new APInvoiceInsController();
            if (string.IsNullOrEmpty(objReceiptsInfo.ICReceiptReference)) return;
            APInvoiceInsInfo invoice = (APInvoiceInsInfo)objInvoicesController.GetObjectByNo(objReceiptsInfo.ICReceiptReference);
            if (invoice != null)
            {
                APInvoiceInItemsController objInvoiceInItemsController = new APInvoiceInItemsController();
                List<APInvoiceInItemsInfo> invoiceItems = objInvoiceInItemsController.GetComponentItemsByInvoiceInID(invoice.APInvoiceInID);
                invoiceItems.ForEach(i => i.APInvoiceInItemRemainedQty = i.APInvoiceInItemProductQty - i.APInvoiceInItemReceiptedQty);

                APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
                APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
                List<APPurchaseOrdersInfo> purchaseOrders = new List<APPurchaseOrdersInfo>();
                List<APPurchaseOrderItemsInfo> allPurchaseOrderItems = new List<APPurchaseOrderItemsInfo>();
                string[] purchaseOrderNos = invoice.APInvoiceInReference.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < purchaseOrderNos.Length; i++)
                {
                    string purchaseOrderNo = purchaseOrderNos[i].Trim();
                    APPurchaseOrdersInfo purchaseOrder = purchaseOrders.Where(po => po.APPurchaseOrderNo == purchaseOrderNo).FirstOrDefault();
                    if (purchaseOrder == null)
                    {
                        purchaseOrder = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByNo(purchaseOrderNo);
                        if (purchaseOrder != null)
                        {
                            purchaseOrders.Add(purchaseOrder);
                            List<APPurchaseOrderItemsInfo> purchaseOrderItems = objPurchaseOrderItemsController.GetComponentItemsByPurchaseOrderID(purchaseOrder.APPurchaseOrderID);
                            allPurchaseOrderItems.AddRange(purchaseOrderItems);
                        }
                    }
                }
                allPurchaseOrderItems.ForEach(i => i.APPurchaseOrderItemRemainedQty = i.APPurchaseOrderItemProductQty - i.APPurchaseOrderItemReceiptedQty - i.APPurchaseOrderItemProductCanceledQty);

                foreach (ICReceiptItemsInfo receiptItem in ComponentReceiptItemList)
                {
                    decimal receiptItemQty = receiptItem.ICReceiptItemProductQty;
                    while (receiptItemQty > 0)
                    {
                        APInvoiceInItemsInfo invoiceItem = invoiceItems.Where(i => i.FK_ICProductID == receiptItem.FK_ICProductID &&
                                                                                i.APInvoiceInItemRemainedQty > 0).FirstOrDefault();
                        decimal invoiceItemReceiptedQty = 0;
                        if (invoiceItem != null)
                        {
                            invoiceItemReceiptedQty = Math.Min(receiptItemQty, invoiceItem.APInvoiceInItemRemainedQty);
                        }
                        else
                        {
                            invoiceItem = invoiceItems.Where(i => i.FK_ICProductID == receiptItem.FK_ICProductID).FirstOrDefault();
                            invoiceItemReceiptedQty = receiptItemQty;
                        }

                        if (invoiceItem != null)
                        {
                            invoiceItem.APInvoiceInItemReceiptedQty += invoiceItemReceiptedQty;
                            invoiceItem.APInvoiceInItemRemainedQty = invoiceItem.APInvoiceInItemProductQty - invoiceItem.APInvoiceInItemReceiptedQty;
                            if (!invoiceItem.IsSubItem)
                            {
                                objInvoiceInItemsController.UpdateReceiptedQty(invoiceItem.APInvoiceInItemID, invoiceItem.APInvoiceInItemReceiptedQty);
                            }

                            APPurchaseOrderItemsInfo purchaseOrderItem = allPurchaseOrderItems.Where(i => i.FK_ICProductID == invoiceItem.FK_ICProductID &&
                                                                                                    i.APPurchaseOrderItemRemainedQty > 0).FirstOrDefault();
                            decimal purchaseOrderItemReceiptedQty = 0;
                            if (purchaseOrderItem != null)
                            {
                                purchaseOrderItemReceiptedQty = Math.Min(receiptItemQty, purchaseOrderItem.APPurchaseOrderItemRemainedQty);
                            }
                            else
                            {
                                purchaseOrderItem = allPurchaseOrderItems.Where(i => i.FK_ICProductID == invoiceItem.FK_ICProductID).FirstOrDefault();
                                purchaseOrderItemReceiptedQty = receiptItemQty;
                            }

                            if (purchaseOrderItem != null)
                            {
                                purchaseOrderItem.APPurchaseOrderItemReceiptedQty += purchaseOrderItemReceiptedQty;
                                purchaseOrderItem.APPurchaseOrderItemRemainedQty = purchaseOrderItem.APPurchaseOrderItemProductQty - purchaseOrderItem.APPurchaseOrderItemReceiptedQty - purchaseOrderItem.APPurchaseOrderItemProductCanceledQty;
                                if (!purchaseOrderItem.IsSubItem)
                                {
                                    objPurchaseOrderItemsController.UpdateReceiptedQty(purchaseOrderItem.APPurchaseOrderItemID, purchaseOrderItem.APPurchaseOrderItemReceiptedQty);
                                }
                            }
                        }
                        else
                        {
                            break;
                        }

                        receiptItemQty -= invoiceItemReceiptedQty;
                    }
                }

                //Update invoice status
                bool isRemained = false;
                foreach (APInvoiceInItemsInfo invoiceItem in invoiceItems)
                {
                    if (invoiceItem.APInvoiceInItemRemainedQty > 0)
                    {
                        isRemained = true;
                        break;
                    }
                }

                if (isRemained)
                {
                    invoice.APInvoiceInStatus = InvoiceInStatus.Incompleted.ToString();
                    objInvoicesController.UpdateObject(invoice);
                }
                else
                {
                    invoice.APInvoiceInStatus = InvoiceInStatus.Completed.ToString();
                    objInvoicesController.UpdateObject(invoice);
                }

                //Update purchase order's status
                foreach (APPurchaseOrdersInfo purchaseOrder in purchaseOrders)
                {
                    isRemained = false;
                    foreach (APPurchaseOrderItemsInfo purchaseOrderItem in allPurchaseOrderItems)
                    {
                        if (purchaseOrderItem.FK_APPurchaseOrderID == purchaseOrder.APPurchaseOrderID && purchaseOrderItem.APPurchaseOrderItemRemainedQty > 0)
                        {
                            isRemained = true;
                            break;
                        }
                    }

                    if (!isRemained)
                    {
                        purchaseOrder.APPurchaseOrderStatus = PurchaseOrderStatus.Completed.ToString();
                        objPurchaseOrdersController.UpdateObject(purchaseOrder);
                    }
                    else
                    {
                        purchaseOrder.APPurchaseOrderStatus = PurchaseOrderStatus.Incompleted.ToString();
                        objPurchaseOrdersController.UpdateObject(purchaseOrder);
                    }
                }
            }
        }

        public APInvoiceInsInfo GenerateInvoiceInFromReceipt(ICReceiptsInfo objReceiptsInfo)
        {
            APInvoiceInsInfo objInvoiceInsInfo = new APInvoiceInsInfo();
            BOSUtil.CopyObject(objReceiptsInfo, objInvoiceInsInfo);

            //Set own properties of InvoiceIn
            objInvoiceInsInfo.AACreatedUser = BOSApp.CurrentUser;
            objInvoiceInsInfo.AACreatedDate = DateTime.Now;
            objInvoiceInsInfo.APInvoiceInType = InvoiceInType.PurchaseReceipt.ToString();
            objInvoiceInsInfo.APInvoiceInReference = objReceiptsInfo.ICReceiptNo;
            objInvoiceInsInfo.APInvoiceInSupplierNo = objReceiptsInfo.ICReceiptInvoiceInNo;
            objInvoiceInsInfo.APInvoiceInStatus = InvoiceInStatus.Completed.ToString();
            objInvoiceInsInfo.APInvoiceInBalanceDue = objInvoiceInsInfo.APInvoiceInTotalCost;
            return objInvoiceInsInfo;
        }

        public void GenerateInvoiceInItemsFromReceiptItems(int invoiceInID)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            APInvoiceInItemsController objInvoiceInItemsController = new APInvoiceInItemsController();
            foreach (ICReceiptItemsInfo item in ReceiptItemsList)
            {
                APInvoiceInItemsInfo objInvoiceInItemsInfo = new APInvoiceInItemsInfo();
                ICReceiptItemsInfo objReceiptItemsInfo = (ICReceiptItemsInfo)item.Clone();
                BOSUtil.CopyObject(objReceiptItemsInfo, objInvoiceInItemsInfo);
                objInvoiceInItemsInfo.FK_APInvoiceInID = invoiceInID;
                objInvoiceInItemsController.CreateObject(objInvoiceInItemsInfo);
            }
        }

        /// <summary>
        /// Generate package from receipt items
        /// </summary>        
        /// <returns>True if genarate successful</returns>
        public bool GeneratePackageFromReceipt()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            ICPackagesController objPackagesController = new ICPackagesController();
            ICPackageProductsController objPackageProductsController = new ICPackageProductsController();
            ICPackageProductsInfo objPackageProductsInfo = new ICPackageProductsInfo();
            ICProductsController objProductsController = new ICProductsController();
            ICReceiptItemPackagesController objReceiptItemPackagesController = new ICReceiptItemPackagesController();

            //Rollback package
            objPackagesController.DeletePackagesBySupplierIDAndPackNo(objReceiptsInfo.FK_APSupplierID, objReceiptsInfo.ICReceiptPackNo);

            //Crate package
            ICPackagesInfo objPackagesInfo = new ICPackagesInfo();
            objPackagesInfo.FK_APSupplierID = objReceiptsInfo.FK_APSupplierID;
            objPackagesInfo.ICPackagePackNo = objReceiptsInfo.ICReceiptPackNo;
            objPackagesInfo.ICPackageReceiptDate = objReceiptsInfo.ICReceiptDate;
            string firstNo = objPackagesInfo.ICPackageReceiptDate.ToString("ddMMyy");
            ICPackageNumbersController objPackageNumbersController = new ICPackageNumbersController();
            ICPackageNumbersInfo objPackageNumbersInfo = (ICPackageNumbersInfo)objPackageNumbersController.GetPackageNumberByPackageNumberDate(objPackagesInfo.ICPackageReceiptDate);
            if (objPackageNumbersInfo == null)
            {
                objPackageNumbersInfo = new ICPackageNumbersInfo();
                objPackageNumbersInfo.ICPackageNumberDate = objPackagesInfo.ICPackageReceiptDate;
                objPackageNumbersInfo.ICPackageNumberStart = 0;
                objPackageNumbersController.CreateObject(objPackageNumbersInfo);
            }

            //initializa default value
            int receiptItemPackageIndex = 0;
            decimal preItemReceiptPackageQty = 0;
            decimal nextItemReceiptPackageQty = 0;

            #region A product more package
            foreach (ICReceiptComponentItemsInfo objReceiptComponentItemsInfo in MultiPackageReceiptComponentItemsList)
            {
                if (objReceiptComponentItemsInfo.ICReceiptComponentItemPackageQty > 0)
                {
                    //Get receipt item package list
                    List<ICReceiptItemPackagesInfo> receiptItemPackageList = objReceiptItemPackagesController.GetReceiptItemPackageByReceiptComponentItemID(objReceiptComponentItemsInfo.ICReceiptComponentItemID);
                    objPackagesInfo.ICPackageCount = objReceiptComponentItemsInfo.ICReceiptComponentItemPackageQty;
                    objPackagesInfo.ICPackageProductCount = 1;
                    if (receiptItemPackageList != null && receiptItemPackageList.Count > 0)
                    {
                        nextItemReceiptPackageQty = receiptItemPackageList[0].ICReceiptItemPackageQty;
                    }

                    if (objReceiptComponentItemsInfo.ICReceiptComponentItemProductQty > 0)
                    {
                        int middleNoMax = objPackageNumbersInfo.ICPackageNumberStart;
                        for (int numProduct = 1; numProduct <= Convert.ToInt32(objReceiptComponentItemsInfo.ICReceiptComponentItemProductQty); numProduct++)
                        {
                            middleNoMax += 1;
                            for (int numPackage = 1; numPackage <= objPackagesInfo.ICPackageCount; numPackage++)
                            {
                                //Generate package
                                objPackagesInfo.ICPackageNo = String.Format("{0}{1}{2}", firstNo, middleNoMax.ToString("0000"), numPackage.ToString("00"));
                                objPackagesInfo.ICPackageOrder = numPackage;
                                objPackagesInfo.ICProductSupplierNo = objReceiptComponentItemsInfo.ICReceiptComponentItemProductSupplierNo;
                                objPackagesInfo.ICProductDesc = objReceiptComponentItemsInfo.ICReceiptComponentItemProductDesc;
                                //Generate supplier package no
                                if (receiptItemPackageList != null && receiptItemPackageList.Count > 0)
                                {
                                    if (numPackage > preItemReceiptPackageQty + nextItemReceiptPackageQty)
                                    {
                                        receiptItemPackageIndex += 1;
                                        preItemReceiptPackageQty = nextItemReceiptPackageQty;
                                        nextItemReceiptPackageQty = receiptItemPackageList[receiptItemPackageIndex].ICReceiptItemPackageQty;
                                    }
                                    objPackagesInfo.ICPackageSupplierNo = receiptItemPackageList[receiptItemPackageIndex].ICReceiptItemPackageSupplierNo;
                                }
                                objPackagesController.CreateObject(objPackagesInfo);

                                //Generate package product
                                objPackageProductsInfo.FK_ICPackageID = objPackagesInfo.ICPackageID;
                                objPackageProductsInfo.FK_ICProductID = objReceiptComponentItemsInfo.FK_ICProductID;
                                objPackageProductsInfo.ICPackageProductQty = 1;
                                objPackageProductsController.CreateObject(objPackageProductsInfo);
                            }

                            //Reset value
                            receiptItemPackageIndex = 0;
                            nextItemReceiptPackageQty = preItemReceiptPackageQty;
                            preItemReceiptPackageQty = 0;
                        }

                        //Update package number start
                        objPackageNumbersInfo.ICPackageNumberStart = middleNoMax;
                        objPackageNumbersController.UpdateObject(objPackageNumbersInfo);
                    }
                }
            }
            #endregion

            #region A Package more product
            for (int i = 0; i < MultiProductReceiptComponentItemsList.Count; i++)
            {
                int startIndex = 0;
                if (MultiProductReceiptComponentItemsList[i].IsPackageGroup)
                {
                    //Create package
                    objPackagesInfo.ICPackageCount = 1;
                    decimal packageProductCount = 0;
                    int middleNoMax = objPackageNumbersInfo.ICPackageNumberStart + 1;
                    int numPackage = 1;
                    objPackagesInfo.ICPackageNo = String.Format("{0}{1}{2}", firstNo, middleNoMax.ToString("0000"), numPackage.ToString("00"));
                    objPackagesInfo.ICPackageOrder = 1;
                    packageProductCount += MultiProductReceiptComponentItemsList[i].ICReceiptComponentItemProductQty;
                    string productSupplierNoString = MultiProductReceiptComponentItemsList[i].ICReceiptComponentItemProductSupplierNo;
                    string productDescString = MultiProductReceiptComponentItemsList[i].ICReceiptComponentItemProductDesc;
                    for (int j = i + 1; j < MultiProductReceiptComponentItemsList.Count; j++)
                    {
                        startIndex = j;
                        if (!MultiProductReceiptComponentItemsList[j].IsPackageGroup)
                        {
                            packageProductCount += MultiProductReceiptComponentItemsList[j].ICReceiptComponentItemProductQty;
                            string productSupplierNo = MultiProductReceiptComponentItemsList[j].ICReceiptComponentItemProductSupplierNo;
                            if (!String.IsNullOrEmpty(productSupplierNo) && !productSupplierNoString.Contains(productSupplierNo))
                                productSupplierNoString += String.Format("; {0}", productSupplierNo);
                            if (!String.IsNullOrEmpty(MultiProductReceiptComponentItemsList[j].ICReceiptComponentItemProductDesc))
                                productDescString += String.Format("; {0}", MultiProductReceiptComponentItemsList[j].ICReceiptComponentItemProductDesc);
                        }
                        else
                            break;
                    }
                    objPackagesInfo.ICPackageSupplierNo = string.Empty;
                    objPackagesInfo.ICPackageProductCount = packageProductCount;
                    objPackagesInfo.ICProductSupplierNo = productSupplierNoString;
                    objPackagesInfo.ICProductDesc = productDescString;
                    objPackagesController.CreateObject(objPackagesInfo);

                    //Create product package
                    objPackageProductsInfo.FK_ICPackageID = objPackagesInfo.ICPackageID;
                    objPackageProductsInfo.FK_ICProductID = MultiProductReceiptComponentItemsList[i].FK_ICProductID;
                    objPackageProductsInfo.ICPackageProductQty = MultiProductReceiptComponentItemsList[i].ICReceiptComponentItemProductQty;
                    objPackageProductsController.CreateObject(objPackageProductsInfo);
                    for (int j = i + 1; j < MultiProductReceiptComponentItemsList.Count; j++)
                    {
                        if (!MultiProductReceiptComponentItemsList[j].IsPackageGroup)
                        {
                            objPackageProductsInfo.FK_ICPackageID = objPackagesInfo.ICPackageID;
                            objPackageProductsInfo.FK_ICProductID = MultiProductReceiptComponentItemsList[j].FK_ICProductID;
                            objPackageProductsInfo.ICPackageProductQty = MultiProductReceiptComponentItemsList[j].ICReceiptComponentItemProductQty;
                            objPackageProductsController.CreateObject(objPackageProductsInfo);
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (startIndex > i)
                    {
                        i = startIndex - 1;
                    }
                    //Update package number start
                    objPackageNumbersInfo.ICPackageNumberStart = middleNoMax;
                    objPackageNumbersController.UpdateObject(objPackageNumbersInfo);
                }
            }
            #endregion

            #region More package more product
            for (int i = 0; i < MultiReceiptComponentItemsList.Count; i++)
            {
                int middleNoMax = objPackageNumbersInfo.ICPackageNumberStart + 1;
                int startIndex = 0;
                if (MultiReceiptComponentItemsList[i].IsPackageGroup)
                {
                    //Create package
                    for (int numPackage = 1; numPackage <= Convert.ToInt32(MultiReceiptComponentItemsList[i].ICReceiptComponentItemPackageQty); numPackage++)
                    {
                        //Get receipt item package list
                        List<ICReceiptItemPackagesInfo> receiptItemPackageList = objReceiptItemPackagesController.GetReceiptItemPackageByReceiptComponentItemID(MultiReceiptComponentItemsList[i].ICReceiptComponentItemID);
                        //initializa default value
                        if (receiptItemPackageList != null && receiptItemPackageList.Count > 0)
                        {
                            nextItemReceiptPackageQty = receiptItemPackageList[0].ICReceiptItemPackageQty;
                        }

                        //Create package
                        objPackagesInfo.ICPackageCount = MultiReceiptComponentItemsList[i].ICReceiptComponentItemPackageQty;
                        decimal packageProductCount = 0;
                        objPackagesInfo.ICPackageNo = String.Format("{0}{1}{2}", firstNo, middleNoMax.ToString("0000"), numPackage.ToString("00"));
                        objPackagesInfo.ICPackageOrder = numPackage;
                        packageProductCount += MultiReceiptComponentItemsList[i].ICReceiptComponentItemProductQty;
                        string productSupplierNoString = MultiReceiptComponentItemsList[i].ICReceiptComponentItemProductSupplierNo;
                        string productDescString = MultiReceiptComponentItemsList[i].ICReceiptComponentItemProductDesc;
                        for (int j = i + 1; j < MultiReceiptComponentItemsList.Count; j++)
                        {
                            startIndex = j;
                            if (!MultiReceiptComponentItemsList[j].IsPackageGroup)
                            {
                                packageProductCount += MultiReceiptComponentItemsList[j].ICReceiptComponentItemProductQty;
                                string productSupplierNo = MultiProductReceiptComponentItemsList[j].ICReceiptComponentItemProductSupplierNo;
                                if (!String.IsNullOrEmpty(productSupplierNo) && !productSupplierNoString.Contains(productSupplierNo))
                                    productSupplierNoString += String.Format("; {0}", productSupplierNo);
                                if (!String.IsNullOrEmpty(MultiReceiptComponentItemsList[j].ICReceiptComponentItemProductDesc))
                                    productDescString += String.Format("; {0}", MultiReceiptComponentItemsList[j].ICReceiptComponentItemProductDesc);
                            }
                            else
                                break;
                        }

                        objPackagesInfo.ICProductSupplierNo = productSupplierNoString.Trim();
                        objPackagesInfo.ICPackageProductCount = packageProductCount;
                        objPackagesInfo.ICProductDesc = productDescString.Trim();

                        //Generate supplier package no
                        if (receiptItemPackageList != null && receiptItemPackageList.Count > 0)
                        {
                            if (numPackage > preItemReceiptPackageQty + nextItemReceiptPackageQty)
                            {
                                receiptItemPackageIndex += 1;
                                preItemReceiptPackageQty = nextItemReceiptPackageQty;
                                nextItemReceiptPackageQty = receiptItemPackageList[receiptItemPackageIndex].ICReceiptItemPackageQty;
                            }
                            objPackagesInfo.ICPackageSupplierNo = receiptItemPackageList[receiptItemPackageIndex].ICReceiptItemPackageSupplierNo;
                        }
                        objPackagesController.CreateObject(objPackagesInfo);

                        //Create product package
                        objPackageProductsInfo.FK_ICPackageID = objPackagesInfo.ICPackageID;
                        objPackageProductsInfo.FK_ICProductID = MultiReceiptComponentItemsList[i].FK_ICProductID;
                        objPackageProductsInfo.ICPackageProductQty = MultiReceiptComponentItemsList[i].ICReceiptComponentItemProductQty;
                        objPackageProductsController.CreateObject(objPackageProductsInfo);
                        for (int j = i + 1; j < MultiReceiptComponentItemsList.Count; j++)
                        {
                            if (!MultiReceiptComponentItemsList[j].IsPackageGroup)
                            {
                                objPackageProductsInfo.FK_ICPackageID = objPackagesInfo.ICPackageID;
                                objPackageProductsInfo.FK_ICProductID = MultiReceiptComponentItemsList[j].FK_ICProductID;
                                objPackageProductsInfo.ICPackageProductQty = MultiReceiptComponentItemsList[j].ICReceiptComponentItemProductQty;
                                objPackageProductsController.CreateObject(objPackageProductsInfo);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    //Reset value
                    receiptItemPackageIndex = 0;
                    nextItemReceiptPackageQty = preItemReceiptPackageQty;
                    preItemReceiptPackageQty = 0;

                    //Update package number start
                    objPackageNumbersInfo.ICPackageNumberStart = middleNoMax;
                    objPackageNumbersController.UpdateObject(objPackageNumbersInfo);
                    if (startIndex > i)
                    {
                        i = startIndex - 1;
                    }
                }
            }
            #endregion

            return true;
        }

        /// <summary>
        /// Update package
        /// </summary>
        /// <param name="objPackagesInfo">Given package</param>
        public void UpdatePackage(ICPackagesInfo objPackagesInfo)
        {
            ICPackagesController objPackagesController = new ICPackagesController();
            objPackagesController.UpdateObject(objPackagesInfo);
        }

        public override bool IsInvalidInventory()
        {
            return ComponentReceiptItemList.IsInvalidInventory(TransactionUtil.cstInventoryReceipt);
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
                receiptItem.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                receiptItem.ICReceiptItemProductSupplierNo = objProductsInfo.ICProductSupplierNumber;
                //NN GIANG ADD AccountID WITH PRODUCT - START - 25-04-2016
                receiptItem.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                receiptItem.ICReceiptItemProductType = objProductsInfo.ICProductType;
                //NN GIANG ADD AccountID WITH PRODUCT - END - 25-04-2016
            }
        }

        /// <summary>
        /// Set receipt item entity after validate product
        /// </summary>
        /// <param name="productID">Product id</param>
        /// <returns>PurchaseReceipt item entity</returns>
        public ICReceiptComponentItemsInfo SetReceiptComponentItemAfterValidateProduct(int productID)
        {
            ICReceiptsInfo objICReceiptsInfo = (ICReceiptsInfo)MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            if (objProductsInfo != null)
            {
                ICReceiptComponentItemsInfo objReceiptComponentItemsInfo = new ICReceiptComponentItemsInfo();
                SetDefaultValuesFromProduct(productID, objReceiptComponentItemsInfo);
                objReceiptComponentItemsInfo.FK_ICStockID = objICReceiptsInfo.FK_ICStockID;
                objReceiptComponentItemsInfo.ICProductComponentQty = 1;
                objReceiptComponentItemsInfo.ICReceiptComponentItemType = ReceiptItemType.MultiPackage.ToString();
                return objReceiptComponentItemsInfo;
            }
            return null;
        }

        /// <summary>
        /// Generate main object, module object, module object list from a purchase order
        /// </summary>
        /// <param name="objPurchaseOrdersInfo">Given purchase order</param>
        public void GenerateEntityFromPurchaseOrder(APPurchaseOrdersInfo objPurchaseOrdersInfo)
        {
            //Copy receipt
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            ICReceiptsInfo objOldReceiptsInfo = (ICReceiptsInfo)objReceiptsInfo.Clone();
            BOSUtil.CopyObject(objPurchaseOrdersInfo, objReceiptsInfo);

            //Restore some its own properties
            objReceiptsInfo.ICReceiptNo = objOldReceiptsInfo.ICReceiptNo;
            objReceiptsInfo.ICReceiptName = objOldReceiptsInfo.ICReceiptName;
            objReceiptsInfo.ICReceiptTypeCombo = objOldReceiptsInfo.ICReceiptTypeCombo;
            objReceiptsInfo.ICReceiptStatus = objOldReceiptsInfo.ICReceiptStatus;
            objReceiptsInfo.FK_ICStockID = objOldReceiptsInfo.FK_ICStockID;
            objReceiptsInfo.ICReceiptDate = objOldReceiptsInfo.ICReceiptDate;
            objReceiptsInfo.ICReceiptDeliveryDate = objOldReceiptsInfo.ICReceiptDeliveryDate;
            objReceiptsInfo.ICReceiptValidateDate = objOldReceiptsInfo.ICReceiptValidateDate;
            objReceiptsInfo.ICReceiptDesc = objOldReceiptsInfo.ICReceiptDesc;
            objReceiptsInfo.ICReceiptReference = objPurchaseOrdersInfo.APPurchaseOrderNo;
            objReceiptsInfo.FK_HREmployeeID = objOldReceiptsInfo.FK_HREmployeeID;
            objReceiptsInfo.ICReceiptEmployeePicture = objOldReceiptsInfo.ICReceiptEmployeePicture;
            objReceiptsInfo.ICReceiptPackNo = GetProductLotNo();
            //Copy item list
            BOSList<APPurchaseOrderItemsInfo> lstPurchaseOrderItems = new BOSList<APPurchaseOrderItemsInfo>();
            lstPurchaseOrderItems.InitBOSList(
                                                null,
                                                TableName.APPurchaseOrdersTableName,
                                                TableName.APPurchaseOrderItemsTableName,
                                                BOSList<APPurchaseOrderItemsInfo>.cstRelationForeign);
            lstPurchaseOrderItems.Invalidate(objPurchaseOrdersInfo.APPurchaseOrderID);
            APReferencePurchaseOrderItemsList.Clear();
            foreach (APPurchaseOrderItemsInfo objPurchaseOrderItemsInfo in lstPurchaseOrderItems)
            {
                objPurchaseOrderItemsInfo.APPurchaseOrderItemRemainedQty = objPurchaseOrderItemsInfo.APPurchaseOrderItemProductQty - objPurchaseOrderItemsInfo.APPurchaseOrderItemProductQtyOld;
                if (objPurchaseOrderItemsInfo.APPurchaseOrderItemRemainedQty > 0)
                {
                    ICReceiptItemsInfo objReceiptItemsInfo = new ICReceiptItemsInfo();
                    BOSUtil.CopyObject(objPurchaseOrderItemsInfo, objReceiptItemsInfo);
                    objReceiptItemsInfo.FK_ICStockID = objReceiptsInfo.FK_ICStockID;
                    objReceiptItemsInfo.ICReceiptItemProductQty = objPurchaseOrderItemsInfo.APPurchaseOrderItemRemainedQty;
                    SetProductCostByProductUnitCost(objReceiptItemsInfo);
                    ReceiptItemsList.Add(objReceiptItemsInfo);
                    APReferencePurchaseOrderItemsList.Add(objPurchaseOrderItemsInfo.APPurchaseOrderItemID, objPurchaseOrderItemsInfo);
                }
            }

            UpdateTotalCost();
        }

        /// <summary>
        /// Generate main object, module object, module object list from an invoice
        /// </summary>
        /// <param name="objInvoiceInsInfo">Given invoice</param>
        public void GenerateEntityFromInvoice(APInvoiceInsInfo objInvoiceInsInfo)
        {
            //Copy receipt
            ICReceiptsInfo receipt = (ICReceiptsInfo)MainObject;
            ICReceiptsInfo oldReceipt = (ICReceiptsInfo)receipt.Clone();
            BOSUtil.CopyObject(objInvoiceInsInfo, receipt);
            receipt.ICReceiptPackNo = objInvoiceInsInfo.APInvoiceInPackNo;
            //Restore some its own properties
            receipt.AACreatedDate = oldReceipt.AACreatedDate;
            receipt.AACreatedUser = oldReceipt.AACreatedUser;
            receipt.AAUpdatedDate = oldReceipt.AAUpdatedDate;
            receipt.AAUpdatedUser = oldReceipt.AAUpdatedUser;
            receipt.ICReceiptNo = oldReceipt.ICReceiptNo;
            receipt.ICReceiptName = oldReceipt.ICReceiptName;
            receipt.ICReceiptTypeCombo = oldReceipt.ICReceiptTypeCombo;
            receipt.ICReceiptStatus = oldReceipt.ICReceiptStatus;
            receipt.ICReceiptPostedStatus = oldReceipt.ICReceiptPostedStatus;
            receipt.FK_ICStockID = oldReceipt.FK_ICStockID;
            receipt.ICReceiptDate = oldReceipt.ICReceiptDate;
            receipt.ICReceiptDeliveryDate = oldReceipt.ICReceiptDeliveryDate;
            receipt.ICReceiptValidateDate = oldReceipt.ICReceiptValidateDate;
            receipt.ICReceiptDesc = oldReceipt.ICReceiptDesc;
            receipt.ICReceiptReference = objInvoiceInsInfo.APInvoiceInNo;
            receipt.ICReceiptInvoiceInNo = objInvoiceInsInfo.APInvoiceInSupplierNo;
            receipt.ICReceiptInvoiceInDate = objInvoiceInsInfo.APInvoiceInDate;
            receipt.ICReceiptReceiptType = objInvoiceInsInfo.APInvoiceInType;
            receipt.FK_HREmployeeID = oldReceipt.FK_HREmployeeID;
            receipt.ICReceiptEmployeePicture = oldReceipt.ICReceiptEmployeePicture;
            receipt.FK_BRBranchID = oldReceipt.FK_BRBranchID;
            receipt.FK_ICProductAttributeTTMTID = objInvoiceInsInfo.FK_ICProductAttributeTTMTID;
            receipt.ICReceiptCreateFrom = "InvoiceIn";
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(receipt.FK_ACAssObjectID, receipt.ICAssObjectType);
            receipt.ICReceiptDeliveryContactName = objObjectsInfo != null ? objObjectsInfo.ACObjectName : string.Empty;
            //TKChinh Add PO No
            receipt.ICReceiptPONo = objInvoiceInsInfo.APInvoiceInPONo;

            //Copy item list
            BOSList<APInvoiceInItemsInfo> invoiceItems = new BOSList<APInvoiceInItemsInfo>();
            invoiceItems.InitBOSList(
                                    null,
                                    TableName.APInvoiceInsTableName,
                                    TableName.APInvoiceInItemsTableName,
                                    BOSList<APInvoiceInItemsInfo>.cstRelationForeign);


            //invoiceItems.Invalidate(objInvoiceInsInfo.APInvoiceInID);
            APInvoiceInItemsController objItemsController = new APInvoiceInItemsController();
            //List<APInvoiceInItemsInfo> invoiceInItemList = objItemsController.GetItemsByInvoiceID(objInvoiceInsInfo.APInvoiceInID); //GetInvoiceInItemByInvoiceInID
            List<APInvoiceInItemsInfo> invoiceInItemList = (List<APInvoiceInItemsInfo>)objItemsController.GetListFromDataSet(objItemsController.GetInvoiceInItemByInvoiceInID(objInvoiceInsInfo.APInvoiceInID));
            if (invoiceInItemList == null || invoiceInItemList.Count == 0)
                invoiceInItemList = new List<APInvoiceInItemsInfo>();
            invoiceInItemList = invoiceInItemList.Where(o => o.APInvoiceInItemProductType != ProductType.Work.ToString()
                                    && o.APInvoiceInItemProductType != ProductType.Service.ToString()).ToList();
            invoiceItems.Invalidate(invoiceInItemList);
            APBillOfLadingItemsController objBillOfLadingItemsController = new APBillOfLadingItemsController();
            List<APBillOfLadingItemsInfo> listBOL = objBillOfLadingItemsController.GetItemByInvoiceInID(objInvoiceInsInfo.APInvoiceInID);
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();

            foreach (APInvoiceInItemsInfo objInvoiceInItemsInfo in invoiceItems)
            {
                decimal qty = 0;
                if (objInvoiceInItemsInfo.APInvoiceInItemProductQty - objInvoiceInItemsInfo.APInvoiceInItemReceiptedQty > 0)
                {
                    ICReceiptItemsInfo objReceiptItemsInfo = new ICReceiptItemsInfo();
                    BOSUtil.CopyObject(objInvoiceInItemsInfo, objReceiptItemsInfo);
                    //ReceiptItemIDMax += 1;
                    //objReceiptItemsInfo.Id = ReceiptItemIDMax;
                    objReceiptItemsInfo.FK_ICStockID = receipt.FK_ICStockID;
                    objReceiptItemsInfo.FK_APBillOfLadingID = objInvoiceInsInfo.APBillOfLadingID;
                    objReceiptItemsInfo.FK_APBillOfLadingItemID = 0;
                    if (listBOL != null && listBOL.Count > 0)
                    {
                        APBillOfLadingItemsInfo objBillOfLadingItemsInfo = listBOL.Where(o => o.FK_ICProductID == objInvoiceInItemsInfo.FK_ICProductID).FirstOrDefault();
                        if (objBillOfLadingItemsInfo != null)
                        {
                            if (IsValidateBillOfLading(objBillOfLadingItemsInfo.APBillOfLadingItemID))
                                objReceiptItemsInfo.FK_APBillOfLadingItemID = objBillOfLadingItemsInfo.APBillOfLadingItemID;
                        }
                    }
                    objReceiptItemsInfo.FK_APInvoiceInID = objInvoiceInItemsInfo.FK_APInvoiceInID;
                    objReceiptItemsInfo.FK_APInvoiceInItemID = objInvoiceInItemsInfo.APInvoiceInItemID;
                    objReceiptItemsInfo.FK_ICModelID = objInvoiceInItemsInfo.FK_ICModelID;
                    objReceiptItemsInfo.FK_ICModelDetailID = objInvoiceInItemsInfo.FK_ICModelDetailID;
                    objReceiptItemsInfo.ICReceiptItemProductSupplierNo = objInvoiceInItemsInfo.APInvoiceInItemProductSupplierNo;
                    objReceiptItemsInfo.FK_ICProductAttributeTTMTID = objInvoiceInItemsInfo.FK_ICProductAttributeTTMTID;
                    objReceiptItemsInfo.ICReceiptItemWoodQty = objInvoiceInItemsInfo.APInvoiceInItemWoodQty;
                    objProductsInfo = BOSApp.GetProductFromCurrentProductList(objReceiptItemsInfo.FK_ICProductID);
                    objReceiptItemsInfo.FK_ICMeasureUnitID = objInvoiceInItemsInfo.FK_ICMeasureUnitID;
                    objReceiptItemsInfo.ICReceiptItemProductType = objProductsInfo.ICProductType;
                    objReceiptItemsInfo.ICReceiptItemProductFactor = objInvoiceInItemsInfo.APInvoiceInItemProductFactor;
                    objReceiptItemsInfo.FK_GECountryID = objInvoiceInItemsInfo.FK_GECountryID;
                    if (objProductsInfo != null)
                    {
                        //NN GIANG ADD AccountID WITH PRODUCT - START - 25-04-2016
                        objReceiptItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                        //NN GIANG ADD AccountID WITH PRODUCT - END - 25-04-2016
                        objReceiptItemsInfo.FK_ACAccountID = GetAccountByStock(objReceiptItemsInfo.FK_ICStockID, objReceiptItemsInfo.FK_ACAccountID);
                        qty = Math.Round((objInvoiceInItemsInfo.APInvoiceInItemProductQty - objInvoiceInItemsInfo.APInvoiceInItemReceiptedQty), 5, MidpointRounding.AwayFromZero);
                    }
                    if (receipt.ICReceiptReceiptType == ProductType.IngredientPaint.ToString())
                    {
                        objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objReceiptItemsInfo.FK_ICProductID);

                        if (objProductsInfo != null)
                        {
                            objReceiptItemsInfo.ICReceiptItemProductionDate = receipt.ICReceiptDate;
                            objReceiptItemsInfo.ICReceiptItemExpiryDate = objReceiptItemsInfo.ICReceiptItemProductionDate.AddDays((int)objProductsInfo.ICProductExpiryDay);
                        }
                    }
                    objReceiptItemsInfo.ICReceiptItemProductQty = qty;
                    objReceiptItemsInfo.APPurchaseOrderItemProductQty = qty;
                    receipt.FK_APPurchaseContractID = objInvoiceInItemsInfo.FK_APPurchaseContractID;
                    receipt.FK_APPurchaseOrderID = objInvoiceInItemsInfo.FK_APPurchaseOrderID;
                    SetProductCostByProductUnitCost(objReceiptItemsInfo);
                    ReceiptItemsList.Add(objReceiptItemsInfo);
                }
            }

            UpdateTotalCost();
        }
        public bool IsValidateBillOfLading(int billOfLadingItemID)
        {
            bool result = true;
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            ICReceiptItemsInfo objReceipItemsInfo = (ICReceiptItemsInfo)objReceiptItemsController.CheckExistBillOfLadings(billOfLadingItemID);
            if (objReceipItemsInfo != null)
                result = false;
            return result;
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
            foreach (ICReceiptItemsInfo item in items)
            {
                ComponentReceiptItemList.Add((ICReceiptItemsInfo)item.Clone());
            }

            foreach (ICReceiptItemsInfo item in ComponentReceiptItemList)
            {
                ComponentReceiptItemList.OriginalList.Add((ICReceiptItemsInfo)item.Clone());
            }
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
                objDocumentsInfo.ACDocumentDate = objReceiptsInfo.ICReceiptDate;
                objDocumentsInfo.ACDocumentInvoiceDate = objReceiptsInfo.ICReceiptInvoiceInDate;
            }


            return base.SaveAccountingData();
        }
        #endregion

        public override int CreateMainObject()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo;
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
                    UpdateProductLotNo(objGENumberingInfo.GENumberingStart);
                    foreach (ICReceiptItemsInfo item in ReceiptItemsList)
                    {
                        objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                        if (objProductsInfo.ICProductType != ProductType.Service.ToString()
                            && objProductsInfo.ICPriceCalculationMethodMethod == PriceCalculationMethod.Specific.ToString()
                            && !item.ICReceiptItemIsAverageCalculation
                            && string.IsNullOrEmpty(item.ICReceiptItemLotNo))
                        {
                            if (BOSApp.IsWoodTypeDocument(objReceiptsInfo.ICReceiptReceiptType, ReceiptItemsList.FirstOrDefault()))
                                item.ICReceiptItemLotNo = objReceiptsInfo.ICReceiptPackNo;
                        }
                    }
                }
            }
            return iObjectID;
        }


        public void GenerateEntityFromPurchaseOrders(APPurchaseOrdersInfo objPurchaseOrdersInfo, IList<APPurchaseOrderItemsInfo> purchaseOrderItemList)
        {
            //Copy receipt
            ICReceiptsInfo receipt = (ICReceiptsInfo)MainObject;
            ICReceiptsInfo oldReceipt = (ICReceiptsInfo)receipt.Clone();
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            BOSUtil.CopyObject(objPurchaseOrdersInfo, receipt);
            //Restore some its own properties
            receipt.AAUpdatedUser = "";
            receipt.AAUpdatedDate = DateTime.MaxValue;
            receipt.ICReceiptNo = oldReceipt.ICReceiptNo;
            receipt.ICReceiptName = oldReceipt.ICReceiptName;
            receipt.ICReceiptTypeCombo = oldReceipt.ICReceiptTypeCombo;
            receipt.ICReceiptStatus = oldReceipt.ICReceiptStatus;
            receipt.ICReceiptPostedStatus = oldReceipt.ICReceiptPostedStatus;
            receipt.FK_ICStockID = oldReceipt.FK_ICStockID;
            receipt.ICReceiptDate = oldReceipt.ICReceiptDate;
            receipt.ICReceiptDeliveryDate = oldReceipt.ICReceiptDeliveryDate;
            receipt.ICReceiptValidateDate = oldReceipt.ICReceiptValidateDate;
            receipt.ICReceiptDesc = oldReceipt.ICReceiptDesc;
            receipt.ICReceiptReference = objPurchaseOrdersInfo.APPurchaseOrderNo;
            receipt.FK_HREmployeeID = oldReceipt.FK_HREmployeeID;
            receipt.ICReceiptEmployeePicture = oldReceipt.ICReceiptEmployeePicture;
            receipt.FK_BRBranchID = oldReceipt.FK_BRBranchID;
            receipt.ICReceiptReceiptType = objPurchaseOrdersInfo.APPurchaseOrderReceiptTypeCombo;
            receipt.FK_APPurchaseOrderID = objPurchaseOrdersInfo.APPurchaseOrderID;
            receipt.ICReceiptCreateFrom = "PurchaseOrder";
            receipt.ICReceiptTaxPercent = objPurchaseOrdersInfo.APPurchaseOrderTaxPercent;
            receipt.ICReceiptTaxAmount = 0;

            foreach (APPurchaseOrderItemsInfo obj in purchaseOrderItemList)
            {
                decimal qty = 0;
                if (obj.APPurchaseOrderItemProductQty > 0)
                {
                    ICReceiptItemsInfo objReceiptItemsInfo = new ICReceiptItemsInfo();
                    BOSUtil.CopyObject(obj, objReceiptItemsInfo);
                    objProductsInfo = BOSApp.GetProductFromCurrentProductList(objReceiptItemsInfo.FK_ICProductID);
                    if (objProductsInfo != null)
                    {
                        objReceiptItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                        //objReceiptItemsInfo.FK_ACAccountID = GetAccountByStock(objReceiptItemsInfo.FK_ICStockID, objReceiptItemsInfo.FK_ACAccountID);
                        qty = Math.Round((obj.APPurchaseOrderItemProductQty), 5, MidpointRounding.AwayFromZero);
                    }
                    objReceiptItemsInfo.FK_ICStockID = 0;
                    objReceiptItemsInfo.ICReceiptItemProductQty = qty;
                    objReceiptItemsInfo.FK_APPurchaseOrderItemID = obj.APPurchaseOrderItemID;
                    objReceiptItemsInfo.FK_ICModelID = obj.FK_ICModelID;
                    objReceiptItemsInfo.FK_ICModelDetailID = obj.FK_ICModelDetailID;
                    objReceiptItemsInfo.FK_MMBatchProductID = obj.FK_MMBatchProductID;
                    objReceiptItemsInfo.FK_ICMeasureUnitID = obj.FK_ICMeasureUnitID;
                    objReceiptItemsInfo.ICReceiptItemProductFactor = obj.APPurchaseOrderItemProductFactor;
                    objReceiptItemsInfo.ICReceiptItemProductUnitCost = obj.APPurchaseOrderItemProductUnitCost;
                    SetProductCostByProductUnitCost(objReceiptItemsInfo);
                    objReceiptItemsInfo.ICReceiptItemProductSupplierNo = obj.APPurchaseOrderItemProductSupplierNo;
                    objReceiptItemsInfo.ICReceiptItemWoodQty = obj.APPurchaseOrderItemWoodQty;
                    objReceiptItemsInfo.ICReceiptItemProductType = objProductsInfo.ICProductType;
                    objReceiptItemsInfo.FK_ICLengthGroupID = objProductsInfo.FK_ICLengthGroupID;
                    objReceiptItemsInfo.FK_ICPerimeterGroupID = objProductsInfo.FK_ICPerimeterGroupID;
                    objReceiptItemsInfo.FK_GETerminalID = receipt.FK_GETerminalID;
                    objReceiptItemsInfo.FK_ICProductAttributeTTMTID = obj.FK_ICProductAttributeTTMTID;
                    objReceiptItemsInfo.ICReceiptItemProductLength = obj.APPurchaseOrderItemProductLenght;
                    objReceiptItemsInfo.ICReceiptItemLenghtMin = obj.APPurchaseOrderItemProductLenghtMin;
                    objReceiptItemsInfo.ICReceiptItemWidthMin = obj.APPurchaseOrderItemProductWidthMin;
                    objReceiptItemsInfo.ICReceiptItemWidthMax = obj.APPurchaseOrderItemProductWidthMax;
                    objReceiptItemsInfo.ICReceiptItemLenghtMax = obj.APPurchaseOrderItemProductLenghtMax;
                    objReceiptItemsInfo.FK_GECountryID = obj.FK_GECountryID;
                    objReceiptItemsInfo.ICReceiptItemSOName = obj.MMBatchProductSOName;
                    if (objPurchaseOrdersInfo.APPurchaseOrderReceiptTypeCombo == ProductType.Lumber.ToString() || objPurchaseOrdersInfo.APPurchaseOrderReceiptTypeCombo == ProductType.Roundwood.ToString())
                    {
                        objReceiptItemsInfo.ICReceiptItemProductLength = obj.APPurchaseOrderItemProductLenght;

                        if (objPurchaseOrdersInfo.APPurchaseOrderReceiptTypeCombo == ProductType.IngredientPaint.ToString())
                        {
                            objReceiptItemsInfo.ICReceiptItemNotJetExceptBlock = obj.APPurchaseOrderItemProductQty;
                            objReceiptItemsInfo.ICReceiptItemProductQty = (objReceiptItemsInfo.ICReceiptItemNotJetExceptBlock - objReceiptItemsInfo.ICReceiptItemExceptedBlock);
                            receipt.ICReceiptTotalQty = (receipt.ICReceiptTotalQty + objReceiptItemsInfo.ICReceiptItemProductQty);
                        }
                        else if (objPurchaseOrdersInfo.APPurchaseOrderReceiptTypeCombo == ProductType.Roundwood.ToString())
                        {
                            objReceiptItemsInfo.ICReceiptItemNotJetExceptBlock = obj.APPurchaseOrderItemProductQty;
                            objReceiptItemsInfo.ICReceiptItemProductQty = (objReceiptItemsInfo.ICReceiptItemNotJetExceptBlock - objReceiptItemsInfo.ICReceiptItemExceptedBlock);
                            receipt.ICReceiptTotalQty = (receipt.ICReceiptTotalQty + objReceiptItemsInfo.ICReceiptItemProductQty);
                        }
                    }
                    else if (objPurchaseOrdersInfo.APPurchaseOrderReceiptTypeCombo == PurchaseOrderReceiptType.WoodMDFOutSourcing.ToString()
                            || objPurchaseOrdersInfo.APPurchaseOrderReceiptTypeCombo == PurchaseOrderReceiptType.MechanicOutSourcing.ToString()
                            || objPurchaseOrdersInfo.APPurchaseOrderReceiptTypeCombo == PurchaseOrderReceiptType.OutSourcing.ToString())
                    {
                        objReceiptItemsInfo.ICReceiptItemQty2 = obj.APPurchaseOrderItemProductUnitCost; //Lưu Đơn giá gia công ở Đơn mua hàng
                        objReceiptItemsInfo.ICReceiptItemQty3 = obj.APPurchaseOrderItemPackagedQty1Compare; //Lưu Tổng giá vốn xuất kho    
                        objReceiptItemsInfo.FK_ACOffsetAccountID = obj.FK_ACAccountID;
                    }
                    objReceiptItemsInfo.ICReceiptItemInventoryCost = objReceiptItemsInfo.ICReceiptItemProductUnitCost;
                    objReceiptItemsInfo.APPurchaseOrderItemProductQty = obj.APPurchaseOrderItemProductQty;
                    if (receipt.ICReceiptReceiptType == ProductType.IngredientPaint.ToString())
                    {
                        objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objReceiptItemsInfo.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            objReceiptItemsInfo.ICReceiptItemProductionDate = receipt.ICReceiptDate;
                            objReceiptItemsInfo.ICReceiptItemExpiryDate = objReceiptItemsInfo.ICReceiptItemProductionDate.AddDays((int)objProductsInfo.ICProductExpiryDay);
                        }
                    }
                    ReceiptItemsList.Add(objReceiptItemsInfo);
                }
            }
            ReceiptItemsList.GridControl.RefreshDataSource();
            UpdateTotalCost();
        }

        public List<APPOPaymentTimeInvoiceInDetailsInfo> GeneratePOPaymentTimeInvoiceInDetailList()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            List<APPOPaymentTimeInvoiceInDetailsInfo> pOPaymentTimeInvoiceInDetails = new List<APPOPaymentTimeInvoiceInDetailsInfo>();

            APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
            APPurchaseOrdersInfo objPurchaseOrdersInfo = new APPurchaseOrdersInfo();
            objPurchaseOrdersInfo = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByID(ReceiptItemsList.FirstOrDefault().FK_APPurchaseOrderID);

            APPurchaseOrderPaymentTimesController objPurchaseOrderPaymentTimesController = new APPurchaseOrderPaymentTimesController();
            List<APPurchaseOrderPaymentTimesInfo> purchaseOrderPaymentTimes = new List<APPurchaseOrderPaymentTimesInfo>();
            if (objPurchaseOrdersInfo != null)
            {
                purchaseOrderPaymentTimes = objPurchaseOrderPaymentTimesController.GetByPurchaeOrderID(objPurchaseOrdersInfo.APPurchaseOrderID);

                purchaseOrderPaymentTimes.Where(o => o.APPurchaseOrderPaymentTimePaymentTimepoint == PaymentTermItemPaymentDate.IsAfterDelivery.ToString()).ToList()
                                            .ForEach(o => pOPaymentTimeInvoiceInDetails.Add(GenerateIsAfterDeliveryPOPaymentTimeInvoiceInDetailsInfo(o, objPurchaseOrdersInfo, objReceiptsInfo)));
            }
            return pOPaymentTimeInvoiceInDetails;
        }

        public APPOPaymentTimeInvoiceInDetailsInfo GenerateIsAfterDeliveryPOPaymentTimeInvoiceInDetailsInfo(APPurchaseOrderPaymentTimesInfo objPurchaseOrderPaymentTimesInfo, APPurchaseOrdersInfo objPurchaseOrdersInfo, ICReceiptsInfo objReceiptsInfo)
        {
            APPOPaymentTimeInvoiceInDetailsInfo objPOPaymentTimeInvoiceInDetailsInfo;
            objPOPaymentTimeInvoiceInDetailsInfo = new APPOPaymentTimeInvoiceInDetailsInfo()
            {
                FK_APPurchaseOrderID = objPurchaseOrdersInfo.APPurchaseOrderID,
                APPOPaymentTimeInvoiceInDetailAmount = 0,
                APPOPaymentTimeInvoiceInDetailDate = objReceiptsInfo.ICReceiptDate,
                FK_APPurchaseOrderPaymentTimeID = objPurchaseOrderPaymentTimesInfo.APPurchaseOrderPaymentTimeID,
                FK_APInvoiceInID = 0,
                APInvoiceInNo = String.Empty,
                APPurchaseOrderNo = objPurchaseOrdersInfo.APPurchaseOrderNo,
                APPOPaymentTimeInvoiceInDetailEndDate = objReceiptsInfo.ICReceiptDate.AddDays(objPurchaseOrderPaymentTimesInfo.APPurchaseOrderPaymentTimePaymentTermItemDay),
                //APPOPaymentTimeInvoiceInDetailBalanceDue = objPurchaseOrderPaymentTimesInfo.APPurchaseOrderPaymentTimeAmount,
                FK_ACDebitAccountID = 0,
                FK_ACCreditAccountID = 0,
                FK_ACObjectID = objPurchaseOrdersInfo.FK_ACObjectID,
                APObjectType = objPurchaseOrdersInfo.APObjectType,
                FK_GECurrencyID = objPurchaseOrdersInfo.FK_GECurrencyID,
                APPOPaymentTimeInvoiceInDetailDepositAmount = objPurchaseOrderPaymentTimesInfo.APPurchaseOrderPaymentTimeAmount,
                APPOPaymentTimeInvoiceInDetailPaidAmount = 0,
                APPOPaymentTimeInvoiceInDetailPaymentType = objPurchaseOrderPaymentTimesInfo.APPurchaseOrderPaymentTimePaymentTermItemPaymentType,
                APPOPaymentTimeInvoiceInDetailDocumentType = "PurchaseReceipt",
                FK_BRBranchID = objPurchaseOrdersInfo.FK_BRBranchID,
            };
            objPOPaymentTimeInvoiceInDetailsInfo.APPOPaymentTimeInvoiceInDetailRequiredAmount = objPOPaymentTimeInvoiceInDetailsInfo.APPOPaymentTimeInvoiceInDetailDepositAmount;

            return objPOPaymentTimeInvoiceInDetailsInfo;
        }

        public List<ICProductSerialNumbersInfo> GenerateProductSerialNumber()
        {
            List<ICProductSerialNumbersInfo> productSerialNumbers = new List<ICProductSerialNumbersInfo>();
            ICProductSerialNumbersController objProductSerialNumbersController = new ICProductSerialNumbersController();
            ICProductSerialNumbersInfo objProductSerialNumbersInfo;
            GENumberingController objNumberingController = new GENumberingController();
            GENumberingInfo objNumberingInfo;
            string productSerialNumber;
            ReceiptItemsList.ForEach(o =>
            {
                for (int i = 0; i < o.ICReceiptItemProductQty; i++)
                {
                    objNumberingInfo = (GENumberingInfo)objNumberingController.GetObjectByName("ProductSerialNumber");
                    DateTime currentDate = BOSApp.GetCurrentServerDate();

                    if (objNumberingInfo.AAUpdatedDate.Year < currentDate.Year)
                    {
                        objNumberingInfo.GENumberingStart = Convert.ToInt32(Math.Pow(10, objNumberingInfo.GENumberingLength - 1)) + 1;
                    }
                    objProductSerialNumbersInfo = new ICProductSerialNumbersInfo();
                    if (objNumberingInfo != null)
                    {
                        productSerialNumber = objNumberingInfo.GENumberingStart.ToString().PadLeft(objNumberingInfo.GENumberingLength, '0');
                        objProductSerialNumbersInfo.ICProductSerialNumberNo = string.Format(PurchaseReceiptLocalizedResources.ProductSerialNumberDefault, currentDate.Year.ToString().Substring(2, 2), productSerialNumber);
                        objProductSerialNumbersInfo.FK_ICProductID = o.FK_ICProductID;
                        objProductSerialNumbersInfo.FK_ICProductSerieID = o.FK_ICProductSerieID;
                        objProductSerialNumbersController.CreateObject(objProductSerialNumbersInfo);
                        productSerialNumbers.Add(objProductSerialNumbersInfo);
                        objNumberingInfo.GENumberingStart++;
                        objNumberingController.UpdateObject(objNumberingInfo);
                    }
                }
            });

            return productSerialNumbers;
        }

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
        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            string strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            if (MainObject != null && strTableName == strMainObjectTableName)
            {
                ReceiptItemsList.DeleteItemObjects();
                MultiPackageReceiptComponentItemsList.DeleteItemObjects();
                MultiProductReceiptComponentItemsList.DeleteItemObjects();
                MultiReceiptComponentItemsList.DeleteItemObjects();
                ComponentReceiptItemList.DeleteItemObjects();
                ReceiptItemLogList.DeleteItemObjects();
                ReceiptItemContList.DeleteItemObjects();
                ReceiptItemContFeeList.DeleteItemObjects();
                ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
                objProductSeriesController.DeleteReferSeries(iObjectID);
            }
        }

        public override void SetProductCostByProductUnitCost(BusinessObject objItem)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String itemTableName = BOSUtil.GetTableNameFromBusinessObject(objItem);

            string mainTablePrefix = mainTableName.Substring(0, mainTableName.Length - 1);
            string itemTablePrefix = itemTableName.Substring(0, itemTableName.Length - 1);

            //Get Exchange Rate
            decimal exchangeRate = Convert.ToDecimal(dbUtil.GetPropertyValue(MainObject, mainTablePrefix + "ExchangeRate"));
            if (exchangeRate == 0)
                exchangeRate = 1;
            //round by currency
            int currencyID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_GECurrencyID"));
            int decimalNumber = BOSApp.GetDecimalNumberByCurrencyID(currencyID);

            //Get Item Qty
            String columnName = itemTablePrefix + "ProductQty";
            decimal qty = Convert.ToDecimal(dbUtil.GetPropertyValue(objItem, columnName));

            //Get Item Unit Cost            
            columnName = itemTablePrefix + "ProductUnitCost";
            decimal unitCost = Convert.ToDecimal(dbUtil.GetPropertyValue(objItem, columnName));
            //unitCost = Math.Round(unitCost, decimalNumber);

            //Get item discount percent
            columnName = itemTablePrefix + "ProductDiscount";
            decimal discountPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(objItem, columnName));

            //Get Item Tax Percent
            columnName = itemTablePrefix + "ProductTaxPercent";
            decimal taxPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(objItem, columnName));

            //Set Extended Cost
            columnName = itemTablePrefix + "ExtCost";
            decimal extCost = unitCost * qty;
            //extCost = Math.Round(extCost, decimalNumber);
            dbUtil.SetPropertyValue(objItem, columnName, extCost);

            //Set item discount amount
            decimal discountAmount = extCost * discountPercent / 100;
            //discountAmount = Math.Round(discountAmount, decimalNumber);
            columnName = itemTablePrefix + "DiscountAmount";
            dbUtil.SetPropertyValue(objItem, columnName, discountAmount);

            //Set Item Tax Amount
            columnName = itemTablePrefix + "TaxAmount";
            decimal taxAmount = ((extCost - discountAmount) * taxPercent) / 100;
            //taxAmount = Math.Round(taxAmount, decimalNumber);
            dbUtil.SetPropertyValue(objItem, columnName, taxAmount);

            //Set Item Total Cost
            columnName = itemTablePrefix + "TotalCost";
            dbUtil.SetPropertyValue(objItem, columnName, Math.Round(extCost + taxAmount - discountAmount, 5, MidpointRounding.AwayFromZero));

            //Set Item Exchange Total Cost
            columnName = itemTablePrefix + "ExchangeTotalCost";
            dbUtil.SetPropertyValue(objItem, columnName, Math.Round((extCost + taxAmount - discountAmount) * exchangeRate, 5, MidpointRounding.AwayFromZero));

            //Get item factor
            columnName = itemTablePrefix + "ProductFactor";
            decimal factor = Convert.ToDecimal(dbUtil.GetPropertyValue(objItem, columnName));
            
            //Set Item Exchange Unit Cost
            columnName = itemTablePrefix + "ExchangeUnitCost";
            dbUtil.SetPropertyValue(objItem, columnName, unitCost / (factor != 0 ? factor : 1) * exchangeRate);
            
            //Set Item Exchange Qty
            columnName = itemTablePrefix + "ProductExchangeQty";
            dbUtil.SetPropertyValue(objItem, columnName, qty * factor);
        }
    }
}
