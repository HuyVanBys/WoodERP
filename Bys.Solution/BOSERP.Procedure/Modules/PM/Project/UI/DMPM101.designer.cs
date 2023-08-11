using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Project.UI
{
	/// <summary>
    /// Summary description for DMPM101
	/// </summary>
    partial class DMPM101
    {


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
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dtePMProjectContactDOB = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtPMProjectContactFax = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_chkPMProjectContactTransactionContactInfo = new BOSComponent.BOSCheckEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtPMProjectContactComment = new BOSComponent.BOSTextBox(this.components);
            this.fld_chkPMProjectContactDefaultAddress = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_txtPMProjectContactAddress = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtPMProjectContactPhone = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtPMProjectContactEmail = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtPMProjectContactName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtPMProjectContactTaxCode = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel35 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel38 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel48 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel49 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel50 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcPMProjectContactsGridControl = new BOSERP.Modules.Project.PMProjectContactsGridControl();
            this.fld_btnAddContact = new BOSComponent.BOSButton(this.components);
            this.fld_btnDeleteContact = new BOSComponent.BOSButton(this.components);
            this.fld_btnEditContact = new BOSComponent.BOSButton(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectContactDOB.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectContactDOB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectContactFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkPMProjectContactTransactionContactInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectContactComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkPMProjectContactDefaultAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectContactAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectContactPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectContactEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectContactName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectContactTaxCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMProjectContactsGridControl)).BeginInit();
            this.SuspendLayout();
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
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.bosGroupControl2);
            this.bosPanel1.Controls.Add(this.fld_btnAddContact);
            this.bosPanel1.Controls.Add(this.fld_btnDeleteContact);
            this.bosPanel1.Controls.Add(this.fld_btnEditContact);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 599);
            this.bosPanel1.TabIndex = 6;
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_dtePMProjectContactDOB);
            this.bosGroupControl1.Controls.Add(this.fld_txtPMProjectContactFax);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_chkPMProjectContactTransactionContactInfo);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.fld_txtPMProjectContactComment);
            this.bosGroupControl1.Controls.Add(this.fld_chkPMProjectContactDefaultAddress);
            this.bosGroupControl1.Controls.Add(this.fld_txtPMProjectContactAddress);
            this.bosGroupControl1.Controls.Add(this.fld_txtPMProjectContactPhone);
            this.bosGroupControl1.Controls.Add(this.fld_txtPMProjectContactEmail);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.fld_txtPMProjectContactName);
            this.bosGroupControl1.Controls.Add(this.fld_txtPMProjectContactTaxCode);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel35);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel38);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel48);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel49);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel50);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosGroupControl1, true);
            this.bosGroupControl1.Size = new System.Drawing.Size(857, 187);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Thông tin người liên hệ";
            // 
            // fld_dtePMProjectContactDOB
            // 
            this.fld_dtePMProjectContactDOB.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dtePMProjectContactDOB.BOSDataMember = "PMProjectContactDOB";
            this.fld_dtePMProjectContactDOB.BOSDataSource = "PMProjectContacts";
            this.fld_dtePMProjectContactDOB.BOSDescription = null;
            this.fld_dtePMProjectContactDOB.BOSError = null;
            this.fld_dtePMProjectContactDOB.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dtePMProjectContactDOB.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dtePMProjectContactDOB.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dtePMProjectContactDOB.BOSPropertyName = "EditValue";
            this.fld_dtePMProjectContactDOB.EditValue = null;
            this.fld_dtePMProjectContactDOB.Location = new System.Drawing.Point(106, 103);
            this.fld_dtePMProjectContactDOB.Name = "fld_dtePMProjectContactDOB";
            this.fld_dtePMProjectContactDOB.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dtePMProjectContactDOB.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dtePMProjectContactDOB.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dtePMProjectContactDOB.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dtePMProjectContactDOB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dtePMProjectContactDOB.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dtePMProjectContactDOB.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dtePMProjectContactDOB, true);
            this.fld_dtePMProjectContactDOB.Size = new System.Drawing.Size(163, 20);
            this.fld_dtePMProjectContactDOB.TabIndex = 4;
            this.fld_dtePMProjectContactDOB.Tag = "DC";
            // 
            // fld_txtPMProjectContactFax
            // 
            this.fld_txtPMProjectContactFax.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactFax.BOSDataMember = "PMProjectContactFax";
            this.fld_txtPMProjectContactFax.BOSDataSource = "PMProjectContacts";
            this.fld_txtPMProjectContactFax.BOSDescription = null;
            this.fld_txtPMProjectContactFax.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactFax.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactFax.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactFax.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactFax.BOSPropertyName = "Text";
            this.fld_txtPMProjectContactFax.Location = new System.Drawing.Point(106, 129);
            this.fld_txtPMProjectContactFax.Name = "fld_txtPMProjectContactFax";
            this.fld_txtPMProjectContactFax.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMProjectContactFax.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMProjectContactFax.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMProjectContactFax.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMProjectContactFax.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMProjectContactFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMProjectContactFax.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtPMProjectContactFax, true);
            this.fld_txtPMProjectContactFax.Size = new System.Drawing.Size(163, 20);
            this.fld_txtPMProjectContactFax.TabIndex = 6;
            this.fld_txtPMProjectContactFax.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(13, 132);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(33, 13);
            this.bosLabel3.TabIndex = 359;
            this.bosLabel3.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.Text = "Số Fax";
            // 
            // fld_chkPMProjectContactTransactionContactInfo
            // 
            this.fld_chkPMProjectContactTransactionContactInfo.BOSComment = null;
            this.fld_chkPMProjectContactTransactionContactInfo.BOSDataMember = "PMProjectContactTransactionContactInfo";
            this.fld_chkPMProjectContactTransactionContactInfo.BOSDataSource = "PMProjectContacts";
            this.fld_chkPMProjectContactTransactionContactInfo.BOSDescription = null;
            this.fld_chkPMProjectContactTransactionContactInfo.BOSError = null;
            this.fld_chkPMProjectContactTransactionContactInfo.BOSFieldGroup = null;
            this.fld_chkPMProjectContactTransactionContactInfo.BOSFieldRelation = null;
            this.fld_chkPMProjectContactTransactionContactInfo.BOSPrivilege = null;
            this.fld_chkPMProjectContactTransactionContactInfo.BOSPropertyName = "EditValue";
            this.fld_chkPMProjectContactTransactionContactInfo.Location = new System.Drawing.Point(532, 155);
            this.fld_chkPMProjectContactTransactionContactInfo.MenuManager = this.screenToolbar;
            this.fld_chkPMProjectContactTransactionContactInfo.Name = "fld_chkPMProjectContactTransactionContactInfo";
            this.fld_chkPMProjectContactTransactionContactInfo.Properties.Caption = "Thông tin giao dịch";
            this.fld_chkPMProjectContactTransactionContactInfo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_chkPMProjectContactTransactionContactInfo, true);
            this.fld_chkPMProjectContactTransactionContactInfo.Size = new System.Drawing.Size(151, 19);
            this.fld_chkPMProjectContactTransactionContactInfo.TabIndex = 10;
            this.fld_chkPMProjectContactTransactionContactInfo.Tag = "DC";
            this.fld_chkPMProjectContactTransactionContactInfo.Visible = false;
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(13, 158);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(45, 13);
            this.bosLabel1.TabIndex = 356;
            this.bosLabel1.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.Text = "Thông tin";
            // 
            // fld_txtPMProjectContactComment
            // 
            this.fld_txtPMProjectContactComment.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactComment.BOSDataMember = "PMProjectContactComment";
            this.fld_txtPMProjectContactComment.BOSDataSource = "PMProjectContacts";
            this.fld_txtPMProjectContactComment.BOSDescription = null;
            this.fld_txtPMProjectContactComment.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactComment.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactComment.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactComment.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactComment.BOSPropertyName = "Text";
            this.fld_txtPMProjectContactComment.Location = new System.Drawing.Point(106, 155);
            this.fld_txtPMProjectContactComment.Name = "fld_txtPMProjectContactComment";
            this.fld_txtPMProjectContactComment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMProjectContactComment.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMProjectContactComment.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMProjectContactComment.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMProjectContactComment.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMProjectContactComment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMProjectContactComment.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtPMProjectContactComment, true);
            this.fld_txtPMProjectContactComment.Size = new System.Drawing.Size(398, 20);
            this.fld_txtPMProjectContactComment.TabIndex = 8;
            this.fld_txtPMProjectContactComment.Tag = "DC";
            // 
            // fld_chkPMProjectContactDefaultAddress
            // 
            this.fld_chkPMProjectContactDefaultAddress.BOSComment = null;
            this.fld_chkPMProjectContactDefaultAddress.BOSDataMember = "PMProjectContactDefaultAddress";
            this.fld_chkPMProjectContactDefaultAddress.BOSDataSource = "PMProjectContacts";
            this.fld_chkPMProjectContactDefaultAddress.BOSDescription = null;
            this.fld_chkPMProjectContactDefaultAddress.BOSError = null;
            this.fld_chkPMProjectContactDefaultAddress.BOSFieldGroup = null;
            this.fld_chkPMProjectContactDefaultAddress.BOSFieldRelation = null;
            this.fld_chkPMProjectContactDefaultAddress.BOSPrivilege = null;
            this.fld_chkPMProjectContactDefaultAddress.BOSPropertyName = "EditValue";
            this.fld_chkPMProjectContactDefaultAddress.Location = new System.Drawing.Point(532, 129);
            this.fld_chkPMProjectContactDefaultAddress.MenuManager = this.screenToolbar;
            this.fld_chkPMProjectContactDefaultAddress.Name = "fld_chkPMProjectContactDefaultAddress";
            this.fld_chkPMProjectContactDefaultAddress.Properties.Caption = "Địa chỉ S.O mặc định";
            this.fld_chkPMProjectContactDefaultAddress.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_chkPMProjectContactDefaultAddress, true);
            this.fld_chkPMProjectContactDefaultAddress.Size = new System.Drawing.Size(151, 19);
            this.fld_chkPMProjectContactDefaultAddress.TabIndex = 9;
            this.fld_chkPMProjectContactDefaultAddress.Tag = "DC";
            this.fld_chkPMProjectContactDefaultAddress.Visible = false;
            // 
            // fld_txtPMProjectContactAddress
            // 
            this.fld_txtPMProjectContactAddress.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactAddress.BOSDataMember = "PMProjectContactAddress";
            this.fld_txtPMProjectContactAddress.BOSDataSource = "PMProjectContacts";
            this.fld_txtPMProjectContactAddress.BOSDescription = null;
            this.fld_txtPMProjectContactAddress.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactAddress.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactAddress.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactAddress.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactAddress.BOSPropertyName = "Text";
            this.fld_txtPMProjectContactAddress.Location = new System.Drawing.Point(106, 77);
            this.fld_txtPMProjectContactAddress.Name = "fld_txtPMProjectContactAddress";
            this.fld_txtPMProjectContactAddress.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMProjectContactAddress.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMProjectContactAddress.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMProjectContactAddress.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMProjectContactAddress.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMProjectContactAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMProjectContactAddress.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtPMProjectContactAddress, true);
            this.fld_txtPMProjectContactAddress.Size = new System.Drawing.Size(398, 20);
            this.fld_txtPMProjectContactAddress.TabIndex = 3;
            this.fld_txtPMProjectContactAddress.Tag = "DC";
            // 
            // fld_txtPMProjectContactPhone
            // 
            this.fld_txtPMProjectContactPhone.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactPhone.BOSDataMember = "PMProjectContactPhone";
            this.fld_txtPMProjectContactPhone.BOSDataSource = "PMProjectContacts";
            this.fld_txtPMProjectContactPhone.BOSDescription = null;
            this.fld_txtPMProjectContactPhone.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactPhone.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactPhone.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactPhone.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactPhone.BOSPropertyName = "Text";
            this.fld_txtPMProjectContactPhone.Location = new System.Drawing.Point(341, 103);
            this.fld_txtPMProjectContactPhone.Name = "fld_txtPMProjectContactPhone";
            this.fld_txtPMProjectContactPhone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMProjectContactPhone.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMProjectContactPhone.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMProjectContactPhone.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMProjectContactPhone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMProjectContactPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMProjectContactPhone.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtPMProjectContactPhone, true);
            this.fld_txtPMProjectContactPhone.Size = new System.Drawing.Size(163, 20);
            this.fld_txtPMProjectContactPhone.TabIndex = 5;
            this.fld_txtPMProjectContactPhone.Tag = "DC";
            // 
            // fld_txtPMProjectContactEmail
            // 
            this.fld_txtPMProjectContactEmail.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactEmail.BOSDataMember = "PMProjectContactEmail";
            this.fld_txtPMProjectContactEmail.BOSDataSource = "PMProjectContacts";
            this.fld_txtPMProjectContactEmail.BOSDescription = null;
            this.fld_txtPMProjectContactEmail.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactEmail.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactEmail.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactEmail.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactEmail.BOSPropertyName = "Text";
            this.fld_txtPMProjectContactEmail.Location = new System.Drawing.Point(106, 51);
            this.fld_txtPMProjectContactEmail.Name = "fld_txtPMProjectContactEmail";
            this.fld_txtPMProjectContactEmail.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMProjectContactEmail.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMProjectContactEmail.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMProjectContactEmail.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMProjectContactEmail.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMProjectContactEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMProjectContactEmail.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtPMProjectContactEmail, true);
            this.fld_txtPMProjectContactEmail.Size = new System.Drawing.Size(398, 20);
            this.fld_txtPMProjectContactEmail.TabIndex = 2;
            this.fld_txtPMProjectContactEmail.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(13, 80);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(33, 13);
            this.bosLabel2.TabIndex = 53;
            this.bosLabel2.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.Text = "Địa chỉ";
            // 
            // fld_txtPMProjectContactName
            // 
            this.fld_txtPMProjectContactName.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactName.BOSDataMember = "PMProjectContactName";
            this.fld_txtPMProjectContactName.BOSDataSource = "PMProjectContacts";
            this.fld_txtPMProjectContactName.BOSDescription = null;
            this.fld_txtPMProjectContactName.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactName.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactName.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactName.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactName.BOSPropertyName = "Text";
            this.fld_txtPMProjectContactName.Location = new System.Drawing.Point(106, 25);
            this.fld_txtPMProjectContactName.Name = "fld_txtPMProjectContactName";
            this.fld_txtPMProjectContactName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMProjectContactName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMProjectContactName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMProjectContactName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMProjectContactName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMProjectContactName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMProjectContactName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtPMProjectContactName, true);
            this.fld_txtPMProjectContactName.Size = new System.Drawing.Size(398, 20);
            this.fld_txtPMProjectContactName.TabIndex = 1;
            this.fld_txtPMProjectContactName.Tag = "DC";
            // 
            // fld_txtPMProjectContactTaxCode
            // 
            this.fld_txtPMProjectContactTaxCode.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactTaxCode.BOSDataMember = "PMProjectContactTaxCode";
            this.fld_txtPMProjectContactTaxCode.BOSDataSource = "PMProjectContacts";
            this.fld_txtPMProjectContactTaxCode.BOSDescription = null;
            this.fld_txtPMProjectContactTaxCode.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactTaxCode.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactTaxCode.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactTaxCode.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtPMProjectContactTaxCode.BOSPropertyName = "Text";
            this.fld_txtPMProjectContactTaxCode.Location = new System.Drawing.Point(341, 129);
            this.fld_txtPMProjectContactTaxCode.Name = "fld_txtPMProjectContactTaxCode";
            this.fld_txtPMProjectContactTaxCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMProjectContactTaxCode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMProjectContactTaxCode.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMProjectContactTaxCode.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMProjectContactTaxCode.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMProjectContactTaxCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMProjectContactTaxCode.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtPMProjectContactTaxCode, true);
            this.fld_txtPMProjectContactTaxCode.Size = new System.Drawing.Size(163, 20);
            this.fld_txtPMProjectContactTaxCode.TabIndex = 7;
            this.fld_txtPMProjectContactTaxCode.Tag = "DC";
            // 
            // fld_lblLabel35
            // 
            this.fld_lblLabel35.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel35.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel35.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel35.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel35.Appearance.Options.UseFont = true;
            this.fld_lblLabel35.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel35.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel35.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel35.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel35.BOSDescription = null;
            this.fld_lblLabel35.BOSError = null;
            this.fld_lblLabel35.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel35.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel35.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel35.BOSPropertyName = null;
            this.fld_lblLabel35.Location = new System.Drawing.Point(13, 28);
            this.fld_lblLabel35.Name = "fld_lblLabel35";
            this.fld_lblLabel35.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel35, true);
            this.fld_lblLabel35.Size = new System.Drawing.Size(19, 13);
            this.fld_lblLabel35.TabIndex = 40;
            this.fld_lblLabel35.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel35.Text = "Tên";
            // 
            // fld_lblLabel38
            // 
            this.fld_lblLabel38.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel38.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel38.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel38.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel38.Appearance.Options.UseFont = true;
            this.fld_lblLabel38.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel38.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel38.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel38.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel38.BOSDescription = null;
            this.fld_lblLabel38.BOSError = null;
            this.fld_lblLabel38.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel38.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel38.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel38.BOSPropertyName = null;
            this.fld_lblLabel38.Location = new System.Drawing.Point(282, 132);
            this.fld_lblLabel38.Name = "fld_lblLabel38";
            this.fld_lblLabel38.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel38, true);
            this.fld_lblLabel38.Size = new System.Drawing.Size(53, 13);
            this.fld_lblLabel38.TabIndex = 41;
            this.fld_lblLabel38.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel38.Text = "Mã số thuế";
            // 
            // fld_lblLabel48
            // 
            this.fld_lblLabel48.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel48.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel48.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel48.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel48.Appearance.Options.UseFont = true;
            this.fld_lblLabel48.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel48.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel48.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel48.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel48.BOSDescription = null;
            this.fld_lblLabel48.BOSError = null;
            this.fld_lblLabel48.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel48.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel48.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel48.BOSPropertyName = null;
            this.fld_lblLabel48.Location = new System.Drawing.Point(13, 54);
            this.fld_lblLabel48.Name = "fld_lblLabel48";
            this.fld_lblLabel48.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel48, true);
            this.fld_lblLabel48.Size = new System.Drawing.Size(25, 13);
            this.fld_lblLabel48.TabIndex = 43;
            this.fld_lblLabel48.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
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
            this.fld_lblLabel49.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel49.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel49.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel49.BOSDescription = null;
            this.fld_lblLabel49.BOSError = null;
            this.fld_lblLabel49.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel49.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel49.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel49.BOSPropertyName = null;
            this.fld_lblLabel49.Location = new System.Drawing.Point(13, 106);
            this.fld_lblLabel49.Name = "fld_lblLabel49";
            this.fld_lblLabel49.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel49, true);
            this.fld_lblLabel49.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel49.TabIndex = 44;
            this.fld_lblLabel49.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel49.Text = "Ngày sinh";
            // 
            // fld_lblLabel50
            // 
            this.fld_lblLabel50.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel50.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel50.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel50.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel50.Appearance.Options.UseFont = true;
            this.fld_lblLabel50.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel50.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel50.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel50.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel50.BOSDescription = null;
            this.fld_lblLabel50.BOSError = null;
            this.fld_lblLabel50.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel50.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel50.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel50.BOSPropertyName = null;
            this.fld_lblLabel50.Location = new System.Drawing.Point(282, 106);
            this.fld_lblLabel50.Name = "fld_lblLabel50";
            this.fld_lblLabel50.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel50, true);
            this.fld_lblLabel50.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel50.TabIndex = 45;
            this.fld_lblLabel50.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel50.Text = "Điện thoại";
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.fld_dgcPMProjectContactsGridControl);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 229);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(857, 368);
            this.bosGroupControl2.TabIndex = 4;
            this.bosGroupControl2.Text = "Danh sách người liên hệ";
            // 
            // fld_dgcPMProjectContactsGridControl
            // 
            this.fld_dgcPMProjectContactsGridControl.BOSComment = null;
            this.fld_dgcPMProjectContactsGridControl.BOSDataMember = null;
            this.fld_dgcPMProjectContactsGridControl.BOSDataSource = "PMProjectContacts";
            this.fld_dgcPMProjectContactsGridControl.BOSDescription = null;
            this.fld_dgcPMProjectContactsGridControl.BOSError = null;
            this.fld_dgcPMProjectContactsGridControl.BOSFieldGroup = null;
            this.fld_dgcPMProjectContactsGridControl.BOSFieldRelation = null;
            this.fld_dgcPMProjectContactsGridControl.BOSGridType = null;
            this.fld_dgcPMProjectContactsGridControl.BOSPrivilege = null;
            this.fld_dgcPMProjectContactsGridControl.BOSPropertyName = null;
            this.fld_dgcPMProjectContactsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcPMProjectContactsGridControl.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcPMProjectContactsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcPMProjectContactsGridControl.Name = "fld_dgcPMProjectContactsGridControl";
            this.fld_dgcPMProjectContactsGridControl.PrintReport = false;
            this.fld_dgcPMProjectContactsGridControl.Screen = null;
            this.fld_dgcPMProjectContactsGridControl.Size = new System.Drawing.Size(853, 344);
            this.fld_dgcPMProjectContactsGridControl.TabIndex = 0;
            // 
            // fld_btnAddContact
            // 
            this.fld_btnAddContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnAddContact.BOSComment = null;
            this.fld_btnAddContact.BOSDataMember = null;
            this.fld_btnAddContact.BOSDataSource = null;
            this.fld_btnAddContact.BOSDescription = null;
            this.fld_btnAddContact.BOSError = null;
            this.fld_btnAddContact.BOSFieldGroup = null;
            this.fld_btnAddContact.BOSFieldRelation = null;
            this.fld_btnAddContact.BOSPrivilege = null;
            this.fld_btnAddContact.BOSPropertyName = null;
            this.fld_btnAddContact.Location = new System.Drawing.Point(620, 196);
            this.fld_btnAddContact.Name = "fld_btnAddContact";
            this.fld_btnAddContact.Screen = null;
            this.fld_btnAddContact.Size = new System.Drawing.Size(75, 27);
            this.fld_btnAddContact.TabIndex = 1;
            this.fld_btnAddContact.Text = "Thêm";
            this.fld_btnAddContact.Click += new System.EventHandler(this.fld_btnAddContact_Click);
            // 
            // fld_btnDeleteContact
            // 
            this.fld_btnDeleteContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnDeleteContact.BOSComment = null;
            this.fld_btnDeleteContact.BOSDataMember = null;
            this.fld_btnDeleteContact.BOSDataSource = null;
            this.fld_btnDeleteContact.BOSDescription = null;
            this.fld_btnDeleteContact.BOSError = null;
            this.fld_btnDeleteContact.BOSFieldGroup = null;
            this.fld_btnDeleteContact.BOSFieldRelation = null;
            this.fld_btnDeleteContact.BOSPrivilege = null;
            this.fld_btnDeleteContact.BOSPropertyName = null;
            this.fld_btnDeleteContact.Location = new System.Drawing.Point(782, 196);
            this.fld_btnDeleteContact.Name = "fld_btnDeleteContact";
            this.fld_btnDeleteContact.Screen = null;
            this.fld_btnDeleteContact.Size = new System.Drawing.Size(75, 27);
            this.fld_btnDeleteContact.TabIndex = 3;
            this.fld_btnDeleteContact.Text = "Xóa";
            this.fld_btnDeleteContact.Click += new System.EventHandler(this.fld_btnDeleteContact_Click);
            // 
            // fld_btnEditContact
            // 
            this.fld_btnEditContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnEditContact.BOSComment = null;
            this.fld_btnEditContact.BOSDataMember = null;
            this.fld_btnEditContact.BOSDataSource = null;
            this.fld_btnEditContact.BOSDescription = null;
            this.fld_btnEditContact.BOSError = null;
            this.fld_btnEditContact.BOSFieldGroup = null;
            this.fld_btnEditContact.BOSFieldRelation = null;
            this.fld_btnEditContact.BOSPrivilege = null;
            this.fld_btnEditContact.BOSPropertyName = null;
            this.fld_btnEditContact.Location = new System.Drawing.Point(701, 196);
            this.fld_btnEditContact.Name = "fld_btnEditContact";
            this.fld_btnEditContact.Screen = null;
            this.fld_btnEditContact.Size = new System.Drawing.Size(75, 27);
            this.fld_btnEditContact.TabIndex = 2;
            this.fld_btnEditContact.Text = "Sửa";
            this.fld_btnEditContact.Click += new System.EventHandler(this.fld_btnEditContact_Click);
            // 
            // DMPM101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 599);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPM101";
            this.Text = "Danh sách liên hệ";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectContactDOB.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectContactDOB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectContactFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkPMProjectContactTransactionContactInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectContactComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkPMProjectContactDefaultAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectContactAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectContactPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectContactEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectContactName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectContactTaxCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMProjectContactsGridControl)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private PMProjectContactsGridControl fld_dgcPMProjectContactsGridControl;
        private BOSComponent.BOSButton fld_btnAddContact;
        private BOSComponent.BOSButton fld_btnDeleteContact;
        private BOSComponent.BOSButton fld_btnEditContact;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSCheckEdit fld_chkPMProjectContactDefaultAddress;
        private BOSComponent.BOSTextBox fld_txtPMProjectContactAddress;
        private BOSComponent.BOSTextBox fld_txtPMProjectContactPhone;
        private BOSComponent.BOSTextBox fld_txtPMProjectContactEmail;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtPMProjectContactName;
        private BOSComponent.BOSTextBox fld_txtPMProjectContactTaxCode;
        private BOSComponent.BOSLabel fld_lblLabel35;
        private BOSComponent.BOSLabel fld_lblLabel38;
        private BOSComponent.BOSLabel fld_lblLabel48;
        private BOSComponent.BOSLabel fld_lblLabel49;
        private BOSComponent.BOSLabel fld_lblLabel50;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtPMProjectContactComment;
        private BOSComponent.BOSCheckEdit fld_chkPMProjectContactTransactionContactInfo;
        private BOSComponent.BOSTextBox fld_txtPMProjectContactFax;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSDateEdit fld_dtePMProjectContactDOB;
	}
}
