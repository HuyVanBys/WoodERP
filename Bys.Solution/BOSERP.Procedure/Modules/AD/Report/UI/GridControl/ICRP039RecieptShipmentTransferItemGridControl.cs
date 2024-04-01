using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public partial class ICRP039RecieptShipmentTransferItemGridControl : ReportGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            if (gridView.Columns["ItemReceiptedQty"] != null)
            {
                gridView.Columns["ItemReceiptedQty"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView.Columns["ItemReceiptedQty"].DisplayFormat.FormatString = "{0:n6}";
            }
            if (gridView.Columns["ItemShippedQty"] != null)
            {
                gridView.Columns["ItemShippedQty"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView.Columns["ItemShippedQty"].DisplayFormat.FormatString = "{0:n6}";
            }
            if (gridView.Columns["ItemExchangeTotalCost"] != null)
            {
                gridView.Columns["ItemExchangeTotalCost"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView.Columns["ItemExchangeTotalCost"].DisplayFormat.FormatString = "{0:n0}";
            }
            return gridView;
        }

        protected override void AddColumnsToGridView(String strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = ReportLocalizedResources.ICReceiptNo;
            column.FieldName = "ICReceiptNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ICReceiptDate;
            column.FieldName = "ICReceiptDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ICReceiptDesc;
            column.FieldName = "ICReceiptDesc";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ICProductNo;
            column.FieldName = "ICProductNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên sản phẩm";
            column.FieldName = "ICProductName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên thành phẩm";
            column.FieldName = "ICProductName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ICProductSupplierNumber;
            column.FieldName = "ICProductSupplierNumber";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ICProductDesc;
            column.FieldName = "ICProductDesc";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ICProductSerieNo;
            column.FieldName = "ICReceiptItemLotNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã kiện/ Mã đầu lóng";
            column.FieldName = "ICProductSerieNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.MMBatchProductProductionNormItemQuantity;
            column.FieldName = "ICReceiptItemBPProductionNormItemQty";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatString = "{0:N5}";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "SL cần sản xuất";
            column.FieldName = "SLHoanThanh";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatString = "{0:N5}";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ReceiptedQty;
            column.FieldName = "ItemReceiptedQty";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatString = "{0:N5}";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ShippedQty;
            column.FieldName = "ItemShippedQty";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatString = "{0:N5}";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ICStockName;
            column.FieldName = "ICStockName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên đối tượng";
            column.FieldName = "ACObjectName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã đối tượng";
            column.FieldName = "ACObjectNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = ReportLocalizedResources.ICReceiptStatus;
            //column.FieldName = "ICReceiptStatus";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.MMBatchProductNo;
            column.FieldName = "MMBatchProductNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = ReportLocalizedResources.PurchaseOrderNo;
            //column.FieldName = "PurchaseOrderNo";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Thành tiền";
            column.FieldName = "ICReceiptItemTotalCost";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatString = "{0:N2}";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ICProductNoOfOldSys;
            column.FieldName = "ICProductNoOfOldSys";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Đơn vị tính";
            column.FieldName = "ICMeasureUnitName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số thanh (Tấm)";
            column.FieldName = "ItemWoodQty";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatString = "{0:N5}";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Thành tiền (VND)";
            column.FieldName = "ItemExchangeTotalCost";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatString = "{0:N0}";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Dày(mm)";
            column.FieldName = "ICReceiptItemProductHeight";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatString = "{0:N5}";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Rộng(mm)";
            column.FieldName = "ICReceiptItemProductWidth";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatString = "{0:N5}";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Dài(mm)";
            column.FieldName = "ICReceiptItemProductLength";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatString = "{0:N5}";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Lý do nhập xuất";
            column.FieldName = "ICImportAndExportReasonName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã Đơn mua hàng";
            column.FieldName = "PurchaseOrderNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
