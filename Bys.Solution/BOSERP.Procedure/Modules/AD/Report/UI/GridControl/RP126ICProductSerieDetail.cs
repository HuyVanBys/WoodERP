using BOSComponent;
using DevExpress.XtraGrid.Columns;

namespace BOSERP.Modules.Report
{
    public class RP126ICProductSerieDetail : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "ICProductSerieNo";
            column.Caption = "Mã kiện";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieProductDesc";
            column.Caption = "Mô tả";
            column.Visible = true;
            column.VisibleIndex = 2;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "WoodTypeName";
            column.Caption = "Loại gỗ";
            column.Visible = true;
            column.VisibleIndex = 3;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "QualityTypeName";
            column.Caption = "Chất lượng";
            column.Visible = true;
            column.VisibleIndex = 4;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieProductHeight";
            column.Caption = "Dày";
            column.Visible = true;
            column.VisibleIndex = 5;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieProductLength";
            column.Caption = "Dài";
            column.Visible = true;
            column.VisibleIndex = 6;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieProductWidth";
            column.Caption = "Rộng";
            column.Visible = true;
            column.VisibleIndex = 7;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieProductWidthMax";
            column.Caption = "Rộng(Max)";
            column.Visible = true;
            column.VisibleIndex = 8;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieProductLengthMax";
            column.Caption = "Dài(Max)";
            column.Visible = true;
            column.VisibleIndex = 9;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICStockName";
            column.Caption = "Kho";
            column.Visible = true;
            column.VisibleIndex = 10;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICInventoryStockQuantity";
            column.Caption = "Khối lượng";
            column.Visible = true;
            column.VisibleIndex = 11;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

        }

    }
}
