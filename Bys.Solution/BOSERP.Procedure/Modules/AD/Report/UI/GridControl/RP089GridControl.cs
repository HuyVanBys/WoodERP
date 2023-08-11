using BOSComponent;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP089GridControl : BOSGridControl
    {
        /// <summary>
        /// Gets or sets the grid view main
        /// </summary>
        public GridView GridViewMain { get; set; }

        public override void InitializeControl()
        {
            base.InitializeControl();
            BandedGridView bandedView = InitializeBandedGridView(GridViewMain);
            MainView = bandedView;
            ViewCollection.AddRange(new BaseView[] { bandedView });
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

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
            RP089 screen = Screen as RP089;
            BandedGridView bandedView = screen.InitBandedGridView(gridView);
            bandedView.EndSorting += new EventHandler(bandedView_EndSorting);
            return bandedView;
        }

        void bandedView_EndSorting(object sender, EventArgs e)
        {
            (sender as BandedGridView).ExpandAllGroups();
        }


        public void RefreshDataSource(DataTable datatable)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = datatable;
            DataSource = bds;
        }

    }
}
