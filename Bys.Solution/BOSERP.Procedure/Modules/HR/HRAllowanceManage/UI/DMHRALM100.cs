using System;

namespace BOSERP.Modules.HRAllowanceManage.UI
{
    /// <summary>
    /// Summary description for DMHRAL100
    /// </summary>
    public partial class DMHRALM100 : BOSERPScreen
    {

        public DMHRALM100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAdd_Click(object sender, EventArgs e)
        {
            ((HRAllowanceManageModule)Module).AddEmployee();
        }

        private void fld_btnDelete_Click(object sender, EventArgs e)
        {
            ((HRAllowanceManageModule)Module).RemoveSelectedItemFromAllowancesList();
        }

        private void fld_lkeHRAllowanceType_Validated(object sender, EventArgs e)
        {
            ((HRAllowanceManageModule)Module).SetMaskForAllowanceValue();
        }

    }
}
