using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.WorkShop.UI
{
	/// <summary>
	/// Summary description for DMWS100
	/// </summary>
	partial class DMWS100
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
            this.fld_grcGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lblLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel30 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel32 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel38 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel41 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel42 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel43 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel45 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMWorkShopContactTitle = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMWorkShopContactFirstName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMWorkShopContactPhone = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMWorkShopContactFax = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMWorkShopContactCellPhone = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMWorkShopContactEmail = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMWorkShopContactDepartment = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMLineContactRoom = new BOSComponent.BOSTextBox(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_bedGELocationName = new BOSComponent.BOSButtonEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_medMMWorkShopDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMWorkShopLength = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMWorkShopNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_chkMMWorkShopActiveCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_txtMMWorkShopWidth = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMWorkShopName = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnInsertValueByEmployee = new BOSComponent.BOSButton(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).BeginInit();
            this.fld_grcGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactCellPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactRoom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedGELocationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMWorkShopDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkMMWorkShopActiveCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopName.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl3);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(890, 568);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_grcGroupControl3
            // 
            this.fld_grcGroupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl3.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl3.BOSComment = "";
            this.fld_grcGroupControl3.BOSDataMember = null;
            this.fld_grcGroupControl3.BOSDataSource = null;
            this.fld_grcGroupControl3.BOSDescription = null;
            this.fld_grcGroupControl3.BOSError = null;
            this.fld_grcGroupControl3.BOSFieldGroup = "";
            this.fld_grcGroupControl3.BOSFieldRelation = null;
            this.fld_grcGroupControl3.BOSPrivilege = "";
            this.fld_grcGroupControl3.BOSPropertyName = null;
            this.fld_grcGroupControl3.Controls.Add(this.fld_btnInsertValueByEmployee);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel27);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel30);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel32);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel38);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel41);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel42);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel43);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel45);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtMMWorkShopContactTitle);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtMMWorkShopContactFirstName);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtMMWorkShopContactPhone);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtMMWorkShopContactFax);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtMMWorkShopContactCellPhone);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtMMWorkShopContactEmail);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtMMWorkShopContactDepartment);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtMMLineContactRoom);
            this.fld_grcGroupControl3.Location = new System.Drawing.Point(3, 162);
            this.fld_grcGroupControl3.Name = "fld_grcGroupControl3";
            this.fld_grcGroupControl3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl3, true);
            this.fld_grcGroupControl3.Size = new System.Drawing.Size(884, 169);
            this.fld_grcGroupControl3.TabIndex = 1;
            this.fld_grcGroupControl3.Text = "Người liên lạc";
            // 
            // fld_lblLabel27
            // 
            this.fld_lblLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel27.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel27.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel27.Appearance.Options.UseFont = true;
            this.fld_lblLabel27.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel27.BOSComment = "";
            this.fld_lblLabel27.BOSDataMember = "";
            this.fld_lblLabel27.BOSDataSource = "";
            this.fld_lblLabel27.BOSDescription = null;
            this.fld_lblLabel27.BOSError = null;
            this.fld_lblLabel27.BOSFieldGroup = "";
            this.fld_lblLabel27.BOSFieldRelation = "";
            this.fld_lblLabel27.BOSPrivilege = "";
            this.fld_lblLabel27.BOSPropertyName = null;
            this.fld_lblLabel27.Location = new System.Drawing.Point(26, 53);
            this.fld_lblLabel27.Name = "fld_lblLabel27";
            this.fld_lblLabel27.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel27, true);
            this.fld_lblLabel27.Size = new System.Drawing.Size(22, 13);
            this.fld_lblLabel27.TabIndex = 51;
            this.fld_lblLabel27.Tag = "";
            this.fld_lblLabel27.Text = "Tên ";
            // 
            // fld_lblLabel30
            // 
            this.fld_lblLabel30.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel30.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel30.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel30.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel30.Appearance.Options.UseFont = true;
            this.fld_lblLabel30.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel30.BOSComment = "";
            this.fld_lblLabel30.BOSDataMember = "";
            this.fld_lblLabel30.BOSDataSource = "";
            this.fld_lblLabel30.BOSDescription = null;
            this.fld_lblLabel30.BOSError = null;
            this.fld_lblLabel30.BOSFieldGroup = "";
            this.fld_lblLabel30.BOSFieldRelation = "";
            this.fld_lblLabel30.BOSPrivilege = "";
            this.fld_lblLabel30.BOSPropertyName = null;
            this.fld_lblLabel30.Location = new System.Drawing.Point(303, 78);
            this.fld_lblLabel30.Name = "fld_lblLabel30";
            this.fld_lblLabel30.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel30, true);
            this.fld_lblLabel30.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabel30.TabIndex = 54;
            this.fld_lblLabel30.Tag = "";
            this.fld_lblLabel30.Text = "Điện thoại DĐ";
            // 
            // fld_lblLabel32
            // 
            this.fld_lblLabel32.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel32.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel32.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel32.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel32.Appearance.Options.UseFont = true;
            this.fld_lblLabel32.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel32.BOSComment = "";
            this.fld_lblLabel32.BOSDataMember = "";
            this.fld_lblLabel32.BOSDataSource = "";
            this.fld_lblLabel32.BOSDescription = null;
            this.fld_lblLabel32.BOSError = null;
            this.fld_lblLabel32.BOSFieldGroup = "";
            this.fld_lblLabel32.BOSFieldRelation = "";
            this.fld_lblLabel32.BOSPrivilege = "";
            this.fld_lblLabel32.BOSPropertyName = null;
            this.fld_lblLabel32.Location = new System.Drawing.Point(26, 128);
            this.fld_lblLabel32.Name = "fld_lblLabel32";
            this.fld_lblLabel32.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel32, true);
            this.fld_lblLabel32.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel32.TabIndex = 56;
            this.fld_lblLabel32.Tag = "";
            this.fld_lblLabel32.Text = "Bộ phận";
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
            this.fld_lblLabel38.Location = new System.Drawing.Point(26, 28);
            this.fld_lblLabel38.Name = "fld_lblLabel38";
            this.fld_lblLabel38.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel38, true);
            this.fld_lblLabel38.Size = new System.Drawing.Size(52, 13);
            this.fld_lblLabel38.TabIndex = 62;
            this.fld_lblLabel38.Tag = "";
            this.fld_lblLabel38.Text = "Danh xưng";
            // 
            // fld_lblLabel41
            // 
            this.fld_lblLabel41.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel41.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel41.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel41.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel41.Appearance.Options.UseFont = true;
            this.fld_lblLabel41.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel41.BOSComment = "";
            this.fld_lblLabel41.BOSDataMember = "";
            this.fld_lblLabel41.BOSDataSource = "";
            this.fld_lblLabel41.BOSDescription = null;
            this.fld_lblLabel41.BOSError = null;
            this.fld_lblLabel41.BOSFieldGroup = "";
            this.fld_lblLabel41.BOSFieldRelation = "";
            this.fld_lblLabel41.BOSPrivilege = "";
            this.fld_lblLabel41.BOSPropertyName = null;
            this.fld_lblLabel41.Location = new System.Drawing.Point(26, 103);
            this.fld_lblLabel41.Name = "fld_lblLabel41";
            this.fld_lblLabel41.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel41, true);
            this.fld_lblLabel41.Size = new System.Drawing.Size(25, 13);
            this.fld_lblLabel41.TabIndex = 65;
            this.fld_lblLabel41.Tag = "";
            this.fld_lblLabel41.Text = "Email";
            // 
            // fld_lblLabel42
            // 
            this.fld_lblLabel42.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel42.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel42.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel42.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel42.Appearance.Options.UseFont = true;
            this.fld_lblLabel42.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel42.BOSComment = "";
            this.fld_lblLabel42.BOSDataMember = "";
            this.fld_lblLabel42.BOSDataSource = "";
            this.fld_lblLabel42.BOSDescription = null;
            this.fld_lblLabel42.BOSError = null;
            this.fld_lblLabel42.BOSFieldGroup = "";
            this.fld_lblLabel42.BOSFieldRelation = "";
            this.fld_lblLabel42.BOSPrivilege = "";
            this.fld_lblLabel42.BOSPropertyName = null;
            this.fld_lblLabel42.Location = new System.Drawing.Point(26, 78);
            this.fld_lblLabel42.Name = "fld_lblLabel42";
            this.fld_lblLabel42.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel42, true);
            this.fld_lblLabel42.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel42.TabIndex = 66;
            this.fld_lblLabel42.Tag = "";
            this.fld_lblLabel42.Text = "Điện thoại";
            // 
            // fld_lblLabel43
            // 
            this.fld_lblLabel43.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel43.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel43.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel43.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel43.Appearance.Options.UseFont = true;
            this.fld_lblLabel43.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel43.BOSComment = "";
            this.fld_lblLabel43.BOSDataMember = "";
            this.fld_lblLabel43.BOSDataSource = "";
            this.fld_lblLabel43.BOSDescription = null;
            this.fld_lblLabel43.BOSError = null;
            this.fld_lblLabel43.BOSFieldGroup = "";
            this.fld_lblLabel43.BOSFieldRelation = "";
            this.fld_lblLabel43.BOSPrivilege = "";
            this.fld_lblLabel43.BOSPropertyName = null;
            this.fld_lblLabel43.Location = new System.Drawing.Point(303, 103);
            this.fld_lblLabel43.Name = "fld_lblLabel43";
            this.fld_lblLabel43.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel43, true);
            this.fld_lblLabel43.Size = new System.Drawing.Size(30, 13);
            this.fld_lblLabel43.TabIndex = 67;
            this.fld_lblLabel43.Tag = "";
            this.fld_lblLabel43.Text = "Số fax";
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
            this.fld_lblLabel45.Location = new System.Drawing.Point(303, 128);
            this.fld_lblLabel45.Name = "fld_lblLabel45";
            this.fld_lblLabel45.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel45, true);
            this.fld_lblLabel45.Size = new System.Drawing.Size(52, 13);
            this.fld_lblLabel45.TabIndex = 69;
            this.fld_lblLabel45.Tag = "";
            this.fld_lblLabel45.Text = "Phòng ban";
            // 
            // fld_txtMMWorkShopContactTitle
            // 
            this.fld_txtMMWorkShopContactTitle.BOSComment = "";
            this.fld_txtMMWorkShopContactTitle.BOSDataMember = "MMWorkShopContactTitle";
            this.fld_txtMMWorkShopContactTitle.BOSDataSource = "MMWorkShops";
            this.fld_txtMMWorkShopContactTitle.BOSDescription = null;
            this.fld_txtMMWorkShopContactTitle.BOSError = "";
            this.fld_txtMMWorkShopContactTitle.BOSFieldGroup = "";
            this.fld_txtMMWorkShopContactTitle.BOSFieldRelation = "";
            this.fld_txtMMWorkShopContactTitle.BOSPrivilege = "";
            this.fld_txtMMWorkShopContactTitle.BOSPropertyName = "Text";
            this.fld_txtMMWorkShopContactTitle.Location = new System.Drawing.Point(116, 25);
            this.fld_txtMMWorkShopContactTitle.Name = "fld_txtMMWorkShopContactTitle";
            this.fld_txtMMWorkShopContactTitle.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMWorkShopContactTitle.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMWorkShopContactTitle.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMWorkShopContactTitle.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMWorkShopContactTitle.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMWorkShopContactTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMWorkShopContactTitle.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMWorkShopContactTitle, true);
            this.fld_txtMMWorkShopContactTitle.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMWorkShopContactTitle.TabIndex = 0;
            this.fld_txtMMWorkShopContactTitle.Tag = "DC";
            // 
            // fld_txtMMWorkShopContactFirstName
            // 
            this.fld_txtMMWorkShopContactFirstName.BOSComment = "";
            this.fld_txtMMWorkShopContactFirstName.BOSDataMember = "MMWorkShopContactFirstName";
            this.fld_txtMMWorkShopContactFirstName.BOSDataSource = "MMWorkShops";
            this.fld_txtMMWorkShopContactFirstName.BOSDescription = null;
            this.fld_txtMMWorkShopContactFirstName.BOSError = "";
            this.fld_txtMMWorkShopContactFirstName.BOSFieldGroup = "";
            this.fld_txtMMWorkShopContactFirstName.BOSFieldRelation = "";
            this.fld_txtMMWorkShopContactFirstName.BOSPrivilege = "";
            this.fld_txtMMWorkShopContactFirstName.BOSPropertyName = "Text";
            this.fld_txtMMWorkShopContactFirstName.Location = new System.Drawing.Point(116, 50);
            this.fld_txtMMWorkShopContactFirstName.Name = "fld_txtMMWorkShopContactFirstName";
            this.fld_txtMMWorkShopContactFirstName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMWorkShopContactFirstName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMWorkShopContactFirstName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMWorkShopContactFirstName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMWorkShopContactFirstName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMWorkShopContactFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMWorkShopContactFirstName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMWorkShopContactFirstName, true);
            this.fld_txtMMWorkShopContactFirstName.Size = new System.Drawing.Size(384, 20);
            this.fld_txtMMWorkShopContactFirstName.TabIndex = 1;
            this.fld_txtMMWorkShopContactFirstName.Tag = "DC";
            // 
            // fld_txtMMWorkShopContactPhone
            // 
            this.fld_txtMMWorkShopContactPhone.BOSComment = "";
            this.fld_txtMMWorkShopContactPhone.BOSDataMember = "MMWorkShopContactPhone";
            this.fld_txtMMWorkShopContactPhone.BOSDataSource = "MMWorkShops";
            this.fld_txtMMWorkShopContactPhone.BOSDescription = null;
            this.fld_txtMMWorkShopContactPhone.BOSError = "";
            this.fld_txtMMWorkShopContactPhone.BOSFieldGroup = "";
            this.fld_txtMMWorkShopContactPhone.BOSFieldRelation = "";
            this.fld_txtMMWorkShopContactPhone.BOSPrivilege = "";
            this.fld_txtMMWorkShopContactPhone.BOSPropertyName = "Text";
            this.fld_txtMMWorkShopContactPhone.Location = new System.Drawing.Point(116, 75);
            this.fld_txtMMWorkShopContactPhone.Name = "fld_txtMMWorkShopContactPhone";
            this.fld_txtMMWorkShopContactPhone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMWorkShopContactPhone.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMWorkShopContactPhone.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMWorkShopContactPhone.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMWorkShopContactPhone.Properties.Mask.EditMask = "\\d+";
            this.fld_txtMMWorkShopContactPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.fld_txtMMWorkShopContactPhone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMWorkShopContactPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMWorkShopContactPhone.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMWorkShopContactPhone, true);
            this.fld_txtMMWorkShopContactPhone.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMWorkShopContactPhone.TabIndex = 3;
            this.fld_txtMMWorkShopContactPhone.Tag = "DC";
            // 
            // fld_txtMMWorkShopContactFax
            // 
            this.fld_txtMMWorkShopContactFax.BOSComment = "";
            this.fld_txtMMWorkShopContactFax.BOSDataMember = "MMWorkShopContactFax";
            this.fld_txtMMWorkShopContactFax.BOSDataSource = "MMWorkShops";
            this.fld_txtMMWorkShopContactFax.BOSDescription = null;
            this.fld_txtMMWorkShopContactFax.BOSError = "";
            this.fld_txtMMWorkShopContactFax.BOSFieldGroup = "";
            this.fld_txtMMWorkShopContactFax.BOSFieldRelation = "";
            this.fld_txtMMWorkShopContactFax.BOSPrivilege = "";
            this.fld_txtMMWorkShopContactFax.BOSPropertyName = "Text";
            this.fld_txtMMWorkShopContactFax.Location = new System.Drawing.Point(378, 100);
            this.fld_txtMMWorkShopContactFax.Name = "fld_txtMMWorkShopContactFax";
            this.fld_txtMMWorkShopContactFax.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMWorkShopContactFax.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMWorkShopContactFax.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMWorkShopContactFax.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMWorkShopContactFax.Properties.Mask.EditMask = "\\d+";
            this.fld_txtMMWorkShopContactFax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.fld_txtMMWorkShopContactFax.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMWorkShopContactFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMWorkShopContactFax.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMWorkShopContactFax, true);
            this.fld_txtMMWorkShopContactFax.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMWorkShopContactFax.TabIndex = 6;
            this.fld_txtMMWorkShopContactFax.Tag = "DC";
            // 
            // fld_txtMMWorkShopContactCellPhone
            // 
            this.fld_txtMMWorkShopContactCellPhone.BOSComment = "";
            this.fld_txtMMWorkShopContactCellPhone.BOSDataMember = "MMWorkShopContactCellPhone";
            this.fld_txtMMWorkShopContactCellPhone.BOSDataSource = "MMWorkShops";
            this.fld_txtMMWorkShopContactCellPhone.BOSDescription = null;
            this.fld_txtMMWorkShopContactCellPhone.BOSError = "";
            this.fld_txtMMWorkShopContactCellPhone.BOSFieldGroup = "";
            this.fld_txtMMWorkShopContactCellPhone.BOSFieldRelation = "";
            this.fld_txtMMWorkShopContactCellPhone.BOSPrivilege = "";
            this.fld_txtMMWorkShopContactCellPhone.BOSPropertyName = "Text";
            this.fld_txtMMWorkShopContactCellPhone.Location = new System.Drawing.Point(378, 75);
            this.fld_txtMMWorkShopContactCellPhone.Name = "fld_txtMMWorkShopContactCellPhone";
            this.fld_txtMMWorkShopContactCellPhone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMWorkShopContactCellPhone.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMWorkShopContactCellPhone.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMWorkShopContactCellPhone.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMWorkShopContactCellPhone.Properties.Mask.EditMask = "\\d+";
            this.fld_txtMMWorkShopContactCellPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.fld_txtMMWorkShopContactCellPhone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMWorkShopContactCellPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMWorkShopContactCellPhone.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMWorkShopContactCellPhone, true);
            this.fld_txtMMWorkShopContactCellPhone.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMWorkShopContactCellPhone.TabIndex = 4;
            this.fld_txtMMWorkShopContactCellPhone.Tag = "DC";
            // 
            // fld_txtMMWorkShopContactEmail
            // 
            this.fld_txtMMWorkShopContactEmail.BOSComment = "";
            this.fld_txtMMWorkShopContactEmail.BOSDataMember = "MMWorkShopContactEmail";
            this.fld_txtMMWorkShopContactEmail.BOSDataSource = "MMWorkShops";
            this.fld_txtMMWorkShopContactEmail.BOSDescription = null;
            this.fld_txtMMWorkShopContactEmail.BOSError = "";
            this.fld_txtMMWorkShopContactEmail.BOSFieldGroup = "";
            this.fld_txtMMWorkShopContactEmail.BOSFieldRelation = "";
            this.fld_txtMMWorkShopContactEmail.BOSPrivilege = "";
            this.fld_txtMMWorkShopContactEmail.BOSPropertyName = "Text";
            this.fld_txtMMWorkShopContactEmail.Location = new System.Drawing.Point(116, 100);
            this.fld_txtMMWorkShopContactEmail.Name = "fld_txtMMWorkShopContactEmail";
            this.fld_txtMMWorkShopContactEmail.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMWorkShopContactEmail.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMWorkShopContactEmail.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMWorkShopContactEmail.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMWorkShopContactEmail.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMWorkShopContactEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMWorkShopContactEmail.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMWorkShopContactEmail, true);
            this.fld_txtMMWorkShopContactEmail.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMWorkShopContactEmail.TabIndex = 5;
            this.fld_txtMMWorkShopContactEmail.Tag = "DC";
            // 
            // fld_txtMMWorkShopContactDepartment
            // 
            this.fld_txtMMWorkShopContactDepartment.BOSComment = "";
            this.fld_txtMMWorkShopContactDepartment.BOSDataMember = "MMWorkShopContactDepartment";
            this.fld_txtMMWorkShopContactDepartment.BOSDataSource = "MMWorkShops";
            this.fld_txtMMWorkShopContactDepartment.BOSDescription = null;
            this.fld_txtMMWorkShopContactDepartment.BOSError = "";
            this.fld_txtMMWorkShopContactDepartment.BOSFieldGroup = "";
            this.fld_txtMMWorkShopContactDepartment.BOSFieldRelation = "";
            this.fld_txtMMWorkShopContactDepartment.BOSPrivilege = "";
            this.fld_txtMMWorkShopContactDepartment.BOSPropertyName = "Text";
            this.fld_txtMMWorkShopContactDepartment.Location = new System.Drawing.Point(116, 126);
            this.fld_txtMMWorkShopContactDepartment.Name = "fld_txtMMWorkShopContactDepartment";
            this.fld_txtMMWorkShopContactDepartment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMWorkShopContactDepartment.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMWorkShopContactDepartment.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMWorkShopContactDepartment.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMWorkShopContactDepartment.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMWorkShopContactDepartment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMWorkShopContactDepartment.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMWorkShopContactDepartment, true);
            this.fld_txtMMWorkShopContactDepartment.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMWorkShopContactDepartment.TabIndex = 7;
            this.fld_txtMMWorkShopContactDepartment.Tag = "DC";
            // 
            // fld_txtMMLineContactRoom
            // 
            this.fld_txtMMLineContactRoom.BOSComment = "";
            this.fld_txtMMLineContactRoom.BOSDataMember = "MMWorkShopContactRoom";
            this.fld_txtMMLineContactRoom.BOSDataSource = "MMWorkShops";
            this.fld_txtMMLineContactRoom.BOSDescription = null;
            this.fld_txtMMLineContactRoom.BOSError = "";
            this.fld_txtMMLineContactRoom.BOSFieldGroup = "";
            this.fld_txtMMLineContactRoom.BOSFieldRelation = "";
            this.fld_txtMMLineContactRoom.BOSPrivilege = "";
            this.fld_txtMMLineContactRoom.BOSPropertyName = "Text";
            this.fld_txtMMLineContactRoom.Location = new System.Drawing.Point(378, 125);
            this.fld_txtMMLineContactRoom.Name = "fld_txtMMLineContactRoom";
            this.fld_txtMMLineContactRoom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMLineContactRoom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMLineContactRoom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMLineContactRoom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMLineContactRoom.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMLineContactRoom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMLineContactRoom.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMLineContactRoom, true);
            this.fld_txtMMLineContactRoom.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMLineContactRoom.TabIndex = 8;
            this.fld_txtMMLineContactRoom.Tag = "DC";
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.fld_grcGroupControl.Controls.Add(this.fld_bedGELocationName);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel16);
            this.fld_grcGroupControl.Controls.Add(this.fld_medMMWorkShopDesc);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel13);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtMMWorkShopLength);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtMMWorkShopNo);
            this.fld_grcGroupControl.Controls.Add(this.fld_chkMMWorkShopActiveCheck);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtMMWorkShopWidth);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtMMWorkShopName);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl, true);
            this.fld_grcGroupControl.Size = new System.Drawing.Size(884, 153);
            this.fld_grcGroupControl.TabIndex = 0;
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = false;
            this.fld_lkeFK_BRBranchID.BOSComment = null;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "MMWorkShops";
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
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(652, 25);
            this.fld_lkeFK_BRBranchID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.ColumnName = null;
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(160, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 2;
            this.fld_lkeFK_BRBranchID.Tag = "DC";
            // 
            // fld_bedGELocationName
            // 
            this.fld_bedGELocationName.BOSComment = null;
            this.fld_bedGELocationName.BOSDataMember = "MMWorkShopGELocationName";
            this.fld_bedGELocationName.BOSDataSource = "MMWorkShops";
            this.fld_bedGELocationName.BOSDescription = null;
            this.fld_bedGELocationName.BOSError = null;
            this.fld_bedGELocationName.BOSFieldGroup = null;
            this.fld_bedGELocationName.BOSFieldRelation = null;
            this.fld_bedGELocationName.BOSPrivilege = null;
            this.fld_bedGELocationName.BOSPropertyName = "Text";
            this.fld_bedGELocationName.Location = new System.Drawing.Point(116, 77);
            this.fld_bedGELocationName.MenuManager = this.screenToolbar;
            this.fld_bedGELocationName.Name = "fld_bedGELocationName";
            this.fld_bedGELocationName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedGELocationName.Properties.ReadOnly = true;
            this.fld_bedGELocationName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_bedGELocationName, true);
            this.fld_bedGELocationName.Size = new System.Drawing.Size(422, 20);
            this.fld_bedGELocationName.TabIndex = 5;
            this.fld_bedGELocationName.Tag = "DC";
            this.fld_bedGELocationName.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedGELocationName_ButtonClick);
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
            this.bosLabel4.Location = new System.Drawing.Point(556, 28);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(48, 13);
            this.bosLabel4.TabIndex = 104;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Chi nhánh";
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
            this.bosLabel16.Location = new System.Drawing.Point(27, 80);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel16, true);
            this.bosLabel16.Size = new System.Drawing.Size(21, 13);
            this.bosLabel16.TabIndex = 102;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "Vị trí";
            // 
            // fld_medMMWorkShopDesc
            // 
            this.fld_medMMWorkShopDesc.BOSComment = "";
            this.fld_medMMWorkShopDesc.BOSDataMember = "MMWorkShopDesc";
            this.fld_medMMWorkShopDesc.BOSDataSource = "MMWorkShops";
            this.fld_medMMWorkShopDesc.BOSDescription = null;
            this.fld_medMMWorkShopDesc.BOSError = null;
            this.fld_medMMWorkShopDesc.BOSFieldGroup = "";
            this.fld_medMMWorkShopDesc.BOSFieldRelation = "";
            this.fld_medMMWorkShopDesc.BOSPrivilege = "";
            this.fld_medMMWorkShopDesc.BOSPropertyName = "EditValue";
            this.fld_medMMWorkShopDesc.EditValue = "";
            this.fld_medMMWorkShopDesc.Location = new System.Drawing.Point(116, 104);
            this.fld_medMMWorkShopDesc.Name = "fld_medMMWorkShopDesc";
            this.fld_medMMWorkShopDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medMMWorkShopDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medMMWorkShopDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medMMWorkShopDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medMMWorkShopDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medMMWorkShopDesc, true);
            this.fld_medMMWorkShopDesc.Size = new System.Drawing.Size(422, 35);
            this.fld_medMMWorkShopDesc.TabIndex = 6;
            this.fld_medMMWorkShopDesc.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
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
            this.bosLabel13.Location = new System.Drawing.Point(27, 107);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel13, true);
            this.bosLabel13.Size = new System.Drawing.Size(27, 13);
            this.bosLabel13.TabIndex = 100;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "Mô tả";
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
            this.bosLabel3.Location = new System.Drawing.Point(26, 54);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(16, 13);
            this.bosLabel3.TabIndex = 99;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Dài";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseFont = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = "";
            this.fld_lblLabel4.BOSDataMember = "";
            this.fld_lblLabel4.BOSDataSource = "";
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = "";
            this.fld_lblLabel4.BOSFieldRelation = "";
            this.fld_lblLabel4.BOSPrivilege = "";
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(26, 28);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel4, true);
            this.fld_lblLabel4.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel4.TabIndex = 99;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Mã xưởng";
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
            this.bosLabel2.Location = new System.Drawing.Point(303, 54);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(26, 13);
            this.bosLabel2.TabIndex = 97;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Rộng";
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
            this.bosLabel1.Location = new System.Drawing.Point(303, 28);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(51, 13);
            this.bosLabel1.TabIndex = 97;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Tên xưởng";
            // 
            // fld_txtMMWorkShopLength
            // 
            this.fld_txtMMWorkShopLength.BOSComment = "";
            this.fld_txtMMWorkShopLength.BOSDataMember = "MMWorkShopLength";
            this.fld_txtMMWorkShopLength.BOSDataSource = "MMWorkShops";
            this.fld_txtMMWorkShopLength.BOSDescription = null;
            this.fld_txtMMWorkShopLength.BOSError = "";
            this.fld_txtMMWorkShopLength.BOSFieldGroup = "";
            this.fld_txtMMWorkShopLength.BOSFieldRelation = "";
            this.fld_txtMMWorkShopLength.BOSPrivilege = "";
            this.fld_txtMMWorkShopLength.BOSPropertyName = "Text";
            this.fld_txtMMWorkShopLength.Location = new System.Drawing.Point(115, 51);
            this.fld_txtMMWorkShopLength.Name = "fld_txtMMWorkShopLength";
            this.fld_txtMMWorkShopLength.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMWorkShopLength.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMWorkShopLength.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMWorkShopLength.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMWorkShopLength.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMWorkShopLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMWorkShopLength.Screen = null;
            this.fld_txtMMWorkShopLength.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMWorkShopLength.TabIndex = 3;
            this.fld_txtMMWorkShopLength.Tag = "DC";
            // 
            // fld_txtMMWorkShopNo
            // 
            this.fld_txtMMWorkShopNo.BOSComment = "";
            this.fld_txtMMWorkShopNo.BOSDataMember = "MMWorkShopNo";
            this.fld_txtMMWorkShopNo.BOSDataSource = "MMWorkShops";
            this.fld_txtMMWorkShopNo.BOSDescription = null;
            this.fld_txtMMWorkShopNo.BOSError = "";
            this.fld_txtMMWorkShopNo.BOSFieldGroup = "";
            this.fld_txtMMWorkShopNo.BOSFieldRelation = "";
            this.fld_txtMMWorkShopNo.BOSPrivilege = "";
            this.fld_txtMMWorkShopNo.BOSPropertyName = "Text";
            this.fld_txtMMWorkShopNo.Location = new System.Drawing.Point(115, 25);
            this.fld_txtMMWorkShopNo.Name = "fld_txtMMWorkShopNo";
            this.fld_txtMMWorkShopNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMWorkShopNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMWorkShopNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMWorkShopNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMWorkShopNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMWorkShopNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMWorkShopNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMWorkShopNo, true);
            this.fld_txtMMWorkShopNo.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMWorkShopNo.TabIndex = 0;
            this.fld_txtMMWorkShopNo.Tag = "DC";
            // 
            // fld_chkMMWorkShopActiveCheck
            // 
            this.fld_chkMMWorkShopActiveCheck.BOSComment = "";
            this.fld_chkMMWorkShopActiveCheck.BOSDataMember = "MMWorkShopActiveCheck";
            this.fld_chkMMWorkShopActiveCheck.BOSDataSource = "MMWorkShops";
            this.fld_chkMMWorkShopActiveCheck.BOSDescription = null;
            this.fld_chkMMWorkShopActiveCheck.BOSError = "";
            this.fld_chkMMWorkShopActiveCheck.BOSFieldGroup = "";
            this.fld_chkMMWorkShopActiveCheck.BOSFieldRelation = "";
            this.fld_chkMMWorkShopActiveCheck.BOSPrivilege = "";
            this.fld_chkMMWorkShopActiveCheck.BOSPropertyName = "EditValue";
            this.fld_chkMMWorkShopActiveCheck.Location = new System.Drawing.Point(554, 120);
            this.fld_chkMMWorkShopActiveCheck.Name = "fld_chkMMWorkShopActiveCheck";
            this.fld_chkMMWorkShopActiveCheck.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkMMWorkShopActiveCheck.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkMMWorkShopActiveCheck.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkMMWorkShopActiveCheck.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkMMWorkShopActiveCheck.Properties.Caption = "Hoạt động";
            this.fld_chkMMWorkShopActiveCheck.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_chkMMWorkShopActiveCheck, true);
            this.fld_chkMMWorkShopActiveCheck.Size = new System.Drawing.Size(75, 19);
            this.fld_chkMMWorkShopActiveCheck.TabIndex = 7;
            this.fld_chkMMWorkShopActiveCheck.Tag = "DC";
            // 
            // fld_txtMMWorkShopWidth
            // 
            this.fld_txtMMWorkShopWidth.BOSComment = "";
            this.fld_txtMMWorkShopWidth.BOSDataMember = "MMWorkShopWidth";
            this.fld_txtMMWorkShopWidth.BOSDataSource = "MMWorkShops";
            this.fld_txtMMWorkShopWidth.BOSDescription = null;
            this.fld_txtMMWorkShopWidth.BOSError = "";
            this.fld_txtMMWorkShopWidth.BOSFieldGroup = "";
            this.fld_txtMMWorkShopWidth.BOSFieldRelation = "";
            this.fld_txtMMWorkShopWidth.BOSPrivilege = "";
            this.fld_txtMMWorkShopWidth.BOSPropertyName = "Text";
            this.fld_txtMMWorkShopWidth.Location = new System.Drawing.Point(377, 51);
            this.fld_txtMMWorkShopWidth.Name = "fld_txtMMWorkShopWidth";
            this.fld_txtMMWorkShopWidth.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMWorkShopWidth.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMWorkShopWidth.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMWorkShopWidth.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMWorkShopWidth.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMWorkShopWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMWorkShopWidth.Screen = null;
            this.fld_txtMMWorkShopWidth.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMWorkShopWidth.TabIndex = 4;
            this.fld_txtMMWorkShopWidth.Tag = "DC";
            // 
            // fld_txtMMWorkShopName
            // 
            this.fld_txtMMWorkShopName.BOSComment = "";
            this.fld_txtMMWorkShopName.BOSDataMember = "MMWorkShopName";
            this.fld_txtMMWorkShopName.BOSDataSource = "MMWorkShops";
            this.fld_txtMMWorkShopName.BOSDescription = null;
            this.fld_txtMMWorkShopName.BOSError = "";
            this.fld_txtMMWorkShopName.BOSFieldGroup = "";
            this.fld_txtMMWorkShopName.BOSFieldRelation = "";
            this.fld_txtMMWorkShopName.BOSPrivilege = "";
            this.fld_txtMMWorkShopName.BOSPropertyName = "Text";
            this.fld_txtMMWorkShopName.Location = new System.Drawing.Point(377, 25);
            this.fld_txtMMWorkShopName.Name = "fld_txtMMWorkShopName";
            this.fld_txtMMWorkShopName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMWorkShopName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMWorkShopName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMWorkShopName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMWorkShopName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMWorkShopName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMWorkShopName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMWorkShopName, true);
            this.fld_txtMMWorkShopName.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMWorkShopName.TabIndex = 1;
            this.fld_txtMMWorkShopName.Tag = "DC";
            // 
            // fld_btnInsertValueByEmployee
            // 
            this.fld_btnInsertValueByEmployee.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnInsertValueByEmployee.Appearance.Options.UseForeColor = true;
            this.fld_btnInsertValueByEmployee.BOSComment = null;
            this.fld_btnInsertValueByEmployee.BOSDataMember = null;
            this.fld_btnInsertValueByEmployee.BOSDataSource = null;
            this.fld_btnInsertValueByEmployee.BOSDescription = null;
            this.fld_btnInsertValueByEmployee.BOSError = null;
            this.fld_btnInsertValueByEmployee.BOSFieldGroup = null;
            this.fld_btnInsertValueByEmployee.BOSFieldRelation = null;
            this.fld_btnInsertValueByEmployee.BOSPrivilege = null;
            this.fld_btnInsertValueByEmployee.BOSPropertyName = null;
            this.fld_btnInsertValueByEmployee.Location = new System.Drawing.Point(506, 50);
            this.fld_btnInsertValueByEmployee.Name = "fld_btnInsertValueByEmployee";
            this.fld_btnInsertValueByEmployee.Screen = null;
            this.fld_btnInsertValueByEmployee.Size = new System.Drawing.Size(32, 20);
            this.fld_btnInsertValueByEmployee.TabIndex = 2;
            this.fld_btnInsertValueByEmployee.Text = "...";
            this.fld_btnInsertValueByEmployee.Click += new System.EventHandler(this.Fld_btnInsertValueByEmployee_Click);
            // 
            // DMWS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(890, 568);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMWS100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).EndInit();
            this.fld_grcGroupControl3.ResumeLayout(false);
            this.fld_grcGroupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactCellPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopContactDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactRoom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedGELocationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMWorkShopDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkMMWorkShopActiveCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWorkShopName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSGroupControl fld_grcGroupControl3;
        private BOSComponent.BOSLabel fld_lblLabel27;
        private BOSComponent.BOSLabel fld_lblLabel30;
        private BOSComponent.BOSLabel fld_lblLabel32;
        private BOSComponent.BOSLabel fld_lblLabel38;
        private BOSComponent.BOSLabel fld_lblLabel41;
        private BOSComponent.BOSLabel fld_lblLabel42;
        private BOSComponent.BOSLabel fld_lblLabel43;
        private BOSComponent.BOSLabel fld_lblLabel45;
        private BOSComponent.BOSTextBox fld_txtMMWorkShopContactTitle;
        private BOSComponent.BOSTextBox fld_txtMMWorkShopContactFirstName;
        private BOSComponent.BOSTextBox fld_txtMMWorkShopContactPhone;
        private BOSComponent.BOSTextBox fld_txtMMWorkShopContactFax;
        private BOSComponent.BOSTextBox fld_txtMMWorkShopContactCellPhone;
        private BOSComponent.BOSTextBox fld_txtMMWorkShopContactEmail;
        private BOSComponent.BOSTextBox fld_txtMMWorkShopContactDepartment;
        private BOSComponent.BOSTextBox fld_txtMMLineContactRoom;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private BOSComponent.BOSMemoEdit fld_medMMWorkShopDesc;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMWorkShopNo;
        private BOSComponent.BOSCheckEdit fld_chkMMWorkShopActiveCheck;
        private BOSComponent.BOSTextBox fld_txtMMWorkShopName;
        private IContainer components;
        private BOSComponent.BOSButtonEdit fld_bedGELocationName;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtMMWorkShopLength;
        private BOSComponent.BOSTextBox fld_txtMMWorkShopWidth;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSButton fld_btnInsertValueByEmployee;
    }
}
