using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;
namespace BOSERP.Modules.OperationDetailPlanCancel
{
    public class MMOperationDetailPlanCancelItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            OperationDetailPlanCancelEntities entity = (OperationDetailPlanCancelEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.OperationDetailPlanCancelItemList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.GroupFormat = "[#image]{1} {2}";
            if (gridView.Columns["MMOperationDetailPlanCancelItemQty"] != null)
            {
                gridView.Columns["MMOperationDetailPlanCancelItemQty"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["MMOperationDetailPlanCancelItemProductSerial"] != null)
            {
                gridView.Columns["MMOperationDetailPlanCancelItemProductSerial"].Group();
            }

            if (gridView.Columns["FK_ICProductForBatchID"] != null)
            {
                gridView.Columns["FK_ICProductForBatchID"].Group();
            }

            if (gridView.Columns["MMOperationDetailPlanCancelItemParentNo"] != null)
            {
                gridView.Columns["MMOperationDetailPlanCancelItemParentNo"].Group();
            }


            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            return gridView;
        }

        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.BestFitColumns();
            gridView.ExpandAllGroups();
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((OperationDetailPlanCancelModule)Screen.Module).DeleteItemFromOperationDetailPlanCancelItemList();
            }
        }



    }
}
