using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.SemiProductIngredient
{
    public partial class ShowIngredientCostDDGridControl : BOSGridControl
    {

        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = BaseLocalizedResources.Select;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Insert(0, column);
            column.VisibleIndex = 0;

            column = new GridColumn();
            column.FieldName = "MMProductionCostIngredientCostReferenceNo";
            column.Caption = "Mã chứng từ";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMProductionCostIngredientCostBatchProductNo";
            column.Caption = "Lệnh sản xuất";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMProductionCostIngredientCostOperationName";
            column.Caption = "Công đoạn";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMProductionCostIngredientCostMeasureUnitName";
            column.Caption = "Đơn vị tính";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMProductionCostIngredientCostStockName";
            column.Caption = "Kho";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMProductionCostIngredientCostProductNo";
            column.Caption = "Mã sản phẩm";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMProductionCostIngredientCostProductName";
            column.Caption = "Tên sản phẩm";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMProductionCostIngredientCostProductDesc";
            column.Caption = "Mô tả";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMProductionCostIngredientCostProductQty";
            column.Caption = "Số lượng";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMProductionCostIngredientCostProductUnitCost";
            column.Caption = "Đơn giá";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMProductionCostIngredientCostTotalCost";
            column.Caption = "Thành tiền";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMProductionCostIngredientCostProductWoodQty";
            column.Caption = "Khối lượng tinh (m3)";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            return gridView;
        }
    }
}
