using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace BOSERP.Modules.Report
{
    public partial class RP181 : ReportForm
    {

        public RP181()
        {
            InitializeComponent();
        }

        private void RP181_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
            GridView bandView = (GridView)fld_dgcRP181GridControls.MainView;
            fld_dgcRP181GridControls.MainView = InitializeCustomerBandedGridView(bandView);
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

                    fld_dgcRP181GridControls.ExportToXlsx(fileName);
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
            GridBand itemGridBandSelected = CreateGridBand("Thông tin chung", GridBandList);
            itemGridBandSelected.AppearanceHeader.Options.UseTextOptions = true;
            itemGridBandSelected.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            CreateBandedGridColumn("MMBatchProductNo", "Lệnh SX", itemGridBandSelected, bandedView, false);
            CreateBandedGridColumn("ICReceiptNo", "Phiếu nhập", itemGridBandSelected, bandedView, false);
            CreateBandedGridColumn("MMOperationName", "Công đoạn", itemGridBandSelected, bandedView, false);
            CreateBandedGridColumn("HRDepartmentName", "Xưởng", itemGridBandSelected, bandedView, false);
            //3.SƠ CHẾ
            GridBand itemGridBandSLSC = CreateGridBand("Chi tiết", GridBandList);
            itemGridBandSLSC.AppearanceHeader.Options.UseTextOptions = true;
            itemGridBandSLSC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            CreateBandedGridColumn("MaSP", "Mã sản phẩm", itemGridBandSLSC, bandedView, false);
            CreateBandedGridColumn("ICReceiptItemTotalCost", "Giá trị(USD)", itemGridBandSLSC, bandedView, false);
            CreateBandedGridColumn("SLSP", "SL LSX", itemGridBandSLSC, bandedView, false);
            CreateBandedGridColumn("ICProductNo", "Mã chi tiết", itemGridBandSLSC, bandedView, false);
            CreateBandedGridColumn("ICProductAttributeWoodType", "Loại gỗ", itemGridBandSLSC, bandedView, false);
            CreateBandedGridColumn("ICReceiptItemProductHeight", "Dày", itemGridBandSLSC, bandedView, false);
            CreateBandedGridColumn("ICReceiptItemProductWidth", "Rộng", itemGridBandSLSC, bandedView, false);
            CreateBandedGridColumn("ICReceiptItemProductLength", "Dài", itemGridBandSLSC, bandedView, false);
            CreateBandedNumbericN2GridColumn("SLDM", "Số lượng ĐMSP", itemGridBandSLSC, bandedView);
            CreateBandedNumbericN2GridColumn("SLDMCT", "Số lượng ĐM/CT", itemGridBandSLSC, bandedView);
            CreateBandedNumbericN2GridColumn("ICReceiptItemProductQty", "Số lượng", itemGridBandSLSC, bandedView);
            CreateBandedNumbericN2GridColumn("ICReceiptItemWoodQty", "Khối tinh", itemGridBandSLSC, bandedView);


            bandedView.Bands.AddRange(GridBandList.ToArray());
            bandedView.BestFitColumns();
            return bandedView;
        }

        #endregion

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ShowReportData();
        }
        private void ShowReportData()
        {
            BOSProgressBar.Start("Đang tải dữ liệu...");

            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            int operationID = Convert.ToInt32(fld_lkeMMOperationID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeHRDepartmentID.EditValue);
            ADReportsController objADReportsController = new ADReportsController();

            List<ADReportsInfo> ListDMChiTiet = new List<ADReportsInfo>();
            List<ADReportsInfo> ListDMCum = new List<ADReportsInfo>();
            List<ADReportsInfo> ListDMSP = new List<ADReportsInfo>();
            List<ADReportsInfo> ListGiatri = new List<ADReportsInfo>();

            //ListGiatri = objADReportsController.GetBatchItemPrice(dateTo);
            //ListDMChiTiet = objADReportsController.GetBatchItemProductionNormDetail(dateTo);
            //ListDMCum = objADReportsController.GetBatchItemProductionNormComponent(dateTo);
            //ListDMSP = objADReportsController.GetBatchItemProductionNormProduct();



            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<ICReceiptItemsInfo> List = objReceiptItemsController.GetSemiProductReceiptByOperation(dateFrom, dateTo, operationID, departmentID);
            foreach (ICReceiptItemsInfo item in List)
            {
                if (item.FK_MMOperationID == 3 || item.FK_MMOperationID == 4 || item.FK_MMOperationID == 5)
                    item.SLDMCT = ListDMChiTiet.Where(x => x.FK_MMBatchProductItemID == item.FK_MMBatchProductItemID)
                                            .Sum(x => x.MMBatchProductProductionNormItemQuantity);
                else if (item.FK_MMOperationID == 84 || item.FK_MMOperationID == 6)
                    item.SLDMCT = ListDMCum.Where(x => x.FK_MMBatchProductItemID == item.FK_MMBatchProductItemID)
                                        .Sum(x => x.MMBatchProductProductionNormItemQuantity);
                else
                    item.SLDMCT = ListDMSP.Where(x => x.FK_MMBatchProductItemID == item.FK_MMBatchProductItemID)
                                        .Sum(x => x.MMBatchProductProductionNormItemQuantity);

                item.ICReceiptItemTotalCost = ListGiatri.Where(x => x.FK_MMBatchProductItemID == item.FK_MMBatchProductItemID).FirstOrDefault()
                                                    .ARSaleOrderItemTotalAmount;
            }

            fld_dgcRP181GridControls.DataSource = List;
            BOSProgressBar.Close();
        }

    }
}
