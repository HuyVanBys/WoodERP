using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.GenaralLeadger
{
    #region GLShipmentModule

    public class GLShipmentModule : BaseTransactionModule
    {
        #region Public
        public List<ICCalculatedPackageVolumnConfigsInfo> CalculatedPackageVolumnConfigsList { get; set; }
        #endregion

        public GLShipmentModule()
        {
            CalculatedPackageVolumnConfigsList = (new ICCalculatedPackageVolumnConfigsController()).GetAllObjectList();
        }

        public GLShipmentModule(string moduleName, GLShipmentEntities entity)
        {
            Name = moduleName;
            CurrentModuleEntity = entity;
            CurrentModuleEntity.Module = this;
            CalculatedPackageVolumnConfigsList = (new ICCalculatedPackageVolumnConfigsController()).GetAllObjectList();
        }

        public virtual void ActionPosted()
        {
            GLShipmentEntities entity = (GLShipmentEntities)CurrentModuleEntity;
            if (!CheckLock()) return;

            if (entity.ShipmentItemList.IsInvalidInventory(TransactionUtil.cstInventoryShipment))
                return;

            entity.SetPropertyChangeEventLock(false);
            ICShipmentsInfo mainObject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            if (mainObject != null && mainObject.ICShipmentID > 0)
            {
                mainObject.ICShipmentPostedStatus = PostedTransactionStatus.Posted.ToString();
                string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
                //GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ICShipmentID, PostedTransactionStatus.Posted.ToString());
                entity.UpdateMainObject();
                GLHelper.PostedTransactions(this.Name, mainObject.ICShipmentID, ModulePostingType.Accounting, ModulePostingType.Stock, ModulePostingType.SaleOrder, ModulePostingType.Purchase, ModulePostingType.Allocation, ModulePostingType.TransitIn, ModulePostingType.TransitOut);
                entity.UpdateMainObject();
                InvalidateToolbar();
            }
            entity.SetPropertyChangeEventLock(true);
        }

        public virtual void ActionUnPosted()
        {
            GLShipmentEntities entity = (GLShipmentEntities)CurrentModuleEntity;
            if (!CheckLock()) return;
            entity.SetPropertyChangeEventLock(false);
            ICShipmentsInfo mainObject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            if (mainObject != null && mainObject.ICShipmentID > 0)
            {
                mainObject.ICShipmentPostedStatus = PostedTransactionStatus.UnPosted.ToString();
                string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
                //GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ICShipmentID, PostedTransactionStatus.UnPosted.ToString());
                entity.UpdateMainObject();
                GLHelper.UnPostedTransactions(this.Name, mainObject.ICShipmentID, ModulePostingType.Accounting, ModulePostingType.Stock, ModulePostingType.SaleOrder, ModulePostingType.Purchase, ModulePostingType.Allocation, ModulePostingType.TransitIn, ModulePostingType.TransitOut);
                
                InvalidateToolbar();
            }
            entity.SetPropertyChangeEventLock(true);
        }

        public override void ModuleAfterCompleted()
        {
            ICShipmentsInfo mainObject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            if (!CheckLock()) return;
            if (mainObject != null && mainObject.ICShipmentID > 0)
            {
                ActionPosted();
            }
            base.ModuleAfterCompleted();
        }

        public override void ModuleAfterCancelCompleted()
        {
            ICShipmentsInfo mainObject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            if (mainObject != null && mainObject.ICShipmentID > 0)
            {
                ActionUnPosted();
            }
            base.ModuleAfterCancelCompleted();
        }

        public virtual void ChangeItemMeasureUnit(ICShipmentItemsInfo item)
        {
            GLShipmentEntities entity = (GLShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
            ICProductMeasureUnitsController controller = new ICProductMeasureUnitsController();
            ICProductMeasureUnitsInfo measureUnit = controller.GetProductMeasureUnitByProductIDAndMeasureUnitID(item.FK_ICProductID, item.FK_ICMeasureUnitID);
            item.ICShipmentItemProductFactor = (measureUnit != null && measureUnit.ICProductMeasureUnitFactor > 0)
                                                ? measureUnit.ICProductMeasureUnitFactor
                                                : 1;

            decimal unitCost = AccountHelper.GetProductUnitCost(item.FK_ICStockID, item.FK_ICProductID, item.ICShipmentItemProductSerialNo, mainObject.ICShipmentDate);
            item.ICShipmentItemProductUnitCost = unitCost * item.ICShipmentItemProductFactor / mainObject.ICShipmentExchangeRate;
            item.ICShipmentItemExchangeUnitCost = unitCost;
            entity.SetProductPriceByProductUnitPrice(item);
            entity.ShipmentItemList.GridControl?.RefreshDataSource();
        }

        public override void InvalidateToolbar()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            if (objShipmentsInfo.ICShipmentID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
                if (objShipmentsInfo.ICShipmentStatus == ShipmentStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                        objShipmentsInfo.ICShipmentPostedStatus != PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                        objShipmentsInfo.ICShipmentPostedStatus == PostedTransactionStatus.Posted.ToString());
                }
            }
            base.InvalidateToolbar();
        }

        public virtual void ChangeItemSerieNo(ICShipmentItemsInfo item)
        {
            GLShipmentEntities entity = (GLShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;

            decimal unitCost = AccountHelper.GetProductUnitCost(item.FK_ICStockID, item.FK_ICProductID, item.ICShipmentItemProductSerialNo, objShipmentsInfo.ICShipmentDate);
            item.ICShipmentItemProductUnitCost = unitCost * item.ICShipmentItemProductFactor;
            entity.SetProductPriceByProductUnitPrice(item);
            item.ICShipmentItemExchangeUnitCost = unitCost;

            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductID);
            if (objProductsInfo != null)
            {
                if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                       objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                       objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                       objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                       objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                       objProductsInfo.ICProductType == ProductType.Verneer.ToString())
                {
                    item.ICShipmentItemProductQty = Math.Round(item.ICShipmentItemProductQty, 6, MidpointRounding.AwayFromZero);
                }
                else
                {
                    item.ICShipmentItemProductQty = Math.Round(item.ICShipmentItemProductQty, 3, MidpointRounding.AwayFromZero);
                }
                item.ICShipmentItemProductExchangeQty = item.ICShipmentItemProductQty * item.ICShipmentItemProductFactor;
                item.ICShipmentItemProductExchangeQty = Math.Round(item.ICShipmentItemProductExchangeQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
            }
            BOSApp.RoundByCurrency(item, objShipmentsInfo.FK_GECurrencyID);
            entity.ShipmentItemList.GridControl?.RefreshDataSource();
            UpdateTotalAmount();
        }

        public virtual void UpdateTotalAmount()
        {

        }

        public virtual void SelectSeriesNoDefault(ICShipmentItemsInfo item)
        {
            GLShipmentEntities entity = (GLShipmentEntities)CurrentModuleEntity;
            item.FK_ICProductSerieID = 0;
            item.ICShipmentItemProductSerialNo = string.Empty;
            item.ICShipmentItemLotNo = string.Empty;
            entity.ShipmentItemList.GridControl?.RefreshDataSource();
        }

        public void CalculatedProductQtyByPackageVolumnConfig(ICShipmentItemsInfo item)
        {
            if (Toolbar.IsNullOrNoneAction())
                return;
            if (item != null)
            {
                ICProductSeriesInfo objProductSeriesInfo = (ICProductSeriesInfo)(new ICProductSeriesController()).GetObjectByID(item.FK_ICProductSerieID);
                if (objProductSeriesInfo != null)
                {
                    item.ICShipmentItemLength = objProductSeriesInfo.ICProductSerieProductLength;
                    item.ICShipmentItemHeight = objProductSeriesInfo.ICProductSerieProductHeight;
                    item.ICShipmentItemWidth = objProductSeriesInfo.ICProductSerieProductWidth;
                }
                if (CalculatedPackageVolumnConfigsList == null || CalculatedPackageVolumnConfigsList.Count <= 0)
                {
                    CalculatedPackageVolumnConfigsList = (new ICCalculatedPackageVolumnConfigsController()).GetAllObjectList();
                }
                ICCalculatedPackageVolumnConfigsInfo objCalculatedPackageVolumnConfigsInfo = CalculatedPackageVolumnConfigsList.FirstOrDefault(o => o.STModuleName == this.Name);
                ICProductsForViewInfo product = BOSApp.CurrentProductList.FirstOrDefault(o => o.ICProductID == item.FK_ICProductID);
                if (product.ICProductType == ProductType.Lumber.ToString()
                    && objCalculatedPackageVolumnConfigsInfo != null
                    && objCalculatedPackageVolumnConfigsInfo.IsActive
                    && item.ICShipmentItemLength * item.ICShipmentItemHeight * item.ICShipmentItemWidth * item.ICShipmentItemWoodQty != 0M)
                {
                    item.ICShipmentItemProductQty = item.ICShipmentItemLength * item.ICShipmentItemHeight * item.ICShipmentItemWidth * item.ICShipmentItemWoodQty / 1000000000;
                    item.ICShipmentItemProductExchangeQty = item.ICShipmentItemProductQty * item.ICShipmentItemProductFactor;
                    item.ICShipmentItemProductQty = Math.Round(item.ICShipmentItemProductQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                    item.ICShipmentItemProductExchangeQty = Math.Round(item.ICShipmentItemProductExchangeQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                }
            }
        }

        public void CalculatedProductQtyByPackageVolumnConfig()
        {
            if (Toolbar.IsNullOrNoneAction())
                return;
            GLShipmentEntities entity = (GLShipmentEntities)CurrentModuleEntity;
            if (entity.ShipmentItemList.CurrentIndex >= 0)
            {
                ICShipmentItemsInfo item = entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex];
                if (item != null)
                {
                    ICProductSeriesInfo objProductSeriesInfo = (ICProductSeriesInfo)(new ICProductSeriesController()).GetObjectByID(item.FK_ICProductSerieID);
                    if (objProductSeriesInfo != null)
                    {
                        item.ICShipmentItemLength = objProductSeriesInfo.ICProductSerieProductLength;
                        item.ICShipmentItemHeight = objProductSeriesInfo.ICProductSerieProductHeight;
                        item.ICShipmentItemWidth = objProductSeriesInfo.ICProductSerieProductWidth;
                    }
                    if (CalculatedPackageVolumnConfigsList == null || CalculatedPackageVolumnConfigsList.Count <= 0)
                    {
                        CalculatedPackageVolumnConfigsList = (new ICCalculatedPackageVolumnConfigsController()).GetAllObjectList();
                    }
                    ICCalculatedPackageVolumnConfigsInfo objCalculatedPackageVolumnConfigsInfo = CalculatedPackageVolumnConfigsList.FirstOrDefault(o => o.STModuleName == this.Name);
                    ICProductsForViewInfo product = BOSApp.CurrentProductList.FirstOrDefault(o => o.ICProductID == item.FK_ICProductID);
                    if (product.ICProductType == ProductType.Lumber.ToString()
                        && objCalculatedPackageVolumnConfigsInfo != null
                        && objCalculatedPackageVolumnConfigsInfo.IsActive
                        && item.ICShipmentItemLength * item.ICShipmentItemHeight * item.ICShipmentItemWidth * item.ICShipmentItemWoodQty != 0M)
                    {
                        item.ICShipmentItemProductQty = item.ICShipmentItemLength * item.ICShipmentItemHeight * item.ICShipmentItemWidth * item.ICShipmentItemWoodQty / 1000000000;
                        item.ICShipmentItemProductExchangeQty = item.ICShipmentItemProductQty * item.ICShipmentItemProductFactor;
                        item.ICShipmentItemProductQty = Math.Round(item.ICShipmentItemProductQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                        item.ICShipmentItemProductExchangeQty = Math.Round(item.ICShipmentItemProductExchangeQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                        entity.ShipmentItemList.GridControl?.RefreshDataSource();
                    }
                }
            }   
        }
        public void CalculatedWoodQtyByPackageVolumnConfig()
        {
            if (Toolbar.IsNullOrNoneAction())
                return;
            GLShipmentEntities entity = (GLShipmentEntities)CurrentModuleEntity;
            if (entity.ShipmentItemList.CurrentIndex >= 0)
            {
                ICShipmentItemsInfo item = entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex];
                if (item != null)
                {
                    ICProductSeriesInfo objProductSeriesInfo = (ICProductSeriesInfo)(new ICProductSeriesController()).GetObjectByID(item.FK_ICProductSerieID);
                    if (objProductSeriesInfo != null)
                    {
                        item.ICShipmentItemLength = objProductSeriesInfo.ICProductSerieProductLength;
                        item.ICShipmentItemHeight = objProductSeriesInfo.ICProductSerieProductHeight;
                        item.ICShipmentItemWidth = objProductSeriesInfo.ICProductSerieProductWidth;
                    }
                    if (CalculatedPackageVolumnConfigsList == null || CalculatedPackageVolumnConfigsList.Count <= 0)
                    {
                        CalculatedPackageVolumnConfigsList = (new ICCalculatedPackageVolumnConfigsController()).GetAllObjectList();
                    }
                    ICCalculatedPackageVolumnConfigsInfo objCalculatedPackageVolumnConfigsInfo = CalculatedPackageVolumnConfigsList.FirstOrDefault(o => o.STModuleName == this.Name);
                    ICProductsForViewInfo product = BOSApp.CurrentProductList.FirstOrDefault(o => o.ICProductID == item.FK_ICProductID);
                    if (product.ICProductType == ProductType.Lumber.ToString()
                        && objCalculatedPackageVolumnConfigsInfo != null
                        && objCalculatedPackageVolumnConfigsInfo.IsActive
                        && item.ICShipmentItemLength * item.ICShipmentItemHeight * item.ICShipmentItemWidth  != 0M)
                    {
                        item.ICShipmentItemWoodQty = item.ICShipmentItemProductQty /(( item.ICShipmentItemLength * item.ICShipmentItemHeight * item.ICShipmentItemWidth ) / 1000000000);
                        item.ICShipmentItemWoodQty = Math.Round(item.ICShipmentItemWoodQty, 0);
                        entity.ShipmentItemList.GridControl?.RefreshDataSource();
                    }
                }
            }
        }
        private bool CheckLock()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            string MainTableName = BOSUtil.GetTableNameFromBusinessObject(CurrentModuleEntity.MainObject);
            string MainTablePrefix = MainTableName.Substring(0, MainTableName.Length - 1);
            object value = dbUtil.GetPropertyValue(CurrentModuleEntity.MainObject, MainTablePrefix + "Date");
            if (value != null)
            {
                STModulePostingsInfo postExit = (new STModulePostingsController()).GetObjectByModuleName(CurrentModuleEntity.Module.Name);
                if (postExit == null || string.IsNullOrEmpty(postExit.STModulePostingStockFunction))
                    return false;

                DateTime transactionDate = Convert.ToDateTime(value);
                ADLocksController objLocksController = new ADLocksController();
                ADLocksInfo lockInfo = objLocksController.GetActiveLockByDate(transactionDate);
                if (lockInfo != null)
                {
                    MessageBox.Show("Ngày chứng từ không hợp lệ, đã khoá dữ liệu đến ngày: " + lockInfo.ADLockToDate.ToShortDateString(),
                                            CommonLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                    return false;
                }

                TimeSpan interval = transactionDate.Date - BOSApp.GetCurrentServerDate().AddDays(BOSApp.CurrentCompanyInfo.CSCompanyExceededDay).Date;


                if (interval.Days > 0)
                {
                    MessageBox.Show("Ngày chứng từ vượt quá thời gian cho phép!",
                                            CommonLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
    }
    #endregion
}