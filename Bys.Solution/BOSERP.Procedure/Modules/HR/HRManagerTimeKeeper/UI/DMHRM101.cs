using System;

namespace BOSERP.Modules.ManagerTimeKeeper.UI
{
    /// <summary>
    /// Summary description for DMHRM101
    /// </summary>
    public partial class DMHRM101 : BOSERPScreen
    {

        public DMHRM101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ((ManagerTimeKeeperModule)this.Module).UpdateEmplyeesToMachineTimeKeeper();
        }

        private void fld_btnApplyTemplate_Click(object sender, EventArgs e)
        {
            ((ManagerTimeKeeperModule)this.Module).UpdateTeamplateOfEmplyeesToMachineTimeKeeper();
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((ManagerTimeKeeperModule)this.Module).UpdateID();
        }

        private void fld_btnApplyDelete_Click(object sender, EventArgs e)
        {
            ((ManagerTimeKeeperModule)this.Module).ClearAllData();
        }

        private void fld_lkeHREmployeeID2_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
