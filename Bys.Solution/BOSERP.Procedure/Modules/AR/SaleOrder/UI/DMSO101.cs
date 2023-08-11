using DevExpress.XtraTab;
using System;
using System.Data;
using System.Drawing;
using System.Linq;

namespace BOSERP.Modules.SaleOrder.UI
{
    /// <summary>
    /// Summary description for DMSO101
    /// </summary>
    public partial class DMSO101 : BOSERPScreen
    {

        public DMSO101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAdd_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).TakePayment();
        }

        private void fld_btnEdit_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).UpdatePayment();
        }

        private void fld_btnDelete_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).DeletePayment();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).PrintDeposit();
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
