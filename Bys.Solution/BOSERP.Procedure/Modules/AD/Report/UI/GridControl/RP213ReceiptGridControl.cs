using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public partial class RP213ReceiptGridControl : BOSGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            return gridView;
        }

        public void CreateColumn(string caption, string fieldName, GridView gridView, bool formatQty, bool formatDate)
        {
            GridColumn column = new GridColumn();
            column.Caption = caption;
            column.FieldName = fieldName;
            column.OptionsColumn.AllowEdit = false;
            if (formatQty)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:N4}";
            }
            if (formatDate)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                column.DisplayFormat.FormatString = "dd/MM/yyyy";
            }
            gridView.Columns.Add(column);
        }

        //private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit;
        //private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            CreateColumn("Mã VT", "ICProductNo", gridView, false, false);
            CreateColumn("Tên vật tư", "ICProductDesc", gridView, false, false);
            CreateColumn("Mã lô", "ICProductSerieNo", gridView, false, false);
            CreateColumn("ĐVT", "ICMeasureUnitName", gridView, false, false);
            CreateColumn("SL Nhập", "ICReceiptItemProductQty", gridView, true, false);
            CreateColumn("Giá trị nhập", "ICReceiptItemTotalCost", gridView, true, false);
            CreateColumn("Ngày nhập", "ICReceiptDate", gridView, false, true);
            CreateColumn("SL Tồn", "ICInventoryStockQuantity", gridView, true, false);
            CreateColumn("Giá trị tồn", "ICInventoryStockTotalCost", gridView, true, false);
            CreateColumn("Số ngày chậm luân chuyển", "ICReceiptStorageDay", gridView, false, false);
        }
    }
}