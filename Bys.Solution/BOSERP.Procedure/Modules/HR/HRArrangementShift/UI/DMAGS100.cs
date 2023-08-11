using System;

namespace BOSERP.Modules.HRArrangementShift.UI
{
    /// <summary>
    /// Summary description for DMAGS100
    /// </summary>
    public partial class DMAGS100 : BOSERPScreen
    {

        public DMAGS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddEmployee_Click(object sender, EventArgs e)
        {
            ((HRArrangementShiftModule)Module).AddEmployeeToArrangementShift();
        }

        private void fld_dteHRArrangementShiftDate1_Validated(object sender, EventArgs e)
        {
            ((HRArrangementShiftModule)Module).ChangeArrangementShiftTime();
        }

        private void fld_btnDelete_Click(object sender, EventArgs e)
        {
            ((HRArrangementShiftModule)Module).RemoveEmployeeFromArrangementShiftList();
        }
    }
}
