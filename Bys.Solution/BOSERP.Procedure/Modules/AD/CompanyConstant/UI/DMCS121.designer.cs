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
    partial class DMCS121
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
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcGETerminals = new BOSERP.Modules.CompanyConstant.GETerminalsGridControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcGEUnitCosts = new BOSERP.Modules.CompanyConstant.GEUnitCostsGridControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcGEUnitCostContainers = new BOSERP.Modules.CompanyConstant.GEUnitCostContainersGridControl();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGETerminals)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGEUnitCosts)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGEUnitCostContainers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            this.SuspendLayout();
            // 
            // bosPanel1
            // 
            this.bosPanel1.AutoScroll = true;
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.xtraScrollableControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(984, 644);
            this.bosPanel1.TabIndex = 7;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.bosTabControl1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(984, 644);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosTabControl1.Location = new System.Drawing.Point(0, 0);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(984, 644);
            this.bosTabControl1.TabIndex = 0;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcGETerminals);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(978, 616);
            this.xtraTabPage1.Text = "Cấu hình cảng";
            // 
            // fld_dgcGETerminals
            // 
            this.fld_dgcGETerminals.BOSComment = null;
            this.fld_dgcGETerminals.BOSDataMember = null;
            this.fld_dgcGETerminals.BOSDataSource = "GETerminals";
            this.fld_dgcGETerminals.BOSDescription = null;
            this.fld_dgcGETerminals.BOSError = null;
            this.fld_dgcGETerminals.BOSFieldGroup = null;
            this.fld_dgcGETerminals.BOSFieldRelation = null;
            this.fld_dgcGETerminals.BOSGridType = null;
            this.fld_dgcGETerminals.BOSPrivilege = null;
            this.fld_dgcGETerminals.BOSPropertyName = null;
            this.fld_dgcGETerminals.CommodityType = "";
            this.fld_dgcGETerminals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcGETerminals.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcGETerminals.MenuManager = this.screenToolbar;
            this.fld_dgcGETerminals.Name = "fld_dgcGETerminals";
            this.fld_dgcGETerminals.PrintReport = false;
            this.fld_dgcGETerminals.Screen = null;
            this.fld_dgcGETerminals.Size = new System.Drawing.Size(978, 616);
            this.fld_dgcGETerminals.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcGEUnitCosts);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(978, 616);
            this.xtraTabPage2.Text = "Cấu hình phí";
            // 
            // fld_dgcGEUnitCosts
            // 
            this.fld_dgcGEUnitCosts.BOSComment = null;
            this.fld_dgcGEUnitCosts.BOSDataMember = null;
            this.fld_dgcGEUnitCosts.BOSDataSource = "GEUnitCosts";
            this.fld_dgcGEUnitCosts.BOSDescription = null;
            this.fld_dgcGEUnitCosts.BOSError = null;
            this.fld_dgcGEUnitCosts.BOSFieldGroup = null;
            this.fld_dgcGEUnitCosts.BOSFieldRelation = null;
            this.fld_dgcGEUnitCosts.BOSGridType = null;
            this.fld_dgcGEUnitCosts.BOSPrivilege = null;
            this.fld_dgcGEUnitCosts.BOSPropertyName = null;
            this.fld_dgcGEUnitCosts.CommodityType = "";
            this.fld_dgcGEUnitCosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcGEUnitCosts.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcGEUnitCosts.MenuManager = this.screenToolbar;
            this.fld_dgcGEUnitCosts.Name = "fld_dgcGEUnitCosts";
            this.fld_dgcGEUnitCosts.PrintReport = false;
            this.fld_dgcGEUnitCosts.Screen = null;
            this.fld_dgcGEUnitCosts.Size = new System.Drawing.Size(978, 616);
            this.fld_dgcGEUnitCosts.TabIndex = 1;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcGEUnitCostContainers);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(978, 616);
            this.xtraTabPage3.Text = "Cấu hình đơn giá cont";
            // 
            // fld_dgcGEUnitCostContainers
            // 
            this.fld_dgcGEUnitCostContainers.BOSComment = null;
            this.fld_dgcGEUnitCostContainers.BOSDataMember = null;
            this.fld_dgcGEUnitCostContainers.BOSDataSource = "GEUnitCostContainers";
            this.fld_dgcGEUnitCostContainers.BOSDescription = null;
            this.fld_dgcGEUnitCostContainers.BOSError = null;
            this.fld_dgcGEUnitCostContainers.BOSFieldGroup = null;
            this.fld_dgcGEUnitCostContainers.BOSFieldRelation = null;
            this.fld_dgcGEUnitCostContainers.BOSGridType = null;
            this.fld_dgcGEUnitCostContainers.BOSPrivilege = null;
            this.fld_dgcGEUnitCostContainers.BOSPropertyName = null;
            this.fld_dgcGEUnitCostContainers.CommodityType = "";
            this.fld_dgcGEUnitCostContainers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcGEUnitCostContainers.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcGEUnitCostContainers.MenuManager = this.screenToolbar;
            this.fld_dgcGEUnitCostContainers.Name = "fld_dgcGEUnitCostContainers";
            this.fld_dgcGEUnitCostContainers.PrintReport = false;
            this.fld_dgcGEUnitCostContainers.Screen = null;
            this.fld_dgcGEUnitCostContainers.Size = new System.Drawing.Size(978, 616);
            this.fld_dgcGEUnitCostContainers.TabIndex = 1;
            // 
            // gridView6
            // 
            this.gridView6.Name = "gridView6";
            this.gridView6.PaintStyleName = "Office2003";
            // 
            // gridView7
            // 
            this.gridView7.Name = "gridView7";
            this.gridView7.PaintStyleName = "Office2003";
            // 
            // gridView8
            // 
            this.gridView8.Name = "gridView8";
            this.gridView8.PaintStyleName = "Office2003";
            // 
            // DMCS121
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(984, 644);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMCS121";
            this.Text = "Cấu loại Khai báo phí";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGETerminals)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGEUnitCosts)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGEUnitCostContainers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private GETerminalsGridControl fld_dgcGETerminals;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private GEUnitCostsGridControl fld_dgcGEUnitCosts;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private GEUnitCostContainersGridControl fld_dgcGEUnitCostContainers;
	}
}
