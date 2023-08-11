using BOSLib;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace BOSERP.Modules.Report
{
    public partial class RP215 : ReportForm
    {
        public DataTable invoiceDataTable;
        public DataSet dsCustomer;
        public RP215()
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
        private void RP215_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
            fld_dteSearchFromDateTl.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDateTL.DateTime = BOSUtil.GetMonthEndDate();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowReportData()
        {
            ADReportsController objReportsController = new ADReportsController();
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            DateTime datefromTl = fld_dteSearchFromDateTl.DateTime;
            DateTime dateToTL = fld_dteSearchToDateTL.DateTime;
            int customerID = 0;
            if (fld_lkeARCustomerID.EditValue != null)
                Int32.TryParse(fld_lkeARCustomerID.EditValue.ToString(), out customerID);
            fld_dgcReport231.MainView = GenerateBandedGridView();
            List<ADReportsInfo> invoiceList = objReportsController.GetRP215(customerID, dateFrom, dateTo, datefromTl, dateToTL);
            List<ADReportsInfo> saleOrderList = objReportsController.GetRP215PI(customerID, datefromTl, dateToTL);
            List<ADReportsInfo> batchProductList = objReportsController.GetRP215LSX(customerID, datefromTl, dateToTL);
            InitinvoiceDataRow(invoiceList, saleOrderList, batchProductList);
            fld_dgcReport231.DataSource = invoiceDataTable;
            GridView gridView = (GridView)fld_dgcReport231.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.BestFitColumns();
        }
        public BandedGridView GenerateBandedGridView()
        {
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            bool checkInvoiceDate = false;
            if (fld_dteSearchFromDateTl.DateTime.Month < fld_dteSearchFromDate.DateTime.Month)
            {
                dateFrom = fld_dteSearchFromDateTl.DateTime;
            }
            if (fld_dteSearchToDate.DateTime.Month < fld_dteSearchToDateTL.DateTime.Month)
            {
                dateTo = fld_dteSearchToDateTL.DateTime;
            }
            if (fld_dteSearchFromDate.DateTime.Date == DateTime.MaxValue.Date
                || fld_dteSearchToDate.DateTime.Date == DateTime.MaxValue.Date)
            {
                checkInvoiceDate = true;
                dateFrom = fld_dteSearchFromDateTl.DateTime;
                dateTo = fld_dteSearchToDateTL.DateTime;
            }

            DateTime datefromDefault = dateFrom;
            BandedGridView banded = new BandedGridView();
            banded.OptionsCustomization.AllowFilter = false;
            banded.OptionsView.ColumnAutoWidth = false;
            banded.OptionsView.ShowGroupPanel = false;
            banded.OptionsView.ShowFooter = true;

            invoiceDataTable = new DataTable();
            GridBand headerBand = new GridBand();
            headerBand.Caption = "Kế hoạch đơn hàng dự kiến và doanh thu dự kiến";
            headerBand.AppearanceHeader.Options.UseTextOptions = true;
            headerBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            banded.Bands.Add(headerBand);


            #region Thông tin chung


            GridBand generalBand = new GridBand();
            generalBand.Caption = "Thông tin chung";
            generalBand.AppearanceHeader.Options.UseTextOptions = true;
            generalBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            headerBand.Children.Add(generalBand);

            //Khách hàng
            CreateBandedColumn("Khách hàng", "ARCustomerName", true, false, generalBand, banded, false);
            invoiceDataTable.Columns.Add("ARCustomerName", typeof(string));
            //Mã Sản phẩm
            CreateBandedColumn("Mã Sản phẩm", "ICProductNo", true, false, generalBand, banded, false);
            invoiceDataTable.Columns.Add("ICProductNo", typeof(string));
            //Tên Sản phẩm
            CreateBandedColumn("Tên Sản phẩm", "ICProductName", true, false, generalBand, banded, false);
            invoiceDataTable.Columns.Add("ICProductName", typeof(string));

            generalBand.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            #endregion

            #region  tháng                        
            while (dateFrom.Month <= dateTo.Month && dateFrom.Year == datefromDefault.Year)
            {
                GridBand mothBand = new GridBand();
                mothBand.Caption = "Tháng " + dateFrom.Month;
                mothBand.AppearanceHeader.Options.UseTextOptions = true;
                mothBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                headerBand.Children.Add(mothBand);
                if (!checkInvoiceDate)
                {
                    //Số lượng PG
                    CreateBandedColumnAmount("PG", "ICProductQtyPG_" + dateFrom.Month, true, false, mothBand, banded, false);
                    invoiceDataTable.Columns.Add("ICProductQtyPG_" + dateFrom.Month, typeof(decimal));
                }
                //Số lượng PI
                CreateBandedColumnAmount("PI", "ICProductQtyPI_" + dateFrom.Month, true, false, mothBand, banded, false);
                invoiceDataTable.Columns.Add("ICProductQtyPI_" + dateFrom.Month, typeof(decimal));
                //Số lượng khối tinh
                CreateBandedColumnNumer("khối tinh", "MMBatchProductBlock_" + dateFrom.Month, true, false, mothBand, banded, false);
                invoiceDataTable.Columns.Add("MMBatchProductBlock_" + dateFrom.Month, typeof(decimal));
                dateFrom = dateFrom.AddMonths(1);
            }
            #endregion
            #region Tổng giá trị
            GridBand total = new GridBand();
            total.Caption = "Tổng giá trị";
            total.AppearanceHeader.Options.UseTextOptions = true;
            total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            headerBand.Children.Add(total);
            if (!checkInvoiceDate)
            {
                //Tổng SL PG
                CreateBandedColumnAmount("Tổng số lượng PG", "ICARInvoiceTotalQty", true, false, total, banded, false);
                invoiceDataTable.Columns.Add("ICARInvoiceTotalQty", typeof(decimal));
                //Tổng giá trị PG
                CreateBandedColumnAmount("Tổng giá trị PG", "ICARInvoiceTotalAmount", true, false, total, banded, false);
                invoiceDataTable.Columns.Add("ICARInvoiceTotalAmount", typeof(decimal));
            }
            //Tổng SL PI
            CreateBandedColumnAmount("Tổng số lượng PI", "ARSaleOrderTotalQty", true, false, total, banded, false);
            invoiceDataTable.Columns.Add("ARSaleOrderTotalQty", typeof(decimal));
            //Tổng giá trị PI
            CreateBandedColumnAmount("Tổng giá trị PI", "ARSaleOrderAmount", true, false, total, banded, false);
            invoiceDataTable.Columns.Add("ARSaleOrderAmount", typeof(decimal));
            //Tổng khối tinh
            CreateBandedColumnNumer("Tổng khối tinh", "MMBatchTotalBlock", true, false, total, banded, false);
            invoiceDataTable.Columns.Add("MMBatchTotalBlock", typeof(decimal));
            #endregion
            return banded;
        }
        public void CreateBandedColumn(string caption, string fieldName, bool visible, bool allowEdit, GridBand ownerBand, BandedGridView banded, bool group)
        {
            BandedGridColumn column = new BandedGridColumn();
            column.Caption = caption;
            column.FieldName = fieldName;
            column.Visible = visible;
            column.OptionsColumn.AllowEdit = allowEdit;
            column.OwnerBand = ownerBand;
            if (group)
            {
                column.Group();
            }
            banded.Columns.Add(column);
        }
        public void CreateBandedColumnAmount(string caption, string fieldName, bool visible, bool allowEdit, GridBand ownerBand, BandedGridView banded, bool group)
        {
            BandedGridColumn column = new BandedGridColumn();
            column.Caption = caption;
            column.FieldName = fieldName;
            column.Visible = visible;
            column.OptionsColumn.AllowEdit = allowEdit;
            column.OwnerBand = ownerBand;
            column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            column.SummaryItem.DisplayFormat = "{0:n0}";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n0}";
            banded.Columns.Add(column);
        }
        public void CreateBandedColumnNumer(string caption, string fieldName, bool visible, bool allowEdit, GridBand ownerBand, BandedGridView banded, bool group)
        {
            BandedGridColumn column = new BandedGridColumn();
            column.Caption = caption;
            column.FieldName = fieldName;
            column.Visible = visible;
            column.OptionsColumn.AllowEdit = allowEdit;
            column.OwnerBand = ownerBand;
            column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            column.SummaryItem.DisplayFormat = "{0:n0}";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n5}";
            banded.Columns.Add(column);
        }
        public void InitinvoiceDataRow(List<ADReportsInfo> ListItem, List<ADReportsInfo> saleOrderList, List<ADReportsInfo> batchProductList)
        {
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            bool checkInvoiceDate = false;
            if (fld_dteSearchFromDateTl.DateTime.Month < fld_dteSearchFromDate.DateTime.Month)
            {
                dateFrom = fld_dteSearchFromDateTl.DateTime;
            }
            if (fld_dteSearchToDate.DateTime.Month < fld_dteSearchToDateTL.DateTime.Month)
            {
                dateTo = fld_dteSearchToDateTL.DateTime;
            }
            if (fld_dteSearchFromDate.DateTime.Date == DateTime.MaxValue.Date
                || fld_dteSearchToDate.DateTime.Date == DateTime.MaxValue.Date)
            {
                checkInvoiceDate = true;
                dateFrom = fld_dteSearchFromDateTl.DateTime;
                dateTo = fld_dteSearchToDateTL.DateTime;
            }
            if (invoiceDataTable == null)
            {
                invoiceDataTable = new DataTable();
            }

            //Split Customer From MultiCustomer BatchProduct
            batchProductList.ForEach(o =>
            {
                o.CustomerNameList = o.ARCustomerName.Split(',');
            });

            List<ADReportsInfo> TotalItemList = new List<ADReportsInfo>();
            if (saleOrderList != null && saleOrderList.Count > 0)
            {
                TotalItemList.AddRange(saleOrderList);
            }
            //if (ListItem != null && ListItem.Count > 0)
            //{
            //    TotalItemList.AddRange(ListItem);
            //}
            if (TotalItemList != null && TotalItemList.Count > 0)
            {
                List<ADReportsInfo> groupProductList = TotalItemList.GroupBy(a => new { a.ARCustomerName, a.ICProductNo, a.ICProductName })
                                                        .Select(a => new ADReportsInfo
                                                        {
                                                            ARCustomerName = a.Key.ARCustomerName,
                                                            ICProductNo = a.Key.ICProductNo,
                                                            ICProductName = a.Key.ICProductName
                                                        }).ToList();
                groupProductList.ForEach(a =>
                    {
                        DateTime from = dateFrom;
                        DataRow row = invoiceDataTable.NewRow();
                        decimal totalQty = 0;
                        decimal totalAmount = 0;
                        decimal totalQtyPI = 0;
                        decimal totalAmountPI = 0;
                        decimal totalBlock = 0;
                        row["ARCustomerName"] = a.ARCustomerName;
                        row["ICProductNo"] = a.ICProductNo;
                        row["ICProductName"] = a.ICProductName;

                        while (from.Month <= dateTo.Month && from.Year == dateFrom.Year)
                        {
                            decimal qty = ListItem.Where(b => b.ARCustomerName == a.ARCustomerName
                                                        && b.ICProductName == a.ICProductName
                                                        && b.ICProductNo == a.ICProductNo
                                                        && b.ARInvoiceDate.Month == from.Month)
                                                         .Sum(b => b.ARInvoiceItemProductQty);
                            decimal amount = ListItem.Where(b => b.ARCustomerName == a.ARCustomerName
                                                        && b.ICProductName == a.ICProductName
                                                        && b.ICProductNo == a.ICProductNo
                                                        && b.ARInvoiceDate.Month == from.Month)
                                                        .Sum(b => b.ARInvoiceTotalAmount);
                            decimal qtyPI = saleOrderList.Where(b => b.ARCustomerName == a.ARCustomerName
                                                                && b.ICProductName == a.ICProductName
                                                                && b.ICProductNo == a.ICProductNo
                                                                && b.ARSaleOrderDate.Month == from.Month)
                                                                 .Sum(b => b.ARSaleOrderItemProductQty);
                            decimal amountPI = saleOrderList.Where(b => b.ARCustomerName == a.ARCustomerName
                                                                && b.ICProductName == a.ICProductName
                                                                && b.ICProductNo == a.ICProductNo
                                                                && b.ARSaleOrderDate.Month == from.Month)
                                                                .Sum(b => b.ARSaleOrderItemTotalAmount);

                            decimal block = batchProductList.Where(b => b.ARCustomerName == a.ARCustomerName
                                                                && b.ICProductName == a.ICProductName
                                                                && b.ICProductNo == a.ICProductNo
                                                                && b.MMBatchProductItemDeliveryDate.Month == from.Month)
                                                                .Sum(b => b.MMBatchProductItemBlock);
                            if (!checkInvoiceDate)
                            {
                                row["ICProductQtyPG_" + from.Month] = qty;
                            }
                            row["ICProductQtyPI_" + from.Month] = qtyPI;
                            row["MMBatchProductBlock_" + from.Month] = block;
                            totalQty += qty;
                            totalAmount += amount;
                            totalQtyPI += qtyPI;
                            totalAmountPI += amountPI;
                            totalBlock += block;
                            from = from.AddMonths(1);
                        }
                        if (!checkInvoiceDate)
                        {
                            row["ICARInvoiceTotalQty"] = totalQty;
                            row["ICARInvoiceTotalAmount"] = totalAmount;
                        }
                        row["ARSaleOrderTotalQty"] = totalQtyPI;
                        row["ARSaleOrderAmount"] = totalAmountPI;
                        row["MMBatchTotalBlock"] = totalBlock;
                        invoiceDataTable.Rows.Add(row);
                    });
            }
        }
        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ShowReportData();
        }
        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)fld_dgcReport231.MainView;
            if (gridView != null)
            {
                ExportToXls(gridView);
            }
        }
    }
}