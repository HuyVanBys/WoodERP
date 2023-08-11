using System;

namespace BOSERP.Modules.HRReward.UI
{
    /// <summary>
    /// Summary description for DMHRRW100
    /// </summary>
    public partial class DMHRRW100 : BOSERPScreen
    {

        public DMHRRW100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAdd_Click(object sender, EventArgs e)
        {
            ((HRRewardModule)Module).AddEmployee();
        }

        private void fld_btnDelete_Click(object sender, EventArgs e)
        {
            ((HRRewardModule)Module).RemoveItemFromRewardList();
        }

        private void fld_lkeHRRewardType_Validated(object sender, EventArgs e)
        {
            ((HRRewardModule)Module).SetMaskForTextBox();
        }

        private void fld_txtHRRewardValue_Validated(object sender, EventArgs e)
        {
            ((HRRewardModule)Module).UpdateValue();
        }
    }
}
