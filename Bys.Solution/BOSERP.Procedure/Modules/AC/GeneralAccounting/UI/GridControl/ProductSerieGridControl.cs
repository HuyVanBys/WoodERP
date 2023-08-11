using BOSComponent;
using DevExpress.XtraGrid.Columns;
using System.Windows.Forms;

namespace BOSERP.Modules.GeneralAccounting
{
    public partial class ProductSerieGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductSerieList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Chọn";
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Giá vốn ban đầu";
            column.FieldName = "OriginalInventoryCost";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Giá vốn sau tính phí";
            column.FieldName = "AdjustedInventoryCost";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã phiếu nhập";
            column.FieldName = "ICReceiptNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày nhập";
            column.FieldName = "ICReceiptDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
