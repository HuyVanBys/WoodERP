using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;


namespace BOSERP.Modules.CustomerPayment
{
    public class ARInvoicesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CustomerPaymentEntities entity = (CustomerPaymentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARInvoiceList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            return gridView;
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CustomerPaymentModule)Screen.Module).DeleteSelectedInvoice();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            //RepositoryItemCalcEdit repositoryItemCalcEdit = new RepositoryItemCalcEdit();
            //repositoryItemCalcEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            //repositoryItemCalcEdit.NullText = "0";
            //repositoryItemCalcEdit.Mask.EditMask = "n2";

            GridColumn column = new GridColumn();
            column.Caption = CustomerPaymentLocalizedResources.ARDocumentPaymentAmount;
            column.FieldName = "ARDocumentPaymentAmount";
            column.OptionsColumn.AllowEdit = true;
            //column.DisplayFormat.FormatType = FormatType.Numeric;
            //column.DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = CustomerPaymentLocalizedResources.ARDocumentPaymentExchangeRate;
            column.FieldName = "ARDocumentPaymentExchangeRate";
            column.OptionsColumn.AllowEdit = true;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = CustomerPaymentLocalizedResources.ARInvoiceReturnAmount;
            column.FieldName = "ARInvoiceReturnAmount";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = CustomerPaymentLocalizedResources.ARCustomerRepaid;
            column.FieldName = "ARCustomerRepaid";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns.Add(column);
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;

            if (gridView.FocusedRowHandle >= 0)
            {
                ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)gridView.GetRow(e.RowHandle);
                if (objInvoicesInfo != null)
                {
                    if (e.Column.FieldName == "ARDocumentPaymentAmount")
                    {
                        ((CustomerPaymentModule)Screen.Module).ChangeInvoicePaymentAmount(objInvoicesInfo);
                    }
                }
            }
        }
    }
}
