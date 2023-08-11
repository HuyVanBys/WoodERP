using System;

namespace BOSERP.Modules.RegisterDormitory.UI
{
    /// <summary>
    /// Summary description for DMRD100
    /// </summary>
    public partial class DMRD100 : BOSERPScreen
    {

        public DMRD100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID1_Validated(object sender, EventArgs e)
        {
            ((Modules.RegisterDormitory.RegisterDormitoryModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_lkeFK_HRDormitoryID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((RegisterDormitoryModule)Module).ChangeDormitory(sender, e);
        }

        private void fld_btnAddEmployee_Click(object sender, EventArgs e)
        {
            ((RegisterDormitoryModule)Module).AddEmployeeToRegisterDormitoryItem();
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((RegisterDormitoryModule)Module).AddContactPersonToRegisterDormitoryItem();
        }
    }
}
