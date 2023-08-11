using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public partial class RP105PurchaseOrderItemWoodsGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Rộng (min)";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "APPurchaseOrderItemProductWidthMin";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Dài (min)";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "APPurchaseOrderItemProductLenghtMin";
            gridView.Columns.Add(column);
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "APPurchaseOrderItemProductQty")
                {
                    column.Caption = "Khối lượng (m3)";
                    column.Visible = true;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
                if (column.FieldName == "APPurchaseOrderItemReceiptedQty")
                {
                    column.Caption = "Khối lượng đã nhận";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
                if (column.FieldName == "APPurchaseOrderItemPackagedQty")
                {
                    column.Caption = "Khối lượng đóng hàng";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
                if (column.FieldName == "APPurchaseOrderItemProductHeight")
                {
                    column.Group();
                    column.GroupIndex = 0;
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                }
                if (column.FieldName == "APPurchaseOrderItemProductName")
                {
                    column.Group();
                    column.GroupIndex = 1;
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                }
            }

            gridView.ExpandAllGroups();
            return gridView;
        }
    }
}
