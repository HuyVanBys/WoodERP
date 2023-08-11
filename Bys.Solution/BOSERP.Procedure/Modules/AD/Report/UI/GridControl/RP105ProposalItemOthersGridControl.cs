using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.Report
{
    public partial class RP105ProposalItemOthersGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            //GridColumn column = new GridColumn();
            //column.Caption = ReportLocalizedResources.APInvoiceInPaymentAmount;
            //column.FieldName = "APInvoiceInPaymentAmount";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "APProposalItemProductQty")
                {
                    column.Caption = PurchaseProposalLocalizedResources.Quanlity;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                    column.Visible = true;
                }
                if (column.FieldName == "APProposalItemPurchaseOrderQty")
                {
                    column.Caption = PurchaseProposalLocalizedResources.APProposalItemPurchaseOrderQty1;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                    column.Visible = true;
                }
            }
            return gridView;
        }
    }
}
