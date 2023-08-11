namespace BOSERP.Modules.InvoiceTransaction.UI
{
    /// <summary>
    /// Summary description for DMHM100
    /// </summary>
    public partial class DMIT100 : BOSERPScreen
    {

        public DMIT100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnImportFromExcel_Click(object sender, System.EventArgs e)
        {
            ((InvoiceTransactionModule)this.Module).ImportInvoiceTransaction();
        }

        private void fld_btnSave_Click(object sender, System.EventArgs e)
        {
            ((InvoiceTransactionModule)this.Module).SaveItem();
        }
    }
}
