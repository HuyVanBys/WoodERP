using BOSCommon;
using System;

namespace BOSERP.Modules.Proposal.UI
{
    /// <summary>
    /// Summary description for DMPS100
    /// </summary>
    public partial class DMPS101 : BOSERPScreen
    {

        public DMPS101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void Fld_btnAddProductSection_Click(object sender, EventArgs e)
        {
            ((Modules.Proposal.ProposalModule)this.Module).AddProductSectionToTemplateItemsList(ProductType.Section.ToString());
        }

        private void Fld_btnAddProductWork_Click(object sender, EventArgs e)
        {
            ((Modules.Proposal.ProposalModule)this.Module).AddProductSectionToTemplateItemsList(ProductType.Work.ToString());
        }
    }
}
