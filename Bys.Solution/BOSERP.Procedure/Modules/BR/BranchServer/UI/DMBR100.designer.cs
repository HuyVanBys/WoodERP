using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Branch.UI
{
	/// <summary>
	/// Summary description for DMBR100
	/// </summary>
	partial class DMBR100
	{
		private BOSComponent.BOSLabel fld_lblLabel12;
		private BOSComponent.BOSLabel fld_lblLabel14;
		private BOSComponent.BOSLabel fld_lblLabel18;
		private BOSComponent.BOSLine fld_Line1;
        private BOSComponent.BOSLabel fld_lblLabel27;
        private BOSComponent.BOSLabel fld_lblLabel30;
        private BOSComponent.BOSLabel fld_lblLabel32;
        private BOSComponent.BOSLabel fld_lblLabel38;
		private BOSComponent.BOSLabel fld_lblLabel41;
        private BOSComponent.BOSLabel fld_lblLabel42;
        private BOSComponent.BOSLabel fld_lblLabel45;
		private BOSComponent.BOSLine fld_Line2;
		private BOSComponent.BOSLine fld_Line3;
		private BOSComponent.BOSTextBox fld_txtBRBranchName;
		private BOSComponent.BOSTextBox fld_txtBRBranchContactTitle;
        private BOSComponent.BOSTextBox fld_txtBRBranchContactFirstName;
        private BOSComponent.BOSTextBox fld_txtBRBranchContactPhone;
		private BOSComponent.BOSTextBox fld_txtBRBranchContactCellPhone;
		private BOSComponent.BOSTextBox fld_txtBRBranchContactEmail1;
		private BOSComponent.BOSTextBox fld_txtBRBranchContactDepartment;
        private BOSComponent.BOSTextBox fld_txtBRBranchContactRoom;
        private BOSComponent.BOSMemoEdit fld_medBRBranchDesc;
		private BOSComponent.BOSCheckEdit fld_chkBRBranchActiveCheck;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
		private BOSComponent.BOSGroupControl fld_grcGroupControl3;
		private BOSComponent.BOSTextBox fld_txtBRBranchNo1;
		private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSTextBox fld_txtBRBranchContactAddressLine1;


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
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_Line1 = new BOSComponent.BOSLine(this.components);
            this.fld_lblLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel30 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel32 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel38 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel41 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel42 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel45 = new BOSComponent.BOSLabel(this.components);
            this.fld_Line2 = new BOSComponent.BOSLine(this.components);
            this.fld_Line3 = new BOSComponent.BOSLine(this.components);
            this.fld_txtBRBranchName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtBRBranchContactTitle = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtBRBranchContactFirstName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtBRBranchContactPhone = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtBRBranchContactCellPhone = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtBRBranchContactEmail1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtBRBranchContactDepartment = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtBRBranchContactRoom = new BOSComponent.BOSTextBox(this.components);
            this.fld_medBRBranchDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_chkBRBranchActiveCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeBRBranchParentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeBRBranchType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_bedGELocationName = new BOSComponent.BOSButtonEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtBRBranchCompanyName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtBRBranchNo1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtBRBranchContactAddressPostalCode = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtBRBranchContactAddressCountry = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtBRBranchContactAddressStateProvince = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtBRBranchContactAddressCity = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtBRBranchContactAddressLine1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_grcGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtBRBranchContactFax = new BOSComponent.BOSTextBox(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_txtBRBranchDatabasePassword = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtBRBranchDatabaseUser = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtBRBranchDatabase = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtBRBranchServerAliasName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtBRBranchServerName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.bosTextBox5 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactCellPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactEmail1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactRoom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medBRBranchDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkBRBranchActiveCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchParentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedGELocationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchCompanyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactAddressPostalCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactAddressCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactAddressStateProvince.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactAddressCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactAddressLine1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).BeginInit();
            this.fld_grcGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchDatabasePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchDatabaseUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchServerAliasName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchServerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel12
            // 
            this.fld_lblLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel12.Appearance.Options.UseFont = true;
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
            this.fld_lblLabel12.Location = new System.Drawing.Point(17, 36);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel12.TabIndex = 4;
            this.fld_lblLabel12.Tag = "";
            this.fld_lblLabel12.Text = "Mã chi nhánh";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel14.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseFont = true;
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
            this.fld_lblLabel14.Location = new System.Drawing.Point(16, 61);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(69, 13);
            this.fld_lblLabel14.TabIndex = 6;
            this.fld_lblLabel14.Tag = "";
            this.fld_lblLabel14.Text = "Tên chi nhánh";
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
            this.fld_lblLabel18.Location = new System.Drawing.Point(17, 109);
            this.fld_lblLabel18.Name = "fld_lblLabel18";
            this.fld_lblLabel18.Screen = null;
            this.fld_lblLabel18.Size = new System.Drawing.Size(37, 13);
            this.fld_lblLabel18.TabIndex = 14;
            this.fld_lblLabel18.Tag = "";
            this.fld_lblLabel18.Text = "Ghi chú";
            // 
            // fld_Line1
            // 
            this.fld_Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.fld_Line1.BOSComment = null;
            this.fld_Line1.BOSDataMember = null;
            this.fld_Line1.BOSDataSource = null;
            this.fld_Line1.BOSDescription = null;
            this.fld_Line1.BOSError = null;
            this.fld_Line1.BOSFieldGroup = "";
            this.fld_Line1.BOSFieldRelation = null;
            this.fld_Line1.BOSPrivilege = "";
            this.fld_Line1.BOSPropertyName = null;
            this.fld_Line1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_Line1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line1.Location = new System.Drawing.Point(304, 603);
            this.fld_Line1.Name = "fld_Line1";
            this.fld_Line1.Screen = null;
            this.fld_Line1.Size = new System.Drawing.Size(0, 0);
            this.fld_Line1.TabIndex = 27;
            this.fld_Line1.TabStop = false;
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
            this.fld_lblLabel27.Location = new System.Drawing.Point(12, 53);
            this.fld_lblLabel27.Name = "fld_lblLabel27";
            this.fld_lblLabel27.Screen = null;
            this.fld_lblLabel27.Size = new System.Drawing.Size(19, 13);
            this.fld_lblLabel27.TabIndex = 51;
            this.fld_lblLabel27.Tag = "";
            this.fld_lblLabel27.Text = "Tên";
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
            this.fld_lblLabel30.Location = new System.Drawing.Point(259, 78);
            this.fld_lblLabel30.Name = "fld_lblLabel30";
            this.fld_lblLabel30.Screen = null;
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
            this.fld_lblLabel32.Location = new System.Drawing.Point(12, 128);
            this.fld_lblLabel32.Name = "fld_lblLabel32";
            this.fld_lblLabel32.Screen = null;
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
            this.fld_lblLabel38.Location = new System.Drawing.Point(12, 28);
            this.fld_lblLabel38.Name = "fld_lblLabel38";
            this.fld_lblLabel38.Screen = null;
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
            this.fld_lblLabel41.Location = new System.Drawing.Point(12, 103);
            this.fld_lblLabel41.Name = "fld_lblLabel41";
            this.fld_lblLabel41.Screen = null;
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
            this.fld_lblLabel42.Location = new System.Drawing.Point(12, 78);
            this.fld_lblLabel42.Name = "fld_lblLabel42";
            this.fld_lblLabel42.Screen = null;
            this.fld_lblLabel42.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel42.TabIndex = 66;
            this.fld_lblLabel42.Tag = "";
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
            this.fld_lblLabel45.Location = new System.Drawing.Point(259, 128);
            this.fld_lblLabel45.Name = "fld_lblLabel45";
            this.fld_lblLabel45.Screen = null;
            this.fld_lblLabel45.Size = new System.Drawing.Size(52, 13);
            this.fld_lblLabel45.TabIndex = 69;
            this.fld_lblLabel45.Tag = "";
            this.fld_lblLabel45.Text = "Phòng ban";
            // 
            // fld_Line2
            // 
            this.fld_Line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.fld_Line2.BOSComment = null;
            this.fld_Line2.BOSDataMember = null;
            this.fld_Line2.BOSDataSource = null;
            this.fld_Line2.BOSDescription = null;
            this.fld_Line2.BOSError = null;
            this.fld_Line2.BOSFieldGroup = "";
            this.fld_Line2.BOSFieldRelation = null;
            this.fld_Line2.BOSPrivilege = "";
            this.fld_Line2.BOSPropertyName = null;
            this.fld_Line2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_Line2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line2.Location = new System.Drawing.Point(586, 485);
            this.fld_Line2.Name = "fld_Line2";
            this.fld_Line2.Screen = null;
            this.fld_Line2.Size = new System.Drawing.Size(0, 0);
            this.fld_Line2.TabIndex = 73;
            this.fld_Line2.TabStop = false;
            // 
            // fld_Line3
            // 
            this.fld_Line3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.fld_Line3.BOSComment = null;
            this.fld_Line3.BOSDataMember = null;
            this.fld_Line3.BOSDataSource = null;
            this.fld_Line3.BOSDescription = null;
            this.fld_Line3.BOSError = null;
            this.fld_Line3.BOSFieldGroup = "";
            this.fld_Line3.BOSFieldRelation = null;
            this.fld_Line3.BOSPrivilege = "";
            this.fld_Line3.BOSPropertyName = null;
            this.fld_Line3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_Line3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line3.Location = new System.Drawing.Point(399, 506);
            this.fld_Line3.Name = "fld_Line3";
            this.fld_Line3.Screen = null;
            this.fld_Line3.Size = new System.Drawing.Size(0, 0);
            this.fld_Line3.TabIndex = 144;
            this.fld_Line3.TabStop = false;
            // 
            // fld_txtBRBranchName
            // 
            this.fld_txtBRBranchName.BOSComment = "";
            this.fld_txtBRBranchName.BOSDataMember = "BRBranchName";
            this.fld_txtBRBranchName.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchName.BOSDescription = null;
            this.fld_txtBRBranchName.BOSError = "";
            this.fld_txtBRBranchName.BOSFieldGroup = "";
            this.fld_txtBRBranchName.BOSFieldRelation = "";
            this.fld_txtBRBranchName.BOSPrivilege = "";
            this.fld_txtBRBranchName.BOSPropertyName = "Text";
            this.fld_txtBRBranchName.Location = new System.Drawing.Point(104, 58);
            this.fld_txtBRBranchName.Name = "fld_txtBRBranchName";
            this.fld_txtBRBranchName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtBRBranchName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtBRBranchName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtBRBranchName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtBRBranchName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtBRBranchName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtBRBranchName.Screen = null;
            this.fld_txtBRBranchName.Size = new System.Drawing.Size(372, 20);
            this.fld_txtBRBranchName.TabIndex = 2;
            this.fld_txtBRBranchName.Tag = "DC";
            // 
            // fld_txtBRBranchContactTitle
            // 
            this.fld_txtBRBranchContactTitle.BOSComment = "";
            this.fld_txtBRBranchContactTitle.BOSDataMember = "BRBranchContactTitle";
            this.fld_txtBRBranchContactTitle.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchContactTitle.BOSDescription = null;
            this.fld_txtBRBranchContactTitle.BOSError = "";
            this.fld_txtBRBranchContactTitle.BOSFieldGroup = "";
            this.fld_txtBRBranchContactTitle.BOSFieldRelation = "";
            this.fld_txtBRBranchContactTitle.BOSPrivilege = "";
            this.fld_txtBRBranchContactTitle.BOSPropertyName = "Text";
            this.fld_txtBRBranchContactTitle.Location = new System.Drawing.Point(88, 25);
            this.fld_txtBRBranchContactTitle.Name = "fld_txtBRBranchContactTitle";
            this.fld_txtBRBranchContactTitle.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtBRBranchContactTitle.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtBRBranchContactTitle.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtBRBranchContactTitle.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtBRBranchContactTitle.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtBRBranchContactTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtBRBranchContactTitle.Screen = null;
            this.fld_txtBRBranchContactTitle.Size = new System.Drawing.Size(150, 20);
            this.fld_txtBRBranchContactTitle.TabIndex = 1;
            this.fld_txtBRBranchContactTitle.Tag = "DC";
            // 
            // fld_txtBRBranchContactFirstName
            // 
            this.fld_txtBRBranchContactFirstName.BOSComment = "";
            this.fld_txtBRBranchContactFirstName.BOSDataMember = "BRBranchContactName";
            this.fld_txtBRBranchContactFirstName.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchContactFirstName.BOSDescription = null;
            this.fld_txtBRBranchContactFirstName.BOSError = "";
            this.fld_txtBRBranchContactFirstName.BOSFieldGroup = "";
            this.fld_txtBRBranchContactFirstName.BOSFieldRelation = "";
            this.fld_txtBRBranchContactFirstName.BOSPrivilege = "";
            this.fld_txtBRBranchContactFirstName.BOSPropertyName = "Text";
            this.fld_txtBRBranchContactFirstName.Location = new System.Drawing.Point(88, 50);
            this.fld_txtBRBranchContactFirstName.Name = "fld_txtBRBranchContactFirstName";
            this.fld_txtBRBranchContactFirstName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtBRBranchContactFirstName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtBRBranchContactFirstName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtBRBranchContactFirstName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtBRBranchContactFirstName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtBRBranchContactFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtBRBranchContactFirstName.Screen = null;
            this.fld_txtBRBranchContactFirstName.Size = new System.Drawing.Size(404, 20);
            this.fld_txtBRBranchContactFirstName.TabIndex = 2;
            this.fld_txtBRBranchContactFirstName.Tag = "DC";
            // 
            // fld_txtBRBranchContactPhone
            // 
            this.fld_txtBRBranchContactPhone.BOSComment = "";
            this.fld_txtBRBranchContactPhone.BOSDataMember = "BRBranchContactPhone";
            this.fld_txtBRBranchContactPhone.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchContactPhone.BOSDescription = null;
            this.fld_txtBRBranchContactPhone.BOSError = "";
            this.fld_txtBRBranchContactPhone.BOSFieldGroup = "";
            this.fld_txtBRBranchContactPhone.BOSFieldRelation = "";
            this.fld_txtBRBranchContactPhone.BOSPrivilege = "";
            this.fld_txtBRBranchContactPhone.BOSPropertyName = "Text";
            this.fld_txtBRBranchContactPhone.Location = new System.Drawing.Point(88, 75);
            this.fld_txtBRBranchContactPhone.Name = "fld_txtBRBranchContactPhone";
            this.fld_txtBRBranchContactPhone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtBRBranchContactPhone.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtBRBranchContactPhone.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtBRBranchContactPhone.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtBRBranchContactPhone.Properties.Mask.EditMask = "\\d+";
            this.fld_txtBRBranchContactPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.fld_txtBRBranchContactPhone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtBRBranchContactPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtBRBranchContactPhone.Screen = null;
            this.fld_txtBRBranchContactPhone.Size = new System.Drawing.Size(150, 20);
            this.fld_txtBRBranchContactPhone.TabIndex = 3;
            this.fld_txtBRBranchContactPhone.Tag = "DC";
            // 
            // fld_txtBRBranchContactCellPhone
            // 
            this.fld_txtBRBranchContactCellPhone.BOSComment = "";
            this.fld_txtBRBranchContactCellPhone.BOSDataMember = "BRBranchContactCellPhone";
            this.fld_txtBRBranchContactCellPhone.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchContactCellPhone.BOSDescription = null;
            this.fld_txtBRBranchContactCellPhone.BOSError = "";
            this.fld_txtBRBranchContactCellPhone.BOSFieldGroup = "";
            this.fld_txtBRBranchContactCellPhone.BOSFieldRelation = "";
            this.fld_txtBRBranchContactCellPhone.BOSPrivilege = "";
            this.fld_txtBRBranchContactCellPhone.BOSPropertyName = "Text";
            this.fld_txtBRBranchContactCellPhone.Location = new System.Drawing.Point(342, 75);
            this.fld_txtBRBranchContactCellPhone.Name = "fld_txtBRBranchContactCellPhone";
            this.fld_txtBRBranchContactCellPhone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtBRBranchContactCellPhone.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtBRBranchContactCellPhone.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtBRBranchContactCellPhone.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtBRBranchContactCellPhone.Properties.Mask.EditMask = "\\d+";
            this.fld_txtBRBranchContactCellPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.fld_txtBRBranchContactCellPhone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtBRBranchContactCellPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtBRBranchContactCellPhone.Screen = null;
            this.fld_txtBRBranchContactCellPhone.Size = new System.Drawing.Size(150, 20);
            this.fld_txtBRBranchContactCellPhone.TabIndex = 4;
            this.fld_txtBRBranchContactCellPhone.Tag = "DC";
            // 
            // fld_txtBRBranchContactEmail1
            // 
            this.fld_txtBRBranchContactEmail1.BOSComment = "";
            this.fld_txtBRBranchContactEmail1.BOSDataMember = "BRBranchContactEmail1";
            this.fld_txtBRBranchContactEmail1.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchContactEmail1.BOSDescription = null;
            this.fld_txtBRBranchContactEmail1.BOSError = "";
            this.fld_txtBRBranchContactEmail1.BOSFieldGroup = "";
            this.fld_txtBRBranchContactEmail1.BOSFieldRelation = "";
            this.fld_txtBRBranchContactEmail1.BOSPrivilege = "";
            this.fld_txtBRBranchContactEmail1.BOSPropertyName = "Text";
            this.fld_txtBRBranchContactEmail1.Location = new System.Drawing.Point(88, 100);
            this.fld_txtBRBranchContactEmail1.Name = "fld_txtBRBranchContactEmail1";
            this.fld_txtBRBranchContactEmail1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtBRBranchContactEmail1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtBRBranchContactEmail1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtBRBranchContactEmail1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtBRBranchContactEmail1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtBRBranchContactEmail1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtBRBranchContactEmail1.Screen = null;
            this.fld_txtBRBranchContactEmail1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtBRBranchContactEmail1.TabIndex = 5;
            this.fld_txtBRBranchContactEmail1.Tag = "DC";
            // 
            // fld_txtBRBranchContactDepartment
            // 
            this.fld_txtBRBranchContactDepartment.BOSComment = "";
            this.fld_txtBRBranchContactDepartment.BOSDataMember = "BRBranchContactDepartment";
            this.fld_txtBRBranchContactDepartment.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchContactDepartment.BOSDescription = null;
            this.fld_txtBRBranchContactDepartment.BOSError = "";
            this.fld_txtBRBranchContactDepartment.BOSFieldGroup = "";
            this.fld_txtBRBranchContactDepartment.BOSFieldRelation = "";
            this.fld_txtBRBranchContactDepartment.BOSPrivilege = "";
            this.fld_txtBRBranchContactDepartment.BOSPropertyName = "Text";
            this.fld_txtBRBranchContactDepartment.Location = new System.Drawing.Point(88, 125);
            this.fld_txtBRBranchContactDepartment.Name = "fld_txtBRBranchContactDepartment";
            this.fld_txtBRBranchContactDepartment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtBRBranchContactDepartment.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtBRBranchContactDepartment.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtBRBranchContactDepartment.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtBRBranchContactDepartment.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtBRBranchContactDepartment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtBRBranchContactDepartment.Screen = null;
            this.fld_txtBRBranchContactDepartment.Size = new System.Drawing.Size(150, 20);
            this.fld_txtBRBranchContactDepartment.TabIndex = 7;
            this.fld_txtBRBranchContactDepartment.Tag = "DC";
            // 
            // fld_txtBRBranchContactRoom
            // 
            this.fld_txtBRBranchContactRoom.BOSComment = "";
            this.fld_txtBRBranchContactRoom.BOSDataMember = "BRBranchContactRoom";
            this.fld_txtBRBranchContactRoom.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchContactRoom.BOSDescription = null;
            this.fld_txtBRBranchContactRoom.BOSError = "";
            this.fld_txtBRBranchContactRoom.BOSFieldGroup = "";
            this.fld_txtBRBranchContactRoom.BOSFieldRelation = "";
            this.fld_txtBRBranchContactRoom.BOSPrivilege = "";
            this.fld_txtBRBranchContactRoom.BOSPropertyName = "Text";
            this.fld_txtBRBranchContactRoom.Location = new System.Drawing.Point(342, 124);
            this.fld_txtBRBranchContactRoom.Name = "fld_txtBRBranchContactRoom";
            this.fld_txtBRBranchContactRoom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtBRBranchContactRoom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtBRBranchContactRoom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtBRBranchContactRoom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtBRBranchContactRoom.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtBRBranchContactRoom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtBRBranchContactRoom.Screen = null;
            this.fld_txtBRBranchContactRoom.Size = new System.Drawing.Size(150, 20);
            this.fld_txtBRBranchContactRoom.TabIndex = 8;
            this.fld_txtBRBranchContactRoom.Tag = "DC";
            // 
            // fld_medBRBranchDesc
            // 
            this.fld_medBRBranchDesc.BOSComment = "";
            this.fld_medBRBranchDesc.BOSDataMember = "BRBranchDesc";
            this.fld_medBRBranchDesc.BOSDataSource = "BRBranchs";
            this.fld_medBRBranchDesc.BOSDescription = null;
            this.fld_medBRBranchDesc.BOSError = "";
            this.fld_medBRBranchDesc.BOSFieldGroup = "";
            this.fld_medBRBranchDesc.BOSFieldRelation = "";
            this.fld_medBRBranchDesc.BOSPrivilege = "";
            this.fld_medBRBranchDesc.BOSPropertyName = "Text";
            this.fld_medBRBranchDesc.Location = new System.Drawing.Point(104, 106);
            this.fld_medBRBranchDesc.Name = "fld_medBRBranchDesc";
            this.fld_medBRBranchDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medBRBranchDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medBRBranchDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medBRBranchDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medBRBranchDesc.Screen = null;
            this.fld_medBRBranchDesc.Size = new System.Drawing.Size(372, 35);
            this.fld_medBRBranchDesc.TabIndex = 4;
            this.fld_medBRBranchDesc.Tag = "DC";
            // 
            // fld_chkBRBranchActiveCheck
            // 
            this.fld_chkBRBranchActiveCheck.BOSComment = "";
            this.fld_chkBRBranchActiveCheck.BOSDataMember = "BRBranchActiveCheck";
            this.fld_chkBRBranchActiveCheck.BOSDataSource = "BRBranchs";
            this.fld_chkBRBranchActiveCheck.BOSDescription = null;
            this.fld_chkBRBranchActiveCheck.BOSError = "";
            this.fld_chkBRBranchActiveCheck.BOSFieldGroup = "";
            this.fld_chkBRBranchActiveCheck.BOSFieldRelation = "";
            this.fld_chkBRBranchActiveCheck.BOSPrivilege = "";
            this.fld_chkBRBranchActiveCheck.BOSPropertyName = "EditValue";
            this.fld_chkBRBranchActiveCheck.Location = new System.Drawing.Point(102, 277);
            this.fld_chkBRBranchActiveCheck.Name = "fld_chkBRBranchActiveCheck";
            this.fld_chkBRBranchActiveCheck.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkBRBranchActiveCheck.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkBRBranchActiveCheck.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkBRBranchActiveCheck.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkBRBranchActiveCheck.Properties.Caption = "Hoạt động";
            this.fld_chkBRBranchActiveCheck.Screen = null;
            this.fld_chkBRBranchActiveCheck.Size = new System.Drawing.Size(75, 19);
            this.fld_chkBRBranchActiveCheck.TabIndex = 13;
            this.fld_chkBRBranchActiveCheck.Tag = "DC";
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
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeBRBranchParentID);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeBRBranchType);
            this.fld_grcGroupControl.Controls.Add(this.fld_bedGELocationName);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel12);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel14);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel14);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel13);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel7);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel18);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtBRBranchCompanyName);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtBRBranchName);
            this.fld_grcGroupControl.Controls.Add(this.fld_medBRBranchDesc);
            this.fld_grcGroupControl.Controls.Add(this.fld_chkBRBranchActiveCheck);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtBRBranchNo1);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel11);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel12);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel10);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel9);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel8);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel8);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtBRBranchContactAddressPostalCode);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtBRBranchContactAddressCountry);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtBRBranchContactAddressStateProvince);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtBRBranchContactAddressCity);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtBRBranchContactAddressLine1);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(954, 304);
            this.fld_grcGroupControl.TabIndex = 1;
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // fld_lkeBRBranchParentID
            // 
            this.fld_lkeBRBranchParentID.BOSAllowAddNew = false;
            this.fld_lkeBRBranchParentID.BOSAllowDummy = true;
            this.fld_lkeBRBranchParentID.BOSComment = null;
            this.fld_lkeBRBranchParentID.BOSDataMember = "BRBranchParentID";
            this.fld_lkeBRBranchParentID.BOSDataSource = "BRBranchs";
            this.fld_lkeBRBranchParentID.BOSDescription = null;
            this.fld_lkeBRBranchParentID.BOSError = null;
            this.fld_lkeBRBranchParentID.BOSFieldGroup = null;
            this.fld_lkeBRBranchParentID.BOSFieldParent = null;
            this.fld_lkeBRBranchParentID.BOSFieldRelation = null;
            this.fld_lkeBRBranchParentID.BOSPrivilege = null;
            this.fld_lkeBRBranchParentID.BOSPropertyName = "EditValue";
            this.fld_lkeBRBranchParentID.BOSSelectType = null;
            this.fld_lkeBRBranchParentID.BOSSelectTypeValue = null;
            this.fld_lkeBRBranchParentID.CurrentDisplayText = null;
            this.fld_lkeBRBranchParentID.Location = new System.Drawing.Point(326, 147);
            this.fld_lkeBRBranchParentID.Name = "fld_lkeBRBranchParentID";
            this.fld_lkeBRBranchParentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBRBranchParentID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBRBranchParentID.Properties.NullText = "";
            this.fld_lkeBRBranchParentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeBRBranchParentID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchParentID.Screen = null;
            this.fld_lkeBRBranchParentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchParentID.TabIndex = 6;
            this.fld_lkeBRBranchParentID.Tag = "DC";
            // 
            // fld_lkeBRBranchType
            // 
            this.fld_lkeBRBranchType.BOSAllowAddNew = false;
            this.fld_lkeBRBranchType.BOSAllowDummy = false;
            this.fld_lkeBRBranchType.BOSComment = null;
            this.fld_lkeBRBranchType.BOSDataMember = "BRBranchType";
            this.fld_lkeBRBranchType.BOSDataSource = "BRBranchs";
            this.fld_lkeBRBranchType.BOSDescription = null;
            this.fld_lkeBRBranchType.BOSError = null;
            this.fld_lkeBRBranchType.BOSFieldGroup = null;
            this.fld_lkeBRBranchType.BOSFieldParent = null;
            this.fld_lkeBRBranchType.BOSFieldRelation = null;
            this.fld_lkeBRBranchType.BOSPrivilege = null;
            this.fld_lkeBRBranchType.BOSPropertyName = "EditValue";
            this.fld_lkeBRBranchType.BOSSelectType = null;
            this.fld_lkeBRBranchType.BOSSelectTypeValue = null;
            this.fld_lkeBRBranchType.CurrentDisplayText = null;
            this.fld_lkeBRBranchType.Location = new System.Drawing.Point(104, 147);
            this.fld_lkeBRBranchType.MenuManager = this.screenToolbar;
            this.fld_lkeBRBranchType.Name = "fld_lkeBRBranchType";
            this.fld_lkeBRBranchType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBRBranchType.Properties.NullText = "";
            this.fld_lkeBRBranchType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeBRBranchType.Screen = null;
            this.fld_lkeBRBranchType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchType.TabIndex = 5;
            this.fld_lkeBRBranchType.Tag = "DC";
            // 
            // fld_bedGELocationName
            // 
            this.fld_bedGELocationName.BOSComment = null;
            this.fld_bedGELocationName.BOSDataMember = "GELocationName";
            this.fld_bedGELocationName.BOSDataSource = "BRBranchs";
            this.fld_bedGELocationName.BOSDescription = null;
            this.fld_bedGELocationName.BOSError = null;
            this.fld_bedGELocationName.BOSFieldGroup = null;
            this.fld_bedGELocationName.BOSFieldRelation = null;
            this.fld_bedGELocationName.BOSPrivilege = null;
            this.fld_bedGELocationName.BOSPropertyName = "Text";
            this.fld_bedGELocationName.Location = new System.Drawing.Point(104, 251);
            this.fld_bedGELocationName.MenuManager = this.screenToolbar;
            this.fld_bedGELocationName.Name = "fld_bedGELocationName";
            this.fld_bedGELocationName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedGELocationName.Properties.ReadOnly = true;
            this.fld_bedGELocationName.Screen = null;
            this.fld_bedGELocationName.Size = new System.Drawing.Size(372, 20);
            this.fld_bedGELocationName.TabIndex = 12;
            this.fld_bedGELocationName.Tag = "DC";
            this.fld_bedGELocationName.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedGELocationName_ButtonClick);
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
            this.bosLabel14.Location = new System.Drawing.Point(16, 85);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(57, 13);
            this.bosLabel14.TabIndex = 6;
            this.bosLabel14.Tag = "";
            this.bosLabel14.Text = "Tên công ty";
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
            this.bosLabel13.Location = new System.Drawing.Point(274, 150);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(41, 13);
            this.bosLabel13.TabIndex = 14;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "TT vùng";
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
            this.bosLabel7.Location = new System.Drawing.Point(17, 150);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(20, 13);
            this.bosLabel7.TabIndex = 14;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Loại";
            // 
            // fld_txtBRBranchCompanyName
            // 
            this.fld_txtBRBranchCompanyName.BOSComment = "";
            this.fld_txtBRBranchCompanyName.BOSDataMember = "BRBranchCompanyName";
            this.fld_txtBRBranchCompanyName.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchCompanyName.BOSDescription = null;
            this.fld_txtBRBranchCompanyName.BOSError = "";
            this.fld_txtBRBranchCompanyName.BOSFieldGroup = "";
            this.fld_txtBRBranchCompanyName.BOSFieldRelation = "";
            this.fld_txtBRBranchCompanyName.BOSPrivilege = "";
            this.fld_txtBRBranchCompanyName.BOSPropertyName = "Text";
            this.fld_txtBRBranchCompanyName.Location = new System.Drawing.Point(104, 82);
            this.fld_txtBRBranchCompanyName.Name = "fld_txtBRBranchCompanyName";
            this.fld_txtBRBranchCompanyName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtBRBranchCompanyName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtBRBranchCompanyName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtBRBranchCompanyName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtBRBranchCompanyName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtBRBranchCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtBRBranchCompanyName.Screen = null;
            this.fld_txtBRBranchCompanyName.Size = new System.Drawing.Size(372, 20);
            this.fld_txtBRBranchCompanyName.TabIndex = 3;
            this.fld_txtBRBranchCompanyName.Tag = "DC";
            // 
            // fld_txtBRBranchNo1
            // 
            this.fld_txtBRBranchNo1.BOSComment = "";
            this.fld_txtBRBranchNo1.BOSDataMember = "BRBranchNo";
            this.fld_txtBRBranchNo1.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchNo1.BOSDescription = null;
            this.fld_txtBRBranchNo1.BOSError = "";
            this.fld_txtBRBranchNo1.BOSFieldGroup = "";
            this.fld_txtBRBranchNo1.BOSFieldRelation = "";
            this.fld_txtBRBranchNo1.BOSPrivilege = "";
            this.fld_txtBRBranchNo1.BOSPropertyName = "Text";
            this.fld_txtBRBranchNo1.Location = new System.Drawing.Point(104, 33);
            this.fld_txtBRBranchNo1.Name = "fld_txtBRBranchNo1";
            this.fld_txtBRBranchNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtBRBranchNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtBRBranchNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtBRBranchNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtBRBranchNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtBRBranchNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtBRBranchNo1.Screen = null;
            this.fld_txtBRBranchNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtBRBranchNo1.TabIndex = 1;
            this.fld_txtBRBranchNo1.Tag = "DC";
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
            this.bosLabel11.Location = new System.Drawing.Point(273, 228);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(42, 13);
            this.bosLabel11.TabIndex = 195;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Mã vùng";
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
            this.bosLabel12.Location = new System.Drawing.Point(17, 254);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(22, 13);
            this.bosLabel12.TabIndex = 195;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "Vị trí";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseFont = true;
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
            this.bosLabel10.Location = new System.Drawing.Point(17, 228);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(43, 13);
            this.bosLabel10.TabIndex = 195;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Quốc gia";
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
            this.bosLabel9.Location = new System.Drawing.Point(273, 202);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(21, 13);
            this.bosLabel9.TabIndex = 195;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Tỉnh";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseFont = true;
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
            this.bosLabel8.Location = new System.Drawing.Point(16, 202);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(52, 13);
            this.bosLabel8.TabIndex = 195;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Thành phố";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseFont = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = "";
            this.fld_lblLabel8.BOSDataMember = "";
            this.fld_lblLabel8.BOSDataSource = "";
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = "";
            this.fld_lblLabel8.BOSFieldRelation = "";
            this.fld_lblLabel8.BOSPrivilege = "";
            this.fld_lblLabel8.BOSPropertyName = null;
            this.fld_lblLabel8.Location = new System.Drawing.Point(17, 176);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(33, 13);
            this.fld_lblLabel8.TabIndex = 195;
            this.fld_lblLabel8.Tag = "";
            this.fld_lblLabel8.Text = "Địa chỉ";
            // 
            // fld_txtBRBranchContactAddressPostalCode
            // 
            this.fld_txtBRBranchContactAddressPostalCode.BOSComment = "";
            this.fld_txtBRBranchContactAddressPostalCode.BOSDataMember = "BRBranchContactAddressPostalCode";
            this.fld_txtBRBranchContactAddressPostalCode.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchContactAddressPostalCode.BOSDescription = null;
            this.fld_txtBRBranchContactAddressPostalCode.BOSError = "";
            this.fld_txtBRBranchContactAddressPostalCode.BOSFieldGroup = "";
            this.fld_txtBRBranchContactAddressPostalCode.BOSFieldRelation = "";
            this.fld_txtBRBranchContactAddressPostalCode.BOSPrivilege = "";
            this.fld_txtBRBranchContactAddressPostalCode.BOSPropertyName = "Text";
            this.fld_txtBRBranchContactAddressPostalCode.Location = new System.Drawing.Point(326, 225);
            this.fld_txtBRBranchContactAddressPostalCode.Name = "fld_txtBRBranchContactAddressPostalCode";
            this.fld_txtBRBranchContactAddressPostalCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtBRBranchContactAddressPostalCode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtBRBranchContactAddressPostalCode.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtBRBranchContactAddressPostalCode.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtBRBranchContactAddressPostalCode.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtBRBranchContactAddressPostalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtBRBranchContactAddressPostalCode.Screen = null;
            this.fld_txtBRBranchContactAddressPostalCode.Size = new System.Drawing.Size(150, 20);
            this.fld_txtBRBranchContactAddressPostalCode.TabIndex = 11;
            this.fld_txtBRBranchContactAddressPostalCode.Tag = "DC";
            // 
            // fld_txtBRBranchContactAddressCountry
            // 
            this.fld_txtBRBranchContactAddressCountry.BOSComment = "";
            this.fld_txtBRBranchContactAddressCountry.BOSDataMember = "BRBranchContactAddressCountry";
            this.fld_txtBRBranchContactAddressCountry.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchContactAddressCountry.BOSDescription = null;
            this.fld_txtBRBranchContactAddressCountry.BOSError = "";
            this.fld_txtBRBranchContactAddressCountry.BOSFieldGroup = "";
            this.fld_txtBRBranchContactAddressCountry.BOSFieldRelation = "";
            this.fld_txtBRBranchContactAddressCountry.BOSPrivilege = "";
            this.fld_txtBRBranchContactAddressCountry.BOSPropertyName = "Text";
            this.fld_txtBRBranchContactAddressCountry.Location = new System.Drawing.Point(104, 225);
            this.fld_txtBRBranchContactAddressCountry.Name = "fld_txtBRBranchContactAddressCountry";
            this.fld_txtBRBranchContactAddressCountry.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtBRBranchContactAddressCountry.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtBRBranchContactAddressCountry.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtBRBranchContactAddressCountry.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtBRBranchContactAddressCountry.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtBRBranchContactAddressCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtBRBranchContactAddressCountry.Screen = null;
            this.fld_txtBRBranchContactAddressCountry.Size = new System.Drawing.Size(150, 20);
            this.fld_txtBRBranchContactAddressCountry.TabIndex = 10;
            this.fld_txtBRBranchContactAddressCountry.Tag = "DC";
            // 
            // fld_txtBRBranchContactAddressStateProvince
            // 
            this.fld_txtBRBranchContactAddressStateProvince.BOSComment = "";
            this.fld_txtBRBranchContactAddressStateProvince.BOSDataMember = "BRBranchContactAddressStateProvince";
            this.fld_txtBRBranchContactAddressStateProvince.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchContactAddressStateProvince.BOSDescription = null;
            this.fld_txtBRBranchContactAddressStateProvince.BOSError = "";
            this.fld_txtBRBranchContactAddressStateProvince.BOSFieldGroup = "";
            this.fld_txtBRBranchContactAddressStateProvince.BOSFieldRelation = "";
            this.fld_txtBRBranchContactAddressStateProvince.BOSPrivilege = "";
            this.fld_txtBRBranchContactAddressStateProvince.BOSPropertyName = "Text";
            this.fld_txtBRBranchContactAddressStateProvince.Location = new System.Drawing.Point(326, 199);
            this.fld_txtBRBranchContactAddressStateProvince.Name = "fld_txtBRBranchContactAddressStateProvince";
            this.fld_txtBRBranchContactAddressStateProvince.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtBRBranchContactAddressStateProvince.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtBRBranchContactAddressStateProvince.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtBRBranchContactAddressStateProvince.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtBRBranchContactAddressStateProvince.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtBRBranchContactAddressStateProvince.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtBRBranchContactAddressStateProvince.Screen = null;
            this.fld_txtBRBranchContactAddressStateProvince.Size = new System.Drawing.Size(150, 20);
            this.fld_txtBRBranchContactAddressStateProvince.TabIndex = 9;
            this.fld_txtBRBranchContactAddressStateProvince.Tag = "DC";
            // 
            // fld_txtBRBranchContactAddressCity
            // 
            this.fld_txtBRBranchContactAddressCity.BOSComment = "";
            this.fld_txtBRBranchContactAddressCity.BOSDataMember = "BRBranchContactAddressCity";
            this.fld_txtBRBranchContactAddressCity.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchContactAddressCity.BOSDescription = null;
            this.fld_txtBRBranchContactAddressCity.BOSError = "";
            this.fld_txtBRBranchContactAddressCity.BOSFieldGroup = "";
            this.fld_txtBRBranchContactAddressCity.BOSFieldRelation = "";
            this.fld_txtBRBranchContactAddressCity.BOSPrivilege = "";
            this.fld_txtBRBranchContactAddressCity.BOSPropertyName = "Text";
            this.fld_txtBRBranchContactAddressCity.Location = new System.Drawing.Point(104, 199);
            this.fld_txtBRBranchContactAddressCity.Name = "fld_txtBRBranchContactAddressCity";
            this.fld_txtBRBranchContactAddressCity.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtBRBranchContactAddressCity.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtBRBranchContactAddressCity.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtBRBranchContactAddressCity.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtBRBranchContactAddressCity.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtBRBranchContactAddressCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtBRBranchContactAddressCity.Screen = null;
            this.fld_txtBRBranchContactAddressCity.Size = new System.Drawing.Size(150, 20);
            this.fld_txtBRBranchContactAddressCity.TabIndex = 8;
            this.fld_txtBRBranchContactAddressCity.Tag = "DC";
            // 
            // fld_txtBRBranchContactAddressLine1
            // 
            this.fld_txtBRBranchContactAddressLine1.BOSComment = "";
            this.fld_txtBRBranchContactAddressLine1.BOSDataMember = "BRBranchContactAddressLine1";
            this.fld_txtBRBranchContactAddressLine1.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchContactAddressLine1.BOSDescription = null;
            this.fld_txtBRBranchContactAddressLine1.BOSError = "";
            this.fld_txtBRBranchContactAddressLine1.BOSFieldGroup = "";
            this.fld_txtBRBranchContactAddressLine1.BOSFieldRelation = "";
            this.fld_txtBRBranchContactAddressLine1.BOSPrivilege = "";
            this.fld_txtBRBranchContactAddressLine1.BOSPropertyName = "Text";
            this.fld_txtBRBranchContactAddressLine1.Location = new System.Drawing.Point(104, 173);
            this.fld_txtBRBranchContactAddressLine1.Name = "fld_txtBRBranchContactAddressLine1";
            this.fld_txtBRBranchContactAddressLine1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtBRBranchContactAddressLine1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtBRBranchContactAddressLine1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtBRBranchContactAddressLine1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtBRBranchContactAddressLine1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtBRBranchContactAddressLine1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtBRBranchContactAddressLine1.Screen = null;
            this.fld_txtBRBranchContactAddressLine1.Size = new System.Drawing.Size(372, 20);
            this.fld_txtBRBranchContactAddressLine1.TabIndex = 7;
            this.fld_txtBRBranchContactAddressLine1.Tag = "DC";
            // 
            // fld_grcGroupControl3
            // 
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
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel27);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel30);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel32);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel38);
            this.fld_grcGroupControl3.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel41);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel42);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel45);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtBRBranchContactTitle);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtBRBranchContactFirstName);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtBRBranchContactPhone);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtBRBranchContactFax);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtBRBranchContactCellPhone);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtBRBranchContactEmail1);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtBRBranchContactDepartment);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtBRBranchContactRoom);
            this.fld_grcGroupControl3.Location = new System.Drawing.Point(5, 310);
            this.fld_grcGroupControl3.Name = "fld_grcGroupControl3";
            this.fld_grcGroupControl3.Screen = null;
            this.fld_grcGroupControl3.Size = new System.Drawing.Size(508, 161);
            this.fld_grcGroupControl3.TabIndex = 2;
            this.fld_grcGroupControl3.Text = "Người liên hệ";
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
            this.bosLabel1.Location = new System.Drawing.Point(259, 103);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(30, 13);
            this.bosLabel1.TabIndex = 65;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Số fax";
            // 
            // fld_txtBRBranchContactFax
            // 
            this.fld_txtBRBranchContactFax.BOSComment = "";
            this.fld_txtBRBranchContactFax.BOSDataMember = "BRBranchContactFax";
            this.fld_txtBRBranchContactFax.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchContactFax.BOSDescription = null;
            this.fld_txtBRBranchContactFax.BOSError = "";
            this.fld_txtBRBranchContactFax.BOSFieldGroup = "";
            this.fld_txtBRBranchContactFax.BOSFieldRelation = "";
            this.fld_txtBRBranchContactFax.BOSPrivilege = "";
            this.fld_txtBRBranchContactFax.BOSPropertyName = "Text";
            this.fld_txtBRBranchContactFax.Location = new System.Drawing.Point(342, 99);
            this.fld_txtBRBranchContactFax.Name = "fld_txtBRBranchContactFax";
            this.fld_txtBRBranchContactFax.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtBRBranchContactFax.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtBRBranchContactFax.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtBRBranchContactFax.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtBRBranchContactFax.Properties.Mask.EditMask = "\\d+";
            this.fld_txtBRBranchContactFax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.fld_txtBRBranchContactFax.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtBRBranchContactFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtBRBranchContactFax.Screen = null;
            this.fld_txtBRBranchContactFax.Size = new System.Drawing.Size(150, 20);
            this.fld_txtBRBranchContactFax.TabIndex = 6;
            this.fld_txtBRBranchContactFax.Tag = "DC";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_txtBRBranchDatabasePassword);
            this.bosGroupControl1.Controls.Add(this.fld_txtBRBranchDatabaseUser);
            this.bosGroupControl1.Controls.Add(this.fld_txtBRBranchDatabase);
            this.bosGroupControl1.Controls.Add(this.fld_txtBRBranchServerAliasName);
            this.bosGroupControl1.Controls.Add(this.fld_txtBRBranchServerName);
            this.bosGroupControl1.Controls.Add(this.bosLabel5);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.bosLabel6);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Location = new System.Drawing.Point(519, 310);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(437, 246);
            this.bosGroupControl1.TabIndex = 3;
            this.bosGroupControl1.Text = "Thông tin kết nối";
            // 
            // fld_txtBRBranchDatabasePassword
            // 
            this.fld_txtBRBranchDatabasePassword.BOSComment = null;
            this.fld_txtBRBranchDatabasePassword.BOSDataMember = "BRBranchDatabasePassword";
            this.fld_txtBRBranchDatabasePassword.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchDatabasePassword.BOSDescription = null;
            this.fld_txtBRBranchDatabasePassword.BOSError = null;
            this.fld_txtBRBranchDatabasePassword.BOSFieldGroup = null;
            this.fld_txtBRBranchDatabasePassword.BOSFieldRelation = null;
            this.fld_txtBRBranchDatabasePassword.BOSPrivilege = null;
            this.fld_txtBRBranchDatabasePassword.BOSPropertyName = "Text";
            this.fld_txtBRBranchDatabasePassword.Location = new System.Drawing.Point(104, 133);
            this.fld_txtBRBranchDatabasePassword.Name = "fld_txtBRBranchDatabasePassword";
            this.fld_txtBRBranchDatabasePassword.Properties.PasswordChar = '*';
            this.fld_txtBRBranchDatabasePassword.Screen = null;
            this.fld_txtBRBranchDatabasePassword.Size = new System.Drawing.Size(150, 20);
            this.fld_txtBRBranchDatabasePassword.TabIndex = 5;
            this.fld_txtBRBranchDatabasePassword.Tag = "DC";
            // 
            // fld_txtBRBranchDatabaseUser
            // 
            this.fld_txtBRBranchDatabaseUser.BOSComment = null;
            this.fld_txtBRBranchDatabaseUser.BOSDataMember = "BRBranchDatabaseUser";
            this.fld_txtBRBranchDatabaseUser.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchDatabaseUser.BOSDescription = null;
            this.fld_txtBRBranchDatabaseUser.BOSError = null;
            this.fld_txtBRBranchDatabaseUser.BOSFieldGroup = null;
            this.fld_txtBRBranchDatabaseUser.BOSFieldRelation = null;
            this.fld_txtBRBranchDatabaseUser.BOSPrivilege = null;
            this.fld_txtBRBranchDatabaseUser.BOSPropertyName = "Text";
            this.fld_txtBRBranchDatabaseUser.Location = new System.Drawing.Point(104, 107);
            this.fld_txtBRBranchDatabaseUser.Name = "fld_txtBRBranchDatabaseUser";
            this.fld_txtBRBranchDatabaseUser.Screen = null;
            this.fld_txtBRBranchDatabaseUser.Size = new System.Drawing.Size(150, 20);
            this.fld_txtBRBranchDatabaseUser.TabIndex = 4;
            this.fld_txtBRBranchDatabaseUser.Tag = "DC";
            // 
            // fld_txtBRBranchDatabase
            // 
            this.fld_txtBRBranchDatabase.BOSComment = null;
            this.fld_txtBRBranchDatabase.BOSDataMember = "BRBranchDatabase";
            this.fld_txtBRBranchDatabase.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchDatabase.BOSDescription = null;
            this.fld_txtBRBranchDatabase.BOSError = null;
            this.fld_txtBRBranchDatabase.BOSFieldGroup = null;
            this.fld_txtBRBranchDatabase.BOSFieldRelation = null;
            this.fld_txtBRBranchDatabase.BOSPrivilege = null;
            this.fld_txtBRBranchDatabase.BOSPropertyName = "Text";
            this.fld_txtBRBranchDatabase.Location = new System.Drawing.Point(104, 81);
            this.fld_txtBRBranchDatabase.Name = "fld_txtBRBranchDatabase";
            this.fld_txtBRBranchDatabase.Screen = null;
            this.fld_txtBRBranchDatabase.Size = new System.Drawing.Size(150, 20);
            this.fld_txtBRBranchDatabase.TabIndex = 3;
            this.fld_txtBRBranchDatabase.Tag = "DC";
            // 
            // fld_txtBRBranchServerAliasName
            // 
            this.fld_txtBRBranchServerAliasName.BOSComment = null;
            this.fld_txtBRBranchServerAliasName.BOSDataMember = "BRBranchServerAliasName";
            this.fld_txtBRBranchServerAliasName.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchServerAliasName.BOSDescription = null;
            this.fld_txtBRBranchServerAliasName.BOSError = null;
            this.fld_txtBRBranchServerAliasName.BOSFieldGroup = null;
            this.fld_txtBRBranchServerAliasName.BOSFieldRelation = null;
            this.fld_txtBRBranchServerAliasName.BOSPrivilege = null;
            this.fld_txtBRBranchServerAliasName.BOSPropertyName = "Text";
            this.fld_txtBRBranchServerAliasName.Location = new System.Drawing.Point(104, 55);
            this.fld_txtBRBranchServerAliasName.Name = "fld_txtBRBranchServerAliasName";
            this.fld_txtBRBranchServerAliasName.Screen = null;
            this.fld_txtBRBranchServerAliasName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtBRBranchServerAliasName.TabIndex = 2;
            this.fld_txtBRBranchServerAliasName.Tag = "DC";
            // 
            // fld_txtBRBranchServerName
            // 
            this.fld_txtBRBranchServerName.BOSComment = null;
            this.fld_txtBRBranchServerName.BOSDataMember = "BRBranchServerName";
            this.fld_txtBRBranchServerName.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchServerName.BOSDescription = null;
            this.fld_txtBRBranchServerName.BOSError = null;
            this.fld_txtBRBranchServerName.BOSFieldGroup = null;
            this.fld_txtBRBranchServerName.BOSFieldRelation = null;
            this.fld_txtBRBranchServerName.BOSPrivilege = null;
            this.fld_txtBRBranchServerName.BOSPropertyName = "Text";
            this.fld_txtBRBranchServerName.Location = new System.Drawing.Point(104, 29);
            this.fld_txtBRBranchServerName.MenuManager = this.screenToolbar;
            this.fld_txtBRBranchServerName.Name = "fld_txtBRBranchServerName";
            this.fld_txtBRBranchServerName.Screen = null;
            this.fld_txtBRBranchServerName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtBRBranchServerName.TabIndex = 1;
            this.fld_txtBRBranchServerName.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(23, 136);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(44, 13);
            this.bosLabel5.TabIndex = 0;
            this.bosLabel5.Text = "Mật khẩu";
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(23, 110);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(55, 13);
            this.bosLabel4.TabIndex = 0;
            this.bosLabel4.Text = "Người dùng";
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(23, 84);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(25, 13);
            this.bosLabel3.TabIndex = 0;
            this.bosLabel3.Text = "CSDL";
            // 
            // bosLabel6
            // 
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(23, 57);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(42, 13);
            this.bosLabel6.TabIndex = 0;
            this.bosLabel6.Text = "Tên alias";
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(23, 32);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(52, 13);
            this.bosLabel2.TabIndex = 0;
            this.bosLabel2.Text = "Tên server";
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.bosTextBox5);
            this.bosGroupControl2.Controls.Add(this.bosLabel19);
            this.bosGroupControl2.Location = new System.Drawing.Point(5, 477);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(508, 79);
            this.bosGroupControl2.TabIndex = 3;
            this.bosGroupControl2.Text = "Trung tân bảo hành";
            // 
            // bosTextBox5
            // 
            this.bosTextBox5.BOSComment = null;
            this.bosTextBox5.BOSDataMember = "BRBranchWarrantyPhone";
            this.bosTextBox5.BOSDataSource = "BRBranchs";
            this.bosTextBox5.BOSDescription = null;
            this.bosTextBox5.BOSError = null;
            this.bosTextBox5.BOSFieldGroup = null;
            this.bosTextBox5.BOSFieldRelation = null;
            this.bosTextBox5.BOSPrivilege = null;
            this.bosTextBox5.BOSPropertyName = "Text";
            this.bosTextBox5.Location = new System.Drawing.Point(88, 26);
            this.bosTextBox5.Name = "bosTextBox5";
            this.bosTextBox5.Screen = null;
            this.bosTextBox5.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox5.TabIndex = 1;
            this.bosTextBox5.Tag = "DC";
            // 
            // bosLabel19
            // 
            this.bosLabel19.BOSComment = null;
            this.bosLabel19.BOSDataMember = null;
            this.bosLabel19.BOSDataSource = null;
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = null;
            this.bosLabel19.BOSFieldRelation = null;
            this.bosLabel19.BOSPrivilege = null;
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(12, 29);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(62, 13);
            this.bosLabel19.TabIndex = 0;
            this.bosLabel19.Text = "Số điện thoại";
            // 
            // DMBR100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(977, 568);
            this.Controls.Add(this.bosGroupControl2);
            this.Controls.Add(this.bosGroupControl1);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Controls.Add(this.fld_Line1);
            this.Controls.Add(this.fld_Line2);
            this.Controls.Add(this.fld_grcGroupControl3);
            this.Controls.Add(this.fld_Line3);
            this.Name = "DMBR100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.fld_Line3, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl3, 0);
            this.Controls.SetChildIndex(this.fld_Line2, 0);
            this.Controls.SetChildIndex(this.fld_Line1, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            this.Controls.SetChildIndex(this.bosGroupControl1, 0);
            this.Controls.SetChildIndex(this.bosGroupControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactCellPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactEmail1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactRoom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medBRBranchDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkBRBranchActiveCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchParentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedGELocationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchCompanyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactAddressPostalCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactAddressCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactAddressStateProvince.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactAddressCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactAddressLine1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).EndInit();
            this.fld_grcGroupControl3.ResumeLayout(false);
            this.fld_grcGroupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchDatabasePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchDatabaseUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchServerAliasName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchServerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.bosGroupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtBRBranchContactFax;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtBRBranchDatabasePassword;
        private BOSComponent.BOSTextBox fld_txtBRBranchDatabaseUser;
        private BOSComponent.BOSTextBox fld_txtBRBranchDatabase;
        private BOSComponent.BOSTextBox fld_txtBRBranchServerName;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtBRBranchServerAliasName;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSButtonEdit fld_bedGELocationName;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchType;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSTextBox fld_txtBRBranchContactAddressPostalCode;
        private BOSComponent.BOSTextBox fld_txtBRBranchContactAddressCountry;
        private BOSComponent.BOSTextBox fld_txtBRBranchContactAddressStateProvince;
        private BOSComponent.BOSTextBox fld_txtBRBranchContactAddressCity;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchParentID;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSTextBox fld_txtBRBranchCompanyName;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSTextBox bosTextBox5;
        private BOSComponent.BOSLabel bosLabel19;
	}
}
