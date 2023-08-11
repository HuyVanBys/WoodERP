using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.RegisterDormitory.UI
{
	/// <summary>
    /// Summary description for SMRD100
	/// </summary>
    partial class SMRD100
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
            this.fld_dgcHRRegisterDormitorys = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRRegisterDormitoryNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDormitoryID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRRegisterDormitorys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRegisterDormitoryNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDormitoryID1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcHRRegisterDormitorys
            // 
            this.fld_dgcHRRegisterDormitorys.BOSComment = null;
            this.fld_dgcHRRegisterDormitorys.BOSDataMember = null;
            this.fld_dgcHRRegisterDormitorys.BOSDataSource = "HRRegisterDormitorys";
            this.fld_dgcHRRegisterDormitorys.BOSDescription = null;
            this.fld_dgcHRRegisterDormitorys.BOSError = null;
            this.fld_dgcHRRegisterDormitorys.BOSFieldGroup = null;
            this.fld_dgcHRRegisterDormitorys.BOSFieldRelation = null;
            this.fld_dgcHRRegisterDormitorys.BOSPrivilege = null;
            this.fld_dgcHRRegisterDormitorys.BOSPropertyName = null;
            this.fld_dgcHRRegisterDormitorys.Location = new System.Drawing.Point(38, 185);
            this.fld_dgcHRRegisterDormitorys.MenuManager = this.screenToolbar;
            this.fld_dgcHRRegisterDormitorys.Name = "fld_dgcHRRegisterDormitorys";
            this.fld_dgcHRRegisterDormitorys.Screen = null;
            this.fld_dgcHRRegisterDormitorys.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRRegisterDormitorys.TabIndex = 101;
            this.fld_dgcHRRegisterDormitorys.Tag = "SR";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.Location = new System.Drawing.Point(38, 29);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 99;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_txtHRRegisterDormitoryNo
            // 
            this.fld_txtHRRegisterDormitoryNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRRegisterDormitoryNo.BOSDataMember = "HRRegisterDormitoryNo";
            this.fld_txtHRRegisterDormitoryNo.BOSDataSource = "HRRegisterDormitorys";
            this.fld_txtHRRegisterDormitoryNo.BOSDescription = null;
            this.fld_txtHRRegisterDormitoryNo.BOSError = null;
            this.fld_txtHRRegisterDormitoryNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRRegisterDormitoryNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRRegisterDormitoryNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRRegisterDormitoryNo.BOSPropertyName = "Text";
            this.fld_txtHRRegisterDormitoryNo.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRRegisterDormitoryNo.Location = new System.Drawing.Point(123, 26);
            this.fld_txtHRRegisterDormitoryNo.Name = "fld_txtHRRegisterDormitoryNo";
            this.fld_txtHRRegisterDormitoryNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRRegisterDormitoryNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRRegisterDormitoryNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRRegisterDormitoryNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRRegisterDormitoryNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRRegisterDormitoryNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRRegisterDormitoryNo.Screen = null;
            this.fld_txtHRRegisterDormitoryNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRRegisterDormitoryNo.TabIndex = 97;
            this.fld_txtHRRegisterDormitoryNo.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.Location = new System.Drawing.Point(38, 55);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 103;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "HRRegisterDormitorys";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(123, 52);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 102;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // fld_lblLabel13
            // 
            this.fld_lblLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel13.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel13.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel13.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel13.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel13.BOSDescription = null;
            this.fld_lblLabel13.BOSError = null;
            this.fld_lblLabel13.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel13.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel13.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel13.BOSPropertyName = null;
            this.fld_lblLabel13.Location = new System.Drawing.Point(38, 81);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel13.TabIndex = 105;
            this.fld_lblLabel13.Tag = "SI";
            this.fld_lblLabel13.Text = "Nhân viên";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "HRRegisterDormitorys";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(123, 78);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.tutu, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 104;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // fld_lkeFK_HRDormitoryID1
            // 
            this.fld_lkeFK_HRDormitoryID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDormitoryID1.BOSAllowDummy = false;
            this.fld_lkeFK_HRDormitoryID1.BOSComment = null;
            this.fld_lkeFK_HRDormitoryID1.BOSDataMember = "FK_HRDormitoryID";
            this.fld_lkeFK_HRDormitoryID1.BOSDataSource = "HRregisterDormitorys";
            this.fld_lkeFK_HRDormitoryID1.BOSDescription = null;
            this.fld_lkeFK_HRDormitoryID1.BOSError = null;
            this.fld_lkeFK_HRDormitoryID1.BOSFieldGroup = null;
            this.fld_lkeFK_HRDormitoryID1.BOSFieldParent = null;
            this.fld_lkeFK_HRDormitoryID1.BOSFieldRelation = null;
            this.fld_lkeFK_HRDormitoryID1.BOSPrivilege = null;
            this.fld_lkeFK_HRDormitoryID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDormitoryID1.BOSSelectType = null;
            this.fld_lkeFK_HRDormitoryID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDormitoryID1.CurrentDisplayText = null;
            this.fld_lkeFK_HRDormitoryID1.Location = new System.Drawing.Point(123, 104);
            this.fld_lkeFK_HRDormitoryID1.Name = "fld_lkeFK_HRDormitoryID1";
            this.fld_lkeFK_HRDormitoryID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDormitoryID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDormitoryID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDormitoryID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDormitoryID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDormitoryID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDormitoryNo", "Mã phòng trọ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDormitoryName", "Tên phòng trọ")});
            this.fld_lkeFK_HRDormitoryID1.Properties.DisplayMember = "HRDormitoryName";
            this.fld_lkeFK_HRDormitoryID1.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HRDormitoryID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDormitoryID1.Properties.ValueMember = "HRDormitoryID";
            this.fld_lkeFK_HRDormitoryID1.Screen = null;
            this.fld_lkeFK_HRDormitoryID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRDormitoryID1.TabIndex = 107;
            this.fld_lkeFK_HRDormitoryID1.Tag = "SC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(38, 107);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(47, 13);
            this.bosLabel1.TabIndex = 106;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Phòng trọ";
            // 
            // SMRD100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_lkeFK_HRDormitoryID1);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel13);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_dgcHRRegisterDormitorys);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_txtHRRegisterDormitoryNo);
            this.Name = "SMRD100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtHRRegisterDormitoryNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRRegisterDormitorys, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel13, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HRDormitoryID1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRRegisterDormitorys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRegisterDormitoryNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDormitoryID1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcHRRegisterDormitorys;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSTextBox fld_txtHRRegisterDormitoryNo;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel fld_lblLabel13;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDormitoryID1;
        private BOSComponent.BOSLabel bosLabel1;
	}
}
