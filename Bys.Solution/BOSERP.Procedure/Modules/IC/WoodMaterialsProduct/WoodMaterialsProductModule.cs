using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Utilities;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BOSERP.Modules.WoodMaterialsProduct
{
    class WoodMaterialsProductModule : BaseModuleERP
    {
        public const string ProductGroupsButtonEditName = "fld_bedFK_ICProductGroupID";
        public const string ProductParentLookupName = "fld_lkeFK_ICProductParentID";
        public const string ProductionNormItemLookupName = "fld_lkeFK_MMProductionNormItemID";
        public const string WoodTypeLookupName = "fld_lkeFK_ICProductAttributeWoodTypeID";
        public const string ICProductPicturePictureBoxName = "fld_ptbICProductPicture";
        public const string ProductBasicUnitLookUpName = "fld_lkeFK_ICProductBasicUnitID";

        private BOSButtonEdit ProductGroupsButtonEdit;
        public BOSLookupEdit ProductParentLookupEditControl;
        public BOSLookupEdit ProductionNormItemLookupEditControl;
        public BOSLookupEdit WoodTypeLookupLookupEditControl;
        private List<ICProductsInfo> ProductList { get; set; }
        private List<MMProductionNormItemsInfo> ProductionNormItemList { get; set; }
        public bool isChangeBOM { get; set; }
        public MMProductionNormItemsInfo objProductionNormItemsInfo { get; set; }
        private PictureBox ProductPicturePictureBox;
        private BOSLookupEdit ProductBasicUnitLookUpControl;
        public WoodMaterialsProductModule()
        {
            Name = "WoodMaterialsProduct";
            CurrentModuleEntity = new WoodMaterialsProductEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            ProductGroupsButtonEdit = (BOSButtonEdit)Controls[WoodMaterialsProductModule.ProductGroupsButtonEditName];
            ProductParentLookupEditControl = (BOSLookupEdit)Controls[ProductParentLookupName];
            ICProductsController objProductController = new ICProductsController();
            List<ICProductsForViewInfo> productList = new List<ICProductsForViewInfo>();
            productList = BOSApp.CurrentProductList.Where(p => p.ICProductType == ProductType.Product.ToString()).ToList();
            ProductParentLookupEditControl.Properties.DataSource = ProductList;
            ProductionNormItemLookupEditControl = (BOSLookupEdit)Controls[ProductionNormItemLookupName];
            //WoodTypeLookupLookupEditControl = (BOSLookupEdit)Controls[WoodTypeLookupName];
            MMProductionNormItemsController productionNormItemsController = new MMProductionNormItemsController();
            ProductionNormItemList = productionNormItemsController.GetAllAliveSemiProductParent()
                                                                  .Where(o => o.MMProductionNormItemParentID == 0)
                                                                  .GroupBy(o => o.FK_ICProductID)
                                                                  .Select(o => o.First())
                                                                  .ToList();
            MMProductionNormItemsInfo objProductionNormItemsInfo = (MMProductionNormItemsInfo)productionNormItemsController.GetObjectByID(0);
            if (objProductionNormItemsInfo != null)
                ProductionNormItemList.Add(objProductionNormItemsInfo);
            ProductionNormItemLookupEditControl.Properties.DataSource = ProductionNormItemList;
            objProductionNormItemsInfo = new MMProductionNormItemsInfo();
            isChangeBOM = false;
            ProductPicturePictureBox = (PictureBox)Controls[ICProductPicturePictureBoxName];
            ProductBasicUnitLookUpControl = (BOSLookupEdit)Controls[ProductBasicUnitLookUpName];
            //GetWoodTypeDatasource();


        }
        //public void GetWoodTypeDatasource()
        //{
        //    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
        //    List<ICProductAttributesInfo> listData = objProductAttributesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.WoodType.ToString());
        //    if (listData != null)
        //    {
        //        //WoodTypeLookupLookupEditControl.Properties.DataSource = listData;
        //    }
        //}
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            ICProductsInfo objProductsInfo = (ICProductsInfo)CurrentModuleEntity.MainObject;
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            objProductsInfo.ICProductGroupName = objProductGroupsController.GetObjectNameByID(objProductsInfo.FK_ICProductGroupID);
            ProductGroupsButtonEdit.Text = objProductsInfo.ICProductGroupName;
            // InvalidateProductComponentList(iObjectID);

            //EnableControlByProductType(ProductType.SemiProduct, true, false);
            //isEditProductType = false;

            objProductsInfo.ICProductPrimaryImage = ApiClientHelper.GetProductPrimaryImage(objProductsInfo.ICProductID);
            if (ProductPicturePictureBox != null)
                ProductPicturePictureBox.Image = objProductsInfo.ICProductPrimaryImage;
            ICTransactionsController objTransactionsController = new ICTransactionsController();
            bool isTransaction = objTransactionsController.GetTransactionByProductID(objProductsInfo.ICProductID);
            ProductBasicUnitLookUpControl.Properties.ReadOnly = isTransaction;
        }

        public void ShowCategoryTree()
        {
            if (IsEditable())
            {
                ActionEdit();
            }

            WoodMaterialsProductEntities entity = (WoodMaterialsProductEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
            ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
            ICDepartmentsInfo objICDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByNo(BOSApp.GetDisplayTextFromConfigText(ConfigValueGroup.DepartmentGroup, DepartmentGroup.SemiProductNo.ToString()));
            int departmentID = 1;
            if (objICDepartmentsInfo != null)
                departmentID = objICDepartmentsInfo.ICDepartmentID;
            if (objProductsInfo.FK_ICDepartmentID > 0)
                departmentID = objProductsInfo.FK_ICDepartmentID;
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(departmentID, objProductsInfo.FK_ICProductGroupID, objProductsInfo.ICProductType);
            guiProductGroupTree.Module = this;
            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {
                ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)guiProductGroupTree.TreeList.GetSelectedObject();
                if (objProductGroupsInfo != null)
                {
                    objProductsInfo.FK_ICDepartmentID = guiProductGroupTree.ICDepartmentID;
                    objProductsInfo.FK_ICProductGroupID = objProductGroupsInfo.ICProductGroupID;
                    objProductsInfo.ICProductGroupNo = objProductGroupsInfo.ICProductGroupNo;
                    objProductsInfo.ICProductGroupName = guiProductGroupTree.GetSelectedProductGroupName();
                }
                else
                {
                    objProductsInfo.FK_ICProductGroupID = 0;
                    objProductsInfo.ICProductGroupName = string.Empty;
                }
                entity.UpdateMainObjectBindingSource();
            }
        }
        public override void ActionNew()
        {
            base.ActionNew();

            ICProductsInfo objProductsInfo = (ICProductsInfo)((WoodMaterialsProductEntities)CurrentModuleEntity).MainObject;
            objProductsInfo.ICProductStockMinDateFrom = DateTime.Now;
            objProductsInfo.ICProductStockMinDateTo = BOSUtil.GetYearEndDate();
            objProductsInfo.ICProductStockMaxDateFrom = DateTime.Now;
            objProductsInfo.ICProductStockMaxDateTo = BOSUtil.GetYearEndDate();
            /// isEditProductType = false;
            SetDefaultAccountByProductType();
            if (ProductBasicUnitLookUpControl != null)
            {
                ProductBasicUnitLookUpControl.Properties.ReadOnly = false;
            }
        }
        public void SetDefaultAccountByProductType()
        {
            ICProductsInfo product = (ICProductsInfo)CurrentModuleEntity.MainObject;
            ICProductTypeAccountConfigsController ctacsController = new ICProductTypeAccountConfigsController();
            ICProductTypeAccountConfigsInfo ctac = ctacsController.GetObjectByProductType(product.ICProductType);
            if (ctac != null)
            {
                product.FK_ICProductTypeAccountConfigID = ctac.ICProductTypeAccountConfigID;
                product.FK_ACAccountCostPriceID = ctac.FK_ACAccountCostPriceID;
                product.FK_ACAccountDiscountID = ctac.FK_ACAccountDiscountID;
                product.FK_ACAccountID = ctac.FK_ACAccountID;
                product.FK_ACAccountRevenueID = ctac.FK_ACAccountRevenueID;
                product.FK_ACAccountRevenueInternalID = ctac.FK_ACAccountRevenueInternalID;
                product.FK_ACAccountSaleReturnID = ctac.FK_ACAccountSaleReturnID;
            }
        }
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo searchObject = (ICProductsInfo)CurrentModuleEntity.SearchObject;
            searchObject.ICProductType = ProductType.SemiProduct.ToString();
            DataSet ds = objProductsController.GetProductSet(BOSApp.CurrentCompanyInfo.CSCompanyID,
                                                        searchObject.ICProductNo,
                                                        searchObject.ICProductSupplierNumber,
                                                        searchObject.ICProductType,
                                                        BOSUtil.GetSearchString(searchObject.ICProductDesc),
                                                        searchObject.FK_ICDepartmentID,
                                                        searchObject.FK_ICProductGroupID,
                                                        searchObject.FK_APSupplierID,
                                                        searchObject.ICProductBarCode,
                                                        0);
            return ds;
        }
        public void ShowEditAttributeForm()
        {
            if (IsEditable())
            {
                ActionEdit();
            }

            ICProductsInfo objProductsInfo = (ICProductsInfo)CurrentModuleEntity.MainObject;
            guiEditAttribute guiEditAttribute = new guiEditAttribute(objProductsInfo);
            guiEditAttribute.Module = this;
            if (guiEditAttribute.ShowDialog() == DialogResult.OK)
            {
                objProductsInfo.ICProductAttributeKey = guiEditAttribute.ICProductAttributeKey;
                objProductsInfo.ICProductAttribute = guiEditAttribute.ICProductAttribute;
                objProductsInfo.ICProductAttributeNo = guiEditAttribute.ICProductAttributeNo;
                CurrentModuleEntity.UpdateMainObjectBindingSource();
            }
        }
        public bool CheckExistProduct(string productType)
        {
            bool isExist = false;
            List<ICProductsInfo> productsList = new List<ICProductsInfo>();
            WoodMaterialsProductEntities entity = (WoodMaterialsProductEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            productsList = objProductsController.GetProductByProductType(productType);
            if (Toolbar.IsNewAction())
            {
                if (productsList.Count > 0)
                {

                    PropertyInfo[] props = objProductsInfo.GetType().GetProperties();
                    object oldValue;
                    foreach (PropertyInfo propInfo in props)
                    {
                        BOSDbUtil bosDbUtil = new BOSDbUtil();
                        oldValue = bosDbUtil.GetPropertyValue(objProductsInfo, propInfo.Name);
                        if (oldValue != null)
                        {
                            if ((propInfo.Name.Substring(0, 2) != "AA") && propInfo.Name != "ICProductNo" && propInfo.Name != "ICProductID"
                                 && propInfo.Name != "ICProductStockMinDateFrom" && propInfo.Name != "ICProductStockMaxDateFrom" && propInfo.Name != "ICProductPicture"
                            && propInfo.Name != "ICProductStockMinDateTo" && propInfo.Name != "ICProductStockMaxDateTo" && propInfo.Name != "ICProductIdentifyAttribute"
                            && propInfo.Name != "ICProductIdentifyWoodType" && propInfo.Name != "ICProductIdentifyFirstAndLastName" && propInfo.Name != "ICProductIdentifyColor" && propInfo.Name != "ICProductIdentifyPaintType"
                               && propInfo.Name != "ICProductGroupNo" && propInfo.Name != "ICProductGroupName" && propInfo.Name != "ICProductGroupParentName" && propInfo.Name != "ICInventoryStockQuantity"
                               && propInfo.Name != "ICInventoryStockProposalQuantity" && propInfo.Name != "ICInventoryStockSaleOrderQuantity" && propInfo.Name != "ICInventoryStockAvailableQuantity"
                               && propInfo.Name != "ICInventoryStockPurchaseOrderQuantity" && propInfo.Name != "ICInventoryStockTransitOutQuantity" && propInfo.Name != "ICInventoryStockTransitInQuantity" && propInfo.Name != "ICInventoryStockMaintainanceQuantity"
                               && propInfo.Name != "ICInventoryStockExtCost" && propInfo.Name != "ICInventoryStockExtPrice" && propInfo.Name != "ICInventoryStockTotalQty" && propInfo.Name != "ICStockType"
                                && propInfo.Name != "InventoryStatus" && propInfo.Name != "ARInvoiceItemProductQty" && propInfo.Name != "ARInvoiceItemTotalAmount" && propInfo.Name != "ARInvoiceItemTotalCost"
                                && propInfo.Name != "ICPackageProductQty" && propInfo.Name != "ICMeasureUnitName" && propInfo.Name != "ICStockName" && propInfo.Name != "ICStockID"
                                && propInfo.Name != "HRDepartmentRoomID" && propInfo.Name != "ICInventoryStockQuantityToPrint" && propInfo.Name != "BarcodeImage" && propInfo.Name != "ICProductOrderID" && propInfo.Name != "ICProductItemQty"
                            && propInfo.Name != "ICProductNoOfOldSys" && propInfo.Name != "ICProductName" && propInfo.Name != "ICProductDesc" && propInfo.Name != "FK_ICProductBasicUnitID" && propInfo.Name != "FK_ICProductSaleUnitID" && propInfo.Name != "FK_ICProductPurchaseUnitID")
                            {
                                if (propInfo.GetType() != typeof(byte[]))
                                {
                                    if (productsList != null)
                                    {
                                        productsList = GetListByProp(productsList, propInfo, objProductsInfo);
                                    }
                                    if (productsList != null && productsList.Count == 0)
                                    {

                                    }
                                }
                            }
                        }
                    }
                    if (productsList != null && productsList.Count > 0)
                    {
                        MessageBox.Show(string.Format("Hàng hóa đã tồn tại trong hệ thống. Mã " + productsList[0].ICProductNo + ": " + productsList[0].ICProductDesc),
                                     CommonLocalizedResources.MessageBoxDefaultCaption,
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                        isExist = true;
                    }
                }
            }
            return isExist;
        }
        public void ShowCategoryTreeForSearch()
        {
            ICProductsInfo searchObject = (ICProductsInfo)CurrentModuleEntity.SearchObject;
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(searchObject.FK_ICDepartmentID, searchObject.FK_ICProductGroupID);
            guiProductGroupTree.Module = this;
            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {
                ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)guiProductGroupTree.TreeList.GetSelectedObject();
                if (objProductGroupsInfo != null)
                {
                    searchObject.FK_ICProductGroupID = objProductGroupsInfo.ICProductGroupID;
                    searchObject.ICProductGroupName = guiProductGroupTree.GetSelectedProductGroupName();
                }
                else
                {
                    searchObject.FK_ICProductGroupID = 0;
                    searchObject.ICProductGroupName = string.Empty;
                }
                CurrentModuleEntity.UpdateSearchObjectBindingSource();
            }
        }
        public void RemoveSelectedItemFromProductSupplier(ProductSuppliersGridControl productSupplierGridControl)
        {
            BOSList<ICProductSuppliersInfo> productSupplierList = (BOSList<ICProductSuppliersInfo>)((BindingSource)productSupplierGridControl.DataSource).DataSource;
            productSupplierList.GridControl = productSupplierGridControl;
            productSupplierList.RemoveSelectedRowObjectFromList();
        }
        public void ShowSuppliersForm()
        {
            guiChooseSupplier chooseSupplierForm = new guiChooseSupplier();
            chooseSupplierForm.Module = this;
            if (chooseSupplierForm.ShowDialog() == DialogResult.OK)
            {
                BackupProductSuppliers();
            }
            else
            {
                RollbackProductSuppliers();
            }
        }
        private void BackupProductSuppliers()
        {
            WoodMaterialsProductEntities entity = (WoodMaterialsProductEntities)CurrentModuleEntity;
            entity.ICProductSuppliersList.BackupList.Clear();
            foreach (ICProductSuppliersInfo objProductSuppliersInfo in entity.ICProductSuppliersList)
            {
                entity.ICProductSuppliersList.BackupList.Add((ICProductSuppliersInfo)objProductSuppliersInfo.Clone());
            }
        }
        private void RollbackProductSuppliers()
        {
            WoodMaterialsProductEntities entity = (WoodMaterialsProductEntities)CurrentModuleEntity;
            entity.ICProductSuppliersList.Clear();
            entity.ICProductSuppliersList.Invalidate(entity.ICProductSuppliersList.BackupList);
        }

        public List<ICProductsInfo> GetListByProp(List<ICProductsInfo> productsList, PropertyInfo prop, ICProductsInfo objProductsInfo)
        {
            List<ICProductsInfo> productsCheckList = new List<ICProductsInfo>();
            object oldValue;
            object newValue;
            PropertyInfo[] props = null;
            foreach (ICProductsInfo item in productsList)
            {
                props = item.GetType().GetProperties();

                foreach (PropertyInfo propInfo in props)
                {
                    if ((propInfo.Name.Substring(0, 2) != "AA"))
                    {
                        if (propInfo.GetType() != typeof(byte[]))
                        {
                            if (propInfo.Name == prop.Name && propInfo.Name != "ICProductNo" && propInfo.Name != "ICProductID"
                                 && propInfo.Name != "ICProductStockMinDateFrom" && propInfo.Name != "ICProductStockMaxDateFrom" && propInfo.Name != "ICProductPicture"
                            && propInfo.Name != "ICProductStockMinDateTo" && propInfo.Name != "ICProductStockMaxDateTo" && propInfo.Name != "ICProductIdentifyAttribute"
                            && propInfo.Name != "ICProductIdentifyWoodType" && propInfo.Name != "ICProductIdentifyFirstAndLastName" && propInfo.Name != "ICProductIdentifyColor" && propInfo.Name != "ICProductIdentifyPaintType"
                                 && propInfo.Name != "ICProductGroupNo" && propInfo.Name != "ICProductGroupName" && propInfo.Name != "ICProductGroupParentName" && propInfo.Name != "ICInventoryStockQuantity"
                              && propInfo.Name != "ICInventoryStockProposalQuantity" && propInfo.Name != "ICInventoryStockSaleOrderQuantity" && propInfo.Name != "ICInventoryStockAvailableQuantity"
                              && propInfo.Name != "ICInventoryStockPurchaseOrderQuantity" && propInfo.Name != "ICInventoryStockTransitOutQuantity" && propInfo.Name != "ICInventoryStockTransitInQuantity" && propInfo.Name != "ICInventoryStockMaintainanceQuantity"
                              && propInfo.Name != "ICInventoryStockExtCost" && propInfo.Name != "ICInventoryStockExtPrice" && propInfo.Name != "ICInventoryStockTotalQty" && propInfo.Name != "ICStockType"
                               && propInfo.Name != "InventoryStatus" && propInfo.Name != "ARInvoiceItemProductQty" && propInfo.Name != "ARInvoiceItemTotalAmount" && propInfo.Name != "ARInvoiceItemTotalCost"
                               && propInfo.Name != "ICPackageProductQty" && propInfo.Name != "ICMeasureUnitName" && propInfo.Name != "ICStockName" && propInfo.Name != "ICStockID"
                               && propInfo.Name != "ICProductComponentQty" && propInfo.Name != "APSupplierName" && propInfo.Name != "EquipmentReceiptedQty" && propInfo.Name != "EquipmentShippedQty"
                               && propInfo.Name != "HRDepartmentRoomID" && propInfo.Name != "ICInventoryStockQuantityToPrint" && propInfo.Name != "BarcodeImage" && propInfo.Name != "ICProductOrderID" && propInfo.Name != "ICProductItemQty")
                            {
                                BOSDbUtil bosDbUtil = new BOSDbUtil();
                                newValue = bosDbUtil.GetPropertyValue(objProductsInfo, propInfo.Name);
                                oldValue = bosDbUtil.GetPropertyValue(item, propInfo.Name);
                                if (oldValue != null && newValue != null && oldValue.Equals(newValue))
                                {
                                    productsCheckList.Add(item);
                                }
                            }
                        }
                    }
                }
            }
            return productsCheckList;
        }
        public void SetDefaultProductDesc()
        {
            ICProductsInfo objProductsInfo = (ICProductsInfo)CurrentModuleEntity.MainObject;
            objProductsInfo.ICProductDesc = objProductsInfo.ICProductName.Trim();
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            ICProductAttributesInfo objProductAttributesInfo = null;
            if (objProductsInfo.ICProductType != ProductType.Roundwood.ToString())
            {
                if (objProductsInfo.ICProductHeight > 0 || objProductsInfo.ICProductWidth > 0 || objProductsInfo.ICProductLength > 0)
                {
                    objProductsInfo.ICProductDesc += string.Format(string.IsNullOrEmpty(objProductsInfo.ICProductDesc) ? "{0}" : ", {0}",
                                              "W" + objProductsInfo.ICProductWidth + "xD" + objProductsInfo.ICProductLength + "xH" + objProductsInfo.ICProductHeight + " mm");
                }
                else
                {
                    if (objProductsInfo.ICProductHeight > 0 || objProductsInfo.ICProductWidth > 0 || objProductsInfo.ICProductLength > 0
                        )
                    {
                        objProductsInfo.ICProductDesc += string.Format(string.IsNullOrEmpty(objProductsInfo.ICProductDesc) ? "{0}" : ", {0}", "(" + objProductsInfo.ICProductHeight + ")"
                                                                            + "(" + objProductsInfo.ICProductWidth + ")"
                                                                            + "(" + objProductsInfo.ICProductLength + ")");
                    }
                }
            }
            else
            {
                if (objProductsInfo.ICProductLength > 0)
                {
                    objProductsInfo.ICProductDesc += string.Format(string.IsNullOrEmpty(objProductsInfo.ICProductDesc) ? "{0}" : ", {0}", objProductsInfo.ICProductLength);
                }
            }
            if (objProductsInfo.FK_ICProductAttributeWoodTypeID > 0)
            {
                objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(objProductsInfo.FK_ICProductAttributeWoodTypeID);
                if (objProductAttributesInfo != null)
                {
                    objProductsInfo.ICProductDesc += string.Format(", {0}", objProductAttributesInfo.ICProductAttributeValue);
                }
            }

            if (objProductsInfo.FK_ICProductAttributeColorID > 0)
            {
                objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(objProductsInfo.FK_ICProductAttributeColorID);
                if (objProductAttributesInfo != null)
                {
                    objProductsInfo.ICProductDesc += string.Format(", {0}", objProductAttributesInfo.ICProductAttributeValue);
                }
            }
            if (objProductsInfo.FK_ICProductAttributeFinishingID > 0)
            {
                objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(objProductsInfo.FK_ICProductAttributeFinishingID);
                if (objProductAttributesInfo != null)
                {
                    objProductsInfo.ICProductDesc += string.Format(", {0}", objProductAttributesInfo.ICProductAttributeValue);
                }
            }
            if (objProductsInfo.ICProductAttributeKey != null)
            {
                string[] attributeValueIDs = objProductsInfo.ICProductAttributeKey.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
                ICDepartmentAttributeValuesController objDepartmentAttributeValuesController = new ICDepartmentAttributeValuesController();
                for (int i = 0; i < attributeValueIDs.Length; i++)
                {
                    int attributeValueID = Convert.ToInt32(attributeValueIDs[i]);
                    ICDepartmentAttributeValuesInfo objDepartmentAttributeValuesInfo = (ICDepartmentAttributeValuesInfo)objDepartmentAttributeValuesController.GetObjectByID(attributeValueID);
                    objProductsInfo.ICProductDesc += string.Format(", {0}", objDepartmentAttributeValuesInfo.ICDepartmentAttributeValueValue);
                }
            }

            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        public void ChangeProductTypeAccountConfig(int customerTypeAccountConfigID)
        {
            WoodMaterialsProductEntities entity = (WoodMaterialsProductEntities)CurrentModuleEntity;
            ICProductsInfo product = (ICProductsInfo)entity.MainObject;
            product.FK_ICProductTypeAccountConfigID = customerTypeAccountConfigID;

            ICProductTypeAccountConfigsInfo ctac = new ICProductTypeAccountConfigsInfo();
            ICProductTypeAccountConfigsController ctacsController = new ICProductTypeAccountConfigsController();
            if (customerTypeAccountConfigID > 0)
            {
                ctac = (ICProductTypeAccountConfigsInfo)ctacsController.GetObjectByID(customerTypeAccountConfigID);
                if (ctac != null)
                {
                    product.FK_ACAccountCostPriceID = ctac.FK_ACAccountCostPriceID;
                    product.FK_ACAccountDiscountID = ctac.FK_ACAccountDiscountID;
                    product.FK_ACAccountID = ctac.FK_ACAccountID;
                    product.FK_ACAccountRevenueID = ctac.FK_ACAccountRevenueID;
                    product.FK_ACAccountRevenueInternalID = ctac.FK_ACAccountRevenueInternalID;
                    product.FK_ACAccountSaleReturnID = ctac.FK_ACAccountSaleReturnID;
                }
            }

            entity.UpdateMainObjectBindingSource();
        }

        public override int ActionSave()
        {
            WoodMaterialsProductEntities entity = (WoodMaterialsProductEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)CurrentModuleEntity.MainObject;
            if (string.IsNullOrEmpty(objProductsInfo.ICProductGroupName))
            {
                MessageBox.Show("Vui lòng chọn nhóm hàng!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            string productPrimaryPath = objProductsInfo.ICProductPrimaryPath;
            int result = base.ActionSave();
            MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            if (isChangeBOM)
            {
                objProductionNormItemsInfo.MMProductionNormItemProductHeight = objProductsInfo.ICProductHeight;
                objProductionNormItemsInfo.MMProductionNormItemProductWidth = objProductsInfo.ICProductWidth;
                objProductionNormItemsInfo.MMProductionNormItemProductLength = objProductsInfo.ICProductLength;
                if (objProductsInfo.FK_ICProductAttributeWoodTypeID > 0)
                {
                    ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(objProductsInfo.FK_ICProductAttributeWoodTypeID);
                    if (objProductAttributesInfo != null)
                        objProductionNormItemsInfo.MMProductionNormItemProductWoodType = objProductAttributesInfo.ICProductAttributeValue;
                }
                objProductionNormItemsController.UpdateObject(objProductionNormItemsInfo);
            }

            if (!BOSApp.CurrentProductList.Any(o => o.ICProductID == objProductsInfo.ICProductID))
            {
                ICProductsForViewInfo newObj = new ICProductsForViewInfo();
                BOSUtil.CopyViewObject(objProductsInfo, newObj);
                BOSApp.CurrentProductList.Add(newObj);
            }

            if (result > 0)
            {
                BOSProgressBar.Start("Đang lưu hình ảnh sản phẩm");
                entity.SavePrimaryImage(productPrimaryPath);
                UpdateProductImage();
                BOSProgressBar.Close();
            }

            return result;
        }

        public void UpdateProductImage()
        {
            WoodMaterialsProductEntities entity = (WoodMaterialsProductEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
            objProductsInfo.ICProductPrimaryImage = ApiClientHelper.GetProductPrimaryImage(objProductsInfo.ICProductID);
            if (ProductPicturePictureBox != null)
                ProductPicturePictureBox.Image = objProductsInfo.ICProductPrimaryImage;
            entity.UpdateMainObjectBindingSource();
        }

        public void RemoveProductMeasureUnitList()
        {
            WoodMaterialsProductEntities entity = (WoodMaterialsProductEntities)CurrentModuleEntity;
            entity.ProductMeasureUnitList.RemoveSelectedRowObjectFromList();
        }

        public void UpdatePrimaryImage(String path)
        {
            WoodMaterialsProductEntities entity = (WoodMaterialsProductEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)CurrentModuleEntity.MainObject;
            objProductsInfo.ICProductPrimaryPath = path;
            entity.UpdateMainObjectBindingSource();
        }
    }
}
