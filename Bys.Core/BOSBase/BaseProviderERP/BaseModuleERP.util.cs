using BOSCommon;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace BOSERP
{
    partial class BaseModuleERP
    {
        #region Set Default Values From Customer,Supplier
        public virtual void SetDefaultValuesFromCustomer()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            int customerID = Convert.ToInt32(dbUtil.GetPropertyValue(CurrentModuleEntity.MainObject, "FK_ARCustomerID"));
            ARCustomersController objCustomersController = new ARCustomersController();
            ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(customerID);
            if (objCustomersInfo != null)
            {
                CurrentModuleEntity.SetDefaultValuesFromCustomer(objCustomersInfo);
                DisplayLabelText(objCustomersInfo);
                DisplayLabelText(CurrentModuleEntity.MainObject);
            }
        }

        public virtual void SetDefaultValuesFromSupplier()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            int supplierID = Convert.ToInt32(dbUtil.GetPropertyValue(CurrentModuleEntity.MainObject, "FK_APSupplierID"));
            APSuppliersController objSuppliersController = new APSuppliersController();
            APSuppliersInfo objSuppliersInfo = (APSuppliersInfo)objSuppliersController.GetObjectByID(supplierID);
            if (objSuppliersInfo != null)
            {
                CurrentModuleEntity.SetDefaultValuesFromSupplier(objSuppliersInfo);
                DisplayLabelText(objSuppliersInfo);
                DisplayLabelText(CurrentModuleEntity.MainObject);
            }
        }
        #endregion

        #region Generate Search Query based on Search Fields of Module

        public virtual String GenerateSearchQuery(String strTableName)
        {
            StringBuilder strSearchQueryBuilder = new StringBuilder();
            strSearchQueryBuilder.Append(GenerateSearchQueryHeader(strTableName));
            strSearchQueryBuilder.Append("WHERE" + BOSUtil.NewLine);
            strSearchQueryBuilder.Append(GenerateConditionsForSearch(strTableName));
            strSearchQueryBuilder.Append(BOSUtil.NewLine);
            return strSearchQueryBuilder.ToString();
        }

        public virtual String GenerateSearchQueryHeader(String strTableName)
        {
            StringBuilder strSearchQueryHeaderBuilder = new StringBuilder();
            if (Controls[BOSApp.cstTopResultsSearchControl] != null)
            {
                int iTopResults = Convert.ToInt32(((DevExpress.XtraEditors.BaseEdit)Controls[BOSApp.cstTopResultsSearchControl]).EditValue);
                //iTopResults must be greater or equal to 0
                if (iTopResults < 0)
                    iTopResults = 0;
                strSearchQueryHeaderBuilder.Append(String.Format("SELECT TOP({0}) ", iTopResults));
                strSearchQueryHeaderBuilder.Append("* FROM [dbo]." + strTableName + BOSUtil.NewLine);
            }
            else
            {
                strSearchQueryHeaderBuilder.Append("SELECT * FROM [dbo]." + strTableName + BOSUtil.NewLine);
            }

            return strSearchQueryHeaderBuilder.ToString();
        }

        public virtual String GenerateConditionsForSearch(String strTableName)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            StringBuilder strConditionBuilder = new StringBuilder();
            STFieldsController objSTFieldsController = new STFieldsController();
            foreach (Control ctrl in SearchScreen.CriteriaSection.Controls)
                if (ctrl.Tag != null && ctrl.Tag.ToString() == BOSERPScreen.SearchControl)
                {
                    String strColumnName = dbUtil.GetPropertyStringValue(ctrl, BOSERPScreen.cstDataMemberPropertyName);
                    strConditionBuilder.Append(GenerateConditionsForSearch(ctrl, strTableName, strColumnName));
                }
            strConditionBuilder.Append(BOSUtil.Tab + String.Format("([AAStatus]='Alive')") + BOSUtil.NewLine);

            return strConditionBuilder.ToString();
        }

        public virtual String GenerateConditionsForSearch(Control ctrl, String strTableName, String strColumnName)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            StringBuilder strConditionBuilder = new StringBuilder();
            String strFieldName = ctrl.Name;
            if (strFieldName.Contains("TopResult"))
                return String.Empty;
            String strColumnDbType = dbUtil.GetColumnDbType(strTableName, strColumnName);
            object editValue = ((DevExpress.XtraEditors.BaseEdit)ctrl).EditValue;
            if (editValue == null)
                return String.Empty;
            if (editValue.ToString() == String.Empty)
                return String.Empty;

            if (strColumnDbType.Contains("varchar") || strColumnDbType.Contains("nvarchar"))
            {
                #region varchar
                String strColumnValue = BOSUtil.GetSearchString(editValue.ToString());
                if (!string.IsNullOrEmpty(strColumnValue))
                {
                    if (strFieldName.Contains("SearchFrom"))
                    {
                        strConditionBuilder.Append(BOSUtil.Tab + String.Format("([{0}] >= '{1}')", strColumnName, strColumnValue));
                    }
                    else if (strFieldName.Contains("SearchTo"))
                    {
                        strConditionBuilder.Append(BOSUtil.Tab + String.Format("([{0}] <= '{1}')", strColumnName, strColumnValue));
                    }
                    else
                    {
                        strConditionBuilder.Append(BOSUtil.Tab + String.Format("([{0}] LIKE N'%{1}%')", strColumnName, strColumnValue));
                    }

                    strConditionBuilder.Append(BOSUtil.NewLine + BOSUtil.Tab + "AND" + BOSUtil.NewLine);
                }
                #endregion

            }
            else if (strColumnDbType.Contains("datetime"))
            {
                #region datetime
                DateTime dtColumnValue = Convert.ToDateTime(editValue);
                String strFormatDatetime = String.Format("yyyyMMdd");
                if (strFieldName.Contains("SearchFrom"))
                {
                    strConditionBuilder.Append(BOSUtil.Tab + String.Format("((CONVERT(VARCHAR(10), [{0}], 112) >= CONVERT(VARCHAR(10),'{1}', 112)))",
                        strColumnName, dtColumnValue.ToString(strFormatDatetime)));
                }
                else if (strFieldName.Contains("SearchTo"))
                {
                    strConditionBuilder.Append(BOSUtil.Tab + String.Format("((CONVERT(VARCHAR(10), [{0}], 112) <= CONVERT(VARCHAR(10),'{1}', 112)))",
                        strColumnName, dtColumnValue.ToString(strFormatDatetime)));
                }
                else
                {
                    strConditionBuilder.Append(BOSUtil.Tab + String.Format("((CONVERT(VARCHAR(10), [{0}], 112) = CONVERT(VARCHAR(20),'{1}', 112)))",
                        strColumnName, dtColumnValue.ToString(strFormatDatetime)));
                }

                strConditionBuilder.Append(BOSUtil.NewLine + BOSUtil.Tab + "AND" + BOSUtil.NewLine);
                #endregion
            }

            else if (strColumnDbType.Contains("int"))
            {
                #region int
                int iColumnValue = Convert.ToInt32(editValue.ToString());
                if (iColumnValue > 0)
                {
                    if (strFieldName.Contains("SearchFrom"))
                    {
                        strConditionBuilder.Append(BOSUtil.Tab + String.Format("([{0}] >= {1})", strColumnName, iColumnValue));
                    }
                    else if (strFieldName.Contains("SearchTo"))
                    {
                        strConditionBuilder.Append(BOSUtil.Tab + String.Format("([{0}] <= {1})", strColumnName, iColumnValue));
                    }
                    else
                    {
                        strConditionBuilder.Append(BOSUtil.Tab + String.Format("([{0}] = {1})", strColumnName, iColumnValue));
                    }

                    strConditionBuilder.Append(BOSUtil.NewLine + BOSUtil.Tab + "AND" + BOSUtil.NewLine);
                }
                #endregion
            }
            else if (strColumnDbType.Contains("float"))
            {
                #region float
                double dbColumnValue = Convert.ToDouble(editValue.ToString());
                if (strFieldName.Contains("SearchFrom"))
                {
                    strConditionBuilder.Append(BOSUtil.Tab + String.Format("([{0}] >= {1})", strColumnName, dbColumnValue));
                }
                else if (strFieldName.Contains("SearchTo"))
                {
                    strConditionBuilder.Append(BOSUtil.Tab + String.Format("([{0}] <= {1})", strColumnName, dbColumnValue));
                }
                else
                {
                    strConditionBuilder.Append(BOSUtil.Tab + String.Format("([{0}] = {1})", strColumnName, dbColumnValue));
                }

                strConditionBuilder.Append(BOSUtil.NewLine + BOSUtil.Tab + "AND" + BOSUtil.NewLine);
                #endregion
            }
            else if (strColumnDbType.Contains("bit"))
            {
                #region Bit
                bool bColumnValue = Convert.ToBoolean(editValue);
                strConditionBuilder.Append(BOSUtil.Tab + String.Format("([{0}] = {1})", strColumnName, bColumnValue));
                strConditionBuilder.Append(BOSUtil.NewLine + BOSUtil.Tab + "AND" + BOSUtil.NewLine);
                #endregion
            }
            else
            {
                return String.Empty;
            }
            return strConditionBuilder.ToString();
        }
        #endregion

        /// <summary>
        /// Set label's text to corresponding property of the given object
        /// </summary>
        /// <param name="obj">The given object</param>
        /// <param name="ctrl">Label needs to be set</param>
        public virtual void DisplayLabelText(BusinessObject obj, Control ctrl)
        {
            if (ctrl is BOSLabel || ctrl is Label || ctrl is LabelControl || ctrl is BOSHyperLinkEdit)
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                String strObjectTableName = BOSUtil.GetTableNameFromBusinessObject(obj);
                String strDataSource = dbUtil.GetPropertyStringValue(ctrl, BOSERPScreen.cstDataSourcePropertyName);
                String strDataMember = dbUtil.GetPropertyStringValue(ctrl, BOSERPScreen.cstDataMemberPropertyName);
                if (!String.IsNullOrEmpty(ctrl.AccessibleName))
                {
                    strDataSource = ctrl.AccessibleName.Split(';')[0];
                    strDataMember = ctrl.AccessibleName.Split(';')[1];
                }
                if (!String.IsNullOrEmpty(strDataSource) && !String.IsNullOrEmpty(strDataMember))
                {
                    if (strDataSource == strObjectTableName)
                    {
                        PropertyInfo prop = obj.GetType().GetProperty(strDataMember);
                        if (prop != null && prop.GetValue(obj, null) != null)
                        {
                            object objValue = prop.GetValue(obj, null);
                            if (objValue != null)
                            {
                                Type columnType = objValue.GetType();
                                if (columnType == typeof(String))
                                    ctrl.Text = objValue.ToString();
                                else if (columnType == typeof(int))
                                    ctrl.Text = BOSUtil.GetNumberDisplayFormat(Convert.ToInt32(objValue));
                                else if (columnType == typeof(double))
                                {
                                    double dblValue = Convert.ToDouble(objValue);
                                    ctrl.Text = BOSUtil.GetNumberDisplayFormat(dblValue);
                                }
                                else if (columnType == typeof(decimal))
                                {
                                    decimal decValue = Convert.ToDecimal(objValue);
                                    ctrl.Text = BOSUtil.GetNumberDisplayFormat(decValue);
                                }
                                else if (columnType == typeof(DateTime))
                                    ctrl.Text = objValue.ToString();
                                else if (columnType == typeof(bool))
                                    ctrl.Text = objValue.ToString();
                                else
                                    ctrl.Text = objValue.ToString();
                            }
                        }
                    }
                }
            }
        }

        public virtual void DisplayLabelText(BusinessObject obj)
        {
            foreach (DictionaryEntry entry in Controls)
            {
                Control ctrl = (Control)entry.Value;
                DisplayLabelText(obj, ctrl);
            }
        }

        /// <summary>
        /// Show inventory info of a product for the current transaction
        /// </summary>
        /// <param name="productID">Product id</param>
        //public virtual void ShowInventory(int productID, string desc)
        //{

        //}


        public virtual void ShowInventory(int productID, string desc, int modelID, int modelDetailID)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo != null)
            {
                int userGroupID = BOSApp.CurrentUserGroupInfo.ADUserGroupID;
                guiInventoryStockQuantity guiInventoryStockQuantity = new guiInventoryStockQuantity();
                guiInventoryStockQuantity.Module = this;
                guiInventoryStockQuantity.Product = objProductsInfo;
                List<ICInventoryStocksInfo> inventoryStocks = new List<ICInventoryStocksInfo>();
                ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
                inventoryStocks = objInventoryStocksController.GetInventoryStocksByProductIDAndStockID(productID, null, null, userGroupID);
                inventoryStocks = inventoryStocks.Union(objInventoryStocksController.GetInventoryStocksByProductIDAndStockID(productID, null)).ToList();

                //Collect inventory from the centre                
                List<ICInventoryStocksInfo> centralInventoryStocks = CentralInventoryStocks.Where(i => i.FK_ICProductID == productID).ToList();
                foreach (ICInventoryStocksInfo centralInventoryStock in centralInventoryStocks)
                {
                    if (centralInventoryStock.FK_BRBranchID != BOSApp.CurrentCompanyInfo.FK_BRBranchID &&
                        centralInventoryStock.BRBranchParentID != BOSApp.CurrentCompanyInfo.FK_BRBranchID)
                    {
                        ICInventoryStocksInfo objInventoryStocksInfo = inventoryStocks.Where(i => i.FK_ICStockID == centralInventoryStock.FK_ICStockID &&
                                                                                                    i.FK_ICProductID == centralInventoryStock.FK_ICProductID).FirstOrDefault();
                        if (objInventoryStocksInfo != null)
                        {
                            objInventoryStocksInfo.ICInventoryStockQuantity = centralInventoryStock.ICInventoryStockQuantity;
                        }
                        else
                        {
                            inventoryStocks.Add(centralInventoryStock);
                        }
                    }
                }

                inventoryStocks.Where(i => i.ICStockType == StockType.Sale.ToString() || i.ICStockType == StockType.Central.ToString())
                                .ToList()
                                .ForEach(i => i.InventoryType = InventoryType.OnHand.ToString());
                //NNGiang Remove SaleOrder Stock - Start
                inventoryStocks.Where(i => i.ICStockType == StockType.SaleOrder.ToString())
                                .ToList()
                                .ForEach(i => i.InventoryType = InventoryType.SaleOrder.ToString());
                //NNGiang Remove SaleOrder Stock - End

                inventoryStocks.Where(i => i.ICStockType == StockType.Purchase.ToString())
                               .ToList()
                               .ForEach(i => i.InventoryType = InventoryType.PurchaseOrder.ToString());

                inventoryStocks.Where(i => i.ICStockType == StockType.TransitIn.ToString())
                                .ToList()
                                .ForEach(i => i.InventoryType = InventoryType.TransitIn.ToString());

                inventoryStocks.Where(i => i.ICStockType == StockType.TransitOut.ToString())
                                .ToList()
                                .ForEach(i => i.InventoryType = InventoryType.TransitOut.ToString());

                inventoryStocks.Where(i => i.ICStockType == StockType.AllocationPlan.ToString())
                                .ToList()
                                .ForEach(i => i.InventoryType = InventoryType.AllocationPlan.ToString());

                inventoryStocks.Where(i => i.ICStockType == StockType.PurchasePlan.ToString())
                                .ToList()
                                .ForEach(i => i.InventoryType = InventoryType.PurchasePlan.ToString());

                //inventoryStocks = inventoryStocks.Where(i => i.ICInventoryStockQuantity > 0).ToList();
                guiInventoryStockQuantity.InventoryStockQuantityGridControl.DataSource = inventoryStocks;
                guiInventoryStockQuantity.ShowDialog();
            }
        }
        /// <summary>
        /// Show inventory details of a product based on inventory permission
        /// of the current user
        /// </summary>
        /// <param name="productID">The product id</param>
        /// <param name="inventoryType">Inventory type</param>
        public virtual void ShowInventoryDetails(int productID, string inventoryType)
        {

        }

        /// <summary>
        /// Synchronize serie for an object when transferring from a branch to another
        /// </summary>
        /// <param name="obj">Given object</param>
        public void SynProductSerie(BusinessObject obj)
        {
            ERPModuleEntities entity = (ERPModuleEntities)CurrentModuleEntity;
            entity.SynProductSerie(obj);
        }
    }
}
