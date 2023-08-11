using BOSComponent;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.POS.UI
{
    /// <summary>
    /// Summary description for DMPS100
    /// </summary>
    public partial class DMPS100 : BOSERPScreen
    {

        public DMPS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID_Validated(object sender, EventArgs e)
        {
            ((Modules.POS.POSModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_lblViewCustomer_Click(object sender, EventArgs e)
        {
            ((Modules.POS.POSModule)this.Module).SetDefaultValuesFromCustomer();
        }

        private void fld_txtBRPOSDiscountAmount_Validated(object sender, EventArgs e)
        {
            ((Modules.POS.POSModule)this.Module).ChangeDiscountAmount();
        }

        private void fld_btnComplete_Click(object sender, EventArgs e)
        {
            ((Modules.POS.POSModule)this.Module).ActionComplete();
        }

        private void fld_txtBRPOSDiscountPerCent_Validated(object sender, EventArgs e)
        {
            ((Modules.POS.POSModule)this.Module).ChangeDiscountPercent();
        }

        private void fld_lkeFK_ARCustomerID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((Modules.POS.POSModule)this.Module).ChangeCustomer(sender, e);
        }

        private void fld_lkeFK_ARPriceLevelID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((Modules.POS.POSModule)this.Module).ChangePriceLevel(sender, e);
        }

        private void fld_lkeFK_ICProductAttributeID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int productID = 0;
                Int32.TryParse(fld_lkeFK_ICProductAttributeID.EditValue.ToString(), out productID);
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
                if (objProductsInfo != null && !objProductsInfo.ICProductActiveCheck)
                {
                    MessageBox.Show(POSLocalizedResources.ProductNoneActiveErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (objProductsInfo.ICProductNonRetail)
                {
                    MessageBox.Show(POSLocalizedResources.ProductNonRetailMessages, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!objProductsInfo.ICProductActiveCheck)
                {
                    MessageBox.Show(POSLocalizedResources.ProductNonActiveCheck, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ((POSModule)Module).AddItemToInvoiceItemList(productID);
                fld_lkeFK_ICProductAttributeID.EditValue = 0;
            }
        }

        private void fld_txtARInvoiceShippingFees_Validated(object sender, EventArgs e)
        {
            ((Modules.POS.POSModule)this.Module).ChangeShippingFeeAmount();
        }

        private void fld_txtARInvoiceDepositBalance_Validated(object sender, EventArgs e)
        {
            ((Modules.POS.POSModule)this.Module).ChangeDepositBalance();
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            AccObjectLookupEdit lke = (AccObjectLookupEdit)sender;

            if (e.Value == null)
            {
                ((POSModule)Module).ChangeObject(string.Empty);
            }
            else if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((POSModule)Module).ChangeObject(Convert.ToString(e.Value));
            }

        }

        private void fld_btnAddCustomers_Click(object sender, EventArgs e)
        {
            ((POSModule)Module).AddNewCustomer();
        }

        private void fld_lkeFK_ACEInvoiceTypeID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            int objectID = 0;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                Int32.TryParse(e.Value.ToString(), out objectID);
                ((POSModule)Module).ChangeACEInvoiceTypeNo(objectID);
            }
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int currencyID = 0;
                if (Int32.TryParse(e.Value.ToString(), out currencyID))
                {
                    ((POSModule)Module).ChangeCurrency(currencyID);
                }
            }
        }

        private void fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((POSModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_btnAutoSelectProductSerialNo_Click(object sender, EventArgs e)
        {
            ((POSModule)Module).AutoSelectProductSerialNo();
        }

        private void fld_dteARInvoiceDate_Validated(object sender, EventArgs e)
        {
            ((POSModule)Module).ChangeInvoiceDate();
        }

        private void fld_lkeFK_ICProductAttributeID_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;
            lke.Properties.DataSource = ((POSModule)Module).LoadProductList();
        }
    }
}
