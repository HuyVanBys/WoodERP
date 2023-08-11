using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.UnfinishedConstructionCost.UI
{
	/// <summary>
	/// Summary description for DMUCC100
	/// </summary>
	partial class DMUCC100
	{
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel fld_lblLabel6;
		private BOSComponent.BOSTextBox fld_txtACUnfinishedConstructionCostNo;
		private BOSComponent.BOSTextBox fld_txtACUnfinishedConstructionCostName;
		private BOSComponent.BOSDateEdit fld_dteACUnfinishedConstructionCostFinishedDate;
        private BOSComponent.BOSDateEdit fld_dteACUnfinishedConstructionCostStartDate;


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
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACUnfinishedConstructionCostNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACUnfinishedConstructionCostName = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteACUnfinishedConstructionCostFinishedDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteACUnfinishedConstructionCostStartDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACUnfinishedConstructionCostValue = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ACAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeACUnfinishedConstructionCostStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACUnfinishedConstructionCostNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACUnfinishedConstructionCostName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACUnfinishedConstructionCostFinishedDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACUnfinishedConstructionCostFinishedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACUnfinishedConstructionCostStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACUnfinishedConstructionCostStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACUnfinishedConstructionCostValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACUnfinishedConstructionCostStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.Location = new System.Drawing.Point(19, 43);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(105, 13);
            this.fld_lblLabel3.TabIndex = 4;
            this.fld_lblLabel3.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.Text = "Mã chi phí XD dở dang";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.Location = new System.Drawing.Point(407, 43);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(109, 13);
            this.fld_lblLabel4.TabIndex = 5;
            this.fld_lblLabel4.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.Text = "Tên chi phí XD dở dang";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.Location = new System.Drawing.Point(407, 95);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabel5.TabIndex = 6;
            this.fld_lblLabel5.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.Text = "Ngày kết thúc";
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
            this.fld_lblLabel6.Location = new System.Drawing.Point(19, 95);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(73, 13);
            this.fld_lblLabel6.TabIndex = 7;
            this.fld_lblLabel6.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.Text = "Ngày thực hiện";
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
            this.fld_txtACUnfinishedConstructionCostNo.Location = new System.Drawing.Point(149, 40);
            this.fld_txtACUnfinishedConstructionCostNo.Name = "fld_txtACUnfinishedConstructionCostNo";
            this.fld_txtACUnfinishedConstructionCostNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACUnfinishedConstructionCostNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACUnfinishedConstructionCostNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACUnfinishedConstructionCostNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACUnfinishedConstructionCostNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACUnfinishedConstructionCostNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACUnfinishedConstructionCostNo.Screen = null;
            this.fld_txtACUnfinishedConstructionCostNo.Size = new System.Drawing.Size(205, 20);
            this.fld_txtACUnfinishedConstructionCostNo.TabIndex = 0;
            this.fld_txtACUnfinishedConstructionCostNo.Tag = "DC";
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
            this.fld_txtACUnfinishedConstructionCostName.Location = new System.Drawing.Point(532, 40);
            this.fld_txtACUnfinishedConstructionCostName.Name = "fld_txtACUnfinishedConstructionCostName";
            this.fld_txtACUnfinishedConstructionCostName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACUnfinishedConstructionCostName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACUnfinishedConstructionCostName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACUnfinishedConstructionCostName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACUnfinishedConstructionCostName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACUnfinishedConstructionCostName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACUnfinishedConstructionCostName.Screen = null;
            this.fld_txtACUnfinishedConstructionCostName.Size = new System.Drawing.Size(205, 20);
            this.fld_txtACUnfinishedConstructionCostName.TabIndex = 1;
            this.fld_txtACUnfinishedConstructionCostName.Tag = "DC";
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
            this.fld_dteACUnfinishedConstructionCostFinishedDate.Location = new System.Drawing.Point(532, 92);
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
            this.fld_dteACUnfinishedConstructionCostFinishedDate.Size = new System.Drawing.Size(205, 20);
            this.fld_dteACUnfinishedConstructionCostFinishedDate.TabIndex = 5;
            this.fld_dteACUnfinishedConstructionCostFinishedDate.Tag = "DC";
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
            this.fld_dteACUnfinishedConstructionCostStartDate.Location = new System.Drawing.Point(149, 92);
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
            this.fld_dteACUnfinishedConstructionCostStartDate.Size = new System.Drawing.Size(205, 20);
            this.fld_dteACUnfinishedConstructionCostStartDate.TabIndex = 4;
            this.fld_dteACUnfinishedConstructionCostStartDate.Tag = "DC";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.fld_txtACUnfinishedConstructionCostValue);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAccountID);
            this.bosGroupControl1.Controls.Add(this.fld_lkeACUnfinishedConstructionCostStatus);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_txtACUnfinishedConstructionCostNo);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel4);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel5);
            this.bosGroupControl1.Controls.Add(this.bosLabel12);
            this.bosGroupControl1.Controls.Add(this.fld_dteACUnfinishedConstructionCostStartDate);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel6);
            this.bosGroupControl1.Controls.Add(this.fld_dteACUnfinishedConstructionCostFinishedDate);
            this.bosGroupControl1.Controls.Add(this.fld_txtACUnfinishedConstructionCostName);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 4);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(805, 167);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Thông tin chung";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel1.Location = new System.Drawing.Point(407, 69);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(28, 13);
            this.bosLabel1.TabIndex = 18;
            this.bosLabel1.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.Text = "Giá trị";
            // 
            // fld_txtACUnfinishedConstructionCostValue
            // 
            this.fld_txtACUnfinishedConstructionCostValue.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACUnfinishedConstructionCostValue.BOSDataMember = "ACUnfinishedConstructionCostValue";
            this.fld_txtACUnfinishedConstructionCostValue.BOSDataSource = "ACUnfinishedConstructionCosts";
            this.fld_txtACUnfinishedConstructionCostValue.BOSDescription = null;
            this.fld_txtACUnfinishedConstructionCostValue.BOSError = null;
            this.fld_txtACUnfinishedConstructionCostValue.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACUnfinishedConstructionCostValue.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACUnfinishedConstructionCostValue.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACUnfinishedConstructionCostValue.BOSPropertyName = "Text";
            this.fld_txtACUnfinishedConstructionCostValue.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACUnfinishedConstructionCostValue.Location = new System.Drawing.Point(532, 66);
            this.fld_txtACUnfinishedConstructionCostValue.Name = "fld_txtACUnfinishedConstructionCostValue";
            this.fld_txtACUnfinishedConstructionCostValue.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACUnfinishedConstructionCostValue.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACUnfinishedConstructionCostValue.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACUnfinishedConstructionCostValue.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACUnfinishedConstructionCostValue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACUnfinishedConstructionCostValue.Properties.ReadOnly = true;
            this.fld_txtACUnfinishedConstructionCostValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACUnfinishedConstructionCostValue.Screen = null;
            this.fld_txtACUnfinishedConstructionCostValue.Size = new System.Drawing.Size(205, 20);
            this.fld_txtACUnfinishedConstructionCostValue.TabIndex = 3;
            this.fld_txtACUnfinishedConstructionCostValue.Tag = "DC";
            // 
            // fld_lkeFK_ACAccountID
            // 
            this.fld_lkeFK_ACAccountID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAccountID.BOSComment = null;
            this.fld_lkeFK_ACAccountID.BOSDataMember = "FK_ACAccountID";
            this.fld_lkeFK_ACAccountID.BOSDataSource = "ACUnfinishedConstructionCosts";
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
            this.fld_lkeFK_ACAccountID.Location = new System.Drawing.Point(149, 66);
            this.fld_lkeFK_ACAccountID.Name = "fld_lkeFK_ACAccountID";
            this.fld_lkeFK_ACAccountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAccountID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACAccountID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACAccountID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACAccountID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAccountID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACAccountID.Screen = null;
            this.fld_lkeFK_ACAccountID.Size = new System.Drawing.Size(205, 20);
            this.fld_lkeFK_ACAccountID.TabIndex = 2;
            this.fld_lkeFK_ACAccountID.Tag = "DC";
            // 
            // fld_lkeACUnfinishedConstructionCostStatus
            // 
            this.fld_lkeACUnfinishedConstructionCostStatus.BOSAllowAddNew = false;
            this.fld_lkeACUnfinishedConstructionCostStatus.BOSAllowDummy = false;
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
            this.fld_lkeACUnfinishedConstructionCostStatus.Location = new System.Drawing.Point(149, 118);
            this.fld_lkeACUnfinishedConstructionCostStatus.MenuManager = this.screenToolbar;
            this.fld_lkeACUnfinishedConstructionCostStatus.Name = "fld_lkeACUnfinishedConstructionCostStatus";
            this.fld_lkeACUnfinishedConstructionCostStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACUnfinishedConstructionCostStatus.Properties.ReadOnly = true;
            this.fld_lkeACUnfinishedConstructionCostStatus.Screen = null;
            this.fld_lkeACUnfinishedConstructionCostStatus.Size = new System.Drawing.Size(205, 20);
            this.fld_lkeACUnfinishedConstructionCostStatus.TabIndex = 6;
            this.fld_lkeACUnfinishedConstructionCostStatus.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.Location = new System.Drawing.Point(19, 121);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 6;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.Text = "Trạng thái";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel12.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel12.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel12.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel12.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel12.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel12.Location = new System.Drawing.Point(19, 69);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(103, 13);
            this.bosLabel12.TabIndex = 7;
            this.bosLabel12.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel12.Text = "TK chi phí XD dở dang";
            // 
            // DMUCC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(824, 183);
            this.Controls.Add(this.bosGroupControl1);
            this.Name = "DMUCC100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosGroupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACUnfinishedConstructionCostNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACUnfinishedConstructionCostName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACUnfinishedConstructionCostFinishedDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACUnfinishedConstructionCostFinishedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACUnfinishedConstructionCostStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACUnfinishedConstructionCostStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACUnfinishedConstructionCostValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACUnfinishedConstructionCostStatus.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeACUnfinishedConstructionCostStatus;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtACUnfinishedConstructionCostValue;
	}
}
