using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AssetIncreasing.UI
{
	/// <summary>
	/// Summary description for DMER100
	/// </summary>
	partial class DMAI100
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
            this.fld_pteICReceiptEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lkeFK_ICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcReceiptItems = new BOSERP.Modules.AssetIncreasing.ReceiptItemsGridControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_medICReceiptDesc = new BOSComponent.BOSMemoEdit(this.components);
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
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_Lablel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICReceiptStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICReceiptPackNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICInputVATInvoiceNoCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptSymbol = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptFormNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICInputVATDocumentType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptInvoiceInNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptInvoiceInDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptInvoiceInDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcReceiptItems)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICReceiptDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptShippingExtraFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptShippingFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptDiscountPerCent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptSubTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptPackNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICInputVATInvoiceNoCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptSymbol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptFormNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICInputVATDocumentType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.Location = new System.Drawing.Point(134, 15);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel6.TabIndex = 4;
            this.fld_lblLabel6.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.Text = "Mã chứng từ";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.Location = new System.Drawing.Point(134, 40);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel7.TabIndex = 5;
            this.fld_lblLabel7.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.Text = "Nhà cung cấp";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.Location = new System.Drawing.Point(393, 15);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel8.TabIndex = 6;
            this.fld_lblLabel8.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.Text = "Ngày chứng từ";
            // 
            // fld_lblLabel9
            // 
            this.fld_lblLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel9.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel9.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel9.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel9.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel9.BOSDescription = null;
            this.fld_lblLabel9.BOSError = null;
            this.fld_lblLabel9.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel9.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel9.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel9.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel9.Location = new System.Drawing.Point(393, 66);
            this.fld_lblLabel9.Name = "fld_lblLabel9";
            this.fld_lblLabel9.Screen = null;
            this.fld_lblLabel9.Size = new System.Drawing.Size(53, 13);
            this.fld_lblLabel9.TabIndex = 7;
            this.fld_lblLabel9.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel9.Text = "Loại tiền tệ";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel10.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel10.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel10.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel10.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel10.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel10.Location = new System.Drawing.Point(393, 92);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(29, 13);
            this.fld_lblLabel10.TabIndex = 8;
            this.fld_lblLabel10.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel10.Text = "Tỷ giá";
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.Location = new System.Drawing.Point(393, 40);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(54, 13);
            this.fld_lblLabel11.TabIndex = 9;
            this.fld_lblLabel11.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.Text = "Số hóa đơn";
            // 
            // fld_lblLabel12
            // 
            this.fld_lblLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel12.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel12.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSDescription = null;
            this.fld_lblLabel12.BOSError = null;
            this.fld_lblLabel12.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.Location = new System.Drawing.Point(134, 92);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabel12.TabIndex = 10;
            this.fld_lblLabel12.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.Text = "Ngày hóa đơn";
            this.fld_lblLabel12.Click += new System.EventHandler(this.fld_lblLabel12_Click);
            // 
            // fld_txtICReceiptNo1
            // 
            this.fld_txtICReceiptNo1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptNo1.BOSDataMember = "ICReceiptNo";
            this.fld_txtICReceiptNo1.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptNo1.BOSDescription = null;
            this.fld_txtICReceiptNo1.BOSError = null;
            this.fld_txtICReceiptNo1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptNo1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptNo1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptNo1.BOSPropertyName = "Text";
            this.fld_txtICReceiptNo1.EditValue = global::Localization.ReportLocalizedResources.String1;
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
            this.fld_dteICReceiptDate2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICReceiptDate2.BOSDataMember = "ICReceiptDate";
            this.fld_dteICReceiptDate2.BOSDataSource = "ICReceipts";
            this.fld_dteICReceiptDate2.BOSDescription = null;
            this.fld_dteICReceiptDate2.BOSError = null;
            this.fld_dteICReceiptDate2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICReceiptDate2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICReceiptDate2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
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
            this.fld_dteICReceiptDate2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICReceiptDate2.Screen = null;
            this.fld_dteICReceiptDate2.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICReceiptDate2.TabIndex = 2;
            this.fld_dteICReceiptDate2.Tag = "DC";
            // 
            // fld_lkeFK_APSupplierID1
            // 
            this.fld_lkeFK_APSupplierID1.BOSAllowAddNew = false;
            this.fld_lkeFK_APSupplierID1.BOSAllowDummy = false;
            this.fld_lkeFK_APSupplierID1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID1.BOSDataMember = "FK_APSupplierID";
            this.fld_lkeFK_APSupplierID1.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_APSupplierID1.BOSDescription = null;
            this.fld_lkeFK_APSupplierID1.BOSError = null;
            this.fld_lkeFK_APSupplierID1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID1.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APSupplierID1.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID1.CurrentDisplayText = null;
            this.fld_lkeFK_APSupplierID1.Location = new System.Drawing.Point(215, 37);
            this.fld_lkeFK_APSupplierID1.Name = "fld_lkeFK_APSupplierID1";
            this.fld_lkeFK_APSupplierID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_APSupplierID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_APSupplierID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_APSupplierID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_APSupplierID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APSupplierID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierNo", "Mã NCC", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierName", "Tên NCC")});
            this.fld_lkeFK_APSupplierID1.Properties.DisplayMember = "APSupplierName";
            this.fld_lkeFK_APSupplierID1.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_APSupplierID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APSupplierID1.Properties.ValueMember = "APSupplierID";
            this.fld_lkeFK_APSupplierID1.Screen = null;
            this.fld_lkeFK_APSupplierID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_APSupplierID1.TabIndex = 3;
            this.fld_lkeFK_APSupplierID1.Tag = "DC";
            this.fld_lkeFK_APSupplierID1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_APSupplierID1_CloseUp);
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(491, 63);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyNo", "Mã", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Tên")});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 7;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // fld_txtICReceiptInvoiceInNo1
            // 
            this.fld_txtICReceiptInvoiceInNo1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptInvoiceInNo1.BOSDataMember = "ICReceiptInvoiceInNo";
            this.fld_txtICReceiptInvoiceInNo1.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptInvoiceInNo1.BOSDescription = null;
            this.fld_txtICReceiptInvoiceInNo1.BOSError = null;
            this.fld_txtICReceiptInvoiceInNo1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptInvoiceInNo1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptInvoiceInNo1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptInvoiceInNo1.BOSPropertyName = "Text";
            this.fld_txtICReceiptInvoiceInNo1.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptInvoiceInNo1.Location = new System.Drawing.Point(491, 37);
            this.fld_txtICReceiptInvoiceInNo1.Name = "fld_txtICReceiptInvoiceInNo1";
            this.fld_txtICReceiptInvoiceInNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptInvoiceInNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptInvoiceInNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptInvoiceInNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptInvoiceInNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptInvoiceInNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptInvoiceInNo1.Screen = null;
            this.fld_txtICReceiptInvoiceInNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptInvoiceInNo1.TabIndex = 4;
            this.fld_txtICReceiptInvoiceInNo1.Tag = "DC";
            // 
            // fld_dteICReceiptInvoiceInDate
            // 
            this.fld_dteICReceiptInvoiceInDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICReceiptInvoiceInDate.BOSDataMember = "ICReceiptInvoiceInDate";
            this.fld_dteICReceiptInvoiceInDate.BOSDataSource = "ICReceipts";
            this.fld_dteICReceiptInvoiceInDate.BOSDescription = null;
            this.fld_dteICReceiptInvoiceInDate.BOSError = null;
            this.fld_dteICReceiptInvoiceInDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICReceiptInvoiceInDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICReceiptInvoiceInDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteICReceiptInvoiceInDate.BOSPropertyName = "EditValue";
            this.fld_dteICReceiptInvoiceInDate.EditValue = null;
            this.fld_dteICReceiptInvoiceInDate.Location = new System.Drawing.Point(215, 89);
            this.fld_dteICReceiptInvoiceInDate.Name = "fld_dteICReceiptInvoiceInDate";
            this.fld_dteICReceiptInvoiceInDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICReceiptInvoiceInDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICReceiptInvoiceInDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICReceiptInvoiceInDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICReceiptInvoiceInDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICReceiptInvoiceInDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICReceiptInvoiceInDate.Screen = null;
            this.fld_dteICReceiptInvoiceInDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICReceiptInvoiceInDate.TabIndex = 5;
            this.fld_dteICReceiptInvoiceInDate.Tag = "DC";
            // 
            // fld_txtICReceiptExchangeRate
            // 
            this.fld_txtICReceiptExchangeRate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptExchangeRate.BOSDataMember = "ICReceiptExchangeRate";
            this.fld_txtICReceiptExchangeRate.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptExchangeRate.BOSDescription = null;
            this.fld_txtICReceiptExchangeRate.BOSError = null;
            this.fld_txtICReceiptExchangeRate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptExchangeRate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptExchangeRate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptExchangeRate.BOSPropertyName = "Text";
            this.fld_txtICReceiptExchangeRate.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptExchangeRate.Location = new System.Drawing.Point(491, 90);
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
            this.fld_txtICReceiptExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptExchangeRate.TabIndex = 8;
            this.fld_txtICReceiptExchangeRate.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(3, 103);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 18;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
            // 
            // fld_pteICReceiptEmployeePicture
            // 
            this.fld_pteICReceiptEmployeePicture.BOSComment = null;
            this.fld_pteICReceiptEmployeePicture.BOSDataMember = "ICReceiptEmployeePicture";
            this.fld_pteICReceiptEmployeePicture.BOSDataSource = "ICReceipts";
            this.fld_pteICReceiptEmployeePicture.BOSDescription = null;
            this.fld_pteICReceiptEmployeePicture.BOSError = null;
            this.fld_pteICReceiptEmployeePicture.BOSFieldGroup = null;
            this.fld_pteICReceiptEmployeePicture.BOSFieldRelation = null;
            this.fld_pteICReceiptEmployeePicture.BOSPrivilege = null;
            this.fld_pteICReceiptEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteICReceiptEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteICReceiptEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteICReceiptEmployeePicture.Name = "fld_pteICReceiptEmployeePicture";
            this.fld_pteICReceiptEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICReceiptEmployeePicture.Screen = null;
            this.fld_pteICReceiptEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteICReceiptEmployeePicture.TabIndex = 19;
            this.fld_pteICReceiptEmployeePicture.Tag = "DC";
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
            this.bosTabControl1.Location = new System.Drawing.Point(3, 168);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(909, 289);
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
            this.xtraTabPage1.Size = new System.Drawing.Size(902, 260);
            this.xtraTabPage1.Text = "Danh sách sản phẩm";
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
            this.fld_lkeFK_ICProductID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(63, 10);
            this.fld_lkeFK_ICProductID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên Sản Phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(836, 20);
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
            this.bosLabel1.Location = new System.Drawing.Point(10, 13);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(47, 13);
            this.bosLabel1.TabIndex = 1;
            this.bosLabel1.Text = "Sản phẩm";
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
            this.fld_dgcReceiptItems.Location = new System.Drawing.Point(6, 46);
            this.fld_dgcReceiptItems.MenuManager = this.screenToolbar;
            this.fld_dgcReceiptItems.Name = "fld_dgcReceiptItems";
            this.fld_dgcReceiptItems.PrintReport = false;
            this.fld_dgcReceiptItems.Screen = null;
            this.fld_dgcReceiptItems.Size = new System.Drawing.Size(893, 211);
            this.fld_dgcReceiptItems.TabIndex = 0;
            this.fld_dgcReceiptItems.Tag = "DC";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcDocumentEntrys);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(902, 260);
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
            this.fld_dgcDocumentEntrys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcDocumentEntrys.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcDocumentEntrys.MenuManager = this.screenToolbar;
            this.fld_dgcDocumentEntrys.Name = "fld_dgcDocumentEntrys";
            this.fld_dgcDocumentEntrys.PrintReport = false;
            this.fld_dgcDocumentEntrys.Screen = null;
            this.fld_dgcDocumentEntrys.Size = new System.Drawing.Size(902, 260);
            this.fld_dgcDocumentEntrys.TabIndex = 0;
            this.fld_dgcDocumentEntrys.Tag = "DC";
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
            this.fld_medICReceiptDesc.Location = new System.Drawing.Point(215, 116);
            this.fld_medICReceiptDesc.MenuManager = this.screenToolbar;
            this.fld_medICReceiptDesc.Name = "fld_medICReceiptDesc";
            this.fld_medICReceiptDesc.Screen = null;
            this.fld_medICReceiptDesc.Size = new System.Drawing.Size(426, 46);
            this.fld_medICReceiptDesc.TabIndex = 9;
            this.fld_medICReceiptDesc.Tag = "DC";
            // 
            // fld_txtICReceiptDiscountFix
            // 
            this.fld_txtICReceiptDiscountFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptDiscountFix.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptDiscountFix.BOSDataMember = "ICReceiptDiscountFix";
            this.fld_txtICReceiptDiscountFix.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptDiscountFix.BOSDescription = null;
            this.fld_txtICReceiptDiscountFix.BOSError = null;
            this.fld_txtICReceiptDiscountFix.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptDiscountFix.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptDiscountFix.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptDiscountFix.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptDiscountFix.EditValue = "0.00";
            this.fld_txtICReceiptDiscountFix.Location = new System.Drawing.Point(822, 496);
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
            this.fld_txtICReceiptDiscountFix.TabIndex = 14;
            this.fld_txtICReceiptDiscountFix.Tag = "DC";
            this.fld_txtICReceiptDiscountFix.Validated += new System.EventHandler(this.fld_txtICReceiptDiscountFix_Validated);
            // 
            // fld_txtICReceiptTotalCost
            // 
            this.fld_txtICReceiptTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptTotalCost.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptTotalCost.BOSDataMember = "ICReceiptTotalCost";
            this.fld_txtICReceiptTotalCost.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptTotalCost.BOSDescription = null;
            this.fld_txtICReceiptTotalCost.BOSError = null;
            this.fld_txtICReceiptTotalCost.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptTotalCost.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptTotalCost.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptTotalCost.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptTotalCost.EditValue = "0.00";
            this.fld_txtICReceiptTotalCost.Location = new System.Drawing.Point(744, 599);
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
            this.fld_txtICReceiptTotalCost.TabIndex = 19;
            this.fld_txtICReceiptTotalCost.Tag = "DC";
            // 
            // fld_txtICReceiptShippingExtraFee
            // 
            this.fld_txtICReceiptShippingExtraFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptShippingExtraFee.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptShippingExtraFee.BOSDataMember = "ICReceiptShippingExtraFees";
            this.fld_txtICReceiptShippingExtraFee.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptShippingExtraFee.BOSDescription = null;
            this.fld_txtICReceiptShippingExtraFee.BOSError = null;
            this.fld_txtICReceiptShippingExtraFee.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptShippingExtraFee.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptShippingExtraFee.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptShippingExtraFee.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptShippingExtraFee.EditValue = "0.00";
            this.fld_txtICReceiptShippingExtraFee.Location = new System.Drawing.Point(744, 548);
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
            this.fld_txtICReceiptShippingExtraFee.TabIndex = 16;
            this.fld_txtICReceiptShippingExtraFee.Tag = "DC";
            this.fld_txtICReceiptShippingExtraFee.Validated += new System.EventHandler(this.fld_txtICReceiptShippingExtraFee_Validated);
            // 
            // fld_txtICReceiptShippingFee
            // 
            this.fld_txtICReceiptShippingFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptShippingFee.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptShippingFee.BOSDataMember = "ICReceiptShippingFees";
            this.fld_txtICReceiptShippingFee.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptShippingFee.BOSDescription = null;
            this.fld_txtICReceiptShippingFee.BOSError = null;
            this.fld_txtICReceiptShippingFee.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptShippingFee.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptShippingFee.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptShippingFee.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptShippingFee.EditValue = "0.00";
            this.fld_txtICReceiptShippingFee.Location = new System.Drawing.Point(744, 522);
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
            this.fld_txtICReceiptShippingFee.TabIndex = 15;
            this.fld_txtICReceiptShippingFee.Tag = "DC";
            this.fld_txtICReceiptShippingFee.Validated += new System.EventHandler(this.fld_txtICReceiptShippingFee_Validated);
            // 
            // fld_txtICReceiptTaxAmount
            // 
            this.fld_txtICReceiptTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptTaxAmount.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptTaxAmount.BOSDataMember = "ICReceiptTaxAmount";
            this.fld_txtICReceiptTaxAmount.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptTaxAmount.BOSDescription = null;
            this.fld_txtICReceiptTaxAmount.BOSError = null;
            this.fld_txtICReceiptTaxAmount.BOSFieldGroup = null;
            this.fld_txtICReceiptTaxAmount.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptTaxAmount.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptTaxAmount.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptTaxAmount.EditValue = "0.00";
            this.fld_txtICReceiptTaxAmount.Location = new System.Drawing.Point(822, 574);
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
            this.fld_txtICReceiptTaxAmount.TabIndex = 18;
            this.fld_txtICReceiptTaxAmount.Tag = "DC";
            this.fld_txtICReceiptTaxAmount.Validated += new System.EventHandler(this.fld_txtICReceiptTaxAmount_Validated);
            // 
            // fld_txtICReceiptTaxPercent
            // 
            this.fld_txtICReceiptTaxPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptTaxPercent.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptTaxPercent.BOSDataMember = "ICReceiptTaxPercent";
            this.fld_txtICReceiptTaxPercent.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptTaxPercent.BOSDescription = null;
            this.fld_txtICReceiptTaxPercent.BOSError = null;
            this.fld_txtICReceiptTaxPercent.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptTaxPercent.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptTaxPercent.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptTaxPercent.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptTaxPercent.EditValue = "0.00";
            this.fld_txtICReceiptTaxPercent.Location = new System.Drawing.Point(744, 574);
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
            this.fld_txtICReceiptTaxPercent.TabIndex = 17;
            this.fld_txtICReceiptTaxPercent.Tag = "DC";
            this.fld_txtICReceiptTaxPercent.Validated += new System.EventHandler(this.fld_txtICReceiptTaxPercent_Validated);
            // 
            // fld_txtICReceiptDiscountPerCent
            // 
            this.fld_txtICReceiptDiscountPerCent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptDiscountPerCent.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptDiscountPerCent.BOSDataMember = "ICReceiptDiscountPerCent";
            this.fld_txtICReceiptDiscountPerCent.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptDiscountPerCent.BOSDescription = null;
            this.fld_txtICReceiptDiscountPerCent.BOSError = null;
            this.fld_txtICReceiptDiscountPerCent.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptDiscountPerCent.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptDiscountPerCent.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptDiscountPerCent.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptDiscountPerCent.EditValue = "0.00";
            this.fld_txtICReceiptDiscountPerCent.Location = new System.Drawing.Point(744, 496);
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
            this.fld_txtICReceiptDiscountPerCent.TabIndex = 13;
            this.fld_txtICReceiptDiscountPerCent.Tag = "DC";
            this.fld_txtICReceiptDiscountPerCent.Validated += new System.EventHandler(this.fld_txtICReceiptDiscountPerCent_Validated);
            // 
            // fld_txtICReceiptSubTotalCost
            // 
            this.fld_txtICReceiptSubTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptSubTotalCost.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptSubTotalCost.BOSDataMember = "ICReceiptSubTotalCost";
            this.fld_txtICReceiptSubTotalCost.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptSubTotalCost.BOSDescription = null;
            this.fld_txtICReceiptSubTotalCost.BOSError = null;
            this.fld_txtICReceiptSubTotalCost.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptSubTotalCost.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptSubTotalCost.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptSubTotalCost.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptSubTotalCost.EditValue = "0.00";
            this.fld_txtICReceiptSubTotalCost.Location = new System.Drawing.Point(744, 471);
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
            this.fld_txtICReceiptSubTotalCost.TabIndex = 12;
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
            this.bosLabel8.Location = new System.Drawing.Point(656, 602);
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
            this.bosLabel12.Location = new System.Drawing.Point(683, 551);
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
            this.bosLabel11.Location = new System.Drawing.Point(649, 525);
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
            this.bosLabel9.Location = new System.Drawing.Point(698, 577);
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
            this.bosLabel7.Location = new System.Drawing.Point(669, 499);
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
            this.bosLabel5.Location = new System.Drawing.Point(677, 474);
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
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.Location = new System.Drawing.Point(134, 66);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(18, 13);
            this.bosLabel2.TabIndex = 7;
            this.bosLabel2.Tag = global::Localization.ReportLocalizedResources.String1;
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
            this.fld_lkeFK_ICStockID.Location = new System.Drawing.Point(215, 63);
            this.fld_lkeFK_ICStockID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICStockID.Name = "fld_lkeFK_ICStockID";
            this.fld_lkeFK_ICStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICStockID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "Mã kho"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Tên kho")});
            this.fld_lkeFK_ICStockID.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICStockID.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICStockID.Screen = null;
            this.fld_lkeFK_ICStockID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICStockID.TabIndex = 6;
            this.fld_lkeFK_ICStockID.Tag = "DC";
            this.fld_lkeFK_ICStockID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICStockID_CloseUp);
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
            this.bosPanel1.Controls.Add(this.fld_Lablel2);
            this.bosPanel1.Controls.Add(this.fld_lkeICReceiptStatus);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptPackNo);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.fld_lkeICInputVATInvoiceNoCombo);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel25);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptSymbol);
            this.bosPanel1.Controls.Add(this.bosLabel24);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptFormNo);
            this.bosPanel1.Controls.Add(this.bosLabel22);
            this.bosPanel1.Controls.Add(this.fld_lkeICInputVATDocumentType);
            this.bosPanel1.Controls.Add(this.fld_medICReceiptDesc);
            this.bosPanel1.Controls.Add(this.fld_pteICReceiptEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptExchangeRate);
            this.bosPanel1.Controls.Add(this.fld_dteICReceiptInvoiceInDate);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICStockID);
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
            this.bosPanel1.Size = new System.Drawing.Size(921, 637);
            this.bosPanel1.TabIndex = 545;
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
            this.fld_Lablel2.Location = new System.Drawing.Point(669, 145);
            this.fld_Lablel2.Name = "fld_Lablel2";
            this.fld_Lablel2.Screen = null;
            this.fld_Lablel2.Size = new System.Drawing.Size(49, 13);
            this.fld_Lablel2.TabIndex = 557;
            this.fld_Lablel2.Text = "Tình trạng";
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
            this.fld_lkeICReceiptStatus.Location = new System.Drawing.Point(760, 142);
            this.fld_lkeICReceiptStatus.MenuManager = this.screenToolbar;
            this.fld_lkeICReceiptStatus.Name = "fld_lkeICReceiptStatus";
            this.fld_lkeICReceiptStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICReceiptStatus.Properties.ReadOnly = true;
            this.fld_lkeICReceiptStatus.Screen = null;
            this.fld_lkeICReceiptStatus.Size = new System.Drawing.Size(152, 20);
            this.fld_lkeICReceiptStatus.TabIndex = 556;
            this.fld_lkeICReceiptStatus.Tag = "DC";
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
            this.fld_txtICReceiptPackNo.Location = new System.Drawing.Point(760, 116);
            this.fld_txtICReceiptPackNo.Name = "fld_txtICReceiptPackNo";
            this.fld_txtICReceiptPackNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptPackNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptPackNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptPackNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptPackNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptPackNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptPackNo.Screen = null;
            this.fld_txtICReceiptPackNo.Size = new System.Drawing.Size(151, 20);
            this.fld_txtICReceiptPackNo.TabIndex = 554;
            this.fld_txtICReceiptPackNo.Tag = "DC";
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
            this.bosLabel10.Location = new System.Drawing.Point(669, 119);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(52, 13);
            this.bosLabel10.TabIndex = 555;
            this.bosLabel10.Text = "Mã lô hàng";
            // 
            // fld_lkeICInputVATInvoiceNoCombo
            // 
            this.fld_lkeICInputVATInvoiceNoCombo.BOSAllowAddNew = false;
            this.fld_lkeICInputVATInvoiceNoCombo.BOSAllowDummy = false;
            this.fld_lkeICInputVATInvoiceNoCombo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICInputVATInvoiceNoCombo.BOSDataMember = "ICInputVATInvoiceNoCombo";
            this.fld_lkeICInputVATInvoiceNoCombo.BOSDataSource = "ICReceipts";
            this.fld_lkeICInputVATInvoiceNoCombo.BOSDescription = null;
            this.fld_lkeICInputVATInvoiceNoCombo.BOSError = null;
            this.fld_lkeICInputVATInvoiceNoCombo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICInputVATInvoiceNoCombo.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICInputVATInvoiceNoCombo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICInputVATInvoiceNoCombo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICInputVATInvoiceNoCombo.BOSPropertyName = "EditValue";
            this.fld_lkeICInputVATInvoiceNoCombo.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICInputVATInvoiceNoCombo.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICInputVATInvoiceNoCombo.CurrentDisplayText = null;
            this.fld_lkeICInputVATInvoiceNoCombo.Location = new System.Drawing.Point(760, 90);
            this.fld_lkeICInputVATInvoiceNoCombo.Name = "fld_lkeICInputVATInvoiceNoCombo";
            this.fld_lkeICInputVATInvoiceNoCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICInputVATInvoiceNoCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICInputVATInvoiceNoCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICInputVATInvoiceNoCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICInputVATInvoiceNoCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICInputVATInvoiceNoCombo.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICInputVATInvoiceNoCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICInputVATInvoiceNoCombo.Screen = null;
            this.fld_lkeICInputVATInvoiceNoCombo.Size = new System.Drawing.Size(152, 20);
            this.fld_lkeICInputVATInvoiceNoCombo.TabIndex = 553;
            this.fld_lkeICInputVATInvoiceNoCombo.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(669, 93);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(85, 13);
            this.bosLabel4.TabIndex = 552;
            this.bosLabel4.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.Text = "Mã hóa đơn GTGT";
            // 
            // bosLabel25
            // 
            this.bosLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.Options.UseBackColor = true;
            this.bosLabel25.Appearance.Options.UseForeColor = true;
            this.bosLabel25.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel25.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel25.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel25.BOSDescription = null;
            this.bosLabel25.BOSError = null;
            this.bosLabel25.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel25.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel25.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel25.BOSPropertyName = null;
            this.bosLabel25.Location = new System.Drawing.Point(669, 66);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(35, 13);
            this.bosLabel25.TabIndex = 551;
            this.bosLabel25.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel25.Text = "Ký hiệu";
            // 
            // fld_txtICReceiptSymbol
            // 
            this.fld_txtICReceiptSymbol.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptSymbol.BOSDataMember = "ICReceiptSymbol";
            this.fld_txtICReceiptSymbol.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptSymbol.BOSDescription = null;
            this.fld_txtICReceiptSymbol.BOSError = null;
            this.fld_txtICReceiptSymbol.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptSymbol.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptSymbol.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptSymbol.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptSymbol.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptSymbol.Location = new System.Drawing.Point(760, 63);
            this.fld_txtICReceiptSymbol.Name = "fld_txtICReceiptSymbol";
            this.fld_txtICReceiptSymbol.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptSymbol.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptSymbol.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptSymbol.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptSymbol.Properties.Mask.EditMask = "n";
            this.fld_txtICReceiptSymbol.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptSymbol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptSymbol.Screen = null;
            this.fld_txtICReceiptSymbol.Size = new System.Drawing.Size(151, 20);
            this.fld_txtICReceiptSymbol.TabIndex = 550;
            this.fld_txtICReceiptSymbol.Tag = "DC";
            // 
            // bosLabel24
            // 
            this.bosLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.Options.UseBackColor = true;
            this.bosLabel24.Appearance.Options.UseForeColor = true;
            this.bosLabel24.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel24.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel24.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel24.BOSDescription = null;
            this.bosLabel24.BOSError = null;
            this.bosLabel24.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel24.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel24.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel24.BOSPropertyName = null;
            this.bosLabel24.Location = new System.Drawing.Point(669, 40);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(34, 13);
            this.bosLabel24.TabIndex = 549;
            this.bosLabel24.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel24.Text = "Mẫu số";
            // 
            // fld_txtICReceiptFormNo
            // 
            this.fld_txtICReceiptFormNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptFormNo.BOSDataMember = "ICReceiptFormNo";
            this.fld_txtICReceiptFormNo.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptFormNo.BOSDescription = null;
            this.fld_txtICReceiptFormNo.BOSError = null;
            this.fld_txtICReceiptFormNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptFormNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptFormNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptFormNo.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptFormNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptFormNo.Location = new System.Drawing.Point(760, 37);
            this.fld_txtICReceiptFormNo.Name = "fld_txtICReceiptFormNo";
            this.fld_txtICReceiptFormNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptFormNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptFormNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptFormNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptFormNo.Properties.Mask.EditMask = "n";
            this.fld_txtICReceiptFormNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptFormNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptFormNo.Screen = null;
            this.fld_txtICReceiptFormNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptFormNo.TabIndex = 548;
            this.fld_txtICReceiptFormNo.Tag = "DC";
            // 
            // bosLabel22
            // 
            this.bosLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.Options.UseBackColor = true;
            this.bosLabel22.Appearance.Options.UseForeColor = true;
            this.bosLabel22.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel22.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel22.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel22.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel22.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel22.BOSPropertyName = null;
            this.bosLabel22.Location = new System.Drawing.Point(669, 14);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(61, 13);
            this.bosLabel22.TabIndex = 545;
            this.bosLabel22.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel22.Text = "Loại hóa đơn";
            // 
            // fld_lkeICInputVATDocumentType
            // 
            this.fld_lkeICInputVATDocumentType.BOSAllowAddNew = false;
            this.fld_lkeICInputVATDocumentType.BOSAllowDummy = false;
            this.fld_lkeICInputVATDocumentType.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICInputVATDocumentType.BOSDataMember = "ICInputVATDocumentType";
            this.fld_lkeICInputVATDocumentType.BOSDataSource = "ICReceipts";
            this.fld_lkeICInputVATDocumentType.BOSDescription = null;
            this.fld_lkeICInputVATDocumentType.BOSError = null;
            this.fld_lkeICInputVATDocumentType.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICInputVATDocumentType.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICInputVATDocumentType.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICInputVATDocumentType.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICInputVATDocumentType.BOSPropertyName = "EditValue";
            this.fld_lkeICInputVATDocumentType.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICInputVATDocumentType.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICInputVATDocumentType.CurrentDisplayText = null;
            this.fld_lkeICInputVATDocumentType.Location = new System.Drawing.Point(760, 11);
            this.fld_lkeICInputVATDocumentType.Name = "fld_lkeICInputVATDocumentType";
            this.fld_lkeICInputVATDocumentType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICInputVATDocumentType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICInputVATDocumentType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICInputVATDocumentType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICInputVATDocumentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICInputVATDocumentType.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICInputVATDocumentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICInputVATDocumentType.Screen = null;
            this.fld_lkeICInputVATDocumentType.Size = new System.Drawing.Size(151, 20);
            this.fld_lkeICInputVATDocumentType.TabIndex = 544;
            this.fld_lkeICInputVATDocumentType.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.Location = new System.Drawing.Point(134, 118);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 7;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.Text = "Diễn giải";
            // 
            // DMAI100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(921, 637);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMAI100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptInvoiceInNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptInvoiceInDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptInvoiceInDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcReceiptItems)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICReceiptDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptShippingExtraFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptShippingFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptDiscountPerCent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptSubTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptPackNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICInputVATInvoiceNoCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptSymbol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptFormNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICInputVATDocumentType.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPictureEdit fld_pteICReceiptEmployeePicture;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSMemoEdit fld_medICReceiptDesc;
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
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSLookupEdit fld_lkeICInputVATDocumentType;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSTextBox fld_txtICReceiptFormNo;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSTextBox fld_txtICReceiptSymbol;
        private BOSComponent.BOSLookupEdit fld_lkeICInputVATInvoiceNoCombo;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtICReceiptPackNo;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel fld_Lablel2;
        private BOSComponent.BOSLookupEdit fld_lkeICReceiptStatus;
	}
}
