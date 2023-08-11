using System;

namespace BOSERP.Modules.SellStaff.UI
{
    /// <summary>
    /// Summary description for DMSS101
    /// </summary>
    public partial class DMSS110 : BOSERPScreen
    {

        public DMSS110()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddPersonReward_Click(object sender, EventArgs e)
        {
            //SellStaffEntities entity = (SellStaffEntities)CurrentModuleEntity;
            //HRQuarterRewardsInfo objQuarterRewardsInfo = (HRQuarterRewardsInfo)entity.MainObject;
            int HRQuarterRewardAmount = 0;
            String HRQuarterRewardType = string.Empty;
            int.TryParse(fld_txtHRQuarterRewardAmount.EditValue.ToString(), out HRQuarterRewardAmount);
            //HRQuarterRewardType=fld_lkeHRQuarterRewardType.EditValue.ToString();
            ((SellStaffModule)Module).AddItemToPersonRewardList(HRQuarterRewardAmount, HRQuarterRewardType);


        }

        private void fld_btnDeletePersonReward_Click(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).RemoveSelectedItemFromPersonRewardList();
        }

    }
}
