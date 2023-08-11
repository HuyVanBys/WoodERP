using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.BugManagement.UI
{
	/// <summary>
    /// Summary description for SMBM100
	/// </summary>
    partial class SMBM100
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
            this.fld_dgcHRBugManagements = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRBugManagementNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteMMProductionCostFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteMMProductionCostToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRBugManagements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRBugManagementNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostToDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcHRBugManagements
            // 
            this.fld_dgcHRBugManagements.BOSComment = null;
            this.fld_dgcHRBugManagements.BOSDataMember = null;
            this.fld_dgcHRBugManagements.BOSDataSource = "HRBugManagements";
            this.fld_dgcHRBugManagements.BOSDescription = null;
            this.fld_dgcHRBugManagements.BOSError = null;
            this.fld_dgcHRBugManagements.BOSFieldGroup = null;
            this.fld_dgcHRBugManagements.BOSFieldRelation = null;
            this.fld_dgcHRBugManagements.BOSPrivilege = null;
            this.fld_dgcHRBugManagements.BOSPropertyName = null;
            this.fld_dgcHRBugManagements.Location = new System.Drawing.Point(38, 185);
            this.fld_dgcHRBugManagements.MenuManager = this.screenToolbar;
            this.fld_dgcHRBugManagements.Name = "fld_dgcHRBugManagements";
            this.fld_dgcHRBugManagements.Screen = null;
            this.fld_dgcHRBugManagements.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRBugManagements.TabIndex = 101;
            this.fld_dgcHRBugManagements.Tag = "SR";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.Location = new System.Drawing.Point(37, 29);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 99;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_txtHRBugManagementNo
            // 
            this.fld_txtHRBugManagementNo.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtHRBugManagementNo.BOSDataMember = "HRBugManagementNo";
            this.fld_txtHRBugManagementNo.BOSDataSource = "HRBugManagements";
            this.fld_txtHRBugManagementNo.BOSDescription = null;
            this.fld_txtHRBugManagementNo.BOSError = null;
            this.fld_txtHRBugManagementNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtHRBugManagementNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtHRBugManagementNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtHRBugManagementNo.BOSPropertyName = "Text";
            this.fld_txtHRBugManagementNo.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtHRBugManagementNo.Location = new System.Drawing.Point(123, 26);
            this.fld_txtHRBugManagementNo.Name = "fld_txtHRBugManagementNo";
            this.fld_txtHRBugManagementNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRBugManagementNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRBugManagementNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRBugManagementNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRBugManagementNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRBugManagementNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRBugManagementNo.Screen = null;
            this.fld_txtHRBugManagementNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRBugManagementNo.TabIndex = 97;
            this.fld_txtHRBugManagementNo.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.Location = new System.Drawing.Point(37, 55);
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
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSDataSource = "HRBugManagements";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(123, 52);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
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
            this.fld_lblLabel13.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel13.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel13.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel13.BOSDescription = null;
            this.fld_lblLabel13.BOSError = null;
            this.fld_lblLabel13.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel13.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel13.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel13.BOSPropertyName = null;
            this.fld_lblLabel13.Location = new System.Drawing.Point(37, 81);
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
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "HRBugManagements";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(123, 78);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.CommonLocalizedResources.String2, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 104;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // fld_dteMMProductionCostFromDate
            // 
            this.fld_dteMMProductionCostFromDate.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProductionCostFromDate.BOSDataMember = "HRBugManagementFromDate";
            this.fld_dteMMProductionCostFromDate.BOSDataSource = "HRBugManagements";
            this.fld_dteMMProductionCostFromDate.BOSDescription = null;
            this.fld_dteMMProductionCostFromDate.BOSError = null;
            this.fld_dteMMProductionCostFromDate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProductionCostFromDate.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProductionCostFromDate.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProductionCostFromDate.BOSPropertyName = "EditValue";
            this.fld_dteMMProductionCostFromDate.EditValue = null;
            this.fld_dteMMProductionCostFromDate.Location = new System.Drawing.Point(123, 108);
            this.fld_dteMMProductionCostFromDate.Name = "fld_dteMMProductionCostFromDate";
            this.fld_dteMMProductionCostFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMProductionCostFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMProductionCostFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMProductionCostFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMProductionCostFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMProductionCostFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMProductionCostFromDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteMMProductionCostFromDate, true);
            this.fld_dteMMProductionCostFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMProductionCostFromDate.TabIndex = 377;
            this.fld_dteMMProductionCostFromDate.Tag = "SC";
            // 
            // fld_dteMMProductionCostToDate
            // 
            this.fld_dteMMProductionCostToDate.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProductionCostToDate.BOSDataMember = "HRBugManagementToDate";
            this.fld_dteMMProductionCostToDate.BOSDataSource = "HRBugManagements";
            this.fld_dteMMProductionCostToDate.BOSDescription = null;
            this.fld_dteMMProductionCostToDate.BOSError = null;
            this.fld_dteMMProductionCostToDate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProductionCostToDate.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProductionCostToDate.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMProductionCostToDate.BOSPropertyName = "EditValue";
            this.fld_dteMMProductionCostToDate.EditValue = null;
            this.fld_dteMMProductionCostToDate.Location = new System.Drawing.Point(376, 108);
            this.fld_dteMMProductionCostToDate.Name = "fld_dteMMProductionCostToDate";
            this.fld_dteMMProductionCostToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMProductionCostToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMProductionCostToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMProductionCostToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMProductionCostToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMProductionCostToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMProductionCostToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteMMProductionCostToDate, true);
            this.fld_dteMMProductionCostToDate.Size = new System.Drawing.Size(149, 20);
            this.fld_dteMMProductionCostToDate.TabIndex = 378;
            this.fld_dteMMProductionCostToDate.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(37, 111);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(39, 13);
            this.bosLabel3.TabIndex = 380;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Từ ngày";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(310, 111);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(46, 13);
            this.bosLabel1.TabIndex = 379;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Đến ngày";
            // 
            // SMBM100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dteMMProductionCostFromDate);
            this.Controls.Add(this.fld_dteMMProductionCostToDate);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel13);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_dgcHRBugManagements);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_txtHRBugManagementNo);
            this.Name = "SMBM100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtHRBugManagementNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRBugManagements, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel13, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_dteMMProductionCostToDate, 0);
            this.Controls.SetChildIndex(this.fld_dteMMProductionCostFromDate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRBugManagements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRBugManagementNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostToDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcHRBugManagements;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSTextBox fld_txtHRBugManagementNo;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel fld_lblLabel13;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSDateEdit fld_dteMMProductionCostFromDate;
        private BOSComponent.BOSDateEdit fld_dteMMProductionCostToDate;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel1;
	}
}
