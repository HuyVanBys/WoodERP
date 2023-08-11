using BOSComponent;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductionCost
{
    public class MMProductionCostIngredientIncompleteTCsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductionCostEntities entity = (ProductionCostEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductionCostIngredientCostListDDTC;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            //gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.GroupFormat = "[#image]{1} {2}";
            gridView.OptionsView.ShowFooter = true;
            GridColumn column = new GridColumn();

            column = gridView.Columns["MMProductionCostIngredientCostDDTCBatchProductNo"];
            if (column != null)
            {
                column.Group();
                column.GroupIndex = 0;
            }
            column = gridView.Columns["MMProductionCostIngredientCostDDTCReferenceType"];
            if (column != null)
            {
                column.Group();
                column.GroupIndex = 1;
            }
            column = gridView.Columns["MMProductionCostIngredientCostDDTCProductQty"];
            if (column != null)
            {
                column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                column.SummaryItem.DisplayFormat = "{0:N2}";

                GridGroupSummaryItem summaryItem = new GridGroupSummaryItem();
                summaryItem.FieldName = "MMProductionCostIngredientCostDDTCProductQty";
                summaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                summaryItem.DisplayFormat = "{0:N2}";
                summaryItem.ShowInGroupColumnFooter = column;
                gridView.GroupSummary.Add(summaryItem);
            }
            column = gridView.Columns["MMProductionCostIngredientCostDDTCTotalCost"];
            if (column != null)
            {
                column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                column.SummaryItem.DisplayFormat = "{0:N2}";

                GridGroupSummaryItem summaryItem = new GridGroupSummaryItem();
                summaryItem.FieldName = "MMProductionCostIngredientCostDDTCTotalCost";
                summaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                summaryItem.DisplayFormat = "{0:N4}";
                summaryItem.ShowInGroupColumnFooter = column;
                gridView.GroupSummary.Add(summaryItem);
            }

            gridView.ExpandAllGroups();
            return gridView;
        }

    }
}
