using System;

namespace BOSERP.Modules.SectionProduct.UI
{
    /// <summary>
    /// Summary description for DMSTP100
    /// </summary>
    public partial class DMSTP100 : BOSERPScreen
    {

        public DMSTP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void DMWKP100_Load(object sender, EventArgs e)
        {

        }

        private void fld_lnkSetDefaultDesc_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((SectionProductModule)Module).SetDefaultProductDesc();
        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((SectionProductModule)Module).ShowCategoryTree();
        }

        private void fld_lnkOpenSupplier_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((SectionProductModule)Module).ShowSuppliersForm();
        }

        private void fld_bedICProductAttribute_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((SectionProductModule)Module).ShowEditAttributeForm();
        }

        private void fld_lnkEditPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((SectionProductModule)Module).ShowPriceLevelForm();
        }

        private void fld_lnkOpenBranchPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((SectionProductModule)Module).ShowProductBranchPrice();
        }

        private void fld_lnkEditPurchasePrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((SectionProductModule)Module).EditPurchasePriceByCurrency();
        }
    }
}
