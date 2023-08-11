namespace BOSERP.Modules.InvoiceInTransaction.UI
{
    /// <summary>
    /// Summary description for DMHM100
    /// </summary>
    public partial class DMIIT100 : BOSERPScreen
    {

        public DMIIT100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnImportFromExcel_Click(object sender, System.EventArgs e)
        {
            ((InvoiceInTransactionModule)this.Module).ImportInvoiceInTransaction();
        }

        private void fld_btnSave_Click(object sender, System.EventArgs e)
        {
            ((InvoiceInTransactionModule)this.Module).SaveItem();
        }
    }
}
