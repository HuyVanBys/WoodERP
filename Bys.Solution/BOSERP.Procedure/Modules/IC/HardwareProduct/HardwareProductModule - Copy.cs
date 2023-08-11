using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.Product;
using BOSERP.Utilities;
using BOSLib;
using BOSReport;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace BOSERP.Modules.HardwareProduct
{
    class HardwareProductModule : BaseModuleERP
    {
        public const string ICProductPicturePictureBoxName = "fld_ptbICProductPicture";
        public const string ICProductImagesGridControlName = "fld_dgcICProductImagesGridControl";
        public const string ProductGroupsButtonEditName = "fld_bedFK_ICProductGroupID";
        public const string ProductComponentsGridControlName = "fld_dgcProductComponentGridControl";
        public const string ProductBasicUnitLookUpName = "fld_lkeFK_ICProductBasicUnitID";

        public bool isEditProductType { get; set; }
        private BOSButtonEdit ProductGroupsButtonEdit;
        private DataTable ProductBranchPriceTable;
        private PictureBox ProductPicturePictureBox;
        private BOSTextBox ProductImageFile;
        private BOSLookupEdit ProductBasicUnitLookUpControl;
        public HardwareProductModule()
        {
            Name = "HardwareProduct";
            CurrentModuleEntity = new HardwareProductEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            ProductGroupsButtonEdit = (BOSButtonEdit)Controls[HardwareProductModule.ProductGroupsButtonEditName];
            ProductPicturePictureBox = (PictureBox)Controls[HardwareProductModule.ICProductPicturePictureBoxName];
            ProductImageFile = (BOSTextBox)Controls["fld_txtICProductImageFile"];
            ProductBasicUnitLookUpControl = (BOSLookupEdit)Controls[ProductBasicUnitLookUpName];
        }
        public override void Invalidate(int iObjectID)
        {

            base.Invalidate(iObjectID);
            HardwareProductEntities entity = (HardwareProductEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
            ProductPicturePictureBox.Image = null;
            InitProductPictureImage(objProductsInfo.ICProductImageFile);
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            objProductsInfo.ICProductGroupName = objProductGroupsController.GetObjectNameByID(objProductsInfo.FK_ICProductGroupID);
            ProductGroupsButtonEdit.Text = objProductsInfo.ICProductGroupName;
            ICTransactionsController objTransactionsController = new ICTransactionsController();
            bool isTransaction = objTransactionsController.GetTransactionByProductID(objProductsInfo.ICProductID);
            ProductBasicUnitLookUpControl.Properties.ReadOnly = isTransaction;
            //InvalidateProductComponentList(iObjectID);
            //isEditProductType = false;

            //OldProduct = (ICProductsInfo)objProductsInfo.Clone();
        }


        public override void ActionNew()
        {
            base.ActionNew();

            ICProductsInfo objProductsInfo = (ICProductsInfo)((HardwareProductEntities)CurrentModuleEntity).MainObject;
            objProductsInfo.ICProductStockMinDateFrom = DateTime.Now;
            objProductsInfo.ICProductStockMinDateTo = BOSUtil.GetYearEndDate();
            objProductsInfo.ICProductStockMaxDateFrom = DateTime.Now;
            objProductsInfo.ICProductStockMaxDateTo = BOSUtil.GetYearEndDate();
            objProductsInfo.ICProductPromotionCheck = false;
            isEditProductType = false;
            if (ProductBasicUnitLookUpControl != null)
            {
                ProductBasicUnitLookUpControl.Properties.ReadOnly = false;
            }
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
            HardwareProductEntities entity = (HardwareProductEntities)CurrentModuleEntity;
            entity.ICProductSuppliersList.BackupList.Clear();
            foreach (ICProductSuppliersInfo objProductSuppliersInfo in entity.ICProductSuppliersList)
            {
                entity.ICProductSuppliersList.BackupList.Add((ICProductSuppliersInfo)objProductSuppliersInfo.Clone());
            }
        }
        private void RollbackProductSuppliers()
        {
            HardwareProductEntities entity = (HardwareProductEntities)CurrentModuleEntity;
            entity.ICProductSuppliersList.Clear();
            entity.ICProductSuppliersList.Invalidate(entity.ICProductSuppliersList.BackupList);
        }
        public void SetDefaultProductDesc()
        {
            ICProductsInfo objProductsInfo = (ICProductsInfo)CurrentModuleEntity.MainObject;
            objProductsInfo.ICProductDesc = string.Empty;
            if (objProductsInfo.ICProductType == ProductType.Hardware.ToString())
            {
                List<string> item = new List<string>();
                if (objProductsInfo.ICProductName != string.Empty)
                    item.Add(objProductsInfo.ICProductName);

                if (objProductsInfo.ICProductGroupName != string.Empty)
                    item.Add(objProductsInfo.ICProductGroupName);

                if (objProductsInfo.ICProductSizeAndSpecifiCations != string.Empty)
                    item.Add(objProductsInfo.ICProductSizeAndSpecifiCations.ToString());

                if (objProductsInfo.ICProductAttribute != string.Empty)
                    item.Add(objProductsInfo.ICProductAttribute);

                string productSize = string.Empty;
                if (objProductsInfo.ICProductWidth != 0 || objProductsInfo.ICProductLength != 0 || objProductsInfo.ICProductHeight != 0)
                {
                    productSize = "R:" + ((int)objProductsInfo.ICProductWidth).ToString() + "(mm)" + " x "
                                + "D:" + ((int)objProductsInfo.ICProductLength).ToString() + "(mm)" + " x "
                                + "C:" + ((int)objProductsInfo.ICProductHeight).ToString() + "(mm)";
                    item.Add(productSize);
                }

                if (objProductsInfo.ICProductDiameter > 0)
                {
                    string text = "ĐK:" + ((int)objProductsInfo.ICProductDiameter).ToString() + "(mm)";
                    item.Add(text);
                }

                if (objProductsInfo.ICProductRadius > 0)
                {
                    string text = "BK:" + ((int)objProductsInfo.ICProductRadius).ToString() + "(mm)";
                    item.Add(text);
                }

                if (objProductsInfo.ICProductDepth > 0)
                {
                    string text = "Sâu:" + ((int)objProductsInfo.ICProductDepth).ToString() + "(mm)";
                    item.Add(text);
                }
                if (objProductsInfo.ICProductThickness > 0)
                {
                    string text = "Dày:" + ((int)objProductsInfo.ICProductThickness).ToString() + "(mm)";
                    item.Add(text);
                }

                objProductsInfo.ICProductDesc = string.Join(", ", item.ToArray());
            }

            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }
        public void ShowCategoryTree()
        {
            if (IsEditable())
            {
                ActionEdit();
            }

            HardwareProductEntities entity = (HardwareProductEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
            ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
            ICDepartmentsInfo objICDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByNo(BOSApp.GetDisplayTextFromConfigText(ConfigValueGroup.DepartmentGroup, DepartmentGroup.HardwareNo.ToString()));
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
                    objProductsInfo.FK_ICProductTypeAccountConfigID = objProductGroupsInfo.FK_ICProductTypeAccountConfigID;
                }
                else
                {
                    objProductsInfo.FK_ICProductGroupID = 0;
                    objProductsInfo.ICProductGroupName = string.Empty;
                }
                ChangeProductTypeAccountConfig(objProductsInfo.FK_ICProductTypeAccountConfigID);
                entity.UpdateMainObjectBindingSource();
            }
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
        public void ShowProductBranchPrice()
        {
            guiShowProductBranchPrice showProductBranchPrice = new guiShowProductBranchPrice();
            showProductBranchPrice.Module = this;
            if (showProductBranchPrice.ShowDialog() == DialogResult.OK)
            {
                BackupProductBranchPrices();
            }
            else
            {
                RollbackProductBranchPrices();
            }
        }
        private void RollbackProductBranchPrices()
        {
            HardwareProductEntities entity = (HardwareProductEntities)CurrentModuleEntity;
            entity.ProductBranchPriceList.Clear();
            entity.ProductBranchPriceList.Invalidate(entity.ProductBranchPriceList.BackupList);
        }
        private void BackupProductBranchPrices()
        {
            HardwareProductEntities entity = (HardwareProductEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
            if (ProductBranchPriceTable != null)
            {
                foreach (DataRow dr in ProductBranchPriceTable.Rows)
                {
                    int branchID = Convert.ToInt32(dr["FK_BRBranchID"]);
                    foreach (DataColumn column in ProductBranchPriceTable.Columns)
                    {
                        if (column.ColumnName != "FK_BRBranchID" && column.ColumnName != "BRBranchName" && column.ColumnName != "ICDefaultProductBranchPrice")
                        {
                            int currencyID = Convert.ToInt32(column.ColumnName.Split('_')[0]);
                            decimal price = 0;
                            if (dr[column.ColumnName] != DBNull.Value)
                            {
                                price = Convert.ToDecimal(dr[column.ColumnName]);
                            }

                            ICProductBranchPricesInfo objProductBranchPricesInfo = entity.ProductBranchPriceList.Where(
                                                                                                        p => p.FK_BRBranchID == branchID &&
                                                                                                        p.FK_GECurrencyID == currencyID &&
                                                                                                        p.ICProductBranchPriceType == ProductBranchPriceType.Sale.ToString())
                                                                                                        .FirstOrDefault();
                            if (objProductBranchPricesInfo == null)
                            {
                                // Add new product branch price to list
                                ICProductBranchPricesInfo objNewProductBranchPricesInfo = new ICProductBranchPricesInfo();
                                objNewProductBranchPricesInfo.FK_BRBranchID = branchID;
                                objNewProductBranchPricesInfo.FK_GECurrencyID = currencyID;
                                objNewProductBranchPricesInfo.FK_ICProductID = objProductsInfo.ICProductID;
                                objNewProductBranchPricesInfo.ICProductBranchPrice = price;
                                objNewProductBranchPricesInfo.ICProductBranchPriceType = ProductBranchPriceType.Sale.ToString();
                                entity.ProductBranchPriceList.Add(objNewProductBranchPricesInfo);
                            }
                            else
                            {
                                // Update the existing product branch price
                                objProductBranchPricesInfo.ICProductBranchPrice = price;
                            }
                        }
                    }
                }
            }

            entity.ProductBranchPriceList.BackupList.Clear();
            foreach (ICProductBranchPricesInfo objProductBranchPricesInfo in entity.ProductBranchPriceList)
            {
                entity.ProductBranchPriceList.BackupList.Add((ICProductBranchPricesInfo)objProductBranchPricesInfo.Clone());
            }

        }
        public void EditPurchasePriceByCurrency()
        {
            guiEditPurchasePriceByCurrency editPurchasePriceByCurrency = new guiEditPurchasePriceByCurrency();
            editPurchasePriceByCurrency.Module = this;
            if (editPurchasePriceByCurrency.ShowDialog() == DialogResult.OK)
            {
                BackupPurchasePrices();
            }
            else
            {
                RollbackPurchasePrices();
            }
        }
        private void RollbackPurchasePrices()
        {
            HardwareProductEntities entity = (HardwareProductEntities)CurrentModuleEntity;
            entity.ProductPurchasePriceList.Clear();
            entity.ProductPurchasePriceList.Invalidate(entity.ProductPurchasePriceList.BackupList);
        }
        public void BackupPurchasePrices()
        {
            HardwareProductEntities entity = (HardwareProductEntities)CurrentModuleEntity;
            entity.ProductPurchasePriceList.BackupList.Clear();
            foreach (ICProductBranchPricesInfo objProductBranchPricesInfo in entity.ProductPurchasePriceList)
            {
                entity.ProductPurchasePriceList.BackupList.Add((ICProductBranchPricesInfo)objProductBranchPricesInfo.Clone());
            }
        }
        public void ShowPriceLevelForm()
        {
            HardwareProductEntities entity = (HardwareProductEntities)CurrentModuleEntity;
            guiEditPrice guiEditPrice = new guiEditPrice(((ICProductsInfo)entity.MainObject).ICProductID, entity.ICProductPricesList);
            //guiEditPrice 
            //guiEditPrice.ShowDialog();
            guiEditPrice.ShowDialog();
        }
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo searchObject = (ICProductsInfo)CurrentModuleEntity.SearchObject;
            searchObject.ICProductType = ProductType.Hardware.ToString();

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
        public void InvalidateProductBranchPriceWithCurrency(BOSGridControl productBranchPricesGridControl)
        {
            HardwareProductEntities entity = (HardwareProductEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            DataSet ds = objCurrenciesController.GetAllObjects();
            DataTable tableResult = new DataTable();
            tableResult.Columns.Add("FK_BRBranchID", typeof(int));
            tableResult.Columns.Add("BRBranchName", typeof(string));
            SortedList<int, string> columnList = new SortedList<int, string>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                GECurrenciesInfo objCurrenciesInfo = (GECurrenciesInfo)objCurrenciesController.GetObjectFromDataRow(dr);
                columnList.Add(objCurrenciesInfo.GECurrencyID, objCurrenciesInfo.GECurrencyName);
                tableResult.Columns.Add(objCurrenciesInfo.GECurrencyID + "_" + objCurrenciesInfo.GECurrencyName, typeof(decimal));
            }
            BRBranchsController objBranchsController = new BRBranchsController();
            DataSet dsBranch = objBranchsController.GetAllObjects();
            foreach (DataRow dr in dsBranch.Tables[0].Rows)
            {
                DataRow rowResult = tableResult.NewRow();
                BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectFromDataRow(dr);
                rowResult["FK_BRBranchID"] = objBranchsInfo.BRBranchID;
                rowResult["BRBranchName"] = objBranchsInfo.BRBranchName;
                //Get product branch price list by branch id 
                List<ICProductBranchPricesInfo> productBranchPriceList = entity.ProductBranchPriceList
                    .Where(p => p.FK_BRBranchID == objBranchsInfo.BRBranchID && p.ICProductBranchPriceType == ProductBranchPriceType.Sale.ToString()).ToList();

                //Get product branch price by currency id                
                for (int i = 0; i < columnList.Count; i++)
                {
                    int currencyID = columnList.Keys[i];
                    ICProductBranchPricesInfo objProductBranchPricesInfo = productBranchPriceList.Where(p => p.FK_GECurrencyID == columnList.Keys[i]).FirstOrDefault();
                    string columnName = string.Format("{0}_{1}", columnList.Keys[i], columnList.Values[i]);
                    if (objProductBranchPricesInfo != null)
                    {
                        rowResult[columnName] = objProductBranchPricesInfo.ICProductBranchPrice;
                    }
                    else
                    {
                        if (currencyID == BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID)
                        {
                            rowResult[columnName] = objProductsInfo.ICProductPrice01;
                        }
                        else
                        {
                            rowResult[columnName] = 0;
                        }
                    }
                }
                tableResult.Rows.Add(rowResult);
            }
            productBranchPricesGridControl.DataSource = tableResult;
            GridView gridView = (GridView)productBranchPricesGridControl.MainView;
            gridView.BestFitColumns();
            gridView.Columns.Remove(gridView.Columns["FK_BRBranchID"]);
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "BRBranchName")
                {
                    column.Caption = "Chi Nhánh";
                    column.OptionsColumn.AllowEdit = false;
                }
                else
                {
                    column.Tag = column.FieldName.Split('_')[0];
                    column.Caption = column.FieldName.Split('_')[1];
                    RepositoryItemTextEdit rep = new RepositoryItemTextEdit();
                    rep.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    rep.Mask.EditMask = String.Format("n2");
                    rep.Mask.UseMaskAsDisplayFormat = true;
                    column.ColumnEdit = rep;
                }
            }
            productBranchPricesGridControl.RefreshDataSource();
            ProductBranchPriceTable = tableResult;
        }
        public void ChangeProductBranchPrice(BOSGridControl gridControl, int index, string columnName)
        {
            DataTable table = (DataTable)gridControl.DataSource;
            BRBranchsController objBranchsController = new BRBranchsController();
            List<BRBranchsInfo> branches = objBranchsController.GetAllBranches();
            int branchID = Convert.ToInt32(table.Rows[index]["FK_BRBranchID"]);
            BRBranchsInfo changedBranch = branches.Where(b => b.BRBranchID == branchID).FirstOrDefault();
            if (changedBranch != null)
            {
                int count = 0;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (i != index)
                    {
                        branchID = Convert.ToInt32(table.Rows[i]["FK_BRBranchID"]);
                        BRBranchsInfo branch = branches.Where(b => b.BRBranchID == branchID).FirstOrDefault();
                        if (branch != null && branch.FK_GELocationID == changedBranch.FK_GELocationID)
                        {
                            count++;
                        }
                    }
                }

                if (count > 0)
                {
                    if (MessageBox.Show(
                                HardwareProductLocalizedResources.ChangeSameLocationPriceMessage,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            if (i != index)
                            {
                                branchID = Convert.ToInt32(table.Rows[i]["FK_BRBranchID"]);
                                BRBranchsInfo branch = branches.Where(b => b.BRBranchID == branchID).FirstOrDefault();
                                if (branch != null && branch.FK_GELocationID == changedBranch.FK_GELocationID)
                                {
                                    table.Rows[i][columnName] = table.Rows[index][columnName];
                                }
                            }
                        }
                    }
                }
            }
            gridControl.RefreshDataSource();
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

        public override int ActionSave()
        {
            ICProductsInfo objProductsInfo = (ICProductsInfo)CurrentModuleEntity.MainObject;
            HardwareProductEntities entity = (HardwareProductEntities)CurrentModuleEntity;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> ProductList = new List<ICProductsInfo>();
            if (string.IsNullOrEmpty(objProductsInfo.ICProductGroupName))
            {
                MessageBox.Show("Vui lòng chọn nhóm hàng!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            ProductList = objProductsController.GetProductFromProductNameAndDesc(objProductsInfo.ICProductName.Trim(), objProductsInfo.ICProductDesc.Trim(),
                                                                                    objProductsInfo.FK_ICProductGroupID, objProductsInfo.ICProductSizeAndSpecifiCations.Trim(),
                                                                                    objProductsInfo.ICProductAttribute.Trim());
            bool isInvalid = false;
            if (ProductList.Count != 0)
            {
                ICProductsInfo foundItem = ProductList.Where(item => item.ICProductID == objProductsInfo.ICProductID).FirstOrDefault();
                if (foundItem == null)
                    isInvalid = true;
            }
            else
            {
                isInvalid = false;
            }

            if (isInvalid)
            {
                MessageBox.Show(ProductLocalizedResources.SaveFaileMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                if (objProductsInfo.ICProductID == 0 && objProductsInfo.ICProductNo != "***NEW***")
                {
                    string[] arrListStr = objProductsInfo.ICProductNo.Split('.');
                    if (arrListStr.Length > 1)
                    {
                        objProductsInfo.ICProductNo = arrListStr[0];
                    }
                    ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
                    ICDepartmentsInfo objDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByID(objProductsInfo.FK_ICDepartmentID);
                    ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
                    ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(objProductsInfo.FK_ICProductGroupID);
                    GENumberingController objNumberingController = new GENumberingController();
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(objProductsInfo.FK_ICProductAttributeColorID);
                    GENumberingInfo objNumberingInfo;
                    objNumberingInfo = objNumberingController.GetGENumberingByNameAndBranchID(entity.Module.Name, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                    if (objProductAttributesInfo != null)
                    {
                        if (!string.IsNullOrEmpty(objProductAttributesInfo.ICProductAttributeAbbreviation))
                        {
                            if (objDepartmentsInfo != null && objProductGroupsInfo != null && objNumberingInfo != null && objProductsInfo.ICProductNo.Length > objNumberingInfo.GENumberingLength)
                            {
                                //string[] arrListStr = objProductsInfo.ICProductNo.Split('.');
                                objProductGroupsInfo.ICProductGroupNo = objProductGroupsInfo.ICProductGroupNo.Substring(0, 2);
                                //objProductsInfo.ICProductNo = arrListStr[0];
                                objProductsInfo.ICProductNo = objDepartmentsInfo.ICDepartmentNo + objProductGroupsInfo.ICProductGroupNo
                                                              + objProductsInfo.ICProductNo.Substring(objProductsInfo.ICProductNo.Length - objNumberingInfo.GENumberingLength)
                                                              + "." + objProductAttributesInfo.ICProductAttributeAbbreviation;
                                objProductsInfo.ICProductGroupNo = objProductGroupsInfo.ICProductGroupNo;
                            }
                        }
                        else
                        {
                            if (objDepartmentsInfo != null && objProductGroupsInfo != null && objNumberingInfo != null && objProductsInfo.ICProductNo.Length > objNumberingInfo.GENumberingLength)
                            {
                                //string[] arrListStr = objProductsInfo.ICProductNo.Split('.');
                                //if (arrListStr.Length > 1)
                                //{
                                //    objProductsInfo.ICProductNo = arrListStr[0];
                                //}
                                objProductGroupsInfo.ICProductGroupNo = objProductGroupsInfo.ICProductGroupNo.Substring(0, 2);
                                objProductsInfo.ICProductNo = objDepartmentsInfo.ICDepartmentNo + objProductGroupsInfo.ICProductGroupNo + objProductsInfo.ICProductNo.Substring(objProductsInfo.ICProductNo.Length - objNumberingInfo.GENumberingLength);
                                objProductsInfo.ICProductGroupNo = objProductGroupsInfo.ICProductGroupNo;

                            }
                        }
                    }
                }
            }
            bool isExistNoOfOldSys = BOSApp.CurrentProductList.Where(o => o.ICProductNoOfOldSys == objProductsInfo.ICProductNoOfOldSys && o.ICProductID != objProductsInfo.ICProductID && !String.IsNullOrEmpty(objProductsInfo.ICProductNoOfOldSys)).Count() > 0;
            if (isExistNoOfOldSys)
            {
                MessageBox.Show("Mã hệ thống cũ đã tồn tại trong hệ thống! Vui lòng kiểm tra lại", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            isInvalid = BOSApp.CurrentProductList.Where(o => o.ICProductDesc == objProductsInfo.ICProductDesc && o.ICProductID != objProductsInfo.ICProductID).Count() > 0;
            if (isInvalid)
            {
                MessageBox.Show(ProductLocalizedResources.SaveDESCFailedMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            int result = base.ActionSave();
            if (!BOSApp.CurrentProductList.Any(o => o.ICProductID == objProductsInfo.ICProductID))
            {
                ICProductsForViewInfo newObj = new ICProductsForViewInfo();
                BOSUtil.CopyViewObject(objProductsInfo, newObj);
                BOSApp.CurrentProductList.Add(newObj);
            }
            if (result > 0)
            {
                BOSProgressBar.Start("Đang lưu hình ảnh sản phẩm");
                entity.UpdateImages();
                BOSProgressBar.Close();
            }
            return result;
        }

        public void ChangeProductTypeAccountConfig(int customerTypeAccountConfigID)
        {
            HardwareProductEntities entity = (HardwareProductEntities)CurrentModuleEntity;
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

        public override void ActionDuplicate()
        {
            base.ActionDuplicate();

            ICProductsInfo product = (ICProductsInfo)CurrentModuleEntity.MainObject;
            product.ICProductPrice01 = 0;
            product.ICProductBarCode = string.Empty;
            product.ICProductIsFollowInventoryStock = true;
        }

        public void AddImageToProductFilesList(String path, bool isDefault)
        {
            HardwareProductEntities entity = (HardwareProductEntities)CurrentModuleEntity;
            if (String.IsNullOrEmpty(path))
                return;
            if (Toolbar.IsNullOrNoneAction())
                base.ActionEdit();
            entity.ProductFilesList.Add(new ICProductFilesInfo()
            {
                IsDefault = isDefault,
                ICProductFilePath = path,
                ICProductFileImage = Image.FromFile(path)
            });
            entity.ProductFilesList.GridControl.RefreshDataSource();
        }

        public void DeleteItemFromICProductComponentsList()
        {
            HardwareProductEntities entity = (HardwareProductEntities)CurrentModuleEntity;
            entity.ICProductComponentsList.RemoveSelectedRowObjectFromList();
        }

        private string ToString(decimal number)
        {
            if (number == 0)
                return "0";
            return number / Convert.ToInt32(number) != 1 ? number.ToString("N3") : number.ToString("N0");
        }

        public void AddProductComponentToProductComponentList()
        {
            HardwareProductEntities entity = (HardwareProductEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)CurrentModuleEntity.MainObject;
            //List<ICProductsInfo> productList = BOSApp.CurrentProductList.Where(p => productTypes.Contains(p.ICProductType)).ToList();
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> productList = objProductsController.GetListProductByProductType(ProductType.Hardware.ToString());
            guiAddProductComponent<ICProductsInfo> guiAddProductComponent = new guiAddProductComponent<ICProductsInfo>(productList, 0);
            guiAddProductComponent.Module = this;
            guiAddProductComponent.ShowDialog();
            if (guiAddProductComponent.DialogResult != DialogResult.OK)
                return;

            IList<ICProductsInfo> results = guiAddProductComponent.SelectedObjects;
            if (results.Count == 0)
                return;

            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
                base.ActionEdit();

            ICProductComponentsInfo objProductComponentsInfo;
            foreach (ICProductsInfo item in results)
            {
                objProductComponentsInfo = new ICProductComponentsInfo();
                objProductComponentsInfo.FK_ICProductComponentChildID = item.ICProductID;
                objProductComponentsInfo.ICProductComponentQty = 1;
                objProductComponentsInfo.ICProductName = item.ICProductName;
                objProductComponentsInfo.ICProductDesc = item.ICProductDesc;
                entity.ICProductComponentsList.Add(objProductComponentsInfo);
            }
            entity.ICProductComponentsList.GridControl.RefreshDataSource();
        }

        public void PrintHardwareSingle()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                RPProductSingle report = (RPProductSingle)InitProductSingleReport("RPProductSingle");
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevInvoiceItemReportPath, true);
                reviewer.Show();
            }
        }

        public void PrintHardwareSingleA6()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                RPProductSingleA6 report = (RPProductSingleA6)InitProductSingleReport("PrintProductSingleA6");
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevInvoiceItemReportPath, true);
                reviewer.Show();
            }
        }

        public BaseReport InitProductSingleReport(string reportType)
        {
            HardwareProductEntities entity = (HardwareProductEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
            ApiClientHelper.GetProductPrimaryImage(objProductsInfo);
            System.ComponentModel.ComponentResourceManager resourceImgDefault = new System.ComponentModel.ComponentResourceManager(typeof(RPProductSingle));
            Image imgDefault = ((System.Drawing.Image)(resourceImgDefault.GetObject("xrPictureBox4.Image")));

            if (objProductsInfo.ICProductPrimaryImage == null)
                objProductsInfo.ICProductPrimaryImage = imgDefault;

            ICDepartmentAttributeValuesController objDepartmentAttributeValuesController = new ICDepartmentAttributeValuesController();
            List<ICDepartmentAttributeValuesInfo> departmentAttributeValuesList = new List<ICDepartmentAttributeValuesInfo>();
            if (!string.IsNullOrEmpty(objProductsInfo.ICProductAttributeKey))
            {
                departmentAttributeValuesList = objDepartmentAttributeValuesController.GetDepartmentAttributeByDepartmentAttributeReference(objProductsInfo.ICProductAttributeKey);
                if (departmentAttributeValuesList != null)
                {
                    objProductsInfo.ICProductAttributeMaterialText = string.Join("+", departmentAttributeValuesList.Where(o2 => o2.FK_ICDepartmentID == objProductsInfo.FK_ICDepartmentID
                                                                                                                        && o2.ICDepartmentAttributeLevel == DepartmentAttributeColorLevel.Material)
                                                                                                                .Select(o2 => o2.ICDepartmentAttributeValueValue).ToArray());
                    objProductsInfo.ICProductAttributeColorText = string.Join("+", departmentAttributeValuesList.Where(o2 => o2.FK_ICDepartmentID == objProductsInfo.FK_ICDepartmentID
                                                                                                                        && o2.ICDepartmentAttributeLevel == DepartmentAttributeColorLevel.Color)
                                                                                                                   .Select(o2 => o2.ICDepartmentAttributeValueValue).ToArray());
                }
            }


            List<string> productSizeList = new List<string>();
            if (objProductsInfo.ICProductLength > 0 || objProductsInfo.ICProductWidth > 0 || objProductsInfo.ICProductHeight > 0)
            {
                if (objProductsInfo.ICProductLength != 0)
                    productSizeList.Add(ToString(objProductsInfo.ICProductLength));
                if (objProductsInfo.ICProductWidth != 0)
                    productSizeList.Add(ToString(objProductsInfo.ICProductWidth));
                if (objProductsInfo.ICProductHeight != 0)
                    productSizeList.Add(ToString(objProductsInfo.ICProductHeight));
                objProductsInfo.ICProductSizeText = string.Join("*", productSizeList.ToArray());
            }
            if (reportType == "PrintProductSingleA6")
            {
                RPProductSingleA6 report = new RPProductSingleA6();
                XRPictureBox productBarcode = (XRPictureBox)report.Bands[BandKind.ReportFooter].Controls["pnlProductView"].Controls["xrPictureProductBarcode"];
                if (productBarcode != null)
                {
                    productBarcode.Image = (System.Drawing.Image)EncodingQR((int)productBarcode.WidthF, (int)productBarcode.HeightF, string.IsNullOrEmpty(objProductsInfo.ICProductBarCode) ? objProductsInfo.ICProductNo : objProductsInfo.ICProductBarCode);
                }
                report.bsProducts.DataSource = objProductsInfo;
                return report;
            }
            else
            {
                RPProductSingle report = new RPProductSingle();
                XRPictureBox productBarcode = (XRPictureBox)report.Bands[BandKind.ReportHeader].Controls["pnlProductView"].Controls["xrPictureProductBarcode"];
                if (productBarcode != null)
                {
                    productBarcode.Image = (System.Drawing.Image)EncodingQR((int)productBarcode.WidthF, (int)productBarcode.HeightF, string.IsNullOrEmpty(objProductsInfo.ICProductBarCode) ? objProductsInfo.ICProductNo : objProductsInfo.ICProductBarCode);
                }
                report.bsProducts.DataSource = objProductsInfo;
                return report;
            }

        }

        public void PrintHardwareComboA6()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                HardwareProductEntities entity = (HardwareProductEntities)CurrentModuleEntity;
                ICProductsInfo mainObject = (ICProductsInfo)entity.MainObject;
                ICProductComponentsController objProductComponentsController = new ICProductComponentsController();
                List<ICProductComponentsInfo> productComponentsList = objProductComponentsController.GetProductComponentListByProductID(mainObject.ICProductID);
                if (productComponentsList == null)
                    productComponentsList = new List<ICProductComponentsInfo>();
                productComponentsList.ForEach(o =>
                {
                    o.ICProductBarcodeImage = (System.Drawing.Image)EncodingQR(38, 38, o.ICProductBarcode);
                });
                RPProductComboPage1 report = new RPProductComboPage1(productComponentsList);
                InitProductComboReport(report);
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevInvoiceItemReportPath, true);
                reviewer.Show();
            }
        }

        public void InitProductComboReport(RPProductComboPage1 report)
        {
            HardwareProductEntities entity = (HardwareProductEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
            ApiClientHelper.GetProductPrimaryImage(objProductsInfo);
            System.ComponentModel.ComponentResourceManager resourceImgDefault = new System.ComponentModel.ComponentResourceManager(typeof(RPProductCombo));
            Image imgDefault = ((System.Drawing.Image)(resourceImgDefault.GetObject("xrPictureBox4.Image")));
            if (objProductsInfo.ICProductPrimaryImage == null)
                objProductsInfo.ICProductPrimaryImage = imgDefault;

            ICDepartmentAttributeValuesController objDepartmentAttributeValuesController = new ICDepartmentAttributeValuesController();
            List<ICDepartmentAttributeValuesInfo> departmentAttributeValuesList = new List<ICDepartmentAttributeValuesInfo>();
            if (!string.IsNullOrEmpty(objProductsInfo.ICProductAttributeKey))
            {
                departmentAttributeValuesList = objDepartmentAttributeValuesController.GetDepartmentAttributeByDepartmentAttributeReference(objProductsInfo.ICProductAttributeKey);
                if (departmentAttributeValuesList != null)
                {
                    objProductsInfo.ICProductAttributeMaterialText = string.Join("+", departmentAttributeValuesList.Where(o2 => o2.FK_ICDepartmentID == objProductsInfo.FK_ICDepartmentID
                                                                                                                        && o2.ICDepartmentAttributeLevel == DepartmentAttributeColorLevel.Material)
                                                                                                                .Select(o2 => o2.ICDepartmentAttributeValueValue).ToArray());
                    objProductsInfo.ICProductAttributeColorText = string.Join("+", departmentAttributeValuesList.Where(o2 => o2.FK_ICDepartmentID == objProductsInfo.FK_ICDepartmentID
                                                                                                                        && o2.ICDepartmentAttributeLevel == DepartmentAttributeColorLevel.Color)
                                                                                                                   .Select(o2 => o2.ICDepartmentAttributeValueValue).ToArray());
                }
            }

            List<string> productSizeList = new List<string>();
            if (objProductsInfo.ICProductLength > 0 || objProductsInfo.ICProductWidth > 0 || objProductsInfo.ICProductHeight > 0)
            {
                if (objProductsInfo.ICProductLength != 0)
                    productSizeList.Add(ToString(objProductsInfo.ICProductLength));
                if (objProductsInfo.ICProductWidth != 0)
                    productSizeList.Add(ToString(objProductsInfo.ICProductWidth));
                if (objProductsInfo.ICProductHeight != 0)
                    productSizeList.Add(ToString(objProductsInfo.ICProductHeight));
                objProductsInfo.ICProductSizeText = string.Join("*", productSizeList.ToArray());
            }
            report.bsProducts.DataSource = objProductsInfo;
        }

        public Bitmap EncodingQR(int width, int height, string inputStringToBarcode)
        {
            BarcodeWriter bw = new BarcodeWriter();
            bw.Format = ZXing.BarcodeFormat.QR_CODE;
            EncodingOptions encOptions = new EncodingOptions() { Width = width, Height = height, Margin = 0 };
            bw.Options = encOptions;
            if (string.IsNullOrEmpty(inputStringToBarcode))
                inputStringToBarcode = " ";
            Bitmap result = new Bitmap(bw.Write(inputStringToBarcode));
            return result;
        }

        public void SaveProductMeasureUnitList()
        {
            HardwareProductEntities entity = (HardwareProductEntities)CurrentModuleEntity;
            ICProductsInfo product = (ICProductsInfo)entity.MainObject;
            if (product.ICProductID > 0)
            {
                if (entity.ProductMeasureUnitList != null)
                {
                    entity.ProductMeasureUnitList.SaveItemObjects();
                }
                MessageBox.Show("Lưu thành công", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void RemoveProductMeasureUnitList()
        {
            HardwareProductEntities entity = (HardwareProductEntities)CurrentModuleEntity;
            entity.ProductMeasureUnitList.RemoveSelectedRowObjectFromList();
        }
        public string FilterProduct(string getFilterProduct)
        {
            string result = string.Empty;
            List<ICProductsForViewInfo> ProductList = new List<ICProductsForViewInfo>();
            ProductList = BOSApp.CurrentProductList.Where(x => (x.ICProductName.ToLower().Contains(
                                                                getFilterProduct.Trim()) ||
                                                                x.ICProductDesc.ToLower().Contains(getFilterProduct.Trim()))
                                                                && x.ICProductType == ProductType.Hardware.ToString()).ToList();


            ProductList.ForEach(o => result += Environment.NewLine + o.ICProductName);

            return result;
        }
        public void AddProductImage()
        {
            HardwareProductEntities entity = (HardwareProductEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
            guiAddProductImage guiImage = new guiAddProductImage();
            guiImage.Module = this;
            guiImage.ShowDialog();
            if (guiImage.DialogResult == DialogResult.OK)
            {
                objProductsInfo.ICProductImageFile = guiImage.ProductImageFile;
                ProductImageFile.Text = guiImage.ProductImageFile;
            }
            InitProductPictureImage(objProductsInfo.ICProductImageFile);
        }

        public void InitProductPictureImage(string image)
        {
            if (string.IsNullOrEmpty(image))
                return;
            image = image.Replace("/view?usp=sharing", "").Replace("https://drive.google.com/file/d/", "https://drive.google.com/uc?id=");
            try
            {
                WebClient webclient = new WebClient();
                byte[] bytes = webclient.DownloadData(image);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                ProductPicturePictureBox.Image = img;
                ProductPicturePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {
                BOSApp.ShowMessage("Link ảnh hoặc định dạng hình ảnh không hợp lệ!");
                ProductPicturePictureBox.Image = null;
            }
        }
    }
}
