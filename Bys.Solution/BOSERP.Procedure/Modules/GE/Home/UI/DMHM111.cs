using System;

namespace BOSERP.Modules.Home.UI
{
    /// <summary>
    /// Summary description for DMHM111
    /// </summary>
    public partial class DMHM111 : BOSERPScreen
    {

        public DMHM111()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
            fld_dteAPProposalFromDate.DateTime = BOSApp.GetCurrentServerDate().AddDays(-7);
            fld_dteAPProposalToDate.DateTime = BOSApp.GetCurrentServerDate();
            fld_lkeAPProposalStatus.Enabled = false;
            fld_lkeAPProposalStatus.EditValue = "New";
        }

        private void fld_btnShow_Click(object sender, EventArgs e)
        {
            ((HomeModule)Module).ShowPurchaseProposalFilterList();
        }
    }
}
