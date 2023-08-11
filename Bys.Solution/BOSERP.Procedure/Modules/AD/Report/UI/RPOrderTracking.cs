using BOSCommon;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RPOrderTracking : ReportForm
    {
        private DateTime FromDate { get; set; }
        private DateTime ToDate { get; set; }
        private int CustomerID { get; set; }
        private int SaleOrderID { get; set; }
        private int BatchProductID { get; set; }
        private bool IsSearched { get; set; }
        private string CurrentSelectedPage { get; set; }
        List<string> TabSelectedList { get; set; }
        public RPOrderTracking()
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

        private void fld_btnExport_Click(object sender, EventArgs e)
        {
            GridView gridView = null;
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = @"Excel Files| *.xls; *.xlsx;";
            saveDialog.FilterIndex = 2;
            saveDialog.FileName = "BCTheoDoiMuaHang-" + DateTime.Now.ToString("yyyyddMMHHmmss") + ".xlsx";
            if (saveDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            string fullFileName = saveDialog.FileName;

            switch (CurrentSelectedPage)
            {
                case "fld_tabSemiProduct":
                    gridView = (GridView)fld_dgcItemMaterials.MainView;
                    gridView.ExportToXlsx(fullFileName);
                    break;
                case "fld_tabHardware":
                    gridView = (GridView)fld_dgcItemHardwaresGridControls.MainView;
                    gridView.ExportToXlsx(fullFileName);
                    break;
                case "fld_tabPackaging":
                    gridView = (GridView)fld_dgcPackagingGridControl.MainView;
                    gridView.ExportToXlsx(fullFileName);
                    break;
                case "fld_tabPaint":
                    gridView = (GridView)fld_dgcPaintGridControl.MainView;
                    gridView.ExportToXlsx(fullFileName);
                    break;
                case "fld_tabGenMaterial":
                    gridView = (GridView)fld_dgcGenMaterialGridControl.MainView;
                    gridView.ExportToXlsx(fullFileName);
                    break;
                case "fld_tabOutSourcing":
                    gridView = (GridView)fld_dgcOutSourcingGridControl.MainView;
                    gridView.ExportToXlsx(fullFileName);
                    break;
            }
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            FromDate = fld_dteSearchFromARInvoiceDate.DateTime;
            ToDate = fld_dteSearchToARInvoiceDate.DateTime;
            CustomerID = Convert.ToInt32(fld_lkeARCustomerID.EditValue);
            SaleOrderID = Convert.ToInt32(fld_lkeARSaleOrderID.EditValue);
            BatchProductID = Convert.ToInt32(fld_lkeMMBatchProductID.EditValue);
            IsSearched = true;
            TabSelectedList.Clear();
            ResetSelectTabPage();
            SearchDataCurentTab(true);
        }

        public void ResetSelectTabPage()
        {
            TabSelectedList = new List<string>();
            CurrentSelectedPage = fld_tabProductionNorm.SelectedTabPage?.Name;
        }

        private void RPOrderTracking_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromARInvoiceDate.EditValue = DateTime.Now;
            fld_dteSearchToARInvoiceDate.EditValue = DateTime.Now;
            ResetSelectTabPage();
        }

        private void fld_tabProductionNorm_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            CurrentSelectedPage = e.Page.Name;
            SearchDataCurentTab();
        }

        public void SearchDataCurentTab(bool isRefresh = false)
        {
            if (!IsSearched || string.IsNullOrWhiteSpace(CurrentSelectedPage))
                return;

            LazyLoadData(isRefresh);
        }

        public void LazyLoadData(bool isRefresh = false)
        {
            if (TabSelectedList.Contains(CurrentSelectedPage) && !isRefresh)
                return;

            TabSelectedList.Add(CurrentSelectedPage);
            BOSProgressBar.Start("Đang khởi tạo dữ liệu");
            MMBatchProductProductionNormItemsController pniController = new MMBatchProductProductionNormItemsController();
            DataSet ds = null;
            switch (CurrentSelectedPage)
            {
                case "fld_tabSemiProduct":
                    ds = pniController.GetDataReportOrderTrackingMaterials(CustomerID, SaleOrderID, BatchProductID, FromDate, ToDate);
                    fld_dgcItemMaterials.DataSource = ds.Tables[0];
                    break;
                case "fld_tabHardware":
                    ds = pniController.GetDataReportOrderTrackingItems(CustomerID, SaleOrderID, BatchProductID, FromDate, ToDate, ProductType.Hardware.ToString());
                    fld_dgcItemHardwaresGridControls.DataSource = ds.Tables[0];
                    break;
                case "fld_tabPackaging":
                    ds = pniController.GetDataReportOrderTrackingItems(CustomerID, SaleOrderID, BatchProductID, FromDate, ToDate, ProductType.IngredientPackaging.ToString());
                    fld_dgcPackagingGridControl.DataSource = ds.Tables[0];
                    break;
                case "fld_tabPaint":
                    ds = pniController.GetDataReportOrderTrackingItems(CustomerID, SaleOrderID, BatchProductID, FromDate, ToDate, ProductType.IngredientPaint.ToString());
                    fld_dgcPaintGridControl.DataSource = ds.Tables[0];
                    break;
                case "fld_tabGenMaterial":
                    ds = pniController.GetDataReportOrderTrackingItems(CustomerID, SaleOrderID, BatchProductID, FromDate, ToDate, ProductType.GeneralMaterial.ToString());
                    fld_dgcGenMaterialGridControl.DataSource = ds.Tables[0];
                    break;
                case "fld_tabOutSourcing":
                    ds = pniController.GetDataReportOrderTrackingItemOutSourcings(CustomerID, SaleOrderID, BatchProductID, FromDate, ToDate);
                    fld_dgcOutSourcingGridControl.DataSource = ds.Tables[0];
                    break;
            }
            BOSProgressBar.Close();
        }
    }
}