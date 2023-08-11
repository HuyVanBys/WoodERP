using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductionCostCalculation
{
    public class MMProductionCostCalculationItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductionCostCalculationEntities entity = (ProductionCostCalculationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductionCostCalculationItemsList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "MMProductionCostCalculationItemType")
            {
                if (e.Value != null)
                {
                    e.DisplayText = ADConfigValueUtility.GetConfigTextByGroupAndValue("ProductionCostAllocationType", Convert.ToString(e.Value));
                }
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn col = gridView.Columns["FK_MMProductionCostFactorID"];
            if (col != null)
            {
                col.Group();
            }
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
        }

        public void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView != null)
            {
                gridView.ExpandAllGroups();
            }
        }
    }
}
