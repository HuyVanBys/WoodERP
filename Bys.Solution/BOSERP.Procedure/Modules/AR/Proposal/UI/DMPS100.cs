using BOSComponent;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace BOSERP.Modules.Proposal.UI
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
            ((Modules.Proposal.ProposalModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_btnARProposalAdd_Click(object sender, EventArgs e)
        {
            ((Modules.Proposal.ProposalModule)this.Module).AddItemToProposalItemsList();
        }

        private void fld_btnARProposalDelete_Click(object sender, EventArgs e)
        {
            ((Modules.Proposal.ProposalModule)this.Module).DeleteItemFromProposalItemsList();
        }

        private void fld_btnARProposalEdit_Click(object sender, EventArgs e)
        {
            //((Modules.Proposal.ProposalModule)this.Module).ChangeItemFromProposalItemsList();
        }

        private void fld_txtARProposalDiscountFix_Validated(object sender, EventArgs e)
        {
            
        }

        private void fld_txtARProposalDiscountPerCent_Validated(object sender, EventArgs e)
        {
            ((Modules.Proposal.ProposalModule)this.Module).ChangeDiscountPercent();
        }

        private void fld_bedButtonEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((Modules.Proposal.ProposalModule)this.Module).ShowPaymentInfo();
        }

        private void fld_lkeFK_ARCustomerID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((ProposalModule)this.Module).ChangeCustomer(sender, e);
        }

        private void fld_lkeFK_ARPriceLevelID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((ProposalModule)this.Module).ChangePriceLevel(sender, e);
        }

        private void fld_lkeFK_ICProductAttributeID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int productID = 0;
                Int32.TryParse(fld_lkeFK_ICProductAttributeID.EditValue.ToString(), out productID);
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
                if (!objProductsInfo.ICProductActiveCheck)
                {
                    MessageBox.Show(POSLocalizedResources.ProductNoneActiveErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (objProductsInfo.ICProductNonRetail)
                {
                    MessageBox.Show(POSLocalizedResources.ProductNonRetailMessages, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ((ProposalModule)Module).AddItemToProposalItemsList();
            }
        }

        private void fld_btnShowProductCollection_Click(object sender, EventArgs e)
        {
            ((ProposalModule)Module).AddCollectionToProposal();
        }

        private void fld_txtARProposalCustomerCommissionPercent_Validated(object sender, EventArgs e)
        {
            ((ProposalModule)Module).ChangeCommissionPercent();
        }

        private void fld_txtARProposalSOCommissionAmount_Validated(object sender, EventArgs e)
        {
            ((ProposalModule)Module).ChangeCommissionAmount();
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            AccObjectLookupEdit lke = (AccObjectLookupEdit)sender;
            if (e.Value == null)
            {
                ((ProposalModule)Module).ChangeObject(string.Empty);
            }
            else if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((ProposalModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void fld_txtARProposalTaxPercent_Validated(object sender, EventArgs e)
        {
            ((Modules.Proposal.ProposalModule)this.Module).ChangeTaxPercent();
        }

        private void fld_txtARProposalTaxAmount_Validated(object sender, EventArgs e)
        {
            //BOSTextBox tbe = (BOSTextBox)sender;
            //if (tbe != null && tbe.EditValue != tbe.OldEditValue)
            //{
            //    ((Modules.Proposal.ProposalModule)this.Module).ChangeTaxAmount();
            //}
        }

        private void fld_btnAddProductWork_Click(object sender, EventArgs e)
        {
            ((Modules.Proposal.ProposalModule)this.Module).AddWorkItemToProposalItemWorksCostList();
        }

        private void fld_btnAddProductMaterial_Click(object sender, EventArgs e)
        {
            ((Modules.Proposal.ProposalModule)this.Module).AddMaterialItemProposalItemWorksCostList();
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((Modules.Proposal.ProposalModule)this.Module).AddItemWork();
        }

        private void fld_dteARProposalDate_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSDateEdit lke = (BOSDateEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                DateTime dt = DateTime.Now;
                if (DateTime.TryParse(e.Value.ToString(), out dt))
                {
                    ((ProposalModule)Module).ChangeDateTime(dt);
                }
            }
        }

        private void fld_btnAddProductAsset_Click(object sender, EventArgs e)
        {
            ((ProposalModule)Module).AddProposalItemWorkAsset();
        }

        private void fld_btnAddTask_Click(object sender, EventArgs e)
        {
            ((ProposalModule)Module).AddProposalItemWorkTask();
        }

        private void fld_btnAddCost_Click(object sender, EventArgs e)
        {
            ((ProposalModule)Module).AddItemCost();
        }

        private void fld_lkeFK_GEPaymentTermID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                int paymentTermID = 0;
                if (int.TryParse(e.Value.ToString(), out paymentTermID))
                {
                    if (((ProposalModule)Module).CheckPaymentTerm(paymentTermID) == false)
                    {
                        e.Value = lke.OldEditValue;
                    }
                }
            }
        }

        private void fld_lnkChooseProspectCustomer_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((ProposalModule)Module).ChooseProspectCustomer();
        }

        private void fld_lkeFK_ICProductAttributeID_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;
            List<ICProductsForViewInfo> list = BOSApp.CurrentProductList.Where(o => o.ICProductType == "ProductProposal" || o.ICProductType == "Product" || o.ICProductType == "SemiProduct").ToList();
            lke.Properties.DataSource = list;
        }

        private void fld_lkeFK_ACCostCenterID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((ProposalModule)Module).ChangeCostCenter(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_PMProjectID_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;
            lke.Properties.DataSource = ((ProposalModule)Module).GetAllProjectForLookUp();
        }

        private void fld_lkeFK_ARSaleContractID_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;
            List<ARSaleContractsInfo> results = ((ProposalModule)Module).GetSaleContractByObjectIDAnProjectID();
            lke.Properties.DataSource = results;
        }

        private void Fld_lkeFK_PMTemplateID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke != null && lke.OldEditValue != e.Value)
                ((ProposalModule)Module).GenDataSourceForProposalTemplateItems(Convert.ToInt32(e.Value));
        }

        private void Fld_txtARProposalDiscountPerCentForItem_Validated(object sender, EventArgs e)
        {
            ((Modules.Proposal.ProposalModule)this.Module).ChangeDiscountPercentForItem();
        }

        private void Fld_lkeARProposalSaleType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            //BOSLookupEdit lke = (BOSLookupEdit)sender;
            //if (e.Value != null && e.Value != lke.OldEditValue)
            //{
            //    ((ProposalModule)Module).UpdatePriceForSaleType(e.Value.ToString());
            //}
            //((ProposalModule)Module).ChangeGECurrency();
        }
        private void Fld_lkeARProposalSaleType_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            ((ProposalModule)Module).ChangeSaleType();
        }

        private void Fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ARProposalsInfo mainObject = (ARProposalsInfo)((ProposalModule)Module).CurrentModuleEntity.MainObject;
                if (mainObject.FK_ARPriceSheetID > 0)
                {
                    MessageBox.Show("Loại tiền tệ khác với bảng giá, không được thay đổi", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Value = lke.OldEditValue;
                }
                else
                {
                    ARConfigOriginalUnitPricesController objcoupController = new ARConfigOriginalUnitPricesController();
                    ARConfigOriginalUnitPricesInfo objconfigPrice = objcoupController.GetOriginalIsAlive();
                    if (objconfigPrice != null)
                    {
                        if (objconfigPrice.ARConfigOriginalUnitPriceVoucher)
                        {
                            if (MessageBox.Show("Thay đổi loại tiền tệ sẽ thay đổi đơn giá gốc, bạn có chắc muốn thay đổi không? "
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                ((ProposalModule)Module).UpdateTotalAmountByCurrency(Convert.ToInt32(e.Value));
                            }
                            else
                            {
                                e.Value = lke.OldEditValue;
                            }
                        }
                        else
                        {
                            ((ProposalModule)Module).UpdateTotalAmountByCurrency(Convert.ToInt32(e.Value));
                        }
                    }
                }
            }
        }

        private void bosLookupEdit1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((ProposalModule)Module).UpdateTotalAmountByCurrency2(Convert.ToInt32(e.Value));
            }
        }

        private void bosTextBox4_Validated(object sender, EventArgs e)
        {
            ((ProposalModule)Module).UpdatePriceForcurrencyOrExchange(true);
        }

        private void bosTextBox5_Validated(object sender, EventArgs e)
        {
            ((ProposalModule)Module).UpdatePriceForcurrencyOrExchange(false);
        }

        private void bosLookupEdit2_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ARProposalsInfo mainObject = (ARProposalsInfo)((ProposalModule)Module).CurrentModuleEntity.MainObject;
            string proposalSourceSellingPriceMethod = e.Value.ToString();
            if (proposalSourceSellingPriceMethod == mainObject.ARProposalSourceSellingPriceMethod)
                return;
            ((ProposalModule)Module).ChangeSourceSellingPriceMethod(proposalSourceSellingPriceMethod);
        }

        private void fld_txtARProposalDiscountFix_Modified(object sender, EventArgs e)
        {
            BOSTextBox tbe = (BOSTextBox)sender;
            if (tbe != null && tbe.EditValue != tbe.OldEditValue)
            {
                ((Modules.Proposal.ProposalModule)this.Module).ChangeDiscountAmount();
            }
        }

        private void fld_txtARProposalTaxAmount_Modified(object sender, EventArgs e)
        {
            BOSTextBox tbe = (BOSTextBox)sender;
            if (tbe != null && tbe.EditValue != tbe.OldEditValue)
            {
                ((Modules.Proposal.ProposalModule)this.Module).ChangeTaxAmount();
            }
        }
    }
}
