using BOSComponent;
using System;

namespace BOSERP.Modules.WorkProduct.UI
{
    /// <summary>
    /// Summary description for DMWKP100
    /// </summary>
    public partial class DMWKP100 : BOSERPScreen
    {

        public DMWKP100()
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
            ((WorkProductModule)Module).SetDefaultProductDesc();
        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((WorkProductModule)Module).ShowCategoryTree();
        }

        private void fld_lnkOpenSupplier_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((WorkProductModule)Module).ShowSuppliersForm();
        }

        private void fld_bedICProductAttribute_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((WorkProductModule)Module).ShowEditAttributeForm();
        }

        private void fld_lnkEditPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((WorkProductModule)Module).ShowPriceLevelForm();
        }

        private void fld_lnkOpenBranchPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((WorkProductModule)Module).ShowProductBranchPrice();
        }

        private void fld_lnkEditPurchasePrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((WorkProductModule)Module).EditPurchasePriceByCurrency();
        }

        private void fld_btnAddProductWorkItem_Click(object sender, EventArgs e)
        {
            ((WorkProductModule)Module).AddWorkItemToProductWorkItemsList();
        }

        private void fld_btnAddProductWorkItem1_Click(object sender, EventArgs e)
        {
            ((WorkProductModule)Module).AddWorkItemToProductWorkItemsList();
        }

        private void fld_btnAddTask_Click(object sender, EventArgs e)
        {
            ((WorkProductModule)Module).AddTaskToProductTaskList();
        }

        private void fld_lkeFK_ICProductTypeAccountConfigID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {

            BOSLookupEdit lke = (BOSLookupEdit)sender;
            int objectID = 0;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                Int32.TryParse(e.Value.ToString(), out objectID);
                ((WorkProductModule)Module).ChangeProductTypeAccountConfig(objectID);
            }
        }
    }
}
