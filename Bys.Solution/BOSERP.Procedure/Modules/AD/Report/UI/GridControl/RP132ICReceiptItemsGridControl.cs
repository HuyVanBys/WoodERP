using BOSComponent;
using DevExpress.XtraGrid.Columns;
using Localization;

namespace BOSERP.Modules.Report
{
    public class RP132ICReceiptItemsGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "ICReceiptNo";
            column.Caption = ReportLocalizedResources.ReceiptNo;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICReceiptDate";
            column.Caption = ReportLocalizedResources.APPurchaseOrderDeliveryDate;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APSupplierName";
            column.Caption = ReportLocalizedResources.APSupplierName;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["ICReceiptItemProductQty"];
            if (column != null)
            {
                column.Visible = true;
                column.VisibleIndex = 3;
            }
            column = gridView.Columns["ICReceiptItemProductUnitCost"];
            if (column != null)
            {
                column.Visible = true;
                column.VisibleIndex = 4;
            }
            column = gridView.Columns["ICReceiptItemTotalCost"];
            if (column != null)
            {
                column.Visible = true;
                column.VisibleIndex = 5;
            }
            return gridView;
        }

    }
}
