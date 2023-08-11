using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP145 : ReportForm
    {
        #region Variables        


        /// <summary>
        /// A variable to store the report data source
        /// </summary>
        public DataTable ReceiptCDItemDataTable;
        List<int> OperationIDList;
        #endregion

        public RP145()
        {
            InitializeComponent();
        }

        private void RP145_Load(object sender, EventArgs e)
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
            int SupplierID = 0, TTMTID = 0, RoundWoodID = 0;
            int.TryParse(fld_lkeAPSupplierID.EditValue.ToString(), out SupplierID);
            int.TryParse(fld_lkeICProductAttributeWoodType.EditValue.ToString(), out RoundWoodID);
            int.TryParse(fld_lkeICProductAttributeID.EditValue.ToString(), out TTMTID);
            string lotno = fld_txtICReceiptItemLotNo.Text;
            DateTime FromDate = Convert.ToDateTime(fld_dteSearchFromDate.EditValue);
            DateTime ToDate = Convert.ToDateTime(fld_dteSearchToDate.EditValue);

            ICReceiptCDItemsController objReceiptCDItemsController = new ICReceiptCDItemsController();
            List<ICReceiptCDItemsInfo> ListItem = objReceiptCDItemsController.GetReceiptCDItemForReport145(FromDate, ToDate, SupplierID, TTMTID, RoundWoodID, lotno);
            if (ReceiptCDItemDataTable == null)
            {
                ReceiptCDItemDataTable = new DataTable();
            }
            ReceiptCDItemDataTable.Rows.Clear();
            foreach (ICReceiptCDItemsInfo item in ListItem)
            {
                DataRow row = ReceiptCDItemDataTable.NewRow();
                row["APSupplierName"] = item.APSupplierName;
                row["ICReceiptCDLotNo"] = item.ICReceiptCDLotNo;
                row["ICProductAttributeValue"] = item.ICProductAttributeValue;
                row["GECountryName"] = item.GECountryName;
                row["KLvantuoi"] = item.KLvantuoi;
                row["KLtheoCD"] = item.KLtheoCD;
                row["KLtheoKho"] = item.KLtheoKho;
                row["KLtheoLoglist"] = item.KLtheoLoglist;
                row["FK_ICProductAttributeTTMTID"] = item.FK_ICProductAttributeTTMTID;
                row["FK_ICProductAttributeWoodTypeID"] = item.FK_ICProductAttributeWoodTypeID;
                row["FK_APSupplierID"] = item.FK_APSupplierID;
                row["FK_GECountryID"] = item.FK_GECountryID;
                if (item.KLtheoCD > 0)
                {
                    row["TLTHtheoCD"] = (item.KLvantuoi / item.KLtheoCD).ToString("n4");
                }
                if (item.KLtheoKho > 0)
                {
                    row["TLTHtheoKho"] = (item.KLvantuoi / item.KLtheoKho).ToString("n4");
                }
                if (item.KLtheoLoglist > 0)
                {
                    row["TLTHtheoLoglist"] = (item.KLvantuoi / item.KLtheoLoglist).ToString("n4");
                }
                ReceiptCDItemDataTable.Rows.Add(row);
            }
            fld_dgcICReceiptCDITems.DataSource = ReceiptCDItemDataTable;

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

            ReceiptCDItemDataTable = new DataTable();

            #region Thông tin chung
            GridBand generalBand = new GridBand();
            generalBand.Caption = "Thông tin chung";
            generalBand.Fixed = FixedStyle.Left;

            banded.Bands.Add(generalBand);

            //Nhà cung cấp
            CreateBandedColumn("Nhà cung cấp", "APSupplierName", true, false, generalBand, banded, true);
            ReceiptCDItemDataTable.Columns.Add("APSupplierName");
            ReceiptCDItemDataTable.Columns.Add("FK_APSupplierID");
            //Tên gỗ
            CreateBandedColumn("Tên gỗ", "ICProductAttributeValue", true, false, generalBand, banded, true);
            ReceiptCDItemDataTable.Columns.Add("ICProductAttributeValue");
            ReceiptCDItemDataTable.Columns.Add("FK_ICProductAttributeTTMTID");
            ReceiptCDItemDataTable.Columns.Add("FK_ICProductAttributeWoodTypeID");
            //Mã lo gỗ
            CreateBandedColumn("Mã lo gỗ", "ICReceiptCDLotNo", true, false, generalBand, banded, true);
            ReceiptCDItemDataTable.Columns.Add("ICReceiptCDLotNo");

            //Nguồn gốc
            CreateBandedColumn("Nguồn gốc", "GECountryName", true, false, generalBand, banded, true);
            ReceiptCDItemDataTable.Columns.Add("GECountryName");
            ReceiptCDItemDataTable.Columns.Add("FK_GECountryID");
            #endregion

            #region Gỗ xẻ ván tươi
            GridBand freshLumberBand = new GridBand();
            freshLumberBand.Caption = "Gỗ xẻ ván tươi";

            banded.Bands.Add(freshLumberBand);
            //Khối lượng(m3) 
            CreateBandedColumn("Khối lượng(m3)", "KLvantuoi", true, false, freshLumberBand, banded, false);
            ReceiptCDItemDataTable.Columns.Add("KLvantuoi");

            #endregion

            #region Khối lượng gỗ tròn m3
            GridBand ProductQtyRoundWoodBand = new GridBand();
            ProductQtyRoundWoodBand.Caption = "Khối lượng gỗ tròn(m3)";

            banded.Bands.Add(ProductQtyRoundWoodBand);
            //Theo loglist
            CreateBandedColumn("Theo loglist", "KLtheoLoglist", true, false, ProductQtyRoundWoodBand, banded, false);
            ReceiptCDItemDataTable.Columns.Add("KLtheoLoglist");

            //Nhập theo kho
            CreateBandedColumn("Nhập theo kho", "KLtheoKho", true, false, ProductQtyRoundWoodBand, banded, false);
            ReceiptCDItemDataTable.Columns.Add("KLtheoKho");


            //Theo CD
            CreateBandedColumn("Theo CD", "KLtheoCD", true, false, ProductQtyRoundWoodBand, banded, false);
            ReceiptCDItemDataTable.Columns.Add("KLtheoCD");

            #endregion

            #region Tỷ lệ thu hồi
            GridBand TLTHBand = new GridBand();
            TLTHBand.Caption = "Tỷ lệ thu hồi";
            //TLTHBand.Fixed = FixedStyle.Left;

            banded.Bands.Add(TLTHBand);
            //Theo loglist
            CreateBandedColumn("Theo loglist", "TLTHtheoLoglist", true, false, TLTHBand, banded, false);
            ReceiptCDItemDataTable.Columns.Add("TLTHtheoLoglist");

            //Nhập theo kho
            CreateBandedColumn("Nhập theo kho", "TLTHtheoKho", true, false, TLTHBand, banded, false);
            ReceiptCDItemDataTable.Columns.Add("TLTHtheoKho");

            //Theo CD
            CreateBandedColumn("Theo CD", "TLTHtheoCD", true, false, TLTHBand, banded, false);
            ReceiptCDItemDataTable.Columns.Add("TLTHtheoCD");
            #endregion
            banded.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(banded_FocusedRowChanged);
            return banded;
        }

        void banded_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //throw new NotImplementedException();
            ICReceiptCDItemsController objReceiptCDItemsController = new ICReceiptCDItemsController();
            BandedGridView BandedgridView = (BandedGridView)sender;
            int supplierID = 0;
            int productAttributeTTMTID = 0;
            int productAttributeWoodTypeID = 0;
            int countryID = 0;
            string lotno = string.Empty;
            decimal KLvantuoi = 0;
            if (BandedgridView.FocusedColumn != null)
            {
                if (BandedgridView.FocusedRowHandle >= 0)
                {
                    DataRow row = (DataRow)BandedgridView.GetDataRow(BandedgridView.FocusedRowHandle);
                    if (row["FK_APSupplierID"] != null)
                    {
                        int.TryParse(row["FK_APSupplierID"].ToString(), out supplierID);
                    }
                    if (row["FK_ICProductAttributeTTMTID"] != null)
                    {
                        int.TryParse(row["FK_ICProductAttributeTTMTID"].ToString(), out productAttributeTTMTID);
                    }
                    if (row["FK_ICProductAttributeWoodTypeID"] != null)
                    {
                        int.TryParse(row["FK_ICProductAttributeWoodTypeID"].ToString(), out productAttributeWoodTypeID);
                    }
                    if (row["FK_GECountryID"] != null)
                    {
                        int.TryParse(row["FK_GECountryID"].ToString(), out countryID);
                    }
                    if (row["ICReceiptCDLotNo"] != null)
                    {
                        lotno = row["ICReceiptCDLotNo"].ToString();
                    }
                    if (row["KLvantuoi"] != null)
                    {
                        decimal.TryParse(row["KLvantuoi"].ToString(), out KLvantuoi);
                    }
                    List<ICReceiptCDItemsInfo> listReceiptCDItem = objReceiptCDItemsController.GetReceiptCDItemForReport145detail(supplierID, productAttributeTTMTID, productAttributeWoodTypeID, countryID, lotno);
                    if (listReceiptCDItem.Count > 0)
                    {
                        foreach (ICReceiptCDItemsInfo item in listReceiptCDItem)
                        {
                            item.ProductQuality = decimal.Parse(((item.ICReceiptCDItemProductQty / KLvantuoi) * 100).ToString("n2"));
                        }
                    }
                    fld_dgcICReceiptCDITemdetail.DataSource = listReceiptCDItem;
                }

            }
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