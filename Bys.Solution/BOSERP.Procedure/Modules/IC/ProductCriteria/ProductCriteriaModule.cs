using BOSCommon;
using BOSComponent;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductCriteria
{
    public class ProductCriteriaModule : BaseTransactionModule
    {
        public const string ModuleName = "ProductCriteria";
        public const string ProductCriteriasDiscountAmountTextBoxName = "fld_txtICProductCriteriaDiscountAmount";
        public const string ProductCriteriasDiscountPercentTextBoxName = "fld_txtICProductCriteriaDiscountPercent";

        public BOSTextBox ProductCriteriasDiscountPercentTextBox;
        public BOSTextBox ProductCriteriasDiscountAmountTextBox;
        public ProductCriteriaModule()
        {
            Name = ModuleName;
            CurrentModuleEntity = new ProductCriteriaEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            ProductCriteriasDiscountPercentTextBox = (BOSTextBox)Controls[ProductCriteriaModule.ProductCriteriasDiscountPercentTextBoxName];
            ProductCriteriasDiscountAmountTextBox = (BOSTextBox)Controls[ProductCriteriaModule.ProductCriteriasDiscountAmountTextBoxName];
        }

        public void CheckedProductCriteria()
        {
            if (ParentScreen.ToolbarManager.Items["fld_barbtnSave"].Enabled == true)
            {
                return;
            }
            ProductCriteriaEntities entity = (ProductCriteriaEntities)CurrentModuleEntity;
            ICProductCriteriasInfo objProductCriteriasInfo = (ICProductCriteriasInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            objProductCriteriasInfo.ICProductCriteriaStatus = ProductCriteriaStatus.Checked.ToString();
            entity.UpdateMainObject();
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public void AddCollectionToProductCriteriaItemsList()
        {
            if (IsEditable())
            {
                ActionEdit();
            }
            ProductCriteriaEntities entity = (ProductCriteriaEntities)CurrentModuleEntity;
            ICProductCriteriasInfo mainObject = (ICProductCriteriasInfo)CurrentModuleEntity.MainObject;

            ICCollectionsController objCollectionController = new ICCollectionsController();
            List<ICCollectionsInfo> collectionList = (List<ICCollectionsInfo>)objCollectionController.GetListFromDataSet(objCollectionController.GetAllObjects());

            guiAddCollectionToProductCriteria<ICCollectionsInfo> guiAddCollectionToProductCriteria = new guiAddCollectionToProductCriteria<ICCollectionsInfo>(collectionList);
            guiAddCollectionToProductCriteria.Module = this;
            guiAddCollectionToProductCriteria.ShowDialog();
            if (guiAddCollectionToProductCriteria.DialogResult != DialogResult.OK)
                return;

            ICCollectionsInfo objICCollectionsInfo = guiAddCollectionToProductCriteria.SelectedObjects[0];
            if (objICCollectionsInfo == null)
                return;

            if (!Toolbar.IsEditAction() && !Toolbar.IsNewAction())
                ActionEdit();
            entity.GenarateProductCriteriaItems(objICCollectionsInfo);
            entity.ProductCriteriaItemList.GridControl.RefreshDataSource();
            UpdateTotalAmount();
        }

        public void AddProductToProductCriteriaItemsList()
        {
            if (IsEditable())
            {
                ActionEdit();
            }
            ProductCriteriaEntities entity = (ProductCriteriaEntities)CurrentModuleEntity;
            ICProductCriteriasInfo mainObject = (ICProductCriteriasInfo)CurrentModuleEntity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> products = objProductsController.GetListProductByProductType(ProductType.Product.ToString())
                                                                        .Where(o => o.ICProductActiveCheck).ToList();
            guiAddProduct<ICProductsInfo> guiAddProduct = new guiAddProduct<ICProductsInfo>(products);
            guiAddProduct.Module = this;
            guiAddProduct.ShowDialog();
            if (guiAddProduct.DialogResult != DialogResult.OK)
                return;

            if (guiAddProduct.SelectedObjects.Count == 0)
                return;

            if (!Toolbar.IsEditAction() && !Toolbar.IsNewAction())
                ActionEdit();
            products = (List<ICProductsInfo>)guiAddProduct.SelectedObjects;
            entity.GenarateProductCriteriaItems(products);
            entity.ProductCriteriaItemList.GridControl.RefreshDataSource();
            UpdateTotalAmount();
        }

        public void DeleteItemProductCriteriaItemsList()
        {
            ProductCriteriaEntities entity = (ProductCriteriaEntities)CurrentModuleEntity;
            entity.ProductCriteriaItemList.RemoveSelectedRowObjectFromList();
        }

        public override int ActionSave()
        {
            ProductCriteriaEntities entity = (ProductCriteriaEntities)CurrentModuleEntity;
            ICProductCriteriasInfo mainObject = (ICProductCriteriasInfo)entity.MainObject;
            if (String.IsNullOrEmpty(mainObject.ICProductCriteriaType))
            {
                MessageBox.Show(ProductCriteriaLocalizedResources.ICProductCriteriaTypeRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            int id = base.ActionSave();
            InvalidateToolbar();
            return id;
        }

        public override bool ActionComplete()
        {
            ProductCriteriaEntities entity = (ProductCriteriaEntities)CurrentModuleEntity;
            ICProductCriteriasInfo mainObject = (ICProductCriteriasInfo)CurrentModuleEntity.MainObject;
            mainObject.ICProductCriteriaStatus = ProductCriteriaStatus.Completed.ToString();
            entity.UpdateMainObject();
            return base.ActionComplete();
        }

        public override void InvalidateToolbar()
        {
            ICProductCriteriasInfo mainObject = (ICProductCriteriasInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
            ParentScreen.SetEnableOfToolbarButton("CheckedProductCriteria", true);
            if (mainObject.ICProductCriteriaStatus == ProductCriteriaStatus.Checked.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ParentScreen.SetEnableOfToolbarButton("CheckedProductCriteria", false);
            }
            if (mainObject.ICProductCriteriaStatus == ProductCriteriaStatus.Completed.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ParentScreen.SetEnableOfToolbarButton("CheckedProductCriteria", false);
            }
            //else
            //{
            //    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
            //}
        }

        public void ChangeCriteriaItemPercent()
        {
            ProductCriteriaEntities entity = (ProductCriteriaEntities)CurrentModuleEntity;
            if (entity.ProductCriteriaItemList.CurrentIndex < 0)
                return;

            ICProductCriteriaItemsInfo objProductCriteriaItemsInfo = entity.ProductCriteriaItemList[entity.ProductCriteriaItemList.CurrentIndex];
            objProductCriteriaItemsInfo.ICProductCriteriaItemsDiscountAmount = 0;
            if (objProductCriteriaItemsInfo.ICProductCriteriaItemIsIncrease)
                objProductCriteriaItemsInfo.ICProductCriteriaItemUnitPrice = objProductCriteriaItemsInfo.ICProductCriteriaItemProductUnitPrice + objProductCriteriaItemsInfo.ICProductCriteriaItemProductUnitPrice * objProductCriteriaItemsInfo.ICProductCriteriaItemPercent / 100;
            else
                objProductCriteriaItemsInfo.ICProductCriteriaItemUnitPrice = objProductCriteriaItemsInfo.ICProductCriteriaItemProductUnitPrice - objProductCriteriaItemsInfo.ICProductCriteriaItemProductUnitPrice * objProductCriteriaItemsInfo.ICProductCriteriaItemPercent / 100;
            entity.ProductCriteriaItemList.GridControl.RefreshDataSource();
        }

        public void ChangeCriteriaItemIsIncrease()
        {
            ProductCriteriaEntities entity = (ProductCriteriaEntities)CurrentModuleEntity;
            if (entity.ProductCriteriaItemList.CurrentIndex < 0)
                return;

            ICProductCriteriaItemsInfo objProductCriteriaItemsInfo = entity.ProductCriteriaItemList[entity.ProductCriteriaItemList.CurrentIndex];
            if (objProductCriteriaItemsInfo.ICProductCriteriaItemIsIncrease)
                objProductCriteriaItemsInfo.ICProductCriteriaItemUnitPrice = objProductCriteriaItemsInfo.ICProductCriteriaItemProductUnitPrice + objProductCriteriaItemsInfo.ICProductCriteriaItemsDiscountAmount + objProductCriteriaItemsInfo.ICProductCriteriaItemProductUnitPrice * objProductCriteriaItemsInfo.ICProductCriteriaItemPercent / 100;
            else
                objProductCriteriaItemsInfo.ICProductCriteriaItemUnitPrice = objProductCriteriaItemsInfo.ICProductCriteriaItemProductUnitPrice - objProductCriteriaItemsInfo.ICProductCriteriaItemsDiscountAmount - objProductCriteriaItemsInfo.ICProductCriteriaItemProductUnitPrice * objProductCriteriaItemsInfo.ICProductCriteriaItemPercent / 100;
            if (objProductCriteriaItemsInfo.ICProductCriteriaItemUnitPrice < 0)
                objProductCriteriaItemsInfo.ICProductCriteriaItemUnitPrice = 0;
            entity.ProductCriteriaItemList.GridControl.RefreshDataSource();
        }

        public void ChangeCriteriaItemUnitPrice()
        {
            ProductCriteriaEntities entity = (ProductCriteriaEntities)CurrentModuleEntity;
            if (entity.ProductCriteriaItemList.CurrentIndex < 0)
                return;

            ICProductCriteriaItemsInfo objProductCriteriaItemsInfo = entity.ProductCriteriaItemList[entity.ProductCriteriaItemList.CurrentIndex];
            if (objProductCriteriaItemsInfo.ICProductCriteriaItemUnitPrice > objProductCriteriaItemsInfo.ICProductCriteriaItemProductUnitPrice)
                objProductCriteriaItemsInfo.ICProductCriteriaItemIsIncrease = true;
            if (objProductCriteriaItemsInfo.ICProductCriteriaItemType == ProductCriteriaDiscountType.Price.ToString())
            {
                if (objProductCriteriaItemsInfo.ICProductCriteriaItemIsIncrease)
                {
                    objProductCriteriaItemsInfo.ICProductCriteriaItemPercent = 0;
                    objProductCriteriaItemsInfo.ICProductCriteriaItemUnitPrice = objProductCriteriaItemsInfo.ICProductCriteriaItemsDiscountAmount + objProductCriteriaItemsInfo.ICProductCriteriaItemProductUnitPrice;
                }
                else
                {
                    objProductCriteriaItemsInfo.ICProductCriteriaItemPercent = 0;
                    objProductCriteriaItemsInfo.ICProductCriteriaItemUnitPrice = objProductCriteriaItemsInfo.ICProductCriteriaItemProductUnitPrice - objProductCriteriaItemsInfo.ICProductCriteriaItemsDiscountAmount;
                }
            }
            else
            {
                objProductCriteriaItemsInfo.ICProductCriteriaItemPercent = Math.Abs((objProductCriteriaItemsInfo.ICProductCriteriaItemUnitPrice - objProductCriteriaItemsInfo.ICProductCriteriaItemProductUnitPrice) / objProductCriteriaItemsInfo.ICProductCriteriaItemProductUnitPrice * 100);
                objProductCriteriaItemsInfo.ICProductCriteriaItemsDiscountAmount = 0;
            }
            entity.ProductCriteriaItemList.GridControl.RefreshDataSource();
        }

        public void ChangeCriteriaItemDiscountAmount()
        {
            ProductCriteriaEntities entity = (ProductCriteriaEntities)CurrentModuleEntity;
            if (entity.ProductCriteriaItemList.CurrentIndex < 0)
                return;

            ICProductCriteriaItemsInfo objProductCriteriaItemsInfo = entity.ProductCriteriaItemList[entity.ProductCriteriaItemList.CurrentIndex];
            objProductCriteriaItemsInfo.ICProductCriteriaItemPercent = 0;
            if (objProductCriteriaItemsInfo.ICProductCriteriaItemIsIncrease)
                objProductCriteriaItemsInfo.ICProductCriteriaItemUnitPrice = objProductCriteriaItemsInfo.ICProductCriteriaItemProductUnitPrice + objProductCriteriaItemsInfo.ICProductCriteriaItemsDiscountAmount;
            else
                objProductCriteriaItemsInfo.ICProductCriteriaItemUnitPrice = objProductCriteriaItemsInfo.ICProductCriteriaItemProductUnitPrice - objProductCriteriaItemsInfo.ICProductCriteriaItemsDiscountAmount;
            entity.ProductCriteriaItemList.GridControl.RefreshDataSource();
        }

        public void UpdateTotalAmount()
        {
            ProductCriteriaEntities entity = (ProductCriteriaEntities)CurrentModuleEntity;
            ICProductCriteriasInfo objProductCriteriasInfo = (ICProductCriteriasInfo)entity.MainObject;
            List<ICProductCriteriaItemsInfo> productCriteriaItemsList = entity.ProductCriteriaItemList;
            productCriteriaItemsList.ForEach(o =>
            {
                o.ICProductCriteriaItemType = objProductCriteriasInfo.ICProductCriteriaDiscountType;
                o.ICProductCriteriaItemIsIncrease = objProductCriteriasInfo.ICProductCriteriaIsIncrease;
                if (o.ICProductCriteriaItemType == ProductCriteriaDiscountType.Percent.ToString())
                {
                    o.ICProductCriteriaItemsDiscountAmount = 0;
                }
                else
                {
                    o.ICProductCriteriaItemPercent = 0;
                }
                if (objProductCriteriasInfo.ICProductCriteriaDiscountPercent > 0)
                {
                    o.ICProductCriteriaItemPercent = objProductCriteriasInfo.ICProductCriteriaDiscountPercent;
                }
                if (objProductCriteriasInfo.ICProductCriteriaDiscountAmount > 0)
                {
                    o.ICProductCriteriaItemsDiscountAmount = objProductCriteriasInfo.ICProductCriteriaDiscountAmount;
                }

                if (o.ICProductCriteriaItemIsIncrease)
                    o.ICProductCriteriaItemUnitPrice = o.ICProductCriteriaItemsDiscountAmount + o.ICProductCriteriaItemProductUnitPrice + o.ICProductCriteriaItemProductUnitPrice * o.ICProductCriteriaItemPercent / 100;
                else
                    o.ICProductCriteriaItemUnitPrice = o.ICProductCriteriaItemProductUnitPrice - o.ICProductCriteriaItemsDiscountAmount - o.ICProductCriteriaItemProductUnitPrice * o.ICProductCriteriaItemPercent / 100;
                if (o.ICProductCriteriaItemUnitPrice < 0)
                    o.ICProductCriteriaItemUnitPrice = 0;
            });
            entity.ProductCriteriaItemList.GridControl.RefreshDataSource();
        }

        public void UpdateTotalAmount(string productCriteriaDiscountType)
        {
            ProductCriteriaEntities entity = (ProductCriteriaEntities)CurrentModuleEntity;
            ICProductCriteriasInfo objProductCriteriasInfo = (ICProductCriteriasInfo)entity.MainObject;
            objProductCriteriasInfo.ICProductCriteriaDiscountType = productCriteriaDiscountType;
            entity.ProductCriteriaItemList.GridControl.RefreshDataSource();
            UpdateTotalAmount();
        }

        public override void ActionNew()
        {
            base.ActionNew();
            ProductCriteriasDiscountPercentTextBox.Enabled = true;
            ProductCriteriasDiscountPercentTextBox.BackColor = Color.White;
            ProductCriteriasDiscountAmountTextBox.Enabled = false;
            ProductCriteriasDiscountAmountTextBox.BackColor = Color.WhiteSmoke;
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            ProductCriteriaEntities entity = (ProductCriteriaEntities)CurrentModuleEntity;
            ICProductCriteriasInfo objProductCriteriasInfo = (ICProductCriteriasInfo)entity.MainObject;

            if (objProductCriteriasInfo.ICProductCriteriaDiscountType == ProductCriteriaDiscountType.Percent.ToString())
            {
                ProductCriteriasDiscountPercentTextBox.Enabled = true;
                ProductCriteriasDiscountPercentTextBox.BackColor = Color.White;
                ProductCriteriasDiscountAmountTextBox.Enabled = false;
                ProductCriteriasDiscountAmountTextBox.BackColor = Color.WhiteSmoke;
            }
            else
            {
                ProductCriteriasDiscountPercentTextBox.Enabled = false;
                ProductCriteriasDiscountPercentTextBox.BackColor = Color.WhiteSmoke;
                ProductCriteriasDiscountAmountTextBox.Enabled = true;
                ProductCriteriasDiscountAmountTextBox.BackColor = Color.White;
            }
        }
    }
}
