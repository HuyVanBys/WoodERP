using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.EquipmentReceipt.UI
{
	/// <summary>
	/// Summary description for DMER100
	/// </summary>
	partial class DMER100
	{
		private BOSComponent.BOSLabel fld_lblLabel6;
		private BOSComponent.BOSLabel fld_lblLabel7;
		private BOSComponent.BOSLabel fld_lblLabel8;
		private BOSComponent.BOSLabel fld_lblLabel9;
		private BOSComponent.BOSLabel fld_lblLabel10;
		private BOSComponent.BOSLabel fld_lblLabel11;
		private BOSComponent.BOSLabel fld_lblLabel12;
		private BOSComponent.BOSTextBox fld_txtICReceiptNo1;
		private BOSComponent.BOSDateEdit fld_dteICReceiptDate2;
		private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierID1;
		private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
		private BOSComponent.BOSTextBox fld_txtICReceiptInvoiceInNo1;
		private BOSComponent.BOSDateEdit fld_dteICReceiptInvoiceInDate;
		private BOSComponent.BOSTextBox fld_txtICReceiptExchangeRate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;


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
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteICReceiptDate2 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_APSupplierID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICReceiptInvoiceInNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteICReceiptInvoiceInDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtICReceiptExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lkeFK_ICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcReceiptItems = new BOSERP.Modules.EquipmentReceipt.ReceiptItemsGridControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_txtICReceiptDiscountFix = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICReceiptTotalCost = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICReceiptShippingExtraFee = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICReceiptShippingFee = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICReceiptTaxAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICReceiptTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICReceiptDiscountPerCent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICReceiptSubTotalCost = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICReceiptSupplierAddress = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICReceiptSupplerTaxNumber = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_medICReceiptDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeICInputVATDocumentType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptSymbol = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptPackNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeICReceiptStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_Lablel2 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_ACEInvoiceTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptVATFormNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_pteICShipmentEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dteICReceiptPaymentTermDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptInvoiceInNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptInvoiceInDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptInvoiceInDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcReceiptItems)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptShippingExtraFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptShippingFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptDiscountPerCent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptSubTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptSupplierAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptSupplerTaxNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICReceiptDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICInputVATDocumentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptSymbol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptPackNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptStatus.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACEInvoiceTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptVATFormNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICShipmentEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptPaymentTermDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptPaymentTermDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = "";
            this.fld_lblLabel6.BOSDataMember = "";
            this.fld_lblLabel6.BOSDataSource = "";
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = "";
            this.fld_lblLabel6.BOSFieldRelation = "";
            this.fld_lblLabel6.BOSPrivilege = "";
            this.fld_lblLabel6.BOSPropertyName = "";
            this.fld_lblLabel6.Location = new System.Drawing.Point(134, 15);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel6.TabIndex = 4;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Mã chứng từ";
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
            this.fld_lblLabel7.Location = new System.Drawing.Point(134, 40);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel7.TabIndex = 5;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Nhà cung cấp";
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
            this.fld_lblLabel8.BOSPropertyName = "";
            this.fld_lblLabel8.Location = new System.Drawing.Point(393, 15);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel8.TabIndex = 6;
            this.fld_lblLabel8.Tag = "";
            this.fld_lblLabel8.Text = "Ngày chứng từ";
            // 
            // fld_lblLabel9
            // 
            this.fld_lblLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel9.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel9.BOSComment = "";
            this.fld_lblLabel9.BOSDataMember = "";
            this.fld_lblLabel9.BOSDataSource = "";
            this.fld_lblLabel9.BOSDescription = null;
            this.fld_lblLabel9.BOSError = null;
            this.fld_lblLabel9.BOSFieldGroup = "";
            this.fld_lblLabel9.BOSFieldRelation = "";
            this.fld_lblLabel9.BOSPrivilege = "";
            this.fld_lblLabel9.BOSPropertyName = "";
            this.fld_lblLabel9.Location = new System.Drawing.Point(134, 118);
            this.fld_lblLabel9.Name = "fld_lblLabel9";
            this.fld_lblLabel9.Screen = null;
            this.fld_lblLabel9.Size = new System.Drawing.Size(53, 13);
            this.fld_lblLabel9.TabIndex = 7;
            this.fld_lblLabel9.Tag = "";
            this.fld_lblLabel9.Text = "Loại tiền tệ";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = "";
            this.fld_lblLabel10.BOSDataMember = "";
            this.fld_lblLabel10.BOSDataSource = "";
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = "";
            this.fld_lblLabel10.BOSFieldRelation = "";
            this.fld_lblLabel10.BOSPrivilege = "";
            this.fld_lblLabel10.BOSPropertyName = "";
            this.fld_lblLabel10.Location = new System.Drawing.Point(393, 118);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(29, 13);
            this.fld_lblLabel10.TabIndex = 8;
            this.fld_lblLabel10.Tag = "";
            this.fld_lblLabel10.Text = "Tỷ giá";
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
            this.fld_lblLabel11.BOSPropertyName = "";
            this.fld_lblLabel11.Location = new System.Drawing.Point(669, 118);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(54, 13);
            this.fld_lblLabel11.TabIndex = 9;
            this.fld_lblLabel11.Tag = "";
            this.fld_lblLabel11.Text = "Số hóa đơn";
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
            this.fld_lblLabel12.BOSPropertyName = "";
            this.fld_lblLabel12.Location = new System.Drawing.Point(669, 144);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabel12.TabIndex = 10;
            this.fld_lblLabel12.Tag = "";
            this.fld_lblLabel12.Text = "Ngày hóa đơn";
            // 
            // fld_txtICReceiptNo1
            // 
            this.fld_txtICReceiptNo1.BOSComment = "";
            this.fld_txtICReceiptNo1.BOSDataMember = "ICReceiptNo";
            this.fld_txtICReceiptNo1.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptNo1.BOSDescription = null;
            this.fld_txtICReceiptNo1.BOSError = null;
            this.fld_txtICReceiptNo1.BOSFieldGroup = "";
            this.fld_txtICReceiptNo1.BOSFieldRelation = "";
            this.fld_txtICReceiptNo1.BOSPrivilege = "";
            this.fld_txtICReceiptNo1.BOSPropertyName = "Text";
            this.fld_txtICReceiptNo1.EditValue = "";
            this.fld_txtICReceiptNo1.Location = new System.Drawing.Point(215, 11);
            this.fld_txtICReceiptNo1.Name = "fld_txtICReceiptNo1";
            this.fld_txtICReceiptNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptNo1.Screen = null;
            this.fld_txtICReceiptNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptNo1.TabIndex = 1;
            this.fld_txtICReceiptNo1.Tag = "DC";
            // 
            // fld_dteICReceiptDate2
            // 
            this.fld_dteICReceiptDate2.BOSComment = "";
            this.fld_dteICReceiptDate2.BOSDataMember = "ICReceiptDate";
            this.fld_dteICReceiptDate2.BOSDataSource = "ICReceipts";
            this.fld_dteICReceiptDate2.BOSDescription = null;
            this.fld_dteICReceiptDate2.BOSError = null;
            this.fld_dteICReceiptDate2.BOSFieldGroup = "";
            this.fld_dteICReceiptDate2.BOSFieldRelation = "";
            this.fld_dteICReceiptDate2.BOSPrivilege = "";
            this.fld_dteICReceiptDate2.BOSPropertyName = "EditValue";
            this.fld_dteICReceiptDate2.EditValue = null;
            this.fld_dteICReceiptDate2.Location = new System.Drawing.Point(491, 11);
            this.fld_dteICReceiptDate2.Name = "fld_dteICReceiptDate2";
            this.fld_dteICReceiptDate2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICReceiptDate2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICReceiptDate2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICReceiptDate2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICReceiptDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICReceiptDate2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICReceiptDate2.Screen = null;
            this.fld_dteICReceiptDate2.Size = new System.Drawing.Size(151, 20);
            this.fld_dteICReceiptDate2.TabIndex = 2;
            this.fld_dteICReceiptDate2.Tag = "DC";
            // 
            // fld_lkeFK_APSupplierID1
            // 
            this.fld_lkeFK_APSupplierID1.BOSAllowAddNew = false;
            this.fld_lkeFK_APSupplierID1.BOSAllowDummy = false;
            this.fld_lkeFK_APSupplierID1.BOSComment = "";
            this.fld_lkeFK_APSupplierID1.BOSDataMember = "FK_APSupplierID";
            this.fld_lkeFK_APSupplierID1.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_APSupplierID1.BOSDescription = null;
            this.fld_lkeFK_APSupplierID1.BOSError = null;
            this.fld_lkeFK_APSupplierID1.BOSFieldGroup = "";
            this.fld_lkeFK_APSupplierID1.BOSFieldParent = "";
            this.fld_lkeFK_APSupplierID1.BOSFieldRelation = "";
            this.fld_lkeFK_APSupplierID1.BOSPrivilege = "";
            this.fld_lkeFK_APSupplierID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APSupplierID1.BOSSelectType = "";
            this.fld_lkeFK_APSupplierID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_APSupplierID1.CurrentDisplayText = null;
            this.fld_lkeFK_APSupplierID1.Location = new System.Drawing.Point(215, 37);
            this.fld_lkeFK_APSupplierID1.Name = "fld_lkeFK_APSupplierID1";
            this.fld_lkeFK_APSupplierID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_APSupplierID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_APSupplierID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_APSupplierID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_APSupplierID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APSupplierID1.Properties.ColumnName = null;
            this.fld_lkeFK_APSupplierID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierName", "Name")});
            this.fld_lkeFK_APSupplierID1.Properties.DisplayMember = "APSupplierName";
            this.fld_lkeFK_APSupplierID1.Properties.NullText = "";
            this.fld_lkeFK_APSupplierID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_APSupplierID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APSupplierID1.Properties.ValueMember = "APSupplierID";
            this.fld_lkeFK_APSupplierID1.Screen = null;
            this.fld_lkeFK_APSupplierID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_APSupplierID1.TabIndex = 4;
            this.fld_lkeFK_APSupplierID1.Tag = "DC";
            this.fld_lkeFK_APSupplierID1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_APSupplierID1_CloseUp);
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = "";
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = "";
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = "";
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = "";
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = "";
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = "";
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = "";
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(215, 115);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Name")});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 6;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // fld_txtICReceiptInvoiceInNo1
            // 
            this.fld_txtICReceiptInvoiceInNo1.BOSComment = "";
            this.fld_txtICReceiptInvoiceInNo1.BOSDataMember = "ICReceiptInvoiceInNo";
            this.fld_txtICReceiptInvoiceInNo1.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptInvoiceInNo1.BOSDescription = null;
            this.fld_txtICReceiptInvoiceInNo1.BOSError = null;
            this.fld_txtICReceiptInvoiceInNo1.BOSFieldGroup = "";
            this.fld_txtICReceiptInvoiceInNo1.BOSFieldRelation = "";
            this.fld_txtICReceiptInvoiceInNo1.BOSPrivilege = "";
            this.fld_txtICReceiptInvoiceInNo1.BOSPropertyName = "Text";
            this.fld_txtICReceiptInvoiceInNo1.EditValue = "";
            this.fld_txtICReceiptInvoiceInNo1.Location = new System.Drawing.Point(758, 115);
            this.fld_txtICReceiptInvoiceInNo1.Name = "fld_txtICReceiptInvoiceInNo1";
            this.fld_txtICReceiptInvoiceInNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptInvoiceInNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptInvoiceInNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptInvoiceInNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptInvoiceInNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptInvoiceInNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptInvoiceInNo1.Screen = null;
            this.fld_txtICReceiptInvoiceInNo1.Size = new System.Drawing.Size(178, 20);
            this.fld_txtICReceiptInvoiceInNo1.TabIndex = 9;
            this.fld_txtICReceiptInvoiceInNo1.Tag = "DC";
            // 
            // fld_dteICReceiptInvoiceInDate
            // 
            this.fld_dteICReceiptInvoiceInDate.BOSComment = "";
            this.fld_dteICReceiptInvoiceInDate.BOSDataMember = "ICReceiptInvoiceInDate";
            this.fld_dteICReceiptInvoiceInDate.BOSDataSource = "ICReceipts";
            this.fld_dteICReceiptInvoiceInDate.BOSDescription = null;
            this.fld_dteICReceiptInvoiceInDate.BOSError = null;
            this.fld_dteICReceiptInvoiceInDate.BOSFieldGroup = "";
            this.fld_dteICReceiptInvoiceInDate.BOSFieldRelation = "";
            this.fld_dteICReceiptInvoiceInDate.BOSPrivilege = "";
            this.fld_dteICReceiptInvoiceInDate.BOSPropertyName = "EditValue";
            this.fld_dteICReceiptInvoiceInDate.EditValue = null;
            this.fld_dteICReceiptInvoiceInDate.Location = new System.Drawing.Point(758, 141);
            this.fld_dteICReceiptInvoiceInDate.Name = "fld_dteICReceiptInvoiceInDate";
            this.fld_dteICReceiptInvoiceInDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICReceiptInvoiceInDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICReceiptInvoiceInDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICReceiptInvoiceInDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICReceiptInvoiceInDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICReceiptInvoiceInDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICReceiptInvoiceInDate.Screen = null;
            this.fld_dteICReceiptInvoiceInDate.Size = new System.Drawing.Size(178, 20);
            this.fld_dteICReceiptInvoiceInDate.TabIndex = 5;
            this.fld_dteICReceiptInvoiceInDate.Tag = "DC";
            // 
            // fld_txtICReceiptExchangeRate
            // 
            this.fld_txtICReceiptExchangeRate.BOSComment = "";
            this.fld_txtICReceiptExchangeRate.BOSDataMember = "ICReceiptExchangeRate";
            this.fld_txtICReceiptExchangeRate.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptExchangeRate.BOSDescription = null;
            this.fld_txtICReceiptExchangeRate.BOSError = null;
            this.fld_txtICReceiptExchangeRate.BOSFieldGroup = "";
            this.fld_txtICReceiptExchangeRate.BOSFieldRelation = "";
            this.fld_txtICReceiptExchangeRate.BOSPrivilege = "";
            this.fld_txtICReceiptExchangeRate.BOSPropertyName = "Text";
            this.fld_txtICReceiptExchangeRate.EditValue = "";
            this.fld_txtICReceiptExchangeRate.Location = new System.Drawing.Point(491, 115);
            this.fld_txtICReceiptExchangeRate.Name = "fld_txtICReceiptExchangeRate";
            this.fld_txtICReceiptExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptExchangeRate.Properties.Mask.EditMask = "n";
            this.fld_txtICReceiptExchangeRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICReceiptExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptExchangeRate.Screen = null;
            this.fld_txtICReceiptExchangeRate.Size = new System.Drawing.Size(151, 20);
            this.fld_txtICReceiptExchangeRate.TabIndex = 7;
            this.fld_txtICReceiptExchangeRate.Tag = "DC";
            this.fld_txtICReceiptExchangeRate.Validated += new System.EventHandler(this.fld_txtICReceiptExchangeRate_Validated);
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = "";
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(11, 111);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 18;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
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
            this.bosTabControl1.Location = new System.Drawing.Point(3, 195);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(1008, 298);
            this.bosTabControl1.TabIndex = 20;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_lkeFK_ICProductID);
            this.xtraTabPage1.Controls.Add(this.bosLabel1);
            this.xtraTabPage1.Controls.Add(this.fld_dgcReceiptItems);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1002, 270);
            this.xtraTabPage1.Text = "Danh sách CCDC";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = null;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ICReceiptItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(63, 10);
            this.fld_lkeFK_ICProductID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(936, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 2;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID_KeyUp);
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
            this.bosLabel1.Location = new System.Drawing.Point(19, 13);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(28, 13);
            this.bosLabel1.TabIndex = 1;
            this.bosLabel1.Text = "CCDC";
            // 
            // fld_dgcReceiptItems
            // 
            this.fld_dgcReceiptItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcReceiptItems.BOSComment = null;
            this.fld_dgcReceiptItems.BOSDataMember = null;
            this.fld_dgcReceiptItems.BOSDataSource = "ICReceiptItems";
            this.fld_dgcReceiptItems.BOSDescription = null;
            this.fld_dgcReceiptItems.BOSError = null;
            this.fld_dgcReceiptItems.BOSFieldGroup = null;
            this.fld_dgcReceiptItems.BOSFieldRelation = null;
            this.fld_dgcReceiptItems.BOSGridType = null;
            this.fld_dgcReceiptItems.BOSPrivilege = null;
            this.fld_dgcReceiptItems.BOSPropertyName = null;
            this.fld_dgcReceiptItems.CommodityType = "";
            this.fld_dgcReceiptItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcReceiptItems.Location = new System.Drawing.Point(6, 46);
            this.fld_dgcReceiptItems.MenuManager = this.screenToolbar;
            this.fld_dgcReceiptItems.Name = "fld_dgcReceiptItems";
            this.fld_dgcReceiptItems.PrintReport = false;
            this.fld_dgcReceiptItems.Screen = null;
            this.fld_dgcReceiptItems.Size = new System.Drawing.Size(993, 221);
            this.fld_dgcReceiptItems.TabIndex = 0;
            this.fld_dgcReceiptItems.Tag = "DC";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcDocumentEntrys);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(996, 263);
            this.xtraTabPage2.Text = "Hạch toán";
            // 
            // fld_dgcDocumentEntrys
            // 
            this.fld_dgcDocumentEntrys.BOSComment = null;
            this.fld_dgcDocumentEntrys.BOSDataMember = null;
            this.fld_dgcDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcDocumentEntrys.BOSDescription = null;
            this.fld_dgcDocumentEntrys.BOSError = null;
            this.fld_dgcDocumentEntrys.BOSFieldGroup = null;
            this.fld_dgcDocumentEntrys.BOSFieldRelation = null;
            this.fld_dgcDocumentEntrys.BOSGridType = null;
            this.fld_dgcDocumentEntrys.BOSPrivilege = null;
            this.fld_dgcDocumentEntrys.BOSPropertyName = null;
            this.fld_dgcDocumentEntrys.CommodityType = "";
            this.fld_dgcDocumentEntrys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcDocumentEntrys.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcDocumentEntrys.MenuManager = this.screenToolbar;
            this.fld_dgcDocumentEntrys.Name = "fld_dgcDocumentEntrys";
            this.fld_dgcDocumentEntrys.PrintReport = false;
            this.fld_dgcDocumentEntrys.Screen = null;
            this.fld_dgcDocumentEntrys.Size = new System.Drawing.Size(996, 263);
            this.fld_dgcDocumentEntrys.TabIndex = 0;
            this.fld_dgcDocumentEntrys.Tag = "DC";
            // 
            // fld_txtICReceiptDiscountFix
            // 
            this.fld_txtICReceiptDiscountFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptDiscountFix.BOSComment = "";
            this.fld_txtICReceiptDiscountFix.BOSDataMember = "ICReceiptDiscountFix";
            this.fld_txtICReceiptDiscountFix.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptDiscountFix.BOSDescription = null;
            this.fld_txtICReceiptDiscountFix.BOSError = null;
            this.fld_txtICReceiptDiscountFix.BOSFieldGroup = "";
            this.fld_txtICReceiptDiscountFix.BOSFieldRelation = "";
            this.fld_txtICReceiptDiscountFix.BOSPrivilege = "";
            this.fld_txtICReceiptDiscountFix.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptDiscountFix.EditValue = "0.00";
            this.fld_txtICReceiptDiscountFix.Location = new System.Drawing.Point(921, 524);
            this.fld_txtICReceiptDiscountFix.Name = "fld_txtICReceiptDiscountFix";
            this.fld_txtICReceiptDiscountFix.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptDiscountFix.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptDiscountFix.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptDiscountFix.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptDiscountFix.Properties.Mask.EditMask = "n";
            this.fld_txtICReceiptDiscountFix.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICReceiptDiscountFix.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptDiscountFix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptDiscountFix.Screen = null;
            this.fld_txtICReceiptDiscountFix.Size = new System.Drawing.Size(90, 20);
            this.fld_txtICReceiptDiscountFix.TabIndex = 23;
            this.fld_txtICReceiptDiscountFix.Tag = "DC";
            this.fld_txtICReceiptDiscountFix.Validated += new System.EventHandler(this.fld_txtICReceiptDiscountFix_Validated);
            // 
            // fld_txtICReceiptTotalCost
            // 
            this.fld_txtICReceiptTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptTotalCost.BOSComment = "";
            this.fld_txtICReceiptTotalCost.BOSDataMember = "ICReceiptTotalCost";
            this.fld_txtICReceiptTotalCost.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptTotalCost.BOSDescription = null;
            this.fld_txtICReceiptTotalCost.BOSError = null;
            this.fld_txtICReceiptTotalCost.BOSFieldGroup = "";
            this.fld_txtICReceiptTotalCost.BOSFieldRelation = "";
            this.fld_txtICReceiptTotalCost.BOSPrivilege = "";
            this.fld_txtICReceiptTotalCost.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptTotalCost.EditValue = "0.00";
            this.fld_txtICReceiptTotalCost.Location = new System.Drawing.Point(843, 627);
            this.fld_txtICReceiptTotalCost.Name = "fld_txtICReceiptTotalCost";
            this.fld_txtICReceiptTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtICReceiptTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptTotalCost.Properties.Mask.EditMask = "n";
            this.fld_txtICReceiptTotalCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICReceiptTotalCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptTotalCost.Properties.ReadOnly = true;
            this.fld_txtICReceiptTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptTotalCost.Screen = null;
            this.fld_txtICReceiptTotalCost.Size = new System.Drawing.Size(168, 20);
            this.fld_txtICReceiptTotalCost.TabIndex = 28;
            this.fld_txtICReceiptTotalCost.Tag = "DC";
            // 
            // fld_txtICReceiptShippingExtraFee
            // 
            this.fld_txtICReceiptShippingExtraFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptShippingExtraFee.BOSComment = "";
            this.fld_txtICReceiptShippingExtraFee.BOSDataMember = "ICReceiptShippingExtraFees";
            this.fld_txtICReceiptShippingExtraFee.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptShippingExtraFee.BOSDescription = null;
            this.fld_txtICReceiptShippingExtraFee.BOSError = null;
            this.fld_txtICReceiptShippingExtraFee.BOSFieldGroup = "";
            this.fld_txtICReceiptShippingExtraFee.BOSFieldRelation = "";
            this.fld_txtICReceiptShippingExtraFee.BOSPrivilege = "";
            this.fld_txtICReceiptShippingExtraFee.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptShippingExtraFee.EditValue = "0.00";
            this.fld_txtICReceiptShippingExtraFee.Location = new System.Drawing.Point(843, 576);
            this.fld_txtICReceiptShippingExtraFee.Name = "fld_txtICReceiptShippingExtraFee";
            this.fld_txtICReceiptShippingExtraFee.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptShippingExtraFee.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptShippingExtraFee.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptShippingExtraFee.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptShippingExtraFee.Properties.Mask.EditMask = "n";
            this.fld_txtICReceiptShippingExtraFee.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICReceiptShippingExtraFee.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptShippingExtraFee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptShippingExtraFee.Screen = null;
            this.fld_txtICReceiptShippingExtraFee.Size = new System.Drawing.Size(168, 20);
            this.fld_txtICReceiptShippingExtraFee.TabIndex = 25;
            this.fld_txtICReceiptShippingExtraFee.Tag = "DC";
            this.fld_txtICReceiptShippingExtraFee.Validated += new System.EventHandler(this.fld_txtICReceiptShippingExtraFee_Validated);
            // 
            // fld_txtICReceiptShippingFee
            // 
            this.fld_txtICReceiptShippingFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptShippingFee.BOSComment = "";
            this.fld_txtICReceiptShippingFee.BOSDataMember = "ICReceiptShippingFees";
            this.fld_txtICReceiptShippingFee.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptShippingFee.BOSDescription = null;
            this.fld_txtICReceiptShippingFee.BOSError = null;
            this.fld_txtICReceiptShippingFee.BOSFieldGroup = "";
            this.fld_txtICReceiptShippingFee.BOSFieldRelation = "";
            this.fld_txtICReceiptShippingFee.BOSPrivilege = "";
            this.fld_txtICReceiptShippingFee.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptShippingFee.EditValue = "0.00";
            this.fld_txtICReceiptShippingFee.Location = new System.Drawing.Point(843, 550);
            this.fld_txtICReceiptShippingFee.Name = "fld_txtICReceiptShippingFee";
            this.fld_txtICReceiptShippingFee.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptShippingFee.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptShippingFee.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptShippingFee.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptShippingFee.Properties.Mask.EditMask = "n";
            this.fld_txtICReceiptShippingFee.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICReceiptShippingFee.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptShippingFee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptShippingFee.Screen = null;
            this.fld_txtICReceiptShippingFee.Size = new System.Drawing.Size(168, 20);
            this.fld_txtICReceiptShippingFee.TabIndex = 24;
            this.fld_txtICReceiptShippingFee.Tag = "DC";
            this.fld_txtICReceiptShippingFee.Validated += new System.EventHandler(this.fld_txtICReceiptShippingFee_Validated);
            // 
            // fld_txtICReceiptTaxAmount
            // 
            this.fld_txtICReceiptTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptTaxAmount.BOSComment = "";
            this.fld_txtICReceiptTaxAmount.BOSDataMember = "ICReceiptTaxAmount";
            this.fld_txtICReceiptTaxAmount.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptTaxAmount.BOSDescription = null;
            this.fld_txtICReceiptTaxAmount.BOSError = null;
            this.fld_txtICReceiptTaxAmount.BOSFieldGroup = null;
            this.fld_txtICReceiptTaxAmount.BOSFieldRelation = "";
            this.fld_txtICReceiptTaxAmount.BOSPrivilege = "";
            this.fld_txtICReceiptTaxAmount.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptTaxAmount.EditValue = "0.00";
            this.fld_txtICReceiptTaxAmount.Location = new System.Drawing.Point(921, 602);
            this.fld_txtICReceiptTaxAmount.Name = "fld_txtICReceiptTaxAmount";
            this.fld_txtICReceiptTaxAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptTaxAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptTaxAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptTaxAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptTaxAmount.Properties.Mask.EditMask = "n";
            this.fld_txtICReceiptTaxAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICReceiptTaxAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptTaxAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptTaxAmount.Screen = null;
            this.fld_txtICReceiptTaxAmount.Size = new System.Drawing.Size(90, 20);
            this.fld_txtICReceiptTaxAmount.TabIndex = 27;
            this.fld_txtICReceiptTaxAmount.Tag = "DC";
            this.fld_txtICReceiptTaxAmount.Validated += new System.EventHandler(this.fld_txtICReceiptTaxAmount_Validated);
            // 
            // fld_txtICReceiptTaxPercent
            // 
            this.fld_txtICReceiptTaxPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptTaxPercent.BOSComment = "";
            this.fld_txtICReceiptTaxPercent.BOSDataMember = "ICReceiptTaxPercent";
            this.fld_txtICReceiptTaxPercent.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptTaxPercent.BOSDescription = null;
            this.fld_txtICReceiptTaxPercent.BOSError = null;
            this.fld_txtICReceiptTaxPercent.BOSFieldGroup = "";
            this.fld_txtICReceiptTaxPercent.BOSFieldRelation = "";
            this.fld_txtICReceiptTaxPercent.BOSPrivilege = "";
            this.fld_txtICReceiptTaxPercent.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptTaxPercent.EditValue = "0.00";
            this.fld_txtICReceiptTaxPercent.Location = new System.Drawing.Point(843, 602);
            this.fld_txtICReceiptTaxPercent.Name = "fld_txtICReceiptTaxPercent";
            this.fld_txtICReceiptTaxPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptTaxPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptTaxPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptTaxPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptTaxPercent.Properties.Mask.EditMask = "n";
            this.fld_txtICReceiptTaxPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICReceiptTaxPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptTaxPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptTaxPercent.Screen = null;
            this.fld_txtICReceiptTaxPercent.Size = new System.Drawing.Size(72, 20);
            this.fld_txtICReceiptTaxPercent.TabIndex = 26;
            this.fld_txtICReceiptTaxPercent.Tag = "DC";
            this.fld_txtICReceiptTaxPercent.Validated += new System.EventHandler(this.fld_txtICReceiptTaxPercent_Validated);
            // 
            // fld_txtICReceiptDiscountPerCent
            // 
            this.fld_txtICReceiptDiscountPerCent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptDiscountPerCent.BOSComment = "";
            this.fld_txtICReceiptDiscountPerCent.BOSDataMember = "ICReceiptDiscountPerCent";
            this.fld_txtICReceiptDiscountPerCent.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptDiscountPerCent.BOSDescription = null;
            this.fld_txtICReceiptDiscountPerCent.BOSError = null;
            this.fld_txtICReceiptDiscountPerCent.BOSFieldGroup = "";
            this.fld_txtICReceiptDiscountPerCent.BOSFieldRelation = "";
            this.fld_txtICReceiptDiscountPerCent.BOSPrivilege = "";
            this.fld_txtICReceiptDiscountPerCent.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptDiscountPerCent.EditValue = "0.00";
            this.fld_txtICReceiptDiscountPerCent.Location = new System.Drawing.Point(843, 524);
            this.fld_txtICReceiptDiscountPerCent.Name = "fld_txtICReceiptDiscountPerCent";
            this.fld_txtICReceiptDiscountPerCent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptDiscountPerCent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptDiscountPerCent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptDiscountPerCent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptDiscountPerCent.Properties.Mask.EditMask = "n";
            this.fld_txtICReceiptDiscountPerCent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICReceiptDiscountPerCent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptDiscountPerCent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptDiscountPerCent.Screen = null;
            this.fld_txtICReceiptDiscountPerCent.Size = new System.Drawing.Size(72, 20);
            this.fld_txtICReceiptDiscountPerCent.TabIndex = 22;
            this.fld_txtICReceiptDiscountPerCent.Tag = "DC";
            this.fld_txtICReceiptDiscountPerCent.Validated += new System.EventHandler(this.fld_txtICReceiptDiscountPerCent_Validated);
            // 
            // fld_txtICReceiptSubTotalCost
            // 
            this.fld_txtICReceiptSubTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptSubTotalCost.BOSComment = "";
            this.fld_txtICReceiptSubTotalCost.BOSDataMember = "ICReceiptSubTotalCost";
            this.fld_txtICReceiptSubTotalCost.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptSubTotalCost.BOSDescription = null;
            this.fld_txtICReceiptSubTotalCost.BOSError = null;
            this.fld_txtICReceiptSubTotalCost.BOSFieldGroup = "";
            this.fld_txtICReceiptSubTotalCost.BOSFieldRelation = "";
            this.fld_txtICReceiptSubTotalCost.BOSPrivilege = "";
            this.fld_txtICReceiptSubTotalCost.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptSubTotalCost.EditValue = "0.00";
            this.fld_txtICReceiptSubTotalCost.Location = new System.Drawing.Point(843, 499);
            this.fld_txtICReceiptSubTotalCost.Name = "fld_txtICReceiptSubTotalCost";
            this.fld_txtICReceiptSubTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtICReceiptSubTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptSubTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptSubTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptSubTotalCost.Properties.Mask.EditMask = "n";
            this.fld_txtICReceiptSubTotalCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICReceiptSubTotalCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptSubTotalCost.Properties.ReadOnly = true;
            this.fld_txtICReceiptSubTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptSubTotalCost.Screen = null;
            this.fld_txtICReceiptSubTotalCost.Size = new System.Drawing.Size(168, 20);
            this.fld_txtICReceiptSubTotalCost.TabIndex = 21;
            this.fld_txtICReceiptSubTotalCost.Tag = "DC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLabel8.Appearance.Options.UseFont = true;
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(755, 630);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(66, 13);
            this.bosLabel8.TabIndex = 541;
            this.bosLabel8.Text = "THÀNH TIỀN";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(782, 579);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(39, 13);
            this.bosLabel12.TabIndex = 542;
            this.bosLabel12.Text = "Phí khác";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(748, 553);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(73, 13);
            this.bosLabel11.TabIndex = 543;
            this.bosLabel11.Text = "Phí vận chuyển";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(797, 605);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(24, 13);
            this.bosLabel9.TabIndex = 538;
            this.bosLabel9.Text = "Thuế";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(768, 527);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(53, 13);
            this.bosLabel7.TabIndex = 539;
            this.bosLabel7.Text = "Chiếu khấu";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(776, 502);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(45, 13);
            this.bosLabel5.TabIndex = 540;
            this.bosLabel5.Text = "Tổng tiền";
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
            this.bosLabel2.BOSPropertyName = "";
            this.bosLabel2.Location = new System.Drawing.Point(393, 40);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(18, 13);
            this.bosLabel2.TabIndex = 7;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Kho";
            // 
            // fld_lkeFK_ICStockID
            // 
            this.fld_lkeFK_ICStockID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICStockID.BOSAllowDummy = false;
            this.fld_lkeFK_ICStockID.BOSComment = null;
            this.fld_lkeFK_ICStockID.BOSDataMember = "FK_ICStockID";
            this.fld_lkeFK_ICStockID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_ICStockID.BOSDescription = null;
            this.fld_lkeFK_ICStockID.BOSError = null;
            this.fld_lkeFK_ICStockID.BOSFieldGroup = null;
            this.fld_lkeFK_ICStockID.BOSFieldParent = null;
            this.fld_lkeFK_ICStockID.BOSFieldRelation = null;
            this.fld_lkeFK_ICStockID.BOSPrivilege = null;
            this.fld_lkeFK_ICStockID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICStockID.BOSSelectType = null;
            this.fld_lkeFK_ICStockID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICStockID.CurrentDisplayText = null;
            this.fld_lkeFK_ICStockID.Location = new System.Drawing.Point(491, 37);
            this.fld_lkeFK_ICStockID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICStockID.Name = "fld_lkeFK_ICStockID";
            this.fld_lkeFK_ICStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICStockID.Properties.ColumnName = null;
            this.fld_lkeFK_ICStockID.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICStockID.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICStockID.Screen = null;
            this.fld_lkeFK_ICStockID.Size = new System.Drawing.Size(151, 20);
            this.fld_lkeFK_ICStockID.TabIndex = 13;
            this.fld_lkeFK_ICStockID.Tag = "DC";
            this.fld_lkeFK_ICStockID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICStockID_CloseUp);
            // 
            // fld_txtICReceiptSupplierAddress
            // 
            this.fld_txtICReceiptSupplierAddress.BOSComment = "";
            this.fld_txtICReceiptSupplierAddress.BOSDataMember = "ICReceiptSupplierAddress";
            this.fld_txtICReceiptSupplierAddress.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptSupplierAddress.BOSDescription = null;
            this.fld_txtICReceiptSupplierAddress.BOSError = null;
            this.fld_txtICReceiptSupplierAddress.BOSFieldGroup = "";
            this.fld_txtICReceiptSupplierAddress.BOSFieldRelation = "";
            this.fld_txtICReceiptSupplierAddress.BOSPrivilege = "";
            this.fld_txtICReceiptSupplierAddress.BOSPropertyName = "Text";
            this.fld_txtICReceiptSupplierAddress.EditValue = "";
            this.fld_txtICReceiptSupplierAddress.Location = new System.Drawing.Point(215, 89);
            this.fld_txtICReceiptSupplierAddress.Name = "fld_txtICReceiptSupplierAddress";
            this.fld_txtICReceiptSupplierAddress.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptSupplierAddress.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptSupplierAddress.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptSupplierAddress.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptSupplierAddress.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptSupplierAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptSupplierAddress.Screen = null;
            this.fld_txtICReceiptSupplierAddress.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptSupplierAddress.TabIndex = 11;
            this.fld_txtICReceiptSupplierAddress.Tag = "DC";
            // 
            // fld_txtICReceiptSupplerTaxNumber
            // 
            this.fld_txtICReceiptSupplerTaxNumber.BOSComment = "";
            this.fld_txtICReceiptSupplerTaxNumber.BOSDataMember = "ICReceiptSupplerTaxNumber";
            this.fld_txtICReceiptSupplerTaxNumber.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptSupplerTaxNumber.BOSDescription = null;
            this.fld_txtICReceiptSupplerTaxNumber.BOSError = null;
            this.fld_txtICReceiptSupplerTaxNumber.BOSFieldGroup = "";
            this.fld_txtICReceiptSupplerTaxNumber.BOSFieldRelation = "";
            this.fld_txtICReceiptSupplerTaxNumber.BOSPrivilege = "";
            this.fld_txtICReceiptSupplerTaxNumber.BOSPropertyName = "Text";
            this.fld_txtICReceiptSupplerTaxNumber.EditValue = "";
            this.fld_txtICReceiptSupplerTaxNumber.Location = new System.Drawing.Point(215, 63);
            this.fld_txtICReceiptSupplerTaxNumber.Name = "fld_txtICReceiptSupplerTaxNumber";
            this.fld_txtICReceiptSupplerTaxNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptSupplerTaxNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptSupplerTaxNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptSupplerTaxNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptSupplerTaxNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptSupplerTaxNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptSupplerTaxNumber.Screen = null;
            this.fld_txtICReceiptSupplerTaxNumber.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptSupplerTaxNumber.TabIndex = 8;
            this.fld_txtICReceiptSupplerTaxNumber.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(134, 92);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(32, 13);
            this.bosLabel6.TabIndex = 9;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Địa chỉ";
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
            this.bosLabel4.BOSPropertyName = "";
            this.bosLabel4.Location = new System.Drawing.Point(134, 66);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(20, 13);
            this.bosLabel4.TabIndex = 9;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "MST";
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
            this.bosLabel3.BOSPropertyName = "";
            this.bosLabel3.Location = new System.Drawing.Point(134, 143);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 7;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Diễn giải";
            // 
            // fld_medICReceiptDesc
            // 
            this.fld_medICReceiptDesc.BOSComment = null;
            this.fld_medICReceiptDesc.BOSDataMember = "ICReceiptDesc";
            this.fld_medICReceiptDesc.BOSDataSource = "ICReceipts";
            this.fld_medICReceiptDesc.BOSDescription = null;
            this.fld_medICReceiptDesc.BOSError = null;
            this.fld_medICReceiptDesc.BOSFieldGroup = null;
            this.fld_medICReceiptDesc.BOSFieldRelation = null;
            this.fld_medICReceiptDesc.BOSPrivilege = null;
            this.fld_medICReceiptDesc.BOSPropertyName = "EditValue";
            this.fld_medICReceiptDesc.Location = new System.Drawing.Point(215, 141);
            this.fld_medICReceiptDesc.MenuManager = this.screenToolbar;
            this.fld_medICReceiptDesc.Name = "fld_medICReceiptDesc";
            this.fld_medICReceiptDesc.Screen = null;
            this.fld_medICReceiptDesc.Size = new System.Drawing.Size(427, 46);
            this.fld_medICReceiptDesc.TabIndex = 14;
            this.fld_medICReceiptDesc.Tag = "DC";
            // 
            // fld_lkeICInputVATDocumentType
            // 
            this.fld_lkeICInputVATDocumentType.BOSAllowAddNew = false;
            this.fld_lkeICInputVATDocumentType.BOSAllowDummy = false;
            this.fld_lkeICInputVATDocumentType.BOSComment = "";
            this.fld_lkeICInputVATDocumentType.BOSDataMember = "ICInputVATDocumentType";
            this.fld_lkeICInputVATDocumentType.BOSDataSource = "ICReceipts";
            this.fld_lkeICInputVATDocumentType.BOSDescription = null;
            this.fld_lkeICInputVATDocumentType.BOSError = null;
            this.fld_lkeICInputVATDocumentType.BOSFieldGroup = "";
            this.fld_lkeICInputVATDocumentType.BOSFieldParent = "";
            this.fld_lkeICInputVATDocumentType.BOSFieldRelation = "";
            this.fld_lkeICInputVATDocumentType.BOSPrivilege = "";
            this.fld_lkeICInputVATDocumentType.BOSPropertyName = "EditValue";
            this.fld_lkeICInputVATDocumentType.BOSSelectType = "";
            this.fld_lkeICInputVATDocumentType.BOSSelectTypeValue = "";
            this.fld_lkeICInputVATDocumentType.CurrentDisplayText = null;
            this.fld_lkeICInputVATDocumentType.Location = new System.Drawing.Point(758, 11);
            this.fld_lkeICInputVATDocumentType.Name = "fld_lkeICInputVATDocumentType";
            this.fld_lkeICInputVATDocumentType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICInputVATDocumentType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICInputVATDocumentType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICInputVATDocumentType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICInputVATDocumentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICInputVATDocumentType.Properties.ColumnName = null;
            this.fld_lkeICInputVATDocumentType.Properties.NullText = "";
            this.fld_lkeICInputVATDocumentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICInputVATDocumentType.Screen = null;
            this.fld_lkeICInputVATDocumentType.Size = new System.Drawing.Size(178, 20);
            this.fld_lkeICInputVATDocumentType.TabIndex = 3;
            this.fld_lkeICInputVATDocumentType.Tag = "DC";
            // 
            // bosLabel22
            // 
            this.bosLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.Options.UseBackColor = true;
            this.bosLabel22.Appearance.Options.UseForeColor = true;
            this.bosLabel22.BOSComment = "";
            this.bosLabel22.BOSDataMember = "";
            this.bosLabel22.BOSDataSource = "";
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = "";
            this.bosLabel22.BOSFieldRelation = "";
            this.bosLabel22.BOSPrivilege = "";
            this.bosLabel22.BOSPropertyName = null;
            this.bosLabel22.Location = new System.Drawing.Point(669, 14);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(61, 13);
            this.bosLabel22.TabIndex = 545;
            this.bosLabel22.Tag = "";
            this.bosLabel22.Text = "Loại hóa đơn";
            // 
            // fld_txtICReceiptSymbol
            // 
            this.fld_txtICReceiptSymbol.BOSComment = "";
            this.fld_txtICReceiptSymbol.BOSDataMember = "ICReceiptSymbol";
            this.fld_txtICReceiptSymbol.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptSymbol.BOSDescription = null;
            this.fld_txtICReceiptSymbol.BOSError = null;
            this.fld_txtICReceiptSymbol.BOSFieldGroup = "";
            this.fld_txtICReceiptSymbol.BOSFieldRelation = "";
            this.fld_txtICReceiptSymbol.BOSPrivilege = "";
            this.fld_txtICReceiptSymbol.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptSymbol.EditValue = "";
            this.fld_txtICReceiptSymbol.Location = new System.Drawing.Point(758, 89);
            this.fld_txtICReceiptSymbol.Name = "fld_txtICReceiptSymbol";
            this.fld_txtICReceiptSymbol.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptSymbol.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptSymbol.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptSymbol.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptSymbol.Properties.Mask.EditMask = "n";
            this.fld_txtICReceiptSymbol.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptSymbol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptSymbol.Screen = null;
            this.fld_txtICReceiptSymbol.Size = new System.Drawing.Size(178, 20);
            this.fld_txtICReceiptSymbol.TabIndex = 12;
            this.fld_txtICReceiptSymbol.Tag = "DC";
            // 
            // bosLabel25
            // 
            this.bosLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.Options.UseBackColor = true;
            this.bosLabel25.Appearance.Options.UseForeColor = true;
            this.bosLabel25.BOSComment = "";
            this.bosLabel25.BOSDataMember = "";
            this.bosLabel25.BOSDataSource = "";
            this.bosLabel25.BOSDescription = null;
            this.bosLabel25.BOSError = null;
            this.bosLabel25.BOSFieldGroup = "";
            this.bosLabel25.BOSFieldRelation = "";
            this.bosLabel25.BOSPrivilege = "";
            this.bosLabel25.BOSPropertyName = null;
            this.bosLabel25.Location = new System.Drawing.Point(669, 92);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(35, 13);
            this.bosLabel25.TabIndex = 551;
            this.bosLabel25.Tag = "";
            this.bosLabel25.Text = "Ký hiệu";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(393, 66);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(52, 13);
            this.bosLabel10.TabIndex = 555;
            this.bosLabel10.Text = "Mã lô hàng";
            // 
            // fld_txtICReceiptPackNo
            // 
            this.fld_txtICReceiptPackNo.BOSComment = null;
            this.fld_txtICReceiptPackNo.BOSDataMember = "ICReceiptPackNo";
            this.fld_txtICReceiptPackNo.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptPackNo.BOSDescription = null;
            this.fld_txtICReceiptPackNo.BOSError = null;
            this.fld_txtICReceiptPackNo.BOSFieldGroup = null;
            this.fld_txtICReceiptPackNo.BOSFieldRelation = null;
            this.fld_txtICReceiptPackNo.BOSPrivilege = null;
            this.fld_txtICReceiptPackNo.BOSPropertyName = "Text";
            this.fld_txtICReceiptPackNo.Location = new System.Drawing.Point(491, 63);
            this.fld_txtICReceiptPackNo.Name = "fld_txtICReceiptPackNo";
            this.fld_txtICReceiptPackNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptPackNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptPackNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptPackNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptPackNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptPackNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptPackNo.Screen = null;
            this.fld_txtICReceiptPackNo.Size = new System.Drawing.Size(151, 20);
            this.fld_txtICReceiptPackNo.TabIndex = 15;
            this.fld_txtICReceiptPackNo.Tag = "DC";
            // 
            // fld_lkeICReceiptStatus
            // 
            this.fld_lkeICReceiptStatus.BOSAllowAddNew = false;
            this.fld_lkeICReceiptStatus.BOSAllowDummy = false;
            this.fld_lkeICReceiptStatus.BOSComment = null;
            this.fld_lkeICReceiptStatus.BOSDataMember = "ICReceiptStatus";
            this.fld_lkeICReceiptStatus.BOSDataSource = "ICReceipts";
            this.fld_lkeICReceiptStatus.BOSDescription = null;
            this.fld_lkeICReceiptStatus.BOSError = null;
            this.fld_lkeICReceiptStatus.BOSFieldGroup = null;
            this.fld_lkeICReceiptStatus.BOSFieldParent = null;
            this.fld_lkeICReceiptStatus.BOSFieldRelation = null;
            this.fld_lkeICReceiptStatus.BOSPrivilege = null;
            this.fld_lkeICReceiptStatus.BOSPropertyName = "EditValue";
            this.fld_lkeICReceiptStatus.BOSSelectType = null;
            this.fld_lkeICReceiptStatus.BOSSelectTypeValue = null;
            this.fld_lkeICReceiptStatus.CurrentDisplayText = null;
            this.fld_lkeICReceiptStatus.Location = new System.Drawing.Point(491, 89);
            this.fld_lkeICReceiptStatus.MenuManager = this.screenToolbar;
            this.fld_lkeICReceiptStatus.Name = "fld_lkeICReceiptStatus";
            this.fld_lkeICReceiptStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICReceiptStatus.Properties.ColumnName = null;
            this.fld_lkeICReceiptStatus.Properties.ReadOnly = true;
            this.fld_lkeICReceiptStatus.Screen = null;
            this.fld_lkeICReceiptStatus.Size = new System.Drawing.Size(151, 20);
            this.fld_lkeICReceiptStatus.TabIndex = 16;
            this.fld_lkeICReceiptStatus.Tag = "DC";
            // 
            // fld_Lablel2
            // 
            this.fld_Lablel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel2.Appearance.Options.UseBackColor = true;
            this.fld_Lablel2.Appearance.Options.UseForeColor = true;
            this.fld_Lablel2.BOSComment = null;
            this.fld_Lablel2.BOSDataMember = null;
            this.fld_Lablel2.BOSDataSource = null;
            this.fld_Lablel2.BOSDescription = null;
            this.fld_Lablel2.BOSError = null;
            this.fld_Lablel2.BOSFieldGroup = null;
            this.fld_Lablel2.BOSFieldRelation = null;
            this.fld_Lablel2.BOSPrivilege = null;
            this.fld_Lablel2.BOSPropertyName = null;
            this.fld_Lablel2.Location = new System.Drawing.Point(393, 92);
            this.fld_Lablel2.Name = "fld_Lablel2";
            this.fld_Lablel2.Screen = null;
            this.fld_Lablel2.Size = new System.Drawing.Size(49, 13);
            this.fld_Lablel2.TabIndex = 557;
            this.fld_Lablel2.Text = "Tình trạng";
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACEInvoiceTypeID);
            this.bosPanel1.Controls.Add(this.bosLabel17);
            this.bosPanel1.Controls.Add(this.bosLabel24);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptVATFormNo);
            this.bosPanel1.Controls.Add(this.fld_pteICShipmentEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_dteICReceiptPaymentTermDate);
            this.bosPanel1.Controls.Add(this.bosLabel13);
            this.bosPanel1.Controls.Add(this.fld_Lablel2);
            this.bosPanel1.Controls.Add(this.fld_lkeICReceiptStatus);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptPackNo);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.bosLabel25);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptSymbol);
            this.bosPanel1.Controls.Add(this.bosLabel22);
            this.bosPanel1.Controls.Add(this.fld_lkeICInputVATDocumentType);
            this.bosPanel1.Controls.Add(this.fld_medICReceiptDesc);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptExchangeRate);
            this.bosPanel1.Controls.Add(this.fld_dteICReceiptInvoiceInDate);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICStockID);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptSupplierAddress);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptSupplerTaxNumber);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptInvoiceInNo1);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptDiscountFix);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_APSupplierID1);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptTotalCost);
            this.bosPanel1.Controls.Add(this.fld_dteICReceiptDate2);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptShippingExtraFee);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptNo1);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptShippingFee);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_lblLabel6);
            this.bosPanel1.Controls.Add(this.fld_lblLabel12);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptTaxAmount);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lblLabel11);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptTaxPercent);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.fld_lblLabel7);
            this.bosPanel1.Controls.Add(this.fld_lblLabel10);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptDiscountPerCent);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_lblLabel8);
            this.bosPanel1.Controls.Add(this.fld_lblLabel9);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptSubTotalCost);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1020, 665);
            this.bosPanel1.TabIndex = 545;
            // 
            // fld_lkeFK_ACEInvoiceTypeID
            // 
            this.fld_lkeFK_ACEInvoiceTypeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACEInvoiceTypeID.BOSAllowDummy = false;
            this.fld_lkeFK_ACEInvoiceTypeID.BOSComment = "";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSDataMember = "FK_ACEInvoiceTypeID";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSDescription = null;
            this.fld_lkeFK_ACEInvoiceTypeID.BOSError = null;
            this.fld_lkeFK_ACEInvoiceTypeID.BOSFieldGroup = "";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSFieldParent = "";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSFieldRelation = "";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSPrivilege = "";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSSelectType = "ACEInvoiceTypeCombo";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSSelectTypeValue = "Purchase";
            this.fld_lkeFK_ACEInvoiceTypeID.CurrentDisplayText = "";
            this.fld_lkeFK_ACEInvoiceTypeID.Location = new System.Drawing.Point(758, 37);
            this.fld_lkeFK_ACEInvoiceTypeID.Name = "fld_lkeFK_ACEInvoiceTypeID";
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.ColumnName = null;
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACEInvoiceTypeNo", "Mã hóa đơn GTGT")});
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.DisplayMember = "ACEInvoiceTypeNo";
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.NullText = "";
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACEInvoiceTypeID.Properties.ValueMember = "ACEInvoiceTypeID";
            this.fld_lkeFK_ACEInvoiceTypeID.Screen = null;
            this.fld_lkeFK_ACEInvoiceTypeID.Size = new System.Drawing.Size(178, 20);
            this.fld_lkeFK_ACEInvoiceTypeID.TabIndex = 648;
            this.fld_lkeFK_ACEInvoiceTypeID.Tag = "DC";
            this.fld_lkeFK_ACEInvoiceTypeID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACEInvoiceTypeID_CloseUp);
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = "";
            this.bosLabel17.BOSDataMember = "";
            this.bosLabel17.BOSDataSource = "";
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = "";
            this.bosLabel17.BOSFieldRelation = "";
            this.bosLabel17.BOSPrivilege = "";
            this.bosLabel17.BOSPropertyName = "";
            this.bosLabel17.Location = new System.Drawing.Point(669, 40);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(85, 13);
            this.bosLabel17.TabIndex = 651;
            this.bosLabel17.Tag = "";
            this.bosLabel17.Text = "Mã hóa đơn GTGT";
            // 
            // bosLabel24
            // 
            this.bosLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.Options.UseBackColor = true;
            this.bosLabel24.Appearance.Options.UseForeColor = true;
            this.bosLabel24.BOSComment = "";
            this.bosLabel24.BOSDataMember = "";
            this.bosLabel24.BOSDataSource = "";
            this.bosLabel24.BOSDescription = null;
            this.bosLabel24.BOSError = null;
            this.bosLabel24.BOSFieldGroup = "";
            this.bosLabel24.BOSFieldRelation = "";
            this.bosLabel24.BOSPrivilege = "";
            this.bosLabel24.BOSPropertyName = null;
            this.bosLabel24.Location = new System.Drawing.Point(669, 66);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(34, 13);
            this.bosLabel24.TabIndex = 650;
            this.bosLabel24.Tag = "";
            this.bosLabel24.Text = "Mẫu số";
            // 
            // fld_txtICReceiptVATFormNo
            // 
            this.fld_txtICReceiptVATFormNo.BOSComment = "";
            this.fld_txtICReceiptVATFormNo.BOSDataMember = "ICReceiptVATFormNo";
            this.fld_txtICReceiptVATFormNo.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptVATFormNo.BOSDescription = null;
            this.fld_txtICReceiptVATFormNo.BOSError = null;
            this.fld_txtICReceiptVATFormNo.BOSFieldGroup = "";
            this.fld_txtICReceiptVATFormNo.BOSFieldRelation = "";
            this.fld_txtICReceiptVATFormNo.BOSPrivilege = "";
            this.fld_txtICReceiptVATFormNo.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptVATFormNo.EditValue = "";
            this.fld_txtICReceiptVATFormNo.Location = new System.Drawing.Point(758, 63);
            this.fld_txtICReceiptVATFormNo.Name = "fld_txtICReceiptVATFormNo";
            this.fld_txtICReceiptVATFormNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptVATFormNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptVATFormNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptVATFormNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptVATFormNo.Properties.Mask.EditMask = "n";
            this.fld_txtICReceiptVATFormNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptVATFormNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptVATFormNo.Screen = null;
            this.fld_txtICReceiptVATFormNo.Size = new System.Drawing.Size(178, 20);
            this.fld_txtICReceiptVATFormNo.TabIndex = 649;
            this.fld_txtICReceiptVATFormNo.Tag = "DC";
            // 
            // fld_pteICShipmentEmployeePicture
            // 
            this.fld_pteICShipmentEmployeePicture.BOSComment = null;
            this.fld_pteICShipmentEmployeePicture.BOSDataMember = "ICReceiptEmployeePicture";
            this.fld_pteICShipmentEmployeePicture.BOSDataSource = "ICReceipts";
            this.fld_pteICShipmentEmployeePicture.BOSDescription = null;
            this.fld_pteICShipmentEmployeePicture.BOSError = null;
            this.fld_pteICShipmentEmployeePicture.BOSFieldGroup = null;
            this.fld_pteICShipmentEmployeePicture.BOSFieldRelation = null;
            this.fld_pteICShipmentEmployeePicture.BOSPrivilege = null;
            this.fld_pteICShipmentEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteICShipmentEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteICShipmentEmployeePicture.FileName = null;
            this.fld_pteICShipmentEmployeePicture.FilePath = null;
            this.fld_pteICShipmentEmployeePicture.Location = new System.Drawing.Point(11, 9);
            this.fld_pteICShipmentEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteICShipmentEmployeePicture.Name = "fld_pteICShipmentEmployeePicture";
            this.fld_pteICShipmentEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICShipmentEmployeePicture.Screen = null;
            this.fld_pteICShipmentEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteICShipmentEmployeePicture.TabIndex = 559;
            this.fld_pteICShipmentEmployeePicture.Tag = "DC";
            // 
            // fld_dteICReceiptPaymentTermDate
            // 
            this.fld_dteICReceiptPaymentTermDate.BOSComment = "";
            this.fld_dteICReceiptPaymentTermDate.BOSDataMember = "ICReceiptPaymentTermDate";
            this.fld_dteICReceiptPaymentTermDate.BOSDataSource = "ICReceipts";
            this.fld_dteICReceiptPaymentTermDate.BOSDescription = null;
            this.fld_dteICReceiptPaymentTermDate.BOSError = null;
            this.fld_dteICReceiptPaymentTermDate.BOSFieldGroup = "";
            this.fld_dteICReceiptPaymentTermDate.BOSFieldRelation = "";
            this.fld_dteICReceiptPaymentTermDate.BOSPrivilege = "";
            this.fld_dteICReceiptPaymentTermDate.BOSPropertyName = "EditValue";
            this.fld_dteICReceiptPaymentTermDate.EditValue = null;
            this.fld_dteICReceiptPaymentTermDate.Location = new System.Drawing.Point(758, 167);
            this.fld_dteICReceiptPaymentTermDate.Name = "fld_dteICReceiptPaymentTermDate";
            this.fld_dteICReceiptPaymentTermDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICReceiptPaymentTermDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICReceiptPaymentTermDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICReceiptPaymentTermDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICReceiptPaymentTermDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICReceiptPaymentTermDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICReceiptPaymentTermDate.Screen = null;
            this.fld_dteICReceiptPaymentTermDate.Size = new System.Drawing.Size(178, 20);
            this.fld_dteICReceiptPaymentTermDate.TabIndex = 10;
            this.fld_dteICReceiptPaymentTermDate.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = "";
            this.bosLabel13.BOSDataMember = "";
            this.bosLabel13.BOSDataSource = "";
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = "";
            this.bosLabel13.BOSFieldRelation = "";
            this.bosLabel13.BOSPrivilege = "";
            this.bosLabel13.BOSPropertyName = "";
            this.bosLabel13.Location = new System.Drawing.Point(669, 170);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(75, 13);
            this.bosLabel13.TabIndex = 558;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "Hạn thanh toán";
            // 
            // DMER100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1020, 665);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMER100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptInvoiceInNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptInvoiceInDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptInvoiceInDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcReceiptItems)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptShippingExtraFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptShippingFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptDiscountPerCent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptSubTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptSupplierAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptSupplerTaxNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICReceiptDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICInputVATDocumentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptSymbol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptPackNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptStatus.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACEInvoiceTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptVATFormNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICShipmentEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptPaymentTermDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptPaymentTermDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPictureEdit fld_pteICReceiptEmployeePicture;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSTextBox fld_txtICReceiptDiscountFix;
        private BOSComponent.BOSTextBox fld_txtICReceiptTotalCost;
        private BOSComponent.BOSTextBox fld_txtICReceiptShippingExtraFee;
        private BOSComponent.BOSTextBox fld_txtICReceiptShippingFee;
        private BOSComponent.BOSTextBox fld_txtICReceiptTaxAmount;
        private BOSComponent.BOSTextBox fld_txtICReceiptTaxPercent;
        private BOSComponent.BOSTextBox fld_txtICReceiptDiscountPerCent;
        private BOSComponent.BOSTextBox fld_txtICReceiptSubTotalCost;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel5;
        private ReceiptItemsGridControl fld_dgcReceiptItems;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLabel bosLabel1;
        private BaseDocumentEntryGridControl fld_dgcDocumentEntrys;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtICReceiptSupplierAddress;
        private BOSComponent.BOSTextBox fld_txtICReceiptSupplerTaxNumber;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSMemoEdit fld_medICReceiptDesc;
        private BOSComponent.BOSLookupEdit fld_lkeICInputVATDocumentType;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSTextBox fld_txtICReceiptSymbol;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSTextBox fld_txtICReceiptPackNo;
        private BOSComponent.BOSLookupEdit fld_lkeICReceiptStatus;
        private BOSComponent.BOSLabel fld_Lablel2;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSDateEdit fld_dteICReceiptPaymentTermDate;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSPictureEdit fld_pteICShipmentEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACEInvoiceTypeID;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSTextBox fld_txtICReceiptVATFormNo;
    }
}
