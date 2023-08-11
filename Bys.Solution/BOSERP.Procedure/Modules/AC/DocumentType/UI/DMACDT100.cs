using System;

namespace BOSERP.Modules.ACDocumentType.UI
{
    /// <summary>
    /// Summary description for DMACDT100
    /// </summary>
    public partial class DMACDT100 : BOSERPScreen
    {

        public DMACDT100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_tmiEditDocumentType_Click(object sender, EventArgs e)
        {
            ((ACDocumentTypeModule)Module).ChangeDocumentType();
        }

        private void fld_tmiConfigEntry_Click(object sender, EventArgs e)
        {
            ((ACDocumentTypeModule)Module).ConfigEntryType();
        }

        private void fld_btnSaveACDocTypeEntryFunctionMappings_Click(object sender, EventArgs e)
        {
            ((ACDocumentTypeModule)Module).SaveACDocTypeEntryFunctionMappings();
        }

        private void fld_btnSaveSTModulePostings_Click(object sender, EventArgs e)
        {
            ((ACDocumentTypeModule)Module).SaveSTModulePostingList();
        }

        private void fld_btnSaveAccountCostTranfer_Click(object sender, EventArgs e)
        {
            ((ACDocumentTypeModule)Module).SaveAccountTranferCost();
        }
    }
}
