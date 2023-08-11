using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ShipmentSaleOrder.UI
{
	/// <summary>
	/// Summary description for DMSOSM101
	/// </summary>
	partial class DMSOSM101
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
            this.fld_lkeFK_ICProductPackageItemID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.btnAddPackage = new BOSComponent.BOSButton(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICShipmentPackageItems = new BOSERP.Modules.ShipmentSaleOrder.ICShipmentPackageItemsGridControl();
            this.fld_dgvAPPurchaseOrderItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICShipmentPackageItemDetails = new BOSERP.Modules.ShipmentSaleOrder.ShipmentPackageItemDetailsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgvAPPurchaseOrderPaymentTimes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductPackageItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentPackageItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrderItems)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentPackageItemDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductPackageItemID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductID);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.btnAddPackage);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1109, 662);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lkeFK_ICProductPackageItemID
            // 
            this.fld_lkeFK_ICProductPackageItemID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductPackageItemID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductPackageItemID.BOSComment = "";
            this.fld_lkeFK_ICProductPackageItemID.BOSDataMember = "FK_ICProductPackageItemID";
            this.fld_lkeFK_ICProductPackageItemID.BOSDataSource = "ICProductPackages";
            this.fld_lkeFK_ICProductPackageItemID.BOSDescription = null;
            this.fld_lkeFK_ICProductPackageItemID.BOSError = null;
            this.fld_lkeFK_ICProductPackageItemID.BOSFieldGroup = "";
            this.fld_lkeFK_ICProductPackageItemID.BOSFieldParent = "";
            this.fld_lkeFK_ICProductPackageItemID.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductPackageItemID.BOSPrivilege = "";
            this.fld_lkeFK_ICProductPackageItemID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductPackageItemID.BOSSelectType = "";
            this.fld_lkeFK_ICProductPackageItemID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICProductPackageItemID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductPackageItemID.Location = new System.Drawing.Point(119, 38);
            this.fld_lkeFK_ICProductPackageItemID.Name = "fld_lkeFK_ICProductPackageItemID";
            this.fld_lkeFK_ICProductPackageItemID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductPackageItemID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductPackageItemID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductPackageItemID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductPackageItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductPackageItemID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductPackageItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductPackageItemNo", "Mã kiện"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductPackageItemName", "Tên kiện")});
            this.fld_lkeFK_ICProductPackageItemID.Properties.DisplayMember = "ICProductPackageItemName";
            this.fld_lkeFK_ICProductPackageItemID.Properties.NullText = "";
            this.fld_lkeFK_ICProductPackageItemID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductPackageItemID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductPackageItemID.Properties.ValueMember = "ICProductPackageItemID";
            this.fld_lkeFK_ICProductPackageItemID.Screen = null;
            this.fld_lkeFK_ICProductPackageItemID.Size = new System.Drawing.Size(203, 20);
            this.fld_lkeFK_ICProductPackageItemID.TabIndex = 1;
            this.fld_lkeFK_ICProductPackageItemID.Tag = "DC";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductID.BOSComment = "";
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ICProductPackages";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = "";
            this.fld_lkeFK_ICProductID.BOSFieldParent = "";
            this.fld_lkeFK_ICProductID.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductID.BOSPrivilege = "";
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(119, 12);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNoOfOldSys", "Mã HT củ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductID.Properties.NullText = "";
            this.fld_lkeFK_ICProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(338, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 0;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "";
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(18, 16);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(47, 13);
            this.bosLabel3.TabIndex = 161;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Sản phẩm";
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddPackage.Appearance.Options.UseForeColor = true;
            this.btnAddPackage.BOSComment = "";
            this.btnAddPackage.BOSDataMember = "";
            this.btnAddPackage.BOSDataSource = "";
            this.btnAddPackage.BOSDescription = null;
            this.btnAddPackage.BOSError = null;
            this.btnAddPackage.BOSFieldGroup = "";
            this.btnAddPackage.BOSFieldRelation = "";
            this.btnAddPackage.BOSPrivilege = "";
            this.btnAddPackage.BOSPropertyName = "";
            this.btnAddPackage.Location = new System.Drawing.Point(350, 38);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Screen = null;
            this.btnAddPackage.Size = new System.Drawing.Size(107, 20);
            this.btnAddPackage.TabIndex = 2;
            this.btnAddPackage.Tag = "";
            this.btnAddPackage.Text = "Thêm kiện";
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Location = new System.Drawing.Point(6, 82);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.ScreenHelper.SetShowHelp(this.bosTabControl1, true);
            this.bosTabControl1.Size = new System.Drawing.Size(1100, 580);
            this.bosTabControl1.TabIndex = 3;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcICShipmentPackageItems);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.ScreenHelper.SetShowHelp(this.xtraTabPage1, true);
            this.xtraTabPage1.Size = new System.Drawing.Size(1094, 552);
            this.xtraTabPage1.Text = "Danh sách kiện";
            // 
            // fld_dgcICShipmentPackageItems
            // 
            this.fld_dgcICShipmentPackageItems.AllowDrop = true;
            this.fld_dgcICShipmentPackageItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICShipmentPackageItems.BOSComment = "";
            this.fld_dgcICShipmentPackageItems.BOSDataMember = "";
            this.fld_dgcICShipmentPackageItems.BOSDataSource = "ICShipmentPackageItems";
            this.fld_dgcICShipmentPackageItems.BOSDescription = null;
            this.fld_dgcICShipmentPackageItems.BOSError = null;
            this.fld_dgcICShipmentPackageItems.BOSFieldGroup = "";
            this.fld_dgcICShipmentPackageItems.BOSFieldRelation = "";
            this.fld_dgcICShipmentPackageItems.BOSGridType = null;
            this.fld_dgcICShipmentPackageItems.BOSPrivilege = "";
            this.fld_dgcICShipmentPackageItems.BOSPropertyName = "";
            this.fld_dgcICShipmentPackageItems.CommodityType = "";
            this.fld_dgcICShipmentPackageItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICShipmentPackageItems.Location = new System.Drawing.Point(4, 3);
            this.fld_dgcICShipmentPackageItems.MainView = this.fld_dgvAPPurchaseOrderItems;
            this.fld_dgcICShipmentPackageItems.Name = "fld_dgcICShipmentPackageItems";
            this.fld_dgcICShipmentPackageItems.PrintReport = false;
            this.fld_dgcICShipmentPackageItems.Screen = null;
            this.fld_dgcICShipmentPackageItems.Size = new System.Drawing.Size(1098, 546);
            this.fld_dgcICShipmentPackageItems.TabIndex = 0;
            this.fld_dgcICShipmentPackageItems.Tag = "DC";
            this.fld_dgcICShipmentPackageItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPPurchaseOrderItems});
            // 
            // fld_dgvAPPurchaseOrderItems
            // 
            this.fld_dgvAPPurchaseOrderItems.GridControl = this.fld_dgcICShipmentPackageItems;
            this.fld_dgvAPPurchaseOrderItems.Name = "fld_dgvAPPurchaseOrderItems";
            this.fld_dgvAPPurchaseOrderItems.PaintStyleName = "Office2003";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcICShipmentPackageItemDetails);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.ScreenHelper.SetShowHelp(this.xtraTabPage3, true);
            this.xtraTabPage3.Size = new System.Drawing.Size(1094, 552);
            this.xtraTabPage3.Text = "Chi tiết kiện";
            // 
            // fld_dgcICShipmentPackageItemDetails
            // 
            this.fld_dgcICShipmentPackageItemDetails.AllowDrop = true;
            this.fld_dgcICShipmentPackageItemDetails.BOSComment = "";
            this.fld_dgcICShipmentPackageItemDetails.BOSDataMember = "";
            this.fld_dgcICShipmentPackageItemDetails.BOSDataSource = "ICShipmentPackageItemDetails";
            this.fld_dgcICShipmentPackageItemDetails.BOSDescription = "";
            this.fld_dgcICShipmentPackageItemDetails.BOSError = null;
            this.fld_dgcICShipmentPackageItemDetails.BOSFieldGroup = "";
            this.fld_dgcICShipmentPackageItemDetails.BOSFieldRelation = "";
            this.fld_dgcICShipmentPackageItemDetails.BOSGridType = null;
            this.fld_dgcICShipmentPackageItemDetails.BOSPrivilege = "";
            this.fld_dgcICShipmentPackageItemDetails.BOSPropertyName = "";
            this.fld_dgcICShipmentPackageItemDetails.CommodityType = "";
            this.fld_dgcICShipmentPackageItemDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICShipmentPackageItemDetails.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICShipmentPackageItemDetails.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcICShipmentPackageItemDetails.MainView = this.gridView1;
            this.fld_dgcICShipmentPackageItemDetails.Name = "fld_dgcICShipmentPackageItemDetails";
            this.fld_dgcICShipmentPackageItemDetails.PrintReport = false;
            this.fld_dgcICShipmentPackageItemDetails.Screen = null;
            this.fld_dgcICShipmentPackageItemDetails.Size = new System.Drawing.Size(1094, 552);
            this.fld_dgcICShipmentPackageItemDetails.TabIndex = 11;
            this.fld_dgcICShipmentPackageItemDetails.Tag = "DC";
            this.fld_dgcICShipmentPackageItemDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcICShipmentPackageItemDetails;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = "";
            this.bosLabel4.BOSDataMember = "";
            this.bosLabel4.BOSDataSource = "";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = "";
            this.bosLabel4.BOSPrivilege = "";
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(18, 42);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(49, 13);
            this.bosLabel4.TabIndex = 140;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Nhóm kiện";
            // 
            // fld_dgvAPPurchaseOrderPaymentTimes
            // 
            this.fld_dgvAPPurchaseOrderPaymentTimes.Name = "fld_dgvAPPurchaseOrderPaymentTimes";
            this.fld_dgvAPPurchaseOrderPaymentTimes.PaintStyleName = "Office2003";
            // 
            // DMSOSM101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1109, 662);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMSOSM101";
            this.Text = "Danh sách kiện";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductPackageItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentPackageItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrderItems)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentPackageItemDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrderPaymentTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPPurchaseOrderPaymentTimes;
        private BOSComponent.BOSButton btnAddPackage;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductPackageItemID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private ICShipmentPackageItemsGridControl fld_dgcICShipmentPackageItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPPurchaseOrderItems;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private ShipmentPackageItemDetailsGridControl fld_dgcICShipmentPackageItemDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
