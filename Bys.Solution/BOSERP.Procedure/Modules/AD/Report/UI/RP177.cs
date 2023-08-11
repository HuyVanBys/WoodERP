using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace BOSERP.Modules.Report
{
    public partial class RP177 : ReportForm
    {
        string dateType = "Date";
        public RP177()
        {
            InitializeComponent();
        }

        private void RP177_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
            fld_dteDataLoadFrom.DateTime = BOSUtil.GetMonthBeginDate().AddMonths(-3);
            GridView bandView = (GridView)fld_dgcRP177LabourProductivity.MainView;
            fld_dgcRP177LabourProductivity.MainView = InitializeCustomerBandedGridView(bandView, false);
        }
        #region Event


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

                    fld_dgcRP177LabourProductivity.ExportToXlsx(fileName);
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
            ShowReportData();
        }
        #endregion
        #region GridBand

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

        public void CreateBandedGridColumn(string name, string caption, GridBand ownerBand, BandedGridView bandedView, bool isgroup)
        {
            BandedGridColumn bandedLocation = new BandedGridColumn();
            bandedLocation.Name = name;
            bandedLocation.Caption = caption;
            bandedLocation.FieldName = name;
            bandedLocation.Visible = true;
            bandedLocation.OptionsColumn.AllowEdit = false;
            bandedLocation.OwnerBand = ownerBand;

            bandedLocation.MinWidth = 100;
            if (isgroup)
                bandedLocation.Group();
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
            bandedLocation.MinWidth = 50;
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

        public BandedGridView InitializeCustomerBandedGridView(GridView gridView, bool isViewSL)
        {
            MMOperationsController operationController = new MMOperationsController();
            BandedGridView bandedView = new BandedGridView();

            bandedView.GridControl = gridView.GridControl;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;
            bandedView.OptionsView.ShowFooter = true;

            List<GridBand> GridBandList = new List<GridBand>();
            //1. Date
            GridBand itemGridBandSelected = CreateGridBand("", GridBandList);
            itemGridBandSelected.AppearanceHeader.Options.UseTextOptions = true;
            itemGridBandSelected.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            CreateBandedGridColumn("ICReceiptDate", "NGÀY", itemGridBandSelected, bandedView, false);
            //3.SƠ CHẾ
            GridBand itemGridBandSLSC = CreateGridBand("SƠ CHẾ", GridBandList);
            itemGridBandSLSC.AppearanceHeader.Options.UseTextOptions = true;
            itemGridBandSLSC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivityKTSC", "KT(m3)", itemGridBandSLSC, bandedView);
            if (isViewSL)
                CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivitySLSC", "SL(USD)", itemGridBandSLSC, bandedView);
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivityGDSC", "Sản lượng GĐ(USD)", itemGridBandSLSC, bandedView);
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivityDayPillowSC", "Số ngày GĐ(ngày)", itemGridBandSLSC, bandedView);

            //4.ĐỊNH HÌNH
            GridBand itemGridBandSLDH = CreateGridBand("ĐỊNH HÌNH", GridBandList);
            itemGridBandSLDH.AppearanceHeader.Options.UseTextOptions = true;
            itemGridBandSLDH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivityKTDH", "KT(m3)", itemGridBandSLDH, bandedView);
            if (isViewSL)
                CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivitySLDH", "SL(USD)", itemGridBandSLDH, bandedView);
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivityGDDH", "Sản lượng GĐ(USD)", itemGridBandSLDH, bandedView);
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivityDayPillowDH", "Số ngày GĐ(ngày)", itemGridBandSLDH, bandedView);

            //5.LẮP RÁP & NHÁM NGUỘI
            GridBand itemGridBandSLLR = CreateGridBand("LẮP RÁP & NHÁM NGUỘI", GridBandList);
            itemGridBandSLLR.AppearanceHeader.Options.UseTextOptions = true;
            itemGridBandSLLR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivityKTLR", "KT(m3)", itemGridBandSLLR, bandedView);
            if (isViewSL)
                CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivitySLLR", "SL(USD)", itemGridBandSLLR, bandedView);
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivityGDLR", "Sản lượng GĐ(USD)", itemGridBandSLLR, bandedView);
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivityDayPillowLR", "Số ngày GĐ(ngày)", itemGridBandSLLR, bandedView);

            //6.SƠN
            GridBand itemGridBandSLS = CreateGridBand("SƠN", GridBandList);
            itemGridBandSLS.AppearanceHeader.Options.UseTextOptions = true;
            itemGridBandSLS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivityKTS", "KT(m3)", itemGridBandSLS, bandedView);
            if (isViewSL)
                CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivitySLS", "SL(USD)", itemGridBandSLS, bandedView);
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivityGDS", "Sản lượng GĐ(USD)", itemGridBandSLS, bandedView);
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivityDayPillowS", "Số ngày GĐ(ngày)", itemGridBandSLS, bandedView);

            //7.ĐÓNG GÓI
            GridBand itemGridBandSLDG = CreateGridBand("ĐÓNG GÓI", GridBandList);
            itemGridBandSLS.AppearanceHeader.Options.UseTextOptions = true;
            itemGridBandSLS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivityKTDG", "KT(m3)", itemGridBandSLDG, bandedView);
            if (isViewSL)
                CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivitySLDG", "SL(USD)", itemGridBandSLDG, bandedView);
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivityGDDG", "Sản lượng GĐ(USD)", itemGridBandSLDG, bandedView);
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivityDayPillowDG", "Số ngày GĐ(ngày)", itemGridBandSLDG, bandedView);


            bandedView.Bands.AddRange(GridBandList.ToArray());
            bandedView.BestFitColumns();
            return bandedView;
        }

        #endregion

        private void ShowReportData()
        {
            BOSProgressBar.Start("Đang tải dữ liệu...");

            int workShopID = 0;
            if (fld_lkeMMWorkShopID.EditValue != null)
            {
                int.TryParse(fld_lkeMMWorkShopID.EditValue.ToString(), out workShopID);
            }

            string viewType = "Date";

            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;
            DateTime LoadfromDate = fld_dteDataLoadFrom.DateTime;
            fromDate = fld_dteSearchFromDate.DateTime;
            toDate = fld_dteSearchToDate.DateTime;

            ADReportsController ReportsController = new ADReportsController();
            DataTable dt = ReportsController.GetDataReportTarget(viewType, workShopID, fromDate, toDate, LoadfromDate);

            fld_dgcRP177LabourProductivity.DataSource = dt;

            GridView bandViewAfterInit = (GridView)fld_dgcRP177LabourProductivity.MainView;
            BOSProgressBar.Close();
        }
    }
}
