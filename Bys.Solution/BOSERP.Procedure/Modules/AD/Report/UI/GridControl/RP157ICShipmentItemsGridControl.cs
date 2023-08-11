using DevExpress.XtraGrid.Columns;

namespace BOSERP.Modules.Report
{
    public partial class RP157ICShipmentItemsGridControl : ReportGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Mã lô";
            column.FieldName = "LotNo";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M3 Gỗ tròn(xuất kho)";
            column.FieldName = "ICShipmentItemProductQty";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M3 Gỗ tròn(CD)";
            column.FieldName = "M3nhapgotron";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M3 phách";
            column.FieldName = "M3gophach";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tổng dài theo invoice";
            column.FieldName = "ICShipmentItemLength";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tổng dài CD";
            column.FieldName = "tongdaiCD";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);
        }

    }
}
