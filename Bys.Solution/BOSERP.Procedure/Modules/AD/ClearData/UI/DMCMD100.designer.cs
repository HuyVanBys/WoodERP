using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ClearData.UI
{
	/// <summary>
	/// Summary description for DMCMD100
	/// </summary>
	partial class DMCMD100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMCMD100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnSaveSTModuleClearDatas = new BOSComponent.BOSButton(this.components);
            this.fld_dgcSTModuleClearDatas = new BOSERP.Modules.ClearData.STModuleClearDatasGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSTModuleClearDatas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
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
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(876, 574);
            this.bosPanel1.TabIndex = 6;
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
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage3;
            this.bosTabControl1.Size = new System.Drawing.Size(876, 574);
            this.bosTabControl1.TabIndex = 8;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.bosGroupControl2);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(874, 549);
            this.xtraTabPage3.Text = "Clear Data cho Module";
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosGroupControl2.Appearance.Options.UseBackColor = true;
            this.bosGroupControl2.Appearance.Options.UseForeColor = true;
            this.bosGroupControl2.BOSComment = "";
            this.bosGroupControl2.BOSDataMember = "";
            this.bosGroupControl2.BOSDataSource = "";
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = "";
            this.bosGroupControl2.BOSFieldRelation = "";
            this.bosGroupControl2.BOSPrivilege = "";
            this.bosGroupControl2.BOSPropertyName = "";
            this.bosGroupControl2.Controls.Add(this.fld_btnSaveSTModuleClearDatas);
            this.bosGroupControl2.Controls.Add(this.fld_dgcSTModuleClearDatas);
            this.bosGroupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosGroupControl2.Location = new System.Drawing.Point(0, 0);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(874, 549);
            this.bosGroupControl2.TabIndex = 7;
            this.bosGroupControl2.Tag = "";
            this.bosGroupControl2.Text = "Danh sách cấu hình";
            // 
            // fld_btnSaveSTModuleClearDatas
            // 
            this.fld_btnSaveSTModuleClearDatas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveSTModuleClearDatas.BOSComment = null;
            this.fld_btnSaveSTModuleClearDatas.BOSDataMember = null;
            this.fld_btnSaveSTModuleClearDatas.BOSDataSource = null;
            this.fld_btnSaveSTModuleClearDatas.BOSDescription = null;
            this.fld_btnSaveSTModuleClearDatas.BOSError = null;
            this.fld_btnSaveSTModuleClearDatas.BOSFieldGroup = null;
            this.fld_btnSaveSTModuleClearDatas.BOSFieldRelation = null;
            this.fld_btnSaveSTModuleClearDatas.BOSPrivilege = null;
            this.fld_btnSaveSTModuleClearDatas.BOSPropertyName = null;
            this.fld_btnSaveSTModuleClearDatas.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveSTModuleClearDatas.Location = new System.Drawing.Point(836, 25);
            this.fld_btnSaveSTModuleClearDatas.Name = "fld_btnSaveSTModuleClearDatas";
            this.fld_btnSaveSTModuleClearDatas.Screen = null;
            this.fld_btnSaveSTModuleClearDatas.Size = new System.Drawing.Size(31, 30);
            this.fld_btnSaveSTModuleClearDatas.TabIndex = 8;
            this.fld_btnSaveSTModuleClearDatas.Text = "bosButton1";
            this.fld_btnSaveSTModuleClearDatas.Click += new System.EventHandler(this.fld_btnSaveSTModuleClearDatas_Click);
            // 
            // fld_dgcSTModuleClearDatas
            // 
            this.fld_dgcSTModuleClearDatas.AllowDrop = true;
            this.fld_dgcSTModuleClearDatas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcSTModuleClearDatas.BOSComment = "";
            this.fld_dgcSTModuleClearDatas.BOSDataMember = "";
            this.fld_dgcSTModuleClearDatas.BOSDataSource = "STModuleClearDatas";
            this.fld_dgcSTModuleClearDatas.BOSDescription = null;
            this.fld_dgcSTModuleClearDatas.BOSError = null;
            this.fld_dgcSTModuleClearDatas.BOSFieldGroup = "";
            this.fld_dgcSTModuleClearDatas.BOSFieldRelation = "";
            this.fld_dgcSTModuleClearDatas.BOSGridType = null;
            this.fld_dgcSTModuleClearDatas.BOSPrivilege = "";
            this.fld_dgcSTModuleClearDatas.BOSPropertyName = "";
            this.fld_dgcSTModuleClearDatas.CommodityType = "";
            this.fld_dgcSTModuleClearDatas.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcSTModuleClearDatas.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcSTModuleClearDatas.MainView = this.gridView2;
            this.fld_dgcSTModuleClearDatas.Name = "fld_dgcSTModuleClearDatas";
            this.fld_dgcSTModuleClearDatas.PrintReport = false;
            this.fld_dgcSTModuleClearDatas.Screen = null;
            this.fld_dgcSTModuleClearDatas.Size = new System.Drawing.Size(828, 524);
            this.fld_dgcSTModuleClearDatas.TabIndex = 4;
            this.fld_dgcSTModuleClearDatas.Tag = "DC";
            this.fld_dgcSTModuleClearDatas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcSTModuleClearDatas;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // DMCMD100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(876, 574);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMCMD100.IconOptions.Icon")));
            this.Name = "DMCMD100";
            this.ScreenNumber = "DMCMD100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSTModuleClearDatas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSButton fld_btnSaveSTModuleClearDatas;
        private STModuleClearDatasGridControl fld_dgcSTModuleClearDatas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
	}
}
