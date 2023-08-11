using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Project.UI
{
	/// <summary>
	/// Summary description for SMDE100
	/// </summary>
    partial class SMPM100
	{
		private BOSComponent.BOSLabel fld_lblLabel53;
        private BOSComponent.BOSLabel fld_lblLabel57;
		private BOSComponent.BOSTextBox fld_txtPMProjectName;
		private BOSComponent.BOSLabel fld_lblLabel51;
		private BOSComponent.BOSLabel fld_lblLabel58;
		private BOSSearchResultsGridControl fld_dgcPMProjects;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICDepartment;
        private BOSComponent.BOSTextBox fld_txtPMProjectNo;


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
            this.fld_txtPMProjectName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel51 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel58 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcPMProjects = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICDepartment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtPMProjectNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_PMProjectTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dtePMProjectToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dtePMProjectFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRProjectOwnerEmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRProjectOwnerEmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
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
            this.fld_lblLabel53.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel53.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel53.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel53.BOSDescription = null;
            this.fld_lblLabel53.BOSError = null;
            this.fld_lblLabel53.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel53.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel53.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel53.BOSPropertyName = null;
            this.fld_lblLabel53.Location = new System.Drawing.Point(47, 12);
            this.fld_lblLabel53.Name = "fld_lblLabel53";
            this.fld_lblLabel53.Screen = null;
            this.fld_lblLabel53.Size = new System.Drawing.Size(60, 13);
            this.fld_lblLabel53.TabIndex = 4;
            this.fld_lblLabel53.Tag = "SI";
            this.fld_lblLabel53.Text = "Mã chứng từ";
            // 
            // fld_lblLabel57
            // 
            this.fld_lblLabel57.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel57.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel57.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel57.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel57.Appearance.Options.UseFont = true;
            this.fld_lblLabel57.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel57.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel57.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel57.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel57.BOSDescription = null;
            this.fld_lblLabel57.BOSError = null;
            this.fld_lblLabel57.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel57.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel57.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel57.BOSPropertyName = null;
            this.fld_lblLabel57.Location = new System.Drawing.Point(47, 38);
            this.fld_lblLabel57.Name = "fld_lblLabel57";
            this.fld_lblLabel57.Screen = null;
            this.fld_lblLabel57.Size = new System.Drawing.Size(64, 13);
            this.fld_lblLabel57.TabIndex = 5;
            this.fld_lblLabel57.Tag = "SI";
            this.fld_lblLabel57.Text = "Tên chứng từ";
            // 
            // fld_txtPMProjectName
            // 
            this.fld_txtPMProjectName.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMProjectName.BOSDataMember = "PMProjectName";
            this.fld_txtPMProjectName.BOSDataSource = "PMProjects";
            this.fld_txtPMProjectName.BOSDescription = null;
            this.fld_txtPMProjectName.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMProjectName.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMProjectName.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMProjectName.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMProjectName.BOSPropertyName = "Text";
            this.fld_txtPMProjectName.Location = new System.Drawing.Point(121, 35);
            this.fld_txtPMProjectName.Name = "fld_txtPMProjectName";
            this.fld_txtPMProjectName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMProjectName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMProjectName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMProjectName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMProjectName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMProjectName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMProjectName.Screen = null;
            this.fld_txtPMProjectName.Size = new System.Drawing.Size(440, 20);
            this.fld_txtPMProjectName.TabIndex = 1;
            this.fld_txtPMProjectName.Tag = "SC";
            // 
            // fld_lblLabel51
            // 
            this.fld_lblLabel51.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel51.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel51.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel51.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel51.Appearance.Options.UseFont = true;
            this.fld_lblLabel51.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel51.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel51.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel51.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel51.BOSDescription = null;
            this.fld_lblLabel51.BOSError = null;
            this.fld_lblLabel51.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel51.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel51.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel51.BOSPropertyName = null;
            this.fld_lblLabel51.Location = new System.Drawing.Point(70, 135);
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
            this.fld_lblLabel58.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel58.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel58.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel58.BOSDescription = null;
            this.fld_lblLabel58.BOSError = null;
            this.fld_lblLabel58.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel58.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel58.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel58.BOSPropertyName = null;
            this.fld_lblLabel58.Location = new System.Drawing.Point(10, 99);
            this.fld_lblLabel58.Name = "fld_lblLabel58";
            this.fld_lblLabel58.Screen = null;
            this.fld_lblLabel58.Size = new System.Drawing.Size(0, 13);
            this.fld_lblLabel58.TabIndex = 66;
            this.fld_lblLabel58.Tag = "SI";
            // 
            // fld_dgcPMProjects
            // 
            this.fld_dgcPMProjects.AllowDrop = true;
            this.fld_dgcPMProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcPMProjects.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcPMProjects.BOSDataMember = null;
            this.fld_dgcPMProjects.BOSDataSource = "PMProjects";
            this.fld_dgcPMProjects.BOSDescription = null;
            this.fld_dgcPMProjects.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcPMProjects.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcPMProjects.BOSFieldRelation = null;
            this.fld_dgcPMProjects.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcPMProjects.BOSPropertyName = null;
            this.fld_dgcPMProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_dgcPMProjects.Location = new System.Drawing.Point(10, 165);
            this.fld_dgcPMProjects.MainView = this.fld_dgvICDepartment;
            this.fld_dgcPMProjects.Name = "fld_dgcPMProjects";
            this.fld_dgcPMProjects.Screen = null;
            this.fld_dgcPMProjects.Size = new System.Drawing.Size(641, 255);
            this.fld_dgcPMProjects.TabIndex = 6;
            this.fld_dgcPMProjects.Tag = "SR";
            this.fld_dgcPMProjects.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICDepartment});
            // 
            // fld_dgvICDepartment
            // 
            this.fld_dgvICDepartment.GridControl = this.fld_dgcPMProjects;
            this.fld_dgvICDepartment.Name = "fld_dgvICDepartment";
            this.fld_dgvICDepartment.PaintStyleName = "Office2003";
            // 
            // fld_txtPMProjectNo
            // 
            this.fld_txtPMProjectNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMProjectNo.BOSDataMember = "PMProjectNo";
            this.fld_txtPMProjectNo.BOSDataSource = "PMProjects";
            this.fld_txtPMProjectNo.BOSDescription = null;
            this.fld_txtPMProjectNo.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMProjectNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMProjectNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMProjectNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMProjectNo.BOSPropertyName = "Text";
            this.fld_txtPMProjectNo.Location = new System.Drawing.Point(121, 9);
            this.fld_txtPMProjectNo.Name = "fld_txtPMProjectNo";
            this.fld_txtPMProjectNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMProjectNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMProjectNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMProjectNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMProjectNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMProjectNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMProjectNo.Screen = null;
            this.fld_txtPMProjectNo.Size = new System.Drawing.Size(191, 20);
            this.fld_txtPMProjectNo.TabIndex = 0;
            this.fld_txtPMProjectNo.Tag = "SC";
            // 
            // fld_lkeFK_PMProjectTypeID
            // 
            this.fld_lkeFK_PMProjectTypeID.BOSAllowAddNew = false;
            this.fld_lkeFK_PMProjectTypeID.BOSAllowDummy = true;
            this.fld_lkeFK_PMProjectTypeID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID.BOSDataMember = "FK_PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID.BOSDataSource = "PMProjects";
            this.fld_lkeFK_PMProjectTypeID.BOSDescription = null;
            this.fld_lkeFK_PMProjectTypeID.BOSError = null;
            this.fld_lkeFK_PMProjectTypeID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_PMProjectTypeID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID.CurrentDisplayText = null;
            this.fld_lkeFK_PMProjectTypeID.Location = new System.Drawing.Point(121, 87);
            this.fld_lkeFK_PMProjectTypeID.Name = "fld_lkeFK_PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_PMProjectTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_PMProjectTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectTypeNo", "Mã loại dự án"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectTypeName", 300, "Tên Loại dự án")});
            this.fld_lkeFK_PMProjectTypeID.Properties.DisplayMember = "PMProjectTypeName";
            this.fld_lkeFK_PMProjectTypeID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_PMProjectTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_PMProjectTypeID.Properties.ValueMember = "PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID.Screen = null;
            this.fld_lkeFK_PMProjectTypeID.Size = new System.Drawing.Size(191, 20);
            this.fld_lkeFK_PMProjectTypeID.TabIndex = 3;
            this.fld_lkeFK_PMProjectTypeID.Tag = "SC";
            // 
            // fld_dtePMProjectToDate
            // 
            this.fld_dtePMProjectToDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dtePMProjectToDate.BOSDataMember = "PMProjectToDate";
            this.fld_dtePMProjectToDate.BOSDataSource = "PMProjects";
            this.fld_dtePMProjectToDate.BOSDescription = null;
            this.fld_dtePMProjectToDate.BOSError = null;
            this.fld_dtePMProjectToDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dtePMProjectToDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dtePMProjectToDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dtePMProjectToDate.BOSPropertyName = "EditValue";
            this.fld_dtePMProjectToDate.EditValue = null;
            this.fld_dtePMProjectToDate.Location = new System.Drawing.Point(374, 139);
            this.fld_dtePMProjectToDate.Name = "fld_dtePMProjectToDate";
            this.fld_dtePMProjectToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dtePMProjectToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dtePMProjectToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dtePMProjectToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dtePMProjectToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dtePMProjectToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dtePMProjectToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dtePMProjectToDate, true);
            this.fld_dtePMProjectToDate.Size = new System.Drawing.Size(187, 20);
            this.fld_dtePMProjectToDate.TabIndex = 6;
            this.fld_dtePMProjectToDate.Tag = "SC";
            // 
            // fld_dtePMProjectFromDate
            // 
            this.fld_dtePMProjectFromDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dtePMProjectFromDate.BOSDataMember = "PMProjectFromDate";
            this.fld_dtePMProjectFromDate.BOSDataSource = "PMProjects";
            this.fld_dtePMProjectFromDate.BOSDescription = null;
            this.fld_dtePMProjectFromDate.BOSError = null;
            this.fld_dtePMProjectFromDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dtePMProjectFromDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dtePMProjectFromDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dtePMProjectFromDate.BOSPropertyName = "EditValue";
            this.fld_dtePMProjectFromDate.EditValue = null;
            this.fld_dtePMProjectFromDate.Location = new System.Drawing.Point(121, 139);
            this.fld_dtePMProjectFromDate.Name = "fld_dtePMProjectFromDate";
            this.fld_dtePMProjectFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dtePMProjectFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dtePMProjectFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dtePMProjectFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dtePMProjectFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dtePMProjectFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dtePMProjectFromDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dtePMProjectFromDate, true);
            this.fld_dtePMProjectFromDate.Size = new System.Drawing.Size(191, 20);
            this.fld_dtePMProjectFromDate.TabIndex = 5;
            this.fld_dtePMProjectFromDate.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(47, 90);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(50, 13);
            this.bosLabel3.TabIndex = 133;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Loại dự án";
            // 
            // fld_lkeFK_HRProjectOwnerEmployeeID1
            // 
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.BOSDataMember = "FK_HRProjectOwnerEmployeeID";
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.BOSDataSource = "PMProjects";
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.BOSError = null;
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.Location = new System.Drawing.Point(121, 113);
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.Name = "fld_lkeFK_HRProjectOwnerEmployeeID1";
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.tutu, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRProjectOwnerEmployeeID1, true);
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.Size = new System.Drawing.Size(191, 20);
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.TabIndex = 4;
            this.fld_lkeFK_HRProjectOwnerEmployeeID1.Tag = "SC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseFont = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(47, 116);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(65, 13);
            this.bosLabel4.TabIndex = 135;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Quản lí dự án";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.Location = new System.Drawing.Point(47, 64);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(48, 13);
            this.bosLabel5.TabIndex = 137;
            this.bosLabel5.Tag = "SI";
            this.bosLabel5.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "PMProjects";
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
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(121, 61);
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
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(191, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 2;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.Location = new System.Drawing.Point(318, 142);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(47, 13);
            this.bosLabel1.TabIndex = 138;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Đến ngày";
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
            this.bosLabel2.Location = new System.Drawing.Point(47, 142);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(40, 13);
            this.bosLabel2.TabIndex = 139;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Từ ngày";
            // 
            // SMPM100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(663, 432);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_lkeFK_HRProjectOwnerEmployeeID1);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_dtePMProjectFromDate);
            this.Controls.Add(this.fld_dtePMProjectToDate);
            this.Controls.Add(this.fld_lkeFK_PMProjectTypeID);
            this.Controls.Add(this.fld_lblLabel53);
            this.Controls.Add(this.fld_lblLabel51);
            this.Controls.Add(this.fld_lblLabel58);
            this.Controls.Add(this.fld_lblLabel57);
            this.Controls.Add(this.fld_txtPMProjectName);
            this.Controls.Add(this.fld_dgcPMProjects);
            this.Controls.Add(this.fld_txtPMProjectNo);
            this.Name = "SMPM100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtPMProjectNo, 0);
            this.Controls.SetChildIndex(this.fld_dgcPMProjects, 0);
            this.Controls.SetChildIndex(this.fld_txtPMProjectName, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel57, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel58, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel51, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel53, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_PMProjectTypeID, 0);
            this.Controls.SetChildIndex(this.fld_dtePMProjectToDate, 0);
            this.Controls.SetChildIndex(this.fld_dtePMProjectFromDate, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HRProjectOwnerEmployeeID1, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMProjectFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRProjectOwnerEmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectTypeID;
        private BOSComponent.BOSDateEdit fld_dtePMProjectToDate;
        private BOSComponent.BOSDateEdit fld_dtePMProjectFromDate;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRProjectOwnerEmployeeID1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
	}
}
