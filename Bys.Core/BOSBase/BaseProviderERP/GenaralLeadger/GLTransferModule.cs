using System;
using BOSCommon;
using BOSCommon.Constants;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.GenaralLeadger
{
    #region GLTransferModule

    public class GLTransferModule : BaseTransactionModule
    {
        #region Constants
        #endregion

        #region Public
        public List<ICCalculatedPackageVolumnConfigsInfo> CalculatedPackageVolumnConfigsList { get; set; }
        #endregion

        public GLTransferModule()
        {
            CalculatedPackageVolumnConfigsList = (new ICCalculatedPackageVolumnConfigsController()).GetAllObjectList();
        }

        public GLTransferModule(string moduleName, GLTransferEntities entity)
        {
            Name = moduleName;
            CurrentModuleEntity = entity;
            CurrentModuleEntity.Module = this;
            CalculatedPackageVolumnConfigsList = (new ICCalculatedPackageVolumnConfigsController()).GetAllObjectList();
        }

        public virtual void ActionPosted()
        {
            GLTransferEntities entity = (GLTransferEntities)CurrentModuleEntity;
            ICTransfersInfo objTransfersInfo = (ICTransfersInfo)CurrentModuleEntity.MainObject;
            if (!CheckLock())return;
            if (objTransfersInfo.ICTransferType == TransferType.Transfer.ToString()
                && entity.TransferItemList.IsInvalidInventory(TransactionUtil.cstInventoryShipment))
                return;

            entity.SetPropertyChangeEventLock(false);
            objTransfersInfo.ICTransferPostedStatus = PostedTransactionStatus.Posted.ToString();
            string tableName = objTransfersInfo.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            //GLHelper.UpdatePostedStatus(this.Name, tableName, objTransfersInfo.ICTransferID, PostedTransactionStatus.Posted.ToString());
            GLHelper.PostedTransactions(this.Name, objTransfersInfo.ICTransferID, ModulePostingType.Accounting, ModulePostingType.Stock, ModulePostingType.SaleOrder, ModulePostingType.Purchase, ModulePostingType.Allocation, ModulePostingType.TransitIn, ModulePostingType.TransitOut);
            entity.UpdateMainObject();
            InvalidateToolbar();
            entity.SetPropertyChangeEventLock(true);
        }

        public virtual void ActionUnPosted()
        {
            if (!CheckLock()) return;
            GLTransferEntities entity = (GLTransferEntities)CurrentModuleEntity;
            entity.SetPropertyChangeEventLock(false);
            ICTransfersInfo objTransfersInfo = (ICTransfersInfo)CurrentModuleEntity.MainObject;
            objTransfersInfo.ICTransferPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = objTransfersInfo.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            //GLHelper.UpdatePostedStatus(this.Name, tableName, objTransfersInfo.ICTransferID, PostedTransactionStatus.UnPosted.ToString());
            GLHelper.UnPostedTransactions(this.Name, objTransfersInfo.ICTransferID, ModulePostingType.Accounting, ModulePostingType.Stock, ModulePostingType.SaleOrder, ModulePostingType.Purchase, ModulePostingType.Allocation, ModulePostingType.TransitIn, ModulePostingType.TransitOut);
            entity.UpdateMainObject();
            InvalidateToolbar();
            entity.SetPropertyChangeEventLock(true);
        }

        public void ChangeItemMeasureUnit(ICTransferItemsInfo item)
        {
            GLTransferEntities entity = (GLTransferEntities)CurrentModuleEntity;
            ICTransfersInfo mainObject = (ICTransfersInfo)entity.MainObject;
            decimal oldProductFactor = item.ICTransferItemProductFactor;
            decimal oldExchangeQty = item.ICTransferItemProductExchangeQty;
            ICProductMeasureUnitsController controller = new ICProductMeasureUnitsController();
            ICProductMeasureUnitsInfo measureUnit = controller.GetProductMeasureUnitByProductIDAndMeasureUnitID(item.FK_ICProductID, item.FK_ICMeasureUnitID);
            item.ICTransferItemProductFactor = (measureUnit != null && measureUnit.ICProductMeasureUnitFactor > 0)
                                                ? measureUnit.ICProductMeasureUnitFactor
                                                : 1;
            item.ICTransferItemProductQty = oldExchangeQty / (item.ICTransferItemProductFactor > 0 ? item.ICTransferItemProductFactor : 1);
            item.ICTransferItemProductExchangeQty = item.ICTransferItemProductQty * item.ICTransferItemProductFactor;
            item.ICTransferItemProductUnitCost = AccountHelper.GetProductUnitCost(item.FK_ICFromStockID, item.FK_ICProductID, item.ICTransferItemProductSerialNo, mainObject.ICTransferDate) * item.ICTransferItemProductFactor;
            entity.SetProductPriceByProductUnitPrice(item);
            entity.TransferItemList.GridControl?.RefreshDataSource();
        }

        public override void InvalidateToolbar()
        {
            ICTransfersInfo objTransfersInfo = (ICTransfersInfo)CurrentModuleEntity.MainObject;
            if (objTransfersInfo.ICTransferID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
                if (objTransfersInfo.ICTransferStatus == TransferStatus.Complete.ToString()
                    || objTransfersInfo.ICTransferStatus == TransferStatus.Post.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                        objTransfersInfo.ICTransferPostedStatus != PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                        objTransfersInfo.ICTransferPostedStatus == PostedTransactionStatus.Posted.ToString());
                }
            }

            base.InvalidateToolbar();
        }

        public override void ModuleAfterCompleted()
        {
            GLTransferEntities entity = (GLTransferEntities)CurrentModuleEntity;
            ICTransfersInfo objTransfersInfo = (ICTransfersInfo)CurrentModuleEntity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            objTransfersInfo.ICTransferPostedStatus = PostedTransactionStatus.Posted.ToString();
            entity.UpdateMainObject();
            GLHelper.PostedTransactions(this.Name, objTransfersInfo.ICTransferID, ModulePostingType.Accounting, ModulePostingType.Stock, ModulePostingType.SaleOrder, ModulePostingType.Purchase, ModulePostingType.Allocation, ModulePostingType.TransitIn, ModulePostingType.TransitOut);
            InvalidateToolbar();
            entity.SetPropertyChangeEventLock(true);
            base.ModuleAfterCompleted();
        }

        public void ChangeExchangeRate()
        {
            GLTransferEntities entity = (GLTransferEntities)CurrentModuleEntity;
            entity.TransferItemList.ForEach(o => entity.SetProductPriceByProductUnitPrice(o));
            entity.TransferItemList.GridControl?.RefreshDataSource();
        }

        public virtual void ChangeItemSerieNo(ICTransferItemsInfo item)
        {
            GLTransferEntities entity = (GLTransferEntities)CurrentModuleEntity;
            ICTransfersInfo objTransfersInfo = (ICTransfersInfo)entity.MainObject;
            item.ICTransferItemProductUnitCost = AccountHelper.GetProductUnitCost(item.FK_ICStockID, item.FK_ICProductID, item.ICTransferItemProductSerialNo, objTransfersInfo.ICTransferDate) * item.ICTransferItemProductFactor;

            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            ICInventoryStocksInfo objInventoryStocksInfo = objInventoryStocksController.GetInventoryStockByStockIDAndProductIDAndSerieID(item.FK_ICStockID, item.FK_ICProductID, item.FK_ICProductSerieID);
            ICProductsInfo product = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductID);
            if (product == null)
                return;

            if (objInventoryStocksInfo != null
                && !string.IsNullOrEmpty(item.ICTransferItemProductSerialNo)
                )
            {
                item.ICTransferItemProductQty = objInventoryStocksInfo.ICInventoryStockQuantity;
                item.ICTransferItemProductFactor = 1;
                item.ICTransferItemProductExchangeQty = objInventoryStocksInfo.ICInventoryStockQuantity;

                item.ICTransferItemProductLength = objInventoryStocksInfo.ICProductSerieProductLength;
                item.ICTransferItemProductWidth = objInventoryStocksInfo.ICProductSerieProductWidth;
                item.ICTransferItemProductHeight = objInventoryStocksInfo.ICProductSerieProductHeight;
                item.ICTransferItemQty1 = objInventoryStocksInfo.ICInventoryStockWoodQuantity;
            }

            entity.SetProductPriceByProductUnitPrice(item);
            entity.TransferItemList.GridControl?.RefreshDataSource();
        }

        public void CalculatedProductQtyByPackageVolumnConfig()
        {
            GLTransferEntities entity = (GLTransferEntities)CurrentModuleEntity;
            ICTransfersInfo mainobject = (ICTransfersInfo)entity.MainObject;

            ICTransferItemsInfo item = entity.TransferItemList[entity.TransferItemList.CurrentIndex];
            if (item != null)
            {
                if(mainobject.ICTransferType == TransferType.Transfer.ToString())
                {
                    ICProductSeriesInfo objProductSeriesInfo = (ICProductSeriesInfo)(new ICProductSeriesController()).GetObjectByID(item.FK_ICProductSerieID);
                    if (objProductSeriesInfo != null)
                    {
                        item.ICTransferItemProductLength = objProductSeriesInfo.ICProductSerieProductLength;
                        item.ICTransferItemProductHeight = objProductSeriesInfo.ICProductSerieProductHeight;
                        item.ICTransferItemProductWidth = objProductSeriesInfo.ICProductSerieProductWidth;
                    }
                }    
                if(CalculatedPackageVolumnConfigsList == null || CalculatedPackageVolumnConfigsList.Count <= 0)
                {
                    CalculatedPackageVolumnConfigsList = (new ICCalculatedPackageVolumnConfigsController()).GetAllObjectList();
                }    
                ICCalculatedPackageVolumnConfigsInfo objCalculatedPackageVolumnConfigsInfo = CalculatedPackageVolumnConfigsList.FirstOrDefault(o => o.STModuleName == this.Name);
                ICProductsForViewInfo product = BOSApp.CurrentProductList.FirstOrDefault(o => o.ICProductID == item.FK_ICProductID);
                if (product.ICProductType == ProductType.Lumber.ToString()
                    && objCalculatedPackageVolumnConfigsInfo != null
                    && objCalculatedPackageVolumnConfigsInfo.IsActive
                    && item.ICTransferItemProductLength * item.ICTransferItemProductHeight * item.ICTransferItemProductWidth * item.ICTransferItemQty1 != 0M)
                {
                    item.ICTransferItemProductQty = item.ICTransferItemProductLength * item.ICTransferItemProductHeight * item.ICTransferItemProductWidth * item.ICTransferItemQty1 / 1000000000;
                    item.ICTransferItemProductExchangeQty = item.ICTransferItemProductQty * item.ICTransferItemProductFactor;
                    item.ICTransferItemProductQty = Math.Round(item.ICTransferItemProductQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                    item.ICTransferItemProductExchangeQty = Math.Round(item.ICTransferItemProductExchangeQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                    entity.TransferItemList.GridControl?.RefreshDataSource();
                }
            }
        }
    }
    #endregion
}