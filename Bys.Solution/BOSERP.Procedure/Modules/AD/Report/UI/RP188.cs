using BOSLib;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP188 : ReportForm
    {
        #region Variables        


        /// <summary>
        /// A variable to store the report data source
        /// </summary>
        public DataTable InvoiceInItemDataTable;
        List<int> OperationIDList;
        #endregion

        public RP188()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void RP188_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dteSearchFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
            fld_dgcICReceiptCDITems.MainView = GenerateBandedGridView();
            // = GenerateFocusedItem();
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
            if (fld_dteSearchFromDate.DateTime != DateTime.MaxValue && fld_dteSearchToDate.DateTime != DateTime.MaxValue)
            {
                ShowReportData();
            }
        }

        /// <summary>
        /// Show report data based on the report's parameters
        /// </summary>
        private void ShowReportData()
        {
            BOSProgressBar.Start(ReportLocalizedResources.LoadingData);
            int APInvoiceInID = 0;
            int.TryParse(fld_lkeAPInvoiceInID.EditValue.ToString(), out APInvoiceInID);
            //int.TryParse(fld_lkeICProductAttributeWoodType.EditValue.ToString(), out RoundWoodID);
            //int.TryParse(fld_lkeICProductAttributeID.EditValue.ToString(), out TTMTID);
            //string lotno = fld_txtICReceiptItemLotNo.Text;
            DateTime FromDate = Convert.ToDateTime(fld_dteSearchFromDate.EditValue);
            DateTime ToDate = Convert.ToDateTime(fld_dteSearchToDate.EditValue);

            APInvoiceInItemsController objInvoiceInItemsController = new APInvoiceInItemsController();
            List<APInvoiceInItemsInfo> ListItem = objInvoiceInItemsController.GetRP188(FromDate, ToDate, APInvoiceInID);
            if (InvoiceInItemDataTable == null)
            {
                InvoiceInItemDataTable = new DataTable();
            }
            InvoiceInItemDataTable.Rows.Clear();
            foreach (APInvoiceInItemsInfo item in ListItem)
            {
                DataRow row = InvoiceInItemDataTable.NewRow();
                row["ICProductNo"] = item.ICProductNo;
                row["ICProductName"] = item.ICProductName;
                row["APInvoiceInItemProductDesc"] = item.APInvoiceInItemProductDesc;
                row["APInvoiceInNo"] = item.APInvoiceInNo;
                row["APInvoiceInItemLotNo"] = item.APInvoiceInItemLotNo;
                row["APInvoiceInItemContainerNo"] = item.APInvoiceInItemContainerNo;
                row["APInvoiceInItemProductQty"] = item.APInvoiceInItemProductQty;
                row["APInvoiceInItemWoodQty"] = item.APInvoiceInItemWoodQty;
                row["ICReceiptNo"] = item.ICReceiptNo;
                row["ICReceiptItemProductQty"] = item.ICReceiptItemProductQty;
                row["ICReceiptItemWoodQty"] = item.ICReceiptItemWoodQty;
                row["SLChenhlech"] = Math.Round((item.APInvoiceInItemWoodQty - item.ICReceiptItemWoodQty), 0);
                row["KLChenhlech"] = Math.Round((item.APInvoiceInItemProductQty - item.ICReceiptItemProductQty), 4);
                InvoiceInItemDataTable.Rows.Add(row);
            }
            fld_dgcICReceiptCDITems.DataSource = InvoiceInItemDataTable;

            fld_dgcICReceiptCDITems.ForceInitialize();
            GridView view_Depasse = fld_dgcICReceiptCDITems.MainView as GridView;
            view_Depasse.Columns["APInvoiceInItemLotNo"].GroupIndex = 0;

            GridGroupSummaryItem griditem = new GridGroupSummaryItem();
            griditem.FieldName = "APInvoiceInItemProductQty";
            griditem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            griditem.DisplayFormat = "{0:N4}";
            view_Depasse.GroupSummary.Add(griditem);
            griditem.ShowInGroupColumnFooter = view_Depasse.Columns["APInvoiceInItemProductQty"];

            griditem = new GridGroupSummaryItem();
            griditem.FieldName = "APInvoiceInItemWoodQty";
            griditem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            griditem.DisplayFormat = "{0:N0}";
            view_Depasse.GroupSummary.Add(griditem);
            griditem.ShowInGroupColumnFooter = view_Depasse.Columns["APInvoiceInItemWoodQty"];

            griditem = new GridGroupSummaryItem();
            griditem.FieldName = "ICReceiptItemProductQty";
            griditem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            griditem.DisplayFormat = "{0:N4}";
            view_Depasse.GroupSummary.Add(griditem);
            griditem.ShowInGroupColumnFooter = view_Depasse.Columns["ICReceiptItemProductQty"];

            griditem = new GridGroupSummaryItem();
            griditem.FieldName = "ICReceiptItemWoodQty";
            griditem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            griditem.DisplayFormat = "{0:N0}";
            view_Depasse.GroupSummary.Add(griditem);
            griditem.ShowInGroupColumnFooter = view_Depasse.Columns["ICReceiptItemWoodQty"];

            griditem = new GridGroupSummaryItem();
            griditem.FieldName = "KLChenhlech";
            griditem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            griditem.DisplayFormat = "{0:N4}";
            view_Depasse.GroupSummary.Add(griditem);
            griditem.ShowInGroupColumnFooter = view_Depasse.Columns["KLChenhlech"];

            griditem = new GridGroupSummaryItem();
            griditem.FieldName = "SLChenhlech";
            griditem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            griditem.DisplayFormat = "{0:N0}";
            view_Depasse.GroupSummary.Add(griditem);
            griditem.ShowInGroupColumnFooter = view_Depasse.Columns["SLChenhlech"];

            view_Depasse.ExpandAllGroups();

            BOSProgressBar.Close();
        }
        public bool GenerateFocusedItem()
        {
            return true;
        }
        public BandedGridView GenerateBandedGridView()
        {
            OperationIDList = new List<int>();

            BandedGridView banded = new BandedGridView();
            banded.OptionsCustomization.AllowFilter = false;
            banded.OptionsView.ColumnAutoWidth = false;
            banded.OptionsView.ShowGroupPanel = false;
            banded.OptionsView.ShowFooter = true;

            InvoiceInItemDataTable = new DataTable();

            #region Thông tin chung
            GridBand generalBand = new GridBand();
            generalBand.Caption = "Thông tin chung";
            generalBand.Fixed = FixedStyle.Left;

            banded.Bands.Add(generalBand);

            //Mã sản phẩm
            CreateBandedColumn("Mã sản phẩm", "ICProductNo", true, false, generalBand, banded, true);
            InvoiceInItemDataTable.Columns.Add("ICProductNo");
            //Tên sản phẩm
            CreateBandedColumn("Tên sản phẩm", "ICProductName", true, false, generalBand, banded, true);
            InvoiceInItemDataTable.Columns.Add("ICProductName");
            //Mô tả
            CreateBandedColumn("Mô tả", "APInvoiceInItemProductDesc", true, false, generalBand, banded, true);
            InvoiceInItemDataTable.Columns.Add("APInvoiceInItemProductDesc");
            //Mã lo gỗ
            CreateBandedColumn("Mã lo gỗ", "APInvoiceInItemLotNo", true, false, generalBand, banded, true);
            InvoiceInItemDataTable.Columns.Add("APInvoiceInItemLotNo");
            //Mã cont
            CreateBandedColumn("Mã cont", "APInvoiceInItemContainerNo", true, false, generalBand, banded, true);
            InvoiceInItemDataTable.Columns.Add("APInvoiceInItemContainerNo");
            #endregion

            #region Packinglist
            GridBand ProductQtyInvoiceinBand = new GridBand();
            ProductQtyInvoiceinBand.Caption = "Packinglist";

            banded.Bands.Add(ProductQtyInvoiceinBand);
            //Mã hóa đơn
            CreateBandedColumn("Mã hóa đơn", "APInvoiceInNo", true, false, ProductQtyInvoiceinBand, banded, false);
            InvoiceInItemDataTable.Columns.Add("APInvoiceInNo");

            //Số lượng
            CreateBandedColumn("Số lượng", "APInvoiceInItemWoodQty", true, false, ProductQtyInvoiceinBand, banded, false);
            InvoiceInItemDataTable.Columns.Add("APInvoiceInItemWoodQty");

            //Khối lượng
            CreateBandedColumn("Khối lượng", "APInvoiceInItemProductQty", true, false, ProductQtyInvoiceinBand, banded, false);
            InvoiceInItemDataTable.Columns.Add("APInvoiceInItemProductQty");


            //Theo CD
            //CreateBandedColumn("Theo CD", "KLtheoCD", true, false, ProductQtyInvoiceinBand, banded, false);
            //ReceiptCDItemDataTable.Columns.Add("KLtheoCD");

            #endregion

            #region Thực tế
            GridBand KLTTBand = new GridBand();
            KLTTBand.Caption = "Thực tế";
            //TLTHBand.Fixed = FixedStyle.Left;

            banded.Bands.Add(KLTTBand);
            //Mã nhập kho
            CreateBandedColumn("Mã nhập kho", "ICReceiptNo", true, false, KLTTBand, banded, false);
            InvoiceInItemDataTable.Columns.Add("ICReceiptNo");

            //Số lượng
            CreateBandedColumn("Số lượng", "ICReceiptItemWoodQty", true, false, KLTTBand, banded, false);
            InvoiceInItemDataTable.Columns.Add("ICReceiptItemWoodQty");

            //Khối lượng
            CreateBandedColumn("Khối lượng", "ICReceiptItemProductQty", true, false, KLTTBand, banded, false);
            InvoiceInItemDataTable.Columns.Add("ICReceiptItemProductQty");
            #endregion

            #region khối lượng Chênh lệch
            GridBand KLCL = new GridBand();
            KLCL.Caption = "SL/KL Chênh lệch";

            //Số lượng
            CreateBandedColumn("Số lượng", "SLChenhlech", true, false, KLCL, banded, false);
            InvoiceInItemDataTable.Columns.Add("SLChenhlech");

            //Khối lượng
            CreateBandedColumn("Khối lượng", "KLChenhlech", true, false, KLCL, banded, false);
            InvoiceInItemDataTable.Columns.Add("KLChenhlech");

            #endregion
            banded.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(banded_FocusedRowChanged);
            return banded;
        }

        void banded_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //throw new NotImplementedException();
            ICReceiptCDItemsController objReceiptCDItemsController = new ICReceiptCDItemsController();
            BandedGridView BandedgridView = (BandedGridView)sender;
            //int supplierID = 0;
            //int productAttributeTTMTID = 0;
            //int productAttributeWoodTypeID = 0;
            //int countryID = 0;
            //string lotno = string.Empty;
            //double KLvantuoi = 0;
            //if (BandedgridView.FocusedColumn != null)
            //{               
            //    if (BandedgridView.FocusedRowHandle >= 0)
            //    {
            //        DataRow row = (DataRow)BandedgridView.GetDataRow(BandedgridView.FocusedRowHandle);
            //        if (row["FK_APSupplierID"] != null)
            //        {
            //            int.TryParse(row["FK_APSupplierID"].ToString(),out supplierID);
            //        }
            //        if (row["FK_ICProductAttributeTTMTID"] != null)
            //        {
            //            int.TryParse(row["FK_ICProductAttributeTTMTID"].ToString(), out productAttributeTTMTID);
            //        }
            //        if (row["FK_ICProductAttributeWoodTypeID"] != null)
            //        {
            //            int.TryParse(row["FK_ICProductAttributeWoodTypeID"].ToString(), out productAttributeWoodTypeID);
            //        }
            //        if (row["FK_GECountryID"] != null)
            //        {
            //            int.TryParse(row["FK_GECountryID"].ToString(), out countryID);
            //        }
            //        if (row["ICReceiptCDLotNo"] != null)
            //        {
            //            lotno = row["ICReceiptCDLotNo"].ToString();
            //        }
            //        if (row["KLvantuoi"] != null)
            //        {
            //            double.TryParse(row["KLvantuoi"].ToString(), out KLvantuoi);
            //        }
            //        List<ICReceiptCDItemsInfo> listReceiptCDItem = objReceiptCDItemsController.GetReceiptCDItemForReport145detail(supplierID, productAttributeTTMTID, productAttributeWoodTypeID, countryID, lotno);
            //        if (listReceiptCDItem.Count > 0)
            //        {
            //            foreach (ICReceiptCDItemsInfo item in listReceiptCDItem)
            //            {
            //                item.ProductQuality = double.Parse(((item.ICReceiptCDItemProductQty / KLvantuoi)*100).ToString("n2"));
            //            }
            //        }
            //        //fld_dgcICReceiptCDITemdetail.DataSource = listReceiptCDItem;
            //    }

            //}
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
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcICReceiptCDITems.MainView;
            ExportToExcel(gridView);
        }

        #region Initialize export excel parameter
        #endregion
    }

}