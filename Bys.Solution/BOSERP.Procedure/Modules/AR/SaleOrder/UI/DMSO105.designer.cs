using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SaleOrder.UI
{
	/// <summary>
	/// Summary description for DMSO101
	/// </summary>
	partial class DMSO105
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMSO105));
            this.fld_pnlMainScreen = new BOSComponent.BOSPanel(this.components);
            this.fld_dgcSaleOrderItemFollowsGridControl = new BOSERP.Modules.SaleOrder.ARSaleOrderItemFollowsGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnViewFollow = new BOSComponent.BOSButton(this.components);
            this.fld_pnlMainScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSaleOrderItemFollowsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).BeginInit();
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
            this.fld_pnlMainScreen.Controls.Add(this.fld_dgcSaleOrderItemFollowsGridControl);
            this.fld_pnlMainScreen.Controls.Add(this.fld_btnViewFollow);
            this.fld_pnlMainScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_pnlMainScreen.Location = new System.Drawing.Point(0, 0);
            this.fld_pnlMainScreen.Name = "fld_pnlMainScreen";
            this.fld_pnlMainScreen.Screen = null;
            this.fld_pnlMainScreen.Size = new System.Drawing.Size(950, 623);
            this.fld_pnlMainScreen.TabIndex = 7;
            // 
            // fld_dgcSaleOrderItemFollowsGridControl
            // 
            this.fld_dgcSaleOrderItemFollowsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcSaleOrderItemFollowsGridControl.BOSComment = "";
            this.fld_dgcSaleOrderItemFollowsGridControl.BOSDataMember = "";
            this.fld_dgcSaleOrderItemFollowsGridControl.BOSDataSource = "ARSaleOrderItems";
            this.fld_dgcSaleOrderItemFollowsGridControl.BOSDescription = null;
            this.fld_dgcSaleOrderItemFollowsGridControl.BOSError = null;
            this.fld_dgcSaleOrderItemFollowsGridControl.BOSFieldGroup = "";
            this.fld_dgcSaleOrderItemFollowsGridControl.BOSFieldRelation = "";
            this.fld_dgcSaleOrderItemFollowsGridControl.BOSGridType = null;
            this.fld_dgcSaleOrderItemFollowsGridControl.BOSPrivilege = "";
            this.fld_dgcSaleOrderItemFollowsGridControl.BOSPropertyName = "";
            this.fld_dgcSaleOrderItemFollowsGridControl.CommodityType = "";
            this.fld_dgcSaleOrderItemFollowsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcSaleOrderItemFollowsGridControl.Location = new System.Drawing.Point(12, 55);
            this.fld_dgcSaleOrderItemFollowsGridControl.MainView = this.fld_dgvARSaleOrder;
            this.fld_dgcSaleOrderItemFollowsGridControl.Name = "fld_dgcSaleOrderItemFollowsGridControl";
            this.fld_dgcSaleOrderItemFollowsGridControl.PrintReport = false;
            this.fld_dgcSaleOrderItemFollowsGridControl.Screen = null;
            this.fld_dgcSaleOrderItemFollowsGridControl.Size = new System.Drawing.Size(926, 556);
            this.fld_dgcSaleOrderItemFollowsGridControl.TabIndex = 26;
            this.fld_dgcSaleOrderItemFollowsGridControl.Tag = "DC";
            this.fld_dgcSaleOrderItemFollowsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrder});
            // 
            // fld_dgvARSaleOrder
            // 
            this.fld_dgvARSaleOrder.GridControl = this.fld_dgcSaleOrderItemFollowsGridControl;
            this.fld_dgvARSaleOrder.Name = "fld_dgvARSaleOrder";
            this.fld_dgvARSaleOrder.PaintStyleName = "Office2003";
            // 
            // fld_btnViewFollow
            // 
            this.fld_btnViewFollow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnViewFollow.BOSComment = null;
            this.fld_btnViewFollow.BOSDataMember = null;
            this.fld_btnViewFollow.BOSDataSource = null;
            this.fld_btnViewFollow.BOSDescription = null;
            this.fld_btnViewFollow.BOSError = null;
            this.fld_btnViewFollow.BOSFieldGroup = null;
            this.fld_btnViewFollow.BOSFieldRelation = null;
            this.fld_btnViewFollow.BOSPrivilege = null;
            this.fld_btnViewFollow.BOSPropertyName = null;
            this.fld_btnViewFollow.Location = new System.Drawing.Point(866, 3);
            this.fld_btnViewFollow.Name = "fld_btnViewFollow";
            this.fld_btnViewFollow.Screen = null;
            this.fld_btnViewFollow.Size = new System.Drawing.Size(72, 46);
            this.fld_btnViewFollow.TabIndex = 22;
            this.fld_btnViewFollow.Text = "Xem";
            this.fld_btnViewFollow.Click += new System.EventHandler(this.fld_btnViewFollow_Click);
            // 
            // DMSO105
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(950, 623);
            this.Controls.Add(this.fld_pnlMainScreen);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMSO105.IconOptions.Icon")));
            this.Name = "DMSO105";
            this.Text = "Theo dõi đơn hàng";
            this.Controls.SetChildIndex(this.fld_pnlMainScreen, 0);
            this.fld_pnlMainScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSaleOrderItemFollowsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel fld_pnlMainScreen;
        private ARSaleOrderItemFollowsGridControl fld_dgcSaleOrderItemFollowsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private BOSComponent.BOSButton fld_btnViewFollow;
    }
}
