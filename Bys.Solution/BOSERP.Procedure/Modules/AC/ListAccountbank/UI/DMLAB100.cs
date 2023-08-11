using BOSComponent;

namespace BOSERP.Modules.ListAccountBank.UI
{
    /// <summary>
    /// Summary description for DMAS100
    /// </summary>
    public partial class DMLAB100 : BOSERPScreen
    {

        public DMLAB100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null)
            {
                ((ListAccountBankModule)Module).ChangeObject(e.Value.ToString());
            }
            else if (e.Value == null)
            {
                ((ListAccountBankModule)Module).ChangeObject("");
            }
        }

        private void fld_lkeFK_GEBankID_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            ((ListAccountBankModule)Module).ChangeBank();
        }
    }
}
