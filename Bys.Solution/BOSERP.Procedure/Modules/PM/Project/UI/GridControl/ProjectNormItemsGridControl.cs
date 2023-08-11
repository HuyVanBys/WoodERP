using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Project
{
    public class ProjectNormItemsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<PMProjectNormItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            if (gridView.Columns["PMProjectNormItemQty"] != null)
            {
                gridView.Columns["PMProjectNormItemQty"].OptionsColumn.AllowEdit = true;
            }
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            gridView.OptionsView.ShowAutoFilterRow = true;
            return gridView;
        }

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            //ShowInventory();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }
    }
}
