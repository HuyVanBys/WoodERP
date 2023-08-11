using DevExpress.XtraGrid.Columns;
using Localization;

namespace BOSERP.Modules.PaymentCash
{
    public partial class PaymentCashGridControl : BOSSearchResultsGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = PaymentCashLocalizedResources.ACObjectName;
            column.FieldName = "ACObjectName";
            gridView.Columns.Add(column);
        }
    }
}
