using DevExpress.XtraGrid.Columns;
using Localization;

namespace BOSERP.Modules.PaymentOrder
{
    public partial class PaymentOrderGridControl : BOSSearchResultsGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = PaymentOrderLocalizedResources.ACObjectName;
            column.FieldName = "ACObjectName";
            gridView.Columns.Add(column);
        }
    }
}
