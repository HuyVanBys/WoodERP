using DevExpress.XtraGrid.Columns;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public partial class RP100MMPackagingsItemGridControl : ReportGridControl
    {
        protected override void AddColumnsToGridView(String strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "ARCustomerName";
            column.Caption = ReportLocalizedResources.CustomerName;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleOrderNo";
            column.Caption = ReportLocalizedResources.ARSaleOrderID;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductNo";
            column.Caption = ReportLocalizedResources.MMBatchProductNo;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductProductionNormItemNo";
            column.Caption = ReportLocalizedResources.MMWoodPlanItemDetailProductNo;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductProductionNormItemProductDesc";
            column.Caption = ReportLocalizedResources.ICProductDesc;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductProductionNormItemQuantity";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n3}";
            column.Caption = ReportLocalizedResources.ARInvoiceItemProductQty;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMAllocationPlanItemQty";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n3}";
            column.Caption = ReportLocalizedResources.MMAllocationPlanItemQty;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMAllocationProposlItemQty";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n3}";
            column.Caption = ReportLocalizedResources.MMAllocationProposlItemQty;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICShipmentProductQty";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n3}";
            column.Caption = ReportLocalizedResources.ICShipmentProductQty;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

        }
    }
}
