using System;

namespace BOSERP.Modules.CancelPurchaseOrder.UI
{
    /// <summary>
    /// Summary description for DMCPO100
    /// </summary>
    public partial class DMCPO100 : BOSERPScreen
    {

        public DMCPO100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeACObjectAccessKey_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            AccObjectLookupEdit lke = (AccObjectLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((CancelPurchaseOrderModule)Module).ChangeObject(Convert.ToString(e.Value));
            }
        }
    }
}
