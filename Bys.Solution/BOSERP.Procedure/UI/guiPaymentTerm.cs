using System;
using System.Windows.Forms;

namespace BOSERP
{
    /// <summary>
    /// Summary description for DSPL10
    /// </summary>
    public partial class guiPaymentTerm : BOSERPScreen
    {
        public guiPaymentTerm()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void fld_btnOk_Click(object sender, EventArgs e)
        {
            this.Tag = String.Format("%/days - {0}/{1} days .NET/{2} days", fld_txtDiscount.Text, fld_txtPayWithin.Text, fld_txtNetDue.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
