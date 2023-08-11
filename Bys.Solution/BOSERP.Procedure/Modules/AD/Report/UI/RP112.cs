using BOSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP112 : ReportForm
    {
        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
        private List<ICStocksInfo> stockListByUserGroup;
        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END

        public RP112()
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

        private void RP112_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            ICStocksController objStocksController = new ICStocksController();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            stockListByUserGroup = objStocksController.GetStocksByUserGroupIDAndType(BOSApp.CurrentUserGroupInfo.ADUserGroupID);
            fld_cmbStocks.Properties.DataSource = stockListByUserGroup;
            //List productType = new ListControl();
            //productType.a
            //fld_lkeProductType.Properties.DataSource=
            //fld_lkeProductType.Properties.DisplayMember = "RoundWood";
            //fld_lkeProductType.Properties.ValueMember = "Gỗ phách";
            ////NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            //DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            //DateTime dateTo = fld_dteSearchToDate.DateTime;
            //int stockID = Convert.ToInt32(fld_lkeICStockID.EditValue);
            int productID = Convert.ToInt32(fld_lkeICProductID.EditValue);
            int accountID = Convert.ToInt32(fld_lkeACAccountID.EditValue);
            int supplierID = Convert.ToInt32(fld_lkeFK_APSupplierID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeICDepartmentID.EditValue);
            int productGroupID = Convert.ToInt32(fld_lkeICProductGroupID.EditValue);
            string productType = comboBox1.Text;

            ADReportsController objReportsController = new ADReportsController();
            List<ICInventoryStocksInfo> inventoryStocks;
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
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
            if (productType == "Gỗ tròn")
            {
                productType = ProductType.Roundwood.ToString();
                inventoryStocks = objReportsController.GetIOInventoryListByUnitcost(stockNoList, productID, accountID, supplierID, departmentID, productGroupID, productType);
            }
            else if (productType == "Gỗ phách")
            {
                productType = ProductType.Lumber.ToString();
                inventoryStocks = objReportsController.GetIOInventoryListByUnitcost(stockNoList, productID, accountID, supplierID, departmentID, productGroupID, productType);
            }
            else if (productType == "Thành phẩm")
            {
                productType = ProductType.Product.ToString();
                inventoryStocks = objReportsController.GetIOInventoryListByUnitcost(stockNoList, productID, accountID, supplierID, departmentID, productGroupID, productType);
            }
            else if (productType == "Bán thành phẩm")
            {
                productType = ProductType.SemiProduct.ToString();
                inventoryStocks = objReportsController.GetIOInventoryListByUnitcost(stockNoList, productID, accountID, supplierID, departmentID, productGroupID, productType);
            }
            else if (productType.Equals(string.Empty))
            {
                inventoryStocks = objReportsController.GetIOInventoryListByUnitcost(stockNoList, productID, accountID, supplierID, departmentID, productGroupID, productType);
            }
            else
            {
                inventoryStocks = objReportsController.GetIOInventoryListByUnitcostAndTypeOther(stockNoList, productID, accountID, supplierID, departmentID, productGroupID);
            }

            foreach (ICInventoryStocksInfo item in inventoryStocks)
            {
                item.ICInventoryStockTotoAmount = item.ICInventoryStockUnitCost * item.ICInventoryStockQuantity;
            }
            fld_dgcRP112ICInventoryStocks.DataSource = inventoryStocks;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Gỗ tròn")
            {
                fld_dgcRP112ICInventoryStocks.LoadGridViewByProductType("RoundWood");
            }
            else if (comboBox1.Text == "Gỗ phách")
            {
                fld_dgcRP112ICInventoryStocks.LoadGridViewByProductType("Lumber");
            }
            else
            {
                fld_dgcRP112ICInventoryStocks.LoadGridViewByProductType("order");
            }
        }

    }
}
