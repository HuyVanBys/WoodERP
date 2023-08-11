using BOSComponent;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductionCostCalculation
{
    public class MMProductionCostCalculationDetailCostsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductionCostCalculationEntities entity = (ProductionCostCalculationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MMProductionCostCalculationDetailCostsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.GroupFormat = "[#image]{1} {2}";
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = false;

            }

            GridColumn col = gridView.Columns["FK_MMProductionCostFactorID"];
            if (col != null)
            {
                col.Group();
            }

            GridGroupSummaryItem item = new GridGroupSummaryItem();
            item.FieldName = "MMProductionCostCalculationDetailCostValue";
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item.DisplayFormat = "{0:N0}";
            gridView.GroupSummary.Add(item);
            item.ShowInGroupColumnFooter = gridView.Columns["MMProductionCostCalculationDetailCostValue"];
            InitColumnSummary("MMProductionCostCalculationDetailCostValue", DevExpress.Data.SummaryItemType.Sum);

            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }
        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_MMProductionCostFactorID")
            {
                int id = 0;
                if (e.Value != null && int.TryParse(e.Value.ToString(), out id))
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMProductionCostFactors", "MMProductionCostFactorID", id, "MMProductionCostFactorName");
                }
            }
        }

        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView != null)
            {
                gridView.ExpandAllGroups();
            }
        }
    }
}
