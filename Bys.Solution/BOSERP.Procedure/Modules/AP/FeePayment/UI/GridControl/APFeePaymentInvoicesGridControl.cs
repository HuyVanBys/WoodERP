using BOSComponent;
using BOSERP.Modules.AP.FeePayment.Localization;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using System.Windows.Forms;


namespace BOSERP.Modules.FeePayment
{
    public partial class APFeePaymentInvoicesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            FeePaymentEntities entity = (FeePaymentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.FeePaymentInvoiceList;
            DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((FeePaymentModule)Screen.Module).RemoveSelectedInvoice();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = FeePaymentLocalizedResources.ICReceiptNo;
            column.FieldName = "ARInvoiceNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = FeePaymentLocalizedResources.APInvoiceInVATDate;
            column.FieldName = "ARInvoiceDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.Caption = FeePaymentLocalizedResources.APInvoiceInSupplierNo;
            column.FieldName = "ARInvoiceVATInvoiceNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.Caption = FeePaymentLocalizedResources.ICReceiptTotalCost;
            column.FieldName = "ARInvoiceTotalAmount";
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n3}";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Đối tượng";
            column.FieldName = "ARObjectName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
