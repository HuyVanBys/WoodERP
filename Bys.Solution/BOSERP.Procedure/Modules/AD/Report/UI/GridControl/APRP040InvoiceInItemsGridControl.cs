using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public class APRP040InvoiceInItemsGridControl : ReportGridControl
    {
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["APInvoiceInItemProductQty"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n4}";
            }
            return gridView;
        }
        protected override void AddColumnsToGridView(String strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = ReportLocalizedResources.APInvoiceInNo;
            column.FieldName = "APInvoiceInNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APInvoiceInDate;
            column.FieldName = "APInvoiceInDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APInvoiceInValidateDate;
            column.FieldName = "APInvoiceInValidateDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APInvoiceInStatusDisplayText;
            column.FieldName = "APInvoiceInStatusDisplayText";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APInvoiceInPackNo;
            column.FieldName = "APInvoiceInPackNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APInvoiceInTotalCost;
            column.FieldName = "APInvoiceInTotalCost";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APInvoiceInDepositBalance;
            column.FieldName = "APInvoiceInDepositBalance";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APInvoiceInBalanceDue;
            column.FieldName = "APInvoiceInBalanceDue";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APInvoiceInPaymentAmount;
            column.FieldName = "APInvoiceInPaymentAmount";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APInvoiceInComment;
            column.FieldName = "APInvoiceInComment";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.GECurrencyName;
            column.FieldName = "GECurrencyName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APInvoiceInExchangeRate;
            column.FieldName = "APInvoiceInExchangeRate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
