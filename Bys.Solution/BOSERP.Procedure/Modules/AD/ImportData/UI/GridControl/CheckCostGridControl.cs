using BOSComponent;
using BOSERP.Procedure.Modules.AD.ImportData;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.ImportData
{
    public partial class CheckCostGridControl : BOSGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            if (gridView.Columns["MMProductionCostCalculationNo"] != null)
                gridView.Columns["MMProductionCostCalculationNo"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["MMProductionCostCalculationNoUpdate"] != null)
                gridView.Columns["MMProductionCostCalculationNoUpdate"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["TongchiphiTranfer"] != null)
                gridView.Columns["TongchiphiTranfer"].OptionsColumn.AllowEdit = true;

            return gridView;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column = new GridColumn();
            column.Caption = "Chọn";
            column.FieldName = "Selected";
            RepositoryItemCheckEdit rep = new RepositoryItemCheckEdit();
            column.ColumnEdit = rep;
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);


        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            if (e.Column.FieldName == "MMProductionCostCalculationNoUpdate" && e.RowHandle >= 0)
            {
                CheckCostInfo obj = (CheckCostInfo)gridView.GetFocusedRow();
                if (obj != null && !string.IsNullOrEmpty(obj.MMProductionCostCalculationNoUpdate.TrimEnd()))
                {
                    MMProductionCostCalculationPricesInfo result = ((ImportDataModule)this.Screen.Module).GetReferPrice(obj);
                    if (result != null)
                    {
                        obj.MMProductionCostCalculationPriceReceiptQty = result.MMProductionCostCalculationPriceReceiptQty;
                        obj.MMProductionCostCalculationUnitCost = result.MMProductionCostCalculationUnitCost;
                        obj.MMProductionCostCalculationTotalCost = result.MMProductionCostCalculationTotalCost;
                    }
                }
            }
        }
    }
}
