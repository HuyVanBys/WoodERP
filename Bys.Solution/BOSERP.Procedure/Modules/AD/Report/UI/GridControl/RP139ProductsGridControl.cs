using BOSComponent;
using DevExpress.XtraGrid.Columns;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public class RP139ProductsGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "ICProductNo";
            column.Caption = "Mã CCDC";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 0;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductIdentifiedEquipmentNo";
            column.Caption = "Mã định danh";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductName";
            column.Caption = "Tên sản phẩm";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductDesc";
            column.Caption = "Quy cách";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICMeasureUnitName";
            column.Caption = ReportLocalizedResources.ICMeasureUnitName;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICShipmentItemProductQty";
            column.Caption = "Số lượng";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductIdentifiedEquipmentOriginalAmount";
            column.Caption = "Giá trị mua";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "RemainedAmount";
            column.Caption = ReportLocalizedResources.ACAssetRemainedAmount;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICShipmentDate";
            column.Caption = ReportLocalizedResources.ACAssetUsedDate;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APPurchaseOrderDate";
            column.Caption = "Ngày sửa chữa";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APPurchaseOrderItemProductDesc";
            column.Caption = "Nội dung sửa chữa";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 10;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APPurchaseOrderItemTotalCost";
            column.Caption = "Giá trị sửa chữa";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 11;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "HREmployeeName";
            column.Caption = "Người sử dụng";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 12;
            gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.FieldName = "MMWorkShopName";
            //column.Caption = ReportLocalizedResources.MMWorkShopName;
            //column.OptionsColumn.AllowEdit = false;
            //column.Visible = true;
            //column.VisibleIndex = 13;
            //gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "HRDepartmentRoomName";
            column.Caption = ReportLocalizedResources.HRDepartmentRoomName;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 14;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "HRDepartmentName";
            column.Caption = ReportLocalizedResources.HRDepartmentName;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 15;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductComment";
            column.Caption = "Ghi chú";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 15;
            gridView.Columns.Add(column);

        }
        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            DateTime value = DateTime.Now;
            if (e.CellValue != null && (e.Column.FieldName == "ICShipmentDate" || e.Column.FieldName == "APPurchaseOrderDate"))
            {
                if (DateTime.TryParse(e.CellValue.ToString(), out value))
                {
                    if (value.Date == DateTime.MinValue.Date)
                    {
                        e.DisplayText = "";
                    }
                    if (value.Date == DateTime.MaxValue.Date)
                    {
                        e.DisplayText = "";
                    }
                }
            }

        }


    }
}
