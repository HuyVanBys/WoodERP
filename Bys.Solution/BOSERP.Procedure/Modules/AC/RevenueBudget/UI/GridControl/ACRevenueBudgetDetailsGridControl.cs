using BOSCommon;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.RevenueBudget
{
    public class ACRevenueBudgetDetailsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            RevenueBudgetEntities entity = (RevenueBudgetEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ACRevenueBudgetDetailsList;
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
            RevenueBudgetEntities entity = (RevenueBudgetEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            ACRevenueBudgetsInfo revenueBudget = (ACRevenueBudgetsInfo)entity.MainObject;
            ACRevenueBudgetDetailsInfo revenueBudgetDetail = (ACRevenueBudgetDetailsInfo)view.GetRow(e.RowHandle);
            if (revenueBudgetDetail != null)
            {
                revenueBudgetDetail.FK_GECurrencyID = revenueBudget.FK_GECurrencyID;
                revenueBudgetDetail.ACRevenueBudgetDetailExchangeRate = revenueBudget.ACRevenueBudgetExchangeRate;

                if (((RevenueBudgetModule)Screen.Module).Toolbar.IsNullOrNoneAction() && revenueBudget.ACRevenueBudgetStatus == RevenueBudgetStatus.New.ToString())
                {
                    ((RevenueBudgetModule)Screen.Module).ActionEdit();

                    entity.ACRevenueBudgetDetailsList.Add(revenueBudgetDetail);
                    entity.ACRevenueBudgetDetailsList.GridControl.RefreshDataSource();
                    view.FocusedRowHandle = e.RowHandle;
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((RevenueBudgetModule)Screen.Module).DeleteItemFromRevenueBudgetDetailsList();
            }
        }

    }
}
