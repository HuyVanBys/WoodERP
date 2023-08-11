using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP115 : ReportForm
    {
        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
        private List<ICStocksInfo> stockListByUserGroup;
        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END

        public RP115()
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

        private void RP115_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();
            ICStocksController objStocksController = new ICStocksController();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            stockListByUserGroup = objStocksController.GetStocksByUserGroupIDAndType(BOSApp.CurrentUserGroupInfo.ADUserGroupID);
            fld_cmbStocks.Properties.DataSource = stockListByUserGroup;
            ////NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            //int stockID = Convert.ToInt32(fld_lkeICStockID.EditValue);
            int productID = Convert.ToInt32(fld_lkeICProductID.EditValue);
            int accountID = Convert.ToInt32(fld_lkeACAccountID.EditValue);
            //int supplierID = Convert.ToInt32(fld_lkeFK_APSupplierID.EditValue);
            int batchProductID = Convert.ToInt32(fld_lkeFK_MMBatchProductID.EditValue);

            ADReportsController objReportsController = new ADReportsController();
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            List<ICInventoryStocksInfo> keyList = new List<ICInventoryStocksInfo>();
            string key = string.Empty;
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
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

            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END


            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //List<ICInventoryStocksInfo> inventoryStocks = objReportsController.GetIOInventoryListBySomeCriteria(dateFrom, dateTo, stockID, productID, accountID);
            List<ICInventoryStocksInfo> inventoryStocks = objReportsController.GetIOInventoryListByBatchProductIDAndProductType(dateFrom, dateTo, stockNoList,
                                                                                                                            productID, accountID, 0, batchProductID);
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            SortedList<string, List<ICInventoryStocksInfo>> sortedInventoryStocks = new SortedList<string, List<ICInventoryStocksInfo>>();
            foreach (ICInventoryStocksInfo inventoryStock in inventoryStocks)
            {
                if (stockNoList.Length == 0)
                {
                    inventoryStock.FK_ICStockID = 0;
                    inventoryStock.ICStockName = string.Empty;
                    inventoryStock.ICStockNo = string.Empty;
                }
                key = inventoryStock.MMBatchProductNo + inventoryStock.MMOperationName + inventoryStock.ICProductForBatchNo + inventoryStock.FK_ICProductID;
                if (!sortedInventoryStocks.ContainsKey(key))
                {
                    sortedInventoryStocks.Add(key, new List<ICInventoryStocksInfo>());
                }
                sortedInventoryStocks[key].Add(inventoryStock);
                ICInventoryStocksInfo foundItem = keyList.FirstOrDefault(item => item.MMBatchProductNo == inventoryStock.MMBatchProductNo
                                                                                && item.MMOperationName == inventoryStock.MMOperationName
                                                                                && item.ICProductForBatchNo == inventoryStock.ICProductForBatchNo
                                                                                && item.FK_ICProductID == inventoryStock.FK_ICProductID);
                if (foundItem == null)
                {
                    ICInventoryStocksInfo newKey = new ICInventoryStocksInfo();
                    newKey.MMBatchProductNo = inventoryStock.MMBatchProductNo;
                    newKey.MMOperationName = inventoryStock.MMOperationName;
                    newKey.ICProductForBatchNo = inventoryStock.ICProductForBatchNo;
                    newKey.FK_ICProductID = inventoryStock.FK_ICProductID;
                    newKey.ICProductName = inventoryStock.ICProductName;
                    newKey.ICProductForBatchNo = inventoryStock.ICProductForBatchNo;
                    newKey.ICProductForBatchName = inventoryStock.ICProductForBatchName;
                    keyList.Add(newKey);
                }
            }

            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //List<ICInventoryStocksInfo> prevInventoryStocks = objReportsController.GetIOInventoryListBySomeCriteria(null, dateFrom.AddDays(-1), stockID, productID, accountID);
            List<ICInventoryStocksInfo> prevInventoryStocks = objReportsController.GetIOInventoryListByBatchProductIDAndProductType(null, dateFrom.AddDays(-1), stockNoList,
                                                                                                                                productID, accountID, 0, batchProductID);
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            SortedList<string, List<ICInventoryStocksInfo>> sortedPrevInventoryStocks = new SortedList<string, List<ICInventoryStocksInfo>>();
            foreach (ICInventoryStocksInfo inventoryStock in prevInventoryStocks)
            {
                if (stockNoList.Length == 0)
                {
                    inventoryStock.FK_ICStockID = 0;
                    inventoryStock.ICStockName = string.Empty;
                    inventoryStock.ICStockNo = string.Empty;
                }
                key = inventoryStock.MMBatchProductNo + inventoryStock.MMOperationName + inventoryStock.ICProductForBatchNo + inventoryStock.FK_ICProductID;
                if (!sortedPrevInventoryStocks.ContainsKey(key))
                {
                    sortedPrevInventoryStocks.Add(key, new List<ICInventoryStocksInfo>());
                }
                sortedPrevInventoryStocks[key].Add(inventoryStock);
                ICInventoryStocksInfo foundItem = keyList.FirstOrDefault(item => item.MMBatchProductNo == inventoryStock.MMBatchProductNo
                                                                               && item.MMOperationName == inventoryStock.MMOperationName
                                                                               && item.ICProductForBatchNo == inventoryStock.ICProductForBatchNo
                                                                               && item.FK_ICProductID == inventoryStock.FK_ICProductID);
                if (foundItem == null)
                {
                    ICInventoryStocksInfo newKey = new ICInventoryStocksInfo();
                    newKey.MMBatchProductNo = inventoryStock.MMBatchProductNo;
                    newKey.MMOperationName = inventoryStock.MMOperationName;
                    newKey.ICProductForBatchNo = inventoryStock.ICProductForBatchNo;
                    newKey.FK_ICProductID = inventoryStock.FK_ICProductID;
                    newKey.ICProductName = inventoryStock.ICProductName;
                    newKey.ICProductForBatchNo = inventoryStock.ICProductForBatchNo;
                    newKey.ICProductForBatchName = inventoryStock.ICProductForBatchName;
                    keyList.Add(newKey);
                }
            }
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //List<ICInventoryStocksInfo> initInventoryStocks = objInventoryStocksController.GetInitInventoryStocks(stockID, productID);
            List<ICInventoryStocksInfo> initInventoryStocks = objInventoryStocksController.GetInitInventoryStocksByStockNoListAndBatchProductIDAndProductType(productID, stockNoList, accountID, 0, batchProductID);
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            SortedList<string, List<ICInventoryStocksInfo>> sortedInitInventoryStocks = new SortedList<string, List<ICInventoryStocksInfo>>();
            foreach (ICInventoryStocksInfo inventoryStock in initInventoryStocks)
            {
                if (stockNoList.Length == 0)
                {
                    inventoryStock.FK_ICStockID = 0;
                    inventoryStock.ICStockName = string.Empty;
                    inventoryStock.ICStockNo = string.Empty;
                }
                key = inventoryStock.MMBatchProductNo + inventoryStock.MMOperationName + inventoryStock.ICProductForBatchNo + inventoryStock.FK_ICProductID;
                if (!sortedInitInventoryStocks.ContainsKey(key))
                {
                    sortedInitInventoryStocks.Add(key, new List<ICInventoryStocksInfo>());
                }
                sortedInitInventoryStocks[key].Add(inventoryStock);
                ICInventoryStocksInfo foundItem = keyList.FirstOrDefault(item => item.MMBatchProductNo == inventoryStock.MMBatchProductNo
                                                                               && item.MMOperationName == inventoryStock.MMOperationName
                                                                               && item.ICProductForBatchNo == inventoryStock.ICProductForBatchNo
                                                                               && item.FK_ICProductID == inventoryStock.FK_ICProductID);
                if (foundItem == null)
                {
                    ICInventoryStocksInfo newKey = new ICInventoryStocksInfo();
                    newKey.MMBatchProductNo = inventoryStock.MMBatchProductNo;
                    newKey.MMOperationName = inventoryStock.MMOperationName;
                    newKey.ICProductForBatchNo = inventoryStock.ICProductForBatchNo;
                    newKey.FK_ICProductID = inventoryStock.FK_ICProductID;
                    newKey.ICProductName = inventoryStock.ICProductName;
                    newKey.ICProductForBatchNo = inventoryStock.ICProductForBatchNo;
                    newKey.ICProductForBatchName = inventoryStock.ICProductForBatchName;
                    keyList.Add(newKey);
                }
            }

            List<ICInventoryStocksInfo> inventoryStockList = new List<ICInventoryStocksInfo>();
            List<ICProductsInfo> productList = GetProductList();

            foreach (ICProductsInfo objProductsInfo in productList)
            {
                List<ICInventoryStocksInfo> foundKeyList = keyList.Where(item => item.FK_ICProductID == objProductsInfo.ICProductID).ToList();
                if (foundKeyList != null)
                {
                    foreach (ICInventoryStocksInfo inventoryKey in foundKeyList)
                    {
                        key = inventoryKey.MMBatchProductNo + inventoryKey.MMOperationName + inventoryKey.ICProductForBatchNo + inventoryKey.FK_ICProductID;
                        ICInventoryStocksInfo objInventoryStocksInfo = null;
                        if (sortedInventoryStocks.ContainsKey(key))
                        {
                            objInventoryStocksInfo = (ICInventoryStocksInfo)sortedInventoryStocks[key].FirstOrDefault();
                            objInventoryStocksInfo.ICProductReceiptQty = sortedInventoryStocks[key].Sum(item => item.ICProductReceiptQty);
                            objInventoryStocksInfo.ICProductShipmentQty = sortedInventoryStocks[key].Sum(item => item.ICProductShipmentQty);
                            objInventoryStocksInfo.ICProductReceiptAmount = sortedInventoryStocks[key].Sum(item => item.ICProductReceiptAmount);
                            objInventoryStocksInfo.ICProductShipmentAmount = sortedInventoryStocks[key].Sum(item => item.ICProductShipmentAmount);
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
                            //objInventoryStocksInfo.ICStockNo = s.ICStockNo;
                            //objInventoryStocksInfo.ICStockName = s.ICStockName;
                            objInventoryStocksInfo.ICProductSupplierNumber = objProductsInfo.ICProductSupplierNumber;
                            objInventoryStocksInfo.ICProductDesc = objProductsInfo.ICProductDesc;
                            objInventoryStocksInfo.ICMeasureUnitName = objProductsInfo.ICMeasureUnitName;
                            objInventoryStocksInfo.FK_ICProductID = objProductsInfo.ICProductID;
                            //objInventoryStocksInfo.ICProductName = objProductsInfo.ICProductName;
                        }

                        if (objInventoryStocksInfo != null)
                        {
                            objInventoryStocksInfo.ICProductPreviouslyAccumulateQty = previousAccumulateQty;

                            ICProductsController objProductsController = new ICProductsController();
                            ICProductsInfo objProductFB = (ICProductsInfo)objProductsController.GetObjectByNo(inventoryKey.ICProductForBatchNo);
                            if (objProductFB != null)
                            {
                                objInventoryStocksInfo.ICProductForBatchName = objProductFB.ICProductDesc;
                            }
                            //MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
                            //MMBatchProductItemsInfo objBatchProductItemsInfo = (MMBatchProductItemsInfo)objBatchProductItemsController.GetObjectByID(inventoryKey.MMBatchProductItemID);
                            //if (objBatchProductItemsInfo != null)
                            //{
                            //    objInventoryStocksInfo.MMBatchProductItemProductName = objBatchProductItemsInfo.MMBatchProductItemProductName;
                            //    objInventoryStocksInfo.MMBatchProductItemProductQty = objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            //}
                            //MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
                            //MMBatchProductProductionNormItemsInfo objBatchProductProductionNormItemsInfo = (MMBatchProductProductionNormItemsInfo)objBatchProductProductionNormItemsController.GetObjectByID(inventoryKey.MMBatchProductProductionNormItemID);
                            //if (objBatchProductProductionNormItemsInfo != null)
                            //{
                            //    objInventoryStocksInfo.MMBatchProductProductionNormItemProductName = objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductName;
                            //}
                            objInventoryStocksInfo.MMBatchProductNo = inventoryKey.MMBatchProductNo;
                            objInventoryStocksInfo.MMOperationName = inventoryKey.MMOperationName;
                            objInventoryStocksInfo.ICProductName = inventoryKey.ICProductName;
                            objInventoryStocksInfo.ICProductForBatchNo = inventoryKey.ICProductForBatchNo;
                            objInventoryStocksInfo.ICProductForBatchName = inventoryKey.ICProductForBatchName;
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

                            objInventoryStocksInfo.TotalBlockInit = objInventoryStocksInfo.MMBatchProductProductionNormItemBlockPerOne * objInventoryStocksInfo.ICProductPreviouslyAccumulateQty;
                            objInventoryStocksInfo.TotalBlockEndBalance = objInventoryStocksInfo.MMBatchProductProductionNormItemBlockPerOne * objInventoryStocksInfo.ICProductNextAccumulateQty;

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
                }
            }
            fld_dgcRP115ICInventoryStocks.DataSource = inventoryStockList;
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Init data source report for displaying
        /// </summary>
        /// <param name="report">Given report</param>

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
                //int departmentID = Convert.ToInt32(fld_lkeICDepartmentID.EditValue);
                //int productGroupID = Convert.ToInt32(fld_lkeICProductGroupID.EditValue);
                int accountID = Convert.ToInt32(fld_lkeACAccountID.EditValue);
                //int supplierID = Convert.ToInt32(fld_lkeFK_APSupplierID.EditValue);
                //NUThao [EDIT] [08/04/2014] [DB centre] [CSCompany issue], START
                //products = objProductsController.GetProductList(departmentID, productGroupID, null, accountID);
                int companyID = BOSApp.CurrentCompanyInfo.CSCompanyID;
                products = objProductsController.GetProductList(companyID, 0, 0, 0, accountID);
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
                int branchID = Convert.ToInt32(bosLookupEdit1.EditValue);
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
