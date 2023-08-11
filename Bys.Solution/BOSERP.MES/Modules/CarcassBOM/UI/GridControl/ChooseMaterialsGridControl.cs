using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.CarcassBOM
{
    public partial class ChooseMaterialsGridControl : BOSGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridview = base.InitializeGridView();
            GridColumn column = gridview.Columns["FK_MMProductionNormID"];
            if (column != null) column.Group();
            return gridview;
        }
    }
}
