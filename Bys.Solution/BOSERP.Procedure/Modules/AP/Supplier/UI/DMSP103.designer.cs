using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Supplier.UI
{
	/// <summary>
	/// Summary description for DMSP103
	/// </summary>
	partial class DMSP103
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMSP103));
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_txtAPSupplierContactLevel = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_dtpAPSupplierContactBirthday = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtAPSupplierContactAddressCountry = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierContactAddressLine1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierContactPhone1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierContactFax1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierContactEmail11 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierContactAddressPostalCode = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierContactAddressStateProvince = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierContactAddressCity = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPSupplierContactName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierContactTitle1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierContactCellPhone1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel35 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel38 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel45 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel48 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel49 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel50 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcAPSupplierContacts = new BOSERP.Modules.Supplier.APSupplierContactsGridControl();
            this.fld_btnEditContact = new BOSComponent.BOSButton(this.components);
            this.fld_btnDeleteContact = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddContact = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtpAPSupplierContactBirthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtpAPSupplierContactBirthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactAddressCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactAddressLine1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactPhone1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactFax1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactEmail11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactAddressPostalCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactAddressStateProvince.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactAddressCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactTitle1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactCellPhone1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPSupplierContacts)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.bosGroupControl1.Controls.Add(this.fld_txtAPSupplierContactLevel);
            this.bosGroupControl1.Controls.Add(this.bosLabel7);
            this.bosGroupControl1.Controls.Add(this.fld_dtpAPSupplierContactBirthday);
            this.bosGroupControl1.Controls.Add(this.fld_txtAPSupplierContactAddressCountry);
            this.bosGroupControl1.Controls.Add(this.fld_txtAPSupplierContactAddressLine1);
            this.bosGroupControl1.Controls.Add(this.fld_txtAPSupplierContactPhone1);
            this.bosGroupControl1.Controls.Add(this.fld_txtAPSupplierContactFax1);
            this.bosGroupControl1.Controls.Add(this.fld_txtAPSupplierContactEmail11);
            this.bosGroupControl1.Controls.Add(this.fld_txtAPSupplierContactAddressPostalCode);
            this.bosGroupControl1.Controls.Add(this.fld_txtAPSupplierContactAddressStateProvince);
            this.bosGroupControl1.Controls.Add(this.fld_txtAPSupplierContactAddressCity);
            this.bosGroupControl1.Controls.Add(this.bosLabel6);
            this.bosGroupControl1.Controls.Add(this.bosLabel5);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_txtAPSupplierContactName);
            this.bosGroupControl1.Controls.Add(this.fld_txtAPSupplierContactTitle1);
            this.bosGroupControl1.Controls.Add(this.fld_txtAPSupplierContactCellPhone1);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel35);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel38);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel45);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel48);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel49);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel50);
            this.bosGroupControl1.Location = new System.Drawing.Point(5, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(877, 256);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Thông tin người liên hệ";
            // 
            // fld_txtAPSupplierContactLevel
            // 
            this.fld_txtAPSupplierContactLevel.BOSComment = "";
            this.fld_txtAPSupplierContactLevel.BOSDataMember = "APSupplierContactLevel";
            this.fld_txtAPSupplierContactLevel.BOSDataSource = "APSupplierContacts";
            this.fld_txtAPSupplierContactLevel.BOSDescription = null;
            this.fld_txtAPSupplierContactLevel.BOSError = "";
            this.fld_txtAPSupplierContactLevel.BOSFieldGroup = "";
            this.fld_txtAPSupplierContactLevel.BOSFieldRelation = "";
            this.fld_txtAPSupplierContactLevel.BOSPrivilege = "";
            this.fld_txtAPSupplierContactLevel.BOSPropertyName = "Text";
            this.fld_txtAPSupplierContactLevel.Location = new System.Drawing.Point(356, 32);
            this.fld_txtAPSupplierContactLevel.Name = "fld_txtAPSupplierContactLevel";
            this.fld_txtAPSupplierContactLevel.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierContactLevel.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierContactLevel.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierContactLevel.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierContactLevel.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierContactLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierContactLevel.Screen = null;
            this.fld_txtAPSupplierContactLevel.Size = new System.Drawing.Size(145, 20);
            this.fld_txtAPSupplierContactLevel.TabIndex = 25;
            this.fld_txtAPSupplierContactLevel.Tag = "DC";
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
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(295, 35);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(40, 13);
            this.bosLabel7.TabIndex = 24;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Chức vụ";
            // 
            // fld_dtpAPSupplierContactBirthday
            // 
            this.fld_dtpAPSupplierContactBirthday.BOSComment = "";
            this.fld_dtpAPSupplierContactBirthday.BOSDataMember = "APSupplierContactBirthday";
            this.fld_dtpAPSupplierContactBirthday.BOSDataSource = "APSupplierContacts";
            this.fld_dtpAPSupplierContactBirthday.BOSDescription = null;
            this.fld_dtpAPSupplierContactBirthday.BOSError = "";
            this.fld_dtpAPSupplierContactBirthday.BOSFieldGroup = "";
            this.fld_dtpAPSupplierContactBirthday.BOSFieldRelation = null;
            this.fld_dtpAPSupplierContactBirthday.BOSPrivilege = "";
            this.fld_dtpAPSupplierContactBirthday.BOSPropertyName = "EditValue";
            this.fld_dtpAPSupplierContactBirthday.EditValue = null;
            this.fld_dtpAPSupplierContactBirthday.Location = new System.Drawing.Point(103, 84);
            this.fld_dtpAPSupplierContactBirthday.Name = "fld_dtpAPSupplierContactBirthday";
            this.fld_dtpAPSupplierContactBirthday.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dtpAPSupplierContactBirthday.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_dtpAPSupplierContactBirthday.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dtpAPSupplierContactBirthday.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dtpAPSupplierContactBirthday.Properties.Appearance.Options.UseFont = true;
            this.fld_dtpAPSupplierContactBirthday.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dtpAPSupplierContactBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dtpAPSupplierContactBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dtpAPSupplierContactBirthday.Screen = null;
            this.fld_dtpAPSupplierContactBirthday.Size = new System.Drawing.Size(145, 20);
            this.fld_dtpAPSupplierContactBirthday.TabIndex = 5;
            this.fld_dtpAPSupplierContactBirthday.Tag = "DC";
            // 
            // fld_txtAPSupplierContactAddressCountry
            // 
            this.fld_txtAPSupplierContactAddressCountry.BOSComment = "";
            this.fld_txtAPSupplierContactAddressCountry.BOSDataMember = "APSupplierContactAddressCountry";
            this.fld_txtAPSupplierContactAddressCountry.BOSDataSource = "APSupplierContacts";
            this.fld_txtAPSupplierContactAddressCountry.BOSDescription = null;
            this.fld_txtAPSupplierContactAddressCountry.BOSError = "";
            this.fld_txtAPSupplierContactAddressCountry.BOSFieldGroup = "";
            this.fld_txtAPSupplierContactAddressCountry.BOSFieldRelation = "";
            this.fld_txtAPSupplierContactAddressCountry.BOSPrivilege = "";
            this.fld_txtAPSupplierContactAddressCountry.BOSPropertyName = "Text";
            this.fld_txtAPSupplierContactAddressCountry.Location = new System.Drawing.Point(103, 214);
            this.fld_txtAPSupplierContactAddressCountry.Name = "fld_txtAPSupplierContactAddressCountry";
            this.fld_txtAPSupplierContactAddressCountry.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierContactAddressCountry.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierContactAddressCountry.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierContactAddressCountry.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierContactAddressCountry.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierContactAddressCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierContactAddressCountry.Screen = null;
            this.fld_txtAPSupplierContactAddressCountry.Size = new System.Drawing.Size(145, 20);
            this.fld_txtAPSupplierContactAddressCountry.TabIndex = 21;
            this.fld_txtAPSupplierContactAddressCountry.Tag = "DC";
            // 
            // fld_txtAPSupplierContactAddressLine1
            // 
            this.fld_txtAPSupplierContactAddressLine1.BOSComment = "";
            this.fld_txtAPSupplierContactAddressLine1.BOSDataMember = "APSupplierContactAddressLine1";
            this.fld_txtAPSupplierContactAddressLine1.BOSDataSource = "APSupplierContacts";
            this.fld_txtAPSupplierContactAddressLine1.BOSDescription = null;
            this.fld_txtAPSupplierContactAddressLine1.BOSError = "";
            this.fld_txtAPSupplierContactAddressLine1.BOSFieldGroup = "";
            this.fld_txtAPSupplierContactAddressLine1.BOSFieldRelation = "";
            this.fld_txtAPSupplierContactAddressLine1.BOSPrivilege = "";
            this.fld_txtAPSupplierContactAddressLine1.BOSPropertyName = "Text";
            this.fld_txtAPSupplierContactAddressLine1.Location = new System.Drawing.Point(103, 162);
            this.fld_txtAPSupplierContactAddressLine1.Name = "fld_txtAPSupplierContactAddressLine1";
            this.fld_txtAPSupplierContactAddressLine1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierContactAddressLine1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierContactAddressLine1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierContactAddressLine1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierContactAddressLine1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierContactAddressLine1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierContactAddressLine1.Screen = null;
            this.fld_txtAPSupplierContactAddressLine1.Size = new System.Drawing.Size(398, 20);
            this.fld_txtAPSupplierContactAddressLine1.TabIndex = 15;
            this.fld_txtAPSupplierContactAddressLine1.Tag = "DC";
            // 
            // fld_txtAPSupplierContactPhone1
            // 
            this.fld_txtAPSupplierContactPhone1.BOSComment = "";
            this.fld_txtAPSupplierContactPhone1.BOSDataMember = "APSupplierContactPhone";
            this.fld_txtAPSupplierContactPhone1.BOSDataSource = "APSupplierContacts";
            this.fld_txtAPSupplierContactPhone1.BOSDescription = null;
            this.fld_txtAPSupplierContactPhone1.BOSError = "";
            this.fld_txtAPSupplierContactPhone1.BOSFieldGroup = "";
            this.fld_txtAPSupplierContactPhone1.BOSFieldRelation = "";
            this.fld_txtAPSupplierContactPhone1.BOSPrivilege = "";
            this.fld_txtAPSupplierContactPhone1.BOSPropertyName = "Text";
            this.fld_txtAPSupplierContactPhone1.Location = new System.Drawing.Point(356, 84);
            this.fld_txtAPSupplierContactPhone1.Name = "fld_txtAPSupplierContactPhone1";
            this.fld_txtAPSupplierContactPhone1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierContactPhone1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierContactPhone1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierContactPhone1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierContactPhone1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierContactPhone1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierContactPhone1.Screen = null;
            this.fld_txtAPSupplierContactPhone1.Size = new System.Drawing.Size(145, 20);
            this.fld_txtAPSupplierContactPhone1.TabIndex = 7;
            this.fld_txtAPSupplierContactPhone1.Tag = "DC";
            // 
            // fld_txtAPSupplierContactFax1
            // 
            this.fld_txtAPSupplierContactFax1.BOSComment = "";
            this.fld_txtAPSupplierContactFax1.BOSDataMember = "APSupplierContactFax";
            this.fld_txtAPSupplierContactFax1.BOSDataSource = "APSupplierContacts";
            this.fld_txtAPSupplierContactFax1.BOSDescription = null;
            this.fld_txtAPSupplierContactFax1.BOSError = "";
            this.fld_txtAPSupplierContactFax1.BOSFieldGroup = "";
            this.fld_txtAPSupplierContactFax1.BOSFieldRelation = "";
            this.fld_txtAPSupplierContactFax1.BOSPrivilege = "";
            this.fld_txtAPSupplierContactFax1.BOSPropertyName = "Text";
            this.fld_txtAPSupplierContactFax1.Location = new System.Drawing.Point(356, 110);
            this.fld_txtAPSupplierContactFax1.Name = "fld_txtAPSupplierContactFax1";
            this.fld_txtAPSupplierContactFax1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierContactFax1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierContactFax1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierContactFax1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierContactFax1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierContactFax1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierContactFax1.Screen = null;
            this.fld_txtAPSupplierContactFax1.Size = new System.Drawing.Size(145, 20);
            this.fld_txtAPSupplierContactFax1.TabIndex = 11;
            this.fld_txtAPSupplierContactFax1.Tag = "DC";
            // 
            // fld_txtAPSupplierContactEmail11
            // 
            this.fld_txtAPSupplierContactEmail11.BOSComment = "";
            this.fld_txtAPSupplierContactEmail11.BOSDataMember = "APSupplierContactEmail1";
            this.fld_txtAPSupplierContactEmail11.BOSDataSource = "APSupplierContacts";
            this.fld_txtAPSupplierContactEmail11.BOSDescription = null;
            this.fld_txtAPSupplierContactEmail11.BOSError = "";
            this.fld_txtAPSupplierContactEmail11.BOSFieldGroup = "";
            this.fld_txtAPSupplierContactEmail11.BOSFieldRelation = "";
            this.fld_txtAPSupplierContactEmail11.BOSPrivilege = "";
            this.fld_txtAPSupplierContactEmail11.BOSPropertyName = "Text";
            this.fld_txtAPSupplierContactEmail11.Location = new System.Drawing.Point(103, 136);
            this.fld_txtAPSupplierContactEmail11.Name = "fld_txtAPSupplierContactEmail11";
            this.fld_txtAPSupplierContactEmail11.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierContactEmail11.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierContactEmail11.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierContactEmail11.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierContactEmail11.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierContactEmail11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierContactEmail11.Screen = null;
            this.fld_txtAPSupplierContactEmail11.Size = new System.Drawing.Size(398, 20);
            this.fld_txtAPSupplierContactEmail11.TabIndex = 13;
            this.fld_txtAPSupplierContactEmail11.Tag = "DC";
            // 
            // fld_txtAPSupplierContactAddressPostalCode
            // 
            this.fld_txtAPSupplierContactAddressPostalCode.BOSComment = "";
            this.fld_txtAPSupplierContactAddressPostalCode.BOSDataMember = "APSupplierContactAddressPostalCode";
            this.fld_txtAPSupplierContactAddressPostalCode.BOSDataSource = "APSupplierContacts";
            this.fld_txtAPSupplierContactAddressPostalCode.BOSDescription = null;
            this.fld_txtAPSupplierContactAddressPostalCode.BOSError = "";
            this.fld_txtAPSupplierContactAddressPostalCode.BOSFieldGroup = "";
            this.fld_txtAPSupplierContactAddressPostalCode.BOSFieldRelation = "";
            this.fld_txtAPSupplierContactAddressPostalCode.BOSPrivilege = "";
            this.fld_txtAPSupplierContactAddressPostalCode.BOSPropertyName = "Text";
            this.fld_txtAPSupplierContactAddressPostalCode.Location = new System.Drawing.Point(356, 214);
            this.fld_txtAPSupplierContactAddressPostalCode.Name = "fld_txtAPSupplierContactAddressPostalCode";
            this.fld_txtAPSupplierContactAddressPostalCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierContactAddressPostalCode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierContactAddressPostalCode.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierContactAddressPostalCode.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierContactAddressPostalCode.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierContactAddressPostalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierContactAddressPostalCode.Screen = null;
            this.fld_txtAPSupplierContactAddressPostalCode.Size = new System.Drawing.Size(145, 20);
            this.fld_txtAPSupplierContactAddressPostalCode.TabIndex = 23;
            this.fld_txtAPSupplierContactAddressPostalCode.Tag = "DC";
            // 
            // fld_txtAPSupplierContactAddressStateProvince
            // 
            this.fld_txtAPSupplierContactAddressStateProvince.BOSComment = "";
            this.fld_txtAPSupplierContactAddressStateProvince.BOSDataMember = "APSupplierContactAddressStateProvince";
            this.fld_txtAPSupplierContactAddressStateProvince.BOSDataSource = "APSupplierContacts";
            this.fld_txtAPSupplierContactAddressStateProvince.BOSDescription = null;
            this.fld_txtAPSupplierContactAddressStateProvince.BOSError = "";
            this.fld_txtAPSupplierContactAddressStateProvince.BOSFieldGroup = "";
            this.fld_txtAPSupplierContactAddressStateProvince.BOSFieldRelation = "";
            this.fld_txtAPSupplierContactAddressStateProvince.BOSPrivilege = "";
            this.fld_txtAPSupplierContactAddressStateProvince.BOSPropertyName = "Text";
            this.fld_txtAPSupplierContactAddressStateProvince.Location = new System.Drawing.Point(356, 188);
            this.fld_txtAPSupplierContactAddressStateProvince.Name = "fld_txtAPSupplierContactAddressStateProvince";
            this.fld_txtAPSupplierContactAddressStateProvince.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierContactAddressStateProvince.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierContactAddressStateProvince.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierContactAddressStateProvince.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierContactAddressStateProvince.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierContactAddressStateProvince.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierContactAddressStateProvince.Screen = null;
            this.fld_txtAPSupplierContactAddressStateProvince.Size = new System.Drawing.Size(145, 20);
            this.fld_txtAPSupplierContactAddressStateProvince.TabIndex = 19;
            this.fld_txtAPSupplierContactAddressStateProvince.Tag = "DC";
            // 
            // fld_txtAPSupplierContactAddressCity
            // 
            this.fld_txtAPSupplierContactAddressCity.BOSComment = "";
            this.fld_txtAPSupplierContactAddressCity.BOSDataMember = "APSupplierContactAddressCity";
            this.fld_txtAPSupplierContactAddressCity.BOSDataSource = "APSupplierContacts";
            this.fld_txtAPSupplierContactAddressCity.BOSDescription = null;
            this.fld_txtAPSupplierContactAddressCity.BOSError = "";
            this.fld_txtAPSupplierContactAddressCity.BOSFieldGroup = "";
            this.fld_txtAPSupplierContactAddressCity.BOSFieldRelation = "";
            this.fld_txtAPSupplierContactAddressCity.BOSPrivilege = "";
            this.fld_txtAPSupplierContactAddressCity.BOSPropertyName = "Text";
            this.fld_txtAPSupplierContactAddressCity.Location = new System.Drawing.Point(103, 188);
            this.fld_txtAPSupplierContactAddressCity.Name = "fld_txtAPSupplierContactAddressCity";
            this.fld_txtAPSupplierContactAddressCity.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierContactAddressCity.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierContactAddressCity.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierContactAddressCity.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierContactAddressCity.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierContactAddressCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierContactAddressCity.Screen = null;
            this.fld_txtAPSupplierContactAddressCity.Size = new System.Drawing.Size(145, 20);
            this.fld_txtAPSupplierContactAddressCity.TabIndex = 17;
            this.fld_txtAPSupplierContactAddressCity.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(295, 216);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(42, 13);
            this.bosLabel6.TabIndex = 22;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Mã vùng";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(295, 191);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(21, 13);
            this.bosLabel5.TabIndex = 18;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Tỉnh";
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
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(18, 191);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(52, 13);
            this.bosLabel1.TabIndex = 16;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Thành phố";
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
            this.bosLabel2.Location = new System.Drawing.Point(18, 165);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(33, 13);
            this.bosLabel2.TabIndex = 14;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Địa chỉ";
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
            this.bosLabel3.Location = new System.Drawing.Point(18, 216);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(43, 13);
            this.bosLabel3.TabIndex = 20;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Quốc gia";
            // 
            // fld_txtAPSupplierContactName
            // 
            this.fld_txtAPSupplierContactName.BOSComment = "";
            this.fld_txtAPSupplierContactName.BOSDataMember = "APSupplierContactName";
            this.fld_txtAPSupplierContactName.BOSDataSource = "APSupplierContacts";
            this.fld_txtAPSupplierContactName.BOSDescription = null;
            this.fld_txtAPSupplierContactName.BOSError = "";
            this.fld_txtAPSupplierContactName.BOSFieldGroup = "";
            this.fld_txtAPSupplierContactName.BOSFieldRelation = "";
            this.fld_txtAPSupplierContactName.BOSPrivilege = "";
            this.fld_txtAPSupplierContactName.BOSPropertyName = "Text";
            this.fld_txtAPSupplierContactName.Location = new System.Drawing.Point(103, 58);
            this.fld_txtAPSupplierContactName.Name = "fld_txtAPSupplierContactName";
            this.fld_txtAPSupplierContactName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierContactName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierContactName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierContactName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierContactName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierContactName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierContactName.Screen = null;
            this.fld_txtAPSupplierContactName.Size = new System.Drawing.Size(398, 20);
            this.fld_txtAPSupplierContactName.TabIndex = 3;
            this.fld_txtAPSupplierContactName.Tag = "DC";
            // 
            // fld_txtAPSupplierContactTitle1
            // 
            this.fld_txtAPSupplierContactTitle1.BOSComment = "";
            this.fld_txtAPSupplierContactTitle1.BOSDataMember = "APSupplierContactTitle";
            this.fld_txtAPSupplierContactTitle1.BOSDataSource = "APSupplierContacts";
            this.fld_txtAPSupplierContactTitle1.BOSDescription = null;
            this.fld_txtAPSupplierContactTitle1.BOSError = "";
            this.fld_txtAPSupplierContactTitle1.BOSFieldGroup = "";
            this.fld_txtAPSupplierContactTitle1.BOSFieldRelation = "";
            this.fld_txtAPSupplierContactTitle1.BOSPrivilege = "";
            this.fld_txtAPSupplierContactTitle1.BOSPropertyName = "Text";
            this.fld_txtAPSupplierContactTitle1.Location = new System.Drawing.Point(103, 32);
            this.fld_txtAPSupplierContactTitle1.Name = "fld_txtAPSupplierContactTitle1";
            this.fld_txtAPSupplierContactTitle1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierContactTitle1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierContactTitle1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierContactTitle1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierContactTitle1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierContactTitle1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierContactTitle1.Screen = null;
            this.fld_txtAPSupplierContactTitle1.Size = new System.Drawing.Size(145, 20);
            this.fld_txtAPSupplierContactTitle1.TabIndex = 1;
            this.fld_txtAPSupplierContactTitle1.Tag = "DC";
            // 
            // fld_txtAPSupplierContactCellPhone1
            // 
            this.fld_txtAPSupplierContactCellPhone1.BOSComment = "";
            this.fld_txtAPSupplierContactCellPhone1.BOSDataMember = "APSupplierContactCellPhone";
            this.fld_txtAPSupplierContactCellPhone1.BOSDataSource = "APSupplierContacts";
            this.fld_txtAPSupplierContactCellPhone1.BOSDescription = null;
            this.fld_txtAPSupplierContactCellPhone1.BOSError = "";
            this.fld_txtAPSupplierContactCellPhone1.BOSFieldGroup = "";
            this.fld_txtAPSupplierContactCellPhone1.BOSFieldRelation = "";
            this.fld_txtAPSupplierContactCellPhone1.BOSPrivilege = "";
            this.fld_txtAPSupplierContactCellPhone1.BOSPropertyName = "Text";
            this.fld_txtAPSupplierContactCellPhone1.Location = new System.Drawing.Point(103, 110);
            this.fld_txtAPSupplierContactCellPhone1.Name = "fld_txtAPSupplierContactCellPhone1";
            this.fld_txtAPSupplierContactCellPhone1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierContactCellPhone1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierContactCellPhone1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierContactCellPhone1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierContactCellPhone1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierContactCellPhone1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierContactCellPhone1.Screen = null;
            this.fld_txtAPSupplierContactCellPhone1.Size = new System.Drawing.Size(145, 20);
            this.fld_txtAPSupplierContactCellPhone1.TabIndex = 9;
            this.fld_txtAPSupplierContactCellPhone1.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseFont = true;
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
            this.bosLabel4.Location = new System.Drawing.Point(18, 87);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(47, 13);
            this.bosLabel4.TabIndex = 4;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Ngày sinh";
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
            this.fld_lblLabel35.Location = new System.Drawing.Point(18, 61);
            this.fld_lblLabel35.Name = "fld_lblLabel35";
            this.fld_lblLabel35.Screen = null;
            this.fld_lblLabel35.Size = new System.Drawing.Size(19, 13);
            this.fld_lblLabel35.TabIndex = 2;
            this.fld_lblLabel35.Tag = "";
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
            this.fld_lblLabel38.BOSComment = "";
            this.fld_lblLabel38.BOSDataMember = "";
            this.fld_lblLabel38.BOSDataSource = "";
            this.fld_lblLabel38.BOSDescription = null;
            this.fld_lblLabel38.BOSError = null;
            this.fld_lblLabel38.BOSFieldGroup = "";
            this.fld_lblLabel38.BOSFieldRelation = "";
            this.fld_lblLabel38.BOSPrivilege = "";
            this.fld_lblLabel38.BOSPropertyName = null;
            this.fld_lblLabel38.Location = new System.Drawing.Point(18, 113);
            this.fld_lblLabel38.Name = "fld_lblLabel38";
            this.fld_lblLabel38.Screen = null;
            this.fld_lblLabel38.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabel38.TabIndex = 8;
            this.fld_lblLabel38.Tag = "";
            this.fld_lblLabel38.Text = "Điện thoại DĐ";
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
            this.fld_lblLabel45.Location = new System.Drawing.Point(18, 35);
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
            this.fld_lblLabel48.Location = new System.Drawing.Point(18, 139);
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
            this.fld_lblLabel49.Location = new System.Drawing.Point(295, 87);
            this.fld_lblLabel49.Name = "fld_lblLabel49";
            this.fld_lblLabel49.Screen = null;
            this.fld_lblLabel49.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel49.TabIndex = 6;
            this.fld_lblLabel49.Tag = "";
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
            this.fld_lblLabel50.BOSComment = "";
            this.fld_lblLabel50.BOSDataMember = "";
            this.fld_lblLabel50.BOSDataSource = "";
            this.fld_lblLabel50.BOSDescription = null;
            this.fld_lblLabel50.BOSError = null;
            this.fld_lblLabel50.BOSFieldGroup = "";
            this.fld_lblLabel50.BOSFieldRelation = "";
            this.fld_lblLabel50.BOSPrivilege = "";
            this.fld_lblLabel50.BOSPropertyName = null;
            this.fld_lblLabel50.Location = new System.Drawing.Point(295, 113);
            this.fld_lblLabel50.Name = "fld_lblLabel50";
            this.fld_lblLabel50.Screen = null;
            this.fld_lblLabel50.Size = new System.Drawing.Size(30, 13);
            this.fld_lblLabel50.TabIndex = 10;
            this.fld_lblLabel50.Tag = "";
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
            this.bosGroupControl2.Controls.Add(this.fld_dgcAPSupplierContacts);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 295);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(884, 283);
            this.bosGroupControl2.TabIndex = 6;
            this.bosGroupControl2.Text = "Danh sách người liên hệ";
            // 
            // fld_dgcAPSupplierContacts
            // 
            this.fld_dgcAPSupplierContacts.BOSComment = null;
            this.fld_dgcAPSupplierContacts.BOSDataMember = null;
            this.fld_dgcAPSupplierContacts.BOSDataSource = "APSupplierContacts";
            this.fld_dgcAPSupplierContacts.BOSDescription = null;
            this.fld_dgcAPSupplierContacts.BOSError = null;
            this.fld_dgcAPSupplierContacts.BOSFieldGroup = null;
            this.fld_dgcAPSupplierContacts.BOSFieldRelation = null;
            this.fld_dgcAPSupplierContacts.BOSGridType = null;
            this.fld_dgcAPSupplierContacts.BOSPrivilege = null;
            this.fld_dgcAPSupplierContacts.BOSPropertyName = null;
            this.fld_dgcAPSupplierContacts.CommodityType = "";
            this.fld_dgcAPSupplierContacts.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcAPSupplierContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcAPSupplierContacts.Location = new System.Drawing.Point(2, 23);
            this.fld_dgcAPSupplierContacts.MenuManager = this.screenToolbar;
            this.fld_dgcAPSupplierContacts.Name = "fld_dgcAPSupplierContacts";
            this.fld_dgcAPSupplierContacts.PrintReport = false;
            this.fld_dgcAPSupplierContacts.Screen = null;
            this.fld_dgcAPSupplierContacts.Size = new System.Drawing.Size(880, 258);
            this.fld_dgcAPSupplierContacts.TabIndex = 7;
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
            this.fld_btnEditContact.Location = new System.Drawing.Point(728, 264);
            this.fld_btnEditContact.Name = "fld_btnEditContact";
            this.fld_btnEditContact.Screen = null;
            this.fld_btnEditContact.Size = new System.Drawing.Size(75, 27);
            this.fld_btnEditContact.TabIndex = 4;
            this.fld_btnEditContact.Text = "Sửa";
            this.fld_btnEditContact.Click += new System.EventHandler(this.fld_btnEditContact_Click);
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
            this.fld_btnDeleteContact.Location = new System.Drawing.Point(809, 264);
            this.fld_btnDeleteContact.Name = "fld_btnDeleteContact";
            this.fld_btnDeleteContact.Screen = null;
            this.fld_btnDeleteContact.Size = new System.Drawing.Size(75, 27);
            this.fld_btnDeleteContact.TabIndex = 5;
            this.fld_btnDeleteContact.Text = "Xóa";
            this.fld_btnDeleteContact.Click += new System.EventHandler(this.fld_btnDeleteContact_Click);
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
            this.fld_btnAddContact.Location = new System.Drawing.Point(647, 264);
            this.fld_btnAddContact.Name = "fld_btnAddContact";
            this.fld_btnAddContact.Screen = null;
            this.fld_btnAddContact.Size = new System.Drawing.Size(75, 27);
            this.fld_btnAddContact.TabIndex = 3;
            this.fld_btnAddContact.Text = "Thêm";
            this.fld_btnAddContact.Click += new System.EventHandler(this.fld_btnAddContact_Click);
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
            this.bosPanel1.Controls.Add(this.fld_btnAddContact);
            this.bosPanel1.Controls.Add(this.fld_btnDeleteContact);
            this.bosPanel1.Controls.Add(this.fld_btnEditContact);
            this.bosPanel1.Controls.Add(this.bosGroupControl2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(890, 581);
            this.bosPanel1.TabIndex = 6;
            // 
            // DMSP103
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(890, 581);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMSP103.IconOptions.Icon")));
            this.Name = "DMSP103";
            this.Text = "Danh sách liên hệ";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtpAPSupplierContactBirthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtpAPSupplierContactBirthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactAddressCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactAddressLine1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactPhone1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactFax1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactEmail11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactAddressPostalCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactAddressStateProvince.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactAddressCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactTitle1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierContactCellPhone1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPSupplierContacts)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSDateEdit fld_dtpAPSupplierContactBirthday;
        private BOSComponent.BOSTextBox fld_txtAPSupplierContactAddressCountry;
        private BOSComponent.BOSTextBox fld_txtAPSupplierContactAddressLine1;
        private BOSComponent.BOSTextBox fld_txtAPSupplierContactPhone1;
        private BOSComponent.BOSTextBox fld_txtAPSupplierContactFax1;
        private BOSComponent.BOSTextBox fld_txtAPSupplierContactEmail11;
        private BOSComponent.BOSTextBox fld_txtAPSupplierContactAddressPostalCode;
        private BOSComponent.BOSTextBox fld_txtAPSupplierContactAddressStateProvince;
        private BOSComponent.BOSTextBox fld_txtAPSupplierContactAddressCity;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtAPSupplierContactName;
        private BOSComponent.BOSTextBox fld_txtAPSupplierContactTitle1;
        private BOSComponent.BOSTextBox fld_txtAPSupplierContactCellPhone1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel fld_lblLabel35;
        private BOSComponent.BOSLabel fld_lblLabel38;
        private BOSComponent.BOSLabel fld_lblLabel45;
        private BOSComponent.BOSLabel fld_lblLabel48;
        private BOSComponent.BOSLabel fld_lblLabel49;
        private BOSComponent.BOSLabel fld_lblLabel50;
        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private APSupplierContactsGridControl fld_dgcAPSupplierContacts;
        private BOSComponent.BOSButton fld_btnEditContact;
        private BOSComponent.BOSButton fld_btnDeleteContact;
        private BOSComponent.BOSButton fld_btnAddContact;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTextBox fld_txtAPSupplierContactLevel;
        private BOSComponent.BOSLabel bosLabel7;
    }
}
