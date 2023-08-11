using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.GeneralCostAllocation.UI
{
    /// <summary>
    /// Summary description for DMGCA100
    /// </summary>
    public partial class DMGCA100 : BOSERPScreen
    {

        public DMGCA100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fld_lkeFK_MMProductionCostFactorID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((GeneralCostAllocationModule)Module).ChangeFactor(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ACDebitAccountID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((GeneralCostAllocationModule)Module).ChangeDebitAccount(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ACCreditAccountID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((GeneralCostAllocationModule)Module).ChangeCreditAccount(Convert.ToInt32(e.Value));
            }
        }

        private void fld_dteMMProductionCostGeneralCostAllocationFromDate_TextChanged(object sender, EventArgs e)
        {
            ((GeneralCostAllocationModule)Module).ChangeFromToDate();
        }

        private void fld_dteMMProductionCostGeneralCostAllocationToDate_TextChanged(object sender, EventArgs e)
        {
            ((GeneralCostAllocationModule)Module).ChangeFromToDate();
        }

        private void bosHyperLinkEdit1_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((GeneralCostAllocationModule)Module).ViewDetailGeneralCost();
        }




    }
}
