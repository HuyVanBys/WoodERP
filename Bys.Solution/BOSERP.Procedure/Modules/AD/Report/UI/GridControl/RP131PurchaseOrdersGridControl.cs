using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.Report
{
    public class RP131PurchaseOrdersGridControl : BOSGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            if (gridView.Columns["APSupplierNo"] != null)
            {
                gridView.Columns["APSupplierNo"].Caption = ReportLocalizedResources.ACObjectNo;
            }
            if (gridView.Columns["ACObjectName"] != null)
            {
                gridView.Columns["ACObjectName"].Caption = ReportLocalizedResources.ACObjectName;
            }
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "APSupplierNo";
            column.Caption = ReportLocalizedResources.APSupplierNo;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APSupplierName";
            column.Caption = ReportLocalizedResources.APSupplierName;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APPurchaseOrderNo";
            column.Caption = ReportLocalizedResources.APPurchaseOrderNo;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "SoNgayTre";
            column.Caption = ReportLocalizedResources.SoNgayTre;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APPurchaseOrderItemRemainValue";
            column.Caption = "Giá trị hàng bị trễ";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

        }
        //protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        //{

        //    DateTime value = DateTime.Now;
        //    if (e.CellValue != null && (e.Column.FieldName == "ReportContractFromDate" || e.Column.FieldName == "ReportContractToDate" ||
        //                                   e.Column.FieldName == "NgayDatCoc"))
        //    {
        //        if (DateTime.TryParse(e.CellValue.ToString(), out value))
        //        {
        //            if (value == DateTime.MinValue)
        //            {
        //                e.DisplayText = "";
        //            }
        //            if (value == DateTime.MaxValue)
        //            {
        //                e.DisplayText = "";
        //            }
        //        }
        //    }

        //}


    }
}
