using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using BOSComponent;

namespace BOSERP.Modules.Home.UI
{
    /// <summary>
    /// Summary description for DMHM121
    /// </summary>
    partial class DMHM122
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMHM122));
            this.fld_dgvGEHistoryDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnMoveUp = new BOSComponent.BOSButton(this.components);
            this.fld_dgcShipmentSaleOrdersGridControl = new BOSERP.Modules.Home.ShipmentSaleOrdersGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEHistoryDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcShipmentSaleOrdersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgvGEHistoryDetails
            // 
            this.fld_dgvGEHistoryDetails.Name = "fld_dgvGEHistoryDetails";
            this.fld_dgvGEHistoryDetails.PaintStyleName = "Office2003";
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = "";
            this.fld_grcGroupControl.BOSDataMember = "";
            this.fld_grcGroupControl.BOSDataSource = "";
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = "";
            this.fld_grcGroupControl.BOSFieldRelation = "";
            this.fld_grcGroupControl.BOSPrivilege = "";
            this.fld_grcGroupControl.BOSPropertyName = "";
            this.fld_grcGroupControl.Controls.Add(this.fld_btnMoveUp);
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcShipmentSaleOrdersGridControl);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(906, 501);
            this.fld_grcGroupControl.TabIndex = 7;
            this.fld_grcGroupControl.Tag = "";
            this.fld_grcGroupControl.Text = "Danh sách xuất kho bán hàng";
            // 
            // fld_btnMoveUp
            // 
            this.fld_btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnMoveUp.BOSComment = null;
            this.fld_btnMoveUp.BOSDataMember = null;
            this.fld_btnMoveUp.BOSDataSource = null;
            this.fld_btnMoveUp.BOSDescription = null;
            this.fld_btnMoveUp.BOSError = null;
            this.fld_btnMoveUp.BOSFieldGroup = null;
            this.fld_btnMoveUp.BOSFieldRelation = null;
            this.fld_btnMoveUp.BOSPrivilege = null;
            this.fld_btnMoveUp.BOSPropertyName = null;
            this.fld_btnMoveUp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("fld_btnMoveUp.ImageOptions.Image")));
            this.fld_btnMoveUp.Location = new System.Drawing.Point(860, 23);
            this.fld_btnMoveUp.Name = "fld_btnMoveUp";
            this.fld_btnMoveUp.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnMoveUp, true);
            this.fld_btnMoveUp.Size = new System.Drawing.Size(41, 37);
            this.fld_btnMoveUp.TabIndex = 29;
            this.fld_btnMoveUp.ToolTip = "Làm mới danh sách";
            this.fld_btnMoveUp.Click += new System.EventHandler(this.Fld_btnMoveUp_Click);
            // 
            // fld_dgcShipmentSaleOrdersGridControl
            // 
            this.fld_dgcShipmentSaleOrdersGridControl.AllowDrop = true;
            this.fld_dgcShipmentSaleOrdersGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcShipmentSaleOrdersGridControl.BOSComment = "";
            this.fld_dgcShipmentSaleOrdersGridControl.BOSDataMember = "";
            this.fld_dgcShipmentSaleOrdersGridControl.BOSDataSource = "ICShipments";
            this.fld_dgcShipmentSaleOrdersGridControl.BOSDescription = null;
            this.fld_dgcShipmentSaleOrdersGridControl.BOSError = null;
            this.fld_dgcShipmentSaleOrdersGridControl.BOSFieldGroup = "";
            this.fld_dgcShipmentSaleOrdersGridControl.BOSFieldRelation = "";
            this.fld_dgcShipmentSaleOrdersGridControl.BOSGridType = null;
            this.fld_dgcShipmentSaleOrdersGridControl.BOSPrivilege = "";
            this.fld_dgcShipmentSaleOrdersGridControl.BOSPropertyName = "";
            this.fld_dgcShipmentSaleOrdersGridControl.CommodityType = "";
            this.fld_dgcShipmentSaleOrdersGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcShipmentSaleOrdersGridControl.Location = new System.Drawing.Point(0, 22);
            this.fld_dgcShipmentSaleOrdersGridControl.MainView = this.gridView1;
            this.fld_dgcShipmentSaleOrdersGridControl.Name = "fld_dgcShipmentSaleOrdersGridControl";
            this.fld_dgcShipmentSaleOrdersGridControl.PrintReport = false;
            this.fld_dgcShipmentSaleOrdersGridControl.Screen = null;
            this.fld_dgcShipmentSaleOrdersGridControl.Size = new System.Drawing.Size(854, 479);
            this.fld_dgcShipmentSaleOrdersGridControl.TabIndex = 5;
            this.fld_dgcShipmentSaleOrdersGridControl.Tag = "DC";
            this.fld_dgcShipmentSaleOrdersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcShipmentSaleOrdersGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // DMHM122
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(906, 501);
            this.Controls.Add(this.fld_grcGroupControl);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMHM122.IconOptions.Icon")));
            this.Name = "DMHM122";
            this.Text = "Danh sách XKBH chưa có hóa đơn ";
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEHistoryDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcShipmentSaleOrdersGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGEHistoryDetails;
        private BOSGroupControl fld_grcGroupControl;
        private ShipmentSaleOrdersGridControl fld_dgcShipmentSaleOrdersGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSButton fld_btnMoveUp;
    }
}
