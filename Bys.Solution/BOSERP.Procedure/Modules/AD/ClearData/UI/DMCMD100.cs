using System;

namespace BOSERP.Modules.ClearData.UI
{
    /// <summary>
    /// Summary description for DMCMD100
    /// </summary>
    public partial class DMCMD100 : BOSERPScreen
    {

        public DMCMD100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }
        private void fld_btnSaveSTModuleClearDatas_Click(object sender, EventArgs e)
        {
            ((ClearDataModule)Module).SaveSTModulePostingList();
        }
    }
}
