using BOSComponent;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductionCost
{
    public class MMProductionCostIngredientCostLRsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductionCostEntities entity = (ProductionCostEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductionCostIngredientCostListLR;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            //gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.GroupFormat = "[#image]{1} {2}";
            gridView.OptionsView.ShowFooter = true;
            GridColumn column = new GridColumn();

            column = gridView.Columns["MMProductionCostIngredientCostLRBatchProductNo"];
            if (column != null)
            {
                column.Group();
                column.GroupIndex = 0;
            }
            column = gridView.Columns["MMProductionCostIngredientCostLRReferenceType"];
            if (column != null)
            {
                column.Group();
                column.GroupIndex = 1;
            }
            column = gridView.Columns["MMProductionCostIngredientCostLRProductQty"];
            if (column != null)
            {
                column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                column.SummaryItem.DisplayFormat = "{0:N2}";

                GridGroupSummaryItem summaryItem = new GridGroupSummaryItem();
                summaryItem.FieldName = "MMProductionCostIngredientCostLRProductQty";
                summaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                summaryItem.DisplayFormat = "{0:N2}";
                summaryItem.ShowInGroupColumnFooter = column;
                gridView.GroupSummary.Add(summaryItem);
            }
            column = gridView.Columns["MMProductionCostIngredientCostLRTotalCost"];
            if (column != null)
            {
                column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                column.SummaryItem.DisplayFormat = "{0:N2}";

                GridGroupSummaryItem summaryItem = new GridGroupSummaryItem();
                summaryItem.FieldName = "MMProductionCostIngredientCostLRTotalCost";
                summaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                summaryItem.DisplayFormat = "{0:N4}";
                summaryItem.ShowInGroupColumnFooter = column;
                gridView.GroupSummary.Add(summaryItem);
            }

            column = gridView.Columns["MMProductionCostIngredientCostLRProductWoodQty"];
            if (column != null)
            {
                column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                column.SummaryItem.DisplayFormat = "{0:N2}";

                GridGroupSummaryItem summaryItem = new GridGroupSummaryItem();
                summaryItem.FieldName = "MMProductionCostIngredientCostLRProductWoodQty";
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
