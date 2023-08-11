using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public class RP196ARDeliveryPlanItemsGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            GridColumn column = new GridColumn();
            column.FieldName = "ARDeliveryPlanItemRowNumber";
            column.Caption = ReportLocalizedResources.ARSaleOrderItemRowNumber;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "CustomerName";
            column.Caption = ReportLocalizedResources.ARCustomerName;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARDeliveryPlanItemSaleOrderNo";
            column.Caption = ReportLocalizedResources.ARDeliveryPlanItemSaleOrderNo;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARDeliveryPlanItemAddress";
            column.Caption = ReportLocalizedResources.ARDeliveryPlanItemAddress;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductName";
            column.Caption = ReportLocalizedResources.ProductName;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARDeliveryPlanItemDeliveryActualDate";
            column.Caption = ReportLocalizedResources.ARDeliveryPlanItemDeliveryActualDate;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICMeasureUnitName";
            column.Caption = ReportLocalizedResources.ICMeasureUnitName;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARDeliveryPlanItemProductTemplateType";
            column.Caption = ReportLocalizedResources.ARDeliveryPlanItemProductTemplateType;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARDeliveryPlanItemDeliveryActualDate";
            column.Caption = ReportLocalizedResources.ARDeliveryPlanItemDeliveryActualDate;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARDeliveryPlanTruckName";
            column.Caption = ReportLocalizedResources.ARDeliveryPlanTruckName;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARDeliveryPlanTruckDriver";
            column.Caption = ReportLocalizedResources.ARDeliveryPlanTruckDriver;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARDeliveryPlanTruckDeliveryEmployee";
            column.Caption = ReportLocalizedResources.ARDeliveryPlanTruckDeliveryEmployee;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARDeliveryPlanItemProductDesc";
            column.Caption = ReportLocalizedResources.ARDeliveryPlanDesc;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleOrderSaleAgreement";
            column.Caption = ReportLocalizedResources.ARSaleOrderSaleAgreement;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

        }

        protected override void InitGridViewColumns(GridView gridView)
        {
            base.InitGridViewColumns(gridView);

        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            return gridView;
        }

        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }

        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            DateTime value = DateTime.Now;
        }
    }
}
