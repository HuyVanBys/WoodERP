using BOSCommon;
using BOSComponent;
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
    public partial class RP075 : ReportForm
    {
        /// <summary>
        /// Gets or sets products
        /// </summary>
        public List<ICProductsInfo> SelectedProductList { get; set; }
        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
        private List<ICStocksInfo> stockListByUserGroup;
        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END

        #region Constructor
        public RP075()
        {
            InitializeComponent();
        }
        #endregion

        #region Override
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
        #endregion

        #region Events
        private void RP075_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();
            SelectedProductList = new List<ICProductsInfo>();
            fld_dgcICRP075Products.DataSource = SelectedProductList;

            ICStocksController objStocksController = new ICStocksController();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            stockListByUserGroup = objStocksController.GetStocksByUserGroupID(BOSApp.CurrentUserGroupInfo.ADUserGroupID);
            List<ICStocksInfo> stocks = new List<ICStocksInfo>();
            stocks.AddRange(stockListByUserGroup);
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END        
            stocks.Insert(0, new ICStocksInfo(0, ReportLocalizedResources.StockCardViewAll));
            stocks.Insert(1, new ICStocksInfo(-1, ReportLocalizedResources.StockCardViewAll1));
            stocks.Insert(2, new ICStocksInfo(-2, ReportLocalizedResources.StockCardViewAll2));
            fld_lkeICStockID.Properties.DataSource = stocks;
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {

            int stockID = Convert.ToInt32(fld_lkeICStockID.EditValue);
            XtraReport report = null;
            if (stockID != -2)
            {
                report = new BOSReport.RP075();
            }
            else
            {
                report = new BOSReport.RP086();
            }
            //BOSReport.RP075 report = new BOSReport.RP075();            
            bool selected = InitDataSourceReport(report);
            XtraReportHelper.SetFormatField(report);
            if (selected)
            {
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRP043Path, true);
                reviewer.Show();
            }
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (fld_chkSelectAll.Checked)
            {
                foreach (ICProductsInfo objProductsInfo in SelectedProductList)
                {
                    objProductsInfo.Selected = true;
                }
            }
            else
            {
                foreach (ICProductsInfo objProductsInfo in SelectedProductList)
                {
                    objProductsInfo.Selected = false;
                }
            }
            fld_dgcICRP075Products.RefreshDataSource();
        }
        #endregion

        #region Methods      
        /// <summary>
        /// Init data source report for displaying
        /// </summary>
        /// <param name="report">Given report</param>
        public bool InitDataSourceReport(XtraReport report)
        {
            bool selected = false;
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            int stockID = Convert.ToInt32(fld_lkeICStockID.EditValue);

            BRBranchsController objBranchsController = new BRBranchsController();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;
            XRLabel dateTime = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblFromdateTodate"];
            dateTime.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                    ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);

            XRLabel stockNameLabel = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblStockName"];
            if (stockNameLabel != null)
            {
                if (stockID > 0)
                {
                    ICStocksController objStocksController = new ICStocksController();
                    string stockName = objStocksController.GetObjectNameByID(stockID);
                    stockNameLabel.Text = stockName;
                }
            }

            List<ICProductsInfo> productList = SelectedProductList.Where(a => a.Selected).ToList();
            if (productList.Count > 0)
            {
                List<ICReceiptItemsInfo> stockCardList = GetStockCardListBySomeCriteria();
                report.DataSource = stockCardList;
                selected = true;
            }
            else
            {
                MessageBox.Show(ReportLocalizedResources.ChooseProductMessage, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                selected = false;
            }
            return selected;
        }

        /// <summary>
        /// Get stock card list by some criteria
        /// </summary>
        /// <returns>List of stock card</returns>
        private List<ICReceiptItemsInfo> GetStockCardListBySomeCriteria()
        {
            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;
            int stockID = Convert.ToInt32(fld_lkeICStockID.EditValue);

            ICStocksController objStocksController = new ICStocksController();
            List<ICStocksInfo> stocks = new List<ICStocksInfo>();
            if (stockID > 0)
            {
                ICStocksInfo stock = (ICStocksInfo)objStocksController.GetObjectByID(stockID);
                stocks.Add(stock);
            }
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            else //if (stockID == 0)
            {
                stocks.Add(new ICStocksInfo());
                stocks = stockListByUserGroup;
                stocks = stocks.Where(s => s.ICStockType == StockType.Sale.ToString() || s.ICStockType == StockType.Central.ToString()).ToList();
                stocks = stocks.Where(s => !stocks.Exists(s1 => s1.ICStockParentID == s.ICStockID)).ToList();
            }
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //NUThao [DELETE] [10/16/2014] [DB centre] [Report Permission], START
            //else if (stockID == -1)
            //{
            //    stocks = objStocksController.GetAllStocks();
            //    stocks = stocks.Where(s => s.ICStockType == StockType.Sale.ToString() || s.ICStockType == StockType.Central.ToString()).ToList();
            //    stocks = stocks.Where(s => !stocks.Exists(s1 => s1.ICStockParentID == s.ICStockID)).ToList();
            //}
            //else if (stockID == -2)
            //{
            //    stocks = objStocksController.GetAllStocks();
            //    stocks = stocks.Where(s => s.ICStockType == StockType.Sale.ToString() || s.ICStockType == StockType.Central.ToString()).ToList();
            //    stocks = stocks.Where(s => !stocks.Exists(s1 => s1.ICStockParentID == s.ICStockID)).ToList();
            //}
            //NUThao [DELETE] [10/16/2014] [DB centre] [Report Permission], END

            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            string stockNoList = string.Empty;
            if (stocks != null)
            {
                foreach (ICStocksInfo selectedStock in stocks)
                {
                    if (!string.IsNullOrEmpty(stockNoList))
                        stockNoList += ", ";
                    stockNoList += selectedStock.ICStockNo;
                }
            }
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END

            ADReportsController objReportsController = new ADReportsController();
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            List<ICReceiptItemsInfo> stockCards = new List<ICReceiptItemsInfo>();
            List<ICReceiptItemsInfo> prevStockCards = new List<ICReceiptItemsInfo>();
            List<ICInventoryStocksInfo> initInventoryStocks = new List<ICInventoryStocksInfo>();
            foreach (ICProductsInfo product in SelectedProductList)
            {
                //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                //foreach (ICStocksInfo stock in stocks)
                //{
                //    List<ICReceiptItemsInfo> temp = objReportsController.GetStockCardListBySomeCriteria(fromDate, toDate, stock.ICStockID, product.ICProductID);
                //    stockCards = stockCards.Concat(temp).ToList();
                //    temp = objReportsController.GetStockCardListBySomeCriteria(null, fromDate.AddDays(-1), stock.ICStockID, product.ICProductID);
                //    prevStockCards = prevStockCards.Concat(temp).ToList();
                //    List<ICInventoryStocksInfo> temp1 = objInventoryStocksController.GetInitInventoryStocks(stock.ICStockID, product.ICProductID);
                //    initInventoryStocks = initInventoryStocks.Concat(temp1).ToList();
                //}

                List<ICReceiptItemsInfo> temp = objReportsController.GetStockCardListByStockNoListAndSomeCriteria(fromDate, toDate, product.ICProductID, stockNoList);
                stockCards = stockCards.Concat(temp).ToList();
                temp = objReportsController.GetStockCardListByStockNoListAndSomeCriteria(null, fromDate.AddDays(-1), product.ICProductID, stockNoList);
                prevStockCards = prevStockCards.Concat(temp).ToList();
                List<ICInventoryStocksInfo> temp1 = objInventoryStocksController.GetInitInventoryStocksByStockNoList(product.ICProductID, stockNoList, null, null);
                initInventoryStocks = initInventoryStocks.Concat(temp1).ToList();
                //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            }

            List<ICReceiptItemsInfo> stockCardList = new List<ICReceiptItemsInfo>();
            foreach (ICStocksInfo stock in stocks)
            {
                foreach (ICProductsInfo objProductsInfo in SelectedProductList)
                {
                    if (objProductsInfo.Selected)
                    {
                        decimal openingBalance = 0;
                        decimal openingBalanceAmount = 0;
                        List<ICReceiptItemsInfo> temp = new List<ICReceiptItemsInfo>();
                        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                        //if (stock.ICStockID > 0)
                        if (stockID != 0)
                        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
                        {
                            openingBalance = initInventoryStocks.Where(inv => inv.FK_ICProductID == objProductsInfo.ICProductID && inv.FK_ICStockID == stock.ICStockID)
                                                                                .Sum(inv => inv.ICProductReceiptQty);
                            openingBalance += prevStockCards.Where(sc => sc.FK_ICProductID == objProductsInfo.ICProductID && sc.FK_ICStockID == stock.ICStockID)
                                                        .Sum(sc => sc.StockCardReceiptItemProductQty - sc.StockCardShipmentItemProductQty);

                            openingBalanceAmount = initInventoryStocks.Where(inv => inv.FK_ICProductID == objProductsInfo.ICProductID && inv.FK_ICStockID == stock.ICStockID)
                                                                                .Sum(inv => inv.ICProductReceiptAmount);
                            openingBalanceAmount += prevStockCards.Where(sc => sc.FK_ICProductID == objProductsInfo.ICProductID && sc.FK_ICStockID == stock.ICStockID)
                                                        .Sum(sc => sc.StockCardReceiptAmount - sc.StockCardShipmentAmount);
                            temp = stockCards.Where(s => s.FK_ICProductID == objProductsInfo.ICProductID && s.FK_ICStockID == stock.ICStockID).ToList();
                        }
                        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                        //else if (stock.ICStockID == 0)
                        else if (stockID == 0)
                        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
                        {
                            openingBalance = initInventoryStocks.Where(inv => inv.FK_ICProductID == objProductsInfo.ICProductID).Sum(inv => inv.ICProductReceiptQty);
                            openingBalance += prevStockCards.Where(sc => sc.FK_ICProductID == objProductsInfo.ICProductID)
                                                            .Sum(sc => sc.StockCardReceiptItemProductQty - sc.StockCardShipmentItemProductQty);

                            openingBalanceAmount = initInventoryStocks.Where(inv => inv.FK_ICProductID == objProductsInfo.ICProductID).Sum(inv => inv.ICProductReceiptAmount);
                            openingBalanceAmount += prevStockCards.Where(sc => sc.FK_ICProductID == objProductsInfo.ICProductID)
                                                            .Sum(sc => sc.StockCardReceiptAmount - sc.StockCardShipmentAmount);
                            temp = stockCards.Where(s => s.FK_ICProductID == objProductsInfo.ICProductID).ToList();
                        }
                        if (openingBalance > 0 && temp.Count == 0)
                        {
                            ICReceiptItemsInfo stockCard = new ICReceiptItemsInfo();
                            stockCard.ICProductNo = objProductsInfo.ICProductNo;
                            stockCard.ICProductSupplierNumber = objProductsInfo.ICProductSupplierNumber;
                            stockCard.ICProductName = objProductsInfo.ICProductName;
                            stockCard.ICProductDesc = objProductsInfo.ICProductDesc;
                            stockCard.ICMeasureUnitName = objProductsInfo.ICMeasureUnitName;
                            temp.Add(stockCard);
                        }

                        if (temp.Count > 0)
                        {
                            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
                            if (stockID == 0)
                                temp.ForEach(sc => sc.ICStockName = string.Empty);
                            else
                                //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
                                temp.ForEach(sc => sc.ICStockName = stock.ICStockName);
                            temp[0].StockCardOpeningBalance = openingBalance;
                            temp[0].StockCardOpeningBalanceAmount = openingBalanceAmount;
                            temp[temp.Count - 1].StockCardEndBalance = openingBalance + temp.Sum(sc => sc.StockCardReceiptItemProductQty) -
                                                                                        temp.Sum(sc => sc.StockCardShipmentItemProductQty);
                            temp[temp.Count - 1].StockCardEndBalanceAmount = openingBalanceAmount + temp.Sum(sc => sc.StockCardReceiptAmount) -
                                                                                        temp.Sum(sc => sc.StockCardShipmentAmount);
                            foreach (ICReceiptItemsInfo objReceiptItemsInfo in temp)
                            {
                                if (objReceiptItemsInfo.StockCardReceiptItemProductQty != 0)
                                {
                                    objReceiptItemsInfo.StockCardReceiptNo = objReceiptItemsInfo.StockCardNo;
                                }
                                if (objReceiptItemsInfo.StockCardShipmentItemProductQty != 0)
                                {
                                    objReceiptItemsInfo.StockCardShipmentNo = objReceiptItemsInfo.StockCardNo;
                                }
                                objReceiptItemsInfo.StockCardBalanceProductQty = openingBalance
                                                                      + objReceiptItemsInfo.StockCardReceiptItemProductQty
                                                                      - objReceiptItemsInfo.StockCardShipmentItemProductQty;
                                objReceiptItemsInfo.StockCardBalanceAmount = openingBalanceAmount
                                                                      + objReceiptItemsInfo.StockCardReceiptAmount
                                                                      - objReceiptItemsInfo.StockCardShipmentAmount;
                                openingBalance = objReceiptItemsInfo.StockCardBalanceProductQty;
                                openingBalanceAmount = objReceiptItemsInfo.StockCardBalanceAmount;
                                stockCardList.Add(objReceiptItemsInfo);
                            }
                        }
                    }
                }
                //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
                if (stockID == 0)
                    break;
                //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            }

            stockCardList = stockCardList.OrderBy(sc => sc.StockCardDate).ToList();
            return stockCardList;
        }
        #endregion

        private void fld_lkeICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.KeyCode == Keys.Enter)
            {
                ICProductsController objProductsController = new ICProductsController();
                int productID = Convert.ToInt32(lke.EditValue);
                ICProductsInfo objProductsInfo = SelectedProductList.Where(p => p.ICProductID == productID).FirstOrDefault();
                if (objProductsInfo == null)
                {
                    objProductsInfo = (ICProductsInfo)objProductsController.GetProductByID(productID);
                    objProductsInfo.Selected = true;
                    SelectedProductList.Add(objProductsInfo);
                }
                fld_dgcICRP075Products.RefreshDataSource();
            }
        }
    }
}
