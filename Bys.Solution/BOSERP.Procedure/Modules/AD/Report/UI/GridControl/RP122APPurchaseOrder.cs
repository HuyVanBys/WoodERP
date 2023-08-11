using BOSComponent;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public class RP122APPurchseOrderGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.FieldName = "GECurrencyNo";
            column.Caption = ReportLocalizedResources.GECurrencyNo;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APSupplierNo";
            column.Caption = "Mã NCC";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APSupplierName";
            column.Caption = "Tên NCC";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "HREmployessName";
            column.Caption = "Nhân viên mua hàng";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "PurchaseOrderNo";
            column.Caption = "Số đơn hàng";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APInvoiceInSupplierNo";
            column.Caption = "Số hóa đơn";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "PurchaseOrdertotalAmount";
            column.Caption = "Số tiền trên đơn hàng";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APPaymentMethodCombo";
            column.Caption = "Điều khoản thanh toán";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APPurchaseOrderPaymentTimeAmountDeposit";
            column.Caption = "Số tiền đặt cọc";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "PurchaseOrderPaymentTimeDateDeposit";
            column.Caption = "Ngày đặt cọc";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APInvoiceInNo";
            column.Caption = "Hóa đơn";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 10;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APInvoiceIntotalAmount";
            column.Caption = "Số tiền hóa đơn";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 11;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APInvoiceVATIndate";
            column.Caption = "Ngày xác nhận nợ";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 12;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "NgayToiHan";
            column.Caption = "Ngày tới hạn";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 13;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APInvoiceIndate";
            column.Caption = "Ngày tạo hóa đơn";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 14;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Notronghan";
            column.Caption = "Nợ trong hạn";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 15;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Noqua5den15ngay";
            column.Caption = "Số nợ quá hạn 5-15 ngày";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 16;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Noqua16den30ngay";
            column.Caption = "Số nợ quá hạn 16-30 ngày";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 17;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Noquatren30ngay";
            column.Caption = "Số nợ quá hạn quá 30 ngày";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 18;
            gridView.Columns.Add(column);
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;
            GridGroupSummaryItem item = new GridGroupSummaryItem();
            item.FieldName = "PurchaseOrdertotalAmount";
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item.DisplayFormat = "{0:N0}";
            gridView.GroupSummary.Add(item);
            item.ShowInGroupColumnFooter = gridView.Columns["PurchaseOrdertotalAmount"];
            InitColumnSummary("PurchaseOrdertotalAmount", DevExpress.Data.SummaryItemType.Sum);

            item = new GridGroupSummaryItem();
            item.FieldName = "APPurchaseOrderPaymentTimeAmountDeposit";
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item.DisplayFormat = "{0:N0}";
            gridView.GroupSummary.Add(item);
            item.ShowInGroupColumnFooter = gridView.Columns["APPurchaseOrderPaymentTimeAmountDeposit"];
            InitColumnSummary("APPurchaseOrderPaymentTimeAmountDeposit", DevExpress.Data.SummaryItemType.Sum);

            item = new GridGroupSummaryItem();
            item.FieldName = "APInvoiceIntotalAmount";
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item.DisplayFormat = "{0:N0}";
            gridView.GroupSummary.Add(item);
            item.ShowInGroupColumnFooter = gridView.Columns["APInvoiceIntotalAmount"];
            InitColumnSummary("APInvoiceIntotalAmount", DevExpress.Data.SummaryItemType.Sum);

            item = new GridGroupSummaryItem();
            item.FieldName = "Notronghan";
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item.DisplayFormat = "{0:N0}";
            gridView.GroupSummary.Add(item);
            item.ShowInGroupColumnFooter = gridView.Columns["Notronghan"];
            InitColumnSummary("Notronghan", DevExpress.Data.SummaryItemType.Sum);

            item = new GridGroupSummaryItem();
            item.FieldName = "Noqua5den15ngay";
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item.DisplayFormat = "{0:N0}";
            gridView.GroupSummary.Add(item);
            item.ShowInGroupColumnFooter = gridView.Columns["Noqua5den15ngay"];
            InitColumnSummary("Noqua5den15ngay", DevExpress.Data.SummaryItemType.Sum);

            item = new GridGroupSummaryItem();
            item.FieldName = "Noqua16den30ngay";
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item.DisplayFormat = "{0:N0}";
            gridView.GroupSummary.Add(item);
            item.ShowInGroupColumnFooter = gridView.Columns["Noqua16den30ngay"];
            InitColumnSummary("Noqua16den30ngay", DevExpress.Data.SummaryItemType.Sum);

            item = new GridGroupSummaryItem();
            item.FieldName = "Noquatren30ngay";
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item.DisplayFormat = "{0:N0}";
            gridView.GroupSummary.Add(item);
            item.ShowInGroupColumnFooter = gridView.Columns["Noquatren30ngay"];
            InitColumnSummary("Noquatren30ngay", DevExpress.Data.SummaryItemType.Sum);

            GridColumn column = gridView.Columns["GECurrencyNo"];
            if (column != null)
            {
                column.Group();
            }
            return gridView;
        }
        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            DateTime value = DateTime.Now;
            if (e.CellValue != null && (e.Column.FieldName == "PurchaseOrderPaymentTimeDateDeposit"
                                        || e.Column.FieldName == "APInvoiceIndate"
                                        || e.Column.FieldName == "APInvoiceVATIndate"))
            {
                if (DateTime.TryParse(e.CellValue.ToString(), out value))
                {
                    if (value.Date == DateTime.MinValue.Date)
                    {
                        e.DisplayText = "";
                    }
                    if (value.Date == DateTime.MaxValue.Date)
                    {
                        e.DisplayText = "";
                    }
                }
            }

        }


    }
}
