using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP101 : ReportForm
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
        //private List<ACAssetsInfo> AssetList;

        public RP101()
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


        private void fld_btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.InitialDirectory = @"C:\";

                saveFileDialog1.Title = "Save Files";

                saveFileDialog1.DefaultExt = "xlsx";

                saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|(*.xlsx)|*.xlsx|All files (*.*)|*.*";

                saveFileDialog1.FilterIndex = 2;

                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    string fileName = saveFileDialog1.FileName;

                    fld_dgcRP101SaleOrders.ExportToXlsx(fileName);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The process cannot access the file") && ex.Message.Contains("because it is being used by another process."))
                    MessageBox.Show(ReportLocalizedResources.CannotExportToExcelFileBecauseTheFileIsBeingUsedByAnotherProcessMessage,
                                    ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(ReportLocalizedResources.ExportExelFileUnsuccessfullyMessage,
                                    ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            int.TryParse(fld_lkeFK_ARCustomerID.EditValue.ToString(), out CustomerID);
            int.TryParse(fld_ldkARSaleOrderNo.EditValue.ToString(), out SaleOrderID);
            int.TryParse(fld_lkeBatchProductNo.EditValue.ToString(), out BatchProductID);
            DateTime FromDate = Convert.ToDateTime(fld_dteSearchFromDate.EditValue);
            DateTime ToDate = Convert.ToDateTime(fld_dteSearchToDate.EditValue);

            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            List<ARSaleOrderItemsInfo> ListItem = objSaleOrderItemsController.GetItemForReport143(FromDate, ToDate, BatchProductID, CustomerID, SaleOrderID);
            fld_dgcRP101SaleOrders.DataSource = ListItem;
            GridView gridView = (GridView)fld_dgcRP101SaleOrders.MainView;
            gridView.ExpandAllGroups();
            gridView.BestFitColumns();

        }
    }
}
