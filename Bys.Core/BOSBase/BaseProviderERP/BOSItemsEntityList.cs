using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using BOSLib.Interfaces;
using Localization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP
{
    public class BOSItemsEntityList<T> : BOSList<T>
        where T : ERPModuleItemsEntity, new()
    {
        #region Public Properties
        #endregion

        #region Invalidate
        public override void Invalidate(DataSet ds)
        {
            IBusinessController objItemController = BusinessControllerFactory.GetBusinessController(ItemTableName + "Controller");
            this.Clear();

            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    try
                    {
                        BusinessObject objItemInfo = (BusinessObject)objItemController.GetObjectFromDataRow(row);
                        T objT = (T)objItemInfo.Clone();
                        if (objT != null)
                            this.Add(objT);
                        else
                            break;
                    }
                    catch (Exception ex)
                    {
                        if (ex.GetHashCode() == 3925915)
                        {
                            BOSDisposeUtility.DisposeAll(this as IEnumerable, 0, GCCollectionMode.Forced);
                            GC.Collect(0, GCCollectionMode.Forced);
                            MessageBox.Show("Lỗi tràn bộ nhớ, vui lòng tắt bớt ứng dụng, chạy lại hệ thống!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }

            //Invalidate original list same as itself
            OriginalList.Clear();
            BOSDisposeUtility.DisposeAll(OriginalList, 0, GCCollectionMode.Forced);
            foreach (T obj in this)
            {
                T newT = (T)obj.Clone();
                if (newT != null)
                    OriginalList.Add(newT);
                else
                    break;
            }

            //Invalidate backup list same as itself
            BackupList.Clear();
            BOSDisposeUtility.DisposeAll(BackupList, 0, GCCollectionMode.Forced);
            foreach (T obj in this)
            {
                T newT = (T)obj.Clone();
                if (newT != null)
                    BackupList.Add(newT);
                else
                    break;
            }

            if (GridControl != null)
            {
                GridControl.RefreshDataSource();
                if (this.Count > 0)
                {
                    if (CurrentIndex >= 0 && CurrentIndex < Count)
                    {
                        GridViewFocusRow(CurrentIndex);
                    }
                    else
                    {
                        GridViewFocusRow(0);
                    }
                }
                else
                {
                    Entity.InvalidateModuleObject(BusinessObjectFactory.GetBusinessObject(ItemTableName + "Info"));
                }
            }
            BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
        }
        #endregion

        #region Save List
        public override T SaveObjectToList(bool IsNew)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            T objT = (T)Entity.ModuleObjects[ItemTableName].Clone();
            if (IsNew)
            {
                String strPrimaryKey = ItemTableName.Substring(0, ItemTableName.Length - 1) + "ID";
                dbUtil.SetPropertyValue(objT, strPrimaryKey, 0);
                this.Add(objT);
            }
            else
            {
                if (CurrentIndex >= 0)
                    this[CurrentIndex] = objT;
            }
            return objT;
        }
        #endregion

        #region GridControl,GridView event handlers
        protected override void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!IsEndCurrentEdit)
            {
                DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)GridControl.Views[0];
                if (CurrentIndex >= 0)
                {
                    InvalidateItem();
                }
            }
            IsEndCurrentEdit = false;
        }

        public override void GridViewFocusRow(int iRowHandle)
        {
            if (GridView != null)
            {
                if (GridView.FocusedRowHandle == iRowHandle)
                {
                    if (CurrentIndex >= 0)
                    {
                        InvalidateItem();
                    }
                }
                else
                {
                    GridView.FocusedRowHandle = iRowHandle;
                }
            }
        }

        /// <summary>
        /// Invalidate item
        /// </summary>
        private void InvalidateItem()
        {
            //Set item picture
            Entity.InvalidateModuleObject((T)this[CurrentIndex].Clone(), ItemTableName);
        }
        #endregion

        #region Save List, Delete List to database

        public override void SaveItemCDObjects()
        {
            try
            {
                EndCurrentEdit();

                BOSDbUtil dbUtil = new BOSDbUtil();
                String strItemTablePrimaryKey = BOSApp.GetTablePrimaryColumn(ItemTableName);
                IBusinessController objItemsController = BusinessControllerFactory.GetBusinessController(ItemTableName + "Controller");

                foreach (T objT in this)
                {
                    int iItemObjectID = (int)dbUtil.GetPropertyValue(objT, strItemTablePrimaryKey);
                    switch (Relation)
                    {
                        case cstRelationSwitcher:
                            {
                                break;
                            }
                        case cstRelationForeign:
                            {
                                int iParentObjectID = GetParentObjectID();
                                if (iParentObjectID > 0)
                                {
                                    if (dbUtil.GetPropertyValue(objT, ItemTableForeignKey) != null)
                                        dbUtil.SetPropertyValue(objT, ItemTableForeignKey, iParentObjectID);
                                }
                                break;
                            }
                        case cstRelationParent:
                            {
                                break;
                            }
                        case cstRelationNone:
                            {
                                break;
                            }
                    }

                    //Create or update items
                    if (iItemObjectID > 0)
                    {
                        dbUtil.SetPropertyValue(objT, ERPModuleEntities.AAUpdatedUser, BOSApp.CurrentUser);
                        dbUtil.SetPropertyValue(objT, ERPModuleEntities.AAUpdatedDate, DateTime.Now);
                        objItemsController.UpdateObject(objT);
                    }
                    else
                    {
                        dbUtil.SetPropertyValue(objT, ERPModuleEntities.AACreatedUser, BOSApp.CurrentUser);
                        dbUtil.SetPropertyValue(objT, ERPModuleEntities.AACreatedDate, DateTime.Now);
                        iItemObjectID = objItemsController.CreateObject(objT);
                    }
                    dbUtil.SetPropertyValue(objT, strItemTablePrimaryKey, iItemObjectID);
                    Entity.SaveObjectItemRelations(objT);
                }

                //Delete items
                foreach (T objT in OriginalList)
                {
                    int iItemObjectID = (int)dbUtil.GetPropertyValue(objT, strItemTablePrimaryKey);
                    if (iItemObjectID > 0 && !this.Exists(strItemTablePrimaryKey, iItemObjectID))
                    {
                        objItemsController.DeleteObject(iItemObjectID);
                        Entity.DeleteObjectRelations(ItemTableName, iItemObjectID);
                    }
                }
                //Invalidate original list
                OriginalList.Clear();
                foreach (T objT in this)
                    OriginalList.Add((T)objT.Clone());
            }
            catch (Exception e)
            {
                MessageBox.Show("BOSList.SaveItemObjects -" + e.Message, "Bug");
            }
        }
        #endregion

        /// <summary>
        /// Check whether all items of list satisfy inventory conditions.
        /// If exists any invalid item, show status sub screen to confirm user.
        /// </summary>
        /// <param name="updateType">Inventory update type</param>
        public virtual bool IsInvalidInventory(String updateType)
        {
            if (updateType == TransactionUtil.cstInventoryReceipt)
                return false;

            //Merge the item list with its back-up one for merging on-hand quantity
            //between new and old
            BOSDbUtil dbUtil = new BOSDbUtil();
            BOSItemsEntityList<T> mergedItems = (BOSItemsEntityList<T>)this.Clone();

            mergedItems = mergedItems.MergeBySameItems();

            guiInventoryStatus guiInventoryStatus = new guiInventoryStatus();
            guiInventoryStatus.Module = Entity.Module;
            bool isInvalid = false;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> invalidProducts = new List<ICProductsInfo>();

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ProductID", typeof(int)));
            dt.Columns.Add(new DataColumn("StockID", typeof(int)));
            dt.Columns.Add(new DataColumn("SeriaNo", typeof(string)));
            dt.Columns.Add(new DataColumn("ToDate", typeof(DateTime)));
            DataTable dtCheckMinmax = dt.Copy();

            string mainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(Entity.MainObject);
            string mainObjectDatecolumn = mainObjectTableName.Substring(0, mainObjectTableName.Length - 1) + "Date";
            DateTime docDate = Convert.ToDateTime(dbUtil.GetPropertyValue(Entity.MainObject, mainObjectDatecolumn));
            List<ICTransactionsInfo> inventoryList = new List<ICTransactionsInfo>();
            List<ICTransactionsInfo> inventoryCheckMinMaxList = new List<ICTransactionsInfo>();
            foreach (ERPModuleItemsEntity item in mergedItems)
            {
                String tableName = BOSUtil.GetTableNameFromBusinessObject(item);
                int productID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICProductID"));
                int stockID = dbUtil.GetPropertyIntValue(item, "FK_ICStockID");
                string serialNo = dbUtil.GetPropertyStringValue(item, tableName.Substring(0, tableName.Length - 1) + "ProductSerialNo");
                ////decimal itemQty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, tableName.Substring(0, tableName.Length - 1) + "ProductExchangeQty"));
                ////if (itemQty == 0)
                ////    itemQty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, tableName.Substring(0, tableName.Length - 1) + "ProductQty"));
                ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
                if (objProductsInfo.ICProductType != ProductType.Service.ToString() && !objProductsInfo.IsAsset)
                {
                    if (objProductsInfo.ICPriceCalculationMethodMethod == PriceCalculationMethod.Average.ToString()) serialNo = string.Empty;
                    DataRow r = dt.NewRow();
                    r["ProductID"] = productID;
                    r["StockID"] = stockID;
                    r["SeriaNo"] = serialNo;
                    r["ToDate"] = docDate;
                    dt.Rows.Add(r);

                    DataRow rmm = dtCheckMinmax.NewRow();
                    rmm["ProductID"] = productID;
                    rmm["StockID"] = stockID;
                    rmm["SeriaNo"] = string.Empty;
                    rmm["ToDate"] = docDate;
                    dtCheckMinmax.Rows.Add(rmm);
                }
            }
            if(Entity.Module.Name == "InventoryStockCount")
            {
            if (dt.Rows.Count > 0)
                    inventoryList = (new ICTransactionsController()).GetListInventoryStockQtyForInventoryStockCount(dt);
                if (dtCheckMinmax.Rows.Count > 0)
                    inventoryCheckMinMaxList = (new ICTransactionsController()).GetListInventoryStockQtyForInventoryStockCount(dtCheckMinmax);
            }
            else
            {
                if (dt.Rows.Count > 0)
                inventoryList = (new ICTransactionsController()).GetListInventoryStockQty(dt);
            if (dtCheckMinmax.Rows.Count > 0)
                inventoryCheckMinMaxList = (new ICTransactionsController()).GetListInventoryStockQty(dtCheckMinmax);
            }
            foreach (ERPModuleItemsEntity item in mergedItems)
            {
                String tableName = BOSUtil.GetTableNameFromBusinessObject(item);
                int productID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICProductID"));
                int stockID = dbUtil.GetPropertyIntValue(item, "FK_ICStockID");
                string serialNo = dbUtil.GetPropertyStringValue(item, tableName.Substring(0, tableName.Length - 1) + "ProductSerialNo");
                decimal itemQty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, tableName.Substring(0, tableName.Length - 1) + "ProductExchangeQty"));
                if (itemQty == 0)
                    itemQty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, tableName.Substring(0, tableName.Length - 1) + "ProductQty"));

                ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
                if (objProductsInfo.ICProductType != ProductType.Service.ToString() && !objProductsInfo.IsAsset)
                {
                    if (objProductsInfo != null&& !objProductsInfo.HasComponent)
                    {
                        if (objProductsInfo.ICPriceCalculationMethodMethod == PriceCalculationMethod.Average.ToString()) serialNo = string.Empty;
                        ICTransactionsInfo info = inventoryList.Where(t => t.FK_ICProductID == productID && t.FK_ICStockID == stockID && t.ICTransactionReceiptSerialNo.ToUpper() == serialNo.ToUpper()).FirstOrDefault();
                        ICTransactionsInfo infoMM = inventoryCheckMinMaxList.Where(t => t.FK_ICProductID == productID && t.FK_ICStockID == stockID).FirstOrDefault();
                        InventoryStatus status = Entity.GetInventoryStatusFromCatche(productID, itemQty, updateType, (info != null ? info.ICTransactionExchangeQty : 0), (infoMM != null ? infoMM.ICTransactionExchangeQty : 0));
                        if (status == InventoryStatus.Empty)
                        {
                            objProductsInfo.InventoryStatus = GetInventoryStatusMessage(status);
                            objProductsInfo.ICProductSerialNo = serialNo;
                            objProductsInfo.ICProductQty = (info != null ? info.ICTransactionExchangeQty : 0);
                            objProductsInfo.ICProductItemQty = itemQty;
                            objProductsInfo.ICProductDesc = dbUtil.GetPropertyValue(item, ItemTableName.Substring(0, ItemTableName.Length - 1) + "ProductDesc") == null ? objProductsInfo.ICProductDesc: dbUtil.GetPropertyValue(item, ItemTableName.Substring(0, ItemTableName.Length - 1) + "ProductDesc").ToString();
                            invalidProducts.Add((ICProductsInfo)objProductsInfo.Clone());
                            isInvalid = true;
                        }
                        #region Check Wood Qty
                        decimal itemWoodQty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, tableName.Substring(0, tableName.Length - 1) + "WoodQty"));
                        if(( objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                            objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                            objProductsInfo.ICProductType == ProductType.Verneer.ToString() ||
                            objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString()
                            ) && itemWoodQty > 0)
                        {
                            InventoryStatus woodstatus = Entity.GetInventoryStatusFromCatche(productID, itemWoodQty, updateType, (info != null ? info.ICTransactionQty1 : 0), (infoMM != null ? infoMM.ICTransactionQty1 : 0));
                            if (woodstatus == InventoryStatus.Empty)
                            {
                                woodstatus = InventoryStatus.WoodQtyInValid;
                                objProductsInfo.InventoryStatus = GetInventoryStatusMessage(woodstatus);
                                objProductsInfo.ICProductSerialNo = serialNo;
                                objProductsInfo.ICProductQty = (info != null ? info.ICTransactionQty1 : 0);
                                objProductsInfo.ICProductItemQty = itemWoodQty;
                                objProductsInfo.ICProductDesc = dbUtil.GetPropertyValue(item, ItemTableName.Substring(0, ItemTableName.Length - 1) + "ProductDesc") == null ? objProductsInfo.ICProductDesc : dbUtil.GetPropertyValue(item, ItemTableName.Substring(0, ItemTableName.Length - 1) + "ProductDesc").ToString();
                                invalidProducts.Add((ICProductsInfo)objProductsInfo.Clone());
                                isInvalid = true;
                            }
                        }
                        #endregion
                    }
                }
            }
            if (invalidProducts.Count > 0)
            {
                guiInventoryStatus.InventoryStatusGridControl.DataSource = invalidProducts;
                guiInventoryStatus.ShowDialog();
                this.ForEach(o =>
                {
                    int productID = Convert.ToInt32(dbUtil.GetPropertyValue(o, "FK_ICProductID"));
                    bool isInventory = invalidProducts.Where(s => s.ICProductID == productID).Count() > 0;
                    if (isInventory)
                        dbUtil.SetPropertyValue(o, "IsInventoryStock", !isInventory);
                });
            }
            return isInvalid;
        }

        public virtual bool CheckAvailableQty(String updateType, String moduleName)
        {
            if (updateType != TransactionUtil.cstInventoryShipment
                || moduleName != ModuleName.Shipment)
                return false;

            //Merge the item list with its back-up one for merging on-hand quantity
            //between new and old
            BOSDbUtil dbUtil = new BOSDbUtil();
            BOSItemsEntityList<T> mergedItems = (BOSItemsEntityList<T>)this.Clone();
            mergedItems = mergedItems.MergeBySameItems();

            bool isInvalid = false;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> invalidProducts = new List<ICProductsInfo>();

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ProductID", typeof(int)));
            dt.Columns.Add(new DataColumn("StockID", typeof(int)));
            dt.Columns.Add(new DataColumn("SeriaNo", typeof(string)));
            dt.Columns.Add(new DataColumn("ToDate", typeof(DateTime)));
            
            string mainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(Entity.MainObject);
            string mainObjectDatecolumn = mainObjectTableName.Substring(0, mainObjectTableName.Length - 1) + "Date";
            DateTime docDate = Convert.ToDateTime(dbUtil.GetPropertyValue(Entity.MainObject, mainObjectDatecolumn));
            List<ICTransactionsInfo> inventoryList = new List<ICTransactionsInfo>();            
            foreach (ERPModuleItemsEntity item in mergedItems)
            {
                String tableName = BOSUtil.GetTableNameFromBusinessObject(item);
                int productID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICProductID"));
                int stockID = dbUtil.GetPropertyIntValue(item, "FK_ICStockID");
                string serialNo = dbUtil.GetPropertyStringValue(item, tableName.Substring(0, tableName.Length - 1) + "ProductSerialNo");
                ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
                if (objProductsInfo.ICProductType != ProductType.Service.ToString() && !objProductsInfo.IsAsset)
                {
                    if (objProductsInfo.ICPriceCalculationMethodMethod == PriceCalculationMethod.Average.ToString()) serialNo = string.Empty;
                    DataRow r = dt.NewRow();
                    r["ProductID"] = productID;
                    r["StockID"] = stockID;
                    r["SeriaNo"] = serialNo;
                    r["ToDate"] = docDate;
                    dt.Rows.Add(r);
                }
            }
            if (dt.Rows.Count > 0)
            {
                inventoryList = (new ICTransactionsController()).CheckAvailableQty(dt);
            }

            foreach (ERPModuleItemsEntity item in mergedItems)
            {
                String tableName = BOSUtil.GetTableNameFromBusinessObject(item);
                int productID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICProductID"));
                decimal itemQty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, tableName.Substring(0, tableName.Length - 1) + "ProductExchangeQty"));
                if (itemQty == 0)
                    itemQty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, tableName.Substring(0, tableName.Length - 1) + "ProductQty"));

                ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
                if (objProductsInfo.ICProductType != ProductType.Service.ToString() && objProductsInfo.ICProductIsFollowInventoryStock)
                {
                    if (objProductsInfo != null)
                    {
                        ICTransactionsInfo info = inventoryList.Where(t => t.FK_ICProductID == productID).FirstOrDefault();                        
                        InventoryStatus status = Entity.GetInventoryStatusFromCatche(productID, itemQty, updateType, (info != null ? info.ICTransactionExchangeQty - info.ICInventoryStockAllocationPlanQuantity : 0), 0);
                        if (status == InventoryStatus.Empty)
                        {
                            objProductsInfo.InventoryStatus = GetInventoryStatusMessage(status);
                            objProductsInfo.ICProductSerialNo = string.Empty;
                            objProductsInfo.ICProductQty = (info != null ? info.ICTransactionExchangeQty - info.ICInventoryStockAllocationPlanQuantity : 0);
                            objProductsInfo.ICProductItemQty = itemQty;
                            objProductsInfo.ICProductDesc = dbUtil.GetPropertyValue(item, ItemTableName.Substring(0, ItemTableName.Length - 1) + "ProductDesc") == null ? objProductsInfo.ICProductDesc : dbUtil.GetPropertyValue(item, ItemTableName.Substring(0, ItemTableName.Length - 1) + "ProductDesc").ToString();
                            invalidProducts.Add((ICProductsInfo)objProductsInfo.Clone());
                            isInvalid = true;
                        }
                    }
                }
            }
            if (invalidProducts.Count > 0)
            {
                MessageBox.Show(string.Format("Số lượng xuất lớn hơn số lượng có thể sử dụng. Vui lòng kiểm tra lại:" + Environment.NewLine 
                                + "-{0}", string.Join("\n-", invalidProducts.Select(o => string.Format("{0} (SL xuất: {1} - SL có thể sử dụng: {2})", o.ICProductNo, o.ICProductItemQty.ToString("N6"), o.ICProductQty.ToString("N6"))).ToArray()))
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                this.ForEach(o =>
                {
                    int productID = Convert.ToInt32(dbUtil.GetPropertyValue(o, "FK_ICProductID"));
                    bool isInventory = invalidProducts.Where(s => s.ICProductID == productID).Count() > 0;
                    if (isInventory)
                        dbUtil.SetPropertyValue(o, "IsInventoryStock", !isInventory);
                });
            }
            return isInvalid;
        }

        public virtual bool IsInvalidInventoryStockMax(String updateType)
        {
            if (updateType == TransactionUtil.cstInventoryReceipt)
                return false;
            //Merge the item list with its back-up one for merging on-hand quantity
            //between new and old
            BOSDbUtil dbUtil = new BOSDbUtil();
            BOSItemsEntityList<T> mergedItems = (BOSItemsEntityList<T>)this.Clone();
            String qtyColumnName = ItemTableName.Substring(0, ItemTableName.Length - 1) + "ProductQty";
            //foreach (T item in BackupList)
            //{
            //    T backupItem = (T)item.Clone();
            //    decimal qty = Convert.ToDecimal(dbUtil.GetPropertyValue(backupItem, qtyColumnName));
            //    dbUtil.SetPropertyValue(backupItem, qtyColumnName, -qty);
            //    mergedItems.Add(backupItem);
            //}

            mergedItems = mergedItems.MergeBySameItems();

            guiInventoryStatus guiInventoryStatus = new guiInventoryStatus();
            guiInventoryStatus.Module = Entity.Module;
            bool isInvalid = false;

            foreach (ERPModuleItemsEntity item in mergedItems)
            {
                String tableName = BOSUtil.GetTableNameFromBusinessObject(item);
                int productID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICProductID"));

                ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
                if (objProductsInfo.ICProductType != ProductType.Service.ToString() && !objProductsInfo.IsAsset)
                {
                    if (objProductsInfo != null)//&& //!objProductsInfo.HasComponent)
                    {
                        InventoryStatus status = Entity.GetInventoryStatus(item, tableName, updateType);
                        if (status == InventoryStatus.GreaterThanMaxQty
                            && ItemTableName == TableName.ICReceiptItemsTableName
                            && objProductsInfo.ICProductType != ProductType.SemiProduct.ToString()
                            && objProductsInfo.ICProductType != ProductType.Product.ToString())
                        {
                            MessageBox.Show("Không được nhập vượt số lượng tối đa!"
                                + Environment.NewLine + "Sản phẩm: " + objProductsInfo.ICProductNo + " - " + objProductsInfo.ICProductDesc
                                + Environment.NewLine + "Số lượng tối đa: " + objProductsInfo.ICProductStockMax
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK, MessageBoxIcon.Information);

                            isInvalid = true;
                            break;
                        }
                    }
                }
            }

            return isInvalid;
        }
        /// <summary>
        /// Get description for inventory status
        /// </summary>
        private String GetInventoryStatusMessage(InventoryStatus status)
        {
            switch (status)
            {
                case InventoryStatus.Empty:
                    return BaseLocalizedResources.NotEnoughQtyMessage;
                case InventoryStatus.WoodQtyInValid:
                    return BaseLocalizedResources.NotEnoughWoodQtyMessage;
                case InventoryStatus.LessThanMinQty:
                    return BaseLocalizedResources.LessThanMinimumQtyMessage;
                case InventoryStatus.GreaterThanMaxQty:
                    return BaseLocalizedResources.GreaterThanMaximumQtyMessage;
                default:
                    return String.Empty;
            }
        }

        /// <summary>
        /// Merge the list by the same items. If items are same, just get one item of which the quantity 
        /// is equal to the sum of quantity of identical ones        
        /// </summary>        
        /// <returns>List contains merged items</returns>
        public BOSItemsEntityList<T> MergeBySameItems()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            BOSItemsEntityList<T> mergedItems = new BOSItemsEntityList<T>();
            foreach (T entItem in this)
            {
                mergedItems.Add((T)entItem.Clone());
            }
            String qtyColumnName = ItemTableName.Substring(0, ItemTableName.Length - 1) + "ProductQty";
            String exchangeQtyColumnName = ItemTableName.Substring(0, ItemTableName.Length - 1) + "ProductExchangeQty";
            String woodQtyColumnName = ItemTableName.Substring(0, ItemTableName.Length - 1) + "WoodQty";
            for (int i = 0; i < mergedItems.Count; i++)
            {
                for (int j = i + 1; j < mergedItems.Count; j++)
                {
                    int productID1 = dbUtil.GetPropertyIntValue(mergedItems[i], "FK_ICProductID");

                    int productID2 = dbUtil.GetPropertyIntValue(mergedItems[j], "FK_ICProductID");
                    int serieID1 = dbUtil.GetPropertyIntValue(mergedItems[i], "FK_ICProductSerieID");
                    int serieID2 = dbUtil.GetPropertyIntValue(mergedItems[j], "FK_ICProductSerieID");
                    int stockID1 = dbUtil.GetPropertyIntValue(mergedItems[i], "FK_ICStockID");
                    int stockID2 = dbUtil.GetPropertyIntValue(mergedItems[j], "FK_ICStockID");
                    if (stockID1 == stockID2 && productID1 == productID2 && serieID1 == serieID2)
                    {
                        //Merge ProductQty
                        decimal qty1 = Convert.ToDecimal(dbUtil.GetPropertyValue(mergedItems[i], qtyColumnName));
                        qty1 = Math.Round(qty1, RoundingNumber.FormatN6);
                        decimal qty2 = Convert.ToDecimal(dbUtil.GetPropertyValue(mergedItems[j], qtyColumnName));
                        qty2 = Math.Round(qty2, RoundingNumber.FormatN6);
                        dbUtil.SetPropertyValue(mergedItems[i], qtyColumnName, qty1 + qty2);

                        //Merge ProductExchangeQty
                        decimal eqty1 = Convert.ToDecimal(dbUtil.GetPropertyValue(mergedItems[i], exchangeQtyColumnName));
                        eqty1 = eqty1 == 0 ? qty1 : eqty1;
                        eqty1 = Math.Round(eqty1, RoundingNumber.FormatN6);
                        decimal eqty2 = Convert.ToDecimal(dbUtil.GetPropertyValue(mergedItems[j], exchangeQtyColumnName));
                        eqty2 = eqty2 == 0 ? qty2 : eqty2;
                        eqty2 = Math.Round(eqty2, RoundingNumber.FormatN6);
                        dbUtil.SetPropertyValue(mergedItems[i], exchangeQtyColumnName, eqty1 + eqty2);

                        //Merge WoodQty
                        qty1 = Convert.ToDecimal(dbUtil.GetPropertyValue(mergedItems[i], woodQtyColumnName));
                        qty1 = Math.Round(qty1, RoundingNumber.FormatN6);
                        qty2 = Convert.ToDecimal(dbUtil.GetPropertyValue(mergedItems[j], woodQtyColumnName));
                        qty2 = Math.Round(qty2, RoundingNumber.FormatN6);
                        dbUtil.SetPropertyValue(mergedItems[i], woodQtyColumnName, qty1 + qty2);
                        mergedItems.RemoveAt(j);
                        j--;
                    }
                }
            }
            return mergedItems;
        }

        /// <summary>
        /// Clone a list
        /// </summary>
        /// <returns>Copied list from the current one</returns>
        public object Clone()
        {
            BOSItemsEntityList<T> result = new BOSItemsEntityList<T>();
            result.InitBOSList(Entity, ParentTableName, ItemTableName, Relation);
            result.ItemTableForeignKey = ItemTableForeignKey;
            foreach (T obj in this)
            {
                result.Add((T)obj.Clone());
            }
            foreach (T obj in OriginalList)
            {
                result.OriginalList.Add((T)obj.Clone());
            }
            foreach (T obj in BackupList)
            {
                result.BackupList.Add((T)obj.Clone());
            }
            return result;
        }

        public virtual bool IsInvalidWoodQty()
        {
            //Merge the item list with its back-up one for merging on-hand quantity
            //between new and old
            BOSDbUtil dbUtil = new BOSDbUtil();
            BOSItemsEntityList<T> mergedItems = (BOSItemsEntityList<T>)this.Clone();
            String qtyColumnName = ItemTableName.Substring(0, ItemTableName.Length - 1) + "WoodQty";
            foreach (T item in BackupList)
            {
                T backupItem = (T)item.Clone();
                decimal qty = Convert.ToDecimal(dbUtil.GetPropertyValue(backupItem, qtyColumnName));
                dbUtil.SetPropertyValue(backupItem, qtyColumnName, -qty);
                mergedItems.Add(backupItem);
            }

            mergedItems = mergedItems.MergeBySameItems();

            guiInventoryStatus guiInventoryStatus = new guiInventoryStatus();
            guiInventoryStatus.Module = Entity.Module;
            bool isInvalid = false;
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            List<ICProductsInfo> invalidProducts = new List<ICProductsInfo>();
            foreach (ERPModuleItemsEntity item in mergedItems)
            {
                String tableName = BOSUtil.GetTableNameFromBusinessObject(item);
                int productID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICProductID"));
                ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
                int productSerieID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICProductSerieID"));
                int stockID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICStockID"));
                ICInventoryStocksInfo objInventoryStocksInfo = objInventoryStocksController.GetInventoryStockByStockIDAndProductIDAndSerieID(stockID, productID, productSerieID);
                decimal itemQty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, tableName.Substring(0, tableName.Length - 1) + "WoodQty"));
                if (objProductsInfo.ICProductType != ProductType.Service.ToString() && !objProductsInfo.IsAsset)
                {
                    if (objProductsInfo != null && objInventoryStocksInfo != null && !objProductsInfo.HasComponent)
                    {
                        if (itemQty > objInventoryStocksInfo.ICInventoryStockWoodQuantity)
                        {
                            invalidProducts.Add(objProductsInfo);
                            isInvalid = true;
                        }
                    }
                }
            }
            if (invalidProducts.Count > 0)
            {
                guiInventoryStatus.InventoryStatusGridControl.DataSource = invalidProducts;
                guiInventoryStatus.ShowDialog();
            }

            return isInvalid;
        }
        public bool IsInvalidInventoryStockQty()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            BOSItemsEntityList<T> mergedItems = (BOSItemsEntityList<T>)this.Clone();
            String qtyColumnName = ItemTableName.Substring(0, ItemTableName.Length - 1) + "ProductQty";
            String woodQtyColumnName = ItemTableName.Substring(0, ItemTableName.Length - 1) + "WoodQty";
            //foreach (T item in this)
            //{
            //    T backupItem = (T)item.Clone();
            //    //decimal qty = Convert.ToDecimal(dbUtil.GetPropertyValue(backupItem, qtyColumnName));
            //    //decimal woodQty = Convert.ToDecimal(dbUtil.GetPropertyValue(backupItem, woodQtyColumnName));
            //    //dbUtil.SetPropertyValue(backupItem, qtyColumnName, -qty);
            //    //dbUtil.SetPropertyValue(backupItem, woodQtyColumnName, -woodQty);
            //    mergedItems.Add(backupItem);
            //}
            mergedItems = mergedItems.MergeBySameItems();
            guiInventoryStatus guiInventoryStatus = new guiInventoryStatus();
            guiInventoryStatus.Module = Entity.Module;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            List<ICProductsInfo> invalidProducts = new List<ICProductsInfo>();
            String tableName = string.Empty;
            int productID = 0;
            int productSerieID = 0;
            int stockID = 0;
            decimal productQty = 0;
            bool isInvalid = false;
            bool isInvalidInventory = false;
            mergedItems.ForEach(o =>
            {
                tableName = BOSUtil.GetTableNameFromBusinessObject(o);
                productID = Convert.ToInt32(dbUtil.GetPropertyValue(o, "FK_ICProductID"));
                productSerieID = Convert.ToInt32(dbUtil.GetPropertyValue(o, "FK_ICProductSerieID"));
                stockID = Convert.ToInt32(dbUtil.GetPropertyValue(o, "FK_ICStockID"));
                objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
                if (objProductsInfo.ICProductType == ProductType.Roundwood.ToString()
                    || objProductsInfo.ICProductType == ProductType.Lumber.ToString())
                {
                    productQty = Convert.ToDecimal(dbUtil.GetPropertyValue(o, woodQtyColumnName));
                }
                else
                {
                    productQty = Convert.ToDecimal(dbUtil.GetPropertyValue(o, qtyColumnName));
                }
                isInvalidInventory = CheckInventoryStockQty(productID, stockID, productSerieID, productQty, objProductsInfo.ICProductType);
                if (!isInvalidInventory)
                {
                    invalidProducts.Add(objProductsInfo);
                }
            });
            if (invalidProducts.Count > 0)
            {
                guiInventoryStatus.InventoryStatusGridControl.DataSource = invalidProducts;
                guiInventoryStatus.ShowDialog();
                isInvalid = true;
            }
            return isInvalid;
        }

        public bool CheckInventoryStockQty(int productID, int stockID, int productSerieID, decimal productQty, string productType)
        {
            if (productType == ProductType.Roundwood.ToString()
                || productType == ProductType.Lumber.ToString())
            {
                return CheckInventoryStockWoodQty(productID, stockID, productSerieID, productQty);
            }
            return CheckInventoryStockProductQty(productID, stockID, productSerieID, productQty);
        }

        public bool CheckInventoryStockWoodQty(int productID, int stockID, int productSerieID, decimal productQty)
        {
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            ICInventoryStocksInfo objInventoryStocksInfo = objInventoryStocksController.GetInventoryStockByStockIDAndProductIDAndSerieID(stockID, productID, productSerieID);
            if (objInventoryStocksInfo != null && objInventoryStocksInfo.ICInventoryStockWoodQuantity - objInventoryStocksInfo.ICInventoryStockSaleOrderQuantity - productQty >= 0)
                return true;
            return false;
        }

        public bool CheckInventoryStockProductQty(int productID, int stockID, int productSerieID, decimal productQty)
        {
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            ICInventoryStocksInfo objInventoryStocksInfo = objInventoryStocksController.GetInventoryStockByStockIDAndProductIDAndSerieID(stockID, productID, productSerieID);
            if (objInventoryStocksInfo != null && objInventoryStocksInfo.ICInventoryStockQuantity - objInventoryStocksInfo.ICInventoryStockSaleOrderQuantity - productQty >= 0)
                return true;
            return false;
        }

        public bool IsInvalidInventoryShipmentStockQty()
        {
            return IsInvalidInventory(TransactionUtil.cstInventoryShipment);
        }

        public bool CheckInventoryStockShipmentQty(int productID, int stockID, int productSerieID, decimal productQty, string productType)
        {
            if (productType == ProductType.Roundwood.ToString()
                || productType == ProductType.Lumber.ToString())
            {
                return CheckInventoryStockShipmentWoodQty(productID, stockID, productSerieID, productQty);
            }
            return CheckInventoryStockShipmentProductQty(productID, stockID, productSerieID, productQty);
        }

        public bool CheckInventoryStockShipmentWoodQty(int productID, int stockID, int productSerieID, decimal productQty)
        {
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            ICInventoryStocksInfo objInventoryStocksInfo = objInventoryStocksController.GetInventoryStockByStockIDAndProductIDAndSerieID(stockID, productID, productSerieID);
            if (objInventoryStocksInfo != null && objInventoryStocksInfo.ICInventoryStockWoodQuantity - productQty >= 0)
                return true;
            return false;
        }

        public bool CheckInventoryStockShipmentProductQty(int productID, int stockID, int productSerieID, decimal productQty)
        {
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            ICInventoryStocksInfo objInventoryStocksInfo = objInventoryStocksController.GetInventoryStockByStockIDAndProductIDAndSerieID(stockID, productID, productSerieID);
            if (objInventoryStocksInfo != null && objInventoryStocksInfo.ICInventoryStockQuantity - productQty >= 0)
                return true;
            return false;
        }

        public virtual bool IsInvalidInventoryByAllStock(String updateType, String qtyColumnName)
        {
            //Merge the item list with its back-up one for merging on-hand quantity
            //between new and old
            BOSDbUtil dbUtil = new BOSDbUtil();
            BOSItemsEntityList<T> mergedItems = (BOSItemsEntityList<T>)this.Clone();
            BOSItemsEntityList<T> duplicateItems = (BOSItemsEntityList<T>)this.Clone();
            guiInventoryStatus guiInventoryStatus = new guiInventoryStatus();
            guiInventoryStatus.Module = Entity.Module;
            bool isInvalid = false;
            ICProductsController objProductsController = new ICProductsController();
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            List<ICProductsInfo> invalidProducts = new List<ICProductsInfo>();

            foreach (ERPModuleItemsEntity item in mergedItems)
            {
                String tableName = BOSUtil.GetTableNameFromBusinessObject(item);
                string serialNoColumn = tableName.Substring(0, tableName.Length - 1) + "ProductSerialNo";
                int productID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICProductID"));
                ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
                if (objProductsInfo != null
                    && !objProductsInfo.HasComponent
                    && objProductsInfo.ICPriceCalculationMethodMethod != PriceCalculationMethod.Average.ToString())
                {

                    decimal toTalQty = 0;
                    int productID1 = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
                    string serieNo1 = dbUtil.GetPropertyStringValue(item, serialNoColumn);
                    int stockID1 = dbUtil.GetPropertyIntValue(item, "FK_ICStockID");
                    foreach (var itemIn in mergedItems)
                    {

                        int productID2 = dbUtil.GetPropertyIntValue(itemIn, "FK_ICProductID");
                        string serieNo2 = dbUtil.GetPropertyStringValue(itemIn, serialNoColumn);
                        int stockID2 = dbUtil.GetPropertyIntValue(itemIn, "FK_ICStockID");
                        if (stockID1 == stockID2 && productID1 == productID2 && serieNo1 == serieNo2)
                        {
                            toTalQty += Convert.ToDecimal(dbUtil.GetPropertyValue(itemIn, qtyColumnName));
                            duplicateItems.Add(itemIn);
                        }
                    }
                    //dbUtil.SetPropertyValue(item, qtyColumnName, toTalQty);
                    InventoryStatus status = Entity.GetInventoryStatusByAllStock(item, tableName, updateType, toTalQty, true);
                    if (status == InventoryStatus.Empty)
                    {

                        objProductsInfo.ICProductSerialNo = serieNo1;

                        objProductsInfo.InventoryStatus = GetInventoryStatusMessage(status);
                        invalidProducts.Add(objProductsInfo);
                        isInvalid = true;
                    }
                }
            }
            if (invalidProducts.Count > 0)
            {
                guiInventoryStatus.InventoryStatusGridControl.DataSource = invalidProducts;
                guiInventoryStatus.ShowDialog();
            }
            return isInvalid;
        }

        public virtual List<ICTransactionsInfo> GetInvalidSerialNo()
        {
            //Merge the item list with its back-up one for merging on-hand quantity
            //between new and old
            BOSDbUtil dbUtil = new BOSDbUtil();
            BOSItemsEntityList<T> mergedItems = (BOSItemsEntityList<T>)this.Clone();

            //mergedItems = mergedItems.MergeBySameItems();

            guiInventoryStatus guiInventoryStatus = new guiInventoryStatus();
            guiInventoryStatus.Module = Entity.Module;
            bool isInvalid = false;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> invalidProducts = new List<ICProductsInfo>();

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ProductID", typeof(int)));
            dt.Columns.Add(new DataColumn("StockID", typeof(int)));
            dt.Columns.Add(new DataColumn("SeriaNo", typeof(string)));
            dt.Columns.Add(new DataColumn("ToDate", typeof(DateTime)));

            List<ICTransactionsInfo> inventoryList = new List<ICTransactionsInfo>();
            foreach (ERPModuleItemsEntity item in mergedItems)
            {
                String tableName = BOSUtil.GetTableNameFromBusinessObject(item);
                int productID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICProductID"));
                string serialNo = dbUtil.GetPropertyStringValue(item, tableName.Substring(0, tableName.Length - 1) + "ProductSerialNo");

                ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
                if (objProductsInfo.ICProductType != ProductType.Service.ToString() && !objProductsInfo.IsAsset)
                {
                    if (objProductsInfo.ICPriceCalculationMethodMethod == PriceCalculationMethod.Average.ToString()) serialNo = string.Empty;
                    DataRow r = dt.NewRow();
                    r["ProductID"] = productID;
                    r["StockID"] = 0;
                    r["SeriaNo"] = serialNo;
                    r["ToDate"] = BOSApp.GetCurrentServerDate();
                    dt.Rows.Add(r);
                }
            }
            if (dt.Rows.Count > 0)
                inventoryList = (new ICTransactionsController()).GetListInvalidSerialNo(dt);

            return inventoryList;
        }
        public virtual List<ICTransactionsInfo> GetInvalidSerialNoBySomeCriteria()
        {
            //Merge the item list with its back-up one for merging on-hand quantity
            //between new and old
            BOSDbUtil dbUtil = new BOSDbUtil();
            BOSItemsEntityList<T> mergedItems = (BOSItemsEntityList<T>)this.Clone();

            //mergedItems = mergedItems.MergeBySameItems();

            guiInventoryStatus guiInventoryStatus = new guiInventoryStatus();
            guiInventoryStatus.Module = Entity.Module;
            bool isInvalid = false;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> invalidProducts = new List<ICProductsInfo>();

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ProductID", typeof(int)));
            dt.Columns.Add(new DataColumn("StockID", typeof(int)));
            dt.Columns.Add(new DataColumn("SeriaNo", typeof(string)));
            dt.Columns.Add(new DataColumn("ToDate", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("ReceiptID", typeof(int)));
            dt.Columns.Add(new DataColumn("Module", typeof(string)));

            List<ICTransactionsInfo> inventoryList = new List<ICTransactionsInfo>();
            foreach (ERPModuleItemsEntity item in mergedItems)
            {
                String tableName = BOSUtil.GetTableNameFromBusinessObject(item);
                int productID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICProductID"));
                string serialNo = dbUtil.GetPropertyStringValue(item, tableName.Substring(0, tableName.Length - 1) + "ProductSerialNo");
                int ReceiptID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICReceiptID"));
                string Module = Entity.Module.Name;
                int productConversionID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICProductConversionID"));

                ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
                if (objProductsInfo.ICProductType != ProductType.Service.ToString() && !objProductsInfo.IsAsset)
                {
                    if (objProductsInfo.ICPriceCalculationMethodMethod == PriceCalculationMethod.Average.ToString()) serialNo = string.Empty;
                    DataRow r = dt.NewRow();
                    r["ProductID"] = productID;
                    r["StockID"] = 0;
                    r["SeriaNo"] = serialNo;
                    r["ToDate"] = BOSApp.GetCurrentServerDate();
                    r["ReceiptID"] = Module == "ProductConversion" ? productConversionID : ReceiptID;
                    r["Module"] = Module;
                    dt.Rows.Add(r);
                }
            }
            if (dt.Rows.Count > 0)
                inventoryList = (new ICTransactionsController()).GetListInvalidSerialNoBySomeCriteria(dt);

            return inventoryList;
        }
    }
}
