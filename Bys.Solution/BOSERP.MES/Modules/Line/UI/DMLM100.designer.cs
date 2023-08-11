using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Line.UI
{
	/// <summary>
	/// Summary description for DMLM100
	/// </summary>
	partial class DMLM100
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
            this.fld_txtMMLineContactTitle = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMLineContactFirstName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMLineContactPhone = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMLineContactFax = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMLineContactCellPhone = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMLineContactEmail = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMLineContactDepartment = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMLineContactRoom = new BOSComponent.BOSTextBox(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_MMWorkShopID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_medMMLineDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMLineNo = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_chkMMLineActiveCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_txtMMLineName = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnInsertValueByEmployee = new BOSComponent.BOSButton(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).BeginInit();
            this.fld_grcGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactCellPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactRoom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMLineDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkMMLineActiveCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineName.Properties)).BeginInit();
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
            this.bosPanel1.TabIndex = 0;
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
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtMMLineContactTitle);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtMMLineContactFirstName);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtMMLineContactPhone);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtMMLineContactFax);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtMMLineContactCellPhone);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtMMLineContactEmail);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtMMLineContactDepartment);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtMMLineContactRoom);
            this.fld_grcGroupControl3.Location = new System.Drawing.Point(3, 127);
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
            // fld_txtMMLineContactTitle
            // 
            this.fld_txtMMLineContactTitle.BOSComment = "";
            this.fld_txtMMLineContactTitle.BOSDataMember = "MMLineContactTitle";
            this.fld_txtMMLineContactTitle.BOSDataSource = "MMLines";
            this.fld_txtMMLineContactTitle.BOSDescription = null;
            this.fld_txtMMLineContactTitle.BOSError = "";
            this.fld_txtMMLineContactTitle.BOSFieldGroup = "";
            this.fld_txtMMLineContactTitle.BOSFieldRelation = "";
            this.fld_txtMMLineContactTitle.BOSPrivilege = "";
            this.fld_txtMMLineContactTitle.BOSPropertyName = "Text";
            this.fld_txtMMLineContactTitle.Location = new System.Drawing.Point(116, 25);
            this.fld_txtMMLineContactTitle.Name = "fld_txtMMLineContactTitle";
            this.fld_txtMMLineContactTitle.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMLineContactTitle.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMLineContactTitle.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMLineContactTitle.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMLineContactTitle.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMLineContactTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMLineContactTitle.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMLineContactTitle, true);
            this.fld_txtMMLineContactTitle.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMLineContactTitle.TabIndex = 0;
            this.fld_txtMMLineContactTitle.Tag = "DC";
            // 
            // fld_txtMMLineContactFirstName
            // 
            this.fld_txtMMLineContactFirstName.BOSComment = "";
            this.fld_txtMMLineContactFirstName.BOSDataMember = "MMLineContactFirstName";
            this.fld_txtMMLineContactFirstName.BOSDataSource = "MMLines";
            this.fld_txtMMLineContactFirstName.BOSDescription = null;
            this.fld_txtMMLineContactFirstName.BOSError = "";
            this.fld_txtMMLineContactFirstName.BOSFieldGroup = "";
            this.fld_txtMMLineContactFirstName.BOSFieldRelation = "";
            this.fld_txtMMLineContactFirstName.BOSPrivilege = "";
            this.fld_txtMMLineContactFirstName.BOSPropertyName = "Text";
            this.fld_txtMMLineContactFirstName.Location = new System.Drawing.Point(116, 50);
            this.fld_txtMMLineContactFirstName.Name = "fld_txtMMLineContactFirstName";
            this.fld_txtMMLineContactFirstName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMLineContactFirstName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMLineContactFirstName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMLineContactFirstName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMLineContactFirstName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMLineContactFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMLineContactFirstName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMLineContactFirstName, true);
            this.fld_txtMMLineContactFirstName.Size = new System.Drawing.Size(386, 20);
            this.fld_txtMMLineContactFirstName.TabIndex = 1;
            this.fld_txtMMLineContactFirstName.Tag = "DC";
            // 
            // fld_txtMMLineContactPhone
            // 
            this.fld_txtMMLineContactPhone.BOSComment = "";
            this.fld_txtMMLineContactPhone.BOSDataMember = "MMLineContactPhone";
            this.fld_txtMMLineContactPhone.BOSDataSource = "MMLines";
            this.fld_txtMMLineContactPhone.BOSDescription = null;
            this.fld_txtMMLineContactPhone.BOSError = "";
            this.fld_txtMMLineContactPhone.BOSFieldGroup = "";
            this.fld_txtMMLineContactPhone.BOSFieldRelation = "";
            this.fld_txtMMLineContactPhone.BOSPrivilege = "";
            this.fld_txtMMLineContactPhone.BOSPropertyName = "Text";
            this.fld_txtMMLineContactPhone.Location = new System.Drawing.Point(116, 75);
            this.fld_txtMMLineContactPhone.Name = "fld_txtMMLineContactPhone";
            this.fld_txtMMLineContactPhone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMLineContactPhone.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMLineContactPhone.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMLineContactPhone.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMLineContactPhone.Properties.Mask.EditMask = "\\d+";
            this.fld_txtMMLineContactPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.fld_txtMMLineContactPhone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMLineContactPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMLineContactPhone.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMLineContactPhone, true);
            this.fld_txtMMLineContactPhone.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMLineContactPhone.TabIndex = 3;
            this.fld_txtMMLineContactPhone.Tag = "DC";
            // 
            // fld_txtMMLineContactFax
            // 
            this.fld_txtMMLineContactFax.BOSComment = "";
            this.fld_txtMMLineContactFax.BOSDataMember = "MMLineContactFax";
            this.fld_txtMMLineContactFax.BOSDataSource = "MMLines";
            this.fld_txtMMLineContactFax.BOSDescription = null;
            this.fld_txtMMLineContactFax.BOSError = "";
            this.fld_txtMMLineContactFax.BOSFieldGroup = "";
            this.fld_txtMMLineContactFax.BOSFieldRelation = "";
            this.fld_txtMMLineContactFax.BOSPrivilege = "";
            this.fld_txtMMLineContactFax.BOSPropertyName = "Text";
            this.fld_txtMMLineContactFax.Location = new System.Drawing.Point(378, 100);
            this.fld_txtMMLineContactFax.Name = "fld_txtMMLineContactFax";
            this.fld_txtMMLineContactFax.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMLineContactFax.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMLineContactFax.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMLineContactFax.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMLineContactFax.Properties.Mask.EditMask = "\\d+";
            this.fld_txtMMLineContactFax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.fld_txtMMLineContactFax.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMLineContactFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMLineContactFax.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMLineContactFax, true);
            this.fld_txtMMLineContactFax.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMLineContactFax.TabIndex = 6;
            this.fld_txtMMLineContactFax.Tag = "DC";
            // 
            // fld_txtMMLineContactCellPhone
            // 
            this.fld_txtMMLineContactCellPhone.BOSComment = "";
            this.fld_txtMMLineContactCellPhone.BOSDataMember = "MMLineContactCellPhone";
            this.fld_txtMMLineContactCellPhone.BOSDataSource = "MMLines";
            this.fld_txtMMLineContactCellPhone.BOSDescription = null;
            this.fld_txtMMLineContactCellPhone.BOSError = "";
            this.fld_txtMMLineContactCellPhone.BOSFieldGroup = "";
            this.fld_txtMMLineContactCellPhone.BOSFieldRelation = "";
            this.fld_txtMMLineContactCellPhone.BOSPrivilege = "";
            this.fld_txtMMLineContactCellPhone.BOSPropertyName = "Text";
            this.fld_txtMMLineContactCellPhone.Location = new System.Drawing.Point(378, 75);
            this.fld_txtMMLineContactCellPhone.Name = "fld_txtMMLineContactCellPhone";
            this.fld_txtMMLineContactCellPhone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMLineContactCellPhone.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMLineContactCellPhone.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMLineContactCellPhone.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMLineContactCellPhone.Properties.Mask.EditMask = "\\d+";
            this.fld_txtMMLineContactCellPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.fld_txtMMLineContactCellPhone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMLineContactCellPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMLineContactCellPhone.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMLineContactCellPhone, true);
            this.fld_txtMMLineContactCellPhone.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMLineContactCellPhone.TabIndex = 4;
            this.fld_txtMMLineContactCellPhone.Tag = "DC";
            // 
            // fld_txtMMLineContactEmail
            // 
            this.fld_txtMMLineContactEmail.BOSComment = "";
            this.fld_txtMMLineContactEmail.BOSDataMember = "MMLineContactEmail";
            this.fld_txtMMLineContactEmail.BOSDataSource = "MMLines";
            this.fld_txtMMLineContactEmail.BOSDescription = null;
            this.fld_txtMMLineContactEmail.BOSError = "";
            this.fld_txtMMLineContactEmail.BOSFieldGroup = "";
            this.fld_txtMMLineContactEmail.BOSFieldRelation = "";
            this.fld_txtMMLineContactEmail.BOSPrivilege = "";
            this.fld_txtMMLineContactEmail.BOSPropertyName = "Text";
            this.fld_txtMMLineContactEmail.Location = new System.Drawing.Point(116, 100);
            this.fld_txtMMLineContactEmail.Name = "fld_txtMMLineContactEmail";
            this.fld_txtMMLineContactEmail.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMLineContactEmail.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMLineContactEmail.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMLineContactEmail.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMLineContactEmail.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMLineContactEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMLineContactEmail.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMLineContactEmail, true);
            this.fld_txtMMLineContactEmail.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMLineContactEmail.TabIndex = 5;
            this.fld_txtMMLineContactEmail.Tag = "DC";
            // 
            // fld_txtMMLineContactDepartment
            // 
            this.fld_txtMMLineContactDepartment.BOSComment = "";
            this.fld_txtMMLineContactDepartment.BOSDataMember = "MMLineContactDepartment";
            this.fld_txtMMLineContactDepartment.BOSDataSource = "MMLines";
            this.fld_txtMMLineContactDepartment.BOSDescription = null;
            this.fld_txtMMLineContactDepartment.BOSError = "";
            this.fld_txtMMLineContactDepartment.BOSFieldGroup = "";
            this.fld_txtMMLineContactDepartment.BOSFieldRelation = "";
            this.fld_txtMMLineContactDepartment.BOSPrivilege = "";
            this.fld_txtMMLineContactDepartment.BOSPropertyName = "Text";
            this.fld_txtMMLineContactDepartment.Location = new System.Drawing.Point(116, 126);
            this.fld_txtMMLineContactDepartment.Name = "fld_txtMMLineContactDepartment";
            this.fld_txtMMLineContactDepartment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMLineContactDepartment.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMLineContactDepartment.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMLineContactDepartment.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMLineContactDepartment.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMLineContactDepartment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMLineContactDepartment.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMLineContactDepartment, true);
            this.fld_txtMMLineContactDepartment.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMLineContactDepartment.TabIndex = 7;
            this.fld_txtMMLineContactDepartment.Tag = "DC";
            // 
            // fld_txtMMLineContactRoom
            // 
            this.fld_txtMMLineContactRoom.BOSComment = "";
            this.fld_txtMMLineContactRoom.BOSDataMember = "MMLineContactRoom";
            this.fld_txtMMLineContactRoom.BOSDataSource = "MMLines";
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
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_MMWorkShopID);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl.Controls.Add(this.fld_medMMLineDesc);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel13);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtMMLineNo);
            this.fld_grcGroupControl.Controls.Add(this.bosTextBox1);
            this.fld_grcGroupControl.Controls.Add(this.fld_chkMMLineActiveCheck);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtMMLineName);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl, true);
            this.fld_grcGroupControl.Size = new System.Drawing.Size(884, 118);
            this.fld_grcGroupControl.TabIndex = 0;
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // fld_lkeFK_MMWorkShopID
            // 
            this.fld_lkeFK_MMWorkShopID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMWorkShopID.BOSAllowDummy = false;
            this.fld_lkeFK_MMWorkShopID.BOSComment = null;
            this.fld_lkeFK_MMWorkShopID.BOSDataMember = "FK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.BOSDataSource = "MMLines";
            this.fld_lkeFK_MMWorkShopID.BOSDescription = null;
            this.fld_lkeFK_MMWorkShopID.BOSError = null;
            this.fld_lkeFK_MMWorkShopID.BOSFieldGroup = null;
            this.fld_lkeFK_MMWorkShopID.BOSFieldParent = null;
            this.fld_lkeFK_MMWorkShopID.BOSFieldRelation = null;
            this.fld_lkeFK_MMWorkShopID.BOSPrivilege = null;
            this.fld_lkeFK_MMWorkShopID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMWorkShopID.BOSSelectType = null;
            this.fld_lkeFK_MMWorkShopID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMWorkShopID.CurrentDisplayText = null;
            this.fld_lkeFK_MMWorkShopID.Location = new System.Drawing.Point(115, 51);
            this.fld_lkeFK_MMWorkShopID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_MMWorkShopID.Name = "fld_lkeFK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMWorkShopID.Properties.ColumnName = null;
            this.fld_lkeFK_MMWorkShopID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopName", "Xưởng")});
            this.fld_lkeFK_MMWorkShopID.Properties.DisplayMember = "MMWorkShopName";
            this.fld_lkeFK_MMWorkShopID.Properties.ValueMember = "MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Screen = null;
            this.fld_lkeFK_MMWorkShopID.Size = new System.Drawing.Size(160, 20);
            this.fld_lkeFK_MMWorkShopID.TabIndex = 2;
            this.fld_lkeFK_MMWorkShopID.Tag = "DC";
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
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(63, 13);
            this.bosLabel3.TabIndex = 102;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Thuộc xưởng";
            // 
            // fld_medMMLineDesc
            // 
            this.fld_medMMLineDesc.BOSComment = "";
            this.fld_medMMLineDesc.BOSDataMember = "MMLineDesc";
            this.fld_medMMLineDesc.BOSDataSource = "MMLines";
            this.fld_medMMLineDesc.BOSDescription = null;
            this.fld_medMMLineDesc.BOSError = null;
            this.fld_medMMLineDesc.BOSFieldGroup = "";
            this.fld_medMMLineDesc.BOSFieldRelation = "";
            this.fld_medMMLineDesc.BOSPrivilege = "";
            this.fld_medMMLineDesc.BOSPropertyName = "EditValue";
            this.fld_medMMLineDesc.EditValue = "";
            this.fld_medMMLineDesc.Location = new System.Drawing.Point(113, 77);
            this.fld_medMMLineDesc.Name = "fld_medMMLineDesc";
            this.fld_medMMLineDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medMMLineDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medMMLineDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medMMLineDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medMMLineDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medMMLineDesc, true);
            this.fld_medMMLineDesc.Size = new System.Drawing.Size(422, 35);
            this.fld_medMMLineDesc.TabIndex = 5;
            this.fld_medMMLineDesc.Tag = "DC";
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
            this.bosLabel13.Location = new System.Drawing.Point(26, 80);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel13, true);
            this.bosLabel13.Size = new System.Drawing.Size(40, 13);
            this.bosLabel13.TabIndex = 100;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "Diễn giải";
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
            this.fld_lblLabel4.Size = new System.Drawing.Size(53, 13);
            this.fld_lblLabel4.TabIndex = 99;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Mã chuyền";
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
            this.bosLabel2.Size = new System.Drawing.Size(21, 13);
            this.bosLabel2.TabIndex = 97;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "STT";
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
            this.bosLabel1.Size = new System.Drawing.Size(57, 13);
            this.bosLabel1.TabIndex = 97;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Tên chuyền";
            // 
            // fld_txtMMLineNo
            // 
            this.fld_txtMMLineNo.BOSComment = "";
            this.fld_txtMMLineNo.BOSDataMember = "MMLineNo";
            this.fld_txtMMLineNo.BOSDataSource = "MMLines";
            this.fld_txtMMLineNo.BOSDescription = null;
            this.fld_txtMMLineNo.BOSError = "";
            this.fld_txtMMLineNo.BOSFieldGroup = "";
            this.fld_txtMMLineNo.BOSFieldRelation = "";
            this.fld_txtMMLineNo.BOSPrivilege = "";
            this.fld_txtMMLineNo.BOSPropertyName = "Text";
            this.fld_txtMMLineNo.Location = new System.Drawing.Point(115, 25);
            this.fld_txtMMLineNo.Name = "fld_txtMMLineNo";
            this.fld_txtMMLineNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMLineNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMLineNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMLineNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMLineNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMLineNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMLineNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMLineNo, true);
            this.fld_txtMMLineNo.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMLineNo.TabIndex = 0;
            this.fld_txtMMLineNo.Tag = "DC";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "MMLineOrder";
            this.bosTextBox1.BOSDataSource = "MMLines";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = "";
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.Location = new System.Drawing.Point(378, 51);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(48, 20);
            this.bosTextBox1.TabIndex = 3;
            this.bosTextBox1.Tag = "DC";
            // 
            // fld_chkMMLineActiveCheck
            // 
            this.fld_chkMMLineActiveCheck.BOSComment = "";
            this.fld_chkMMLineActiveCheck.BOSDataMember = "MMLineActiveCheck";
            this.fld_chkMMLineActiveCheck.BOSDataSource = "MMLines";
            this.fld_chkMMLineActiveCheck.BOSDescription = null;
            this.fld_chkMMLineActiveCheck.BOSError = "";
            this.fld_chkMMLineActiveCheck.BOSFieldGroup = "";
            this.fld_chkMMLineActiveCheck.BOSFieldRelation = "";
            this.fld_chkMMLineActiveCheck.BOSPrivilege = "";
            this.fld_chkMMLineActiveCheck.BOSPropertyName = "EditValue";
            this.fld_chkMMLineActiveCheck.Location = new System.Drawing.Point(460, 52);
            this.fld_chkMMLineActiveCheck.Name = "fld_chkMMLineActiveCheck";
            this.fld_chkMMLineActiveCheck.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkMMLineActiveCheck.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkMMLineActiveCheck.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkMMLineActiveCheck.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkMMLineActiveCheck.Properties.Caption = "Hoạt động";
            this.fld_chkMMLineActiveCheck.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_chkMMLineActiveCheck, true);
            this.fld_chkMMLineActiveCheck.Size = new System.Drawing.Size(75, 19);
            this.fld_chkMMLineActiveCheck.TabIndex = 4;
            this.fld_chkMMLineActiveCheck.Tag = "DC";
            // 
            // fld_txtMMLineName
            // 
            this.fld_txtMMLineName.BOSComment = "";
            this.fld_txtMMLineName.BOSDataMember = "MMLineName";
            this.fld_txtMMLineName.BOSDataSource = "MMLines";
            this.fld_txtMMLineName.BOSDescription = null;
            this.fld_txtMMLineName.BOSError = "";
            this.fld_txtMMLineName.BOSFieldGroup = "";
            this.fld_txtMMLineName.BOSFieldRelation = "";
            this.fld_txtMMLineName.BOSPrivilege = "";
            this.fld_txtMMLineName.BOSPropertyName = "Text";
            this.fld_txtMMLineName.Location = new System.Drawing.Point(378, 25);
            this.fld_txtMMLineName.Name = "fld_txtMMLineName";
            this.fld_txtMMLineName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMLineName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMLineName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMLineName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMLineName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMLineName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMLineName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMLineName, true);
            this.fld_txtMMLineName.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMLineName.TabIndex = 1;
            this.fld_txtMMLineName.Tag = "DC";
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
            // DMLM100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(890, 568);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMLM100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).EndInit();
            this.fld_grcGroupControl3.ResumeLayout(false);
            this.fld_grcGroupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactCellPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactRoom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMLineDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkMMLineActiveCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSMemoEdit fld_medMMLineDesc;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMLineNo;
        private BOSComponent.BOSTextBox fld_txtMMLineName;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private BOSComponent.BOSCheckEdit fld_chkMMLineActiveCheck;
        private BOSComponent.BOSGroupControl fld_grcGroupControl3;
        private BOSComponent.BOSLabel fld_lblLabel27;
        private BOSComponent.BOSLabel fld_lblLabel30;
        private BOSComponent.BOSLabel fld_lblLabel32;
        private BOSComponent.BOSLabel fld_lblLabel38;
        private BOSComponent.BOSLabel fld_lblLabel41;
        private BOSComponent.BOSLabel fld_lblLabel42;
        private BOSComponent.BOSLabel fld_lblLabel43;
        private BOSComponent.BOSLabel fld_lblLabel45;
        private BOSComponent.BOSTextBox fld_txtMMLineContactTitle;
        private BOSComponent.BOSTextBox fld_txtMMLineContactFirstName;
        private BOSComponent.BOSTextBox fld_txtMMLineContactPhone;
        private BOSComponent.BOSTextBox fld_txtMMLineContactFax;
        private BOSComponent.BOSTextBox fld_txtMMLineContactCellPhone;
        private BOSComponent.BOSTextBox fld_txtMMLineContactEmail;
        private BOSComponent.BOSTextBox fld_txtMMLineContactDepartment;
        private BOSComponent.BOSTextBox fld_txtMMLineContactRoom;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMWorkShopID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSButton fld_btnInsertValueByEmployee;
    }
}
