using BOSComponent;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public class ICProductWorkItemTasksGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<ICProductTasksInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            if (gridView.Columns["ICProductTaskQty"] != null)
            {
                gridView.Columns["ICProductTaskQty"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ICProductTaskTotalEstimatedDays"] != null)
            {
                gridView.Columns["ICProductTaskTotalEstimatedDays"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ICProductTaskTotalEstimatedHours"] != null)
            {
                gridView.Columns["ICProductTaskTotalEstimatedHours"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ICProductTaskEstimatedTotalCost"] != null)
            {
                gridView.Columns["ICProductTaskEstimatedTotalCost"].OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }
    }
}
