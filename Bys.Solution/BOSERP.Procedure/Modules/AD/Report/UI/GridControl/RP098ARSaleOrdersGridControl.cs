using BOSComponent;
using DevExpress.XtraGrid.Columns;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public class RP098ARSaleOrdersGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "ARCustomerName";
            column.Caption = ReportLocalizedResources.ARCustomerName;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportSaleOrderPONo";
            column.Caption = ReportLocalizedResources.SaleOrderPONo;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportSaleOrderNo";
            column.Caption = ReportLocalizedResources.SaleOrderNo;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportBatchProductNo";
            column.Caption = ReportLocalizedResources.BatchProductNo;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportDeliveryDate";
            column.Caption = ReportLocalizedResources.DeliveryDate;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportInvoiceDate";
            column.Caption = ReportLocalizedResources.InvoiceDate;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportPaymentTerm";
            column.Caption = ReportLocalizedResources.PaymentTerm;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportPlanDepositDate";
            column.Caption = ReportLocalizedResources.ReportCustomerDepositDate;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportRealDepositDate";
            column.Caption = ReportLocalizedResources.ReportRealDepositDate;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportTotalPlanDeposit";
            column.Caption = ReportLocalizedResources.TotalPlanPaymentTimeAmount;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportTotalRealDeposit";
            column.Caption = ReportLocalizedResources.TotalRealPaymentTimeDepositBalance;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportTotalPlanPayment";
            column.Caption = ReportLocalizedResources.TotalFinalPlanPaymentTimeAmount;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportTotalRealPayment";
            column.Caption = ReportLocalizedResources.TotalFinalRealPaymentTimeDepositBalance;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportOutOfDateAmountDepopsit";
            column.Caption = ReportLocalizedResources.ReportOutOfDateAmount;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportOutOfDayDeposit";
            column.Caption = ReportLocalizedResources.ReportOutOfDay;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportOutOfDateAmountPayment";
            column.Caption = ReportLocalizedResources.ReportOutOfDateAmountPayment;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportOutOfDayPayment";
            column.Caption = ReportLocalizedResources.ReportOutOfDayPayment;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

        }
        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            DateTime value = DateTime.Now;
            if (e.CellValue != null && (e.Column.FieldName == "ReportContractFromDate" || e.Column.FieldName == "ReportContractToDate"))
            {
                if (DateTime.TryParse(e.CellValue.ToString(), out value))
                {
                    if (value == DateTime.MinValue)
                    {
                        e.DisplayText = "";
                    }
                    if (value == DateTime.MaxValue)
                    {
                        e.DisplayText = "";
                    }
                }
            }

        }


    }
}
