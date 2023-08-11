using System;

namespace BOSERP.Modules.HREvaluationStandard.UI
{
    /// <summary>
    /// Summary description for DMHRES101
    /// </summary>
    public partial class DMHRES101 : BOSERPScreen
    {

        public DMHRES101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            ((HREvaluationStandardModule)Module).SaveEvaluationRanks();
        }
    }
}
