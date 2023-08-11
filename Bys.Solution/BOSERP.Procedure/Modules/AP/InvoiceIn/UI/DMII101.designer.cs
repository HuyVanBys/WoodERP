using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.InvoiceIn.UI
{
	/// <summary>
	/// Summary description for DMII101
	/// </summary>
	partial class DMII101
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
            this.fld_dgcAPInvoiceInPackageItems = new BOSERP.Modules.InvoiceIn.APInvoiceInPackageItemsGridControl();
            this.fld_dgvAPInvoiceInItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcAPInvoiceInPackageItemDetails = new BOSERP.Modules.InvoiceIn.InvoiceInPackageItemDetailsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgvAPInvoiceInPaymentTimes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductPackageItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPInvoiceInPackageItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPInvoiceInItems)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPInvoiceInPackageItemDetails)).BeginInit();
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
            this.fld_lkeFK_ICProductPackageItemID.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ICProductPackageItemID.BOSDataMember = "FK_ICProductPackageItemID";
            this.fld_lkeFK_ICProductPackageItemID.BOSDataSource = "ICProductPackages";
            this.fld_lkeFK_ICProductPackageItemID.BOSDescription = null;
            this.fld_lkeFK_ICProductPackageItemID.BOSError = null;
            this.fld_lkeFK_ICProductPackageItemID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ICProductPackageItemID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ICProductPackageItemID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ICProductPackageItemID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
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
            this.fld_lkeFK_ICProductPackageItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductPackageItemNo", "Mã kiện"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductPackageItemName", "Tên kiện")});
            this.fld_lkeFK_ICProductPackageItemID.Properties.DisplayMember = "ICProductPackageItemName";
            this.fld_lkeFK_ICProductPackageItemID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
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
            this.fld_lkeFK_ICProductID.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ICProductPackages";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ICProductID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ICProductID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
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
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNoOfOldSys", "Mã HT củ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_ICProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(338, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 0;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_ICProductID_EditValueChanged);
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(18, 16);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(47, 13);
            this.bosLabel3.TabIndex = 161;
            this.bosLabel3.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.Text = "Sản phẩm";
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddPackage.Appearance.Options.UseForeColor = true;
            this.btnAddPackage.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.btnAddPackage.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.btnAddPackage.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.btnAddPackage.BOSDescription = null;
            this.btnAddPackage.BOSError = null;
            this.btnAddPackage.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.btnAddPackage.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.btnAddPackage.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.btnAddPackage.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.btnAddPackage.Location = new System.Drawing.Point(350, 38);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Screen = null;
            this.btnAddPackage.Size = new System.Drawing.Size(107, 20);
            this.btnAddPackage.TabIndex = 2;
            this.btnAddPackage.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
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
            this.bosTabControl1.Size = new System.Drawing.Size(1094, 573);
            this.bosTabControl1.TabIndex = 3;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcAPInvoiceInPackageItems);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.ScreenHelper.SetShowHelp(this.xtraTabPage1, true);
            this.xtraTabPage1.Size = new System.Drawing.Size(1087, 544);
            this.xtraTabPage1.Text = "Danh sách kiện";
            // 
            // fld_dgcAPInvoiceInPackageItems
            // 
            this.fld_dgcAPInvoiceInPackageItems.AllowDrop = true;
            this.fld_dgcAPInvoiceInPackageItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPInvoiceInPackageItems.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcAPInvoiceInPackageItems.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcAPInvoiceInPackageItems.BOSDataSource = "APInvoiceInPackageItems";
            this.fld_dgcAPInvoiceInPackageItems.BOSDescription = null;
            this.fld_dgcAPInvoiceInPackageItems.BOSError = null;
            this.fld_dgcAPInvoiceInPackageItems.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcAPInvoiceInPackageItems.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcAPInvoiceInPackageItems.BOSGridType = null;
            this.fld_dgcAPInvoiceInPackageItems.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcAPInvoiceInPackageItems.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcAPInvoiceInPackageItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPInvoiceInPackageItems.Location = new System.Drawing.Point(4, 3);
            this.fld_dgcAPInvoiceInPackageItems.MainView = this.fld_dgvAPInvoiceInItems;
            this.fld_dgcAPInvoiceInPackageItems.Name = "fld_dgcAPInvoiceInPackageItems";
            this.fld_dgcAPInvoiceInPackageItems.PrintReport = false;
            this.fld_dgcAPInvoiceInPackageItems.Screen = null;
            this.fld_dgcAPInvoiceInPackageItems.Size = new System.Drawing.Size(1091, 538);
            this.fld_dgcAPInvoiceInPackageItems.TabIndex = 0;
            this.fld_dgcAPInvoiceInPackageItems.Tag = "DC";
            this.fld_dgcAPInvoiceInPackageItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPInvoiceInItems});
            // 
            // fld_dgvAPInvoiceInItems
            // 
            this.fld_dgvAPInvoiceInItems.GridControl = this.fld_dgcAPInvoiceInPackageItems;
            this.fld_dgvAPInvoiceInItems.Name = "fld_dgvAPInvoiceInItems";
            this.fld_dgvAPInvoiceInItems.PaintStyleName = "Office2003";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcAPInvoiceInPackageItemDetails);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.ScreenHelper.SetShowHelp(this.xtraTabPage3, true);
            this.xtraTabPage3.Size = new System.Drawing.Size(1087, 544);
            this.xtraTabPage3.Text = "Chi tiết kiện";
            // 
            // fld_dgcAPInvoiceInPackageItemDetails
            // 
            this.fld_dgcAPInvoiceInPackageItemDetails.AllowDrop = true;
            this.fld_dgcAPInvoiceInPackageItemDetails.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcAPInvoiceInPackageItemDetails.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcAPInvoiceInPackageItemDetails.BOSDataSource = "APInvoiceInPackageItemDetails";
            this.fld_dgcAPInvoiceInPackageItemDetails.BOSDescription = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcAPInvoiceInPackageItemDetails.BOSError = null;
            this.fld_dgcAPInvoiceInPackageItemDetails.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcAPInvoiceInPackageItemDetails.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcAPInvoiceInPackageItemDetails.BOSGridType = null;
            this.fld_dgcAPInvoiceInPackageItemDetails.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcAPInvoiceInPackageItemDetails.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcAPInvoiceInPackageItemDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcAPInvoiceInPackageItemDetails.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPInvoiceInPackageItemDetails.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcAPInvoiceInPackageItemDetails.MainView = this.gridView1;
            this.fld_dgcAPInvoiceInPackageItemDetails.Name = "fld_dgcAPInvoiceInPackageItemDetails";
            this.fld_dgcAPInvoiceInPackageItemDetails.PrintReport = false;
            this.fld_dgcAPInvoiceInPackageItemDetails.Screen = null;
            this.fld_dgcAPInvoiceInPackageItemDetails.Size = new System.Drawing.Size(1087, 544);
            this.fld_dgcAPInvoiceInPackageItemDetails.TabIndex = 11;
            this.fld_dgcAPInvoiceInPackageItemDetails.Tag = "DC";
            this.fld_dgcAPInvoiceInPackageItemDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcAPInvoiceInPackageItemDetails;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(18, 42);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(49, 13);
            this.bosLabel4.TabIndex = 140;
            this.bosLabel4.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.Text = "Nhóm kiện";
            // 
            // fld_dgvAPInvoiceInPaymentTimes
            // 
            this.fld_dgvAPInvoiceInPaymentTimes.Name = "fld_dgvAPInvoiceInPaymentTimes";
            this.fld_dgvAPInvoiceInPaymentTimes.PaintStyleName = "Office2003";
            // 
            // DMII101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1103, 655);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMII101";
            this.Text = "Danh sách kiện";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductPackageItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPInvoiceInPackageItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPInvoiceInItems)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPInvoiceInPackageItemDetails)).EndInit();
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
        private APInvoiceInPackageItemsGridControl fld_dgcAPInvoiceInPackageItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPInvoiceInItems;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private InvoiceInPackageItemDetailsGridControl fld_dgcAPInvoiceInPackageItemDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
