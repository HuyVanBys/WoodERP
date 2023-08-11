using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SellStaff.UI
{
	/// <summary>
	/// Summary description for DMSS109
	/// </summary>
	partial class DMSS109
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
            this.fld_celHREmployeeContactPersonDependency = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeFK_HRRelationshipID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHREmployeeContactPersonGenderCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtEndDate = new BOSComponent.BOSLabel(this.components);
            this.fld_txtStartDate = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel28 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECountryID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GEStateProvinceID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GEDistrictID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtHREmployeeContactPersonEndApplyDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dtpHREmployeeContactPersonStartApplyDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dtpHREmployeeContactPersonBirthday = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHREmployeeContactPersonAddressStreet = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeContactPersonPhone = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeContactPersonFax = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeContactPersonEmail = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeContactPersonAddressPostalCode = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeContactPersonName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeContactPersonCellPhone = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel35 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel38 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel48 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel49 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel50 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnAddContactPerson = new BOSComponent.BOSButton(this.components);
            this.fld_btnDeleteContactPerson = new BOSComponent.BOSButton(this.components);
            this.fld_btnEditContactPerson = new BOSComponent.BOSButton(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHREmployeeContactPersons = new BOSERP.Modules.SellStaff.HREmployeeContactPersonsGridControl();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_celHREmployeeContactPersonDependency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRRelationshipID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeContactPersonGenderCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECountryID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEStateProvinceID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEDistrictID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactPersonEndApplyDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactPersonEndApplyDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtpHREmployeeContactPersonStartApplyDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtpHREmployeeContactPersonStartApplyDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtpHREmployeeContactPersonBirthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtpHREmployeeContactPersonBirthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactPersonAddressStreet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactPersonPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactPersonFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactPersonEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactPersonAddressPostalCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactPersonName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactPersonCellPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeContactPersons)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_btnAddContactPerson);
            this.bosPanel1.Controls.Add(this.fld_btnDeleteContactPerson);
            this.bosPanel1.Controls.Add(this.fld_btnEditContactPerson);
            this.bosPanel1.Controls.Add(this.bosGroupControl2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosPanel1, true);
            this.bosPanel1.Size = new System.Drawing.Size(783, 687);
            this.bosPanel1.TabIndex = 50;
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
            this.bosGroupControl1.Controls.Add(this.fld_celHREmployeeContactPersonDependency);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_HRRelationshipID);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel9);
            this.bosGroupControl1.Controls.Add(this.fld_lkeHREmployeeContactPersonGenderCombo);
            this.bosGroupControl1.Controls.Add(this.fld_txtEndDate);
            this.bosGroupControl1.Controls.Add(this.fld_txtStartDate);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel27);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel28);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_GECountryID1);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_GEStateProvinceID1);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_GEDistrictID1);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeContactPersonEndApplyDate);
            this.bosGroupControl1.Controls.Add(this.fld_dtpHREmployeeContactPersonStartApplyDate);
            this.bosGroupControl1.Controls.Add(this.fld_dtpHREmployeeContactPersonBirthday);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeContactPersonAddressStreet);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeContactPersonPhone);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeContactPersonFax);
            this.bosGroupControl1.Controls.Add(this.bosTextBox1);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeContactPersonEmail);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeContactPersonAddressPostalCode);
            this.bosGroupControl1.Controls.Add(this.bosLabel6);
            this.bosGroupControl1.Controls.Add(this.bosLabel9);
            this.bosGroupControl1.Controls.Add(this.bosLabel8);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeContactPersonName);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeContactPersonCellPhone);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel35);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel38);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel48);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel49);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel50);
            this.bosGroupControl1.Location = new System.Drawing.Point(12, 10);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(759, 286);
            this.bosGroupControl1.TabIndex = 23;
            this.bosGroupControl1.Text = "Thông tin thân nhân";
            // 
            // fld_celHREmployeeContactPersonDependency
            // 
            this.fld_celHREmployeeContactPersonDependency.BOSComment = null;
            this.fld_celHREmployeeContactPersonDependency.BOSDataMember = "HREmployeeContactPersonDependency";
            this.fld_celHREmployeeContactPersonDependency.BOSDataSource = "HREmployeeContactPersons";
            this.fld_celHREmployeeContactPersonDependency.BOSDescription = null;
            this.fld_celHREmployeeContactPersonDependency.BOSError = null;
            this.fld_celHREmployeeContactPersonDependency.BOSFieldGroup = null;
            this.fld_celHREmployeeContactPersonDependency.BOSFieldRelation = null;
            this.fld_celHREmployeeContactPersonDependency.BOSPrivilege = null;
            this.fld_celHREmployeeContactPersonDependency.BOSPropertyName = "EditValue";
            this.fld_celHREmployeeContactPersonDependency.Location = new System.Drawing.Point(263, 207);
            this.fld_celHREmployeeContactPersonDependency.MenuManager = this.screenToolbar;
            this.fld_celHREmployeeContactPersonDependency.Name = "fld_celHREmployeeContactPersonDependency";
            this.fld_celHREmployeeContactPersonDependency.Properties.Caption = "Người phụ thuộc";
            this.fld_celHREmployeeContactPersonDependency.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_celHREmployeeContactPersonDependency, true);
            this.fld_celHREmployeeContactPersonDependency.Size = new System.Drawing.Size(113, 19);
            this.fld_celHREmployeeContactPersonDependency.TabIndex = 26;
            this.fld_celHREmployeeContactPersonDependency.Tag = "DC";
            this.fld_celHREmployeeContactPersonDependency.CheckedChanged += new System.EventHandler(this.fld_celHREmployeeContactPersonDependency_CheckedChanged);
            // 
            // fld_lkeFK_HRRelationshipID
            // 
            this.fld_lkeFK_HRRelationshipID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRRelationshipID.BOSAllowDummy = true;
            this.fld_lkeFK_HRRelationshipID.BOSComment = null;
            this.fld_lkeFK_HRRelationshipID.BOSDataMember = "FK_HRRelationshipID";
            this.fld_lkeFK_HRRelationshipID.BOSDataSource = "HREmployeeContactPersons";
            this.fld_lkeFK_HRRelationshipID.BOSDescription = null;
            this.fld_lkeFK_HRRelationshipID.BOSError = null;
            this.fld_lkeFK_HRRelationshipID.BOSFieldGroup = null;
            this.fld_lkeFK_HRRelationshipID.BOSFieldParent = null;
            this.fld_lkeFK_HRRelationshipID.BOSFieldRelation = null;
            this.fld_lkeFK_HRRelationshipID.BOSPrivilege = null;
            this.fld_lkeFK_HRRelationshipID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRRelationshipID.BOSSelectType = null;
            this.fld_lkeFK_HRRelationshipID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRRelationshipID.CurrentDisplayText = null;
            this.fld_lkeFK_HRRelationshipID.Location = new System.Drawing.Point(358, 25);
            this.fld_lkeFK_HRRelationshipID.Name = "fld_lkeFK_HRRelationshipID";
            this.fld_lkeFK_HRRelationshipID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRRelationshipID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRRelationshipID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRRelationshipID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRRelationshipID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRRelationshipID.Properties.ColumnName = null;
            this.fld_lkeFK_HRRelationshipID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRRelationshipCode", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRRelationshipName", "Tên")});
            this.fld_lkeFK_HRRelationshipID.Properties.DisplayMember = "HRRelationshipName";
            this.fld_lkeFK_HRRelationshipID.Properties.NullText = "";
            this.fld_lkeFK_HRRelationshipID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRRelationshipID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRRelationshipID.Properties.ValueMember = "HRRelationshipID";
            this.fld_lkeFK_HRRelationshipID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRRelationshipID, true);
            this.fld_lkeFK_HRRelationshipID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRRelationshipID.TabIndex = 3;
            this.fld_lkeFK_HRRelationshipID.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(4, 54);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(38, 13);
            this.bosLabel3.TabIndex = 4;
            this.bosLabel3.Text = "Giới tính";
            // 
            // fld_lblLabel9
            // 
            this.fld_lblLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel9.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel9.BOSComment = null;
            this.fld_lblLabel9.BOSDataMember = null;
            this.fld_lblLabel9.BOSDataSource = null;
            this.fld_lblLabel9.BOSDescription = null;
            this.fld_lblLabel9.BOSError = null;
            this.fld_lblLabel9.BOSFieldGroup = null;
            this.fld_lblLabel9.BOSFieldRelation = null;
            this.fld_lblLabel9.BOSPrivilege = null;
            this.fld_lblLabel9.BOSPropertyName = null;
            this.fld_lblLabel9.Location = new System.Drawing.Point(265, 28);
            this.fld_lblLabel9.Name = "fld_lblLabel9";
            this.fld_lblLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel9, true);
            this.fld_lblLabel9.Size = new System.Drawing.Size(58, 13);
            this.fld_lblLabel9.TabIndex = 2;
            this.fld_lblLabel9.Text = "Mối quan hệ";
            // 
            // fld_lkeHREmployeeContactPersonGenderCombo
            // 
            this.fld_lkeHREmployeeContactPersonGenderCombo.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeContactPersonGenderCombo.BOSAllowDummy = true;
            this.fld_lkeHREmployeeContactPersonGenderCombo.BOSComment = null;
            this.fld_lkeHREmployeeContactPersonGenderCombo.BOSDataMember = "HREmployeeContactPersonGenderCombo";
            this.fld_lkeHREmployeeContactPersonGenderCombo.BOSDataSource = "HREmployeeContactPersons";
            this.fld_lkeHREmployeeContactPersonGenderCombo.BOSDescription = null;
            this.fld_lkeHREmployeeContactPersonGenderCombo.BOSError = null;
            this.fld_lkeHREmployeeContactPersonGenderCombo.BOSFieldGroup = null;
            this.fld_lkeHREmployeeContactPersonGenderCombo.BOSFieldParent = null;
            this.fld_lkeHREmployeeContactPersonGenderCombo.BOSFieldRelation = null;
            this.fld_lkeHREmployeeContactPersonGenderCombo.BOSPrivilege = null;
            this.fld_lkeHREmployeeContactPersonGenderCombo.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeContactPersonGenderCombo.BOSSelectType = null;
            this.fld_lkeHREmployeeContactPersonGenderCombo.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeeContactPersonGenderCombo.CurrentDisplayText = null;
            this.fld_lkeHREmployeeContactPersonGenderCombo.Location = new System.Drawing.Point(97, 51);
            this.fld_lkeHREmployeeContactPersonGenderCombo.Name = "fld_lkeHREmployeeContactPersonGenderCombo";
            this.fld_lkeHREmployeeContactPersonGenderCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHREmployeeContactPersonGenderCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHREmployeeContactPersonGenderCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHREmployeeContactPersonGenderCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHREmployeeContactPersonGenderCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeContactPersonGenderCombo.Properties.ColumnName = null;
            this.fld_lkeHREmployeeContactPersonGenderCombo.Properties.NullText = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHREmployeeContactPersonGenderCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHREmployeeContactPersonGenderCombo.Screen = null;
            this.fld_lkeHREmployeeContactPersonGenderCombo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHREmployeeContactPersonGenderCombo.TabIndex = 5;
            this.fld_lkeHREmployeeContactPersonGenderCombo.Tag = "DC";
            // 
            // fld_txtEndDate
            // 
            this.fld_txtEndDate.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtEndDate.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtEndDate.Appearance.Options.UseBackColor = true;
            this.fld_txtEndDate.Appearance.Options.UseForeColor = true;
            this.fld_txtEndDate.BOSComment = null;
            this.fld_txtEndDate.BOSDataMember = null;
            this.fld_txtEndDate.BOSDataSource = null;
            this.fld_txtEndDate.BOSDescription = null;
            this.fld_txtEndDate.BOSError = null;
            this.fld_txtEndDate.BOSFieldGroup = null;
            this.fld_txtEndDate.BOSFieldRelation = null;
            this.fld_txtEndDate.BOSPrivilege = null;
            this.fld_txtEndDate.BOSPropertyName = null;
            this.fld_txtEndDate.Location = new System.Drawing.Point(259, 235);
            this.fld_txtEndDate.Name = "fld_txtEndDate";
            this.fld_txtEndDate.Screen = null;
            this.fld_txtEndDate.Size = new System.Drawing.Size(72, 13);
            this.fld_txtEndDate.TabIndex = 22;
            this.fld_txtEndDate.Text = "Tháng kết thúc";
            // 
            // fld_txtStartDate
            // 
            this.fld_txtStartDate.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtStartDate.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtStartDate.Appearance.Options.UseBackColor = true;
            this.fld_txtStartDate.Appearance.Options.UseForeColor = true;
            this.fld_txtStartDate.BOSComment = null;
            this.fld_txtStartDate.BOSDataMember = null;
            this.fld_txtStartDate.BOSDataSource = null;
            this.fld_txtStartDate.BOSDescription = null;
            this.fld_txtStartDate.BOSError = null;
            this.fld_txtStartDate.BOSFieldGroup = null;
            this.fld_txtStartDate.BOSFieldRelation = null;
            this.fld_txtStartDate.BOSPrivilege = null;
            this.fld_txtStartDate.BOSPropertyName = null;
            this.fld_txtStartDate.Location = new System.Drawing.Point(6, 235);
            this.fld_txtStartDate.Name = "fld_txtStartDate";
            this.fld_txtStartDate.Screen = null;
            this.fld_txtStartDate.Size = new System.Drawing.Size(70, 13);
            this.fld_txtStartDate.TabIndex = 22;
            this.fld_txtStartDate.Text = "Tháng bắt đầu";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(4, 184);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(67, 13);
            this.bosLabel1.TabIndex = 22;
            this.bosLabel1.Text = "Quận / Huyện";
            // 
            // fld_lblLabel27
            // 
            this.fld_lblLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel27.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel27.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel27.BOSComment = null;
            this.fld_lblLabel27.BOSDataMember = null;
            this.fld_lblLabel27.BOSDataSource = null;
            this.fld_lblLabel27.BOSDescription = null;
            this.fld_lblLabel27.BOSError = null;
            this.fld_lblLabel27.BOSFieldGroup = null;
            this.fld_lblLabel27.BOSFieldRelation = null;
            this.fld_lblLabel27.BOSPrivilege = null;
            this.fld_lblLabel27.BOSPropertyName = null;
            this.fld_lblLabel27.Location = new System.Drawing.Point(265, 158);
            this.fld_lblLabel27.Name = "fld_lblLabel27";
            this.fld_lblLabel27.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel27, true);
            this.fld_lblLabel27.Size = new System.Drawing.Size(42, 13);
            this.fld_lblLabel27.TabIndex = 20;
            this.fld_lblLabel27.Text = "Tỉnh / TP";
            // 
            // fld_lblLabel28
            // 
            this.fld_lblLabel28.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel28.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel28.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel28.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel28.BOSComment = null;
            this.fld_lblLabel28.BOSDataMember = null;
            this.fld_lblLabel28.BOSDataSource = null;
            this.fld_lblLabel28.BOSDescription = null;
            this.fld_lblLabel28.BOSError = null;
            this.fld_lblLabel28.BOSFieldGroup = null;
            this.fld_lblLabel28.BOSFieldRelation = null;
            this.fld_lblLabel28.BOSPrivilege = null;
            this.fld_lblLabel28.BOSPropertyName = null;
            this.fld_lblLabel28.Location = new System.Drawing.Point(4, 158);
            this.fld_lblLabel28.Name = "fld_lblLabel28";
            this.fld_lblLabel28.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel28, true);
            this.fld_lblLabel28.Size = new System.Drawing.Size(42, 13);
            this.fld_lblLabel28.TabIndex = 18;
            this.fld_lblLabel28.Text = "Quốc gia";
            // 
            // fld_lkeFK_GECountryID1
            // 
            this.fld_lkeFK_GECountryID1.BOSAllowAddNew = true;
            this.fld_lkeFK_GECountryID1.BOSAllowDummy = true;
            this.fld_lkeFK_GECountryID1.BOSComment = null;
            this.fld_lkeFK_GECountryID1.BOSDataMember = "FK_GECountryID";
            this.fld_lkeFK_GECountryID1.BOSDataSource = "HREmployeeContactPersons";
            this.fld_lkeFK_GECountryID1.BOSDescription = null;
            this.fld_lkeFK_GECountryID1.BOSError = null;
            this.fld_lkeFK_GECountryID1.BOSFieldGroup = null;
            this.fld_lkeFK_GECountryID1.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_GECountryID1.BOSFieldRelation = null;
            this.fld_lkeFK_GECountryID1.BOSPrivilege = null;
            this.fld_lkeFK_GECountryID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECountryID1.BOSSelectType = null;
            this.fld_lkeFK_GECountryID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_GECountryID1.CurrentDisplayText = null;
            this.fld_lkeFK_GECountryID1.Location = new System.Drawing.Point(97, 155);
            this.fld_lkeFK_GECountryID1.Name = "fld_lkeFK_GECountryID1";
            this.fld_lkeFK_GECountryID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECountryID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECountryID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECountryID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECountryID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECountryID1.Properties.ColumnName = null;
            this.fld_lkeFK_GECountryID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECountryCode", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECountryName", "Tên")});
            this.fld_lkeFK_GECountryID1.Properties.DisplayMember = "GECountryName";
            this.fld_lkeFK_GECountryID1.Properties.NullText = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_GECountryID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECountryID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECountryID1.Properties.ValueMember = "GECountryID";
            this.fld_lkeFK_GECountryID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GECountryID1, true);
            this.fld_lkeFK_GECountryID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECountryID1.TabIndex = 19;
            this.fld_lkeFK_GECountryID1.Tag = "DC";
            this.fld_lkeFK_GECountryID1.EditValueChanged += new System.EventHandler(this.fld_lkeFK_GECountryID1_EditValueChanged);
            this.fld_lkeFK_GECountryID1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_lkeFK_GECountryID1_EditValueChanging);
            // 
            // fld_lkeFK_GEStateProvinceID1
            // 
            this.fld_lkeFK_GEStateProvinceID1.BOSAllowAddNew = true;
            this.fld_lkeFK_GEStateProvinceID1.BOSAllowDummy = true;
            this.fld_lkeFK_GEStateProvinceID1.BOSComment = null;
            this.fld_lkeFK_GEStateProvinceID1.BOSDataMember = "FK_GEStateProvinceID";
            this.fld_lkeFK_GEStateProvinceID1.BOSDataSource = "HREmployeeContactPersons";
            this.fld_lkeFK_GEStateProvinceID1.BOSDescription = null;
            this.fld_lkeFK_GEStateProvinceID1.BOSError = null;
            this.fld_lkeFK_GEStateProvinceID1.BOSFieldGroup = null;
            this.fld_lkeFK_GEStateProvinceID1.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_GEStateProvinceID1.BOSFieldRelation = null;
            this.fld_lkeFK_GEStateProvinceID1.BOSPrivilege = null;
            this.fld_lkeFK_GEStateProvinceID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEStateProvinceID1.BOSSelectType = null;
            this.fld_lkeFK_GEStateProvinceID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_GEStateProvinceID1.CurrentDisplayText = null;
            this.fld_lkeFK_GEStateProvinceID1.Location = new System.Drawing.Point(358, 155);
            this.fld_lkeFK_GEStateProvinceID1.Name = "fld_lkeFK_GEStateProvinceID1";
            this.fld_lkeFK_GEStateProvinceID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEStateProvinceID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEStateProvinceID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEStateProvinceID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEStateProvinceID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEStateProvinceID1.Properties.ColumnName = null;
            this.fld_lkeFK_GEStateProvinceID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEStateProvinceCode", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEStateProvinceName", "Tên tỉnh / thành")});
            this.fld_lkeFK_GEStateProvinceID1.Properties.DisplayMember = "GEStateProvinceName";
            this.fld_lkeFK_GEStateProvinceID1.Properties.NullText = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_GEStateProvinceID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_GEStateProvinceID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEStateProvinceID1.Properties.ValueMember = "GEStateProvinceID";
            this.fld_lkeFK_GEStateProvinceID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GEStateProvinceID1, true);
            this.fld_lkeFK_GEStateProvinceID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GEStateProvinceID1.TabIndex = 21;
            this.fld_lkeFK_GEStateProvinceID1.Tag = "DC";
            this.fld_lkeFK_GEStateProvinceID1.EditValueChanged += new System.EventHandler(this.fld_lkeFK_GEStateProvinceID1_EditValueChanged);
            this.fld_lkeFK_GEStateProvinceID1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_lkeFK_GEStateProvinceID1_EditValueChanging);
            // 
            // fld_lkeFK_GEDistrictID1
            // 
            this.fld_lkeFK_GEDistrictID1.BOSAllowAddNew = true;
            this.fld_lkeFK_GEDistrictID1.BOSAllowDummy = true;
            this.fld_lkeFK_GEDistrictID1.BOSComment = null;
            this.fld_lkeFK_GEDistrictID1.BOSDataMember = "FK_GEDistrictID";
            this.fld_lkeFK_GEDistrictID1.BOSDataSource = "HREmployeeContactPersons";
            this.fld_lkeFK_GEDistrictID1.BOSDescription = null;
            this.fld_lkeFK_GEDistrictID1.BOSError = null;
            this.fld_lkeFK_GEDistrictID1.BOSFieldGroup = null;
            this.fld_lkeFK_GEDistrictID1.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_GEDistrictID1.BOSFieldRelation = null;
            this.fld_lkeFK_GEDistrictID1.BOSPrivilege = null;
            this.fld_lkeFK_GEDistrictID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEDistrictID1.BOSSelectType = null;
            this.fld_lkeFK_GEDistrictID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_GEDistrictID1.CurrentDisplayText = null;
            this.fld_lkeFK_GEDistrictID1.Location = new System.Drawing.Point(97, 181);
            this.fld_lkeFK_GEDistrictID1.Name = "fld_lkeFK_GEDistrictID1";
            this.fld_lkeFK_GEDistrictID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEDistrictID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEDistrictID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEDistrictID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEDistrictID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEDistrictID1.Properties.ColumnName = null;
            this.fld_lkeFK_GEDistrictID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEDistrictCode", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEDistrictName", "Tên quận/ huyện")});
            this.fld_lkeFK_GEDistrictID1.Properties.DisplayMember = "GEDistrictName";
            this.fld_lkeFK_GEDistrictID1.Properties.NullText = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_GEDistrictID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_GEDistrictID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEDistrictID1.Properties.ValueMember = "GEDistrictID";
            this.fld_lkeFK_GEDistrictID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GEDistrictID1, true);
            this.fld_lkeFK_GEDistrictID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GEDistrictID1.TabIndex = 23;
            this.fld_lkeFK_GEDistrictID1.Tag = "DC";
            this.fld_lkeFK_GEDistrictID1.EditValueChanged += new System.EventHandler(this.fld_lkeFK_GEDistrictID1_EditValueChanged);
            this.fld_lkeFK_GEDistrictID1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_lkeFK_GEDistrictID1_EditValueChanging);
            // 
            // fld_txtHREmployeeContactPersonEndApplyDate
            // 
            this.fld_txtHREmployeeContactPersonEndApplyDate.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonEndApplyDate.BOSDataMember = "HREmployeeContactPersonEndApplyDate";
            this.fld_txtHREmployeeContactPersonEndApplyDate.BOSDataSource = "HREmployeeContactPersons";
            this.fld_txtHREmployeeContactPersonEndApplyDate.BOSDescription = null;
            this.fld_txtHREmployeeContactPersonEndApplyDate.BOSError = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonEndApplyDate.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonEndApplyDate.BOSFieldRelation = null;
            this.fld_txtHREmployeeContactPersonEndApplyDate.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonEndApplyDate.BOSPropertyName = "EditValue";
            this.fld_txtHREmployeeContactPersonEndApplyDate.EditValue = null;
            this.fld_txtHREmployeeContactPersonEndApplyDate.Location = new System.Drawing.Point(358, 233);
            this.fld_txtHREmployeeContactPersonEndApplyDate.Name = "fld_txtHREmployeeContactPersonEndApplyDate";
            this.fld_txtHREmployeeContactPersonEndApplyDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeContactPersonEndApplyDate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_txtHREmployeeContactPersonEndApplyDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeContactPersonEndApplyDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeContactPersonEndApplyDate.Properties.Appearance.Options.UseFont = true;
            this.fld_txtHREmployeeContactPersonEndApplyDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeContactPersonEndApplyDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_txtHREmployeeContactPersonEndApplyDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_txtHREmployeeContactPersonEndApplyDate.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_txtHREmployeeContactPersonEndApplyDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_txtHREmployeeContactPersonEndApplyDate.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_txtHREmployeeContactPersonEndApplyDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_txtHREmployeeContactPersonEndApplyDate.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_txtHREmployeeContactPersonEndApplyDate.Screen = null;
            this.fld_txtHREmployeeContactPersonEndApplyDate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeContactPersonEndApplyDate.TabIndex = 7;
            this.fld_txtHREmployeeContactPersonEndApplyDate.Tag = "DC";
            // 
            // fld_dtpHREmployeeContactPersonStartApplyDate
            // 
            this.fld_dtpHREmployeeContactPersonStartApplyDate.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dtpHREmployeeContactPersonStartApplyDate.BOSDataMember = "HREmployeeContactPersonStartApplyDate";
            this.fld_dtpHREmployeeContactPersonStartApplyDate.BOSDataSource = "HREmployeeContactPersons";
            this.fld_dtpHREmployeeContactPersonStartApplyDate.BOSDescription = null;
            this.fld_dtpHREmployeeContactPersonStartApplyDate.BOSError = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dtpHREmployeeContactPersonStartApplyDate.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dtpHREmployeeContactPersonStartApplyDate.BOSFieldRelation = null;
            this.fld_dtpHREmployeeContactPersonStartApplyDate.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dtpHREmployeeContactPersonStartApplyDate.BOSPropertyName = "EditValue";
            this.fld_dtpHREmployeeContactPersonStartApplyDate.EditValue = null;
            this.fld_dtpHREmployeeContactPersonStartApplyDate.Location = new System.Drawing.Point(97, 233);
            this.fld_dtpHREmployeeContactPersonStartApplyDate.Name = "fld_dtpHREmployeeContactPersonStartApplyDate";
            this.fld_dtpHREmployeeContactPersonStartApplyDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dtpHREmployeeContactPersonStartApplyDate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_dtpHREmployeeContactPersonStartApplyDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dtpHREmployeeContactPersonStartApplyDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dtpHREmployeeContactPersonStartApplyDate.Properties.Appearance.Options.UseFont = true;
            this.fld_dtpHREmployeeContactPersonStartApplyDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dtpHREmployeeContactPersonStartApplyDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dtpHREmployeeContactPersonStartApplyDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dtpHREmployeeContactPersonStartApplyDate.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dtpHREmployeeContactPersonStartApplyDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dtpHREmployeeContactPersonStartApplyDate.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dtpHREmployeeContactPersonStartApplyDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dtpHREmployeeContactPersonStartApplyDate.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dtpHREmployeeContactPersonStartApplyDate.Screen = null;
            this.fld_dtpHREmployeeContactPersonStartApplyDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dtpHREmployeeContactPersonStartApplyDate.TabIndex = 7;
            this.fld_dtpHREmployeeContactPersonStartApplyDate.Tag = "DC";
            // 
            // fld_dtpHREmployeeContactPersonBirthday
            // 
            this.fld_dtpHREmployeeContactPersonBirthday.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dtpHREmployeeContactPersonBirthday.BOSDataMember = "HREmployeeContactPersonBirthday";
            this.fld_dtpHREmployeeContactPersonBirthday.BOSDataSource = "HREmployeeContactPersons";
            this.fld_dtpHREmployeeContactPersonBirthday.BOSDescription = null;
            this.fld_dtpHREmployeeContactPersonBirthday.BOSError = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dtpHREmployeeContactPersonBirthday.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dtpHREmployeeContactPersonBirthday.BOSFieldRelation = null;
            this.fld_dtpHREmployeeContactPersonBirthday.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dtpHREmployeeContactPersonBirthday.BOSPropertyName = "EditValue";
            this.fld_dtpHREmployeeContactPersonBirthday.EditValue = null;
            this.fld_dtpHREmployeeContactPersonBirthday.Location = new System.Drawing.Point(358, 51);
            this.fld_dtpHREmployeeContactPersonBirthday.Name = "fld_dtpHREmployeeContactPersonBirthday";
            this.fld_dtpHREmployeeContactPersonBirthday.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dtpHREmployeeContactPersonBirthday.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_dtpHREmployeeContactPersonBirthday.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dtpHREmployeeContactPersonBirthday.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dtpHREmployeeContactPersonBirthday.Properties.Appearance.Options.UseFont = true;
            this.fld_dtpHREmployeeContactPersonBirthday.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dtpHREmployeeContactPersonBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dtpHREmployeeContactPersonBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dtpHREmployeeContactPersonBirthday.Screen = null;
            this.fld_dtpHREmployeeContactPersonBirthday.Size = new System.Drawing.Size(150, 20);
            this.fld_dtpHREmployeeContactPersonBirthday.TabIndex = 7;
            this.fld_dtpHREmployeeContactPersonBirthday.Tag = "DC";
            // 
            // fld_txtHREmployeeContactPersonAddressStreet
            // 
            this.fld_txtHREmployeeContactPersonAddressStreet.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonAddressStreet.BOSDataMember = "HREmployeeContactPersonAddressStreet";
            this.fld_txtHREmployeeContactPersonAddressStreet.BOSDataSource = "HREmployeeContactPersons";
            this.fld_txtHREmployeeContactPersonAddressStreet.BOSDescription = null;
            this.fld_txtHREmployeeContactPersonAddressStreet.BOSError = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonAddressStreet.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonAddressStreet.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonAddressStreet.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonAddressStreet.BOSPropertyName = "Text";
            this.fld_txtHREmployeeContactPersonAddressStreet.Location = new System.Drawing.Point(97, 129);
            this.fld_txtHREmployeeContactPersonAddressStreet.Name = "fld_txtHREmployeeContactPersonAddressStreet";
            this.fld_txtHREmployeeContactPersonAddressStreet.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeContactPersonAddressStreet.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeContactPersonAddressStreet.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeContactPersonAddressStreet.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeContactPersonAddressStreet.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeContactPersonAddressStreet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeContactPersonAddressStreet.Screen = null;
            this.fld_txtHREmployeeContactPersonAddressStreet.Size = new System.Drawing.Size(411, 20);
            this.fld_txtHREmployeeContactPersonAddressStreet.TabIndex = 17;
            this.fld_txtHREmployeeContactPersonAddressStreet.Tag = "DC";
            // 
            // fld_txtHREmployeeContactPersonPhone
            // 
            this.fld_txtHREmployeeContactPersonPhone.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonPhone.BOSDataMember = "HREmployeeContactPersonPhone";
            this.fld_txtHREmployeeContactPersonPhone.BOSDataSource = "HREmployeeContactPersons";
            this.fld_txtHREmployeeContactPersonPhone.BOSDescription = null;
            this.fld_txtHREmployeeContactPersonPhone.BOSError = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonPhone.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonPhone.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonPhone.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonPhone.BOSPropertyName = "Text";
            this.fld_txtHREmployeeContactPersonPhone.Location = new System.Drawing.Point(97, 77);
            this.fld_txtHREmployeeContactPersonPhone.Name = "fld_txtHREmployeeContactPersonPhone";
            this.fld_txtHREmployeeContactPersonPhone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeContactPersonPhone.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeContactPersonPhone.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeContactPersonPhone.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeContactPersonPhone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeContactPersonPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeContactPersonPhone.Screen = null;
            this.fld_txtHREmployeeContactPersonPhone.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeContactPersonPhone.TabIndex = 9;
            this.fld_txtHREmployeeContactPersonPhone.Tag = "DC";
            // 
            // fld_txtHREmployeeContactPersonFax
            // 
            this.fld_txtHREmployeeContactPersonFax.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonFax.BOSDataMember = "HREmployeeContactPersonFax";
            this.fld_txtHREmployeeContactPersonFax.BOSDataSource = "HREmployeeContactPersons";
            this.fld_txtHREmployeeContactPersonFax.BOSDescription = null;
            this.fld_txtHREmployeeContactPersonFax.BOSError = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonFax.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonFax.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonFax.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonFax.BOSPropertyName = "Text";
            this.fld_txtHREmployeeContactPersonFax.Location = new System.Drawing.Point(358, 103);
            this.fld_txtHREmployeeContactPersonFax.Name = "fld_txtHREmployeeContactPersonFax";
            this.fld_txtHREmployeeContactPersonFax.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeContactPersonFax.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeContactPersonFax.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeContactPersonFax.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeContactPersonFax.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeContactPersonFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeContactPersonFax.Screen = null;
            this.fld_txtHREmployeeContactPersonFax.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeContactPersonFax.TabIndex = 15;
            this.fld_txtHREmployeeContactPersonFax.Tag = "DC";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.bosTextBox1.BOSDataMember = "HREmployeeContactPersonTaxNumber";
            this.bosTextBox1.BOSDataSource = "HREmployeeContactPersons";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = "(Liên 2 - Giao cho khách hàng)";
            this.bosTextBox1.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.bosTextBox1.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.bosTextBox1.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.Location = new System.Drawing.Point(97, 207);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox1.TabIndex = 13;
            this.bosTextBox1.Tag = "DC";
            // 
            // fld_txtHREmployeeContactPersonEmail
            // 
            this.fld_txtHREmployeeContactPersonEmail.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonEmail.BOSDataMember = "HREmployeeContactPersonEmail";
            this.fld_txtHREmployeeContactPersonEmail.BOSDataSource = "HREmployeeContactPersons";
            this.fld_txtHREmployeeContactPersonEmail.BOSDescription = null;
            this.fld_txtHREmployeeContactPersonEmail.BOSError = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonEmail.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonEmail.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonEmail.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonEmail.BOSPropertyName = "Text";
            this.fld_txtHREmployeeContactPersonEmail.Location = new System.Drawing.Point(97, 103);
            this.fld_txtHREmployeeContactPersonEmail.Name = "fld_txtHREmployeeContactPersonEmail";
            this.fld_txtHREmployeeContactPersonEmail.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeContactPersonEmail.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeContactPersonEmail.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeContactPersonEmail.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeContactPersonEmail.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeContactPersonEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeContactPersonEmail.Screen = null;
            this.fld_txtHREmployeeContactPersonEmail.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeContactPersonEmail.TabIndex = 13;
            this.fld_txtHREmployeeContactPersonEmail.Tag = "DC";
            // 
            // fld_txtHREmployeeContactPersonAddressPostalCode
            // 
            this.fld_txtHREmployeeContactPersonAddressPostalCode.BOSComment = null;
            this.fld_txtHREmployeeContactPersonAddressPostalCode.BOSDataMember = "HREmployeeContactPersonAddressPostalCode";
            this.fld_txtHREmployeeContactPersonAddressPostalCode.BOSDataSource = "HREmployeeContactPersons";
            this.fld_txtHREmployeeContactPersonAddressPostalCode.BOSDescription = null;
            this.fld_txtHREmployeeContactPersonAddressPostalCode.BOSError = null;
            this.fld_txtHREmployeeContactPersonAddressPostalCode.BOSFieldGroup = null;
            this.fld_txtHREmployeeContactPersonAddressPostalCode.BOSFieldRelation = null;
            this.fld_txtHREmployeeContactPersonAddressPostalCode.BOSPrivilege = null;
            this.fld_txtHREmployeeContactPersonAddressPostalCode.BOSPropertyName = "Text";
            this.fld_txtHREmployeeContactPersonAddressPostalCode.Location = new System.Drawing.Point(358, 181);
            this.fld_txtHREmployeeContactPersonAddressPostalCode.Name = "fld_txtHREmployeeContactPersonAddressPostalCode";
            this.fld_txtHREmployeeContactPersonAddressPostalCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeContactPersonAddressPostalCode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeContactPersonAddressPostalCode.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeContactPersonAddressPostalCode.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeContactPersonAddressPostalCode.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeContactPersonAddressPostalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeContactPersonAddressPostalCode.Screen = null;
            this.fld_txtHREmployeeContactPersonAddressPostalCode.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeContactPersonAddressPostalCode.TabIndex = 25;
            this.fld_txtHREmployeeContactPersonAddressPostalCode.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel6.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel6.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel6.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel6.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(264, 184);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(42, 13);
            this.bosLabel6.TabIndex = 24;
            this.bosLabel6.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel6.Text = "Mã vùng";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseFont = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.bosLabel9.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel9.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel9.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel9.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel9.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(16, 219);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(75, 13);
            this.bosLabel9.TabIndex = 16;
            this.bosLabel9.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel9.Text = "phụ thuộc";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseFont = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.bosLabel8.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel8.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel8.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel8.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel8.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(6, 204);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(90, 13);
            this.bosLabel8.TabIndex = 16;
            this.bosLabel8.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel8.Text = "Mã số thuế người";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel2.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel2.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel2.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel2.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(4, 133);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(33, 13);
            this.bosLabel2.TabIndex = 16;
            this.bosLabel2.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel2.Text = "Địa chỉ";
            // 
            // fld_txtHREmployeeContactPersonName
            // 
            this.fld_txtHREmployeeContactPersonName.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonName.BOSDataMember = "HREmployeeContactPersonName";
            this.fld_txtHREmployeeContactPersonName.BOSDataSource = "HREmployeeContactPersons";
            this.fld_txtHREmployeeContactPersonName.BOSDescription = null;
            this.fld_txtHREmployeeContactPersonName.BOSError = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonName.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonName.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonName.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonName.BOSPropertyName = "Text";
            this.fld_txtHREmployeeContactPersonName.Location = new System.Drawing.Point(97, 25);
            this.fld_txtHREmployeeContactPersonName.Name = "fld_txtHREmployeeContactPersonName";
            this.fld_txtHREmployeeContactPersonName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeContactPersonName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeContactPersonName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeContactPersonName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeContactPersonName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeContactPersonName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeContactPersonName.Screen = null;
            this.fld_txtHREmployeeContactPersonName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeContactPersonName.TabIndex = 1;
            this.fld_txtHREmployeeContactPersonName.Tag = "DC";
            // 
            // fld_txtHREmployeeContactPersonCellPhone
            // 
            this.fld_txtHREmployeeContactPersonCellPhone.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonCellPhone.BOSDataMember = "HREmployeeContactPersonCellPhone";
            this.fld_txtHREmployeeContactPersonCellPhone.BOSDataSource = "HREmployeeContactPersons";
            this.fld_txtHREmployeeContactPersonCellPhone.BOSDescription = null;
            this.fld_txtHREmployeeContactPersonCellPhone.BOSError = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonCellPhone.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonCellPhone.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonCellPhone.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContactPersonCellPhone.BOSPropertyName = "Text";
            this.fld_txtHREmployeeContactPersonCellPhone.Location = new System.Drawing.Point(358, 77);
            this.fld_txtHREmployeeContactPersonCellPhone.Name = "fld_txtHREmployeeContactPersonCellPhone";
            this.fld_txtHREmployeeContactPersonCellPhone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeContactPersonCellPhone.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeContactPersonCellPhone.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeContactPersonCellPhone.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeContactPersonCellPhone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeContactPersonCellPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeContactPersonCellPhone.Screen = null;
            this.fld_txtHREmployeeContactPersonCellPhone.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeContactPersonCellPhone.TabIndex = 11;
            this.fld_txtHREmployeeContactPersonCellPhone.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseFont = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel4.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel4.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel4.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel4.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(265, 53);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(47, 13);
            this.bosLabel4.TabIndex = 6;
            this.bosLabel4.Tag = "(Liên 2 - Giao cho khách hàng)";
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
            this.fld_lblLabel35.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel35.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel35.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel35.BOSDescription = null;
            this.fld_lblLabel35.BOSError = null;
            this.fld_lblLabel35.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel35.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel35.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel35.BOSPropertyName = null;
            this.fld_lblLabel35.Location = new System.Drawing.Point(4, 28);
            this.fld_lblLabel35.Name = "fld_lblLabel35";
            this.fld_lblLabel35.Screen = null;
            this.fld_lblLabel35.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel35.TabIndex = 0;
            this.fld_lblLabel35.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel35.Text = "Họ và tên";
            // 
            // fld_lblLabel38
            // 
            this.fld_lblLabel38.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel38.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel38.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel38.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel38.Appearance.Options.UseFont = true;
            this.fld_lblLabel38.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel38.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel38.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel38.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel38.BOSDescription = null;
            this.fld_lblLabel38.BOSError = null;
            this.fld_lblLabel38.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel38.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel38.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel38.BOSPropertyName = null;
            this.fld_lblLabel38.Location = new System.Drawing.Point(264, 80);
            this.fld_lblLabel38.Name = "fld_lblLabel38";
            this.fld_lblLabel38.Screen = null;
            this.fld_lblLabel38.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabel38.TabIndex = 10;
            this.fld_lblLabel38.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel38.Text = "Điện thoại DĐ";
            // 
            // fld_lblLabel48
            // 
            this.fld_lblLabel48.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel48.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel48.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel48.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel48.Appearance.Options.UseFont = true;
            this.fld_lblLabel48.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel48.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel48.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel48.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel48.BOSDescription = null;
            this.fld_lblLabel48.BOSError = null;
            this.fld_lblLabel48.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel48.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel48.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel48.BOSPropertyName = null;
            this.fld_lblLabel48.Location = new System.Drawing.Point(4, 106);
            this.fld_lblLabel48.Name = "fld_lblLabel48";
            this.fld_lblLabel48.Screen = null;
            this.fld_lblLabel48.Size = new System.Drawing.Size(25, 13);
            this.fld_lblLabel48.TabIndex = 12;
            this.fld_lblLabel48.Tag = "(Liên 2 - Giao cho khách hàng)";
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
            this.fld_lblLabel49.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel49.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel49.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel49.BOSDescription = null;
            this.fld_lblLabel49.BOSError = null;
            this.fld_lblLabel49.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel49.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel49.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel49.BOSPropertyName = null;
            this.fld_lblLabel49.Location = new System.Drawing.Point(4, 80);
            this.fld_lblLabel49.Name = "fld_lblLabel49";
            this.fld_lblLabel49.Screen = null;
            this.fld_lblLabel49.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel49.TabIndex = 8;
            this.fld_lblLabel49.Tag = "(Liên 2 - Giao cho khách hàng)";
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
            this.fld_lblLabel50.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel50.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel50.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel50.BOSDescription = null;
            this.fld_lblLabel50.BOSError = null;
            this.fld_lblLabel50.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel50.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel50.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel50.BOSPropertyName = null;
            this.fld_lblLabel50.Location = new System.Drawing.Point(265, 106);
            this.fld_lblLabel50.Name = "fld_lblLabel50";
            this.fld_lblLabel50.Screen = null;
            this.fld_lblLabel50.Size = new System.Drawing.Size(30, 13);
            this.fld_lblLabel50.TabIndex = 14;
            this.fld_lblLabel50.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel50.Text = "Số fax";
            // 
            // fld_btnAddContactPerson
            // 
            this.fld_btnAddContactPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnAddContactPerson.BOSComment = null;
            this.fld_btnAddContactPerson.BOSDataMember = null;
            this.fld_btnAddContactPerson.BOSDataSource = null;
            this.fld_btnAddContactPerson.BOSDescription = null;
            this.fld_btnAddContactPerson.BOSError = null;
            this.fld_btnAddContactPerson.BOSFieldGroup = null;
            this.fld_btnAddContactPerson.BOSFieldRelation = null;
            this.fld_btnAddContactPerson.BOSPrivilege = null;
            this.fld_btnAddContactPerson.BOSPropertyName = null;
            this.fld_btnAddContactPerson.Location = new System.Drawing.Point(528, 302);
            this.fld_btnAddContactPerson.Name = "fld_btnAddContactPerson";
            this.fld_btnAddContactPerson.Screen = null;
            this.fld_btnAddContactPerson.Size = new System.Drawing.Size(75, 27);
            this.fld_btnAddContactPerson.TabIndex = 0;
            this.fld_btnAddContactPerson.Text = "Thêm";
            this.fld_btnAddContactPerson.Click += new System.EventHandler(this.fld_btnAddContactPerson_Click);
            // 
            // fld_btnDeleteContactPerson
            // 
            this.fld_btnDeleteContactPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnDeleteContactPerson.BOSComment = null;
            this.fld_btnDeleteContactPerson.BOSDataMember = null;
            this.fld_btnDeleteContactPerson.BOSDataSource = null;
            this.fld_btnDeleteContactPerson.BOSDescription = null;
            this.fld_btnDeleteContactPerson.BOSError = null;
            this.fld_btnDeleteContactPerson.BOSFieldGroup = null;
            this.fld_btnDeleteContactPerson.BOSFieldRelation = null;
            this.fld_btnDeleteContactPerson.BOSPrivilege = null;
            this.fld_btnDeleteContactPerson.BOSPropertyName = null;
            this.fld_btnDeleteContactPerson.Location = new System.Drawing.Point(690, 302);
            this.fld_btnDeleteContactPerson.Name = "fld_btnDeleteContactPerson";
            this.fld_btnDeleteContactPerson.Screen = null;
            this.fld_btnDeleteContactPerson.Size = new System.Drawing.Size(75, 27);
            this.fld_btnDeleteContactPerson.TabIndex = 2;
            this.fld_btnDeleteContactPerson.Text = "Xóa";
            this.fld_btnDeleteContactPerson.Click += new System.EventHandler(this.fld_btnDeleteContactPerson_Click);
            // 
            // fld_btnEditContactPerson
            // 
            this.fld_btnEditContactPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnEditContactPerson.BOSComment = null;
            this.fld_btnEditContactPerson.BOSDataMember = null;
            this.fld_btnEditContactPerson.BOSDataSource = null;
            this.fld_btnEditContactPerson.BOSDescription = null;
            this.fld_btnEditContactPerson.BOSError = null;
            this.fld_btnEditContactPerson.BOSFieldGroup = null;
            this.fld_btnEditContactPerson.BOSFieldRelation = null;
            this.fld_btnEditContactPerson.BOSPrivilege = null;
            this.fld_btnEditContactPerson.BOSPropertyName = null;
            this.fld_btnEditContactPerson.Location = new System.Drawing.Point(609, 302);
            this.fld_btnEditContactPerson.Name = "fld_btnEditContactPerson";
            this.fld_btnEditContactPerson.Screen = null;
            this.fld_btnEditContactPerson.Size = new System.Drawing.Size(75, 27);
            this.fld_btnEditContactPerson.TabIndex = 1;
            this.fld_btnEditContactPerson.Text = "Sửa";
            this.fld_btnEditContactPerson.Click += new System.EventHandler(this.fld_btnEditContactPerson_Click);
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
            this.bosGroupControl2.Controls.Add(this.fld_dgcHREmployeeContactPersons);
            this.bosGroupControl2.Location = new System.Drawing.Point(11, 335);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(759, 341);
            this.bosGroupControl2.TabIndex = 3;
            this.bosGroupControl2.Text = "Danh sách thân nhân";
            // 
            // fld_dgcHREmployeeContactPersons
            // 
            this.fld_dgcHREmployeeContactPersons.BOSComment = null;
            this.fld_dgcHREmployeeContactPersons.BOSDataMember = "";
            this.fld_dgcHREmployeeContactPersons.BOSDataSource = "HREmployeeContactPersons";
            this.fld_dgcHREmployeeContactPersons.BOSDescription = null;
            this.fld_dgcHREmployeeContactPersons.BOSError = null;
            this.fld_dgcHREmployeeContactPersons.BOSFieldGroup = null;
            this.fld_dgcHREmployeeContactPersons.BOSFieldRelation = null;
            this.fld_dgcHREmployeeContactPersons.BOSGridType = null;
            this.fld_dgcHREmployeeContactPersons.BOSPrivilege = null;
            this.fld_dgcHREmployeeContactPersons.BOSPropertyName = null;
            this.fld_dgcHREmployeeContactPersons.CommodityType = "";
            this.fld_dgcHREmployeeContactPersons.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcHREmployeeContactPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHREmployeeContactPersons.Location = new System.Drawing.Point(2, 20);
            this.fld_dgcHREmployeeContactPersons.MenuManager = this.screenToolbar;
            this.fld_dgcHREmployeeContactPersons.Name = "fld_dgcHREmployeeContactPersons";
            this.fld_dgcHREmployeeContactPersons.PrintReport = false;
            this.fld_dgcHREmployeeContactPersons.Screen = null;
            this.fld_dgcHREmployeeContactPersons.Size = new System.Drawing.Size(755, 319);
            this.fld_dgcHREmployeeContactPersons.TabIndex = 0;
            // 
            // DMSS109
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(783, 687);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMSS109";
            this.Text = "Thông tin nhân thân";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_celHREmployeeContactPersonDependency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRRelationshipID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeContactPersonGenderCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECountryID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEStateProvinceID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEDistrictID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactPersonEndApplyDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactPersonEndApplyDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtpHREmployeeContactPersonStartApplyDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtpHREmployeeContactPersonStartApplyDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtpHREmployeeContactPersonBirthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtpHREmployeeContactPersonBirthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactPersonAddressStreet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactPersonPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactPersonFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactPersonEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactPersonAddressPostalCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactPersonName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactPersonCellPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeContactPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel fld_lblLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeContactPersonGenderCombo;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel fld_lblLabel27;
        private BOSComponent.BOSLabel fld_lblLabel28;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECountryID1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEStateProvinceID1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEDistrictID1;
        private BOSComponent.BOSDateEdit fld_dtpHREmployeeContactPersonBirthday;
        private BOSComponent.BOSTextBox fld_txtHREmployeeContactPersonAddressStreet;
        private BOSComponent.BOSTextBox fld_txtHREmployeeContactPersonPhone;
        private BOSComponent.BOSTextBox fld_txtHREmployeeContactPersonFax;
        private BOSComponent.BOSTextBox fld_txtHREmployeeContactPersonEmail;
        private BOSComponent.BOSTextBox fld_txtHREmployeeContactPersonAddressPostalCode;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtHREmployeeContactPersonName;
        private BOSComponent.BOSTextBox fld_txtHREmployeeContactPersonCellPhone;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel fld_lblLabel35;
        private BOSComponent.BOSLabel fld_lblLabel38;
        private BOSComponent.BOSLabel fld_lblLabel48;
        private BOSComponent.BOSLabel fld_lblLabel49;
        private BOSComponent.BOSLabel fld_lblLabel50;
        private BOSComponent.BOSButton fld_btnAddContactPerson;
        private BOSComponent.BOSButton fld_btnDeleteContactPerson;
        private BOSComponent.BOSButton fld_btnEditContactPerson;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRRelationshipID;
        private BOSComponent.BOSCheckEdit fld_celHREmployeeContactPersonDependency;
        private BOSComponent.BOSDateEdit fld_txtHREmployeeContactPersonEndApplyDate;
        private BOSComponent.BOSDateEdit fld_dtpHREmployeeContactPersonStartApplyDate;
        private BOSComponent.BOSLabel fld_txtEndDate;
        private BOSComponent.BOSLabel fld_txtStartDate;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel9;
        private HREmployeeContactPersonsGridControl fld_dgcHREmployeeContactPersons;
    }
}
