using System;

namespace BOSERP.Modules.SellStaff.UI
{
    /// <summary>
    /// Summary description for DMSS102
    /// </summary>
    public partial class DMSS102 : BOSERPScreen
    {

        public DMSS102()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnShow_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = Convert.ToDateTime(fld_dteDateFrom.Text);
            DateTime dateTo = Convert.ToDateTime(fld_dteDateTo.Text);
            ((SellStaffModule)Module).InvalidateWorkingShifts(dateFrom, dateTo);
        }
    }
}
