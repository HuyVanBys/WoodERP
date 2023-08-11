using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseProposal
{
    public partial class MMPurchasePlanItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PurchasePlanItemList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.EndGrouping += GridView_EndGrouping;
            GridColumn column = gridView.Columns["MMPurchasePlanItemQuantity"];
            if (column != null)
            {
                column.Caption = "Số lượng";
            }
            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.Group();
            }
            column = gridView.Columns["FK_MMPurchasePlanID"];
            if (column != null)
            {
                column.Group();
            }
            return gridView;
        }

        private void GridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            gridView.ExpandAllGroups();
        }
    }
}
