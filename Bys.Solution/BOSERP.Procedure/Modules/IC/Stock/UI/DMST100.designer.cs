using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Stock.UI
{
	/// <summary>
	/// Summary description for DMST100
	/// </summary>
	partial class DMST100
    {
        private BOSComponent.BOSLine fld_Line1;
		private BOSComponent.BOSLine fld_Line2;
        private BOSComponent.BOSLine fld_Line3;


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
            this.fld_Line1 = new BOSComponent.BOSLine(this.components);
            this.fld_Line2 = new BOSComponent.BOSLine(this.components);
            this.fld_Line3 = new BOSComponent.BOSLine(this.components);
            this.fld_grcGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lblLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel30 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel32 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel38 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel41 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel42 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel43 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel45 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICStockContactTitle = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICStockContactFirstName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICStockContactPhone = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICStockContactFax = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICStockContactCellPhone = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICStockContactEmail1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICStockContactDepartment = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICStockContactRoom = new BOSComponent.BOSTextBox(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.bosCheckEdit1 = new BOSComponent.BOSCheckEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ACAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICStockContactAddressPostalCode = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICStockContactAddressStateProvince = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel37 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel46 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICStockName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICStockContactAddressCity = new BOSComponent.BOSTextBox(this.components);
            this.fld_medICStockDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_chkICStockActiveCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_txtICStockNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICStockContactAddressLine1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICStockType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel29 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICStockContactAddressCountry = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).BeginInit();
            this.fld_grcGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactCellPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactEmail1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactRoom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosCheckEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactAddressPostalCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactAddressStateProvince.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactAddressCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICStockDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICStockActiveCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactAddressLine1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICStockType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactAddressCountry.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel41);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel42);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel43);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel45);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtICStockContactTitle);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtICStockContactFirstName);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtICStockContactPhone);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtICStockContactFax);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtICStockContactCellPhone);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtICStockContactEmail1);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtICStockContactDepartment);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtICStockContactRoom);
            this.fld_grcGroupControl3.Location = new System.Drawing.Point(7, 292);
            this.fld_grcGroupControl3.Name = "fld_grcGroupControl3";
            this.fld_grcGroupControl3.Screen = null;
            this.fld_grcGroupControl3.Size = new System.Drawing.Size(555, 180);
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
            this.fld_lblLabel30.Location = new System.Drawing.Point(290, 78);
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
            this.fld_lblLabel32.Location = new System.Drawing.Point(26, 128);
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
            this.fld_lblLabel38.Location = new System.Drawing.Point(26, 28);
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
            this.fld_lblLabel41.Location = new System.Drawing.Point(26, 103);
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
            this.fld_lblLabel42.Location = new System.Drawing.Point(26, 78);
            this.fld_lblLabel42.Name = "fld_lblLabel42";
            this.fld_lblLabel42.Screen = null;
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
            this.fld_lblLabel43.Location = new System.Drawing.Point(290, 103);
            this.fld_lblLabel43.Name = "fld_lblLabel43";
            this.fld_lblLabel43.Screen = null;
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
            this.fld_lblLabel45.Location = new System.Drawing.Point(290, 128);
            this.fld_lblLabel45.Name = "fld_lblLabel45";
            this.fld_lblLabel45.Screen = null;
            this.fld_lblLabel45.Size = new System.Drawing.Size(52, 13);
            this.fld_lblLabel45.TabIndex = 69;
            this.fld_lblLabel45.Tag = "";
            this.fld_lblLabel45.Text = "Phòng ban";
            // 
            // fld_txtICStockContactTitle
            // 
            this.fld_txtICStockContactTitle.BOSComment = "";
            this.fld_txtICStockContactTitle.BOSDataMember = "ICStockContactTitle";
            this.fld_txtICStockContactTitle.BOSDataSource = "ICStocks";
            this.fld_txtICStockContactTitle.BOSDescription = null;
            this.fld_txtICStockContactTitle.BOSError = "";
            this.fld_txtICStockContactTitle.BOSFieldGroup = "";
            this.fld_txtICStockContactTitle.BOSFieldRelation = "";
            this.fld_txtICStockContactTitle.BOSPrivilege = "";
            this.fld_txtICStockContactTitle.BOSPropertyName = "Text";
            this.fld_txtICStockContactTitle.Location = new System.Drawing.Point(116, 25);
            this.fld_txtICStockContactTitle.Name = "fld_txtICStockContactTitle";
            this.fld_txtICStockContactTitle.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICStockContactTitle.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICStockContactTitle.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICStockContactTitle.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICStockContactTitle.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICStockContactTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICStockContactTitle.Screen = null;
            this.fld_txtICStockContactTitle.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICStockContactTitle.TabIndex = 11;
            this.fld_txtICStockContactTitle.Tag = "DC";
            // 
            // fld_txtICStockContactFirstName
            // 
            this.fld_txtICStockContactFirstName.BOSComment = "";
            this.fld_txtICStockContactFirstName.BOSDataMember = "ICStockContactFirstName";
            this.fld_txtICStockContactFirstName.BOSDataSource = "ICStocks";
            this.fld_txtICStockContactFirstName.BOSDescription = null;
            this.fld_txtICStockContactFirstName.BOSError = "";
            this.fld_txtICStockContactFirstName.BOSFieldGroup = "";
            this.fld_txtICStockContactFirstName.BOSFieldRelation = "";
            this.fld_txtICStockContactFirstName.BOSPrivilege = "";
            this.fld_txtICStockContactFirstName.BOSPropertyName = "Text";
            this.fld_txtICStockContactFirstName.Location = new System.Drawing.Point(116, 50);
            this.fld_txtICStockContactFirstName.Name = "fld_txtICStockContactFirstName";
            this.fld_txtICStockContactFirstName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICStockContactFirstName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICStockContactFirstName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICStockContactFirstName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICStockContactFirstName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICStockContactFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICStockContactFirstName.Screen = null;
            this.fld_txtICStockContactFirstName.Size = new System.Drawing.Size(399, 20);
            this.fld_txtICStockContactFirstName.TabIndex = 12;
            this.fld_txtICStockContactFirstName.Tag = "DC";
            // 
            // fld_txtICStockContactPhone
            // 
            this.fld_txtICStockContactPhone.BOSComment = "";
            this.fld_txtICStockContactPhone.BOSDataMember = "ICStockContactPhone";
            this.fld_txtICStockContactPhone.BOSDataSource = "ICStocks";
            this.fld_txtICStockContactPhone.BOSDescription = null;
            this.fld_txtICStockContactPhone.BOSError = "";
            this.fld_txtICStockContactPhone.BOSFieldGroup = "";
            this.fld_txtICStockContactPhone.BOSFieldRelation = "";
            this.fld_txtICStockContactPhone.BOSPrivilege = "";
            this.fld_txtICStockContactPhone.BOSPropertyName = "Text";
            this.fld_txtICStockContactPhone.Location = new System.Drawing.Point(116, 75);
            this.fld_txtICStockContactPhone.Name = "fld_txtICStockContactPhone";
            this.fld_txtICStockContactPhone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICStockContactPhone.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICStockContactPhone.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICStockContactPhone.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICStockContactPhone.Properties.Mask.EditMask = "\\d+";
            this.fld_txtICStockContactPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.fld_txtICStockContactPhone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICStockContactPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICStockContactPhone.Screen = null;
            this.fld_txtICStockContactPhone.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICStockContactPhone.TabIndex = 13;
            this.fld_txtICStockContactPhone.Tag = "DC";
            // 
            // fld_txtICStockContactFax
            // 
            this.fld_txtICStockContactFax.BOSComment = "";
            this.fld_txtICStockContactFax.BOSDataMember = "ICStockContactFax";
            this.fld_txtICStockContactFax.BOSDataSource = "ICStocks";
            this.fld_txtICStockContactFax.BOSDescription = null;
            this.fld_txtICStockContactFax.BOSError = "";
            this.fld_txtICStockContactFax.BOSFieldGroup = "";
            this.fld_txtICStockContactFax.BOSFieldRelation = "";
            this.fld_txtICStockContactFax.BOSPrivilege = "";
            this.fld_txtICStockContactFax.BOSPropertyName = "Text";
            this.fld_txtICStockContactFax.Location = new System.Drawing.Point(365, 100);
            this.fld_txtICStockContactFax.Name = "fld_txtICStockContactFax";
            this.fld_txtICStockContactFax.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICStockContactFax.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICStockContactFax.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICStockContactFax.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICStockContactFax.Properties.Mask.EditMask = "\\d+";
            this.fld_txtICStockContactFax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.fld_txtICStockContactFax.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICStockContactFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICStockContactFax.Screen = null;
            this.fld_txtICStockContactFax.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICStockContactFax.TabIndex = 16;
            this.fld_txtICStockContactFax.Tag = "DC";
            // 
            // fld_txtICStockContactCellPhone
            // 
            this.fld_txtICStockContactCellPhone.BOSComment = "";
            this.fld_txtICStockContactCellPhone.BOSDataMember = "ICStockContactCellPhone";
            this.fld_txtICStockContactCellPhone.BOSDataSource = "ICStocks";
            this.fld_txtICStockContactCellPhone.BOSDescription = null;
            this.fld_txtICStockContactCellPhone.BOSError = "";
            this.fld_txtICStockContactCellPhone.BOSFieldGroup = "";
            this.fld_txtICStockContactCellPhone.BOSFieldRelation = "";
            this.fld_txtICStockContactCellPhone.BOSPrivilege = "";
            this.fld_txtICStockContactCellPhone.BOSPropertyName = "Text";
            this.fld_txtICStockContactCellPhone.Location = new System.Drawing.Point(365, 75);
            this.fld_txtICStockContactCellPhone.Name = "fld_txtICStockContactCellPhone";
            this.fld_txtICStockContactCellPhone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICStockContactCellPhone.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICStockContactCellPhone.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICStockContactCellPhone.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICStockContactCellPhone.Properties.Mask.EditMask = "\\d+";
            this.fld_txtICStockContactCellPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.fld_txtICStockContactCellPhone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICStockContactCellPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICStockContactCellPhone.Screen = null;
            this.fld_txtICStockContactCellPhone.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICStockContactCellPhone.TabIndex = 14;
            this.fld_txtICStockContactCellPhone.Tag = "DC";
            // 
            // fld_txtICStockContactEmail1
            // 
            this.fld_txtICStockContactEmail1.BOSComment = "";
            this.fld_txtICStockContactEmail1.BOSDataMember = "ICStockContactEmail1";
            this.fld_txtICStockContactEmail1.BOSDataSource = "ICStocks";
            this.fld_txtICStockContactEmail1.BOSDescription = null;
            this.fld_txtICStockContactEmail1.BOSError = "";
            this.fld_txtICStockContactEmail1.BOSFieldGroup = "";
            this.fld_txtICStockContactEmail1.BOSFieldRelation = "";
            this.fld_txtICStockContactEmail1.BOSPrivilege = "";
            this.fld_txtICStockContactEmail1.BOSPropertyName = "Text";
            this.fld_txtICStockContactEmail1.Location = new System.Drawing.Point(116, 100);
            this.fld_txtICStockContactEmail1.Name = "fld_txtICStockContactEmail1";
            this.fld_txtICStockContactEmail1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICStockContactEmail1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICStockContactEmail1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICStockContactEmail1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICStockContactEmail1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICStockContactEmail1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICStockContactEmail1.Screen = null;
            this.fld_txtICStockContactEmail1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICStockContactEmail1.TabIndex = 15;
            this.fld_txtICStockContactEmail1.Tag = "DC";
            // 
            // fld_txtICStockContactDepartment
            // 
            this.fld_txtICStockContactDepartment.BOSComment = "";
            this.fld_txtICStockContactDepartment.BOSDataMember = "ICStockContactDepartment";
            this.fld_txtICStockContactDepartment.BOSDataSource = "ICStocks";
            this.fld_txtICStockContactDepartment.BOSDescription = null;
            this.fld_txtICStockContactDepartment.BOSError = "";
            this.fld_txtICStockContactDepartment.BOSFieldGroup = "";
            this.fld_txtICStockContactDepartment.BOSFieldRelation = "";
            this.fld_txtICStockContactDepartment.BOSPrivilege = "";
            this.fld_txtICStockContactDepartment.BOSPropertyName = "Text";
            this.fld_txtICStockContactDepartment.Location = new System.Drawing.Point(116, 126);
            this.fld_txtICStockContactDepartment.Name = "fld_txtICStockContactDepartment";
            this.fld_txtICStockContactDepartment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICStockContactDepartment.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICStockContactDepartment.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICStockContactDepartment.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICStockContactDepartment.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICStockContactDepartment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICStockContactDepartment.Screen = null;
            this.fld_txtICStockContactDepartment.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICStockContactDepartment.TabIndex = 17;
            this.fld_txtICStockContactDepartment.Tag = "DC";
            // 
            // fld_txtICStockContactRoom
            // 
            this.fld_txtICStockContactRoom.BOSComment = "";
            this.fld_txtICStockContactRoom.BOSDataMember = "ICStockContactRoom";
            this.fld_txtICStockContactRoom.BOSDataSource = "ICStocks";
            this.fld_txtICStockContactRoom.BOSDescription = null;
            this.fld_txtICStockContactRoom.BOSError = "";
            this.fld_txtICStockContactRoom.BOSFieldGroup = "";
            this.fld_txtICStockContactRoom.BOSFieldRelation = "";
            this.fld_txtICStockContactRoom.BOSPrivilege = "";
            this.fld_txtICStockContactRoom.BOSPropertyName = "Text";
            this.fld_txtICStockContactRoom.Location = new System.Drawing.Point(365, 125);
            this.fld_txtICStockContactRoom.Name = "fld_txtICStockContactRoom";
            this.fld_txtICStockContactRoom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICStockContactRoom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICStockContactRoom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICStockContactRoom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICStockContactRoom.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICStockContactRoom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICStockContactRoom.Screen = null;
            this.fld_txtICStockContactRoom.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICStockContactRoom.TabIndex = 18;
            this.fld_txtICStockContactRoom.Tag = "DC";
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
            this.fld_grcGroupControl.Controls.Add(this.bosCheckEdit1);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl.Controls.Add(this.bosTextBox1);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_ACAccountID);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtICStockContactAddressPostalCode);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtICStockContactAddressStateProvince);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel12);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel14);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel18);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel37);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel46);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtICStockName);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtICStockContactAddressCity);
            this.fld_grcGroupControl.Controls.Add(this.fld_medICStockDesc);
            this.fld_grcGroupControl.Controls.Add(this.fld_chkICStockActiveCheck);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtICStockNo1);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel8);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtICStockContactAddressLine1);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel25);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel26);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeICStockType);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel29);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel6);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtICStockContactAddressCountry);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(7, 4);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(555, 282);
            this.fld_grcGroupControl.TabIndex = 0;
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // bosCheckEdit1
            // 
            this.bosCheckEdit1.BOSComment = "";
            this.bosCheckEdit1.BOSDataMember = "ICStockIsSemiProduct";
            this.bosCheckEdit1.BOSDataSource = "ICStocks";
            this.bosCheckEdit1.BOSDescription = null;
            this.bosCheckEdit1.BOSError = "";
            this.bosCheckEdit1.BOSFieldGroup = "";
            this.bosCheckEdit1.BOSFieldRelation = "";
            this.bosCheckEdit1.BOSPrivilege = "";
            this.bosCheckEdit1.BOSPropertyName = "EditValue";
            this.bosCheckEdit1.Location = new System.Drawing.Point(365, 221);
            this.bosCheckEdit1.Name = "bosCheckEdit1";
            this.bosCheckEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosCheckEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosCheckEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosCheckEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosCheckEdit1.Properties.Caption = "Kho Bán thành phẩm";
            this.bosCheckEdit1.Screen = null;
            this.bosCheckEdit1.Size = new System.Drawing.Size(159, 19);
            this.bosCheckEdit1.TabIndex = 337;
            this.bosCheckEdit1.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(290, 33);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(34, 13);
            this.bosLabel2.TabIndex = 336;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Kí hiệu";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "ICStockPrefix";
            this.bosTextBox1.BOSDataSource = "ICStocks";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = "";
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.Location = new System.Drawing.Point(365, 30);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox1.TabIndex = 335;
            this.bosTextBox1.Tag = "DC";
            // 
            // fld_lkeFK_ACAccountID
            // 
            this.fld_lkeFK_ACAccountID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAccountID.BOSComment = null;
            this.fld_lkeFK_ACAccountID.BOSDataMember = "FK_ACAccountID";
            this.fld_lkeFK_ACAccountID.BOSDataSource = "ICStocks";
            this.fld_lkeFK_ACAccountID.BOSDescription = null;
            this.fld_lkeFK_ACAccountID.BOSError = null;
            this.fld_lkeFK_ACAccountID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAccountID.BOSFieldParent = null;
            this.fld_lkeFK_ACAccountID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAccountID.BOSPrivilege = null;
            this.fld_lkeFK_ACAccountID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAccountID.BOSSelectType = null;
            this.fld_lkeFK_ACAccountID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACAccountID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAccountID.Location = new System.Drawing.Point(116, 221);
            this.fld_lkeFK_ACAccountID.Name = "fld_lkeFK_ACAccountID";
            this.fld_lkeFK_ACAccountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAccountID.Properties.ColumnName = null;
            this.fld_lkeFK_ACAccountID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACAccountID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACAccountID.Properties.NullText = "";
            this.fld_lkeFK_ACAccountID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAccountID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACAccountID.Screen = null;
            this.fld_lkeFK_ACAccountID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACAccountID.TabIndex = 10;
            this.fld_lkeFK_ACAccountID.Tag = "DC";
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
            this.bosLabel4.BOSPropertyName = "";
            this.bosLabel4.Location = new System.Drawing.Point(24, 224);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(65, 13);
            this.bosLabel4.TabIndex = 334;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Tài khoản tồn";
            // 
            // fld_txtICStockContactAddressPostalCode
            // 
            this.fld_txtICStockContactAddressPostalCode.BOSComment = null;
            this.fld_txtICStockContactAddressPostalCode.BOSDataMember = "ICStockContactAddressPostalCode";
            this.fld_txtICStockContactAddressPostalCode.BOSDataSource = "ICStocks";
            this.fld_txtICStockContactAddressPostalCode.BOSDescription = null;
            this.fld_txtICStockContactAddressPostalCode.BOSError = null;
            this.fld_txtICStockContactAddressPostalCode.BOSFieldGroup = null;
            this.fld_txtICStockContactAddressPostalCode.BOSFieldRelation = null;
            this.fld_txtICStockContactAddressPostalCode.BOSPrivilege = null;
            this.fld_txtICStockContactAddressPostalCode.BOSPropertyName = "Text";
            this.fld_txtICStockContactAddressPostalCode.Location = new System.Drawing.Point(365, 195);
            this.fld_txtICStockContactAddressPostalCode.MenuManager = this.screenToolbar;
            this.fld_txtICStockContactAddressPostalCode.Name = "fld_txtICStockContactAddressPostalCode";
            this.fld_txtICStockContactAddressPostalCode.Screen = null;
            this.fld_txtICStockContactAddressPostalCode.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICStockContactAddressPostalCode.TabIndex = 9;
            this.fld_txtICStockContactAddressPostalCode.Tag = "DC";
            // 
            // fld_txtICStockContactAddressStateProvince
            // 
            this.fld_txtICStockContactAddressStateProvince.BOSComment = null;
            this.fld_txtICStockContactAddressStateProvince.BOSDataMember = "ICStockContactAddressStateProvince";
            this.fld_txtICStockContactAddressStateProvince.BOSDataSource = "ICStocks";
            this.fld_txtICStockContactAddressStateProvince.BOSDescription = null;
            this.fld_txtICStockContactAddressStateProvince.BOSError = null;
            this.fld_txtICStockContactAddressStateProvince.BOSFieldGroup = null;
            this.fld_txtICStockContactAddressStateProvince.BOSFieldRelation = null;
            this.fld_txtICStockContactAddressStateProvince.BOSPrivilege = null;
            this.fld_txtICStockContactAddressStateProvince.BOSPropertyName = "Text";
            this.fld_txtICStockContactAddressStateProvince.Location = new System.Drawing.Point(365, 170);
            this.fld_txtICStockContactAddressStateProvince.MenuManager = this.screenToolbar;
            this.fld_txtICStockContactAddressStateProvince.Name = "fld_txtICStockContactAddressStateProvince";
            this.fld_txtICStockContactAddressStateProvince.Screen = null;
            this.fld_txtICStockContactAddressStateProvince.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICStockContactAddressStateProvince.TabIndex = 7;
            this.fld_txtICStockContactAddressStateProvince.Tag = "DC";
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
            this.fld_lblLabel12.Location = new System.Drawing.Point(24, 33);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(36, 13);
            this.fld_lblLabel12.TabIndex = 4;
            this.fld_lblLabel12.Tag = "";
            this.fld_lblLabel12.Text = "Mã kho";
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
            this.fld_lblLabel14.Location = new System.Drawing.Point(24, 57);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel14.TabIndex = 6;
            this.fld_lblLabel14.Tag = "";
            this.fld_lblLabel14.Text = "Tên kho";
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
            this.fld_lblLabel18.Location = new System.Drawing.Point(24, 83);
            this.fld_lblLabel18.Name = "fld_lblLabel18";
            this.fld_lblLabel18.Screen = null;
            this.fld_lblLabel18.Size = new System.Drawing.Size(41, 13);
            this.fld_lblLabel18.TabIndex = 14;
            this.fld_lblLabel18.Tag = "";
            this.fld_lblLabel18.Text = "Diễn giải";
            // 
            // fld_lblLabel37
            // 
            this.fld_lblLabel37.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel37.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel37.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel37.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel37.Appearance.Options.UseFont = true;
            this.fld_lblLabel37.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel37.BOSComment = "";
            this.fld_lblLabel37.BOSDataMember = "";
            this.fld_lblLabel37.BOSDataSource = "";
            this.fld_lblLabel37.BOSDescription = null;
            this.fld_lblLabel37.BOSError = null;
            this.fld_lblLabel37.BOSFieldGroup = "";
            this.fld_lblLabel37.BOSFieldRelation = "";
            this.fld_lblLabel37.BOSPrivilege = "";
            this.fld_lblLabel37.BOSPropertyName = null;
            this.fld_lblLabel37.Location = new System.Drawing.Point(24, 173);
            this.fld_lblLabel37.Name = "fld_lblLabel37";
            this.fld_lblLabel37.Screen = null;
            this.fld_lblLabel37.Size = new System.Drawing.Size(52, 13);
            this.fld_lblLabel37.TabIndex = 61;
            this.fld_lblLabel37.Tag = "";
            this.fld_lblLabel37.Text = "Thành phố";
            // 
            // fld_lblLabel46
            // 
            this.fld_lblLabel46.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel46.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel46.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel46.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel46.Appearance.Options.UseFont = true;
            this.fld_lblLabel46.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel46.BOSComment = "";
            this.fld_lblLabel46.BOSDataMember = "";
            this.fld_lblLabel46.BOSDataSource = "";
            this.fld_lblLabel46.BOSDescription = null;
            this.fld_lblLabel46.BOSError = null;
            this.fld_lblLabel46.BOSFieldGroup = "";
            this.fld_lblLabel46.BOSFieldRelation = "";
            this.fld_lblLabel46.BOSPrivilege = "";
            this.fld_lblLabel46.BOSPropertyName = null;
            this.fld_lblLabel46.Location = new System.Drawing.Point(290, 173);
            this.fld_lblLabel46.Name = "fld_lblLabel46";
            this.fld_lblLabel46.Screen = null;
            this.fld_lblLabel46.Size = new System.Drawing.Size(21, 13);
            this.fld_lblLabel46.TabIndex = 70;
            this.fld_lblLabel46.Tag = "";
            this.fld_lblLabel46.Text = "Tỉnh";
            // 
            // fld_txtICStockName
            // 
            this.fld_txtICStockName.BOSComment = "";
            this.fld_txtICStockName.BOSDataMember = "ICStockName";
            this.fld_txtICStockName.BOSDataSource = "ICStocks";
            this.fld_txtICStockName.BOSDescription = null;
            this.fld_txtICStockName.BOSError = "";
            this.fld_txtICStockName.BOSFieldGroup = "";
            this.fld_txtICStockName.BOSFieldRelation = "";
            this.fld_txtICStockName.BOSPrivilege = "";
            this.fld_txtICStockName.BOSPropertyName = "Text";
            this.fld_txtICStockName.Location = new System.Drawing.Point(116, 54);
            this.fld_txtICStockName.Name = "fld_txtICStockName";
            this.fld_txtICStockName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICStockName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICStockName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICStockName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICStockName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICStockName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICStockName.Screen = null;
            this.fld_txtICStockName.Size = new System.Drawing.Size(399, 20);
            this.fld_txtICStockName.TabIndex = 1;
            this.fld_txtICStockName.Tag = "DC";
            // 
            // fld_txtICStockContactAddressCity
            // 
            this.fld_txtICStockContactAddressCity.BOSComment = "";
            this.fld_txtICStockContactAddressCity.BOSDataMember = "ICStockContactAddressCity";
            this.fld_txtICStockContactAddressCity.BOSDataSource = "ICStocks";
            this.fld_txtICStockContactAddressCity.BOSDescription = null;
            this.fld_txtICStockContactAddressCity.BOSError = "";
            this.fld_txtICStockContactAddressCity.BOSFieldGroup = "";
            this.fld_txtICStockContactAddressCity.BOSFieldRelation = "";
            this.fld_txtICStockContactAddressCity.BOSPrivilege = "";
            this.fld_txtICStockContactAddressCity.BOSPropertyName = "Text";
            this.fld_txtICStockContactAddressCity.Location = new System.Drawing.Point(116, 170);
            this.fld_txtICStockContactAddressCity.Name = "fld_txtICStockContactAddressCity";
            this.fld_txtICStockContactAddressCity.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICStockContactAddressCity.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICStockContactAddressCity.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICStockContactAddressCity.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICStockContactAddressCity.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICStockContactAddressCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICStockContactAddressCity.Screen = null;
            this.fld_txtICStockContactAddressCity.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICStockContactAddressCity.TabIndex = 6;
            this.fld_txtICStockContactAddressCity.Tag = "DC";
            // 
            // fld_medICStockDesc
            // 
            this.fld_medICStockDesc.BOSComment = "";
            this.fld_medICStockDesc.BOSDataMember = "ICStockDesc";
            this.fld_medICStockDesc.BOSDataSource = "ICStocks";
            this.fld_medICStockDesc.BOSDescription = null;
            this.fld_medICStockDesc.BOSError = "";
            this.fld_medICStockDesc.BOSFieldGroup = "";
            this.fld_medICStockDesc.BOSFieldRelation = "";
            this.fld_medICStockDesc.BOSPrivilege = "";
            this.fld_medICStockDesc.BOSPropertyName = "Text";
            this.fld_medICStockDesc.Location = new System.Drawing.Point(116, 80);
            this.fld_medICStockDesc.Name = "fld_medICStockDesc";
            this.fld_medICStockDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICStockDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICStockDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICStockDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICStockDesc.Screen = null;
            this.fld_medICStockDesc.Size = new System.Drawing.Size(399, 35);
            this.fld_medICStockDesc.TabIndex = 2;
            this.fld_medICStockDesc.Tag = "DC";
            // 
            // fld_chkICStockActiveCheck
            // 
            this.fld_chkICStockActiveCheck.BOSComment = "";
            this.fld_chkICStockActiveCheck.BOSDataMember = "ICStockActiveCheck";
            this.fld_chkICStockActiveCheck.BOSDataSource = "ICStocks";
            this.fld_chkICStockActiveCheck.BOSDescription = null;
            this.fld_chkICStockActiveCheck.BOSError = "";
            this.fld_chkICStockActiveCheck.BOSFieldGroup = "";
            this.fld_chkICStockActiveCheck.BOSFieldRelation = "";
            this.fld_chkICStockActiveCheck.BOSPrivilege = "";
            this.fld_chkICStockActiveCheck.BOSPropertyName = "EditValue";
            this.fld_chkICStockActiveCheck.Location = new System.Drawing.Point(114, 247);
            this.fld_chkICStockActiveCheck.Name = "fld_chkICStockActiveCheck";
            this.fld_chkICStockActiveCheck.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkICStockActiveCheck.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkICStockActiveCheck.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkICStockActiveCheck.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkICStockActiveCheck.Properties.Caption = "Hoạt động";
            this.fld_chkICStockActiveCheck.Screen = null;
            this.fld_chkICStockActiveCheck.Size = new System.Drawing.Size(75, 19);
            this.fld_chkICStockActiveCheck.TabIndex = 11;
            this.fld_chkICStockActiveCheck.Tag = "DC";
            // 
            // fld_txtICStockNo1
            // 
            this.fld_txtICStockNo1.BOSComment = "";
            this.fld_txtICStockNo1.BOSDataMember = "ICStockNo";
            this.fld_txtICStockNo1.BOSDataSource = "ICStocks";
            this.fld_txtICStockNo1.BOSDescription = null;
            this.fld_txtICStockNo1.BOSError = "Mã kho không thể rỗng";
            this.fld_txtICStockNo1.BOSFieldGroup = "";
            this.fld_txtICStockNo1.BOSFieldRelation = "";
            this.fld_txtICStockNo1.BOSPrivilege = "";
            this.fld_txtICStockNo1.BOSPropertyName = "Text";
            this.fld_txtICStockNo1.Location = new System.Drawing.Point(116, 30);
            this.fld_txtICStockNo1.Name = "fld_txtICStockNo1";
            this.fld_txtICStockNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICStockNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICStockNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICStockNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICStockNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICStockNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICStockNo1.Screen = null;
            this.fld_txtICStockNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICStockNo1.TabIndex = 0;
            this.fld_txtICStockNo1.Tag = "DC";
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
            this.fld_lblLabel8.Location = new System.Drawing.Point(24, 148);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(33, 13);
            this.fld_lblLabel8.TabIndex = 195;
            this.fld_lblLabel8.Tag = "";
            this.fld_lblLabel8.Text = "Địa chỉ";
            // 
            // fld_txtICStockContactAddressLine1
            // 
            this.fld_txtICStockContactAddressLine1.BOSComment = "";
            this.fld_txtICStockContactAddressLine1.BOSDataMember = "ICStockContactAddressLine1";
            this.fld_txtICStockContactAddressLine1.BOSDataSource = "ICStocks";
            this.fld_txtICStockContactAddressLine1.BOSDescription = null;
            this.fld_txtICStockContactAddressLine1.BOSError = "";
            this.fld_txtICStockContactAddressLine1.BOSFieldGroup = "";
            this.fld_txtICStockContactAddressLine1.BOSFieldRelation = "";
            this.fld_txtICStockContactAddressLine1.BOSPrivilege = "";
            this.fld_txtICStockContactAddressLine1.BOSPropertyName = "Text";
            this.fld_txtICStockContactAddressLine1.Location = new System.Drawing.Point(116, 145);
            this.fld_txtICStockContactAddressLine1.Name = "fld_txtICStockContactAddressLine1";
            this.fld_txtICStockContactAddressLine1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICStockContactAddressLine1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICStockContactAddressLine1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICStockContactAddressLine1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICStockContactAddressLine1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICStockContactAddressLine1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICStockContactAddressLine1.Screen = null;
            this.fld_txtICStockContactAddressLine1.Size = new System.Drawing.Size(399, 20);
            this.fld_txtICStockContactAddressLine1.TabIndex = 5;
            this.fld_txtICStockContactAddressLine1.Tag = "DC";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = false;
            this.fld_lkeFK_BRBranchID.BOSComment = "";
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ICStocks";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = "";
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = "";
            this.fld_lkeFK_BRBranchID.BOSFieldParent = "";
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = "";
            this.fld_lkeFK_BRBranchID.BOSPrivilege = "";
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = "";
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = "";
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = "";
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(116, 120);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.ColumnName = null;
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = "";
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 3;
            this.fld_lkeFK_BRBranchID.Tag = "DC";
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
            this.fld_lblLabel25.Location = new System.Drawing.Point(24, 123);
            this.fld_lblLabel25.Name = "fld_lblLabel25";
            this.fld_lblLabel25.Screen = null;
            this.fld_lblLabel25.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel25.TabIndex = 216;
            this.fld_lblLabel25.Tag = "";
            this.fld_lblLabel25.Text = "Chi nhánh";
            // 
            // fld_lblLabel26
            // 
            this.fld_lblLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel26.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel26.Appearance.Options.UseFont = true;
            this.fld_lblLabel26.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel26.BOSComment = "";
            this.fld_lblLabel26.BOSDataMember = "";
            this.fld_lblLabel26.BOSDataSource = "";
            this.fld_lblLabel26.BOSDescription = null;
            this.fld_lblLabel26.BOSError = null;
            this.fld_lblLabel26.BOSFieldGroup = "";
            this.fld_lblLabel26.BOSFieldRelation = "";
            this.fld_lblLabel26.BOSPrivilege = "";
            this.fld_lblLabel26.BOSPropertyName = null;
            this.fld_lblLabel26.Location = new System.Drawing.Point(290, 124);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(41, 13);
            this.fld_lblLabel26.TabIndex = 217;
            this.fld_lblLabel26.Tag = "";
            this.fld_lblLabel26.Text = "Loại kho";
            // 
            // fld_lkeICStockType
            // 
            this.fld_lkeICStockType.BOSAllowAddNew = false;
            this.fld_lkeICStockType.BOSAllowDummy = false;
            this.fld_lkeICStockType.BOSComment = "";
            this.fld_lkeICStockType.BOSDataMember = "ICStockType";
            this.fld_lkeICStockType.BOSDataSource = "ICStocks";
            this.fld_lkeICStockType.BOSDescription = null;
            this.fld_lkeICStockType.BOSError = "";
            this.fld_lkeICStockType.BOSFieldGroup = "";
            this.fld_lkeICStockType.BOSFieldParent = "";
            this.fld_lkeICStockType.BOSFieldRelation = "";
            this.fld_lkeICStockType.BOSPrivilege = "";
            this.fld_lkeICStockType.BOSPropertyName = "EditValue";
            this.fld_lkeICStockType.BOSSelectType = "";
            this.fld_lkeICStockType.BOSSelectTypeValue = "";
            this.fld_lkeICStockType.CurrentDisplayText = "";
            this.fld_lkeICStockType.Location = new System.Drawing.Point(365, 121);
            this.fld_lkeICStockType.Name = "fld_lkeICStockType";
            this.fld_lkeICStockType.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeICStockType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICStockType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICStockType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICStockType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICStockType.Properties.ColumnName = null;
            this.fld_lkeICStockType.Properties.NullText = "";
            this.fld_lkeICStockType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICStockType.Screen = null;
            this.fld_lkeICStockType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICStockType.TabIndex = 4;
            this.fld_lkeICStockType.Tag = "DC";
            // 
            // fld_lblLabel29
            // 
            this.fld_lblLabel29.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel29.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel29.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel29.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel29.Appearance.Options.UseFont = true;
            this.fld_lblLabel29.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel29.BOSComment = "";
            this.fld_lblLabel29.BOSDataMember = "";
            this.fld_lblLabel29.BOSDataSource = "";
            this.fld_lblLabel29.BOSDescription = null;
            this.fld_lblLabel29.BOSError = null;
            this.fld_lblLabel29.BOSFieldGroup = "";
            this.fld_lblLabel29.BOSFieldRelation = "";
            this.fld_lblLabel29.BOSPrivilege = "";
            this.fld_lblLabel29.BOSPropertyName = null;
            this.fld_lblLabel29.Location = new System.Drawing.Point(290, 198);
            this.fld_lblLabel29.Name = "fld_lblLabel29";
            this.fld_lblLabel29.Screen = null;
            this.fld_lblLabel29.Size = new System.Drawing.Size(42, 13);
            this.fld_lblLabel29.TabIndex = 219;
            this.fld_lblLabel29.Tag = "";
            this.fld_lblLabel29.Text = "Mã vùng";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseFont = true;
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
            this.fld_lblLabel6.Location = new System.Drawing.Point(24, 198);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(43, 13);
            this.fld_lblLabel6.TabIndex = 224;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Quốc gia";
            // 
            // fld_txtICStockContactAddressCountry
            // 
            this.fld_txtICStockContactAddressCountry.BOSComment = "";
            this.fld_txtICStockContactAddressCountry.BOSDataMember = "ICStockContactAddressCountry";
            this.fld_txtICStockContactAddressCountry.BOSDataSource = "ICStocks";
            this.fld_txtICStockContactAddressCountry.BOSDescription = null;
            this.fld_txtICStockContactAddressCountry.BOSError = "";
            this.fld_txtICStockContactAddressCountry.BOSFieldGroup = "";
            this.fld_txtICStockContactAddressCountry.BOSFieldRelation = "";
            this.fld_txtICStockContactAddressCountry.BOSPrivilege = "";
            this.fld_txtICStockContactAddressCountry.BOSPropertyName = "Text";
            this.fld_txtICStockContactAddressCountry.Location = new System.Drawing.Point(116, 195);
            this.fld_txtICStockContactAddressCountry.Name = "fld_txtICStockContactAddressCountry";
            this.fld_txtICStockContactAddressCountry.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICStockContactAddressCountry.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICStockContactAddressCountry.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICStockContactAddressCountry.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICStockContactAddressCountry.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICStockContactAddressCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICStockContactAddressCountry.Screen = null;
            this.fld_txtICStockContactAddressCountry.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICStockContactAddressCountry.TabIndex = 8;
            this.fld_txtICStockContactAddressCountry.Tag = "DC";
            // 
            // DMST100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(896, 575);
            this.Controls.Add(this.fld_grcGroupControl3);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Controls.Add(this.fld_Line1);
            this.Controls.Add(this.fld_Line2);
            this.Controls.Add(this.fld_Line3);
            this.Name = "DMST100";
            this.Text = "Thông tin ";
            this.Controls.SetChildIndex(this.fld_Line3, 0);
            this.Controls.SetChildIndex(this.fld_Line2, 0);
            this.Controls.SetChildIndex(this.fld_Line1, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).EndInit();
            this.fld_grcGroupControl3.ResumeLayout(false);
            this.fld_grcGroupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactCellPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactEmail1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactRoom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosCheckEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactAddressPostalCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactAddressStateProvince.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactAddressCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICStockDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICStockActiveCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactAddressLine1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICStockType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICStockContactAddressCountry.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSGroupControl fld_grcGroupControl3;
        private BOSComponent.BOSLabel fld_lblLabel27;
        private BOSComponent.BOSLabel fld_lblLabel30;
        private BOSComponent.BOSLabel fld_lblLabel32;
        private BOSComponent.BOSLabel fld_lblLabel38;
        private BOSComponent.BOSLabel fld_lblLabel41;
        private BOSComponent.BOSLabel fld_lblLabel42;
        private BOSComponent.BOSLabel fld_lblLabel43;
        private BOSComponent.BOSLabel fld_lblLabel45;
        private BOSComponent.BOSTextBox fld_txtICStockContactTitle;
        private BOSComponent.BOSTextBox fld_txtICStockContactFirstName;
        private BOSComponent.BOSTextBox fld_txtICStockContactPhone;
        private BOSComponent.BOSTextBox fld_txtICStockContactFax;
        private BOSComponent.BOSTextBox fld_txtICStockContactCellPhone;
        private BOSComponent.BOSTextBox fld_txtICStockContactEmail1;
        private BOSComponent.BOSTextBox fld_txtICStockContactDepartment;
        private BOSComponent.BOSTextBox fld_txtICStockContactRoom;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private BOSComponent.BOSTextBox fld_txtICStockContactAddressPostalCode;
        private BOSComponent.BOSTextBox fld_txtICStockContactAddressStateProvince;
        private BOSComponent.BOSLabel fld_lblLabel12;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel18;
        private BOSComponent.BOSLabel fld_lblLabel37;
        private BOSComponent.BOSLabel fld_lblLabel46;
        private BOSComponent.BOSTextBox fld_txtICStockName;
        private BOSComponent.BOSTextBox fld_txtICStockContactAddressCity;
        private BOSComponent.BOSMemoEdit fld_medICStockDesc;
        private BOSComponent.BOSCheckEdit fld_chkICStockActiveCheck;
        private BOSComponent.BOSTextBox fld_txtICStockNo1;
        private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSTextBox fld_txtICStockContactAddressLine1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel fld_lblLabel25;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSLookupEdit fld_lkeICStockType;
        private BOSComponent.BOSLabel fld_lblLabel29;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSTextBox fld_txtICStockContactAddressCountry;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSCheckEdit bosCheckEdit1;
    }
}
