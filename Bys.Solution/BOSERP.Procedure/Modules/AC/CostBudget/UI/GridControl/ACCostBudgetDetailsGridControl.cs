using BOSCommon;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.CostBudget
{
    public class ACCostBudgetDetailsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CostBudgetEntities entity = (CostBudgetEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ACCostBudgetDetailsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;

            }
            GridColumn column1 = gridView.Columns["ACCostBudgetDetailToDate"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = false;
            }
            column1 = gridView.Columns["ACCostBudgetDetailFromDate"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = false;
            }
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.InitNewRow += new InitNewRowEventHandler(gridView1_InitNewRow);
        }

        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            CostBudgetEntities entity = (CostBudgetEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            ACCostBudgetsInfo revenueBudget = (ACCostBudgetsInfo)entity.MainObject;
            ACCostBudgetDetailsInfo revenueBudgetDetail = (ACCostBudgetDetailsInfo)view.GetRow(e.RowHandle);
            if (revenueBudgetDetail != null)
            {
                revenueBudgetDetail.FK_GECurrencyID = revenueBudget.FK_GECurrencyID;
                revenueBudgetDetail.ACCostBudgetDetailExchangeRate = revenueBudget.ACCostBudgetExchangeRate;
                revenueBudgetDetail.ACCostBudgetDetailFromDate = revenueBudget.ACCostBudgetFromDate;
                revenueBudgetDetail.ACCostBudgetDetailToDate = revenueBudget.ACCostBudgetToDate;

                if (((CostBudgetModule)Screen.Module).Toolbar.IsNullOrNoneAction() && revenueBudget.ACCostBudgetStatus == CostBudgetStatus.New.ToString())
                {
                    ((CostBudgetModule)Screen.Module).ActionEdit();

                    entity.ACCostBudgetDetailsList.Add(revenueBudgetDetail);
                    entity.ACCostBudgetDetailsList.GridControl.RefreshDataSource();
                    view.FocusedRowHandle = e.RowHandle;
                }
            }


        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((CostBudgetModule)Screen.Module).DeleteItemFromCostBudgetDetailsList();
            }
        }

    }
}
