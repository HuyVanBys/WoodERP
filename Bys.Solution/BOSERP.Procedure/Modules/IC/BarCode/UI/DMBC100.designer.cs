using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Barcode.UI
{
	/// <summary>
	/// Summary description for DMBC100
	/// </summary>
	partial class DMBC100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMBC100));
            this.fld_grcGroupControl5 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_btnAddProduct = new BOSComponent.BOSButton(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_btnUpdateItemBarcodeQty = new BOSComponent.BOSButton(this.components);
            this.fld_txtICBarcodeNumber = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel32 = new BOSComponent.BOSLabel(this.components);
            this.bosLine4 = new BOSComponent.BOSLine(this.components);
            this.fld_txtICBarcodeReference = new BOSComponent.BOSTextBox(this.components);
            this.fld_medARInvoiceDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARInvoiceStatus1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteICTransferDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICBarcodeNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcICBarcodeItems = new BOSERP.Modules.Barcode.ICBarcodeItemGridControl();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnPrintQRcode = new BOSComponent.BOSButton(this.components);
            this.fld_btnPrintBarcode = new BOSComponent.BOSButton(this.components);
            this.bosPanel3 = new BOSComponent.BOSPanel(this.components);
            this.bosPanel5 = new BOSComponent.BOSPanel(this.components);
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).BeginInit();
            this.fld_grcGroupControl5.SuspendLayout();
            this.bosLine2.SuspendLayout();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICBarcodeNumber.Properties)).BeginInit();
            this.bosLine4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICBarcodeReference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARInvoiceDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARInvoiceStatus1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICBarcodeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICBarcodeItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            this.bosPanel3.SuspendLayout();
            this.bosPanel5.SuspendLayout();
            this.bosPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl5
            // 
            this.fld_grcGroupControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.fld_grcGroupControl5.Controls.Add(this.bosLine2);
            this.fld_grcGroupControl5.Controls.Add(this.bosLine1);
            this.fld_grcGroupControl5.Controls.Add(this.bosLine4);
            this.fld_grcGroupControl5.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl5.Name = "fld_grcGroupControl5";
            this.fld_grcGroupControl5.Screen = null;
            this.fld_grcGroupControl5.Size = new System.Drawing.Size(1034, 172);
            this.fld_grcGroupControl5.TabIndex = 0;
            this.fld_grcGroupControl5.Tag = "";
            // 
            // bosLine2
            // 
            this.bosLine2.BackColor = System.Drawing.Color.Transparent;
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.fld_btnAddProduct);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bosLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine2.Location = new System.Drawing.Point(753, 26);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine2, true);
            this.bosLine2.Size = new System.Drawing.Size(107, 113);
            this.bosLine2.TabIndex = 782;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Chức năng";
            // 
            // fld_btnAddProduct
            // 
            this.fld_btnAddProduct.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProduct.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProduct.BOSComment = "";
            this.fld_btnAddProduct.BOSDataMember = "";
            this.fld_btnAddProduct.BOSDataSource = "";
            this.fld_btnAddProduct.BOSDescription = null;
            this.fld_btnAddProduct.BOSError = null;
            this.fld_btnAddProduct.BOSFieldGroup = "";
            this.fld_btnAddProduct.BOSFieldRelation = "";
            this.fld_btnAddProduct.BOSPrivilege = "";
            this.fld_btnAddProduct.BOSPropertyName = "";
            this.fld_btnAddProduct.Location = new System.Drawing.Point(6, 20);
            this.fld_btnAddProduct.Name = "fld_btnAddProduct";
            this.fld_btnAddProduct.Screen = null;
            this.fld_btnAddProduct.Size = new System.Drawing.Size(86, 20);
            this.fld_btnAddProduct.TabIndex = 848;
            this.fld_btnAddProduct.Tag = "";
            this.fld_btnAddProduct.Text = "Thêm sản phẩm";
            this.fld_btnAddProduct.Click += new System.EventHandler(this.fld_btnAddProduct_Click);
            // 
            // bosLine1
            // 
            this.bosLine1.BackColor = System.Drawing.Color.Transparent;
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_btnUpdateItemBarcodeQty);
            this.bosLine1.Controls.Add(this.fld_txtICBarcodeNumber);
            this.bosLine1.Controls.Add(this.bosLabel32);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bosLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine1.Location = new System.Drawing.Point(539, 26);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine1, true);
            this.bosLine1.Size = new System.Drawing.Size(208, 113);
            this.bosLine1.TabIndex = 781;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Cập nhật thông tin";
            // 
            // fld_btnUpdateItemBarcodeQty
            // 
            this.fld_btnUpdateItemBarcodeQty.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnUpdateItemBarcodeQty.Appearance.Options.UseForeColor = true;
            this.fld_btnUpdateItemBarcodeQty.BOSComment = "";
            this.fld_btnUpdateItemBarcodeQty.BOSDataMember = "";
            this.fld_btnUpdateItemBarcodeQty.BOSDataSource = "";
            this.fld_btnUpdateItemBarcodeQty.BOSDescription = null;
            this.fld_btnUpdateItemBarcodeQty.BOSError = null;
            this.fld_btnUpdateItemBarcodeQty.BOSFieldGroup = "";
            this.fld_btnUpdateItemBarcodeQty.BOSFieldRelation = "";
            this.fld_btnUpdateItemBarcodeQty.BOSPrivilege = "";
            this.fld_btnUpdateItemBarcodeQty.BOSPropertyName = "";
            this.fld_btnUpdateItemBarcodeQty.Location = new System.Drawing.Point(124, 49);
            this.fld_btnUpdateItemBarcodeQty.Name = "fld_btnUpdateItemBarcodeQty";
            this.fld_btnUpdateItemBarcodeQty.Screen = null;
            this.fld_btnUpdateItemBarcodeQty.Size = new System.Drawing.Size(75, 20);
            this.fld_btnUpdateItemBarcodeQty.TabIndex = 847;
            this.fld_btnUpdateItemBarcodeQty.Tag = "";
            this.fld_btnUpdateItemBarcodeQty.Text = "Cập nhật";
            this.fld_btnUpdateItemBarcodeQty.Click += new System.EventHandler(this.fld_btnUpdateItemBarcodeQty_Click);
            // 
            // fld_txtICBarcodeNumber
            // 
            this.fld_txtICBarcodeNumber.BOSComment = "";
            this.fld_txtICBarcodeNumber.BOSDataMember = "ICBarcodeNumber";
            this.fld_txtICBarcodeNumber.BOSDataSource = "ICBarcodes";
            this.fld_txtICBarcodeNumber.BOSDescription = null;
            this.fld_txtICBarcodeNumber.BOSError = null;
            this.fld_txtICBarcodeNumber.BOSFieldGroup = "";
            this.fld_txtICBarcodeNumber.BOSFieldRelation = "";
            this.fld_txtICBarcodeNumber.BOSPrivilege = "";
            this.fld_txtICBarcodeNumber.BOSPropertyName = "EditValue";
            this.fld_txtICBarcodeNumber.EditValue = "";
            this.fld_txtICBarcodeNumber.Location = new System.Drawing.Point(140, 20);
            this.fld_txtICBarcodeNumber.Name = "fld_txtICBarcodeNumber";
            this.fld_txtICBarcodeNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICBarcodeNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICBarcodeNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICBarcodeNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICBarcodeNumber.Properties.BeepOnError = false;
            this.fld_txtICBarcodeNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICBarcodeNumber.Properties.MaskSettings.Set("mask", "f2");
            this.fld_txtICBarcodeNumber.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtICBarcodeNumber.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.fld_txtICBarcodeNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICBarcodeNumber.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICBarcodeNumber, true);
            this.fld_txtICBarcodeNumber.Size = new System.Drawing.Size(35, 20);
            this.fld_txtICBarcodeNumber.TabIndex = 845;
            this.fld_txtICBarcodeNumber.Tag = "DC";
            // 
            // bosLabel32
            // 
            this.bosLabel32.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel32.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel32.Appearance.Options.UseBackColor = true;
            this.bosLabel32.Appearance.Options.UseForeColor = true;
            this.bosLabel32.BOSComment = "";
            this.bosLabel32.BOSDataMember = "";
            this.bosLabel32.BOSDataSource = "";
            this.bosLabel32.BOSDescription = null;
            this.bosLabel32.BOSError = null;
            this.bosLabel32.BOSFieldGroup = "";
            this.bosLabel32.BOSFieldRelation = "";
            this.bosLabel32.BOSPrivilege = "";
            this.bosLabel32.BOSPropertyName = null;
            this.bosLabel32.Location = new System.Drawing.Point(6, 23);
            this.bosLabel32.Name = "bosLabel32";
            this.bosLabel32.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel32, true);
            this.bosLabel32.Size = new System.Drawing.Size(116, 13);
            this.bosLabel32.TabIndex = 846;
            this.bosLabel32.Tag = "";
            this.bosLabel32.Text = "Số lượng mã vạch cần in";
            // 
            // bosLine4
            // 
            this.bosLine4.BackColor = System.Drawing.Color.Transparent;
            this.bosLine4.BOSComment = null;
            this.bosLine4.BOSDataMember = null;
            this.bosLine4.BOSDataSource = null;
            this.bosLine4.BOSDescription = null;
            this.bosLine4.BOSError = null;
            this.bosLine4.BOSFieldGroup = null;
            this.bosLine4.BOSFieldRelation = null;
            this.bosLine4.BOSPrivilege = null;
            this.bosLine4.BOSPropertyName = null;
            this.bosLine4.Controls.Add(this.fld_txtICBarcodeReference);
            this.bosLine4.Controls.Add(this.fld_medARInvoiceDesc);
            this.bosLine4.Controls.Add(this.bosLabel4);
            this.bosLine4.Controls.Add(this.fld_lblLabel25);
            this.bosLine4.Controls.Add(this.fld_lkeARInvoiceStatus1);
            this.bosLine4.Controls.Add(this.fld_dteICTransferDate);
            this.bosLine4.Controls.Add(this.bosLabel3);
            this.bosLine4.Controls.Add(this.bosLabel1);
            this.bosLine4.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosLine4.Controls.Add(this.bosLabel6);
            this.bosLine4.Controls.Add(this.fld_txtICBarcodeNo);
            this.bosLine4.Controls.Add(this.bosLabel2);
            this.bosLine4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bosLine4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine4.Location = new System.Drawing.Point(3, 26);
            this.bosLine4.Name = "bosLine4";
            this.bosLine4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine4, true);
            this.bosLine4.Size = new System.Drawing.Size(530, 146);
            this.bosLine4.TabIndex = 780;
            this.bosLine4.TabStop = false;
            this.bosLine4.Text = "Thông tin chung";
            // 
            // fld_txtICBarcodeReference
            // 
            this.fld_txtICBarcodeReference.BOSComment = null;
            this.fld_txtICBarcodeReference.BOSDataMember = "ICBarcodeReference";
            this.fld_txtICBarcodeReference.BOSDataSource = "ICBarcodes";
            this.fld_txtICBarcodeReference.BOSDescription = null;
            this.fld_txtICBarcodeReference.BOSError = null;
            this.fld_txtICBarcodeReference.BOSFieldGroup = null;
            this.fld_txtICBarcodeReference.BOSFieldRelation = null;
            this.fld_txtICBarcodeReference.BOSPrivilege = null;
            this.fld_txtICBarcodeReference.BOSPropertyName = "EditValue";
            this.fld_txtICBarcodeReference.Location = new System.Drawing.Point(106, 46);
            this.fld_txtICBarcodeReference.MenuManager = this.screenToolbar;
            this.fld_txtICBarcodeReference.Name = "fld_txtICBarcodeReference";
            this.fld_txtICBarcodeReference.Properties.ReadOnly = true;
            this.fld_txtICBarcodeReference.Screen = null;
            this.fld_txtICBarcodeReference.Size = new System.Drawing.Size(146, 20);
            this.fld_txtICBarcodeReference.TabIndex = 512;
            this.fld_txtICBarcodeReference.Tag = "DC";
            // 
            // fld_medARInvoiceDesc
            // 
            this.fld_medARInvoiceDesc.BOSComment = "";
            this.fld_medARInvoiceDesc.BOSDataMember = "ICBarcodeDesc";
            this.fld_medARInvoiceDesc.BOSDataSource = "ICBarcodes";
            this.fld_medARInvoiceDesc.BOSDescription = null;
            this.fld_medARInvoiceDesc.BOSError = null;
            this.fld_medARInvoiceDesc.BOSFieldGroup = "";
            this.fld_medARInvoiceDesc.BOSFieldRelation = "";
            this.fld_medARInvoiceDesc.BOSPrivilege = "";
            this.fld_medARInvoiceDesc.BOSPropertyName = "EditValue";
            this.fld_medARInvoiceDesc.EditValue = "";
            this.fld_medARInvoiceDesc.Location = new System.Drawing.Point(106, 98);
            this.fld_medARInvoiceDesc.Name = "fld_medARInvoiceDesc";
            this.fld_medARInvoiceDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARInvoiceDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARInvoiceDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARInvoiceDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARInvoiceDesc.Screen = null;
            this.fld_medARInvoiceDesc.Size = new System.Drawing.Size(409, 40);
            this.fld_medARInvoiceDesc.TabIndex = 510;
            this.fld_medARInvoiceDesc.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel4.Location = new System.Drawing.Point(12, 100);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(40, 13);
            this.bosLabel4.TabIndex = 511;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Diễn giải";
            // 
            // fld_lblLabel25
            // 
            this.fld_lblLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel25.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel25.BOSComment = "";
            this.fld_lblLabel25.BOSDataMember = "";
            this.fld_lblLabel25.BOSDataSource = "";
            this.fld_lblLabel25.BOSDescription = null;
            this.fld_lblLabel25.BOSError = null;
            this.fld_lblLabel25.BOSFieldGroup = "";
            this.fld_lblLabel25.BOSFieldRelation = "";
            this.fld_lblLabel25.BOSPrivilege = "";
            this.fld_lblLabel25.BOSPropertyName = null;
            this.fld_lblLabel25.Location = new System.Drawing.Point(279, 49);
            this.fld_lblLabel25.Name = "fld_lblLabel25";
            this.fld_lblLabel25.Screen = null;
            this.fld_lblLabel25.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel25.TabIndex = 509;
            this.fld_lblLabel25.Tag = "";
            this.fld_lblLabel25.Text = "Tình trạng";
            // 
            // fld_lkeARInvoiceStatus1
            // 
            this.fld_lkeARInvoiceStatus1.BOSAllowAddNew = false;
            this.fld_lkeARInvoiceStatus1.BOSAllowDummy = false;
            this.fld_lkeARInvoiceStatus1.BOSComment = "";
            this.fld_lkeARInvoiceStatus1.BOSDataMember = "ICBarcodeStatus";
            this.fld_lkeARInvoiceStatus1.BOSDataSource = "ICBarcodes";
            this.fld_lkeARInvoiceStatus1.BOSDescription = null;
            this.fld_lkeARInvoiceStatus1.BOSError = null;
            this.fld_lkeARInvoiceStatus1.BOSFieldGroup = "";
            this.fld_lkeARInvoiceStatus1.BOSFieldParent = "";
            this.fld_lkeARInvoiceStatus1.BOSFieldRelation = "";
            this.fld_lkeARInvoiceStatus1.BOSPrivilege = "";
            this.fld_lkeARInvoiceStatus1.BOSPropertyName = "EditValue";
            this.fld_lkeARInvoiceStatus1.BOSSelectType = "";
            this.fld_lkeARInvoiceStatus1.BOSSelectTypeValue = "";
            this.fld_lkeARInvoiceStatus1.CurrentDisplayText = "";
            this.fld_lkeARInvoiceStatus1.Location = new System.Drawing.Point(369, 46);
            this.fld_lkeARInvoiceStatus1.Name = "fld_lkeARInvoiceStatus1";
            this.fld_lkeARInvoiceStatus1.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeARInvoiceStatus1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARInvoiceStatus1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARInvoiceStatus1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARInvoiceStatus1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARInvoiceStatus1.Properties.ColumnName = null;
            this.fld_lkeARInvoiceStatus1.Properties.NullText = "";
            this.fld_lkeARInvoiceStatus1.Properties.ReadOnly = true;
            this.fld_lkeARInvoiceStatus1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARInvoiceStatus1.Screen = null;
            this.fld_lkeARInvoiceStatus1.Size = new System.Drawing.Size(146, 20);
            this.fld_lkeARInvoiceStatus1.TabIndex = 508;
            this.fld_lkeARInvoiceStatus1.Tag = "DC";
            // 
            // fld_dteICTransferDate
            // 
            this.fld_dteICTransferDate.BOSComment = null;
            this.fld_dteICTransferDate.BOSDataMember = "ICBarcodeDate";
            this.fld_dteICTransferDate.BOSDataSource = "ICBarcodes";
            this.fld_dteICTransferDate.BOSDescription = null;
            this.fld_dteICTransferDate.BOSError = null;
            this.fld_dteICTransferDate.BOSFieldGroup = null;
            this.fld_dteICTransferDate.BOSFieldRelation = null;
            this.fld_dteICTransferDate.BOSPrivilege = null;
            this.fld_dteICTransferDate.BOSPropertyName = "EditValue";
            this.fld_dteICTransferDate.EditValue = null;
            this.fld_dteICTransferDate.Location = new System.Drawing.Point(369, 20);
            this.fld_dteICTransferDate.MenuManager = this.screenToolbar;
            this.fld_dteICTransferDate.Name = "fld_dteICTransferDate";
            this.fld_dteICTransferDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICTransferDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICTransferDate.Screen = null;
            this.fld_dteICTransferDate.Size = new System.Drawing.Size(146, 20);
            this.fld_dteICTransferDate.TabIndex = 506;
            this.fld_dteICTransferDate.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(279, 23);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(72, 13);
            this.bosLabel3.TabIndex = 507;
            this.bosLabel3.Text = "Ngày chứng từ";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(12, 75);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 505;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Nhân viên";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ICBarcodes";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Enabled = false;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(106, 72);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.ReadOnly = true;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(146, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 504;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
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
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(12, 49);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(69, 13);
            this.bosLabel6.TabIndex = 502;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Mã tham chiếu";
            // 
            // fld_txtICBarcodeNo
            // 
            this.fld_txtICBarcodeNo.BOSComment = null;
            this.fld_txtICBarcodeNo.BOSDataMember = "ICBarcodeNo";
            this.fld_txtICBarcodeNo.BOSDataSource = "ICBarcodes";
            this.fld_txtICBarcodeNo.BOSDescription = null;
            this.fld_txtICBarcodeNo.BOSError = null;
            this.fld_txtICBarcodeNo.BOSFieldGroup = null;
            this.fld_txtICBarcodeNo.BOSFieldRelation = null;
            this.fld_txtICBarcodeNo.BOSPrivilege = null;
            this.fld_txtICBarcodeNo.BOSPropertyName = "EditValue";
            this.fld_txtICBarcodeNo.Location = new System.Drawing.Point(106, 20);
            this.fld_txtICBarcodeNo.MenuManager = this.screenToolbar;
            this.fld_txtICBarcodeNo.Name = "fld_txtICBarcodeNo";
            this.fld_txtICBarcodeNo.Screen = null;
            this.fld_txtICBarcodeNo.Size = new System.Drawing.Size(146, 20);
            this.fld_txtICBarcodeNo.TabIndex = 499;
            this.fld_txtICBarcodeNo.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(12, 23);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(61, 13);
            this.bosLabel2.TabIndex = 500;
            this.bosLabel2.Text = "Mã chứng từ";
            // 
            // fld_dgcICBarcodeItems
            // 
            this.fld_dgcICBarcodeItems.BOSComment = null;
            this.fld_dgcICBarcodeItems.BOSDataMember = null;
            this.fld_dgcICBarcodeItems.BOSDataSource = "ICBarcodeItems";
            this.fld_dgcICBarcodeItems.BOSDescription = null;
            this.fld_dgcICBarcodeItems.BOSError = null;
            this.fld_dgcICBarcodeItems.BOSFieldGroup = null;
            this.fld_dgcICBarcodeItems.BOSFieldRelation = null;
            this.fld_dgcICBarcodeItems.BOSGridType = null;
            this.fld_dgcICBarcodeItems.BOSPrivilege = null;
            this.fld_dgcICBarcodeItems.BOSPropertyName = null;
            this.fld_dgcICBarcodeItems.CommodityType = "";
            this.fld_dgcICBarcodeItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcICBarcodeItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICBarcodeItems.Location = new System.Drawing.Point(2, 23);
            this.fld_dgcICBarcodeItems.MenuManager = this.screenToolbar;
            this.fld_dgcICBarcodeItems.Name = "fld_dgcICBarcodeItems";
            this.fld_dgcICBarcodeItems.PrintReport = false;
            this.fld_dgcICBarcodeItems.Screen = null;
            this.fld_dgcICBarcodeItems.Size = new System.Drawing.Size(1030, 363);
            this.fld_dgcICBarcodeItems.TabIndex = 1;
            this.fld_dgcICBarcodeItems.TabStop = false;
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
            this.bosGroupControl1.Controls.Add(this.fld_dgcICBarcodeItems);
            this.bosGroupControl1.Location = new System.Drawing.Point(0, 0);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(1034, 388);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Danh sách chi tiết";
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
            this.bosPanel1.Controls.Add(this.fld_btnPrintQRcode);
            this.bosPanel1.Controls.Add(this.fld_btnPrintBarcode);
            this.bosPanel1.Controls.Add(this.bosPanel3);
            this.bosPanel1.Controls.Add(this.bosPanel2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1040, 667);
            this.bosPanel1.TabIndex = 9;
            // 
            // fld_btnPrintQRcode
            // 
            this.fld_btnPrintQRcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnPrintQRcode.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnPrintQRcode.Appearance.Options.UseForeColor = true;
            this.fld_btnPrintQRcode.BOSComment = "";
            this.fld_btnPrintQRcode.BOSDataMember = "";
            this.fld_btnPrintQRcode.BOSDataSource = "";
            this.fld_btnPrintQRcode.BOSDescription = null;
            this.fld_btnPrintQRcode.BOSError = null;
            this.fld_btnPrintQRcode.BOSFieldGroup = "";
            this.fld_btnPrintQRcode.BOSFieldRelation = "";
            this.fld_btnPrintQRcode.BOSPrivilege = "";
            this.fld_btnPrintQRcode.BOSPropertyName = "";
            this.fld_btnPrintQRcode.Location = new System.Drawing.Point(903, 589);
            this.fld_btnPrintQRcode.Name = "fld_btnPrintQRcode";
            this.fld_btnPrintQRcode.Screen = null;
            this.fld_btnPrintQRcode.Size = new System.Drawing.Size(75, 34);
            this.fld_btnPrintQRcode.TabIndex = 9;
            this.fld_btnPrintQRcode.Tag = "";
            this.fld_btnPrintQRcode.Text = "In QR Code";
            this.fld_btnPrintQRcode.Click += new System.EventHandler(this.fld_btnPrintQRcode_Click);
            // 
            // fld_btnPrintBarcode
            // 
            this.fld_btnPrintBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnPrintBarcode.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_btnPrintBarcode.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnPrintBarcode.Appearance.Options.UseFont = true;
            this.fld_btnPrintBarcode.Appearance.Options.UseForeColor = true;
            this.fld_btnPrintBarcode.BOSComment = "";
            this.fld_btnPrintBarcode.BOSDataMember = "";
            this.fld_btnPrintBarcode.BOSDataSource = "";
            this.fld_btnPrintBarcode.BOSDescription = null;
            this.fld_btnPrintBarcode.BOSError = null;
            this.fld_btnPrintBarcode.BOSFieldGroup = "";
            this.fld_btnPrintBarcode.BOSFieldRelation = "";
            this.fld_btnPrintBarcode.BOSPrivilege = "";
            this.fld_btnPrintBarcode.BOSPropertyName = "";
            this.fld_btnPrintBarcode.Location = new System.Drawing.Point(802, 589);
            this.fld_btnPrintBarcode.Name = "fld_btnPrintBarcode";
            this.fld_btnPrintBarcode.Screen = null;
            this.fld_btnPrintBarcode.Size = new System.Drawing.Size(75, 34);
            this.fld_btnPrintBarcode.TabIndex = 8;
            this.fld_btnPrintBarcode.Tag = "";
            this.fld_btnPrintBarcode.Text = "In Barcode";
            this.fld_btnPrintBarcode.Click += new System.EventHandler(this.fld_btnPrintBarcode_Click);
            // 
            // bosPanel3
            // 
            this.bosPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosPanel3.BOSComment = null;
            this.bosPanel3.BOSDataMember = null;
            this.bosPanel3.BOSDataSource = null;
            this.bosPanel3.BOSDescription = null;
            this.bosPanel3.BOSError = null;
            this.bosPanel3.BOSFieldGroup = null;
            this.bosPanel3.BOSFieldRelation = null;
            this.bosPanel3.BOSPrivilege = null;
            this.bosPanel3.BOSPropertyName = null;
            this.bosPanel3.Controls.Add(this.bosPanel5);
            this.bosPanel3.Location = new System.Drawing.Point(0, 178);
            this.bosPanel3.Name = "bosPanel3";
            this.bosPanel3.Screen = null;
            this.bosPanel3.Size = new System.Drawing.Size(1034, 394);
            this.bosPanel3.TabIndex = 7;
            // 
            // bosPanel5
            // 
            this.bosPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosPanel5.BOSComment = null;
            this.bosPanel5.BOSDataMember = null;
            this.bosPanel5.BOSDataSource = null;
            this.bosPanel5.BOSDescription = null;
            this.bosPanel5.BOSError = null;
            this.bosPanel5.BOSFieldGroup = null;
            this.bosPanel5.BOSFieldRelation = null;
            this.bosPanel5.BOSPrivilege = null;
            this.bosPanel5.BOSPropertyName = null;
            this.bosPanel5.Controls.Add(this.bosGroupControl1);
            this.bosPanel5.Location = new System.Drawing.Point(0, 0);
            this.bosPanel5.Name = "bosPanel5";
            this.bosPanel5.Screen = null;
            this.bosPanel5.Size = new System.Drawing.Size(1034, 391);
            this.bosPanel5.TabIndex = 0;
            // 
            // bosPanel2
            // 
            this.bosPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.fld_grcGroupControl5);
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(1037, 172);
            this.bosPanel2.TabIndex = 0;
            // 
            // DMBC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1040, 667);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMBC100.IconOptions.Icon")));
            this.Name = "DMBC100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).EndInit();
            this.fld_grcGroupControl5.ResumeLayout(false);
            this.bosLine2.ResumeLayout(false);
            this.bosLine1.ResumeLayout(false);
            this.bosLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICBarcodeNumber.Properties)).EndInit();
            this.bosLine4.ResumeLayout(false);
            this.bosLine4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICBarcodeReference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARInvoiceDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARInvoiceStatus1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICBarcodeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICBarcodeItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel3.ResumeLayout(false);
            this.bosPanel5.ResumeLayout(false);
            this.bosPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSGroupControl fld_grcGroupControl5;
        private IContainer components;
        private BOSERP.Modules.Barcode.ICBarcodeItemGridControl fld_dgcICBarcodeItems;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPanel bosPanel3;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSPanel bosPanel5;
        private BOSComponent.BOSLine bosLine4;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSTextBox fld_txtICBarcodeNo;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSDateEdit fld_dteICTransferDate;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel fld_lblLabel25;
        private BOSComponent.BOSLookupEdit fld_lkeARInvoiceStatus1;
        private BOSComponent.BOSMemoEdit fld_medARInvoiceDesc;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSButton fld_btnUpdateItemBarcodeQty;
        private BOSComponent.BOSTextBox fld_txtICBarcodeNumber;
        private BOSComponent.BOSLabel bosLabel32;
        private BOSComponent.BOSButton fld_btnAddProduct;
        private BOSComponent.BOSTextBox fld_txtICBarcodeReference;
        private BOSComponent.BOSButton fld_btnPrintQRcode;
        private BOSComponent.BOSButton fld_btnPrintBarcode;
    }
}
