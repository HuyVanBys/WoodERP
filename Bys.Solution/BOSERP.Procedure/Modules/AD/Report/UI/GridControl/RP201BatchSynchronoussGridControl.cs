using BOSComponent;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public partial class RP201BatchSynchronoussGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }
        public GridView GridViewMain { get; set; }

        public override void InitializeControl()
        {
            base.InitializeControl();
            BandedGridView bandedView = InitializeBandedGridView(GridViewMain);
            MainView = bandedView;
            ViewCollection.AddRange(new BaseView[] { bandedView });
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridViewMain = gridView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            return gridView;
        }
        public BandedGridView InitializeBandedGridView(GridView gridView)
        {
            RP201 screen = Screen as RP201;
            BandedGridView bandedView = screen.InitBandedGridView();
            //  bandedView.EndSorting += new EventHandler(bandedView_EndSorting);
            return bandedView;
        }
    }
}
