using BOSComponent;
using DevExpress.XtraGrid.Columns;

namespace BOSERP.Modules.Report
{
    public partial class RP115ICInventoryStocksGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();

            column = new GridColumn();
            column.Caption = "Tên sản phẩm";
            column.FieldName = "ICProductForBatchName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã sản phẩm";
            column.FieldName = "ICProductForBatchNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số lượng";
            column.FieldName = "MMBatchProductItemProductQty";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã BTP";
            column.FieldName = "ICProductNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "KL tinh / TP";
            column.FieldName = "MMBatchProductProductionNormItemBlockPerOnePD";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = "Tổng KL tinh/SP";
            //column.FieldName = "MMBatchProductProductionNormItemBlockPerOneTotalPD";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên chi tiết";
            column.FieldName = "ICProductName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tổng số lượng ĐM";
            column.FieldName = "MMBatchProductProductionNormItemQuantity";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "KL tinh / Chi tiết ";
            column.FieldName = "MMBatchProductProductionNormItemBlockPerOne";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Lệnh sản xuất";
            column.FieldName = "MMBatchProductNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số lượng tồn đầu kỳ";
            column.FieldName = "ICProductPreviouslyAccumulateQty";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Giá trị tồn đầu kỳ";
            column.FieldName = "ICProductPreviouslyAccumulateAmount";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số lượng nhập trong kỳ";
            column.FieldName = "ICProductReceiptQty";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Giá trị nhập trong kỳ";
            column.FieldName = "ICProductReceiptAmount";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số lượng xuất trong kỳ";
            column.FieldName = "ICProductShipmentQty";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Giá trị xuất trong kỳ";
            column.FieldName = "ICProductShipmentAmount";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số lượng tồn cuối kỳ";
            column.FieldName = "ICProductNextAccumulateQty";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Giá trị tồn cuối kỳ";
            column.FieldName = "ICProductNextAccumulateAmount";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tổng KL tinh nhập";
            column.FieldName = "TotalBlockReceipted";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.Caption = "Tổng KL tinh xuất";
            column.FieldName = "TotalBlockShipped";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.Caption = "Tổng KL tinh đầu kì";
            column.FieldName = "TotalBlockInit";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.Caption = "Tổng KL tinh cuối kì";
            column.FieldName = "TotalBlockEndBalance";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

        }
    }
}
