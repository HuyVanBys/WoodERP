using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Customer.UI
{
	/// <summary>
	/// Summary description for DMCU103
	/// </summary>
	partial class DMCU103
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
            this.fld_chkARCustomerContactDefaultAddress = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_txtARCustomerContactAddressLine3 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerContactPhone1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerContactFax1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerContactEmail11 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerContactName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerContactTaxCode = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel35 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel38 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel48 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel49 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel50 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcARCustomerContacts = new BOSERP.Modules.Customer.ARCustomerContactsGridControl();
            this.fld_btnAddContact = new BOSComponent.BOSButton(this.components);
            this.fld_btnDeleteContact = new BOSComponent.BOSButton(this.components);
            this.fld_btnEditContact = new BOSComponent.BOSButton(this.components);
            this.fld_txtARCustomerContactComment = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_chkARCustomerContactTransactionContactInfo = new BOSComponent.BOSCheckEdit(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkARCustomerContactDefaultAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactAddressLine3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactPhone1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactFax1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactEmail11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactTaxCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCustomerContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkARCustomerContactTransactionContactInfo.Properties)).BeginInit();
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
            this.bosGroupControl1.Controls.Add(this.fld_chkARCustomerContactTransactionContactInfo);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.fld_txtARCustomerContactComment);
            this.bosGroupControl1.Controls.Add(this.fld_chkARCustomerContactDefaultAddress);
            this.bosGroupControl1.Controls.Add(this.fld_txtARCustomerContactAddressLine3);
            this.bosGroupControl1.Controls.Add(this.fld_txtARCustomerContactPhone1);
            this.bosGroupControl1.Controls.Add(this.fld_txtARCustomerContactFax1);
            this.bosGroupControl1.Controls.Add(this.fld_txtARCustomerContactEmail11);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.fld_txtARCustomerContactName);
            this.bosGroupControl1.Controls.Add(this.fld_txtARCustomerContactTaxCode);
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
            this.bosGroupControl1.TabIndex = 16;
            this.bosGroupControl1.Text = "Thông tin người liên hệ";
            // 
            // fld_chkARCustomerContactDefaultAddress
            // 
            this.fld_chkARCustomerContactDefaultAddress.BOSComment = null;
            this.fld_chkARCustomerContactDefaultAddress.BOSDataMember = "ARCustomerContactDefaultAddress";
            this.fld_chkARCustomerContactDefaultAddress.BOSDataSource = "ARCustomerContacts";
            this.fld_chkARCustomerContactDefaultAddress.BOSDescription = null;
            this.fld_chkARCustomerContactDefaultAddress.BOSError = null;
            this.fld_chkARCustomerContactDefaultAddress.BOSFieldGroup = null;
            this.fld_chkARCustomerContactDefaultAddress.BOSFieldRelation = null;
            this.fld_chkARCustomerContactDefaultAddress.BOSPrivilege = null;
            this.fld_chkARCustomerContactDefaultAddress.BOSPropertyName = "EditValue";
            this.fld_chkARCustomerContactDefaultAddress.Location = new System.Drawing.Point(532, 129);
            this.fld_chkARCustomerContactDefaultAddress.MenuManager = this.screenToolbar;
            this.fld_chkARCustomerContactDefaultAddress.Name = "fld_chkARCustomerContactDefaultAddress";
            this.fld_chkARCustomerContactDefaultAddress.Properties.Caption = "Địa chỉ S.O mặc định";
            this.fld_chkARCustomerContactDefaultAddress.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_chkARCustomerContactDefaultAddress, true);
            this.fld_chkARCustomerContactDefaultAddress.Size = new System.Drawing.Size(151, 19);
            this.fld_chkARCustomerContactDefaultAddress.TabIndex = 354;
            this.fld_chkARCustomerContactDefaultAddress.Tag = "DC";
            // 
            // fld_txtARCustomerContactAddressLine3
            // 
            this.fld_txtARCustomerContactAddressLine3.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactAddressLine3.BOSDataMember = "ARCustomerContactAddressLine3";
            this.fld_txtARCustomerContactAddressLine3.BOSDataSource = "ARCustomerContacts";
            this.fld_txtARCustomerContactAddressLine3.BOSDescription = null;
            this.fld_txtARCustomerContactAddressLine3.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactAddressLine3.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactAddressLine3.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactAddressLine3.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactAddressLine3.BOSPropertyName = "Text";
            this.fld_txtARCustomerContactAddressLine3.Location = new System.Drawing.Point(106, 77);
            this.fld_txtARCustomerContactAddressLine3.Name = "fld_txtARCustomerContactAddressLine3";
            this.fld_txtARCustomerContactAddressLine3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerContactAddressLine3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerContactAddressLine3.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerContactAddressLine3.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerContactAddressLine3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerContactAddressLine3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerContactAddressLine3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerContactAddressLine3, true);
            this.fld_txtARCustomerContactAddressLine3.Size = new System.Drawing.Size(398, 20);
            this.fld_txtARCustomerContactAddressLine3.TabIndex = 8;
            this.fld_txtARCustomerContactAddressLine3.Tag = "DC";
            // 
            // fld_txtARCustomerContactPhone1
            // 
            this.fld_txtARCustomerContactPhone1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactPhone1.BOSDataMember = "ARCustomerContactPhone";
            this.fld_txtARCustomerContactPhone1.BOSDataSource = "ARCustomerContacts";
            this.fld_txtARCustomerContactPhone1.BOSDescription = null;
            this.fld_txtARCustomerContactPhone1.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactPhone1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactPhone1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactPhone1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactPhone1.BOSPropertyName = "Text";
            this.fld_txtARCustomerContactPhone1.Location = new System.Drawing.Point(106, 103);
            this.fld_txtARCustomerContactPhone1.Name = "fld_txtARCustomerContactPhone1";
            this.fld_txtARCustomerContactPhone1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerContactPhone1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerContactPhone1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerContactPhone1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerContactPhone1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerContactPhone1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerContactPhone1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerContactPhone1, true);
            this.fld_txtARCustomerContactPhone1.Size = new System.Drawing.Size(163, 20);
            this.fld_txtARCustomerContactPhone1.TabIndex = 4;
            this.fld_txtARCustomerContactPhone1.Tag = "DC";
            // 
            // fld_txtARCustomerContactFax1
            // 
            this.fld_txtARCustomerContactFax1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactFax1.BOSDataMember = "ARCustomerContactFax";
            this.fld_txtARCustomerContactFax1.BOSDataSource = "ARCustomerContacts";
            this.fld_txtARCustomerContactFax1.BOSDescription = null;
            this.fld_txtARCustomerContactFax1.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactFax1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactFax1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactFax1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactFax1.BOSPropertyName = "Text";
            this.fld_txtARCustomerContactFax1.Location = new System.Drawing.Point(341, 103);
            this.fld_txtARCustomerContactFax1.Name = "fld_txtARCustomerContactFax1";
            this.fld_txtARCustomerContactFax1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerContactFax1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerContactFax1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerContactFax1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerContactFax1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerContactFax1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerContactFax1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerContactFax1, true);
            this.fld_txtARCustomerContactFax1.Size = new System.Drawing.Size(163, 20);
            this.fld_txtARCustomerContactFax1.TabIndex = 6;
            this.fld_txtARCustomerContactFax1.Tag = "DC";
            // 
            // fld_txtARCustomerContactEmail11
            // 
            this.fld_txtARCustomerContactEmail11.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactEmail11.BOSDataMember = "ARCustomerContactEmail1";
            this.fld_txtARCustomerContactEmail11.BOSDataSource = "ARCustomerContacts";
            this.fld_txtARCustomerContactEmail11.BOSDescription = null;
            this.fld_txtARCustomerContactEmail11.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactEmail11.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactEmail11.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactEmail11.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactEmail11.BOSPropertyName = "Text";
            this.fld_txtARCustomerContactEmail11.Location = new System.Drawing.Point(106, 51);
            this.fld_txtARCustomerContactEmail11.Name = "fld_txtARCustomerContactEmail11";
            this.fld_txtARCustomerContactEmail11.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerContactEmail11.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerContactEmail11.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerContactEmail11.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerContactEmail11.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerContactEmail11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerContactEmail11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerContactEmail11, true);
            this.fld_txtARCustomerContactEmail11.Size = new System.Drawing.Size(398, 20);
            this.fld_txtARCustomerContactEmail11.TabIndex = 7;
            this.fld_txtARCustomerContactEmail11.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(13, 80);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(33, 13);
            this.bosLabel2.TabIndex = 53;
            this.bosLabel2.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.Text = "Địa chỉ";
            // 
            // fld_txtARCustomerContactName
            // 
            this.fld_txtARCustomerContactName.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactName.BOSDataMember = "ARCustomerContactName";
            this.fld_txtARCustomerContactName.BOSDataSource = "ARCustomerContacts";
            this.fld_txtARCustomerContactName.BOSDescription = null;
            this.fld_txtARCustomerContactName.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactName.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactName.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactName.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactName.BOSPropertyName = "Text";
            this.fld_txtARCustomerContactName.Location = new System.Drawing.Point(106, 25);
            this.fld_txtARCustomerContactName.Name = "fld_txtARCustomerContactName";
            this.fld_txtARCustomerContactName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerContactName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerContactName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerContactName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerContactName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerContactName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerContactName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerContactName, true);
            this.fld_txtARCustomerContactName.Size = new System.Drawing.Size(398, 20);
            this.fld_txtARCustomerContactName.TabIndex = 2;
            this.fld_txtARCustomerContactName.Tag = "DC";
            // 
            // fld_txtARCustomerContactTaxCode
            // 
            this.fld_txtARCustomerContactTaxCode.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactTaxCode.BOSDataMember = "ARCustomerContactTaxCode";
            this.fld_txtARCustomerContactTaxCode.BOSDataSource = "ARCustomerContacts";
            this.fld_txtARCustomerContactTaxCode.BOSDescription = null;
            this.fld_txtARCustomerContactTaxCode.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactTaxCode.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactTaxCode.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactTaxCode.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactTaxCode.BOSPropertyName = "Text";
            this.fld_txtARCustomerContactTaxCode.Location = new System.Drawing.Point(106, 129);
            this.fld_txtARCustomerContactTaxCode.Name = "fld_txtARCustomerContactTaxCode";
            this.fld_txtARCustomerContactTaxCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerContactTaxCode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerContactTaxCode.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerContactTaxCode.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerContactTaxCode.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerContactTaxCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerContactTaxCode.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerContactTaxCode, true);
            this.fld_txtARCustomerContactTaxCode.Size = new System.Drawing.Size(398, 20);
            this.fld_txtARCustomerContactTaxCode.TabIndex = 5;
            this.fld_txtARCustomerContactTaxCode.Tag = "DC";
            // 
            // fld_lblLabel35
            // 
            this.fld_lblLabel35.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel35.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel35.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel35.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel35.Appearance.Options.UseFont = true;
            this.fld_lblLabel35.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel35.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel35.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel35.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel35.BOSDescription = null;
            this.fld_lblLabel35.BOSError = null;
            this.fld_lblLabel35.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel35.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel35.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel35.BOSPropertyName = null;
            this.fld_lblLabel35.Location = new System.Drawing.Point(13, 28);
            this.fld_lblLabel35.Name = "fld_lblLabel35";
            this.fld_lblLabel35.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel35, true);
            this.fld_lblLabel35.Size = new System.Drawing.Size(19, 13);
            this.fld_lblLabel35.TabIndex = 40;
            this.fld_lblLabel35.Tag = global::Localization.ReportLocalizedResources.tutu;
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
            this.fld_lblLabel38.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel38.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel38.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel38.BOSDescription = null;
            this.fld_lblLabel38.BOSError = null;
            this.fld_lblLabel38.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel38.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel38.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel38.BOSPropertyName = null;
            this.fld_lblLabel38.Location = new System.Drawing.Point(13, 132);
            this.fld_lblLabel38.Name = "fld_lblLabel38";
            this.fld_lblLabel38.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel38, true);
            this.fld_lblLabel38.Size = new System.Drawing.Size(53, 13);
            this.fld_lblLabel38.TabIndex = 41;
            this.fld_lblLabel38.Tag = global::Localization.ReportLocalizedResources.tutu;
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
            this.fld_lblLabel48.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel48.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel48.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel48.BOSDescription = null;
            this.fld_lblLabel48.BOSError = null;
            this.fld_lblLabel48.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel48.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel48.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel48.BOSPropertyName = null;
            this.fld_lblLabel48.Location = new System.Drawing.Point(13, 54);
            this.fld_lblLabel48.Name = "fld_lblLabel48";
            this.fld_lblLabel48.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel48, true);
            this.fld_lblLabel48.Size = new System.Drawing.Size(25, 13);
            this.fld_lblLabel48.TabIndex = 43;
            this.fld_lblLabel48.Tag = global::Localization.ReportLocalizedResources.tutu;
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
            this.fld_lblLabel49.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel49.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel49.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel49.BOSDescription = null;
            this.fld_lblLabel49.BOSError = null;
            this.fld_lblLabel49.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel49.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel49.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel49.BOSPropertyName = null;
            this.fld_lblLabel49.Location = new System.Drawing.Point(13, 106);
            this.fld_lblLabel49.Name = "fld_lblLabel49";
            this.fld_lblLabel49.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel49, true);
            this.fld_lblLabel49.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel49.TabIndex = 44;
            this.fld_lblLabel49.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel49.Text = "Điện thoại";
            // 
            // fld_lblLabel50
            // 
            this.fld_lblLabel50.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel50.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel50.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel50.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel50.Appearance.Options.UseFont = true;
            this.fld_lblLabel50.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel50.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel50.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel50.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel50.BOSDescription = null;
            this.fld_lblLabel50.BOSError = null;
            this.fld_lblLabel50.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel50.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel50.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel50.BOSPropertyName = null;
            this.fld_lblLabel50.Location = new System.Drawing.Point(296, 106);
            this.fld_lblLabel50.Name = "fld_lblLabel50";
            this.fld_lblLabel50.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel50, true);
            this.fld_lblLabel50.Size = new System.Drawing.Size(30, 13);
            this.fld_lblLabel50.TabIndex = 45;
            this.fld_lblLabel50.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel50.Text = "Số fax";
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
            this.bosGroupControl2.Controls.Add(this.fld_dgcARCustomerContacts);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 229);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(857, 368);
            this.bosGroupControl2.TabIndex = 15;
            this.bosGroupControl2.Text = "Danh sách người liên hệ";
            // 
            // fld_dgcARCustomerContacts
            // 
            this.fld_dgcARCustomerContacts.BOSComment = null;
            this.fld_dgcARCustomerContacts.BOSDataMember = null;
            this.fld_dgcARCustomerContacts.BOSDataSource = "ARCustomerContacts";
            this.fld_dgcARCustomerContacts.BOSDescription = null;
            this.fld_dgcARCustomerContacts.BOSError = null;
            this.fld_dgcARCustomerContacts.BOSFieldGroup = null;
            this.fld_dgcARCustomerContacts.BOSFieldRelation = null;
            this.fld_dgcARCustomerContacts.BOSGridType = null;
            this.fld_dgcARCustomerContacts.BOSPrivilege = null;
            this.fld_dgcARCustomerContacts.BOSPropertyName = null;
            this.fld_dgcARCustomerContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARCustomerContacts.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcARCustomerContacts.MenuManager = this.screenToolbar;
            this.fld_dgcARCustomerContacts.Name = "fld_dgcARCustomerContacts";
            this.fld_dgcARCustomerContacts.PrintReport = false;
            this.fld_dgcARCustomerContacts.Screen = null;
            this.fld_dgcARCustomerContacts.Size = new System.Drawing.Size(853, 344);
            this.fld_dgcARCustomerContacts.TabIndex = 16;
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
            this.fld_btnAddContact.TabIndex = 12;
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
            this.fld_btnDeleteContact.TabIndex = 14;
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
            this.fld_btnEditContact.TabIndex = 13;
            this.fld_btnEditContact.Text = "Sửa";
            this.fld_btnEditContact.Click += new System.EventHandler(this.fld_btnEditContact_Click);
            // 
            // fld_txtARCustomerContactComment
            // 
            this.fld_txtARCustomerContactComment.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactComment.BOSDataMember = "ARCustomerContactComment";
            this.fld_txtARCustomerContactComment.BOSDataSource = "ARCustomerContacts";
            this.fld_txtARCustomerContactComment.BOSDescription = null;
            this.fld_txtARCustomerContactComment.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactComment.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactComment.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactComment.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtARCustomerContactComment.BOSPropertyName = "Text";
            this.fld_txtARCustomerContactComment.Location = new System.Drawing.Point(106, 155);
            this.fld_txtARCustomerContactComment.Name = "fld_txtARCustomerContactComment";
            this.fld_txtARCustomerContactComment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerContactComment.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerContactComment.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerContactComment.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerContactComment.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerContactComment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerContactComment.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerContactComment, true);
            this.fld_txtARCustomerContactComment.Size = new System.Drawing.Size(398, 20);
            this.fld_txtARCustomerContactComment.TabIndex = 355;
            this.fld_txtARCustomerContactComment.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(13, 158);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(45, 13);
            this.bosLabel1.TabIndex = 356;
            this.bosLabel1.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.Text = "Thông tin";
            // 
            // fld_chkARCustomerContactTransactionContactInfo
            // 
            this.fld_chkARCustomerContactTransactionContactInfo.BOSComment = null;
            this.fld_chkARCustomerContactTransactionContactInfo.BOSDataMember = "ARCustomerContactTransactionContactInfo";
            this.fld_chkARCustomerContactTransactionContactInfo.BOSDataSource = "ARCustomerContacts";
            this.fld_chkARCustomerContactTransactionContactInfo.BOSDescription = null;
            this.fld_chkARCustomerContactTransactionContactInfo.BOSError = null;
            this.fld_chkARCustomerContactTransactionContactInfo.BOSFieldGroup = null;
            this.fld_chkARCustomerContactTransactionContactInfo.BOSFieldRelation = null;
            this.fld_chkARCustomerContactTransactionContactInfo.BOSPrivilege = null;
            this.fld_chkARCustomerContactTransactionContactInfo.BOSPropertyName = "EditValue";
            this.fld_chkARCustomerContactTransactionContactInfo.Location = new System.Drawing.Point(532, 155);
            this.fld_chkARCustomerContactTransactionContactInfo.MenuManager = this.screenToolbar;
            this.fld_chkARCustomerContactTransactionContactInfo.Name = "fld_chkARCustomerContactTransactionContactInfo";
            this.fld_chkARCustomerContactTransactionContactInfo.Properties.Caption = "Thông tin giao dịch";
            this.fld_chkARCustomerContactTransactionContactInfo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_chkARCustomerContactTransactionContactInfo, true);
            this.fld_chkARCustomerContactTransactionContactInfo.Size = new System.Drawing.Size(151, 19);
            this.fld_chkARCustomerContactTransactionContactInfo.TabIndex = 357;
            this.fld_chkARCustomerContactTransactionContactInfo.Tag = "DC";
            // 
            // DMCU103
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 599);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMCU103";
            this.Text = "Danh sách liên hệ";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkARCustomerContactDefaultAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactAddressLine3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactPhone1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactFax1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactEmail11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactTaxCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCustomerContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerContactComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkARCustomerContactTransactionContactInfo.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private ARCustomerContactsGridControl fld_dgcARCustomerContacts;
        private BOSComponent.BOSButton fld_btnAddContact;
        private BOSComponent.BOSButton fld_btnDeleteContact;
        private BOSComponent.BOSButton fld_btnEditContact;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSCheckEdit fld_chkARCustomerContactDefaultAddress;
        private BOSComponent.BOSTextBox fld_txtARCustomerContactAddressLine3;
        private BOSComponent.BOSTextBox fld_txtARCustomerContactPhone1;
        private BOSComponent.BOSTextBox fld_txtARCustomerContactFax1;
        private BOSComponent.BOSTextBox fld_txtARCustomerContactEmail11;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtARCustomerContactName;
        private BOSComponent.BOSTextBox fld_txtARCustomerContactTaxCode;
        private BOSComponent.BOSLabel fld_lblLabel35;
        private BOSComponent.BOSLabel fld_lblLabel38;
        private BOSComponent.BOSLabel fld_lblLabel48;
        private BOSComponent.BOSLabel fld_lblLabel49;
        private BOSComponent.BOSLabel fld_lblLabel50;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtARCustomerContactComment;
        private BOSComponent.BOSCheckEdit fld_chkARCustomerContactTransactionContactInfo;
	}
}
