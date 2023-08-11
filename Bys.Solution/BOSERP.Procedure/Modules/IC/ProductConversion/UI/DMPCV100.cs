using BOSComponent;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConversion.UI
{
    /// <summary>
    /// Summary description for DMPCV100
    /// </summary>
    public partial class DMPCV100 : BOSERPScreen
    {
        public DMPCV100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();


        }

        private void fld_lkeFK_ICStockTargetID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            if (lke == null)
                return;

            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int stockID = Convert.ToInt32(e.Value);
                ((ProductConversionModule)Module).ChangeStockTarget(stockID);
            }
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            if (lke == null)
                return;

            if (e.KeyCode != Keys.Enter)
                return;

            int productID = Convert.ToInt32(lke.EditValue);
            ((ProductConversionModule)Module).AddProductItemSource(productID);
        }

        private void fld_lkeFK_ICProductID2_KeyUp(object sender, KeyEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            if (lke == null)
                return;

            if (e.KeyCode != Keys.Enter)
                return;

            int productID = Convert.ToInt32(lke.EditValue);
            ((ProductConversionModule)Module).AddProductItemTarget(productID);
        }

        private void fld_lkeFK_ICSourceStockID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            if (lke == null)
                return;

            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int stockID = Convert.ToInt32(e.Value);
                ((ProductConversionModule)Module).ChangeStockSource(stockID);
            }
        }

        private void fld_btnViewAllProduct_Click(object sender, EventArgs e)
        {
            ((ProductConversionModule)Module).ShowAllProductConversionItem();
        }

        private void bosLookupEdit1_Validated(object sender, EventArgs e)
        {
            ((ProductConversionModule)Module).ChangeLabelGroup();
        }

        private void fld_btnCopyProduct_Click(object sender, EventArgs e)
        {
            ((ProductConversionModule)Module).CopyProductFromTarget();
        }

        private void fld_btnCopyAllProduct_Click(object sender, EventArgs e)
        {
            ((ProductConversionModule)Module).CopyMultiProductFromTarget();
        }

        private void fld_lkeProductConversionProductType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((ProductConversionModule)Module).ChangeProductType(e.Value.ToString());
            }
        }

        private void fld_btnAddFromPurchaseReceipt_Click(object sender, EventArgs e)
        {
            ((ProductConversionModule)Module).ChooseFromPurchaseReceipt();
        }

        private void fld_lkeGenerationHSPB_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((ProductConversionModule)Module).ChangeGenerationHSPB(e.Value.ToString());
            }
        }

        private void fld_btnShipment_Click(object sender, EventArgs e)
        {
            ((ProductConversionModule)Module).ShipmentProductConversion();
        }

        private void btnGenPackage_Click(object sender, EventArgs e)
        {
            ((ProductConversionModule)Module).ChangePackage();
        }

        private void fld_btnGroupPackage_Click(object sender, EventArgs e)
        {
            ((ProductConversionModule)Module).GroupPackage();
        }

        private void fld_btnClearPackage_Click(object sender, EventArgs e)
        {
            ((ProductConversionModule)Module).ClearPackage();
        }
    }
}
