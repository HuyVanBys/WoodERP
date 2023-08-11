using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Template.UI
{
	/// <summary>
	/// Summary description for SMDE100
	/// </summary>
    partial class SMPMTP100
	{
		private BOSComponent.BOSLabel fld_lblLabel53;
        private BOSComponent.BOSLabel fld_lblLabel57;
		private BOSComponent.BOSTextBox fld_txtPMTemplateName;
		private BOSComponent.BOSLabel fld_lblLabel51;
		private BOSComponent.BOSLabel fld_lblLabel58;
		private BOSSearchResultsGridControl fld_dgcPMTemplate;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICDepartment;
        private BOSComponent.BOSTextBox fld_txtPMTemplateNo;


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
            this.fld_txtPMTemplateName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel51 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel58 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcPMTemplate = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICDepartment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtPMTemplateNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_PMProjectTypeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dtePMTemplateToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dtePMTemplateFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMTemplateName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMTemplateNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectTypeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMTemplateToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMTemplateToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMTemplateFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMTemplateFromDate.Properties)).BeginInit();
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
            // fld_txtPMTemplateName
            // 
            this.fld_txtPMTemplateName.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMTemplateName.BOSDataMember = "PMTemplateName";
            this.fld_txtPMTemplateName.BOSDataSource = "PMTemplates";
            this.fld_txtPMTemplateName.BOSDescription = null;
            this.fld_txtPMTemplateName.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMTemplateName.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMTemplateName.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMTemplateName.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMTemplateName.BOSPropertyName = "Text";
            this.fld_txtPMTemplateName.Location = new System.Drawing.Point(121, 35);
            this.fld_txtPMTemplateName.Name = "fld_txtPMTemplateName";
            this.fld_txtPMTemplateName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMTemplateName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMTemplateName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMTemplateName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMTemplateName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMTemplateName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMTemplateName.Screen = null;
            this.fld_txtPMTemplateName.Size = new System.Drawing.Size(451, 20);
            this.fld_txtPMTemplateName.TabIndex = 1;
            this.fld_txtPMTemplateName.Tag = "SC";
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
            this.fld_lblLabel51.Location = new System.Drawing.Point(70, 111);
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
            // fld_dgcPMTemplate
            // 
            this.fld_dgcPMTemplate.AllowDrop = true;
            this.fld_dgcPMTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcPMTemplate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcPMTemplate.BOSDataMember = null;
            this.fld_dgcPMTemplate.BOSDataSource = "PMTemplates";
            this.fld_dgcPMTemplate.BOSDescription = null;
            this.fld_dgcPMTemplate.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcPMTemplate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcPMTemplate.BOSFieldRelation = null;
            this.fld_dgcPMTemplate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcPMTemplate.BOSPropertyName = null;
            this.fld_dgcPMTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_dgcPMTemplate.Location = new System.Drawing.Point(12, 154);
            this.fld_dgcPMTemplate.MainView = this.fld_dgvICDepartment;
            this.fld_dgcPMTemplate.Name = "fld_dgcPMTemplate";
            this.fld_dgcPMTemplate.Screen = null;
            this.fld_dgcPMTemplate.Size = new System.Drawing.Size(641, 270);
            this.fld_dgcPMTemplate.TabIndex = 6;
            this.fld_dgcPMTemplate.Tag = "SR";
            this.fld_dgcPMTemplate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICDepartment});
            // 
            // fld_dgvICDepartment
            // 
            this.fld_dgvICDepartment.GridControl = this.fld_dgcPMTemplate;
            this.fld_dgvICDepartment.Name = "fld_dgvICDepartment";
            this.fld_dgvICDepartment.PaintStyleName = "Office2003";
            // 
            // fld_txtPMTemplateNo
            // 
            this.fld_txtPMTemplateNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMTemplateNo.BOSDataMember = "PMTemplateNo";
            this.fld_txtPMTemplateNo.BOSDataSource = "PMTemplates";
            this.fld_txtPMTemplateNo.BOSDescription = null;
            this.fld_txtPMTemplateNo.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMTemplateNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMTemplateNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMTemplateNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtPMTemplateNo.BOSPropertyName = "Text";
            this.fld_txtPMTemplateNo.Location = new System.Drawing.Point(121, 9);
            this.fld_txtPMTemplateNo.Name = "fld_txtPMTemplateNo";
            this.fld_txtPMTemplateNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMTemplateNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMTemplateNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMTemplateNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMTemplateNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMTemplateNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMTemplateNo.Screen = null;
            this.fld_txtPMTemplateNo.Size = new System.Drawing.Size(191, 20);
            this.fld_txtPMTemplateNo.TabIndex = 0;
            this.fld_txtPMTemplateNo.Tag = "SC";
            // 
            // fld_lkeFK_PMProjectTypeID1
            // 
            this.fld_lkeFK_PMProjectTypeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_PMProjectTypeID1.BOSAllowDummy = true;
            this.fld_lkeFK_PMProjectTypeID1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID1.BOSDataMember = "FK_PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID1.BOSDataSource = "PMTemplates";
            this.fld_lkeFK_PMProjectTypeID1.BOSDescription = null;
            this.fld_lkeFK_PMProjectTypeID1.BOSError = null;
            this.fld_lkeFK_PMProjectTypeID1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID1.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_PMProjectTypeID1.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID1.CurrentDisplayText = null;
            this.fld_lkeFK_PMProjectTypeID1.Location = new System.Drawing.Point(121, 87);
            this.fld_lkeFK_PMProjectTypeID1.Name = "fld_lkeFK_PMProjectTypeID1";
            this.fld_lkeFK_PMProjectTypeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_PMProjectTypeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_PMProjectTypeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_PMProjectTypeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_PMProjectTypeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_PMProjectTypeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectTypeNo", "Mã loại dự án"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectTypeName", 300, "Tên Loại dự án")});
            this.fld_lkeFK_PMProjectTypeID1.Properties.DisplayMember = "PMProjectTypeName";
            this.fld_lkeFK_PMProjectTypeID1.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_PMProjectTypeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_PMProjectTypeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_PMProjectTypeID1.Properties.ValueMember = "PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID1.Screen = null;
            this.fld_lkeFK_PMProjectTypeID1.Size = new System.Drawing.Size(191, 20);
            this.fld_lkeFK_PMProjectTypeID1.TabIndex = 3;
            this.fld_lkeFK_PMProjectTypeID1.Tag = "SC";
            // 
            // fld_dtePMTemplateToDate
            // 
            this.fld_dtePMTemplateToDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dtePMTemplateToDate.BOSDataMember = "PMTemplateToDate";
            this.fld_dtePMTemplateToDate.BOSDataSource = "PMTemplates";
            this.fld_dtePMTemplateToDate.BOSDescription = null;
            this.fld_dtePMTemplateToDate.BOSError = null;
            this.fld_dtePMTemplateToDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dtePMTemplateToDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dtePMTemplateToDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dtePMTemplateToDate.BOSPropertyName = "EditValue";
            this.fld_dtePMTemplateToDate.EditValue = null;
            this.fld_dtePMTemplateToDate.Location = new System.Drawing.Point(385, 113);
            this.fld_dtePMTemplateToDate.Name = "fld_dtePMTemplateToDate";
            this.fld_dtePMTemplateToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dtePMTemplateToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dtePMTemplateToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dtePMTemplateToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dtePMTemplateToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dtePMTemplateToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dtePMTemplateToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dtePMTemplateToDate, true);
            this.fld_dtePMTemplateToDate.Size = new System.Drawing.Size(187, 20);
            this.fld_dtePMTemplateToDate.TabIndex = 5;
            this.fld_dtePMTemplateToDate.Tag = "SC";
            // 
            // fld_dtePMTemplateFromDate
            // 
            this.fld_dtePMTemplateFromDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dtePMTemplateFromDate.BOSDataMember = "PMTemplateFromDate";
            this.fld_dtePMTemplateFromDate.BOSDataSource = "PMTemplates";
            this.fld_dtePMTemplateFromDate.BOSDescription = null;
            this.fld_dtePMTemplateFromDate.BOSError = null;
            this.fld_dtePMTemplateFromDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dtePMTemplateFromDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dtePMTemplateFromDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dtePMTemplateFromDate.BOSPropertyName = "EditValue";
            this.fld_dtePMTemplateFromDate.EditValue = null;
            this.fld_dtePMTemplateFromDate.Location = new System.Drawing.Point(121, 113);
            this.fld_dtePMTemplateFromDate.Name = "fld_dtePMTemplateFromDate";
            this.fld_dtePMTemplateFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dtePMTemplateFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dtePMTemplateFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dtePMTemplateFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dtePMTemplateFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dtePMTemplateFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dtePMTemplateFromDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dtePMTemplateFromDate, true);
            this.fld_dtePMTemplateFromDate.Size = new System.Drawing.Size(191, 20);
            this.fld_dtePMTemplateFromDate.TabIndex = 4;
            this.fld_dtePMTemplateFromDate.Tag = "SC";
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
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.Location = new System.Drawing.Point(47, 64);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(48, 13);
            this.bosLabel4.TabIndex = 135;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "PMTemplates";
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
            this.bosLabel1.Location = new System.Drawing.Point(331, 116);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(47, 13);
            this.bosLabel1.TabIndex = 136;
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
            this.bosLabel2.Location = new System.Drawing.Point(47, 116);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(40, 13);
            this.bosLabel2.TabIndex = 137;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Từ ngày";
            // 
            // SMPMTP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(663, 436);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_dtePMTemplateFromDate);
            this.Controls.Add(this.fld_dtePMTemplateToDate);
            this.Controls.Add(this.fld_lkeFK_PMProjectTypeID1);
            this.Controls.Add(this.fld_lblLabel53);
            this.Controls.Add(this.fld_lblLabel51);
            this.Controls.Add(this.fld_lblLabel58);
            this.Controls.Add(this.fld_lblLabel57);
            this.Controls.Add(this.fld_txtPMTemplateName);
            this.Controls.Add(this.fld_dgcPMTemplate);
            this.Controls.Add(this.fld_txtPMTemplateNo);
            this.Name = "SMPMTP100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtPMTemplateNo, 0);
            this.Controls.SetChildIndex(this.fld_dgcPMTemplate, 0);
            this.Controls.SetChildIndex(this.fld_txtPMTemplateName, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel57, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel58, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel51, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel53, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_PMProjectTypeID1, 0);
            this.Controls.SetChildIndex(this.fld_dtePMTemplateToDate, 0);
            this.Controls.SetChildIndex(this.fld_dtePMTemplateFromDate, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMTemplateName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMTemplateNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectTypeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMTemplateToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMTemplateToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMTemplateFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePMTemplateFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectTypeID1;
        private BOSComponent.BOSDateEdit fld_dtePMTemplateToDate;
        private BOSComponent.BOSDateEdit fld_dtePMTemplateFromDate;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
	}
}
