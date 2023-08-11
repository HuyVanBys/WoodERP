using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public partial class ARRP87InvoiceItemsGridControl : ReportGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;
            InitColumnSummary("ARInvoiceItemTotalAmount", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("ICProductUnitCost", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("ICProductGrossProfit", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("ProductQty", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("ICProductPrice01", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("ICProductSupplierPrice", DevExpress.Data.SummaryItemType.Sum);
            return gridView;
        }

        protected override void AddColumnsToGridView(String strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            //column.Caption = ReportLocalizedResources.ARCustomerName;
            //column.FieldName = "ARCustomerName";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = ReportLocalizedResources.ARInvoiceNo;
            //column.FieldName = "ARInvoiceNo";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = ReportLocalizedResources.ARSellerName;
            //column.FieldName = "ARSellerName";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = ReportLocalizedResources.ARInvoiceTotalAmount;
            //column.FieldName = "ARInvoiceTotalAmount";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = ReportLocalizedResources.ARInvoiceDepositBalance;
            //column.FieldName = "ARInvoiceDepositBalance";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = ReportLocalizedResources.ARInvoiceBalanceDue;
            //column.FieldName = "ARInvoiceBalanceDue";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = ReportLocalizedResources.ARInvoicePaymentAmount;
            //column.FieldName = "ARInvoicePaymentAmount";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = ReportLocalizedResources.ARInvoiceReturnAmount;
            //column.FieldName = "ARInvoiceReturnAmount";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = ReportLocalizedResources.ARCustomerRepaid;
            //column.FieldName = "ARCustomerRepaid";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = ReportLocalizedResources.ARCustomerContactAddressLine3;
            //column.FieldName = "ARCustomerContactAddressLine3";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = ReportLocalizedResources.ARInvoiceDate;
            //column.FieldName = "ARInvoiceDate";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = ReportLocalizedResources.ARInvoiceStatus;
            //column.FieldName = "ARInvoiceStatusDisplayedText";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);
            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ARInvoiceItemTotalAmount;
            column.FieldName = "ARInvoiceItemTotalAmount";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "n0";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ICProductTotalUnitCost;
            column.FieldName = "ICProductUnitCost";
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

            //column = new GridColumn();
            //column.Caption = "Mã lô";
            //column.FieldName = "ICProductSerieNo";
            //column.OptionsColumn.AllowEdit = false;
            //column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            //column.DisplayFormat.FormatString = "n0";
            //gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.SupplierName;
            column.FieldName = "APSupplierName";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "n0";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.SupplierNo;
            column.FieldName = "APSupplierNo";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "n0";
            gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = "Kho";
            //column.FieldName = "ICStockName";
            //column.OptionsColumn.AllowEdit = false;
            //column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            //column.DisplayFormat.FormatString = "n0";
            //gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.TotalProductQty;
            column.FieldName = "ProductQty";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "n0";
            gridView.Columns.Add(column);
        }
    }
}
