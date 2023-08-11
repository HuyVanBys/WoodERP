using BOSComponent;
using DevExpress.XtraGrid.Columns;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.Customer
{
    public partial class AROwingInvoicesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            //base.InitGridControlDataSource();
            CustomerEntities entity = (CustomerEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.AROwingInvoicesList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = CustomerLocalizedResources.ARInvoiceDueDays;
            column.FieldName = "ARInvoiceDueDays";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = CustomerLocalizedResources.ARInvoiceReturnAmount;
            column.FieldName = "ARInvoiceReturnAmount";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridview = base.InitializeGridView();
            DevExpress.XtraGrid.Columns.GridColumn column = gridview.Columns["ARInvoiceDate"];
            column.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            return gridview;

        }
        protected override void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);

            CustomerEntities entity = (CustomerEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            if (e.FocusedRowHandle >= 0)
            {
                DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
                if (gridView != null)
                {
                    ARInvoicesInfo objARInvoicesInfo = (ARInvoicesInfo)gridView.GetRow(e.FocusedRowHandle);
                    if (objARInvoicesInfo != null)
                    {
                        ((CustomerModule)Screen.Module).ShowPaymentDetails(objARInvoicesInfo);
                    }
                }
            }
        }
    }
}
