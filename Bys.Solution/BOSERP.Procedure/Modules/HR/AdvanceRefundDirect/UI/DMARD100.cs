using BOSComponent;
using DevExpress.XtraEditors;
using System;

namespace BOSERP.Modules.AdvanceRefundDirect.UI
{
    /// <summary>
    /// Summary description for DMARD100
    /// </summary>
    public partial class DMARD100 : BOSERPScreen
    {

        public DMARD100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeEmployee_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;

            if (lke.OldEditValue != e.Value)
            {
                ((AdvanceRefundDirectModule)Module).ChangeEmployee(e.Value.ToString());
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((AdvanceRefundDirectModule)Module).ChangeObject(Convert.ToString(e.Value));
            }
        }

        private void fld_lkeFK_PMProjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int projectID = 0;
                if (int.TryParse(e.Value.ToString(), out projectID))
                {
                    ((AdvanceRefundDirectModule)Module).ChangeProject(projectID);
                }
            }
        }

        private void fld_medHRAdvanceRefundDesc_Validated(object sender, EventArgs e)
        {
            ((AdvanceRefundDirectModule)Module).UpdateAdvanceRefundDesc();
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int currencyID = 0;
                if (int.TryParse(e.Value.ToString(), out currencyID))
                {
                    ((AdvanceRefundDirectModule)Module).ChangeCurrency(currencyID);
                }
            }
        }
    }
}
