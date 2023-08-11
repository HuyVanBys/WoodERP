using System;

namespace BOSERP.Modules.HREmployeePieceWage.UI
{
    /// <summary>
    /// Summary description for DMHRPW100
    /// </summary>
    public partial class DMHRPW100 : BOSERPScreen
    {

        public DMHRPW100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddEmployee_Click(object sender, EventArgs e)
        {
            ((HREmployeePieceWageModule)Module).AddEmployeeToEmployeePieceWageItemList();
        }

        private void fld_dteHREmployeePieceWageFromDate1_Validated(object sender, EventArgs e)
        {
            ((HREmployeePieceWageModule)Module).UpdateDateEnd();
        }

        private void fld_txtHREmployeePieceWageToDate_EditValueChanged(object sender, EventArgs e)
        {
            //((HREmployeePieceWageModule)Module).Check();
        }

        private void fld_lkeFK_HRProductPieceWageID_Validated(object sender, EventArgs e)
        {
            ((HREmployeePieceWageModule)Module).ChangeProductPieceWage(int.Parse(fld_lkeFK_HRProductPieceWageID.EditValue.ToString()));
        }

        private void fld_txtHREmployeePieceWageRealProductTotalQty_Validated(object sender, EventArgs e)
        {
            ((HREmployeePieceWageModule)Module).ChangeProductPieceWageRealProductTotalQty();
        }
    }
}
