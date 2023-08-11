using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Supplier.UI
{
	/// <summary>
	/// Summary description for DMSP100
	/// </summary>
	partial class DMSP100
	{
        private BOSComponent.BOSLabel fld_lblLabel16;
		private BOSComponent.BOSLabel fld_lblLabel25;
		private BOSComponent.BOSLabel fld_lblLabel48;
		private BOSComponent.BOSLabel fld_lblLabel49;
		private BOSComponent.BOSLabel fld_lblLabel50;
		private BOSComponent.BOSLabel fld_lblLabel56;
		private BOSComponent.BOSTextBox fld_txtAPSupplierName2;
		private BOSComponent.BOSTextBox fld_txtAPSupplierContactPhone;
		private BOSComponent.BOSTextBox fld_txtAPSupplierContactFax;
		private BOSComponent.BOSTextBox fld_txtAPSupplierContactEmail1;
		private BOSComponent.BOSLabel fld_lblLabel102;
		private BOSComponent.BOSLookupEdit fld_lkeAPSupplierTypeCombo;
		private BOSComponent.BOSCheckEdit fld_chkAPSupplierActiveCheck;
		private BOSComponent.BOSGroupControl fld_grcGroupControl;
		private BOSComponent.BOSTextBox fld_txtAPSupplierNo1;
		private BOSComponent.BOSDateEdit fld_dteAPSupplierStartDate;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSTextBox fld_txtAPSupplierAddressLine1;
		private BOSComponent.BOSLabel fld_lblLabel7;
		private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private BOSComponent.BOSTextBox fld_txtAPSupplierAddressPostalCode;
        private BOSComponent.BOSGroupControl fld_grcGroupControl1;
		private BOSComponent.BOSLabel fld_lblLabel5;
		private BOSComponent.BOSLabel fld_lblLabel6;
		private BOSComponent.BOSLabel fld_lblLabel9;
		private BOSComponent.BOSTextBox fld_txtAPSupplierWebsite;
        private BOSComponent.BOSLabel fld_lblLabel11;
		private BOSComponent.BOSTextBox fld_txtAPSupplierBankName;
        private BOSComponent.BOSTextBox fld_txtAPSupplierBankAccount1;
        private BOSComponent.BOSTextBox fld_txtAPSupplierBankAccount2;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSLabel fld_lblLabel12;
		private BOSComponent.BOSLabel fld_lblLabel13;
		private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel15;
		private BOSComponent.BOSLookupEdit fld_lkeAPPaymentMethodCombo;
        private BOSComponent.BOSTextBox fld_txtAPSupplierTaxNumber;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMSP100));
            this.fld_lblLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel48 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel49 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel50 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel56 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPSupplierName2 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierContactPhone = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierContactFax = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierContactEmail1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel102 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPSupplierTypeCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_chkAPSupplierActiveCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcAPSupplierDepartments = new BOSERP.Modules.Supplier.APSupplierDepartmentsGridControl();
            this.fld_dgvGridControl1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosPanel3 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_APSupplierTypeAccountConfigID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountPurchaseID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountSaleID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPSuppliersDiscountType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel31 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GEDistrictID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GEStateProvinceID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GECountryID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtAPSupplierWebsite = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPSupplierAddressPostalCode = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierContactPhone1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteAPSupplierStartDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPSupplierAddressLine1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_clgName = new BOSERP.CollapsibleGroupBox();
            this.fld_txtAPSupplierNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_chkIsPaymentLocked = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_chkIsBuyingLocked = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_txtAPSupplierName1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPSupplierName21 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierName3 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_GEPaymentTermID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeAPSupplierBankAccountCurrency2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPSupplierBankAccountCurrency1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerDueDays = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierBankAccount1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID2 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtAPSupplierBankAccount2 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPPaymentMethodCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtAPSupplierTaxNumber = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierBankCode = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierBankName = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierName2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactEmail1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPSupplierTypeCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkAPSupplierActiveCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPSupplierDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.bosPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierTypeAccountConfigID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountPurchaseID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountSaleID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPSuppliersDiscountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEDistrictID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEStateProvinceID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECountryID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierWebsite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierAddressPostalCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactPhone1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPSupplierStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPSupplierStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierAddressLine1.Properties)).BeginInit();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkIsPaymentLocked.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkIsBuyingLocked.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierName21.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierName3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEPaymentTermID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPSupplierBankAccountCurrency2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPSupplierBankAccountCurrency1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerDueDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierBankAccount1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierBankAccount2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPaymentMethodCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierTaxNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierBankCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierBankName.Properties)).BeginInit();
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
            this.fld_lblLabel16.BOSPropertyName = "";
            this.fld_lblLabel16.Location = new System.Drawing.Point(11, 7);
            this.fld_lblLabel16.Name = "fld_lblLabel16";
            this.fld_lblLabel16.Screen = null;
            this.fld_lblLabel16.Size = new System.Drawing.Size(84, 13);
            this.fld_lblLabel16.TabIndex = 0;
            this.fld_lblLabel16.Tag = "";
            this.fld_lblLabel16.Text = "Mã nhà cung cấp";
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
            this.fld_lblLabel25.BOSPropertyName = "";
            this.fld_lblLabel25.Location = new System.Drawing.Point(11, 33);
            this.fld_lblLabel25.Name = "fld_lblLabel25";
            this.fld_lblLabel25.Screen = null;
            this.fld_lblLabel25.Size = new System.Drawing.Size(88, 13);
            this.fld_lblLabel25.TabIndex = 2;
            this.fld_lblLabel25.Tag = "";
            this.fld_lblLabel25.Text = "Tên nhà cung cấp";
            // 
            // fld_lblLabel48
            // 
            this.fld_lblLabel48.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel48.BOSPropertyName = "";
            this.fld_lblLabel48.Location = new System.Drawing.Point(12, 112);
            this.fld_lblLabel48.Name = "fld_lblLabel48";
            this.fld_lblLabel48.Screen = null;
            this.fld_lblLabel48.Size = new System.Drawing.Size(25, 13);
            this.fld_lblLabel48.TabIndex = 10;
            this.fld_lblLabel48.Tag = "";
            this.fld_lblLabel48.Text = "Email";
            // 
            // fld_lblLabel49
            // 
            this.fld_lblLabel49.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel49.BOSPropertyName = "";
            this.fld_lblLabel49.Location = new System.Drawing.Point(12, 31);
            this.fld_lblLabel49.Name = "fld_lblLabel49";
            this.fld_lblLabel49.Screen = null;
            this.fld_lblLabel49.Size = new System.Drawing.Size(57, 13);
            this.fld_lblLabel49.TabIndex = 4;
            this.fld_lblLabel49.Tag = "";
            this.fld_lblLabel49.Text = "Điện thoại 1";
            // 
            // fld_lblLabel50
            // 
            this.fld_lblLabel50.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel50.BOSPropertyName = "";
            this.fld_lblLabel50.Location = new System.Drawing.Point(11, 57);
            this.fld_lblLabel50.Name = "fld_lblLabel50";
            this.fld_lblLabel50.Screen = null;
            this.fld_lblLabel50.Size = new System.Drawing.Size(30, 13);
            this.fld_lblLabel50.TabIndex = 6;
            this.fld_lblLabel50.Tag = "";
            this.fld_lblLabel50.Text = "Số fax";
            // 
            // fld_lblLabel56
            // 
            this.fld_lblLabel56.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel56.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel56.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel56.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel56.Appearance.Options.UseFont = true;
            this.fld_lblLabel56.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel56.BOSComment = "";
            this.fld_lblLabel56.BOSDataMember = "";
            this.fld_lblLabel56.BOSDataSource = "";
            this.fld_lblLabel56.BOSDescription = null;
            this.fld_lblLabel56.BOSError = null;
            this.fld_lblLabel56.BOSFieldGroup = "";
            this.fld_lblLabel56.BOSFieldRelation = "";
            this.fld_lblLabel56.BOSPrivilege = "";
            this.fld_lblLabel56.BOSPropertyName = "";
            this.fld_lblLabel56.Location = new System.Drawing.Point(12, 190);
            this.fld_lblLabel56.Name = "fld_lblLabel56";
            this.fld_lblLabel56.Screen = null;
            this.fld_lblLabel56.Size = new System.Drawing.Size(68, 13);
            this.fld_lblLabel56.TabIndex = 14;
            this.fld_lblLabel56.Tag = "";
            this.fld_lblLabel56.Text = "Quận / Huyện";
            // 
            // fld_txtAPSupplierName2
            // 
            this.fld_txtAPSupplierName2.BOSComment = "";
            this.fld_txtAPSupplierName2.BOSDataMember = "APSupplierName";
            this.fld_txtAPSupplierName2.BOSDataSource = "APSuppliers";
            this.fld_txtAPSupplierName2.BOSDescription = null;
            this.fld_txtAPSupplierName2.BOSError = null;
            this.fld_txtAPSupplierName2.BOSFieldGroup = "";
            this.fld_txtAPSupplierName2.BOSFieldRelation = "";
            this.fld_txtAPSupplierName2.BOSPrivilege = "";
            this.fld_txtAPSupplierName2.BOSPropertyName = "Text";
            this.fld_txtAPSupplierName2.EditValue = "";
            this.fld_txtAPSupplierName2.Location = new System.Drawing.Point(115, 30);
            this.fld_txtAPSupplierName2.Name = "fld_txtAPSupplierName2";
            this.fld_txtAPSupplierName2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierName2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierName2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierName2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierName2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierName2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierName2.Screen = null;
            this.fld_txtAPSupplierName2.Size = new System.Drawing.Size(200, 20);
            this.fld_txtAPSupplierName2.TabIndex = 1;
            this.fld_txtAPSupplierName2.Tag = "DC";
            // 
            // fld_txtAPSupplierContactPhone
            // 
            this.fld_txtAPSupplierContactPhone.BOSComment = "";
            this.fld_txtAPSupplierContactPhone.BOSDataMember = "APSupplierContactPhone";
            this.fld_txtAPSupplierContactPhone.BOSDataSource = "APSuppliers";
            this.fld_txtAPSupplierContactPhone.BOSDescription = null;
            this.fld_txtAPSupplierContactPhone.BOSError = null;
            this.fld_txtAPSupplierContactPhone.BOSFieldGroup = "";
            this.fld_txtAPSupplierContactPhone.BOSFieldRelation = "";
            this.fld_txtAPSupplierContactPhone.BOSPrivilege = "";
            this.fld_txtAPSupplierContactPhone.BOSPropertyName = "Text";
            this.fld_txtAPSupplierContactPhone.EditValue = "";
            this.fld_txtAPSupplierContactPhone.Location = new System.Drawing.Point(115, 28);
            this.fld_txtAPSupplierContactPhone.Name = "fld_txtAPSupplierContactPhone";
            this.fld_txtAPSupplierContactPhone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierContactPhone.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierContactPhone.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierContactPhone.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierContactPhone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierContactPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierContactPhone.Screen = null;
            this.fld_txtAPSupplierContactPhone.Size = new System.Drawing.Size(125, 20);
            this.fld_txtAPSupplierContactPhone.TabIndex = 2;
            this.fld_txtAPSupplierContactPhone.Tag = "DC";
            // 
            // fld_txtAPSupplierContactFax
            // 
            this.fld_txtAPSupplierContactFax.BOSComment = "";
            this.fld_txtAPSupplierContactFax.BOSDataMember = "APSupplierContactFax";
            this.fld_txtAPSupplierContactFax.BOSDataSource = "APSuppliers";
            this.fld_txtAPSupplierContactFax.BOSDescription = null;
            this.fld_txtAPSupplierContactFax.BOSError = null;
            this.fld_txtAPSupplierContactFax.BOSFieldGroup = "";
            this.fld_txtAPSupplierContactFax.BOSFieldRelation = "";
            this.fld_txtAPSupplierContactFax.BOSPrivilege = "";
            this.fld_txtAPSupplierContactFax.BOSPropertyName = "Text";
            this.fld_txtAPSupplierContactFax.EditValue = "";
            this.fld_txtAPSupplierContactFax.Location = new System.Drawing.Point(115, 54);
            this.fld_txtAPSupplierContactFax.Name = "fld_txtAPSupplierContactFax";
            this.fld_txtAPSupplierContactFax.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierContactFax.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierContactFax.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierContactFax.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierContactFax.Properties.Mask.EditMask = "\\d+";
            this.fld_txtAPSupplierContactFax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.fld_txtAPSupplierContactFax.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierContactFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierContactFax.Screen = null;
            this.fld_txtAPSupplierContactFax.Size = new System.Drawing.Size(125, 20);
            this.fld_txtAPSupplierContactFax.TabIndex = 4;
            this.fld_txtAPSupplierContactFax.Tag = "DC";
            // 
            // fld_txtAPSupplierContactEmail1
            // 
            this.fld_txtAPSupplierContactEmail1.BOSComment = "";
            this.fld_txtAPSupplierContactEmail1.BOSDataMember = "APSupplierContactEmail1";
            this.fld_txtAPSupplierContactEmail1.BOSDataSource = "APSuppliers";
            this.fld_txtAPSupplierContactEmail1.BOSDescription = null;
            this.fld_txtAPSupplierContactEmail1.BOSError = null;
            this.fld_txtAPSupplierContactEmail1.BOSFieldGroup = "";
            this.fld_txtAPSupplierContactEmail1.BOSFieldRelation = "";
            this.fld_txtAPSupplierContactEmail1.BOSPrivilege = "";
            this.fld_txtAPSupplierContactEmail1.BOSPropertyName = "Text";
            this.fld_txtAPSupplierContactEmail1.EditValue = "";
            this.fld_txtAPSupplierContactEmail1.Location = new System.Drawing.Point(116, 109);
            this.fld_txtAPSupplierContactEmail1.Name = "fld_txtAPSupplierContactEmail1";
            this.fld_txtAPSupplierContactEmail1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierContactEmail1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierContactEmail1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierContactEmail1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierContactEmail1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierContactEmail1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierContactEmail1.Screen = null;
            this.fld_txtAPSupplierContactEmail1.Size = new System.Drawing.Size(371, 20);
            this.fld_txtAPSupplierContactEmail1.TabIndex = 7;
            this.fld_txtAPSupplierContactEmail1.Tag = "DC";
            // 
            // fld_lblLabel102
            // 
            this.fld_lblLabel102.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel102.BOSPropertyName = "";
            this.fld_lblLabel102.Location = new System.Drawing.Point(12, 7);
            this.fld_lblLabel102.Name = "fld_lblLabel102";
            this.fld_lblLabel102.Screen = null;
            this.fld_lblLabel102.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel102.TabIndex = 0;
            this.fld_lblLabel102.Tag = "";
            this.fld_lblLabel102.Text = "Loại";
            // 
            // fld_lkeAPSupplierTypeCombo
            // 
            this.fld_lkeAPSupplierTypeCombo.BOSAllowAddNew = false;
            this.fld_lkeAPSupplierTypeCombo.BOSAllowDummy = true;
            this.fld_lkeAPSupplierTypeCombo.BOSComment = "";
            this.fld_lkeAPSupplierTypeCombo.BOSDataMember = "APSupplierTypeCombo";
            this.fld_lkeAPSupplierTypeCombo.BOSDataSource = "APSuppliers";
            this.fld_lkeAPSupplierTypeCombo.BOSDescription = null;
            this.fld_lkeAPSupplierTypeCombo.BOSError = null;
            this.fld_lkeAPSupplierTypeCombo.BOSFieldGroup = "";
            this.fld_lkeAPSupplierTypeCombo.BOSFieldParent = "";
            this.fld_lkeAPSupplierTypeCombo.BOSFieldRelation = "";
            this.fld_lkeAPSupplierTypeCombo.BOSPrivilege = "";
            this.fld_lkeAPSupplierTypeCombo.BOSPropertyName = "EditValue";
            this.fld_lkeAPSupplierTypeCombo.BOSSelectType = "";
            this.fld_lkeAPSupplierTypeCombo.BOSSelectTypeValue = "";
            this.fld_lkeAPSupplierTypeCombo.CurrentDisplayText = null;
            this.fld_lkeAPSupplierTypeCombo.Location = new System.Drawing.Point(115, 4);
            this.fld_lkeAPSupplierTypeCombo.Name = "fld_lkeAPSupplierTypeCombo";
            this.fld_lkeAPSupplierTypeCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPSupplierTypeCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPSupplierTypeCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPSupplierTypeCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPSupplierTypeCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPSupplierTypeCombo.Properties.ColumnName = null;
            this.fld_lkeAPSupplierTypeCombo.Properties.NullText = "";
            this.fld_lkeAPSupplierTypeCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPSupplierTypeCombo.Screen = null;
            this.fld_lkeAPSupplierTypeCombo.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeAPSupplierTypeCombo.TabIndex = 0;
            this.fld_lkeAPSupplierTypeCombo.Tag = "DC";
            // 
            // fld_chkAPSupplierActiveCheck
            // 
            this.fld_chkAPSupplierActiveCheck.BOSComment = "";
            this.fld_chkAPSupplierActiveCheck.BOSDataMember = "APSupplierActiveCheck";
            this.fld_chkAPSupplierActiveCheck.BOSDataSource = "APSuppliers";
            this.fld_chkAPSupplierActiveCheck.BOSDescription = null;
            this.fld_chkAPSupplierActiveCheck.BOSError = null;
            this.fld_chkAPSupplierActiveCheck.BOSFieldGroup = "";
            this.fld_chkAPSupplierActiveCheck.BOSFieldRelation = "";
            this.fld_chkAPSupplierActiveCheck.BOSPrivilege = "";
            this.fld_chkAPSupplierActiveCheck.BOSPropertyName = "EditValue";
            this.fld_chkAPSupplierActiveCheck.Location = new System.Drawing.Point(114, 215);
            this.fld_chkAPSupplierActiveCheck.Name = "fld_chkAPSupplierActiveCheck";
            this.fld_chkAPSupplierActiveCheck.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkAPSupplierActiveCheck.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkAPSupplierActiveCheck.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkAPSupplierActiveCheck.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkAPSupplierActiveCheck.Properties.Caption = "Hoạt động";
            this.fld_chkAPSupplierActiveCheck.Screen = null;
            this.fld_chkAPSupplierActiveCheck.Size = new System.Drawing.Size(100, 20);
            this.fld_chkAPSupplierActiveCheck.TabIndex = 13;
            this.fld_chkAPSupplierActiveCheck.Tag = "DC";
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = "";
            this.fld_grcGroupControl.BOSDataMember = "";
            this.fld_grcGroupControl.BOSDataSource = "";
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = "";
            this.fld_grcGroupControl.BOSFieldRelation = "";
            this.fld_grcGroupControl.BOSPrivilege = "";
            this.fld_grcGroupControl.BOSPropertyName = "";
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcAPSupplierDepartments);
            this.fld_grcGroupControl.Controls.Add(this.bosPanel1);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(11, 12);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(865, 468);
            this.fld_grcGroupControl.TabIndex = 1;
            this.fld_grcGroupControl.Tag = "";
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // fld_dgcAPSupplierDepartments
            // 
            this.fld_dgcAPSupplierDepartments.AllowDrop = true;
            this.fld_dgcAPSupplierDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPSupplierDepartments.BOSComment = "";
            this.fld_dgcAPSupplierDepartments.BOSDataMember = "";
            this.fld_dgcAPSupplierDepartments.BOSDataSource = "APSupplierDepartments";
            this.fld_dgcAPSupplierDepartments.BOSDescription = null;
            this.fld_dgcAPSupplierDepartments.BOSError = null;
            this.fld_dgcAPSupplierDepartments.BOSFieldGroup = "";
            this.fld_dgcAPSupplierDepartments.BOSFieldRelation = "";
            this.fld_dgcAPSupplierDepartments.BOSGridType = null;
            this.fld_dgcAPSupplierDepartments.BOSPrivilege = "";
            this.fld_dgcAPSupplierDepartments.BOSPropertyName = "";
            this.fld_dgcAPSupplierDepartments.CommodityType = "";
            this.fld_dgcAPSupplierDepartments.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPSupplierDepartments.Location = new System.Drawing.Point(529, 25);
            this.fld_dgcAPSupplierDepartments.MainView = this.fld_dgvGridControl1;
            this.fld_dgcAPSupplierDepartments.Name = "fld_dgcAPSupplierDepartments";
            this.fld_dgcAPSupplierDepartments.PrintReport = false;
            this.fld_dgcAPSupplierDepartments.Screen = null;
            this.fld_dgcAPSupplierDepartments.Size = new System.Drawing.Size(326, 436);
            this.fld_dgcAPSupplierDepartments.TabIndex = 15;
            this.fld_dgcAPSupplierDepartments.Tag = "DC";
            this.fld_dgcAPSupplierDepartments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl1});
            // 
            // fld_dgvGridControl1
            // 
            this.fld_dgvGridControl1.GridControl = this.fld_dgcAPSupplierDepartments;
            this.fld_dgvGridControl1.Name = "fld_dgvGridControl1";
            this.fld_dgvGridControl1.PaintStyleName = "Office2003";
            // 
            // bosPanel1
            // 
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.bosPanel3);
            this.bosPanel1.Controls.Add(this.bosPanel2);
            this.bosPanel1.Location = new System.Drawing.Point(5, 25);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(507, 436);
            this.bosPanel1.TabIndex = 1;
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
            this.bosPanel3.Controls.Add(this.fld_lkeFK_APSupplierTypeAccountConfigID);
            this.bosPanel3.Controls.Add(this.bosLabel16);
            this.bosPanel3.Controls.Add(this.fld_lkeFK_ACAccountPurchaseID);
            this.bosPanel3.Controls.Add(this.bosLabel14);
            this.bosPanel3.Controls.Add(this.fld_lkeFK_ACAccountSaleID);
            this.bosPanel3.Controls.Add(this.bosLabel13);
            this.bosPanel3.Controls.Add(this.fld_lkeAPSuppliersDiscountType);
            this.bosPanel3.Controls.Add(this.bosLabel12);
            this.bosPanel3.Controls.Add(this.bosLabel9);
            this.bosPanel3.Controls.Add(this.bosTextBox2);
            this.bosPanel3.Controls.Add(this.bosLookupEdit1);
            this.bosPanel3.Controls.Add(this.bosLabel31);
            this.bosPanel3.Controls.Add(this.bosTextBox1);
            this.bosPanel3.Controls.Add(this.bosLabel7);
            this.bosPanel3.Controls.Add(this.fld_lkeFK_GEDistrictID);
            this.bosPanel3.Controls.Add(this.fld_lkeFK_GEStateProvinceID);
            this.bosPanel3.Controls.Add(this.fld_lkeFK_GECountryID);
            this.bosPanel3.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.bosPanel3.Controls.Add(this.fld_lblLabel56);
            this.bosPanel3.Controls.Add(this.fld_lkeAPSupplierTypeCombo);
            this.bosPanel3.Controls.Add(this.fld_lblLabel102);
            this.bosPanel3.Controls.Add(this.fld_txtAPSupplierWebsite);
            this.bosPanel3.Controls.Add(this.fld_txtAPSupplierContactEmail1);
            this.bosPanel3.Controls.Add(this.fld_lblLabel9);
            this.bosPanel3.Controls.Add(this.fld_txtAPSupplierContactFax);
            this.bosPanel3.Controls.Add(this.fld_chkAPSupplierActiveCheck);
            this.bosPanel3.Controls.Add(this.fld_txtAPSupplierAddressPostalCode);
            this.bosPanel3.Controls.Add(this.fld_txtAPSupplierContactPhone1);
            this.bosPanel3.Controls.Add(this.fld_txtAPSupplierContactPhone);
            this.bosPanel3.Controls.Add(this.fld_dteAPSupplierStartDate);
            this.bosPanel3.Controls.Add(this.fld_lblLabel2);
            this.bosPanel3.Controls.Add(this.fld_lblLabel10);
            this.bosPanel3.Controls.Add(this.fld_lblLabel8);
            this.bosPanel3.Controls.Add(this.fld_lblLabel3);
            this.bosPanel3.Controls.Add(this.fld_lblLabel48);
            this.bosPanel3.Controls.Add(this.bosLabel6);
            this.bosPanel3.Controls.Add(this.fld_lblLabel50);
            this.bosPanel3.Controls.Add(this.fld_lblLabel7);
            this.bosPanel3.Controls.Add(this.fld_txtAPSupplierAddressLine1);
            this.bosPanel3.Controls.Add(this.bosLabel5);
            this.bosPanel3.Controls.Add(this.fld_lblLabel49);
            this.bosPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel3.Location = new System.Drawing.Point(0, 75);
            this.bosPanel3.Name = "bosPanel3";
            this.bosPanel3.Screen = null;
            this.bosPanel3.Size = new System.Drawing.Size(507, 358);
            this.bosPanel3.TabIndex = 2;
            // 
            // fld_lkeFK_APSupplierTypeAccountConfigID
            // 
            this.fld_lkeFK_APSupplierTypeAccountConfigID.BOSAllowAddNew = false;
            this.fld_lkeFK_APSupplierTypeAccountConfigID.BOSAllowDummy = false;
            this.fld_lkeFK_APSupplierTypeAccountConfigID.BOSComment = "";
            this.fld_lkeFK_APSupplierTypeAccountConfigID.BOSDataMember = "FK_APSupplierTypeAccountConfigID";
            this.fld_lkeFK_APSupplierTypeAccountConfigID.BOSDataSource = "APSuppliers";
            this.fld_lkeFK_APSupplierTypeAccountConfigID.BOSDescription = null;
            this.fld_lkeFK_APSupplierTypeAccountConfigID.BOSError = "";
            this.fld_lkeFK_APSupplierTypeAccountConfigID.BOSFieldGroup = "";
            this.fld_lkeFK_APSupplierTypeAccountConfigID.BOSFieldParent = "";
            this.fld_lkeFK_APSupplierTypeAccountConfigID.BOSFieldRelation = "";
            this.fld_lkeFK_APSupplierTypeAccountConfigID.BOSPrivilege = "";
            this.fld_lkeFK_APSupplierTypeAccountConfigID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APSupplierTypeAccountConfigID.BOSSelectType = "";
            this.fld_lkeFK_APSupplierTypeAccountConfigID.BOSSelectTypeValue = "";
            this.fld_lkeFK_APSupplierTypeAccountConfigID.CurrentDisplayText = "";
            this.fld_lkeFK_APSupplierTypeAccountConfigID.Location = new System.Drawing.Point(115, 291);
            this.fld_lkeFK_APSupplierTypeAccountConfigID.Name = "fld_lkeFK_APSupplierTypeAccountConfigID";
            this.fld_lkeFK_APSupplierTypeAccountConfigID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_APSupplierTypeAccountConfigID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_APSupplierTypeAccountConfigID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_APSupplierTypeAccountConfigID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_APSupplierTypeAccountConfigID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APSupplierTypeAccountConfigID.Properties.ColumnName = null;
            this.fld_lkeFK_APSupplierTypeAccountConfigID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierTypeAccountConfigName", "Nhóm tài khoản")});
            this.fld_lkeFK_APSupplierTypeAccountConfigID.Properties.DisplayMember = "APSupplierTypeAccountConfigName";
            this.fld_lkeFK_APSupplierTypeAccountConfigID.Properties.NullText = "";
            this.fld_lkeFK_APSupplierTypeAccountConfigID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APSupplierTypeAccountConfigID.Properties.ValueMember = "APSupplierTypeAccountConfigID";
            this.fld_lkeFK_APSupplierTypeAccountConfigID.Screen = null;
            this.fld_lkeFK_APSupplierTypeAccountConfigID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_APSupplierTypeAccountConfigID.TabIndex = 33;
            this.fld_lkeFK_APSupplierTypeAccountConfigID.Tag = "DC";
            this.fld_lkeFK_APSupplierTypeAccountConfigID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_APSupplierTypeAccountConfigID_CloseUp);
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel16.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseFont = true;
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
            this.bosLabel16.Location = new System.Drawing.Point(12, 294);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(75, 13);
            this.bosLabel16.TabIndex = 34;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "Nhóm tài khoản";
            // 
            // fld_lkeFK_ACAccountPurchaseID
            // 
            this.fld_lkeFK_ACAccountPurchaseID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountPurchaseID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAccountPurchaseID.BOSComment = "";
            this.fld_lkeFK_ACAccountPurchaseID.BOSDataMember = "FK_ACAccountPurchaseID";
            this.fld_lkeFK_ACAccountPurchaseID.BOSDataSource = "APSuppliers";
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
            this.fld_lkeFK_ACAccountPurchaseID.Location = new System.Drawing.Point(360, 317);
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
            this.fld_lkeFK_ACAccountPurchaseID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_ACAccountPurchaseID.TabIndex = 19;
            this.fld_lkeFK_ACAccountPurchaseID.Tag = "DC";
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
            this.bosLabel14.Location = new System.Drawing.Point(291, 320);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(55, 13);
            this.bosLabel14.TabIndex = 32;
            this.bosLabel14.Tag = "";
            this.bosLabel14.Text = "TK CN mua";
            // 
            // fld_lkeFK_ACAccountSaleID
            // 
            this.fld_lkeFK_ACAccountSaleID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountSaleID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAccountSaleID.BOSComment = "";
            this.fld_lkeFK_ACAccountSaleID.BOSDataMember = "FK_ACAccountSaleID";
            this.fld_lkeFK_ACAccountSaleID.BOSDataSource = "APSuppliers";
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
            this.fld_lkeFK_ACAccountSaleID.Location = new System.Drawing.Point(115, 317);
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
            this.fld_lkeFK_ACAccountSaleID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_ACAccountSaleID.TabIndex = 18;
            this.fld_lkeFK_ACAccountSaleID.Tag = "DC";
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
            this.bosLabel13.Location = new System.Drawing.Point(12, 320);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(53, 13);
            this.bosLabel13.TabIndex = 30;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "TK CN bán";
            // 
            // fld_lkeAPSuppliersDiscountType
            // 
            this.fld_lkeAPSuppliersDiscountType.BOSAllowAddNew = false;
            this.fld_lkeAPSuppliersDiscountType.BOSAllowDummy = false;
            this.fld_lkeAPSuppliersDiscountType.BOSComment = "";
            this.fld_lkeAPSuppliersDiscountType.BOSDataMember = "APSuppliersDiscountType";
            this.fld_lkeAPSuppliersDiscountType.BOSDataSource = "APSuppliers";
            this.fld_lkeAPSuppliersDiscountType.BOSDescription = null;
            this.fld_lkeAPSuppliersDiscountType.BOSError = "";
            this.fld_lkeAPSuppliersDiscountType.BOSFieldGroup = "";
            this.fld_lkeAPSuppliersDiscountType.BOSFieldParent = "";
            this.fld_lkeAPSuppliersDiscountType.BOSFieldRelation = "";
            this.fld_lkeAPSuppliersDiscountType.BOSPrivilege = "";
            this.fld_lkeAPSuppliersDiscountType.BOSPropertyName = "EditValue";
            this.fld_lkeAPSuppliersDiscountType.BOSSelectType = "";
            this.fld_lkeAPSuppliersDiscountType.BOSSelectTypeValue = "";
            this.fld_lkeAPSuppliersDiscountType.CurrentDisplayText = "";
            this.fld_lkeAPSuppliersDiscountType.Location = new System.Drawing.Point(361, 213);
            this.fld_lkeAPSuppliersDiscountType.Name = "fld_lkeAPSuppliersDiscountType";
            this.fld_lkeAPSuppliersDiscountType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPSuppliersDiscountType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPSuppliersDiscountType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPSuppliersDiscountType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPSuppliersDiscountType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPSuppliersDiscountType.Properties.ColumnName = null;
            this.fld_lkeAPSuppliersDiscountType.Properties.NullText = "";
            this.fld_lkeAPSuppliersDiscountType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPSuppliersDiscountType.Screen = null;
            this.fld_lkeAPSuppliersDiscountType.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeAPSuppliersDiscountType.TabIndex = 14;
            this.fld_lkeAPSuppliersDiscountType.Tag = "DC";
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
            this.bosLabel12.Location = new System.Drawing.Point(291, 216);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(51, 13);
            this.bosLabel12.TabIndex = 28;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "Chiết khấu";
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
            this.bosLabel9.Location = new System.Drawing.Point(12, 268);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(62, 13);
            this.bosLabel9.TabIndex = 26;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "SWIFT Code";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = "";
            this.bosTextBox2.BOSDataMember = "APSupplierSWIFTCode";
            this.bosTextBox2.BOSDataSource = "APSuppliers";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = "";
            this.bosTextBox2.BOSFieldRelation = "";
            this.bosTextBox2.BOSPrivilege = "";
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.EditValue = "";
            this.bosTextBox2.Location = new System.Drawing.Point(116, 265);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox2, true);
            this.bosTextBox2.Size = new System.Drawing.Size(124, 20);
            this.bosTextBox2.TabIndex = 17;
            this.bosTextBox2.Tag = "DC";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = "";
            this.bosLookupEdit1.BOSDataMember = "FK_ACAccountID";
            this.bosLookupEdit1.BOSDataSource = "APSuppliers";
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
            this.bosLookupEdit1.Location = new System.Drawing.Point(360, 291);
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
            this.bosLookupEdit1.Size = new System.Drawing.Size(125, 20);
            this.bosLookupEdit1.TabIndex = 16;
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
            this.bosLabel31.Location = new System.Drawing.Point(291, 294);
            this.bosLabel31.Name = "bosLabel31";
            this.bosLabel31.Screen = null;
            this.bosLabel31.Size = new System.Drawing.Size(48, 13);
            this.bosLabel31.TabIndex = 24;
            this.bosLabel31.Tag = "";
            this.bosLabel31.Text = "Tài khoản";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "APSupplierNoOfOldSys";
            this.bosTextBox1.BOSDataSource = "APSuppliers";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.EditValue = "";
            this.bosTextBox1.Location = new System.Drawing.Point(115, 239);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox1, true);
            this.bosTextBox1.Size = new System.Drawing.Size(371, 20);
            this.bosTextBox1.TabIndex = 15;
            this.bosTextBox1.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseFont = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = "";
            this.bosLabel7.BOSDataMember = "";
            this.bosLabel7.BOSDataSource = "";
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = "";
            this.bosLabel7.BOSFieldRelation = "";
            this.bosLabel7.BOSPrivilege = "";
            this.bosLabel7.BOSPropertyName = "";
            this.bosLabel7.Location = new System.Drawing.Point(12, 239);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(48, 13);
            this.bosLabel7.TabIndex = 21;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Mã HT cũ";
            // 
            // fld_lkeFK_GEDistrictID
            // 
            this.fld_lkeFK_GEDistrictID.BOSAllowAddNew = true;
            this.fld_lkeFK_GEDistrictID.BOSAllowDummy = true;
            this.fld_lkeFK_GEDistrictID.BOSComment = null;
            this.fld_lkeFK_GEDistrictID.BOSDataMember = "FK_GEDistrictID";
            this.fld_lkeFK_GEDistrictID.BOSDataSource = "APSuppliers";
            this.fld_lkeFK_GEDistrictID.BOSDescription = null;
            this.fld_lkeFK_GEDistrictID.BOSError = null;
            this.fld_lkeFK_GEDistrictID.BOSFieldGroup = null;
            this.fld_lkeFK_GEDistrictID.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_GEDistrictID.BOSFieldRelation = null;
            this.fld_lkeFK_GEDistrictID.BOSPrivilege = null;
            this.fld_lkeFK_GEDistrictID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEDistrictID.BOSSelectType = null;
            this.fld_lkeFK_GEDistrictID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GEDistrictID.CurrentDisplayText = null;
            this.fld_lkeFK_GEDistrictID.Location = new System.Drawing.Point(115, 189);
            this.fld_lkeFK_GEDistrictID.Name = "fld_lkeFK_GEDistrictID";
            this.fld_lkeFK_GEDistrictID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEDistrictID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEDistrictID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEDistrictID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEDistrictID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEDistrictID.Properties.ColumnName = null;
            this.fld_lkeFK_GEDistrictID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEDistrictName", "Tên quận/ huyện")});
            this.fld_lkeFK_GEDistrictID.Properties.DisplayMember = "GEDistrictName";
            this.fld_lkeFK_GEDistrictID.Properties.NullText = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_GEDistrictID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GEDistrictID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEDistrictID.Properties.ValueMember = "GEDistrictID";
            this.fld_lkeFK_GEDistrictID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GEDistrictID, true);
            this.fld_lkeFK_GEDistrictID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_GEDistrictID.TabIndex = 11;
            this.fld_lkeFK_GEDistrictID.Tag = "DC";
            this.fld_lkeFK_GEDistrictID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_GEDistrictID_EditValueChanged);
            this.fld_lkeFK_GEDistrictID.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_lkeFK_GEDistrictID_EditValueChanging);
            // 
            // fld_lkeFK_GEStateProvinceID
            // 
            this.fld_lkeFK_GEStateProvinceID.BOSAllowAddNew = true;
            this.fld_lkeFK_GEStateProvinceID.BOSAllowDummy = false;
            this.fld_lkeFK_GEStateProvinceID.BOSComment = null;
            this.fld_lkeFK_GEStateProvinceID.BOSDataMember = "FK_GEStateProvinceID";
            this.fld_lkeFK_GEStateProvinceID.BOSDataSource = "APSuppliers";
            this.fld_lkeFK_GEStateProvinceID.BOSDescription = null;
            this.fld_lkeFK_GEStateProvinceID.BOSError = null;
            this.fld_lkeFK_GEStateProvinceID.BOSFieldGroup = null;
            this.fld_lkeFK_GEStateProvinceID.BOSFieldParent = "";
            this.fld_lkeFK_GEStateProvinceID.BOSFieldRelation = null;
            this.fld_lkeFK_GEStateProvinceID.BOSPrivilege = null;
            this.fld_lkeFK_GEStateProvinceID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEStateProvinceID.BOSSelectType = null;
            this.fld_lkeFK_GEStateProvinceID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GEStateProvinceID.CurrentDisplayText = null;
            this.fld_lkeFK_GEStateProvinceID.Location = new System.Drawing.Point(361, 161);
            this.fld_lkeFK_GEStateProvinceID.Name = "fld_lkeFK_GEStateProvinceID";
            this.fld_lkeFK_GEStateProvinceID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEStateProvinceID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEStateProvinceID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEStateProvinceID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEStateProvinceID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEStateProvinceID.Properties.ColumnName = null;
            this.fld_lkeFK_GEStateProvinceID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEStateProvinceName", "Tên tỉnh / thành")});
            this.fld_lkeFK_GEStateProvinceID.Properties.DisplayMember = "GEStateProvinceName";
            this.fld_lkeFK_GEStateProvinceID.Properties.NullText = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_GEStateProvinceID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GEStateProvinceID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEStateProvinceID.Properties.ValueMember = "GEStateProvinceID";
            this.fld_lkeFK_GEStateProvinceID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GEStateProvinceID, true);
            this.fld_lkeFK_GEStateProvinceID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_GEStateProvinceID.TabIndex = 10;
            this.fld_lkeFK_GEStateProvinceID.Tag = "DC";
            this.fld_lkeFK_GEStateProvinceID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_GEStateProvinceID_EditValueChanged);
            this.fld_lkeFK_GEStateProvinceID.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_lkeFK_GEStateProvinceID_EditValueChanging);
            // 
            // fld_lkeFK_GECountryID
            // 
            this.fld_lkeFK_GECountryID.BOSAllowAddNew = true;
            this.fld_lkeFK_GECountryID.BOSAllowDummy = false;
            this.fld_lkeFK_GECountryID.BOSComment = null;
            this.fld_lkeFK_GECountryID.BOSDataMember = "FK_GECountryID";
            this.fld_lkeFK_GECountryID.BOSDataSource = "APSuppliers";
            this.fld_lkeFK_GECountryID.BOSDescription = null;
            this.fld_lkeFK_GECountryID.BOSError = null;
            this.fld_lkeFK_GECountryID.BOSFieldGroup = null;
            this.fld_lkeFK_GECountryID.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_GECountryID.BOSFieldRelation = null;
            this.fld_lkeFK_GECountryID.BOSPrivilege = null;
            this.fld_lkeFK_GECountryID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECountryID.BOSSelectType = null;
            this.fld_lkeFK_GECountryID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GECountryID.CurrentDisplayText = null;
            this.fld_lkeFK_GECountryID.Location = new System.Drawing.Point(115, 163);
            this.fld_lkeFK_GECountryID.Name = "fld_lkeFK_GECountryID";
            this.fld_lkeFK_GECountryID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECountryID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECountryID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECountryID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECountryID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECountryID.Properties.ColumnName = null;
            this.fld_lkeFK_GECountryID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECountryName", "Tên quốc gia")});
            this.fld_lkeFK_GECountryID.Properties.DisplayMember = "GECountryName";
            this.fld_lkeFK_GECountryID.Properties.NullText = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_GECountryID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECountryID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECountryID.Properties.ValueMember = "GECountryID";
            this.fld_lkeFK_GECountryID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GECountryID, true);
            this.fld_lkeFK_GECountryID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_GECountryID.TabIndex = 9;
            this.fld_lkeFK_GECountryID.Tag = "DC";
            this.fld_lkeFK_GECountryID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_GECountryID_EditValueChanged);
            this.fld_lkeFK_GECountryID.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_lkeFK_GECountryID_EditValueChanging);
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = false;
            this.fld_lkeFK_BRBranchID.BOSComment = null;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "APSuppliers";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = null;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = null;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = null;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = null;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = null;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = null;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(361, 54);
            this.fld_lkeFK_BRBranchID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.ColumnName = null;
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(126, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 5;
            this.fld_lkeFK_BRBranchID.Tag = "DC";
            // 
            // fld_txtAPSupplierWebsite
            // 
            this.fld_txtAPSupplierWebsite.BOSComment = "";
            this.fld_txtAPSupplierWebsite.BOSDataMember = "APSupplierWebsite";
            this.fld_txtAPSupplierWebsite.BOSDataSource = "APSuppliers";
            this.fld_txtAPSupplierWebsite.BOSDescription = null;
            this.fld_txtAPSupplierWebsite.BOSError = null;
            this.fld_txtAPSupplierWebsite.BOSFieldGroup = "";
            this.fld_txtAPSupplierWebsite.BOSFieldRelation = "";
            this.fld_txtAPSupplierWebsite.BOSPrivilege = "";
            this.fld_txtAPSupplierWebsite.BOSPropertyName = "Text";
            this.fld_txtAPSupplierWebsite.EditValue = "<APSupplierWebsite>";
            this.fld_txtAPSupplierWebsite.Location = new System.Drawing.Point(115, 83);
            this.fld_txtAPSupplierWebsite.Name = "fld_txtAPSupplierWebsite";
            this.fld_txtAPSupplierWebsite.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierWebsite.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierWebsite.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierWebsite.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierWebsite.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierWebsite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierWebsite.Screen = null;
            this.fld_txtAPSupplierWebsite.Size = new System.Drawing.Size(371, 20);
            this.fld_txtAPSupplierWebsite.TabIndex = 6;
            this.fld_txtAPSupplierWebsite.Tag = "DC";
            // 
            // fld_lblLabel9
            // 
            this.fld_lblLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel9.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel9.BOSComment = "";
            this.fld_lblLabel9.BOSDataMember = "";
            this.fld_lblLabel9.BOSDataSource = "";
            this.fld_lblLabel9.BOSDescription = null;
            this.fld_lblLabel9.BOSError = null;
            this.fld_lblLabel9.BOSFieldGroup = "";
            this.fld_lblLabel9.BOSFieldRelation = "";
            this.fld_lblLabel9.BOSPrivilege = "";
            this.fld_lblLabel9.BOSPropertyName = "";
            this.fld_lblLabel9.Location = new System.Drawing.Point(12, 86);
            this.fld_lblLabel9.Name = "fld_lblLabel9";
            this.fld_lblLabel9.Screen = null;
            this.fld_lblLabel9.Size = new System.Drawing.Size(39, 13);
            this.fld_lblLabel9.TabIndex = 8;
            this.fld_lblLabel9.Tag = "";
            this.fld_lblLabel9.Text = "Website";
            // 
            // fld_txtAPSupplierAddressPostalCode
            // 
            this.fld_txtAPSupplierAddressPostalCode.BOSComment = "";
            this.fld_txtAPSupplierAddressPostalCode.BOSDataMember = "APSupplierContactAddressPostalCode";
            this.fld_txtAPSupplierAddressPostalCode.BOSDataSource = "APSuppliers";
            this.fld_txtAPSupplierAddressPostalCode.BOSDescription = null;
            this.fld_txtAPSupplierAddressPostalCode.BOSError = null;
            this.fld_txtAPSupplierAddressPostalCode.BOSFieldGroup = "";
            this.fld_txtAPSupplierAddressPostalCode.BOSFieldRelation = "";
            this.fld_txtAPSupplierAddressPostalCode.BOSPrivilege = "";
            this.fld_txtAPSupplierAddressPostalCode.BOSPropertyName = "Text";
            this.fld_txtAPSupplierAddressPostalCode.EditValue = "<APSupplierAddressPostalCode>";
            this.fld_txtAPSupplierAddressPostalCode.Location = new System.Drawing.Point(362, 187);
            this.fld_txtAPSupplierAddressPostalCode.Name = "fld_txtAPSupplierAddressPostalCode";
            this.fld_txtAPSupplierAddressPostalCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierAddressPostalCode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierAddressPostalCode.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierAddressPostalCode.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierAddressPostalCode.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierAddressPostalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierAddressPostalCode.Screen = null;
            this.fld_txtAPSupplierAddressPostalCode.Size = new System.Drawing.Size(124, 20);
            this.fld_txtAPSupplierAddressPostalCode.TabIndex = 12;
            this.fld_txtAPSupplierAddressPostalCode.Tag = "DC";
            // 
            // fld_txtAPSupplierContactPhone1
            // 
            this.fld_txtAPSupplierContactPhone1.BOSComment = "";
            this.fld_txtAPSupplierContactPhone1.BOSDataMember = "APSupplierContactPhone1";
            this.fld_txtAPSupplierContactPhone1.BOSDataSource = "APSuppliers";
            this.fld_txtAPSupplierContactPhone1.BOSDescription = null;
            this.fld_txtAPSupplierContactPhone1.BOSError = null;
            this.fld_txtAPSupplierContactPhone1.BOSFieldGroup = "";
            this.fld_txtAPSupplierContactPhone1.BOSFieldRelation = "";
            this.fld_txtAPSupplierContactPhone1.BOSPrivilege = "";
            this.fld_txtAPSupplierContactPhone1.BOSPropertyName = "Text";
            this.fld_txtAPSupplierContactPhone1.EditValue = "";
            this.fld_txtAPSupplierContactPhone1.Location = new System.Drawing.Point(361, 28);
            this.fld_txtAPSupplierContactPhone1.Name = "fld_txtAPSupplierContactPhone1";
            this.fld_txtAPSupplierContactPhone1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierContactPhone1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierContactPhone1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierContactPhone1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierContactPhone1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierContactPhone1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierContactPhone1.Screen = null;
            this.fld_txtAPSupplierContactPhone1.Size = new System.Drawing.Size(125, 20);
            this.fld_txtAPSupplierContactPhone1.TabIndex = 3;
            this.fld_txtAPSupplierContactPhone1.Tag = "DC";
            // 
            // fld_dteAPSupplierStartDate
            // 
            this.fld_dteAPSupplierStartDate.BOSComment = "";
            this.fld_dteAPSupplierStartDate.BOSDataMember = "APSupplierStartDate";
            this.fld_dteAPSupplierStartDate.BOSDataSource = "APSuppliers";
            this.fld_dteAPSupplierStartDate.BOSDescription = null;
            this.fld_dteAPSupplierStartDate.BOSError = null;
            this.fld_dteAPSupplierStartDate.BOSFieldGroup = "";
            this.fld_dteAPSupplierStartDate.BOSFieldRelation = "";
            this.fld_dteAPSupplierStartDate.BOSPrivilege = "";
            this.fld_dteAPSupplierStartDate.BOSPropertyName = "EditValue";
            this.fld_dteAPSupplierStartDate.EditValue = null;
            this.fld_dteAPSupplierStartDate.Location = new System.Drawing.Point(361, 4);
            this.fld_dteAPSupplierStartDate.Name = "fld_dteAPSupplierStartDate";
            this.fld_dteAPSupplierStartDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPSupplierStartDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPSupplierStartDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPSupplierStartDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPSupplierStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPSupplierStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPSupplierStartDate.Screen = null;
            this.fld_dteAPSupplierStartDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteAPSupplierStartDate.TabIndex = 1;
            this.fld_dteAPSupplierStartDate.Tag = "DC";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseFont = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = "";
            this.fld_lblLabel2.BOSDataMember = "";
            this.fld_lblLabel2.BOSDataSource = "";
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = "";
            this.fld_lblLabel2.BOSFieldRelation = "";
            this.fld_lblLabel2.BOSPrivilege = "";
            this.fld_lblLabel2.BOSPropertyName = "";
            this.fld_lblLabel2.Location = new System.Drawing.Point(267, 7);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel2.TabIndex = 2;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Ngày bắt đầu";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = "";
            this.fld_lblLabel10.BOSDataMember = "";
            this.fld_lblLabel10.BOSDataSource = "";
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = "";
            this.fld_lblLabel10.BOSFieldRelation = "";
            this.fld_lblLabel10.BOSPrivilege = "";
            this.fld_lblLabel10.BOSPropertyName = "";
            this.fld_lblLabel10.Location = new System.Drawing.Point(291, 164);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(42, 13);
            this.fld_lblLabel10.TabIndex = 16;
            this.fld_lblLabel10.Tag = "";
            this.fld_lblLabel10.Text = "Tỉnh / TP";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = "";
            this.fld_lblLabel8.BOSDataMember = "";
            this.fld_lblLabel8.BOSDataSource = "";
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = "";
            this.fld_lblLabel8.BOSFieldRelation = "";
            this.fld_lblLabel8.BOSPrivilege = "";
            this.fld_lblLabel8.BOSPropertyName = "";
            this.fld_lblLabel8.Location = new System.Drawing.Point(291, 190);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(41, 13);
            this.fld_lblLabel8.TabIndex = 20;
            this.fld_lblLabel8.Tag = "";
            this.fld_lblLabel8.Text = "Mã vùng";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseFont = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = "";
            this.fld_lblLabel3.BOSDataMember = "";
            this.fld_lblLabel3.BOSDataSource = "";
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = "";
            this.fld_lblLabel3.BOSFieldRelation = "";
            this.fld_lblLabel3.BOSPrivilege = "";
            this.fld_lblLabel3.BOSPropertyName = "";
            this.fld_lblLabel3.Location = new System.Drawing.Point(12, 138);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(33, 13);
            this.fld_lblLabel3.TabIndex = 12;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Địa chỉ";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel6.BOSPropertyName = "";
            this.bosLabel6.Location = new System.Drawing.Point(267, 57);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 6;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Chi nhánh";
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
            this.fld_lblLabel7.Location = new System.Drawing.Point(12, 164);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(42, 13);
            this.fld_lblLabel7.TabIndex = 18;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Quốc gia";
            // 
            // fld_txtAPSupplierAddressLine1
            // 
            this.fld_txtAPSupplierAddressLine1.BOSComment = "";
            this.fld_txtAPSupplierAddressLine1.BOSDataMember = "APSupplierContactAddressLine1";
            this.fld_txtAPSupplierAddressLine1.BOSDataSource = "APSuppliers";
            this.fld_txtAPSupplierAddressLine1.BOSDescription = null;
            this.fld_txtAPSupplierAddressLine1.BOSError = null;
            this.fld_txtAPSupplierAddressLine1.BOSFieldGroup = "";
            this.fld_txtAPSupplierAddressLine1.BOSFieldRelation = "";
            this.fld_txtAPSupplierAddressLine1.BOSPrivilege = "";
            this.fld_txtAPSupplierAddressLine1.BOSPropertyName = "Text";
            this.fld_txtAPSupplierAddressLine1.EditValue = "";
            this.fld_txtAPSupplierAddressLine1.Location = new System.Drawing.Point(116, 135);
            this.fld_txtAPSupplierAddressLine1.Name = "fld_txtAPSupplierAddressLine1";
            this.fld_txtAPSupplierAddressLine1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierAddressLine1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierAddressLine1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierAddressLine1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierAddressLine1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierAddressLine1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierAddressLine1.Screen = null;
            this.fld_txtAPSupplierAddressLine1.Size = new System.Drawing.Size(370, 20);
            this.fld_txtAPSupplierAddressLine1.TabIndex = 8;
            this.fld_txtAPSupplierAddressLine1.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseFont = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = "";
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = "";
            this.bosLabel5.BOSPrivilege = "";
            this.bosLabel5.BOSPropertyName = "";
            this.bosLabel5.Location = new System.Drawing.Point(267, 31);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(57, 13);
            this.bosLabel5.TabIndex = 4;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Điện thoại 2";
            // 
            // bosPanel2
            // 
            this.bosPanel2.AutoSize = true;
            this.bosPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.bosLookupEdit2);
            this.bosPanel2.Controls.Add(this.bosLabel15);
            this.bosPanel2.Controls.Add(this.fld_clgName);
            this.bosPanel2.Controls.Add(this.fld_txtAPSupplierNo1);
            this.bosPanel2.Controls.Add(this.fld_txtAPSupplierName2);
            this.bosPanel2.Controls.Add(this.fld_lblLabel25);
            this.bosPanel2.Controls.Add(this.fld_lblLabel16);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(507, 75);
            this.bosPanel2.TabIndex = 1;
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = true;
            this.bosLookupEdit2.BOSComment = "";
            this.bosLookupEdit2.BOSDataMember = "APSupplierOtherType";
            this.bosLookupEdit2.BOSDataSource = "APSuppliers";
            this.bosLookupEdit2.BOSDescription = null;
            this.bosLookupEdit2.BOSError = null;
            this.bosLookupEdit2.BOSFieldGroup = "";
            this.bosLookupEdit2.BOSFieldParent = "";
            this.bosLookupEdit2.BOSFieldRelation = "";
            this.bosLookupEdit2.BOSPrivilege = "";
            this.bosLookupEdit2.BOSPropertyName = "EditValue";
            this.bosLookupEdit2.BOSSelectType = "";
            this.bosLookupEdit2.BOSSelectTypeValue = "";
            this.bosLookupEdit2.CurrentDisplayText = null;
            this.bosLookupEdit2.Location = new System.Drawing.Point(384, 30);
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
            this.bosLookupEdit2.Size = new System.Drawing.Size(101, 20);
            this.bosLookupEdit2.TabIndex = 33;
            this.bosLookupEdit2.Tag = "DC";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseFont = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = "";
            this.bosLabel15.BOSDataMember = "";
            this.bosLabel15.BOSDataSource = "";
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = "";
            this.bosLabel15.BOSFieldRelation = "";
            this.bosLabel15.BOSPrivilege = "";
            this.bosLabel15.BOSPropertyName = "";
            this.bosLabel15.Location = new System.Drawing.Point(330, 33);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(45, 13);
            this.bosLabel15.TabIndex = 382;
            this.bosLabel15.Tag = "";
            this.bosLabel15.Text = "Loại NCC";
            // 
            // fld_clgName
            // 
            this.fld_clgName.Location = new System.Drawing.Point(12, 52);
            this.fld_clgName.Name = "fld_clgName";
            this.fld_clgName.Size = new System.Drawing.Size(200, 20);
            this.fld_clgName.TabIndex = 381;
            this.fld_clgName.TabStop = false;
            // 
            // fld_txtAPSupplierNo1
            // 
            this.fld_txtAPSupplierNo1.BOSComment = "";
            this.fld_txtAPSupplierNo1.BOSDataMember = "APSupplierNo";
            this.fld_txtAPSupplierNo1.BOSDataSource = "APSuppliers";
            this.fld_txtAPSupplierNo1.BOSDescription = null;
            this.fld_txtAPSupplierNo1.BOSError = null;
            this.fld_txtAPSupplierNo1.BOSFieldGroup = "";
            this.fld_txtAPSupplierNo1.BOSFieldRelation = "";
            this.fld_txtAPSupplierNo1.BOSPrivilege = "";
            this.fld_txtAPSupplierNo1.BOSPropertyName = "Text";
            this.fld_txtAPSupplierNo1.EditValue = "";
            this.fld_txtAPSupplierNo1.Location = new System.Drawing.Point(115, 4);
            this.fld_txtAPSupplierNo1.Name = "fld_txtAPSupplierNo1";
            this.fld_txtAPSupplierNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierNo1.Screen = null;
            this.fld_txtAPSupplierNo1.Size = new System.Drawing.Size(371, 20);
            this.fld_txtAPSupplierNo1.TabIndex = 0;
            this.fld_txtAPSupplierNo1.Tag = "DC";
            // 
            // fld_chkIsPaymentLocked
            // 
            this.fld_chkIsPaymentLocked.BOSComment = "";
            this.fld_chkIsPaymentLocked.BOSDataMember = "IsPaymentLocked";
            this.fld_chkIsPaymentLocked.BOSDataSource = "APSuppliers";
            this.fld_chkIsPaymentLocked.BOSDescription = null;
            this.fld_chkIsPaymentLocked.BOSError = null;
            this.fld_chkIsPaymentLocked.BOSFieldGroup = "";
            this.fld_chkIsPaymentLocked.BOSFieldRelation = "";
            this.fld_chkIsPaymentLocked.BOSPrivilege = "";
            this.fld_chkIsPaymentLocked.BOSPropertyName = "EditValue";
            this.fld_chkIsPaymentLocked.Location = new System.Drawing.Point(683, 25);
            this.fld_chkIsPaymentLocked.Name = "fld_chkIsPaymentLocked";
            this.fld_chkIsPaymentLocked.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkIsPaymentLocked.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkIsPaymentLocked.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkIsPaymentLocked.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkIsPaymentLocked.Properties.Caption = "Khóa thanh toán";
            this.fld_chkIsPaymentLocked.Screen = null;
            this.fld_chkIsPaymentLocked.Size = new System.Drawing.Size(112, 20);
            this.fld_chkIsPaymentLocked.TabIndex = 2;
            this.fld_chkIsPaymentLocked.Tag = "DC";
            // 
            // fld_chkIsBuyingLocked
            // 
            this.fld_chkIsBuyingLocked.BOSComment = "";
            this.fld_chkIsBuyingLocked.BOSDataMember = "IsBuyingLocked";
            this.fld_chkIsBuyingLocked.BOSDataSource = "APSuppliers";
            this.fld_chkIsBuyingLocked.BOSDescription = null;
            this.fld_chkIsBuyingLocked.BOSError = null;
            this.fld_chkIsBuyingLocked.BOSFieldGroup = "";
            this.fld_chkIsBuyingLocked.BOSFieldRelation = "";
            this.fld_chkIsBuyingLocked.BOSPrivilege = "";
            this.fld_chkIsBuyingLocked.BOSPropertyName = "EditValue";
            this.fld_chkIsBuyingLocked.Location = new System.Drawing.Point(683, 51);
            this.fld_chkIsBuyingLocked.Name = "fld_chkIsBuyingLocked";
            this.fld_chkIsBuyingLocked.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkIsBuyingLocked.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkIsBuyingLocked.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkIsBuyingLocked.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkIsBuyingLocked.Properties.Caption = "Khóa mua hàng";
            this.fld_chkIsBuyingLocked.Screen = null;
            this.fld_chkIsBuyingLocked.Size = new System.Drawing.Size(100, 20);
            this.fld_chkIsBuyingLocked.TabIndex = 5;
            this.fld_chkIsBuyingLocked.Tag = "DC";
            // 
            // fld_txtAPSupplierName1
            // 
            this.fld_txtAPSupplierName1.BOSComment = "";
            this.fld_txtAPSupplierName1.BOSDataMember = "APSupplierName1";
            this.fld_txtAPSupplierName1.BOSDataSource = "APSuppliers";
            this.fld_txtAPSupplierName1.BOSDescription = null;
            this.fld_txtAPSupplierName1.BOSError = null;
            this.fld_txtAPSupplierName1.BOSFieldGroup = "";
            this.fld_txtAPSupplierName1.BOSFieldRelation = "";
            this.fld_txtAPSupplierName1.BOSPrivilege = "";
            this.fld_txtAPSupplierName1.BOSPropertyName = "Text";
            this.fld_txtAPSupplierName1.EditValue = "";
            this.fld_txtAPSupplierName1.Location = new System.Drawing.Point(115, 13);
            this.fld_txtAPSupplierName1.Name = "fld_txtAPSupplierName1";
            this.fld_txtAPSupplierName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierName1.Screen = null;
            this.fld_txtAPSupplierName1.Size = new System.Drawing.Size(371, 20);
            this.fld_txtAPSupplierName1.TabIndex = 1;
            this.fld_txtAPSupplierName1.Tag = "DC";
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
            this.bosLabel3.BOSPropertyName = "";
            this.bosLabel3.Location = new System.Drawing.Point(11, 66);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(55, 13);
            this.bosLabel3.TabIndex = 4;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Tên khác 3";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = "";
            this.bosLabel1.Location = new System.Drawing.Point(11, 16);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(55, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Tên khác 1";
            // 
            // fld_txtAPSupplierName21
            // 
            this.fld_txtAPSupplierName21.BOSComment = "";
            this.fld_txtAPSupplierName21.BOSDataMember = "APSupplierName2";
            this.fld_txtAPSupplierName21.BOSDataSource = "APSuppliers";
            this.fld_txtAPSupplierName21.BOSDescription = null;
            this.fld_txtAPSupplierName21.BOSError = null;
            this.fld_txtAPSupplierName21.BOSFieldGroup = "";
            this.fld_txtAPSupplierName21.BOSFieldRelation = "";
            this.fld_txtAPSupplierName21.BOSPrivilege = "";
            this.fld_txtAPSupplierName21.BOSPropertyName = "Text";
            this.fld_txtAPSupplierName21.EditValue = "";
            this.fld_txtAPSupplierName21.Location = new System.Drawing.Point(115, 39);
            this.fld_txtAPSupplierName21.Name = "fld_txtAPSupplierName21";
            this.fld_txtAPSupplierName21.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierName21.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierName21.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierName21.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierName21.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierName21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierName21.Screen = null;
            this.fld_txtAPSupplierName21.Size = new System.Drawing.Size(371, 20);
            this.fld_txtAPSupplierName21.TabIndex = 3;
            this.fld_txtAPSupplierName21.Tag = "DC";
            // 
            // fld_txtAPSupplierName3
            // 
            this.fld_txtAPSupplierName3.BOSComment = "";
            this.fld_txtAPSupplierName3.BOSDataMember = "APSupplierName3";
            this.fld_txtAPSupplierName3.BOSDataSource = "APSuppliers";
            this.fld_txtAPSupplierName3.BOSDescription = null;
            this.fld_txtAPSupplierName3.BOSError = null;
            this.fld_txtAPSupplierName3.BOSFieldGroup = "";
            this.fld_txtAPSupplierName3.BOSFieldRelation = "";
            this.fld_txtAPSupplierName3.BOSPrivilege = "";
            this.fld_txtAPSupplierName3.BOSPropertyName = "Text";
            this.fld_txtAPSupplierName3.EditValue = "";
            this.fld_txtAPSupplierName3.Location = new System.Drawing.Point(115, 63);
            this.fld_txtAPSupplierName3.Name = "fld_txtAPSupplierName3";
            this.fld_txtAPSupplierName3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierName3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierName3.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierName3.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierName3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierName3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierName3.Screen = null;
            this.fld_txtAPSupplierName3.Size = new System.Drawing.Size(371, 20);
            this.fld_txtAPSupplierName3.TabIndex = 5;
            this.fld_txtAPSupplierName3.Tag = "DC";
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
            this.bosLabel2.BOSPropertyName = "";
            this.bosLabel2.Location = new System.Drawing.Point(11, 42);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(55, 13);
            this.bosLabel2.TabIndex = 2;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Tên khác 2";
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl1.BOSComment = "";
            this.fld_grcGroupControl1.BOSDataMember = "";
            this.fld_grcGroupControl1.BOSDataSource = "";
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = "";
            this.fld_grcGroupControl1.BOSFieldRelation = "";
            this.fld_grcGroupControl1.BOSPrivilege = "";
            this.fld_grcGroupControl1.BOSPropertyName = "";
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_GEPaymentTermID);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeAPSupplierBankAccountCurrency2);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel11);
            this.fld_grcGroupControl1.Controls.Add(this.fld_chkIsPaymentLocked);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeAPSupplierBankAccountCurrency1);
            this.fld_grcGroupControl1.Controls.Add(this.fld_chkIsBuyingLocked);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel10);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtARCustomerDueDays);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtAPSupplierBankAccount1);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel15);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_GECurrencyID2);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtAPSupplierBankAccount2);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel12);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel1);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel14);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel5);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel6);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel13);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel8);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel11);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeAPPaymentMethodCombo);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtAPSupplierTaxNumber);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtAPSupplierBankCode);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtAPSupplierBankName);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(11, 486);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(864, 214);
            this.fld_grcGroupControl1.TabIndex = 2;
            this.fld_grcGroupControl1.Tag = "";
            this.fld_grcGroupControl1.Text = "Thông tin giao dịch";
            // 
            // fld_lkeFK_GEPaymentTermID
            // 
            this.fld_lkeFK_GEPaymentTermID.BOSAllowAddNew = false;
            this.fld_lkeFK_GEPaymentTermID.BOSAllowDummy = false;
            this.fld_lkeFK_GEPaymentTermID.BOSComment = "";
            this.fld_lkeFK_GEPaymentTermID.BOSDataMember = "FK_GEPaymentTermID";
            this.fld_lkeFK_GEPaymentTermID.BOSDataSource = "APSuppliers";
            this.fld_lkeFK_GEPaymentTermID.BOSDescription = null;
            this.fld_lkeFK_GEPaymentTermID.BOSError = null;
            this.fld_lkeFK_GEPaymentTermID.BOSFieldGroup = "";
            this.fld_lkeFK_GEPaymentTermID.BOSFieldParent = "";
            this.fld_lkeFK_GEPaymentTermID.BOSFieldRelation = "";
            this.fld_lkeFK_GEPaymentTermID.BOSPrivilege = "";
            this.fld_lkeFK_GEPaymentTermID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEPaymentTermID.BOSSelectType = "";
            this.fld_lkeFK_GEPaymentTermID.BOSSelectTypeValue = "";
            this.fld_lkeFK_GEPaymentTermID.CurrentDisplayText = null;
            this.fld_lkeFK_GEPaymentTermID.Location = new System.Drawing.Point(154, 85);
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
            this.fld_lkeFK_GEPaymentTermID.Size = new System.Drawing.Size(411, 20);
            this.fld_lkeFK_GEPaymentTermID.TabIndex = 404;
            this.fld_lkeFK_GEPaymentTermID.Tag = "DC";
            // 
            // fld_lkeAPSupplierBankAccountCurrency2
            // 
            this.fld_lkeAPSupplierBankAccountCurrency2.BOSAllowAddNew = false;
            this.fld_lkeAPSupplierBankAccountCurrency2.BOSAllowDummy = false;
            this.fld_lkeAPSupplierBankAccountCurrency2.BOSComment = "";
            this.fld_lkeAPSupplierBankAccountCurrency2.BOSDataMember = "APSupplierBankAccountCurrency2";
            this.fld_lkeAPSupplierBankAccountCurrency2.BOSDataSource = "APSuppliers";
            this.fld_lkeAPSupplierBankAccountCurrency2.BOSDescription = null;
            this.fld_lkeAPSupplierBankAccountCurrency2.BOSError = null;
            this.fld_lkeAPSupplierBankAccountCurrency2.BOSFieldGroup = "";
            this.fld_lkeAPSupplierBankAccountCurrency2.BOSFieldParent = "";
            this.fld_lkeAPSupplierBankAccountCurrency2.BOSFieldRelation = "";
            this.fld_lkeAPSupplierBankAccountCurrency2.BOSPrivilege = "";
            this.fld_lkeAPSupplierBankAccountCurrency2.BOSPropertyName = "EditValue";
            this.fld_lkeAPSupplierBankAccountCurrency2.BOSSelectType = "";
            this.fld_lkeAPSupplierBankAccountCurrency2.BOSSelectTypeValue = "";
            this.fld_lkeAPSupplierBankAccountCurrency2.CurrentDisplayText = null;
            this.fld_lkeAPSupplierBankAccountCurrency2.Location = new System.Drawing.Point(415, 165);
            this.fld_lkeAPSupplierBankAccountCurrency2.Name = "fld_lkeAPSupplierBankAccountCurrency2";
            this.fld_lkeAPSupplierBankAccountCurrency2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPSupplierBankAccountCurrency2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPSupplierBankAccountCurrency2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPSupplierBankAccountCurrency2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPSupplierBankAccountCurrency2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPSupplierBankAccountCurrency2.Properties.ColumnName = null;
            this.fld_lkeAPSupplierBankAccountCurrency2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyNo", "Mã tiền tệ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeAPSupplierBankAccountCurrency2.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeAPSupplierBankAccountCurrency2.Properties.NullText = "";
            this.fld_lkeAPSupplierBankAccountCurrency2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPSupplierBankAccountCurrency2.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeAPSupplierBankAccountCurrency2.Screen = null;
            this.fld_lkeAPSupplierBankAccountCurrency2.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPSupplierBankAccountCurrency2.TabIndex = 11;
            this.fld_lkeAPSupplierBankAccountCurrency2.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
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
            this.bosLabel11.Location = new System.Drawing.Point(571, 62);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(24, 13);
            this.bosLabel11.TabIndex = 403;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "ngày";
            // 
            // fld_lkeAPSupplierBankAccountCurrency1
            // 
            this.fld_lkeAPSupplierBankAccountCurrency1.BOSAllowAddNew = false;
            this.fld_lkeAPSupplierBankAccountCurrency1.BOSAllowDummy = false;
            this.fld_lkeAPSupplierBankAccountCurrency1.BOSComment = "";
            this.fld_lkeAPSupplierBankAccountCurrency1.BOSDataMember = "APSupplierBankAccountCurrency1";
            this.fld_lkeAPSupplierBankAccountCurrency1.BOSDataSource = "APSuppliers";
            this.fld_lkeAPSupplierBankAccountCurrency1.BOSDescription = null;
            this.fld_lkeAPSupplierBankAccountCurrency1.BOSError = null;
            this.fld_lkeAPSupplierBankAccountCurrency1.BOSFieldGroup = "";
            this.fld_lkeAPSupplierBankAccountCurrency1.BOSFieldParent = "";
            this.fld_lkeAPSupplierBankAccountCurrency1.BOSFieldRelation = "";
            this.fld_lkeAPSupplierBankAccountCurrency1.BOSPrivilege = "";
            this.fld_lkeAPSupplierBankAccountCurrency1.BOSPropertyName = "EditValue";
            this.fld_lkeAPSupplierBankAccountCurrency1.BOSSelectType = "";
            this.fld_lkeAPSupplierBankAccountCurrency1.BOSSelectTypeValue = "";
            this.fld_lkeAPSupplierBankAccountCurrency1.CurrentDisplayText = null;
            this.fld_lkeAPSupplierBankAccountCurrency1.Location = new System.Drawing.Point(415, 137);
            this.fld_lkeAPSupplierBankAccountCurrency1.Name = "fld_lkeAPSupplierBankAccountCurrency1";
            this.fld_lkeAPSupplierBankAccountCurrency1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPSupplierBankAccountCurrency1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPSupplierBankAccountCurrency1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPSupplierBankAccountCurrency1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPSupplierBankAccountCurrency1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPSupplierBankAccountCurrency1.Properties.ColumnName = null;
            this.fld_lkeAPSupplierBankAccountCurrency1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyNo", "Mã tiền tệ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeAPSupplierBankAccountCurrency1.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeAPSupplierBankAccountCurrency1.Properties.NullText = "";
            this.fld_lkeAPSupplierBankAccountCurrency1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPSupplierBankAccountCurrency1.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeAPSupplierBankAccountCurrency1.Screen = null;
            this.fld_lkeAPSupplierBankAccountCurrency1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPSupplierBankAccountCurrency1.TabIndex = 9;
            this.fld_lkeAPSupplierBankAccountCurrency1.Tag = "DC";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = "";
            this.bosLabel10.BOSDataMember = "";
            this.bosLabel10.BOSDataSource = "";
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = "";
            this.bosLabel10.BOSFieldRelation = "";
            this.bosLabel10.BOSPrivilege = "";
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(327, 62);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(68, 13);
            this.bosLabel10.TabIndex = 8;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Kỳ thanh toán";
            // 
            // fld_txtARCustomerDueDays
            // 
            this.fld_txtARCustomerDueDays.BOSComment = "";
            this.fld_txtARCustomerDueDays.BOSDataMember = "APSupplierDueDays";
            this.fld_txtARCustomerDueDays.BOSDataSource = "APSuppliers";
            this.fld_txtARCustomerDueDays.BOSDescription = null;
            this.fld_txtARCustomerDueDays.BOSError = "";
            this.fld_txtARCustomerDueDays.BOSFieldGroup = "";
            this.fld_txtARCustomerDueDays.BOSFieldRelation = "";
            this.fld_txtARCustomerDueDays.BOSPrivilege = "";
            this.fld_txtARCustomerDueDays.BOSPropertyName = "Text";
            this.fld_txtARCustomerDueDays.Location = new System.Drawing.Point(415, 59);
            this.fld_txtARCustomerDueDays.Name = "fld_txtARCustomerDueDays";
            this.fld_txtARCustomerDueDays.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerDueDays.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerDueDays.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerDueDays.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerDueDays.Properties.Mask.EditMask = "\\d+";
            this.fld_txtARCustomerDueDays.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.fld_txtARCustomerDueDays.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerDueDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerDueDays.Screen = null;
            this.fld_txtARCustomerDueDays.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARCustomerDueDays.TabIndex = 4;
            this.fld_txtARCustomerDueDays.Tag = "DC";
            // 
            // fld_txtAPSupplierBankAccount1
            // 
            this.fld_txtAPSupplierBankAccount1.BOSComment = "";
            this.fld_txtAPSupplierBankAccount1.BOSDataMember = "APSupplierBankAccount1";
            this.fld_txtAPSupplierBankAccount1.BOSDataSource = "APSuppliers";
            this.fld_txtAPSupplierBankAccount1.BOSDescription = null;
            this.fld_txtAPSupplierBankAccount1.BOSError = null;
            this.fld_txtAPSupplierBankAccount1.BOSFieldGroup = "";
            this.fld_txtAPSupplierBankAccount1.BOSFieldRelation = "";
            this.fld_txtAPSupplierBankAccount1.BOSPrivilege = "";
            this.fld_txtAPSupplierBankAccount1.BOSPropertyName = "Text";
            this.fld_txtAPSupplierBankAccount1.EditValue = "<APSupplierBankAccount1>";
            this.fld_txtAPSupplierBankAccount1.Location = new System.Drawing.Point(154, 137);
            this.fld_txtAPSupplierBankAccount1.Name = "fld_txtAPSupplierBankAccount1";
            this.fld_txtAPSupplierBankAccount1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierBankAccount1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierBankAccount1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierBankAccount1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierBankAccount1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierBankAccount1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierBankAccount1.Screen = null;
            this.fld_txtAPSupplierBankAccount1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPSupplierBankAccount1.TabIndex = 8;
            this.fld_txtAPSupplierBankAccount1.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = "";
            this.bosLabel4.BOSDataMember = "";
            this.bosLabel4.BOSDataSource = "";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = "";
            this.bosLabel4.BOSPrivilege = "";
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(14, 62);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(53, 13);
            this.bosLabel4.TabIndex = 6;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Loại tiền tệ";
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
            this.fld_lblLabel15.BOSPropertyName = "";
            this.fld_lblLabel15.Location = new System.Drawing.Point(331, 168);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.fld_lblLabel15.Size = new System.Drawing.Size(62, 13);
            this.fld_lblLabel15.TabIndex = 10;
            this.fld_lblLabel15.Tag = "";
            this.fld_lblLabel15.Text = "Loại tiền tệ 2";
            // 
            // fld_lkeFK_GECurrencyID2
            // 
            this.fld_lkeFK_GECurrencyID2.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID2.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID2.BOSComment = "";
            this.fld_lkeFK_GECurrencyID2.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID2.BOSDataSource = "APSuppliers";
            this.fld_lkeFK_GECurrencyID2.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID2.BOSError = "";
            this.fld_lkeFK_GECurrencyID2.BOSFieldGroup = "";
            this.fld_lkeFK_GECurrencyID2.BOSFieldParent = "";
            this.fld_lkeFK_GECurrencyID2.BOSFieldRelation = "";
            this.fld_lkeFK_GECurrencyID2.BOSPrivilege = "";
            this.fld_lkeFK_GECurrencyID2.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID2.BOSSelectType = "";
            this.fld_lkeFK_GECurrencyID2.BOSSelectTypeValue = "";
            this.fld_lkeFK_GECurrencyID2.CurrentDisplayText = "";
            this.fld_lkeFK_GECurrencyID2.Location = new System.Drawing.Point(154, 59);
            this.fld_lkeFK_GECurrencyID2.Name = "fld_lkeFK_GECurrencyID2";
            this.fld_lkeFK_GECurrencyID2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID2.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeFK_GECurrencyID2.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID2.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID2.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID2.Screen = null;
            this.fld_lkeFK_GECurrencyID2.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID2.TabIndex = 3;
            this.fld_lkeFK_GECurrencyID2.Tag = "DC";
            // 
            // fld_txtAPSupplierBankAccount2
            // 
            this.fld_txtAPSupplierBankAccount2.BOSComment = "";
            this.fld_txtAPSupplierBankAccount2.BOSDataMember = "APSupplierBankAccount2";
            this.fld_txtAPSupplierBankAccount2.BOSDataSource = "APSuppliers";
            this.fld_txtAPSupplierBankAccount2.BOSDescription = null;
            this.fld_txtAPSupplierBankAccount2.BOSError = null;
            this.fld_txtAPSupplierBankAccount2.BOSFieldGroup = "";
            this.fld_txtAPSupplierBankAccount2.BOSFieldRelation = "";
            this.fld_txtAPSupplierBankAccount2.BOSPrivilege = "";
            this.fld_txtAPSupplierBankAccount2.BOSPropertyName = "Text";
            this.fld_txtAPSupplierBankAccount2.EditValue = "<APSupplierBankAccount2>";
            this.fld_txtAPSupplierBankAccount2.Location = new System.Drawing.Point(154, 165);
            this.fld_txtAPSupplierBankAccount2.Name = "fld_txtAPSupplierBankAccount2";
            this.fld_txtAPSupplierBankAccount2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierBankAccount2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierBankAccount2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierBankAccount2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierBankAccount2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierBankAccount2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierBankAccount2.Screen = null;
            this.fld_txtAPSupplierBankAccount2.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPSupplierBankAccount2.TabIndex = 10;
            this.fld_txtAPSupplierBankAccount2.Tag = "DC";
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
            this.fld_lblLabel12.BOSPropertyName = "";
            this.fld_lblLabel12.Location = new System.Drawing.Point(14, 140);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(68, 13);
            this.fld_lblLabel12.TabIndex = 4;
            this.fld_lblLabel12.Tag = "";
            this.fld_lblLabel12.Text = "Số tài khoản 1";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = "";
            this.fld_lblLabel1.BOSDataMember = "";
            this.fld_lblLabel1.BOSDataSource = "";
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = "";
            this.fld_lblLabel1.BOSFieldRelation = "";
            this.fld_lblLabel1.BOSPrivilege = "";
            this.fld_lblLabel1.BOSPropertyName = "";
            this.fld_lblLabel1.Location = new System.Drawing.Point(14, 114);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel1.TabIndex = 2;
            this.fld_lblLabel1.Tag = "";
            this.fld_lblLabel1.Text = "Tên ngân hàng";
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
            this.fld_lblLabel14.BOSPropertyName = "";
            this.fld_lblLabel14.Location = new System.Drawing.Point(14, 168);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(68, 13);
            this.fld_lblLabel14.TabIndex = 8;
            this.fld_lblLabel14.Tag = "";
            this.fld_lblLabel14.Text = "Số tài khoản 2";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = "";
            this.fld_lblLabel5.BOSDataMember = "";
            this.fld_lblLabel5.BOSDataSource = "";
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = "";
            this.fld_lblLabel5.BOSFieldRelation = "";
            this.fld_lblLabel5.BOSPrivilege = "";
            this.fld_lblLabel5.BOSPropertyName = "";
            this.fld_lblLabel5.Location = new System.Drawing.Point(14, 88);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(110, 13);
            this.fld_lblLabel5.TabIndex = 0;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Điều khoản thanh toán";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel6.BOSPropertyName = "";
            this.fld_lblLabel6.Location = new System.Drawing.Point(14, 38);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(118, 13);
            this.fld_lblLabel6.TabIndex = 2;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Phương thức thanh toán";
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
            this.fld_lblLabel13.BOSPropertyName = "";
            this.fld_lblLabel13.Location = new System.Drawing.Point(331, 140);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(62, 13);
            this.fld_lblLabel13.TabIndex = 6;
            this.fld_lblLabel13.Tag = "";
            this.fld_lblLabel13.Text = "Loại tiền tệ 1";
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
            this.bosLabel8.BOSPropertyName = "";
            this.bosLabel8.Location = new System.Drawing.Point(331, 114);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(68, 13);
            this.bosLabel8.TabIndex = 4;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Mã ngân hàng";
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
            this.fld_lblLabel11.BOSPropertyName = "";
            this.fld_lblLabel11.Location = new System.Drawing.Point(327, 37);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(53, 13);
            this.fld_lblLabel11.TabIndex = 4;
            this.fld_lblLabel11.Tag = "";
            this.fld_lblLabel11.Text = "Mã số thuế";
            // 
            // fld_lkeAPPaymentMethodCombo
            // 
            this.fld_lkeAPPaymentMethodCombo.BOSAllowAddNew = false;
            this.fld_lkeAPPaymentMethodCombo.BOSAllowDummy = true;
            this.fld_lkeAPPaymentMethodCombo.BOSComment = "";
            this.fld_lkeAPPaymentMethodCombo.BOSDataMember = "APPaymentMethodCombo";
            this.fld_lkeAPPaymentMethodCombo.BOSDataSource = "APSuppliers";
            this.fld_lkeAPPaymentMethodCombo.BOSDescription = null;
            this.fld_lkeAPPaymentMethodCombo.BOSError = null;
            this.fld_lkeAPPaymentMethodCombo.BOSFieldGroup = "";
            this.fld_lkeAPPaymentMethodCombo.BOSFieldParent = "";
            this.fld_lkeAPPaymentMethodCombo.BOSFieldRelation = "";
            this.fld_lkeAPPaymentMethodCombo.BOSPrivilege = "";
            this.fld_lkeAPPaymentMethodCombo.BOSPropertyName = "EditValue";
            this.fld_lkeAPPaymentMethodCombo.BOSSelectType = "";
            this.fld_lkeAPPaymentMethodCombo.BOSSelectTypeValue = "";
            this.fld_lkeAPPaymentMethodCombo.CurrentDisplayText = null;
            this.fld_lkeAPPaymentMethodCombo.Location = new System.Drawing.Point(154, 33);
            this.fld_lkeAPPaymentMethodCombo.Name = "fld_lkeAPPaymentMethodCombo";
            this.fld_lkeAPPaymentMethodCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPPaymentMethodCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPPaymentMethodCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPPaymentMethodCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPPaymentMethodCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPaymentMethodCombo.Properties.ColumnName = null;
            this.fld_lkeAPPaymentMethodCombo.Properties.NullText = "";
            this.fld_lkeAPPaymentMethodCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPPaymentMethodCombo.Screen = null;
            this.fld_lkeAPPaymentMethodCombo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPPaymentMethodCombo.TabIndex = 0;
            this.fld_lkeAPPaymentMethodCombo.Tag = "DC";
            // 
            // fld_txtAPSupplierTaxNumber
            // 
            this.fld_txtAPSupplierTaxNumber.BOSComment = "";
            this.fld_txtAPSupplierTaxNumber.BOSDataMember = "APSupplierTaxNumber";
            this.fld_txtAPSupplierTaxNumber.BOSDataSource = "APSuppliers";
            this.fld_txtAPSupplierTaxNumber.BOSDescription = null;
            this.fld_txtAPSupplierTaxNumber.BOSError = null;
            this.fld_txtAPSupplierTaxNumber.BOSFieldGroup = "";
            this.fld_txtAPSupplierTaxNumber.BOSFieldRelation = "";
            this.fld_txtAPSupplierTaxNumber.BOSPrivilege = "";
            this.fld_txtAPSupplierTaxNumber.BOSPropertyName = "Text";
            this.fld_txtAPSupplierTaxNumber.EditValue = "<APSupplierTaxNumber>";
            this.fld_txtAPSupplierTaxNumber.Location = new System.Drawing.Point(415, 34);
            this.fld_txtAPSupplierTaxNumber.Name = "fld_txtAPSupplierTaxNumber";
            this.fld_txtAPSupplierTaxNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierTaxNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierTaxNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierTaxNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierTaxNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierTaxNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierTaxNumber.Screen = null;
            this.fld_txtAPSupplierTaxNumber.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPSupplierTaxNumber.TabIndex = 1;
            this.fld_txtAPSupplierTaxNumber.Tag = "DC";
            // 
            // fld_txtAPSupplierBankCode
            // 
            this.fld_txtAPSupplierBankCode.BOSComment = "";
            this.fld_txtAPSupplierBankCode.BOSDataMember = "APSupplierBankCode";
            this.fld_txtAPSupplierBankCode.BOSDataSource = "APSuppliers";
            this.fld_txtAPSupplierBankCode.BOSDescription = null;
            this.fld_txtAPSupplierBankCode.BOSError = null;
            this.fld_txtAPSupplierBankCode.BOSFieldGroup = "";
            this.fld_txtAPSupplierBankCode.BOSFieldRelation = "";
            this.fld_txtAPSupplierBankCode.BOSPrivilege = "";
            this.fld_txtAPSupplierBankCode.BOSPropertyName = "Text";
            this.fld_txtAPSupplierBankCode.EditValue = "<APSupplierBankCode>";
            this.fld_txtAPSupplierBankCode.Location = new System.Drawing.Point(415, 111);
            this.fld_txtAPSupplierBankCode.Name = "fld_txtAPSupplierBankCode";
            this.fld_txtAPSupplierBankCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierBankCode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierBankCode.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierBankCode.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierBankCode.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierBankCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierBankCode.Screen = null;
            this.fld_txtAPSupplierBankCode.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPSupplierBankCode.TabIndex = 7;
            this.fld_txtAPSupplierBankCode.Tag = "DC";
            // 
            // fld_txtAPSupplierBankName
            // 
            this.fld_txtAPSupplierBankName.BOSComment = "";
            this.fld_txtAPSupplierBankName.BOSDataMember = "APSupplierBankName";
            this.fld_txtAPSupplierBankName.BOSDataSource = "APSuppliers";
            this.fld_txtAPSupplierBankName.BOSDescription = null;
            this.fld_txtAPSupplierBankName.BOSError = null;
            this.fld_txtAPSupplierBankName.BOSFieldGroup = "";
            this.fld_txtAPSupplierBankName.BOSFieldRelation = "";
            this.fld_txtAPSupplierBankName.BOSPrivilege = "";
            this.fld_txtAPSupplierBankName.BOSPropertyName = "Text";
            this.fld_txtAPSupplierBankName.EditValue = "<APSupplierBankName>";
            this.fld_txtAPSupplierBankName.Location = new System.Drawing.Point(154, 111);
            this.fld_txtAPSupplierBankName.Name = "fld_txtAPSupplierBankName";
            this.fld_txtAPSupplierBankName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierBankName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierBankName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierBankName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierBankName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierBankName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierBankName.Screen = null;
            this.fld_txtAPSupplierBankName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPSupplierBankName.TabIndex = 7;
            this.fld_txtAPSupplierBankName.Tag = "DC";
            // 
            // DMSP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(930, 725);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Controls.Add(this.fld_grcGroupControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMSP100.IconOptions.Icon")));
            this.Name = "DMSP100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.fld_grcGroupControl1, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierName2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactEmail1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPSupplierTypeCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkAPSupplierActiveCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPSupplierDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.bosPanel3.ResumeLayout(false);
            this.bosPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierTypeAccountConfigID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountPurchaseID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountSaleID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPSuppliersDiscountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEDistrictID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEStateProvinceID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECountryID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierWebsite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierAddressPostalCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactPhone1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPSupplierStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPSupplierStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierAddressLine1.Properties)).EndInit();
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkIsPaymentLocked.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkIsBuyingLocked.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierName21.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierName3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            this.fld_grcGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEPaymentTermID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPSupplierBankAccountCurrency2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPSupplierBankAccountCurrency1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerDueDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierBankAccount1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierBankAccount2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPaymentMethodCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierTaxNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierBankCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierBankName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtAPSupplierName21;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtAPSupplierName1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtAPSupplierName3;
        private BOSComponent.BOSLookupEdit fld_lkeAPSupplierBankAccountCurrency2;
        private BOSComponent.BOSLookupEdit fld_lkeAPSupplierBankAccountCurrency1;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSTextBox fld_txtARCustomerDueDays;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID2;
        private BOSComponent.BOSCheckEdit fld_chkIsBuyingLocked;
        private BOSComponent.BOSCheckEdit fld_chkIsPaymentLocked;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPanel bosPanel3;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSTextBox fld_txtAPSupplierContactPhone1;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEDistrictID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEStateProvinceID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECountryID;
        private APSupplierDepartmentsGridControl fld_dgcAPSupplierDepartments;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl1;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEPaymentTermID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtAPSupplierBankCode;
        private CollapsibleGroupBox fld_clgName;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel31;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLookupEdit fld_lkeAPSuppliersDiscountType;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountPurchaseID;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountSaleID;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLookupEdit bosLookupEdit2;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierTypeAccountConfigID;
        private BOSComponent.BOSLabel bosLabel16;
	}
}
