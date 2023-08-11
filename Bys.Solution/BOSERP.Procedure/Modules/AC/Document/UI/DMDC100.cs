using BOSComponent;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Document.UI
{
    /// <summary>
    /// Summary description for DMDC100
    /// </summary>
    public partial class DMDC100 : BOSERPScreen
    {

        public DMDC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        public override Control InitializeControl(Control ctrl)
        {
            ctrl = base.InitializeControl(ctrl);

            if (ctrl.Name == "fld_lkeFK_ACAssObjectID")
            {
                (ctrl as BOSLookupEdit).Properties.ValueMember = "ACAssObjectAccessKey";
            }
            return ctrl;
        }

        private void fld_lkeFK_ACObjectID_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (e.Value != null)
                ((DocumentModule)Module).ChangeFK_ACObjectID(e.Value.ToString());
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            if (lookup.OldEditValue != e.Value.ToString())
            {
                int currencyID = 0;
                if (int.TryParse(e.Value.ToString(), out currencyID))
                {
                    ((DocumentModule)Module).ChangeCurrency(currencyID);
                }
            }
        }
    }
}
