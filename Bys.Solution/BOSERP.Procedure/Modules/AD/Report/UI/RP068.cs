using BOSERP.Utilities;
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
    public partial class RP068 : ReportForm
    {
        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
        private List<ICStocksInfo> stockListByUserGroup;
        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END

        public RP068()
        {
            InitializeComponent();
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

        private void RP068_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();

            ICStocksController objStocksController = new ICStocksController();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            stockListByUserGroup = objStocksController.GetStocksByUserGroupID(BOSApp.CurrentUserGroupInfo.ADUserGroupID);
            fld_cmbStocks.Properties.DataSource = stockListByUserGroup;
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END

        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP068 report = new BOSReport.RP068();
            //report.LoadLayout(BOSCommon.Constants.Report.DevRP068Path);
            InitDataSourceReport(report);
            XtraReportHelper.SetFormatField(report);
            guiReportPreview reviewer = new guiReportPreview(report);
            reviewer.Show();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Init data source report for displaying
        /// </summary>
        /// <param name="report">Given report</param>
        public void InitDataSourceReport(XtraReport report)
        {
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            int productID = Convert.ToInt32(fld_lkeICProductID.EditValue);
            int accountID = Convert.ToInt32(fld_lkeACAccountID.EditValue);
            int supplierID = Convert.ToInt32(fld_lkeFK_APSupplierID.EditValue);

            BRBranchsController objBranchsController = new BRBranchsController();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
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
            XRLabel dateTime = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            dateTime.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                    ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            List<ICStocksInfo> selectedStocks = GetStockList();
            string stockNoList = string.Empty;
            if (selectedStocks != null)
            {
                foreach (ICStocksInfo selectedStock in selectedStocks)
                {
                    if (!string.IsNullOrEmpty(stockNoList))
                        stockNoList += ", ";
                    stockNoList += selectedStock.ICStockNo;
                }
            }
            else
            {
                if (selectedStocks == null)
                    selectedStocks = new List<ICStocksInfo>();
                selectedStocks.Add(new ICStocksInfo());
            }

            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END

            ADReportsController objReportsController = new ADReportsController();
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //List<ICInventoryStocksInfo> inventoryStocks = objReportsController.GetIOInventoryListBySomeCriteria(dateFrom, dateTo, stockID, productID, accountID);
            List<ICInventoryStocksInfo> inventoryStocks = objReportsController.GetIOInventoryListBySomeCriteriaByStockNoList(dateFrom, dateTo, stockNoList,
                                                                                                                            productID, accountID, supplierID);
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            SortedList<int, List<ICInventoryStocksInfo>> sortedInventoryStocks = new SortedList<int, List<ICInventoryStocksInfo>>();
            foreach (ICInventoryStocksInfo inventoryStock in inventoryStocks)
            {
                if (stockNoList.Length == 0)
                {
                    inventoryStock.FK_ICStockID = 0;
                    inventoryStock.ICStockName = string.Empty;
                    inventoryStock.ICStockNo = string.Empty;
                }
                if (!sortedInventoryStocks.ContainsKey(inventoryStock.FK_ICProductID))
                {
                    sortedInventoryStocks.Add(inventoryStock.FK_ICProductID, new List<ICInventoryStocksInfo>());
                }
                sortedInventoryStocks[inventoryStock.FK_ICProductID].Add(inventoryStock);
            }

            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //List<ICInventoryStocksInfo> prevInventoryStocks = objReportsController.GetIOInventoryListBySomeCriteria(null, dateFrom.AddDays(-1), stockID, productID, accountID);
            List<ICInventoryStocksInfo> prevInventoryStocks = objReportsController.GetIOInventoryListBySomeCriteriaByStockNoList(null, dateFrom.AddDays(-1), stockNoList,
                                                                                                                                        productID, accountID, supplierID);
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            SortedList<int, List<ICInventoryStocksInfo>> sortedPrevInventoryStocks = new SortedList<int, List<ICInventoryStocksInfo>>();
            foreach (ICInventoryStocksInfo inventoryStock in prevInventoryStocks)
            {
                if (stockNoList.Length == 0)
                {
                    inventoryStock.FK_ICStockID = 0;
                    inventoryStock.ICStockName = string.Empty;
                    inventoryStock.ICStockNo = string.Empty;
                }
                if (!sortedPrevInventoryStocks.ContainsKey(inventoryStock.FK_ICProductID))
                {
                    sortedPrevInventoryStocks.Add(inventoryStock.FK_ICProductID, new List<ICInventoryStocksInfo>());
                }
                sortedPrevInventoryStocks[inventoryStock.FK_ICProductID].Add(inventoryStock);
            }
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //List<ICInventoryStocksInfo> initInventoryStocks = objInventoryStocksController.GetInitInventoryStocks(stockID, productID);
            List<ICInventoryStocksInfo> initInventoryStocks = objInventoryStocksController.GetInitInventoryStocksByStockNoList(productID, stockNoList, accountID, supplierID);
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            SortedList<int, List<ICInventoryStocksInfo>> sortedInitInventoryStocks = new SortedList<int, List<ICInventoryStocksInfo>>();
            foreach (ICInventoryStocksInfo inventoryStock in initInventoryStocks)
            {
                if (stockNoList.Length == 0)
                {
                    inventoryStock.FK_ICStockID = 0;
                    inventoryStock.ICStockName = string.Empty;
                    inventoryStock.ICStockNo = string.Empty;
                }
                if (!sortedInitInventoryStocks.ContainsKey(inventoryStock.FK_ICProductID))
                {
                    sortedInitInventoryStocks.Add(inventoryStock.FK_ICProductID, new List<ICInventoryStocksInfo>());
                }
                sortedInitInventoryStocks[inventoryStock.FK_ICProductID].Add(inventoryStock);
            }

            List<ICInventoryStocksInfo> inventoryStockList = new List<ICInventoryStocksInfo>();
            List<ICProductsInfo> productList = GetProductList();

            //foreach (ICStocksInfo stock in selectedStocks)
            //{
            //    foreach (ICProductsInfo objProductsInfo in productList)
            //    {
            //        ICInventoryStocksInfo objInventoryStocksInfo = null;
            //        if (sortedInventoryStocks.ContainsKey(objProductsInfo.ICProductID))
            //        {
            //            objInventoryStocksInfo = (ICInventoryStocksInfo)sortedInventoryStocks[objProductsInfo.ICProductID].Where(i => i.FK_ICStockID == stock.ICStockID).FirstOrDefault();
            //        }

            //        decimal initQty = 0;
            //        decimal initCost = 0;
            //        if (sortedInitInventoryStocks.ContainsKey(objProductsInfo.ICProductID))
            //        {
            //            initQty = sortedInitInventoryStocks[objProductsInfo.ICProductID].Where(inv => inv.FK_ICStockID == stock.ICStockID).Sum(inv => inv.ICProductReceiptQty);
            //            initCost = sortedInitInventoryStocks[objProductsInfo.ICProductID].Where(inv => inv.FK_ICStockID == stock.ICStockID).Sum(inv => inv.ICProductReceiptAmount);
            //        }

            //        decimal previousAccumulateQty = initQty;
            //        if (sortedPrevInventoryStocks.ContainsKey(objProductsInfo.ICProductID))
            //        {
            //            previousAccumulateQty += sortedPrevInventoryStocks[objProductsInfo.ICProductID].Where(inv => inv.FK_ICStockID == stock.ICStockID)
            //                                                                            .Sum(inv => inv.ICProductReceiptQty - inv.ICProductShipmentQty);
            //        }
            //        if (previousAccumulateQty > 0 && objInventoryStocksInfo == null)
            //        {
            //            objInventoryStocksInfo = new ICInventoryStocksInfo();
            //            objInventoryStocksInfo.ICStockNo = stock.ICStockNo;
            //            objInventoryStocksInfo.ICStockName = stock.ICStockName;
            //            objInventoryStocksInfo.ICProductSupplierNumber = objProductsInfo.ICProductSupplierNumber;
            //            objInventoryStocksInfo.ICProductDesc = objProductsInfo.ICProductDesc;
            //            objInventoryStocksInfo.ICMeasureUnitName = objProductsInfo.ICMeasureUnitName;
            //        }

            //        if (objInventoryStocksInfo != null)
            //        {
            //            objInventoryStocksInfo.ICProductPreviouslyAccumulateQty = previousAccumulateQty;
            //            decimal previousAccumulateAmount = initCost;
            //            if (sortedPrevInventoryStocks.ContainsKey(objProductsInfo.ICProductID))
            //            {
            //                previousAccumulateAmount += sortedPrevInventoryStocks[objProductsInfo.ICProductID].Where(inv => inv.FK_ICStockID == stock.ICStockID)
            //                                                                        .Sum(inv => inv.ICProductReceiptAmount - inv.ICProductShipmentAmount);
            //            }
            //            objInventoryStocksInfo.ICProductPreviouslyAccumulateAmount = previousAccumulateAmount;

            //            decimal productNextAccumulateQty = previousAccumulateQty + objInventoryStocksInfo.ICProductReceiptQty - objInventoryStocksInfo.ICProductShipmentQty;
            //            objInventoryStocksInfo.ICProductNextAccumulateQty = productNextAccumulateQty;
            //            decimal nextAccumulateAmount = objInventoryStocksInfo.ICProductPreviouslyAccumulateAmount + objInventoryStocksInfo.ICProductReceiptAmount - objInventoryStocksInfo.ICProductShipmentAmount;
            //            objInventoryStocksInfo.ICProductNextAccumulateAmount = nextAccumulateAmount;

            //            if (fld_cmbViewType.SelectedIndex == 0)
            //            {
            //                inventoryStockList.Add(objInventoryStocksInfo);
            //            }
            //            else if (fld_cmbViewType.SelectedIndex == 1)
            //            {
            //                if (productNextAccumulateQty != 0)
            //                {
            //                    inventoryStockList.Add(objInventoryStocksInfo);
            //                }
            //            }
            //        }
            //    }
            //}

            foreach (ICProductsInfo objProductsInfo in productList)
            {
                ICInventoryStocksInfo objInventoryStocksInfo = null;
                if (sortedInventoryStocks.ContainsKey(objProductsInfo.ICProductID))
                {
                    objInventoryStocksInfo = (ICInventoryStocksInfo)sortedInventoryStocks[objProductsInfo.ICProductID].FirstOrDefault();
                    objInventoryStocksInfo.ICProductReceiptQty = sortedInventoryStocks[objProductsInfo.ICProductID].Sum(item => item.ICProductReceiptQty);
                    objInventoryStocksInfo.ICProductShipmentQty = sortedInventoryStocks[objProductsInfo.ICProductID].Sum(item => item.ICProductShipmentQty);
                    objInventoryStocksInfo.ICProductReceiptAmount = sortedInventoryStocks[objProductsInfo.ICProductID].Sum(item => item.ICProductReceiptAmount);
                    objInventoryStocksInfo.ICProductShipmentAmount = sortedInventoryStocks[objProductsInfo.ICProductID].Sum(item => item.ICProductShipmentAmount);

                }

                decimal initQty = 0;
                decimal initCost = 0;
                if (sortedInitInventoryStocks.ContainsKey(objProductsInfo.ICProductID))
                {
                    initQty = sortedInitInventoryStocks[objProductsInfo.ICProductID].Sum(inv => inv.ICProductReceiptQty);
                    initCost = sortedInitInventoryStocks[objProductsInfo.ICProductID].Sum(inv => inv.ICProductReceiptAmount);
                }

                decimal previousAccumulateQty = initQty;
                if (sortedPrevInventoryStocks.ContainsKey(objProductsInfo.ICProductID))
                {
                    previousAccumulateQty += sortedPrevInventoryStocks[objProductsInfo.ICProductID]
                                                                                    .Sum(inv => inv.ICProductReceiptQty - inv.ICProductShipmentQty);
                }
                if (previousAccumulateQty > 0 && objInventoryStocksInfo == null)
                {
                    objInventoryStocksInfo = new ICInventoryStocksInfo();
                    //objInventoryStocksInfo.ICStockNo = stock.ICStockNo;
                    //objInventoryStocksInfo.ICStockName = stock.ICStockName;
                    objInventoryStocksInfo.ICProductSupplierNumber = objProductsInfo.ICProductSupplierNumber;
                    objInventoryStocksInfo.ICProductDesc = objProductsInfo.ICProductDesc;
                    objInventoryStocksInfo.ICMeasureUnitName = objProductsInfo.ICMeasureUnitName;
                }

                if (objInventoryStocksInfo != null)
                {
                    objInventoryStocksInfo.ICProductPreviouslyAccumulateQty = previousAccumulateQty;
                    decimal previousAccumulateAmount = initCost;
                    if (sortedPrevInventoryStocks.ContainsKey(objProductsInfo.ICProductID))
                    {
                        previousAccumulateAmount += sortedPrevInventoryStocks[objProductsInfo.ICProductID]
                                                                                .Sum(inv => inv.ICProductReceiptAmount - inv.ICProductShipmentAmount);
                    }
                    objInventoryStocksInfo.ICProductPreviouslyAccumulateAmount = previousAccumulateAmount;

                    decimal productNextAccumulateQty = previousAccumulateQty + objInventoryStocksInfo.ICProductReceiptQty - objInventoryStocksInfo.ICProductShipmentQty;
                    objInventoryStocksInfo.ICProductNextAccumulateQty = productNextAccumulateQty;
                    decimal nextAccumulateAmount = objInventoryStocksInfo.ICProductPreviouslyAccumulateAmount + objInventoryStocksInfo.ICProductReceiptAmount - objInventoryStocksInfo.ICProductShipmentAmount;
                    objInventoryStocksInfo.ICProductNextAccumulateAmount = nextAccumulateAmount;

                    if (fld_cmbViewType.SelectedIndex == 0)
                    {
                        objInventoryStocksInfo.ICProductNo = objProductsInfo.ICProductNo;
                        inventoryStockList.Add(objInventoryStocksInfo);
                    }
                    else if (fld_cmbViewType.SelectedIndex == 1)
                    {
                        if (productNextAccumulateQty != 0)
                        {
                            objInventoryStocksInfo.ICProductNo = objProductsInfo.ICProductNo;
                            inventoryStockList.Add(objInventoryStocksInfo);
                        }
                    }
                }
            }
            report.DataSource = inventoryStockList;
        }

        /// <summary>
        /// Get product list for the report
        /// </summary>
        /// <returns>Product list</returns>
        private List<ICProductsInfo> GetProductList()
        {
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> products = new List<ICProductsInfo>();
            int selectedProductID = Convert.ToInt32(fld_lkeICProductID.EditValue);
            if (selectedProductID == 0)
            {
                int departmentID = Convert.ToInt32(fld_lkeICDepartmentID.EditValue);
                int productGroupID = Convert.ToInt32(fld_lkeICProductGroupID.EditValue);
                int accountID = Convert.ToInt32(fld_lkeACAccountID.EditValue);
                int supplierID = Convert.ToInt32(fld_lkeFK_APSupplierID.EditValue);
                //NUThao [EDIT] [08/04/2014] [DB centre] [CSCompany issue], START
                //products = objProductsController.GetProductList(departmentID, productGroupID, null, accountID);
                int companyID = BOSApp.CurrentCompanyInfo.CSCompanyID;
                products = objProductsController.GetProductList(companyID, departmentID, productGroupID, supplierID, accountID);

                //NUThao [EDIT] [08/04/2014] [DB centre] [CSCompany issue], END
            }
            else
            {
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetProductByID(selectedProductID);
                if (objProductsInfo != null)
                {
                    products.Add(objProductsInfo);
                }
            }
            return products;
        }

        /// <summary>
        /// Get stock list
        /// </summary>        
        /// <returns>List of stocks</returns>
        public List<ICStocksInfo> GetStockList()
        {
            List<ICStocksInfo> stockList = new List<ICStocksInfo>();
            string[] stockIDs = fld_cmbStocks.EditValue.ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (stockIDs.Length > 0)
            {
                for (int i = 0; i < stockIDs.Length; i++)
                {
                    int stockID = Convert.ToInt32(stockIDs[i]);
                    ICStocksInfo stock = stockListByUserGroup.FirstOrDefault(item => item.ICStockID == stockID);
                    if (stock != null)
                        stockList.Add(stock);
                }
            }

            if (stockList.Count == 0)
            {
                DataSet ds = new DataSet();
                int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
                if (branchID > 0)
                {
                    stockList = stockListByUserGroup.Where(item => item.FK_BRBranchID == branchID).ToList();
                }
                else
                {
                    stockList = stockListByUserGroup;
                }
            }

            if (stockList != null)
            {
                BRBranchsController objBranchsController = new BRBranchsController();
                List<BRBranchsInfo> branches = objBranchsController.GetAllBranches();
                foreach (ICStocksInfo stock in stockList)
                {
                    BRBranchsInfo branch = (BRBranchsInfo)branches.Where(b => b.BRBranchID == stock.FK_BRBranchID).FirstOrDefault();
                    if (branch != null)
                    {
                        stock.BRBranchParentID = branch.BRBranchParentID;
                    }
                }
            }
            return stockList;
        }
    }
}
