using System;

namespace BOSERP.Modules.DormitoryCost.UI
{
    /// <summary>
    /// Summary description for DMRD100
    /// </summary>
    public partial class DMDMC100 : BOSERPScreen
    {

        public DMDMC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID1_Validated(object sender, EventArgs e)
        {

        }

        private void fld_lkeFK_HRDormitoryID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {

        }

        private void fld_btnAddEmployee_Click(object sender, EventArgs e)
        {
            ((DormitoryCostModule)Module).AddEmployeeToRegisterDormitoryItem();
        }


        private void fld_txtHRDormitoryCostUnitPriceElectricity_Validated(object sender, EventArgs e)
        {
            ((DormitoryCostModule)Module).UpdateTotalAmountItems();
        }

        private void Fld_txtHRDormitoryCostUnitPriceWater_Validated(object sender, EventArgs e)
        {
            ((DormitoryCostModule)Module).UpdateTotalAmountItems();
        }
    }
}
