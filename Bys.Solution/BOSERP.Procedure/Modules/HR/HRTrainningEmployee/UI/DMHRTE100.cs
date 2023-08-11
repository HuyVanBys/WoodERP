using BOSComponent;
using System;

namespace BOSERP.Modules.HRTrainningEmployee.UI
{
    /// <summary>
    /// Summary description for DMHRTE100
    /// </summary>
    public partial class DMHRTE100 : BOSERPScreen
    {

        public DMHRTE100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HRTrainningClassID_Validated(object sender, EventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            ((HRTrainningEmployeeModule)Module).ChooseTrainningClass(Convert.ToInt32(lke.EditValue));
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            ((HRTrainningEmployeeModule)Module).ActionSave();
        }

    }
}
