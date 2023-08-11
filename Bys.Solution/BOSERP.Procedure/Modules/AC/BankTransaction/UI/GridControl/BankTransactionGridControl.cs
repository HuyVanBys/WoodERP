using DevExpress.XtraGrid.Columns;
using Localization;

namespace BOSERP.Modules.BankTransaction
{
    public partial class BankTransactionGridControl : BOSSearchResultsGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = BankTransactionLocalizedResources.ACObjectName;
            column.FieldName = "ACObjectName";
            gridView.Columns.Add(column);
        }
    }
}
