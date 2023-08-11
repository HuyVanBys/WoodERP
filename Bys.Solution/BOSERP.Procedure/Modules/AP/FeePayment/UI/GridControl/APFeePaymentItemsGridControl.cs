using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace BOSERP.Modules.FeePayment
{
    public partial class APFeePaymentItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            FeePaymentEntities entity = (FeePaymentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.FeePaymentItemList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsCustomization.AllowSort = false;
            gridView.OptionsView.ShowFooter = true;
            GridColumn Column = gridView.Columns["APFeePaymentItemCostAttribution"];
            if (Column != null)
            {
                InitColumnSummary("APFeePaymentItemCostAttribution", DevExpress.Data.SummaryItemType.Sum);
            }
            return gridView;
        }

        public void LoadGridViewForAllocationCriteria(string allocationCriteria)
        {
            GridView gridView = (GridView)MainView;
            GridColumn column = gridView.Columns["APFeePaymentItemCostAttribution"];
            column = gridView.Columns["APFeePaymentItemCostAttribution"];
            if (column != null && column.FieldName == "APFeePaymentItemCostAttribution")
            {
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
            }
            gridView.BestFitColumns();
        }
    }
}
