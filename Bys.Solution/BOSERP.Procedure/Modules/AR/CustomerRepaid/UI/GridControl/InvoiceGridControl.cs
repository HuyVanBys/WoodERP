using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.CustomerRepaid
{
    public partial class InvoiceGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CustomerRepaidEntities entity = (CustomerRepaidEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.InvoiceList;
            DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((CustomerRepaidModule)Screen.Module).RemoveSelectedInvoice();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = CustomerRepaidLocalizedResources.ARInvoiceReturnAmount;
            column.FieldName = "ARInvoiceReturnAmount";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = CustomerRepaidLocalizedResources.ARCustomerRepaid;
            column.FieldName = "ARCustomerRepaid";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = CustomerRepaidLocalizedResources.ARDocumentPaymentAmount;
            column.FieldName = "ARDocumentPaymentAmount";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = CustomerRepaidLocalizedResources.ARDocumentPaymentExchangeRate;
            column.FieldName = "ARDocumentPaymentExchangeRate";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objInvoicesInfo != null)
                {
                    if (e.Column.FieldName == "ARDocumentPaymentAmount")
                    {
                        ((CustomerRepaidModule)Screen.Module).ChangeInvoicePaymentAmount(objInvoicesInfo);
                    }
                }
            }
        }
    }
}
