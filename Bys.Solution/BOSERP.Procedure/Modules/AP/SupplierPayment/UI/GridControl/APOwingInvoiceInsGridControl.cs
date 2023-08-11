using BOSComponent;
using DevExpress.XtraGrid.Columns;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.SupplierPayment
{
    public partial class APOwingInvoiceInsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            //base.InitGridControlDataSource();
            SupplierPaymentEntities entity = (SupplierPaymentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.OwingInvoiceInList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = SupplierPaymentLocalizedResources.APInvoiceInDueDays;
            column.FieldName = "APInvoiceInDueDays";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = SupplierPaymentLocalizedResources.Selected;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = SupplierPaymentLocalizedResources.GECurrencyName;
            column.FieldName = "GECurrencyName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridview = base.InitializeGridView();
            DevExpress.XtraGrid.Columns.GridColumn column = gridview.Columns["APInvoiceInDate"];
            column.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            return gridview;

        }


    }
}
