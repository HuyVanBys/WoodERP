using DevExpress.XtraGrid.Columns;
using Localization;

namespace BOSERP
{
    public partial class BaseDocumentGridControl : BOSSearchResultsGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = CommonLocalizedResources.Object;
            column.FieldName = "ACObjectName";
            gridView.Columns.Add(column);
        }
    }
}
