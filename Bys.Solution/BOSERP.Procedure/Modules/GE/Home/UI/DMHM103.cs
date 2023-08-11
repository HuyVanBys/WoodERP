using DevExpress.XtraTab;
using System;
using System.Data;
using System.Drawing;
using System.Linq;

namespace BOSERP.Modules.Home.UI
{
    /// <summary>
    /// Summary description for DMHM103
    /// </summary>
    public partial class DMHM103 : BOSERPScreen
    {

        public DMHM103()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnShow_Click(object sender, EventArgs e)
        {
            ((HomeModule)Module).ShowHistoryDetailsOfSaleOrder();
        }

        private void fld_btnAccept_Click(object sender, EventArgs e)
        {
            ((HomeModule)Module).DeleteHistoryDetailsOfSaleOrder();
        }

        private void fld_chkCheckAllSaleOrder_CheckedChanged(object sender, EventArgs e)
        {
            ((HomeModule)Module).CheckAllHistoryDetailsOfSaleOrder();
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
