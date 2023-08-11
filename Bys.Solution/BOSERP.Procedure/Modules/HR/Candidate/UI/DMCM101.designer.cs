using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Candidate.UI
{
	/// <summary>
	/// Summary description for DMCM101
	/// </summary>
	partial class DMCM101
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
            this.fld_tabTemplate = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddTemplates = new BOSComponent.BOSButton(this.components);
            this.fld_dgcHRCandidateTemplates = new BOSERP.Modules.Candidate.HRCandidateTemplatesGridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtFilePath = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnBrowseFile = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabTemplate)).BeginInit();
            this.fld_tabTemplate.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRCandidateTemplates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFilePath.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.fld_tabTemplate.Size = new System.Drawing.Size(868, 574);
            this.fld_tabTemplate.TabIndex = 17;
            this.fld_tabTemplate.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            this.fld_tabTemplate.Tag = "";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_btnAddTemplates);
            this.xtraTabPage2.Controls.Add(this.fld_dgcHRCandidateTemplates);
            this.xtraTabPage2.Controls.Add(this.fld_lblLabel17);
            this.xtraTabPage2.Controls.Add(this.fld_txtFilePath);
            this.xtraTabPage2.Controls.Add(this.fld_btnBrowseFile);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(862, 546);
            this.xtraTabPage2.Text = "Tài liệu đính kèm";
            // 
            // fld_btnAddTemplates
            // 
            this.fld_btnAddTemplates.BOSComment = null;
            this.fld_btnAddTemplates.BOSDataMember = null;
            this.fld_btnAddTemplates.BOSDataSource = null;
            this.fld_btnAddTemplates.BOSDescription = null;
            this.fld_btnAddTemplates.BOSError = null;
            this.fld_btnAddTemplates.BOSFieldGroup = null;
            this.fld_btnAddTemplates.BOSFieldRelation = null;
            this.fld_btnAddTemplates.BOSPrivilege = null;
            this.fld_btnAddTemplates.BOSPropertyName = null;
            this.fld_btnAddTemplates.Location = new System.Drawing.Point(487, 8);
            this.fld_btnAddTemplates.Name = "fld_btnAddTemplates";
            this.fld_btnAddTemplates.Screen = null;
            this.fld_btnAddTemplates.Size = new System.Drawing.Size(75, 27);
            this.fld_btnAddTemplates.TabIndex = 16;
            this.fld_btnAddTemplates.Text = "Thêm tài liệu";
            this.fld_btnAddTemplates.Click += new System.EventHandler(this.Fld_btnAddTemplates_Click);
            // 
            // fld_dgcHRCandidateTemplates
            // 
            this.fld_dgcHRCandidateTemplates.AllowDrop = true;
            this.fld_dgcHRCandidateTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRCandidateTemplates.BOSComment = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_dgcHRCandidateTemplates.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_dgcHRCandidateTemplates.BOSDataSource = "HRCandidateTemplates";
            this.fld_dgcHRCandidateTemplates.BOSDescription = null;
            this.fld_dgcHRCandidateTemplates.BOSError = null;
            this.fld_dgcHRCandidateTemplates.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_dgcHRCandidateTemplates.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_dgcHRCandidateTemplates.BOSGridType = null;
            this.fld_dgcHRCandidateTemplates.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_dgcHRCandidateTemplates.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_dgcHRCandidateTemplates.CommodityType = "";
            this.fld_dgcHRCandidateTemplates.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRCandidateTemplates.Location = new System.Drawing.Point(3, 41);
            this.fld_dgcHRCandidateTemplates.MainView = this.gridView;
            this.fld_dgcHRCandidateTemplates.Name = "fld_dgcHRCandidateTemplates";
            this.fld_dgcHRCandidateTemplates.PrintReport = false;
            this.fld_dgcHRCandidateTemplates.Screen = null;
            this.fld_dgcHRCandidateTemplates.Size = new System.Drawing.Size(859, 502);
            this.fld_dgcHRCandidateTemplates.TabIndex = 15;
            this.fld_dgcHRCandidateTemplates.Tag = "DC";
            this.fld_dgcHRCandidateTemplates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.GridControl = this.fld_dgcHRCandidateTemplates;
            this.gridView.Name = "gridView";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = "";
            this.fld_lblLabel17.BOSDataMember = "";
            this.fld_lblLabel17.BOSDataSource = "";
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = "";
            this.fld_lblLabel17.BOSFieldRelation = "";
            this.fld_lblLabel17.BOSPrivilege = "";
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(21, 18);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel17.TabIndex = 14;
            this.fld_lblLabel17.Tag = "";
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
            this.fld_txtFilePath.EditValue = "";
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
            this.fld_btnBrowseFile.Click += new System.EventHandler(this.Fld_btnBrowseFile_Click);
            // 
            // DMCM101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(868, 574);
            this.Controls.Add(this.fld_tabTemplate);
            this.Name = "DMCM101";
            this.Text = "Tài liệu đính kèm";
            this.Controls.SetChildIndex(this.fld_tabTemplate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabTemplate)).EndInit();
            this.fld_tabTemplate.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRCandidateTemplates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFilePath.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        #endregion

        private BOSComponent.BOSTabControl fld_tabTemplate;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSButton fld_btnAddTemplates;
        private HRCandidateTemplatesGridControl fld_dgcHRCandidateTemplates;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSTextBox fld_txtFilePath;
        private BOSComponent.BOSButton fld_btnBrowseFile;
        private IContainer components;
    }
}
