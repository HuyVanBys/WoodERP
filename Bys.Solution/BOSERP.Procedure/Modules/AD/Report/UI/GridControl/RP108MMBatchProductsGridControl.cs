using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public partial class RP108MMBatchProductsGridControl : BOSGridControl
    {


        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowAutoFilterRow = true;
            return gridView;
        }
    }
}
