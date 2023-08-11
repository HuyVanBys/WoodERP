using BOSLib;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP033 : ReportForm
    {
        #region Variables
        /// <summary>
        /// Product group id
        /// </summary>
        private int ProductGroupID = 0;

        /// <summary>
        /// A variable to store the report data source
        /// </summary>
        private DataTable ReportDataSource;
        #endregion

        public RP033()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }
        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RP033_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            //Set default branch
            fld_lkeBRBranchID.EditValue = BOSApp.CurrentCompanyInfo.FK_BRBranchID;

            ICStocksController objStocksController = new ICStocksController();
            List<ICStocksInfo> stocks = objStocksController.GetStocksByUserGroupID(BOSApp.CurrentUserGroupInfo.ADUserGroupID);
            stocks.Insert(0, new ICStocksInfo());
            fld_lkeICStockID.Properties.DataSource = stocks;

            fld_lblSubTitle.Text = string.Empty;
            fld_lblSubTitleDate.Text = string.Empty;

            fld_btnPrint.Enabled = false;
        }

        /// <summary>
        /// Show treelist category
        /// </summary>
        public void ShowCategoryTree()
        {
            int departmentID = 0;
            departmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            int productGroupID = objProductGroupsController.GetObjectIDByName(Convert.ToString(fld_bedICProductGroupID.EditValue));
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(productGroupID);
            guiProductGroupTree.Module = this.Module;
            guiProductGroupTree.ICDepartmentID = departmentID;

            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {

                ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)guiProductGroupTree.TreeList.GetSelectedObject();
                if (objProductGroupsInfo != null)
                {
                    fld_bedICProductGroupID.Text = guiProductGroupTree.GetSelectedProductGroupName();
                    ProductGroupID = objProductGroupsInfo.ICProductGroupID;
                    fld_lkeFK_ICDepartmentID.EditValue = guiProductGroupTree.ICDepartmentID;
                }
                else
                {
                    fld_bedICProductGroupID.Text = String.Empty;
                    ProductGroupID = 0;
                }
            }
        }

        /// <summary>
        /// Initialize data source and refresh grid control
        /// </summary>
        public void InitializeDataSource()
        {
            BOSProgressBar.Start(ReportLocalizedResources.LoadingData);
            ADReportsController objReportsController = new ADReportsController();
            ICStocksController objStocksController = new ICStocksController();
            ICProductsController objProductsController = new ICProductsController();
            ICProductComponentsController objProductComponentsController = new ICProductComponentsController();
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int stockID = Convert.ToInt32(fld_lkeICStockID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            int productGroupID = ProductGroupID;
            int supplierID = Convert.ToInt32(fld_lkeFK_APSupplierID.EditValue);
            //Set title report
            fld_lblSubTitle.Text = fld_lkeBRBranchID.Text.ToUpper();
            fld_lblSubTitleDate.Text = String.Format("{0} {1}", ReportLocalizedResources.DateTitle, DateTime.Now.ToString("dd/MM/yyyy"));

            List<ICStocksInfo> stockList = GetStockList(branchID, stockID);
            DataTable resultTable = null;
            DataSet ds = objReportsController.GetParentProducts(departmentID, productGroupID, supplierID);
            if (ds.Tables.Count > 0)
            {
                resultTable = ds.Tables[0];
            }
            foreach (ICStocksInfo objStocksInfo in stockList)
            {
                resultTable.Columns.Add(objStocksInfo.ICStockID.ToString(), typeof(string));
            }

            SortedList<int, List<ICProductsInfo>> inventoryProducts = new SortedList<int, List<ICProductsInfo>>();
            SortedList<int, List<ICProductsInfo>> inventoryComponents = new SortedList<int, List<ICProductsInfo>>();
            bool isSuccessful = GetInventoryProductsFromCentre(ds, stockList, ref inventoryProducts, ref inventoryComponents);
            if (!isSuccessful)
            {
                BOSProgressBar.Close();
                return;
            }

            for (int i = 0; i < resultTable.Rows.Count; i++)
            {
                DataRow row = resultTable.Rows[i];
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectFromDataRow(row);
                if (inventoryProducts.ContainsKey(objProductsInfo.ICProductID))
                {
                    List<ICProductsInfo> products = inventoryProducts[objProductsInfo.ICProductID];
                    List<ICProductsInfo> components = inventoryComponents[objProductsInfo.ICProductID];
                    bool exists = false;
                    foreach (ICStocksInfo objStocksInfo in stockList)
                    {
                        objProductsInfo = products.Where(p => p.ICProductID == objProductsInfo.ICProductID && p.ICStockID == objStocksInfo.ICStockID).FirstOrDefault();
                        if (objProductsInfo != null)
                        {
                            List<ICProductsInfo> stockComponents = components.Where(p => p.ICStockID == objStocksInfo.ICStockID).ToList();
                            decimal fullQty = 0;
                            foreach (ICProductsInfo component in stockComponents)
                            {
                                if (component.ICProductComponentQty > 0)
                                {
                                    decimal qty = Math.Ceiling(component.ICInventoryStockQuantity / component.ICProductComponentQty);
                                    if (qty > fullQty)
                                    {
                                        fullQty = qty;
                                    }
                                }
                            }

                            decimal missingQty = 0;
                            foreach (ICProductsInfo component in stockComponents)
                            {
                                decimal qty = Math.Ceiling((fullQty * component.ICProductComponentQty - component.ICInventoryStockQuantity) / component.ICProductComponentQty);
                                if (qty > missingQty)
                                {
                                    missingQty = qty;
                                }
                            }

                            string stockDesc = string.Empty;
                            if (missingQty > 0)
                            {
                                stockDesc = missingQty.ToString();
                                foreach (ICProductsInfo component in stockComponents)
                                {
                                    decimal componentMissingQty = fullQty * component.ICProductComponentQty - component.ICInventoryStockQuantity;
                                    if (componentMissingQty > 0)
                                    {
                                        stockDesc += Environment.NewLine + string.Format("{0} {1}", componentMissingQty, component.ICProductDesc);
                                    }
                                }
                                exists = true;
                            }
                            row[objStocksInfo.ICStockID.ToString()] = stockDesc;
                        }
                    }

                    if (!exists)
                    {
                        resultTable.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }

            fld_dgcICRP033Products.DataSource = resultTable;
            ReportDataSource = resultTable;
            fld_dgcICRP033Products.AddInventoryColumns(stockList);
            fld_dgcICRP033Products.RefreshDataSource();
            if (resultTable == null || resultTable.Rows.Count == 0)
                fld_btnPrint.Enabled = false;
            else
                fld_btnPrint.Enabled = true;

            BOSProgressBar.Close();
        }

        /// <summary>
        /// Get inventory products from the centre
        /// </summary>
        /// <param name="productDataSet">List of products to get inventory</param>
        /// <param name="stockList">List of stocks to get inventory</param>
        /// <param name="inventoryProducts">The inventory products are gotten</param>
        /// <param name="inventoryComponents">The inventory components are gotten</param>
        /// <returns>A value indicates whether the process is successful</returns>
        private bool GetInventoryProductsFromCentre(
                                            DataSet productDataSet,
                                            List<ICStocksInfo> stockList,
                                            ref SortedList<int, List<ICProductsInfo>> inventoryProducts,
                                            ref SortedList<int, List<ICProductsInfo>> inventoryComponents)
        {
            bool isSuccessful = false;
            ICProductsController objProductsController = new ICProductsController();
            ADReportsController objReportsController = new ADReportsController();

            //NUThao [ADD] [08/04/2014] [DB centre] [SwitchConnection issue], START
            //try
            //{
            //    BRBranchsController objBranchsController = new BRBranchsController();
            //    BRBranchsInfo centre = objBranchsController.GetCentre();
            //    if (centre != null)
            //    {
            //        BOSApp.SwitchConnection(centre.BRBranchID);
            //        if (BOSApp.TestCurrentConnection())
            //        {
            //            foreach (DataRow row in productDataSet.Tables[0].Rows)
            //            {
            //                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectFromDataRow(row);
            //                List<ICProductsInfo> products = objReportsController.GetProductInventoryByProductID(objProductsInfo.ICProductID);
            //                List<ICProductsInfo> components = objReportsController.GetComponentInventoryByProductID(objProductsInfo.ICProductID);
            //                foreach (ICStocksInfo objStocksInfo in stockList)
            //                {
            //                    objProductsInfo = products.Where(p => p.ICProductID == objProductsInfo.ICProductID && p.ICStockID == objStocksInfo.ICStockID).FirstOrDefault();
            //                    if (objProductsInfo != null)
            //                    {
            //                        if (objProductsInfo.HasComponent)
            //                        {
            //                            objProductsInfo.ICInventoryStockQuantity = CalculateProductQtyByComponent(objProductsInfo.ICProductID, objStocksInfo.ICStockID);
            //                        }
            //                    }
            //                }
            //                inventoryProducts.Add(objProductsInfo.ICProductID, products);
            //                inventoryComponents.Add(objProductsInfo.ICProductID, components);
            //            }
            //            isSuccessful = true;
            //        }
            //        else
            //        {
            //            MessageBox.Show(string.Format(DataExchangeLocalizedResources.CannotConnectToCentre, centre.BRBranchName), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //}
            //finally
            //{
            //    BOSApp.RollbackLocalConnection();
            //}

            foreach (DataRow row in productDataSet.Tables[0].Rows)
            {
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectFromDataRow(row);
                List<ICProductsInfo> products = objReportsController.GetProductInventoryByProductID(objProductsInfo.ICProductID);
                List<ICProductsInfo> components = objReportsController.GetComponentInventoryByProductID(objProductsInfo.ICProductID);
                foreach (ICStocksInfo objStocksInfo in stockList)
                {
                    objProductsInfo = products.Where(p => p.ICProductID == objProductsInfo.ICProductID && p.ICStockID == objStocksInfo.ICStockID).FirstOrDefault();
                    if (objProductsInfo != null)
                    {
                        if (objProductsInfo.HasComponent)
                        {
                            objProductsInfo.ICInventoryStockQuantity = CalculateProductQtyByComponent(objProductsInfo.ICProductID, objStocksInfo.ICStockID);
                        }
                    }
                }
                inventoryProducts.Add(objProductsInfo.ICProductID, products);
                inventoryComponents.Add(objProductsInfo.ICProductID, components);
            }
            isSuccessful = true;
            //NUThao [ADD] [08/04/2014] [DB centre] [SwitchConnection issue], END

            return isSuccessful;
        }

        /// <summary>
        /// Calculate the quantity of a product based on its inventory components
        /// </summary>
        /// <param name="productID">Product id</param>
        /// <param name="stockID">Stock id</param>
        /// <returns>On-hand quantity of the product in the stock</returns>
        private decimal CalculateProductQtyByComponent(int productID, int stockID)
        {
            ADReportsController objReportsController = new ADReportsController();
            List<ICProductsInfo> components = objReportsController.GetComponentInventoryByProductID(productID);
            decimal productQty = Int32.MaxValue;
            foreach (ICProductsInfo component in components)
            {
                if (component.ICStockID == stockID)
                {
                    if (component.ICProductComponentQty > 0)
                    {
                        decimal qty = Math.Floor(component.ICInventoryStockQuantity / component.ICProductComponentQty);
                        if (qty < productQty)
                        {
                            productQty = qty;
                        }
                    }
                }
            }
            if (productQty == Int32.MaxValue)
            {
                productQty = 0;
            }
            return productQty;
        }

        /// <summary>
        /// Get stock list
        /// </summary>
        /// <param name="branchID">Branch id</param>
        /// <param name="stockID">Stock id</param>
        /// <returns>List of stock</returns>
        public List<ICStocksInfo> GetStockList(int branchID, int stockID)
        {
            List<ICStocksInfo> stockList = new List<ICStocksInfo>();
            DataSet ds = new DataSet();
            ICStocksController objStocksController = new ICStocksController();
            if (stockID > 0)
            {
                ds = objStocksController.GetDataSetByID(stockID);
            }
            else if (branchID > 0)
            {
                ds = objStocksController.GetAllDataByForeignColumn("FK_BRBranchID", branchID);
            }
            else
            {
                ds = objStocksController.GetAllObjects();
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICStocksInfo objStocksInfo = (ICStocksInfo)objStocksController.GetObjectFromDataRow(row);
                    //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                    if (branchID == 0)
                    {
                        bool hasExist = BranchList.Exists(branch => branch.BRBranchID == objStocksInfo.FK_BRBranchID);
                        if (hasExist)
                            stockList.Add(objStocksInfo);
                    }
                    //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
                    else
                    {
                        stockList.Add(objStocksInfo);
                    }
                }
            }
            return stockList;
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            InitializeDataSource();
        }

        #region Initialize export excel parameter
        protected override List<ExportExcelParameter> GetReportHeader()
        {
            List<ExportExcelParameter> lstHeaderParameter = base.GetReportHeader();
            lstHeaderParameter.Add(SetDefaultSubHeaderParameter(fld_lblTitle.Text, 1, 4));
            return lstHeaderParameter;
        }

        protected override List<ExportExcelParameter> GetReportContent(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            List<DataTable> dataTableList = new List<DataTable>();
            DataTable table = GetDefaultTableFromGridView(gridView);
            List<string> departmentAndProductGroupList = new List<string>();

            //Init data row for datatable
            for (int i = 0; i < gridView.DataRowCount; i++)
            {
                if (gridView.GetRow(i) != null)
                {
                    int departmentID = (int)gridView.GetRowCellValue(i, gridView.Columns["FK_ICDepartmentID"]);
                    int productGroupID = (int)gridView.GetRowCellValue(i, gridView.Columns["FK_ICProductGroupID"]);
                    String strDepartmentAndProductGroupID = String.Format("{0};{1}", departmentID.ToString(), productGroupID.ToString());
                    DataTable tempTable = new DataTable();
                    if (departmentAndProductGroupList.Count == 0 || !departmentAndProductGroupList.Contains(strDepartmentAndProductGroupID))
                    {
                        departmentAndProductGroupList.Add(strDepartmentAndProductGroupID);
                        tempTable = table.Clone();
                        tempTable.TableName = strDepartmentAndProductGroupID;
                        dataTableList.Add(tempTable);
                    }
                    tempTable = dataTableList[departmentAndProductGroupList.IndexOf(strDepartmentAndProductGroupID)];
                    DataRow row = tempTable.NewRow();
                    for (int j = 0; j < VisibleColumns.Count; j++)
                    {
                        String value = gridView.GetRowCellDisplayText(i, gridView.Columns[tempTable.Columns[j].ColumnName]);
                        if (table.Columns[j].DataType == typeof(decimal))
                        {
                            if (String.IsNullOrEmpty(value))
                                value = "0";
                            row[j] = decimal.Parse(value);
                        }
                        else if (table.Columns[j].DataType == typeof(float))
                        {
                            if (String.IsNullOrEmpty(value))
                                value = "0";
                            row[j] = float.Parse(value);
                        }
                        else
                            row[j] = value;
                    }
                    dataTableList[departmentAndProductGroupList.IndexOf(strDepartmentAndProductGroupID)].Rows.Add(row);
                }
            }

            List<ExportExcelParameter> parameterList = new List<ExportExcelParameter>();
            String filterDepartment = String.Empty;
            foreach (DataTable tableItem in dataTableList)
            {
                String[] strDepartmentAndProductGroupID = tableItem.TableName.Split(new char[] { ';' });
                String departmentName = ((ICDepartmentsInfo)new ICDepartmentsController().GetObjectByID(int.Parse(strDepartmentAndProductGroupID[0]))).ICDepartmentName;
                String productGroupName = ((ICProductGroupsInfo)new ICProductGroupsController().GetObjectByID(int.Parse(strDepartmentAndProductGroupID[1]))).ICProductGroupName;

                if (!departmentName.Equals(filterDepartment))
                    parameterList.Add(SetDefaultTableNameParameter(departmentName, ContentRowIndex, 1));

                parameterList.Add(SetDefaultSubTableNameParameter(productGroupName, ContentRowIndex + 1, 2));
                parameterList.Add(new ExportExcelParameter(ContentRowIndex + 2, 2, tableItem));
                ContentRowIndex += tableItem.Rows.Count + 3;
                filterDepartment = departmentName;
            }
            SummaryRowIndex = ContentRowIndex;
            ContentStartYIndex = 2;
            return parameterList;
        }
        #endregion

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int stockID = Convert.ToInt32(fld_lkeICStockID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            int productGroupID = ProductGroupID;
            int supplierID = Convert.ToInt32(fld_lkeFK_APSupplierID.EditValue);

            ADReportsController objReportsController = new ADReportsController();
            ICProductsController objProductsController = new ICProductsController();
            ICProductComponentsController objProductComponentsController = new ICProductComponentsController();
            List<ICStocksInfo> stockList = GetStockList(branchID, stockID);
            BOSReport.RP033 report = new BOSReport.RP033(stockList);
            //report.LoadLayout(BOSCommon.Constants.Report.DevProductComponentParentInventoryStockReportPath);
            report.AddDynamicColumn();
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;
            //Set title report
            XRLabel title = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblTitle"];
            if (title != null)
                title.Text += string.Format(" {0}", fld_lkeBRBranchID.Text.ToUpper());
            XRLabel subTitle = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblSubTitle"];
            if (subTitle != null)
                subTitle.Text += String.Format("{0} {1}", ReportLocalizedResources.DateTitle, DateTime.Now.ToString("dd/MM/yyyy"));

            report.DataSource = ReportDataSource;
            report.DataMember = BOSCommon.Constants.Report.DevProductComponentParentInventoryStockReportName;
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevProductComponentParentInventoryStockReportPath, true);
            reviewer.Show();
        }

        private void fld_bedICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ShowCategoryTree();
        }
    }
}
