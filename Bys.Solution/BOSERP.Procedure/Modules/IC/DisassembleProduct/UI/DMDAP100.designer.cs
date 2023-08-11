using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.DisassembleProduct.UI
{
	/// <summary>
	/// Summary description for DMDAP100
	/// </summary>
	partial class DMDAP100
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
            this.fld_lkeFK_ICProductSerieID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnShowInventoryProduct = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICDisassembleProductDetails = new BOSERP.Modules.DisassembleProduct.ICDisassembleProductDetailsGridControl();
            this.fld_dgvICShipmentItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICDisassembleProductQty = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICDisassembleProductName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeProduct = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_Lablel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICDisassembleProductStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICDisassembleProductDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICDisassembleProductNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_chkICDisassembleProductIsSpecificCalculation = new BOSComponent.BOSCheckEdit(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductSerieID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICDisassembleProductDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICDisassembleProductQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICDisassembleProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICDisassembleProductStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICDisassembleProductDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICDisassembleProductDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICDisassembleProductNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICDisassembleProductIsSpecificCalculation.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_chkICDisassembleProductIsSpecificCalculation);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductSerieID);
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_txtICDisassembleProductQty);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_txtICDisassembleProductName);
            this.bosPanel1.Controls.Add(this.bosLabel18);
            this.bosPanel1.Controls.Add(this.fld_lkeProduct);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICStockID);
            this.bosPanel1.Controls.Add(this.fld_Lablel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lkeICDisassembleProductStatus);
            this.bosPanel1.Controls.Add(this.fld_lblLabel25);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_dteICDisassembleProductDate);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtICDisassembleProductNo);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(829, 407);
            this.bosPanel1.TabIndex = 0;
            this.bosPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bosPanel1_Paint);
            // 
            // fld_lkeFK_ICProductSerieID
            // 
            this.fld_lkeFK_ICProductSerieID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductSerieID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductSerieID.BOSComment = null;
            this.fld_lkeFK_ICProductSerieID.BOSDataMember = "FK_ICProductSerieID";
            this.fld_lkeFK_ICProductSerieID.BOSDataSource = "ICDisassembleProducts";
            this.fld_lkeFK_ICProductSerieID.BOSDescription = null;
            this.fld_lkeFK_ICProductSerieID.BOSError = string.Empty;
            this.fld_lkeFK_ICProductSerieID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductSerieID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductSerieID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductSerieID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductSerieID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductSerieID.BOSSelectType = null;
            this.fld_lkeFK_ICProductSerieID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductSerieID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductSerieID.Location = new System.Drawing.Point(383, 64);
            this.fld_lkeFK_ICProductSerieID.Name = "fld_lkeFK_ICProductSerieID";
            this.fld_lkeFK_ICProductSerieID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductSerieID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductSerieID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductSerieID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductSerieID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductSerieID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductSerieNo", "Mã lô")});
            this.fld_lkeFK_ICProductSerieID.Properties.DisplayMember = "ICProductSerieNo";
            this.fld_lkeFK_ICProductSerieID.Properties.NullText = string.Empty;
            this.fld_lkeFK_ICProductSerieID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductSerieID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductSerieID.Properties.ValueMember = "ICProductSerieID";
            this.fld_lkeFK_ICProductSerieID.Screen = null;
            this.fld_lkeFK_ICProductSerieID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICProductSerieID.TabIndex = 6;
            this.fld_lkeFK_ICProductSerieID.Tag = "DC";
            this.fld_lkeFK_ICProductSerieID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICProductSerieID_CloseUp);
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
            this.bosGroupControl1.Controls.Add(this.fld_dgcICDisassembleProductDetails);
            this.bosGroupControl1.Controls.Add(this.bosButton1);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 115);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(823, 289);
            this.bosGroupControl1.TabIndex = 8;
            this.bosGroupControl1.Text = "Chi tiết rã bộ";
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
            this.fld_btnShowInventoryProduct.Location = new System.Drawing.Point(144, 25);
            this.fld_btnShowInventoryProduct.Name = "fld_btnShowInventoryProduct";
            this.fld_btnShowInventoryProduct.Screen = null;
            this.fld_btnShowInventoryProduct.Size = new System.Drawing.Size(156, 27);
            this.fld_btnShowInventoryProduct.TabIndex = 1;
            this.fld_btnShowInventoryProduct.Text = " Xem tồn kho thành phẩm";
            this.fld_btnShowInventoryProduct.Click += new System.EventHandler(this.fld_btnShowInventoryProduct_Click);
            // 
            // fld_dgcICDisassembleProductDetails
            // 
            this.fld_dgcICDisassembleProductDetails.AllowDrop = true;
            this.fld_dgcICDisassembleProductDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICDisassembleProductDetails.BOSComment = string.Empty;
            this.fld_dgcICDisassembleProductDetails.BOSDataMember = string.Empty;
            this.fld_dgcICDisassembleProductDetails.BOSDataSource = "ICDisassembleProductDetails";
            this.fld_dgcICDisassembleProductDetails.BOSDescription = null;
            this.fld_dgcICDisassembleProductDetails.BOSError = null;
            this.fld_dgcICDisassembleProductDetails.BOSFieldGroup = string.Empty;
            this.fld_dgcICDisassembleProductDetails.BOSFieldRelation = string.Empty;
            this.fld_dgcICDisassembleProductDetails.BOSGridType = null;
            this.fld_dgcICDisassembleProductDetails.BOSPrivilege = string.Empty;
            this.fld_dgcICDisassembleProductDetails.BOSPropertyName = null;
            this.fld_dgcICDisassembleProductDetails.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICDisassembleProductDetails.Location = new System.Drawing.Point(5, 58);
            this.fld_dgcICDisassembleProductDetails.MainView = this.fld_dgvICShipmentItems;
            this.fld_dgcICDisassembleProductDetails.Name = "fld_dgcICDisassembleProductDetails";
            this.fld_dgcICDisassembleProductDetails.PrintReport = false;
            this.fld_dgcICDisassembleProductDetails.Screen = null;
            this.fld_dgcICDisassembleProductDetails.Size = new System.Drawing.Size(813, 226);
            this.fld_dgcICDisassembleProductDetails.TabIndex = 2;
            this.fld_dgcICDisassembleProductDetails.Tag = "DC";
            this.fld_dgcICDisassembleProductDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICShipmentItems});
            // 
            // fld_dgvICShipmentItems
            // 
            this.fld_dgvICShipmentItems.GridControl = this.fld_dgcICDisassembleProductDetails;
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
            this.bosButton1.Size = new System.Drawing.Size(129, 27);
            this.bosButton1.TabIndex = 0;
            this.bosButton1.Text = "Load chi tiết rã bộ";
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
            this.bosLabel5.Location = new System.Drawing.Point(570, 67);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(42, 13);
            this.bosLabel5.TabIndex = 558;
            this.bosLabel5.Text = "Số lượng";
            // 
            // fld_txtICDisassembleProductQty
            // 
            this.fld_txtICDisassembleProductQty.BOSComment = string.Empty;
            this.fld_txtICDisassembleProductQty.BOSDataMember = "ICDisassembleProductQty";
            this.fld_txtICDisassembleProductQty.BOSDataSource = "ICDisassembleProducts";
            this.fld_txtICDisassembleProductQty.BOSDescription = null;
            this.fld_txtICDisassembleProductQty.BOSError = null;
            this.fld_txtICDisassembleProductQty.BOSFieldGroup = string.Empty;
            this.fld_txtICDisassembleProductQty.BOSFieldRelation = string.Empty;
            this.fld_txtICDisassembleProductQty.BOSPrivilege = string.Empty;
            this.fld_txtICDisassembleProductQty.BOSPropertyName = "Text";
            this.fld_txtICDisassembleProductQty.EditValue = string.Empty;
            this.fld_txtICDisassembleProductQty.Location = new System.Drawing.Point(651, 64);
            this.fld_txtICDisassembleProductQty.Name = "fld_txtICDisassembleProductQty";
            this.fld_txtICDisassembleProductQty.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICDisassembleProductQty.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICDisassembleProductQty.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICDisassembleProductQty.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICDisassembleProductQty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICDisassembleProductQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICDisassembleProductQty.Screen = null;
            this.fld_txtICDisassembleProductQty.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICDisassembleProductQty.TabIndex = 7;
            this.fld_txtICDisassembleProductQty.Tag = "DC";
            this.fld_txtICDisassembleProductQty.Validated += new System.EventHandler(this.fld_txtICDisassembleProductQty_Validated);
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
            this.bosLabel3.Location = new System.Drawing.Point(292, 41);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(27, 13);
            this.bosLabel3.TabIndex = 556;
            this.bosLabel3.Text = "Mô tả";
            // 
            // fld_txtICDisassembleProductName
            // 
            this.fld_txtICDisassembleProductName.BOSComment = string.Empty;
            this.fld_txtICDisassembleProductName.BOSDataMember = "ICDisassembleProductDesc";
            this.fld_txtICDisassembleProductName.BOSDataSource = "ICDisassembleProducts";
            this.fld_txtICDisassembleProductName.BOSDescription = null;
            this.fld_txtICDisassembleProductName.BOSError = null;
            this.fld_txtICDisassembleProductName.BOSFieldGroup = string.Empty;
            this.fld_txtICDisassembleProductName.BOSFieldRelation = string.Empty;
            this.fld_txtICDisassembleProductName.BOSPrivilege = string.Empty;
            this.fld_txtICDisassembleProductName.BOSPropertyName = "Text";
            this.fld_txtICDisassembleProductName.EditValue = string.Empty;
            this.fld_txtICDisassembleProductName.Location = new System.Drawing.Point(383, 38);
            this.fld_txtICDisassembleProductName.Name = "fld_txtICDisassembleProductName";
            this.fld_txtICDisassembleProductName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICDisassembleProductName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICDisassembleProductName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICDisassembleProductName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICDisassembleProductName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICDisassembleProductName.Properties.ReadOnly = true;
            this.fld_txtICDisassembleProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICDisassembleProductName.Screen = null;
            this.fld_txtICDisassembleProductName.Size = new System.Drawing.Size(418, 20);
            this.fld_txtICDisassembleProductName.TabIndex = 4;
            this.fld_txtICDisassembleProductName.Tag = "DC";
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
            this.bosLabel18.Location = new System.Drawing.Point(18, 41);
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
            this.fld_lkeProduct.BOSDataSource = "ICDisassembleProducts";
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
            this.fld_lkeProduct.Location = new System.Drawing.Point(114, 38);
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
            this.fld_lkeProduct.TabIndex = 3;
            this.fld_lkeProduct.Tag = "DC";
            this.fld_lkeProduct.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeProduct_CloseUp);
            // 
            // fld_lkeFK_ICStockID
            // 
            this.fld_lkeFK_ICStockID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICStockID.BOSAllowDummy = false;
            this.fld_lkeFK_ICStockID.BOSComment = null;
            this.fld_lkeFK_ICStockID.BOSDataMember = "FK_ICStockID";
            this.fld_lkeFK_ICStockID.BOSDataSource = "ICDisassembleProducts";
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
            this.fld_lkeFK_ICStockID.Location = new System.Drawing.Point(114, 64);
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
            this.fld_lkeFK_ICStockID.TabIndex = 5;
            this.fld_lkeFK_ICStockID.Tag = "DC";
            this.fld_lkeFK_ICStockID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICStockID_CloseUp);
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
            this.fld_Lablel3.Location = new System.Drawing.Point(18, 67);
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
            this.bosLabel2.Location = new System.Drawing.Point(292, 67);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(25, 13);
            this.bosLabel2.TabIndex = 20;
            this.bosLabel2.Text = "Mã lô";
            // 
            // fld_lkeICDisassembleProductStatus
            // 
            this.fld_lkeICDisassembleProductStatus.BOSAllowAddNew = false;
            this.fld_lkeICDisassembleProductStatus.BOSAllowDummy = false;
            this.fld_lkeICDisassembleProductStatus.BOSComment = null;
            this.fld_lkeICDisassembleProductStatus.BOSDataMember = "ICDisassembleProductStatus";
            this.fld_lkeICDisassembleProductStatus.BOSDataSource = "ICDisassembleProducts";
            this.fld_lkeICDisassembleProductStatus.BOSDescription = null;
            this.fld_lkeICDisassembleProductStatus.BOSError = null;
            this.fld_lkeICDisassembleProductStatus.BOSFieldGroup = null;
            this.fld_lkeICDisassembleProductStatus.BOSFieldParent = null;
            this.fld_lkeICDisassembleProductStatus.BOSFieldRelation = null;
            this.fld_lkeICDisassembleProductStatus.BOSPrivilege = null;
            this.fld_lkeICDisassembleProductStatus.BOSPropertyName = "EditValue";
            this.fld_lkeICDisassembleProductStatus.BOSSelectType = null;
            this.fld_lkeICDisassembleProductStatus.BOSSelectTypeValue = null;
            this.fld_lkeICDisassembleProductStatus.CurrentDisplayText = null;
            this.fld_lkeICDisassembleProductStatus.Location = new System.Drawing.Point(651, 12);
            this.fld_lkeICDisassembleProductStatus.MenuManager = this.screenToolbar;
            this.fld_lkeICDisassembleProductStatus.Name = "fld_lkeICDisassembleProductStatus";
            this.fld_lkeICDisassembleProductStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeICDisassembleProductStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICDisassembleProductStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICDisassembleProductStatus.Properties.NullText = string.Empty;
            this.fld_lkeICDisassembleProductStatus.Properties.ReadOnly = true;
            this.fld_lkeICDisassembleProductStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICDisassembleProductStatus.Screen = null;
            this.fld_lkeICDisassembleProductStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICDisassembleProductStatus.TabIndex = 2;
            this.fld_lkeICDisassembleProductStatus.Tag = "DC";
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
            // fld_dteICDisassembleProductDate
            // 
            this.fld_dteICDisassembleProductDate.BOSComment = null;
            this.fld_dteICDisassembleProductDate.BOSDataMember = "ICDisassembleProductDate";
            this.fld_dteICDisassembleProductDate.BOSDataSource = "ICDisassembleProducts";
            this.fld_dteICDisassembleProductDate.BOSDescription = null;
            this.fld_dteICDisassembleProductDate.BOSError = null;
            this.fld_dteICDisassembleProductDate.BOSFieldGroup = null;
            this.fld_dteICDisassembleProductDate.BOSFieldRelation = null;
            this.fld_dteICDisassembleProductDate.BOSPrivilege = null;
            this.fld_dteICDisassembleProductDate.BOSPropertyName = "EditValue";
            this.fld_dteICDisassembleProductDate.EditValue = null;
            this.fld_dteICDisassembleProductDate.Location = new System.Drawing.Point(383, 12);
            this.fld_dteICDisassembleProductDate.Name = "fld_dteICDisassembleProductDate";
            this.fld_dteICDisassembleProductDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICDisassembleProductDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICDisassembleProductDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICDisassembleProductDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICDisassembleProductDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICDisassembleProductDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICDisassembleProductDate.Screen = null;
            this.fld_dteICDisassembleProductDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICDisassembleProductDate.TabIndex = 1;
            this.fld_dteICDisassembleProductDate.Tag = "DC";
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
            // fld_txtICDisassembleProductNo
            // 
            this.fld_txtICDisassembleProductNo.BOSComment = string.Empty;
            this.fld_txtICDisassembleProductNo.BOSDataMember = "ICDisassembleProductNo";
            this.fld_txtICDisassembleProductNo.BOSDataSource = "ICDisassembleProducts";
            this.fld_txtICDisassembleProductNo.BOSDescription = null;
            this.fld_txtICDisassembleProductNo.BOSError = null;
            this.fld_txtICDisassembleProductNo.BOSFieldGroup = string.Empty;
            this.fld_txtICDisassembleProductNo.BOSFieldRelation = string.Empty;
            this.fld_txtICDisassembleProductNo.BOSPrivilege = string.Empty;
            this.fld_txtICDisassembleProductNo.BOSPropertyName = "Text";
            this.fld_txtICDisassembleProductNo.EditValue = string.Empty;
            this.fld_txtICDisassembleProductNo.Location = new System.Drawing.Point(114, 12);
            this.fld_txtICDisassembleProductNo.Name = "fld_txtICDisassembleProductNo";
            this.fld_txtICDisassembleProductNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICDisassembleProductNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICDisassembleProductNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICDisassembleProductNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICDisassembleProductNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICDisassembleProductNo.Properties.ReadOnly = true;
            this.fld_txtICDisassembleProductNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICDisassembleProductNo.Screen = null;
            this.fld_txtICDisassembleProductNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICDisassembleProductNo.TabIndex = 0;
            this.fld_txtICDisassembleProductNo.Tag = "DC";
            // 
            // fld_chkICDisassembleProductIsSpecificCalculation
            // 
            this.fld_chkICDisassembleProductIsSpecificCalculation.BOSComment = null;
            this.fld_chkICDisassembleProductIsSpecificCalculation.BOSDataMember = "ICDisassembleProductIsSpecificCalculation";
            this.fld_chkICDisassembleProductIsSpecificCalculation.BOSDataSource = "ICDisassembleProducts";
            this.fld_chkICDisassembleProductIsSpecificCalculation.BOSDescription = null;
            this.fld_chkICDisassembleProductIsSpecificCalculation.BOSError = null;
            this.fld_chkICDisassembleProductIsSpecificCalculation.BOSFieldGroup = null;
            this.fld_chkICDisassembleProductIsSpecificCalculation.BOSFieldRelation = null;
            this.fld_chkICDisassembleProductIsSpecificCalculation.BOSPrivilege = null;
            this.fld_chkICDisassembleProductIsSpecificCalculation.BOSPropertyName = "EditValue";
            this.fld_chkICDisassembleProductIsSpecificCalculation.Location = new System.Drawing.Point(112, 90);
            this.fld_chkICDisassembleProductIsSpecificCalculation.MenuManager = this.screenToolbar;
            this.fld_chkICDisassembleProductIsSpecificCalculation.Name = "fld_chkICDisassembleProductIsSpecificCalculation";
            this.fld_chkICDisassembleProductIsSpecificCalculation.Properties.Caption = "Áp giá đích danh";
            this.fld_chkICDisassembleProductIsSpecificCalculation.Screen = null;
            this.fld_chkICDisassembleProductIsSpecificCalculation.Size = new System.Drawing.Size(152, 19);
            this.fld_chkICDisassembleProductIsSpecificCalculation.TabIndex = 559;
            this.fld_chkICDisassembleProductIsSpecificCalculation.Tag = "DC";
            // 
            // DMDAP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(829, 407);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMDAP100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductSerieID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICDisassembleProductDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICDisassembleProductQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICDisassembleProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICDisassembleProductStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICDisassembleProductDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICDisassembleProductDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICDisassembleProductNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICDisassembleProductIsSpecificCalculation.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtICDisassembleProductNo;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dteICDisassembleProductDate;
        private BOSComponent.BOSLookupEdit fld_lkeICDisassembleProductStatus;
        private BOSComponent.BOSLabel fld_lblLabel25;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID;
        private BOSComponent.BOSLabel fld_Lablel3;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLookupEdit fld_lkeProduct;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtICDisassembleProductName;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtICDisassembleProductQty;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSButton bosButton1;
        private ICDisassembleProductDetailsGridControl fld_dgcICDisassembleProductDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICShipmentItems;
        private BOSComponent.BOSButton fld_btnShowInventoryProduct;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductSerieID;
        private BOSComponent.BOSCheckEdit fld_chkICDisassembleProductIsSpecificCalculation;
	}
}
