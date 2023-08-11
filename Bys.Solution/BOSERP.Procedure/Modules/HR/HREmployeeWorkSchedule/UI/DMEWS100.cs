using System;

namespace BOSERP.Modules.HREmployeeWorkSchedule.UI
{
    /// <summary>
    /// Summary description for DMEWS100
    /// </summary>
    public partial class DMEWS100 : BOSERPScreen
    {

        public DMEWS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddEmployee_Click(object sender, EventArgs e)
        {
            ((HREmployeeWorkScheduleModule)Module).AddEmployeeToOTList();
        }
    }
}
