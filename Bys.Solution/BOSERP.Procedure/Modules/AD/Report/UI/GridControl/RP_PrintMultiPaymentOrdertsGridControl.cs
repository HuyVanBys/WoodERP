using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public class RP_PrintMultiPaymentOrdertsGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            column = new GridColumn();
            column.Caption = "Mã chứng từ";
            column.FieldName = "ACBankTransactionNo";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày chứng từ";
            column.FieldName = "ACBankTransactionDate";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mô tả";
            column.FieldName = "ACBankTransactionDesc";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên NCC";
            column.FieldName = "APSupplierName";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số tiền trên hóa đơn";
            column.FieldName = "APPaymentProposalPaymentTotalAmount";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số tiền giải ngân";
            column.FieldName = "APPaymentProposalPaymentAmount";
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã hóa đơn";
            column.FieldName = "APInvoiceInNo";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Hạn thanh toán";
            column.FieldName = "ARSaleOrderPaymentTimeDueDate";
            column.DisplayFormat.FormatType = FormatType.DateTime;
            column.DisplayFormat.FormatString = "{0:dd/MM/yyyy}";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngân hàng";
            column.FieldName = "CSCompanyBankName";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = new GridColumn();
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            //column.Caption = BaseLocalizedResources.Select;
            //column.FieldName = "Selected";
            //column.OptionsColumn.AllowEdit = true;
            //gridView.Columns.Insert(0, column);
            //column.VisibleIndex = 0;      
            gridView.ExpandAllGroups();
            return gridView;
        }
        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            gridView.ExpandAllGroups();
        }
    }
}
