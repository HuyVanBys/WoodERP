using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public partial class RP159ReceiptCDItemsGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();

            column.FieldName = "ICReceiptNo";
            column.Caption = "Mã chứng từ";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICReceiptPackNo";
            column.Caption = "Mã lô gỗ";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "GECountryName";
            column.Caption = "Nguồn gốc";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICReceiptHeight";
            column.Caption = "Dày ván tươi";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICReceiptItemProductQty";
            column.Caption = "Khối lượng(m3)";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 11;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICReceiptItemWoodQty";
            column.Caption = "Số lượng thanh";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 12;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.FieldName = "ICProductAttributeValue";
            column.Caption = "Chất lượng";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 13;
            gridView.Columns.Add(column);

        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowAutoFilterRow = true;
            return gridView;
        }
    }
}
