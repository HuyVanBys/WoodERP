using BOSComponent;

namespace BOSERP.Modules.AccountingFormula.UI
{
    /// <summary>
    /// Summary description for DMCL100
    /// </summary>
    public partial class DMAF100 : BOSERPScreen
    {

        public DMAF100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeAPInvoiceInType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((AccountingFormulaModule)Module).ChangeType(e.Value.ToString());
            }
        }
    }
}
