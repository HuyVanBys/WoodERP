using BOSComponent;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public class ICProductTasksGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            ProductEntities entity = (ProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICProductTaskList;
            this.DataSource = bds;
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

        //protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        //{
        //    base.GridView_KeyUp(sender, e);

        //    if (e.KeyCode == Keys.Delete)
        //    {
        //        ((ProductModule)Screen.Module).DeleteItemFromICProductTask();
        //    }
        //}
    }
}
