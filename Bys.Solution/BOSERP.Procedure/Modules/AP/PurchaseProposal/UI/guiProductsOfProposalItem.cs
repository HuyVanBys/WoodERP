using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseProposal
{
    public partial class guiProductsOfProposalItem : BOSERPScreen
    {
        public guiProductsOfProposalItem()
        {
            InitializeComponent();
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

        private void guiProductsOfProposalItem_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            PurchaseProposalEntities entity = (PurchaseProposalEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.ReferredProposalItemList.InitBOSListGridControl(fld_dgcAPProductsOfProposalItemsGridControl);
            GridView gridView = (GridView)fld_dgcAPProductsOfProposalItemsGridControl.MainView;
            gridView.ExpandAllGroups();
        }

        private void fld_chkSelectAllProposalItem_CheckedChanged(object sender, EventArgs e)
        {
            ((PurchaseProposalModule)Module).CheckAllProposalItems(fld_chkSelectAllProposalItem.Checked);
        }

        private void fld_btnOk_Click(object sender, EventArgs e)
        {
            if (!((PurchaseProposalModule)Module).CheckSelectedProposalItems())
            {
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
