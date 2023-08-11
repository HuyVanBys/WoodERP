using BOSComponent;
using DevExpress.XtraGrid.Columns;
using Localization;

namespace BOSERP.Modules.Supplier
{
    public partial class OwingByCurrencyGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = SupplierLocalizedResources.GECurrencyName;
            column.FieldName = "GECurrencyName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = SupplierLocalizedResources.DueAmount;
            column.FieldName = "DueAmount";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
