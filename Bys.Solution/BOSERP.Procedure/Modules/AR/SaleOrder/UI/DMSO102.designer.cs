using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using BOSComponent;

namespace BOSERP.Modules.SaleOrder.UI
{
	/// <summary>
	/// Summary description for DMSO102
	/// </summary>
	partial class DMSO102
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMSO102));
            this.fld_pnlMainScreen = new BOSComponent.BOSPanel(this.components);
            this.fld_txtFileName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARSaleOrderTemplatesGridControl = new BOSERP.Modules.SaleOrder.ARSaleOrderTemplatesGridControl();
            this.fld_dgvARSaleForecastTemplates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtFilePath = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnBrowseFile = new BOSComponent.BOSButton(this.components);
            this.fld_btnUploadSaleOrderTemplate = new BOSComponent.BOSButton(this.components);
            this.fld_pnlMainScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderTemplatesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleForecastTemplates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFilePath.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_pnlMainScreen
            // 
            this.fld_pnlMainScreen.BOSComment = null;
            this.fld_pnlMainScreen.BOSDataMember = null;
            this.fld_pnlMainScreen.BOSDataSource = null;
            this.fld_pnlMainScreen.BOSDescription = null;
            this.fld_pnlMainScreen.BOSError = null;
            this.fld_pnlMainScreen.BOSFieldGroup = null;
            this.fld_pnlMainScreen.BOSFieldRelation = null;
            this.fld_pnlMainScreen.BOSPrivilege = null;
            this.fld_pnlMainScreen.BOSPropertyName = null;
            this.fld_pnlMainScreen.Controls.Add(this.fld_txtFileName);
            this.fld_pnlMainScreen.Controls.Add(this.bosLabel1);
            this.fld_pnlMainScreen.Controls.Add(this.fld_dgcARSaleOrderTemplatesGridControl);
            this.fld_pnlMainScreen.Controls.Add(this.fld_lblLabel17);
            this.fld_pnlMainScreen.Controls.Add(this.fld_txtFilePath);
            this.fld_pnlMainScreen.Controls.Add(this.fld_btnBrowseFile);
            this.fld_pnlMainScreen.Controls.Add(this.fld_btnUploadSaleOrderTemplate);
            this.fld_pnlMainScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_pnlMainScreen.Location = new System.Drawing.Point(0, 0);
            this.fld_pnlMainScreen.Name = "fld_pnlMainScreen";
            this.fld_pnlMainScreen.Screen = null;
            this.fld_pnlMainScreen.Size = new System.Drawing.Size(918, 595);
            this.fld_pnlMainScreen.TabIndex = 6;
            // 
            // fld_txtFileName
            // 
            this.fld_txtFileName.BOSComment = null;
            this.fld_txtFileName.BOSDataMember = "ARSaleOrderTemplateName";
            this.fld_txtFileName.BOSDataSource = "ARSaleOrderTemplates";
            this.fld_txtFileName.BOSDescription = null;
            this.fld_txtFileName.BOSError = null;
            this.fld_txtFileName.BOSFieldGroup = null;
            this.fld_txtFileName.BOSFieldRelation = null;
            this.fld_txtFileName.BOSPrivilege = null;
            this.fld_txtFileName.BOSPropertyName = null;
            this.fld_txtFileName.EditValue = "";
            this.fld_txtFileName.Location = new System.Drawing.Point(89, 33);
            this.fld_txtFileName.MenuManager = this.screenToolbar;
            this.fld_txtFileName.Name = "fld_txtFileName";
            this.fld_txtFileName.Screen = null;
            this.fld_txtFileName.Size = new System.Drawing.Size(347, 20);
            this.fld_txtFileName.TabIndex = 28;
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(12, 36);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(52, 13);
            this.bosLabel1.TabIndex = 27;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Tên tài liệu";
            // 
            // fld_dgcARSaleOrderTemplatesGridControl
            // 
            this.fld_dgcARSaleOrderTemplatesGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleOrderTemplatesGridControl.BOSComment = "";
            this.fld_dgcARSaleOrderTemplatesGridControl.BOSDataMember = "";
            this.fld_dgcARSaleOrderTemplatesGridControl.BOSDataSource = "ARSaleOrderTemplates";
            this.fld_dgcARSaleOrderTemplatesGridControl.BOSDescription = null;
            this.fld_dgcARSaleOrderTemplatesGridControl.BOSError = null;
            this.fld_dgcARSaleOrderTemplatesGridControl.BOSFieldGroup = "";
            this.fld_dgcARSaleOrderTemplatesGridControl.BOSFieldRelation = "";
            this.fld_dgcARSaleOrderTemplatesGridControl.BOSGridType = null;
            this.fld_dgcARSaleOrderTemplatesGridControl.BOSPrivilege = "";
            this.fld_dgcARSaleOrderTemplatesGridControl.BOSPropertyName = "";
            this.fld_dgcARSaleOrderTemplatesGridControl.CommodityType = "";
            this.fld_dgcARSaleOrderTemplatesGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSaleOrderTemplatesGridControl.Location = new System.Drawing.Point(12, 66);
            this.fld_dgcARSaleOrderTemplatesGridControl.MainView = this.fld_dgvARSaleForecastTemplates;
            this.fld_dgcARSaleOrderTemplatesGridControl.Name = "fld_dgcARSaleOrderTemplatesGridControl";
            this.fld_dgcARSaleOrderTemplatesGridControl.PrintReport = false;
            this.fld_dgcARSaleOrderTemplatesGridControl.Screen = null;
            this.fld_dgcARSaleOrderTemplatesGridControl.Size = new System.Drawing.Size(894, 517);
            this.fld_dgcARSaleOrderTemplatesGridControl.TabIndex = 26;
            this.fld_dgcARSaleOrderTemplatesGridControl.Tag = "DC";
            this.fld_dgcARSaleOrderTemplatesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleForecastTemplates});
            // 
            // fld_dgvARSaleForecastTemplates
            // 
            this.fld_dgvARSaleForecastTemplates.GridControl = this.fld_dgcARSaleOrderTemplatesGridControl;
            this.fld_dgvARSaleForecastTemplates.Name = "fld_dgvARSaleForecastTemplates";
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
            this.fld_lblLabel17.Location = new System.Drawing.Point(12, 12);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel17.TabIndex = 25;
            this.fld_lblLabel17.Tag = "";
            this.fld_lblLabel17.Text = "File đính kèm";
            // 
            // fld_txtFilePath
            // 
            this.fld_txtFilePath.BOSComment = null;
            this.fld_txtFilePath.BOSDataMember = "ARSaleOrderTemplateFileGUID";
            this.fld_txtFilePath.BOSDataSource = "ARSaleOrderTemplates";
            this.fld_txtFilePath.BOSDescription = null;
            this.fld_txtFilePath.BOSError = null;
            this.fld_txtFilePath.BOSFieldGroup = null;
            this.fld_txtFilePath.BOSFieldRelation = null;
            this.fld_txtFilePath.BOSPrivilege = null;
            this.fld_txtFilePath.BOSPropertyName = null;
            this.fld_txtFilePath.EditValue = "";
            this.fld_txtFilePath.Location = new System.Drawing.Point(89, 9);
            this.fld_txtFilePath.MenuManager = this.screenToolbar;
            this.fld_txtFilePath.Name = "fld_txtFilePath";
            this.fld_txtFilePath.Screen = null;
            this.fld_txtFilePath.Size = new System.Drawing.Size(347, 20);
            this.fld_txtFilePath.TabIndex = 23;
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
            this.fld_btnBrowseFile.Location = new System.Drawing.Point(442, 26);
            this.fld_btnBrowseFile.Name = "fld_btnBrowseFile";
            this.fld_btnBrowseFile.Screen = null;
            this.fld_btnBrowseFile.Size = new System.Drawing.Size(38, 20);
            this.fld_btnBrowseFile.TabIndex = 24;
            this.fld_btnBrowseFile.Text = "....";
            this.fld_btnBrowseFile.Visible = false;
            this.fld_btnBrowseFile.Click += new System.EventHandler(this.fld_btnBrowseFile_Click);
            // 
            // fld_btnUploadSaleOrderTemplate
            // 
            this.fld_btnUploadSaleOrderTemplate.BOSComment = null;
            this.fld_btnUploadSaleOrderTemplate.BOSDataMember = null;
            this.fld_btnUploadSaleOrderTemplate.BOSDataSource = null;
            this.fld_btnUploadSaleOrderTemplate.BOSDescription = null;
            this.fld_btnUploadSaleOrderTemplate.BOSError = null;
            this.fld_btnUploadSaleOrderTemplate.BOSFieldGroup = null;
            this.fld_btnUploadSaleOrderTemplate.BOSFieldRelation = null;
            this.fld_btnUploadSaleOrderTemplate.BOSPrivilege = null;
            this.fld_btnUploadSaleOrderTemplate.BOSPropertyName = null;
            this.fld_btnUploadSaleOrderTemplate.Location = new System.Drawing.Point(442, 12);
            this.fld_btnUploadSaleOrderTemplate.Name = "fld_btnUploadSaleOrderTemplate";
            this.fld_btnUploadSaleOrderTemplate.Screen = null;
            this.fld_btnUploadSaleOrderTemplate.Size = new System.Drawing.Size(75, 41);
            this.fld_btnUploadSaleOrderTemplate.TabIndex = 22;
            this.fld_btnUploadSaleOrderTemplate.Text = "Thêm tài liệu";
            this.fld_btnUploadSaleOrderTemplate.Click += new System.EventHandler(this.fld_btnUploadSaleOrderTemplate_Click);
            // 
            // DMSO102
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(918, 595);
            this.Controls.Add(this.fld_pnlMainScreen);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMSO102.IconOptions.Icon")));
            this.Name = "DMSO102";
            this.Text = "Tài liệu đính kèm";
            this.Controls.SetChildIndex(this.fld_pnlMainScreen, 0);
            this.fld_pnlMainScreen.ResumeLayout(false);
            this.fld_pnlMainScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderTemplatesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleForecastTemplates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFilePath.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSPanel fld_pnlMainScreen;
        private BOSERP.Modules.SaleOrder.ARSaleOrderTemplatesGridControl fld_dgcARSaleOrderTemplatesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleForecastTemplates;
        private BOSLabel fld_lblLabel17;
        private BOSTextBox fld_txtFilePath;
        private BOSButton fld_btnBrowseFile;
        private BOSButton fld_btnUploadSaleOrderTemplate;
        private BOSTextBox fld_txtFileName;
        private BOSLabel bosLabel1;
    }
}
