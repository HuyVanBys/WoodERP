using BOSComponent;
using System;

namespace BOSERP.Modules.EndingAllocation.UI
{
    /// <summary>
    /// Summary description for DMEA100
    /// </summary>
    public partial class DMEA100 : BOSERPScreen
    {

        public DMEA100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAllocation_Click(object sender, EventArgs e)
        {
            ((EndingAllocationModule)Module).Allocation();
        }

        private void fld_lkeFK_ACEndingAllocationDeclarationID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int eadID = 0;
                if (int.TryParse(e.Value.ToString(), out eadID))
                {
                    ((EndingAllocationModule)Module).ChangeEAD(eadID);
                }
            }
        }

        private void fld_dteACEndingAllocationToDate_TextChanged(object sender, EventArgs e)
        {
            ((EndingAllocationModule)Module).ChangeEndDate();
        }

        private void fld_dteACEndingAllocationFromDate_TextChanged(object sender, EventArgs e)
        {
            ((EndingAllocationModule)Module).ChangeFromDate();
        }





    }
}
