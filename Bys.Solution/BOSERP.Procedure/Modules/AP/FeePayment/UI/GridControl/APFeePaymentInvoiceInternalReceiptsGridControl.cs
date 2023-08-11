using BOSComponent;
using BOSERP.Modules.AP.FeePayment.Localization;
using DevExpress.XtraGrid.Columns;
using System.Windows.Forms;


namespace BOSERP.Modules.FeePayment
{
    public partial class APFeePaymentInvoiceInternalReceiptsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            FeePaymentEntities entity = (FeePaymentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.FeePaymentInvoiceInternalReceiptList;
            DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((FeePaymentModule)Screen.Module).RemoveSelectedInvoiceInternalReceipt();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = FeePaymentLocalizedResources.ICReceiptNo;
            column.FieldName = "ICReceiptNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = FeePaymentLocalizedResources.ICReceiptDate;
            column.FieldName = "ICReceiptDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = FeePaymentLocalizedResources.ICReceiptPackNo;
            column.FieldName = "ICReceiptPackNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = FeePaymentLocalizedResources.ICReceiptTotalCost;
            column.FieldName = "ICReceiptTotalCost";
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
