using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public partial class RP105PurchasePlanItemOthersGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            //GridColumn column = new GridColumn();
            //column.Caption = ReportLocalizedResources.APInvoiceInPaymentAmount;
            //column.FieldName = "APInvoiceInPaymentAmount";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "MMPurchasePlanItemProductName")
                {
                    column.Caption = "Tên vật tư";
                }
                if (column.FieldName == "MMPurchasePlanItemQuantity")
                {
                    column.FieldName = "MMPurchasePlanItemQuantity";
                    column.Caption = "Số lượng cần mua";
                    column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                }
                if (column.FieldName == "MMPurchasePlanItemBPProductionNormItemQty")
                {
                    column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                }
                if (column.FieldName == "MMPurchasePlanItemPurchaseProposalQty")
                {
                    column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                }
                if (column.FieldName == "MMPurchasePlanItemInventoryStock")
                {
                    column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                }
                if (column.FieldName == "MMPurchasePlanItemBPQuantity")
                {
                    column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                }
            }
            return gridView;
        }
    }
}
