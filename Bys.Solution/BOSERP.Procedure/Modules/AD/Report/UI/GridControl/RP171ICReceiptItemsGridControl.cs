using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public class RP171ICReceiptsGridControl : BOSGridControl
    {
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;
            InitColumnSummary("SLDM", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("SLHoanThanh", DevExpress.Data.SummaryItemType.Sum);
            //InitColumnSummary("TyLeHoanThanh", DevExpress.Data.SummaryItemType.Custom);

            //GridGroupSummaryItem item = new GridGroupSummaryItem();
            //item.FieldName = "ACDocumentTotalAmount";
            //item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            //item.DisplayFormat = "{0:n}";
            //gridView.GroupSummary.Add(item);
            //item.ShowInGroupColumnFooter = gridView.Columns["ACDocumentTotalAmount"];
            //InitColumnSummary("ACDocumentTotalAmount", DevExpress.Data.SummaryItemType.Custom);

            return gridView;
        }



        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "MMBatchProductNo";
            column.Caption = "Mã LSX";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MaSP";
            column.Caption = "Mã sản phẩm";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "TenSP";
            column.Caption = "Tên sản phẩm";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.FieldName = "MaCum";
            //column.Caption = "Mã cụm";
            //column.OptionsColumn.AllowEdit = false;
            //column.Visible = true;
            //column.VisibleIndex = 4;
            //gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.FieldName = "TenCum";
            //column.Caption = "Tên cụm";
            //column.OptionsColumn.AllowEdit = false;
            //column.Visible = true;
            //column.VisibleIndex = 5;
            //gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.FieldName = "MaCT";
            //column.Caption = "Mã chi tiết";
            //column.OptionsColumn.AllowEdit = false;
            //column.Visible = true;
            //column.VisibleIndex = 6;
            //gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.FieldName = "TenCT";
            //column.Caption = "Tên chi tiết";
            //column.OptionsColumn.AllowEdit = false;
            //column.Visible = true;
            //column.VisibleIndex = 6;
            //gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "SLDM";
            column.Caption = "Số lượng định mức";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "SLHoanThanh";
            column.Caption = "Số lượng hoàn thành";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "TyLeHoanThanh";
            column.Caption = "% hoàn thành";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.FieldName = "ICStockName";
            //column.Caption = "Kho";
            //column.OptionsColumn.AllowEdit = false;
            //column.Visible = true;
            //column.VisibleIndex = 9;
            //gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleOrderItemProductUnitPrice";
            column.Caption = "Đơn giá";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 10;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleOrderItemTotalAmount";
            column.Caption = "Thành tiền";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 11;
            gridView.Columns.Add(column);

        }

    }
}
