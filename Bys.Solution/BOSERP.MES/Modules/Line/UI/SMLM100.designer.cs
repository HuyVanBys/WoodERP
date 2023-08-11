using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Line.UI
{
	/// <summary>
	/// Summary description for SRLM100
	/// </summary>
	partial class SMLM100
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
            this.fld_lblLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel32 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel38 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel41 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel42 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel45 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMLineContactTitle = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMLineContactFirstName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMLineContactPhone = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMLineContactEmail = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMLineContactDepartment = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMLineContactRoom = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcMMLines = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMLineNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMLineName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_MMWorkShopID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactRoom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.fld_lblLabel27.Location = new System.Drawing.Point(25, 94);
            this.fld_lblLabel27.Name = "fld_lblLabel27";
            this.fld_lblLabel27.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel27, true);
            this.fld_lblLabel27.Size = new System.Drawing.Size(22, 13);
            this.fld_lblLabel27.TabIndex = 136;
            this.fld_lblLabel27.Tag = "SI";
            this.fld_lblLabel27.Text = "Tên ";
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
            this.fld_lblLabel32.Location = new System.Drawing.Point(290, 68);
            this.fld_lblLabel32.Name = "fld_lblLabel32";
            this.fld_lblLabel32.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel32, true);
            this.fld_lblLabel32.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel32.TabIndex = 138;
            this.fld_lblLabel32.Tag = "SI";
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
            this.fld_lblLabel38.Location = new System.Drawing.Point(25, 68);
            this.fld_lblLabel38.Name = "fld_lblLabel38";
            this.fld_lblLabel38.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel38, true);
            this.fld_lblLabel38.Size = new System.Drawing.Size(52, 13);
            this.fld_lblLabel38.TabIndex = 139;
            this.fld_lblLabel38.Tag = "SI";
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
            this.fld_lblLabel41.Location = new System.Drawing.Point(25, 119);
            this.fld_lblLabel41.Name = "fld_lblLabel41";
            this.fld_lblLabel41.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel41, true);
            this.fld_lblLabel41.Size = new System.Drawing.Size(25, 13);
            this.fld_lblLabel41.TabIndex = 140;
            this.fld_lblLabel41.Tag = "SI";
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
            this.fld_lblLabel42.Location = new System.Drawing.Point(290, 117);
            this.fld_lblLabel42.Name = "fld_lblLabel42";
            this.fld_lblLabel42.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel42, true);
            this.fld_lblLabel42.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel42.TabIndex = 141;
            this.fld_lblLabel42.Tag = "SI";
            this.fld_lblLabel42.Text = "Điện thoại";
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
            this.fld_lblLabel45.Location = new System.Drawing.Point(290, 42);
            this.fld_lblLabel45.Name = "fld_lblLabel45";
            this.fld_lblLabel45.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel45, true);
            this.fld_lblLabel45.Size = new System.Drawing.Size(52, 13);
            this.fld_lblLabel45.TabIndex = 143;
            this.fld_lblLabel45.Tag = "SI";
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
            this.fld_txtMMLineContactTitle.Location = new System.Drawing.Point(114, 64);
            this.fld_txtMMLineContactTitle.Name = "fld_txtMMLineContactTitle";
            this.fld_txtMMLineContactTitle.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMLineContactTitle.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMLineContactTitle.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMLineContactTitle.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMLineContactTitle.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMLineContactTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMLineContactTitle.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMLineContactTitle, true);
            this.fld_txtMMLineContactTitle.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMLineContactTitle.TabIndex = 125;
            this.fld_txtMMLineContactTitle.Tag = "SC";
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
            this.fld_txtMMLineContactFirstName.Location = new System.Drawing.Point(114, 90);
            this.fld_txtMMLineContactFirstName.Name = "fld_txtMMLineContactFirstName";
            this.fld_txtMMLineContactFirstName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMLineContactFirstName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMLineContactFirstName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMLineContactFirstName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMLineContactFirstName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMLineContactFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMLineContactFirstName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMLineContactFirstName, true);
            this.fld_txtMMLineContactFirstName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMLineContactFirstName.TabIndex = 126;
            this.fld_txtMMLineContactFirstName.Tag = "SC";
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
            this.fld_txtMMLineContactPhone.Location = new System.Drawing.Point(357, 116);
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
            this.fld_txtMMLineContactPhone.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMLineContactPhone.TabIndex = 127;
            this.fld_txtMMLineContactPhone.Tag = "SC";
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
            this.fld_txtMMLineContactEmail.Location = new System.Drawing.Point(114, 116);
            this.fld_txtMMLineContactEmail.Name = "fld_txtMMLineContactEmail";
            this.fld_txtMMLineContactEmail.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMLineContactEmail.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMLineContactEmail.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMLineContactEmail.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMLineContactEmail.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMLineContactEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMLineContactEmail.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMLineContactEmail, true);
            this.fld_txtMMLineContactEmail.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMLineContactEmail.TabIndex = 129;
            this.fld_txtMMLineContactEmail.Tag = "SC";
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
            this.fld_txtMMLineContactDepartment.Location = new System.Drawing.Point(357, 64);
            this.fld_txtMMLineContactDepartment.Name = "fld_txtMMLineContactDepartment";
            this.fld_txtMMLineContactDepartment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMLineContactDepartment.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMLineContactDepartment.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMLineContactDepartment.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMLineContactDepartment.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMLineContactDepartment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMLineContactDepartment.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMLineContactDepartment, true);
            this.fld_txtMMLineContactDepartment.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMLineContactDepartment.TabIndex = 131;
            this.fld_txtMMLineContactDepartment.Tag = "SC";
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
            this.fld_txtMMLineContactRoom.Location = new System.Drawing.Point(357, 38);
            this.fld_txtMMLineContactRoom.Name = "fld_txtMMLineContactRoom";
            this.fld_txtMMLineContactRoom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMLineContactRoom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMLineContactRoom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMLineContactRoom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMLineContactRoom.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMLineContactRoom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMLineContactRoom.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMLineContactRoom, true);
            this.fld_txtMMLineContactRoom.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMLineContactRoom.TabIndex = 132;
            this.fld_txtMMLineContactRoom.Tag = "SC";
            // 
            // fld_dgcMMLines
            // 
            this.fld_dgcMMLines.AllowDrop = true;
            this.fld_dgcMMLines.BOSComment = "";
            this.fld_dgcMMLines.BOSDataMember = null;
            this.fld_dgcMMLines.BOSDataSource = "MMLines";
            this.fld_dgcMMLines.BOSDescription = null;
            this.fld_dgcMMLines.BOSError = "";
            this.fld_dgcMMLines.BOSFieldGroup = "";
            this.fld_dgcMMLines.BOSFieldRelation = null;
            this.fld_dgcMMLines.BOSGridType = null;
            this.fld_dgcMMLines.BOSPrivilege = "";
            this.fld_dgcMMLines.BOSPropertyName = null;
            this.fld_dgcMMLines.CommodityType = "";
            this.fld_dgcMMLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_dgcMMLines.Location = new System.Drawing.Point(15, 156);
            this.fld_dgcMMLines.Name = "fld_dgcMMLines";
            this.fld_dgcMMLines.PrintReport = false;
            this.fld_dgcMMLines.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMLines, true);
            this.fld_dgcMMLines.Size = new System.Drawing.Size(863, 401);
            this.fld_dgcMMLines.TabIndex = 135;
            this.fld_dgcMMLines.Tag = "SR";
            this.fld_dgcMMLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICProduct});
            // 
            // fld_dgvICProduct
            // 
            this.fld_dgvICProduct.GridControl = this.fld_dgcMMLines;
            this.fld_dgvICProduct.Name = "fld_dgvICProduct";
            this.fld_dgvICProduct.PaintStyleName = "Office2003";
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(25, 12);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel4, true);
            this.fld_lblLabel4.Size = new System.Drawing.Size(53, 13);
            this.fld_lblLabel4.TabIndex = 134;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Mã chuyền";
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
            this.bosLabel1.Location = new System.Drawing.Point(25, 42);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(57, 13);
            this.bosLabel1.TabIndex = 133;
            this.bosLabel1.Tag = "SI";
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
            this.fld_txtMMLineNo.Location = new System.Drawing.Point(114, 12);
            this.fld_txtMMLineNo.Name = "fld_txtMMLineNo";
            this.fld_txtMMLineNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMLineNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMLineNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMLineNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMLineNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMLineNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMLineNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMLineNo, true);
            this.fld_txtMMLineNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMLineNo.TabIndex = 123;
            this.fld_txtMMLineNo.Tag = "SC";
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
            this.fld_txtMMLineName.Location = new System.Drawing.Point(114, 38);
            this.fld_txtMMLineName.Name = "fld_txtMMLineName";
            this.fld_txtMMLineName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMLineName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMLineName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMLineName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMLineName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMLineName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMLineName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMLineName, true);
            this.fld_txtMMLineName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMLineName.TabIndex = 124;
            this.fld_txtMMLineName.Tag = "SC";
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
            this.fld_lkeFK_MMWorkShopID.Location = new System.Drawing.Point(357, 90);
            this.fld_lkeFK_MMWorkShopID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_MMWorkShopID.Name = "fld_lkeFK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMWorkShopID.Properties.ColumnName = null;
            this.fld_lkeFK_MMWorkShopID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopName", "Xưởng")});
            this.fld_lkeFK_MMWorkShopID.Properties.DisplayMember = "MMWorkShopName";
            this.fld_lkeFK_MMWorkShopID.Properties.ValueMember = "MMWorkShopNo";
            this.fld_lkeFK_MMWorkShopID.Screen = null;
            this.fld_lkeFK_MMWorkShopID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMWorkShopID.TabIndex = 144;
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
            this.bosLabel3.Location = new System.Drawing.Point(290, 94);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(31, 13);
            this.bosLabel3.TabIndex = 145;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Xưởng";
            // 
            // SMLM100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(896, 575);
            this.Controls.Add(this.fld_lkeFK_MMWorkShopID);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lblLabel27);
            this.Controls.Add(this.fld_lblLabel32);
            this.Controls.Add(this.fld_lblLabel38);
            this.Controls.Add(this.fld_lblLabel41);
            this.Controls.Add(this.fld_lblLabel42);
            this.Controls.Add(this.fld_lblLabel45);
            this.Controls.Add(this.fld_txtMMLineContactTitle);
            this.Controls.Add(this.fld_txtMMLineContactFirstName);
            this.Controls.Add(this.fld_txtMMLineContactPhone);
            this.Controls.Add(this.fld_txtMMLineContactEmail);
            this.Controls.Add(this.fld_txtMMLineContactDepartment);
            this.Controls.Add(this.fld_txtMMLineContactRoom);
            this.Controls.Add(this.fld_dgcMMLines);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtMMLineNo);
            this.Controls.Add(this.fld_txtMMLineName);
            this.Name = "SMLM100";
            this.Tag = "SM";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtMMLineName, 0);
            this.Controls.SetChildIndex(this.fld_txtMMLineNo, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.fld_dgcMMLines, 0);
            this.Controls.SetChildIndex(this.fld_txtMMLineContactRoom, 0);
            this.Controls.SetChildIndex(this.fld_txtMMLineContactDepartment, 0);
            this.Controls.SetChildIndex(this.fld_txtMMLineContactEmail, 0);
            this.Controls.SetChildIndex(this.fld_txtMMLineContactPhone, 0);
            this.Controls.SetChildIndex(this.fld_txtMMLineContactFirstName, 0);
            this.Controls.SetChildIndex(this.fld_txtMMLineContactTitle, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel45, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel42, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel41, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel38, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel32, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel27, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_MMWorkShopID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineContactRoom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMLineName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel27;
        private BOSComponent.BOSLabel fld_lblLabel32;
        private BOSComponent.BOSLabel fld_lblLabel38;
        private BOSComponent.BOSLabel fld_lblLabel41;
        private BOSComponent.BOSLabel fld_lblLabel42;
        private BOSComponent.BOSLabel fld_lblLabel45;
        private BOSComponent.BOSTextBox fld_txtMMLineContactTitle;
        private BOSComponent.BOSTextBox fld_txtMMLineContactFirstName;
        private BOSComponent.BOSTextBox fld_txtMMLineContactPhone;
        private BOSComponent.BOSTextBox fld_txtMMLineContactEmail;
        private BOSComponent.BOSTextBox fld_txtMMLineContactDepartment;
        private BOSComponent.BOSTextBox fld_txtMMLineContactRoom;
        private BOSSearchResultsGridControl fld_dgcMMLines;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICProduct;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMLineNo;
        private BOSComponent.BOSTextBox fld_txtMMLineName;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMWorkShopID;
        private BOSComponent.BOSLabel bosLabel3;
	}
}
