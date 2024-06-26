using BOSCommon;
using BOSCommon.Constants;
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
    public partial class RP013 : ReportForm
    {
        #region Variables

        private string ProductGroupReference = string.Empty;

        private string ProductAttributeKeyValue = string.Empty;

        private int LocationID = 0;

        private DataTable ReportDataSource;

        private List<ICInventoryStocksInfo> InventoryStockList;

        private bool IsShowDetail = false;

        private List<ICStocksInfo> SelectedStocks = new List<ICStocksInfo>();
        #endregion

        public RP013()
        {
            InitializeComponent();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void RP013_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_lblSubTitle.Text = string.Empty;
            fld_lblSubTitleDate.Text = string.Empty;
            fld_cmbInventoryType.SelectedIndex = 0;
            fld_btnPrint.Enabled = false;
            fld_dteSearchFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();

            //Set default branch and stock
            int branchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            fld_lkeBRBranchID.EditValue = branchID;

            ICStocksController objStocksController = new ICStocksController();
            List<ICStocksInfo> stocks = objStocksController.GetStockPermissionByUserGroupID(BOSApp.CurrentUserGroupInfo.ADUserGroupID);
            fld_cmbStocks.Properties.DataSource = stocks;
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            fld_btnViewDetail.Text = ReportLocalizedResources.CaptionNext;
            fld_dgcICRP013Products.Visible = true;
            fld_pteProductProductPicture.Visible = true;
            InitializeDataSourceInventoryProduct();
        }

        public void InitializeDataSourceInventoryProduct()
        {
            BOSProgressBar.Start(ReportLocalizedResources.LoadingData);
            DataTable resultTable = null;
            List<ICStocksInfo> stockList = GetStockList();
            ICStocksController objStocksController = new ICStocksController();
            if (fld_cmbInventoryType.SelectedIndex != 1)
            {
                resultTable = GetInventoryStock(stockList);
            }
            else
            {
                List<ICStocksInfo> saleOrderList = objStocksController.GetStockPermissionByUserGroupID(BOSApp.CurrentUserGroupInfo.ADUserGroupID, StockType.SaleOrder.ToString());
                if (saleOrderList.Count() != 0)
                    stockList = stockList.Union(saleOrderList).ToList();
                resultTable = GetInventorySaleOrderStock(stockList);
            }

            fld_dgcICRP013Products.DataSource = resultTable;
            ReportDataSource = resultTable;
            fld_dgcICRP013Products.AddInventoryColumns(stockList);
            fld_dgcICRP013Products.RefreshDataSource();
            GridView gridView = (GridView)fld_dgcICRP013Products.MainView;
            gridView.ExpandAllGroups();
            if (resultTable == null || resultTable.Rows.Count == 0)
            {
                fld_btnPrint.Enabled = false;
            }
            else
            {
                fld_btnPrint.Enabled = true;
            }
            BOSProgressBar.Close();
        }

        public DataTable GetInventoryStock(List<ICStocksInfo> stockList)
        {
            ADReportsController objReportsController = new ADReportsController();
            ICProductsController objProductsController = new ICProductsController();
            ICStocksController objStocksController = new ICStocksController();
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int locationID = LocationID;
            int departmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            int supplierID = Convert.ToInt32(fld_lkeFK_APSupplierID.EditValue);
            int? productID = fld_lke_ICProductNo.EditValue as int?;
            string productAttributeKey = ProductAttributeKeyValue;
            DateTime fromDate = Convert.ToDateTime(fld_dteSearchFromDate.EditValue);
            DateTime toDate = Convert.ToDateTime(fld_dteSearchToDate.EditValue);
            bool hasComponent = fld_chkHasComponent.Checked;
            int cSCompanyID = BOSApp.CurrentCompanyInfo.CSCompanyID;
            if (SelectedStocks.Count > 0)
            {
                fld_lblSubTitle.Text = string.Join(", ", SelectedStocks.Select(o => o.ICStockName).ToArray());
            }
            else
            {
                fld_lblSubTitle.Text = fld_lkeBRBranchID.Text.ToUpper();
            }
            fld_lblSubTitleDate.Text = String.Format("{0} {1}", ReportLocalizedResources.DateTitle, DateTime.Now.ToString("dd/MM/yyyy"));

            DataTable resultTable = null;
            DataColumn columnTable = null;
            string stockRef = string.Join(",", stockList.Select(o => o.ICStockID.ToString()).ToArray());
            DataSet ds = objReportsController.GetDataForRP013(cSCompanyID,
                                                              stockRef,
                                                              departmentID,
                                                              ProductGroupReference,
                                                              supplierID,
                                                              productID,
                                                              productAttributeKey,
                                                              locationID,
                                                              branchID,
                                                              toDate);


            resultTable = ds.Tables[0];
            productID = 0;
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

        public DataTable GetInventorySaleOrderStock(List<ICStocksInfo> stockList)
        {
            ADReportsController objReportsController = new ADReportsController();
            ICProductsController objProductsController = new ICProductsController();
            ICStocksController objStocksController = new ICStocksController();
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int locationID = LocationID;
            int departmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            int supplierID = Convert.ToInt32(fld_lkeFK_APSupplierID.EditValue);
            int? productID = fld_lke_ICProductNo.EditValue as int?;
            string productAttributeKey = ProductAttributeKeyValue;
            DateTime fromDate = Convert.ToDateTime(fld_dteSearchFromDate.EditValue);
            DateTime toDate = Convert.ToDateTime(fld_dteSearchToDate.EditValue);
            bool hasComponent = fld_chkHasComponent.Checked;
            int cSCompanyID = BOSApp.CurrentCompanyInfo.CSCompanyID;
            if (SelectedStocks.Count > 0)
            {
                fld_lblSubTitle.Text = string.Join(", ", SelectedStocks.Select(o => o.ICStockName).ToArray());
            }
            else
            {
                fld_lblSubTitle.Text = fld_lkeBRBranchID.Text.ToUpper();
            }
            fld_lblSubTitleDate.Text = String.Format("{0} {1}", ReportLocalizedResources.DateTitle, DateTime.Now.ToString("dd/MM/yyyy"));

            DataTable resultTable = null;
            DataColumn columnTable = null;
            string stockRef = string.Join(",", stockList.Select(o => o.ICStockID.ToString()).ToArray());
            DataSet ds = objReportsController.GetDataForRP013SaleOrder(cSCompanyID,
                                                                      stockRef,
                                                                      departmentID,
                                                                      ProductGroupReference,
                                                                      supplierID,
                                                                      productID,
                                                                      productAttributeKey,
                                                                      locationID,
                                                                      branchID,
                                                                      fromDate,
                                                                      toDate);


            resultTable = ds.Tables[0];
            productID = 0;
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

        public void ShowCategoryTree()
        {
            int departmentID = 0;
            departmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            int productGroupID = objProductGroupsController.GetObjectIDByName(Convert.ToString(fld_bedICProductGroupID.EditValue));
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(productGroupID);
            guiProductGroupTree.AllowMultipleSelect = true;
            guiProductGroupTree.Module = this.Module;
            guiProductGroupTree.ICDepartmentID = departmentID;

            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {
                if (guiProductGroupTree.SelectedObjects != null)
                {
                    fld_bedICProductGroupID.Text = guiProductGroupTree.GetSelectedProductGroupName();
                    ProductGroupReference = guiProductGroupTree.GetSelectedProductGroupReferenceID();
                }
                else
                {
                    fld_bedICProductGroupID.Text = String.Empty;
                    ProductGroupReference = string.Empty;
                }
            }
        }

        public void ShowEditAttributeForm(int departmentID)
        {
            guiEditAttribute guiEditAttribute = new guiEditAttribute(departmentID);
            guiEditAttribute.Module = Module;
            if (guiEditAttribute.ShowDialog() == DialogResult.OK)
            {
                fld_bedProductAttributeKey.Text = guiEditAttribute.ICProductAttribute;
                ProductAttributeKeyValue = guiEditAttribute.ICProductAttributeKey;
            }
        }

        public List<ICStocksInfo> GetStockList()
        {
            ICStocksController objStocksController = new ICStocksController();
            List<ICStocksInfo> stockList = new List<ICStocksInfo>();
            string[] stockIDs = fld_cmbStocks.EditValue.ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            SelectedStocks.Clear();
            if (stockIDs.Length > 0)
            {
                for (int i = 0; i < stockIDs.Length; i++)
                {
                    int stockID = Convert.ToInt32(stockIDs[i]);
                    ICStocksInfo stock = (ICStocksInfo)objStocksController.GetObjectByID(stockID);
                    if (stock != null)
                    {
                        SelectedStocks.Add(stock);
                    }
                }
            }

            if (SelectedStocks.Count > 0)
            {
                stockList = SelectedStocks;
            }
            else
            {
                stockList = objStocksController.GetStockPermissionByUserGroupID(BOSApp.CurrentUserGroupInfo.ADUserGroupID);
            }
            return stockList;
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            List<ICStocksInfo> stockList = GetStockList();
            int flag = 0;
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            ICProductsController objProductsController = new ICProductsController();
            ICProductGroupsInfo objProductGroupsInfo = new ICProductGroupsInfo();
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            List<string> productGroupRef = ProductGroupReference.Split(',').ToList();
            int productGroupID = 0;
            string value = productGroupRef.FirstOrDefault();
            value = string.IsNullOrEmpty(value) ? "0" : value;
            productGroupID = Convert.ToInt32(value);
            int productID = Convert.ToInt32(fld_lke_ICProductNo.EditValue);
            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            objProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(productGroupID);
            if (objProductsInfo != null)
            {
                if (objProductsInfo.ICProductType == ProductType.Roundwood.ToString())
                {
                    flag = 1;
                }
                else if (objProductsInfo.ICProductType == ProductType.Lumber.ToString())
                {
                    flag = 2;
                }
                else
                {
                    flag = 0;
                }
            }
            if (objProductGroupsInfo != null)
            {
                if (objProductGroupsInfo.ICProductGroupName == ProductGroupNameHardCode.GoTron)
                {
                    flag = 1;
                }
                else if (objProductGroupsInfo.ICProductGroupName == ProductGroupNameHardCode.GoPhach)
                {
                    flag = 2;
                }
                else
                {
                    flag = 0;
                }
            }
            BOSReport.RP013 report = new BOSReport.RP013(stockList);
            report.AddDynamicColumn();
            SetDefaultCurrentBranchAndTitle(report, flag, false);
            report.DataSource = ReportDataSource;
            report.DataMember = BOSCommon.Constants.Report.DevProductsReportName;
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevProductsReportPath, true);
            reviewer.Show();
        }

        private void SetDefaultCurrentBranchAndTitle(XtraReport report, int flag, bool IsDetails)
        {
            //Set default current branch
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
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            DateTime fromDate = Convert.ToDateTime(fld_dteSearchFromDate.EditValue);
            DateTime toDate = Convert.ToDateTime(fld_dteSearchToDate.EditValue);
            //Set title report
            XRLabel title = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblTitle"];
            if (title != null)
            {
                title.Text += string.Format(" {0}", fld_lblSubTitle.Text);
            }
            XRLabel subTitle = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblSubTitle"];
            if (subTitle != null)
            {
                subTitle.Text = String.Format(" {0} {1}", ReportLocalizedResources.DateTitle, DateTime.Now.ToString("dd/MM/yyyy"));
            }
            if (IsDetails)
            {
                if (flag == 0)
                {
                    (report as BOSReport.RPInventoryProductSerie).ProductSerieNo = "Mã lô";
                    (report as BOSReport.RPInventoryProductSerie).ProductQty = "Số lượng";
                }
                if (flag == 1)
                {
                    (report as BOSReport.RPInventoryProductSerie).ProductSerieNo = "Mã đầu lóng";
                    (report as BOSReport.RPInventoryProductSerie).ProductQty = "Khối lượng";
                }
                if (flag == 2)
                {
                    (report as BOSReport.RPInventoryProductSerie).ProductSerieNo = "Mã kiện";
                    (report as BOSReport.RPInventoryProductSerie).ProductQty = "Khối lượng";
                }
                //(report as BOSReport.RPInventoryProductSerie).FaxNumber = objBranchsInfo.BRBranchContactFax;
            }
        }

        public void ShowProductSeries(ICProductsInfo objProductsInfo)
        {
            guiReportShowProductSerie guiReportShowProductSeries = new guiReportShowProductSerie(objProductsInfo);
            guiReportShowProductSeries.Module = Module;
            guiReportShowProductSeries.ShowDialog();
        }

        private void fld_bedProductAttributeKey_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int productID = Convert.ToInt32(fld_lke_ICProductNo.EditValue);
            int departmentID = 0;
            if (productID != 0)
            {
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
                if (objProductsInfo != null)
                {
                    departmentID = objProductsInfo.FK_ICDepartmentID;

                }
            }
            if (departmentID == 0)
            {
                departmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            }

            if (departmentID > 0)
            {
                ShowEditAttributeForm(departmentID);
            }
            else
            {
                MessageBox.Show(ReportLocalizedResources.ProductAttributeKeyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void fld_bedICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ShowCategoryTree();
        }

        private void fld_cmbInventoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            fld_dteSearchFromDate.Properties.ReadOnly = false;
            fld_dteSearchFromDate.Enabled = true;
            if (fld_cmbInventoryType.SelectedIndex != 1)
            {
                fld_dteSearchFromDate.Properties.ReadOnly = true;
                fld_dteSearchFromDate.Enabled = false;
            }
        }

        private void fld_bedGELocationName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            guiChooseLocation locationForm = new guiChooseLocation(LocationID);
            locationForm.Module = Module;
            if (locationForm.ShowDialog() == DialogResult.OK)
            {
                GELocationsController objLocationsController = new GELocationsController();
                GELocationsInfo objLocationsInfo = (GELocationsInfo)locationForm.LocationTreeList.GetSelectedObject();
                if (objLocationsInfo != null && objLocationsInfo.Selected)
                {
                    LocationID = objLocationsInfo.GELocationID;
                    fld_bedGELocationName.EditValue = objLocationsController.GetFullLocationNameByID(objLocationsInfo.GELocationID);
                }
                else
                {
                    LocationID = 0;
                    fld_bedGELocationName.EditValue = string.Empty;
                }
            }
        }

        private void fld_btnViewDetail_Click(object sender, EventArgs e)
        {
            //IsShowDetail = !IsShowDetail;
            //if (IsShowDetail)
            //{
            //    fld_btnViewDetail.Text = ReportLocalizedResources.Captionprev;
            //    fld_dgcICRP013Products.Visible = false;
            //    fld_dgcICRP013InventoryStocks.Visible = true;
            //    fld_pteProductProductPicture.Visible = false;
            //    fld_pteInventoryStockProductPicture.Visible = true;
            //    InitializeDataSourceInventoryProductDetail();
            //}
            //else
            //{
            //    fld_btnViewDetail.Text = ReportLocalizedResources.CaptionNext;
            //    fld_dgcICRP013Products.Visible = true;
            //    fld_dgcICRP013InventoryStocks.Visible = false;
            //    fld_pteProductProductPicture.Visible = true;
            //    fld_pteInventoryStockProductPicture.Visible = false;
            //    InitializeDataSourceInventoryProduct();
            //}
        }

        private void fld_btnExportExcel_Click(object sender, EventArgs e)
        {
            GridView gridView = null;
            gridView = (GridView)fld_dgcICRP013Products.MainView;
            if (gridView != null)
            {
                ExportToXls(gridView);
            }
        }

        public void InvalidateItemProductPicture(ICProductsInfo objProductsInfo)
        {
            ((ReportModule)Module).InvalidateItemProductPicture(objProductsInfo);
            fld_pteProductProductPicture.Image = objProductsInfo.ICProductPrimaryImage;
        }
    }
}