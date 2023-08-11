using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.EInvoiceConfig.UI
{
	/// <summary>
	/// Summary description for DMCS100
	/// </summary>
	partial class DMEIC100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMEIC100));
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.fld_tabHDDTConfig = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabBankAndCash = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACEInvoiceTypes = new BOSERP.Modules.EInvoiceConfig.ACEInvoiceTypesGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabPaymentMethod = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACEInvoicePaymentMethods = new BOSERP.Modules.EInvoiceConfig.ACEInvoicePaymentMethodsGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabInfomationBKAV = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACEInvoiceConfigBKAVs = new BOSERP.Modules.EInvoiceConfig.BKAV_EInvoiceConfigsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabInfomationMInvoice = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACEInvoiceConfigMInvoices = new BOSERP.Modules.EInvoiceConfig.MInvoice_EInvoiceConfigsGridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabHDDTConfig)).BeginInit();
            this.fld_tabHDDTConfig.SuspendLayout();
            this.fld_tabBankAndCash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEInvoiceTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.fld_tabPaymentMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEInvoicePaymentMethods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.fld_tabInfomationBKAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEInvoiceConfigBKAVs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.fld_tabInfomationMInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEInvoiceConfigMInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.fld_tabHDDTConfig);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(927, 592);
            this.xtraScrollableControl1.TabIndex = 6;
            // 
            // fld_tabHDDTConfig
            // 
            this.fld_tabHDDTConfig.BOSComment = null;
            this.fld_tabHDDTConfig.BOSDataMember = null;
            this.fld_tabHDDTConfig.BOSDataSource = null;
            this.fld_tabHDDTConfig.BOSDescription = null;
            this.fld_tabHDDTConfig.BOSError = null;
            this.fld_tabHDDTConfig.BOSFieldGroup = null;
            this.fld_tabHDDTConfig.BOSFieldRelation = null;
            this.fld_tabHDDTConfig.BOSPrivilege = null;
            this.fld_tabHDDTConfig.BOSPropertyName = null;
            this.fld_tabHDDTConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_tabHDDTConfig.Location = new System.Drawing.Point(0, 0);
            this.fld_tabHDDTConfig.Name = "fld_tabHDDTConfig";
            this.fld_tabHDDTConfig.Screen = null;
            this.fld_tabHDDTConfig.SelectedTabPage = this.fld_tabBankAndCash;
            this.ScreenHelper.SetShowHelp(this.fld_tabHDDTConfig, true);
            this.fld_tabHDDTConfig.Size = new System.Drawing.Size(927, 592);
            this.fld_tabHDDTConfig.TabIndex = 63;
            this.fld_tabHDDTConfig.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabBankAndCash,
            this.fld_tabPaymentMethod,
            this.fld_tabInfomationBKAV,
            this.fld_tabInfomationMInvoice});
            // 
            // fld_tabBankAndCash
            // 
            this.fld_tabBankAndCash.Controls.Add(this.fld_dgcACEInvoiceTypes);
            this.fld_tabBankAndCash.Name = "fld_tabBankAndCash";
            this.fld_tabBankAndCash.Size = new System.Drawing.Size(925, 567);
            this.fld_tabBankAndCash.Text = "Loại hóa đơn";
            // 
            // fld_dgcACEInvoiceTypes
            // 
            this.fld_dgcACEInvoiceTypes.AllowDrop = true;
            this.fld_dgcACEInvoiceTypes.BOSComment = "";
            this.fld_dgcACEInvoiceTypes.BOSDataMember = null;
            this.fld_dgcACEInvoiceTypes.BOSDataSource = "ACEInvoiceTypes";
            this.fld_dgcACEInvoiceTypes.BOSDescription = null;
            this.fld_dgcACEInvoiceTypes.BOSError = "";
            this.fld_dgcACEInvoiceTypes.BOSFieldGroup = "";
            this.fld_dgcACEInvoiceTypes.BOSFieldRelation = null;
            this.fld_dgcACEInvoiceTypes.BOSGridType = null;
            this.fld_dgcACEInvoiceTypes.BOSPrivilege = "";
            this.fld_dgcACEInvoiceTypes.BOSPropertyName = null;
            this.fld_dgcACEInvoiceTypes.CommodityType = "";
            this.fld_dgcACEInvoiceTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACEInvoiceTypes.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACEInvoiceTypes.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACEInvoiceTypes.MainView = this.gridView2;
            this.fld_dgcACEInvoiceTypes.Name = "fld_dgcACEInvoiceTypes";
            this.fld_dgcACEInvoiceTypes.PrintReport = false;
            this.fld_dgcACEInvoiceTypes.Screen = null;
            this.fld_dgcACEInvoiceTypes.Size = new System.Drawing.Size(925, 567);
            this.fld_dgcACEInvoiceTypes.TabIndex = 62;
            this.fld_dgcACEInvoiceTypes.Tag = "DC";
            this.fld_dgcACEInvoiceTypes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcACEInvoiceTypes;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // fld_tabPaymentMethod
            // 
            this.fld_tabPaymentMethod.Controls.Add(this.fld_dgcACEInvoicePaymentMethods);
            this.fld_tabPaymentMethod.Name = "fld_tabPaymentMethod";
            this.fld_tabPaymentMethod.Size = new System.Drawing.Size(911, 560);
            this.fld_tabPaymentMethod.Text = "Phương thức thanh toán";
            // 
            // fld_dgcACEInvoicePaymentMethods
            // 
            this.fld_dgcACEInvoicePaymentMethods.AllowDrop = true;
            this.fld_dgcACEInvoicePaymentMethods.BOSComment = "";
            this.fld_dgcACEInvoicePaymentMethods.BOSDataMember = null;
            this.fld_dgcACEInvoicePaymentMethods.BOSDataSource = "ACEInvoicePaymentMethods";
            this.fld_dgcACEInvoicePaymentMethods.BOSDescription = null;
            this.fld_dgcACEInvoicePaymentMethods.BOSError = "";
            this.fld_dgcACEInvoicePaymentMethods.BOSFieldGroup = "";
            this.fld_dgcACEInvoicePaymentMethods.BOSFieldRelation = null;
            this.fld_dgcACEInvoicePaymentMethods.BOSGridType = null;
            this.fld_dgcACEInvoicePaymentMethods.BOSPrivilege = "";
            this.fld_dgcACEInvoicePaymentMethods.BOSPropertyName = null;
            this.fld_dgcACEInvoicePaymentMethods.CommodityType = "";
            this.fld_dgcACEInvoicePaymentMethods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACEInvoicePaymentMethods.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACEInvoicePaymentMethods.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACEInvoicePaymentMethods.MainView = this.gridView3;
            this.fld_dgcACEInvoicePaymentMethods.Name = "fld_dgcACEInvoicePaymentMethods";
            this.fld_dgcACEInvoicePaymentMethods.PrintReport = false;
            this.fld_dgcACEInvoicePaymentMethods.Screen = null;
            this.fld_dgcACEInvoicePaymentMethods.Size = new System.Drawing.Size(911, 560);
            this.fld_dgcACEInvoicePaymentMethods.TabIndex = 63;
            this.fld_dgcACEInvoicePaymentMethods.Tag = "DC";
            this.fld_dgcACEInvoicePaymentMethods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcACEInvoicePaymentMethods;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // fld_tabInfomationBKAV
            // 
            this.fld_tabInfomationBKAV.Controls.Add(this.fld_dgcACEInvoiceConfigBKAVs);
            this.fld_tabInfomationBKAV.Name = "fld_tabInfomationBKAV";
            this.fld_tabInfomationBKAV.Size = new System.Drawing.Size(925, 567);
            this.fld_tabInfomationBKAV.Text = "Thông tin tài khoản BKAV";
            // 
            // fld_dgcACEInvoiceConfigBKAVs
            // 
            this.fld_dgcACEInvoiceConfigBKAVs.AllowDrop = true;
            this.fld_dgcACEInvoiceConfigBKAVs.BOSComment = "";
            this.fld_dgcACEInvoiceConfigBKAVs.BOSDataMember = null;
            this.fld_dgcACEInvoiceConfigBKAVs.BOSDataSource = "ACEInvoiceConfigs";
            this.fld_dgcACEInvoiceConfigBKAVs.BOSDescription = null;
            this.fld_dgcACEInvoiceConfigBKAVs.BOSError = "";
            this.fld_dgcACEInvoiceConfigBKAVs.BOSFieldGroup = "";
            this.fld_dgcACEInvoiceConfigBKAVs.BOSFieldRelation = null;
            this.fld_dgcACEInvoiceConfigBKAVs.BOSGridType = null;
            this.fld_dgcACEInvoiceConfigBKAVs.BOSPrivilege = "";
            this.fld_dgcACEInvoiceConfigBKAVs.BOSPropertyName = null;
            this.fld_dgcACEInvoiceConfigBKAVs.CommodityType = "";
            this.fld_dgcACEInvoiceConfigBKAVs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACEInvoiceConfigBKAVs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACEInvoiceConfigBKAVs.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACEInvoiceConfigBKAVs.MainView = this.gridView1;
            this.fld_dgcACEInvoiceConfigBKAVs.Name = "fld_dgcACEInvoiceConfigBKAVs";
            this.fld_dgcACEInvoiceConfigBKAVs.PrintReport = false;
            this.fld_dgcACEInvoiceConfigBKAVs.Screen = null;
            this.fld_dgcACEInvoiceConfigBKAVs.Size = new System.Drawing.Size(925, 567);
            this.fld_dgcACEInvoiceConfigBKAVs.TabIndex = 62;
            this.fld_dgcACEInvoiceConfigBKAVs.Tag = "DC";
            this.fld_dgcACEInvoiceConfigBKAVs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcACEInvoiceConfigBKAVs;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_tabInfomationMInvoice
            // 
            this.fld_tabInfomationMInvoice.Controls.Add(this.fld_dgcACEInvoiceConfigMInvoices);
            this.fld_tabInfomationMInvoice.Name = "fld_tabInfomationMInvoice";
            this.fld_tabInfomationMInvoice.Size = new System.Drawing.Size(925, 567);
            this.fld_tabInfomationMInvoice.Text = "Thông tin tài khoản M-Invoice";
            // 
            // fld_dgcACEInvoiceConfigMInvoices
            // 
            this.fld_dgcACEInvoiceConfigMInvoices.AllowDrop = true;
            this.fld_dgcACEInvoiceConfigMInvoices.BOSComment = "";
            this.fld_dgcACEInvoiceConfigMInvoices.BOSDataMember = null;
            this.fld_dgcACEInvoiceConfigMInvoices.BOSDataSource = "ACEInvoiceConfigs";
            this.fld_dgcACEInvoiceConfigMInvoices.BOSDescription = null;
            this.fld_dgcACEInvoiceConfigMInvoices.BOSError = "";
            this.fld_dgcACEInvoiceConfigMInvoices.BOSFieldGroup = "";
            this.fld_dgcACEInvoiceConfigMInvoices.BOSFieldRelation = null;
            this.fld_dgcACEInvoiceConfigMInvoices.BOSGridType = null;
            this.fld_dgcACEInvoiceConfigMInvoices.BOSPrivilege = "";
            this.fld_dgcACEInvoiceConfigMInvoices.BOSPropertyName = null;
            this.fld_dgcACEInvoiceConfigMInvoices.CommodityType = "";
            this.fld_dgcACEInvoiceConfigMInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACEInvoiceConfigMInvoices.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACEInvoiceConfigMInvoices.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACEInvoiceConfigMInvoices.MainView = this.gridView4;
            this.fld_dgcACEInvoiceConfigMInvoices.Name = "fld_dgcACEInvoiceConfigMInvoices";
            this.fld_dgcACEInvoiceConfigMInvoices.PrintReport = false;
            this.fld_dgcACEInvoiceConfigMInvoices.Screen = null;
            this.fld_dgcACEInvoiceConfigMInvoices.Size = new System.Drawing.Size(925, 567);
            this.fld_dgcACEInvoiceConfigMInvoices.TabIndex = 63;
            this.fld_dgcACEInvoiceConfigMInvoices.Tag = "DC";
            this.fld_dgcACEInvoiceConfigMInvoices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.fld_dgcACEInvoiceConfigMInvoices;
            this.gridView4.Name = "gridView4";
            this.gridView4.PaintStyleName = "Office2003";
            // 
            // DMEIC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(927, 592);
            this.Controls.Add(this.xtraScrollableControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMEIC100.IconOptions.Icon")));
            this.Name = "DMEIC100";
            this.Text = "Cấu hình Hóa đơn điện tử";
            this.Controls.SetChildIndex(this.xtraScrollableControl1, 0);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabHDDTConfig)).EndInit();
            this.fld_tabHDDTConfig.ResumeLayout(false);
            this.fld_tabBankAndCash.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEInvoiceTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.fld_tabPaymentMethod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEInvoicePaymentMethods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.fld_tabInfomationBKAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEInvoiceConfigBKAVs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.fld_tabInfomationMInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEInvoiceConfigMInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private BOSComponent.BOSTabControl fld_tabHDDTConfig;
        private DevExpress.XtraTab.XtraTabPage fld_tabInfomationBKAV;
        private BKAV_EInvoiceConfigsGridControl fld_dgcACEInvoiceConfigBKAVs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage fld_tabBankAndCash;
        private ACEInvoiceTypesGridControl fld_dgcACEInvoiceTypes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraTab.XtraTabPage fld_tabPaymentMethod;
        private ACEInvoicePaymentMethodsGridControl fld_dgcACEInvoicePaymentMethods;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraTab.XtraTabPage fld_tabInfomationMInvoice;
        private MInvoice_EInvoiceConfigsGridControl fld_dgcACEInvoiceConfigMInvoices;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
    }
}
