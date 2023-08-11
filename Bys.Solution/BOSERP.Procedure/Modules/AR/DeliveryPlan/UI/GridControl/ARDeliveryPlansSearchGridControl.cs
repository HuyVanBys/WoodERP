using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.DeliveryPlan
{
    partial class ARDeliveryPlansSearchGridControl : BOSSearchResultsGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Mã ĐBH";
            column.FieldName = "ARSalerOrderNosList";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã Load Cont";
            column.FieldName = "ARLoadContNosList";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleOrderName";
            column.Caption = "Mã đơn hàng nội bộ";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
