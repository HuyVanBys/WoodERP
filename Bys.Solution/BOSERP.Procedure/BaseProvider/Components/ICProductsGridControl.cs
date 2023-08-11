using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP
{
    public partial class ICProductsGridControl : BOSComponent.BOSGridControl
    {
        protected override GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.GroupFormat = "[#image]{1} {2}";
            GridColumn column = gridView.Columns["FK_ICDepartmentID"];
            if (column != null)
            {
                column.Group();
            }
            column = gridView.Columns["FK_ICProductGroupID"];
            if (column != null)
            {
                column.Group();
            }
            return gridView;
        }
    }
}
