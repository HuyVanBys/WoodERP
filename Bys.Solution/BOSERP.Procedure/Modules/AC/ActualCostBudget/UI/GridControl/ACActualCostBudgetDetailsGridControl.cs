using BOSCommon;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.ActualCostBudget
{
    public class ACActualCostBudgetDetailsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ActualCostBudgetEntities entity = (ActualCostBudgetEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ACActualCostBudgetDetailsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;

            }
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.InitNewRow += new InitNewRowEventHandler(gridView1_InitNewRow);
        }

        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            ActualCostBudgetEntities entity = (ActualCostBudgetEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            ACActualCostBudgetsInfo revenueBudget = (ACActualCostBudgetsInfo)entity.MainObject;
            ACActualCostBudgetDetailsInfo revenueBudgetDetail = (ACActualCostBudgetDetailsInfo)view.GetRow(e.RowHandle);
            if (revenueBudgetDetail != null)
            {
                revenueBudgetDetail.FK_GECurrencyID = revenueBudget.FK_GECurrencyID;
                revenueBudgetDetail.ACActualCostBudgetDetailExchangeRate = revenueBudget.ACActualCostBudgetExchangeRate;

                if (((ActualCostBudgetModule)Screen.Module).Toolbar.IsNullOrNoneAction() && revenueBudget.ACActualCostBudgetStatus == ActualCostBudgetStatus.New.ToString())
                {
                    ((ActualCostBudgetModule)Screen.Module).ActionEdit();

                    entity.ACActualCostBudgetDetailsList.Add(revenueBudgetDetail);
                    entity.ACActualCostBudgetDetailsList.GridControl.RefreshDataSource();
                    view.FocusedRowHandle = e.RowHandle;
                }
            }


        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ActualCostBudgetModule)Screen.Module).DeleteItemFromActualCostBudgetDetailsList();
            }
        }

    }
}
