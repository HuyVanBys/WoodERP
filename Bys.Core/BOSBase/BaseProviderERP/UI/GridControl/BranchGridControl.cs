using BOSComponent;
using DevExpress.XtraGrid.Columns;
using Localization;

namespace BOSERP
{
    public partial class BranchGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.FieldName = "Selected";
            column.Caption = BaseLocalizedResources.Selected;
            gridView.Columns.Add(column);
        }
    }
}
