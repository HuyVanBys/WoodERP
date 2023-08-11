using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.Report
{
    public partial class RPOrderTrackingWoodGridControl : ReportGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = ReportLocalizedResources.SONo;
            column.FieldName = "ARSaleOrderNo";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ARCustomerName;
            column.FieldName = "ARCustomerName";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.MMWoodPlanItemDetailProductNo;
            column.FieldName = "MMWoodPlanItemDetailProductNo";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.MMWoodPlanItemDetailProductDesc;
            column.FieldName = "MMWoodPlanItemDetailProductDesc";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Khối lượng định mức";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n4}";
            column.FieldName = "MMWoodPlanItemDetailBlocks";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.MMAllocationPlanItemQty1;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n4}";
            column.FieldName = "MMAllocationPlanItemQty";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.MMPurchasePlanItemQuantity1;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n4}";
            column.FieldName = "MMPurchasePlanItemQuantity";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APProposalItemProductQty1;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n4}";
            column.FieldName = "APProposalItemProductQty";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APPurchaseOrderItemProductQty2;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n4}";
            column.FieldName = "APPurchaseOrderItemProductQty";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ICReceiptItemProductQty1;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n4}";
            column.FieldName = "ICReceiptItemProductQty";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Khối lượng đã cấp phát";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n4}";
            column.FieldName = "MMAllocationProposalItemQty";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã kế hoạch SD NPL";
            column.FieldName = "AllocationPlanNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsBehavior.Editable = false;
            GridColumn column = gridView.Columns["MMBatchProductNo"];
            if (column != null)
            {
                column.Caption = ReportLocalizedResources.MMBatchProductNo;
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }
    }
}
