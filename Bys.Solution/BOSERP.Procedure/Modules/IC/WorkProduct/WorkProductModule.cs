using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BOSERP.Modules.WorkProduct
{
    public class WorkProductModule : BaseModuleERP
    {
        public const string ModuleName = "WorkProduct";

        public const string ProductGroupsButtonEditName = "fld_bedFK_ICProductGroupID";

        public const string ProductWorkItemViewTabEditName = "fld_tabProductWorkItem";

        public const string MaterialTabName = "fld_tabMaterial";

        public const string AssetTabName = "fld_tabAsset";

        public const string ProductWorkMaterialItemsGridControlName = "fld_dgcICProductWorkMaterialItems";

        public const string ProductWorkAssetItemsGridControlName = "fld_dgcICProductWorkAssetItems";

        public const string ProductTasksGridControlName = "fld_dgcICProductTasks";

        public const string ProductTypeLookUpEditNameMain = "fld_lkeICProductType";
        public const string ProductTypeLookUpEditNameSearch = "fld_lkeICProductType1";

        public bool isEditProductType { get; set; }

        private BOSButtonEdit ProductGroupsButtonEdit;

        private DataTable ProductBranchPriceTable;

        private BOSTabControl ProductWorkItemViewTab;

        private ICProductWorkMaterialItemsGridControl ProductWorkMaterialItemsGridControl;

        private ICProductWorkAssetItemsGridControl ProductWorkAssetItemsGridControl;

        private ICProductTasksGridControl ProductTasksGridControl;

        private BOSLookupEdit ProductTypeLookUpEditMain;

        private BOSLookupEdit ProductTypeLookUpEditSearch;

        public WorkProductModule()
        {
            Name = ModuleName;
            CurrentModuleEntity = new WorkProductEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            ProductGroupsButtonEdit = (BOSButtonEdit)Controls[WorkProductModule.ProductGroupsButtonEditName];
            ProductWorkItemViewTab = (BOSTabControl)Controls[ProductWorkItemViewTabEditName];
            ProductWorkMaterialItemsGridControl = (ICProductWorkMaterialItemsGridControl)Controls[ProductWorkMaterialItemsGridControlName];
            ProductWorkAssetItemsGridControl = (ICProductWorkAssetItemsGridControl)Controls[ProductWorkAssetItemsGridControlName];
            ProductTasksGridControl = (ICProductTasksGridControl)Controls[ProductTasksGridControlName];
            ProductTypeLookUpEditMain = (BOSLookupEdit)Controls[WorkProductModule.ProductTypeLookUpEditNameMain];
            ProductTypeLookUpEditSearch = (BOSLookupEdit)Controls[WorkProductModule.ProductTypeLookUpEditNameSearch];
            ProductTypeLookUpEditBindingSource();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            ICProductsInfo objProductsInfo = (ICProductsInfo)CurrentModuleEntity.MainObject;
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            objProductsInfo.ICProductGroupName = objProductGroupsController.GetObjectNameByID(objProductsInfo.FK_ICProductGroupID);
            ProductGroupsButtonEdit.Text = objProductsInfo.ICProductGroupName;
        }

        public override void ActionNew()
        {
            base.ActionNew();

            ICProductsInfo objProductsInfo = (ICProductsInfo)((WorkProductEntities)CurrentModuleEntity).MainObject;
            objProductsInfo.ICProductStockMinDateFrom = DateTime.Now;
            objProductsInfo.ICProductStockMinDateTo = BOSUtil.GetYearEndDate();
            objProductsInfo.ICProductStockMaxDateFrom = DateTime.Now;
            objProductsInfo.ICProductStockMaxDateTo = BOSUtil.GetYearEndDate();
            objProductsInfo.ICProductLockedPurchaseOrder = false;
            isEditProductType = false;
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
            WorkProductEntities entity = (WorkProductEntities)CurrentModuleEntity;
            entity.ICProductSuppliersList.BackupList.Clear();
            foreach (ICProductSuppliersInfo objProductSuppliersInfo in entity.ICProductSuppliersList)
            {
                entity.ICProductSuppliersList.BackupList.Add((ICProductSuppliersInfo)objProductSuppliersInfo.Clone());
            }
        }

        private void RollbackProductSuppliers()
        {
            WorkProductEntities entity = (WorkProductEntities)CurrentModuleEntity;
            entity.ICProductSuppliersList.Clear();
            entity.ICProductSuppliersList.Invalidate(entity.ICProductSuppliersList.BackupList);
        }

        public void SetDefaultProductDesc()
        {
            ICProductsInfo objProductsInfo = (ICProductsInfo)CurrentModuleEntity.MainObject;
            objProductsInfo.ICProductDesc = objProductsInfo.ICProductName;
            //if (objProductsInfo.ICProductType == ProductType.Work.ToString())
            //{
            //    //ProductGroup
            //    ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            //    ICProductGroupsInfo objProductGroupsInfo = new ICProductGroupsInfo();
            //    ICProductGroupsInfo objProductGroupParentsInfo = new ICProductGroupsInfo();
            //    objProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(objProductsInfo.FK_ICProductGroupID);
            //    //objProductsInfo.ICProductDesc += string.Format(string.IsNullOrEmpty(objProductsInfo.ICProductDesc) ? "{0}" : " {0}", objProductsInfo.ICProductName + ",");
            //    if (objProductGroupsInfo != null)
            //    {
            //        if (objProductGroupsInfo.ICProductGroupParentID > 0)
            //            objProductGroupParentsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(objProductGroupsInfo.ICProductGroupParentID);

            //        if (objProductGroupParentsInfo != null)
            //            objProductsInfo.ICProductDesc += string.Format(string.IsNullOrEmpty(objProductsInfo.ICProductDesc) ? "{0}" : " {0}",
            //                  objProductGroupParentsInfo.ICProductGroupName + " " + objProductGroupsInfo.ICProductGroupName + "");
            //        else
            //            objProductsInfo.ICProductDesc += string.Format(string.IsNullOrEmpty(objProductsInfo.ICProductDesc) ? "{0}" : " {0}",
            //                 objProductGroupsInfo.ICProductGroupName + "");
            //    }
            //    if (objProductsInfo.ICProductSizeAndSpecifiCations != string.Empty)
            //    {
            //        objProductsInfo.ICProductDesc += string.Format(", {0}", objProductsInfo.ICProductSizeAndSpecifiCations);
            //    }
            //    //Attribute
            //    string[] attributeValueIDs = objProductsInfo.ICProductAttributeKey.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
            //    ICDepartmentAttributeValuesController objDepartmentAttributeValuesController = new ICDepartmentAttributeValuesController();
            //    for (int i = 0; i < attributeValueIDs.Length; i++)
            //    {
            //        int attributeValueID = Convert.ToInt32(attributeValueIDs[i]);
            //        ICDepartmentAttributeValuesInfo objDepartmentAttributeValuesInfo = (ICDepartmentAttributeValuesInfo)objDepartmentAttributeValuesController.GetObjectByID(attributeValueID);
            //        objProductsInfo.ICProductDesc += string.Format(", {0}", objDepartmentAttributeValuesInfo.ICDepartmentAttributeValueValue);
            //    }
            //}

            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        public void ShowCategoryTree()
        {
            if (IsEditable())
            {
                ActionEdit();
            }

            WorkProductEntities entity = (WorkProductEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
            ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
            ICDepartmentsInfo objICDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByNo(BOSApp.GetDisplayTextFromConfigText(ConfigValueGroup.DepartmentGroup, DepartmentGroup.WorkNo.ToString()));
            int departmentID = 1;
            if (objICDepartmentsInfo != null)
                departmentID = objICDepartmentsInfo.ICDepartmentID;
            if (objProductsInfo.FK_ICDepartmentID > 0)
                departmentID = objProductsInfo.FK_ICDepartmentID;
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> configValuesList = new List<ADConfigValuesInfo>();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            objConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue("ProductType", ProductType.Service.ToString());
            if (objConfigValuesInfo != null)
                configValuesList.Add(objConfigValuesInfo);
            objConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue("ProductType", ProductType.Work.ToString());
            if (objConfigValuesInfo != null)
                configValuesList.Add(objConfigValuesInfo);
            configValuesList = configValuesList.Where(o => o.ADConfigKeyValue == ProductType.Service.ToString() || o.ADConfigKeyValue == ProductType.Work.ToString()).ToList();
            string deparmentReference = string.Join(";", configValuesList.Select(o => o.ADConfigText).ToArray());
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(departmentID, objProductsInfo.FK_ICProductGroupID, objProductsInfo.ICProductType, deparmentReference, true);
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
            WorkProductEntities entity = (WorkProductEntities)CurrentModuleEntity;
            entity.ProductBranchPriceList.Clear();
            entity.ProductBranchPriceList.Invalidate(entity.ProductBranchPriceList.BackupList);
        }

        private void BackupProductBranchPrices()
        {
            WorkProductEntities entity = (WorkProductEntities)CurrentModuleEntity;
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
            //guiEditPurchasePriceByCurrency editPurchasePriceByCurrency = new guiEditPurchasePriceByCurrency();
            //editPurchasePriceByCurrency.Module = this;
            //if (editPurchasePriceByCurrency.ShowDialog() == DialogResult.OK)
            //{
            //    BackupPurchasePrices();
            //}
            //else
            //{
            //    RollbackPurchasePrices();
            //}
        }

        private void RollbackPurchasePrices()
        {
            WorkProductEntities entity = (WorkProductEntities)CurrentModuleEntity;
            entity.ProductPurchasePriceList.Clear();
            entity.ProductPurchasePriceList.Invalidate(entity.ProductPurchasePriceList.BackupList);
        }

        public void BackupPurchasePrices()
        {
            WorkProductEntities entity = (WorkProductEntities)CurrentModuleEntity;
            entity.ProductPurchasePriceList.BackupList.Clear();
            foreach (ICProductBranchPricesInfo objProductBranchPricesInfo in entity.ProductPurchasePriceList)
            {
                entity.ProductPurchasePriceList.BackupList.Add((ICProductBranchPricesInfo)objProductBranchPricesInfo.Clone());
            }
        }

        public void ShowPriceLevelForm()
        {
            WorkProductEntities entity = (WorkProductEntities)CurrentModuleEntity;
            guiEditPrice guiEditPrice = new guiEditPrice(((ICProductsInfo)entity.MainObject).ICProductID, entity.ICProductPricesList);
            guiEditPrice.ShowDialog();
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo searchObject = (ICProductsInfo)CurrentModuleEntity.SearchObject;
            DataSet ds = objProductsController.GetWorkProductList(
                                                        searchObject.ICProductNo,
                                                        searchObject.ICProductSupplierNumber,
                                                        searchObject.ICProductType,
                                                        BOSUtil.GetSearchString(searchObject.ICProductDesc),
                                                        searchObject.FK_ICDepartmentID,
                                                        searchObject.FK_ICProductGroupID,
                                                        searchObject.FK_APSupplierID);
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
            WorkProductEntities entity = (WorkProductEntities)CurrentModuleEntity;
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
            WorkProductEntities entity = (WorkProductEntities)CurrentModuleEntity;
            entity.ProductWorkItemMaterialList.EndCurrentEdit();
            entity.ProductWorkItemAssetList.EndCurrentEdit();
            entity.ProductTaskList.EndCurrentEdit();

            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> ProductList = new List<ICProductsInfo>();
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
            int result = base.ActionSave();
            if (!BOSApp.CurrentProductList.Any(o => o.ICProductID == objProductsInfo.ICProductID))
            {
                ICProductsForViewInfo newObj = new ICProductsForViewInfo();
                BOSUtil.CopyViewObject(objProductsInfo, newObj);
                BOSApp.CurrentProductList.Add(newObj);
            }
            return result;
        }

        public void AddWorkItemToProductWorkItemsList()
        {
            List<string> productTypes = new List<string>();
            if (ProductWorkItemViewTab.SelectedTabPage.Name == MaterialTabName)
            {
                productTypes = Enum.GetNames(typeof(ProductType)).Where(s => s != ProductType.Work.ToString()
                                                                                  && s != ProductType.SemiProduct.ToString()
                                                                                  && s != ProductType.Equipment.ToString()
                                                                                  && s != ProductType.VVP.ToString()
                                                                                  && s != ProductType.MMTB.ToString()
                                                                                  && s != ProductType.Car.ToString()).ToList();
            }
            if (ProductWorkItemViewTab.SelectedTabPage.Name == AssetTabName)
            {
                productTypes = Enum.GetNames(typeof(ProductType)).Where(s => s == ProductType.Equipment.ToString()
                                                                                  || s == ProductType.VVP.ToString()
                                                                                  || s == ProductType.MMTB.ToString()
                                                                                  || s == ProductType.Car.ToString()
                                                                                  || s == ProductType.Service.ToString()
                                                                                  ).ToList();
            }

            WorkProductEntities entity = (WorkProductEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)CurrentModuleEntity.MainObject;
            List<ICProductsInfo> productList = new List<ICProductsInfo>();
            List<ICProductsForViewInfo> productViewList = BOSApp.CurrentProductList.Where(p => productTypes.Contains(p.ICProductType)).ToList();
            if (productViewList.Count() > 0) productViewList.ForEach(o =>
            {
                ICProductsInfo newObj = new ICProductsInfo();
                BOSUtil.CopyViewObject(o, newObj);
                productList.Add(newObj);
            });
            guiAddWorkItem<ICProductsInfo> guiAddWorkItem = new guiAddWorkItem<ICProductsInfo>(productList, 0);
            guiAddWorkItem.Module = this;
            guiAddWorkItem.ShowDialog();
            if (guiAddWorkItem.DialogResult != DialogResult.OK)
                return;

            IList<ICProductsInfo> results = guiAddWorkItem.SelectedObjects;
            if (results.Count == 0)
                return;

            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
                base.ActionEdit();

            ICProductWorkItemsInfo objProductWorkItemsInfo;
            foreach (ICProductsInfo item in results)
            {
                objProductWorkItemsInfo = new ICProductWorkItemsInfo();
                objProductWorkItemsInfo.FK_ICProductWorkItemChildID = item.ICProductID;
                objProductWorkItemsInfo.ICProductWorkItemQty = 1;
                objProductWorkItemsInfo.ICProductWorkItemProductNo = item.ICProductNo;
                objProductWorkItemsInfo.ICProductWorkItemProductName = item.ICProductName;
                objProductWorkItemsInfo.ICProductWorkItemProductDesc = item.ICProductDesc;
                objProductWorkItemsInfo.ICProductWorkItemProductChargeCheck = item.ICProductChargeCheck;
                objProductWorkItemsInfo.ICProductWorkItemParentType = objProductsInfo.ICProductType;
                objProductWorkItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                if (ProductWorkItemViewTab.SelectedTabPage.Name == MaterialTabName)
                {
                    objProductWorkItemsInfo.ICProductWorkItemType = ProductWorkItemType.Material.ToString();
                    entity.ProductWorkItemMaterialList.Add(objProductWorkItemsInfo);
                }
                if (ProductWorkItemViewTab.SelectedTabPage.Name == AssetTabName)
                {
                    objProductWorkItemsInfo.ICProductWorkItemType = ProductWorkItemType.Asset.ToString();
                    entity.ProductWorkItemAssetList.Add(objProductWorkItemsInfo);
                }
            }

            entity.ProductWorkItemMaterialList.GridControl.RefreshDataSource();
            entity.ProductWorkItemAssetList.GridControl.RefreshDataSource();
        }

        public void DeleteItemFromProductWorkItemMaterialList()
        {
            WorkProductEntities entity = (WorkProductEntities)CurrentModuleEntity;
            entity.ProductWorkItemMaterialList.RemoveSelectedRowObjectFromList();
        }

        public void DeleteItemFromProductWorkItemAssetList()
        {
            WorkProductEntities entity = (WorkProductEntities)CurrentModuleEntity;
            entity.ProductWorkItemAssetList.RemoveSelectedRowObjectFromList();
        }

        public void AddTaskToProductTaskList()
        {
            WorkProductEntities entity = (WorkProductEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)CurrentModuleEntity.MainObject;

            ICTasksController objTasksController = new ICTasksController();
            List<ICTasksInfo> taskList = objTasksController.GetAllTaskList();
            guiAddTask<ICTasksInfo> guiAddTask = new guiAddTask<ICTasksInfo>(taskList, 0);
            guiAddTask.Module = this;
            guiAddTask.ShowDialog();
            if (guiAddTask.DialogResult != DialogResult.OK)
                return;

            IList<ICTasksInfo> results = guiAddTask.SelectedObjects;
            if (results.Count == 0)
                return;

            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
                base.ActionEdit();

            ICProductTasksInfo objProductTasksInfo;
            foreach (ICTasksInfo item in results)
            {
                objProductTasksInfo = new ICProductTasksInfo();
                objProductTasksInfo.FK_ICTaskID = item.ICTaskID;
                objProductTasksInfo.FK_ICProductID = objProductsInfo.ICProductID;
                objProductTasksInfo.FK_HRDepartmentID = item.FK_HRDepartmentID;
                objProductTasksInfo.FK_HRDepartmentRoomID = item.FK_HRDepartmentRoomID;
                objProductTasksInfo.FK_HREmployeeID = item.FK_HREmployeeID;
                objProductTasksInfo.FK_ICMeasureUnitID = item.FK_ICMeasureUnitID;
                objProductTasksInfo.ICProductTaskNo = item.ICTaskNo;
                objProductTasksInfo.ICProductTaskName = item.ICTaskName;
                objProductTasksInfo.ICProductTaskInfo = item.ICTaskInfo;
                objProductTasksInfo.ICProductTaskQty = item.ICTaskQty;
                objProductTasksInfo.ICProductTaskTotalActualDays = item.ICTaskTotalActualDays;
                objProductTasksInfo.ICProductTaskTotalActualHours = item.ICTaskTotalActualHours;
                objProductTasksInfo.ICProductTaskTotalEstimatedDays = item.ICTaskTotalEstimatedDays;
                objProductTasksInfo.ICProductTaskTotalEstimatedHours = item.ICTaskTotalEstimatedHours;
                objProductTasksInfo.ICProductTaskActualTotalCost = item.ICTaskActualTotalCost;
                objProductTasksInfo.ICProductTaskEstimatedTotalCost = item.ICTaskEstimatedTotalCost;
                objProductTasksInfo.ICProductTaskParentType = objProductsInfo.ICProductType;
                objProductTasksInfo.FK_ICProductParentID = objProductsInfo.ICProductID;
                entity.ProductTaskList.Add(objProductTasksInfo);
            }

            entity.ProductTaskList.GridControl.RefreshDataSource();
        }

        public void DeleteItemFromProductTaskList()
        {
            WorkProductEntities entity = (WorkProductEntities)CurrentModuleEntity;
            entity.ProductTaskList.RemoveSelectedRowObjectFromList();
        }

        public override void ActionCancel()
        {
            WorkProductEntities entity = (WorkProductEntities)CurrentModuleEntity;
            entity.ProductWorkItemMaterialList.EndCurrentEdit();
            entity.ProductWorkItemAssetList.EndCurrentEdit();
            entity.ProductTaskList.EndCurrentEdit();
            base.ActionCancel();
        }

        public void ChangeProductTypeAccountConfig(int customerTypeAccountConfigID)
        {
            WorkProductEntities entity = (WorkProductEntities)CurrentModuleEntity;
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

        public void ProductTypeLookUpEditBindingSource()
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> ConfigValuesList = new List<ADConfigValuesInfo>();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            objConfigValuesInfo.ADConfigValueID = 0;
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.ProductType);
            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                //ConfigValuesList.Add(objConfigValuesInfo);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
                    if (objConfigValuesInfo.ADConfigKeyValue == ProductType.Work.ToString()
                        || objConfigValuesInfo.ADConfigKeyValue == ProductType.Service.ToString())
                        ConfigValuesList.Add(objConfigValuesInfo);
                }
            }
            ProductTypeLookUpEditMain.Properties.Columns.Clear();
            ProductTypeLookUpEditMain.Properties.Columns.Add(new LookUpColumnInfo("ADConfigText", "Loại"));
            ProductTypeLookUpEditSearch.Properties.Columns.Clear();
            ProductTypeLookUpEditSearch.Properties.Columns.Add(new LookUpColumnInfo("ADConfigText", "Loại"));
            if (ConfigValuesList != null)
            {
                ProductTypeLookUpEditMain.BOSDataSource = "";
                ProductTypeLookUpEditMain.BOSDataMember = "";
                ProductTypeLookUpEditMain.Properties.DataSource = ConfigValuesList;
                ProductTypeLookUpEditMain.Properties.DisplayMember = "ADConfigText";
                ProductTypeLookUpEditMain.Properties.ValueMember = "ADConfigKeyValue";

                ProductTypeLookUpEditSearch.BOSDataSource = "";
                ProductTypeLookUpEditSearch.BOSDataMember = "";
                ProductTypeLookUpEditSearch.Properties.DataSource = ConfigValuesList;
                ProductTypeLookUpEditSearch.Properties.DisplayMember = "ADConfigText";
                ProductTypeLookUpEditSearch.Properties.ValueMember = "ADConfigKeyValue";
            }
        }
    }
}
