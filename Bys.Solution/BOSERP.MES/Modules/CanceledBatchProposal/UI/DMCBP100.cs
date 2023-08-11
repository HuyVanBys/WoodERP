namespace BOSERP.Modules.CanceledBatchProposal.UI
{
    /// <summary>
    /// Summary description for DMBM100
    /// </summary>
    public partial class DMCBP100 : BOSERPScreen
    {

        public DMCBP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        //private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        ((BatchProposalModule)Module).AddItemToBatchProposalItemsLumberList(0,0,0,0);
        //    }

        //}

        //private void fld_lkeMMProposalType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        //{
        //    BOSComponent.BOSLookupEdit lke = (BOSComponent.BOSLookupEdit)sender;
        //    if (e.Value != lke.OldEditValue)
        //    {
        //        ((BatchProposalModule)Module).EnableControl(e.Value.ToString());
        //    }
        //}

        //private void fld_lkeFK_ICProductID2_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        ((BatchProposalModule)Module).AddItemToBatchProposalItemsList(0, 0, 0, 0);
        //    }
        //}

        //private void fld_lkeMMProposalType_EditValueChanged(object sender, EventArgs e)
        //{
        //    if (fld_lkeMMProposalType.EditValue.ToString() != null)
        //    {
        //        if (fld_lkeMMProposalType.EditValue.ToString() == ProductType.Roundwood.ToString())
        //        {
        //            ((BatchProposalModule)Module).ChangedInputType(ProductType.Roundwood.ToString());
        //        }
        //        else if (fld_lkeMMProposalType.EditValue.ToString() == ProductType.Lumber.ToString())
        //        {
        //            ((BatchProposalModule)Module).ChangedInputType(ProductType.Lumber.ToString());
        //        }
        //        else
        //        {
        //            ((BatchProposalModule)Module).ChangedInputType(ProductType.Product.ToString());
        //        }
        //    }
        //}
    }
}
