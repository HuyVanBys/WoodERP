using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.Report
{
    public partial class ICRP013InventoryStocksGridControl : ReportGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(GridView_FocusedRowChanged);
            gridView.OptionsBehavior.Editable = true;
            gridView.GroupFormat = "[#image]{1} {2}";
            GridColumn column = gridView.Columns["ICStockName"];
            if (column != null)
            {
                column.Group();
            }
            column = gridView.Columns["ICProductGroupName"];
            if (column != null)
            {
                column.Group();
            }
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = false;
            }

            return gridView;
        }

        protected virtual void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle < 0)
                return;

            ICInventoryStocksInfo objInventoryStocksInfo = (ICInventoryStocksInfo)gridView.GetRow(gridView.FocusedRowHandle);
            //((RP013)Screen).InvalidateItemProductPicture(objInventoryStocksInfo);
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "ICProductGroupName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductNo";
            column.Caption = ReportLocalizedResources.ICProductNo;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSupplierNumber";
            column.Caption = ReportLocalizedResources.ICProductSupplierNumber;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductDesc";
            column.Caption = ReportLocalizedResources.ICProductDesc;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieNo";
            column.Caption = ReportLocalizedResources.ICProductSerieNo;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieLotNo";
            column.Caption = "Mã lô hàng";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.APSupplierName;
            column.FieldName = "APSupplierName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ICProductPrice;
            column.FieldName = "ICProductPrice";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ICMeasureUnitName;
            column.FieldName = "ICMeasureUnitName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICStockName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.Caption = "Model";
            column.FieldName = "ICModelName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nhãn hiệu";
            column.FieldName = "ICModelDetailName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ProductLockedPurchaseOrderStatus;
            column.FieldName = "ICProductLockedPurchaseOrderStatus";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
