using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.LumberProduct
{
    public partial class guiShowProductBranchPriceHistory : BOSERPScreen
    {
        /// <summary>
        /// Gets or sets product branch price grid control 
        /// </summary>
        public BOSGridControl ProductBranchPricesGridControl { get; set; }
        public guiShowProductBranchPriceHistory()
        {
            InitializeComponent();
            ProductBranchPricesGridControl = new BOSGridControl();
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void guiShowProductBranchPrice_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            LumberProductEntities entity = (LumberProductEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.ProductBranchPriceList.InitBOSListGridControl(fld_dgcICProductBranchPricesHistory);
            ((LumberProductModule)Module).InvalidateProductBranchPriceHistoryWithCurrency(fld_dgcICProductBranchPricesHistory);
        }
        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
