using BOSComponent;
using System;

namespace BOSERP.Modules.ClearInvoice.UI
{
    /// <summary>
    /// Summary description for DMDC100
    /// </summary>
    public partial class DMCLI100 : BOSERPScreen
    {

        public DMCLI100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ACObjectID_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (e.Value != null)
                ((ClearInvoiceModule)Module).ChangeFK_ACObjectID(e.Value.ToString());
            else
                ((ClearInvoiceModule)Module).ChangeFK_ACObjectID(string.Empty);
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((ClearInvoiceModule)Module).ChangeCurrency(Convert.ToInt32(e.Value));
            }
        }

        private void fld_btnInvoice_Click(object sender, EventArgs e)
        {
            ((ClearInvoiceModule)Module).ShowInvoiceList();
        }

        private void fld_btnInvoiceIn_Click(object sender, EventArgs e)
        {
            ((ClearInvoiceModule)Module).ShowInvoiceInList();
        }

        private void fld_lkeRunAllocation_Click(object sender, EventArgs e)
        {
            ((ClearInvoiceModule)Module).RunAllocation();
        }
    }
}
