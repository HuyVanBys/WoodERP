using System;

namespace BOSERP.Modules.GeneralAccounting.UI
{
    /// <summary>
    /// Summary description for DMGA100
    /// </summary>
    public partial class DMGA100 : BOSERPScreen
    {

        public DMGA100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_tabControl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            ((GeneralAccountingModule)Module).RefreshBriefDocumentEntrys();
        }

        private void fld_btnRefresh_Click(object sender, EventArgs e)
        {
            ((GeneralAccountingModule)Module).RefreshData();
        }

        private void fld_dteACDocumentDate2_Validated(object sender, EventArgs e)
        {
            ((GeneralAccountingModule)Module).ChangeDate();
        }
    }
}
