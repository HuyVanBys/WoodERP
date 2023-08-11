using BOSCommon;
using BOSComponent;
using DevExpress.XtraTab;
using Localization;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.InvoiceIn.UI
{
    /// <summary>
    /// Summary description for DMII100
    /// </summary>
    public partial class DMII100 : BOSERPScreen
    {

        public DMII100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnEditShippingInfo_Click(object sender, EventArgs e)
        {
            ((InvoiceInModule)Module).ChangeShippingInfo();
        }

        //private void fld_lkeFK_APSupplierID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        //{
        //    ((InvoiceInModule)Module).ChangeSupplier(sender, e);
        //}

        private void fld_bedAPInvoiceInPaymentTerm_Click(object sender, EventArgs e)
        {
            ((InvoiceInModule)Module).ChangePaymentTerm();
        }

        private void fld_txtAPInvoiceInDiscountPercent_Validated(object sender, EventArgs e)
        {
            ((InvoiceInModule)Module).ChangeDiscountPercent();
        }

        private void fld_txtAPInvoiceInDiscountFix_Validated(object sender, EventArgs e)
        {
            ((InvoiceInModule)Module).ChangeDiscountAmount();
        }

        private void fld_txtAPInvoiceInShippingExtraFees_Validated(object sender, EventArgs e)
        {
            ((Modules.InvoiceIn.InvoiceInModule)this.Module).ChangeShippingFee();
        }

        private void fld_txtAPInvoiceInShippingFees_Validated(object sender, EventArgs e)
        {
            ((InvoiceInModule)Module).ChangeShippingFee();
        }

        private void fld_lkeFK_HREmployeeID1_Validated(object sender, EventArgs e)
        {
            ((InvoiceInModule)Module).ChangeStaff(sender, e);
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((InvoiceInModule)Module).AddItemToInvoiceInItemsList();
            }
        }

        private void fld_txtAPInvoiceInTaxPercent_Validated(object sender, EventArgs e)
        {
            ((InvoiceInModule)Module).ChangeTaxPercent();
        }

        private void fld_txtAPInvoiceInTaxAmount_Validated(object sender, EventArgs e)
        {
            ((InvoiceInModule)Module).ChangeTaxAmount();
        }

        private void fld_txtAPInvoiceInDepositBalance_Validated(object sender, EventArgs e)
        {
            ((InvoiceInModule)Module).ChangeDepositBalance();
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((InvoiceInModule)Module).ChangeCurrency(Convert.ToInt32(e.Value));
            }
        }

        public override void AddControlsToParentScreen()
        {
            base.AddControlsToParentScreen();

            BaseModuleERP module = (BaseModuleERP)Module;
            XtraTabPage page = module.ParentScreen.ScreenContainer.TabPages.Where(p => p.Name == ScreenNumber).FirstOrDefault();
            if (page != null)
            {
                page.AutoScrollMinSize = new Size(Width, Height);
            }
        }

        private void fld_lkeAPInvoiceInType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((InvoiceInModule)Module).ChangeInvoiceInType(e.Value.ToString());
            }
        }

        private void fld_lkeAPInvoiceInType_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeAPInvoiceInType.EditValue != null && !string.IsNullOrEmpty(fld_lkeAPInvoiceInType.EditValue.ToString()))
            {
                if (fld_lkeAPInvoiceInType.EditValue.ToString() == ProductType.Roundwood.ToString())
                {
                    ((InvoiceInModule)Module).ChangedInputType(ProductType.Roundwood.ToString());
                }
                else if (fld_lkeAPInvoiceInType.EditValue.ToString() == ProductType.Lumber.ToString()
                    || fld_lkeAPInvoiceInType.EditValue.ToString() == ProductType.Verneer.ToString()
                    || fld_lkeAPInvoiceInType.EditValue.ToString() == ProductType.ArtificialBoard.ToString())
                {
                    ((InvoiceInModule)Module).ChangedInputType(fld_lkeAPInvoiceInType.EditValue.ToString());
                }
                else
                {
                    ((InvoiceInModule)Module).ChangedInputType(ProductType.Product.ToString());
                }
            }
        }

        private void fld_lkeFK_ICProductAttributeID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((InvoiceInModule)Module).AddItemToInvoiceInItemsList();
            }
        }

        private void fld_lkeFK_GECurrencyID_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            ((InvoiceInModule)Module).updateTotalAmountbyCurrecy();
        }

        private void fld_dteARInvoiceDate_Validated(object sender, EventArgs e)
        {
            ((InvoiceInModule)Module).ChangInvoiceInVATDate();
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value.ToString() != lke.OldEditValue.ToString())
            {
                if (!((InvoiceInModule)Module).IsEditableObject())
                {
                    e.Value = lke.OldEditValue;
                    MessageBox.Show("Không thể thay đổi đối tượng khi tạo từ ĐMH/NKMH", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    ((InvoiceInModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void fld_lkeAPInvoiceInChannel_Validated(object sender, EventArgs e)
        {
            ((InvoiceInModule)Module).GenerateAccountingData();
            ((InvoiceInModule)Module).UpdateTotalCost();
        }

        private void fld_lkeFK_GECountryID_Validated(object sender, EventArgs e)
        {
            ((InvoiceInModule)Module).UpdateCountryForInvoiceItemIn();
        }

        private void fld_lkeFK_PMProjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int projectID = 0;
                if (int.TryParse(e.Value.ToString(), out projectID))
                {
                    ((InvoiceInModule)Module).ChangeProject(projectID);
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
                ((InvoiceInModule)Module).ChangeACEInvoiceTypeNo(objectID);
            }
        }

        private void fld_lkeFK_ICProductAttributeTTMTID_Validated(object sender, EventArgs e)
        {
            ((InvoiceInModule)Module).UpdateProductAttributeTTMTForInvoiceInItem();
        }

        private void fld_txtAPInvoiceInPackNo_Validated(object sender, EventArgs e)
        {
            ((InvoiceInModule)Module).ChangePackNo();
        }

        private void fld_lkeFK_ACObjectID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue != null && e.OldValue != null && e.NewValue.ToString() != e.OldValue.ToString())
            {
                if (!((InvoiceInModule)Module).IsEditableObject())
                {
                    e.NewValue = e.OldValue;
                    MessageBox.Show("Không thể thay đổi đối tượng khi tạo từ ĐMH/NKMH", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                else
                    ((InvoiceInModule)Module).ChangeObject(e.NewValue.ToString());
            }
        }
    }
}
