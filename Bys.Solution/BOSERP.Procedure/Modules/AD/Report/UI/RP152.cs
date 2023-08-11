using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP152 : ReportForm
    {
        List<MMBatchProductProductionNormItemsInfo> reportListAll;
        public DataTable ProductionNormItemDataTable;
        public RP152()
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

        private void RP152_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();
            fld_dgcRP152BatchProductItems.MainView = GenerateBandedGridView();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            //BOSReport.RP152 report = new BOSReport.RP152();
            InitDataSourceReport();
            //XtraReportHelper.SetFormatField(report);
            //guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRP052Path, true);
            //reviewer.Show();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Init data source report for displaying
        /// </summary>
        /// <param name="report">Given report</param>
        public void InitDataSourceReport()
        {
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            int batchProductID = Convert.ToInt32(fld_lkeFK_MMBatchProductID.EditValue);
            int customerID = Convert.ToInt32(fld_lkeARCustomerID.EditValue);
            BRBranchsController objBranchsController = new BRBranchsController();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            //BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            //XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            //if (branchAddressLine3 != null)
            //    branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            //XRLabel branchPhone = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            //if (branchPhone != null)
            //    branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            //XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            //if (branchFax != null)
            //    branchFax.Text = objBranchsInfo.BRBranchContactFax;
            //XRLabel dateTime = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            //dateTime.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
            //                                                                        ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);
            ADReportsController objReportsController = new ADReportsController();
            reportListAll = new List<MMBatchProductProductionNormItemsInfo>();
            List<MMBatchProductProductionNormItemsInfo> reportListgo = objReportsController.RP152go(dateFrom, dateTo, batchProductID);
            reportListAll.AddRange(reportListgo);
            List<MMBatchProductProductionNormItemsInfo> reportListson = objReportsController.RP152Son(dateFrom, dateTo, batchProductID);
            reportListAll.AddRange(reportListson);
            List<MMBatchProductProductionNormItemsInfo> reportListHardWare = objReportsController.RP152HardWare(dateFrom, dateTo, batchProductID);
            reportListAll.AddRange(reportListHardWare);
            List<MMBatchProductProductionNormItemsInfo> reportListBaobi = objReportsController.RP152BaoBi(dateFrom, dateTo, batchProductID);
            reportListAll.AddRange(reportListBaobi);
            List<MMBatchProductProductionNormItemsInfo> reportListKeo = objReportsController.RP152Keo(dateFrom, dateTo, batchProductID);
            reportListAll.AddRange(reportListKeo);
            List<MMBatchProductProductionNormItemsInfo> reportListNham = objReportsController.RP152Nham(dateFrom, dateTo, batchProductID);
            reportListAll.AddRange(reportListNham);
            reportListAll = reportListAll.OrderBy(p => p.FK_MMBatchProductID).ToList();
            // report.DataSource = reportListAll;
            if (ProductionNormItemDataTable == null)
            {
                ProductionNormItemDataTable = new DataTable();
            }
            ProductionNormItemDataTable.Rows.Clear();
            foreach (MMBatchProductProductionNormItemsInfo item in reportListAll)
            {
                DataRow row = ProductionNormItemDataTable.NewRow();
                row["CPNL"] = item.CPNL;
                row["MMBatchProductNo"] = item.MMBatchProductNo;
                row["WoodTypeName"] = item.WoodTypeName;
                row["MMBatchProductProductionNormItemProductDesc"] = item.MMBatchProductProductionNormItemProductDesc;
                row["ProductDryHeight"] = item.ProductDryHeight;
                row["KTinh"] = item.KTinh;
                row["DTSonA"] = item.DTSonA;
                row["KLgoxe"] = item.KLgoxe;
                row["SLBTP"] = item.SLBTP;
                row["ICProductAttributeValue"] = item.ICProductAttributeValue;
                row["KLXuatthuc"] = item.KLXuatthuc;
                row["KLXuatthucBTP"] = item.KLXuatthucBTP;
                row["ICProductAttributeValueXK"] = item.ICProductAttributeValueXK;
                row["Giatritong"] = item.Giatritong;
                ProductionNormItemDataTable.Rows.Add(row);
            }
            fld_dgcRP152BatchProductItems.DataSource = ProductionNormItemDataTable;
        }
        public BandedGridView GenerateBandedGridView()
        {
            //OperationIDList = new List<int>();

            BandedGridView banded = new BandedGridView();
            banded.OptionsCustomization.AllowFilter = false;
            banded.OptionsView.ColumnAutoWidth = false;
            banded.OptionsView.ShowGroupPanel = false;
            banded.OptionsView.ShowFooter = true;

            ProductionNormItemDataTable = new DataTable();

            #region Thông tin chung
            GridBand generalBand = new GridBand();
            generalBand.Caption = "Thông tin chung";
            generalBand.Fixed = FixedStyle.Left;

            banded.Bands.Add(generalBand);

            //Các chỉ tiêu
            CreateBandedColumn("Các chỉ tiêu", "CPNL", true, false, generalBand, banded, true);
            ProductionNormItemDataTable.Columns.Add("CPNL");
            ProductionNormItemDataTable.Columns.Add("FK_APSupplierID");
            //Mã KHSX
            CreateBandedColumn("Mã KHSX", "MMBatchProductNo", true, false, generalBand, banded, true);
            ProductionNormItemDataTable.Columns.Add("MMBatchProductNo");
            //loại gỗ
            CreateBandedColumn("Loại gỗ", "WoodTypeName", true, false, generalBand, banded, true);
            ProductionNormItemDataTable.Columns.Add("WoodTypeName");

            //Mô tả
            CreateBandedColumn("Mô tả", "MMBatchProductProductionNormItemProductDesc", true, false, generalBand, banded, true);
            ProductionNormItemDataTable.Columns.Add("MMBatchProductProductionNormItemProductDesc");

            #endregion

            #region Định mức
            GridBand freshLumberBand = new GridBand();
            freshLumberBand.Caption = "Định mức";

            banded.Bands.Add(freshLumberBand);
            //Khối lượng tinh
            CreateBandedColumn("Khối lượng tinh/m2 sơn", "KTinh", true, false, freshLumberBand, banded, false);
            ProductionNormItemDataTable.Columns.Add("KTinh");
            //DT Son(m2)
            CreateBandedColumn("DT Son(m2)", "DTSonA", true, false, freshLumberBand, banded, false);
            ProductionNormItemDataTable.Columns.Add("DTSonA");
            //Khối lượng gỗ xẻ
            CreateBandedColumn("Khối lượng gỗ xẻ", "KLgoxe", true, false, freshLumberBand, banded, false);
            ProductionNormItemDataTable.Columns.Add("KLgoxe");
            //Số lượng
            CreateBandedColumn("Số lượng", "SLBTP", true, false, freshLumberBand, banded, false);
            ProductionNormItemDataTable.Columns.Add("SLBTP");
            //Dày
            CreateBandedColumn("Dày", "ProductDryHeight", true, false, freshLumberBand, banded, false);
            ProductionNormItemDataTable.Columns.Add("ProductDryHeight");
            //Chất lượng gỗ
            CreateBandedColumn("Chất lượng gỗ", "ICProductAttributeValue", true, false, freshLumberBand, banded, false);
            ProductionNormItemDataTable.Columns.Add("ICProductAttributeValue");

            #endregion

            #region Thực tế
            GridBand ProductQtyRoundWoodBand = new GridBand();
            ProductQtyRoundWoodBand.Caption = "Thực tế";

            banded.Bands.Add(ProductQtyRoundWoodBand);
            //Khối lượng gỗ xẻ
            CreateBandedColumn("Khối lượng gỗ xẻ", "KLXuatthuc", true, false, ProductQtyRoundWoodBand, banded, false);
            ProductionNormItemDataTable.Columns.Add("KLXuatthuc");
            //Số lượng
            CreateBandedColumn("Số lượng", "KLXuatthucBTP", true, false, ProductQtyRoundWoodBand, banded, false);
            ProductionNormItemDataTable.Columns.Add("KLXuatthucBTP");
            //Chất lượng gỗ
            CreateBandedColumn("Chất lượng gỗ", "ICProductAttributeValueXK", true, false, ProductQtyRoundWoodBand, banded, false);
            ProductionNormItemDataTable.Columns.Add("ICProductAttributeValueXK");

            //Giá trị
            CreateBandedColumn("Giá trị", "Giatritong", true, false, ProductQtyRoundWoodBand, banded, false);
            ProductionNormItemDataTable.Columns.Add("Giatritong");

            #endregion

            //#region Tỷ lệ
            //GridBand TLTHBand = new GridBand();
            //TLTHBand.Caption = "Tỷ lệ";
            ////TLTHBand.Fixed = FixedStyle.Left;

            //banded.Bands.Add(TLTHBand);
            ////Số chênh lệch
            //CreateBandedColumn("Số chênh lệch", "sochenhlenh", true, false, TLTHBand, banded, false);
            //ProductionNormItemDataTable.Columns.Add("sochenhlenh");

            ////% so ĐM
            //CreateBandedColumn("% so ĐM", "phantramsoDM", true, false, TLTHBand, banded, false);
            //ProductionNormItemDataTable.Columns.Add("phantramsoDM");

            //#endregion
            // banded.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(banded_FocusedRowChanged);
            return banded;
        }
        public void CreateBandedColumn(string caption, string fieldName, bool visible, bool allowEdit, GridBand ownerBand, BandedGridView banded, bool isFixLeft)
        {
            BandedGridColumn column = new BandedGridColumn();
            column.Caption = caption;
            column.FieldName = fieldName;

            column.Visible = visible;
            column.OptionsColumn.AllowEdit = allowEdit;
            column.OwnerBand = ownerBand;
            if (isFixLeft)
            {
                column.Fixed = FixedStyle.Left;
            }
            column.MinWidth = 75;
            banded.Columns.Add(column);
        }
        private void fld_btnExcel_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcRP152BatchProductItems.MainView;
            ExportToExcel(gridView);
        }

    }
}
