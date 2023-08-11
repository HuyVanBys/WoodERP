using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP183 : ReportForm
    {
        #region Variables


        /// <summary>
        /// A variable to store the report data source
        /// </summary>
        public DataTable InvoicetemDataTable;
        List<int> OperationIDList;
        #endregion

        public RP183()
        {
            InitializeComponent();
        }

        private void RP182_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);



            fld_dteSearchFromDate.DateTime = BOSUtil.GetMonthBeginDate();
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
            this.Close();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {

            ShowReportData();

        }

        public GridBand CreateGridBand(string caption, List<GridBand> GridBandList)
        {
            GridBand gridBand = new GridBand();
            gridBand.Caption = caption;
            gridBand.Name = "";
            gridBand.AppearanceHeader.Options.UseTextOptions = true;
            gridBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            GridBandList.Add(gridBand);
            return gridBand;
        }

        public GridBand CreateGridBand(string caption)
        {
            GridBand gridBand = new GridBand();
            gridBand.Caption = caption;
            gridBand.Name = "";
            gridBand.AppearanceHeader.Options.UseTextOptions = true;
            gridBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            return gridBand;
        }

        public void CreateBandedGridColumn(string name, string caption, GridBand ownerBand, BandedGridView bandedView)
        {
            BandedGridColumn bandedLocation = new BandedGridColumn();
            bandedLocation.Name = name;
            bandedLocation.Caption = caption;
            bandedLocation.FieldName = name;
            bandedLocation.Visible = true;
            bandedLocation.OptionsColumn.AllowEdit = false;
            bandedLocation.OwnerBand = ownerBand;

            bandedLocation.MinWidth = 100;
            bandedView.Columns.Add(bandedLocation);

        }

        public void CreateBandedNumbericN4GridColumn(string name, string caption, GridBand ownerBand, BandedGridView bandedView)
        {
            BandedGridColumn bandedLocation = new BandedGridColumn();
            bandedLocation.Name = name;
            bandedLocation.Caption = caption;
            bandedLocation.FieldName = name;
            bandedLocation.Visible = true;
            bandedLocation.OptionsColumn.AllowEdit = false;
            bandedLocation.OwnerBand = ownerBand;
            bandedLocation.DisplayFormat.FormatType = FormatType.Numeric;
            bandedLocation.DisplayFormat.FormatString = "{0:n4}";
            bandedLocation.MinWidth = 100;
            bandedView.Columns.Add(bandedLocation);


            bandedLocation.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            bandedLocation.SummaryItem.DisplayFormat = "{0:n4}";
        }

        public void CreateBandedNumbericN2GridColumn(string name, string caption, GridBand ownerBand, BandedGridView bandedView)
        {
            BandedGridColumn bandedLocation = new BandedGridColumn();
            bandedLocation.Name = name;
            bandedLocation.Caption = caption;
            bandedLocation.FieldName = name;
            bandedLocation.Visible = true;
            bandedLocation.OptionsColumn.AllowEdit = false;
            bandedLocation.OwnerBand = ownerBand;
            bandedLocation.DisplayFormat.FormatType = FormatType.Numeric;
            bandedLocation.DisplayFormat.FormatString = "{0:n2}";
            bandedLocation.MinWidth = 100;
            bandedView.Columns.Add(bandedLocation);

            bandedLocation.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            bandedLocation.SummaryItem.DisplayFormat = "{0:n2}";
        }

        public void CreateBandedPercentGridColumn(string name, string caption, GridBand ownerBand, BandedGridView bandedView)
        {
            BandedGridColumn bandedLocation = new BandedGridColumn();
            bandedLocation.Name = name;
            bandedLocation.Caption = caption;
            bandedLocation.FieldName = name;
            bandedLocation.Visible = true;
            bandedLocation.OptionsColumn.AllowEdit = false;
            bandedLocation.OwnerBand = ownerBand;
            bandedLocation.DisplayFormat.FormatType = FormatType.Numeric;
            bandedLocation.DisplayFormat.FormatString = "{0:n2}";
            bandedLocation.MinWidth = 40;
            bandedView.Columns.Add(bandedLocation);

            bandedLocation.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            bandedLocation.SummaryItem.DisplayFormat = "{0:n2}";
        }
        public DataTable ReportDataSource;
        public void NewDataTable()
        {
            ReportDataSource = new DataTable();
            ReportDataSource.Columns.Add("MMBatchProductNo", typeof(string));
            ReportDataSource.Columns.Add("TotalBlock", typeof(double));

            ReportDataSource.Columns.Add("TyLePhoi", typeof(double));
            ReportDataSource.Columns.Add("KLNhapPhoi", typeof(double));
            ReportDataSource.Columns.Add("TyLeSoChe", typeof(double));
            ReportDataSource.Columns.Add("KLNhapSoChe", typeof(double));
            ReportDataSource.Columns.Add("TyLeTinhChe", typeof(double));
            ReportDataSource.Columns.Add("KLNhapTinhChe", typeof(double));
            ReportDataSource.Columns.Add("TyLeLapRap", typeof(double));
            ReportDataSource.Columns.Add("KLNhapLapRap", typeof(double));
            ReportDataSource.Columns.Add("TyLeSon", typeof(double));
            ReportDataSource.Columns.Add("KLNhapSon", typeof(double));
            ReportDataSource.Columns.Add("TyLeDongGoi", typeof(double));
            ReportDataSource.Columns.Add("KLNhapDongGoi", typeof(double));
        }

        public void FillDataSourceTable(List<ICReceiptItemsInfo> dataList)
        {
            ReportDataSource.Rows.Clear();

            foreach (ICReceiptItemsInfo item in dataList)
            {

                DataRow row = ReportDataSource.NewRow();
                row["MMBatchProductNo"] = item.MMBatchProductNo;
                row["TotalBlock"] = item.TotalBlock;
                row["TyLePhoi"] = item.TyLePhoi;
                row["KLNhapPhoi"] = item.KLNhapPhoi;
                row["TyLeSoChe"] = item.TyLeSoChe;
                row["KLNhapSoChe"] = item.KLNhapSoChe;
                row["TyLeTinhChe"] = item.TyLeTinhChe;
                row["KLNhapTinhChe"] = item.KLNhapTinhChe;
                row["TyLeLapRap"] = item.TyLeLapRap;
                row["KLNhapLapRap"] = item.KLNhapLapRap;
                row["TyLeSon"] = item.TyLeSon;
                row["KLNhapSon"] = item.KLNhapSon;
                row["TyLeDongGoi"] = item.TyLeDongGoi;
                row["KLNhapDongGoi"] = item.KLNhapDongGoi;


                ReportDataSource.Rows.Add(row);
            }
        }

        public BandedGridView InitializeCustomerBandedGridView(GridView gridView)
        {

            BandedGridView bandedView = new BandedGridView();

            bandedView.GridControl = gridView.GridControl;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;
            bandedView.OptionsView.ShowFooter = true;

            List<GridBand> GridBandList = new List<GridBand>();



            GridBand itemGridBandLSX = CreateGridBand("Thông Tin Chung", GridBandList);
            CreateBandedGridColumn("MMBatchProductNo", "Lệnh Sản Xuất", itemGridBandLSX, bandedView);
            CreateBandedNumbericN4GridColumn("TotalBlock", "Tổng Khối Lượng Định Mức", itemGridBandLSX, bandedView);

            GridBand itemGridBandPhoi = CreateGridBand("Phôi", GridBandList);
            CreateBandedNumbericN2GridColumn("TyLePhoi", "% Hoàn Thành", itemGridBandPhoi, bandedView);
            CreateBandedNumbericN4GridColumn("KLNhapPhoi", "Khối Lượng Hoàn Thành", itemGridBandPhoi, bandedView);

            GridBand itemGridBandSoChe = CreateGridBand("Sơ Chế", GridBandList);
            CreateBandedNumbericN2GridColumn("TyLeSoChe", "% Hoàn Thành", itemGridBandSoChe, bandedView);
            CreateBandedNumbericN4GridColumn("KLNhapSoChe", "Khối Lượng Hoàn Thành", itemGridBandSoChe, bandedView);

            GridBand itemGridBandTinhChe = CreateGridBand("Tinh Chế", GridBandList);
            CreateBandedNumbericN2GridColumn("TyLeTinhChe", "% Hoàn Thành", itemGridBandTinhChe, bandedView);
            CreateBandedNumbericN4GridColumn("KLNhapTinhChe", "Khối Lượng Hoàn Thành", itemGridBandTinhChe, bandedView);

            GridBand itemGridBandLapRap = CreateGridBand("Lắp Ráp", GridBandList);
            CreateBandedNumbericN2GridColumn("TyLeLapRap", "% Hoàn Thành", itemGridBandLapRap, bandedView);
            CreateBandedNumbericN4GridColumn("KLNhapLapRap", "Khối Lượng Hoàn Thành", itemGridBandLapRap, bandedView);

            GridBand itemGridBandSon = CreateGridBand("Sơn", GridBandList);
            CreateBandedNumbericN2GridColumn("TyLeSon", "% Hoàn Thành", itemGridBandSon, bandedView);
            CreateBandedNumbericN4GridColumn("KLNhapSon", "Khối Lượng Hoàn Thành", itemGridBandSon, bandedView);

            GridBand itemGridBandDongGoi = CreateGridBand("Đóng Gói", GridBandList);
            CreateBandedNumbericN2GridColumn("TyLeDongGoi", "% Hoàn Thành", itemGridBandDongGoi, bandedView);
            CreateBandedNumbericN4GridColumn("KLNhapDongGoi", "Khối Lượng Hoàn Thành", itemGridBandDongGoi, bandedView);


            bandedView.Bands.AddRange(GridBandList.ToArray());

            ////bandedView.Columns["APPurchaseOrderNo"].Group();
            bandedView.ExpandAllGroups();
            bandedView.BestFitColumns();
            return bandedView;
        }
        /// <summary>
        /// Show report data based on the report's parameters
        /// </summary>
        private void ShowReportData()
        {
            BOSProgressBar.Start(ReportLocalizedResources.LoadingData);

            int batchProductID = 0;
            int productID = 0;
            if (fld_lkeMMBatchProductID.EditValue != null)
            {
                int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out batchProductID);
            }

            if (fld_lkeICProductID.EditValue != null)
            {
                int.TryParse(fld_lkeICProductID.EditValue.ToString(), out productID);
            }

            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;

            ICReceiptItemsController controller = new ICReceiptItemsController();
            List<ICReceiptItemsInfo> dataList = controller.GetDataForReport183(batchProductID, productID, fromDate, toDate);

            GridView bandView = (GridView)fld_dgcICReceiptItems.MainView;
            fld_dgcICReceiptItems.MainView = InitializeCustomerBandedGridView(bandView);
            NewDataTable();
            FillDataSourceTable(dataList);
            fld_dgcICReceiptItems.DataSource = ReportDataSource;

            BandedGridView bandView2 = (BandedGridView)fld_dgcICReceiptItems.MainView;

            bandView2.BestFitColumns();
            bandView2.ExpandAllGroups();
            BOSProgressBar.Close();
        }

        private void fld_btnExcel_Click(object sender, EventArgs e)
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

                    fld_dgcICReceiptItems.ExportToXlsx(fileName);
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

        private void fld_lkeICProductSerieLotNo_Popup(object sender, EventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;


        }

        #region Initialize export excel parameter
        #endregion
    }

}