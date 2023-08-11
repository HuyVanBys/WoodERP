using DevExpress.XtraTab;
using System;
using System.Data;
using System.Drawing;
using System.Linq;

namespace BOSERP.Modules.SaleOrderForWood.UI
{
    /// <summary>
    /// Summary description for DMSO101
    /// </summary>
    public partial class DMSOFW101 : BOSERPScreen
    {

        public DMSOFW101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAdd_Click(object sender, EventArgs e)
        {
            ((SaleOrderForWoodModule)Module).TakePayment();
        }

        private void fld_btnEdit_Click(object sender, EventArgs e)
        {
            ((SaleOrderForWoodModule)Module).UpdatePayment();
        }

        private void fld_btnDelete_Click(object sender, EventArgs e)
        {
            ((SaleOrderForWoodModule)Module).DeletePayment();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            ((SaleOrderForWoodModule)Module).PrintDeposit();
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
