using DevExpress.XtraTab;
using System;
using System.Data;
using System.Drawing;
using System.Linq;

namespace BOSERP.Modules.Home.UI
{
    /// <summary>
    /// Summary description for DMHM101
    /// </summary>
    public partial class DMHM101 : BOSERPScreen
    {

        public DMHM101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnShow_Click(object sender, EventArgs e)
        {
            ((HomeModule)Module).ShowHistoryDetails();
        }

        private void fld_chkCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            ((HomeModule)Module).CheckAllHistoryDetails();
        }

        private void fld_btnAccept_Click(object sender, EventArgs e)
        {
            ((HomeModule)Module).DeleteHistoryDetails();
        }

        private void fld_btnCancelRemind_Click(object sender, EventArgs e)
        {
            ((HomeModule)Module).CancelRemind();
        }

        public override void AddControlsToParentScreen()
        {
            base.AddControlsToParentScreen();

            BaseModuleERP module = (BaseModuleERP)Module;
            XtraTabPage page = module.ParentScreen.ScreenContainer.TabPages.Where(p => p.Name == ScreenNumber).FirstOrDefault();
            if (page != null)
            {
                page.AutoScrollMinSize = new Size(Width, Height);
            }
        }
    }
}
