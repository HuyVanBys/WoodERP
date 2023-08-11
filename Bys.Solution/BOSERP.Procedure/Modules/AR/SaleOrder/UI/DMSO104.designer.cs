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
    /// Summary description for DMSO104
	/// </summary>
    partial class DMSO104
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
            this.panel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnViewProfile = new BOSComponent.BOSButton(this.components);
            this.fld_tabSaleReturnItems = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcSaleOrderProfilesGridControl = new BOSERP.Modules.SaleOrder.ARSaleOrderProfilesGridControl();
            this.fld_dgvARSaleForecastTemplates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabPageSaleReturnItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcSOItemProfilesGridControl = new BOSERP.Modules.SaleOrder.ARSOItemProfilesGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabSaleReturnItems)).BeginInit();
            this.fld_tabSaleReturnItems.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSaleOrderProfilesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleForecastTemplates)).BeginInit();
            this.fld_tabPageSaleReturnItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSOItemProfilesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BOSComment = null;
            this.panel1.BOSDataMember = null;
            this.panel1.BOSDataSource = null;
            this.panel1.BOSDescription = null;
            this.panel1.BOSError = null;
            this.panel1.BOSFieldGroup = null;
            this.panel1.BOSFieldRelation = null;
            this.panel1.BOSPrivilege = null;
            this.panel1.BOSPropertyName = null;
            this.panel1.Controls.Add(this.fld_btnViewProfile);
            this.panel1.Controls.Add(this.fld_tabSaleReturnItems);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Screen = null;
            this.panel1.Size = new System.Drawing.Size(874, 581);
            this.panel1.TabIndex = 6;
            // 
            // fld_btnViewProfile
            // 
            this.fld_btnViewProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnViewProfile.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnViewProfile.Appearance.Options.UseForeColor = true;
            this.fld_btnViewProfile.BOSComment = null;
            this.fld_btnViewProfile.BOSDataMember = null;
            this.fld_btnViewProfile.BOSDataSource = null;
            this.fld_btnViewProfile.BOSDescription = null;
            this.fld_btnViewProfile.BOSError = null;
            this.fld_btnViewProfile.BOSFieldGroup = null;
            this.fld_btnViewProfile.BOSFieldRelation = null;
            this.fld_btnViewProfile.BOSPrivilege = null;
            this.fld_btnViewProfile.BOSPropertyName = null;
            this.fld_btnViewProfile.Location = new System.Drawing.Point(788, 5);
            this.fld_btnViewProfile.Name = "fld_btnViewProfile";
            this.fld_btnViewProfile.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnViewProfile, true);
            this.fld_btnViewProfile.Size = new System.Drawing.Size(75, 29);
            this.fld_btnViewProfile.TabIndex = 20;
            this.fld_btnViewProfile.Text = "Xem";
            this.fld_btnViewProfile.Click += new System.EventHandler(this.fld_btnViewProfile_Click);
            // 
            // fld_tabSaleReturnItems
            // 
            this.fld_tabSaleReturnItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabSaleReturnItems.BOSComment = null;
            this.fld_tabSaleReturnItems.BOSDataMember = null;
            this.fld_tabSaleReturnItems.BOSDataSource = null;
            this.fld_tabSaleReturnItems.BOSDescription = null;
            this.fld_tabSaleReturnItems.BOSError = null;
            this.fld_tabSaleReturnItems.BOSFieldGroup = null;
            this.fld_tabSaleReturnItems.BOSFieldRelation = null;
            this.fld_tabSaleReturnItems.BOSPrivilege = null;
            this.fld_tabSaleReturnItems.BOSPropertyName = null;
            this.fld_tabSaleReturnItems.Location = new System.Drawing.Point(0, 40);
            this.fld_tabSaleReturnItems.Name = "fld_tabSaleReturnItems";
            this.fld_tabSaleReturnItems.Screen = null;
            this.fld_tabSaleReturnItems.SelectedTabPage = this.xtraTabPage1;
            this.fld_tabSaleReturnItems.Size = new System.Drawing.Size(868, 534);
            this.fld_tabSaleReturnItems.TabIndex = 19;
            this.fld_tabSaleReturnItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.fld_tabPageSaleReturnItems});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcSaleOrderProfilesGridControl);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(862, 506);
            this.xtraTabPage1.Text = "Thông tin chung";
            // 
            // fld_dgcSaleOrderProfilesGridControl
            // 
            this.fld_dgcSaleOrderProfilesGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcSaleOrderProfilesGridControl.BOSComment = "";
            this.fld_dgcSaleOrderProfilesGridControl.BOSDataMember = "";
            this.fld_dgcSaleOrderProfilesGridControl.BOSDataSource = "ARHistoryDetails";
            this.fld_dgcSaleOrderProfilesGridControl.BOSDescription = null;
            this.fld_dgcSaleOrderProfilesGridControl.BOSError = null;
            this.fld_dgcSaleOrderProfilesGridControl.BOSFieldGroup = "";
            this.fld_dgcSaleOrderProfilesGridControl.BOSFieldRelation = "";
            this.fld_dgcSaleOrderProfilesGridControl.BOSGridType = null;
            this.fld_dgcSaleOrderProfilesGridControl.BOSPrivilege = "";
            this.fld_dgcSaleOrderProfilesGridControl.BOSPropertyName = "";
            this.fld_dgcSaleOrderProfilesGridControl.CommodityType = "";
            this.fld_dgcSaleOrderProfilesGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcSaleOrderProfilesGridControl.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcSaleOrderProfilesGridControl.MainView = this.fld_dgvARSaleForecastTemplates;
            this.fld_dgcSaleOrderProfilesGridControl.Name = "fld_dgcSaleOrderProfilesGridControl";
            this.fld_dgcSaleOrderProfilesGridControl.PrintReport = false;
            this.fld_dgcSaleOrderProfilesGridControl.Screen = null;
            this.fld_dgcSaleOrderProfilesGridControl.Size = new System.Drawing.Size(856, 500);
            this.fld_dgcSaleOrderProfilesGridControl.TabIndex = 27;
            this.fld_dgcSaleOrderProfilesGridControl.Tag = "DC";
            this.fld_dgcSaleOrderProfilesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleForecastTemplates});
            // 
            // fld_dgvARSaleForecastTemplates
            // 
            this.fld_dgvARSaleForecastTemplates.GridControl = this.fld_dgcSaleOrderProfilesGridControl;
            this.fld_dgvARSaleForecastTemplates.Name = "fld_dgvARSaleForecastTemplates";
            // 
            // fld_tabPageSaleReturnItems
            // 
            this.fld_tabPageSaleReturnItems.Controls.Add(this.fld_dgcSOItemProfilesGridControl);
            this.fld_tabPageSaleReturnItems.Name = "fld_tabPageSaleReturnItems";
            this.fld_tabPageSaleReturnItems.Size = new System.Drawing.Size(856, 499);
            this.fld_tabPageSaleReturnItems.Text = "Danh sách sản phẩm";
            // 
            // fld_dgcSOItemProfilesGridControl
            // 
            this.fld_dgcSOItemProfilesGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcSOItemProfilesGridControl.BOSComment = "";
            this.fld_dgcSOItemProfilesGridControl.BOSDataMember = "";
            this.fld_dgcSOItemProfilesGridControl.BOSDataSource = "ARHistoryDetails";
            this.fld_dgcSOItemProfilesGridControl.BOSDescription = null;
            this.fld_dgcSOItemProfilesGridControl.BOSError = null;
            this.fld_dgcSOItemProfilesGridControl.BOSFieldGroup = "";
            this.fld_dgcSOItemProfilesGridControl.BOSFieldRelation = "";
            this.fld_dgcSOItemProfilesGridControl.BOSGridType = null;
            this.fld_dgcSOItemProfilesGridControl.BOSPrivilege = "";
            this.fld_dgcSOItemProfilesGridControl.BOSPropertyName = "";
            this.fld_dgcSOItemProfilesGridControl.CommodityType = "";
            this.fld_dgcSOItemProfilesGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcSOItemProfilesGridControl.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcSOItemProfilesGridControl.MainView = this.gridView1;
            this.fld_dgcSOItemProfilesGridControl.Name = "fld_dgcSOItemProfilesGridControl";
            this.fld_dgcSOItemProfilesGridControl.PrintReport = false;
            this.fld_dgcSOItemProfilesGridControl.Screen = null;
            this.fld_dgcSOItemProfilesGridControl.Size = new System.Drawing.Size(850, 493);
            this.fld_dgcSOItemProfilesGridControl.TabIndex = 28;
            this.fld_dgcSOItemProfilesGridControl.Tag = "DC";
            this.fld_dgcSOItemProfilesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcSOItemProfilesGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // DMSO104
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(874, 581);
            this.Controls.Add(this.panel1);
            this.Name = "DMSO104";
            this.Text = "Lịch sử thay đổi trạng thái";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabSaleReturnItems)).EndInit();
            this.fld_tabSaleReturnItems.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSaleOrderProfilesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleForecastTemplates)).EndInit();
            this.fld_tabPageSaleReturnItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSOItemProfilesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSPanel panel1;
        private BOSTabControl fld_tabSaleReturnItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageSaleReturnItems;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private ARSaleOrderProfilesGridControl fld_dgcSaleOrderProfilesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleForecastTemplates;
        private ARSOItemProfilesGridControl fld_dgcSOItemProfilesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSButton fld_btnViewProfile;
    }
}
