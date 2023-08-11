using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SaleForecast.UI
{
	/// <summary>
	/// Summary description for DMSF102
	/// </summary>
	partial class DMSF102
	{
        private BOSComponent.BOSGroupControl fld_grcGroupControl;


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
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcARSaleForecastTemplates = new BOSERP.Modules.SaleForecast.ARSaleForecastTemplatesGridControl();
            this.fld_dgvARSaleForecastTemplates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtFilePath = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnBrowseFile = new BOSComponent.BOSButton(this.components);
            this.fld_btnUploadProposalTemplate = new BOSComponent.BOSButton(this.components);
            this.fld_btnViewTemplate = new BOSComponent.BOSButton(this.components);
            this.fld_btnDeleteTemplate = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleForecastTemplates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleForecastTemplates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFilePath.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_grcGroupControl.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_grcGroupControl.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_grcGroupControl.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_grcGroupControl.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcARSaleForecastTemplates);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel17);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtFilePath);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnBrowseFile);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnUploadProposalTemplate);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnViewTemplate);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnDeleteTemplate);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(862, 567);
            this.fld_grcGroupControl.TabIndex = 4;
            this.fld_grcGroupControl.Tag = global::Localization.CommonLocalizedResources.String1;
            this.fld_grcGroupControl.Text = "Tài liệu đính kèm";
            // 
            // fld_dgcARSaleForecastTemplates
            // 
            this.fld_dgcARSaleForecastTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleForecastTemplates.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcARSaleForecastTemplates.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcARSaleForecastTemplates.BOSDataSource = "ARSaleForecastTemplates";
            this.fld_dgcARSaleForecastTemplates.BOSDescription = null;
            this.fld_dgcARSaleForecastTemplates.BOSError = null;
            this.fld_dgcARSaleForecastTemplates.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcARSaleForecastTemplates.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcARSaleForecastTemplates.BOSGridType = null;
            this.fld_dgcARSaleForecastTemplates.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcARSaleForecastTemplates.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcARSaleForecastTemplates.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSaleForecastTemplates.Location = new System.Drawing.Point(12, 76);
            this.fld_dgcARSaleForecastTemplates.MainView = this.fld_dgvARSaleForecastTemplates;
            this.fld_dgcARSaleForecastTemplates.Name = "fld_dgcARSaleForecastTemplates";
            this.fld_dgcARSaleForecastTemplates.PrintReport = false;
            this.fld_dgcARSaleForecastTemplates.Screen = null;
            this.fld_dgcARSaleForecastTemplates.Size = new System.Drawing.Size(838, 479);
            this.fld_dgcARSaleForecastTemplates.TabIndex = 21;
            this.fld_dgcARSaleForecastTemplates.Tag = "DC";
            this.fld_dgcARSaleForecastTemplates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleForecastTemplates});
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel17.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel17.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel17.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel17.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(12, 42);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel17.TabIndex = 20;
            this.fld_lblLabel17.Tag = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel17.Text = "File đính kèm";
            // 
            // fld_txtFilePath
            // 
            this.fld_txtFilePath.BOSComment = null;
            this.fld_txtFilePath.BOSDataMember = null;
            this.fld_txtFilePath.BOSDataSource = null;
            this.fld_txtFilePath.BOSDescription = null;
            this.fld_txtFilePath.BOSError = null;
            this.fld_txtFilePath.BOSFieldGroup = null;
            this.fld_txtFilePath.BOSFieldRelation = null;
            this.fld_txtFilePath.BOSPrivilege = null;
            this.fld_txtFilePath.BOSPropertyName = null;
            this.fld_txtFilePath.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtFilePath.Enabled = false;
            this.fld_txtFilePath.Location = new System.Drawing.Point(89, 39);
            this.fld_txtFilePath.MenuManager = this.screenToolbar;
            this.fld_txtFilePath.Name = "fld_txtFilePath";
            this.fld_txtFilePath.Screen = null;
            this.fld_txtFilePath.Size = new System.Drawing.Size(347, 20);
            this.fld_txtFilePath.TabIndex = 18;
            // 
            // fld_btnBrowseFile
            // 
            this.fld_btnBrowseFile.BOSComment = null;
            this.fld_btnBrowseFile.BOSDataMember = null;
            this.fld_btnBrowseFile.BOSDataSource = null;
            this.fld_btnBrowseFile.BOSDescription = null;
            this.fld_btnBrowseFile.BOSError = null;
            this.fld_btnBrowseFile.BOSFieldGroup = null;
            this.fld_btnBrowseFile.BOSFieldRelation = null;
            this.fld_btnBrowseFile.BOSPrivilege = null;
            this.fld_btnBrowseFile.BOSPropertyName = null;
            this.fld_btnBrowseFile.Location = new System.Drawing.Point(442, 39);
            this.fld_btnBrowseFile.Name = "fld_btnBrowseFile";
            this.fld_btnBrowseFile.Screen = null;
            this.fld_btnBrowseFile.Size = new System.Drawing.Size(30, 20);
            this.fld_btnBrowseFile.TabIndex = 19;
            this.fld_btnBrowseFile.Text = "...";
            this.fld_btnBrowseFile.Click += new System.EventHandler(this.fld_btnBrowseFile_Click);
            // 
            // fld_btnUploadProposalTemplate
            // 
            this.fld_btnUploadProposalTemplate.BOSComment = null;
            this.fld_btnUploadProposalTemplate.BOSDataMember = null;
            this.fld_btnUploadProposalTemplate.BOSDataSource = null;
            this.fld_btnUploadProposalTemplate.BOSDescription = null;
            this.fld_btnUploadProposalTemplate.BOSError = null;
            this.fld_btnUploadProposalTemplate.BOSFieldGroup = null;
            this.fld_btnUploadProposalTemplate.BOSFieldRelation = null;
            this.fld_btnUploadProposalTemplate.BOSPrivilege = null;
            this.fld_btnUploadProposalTemplate.BOSPropertyName = null;
            this.fld_btnUploadProposalTemplate.Location = new System.Drawing.Point(564, 32);
            this.fld_btnUploadProposalTemplate.Name = "fld_btnUploadProposalTemplate";
            this.fld_btnUploadProposalTemplate.Screen = null;
            this.fld_btnUploadProposalTemplate.Size = new System.Drawing.Size(75, 27);
            this.fld_btnUploadProposalTemplate.TabIndex = 16;
            this.fld_btnUploadProposalTemplate.Text = "Lưu tài liệu";
            this.fld_btnUploadProposalTemplate.Click += new System.EventHandler(this.fld_btnUploadProposalTemplate_Click);
            // 
            // fld_btnViewTemplate
            // 
            this.fld_btnViewTemplate.BOSComment = null;
            this.fld_btnViewTemplate.BOSDataMember = null;
            this.fld_btnViewTemplate.BOSDataSource = null;
            this.fld_btnViewTemplate.BOSDescription = null;
            this.fld_btnViewTemplate.BOSError = null;
            this.fld_btnViewTemplate.BOSFieldGroup = null;
            this.fld_btnViewTemplate.BOSFieldRelation = null;
            this.fld_btnViewTemplate.BOSPrivilege = null;
            this.fld_btnViewTemplate.BOSPropertyName = null;
            this.fld_btnViewTemplate.Location = new System.Drawing.Point(664, 32);
            this.fld_btnViewTemplate.Name = "fld_btnViewTemplate";
            this.fld_btnViewTemplate.Screen = null;
            this.fld_btnViewTemplate.Size = new System.Drawing.Size(75, 27);
            this.fld_btnViewTemplate.TabIndex = 15;
            this.fld_btnViewTemplate.Text = "Xem tài liệu";
            this.fld_btnViewTemplate.Click += new System.EventHandler(this.fld_btnViewTemplate_Click);
            // 
            // fld_btnDeleteTemplate
            // 
            this.fld_btnDeleteTemplate.BOSComment = null;
            this.fld_btnDeleteTemplate.BOSDataMember = null;
            this.fld_btnDeleteTemplate.BOSDataSource = null;
            this.fld_btnDeleteTemplate.BOSDescription = null;
            this.fld_btnDeleteTemplate.BOSError = null;
            this.fld_btnDeleteTemplate.BOSFieldGroup = null;
            this.fld_btnDeleteTemplate.BOSFieldRelation = null;
            this.fld_btnDeleteTemplate.BOSPrivilege = null;
            this.fld_btnDeleteTemplate.BOSPropertyName = null;
            this.fld_btnDeleteTemplate.Location = new System.Drawing.Point(764, 32);
            this.fld_btnDeleteTemplate.Name = "fld_btnDeleteTemplate";
            this.fld_btnDeleteTemplate.Screen = null;
            this.fld_btnDeleteTemplate.Size = new System.Drawing.Size(75, 27);
            this.fld_btnDeleteTemplate.TabIndex = 17;
            this.fld_btnDeleteTemplate.Text = "Xóa tài liệu";
            this.fld_btnDeleteTemplate.Click += new System.EventHandler(this.fld_btnDeleteTemplate_Click);
            // 
            // DMSF102
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Name = "DMSF102";
            this.Text = "Tài liệu đính kèm";
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleForecastTemplates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleForecastTemplates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFilePath.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSTextBox fld_txtFilePath;
        private BOSComponent.BOSButton fld_btnBrowseFile;
        private BOSComponent.BOSButton fld_btnUploadProposalTemplate;
        private BOSComponent.BOSButton fld_btnViewTemplate;
        private BOSComponent.BOSButton fld_btnDeleteTemplate;
        private ARSaleForecastTemplatesGridControl fld_dgcARSaleForecastTemplates;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleForecastTemplates;
	}
}
