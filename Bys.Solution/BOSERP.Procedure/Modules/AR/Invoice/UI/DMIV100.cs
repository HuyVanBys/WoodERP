using BOSCommon;
using BOSComponent;
using Localization;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.Invoice.UI
{
    /// <summary>
    /// Summary description for DMIV100
    /// </summary>
    public partial class DMIV100 : BOSERPScreen
    {

        public DMIV100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID1_Validated(object sender, EventArgs e)
        {
            ((Modules.Invoice.InvoiceModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_txtARInvoiceDiscountFix_Validated(object sender, EventArgs e)
        {
            ((Modules.Invoice.InvoiceModule)this.Module).ChangeDiscountAmount();
        }

        private void fld_txtARInvoiceDiscountPerCent_Validated(object sender, EventArgs e)
        {
            ((Modules.Invoice.InvoiceModule)this.Module).ChangeDiscountPercent();
        }

        private void fld_bedARInvoicePaymentTerm_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((Modules.Invoice.InvoiceModule)this.Module).ShowPaymentInfo();
        }

        private void fld_btnEditShippingInfo_Click(object sender, EventArgs e)
        {
            ((Modules.Invoice.InvoiceModule)this.Module).ShowShippingInfo();
        }

        private void fld_lkeFK_ARCustomerID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((Modules.Invoice.InvoiceModule)this.Module).ChangeCustomer(sender, e);
        }

        private void fld_lkeFK_ARPriceLevelID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((Modules.Invoice.InvoiceModule)this.Module).ChangePriceLevel(sender, e);
        }

        private void fld_lkeFK_ICProductAttributeID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int productID = 0;
                Int32.TryParse(fld_lkeFK_ICProductAttributeID.EditValue.ToString(), out productID);
                ICProductsController controller = new ICProductsController();
                bool checkLocked = ((ICProductsInfo)controller.GetObjectByID(productID)).ICProductActiveCheck;
                if (!checkLocked)
                {
                    MessageBox.Show(POSLocalizedResources.ProductNoneActiveErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ((InvoiceModule)Module).AddItemToInvoiceItemsList();
            }
        }

        private void fld_txtARInvoiceTaxPercent_Validated(object sender, EventArgs e)
        {
            ((Modules.Invoice.InvoiceModule)this.Module).ChangeTaxPercent();
        }

        private void fld_txtARInvoiceTaxAmount_Validated(object sender, EventArgs e)
        {
            ((Modules.Invoice.InvoiceModule)this.Module).ChangeTaxAmount();
        }

        private void fld_txtARInvoiceDepositBalance_Validated(object sender, EventArgs e)
        {
            ((Modules.Invoice.InvoiceModule)this.Module).ChangeDepositBalance();
        }

        private void fld_txtARInvoiceShippingFees_Validated(object sender, EventArgs e)
        {
            ((InvoiceModule)Module).ChangeShippingFee();
        }

        private void fld_lkeARInvoiceProductType_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeARInvoiceProductType.EditValue != null)
            {
                if (fld_lkeARInvoiceProductType.EditValue.ToString() == ProductType.Roundwood.ToString())
                {
                    ((InvoiceModule)Module).ChangedInputType(ProductType.Roundwood.ToString());
                }
                else if (fld_lkeARInvoiceProductType.EditValue.ToString().Contains(ProductType.Lumber.ToString()))
                {
                    ((InvoiceModule)Module).ChangedInputType(ProductType.Lumber.ToString());
                }
                else
                {
                    ((InvoiceModule)Module).ChangedInputType(fld_lkeARInvoiceProductType.EditValue.ToString());
                }
            }
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((InvoiceModule)Module).UpdateTotalAmountByCurrency(Convert.ToInt32(e.Value));
            }
        }

        private void fld_dteARInvoiceDeliveryDate_Validated(object sender, EventArgs e)
        {
            ((InvoiceModule)Module).ChangeInvoiceDeliveryDate();
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                if (!((InvoiceModule)Module).IsEditableObject())
                {
                    e.Value = lke.OldEditValue;
                    MessageBox.Show("Không thể thay đổi đối tượng!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    ((InvoiceModule)Module).ChangeObject(Convert.ToString(e.Value));
            }
        }

        private void fld_lkeFK_ACCostCenterID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((InvoiceModule)Module).ChangeCostCenter(Convert.ToInt32(e.Value.ToString()));
            }
        }

        private void Fld_lkeFK_ICProductAttributeID_QueryPopUp(object sender, CancelEventArgs e)
        {
            ItemLookupEdit lke = (ItemLookupEdit)sender;
            if (lke != null)
            {
                lke.Properties.DataSource = ((InvoiceModule)Module).GetDataForProductLookUpEdit();
            }
        }

        private void Fld_lkeARInvoiceProductType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (e.Value != null)
            {
                if (e.Value.ToString() == ProductType.Roundwood.ToString())
                {
                    ((InvoiceModule)Module).ChangedInputType(ProductType.Roundwood.ToString());
                }
                else if (e.Value.ToString().Contains(ProductType.Lumber.ToString()))
                {
                    ((InvoiceModule)Module).ChangedInputType(ProductType.Lumber.ToString());
                }
                else
                {
                    ((InvoiceModule)Module).ChangedInputType(e.Value.ToString());
                }
            }
        }

        private void fld_lkeFK_ACEInvoiceTypeID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            int objectID = 0;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                Int32.TryParse(e.Value.ToString(), out objectID);
                ((InvoiceModule)Module).ChangeACEInvoiceTypeNo(objectID);
            }

        }

        private void fld_txtARSaleOrderCustomerCommissionPercent_Validated(object sender, EventArgs e)
        {
            ((InvoiceModule)Module).ChangeCommissionPercent();
        }

        private void fld_txtARSaleOrderSOCommissionAmount_Validated(object sender, EventArgs e)
        {
            ((InvoiceModule)Module).ChangeCommissionAmount();
        }

        private void Fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((InvoiceModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ACObjectID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue != null && e.OldValue != null && e.NewValue.ToString() != e.OldValue.ToString())
            {
                if (!((InvoiceModule)Module).IsEditableObject())
                {
                    e.NewValue = e.OldValue;
                    MessageBox.Show("Không thể thay đổi đối tượng!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                else
                    ((InvoiceModule)Module).ChangeObject(e.NewValue.ToString());
            }
        }

        private void fld_lkeAROutputVATDocumentType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;            
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((InvoiceModule)Module).ChangeOutputVATDocumentType(e.Value.ToString());
            }
        }
    }
}
