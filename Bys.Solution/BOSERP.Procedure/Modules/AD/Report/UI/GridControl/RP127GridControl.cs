using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public partial class RP127GridControl : BOSGridControl
    {

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "APSupplierName";
            column.Caption = "NCC GỖ";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieNo";
            column.Caption = "MÃ ĐẦU LÓNG";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieLotNo";
            column.Caption = "MÃ LÔ";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieReceiptDate";
            column.Caption = "NGÀY NHẬP";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductAttributeWoodTypeName";
            column.Caption = "LOẠI GỖ";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieProductPerimeter80";
            column.Caption = "HOÀNH <800";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieProductPerimeter80110";
            column.Caption = "HOÀNH 800-1100";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieProductPerimeter110";
            column.Caption = "HOÀNH >1100";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieProductLength";
            column.Caption = "DÀI";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICInventoryStockQuantity";
            column.Caption = "M3 TỒN";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductAttributeQualityName";
            column.Caption = "CHẤT LƯỢNG";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieContainerNo";
            column.Caption = "SỐ CONT TỒN";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.FieldName = "ICStockName";
            column.Caption = "KHO";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);



            gridView.Columns.Add(column);
        }
        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            if (gridView.Columns["ICProductSerieProductPerimeter80"] != null)
            {
                SetFormat("ICProductSerieProductPerimeter80", "n3", gridView);
            }
            if (gridView.Columns["ICProductSerieProductPerimeter80110"] != null)
            {
                SetFormat("ICProductSerieProductPerimeter80110", "n3", gridView);
            }
            if (gridView.Columns["ICProductSerieProductPerimeter110"] != null)
            {
                SetFormat("ICProductSerieProductPerimeter110", "n3", gridView);
            }
            if (gridView.Columns["ICProductSerieProductLength"] != null)
            {
                SetFormat("ICProductSerieProductLength", "n3", gridView);
            }
            if (gridView.Columns["ICInventoryStockQuantity"] != null)
            {
                SetFormat("ICInventoryStockQuantity", "n3", gridView);
            }

            return gridView;
        }

    }
}
