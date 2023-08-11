using BOSCommon;
using System;
using System.Drawing;

namespace BOSERP.Modules.ProductCriteria.UI
{
    /// <summary>
    /// Summary description for DMPCS100
    /// </summary>
    public partial class DMPCS100 : BOSERPScreen
    {

        public DMPCS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void DMPCS100_Load(object sender, EventArgs e)
        {

        }

        private void fld_btnShowProductCollection_Click(object sender, EventArgs e)
        {
            ((ProductCriteriaModule)Module).AddCollectionToProductCriteriaItemsList();
        }

        private void fld_btnShowProduct_Click(object sender, EventArgs e)
        {
            ((ProductCriteriaModule)Module).AddProductToProductCriteriaItemsList();
        }

        private void fld_txtICProductCriteriaDiscountPercent_Validated(object sender, EventArgs e)
        {
            ((ProductCriteriaModule)Module).UpdateTotalAmount();
        }

        private void fld_txtICProductCriteriaDiscountAmount_Validated(object sender, EventArgs e)
        {
            ((ProductCriteriaModule)Module).UpdateTotalAmount();
        }

        private void fld_chkICProductLockedPurchaseOrder_CheckedChanged(object sender, EventArgs e)
        {
            ((ProductCriteriaModule)Module).UpdateTotalAmount();
        }

        private void fld_dteICProductCriteriaDiscountType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (fld_dteICProductCriteriaDiscountType.OldEditValue != e.Value)
            {
                string productCriteriaDiscountType = e.Value.ToString();
                if (productCriteriaDiscountType != null)
                {
                    if (productCriteriaDiscountType == ProductCriteriaDiscountType.Percent.ToString())
                    {
                        fld_txtICProductCriteriaDiscountPercent.Enabled = true;
                        fld_txtICProductCriteriaDiscountAmount.Enabled = false;
                        fld_txtICProductCriteriaDiscountAmount.EditValue = 0;
                        fld_txtICProductCriteriaDiscountAmount.BackColor = Color.WhiteSmoke;
                        fld_txtICProductCriteriaDiscountPercent.BackColor = Color.White;
                    }
                    if (productCriteriaDiscountType == ProductCriteriaDiscountType.Price.ToString())
                    {
                        fld_txtICProductCriteriaDiscountPercent.Enabled = false;
                        fld_txtICProductCriteriaDiscountPercent.EditValue = 0;
                        fld_txtICProductCriteriaDiscountAmount.Enabled = true;
                        fld_txtICProductCriteriaDiscountPercent.BackColor = Color.WhiteSmoke;
                        fld_txtICProductCriteriaDiscountAmount.BackColor = Color.White;
                    }
                    ((ProductCriteriaModule)Module).UpdateTotalAmount(productCriteriaDiscountType);
                }
            }
        }
    }
}
