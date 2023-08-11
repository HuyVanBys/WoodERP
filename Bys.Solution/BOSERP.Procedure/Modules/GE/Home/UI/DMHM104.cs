using DevExpress.XtraTab;
using System;
using System.Data;
using System.Drawing;
using System.Linq;

namespace BOSERP.Modules.Home.UI
{
    /// <summary>
    /// Summary description for DMHM104
    /// </summary>
    public partial class DMHM104 : BOSERPScreen
    {

        public DMHM104()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAccept_Click(object sender, EventArgs e)
        {
            ((HomeModule)Module).DeleteProductHistoryDetails();
        }

        private void fld_btnCancelRemind_Click(object sender, EventArgs e)
        {
            ((HomeModule)Module).CancelProductRemind();
        }

        private void fld_chkCheckAllProduct_CheckedChanged(object sender, EventArgs e)
        {
            ((HomeModule)Module).CheckAllProductHistoryDetails();
        }

        private void fld_btnShow_Click(object sender, EventArgs e)
        {
            ((HomeModule)Module).ShowProductHistoryDetails();
        }

        public override void AddControlsToParentScreen()
        {
            base.AddControlsToParentScreen();

            BaseModuleERP module = (BaseModuleERP)Module;
            XtraTabPage page = module.ParentScreen.ScreenContainer.TabPages.Where(p => p.Name == ScreenNumber).FirstOrDefault();
            if (page != null)
            {
                page.AutoScrollMinSize = new Size(0, 0);
            }
        }
    }
}
