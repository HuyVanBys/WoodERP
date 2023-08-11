using BOSCommon;
using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.ShipmentProposal.UI
{
    /// <summary>
    /// Summary description for DMSP100
    /// </summary>
    public partial class DMSP100 : BOSERPScreen
    {

        public DMSP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((ShipmentProposalModule)Module).AddItemShipmentProposalItemList();
            }
        }

        private void fld_lkeICShipmentProposalType_EditValueChanged(object sender, EventArgs e)
        {
            //if (fld_lkeICShipmentProposalType.EditValue != null)
            //{
            //    if (fld_lkeICShipmentProposalType.EditValue.ToString() == ProductType.Roundwood.ToString())
            //    {
            //        ((ShipmentProposalModule)Module).ChangedInputType(ProductType.Roundwood.ToString());
            //    }
            //    else if (fld_lkeICShipmentProposalType.EditValue.ToString().Contains(ProductType.Lumber.ToString()))
            //    {
            //        ((ShipmentProposalModule)Module).ChangedInputType(ProductType.Lumber.ToString());
            //    }
            //    else
            //    {
            //        ((ShipmentProposalModule)Module).ChangedInputType(ProductType.Product.ToString());
            //    }
            //}
        }

        private void fld_lkeICShipmentProposalProductType_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeICShipmentProposalProductType.EditValue != null)
            {
                if (fld_lkeICShipmentProposalProductType.EditValue.ToString() == ProductType.Roundwood.ToString())
                {
                    ((ShipmentProposalModule)Module).ChangedInputType(ProductType.Roundwood.ToString());
                }
                else if (fld_lkeICShipmentProposalProductType.EditValue.ToString().Contains(ProductType.Lumber.ToString()))
                {
                    ((ShipmentProposalModule)Module).ChangedInputType(ProductType.Lumber.ToString());
                }
                else
                {
                    ((ShipmentProposalModule)Module).ChangedInputType(fld_lkeICShipmentProposalProductType.EditValue.ToString());
                }
            }
        }

        private void bosLookupEdit1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((ShipmentProposalModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }
    }
}
