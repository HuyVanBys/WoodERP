using BOSComponent;
using System;

namespace BOSERP.Modules.HRTrainningEmployee.UI
{
    /// <summary>
    /// Summary description for DMHRTE101
    /// </summary>
    public partial class DMHRTE101 : BOSERPScreen
    {

        public DMHRTE101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HRTrainningClassID1_Validated(object sender, EventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            ((HRTrainningEmployeeModule)Module).ChooseClassSchedule(Convert.ToInt32(lke.EditValue));
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            ((HRTrainningEmployeeModule)Module).ActionSave();
        }
    }
}
