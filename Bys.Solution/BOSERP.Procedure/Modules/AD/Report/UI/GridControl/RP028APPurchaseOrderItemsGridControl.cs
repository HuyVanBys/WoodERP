using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public partial class RP028APPurchaseOrderItemsGridControl : ReportGridControl
    {
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["APPurchaseOrderItemType"];
            if (column != null)
            {
                RepositoryItemLookUpEdit rep = InitRepositoryForConfigValues(ADConfigValueUtility.ConfigValues.Tables[ConfigValueGroup.PurchaseOrderType]);
                column.ColumnEdit = rep;
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["APPurchaseOrderItemReceiptedQty"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n4}";
            }
            column = gridView.Columns["ACObjectName"];
            if (column != null)
            {
                column.Caption = ReportLocalizedResources.ACObjectName;
                column.OptionsColumn.AllowEdit = false;
            }
            return gridView;
        }

        protected override void AddColumnsToGridView(String strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = ReportLocalizedResources.APPurchaseOrderNo;
            column.FieldName = "APPurchaseOrderNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APPurchaseOrderTotalCost;
            column.FieldName = "APPurchaseOrderTotalCost";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APPurchaseOrderDepositBalance;
            column.FieldName = "APPurchaseOrderDepositBalance";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APPurchaseOrderBalanceDue;
            column.FieldName = "APPurchaseOrderBalanceDue";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APPurchaseOrderDate;
            column.FieldName = "APPurchaseOrderDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APPurchaseOrderPackingDate;
            column.FieldName = "APPurchaseOrderPackingDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APPurchaseOrderDeliveryDate;
            column.FieldName = "APPurchaseOrderDeliveryDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APPurchaseOrderStatusDisplayText;
            column.FieldName = "APPurchaseOrderStatusDisplayText";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APPurchaseOrderComment;
            column.FieldName = "APPurchaseOrderComment";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APSupplierContactPhone1;
            column.FieldName = "APSupplierContactPhone1";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.InvoiceNo;
            column.FieldName = "APInvoiceInNoRef";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ICShipmentNo;
            column.FieldName = "ICReceipteNoRef";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
