using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.Customer
{
    public partial class ARInvoicesGridControl : BOSComponent.BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = CustomerLocalizedResources.ARInvoiceReturnAmount;
            column.FieldName = "ARInvoiceReturnAmount";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.SortInfo.Add(new DevExpress.XtraGrid.Columns.GridColumnSortInfo(gridView.Columns["ARInvoiceDate"], DevExpress.Data.ColumnSortOrder.Descending));
            return gridView;
        }
    }
}
