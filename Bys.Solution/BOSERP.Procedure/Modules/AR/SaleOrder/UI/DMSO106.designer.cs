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
	partial class DMSO106
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMSO106));
            this.fld_pnlMainScreen = new BOSComponent.BOSPanel(this.components);
            this.fld_btnEditOtherFees = new BOSComponent.BOSButton(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl = new BOSERP.Modules.SaleOrder.ARSaleOrderItemAllocationFeesGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fld_dgcARSaleOrderItemOtherFeesGridControl = new BOSERP.Modules.SaleOrder.ARSaleOrderItemOtherFeesGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_pnlMainScreen.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemAllocationFeesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemOtherFeesGridControl)).BeginInit();
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
            this.fld_pnlMainScreen.Controls.Add(this.fld_btnEditOtherFees);
            this.fld_pnlMainScreen.Controls.Add(this.groupBox2);
            this.fld_pnlMainScreen.Controls.Add(this.groupBox1);
            this.fld_pnlMainScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_pnlMainScreen.Location = new System.Drawing.Point(0, 0);
            this.fld_pnlMainScreen.Name = "fld_pnlMainScreen";
            this.fld_pnlMainScreen.Screen = null;
            this.fld_pnlMainScreen.Size = new System.Drawing.Size(1048, 672);
            this.fld_pnlMainScreen.TabIndex = 7;
            // 
            // fld_btnEditOtherFees
            // 
            this.fld_btnEditOtherFees.BOSComment = null;
            this.fld_btnEditOtherFees.BOSDataMember = null;
            this.fld_btnEditOtherFees.BOSDataSource = null;
            this.fld_btnEditOtherFees.BOSDescription = null;
            this.fld_btnEditOtherFees.BOSError = null;
            this.fld_btnEditOtherFees.BOSFieldGroup = null;
            this.fld_btnEditOtherFees.BOSFieldRelation = null;
            this.fld_btnEditOtherFees.BOSPrivilege = null;
            this.fld_btnEditOtherFees.BOSPropertyName = null;
            this.fld_btnEditOtherFees.Location = new System.Drawing.Point(6, 3);
            this.fld_btnEditOtherFees.Name = "fld_btnEditOtherFees";
            this.fld_btnEditOtherFees.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnEditOtherFees, true);
            this.fld_btnEditOtherFees.Size = new System.Drawing.Size(113, 23);
            this.fld_btnEditOtherFees.TabIndex = 564;
            this.fld_btnEditOtherFees.Tag = "";
            this.fld_btnEditOtherFees.Text = "Chỉnh sửa";
            this.fld_btnEditOtherFees.Click += new System.EventHandler(this.fld_btnEditOtherFees_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.fld_dgcARSaleOrderItemAllocationFeesGridControl);
            this.groupBox2.Location = new System.Drawing.Point(3, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1042, 376);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm phân bổ";
            // 
            // fld_dgcARSaleOrderItemAllocationFeesGridControl
            // 
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl.BOSComment = "";
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl.BOSDataMember = "";
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl.BOSDataSource = "ARSaleOrderItemAllocationFees";
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl.BOSDescription = null;
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl.BOSError = null;
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl.BOSFieldGroup = "";
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl.BOSFieldRelation = "";
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl.BOSGridType = null;
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl.BOSPrivilege = "";
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl.BOSPropertyName = "";
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl.CommodityType = "";
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl.MainView = this.gridView1;
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl.Name = "fld_dgcARSaleOrderItemAllocationFeesGridControl";
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl.PrintReport = false;
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl.Screen = null;
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl.Size = new System.Drawing.Size(1036, 356);
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl.TabIndex = 26;
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl.Tag = "DC";
            this.fld_dgcARSaleOrderItemAllocationFeesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcARSaleOrderItemAllocationFeesGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.fld_dgcARSaleOrderItemOtherFeesGridControl);
            this.groupBox1.Location = new System.Drawing.Point(3, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 230);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi phí";
            // 
            // fld_dgcARSaleOrderItemOtherFeesGridControl
            // 
            this.fld_dgcARSaleOrderItemOtherFeesGridControl.BOSComment = "";
            this.fld_dgcARSaleOrderItemOtherFeesGridControl.BOSDataMember = "";
            this.fld_dgcARSaleOrderItemOtherFeesGridControl.BOSDataSource = "ARSaleOrderItemOtherFees";
            this.fld_dgcARSaleOrderItemOtherFeesGridControl.BOSDescription = null;
            this.fld_dgcARSaleOrderItemOtherFeesGridControl.BOSError = null;
            this.fld_dgcARSaleOrderItemOtherFeesGridControl.BOSFieldGroup = "";
            this.fld_dgcARSaleOrderItemOtherFeesGridControl.BOSFieldRelation = "";
            this.fld_dgcARSaleOrderItemOtherFeesGridControl.BOSGridType = null;
            this.fld_dgcARSaleOrderItemOtherFeesGridControl.BOSPrivilege = "";
            this.fld_dgcARSaleOrderItemOtherFeesGridControl.BOSPropertyName = "";
            this.fld_dgcARSaleOrderItemOtherFeesGridControl.CommodityType = "";
            this.fld_dgcARSaleOrderItemOtherFeesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARSaleOrderItemOtherFeesGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSaleOrderItemOtherFeesGridControl.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcARSaleOrderItemOtherFeesGridControl.MainView = this.fld_dgvARSaleOrder;
            this.fld_dgcARSaleOrderItemOtherFeesGridControl.Name = "fld_dgcARSaleOrderItemOtherFeesGridControl";
            this.fld_dgcARSaleOrderItemOtherFeesGridControl.PrintReport = false;
            this.fld_dgcARSaleOrderItemOtherFeesGridControl.Screen = null;
            this.fld_dgcARSaleOrderItemOtherFeesGridControl.Size = new System.Drawing.Size(1036, 210);
            this.fld_dgcARSaleOrderItemOtherFeesGridControl.TabIndex = 26;
            this.fld_dgcARSaleOrderItemOtherFeesGridControl.Tag = "DC";
            this.fld_dgcARSaleOrderItemOtherFeesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrder});
            // 
            // fld_dgvARSaleOrder
            // 
            this.fld_dgvARSaleOrder.GridControl = this.fld_dgcARSaleOrderItemOtherFeesGridControl;
            this.fld_dgvARSaleOrder.Name = "fld_dgvARSaleOrder";
            this.fld_dgvARSaleOrder.PaintStyleName = "Office2003";
            // 
            // DMSO106
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1048, 672);
            this.Controls.Add(this.fld_pnlMainScreen);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMSO106.IconOptions.Icon")));
            this.Name = "DMSO106";
            this.Text = "Chi phí cộng thêm";
            this.Controls.SetChildIndex(this.fld_pnlMainScreen, 0);
            this.fld_pnlMainScreen.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemAllocationFeesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemOtherFeesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel fld_pnlMainScreen;
        private ARSaleOrderItemOtherFeesGridControl fld_dgcARSaleOrderItemOtherFeesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ARSaleOrderItemAllocationFeesGridControl fld_dgcARSaleOrderItemAllocationFeesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSButton fld_btnEditOtherFees;
    }
}
