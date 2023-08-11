using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.LayBy.UI
{
	/// <summary>
	/// Summary description for DMPS100
	/// </summary>
	partial class DMPS100
	{
		private BOSComponent.BOSGroupControl fld_grcGroupControl1;
		private BOSComponent.BOSLabel fld_lblLabel4;
        private ItemLookupEdit fld_lkeFK_ICProductAttributeID;
		private ARLayByItemsGridControl fld_dgcARLayByItems;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARLayByItems;
		private BOSComponent.BOSLabel fld_lblLabel14;
		private BOSComponent.BOSLabel fld_lblLabel15;
		private BOSComponent.BOSLabel fld_lblLabel19;
		private BOSComponent.BOSLabel fld_lblLabel20;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARPriceLevelID;
        private BOSComponent.BOSPictureEdit fld_pteARSaleOrderEmployeePicture;
		private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSPictureEdit fld_pteARSaleOrderItemProductPicture;
		private BOSComponent.BOSTextBox fld_txtARSaleOrderSubTotalAmount;
		private BOSComponent.BOSTextBox fld_txtARSaleOrderTotalAmount;
		private BOSComponent.BOSTextBox fld_txtARSaleOrderDepositBalance;
		private BOSComponent.BOSTextBox fld_txtARSaleOrderBalanceDue;
		private BOSComponent.BOSTextBox fld_txtARSaleOrderDiscountFix;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel7;
		private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
		private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSDateEdit fld_dteARSaleOrderDeliveryDate;
		private BOSComponent.BOSLabel fld_lblLabel12;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderStatus;
		private BOSComponent.BOSLabel fld_lblLabel16;
		private BOSComponent.BOSTextBox fld_txtARSaleOrderDiscountPerCent;
        private BOSComponent.BOSLabel fld_lblLabel17;


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
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductAttributeID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_dgcARLayByItems = new BOSERP.Modules.LayBy.ARLayByItemsGridControl();
            this.fld_dgvARLayByItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_pteARSaleOrderItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARPriceLevelID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteARSaleOrderEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderSubTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleOrderTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleOrderDepositBalance = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleOrderBalanceDue = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARSaleOrderDiscountFix = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARSaleOrderDeliveryDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderStatus = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderDiscountPerCent = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARSaleOrderDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medARSaleOrderDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARLayByItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARLayByItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARPriceLevelID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSubTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderDepositBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderBalanceDue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderDiscountPerCent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARSaleOrderDesc.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.BOSComment = "";
            this.fld_grcGroupControl1.BOSDataMember = null;
            this.fld_grcGroupControl1.BOSDataSource = null;
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = "";
            this.fld_grcGroupControl1.BOSFieldRelation = null;
            this.fld_grcGroupControl1.BOSPrivilege = "";
            this.fld_grcGroupControl1.BOSPropertyName = null;
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_ICProductAttributeID);
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcARLayByItems);
            this.fld_grcGroupControl1.Controls.Add(this.fld_pteARSaleOrderItemProductPicture);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(3, 129);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(1100, 325);
            this.fld_grcGroupControl1.TabIndex = 4;
            this.fld_grcGroupControl1.Text = "Danh sách sản phẩm";
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
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(9, 28);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel4.TabIndex = 387;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Sản phẩm";
            // 
            // fld_lkeFK_ICProductAttributeID
            // 
            this.fld_lkeFK_ICProductAttributeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeID.BOSComment = "";
            this.fld_lkeFK_ICProductAttributeID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductAttributeID.BOSDataSource = "ARSaleOrderItems";
            this.fld_lkeFK_ICProductAttributeID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeID.BOSError = "";
            this.fld_lkeFK_ICProductAttributeID.BOSFieldGroup = "";
            this.fld_lkeFK_ICProductAttributeID.BOSFieldParent = "";
            this.fld_lkeFK_ICProductAttributeID.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductAttributeID.BOSPrivilege = "";
            this.fld_lkeFK_ICProductAttributeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeID.BOSSelectType = "";
            this.fld_lkeFK_ICProductAttributeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICProductAttributeID.CurrentDisplayText = "";
            this.fld_lkeFK_ICProductAttributeID.Location = new System.Drawing.Point(73, 25);
            this.fld_lkeFK_ICProductAttributeID.Name = "fld_lkeFK_ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeSerialNo", "Barcode")});
            this.fld_lkeFK_ICProductAttributeID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductAttributeID.Properties.NullText = "";
            this.fld_lkeFK_ICProductAttributeID.Properties.PopupWidth = 20;
            this.fld_lkeFK_ICProductAttributeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductAttributeID.Screen = null;
            this.fld_lkeFK_ICProductAttributeID.Size = new System.Drawing.Size(873, 20);
            this.fld_lkeFK_ICProductAttributeID.TabIndex = 1;
            this.fld_lkeFK_ICProductAttributeID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductAttributeID_KeyUp);
            // 
            // fld_dgcARLayByItems
            // 
            this.fld_dgcARLayByItems.AllowDrop = true;
            this.fld_dgcARLayByItems.BOSComment = "";
            this.fld_dgcARLayByItems.BOSDataMember = null;
            this.fld_dgcARLayByItems.BOSDataSource = "ARSaleOrderItems";
            this.fld_dgcARLayByItems.BOSDescription = null;
            this.fld_dgcARLayByItems.BOSError = "";
            this.fld_dgcARLayByItems.BOSFieldGroup = "";
            this.fld_dgcARLayByItems.BOSFieldRelation = null;
            this.fld_dgcARLayByItems.BOSGridType = null;
            this.fld_dgcARLayByItems.BOSPrivilege = "";
            this.fld_dgcARLayByItems.BOSPropertyName = null;
            this.fld_dgcARLayByItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARLayByItems.Location = new System.Drawing.Point(8, 57);
            this.fld_dgcARLayByItems.MainView = this.fld_dgvARLayByItems;
            this.fld_dgcARLayByItems.Name = "fld_dgcARLayByItems";
            this.fld_dgcARLayByItems.Screen = null;
            this.fld_dgcARLayByItems.Size = new System.Drawing.Size(938, 263);
            this.fld_dgcARLayByItems.TabIndex = 20;
            this.fld_dgcARLayByItems.Tag = "DC";
            this.fld_dgcARLayByItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARLayByItems});
            // 
            // fld_dgvARLayByItems
            // 
            this.fld_dgvARLayByItems.GridControl = this.fld_dgcARLayByItems;
            this.fld_dgvARLayByItems.Name = "fld_dgvARLayByItems";
            this.fld_dgvARLayByItems.PaintStyleName = "Office2003";
            // 
            // fld_pteARSaleOrderItemProductPicture
            // 
            this.fld_pteARSaleOrderItemProductPicture.BOSComment = "";
            this.fld_pteARSaleOrderItemProductPicture.BOSDataMember = "ARSaleOrderItemProductPicture";
            this.fld_pteARSaleOrderItemProductPicture.BOSDataSource = "ARSaleOrderItems";
            this.fld_pteARSaleOrderItemProductPicture.BOSDescription = null;
            this.fld_pteARSaleOrderItemProductPicture.BOSError = "";
            this.fld_pteARSaleOrderItemProductPicture.BOSFieldGroup = "";
            this.fld_pteARSaleOrderItemProductPicture.BOSFieldRelation = null;
            this.fld_pteARSaleOrderItemProductPicture.BOSPrivilege = "";
            this.fld_pteARSaleOrderItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteARSaleOrderItemProductPicture.Location = new System.Drawing.Point(952, 28);
            this.fld_pteARSaleOrderItemProductPicture.Name = "fld_pteARSaleOrderItemProductPicture";
            this.fld_pteARSaleOrderItemProductPicture.Screen = null;
            this.fld_pteARSaleOrderItemProductPicture.Size = new System.Drawing.Size(140, 132);
            this.fld_pteARSaleOrderItemProductPicture.TabIndex = 471;
            this.fld_pteARSaleOrderItemProductPicture.Tag = "DC";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = "";
            this.fld_lblLabel14.BOSDataMember = "";
            this.fld_lblLabel14.BOSDataSource = "";
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = "";
            this.fld_lblLabel14.BOSFieldRelation = "";
            this.fld_lblLabel14.BOSPrivilege = "";
            this.fld_lblLabel14.BOSPropertyName = null;
            this.fld_lblLabel14.Location = new System.Drawing.Point(909, 494);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel14.TabIndex = 399;
            this.fld_lblLabel14.Tag = "";
            this.fld_lblLabel14.Text = "Giảm giá";
            // 
            // fld_lblLabel15
            // 
            this.fld_lblLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel15.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel15.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel15.BOSComment = "";
            this.fld_lblLabel15.BOSDataMember = "";
            this.fld_lblLabel15.BOSDataSource = "";
            this.fld_lblLabel15.BOSDescription = null;
            this.fld_lblLabel15.BOSError = null;
            this.fld_lblLabel15.BOSFieldGroup = "";
            this.fld_lblLabel15.BOSFieldRelation = "";
            this.fld_lblLabel15.BOSPrivilege = "";
            this.fld_lblLabel15.BOSPropertyName = null;
            this.fld_lblLabel15.Location = new System.Drawing.Point(899, 469);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.fld_lblLabel15.Size = new System.Drawing.Size(50, 13);
            this.fld_lblLabel15.TabIndex = 414;
            this.fld_lblLabel15.Tag = "";
            this.fld_lblLabel15.Text = "Tổng cộng";
            // 
            // fld_lblLabel19
            // 
            this.fld_lblLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel19.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel19.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel19.Appearance.Options.UseFont = true;
            this.fld_lblLabel19.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel19.BOSComment = "";
            this.fld_lblLabel19.BOSDataMember = "";
            this.fld_lblLabel19.BOSDataSource = "";
            this.fld_lblLabel19.BOSDescription = null;
            this.fld_lblLabel19.BOSError = null;
            this.fld_lblLabel19.BOSFieldGroup = "";
            this.fld_lblLabel19.BOSFieldRelation = "";
            this.fld_lblLabel19.BOSPrivilege = "";
            this.fld_lblLabel19.BOSPropertyName = null;
            this.fld_lblLabel19.Location = new System.Drawing.Point(884, 519);
            this.fld_lblLabel19.Name = "fld_lblLabel19";
            this.fld_lblLabel19.Screen = null;
            this.fld_lblLabel19.Size = new System.Drawing.Size(66, 13);
            this.fld_lblLabel19.TabIndex = 415;
            this.fld_lblLabel19.Tag = "";
            this.fld_lblLabel19.Text = "THÀNH TIỀN";
            // 
            // fld_lblLabel20
            // 
            this.fld_lblLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel20.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel20.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel20.BOSComment = "";
            this.fld_lblLabel20.BOSDataMember = "";
            this.fld_lblLabel20.BOSDataSource = "";
            this.fld_lblLabel20.BOSDescription = null;
            this.fld_lblLabel20.BOSError = null;
            this.fld_lblLabel20.BOSFieldGroup = "";
            this.fld_lblLabel20.BOSFieldRelation = "";
            this.fld_lblLabel20.BOSPrivilege = "ChangePriceLevel";
            this.fld_lblLabel20.BOSPropertyName = null;
            this.fld_lblLabel20.Location = new System.Drawing.Point(644, 469);
            this.fld_lblLabel20.Name = "fld_lblLabel20";
            this.fld_lblLabel20.Screen = null;
            this.fld_lblLabel20.Size = new System.Drawing.Size(37, 13);
            this.fld_lblLabel20.TabIndex = 417;
            this.fld_lblLabel20.Tag = "";
            this.fld_lblLabel20.Text = "Mức giá";
            // 
            // fld_lkeFK_ARPriceLevelID
            // 
            this.fld_lkeFK_ARPriceLevelID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARPriceLevelID.BOSAllowDummy = false;
            this.fld_lkeFK_ARPriceLevelID.BOSComment = "";
            this.fld_lkeFK_ARPriceLevelID.BOSDataMember = "FK_ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID.BOSDataSource = "ARSaleOrders";
            this.fld_lkeFK_ARPriceLevelID.BOSDescription = null;
            this.fld_lkeFK_ARPriceLevelID.BOSError = "";
            this.fld_lkeFK_ARPriceLevelID.BOSFieldGroup = "";
            this.fld_lkeFK_ARPriceLevelID.BOSFieldParent = "";
            this.fld_lkeFK_ARPriceLevelID.BOSFieldRelation = "";
            this.fld_lkeFK_ARPriceLevelID.BOSPrivilege = "ChangePriceLevel";
            this.fld_lkeFK_ARPriceLevelID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARPriceLevelID.BOSSelectType = "";
            this.fld_lkeFK_ARPriceLevelID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARPriceLevelID.CurrentDisplayText = "";
            this.fld_lkeFK_ARPriceLevelID.Location = new System.Drawing.Point(725, 466);
            this.fld_lkeFK_ARPriceLevelID.Name = "fld_lkeFK_ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARPriceLevelID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARPriceLevelID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARPriceLevelID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARPriceLevelName", "Name")});
            this.fld_lkeFK_ARPriceLevelID.Properties.DisplayMember = "ARPriceLevelName";
            this.fld_lkeFK_ARPriceLevelID.Properties.NullText = "";
            this.fld_lkeFK_ARPriceLevelID.Properties.PopupWidth = 20;
            this.fld_lkeFK_ARPriceLevelID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARPriceLevelID.Properties.ValueMember = "ARPriceLevelID";
            this.fld_lkeFK_ARPriceLevelID.Screen = null;
            this.fld_lkeFK_ARPriceLevelID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_ARPriceLevelID.TabIndex = 5;
            this.fld_lkeFK_ARPriceLevelID.Tag = "DC";
            this.fld_lkeFK_ARPriceLevelID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ARPriceLevelID_CloseUp);
            // 
            // fld_pteARSaleOrderEmployeePicture
            // 
            this.fld_pteARSaleOrderEmployeePicture.BOSComment = "";
            this.fld_pteARSaleOrderEmployeePicture.BOSDataMember = "ARSaleOrderEmployeePicture";
            this.fld_pteARSaleOrderEmployeePicture.BOSDataSource = "ARSaleOrders";
            this.fld_pteARSaleOrderEmployeePicture.BOSDescription = null;
            this.fld_pteARSaleOrderEmployeePicture.BOSError = "";
            this.fld_pteARSaleOrderEmployeePicture.BOSFieldGroup = "";
            this.fld_pteARSaleOrderEmployeePicture.BOSFieldRelation = null;
            this.fld_pteARSaleOrderEmployeePicture.BOSPrivilege = "";
            this.fld_pteARSaleOrderEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteARSaleOrderEmployeePicture.Location = new System.Drawing.Point(3, 2);
            this.fld_pteARSaleOrderEmployeePicture.Name = "fld_pteARSaleOrderEmployeePicture";
            this.fld_pteARSaleOrderEmployeePicture.Screen = null;
            this.fld_pteARSaleOrderEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteARSaleOrderEmployeePicture.TabIndex = 462;
            this.fld_pteARSaleOrderEmployeePicture.Tag = "DC";
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = "";
            this.fld_lblLabel11.BOSDataMember = "";
            this.fld_lblLabel11.BOSDataSource = "";
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = "";
            this.fld_lblLabel11.BOSFieldRelation = "";
            this.fld_lblLabel11.BOSPrivilege = "";
            this.fld_lblLabel11.BOSPropertyName = null;
            this.fld_lblLabel11.Location = new System.Drawing.Point(124, 39);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(56, 13);
            this.fld_lblLabel11.TabIndex = 470;
            this.fld_lblLabel11.Tag = "";
            this.fld_lblLabel11.Text = "Khách hàng";
            // 
            // fld_txtARSaleOrderSubTotalAmount
            // 
            this.fld_txtARSaleOrderSubTotalAmount.BOSComment = "";
            this.fld_txtARSaleOrderSubTotalAmount.BOSDataMember = "ARSaleOrderSubTotalAmount";
            this.fld_txtARSaleOrderSubTotalAmount.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderSubTotalAmount.BOSDescription = null;
            this.fld_txtARSaleOrderSubTotalAmount.BOSError = "";
            this.fld_txtARSaleOrderSubTotalAmount.BOSFieldGroup = "";
            this.fld_txtARSaleOrderSubTotalAmount.BOSFieldRelation = "";
            this.fld_txtARSaleOrderSubTotalAmount.BOSPrivilege = "";
            this.fld_txtARSaleOrderSubTotalAmount.BOSPropertyName = "Text";
            this.fld_txtARSaleOrderSubTotalAmount.Location = new System.Drawing.Point(986, 466);
            this.fld_txtARSaleOrderSubTotalAmount.Name = "fld_txtARSaleOrderSubTotalAmount";
            this.fld_txtARSaleOrderSubTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fld_txtARSaleOrderSubTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderSubTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderSubTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderSubTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderSubTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleOrderSubTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderSubTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARSaleOrderSubTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderSubTotalAmount.Screen = null;
            this.fld_txtARSaleOrderSubTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARSaleOrderSubTotalAmount.TabIndex = 477;
            this.fld_txtARSaleOrderSubTotalAmount.Tag = "DC";
            // 
            // fld_txtARSaleOrderTotalAmount
            // 
            this.fld_txtARSaleOrderTotalAmount.BOSComment = "";
            this.fld_txtARSaleOrderTotalAmount.BOSDataMember = "ARSaleOrderTotalAmount";
            this.fld_txtARSaleOrderTotalAmount.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderTotalAmount.BOSDescription = null;
            this.fld_txtARSaleOrderTotalAmount.BOSError = "";
            this.fld_txtARSaleOrderTotalAmount.BOSFieldGroup = "";
            this.fld_txtARSaleOrderTotalAmount.BOSFieldRelation = "";
            this.fld_txtARSaleOrderTotalAmount.BOSPrivilege = "";
            this.fld_txtARSaleOrderTotalAmount.BOSPropertyName = "Text";
            this.fld_txtARSaleOrderTotalAmount.Location = new System.Drawing.Point(986, 516);
            this.fld_txtARSaleOrderTotalAmount.Name = "fld_txtARSaleOrderTotalAmount";
            this.fld_txtARSaleOrderTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fld_txtARSaleOrderTotalAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_txtARSaleOrderTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderTotalAmount.Properties.Appearance.Options.UseFont = true;
            this.fld_txtARSaleOrderTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleOrderTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARSaleOrderTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderTotalAmount.Screen = null;
            this.fld_txtARSaleOrderTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARSaleOrderTotalAmount.TabIndex = 478;
            this.fld_txtARSaleOrderTotalAmount.Tag = "DC";
            // 
            // fld_txtARSaleOrderDepositBalance
            // 
            this.fld_txtARSaleOrderDepositBalance.BOSComment = "";
            this.fld_txtARSaleOrderDepositBalance.BOSDataMember = "ARSaleOrderDepositBalance";
            this.fld_txtARSaleOrderDepositBalance.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderDepositBalance.BOSDescription = null;
            this.fld_txtARSaleOrderDepositBalance.BOSError = "";
            this.fld_txtARSaleOrderDepositBalance.BOSFieldGroup = "";
            this.fld_txtARSaleOrderDepositBalance.BOSFieldRelation = "";
            this.fld_txtARSaleOrderDepositBalance.BOSPrivilege = "";
            this.fld_txtARSaleOrderDepositBalance.BOSPropertyName = "Text";
            this.fld_txtARSaleOrderDepositBalance.Location = new System.Drawing.Point(986, 541);
            this.fld_txtARSaleOrderDepositBalance.Name = "fld_txtARSaleOrderDepositBalance";
            this.fld_txtARSaleOrderDepositBalance.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fld_txtARSaleOrderDepositBalance.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_txtARSaleOrderDepositBalance.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderDepositBalance.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderDepositBalance.Properties.Appearance.Options.UseFont = true;
            this.fld_txtARSaleOrderDepositBalance.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderDepositBalance.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderDepositBalance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleOrderDepositBalance.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderDepositBalance.Properties.ReadOnly = true;
            this.fld_txtARSaleOrderDepositBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderDepositBalance.Screen = null;
            this.fld_txtARSaleOrderDepositBalance.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARSaleOrderDepositBalance.TabIndex = 479;
            this.fld_txtARSaleOrderDepositBalance.Tag = "DC";
            // 
            // fld_txtARSaleOrderBalanceDue
            // 
            this.fld_txtARSaleOrderBalanceDue.BOSComment = "";
            this.fld_txtARSaleOrderBalanceDue.BOSDataMember = "ARSaleOrderBalanceDue";
            this.fld_txtARSaleOrderBalanceDue.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderBalanceDue.BOSDescription = null;
            this.fld_txtARSaleOrderBalanceDue.BOSError = "";
            this.fld_txtARSaleOrderBalanceDue.BOSFieldGroup = "";
            this.fld_txtARSaleOrderBalanceDue.BOSFieldRelation = "";
            this.fld_txtARSaleOrderBalanceDue.BOSPrivilege = "";
            this.fld_txtARSaleOrderBalanceDue.BOSPropertyName = "Text";
            this.fld_txtARSaleOrderBalanceDue.Location = new System.Drawing.Point(986, 566);
            this.fld_txtARSaleOrderBalanceDue.Name = "fld_txtARSaleOrderBalanceDue";
            this.fld_txtARSaleOrderBalanceDue.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fld_txtARSaleOrderBalanceDue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_txtARSaleOrderBalanceDue.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderBalanceDue.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderBalanceDue.Properties.Appearance.Options.UseFont = true;
            this.fld_txtARSaleOrderBalanceDue.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderBalanceDue.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderBalanceDue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleOrderBalanceDue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderBalanceDue.Properties.ReadOnly = true;
            this.fld_txtARSaleOrderBalanceDue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderBalanceDue.Screen = null;
            this.fld_txtARSaleOrderBalanceDue.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARSaleOrderBalanceDue.TabIndex = 480;
            this.fld_txtARSaleOrderBalanceDue.Tag = "DC";
            // 
            // fld_txtARSaleOrderDiscountFix
            // 
            this.fld_txtARSaleOrderDiscountFix.BOSComment = "";
            this.fld_txtARSaleOrderDiscountFix.BOSDataMember = "ARSaleOrderDiscountFix";
            this.fld_txtARSaleOrderDiscountFix.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderDiscountFix.BOSDescription = null;
            this.fld_txtARSaleOrderDiscountFix.BOSError = "";
            this.fld_txtARSaleOrderDiscountFix.BOSFieldGroup = "";
            this.fld_txtARSaleOrderDiscountFix.BOSFieldRelation = "";
            this.fld_txtARSaleOrderDiscountFix.BOSPrivilege = "";
            this.fld_txtARSaleOrderDiscountFix.BOSPropertyName = "Text";
            this.fld_txtARSaleOrderDiscountFix.Location = new System.Drawing.Point(986, 491);
            this.fld_txtARSaleOrderDiscountFix.Name = "fld_txtARSaleOrderDiscountFix";
            this.fld_txtARSaleOrderDiscountFix.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleOrderDiscountFix.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderDiscountFix.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderDiscountFix.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderDiscountFix.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderDiscountFix.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleOrderDiscountFix.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderDiscountFix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderDiscountFix.Screen = null;
            this.fld_txtARSaleOrderDiscountFix.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARSaleOrderDiscountFix.TabIndex = 7;
            this.fld_txtARSaleOrderDiscountFix.Tag = "DC";
            this.fld_txtARSaleOrderDiscountFix.Validated += new System.EventHandler(this.fld_txtARSaleOrderDiscountFix_Validated);
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseFont = true;
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(883, 544);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(66, 13);
            this.fld_lblLabel2.TabIndex = 482;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "TRẢ TRƯỚC";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseFont = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = "";
            this.fld_lblLabel7.BOSDataMember = "";
            this.fld_lblLabel7.BOSDataSource = "";
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = "";
            this.fld_lblLabel7.BOSFieldRelation = "";
            this.fld_lblLabel7.BOSPrivilege = "";
            this.fld_lblLabel7.BOSPropertyName = null;
            this.fld_lblLabel7.Location = new System.Drawing.Point(887, 569);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(63, 13);
            this.fld_lblLabel7.TabIndex = 483;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "NỢ CÒN LẠI";
            // 
            // fld_lkeFK_ARCustomerID
            // 
            this.fld_lkeFK_ARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID.BOSAllowDummy = false;
            this.fld_lkeFK_ARCustomerID.BOSComment = "";
            this.fld_lkeFK_ARCustomerID.BOSDataMember = "FK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.BOSDataSource = "ARSaleOrders";
            this.fld_lkeFK_ARCustomerID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID.BOSError = "Please choose a customer.";
            this.fld_lkeFK_ARCustomerID.BOSFieldGroup = "";
            this.fld_lkeFK_ARCustomerID.BOSFieldParent = "";
            this.fld_lkeFK_ARCustomerID.BOSFieldRelation = "";
            this.fld_lkeFK_ARCustomerID.BOSPrivilege = "";
            this.fld_lkeFK_ARCustomerID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerID.BOSSelectType = "";
            this.fld_lkeFK_ARCustomerID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARCustomerID.CurrentDisplayText = "";
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(196, 36);
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Name")});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerNo";
            this.fld_lkeFK_ARCustomerID.Properties.NullText = "";
            this.fld_lkeFK_ARCustomerID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ARCustomerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Screen = null;
            this.fld_lkeFK_ARCustomerID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARCustomerID.TabIndex = 1;
            this.fld_lkeFK_ARCustomerID.Tag = "DC";
            this.fld_lkeFK_ARCustomerID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ARCustomerID_CloseUp);
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARSaleOrders";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = "Please choose a staff.";
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(4, 104);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeFName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 0;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            this.fld_lkeFK_HREmployeeID.Validated += new System.EventHandler(this.fld_lkeFK_HREmployeeID_Validated);
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = "";
            this.fld_lblLabel8.BOSDataMember = "";
            this.fld_lblLabel8.BOSDataSource = "";
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = "";
            this.fld_lblLabel8.BOSFieldRelation = "";
            this.fld_lblLabel8.BOSPrivilege = "";
            this.fld_lblLabel8.BOSPropertyName = null;
            this.fld_lblLabel8.Location = new System.Drawing.Point(470, 39);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel8.TabIndex = 489;
            this.fld_lblLabel8.Tag = "";
            this.fld_lblLabel8.Text = "Ngày hết hạn";
            // 
            // fld_dteARSaleOrderDeliveryDate
            // 
            this.fld_dteARSaleOrderDeliveryDate.BOSComment = "";
            this.fld_dteARSaleOrderDeliveryDate.BOSDataMember = "ARSaleOrderDeliveryDate";
            this.fld_dteARSaleOrderDeliveryDate.BOSDataSource = "ARSaleOrders";
            this.fld_dteARSaleOrderDeliveryDate.BOSDescription = null;
            this.fld_dteARSaleOrderDeliveryDate.BOSError = "";
            this.fld_dteARSaleOrderDeliveryDate.BOSFieldGroup = "";
            this.fld_dteARSaleOrderDeliveryDate.BOSFieldRelation = null;
            this.fld_dteARSaleOrderDeliveryDate.BOSPrivilege = "";
            this.fld_dteARSaleOrderDeliveryDate.BOSPropertyName = "EditValue";
            this.fld_dteARSaleOrderDeliveryDate.EditValue = null;
            this.fld_dteARSaleOrderDeliveryDate.Location = new System.Drawing.Point(557, 36);
            this.fld_dteARSaleOrderDeliveryDate.Name = "fld_dteARSaleOrderDeliveryDate";
            this.fld_dteARSaleOrderDeliveryDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARSaleOrderDeliveryDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARSaleOrderDeliveryDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARSaleOrderDeliveryDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARSaleOrderDeliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARSaleOrderDeliveryDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARSaleOrderDeliveryDate.Screen = null;
            this.fld_dteARSaleOrderDeliveryDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteARSaleOrderDeliveryDate.TabIndex = 2;
            this.fld_dteARSaleOrderDeliveryDate.Tag = "DC";
            // 
            // fld_lblLabel12
            // 
            this.fld_lblLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel12.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel12.BOSComment = "";
            this.fld_lblLabel12.BOSDataMember = "";
            this.fld_lblLabel12.BOSDataSource = "";
            this.fld_lblLabel12.BOSDescription = null;
            this.fld_lblLabel12.BOSError = null;
            this.fld_lblLabel12.BOSFieldGroup = "";
            this.fld_lblLabel12.BOSFieldRelation = "";
            this.fld_lblLabel12.BOSPrivilege = "";
            this.fld_lblLabel12.BOSPropertyName = null;
            this.fld_lblLabel12.Location = new System.Drawing.Point(470, 65);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel12.TabIndex = 493;
            this.fld_lblLabel12.Tag = "";
            this.fld_lblLabel12.Text = "Tình trạng";
            // 
            // fld_txtARSaleOrderStatus
            // 
            this.fld_txtARSaleOrderStatus.BOSComment = "";
            this.fld_txtARSaleOrderStatus.BOSDataMember = "ARSaleOrderStatus";
            this.fld_txtARSaleOrderStatus.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderStatus.BOSDescription = null;
            this.fld_txtARSaleOrderStatus.BOSError = "";
            this.fld_txtARSaleOrderStatus.BOSFieldGroup = "";
            this.fld_txtARSaleOrderStatus.BOSFieldRelation = "";
            this.fld_txtARSaleOrderStatus.BOSPrivilege = "";
            this.fld_txtARSaleOrderStatus.BOSPropertyName = "Text";
            this.fld_txtARSaleOrderStatus.Location = new System.Drawing.Point(557, 62);
            this.fld_txtARSaleOrderStatus.Name = "fld_txtARSaleOrderStatus";
            this.fld_txtARSaleOrderStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fld_txtARSaleOrderStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderStatus.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderStatus.Properties.ReadOnly = true;
            this.fld_txtARSaleOrderStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderStatus.Screen = null;
            this.fld_txtARSaleOrderStatus.Size = new System.Drawing.Size(125, 20);
            this.fld_txtARSaleOrderStatus.TabIndex = 20;
            this.fld_txtARSaleOrderStatus.Tag = "DC";
            // 
            // fld_lblLabel16
            // 
            this.fld_lblLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel16.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel16.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel16.BOSComment = "";
            this.fld_lblLabel16.BOSDataMember = "";
            this.fld_lblLabel16.BOSDataSource = "";
            this.fld_lblLabel16.BOSDescription = null;
            this.fld_lblLabel16.BOSError = null;
            this.fld_lblLabel16.BOSFieldGroup = "";
            this.fld_lblLabel16.BOSFieldRelation = "";
            this.fld_lblLabel16.BOSPrivilege = "";
            this.fld_lblLabel16.BOSPropertyName = null;
            this.fld_lblLabel16.Location = new System.Drawing.Point(644, 493);
            this.fld_lblLabel16.Name = "fld_lblLabel16";
            this.fld_lblLabel16.Screen = null;
            this.fld_lblLabel16.Size = new System.Drawing.Size(0, 13);
            this.fld_lblLabel16.TabIndex = 496;
            this.fld_lblLabel16.Tag = "";
            // 
            // fld_txtARSaleOrderDiscountPerCent
            // 
            this.fld_txtARSaleOrderDiscountPerCent.BOSComment = "";
            this.fld_txtARSaleOrderDiscountPerCent.BOSDataMember = "ARSaleOrderDiscountPerCent";
            this.fld_txtARSaleOrderDiscountPerCent.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderDiscountPerCent.BOSDescription = null;
            this.fld_txtARSaleOrderDiscountPerCent.BOSError = "";
            this.fld_txtARSaleOrderDiscountPerCent.BOSFieldGroup = "Accept";
            this.fld_txtARSaleOrderDiscountPerCent.BOSFieldRelation = "";
            this.fld_txtARSaleOrderDiscountPerCent.BOSPrivilege = "";
            this.fld_txtARSaleOrderDiscountPerCent.BOSPropertyName = "Text";
            this.fld_txtARSaleOrderDiscountPerCent.Location = new System.Drawing.Point(725, 491);
            this.fld_txtARSaleOrderDiscountPerCent.Name = "fld_txtARSaleOrderDiscountPerCent";
            this.fld_txtARSaleOrderDiscountPerCent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleOrderDiscountPerCent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderDiscountPerCent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderDiscountPerCent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderDiscountPerCent.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderDiscountPerCent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARSaleOrderDiscountPerCent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderDiscountPerCent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderDiscountPerCent.Screen = null;
            this.fld_txtARSaleOrderDiscountPerCent.Size = new System.Drawing.Size(75, 20);
            this.fld_txtARSaleOrderDiscountPerCent.TabIndex = 6;
            this.fld_txtARSaleOrderDiscountPerCent.Tag = "DC";
            this.fld_txtARSaleOrderDiscountPerCent.Validated += new System.EventHandler(this.fld_txtARSaleOrderDiscountPerCent_Validated);
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = "";
            this.fld_lblLabel17.BOSDataMember = "";
            this.fld_lblLabel17.BOSDataSource = "";
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = "";
            this.fld_lblLabel17.BOSFieldRelation = "";
            this.fld_lblLabel17.BOSPrivilege = "";
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(644, 494);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(62, 13);
            this.fld_lblLabel17.TabIndex = 498;
            this.fld_lblLabel17.Tag = "";
            this.fld_lblLabel17.Text = "Giảm giá (%)";
            // 
            // fld_dteARSaleOrderDate
            // 
            this.fld_dteARSaleOrderDate.BOSComment = null;
            this.fld_dteARSaleOrderDate.BOSDataMember = "ARSaleOrderDate";
            this.fld_dteARSaleOrderDate.BOSDataSource = "ARSaleOrders";
            this.fld_dteARSaleOrderDate.BOSDescription = null;
            this.fld_dteARSaleOrderDate.BOSError = null;
            this.fld_dteARSaleOrderDate.BOSFieldGroup = null;
            this.fld_dteARSaleOrderDate.BOSFieldRelation = null;
            this.fld_dteARSaleOrderDate.BOSPrivilege = null;
            this.fld_dteARSaleOrderDate.BOSPropertyName = "EditValue";
            this.fld_dteARSaleOrderDate.EditValue = null;
            this.fld_dteARSaleOrderDate.Location = new System.Drawing.Point(557, 10);
            this.fld_dteARSaleOrderDate.MenuManager = this.screenToolbar;
            this.fld_dteARSaleOrderDate.Name = "fld_dteARSaleOrderDate";
            this.fld_dteARSaleOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARSaleOrderDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARSaleOrderDate.Screen = null;
            this.fld_dteARSaleOrderDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteARSaleOrderDate.TabIndex = 3;
            this.fld_dteARSaleOrderDate.Tag = "DC";
            // 
            // BOSLabel1
            // 
            this.BOSLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BOSLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel1.Appearance.Options.UseBackColor = true;
            this.BOSLabel1.Appearance.Options.UseForeColor = true;
            this.BOSLabel1.BOSComment = "";
            this.BOSLabel1.BOSDataMember = "";
            this.BOSLabel1.BOSDataSource = "";
            this.BOSLabel1.BOSDescription = null;
            this.BOSLabel1.BOSError = null;
            this.BOSLabel1.BOSFieldGroup = "";
            this.BOSLabel1.BOSFieldRelation = "";
            this.BOSLabel1.BOSPrivilege = "";
            this.BOSLabel1.BOSPropertyName = null;
            this.BOSLabel1.Location = new System.Drawing.Point(470, 13);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(44, 13);
            this.BOSLabel1.TabIndex = 493;
            this.BOSLabel1.Tag = "";
            this.BOSLabel1.Text = "Ngày tạo";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
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
            this.bosLabel2.Location = new System.Drawing.Point(126, 13);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(14, 13);
            this.bosLabel2.TabIndex = 470;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Mã";
            // 
            // fld_txtARSaleOrderNo1
            // 
            this.fld_txtARSaleOrderNo1.BOSComment = null;
            this.fld_txtARSaleOrderNo1.BOSDataMember = "ARSaleOrderNo";
            this.fld_txtARSaleOrderNo1.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderNo1.BOSDescription = null;
            this.fld_txtARSaleOrderNo1.BOSError = null;
            this.fld_txtARSaleOrderNo1.BOSFieldGroup = null;
            this.fld_txtARSaleOrderNo1.BOSFieldRelation = null;
            this.fld_txtARSaleOrderNo1.BOSPrivilege = null;
            this.fld_txtARSaleOrderNo1.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderNo1.Location = new System.Drawing.Point(196, 10);
            this.fld_txtARSaleOrderNo1.MenuManager = this.screenToolbar;
            this.fld_txtARSaleOrderNo1.Name = "fld_txtARSaleOrderNo1";
            this.fld_txtARSaleOrderNo1.Screen = null;
            this.fld_txtARSaleOrderNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleOrderNo1.TabIndex = 499;
            this.fld_txtARSaleOrderNo1.Tag = "DC";
            // 
            // fld_medARSaleOrderDesc
            // 
            this.fld_medARSaleOrderDesc.BOSComment = null;
            this.fld_medARSaleOrderDesc.BOSDataMember = "ARSaleOrderDesc";
            this.fld_medARSaleOrderDesc.BOSDataSource = "ARSaleOrders";
            this.fld_medARSaleOrderDesc.BOSDescription = null;
            this.fld_medARSaleOrderDesc.BOSError = null;
            this.fld_medARSaleOrderDesc.BOSFieldGroup = null;
            this.fld_medARSaleOrderDesc.BOSFieldRelation = null;
            this.fld_medARSaleOrderDesc.BOSPrivilege = null;
            this.fld_medARSaleOrderDesc.BOSPropertyName = "EditValue";
            this.fld_medARSaleOrderDesc.Location = new System.Drawing.Point(6, 20);
            this.fld_medARSaleOrderDesc.MenuManager = this.screenToolbar;
            this.fld_medARSaleOrderDesc.Name = "fld_medARSaleOrderDesc";
            this.fld_medARSaleOrderDesc.Screen = null;
            this.fld_medARSaleOrderDesc.Size = new System.Drawing.Size(312, 111);
            this.fld_medARSaleOrderDesc.TabIndex = 500;
            this.fld_medARSaleOrderDesc.Tag = "DC";
            // 
            // bosLine1
            // 
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_medARSaleOrderDesc);
            this.bosLine1.Location = new System.Drawing.Point(4, 459);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(324, 137);
            this.bosLine1.TabIndex = 501;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Diễn giải";
            // 
            // DMPS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1113, 608);
            this.Controls.Add(this.bosLine1);
            this.Controls.Add(this.fld_txtARSaleOrderNo1);
            this.Controls.Add(this.fld_dteARSaleOrderDate);
            this.Controls.Add(this.fld_pteARSaleOrderEmployeePicture);
            this.Controls.Add(this.fld_grcGroupControl1);
            this.Controls.Add(this.fld_txtARSaleOrderBalanceDue);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_txtARSaleOrderDiscountFix);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_txtARSaleOrderDepositBalance);
            this.Controls.Add(this.fld_txtARSaleOrderDiscountPerCent);
            this.Controls.Add(this.fld_txtARSaleOrderTotalAmount);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel15);
            this.Controls.Add(this.fld_lblLabel16);
            this.Controls.Add(this.fld_txtARSaleOrderSubTotalAmount);
            this.Controls.Add(this.fld_lblLabel20);
            this.Controls.Add(this.fld_lblLabel7);
            this.Controls.Add(this.fld_lblLabel19);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.Controls.Add(this.fld_lkeFK_ARPriceLevelID);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_txtARSaleOrderStatus);
            this.Controls.Add(this.fld_lblLabel11);
            this.Controls.Add(this.BOSLabel1);
            this.Controls.Add(this.fld_lblLabel8);
            this.Controls.Add(this.fld_dteARSaleOrderDeliveryDate);
            this.Controls.Add(this.fld_lblLabel12);
            this.Name = "DMPS100";
            this.Text = "Thông tin";
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            this.fld_grcGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARLayByItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARLayByItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARPriceLevelID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSubTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderDepositBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderBalanceDue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderDiscountPerCent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARSaleOrderDesc.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSDateEdit fld_dteARSaleOrderDate;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderNo1;
        private BOSComponent.BOSMemoEdit fld_medARSaleOrderDesc;
        private BOSComponent.BOSLine bosLine1;
	}
}
