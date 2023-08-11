using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SellStaff.UI
{
	/// <summary>
	/// Summary description for SMST100
	/// </summary>
	partial class SMST100
	{
		private BOSComponent.BOSTextBox fld_txtHREmployeeNo1;
        private BOSComponent.BOSTextBox fld_txtHREmployeeFName1;
		private BOSComponent.BOSLookupEdit fld_lkeHREmployeeGenderCombo1;
        private BOSComponent.BOSTextBox fld_txtHREmployeeIDNumber1;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel9;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel fld_lblLabel11;
		private HREmployeeGridControl fld_dgcHREmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployee;


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
            this.fld_txtHREmployeeNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeFName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeHREmployeeGenderCombo1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtHREmployeeIDNumber1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcHREmployee = new HREmployeeGridControl();
            this.fld_dgvHREmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeContactAddressLine3 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentRoomID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRLevelID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHREmployeeStatusCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HREmployeePayrollFormulaID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeFName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeGenderCombo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeIDNumber1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactAddressLine3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRLevelID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeStatusCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeePayrollFormulaID1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtHREmployeeNo1
            // 
            this.fld_txtHREmployeeNo1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeeNo1.BOSDataMember = "HREmployeeNo";
            this.fld_txtHREmployeeNo1.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeNo1.BOSDescription = null;
            this.fld_txtHREmployeeNo1.BOSError = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeeNo1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeeNo1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeeNo1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeeNo1.BOSPropertyName = "Text";
            this.fld_txtHREmployeeNo1.Location = new System.Drawing.Point(134, 9);
            this.fld_txtHREmployeeNo1.Name = "fld_txtHREmployeeNo1";
            this.fld_txtHREmployeeNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeNo1.Screen = null;
            this.fld_txtHREmployeeNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeNo1.TabIndex = 1;
            this.fld_txtHREmployeeNo1.Tag = "SC";
            // 
            // fld_txtHREmployeeFName1
            // 
            this.fld_txtHREmployeeFName1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeeFName1.BOSDataMember = "HREmployeeName";
            this.fld_txtHREmployeeFName1.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeFName1.BOSDescription = null;
            this.fld_txtHREmployeeFName1.BOSError = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeeFName1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeeFName1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeeFName1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeeFName1.BOSPropertyName = "Text";
            this.fld_txtHREmployeeFName1.Location = new System.Drawing.Point(134, 35);
            this.fld_txtHREmployeeFName1.Name = "fld_txtHREmployeeFName1";
            this.fld_txtHREmployeeFName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeFName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeFName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeFName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeFName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeFName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeFName1.Screen = null;
            this.fld_txtHREmployeeFName1.Size = new System.Drawing.Size(306, 20);
            this.fld_txtHREmployeeFName1.TabIndex = 2;
            this.fld_txtHREmployeeFName1.Tag = "SC";
            // 
            // fld_lkeHREmployeeGenderCombo1
            // 
            this.fld_lkeHREmployeeGenderCombo1.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeGenderCombo1.BOSAllowDummy = true;
            this.fld_lkeHREmployeeGenderCombo1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHREmployeeGenderCombo1.BOSDataMember = "HREmployeeGenderCombo";
            this.fld_lkeHREmployeeGenderCombo1.BOSDataSource = "HREmployees";
            this.fld_lkeHREmployeeGenderCombo1.BOSDescription = null;
            this.fld_lkeHREmployeeGenderCombo1.BOSError = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHREmployeeGenderCombo1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHREmployeeGenderCombo1.BOSFieldParent = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHREmployeeGenderCombo1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHREmployeeGenderCombo1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHREmployeeGenderCombo1.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeGenderCombo1.BOSSelectType = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHREmployeeGenderCombo1.BOSSelectTypeValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHREmployeeGenderCombo1.CurrentDisplayText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHREmployeeGenderCombo1.Location = new System.Drawing.Point(134, 88);
            this.fld_lkeHREmployeeGenderCombo1.Name = "fld_lkeHREmployeeGenderCombo1";
            this.fld_lkeHREmployeeGenderCombo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHREmployeeGenderCombo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHREmployeeGenderCombo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHREmployeeGenderCombo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHREmployeeGenderCombo1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeGenderCombo1.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHREmployeeGenderCombo1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHREmployeeGenderCombo1.Screen = null;
            this.fld_lkeHREmployeeGenderCombo1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHREmployeeGenderCombo1.TabIndex = 4;
            this.fld_lkeHREmployeeGenderCombo1.Tag = "SC";
            // 
            // fld_txtHREmployeeIDNumber1
            // 
            this.fld_txtHREmployeeIDNumber1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeeIDNumber1.BOSDataMember = "HREmployeeIDNumber";
            this.fld_txtHREmployeeIDNumber1.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeIDNumber1.BOSDescription = null;
            this.fld_txtHREmployeeIDNumber1.BOSError = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeeIDNumber1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeeIDNumber1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeeIDNumber1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeeIDNumber1.BOSPropertyName = "Text";
            this.fld_txtHREmployeeIDNumber1.Location = new System.Drawing.Point(134, 114);
            this.fld_txtHREmployeeIDNumber1.Name = "fld_txtHREmployeeIDNumber1";
            this.fld_txtHREmployeeIDNumber1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeIDNumber1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeIDNumber1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeIDNumber1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeIDNumber1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeIDNumber1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeIDNumber1.Screen = null;
            this.fld_txtHREmployeeIDNumber1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeIDNumber1.TabIndex = 5;
            this.fld_txtHREmployeeIDNumber1.Tag = "SC";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(40, 12);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(64, 13);
            this.fld_lblLabel2.TabIndex = 18;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Mã nhân viên";
            // 
            // fld_lblLabel9
            // 
            this.fld_lblLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel9.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel9.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel9.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel9.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel9.BOSDescription = null;
            this.fld_lblLabel9.BOSError = null;
            this.fld_lblLabel9.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel9.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel9.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel9.BOSPropertyName = null;
            this.fld_lblLabel9.Location = new System.Drawing.Point(40, 91);
            this.fld_lblLabel9.Name = "fld_lblLabel9";
            this.fld_lblLabel9.Screen = null;
            this.fld_lblLabel9.Size = new System.Drawing.Size(38, 13);
            this.fld_lblLabel9.TabIndex = 19;
            this.fld_lblLabel9.Tag = "SI";
            this.fld_lblLabel9.Text = "Giới tính";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(40, 38);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(68, 13);
            this.fld_lblLabel4.TabIndex = 20;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Tên nhân viên";
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel11.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel11.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel11.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel11.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel11.BOSPropertyName = null;
            this.fld_lblLabel11.Location = new System.Drawing.Point(40, 117);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(44, 13);
            this.fld_lblLabel11.TabIndex = 24;
            this.fld_lblLabel11.Tag = "SI";
            this.fld_lblLabel11.Text = "Số CMND";
            // 
            // fld_dgcHREmployee
            // 
            this.fld_dgcHREmployee.AllowDrop = true;
            this.fld_dgcHREmployee.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployee.BOSDataMember = null;
            this.fld_dgcHREmployee.BOSDataSource = "HREmployees";
            this.fld_dgcHREmployee.BOSDescription = null;
            this.fld_dgcHREmployee.BOSError = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployee.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployee.BOSFieldRelation = null;
            this.fld_dgcHREmployee.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHREmployee.BOSPropertyName = null;
            this.fld_dgcHREmployee.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployee.Location = new System.Drawing.Point(40, 293);
            this.fld_dgcHREmployee.MainView = this.fld_dgvHREmployee;
            this.fld_dgcHREmployee.Name = "fld_dgcHREmployee";
            this.fld_dgcHREmployee.Screen = null;
            this.fld_dgcHREmployee.Size = new System.Drawing.Size(494, 258);
            this.fld_dgcHREmployee.TabIndex = 15;
            this.fld_dgcHREmployee.Tag = "SR";
            this.fld_dgcHREmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployee});
            // 
            // fld_dgvHREmployee
            // 
            this.fld_dgvHREmployee.GridControl = this.fld_dgcHREmployee;
            this.fld_dgvHREmployee.Name = "fld_dgvHREmployee";
            this.fld_dgvHREmployee.PaintStyleName = "Office2003";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(40, 64);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(32, 13);
            this.bosLabel1.TabIndex = 20;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Địa chỉ";
            // 
            // fld_txtHREmployeeContactAddressLine3
            // 
            this.fld_txtHREmployeeContactAddressLine3.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeeContactAddressLine3.BOSDataMember = "HREmployeeContactAddressLine3";
            this.fld_txtHREmployeeContactAddressLine3.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeContactAddressLine3.BOSDescription = null;
            this.fld_txtHREmployeeContactAddressLine3.BOSError = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeeContactAddressLine3.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeeContactAddressLine3.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeeContactAddressLine3.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHREmployeeContactAddressLine3.BOSPropertyName = "Text";
            this.fld_txtHREmployeeContactAddressLine3.Location = new System.Drawing.Point(134, 61);
            this.fld_txtHREmployeeContactAddressLine3.Name = "fld_txtHREmployeeContactAddressLine3";
            this.fld_txtHREmployeeContactAddressLine3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeContactAddressLine3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeContactAddressLine3.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeContactAddressLine3.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeContactAddressLine3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeContactAddressLine3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeContactAddressLine3.Screen = null;
            this.fld_txtHREmployeeContactAddressLine3.Size = new System.Drawing.Size(306, 20);
            this.fld_txtHREmployeeContactAddressLine3.TabIndex = 3;
            this.fld_txtHREmployeeContactAddressLine3.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(40, 221);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 24;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID1
            // 
            this.fld_lkeFK_BRBranchID1.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID1.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID1.BOSComment = null;
            this.fld_lkeFK_BRBranchID1.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID1.BOSDataSource = "HREmployees";
            this.fld_lkeFK_BRBranchID1.BOSDescription = null;
            this.fld_lkeFK_BRBranchID1.BOSError = null;
            this.fld_lkeFK_BRBranchID1.BOSFieldGroup = null;
            this.fld_lkeFK_BRBranchID1.BOSFieldParent = null;
            this.fld_lkeFK_BRBranchID1.BOSFieldRelation = null;
            this.fld_lkeFK_BRBranchID1.BOSPrivilege = null;
            this.fld_lkeFK_BRBranchID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID1.BOSSelectType = null;
            this.fld_lkeFK_BRBranchID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_BRBranchID1.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID1.Location = new System.Drawing.Point(134, 218);
            this.fld_lkeFK_BRBranchID1.MenuManager = this.screenToolbar;
            this.fld_lkeFK_BRBranchID1.Name = "fld_lkeFK_BRBranchID1";
            this.fld_lkeFK_BRBranchID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID1.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID1.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID1.Screen = null;
            this.fld_lkeFK_BRBranchID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID1.TabIndex = 9;
            this.fld_lkeFK_BRBranchID1.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(40, 143);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(51, 13);
            this.bosLabel3.TabIndex = 24;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Phòng ban";
            // 
            // fld_lkeFK_HRDepartmentRoomID1
            // 
            this.fld_lkeFK_HRDepartmentRoomID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSDataMember = "FK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID1.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRDepartmentRoomID1.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSFieldParent = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomID1.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomID1.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomID1.Location = new System.Drawing.Point(134, 140);
            this.fld_lkeFK_HRDepartmentRoomID1.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HRDepartmentRoomID1.Name = "fld_lkeFK_HRDepartmentRoomID1";
            this.fld_lkeFK_HRDepartmentRoomID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomID1.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeFK_HRDepartmentRoomID1.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID1.Screen = null;
            this.fld_lkeFK_HRDepartmentRoomID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRDepartmentRoomID1.TabIndex = 7;
            this.fld_lkeFK_HRDepartmentRoomID1.Tag = "SC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(40, 195);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(39, 13);
            this.bosLabel4.TabIndex = 24;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Cấp bậc";
            // 
            // fld_lkeFK_HRLevelID
            // 
            this.fld_lkeFK_HRLevelID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRLevelID.BOSAllowDummy = true;
            this.fld_lkeFK_HRLevelID.BOSComment = null;
            this.fld_lkeFK_HRLevelID.BOSDataMember = "FK_HRLevelID";
            this.fld_lkeFK_HRLevelID.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRLevelID.BOSDescription = null;
            this.fld_lkeFK_HRLevelID.BOSError = null;
            this.fld_lkeFK_HRLevelID.BOSFieldGroup = null;
            this.fld_lkeFK_HRLevelID.BOSFieldParent = null;
            this.fld_lkeFK_HRLevelID.BOSFieldRelation = null;
            this.fld_lkeFK_HRLevelID.BOSPrivilege = null;
            this.fld_lkeFK_HRLevelID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRLevelID.BOSSelectType = null;
            this.fld_lkeFK_HRLevelID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRLevelID.CurrentDisplayText = null;
            this.fld_lkeFK_HRLevelID.Location = new System.Drawing.Point(134, 192);
            this.fld_lkeFK_HRLevelID.Name = "fld_lkeFK_HRLevelID";
            this.fld_lkeFK_HRLevelID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRLevelID.Properties.DisplayMember = "HRLevelName";
            this.fld_lkeFK_HRLevelID.Properties.ValueMember = "HRLevelID";
            this.fld_lkeFK_HRLevelID.Screen = null;
            this.fld_lkeFK_HRLevelID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRLevelID.TabIndex = 8;
            this.fld_lkeFK_HRLevelID.Tag = "SC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(39, 169);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(49, 13);
            this.bosLabel5.TabIndex = 24;
            this.bosLabel5.Tag = "SI";
            this.bosLabel5.Text = "Tình trạng";
            // 
            // fld_lkeHREmployeeStatusCombo
            // 
            this.fld_lkeHREmployeeStatusCombo.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeStatusCombo.BOSAllowDummy = true;
            this.fld_lkeHREmployeeStatusCombo.BOSComment = null;
            this.fld_lkeHREmployeeStatusCombo.BOSDataMember = "HREmployeeStatusCombo";
            this.fld_lkeHREmployeeStatusCombo.BOSDataSource = "HREmployees";
            this.fld_lkeHREmployeeStatusCombo.BOSDescription = null;
            this.fld_lkeHREmployeeStatusCombo.BOSError = null;
            this.fld_lkeHREmployeeStatusCombo.BOSFieldGroup = null;
            this.fld_lkeHREmployeeStatusCombo.BOSFieldParent = null;
            this.fld_lkeHREmployeeStatusCombo.BOSFieldRelation = null;
            this.fld_lkeHREmployeeStatusCombo.BOSPrivilege = null;
            this.fld_lkeHREmployeeStatusCombo.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeStatusCombo.BOSSelectType = null;
            this.fld_lkeHREmployeeStatusCombo.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeeStatusCombo.CurrentDisplayText = null;
            this.fld_lkeHREmployeeStatusCombo.Location = new System.Drawing.Point(134, 166);
            this.fld_lkeHREmployeeStatusCombo.Name = "fld_lkeHREmployeeStatusCombo";
            this.fld_lkeHREmployeeStatusCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHREmployeeStatusCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHREmployeeStatusCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHREmployeeStatusCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHREmployeeStatusCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeStatusCombo.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHREmployeeStatusCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHREmployeeStatusCombo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeHREmployeeStatusCombo, true);
            this.fld_lkeHREmployeeStatusCombo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHREmployeeStatusCombo.TabIndex = 25;
            this.fld_lkeHREmployeeStatusCombo.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeePayrollFormulaID1
            // 
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSComment = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSDataMember = "FK_HREmployeePayrollFormulaID";
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSError = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSSelectType = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.Location = new System.Drawing.Point(134, 246);
            this.fld_lkeFK_HREmployeePayrollFormulaID1.Name = "fld_lkeFK_HREmployeePayrollFormulaID1";
            this.fld_lkeFK_HREmployeePayrollFormulaID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeePayrollFormulaID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeePayrollFormulaName", "Nhóm chấm công")});
            this.fld_lkeFK_HREmployeePayrollFormulaID1.Properties.DisplayMember = "HREmployeePayrollFormulaName";
            this.fld_lkeFK_HREmployeePayrollFormulaID1.Properties.ValueMember = "HREmployeePayrollFormulaID";
            this.fld_lkeFK_HREmployeePayrollFormulaID1.Screen = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeePayrollFormulaID1.TabIndex = 59;
            this.fld_lkeFK_HREmployeePayrollFormulaID1.Tag = "SC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(40, 249);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(81, 13);
            this.bosLabel6.TabIndex = 60;
            this.bosLabel6.Tag = "SI";
            this.bosLabel6.Text = "Nhóm chấm công";
            // 
            // SMST100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(590, 567);
            this.Controls.Add(this.fld_lkeFK_HREmployeePayrollFormulaID1);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.fld_lkeHREmployeeStatusCombo);
            this.Controls.Add(this.fld_lkeFK_HRLevelID);
            this.Controls.Add(this.fld_lkeFK_HRDepartmentRoomID1);
            this.Controls.Add(this.fld_lkeFK_BRBranchID1);
            this.Controls.Add(this.fld_txtHREmployeeNo1);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_txtHREmployeeFName1);
            this.Controls.Add(this.fld_dgcHREmployee);
            this.Controls.Add(this.fld_txtHREmployeeContactAddressLine3);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.fld_lblLabel9);
            this.Controls.Add(this.fld_txtHREmployeeIDNumber1);
            this.Controls.Add(this.fld_lkeHREmployeeGenderCombo1);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lblLabel11);
            this.Name = "SMST100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lkeHREmployeeGenderCombo1, 0);
            this.Controls.SetChildIndex(this.fld_txtHREmployeeIDNumber1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel9, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.fld_txtHREmployeeContactAddressLine3, 0);
            this.Controls.SetChildIndex(this.fld_dgcHREmployee, 0);
            this.Controls.SetChildIndex(this.fld_txtHREmployeeFName1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_txtHREmployeeNo1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HRDepartmentRoomID1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HRLevelID, 0);
            this.Controls.SetChildIndex(this.fld_lkeHREmployeeStatusCombo, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeePayrollFormulaID1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeFName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeGenderCombo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeIDNumber1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactAddressLine3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRLevelID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeStatusCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeePayrollFormulaID1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtHREmployeeContactAddressLine3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomID1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRLevelID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeStatusCombo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeePayrollFormulaID1;
        private BOSComponent.BOSLabel bosLabel6;
	}
}
