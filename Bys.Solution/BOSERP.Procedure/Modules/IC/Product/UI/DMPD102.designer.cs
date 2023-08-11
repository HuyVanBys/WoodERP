using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Product.UI
{
	/// <summary>
	/// Summary description for DMPD102
	/// </summary>
	partial class DMPD102
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
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductProfile = new BOSERP.Modules.Product.ICProductProfileGridControl();
            this.fld_dgvARDocumentPayments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtFilePath = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnBrowseFile = new BOSComponent.BOSButton(this.components);
            this.fld_btnUploadProposalTemplate = new BOSComponent.BOSButton(this.components);
            this.fld_btnViewTemplate = new BOSComponent.BOSButton(this.components);
            this.fld_btnDeleteTemplate = new BOSComponent.BOSButton(this.components);
            this.fld_tabTemplate = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARDocumentPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFilePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabTemplate)).BeginInit();
            this.fld_tabTemplate.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcICProductProfile);
            this.xtraTabPage2.Controls.Add(this.fld_lblLabel17);
            this.xtraTabPage2.Controls.Add(this.fld_txtFilePath);
            this.xtraTabPage2.Controls.Add(this.fld_btnBrowseFile);
            this.xtraTabPage2.Controls.Add(this.fld_btnUploadProposalTemplate);
            this.xtraTabPage2.Controls.Add(this.fld_btnViewTemplate);
            this.xtraTabPage2.Controls.Add(this.fld_btnDeleteTemplate);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(855, 538);
            this.xtraTabPage2.Text = "Tài liệu đính kèm";
            // 
            // fld_dgcICProductProfile
            // 
            this.fld_dgcICProductProfile.AllowDrop = true;
            this.fld_dgcICProductProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductProfile.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProductProfile.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProductProfile.BOSDataSource = "ICProductProfiles";
            this.fld_dgcICProductProfile.BOSDescription = null;
            this.fld_dgcICProductProfile.BOSError = null;
            this.fld_dgcICProductProfile.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProductProfile.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProductProfile.BOSGridType = null;
            this.fld_dgcICProductProfile.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProductProfile.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProductProfile.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICProductProfile.Location = new System.Drawing.Point(3, 41);
            this.fld_dgcICProductProfile.MainView = this.fld_dgvARDocumentPayments;
            this.fld_dgcICProductProfile.Name = "fld_dgcICProductProfile";
            this.fld_dgcICProductProfile.PrintReport = false;
            this.fld_dgcICProductProfile.Screen = null;
            this.fld_dgcICProductProfile.Size = new System.Drawing.Size(852, 494);
            this.fld_dgcICProductProfile.TabIndex = 15;
            this.fld_dgcICProductProfile.Tag = "DC";
            this.fld_dgcICProductProfile.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARDocumentPayments});
            // 
            // fld_dgvARDocumentPayments
            // 
            this.fld_dgvARDocumentPayments.GridControl = this.fld_dgcICProductProfile;
            this.fld_dgvARDocumentPayments.Name = "fld_dgvARDocumentPayments";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel17.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel17.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel17.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel17.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(21, 18);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel17.TabIndex = 14;
            this.fld_lblLabel17.Tag = global::Localization.CommonLocalizedResources.String2;
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
            this.fld_txtFilePath.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtFilePath.Enabled = false;
            this.fld_txtFilePath.Location = new System.Drawing.Point(98, 15);
            this.fld_txtFilePath.MenuManager = this.screenToolbar;
            this.fld_txtFilePath.Name = "fld_txtFilePath";
            this.fld_txtFilePath.Screen = null;
            this.fld_txtFilePath.Size = new System.Drawing.Size(347, 20);
            this.fld_txtFilePath.TabIndex = 8;
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
            this.fld_btnBrowseFile.Location = new System.Drawing.Point(451, 15);
            this.fld_btnBrowseFile.Name = "fld_btnBrowseFile";
            this.fld_btnBrowseFile.Screen = null;
            this.fld_btnBrowseFile.Size = new System.Drawing.Size(30, 20);
            this.fld_btnBrowseFile.TabIndex = 9;
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
            this.fld_btnUploadProposalTemplate.Location = new System.Drawing.Point(573, 8);
            this.fld_btnUploadProposalTemplate.Name = "fld_btnUploadProposalTemplate";
            this.fld_btnUploadProposalTemplate.Screen = null;
            this.fld_btnUploadProposalTemplate.Size = new System.Drawing.Size(75, 27);
            this.fld_btnUploadProposalTemplate.TabIndex = 7;
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
            this.fld_btnViewTemplate.Location = new System.Drawing.Point(673, 8);
            this.fld_btnViewTemplate.Name = "fld_btnViewTemplate";
            this.fld_btnViewTemplate.Screen = null;
            this.fld_btnViewTemplate.Size = new System.Drawing.Size(75, 27);
            this.fld_btnViewTemplate.TabIndex = 7;
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
            this.fld_btnDeleteTemplate.Location = new System.Drawing.Point(773, 8);
            this.fld_btnDeleteTemplate.Name = "fld_btnDeleteTemplate";
            this.fld_btnDeleteTemplate.Screen = null;
            this.fld_btnDeleteTemplate.Size = new System.Drawing.Size(75, 27);
            this.fld_btnDeleteTemplate.TabIndex = 8;
            this.fld_btnDeleteTemplate.Text = "Xóa tài liệu";
            this.fld_btnDeleteTemplate.Click += new System.EventHandler(this.fld_btnDeleteTemplate_Click);
            // 
            // fld_tabTemplate
            // 
            this.fld_tabTemplate.BOSComment = null;
            this.fld_tabTemplate.BOSDataMember = null;
            this.fld_tabTemplate.BOSDataSource = null;
            this.fld_tabTemplate.BOSDescription = null;
            this.fld_tabTemplate.BOSError = null;
            this.fld_tabTemplate.BOSFieldGroup = null;
            this.fld_tabTemplate.BOSFieldRelation = null;
            this.fld_tabTemplate.BOSPrivilege = null;
            this.fld_tabTemplate.BOSPropertyName = null;
            this.fld_tabTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_tabTemplate.Location = new System.Drawing.Point(0, 0);
            this.fld_tabTemplate.Name = "fld_tabTemplate";
            this.fld_tabTemplate.Screen = null;
            this.fld_tabTemplate.SelectedTabPage = this.xtraTabPage2;
            this.fld_tabTemplate.Size = new System.Drawing.Size(862, 567);
            this.fld_tabTemplate.TabIndex = 15;
            this.fld_tabTemplate.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            this.fld_tabTemplate.Tag = global::Localization.CommonLocalizedResources.String2;
            // 
            // DMPD102
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_tabTemplate);
            this.Name = "DMPD102";
            this.Text = "Tài liệu đính kèm";
            this.Controls.SetChildIndex(this.fld_tabTemplate, 0);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARDocumentPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFilePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabTemplate)).EndInit();
            this.fld_tabTemplate.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSTextBox fld_txtFilePath;
        private BOSComponent.BOSButton fld_btnBrowseFile;
        private BOSComponent.BOSButton fld_btnUploadProposalTemplate;
        private BOSComponent.BOSButton fld_btnViewTemplate;
        private BOSComponent.BOSButton fld_btnDeleteTemplate;
        private BOSComponent.BOSTabControl fld_tabTemplate;
        private ICProductProfileGridControl fld_dgcICProductProfile;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARDocumentPayments;
	}
}
