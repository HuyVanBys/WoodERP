using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using Localization;
using BOSCommon;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public partial class RP214 : ReportForm
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
        //private List<ACAssetsInfo> AssetList;

        public RP214()
        {
            InitializeComponent();
        }

        private void RP093_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
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

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            GetDataSearch();
        }

        public void GetDataSearch()
        {
            //int customerID = 0;
            //int.TryParse(fld_lkeFK_ARCustomerID.EditValue.ToString(), out customerID);
            //DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            //DateTime searchToDate = fld_dteSearchToDate.DateTime;
            //string saleOrderNo = fld_ldkARSaleOrderNo.Text;
            //string batchProductNo = fld_lkeBatchProductNo.Text;
            //ADReportsController objReportsController = new ADReportsController();

            //List<ARSaleOrdersInfo> SaleOrderList = objReportsController.ARSaleOrder_GetSubscribeProduction(searchFromDate, searchToDate, customerID, saleOrderNo,batchProductNo);
            //fld_dgcRP101SaleOrders.DataSource = SaleOrderList;

            int CustomerID = 0, SaleOrderID = 0, BatchProductID = 0;
            string ConfigKeyValue = string.Empty;
            int.TryParse(fld_lkeFK_ARCustomerID.EditValue.ToString(), out CustomerID);
            int.TryParse(fld_ldkARSaleOrderNo.EditValue.ToString(), out SaleOrderID);
            int.TryParse(fld_lkeBatchProductNo.EditValue.ToString(), out BatchProductID);
            ConfigKeyValue = fld_lkeBatchProductStatus.EditValue.ToString();
            DateTime FromDate = Convert.ToDateTime(fld_dteSearchFromDate.EditValue);
            DateTime ToDate = Convert.ToDateTime(fld_dteSearchToDate.EditValue);

            MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
            List<MMBatchProductItemsInfo> ListItem = objBatchProductItemsController.GetItemForReport214(FromDate, ToDate, BatchProductID, CustomerID, SaleOrderID, ConfigKeyValue);
            fld_dgcRP101SaleOrders.DataSource = ListItem;
            GridView gridView = (GridView)fld_dgcRP101SaleOrders.MainView;
            gridView.ExpandAllGroups();
            gridView.BestFitColumns();

        }
    }
}
