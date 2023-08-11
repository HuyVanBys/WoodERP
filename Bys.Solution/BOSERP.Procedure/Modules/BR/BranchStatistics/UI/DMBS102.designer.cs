using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.BranchStatistics.UI
{
	/// <summary>
	/// Summary description for SMBS102
	/// </summary>
	partial class DMBS102
	{
		private BOSComponent.BOSGridControl fld_dgcARSaleOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrders;


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
            this.fld_dgcARSaleOrders = new BOSComponent.BOSGridControl(this.components);
            this.fld_dgvARSaleOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabReminder = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabReminder)).BeginInit();
            this.fld_tabReminder.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_dgcARSaleOrders
            // 
            this.fld_dgcARSaleOrders.AllowDrop = true;
            this.fld_dgcARSaleOrders.BOSComment = "";
            this.fld_dgcARSaleOrders.BOSDataMember = null;
            this.fld_dgcARSaleOrders.BOSDataSource = "ARSaleOrders";
            this.fld_dgcARSaleOrders.BOSDescription = null;
            this.fld_dgcARSaleOrders.BOSError = "";
            this.fld_dgcARSaleOrders.BOSFieldGroup = "";
            this.fld_dgcARSaleOrders.BOSFieldRelation = null;
            this.fld_dgcARSaleOrders.BOSGridType = null;
            this.fld_dgcARSaleOrders.BOSPrivilege = "";
            this.fld_dgcARSaleOrders.BOSPropertyName = null;
            this.fld_dgcARSaleOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARSaleOrders.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSaleOrders.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcARSaleOrders.MainView = this.fld_dgvARSaleOrders;
            this.fld_dgcARSaleOrders.Name = "fld_dgcARSaleOrders";
            this.fld_dgcARSaleOrders.Screen = null;
            this.fld_dgcARSaleOrders.Size = new System.Drawing.Size(874, 492);
            this.fld_dgcARSaleOrders.TabIndex = 5;
            this.fld_dgcARSaleOrders.Tag = "DC";
            this.fld_dgcARSaleOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrders});
            // 
            // fld_dgvARSaleOrders
            // 
            this.fld_dgvARSaleOrders.GridControl = this.fld_dgcARSaleOrders;
            this.fld_dgvARSaleOrders.Name = "fld_dgvARSaleOrders";
            this.fld_dgvARSaleOrders.PaintStyleName = "Office2003";
            // 
            // fld_tabReminder
            // 
            this.fld_tabReminder.BOSComment = null;
            this.fld_tabReminder.BOSDataMember = null;
            this.fld_tabReminder.BOSDataSource = null;
            this.fld_tabReminder.BOSDescription = null;
            this.fld_tabReminder.BOSError = null;
            this.fld_tabReminder.BOSFieldGroup = null;
            this.fld_tabReminder.BOSFieldRelation = null;
            this.fld_tabReminder.BOSPrivilege = null;
            this.fld_tabReminder.BOSPropertyName = null;
            this.fld_tabReminder.Location = new System.Drawing.Point(5, 8);
            this.fld_tabReminder.Name = "fld_tabReminder";
            this.fld_tabReminder.Screen = null;
            this.fld_tabReminder.SelectedTabPage = this.xtraTabPage1;
            this.fld_tabReminder.Size = new System.Drawing.Size(881, 521);
            this.fld_tabReminder.TabIndex = 6;
            this.fld_tabReminder.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcARSaleOrders);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(874, 492);
            this.xtraTabPage1.Text = "Mua trả chậm";
            // 
            // DMBS102
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(898, 541);
            this.Controls.Add(this.fld_tabReminder);
            this.Name = "DMBS102";
            this.Text = "Nhắc nhở";
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabReminder)).EndInit();
            this.fld_tabReminder.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSTabControl fld_tabReminder;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
	}
}
