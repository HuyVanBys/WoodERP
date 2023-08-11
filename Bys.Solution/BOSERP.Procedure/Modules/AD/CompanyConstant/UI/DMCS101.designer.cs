using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CompanyConstant.UI
{
	/// <summary>
	/// Summary description for DMCS101
	/// </summary>
	partial class DMCS101
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMCS101));
            this.fld_grpGroupControl5 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcCustomerSaleOrderTypeConfigs = new BOSERP.Modules.CompanyConstant.ARCustomerSaleOrderTypeConfigsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgcCustomerType = new BOSERP.Modules.CompanyConstant.CustomerTypeGridControl();
            this.fld_dgvCustomerType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcCustomerResourcesGridControl = new BOSERP.Modules.CompanyConstant.ARCustomerResourcesGridControl();
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcCustomerDistributionChannelType = new BOSERP.Modules.CompanyConstant.CustomerDistributionChannelTypeGridControl();
            this.fld_dgvCustomerDistributionChannelType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcARCustomerBusinessTypesGridControl = new BOSERP.Modules.CompanyConstant.ARCustomerBusinessTypesGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_grpGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCustomerSaleOrderTypeConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCustomerType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvCustomerType)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCustomerResourcesGridControl)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCustomerDistributionChannelType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvCustomerDistributionChannelType)).BeginInit();
            this.bosLine3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCustomerBusinessTypesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_grpGroupControl5
            // 
            this.fld_grpGroupControl5.BOSComment = null;
            this.fld_grpGroupControl5.BOSDataMember = null;
            this.fld_grpGroupControl5.BOSDataSource = null;
            this.fld_grpGroupControl5.BOSDescription = null;
            this.fld_grpGroupControl5.BOSError = null;
            this.fld_grpGroupControl5.BOSFieldGroup = null;
            this.fld_grpGroupControl5.BOSFieldRelation = null;
            this.fld_grpGroupControl5.BOSPrivilege = null;
            this.fld_grpGroupControl5.BOSPropertyName = null;
            this.fld_grpGroupControl5.Controls.Add(this.fld_dgcCustomerSaleOrderTypeConfigs);
            this.fld_grpGroupControl5.Controls.Add(this.fld_dgcCustomerType);
            this.fld_grpGroupControl5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_grpGroupControl5.Location = new System.Drawing.Point(12, 4);
            this.fld_grpGroupControl5.Name = "fld_grpGroupControl5";
            this.fld_grpGroupControl5.Screen = null;
            this.fld_grpGroupControl5.Size = new System.Drawing.Size(400, 258);
            this.fld_grpGroupControl5.TabIndex = 6;
            this.fld_grpGroupControl5.TabStop = false;
            this.fld_grpGroupControl5.Text = "Loại khách hàng";
            // 
            // fld_dgcCustomerSaleOrderTypeConfigs
            // 
            this.fld_dgcCustomerSaleOrderTypeConfigs.AllowDrop = true;
            this.fld_dgcCustomerSaleOrderTypeConfigs.BOSComment = "";
            this.fld_dgcCustomerSaleOrderTypeConfigs.BOSDataMember = null;
            this.fld_dgcCustomerSaleOrderTypeConfigs.BOSDataSource = "";
            this.fld_dgcCustomerSaleOrderTypeConfigs.BOSDescription = null;
            this.fld_dgcCustomerSaleOrderTypeConfigs.BOSError = "";
            this.fld_dgcCustomerSaleOrderTypeConfigs.BOSFieldGroup = "";
            this.fld_dgcCustomerSaleOrderTypeConfigs.BOSFieldRelation = null;
            this.fld_dgcCustomerSaleOrderTypeConfigs.BOSGridType = null;
            this.fld_dgcCustomerSaleOrderTypeConfigs.BOSPrivilege = "";
            this.fld_dgcCustomerSaleOrderTypeConfigs.BOSPropertyName = null;
            this.fld_dgcCustomerSaleOrderTypeConfigs.CommodityType = "";
            this.fld_dgcCustomerSaleOrderTypeConfigs.Dock = System.Windows.Forms.DockStyle.Right;
            this.fld_dgcCustomerSaleOrderTypeConfigs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcCustomerSaleOrderTypeConfigs.Location = new System.Drawing.Point(145, 17);
            this.fld_dgcCustomerSaleOrderTypeConfigs.MainView = this.gridView2;
            this.fld_dgcCustomerSaleOrderTypeConfigs.Name = "fld_dgcCustomerSaleOrderTypeConfigs";
            this.fld_dgcCustomerSaleOrderTypeConfigs.PrintReport = false;
            this.fld_dgcCustomerSaleOrderTypeConfigs.Screen = null;
            this.fld_dgcCustomerSaleOrderTypeConfigs.Size = new System.Drawing.Size(252, 238);
            this.fld_dgcCustomerSaleOrderTypeConfigs.TabIndex = 5;
            this.fld_dgcCustomerSaleOrderTypeConfigs.Tag = "DC";
            this.fld_dgcCustomerSaleOrderTypeConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcCustomerSaleOrderTypeConfigs;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // fld_dgcCustomerType
            // 
            this.fld_dgcCustomerType.AllowDrop = true;
            this.fld_dgcCustomerType.BOSComment = "";
            this.fld_dgcCustomerType.BOSDataMember = null;
            this.fld_dgcCustomerType.BOSDataSource = "";
            this.fld_dgcCustomerType.BOSDescription = null;
            this.fld_dgcCustomerType.BOSError = "";
            this.fld_dgcCustomerType.BOSFieldGroup = "";
            this.fld_dgcCustomerType.BOSFieldRelation = null;
            this.fld_dgcCustomerType.BOSGridType = null;
            this.fld_dgcCustomerType.BOSPrivilege = "";
            this.fld_dgcCustomerType.BOSPropertyName = null;
            this.fld_dgcCustomerType.CommodityType = "";
            this.fld_dgcCustomerType.Dock = System.Windows.Forms.DockStyle.Left;
            this.fld_dgcCustomerType.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcCustomerType.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcCustomerType.MainView = this.fld_dgvCustomerType;
            this.fld_dgcCustomerType.Name = "fld_dgcCustomerType";
            this.fld_dgcCustomerType.PrintReport = false;
            this.fld_dgcCustomerType.Screen = null;
            this.fld_dgcCustomerType.Size = new System.Drawing.Size(136, 238);
            this.fld_dgcCustomerType.TabIndex = 4;
            this.fld_dgcCustomerType.Tag = "DC";
            this.fld_dgcCustomerType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvCustomerType});
            // 
            // fld_dgvCustomerType
            // 
            this.fld_dgvCustomerType.GridControl = this.fld_dgcCustomerType;
            this.fld_dgvCustomerType.Name = "fld_dgvCustomerType";
            this.fld_dgvCustomerType.PaintStyleName = "Office2003";
            // 
            // bosLine1
            // 
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_dgcCustomerResourcesGridControl);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(12, 268);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(806, 250);
            this.bosLine1.TabIndex = 7;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Cấu hình nguồn khách hàng";
            // 
            // fld_dgcCustomerResourcesGridControl
            // 
            this.fld_dgcCustomerResourcesGridControl.BOSComment = null;
            this.fld_dgcCustomerResourcesGridControl.BOSDataMember = null;
            this.fld_dgcCustomerResourcesGridControl.BOSDataSource = "ARCustomerResources";
            this.fld_dgcCustomerResourcesGridControl.BOSDescription = null;
            this.fld_dgcCustomerResourcesGridControl.BOSError = null;
            this.fld_dgcCustomerResourcesGridControl.BOSFieldGroup = null;
            this.fld_dgcCustomerResourcesGridControl.BOSFieldRelation = null;
            this.fld_dgcCustomerResourcesGridControl.BOSGridType = null;
            this.fld_dgcCustomerResourcesGridControl.BOSPrivilege = null;
            this.fld_dgcCustomerResourcesGridControl.BOSPropertyName = null;
            this.fld_dgcCustomerResourcesGridControl.CommodityType = "";
            this.fld_dgcCustomerResourcesGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcCustomerResourcesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcCustomerResourcesGridControl.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcCustomerResourcesGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcCustomerResourcesGridControl.Name = "fld_dgcCustomerResourcesGridControl";
            this.fld_dgcCustomerResourcesGridControl.PrintReport = false;
            this.fld_dgcCustomerResourcesGridControl.Screen = null;
            this.fld_dgcCustomerResourcesGridControl.Size = new System.Drawing.Size(800, 230);
            this.fld_dgcCustomerResourcesGridControl.TabIndex = 0;
            // 
            // bosLine2
            // 
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.fld_dgcCustomerDistributionChannelType);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(418, 4);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(400, 258);
            this.bosLine2.TabIndex = 8;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Cấu hình kênh phân phối";
            // 
            // fld_dgcCustomerDistributionChannelType
            // 
            this.fld_dgcCustomerDistributionChannelType.AllowDrop = true;
            this.fld_dgcCustomerDistributionChannelType.BOSComment = "";
            this.fld_dgcCustomerDistributionChannelType.BOSDataMember = null;
            this.fld_dgcCustomerDistributionChannelType.BOSDataSource = "";
            this.fld_dgcCustomerDistributionChannelType.BOSDescription = null;
            this.fld_dgcCustomerDistributionChannelType.BOSError = "";
            this.fld_dgcCustomerDistributionChannelType.BOSFieldGroup = "";
            this.fld_dgcCustomerDistributionChannelType.BOSFieldRelation = null;
            this.fld_dgcCustomerDistributionChannelType.BOSGridType = null;
            this.fld_dgcCustomerDistributionChannelType.BOSPrivilege = "";
            this.fld_dgcCustomerDistributionChannelType.BOSPropertyName = null;
            this.fld_dgcCustomerDistributionChannelType.CommodityType = "";
            this.fld_dgcCustomerDistributionChannelType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcCustomerDistributionChannelType.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcCustomerDistributionChannelType.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcCustomerDistributionChannelType.MainView = this.fld_dgvCustomerDistributionChannelType;
            this.fld_dgcCustomerDistributionChannelType.Name = "fld_dgcCustomerDistributionChannelType";
            this.fld_dgcCustomerDistributionChannelType.PrintReport = false;
            this.fld_dgcCustomerDistributionChannelType.Screen = null;
            this.fld_dgcCustomerDistributionChannelType.Size = new System.Drawing.Size(394, 238);
            this.fld_dgcCustomerDistributionChannelType.TabIndex = 5;
            this.fld_dgcCustomerDistributionChannelType.Tag = "DC";
            this.fld_dgcCustomerDistributionChannelType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvCustomerDistributionChannelType});
            // 
            // fld_dgvCustomerDistributionChannelType
            // 
            this.fld_dgvCustomerDistributionChannelType.GridControl = this.fld_dgcCustomerDistributionChannelType;
            this.fld_dgvCustomerDistributionChannelType.Name = "fld_dgvCustomerDistributionChannelType";
            this.fld_dgvCustomerDistributionChannelType.PaintStyleName = "Office2003";
            // 
            // bosLine3
            // 
            this.bosLine3.BOSComment = null;
            this.bosLine3.BOSDataMember = null;
            this.bosLine3.BOSDataSource = null;
            this.bosLine3.BOSDescription = null;
            this.bosLine3.BOSError = null;
            this.bosLine3.BOSFieldGroup = null;
            this.bosLine3.BOSFieldRelation = null;
            this.bosLine3.BOSPrivilege = null;
            this.bosLine3.BOSPropertyName = null;
            this.bosLine3.Controls.Add(this.fld_dgcARCustomerBusinessTypesGridControl);
            this.bosLine3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine3.Location = new System.Drawing.Point(12, 524);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(806, 273);
            this.bosLine3.TabIndex = 9;
            this.bosLine3.TabStop = false;
            this.bosLine3.Text = "Loại hình doanh nghiệp";
            // 
            // fld_dgcARCustomerBusinessTypesGridControl
            // 
            this.fld_dgcARCustomerBusinessTypesGridControl.AllowDrop = true;
            this.fld_dgcARCustomerBusinessTypesGridControl.BOSComment = "";
            this.fld_dgcARCustomerBusinessTypesGridControl.BOSDataMember = null;
            this.fld_dgcARCustomerBusinessTypesGridControl.BOSDataSource = "ARCustomerBusinessTypes";
            this.fld_dgcARCustomerBusinessTypesGridControl.BOSDescription = null;
            this.fld_dgcARCustomerBusinessTypesGridControl.BOSError = "";
            this.fld_dgcARCustomerBusinessTypesGridControl.BOSFieldGroup = "";
            this.fld_dgcARCustomerBusinessTypesGridControl.BOSFieldRelation = null;
            this.fld_dgcARCustomerBusinessTypesGridControl.BOSGridType = null;
            this.fld_dgcARCustomerBusinessTypesGridControl.BOSPrivilege = "";
            this.fld_dgcARCustomerBusinessTypesGridControl.BOSPropertyName = null;
            this.fld_dgcARCustomerBusinessTypesGridControl.CommodityType = "";
            this.fld_dgcARCustomerBusinessTypesGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcARCustomerBusinessTypesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARCustomerBusinessTypesGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARCustomerBusinessTypesGridControl.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcARCustomerBusinessTypesGridControl.MainView = this.gridView1;
            this.fld_dgcARCustomerBusinessTypesGridControl.Name = "fld_dgcARCustomerBusinessTypesGridControl";
            this.fld_dgcARCustomerBusinessTypesGridControl.PrintReport = false;
            this.fld_dgcARCustomerBusinessTypesGridControl.Screen = null;
            this.fld_dgcARCustomerBusinessTypesGridControl.Size = new System.Drawing.Size(800, 253);
            this.fld_dgcARCustomerBusinessTypesGridControl.TabIndex = 4;
            this.fld_dgcARCustomerBusinessTypesGridControl.Tag = "DC";
            this.fld_dgcARCustomerBusinessTypesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcARCustomerBusinessTypesGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // DMCS101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(888, 837);
            this.Controls.Add(this.bosLine3);
            this.Controls.Add(this.bosLine2);
            this.Controls.Add(this.bosLine1);
            this.Controls.Add(this.fld_grpGroupControl5);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMCS101.IconOptions.Icon")));
            this.Name = "DMCS101";
            this.Text = "Cấu hình khách hàng";
            this.Controls.SetChildIndex(this.fld_grpGroupControl5, 0);
            this.Controls.SetChildIndex(this.bosLine1, 0);
            this.Controls.SetChildIndex(this.bosLine2, 0);
            this.Controls.SetChildIndex(this.bosLine3, 0);
            this.fld_grpGroupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCustomerSaleOrderTypeConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCustomerType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvCustomerType)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCustomerResourcesGridControl)).EndInit();
            this.bosLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCustomerDistributionChannelType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvCustomerDistributionChannelType)).EndInit();
            this.bosLine3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCustomerBusinessTypesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLine fld_grpGroupControl5;
        private BOSComponent.BOSLine bosLine1;
        private ARCustomerResourcesGridControl fld_dgcCustomerResourcesGridControl;
        private CustomerTypeGridControl fld_dgcCustomerType;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvCustomerType;
        private BOSComponent.BOSLine bosLine2;
        private CustomerDistributionChannelTypeGridControl fld_dgcCustomerDistributionChannelType;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvCustomerDistributionChannelType;
        private BOSComponent.BOSLine bosLine3;
        private ARCustomerBusinessTypesGridControl fld_dgcARCustomerBusinessTypesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ARCustomerSaleOrderTypeConfigsGridControl fld_dgcCustomerSaleOrderTypeConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}
