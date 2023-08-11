using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.NormTemplate.UI
{
	/// <summary>
    /// Summary description for SMNTL100
	/// </summary>
    partial class SMNTL100
	{
		private BOSComponent.BOSTextBox fld_txtMMNormTemplateNo;
        private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSDateEdit fld_dteSearchFromMMNormTemplateDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToMMNormTemplateDate;


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
            this.fld_txtMMNormTemplateNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromMMNormTemplateDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToMMNormTemplateDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcMMNormTemplates = new BOSERP.BOSSearchResultsGridControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMNormTemplateNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMNormTemplateDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMNormTemplateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMNormTemplateDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMNormTemplateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMNormTemplates)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtMMNormTemplateNo
            // 
            this.fld_txtMMNormTemplateNo.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMNormTemplateNo.BOSDataMember = "MMNormTemplateNo";
            this.fld_txtMMNormTemplateNo.BOSDataSource = "MMNormTemplate";
            this.fld_txtMMNormTemplateNo.BOSDescription = null;
            this.fld_txtMMNormTemplateNo.BOSError = null;
            this.fld_txtMMNormTemplateNo.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMNormTemplateNo.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMNormTemplateNo.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMNormTemplateNo.BOSPropertyName = "Text";
            this.fld_txtMMNormTemplateNo.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMNormTemplateNo.Location = new System.Drawing.Point(135, 131);
            this.fld_txtMMNormTemplateNo.Name = "fld_txtMMNormTemplateNo";
            this.fld_txtMMNormTemplateNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMNormTemplateNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMNormTemplateNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMNormTemplateNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMNormTemplateNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMNormTemplateNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMNormTemplateNo.Screen = null;
            this.fld_txtMMNormTemplateNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMNormTemplateNo.TabIndex = 0;
            this.fld_txtMMNormTemplateNo.Tag = "SC";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.Location = new System.Drawing.Point(37, 134);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 5;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel3.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel3.Location = new System.Drawing.Point(37, 160);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel3.TabIndex = 8;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Ngày chứng từ";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.Location = new System.Drawing.Point(309, 160);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel4.TabIndex = 9;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Đến";
            // 
            // fld_dteSearchFromMMNormTemplateDate
            // 
            this.fld_dteSearchFromMMNormTemplateDate.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchFromMMNormTemplateDate.BOSDataMember = "ProcessDateFrom";
            this.fld_dteSearchFromMMNormTemplateDate.BOSDataSource = "MMNormTemplate";
            this.fld_dteSearchFromMMNormTemplateDate.BOSDescription = null;
            this.fld_dteSearchFromMMNormTemplateDate.BOSError = null;
            this.fld_dteSearchFromMMNormTemplateDate.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchFromMMNormTemplateDate.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchFromMMNormTemplateDate.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchFromMMNormTemplateDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromMMNormTemplateDate.EditValue = null;
            this.fld_dteSearchFromMMNormTemplateDate.Location = new System.Drawing.Point(135, 157);
            this.fld_dteSearchFromMMNormTemplateDate.Name = "fld_dteSearchFromMMNormTemplateDate";
            this.fld_dteSearchFromMMNormTemplateDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromMMNormTemplateDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromMMNormTemplateDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromMMNormTemplateDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromMMNormTemplateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromMMNormTemplateDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromMMNormTemplateDate.Screen = null;
            this.fld_dteSearchFromMMNormTemplateDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromMMNormTemplateDate.TabIndex = 5;
            this.fld_dteSearchFromMMNormTemplateDate.Tag = "SC";
            // 
            // fld_dteSearchToMMNormTemplateDate
            // 
            this.fld_dteSearchToMMNormTemplateDate.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchToMMNormTemplateDate.BOSDataMember = "ProcessDateTo";
            this.fld_dteSearchToMMNormTemplateDate.BOSDataSource = "MMNormTemplate";
            this.fld_dteSearchToMMNormTemplateDate.BOSDescription = null;
            this.fld_dteSearchToMMNormTemplateDate.BOSError = null;
            this.fld_dteSearchToMMNormTemplateDate.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchToMMNormTemplateDate.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchToMMNormTemplateDate.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchToMMNormTemplateDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToMMNormTemplateDate.EditValue = null;
            this.fld_dteSearchToMMNormTemplateDate.Location = new System.Drawing.Point(348, 157);
            this.fld_dteSearchToMMNormTemplateDate.Name = "fld_dteSearchToMMNormTemplateDate";
            this.fld_dteSearchToMMNormTemplateDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToMMNormTemplateDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToMMNormTemplateDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToMMNormTemplateDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToMMNormTemplateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToMMNormTemplateDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToMMNormTemplateDate.Screen = null;
            this.fld_dteSearchToMMNormTemplateDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToMMNormTemplateDate.TabIndex = 6;
            this.fld_dteSearchToMMNormTemplateDate.Tag = "SC";
            // 
            // fld_dgcMMNormTemplates
            // 
            this.fld_dgcMMNormTemplates.BOSComment = null;
            this.fld_dgcMMNormTemplates.BOSDataMember = null;
            this.fld_dgcMMNormTemplates.BOSDataSource = "MMNormTemplates";
            this.fld_dgcMMNormTemplates.BOSDescription = null;
            this.fld_dgcMMNormTemplates.BOSError = null;
            this.fld_dgcMMNormTemplates.BOSFieldGroup = null;
            this.fld_dgcMMNormTemplates.BOSFieldRelation = null;
            this.fld_dgcMMNormTemplates.BOSPrivilege = null;
            this.fld_dgcMMNormTemplates.BOSPropertyName = null;
            this.fld_dgcMMNormTemplates.Location = new System.Drawing.Point(53, 200);
            this.fld_dgcMMNormTemplates.MenuManager = this.screenToolbar;
            this.fld_dgcMMNormTemplates.Name = "fld_dgcMMNormTemplates";
            this.fld_dgcMMNormTemplates.Screen = null;
            this.fld_dgcMMNormTemplates.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcMMNormTemplates.TabIndex = 10;
            this.fld_dgcMMNormTemplates.Tag = "SR";
            // 
            // SMNTL100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcMMNormTemplates);
            this.Controls.Add(this.fld_txtMMNormTemplateNo);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.fld_dteSearchFromMMNormTemplateDate);
            this.Controls.Add(this.fld_dteSearchToMMNormTemplateDate);
            this.Name = "SMNTL100";
            this.Tag = "SI";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dteSearchToMMNormTemplateDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromMMNormTemplateDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_txtMMNormTemplateNo, 0);
            this.Controls.SetChildIndex(this.fld_dgcMMNormTemplates, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMNormTemplateNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMNormTemplateDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMNormTemplateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMNormTemplateDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMNormTemplateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMNormTemplates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcMMNormTemplates;
	}
}
