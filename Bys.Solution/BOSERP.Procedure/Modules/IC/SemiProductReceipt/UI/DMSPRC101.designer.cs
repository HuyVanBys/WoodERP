using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SemiProductReceipt.UI
{
	/// <summary>
	/// Summary description for DMSPRC101
	/// </summary>
	partial class DMSPRC101
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
            this.fld_dgcICReceiptPackageItems = new BOSERP.Modules.SemiProductReceipt.ICReceiptPackageItemsGridControl();
            this.fld_dgvAPInvoiceInItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICReceiptPackageItemDetails = new BOSERP.Modules.SemiProductReceipt.ReceiptPackageItemDetailsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgvAPInvoiceInPaymentTimes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductPackageItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptPackageItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPInvoiceInItems)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptPackageItemDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPInvoiceInPaymentTimes)).BeginInit();
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
            this.bosPanel1.Size = new System.Drawing.Size(1103, 655);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lkeFK_ICProductPackageItemID
            // 
            this.fld_lkeFK_ICProductPackageItemID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductPackageItemID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductPackageItemID.BOSComment = string.Empty;
            this.fld_lkeFK_ICProductPackageItemID.BOSDataMember = "FK_ICProductPackageItemID";
            this.fld_lkeFK_ICProductPackageItemID.BOSDataSource = "ICProductPackages";
            this.fld_lkeFK_ICProductPackageItemID.BOSDescription = null;
            this.fld_lkeFK_ICProductPackageItemID.BOSError = null;
            this.fld_lkeFK_ICProductPackageItemID.BOSFieldGroup = string.Empty;
            this.fld_lkeFK_ICProductPackageItemID.BOSFieldParent = string.Empty;
            this.fld_lkeFK_ICProductPackageItemID.BOSFieldRelation = string.Empty;
            this.fld_lkeFK_ICProductPackageItemID.BOSPrivilege = string.Empty;
            this.fld_lkeFK_ICProductPackageItemID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductPackageItemID.BOSSelectType = string.Empty;
            this.fld_lkeFK_ICProductPackageItemID.BOSSelectTypeValue = string.Empty;
            this.fld_lkeFK_ICProductPackageItemID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductPackageItemID.Location = new System.Drawing.Point(84, 38);
            this.fld_lkeFK_ICProductPackageItemID.Name = "fld_lkeFK_ICProductPackageItemID";
            this.fld_lkeFK_ICProductPackageItemID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductPackageItemID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductPackageItemID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductPackageItemID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductPackageItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductPackageItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductPackageItemNo", "Mã kiện"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductPackageItemName", "Tên kiện")});
            this.fld_lkeFK_ICProductPackageItemID.Properties.DisplayMember = "ICProductPackageItemName";
            this.fld_lkeFK_ICProductPackageItemID.Properties.NullText = string.Empty;
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
            this.fld_lkeFK_ICProductID.BOSComment = string.Empty;
            this.fld_lkeFK_ICProductID.BOSDataMember = "";
            this.fld_lkeFK_ICProductID.BOSDataSource = "";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = string.Empty;
            this.fld_lkeFK_ICProductID.BOSFieldParent = string.Empty;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = string.Empty;
            this.fld_lkeFK_ICProductID.BOSPrivilege = string.Empty;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = string.Empty;
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = string.Empty;
            this.fld_lkeFK_ICProductID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(84, 12);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNoOfOldSys", "Mã HT củ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductID.Properties.NullText = string.Empty;
            this.fld_lkeFK_ICProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(338, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 0;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.Validated += new System.EventHandler(this.fld_lkeFK_ICProductID_Validated);
            this.fld_lkeFK_ICProductID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_ICProductID_QueryPopUp);
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = string.Empty;
            this.bosLabel3.BOSDataMember = string.Empty;
            this.bosLabel3.BOSDataSource = string.Empty;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = string.Empty;
            this.bosLabel3.BOSFieldRelation = string.Empty;
            this.bosLabel3.BOSPrivilege = string.Empty;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(18, 16);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(47, 13);
            this.bosLabel3.TabIndex = 161;
            this.bosLabel3.Tag = string.Empty;
            this.bosLabel3.Text = "Sản phẩm";
            // 
            // btnAddPackage
            // 
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
            this.btnAddPackage.Location = new System.Drawing.Point(315, 38);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Screen = null;
            this.btnAddPackage.Size = new System.Drawing.Size(107, 20);
            this.btnAddPackage.TabIndex = 2;
            this.btnAddPackage.Tag = string.Empty;
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
            this.bosTabControl1.Location = new System.Drawing.Point(6, 73);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.ScreenHelper.SetShowHelp(this.bosTabControl1, true);
            this.bosTabControl1.Size = new System.Drawing.Size(1094, 582);
            this.bosTabControl1.TabIndex = 3;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcICReceiptPackageItems);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.ScreenHelper.SetShowHelp(this.xtraTabPage1, true);
            this.xtraTabPage1.Size = new System.Drawing.Size(1087, 553);
            this.xtraTabPage1.Text = "Danh sách kiện";
            // 
            // fld_dgcICReceiptPackageItems
            // 
            this.fld_dgcICReceiptPackageItems.AllowDrop = true;
            this.fld_dgcICReceiptPackageItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICReceiptPackageItems.BOSComment = string.Empty;
            this.fld_dgcICReceiptPackageItems.BOSDataMember = string.Empty;
            this.fld_dgcICReceiptPackageItems.BOSDataSource = "ICReceiptPackageItems";
            this.fld_dgcICReceiptPackageItems.BOSDescription = null;
            this.fld_dgcICReceiptPackageItems.BOSError = null;
            this.fld_dgcICReceiptPackageItems.BOSFieldGroup = string.Empty;
            this.fld_dgcICReceiptPackageItems.BOSFieldRelation = string.Empty;
            this.fld_dgcICReceiptPackageItems.BOSGridType = null;
            this.fld_dgcICReceiptPackageItems.BOSPrivilege = string.Empty;
            this.fld_dgcICReceiptPackageItems.BOSPropertyName = string.Empty;
            this.fld_dgcICReceiptPackageItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICReceiptPackageItems.Location = new System.Drawing.Point(4, 3);
            this.fld_dgcICReceiptPackageItems.MainView = this.fld_dgvAPInvoiceInItems;
            this.fld_dgcICReceiptPackageItems.Name = "fld_dgcICReceiptPackageItems";
            this.fld_dgcICReceiptPackageItems.PrintReport = false;
            this.fld_dgcICReceiptPackageItems.Screen = null;
            this.fld_dgcICReceiptPackageItems.Size = new System.Drawing.Size(1091, 547);
            this.fld_dgcICReceiptPackageItems.TabIndex = 0;
            this.fld_dgcICReceiptPackageItems.Tag = "DC";
            this.fld_dgcICReceiptPackageItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPInvoiceInItems});
            // 
            // fld_dgvAPInvoiceInItems
            // 
            this.fld_dgvAPInvoiceInItems.GridControl = this.fld_dgcICReceiptPackageItems;
            this.fld_dgvAPInvoiceInItems.Name = "fld_dgvAPInvoiceInItems";
            this.fld_dgvAPInvoiceInItems.PaintStyleName = "Office2003";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcICReceiptPackageItemDetails);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.ScreenHelper.SetShowHelp(this.xtraTabPage3, true);
            this.xtraTabPage3.Size = new System.Drawing.Size(1087, 553);
            this.xtraTabPage3.Text = "Chi tiết kiện";
            // 
            // fld_dgcICReceiptPackageItemDetails
            // 
            this.fld_dgcICReceiptPackageItemDetails.AllowDrop = true;
            this.fld_dgcICReceiptPackageItemDetails.BOSComment = string.Empty;
            this.fld_dgcICReceiptPackageItemDetails.BOSDataMember = string.Empty;
            this.fld_dgcICReceiptPackageItemDetails.BOSDataSource = "ICReceiptPackageItemDetails";
            this.fld_dgcICReceiptPackageItemDetails.BOSDescription = string.Empty;
            this.fld_dgcICReceiptPackageItemDetails.BOSError = null;
            this.fld_dgcICReceiptPackageItemDetails.BOSFieldGroup = string.Empty;
            this.fld_dgcICReceiptPackageItemDetails.BOSFieldRelation = string.Empty;
            this.fld_dgcICReceiptPackageItemDetails.BOSGridType = null;
            this.fld_dgcICReceiptPackageItemDetails.BOSPrivilege = string.Empty;
            this.fld_dgcICReceiptPackageItemDetails.BOSPropertyName = string.Empty;
            this.fld_dgcICReceiptPackageItemDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICReceiptPackageItemDetails.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICReceiptPackageItemDetails.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcICReceiptPackageItemDetails.MainView = this.gridView1;
            this.fld_dgcICReceiptPackageItemDetails.Name = "fld_dgcICReceiptPackageItemDetails";
            this.fld_dgcICReceiptPackageItemDetails.PrintReport = false;
            this.fld_dgcICReceiptPackageItemDetails.Screen = null;
            this.fld_dgcICReceiptPackageItemDetails.Size = new System.Drawing.Size(1087, 553);
            this.fld_dgcICReceiptPackageItemDetails.TabIndex = 11;
            this.fld_dgcICReceiptPackageItemDetails.Tag = "DC";
            this.fld_dgcICReceiptPackageItemDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcICReceiptPackageItemDetails;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = string.Empty;
            this.bosLabel4.BOSDataMember = string.Empty;
            this.bosLabel4.BOSDataSource = string.Empty;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = string.Empty;
            this.bosLabel4.BOSFieldRelation = string.Empty;
            this.bosLabel4.BOSPrivilege = string.Empty;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(18, 42);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(49, 13);
            this.bosLabel4.TabIndex = 140;
            this.bosLabel4.Tag = string.Empty;
            this.bosLabel4.Text = "Nhóm kiện";
            // 
            // fld_dgvAPInvoiceInPaymentTimes
            // 
            this.fld_dgvAPInvoiceInPaymentTimes.Name = "fld_dgvAPInvoiceInPaymentTimes";
            this.fld_dgvAPInvoiceInPaymentTimes.PaintStyleName = "Office2003";
            // 
            // DMSPRC101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1103, 655);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMSPRC101";
            this.Text = "Danh sách kiện";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductPackageItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptPackageItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPInvoiceInItems)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptPackageItemDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPInvoiceInPaymentTimes)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPInvoiceInPaymentTimes;
        private BOSComponent.BOSButton btnAddPackage;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductPackageItemID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private ICReceiptPackageItemsGridControl fld_dgcICReceiptPackageItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPInvoiceInItems;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private ReceiptPackageItemDetailsGridControl fld_dgcICReceiptPackageItemDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
