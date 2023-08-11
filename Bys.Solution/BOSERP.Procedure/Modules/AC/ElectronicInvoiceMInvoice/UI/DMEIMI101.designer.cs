using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using BOSComponent;

namespace BOSERP.Modules.ElectronicInvoiceMInvoice.UI
{
	/// <summary>
    /// Summary description for DMAS101
	/// </summary>
    partial class DMEIMI101
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
            this.fld_pnlMainScreen = new BOSComponent.BOSPanel(this.components);
            this.fld_dgcEInvoiceTemplates = new EInvoiceTemplatesGridControl();
            this.fld_dgvARSaleForecastTemplates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtFilePath = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnBrowseFile = new BOSComponent.BOSButton(this.components);
            this.fld_btnUploadSaleOrderTemplate = new BOSComponent.BOSButton(this.components);
            this.fld_pnlMainScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcEInvoiceTemplates)).BeginInit();
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
            this.fld_pnlMainScreen.Controls.Add(this.fld_dgcEInvoiceTemplates);
            this.fld_pnlMainScreen.Controls.Add(this.fld_lblLabel17);
            this.fld_pnlMainScreen.Controls.Add(this.fld_txtFilePath);
            this.fld_pnlMainScreen.Controls.Add(this.fld_btnBrowseFile);
            this.fld_pnlMainScreen.Controls.Add(this.fld_btnUploadSaleOrderTemplate);
            this.fld_pnlMainScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_pnlMainScreen.Location = new System.Drawing.Point(0, 0);
            this.fld_pnlMainScreen.Name = "fld_pnlMainScreen";
            this.fld_pnlMainScreen.Screen = null;
            this.fld_pnlMainScreen.Size = new System.Drawing.Size(874, 581);
            this.fld_pnlMainScreen.TabIndex = 6;
            // 
            // fld_dgcEInvoiceTemplates
            // 
            this.fld_dgcEInvoiceTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcEInvoiceTemplates.BOSComment = "";
            this.fld_dgcEInvoiceTemplates.BOSDataMember = "";
            this.fld_dgcEInvoiceTemplates.BOSDataSource = "ACFileAttachments";
            this.fld_dgcEInvoiceTemplates.BOSDescription = null;
            this.fld_dgcEInvoiceTemplates.BOSError = null;
            this.fld_dgcEInvoiceTemplates.BOSFieldGroup = "";
            this.fld_dgcEInvoiceTemplates.BOSFieldRelation = "";
            this.fld_dgcEInvoiceTemplates.BOSGridType = null;
            this.fld_dgcEInvoiceTemplates.BOSPrivilege = "";
            this.fld_dgcEInvoiceTemplates.BOSPropertyName = "";
            this.fld_dgcEInvoiceTemplates.CommodityType = "";
            this.fld_dgcEInvoiceTemplates.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcEInvoiceTemplates.Location = new System.Drawing.Point(12, 66);
            this.fld_dgcEInvoiceTemplates.MainView = this.fld_dgvARSaleForecastTemplates;
            this.fld_dgcEInvoiceTemplates.Name = "fld_dgcEInvoiceTemplates";
            this.fld_dgcEInvoiceTemplates.PrintReport = false;
            this.fld_dgcEInvoiceTemplates.Screen = null;
            this.fld_dgcEInvoiceTemplates.Size = new System.Drawing.Size(850, 503);
            this.fld_dgcEInvoiceTemplates.TabIndex = 26;
            this.fld_dgcEInvoiceTemplates.Tag = "DC";
            this.fld_dgcEInvoiceTemplates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleForecastTemplates});
            // 
            // fld_dgvARSaleForecastTemplates
            // 
            this.fld_dgvARSaleForecastTemplates.GridControl = this.fld_dgcEInvoiceTemplates;
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
            this.fld_lblLabel17.Location = new System.Drawing.Point(12, 26);
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
            this.fld_txtFilePath.Location = new System.Drawing.Point(89, 26);
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
            this.fld_btnUploadSaleOrderTemplate.Location = new System.Drawing.Point(491, 22);
            this.fld_btnUploadSaleOrderTemplate.Name = "fld_btnUploadSaleOrderTemplate";
            this.fld_btnUploadSaleOrderTemplate.Screen = null;
            this.fld_btnUploadSaleOrderTemplate.Size = new System.Drawing.Size(75, 27);
            this.fld_btnUploadSaleOrderTemplate.TabIndex = 22;
            this.fld_btnUploadSaleOrderTemplate.Text = "Thêm tài liệu";
            this.fld_btnUploadSaleOrderTemplate.Click += new System.EventHandler(this.fld_btnUploadSaleOrderTemplate_Click);
            // 
            // DMEI101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(874, 581);
            this.Controls.Add(this.fld_pnlMainScreen);
            this.Name = "DMEI101";
            this.Text = "Tài liệu đính kèm";
            this.Controls.SetChildIndex(this.fld_pnlMainScreen, 0);
            this.fld_pnlMainScreen.ResumeLayout(false);
            this.fld_pnlMainScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcEInvoiceTemplates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleForecastTemplates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFilePath.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSPanel fld_pnlMainScreen;
        private EInvoiceTemplatesGridControl fld_dgcEInvoiceTemplates;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleForecastTemplates;
        private BOSLabel fld_lblLabel17;
        private BOSTextBox fld_txtFilePath;
        private BOSButton fld_btnBrowseFile;
        private BOSButton fld_btnUploadSaleOrderTemplate;
	}
}
