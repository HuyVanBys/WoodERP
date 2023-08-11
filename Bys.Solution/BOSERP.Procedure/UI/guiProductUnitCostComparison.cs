using BOSCommon;
using BOSLib;
using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class guiProductUnitCostComparison : BOSERPScreen
    {
        #region Variables
        /// <summary>
        /// A variable to store the product id to view unit cost comparison
        /// </summary>
        private int ProductID;

        /// <summary>
        /// A variable to store the supplier id to view unit cost comparison
        /// </summary>
        private int SupplierID;

        /// <summary>
        /// A variable to store the currency id to view unit cost comparison
        /// </summary>
        private int CurrencyID;
        private string ProductDesc;
        #endregion

        public guiProductUnitCostComparison()
        {
            InitializeComponent();
        }

        public guiProductUnitCostComparison(int productID, string productDesc, int supplierID, int currencyID)
        {
            InitializeComponent();
            ProductID = productID;
            SupplierID = supplierID;
            CurrencyID = currencyID;
            ProductDesc = productDesc;
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guiDictinctProductUnitCost_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            string date = "01/01/2016";
            fld_lkeFK_APSupplierID2.EditValue = SupplierID;
            fld_dteSearchFromAPInvoiceInDate.DateTime = Convert.ToDateTime(date);
            //fld_dteSearchFromAPInvoiceInDate.DateTime = BOSUtil.GetYearBeginDate();
            fld_dteSearchToAPInvoiceInDate.DateTime = BOSUtil.GetYearEndDate();
            ViewProductUnitCostComparisonChart();
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

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ViewProductUnitCostComparisonChart();
        }

        /// <summary>
        /// View comparing product unit cost over time 
        /// </summary>
        private void ViewProductUnitCostComparisonChart()
        {
            DateTime fromDate = Convert.ToDateTime(fld_dteSearchFromAPInvoiceInDate.EditValue);
            DateTime toDate = Convert.ToDateTime(fld_dteSearchToAPInvoiceInDate.EditValue);
            int supplierID = Convert.ToInt32(fld_lkeFK_APSupplierID2.EditValue);
            ViewProductUnitCostComparisonChart(fld_cctrlAPInvoiceInItems, ProductID, supplierID, CurrencyID, fromDate, toDate, ProductDesc);
        }

        /// <summary>
        /// View comparing product unit cost over time 
        /// </summary>
        /// <param name="chartControl">Product unit cost comparison chart control</param>
        /// <param name="productID">Product id</param>
        /// <param name="supplierID">Supplier id</param>
        /// <param name="fromDate">From date</param>
        /// <param name="toDate">To date</param>
        public void ViewProductUnitCostComparisonChart(BOSComponent.BOSChartControl chartControl, int productID, int supplierID, int currencyID, DateTime fromDate, DateTime toDate, string productDesc)
        {
            //APInvoiceInItemsController objInvoiceInItemsController = new APInvoiceInItemsController();            
            //DataSet ds = objInvoiceInItemsController.GetDistinctProductUnitCostList(productID, supplierID, fromDate, toDate, currencyID);
            //chartControl.Series[0].Points.Clear();
            //foreach (DataRow row in ds.Tables[0].Rows)
            //{
            //    APInvoiceInItemsInfo objInvoiceInItemsInfo = (APInvoiceInItemsInfo)objInvoiceInItemsController.GetObjectFromDataRow(row);
            //    SeriesPoint point = new SeriesPoint();
            //    point = new SeriesPoint(objInvoiceInItemsInfo.APInvoiceInDate.ToString("dd/MM/yyyy"), objInvoiceInItemsInfo.APInvoiceInItemProductUnitCost);
            //    chartControl.Series[0].Points.Add(point);
            //}
            string productDescTrim = string.Empty;
            productDescTrim = ProductDesc.Trim();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            DataSet ds;
            if (objProductsInfo != null && objProductsInfo.ICProductType == ProductType.IngredientPackaging.ToString())
            {
                ds = objReceiptItemsController.GetDistinctProductUnitCostList(productID, supplierID, fromDate, toDate, currencyID, productDescTrim);
            }
            else
            {
                ds = objReceiptItemsController.GetDistinctProductUnitCostList2(productID, supplierID, fromDate, toDate, currencyID);
            }
            Dictionary<int, List<ICReceiptItemsInfo>> collection = new Dictionary<int, List<ICReceiptItemsInfo>>();
            //chartControl.Series[0].Points.Clear();
            chartControl.Series.Clear();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ICReceiptItemsInfo ICReceiptItemsInfo = (ICReceiptItemsInfo)objReceiptItemsController.GetObjectFromDataRow(row);
                if (!collection.Keys.Contains(ICReceiptItemsInfo.FK_APSupplierID))
                    collection.Add(ICReceiptItemsInfo.FK_APSupplierID, new List<ICReceiptItemsInfo>());
                collection[ICReceiptItemsInfo.FK_APSupplierID].Add(ICReceiptItemsInfo);
                //SeriesPoint point = new SeriesPoint();
                //point = new SeriesPoint(objInvoiceInItemsInfo.APInvoiceInDate.ToString("dd/MM/yyyy"), objInvoiceInItemsInfo.APInvoiceInItemProductUnitCost);
                //chartControl.Series[0].Points.Add(point);
            }

            foreach (int key in collection.Keys)
            {
                if (collection[key].Count > 0)
                {
                    ICReceiptItemsInfo firstItem = collection[key][0];
                    Series serie = new Series(firstItem.APSupplierName, ViewType.Line);
                    foreach (ICReceiptItemsInfo item in collection[key])
                    {
                        SeriesPoint point = new SeriesPoint();
                        point = new SeriesPoint(item.ICReceiptDate.ToString("dd/MM/yyyy"), item.ICReceiptItemProductUnitCost);
                        serie.Points.Add(point);
                    }

                    chartControl.Series.Add(serie);
                }
            }
        }

        private void fld_cctrlAPInvoiceInItems_BoundDataChanged(object sender, EventArgs e)
        {
            foreach (Series sr in fld_cctrlAPInvoiceInItems.Series)
            {
                sr.PointOptions.ValueNumericOptions.Format = NumericFormat.Number;
                sr.PointOptions.ValueNumericOptions.Precision = 2;
            }
        }
    }
}
