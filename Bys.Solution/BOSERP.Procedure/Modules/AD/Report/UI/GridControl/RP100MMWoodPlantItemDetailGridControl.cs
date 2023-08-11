using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public partial class RP100MMWoodPlantItemDetailGridControl : ReportGridControl
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
            column.FieldName = "MMWoodPlanItemDetailProductNo";
            column.Caption = ReportLocalizedResources.MMWoodPlanItemDetailProductNo;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMWoodPlanItemDetailProductDesc";
            column.Caption = ReportLocalizedResources.ICProductDesc;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMWoodPlanItemDetailBlocks";
            column.Caption = ReportLocalizedResources.MMWoodPlanItemDetailBlocks;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMAllocationPlanItemQty";
            column.Caption = ReportLocalizedResources.MMAllocationPlanItemQty1;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n4}";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMAllocationProposlItemQty";
            column.Caption = ReportLocalizedResources.MMAllocationProposlItemQty1;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n4}";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICShipmentProductQty";
            column.Caption = ReportLocalizedResources.ICShipmentProductQty1;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n4}";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
