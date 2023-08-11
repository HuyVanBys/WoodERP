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
    public partial class RP176 : ReportForm
    {
        string dateType = "Date";
        public RP176()
        {
            InitializeComponent();
        }

        private void RP176_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
            fld_dteSearchFromMonth.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteSearchFromYear.DateTime = BOSUtil.GetYearBeginDate();
            fld_lkeHRLabouringConfigDateType.EditValue = "Date";
            fld_pnlMonth.Visible = false;
            fld_pnlYear.Visible = false;
            GridView bandView = (GridView)fld_dgcRP176LabourProductivity.MainView;
            fld_dgcRP176LabourProductivity.MainView = InitializeCustomerBandedGridView(bandView);
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

                    fld_dgcRP176LabourProductivity.ExportToXlsx(fileName);
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

        public BandedGridView InitializeCustomerBandedGridView(GridView gridView)
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
            CreateBandedGridColumn("ICReceiptDate", "Ngày", itemGridBandSelected, bandedView, false);

            //2.NGUYÊN LIỆU
            GridBand itemGridBandSLNL = CreateGridBand("NGUYÊN LIỆU", GridBandList);
            itemGridBandSLNL.AppearanceHeader.Options.UseTextOptions = true;
            itemGridBandSLNL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            CreateBandedNumbericN4GridColumn("ICReceiptLabourProductivityKTNL", "Khối tinh(m3)", itemGridBandSLNL, bandedView);
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivitySLNL", "Sản lượng(USD)", itemGridBandSLNL, bandedView);

            //3.SƠ CHẾ
            GridBand itemGridBandSLSC = CreateGridBand("SƠ CHẾ", GridBandList);
            itemGridBandSLSC.AppearanceHeader.Options.UseTextOptions = true;
            itemGridBandSLSC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            CreateBandedNumbericN4GridColumn("ICReceiptLabourProductivityKTSC", "Khối tinh(m3)", itemGridBandSLSC, bandedView);
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivitySLSC", "Sản lượng(USD)", itemGridBandSLSC, bandedView);

            //4.ĐỊNH HÌNH
            GridBand itemGridBandSLDH = CreateGridBand("ĐỊNH HÌNH", GridBandList);
            itemGridBandSLDH.AppearanceHeader.Options.UseTextOptions = true;
            itemGridBandSLDH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            CreateBandedNumbericN4GridColumn("ICReceiptLabourProductivityKTDH", "Khối tinh(m3)", itemGridBandSLDH, bandedView);
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivitySLDH", "Sản lượng(USD)", itemGridBandSLDH, bandedView);

            //5.LẮP RÁP & NHÁM NGUỘI
            GridBand itemGridBandSLLR = CreateGridBand("LẮP RÁP & NHÁM NGUỘI", GridBandList);
            itemGridBandSLLR.AppearanceHeader.Options.UseTextOptions = true;
            itemGridBandSLLR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            CreateBandedNumbericN4GridColumn("ICReceiptLabourProductivityKTLR", "Khối tinh(m3)", itemGridBandSLLR, bandedView);
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivitySLLR", "Sản lượng(USD)", itemGridBandSLLR, bandedView);

            //6.SƠN
            GridBand itemGridBandSLS = CreateGridBand("SƠN", GridBandList);
            itemGridBandSLS.AppearanceHeader.Options.UseTextOptions = true;
            itemGridBandSLS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            CreateBandedNumbericN4GridColumn("ICReceiptLabourProductivityKTS", "Khối tinh(m3)", itemGridBandSLS, bandedView);
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivitySLS", "Sản lượng(USD)", itemGridBandSLS, bandedView);

            //7.ĐÓNG GÓI
            GridBand itemGridBandSLDG = CreateGridBand("ĐÓNG GÓI", GridBandList);
            itemGridBandSLDG.AppearanceHeader.Options.UseTextOptions = true;
            itemGridBandSLDG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            CreateBandedNumbericN4GridColumn("ICReceiptLabourProductivityKTDG", "Khối tinh(m3)", itemGridBandSLDG, bandedView);
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivitySLDG", "Sản lượng(USD)", itemGridBandSLDG, bandedView);

            bandedView.Bands.AddRange(GridBandList.ToArray());
            bandedView.BestFitColumns();
            return bandedView;
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ShowReportData();
        }
        private void ShowReportData()
        {
            BOSProgressBar.Start("Đang tải dữ liệu...");

            int workShopID = 0;
            if (fld_lkeMMWorkShopID.EditValue != null)
            {
                int.TryParse(fld_lkeMMWorkShopID.EditValue.ToString(), out workShopID);
            }
            int departmentRoomID = 0;
            if (fld_lkeMMWorkShopID.EditValue != null)
            {
                //int.TryParse(fld_lkeHRDepartmentID.EditValue.ToString(), out departmentRoomID);
            }
            int departmentRoomGroupItemID = 0;
            if (fld_lkeMMWorkShopID.EditValue != null)
            {
                //int.TryParse(fld_lkeHRDepartmentID.EditValue.ToString(), out departmentRoomGroupItemID);
            }
            string viewType = string.Empty;
            if (fld_lkeHRLabouringConfigDateType.EditValue != null)
            {
                viewType = fld_lkeHRLabouringConfigDateType.EditValue.ToString();
            }
            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;

            if (dateType == "Date")
            {
                fromDate = fld_dteSearchFromDate.DateTime;
                toDate = fld_dteSearchToDate.DateTime;
            }
            else if (dateType == "Month")
            {
                fromDate = new DateTime(fld_dteSearchFromMonth.DateTime.Year, fld_dteSearchFromMonth.DateTime.Month, 1);
                toDate = BOSUtil.GetMonthEndDate(fromDate);
            }
            else if (dateType == "Year")
            {
                fromDate = new DateTime(fld_dteSearchFromYear.DateTime.Year, 1, 1);
                toDate = BOSUtil.GetYearEndDate(fromDate);
            }

            ADReportsController ReportsController = new ADReportsController();
            DataTable dt = ReportsController.GetDataForReportProducttionCheckFlow(viewType, workShopID, departmentRoomID, departmentRoomGroupItemID, fromDate, toDate);

            fld_dgcRP176LabourProductivity.DataSource = dt;

            GridView bandViewAfterInit = (GridView)fld_dgcRP176LabourProductivity.MainView;
            BOSProgressBar.Close();
        }

        private void fld_lkeHRLabouringConfigDateType_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeHRLabouringConfigDateType.EditValue != null && fld_lkeHRLabouringConfigDateType.EditValue.ToString() != string.Empty)
            {
                if (fld_lkeHRLabouringConfigDateType.EditValue.ToString() == "Date")
                {
                    fld_pnlDate.Visible = true;
                    fld_pnlMonth.Visible = false;
                    fld_pnlYear.Visible = false;
                    dateType = "Date";
                }
                else if (fld_lkeHRLabouringConfigDateType.EditValue.ToString() == "Month")
                {
                    fld_pnlDate.Visible = false;
                    fld_pnlMonth.Visible = true;
                    fld_pnlYear.Visible = false;
                    dateType = "Month";
                }
                else if (fld_lkeHRLabouringConfigDateType.EditValue.ToString() == "Year")
                {
                    fld_pnlDate.Visible = false;
                    fld_pnlMonth.Visible = false;
                    fld_pnlYear.Visible = true;
                    dateType = "Year";
                }
            }
        }
    }
}
