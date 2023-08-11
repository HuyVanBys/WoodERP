using BOSComponent;
using DevExpress.XtraGrid.Columns;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductionCostCalculation
{
    public class MMProductionCostCalculationPricesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductionCostCalculationEntities entity = (ProductionCostCalculationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductionCostCalculationPricesList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn newColumn = new GridColumn();
            newColumn.Caption = "Mã HT cũ";
            newColumn.FieldName = "MMBatchProductItemProductNoOfOldSys";
            newColumn.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(newColumn);

            newColumn = new GridColumn();
            newColumn.Caption = "Mã đơn hàng nội bộ";
            newColumn.FieldName = "MMBatchProductItemSOName";
            newColumn.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(newColumn);
        }
    }
}
