using BOSComponent;
using BOSERP.Modules.AP.FeePayment.Localization;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using System.Windows.Forms;


namespace BOSERP.Modules.FeePayment
{
    public partial class APFeePaymentInvoiceInsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            FeePaymentEntities entity = (FeePaymentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.FeePaymentInvoiceInList;
            DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((FeePaymentModule)Screen.Module).RemoveSelectedInvoiceIn();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = FeePaymentLocalizedResources.ICReceiptNo;
            column.FieldName = "APInvoiceInNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = FeePaymentLocalizedResources.ICReceiptDate;
            column.FieldName = "APInvoiceInDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = FeePaymentLocalizedResources.ICReceiptPackNo;
            column.FieldName = "APInvoiceInPackNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = FeePaymentLocalizedResources.APInvoiceInSupplierNo;
            column.FieldName = "APInvoiceInSupplierNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = FeePaymentLocalizedResources.APInvoiceInVATDate;
            column.FieldName = "APInvoiceInVATDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = FeePaymentLocalizedResources.ICReceiptTotalCost;
            column.FieldName = "APInvoiceInTotalCost";
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n3}";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = FeePaymentLocalizedResources.APSupplierName;
            column.FieldName = "APSupplierName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
