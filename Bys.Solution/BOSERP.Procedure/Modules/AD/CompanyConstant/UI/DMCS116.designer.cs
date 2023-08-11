using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CompanyConstant.UI
{
	/// <summary>
    /// Summary description for DMCS116
	/// </summary>
    partial class DMCS116
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
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.fld_btnSaveCompletePermissionConfigs = new BOSComponent.BOSButton(this.components);
            this.fld_dgcCompletePermissionConfigsGridControl = new BOSERP.Modules.CompanyConstant.ADCompletePermissionConfigsGridControl();
            this.gridView21 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCompletePermissionConfigsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView21)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(822, 688);
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
            this.bosTabControl1.Size = new System.Drawing.Size(822, 688);
            this.bosTabControl1.TabIndex = 8;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(815, 659);
            this.xtraTabPage1.Text = "Phân quyền dữ liệu";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.fld_btnSaveCompletePermissionConfigs);
            this.groupControl1.Controls.Add(this.fld_dgcCompletePermissionConfigsGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(815, 659);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Cấu hình duyệt chứng từ";
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
            this.fld_btnSaveCompletePermissionConfigs.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveCompletePermissionConfigs.Location = new System.Drawing.Point(779, 25);
            this.fld_btnSaveCompletePermissionConfigs.Name = "fld_btnSaveCompletePermissionConfigs";
            this.fld_btnSaveCompletePermissionConfigs.Screen = null;
            this.fld_btnSaveCompletePermissionConfigs.Size = new System.Drawing.Size(31, 30);
            this.fld_btnSaveCompletePermissionConfigs.TabIndex = 8;
            this.fld_btnSaveCompletePermissionConfigs.Text = "bosButton1";
            this.fld_btnSaveCompletePermissionConfigs.Click += new System.EventHandler(this.fld_btnSaveCompletePermissionConfigs_Click);
            // 
            // fld_dgcCompletePermissionConfigsGridControl
            // 
            this.fld_dgcCompletePermissionConfigsGridControl.AllowDrop = true;
            this.fld_dgcCompletePermissionConfigsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcCompletePermissionConfigsGridControl.BOSComment = string.Empty;
            this.fld_dgcCompletePermissionConfigsGridControl.BOSDataMember = null;
            this.fld_dgcCompletePermissionConfigsGridControl.BOSDataSource = "ADCompletePermissionConfigs";
            this.fld_dgcCompletePermissionConfigsGridControl.BOSDescription = null;
            this.fld_dgcCompletePermissionConfigsGridControl.BOSError = string.Empty;
            this.fld_dgcCompletePermissionConfigsGridControl.BOSFieldGroup = string.Empty;
            this.fld_dgcCompletePermissionConfigsGridControl.BOSFieldRelation = null;
            this.fld_dgcCompletePermissionConfigsGridControl.BOSGridType = string.Empty;
            this.fld_dgcCompletePermissionConfigsGridControl.BOSPrivilege = string.Empty;
            this.fld_dgcCompletePermissionConfigsGridControl.BOSPropertyName = null;
            this.fld_dgcCompletePermissionConfigsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcCompletePermissionConfigsGridControl.Location = new System.Drawing.Point(5, 25);
            this.fld_dgcCompletePermissionConfigsGridControl.MainView = this.gridView21;
            this.fld_dgcCompletePermissionConfigsGridControl.Name = "fld_dgcCompletePermissionConfigsGridControl";
            this.fld_dgcCompletePermissionConfigsGridControl.PrintReport = false;
            this.fld_dgcCompletePermissionConfigsGridControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcCompletePermissionConfigsGridControl, true);
            this.fld_dgcCompletePermissionConfigsGridControl.Size = new System.Drawing.Size(768, 629);
            this.fld_dgcCompletePermissionConfigsGridControl.TabIndex = 9;
            this.fld_dgcCompletePermissionConfigsGridControl.Tag = "DC";
            this.fld_dgcCompletePermissionConfigsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView21});
            // 
            // gridView21
            // 
            this.gridView21.GridControl = this.fld_dgcCompletePermissionConfigsGridControl;
            this.gridView21.Name = "gridView21";
            this.gridView21.PaintStyleName = "Office2003";
            // 
            // DMCS116
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(822, 688);
            this.Controls.Add(this.panel1);
            this.Name = "DMCS116";
            this.Text = "Phân quyền dữ liệu";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCompletePermissionConfigsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView21)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel panel1;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSButton fld_btnSaveCompletePermissionConfigs;
        private ADCompletePermissionConfigsGridControl fld_dgcCompletePermissionConfigsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView21;
        private DevExpress.XtraEditors.GroupControl groupControl1;
	}
}
