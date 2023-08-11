using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AssembleProduct.UI
{
	/// <summary>
	/// Summary description for DMAP100
	/// </summary>
	partial class DMAP100
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
            this.fld_chkICAssembleProductIsAverageCalculation = new BOSComponent.BOSCheckEdit(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnShowInventoryProduct = new BOSComponent.BOSButton(this.components);
            this.fld_btnRefreshInventory = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICAssembleProductDetails = new BOSERP.Modules.AssembleProduct.ICAssembleProductDetailsGridControl();
            this.fld_dgvICShipmentItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICAssembleProductQty = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICAssembleProductName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeProduct = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_Lablel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICAssembleProductLotNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeICAssembleProductStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICAssembleProductDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICAssembleProductNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICAssembleProductIsAverageCalculation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICAssembleProductDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAssembleProductQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAssembleProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAssembleProductLotNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICAssembleProductStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICAssembleProductDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICAssembleProductDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAssembleProductNo.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_chkICAssembleProductIsAverageCalculation);
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_txtICAssembleProductQty);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_txtICAssembleProductName);
            this.bosPanel1.Controls.Add(this.bosLabel18);
            this.bosPanel1.Controls.Add(this.fld_lkeProduct);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICStockID);
            this.bosPanel1.Controls.Add(this.fld_Lablel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_txtICAssembleProductLotNo);
            this.bosPanel1.Controls.Add(this.fld_lkeICAssembleProductStatus);
            this.bosPanel1.Controls.Add(this.fld_lblLabel25);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_dteICAssembleProductDate);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtICAssembleProductNo);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(829, 407);
            this.bosPanel1.TabIndex = 0;
            this.bosPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bosPanel1_Paint);
            // 
            // fld_chkICAssembleProductIsAverageCalculation
            // 
            this.fld_chkICAssembleProductIsAverageCalculation.BOSComment = null;
            this.fld_chkICAssembleProductIsAverageCalculation.BOSDataMember = "ICAssembleProductIsAverageCalculation";
            this.fld_chkICAssembleProductIsAverageCalculation.BOSDataSource = "ICAssembleProducts";
            this.fld_chkICAssembleProductIsAverageCalculation.BOSDescription = null;
            this.fld_chkICAssembleProductIsAverageCalculation.BOSError = null;
            this.fld_chkICAssembleProductIsAverageCalculation.BOSFieldGroup = null;
            this.fld_chkICAssembleProductIsAverageCalculation.BOSFieldRelation = null;
            this.fld_chkICAssembleProductIsAverageCalculation.BOSPrivilege = null;
            this.fld_chkICAssembleProductIsAverageCalculation.BOSPropertyName = "EditValue";
            this.fld_chkICAssembleProductIsAverageCalculation.Location = new System.Drawing.Point(112, 90);
            this.fld_chkICAssembleProductIsAverageCalculation.MenuManager = this.screenToolbar;
            this.fld_chkICAssembleProductIsAverageCalculation.Name = "fld_chkICAssembleProductIsAverageCalculation";
            this.fld_chkICAssembleProductIsAverageCalculation.Properties.Caption = "Áp giá trung bình";
            this.fld_chkICAssembleProductIsAverageCalculation.Screen = null;
            this.fld_chkICAssembleProductIsAverageCalculation.Size = new System.Drawing.Size(152, 19);
            this.fld_chkICAssembleProductIsAverageCalculation.TabIndex = 8;
            this.fld_chkICAssembleProductIsAverageCalculation.Tag = "DC";
            this.fld_chkICAssembleProductIsAverageCalculation.CheckedChanged += new System.EventHandler(this.fld_chkICAssembleProductIsAverageCalculation_CheckedChanged);
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_btnShowInventoryProduct);
            this.bosGroupControl1.Controls.Add(this.fld_btnRefreshInventory);
            this.bosGroupControl1.Controls.Add(this.fld_dgcICAssembleProductDetails);
            this.bosGroupControl1.Controls.Add(this.bosButton1);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 115);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(823, 289);
            this.bosGroupControl1.TabIndex = 8;
            this.bosGroupControl1.Text = "Chi tiết ráp bộ";
            // 
            // fld_btnShowInventoryProduct
            // 
            this.fld_btnShowInventoryProduct.BOSComment = null;
            this.fld_btnShowInventoryProduct.BOSDataMember = null;
            this.fld_btnShowInventoryProduct.BOSDataSource = null;
            this.fld_btnShowInventoryProduct.BOSDescription = null;
            this.fld_btnShowInventoryProduct.BOSError = null;
            this.fld_btnShowInventoryProduct.BOSFieldGroup = null;
            this.fld_btnShowInventoryProduct.BOSFieldRelation = null;
            this.fld_btnShowInventoryProduct.BOSPrivilege = null;
            this.fld_btnShowInventoryProduct.BOSPropertyName = null;
            this.fld_btnShowInventoryProduct.Image = global::BOSERP.Procedure.Properties.Resources.boxes_brown_icon;
            this.fld_btnShowInventoryProduct.Location = new System.Drawing.Point(282, 25);
            this.fld_btnShowInventoryProduct.Name = "fld_btnShowInventoryProduct";
            this.fld_btnShowInventoryProduct.Screen = null;
            this.fld_btnShowInventoryProduct.Size = new System.Drawing.Size(181, 27);
            this.fld_btnShowInventoryProduct.TabIndex = 2;
            this.fld_btnShowInventoryProduct.Text = " Xem tồn kho thành phẩm ráp";
            this.fld_btnShowInventoryProduct.Click += new System.EventHandler(this.fld_btnShowInventoryProduct_Click);
            // 
            // fld_btnRefreshInventory
            // 
            this.fld_btnRefreshInventory.BOSComment = null;
            this.fld_btnRefreshInventory.BOSDataMember = null;
            this.fld_btnRefreshInventory.BOSDataSource = null;
            this.fld_btnRefreshInventory.BOSDescription = null;
            this.fld_btnRefreshInventory.BOSError = null;
            this.fld_btnRefreshInventory.BOSFieldGroup = null;
            this.fld_btnRefreshInventory.BOSFieldRelation = null;
            this.fld_btnRefreshInventory.BOSPrivilege = null;
            this.fld_btnRefreshInventory.BOSPropertyName = null;
            this.fld_btnRefreshInventory.Image = global::BOSERP.Procedure.Properties.Resources.table_refresh_icon;
            this.fld_btnRefreshInventory.Location = new System.Drawing.Point(129, 25);
            this.fld_btnRefreshInventory.Name = "fld_btnRefreshInventory";
            this.fld_btnRefreshInventory.Screen = null;
            this.fld_btnRefreshInventory.Size = new System.Drawing.Size(147, 27);
            this.fld_btnRefreshInventory.TabIndex = 1;
            this.fld_btnRefreshInventory.Text = "Xem tồn kho thời điểm";
            this.fld_btnRefreshInventory.Click += new System.EventHandler(this.fld_btnRefreshInventory_Click);
            // 
            // fld_dgcICAssembleProductDetails
            // 
            this.fld_dgcICAssembleProductDetails.AllowDrop = true;
            this.fld_dgcICAssembleProductDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICAssembleProductDetails.BOSComment = string.Empty;
            this.fld_dgcICAssembleProductDetails.BOSDataMember = string.Empty;
            this.fld_dgcICAssembleProductDetails.BOSDataSource = "ICAssembleProductDetails";
            this.fld_dgcICAssembleProductDetails.BOSDescription = null;
            this.fld_dgcICAssembleProductDetails.BOSError = null;
            this.fld_dgcICAssembleProductDetails.BOSFieldGroup = string.Empty;
            this.fld_dgcICAssembleProductDetails.BOSFieldRelation = string.Empty;
            this.fld_dgcICAssembleProductDetails.BOSGridType = null;
            this.fld_dgcICAssembleProductDetails.BOSPrivilege = string.Empty;
            this.fld_dgcICAssembleProductDetails.BOSPropertyName = null;
            this.fld_dgcICAssembleProductDetails.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICAssembleProductDetails.Location = new System.Drawing.Point(5, 58);
            this.fld_dgcICAssembleProductDetails.MainView = this.fld_dgvICShipmentItems;
            this.fld_dgcICAssembleProductDetails.Name = "fld_dgcICAssembleProductDetails";
            this.fld_dgcICAssembleProductDetails.PrintReport = false;
            this.fld_dgcICAssembleProductDetails.Screen = null;
            this.fld_dgcICAssembleProductDetails.Size = new System.Drawing.Size(813, 226);
            this.fld_dgcICAssembleProductDetails.TabIndex = 3;
            this.fld_dgcICAssembleProductDetails.Tag = "DC";
            this.fld_dgcICAssembleProductDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICShipmentItems});
            // 
            // fld_dgvICShipmentItems
            // 
            this.fld_dgvICShipmentItems.GridControl = this.fld_dgcICAssembleProductDetails;
            this.fld_dgvICShipmentItems.Name = "fld_dgvICShipmentItems";
            this.fld_dgvICShipmentItems.PaintStyleName = "Office2003";
            // 
            // bosButton1
            // 
            this.bosButton1.BOSComment = null;
            this.bosButton1.BOSDataMember = null;
            this.bosButton1.BOSDataSource = null;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = null;
            this.bosButton1.BOSFieldRelation = null;
            this.bosButton1.BOSPrivilege = null;
            this.bosButton1.BOSPropertyName = null;
            this.bosButton1.Image = global::BOSERP.Procedure.Properties.Resources.table_add_icon;
            this.bosButton1.Location = new System.Drawing.Point(9, 25);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(114, 27);
            this.bosButton1.TabIndex = 0;
            this.bosButton1.Text = "Thêm chi tiết";
            this.bosButton1.Click += new System.EventHandler(this.bosButton1_Click);
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(570, 41);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(42, 13);
            this.bosLabel5.TabIndex = 558;
            this.bosLabel5.Text = "Số lượng";
            // 
            // fld_txtICAssembleProductQty
            // 
            this.fld_txtICAssembleProductQty.BOSComment = string.Empty;
            this.fld_txtICAssembleProductQty.BOSDataMember = "ICAssembleProductQty";
            this.fld_txtICAssembleProductQty.BOSDataSource = "ICAssembleProducts";
            this.fld_txtICAssembleProductQty.BOSDescription = null;
            this.fld_txtICAssembleProductQty.BOSError = null;
            this.fld_txtICAssembleProductQty.BOSFieldGroup = string.Empty;
            this.fld_txtICAssembleProductQty.BOSFieldRelation = string.Empty;
            this.fld_txtICAssembleProductQty.BOSPrivilege = string.Empty;
            this.fld_txtICAssembleProductQty.BOSPropertyName = "Text";
            this.fld_txtICAssembleProductQty.EditValue = string.Empty;
            this.fld_txtICAssembleProductQty.Location = new System.Drawing.Point(651, 38);
            this.fld_txtICAssembleProductQty.Name = "fld_txtICAssembleProductQty";
            this.fld_txtICAssembleProductQty.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICAssembleProductQty.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICAssembleProductQty.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICAssembleProductQty.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICAssembleProductQty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICAssembleProductQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICAssembleProductQty.Screen = null;
            this.fld_txtICAssembleProductQty.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICAssembleProductQty.TabIndex = 5;
            this.fld_txtICAssembleProductQty.Tag = "DC";
            this.fld_txtICAssembleProductQty.Validated += new System.EventHandler(this.fld_txtICAssembleProductQty_Validated);
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(292, 67);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(27, 13);
            this.bosLabel3.TabIndex = 556;
            this.bosLabel3.Text = "Mô tả";
            // 
            // fld_txtICAssembleProductName
            // 
            this.fld_txtICAssembleProductName.BOSComment = string.Empty;
            this.fld_txtICAssembleProductName.BOSDataMember = "ICAssembleProductDesc";
            this.fld_txtICAssembleProductName.BOSDataSource = "ICAssembleProducts";
            this.fld_txtICAssembleProductName.BOSDescription = null;
            this.fld_txtICAssembleProductName.BOSError = null;
            this.fld_txtICAssembleProductName.BOSFieldGroup = string.Empty;
            this.fld_txtICAssembleProductName.BOSFieldRelation = string.Empty;
            this.fld_txtICAssembleProductName.BOSPrivilege = string.Empty;
            this.fld_txtICAssembleProductName.BOSPropertyName = "Text";
            this.fld_txtICAssembleProductName.EditValue = string.Empty;
            this.fld_txtICAssembleProductName.Location = new System.Drawing.Point(383, 64);
            this.fld_txtICAssembleProductName.Name = "fld_txtICAssembleProductName";
            this.fld_txtICAssembleProductName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICAssembleProductName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICAssembleProductName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICAssembleProductName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICAssembleProductName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICAssembleProductName.Properties.ReadOnly = true;
            this.fld_txtICAssembleProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICAssembleProductName.Screen = null;
            this.fld_txtICAssembleProductName.Size = new System.Drawing.Size(418, 20);
            this.fld_txtICAssembleProductName.TabIndex = 7;
            this.fld_txtICAssembleProductName.Tag = "DC";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = string.Empty;
            this.bosLabel18.BOSDataMember = string.Empty;
            this.bosLabel18.BOSDataSource = string.Empty;
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = string.Empty;
            this.bosLabel18.BOSFieldRelation = string.Empty;
            this.bosLabel18.BOSPrivilege = string.Empty;
            this.bosLabel18.BOSPropertyName = string.Empty;
            this.bosLabel18.Location = new System.Drawing.Point(18, 67);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(59, 13);
            this.bosLabel18.TabIndex = 554;
            this.bosLabel18.Tag = string.Empty;
            this.bosLabel18.Text = "Thành phẩm";
            // 
            // fld_lkeProduct
            // 
            this.fld_lkeProduct.BOSAllowAddNew = false;
            this.fld_lkeProduct.BOSAllowDummy = false;
            this.fld_lkeProduct.BOSComment = string.Empty;
            this.fld_lkeProduct.BOSDataMember = "FK_ICProductID";
            this.fld_lkeProduct.BOSDataSource = "ICAssembleProducts";
            this.fld_lkeProduct.BOSDescription = null;
            this.fld_lkeProduct.BOSError = null;
            this.fld_lkeProduct.BOSFieldGroup = string.Empty;
            this.fld_lkeProduct.BOSFieldParent = string.Empty;
            this.fld_lkeProduct.BOSFieldRelation = string.Empty;
            this.fld_lkeProduct.BOSPrivilege = string.Empty;
            this.fld_lkeProduct.BOSPropertyName = "EditValue";
            this.fld_lkeProduct.BOSSelectType = string.Empty;
            this.fld_lkeProduct.BOSSelectTypeValue = string.Empty;
            this.fld_lkeProduct.CurrentDisplayText = null;
            this.fld_lkeProduct.Location = new System.Drawing.Point(114, 64);
            this.fld_lkeProduct.Name = "fld_lkeProduct";
            this.fld_lkeProduct.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeProduct.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeProduct.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeProduct.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeProduct.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeProduct.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeProduct.Properties.NullText = string.Empty;
            this.fld_lkeProduct.Properties.PopupWidth = 40;
            this.fld_lkeProduct.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeProduct.Properties.ValueMember = "ICProductID";
            this.fld_lkeProduct.Screen = null;
            this.fld_lkeProduct.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeProduct.TabIndex = 6;
            this.fld_lkeProduct.Tag = "DC";
            this.fld_lkeProduct.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeProduct_CloseUp);
            // 
            // fld_lkeFK_ICStockID
            // 
            this.fld_lkeFK_ICStockID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICStockID.BOSAllowDummy = false;
            this.fld_lkeFK_ICStockID.BOSComment = null;
            this.fld_lkeFK_ICStockID.BOSDataMember = "FK_ICStockID";
            this.fld_lkeFK_ICStockID.BOSDataSource = "ICAssembleProducts";
            this.fld_lkeFK_ICStockID.BOSDescription = null;
            this.fld_lkeFK_ICStockID.BOSError = string.Empty;
            this.fld_lkeFK_ICStockID.BOSFieldGroup = null;
            this.fld_lkeFK_ICStockID.BOSFieldParent = null;
            this.fld_lkeFK_ICStockID.BOSFieldRelation = null;
            this.fld_lkeFK_ICStockID.BOSPrivilege = null;
            this.fld_lkeFK_ICStockID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICStockID.BOSSelectType = null;
            this.fld_lkeFK_ICStockID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICStockID.CurrentDisplayText = null;
            this.fld_lkeFK_ICStockID.Location = new System.Drawing.Point(383, 38);
            this.fld_lkeFK_ICStockID.Name = "fld_lkeFK_ICStockID";
            this.fld_lkeFK_ICStockID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICStockID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICStockID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICStockID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICStockID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "No", 20, DevExpress.Utils.FormatType.Numeric, string.Empty, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Name")});
            this.fld_lkeFK_ICStockID.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICStockID.Properties.NullText = string.Empty;
            this.fld_lkeFK_ICStockID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICStockID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICStockID.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICStockID.Screen = null;
            this.fld_lkeFK_ICStockID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICStockID.TabIndex = 4;
            this.fld_lkeFK_ICStockID.Tag = "DC";
            // 
            // fld_Lablel3
            // 
            this.fld_Lablel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel3.Appearance.Options.UseBackColor = true;
            this.fld_Lablel3.Appearance.Options.UseForeColor = true;
            this.fld_Lablel3.BOSComment = null;
            this.fld_Lablel3.BOSDataMember = string.Empty;
            this.fld_Lablel3.BOSDataSource = string.Empty;
            this.fld_Lablel3.BOSDescription = null;
            this.fld_Lablel3.BOSError = null;
            this.fld_Lablel3.BOSFieldGroup = string.Empty;
            this.fld_Lablel3.BOSFieldRelation = null;
            this.fld_Lablel3.BOSPrivilege = null;
            this.fld_Lablel3.BOSPropertyName = null;
            this.fld_Lablel3.Location = new System.Drawing.Point(292, 41);
            this.fld_Lablel3.Name = "fld_Lablel3";
            this.fld_Lablel3.Screen = null;
            this.fld_Lablel3.Size = new System.Drawing.Size(18, 13);
            this.fld_Lablel3.TabIndex = 524;
            this.fld_Lablel3.Text = "Kho";
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(18, 41);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(25, 13);
            this.bosLabel2.TabIndex = 20;
            this.bosLabel2.Text = "Mã lô";
            // 
            // fld_txtICAssembleProductLotNo
            // 
            this.fld_txtICAssembleProductLotNo.BOSComment = string.Empty;
            this.fld_txtICAssembleProductLotNo.BOSDataMember = "ICAssembleProductLotNo";
            this.fld_txtICAssembleProductLotNo.BOSDataSource = "ICAssembleProducts";
            this.fld_txtICAssembleProductLotNo.BOSDescription = null;
            this.fld_txtICAssembleProductLotNo.BOSError = null;
            this.fld_txtICAssembleProductLotNo.BOSFieldGroup = string.Empty;
            this.fld_txtICAssembleProductLotNo.BOSFieldRelation = string.Empty;
            this.fld_txtICAssembleProductLotNo.BOSPrivilege = string.Empty;
            this.fld_txtICAssembleProductLotNo.BOSPropertyName = "Text";
            this.fld_txtICAssembleProductLotNo.EditValue = string.Empty;
            this.fld_txtICAssembleProductLotNo.Location = new System.Drawing.Point(114, 38);
            this.fld_txtICAssembleProductLotNo.Name = "fld_txtICAssembleProductLotNo";
            this.fld_txtICAssembleProductLotNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICAssembleProductLotNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICAssembleProductLotNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICAssembleProductLotNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICAssembleProductLotNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICAssembleProductLotNo.Properties.ReadOnly = true;
            this.fld_txtICAssembleProductLotNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICAssembleProductLotNo.Screen = null;
            this.fld_txtICAssembleProductLotNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICAssembleProductLotNo.TabIndex = 3;
            this.fld_txtICAssembleProductLotNo.Tag = "DC";
            // 
            // fld_lkeICAssembleProductStatus
            // 
            this.fld_lkeICAssembleProductStatus.BOSAllowAddNew = false;
            this.fld_lkeICAssembleProductStatus.BOSAllowDummy = false;
            this.fld_lkeICAssembleProductStatus.BOSComment = null;
            this.fld_lkeICAssembleProductStatus.BOSDataMember = "ICAssembleProductStatus";
            this.fld_lkeICAssembleProductStatus.BOSDataSource = "ICAssembleProducts";
            this.fld_lkeICAssembleProductStatus.BOSDescription = null;
            this.fld_lkeICAssembleProductStatus.BOSError = null;
            this.fld_lkeICAssembleProductStatus.BOSFieldGroup = null;
            this.fld_lkeICAssembleProductStatus.BOSFieldParent = null;
            this.fld_lkeICAssembleProductStatus.BOSFieldRelation = null;
            this.fld_lkeICAssembleProductStatus.BOSPrivilege = null;
            this.fld_lkeICAssembleProductStatus.BOSPropertyName = "EditValue";
            this.fld_lkeICAssembleProductStatus.BOSSelectType = null;
            this.fld_lkeICAssembleProductStatus.BOSSelectTypeValue = null;
            this.fld_lkeICAssembleProductStatus.CurrentDisplayText = null;
            this.fld_lkeICAssembleProductStatus.Location = new System.Drawing.Point(651, 12);
            this.fld_lkeICAssembleProductStatus.MenuManager = this.screenToolbar;
            this.fld_lkeICAssembleProductStatus.Name = "fld_lkeICAssembleProductStatus";
            this.fld_lkeICAssembleProductStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeICAssembleProductStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICAssembleProductStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICAssembleProductStatus.Properties.NullText = string.Empty;
            this.fld_lkeICAssembleProductStatus.Properties.ReadOnly = true;
            this.fld_lkeICAssembleProductStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICAssembleProductStatus.Screen = null;
            this.fld_lkeICAssembleProductStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICAssembleProductStatus.TabIndex = 2;
            this.fld_lkeICAssembleProductStatus.Tag = "DC";
            // 
            // fld_lblLabel25
            // 
            this.fld_lblLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel25.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel25.BOSComment = null;
            this.fld_lblLabel25.BOSDataMember = null;
            this.fld_lblLabel25.BOSDataSource = null;
            this.fld_lblLabel25.BOSDescription = null;
            this.fld_lblLabel25.BOSError = null;
            this.fld_lblLabel25.BOSFieldGroup = null;
            this.fld_lblLabel25.BOSFieldRelation = null;
            this.fld_lblLabel25.BOSPrivilege = null;
            this.fld_lblLabel25.BOSPropertyName = null;
            this.fld_lblLabel25.Location = new System.Drawing.Point(570, 15);
            this.fld_lblLabel25.Name = "fld_lblLabel25";
            this.fld_lblLabel25.Screen = null;
            this.fld_lblLabel25.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel25.TabIndex = 17;
            this.fld_lblLabel25.Text = "Trạng thái";
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(292, 15);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(72, 13);
            this.bosLabel4.TabIndex = 15;
            this.bosLabel4.Text = "Ngày chứng từ";
            // 
            // fld_dteICAssembleProductDate
            // 
            this.fld_dteICAssembleProductDate.BOSComment = null;
            this.fld_dteICAssembleProductDate.BOSDataMember = "ICAssembleProductDate";
            this.fld_dteICAssembleProductDate.BOSDataSource = "ICAssembleProducts";
            this.fld_dteICAssembleProductDate.BOSDescription = null;
            this.fld_dteICAssembleProductDate.BOSError = null;
            this.fld_dteICAssembleProductDate.BOSFieldGroup = null;
            this.fld_dteICAssembleProductDate.BOSFieldRelation = null;
            this.fld_dteICAssembleProductDate.BOSPrivilege = null;
            this.fld_dteICAssembleProductDate.BOSPropertyName = "EditValue";
            this.fld_dteICAssembleProductDate.EditValue = null;
            this.fld_dteICAssembleProductDate.Location = new System.Drawing.Point(383, 12);
            this.fld_dteICAssembleProductDate.Name = "fld_dteICAssembleProductDate";
            this.fld_dteICAssembleProductDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICAssembleProductDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICAssembleProductDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICAssembleProductDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICAssembleProductDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICAssembleProductDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICAssembleProductDate.Screen = null;
            this.fld_dteICAssembleProductDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICAssembleProductDate.TabIndex = 1;
            this.fld_dteICAssembleProductDate.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(18, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 9;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // fld_txtICAssembleProductNo
            // 
            this.fld_txtICAssembleProductNo.BOSComment = string.Empty;
            this.fld_txtICAssembleProductNo.BOSDataMember = "ICAssembleProductNo";
            this.fld_txtICAssembleProductNo.BOSDataSource = "ICAssembleProducts";
            this.fld_txtICAssembleProductNo.BOSDescription = null;
            this.fld_txtICAssembleProductNo.BOSError = null;
            this.fld_txtICAssembleProductNo.BOSFieldGroup = string.Empty;
            this.fld_txtICAssembleProductNo.BOSFieldRelation = string.Empty;
            this.fld_txtICAssembleProductNo.BOSPrivilege = string.Empty;
            this.fld_txtICAssembleProductNo.BOSPropertyName = "Text";
            this.fld_txtICAssembleProductNo.EditValue = string.Empty;
            this.fld_txtICAssembleProductNo.Location = new System.Drawing.Point(114, 12);
            this.fld_txtICAssembleProductNo.Name = "fld_txtICAssembleProductNo";
            this.fld_txtICAssembleProductNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICAssembleProductNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICAssembleProductNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICAssembleProductNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICAssembleProductNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICAssembleProductNo.Properties.ReadOnly = true;
            this.fld_txtICAssembleProductNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICAssembleProductNo.Screen = null;
            this.fld_txtICAssembleProductNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICAssembleProductNo.TabIndex = 0;
            this.fld_txtICAssembleProductNo.Tag = "DC";
            // 
            // DMAP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(829, 407);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMAP100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICAssembleProductIsAverageCalculation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICAssembleProductDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAssembleProductQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAssembleProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAssembleProductLotNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICAssembleProductStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICAssembleProductDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICAssembleProductDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAssembleProductNo.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtICAssembleProductNo;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dteICAssembleProductDate;
        private BOSComponent.BOSLookupEdit fld_lkeICAssembleProductStatus;
        private BOSComponent.BOSLabel fld_lblLabel25;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtICAssembleProductLotNo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID;
        private BOSComponent.BOSLabel fld_Lablel3;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLookupEdit fld_lkeProduct;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtICAssembleProductName;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtICAssembleProductQty;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSButton bosButton1;
        private ICAssembleProductDetailsGridControl fld_dgcICAssembleProductDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICShipmentItems;
        private BOSComponent.BOSButton fld_btnRefreshInventory;
        private BOSComponent.BOSButton fld_btnShowInventoryProduct;
        private BOSComponent.BOSCheckEdit fld_chkICAssembleProductIsAverageCalculation;
	}
}
