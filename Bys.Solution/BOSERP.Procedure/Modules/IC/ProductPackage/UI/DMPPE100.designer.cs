using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductPackage.UI
{
	/// <summary>
    /// Summary description for DMPPE100
	/// </summary>
    partial class DMPPE100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPPE100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_chkSelectAll = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_btnPrintQR = new BOSComponent.BOSButton(this.components);
            this.fld_tabProductWorkItem = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabProduct = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductPackages = new BOSERP.Modules.ProductPackage.ICProductPackagesGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_grcGroupControl5 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnFind = new BOSComponent.BOSButton(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICPackageSupplierNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeAPSupplierID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtSerial = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeICProductAttributeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtBarcodeNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtPackageName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtPackageNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_ckeGetInfoFromBatch = new BOSComponent.BOSCheckEdit(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductWorkItem)).BeginInit();
            this.fld_tabProductWorkItem.SuspendLayout();
            this.fld_tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).BeginInit();
            this.fld_grcGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPackageSupplierNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPSupplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSerial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductAttributeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBarcodeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPackageName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPackageNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeGetInfoFromBatch.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.fld_tabProductWorkItem);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl5);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosPanel1, true);
            this.bosPanel1.Size = new System.Drawing.Size(1054, 629);
            this.bosPanel1.TabIndex = 335;
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosGroupControl1.Appearance.Options.UseBackColor = true;
            this.bosGroupControl1.Appearance.Options.UseForeColor = true;
            this.bosGroupControl1.BOSComment = "";
            this.bosGroupControl1.BOSDataMember = "";
            this.bosGroupControl1.BOSDataSource = "";
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = "";
            this.bosGroupControl1.BOSFieldRelation = "";
            this.bosGroupControl1.BOSPrivilege = "";
            this.bosGroupControl1.BOSPropertyName = "";
            this.bosGroupControl1.Controls.Add(this.fld_chkSelectAll);
            this.bosGroupControl1.Controls.Add(this.fld_btnPrintQR);
            this.bosGroupControl1.Location = new System.Drawing.Point(931, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosGroupControl1, true);
            this.bosGroupControl1.Size = new System.Drawing.Size(118, 116);
            this.bosGroupControl1.TabIndex = 172;
            this.bosGroupControl1.Tag = "";
            this.bosGroupControl1.Text = "In QR code";
            // 
            // fld_chkSelectAll
            // 
            this.fld_chkSelectAll.BOSComment = null;
            this.fld_chkSelectAll.BOSDataMember = null;
            this.fld_chkSelectAll.BOSDataSource = null;
            this.fld_chkSelectAll.BOSDescription = null;
            this.fld_chkSelectAll.BOSError = null;
            this.fld_chkSelectAll.BOSFieldGroup = null;
            this.fld_chkSelectAll.BOSFieldRelation = null;
            this.fld_chkSelectAll.BOSPrivilege = null;
            this.fld_chkSelectAll.BOSPropertyName = null;
            this.fld_chkSelectAll.Location = new System.Drawing.Point(17, 46);
            this.fld_chkSelectAll.MenuManager = this.screenToolbar;
            this.fld_chkSelectAll.Name = "fld_chkSelectAll";
            this.fld_chkSelectAll.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_chkSelectAll.Properties.Appearance.Options.UseFont = true;
            this.fld_chkSelectAll.Properties.Caption = "Chọn tất cả";
            this.fld_chkSelectAll.Screen = null;
            this.fld_chkSelectAll.Size = new System.Drawing.Size(90, 19);
            this.fld_chkSelectAll.TabIndex = 172;
            this.fld_chkSelectAll.CheckedChanged += new System.EventHandler(this.fld_chkSelectAll_CheckedChanged);
            // 
            // fld_btnPrintQR
            // 
            this.fld_btnPrintQR.BOSComment = null;
            this.fld_btnPrintQR.BOSDataMember = null;
            this.fld_btnPrintQR.BOSDataSource = null;
            this.fld_btnPrintQR.BOSDescription = null;
            this.fld_btnPrintQR.BOSError = null;
            this.fld_btnPrintQR.BOSFieldGroup = null;
            this.fld_btnPrintQR.BOSFieldRelation = null;
            this.fld_btnPrintQR.BOSPrivilege = null;
            this.fld_btnPrintQR.BOSPropertyName = null;
            this.fld_btnPrintQR.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.fld_btnPrintQR.Location = new System.Drawing.Point(17, 72);
            this.fld_btnPrintQR.Name = "fld_btnPrintQR";
            this.fld_btnPrintQR.Screen = null;
            this.fld_btnPrintQR.Size = new System.Drawing.Size(90, 26);
            this.fld_btnPrintQR.TabIndex = 171;
            this.fld_btnPrintQR.Text = "In QR code";
            this.fld_btnPrintQR.Click += new System.EventHandler(this.fld_btnPrintQR_Click);
            // 
            // fld_tabProductWorkItem
            // 
            this.fld_tabProductWorkItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabProductWorkItem.BOSComment = null;
            this.fld_tabProductWorkItem.BOSDataMember = null;
            this.fld_tabProductWorkItem.BOSDataSource = null;
            this.fld_tabProductWorkItem.BOSDescription = null;
            this.fld_tabProductWorkItem.BOSError = null;
            this.fld_tabProductWorkItem.BOSFieldGroup = null;
            this.fld_tabProductWorkItem.BOSFieldRelation = null;
            this.fld_tabProductWorkItem.BOSPrivilege = null;
            this.fld_tabProductWorkItem.BOSPropertyName = null;
            this.fld_tabProductWorkItem.Location = new System.Drawing.Point(6, 125);
            this.fld_tabProductWorkItem.Name = "fld_tabProductWorkItem";
            this.fld_tabProductWorkItem.Screen = null;
            this.fld_tabProductWorkItem.SelectedTabPage = this.fld_tabProduct;
            this.fld_tabProductWorkItem.Size = new System.Drawing.Size(1048, 501);
            this.fld_tabProductWorkItem.TabIndex = 171;
            this.fld_tabProductWorkItem.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabProduct});
            // 
            // fld_tabProduct
            // 
            this.fld_tabProduct.Controls.Add(this.fld_dgcICProductPackages);
            this.fld_tabProduct.Name = "fld_tabProduct";
            this.fld_tabProduct.Size = new System.Drawing.Size(1042, 473);
            this.fld_tabProduct.Text = "Thông tin chi tiết kiện";
            // 
            // fld_dgcICProductPackages
            // 
            this.fld_dgcICProductPackages.AllowDrop = true;
            this.fld_dgcICProductPackages.BOSComment = null;
            this.fld_dgcICProductPackages.BOSDataMember = null;
            this.fld_dgcICProductPackages.BOSDataSource = "ICProductPackages";
            this.fld_dgcICProductPackages.BOSDescription = null;
            this.fld_dgcICProductPackages.BOSError = null;
            this.fld_dgcICProductPackages.BOSFieldGroup = null;
            this.fld_dgcICProductPackages.BOSFieldRelation = null;
            this.fld_dgcICProductPackages.BOSGridType = null;
            this.fld_dgcICProductPackages.BOSPrivilege = null;
            this.fld_dgcICProductPackages.BOSPropertyName = null;
            this.fld_dgcICProductPackages.CommodityType = "";
            this.fld_dgcICProductPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICProductPackages.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICProductPackages.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcICProductPackages.Name = "fld_dgcICProductPackages";
            this.fld_dgcICProductPackages.PrintReport = false;
            this.fld_dgcICProductPackages.Screen = null;
            this.fld_dgcICProductPackages.Size = new System.Drawing.Size(1042, 473);
            this.fld_dgcICProductPackages.TabIndex = 0;
            this.fld_dgcICProductPackages.Tag = "DC";
            this.fld_dgcICProductPackages.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrder});
            // 
            // fld_dgvARSaleOrder
            // 
            this.fld_dgvARSaleOrder.GridControl = this.fld_dgcICProductPackages;
            this.fld_dgvARSaleOrder.Name = "fld_dgvARSaleOrder";
            this.fld_dgvARSaleOrder.PaintStyleName = "Office2003";
            // 
            // fld_grcGroupControl5
            // 
            this.fld_grcGroupControl5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl5.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl5.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl5.BOSComment = "";
            this.fld_grcGroupControl5.BOSDataMember = "";
            this.fld_grcGroupControl5.BOSDataSource = "";
            this.fld_grcGroupControl5.BOSDescription = null;
            this.fld_grcGroupControl5.BOSError = null;
            this.fld_grcGroupControl5.BOSFieldGroup = "";
            this.fld_grcGroupControl5.BOSFieldRelation = "";
            this.fld_grcGroupControl5.BOSPrivilege = "";
            this.fld_grcGroupControl5.BOSPropertyName = "";
            this.fld_grcGroupControl5.Controls.Add(this.fld_ckeGetInfoFromBatch);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeMMBatchProductID);
            this.fld_grcGroupControl5.Controls.Add(this.fld_btnFind);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel6);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICPackageSupplierNo);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeAPSupplierID);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel7);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtSerial);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeICProductID);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeICProductAttributeID);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel2);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel3);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtBarcodeNo);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtPackageName);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtPackageNo);
            this.fld_grcGroupControl5.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl5.Name = "fld_grcGroupControl5";
            this.fld_grcGroupControl5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl5, true);
            this.fld_grcGroupControl5.Size = new System.Drawing.Size(922, 116);
            this.fld_grcGroupControl5.TabIndex = 1;
            this.fld_grcGroupControl5.Tag = "";
            this.fld_grcGroupControl5.Text = "Thông tin tìm kiếm";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(270, 78);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(38, 13);
            this.bosLabel1.TabIndex = 172;
            this.bosLabel1.Text = "Lệnh SX";
            // 
            // fld_lkeMMBatchProductID
            // 
            this.fld_lkeMMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeMMBatchProductID.BOSAllowDummy = true;
            this.fld_lkeMMBatchProductID.BOSComment = null;
            this.fld_lkeMMBatchProductID.BOSDataMember = "MMBatchProductID";
            this.fld_lkeMMBatchProductID.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMBatchProductID.BOSDescription = null;
            this.fld_lkeMMBatchProductID.BOSError = "";
            this.fld_lkeMMBatchProductID.BOSFieldGroup = null;
            this.fld_lkeMMBatchProductID.BOSFieldParent = null;
            this.fld_lkeMMBatchProductID.BOSFieldRelation = null;
            this.fld_lkeMMBatchProductID.BOSPrivilege = null;
            this.fld_lkeMMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeMMBatchProductID.BOSSelectType = "MMBatchProductStatus";
            this.fld_lkeMMBatchProductID.BOSSelectTypeValue = "Approved;Producing";
            this.fld_lkeMMBatchProductID.CurrentDisplayText = null;
            this.fld_lkeMMBatchProductID.Location = new System.Drawing.Point(349, 75);
            this.fld_lkeMMBatchProductID.Name = "fld_lkeMMBatchProductID";
            this.fld_lkeMMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMBatchProductID.Properties.ColumnName = null;
            this.fld_lkeMMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã lệnh ")});
            this.fld_lkeMMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeMMBatchProductID.Properties.NullText = "";
            this.fld_lkeMMBatchProductID.Properties.PopupWidth = 40;
            this.fld_lkeMMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeMMBatchProductID.Screen = null;
            this.fld_lkeMMBatchProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMBatchProductID.TabIndex = 173;
            this.fld_lkeMMBatchProductID.Tag = "DC";
            // 
            // fld_btnFind
            // 
            this.fld_btnFind.BOSComment = null;
            this.fld_btnFind.BOSDataMember = null;
            this.fld_btnFind.BOSDataSource = null;
            this.fld_btnFind.BOSDescription = null;
            this.fld_btnFind.BOSError = null;
            this.fld_btnFind.BOSFieldGroup = null;
            this.fld_btnFind.BOSFieldRelation = null;
            this.fld_btnFind.BOSPrivilege = null;
            this.fld_btnFind.BOSPropertyName = null;
            this.fld_btnFind.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("fld_btnFind.ImageOptions.Image")));
            this.fld_btnFind.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.fld_btnFind.Location = new System.Drawing.Point(788, 72);
            this.fld_btnFind.Name = "fld_btnFind";
            this.fld_btnFind.Screen = null;
            this.fld_btnFind.Size = new System.Drawing.Size(90, 26);
            this.fld_btnFind.TabIndex = 171;
            this.fld_btnFind.Click += new System.EventHandler(this.Fld_btnFind_Click);
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = "";
            this.bosLabel6.BOSDataMember = "";
            this.bosLabel6.BOSDataSource = "";
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = "";
            this.bosLabel6.BOSFieldRelation = "";
            this.bosLabel6.BOSPrivilege = "";
            this.bosLabel6.BOSPropertyName = "";
            this.bosLabel6.Location = new System.Drawing.Point(530, 52);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(60, 13);
            this.bosLabel6.TabIndex = 170;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Mã kiện NCC";
            // 
            // fld_txtICPackageSupplierNo
            // 
            this.fld_txtICPackageSupplierNo.BOSComment = "";
            this.fld_txtICPackageSupplierNo.BOSDataMember = "";
            this.fld_txtICPackageSupplierNo.BOSDataSource = "";
            this.fld_txtICPackageSupplierNo.BOSDescription = null;
            this.fld_txtICPackageSupplierNo.BOSError = null;
            this.fld_txtICPackageSupplierNo.BOSFieldGroup = "";
            this.fld_txtICPackageSupplierNo.BOSFieldRelation = "";
            this.fld_txtICPackageSupplierNo.BOSPrivilege = "";
            this.fld_txtICPackageSupplierNo.BOSPropertyName = "Text";
            this.fld_txtICPackageSupplierNo.EditValue = "";
            this.fld_txtICPackageSupplierNo.Location = new System.Drawing.Point(610, 49);
            this.fld_txtICPackageSupplierNo.Name = "fld_txtICPackageSupplierNo";
            this.fld_txtICPackageSupplierNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICPackageSupplierNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICPackageSupplierNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICPackageSupplierNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICPackageSupplierNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICPackageSupplierNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICPackageSupplierNo.Screen = null;
            this.fld_txtICPackageSupplierNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICPackageSupplierNo.TabIndex = 169;
            this.fld_txtICPackageSupplierNo.Tag = "DC";
            // 
            // fld_lkeAPSupplierID
            // 
            this.fld_lkeAPSupplierID.BOSAllowAddNew = false;
            this.fld_lkeAPSupplierID.BOSAllowDummy = false;
            this.fld_lkeAPSupplierID.BOSComment = "";
            this.fld_lkeAPSupplierID.BOSDataMember = "APSupplierID";
            this.fld_lkeAPSupplierID.BOSDataSource = "APSuppliers";
            this.fld_lkeAPSupplierID.BOSDescription = null;
            this.fld_lkeAPSupplierID.BOSError = null;
            this.fld_lkeAPSupplierID.BOSFieldGroup = "";
            this.fld_lkeAPSupplierID.BOSFieldParent = "";
            this.fld_lkeAPSupplierID.BOSFieldRelation = "";
            this.fld_lkeAPSupplierID.BOSPrivilege = "";
            this.fld_lkeAPSupplierID.BOSPropertyName = "EditValue";
            this.fld_lkeAPSupplierID.BOSSelectType = "";
            this.fld_lkeAPSupplierID.BOSSelectTypeValue = "";
            this.fld_lkeAPSupplierID.CurrentDisplayText = null;
            this.fld_lkeAPSupplierID.Location = new System.Drawing.Point(610, 23);
            this.fld_lkeAPSupplierID.Name = "fld_lkeAPSupplierID";
            this.fld_lkeAPSupplierID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPSupplierID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPSupplierID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPSupplierID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPSupplierID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPSupplierID.Properties.ColumnName = null;
            this.fld_lkeAPSupplierID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierNo", "Mã nhà cung cấp", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierName", "Tên nhà cung cấp")});
            this.fld_lkeAPSupplierID.Properties.DisplayMember = "APSupplierName";
            this.fld_lkeAPSupplierID.Properties.NullText = "";
            this.fld_lkeAPSupplierID.Properties.PopupWidth = 40;
            this.fld_lkeAPSupplierID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPSupplierID.Properties.ValueMember = "APSupplierID";
            this.fld_lkeAPSupplierID.Screen = null;
            this.fld_lkeAPSupplierID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPSupplierID.TabIndex = 167;
            this.fld_lkeAPSupplierID.Tag = "DC";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = "";
            this.fld_lblLabel7.BOSDataMember = "";
            this.fld_lblLabel7.BOSDataSource = "";
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = "";
            this.fld_lblLabel7.BOSFieldRelation = "";
            this.fld_lblLabel7.BOSPrivilege = "";
            this.fld_lblLabel7.BOSPropertyName = "";
            this.fld_lblLabel7.Location = new System.Drawing.Point(530, 26);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel7.TabIndex = 168;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Nhà cung cấp";
            // 
            // fld_txtSerial
            // 
            this.fld_txtSerial.BOSComment = "";
            this.fld_txtSerial.BOSDataMember = "";
            this.fld_txtSerial.BOSDataSource = "";
            this.fld_txtSerial.BOSDescription = null;
            this.fld_txtSerial.BOSError = null;
            this.fld_txtSerial.BOSFieldGroup = "";
            this.fld_txtSerial.BOSFieldRelation = "";
            this.fld_txtSerial.BOSPrivilege = "";
            this.fld_txtSerial.BOSPropertyName = "Text";
            this.fld_txtSerial.EditValue = "";
            this.fld_txtSerial.Location = new System.Drawing.Point(349, 49);
            this.fld_txtSerial.Name = "fld_txtSerial";
            this.fld_txtSerial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtSerial.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtSerial.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtSerial.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtSerial.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtSerial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtSerial.Screen = null;
            this.fld_txtSerial.Size = new System.Drawing.Size(150, 20);
            this.fld_txtSerial.TabIndex = 165;
            this.fld_txtSerial.Tag = "DC";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = "";
            this.fld_lblLabel4.BOSDataMember = "";
            this.fld_lblLabel4.BOSDataSource = "";
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = "";
            this.fld_lblLabel4.BOSFieldRelation = "";
            this.fld_lblLabel4.BOSPrivilege = "";
            this.fld_lblLabel4.BOSPropertyName = "";
            this.fld_lblLabel4.Location = new System.Drawing.Point(270, 52);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(52, 13);
            this.fld_lblLabel4.TabIndex = 166;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Mã lô hàng";
            // 
            // fld_lkeICProductID
            // 
            this.fld_lkeICProductID.BOSAllowAddNew = false;
            this.fld_lkeICProductID.BOSAllowDummy = true;
            this.fld_lkeICProductID.BOSComment = "";
            this.fld_lkeICProductID.BOSDataMember = "ICProductID";
            this.fld_lkeICProductID.BOSDataSource = "ICProducts";
            this.fld_lkeICProductID.BOSDescription = null;
            this.fld_lkeICProductID.BOSError = null;
            this.fld_lkeICProductID.BOSFieldGroup = "";
            this.fld_lkeICProductID.BOSFieldParent = "";
            this.fld_lkeICProductID.BOSFieldRelation = "";
            this.fld_lkeICProductID.BOSPrivilege = "";
            this.fld_lkeICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeICProductID.BOSSelectType = "ICProductType";
            this.fld_lkeICProductID.BOSSelectTypeValue = "Product";
            this.fld_lkeICProductID.CurrentDisplayText = null;
            this.fld_lkeICProductID.Location = new System.Drawing.Point(349, 23);
            this.fld_lkeICProductID.Name = "fld_lkeICProductID";
            this.fld_lkeICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductID.Properties.ColumnName = null;
            this.fld_lkeICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNoOfOldSys", "Mã HT củ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeICProductID.Properties.NullText = "";
            this.fld_lkeICProductID.Properties.PopupWidth = 40;
            this.fld_lkeICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductID.Screen = null;
            this.fld_lkeICProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICProductID.TabIndex = 2;
            this.fld_lkeICProductID.Tag = "DC";
            // 
            // fld_lkeICProductAttributeID
            // 
            this.fld_lkeICProductAttributeID.BOSAllowAddNew = false;
            this.fld_lkeICProductAttributeID.BOSAllowDummy = false;
            this.fld_lkeICProductAttributeID.BOSComment = "";
            this.fld_lkeICProductAttributeID.BOSDataMember = "ICProductAttributeID";
            this.fld_lkeICProductAttributeID.BOSDataSource = "ICProductAttributes";
            this.fld_lkeICProductAttributeID.BOSDescription = null;
            this.fld_lkeICProductAttributeID.BOSError = "";
            this.fld_lkeICProductAttributeID.BOSFieldGroup = "";
            this.fld_lkeICProductAttributeID.BOSFieldParent = "";
            this.fld_lkeICProductAttributeID.BOSFieldRelation = "";
            this.fld_lkeICProductAttributeID.BOSPrivilege = "";
            this.fld_lkeICProductAttributeID.BOSPropertyName = "EditValue";
            this.fld_lkeICProductAttributeID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeICProductAttributeID.BOSSelectTypeValue = "PackingMaterialSpeciality";
            this.fld_lkeICProductAttributeID.CurrentDisplayText = null;
            this.fld_lkeICProductAttributeID.Location = new System.Drawing.Point(88, 75);
            this.fld_lkeICProductAttributeID.Name = "fld_lkeICProductAttributeID";
            this.fld_lkeICProductAttributeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICProductAttributeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICProductAttributeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductAttributeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICProductAttributeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductAttributeID.Properties.ColumnName = null;
            this.fld_lkeICProductAttributeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "Tên")});
            this.fld_lkeICProductAttributeID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeICProductAttributeID.Properties.NullText = "";
            this.fld_lkeICProductAttributeID.Properties.PopupWidth = 40;
            this.fld_lkeICProductAttributeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductAttributeID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeICProductAttributeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductAttributeID, true);
            this.fld_lkeICProductAttributeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICProductAttributeID.TabIndex = 3;
            this.fld_lkeICProductAttributeID.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(530, 78);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(42, 13);
            this.bosLabel2.TabIndex = 146;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Mã vạch";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseFont = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = "";
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = "";
            this.bosLabel5.BOSPrivilege = "";
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(18, 78);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(46, 13);
            this.bosLabel5.TabIndex = 142;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Quy cách";
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
            this.bosLabel3.Location = new System.Drawing.Point(18, 52);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 138;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Tên kiện";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = "";
            this.fld_lblLabel2.BOSDataMember = "";
            this.fld_lblLabel2.BOSDataSource = "";
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = "";
            this.fld_lblLabel2.BOSFieldRelation = "";
            this.fld_lblLabel2.BOSPrivilege = "";
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(18, 26);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(36, 13);
            this.fld_lblLabel2.TabIndex = 138;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Mã kiện";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = "";
            this.fld_lblLabel3.BOSDataMember = "";
            this.fld_lblLabel3.BOSDataSource = "";
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = "";
            this.fld_lblLabel3.BOSFieldRelation = "";
            this.fld_lblLabel3.BOSPrivilege = "";
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(270, 26);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(59, 13);
            this.fld_lblLabel3.TabIndex = 140;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Thành phẩm";
            // 
            // fld_txtBarcodeNo
            // 
            this.fld_txtBarcodeNo.BOSComment = "";
            this.fld_txtBarcodeNo.BOSDataMember = "";
            this.fld_txtBarcodeNo.BOSDataSource = "";
            this.fld_txtBarcodeNo.BOSDescription = null;
            this.fld_txtBarcodeNo.BOSError = "";
            this.fld_txtBarcodeNo.BOSFieldGroup = "";
            this.fld_txtBarcodeNo.BOSFieldRelation = "";
            this.fld_txtBarcodeNo.BOSPrivilege = "";
            this.fld_txtBarcodeNo.BOSPropertyName = "Text";
            this.fld_txtBarcodeNo.Location = new System.Drawing.Point(610, 75);
            this.fld_txtBarcodeNo.Name = "fld_txtBarcodeNo";
            this.fld_txtBarcodeNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtBarcodeNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtBarcodeNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtBarcodeNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtBarcodeNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtBarcodeNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtBarcodeNo.Screen = null;
            this.fld_txtBarcodeNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtBarcodeNo.TabIndex = 1;
            this.fld_txtBarcodeNo.Tag = "DC";
            // 
            // fld_txtPackageName
            // 
            this.fld_txtPackageName.BOSComment = "";
            this.fld_txtPackageName.BOSDataMember = "";
            this.fld_txtPackageName.BOSDataSource = "";
            this.fld_txtPackageName.BOSDescription = null;
            this.fld_txtPackageName.BOSError = "";
            this.fld_txtPackageName.BOSFieldGroup = "";
            this.fld_txtPackageName.BOSFieldRelation = "";
            this.fld_txtPackageName.BOSPrivilege = "";
            this.fld_txtPackageName.BOSPropertyName = "Text";
            this.fld_txtPackageName.Location = new System.Drawing.Point(88, 49);
            this.fld_txtPackageName.Name = "fld_txtPackageName";
            this.fld_txtPackageName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPackageName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPackageName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPackageName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPackageName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPackageName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPackageName.Screen = null;
            this.fld_txtPackageName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtPackageName.TabIndex = 0;
            this.fld_txtPackageName.Tag = "DC";
            // 
            // fld_txtPackageNo
            // 
            this.fld_txtPackageNo.BOSComment = "";
            this.fld_txtPackageNo.BOSDataMember = "";
            this.fld_txtPackageNo.BOSDataSource = "";
            this.fld_txtPackageNo.BOSDescription = null;
            this.fld_txtPackageNo.BOSError = "";
            this.fld_txtPackageNo.BOSFieldGroup = "";
            this.fld_txtPackageNo.BOSFieldRelation = "";
            this.fld_txtPackageNo.BOSPrivilege = "";
            this.fld_txtPackageNo.BOSPropertyName = "Text";
            this.fld_txtPackageNo.Location = new System.Drawing.Point(88, 23);
            this.fld_txtPackageNo.Name = "fld_txtPackageNo";
            this.fld_txtPackageNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPackageNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPackageNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPackageNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPackageNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPackageNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPackageNo.Screen = null;
            this.fld_txtPackageNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtPackageNo.TabIndex = 0;
            this.fld_txtPackageNo.Tag = "DC";
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseFont = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = "";
            this.fld_lblLabel11.BOSDataMember = "";
            this.fld_lblLabel11.BOSDataSource = "";
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = "";
            this.fld_lblLabel11.BOSFieldRelation = "";
            this.fld_lblLabel11.BOSPrivilege = "";
            this.fld_lblLabel11.BOSPropertyName = "";
            this.fld_lblLabel11.Location = new System.Drawing.Point(363, 414);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel11, true);
            this.fld_lblLabel11.Size = new System.Drawing.Size(0, 16);
            this.fld_lblLabel11.TabIndex = 334;
            this.fld_lblLabel11.Tag = "";
            // 
            // fld_ckeGetInfoFromBatch
            // 
            this.fld_ckeGetInfoFromBatch.BOSComment = null;
            this.fld_ckeGetInfoFromBatch.BOSDataMember = null;
            this.fld_ckeGetInfoFromBatch.BOSDataSource = null;
            this.fld_ckeGetInfoFromBatch.BOSDescription = null;
            this.fld_ckeGetInfoFromBatch.BOSError = null;
            this.fld_ckeGetInfoFromBatch.BOSFieldGroup = null;
            this.fld_ckeGetInfoFromBatch.BOSFieldRelation = null;
            this.fld_ckeGetInfoFromBatch.BOSPrivilege = null;
            this.fld_ckeGetInfoFromBatch.BOSPropertyName = null;
            this.fld_ckeGetInfoFromBatch.Location = new System.Drawing.Point(788, 24);
            this.fld_ckeGetInfoFromBatch.Name = "fld_ckeGetInfoFromBatch";
            this.fld_ckeGetInfoFromBatch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_ckeGetInfoFromBatch.Properties.Appearance.Options.UseFont = true;
            this.fld_ckeGetInfoFromBatch.Properties.Caption = "Thông tin lệnh SX";
            this.fld_ckeGetInfoFromBatch.Screen = null;
            this.fld_ckeGetInfoFromBatch.Size = new System.Drawing.Size(132, 19);
            this.fld_ckeGetInfoFromBatch.TabIndex = 172;
            this.fld_ckeGetInfoFromBatch.CheckedChanged += new System.EventHandler(this.fld_chkSelectAll_CheckedChanged);
            // 
            // DMPPE100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1054, 629);
            this.Controls.Add(this.bosPanel1);
            this.Controls.Add(this.fld_lblLabel11);
            this.Name = "DMPPE100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductWorkItem)).EndInit();
            this.fld_tabProductWorkItem.ResumeLayout(false);
            this.fld_tabProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).EndInit();
            this.fld_grcGroupControl5.ResumeLayout(false);
            this.fld_grcGroupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPackageSupplierNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPSupplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSerial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductAttributeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBarcodeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPackageName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPackageNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeGetInfoFromBatch.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private IContainer components;
        private BOSComponent.BOSTabControl fld_tabProductWorkItem;
        private DevExpress.XtraTab.XtraTabPage fld_tabProduct;
        private ICProductPackagesGridControl fld_dgcICProductPackages;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private BOSComponent.BOSGroupControl fld_grcGroupControl5;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTextBox fld_txtICPackageSupplierNo;
        private BOSComponent.BOSLookupEdit fld_lkeAPSupplierID;
        private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSTextBox fld_txtSerial;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeICProductID;
        private BOSComponent.BOSLookupEdit fld_lkeICProductAttributeID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSTextBox fld_txtBarcodeNo;
        private BOSComponent.BOSTextBox fld_txtPackageNo;
        private BOSComponent.BOSButton fld_btnFind;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeMMBatchProductID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtPackageName;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSButton fld_btnPrintQR;
        private BOSComponent.BOSCheckEdit fld_chkSelectAll;
        private BOSComponent.BOSCheckEdit fld_ckeGetInfoFromBatch;
    }
}
