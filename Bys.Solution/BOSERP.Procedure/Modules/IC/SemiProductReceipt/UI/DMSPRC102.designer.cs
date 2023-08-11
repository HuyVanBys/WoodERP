using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SemiProductReceipt.UI
{
	/// <summary>
	/// Summary description for DMSPRC102
	/// </summary>
	partial class DMSPRC102
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
            this.btnAddPackage = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICReceiptPackageItemDetails2 = new BOSERP.Modules.SemiProductReceipt.ICReceiptPackageItemDetailReportsGridControl();
            this.fld_dgvAPPurchaseOrderItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgvAPPurchaseOrderPaymentTimes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptPackageItemDetails2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrderPaymentTimes)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.btnAddPackage);
            this.bosPanel1.Controls.Add(this.fld_dgcICReceiptPackageItemDetails2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1103, 655);
            this.bosPanel1.TabIndex = 0;
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPackage.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddPackage.Appearance.Options.UseForeColor = true;
            this.btnAddPackage.BOSComment = string.Empty;
            this.btnAddPackage.BOSDataMember = string.Empty;
            this.btnAddPackage.BOSDataSource = string.Empty;
            this.btnAddPackage.BOSDescription = null;
            this.btnAddPackage.BOSError = null;
            this.btnAddPackage.BOSFieldGroup = string.Empty;
            this.btnAddPackage.BOSFieldRelation = string.Empty;
            this.btnAddPackage.BOSPrivilege = string.Empty;
            this.btnAddPackage.BOSPropertyName = string.Empty;
            this.btnAddPackage.Location = new System.Drawing.Point(949, 12);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Screen = null;
            this.btnAddPackage.Size = new System.Drawing.Size(142, 26);
            this.btnAddPackage.TabIndex = 3;
            this.btnAddPackage.Tag = string.Empty;
            this.btnAddPackage.Text = "Xem chi tiết SP đóng kiện";
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // fld_dgcICReceiptPackageItemDetails2
            // 
            this.fld_dgcICReceiptPackageItemDetails2.AllowDrop = true;
            this.fld_dgcICReceiptPackageItemDetails2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICReceiptPackageItemDetails2.BOSComment = string.Empty;
            this.fld_dgcICReceiptPackageItemDetails2.BOSDataMember = string.Empty;
            this.fld_dgcICReceiptPackageItemDetails2.BOSDataSource = "ICReceiptPackageItemDetails";
            this.fld_dgcICReceiptPackageItemDetails2.BOSDescription = null;
            this.fld_dgcICReceiptPackageItemDetails2.BOSError = null;
            this.fld_dgcICReceiptPackageItemDetails2.BOSFieldGroup = string.Empty;
            this.fld_dgcICReceiptPackageItemDetails2.BOSFieldRelation = string.Empty;
            this.fld_dgcICReceiptPackageItemDetails2.BOSGridType = null;
            this.fld_dgcICReceiptPackageItemDetails2.BOSPrivilege = string.Empty;
            this.fld_dgcICReceiptPackageItemDetails2.BOSPropertyName = string.Empty;
            this.fld_dgcICReceiptPackageItemDetails2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICReceiptPackageItemDetails2.Location = new System.Drawing.Point(0, 57);
            this.fld_dgcICReceiptPackageItemDetails2.MainView = this.fld_dgvAPPurchaseOrderItems;
            this.fld_dgcICReceiptPackageItemDetails2.Name = "fld_dgcICReceiptPackageItemDetails2";
            this.fld_dgcICReceiptPackageItemDetails2.PrintReport = false;
            this.fld_dgcICReceiptPackageItemDetails2.Screen = null;
            this.fld_dgcICReceiptPackageItemDetails2.Size = new System.Drawing.Size(1103, 595);
            this.fld_dgcICReceiptPackageItemDetails2.TabIndex = 2;
            this.fld_dgcICReceiptPackageItemDetails2.Tag = "DC";
            this.fld_dgcICReceiptPackageItemDetails2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPPurchaseOrderItems});
            // 
            // fld_dgvAPPurchaseOrderItems
            // 
            this.fld_dgvAPPurchaseOrderItems.GridControl = this.fld_dgcICReceiptPackageItemDetails2;
            this.fld_dgvAPPurchaseOrderItems.Name = "fld_dgvAPPurchaseOrderItems";
            this.fld_dgvAPPurchaseOrderItems.PaintStyleName = "Office2003";
            // 
            // fld_dgvAPPurchaseOrderPaymentTimes
            // 
            this.fld_dgvAPPurchaseOrderPaymentTimes.Name = "fld_dgvAPPurchaseOrderPaymentTimes";
            this.fld_dgvAPPurchaseOrderPaymentTimes.PaintStyleName = "Office2003";
            // 
            // DMSPRC102
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1103, 655);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMSPRC102";
            this.Text = "Chi tiết SP đóng kiện";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptPackageItemDetails2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrderPaymentTimes)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPPurchaseOrderPaymentTimes;
        private ICReceiptPackageItemDetailReportsGridControl fld_dgcICReceiptPackageItemDetails2;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPPurchaseOrderItems;
        private BOSComponent.BOSButton btnAddPackage;
    }
}
