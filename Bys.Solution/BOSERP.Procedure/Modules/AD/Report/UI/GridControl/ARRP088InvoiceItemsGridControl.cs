using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public partial class ARRP088InvoiceItemsGridControl : ReportGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;
            InitColumnSummary("ARInvoiceTotalAmount", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("ARInvoiceDepositBalance", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("ARInvoiceBalanceDue", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("ARInvoicePaymentAmount", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("ARInvoiceReturnAmount", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("ARCustomerRepaid", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("ICProductUnitCost", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("ICProductGrossProfit", DevExpress.Data.SummaryItemType.Sum);
            return gridView;
        }

        protected override void AddColumnsToGridView(String strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = ReportLocalizedResources.ARCustomerName;
            column.FieldName = "ARCustomerName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ARInvoiceNo;
            column.FieldName = "ARInvoiceNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ARSellerName;
            column.FieldName = "ARSellerName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ARInvoiceTotalAmount;
            column.FieldName = "ARInvoiceTotalAmount";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ARInvoiceDepositBalance;
            column.FieldName = "ARInvoiceDepositBalance";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ARInvoiceBalanceDue;
            column.FieldName = "ARInvoiceBalanceDue";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ARInvoicePaymentAmount;
            column.FieldName = "ARInvoicePaymentAmount";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ARInvoiceReturnAmount;
            column.FieldName = "ARInvoiceReturnAmount";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ARCustomerRepaid;
            column.FieldName = "ARCustomerRepaid";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ARCustomerContactAddressLine3;
            column.FieldName = "ARCustomerContactAddressLine3";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ARInvoiceDate;
            column.FieldName = "ARInvoiceDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ARInvoiceStatus;
            column.FieldName = "ARInvoiceStatusDisplayedText";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ICProductUnitCost;
            column.FieldName = "ICProductUnitCost";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "n0";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ICProductTotalUnitCost;
            column.FieldName = "ICProductTotalUnitCost";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "n0";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ICProductGrossProfit;
            column.FieldName = "ICProductGrossProfit";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "n0";
            gridView.Columns.Add(column);
        }
    }
}
