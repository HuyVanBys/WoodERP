using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP032 : ReportForm
    {
        #region Variables
        /// <summary>
        /// Define product group id
        /// </summary>
        private int ProductGroupID = 0;

        /// <summary>
        /// A variable to store report data source 
        /// </summary>
        private DataTable ReportDataSource;
        #endregion

        public RP032()
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

        public List<ICStocksInfo> GetStockList()
        {
            ICStocksController objStocksController = new ICStocksController();
            List<ICStocksInfo> stockList = new List<ICStocksInfo>();
            int stockID = Convert.ToInt32(fld_lkeICStockID.EditValue);
            ICStocksInfo objStocksInfo = new ICStocksInfo();
            if (stockID != 0)
            {
                objStocksInfo = (ICStocksInfo)objStocksController.GetObjectByID(stockID);
                if (objStocksInfo != null)
                    stockList.Add(objStocksInfo);
                return stockList;
            }
            return objStocksController.GetStockPermissionByUserGroupID(BOSApp.CurrentUserGroupInfo.ADUserGroupID); ;
        }

        private void RP032_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            //Set default branch
            fld_lkeBRBranchID.EditValue = BOSApp.CurrentCompanyInfo.FK_BRBranchID;

            ICStocksController objStocksController = new ICStocksController();
            List<ICStocksInfo> stocks = objStocksController.GetStockPermissionByUserGroupID(BOSApp.CurrentUserGroupInfo.ADUserGroupID);
            stocks.Insert(0, new ICStocksInfo());
            fld_lkeICStockID.Properties.DataSource = stocks;
            fld_lblSubTitle.Text = string.Empty;
            fld_lblSubTitleDate.Text = string.Empty;
            fld_btnPrint.Enabled = false;
        }

        public void InitializeDataSource()
        {
            BOSProgressBar.Start(ReportLocalizedResources.LoadingData);
            ADReportsController objReportsController = new ADReportsController();

            fld_lblSubTitle.Text = fld_lkeBRBranchID.Text.ToUpper();
            fld_lblSubTitleDate.Text = String.Format("{0} {1}", ReportLocalizedResources.DateTitle, DateTime.Now.ToString("dd/MM/yyyy"));

            List<ICStocksInfo> stockList = GetStockList();
            if (stockList == null)
                stockList = new List<ICStocksInfo>();

            DataTable resultTable = GetInventoryStock(stockList);

            fld_dgcICRP032Products.DataSource = resultTable;
            ReportDataSource = resultTable;

            fld_dgcICRP032Products.AddInventoryColumns(stockList);
            fld_dgcICRP032Products.RefreshDataSource();
            fld_dgcICRP032Products.Refresh();
            GridView gridView = (GridView)fld_dgcICRP032Products.MainView;
            gridView.ExpandAllGroups();
            if (resultTable == null || resultTable.Rows.Count == 0)
                fld_btnPrint.Enabled = false;
            else
                fld_btnPrint.Enabled = true;

            BOSProgressBar.Close();
        }

        public DataTable GetInventoryStock(List<ICStocksInfo> stockList)
        {
            ADReportsController objReportsController = new ADReportsController();
            ICProductsController objProductsController = new ICProductsController();
            ICStocksController objStocksController = new ICStocksController();
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int stockID = Convert.ToInt32(fld_lkeICStockID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            int productGroupID = ProductGroupID;
            int supplierID = Convert.ToInt32(fld_lkeFK_APSupplierID.EditValue);

            DataTable resultTable = null;
            DataColumn columnTable = null;

            string stockRef = string.Join(",", stockList.Select(o => o.ICStockID.ToString()).ToArray());
            DataSet ds = objReportsController.GetDataForRP032StockMinMax(branchID, stockRef, departmentID, productGroupID, supplierID);

            resultTable = ds.Tables[0];
            ICTransactionsController objTransactionsController = new ICTransactionsController();
            List<ICTransactionsInfo> transactionList = new List<ICTransactionsInfo>();
            if (ds.Tables.Count > 1)
            {
                foreach (DataRow row in ds.Tables[1].Rows)
                {
                    ICTransactionsInfo obj = (ICTransactionsInfo)objTransactionsController.GetObjectFromDataRow(row);
                    transactionList.Add(obj);
                }
            }

            decimal inventoryStockQty = 0;
            int indexTotalQty = 0;
            int productID = 0;
            foreach (ICStocksInfo stock in stockList)
            {
                columnTable = new DataColumn();
                columnTable = resultTable.Columns.Add(stock.ICStockID.ToString(), typeof(decimal));
                for (int i = 0; i < resultTable.Rows.Count; i++)
                {
                    productID = Convert.ToInt32(objProductsController.GetRowCellValue(resultTable.Rows[i], "ICProductID"));
                    inventoryStockQty = transactionList.Where(o => o.FK_ICStockID == stock.ICStockID && o.FK_ICProductID == productID)
                                                       .Select(o => o.ICTransactionExchangeQty).Sum();
                    resultTable.Rows[i][columnTable] = inventoryStockQty;
                    indexTotalQty = resultTable.Columns.IndexOf("ICInventoryStockTotalQty");
                    if (indexTotalQty == -1)
                        continue;
                    resultTable.Rows[i][indexTotalQty] = Convert.ToDecimal(resultTable.Rows[i][indexTotalQty]) + inventoryStockQty;
                }
            }
            return resultTable;
        }

        /// <summary>
        /// Compare inventory stock quantity with product stock min and max
        /// </summary>
        /// <param name="objProductsInfo">Given product</param>
        /// <param name="inventoryStockQty">Inventory stock quantity</param>
        /// <returns>Value of result</returns>
        public int CompareInventoryStockQtyWithProductStockMinMax(ICProductsInfo objProductsInfo, decimal inventoryStockQty)
        {
            TimeSpan timeSpanStockMaxDateFrom = DateTime.Now.Subtract(objProductsInfo.ICProductStockMaxDateFrom);
            decimal compareStockMaxDateFrom = (decimal)timeSpanStockMaxDateFrom.TotalDays;

            TimeSpan timeSpanStockMaxDateTo = objProductsInfo.ICProductStockMaxDateTo.Subtract(DateTime.Now);
            decimal compareStockMaxDateTo = (decimal)timeSpanStockMaxDateTo.TotalDays;

            TimeSpan timeSpanStockMinDateFrom = DateTime.Now.Subtract(objProductsInfo.ICProductStockMinDateFrom);
            decimal compareStockMinDateFrom = (decimal)timeSpanStockMinDateFrom.TotalDays;

            TimeSpan timeSpanStockMinDateTo = objProductsInfo.ICProductStockMinDateTo.Subtract(DateTime.Now);
            decimal compareStockMinDateTo = (decimal)timeSpanStockMinDateTo.TotalDays;

            if (inventoryStockQty >= objProductsInfo.ICProductStockMax
                && compareStockMaxDateFrom >= 0
                && compareStockMaxDateTo >= 0)
                return 1;
            if (inventoryStockQty <= objProductsInfo.ICProductStockMin
                && compareStockMinDateFrom >= 0
                && compareStockMinDateTo >= 0)
                return -1;
            else
                return 0;
        }

        /// <summary>
        /// Show treelist category
        /// </summary>
        public void ShowCategoryTree()
        {
            int departmentID = 0;
            int productGroupID = 0;
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            productGroupID = objProductGroupsController.GetObjectIDByName(Convert.ToString(fld_bedICProductGroupID.EditValue));
            departmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
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
            List<ICStocksInfo> stockList = GetStockList();
            BOSReport.RP032 report = new BOSReport.RP032(stockList);
            //report.LoadLayout(BOSCommon.Constants.Report.DevProductInventoryStockMinMaxReportPath);
            report.AddDynamiColumn();
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
                subTitle.Text = String.Format("{0} {1}", ReportLocalizedResources.DateTitle, DateTime.Now.ToString("dd/MM/yyyy"));
            report.DataSource = ReportDataSource;
            report.DataMember = BOSCommon.Constants.Report.DevProductInventoryStockMinMaxReportName;
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevProductInventoryStockMinMaxReportPath, true);
            reviewer.Show();
        }

        private void fld_bedICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ShowCategoryTree();
        }
    }
}
