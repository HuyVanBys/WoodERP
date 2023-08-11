using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.Supplier
{
    public partial class APInvoicePaymentDetailsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SupplierEntities entity = (SupplierEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.DocumentPaymentList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = SupplierLocalizedResources.GECurrencyName;
            column.FieldName = "GECurrencyName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = SupplierLocalizedResources.APSupplierPaymentNo;
            column.FieldName = "APSupplierPaymentNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = SupplierLocalizedResources.APSupplierPaymentDate;
            column.FieldName = "APSupplierPaymentDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = SupplierLocalizedResources.APSupplierPaymentExchangeRate;
            column.FieldName = "APSupplierPaymentExchangeRate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
