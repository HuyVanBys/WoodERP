using System;

namespace BOSERP.Modules.HRAdjustSocialInsurance.UI
{
    /// <summary>
    /// Summary description for DMASI100
    /// </summary>
    public partial class DMASI100 : BOSERPScreen
    {

        public DMASI100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        //private void fld_lkeHREmployeeID_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //        ((HRAdjustSocialInsuranceModule)Module).AddItemToAdvanceRequestItemList();
        //}

        private void fld_lkeFK_BRBranchID_Validated(object sender, EventArgs e)
        {
            //((HRAdjustSocialInsuranceModule)Module).InitEmployeeList(Convert.ToInt32(fld_lkeFK_BRBranchID.EditValue));
        }

        private void fld_btnAddEmployee_Click(object sender, EventArgs e)
        {
            ((HRAdjustSocialInsuranceModule)Module).AddItemToAdvanceRequestItemList();
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((HRAdjustSocialInsuranceModule)Module).AddItemToAdvanceRequestArearItemList();
        }

        private void bosButton2_Click(object sender, EventArgs e)
        {
            ((HRAdjustSocialInsuranceModule)Module).AddItemToChangeList();
        }
    }
}
