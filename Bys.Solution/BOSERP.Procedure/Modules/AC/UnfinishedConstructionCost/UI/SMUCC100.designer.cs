using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.UnfinishedConstructionCost.UI
{
	/// <summary>
	/// Summary description for SMUCC100
	/// </summary>
	partial class SMUCC100
	{
		private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSTextBox fld_txtACUnfinishedConstructionCostNo;
        private BOSComponent.BOSTextBox fld_txtACUnfinishedConstructionCostName;


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
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACUnfinishedConstructionCostNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACUnfinishedConstructionCostName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACUnfinishedConstructionCostStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACUnfinishedConstructionCostStartDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACUnfinishedConstructionCostFinishedDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcACUnfinishedConstructionCosts = new BOSERP.BOSSearchResultsGridControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACUnfinishedConstructionCostNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACUnfinishedConstructionCostName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACUnfinishedConstructionCostStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACUnfinishedConstructionCostStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACUnfinishedConstructionCostStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACUnfinishedConstructionCostFinishedDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACUnfinishedConstructionCostFinishedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACUnfinishedConstructionCosts)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.Location = new System.Drawing.Point(34, 30);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(105, 13);
            this.fld_lblLabel.TabIndex = 4;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chi phí XD dở dang";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.Location = new System.Drawing.Point(34, 56);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(109, 13);
            this.fld_lblLabel1.TabIndex = 5;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Tên chi phí XD dở dang";
            // 
            // fld_txtACUnfinishedConstructionCostNo
            // 
            this.fld_txtACUnfinishedConstructionCostNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACUnfinishedConstructionCostNo.BOSDataMember = "ACUnfinishedConstructionCostNo";
            this.fld_txtACUnfinishedConstructionCostNo.BOSDataSource = "ACUnfinishedConstructionCosts";
            this.fld_txtACUnfinishedConstructionCostNo.BOSDescription = null;
            this.fld_txtACUnfinishedConstructionCostNo.BOSError = null;
            this.fld_txtACUnfinishedConstructionCostNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACUnfinishedConstructionCostNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACUnfinishedConstructionCostNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACUnfinishedConstructionCostNo.BOSPropertyName = "Text";
            this.fld_txtACUnfinishedConstructionCostNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACUnfinishedConstructionCostNo.Location = new System.Drawing.Point(166, 27);
            this.fld_txtACUnfinishedConstructionCostNo.Name = "fld_txtACUnfinishedConstructionCostNo";
            this.fld_txtACUnfinishedConstructionCostNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACUnfinishedConstructionCostNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACUnfinishedConstructionCostNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACUnfinishedConstructionCostNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACUnfinishedConstructionCostNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACUnfinishedConstructionCostNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACUnfinishedConstructionCostNo.Screen = null;
            this.fld_txtACUnfinishedConstructionCostNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACUnfinishedConstructionCostNo.TabIndex = 0;
            this.fld_txtACUnfinishedConstructionCostNo.Tag = "SC";
            // 
            // fld_txtACUnfinishedConstructionCostName
            // 
            this.fld_txtACUnfinishedConstructionCostName.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACUnfinishedConstructionCostName.BOSDataMember = "ACUnfinishedConstructionCostName";
            this.fld_txtACUnfinishedConstructionCostName.BOSDataSource = "ACUnfinishedConstructionCosts";
            this.fld_txtACUnfinishedConstructionCostName.BOSDescription = null;
            this.fld_txtACUnfinishedConstructionCostName.BOSError = null;
            this.fld_txtACUnfinishedConstructionCostName.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACUnfinishedConstructionCostName.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACUnfinishedConstructionCostName.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACUnfinishedConstructionCostName.BOSPropertyName = "Text";
            this.fld_txtACUnfinishedConstructionCostName.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACUnfinishedConstructionCostName.Location = new System.Drawing.Point(166, 53);
            this.fld_txtACUnfinishedConstructionCostName.Name = "fld_txtACUnfinishedConstructionCostName";
            this.fld_txtACUnfinishedConstructionCostName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACUnfinishedConstructionCostName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACUnfinishedConstructionCostName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACUnfinishedConstructionCostName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACUnfinishedConstructionCostName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACUnfinishedConstructionCostName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACUnfinishedConstructionCostName.Screen = null;
            this.fld_txtACUnfinishedConstructionCostName.Size = new System.Drawing.Size(319, 20);
            this.fld_txtACUnfinishedConstructionCostName.TabIndex = 1;
            this.fld_txtACUnfinishedConstructionCostName.Tag = "SC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.Location = new System.Drawing.Point(34, 82);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(49, 13);
            this.bosLabel1.TabIndex = 6;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Tình trạng";
            // 
            // fld_lkeACUnfinishedConstructionCostStatus
            // 
            this.fld_lkeACUnfinishedConstructionCostStatus.BOSAllowAddNew = false;
            this.fld_lkeACUnfinishedConstructionCostStatus.BOSAllowDummy = true;
            this.fld_lkeACUnfinishedConstructionCostStatus.BOSComment = null;
            this.fld_lkeACUnfinishedConstructionCostStatus.BOSDataMember = "ACUnfinishedConstructionCostStatus";
            this.fld_lkeACUnfinishedConstructionCostStatus.BOSDataSource = "ACUnfinishedConstructionCosts";
            this.fld_lkeACUnfinishedConstructionCostStatus.BOSDescription = null;
            this.fld_lkeACUnfinishedConstructionCostStatus.BOSError = null;
            this.fld_lkeACUnfinishedConstructionCostStatus.BOSFieldGroup = null;
            this.fld_lkeACUnfinishedConstructionCostStatus.BOSFieldParent = null;
            this.fld_lkeACUnfinishedConstructionCostStatus.BOSFieldRelation = null;
            this.fld_lkeACUnfinishedConstructionCostStatus.BOSPrivilege = null;
            this.fld_lkeACUnfinishedConstructionCostStatus.BOSPropertyName = "EditValue";
            this.fld_lkeACUnfinishedConstructionCostStatus.BOSSelectType = null;
            this.fld_lkeACUnfinishedConstructionCostStatus.BOSSelectTypeValue = null;
            this.fld_lkeACUnfinishedConstructionCostStatus.CurrentDisplayText = null;
            this.fld_lkeACUnfinishedConstructionCostStatus.Location = new System.Drawing.Point(166, 79);
            this.fld_lkeACUnfinishedConstructionCostStatus.Name = "fld_lkeACUnfinishedConstructionCostStatus";
            this.fld_lkeACUnfinishedConstructionCostStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACUnfinishedConstructionCostStatus.Screen = null;
            this.fld_lkeACUnfinishedConstructionCostStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACUnfinishedConstructionCostStatus.TabIndex = 2;
            this.fld_lkeACUnfinishedConstructionCostStatus.Tag = "SC";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.Location = new System.Drawing.Point(34, 108);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(73, 13);
            this.fld_lblLabel6.TabIndex = 8;
            this.fld_lblLabel6.Tag = "SI";
            this.fld_lblLabel6.Text = "Ngày thực hiện";
            // 
            // fld_dteACUnfinishedConstructionCostStartDate
            // 
            this.fld_dteACUnfinishedConstructionCostStartDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteACUnfinishedConstructionCostStartDate.BOSDataMember = "ACUnfinishedConstructionCostStartDate";
            this.fld_dteACUnfinishedConstructionCostStartDate.BOSDataSource = "ACUnfinishedConstructionCosts";
            this.fld_dteACUnfinishedConstructionCostStartDate.BOSDescription = null;
            this.fld_dteACUnfinishedConstructionCostStartDate.BOSError = null;
            this.fld_dteACUnfinishedConstructionCostStartDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteACUnfinishedConstructionCostStartDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteACUnfinishedConstructionCostStartDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteACUnfinishedConstructionCostStartDate.BOSPropertyName = "EditValue";
            this.fld_dteACUnfinishedConstructionCostStartDate.EditValue = null;
            this.fld_dteACUnfinishedConstructionCostStartDate.Location = new System.Drawing.Point(166, 105);
            this.fld_dteACUnfinishedConstructionCostStartDate.Name = "fld_dteACUnfinishedConstructionCostStartDate";
            this.fld_dteACUnfinishedConstructionCostStartDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACUnfinishedConstructionCostStartDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACUnfinishedConstructionCostStartDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACUnfinishedConstructionCostStartDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACUnfinishedConstructionCostStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACUnfinishedConstructionCostStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACUnfinishedConstructionCostStartDate.Screen = null;
            this.fld_dteACUnfinishedConstructionCostStartDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACUnfinishedConstructionCostStartDate.TabIndex = 3;
            this.fld_dteACUnfinishedConstructionCostStartDate.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.Location = new System.Drawing.Point(34, 134);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(83, 13);
            this.bosLabel2.TabIndex = 10;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Ngày hoàn thành";
            // 
            // fld_dteACUnfinishedConstructionCostFinishedDate
            // 
            this.fld_dteACUnfinishedConstructionCostFinishedDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteACUnfinishedConstructionCostFinishedDate.BOSDataMember = "ACUnfinishedConstructionCostFinishedDate";
            this.fld_dteACUnfinishedConstructionCostFinishedDate.BOSDataSource = "ACUnfinishedConstructionCosts";
            this.fld_dteACUnfinishedConstructionCostFinishedDate.BOSDescription = null;
            this.fld_dteACUnfinishedConstructionCostFinishedDate.BOSError = null;
            this.fld_dteACUnfinishedConstructionCostFinishedDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteACUnfinishedConstructionCostFinishedDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteACUnfinishedConstructionCostFinishedDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteACUnfinishedConstructionCostFinishedDate.BOSPropertyName = "EditValue";
            this.fld_dteACUnfinishedConstructionCostFinishedDate.EditValue = null;
            this.fld_dteACUnfinishedConstructionCostFinishedDate.Location = new System.Drawing.Point(166, 131);
            this.fld_dteACUnfinishedConstructionCostFinishedDate.Name = "fld_dteACUnfinishedConstructionCostFinishedDate";
            this.fld_dteACUnfinishedConstructionCostFinishedDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACUnfinishedConstructionCostFinishedDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACUnfinishedConstructionCostFinishedDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACUnfinishedConstructionCostFinishedDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACUnfinishedConstructionCostFinishedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACUnfinishedConstructionCostFinishedDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACUnfinishedConstructionCostFinishedDate.Screen = null;
            this.fld_dteACUnfinishedConstructionCostFinishedDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACUnfinishedConstructionCostFinishedDate.TabIndex = 4;
            this.fld_dteACUnfinishedConstructionCostFinishedDate.Tag = "SC";
            // 
            // fld_dgcACUnfinishedConstructionCosts
            // 
            this.fld_dgcACUnfinishedConstructionCosts.BOSComment = null;
            this.fld_dgcACUnfinishedConstructionCosts.BOSDataMember = null;
            this.fld_dgcACUnfinishedConstructionCosts.BOSDataSource = "ACUnfinishedConstructionCosts";
            this.fld_dgcACUnfinishedConstructionCosts.BOSDescription = null;
            this.fld_dgcACUnfinishedConstructionCosts.BOSError = null;
            this.fld_dgcACUnfinishedConstructionCosts.BOSFieldGroup = null;
            this.fld_dgcACUnfinishedConstructionCosts.BOSFieldRelation = null;
            this.fld_dgcACUnfinishedConstructionCosts.BOSPrivilege = null;
            this.fld_dgcACUnfinishedConstructionCosts.BOSPropertyName = null;
            this.fld_dgcACUnfinishedConstructionCosts.Location = new System.Drawing.Point(34, 178);
            this.fld_dgcACUnfinishedConstructionCosts.MenuManager = this.screenToolbar;
            this.fld_dgcACUnfinishedConstructionCosts.Name = "fld_dgcACUnfinishedConstructionCosts";
            this.fld_dgcACUnfinishedConstructionCosts.Screen = null;
            this.fld_dgcACUnfinishedConstructionCosts.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcACUnfinishedConstructionCosts.TabIndex = 11;
            this.fld_dgcACUnfinishedConstructionCosts.Tag = "SR";
            // 
            // SMUCC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(599, 567);
            this.Controls.Add(this.fld_dgcACUnfinishedConstructionCosts);
            this.Controls.Add(this.fld_dteACUnfinishedConstructionCostFinishedDate);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_dteACUnfinishedConstructionCostStartDate);
            this.Controls.Add(this.fld_lblLabel6);
            this.Controls.Add(this.fld_lkeACUnfinishedConstructionCostStatus);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtACUnfinishedConstructionCostNo);
            this.Controls.Add(this.fld_txtACUnfinishedConstructionCostName);
            this.Name = "SMUCC100";
            this.Tag = "SM";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtACUnfinishedConstructionCostName, 0);
            this.Controls.SetChildIndex(this.fld_txtACUnfinishedConstructionCostNo, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_lkeACUnfinishedConstructionCostStatus, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel6, 0);
            this.Controls.SetChildIndex(this.fld_dteACUnfinishedConstructionCostStartDate, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dteACUnfinishedConstructionCostFinishedDate, 0);
            this.Controls.SetChildIndex(this.fld_dgcACUnfinishedConstructionCosts, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACUnfinishedConstructionCostNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACUnfinishedConstructionCostName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACUnfinishedConstructionCostStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACUnfinishedConstructionCostStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACUnfinishedConstructionCostStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACUnfinishedConstructionCostFinishedDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACUnfinishedConstructionCostFinishedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACUnfinishedConstructionCosts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeACUnfinishedConstructionCostStatus;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSDateEdit fld_dteACUnfinishedConstructionCostStartDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteACUnfinishedConstructionCostFinishedDate;
        private BOSSearchResultsGridControl fld_dgcACUnfinishedConstructionCosts;
	}
}
