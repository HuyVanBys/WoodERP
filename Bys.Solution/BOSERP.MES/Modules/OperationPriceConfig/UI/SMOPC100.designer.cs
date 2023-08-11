using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.OperationPriceConfig.UI
{
	/// <summary>
    /// Summary description for SMOPC100
	/// </summary>
    partial class SMOPC100
	{
		private BOSComponent.BOSTextBox fld_txtMMOperationPriceConfigNo;
        private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSDateEdit fld_dteSearchFromMMOperationPriceConfigDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToMMOperationPriceConfigDate;


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
            this.fld_txtMMOperationPriceConfigNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromMMOperationPriceConfigDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToMMOperationPriceConfigDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcMMOperationPriceConfigs = new BOSERP.BOSSearchResultsGridControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMOperationPriceConfigNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMOperationPriceConfigDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMOperationPriceConfigDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMOperationPriceConfigDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMOperationPriceConfigDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMOperationPriceConfigs)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtMMOperationPriceConfigNo
            // 
            this.fld_txtMMOperationPriceConfigNo.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMOperationPriceConfigNo.BOSDataMember = "MMOperationPriceConfigNo";
            this.fld_txtMMOperationPriceConfigNo.BOSDataSource = "MMOperationPriceConfig";
            this.fld_txtMMOperationPriceConfigNo.BOSDescription = null;
            this.fld_txtMMOperationPriceConfigNo.BOSError = null;
            this.fld_txtMMOperationPriceConfigNo.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMOperationPriceConfigNo.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMOperationPriceConfigNo.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMOperationPriceConfigNo.BOSPropertyName = "Text";
            this.fld_txtMMOperationPriceConfigNo.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMOperationPriceConfigNo.Location = new System.Drawing.Point(135, 131);
            this.fld_txtMMOperationPriceConfigNo.Name = "fld_txtMMOperationPriceConfigNo";
            this.fld_txtMMOperationPriceConfigNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMOperationPriceConfigNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMOperationPriceConfigNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMOperationPriceConfigNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMOperationPriceConfigNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMOperationPriceConfigNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMOperationPriceConfigNo.Screen = null;
            this.fld_txtMMOperationPriceConfigNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMOperationPriceConfigNo.TabIndex = 0;
            this.fld_txtMMOperationPriceConfigNo.Tag = "SC";
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
            // fld_dteSearchFromMMOperationPriceConfigDate
            // 
            this.fld_dteSearchFromMMOperationPriceConfigDate.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchFromMMOperationPriceConfigDate.BOSDataMember = "OperationPriceConfigDateFrom";
            this.fld_dteSearchFromMMOperationPriceConfigDate.BOSDataSource = "MMOperationPriceConfig";
            this.fld_dteSearchFromMMOperationPriceConfigDate.BOSDescription = null;
            this.fld_dteSearchFromMMOperationPriceConfigDate.BOSError = null;
            this.fld_dteSearchFromMMOperationPriceConfigDate.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchFromMMOperationPriceConfigDate.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchFromMMOperationPriceConfigDate.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchFromMMOperationPriceConfigDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromMMOperationPriceConfigDate.EditValue = null;
            this.fld_dteSearchFromMMOperationPriceConfigDate.Location = new System.Drawing.Point(135, 157);
            this.fld_dteSearchFromMMOperationPriceConfigDate.Name = "fld_dteSearchFromMMOperationPriceConfigDate";
            this.fld_dteSearchFromMMOperationPriceConfigDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromMMOperationPriceConfigDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromMMOperationPriceConfigDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromMMOperationPriceConfigDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromMMOperationPriceConfigDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromMMOperationPriceConfigDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromMMOperationPriceConfigDate.Screen = null;
            this.fld_dteSearchFromMMOperationPriceConfigDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromMMOperationPriceConfigDate.TabIndex = 5;
            this.fld_dteSearchFromMMOperationPriceConfigDate.Tag = "SC";
            // 
            // fld_dteSearchToMMOperationPriceConfigDate
            // 
            this.fld_dteSearchToMMOperationPriceConfigDate.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchToMMOperationPriceConfigDate.BOSDataMember = "OperationPriceConfigDateTo";
            this.fld_dteSearchToMMOperationPriceConfigDate.BOSDataSource = "MMOperationPriceConfig";
            this.fld_dteSearchToMMOperationPriceConfigDate.BOSDescription = null;
            this.fld_dteSearchToMMOperationPriceConfigDate.BOSError = null;
            this.fld_dteSearchToMMOperationPriceConfigDate.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchToMMOperationPriceConfigDate.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchToMMOperationPriceConfigDate.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchToMMOperationPriceConfigDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToMMOperationPriceConfigDate.EditValue = null;
            this.fld_dteSearchToMMOperationPriceConfigDate.Location = new System.Drawing.Point(348, 157);
            this.fld_dteSearchToMMOperationPriceConfigDate.Name = "fld_dteSearchToMMOperationPriceConfigDate";
            this.fld_dteSearchToMMOperationPriceConfigDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToMMOperationPriceConfigDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToMMOperationPriceConfigDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToMMOperationPriceConfigDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToMMOperationPriceConfigDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToMMOperationPriceConfigDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToMMOperationPriceConfigDate.Screen = null;
            this.fld_dteSearchToMMOperationPriceConfigDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToMMOperationPriceConfigDate.TabIndex = 6;
            this.fld_dteSearchToMMOperationPriceConfigDate.Tag = "SC";
            // 
            // fld_dgcMMOperationPriceConfigs
            // 
            this.fld_dgcMMOperationPriceConfigs.BOSComment = null;
            this.fld_dgcMMOperationPriceConfigs.BOSDataMember = null;
            this.fld_dgcMMOperationPriceConfigs.BOSDataSource = "MMOperationPriceConfigs";
            this.fld_dgcMMOperationPriceConfigs.BOSDescription = null;
            this.fld_dgcMMOperationPriceConfigs.BOSError = null;
            this.fld_dgcMMOperationPriceConfigs.BOSFieldGroup = null;
            this.fld_dgcMMOperationPriceConfigs.BOSFieldRelation = null;
            this.fld_dgcMMOperationPriceConfigs.BOSPrivilege = null;
            this.fld_dgcMMOperationPriceConfigs.BOSPropertyName = null;
            this.fld_dgcMMOperationPriceConfigs.Location = new System.Drawing.Point(53, 200);
            this.fld_dgcMMOperationPriceConfigs.MenuManager = this.screenToolbar;
            this.fld_dgcMMOperationPriceConfigs.Name = "fld_dgcMMOperationPriceConfigs";
            this.fld_dgcMMOperationPriceConfigs.Screen = null;
            this.fld_dgcMMOperationPriceConfigs.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcMMOperationPriceConfigs.TabIndex = 10;
            this.fld_dgcMMOperationPriceConfigs.Tag = "SR";
            // 
            // SMOPC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcMMOperationPriceConfigs);
            this.Controls.Add(this.fld_txtMMOperationPriceConfigNo);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.fld_dteSearchFromMMOperationPriceConfigDate);
            this.Controls.Add(this.fld_dteSearchToMMOperationPriceConfigDate);
            this.Name = "SMOPC100";
            this.Tag = "SI";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dteSearchToMMOperationPriceConfigDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromMMOperationPriceConfigDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_txtMMOperationPriceConfigNo, 0);
            this.Controls.SetChildIndex(this.fld_dgcMMOperationPriceConfigs, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMOperationPriceConfigNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMOperationPriceConfigDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMOperationPriceConfigDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMOperationPriceConfigDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMOperationPriceConfigDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMOperationPriceConfigs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcMMOperationPriceConfigs;
	}
}
