using BOSComponent;
using DevExpress.XtraGrid.Columns;
using System;

namespace BOSERP.Modules.Report
{
    public class RP128MMPurchasePlanItemPaints : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "ICProductNo";
            column.Caption = "Mã sản phẩm";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductName";
            column.Caption = "Tên sản phẩm";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductDesc";
            column.Caption = "Mô tả";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMPurchasePlanItemHWorPaintQuantity";
            column.Caption = "Số lượng mua mới";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMAllocationPlanItemQty";
            column.Caption = "Số lượng sử dụng tồn kho";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            DateTime value = DateTime.Now;
            if (e.CellValue != null && (e.Column.FieldName == "PurchaseOrderPaymentTimeDateDeposit" || e.Column.FieldName == "APInvoiceIndate"))
            {
                if (DateTime.TryParse(e.CellValue.ToString(), out value))
                {
                    if (value == DateTime.MinValue)
                    {
                        e.DisplayText = "";
                    }
                    if (value == DateTime.MaxValue)
                    {
                        e.DisplayText = "";
                    }
                }
            }

        }


    }
}
