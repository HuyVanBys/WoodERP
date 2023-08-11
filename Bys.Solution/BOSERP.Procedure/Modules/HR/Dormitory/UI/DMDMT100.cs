using System;

namespace BOSERP.Modules.Dormitory.UI
{
    /// <summary>
    /// Summary description for DMDMT100
    /// </summary>
    public partial class DMDMT100 : BOSERPScreen
    {

        public DMDMT100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID1_Validated(object sender, EventArgs e)
        {
            ((Modules.Dormitory.DormitoryModule)this.Module).ChangeStaff(sender, e);
        }
    }
}
