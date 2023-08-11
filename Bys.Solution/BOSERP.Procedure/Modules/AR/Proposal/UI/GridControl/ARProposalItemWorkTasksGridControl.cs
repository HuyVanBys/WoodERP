using System.Windows.Forms;

namespace BOSERP.Modules.Proposal
{
    public class ARProposalItemWorkTasksGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            ProposalEntities entity = (ProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARProposalItemWorkTasksList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            if (gridView.Columns["ARProposalItemWorkTaskQty"] != null)
            {
                gridView.Columns["ARProposalItemWorkTaskQty"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["FK_HRDepartmentID"] != null)
            {
                gridView.Columns["FK_HRDepartmentID"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["ARProposalItemWorkTaskEstimatedTotalCost"] != null)
            {
                gridView.Columns["ARProposalItemWorkTaskEstimatedTotalCost"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["ARProposalItemWorkTaskTotalEstimatedDays"] != null)
            {
                gridView.Columns["ARProposalItemWorkTaskTotalEstimatedDays"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["ARProposalItemWorkTaskTotalEstimatedHours"] != null)
            {
                gridView.Columns["ARProposalItemWorkTaskTotalEstimatedHours"].OptionsColumn.AllowEdit = true;
            }

            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                //((SaleOrderModule)Screen.Module).DeleteItemFromSaleOrderItemWorkTaskList();
            }
        }
    }
}
