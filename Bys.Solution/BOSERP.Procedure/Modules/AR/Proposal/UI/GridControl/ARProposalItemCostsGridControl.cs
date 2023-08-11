using System.Windows.Forms;

namespace BOSERP.Modules.Proposal
{
    public class ARProposalItemCostsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            ProposalEntities entity = (ProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARProposalItemCostList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            if (gridView.Columns["ARProposalItemWorkProductQty"] != null)
            {
                gridView.Columns["ARProposalItemWorkProductQty"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ARProposalItemWorkProductUnitPrice"] != null)
            {
                gridView.Columns["ARProposalItemWorkProductUnitPrice"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ARProposalItemWorkDiscountAmount"] != null)
            {
                gridView.Columns["ARProposalItemWorkDiscountAmount"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ARProposalItemWorkDiscountPerCent"] != null)
            {
                gridView.Columns["ARProposalItemWorkDiscountPerCent"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["ARProposalItemWorkComment"] != null)
            {
                gridView.Columns["ARProposalItemWorkComment"].OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ProposalModule)Screen.Module).DeleteItemProposalItemWorkItemChargesList();
            }
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            ProposalEntities entity = (ProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ARProposalItemCostList.CurrentIndex >= 0)
            {
                ARProposalItemWorksInfo item = entity.ARProposalItemCostList[entity.ARProposalItemCostList.CurrentIndex];
                if (e.Column.FieldName == "ARProposalItemWorkProductQty")
                {
                    ((ProposalModule)Screen.Module).ChangeQty(item);
                }
                if (e.Column.FieldName == "ARProposalItemWorkProductUnitPrice")
                {
                    ((ProposalModule)Screen.Module).ChangeQty(item);
                }
                if (e.Column.FieldName == "ARProposalItemWorkDiscountAmount")
                {
                    ((ProposalModule)Screen.Module).ChangeProposalItemCostDiscountAmount();
                }
                if (e.Column.FieldName == "ARProposalItemWorkDiscountPerCent")
                {
                    ((ProposalModule)Screen.Module).ChangeProposalItemCostDiscountPerCent();
                }
            }
        }
    }
}