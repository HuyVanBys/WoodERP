using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CompanyConstant.UI
{
	/// <summary>
    /// Summary description for DMCS117
	/// </summary>
    partial class DMCS117
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMCS117));
            this.panel1 = new BOSComponent.BOSPanel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.fld_btnSaveCompletePermissionConfigs = new BOSComponent.BOSButton(this.components);
            this.fld_dgcADObjectViewPermissionsGridControl = new BOSERP.Modules.CompanyConstant.ADObjectViewPermissionsGridControl();
            this.gridView21 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.fld_btnSaveDefaultDescConfigs = new BOSComponent.BOSButton(this.components);
            this.fld_dgcADDefaultDescConfigsGridControl = new BOSERP.Modules.CompanyConstant.ADDefaultDescConfigsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADObjectViewPermissionsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView21)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADDefaultDescConfigsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BOSComment = null;
            this.panel1.BOSDataMember = null;
            this.panel1.BOSDataSource = null;
            this.panel1.BOSDescription = null;
            this.panel1.BOSError = null;
            this.panel1.BOSFieldGroup = null;
            this.panel1.BOSFieldRelation = null;
            this.panel1.BOSPrivilege = null;
            this.panel1.BOSPropertyName = null;
            this.panel1.Controls.Add(this.bosTabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Screen = null;
            this.panel1.Size = new System.Drawing.Size(864, 709);
            this.panel1.TabIndex = 6;
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
            this.bosTabControl1.Size = new System.Drawing.Size(864, 709);
            this.bosTabControl1.TabIndex = 8;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(862, 684);
            this.xtraTabPage1.Text = "Phân quyền dữ liệu";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.fld_btnSaveCompletePermissionConfigs);
            this.groupControl1.Controls.Add(this.fld_dgcADObjectViewPermissionsGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(862, 684);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Cấu hình hiển thị đối tượng";
            // 
            // fld_btnSaveCompletePermissionConfigs
            // 
            this.fld_btnSaveCompletePermissionConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveCompletePermissionConfigs.BOSComment = null;
            this.fld_btnSaveCompletePermissionConfigs.BOSDataMember = null;
            this.fld_btnSaveCompletePermissionConfigs.BOSDataSource = null;
            this.fld_btnSaveCompletePermissionConfigs.BOSDescription = null;
            this.fld_btnSaveCompletePermissionConfigs.BOSError = null;
            this.fld_btnSaveCompletePermissionConfigs.BOSFieldGroup = null;
            this.fld_btnSaveCompletePermissionConfigs.BOSFieldRelation = null;
            this.fld_btnSaveCompletePermissionConfigs.BOSPrivilege = null;
            this.fld_btnSaveCompletePermissionConfigs.BOSPropertyName = null;
            this.fld_btnSaveCompletePermissionConfigs.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveCompletePermissionConfigs.Location = new System.Drawing.Point(826, 25);
            this.fld_btnSaveCompletePermissionConfigs.Name = "fld_btnSaveCompletePermissionConfigs";
            this.fld_btnSaveCompletePermissionConfigs.Screen = null;
            this.fld_btnSaveCompletePermissionConfigs.Size = new System.Drawing.Size(31, 30);
            this.fld_btnSaveCompletePermissionConfigs.TabIndex = 8;
            this.fld_btnSaveCompletePermissionConfigs.Text = "bosButton1";
            this.fld_btnSaveCompletePermissionConfigs.Click += new System.EventHandler(this.fld_btnSaveCompletePermissionConfigs_Click);
            // 
            // fld_dgcADObjectViewPermissionsGridControl
            // 
            this.fld_dgcADObjectViewPermissionsGridControl.AllowDrop = true;
            this.fld_dgcADObjectViewPermissionsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcADObjectViewPermissionsGridControl.BOSComment = "";
            this.fld_dgcADObjectViewPermissionsGridControl.BOSDataMember = null;
            this.fld_dgcADObjectViewPermissionsGridControl.BOSDataSource = "ADObjectViewPermissions";
            this.fld_dgcADObjectViewPermissionsGridControl.BOSDescription = null;
            this.fld_dgcADObjectViewPermissionsGridControl.BOSError = "";
            this.fld_dgcADObjectViewPermissionsGridControl.BOSFieldGroup = "";
            this.fld_dgcADObjectViewPermissionsGridControl.BOSFieldRelation = null;
            this.fld_dgcADObjectViewPermissionsGridControl.BOSGridType = "";
            this.fld_dgcADObjectViewPermissionsGridControl.BOSPrivilege = "";
            this.fld_dgcADObjectViewPermissionsGridControl.BOSPropertyName = null;
            this.fld_dgcADObjectViewPermissionsGridControl.CommodityType = "";
            this.fld_dgcADObjectViewPermissionsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcADObjectViewPermissionsGridControl.Location = new System.Drawing.Point(5, 25);
            this.fld_dgcADObjectViewPermissionsGridControl.MainView = this.gridView21;
            this.fld_dgcADObjectViewPermissionsGridControl.Name = "fld_dgcADObjectViewPermissionsGridControl";
            this.fld_dgcADObjectViewPermissionsGridControl.PrintReport = false;
            this.fld_dgcADObjectViewPermissionsGridControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcADObjectViewPermissionsGridControl, true);
            this.fld_dgcADObjectViewPermissionsGridControl.Size = new System.Drawing.Size(815, 654);
            this.fld_dgcADObjectViewPermissionsGridControl.TabIndex = 9;
            this.fld_dgcADObjectViewPermissionsGridControl.Tag = "DC";
            this.fld_dgcADObjectViewPermissionsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView21});
            // 
            // gridView21
            // 
            this.gridView21.GridControl = this.fld_dgcADObjectViewPermissionsGridControl;
            this.gridView21.Name = "gridView21";
            this.gridView21.PaintStyleName = "Office2003";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(862, 684);
            this.xtraTabPage2.Text = "Hiển thị ghi chú mặc định";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.fld_btnSaveDefaultDescConfigs);
            this.groupControl2.Controls.Add(this.fld_dgcADDefaultDescConfigsGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(862, 684);
            this.groupControl2.TabIndex = 11;
            this.groupControl2.Text = "Cấu hình ghi chú mặc định";
            // 
            // fld_btnSaveDefaultDescConfigs
            // 
            this.fld_btnSaveDefaultDescConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveDefaultDescConfigs.BOSComment = null;
            this.fld_btnSaveDefaultDescConfigs.BOSDataMember = null;
            this.fld_btnSaveDefaultDescConfigs.BOSDataSource = null;
            this.fld_btnSaveDefaultDescConfigs.BOSDescription = null;
            this.fld_btnSaveDefaultDescConfigs.BOSError = null;
            this.fld_btnSaveDefaultDescConfigs.BOSFieldGroup = null;
            this.fld_btnSaveDefaultDescConfigs.BOSFieldRelation = null;
            this.fld_btnSaveDefaultDescConfigs.BOSPrivilege = null;
            this.fld_btnSaveDefaultDescConfigs.BOSPropertyName = null;
            this.fld_btnSaveDefaultDescConfigs.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveDefaultDescConfigs.Location = new System.Drawing.Point(826, 25);
            this.fld_btnSaveDefaultDescConfigs.Name = "fld_btnSaveDefaultDescConfigs";
            this.fld_btnSaveDefaultDescConfigs.Screen = null;
            this.fld_btnSaveDefaultDescConfigs.Size = new System.Drawing.Size(31, 30);
            this.fld_btnSaveDefaultDescConfigs.TabIndex = 8;
            this.fld_btnSaveDefaultDescConfigs.Text = "bosButton1";
            this.fld_btnSaveDefaultDescConfigs.Click += new System.EventHandler(this.fld_btnSaveDefaultDescConfigs_Click);
            // 
            // fld_dgcADDefaultDescConfigsGridControl
            // 
            this.fld_dgcADDefaultDescConfigsGridControl.AllowDrop = true;
            this.fld_dgcADDefaultDescConfigsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcADDefaultDescConfigsGridControl.BOSComment = "";
            this.fld_dgcADDefaultDescConfigsGridControl.BOSDataMember = null;
            this.fld_dgcADDefaultDescConfigsGridControl.BOSDataSource = "ADDefaultDescConfigs";
            this.fld_dgcADDefaultDescConfigsGridControl.BOSDescription = null;
            this.fld_dgcADDefaultDescConfigsGridControl.BOSError = "";
            this.fld_dgcADDefaultDescConfigsGridControl.BOSFieldGroup = "";
            this.fld_dgcADDefaultDescConfigsGridControl.BOSFieldRelation = null;
            this.fld_dgcADDefaultDescConfigsGridControl.BOSGridType = "";
            this.fld_dgcADDefaultDescConfigsGridControl.BOSPrivilege = "";
            this.fld_dgcADDefaultDescConfigsGridControl.BOSPropertyName = null;
            this.fld_dgcADDefaultDescConfigsGridControl.CommodityType = "";
            this.fld_dgcADDefaultDescConfigsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcADDefaultDescConfigsGridControl.Location = new System.Drawing.Point(5, 25);
            this.fld_dgcADDefaultDescConfigsGridControl.MainView = this.gridView1;
            this.fld_dgcADDefaultDescConfigsGridControl.Name = "fld_dgcADDefaultDescConfigsGridControl";
            this.fld_dgcADDefaultDescConfigsGridControl.PrintReport = false;
            this.fld_dgcADDefaultDescConfigsGridControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcADDefaultDescConfigsGridControl, true);
            this.fld_dgcADDefaultDescConfigsGridControl.Size = new System.Drawing.Size(815, 654);
            this.fld_dgcADDefaultDescConfigsGridControl.TabIndex = 9;
            this.fld_dgcADDefaultDescConfigsGridControl.Tag = "DC";
            this.fld_dgcADDefaultDescConfigsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcADDefaultDescConfigsGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // DMCS117
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(864, 709);
            this.Controls.Add(this.panel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMCS117.IconOptions.Icon")));
            this.Name = "DMCS117";
            this.Text = "Phân quyền dữ liệu";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADObjectViewPermissionsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView21)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADDefaultDescConfigsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel panel1;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSButton fld_btnSaveCompletePermissionConfigs;
        private ADObjectViewPermissionsGridControl fld_dgcADObjectViewPermissionsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView21;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private BOSComponent.BOSButton fld_btnSaveDefaultDescConfigs;
        private ADDefaultDescConfigsGridControl fld_dgcADDefaultDescConfigsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
