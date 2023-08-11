using System;

namespace BOSERP.Modules.Home.UI
{
    /// <summary>
    /// Summary description for DMHM121
    /// </summary>
    public partial class DMHM122 : BOSERPScreen
    {
        public DMHM122()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
            //fld_dtePaymentProposalFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            //fld_dtePaymentProposalToDate.DateTime = BOSUtil.GetMonthEndDate();
        }

        //private void fld_btnShow_Click(object sender, EventArgs e)
        //{
        //    ((HomeModule)Module).ShowAllPaymentProposalForHome();
        //}

        private void Fld_btnMoveUp_Click(object sender, EventArgs e)
        {
            ((HomeModule)Module).ShowShipmenttUnExecutedInvoiceList();
        }
    }
}
