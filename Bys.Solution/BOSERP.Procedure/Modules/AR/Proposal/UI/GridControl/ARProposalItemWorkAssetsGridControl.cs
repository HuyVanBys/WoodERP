using System.Windows.Forms;

namespace BOSERP.Modules.Proposal
{
    public class ARProposalItemWorkAssetsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            ProposalEntities entity = (ProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARProposalItemWorkAssetList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            if (gridView.Columns["ARProposalItemWorkProductQty"] != null)
            {
                gridView.Columns["ARProposalItemWorkProductQty"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ARProposalItemWorkProductChargeCheck"] != null)
            {
                gridView.Columns["ARProposalItemWorkProductChargeCheck"].OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            ProposalEntities entity = (ProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ARProposalItemWorkAssetList.CurrentIndex >= 0)
            {
                ARProposalItemWorksInfo item = entity.ARProposalItemWorkAssetList[entity.ARProposalItemWorkAssetList.CurrentIndex];
                if (e.Column.FieldName == "ARProposalItemWorkProductQty")
                {
                    ((ProposalModule)Screen.Module).ChangeQty(item);
                }
                else if (e.Column.FieldName == "ARProposalItemWorkProductChargeCheck")
                {
                    ((ProposalModule)Screen.Module).ChangeChargeCheck(item);
                }

            }
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ProposalModule)Screen.Module).DeleteItemProposalItemWorkAssetItemsList();
            }
        }
    }
}