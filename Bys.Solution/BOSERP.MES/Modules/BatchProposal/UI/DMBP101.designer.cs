using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.BatchProposal.UI
{
	/// <summary>
	/// Summary description for DMBP101
	/// </summary>
	partial class DMBP101
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
            this.fld_dgcMMProposalTemplates = new BOSERP.Modules.BatchProposal.MMProposalTemplatesGridControl();
            this.fld_dgvARSaleForecastTemplates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtFilePath = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnBrowseFile = new BOSComponent.BOSButton(this.components);
            this.fld_btnUploadProposalTemplate = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProposalTemplates)).BeginInit();
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
            this.fld_grcGroupControl.BOSComment = string.Empty;
            this.fld_grcGroupControl.BOSDataMember = string.Empty;
            this.fld_grcGroupControl.BOSDataSource = string.Empty;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = string.Empty;
            this.fld_grcGroupControl.BOSFieldRelation = string.Empty;
            this.fld_grcGroupControl.BOSPrivilege = string.Empty;
            this.fld_grcGroupControl.BOSPropertyName = string.Empty;
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcMMProposalTemplates);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel17);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtFilePath);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnBrowseFile);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnUploadProposalTemplate);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(862, 567);
            this.fld_grcGroupControl.TabIndex = 4;
            this.fld_grcGroupControl.Tag = string.Empty;
            this.fld_grcGroupControl.Text = "Tài liệu đính kèm";
            // 
            // fld_dgcMMProposalTemplates
            // 
            this.fld_dgcMMProposalTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProposalTemplates.BOSComment = string.Empty;
            this.fld_dgcMMProposalTemplates.BOSDataMember = string.Empty;
            this.fld_dgcMMProposalTemplates.BOSDataSource = "MMProposalTemplates";
            this.fld_dgcMMProposalTemplates.BOSDescription = null;
            this.fld_dgcMMProposalTemplates.BOSError = null;
            this.fld_dgcMMProposalTemplates.BOSFieldGroup = string.Empty;
            this.fld_dgcMMProposalTemplates.BOSFieldRelation = string.Empty;
            this.fld_dgcMMProposalTemplates.BOSGridType = null;
            this.fld_dgcMMProposalTemplates.BOSPrivilege = string.Empty;
            this.fld_dgcMMProposalTemplates.BOSPropertyName = string.Empty;
            this.fld_dgcMMProposalTemplates.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProposalTemplates.Location = new System.Drawing.Point(12, 76);
            this.fld_dgcMMProposalTemplates.MainView = this.fld_dgvARSaleForecastTemplates;
            this.fld_dgcMMProposalTemplates.Name = "fld_dgcMMProposalTemplates";
            this.fld_dgcMMProposalTemplates.PrintReport = false;
            this.fld_dgcMMProposalTemplates.Screen = null;
            this.fld_dgcMMProposalTemplates.Size = new System.Drawing.Size(838, 479);
            this.fld_dgcMMProposalTemplates.TabIndex = 21;
            this.fld_dgcMMProposalTemplates.Tag = "DC";
            this.fld_dgcMMProposalTemplates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleForecastTemplates});
            // 
            // fld_dgvARSaleForecastTemplates
            // 
            this.fld_dgvARSaleForecastTemplates.GridControl = this.fld_dgcMMProposalTemplates;
            this.fld_dgvARSaleForecastTemplates.Name = "fld_dgvARSaleForecastTemplates";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = string.Empty;
            this.fld_lblLabel17.BOSDataMember = string.Empty;
            this.fld_lblLabel17.BOSDataSource = string.Empty;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = string.Empty;
            this.fld_lblLabel17.BOSFieldRelation = string.Empty;
            this.fld_lblLabel17.BOSPrivilege = string.Empty;
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(12, 36);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel17.TabIndex = 20;
            this.fld_lblLabel17.Tag = string.Empty;
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
            this.fld_txtFilePath.EditValue = string.Empty;
            this.fld_txtFilePath.Enabled = false;
            this.fld_txtFilePath.Location = new System.Drawing.Point(89, 36);
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
            this.fld_btnBrowseFile.Location = new System.Drawing.Point(442, 36);
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
            this.fld_btnUploadProposalTemplate.Location = new System.Drawing.Point(491, 32);
            this.fld_btnUploadProposalTemplate.Name = "fld_btnUploadProposalTemplate";
            this.fld_btnUploadProposalTemplate.Screen = null;
            this.fld_btnUploadProposalTemplate.Size = new System.Drawing.Size(75, 27);
            this.fld_btnUploadProposalTemplate.TabIndex = 16;
            this.fld_btnUploadProposalTemplate.Text = "Thêm tài liệu";
            this.fld_btnUploadProposalTemplate.Click += new System.EventHandler(this.fld_btnUploadProposalTemplate_Click);
            // 
            // DMBP101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Name = "DMBP101";
            this.Text = "Tài liệu đính kèm";
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProposalTemplates)).EndInit();
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
        private MMProposalTemplatesGridControl fld_dgcMMProposalTemplates;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleForecastTemplates;
	}
}
