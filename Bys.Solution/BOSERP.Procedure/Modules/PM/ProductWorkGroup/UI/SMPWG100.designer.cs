using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductWorkGroup.UI
{
	/// <summary>
    /// Summary description for SMPWG100
	/// </summary>
    partial class SMPWG100
	{
		private BOSComponent.BOSLabel fld_lblLabel53;
        private BOSComponent.BOSLabel fld_lblLabel57;
		private BOSComponent.BOSTextBox fld_txtICProductWorkGroupName;
		private BOSComponent.BOSLabel fld_lblLabel51;
        private BOSComponent.BOSLabel fld_lblLabel58;
        private BOSComponent.BOSTextBox fld_txtICProductWorkGroupNo;


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
            this.fld_lblLabel53 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel57 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductWorkGroupName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel51 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel58 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductWorkGroupNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_PMProjectTypeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_PMPhaseTypeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcICProductWorkGroups = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICDepartment = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWorkGroupName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWorkGroupNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectTypeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMPhaseTypeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductWorkGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel53
            // 
            this.fld_lblLabel53.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel53.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel53.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel53.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel53.Appearance.Options.UseFont = true;
            this.fld_lblLabel53.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel53.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel53.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel53.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel53.BOSDescription = null;
            this.fld_lblLabel53.BOSError = null;
            this.fld_lblLabel53.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel53.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel53.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel53.BOSPropertyName = null;
            this.fld_lblLabel53.Location = new System.Drawing.Point(47, 12);
            this.fld_lblLabel53.Name = "fld_lblLabel53";
            this.fld_lblLabel53.Screen = null;
            this.fld_lblLabel53.Size = new System.Drawing.Size(94, 13);
            this.fld_lblLabel53.TabIndex = 4;
            this.fld_lblLabel53.Tag = "SI";
            this.fld_lblLabel53.Text = "Mã nhóm công việc";
            // 
            // fld_lblLabel57
            // 
            this.fld_lblLabel57.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel57.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel57.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel57.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel57.Appearance.Options.UseFont = true;
            this.fld_lblLabel57.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel57.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel57.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel57.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel57.BOSDescription = null;
            this.fld_lblLabel57.BOSError = null;
            this.fld_lblLabel57.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel57.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel57.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel57.BOSPropertyName = null;
            this.fld_lblLabel57.Location = new System.Drawing.Point(47, 38);
            this.fld_lblLabel57.Name = "fld_lblLabel57";
            this.fld_lblLabel57.Screen = null;
            this.fld_lblLabel57.Size = new System.Drawing.Size(98, 13);
            this.fld_lblLabel57.TabIndex = 5;
            this.fld_lblLabel57.Tag = "SI";
            this.fld_lblLabel57.Text = "Tên nhóm công việc";
            // 
            // fld_txtICProductWorkGroupName
            // 
            this.fld_txtICProductWorkGroupName.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductWorkGroupName.BOSDataMember = "ICProductWorkGroupName";
            this.fld_txtICProductWorkGroupName.BOSDataSource = "ICProductWorkGroups";
            this.fld_txtICProductWorkGroupName.BOSDescription = null;
            this.fld_txtICProductWorkGroupName.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductWorkGroupName.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductWorkGroupName.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductWorkGroupName.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductWorkGroupName.BOSPropertyName = "Text";
            this.fld_txtICProductWorkGroupName.Location = new System.Drawing.Point(151, 35);
            this.fld_txtICProductWorkGroupName.Name = "fld_txtICProductWorkGroupName";
            this.fld_txtICProductWorkGroupName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductWorkGroupName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductWorkGroupName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductWorkGroupName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductWorkGroupName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductWorkGroupName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductWorkGroupName.Screen = null;
            this.fld_txtICProductWorkGroupName.Size = new System.Drawing.Size(363, 20);
            this.fld_txtICProductWorkGroupName.TabIndex = 2;
            this.fld_txtICProductWorkGroupName.Tag = "SC";
            // 
            // fld_lblLabel51
            // 
            this.fld_lblLabel51.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel51.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel51.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel51.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel51.Appearance.Options.UseFont = true;
            this.fld_lblLabel51.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel51.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel51.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel51.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel51.BOSDescription = null;
            this.fld_lblLabel51.BOSError = null;
            this.fld_lblLabel51.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel51.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel51.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel51.BOSPropertyName = null;
            this.fld_lblLabel51.Location = new System.Drawing.Point(70, 85);
            this.fld_lblLabel51.Name = "fld_lblLabel51";
            this.fld_lblLabel51.Screen = null;
            this.fld_lblLabel51.Size = new System.Drawing.Size(0, 13);
            this.fld_lblLabel51.TabIndex = 65;
            this.fld_lblLabel51.Tag = "SI";
            // 
            // fld_lblLabel58
            // 
            this.fld_lblLabel58.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel58.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel58.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel58.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel58.Appearance.Options.UseFont = true;
            this.fld_lblLabel58.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel58.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel58.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel58.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel58.BOSDescription = null;
            this.fld_lblLabel58.BOSError = null;
            this.fld_lblLabel58.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel58.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel58.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel58.BOSPropertyName = null;
            this.fld_lblLabel58.Location = new System.Drawing.Point(10, 99);
            this.fld_lblLabel58.Name = "fld_lblLabel58";
            this.fld_lblLabel58.Screen = null;
            this.fld_lblLabel58.Size = new System.Drawing.Size(0, 13);
            this.fld_lblLabel58.TabIndex = 66;
            this.fld_lblLabel58.Tag = "SI";
            // 
            // fld_txtICProductWorkGroupNo
            // 
            this.fld_txtICProductWorkGroupNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductWorkGroupNo.BOSDataMember = "ICProductWorkGroupNo";
            this.fld_txtICProductWorkGroupNo.BOSDataSource = "ICProductWorkGroups";
            this.fld_txtICProductWorkGroupNo.BOSDescription = null;
            this.fld_txtICProductWorkGroupNo.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductWorkGroupNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductWorkGroupNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductWorkGroupNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductWorkGroupNo.BOSPropertyName = "Text";
            this.fld_txtICProductWorkGroupNo.Location = new System.Drawing.Point(151, 9);
            this.fld_txtICProductWorkGroupNo.Name = "fld_txtICProductWorkGroupNo";
            this.fld_txtICProductWorkGroupNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductWorkGroupNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductWorkGroupNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductWorkGroupNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductWorkGroupNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductWorkGroupNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductWorkGroupNo.Screen = null;
            this.fld_txtICProductWorkGroupNo.Size = new System.Drawing.Size(191, 20);
            this.fld_txtICProductWorkGroupNo.TabIndex = 1;
            this.fld_txtICProductWorkGroupNo.Tag = "SC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(47, 64);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(50, 13);
            this.bosLabel1.TabIndex = 67;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Loại dự án";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(47, 90);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(46, 13);
            this.bosLabel2.TabIndex = 68;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Giai đoạn";
            // 
            // fld_lkeFK_PMProjectTypeID1
            // 
            this.fld_lkeFK_PMProjectTypeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_PMProjectTypeID1.BOSAllowDummy = true;
            this.fld_lkeFK_PMProjectTypeID1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID1.BOSDataMember = "FK_PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID1.BOSDataSource = "ICProductWorkGroups";
            this.fld_lkeFK_PMProjectTypeID1.BOSDescription = null;
            this.fld_lkeFK_PMProjectTypeID1.BOSError = null;
            this.fld_lkeFK_PMProjectTypeID1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID1.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_PMProjectTypeID1.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID1.CurrentDisplayText = null;
            this.fld_lkeFK_PMProjectTypeID1.Location = new System.Drawing.Point(151, 61);
            this.fld_lkeFK_PMProjectTypeID1.Name = "fld_lkeFK_PMProjectTypeID1";
            this.fld_lkeFK_PMProjectTypeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_PMProjectTypeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_PMProjectTypeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_PMProjectTypeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_PMProjectTypeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_PMProjectTypeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectTypeName", 300, "Tên Loại dự án")});
            this.fld_lkeFK_PMProjectTypeID1.Properties.DisplayMember = "PMProjectTypeName";
            this.fld_lkeFK_PMProjectTypeID1.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_PMProjectTypeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_PMProjectTypeID1.Properties.ValueMember = "PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID1.Screen = null;
            this.fld_lkeFK_PMProjectTypeID1.Size = new System.Drawing.Size(191, 20);
            this.fld_lkeFK_PMProjectTypeID1.TabIndex = 71;
            this.fld_lkeFK_PMProjectTypeID1.Tag = "SC";
            // 
            // fld_lkeFK_PMPhaseTypeID1
            // 
            this.fld_lkeFK_PMPhaseTypeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_PMPhaseTypeID1.BOSAllowDummy = true;
            this.fld_lkeFK_PMPhaseTypeID1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMPhaseTypeID1.BOSDataMember = "FK_PMPhaseTypeID";
            this.fld_lkeFK_PMPhaseTypeID1.BOSDataSource = "ICProductWorkGroups";
            this.fld_lkeFK_PMPhaseTypeID1.BOSDescription = null;
            this.fld_lkeFK_PMPhaseTypeID1.BOSError = null;
            this.fld_lkeFK_PMPhaseTypeID1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMPhaseTypeID1.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMPhaseTypeID1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMPhaseTypeID1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMPhaseTypeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_PMPhaseTypeID1.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMPhaseTypeID1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMPhaseTypeID1.CurrentDisplayText = null;
            this.fld_lkeFK_PMPhaseTypeID1.Location = new System.Drawing.Point(151, 87);
            this.fld_lkeFK_PMPhaseTypeID1.Name = "fld_lkeFK_PMPhaseTypeID1";
            this.fld_lkeFK_PMPhaseTypeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_PMPhaseTypeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_PMPhaseTypeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_PMPhaseTypeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_PMPhaseTypeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_PMPhaseTypeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMPhaseTypeNo", "Mã giai đoạn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMPhaseTypeName", 300, "Tên giai đoạn")});
            this.fld_lkeFK_PMPhaseTypeID1.Properties.DisplayMember = "PMPhaseTypeName";
            this.fld_lkeFK_PMPhaseTypeID1.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMPhaseTypeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_PMPhaseTypeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_PMPhaseTypeID1.Properties.ValueMember = "PMPhaseTypeID";
            this.fld_lkeFK_PMPhaseTypeID1.Screen = null;
            this.fld_lkeFK_PMPhaseTypeID1.Size = new System.Drawing.Size(191, 20);
            this.fld_lkeFK_PMPhaseTypeID1.TabIndex = 72;
            this.fld_lkeFK_PMPhaseTypeID1.Tag = "SC";
            // 
            // fld_dgcICProductWorkGroups
            // 
            this.fld_dgcICProductWorkGroups.AllowDrop = true;
            this.fld_dgcICProductWorkGroups.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProductWorkGroups.BOSDataMember = null;
            this.fld_dgcICProductWorkGroups.BOSDataSource = "ICProductWorkGroups";
            this.fld_dgcICProductWorkGroups.BOSDescription = null;
            this.fld_dgcICProductWorkGroups.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProductWorkGroups.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProductWorkGroups.BOSFieldRelation = null;
            this.fld_dgcICProductWorkGroups.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProductWorkGroups.BOSPropertyName = null;
            this.fld_dgcICProductWorkGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_dgcICProductWorkGroups.Location = new System.Drawing.Point(48, 135);
            this.fld_dgcICProductWorkGroups.MainView = this.fld_dgvICDepartment;
            this.fld_dgcICProductWorkGroups.Name = "fld_dgcICProductWorkGroups";
            this.fld_dgcICProductWorkGroups.Screen = null;
            this.fld_dgcICProductWorkGroups.Size = new System.Drawing.Size(567, 354);
            this.fld_dgcICProductWorkGroups.TabIndex = 73;
            this.fld_dgcICProductWorkGroups.Tag = "SR";
            this.fld_dgcICProductWorkGroups.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICDepartment});
            // 
            // fld_dgvICDepartment
            // 
            this.fld_dgvICDepartment.GridControl = this.fld_dgcICProductWorkGroups;
            this.fld_dgvICDepartment.Name = "fld_dgvICDepartment";
            this.fld_dgvICDepartment.PaintStyleName = "Office2003";
            // 
            // SMPWG100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(663, 567);
            this.Controls.Add(this.fld_dgcICProductWorkGroups);
            this.Controls.Add(this.fld_lkeFK_PMPhaseTypeID1);
            this.Controls.Add(this.fld_lkeFK_PMProjectTypeID1);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel53);
            this.Controls.Add(this.fld_lblLabel51);
            this.Controls.Add(this.fld_lblLabel58);
            this.Controls.Add(this.fld_lblLabel57);
            this.Controls.Add(this.fld_txtICProductWorkGroupName);
            this.Controls.Add(this.fld_txtICProductWorkGroupNo);
            this.Name = "SMPWG100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtICProductWorkGroupNo, 0);
            this.Controls.SetChildIndex(this.fld_txtICProductWorkGroupName, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel57, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel58, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel51, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel53, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_PMProjectTypeID1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_PMPhaseTypeID1, 0);
            this.Controls.SetChildIndex(this.fld_dgcICProductWorkGroups, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWorkGroupName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWorkGroupNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectTypeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMPhaseTypeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductWorkGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectTypeID1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMPhaseTypeID1;
        private BOSSearchResultsGridControl fld_dgcICProductWorkGroups;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICDepartment;
	}
}
