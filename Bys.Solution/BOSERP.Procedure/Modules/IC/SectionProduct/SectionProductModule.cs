using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
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

namespace BOSERP.Modules.SectionProduct
{
    public class SectionProductModule : BaseModuleERP
    {
        public const string ModuleName = "SectionProduct";

        public const string ProductGroupsButtonEditName = "fld_bedFK_ICProductGroupID";

        public bool isEditProductType { get; set; }

        private BOSButtonEdit ProductGroupsButtonEdit;

        private DataTable ProductBranchPriceTable;

        public SectionProductModule()
        {
            Name = ModuleName;
            CurrentModuleEntity = new SectionProductEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            ProductGroupsButtonEdit = (BOSButtonEdit)Controls[SectionProductModule.ProductGroupsButtonEditName];
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

            ICProductsInfo objProductsInfo = (ICProductsInfo)((SectionProductEntities)CurrentModuleEntity).MainObject;
            objProductsInfo.ICProductStockMinDateFrom = DateTime.Now;
            objProductsInfo.ICProductStockMinDateTo = BOSUtil.GetYearEndDate();
            objProductsInfo.ICProductStockMaxDateFrom = DateTime.Now;
            objProductsInfo.ICProductStockMaxDateTo = BOSUtil.GetYearEndDate();
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
            SectionProductEntities entity = (SectionProductEntities)CurrentModuleEntity;
            entity.ICProductSuppliersList.BackupList.Clear();
            foreach (ICProductSuppliersInfo objProductSuppliersInfo in entity.ICProductSuppliersList)
            {
                entity.ICProductSuppliersList.BackupList.Add((ICProductSuppliersInfo)objProductSuppliersInfo.Clone());
            }
        }

        private void RollbackProductSuppliers()
        {
            SectionProductEntities entity = (SectionProductEntities)CurrentModuleEntity;
            entity.ICProductSuppliersList.Clear();
            entity.ICProductSuppliersList.Invalidate(entity.ICProductSuppliersList.BackupList);
        }

        public void SetDefaultProductDesc()
        {
            ICProductsInfo objProductsInfo = (ICProductsInfo)CurrentModuleEntity.MainObject;
            objProductsInfo.ICProductDesc = string.Empty;
            if (objProductsInfo.ICProductType == ProductType.Section.ToString())
            {
                //ProductGroup
                ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
                ICProductGroupsInfo objProductGroupsInfo = new ICProductGroupsInfo();
                ICProductGroupsInfo objProductGroupParentsInfo = new ICProductGroupsInfo();
                objProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(objProductsInfo.FK_ICProductGroupID);
                //objProductsInfo.ICProductDesc += string.Format(string.IsNullOrEmpty(objProductsInfo.ICProductDesc) ? "{0}" : " {0}", objProductsInfo.ICProductName + ",");
                if (objProductGroupsInfo != null)
                {
                    if (objProductGroupsInfo.ICProductGroupParentID > 0)
                        objProductGroupParentsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(objProductGroupsInfo.ICProductGroupParentID);

                    if (objProductGroupParentsInfo != null)
                        objProductsInfo.ICProductDesc += string.Format(string.IsNullOrEmpty(objProductsInfo.ICProductDesc) ? "{0}" : " {0}",
                              objProductGroupParentsInfo.ICProductGroupName + " " + objProductGroupsInfo.ICProductGroupName + "");
                    else
                        objProductsInfo.ICProductDesc += string.Format(string.IsNullOrEmpty(objProductsInfo.ICProductDesc) ? "{0}" : " {0}",
                             objProductGroupsInfo.ICProductGroupName + "");
                }
                if (objProductsInfo.ICProductSizeAndSpecifiCations != string.Empty)
                {
                    objProductsInfo.ICProductDesc += string.Format(", {0}", objProductsInfo.ICProductSizeAndSpecifiCations);
                }
                //Attribute
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

        public void ShowCategoryTree()
        {
            if (IsEditable())
            {
                ActionEdit();
            }

            SectionProductEntities entity = (SectionProductEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
            ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
            ICDepartmentsInfo objICDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByNo(BOSApp.GetDisplayTextFromConfigText(ConfigValueGroup.DepartmentGroup, DepartmentGroup.SectionNo.ToString()));
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
            SectionProductEntities entity = (SectionProductEntities)CurrentModuleEntity;
            entity.ProductBranchPriceList.Clear();
            entity.ProductBranchPriceList.Invalidate(entity.ProductBranchPriceList.BackupList);
        }

        private void BackupProductBranchPrices()
        {
            SectionProductEntities entity = (SectionProductEntities)CurrentModuleEntity;
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
            SectionProductEntities entity = (SectionProductEntities)CurrentModuleEntity;
            entity.ProductPurchasePriceList.Clear();
            entity.ProductPurchasePriceList.Invalidate(entity.ProductPurchasePriceList.BackupList);
        }

        public void BackupPurchasePrices()
        {
            SectionProductEntities entity = (SectionProductEntities)CurrentModuleEntity;
            entity.ProductPurchasePriceList.BackupList.Clear();
            foreach (ICProductBranchPricesInfo objProductBranchPricesInfo in entity.ProductPurchasePriceList)
            {
                entity.ProductPurchasePriceList.BackupList.Add((ICProductBranchPricesInfo)objProductBranchPricesInfo.Clone());
            }
        }

        public void ShowPriceLevelForm()
        {
            SectionProductEntities entity = (SectionProductEntities)CurrentModuleEntity;
            guiEditPrice guiEditPrice = new guiEditPrice(((ICProductsInfo)entity.MainObject).ICProductID, entity.ICProductPricesList);
            guiEditPrice.ShowDialog();
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo searchObject = (ICProductsInfo)CurrentModuleEntity.SearchObject;
            searchObject.ICProductType = ProductType.Section.ToString();
            ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
            ICDepartmentsInfo objICDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByNo(BOSApp.GetDisplayTextFromConfigText(ConfigValueGroup.DepartmentGroup, DepartmentGroup.SectionNo.ToString()));
            int departmentID = 0;
            if (objICDepartmentsInfo != null)
                departmentID = objICDepartmentsInfo.ICDepartmentID;
            searchObject.FK_ICDepartmentID = departmentID;

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
            SectionProductEntities entity = (SectionProductEntities)CurrentModuleEntity;
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
            SectionProductEntities entity = (SectionProductEntities)CurrentModuleEntity;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> ProductList = new List<ICProductsInfo>();
            if (objProductsInfo.FK_ICProductGroupID == 0 || objProductsInfo.FK_ICProductGroupID == null)
            {
                MessageBox.Show(SectionProductLocalizedResources.ProductGroupIsNull, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            return base.ActionSave();
        }
    }
}
