using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrder
{
    public class ARSaleOrderItemWorkTasksGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            SaleOrderEntities entity = (SaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARSaleOrderItemWorkTaskList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            if (gridView.Columns["ARSaleOrderItemWorkTaskQty"] != null)
            {
                gridView.Columns["ARSaleOrderItemWorkTaskQty"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["FK_HRDepartmentID"] != null)
            {
                gridView.Columns["FK_HRDepartmentID"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["ARSaleOrderItemWorkTaskEstimatedTotalCost"] != null)
            {
                gridView.Columns["ARSaleOrderItemWorkTaskEstimatedTotalCost"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["ARSaleOrderItemWorkTaskTotalEstimatedDays"] != null)
            {
                gridView.Columns["ARSaleOrderItemWorkTaskTotalEstimatedDays"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["ARSaleOrderItemWorkTaskTotalEstimatedHours"] != null)
            {
                gridView.Columns["ARSaleOrderItemWorkTaskTotalEstimatedHours"].OptionsColumn.AllowEdit = true;
            }

            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((SaleOrderModule)Screen.Module).DeleteItemFromSaleOrderItemWorkTaskList();
            }
        }
    }
}
