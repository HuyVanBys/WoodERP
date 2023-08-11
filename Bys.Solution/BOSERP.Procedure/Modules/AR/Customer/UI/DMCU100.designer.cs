using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Customer.UI
{
    /// <summary>
    /// Summary description for DMCU100
    /// </summary>
    partial class DMCU100
    {
        private BOSComponent.BOSLabel fld_lblLabel16;
        private BOSComponent.BOSLabel fld_lblLabel25;
        private BOSComponent.BOSLabel fld_lblLabel35;
        private BOSComponent.BOSLabel fld_lblLabel38;
        private BOSComponent.BOSLabel fld_lblLabel45;
        private BOSComponent.BOSLabel fld_lblLabel48;
        private BOSComponent.BOSLabel fld_lblLabel49;
        private BOSComponent.BOSLabel fld_lblLabel50;
        private BOSComponent.BOSTextBox fld_txtARCustomerName2;
        private BOSComponent.BOSLabel fld_lblLabel18;
        private BOSComponent.BOSTextBox fld_txtARCustomerContactFirstName;
        private BOSComponent.BOSTextBox fld_txtARCustomerContactPhone;
        private BOSComponent.BOSTextBox fld_txtARCustomerContactTitle;
        private BOSComponent.BOSTextBox fld_txtARCustomerContactFax;
        private BOSComponent.BOSTextBox fld_txtARCustomerContactCellPhone;
        private BOSComponent.BOSTextBox fld_txtARCustomerContactEmail1;
        private BOSComponent.BOSTextBox fld_txtARCustomerContactWebsite;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private BOSComponent.BOSGroupControl fld_grcGroupControl6;
        private BOSComponent.BOSTextBox fld_txtARCustomerNo1;
        private BOSComponent.BOSGroupControl fld_grcGroupControl2;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSLabel fld_lblLabel12;
        private BOSComponent.BOSLabel fld_lblLabel13;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel15;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARPriceLevelID;
        private BOSComponent.BOSTextBox fld_txtARCustomerCreditLimit;
        private BOSComponent.BOSTextBox fld_txtARCustomerDiscount;
        private BOSComponent.BOSTextBox fld_txtARCustomerTaxNumber;
        private BOSComponent.BOSLabel fld_lblLabel19;
        private BOSComponent.BOSLookupEdit fld_lkeARPaymentMethodCombo;


        /// <summary>
        /// Clean up any resources being used
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                if (components != null)
                    components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMCU100));
            this.fld_lblLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel35 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel38 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel45 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel48 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel49 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel50 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerName2 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerContactFirstName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerContactPhone = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerContactTitle = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerContactFax = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerContactCellPhone = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerContactEmail1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerContactWebsite = new BOSComponent.BOSTextBox(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.bosPanel3 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_ARCustomerBusinessTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel50 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARCustomerResourceID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARCustomerTypeAccountConfigID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountDepositID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel38 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountSaleID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel37 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountPurchaseID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel36 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel31 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_medARCustomerDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_chkIsBuyingLocked = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_chkARCustomerActiveCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeARCustomerTypeCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel102 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel96 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARCustomerStartDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_HREmployeeManagementID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel49 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.collapsibleGroupBox1 = new BOSERP.CollapsibleGroupBox();
            this.fld_txtARCustomerCMND = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel32 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel29 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerTaxNumber = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerName3 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerName21 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerName1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl6 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeARCustomerStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel35 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GEPaymentTermID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARCustomerAvailableCredit = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerOwing = new BOSComponent.BOSTextBox(this.components);
            this.fld_Line1 = new BOSComponent.BOSLine(this.components);
            this.fld_lblLabel32 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel30 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARPriceLevelID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARCustomerCreditLimit = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerDiscount = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeARPaymentMethodCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_grcGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeARCustomerSex = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel34 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerLevel = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel30 = new BOSComponent.BOSLabel(this.components);
            this.fld_bedGELocationName = new BOSComponent.BOSButtonEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerContactAddressLine1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel51 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerPaymentAddressEmail = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel48 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerDeliveryAddressEmail = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel47 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerPaymentContactName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel44 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerInvoiceContactName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel43 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerDeliveryHomeNumber = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GEDeliveryCountryID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GEDeliveryWardID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GEDeliveryStreetID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARCustomerDeliveryContactName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel33 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerPaymentAddressTel = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_GEDeliveryStateProvinceID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GEDeliveryDistrictID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel39 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel40 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerDeliveryAddressTel = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel41 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel26 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel42 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerInvoiceAddressTel = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerPaymentAddressPostalCode = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerDeliveryAddressPostalCode = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabelDeliveryPostalCode = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerInvoiceAddressPostalCode = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabelInvoicePostalCode = new BOSComponent.BOSLabel(this.components);
            this.fld_bedGELocationName3 = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_lblLabelPaymentPostalCode = new BOSComponent.BOSLabel(this.components);
            this.fld_bedGELocationName2 = new BOSComponent.BOSButtonEdit(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_bedGELocationName1 = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_txtARCustomerPaymentAddressFax = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerDeliveryAddressFax = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerInvoiceAddressFax = new BOSComponent.BOSTextBox(this.components);
            this.fld_lnkCopyPaymentAddress = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_txtARCustomerPaymentAddressTaxCode = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerDeliveryAddressTaxCode = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerInvoiceAddressTaxCode = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_lnkCopyInvoiceAddress = new DevExpress.XtraEditors.HyperLinkEdit();
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_lnkCopyDeliveryAddress = new DevExpress.XtraEditors.HyperLinkEdit();
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerPaymentAddressLine1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.bosLabel28 = new BOSComponent.BOSLabel(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_txtARCustomerDeliveryAddressLine1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerInvoiceAddressLine1 = new BOSComponent.BOSTextBox(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_ADFengShuisColorID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ADFengShuisGenaralID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ADFengShuisDirectionID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel45 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel46 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerName2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactCellPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactEmail1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactWebsite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            this.bosPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerBusinessTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerResourceID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerTypeAccountConfigID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountDepositID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountSaleID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountPurchaseID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARCustomerDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkIsBuyingLocked.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkARCustomerActiveCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerTypeCombo.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCustomerStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCustomerStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeManagementID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerTaxNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerName3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerName21.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl6)).BeginInit();
            this.fld_grcGroupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEPaymentTermID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerAvailableCredit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerOwing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARPriceLevelID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerCreditLimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARPaymentMethodCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl2)).BeginInit();
            this.fld_grcGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerSex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedGELocationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactAddressLine1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentAddressEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerDeliveryAddressEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentContactName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerInvoiceContactName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerDeliveryHomeNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEDeliveryCountryID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEDeliveryWardID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEDeliveryStreetID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerDeliveryContactName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentAddressTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEDeliveryStateProvinceID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEDeliveryDistrictID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerDeliveryAddressTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerInvoiceAddressTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentAddressPostalCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerDeliveryAddressPostalCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerInvoiceAddressPostalCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedGELocationName3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedGELocationName2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedGELocationName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentAddressFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerDeliveryAddressFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerInvoiceAddressFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkCopyPaymentAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentAddressTaxCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerDeliveryAddressTaxCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerInvoiceAddressTaxCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkCopyInvoiceAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkCopyDeliveryAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentAddressLine1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerDeliveryAddressLine1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerInvoiceAddressLine1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ADFengShuisColorID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ADFengShuisGenaralID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ADFengShuisDirectionID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel16
            // 
            this.fld_lblLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel16.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel16.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel16.Appearance.Options.UseFont = true;
            this.fld_lblLabel16.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel16.BOSComment = "";
            this.fld_lblLabel16.BOSDataMember = "";
            this.fld_lblLabel16.BOSDataSource = "";
            this.fld_lblLabel16.BOSDescription = null;
            this.fld_lblLabel16.BOSError = null;
            this.fld_lblLabel16.BOSFieldGroup = "";
            this.fld_lblLabel16.BOSFieldRelation = "";
            this.fld_lblLabel16.BOSPrivilege = "";
            this.fld_lblLabel16.BOSPropertyName = null;
            this.fld_lblLabel16.Location = new System.Drawing.Point(9, 7);
            this.fld_lblLabel16.Name = "fld_lblLabel16";
            this.fld_lblLabel16.Screen = null;
            this.fld_lblLabel16.Size = new System.Drawing.Size(75, 13);
            this.fld_lblLabel16.TabIndex = 0;
            this.fld_lblLabel16.Tag = "";
            this.fld_lblLabel16.Text = "Mã khách hàng";
            // 
            // fld_lblLabel25
            // 
            this.fld_lblLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel25.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel25.Appearance.Options.UseFont = true;
            this.fld_lblLabel25.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel25.BOSComment = "";
            this.fld_lblLabel25.BOSDataMember = "";
            this.fld_lblLabel25.BOSDataSource = "";
            this.fld_lblLabel25.BOSDescription = null;
            this.fld_lblLabel25.BOSError = null;
            this.fld_lblLabel25.BOSFieldGroup = "";
            this.fld_lblLabel25.BOSFieldRelation = "";
            this.fld_lblLabel25.BOSPrivilege = "";
            this.fld_lblLabel25.BOSPropertyName = null;
            this.fld_lblLabel25.Location = new System.Drawing.Point(9, 59);
            this.fld_lblLabel25.Name = "fld_lblLabel25";
            this.fld_lblLabel25.Screen = null;
            this.fld_lblLabel25.Size = new System.Drawing.Size(79, 13);
            this.fld_lblLabel25.TabIndex = 2;
            this.fld_lblLabel25.Tag = "";
            this.fld_lblLabel25.Text = "Tên khách hàng";
            // 
            // fld_lblLabel35
            // 
            this.fld_lblLabel35.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel35.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel35.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel35.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel35.Appearance.Options.UseFont = true;
            this.fld_lblLabel35.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel35.BOSComment = "";
            this.fld_lblLabel35.BOSDataMember = "";
            this.fld_lblLabel35.BOSDataSource = "";
            this.fld_lblLabel35.BOSDescription = null;
            this.fld_lblLabel35.BOSError = null;
            this.fld_lblLabel35.BOSFieldGroup = "";
            this.fld_lblLabel35.BOSFieldRelation = "";
            this.fld_lblLabel35.BOSPrivilege = "";
            this.fld_lblLabel35.BOSPropertyName = null;
            this.fld_lblLabel35.Location = new System.Drawing.Point(12, 55);
            this.fld_lblLabel35.Name = "fld_lblLabel35";
            this.fld_lblLabel35.Screen = null;
            this.fld_lblLabel35.Size = new System.Drawing.Size(71, 13);
            this.fld_lblLabel35.TabIndex = 2;
            this.fld_lblLabel35.Tag = "";
            this.fld_lblLabel35.Text = "Tên người mua";
            // 
            // fld_lblLabel38
            // 
            this.fld_lblLabel38.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel38.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel38.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel38.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel38.Appearance.Options.UseFont = true;
            this.fld_lblLabel38.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel38.BOSComment = "";
            this.fld_lblLabel38.BOSDataMember = "";
            this.fld_lblLabel38.BOSDataSource = "";
            this.fld_lblLabel38.BOSDescription = null;
            this.fld_lblLabel38.BOSError = null;
            this.fld_lblLabel38.BOSFieldGroup = "";
            this.fld_lblLabel38.BOSFieldRelation = "";
            this.fld_lblLabel38.BOSPrivilege = "";
            this.fld_lblLabel38.BOSPropertyName = null;
            this.fld_lblLabel38.Location = new System.Drawing.Point(12, 115);
            this.fld_lblLabel38.Name = "fld_lblLabel38";
            this.fld_lblLabel38.Screen = null;
            this.fld_lblLabel38.Size = new System.Drawing.Size(57, 13);
            this.fld_lblLabel38.TabIndex = 8;
            this.fld_lblLabel38.Tag = "";
            this.fld_lblLabel38.Text = "Điện thoại 2";
            // 
            // fld_lblLabel45
            // 
            this.fld_lblLabel45.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel45.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel45.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel45.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel45.Appearance.Options.UseFont = true;
            this.fld_lblLabel45.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel45.BOSComment = "";
            this.fld_lblLabel45.BOSDataMember = "";
            this.fld_lblLabel45.BOSDataSource = "";
            this.fld_lblLabel45.BOSDescription = null;
            this.fld_lblLabel45.BOSError = null;
            this.fld_lblLabel45.BOSFieldGroup = "";
            this.fld_lblLabel45.BOSFieldRelation = "";
            this.fld_lblLabel45.BOSPrivilege = "";
            this.fld_lblLabel45.BOSPropertyName = null;
            this.fld_lblLabel45.Location = new System.Drawing.Point(12, 30);
            this.fld_lblLabel45.Name = "fld_lblLabel45";
            this.fld_lblLabel45.Screen = null;
            this.fld_lblLabel45.Size = new System.Drawing.Size(52, 13);
            this.fld_lblLabel45.TabIndex = 0;
            this.fld_lblLabel45.Tag = "";
            this.fld_lblLabel45.Text = "Danh xưng";
            // 
            // fld_lblLabel48
            // 
            this.fld_lblLabel48.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel48.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel48.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel48.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel48.Appearance.Options.UseFont = true;
            this.fld_lblLabel48.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel48.BOSComment = "";
            this.fld_lblLabel48.BOSDataMember = "";
            this.fld_lblLabel48.BOSDataSource = "";
            this.fld_lblLabel48.BOSDescription = null;
            this.fld_lblLabel48.BOSError = null;
            this.fld_lblLabel48.BOSFieldGroup = "";
            this.fld_lblLabel48.BOSFieldRelation = "";
            this.fld_lblLabel48.BOSPrivilege = "";
            this.fld_lblLabel48.BOSPropertyName = null;
            this.fld_lblLabel48.Location = new System.Drawing.Point(12, 137);
            this.fld_lblLabel48.Name = "fld_lblLabel48";
            this.fld_lblLabel48.Screen = null;
            this.fld_lblLabel48.Size = new System.Drawing.Size(25, 13);
            this.fld_lblLabel48.TabIndex = 12;
            this.fld_lblLabel48.Tag = "";
            this.fld_lblLabel48.Text = "Email";
            // 
            // fld_lblLabel49
            // 
            this.fld_lblLabel49.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel49.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel49.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel49.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel49.Appearance.Options.UseFont = true;
            this.fld_lblLabel49.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel49.BOSComment = "";
            this.fld_lblLabel49.BOSDataMember = "";
            this.fld_lblLabel49.BOSDataSource = "";
            this.fld_lblLabel49.BOSDescription = null;
            this.fld_lblLabel49.BOSError = null;
            this.fld_lblLabel49.BOSFieldGroup = "";
            this.fld_lblLabel49.BOSFieldRelation = "";
            this.fld_lblLabel49.BOSPrivilege = "";
            this.fld_lblLabel49.BOSPropertyName = null;
            this.fld_lblLabel49.Location = new System.Drawing.Point(12, 85);
            this.fld_lblLabel49.Name = "fld_lblLabel49";
            this.fld_lblLabel49.Screen = null;
            this.fld_lblLabel49.Size = new System.Drawing.Size(57, 13);
            this.fld_lblLabel49.TabIndex = 6;
            this.fld_lblLabel49.Tag = "";
            this.fld_lblLabel49.Text = "Điện thoại 1";
            // 
            // fld_lblLabel50
            // 
            this.fld_lblLabel50.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel50.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel50.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel50.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel50.Appearance.Options.UseFont = true;
            this.fld_lblLabel50.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel50.BOSComment = "";
            this.fld_lblLabel50.BOSDataMember = "";
            this.fld_lblLabel50.BOSDataSource = "";
            this.fld_lblLabel50.BOSDescription = null;
            this.fld_lblLabel50.BOSError = null;
            this.fld_lblLabel50.BOSFieldGroup = "";
            this.fld_lblLabel50.BOSFieldRelation = "";
            this.fld_lblLabel50.BOSPrivilege = "";
            this.fld_lblLabel50.BOSPropertyName = null;
            this.fld_lblLabel50.Location = new System.Drawing.Point(258, 111);
            this.fld_lblLabel50.Name = "fld_lblLabel50";
            this.fld_lblLabel50.Screen = null;
            this.fld_lblLabel50.Size = new System.Drawing.Size(30, 13);
            this.fld_lblLabel50.TabIndex = 10;
            this.fld_lblLabel50.Tag = "";
            this.fld_lblLabel50.Text = "Số fax";
            // 
            // fld_txtARCustomerName2
            // 
            this.fld_txtARCustomerName2.BOSComment = "";
            this.fld_txtARCustomerName2.BOSDataMember = "ARCustomerName";
            this.fld_txtARCustomerName2.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerName2.BOSDescription = null;
            this.fld_txtARCustomerName2.BOSError = "";
            this.fld_txtARCustomerName2.BOSFieldGroup = "";
            this.fld_txtARCustomerName2.BOSFieldRelation = "";
            this.fld_txtARCustomerName2.BOSPrivilege = "";
            this.fld_txtARCustomerName2.BOSPropertyName = "Text";
            this.fld_txtARCustomerName2.Location = new System.Drawing.Point(97, 56);
            this.fld_txtARCustomerName2.Name = "fld_txtARCustomerName2";
            this.fld_txtARCustomerName2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerName2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerName2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerName2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerName2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerName2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerName2.Screen = null;
            this.fld_txtARCustomerName2.Size = new System.Drawing.Size(366, 20);
            this.fld_txtARCustomerName2.TabIndex = 3;
            this.fld_txtARCustomerName2.Tag = "DC";
            this.fld_txtARCustomerName2.Validated += new System.EventHandler(this.fld_txtARCustomerName2_Validated);
            // 
            // fld_lblLabel18
            // 
            this.fld_lblLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel18.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel18.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel18.Appearance.Options.UseFont = true;
            this.fld_lblLabel18.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel18.BOSComment = "";
            this.fld_lblLabel18.BOSDataMember = "";
            this.fld_lblLabel18.BOSDataSource = "";
            this.fld_lblLabel18.BOSDescription = null;
            this.fld_lblLabel18.BOSError = null;
            this.fld_lblLabel18.BOSFieldGroup = "";
            this.fld_lblLabel18.BOSFieldRelation = "";
            this.fld_lblLabel18.BOSPrivilege = "";
            this.fld_lblLabel18.BOSPropertyName = null;
            this.fld_lblLabel18.Location = new System.Drawing.Point(11, 163);
            this.fld_lblLabel18.Name = "fld_lblLabel18";
            this.fld_lblLabel18.Screen = null;
            this.fld_lblLabel18.Size = new System.Drawing.Size(39, 13);
            this.fld_lblLabel18.TabIndex = 14;
            this.fld_lblLabel18.Tag = "";
            this.fld_lblLabel18.Text = "Website";
            // 
            // fld_txtARCustomerContactFirstName
            // 
            this.fld_txtARCustomerContactFirstName.BOSComment = "";
            this.fld_txtARCustomerContactFirstName.BOSDataMember = "ARCustomerContactName";
            this.fld_txtARCustomerContactFirstName.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerContactFirstName.BOSDescription = null;
            this.fld_txtARCustomerContactFirstName.BOSError = "";
            this.fld_txtARCustomerContactFirstName.BOSFieldGroup = "";
            this.fld_txtARCustomerContactFirstName.BOSFieldRelation = "";
            this.fld_txtARCustomerContactFirstName.BOSPrivilege = "";
            this.fld_txtARCustomerContactFirstName.BOSPropertyName = "Text";
            this.fld_txtARCustomerContactFirstName.Location = new System.Drawing.Point(97, 52);
            this.fld_txtARCustomerContactFirstName.Name = "fld_txtARCustomerContactFirstName";
            this.fld_txtARCustomerContactFirstName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerContactFirstName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerContactFirstName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerContactFirstName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerContactFirstName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerContactFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerContactFirstName.Screen = null;
            this.fld_txtARCustomerContactFirstName.Size = new System.Drawing.Size(366, 20);
            this.fld_txtARCustomerContactFirstName.TabIndex = 2;
            this.fld_txtARCustomerContactFirstName.Tag = "DC";
            // 
            // fld_txtARCustomerContactPhone
            // 
            this.fld_txtARCustomerContactPhone.BOSComment = "";
            this.fld_txtARCustomerContactPhone.BOSDataMember = "ARCustomerContactPhone";
            this.fld_txtARCustomerContactPhone.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerContactPhone.BOSDescription = null;
            this.fld_txtARCustomerContactPhone.BOSError = "";
            this.fld_txtARCustomerContactPhone.BOSFieldGroup = "";
            this.fld_txtARCustomerContactPhone.BOSFieldRelation = "";
            this.fld_txtARCustomerContactPhone.BOSPrivilege = "";
            this.fld_txtARCustomerContactPhone.BOSPropertyName = "Text";
            this.fld_txtARCustomerContactPhone.Location = new System.Drawing.Point(97, 82);
            this.fld_txtARCustomerContactPhone.Name = "fld_txtARCustomerContactPhone";
            this.fld_txtARCustomerContactPhone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerContactPhone.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerContactPhone.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerContactPhone.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerContactPhone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerContactPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerContactPhone.Screen = null;
            this.fld_txtARCustomerContactPhone.Size = new System.Drawing.Size(124, 20);
            this.fld_txtARCustomerContactPhone.TabIndex = 5;
            this.fld_txtARCustomerContactPhone.Tag = "DC";
            // 
            // fld_txtARCustomerContactTitle
            // 
            this.fld_txtARCustomerContactTitle.BOSComment = "";
            this.fld_txtARCustomerContactTitle.BOSDataMember = "ARCustomerContactTitle";
            this.fld_txtARCustomerContactTitle.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerContactTitle.BOSDescription = null;
            this.fld_txtARCustomerContactTitle.BOSError = "";
            this.fld_txtARCustomerContactTitle.BOSFieldGroup = "";
            this.fld_txtARCustomerContactTitle.BOSFieldRelation = "";
            this.fld_txtARCustomerContactTitle.BOSPrivilege = "";
            this.fld_txtARCustomerContactTitle.BOSPropertyName = "Text";
            this.fld_txtARCustomerContactTitle.Location = new System.Drawing.Point(97, 27);
            this.fld_txtARCustomerContactTitle.Name = "fld_txtARCustomerContactTitle";
            this.fld_txtARCustomerContactTitle.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerContactTitle.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerContactTitle.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerContactTitle.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerContactTitle.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerContactTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerContactTitle.Screen = null;
            this.fld_txtARCustomerContactTitle.Size = new System.Drawing.Size(124, 20);
            this.fld_txtARCustomerContactTitle.TabIndex = 0;
            this.fld_txtARCustomerContactTitle.Tag = "DC";
            // 
            // fld_txtARCustomerContactFax
            // 
            this.fld_txtARCustomerContactFax.BOSComment = "";
            this.fld_txtARCustomerContactFax.BOSDataMember = "ARCustomerContactFax";
            this.fld_txtARCustomerContactFax.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerContactFax.BOSDescription = null;
            this.fld_txtARCustomerContactFax.BOSError = "";
            this.fld_txtARCustomerContactFax.BOSFieldGroup = "";
            this.fld_txtARCustomerContactFax.BOSFieldRelation = "";
            this.fld_txtARCustomerContactFax.BOSPrivilege = "";
            this.fld_txtARCustomerContactFax.BOSPropertyName = "Text";
            this.fld_txtARCustomerContactFax.Location = new System.Drawing.Point(339, 108);
            this.fld_txtARCustomerContactFax.Name = "fld_txtARCustomerContactFax";
            this.fld_txtARCustomerContactFax.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerContactFax.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerContactFax.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerContactFax.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerContactFax.Properties.Mask.EditMask = "\\d+";
            this.fld_txtARCustomerContactFax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.fld_txtARCustomerContactFax.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerContactFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerContactFax.Screen = null;
            this.fld_txtARCustomerContactFax.Size = new System.Drawing.Size(124, 20);
            this.fld_txtARCustomerContactFax.TabIndex = 7;
            this.fld_txtARCustomerContactFax.Tag = "DC";
            // 
            // fld_txtARCustomerContactCellPhone
            // 
            this.fld_txtARCustomerContactCellPhone.BOSComment = "";
            this.fld_txtARCustomerContactCellPhone.BOSDataMember = "ARCustomerContactCellPhone";
            this.fld_txtARCustomerContactCellPhone.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerContactCellPhone.BOSDescription = null;
            this.fld_txtARCustomerContactCellPhone.BOSError = "";
            this.fld_txtARCustomerContactCellPhone.BOSFieldGroup = "";
            this.fld_txtARCustomerContactCellPhone.BOSFieldRelation = "";
            this.fld_txtARCustomerContactCellPhone.BOSPrivilege = "";
            this.fld_txtARCustomerContactCellPhone.BOSPropertyName = "Text";
            this.fld_txtARCustomerContactCellPhone.Location = new System.Drawing.Point(97, 108);
            this.fld_txtARCustomerContactCellPhone.Name = "fld_txtARCustomerContactCellPhone";
            this.fld_txtARCustomerContactCellPhone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerContactCellPhone.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerContactCellPhone.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerContactCellPhone.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerContactCellPhone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerContactCellPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerContactCellPhone.Screen = null;
            this.fld_txtARCustomerContactCellPhone.Size = new System.Drawing.Size(124, 20);
            this.fld_txtARCustomerContactCellPhone.TabIndex = 6;
            this.fld_txtARCustomerContactCellPhone.Tag = "DC";
            // 
            // fld_txtARCustomerContactEmail1
            // 
            this.fld_txtARCustomerContactEmail1.BOSComment = "";
            this.fld_txtARCustomerContactEmail1.BOSDataMember = "ARCustomerContactEmail1";
            this.fld_txtARCustomerContactEmail1.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerContactEmail1.BOSDescription = null;
            this.fld_txtARCustomerContactEmail1.BOSError = "";
            this.fld_txtARCustomerContactEmail1.BOSFieldGroup = "";
            this.fld_txtARCustomerContactEmail1.BOSFieldRelation = "";
            this.fld_txtARCustomerContactEmail1.BOSPrivilege = "";
            this.fld_txtARCustomerContactEmail1.BOSPropertyName = "Text";
            this.fld_txtARCustomerContactEmail1.Location = new System.Drawing.Point(97, 134);
            this.fld_txtARCustomerContactEmail1.Name = "fld_txtARCustomerContactEmail1";
            this.fld_txtARCustomerContactEmail1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerContactEmail1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerContactEmail1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerContactEmail1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerContactEmail1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerContactEmail1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerContactEmail1.Screen = null;
            this.fld_txtARCustomerContactEmail1.Size = new System.Drawing.Size(366, 20);
            this.fld_txtARCustomerContactEmail1.TabIndex = 8;
            this.fld_txtARCustomerContactEmail1.Tag = "DC";
            // 
            // fld_txtARCustomerContactWebsite
            // 
            this.fld_txtARCustomerContactWebsite.BOSComment = "";
            this.fld_txtARCustomerContactWebsite.BOSDataMember = "ARCustomerContactWebsite";
            this.fld_txtARCustomerContactWebsite.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerContactWebsite.BOSDescription = null;
            this.fld_txtARCustomerContactWebsite.BOSError = "";
            this.fld_txtARCustomerContactWebsite.BOSFieldGroup = "";
            this.fld_txtARCustomerContactWebsite.BOSFieldRelation = "";
            this.fld_txtARCustomerContactWebsite.BOSPrivilege = "";
            this.fld_txtARCustomerContactWebsite.BOSPropertyName = "Text";
            this.fld_txtARCustomerContactWebsite.Location = new System.Drawing.Point(97, 160);
            this.fld_txtARCustomerContactWebsite.Name = "fld_txtARCustomerContactWebsite";
            this.fld_txtARCustomerContactWebsite.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerContactWebsite.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerContactWebsite.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerContactWebsite.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerContactWebsite.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerContactWebsite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerContactWebsite.Screen = null;
            this.fld_txtARCustomerContactWebsite.Size = new System.Drawing.Size(366, 20);
            this.fld_txtARCustomerContactWebsite.TabIndex = 9;
            this.fld_txtARCustomerContactWebsite.Tag = "DC";
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.BOSComment = "";
            this.fld_grcGroupControl.BOSDataMember = null;
            this.fld_grcGroupControl.BOSDataSource = null;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = "";
            this.fld_grcGroupControl.BOSFieldRelation = null;
            this.fld_grcGroupControl.BOSPrivilege = "";
            this.fld_grcGroupControl.BOSPropertyName = null;
            this.fld_grcGroupControl.Controls.Add(this.bosPanel3);
            this.fld_grcGroupControl.Controls.Add(this.bosPanel1);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(13, 12);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(482, 370);
            this.fld_grcGroupControl.TabIndex = 0;
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // bosPanel3
            // 
            this.bosPanel3.BOSComment = null;
            this.bosPanel3.BOSDataMember = null;
            this.bosPanel3.BOSDataSource = null;
            this.bosPanel3.BOSDescription = null;
            this.bosPanel3.BOSError = null;
            this.bosPanel3.BOSFieldGroup = null;
            this.bosPanel3.BOSFieldRelation = null;
            this.bosPanel3.BOSPrivilege = null;
            this.bosPanel3.BOSPropertyName = null;
            this.bosPanel3.Controls.Add(this.fld_lkeFK_ARCustomerBusinessTypeID);
            this.bosPanel3.Controls.Add(this.bosLabel50);
            this.bosPanel3.Controls.Add(this.bosLookupEdit2);
            this.bosPanel3.Controls.Add(this.bosLabel20);
            this.bosPanel3.Controls.Add(this.fld_lkeFK_ARCustomerResourceID);
            this.bosPanel3.Controls.Add(this.bosLabel17);
            this.bosPanel3.Controls.Add(this.fld_lkeFK_ARCustomerTypeAccountConfigID);
            this.bosPanel3.Controls.Add(this.bosLabel11);
            this.bosPanel3.Controls.Add(this.fld_lkeFK_ACAccountDepositID);
            this.bosPanel3.Controls.Add(this.bosLabel38);
            this.bosPanel3.Controls.Add(this.fld_lkeFK_ACAccountSaleID);
            this.bosPanel3.Controls.Add(this.bosLabel37);
            this.bosPanel3.Controls.Add(this.fld_lkeFK_ACAccountPurchaseID);
            this.bosPanel3.Controls.Add(this.bosLabel36);
            this.bosPanel3.Controls.Add(this.bosLookupEdit1);
            this.bosPanel3.Controls.Add(this.bosLabel31);
            this.bosPanel3.Controls.Add(this.fld_lblLabel17);
            this.bosPanel3.Controls.Add(this.fld_medARCustomerDesc);
            this.bosPanel3.Controls.Add(this.fld_chkIsBuyingLocked);
            this.bosPanel3.Controls.Add(this.fld_chkARCustomerActiveCheck);
            this.bosPanel3.Controls.Add(this.fld_lkeARCustomerTypeCombo);
            this.bosPanel3.Controls.Add(this.fld_lblLabel102);
            this.bosPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel3.Location = new System.Drawing.Point(2, 156);
            this.bosPanel3.Name = "bosPanel3";
            this.bosPanel3.Screen = null;
            this.bosPanel3.Size = new System.Drawing.Size(478, 210);
            this.bosPanel3.TabIndex = 1;
            // 
            // fld_lkeFK_ARCustomerBusinessTypeID
            // 
            this.fld_lkeFK_ARCustomerBusinessTypeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerBusinessTypeID.BOSAllowDummy = true;
            this.fld_lkeFK_ARCustomerBusinessTypeID.BOSComment = "";
            this.fld_lkeFK_ARCustomerBusinessTypeID.BOSDataMember = "FK_ARCustomerBusinessTypeID";
            this.fld_lkeFK_ARCustomerBusinessTypeID.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_ARCustomerBusinessTypeID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerBusinessTypeID.BOSError = null;
            this.fld_lkeFK_ARCustomerBusinessTypeID.BOSFieldGroup = "";
            this.fld_lkeFK_ARCustomerBusinessTypeID.BOSFieldParent = "";
            this.fld_lkeFK_ARCustomerBusinessTypeID.BOSFieldRelation = "";
            this.fld_lkeFK_ARCustomerBusinessTypeID.BOSPrivilege = "";
            this.fld_lkeFK_ARCustomerBusinessTypeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerBusinessTypeID.BOSSelectType = "";
            this.fld_lkeFK_ARCustomerBusinessTypeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARCustomerBusinessTypeID.CurrentDisplayText = null;
            this.fld_lkeFK_ARCustomerBusinessTypeID.Location = new System.Drawing.Point(97, 81);
            this.fld_lkeFK_ARCustomerBusinessTypeID.Name = "fld_lkeFK_ARCustomerBusinessTypeID";
            this.fld_lkeFK_ARCustomerBusinessTypeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerBusinessTypeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerBusinessTypeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerBusinessTypeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerBusinessTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerBusinessTypeID.Properties.ColumnName = null;
            this.fld_lkeFK_ARCustomerBusinessTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerBusinessTypeAbbreviation", "Viết tắt"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerBusinessTypeName", "Loại hình doanh nghiệp")});
            this.fld_lkeFK_ARCustomerBusinessTypeID.Properties.DisplayMember = "ARCustomerBusinessTypeName";
            this.fld_lkeFK_ARCustomerBusinessTypeID.Properties.NullText = "";
            this.fld_lkeFK_ARCustomerBusinessTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerBusinessTypeID.Properties.ValueMember = "ARCustomerBusinessTypeID";
            this.fld_lkeFK_ARCustomerBusinessTypeID.Screen = null;
            this.fld_lkeFK_ARCustomerBusinessTypeID.Size = new System.Drawing.Size(124, 20);
            this.fld_lkeFK_ARCustomerBusinessTypeID.TabIndex = 18;
            this.fld_lkeFK_ARCustomerBusinessTypeID.Tag = "DC";
            // 
            // bosLabel50
            // 
            this.bosLabel50.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel50.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel50.Appearance.Options.UseBackColor = true;
            this.bosLabel50.Appearance.Options.UseForeColor = true;
            this.bosLabel50.BOSComment = "";
            this.bosLabel50.BOSDataMember = "";
            this.bosLabel50.BOSDataSource = "";
            this.bosLabel50.BOSDescription = null;
            this.bosLabel50.BOSError = null;
            this.bosLabel50.BOSFieldGroup = "";
            this.bosLabel50.BOSFieldRelation = "";
            this.bosLabel50.BOSPrivilege = "";
            this.bosLabel50.BOSPropertyName = null;
            this.bosLabel50.Location = new System.Drawing.Point(10, 84);
            this.bosLabel50.Name = "bosLabel50";
            this.bosLabel50.Screen = null;
            this.bosLabel50.Size = new System.Drawing.Size(59, 13);
            this.bosLabel50.TabIndex = 19;
            this.bosLabel50.Tag = "";
            this.bosLabel50.Text = "Loại hình DN";
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = false;
            this.bosLookupEdit2.BOSComment = "";
            this.bosLookupEdit2.BOSDataMember = "ARCustomerDistributionChannelTypeCombo";
            this.bosLookupEdit2.BOSDataSource = "ARCustomers";
            this.bosLookupEdit2.BOSDescription = null;
            this.bosLookupEdit2.BOSError = "";
            this.bosLookupEdit2.BOSFieldGroup = "";
            this.bosLookupEdit2.BOSFieldParent = "";
            this.bosLookupEdit2.BOSFieldRelation = "";
            this.bosLookupEdit2.BOSPrivilege = "";
            this.bosLookupEdit2.BOSPropertyName = "EditValue";
            this.bosLookupEdit2.BOSSelectType = "";
            this.bosLookupEdit2.BOSSelectTypeValue = "";
            this.bosLookupEdit2.CurrentDisplayText = "";
            this.bosLookupEdit2.Location = new System.Drawing.Point(339, 81);
            this.bosLookupEdit2.Name = "bosLookupEdit2";
            this.bosLookupEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit2.Properties.ColumnName = null;
            this.bosLookupEdit2.Properties.NullText = "";
            this.bosLookupEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit2.Screen = null;
            this.bosLookupEdit2.Size = new System.Drawing.Size(124, 20);
            this.bosLookupEdit2.TabIndex = 16;
            this.bosLookupEdit2.Tag = "DC";
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel20.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseFont = true;
            this.bosLabel20.Appearance.Options.UseForeColor = true;
            this.bosLabel20.BOSComment = "";
            this.bosLabel20.BOSDataMember = "";
            this.bosLabel20.BOSDataSource = "";
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = "";
            this.bosLabel20.BOSFieldRelation = "";
            this.bosLabel20.BOSPrivilege = "";
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(258, 84);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(75, 13);
            this.bosLabel20.TabIndex = 17;
            this.bosLabel20.Tag = "";
            this.bosLabel20.Text = "Kênh phân phối";
            // 
            // fld_lkeFK_ARCustomerResourceID
            // 
            this.fld_lkeFK_ARCustomerResourceID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerResourceID.BOSAllowDummy = true;
            this.fld_lkeFK_ARCustomerResourceID.BOSComment = "";
            this.fld_lkeFK_ARCustomerResourceID.BOSDataMember = "FK_ARCustomerResourceID";
            this.fld_lkeFK_ARCustomerResourceID.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_ARCustomerResourceID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerResourceID.BOSError = null;
            this.fld_lkeFK_ARCustomerResourceID.BOSFieldGroup = "";
            this.fld_lkeFK_ARCustomerResourceID.BOSFieldParent = "";
            this.fld_lkeFK_ARCustomerResourceID.BOSFieldRelation = "";
            this.fld_lkeFK_ARCustomerResourceID.BOSPrivilege = "";
            this.fld_lkeFK_ARCustomerResourceID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerResourceID.BOSSelectType = "";
            this.fld_lkeFK_ARCustomerResourceID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARCustomerResourceID.CurrentDisplayText = null;
            this.fld_lkeFK_ARCustomerResourceID.Location = new System.Drawing.Point(339, 55);
            this.fld_lkeFK_ARCustomerResourceID.Name = "fld_lkeFK_ARCustomerResourceID";
            this.fld_lkeFK_ARCustomerResourceID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerResourceID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerResourceID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerResourceID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerResourceID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerResourceID.Properties.ColumnName = null;
            this.fld_lkeFK_ARCustomerResourceID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerResourceNo", "Mã nguồn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerResourceName", "Tên nguồn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerResourceDesc", "Mô tả")});
            this.fld_lkeFK_ARCustomerResourceID.Properties.DisplayMember = "ARCustomerResourceName";
            this.fld_lkeFK_ARCustomerResourceID.Properties.NullText = "";
            this.fld_lkeFK_ARCustomerResourceID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerResourceID.Properties.ValueMember = "ARCustomerResourceID";
            this.fld_lkeFK_ARCustomerResourceID.Screen = null;
            this.fld_lkeFK_ARCustomerResourceID.Size = new System.Drawing.Size(124, 20);
            this.fld_lkeFK_ARCustomerResourceID.TabIndex = 5;
            this.fld_lkeFK_ARCustomerResourceID.Tag = "DC";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = "";
            this.bosLabel17.BOSDataMember = "";
            this.bosLabel17.BOSDataSource = "";
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = "";
            this.bosLabel17.BOSFieldRelation = "";
            this.bosLabel17.BOSPrivilege = "";
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(258, 58);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(31, 13);
            this.bosLabel17.TabIndex = 15;
            this.bosLabel17.Tag = "";
            this.bosLabel17.Text = "Nguồn";
            // 
            // fld_lkeFK_ARCustomerTypeAccountConfigID
            // 
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.BOSAllowDummy = false;
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.BOSComment = "";
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.BOSDataMember = "FK_ARCustomerTypeAccountConfigID";
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.BOSError = "";
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.BOSFieldGroup = "";
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.BOSFieldParent = "";
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.BOSFieldRelation = "";
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.BOSPrivilege = "";
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.BOSSelectType = "";
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.CurrentDisplayText = "";
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.Location = new System.Drawing.Point(97, 107);
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.Name = "fld_lkeFK_ARCustomerTypeAccountConfigID";
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.Properties.ColumnName = null;
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerTypeAccountConfigName", "Nhóm tài khoản")});
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.Properties.DisplayMember = "ARCustomerTypeAccountConfigName";
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.Properties.NullText = "";
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.Properties.ValueMember = "ARCustomerTypeAccountConfigID";
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.Screen = null;
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.Size = new System.Drawing.Size(124, 20);
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.TabIndex = 2;
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.Tag = "DC";
            this.fld_lkeFK_ARCustomerTypeAccountConfigID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ARCustomerTypeAccountConfigID_CloseUp);
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseFont = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = "";
            this.bosLabel11.BOSDataMember = "";
            this.bosLabel11.BOSDataSource = "";
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = "";
            this.bosLabel11.BOSFieldRelation = "";
            this.bosLabel11.BOSPrivilege = "";
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(10, 110);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(75, 13);
            this.bosLabel11.TabIndex = 13;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Nhóm tài khoản";
            // 
            // fld_lkeFK_ACAccountDepositID
            // 
            this.fld_lkeFK_ACAccountDepositID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountDepositID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAccountDepositID.BOSComment = "";
            this.fld_lkeFK_ACAccountDepositID.BOSDataMember = "FK_ACAccountDepositID";
            this.fld_lkeFK_ACAccountDepositID.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_ACAccountDepositID.BOSDescription = null;
            this.fld_lkeFK_ACAccountDepositID.BOSError = "";
            this.fld_lkeFK_ACAccountDepositID.BOSFieldGroup = "";
            this.fld_lkeFK_ACAccountDepositID.BOSFieldParent = "";
            this.fld_lkeFK_ACAccountDepositID.BOSFieldRelation = "";
            this.fld_lkeFK_ACAccountDepositID.BOSPrivilege = "";
            this.fld_lkeFK_ACAccountDepositID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAccountDepositID.BOSSelectType = "";
            this.fld_lkeFK_ACAccountDepositID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACAccountDepositID.CurrentDisplayText = "";
            this.fld_lkeFK_ACAccountDepositID.Location = new System.Drawing.Point(97, 159);
            this.fld_lkeFK_ACAccountDepositID.Name = "fld_lkeFK_ACAccountDepositID";
            this.fld_lkeFK_ACAccountDepositID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACAccountDepositID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACAccountDepositID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACAccountDepositID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACAccountDepositID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAccountDepositID.Properties.ColumnName = null;
            this.fld_lkeFK_ACAccountDepositID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Mã TK"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên TK")});
            this.fld_lkeFK_ACAccountDepositID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACAccountDepositID.Properties.NullText = "";
            this.fld_lkeFK_ACAccountDepositID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAccountDepositID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACAccountDepositID.Screen = null;
            this.fld_lkeFK_ACAccountDepositID.Size = new System.Drawing.Size(124, 20);
            this.fld_lkeFK_ACAccountDepositID.TabIndex = 4;
            this.fld_lkeFK_ACAccountDepositID.Tag = "DC";
            // 
            // bosLabel38
            // 
            this.bosLabel38.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel38.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel38.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel38.Appearance.Options.UseBackColor = true;
            this.bosLabel38.Appearance.Options.UseFont = true;
            this.bosLabel38.Appearance.Options.UseForeColor = true;
            this.bosLabel38.BOSComment = "";
            this.bosLabel38.BOSDataMember = "";
            this.bosLabel38.BOSDataSource = "";
            this.bosLabel38.BOSDescription = null;
            this.bosLabel38.BOSError = null;
            this.bosLabel38.BOSFieldGroup = "";
            this.bosLabel38.BOSFieldRelation = "";
            this.bosLabel38.BOSPrivilege = "";
            this.bosLabel38.BOSPropertyName = null;
            this.bosLabel38.Location = new System.Drawing.Point(10, 162);
            this.bosLabel38.Name = "bosLabel38";
            this.bosLabel38.Screen = null;
            this.bosLabel38.Size = new System.Drawing.Size(72, 13);
            this.bosLabel38.TabIndex = 11;
            this.bosLabel38.Tag = "";
            this.bosLabel38.Text = "TK CN đặt cọc";
            // 
            // fld_lkeFK_ACAccountSaleID
            // 
            this.fld_lkeFK_ACAccountSaleID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountSaleID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAccountSaleID.BOSComment = "";
            this.fld_lkeFK_ACAccountSaleID.BOSDataMember = "FK_ACAccountSaleID";
            this.fld_lkeFK_ACAccountSaleID.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_ACAccountSaleID.BOSDescription = null;
            this.fld_lkeFK_ACAccountSaleID.BOSError = "";
            this.fld_lkeFK_ACAccountSaleID.BOSFieldGroup = "";
            this.fld_lkeFK_ACAccountSaleID.BOSFieldParent = "";
            this.fld_lkeFK_ACAccountSaleID.BOSFieldRelation = "";
            this.fld_lkeFK_ACAccountSaleID.BOSPrivilege = "";
            this.fld_lkeFK_ACAccountSaleID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAccountSaleID.BOSSelectType = "";
            this.fld_lkeFK_ACAccountSaleID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACAccountSaleID.CurrentDisplayText = "";
            this.fld_lkeFK_ACAccountSaleID.Location = new System.Drawing.Point(339, 107);
            this.fld_lkeFK_ACAccountSaleID.Name = "fld_lkeFK_ACAccountSaleID";
            this.fld_lkeFK_ACAccountSaleID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACAccountSaleID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACAccountSaleID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACAccountSaleID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACAccountSaleID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAccountSaleID.Properties.ColumnName = null;
            this.fld_lkeFK_ACAccountSaleID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Mã TK"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên TK")});
            this.fld_lkeFK_ACAccountSaleID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACAccountSaleID.Properties.NullText = "";
            this.fld_lkeFK_ACAccountSaleID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAccountSaleID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACAccountSaleID.Screen = null;
            this.fld_lkeFK_ACAccountSaleID.Size = new System.Drawing.Size(124, 20);
            this.fld_lkeFK_ACAccountSaleID.TabIndex = 6;
            this.fld_lkeFK_ACAccountSaleID.Tag = "DC";
            // 
            // bosLabel37
            // 
            this.bosLabel37.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel37.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel37.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel37.Appearance.Options.UseBackColor = true;
            this.bosLabel37.Appearance.Options.UseFont = true;
            this.bosLabel37.Appearance.Options.UseForeColor = true;
            this.bosLabel37.BOSComment = "";
            this.bosLabel37.BOSDataMember = "";
            this.bosLabel37.BOSDataSource = "";
            this.bosLabel37.BOSDescription = null;
            this.bosLabel37.BOSError = null;
            this.bosLabel37.BOSFieldGroup = "";
            this.bosLabel37.BOSFieldRelation = "";
            this.bosLabel37.BOSPrivilege = "";
            this.bosLabel37.BOSPropertyName = null;
            this.bosLabel37.Location = new System.Drawing.Point(258, 110);
            this.bosLabel37.Name = "bosLabel37";
            this.bosLabel37.Screen = null;
            this.bosLabel37.Size = new System.Drawing.Size(53, 13);
            this.bosLabel37.TabIndex = 9;
            this.bosLabel37.Tag = "";
            this.bosLabel37.Text = "TK CN bán";
            // 
            // fld_lkeFK_ACAccountPurchaseID
            // 
            this.fld_lkeFK_ACAccountPurchaseID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountPurchaseID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAccountPurchaseID.BOSComment = "";
            this.fld_lkeFK_ACAccountPurchaseID.BOSDataMember = "FK_ACAccountPurchaseID";
            this.fld_lkeFK_ACAccountPurchaseID.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_ACAccountPurchaseID.BOSDescription = null;
            this.fld_lkeFK_ACAccountPurchaseID.BOSError = "";
            this.fld_lkeFK_ACAccountPurchaseID.BOSFieldGroup = "";
            this.fld_lkeFK_ACAccountPurchaseID.BOSFieldParent = "";
            this.fld_lkeFK_ACAccountPurchaseID.BOSFieldRelation = "";
            this.fld_lkeFK_ACAccountPurchaseID.BOSPrivilege = "";
            this.fld_lkeFK_ACAccountPurchaseID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAccountPurchaseID.BOSSelectType = "";
            this.fld_lkeFK_ACAccountPurchaseID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACAccountPurchaseID.CurrentDisplayText = "";
            this.fld_lkeFK_ACAccountPurchaseID.Location = new System.Drawing.Point(97, 133);
            this.fld_lkeFK_ACAccountPurchaseID.Name = "fld_lkeFK_ACAccountPurchaseID";
            this.fld_lkeFK_ACAccountPurchaseID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACAccountPurchaseID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACAccountPurchaseID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACAccountPurchaseID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACAccountPurchaseID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAccountPurchaseID.Properties.ColumnName = null;
            this.fld_lkeFK_ACAccountPurchaseID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Mã TK"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên TK")});
            this.fld_lkeFK_ACAccountPurchaseID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACAccountPurchaseID.Properties.NullText = "";
            this.fld_lkeFK_ACAccountPurchaseID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAccountPurchaseID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACAccountPurchaseID.Screen = null;
            this.fld_lkeFK_ACAccountPurchaseID.Size = new System.Drawing.Size(124, 20);
            this.fld_lkeFK_ACAccountPurchaseID.TabIndex = 3;
            this.fld_lkeFK_ACAccountPurchaseID.Tag = "DC";
            // 
            // bosLabel36
            // 
            this.bosLabel36.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel36.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel36.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel36.Appearance.Options.UseBackColor = true;
            this.bosLabel36.Appearance.Options.UseFont = true;
            this.bosLabel36.Appearance.Options.UseForeColor = true;
            this.bosLabel36.BOSComment = "";
            this.bosLabel36.BOSDataMember = "";
            this.bosLabel36.BOSDataSource = "";
            this.bosLabel36.BOSDescription = null;
            this.bosLabel36.BOSError = null;
            this.bosLabel36.BOSFieldGroup = "";
            this.bosLabel36.BOSFieldRelation = "";
            this.bosLabel36.BOSPrivilege = "";
            this.bosLabel36.BOSPropertyName = null;
            this.bosLabel36.Location = new System.Drawing.Point(10, 136);
            this.bosLabel36.Name = "bosLabel36";
            this.bosLabel36.Screen = null;
            this.bosLabel36.Size = new System.Drawing.Size(55, 13);
            this.bosLabel36.TabIndex = 7;
            this.bosLabel36.Tag = "";
            this.bosLabel36.Text = "TK CN mua";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = "";
            this.bosLookupEdit1.BOSDataMember = "FK_ACAccountID";
            this.bosLookupEdit1.BOSDataSource = "ARCustomers";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = "";
            this.bosLookupEdit1.BOSFieldGroup = "";
            this.bosLookupEdit1.BOSFieldParent = "";
            this.bosLookupEdit1.BOSFieldRelation = "";
            this.bosLookupEdit1.BOSPrivilege = "";
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = "";
            this.bosLookupEdit1.BOSSelectTypeValue = "";
            this.bosLookupEdit1.CurrentDisplayText = "";
            this.bosLookupEdit1.Location = new System.Drawing.Point(339, 133);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Mã TK"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên TK")});
            this.bosLookupEdit1.Properties.DisplayMember = "ACAccountNo";
            this.bosLookupEdit1.Properties.NullText = "";
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Properties.ValueMember = "ACAccountID";
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(124, 20);
            this.bosLookupEdit1.TabIndex = 7;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // bosLabel31
            // 
            this.bosLabel31.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel31.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel31.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel31.Appearance.Options.UseBackColor = true;
            this.bosLabel31.Appearance.Options.UseFont = true;
            this.bosLabel31.Appearance.Options.UseForeColor = true;
            this.bosLabel31.BOSComment = "";
            this.bosLabel31.BOSDataMember = "";
            this.bosLabel31.BOSDataSource = "";
            this.bosLabel31.BOSDescription = null;
            this.bosLabel31.BOSError = null;
            this.bosLabel31.BOSFieldGroup = "";
            this.bosLabel31.BOSFieldRelation = "";
            this.bosLabel31.BOSPrivilege = "";
            this.bosLabel31.BOSPropertyName = null;
            this.bosLabel31.Location = new System.Drawing.Point(258, 136);
            this.bosLabel31.Name = "bosLabel31";
            this.bosLabel31.Screen = null;
            this.bosLabel31.Size = new System.Drawing.Size(48, 13);
            this.bosLabel31.TabIndex = 5;
            this.bosLabel31.Tag = "";
            this.bosLabel31.Text = "Tài khoản";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel17.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseFont = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = "";
            this.fld_lblLabel17.BOSDataMember = "";
            this.fld_lblLabel17.BOSDataSource = "";
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = "";
            this.fld_lblLabel17.BOSFieldRelation = "";
            this.fld_lblLabel17.BOSPrivilege = "";
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(10, 11);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(27, 13);
            this.fld_lblLabel17.TabIndex = 0;
            this.fld_lblLabel17.Tag = "";
            this.fld_lblLabel17.Text = "Mô tả";
            // 
            // fld_medARCustomerDesc
            // 
            this.fld_medARCustomerDesc.BOSComment = "";
            this.fld_medARCustomerDesc.BOSDataMember = "ARCustomerDesc";
            this.fld_medARCustomerDesc.BOSDataSource = "ARCustomers";
            this.fld_medARCustomerDesc.BOSDescription = null;
            this.fld_medARCustomerDesc.BOSError = "";
            this.fld_medARCustomerDesc.BOSFieldGroup = "";
            this.fld_medARCustomerDesc.BOSFieldRelation = "";
            this.fld_medARCustomerDesc.BOSPrivilege = "";
            this.fld_medARCustomerDesc.BOSPropertyName = "Text";
            this.fld_medARCustomerDesc.Location = new System.Drawing.Point(97, 6);
            this.fld_medARCustomerDesc.Name = "fld_medARCustomerDesc";
            this.fld_medARCustomerDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARCustomerDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARCustomerDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARCustomerDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARCustomerDesc.Screen = null;
            this.fld_medARCustomerDesc.Size = new System.Drawing.Size(366, 43);
            this.fld_medARCustomerDesc.TabIndex = 0;
            this.fld_medARCustomerDesc.Tag = "DC";
            // 
            // fld_chkIsBuyingLocked
            // 
            this.fld_chkIsBuyingLocked.BOSComment = "";
            this.fld_chkIsBuyingLocked.BOSDataMember = "IsBuyingLocked";
            this.fld_chkIsBuyingLocked.BOSDataSource = "ARCustomers";
            this.fld_chkIsBuyingLocked.BOSDescription = null;
            this.fld_chkIsBuyingLocked.BOSError = "";
            this.fld_chkIsBuyingLocked.BOSFieldGroup = "";
            this.fld_chkIsBuyingLocked.BOSFieldRelation = "";
            this.fld_chkIsBuyingLocked.BOSPrivilege = "";
            this.fld_chkIsBuyingLocked.BOSPropertyName = "EditValue";
            this.fld_chkIsBuyingLocked.Location = new System.Drawing.Point(339, 185);
            this.fld_chkIsBuyingLocked.Name = "fld_chkIsBuyingLocked";
            this.fld_chkIsBuyingLocked.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkIsBuyingLocked.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkIsBuyingLocked.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkIsBuyingLocked.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkIsBuyingLocked.Properties.Caption = "Khóa bán hàng";
            this.fld_chkIsBuyingLocked.Screen = null;
            this.fld_chkIsBuyingLocked.Size = new System.Drawing.Size(112, 20);
            this.fld_chkIsBuyingLocked.TabIndex = 9;
            this.fld_chkIsBuyingLocked.Tag = "DC";
            // 
            // fld_chkARCustomerActiveCheck
            // 
            this.fld_chkARCustomerActiveCheck.BOSComment = "";
            this.fld_chkARCustomerActiveCheck.BOSDataMember = "ARCustomerActiveCheck";
            this.fld_chkARCustomerActiveCheck.BOSDataSource = "ARCustomers";
            this.fld_chkARCustomerActiveCheck.BOSDescription = null;
            this.fld_chkARCustomerActiveCheck.BOSError = "";
            this.fld_chkARCustomerActiveCheck.BOSFieldGroup = "";
            this.fld_chkARCustomerActiveCheck.BOSFieldRelation = "";
            this.fld_chkARCustomerActiveCheck.BOSPrivilege = "";
            this.fld_chkARCustomerActiveCheck.BOSPropertyName = "EditValue";
            this.fld_chkARCustomerActiveCheck.Location = new System.Drawing.Point(97, 185);
            this.fld_chkARCustomerActiveCheck.Name = "fld_chkARCustomerActiveCheck";
            this.fld_chkARCustomerActiveCheck.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkARCustomerActiveCheck.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkARCustomerActiveCheck.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkARCustomerActiveCheck.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkARCustomerActiveCheck.Properties.Caption = "Hoạt động";
            this.fld_chkARCustomerActiveCheck.Screen = null;
            this.fld_chkARCustomerActiveCheck.Size = new System.Drawing.Size(81, 20);
            this.fld_chkARCustomerActiveCheck.TabIndex = 8;
            this.fld_chkARCustomerActiveCheck.Tag = "DC";
            // 
            // fld_lkeARCustomerTypeCombo
            // 
            this.fld_lkeARCustomerTypeCombo.BOSAllowAddNew = false;
            this.fld_lkeARCustomerTypeCombo.BOSAllowDummy = false;
            this.fld_lkeARCustomerTypeCombo.BOSComment = "";
            this.fld_lkeARCustomerTypeCombo.BOSDataMember = "ARCustomerTypeCombo";
            this.fld_lkeARCustomerTypeCombo.BOSDataSource = "ARCustomers";
            this.fld_lkeARCustomerTypeCombo.BOSDescription = null;
            this.fld_lkeARCustomerTypeCombo.BOSError = "";
            this.fld_lkeARCustomerTypeCombo.BOSFieldGroup = "";
            this.fld_lkeARCustomerTypeCombo.BOSFieldParent = "";
            this.fld_lkeARCustomerTypeCombo.BOSFieldRelation = "";
            this.fld_lkeARCustomerTypeCombo.BOSPrivilege = "";
            this.fld_lkeARCustomerTypeCombo.BOSPropertyName = "EditValue";
            this.fld_lkeARCustomerTypeCombo.BOSSelectType = "";
            this.fld_lkeARCustomerTypeCombo.BOSSelectTypeValue = "";
            this.fld_lkeARCustomerTypeCombo.CurrentDisplayText = "";
            this.fld_lkeARCustomerTypeCombo.Location = new System.Drawing.Point(97, 55);
            this.fld_lkeARCustomerTypeCombo.Name = "fld_lkeARCustomerTypeCombo";
            this.fld_lkeARCustomerTypeCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARCustomerTypeCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARCustomerTypeCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARCustomerTypeCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARCustomerTypeCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCustomerTypeCombo.Properties.ColumnName = null;
            this.fld_lkeARCustomerTypeCombo.Properties.NullText = "";
            this.fld_lkeARCustomerTypeCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARCustomerTypeCombo.Screen = null;
            this.fld_lkeARCustomerTypeCombo.Size = new System.Drawing.Size(124, 20);
            this.fld_lkeARCustomerTypeCombo.TabIndex = 1;
            this.fld_lkeARCustomerTypeCombo.Tag = "DC";
            this.fld_lkeARCustomerTypeCombo.EditValueChanged += new System.EventHandler(this.fld_lkeARCustomerTypeCombo_EditValueChanged);
            // 
            // fld_lblLabel102
            // 
            this.fld_lblLabel102.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel102.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel102.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel102.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel102.Appearance.Options.UseFont = true;
            this.fld_lblLabel102.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel102.BOSComment = "";
            this.fld_lblLabel102.BOSDataMember = "";
            this.fld_lblLabel102.BOSDataSource = "";
            this.fld_lblLabel102.BOSDescription = null;
            this.fld_lblLabel102.BOSError = null;
            this.fld_lblLabel102.BOSFieldGroup = "";
            this.fld_lblLabel102.BOSFieldRelation = "";
            this.fld_lblLabel102.BOSPrivilege = "";
            this.fld_lblLabel102.BOSPropertyName = null;
            this.fld_lblLabel102.Location = new System.Drawing.Point(10, 57);
            this.fld_lblLabel102.Name = "fld_lblLabel102";
            this.fld_lblLabel102.Screen = null;
            this.fld_lblLabel102.Size = new System.Drawing.Size(80, 13);
            this.fld_lblLabel102.TabIndex = 2;
            this.fld_lblLabel102.Tag = "";
            this.fld_lblLabel102.Text = "Loại khách hàng";
            // 
            // bosPanel1
            // 
            this.bosPanel1.AutoSize = true;
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.bosLabel96);
            this.bosPanel1.Controls.Add(this.fld_dteARCustomerStartDate);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeManagementID);
            this.bosPanel1.Controls.Add(this.bosLabel49);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.collapsibleGroupBox1);
            this.bosPanel1.Controls.Add(this.fld_txtARCustomerCMND);
            this.bosPanel1.Controls.Add(this.bosLabel32);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.bosLabel29);
            this.bosPanel1.Controls.Add(this.fld_txtARCustomerNo1);
            this.bosPanel1.Controls.Add(this.fld_txtARCustomerName2);
            this.bosPanel1.Controls.Add(this.fld_lblLabel25);
            this.bosPanel1.Controls.Add(this.fld_lblLabel16);
            this.bosPanel1.Controls.Add(this.fld_lblLabel19);
            this.bosPanel1.Controls.Add(this.fld_txtARCustomerTaxNumber);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel1.Location = new System.Drawing.Point(2, 23);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(478, 133);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosLabel96
            // 
            this.bosLabel96.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel96.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel96.Appearance.Options.UseBackColor = true;
            this.bosLabel96.Appearance.Options.UseForeColor = true;
            this.bosLabel96.BOSComment = null;
            this.bosLabel96.BOSDataMember = null;
            this.bosLabel96.BOSDataSource = null;
            this.bosLabel96.BOSDescription = null;
            this.bosLabel96.BOSError = null;
            this.bosLabel96.BOSFieldGroup = null;
            this.bosLabel96.BOSFieldRelation = null;
            this.bosLabel96.BOSPrivilege = null;
            this.bosLabel96.BOSPropertyName = null;
            this.bosLabel96.Location = new System.Drawing.Point(254, 85);
            this.bosLabel96.Name = "bosLabel96";
            this.bosLabel96.Screen = null;
            this.bosLabel96.Size = new System.Drawing.Size(76, 13);
            this.bosLabel96.TabIndex = 761;
            this.bosLabel96.Text = "Bắt đầu hợp tác";
            // 
            // fld_dteARCustomerStartDate
            // 
            this.fld_dteARCustomerStartDate.BOSComment = null;
            this.fld_dteARCustomerStartDate.BOSDataMember = "ARCustomerStartDate";
            this.fld_dteARCustomerStartDate.BOSDataSource = "ARCustomers";
            this.fld_dteARCustomerStartDate.BOSDescription = null;
            this.fld_dteARCustomerStartDate.BOSError = null;
            this.fld_dteARCustomerStartDate.BOSFieldGroup = null;
            this.fld_dteARCustomerStartDate.BOSFieldRelation = null;
            this.fld_dteARCustomerStartDate.BOSPrivilege = null;
            this.fld_dteARCustomerStartDate.BOSPropertyName = "EditValue";
            this.fld_dteARCustomerStartDate.EditValue = null;
            this.fld_dteARCustomerStartDate.Location = new System.Drawing.Point(339, 82);
            this.fld_dteARCustomerStartDate.Name = "fld_dteARCustomerStartDate";
            this.fld_dteARCustomerStartDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARCustomerStartDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARCustomerStartDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARCustomerStartDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARCustomerStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARCustomerStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARCustomerStartDate.Screen = null;
            this.fld_dteARCustomerStartDate.Size = new System.Drawing.Size(124, 20);
            this.fld_dteARCustomerStartDate.TabIndex = 762;
            this.fld_dteARCustomerStartDate.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeManagementID
            // 
            this.fld_lkeFK_HREmployeeManagementID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeManagementID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeManagementID.BOSComment = "";
            this.fld_lkeFK_HREmployeeManagementID.BOSDataMember = "FK_HREmployeeManagementID";
            this.fld_lkeFK_HREmployeeManagementID.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_HREmployeeManagementID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeManagementID.BOSError = "";
            this.fld_lkeFK_HREmployeeManagementID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeManagementID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeManagementID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeManagementID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeManagementID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeManagementID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeManagementID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeManagementID.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeManagementID.Location = new System.Drawing.Point(339, 30);
            this.fld_lkeFK_HREmployeeManagementID.Name = "fld_lkeFK_HREmployeeManagementID";
            this.fld_lkeFK_HREmployeeManagementID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeManagementID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeManagementID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeManagementID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeManagementID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeManagementID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeManagementID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeManagementID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeManagementID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeManagementID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeManagementID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeManagementID.Screen = null;
            this.fld_lkeFK_HREmployeeManagementID.Size = new System.Drawing.Size(124, 20);
            this.fld_lkeFK_HREmployeeManagementID.TabIndex = 14;
            this.fld_lkeFK_HREmployeeManagementID.Tag = "DC";
            // 
            // bosLabel49
            // 
            this.bosLabel49.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel49.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel49.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel49.Appearance.Options.UseBackColor = true;
            this.bosLabel49.Appearance.Options.UseFont = true;
            this.bosLabel49.Appearance.Options.UseForeColor = true;
            this.bosLabel49.BOSComment = "";
            this.bosLabel49.BOSDataMember = "";
            this.bosLabel49.BOSDataSource = "";
            this.bosLabel49.BOSDescription = null;
            this.bosLabel49.BOSError = null;
            this.bosLabel49.BOSFieldGroup = "";
            this.bosLabel49.BOSFieldRelation = "";
            this.bosLabel49.BOSPrivilege = "";
            this.bosLabel49.BOSPropertyName = null;
            this.bosLabel49.Location = new System.Drawing.Point(254, 33);
            this.bosLabel49.Name = "bosLabel49";
            this.bosLabel49.Screen = null;
            this.bosLabel49.Size = new System.Drawing.Size(36, 13);
            this.bosLabel49.TabIndex = 13;
            this.bosLabel49.Tag = "";
            this.bosLabel49.Text = "Quản lý";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseFont = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.bosLabel10.BOSComment = "";
            this.bosLabel10.BOSDataMember = "";
            this.bosLabel10.BOSDataSource = "";
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = "";
            this.bosLabel10.BOSFieldRelation = "";
            this.bosLabel10.BOSPrivilege = "";
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(334, 114);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(48, 13);
            this.bosLabel10.TabIndex = 12;
            this.bosLabel10.Tag = "";
            // 
            // collapsibleGroupBox1
            // 
            this.collapsibleGroupBox1.AutoSize = true;
            this.collapsibleGroupBox1.Location = new System.Drawing.Point(3, 110);
            this.collapsibleGroupBox1.Name = "collapsibleGroupBox1";
            this.collapsibleGroupBox1.Size = new System.Drawing.Size(200, 20);
            this.collapsibleGroupBox1.TabIndex = 0;
            this.collapsibleGroupBox1.TabStop = false;
            // 
            // fld_txtARCustomerCMND
            // 
            this.fld_txtARCustomerCMND.BOSComment = "";
            this.fld_txtARCustomerCMND.BOSDataMember = "ARCustomerCMND";
            this.fld_txtARCustomerCMND.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerCMND.BOSDescription = null;
            this.fld_txtARCustomerCMND.BOSError = "";
            this.fld_txtARCustomerCMND.BOSFieldGroup = "";
            this.fld_txtARCustomerCMND.BOSFieldRelation = "";
            this.fld_txtARCustomerCMND.BOSPrivilege = "";
            this.fld_txtARCustomerCMND.BOSPropertyName = "Text";
            this.fld_txtARCustomerCMND.Location = new System.Drawing.Point(97, 82);
            this.fld_txtARCustomerCMND.Name = "fld_txtARCustomerCMND";
            this.fld_txtARCustomerCMND.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerCMND.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerCMND.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerCMND.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerCMND.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerCMND.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerCMND.Screen = null;
            this.fld_txtARCustomerCMND.Size = new System.Drawing.Size(124, 20);
            this.fld_txtARCustomerCMND.TabIndex = 4;
            this.fld_txtARCustomerCMND.Tag = "DC";
            // 
            // bosLabel32
            // 
            this.bosLabel32.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel32.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel32.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel32.Appearance.Options.UseBackColor = true;
            this.bosLabel32.Appearance.Options.UseFont = true;
            this.bosLabel32.Appearance.Options.UseForeColor = true;
            this.bosLabel32.BOSComment = "";
            this.bosLabel32.BOSDataMember = "";
            this.bosLabel32.BOSDataSource = "";
            this.bosLabel32.BOSDescription = null;
            this.bosLabel32.BOSError = null;
            this.bosLabel32.BOSFieldGroup = "";
            this.bosLabel32.BOSFieldRelation = "";
            this.bosLabel32.BOSPrivilege = "";
            this.bosLabel32.BOSPropertyName = null;
            this.bosLabel32.Location = new System.Drawing.Point(9, 85);
            this.bosLabel32.Name = "bosLabel32";
            this.bosLabel32.Screen = null;
            this.bosLabel32.Size = new System.Drawing.Size(48, 13);
            this.bosLabel32.TabIndex = 11;
            this.bosLabel32.Tag = "";
            this.bosLabel32.Text = "Số CMND";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "ARCustomerNoOfOldSys";
            this.bosTextBox1.BOSDataSource = "ARCustomers";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = "";
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.Location = new System.Drawing.Point(97, 30);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox1, true);
            this.bosTextBox1.Size = new System.Drawing.Size(124, 20);
            this.bosTextBox1.TabIndex = 2;
            this.bosTextBox1.Tag = "DC";
            // 
            // bosLabel29
            // 
            this.bosLabel29.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel29.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel29.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel29.Appearance.Options.UseBackColor = true;
            this.bosLabel29.Appearance.Options.UseFont = true;
            this.bosLabel29.Appearance.Options.UseForeColor = true;
            this.bosLabel29.BOSComment = "";
            this.bosLabel29.BOSDataMember = "";
            this.bosLabel29.BOSDataSource = "";
            this.bosLabel29.BOSDescription = null;
            this.bosLabel29.BOSError = null;
            this.bosLabel29.BOSFieldGroup = "";
            this.bosLabel29.BOSFieldRelation = "";
            this.bosLabel29.BOSPrivilege = "";
            this.bosLabel29.BOSPropertyName = null;
            this.bosLabel29.Location = new System.Drawing.Point(9, 33);
            this.bosLabel29.Name = "bosLabel29";
            this.bosLabel29.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel29, true);
            this.bosLabel29.Size = new System.Drawing.Size(48, 13);
            this.bosLabel29.TabIndex = 10;
            this.bosLabel29.Tag = "";
            this.bosLabel29.Text = "Mã HT cũ";
            // 
            // fld_txtARCustomerNo1
            // 
            this.fld_txtARCustomerNo1.BOSComment = "";
            this.fld_txtARCustomerNo1.BOSDataMember = "ARCustomerNo";
            this.fld_txtARCustomerNo1.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerNo1.BOSDescription = null;
            this.fld_txtARCustomerNo1.BOSError = "";
            this.fld_txtARCustomerNo1.BOSFieldGroup = "";
            this.fld_txtARCustomerNo1.BOSFieldRelation = "";
            this.fld_txtARCustomerNo1.BOSPrivilege = "";
            this.fld_txtARCustomerNo1.BOSPropertyName = "Text";
            this.fld_txtARCustomerNo1.Location = new System.Drawing.Point(97, 4);
            this.fld_txtARCustomerNo1.Name = "fld_txtARCustomerNo1";
            this.fld_txtARCustomerNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerNo1.Screen = null;
            this.fld_txtARCustomerNo1.Size = new System.Drawing.Size(124, 20);
            this.fld_txtARCustomerNo1.TabIndex = 0;
            this.fld_txtARCustomerNo1.Tag = "DC";
            // 
            // fld_lblLabel19
            // 
            this.fld_lblLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel19.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel19.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel19.BOSComment = "";
            this.fld_lblLabel19.BOSDataMember = "";
            this.fld_lblLabel19.BOSDataSource = "";
            this.fld_lblLabel19.BOSDescription = null;
            this.fld_lblLabel19.BOSError = null;
            this.fld_lblLabel19.BOSFieldGroup = "";
            this.fld_lblLabel19.BOSFieldRelation = "";
            this.fld_lblLabel19.BOSPrivilege = "";
            this.fld_lblLabel19.BOSPropertyName = null;
            this.fld_lblLabel19.Location = new System.Drawing.Point(254, 7);
            this.fld_lblLabel19.Name = "fld_lblLabel19";
            this.fld_lblLabel19.Screen = null;
            this.fld_lblLabel19.Size = new System.Drawing.Size(53, 13);
            this.fld_lblLabel19.TabIndex = 8;
            this.fld_lblLabel19.Tag = "";
            this.fld_lblLabel19.Text = "Mã số thuế";
            // 
            // fld_txtARCustomerTaxNumber
            // 
            this.fld_txtARCustomerTaxNumber.BOSComment = "";
            this.fld_txtARCustomerTaxNumber.BOSDataMember = "ARCustomerTaxNumber";
            this.fld_txtARCustomerTaxNumber.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerTaxNumber.BOSDescription = null;
            this.fld_txtARCustomerTaxNumber.BOSError = "";
            this.fld_txtARCustomerTaxNumber.BOSFieldGroup = "";
            this.fld_txtARCustomerTaxNumber.BOSFieldRelation = "";
            this.fld_txtARCustomerTaxNumber.BOSPrivilege = "";
            this.fld_txtARCustomerTaxNumber.BOSPropertyName = "Text";
            this.fld_txtARCustomerTaxNumber.Location = new System.Drawing.Point(339, 4);
            this.fld_txtARCustomerTaxNumber.Name = "fld_txtARCustomerTaxNumber";
            this.fld_txtARCustomerTaxNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerTaxNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerTaxNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerTaxNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerTaxNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerTaxNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerTaxNumber.Screen = null;
            this.fld_txtARCustomerTaxNumber.Size = new System.Drawing.Size(124, 20);
            this.fld_txtARCustomerTaxNumber.TabIndex = 1;
            this.fld_txtARCustomerTaxNumber.Tag = "DC";
            // 
            // bosLabel21
            // 
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.Options.UseBackColor = true;
            this.bosLabel21.Appearance.Options.UseForeColor = true;
            this.bosLabel21.BOSComment = "";
            this.bosLabel21.BOSDataMember = "";
            this.bosLabel21.BOSDataSource = "";
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = "";
            this.bosLabel21.BOSFieldRelation = "";
            this.bosLabel21.BOSPrivilege = "";
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(17, 127);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel21, true);
            this.bosLabel21.Size = new System.Drawing.Size(21, 13);
            this.bosLabel21.TabIndex = 38;
            this.bosLabel21.Tag = "";
            this.bosLabel21.Text = "Vị trí";
            // 
            // fld_txtARCustomerName3
            // 
            this.fld_txtARCustomerName3.BOSComment = "";
            this.fld_txtARCustomerName3.BOSDataMember = "ARCustomerName3";
            this.fld_txtARCustomerName3.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerName3.BOSDescription = null;
            this.fld_txtARCustomerName3.BOSError = "Tên khách hàng không thể rỗng";
            this.fld_txtARCustomerName3.BOSFieldGroup = "";
            this.fld_txtARCustomerName3.BOSFieldRelation = "";
            this.fld_txtARCustomerName3.BOSPrivilege = "";
            this.fld_txtARCustomerName3.BOSPropertyName = "Text";
            this.fld_txtARCustomerName3.Location = new System.Drawing.Point(100, 66);
            this.fld_txtARCustomerName3.Name = "fld_txtARCustomerName3";
            this.fld_txtARCustomerName3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerName3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerName3.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerName3.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerName3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerName3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerName3.Screen = null;
            this.fld_txtARCustomerName3.Size = new System.Drawing.Size(369, 20);
            this.fld_txtARCustomerName3.TabIndex = 5;
            this.fld_txtARCustomerName3.Tag = "DC";
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel14.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseFont = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.BOSComment = "";
            this.bosLabel14.BOSDataMember = "";
            this.bosLabel14.BOSDataSource = "";
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = "";
            this.bosLabel14.BOSFieldRelation = "";
            this.bosLabel14.BOSPrivilege = "";
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(6, 70);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(55, 13);
            this.bosLabel14.TabIndex = 4;
            this.bosLabel14.Tag = "";
            this.bosLabel14.Text = "Tên khác 3";
            // 
            // fld_txtARCustomerName21
            // 
            this.fld_txtARCustomerName21.BOSComment = "";
            this.fld_txtARCustomerName21.BOSDataMember = "ARCustomerName2";
            this.fld_txtARCustomerName21.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerName21.BOSDescription = null;
            this.fld_txtARCustomerName21.BOSError = "Tên khách hàng không thể rỗng";
            this.fld_txtARCustomerName21.BOSFieldGroup = "";
            this.fld_txtARCustomerName21.BOSFieldRelation = "";
            this.fld_txtARCustomerName21.BOSPrivilege = "";
            this.fld_txtARCustomerName21.BOSPropertyName = "Text";
            this.fld_txtARCustomerName21.Location = new System.Drawing.Point(100, 42);
            this.fld_txtARCustomerName21.Name = "fld_txtARCustomerName21";
            this.fld_txtARCustomerName21.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerName21.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerName21.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerName21.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerName21.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerName21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerName21.Screen = null;
            this.fld_txtARCustomerName21.Size = new System.Drawing.Size(369, 20);
            this.fld_txtARCustomerName21.TabIndex = 3;
            this.fld_txtARCustomerName21.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel13.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseFont = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = "";
            this.bosLabel13.BOSDataMember = "";
            this.bosLabel13.BOSDataSource = "";
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = "";
            this.bosLabel13.BOSFieldRelation = "";
            this.bosLabel13.BOSPrivilege = "";
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(6, 46);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(55, 13);
            this.bosLabel13.TabIndex = 2;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "Tên khác 2";
            // 
            // fld_txtARCustomerName1
            // 
            this.fld_txtARCustomerName1.BOSComment = "";
            this.fld_txtARCustomerName1.BOSDataMember = "ARCustomerName1";
            this.fld_txtARCustomerName1.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerName1.BOSDescription = null;
            this.fld_txtARCustomerName1.BOSError = "Tên khách hàng không thể rỗng";
            this.fld_txtARCustomerName1.BOSFieldGroup = "";
            this.fld_txtARCustomerName1.BOSFieldRelation = "";
            this.fld_txtARCustomerName1.BOSPrivilege = "";
            this.fld_txtARCustomerName1.BOSPropertyName = "Text";
            this.fld_txtARCustomerName1.Location = new System.Drawing.Point(100, 18);
            this.fld_txtARCustomerName1.Name = "fld_txtARCustomerName1";
            this.fld_txtARCustomerName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerName1.Screen = null;
            this.fld_txtARCustomerName1.Size = new System.Drawing.Size(369, 20);
            this.fld_txtARCustomerName1.TabIndex = 1;
            this.fld_txtARCustomerName1.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseFont = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = "";
            this.bosLabel12.BOSDataMember = "";
            this.bosLabel12.BOSDataSource = "";
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = "";
            this.bosLabel12.BOSFieldRelation = "";
            this.bosLabel12.BOSPrivilege = "";
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(7, 22);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(55, 13);
            this.bosLabel12.TabIndex = 0;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "Tên khác 1";
            // 
            // fld_grcGroupControl6
            // 
            this.fld_grcGroupControl6.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl6.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl6.BOSComment = "";
            this.fld_grcGroupControl6.BOSDataMember = null;
            this.fld_grcGroupControl6.BOSDataSource = null;
            this.fld_grcGroupControl6.BOSDescription = null;
            this.fld_grcGroupControl6.BOSError = null;
            this.fld_grcGroupControl6.BOSFieldGroup = "";
            this.fld_grcGroupControl6.BOSFieldRelation = null;
            this.fld_grcGroupControl6.BOSPrivilege = "";
            this.fld_grcGroupControl6.BOSPropertyName = null;
            this.fld_grcGroupControl6.Controls.Add(this.fld_lkeARCustomerStatus);
            this.fld_grcGroupControl6.Controls.Add(this.bosLabel35);
            this.fld_grcGroupControl6.Controls.Add(this.fld_lkeFK_GEPaymentTermID);
            this.fld_grcGroupControl6.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl6.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.fld_grcGroupControl6.Controls.Add(this.fld_txtARCustomerAvailableCredit);
            this.fld_grcGroupControl6.Controls.Add(this.fld_txtARCustomerOwing);
            this.fld_grcGroupControl6.Controls.Add(this.fld_Line1);
            this.fld_grcGroupControl6.Controls.Add(this.fld_lblLabel32);
            this.fld_grcGroupControl6.Controls.Add(this.fld_lblLabel30);
            this.fld_grcGroupControl6.Controls.Add(this.fld_lblLabel11);
            this.fld_grcGroupControl6.Controls.Add(this.fld_lblLabel12);
            this.fld_grcGroupControl6.Controls.Add(this.fld_lblLabel13);
            this.fld_grcGroupControl6.Controls.Add(this.fld_lblLabel14);
            this.fld_grcGroupControl6.Controls.Add(this.fld_lblLabel15);
            this.fld_grcGroupControl6.Controls.Add(this.fld_lkeFK_ARPriceLevelID);
            this.fld_grcGroupControl6.Controls.Add(this.fld_txtARCustomerCreditLimit);
            this.fld_grcGroupControl6.Controls.Add(this.fld_txtARCustomerDiscount);
            this.fld_grcGroupControl6.Controls.Add(this.fld_lkeARPaymentMethodCombo);
            this.fld_grcGroupControl6.Location = new System.Drawing.Point(497, 12);
            this.fld_grcGroupControl6.Name = "fld_grcGroupControl6";
            this.fld_grcGroupControl6.Screen = null;
            this.fld_grcGroupControl6.Size = new System.Drawing.Size(480, 173);
            this.fld_grcGroupControl6.TabIndex = 2;
            this.fld_grcGroupControl6.Text = "Thông tin giao dịch";
            // 
            // fld_lkeARCustomerStatus
            // 
            this.fld_lkeARCustomerStatus.BOSAllowAddNew = false;
            this.fld_lkeARCustomerStatus.BOSAllowDummy = true;
            this.fld_lkeARCustomerStatus.BOSComment = "";
            this.fld_lkeARCustomerStatus.BOSDataMember = "ARCustomerStatus";
            this.fld_lkeARCustomerStatus.BOSDataSource = "ARCustomers";
            this.fld_lkeARCustomerStatus.BOSDescription = null;
            this.fld_lkeARCustomerStatus.BOSError = "";
            this.fld_lkeARCustomerStatus.BOSFieldGroup = "";
            this.fld_lkeARCustomerStatus.BOSFieldParent = "";
            this.fld_lkeARCustomerStatus.BOSFieldRelation = "";
            this.fld_lkeARCustomerStatus.BOSPrivilege = "";
            this.fld_lkeARCustomerStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARCustomerStatus.BOSSelectType = "";
            this.fld_lkeARCustomerStatus.BOSSelectTypeValue = "";
            this.fld_lkeARCustomerStatus.CurrentDisplayText = "";
            this.fld_lkeARCustomerStatus.Location = new System.Drawing.Point(354, 139);
            this.fld_lkeARCustomerStatus.Name = "fld_lkeARCustomerStatus";
            this.fld_lkeARCustomerStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARCustomerStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARCustomerStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARCustomerStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARCustomerStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCustomerStatus.Properties.ColumnName = null;
            this.fld_lkeARCustomerStatus.Properties.NullText = "";
            this.fld_lkeARCustomerStatus.Properties.ReadOnly = true;
            this.fld_lkeARCustomerStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARCustomerStatus.Screen = null;
            this.fld_lkeARCustomerStatus.Size = new System.Drawing.Size(117, 20);
            this.fld_lkeARCustomerStatus.TabIndex = 5;
            this.fld_lkeARCustomerStatus.Tag = "DC";
            this.fld_lkeARCustomerStatus.Visible = false;
            // 
            // bosLabel35
            // 
            this.bosLabel35.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel35.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel35.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel35.Appearance.Options.UseBackColor = true;
            this.bosLabel35.Appearance.Options.UseFont = true;
            this.bosLabel35.Appearance.Options.UseForeColor = true;
            this.bosLabel35.BOSComment = "";
            this.bosLabel35.BOSDataMember = "";
            this.bosLabel35.BOSDataSource = "";
            this.bosLabel35.BOSDescription = null;
            this.bosLabel35.BOSError = null;
            this.bosLabel35.BOSFieldGroup = "";
            this.bosLabel35.BOSFieldRelation = "";
            this.bosLabel35.BOSPrivilege = "";
            this.bosLabel35.BOSPropertyName = null;
            this.bosLabel35.Location = new System.Drawing.Point(275, 139);
            this.bosLabel35.Name = "bosLabel35";
            this.bosLabel35.Screen = null;
            this.bosLabel35.Size = new System.Drawing.Size(48, 13);
            this.bosLabel35.TabIndex = 23;
            this.bosLabel35.Tag = "";
            this.bosLabel35.Text = "Tình trạng";
            this.bosLabel35.Visible = false;
            // 
            // fld_lkeFK_GEPaymentTermID
            // 
            this.fld_lkeFK_GEPaymentTermID.BOSAllowAddNew = false;
            this.fld_lkeFK_GEPaymentTermID.BOSAllowDummy = true;
            this.fld_lkeFK_GEPaymentTermID.BOSComment = null;
            this.fld_lkeFK_GEPaymentTermID.BOSDataMember = "FK_GEPaymentTermID";
            this.fld_lkeFK_GEPaymentTermID.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_GEPaymentTermID.BOSDescription = null;
            this.fld_lkeFK_GEPaymentTermID.BOSError = null;
            this.fld_lkeFK_GEPaymentTermID.BOSFieldGroup = null;
            this.fld_lkeFK_GEPaymentTermID.BOSFieldParent = null;
            this.fld_lkeFK_GEPaymentTermID.BOSFieldRelation = null;
            this.fld_lkeFK_GEPaymentTermID.BOSPrivilege = null;
            this.fld_lkeFK_GEPaymentTermID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEPaymentTermID.BOSSelectType = null;
            this.fld_lkeFK_GEPaymentTermID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GEPaymentTermID.CurrentDisplayText = null;
            this.fld_lkeFK_GEPaymentTermID.Location = new System.Drawing.Point(139, 52);
            this.fld_lkeFK_GEPaymentTermID.Name = "fld_lkeFK_GEPaymentTermID";
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEPaymentTermID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEPaymentTermID.Properties.ColumnName = null;
            this.fld_lkeFK_GEPaymentTermID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEPaymentTermName", "Điều khoản thanh toán")});
            this.fld_lkeFK_GEPaymentTermID.Properties.DisplayMember = "GEPaymentTermName";
            this.fld_lkeFK_GEPaymentTermID.Properties.NullText = "";
            this.fld_lkeFK_GEPaymentTermID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEPaymentTermID.Properties.ValueMember = "GEPaymentTermID";
            this.fld_lkeFK_GEPaymentTermID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GEPaymentTermID, true);
            this.fld_lkeFK_GEPaymentTermID.Size = new System.Drawing.Size(332, 20);
            this.fld_lkeFK_GEPaymentTermID.TabIndex = 2;
            this.fld_lkeFK_GEPaymentTermID.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(275, 81);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(53, 13);
            this.bosLabel1.TabIndex = 10;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Loại tiền tệ";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = "";
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = "";
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = "";
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = "";
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = "";
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = "";
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = "";
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = "";
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = "";
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(354, 78);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyNo", "Mã tiền tệ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Tên tiền tệ")});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(117, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 4;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            // 
            // fld_txtARCustomerAvailableCredit
            // 
            this.fld_txtARCustomerAvailableCredit.BOSComment = null;
            this.fld_txtARCustomerAvailableCredit.BOSDataMember = "ARCustomerAvailableCredit";
            this.fld_txtARCustomerAvailableCredit.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerAvailableCredit.BOSDescription = "";
            this.fld_txtARCustomerAvailableCredit.BOSError = null;
            this.fld_txtARCustomerAvailableCredit.BOSFieldGroup = null;
            this.fld_txtARCustomerAvailableCredit.BOSFieldRelation = null;
            this.fld_txtARCustomerAvailableCredit.BOSPrivilege = null;
            this.fld_txtARCustomerAvailableCredit.BOSPropertyName = "Text";
            this.fld_txtARCustomerAvailableCredit.Location = new System.Drawing.Point(139, 139);
            this.fld_txtARCustomerAvailableCredit.Name = "fld_txtARCustomerAvailableCredit";
            this.fld_txtARCustomerAvailableCredit.Properties.Mask.EditMask = "n";
            this.fld_txtARCustomerAvailableCredit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARCustomerAvailableCredit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerAvailableCredit.Properties.ReadOnly = true;
            this.fld_txtARCustomerAvailableCredit.Screen = null;
            this.fld_txtARCustomerAvailableCredit.Size = new System.Drawing.Size(124, 20);
            this.fld_txtARCustomerAvailableCredit.TabIndex = 8;
            this.fld_txtARCustomerAvailableCredit.TabStop = false;
            this.fld_txtARCustomerAvailableCredit.Tag = "DC";
            // 
            // fld_txtARCustomerOwing
            // 
            this.fld_txtARCustomerOwing.BOSComment = null;
            this.fld_txtARCustomerOwing.BOSDataMember = "ARCustomerOwing";
            this.fld_txtARCustomerOwing.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerOwing.BOSDescription = null;
            this.fld_txtARCustomerOwing.BOSError = null;
            this.fld_txtARCustomerOwing.BOSFieldGroup = null;
            this.fld_txtARCustomerOwing.BOSFieldRelation = null;
            this.fld_txtARCustomerOwing.BOSPrivilege = null;
            this.fld_txtARCustomerOwing.BOSPropertyName = "Text";
            this.fld_txtARCustomerOwing.Location = new System.Drawing.Point(354, 113);
            this.fld_txtARCustomerOwing.MenuManager = this.screenToolbar;
            this.fld_txtARCustomerOwing.Name = "fld_txtARCustomerOwing";
            this.fld_txtARCustomerOwing.Properties.Mask.EditMask = "n";
            this.fld_txtARCustomerOwing.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARCustomerOwing.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerOwing.Properties.ReadOnly = true;
            this.fld_txtARCustomerOwing.Screen = null;
            this.fld_txtARCustomerOwing.Size = new System.Drawing.Size(117, 20);
            this.fld_txtARCustomerOwing.TabIndex = 7;
            this.fld_txtARCustomerOwing.TabStop = false;
            this.fld_txtARCustomerOwing.Tag = "DC";
            // 
            // fld_Line1
            // 
            this.fld_Line1.BOSComment = null;
            this.fld_Line1.BOSDataMember = null;
            this.fld_Line1.BOSDataSource = null;
            this.fld_Line1.BOSDescription = null;
            this.fld_Line1.BOSError = null;
            this.fld_Line1.BOSFieldGroup = null;
            this.fld_Line1.BOSFieldRelation = null;
            this.fld_Line1.BOSPrivilege = null;
            this.fld_Line1.BOSPropertyName = null;
            this.fld_Line1.Location = new System.Drawing.Point(5, 101);
            this.fld_Line1.Name = "fld_Line1";
            this.fld_Line1.Screen = null;
            this.fld_Line1.Size = new System.Drawing.Size(470, 5);
            this.fld_Line1.TabIndex = 15;
            this.fld_Line1.TabStop = false;
            // 
            // fld_lblLabel32
            // 
            this.fld_lblLabel32.BOSComment = null;
            this.fld_lblLabel32.BOSDataMember = null;
            this.fld_lblLabel32.BOSDataSource = null;
            this.fld_lblLabel32.BOSDescription = null;
            this.fld_lblLabel32.BOSError = null;
            this.fld_lblLabel32.BOSFieldGroup = null;
            this.fld_lblLabel32.BOSFieldRelation = null;
            this.fld_lblLabel32.BOSPrivilege = null;
            this.fld_lblLabel32.BOSPropertyName = null;
            this.fld_lblLabel32.Location = new System.Drawing.Point(17, 142);
            this.fld_lblLabel32.Name = "fld_lblLabel32";
            this.fld_lblLabel32.Screen = null;
            this.fld_lblLabel32.Size = new System.Drawing.Size(74, 13);
            this.fld_lblLabel32.TabIndex = 20;
            this.fld_lblLabel32.Text = "Tín dụng còn lại";
            // 
            // fld_lblLabel30
            // 
            this.fld_lblLabel30.BOSComment = null;
            this.fld_lblLabel30.BOSDataMember = null;
            this.fld_lblLabel30.BOSDataSource = null;
            this.fld_lblLabel30.BOSDescription = null;
            this.fld_lblLabel30.BOSError = null;
            this.fld_lblLabel30.BOSFieldGroup = null;
            this.fld_lblLabel30.BOSFieldRelation = null;
            this.fld_lblLabel30.BOSPrivilege = null;
            this.fld_lblLabel30.BOSPropertyName = null;
            this.fld_lblLabel30.Location = new System.Drawing.Point(275, 116);
            this.fld_lblLabel30.Name = "fld_lblLabel30";
            this.fld_lblLabel30.Screen = null;
            this.fld_lblLabel30.Size = new System.Drawing.Size(13, 13);
            this.fld_lblLabel30.TabIndex = 18;
            this.fld_lblLabel30.Text = "Nợ";
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = "";
            this.fld_lblLabel11.BOSDataMember = "";
            this.fld_lblLabel11.BOSDataSource = "";
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = "";
            this.fld_lblLabel11.BOSFieldRelation = "";
            this.fld_lblLabel11.BOSPrivilege = "";
            this.fld_lblLabel11.BOSPropertyName = null;
            this.fld_lblLabel11.Location = new System.Drawing.Point(17, 29);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(37, 13);
            this.fld_lblLabel11.TabIndex = 0;
            this.fld_lblLabel11.Tag = "";
            this.fld_lblLabel11.Text = "Mức giá";
            // 
            // fld_lblLabel12
            // 
            this.fld_lblLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel12.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel12.BOSComment = "";
            this.fld_lblLabel12.BOSDataMember = "";
            this.fld_lblLabel12.BOSDataSource = "";
            this.fld_lblLabel12.BOSDescription = null;
            this.fld_lblLabel12.BOSError = null;
            this.fld_lblLabel12.BOSFieldGroup = "";
            this.fld_lblLabel12.BOSFieldRelation = "";
            this.fld_lblLabel12.BOSPrivilege = "";
            this.fld_lblLabel12.BOSPropertyName = null;
            this.fld_lblLabel12.Location = new System.Drawing.Point(275, 29);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(73, 13);
            this.fld_lblLabel12.TabIndex = 2;
            this.fld_lblLabel12.Tag = "";
            this.fld_lblLabel12.Text = "Chiết khấu (%)";
            // 
            // fld_lblLabel13
            // 
            this.fld_lblLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel13.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel13.BOSComment = "";
            this.fld_lblLabel13.BOSDataMember = "";
            this.fld_lblLabel13.BOSDataSource = "";
            this.fld_lblLabel13.BOSDescription = null;
            this.fld_lblLabel13.BOSError = null;
            this.fld_lblLabel13.BOSFieldGroup = "";
            this.fld_lblLabel13.BOSFieldRelation = "";
            this.fld_lblLabel13.BOSPrivilege = "";
            this.fld_lblLabel13.BOSPropertyName = null;
            this.fld_lblLabel13.Location = new System.Drawing.Point(17, 116);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(84, 13);
            this.fld_lblLabel13.TabIndex = 16;
            this.fld_lblLabel13.Tag = "";
            this.fld_lblLabel13.Text = "Hạn mức tín dụng";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = "";
            this.fld_lblLabel14.BOSDataMember = "";
            this.fld_lblLabel14.BOSDataSource = "";
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = "";
            this.fld_lblLabel14.BOSFieldRelation = "";
            this.fld_lblLabel14.BOSPrivilege = "";
            this.fld_lblLabel14.BOSPropertyName = null;
            this.fld_lblLabel14.Location = new System.Drawing.Point(17, 54);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(110, 13);
            this.fld_lblLabel14.TabIndex = 4;
            this.fld_lblLabel14.Tag = "";
            this.fld_lblLabel14.Text = "Điều khoản thanh toán";
            // 
            // fld_lblLabel15
            // 
            this.fld_lblLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel15.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel15.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel15.BOSComment = "";
            this.fld_lblLabel15.BOSDataMember = "";
            this.fld_lblLabel15.BOSDataSource = "";
            this.fld_lblLabel15.BOSDescription = null;
            this.fld_lblLabel15.BOSError = null;
            this.fld_lblLabel15.BOSFieldGroup = "";
            this.fld_lblLabel15.BOSFieldRelation = "";
            this.fld_lblLabel15.BOSPrivilege = "";
            this.fld_lblLabel15.BOSPropertyName = null;
            this.fld_lblLabel15.Location = new System.Drawing.Point(17, 79);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.fld_lblLabel15.Size = new System.Drawing.Size(118, 13);
            this.fld_lblLabel15.TabIndex = 6;
            this.fld_lblLabel15.Tag = "";
            this.fld_lblLabel15.Text = "Phương thức thanh toán";
            // 
            // fld_lkeFK_ARPriceLevelID
            // 
            this.fld_lkeFK_ARPriceLevelID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARPriceLevelID.BOSAllowDummy = true;
            this.fld_lkeFK_ARPriceLevelID.BOSComment = "";
            this.fld_lkeFK_ARPriceLevelID.BOSDataMember = "FK_ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_ARPriceLevelID.BOSDescription = null;
            this.fld_lkeFK_ARPriceLevelID.BOSError = "";
            this.fld_lkeFK_ARPriceLevelID.BOSFieldGroup = "";
            this.fld_lkeFK_ARPriceLevelID.BOSFieldParent = "";
            this.fld_lkeFK_ARPriceLevelID.BOSFieldRelation = "";
            this.fld_lkeFK_ARPriceLevelID.BOSPrivilege = "";
            this.fld_lkeFK_ARPriceLevelID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARPriceLevelID.BOSSelectType = "";
            this.fld_lkeFK_ARPriceLevelID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARPriceLevelID.CurrentDisplayText = "";
            this.fld_lkeFK_ARPriceLevelID.Location = new System.Drawing.Point(139, 26);
            this.fld_lkeFK_ARPriceLevelID.Name = "fld_lkeFK_ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARPriceLevelID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARPriceLevelID.Properties.ColumnName = null;
            this.fld_lkeFK_ARPriceLevelID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARPriceLevelNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARPriceLevelName", "Name")});
            this.fld_lkeFK_ARPriceLevelID.Properties.DisplayMember = "ARPriceLevelName";
            this.fld_lkeFK_ARPriceLevelID.Properties.NullText = "";
            this.fld_lkeFK_ARPriceLevelID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ARPriceLevelID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARPriceLevelID.Properties.ValueMember = "ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID.Screen = null;
            this.fld_lkeFK_ARPriceLevelID.Size = new System.Drawing.Size(124, 20);
            this.fld_lkeFK_ARPriceLevelID.TabIndex = 0;
            this.fld_lkeFK_ARPriceLevelID.Tag = "DC";
            // 
            // fld_txtARCustomerCreditLimit
            // 
            this.fld_txtARCustomerCreditLimit.BOSComment = "";
            this.fld_txtARCustomerCreditLimit.BOSDataMember = "ARCustomerCreditLimit";
            this.fld_txtARCustomerCreditLimit.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerCreditLimit.BOSDescription = null;
            this.fld_txtARCustomerCreditLimit.BOSError = "";
            this.fld_txtARCustomerCreditLimit.BOSFieldGroup = "";
            this.fld_txtARCustomerCreditLimit.BOSFieldRelation = "";
            this.fld_txtARCustomerCreditLimit.BOSPrivilege = "";
            this.fld_txtARCustomerCreditLimit.BOSPropertyName = "Text";
            this.fld_txtARCustomerCreditLimit.Location = new System.Drawing.Point(139, 113);
            this.fld_txtARCustomerCreditLimit.Name = "fld_txtARCustomerCreditLimit";
            this.fld_txtARCustomerCreditLimit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerCreditLimit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerCreditLimit.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerCreditLimit.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerCreditLimit.Properties.Mask.EditMask = "n";
            this.fld_txtARCustomerCreditLimit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARCustomerCreditLimit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerCreditLimit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerCreditLimit.Screen = null;
            this.fld_txtARCustomerCreditLimit.Size = new System.Drawing.Size(124, 20);
            this.fld_txtARCustomerCreditLimit.TabIndex = 6;
            this.fld_txtARCustomerCreditLimit.Tag = "DC";
            // 
            // fld_txtARCustomerDiscount
            // 
            this.fld_txtARCustomerDiscount.BOSComment = "";
            this.fld_txtARCustomerDiscount.BOSDataMember = "ARCustomerDiscount";
            this.fld_txtARCustomerDiscount.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerDiscount.BOSDescription = null;
            this.fld_txtARCustomerDiscount.BOSError = "";
            this.fld_txtARCustomerDiscount.BOSFieldGroup = "";
            this.fld_txtARCustomerDiscount.BOSFieldRelation = "";
            this.fld_txtARCustomerDiscount.BOSPrivilege = "";
            this.fld_txtARCustomerDiscount.BOSPropertyName = "Text";
            this.fld_txtARCustomerDiscount.Location = new System.Drawing.Point(354, 26);
            this.fld_txtARCustomerDiscount.Name = "fld_txtARCustomerDiscount";
            this.fld_txtARCustomerDiscount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerDiscount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerDiscount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerDiscount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerDiscount.Properties.Mask.EditMask = "n";
            this.fld_txtARCustomerDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARCustomerDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerDiscount.Screen = null;
            this.fld_txtARCustomerDiscount.Size = new System.Drawing.Size(117, 20);
            this.fld_txtARCustomerDiscount.TabIndex = 1;
            this.fld_txtARCustomerDiscount.Tag = "DC";
            // 
            // fld_lkeARPaymentMethodCombo
            // 
            this.fld_lkeARPaymentMethodCombo.BOSAllowAddNew = false;
            this.fld_lkeARPaymentMethodCombo.BOSAllowDummy = true;
            this.fld_lkeARPaymentMethodCombo.BOSComment = "";
            this.fld_lkeARPaymentMethodCombo.BOSDataMember = "ARPaymentMethodCombo";
            this.fld_lkeARPaymentMethodCombo.BOSDataSource = "ARCustomers";
            this.fld_lkeARPaymentMethodCombo.BOSDescription = null;
            this.fld_lkeARPaymentMethodCombo.BOSError = "";
            this.fld_lkeARPaymentMethodCombo.BOSFieldGroup = "";
            this.fld_lkeARPaymentMethodCombo.BOSFieldParent = "";
            this.fld_lkeARPaymentMethodCombo.BOSFieldRelation = "";
            this.fld_lkeARPaymentMethodCombo.BOSPrivilege = "";
            this.fld_lkeARPaymentMethodCombo.BOSPropertyName = "EditValue";
            this.fld_lkeARPaymentMethodCombo.BOSSelectType = "";
            this.fld_lkeARPaymentMethodCombo.BOSSelectTypeValue = "";
            this.fld_lkeARPaymentMethodCombo.CurrentDisplayText = "";
            this.fld_lkeARPaymentMethodCombo.Location = new System.Drawing.Point(139, 77);
            this.fld_lkeARPaymentMethodCombo.Name = "fld_lkeARPaymentMethodCombo";
            this.fld_lkeARPaymentMethodCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARPaymentMethodCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARPaymentMethodCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARPaymentMethodCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARPaymentMethodCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARPaymentMethodCombo.Properties.ColumnName = null;
            this.fld_lkeARPaymentMethodCombo.Properties.NullText = "";
            this.fld_lkeARPaymentMethodCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARPaymentMethodCombo.Screen = null;
            this.fld_lkeARPaymentMethodCombo.Size = new System.Drawing.Size(124, 20);
            this.fld_lkeARPaymentMethodCombo.TabIndex = 3;
            this.fld_lkeARPaymentMethodCombo.Tag = "DC";
            // 
            // fld_grcGroupControl2
            // 
            this.fld_grcGroupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl2.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl2.BOSComment = "";
            this.fld_grcGroupControl2.BOSDataMember = null;
            this.fld_grcGroupControl2.BOSDataSource = null;
            this.fld_grcGroupControl2.BOSDescription = null;
            this.fld_grcGroupControl2.BOSError = null;
            this.fld_grcGroupControl2.BOSFieldGroup = "";
            this.fld_grcGroupControl2.BOSFieldRelation = null;
            this.fld_grcGroupControl2.BOSPrivilege = "";
            this.fld_grcGroupControl2.BOSPropertyName = null;
            this.fld_grcGroupControl2.Controls.Add(this.fld_lkeARCustomerSex);
            this.fld_grcGroupControl2.Controls.Add(this.bosLabel34);
            this.fld_grcGroupControl2.Controls.Add(this.fld_txtARCustomerLevel);
            this.fld_grcGroupControl2.Controls.Add(this.bosLabel30);
            this.fld_grcGroupControl2.Controls.Add(this.fld_bedGELocationName);
            this.fld_grcGroupControl2.Controls.Add(this.bosLabel16);
            this.fld_grcGroupControl2.Controls.Add(this.bosLabel15);
            this.fld_grcGroupControl2.Controls.Add(this.fld_txtARCustomerContactAddressLine1);
            this.fld_grcGroupControl2.Controls.Add(this.fld_lblLabel45);
            this.fld_grcGroupControl2.Controls.Add(this.fld_txtARCustomerContactWebsite);
            this.fld_grcGroupControl2.Controls.Add(this.fld_txtARCustomerContactEmail1);
            this.fld_grcGroupControl2.Controls.Add(this.fld_txtARCustomerContactCellPhone);
            this.fld_grcGroupControl2.Controls.Add(this.fld_lblLabel35);
            this.fld_grcGroupControl2.Controls.Add(this.fld_txtARCustomerContactFax);
            this.fld_grcGroupControl2.Controls.Add(this.fld_lblLabel38);
            this.fld_grcGroupControl2.Controls.Add(this.fld_txtARCustomerContactTitle);
            this.fld_grcGroupControl2.Controls.Add(this.fld_txtARCustomerContactPhone);
            this.fld_grcGroupControl2.Controls.Add(this.fld_lblLabel48);
            this.fld_grcGroupControl2.Controls.Add(this.fld_txtARCustomerContactFirstName);
            this.fld_grcGroupControl2.Controls.Add(this.fld_lblLabel49);
            this.fld_grcGroupControl2.Controls.Add(this.fld_lblLabel18);
            this.fld_grcGroupControl2.Controls.Add(this.fld_lblLabel50);
            this.fld_grcGroupControl2.Location = new System.Drawing.Point(13, 388);
            this.fld_grcGroupControl2.Name = "fld_grcGroupControl2";
            this.fld_grcGroupControl2.Screen = null;
            this.fld_grcGroupControl2.Size = new System.Drawing.Size(482, 245);
            this.fld_grcGroupControl2.TabIndex = 1;
            this.fld_grcGroupControl2.Text = "Thông tin trung gian bán hàng/ người mua hàng";
            // 
            // fld_lkeARCustomerSex
            // 
            this.fld_lkeARCustomerSex.BOSAllowAddNew = false;
            this.fld_lkeARCustomerSex.BOSAllowDummy = true;
            this.fld_lkeARCustomerSex.BOSComment = "";
            this.fld_lkeARCustomerSex.BOSDataMember = "ARCustomerSex";
            this.fld_lkeARCustomerSex.BOSDataSource = "ARCustomers";
            this.fld_lkeARCustomerSex.BOSDescription = null;
            this.fld_lkeARCustomerSex.BOSError = "";
            this.fld_lkeARCustomerSex.BOSFieldGroup = "";
            this.fld_lkeARCustomerSex.BOSFieldParent = "";
            this.fld_lkeARCustomerSex.BOSFieldRelation = "";
            this.fld_lkeARCustomerSex.BOSPrivilege = "";
            this.fld_lkeARCustomerSex.BOSPropertyName = "EditValue";
            this.fld_lkeARCustomerSex.BOSSelectType = "";
            this.fld_lkeARCustomerSex.BOSSelectTypeValue = "";
            this.fld_lkeARCustomerSex.CurrentDisplayText = "";
            this.fld_lkeARCustomerSex.Location = new System.Drawing.Point(339, 82);
            this.fld_lkeARCustomerSex.Name = "fld_lkeARCustomerSex";
            this.fld_lkeARCustomerSex.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARCustomerSex.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARCustomerSex.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARCustomerSex.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARCustomerSex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCustomerSex.Properties.ColumnName = null;
            this.fld_lkeARCustomerSex.Properties.NullText = "";
            this.fld_lkeARCustomerSex.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARCustomerSex.Screen = null;
            this.fld_lkeARCustomerSex.Size = new System.Drawing.Size(124, 20);
            this.fld_lkeARCustomerSex.TabIndex = 4;
            this.fld_lkeARCustomerSex.Tag = "DC";
            // 
            // bosLabel34
            // 
            this.bosLabel34.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel34.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel34.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel34.Appearance.Options.UseBackColor = true;
            this.bosLabel34.Appearance.Options.UseFont = true;
            this.bosLabel34.Appearance.Options.UseForeColor = true;
            this.bosLabel34.BOSComment = "";
            this.bosLabel34.BOSDataMember = "";
            this.bosLabel34.BOSDataSource = "";
            this.bosLabel34.BOSDescription = null;
            this.bosLabel34.BOSError = null;
            this.bosLabel34.BOSFieldGroup = "";
            this.bosLabel34.BOSFieldRelation = "";
            this.bosLabel34.BOSPrivilege = "";
            this.bosLabel34.BOSPropertyName = null;
            this.bosLabel34.Location = new System.Drawing.Point(258, 85);
            this.bosLabel34.Name = "bosLabel34";
            this.bosLabel34.Screen = null;
            this.bosLabel34.Size = new System.Drawing.Size(40, 13);
            this.bosLabel34.TabIndex = 22;
            this.bosLabel34.Tag = "";
            this.bosLabel34.Text = "Giới tính";
            // 
            // fld_txtARCustomerLevel
            // 
            this.fld_txtARCustomerLevel.BOSComment = "";
            this.fld_txtARCustomerLevel.BOSDataMember = "ARCustomerLevel";
            this.fld_txtARCustomerLevel.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerLevel.BOSDescription = null;
            this.fld_txtARCustomerLevel.BOSError = "";
            this.fld_txtARCustomerLevel.BOSFieldGroup = "";
            this.fld_txtARCustomerLevel.BOSFieldRelation = "";
            this.fld_txtARCustomerLevel.BOSPrivilege = "";
            this.fld_txtARCustomerLevel.BOSPropertyName = "Text";
            this.fld_txtARCustomerLevel.Location = new System.Drawing.Point(339, 25);
            this.fld_txtARCustomerLevel.Name = "fld_txtARCustomerLevel";
            this.fld_txtARCustomerLevel.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerLevel.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerLevel.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerLevel.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerLevel.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerLevel.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerLevel, true);
            this.fld_txtARCustomerLevel.Size = new System.Drawing.Size(124, 20);
            this.fld_txtARCustomerLevel.TabIndex = 1;
            this.fld_txtARCustomerLevel.Tag = "DC";
            // 
            // bosLabel30
            // 
            this.bosLabel30.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel30.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel30.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel30.Appearance.Options.UseBackColor = true;
            this.bosLabel30.Appearance.Options.UseFont = true;
            this.bosLabel30.Appearance.Options.UseForeColor = true;
            this.bosLabel30.BOSComment = "";
            this.bosLabel30.BOSDataMember = "";
            this.bosLabel30.BOSDataSource = "";
            this.bosLabel30.BOSDescription = null;
            this.bosLabel30.BOSError = null;
            this.bosLabel30.BOSFieldGroup = "";
            this.bosLabel30.BOSFieldRelation = "";
            this.bosLabel30.BOSPrivilege = "";
            this.bosLabel30.BOSPropertyName = null;
            this.bosLabel30.Location = new System.Drawing.Point(258, 28);
            this.bosLabel30.Name = "bosLabel30";
            this.bosLabel30.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel30, true);
            this.bosLabel30.Size = new System.Drawing.Size(40, 13);
            this.bosLabel30.TabIndex = 20;
            this.bosLabel30.Tag = "";
            this.bosLabel30.Text = "Chức vụ";
            // 
            // fld_bedGELocationName
            // 
            this.fld_bedGELocationName.BOSComment = null;
            this.fld_bedGELocationName.BOSDataMember = "GELocationName";
            this.fld_bedGELocationName.BOSDataSource = "ARCustomers";
            this.fld_bedGELocationName.BOSDescription = null;
            this.fld_bedGELocationName.BOSError = null;
            this.fld_bedGELocationName.BOSFieldGroup = null;
            this.fld_bedGELocationName.BOSFieldRelation = null;
            this.fld_bedGELocationName.BOSPrivilege = null;
            this.fld_bedGELocationName.BOSPropertyName = "Text";
            this.fld_bedGELocationName.Location = new System.Drawing.Point(97, 212);
            this.fld_bedGELocationName.MenuManager = this.screenToolbar;
            this.fld_bedGELocationName.Name = "fld_bedGELocationName";
            this.fld_bedGELocationName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedGELocationName.Properties.ReadOnly = true;
            this.fld_bedGELocationName.Screen = null;
            this.fld_bedGELocationName.Size = new System.Drawing.Size(366, 20);
            this.fld_bedGELocationName.TabIndex = 11;
            this.fld_bedGELocationName.Tag = "DC";
            this.fld_bedGELocationName.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedGELocationName_ButtonClick);
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = "";
            this.bosLabel16.BOSDataMember = "";
            this.bosLabel16.BOSDataSource = "";
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = "";
            this.bosLabel16.BOSFieldRelation = "";
            this.bosLabel16.BOSPrivilege = "";
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(12, 215);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(21, 13);
            this.bosLabel16.TabIndex = 16;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "Vị trí";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = "";
            this.bosLabel15.BOSDataMember = "";
            this.bosLabel15.BOSDataSource = "";
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = "";
            this.bosLabel15.BOSFieldRelation = "";
            this.bosLabel15.BOSPrivilege = "";
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(12, 189);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(32, 13);
            this.bosLabel15.TabIndex = 16;
            this.bosLabel15.Tag = "";
            this.bosLabel15.Text = "Địa chỉ";
            // 
            // fld_txtARCustomerContactAddressLine1
            // 
            this.fld_txtARCustomerContactAddressLine1.BOSComment = "";
            this.fld_txtARCustomerContactAddressLine1.BOSDataMember = "ARCustomerContactAddressLine1";
            this.fld_txtARCustomerContactAddressLine1.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerContactAddressLine1.BOSDescription = null;
            this.fld_txtARCustomerContactAddressLine1.BOSError = "";
            this.fld_txtARCustomerContactAddressLine1.BOSFieldGroup = "";
            this.fld_txtARCustomerContactAddressLine1.BOSFieldRelation = "";
            this.fld_txtARCustomerContactAddressLine1.BOSPrivilege = "";
            this.fld_txtARCustomerContactAddressLine1.BOSPropertyName = "Text";
            this.fld_txtARCustomerContactAddressLine1.Location = new System.Drawing.Point(97, 186);
            this.fld_txtARCustomerContactAddressLine1.Name = "fld_txtARCustomerContactAddressLine1";
            this.fld_txtARCustomerContactAddressLine1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerContactAddressLine1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerContactAddressLine1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerContactAddressLine1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerContactAddressLine1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerContactAddressLine1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerContactAddressLine1.Screen = null;
            this.fld_txtARCustomerContactAddressLine1.Size = new System.Drawing.Size(366, 20);
            this.fld_txtARCustomerContactAddressLine1.TabIndex = 10;
            this.fld_txtARCustomerContactAddressLine1.Tag = "DC";
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.BOSComment = "";
            this.fld_grcGroupControl1.BOSDataMember = null;
            this.fld_grcGroupControl1.BOSDataSource = null;
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = "";
            this.fld_grcGroupControl1.BOSFieldRelation = null;
            this.fld_grcGroupControl1.BOSPrivilege = "";
            this.fld_grcGroupControl1.BOSPropertyName = null;
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel51);
            this.fld_grcGroupControl1.Controls.Add(this.bosTextBox2);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtARCustomerPaymentAddressEmail);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel48);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtARCustomerDeliveryAddressEmail);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel47);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtARCustomerPaymentContactName);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel44);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtARCustomerInvoiceContactName);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel43);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtARCustomerDeliveryHomeNumber);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel18);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_GEDeliveryCountryID);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel7);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_GEDeliveryWardID);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_GEDeliveryStreetID);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtARCustomerDeliveryContactName);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel33);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtARCustomerPaymentAddressTel);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_GEDeliveryStateProvinceID);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_GEDeliveryDistrictID);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel39);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel27);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel40);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtARCustomerDeliveryAddressTel);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel41);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel26);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel42);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtARCustomerInvoiceAddressTel);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel25);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtARCustomerPaymentAddressPostalCode);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel8);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtARCustomerDeliveryAddressPostalCode);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabelDeliveryPostalCode);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtARCustomerInvoiceAddressPostalCode);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabelInvoicePostalCode);
            this.fld_grcGroupControl1.Controls.Add(this.fld_bedGELocationName3);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabelPaymentPostalCode);
            this.fld_grcGroupControl1.Controls.Add(this.fld_bedGELocationName2);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel22);
            this.fld_grcGroupControl1.Controls.Add(this.fld_bedGELocationName1);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtARCustomerPaymentAddressFax);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtARCustomerDeliveryAddressFax);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtARCustomerInvoiceAddressFax);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel21);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lnkCopyPaymentAddress);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtARCustomerPaymentAddressTaxCode);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtARCustomerDeliveryAddressTaxCode);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtARCustomerInvoiceAddressTaxCode);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel24);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lnkCopyInvoiceAddress);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel23);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lnkCopyDeliveryAddress);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtARCustomerPaymentAddressLine1);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl1.Controls.Add(this.bosLine3);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel6);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel7);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel9);
            this.fld_grcGroupControl1.Controls.Add(this.bosLine2);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel28);
            this.fld_grcGroupControl1.Controls.Add(this.bosLine1);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtARCustomerDeliveryAddressLine1);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel6);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtARCustomerInvoiceAddressLine1);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(497, 191);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl1, true);
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(480, 633);
            this.fld_grcGroupControl1.TabIndex = 3;
            this.fld_grcGroupControl1.Text = "Địa chỉ giao dịch";
            // 
            // bosLabel51
            // 
            this.bosLabel51.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel51.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel51.Appearance.Options.UseBackColor = true;
            this.bosLabel51.Appearance.Options.UseForeColor = true;
            this.bosLabel51.BOSComment = "";
            this.bosLabel51.BOSDataMember = "";
            this.bosLabel51.BOSDataSource = "";
            this.bosLabel51.BOSDescription = null;
            this.bosLabel51.BOSError = null;
            this.bosLabel51.BOSFieldGroup = "";
            this.bosLabel51.BOSFieldRelation = "";
            this.bosLabel51.BOSPrivilege = "";
            this.bosLabel51.BOSPropertyName = null;
            this.bosLabel51.Location = new System.Drawing.Point(17, 101);
            this.bosLabel51.Name = "bosLabel51";
            this.bosLabel51.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel51, true);
            this.bosLabel51.Size = new System.Drawing.Size(54, 13);
            this.bosLabel51.TabIndex = 73;
            this.bosLabel51.Tag = "";
            this.bosLabel51.Text = "Email HDDT";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = "";
            this.bosTextBox2.BOSDataMember = "ARCustomerInvoiceAddressEmail";
            this.bosTextBox2.BOSDataSource = "ARCustomers";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = "";
            this.bosTextBox2.BOSFieldGroup = "";
            this.bosTextBox2.BOSFieldRelation = "";
            this.bosTextBox2.BOSPrivilege = "";
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.Location = new System.Drawing.Point(80, 98);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox2, true);
            this.bosTextBox2.Size = new System.Drawing.Size(384, 20);
            this.bosTextBox2.TabIndex = 72;
            this.bosTextBox2.Tag = "DC";
            // 
            // fld_txtARCustomerPaymentAddressEmail
            // 
            this.fld_txtARCustomerPaymentAddressEmail.BOSComment = "";
            this.fld_txtARCustomerPaymentAddressEmail.BOSDataMember = "ARCustomerPaymentAddressEmail";
            this.fld_txtARCustomerPaymentAddressEmail.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerPaymentAddressEmail.BOSDescription = null;
            this.fld_txtARCustomerPaymentAddressEmail.BOSError = "";
            this.fld_txtARCustomerPaymentAddressEmail.BOSFieldGroup = "";
            this.fld_txtARCustomerPaymentAddressEmail.BOSFieldRelation = "";
            this.fld_txtARCustomerPaymentAddressEmail.BOSPrivilege = "";
            this.fld_txtARCustomerPaymentAddressEmail.BOSPropertyName = "Text";
            this.fld_txtARCustomerPaymentAddressEmail.Location = new System.Drawing.Point(79, 521);
            this.fld_txtARCustomerPaymentAddressEmail.Name = "fld_txtARCustomerPaymentAddressEmail";
            this.fld_txtARCustomerPaymentAddressEmail.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerPaymentAddressEmail.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerPaymentAddressEmail.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerPaymentAddressEmail.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerPaymentAddressEmail.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerPaymentAddressEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerPaymentAddressEmail.Screen = null;
            this.fld_txtARCustomerPaymentAddressEmail.Size = new System.Drawing.Size(385, 20);
            this.fld_txtARCustomerPaymentAddressEmail.TabIndex = 70;
            this.fld_txtARCustomerPaymentAddressEmail.Tag = "DC";
            // 
            // bosLabel48
            // 
            this.bosLabel48.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel48.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel48.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel48.Appearance.Options.UseBackColor = true;
            this.bosLabel48.Appearance.Options.UseFont = true;
            this.bosLabel48.Appearance.Options.UseForeColor = true;
            this.bosLabel48.BOSComment = "";
            this.bosLabel48.BOSDataMember = "";
            this.bosLabel48.BOSDataSource = "";
            this.bosLabel48.BOSDescription = null;
            this.bosLabel48.BOSError = null;
            this.bosLabel48.BOSFieldGroup = "";
            this.bosLabel48.BOSFieldRelation = "";
            this.bosLabel48.BOSPrivilege = "";
            this.bosLabel48.BOSPropertyName = null;
            this.bosLabel48.Location = new System.Drawing.Point(16, 524);
            this.bosLabel48.Name = "bosLabel48";
            this.bosLabel48.Screen = null;
            this.bosLabel48.Size = new System.Drawing.Size(25, 13);
            this.bosLabel48.TabIndex = 71;
            this.bosLabel48.Tag = "";
            this.bosLabel48.Text = "Email";
            // 
            // fld_txtARCustomerDeliveryAddressEmail
            // 
            this.fld_txtARCustomerDeliveryAddressEmail.BOSComment = "";
            this.fld_txtARCustomerDeliveryAddressEmail.BOSDataMember = "ARCustomerDeliveryAddressEmail";
            this.fld_txtARCustomerDeliveryAddressEmail.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerDeliveryAddressEmail.BOSDescription = null;
            this.fld_txtARCustomerDeliveryAddressEmail.BOSError = "";
            this.fld_txtARCustomerDeliveryAddressEmail.BOSFieldGroup = "";
            this.fld_txtARCustomerDeliveryAddressEmail.BOSFieldRelation = "";
            this.fld_txtARCustomerDeliveryAddressEmail.BOSPrivilege = "";
            this.fld_txtARCustomerDeliveryAddressEmail.BOSPropertyName = "Text";
            this.fld_txtARCustomerDeliveryAddressEmail.Location = new System.Drawing.Point(88, 346);
            this.fld_txtARCustomerDeliveryAddressEmail.Name = "fld_txtARCustomerDeliveryAddressEmail";
            this.fld_txtARCustomerDeliveryAddressEmail.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerDeliveryAddressEmail.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerDeliveryAddressEmail.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerDeliveryAddressEmail.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerDeliveryAddressEmail.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerDeliveryAddressEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerDeliveryAddressEmail.Screen = null;
            this.fld_txtARCustomerDeliveryAddressEmail.Size = new System.Drawing.Size(376, 20);
            this.fld_txtARCustomerDeliveryAddressEmail.TabIndex = 68;
            this.fld_txtARCustomerDeliveryAddressEmail.Tag = "DC";
            // 
            // bosLabel47
            // 
            this.bosLabel47.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel47.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel47.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel47.Appearance.Options.UseBackColor = true;
            this.bosLabel47.Appearance.Options.UseFont = true;
            this.bosLabel47.Appearance.Options.UseForeColor = true;
            this.bosLabel47.BOSComment = "";
            this.bosLabel47.BOSDataMember = "";
            this.bosLabel47.BOSDataSource = "";
            this.bosLabel47.BOSDescription = null;
            this.bosLabel47.BOSError = null;
            this.bosLabel47.BOSFieldGroup = "";
            this.bosLabel47.BOSFieldRelation = "";
            this.bosLabel47.BOSPrivilege = "";
            this.bosLabel47.BOSPropertyName = null;
            this.bosLabel47.Location = new System.Drawing.Point(17, 349);
            this.bosLabel47.Name = "bosLabel47";
            this.bosLabel47.Screen = null;
            this.bosLabel47.Size = new System.Drawing.Size(25, 13);
            this.bosLabel47.TabIndex = 69;
            this.bosLabel47.Tag = "";
            this.bosLabel47.Text = "Email";
            // 
            // fld_txtARCustomerPaymentContactName
            // 
            this.fld_txtARCustomerPaymentContactName.BOSComment = "";
            this.fld_txtARCustomerPaymentContactName.BOSDataMember = "ARCustomerPaymentContactName";
            this.fld_txtARCustomerPaymentContactName.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerPaymentContactName.BOSDescription = null;
            this.fld_txtARCustomerPaymentContactName.BOSError = "";
            this.fld_txtARCustomerPaymentContactName.BOSFieldGroup = "";
            this.fld_txtARCustomerPaymentContactName.BOSFieldRelation = "";
            this.fld_txtARCustomerPaymentContactName.BOSPrivilege = "";
            this.fld_txtARCustomerPaymentContactName.BOSPropertyName = "Text";
            this.fld_txtARCustomerPaymentContactName.Location = new System.Drawing.Point(79, 469);
            this.fld_txtARCustomerPaymentContactName.Name = "fld_txtARCustomerPaymentContactName";
            this.fld_txtARCustomerPaymentContactName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerPaymentContactName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerPaymentContactName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerPaymentContactName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerPaymentContactName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerPaymentContactName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerPaymentContactName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerPaymentContactName, true);
            this.fld_txtARCustomerPaymentContactName.Size = new System.Drawing.Size(384, 20);
            this.fld_txtARCustomerPaymentContactName.TabIndex = 66;
            this.fld_txtARCustomerPaymentContactName.Tag = "DC";
            // 
            // bosLabel44
            // 
            this.bosLabel44.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel44.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel44.Appearance.Options.UseBackColor = true;
            this.bosLabel44.Appearance.Options.UseForeColor = true;
            this.bosLabel44.BOSComment = "";
            this.bosLabel44.BOSDataMember = "";
            this.bosLabel44.BOSDataSource = "";
            this.bosLabel44.BOSDescription = null;
            this.bosLabel44.BOSError = null;
            this.bosLabel44.BOSFieldGroup = "";
            this.bosLabel44.BOSFieldRelation = "";
            this.bosLabel44.BOSPrivilege = "";
            this.bosLabel44.BOSPropertyName = null;
            this.bosLabel44.Location = new System.Drawing.Point(16, 472);
            this.bosLabel44.Name = "bosLabel44";
            this.bosLabel44.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel44, true);
            this.bosLabel44.Size = new System.Drawing.Size(55, 13);
            this.bosLabel44.TabIndex = 67;
            this.bosLabel44.Tag = "";
            this.bosLabel44.Text = "Người nhận";
            // 
            // fld_txtARCustomerInvoiceContactName
            // 
            this.fld_txtARCustomerInvoiceContactName.BOSComment = "";
            this.fld_txtARCustomerInvoiceContactName.BOSDataMember = "ARCustomerInvoiceContactName";
            this.fld_txtARCustomerInvoiceContactName.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerInvoiceContactName.BOSDescription = null;
            this.fld_txtARCustomerInvoiceContactName.BOSError = "";
            this.fld_txtARCustomerInvoiceContactName.BOSFieldGroup = "";
            this.fld_txtARCustomerInvoiceContactName.BOSFieldRelation = "";
            this.fld_txtARCustomerInvoiceContactName.BOSPrivilege = "";
            this.fld_txtARCustomerInvoiceContactName.BOSPropertyName = "Text";
            this.fld_txtARCustomerInvoiceContactName.Location = new System.Drawing.Point(80, 46);
            this.fld_txtARCustomerInvoiceContactName.Name = "fld_txtARCustomerInvoiceContactName";
            this.fld_txtARCustomerInvoiceContactName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerInvoiceContactName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerInvoiceContactName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerInvoiceContactName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerInvoiceContactName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerInvoiceContactName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerInvoiceContactName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerInvoiceContactName, true);
            this.fld_txtARCustomerInvoiceContactName.Size = new System.Drawing.Size(384, 20);
            this.fld_txtARCustomerInvoiceContactName.TabIndex = 64;
            this.fld_txtARCustomerInvoiceContactName.Tag = "DC";
            // 
            // bosLabel43
            // 
            this.bosLabel43.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel43.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel43.Appearance.Options.UseBackColor = true;
            this.bosLabel43.Appearance.Options.UseForeColor = true;
            this.bosLabel43.BOSComment = "";
            this.bosLabel43.BOSDataMember = "";
            this.bosLabel43.BOSDataSource = "";
            this.bosLabel43.BOSDescription = null;
            this.bosLabel43.BOSError = null;
            this.bosLabel43.BOSFieldGroup = "";
            this.bosLabel43.BOSFieldRelation = "";
            this.bosLabel43.BOSPrivilege = "";
            this.bosLabel43.BOSPropertyName = null;
            this.bosLabel43.Location = new System.Drawing.Point(17, 49);
            this.bosLabel43.Name = "bosLabel43";
            this.bosLabel43.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel43, true);
            this.bosLabel43.Size = new System.Drawing.Size(55, 13);
            this.bosLabel43.TabIndex = 65;
            this.bosLabel43.Tag = "";
            this.bosLabel43.Text = "Người nhận";
            // 
            // fld_txtARCustomerDeliveryHomeNumber
            // 
            this.fld_txtARCustomerDeliveryHomeNumber.BOSComment = "";
            this.fld_txtARCustomerDeliveryHomeNumber.BOSDataMember = "ARCustomerDeliveryHomeNumber";
            this.fld_txtARCustomerDeliveryHomeNumber.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerDeliveryHomeNumber.BOSDescription = null;
            this.fld_txtARCustomerDeliveryHomeNumber.BOSError = "";
            this.fld_txtARCustomerDeliveryHomeNumber.BOSFieldGroup = "";
            this.fld_txtARCustomerDeliveryHomeNumber.BOSFieldRelation = "";
            this.fld_txtARCustomerDeliveryHomeNumber.BOSPrivilege = "";
            this.fld_txtARCustomerDeliveryHomeNumber.BOSPropertyName = "Text";
            this.fld_txtARCustomerDeliveryHomeNumber.Location = new System.Drawing.Point(314, 294);
            this.fld_txtARCustomerDeliveryHomeNumber.Name = "fld_txtARCustomerDeliveryHomeNumber";
            this.fld_txtARCustomerDeliveryHomeNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerDeliveryHomeNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerDeliveryHomeNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerDeliveryHomeNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerDeliveryHomeNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerDeliveryHomeNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerDeliveryHomeNumber.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerDeliveryHomeNumber, true);
            this.fld_txtARCustomerDeliveryHomeNumber.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARCustomerDeliveryHomeNumber.TabIndex = 12;
            this.fld_txtARCustomerDeliveryHomeNumber.Tag = "DC";
            this.fld_txtARCustomerDeliveryHomeNumber.TextChanged += new System.EventHandler(this.fld_txtARCustomerDeliveryHomeNumber_TextChanged);
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = "";
            this.bosLabel18.BOSDataMember = "";
            this.bosLabel18.BOSDataSource = "";
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = "";
            this.bosLabel18.BOSFieldRelation = "";
            this.bosLabel18.BOSPrivilege = "";
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(233, 297);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel18, true);
            this.bosLabel18.Size = new System.Drawing.Size(33, 13);
            this.bosLabel18.TabIndex = 63;
            this.bosLabel18.Tag = "";
            this.bosLabel18.Text = "Số nhà";
            // 
            // fld_lkeFK_GEDeliveryCountryID
            // 
            this.fld_lkeFK_GEDeliveryCountryID.BOSAllowAddNew = true;
            this.fld_lkeFK_GEDeliveryCountryID.BOSAllowDummy = false;
            this.fld_lkeFK_GEDeliveryCountryID.BOSComment = null;
            this.fld_lkeFK_GEDeliveryCountryID.BOSDataMember = "FK_GEDeliveryCountryID";
            this.fld_lkeFK_GEDeliveryCountryID.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_GEDeliveryCountryID.BOSDescription = null;
            this.fld_lkeFK_GEDeliveryCountryID.BOSError = null;
            this.fld_lkeFK_GEDeliveryCountryID.BOSFieldGroup = null;
            this.fld_lkeFK_GEDeliveryCountryID.BOSFieldParent = "";
            this.fld_lkeFK_GEDeliveryCountryID.BOSFieldRelation = null;
            this.fld_lkeFK_GEDeliveryCountryID.BOSPrivilege = null;
            this.fld_lkeFK_GEDeliveryCountryID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEDeliveryCountryID.BOSSelectType = null;
            this.fld_lkeFK_GEDeliveryCountryID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GEDeliveryCountryID.CurrentDisplayText = null;
            this.fld_lkeFK_GEDeliveryCountryID.Location = new System.Drawing.Point(88, 242);
            this.fld_lkeFK_GEDeliveryCountryID.Name = "fld_lkeFK_GEDeliveryCountryID";
            this.fld_lkeFK_GEDeliveryCountryID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEDeliveryCountryID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEDeliveryCountryID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEDeliveryCountryID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEDeliveryCountryID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEDeliveryCountryID.Properties.ColumnName = null;
            this.fld_lkeFK_GEDeliveryCountryID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECountryName", "Tên quốc gia")});
            this.fld_lkeFK_GEDeliveryCountryID.Properties.DisplayMember = "GECountryName";
            this.fld_lkeFK_GEDeliveryCountryID.Properties.NullText = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_GEDeliveryCountryID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GEDeliveryCountryID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEDeliveryCountryID.Properties.ValueMember = "GECountryID";
            this.fld_lkeFK_GEDeliveryCountryID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GEDeliveryCountryID, true);
            this.fld_lkeFK_GEDeliveryCountryID.Size = new System.Drawing.Size(139, 20);
            this.fld_lkeFK_GEDeliveryCountryID.TabIndex = 7;
            this.fld_lkeFK_GEDeliveryCountryID.Tag = "DC";
            this.fld_lkeFK_GEDeliveryCountryID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GEDeliveryCountryID_CloseUp);
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = "";
            this.fld_lblLabel7.BOSDataMember = "";
            this.fld_lblLabel7.BOSDataSource = "";
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = "";
            this.fld_lblLabel7.BOSFieldRelation = "";
            this.fld_lblLabel7.BOSPrivilege = "";
            this.fld_lblLabel7.BOSPropertyName = "";
            this.fld_lblLabel7.Location = new System.Drawing.Point(17, 245);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(42, 13);
            this.fld_lblLabel7.TabIndex = 54;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Quốc gia";
            // 
            // fld_lkeFK_GEDeliveryWardID
            // 
            this.fld_lkeFK_GEDeliveryWardID.BOSAllowAddNew = true;
            this.fld_lkeFK_GEDeliveryWardID.BOSAllowDummy = false;
            this.fld_lkeFK_GEDeliveryWardID.BOSComment = null;
            this.fld_lkeFK_GEDeliveryWardID.BOSDataMember = "FK_GEDeliveryWardID";
            this.fld_lkeFK_GEDeliveryWardID.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_GEDeliveryWardID.BOSDescription = null;
            this.fld_lkeFK_GEDeliveryWardID.BOSError = null;
            this.fld_lkeFK_GEDeliveryWardID.BOSFieldGroup = null;
            this.fld_lkeFK_GEDeliveryWardID.BOSFieldParent = "";
            this.fld_lkeFK_GEDeliveryWardID.BOSFieldRelation = null;
            this.fld_lkeFK_GEDeliveryWardID.BOSPrivilege = null;
            this.fld_lkeFK_GEDeliveryWardID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEDeliveryWardID.BOSSelectType = null;
            this.fld_lkeFK_GEDeliveryWardID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GEDeliveryWardID.CurrentDisplayText = null;
            this.fld_lkeFK_GEDeliveryWardID.Location = new System.Drawing.Point(314, 268);
            this.fld_lkeFK_GEDeliveryWardID.Name = "fld_lkeFK_GEDeliveryWardID";
            this.fld_lkeFK_GEDeliveryWardID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEDeliveryWardID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEDeliveryWardID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEDeliveryWardID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEDeliveryWardID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEDeliveryWardID.Properties.ColumnName = null;
            this.fld_lkeFK_GEDeliveryWardID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEWardName", "Tên Xã/Phường")});
            this.fld_lkeFK_GEDeliveryWardID.Properties.DisplayMember = "GEWardName";
            this.fld_lkeFK_GEDeliveryWardID.Properties.NullText = "";
            this.fld_lkeFK_GEDeliveryWardID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GEDeliveryWardID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEDeliveryWardID.Properties.ValueMember = "GEWardID";
            this.fld_lkeFK_GEDeliveryWardID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GEDeliveryWardID, true);
            this.fld_lkeFK_GEDeliveryWardID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GEDeliveryWardID.TabIndex = 10;
            this.fld_lkeFK_GEDeliveryWardID.Tag = "DC";
            this.fld_lkeFK_GEDeliveryWardID.BeforePopup += new System.EventHandler(this.Fld_lkeFK_GEDeliveryWardID_BeforePopup);
            this.fld_lkeFK_GEDeliveryWardID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GEDeliveryWardID_CloseUp);
            this.fld_lkeFK_GEDeliveryWardID.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_lkeFK_GEDeliveryWardID_EditValueChanging);
            // 
            // fld_lkeFK_GEDeliveryStreetID
            // 
            this.fld_lkeFK_GEDeliveryStreetID.BOSAllowAddNew = true;
            this.fld_lkeFK_GEDeliveryStreetID.BOSAllowDummy = false;
            this.fld_lkeFK_GEDeliveryStreetID.BOSComment = null;
            this.fld_lkeFK_GEDeliveryStreetID.BOSDataMember = "FK_GEDeliveryStreetID";
            this.fld_lkeFK_GEDeliveryStreetID.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_GEDeliveryStreetID.BOSDescription = null;
            this.fld_lkeFK_GEDeliveryStreetID.BOSError = null;
            this.fld_lkeFK_GEDeliveryStreetID.BOSFieldGroup = null;
            this.fld_lkeFK_GEDeliveryStreetID.BOSFieldParent = "";
            this.fld_lkeFK_GEDeliveryStreetID.BOSFieldRelation = null;
            this.fld_lkeFK_GEDeliveryStreetID.BOSPrivilege = null;
            this.fld_lkeFK_GEDeliveryStreetID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEDeliveryStreetID.BOSSelectType = null;
            this.fld_lkeFK_GEDeliveryStreetID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GEDeliveryStreetID.CurrentDisplayText = null;
            this.fld_lkeFK_GEDeliveryStreetID.EditValue = "<Null>";
            this.fld_lkeFK_GEDeliveryStreetID.Location = new System.Drawing.Point(88, 294);
            this.fld_lkeFK_GEDeliveryStreetID.Name = "fld_lkeFK_GEDeliveryStreetID";
            this.fld_lkeFK_GEDeliveryStreetID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEDeliveryStreetID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEDeliveryStreetID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEDeliveryStreetID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEDeliveryStreetID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEDeliveryStreetID.Properties.ColumnName = null;
            this.fld_lkeFK_GEDeliveryStreetID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEStreetName", "Tên đường")});
            this.fld_lkeFK_GEDeliveryStreetID.Properties.DisplayMember = "GEStreetName";
            this.fld_lkeFK_GEDeliveryStreetID.Properties.NullText = "";
            this.fld_lkeFK_GEDeliveryStreetID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GEDeliveryStreetID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEDeliveryStreetID.Properties.ValueMember = "GEStreetID";
            this.fld_lkeFK_GEDeliveryStreetID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GEDeliveryStreetID, true);
            this.fld_lkeFK_GEDeliveryStreetID.Size = new System.Drawing.Size(139, 20);
            this.fld_lkeFK_GEDeliveryStreetID.TabIndex = 11;
            this.fld_lkeFK_GEDeliveryStreetID.Tag = "DC";
            this.fld_lkeFK_GEDeliveryStreetID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GEDeliveryStreetID_CloseUp);
            this.fld_lkeFK_GEDeliveryStreetID.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_lkeFK_GEDeliveryStreetID_EditValueChanging);
            // 
            // fld_txtARCustomerDeliveryContactName
            // 
            this.fld_txtARCustomerDeliveryContactName.BOSComment = "";
            this.fld_txtARCustomerDeliveryContactName.BOSDataMember = "ARCustomerDeliveryContactName";
            this.fld_txtARCustomerDeliveryContactName.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerDeliveryContactName.BOSDescription = null;
            this.fld_txtARCustomerDeliveryContactName.BOSError = "";
            this.fld_txtARCustomerDeliveryContactName.BOSFieldGroup = "";
            this.fld_txtARCustomerDeliveryContactName.BOSFieldRelation = "";
            this.fld_txtARCustomerDeliveryContactName.BOSPrivilege = "";
            this.fld_txtARCustomerDeliveryContactName.BOSPropertyName = "Text";
            this.fld_txtARCustomerDeliveryContactName.Location = new System.Drawing.Point(88, 216);
            this.fld_txtARCustomerDeliveryContactName.Name = "fld_txtARCustomerDeliveryContactName";
            this.fld_txtARCustomerDeliveryContactName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerDeliveryContactName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerDeliveryContactName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerDeliveryContactName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerDeliveryContactName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerDeliveryContactName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerDeliveryContactName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerDeliveryContactName, true);
            this.fld_txtARCustomerDeliveryContactName.Size = new System.Drawing.Size(376, 20);
            this.fld_txtARCustomerDeliveryContactName.TabIndex = 6;
            this.fld_txtARCustomerDeliveryContactName.Tag = "DC";
            // 
            // bosLabel33
            // 
            this.bosLabel33.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel33.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel33.Appearance.Options.UseBackColor = true;
            this.bosLabel33.Appearance.Options.UseForeColor = true;
            this.bosLabel33.BOSComment = "";
            this.bosLabel33.BOSDataMember = "";
            this.bosLabel33.BOSDataSource = "";
            this.bosLabel33.BOSDescription = null;
            this.bosLabel33.BOSError = null;
            this.bosLabel33.BOSFieldGroup = "";
            this.bosLabel33.BOSFieldRelation = "";
            this.bosLabel33.BOSPrivilege = "";
            this.bosLabel33.BOSPropertyName = null;
            this.bosLabel33.Location = new System.Drawing.Point(17, 219);
            this.bosLabel33.Name = "bosLabel33";
            this.bosLabel33.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel33, true);
            this.bosLabel33.Size = new System.Drawing.Size(55, 13);
            this.bosLabel33.TabIndex = 52;
            this.bosLabel33.Tag = "";
            this.bosLabel33.Text = "Người nhận";
            // 
            // fld_txtARCustomerPaymentAddressTel
            // 
            this.fld_txtARCustomerPaymentAddressTel.BOSComment = "";
            this.fld_txtARCustomerPaymentAddressTel.BOSDataMember = "ARCustomerPaymentAddressTel";
            this.fld_txtARCustomerPaymentAddressTel.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerPaymentAddressTel.BOSDescription = null;
            this.fld_txtARCustomerPaymentAddressTel.BOSError = "";
            this.fld_txtARCustomerPaymentAddressTel.BOSFieldGroup = "";
            this.fld_txtARCustomerPaymentAddressTel.BOSFieldRelation = "";
            this.fld_txtARCustomerPaymentAddressTel.BOSPrivilege = "";
            this.fld_txtARCustomerPaymentAddressTel.BOSPropertyName = "Text";
            this.fld_txtARCustomerPaymentAddressTel.Location = new System.Drawing.Point(214, 573);
            this.fld_txtARCustomerPaymentAddressTel.Name = "fld_txtARCustomerPaymentAddressTel";
            this.fld_txtARCustomerPaymentAddressTel.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerPaymentAddressTel.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerPaymentAddressTel.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerPaymentAddressTel.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerPaymentAddressTel.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerPaymentAddressTel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerPaymentAddressTel.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerPaymentAddressTel, true);
            this.fld_txtARCustomerPaymentAddressTel.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARCustomerPaymentAddressTel.TabIndex = 23;
            this.fld_txtARCustomerPaymentAddressTel.Tag = "DC";
            // 
            // fld_lkeFK_GEDeliveryStateProvinceID
            // 
            this.fld_lkeFK_GEDeliveryStateProvinceID.BOSAllowAddNew = true;
            this.fld_lkeFK_GEDeliveryStateProvinceID.BOSAllowDummy = false;
            this.fld_lkeFK_GEDeliveryStateProvinceID.BOSComment = null;
            this.fld_lkeFK_GEDeliveryStateProvinceID.BOSDataMember = "FK_GEDeliveryStateProvinceID";
            this.fld_lkeFK_GEDeliveryStateProvinceID.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_GEDeliveryStateProvinceID.BOSDescription = null;
            this.fld_lkeFK_GEDeliveryStateProvinceID.BOSError = null;
            this.fld_lkeFK_GEDeliveryStateProvinceID.BOSFieldGroup = null;
            this.fld_lkeFK_GEDeliveryStateProvinceID.BOSFieldParent = "";
            this.fld_lkeFK_GEDeliveryStateProvinceID.BOSFieldRelation = null;
            this.fld_lkeFK_GEDeliveryStateProvinceID.BOSPrivilege = null;
            this.fld_lkeFK_GEDeliveryStateProvinceID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEDeliveryStateProvinceID.BOSSelectType = null;
            this.fld_lkeFK_GEDeliveryStateProvinceID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GEDeliveryStateProvinceID.CurrentDisplayText = null;
            this.fld_lkeFK_GEDeliveryStateProvinceID.Location = new System.Drawing.Point(314, 242);
            this.fld_lkeFK_GEDeliveryStateProvinceID.Name = "fld_lkeFK_GEDeliveryStateProvinceID";
            this.fld_lkeFK_GEDeliveryStateProvinceID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEDeliveryStateProvinceID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEDeliveryStateProvinceID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEDeliveryStateProvinceID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEDeliveryStateProvinceID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEDeliveryStateProvinceID.Properties.ColumnName = null;
            this.fld_lkeFK_GEDeliveryStateProvinceID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEStateProvinceName", "Tên tỉnh / thành")});
            this.fld_lkeFK_GEDeliveryStateProvinceID.Properties.DisplayMember = "GEStateProvinceName";
            this.fld_lkeFK_GEDeliveryStateProvinceID.Properties.NullText = "";
            this.fld_lkeFK_GEDeliveryStateProvinceID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GEDeliveryStateProvinceID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEDeliveryStateProvinceID.Properties.ValueMember = "GEStateProvinceID";
            this.fld_lkeFK_GEDeliveryStateProvinceID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GEDeliveryStateProvinceID, true);
            this.fld_lkeFK_GEDeliveryStateProvinceID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GEDeliveryStateProvinceID.TabIndex = 8;
            this.fld_lkeFK_GEDeliveryStateProvinceID.Tag = "DC";
            this.fld_lkeFK_GEDeliveryStateProvinceID.BeforePopup += new System.EventHandler(this.Fld_lkeFK_GEDeliveryStateProvinceID_BeforePopup);
            this.fld_lkeFK_GEDeliveryStateProvinceID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GEDeliveryStateProvinceID_CloseUp);
            this.fld_lkeFK_GEDeliveryStateProvinceID.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_lkeFK_GEDeliveryStateProvinceID_EditValueChanging);
            // 
            // fld_lkeFK_GEDeliveryDistrictID
            // 
            this.fld_lkeFK_GEDeliveryDistrictID.BOSAllowAddNew = true;
            this.fld_lkeFK_GEDeliveryDistrictID.BOSAllowDummy = false;
            this.fld_lkeFK_GEDeliveryDistrictID.BOSComment = null;
            this.fld_lkeFK_GEDeliveryDistrictID.BOSDataMember = "FK_GEDeliveryDistrictID";
            this.fld_lkeFK_GEDeliveryDistrictID.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_GEDeliveryDistrictID.BOSDescription = null;
            this.fld_lkeFK_GEDeliveryDistrictID.BOSError = null;
            this.fld_lkeFK_GEDeliveryDistrictID.BOSFieldGroup = null;
            this.fld_lkeFK_GEDeliveryDistrictID.BOSFieldParent = "";
            this.fld_lkeFK_GEDeliveryDistrictID.BOSFieldRelation = null;
            this.fld_lkeFK_GEDeliveryDistrictID.BOSPrivilege = null;
            this.fld_lkeFK_GEDeliveryDistrictID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEDeliveryDistrictID.BOSSelectType = null;
            this.fld_lkeFK_GEDeliveryDistrictID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GEDeliveryDistrictID.CurrentDisplayText = null;
            this.fld_lkeFK_GEDeliveryDistrictID.Location = new System.Drawing.Point(88, 268);
            this.fld_lkeFK_GEDeliveryDistrictID.Name = "fld_lkeFK_GEDeliveryDistrictID";
            this.fld_lkeFK_GEDeliveryDistrictID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEDeliveryDistrictID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEDeliveryDistrictID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEDeliveryDistrictID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEDeliveryDistrictID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEDeliveryDistrictID.Properties.ColumnName = null;
            this.fld_lkeFK_GEDeliveryDistrictID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEDistrictName", "Tên quận/ huyện")});
            this.fld_lkeFK_GEDeliveryDistrictID.Properties.DisplayMember = "GEDistrictName";
            this.fld_lkeFK_GEDeliveryDistrictID.Properties.NullText = "";
            this.fld_lkeFK_GEDeliveryDistrictID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GEDeliveryDistrictID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEDeliveryDistrictID.Properties.ValueMember = "GEDistrictID";
            this.fld_lkeFK_GEDeliveryDistrictID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GEDeliveryDistrictID, true);
            this.fld_lkeFK_GEDeliveryDistrictID.Size = new System.Drawing.Size(139, 20);
            this.fld_lkeFK_GEDeliveryDistrictID.TabIndex = 9;
            this.fld_lkeFK_GEDeliveryDistrictID.Tag = "DC";
            this.fld_lkeFK_GEDeliveryDistrictID.BeforePopup += new System.EventHandler(this.Fld_lkeFK_GEDeliveryDistrictID_BeforePopup);
            this.fld_lkeFK_GEDeliveryDistrictID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GEDeliveryDistrictID_CloseUp);
            this.fld_lkeFK_GEDeliveryDistrictID.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_lkeFK_GEDeliveryDistrictID_EditValueChanging);
            // 
            // bosLabel39
            // 
            this.bosLabel39.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel39.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel39.Appearance.Options.UseBackColor = true;
            this.bosLabel39.Appearance.Options.UseForeColor = true;
            this.bosLabel39.BOSComment = "";
            this.bosLabel39.BOSDataMember = "";
            this.bosLabel39.BOSDataSource = "";
            this.bosLabel39.BOSDescription = null;
            this.bosLabel39.BOSError = null;
            this.bosLabel39.BOSFieldGroup = "";
            this.bosLabel39.BOSFieldRelation = "";
            this.bosLabel39.BOSPrivilege = "";
            this.bosLabel39.BOSPropertyName = null;
            this.bosLabel39.Location = new System.Drawing.Point(17, 297);
            this.bosLabel39.Name = "bosLabel39";
            this.bosLabel39.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel39, true);
            this.bosLabel39.Size = new System.Drawing.Size(50, 13);
            this.bosLabel39.TabIndex = 53;
            this.bosLabel39.Tag = "";
            this.bosLabel39.Text = "Ấp/Đường";
            // 
            // bosLabel27
            // 
            this.bosLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel27.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.Options.UseBackColor = true;
            this.bosLabel27.Appearance.Options.UseFont = true;
            this.bosLabel27.Appearance.Options.UseForeColor = true;
            this.bosLabel27.BOSComment = "";
            this.bosLabel27.BOSDataMember = "";
            this.bosLabel27.BOSDataSource = "";
            this.bosLabel27.BOSDescription = null;
            this.bosLabel27.BOSError = null;
            this.bosLabel27.BOSFieldGroup = "";
            this.bosLabel27.BOSFieldRelation = "";
            this.bosLabel27.BOSPrivilege = "";
            this.bosLabel27.BOSPropertyName = null;
            this.bosLabel27.Location = new System.Drawing.Point(193, 576);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel27, true);
            this.bosLabel27.Size = new System.Drawing.Size(15, 13);
            this.bosLabel27.TabIndex = 51;
            this.bosLabel27.Tag = "";
            this.bosLabel27.Text = "Tel";
            // 
            // bosLabel40
            // 
            this.bosLabel40.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel40.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel40.Appearance.Options.UseBackColor = true;
            this.bosLabel40.Appearance.Options.UseForeColor = true;
            this.bosLabel40.BOSComment = "";
            this.bosLabel40.BOSDataMember = "";
            this.bosLabel40.BOSDataSource = "";
            this.bosLabel40.BOSDescription = null;
            this.bosLabel40.BOSError = null;
            this.bosLabel40.BOSFieldGroup = "";
            this.bosLabel40.BOSFieldRelation = "";
            this.bosLabel40.BOSPrivilege = "";
            this.bosLabel40.BOSPropertyName = null;
            this.bosLabel40.Location = new System.Drawing.Point(233, 271);
            this.bosLabel40.Name = "bosLabel40";
            this.bosLabel40.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel40, true);
            this.bosLabel40.Size = new System.Drawing.Size(53, 13);
            this.bosLabel40.TabIndex = 56;
            this.bosLabel40.Tag = "";
            this.bosLabel40.Text = "Xã/Phường";
            // 
            // fld_txtARCustomerDeliveryAddressTel
            // 
            this.fld_txtARCustomerDeliveryAddressTel.BOSComment = "";
            this.fld_txtARCustomerDeliveryAddressTel.BOSDataMember = "ARCustomerDeliveryAddressTel";
            this.fld_txtARCustomerDeliveryAddressTel.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerDeliveryAddressTel.BOSDescription = null;
            this.fld_txtARCustomerDeliveryAddressTel.BOSError = "";
            this.fld_txtARCustomerDeliveryAddressTel.BOSFieldGroup = "";
            this.fld_txtARCustomerDeliveryAddressTel.BOSFieldRelation = "";
            this.fld_txtARCustomerDeliveryAddressTel.BOSPrivilege = "";
            this.fld_txtARCustomerDeliveryAddressTel.BOSPropertyName = "Text";
            this.fld_txtARCustomerDeliveryAddressTel.Location = new System.Drawing.Point(215, 401);
            this.fld_txtARCustomerDeliveryAddressTel.Name = "fld_txtARCustomerDeliveryAddressTel";
            this.fld_txtARCustomerDeliveryAddressTel.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerDeliveryAddressTel.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerDeliveryAddressTel.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerDeliveryAddressTel.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerDeliveryAddressTel.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerDeliveryAddressTel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerDeliveryAddressTel.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerDeliveryAddressTel, true);
            this.fld_txtARCustomerDeliveryAddressTel.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARCustomerDeliveryAddressTel.TabIndex = 17;
            this.fld_txtARCustomerDeliveryAddressTel.Tag = "DC";
            // 
            // bosLabel41
            // 
            this.bosLabel41.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel41.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel41.Appearance.Options.UseBackColor = true;
            this.bosLabel41.Appearance.Options.UseForeColor = true;
            this.bosLabel41.BOSComment = "";
            this.bosLabel41.BOSDataMember = "";
            this.bosLabel41.BOSDataSource = "";
            this.bosLabel41.BOSDescription = null;
            this.bosLabel41.BOSError = null;
            this.bosLabel41.BOSFieldGroup = "";
            this.bosLabel41.BOSFieldRelation = "";
            this.bosLabel41.BOSPrivilege = "";
            this.bosLabel41.BOSPropertyName = null;
            this.bosLabel41.Location = new System.Drawing.Point(17, 271);
            this.bosLabel41.Name = "bosLabel41";
            this.bosLabel41.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel41, true);
            this.bosLabel41.Size = new System.Drawing.Size(61, 13);
            this.bosLabel41.TabIndex = 58;
            this.bosLabel41.Tag = "";
            this.bosLabel41.Text = "Quận/Huyện";
            // 
            // bosLabel26
            // 
            this.bosLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel26.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel26.Appearance.Options.UseBackColor = true;
            this.bosLabel26.Appearance.Options.UseFont = true;
            this.bosLabel26.Appearance.Options.UseForeColor = true;
            this.bosLabel26.BOSComment = "";
            this.bosLabel26.BOSDataMember = "";
            this.bosLabel26.BOSDataSource = "";
            this.bosLabel26.BOSDescription = null;
            this.bosLabel26.BOSError = null;
            this.bosLabel26.BOSFieldGroup = "";
            this.bosLabel26.BOSFieldRelation = "";
            this.bosLabel26.BOSPrivilege = "";
            this.bosLabel26.BOSPropertyName = null;
            this.bosLabel26.Location = new System.Drawing.Point(194, 404);
            this.bosLabel26.Name = "bosLabel26";
            this.bosLabel26.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel26, true);
            this.bosLabel26.Size = new System.Drawing.Size(15, 13);
            this.bosLabel26.TabIndex = 49;
            this.bosLabel26.Tag = "";
            this.bosLabel26.Text = "Tel";
            // 
            // bosLabel42
            // 
            this.bosLabel42.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel42.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel42.Appearance.Options.UseBackColor = true;
            this.bosLabel42.Appearance.Options.UseForeColor = true;
            this.bosLabel42.BOSComment = "";
            this.bosLabel42.BOSDataMember = "";
            this.bosLabel42.BOSDataSource = "";
            this.bosLabel42.BOSDescription = null;
            this.bosLabel42.BOSError = null;
            this.bosLabel42.BOSFieldGroup = "";
            this.bosLabel42.BOSFieldRelation = "";
            this.bosLabel42.BOSPrivilege = "";
            this.bosLabel42.BOSPropertyName = null;
            this.bosLabel42.Location = new System.Drawing.Point(233, 245);
            this.bosLabel42.Name = "bosLabel42";
            this.bosLabel42.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel42, true);
            this.bosLabel42.Size = new System.Drawing.Size(75, 13);
            this.bosLabel42.TabIndex = 60;
            this.bosLabel42.Tag = "";
            this.bosLabel42.Text = "Tỉnh/Thành phố";
            // 
            // fld_txtARCustomerInvoiceAddressTel
            // 
            this.fld_txtARCustomerInvoiceAddressTel.BOSComment = "";
            this.fld_txtARCustomerInvoiceAddressTel.BOSDataMember = "ARCustomerInvoiceAddressTel";
            this.fld_txtARCustomerInvoiceAddressTel.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerInvoiceAddressTel.BOSDescription = null;
            this.fld_txtARCustomerInvoiceAddressTel.BOSError = "";
            this.fld_txtARCustomerInvoiceAddressTel.BOSFieldGroup = "";
            this.fld_txtARCustomerInvoiceAddressTel.BOSFieldRelation = "";
            this.fld_txtARCustomerInvoiceAddressTel.BOSPrivilege = "";
            this.fld_txtARCustomerInvoiceAddressTel.BOSPropertyName = "Text";
            this.fld_txtARCustomerInvoiceAddressTel.Location = new System.Drawing.Point(215, 150);
            this.fld_txtARCustomerInvoiceAddressTel.Name = "fld_txtARCustomerInvoiceAddressTel";
            this.fld_txtARCustomerInvoiceAddressTel.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerInvoiceAddressTel.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerInvoiceAddressTel.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerInvoiceAddressTel.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerInvoiceAddressTel.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerInvoiceAddressTel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerInvoiceAddressTel.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerInvoiceAddressTel, true);
            this.fld_txtARCustomerInvoiceAddressTel.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARCustomerInvoiceAddressTel.TabIndex = 4;
            this.fld_txtARCustomerInvoiceAddressTel.Tag = "DC";
            // 
            // bosLabel25
            // 
            this.bosLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel25.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.Options.UseBackColor = true;
            this.bosLabel25.Appearance.Options.UseFont = true;
            this.bosLabel25.Appearance.Options.UseForeColor = true;
            this.bosLabel25.BOSComment = "";
            this.bosLabel25.BOSDataMember = "";
            this.bosLabel25.BOSDataSource = "";
            this.bosLabel25.BOSDescription = null;
            this.bosLabel25.BOSError = null;
            this.bosLabel25.BOSFieldGroup = "";
            this.bosLabel25.BOSFieldRelation = "";
            this.bosLabel25.BOSPrivilege = "";
            this.bosLabel25.BOSPropertyName = null;
            this.bosLabel25.Location = new System.Drawing.Point(194, 153);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel25, true);
            this.bosLabel25.Size = new System.Drawing.Size(15, 13);
            this.bosLabel25.TabIndex = 48;
            this.bosLabel25.Tag = "";
            this.bosLabel25.Text = "Tel";
            // 
            // fld_txtARCustomerPaymentAddressPostalCode
            // 
            this.fld_txtARCustomerPaymentAddressPostalCode.BOSComment = "";
            this.fld_txtARCustomerPaymentAddressPostalCode.BOSDataMember = "ARCustomerPaymentAddressPostalCode";
            this.fld_txtARCustomerPaymentAddressPostalCode.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerPaymentAddressPostalCode.BOSDescription = null;
            this.fld_txtARCustomerPaymentAddressPostalCode.BOSError = "";
            this.fld_txtARCustomerPaymentAddressPostalCode.BOSFieldGroup = "";
            this.fld_txtARCustomerPaymentAddressPostalCode.BOSFieldRelation = "";
            this.fld_txtARCustomerPaymentAddressPostalCode.BOSPrivilege = "";
            this.fld_txtARCustomerPaymentAddressPostalCode.BOSPropertyName = "Text";
            this.fld_txtARCustomerPaymentAddressPostalCode.Location = new System.Drawing.Point(384, 547);
            this.fld_txtARCustomerPaymentAddressPostalCode.Name = "fld_txtARCustomerPaymentAddressPostalCode";
            this.fld_txtARCustomerPaymentAddressPostalCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerPaymentAddressPostalCode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerPaymentAddressPostalCode.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerPaymentAddressPostalCode.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerPaymentAddressPostalCode.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerPaymentAddressPostalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerPaymentAddressPostalCode.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerPaymentAddressPostalCode, true);
            this.fld_txtARCustomerPaymentAddressPostalCode.Size = new System.Drawing.Size(79, 20);
            this.fld_txtARCustomerPaymentAddressPostalCode.TabIndex = 21;
            this.fld_txtARCustomerPaymentAddressPostalCode.Tag = "DC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = "";
            this.bosLabel8.BOSDataMember = "";
            this.bosLabel8.BOSDataSource = "";
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = "";
            this.bosLabel8.BOSFieldRelation = "";
            this.bosLabel8.BOSPrivilege = "";
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(337, 550);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, true);
            this.bosLabel8.Size = new System.Drawing.Size(41, 13);
            this.bosLabel8.TabIndex = 46;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Mã vùng";
            // 
            // fld_txtARCustomerDeliveryAddressPostalCode
            // 
            this.fld_txtARCustomerDeliveryAddressPostalCode.BOSComment = "";
            this.fld_txtARCustomerDeliveryAddressPostalCode.BOSDataMember = "ARCustomerDeliveryAddressPostalCode";
            this.fld_txtARCustomerDeliveryAddressPostalCode.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerDeliveryAddressPostalCode.BOSDescription = null;
            this.fld_txtARCustomerDeliveryAddressPostalCode.BOSError = "";
            this.fld_txtARCustomerDeliveryAddressPostalCode.BOSFieldGroup = "";
            this.fld_txtARCustomerDeliveryAddressPostalCode.BOSFieldRelation = "";
            this.fld_txtARCustomerDeliveryAddressPostalCode.BOSPrivilege = "";
            this.fld_txtARCustomerDeliveryAddressPostalCode.BOSPropertyName = "Text";
            this.fld_txtARCustomerDeliveryAddressPostalCode.Location = new System.Drawing.Point(385, 375);
            this.fld_txtARCustomerDeliveryAddressPostalCode.Name = "fld_txtARCustomerDeliveryAddressPostalCode";
            this.fld_txtARCustomerDeliveryAddressPostalCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerDeliveryAddressPostalCode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerDeliveryAddressPostalCode.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerDeliveryAddressPostalCode.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerDeliveryAddressPostalCode.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerDeliveryAddressPostalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerDeliveryAddressPostalCode.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerDeliveryAddressPostalCode, true);
            this.fld_txtARCustomerDeliveryAddressPostalCode.Size = new System.Drawing.Size(79, 20);
            this.fld_txtARCustomerDeliveryAddressPostalCode.TabIndex = 15;
            this.fld_txtARCustomerDeliveryAddressPostalCode.Tag = "DC";
            // 
            // fld_lblLabelDeliveryPostalCode
            // 
            this.fld_lblLabelDeliveryPostalCode.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabelDeliveryPostalCode.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabelDeliveryPostalCode.Appearance.Options.UseBackColor = true;
            this.fld_lblLabelDeliveryPostalCode.Appearance.Options.UseForeColor = true;
            this.fld_lblLabelDeliveryPostalCode.BOSComment = "";
            this.fld_lblLabelDeliveryPostalCode.BOSDataMember = "";
            this.fld_lblLabelDeliveryPostalCode.BOSDataSource = "";
            this.fld_lblLabelDeliveryPostalCode.BOSDescription = null;
            this.fld_lblLabelDeliveryPostalCode.BOSError = null;
            this.fld_lblLabelDeliveryPostalCode.BOSFieldGroup = "";
            this.fld_lblLabelDeliveryPostalCode.BOSFieldRelation = "";
            this.fld_lblLabelDeliveryPostalCode.BOSPrivilege = "";
            this.fld_lblLabelDeliveryPostalCode.BOSPropertyName = null;
            this.fld_lblLabelDeliveryPostalCode.Location = new System.Drawing.Point(338, 378);
            this.fld_lblLabelDeliveryPostalCode.Name = "fld_lblLabelDeliveryPostalCode";
            this.fld_lblLabelDeliveryPostalCode.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabelDeliveryPostalCode, true);
            this.fld_lblLabelDeliveryPostalCode.Size = new System.Drawing.Size(41, 13);
            this.fld_lblLabelDeliveryPostalCode.TabIndex = 44;
            this.fld_lblLabelDeliveryPostalCode.Tag = "";
            this.fld_lblLabelDeliveryPostalCode.Text = "Mã vùng";
            // 
            // fld_txtARCustomerInvoiceAddressPostalCode
            // 
            this.fld_txtARCustomerInvoiceAddressPostalCode.BOSComment = "";
            this.fld_txtARCustomerInvoiceAddressPostalCode.BOSDataMember = "ARCustomerInvoiceAddressPostalCode";
            this.fld_txtARCustomerInvoiceAddressPostalCode.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerInvoiceAddressPostalCode.BOSDescription = null;
            this.fld_txtARCustomerInvoiceAddressPostalCode.BOSError = "";
            this.fld_txtARCustomerInvoiceAddressPostalCode.BOSFieldGroup = "";
            this.fld_txtARCustomerInvoiceAddressPostalCode.BOSFieldRelation = "";
            this.fld_txtARCustomerInvoiceAddressPostalCode.BOSPrivilege = "";
            this.fld_txtARCustomerInvoiceAddressPostalCode.BOSPropertyName = "Text";
            this.fld_txtARCustomerInvoiceAddressPostalCode.Location = new System.Drawing.Point(385, 124);
            this.fld_txtARCustomerInvoiceAddressPostalCode.Name = "fld_txtARCustomerInvoiceAddressPostalCode";
            this.fld_txtARCustomerInvoiceAddressPostalCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerInvoiceAddressPostalCode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerInvoiceAddressPostalCode.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerInvoiceAddressPostalCode.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerInvoiceAddressPostalCode.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerInvoiceAddressPostalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerInvoiceAddressPostalCode.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerInvoiceAddressPostalCode, true);
            this.fld_txtARCustomerInvoiceAddressPostalCode.Size = new System.Drawing.Size(79, 20);
            this.fld_txtARCustomerInvoiceAddressPostalCode.TabIndex = 2;
            this.fld_txtARCustomerInvoiceAddressPostalCode.Tag = "DC";
            // 
            // fld_lblLabelInvoicePostalCode
            // 
            this.fld_lblLabelInvoicePostalCode.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabelInvoicePostalCode.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabelInvoicePostalCode.Appearance.Options.UseBackColor = true;
            this.fld_lblLabelInvoicePostalCode.Appearance.Options.UseForeColor = true;
            this.fld_lblLabelInvoicePostalCode.BOSComment = "";
            this.fld_lblLabelInvoicePostalCode.BOSDataMember = "";
            this.fld_lblLabelInvoicePostalCode.BOSDataSource = "";
            this.fld_lblLabelInvoicePostalCode.BOSDescription = null;
            this.fld_lblLabelInvoicePostalCode.BOSError = null;
            this.fld_lblLabelInvoicePostalCode.BOSFieldGroup = "";
            this.fld_lblLabelInvoicePostalCode.BOSFieldRelation = "";
            this.fld_lblLabelInvoicePostalCode.BOSPrivilege = "";
            this.fld_lblLabelInvoicePostalCode.BOSPropertyName = null;
            this.fld_lblLabelInvoicePostalCode.Location = new System.Drawing.Point(338, 127);
            this.fld_lblLabelInvoicePostalCode.Name = "fld_lblLabelInvoicePostalCode";
            this.fld_lblLabelInvoicePostalCode.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabelInvoicePostalCode, true);
            this.fld_lblLabelInvoicePostalCode.Size = new System.Drawing.Size(41, 13);
            this.fld_lblLabelInvoicePostalCode.TabIndex = 23;
            this.fld_lblLabelInvoicePostalCode.Tag = "";
            this.fld_lblLabelInvoicePostalCode.Text = "Mã vùng";
            // 
            // fld_bedGELocationName3
            // 
            this.fld_bedGELocationName3.BOSComment = null;
            this.fld_bedGELocationName3.BOSDataMember = "GELocationName3";
            this.fld_bedGELocationName3.BOSDataSource = "ARCustomers";
            this.fld_bedGELocationName3.BOSDescription = null;
            this.fld_bedGELocationName3.BOSError = null;
            this.fld_bedGELocationName3.BOSFieldGroup = null;
            this.fld_bedGELocationName3.BOSFieldRelation = null;
            this.fld_bedGELocationName3.BOSPrivilege = null;
            this.fld_bedGELocationName3.BOSPropertyName = "Text";
            this.fld_bedGELocationName3.Location = new System.Drawing.Point(79, 547);
            this.fld_bedGELocationName3.MenuManager = this.screenToolbar;
            this.fld_bedGELocationName3.Name = "fld_bedGELocationName3";
            this.fld_bedGELocationName3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedGELocationName3.Properties.ReadOnly = true;
            this.fld_bedGELocationName3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_bedGELocationName3, true);
            this.fld_bedGELocationName3.Size = new System.Drawing.Size(235, 20);
            this.fld_bedGELocationName3.TabIndex = 20;
            this.fld_bedGELocationName3.Tag = "DC";
            this.fld_bedGELocationName3.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedGELocationName3_ButtonClick);
            // 
            // fld_lblLabelPaymentPostalCode
            // 
            this.fld_lblLabelPaymentPostalCode.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabelPaymentPostalCode.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabelPaymentPostalCode.Appearance.Options.UseBackColor = true;
            this.fld_lblLabelPaymentPostalCode.Appearance.Options.UseForeColor = true;
            this.fld_lblLabelPaymentPostalCode.BOSComment = "";
            this.fld_lblLabelPaymentPostalCode.BOSDataMember = "";
            this.fld_lblLabelPaymentPostalCode.BOSDataSource = "";
            this.fld_lblLabelPaymentPostalCode.BOSDescription = null;
            this.fld_lblLabelPaymentPostalCode.BOSError = null;
            this.fld_lblLabelPaymentPostalCode.BOSFieldGroup = "";
            this.fld_lblLabelPaymentPostalCode.BOSFieldRelation = "";
            this.fld_lblLabelPaymentPostalCode.BOSPrivilege = "";
            this.fld_lblLabelPaymentPostalCode.BOSPropertyName = null;
            this.fld_lblLabelPaymentPostalCode.Location = new System.Drawing.Point(16, 550);
            this.fld_lblLabelPaymentPostalCode.Name = "fld_lblLabelPaymentPostalCode";
            this.fld_lblLabelPaymentPostalCode.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabelPaymentPostalCode, true);
            this.fld_lblLabelPaymentPostalCode.Size = new System.Drawing.Size(21, 13);
            this.fld_lblLabelPaymentPostalCode.TabIndex = 42;
            this.fld_lblLabelPaymentPostalCode.Tag = "";
            this.fld_lblLabelPaymentPostalCode.Text = "Vị trí";
            // 
            // fld_bedGELocationName2
            // 
            this.fld_bedGELocationName2.BOSComment = null;
            this.fld_bedGELocationName2.BOSDataMember = "GELocationName2";
            this.fld_bedGELocationName2.BOSDataSource = "ARCustomers";
            this.fld_bedGELocationName2.BOSDescription = null;
            this.fld_bedGELocationName2.BOSError = null;
            this.fld_bedGELocationName2.BOSFieldGroup = null;
            this.fld_bedGELocationName2.BOSFieldRelation = null;
            this.fld_bedGELocationName2.BOSPrivilege = null;
            this.fld_bedGELocationName2.BOSPropertyName = "Text";
            this.fld_bedGELocationName2.Location = new System.Drawing.Point(88, 375);
            this.fld_bedGELocationName2.MenuManager = this.screenToolbar;
            this.fld_bedGELocationName2.Name = "fld_bedGELocationName2";
            this.fld_bedGELocationName2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedGELocationName2.Properties.ReadOnly = true;
            this.fld_bedGELocationName2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_bedGELocationName2, true);
            this.fld_bedGELocationName2.Size = new System.Drawing.Size(227, 20);
            this.fld_bedGELocationName2.TabIndex = 14;
            this.fld_bedGELocationName2.Tag = "DC";
            this.fld_bedGELocationName2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedGELocationName2_ButtonClick);
            // 
            // bosLabel22
            // 
            this.bosLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.Options.UseBackColor = true;
            this.bosLabel22.Appearance.Options.UseForeColor = true;
            this.bosLabel22.BOSComment = "";
            this.bosLabel22.BOSDataMember = "";
            this.bosLabel22.BOSDataSource = "";
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = "";
            this.bosLabel22.BOSFieldRelation = "";
            this.bosLabel22.BOSPrivilege = "";
            this.bosLabel22.BOSPropertyName = null;
            this.bosLabel22.Location = new System.Drawing.Point(17, 378);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel22, true);
            this.bosLabel22.Size = new System.Drawing.Size(21, 13);
            this.bosLabel22.TabIndex = 40;
            this.bosLabel22.Tag = "";
            this.bosLabel22.Text = "Vị trí";
            // 
            // fld_bedGELocationName1
            // 
            this.fld_bedGELocationName1.BOSComment = null;
            this.fld_bedGELocationName1.BOSDataMember = "GELocationName1";
            this.fld_bedGELocationName1.BOSDataSource = "ARCustomers";
            this.fld_bedGELocationName1.BOSDescription = null;
            this.fld_bedGELocationName1.BOSError = null;
            this.fld_bedGELocationName1.BOSFieldGroup = null;
            this.fld_bedGELocationName1.BOSFieldRelation = null;
            this.fld_bedGELocationName1.BOSPrivilege = null;
            this.fld_bedGELocationName1.BOSPropertyName = "Text";
            this.fld_bedGELocationName1.Location = new System.Drawing.Point(80, 124);
            this.fld_bedGELocationName1.MenuManager = this.screenToolbar;
            this.fld_bedGELocationName1.Name = "fld_bedGELocationName1";
            this.fld_bedGELocationName1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedGELocationName1.Properties.ReadOnly = true;
            this.fld_bedGELocationName1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_bedGELocationName1, true);
            this.fld_bedGELocationName1.Size = new System.Drawing.Size(235, 20);
            this.fld_bedGELocationName1.TabIndex = 1;
            this.fld_bedGELocationName1.Tag = "DC";
            this.fld_bedGELocationName1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedGELocationName1_ButtonClick);
            // 
            // fld_txtARCustomerPaymentAddressFax
            // 
            this.fld_txtARCustomerPaymentAddressFax.BOSComment = "";
            this.fld_txtARCustomerPaymentAddressFax.BOSDataMember = "ARCustomerPaymentAddressFax";
            this.fld_txtARCustomerPaymentAddressFax.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerPaymentAddressFax.BOSDescription = null;
            this.fld_txtARCustomerPaymentAddressFax.BOSError = "";
            this.fld_txtARCustomerPaymentAddressFax.BOSFieldGroup = "";
            this.fld_txtARCustomerPaymentAddressFax.BOSFieldRelation = "";
            this.fld_txtARCustomerPaymentAddressFax.BOSPrivilege = "";
            this.fld_txtARCustomerPaymentAddressFax.BOSPropertyName = "Text";
            this.fld_txtARCustomerPaymentAddressFax.Location = new System.Drawing.Point(384, 573);
            this.fld_txtARCustomerPaymentAddressFax.Name = "fld_txtARCustomerPaymentAddressFax";
            this.fld_txtARCustomerPaymentAddressFax.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerPaymentAddressFax.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerPaymentAddressFax.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerPaymentAddressFax.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerPaymentAddressFax.Properties.Mask.EditMask = "\\d+";
            this.fld_txtARCustomerPaymentAddressFax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.fld_txtARCustomerPaymentAddressFax.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerPaymentAddressFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerPaymentAddressFax.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerPaymentAddressFax, true);
            this.fld_txtARCustomerPaymentAddressFax.Size = new System.Drawing.Size(79, 20);
            this.fld_txtARCustomerPaymentAddressFax.TabIndex = 24;
            this.fld_txtARCustomerPaymentAddressFax.Tag = "DC";
            // 
            // fld_txtARCustomerDeliveryAddressFax
            // 
            this.fld_txtARCustomerDeliveryAddressFax.BOSComment = "";
            this.fld_txtARCustomerDeliveryAddressFax.BOSDataMember = "ARCustomerDeliveryAddressFax";
            this.fld_txtARCustomerDeliveryAddressFax.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerDeliveryAddressFax.BOSDescription = null;
            this.fld_txtARCustomerDeliveryAddressFax.BOSError = "";
            this.fld_txtARCustomerDeliveryAddressFax.BOSFieldGroup = "";
            this.fld_txtARCustomerDeliveryAddressFax.BOSFieldRelation = "";
            this.fld_txtARCustomerDeliveryAddressFax.BOSPrivilege = "";
            this.fld_txtARCustomerDeliveryAddressFax.BOSPropertyName = "Text";
            this.fld_txtARCustomerDeliveryAddressFax.Location = new System.Drawing.Point(385, 401);
            this.fld_txtARCustomerDeliveryAddressFax.Name = "fld_txtARCustomerDeliveryAddressFax";
            this.fld_txtARCustomerDeliveryAddressFax.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerDeliveryAddressFax.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerDeliveryAddressFax.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerDeliveryAddressFax.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerDeliveryAddressFax.Properties.Mask.EditMask = "\\d+";
            this.fld_txtARCustomerDeliveryAddressFax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.fld_txtARCustomerDeliveryAddressFax.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerDeliveryAddressFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerDeliveryAddressFax.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerDeliveryAddressFax, true);
            this.fld_txtARCustomerDeliveryAddressFax.Size = new System.Drawing.Size(79, 20);
            this.fld_txtARCustomerDeliveryAddressFax.TabIndex = 18;
            this.fld_txtARCustomerDeliveryAddressFax.Tag = "DC";
            // 
            // fld_txtARCustomerInvoiceAddressFax
            // 
            this.fld_txtARCustomerInvoiceAddressFax.BOSComment = "";
            this.fld_txtARCustomerInvoiceAddressFax.BOSDataMember = "ARCustomerInvoiceAddressFax";
            this.fld_txtARCustomerInvoiceAddressFax.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerInvoiceAddressFax.BOSDescription = null;
            this.fld_txtARCustomerInvoiceAddressFax.BOSError = "";
            this.fld_txtARCustomerInvoiceAddressFax.BOSFieldGroup = "";
            this.fld_txtARCustomerInvoiceAddressFax.BOSFieldRelation = "";
            this.fld_txtARCustomerInvoiceAddressFax.BOSPrivilege = "";
            this.fld_txtARCustomerInvoiceAddressFax.BOSPropertyName = "Text";
            this.fld_txtARCustomerInvoiceAddressFax.Location = new System.Drawing.Point(385, 150);
            this.fld_txtARCustomerInvoiceAddressFax.Name = "fld_txtARCustomerInvoiceAddressFax";
            this.fld_txtARCustomerInvoiceAddressFax.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerInvoiceAddressFax.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerInvoiceAddressFax.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerInvoiceAddressFax.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerInvoiceAddressFax.Properties.Mask.EditMask = "\\d+";
            this.fld_txtARCustomerInvoiceAddressFax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.fld_txtARCustomerInvoiceAddressFax.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerInvoiceAddressFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerInvoiceAddressFax.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerInvoiceAddressFax, true);
            this.fld_txtARCustomerInvoiceAddressFax.Size = new System.Drawing.Size(79, 20);
            this.fld_txtARCustomerInvoiceAddressFax.TabIndex = 5;
            this.fld_txtARCustomerInvoiceAddressFax.Tag = "DC";
            // 
            // fld_lnkCopyPaymentAddress
            // 
            this.fld_lnkCopyPaymentAddress.EditValue = "Sao chép từ Thông tin trung gian bán hàng/ người mua hàng";
            this.fld_lnkCopyPaymentAddress.Location = new System.Drawing.Point(17, 599);
            this.fld_lnkCopyPaymentAddress.MenuManager = this.screenToolbar;
            this.fld_lnkCopyPaymentAddress.Name = "fld_lnkCopyPaymentAddress";
            this.fld_lnkCopyPaymentAddress.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkCopyPaymentAddress.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkCopyPaymentAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ScreenHelper.SetShowHelp(this.fld_lnkCopyPaymentAddress, true);
            this.fld_lnkCopyPaymentAddress.Size = new System.Drawing.Size(300, 18);
            this.fld_lnkCopyPaymentAddress.TabIndex = 27;
            this.fld_lnkCopyPaymentAddress.TabStop = false;
            this.fld_lnkCopyPaymentAddress.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkCopyPaymentAddress_OpenLink);
            // 
            // fld_txtARCustomerPaymentAddressTaxCode
            // 
            this.fld_txtARCustomerPaymentAddressTaxCode.BOSComment = "";
            this.fld_txtARCustomerPaymentAddressTaxCode.BOSDataMember = "ARCustomerPaymentAddressTaxCode";
            this.fld_txtARCustomerPaymentAddressTaxCode.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerPaymentAddressTaxCode.BOSDescription = null;
            this.fld_txtARCustomerPaymentAddressTaxCode.BOSError = "";
            this.fld_txtARCustomerPaymentAddressTaxCode.BOSFieldGroup = "";
            this.fld_txtARCustomerPaymentAddressTaxCode.BOSFieldRelation = "";
            this.fld_txtARCustomerPaymentAddressTaxCode.BOSPrivilege = "";
            this.fld_txtARCustomerPaymentAddressTaxCode.BOSPropertyName = "Text";
            this.fld_txtARCustomerPaymentAddressTaxCode.Location = new System.Drawing.Point(79, 573);
            this.fld_txtARCustomerPaymentAddressTaxCode.Name = "fld_txtARCustomerPaymentAddressTaxCode";
            this.fld_txtARCustomerPaymentAddressTaxCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerPaymentAddressTaxCode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerPaymentAddressTaxCode.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerPaymentAddressTaxCode.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerPaymentAddressTaxCode.Properties.Mask.EditMask = "\\d+";
            this.fld_txtARCustomerPaymentAddressTaxCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.fld_txtARCustomerPaymentAddressTaxCode.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerPaymentAddressTaxCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerPaymentAddressTaxCode.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerPaymentAddressTaxCode, true);
            this.fld_txtARCustomerPaymentAddressTaxCode.Size = new System.Drawing.Size(108, 20);
            this.fld_txtARCustomerPaymentAddressTaxCode.TabIndex = 22;
            this.fld_txtARCustomerPaymentAddressTaxCode.Tag = "DC";
            // 
            // fld_txtARCustomerDeliveryAddressTaxCode
            // 
            this.fld_txtARCustomerDeliveryAddressTaxCode.BOSComment = "";
            this.fld_txtARCustomerDeliveryAddressTaxCode.BOSDataMember = "ARCustomerDeliveryAddressTaxCode";
            this.fld_txtARCustomerDeliveryAddressTaxCode.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerDeliveryAddressTaxCode.BOSDescription = null;
            this.fld_txtARCustomerDeliveryAddressTaxCode.BOSError = "";
            this.fld_txtARCustomerDeliveryAddressTaxCode.BOSFieldGroup = "";
            this.fld_txtARCustomerDeliveryAddressTaxCode.BOSFieldRelation = "";
            this.fld_txtARCustomerDeliveryAddressTaxCode.BOSPrivilege = "";
            this.fld_txtARCustomerDeliveryAddressTaxCode.BOSPropertyName = "Text";
            this.fld_txtARCustomerDeliveryAddressTaxCode.Location = new System.Drawing.Point(88, 401);
            this.fld_txtARCustomerDeliveryAddressTaxCode.Name = "fld_txtARCustomerDeliveryAddressTaxCode";
            this.fld_txtARCustomerDeliveryAddressTaxCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerDeliveryAddressTaxCode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerDeliveryAddressTaxCode.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerDeliveryAddressTaxCode.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerDeliveryAddressTaxCode.Properties.Mask.EditMask = "\\d+";
            this.fld_txtARCustomerDeliveryAddressTaxCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.fld_txtARCustomerDeliveryAddressTaxCode.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerDeliveryAddressTaxCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerDeliveryAddressTaxCode.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerDeliveryAddressTaxCode, true);
            this.fld_txtARCustomerDeliveryAddressTaxCode.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARCustomerDeliveryAddressTaxCode.TabIndex = 16;
            this.fld_txtARCustomerDeliveryAddressTaxCode.Tag = "DC";
            // 
            // fld_txtARCustomerInvoiceAddressTaxCode
            // 
            this.fld_txtARCustomerInvoiceAddressTaxCode.BOSComment = "";
            this.fld_txtARCustomerInvoiceAddressTaxCode.BOSDataMember = "ARCustomerInvoiceAddressTaxCode";
            this.fld_txtARCustomerInvoiceAddressTaxCode.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerInvoiceAddressTaxCode.BOSDescription = null;
            this.fld_txtARCustomerInvoiceAddressTaxCode.BOSError = "";
            this.fld_txtARCustomerInvoiceAddressTaxCode.BOSFieldGroup = "";
            this.fld_txtARCustomerInvoiceAddressTaxCode.BOSFieldRelation = "";
            this.fld_txtARCustomerInvoiceAddressTaxCode.BOSPrivilege = "";
            this.fld_txtARCustomerInvoiceAddressTaxCode.BOSPropertyName = "Text";
            this.fld_txtARCustomerInvoiceAddressTaxCode.Location = new System.Drawing.Point(80, 150);
            this.fld_txtARCustomerInvoiceAddressTaxCode.Name = "fld_txtARCustomerInvoiceAddressTaxCode";
            this.fld_txtARCustomerInvoiceAddressTaxCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerInvoiceAddressTaxCode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerInvoiceAddressTaxCode.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerInvoiceAddressTaxCode.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerInvoiceAddressTaxCode.Properties.Mask.EditMask = "\\d+";
            this.fld_txtARCustomerInvoiceAddressTaxCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.fld_txtARCustomerInvoiceAddressTaxCode.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerInvoiceAddressTaxCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerInvoiceAddressTaxCode.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerInvoiceAddressTaxCode, true);
            this.fld_txtARCustomerInvoiceAddressTaxCode.Size = new System.Drawing.Size(108, 20);
            this.fld_txtARCustomerInvoiceAddressTaxCode.TabIndex = 3;
            this.fld_txtARCustomerInvoiceAddressTaxCode.Tag = "DC";
            // 
            // bosLabel24
            // 
            this.bosLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel24.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.Options.UseBackColor = true;
            this.bosLabel24.Appearance.Options.UseFont = true;
            this.bosLabel24.Appearance.Options.UseForeColor = true;
            this.bosLabel24.BOSComment = "";
            this.bosLabel24.BOSDataMember = "";
            this.bosLabel24.BOSDataSource = "";
            this.bosLabel24.BOSDescription = null;
            this.bosLabel24.BOSError = null;
            this.bosLabel24.BOSFieldGroup = "";
            this.bosLabel24.BOSFieldRelation = "";
            this.bosLabel24.BOSPrivilege = "";
            this.bosLabel24.BOSPropertyName = null;
            this.bosLabel24.Location = new System.Drawing.Point(16, 576);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel24, true);
            this.bosLabel24.Size = new System.Drawing.Size(45, 13);
            this.bosLabel24.TabIndex = 6;
            this.bosLabel24.Tag = "";
            this.bosLabel24.Text = "Tax code";
            // 
            // fld_lnkCopyInvoiceAddress
            // 
            this.fld_lnkCopyInvoiceAddress.EditValue = "Sao chép từ Thông tin trung gian bán hàng/ người mua hàng";
            this.fld_lnkCopyInvoiceAddress.Location = new System.Drawing.Point(17, 176);
            this.fld_lnkCopyInvoiceAddress.Name = "fld_lnkCopyInvoiceAddress";
            this.fld_lnkCopyInvoiceAddress.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkCopyInvoiceAddress.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkCopyInvoiceAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ScreenHelper.SetShowHelp(this.fld_lnkCopyInvoiceAddress, true);
            this.fld_lnkCopyInvoiceAddress.Size = new System.Drawing.Size(300, 18);
            this.fld_lnkCopyInvoiceAddress.TabIndex = 6;
            this.fld_lnkCopyInvoiceAddress.TabStop = false;
            this.fld_lnkCopyInvoiceAddress.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkCopyInvoiceAddress_OpenLink);
            // 
            // bosLabel23
            // 
            this.bosLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel23.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.Options.UseBackColor = true;
            this.bosLabel23.Appearance.Options.UseFont = true;
            this.bosLabel23.Appearance.Options.UseForeColor = true;
            this.bosLabel23.BOSComment = "";
            this.bosLabel23.BOSDataMember = "";
            this.bosLabel23.BOSDataSource = "";
            this.bosLabel23.BOSDescription = null;
            this.bosLabel23.BOSError = null;
            this.bosLabel23.BOSFieldGroup = "";
            this.bosLabel23.BOSFieldRelation = "";
            this.bosLabel23.BOSPrivilege = "";
            this.bosLabel23.BOSPropertyName = null;
            this.bosLabel23.Location = new System.Drawing.Point(17, 404);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel23, true);
            this.bosLabel23.Size = new System.Drawing.Size(45, 13);
            this.bosLabel23.TabIndex = 6;
            this.bosLabel23.Tag = "";
            this.bosLabel23.Text = "Tax code";
            // 
            // fld_lnkCopyDeliveryAddress
            // 
            this.fld_lnkCopyDeliveryAddress.EditValue = "Sao chép từ Thông tin trung gian bán hàng/ người mua hàng";
            this.fld_lnkCopyDeliveryAddress.Location = new System.Drawing.Point(17, 423);
            this.fld_lnkCopyDeliveryAddress.MenuManager = this.screenToolbar;
            this.fld_lnkCopyDeliveryAddress.Name = "fld_lnkCopyDeliveryAddress";
            this.fld_lnkCopyDeliveryAddress.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkCopyDeliveryAddress.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkCopyDeliveryAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ScreenHelper.SetShowHelp(this.fld_lnkCopyDeliveryAddress, true);
            this.fld_lnkCopyDeliveryAddress.Size = new System.Drawing.Size(300, 18);
            this.fld_lnkCopyDeliveryAddress.TabIndex = 20;
            this.fld_lnkCopyDeliveryAddress.TabStop = false;
            this.fld_lnkCopyDeliveryAddress.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkCopyDeliveryAddress_OpenLink);
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(17, 153);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(45, 13);
            this.bosLabel2.TabIndex = 6;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Tax code";
            // 
            // fld_txtARCustomerPaymentAddressLine1
            // 
            this.fld_txtARCustomerPaymentAddressLine1.BOSComment = "";
            this.fld_txtARCustomerPaymentAddressLine1.BOSDataMember = "ARCustomerPaymentAddressLine1";
            this.fld_txtARCustomerPaymentAddressLine1.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerPaymentAddressLine1.BOSDescription = null;
            this.fld_txtARCustomerPaymentAddressLine1.BOSError = "";
            this.fld_txtARCustomerPaymentAddressLine1.BOSFieldGroup = "";
            this.fld_txtARCustomerPaymentAddressLine1.BOSFieldRelation = "";
            this.fld_txtARCustomerPaymentAddressLine1.BOSPrivilege = "";
            this.fld_txtARCustomerPaymentAddressLine1.BOSPropertyName = "Text";
            this.fld_txtARCustomerPaymentAddressLine1.Location = new System.Drawing.Point(79, 495);
            this.fld_txtARCustomerPaymentAddressLine1.Name = "fld_txtARCustomerPaymentAddressLine1";
            this.fld_txtARCustomerPaymentAddressLine1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerPaymentAddressLine1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerPaymentAddressLine1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerPaymentAddressLine1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerPaymentAddressLine1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerPaymentAddressLine1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerPaymentAddressLine1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerPaymentAddressLine1, true);
            this.fld_txtARCustomerPaymentAddressLine1.Size = new System.Drawing.Size(384, 20);
            this.fld_txtARCustomerPaymentAddressLine1.TabIndex = 19;
            this.fld_txtARCustomerPaymentAddressLine1.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = "";
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = "";
            this.bosLabel5.BOSPrivilege = "";
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(16, 498);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(32, 13);
            this.bosLabel5.TabIndex = 27;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Địa chỉ";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLabel4.Appearance.Options.UseFont = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(5, 448);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(248, 13);
            this.bosLabel4.TabIndex = 25;
            this.bosLabel4.Text = "Thông tin thông báo hàng đến (Notify Party)";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "";
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(337, 576);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(30, 13);
            this.bosLabel3.TabIndex = 10;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Số fax";
            // 
            // bosLine3
            // 
            this.bosLine3.BOSComment = null;
            this.bosLine3.BOSDataMember = null;
            this.bosLine3.BOSDataSource = null;
            this.bosLine3.BOSDescription = null;
            this.bosLine3.BOSError = null;
            this.bosLine3.BOSFieldGroup = null;
            this.bosLine3.BOSFieldRelation = null;
            this.bosLine3.BOSPrivilege = null;
            this.bosLine3.BOSPropertyName = null;
            this.bosLine3.Location = new System.Drawing.Point(94, 453);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine3, true);
            this.bosLine3.Size = new System.Drawing.Size(377, 5);
            this.bosLine3.TabIndex = 26;
            this.bosLine3.TabStop = false;
            this.bosLine3.Text = "bosLine3";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = "";
            this.bosLabel6.BOSDataMember = "";
            this.bosLabel6.BOSDataSource = "";
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = "";
            this.bosLabel6.BOSFieldRelation = "";
            this.bosLabel6.BOSPrivilege = "";
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(338, 404);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(30, 13);
            this.bosLabel6.TabIndex = 10;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Số fax";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLabel7.Appearance.Options.UseFont = true;
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(5, 200);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(210, 13);
            this.bosLabel7.TabIndex = 12;
            this.bosLabel7.Text = "Thông tin bên nhận hàng (Consignee)";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseFont = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = "";
            this.bosLabel9.BOSDataMember = "";
            this.bosLabel9.BOSDataSource = "";
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = "";
            this.bosLabel9.BOSFieldRelation = "";
            this.bosLabel9.BOSPrivilege = "";
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(338, 153);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, true);
            this.bosLabel9.Size = new System.Drawing.Size(30, 13);
            this.bosLabel9.TabIndex = 10;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Số fax";
            // 
            // bosLine2
            // 
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Location = new System.Drawing.Point(111, 205);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine2, true);
            this.bosLine2.Size = new System.Drawing.Size(360, 5);
            this.bosLine2.TabIndex = 13;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "bosLine2";
            // 
            // bosLabel28
            // 
            this.bosLabel28.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLabel28.Appearance.Options.UseFont = true;
            this.bosLabel28.BOSComment = null;
            this.bosLabel28.BOSDataMember = null;
            this.bosLabel28.BOSDataSource = null;
            this.bosLabel28.BOSDescription = null;
            this.bosLabel28.BOSError = null;
            this.bosLabel28.BOSFieldGroup = null;
            this.bosLabel28.BOSFieldRelation = null;
            this.bosLabel28.BOSPrivilege = null;
            this.bosLabel28.BOSPropertyName = null;
            this.bosLabel28.Location = new System.Drawing.Point(5, 28);
            this.bosLabel28.Name = "bosLabel28";
            this.bosLabel28.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel28, true);
            this.bosLabel28.Size = new System.Drawing.Size(119, 13);
            this.bosLabel28.TabIndex = 0;
            this.bosLabel28.Text = "Địa chỉ giao chứng từ";
            // 
            // bosLine1
            // 
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Location = new System.Drawing.Point(129, 33);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine1, true);
            this.bosLine1.Size = new System.Drawing.Size(340, 5);
            this.bosLine1.TabIndex = 1;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "bosLine1";
            // 
            // fld_txtARCustomerDeliveryAddressLine1
            // 
            this.fld_txtARCustomerDeliveryAddressLine1.BOSComment = "";
            this.fld_txtARCustomerDeliveryAddressLine1.BOSDataMember = "ARCustomerDeliveryAddressLine1";
            this.fld_txtARCustomerDeliveryAddressLine1.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerDeliveryAddressLine1.BOSDescription = null;
            this.fld_txtARCustomerDeliveryAddressLine1.BOSError = "";
            this.fld_txtARCustomerDeliveryAddressLine1.BOSFieldGroup = "";
            this.fld_txtARCustomerDeliveryAddressLine1.BOSFieldRelation = "";
            this.fld_txtARCustomerDeliveryAddressLine1.BOSPrivilege = "";
            this.fld_txtARCustomerDeliveryAddressLine1.BOSPropertyName = "Text";
            this.fld_txtARCustomerDeliveryAddressLine1.Location = new System.Drawing.Point(88, 320);
            this.fld_txtARCustomerDeliveryAddressLine1.Name = "fld_txtARCustomerDeliveryAddressLine1";
            this.fld_txtARCustomerDeliveryAddressLine1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerDeliveryAddressLine1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerDeliveryAddressLine1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerDeliveryAddressLine1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerDeliveryAddressLine1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerDeliveryAddressLine1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerDeliveryAddressLine1, true);
            this.fld_txtARCustomerDeliveryAddressLine1.Size = new System.Drawing.Size(376, 20);
            this.fld_txtARCustomerDeliveryAddressLine1.TabIndex = 13;
            this.fld_txtARCustomerDeliveryAddressLine1.Tag = "DC";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = "";
            this.fld_lblLabel6.BOSDataMember = "";
            this.fld_lblLabel6.BOSDataSource = "";
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = "";
            this.fld_lblLabel6.BOSFieldRelation = "";
            this.fld_lblLabel6.BOSPrivilege = "";
            this.fld_lblLabel6.BOSPropertyName = null;
            this.fld_lblLabel6.Location = new System.Drawing.Point(17, 323);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel6, true);
            this.fld_lblLabel6.Size = new System.Drawing.Size(32, 13);
            this.fld_lblLabel6.TabIndex = 14;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Địa chỉ";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = "";
            this.fld_lblLabel.BOSDataMember = "";
            this.fld_lblLabel.BOSDataSource = "";
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = "";
            this.fld_lblLabel.BOSFieldRelation = "";
            this.fld_lblLabel.BOSPrivilege = "";
            this.fld_lblLabel.BOSPropertyName = null;
            this.fld_lblLabel.Location = new System.Drawing.Point(17, 75);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel, true);
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 2;
            this.fld_lblLabel.Tag = "";
            this.fld_lblLabel.Text = "Địa chỉ GPKD";
            // 
            // fld_txtARCustomerInvoiceAddressLine1
            // 
            this.fld_txtARCustomerInvoiceAddressLine1.BOSComment = "";
            this.fld_txtARCustomerInvoiceAddressLine1.BOSDataMember = "ARCustomerInvoiceAddressLine1";
            this.fld_txtARCustomerInvoiceAddressLine1.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerInvoiceAddressLine1.BOSDescription = null;
            this.fld_txtARCustomerInvoiceAddressLine1.BOSError = "";
            this.fld_txtARCustomerInvoiceAddressLine1.BOSFieldGroup = "";
            this.fld_txtARCustomerInvoiceAddressLine1.BOSFieldRelation = "";
            this.fld_txtARCustomerInvoiceAddressLine1.BOSPrivilege = "";
            this.fld_txtARCustomerInvoiceAddressLine1.BOSPropertyName = "Text";
            this.fld_txtARCustomerInvoiceAddressLine1.Location = new System.Drawing.Point(80, 72);
            this.fld_txtARCustomerInvoiceAddressLine1.Name = "fld_txtARCustomerInvoiceAddressLine1";
            this.fld_txtARCustomerInvoiceAddressLine1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerInvoiceAddressLine1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerInvoiceAddressLine1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerInvoiceAddressLine1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerInvoiceAddressLine1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerInvoiceAddressLine1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerInvoiceAddressLine1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerInvoiceAddressLine1, true);
            this.fld_txtARCustomerInvoiceAddressLine1.Size = new System.Drawing.Size(384, 20);
            this.fld_txtARCustomerInvoiceAddressLine1.TabIndex = 0;
            this.fld_txtARCustomerInvoiceAddressLine1.Tag = "DC";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl1.Appearance.Options.UseBackColor = true;
            this.bosGroupControl1.BOSComment = "";
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = "";
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = "";
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ADFengShuisColorID);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ADFengShuisGenaralID);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ADFengShuisDirectionID);
            this.bosGroupControl1.Controls.Add(this.bosLabel19);
            this.bosGroupControl1.Controls.Add(this.bosLabel45);
            this.bosGroupControl1.Controls.Add(this.bosLabel46);
            this.bosGroupControl1.Location = new System.Drawing.Point(13, 639);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(482, 87);
            this.bosGroupControl1.TabIndex = 6;
            this.bosGroupControl1.Text = "Thông tin phong thủy";
            this.bosGroupControl1.Visible = false;
            // 
            // fld_lkeFK_ADFengShuisColorID
            // 
            this.fld_lkeFK_ADFengShuisColorID.BOSAllowAddNew = false;
            this.fld_lkeFK_ADFengShuisColorID.BOSAllowDummy = false;
            this.fld_lkeFK_ADFengShuisColorID.BOSComment = "";
            this.fld_lkeFK_ADFengShuisColorID.BOSDataMember = "FK_ADFengShuisColorID";
            this.fld_lkeFK_ADFengShuisColorID.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_ADFengShuisColorID.BOSDescription = null;
            this.fld_lkeFK_ADFengShuisColorID.BOSError = "";
            this.fld_lkeFK_ADFengShuisColorID.BOSFieldGroup = "";
            this.fld_lkeFK_ADFengShuisColorID.BOSFieldParent = "";
            this.fld_lkeFK_ADFengShuisColorID.BOSFieldRelation = "";
            this.fld_lkeFK_ADFengShuisColorID.BOSPrivilege = "";
            this.fld_lkeFK_ADFengShuisColorID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ADFengShuisColorID.BOSSelectType = "";
            this.fld_lkeFK_ADFengShuisColorID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ADFengShuisColorID.CurrentDisplayText = "";
            this.fld_lkeFK_ADFengShuisColorID.Location = new System.Drawing.Point(339, 27);
            this.fld_lkeFK_ADFengShuisColorID.Name = "fld_lkeFK_ADFengShuisColorID";
            this.fld_lkeFK_ADFengShuisColorID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ADFengShuisColorID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ADFengShuisColorID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ADFengShuisColorID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ADFengShuisColorID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ADFengShuisColorID.Properties.ColumnName = null;
            this.fld_lkeFK_ADFengShuisColorID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADFengShuisColorLife", "Mệnh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADFengShuisColorMutual", "Tương sinh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADFengShuisColorHarmony", "Hòa hợp"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADFengShuisColorFightDown", "Khắc chế"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADFengShuisColorConflict", "Bị khắc")});
            this.fld_lkeFK_ADFengShuisColorID.Properties.DisplayMember = "ADFengShuisColorMutual";
            this.fld_lkeFK_ADFengShuisColorID.Properties.NullText = "";
            this.fld_lkeFK_ADFengShuisColorID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ADFengShuisColorID.Properties.ValueMember = "ADFengShuisColorID";
            this.fld_lkeFK_ADFengShuisColorID.Screen = null;
            this.fld_lkeFK_ADFengShuisColorID.Size = new System.Drawing.Size(124, 20);
            this.fld_lkeFK_ADFengShuisColorID.TabIndex = 4;
            this.fld_lkeFK_ADFengShuisColorID.Tag = "DC";
            // 
            // fld_lkeFK_ADFengShuisGenaralID
            // 
            this.fld_lkeFK_ADFengShuisGenaralID.BOSAllowAddNew = false;
            this.fld_lkeFK_ADFengShuisGenaralID.BOSAllowDummy = false;
            this.fld_lkeFK_ADFengShuisGenaralID.BOSComment = "";
            this.fld_lkeFK_ADFengShuisGenaralID.BOSDataMember = "FK_ADFengShuisGenaralID";
            this.fld_lkeFK_ADFengShuisGenaralID.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_ADFengShuisGenaralID.BOSDescription = null;
            this.fld_lkeFK_ADFengShuisGenaralID.BOSError = "";
            this.fld_lkeFK_ADFengShuisGenaralID.BOSFieldGroup = "";
            this.fld_lkeFK_ADFengShuisGenaralID.BOSFieldParent = "";
            this.fld_lkeFK_ADFengShuisGenaralID.BOSFieldRelation = "";
            this.fld_lkeFK_ADFengShuisGenaralID.BOSPrivilege = "";
            this.fld_lkeFK_ADFengShuisGenaralID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ADFengShuisGenaralID.BOSSelectType = "";
            this.fld_lkeFK_ADFengShuisGenaralID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ADFengShuisGenaralID.CurrentDisplayText = "";
            this.fld_lkeFK_ADFengShuisGenaralID.Location = new System.Drawing.Point(97, 27);
            this.fld_lkeFK_ADFengShuisGenaralID.Name = "fld_lkeFK_ADFengShuisGenaralID";
            this.fld_lkeFK_ADFengShuisGenaralID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ADFengShuisGenaralID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ADFengShuisGenaralID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ADFengShuisGenaralID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ADFengShuisGenaralID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ADFengShuisGenaralID.Properties.ColumnName = null;
            this.fld_lkeFK_ADFengShuisGenaralID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADFengShuisGenaralBirthdate", "Năm sinh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADFengShuisGenaralFiveBasicElements", "Ngũ hành"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADFengShuisGenaralDescription", "Giải thích"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADFengShuisGenaralMale", "Mệnh nam"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADFengShuisGenaralFemale", "Mệnh nữ")});
            this.fld_lkeFK_ADFengShuisGenaralID.Properties.DisplayMember = "ADFengShuisGenaralBirthdate";
            this.fld_lkeFK_ADFengShuisGenaralID.Properties.NullText = "";
            this.fld_lkeFK_ADFengShuisGenaralID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ADFengShuisGenaralID.Properties.ValidateOnEnterKey = true;
            this.fld_lkeFK_ADFengShuisGenaralID.Properties.ValueMember = "ADFengShuisGenaralID";
            this.fld_lkeFK_ADFengShuisGenaralID.Screen = null;
            this.fld_lkeFK_ADFengShuisGenaralID.Size = new System.Drawing.Size(124, 20);
            this.fld_lkeFK_ADFengShuisGenaralID.TabIndex = 3;
            this.fld_lkeFK_ADFengShuisGenaralID.Tag = "DC";
            // 
            // fld_lkeFK_ADFengShuisDirectionID
            // 
            this.fld_lkeFK_ADFengShuisDirectionID.BOSAllowAddNew = false;
            this.fld_lkeFK_ADFengShuisDirectionID.BOSAllowDummy = false;
            this.fld_lkeFK_ADFengShuisDirectionID.BOSComment = "";
            this.fld_lkeFK_ADFengShuisDirectionID.BOSDataMember = "FK_ADFengShuisDirectionID";
            this.fld_lkeFK_ADFengShuisDirectionID.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_ADFengShuisDirectionID.BOSDescription = null;
            this.fld_lkeFK_ADFengShuisDirectionID.BOSError = "";
            this.fld_lkeFK_ADFengShuisDirectionID.BOSFieldGroup = "";
            this.fld_lkeFK_ADFengShuisDirectionID.BOSFieldParent = "";
            this.fld_lkeFK_ADFengShuisDirectionID.BOSFieldRelation = "";
            this.fld_lkeFK_ADFengShuisDirectionID.BOSPrivilege = "";
            this.fld_lkeFK_ADFengShuisDirectionID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ADFengShuisDirectionID.BOSSelectType = "";
            this.fld_lkeFK_ADFengShuisDirectionID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ADFengShuisDirectionID.CurrentDisplayText = "";
            this.fld_lkeFK_ADFengShuisDirectionID.Location = new System.Drawing.Point(97, 52);
            this.fld_lkeFK_ADFengShuisDirectionID.Name = "fld_lkeFK_ADFengShuisDirectionID";
            this.fld_lkeFK_ADFengShuisDirectionID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ADFengShuisDirectionID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ADFengShuisDirectionID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ADFengShuisDirectionID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ADFengShuisDirectionID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ADFengShuisDirectionID.Properties.ColumnName = null;
            this.fld_lkeFK_ADFengShuisDirectionID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADFengShuisDirectionMain", "Hướng chính"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADFengShuisDirectionBowLife", "Cung mệnh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADFengShuisDirectionEast", "Đông"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADFengShuisDirectionWest", "Tây"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADFengShuisDirectionSouth", "Nam"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADFengShuisDirectionNorth", "Bắc"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADFengShuisDirectionSouthEast", "Đông Nam"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADFengShuisDirectionSouthWest", "Tây Nam"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADFengShuisDirectionNorthEast", "Đông Bắc"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADFengShuisDirectionNorthWest", "Tây Bắc")});
            this.fld_lkeFK_ADFengShuisDirectionID.Properties.DisplayMember = "ADFengShuisDirectionMain";
            this.fld_lkeFK_ADFengShuisDirectionID.Properties.NullText = "";
            this.fld_lkeFK_ADFengShuisDirectionID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ADFengShuisDirectionID.Properties.ValueMember = "ADFengShuisDirectionID";
            this.fld_lkeFK_ADFengShuisDirectionID.Screen = null;
            this.fld_lkeFK_ADFengShuisDirectionID.Size = new System.Drawing.Size(124, 20);
            this.fld_lkeFK_ADFengShuisDirectionID.TabIndex = 5;
            this.fld_lkeFK_ADFengShuisDirectionID.Tag = "DC";
            // 
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel19.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.Options.UseBackColor = true;
            this.bosLabel19.Appearance.Options.UseFont = true;
            this.bosLabel19.Appearance.Options.UseForeColor = true;
            this.bosLabel19.BOSComment = "";
            this.bosLabel19.BOSDataMember = "";
            this.bosLabel19.BOSDataSource = "";
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = "";
            this.bosLabel19.BOSFieldRelation = "";
            this.bosLabel19.BOSPrivilege = "";
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(260, 30);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(21, 13);
            this.bosLabel19.TabIndex = 3;
            this.bosLabel19.Tag = "";
            this.bosLabel19.Text = "Màu";
            // 
            // bosLabel45
            // 
            this.bosLabel45.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel45.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel45.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel45.Appearance.Options.UseBackColor = true;
            this.bosLabel45.Appearance.Options.UseFont = true;
            this.bosLabel45.Appearance.Options.UseForeColor = true;
            this.bosLabel45.BOSComment = "";
            this.bosLabel45.BOSDataMember = "";
            this.bosLabel45.BOSDataSource = "";
            this.bosLabel45.BOSDescription = null;
            this.bosLabel45.BOSError = null;
            this.bosLabel45.BOSFieldGroup = "";
            this.bosLabel45.BOSFieldRelation = "";
            this.bosLabel45.BOSPrivilege = "";
            this.bosLabel45.BOSPropertyName = null;
            this.bosLabel45.Location = new System.Drawing.Point(12, 30);
            this.bosLabel45.Name = "bosLabel45";
            this.bosLabel45.Screen = null;
            this.bosLabel45.Size = new System.Drawing.Size(52, 13);
            this.bosLabel45.TabIndex = 0;
            this.bosLabel45.Tag = "";
            this.bosLabel45.Text = "Tổng quan";
            // 
            // bosLabel46
            // 
            this.bosLabel46.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel46.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel46.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel46.Appearance.Options.UseBackColor = true;
            this.bosLabel46.Appearance.Options.UseFont = true;
            this.bosLabel46.Appearance.Options.UseForeColor = true;
            this.bosLabel46.BOSComment = "";
            this.bosLabel46.BOSDataMember = "";
            this.bosLabel46.BOSDataSource = "";
            this.bosLabel46.BOSDescription = null;
            this.bosLabel46.BOSError = null;
            this.bosLabel46.BOSFieldGroup = "";
            this.bosLabel46.BOSFieldRelation = "";
            this.bosLabel46.BOSPrivilege = "";
            this.bosLabel46.BOSPropertyName = null;
            this.bosLabel46.Location = new System.Drawing.Point(12, 55);
            this.bosLabel46.Name = "bosLabel46";
            this.bosLabel46.Screen = null;
            this.bosLabel46.Size = new System.Drawing.Size(32, 13);
            this.bosLabel46.TabIndex = 2;
            this.bosLabel46.Tag = "";
            this.bosLabel46.Text = "Hướng";
            // 
            // DMCU100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1204, 868);
            this.Controls.Add(this.fld_grcGroupControl1);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Controls.Add(this.bosGroupControl1);
            this.Controls.Add(this.fld_grcGroupControl6);
            this.Controls.Add(this.fld_grcGroupControl2);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMCU100.IconOptions.Icon")));
            this.Name = "DMCU100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.fld_grcGroupControl2, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl6, 0);
            this.Controls.SetChildIndex(this.bosGroupControl1, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerName2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactCellPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactEmail1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactWebsite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            this.bosPanel3.ResumeLayout(false);
            this.bosPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerBusinessTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerResourceID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerTypeAccountConfigID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountDepositID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountSaleID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountPurchaseID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARCustomerDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkIsBuyingLocked.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkARCustomerActiveCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerTypeCombo.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCustomerStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCustomerStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeManagementID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerTaxNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerName3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerName21.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl6)).EndInit();
            this.fld_grcGroupControl6.ResumeLayout(false);
            this.fld_grcGroupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEPaymentTermID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerAvailableCredit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerOwing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARPriceLevelID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerCreditLimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARPaymentMethodCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl2)).EndInit();
            this.fld_grcGroupControl2.ResumeLayout(false);
            this.fld_grcGroupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerSex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedGELocationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactAddressLine1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            this.fld_grcGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentAddressEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerDeliveryAddressEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentContactName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerInvoiceContactName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerDeliveryHomeNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEDeliveryCountryID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEDeliveryWardID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEDeliveryStreetID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerDeliveryContactName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentAddressTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEDeliveryStateProvinceID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEDeliveryDistrictID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerDeliveryAddressTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerInvoiceAddressTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentAddressPostalCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerDeliveryAddressPostalCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerInvoiceAddressPostalCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedGELocationName3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedGELocationName2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedGELocationName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentAddressFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerDeliveryAddressFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerInvoiceAddressFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkCopyPaymentAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentAddressTaxCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerDeliveryAddressTaxCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerInvoiceAddressTaxCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkCopyInvoiceAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkCopyDeliveryAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentAddressLine1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerDeliveryAddressLine1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerInvoiceAddressLine1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ADFengShuisColorID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ADFengShuisGenaralID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ADFengShuisDirectionID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSTextBox fld_txtARCustomerAvailableCredit;
        private BOSComponent.BOSTextBox fld_txtARCustomerOwing;
        private BOSComponent.BOSLine fld_Line1;
        private BOSComponent.BOSLabel fld_lblLabel32;
        private BOSComponent.BOSLabel fld_lblLabel30;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSTextBox fld_txtARCustomerContactAddressLine1;
        private BOSComponent.BOSButtonEdit fld_bedGELocationName;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSCheckEdit fld_chkIsBuyingLocked;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSLabel fld_lblLabel102;
        private BOSComponent.BOSLookupEdit fld_lkeARCustomerTypeCombo;
        private BOSComponent.BOSCheckEdit fld_chkARCustomerActiveCheck;
        private BOSComponent.BOSMemoEdit fld_medARCustomerDesc;
        private BOSComponent.BOSPanel bosPanel3;
        private CollapsibleGroupBox collapsibleGroupBox1;
        private BOSComponent.BOSTextBox fld_txtARCustomerName3;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSTextBox fld_txtARCustomerName21;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSTextBox fld_txtARCustomerName1;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSGroupControl fld_grcGroupControl1;
        private BOSComponent.BOSTextBox fld_txtARCustomerPaymentAddressTel;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSTextBox fld_txtARCustomerDeliveryAddressTel;
        private BOSComponent.BOSLabel bosLabel26;
        private BOSComponent.BOSTextBox fld_txtARCustomerInvoiceAddressTel;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSTextBox fld_txtARCustomerPaymentAddressPostalCode;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtARCustomerDeliveryAddressPostalCode;
        private BOSComponent.BOSLabel fld_lblLabelDeliveryPostalCode;
        private BOSComponent.BOSTextBox fld_txtARCustomerInvoiceAddressPostalCode;
        private BOSComponent.BOSLabel fld_lblLabelInvoicePostalCode;
        private BOSComponent.BOSButtonEdit fld_bedGELocationName3;
        private BOSComponent.BOSLabel fld_lblLabelPaymentPostalCode;
        private BOSComponent.BOSButtonEdit fld_bedGELocationName2;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSButtonEdit fld_bedGELocationName1;
        private BOSComponent.BOSTextBox fld_txtARCustomerPaymentAddressFax;
        private BOSComponent.BOSTextBox fld_txtARCustomerDeliveryAddressFax;
        private BOSComponent.BOSTextBox fld_txtARCustomerInvoiceAddressFax;
        private BOSComponent.BOSLabel bosLabel21;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkCopyPaymentAddress;
        private BOSComponent.BOSTextBox fld_txtARCustomerPaymentAddressTaxCode;
        private BOSComponent.BOSTextBox fld_txtARCustomerDeliveryAddressTaxCode;
        private BOSComponent.BOSTextBox fld_txtARCustomerInvoiceAddressTaxCode;
        private BOSComponent.BOSLabel bosLabel24;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkCopyInvoiceAddress;
        private BOSComponent.BOSLabel bosLabel23;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkCopyDeliveryAddress;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtARCustomerPaymentAddressLine1;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLine bosLine3;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSLabel bosLabel28;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSTextBox fld_txtARCustomerDeliveryAddressLine1;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSTextBox fld_txtARCustomerInvoiceAddressLine1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEPaymentTermID;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel29;
        private BOSComponent.BOSTextBox fld_txtARCustomerLevel;
        private BOSComponent.BOSLabel bosLabel30;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel31;
        private BOSComponent.BOSTextBox fld_txtARCustomerCMND;
        private BOSComponent.BOSLabel bosLabel32;
        private BOSComponent.BOSTextBox fld_txtARCustomerDeliveryContactName;
        private BOSComponent.BOSLabel bosLabel33;
        private BOSComponent.BOSLabel bosLabel34;
        private BOSComponent.BOSLookupEdit fld_lkeARCustomerSex;
        private BOSComponent.BOSLookupEdit fld_lkeARCustomerStatus;
        private BOSComponent.BOSLabel bosLabel35;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountDepositID;
        private BOSComponent.BOSLabel bosLabel38;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountSaleID;
        private BOSComponent.BOSLabel bosLabel37;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountPurchaseID;
        private BOSComponent.BOSLabel bosLabel36;
        private BOSComponent.BOSLabel bosLabel39;
        private BOSComponent.BOSLabel bosLabel42;
        private BOSComponent.BOSLabel bosLabel41;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEDeliveryDistrictID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEDeliveryStateProvinceID;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEDeliveryWardID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEDeliveryStreetID;
        private BOSComponent.BOSTextBox fld_txtARCustomerDeliveryHomeNumber;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLabel bosLabel40;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEDeliveryCountryID;
        private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerTypeAccountConfigID;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerResourceID;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ADFengShuisColorID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ADFengShuisGenaralID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ADFengShuisDirectionID;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLabel bosLabel45;
        private BOSComponent.BOSLabel bosLabel46;
        private BOSComponent.BOSLookupEdit bosLookupEdit2;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSTextBox fld_txtARCustomerPaymentContactName;
        private BOSComponent.BOSLabel bosLabel44;
        private BOSComponent.BOSTextBox fld_txtARCustomerInvoiceContactName;
        private BOSComponent.BOSLabel bosLabel43;
        private BOSComponent.BOSTextBox fld_txtARCustomerPaymentAddressEmail;
        private BOSComponent.BOSLabel bosLabel48;
        private BOSComponent.BOSTextBox fld_txtARCustomerDeliveryAddressEmail;
        private BOSComponent.BOSLabel bosLabel47;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeManagementID;
        private BOSComponent.BOSLabel bosLabel49;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerBusinessTypeID;
        private BOSComponent.BOSLabel bosLabel50;
        private BOSComponent.BOSLabel bosLabel96;
        private BOSComponent.BOSDateEdit fld_dteARCustomerStartDate;
        private BOSComponent.BOSLabel bosLabel51;
        private BOSComponent.BOSTextBox bosTextBox2;
    }
}
