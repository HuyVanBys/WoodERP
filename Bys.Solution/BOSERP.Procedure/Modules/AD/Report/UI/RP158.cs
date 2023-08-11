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
    public partial class RP158 : ReportForm
    {

        private List<ICStocksInfo> stockListByUserGroup;


        public RP158()
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

        private void RP109_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();

            ICStocksController objStocksController = new ICStocksController();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            stockListByUserGroup = objStocksController.GetStocksByUserGroupID(BOSApp.CurrentUserGroupInfo.ADUserGroupID);
            fld_cmbStocks.Properties.DataSource = stockListByUserGroup;
            ////NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP158 report = new BOSReport.RP158();
            //report.LoadLayout(BOSCommon.Constants.Report.DevRP109Path);
            InitDataSourceReport(report);
            XtraReportHelper.SetFormatField(report);
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRP052Path, true);
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
            //int stockID = Convert.ToInt32(fld_lkeICStockID.EditValue);
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
            ADReportsController objReportsController = new ADReportsController();
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            List<ICStocksInfo> selectedStocks = GetStockList();
            string stockNoList = string.Empty;
            if (selectedStocks != null && selectedStocks.Count != 0)
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

            List<ICInventoryStocksInfo> inventoryStockList = new List<ICInventoryStocksInfo>();
            if (productID > 0)
            {
                List<string> keys = new List<string>();
                //List<ICInventoryStocksInfo> inventoryStocks = objReportsController.GetIOInventoryListBySomeCriteria(dateFrom, dateTo, stockID, productID, accountID);
                List<ICInventoryStocksInfo> inventoryStocks = objReportsController.GetIOInventoryListByListOfStockNosGroupByModel(dateFrom, dateTo, stockNoList,
                                                                                                                                productID, accountID, supplierID);

                foreach (ICInventoryStocksInfo item in inventoryStocks)
                {
                    item.ReportKey = item.FK_ICProductID + "_" + item.ICModelName + "_" + item.ICModelDetailName; //item.ItemDesc;
                    if (!keys.Contains(item.ReportKey))
                    {
                        keys.Add(item.ReportKey);
                    }
                }
                SortedList<string, List<ICInventoryStocksInfo>> sortedInventoryStocks = new SortedList<string, List<ICInventoryStocksInfo>>();
                foreach (ICInventoryStocksInfo inventoryStock in inventoryStocks)
                {
                    if (stockNoList.Length == 0)
                    {
                        inventoryStock.FK_ICStockID = 0;
                        inventoryStock.ICStockName = string.Empty;
                        inventoryStock.ICStockNo = string.Empty;
                    }
                    if (!sortedInventoryStocks.ContainsKey(inventoryStock.ReportKey))
                    {
                        sortedInventoryStocks.Add(inventoryStock.ReportKey, new List<ICInventoryStocksInfo>());
                    }
                    sortedInventoryStocks[inventoryStock.ReportKey].Add(inventoryStock);
                }

                //List<ICInventoryStocksInfo> prevInventoryStocks = objReportsController.GetIOInventoryListBySomeCriteria(null, dateFrom.AddDays(-1), stockID, productID, accountID);
                List<ICInventoryStocksInfo> prevInventoryStocks = objReportsController.GetIOInventoryListByListOfStockNosGroupByModel(null, dateFrom.AddDays(-1), stockNoList,
                                                                                                                                    productID, accountID, supplierID);

                foreach (ICInventoryStocksInfo item in prevInventoryStocks)
                {
                    item.ReportKey = item.FK_ICProductID + "_" + item.ICModelName + "_" + item.ICModelDetailName; //item.ItemDesc;
                    if (!keys.Contains(item.ReportKey))
                    {
                        keys.Add(item.ReportKey);
                    }
                }
                SortedList<string, List<ICInventoryStocksInfo>> sortedPrevInventoryStocks = new SortedList<string, List<ICInventoryStocksInfo>>();
                foreach (ICInventoryStocksInfo inventoryStock in prevInventoryStocks)
                {
                    if (stockNoList.Length == 0)
                    {
                        inventoryStock.FK_ICStockID = 0;
                        inventoryStock.ICStockName = string.Empty;
                        inventoryStock.ICStockNo = string.Empty;
                    }
                    if (!sortedPrevInventoryStocks.ContainsKey(inventoryStock.ReportKey))
                    {
                        sortedPrevInventoryStocks.Add(inventoryStock.ReportKey, new List<ICInventoryStocksInfo>());
                    }
                    sortedPrevInventoryStocks[inventoryStock.ReportKey].Add(inventoryStock);
                }

                //List<ICInventoryStocksInfo> initInventoryStocks = objInventoryStocksController.GetInitInventoryStocks(stockID, productID);
                List<ICInventoryStocksInfo> initInventoryStocks = objInventoryStocksController.GetInitInventoryStocksByListOfStockNosGroupByModel(productID, stockNoList, accountID, supplierID);
                foreach (ICInventoryStocksInfo item in initInventoryStocks)
                {
                    item.ReportKey = item.FK_ICProductID + "_" + item.ICModelName + "_" + item.ICModelDetailName;//item.ItemDesc;
                    if (!keys.Contains(item.ReportKey))
                    {
                        keys.Add(item.ReportKey);
                    }
                }
                SortedList<string, List<ICInventoryStocksInfo>> sortedInitInventoryStocks = new SortedList<string, List<ICInventoryStocksInfo>>();
                foreach (ICInventoryStocksInfo inventoryStock in initInventoryStocks)
                {
                    if (stockNoList.Length == 0)
                    {
                        inventoryStock.FK_ICStockID = 0;
                        inventoryStock.ICStockName = string.Empty;
                        inventoryStock.ICStockNo = string.Empty;
                    }
                    if (!sortedInitInventoryStocks.ContainsKey(inventoryStock.ReportKey))
                    {
                        sortedInitInventoryStocks.Add(inventoryStock.ReportKey, new List<ICInventoryStocksInfo>());
                    }
                    sortedInitInventoryStocks[inventoryStock.ReportKey].Add(inventoryStock);
                }


                ICProductsController objProductsController = new ICProductsController();
                //List<ICProductsInfo> productList = GetProductList();

                //foreach (ICProductsInfo objProductsInfo in productList)
                //{
                foreach (string key in keys)
                {
                    ICInventoryStocksInfo objInventoryStocksInfo = null;
                    string[] keyArrays = key.Split('_');
                    int objProductID = 0;
                    string desc = string.Empty;
                    for (int i = 0; i < keyArrays.Length; i++)
                    {
                        if (i == 0)
                        {
                            int.TryParse(keyArrays[i], out objProductID);
                        }
                        else
                        {
                            desc += keyArrays[i];
                        }
                    }



                    ICProductsInfo objProductsInfo = new ICProductsInfo();
                    if (objProductID > 0)
                    {
                        objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductID);
                    }
                    if (sortedInventoryStocks.ContainsKey(key))
                    {
                        objInventoryStocksInfo = (ICInventoryStocksInfo)sortedInventoryStocks[key].FirstOrDefault();
                        objInventoryStocksInfo.ICProductReceiptQty = sortedInventoryStocks[key].Sum(item => item.ICProductReceiptQty);
                        objInventoryStocksInfo.ICProductShipmentQty = sortedInventoryStocks[key].Sum(item => item.ICProductShipmentQty);
                        objInventoryStocksInfo.ICProductReceiptAmount = sortedInventoryStocks[key].Sum(item => item.ICProductReceiptAmount);
                        objInventoryStocksInfo.ICProductShipmentAmount = sortedInventoryStocks[key].Sum(item => item.ICProductShipmentAmount);
                        objInventoryStocksInfo.ICProductDesc = desc;
                        objInventoryStocksInfo.ICProductName = objProductsInfo.ICProductNo + " - " + objProductsInfo.ICProductName;
                        if (!String.IsNullOrEmpty(objInventoryStocksInfo.ICModelName))
                        {

                            objInventoryStocksInfo.ICProductName = objInventoryStocksInfo.ICProductName + " - " + objInventoryStocksInfo.ICModelName;
                        }
                        if (!String.IsNullOrEmpty(objInventoryStocksInfo.ICModelDetailName))
                        {
                            objInventoryStocksInfo.ICProductName = objInventoryStocksInfo.ICProductName + " - " + objInventoryStocksInfo.ICModelDetailName;
                        }
                    }

                    decimal initQty = 0;
                    decimal initCost = 0;
                    if (sortedInitInventoryStocks.ContainsKey(key))
                    {
                        initQty = sortedInitInventoryStocks[key].Sum(inv => inv.ICProductReceiptQty);
                        initCost = sortedInitInventoryStocks[key].Sum(inv => inv.ICProductReceiptAmount);
                    }

                    decimal previousAccumulateQty = initQty;
                    if (sortedPrevInventoryStocks.ContainsKey(key))
                    {
                        previousAccumulateQty += sortedPrevInventoryStocks[key].Sum(inv => inv.ICProductReceiptQty - inv.ICProductShipmentQty);
                    }
                    if (previousAccumulateQty > 0 && objInventoryStocksInfo == null)
                    {
                        objInventoryStocksInfo = new ICInventoryStocksInfo();
                        objInventoryStocksInfo.ReportKey = key;
                        objInventoryStocksInfo.ICProductID = objProductsInfo.ICProductID;
                        //objInventoryStocksInfo.ICStockNo = s.ICStockNo;
                        //objInventoryStocksInfo.ICStockName = s.ICStockName;
                        objInventoryStocksInfo.ICProductSupplierNumber = objProductsInfo.ICProductSupplierNumber;
                        objInventoryStocksInfo.ICProductDesc = desc;
                        objInventoryStocksInfo.ICMeasureUnitName = objProductsInfo.ICMeasureUnitName;
                        objInventoryStocksInfo.ICProductName = objProductsInfo.ICProductNo + " - " + objProductsInfo.ICProductName;
                        if (!String.IsNullOrEmpty(objInventoryStocksInfo.ICModelName))
                        {

                            objInventoryStocksInfo.ICProductName = objInventoryStocksInfo.ICProductName + " - " + objInventoryStocksInfo.ICModelName;
                        }
                        if (!String.IsNullOrEmpty(objInventoryStocksInfo.ICModelDetailName))
                        {
                            objInventoryStocksInfo.ICProductName = objInventoryStocksInfo.ICProductName + " - " + objInventoryStocksInfo.ICModelDetailName;
                        }
                    }

                    if (objInventoryStocksInfo != null)
                    {
                        objInventoryStocksInfo.ICProductPreviouslyAccumulateQty = previousAccumulateQty;
                        decimal previousAccumulateAmount = initCost;
                        if (sortedPrevInventoryStocks.ContainsKey(key))
                        {
                            //previousAccumulateAmount += sortedPrevInventoryStocks[objProductsInfo.ICProductID]
                            //                                                        .Sum(inv => inv.ICProductReceiptAmount - inv.ICProductShipmentAmount);
                            //previousAccumulateAmount += sortedPrevInventoryStocks[objProductsInfo.ICProductID]
                            //                                                        .Sum(inv => inv.ICProductReceiptAmount);
                        }
                        objInventoryStocksInfo.ICProductPreviouslyAccumulateAmount = previousAccumulateAmount;

                        decimal productNextAccumulateQty = previousAccumulateQty + objInventoryStocksInfo.ICProductReceiptQty - objInventoryStocksInfo.ICProductShipmentQty;
                        objInventoryStocksInfo.ICProductNextAccumulateQty = productNextAccumulateQty;
                        decimal nextAccumulateAmount = objInventoryStocksInfo.ICProductPreviouslyAccumulateAmount + objInventoryStocksInfo.ICProductReceiptAmount - objInventoryStocksInfo.ICProductShipmentAmount;
                        objInventoryStocksInfo.ICProductNextAccumulateAmount = nextAccumulateAmount;

                        if (fld_cmbViewType.SelectedIndex == 0)
                        {
                            objInventoryStocksInfo.ICProductNo = objProductsInfo.ICProductNo;
                            objInventoryStocksInfo.ICProductName = objProductsInfo.ICProductNo + " - " + objProductsInfo.ICProductName;
                            if (!String.IsNullOrEmpty(objInventoryStocksInfo.ICModelName))
                            {

                                objInventoryStocksInfo.ICProductName = objInventoryStocksInfo.ICProductName + " - " + objInventoryStocksInfo.ICModelName;
                            }
                            if (!String.IsNullOrEmpty(objInventoryStocksInfo.ICModelDetailName))
                            {
                                objInventoryStocksInfo.ICProductName = objInventoryStocksInfo.ICProductName + " - " + objInventoryStocksInfo.ICModelDetailName;
                            }
                            inventoryStockList.Add(objInventoryStocksInfo);
                        }
                        else if (fld_cmbViewType.SelectedIndex == 1)
                        {
                            if (productNextAccumulateQty != 0)
                            {
                                objInventoryStocksInfo.ICProductNo = objProductsInfo.ICProductNo;
                                objInventoryStocksInfo.ICProductName = objProductsInfo.ICProductNo + " - " + objProductsInfo.ICProductName;
                                if (!String.IsNullOrEmpty(objInventoryStocksInfo.ICModelName))
                                {

                                    objInventoryStocksInfo.ICProductName = objInventoryStocksInfo.ICProductName + " - " + objInventoryStocksInfo.ICModelName;
                                }
                                if (!String.IsNullOrEmpty(objInventoryStocksInfo.ICModelDetailName))
                                {
                                    objInventoryStocksInfo.ICProductName = objInventoryStocksInfo.ICProductName + " - " + objInventoryStocksInfo.ICModelDetailName;
                                }
                                inventoryStockList.Add(objInventoryStocksInfo);
                            }
                        }
                    }
                }
            }
            else
            {
                List<ICProductsInfo> objProductList = GetProductList();
                foreach (ICProductsInfo objProductsInfoM in objProductList)
                {
                    productID = objProductsInfoM.ICProductID;
                    List<string> keys = new List<string>();
                    //List<ICInventoryStocksInfo> inventoryStocks = objReportsController.GetIOInventoryListBySomeCriteria(dateFrom, dateTo, stockID, productID, accountID);
                    List<ICInventoryStocksInfo> inventoryStocks = objReportsController.GetIOInventoryListByListOfStockNosGroupByModel(dateFrom, dateTo, stockNoList,
                                                                                                                                    productID, accountID, supplierID);
                    foreach (ICInventoryStocksInfo item in inventoryStocks)
                    {
                        item.ReportKey = item.FK_ICProductID + "_" + item.ICModelName + "_" + item.ICModelDetailName;//item.ItemDesc;
                        if (!keys.Contains(item.ReportKey))
                        {
                            keys.Add(item.ReportKey);
                        }
                    }
                    SortedList<string, List<ICInventoryStocksInfo>> sortedInventoryStocks = new SortedList<string, List<ICInventoryStocksInfo>>();
                    foreach (ICInventoryStocksInfo inventoryStock in inventoryStocks)
                    {
                        if (stockNoList.Length == 0)
                        {
                            inventoryStock.FK_ICStockID = 0;
                            inventoryStock.ICStockName = string.Empty;
                            inventoryStock.ICStockNo = string.Empty;
                        }
                        if (!sortedInventoryStocks.ContainsKey(inventoryStock.ReportKey))
                        {
                            sortedInventoryStocks.Add(inventoryStock.ReportKey, new List<ICInventoryStocksInfo>());
                        }
                        sortedInventoryStocks[inventoryStock.ReportKey].Add(inventoryStock);
                    }

                    //List<ICInventoryStocksInfo> prevInventoryStocks = objReportsController.GetIOInventoryListBySomeCriteria(null, dateFrom.AddDays(-1), stockID, productID, accountID);
                    List<ICInventoryStocksInfo> prevInventoryStocks = objReportsController.GetIOInventoryListByListOfStockNosGroupByModel(null, dateFrom.AddDays(-1), stockNoList,
                                                                                                                                        productID, accountID, supplierID);

                    foreach (ICInventoryStocksInfo item in prevInventoryStocks)
                    {
                        item.ReportKey = item.FK_ICProductID + "_" + item.ICModelName + "_" + item.ICModelDetailName;//item.ItemDesc;
                        if (!keys.Contains(item.ReportKey))
                        {
                            keys.Add(item.ReportKey);
                        }
                    }
                    SortedList<string, List<ICInventoryStocksInfo>> sortedPrevInventoryStocks = new SortedList<string, List<ICInventoryStocksInfo>>();
                    foreach (ICInventoryStocksInfo inventoryStock in prevInventoryStocks)
                    {
                        if (stockNoList.Length == 0)
                        {
                            inventoryStock.FK_ICStockID = 0;
                            inventoryStock.ICStockName = string.Empty;
                            inventoryStock.ICStockNo = string.Empty;
                        }
                        if (!sortedPrevInventoryStocks.ContainsKey(inventoryStock.ReportKey))
                        {
                            sortedPrevInventoryStocks.Add(inventoryStock.ReportKey, new List<ICInventoryStocksInfo>());
                        }
                        sortedPrevInventoryStocks[inventoryStock.ReportKey].Add(inventoryStock);
                    }
                    //List<ICInventoryStocksInfo> initInventoryStocks = objInventoryStocksController.GetInitInventoryStocks(stockID, productID);
                    List<ICInventoryStocksInfo> initInventoryStocks = objInventoryStocksController.GetInitInventoryStocksByListOfStockNosGroupByModel(productID, stockNoList, accountID, supplierID);
                    foreach (ICInventoryStocksInfo item in initInventoryStocks)
                    {
                        item.ReportKey = item.FK_ICProductID + "_" + item.ICModelName + "_" + item.ICModelDetailName; //item.ItemDesc;
                        if (!keys.Contains(item.ReportKey))
                        {
                            keys.Add(item.ReportKey);
                        }
                    }
                    SortedList<string, List<ICInventoryStocksInfo>> sortedInitInventoryStocks = new SortedList<string, List<ICInventoryStocksInfo>>();
                    foreach (ICInventoryStocksInfo inventoryStock in initInventoryStocks)
                    {
                        if (stockNoList.Length == 0)
                        {
                            inventoryStock.FK_ICStockID = 0;
                            inventoryStock.ICStockName = string.Empty;
                            inventoryStock.ICStockNo = string.Empty;
                        }
                        if (!sortedInitInventoryStocks.ContainsKey(inventoryStock.ReportKey))
                        {
                            sortedInitInventoryStocks.Add(inventoryStock.ReportKey, new List<ICInventoryStocksInfo>());
                        }
                        sortedInitInventoryStocks[inventoryStock.ReportKey].Add(inventoryStock);
                    }


                    ICProductsController objProductsController = new ICProductsController();
                    //List<ICProductsInfo> productList = GetProductList();

                    //foreach (ICProductsInfo objProductsInfo in productList)
                    //{
                    foreach (string key in keys)
                    {
                        ICInventoryStocksInfo objInventoryStocksInfo = null;
                        string[] keyArrays = key.Split('_');
                        int objProductID = 0;
                        string desc = string.Empty;
                        for (int i = 0; i < keyArrays.Length; i++)
                        {
                            if (i == 0)
                            {
                                int.TryParse(keyArrays[i], out objProductID);
                            }
                            else
                            {
                                desc += keyArrays[i];
                            }
                        }



                        ICProductsInfo objProductsInfo = new ICProductsInfo();
                        if (objProductID > 0)
                        {
                            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductID);
                        }
                        if (sortedInventoryStocks.ContainsKey(key))
                        {
                            objInventoryStocksInfo = (ICInventoryStocksInfo)sortedInventoryStocks[key].FirstOrDefault();
                            objInventoryStocksInfo.ICProductReceiptQty = sortedInventoryStocks[key].Sum(item => item.ICProductReceiptQty);
                            objInventoryStocksInfo.ICProductShipmentQty = sortedInventoryStocks[key].Sum(item => item.ICProductShipmentQty);
                            objInventoryStocksInfo.ICProductReceiptAmount = sortedInventoryStocks[key].Sum(item => item.ICProductReceiptAmount);
                            objInventoryStocksInfo.ICProductShipmentAmount = sortedInventoryStocks[key].Sum(item => item.ICProductShipmentAmount);
                            objInventoryStocksInfo.ICProductDesc = desc;
                            objInventoryStocksInfo.ICProductName = objProductsInfo.ICProductNo + " - " + objProductsInfo.ICProductName;
                            if (!String.IsNullOrEmpty(objInventoryStocksInfo.ICModelName))
                            {

                                objInventoryStocksInfo.ICProductName = objInventoryStocksInfo.ICProductName + " - " + objInventoryStocksInfo.ICModelName;
                            }
                            if (!String.IsNullOrEmpty(objInventoryStocksInfo.ICModelDetailName))
                            {
                                objInventoryStocksInfo.ICProductName = objInventoryStocksInfo.ICProductName + " - " + objInventoryStocksInfo.ICModelDetailName;
                            }
                        }

                        decimal initQty = 0;
                        decimal initCost = 0;
                        if (sortedInitInventoryStocks.ContainsKey(key))
                        {
                            initQty = sortedInitInventoryStocks[key].Sum(inv => inv.ICProductReceiptQty);
                            initCost = sortedInitInventoryStocks[key].Sum(inv => inv.ICProductReceiptAmount);
                        }

                        decimal previousAccumulateQty = initQty;
                        if (sortedPrevInventoryStocks.ContainsKey(key))
                        {
                            previousAccumulateQty += sortedPrevInventoryStocks[key].Sum(inv => inv.ICProductReceiptQty - inv.ICProductShipmentQty);
                        }
                        if (previousAccumulateQty > 0 && objInventoryStocksInfo == null)
                        {
                            objInventoryStocksInfo = new ICInventoryStocksInfo();
                            objInventoryStocksInfo.ReportKey = key;
                            objInventoryStocksInfo.ICProductID = objProductsInfo.ICProductID;
                            //objInventoryStocksInfo.ICStockNo = s.ICStockNo;
                            //objInventoryStocksInfo.ICStockName = s.ICStockName;
                            objInventoryStocksInfo.ICProductSupplierNumber = objProductsInfo.ICProductSupplierNumber;
                            objInventoryStocksInfo.ICProductDesc = desc;
                            objInventoryStocksInfo.ICMeasureUnitName = objProductsInfo.ICMeasureUnitName;
                            objInventoryStocksInfo.ICProductName = objProductsInfo.ICProductNo + " - " + objProductsInfo.ICProductName;
                            if (!String.IsNullOrEmpty(objInventoryStocksInfo.ICModelName))
                            {

                                objInventoryStocksInfo.ICProductName = objInventoryStocksInfo.ICProductName + " - " + objInventoryStocksInfo.ICModelName;
                            }
                            if (!String.IsNullOrEmpty(objInventoryStocksInfo.ICModelDetailName))
                            {
                                objInventoryStocksInfo.ICProductName = objInventoryStocksInfo.ICProductName + " - " + objInventoryStocksInfo.ICModelDetailName;
                            }
                        }

                        if (objInventoryStocksInfo != null)
                        {
                            objInventoryStocksInfo.ICProductPreviouslyAccumulateQty = previousAccumulateQty;
                            decimal previousAccumulateAmount = initCost;
                            if (sortedPrevInventoryStocks.ContainsKey(key))
                            {
                                //previousAccumulateAmount += sortedPrevInventoryStocks[objProductsInfo.ICProductID]
                                //                                                        .Sum(inv => inv.ICProductReceiptAmount - inv.ICProductShipmentAmount);
                                //previousAccumulateAmount += sortedPrevInventoryStocks[objProductsInfo.ICProductID]
                                //                                                        .Sum(inv => inv.ICProductReceiptAmount);
                            }
                            objInventoryStocksInfo.ICProductPreviouslyAccumulateAmount = previousAccumulateAmount;

                            decimal productNextAccumulateQty = previousAccumulateQty + objInventoryStocksInfo.ICProductReceiptQty - objInventoryStocksInfo.ICProductShipmentQty;
                            objInventoryStocksInfo.ICProductNextAccumulateQty = productNextAccumulateQty;
                            decimal nextAccumulateAmount = objInventoryStocksInfo.ICProductPreviouslyAccumulateAmount + objInventoryStocksInfo.ICProductReceiptAmount - objInventoryStocksInfo.ICProductShipmentAmount;
                            objInventoryStocksInfo.ICProductNextAccumulateAmount = nextAccumulateAmount;

                            if (fld_cmbViewType.SelectedIndex == 0)
                            {
                                objInventoryStocksInfo.ICProductNo = objProductsInfo.ICProductNo;
                                objInventoryStocksInfo.ICProductName = objProductsInfo.ICProductNo + " - " + objProductsInfo.ICProductName;
                                if (!String.IsNullOrEmpty(objInventoryStocksInfo.ICModelName))
                                {

                                    objInventoryStocksInfo.ICProductName = objInventoryStocksInfo.ICProductName + " - " + objInventoryStocksInfo.ICModelName;
                                }
                                if (!String.IsNullOrEmpty(objInventoryStocksInfo.ICModelDetailName))
                                {
                                    objInventoryStocksInfo.ICProductName = objInventoryStocksInfo.ICProductName + " - " + objInventoryStocksInfo.ICModelDetailName;
                                }
                                inventoryStockList.Add(objInventoryStocksInfo);
                            }
                            else if (fld_cmbViewType.SelectedIndex == 1)
                            {
                                if (productNextAccumulateQty != 0)
                                {
                                    objInventoryStocksInfo.ICProductNo = objProductsInfo.ICProductNo;
                                    objInventoryStocksInfo.ICProductName = objProductsInfo.ICProductNo + " - " + objProductsInfo.ICProductName;
                                    if (!String.IsNullOrEmpty(objInventoryStocksInfo.ICModelName))
                                    {

                                        objInventoryStocksInfo.ICProductName = objInventoryStocksInfo.ICProductName + " - " + objInventoryStocksInfo.ICModelName;
                                    }
                                    if (!String.IsNullOrEmpty(objInventoryStocksInfo.ICModelDetailName))
                                    {
                                        objInventoryStocksInfo.ICProductName = objInventoryStocksInfo.ICProductName + " - " + objInventoryStocksInfo.ICModelDetailName;
                                    }
                                    inventoryStockList.Add(objInventoryStocksInfo);
                                }
                            }
                        }
                    }
                }
            }
            //}
            report.DataSource = inventoryStockList;
        }

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
                //products = objProductsController.GetProductList(departmentID, productGroupID, null, accountID);
                int companyID = BOSApp.CurrentCompanyInfo.CSCompanyID;
                products = objProductsController.GetProductList(companyID, departmentID, productGroupID, supplierID, accountID);
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
