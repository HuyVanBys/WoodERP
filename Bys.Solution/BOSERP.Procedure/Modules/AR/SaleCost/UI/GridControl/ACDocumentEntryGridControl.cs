using DevExpress.XtraGrid.Columns;

namespace BOSERP.Modules.SaleCost.UI
{
    public partial class ACDocumentEntryGridControl : BaseDocumentEntryGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Số hóa đơn";
            column.FieldName = "ACDocumentVoucherNo";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mẫu số";
            column.FieldName = "ACDocumentVATFormNo";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ký hiệu";
            column.FieldName = "ACDocumentVATSymbol";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tiền trước VAT";
            column.FieldName = "ACDocumentBeforeVATPrice";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tiền sau VAT";
            column.FieldName = "ACDocumentAfterVATPrice";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            if (gridView.Columns["ACDocumentEntryDesc"] != null)
            {
                gridView.Columns["ACDocumentEntryDesc"].OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }
    }
}

