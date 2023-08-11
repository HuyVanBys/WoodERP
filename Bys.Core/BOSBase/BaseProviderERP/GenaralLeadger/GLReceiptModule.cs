using BOSCommon;
using BOSCommon.Constants;
using Localization;
using System;
using System.Transactions;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using BOSLib;

namespace BOSERP.GenaralLeadger
{
    #region GLReceiptModule

    public class GLReceiptModule : BaseTransactionModule
    {
        #region Public
        public List<ICCalculatedPackageVolumnConfigsInfo> CalculatedPackageVolumnConfigsList { get; set; }
        #endregion

        public GLReceiptModule()
        {
            CalculatedPackageVolumnConfigsList = (new ICCalculatedPackageVolumnConfigsController()).GetAllObjectList();
        }

        public GLReceiptModule(string moduleName, GLReceiptEntities entity)
        {
            Name = moduleName;
            CurrentModuleEntity = entity;
            CurrentModuleEntity.Module = this;
            CalculatedPackageVolumnConfigsList = (new ICCalculatedPackageVolumnConfigsController()).GetAllObjectList();
        }

        public virtual void ActionPosted()
        {
            GLReceiptEntities entity = (GLReceiptEntities)CurrentModuleEntity;
            entity.SetPropertyChangeEventLock(false);
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            if (objReceiptsInfo != null && objReceiptsInfo.ICReceiptID > 0 && CheckLock())
            {
               
                objReceiptsInfo.ICReceiptPostedStatus = PostedTransactionStatus.Posted.ToString();
                string tableName = objReceiptsInfo.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
                //using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
                //{
                //    try
                //    {
                //        GLHelper.PostedTransactions(this.Name, objReceiptsInfo.ICReceiptID, ModulePostingType.Accounting, ModulePostingType.Stock, ModulePostingType.SaleOrder, ModulePostingType.Purchase, ModulePostingType.Allocation, ModulePostingType.TransitIn, ModulePostingType.TransitOut, ModulePostingType.InvoiceInTrans);
                //        GLHelper.UpdatePostedStatus(this.Name, tableName, objReceiptsInfo.ICReceiptID, PostedTransactionStatus.Posted.ToString());
                //        scope.Complete();
                        
                //    }
                //    catch (Exception e)
                //    {
                //        scope.Dispose();
                //    }
                //}
                GLHelper.PostedTransactions(this.Name, objReceiptsInfo.ICReceiptID, ModulePostingType.Accounting, ModulePostingType.Stock, ModulePostingType.SaleOrder, ModulePostingType.Purchase, ModulePostingType.Allocation, ModulePostingType.TransitIn, ModulePostingType.TransitOut, ModulePostingType.InvoiceInTrans);
                //GLHelper.UpdatePostedStatus(this.Name, tableName, objReceiptsInfo.ICReceiptID, PostedTransactionStatus.Posted.ToString());
                entity.UpdateMainObject();
                InvalidateToolbar();
            }
            entity.SetPropertyChangeEventLock(true);
        }

        public virtual void ActionUnPosted()
        {
            GLReceiptEntities entity = (GLReceiptEntities)CurrentModuleEntity;
            entity.SetPropertyChangeEventLock(false);
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            if (objReceiptsInfo != null && objReceiptsInfo.ICReceiptID > 0 && CheckLock())
            {
                if (!CheckRelativeDocument())
                {
                    return;
                }
                objReceiptsInfo.ICReceiptPostedStatus = PostedTransactionStatus.UnPosted.ToString();
                string tableName = objReceiptsInfo.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
                //using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
                //{
                //    try
                //    {
                //        GLHelper.UnPostedTransactions(this.Name, objReceiptsInfo.ICReceiptID, ModulePostingType.Accounting, ModulePostingType.Stock, ModulePostingType.SaleOrder, ModulePostingType.Purchase, ModulePostingType.Allocation, ModulePostingType.TransitIn, ModulePostingType.TransitOut, ModulePostingType.InvoiceInTrans);
                //        GLHelper.UpdatePostedStatus(this.Name, tableName, objReceiptsInfo.ICReceiptID, PostedTransactionStatus.UnPosted.ToString());
                //        scope.Complete();

                //    }
                //    catch (Exception e)
                //    {
                //        scope.Dispose();
                //    }
                //}
                GLHelper.UnPostedTransactions(this.Name, objReceiptsInfo.ICReceiptID, ModulePostingType.Accounting, ModulePostingType.Stock, ModulePostingType.SaleOrder, ModulePostingType.Purchase, ModulePostingType.Allocation, ModulePostingType.TransitIn, ModulePostingType.TransitOut, ModulePostingType.InvoiceInTrans);
                //GLHelper.UpdatePostedStatus(this.Name, tableName, objReceiptsInfo.ICReceiptID, PostedTransactionStatus.UnPosted.ToString());
                entity.UpdateMainObject();
                InvalidateToolbar();
            }
            entity.SetPropertyChangeEventLock(true);
        }

        public virtual void ChangeItemMeasureUnit(ICReceiptItemsInfo item)
        {
            ICProductMeasureUnitsController controller = new ICProductMeasureUnitsController();
            ICProductMeasureUnitsInfo measureUnit = controller.GetProductMeasureUnitByProductIDAndMeasureUnitID(item.FK_ICProductID, item.FK_ICMeasureUnitID);
            item.ICReceiptItemProductFactor = (measureUnit != null && measureUnit.ICProductMeasureUnitFactor > 0)
                                                ? measureUnit.ICProductMeasureUnitFactor
                                                : 1;

            GLReceiptEntities entity = (GLReceiptEntities)CurrentModuleEntity;
            entity.SetProductPriceByProductUnitPrice(item);
            entity.ReceiptItemsList.GridControl?.RefreshDataSource();
        }

        public override void InvalidateToolbar()
        {
            ICReceiptsInfo receipt = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            if (receipt.ICReceiptID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
                if (receipt.ICReceiptStatus == ReceiptStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                        receipt.ICReceiptPostedStatus != PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                        receipt.ICReceiptPostedStatus == PostedTransactionStatus.Posted.ToString());
                }
            }

            base.InvalidateToolbar();
        }

        public override void ModuleAfterCompleted()
        {
            GLReceiptEntities entity = (GLReceiptEntities)CurrentModuleEntity;
            ICReceiptsInfo mainObject = (ICReceiptsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            if (mainObject != null && mainObject.ICReceiptID > 0)
            {
                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
                {
                    try
                    {
                        mainObject.ICReceiptPostedStatus = PostedTransactionStatus.Posted.ToString();
                        string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
                        GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ICReceiptID, PostedTransactionStatus.Posted.ToString());
                        GLHelper.PostedTransactions(this.Name, mainObject.ICReceiptID, ModulePostingType.Accounting, ModulePostingType.Stock, ModulePostingType.SaleOrder, ModulePostingType.Purchase, ModulePostingType.Allocation, ModulePostingType.TransitIn, ModulePostingType.TransitOut, ModulePostingType.InvoiceInTrans);
                        scope.Complete();
                    }
                    catch (Exception e)
                    {
                        scope.Dispose();
                    }
                }
                entity.SetPropertyChangeEventLock(true);
            }
            base.ModuleAfterCompleted();
        }

        public void ChangeExchangeRate()
        {
            GLReceiptEntities entity = (GLReceiptEntities)CurrentModuleEntity;
            entity.ReceiptItemsList.ForEach(o => entity.SetProductPriceByProductUnitPrice(o));
            entity.ReceiptItemsList.GridControl?.RefreshDataSource();
        }

        public void CalculatedProductQtyByPackageVolumnConfig(ICReceiptItemsInfo item)
        {
            if (Toolbar.IsNullOrNoneAction())
                return;
            if (item != null)
            {
                if(CalculatedPackageVolumnConfigsList == null || CalculatedPackageVolumnConfigsList.Count <= 0)
                {
                    CalculatedPackageVolumnConfigsList = (new ICCalculatedPackageVolumnConfigsController()).GetAllObjectList();
                }    
                ICCalculatedPackageVolumnConfigsInfo objCalculatedPackageVolumnConfigsInfo = CalculatedPackageVolumnConfigsList.FirstOrDefault(o => o.STModuleName == this.Name);
                ICProductsForViewInfo product = BOSApp.CurrentProductList.FirstOrDefault(o => o.ICProductID == item.FK_ICProductID);
                if(product.ICProductType == ProductType.Lumber.ToString()
                    && objCalculatedPackageVolumnConfigsInfo != null
                    && objCalculatedPackageVolumnConfigsInfo.IsActive
                    && item.ICReceiptItemProductLength * item.ICReceiptItemProductHeight * item.ICReceiptItemProductWidth * item.ICReceiptItemWoodQty != 0M)
                {
                    item.ICReceiptItemProductQty = item.ICReceiptItemProductLength * item.ICReceiptItemProductHeight * item.ICReceiptItemProductWidth * item.ICReceiptItemWoodQty / 1000000000;
                    item.ICReceiptItemProductExchangeQty = item.ICReceiptItemProductQty * item.ICReceiptItemProductFactor;
                    item.ICReceiptItemProductQty = Math.Round(item.ICReceiptItemProductQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                    item.ICReceiptItemProductExchangeQty = Math.Round(item.ICReceiptItemProductExchangeQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                }
            }   
        }

        public void CalculatedProductQtyByPackageVolumnConfig()
        {
            if (Toolbar.IsNullOrNoneAction())
                return;
            GLReceiptEntities entity = (GLReceiptEntities)CurrentModuleEntity;
            if (entity.ReceiptItemsList.CurrentIndex >= 0)
            {
                ICReceiptItemsInfo item = entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex];
                if (item != null)
                {
                    if (CalculatedPackageVolumnConfigsList == null || CalculatedPackageVolumnConfigsList.Count <= 0)
                    {
                        CalculatedPackageVolumnConfigsList = (new ICCalculatedPackageVolumnConfigsController()).GetAllObjectList();
                    }
                    ICCalculatedPackageVolumnConfigsInfo objCalculatedPackageVolumnConfigsInfo = CalculatedPackageVolumnConfigsList.FirstOrDefault(o => o.STModuleName == this.Name);
                    ICProductsForViewInfo product = BOSApp.CurrentProductList.FirstOrDefault(o => o.ICProductID == item.FK_ICProductID);
                    if (product.ICProductType == ProductType.Lumber.ToString()
                        && objCalculatedPackageVolumnConfigsInfo != null
                        && objCalculatedPackageVolumnConfigsInfo.IsActive
                        && item.ICReceiptItemProductLength * item.ICReceiptItemProductHeight * item.ICReceiptItemProductWidth * item.ICReceiptItemWoodQty != 0M)
                    {
                        item.ICReceiptItemProductQty = item.ICReceiptItemProductLength * item.ICReceiptItemProductHeight * item.ICReceiptItemProductWidth * item.ICReceiptItemWoodQty / 1000000000;
                        item.ICReceiptItemProductExchangeQty = item.ICReceiptItemProductQty * item.ICReceiptItemProductFactor;
                        item.ICReceiptItemProductQty = Math.Round(item.ICReceiptItemProductQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                        item.ICReceiptItemProductExchangeQty = Math.Round(item.ICReceiptItemProductExchangeQty, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                        entity.ReceiptItemsList.GridControl?.RefreshDataSource();
                    }
                }
            }   
        }
        public void CalculatedTotalWoodQtyByPackageVolumnConfig()
        {
            if (Toolbar.IsNullOrNoneAction())
                return;
            GLReceiptEntities entity = (GLReceiptEntities)CurrentModuleEntity;
            if (entity.ReceiptItemsList.CurrentIndex >= 0)
            {
                ICReceiptItemsInfo item = entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex];
                if (CalculatedPackageVolumnConfigsList == null || CalculatedPackageVolumnConfigsList.Count <= 0)
                {
                    CalculatedPackageVolumnConfigsList = (new ICCalculatedPackageVolumnConfigsController()).GetAllObjectList();
                }
                ICCalculatedPackageVolumnConfigsInfo objCalculatedPackageVolumnConfigsInfo = CalculatedPackageVolumnConfigsList.FirstOrDefault(o => o.STModuleName == this.Name);
                ICProductsForViewInfo product = BOSApp.CurrentProductList.FirstOrDefault(o => o.ICProductID == item.FK_ICProductID);
                if (product.ICProductType == ProductType.Lumber.ToString()
                    && objCalculatedPackageVolumnConfigsInfo != null
                    && objCalculatedPackageVolumnConfigsInfo.IsActive
                    && item.ICReceiptItemProductLength * item.ICReceiptItemProductHeight * item.ICReceiptItemProductWidth * item.ICReceiptItemProductQty != 0M
                    )
                {
                    decimal woodqty = item.ICReceiptItemProductQty / (item.ICReceiptItemProductLength * item.ICReceiptItemProductHeight * item.ICReceiptItemProductWidth / 1000000000);
                    if (woodqty != item.ICReceiptItemWoodQty)
                    {
                        item.ICReceiptItemWoodQty = Math.Round(woodqty, RoundingNumber.FormatN0, MidpointRounding.AwayFromZero);
                    }
                    
                    entity.ReceiptItemsList.GridControl?.RefreshDataSource();
                }
            }
        }

        public override bool ActionCancelComplete()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            if (objReceiptsInfo.ICReceiptID > 0)
            {
                if (!CheckRelativeDocument())
                {
                    return false;
                }
                if (!CheckLock())
                    return false;
            }   
            return base.ActionCancelComplete();
        }

        private bool CheckRelativeDocument()
        {
            ICReceiptsInfo mainObject = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            ICTransactionsController objTransactionsController = new ICTransactionsController();
            List<ICTransactionsInfo> listShipment = objTransactionsController.GetShipmentReferenceByReceiptID(mainObject.ICReceiptID, TableName.ICReceiptItemsTableName);
            if (listShipment.Count() > 0)
            {
                MessageBox.Show("Chứng từ này đã tạo chứng từ xuất kho hoặc số lượng tồn kho hiện tại không đủ." + Environment.NewLine
                                + string.Join(",", listShipment.Select(o => o.ICTransactionReferenceNo).Distinct().ToArray())
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return false;
            }
            return true;
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