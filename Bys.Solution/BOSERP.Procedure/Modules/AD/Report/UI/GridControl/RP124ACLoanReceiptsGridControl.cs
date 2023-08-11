using BOSComponent;
using DevExpress.XtraGrid.Columns;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public class RP124ACLoanReceiptsGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "ACLoanReceiptNo";
            column.Caption = ReportLocalizedResources.ACLoanReceiptNo;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ACLoanAgreementNo";
            column.Caption = ReportLocalizedResources.ACLoanAgreementNo;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ACLoanAgreementDesc";
            column.Caption = ReportLocalizedResources.ACLoanAgreementDesc;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ACLoanReceiptDate";
            column.Caption = ReportLocalizedResources.ACLoanReceiptDate;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ACLoanReceiptDeadline";
            column.Caption = ReportLocalizedResources.ACLoanReceiptDeadline;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ACLoanReceiptMonthRate";
            column.Caption = ReportLocalizedResources.ACLoanReceiptMonthRate;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ACLoanReceiptAmountNT";
            column.Caption = ReportLocalizedResources.ACLoanReceiptAmountNT;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ACLoanReceiptExchangeAmount";
            column.Caption = ReportLocalizedResources.ACLoanReceiptExchangeAmount;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "GECurrencyName";
            column.Caption = ReportLocalizedResources.GECurrencyName;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "DuDauKy";
            column.Caption = ReportLocalizedResources.DuDauKy;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 10;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "DuCuoiKy";
            column.Caption = ReportLocalizedResources.DuCuoiKy;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 11;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "AccountNo";
            column.Caption = ReportLocalizedResources.AccountNo;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 12;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "CSCompanyBankName";
            column.Caption = ReportLocalizedResources.CSCompanyBankName;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 13;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ACLoanReceiptInterestRate";
            column.Caption = ReportLocalizedResources.ACLoanReceiptInterestRate;
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 14;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ACLoanReceiptPaidExchangeAmount";
            column.Caption = ReportLocalizedResources.ACLoanReceiptPaidExchangeAmount;
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 15;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "DuDauKyVND";
            column.Caption = ReportLocalizedResources.DuDauKyVND;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 16;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "DuCuoiKyVND";
            column.Caption = ReportLocalizedResources.DuCuoiKyVND;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 17;
            gridView.Columns.Add(column);
        }
        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            DateTime value = DateTime.Now;
            if (e.CellValue != null && (e.Column.FieldName == "ACLoanReceiptDate" || e.Column.FieldName == "ACLoanReceiptDeadline"))
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
