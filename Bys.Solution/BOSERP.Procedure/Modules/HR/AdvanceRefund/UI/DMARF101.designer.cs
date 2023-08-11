using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AdvanceRefund.UI
{
	/// <summary>
	/// Summary description for DMBP101
	/// </summary>
    partial class DMARF101
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
            this.fld_dgcAdvanceRefundTemplates123 = new BOSERP.Modules.AdvanceRefund.HRAdvanceRefundTemplatesGridControl();
            this.fld_dgvAdvanceRefundTemplates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtFilePath = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnBrowseFile = new BOSComponent.BOSButton(this.components);
            this.fld_btnUploadProposalTemplate = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAdvanceRefundTemplates123)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAdvanceRefundTemplates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFilePath.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_dgcAdvanceRefundTemplates123
            // 
            this.fld_dgcAdvanceRefundTemplates123.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAdvanceRefundTemplates123.BOSComment = null;
            this.fld_dgcAdvanceRefundTemplates123.BOSDataMember = null;
            this.fld_dgcAdvanceRefundTemplates123.BOSDataSource = "HRAdvanceRefundTemplates";
            this.fld_dgcAdvanceRefundTemplates123.BOSDescription = null;
            this.fld_dgcAdvanceRefundTemplates123.BOSError = null;
            this.fld_dgcAdvanceRefundTemplates123.BOSFieldGroup = null;
            this.fld_dgcAdvanceRefundTemplates123.BOSFieldRelation = null;
            this.fld_dgcAdvanceRefundTemplates123.BOSGridType = null;
            this.fld_dgcAdvanceRefundTemplates123.BOSPrivilege = null;
            this.fld_dgcAdvanceRefundTemplates123.BOSPropertyName = null;
            this.fld_dgcAdvanceRefundTemplates123.CommodityType = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcAdvanceRefundTemplates123.Location = new System.Drawing.Point(3, 42);
            this.fld_dgcAdvanceRefundTemplates123.MenuManager = this.screenToolbar;
            this.fld_dgcAdvanceRefundTemplates123.MainView = this.fld_dgvAdvanceRefundTemplates;
            this.fld_dgcAdvanceRefundTemplates123.Name = "fld_dgcAdvanceRefundTemplates123";
            this.fld_dgcAdvanceRefundTemplates123.PrintReport = false;
            this.fld_dgcAdvanceRefundTemplates123.Screen = null;
            this.fld_dgcAdvanceRefundTemplates123.Size = new System.Drawing.Size(856, 522);
            this.fld_dgcAdvanceRefundTemplates123.TabIndex = 21;
            this.fld_dgcAdvanceRefundTemplates123.Tag = "DC";
            this.fld_dgcAdvanceRefundTemplates123.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAdvanceRefundTemplates});
            // 
            // fld_dgvAdvanceRefundTemplates
            // 
            this.fld_dgvAdvanceRefundTemplates.GridControl = this.fld_dgcAdvanceRefundTemplates123;
            this.fld_dgvAdvanceRefundTemplates.Name = "fld_dgvAdvanceRefundTemplates";
            // 
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.fld_lblLabel17.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.fld_lblLabel17.BOSDataSource = global::Localization.ReportLocalizedResources.String2;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.fld_lblLabel17.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.fld_lblLabel17.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(21, 16);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel17.TabIndex = 20;
            this.fld_lblLabel17.Tag = global::Localization.ReportLocalizedResources.String2;
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
            this.fld_txtFilePath.EditValue = global::Localization.ReportLocalizedResources.String2;
            this.fld_txtFilePath.Enabled = false;
            this.fld_txtFilePath.Location = new System.Drawing.Point(98, 12);
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
            this.fld_btnBrowseFile.Location = new System.Drawing.Point(476, 12);
            this.fld_btnBrowseFile.Name = "fld_btnBrowseFile";
            this.fld_btnBrowseFile.Screen = null;
            this.fld_btnBrowseFile.Size = new System.Drawing.Size(38, 20);
            this.fld_btnBrowseFile.TabIndex = 19;
            this.fld_btnBrowseFile.Text = "....";
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
            this.fld_btnUploadProposalTemplate.Location = new System.Drawing.Point(529, 9);
            this.fld_btnUploadProposalTemplate.Name = "fld_btnUploadProposalTemplate";
            this.fld_btnUploadProposalTemplate.Screen = null;
            this.fld_btnUploadProposalTemplate.Size = new System.Drawing.Size(75, 27);
            this.fld_btnUploadProposalTemplate.TabIndex = 16;
            this.fld_btnUploadProposalTemplate.Text = "Thêm tài liệu";
            this.fld_btnUploadProposalTemplate.Click += new System.EventHandler(this.fld_btnUploadProposalTemplate_Click);
            // 
            // bosPanel1
            // 
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_btnBrowseFile);
            this.bosPanel1.Controls.Add(this.fld_dgcAdvanceRefundTemplates123);
            this.bosPanel1.Controls.Add(this.fld_btnUploadProposalTemplate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel17);
            this.bosPanel1.Controls.Add(this.fld_txtFilePath);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 7;
            // 
            // DMARF101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMARF101";
            this.Text = "Tài liệu đính kèm";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAdvanceRefundTemplates123)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAdvanceRefundTemplates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFilePath.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSTextBox fld_txtFilePath;
        private BOSComponent.BOSButton fld_btnBrowseFile;
        private BOSComponent.BOSButton fld_btnUploadProposalTemplate;
        private BOSERP.Modules.AdvanceRefund.HRAdvanceRefundTemplatesGridControl fld_dgcAdvanceRefundTemplates123;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAdvanceRefundTemplates;
        private BOSComponent.BOSPanel bosPanel1;
	}
}
