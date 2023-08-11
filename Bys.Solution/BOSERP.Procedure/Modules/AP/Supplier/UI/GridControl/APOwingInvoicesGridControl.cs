using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.Supplier
{
    public partial class APOwingInvoicesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SupplierEntities entity = (SupplierEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            DataSource = entity.OwingInvoiceList;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = SupplierLocalizedResources.APInvoiceInDueDays;
            column.FieldName = "APInvoiceInDueDays";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.SortInfo.Add(new DevExpress.XtraGrid.Columns.GridColumnSortInfo(gridView.Columns["APInvoiceInDate"], DevExpress.Data.ColumnSortOrder.Descending));
            return gridView;
        }

        protected override void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);

            if (e.FocusedRowHandle >= 0)
            {
                GridView gridView = (GridView)MainView;
                APInvoiceInsInfo objInvoiceInsInfo = (APInvoiceInsInfo)gridView.GetRow(e.FocusedRowHandle);
                ((SupplierModule)Screen.Module).ShowPaymentDetails(objInvoiceInsInfo);
            }
        }
    }
}
