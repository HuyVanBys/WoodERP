using BOSComponent;
using System;

namespace BOSERP.Modules.CustomerPaymentProposal.UI
{
    /// <summary>
    /// Summary description for DMPP100
    /// </summary>
    public partial class DMCPP100 : BOSERPScreen
    {

        public DMCPP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnSelectPaymentTerm_Click(object sender, EventArgs e)
        {
            ((CustomerPaymentProposalModule)Module).GetPaymentTerm();
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            AccObjectLookupEdit lke = (AccObjectLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                e.Value = ((CustomerPaymentProposalModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void fld_lkeFK_HREmployeeID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int objectID = 0;
                Int32.TryParse(e.Value.ToString(), out objectID);
                ((CustomerPaymentProposalModule)Module).ChangeEmployeeCreation(objectID);
            }
        }

        private void fld_lnkChooseProspectCustomer_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((CustomerPaymentProposalModule)Module).ChooseProspectCustomer();
        }
    }
}
