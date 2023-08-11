using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public partial class RP103MMBatchProductsGridControl : ReportGridControl
    {
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(gridView_FocusedRowChanged);
            return gridView;
        }

        void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);
            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn != null)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    MMBatchProductsInfo item = (MMBatchProductsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (item != null)
                    {
                        ((RP103)Screen).GetallTabdata(item.MMBatchProductID);
                    }
                }
            }
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            //GridColumn column = new GridColumn();
            //column.Caption = ReportLocalizedResources.APInvoiceInPaymentAmount;
            //column.FieldName = "APInvoiceInPaymentAmount";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);
        }
    }
}
