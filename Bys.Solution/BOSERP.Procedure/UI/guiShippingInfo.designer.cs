using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP
{
    /// <summary>
    /// Summary description for DSSO100
    /// </summary>
    partial class guiShippingInfo
    {
        private BOSComponent.BOSGroupControl fld_grcBillAddress;
        private BOSComponent.BOSGroupControl fld_grcShipAddress;
        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel1;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSLabel fld_lblLabel9;
        private BOSComponent.BOSTextBox fld_txtInvoiceAddressLine1;
        private BOSComponent.BOSTextBox fld_txtInvoiceAddressCity;
        private BOSComponent.BOSTextBox fld_txtInvoiceAddressCountry;
        private BOSComponent.BOSTextBox fld_txtInvoiceAddressPostalCode;
        private BOSComponent.BOSTextBox fld_txtDeliveryAddressLine1;
        private BOSComponent.BOSTextBox fld_txtDeliveryAddressCity;
        private BOSComponent.BOSTextBox fld_txtDeliveryAddressStateProvince;
        private BOSComponent.BOSTextBox fld_txtDeliveryAddressCountry;
        private BOSComponent.BOSTextBox fld_txtDeliveryAddressPostalCode;
        private BOSComponent.BOSTextBox fld_txtInvoiceAddressStateProvince;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiShippingInfo));
            this.fld_grcBillAddress = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeBranchInvoiceID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtInvoiceAddressLine1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtInvoiceAddressCity = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtInvoiceAddressCountry = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtInvoiceAddressPostalCode = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtInvoiceAddressStateProvince = new BOSComponent.BOSTextBox(this.components);
            this.fld_grcShipAddress = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeBranchDeliveryID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lnkCopyBillAddress = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtDeliveryAddressLine1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtDeliveryAddressCity = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtDeliveryAddressStateProvince = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtDeliveryAddressCountry = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtDeliveryAddressPostalCode = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_grcPaymentAddress = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeBRBranchPaymentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lnkCopyBillAddress1 = new DevExpress.XtraEditors.HyperLinkEdit();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtPaymentAddressLine1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtPaymentAddressCity = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtPaymentAddressStateProvince = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtPaymentAddressCountry = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtPaymentAddressPostalCode = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcBillAddress)).BeginInit();
            this.fld_grcBillAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBranchInvoiceID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtInvoiceAddressLine1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtInvoiceAddressCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtInvoiceAddressCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtInvoiceAddressPostalCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtInvoiceAddressStateProvince.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcShipAddress)).BeginInit();
            this.fld_grcShipAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBranchDeliveryID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkCopyBillAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDeliveryAddressLine1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDeliveryAddressCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDeliveryAddressStateProvince.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDeliveryAddressCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDeliveryAddressPostalCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcPaymentAddress)).BeginInit();
            this.fld_grcPaymentAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchPaymentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkCopyBillAddress1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPaymentAddressLine1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPaymentAddressCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPaymentAddressStateProvince.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPaymentAddressCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPaymentAddressPostalCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_grcBillAddress
            // 
            this.fld_grcBillAddress.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcBillAddress.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcBillAddress.Appearance.Options.UseBackColor = true;
            this.fld_grcBillAddress.Appearance.Options.UseForeColor = true;
            this.fld_grcBillAddress.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcBillAddress.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcBillAddress.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcBillAddress.BOSDescription = null;
            this.fld_grcBillAddress.BOSError = null;
            this.fld_grcBillAddress.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcBillAddress.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcBillAddress.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcBillAddress.BOSPropertyName = null;
            this.fld_grcBillAddress.Controls.Add(this.fld_lkeBranchInvoiceID);
            this.fld_grcBillAddress.Controls.Add(this.fld_lblLabel);
            this.fld_grcBillAddress.Controls.Add(this.fld_lblLabel1);
            this.fld_grcBillAddress.Controls.Add(this.fld_lblLabel2);
            this.fld_grcBillAddress.Controls.Add(this.bosLabel8);
            this.fld_grcBillAddress.Controls.Add(this.fld_lblLabel3);
            this.fld_grcBillAddress.Controls.Add(this.fld_lblLabel4);
            this.fld_grcBillAddress.Controls.Add(this.fld_txtInvoiceAddressLine1);
            this.fld_grcBillAddress.Controls.Add(this.fld_txtInvoiceAddressCity);
            this.fld_grcBillAddress.Controls.Add(this.fld_txtInvoiceAddressCountry);
            this.fld_grcBillAddress.Controls.Add(this.fld_txtInvoiceAddressPostalCode);
            this.fld_grcBillAddress.Controls.Add(this.fld_txtInvoiceAddressStateProvince);
            this.fld_grcBillAddress.Location = new System.Drawing.Point(12, 12);
            this.fld_grcBillAddress.Name = "fld_grcBillAddress";
            this.fld_grcBillAddress.Screen = null;
            this.fld_grcBillAddress.Size = new System.Drawing.Size(550, 144);
            this.fld_grcBillAddress.TabIndex = 1;
            this.fld_grcBillAddress.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcBillAddress.Text = "Địa chỉ hóa đơn";
            // 
            // fld_lkeBranchInvoiceID
            // 
            this.fld_lkeBranchInvoiceID.BOSAllowAddNew = false;
            this.fld_lkeBranchInvoiceID.BOSAllowDummy = false;
            this.fld_lkeBranchInvoiceID.BOSComment = null;
            this.fld_lkeBranchInvoiceID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeBranchInvoiceID.BOSDataSource = "APPurchaseOrders";
            this.fld_lkeBranchInvoiceID.BOSDescription = null;
            this.fld_lkeBranchInvoiceID.BOSError = null;
            this.fld_lkeBranchInvoiceID.BOSFieldGroup = null;
            this.fld_lkeBranchInvoiceID.BOSFieldParent = null;
            this.fld_lkeBranchInvoiceID.BOSFieldRelation = null;
            this.fld_lkeBranchInvoiceID.BOSPrivilege = null;
            this.fld_lkeBranchInvoiceID.BOSPropertyName = "EditValue";
            this.fld_lkeBranchInvoiceID.BOSSelectType = null;
            this.fld_lkeBranchInvoiceID.BOSSelectTypeValue = null;
            this.fld_lkeBranchInvoiceID.CurrentDisplayText = null;
            this.fld_lkeBranchInvoiceID.Location = new System.Drawing.Point(78, 110);
            this.fld_lkeBranchInvoiceID.Name = "fld_lkeBranchInvoiceID";
            this.fld_lkeBranchInvoiceID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeBranchInvoiceID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeBranchInvoiceID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeBranchInvoiceID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeBranchInvoiceID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBranchInvoiceID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchContactAddressLine1", "Địa chỉ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchContactPhone", "Số điện thoại"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchContactFax", "Số Fax")});
            this.fld_lkeBranchInvoiceID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBranchInvoiceID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeBranchInvoiceID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeBranchInvoiceID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBranchInvoiceID.Screen = null;
            this.fld_lkeBranchInvoiceID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBranchInvoiceID.TabIndex = 29;
            this.fld_lkeBranchInvoiceID.Tag = "DC";
            this.fld_lkeBranchInvoiceID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeBranchInvoiceID_CloseUp);
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSPropertyName = null;
            this.fld_lblLabel.Location = new System.Drawing.Point(16, 35);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(32, 13);
            this.fld_lblLabel.TabIndex = 8;
            this.fld_lblLabel.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.Text = "Địa chỉ";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSPropertyName = null;
            this.fld_lblLabel1.Location = new System.Drawing.Point(16, 61);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(51, 13);
            this.fld_lblLabel1.TabIndex = 9;
            this.fld_lblLabel1.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.Text = "Thành phố";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(16, 87);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(42, 13);
            this.fld_lblLabel2.TabIndex = 10;
            this.fld_lblLabel2.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.Text = "Quốc gia";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(16, 113);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(48, 13);
            this.bosLabel8.TabIndex = 15;
            this.bosLabel8.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.Text = "Chi nhánh";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(294, 61);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel3.TabIndex = 11;
            this.fld_lblLabel3.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.Text = "Tỉnh";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(294, 87);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(41, 13);
            this.fld_lblLabel4.TabIndex = 12;
            this.fld_lblLabel4.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.Text = "Mã vùng";
            // 
            // fld_txtInvoiceAddressLine1
            // 
            this.fld_txtInvoiceAddressLine1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressLine1.BOSDataMember = "InvoiceAddressLine1";
            this.fld_txtInvoiceAddressLine1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressLine1.BOSDescription = null;
            this.fld_txtInvoiceAddressLine1.BOSError = null;
            this.fld_txtInvoiceAddressLine1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressLine1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressLine1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressLine1.BOSPropertyName = "Text";
            this.fld_txtInvoiceAddressLine1.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressLine1.Location = new System.Drawing.Point(78, 32);
            this.fld_txtInvoiceAddressLine1.Name = "fld_txtInvoiceAddressLine1";
            this.fld_txtInvoiceAddressLine1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtInvoiceAddressLine1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtInvoiceAddressLine1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtInvoiceAddressLine1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtInvoiceAddressLine1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtInvoiceAddressLine1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtInvoiceAddressLine1.Screen = null;
            this.fld_txtInvoiceAddressLine1.Size = new System.Drawing.Size(440, 20);
            this.fld_txtInvoiceAddressLine1.TabIndex = 18;
            this.fld_txtInvoiceAddressLine1.Tag = "DC";
            // 
            // fld_txtInvoiceAddressCity
            // 
            this.fld_txtInvoiceAddressCity.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressCity.BOSDataMember = "InvoiceAddressCity";
            this.fld_txtInvoiceAddressCity.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressCity.BOSDescription = null;
            this.fld_txtInvoiceAddressCity.BOSError = null;
            this.fld_txtInvoiceAddressCity.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressCity.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressCity.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressCity.BOSPropertyName = "Text";
            this.fld_txtInvoiceAddressCity.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressCity.Location = new System.Drawing.Point(78, 58);
            this.fld_txtInvoiceAddressCity.Name = "fld_txtInvoiceAddressCity";
            this.fld_txtInvoiceAddressCity.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtInvoiceAddressCity.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtInvoiceAddressCity.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtInvoiceAddressCity.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtInvoiceAddressCity.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtInvoiceAddressCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtInvoiceAddressCity.Screen = null;
            this.fld_txtInvoiceAddressCity.Size = new System.Drawing.Size(150, 20);
            this.fld_txtInvoiceAddressCity.TabIndex = 19;
            this.fld_txtInvoiceAddressCity.Tag = "DC";
            // 
            // fld_txtInvoiceAddressCountry
            // 
            this.fld_txtInvoiceAddressCountry.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressCountry.BOSDataMember = "InvoiceAddressCountry";
            this.fld_txtInvoiceAddressCountry.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressCountry.BOSDescription = null;
            this.fld_txtInvoiceAddressCountry.BOSError = null;
            this.fld_txtInvoiceAddressCountry.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressCountry.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressCountry.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressCountry.BOSPropertyName = "Text";
            this.fld_txtInvoiceAddressCountry.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressCountry.Location = new System.Drawing.Point(78, 84);
            this.fld_txtInvoiceAddressCountry.Name = "fld_txtInvoiceAddressCountry";
            this.fld_txtInvoiceAddressCountry.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtInvoiceAddressCountry.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtInvoiceAddressCountry.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtInvoiceAddressCountry.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtInvoiceAddressCountry.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtInvoiceAddressCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtInvoiceAddressCountry.Screen = null;
            this.fld_txtInvoiceAddressCountry.Size = new System.Drawing.Size(150, 20);
            this.fld_txtInvoiceAddressCountry.TabIndex = 21;
            this.fld_txtInvoiceAddressCountry.Tag = "DC";
            // 
            // fld_txtInvoiceAddressPostalCode
            // 
            this.fld_txtInvoiceAddressPostalCode.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressPostalCode.BOSDataMember = "InvoiceAddressPostalCode";
            this.fld_txtInvoiceAddressPostalCode.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressPostalCode.BOSDescription = null;
            this.fld_txtInvoiceAddressPostalCode.BOSError = null;
            this.fld_txtInvoiceAddressPostalCode.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressPostalCode.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressPostalCode.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressPostalCode.BOSPropertyName = "Text";
            this.fld_txtInvoiceAddressPostalCode.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressPostalCode.Location = new System.Drawing.Point(368, 84);
            this.fld_txtInvoiceAddressPostalCode.Name = "fld_txtInvoiceAddressPostalCode";
            this.fld_txtInvoiceAddressPostalCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtInvoiceAddressPostalCode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtInvoiceAddressPostalCode.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtInvoiceAddressPostalCode.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtInvoiceAddressPostalCode.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtInvoiceAddressPostalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtInvoiceAddressPostalCode.Screen = null;
            this.fld_txtInvoiceAddressPostalCode.Size = new System.Drawing.Size(105, 20);
            this.fld_txtInvoiceAddressPostalCode.TabIndex = 22;
            this.fld_txtInvoiceAddressPostalCode.Tag = "DC";
            // 
            // fld_txtInvoiceAddressStateProvince
            // 
            this.fld_txtInvoiceAddressStateProvince.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressStateProvince.BOSDataMember = "InvoiceAddressStateProvince";
            this.fld_txtInvoiceAddressStateProvince.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressStateProvince.BOSDescription = null;
            this.fld_txtInvoiceAddressStateProvince.BOSError = null;
            this.fld_txtInvoiceAddressStateProvince.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressStateProvince.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressStateProvince.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressStateProvince.BOSPropertyName = "Text";
            this.fld_txtInvoiceAddressStateProvince.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtInvoiceAddressStateProvince.Location = new System.Drawing.Point(368, 58);
            this.fld_txtInvoiceAddressStateProvince.Name = "fld_txtInvoiceAddressStateProvince";
            this.fld_txtInvoiceAddressStateProvince.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtInvoiceAddressStateProvince.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtInvoiceAddressStateProvince.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtInvoiceAddressStateProvince.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtInvoiceAddressStateProvince.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtInvoiceAddressStateProvince.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtInvoiceAddressStateProvince.Screen = null;
            this.fld_txtInvoiceAddressStateProvince.Size = new System.Drawing.Size(150, 20);
            this.fld_txtInvoiceAddressStateProvince.TabIndex = 20;
            this.fld_txtInvoiceAddressStateProvince.Tag = "DC";
            // 
            // fld_grcShipAddress
            // 
            this.fld_grcShipAddress.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcShipAddress.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcShipAddress.Appearance.Options.UseBackColor = true;
            this.fld_grcShipAddress.Appearance.Options.UseForeColor = true;
            this.fld_grcShipAddress.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcShipAddress.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcShipAddress.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcShipAddress.BOSDescription = null;
            this.fld_grcShipAddress.BOSError = null;
            this.fld_grcShipAddress.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcShipAddress.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcShipAddress.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcShipAddress.BOSPropertyName = null;
            this.fld_grcShipAddress.Controls.Add(this.fld_lkeBranchDeliveryID);
            this.fld_grcShipAddress.Controls.Add(this.fld_lnkCopyBillAddress);
            this.fld_grcShipAddress.Controls.Add(this.fld_lblLabel5);
            this.fld_grcShipAddress.Controls.Add(this.fld_lblLabel6);
            this.fld_grcShipAddress.Controls.Add(this.bosLabel7);
            this.fld_grcShipAddress.Controls.Add(this.fld_lblLabel7);
            this.fld_grcShipAddress.Controls.Add(this.fld_lblLabel8);
            this.fld_grcShipAddress.Controls.Add(this.fld_lblLabel9);
            this.fld_grcShipAddress.Controls.Add(this.fld_txtDeliveryAddressLine1);
            this.fld_grcShipAddress.Controls.Add(this.fld_txtDeliveryAddressCity);
            this.fld_grcShipAddress.Controls.Add(this.fld_txtDeliveryAddressStateProvince);
            this.fld_grcShipAddress.Controls.Add(this.fld_txtDeliveryAddressCountry);
            this.fld_grcShipAddress.Controls.Add(this.fld_txtDeliveryAddressPostalCode);
            this.fld_grcShipAddress.Location = new System.Drawing.Point(12, 162);
            this.fld_grcShipAddress.Name = "fld_grcShipAddress";
            this.fld_grcShipAddress.Screen = null;
            this.fld_grcShipAddress.Size = new System.Drawing.Size(550, 157);
            this.fld_grcShipAddress.TabIndex = 2;
            this.fld_grcShipAddress.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcShipAddress.Text = "Địa chỉ giao hàng";
            // 
            // fld_lkeBranchDeliveryID
            // 
            this.fld_lkeBranchDeliveryID.BOSAllowAddNew = false;
            this.fld_lkeBranchDeliveryID.BOSAllowDummy = false;
            this.fld_lkeBranchDeliveryID.BOSComment = null;
            this.fld_lkeBranchDeliveryID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeBranchDeliveryID.BOSDataSource = "APPurchaseOrders";
            this.fld_lkeBranchDeliveryID.BOSDescription = null;
            this.fld_lkeBranchDeliveryID.BOSError = null;
            this.fld_lkeBranchDeliveryID.BOSFieldGroup = null;
            this.fld_lkeBranchDeliveryID.BOSFieldParent = null;
            this.fld_lkeBranchDeliveryID.BOSFieldRelation = null;
            this.fld_lkeBranchDeliveryID.BOSPrivilege = null;
            this.fld_lkeBranchDeliveryID.BOSPropertyName = "EditValue";
            this.fld_lkeBranchDeliveryID.BOSSelectType = null;
            this.fld_lkeBranchDeliveryID.BOSSelectTypeValue = null;
            this.fld_lkeBranchDeliveryID.CurrentDisplayText = null;
            this.fld_lkeBranchDeliveryID.Location = new System.Drawing.Point(78, 111);
            this.fld_lkeBranchDeliveryID.Name = "fld_lkeBranchDeliveryID";
            this.fld_lkeBranchDeliveryID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeBranchDeliveryID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeBranchDeliveryID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeBranchDeliveryID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeBranchDeliveryID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBranchDeliveryID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchContactAddressLine1", "Địa chỉ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchContactPhone", "Số điện thoại"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchContactFax", "Số Fax")});
            this.fld_lkeBranchDeliveryID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBranchDeliveryID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeBranchDeliveryID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeBranchDeliveryID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBranchDeliveryID.Screen = null;
            this.fld_lkeBranchDeliveryID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBranchDeliveryID.TabIndex = 29;
            this.fld_lkeBranchDeliveryID.Tag = "DC";
            this.fld_lkeBranchDeliveryID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeBranchDeliveryID_CloseUp);
            // 
            // fld_lnkCopyBillAddress
            // 
            this.fld_lnkCopyBillAddress.EditValue = "Sao chép từ địa chỉ hóa đơn";
            this.fld_lnkCopyBillAddress.Location = new System.Drawing.Point(5, 134);
            this.fld_lnkCopyBillAddress.MenuManager = this.screenToolbar;
            this.fld_lnkCopyBillAddress.Name = "fld_lnkCopyBillAddress";
            this.fld_lnkCopyBillAddress.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkCopyBillAddress.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkCopyBillAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkCopyBillAddress.Size = new System.Drawing.Size(149, 18);
            this.fld_lnkCopyBillAddress.TabIndex = 28;
            this.fld_lnkCopyBillAddress.Click += new System.EventHandler(this.fld_lnkCopyBillAddress_Click);
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSPropertyName = null;
            this.fld_lblLabel5.Location = new System.Drawing.Point(16, 36);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(32, 13);
            this.fld_lblLabel5.TabIndex = 13;
            this.fld_lblLabel5.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.Text = "Địa chỉ";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSPropertyName = null;
            this.fld_lblLabel6.Location = new System.Drawing.Point(16, 62);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(51, 13);
            this.fld_lblLabel6.TabIndex = 14;
            this.fld_lblLabel6.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.Text = "Thành phố";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(16, 114);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(48, 13);
            this.bosLabel7.TabIndex = 15;
            this.bosLabel7.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.Text = "Chi nhánh";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSPropertyName = null;
            this.fld_lblLabel7.Location = new System.Drawing.Point(16, 88);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(42, 13);
            this.fld_lblLabel7.TabIndex = 15;
            this.fld_lblLabel7.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.Text = "Quốc gia";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSPropertyName = null;
            this.fld_lblLabel8.Location = new System.Drawing.Point(303, 62);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel8.TabIndex = 16;
            this.fld_lblLabel8.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.Text = "Tỉnh";
            // 
            // fld_lblLabel9
            // 
            this.fld_lblLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel9.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel9.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel9.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel9.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel9.BOSDescription = null;
            this.fld_lblLabel9.BOSError = null;
            this.fld_lblLabel9.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel9.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel9.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel9.BOSPropertyName = null;
            this.fld_lblLabel9.Location = new System.Drawing.Point(303, 88);
            this.fld_lblLabel9.Name = "fld_lblLabel9";
            this.fld_lblLabel9.Screen = null;
            this.fld_lblLabel9.Size = new System.Drawing.Size(41, 13);
            this.fld_lblLabel9.TabIndex = 17;
            this.fld_lblLabel9.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel9.Text = "Mã vùng";
            // 
            // fld_txtDeliveryAddressLine1
            // 
            this.fld_txtDeliveryAddressLine1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressLine1.BOSDataMember = "DeliveryAddressLine1";
            this.fld_txtDeliveryAddressLine1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressLine1.BOSDescription = null;
            this.fld_txtDeliveryAddressLine1.BOSError = null;
            this.fld_txtDeliveryAddressLine1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressLine1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressLine1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressLine1.BOSPropertyName = "Text";
            this.fld_txtDeliveryAddressLine1.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressLine1.Location = new System.Drawing.Point(78, 33);
            this.fld_txtDeliveryAddressLine1.Name = "fld_txtDeliveryAddressLine1";
            this.fld_txtDeliveryAddressLine1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtDeliveryAddressLine1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtDeliveryAddressLine1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtDeliveryAddressLine1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtDeliveryAddressLine1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtDeliveryAddressLine1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtDeliveryAddressLine1.Screen = null;
            this.fld_txtDeliveryAddressLine1.Size = new System.Drawing.Size(440, 20);
            this.fld_txtDeliveryAddressLine1.TabIndex = 23;
            this.fld_txtDeliveryAddressLine1.Tag = "DC";
            // 
            // fld_txtDeliveryAddressCity
            // 
            this.fld_txtDeliveryAddressCity.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressCity.BOSDataMember = "DeliveryAddressCity";
            this.fld_txtDeliveryAddressCity.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressCity.BOSDescription = null;
            this.fld_txtDeliveryAddressCity.BOSError = null;
            this.fld_txtDeliveryAddressCity.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressCity.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressCity.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressCity.BOSPropertyName = "Text";
            this.fld_txtDeliveryAddressCity.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressCity.Location = new System.Drawing.Point(78, 59);
            this.fld_txtDeliveryAddressCity.Name = "fld_txtDeliveryAddressCity";
            this.fld_txtDeliveryAddressCity.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtDeliveryAddressCity.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtDeliveryAddressCity.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtDeliveryAddressCity.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtDeliveryAddressCity.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtDeliveryAddressCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtDeliveryAddressCity.Screen = null;
            this.fld_txtDeliveryAddressCity.Size = new System.Drawing.Size(150, 20);
            this.fld_txtDeliveryAddressCity.TabIndex = 24;
            this.fld_txtDeliveryAddressCity.Tag = "DC";
            // 
            // fld_txtDeliveryAddressStateProvince
            // 
            this.fld_txtDeliveryAddressStateProvince.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressStateProvince.BOSDataMember = "DeliveryAddressStateProvince";
            this.fld_txtDeliveryAddressStateProvince.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressStateProvince.BOSDescription = null;
            this.fld_txtDeliveryAddressStateProvince.BOSError = null;
            this.fld_txtDeliveryAddressStateProvince.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressStateProvince.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressStateProvince.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressStateProvince.BOSPropertyName = "Text";
            this.fld_txtDeliveryAddressStateProvince.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressStateProvince.Location = new System.Drawing.Point(368, 59);
            this.fld_txtDeliveryAddressStateProvince.Name = "fld_txtDeliveryAddressStateProvince";
            this.fld_txtDeliveryAddressStateProvince.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtDeliveryAddressStateProvince.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtDeliveryAddressStateProvince.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtDeliveryAddressStateProvince.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtDeliveryAddressStateProvince.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtDeliveryAddressStateProvince.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtDeliveryAddressStateProvince.Screen = null;
            this.fld_txtDeliveryAddressStateProvince.Size = new System.Drawing.Size(150, 20);
            this.fld_txtDeliveryAddressStateProvince.TabIndex = 25;
            this.fld_txtDeliveryAddressStateProvince.Tag = "DC";
            // 
            // fld_txtDeliveryAddressCountry
            // 
            this.fld_txtDeliveryAddressCountry.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressCountry.BOSDataMember = "DeliveryAddressCountry";
            this.fld_txtDeliveryAddressCountry.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressCountry.BOSDescription = null;
            this.fld_txtDeliveryAddressCountry.BOSError = null;
            this.fld_txtDeliveryAddressCountry.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressCountry.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressCountry.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressCountry.BOSPropertyName = "Text";
            this.fld_txtDeliveryAddressCountry.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressCountry.Location = new System.Drawing.Point(78, 85);
            this.fld_txtDeliveryAddressCountry.Name = "fld_txtDeliveryAddressCountry";
            this.fld_txtDeliveryAddressCountry.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtDeliveryAddressCountry.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtDeliveryAddressCountry.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtDeliveryAddressCountry.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtDeliveryAddressCountry.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtDeliveryAddressCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtDeliveryAddressCountry.Screen = null;
            this.fld_txtDeliveryAddressCountry.Size = new System.Drawing.Size(150, 20);
            this.fld_txtDeliveryAddressCountry.TabIndex = 26;
            this.fld_txtDeliveryAddressCountry.Tag = "DC";
            // 
            // fld_txtDeliveryAddressPostalCode
            // 
            this.fld_txtDeliveryAddressPostalCode.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressPostalCode.BOSDataMember = "DeliveryAddressPostalCode";
            this.fld_txtDeliveryAddressPostalCode.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressPostalCode.BOSDescription = null;
            this.fld_txtDeliveryAddressPostalCode.BOSError = null;
            this.fld_txtDeliveryAddressPostalCode.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressPostalCode.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressPostalCode.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressPostalCode.BOSPropertyName = "Text";
            this.fld_txtDeliveryAddressPostalCode.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtDeliveryAddressPostalCode.Location = new System.Drawing.Point(368, 85);
            this.fld_txtDeliveryAddressPostalCode.Name = "fld_txtDeliveryAddressPostalCode";
            this.fld_txtDeliveryAddressPostalCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtDeliveryAddressPostalCode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtDeliveryAddressPostalCode.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtDeliveryAddressPostalCode.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtDeliveryAddressPostalCode.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtDeliveryAddressPostalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtDeliveryAddressPostalCode.Screen = null;
            this.fld_txtDeliveryAddressPostalCode.Size = new System.Drawing.Size(105, 20);
            this.fld_txtDeliveryAddressPostalCode.TabIndex = 27;
            this.fld_txtDeliveryAddressPostalCode.Tag = "DC";
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnOK.Appearance.Options.UseForeColor = true;
            this.fld_btnOK.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnOK.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnOK.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnOK.BOSDescription = null;
            this.fld_btnOK.BOSError = null;
            this.fld_btnOK.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnOK.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnOK.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnOK.BOSPropertyName = null;
            this.fld_btnOK.Location = new System.Drawing.Point(406, 495);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(75, 25);
            this.fld_btnOK.TabIndex = 6;
            this.fld_btnOK.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnOK.Text = "Đồng ý";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnCancel.Appearance.Options.UseForeColor = true;
            this.fld_btnCancel.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnCancel.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnCancel.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnCancel.BOSDescription = null;
            this.fld_btnCancel.BOSError = null;
            this.fld_btnCancel.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnCancel.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnCancel.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnCancel.BOSPropertyName = null;
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(487, 495);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 25);
            this.fld_btnCancel.TabIndex = 7;
            this.fld_btnCancel.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_grcPaymentAddress
            // 
            this.fld_grcPaymentAddress.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcPaymentAddress.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcPaymentAddress.Appearance.Options.UseBackColor = true;
            this.fld_grcPaymentAddress.Appearance.Options.UseForeColor = true;
            this.fld_grcPaymentAddress.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcPaymentAddress.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcPaymentAddress.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcPaymentAddress.BOSDescription = null;
            this.fld_grcPaymentAddress.BOSError = null;
            this.fld_grcPaymentAddress.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcPaymentAddress.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcPaymentAddress.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcPaymentAddress.BOSPropertyName = null;
            this.fld_grcPaymentAddress.Controls.Add(this.fld_lkeBRBranchPaymentID);
            this.fld_grcPaymentAddress.Controls.Add(this.fld_lnkCopyBillAddress1);
            this.fld_grcPaymentAddress.Controls.Add(this.bosLabel1);
            this.fld_grcPaymentAddress.Controls.Add(this.bosLabel2);
            this.fld_grcPaymentAddress.Controls.Add(this.bosLabel6);
            this.fld_grcPaymentAddress.Controls.Add(this.bosLabel3);
            this.fld_grcPaymentAddress.Controls.Add(this.bosLabel4);
            this.fld_grcPaymentAddress.Controls.Add(this.bosLabel5);
            this.fld_grcPaymentAddress.Controls.Add(this.fld_txtPaymentAddressLine1);
            this.fld_grcPaymentAddress.Controls.Add(this.fld_txtPaymentAddressCity);
            this.fld_grcPaymentAddress.Controls.Add(this.fld_txtPaymentAddressStateProvince);
            this.fld_grcPaymentAddress.Controls.Add(this.fld_txtPaymentAddressCountry);
            this.fld_grcPaymentAddress.Controls.Add(this.fld_txtPaymentAddressPostalCode);
            this.fld_grcPaymentAddress.Location = new System.Drawing.Point(12, 325);
            this.fld_grcPaymentAddress.Name = "fld_grcPaymentAddress";
            this.fld_grcPaymentAddress.Screen = null;
            this.fld_grcPaymentAddress.Size = new System.Drawing.Size(550, 164);
            this.fld_grcPaymentAddress.TabIndex = 3;
            this.fld_grcPaymentAddress.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcPaymentAddress.Text = "Địa chỉ thu tiền";
            // 
            // fld_lkeBRBranchPaymentID
            // 
            this.fld_lkeBRBranchPaymentID.BOSAllowAddNew = false;
            this.fld_lkeBRBranchPaymentID.BOSAllowDummy = false;
            this.fld_lkeBRBranchPaymentID.BOSComment = null;
            this.fld_lkeBRBranchPaymentID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeBRBranchPaymentID.BOSDataSource = "APPurchaseOrders";
            this.fld_lkeBRBranchPaymentID.BOSDescription = null;
            this.fld_lkeBRBranchPaymentID.BOSError = null;
            this.fld_lkeBRBranchPaymentID.BOSFieldGroup = null;
            this.fld_lkeBRBranchPaymentID.BOSFieldParent = null;
            this.fld_lkeBRBranchPaymentID.BOSFieldRelation = null;
            this.fld_lkeBRBranchPaymentID.BOSPrivilege = null;
            this.fld_lkeBRBranchPaymentID.BOSPropertyName = "EditValue";
            this.fld_lkeBRBranchPaymentID.BOSSelectType = null;
            this.fld_lkeBRBranchPaymentID.BOSSelectTypeValue = null;
            this.fld_lkeBRBranchPaymentID.CurrentDisplayText = null;
            this.fld_lkeBRBranchPaymentID.Location = new System.Drawing.Point(78, 111);
            this.fld_lkeBRBranchPaymentID.Name = "fld_lkeBRBranchPaymentID";
            this.fld_lkeBRBranchPaymentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeBRBranchPaymentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeBRBranchPaymentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeBRBranchPaymentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeBRBranchPaymentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBRBranchPaymentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchContactAddressLine1", "Địa chỉ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchContactPhone", "Số điện thoại"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchContactFax", "Số Fax")});
            this.fld_lkeBRBranchPaymentID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBRBranchPaymentID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeBRBranchPaymentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeBRBranchPaymentID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchPaymentID.Screen = null;
            this.fld_lkeBRBranchPaymentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchPaymentID.TabIndex = 29;
            this.fld_lkeBRBranchPaymentID.Tag = "DC";
            this.fld_lkeBRBranchPaymentID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeBRBranchPaymentID_CloseUp);
            // 
            // fld_lnkCopyBillAddress1
            // 
            this.fld_lnkCopyBillAddress1.EditValue = "Sao chép từ địa chỉ hóa đơn";
            this.fld_lnkCopyBillAddress1.Location = new System.Drawing.Point(5, 141);
            this.fld_lnkCopyBillAddress1.MenuManager = this.screenToolbar;
            this.fld_lnkCopyBillAddress1.Name = "fld_lnkCopyBillAddress1";
            this.fld_lnkCopyBillAddress1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkCopyBillAddress1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkCopyBillAddress1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkCopyBillAddress1.Size = new System.Drawing.Size(149, 18);
            this.fld_lnkCopyBillAddress1.TabIndex = 28;
            this.fld_lnkCopyBillAddress1.Click += new System.EventHandler(this.fld_lnkCopyBillAddress1_Click);
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(16, 36);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(32, 13);
            this.bosLabel1.TabIndex = 13;
            this.bosLabel1.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.Text = "Địa chỉ";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(16, 62);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(51, 13);
            this.bosLabel2.TabIndex = 14;
            this.bosLabel2.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.Text = "Thành phố";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(16, 114);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 15;
            this.bosLabel6.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.Text = "Chi nhánh";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(16, 88);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(42, 13);
            this.bosLabel3.TabIndex = 15;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.Text = "Quốc gia";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(303, 62);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(20, 13);
            this.bosLabel4.TabIndex = 16;
            this.bosLabel4.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.Text = "Tỉnh";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(303, 88);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(41, 13);
            this.bosLabel5.TabIndex = 17;
            this.bosLabel5.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.Text = "Mã vùng";
            // 
            // fld_txtPaymentAddressLine1
            // 
            this.fld_txtPaymentAddressLine1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressLine1.BOSDataMember = "PaymentAddressLine1";
            this.fld_txtPaymentAddressLine1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressLine1.BOSDescription = null;
            this.fld_txtPaymentAddressLine1.BOSError = null;
            this.fld_txtPaymentAddressLine1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressLine1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressLine1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressLine1.BOSPropertyName = "Text";
            this.fld_txtPaymentAddressLine1.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressLine1.Location = new System.Drawing.Point(78, 33);
            this.fld_txtPaymentAddressLine1.Name = "fld_txtPaymentAddressLine1";
            this.fld_txtPaymentAddressLine1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPaymentAddressLine1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPaymentAddressLine1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPaymentAddressLine1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPaymentAddressLine1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPaymentAddressLine1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPaymentAddressLine1.Screen = null;
            this.fld_txtPaymentAddressLine1.Size = new System.Drawing.Size(440, 20);
            this.fld_txtPaymentAddressLine1.TabIndex = 23;
            this.fld_txtPaymentAddressLine1.Tag = "DC";
            // 
            // fld_txtPaymentAddressCity
            // 
            this.fld_txtPaymentAddressCity.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressCity.BOSDataMember = "PaymentAddressCity";
            this.fld_txtPaymentAddressCity.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressCity.BOSDescription = null;
            this.fld_txtPaymentAddressCity.BOSError = null;
            this.fld_txtPaymentAddressCity.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressCity.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressCity.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressCity.BOSPropertyName = "Text";
            this.fld_txtPaymentAddressCity.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressCity.Location = new System.Drawing.Point(78, 59);
            this.fld_txtPaymentAddressCity.Name = "fld_txtPaymentAddressCity";
            this.fld_txtPaymentAddressCity.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPaymentAddressCity.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPaymentAddressCity.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPaymentAddressCity.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPaymentAddressCity.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPaymentAddressCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPaymentAddressCity.Screen = null;
            this.fld_txtPaymentAddressCity.Size = new System.Drawing.Size(150, 20);
            this.fld_txtPaymentAddressCity.TabIndex = 24;
            this.fld_txtPaymentAddressCity.Tag = "DC";
            // 
            // fld_txtPaymentAddressStateProvince
            // 
            this.fld_txtPaymentAddressStateProvince.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressStateProvince.BOSDataMember = "PaymentAddressStateProvince";
            this.fld_txtPaymentAddressStateProvince.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressStateProvince.BOSDescription = null;
            this.fld_txtPaymentAddressStateProvince.BOSError = null;
            this.fld_txtPaymentAddressStateProvince.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressStateProvince.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressStateProvince.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressStateProvince.BOSPropertyName = "Text";
            this.fld_txtPaymentAddressStateProvince.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressStateProvince.Location = new System.Drawing.Point(368, 59);
            this.fld_txtPaymentAddressStateProvince.Name = "fld_txtPaymentAddressStateProvince";
            this.fld_txtPaymentAddressStateProvince.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPaymentAddressStateProvince.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPaymentAddressStateProvince.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPaymentAddressStateProvince.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPaymentAddressStateProvince.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPaymentAddressStateProvince.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPaymentAddressStateProvince.Screen = null;
            this.fld_txtPaymentAddressStateProvince.Size = new System.Drawing.Size(150, 20);
            this.fld_txtPaymentAddressStateProvince.TabIndex = 25;
            this.fld_txtPaymentAddressStateProvince.Tag = "DC";
            // 
            // fld_txtPaymentAddressCountry
            // 
            this.fld_txtPaymentAddressCountry.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressCountry.BOSDataMember = "PaymentAddressCountry";
            this.fld_txtPaymentAddressCountry.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressCountry.BOSDescription = null;
            this.fld_txtPaymentAddressCountry.BOSError = null;
            this.fld_txtPaymentAddressCountry.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressCountry.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressCountry.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressCountry.BOSPropertyName = "Text";
            this.fld_txtPaymentAddressCountry.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressCountry.Location = new System.Drawing.Point(78, 85);
            this.fld_txtPaymentAddressCountry.Name = "fld_txtPaymentAddressCountry";
            this.fld_txtPaymentAddressCountry.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPaymentAddressCountry.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPaymentAddressCountry.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPaymentAddressCountry.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPaymentAddressCountry.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPaymentAddressCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPaymentAddressCountry.Screen = null;
            this.fld_txtPaymentAddressCountry.Size = new System.Drawing.Size(150, 20);
            this.fld_txtPaymentAddressCountry.TabIndex = 26;
            this.fld_txtPaymentAddressCountry.Tag = "DC";
            // 
            // fld_txtPaymentAddressPostalCode
            // 
            this.fld_txtPaymentAddressPostalCode.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressPostalCode.BOSDataMember = "PaymentAddressPostalCode";
            this.fld_txtPaymentAddressPostalCode.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressPostalCode.BOSDescription = null;
            this.fld_txtPaymentAddressPostalCode.BOSError = null;
            this.fld_txtPaymentAddressPostalCode.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressPostalCode.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressPostalCode.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressPostalCode.BOSPropertyName = "Text";
            this.fld_txtPaymentAddressPostalCode.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPaymentAddressPostalCode.Location = new System.Drawing.Point(368, 85);
            this.fld_txtPaymentAddressPostalCode.Name = "fld_txtPaymentAddressPostalCode";
            this.fld_txtPaymentAddressPostalCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPaymentAddressPostalCode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPaymentAddressPostalCode.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPaymentAddressPostalCode.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPaymentAddressPostalCode.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPaymentAddressPostalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPaymentAddressPostalCode.Screen = null;
            this.fld_txtPaymentAddressPostalCode.Size = new System.Drawing.Size(105, 20);
            this.fld_txtPaymentAddressPostalCode.TabIndex = 27;
            this.fld_txtPaymentAddressPostalCode.Tag = "DC";
            // 
            // guiShippingInfo
            // 
            this.AcceptButton = this.fld_btnOK;
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(574, 532);
            this.ControlBox = true;
            this.Controls.Add(this.fld_grcPaymentAddress);
            this.Controls.Add(this.fld_grcBillAddress);
            this.Controls.Add(this.fld_grcShipAddress);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiShippingInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin giao hàng";
            this.Load += new System.EventHandler(this.guiShippingInfo_Load);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_grcShipAddress, 0);
            this.Controls.SetChildIndex(this.fld_grcBillAddress, 0);
            this.Controls.SetChildIndex(this.fld_grcPaymentAddress, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcBillAddress)).EndInit();
            this.fld_grcBillAddress.ResumeLayout(false);
            this.fld_grcBillAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBranchInvoiceID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtInvoiceAddressLine1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtInvoiceAddressCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtInvoiceAddressCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtInvoiceAddressPostalCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtInvoiceAddressStateProvince.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcShipAddress)).EndInit();
            this.fld_grcShipAddress.ResumeLayout(false);
            this.fld_grcShipAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBranchDeliveryID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkCopyBillAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDeliveryAddressLine1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDeliveryAddressCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDeliveryAddressStateProvince.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDeliveryAddressCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDeliveryAddressPostalCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcPaymentAddress)).EndInit();
            this.fld_grcPaymentAddress.ResumeLayout(false);
            this.fld_grcPaymentAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchPaymentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkCopyBillAddress1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPaymentAddressLine1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPaymentAddressCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPaymentAddressStateProvince.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPaymentAddressCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPaymentAddressPostalCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private IContainer components;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkCopyBillAddress;
        private BOSComponent.BOSGroupControl fld_grcPaymentAddress;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkCopyBillAddress1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtPaymentAddressLine1;
        private BOSComponent.BOSTextBox fld_txtPaymentAddressCity;
        private BOSComponent.BOSTextBox fld_txtPaymentAddressStateProvince;
        private BOSComponent.BOSTextBox fld_txtPaymentAddressCountry;
        private BOSComponent.BOSTextBox fld_txtPaymentAddressPostalCode;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeBranchInvoiceID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeBranchDeliveryID;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchPaymentID;
    }
}
