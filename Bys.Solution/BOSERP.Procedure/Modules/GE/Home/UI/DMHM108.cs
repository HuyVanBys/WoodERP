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
    public partial class DMHM108 : BOSERPScreen
    {

        public DMHM108()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnShow_Click(object sender, EventArgs e)
        {
            ((HomeModule)Module).DeliveryPlanTruckPointList();
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
