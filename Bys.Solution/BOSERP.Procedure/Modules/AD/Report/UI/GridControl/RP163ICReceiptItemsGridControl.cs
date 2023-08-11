using DevExpress.XtraGrid.Columns;
using System;

namespace BOSERP.Modules.Report
{
    public partial class RP163ICReceitpItemsGridControl : ReportGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();

            column = gridView.Columns["FK_ICProductID"];
            if (column != null)
                gridView.Columns.Remove(column);

            column = gridView.Columns["FK_ICReceiptID"];
            if (column != null)
                gridView.Columns.Remove(column);

            //column.Caption = "Tháng, năm";
            //column.FieldName = "ThangNam";
            //column.OptionsColumn.AllowEdit = false;
            //column.VisibleIndex = 0;
            //gridView.Columns.Add(column);

            //column = new GridColumn();
            column.Caption = "Ngày nhập Lâm sản/Ngày nhận hàng";
            column.FieldName = "ReceiptDate";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã lô gỗ";
            column.FieldName = "ICReceiptItemLotNo";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Loại gỗ";
            column.FieldName = "ICReceiptItemProductName";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Khối lượng";
            column.FieldName = "ICReceiptItemProductQty";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "n4";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số lượng ( lóng/hộp/phách/thanh/tấm)";
            column.FieldName = "ICReceiptItemWoodQty";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "n0";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số hợp đồng/ PI";
            column.FieldName = "APPurchaseOrderContractNo";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày hợp đồng/ PI";
            column.FieldName = "PurchaseOrderContractDate";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số hóa đơn (Invoice)";
            column.FieldName = "ICReceiptInvoiceInNo";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày hóa đơn/ Invoice";
            column.FieldName = "APInvoiceInDateStr";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số tờ khai HQ nhập khẩu";
            column.FieldName = "APInvoiceInSupplierNo";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày tờ khai HQ nhập khẩu";
            column.FieldName = "InvoiceInVATDate";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 10;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "TTMT";
            column.FieldName = "ICProductAttributeTTMT";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 11;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nhà cung cấp";
            column.FieldName = "APSupplierName";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 12;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã chứng từ";
            column.FieldName = "ICReceiptNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã sản phẩm";
            column.FieldName = "ICProductNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();


            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "InvoiceInVATDate")
            {
                if (e.Value != null)
                {
                    DateTime date = DateTime.Parse(e.Value.ToString());
                    if (date.ToString("dd/MM/yyyy") == "31/12/9999" || date.ToString("dd/MM/yyyy") == "01/01/0001")
                    {
                        e.DisplayText = "";
                    }
                    else
                    {
                        e.DisplayText = date.ToString("dd/MM/yyyy");
                    }
                }
            }


            else if (e.Column.FieldName == "PurchaseOrderContractDate")
            {
                if (e.Value != null)
                {
                    DateTime date = DateTime.Parse(e.Value.ToString());
                    if (date.ToString("dd/MM/yyyy") == "31/12/9999" || date.ToString("dd/MM/yyyy") == "01/01/0001")
                    {
                        e.DisplayText = "";
                    }
                    else
                    {
                        e.DisplayText = date.ToString("dd/MM/yyyy");
                    }
                }
            }


        }
    }
}
