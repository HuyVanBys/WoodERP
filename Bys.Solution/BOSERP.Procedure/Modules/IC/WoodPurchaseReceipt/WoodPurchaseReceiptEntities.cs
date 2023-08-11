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


namespace BOSERP.Modules.WoodPurchaseReceipt
{
    public class WoodPurchaseReceiptEntities : GLReceiptEntities
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
        #endregion

        #region Constructor
        public WoodPurchaseReceiptEntities()
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
        }

        public override void InitModuleObjectList()
        {
            PackageList.InitBOSList(this, String.Empty, TableName.ICPackagesTableName, BOSList<ICPackagesInfo>.cstRelationNone);

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

        }

        public override void InitGridControlInBOSList()
        {
            ReceiptItemsList.InitBOSListGridControl();
            MultiPackageReceiptComponentItemsList.InitBOSListGridControl(WoodPurchaseReceiptModule.MultiPackageReceiptItemGridControlName);
            MultiProductReceiptComponentItemsList.InitBOSListGridControl(WoodPurchaseReceiptModule.MultiProductReceiptItemGridControlName);
            MultiReceiptComponentItemsList.InitBOSListGridControl(WoodPurchaseReceiptModule.MultiReceiptItemGridControlName);
            HistoryDetailList.InitBOSListGridControl();
            ReceiptItemLogList.InitBOSListGridControl();
            DocumentEntryList.InitBOSListGridControl(WoodPurchaseReceiptModule.DocumentEntryGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ReceiptItemsList.SetDefaultListAndRefreshGridControl();
                MultiPackageReceiptComponentItemsList.SetDefaultListAndRefreshGridControl();
                MultiProductReceiptComponentItemsList.SetDefaultListAndRefreshGridControl();
                MultiReceiptComponentItemsList.SetDefaultListAndRefreshGridControl();

            }
            catch (Exception)
            {
                return;
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
                if (GetPackNo() == null)
                {
                    {
                        string lotNo = GetProductWoodLotNo();
                        GENumberingController objGENumberingController = new GENumberingController();
                        GENumberingInfo objGENumberingInfo = (GENumberingInfo)objGENumberingController.GetObjectByName("ProductWoodSerialNo");
                        if (objGENumberingInfo != null)
                            UpdateProductWoodLotNo(objGENumberingInfo.GENumberingStart);

                        ICReceiptsController objReceiptsController = new ICReceiptsController();
                        if (objReceiptsInfo.ICReceiptPackNo == null || objReceiptsInfo.ICReceiptPackNo == string.Empty)
                        {
                            objReceiptsInfo.ICReceiptPackNo = lotNo;
                        }
                        objReceiptsController.UpdateObject(objReceiptsInfo);
                    }
                }
                else
                {
                    objReceiptsInfo.ICReceiptPackNo = GetPackNo();
                    UpdateMainObject();
                }
            }
            return iObjectID;
        }
        public string GetPackNo()
        {
            string PackNo = string.Empty;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            //WoodPurchaseReceiptEntities entity = (WoodPurchaseReceiptEntities)CurrentModuleEntity;
            //ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            ICReceiptsController objReceiptsController = new ICReceiptsController();
            PackNo = objReceiptsController.GetObjectByReference(objReceiptsInfo.ICReceiptReference, objReceiptsInfo.ICReceiptID);
            return PackNo;
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
            objReceiptsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objReceiptsInfo.ICReceiptDesc = WoodPurchaseReceiptLocalizedResources.PurchaseReceiptDefaultDesc;

            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects Functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<ICReceiptItemsInfo> receiptItems = objReceiptItemsController.GetItemsByReceiptID(iObjectID);
            //ReceiptItemsList.Invalidate(iObjectID);
            ReceiptItemsList.Invalidate(receiptItems);

            ICReceiptComponentItemsController objReceiptComponentItemsController = new ICReceiptComponentItemsController();
            List<ICReceiptComponentItemsInfo> receiptComponentItemList = objReceiptComponentItemsController.GetReceiptComponentItemByReceiptID(iObjectID);

            // Invalidate receipt item packages
            if (receiptComponentItemList != null)
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

            SaveAccountingData();
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

                //if (itemEntity.Id > OriginalReceiptItemIDMax)
                //{
                //    ICReceiptItemLogsInfo objReceiptItemLogsInfo = new ICReceiptItemLogsInfo();
                //    objReceiptItemLogsInfo.FK_ICReceiptID = objReceiptsInfo.ICReceiptID;
                //    objReceiptItemLogsInfo.ICReceiptItemLogColumnName = "ICReceiptItemProductQty";
                //    objReceiptItemLogsInfo.FK_GEObjectHistoryID = objectHistoryID;
                //    objReceiptItemLogsInfo.FK_ICReceiptItemID = itemEntity.Id;
                //    objReceiptItemLogsInfo.ICObjectHistoryAction = ObjectHistoryAction.Create.ToString();
                //    objReceiptItemLogsInfo.ICReceiptItemLogOldValue = String.Empty;
                //    objReceiptItemLogsInfo.ICReceiptItemLogNewValue = itemEntity.ICReceiptItemProductQty.ToString();
                //    objReceiptItemLogsController.CreateObject(objReceiptItemLogsInfo);
                //}
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
            objReceiptsInfo.ICReceiptTaxAmount = (objReceiptsInfo.ICReceiptSubTotalCost -
                                                 objReceiptsInfo.ICReceiptDiscountFix +
                                                 objReceiptsInfo.ICReceiptShippingFees +
                                                 objReceiptsInfo.ICReceiptShippingExtraFees) * objReceiptsInfo.ICReceiptTaxPercent / 100;
            objReceiptsInfo.ICReceiptTotalCost = objReceiptsInfo.ICReceiptSubTotalCost +
                                                 objReceiptsInfo.ICReceiptTaxAmount +
                                                 objReceiptsInfo.ICReceiptShippingFees +
                                                 objReceiptsInfo.ICReceiptShippingExtraFees -
                                                 objReceiptsInfo.ICReceiptDiscountFix;
            BOSApp.RoundByCurrency(objReceiptsInfo, objReceiptsInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }
        private void UpdateReferencePurchaseOrder()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
            APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
            APPurchaseOrdersInfo objPurchaseOrderInfo = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByNo(objReceiptsInfo.ICReceiptReference);
            //SortedList<int, List<APPurchaseOrderItemsInfo>> purchaseOrders = new SortedList<int, List<APPurchaseOrderItemsInfo>>();
            if (objPurchaseOrderInfo != null)
            {
                /* Trừ dần từ trên xuống dưới theo PurchaseOrderID */
                /* Tạo mới từ DMH đã check cùng DMH => 1 NKMG tạo từ 1 DMH duy nhất */
                List<APPurchaseOrderItemsInfo> purchaseOrderItems = objPurchaseOrderItemsController.GetPurchaseOrderItemsByPurchaseOrderID(objPurchaseOrderInfo.APPurchaseOrderID);
                if (purchaseOrderItems != null && purchaseOrderItems.Count > 0)
                {
                    foreach (ICReceiptItemsInfo receiptItem in ReceiptItemsList)
                    {
                        //List<APPurchaseOrderItemsInfo> matchPOItems = purchaseOrderItems.Where(i => i.FK_ICProductID == receiptItem.FK_ICProductID).ToList();
                        List<APPurchaseOrderItemsInfo> matchPOItems = purchaseOrderItems.Where(i => i.APPurchaseOrderItemID == receiptItem.FK_APPurchaseOrderItemID).ToList();

                        decimal receiptQty = receiptItem.ICReceiptItemProductQty;
                        decimal receiptWoodQty = receiptItem.ICReceiptItemWoodQty;
                        foreach (APPurchaseOrderItemsInfo poItem in matchPOItems)
                        {
                            decimal poRemainQty = poItem.APPurchaseOrderItemProductQty - poItem.APPurchaseOrderItemReceiptedQty;
                            decimal poReceiptQty = receiptQty;
                            //decimal poReceiptQty = Math.Min(poRemainQty, receiptQty);

                            decimal poRemainWoodQty = poItem.APPurchaseOrderItemWoodQty - poItem.APPurchaseOrderItemQty3;
                            decimal poReceiptWoodQty = receiptWoodQty;
                            //decimal poReceiptWoodQty = Math.Min(poRemainWoodQty, receiptWoodQty);

                            poItem.APPurchaseOrderItemReceiptedQty += poReceiptQty;
                            poItem.APPurchaseOrderItemQty3 += poReceiptWoodQty;

                            objPurchaseOrderItemsController.UpdateObject(poItem);

                            receiptQty -= poReceiptQty;
                            if (!(receiptQty > 0))
                            {
                                break;
                            }
                        }
                    }
                }

                /* Cập nhật trạng thái DMH:
                 *       receipt hết số lượng => Complete 
                 *       receipt chưa hết     => Incomplete 
                 */

                bool isReceipted = true;
                foreach (APPurchaseOrderItemsInfo poItem in purchaseOrderItems)
                {
                    decimal remainQty = poItem.APPurchaseOrderItemProductQty - poItem.APPurchaseOrderItemReceiptedQty;
                    if (remainQty > 0)
                    {
                        isReceipted = false;
                        break;
                    }
                }

                if (isReceipted)
                {
                    objPurchaseOrderInfo.APPurchaseOrderStatus = PurchaseOrderStatus.Completed.ToString();
                    objPurchaseOrdersController.UpdateObject(objPurchaseOrderInfo);
                }
                else
                {
                    objPurchaseOrderInfo.APPurchaseOrderStatus = PurchaseOrderStatus.Incompleted.ToString();
                    objPurchaseOrdersController.UpdateObject(objPurchaseOrderInfo);
                }

                #region Original Code

                //ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
                //foreach (ICReceiptItemsInfo receiptItem in ReceiptItemsList)
                //{
                //    APPurchaseOrderItemsInfo purchaseOrderItem = (APPurchaseOrderItemsInfo)objPurchaseOrderItemsController.GetObjectByID(receiptItem.FK_APPurchaseOrderItemID);
                //    if (purchaseOrderItem != null)
                //    {
                //        if (purchaseOrderItem.APPurchaseOrderItemProductQty >= purchaseOrderItem.APPurchaseOrderItemReceiptedQty)
                //            purchaseOrderItem.APPurchaseOrderItemRemainedQty = purchaseOrderItem.APPurchaseOrderItemProductQty - purchaseOrderItem.APPurchaseOrderItemReceiptedQty;
                //        List<ICReceiptItemsInfo> receiptedItemList = new List<ICReceiptItemsInfo>();
                //        receiptedItemList = objReceiptItemsController.GetAllDataByPurchaseOrderItemID(receiptItem.FK_APPurchaseOrderItemID);

                //        decimal receiptedTotalQty = receiptedItemList.Sum(x => x.ICReceiptItemProductQty);
                //        // decimal receiptedTotalBlock = receiptedItemList.Sum(x => x.ICReceiptItemProductBlock);
                //        if (purchaseOrderItem != null)
                //        {

                //            //Decrease purchase order quantity                                
                //            TransactionUtil.UpdateInventoryStock(
                //                                                receiptItem.FK_ICProductID,
                //                                                purchaseOrderItem.FK_ICStockID,
                //                                                Math.Min(purchaseOrderItem.APPurchaseOrderItemRemainedQty, receiptItem.ICReceiptItemProductQty),
                //                                                TransactionUtil.cstInventoryShipment);
                //            purchaseOrderItem.APPurchaseOrderItemReceiptedQty = receiptedTotalQty;
                //            purchaseOrderItem.APPurchaseOrderItemRemainedQty = purchaseOrderItem.APPurchaseOrderItemProductQty - purchaseOrderItem.APPurchaseOrderItemReceiptedQty;
                //            //purchaseOrderItem.APPurchaseOrderItemQty3 = receiptedTotalBlock;
                //            objPurchaseOrderItemsController.UpdateObject(purchaseOrderItem);
                //        }

                //        //Update batch product plan
                //        //UpdateBatchProductPlanItemStatusAndQty(receiptItem.Id);

                //        //ICReceiptItemsInfo objReceiptItemsInfo = (ICReceiptItemsInfo)objReceiptItemsController.GetObjectByID(receiptItem.Id);
                //        //if (objReceiptItemsInfo != null)
                //        //{
                //        //    int BatchProductPlanID = 0;
                //        //    if (objReceiptItemsInfo.FK_MMBatchProductPlanWoodID > 0)
                //        //    {
                //        //        MMBatchProductPlanWoodsController objBatchProductPlanWoodsController = new MMBatchProductPlanWoodsController();
                //        //        MMBatchProductPlanWoodsInfo objBatchProductPlanWoodsInfo = (MMBatchProductPlanWoodsInfo)objBatchProductPlanWoodsController.GetObjectByID(objReceiptItemsInfo.FK_MMBatchProductPlanWoodID);
                //        //        if (objBatchProductPlanWoodsInfo != null)
                //        //            BatchProductPlanID = objBatchProductPlanWoodsInfo.FK_MMBatchProductPlanID;
                //        //    }

                //        //    UpdateBatchProductPlan(BatchProductPlanID);
                //        //}
                //    }
                //}

                //Update purchase order's status
                //foreach (int purchaseOrderID in purchaseOrders.Keys)
                //{
                //    bool isRemained = false;
                //    foreach (APPurchaseOrderItemsInfo objPurchaseOrderItemsInfo in purchaseOrders[purchaseOrderID])
                //    {
                //        if (objPurchaseOrderItemsInfo.FK_APPurchaseOrderID == purchaseOrderID && (objPurchaseOrderItemsInfo.APPurchaseOrderItemProductQty - objPurchaseOrderItemsInfo.APPurchaseOrderItemReceiptedQty > 0))
                //        {
                //            isRemained = true;
                //            break;
                //        }
                //    }

                //    APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByID(purchaseOrderID);
                //    if (objPurchaseOrdersInfo != null)
                //    {
                //        if (!isRemained)
                //        {
                //            objPurchaseOrdersInfo.APPurchaseOrderStatus = PurchaseOrderStatus.Completed.ToString();
                //            objPurchaseOrdersController.UpdateObject(objPurchaseOrdersInfo);
                //        }
                //        else
                //        {
                //            objPurchaseOrdersInfo.APPurchaseOrderStatus = PurchaseOrderStatus.Incompleted.ToString();
                //            objPurchaseOrdersController.UpdateObject(objPurchaseOrdersInfo);
                //        }
                //    }
                //}
                #endregion
            }
        }
        public override bool CompleteTransaction()
        {
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            //Update status of stock receipt
            ICReceiptsInfo receipt = (ICReceiptsInfo)MainObject;


            //Update status of stock receipt
            receipt.ICReceiptStatus = ReceiptStatus.Complete.ToString();
            UpdateMainObject();

            //Update the reference invoice
            if (!string.IsNullOrEmpty(receipt.ICReceiptReference))
            {
                if (receipt.FK_APPurchaseOrderID == 0)
                    UpdateReferenceInvoice();
                else
                    UpdateReferencePurchaseOrder();
            }

            InvalidateItemComponents();
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();

            //Generate product series
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

                        if (item.ICReceiptItemWoodQty != 0)
                        {
                            objProductSeriesInfo.ICProductSerieBlockPerOne = item.ICReceiptItemProductQty / item.ICReceiptItemWoodQty;
                            objProductSeriesController.UpdateObject(objProductSeriesInfo);
                        }
                    }
                }
            }

            ReceiptItemsList.SaveItemObjects();

            UpdateModuleObjectsBindingSource();
            return true;
        }

        /// <summary>
        /// Update the reference invoice that the receipt has been created from
        /// </summary>
        private void UpdateReferenceInvoice()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            APInvoiceInsController objInvoicesController = new APInvoiceInsController();
            APInvoiceInItemsController objInvoiceItemsController = new APInvoiceInItemsController();
            APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
            APInvoiceInsInfo objInvoicesInfo = (APInvoiceInsInfo)objInvoicesController.GetObjectByNo(objReceiptsInfo.ICReceiptReference);
            SortedList<int, List<APPurchaseOrderItemsInfo>> purchaseOrders = new SortedList<int, List<APPurchaseOrderItemsInfo>>();
            if (objInvoicesInfo != null)
            {
                /* Trừ dần từ trên xuống theo APInvoiceInID */
                /* 1 NKMG tạo từ 1 HDMH duy nhất */
                APInvoiceInItemsController objInvoiceInItemsController = new APInvoiceInItemsController();
                List<APInvoiceInItemsInfo> invoiceInItems = objInvoiceInItemsController.GetItemsByInvoiceID(objInvoicesInfo.APInvoiceInID);
                APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
                if (invoiceInItems != null && invoiceInItems.Count > 0)
                {
                    foreach (ICReceiptItemsInfo receiptItem in ReceiptItemsList)
                    {
                        List<APInvoiceInItemsInfo> matchInvoiceInItems = invoiceInItems.Where(i => i.FK_ICProductID == receiptItem.FK_ICProductID && i.APInvoiceInItemProductHeight == receiptItem.ICReceiptItemProductHeight).ToList();

                        if (matchInvoiceInItems != null && matchInvoiceInItems.Count > 0)
                        {
                            decimal receiptQty = receiptItem.ICReceiptItemProductQty;
                            decimal receiptWoodQty = receiptItem.ICReceiptItemWoodQty;

                            foreach (APInvoiceInItemsInfo invoiceItem in matchInvoiceInItems)
                            {
                                decimal remainQty = invoiceItem.APInvoiceInItemProductQty - invoiceItem.APInvoiceInItemReceiptedQty;
                                decimal remainWoodQty = invoiceItem.APInvoiceInItemWoodQty - invoiceItem.APInvoiceInItemQty1;

                                decimal iiReceiptQty = Math.Min(remainQty, receiptQty);
                                decimal iiReceiptWoodQty = Math.Min(remainWoodQty, receiptWoodQty);
                                invoiceItem.APInvoiceInItemReceiptedQty += iiReceiptQty;
                                invoiceItem.APInvoiceInItemQty1 += iiReceiptWoodQty;

                                objInvoiceInItemsController.UpdateObject(invoiceItem);

                                /* cập nhật PO liên quan */

                                if (invoiceItem.FK_APPurchaseOrderItemID > 0)
                                {
                                    if (!purchaseOrders.ContainsKey(invoiceItem.FK_APPurchaseOrderID))
                                    {
                                        List<APPurchaseOrderItemsInfo> purchaseOrderItems = objPurchaseOrderItemsController.GetPurchaseOrderItemsByPurchaseOrderID(invoiceItem.FK_APPurchaseOrderID);
                                        purchaseOrders.Add(invoiceItem.FK_APPurchaseOrderID, purchaseOrderItems);
                                    }
                                    foreach (int purchaseOrderID in purchaseOrders.Keys)
                                    {
                                        foreach (APPurchaseOrderItemsInfo objPurchaseOrderItemsInfo in purchaseOrders[purchaseOrderID])
                                        {
                                            if (objPurchaseOrderItemsInfo.APPurchaseOrderItemID == invoiceItem.FK_APPurchaseOrderItemID)
                                            {
                                                objPurchaseOrderItemsInfo.APPurchaseOrderItemReceiptedQty += iiReceiptQty;
                                                objPurchaseOrderItemsInfo.APPurchaseOrderItemQty3 += iiReceiptWoodQty;
                                                objPurchaseOrderItemsController.UpdateObject(objPurchaseOrderItemsInfo);
                                            }
                                        }
                                    }
                                }

                                /* Cập nhật trạng thái PO */

                                foreach (int purchaseOrderID in purchaseOrders.Keys)
                                {
                                    APPurchaseOrdersInfo objPurchaseOrderInfo = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByID(purchaseOrderID);

                                    bool isReceipted = true;
                                    foreach (APPurchaseOrderItemsInfo objPurchaseOrderItemsInfo in purchaseOrders[purchaseOrderID])
                                    {

                                        decimal remainQtyx = objPurchaseOrderItemsInfo.APPurchaseOrderItemProductQty - objPurchaseOrderItemsInfo.APPurchaseOrderItemReceiptedQty;
                                        if (remainQtyx > 0)
                                        {
                                            isReceipted = false;
                                            break;
                                        }
                                    }

                                    if (isReceipted)
                                    {
                                        objPurchaseOrderInfo.APPurchaseOrderStatus = PurchaseOrderStatus.Completed.ToString();
                                        objPurchaseOrdersController.UpdateObject(objPurchaseOrderInfo);
                                    }
                                    else
                                    {
                                        objPurchaseOrderInfo.APPurchaseOrderStatus = PurchaseOrderStatus.Incompleted.ToString();
                                        objPurchaseOrdersController.UpdateObject(objPurchaseOrderInfo);
                                    }
                                }
                                receiptQty -= iiReceiptQty;
                                receiptWoodQty -= iiReceiptWoodQty;

                                if ((!(receiptQty > 0)))
                                {
                                    break;
                                }
                            }
                        }
                    }

                    /* Cập nhật trạng thái InvoiceIn */
                    bool isReceipt = true;
                    foreach (APInvoiceInItemsInfo invoiceInItem in invoiceInItems)
                    {
                        decimal remainQty = invoiceInItem.APInvoiceInItemProductQty - invoiceInItem.APInvoiceInItemReceiptedQty;
                        if (remainQty > 0)
                        {
                            isReceipt = false;
                            break;
                        }
                    }

                    if (isReceipt)
                    {
                        objInvoicesInfo.APInvoiceInStatus = InvoiceInStatus.Completed.ToString();
                        objInvoicesController.UpdateObject(objInvoicesInfo);
                    }
                    else
                    {
                        objInvoicesInfo.APInvoiceInStatus = InvoiceInStatus.Incompleted.ToString();
                        objInvoicesController.UpdateObject(objInvoicesInfo);
                    }
                }
            }
            #region Original Code
            //    APInvoiceInItemsController objInvoiceInItemsController = new APInvoiceInItemsController();
            //    ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            //    foreach (ICReceiptItemsInfo receiptItem in ReceiptItemsList)
            //    {
            //        APInvoiceInItemsInfo invoiceItem = (APInvoiceInItemsInfo)objInvoiceInItemsController.GetObjectByID(receiptItem.FK_APInvoiceInItemID);
            //        if (invoiceItem != null)
            //        {
            //            if (invoiceItem.APInvoiceInItemProductQty >= invoiceItem.APInvoiceInItemReceiptedQty)
            //                invoiceItem.APInvoiceInItemRemainedQty = invoiceItem.APInvoiceInItemProductQty - invoiceItem.APInvoiceInItemReceiptedQty;
            //            List<ICReceiptItemsInfo> receiptedItemList = new List<ICReceiptItemsInfo>();
            //            receiptedItemList = objReceiptItemsController.GetAllDataByInvoiceInItemID(receiptItem.FK_APInvoiceInItemID);

            //            decimal receiptedTotalQty = receiptedItemList.Sum(x => x.ICReceiptItemProductQty);
            //            decimal receiptedWoodQty = receiptedItemList.Sum(x => x.ICReceiptItemWoodQty);
            //            if (invoiceItem != null)
            //            {
            //                //Decrease transit-in quantity                        
            //                TransactionUtil.UpdateInventoryStock(
            //                                                receiptItem.FK_ICProductID,
            //                                                invoiceItem.FK_ICStockID,
            //                                                receiptItem.ICReceiptItemProductQty,
            //                                                TransactionUtil.cstInventoryShipment);
            //                invoiceItem.APInvoiceInItemReceiptedQty += receiptedTotalQty;
            //                invoiceItem.APInvoiceInItemQty1 += receiptedWoodQty;
            //                if (invoiceItem.APInvoiceInItemProductQty > invoiceItem.APInvoiceInItemReceiptedQty)
            //                    invoiceItem.APInvoiceInItemRemainedQty = invoiceItem.APInvoiceInItemProductQty - invoiceItem.APInvoiceInItemReceiptedQty;
            //                else
            //                    invoiceItem.APInvoiceInItemRemainedQty = 0;
            //                if (!invoiceItem.IsSubItem)
            //                {
            //                    objInvoiceInItemsController.UpdateObject(invoiceItem);
            //                }

            //                if (invoiceItem.FK_APPurchaseOrderItemID > 0)
            //                {
            //                    APPurchaseOrderItemsInfo objPurchaseOrderItemsInfo = (APPurchaseOrderItemsInfo)objPurchaseOrderItemsController.GetObjectByID(invoiceItem.FK_APPurchaseOrderItemID);
            //                    if (objPurchaseOrderItemsInfo != null)
            //                    {
            //                        List<APInvoiceInItemsInfo> listInvoiceInItem = objInvoiceInItemsController.GetItemsByPurchaseOrderItemID(objPurchaseOrderItemsInfo.APPurchaseOrderItemID);
            //                        if (listInvoiceInItem != null)
            //                        {
            //                            receiptedTotalQty = listInvoiceInItem.Sum(x => x.APInvoiceInItemReceiptedQty);
            //                            receiptedWoodQty = listInvoiceInItem.Sum(x => x.APInvoiceInItemQty1);
            //                            //Decrease purchase order quantity                                
            //                            TransactionUtil.UpdateInventoryStock(
            //                                                                receiptItem.FK_ICProductID,
            //                                                                objPurchaseOrderItemsInfo.FK_ICStockID,
            //                                                                receiptItem.ICReceiptItemProductQty,
            //                                                                TransactionUtil.cstInventoryShipment);
            //                            objPurchaseOrderItemsInfo.APPurchaseOrderItemReceiptedQty += receiptedTotalQty;
            //                            objPurchaseOrderItemsInfo.APPurchaseOrderItemQty3 += receiptedWoodQty;

            //                            objPurchaseOrderItemsInfo.APPurchaseOrderItemRemainedQty = objPurchaseOrderItemsInfo.APPurchaseOrderItemProductQty - objPurchaseOrderItemsInfo.APPurchaseOrderItemReceiptedQty;

            //                            objPurchaseOrderItemsController.UpdateObject(objPurchaseOrderItemsInfo);

            //                        }
            //                        if (!purchaseOrders.ContainsKey(invoiceItem.FK_APPurchaseOrderID))
            //                        {
            //                            List<APPurchaseOrderItemsInfo> purchaseOrderItems = objPurchaseOrderItemsController.GetPurchaseOrderItemsByPurchaseOrderID(invoiceItem.FK_APPurchaseOrderID);
            //                            purchaseOrderItems.ForEach(i => i.APPurchaseOrderItemRemainedQty = i.APPurchaseOrderItemProductQty - i.APPurchaseOrderItemReceiptedQty);
            //                            purchaseOrders.Add(invoiceItem.FK_APPurchaseOrderID, purchaseOrderItems);
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }

            //    //Update invoice status
            //    APInvoiceInsController objInvoiceInsController = new APInvoiceInsController();
            //    APInvoiceInsInfo objInvoiceInsInfo = (APInvoiceInsInfo)objInvoiceInsController.GetObjectByID(objInvoicesInfo.APInvoiceInID);
            //    if (objInvoiceInsInfo != null)
            //    {
            //        List<APInvoiceInItemsInfo> invoiceItems = objInvoiceInItemsController.GetComponentItemsByInvoiceInID(objInvoicesInfo.APInvoiceInID);
            //        if (invoiceItems != null)
            //        {
            //            bool isRemained = false;
            //            foreach (APInvoiceInItemsInfo invoiceItem in invoiceItems)
            //            {
            //                if (invoiceItem.APInvoiceInItemWoodQty != 0 &&
            //                    invoiceItem.APInvoiceInItemWoodQty - invoiceItem.APInvoiceInItemQty1 > 0)
            //                {
            //                    isRemained = true;
            //                    break;
            //                }
            //                else if (invoiceItem.APInvoiceInItemProductQty - invoiceItem.APInvoiceInItemReceiptedQty > 0)
            //                {
            //                    isRemained = true;
            //                    break;
            //                }
            //            }

            //            if (isRemained)
            //            {
            //                objInvoiceInsInfo.APInvoiceInStatus = InvoiceInStatus.Incompleted.ToString();
            //                objInvoiceInsController.UpdateObject(objInvoiceInsInfo);
            //            }
            //            else
            //            {
            //                objInvoiceInsInfo.APInvoiceInStatus = InvoiceInStatus.Completed.ToString();
            //                objInvoiceInsController.UpdateObject(objInvoiceInsInfo);
            //            }
            //        }
            //    }

            //    //Update purchase order's status
            //    foreach (int purchaseOrderID in purchaseOrders.Keys)
            //    {
            //        bool isRemained = false;
            //        foreach (APPurchaseOrderItemsInfo objPurchaseOrderItemsInfo in purchaseOrders[purchaseOrderID])
            //        {
            //            if (objPurchaseOrderItemsInfo.FK_APPurchaseOrderID == purchaseOrderID && (objPurchaseOrderItemsInfo.APPurchaseOrderItemProductQty - objPurchaseOrderItemsInfo.APPurchaseOrderItemPackagedQty > 0))
            //            {
            //                isRemained = true;
            //                break;
            //            }

            //        }

            //        APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
            //        APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByID(purchaseOrderID);
            //        if (objPurchaseOrdersInfo != null)
            //        {
            //            if (!isRemained)
            //            {
            //                objPurchaseOrdersInfo.APPurchaseOrderStatus = PurchaseOrderStatus.Completed.ToString();
            //                objPurchaseOrdersController.UpdateObject(objPurchaseOrdersInfo);
            //            }
            //            else
            //            {
            //                objPurchaseOrdersInfo.APPurchaseOrderStatus = PurchaseOrderStatus.Incompleted.ToString();
            //                objPurchaseOrdersController.UpdateObject(objPurchaseOrdersInfo);
            //            }
            //        }
            //    }
            //}
            #endregion
        }
        public void UpdateBatchProductPlanWoodStatusAndQty(int batchProductPlanWoodID, decimal receiptedQty)
        {
            MMBatchProductPlanWoodsController objBatchProductPlanWoodsController = new MMBatchProductPlanWoodsController();
            MMBatchProductPlanWoodsInfo objBatchProductPlanWoodsInfo = (MMBatchProductPlanWoodsInfo)objBatchProductPlanWoodsController.GetObjectByID(batchProductPlanWoodID);
            if (objBatchProductPlanWoodsInfo != null)
            {
                if (receiptedQty > 0)
                {
                    objBatchProductPlanWoodsInfo.MMBatchProductPlanWoodReceiptQty = receiptedQty;
                    if (objBatchProductPlanWoodsInfo.MMBatchProductPlanWoodReceiptQty >= objBatchProductPlanWoodsInfo.MMBatchProductPlanWoodBuyTotalQuantity)
                        objBatchProductPlanWoodsInfo.MMBatchProductPlanWoodProposalStatus = BatchProductItemPlanStatus.Completed.ToString();
                    else if (objBatchProductPlanWoodsInfo.MMBatchProductPlanWoodReceiptQty < objBatchProductPlanWoodsInfo.MMBatchProductPlanWoodBuyTotalQuantity)
                    {
                        objBatchProductPlanWoodsInfo.MMBatchProductPlanWoodProposalStatus = BatchProductItemPlanStatus.InComplete.ToString();
                    }

                    objBatchProductPlanWoodsController.UpdateObject(objBatchProductPlanWoodsInfo);
                }
            }
        }
        public void UpdateBatchProductPlan(int batchProductPlanID)
        {
            MMBatchProductPlansController objBatchProductPlansController = new MMBatchProductPlansController();
            MMBatchProductPlansInfo objBatchProductPlansInfo = (MMBatchProductPlansInfo)objBatchProductPlansController.GetObjectByID(batchProductPlanID);
            if (objBatchProductPlansInfo != null)
            {
                MMBatchProductPlanHWsController objBatchProductPlanHWsController = new MMBatchProductPlanHWsController();
                MMBatchProductPlanPackagingsController objBatchProductPlanPackagingsController = new MMBatchProductPlanPackagingsController();
                MMBatchProductPlanPaintsController objBatchProductPlanPaintsController = new MMBatchProductPlanPaintsController();
                MMBatchProductPlanInstrumentsController objBatchProductPlanInstrumentsController = new MMBatchProductPlanInstrumentsController();
                MMBatchProductPlanWoodsController objBatchProductPlanWoodsController = new MMBatchProductPlanWoodsController();

                DataSet dsHW = objBatchProductPlanHWsController.GetAllDataByForeignColumn("FK_MMBatchProductPlanID", batchProductPlanID);
                DataSet dsPK = objBatchProductPlanPackagingsController.GetAllDataByForeignColumn("FK_MMBatchProductPlanID", batchProductPlanID);
                DataSet dsPA = objBatchProductPlanPaintsController.GetAllDataByForeignColumn("FK_MMBatchProductPlanID", batchProductPlanID);
                DataSet dsIST = objBatchProductPlanInstrumentsController.GetAllDataByForeignColumn("FK_MMBatchProductPlanID", batchProductPlanID);
                DataSet dsWood = objBatchProductPlanWoodsController.GetAllDataByForeignColumn("FK_MMBatchProductPlanID", batchProductPlanID);

                List<MMBatchProductPlanInstrumentsInfo> BatchProductPlanInstrumentList = (List<MMBatchProductPlanInstrumentsInfo>)objBatchProductPlanInstrumentsController.GetListFromDataSet(dsIST);
                List<MMBatchProductPlanPaintsInfo> BatchProductPlanPaintList = (List<MMBatchProductPlanPaintsInfo>)objBatchProductPlanPaintsController.GetListFromDataSet(dsPA);
                List<MMBatchProductPlanPackagingsInfo> BatchProductPlanPackagingList = (List<MMBatchProductPlanPackagingsInfo>)objBatchProductPlanPackagingsController.GetListFromDataSet(dsPK);
                List<MMBatchProductPlanHWsInfo> BatchProductPlanHWList = (List<MMBatchProductPlanHWsInfo>)objBatchProductPlanHWsController.GetListFromDataSet(dsHW);
                List<MMBatchProductPlanWoodsInfo> BatchProductPlanWoodList = (List<MMBatchProductPlanWoodsInfo>)objBatchProductPlanWoodsController.GetListFromDataSet(dsWood);
                bool IsFullHWCompleted = true;
                bool IsFullPackagingCompleted = true;
                bool IsFullPaintCompleted = true;
                bool IsFullInstrumentCompleted = true;
                bool IsFullWoodCompleted = true;

                if (BatchProductPlanWoodList != null)
                {
                    List<MMBatchProductPlanWoodsInfo> BatchProductPlanWoodListCheck = BatchProductPlanWoodList.Where(x => x.MMBatchProductPlanWoodReceiptQty < x.MMBatchProductPlanWoodBuyTotalQuantity).ToList();
                    if (BatchProductPlanWoodListCheck != null && BatchProductPlanWoodListCheck.Count > 0)
                        IsFullWoodCompleted = false;
                }
                if (BatchProductPlanHWList != null)
                {
                    List<MMBatchProductPlanHWsInfo> BatchProductPlanHWListCheck = BatchProductPlanHWList.Where(x => x.MMBatchProductPlanReceiptQty < x.MMBatchProductPlanHWBuyTotalQuantity).ToList();
                    if (BatchProductPlanHWListCheck != null && BatchProductPlanHWListCheck.Count > 0)
                        IsFullHWCompleted = false;
                }


                if (BatchProductPlanPackagingList != null)
                {
                    List<MMBatchProductPlanPackagingsInfo> BatchProductPlanPackagingListCheck = BatchProductPlanPackagingList.Where(x => x.MMBatchProductPlanReceiptQty < x.MMBatchProductPlanPackagingBuyTotalQuantity).ToList();
                    if (BatchProductPlanPackagingListCheck != null && BatchProductPlanPackagingListCheck.Count > 0)
                        IsFullPackagingCompleted = false;
                }

                if (BatchProductPlanPaintList != null)
                {
                    List<MMBatchProductPlanPaintsInfo> BatchProductPlanPaintListCheck = BatchProductPlanPaintList.Where(x => x.MMBatchProductPlanReceiptQty < x.MMBatchProductPlanPaintBuyTotalQuantity).ToList();
                    if (BatchProductPlanPaintListCheck != null && BatchProductPlanPaintListCheck.Count > 0)
                        IsFullPaintCompleted = false;
                }

                if (BatchProductPlanInstrumentList != null)
                {
                    List<MMBatchProductPlanInstrumentsInfo> BatchProductPlanInstrumentListCheck = BatchProductPlanInstrumentList.Where(x => x.MMBatchProductPlanReceiptQty < x.MMBatchProductPlanInstrumentBuyTotalQuantity).ToList();
                    if (BatchProductPlanInstrumentListCheck != null && BatchProductPlanInstrumentListCheck.Count > 0)
                        IsFullInstrumentCompleted = false;
                }

                if (IsFullHWCompleted && IsFullPackagingCompleted && IsFullPaintCompleted && IsFullInstrumentCompleted && IsFullWoodCompleted)
                    objBatchProductPlansInfo.MMBatchProductPlanStatus = BatchProductPlanProposalStatus.Completed.ToString();
                else
                    objBatchProductPlansInfo.MMBatchProductPlanStatus = BatchProductPlanProposalStatus.InComplete.ToString();
                objBatchProductPlansController.UpdateObject(objBatchProductPlansInfo);
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
            return ReceiptItemsList.IsInvalidInventory(TransactionUtil.cstInventoryReceipt);
        }
        #endregion

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            SetValuesAfterValidateProduct(iICProductID, ModuleObjects[TableName.ICReceiptItemsTableName]);
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            ICReceiptItemsInfo objReceiptItemsInfo = (ICReceiptItemsInfo)ModuleObjects[TableName.ICReceiptItemsTableName];
            if (objReceiptsInfo != null && objReceiptItemsInfo != null)
            {
                objReceiptItemsInfo.FK_GECountryID = objReceiptsInfo.FK_GECountryID;
                objReceiptItemsInfo.FK_ICProductAttributeTTMTID = objReceiptsInfo.FK_ICProductAttributeTTMTID;
                //objReceiptItemsInfo.FK_ADMatchCodeIDPaintType = objReceiptsInfo.FK_ADMatchCodeIDPaintType;
            }
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
                receiptItem.ICReceiptItemProductLength = objProductsInfo.ICProductLength;
                //NN GIANG ADD AccountID WITH PRODUCT - START - 25-04-2016
                receiptItem.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                //NN GIANG ADD AccountID WITH PRODUCT - END - 25-04-2016
                //receiptItem.ICReceiptItemProductPerimeter = objProductsInfo.ICProductPerimeter;
            }
        }

        /// <summary>
        /// Set receipt item entity after validate product
        /// </summary>
        /// <param name="productID">Product id</param>
        /// <returns>WoodPurchaseReceipt item entity</returns>
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
        /// Generate main object, module object, module object list from an invoice
        /// </summary>
        /// <param name="objInvoiceInsInfo">Given invoice</param>
        public void GenerateEntityFromInvoice(APInvoiceInsInfo objInvoiceInsInfo, List<APInvoiceInItemsInfo> invoiceItems)
        {
            //Copy receipt
            ICReceiptsInfo receipt = (ICReceiptsInfo)MainObject;
            ICReceiptsInfo oldReceipt = (ICReceiptsInfo)receipt.Clone();
            BOSUtil.CopyObject(objInvoiceInsInfo, receipt);
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            //Restore some its own properties
            receipt.ICReceiptNo = oldReceipt.ICReceiptNo;
            receipt.ICReceiptName = oldReceipt.ICReceiptName;
            receipt.ICReceiptTypeCombo = oldReceipt.ICReceiptTypeCombo;
            receipt.ICReceiptStatus = oldReceipt.ICReceiptStatus;
            receipt.FK_ICStockID = oldReceipt.FK_ICStockID;
            receipt.ICReceiptDate = oldReceipt.ICReceiptDate;
            receipt.ICReceiptDeliveryDate = oldReceipt.ICReceiptDeliveryDate;
            receipt.ICReceiptValidateDate = oldReceipt.ICReceiptValidateDate;
            receipt.ICReceiptDesc = oldReceipt.ICReceiptDesc;
            receipt.ICReceiptReference = objInvoiceInsInfo.APInvoiceInNo;
            receipt.ICReceiptInvoiceInNo = objInvoiceInsInfo.APInvoiceInSupplierNo;
            receipt.ICReceiptInvoiceInDate = objInvoiceInsInfo.APInvoiceInDate;
            receipt.ICReceiptEmployeePicture = oldReceipt.ICReceiptEmployeePicture;
            receipt.ICReceiptPackNo = objInvoiceInsInfo.APInvoiceInPackNo;
            receipt.ICReceiptCreateFrom = "InvoiceIn";
            receipt.ICReceiptReceiptType = objInvoiceInsInfo.APInvoiceInType;
            receipt.FK_GECountryID = objInvoiceInsInfo.FK_GECountryID;
            //TKChinh Add PO No
            receipt.ICReceiptPONo = objInvoiceInsInfo.APInvoiceInReference;
            //Copy item list
            receipt.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;

            foreach (APInvoiceInItemsInfo objInvoiceInItemsInfo in invoiceItems)
            {
                if (objInvoiceInItemsInfo.APInvoiceInItemProductQty - objInvoiceInItemsInfo.APInvoiceInItemReceiptedQty >= 0)
                {
                    receipt.FK_APPurchaseContractID = objInvoiceInItemsInfo.FK_APPurchaseContractID;
                    ICReceiptItemsInfo objReceiptItemsInfo = new ICReceiptItemsInfo();
                    BOSUtil.CopyObject(objInvoiceInItemsInfo, objReceiptItemsInfo);
                    if (objReceiptItemsInfo.FK_ICProductID > 0)
                    {
                        objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objReceiptItemsInfo.FK_ICProductID);
                    }
                    objReceiptItemsInfo.FK_ICStockID = receipt.FK_ICStockID;
                    objReceiptItemsInfo.ICReceiptItemProductQty = objInvoiceInItemsInfo.APInvoiceInItemProductQty - objInvoiceInItemsInfo.APInvoiceInItemReceiptedQty;
                    if (objInvoiceInItemsInfo.APInvoiceInItemWoodQty > objInvoiceInItemsInfo.APInvoiceInItemQty1)
                        objReceiptItemsInfo.ICReceiptItemWoodQty = objInvoiceInItemsInfo.APInvoiceInItemWoodQty - objInvoiceInItemsInfo.APInvoiceInItemQty1;

                    objReceiptItemsInfo.FK_APInvoiceInID = objInvoiceInItemsInfo.FK_APInvoiceInID;
                    objReceiptItemsInfo.FK_APInvoiceInItemID = objInvoiceInItemsInfo.APInvoiceInItemID;

                    objReceiptItemsInfo.ICReceiptItemProductQtySter = objInvoiceInItemsInfo.APInvoiceInItemProductQtySter;
                    objReceiptItemsInfo.ICReceiptItemProductUnitCostSter = objInvoiceInItemsInfo.APInvoiceInItemProductUnitCostSter;
                    objReceiptItemsInfo.ICReceiptItemTotalCostSter = objInvoiceInItemsInfo.APInvoiceInItemTotalCostSter;

                    if (objProductsInfo != null)
                    {
                        objReceiptItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                        objReceiptItemsInfo.FK_ACAccountID = ((WoodPurchaseReceiptModule)Module).GetAccountByStock(objReceiptItemsInfo.FK_ICStockID, objProductsInfo.FK_ACAccountID);
                    }

                    if (objInvoiceInsInfo.APInvoiceInType == ProductType.Roundwood.ToString() || objInvoiceInsInfo.APInvoiceInType == ProductType.Lumber.ToString())
                    {
                        objReceiptItemsInfo.ICReceiptItemProductDesc = objInvoiceInItemsInfo.APInvoiceInItemProductDesc;
                        objReceiptItemsInfo.ICReceiptItemProductLength = objInvoiceInItemsInfo.APInvoiceInItemProductLength;
                        objReceiptItemsInfo.ICReceiptItemProductWidth = objInvoiceInItemsInfo.APInvoiceInItemProductWidth;
                        objReceiptItemsInfo.ICReceiptItemProductPerimeter = objInvoiceInItemsInfo.APInvoiceInItemProductPerimeter;
                        objReceiptItemsInfo.ICReceiptItemProductHeight = objInvoiceInItemsInfo.APInvoiceInItemProductHeight;
                        objReceiptItemsInfo.ICReceiptItemLogListNo = objInvoiceInItemsInfo.APInvoiceInItemLogListNo;
                        objReceiptItemsInfo.ICReceiptItemProductSerialNo = objInvoiceInItemsInfo.APInvoiceInItemProductSerialNo;
                        if (objProductsInfo != null)
                            objReceiptItemsInfo.FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;

                        objReceiptItemsInfo.FK_ICProductAttributeTTMTID = objInvoiceInItemsInfo.FK_ICProductAttributeTTMTID;
                        objReceiptItemsInfo.ICReceiptItemProductSupplierNo = objInvoiceInItemsInfo.APInvoiceInItemProductSupplierNo;
                        //Reset qty
                        if (receipt.ICReceiptReceiptType == ProductType.Roundwood.ToString())
                        {
                            if (objInvoiceInItemsInfo.APInvoiceInItemProductQty > objInvoiceInItemsInfo.APInvoiceInItemReceiptedQty)
                                objReceiptItemsInfo.ICReceiptItemNotJetExceptBlock = objInvoiceInItemsInfo.APInvoiceInItemProductQty - objInvoiceInItemsInfo.APInvoiceInItemReceiptedQty;
                            else
                                objReceiptItemsInfo.ICReceiptItemNotJetExceptBlock = objInvoiceInItemsInfo.APInvoiceInItemProductQty;
                            objReceiptItemsInfo.ICReceiptItemProductQty = objReceiptItemsInfo.ICReceiptItemNotJetExceptBlock - objReceiptItemsInfo.ICReceiptItemExceptedBlock;
                            receipt.ICReceiptTotalQty = receipt.ICReceiptTotalQty + objReceiptItemsInfo.ICReceiptItemProductQty;
                        }
                        if (objReceiptItemsInfo.ICReceiptItemWoodQty == 0)
                        {
                            objReceiptItemsInfo.ICReceiptItemWoodQty = objInvoiceInItemsInfo.APInvoiceInItemWoodQty;
                        }
                        objReceiptItemsInfo.FK_ICMeasureUnitID = objInvoiceInItemsInfo.FK_ICMeasureUnitID;
                        objReceiptItemsInfo.ICReceiptItemProductFactor = objInvoiceInItemsInfo.APInvoiceInItemProductFactor;
                        objReceiptItemsInfo.ICReceiptItemNotJetExceptBlock = Math.Round(objReceiptItemsInfo.ICReceiptItemNotJetExceptBlock, 4, MidpointRounding.AwayFromZero);
                        objReceiptItemsInfo.ICReceiptItemProductQty = Math.Round(objReceiptItemsInfo.ICReceiptItemProductQty, 4, MidpointRounding.AwayFromZero);
                        receipt.ICReceiptTotalQty = Math.Round(receipt.ICReceiptTotalQty, 4, MidpointRounding.AwayFromZero);
                    }
                    SetProductCostByProductUnitCost(objReceiptItemsInfo);
                    ReceiptItemsList.Add(objReceiptItemsInfo);
                }
            }
            UpdateTotalCost();
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
            }
            return base.SaveAccountingData();
        }
        #endregion

        //TNDLoc [ADD] [20/01/2016] [New From PurchaseOrder],START
        public void GenerateEntityFromPurchaseOrder(APPurchaseOrdersInfo objPurchaseOrdersInfo, List<APPurchaseOrderItemsInfo> purchaseOrderItems)
        {
            //Copy receipt
            ICReceiptsInfo receipt = (ICReceiptsInfo)MainObject;
            ICReceiptsInfo oldReceipt = (ICReceiptsInfo)receipt.Clone();
            BOSUtil.CopyObject(objPurchaseOrdersInfo, receipt);
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            //Restore some its own properties
            receipt.ICReceiptNo = oldReceipt.ICReceiptNo;
            receipt.ICReceiptName = oldReceipt.ICReceiptName;
            receipt.ICReceiptTypeCombo = oldReceipt.ICReceiptTypeCombo;
            receipt.ICReceiptStatus = oldReceipt.ICReceiptStatus;
            receipt.FK_ICStockID = oldReceipt.FK_ICStockID;
            receipt.ICReceiptDate = oldReceipt.ICReceiptDate;
            receipt.ICReceiptDeliveryDate = oldReceipt.ICReceiptDeliveryDate;
            receipt.ICReceiptValidateDate = oldReceipt.ICReceiptValidateDate;
            receipt.ICReceiptDesc = oldReceipt.ICReceiptDesc;
            receipt.ICReceiptReference = objPurchaseOrdersInfo.APPurchaseOrderNo;
            //receipt.ICReceiptInvoiceInNo = objInvoiceInsInfo.APInvoiceInSupplierNo;
            //receipt.ICReceiptInvoiceInDate = objInvoiceInsInfo.APInvoiceInDate;
            receipt.ICReceiptEmployeePicture = oldReceipt.ICReceiptEmployeePicture;
            //receipt.ICReceiptPackNo = objInvoiceInsInfo.APInvoiceInPackNo;

            receipt.ICReceiptReceiptType = objPurchaseOrdersInfo.APPurchaseOrderReceiptTypeCombo;
            receipt.FK_APPurchaseOrderID = objPurchaseOrdersInfo.APPurchaseOrderID;
            receipt.ICReceiptCreateFrom = "PurchaseOrder";
            receipt.ICReceiptPONo = objPurchaseOrdersInfo.APPurchaseOrderNo;
            //Copy item list

            foreach (APPurchaseOrderItemsInfo obj in purchaseOrderItems)
            {
                if (obj.APPurchaseOrderItemProductQty > 0)
                {
                    ICReceiptItemsInfo objReceiptItemsInfo = new ICReceiptItemsInfo();
                    BOSUtil.CopyObject(obj, objReceiptItemsInfo);
                    if (objReceiptItemsInfo.FK_ICProductID > 0)
                    {
                        objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objReceiptItemsInfo.FK_ICProductID);
                    }
                    //ReceiptItemIDMax += 1;
                    //objReceiptItemsInfo.Id = ReceiptItemIDMax;
                    objReceiptItemsInfo.FK_ICStockID = receipt.FK_ICStockID;
                    objReceiptItemsInfo.ICReceiptItemProductQty = obj.APPurchaseOrderItemProductQty;
                    //objReceiptItemsInfo.ICReceiptItemWoodQty <= Người dùng tự nhập ( Vì DMH ko có )
                    objReceiptItemsInfo.FK_APPurchaseOrderItemID = obj.APPurchaseOrderItemID;
                    objReceiptItemsInfo.FK_ICModelID = obj.FK_ICModelID;
                    objReceiptItemsInfo.FK_ICModelDetailID = obj.FK_ICModelDetailID;
                    objReceiptItemsInfo.ICReceiptItemProductDesc = obj.APPurchaseOrderItemProductDesc;
                    objReceiptItemsInfo.ICReceiptItemProductLength = obj.APPurchaseOrderItemProductLenght;
                    objReceiptItemsInfo.ICReceiptItemProductWidth = obj.APPurchaseOrderItemProductWidth;
                    objReceiptItemsInfo.ICReceiptItemWidthMax = obj.APPurchaseOrderItemProductWidthMax;
                    objReceiptItemsInfo.ICReceiptItemProductWidth = obj.APPurchaseOrderItemProductWidth;
                    objReceiptItemsInfo.ICReceiptItemProductHeight = obj.APPurchaseOrderItemProductHeight;
                    objReceiptItemsInfo.ICReceiptItemProductQtySter = obj.APPurchaseOrderItemProductQtySter;
                    objReceiptItemsInfo.ICReceiptItemProductUnitCostSter = obj.APPurchaseOrderItemProductUnitCostSter;
                    objReceiptItemsInfo.ICReceiptItemTotalCostSter = obj.APPurchaseOrderItemTotalCostSter;
                    objReceiptItemsInfo.ICReceiptItemProductSupplierNo = obj.APPurchaseOrderItemProductSupplierNo;
                    if (objProductsInfo != null)
                    {
                        objReceiptItemsInfo.FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
                        objReceiptItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                        objReceiptItemsInfo.FK_ACAccountID = ((WoodPurchaseReceiptModule)Module).GetAccountByStock(objReceiptItemsInfo.FK_ICStockID, objProductsInfo.FK_ACAccountID);
                    }
                    objReceiptItemsInfo.FK_ICProductAttributeTTMTID = obj.FK_ICProductAttributeTTMTID;
                    if (receipt.ICReceiptReceiptType == ProductType.Roundwood.ToString())
                    {
                        if (obj.APPurchaseOrderItemProductQty > obj.APPurchaseOrderItemReceiptedQty)
                            objReceiptItemsInfo.ICReceiptItemNotJetExceptBlock = obj.APPurchaseOrderItemProductQty - obj.APPurchaseOrderItemReceiptedQty;
                        else
                            objReceiptItemsInfo.ICReceiptItemNotJetExceptBlock = obj.APPurchaseOrderItemProductQty;
                        objReceiptItemsInfo.ICReceiptItemProductQty = objReceiptItemsInfo.ICReceiptItemNotJetExceptBlock - objReceiptItemsInfo.ICReceiptItemExceptedBlock;
                        receipt.ICReceiptTotalQty = receipt.ICReceiptTotalQty + objReceiptItemsInfo.ICReceiptItemProductQty;
                    }
                    objReceiptItemsInfo.ICReceiptItemProductFactor = obj.APPurchaseOrderItemProductFactor;
                    objReceiptItemsInfo.FK_ICMeasureUnitID = obj.FK_ICMeasureUnitID;
                    SetProductCostByProductUnitCost(objReceiptItemsInfo);
                    objReceiptItemsInfo.ICReceiptItemNotJetExceptBlock = Math.Round(objReceiptItemsInfo.ICReceiptItemNotJetExceptBlock, 4, MidpointRounding.AwayFromZero);
                    objReceiptItemsInfo.ICReceiptItemProductQty = Math.Round(objReceiptItemsInfo.ICReceiptItemProductQty, 4, MidpointRounding.AwayFromZero);
                    receipt.ICReceiptTotalQty = Math.Round(receipt.ICReceiptTotalQty, 4, MidpointRounding.AwayFromZero);

                    ReceiptItemsList.Add(objReceiptItemsInfo);
                }
            }
            UpdateTotalCost();
        }
        //TNDLoc [ADD] [20/01/2016] [New From PurchaseOrder],END
    }
}
