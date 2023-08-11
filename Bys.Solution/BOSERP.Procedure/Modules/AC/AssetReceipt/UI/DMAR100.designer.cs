using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AssetReceipt.UI
{
	/// <summary>
	/// Summary description for DMNTS100
	/// </summary>
	partial class DMAR100
	{
		private BOSComponent.BOSLabel fld_lblLabel5;
		private BOSComponent.BOSLabel fld_lblLabel6;
		private BOSComponent.BOSLabel fld_lblLabel7;
		private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSLabel fld_lblLabel9;
		private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
		private BOSComponent.BOSTextBox fld_txtACAssetReceiptNo1;
		private BOSComponent.BOSDateEdit fld_dteACAssetReceiptDate2;
		private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
		private BOSComponent.BOSTextBox fld_txtACAssetReceiptExchangeRate;
        private BOSComponent.BOSMemoEdit fld_medACAssetReceiptDesc;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMAR100));
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtACAssetReceiptNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteACAssetReceiptDate2 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtACAssetReceiptExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.fld_medACAssetReceiptDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_pteACAssetReceiptEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lkeFK_ICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAssetID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcAssetReceiptItems = new BOSERP.Modules.AssetReceipt.AssetReceiptItemGridControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_ACEInvoiceTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACAssetReceiptVATFormNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ARSaleContractID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACAssetReceiptPaymentTermDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_bkeACAssetReceiptType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACAssetReceiptSupplierContactAddress = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACAssetReceiptSupplierTaxNumber = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACAssetReceiptSymbol = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPInputVATDocumentType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtACAssetReceiptTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACAssetReceiptDiscountPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_APSupplierID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtACAssetReceiptTaxAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACAssetReceiptDiscountAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACAssetReceiptExtraFee = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACAssetReceiptShippingFee = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACAssetReceiptTotalCost = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACAssetReceiptSubTotalCost = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACAssetReceiptInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtACAssetReceiptInvoiceNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetReceiptDate2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetReceiptDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACAssetReceiptDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACAssetReceiptEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAssetID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAssetReceiptItems)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACEInvoiceTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptVATFormNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleContractID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetReceiptPaymentTermDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetReceiptPaymentTermDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bkeACAssetReceiptType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptSupplierContactAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptSupplierTaxNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptSymbol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInputVATDocumentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptDiscountPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptDiscountAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptExtraFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptShippingFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptSubTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetReceiptInvoiceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetReceiptInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptInvoiceNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = "";
            this.fld_lblLabel5.BOSDataMember = "";
            this.fld_lblLabel5.BOSDataSource = "";
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = "";
            this.fld_lblLabel5.BOSFieldRelation = "";
            this.fld_lblLabel5.BOSPrivilege = "";
            this.fld_lblLabel5.BOSPropertyName = "";
            this.fld_lblLabel5.Location = new System.Drawing.Point(127, 16);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel5.TabIndex = 4;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Mã chứng từ";
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
            this.fld_lblLabel6.Location = new System.Drawing.Point(431, 16);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel6.TabIndex = 5;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Ngày chứng từ";
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
            this.fld_lblLabel7.Location = new System.Drawing.Point(127, 42);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel7.TabIndex = 6;
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
            this.fld_lblLabel8.Location = new System.Drawing.Point(431, 42);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(53, 13);
            this.fld_lblLabel8.TabIndex = 7;
            this.fld_lblLabel8.Tag = "";
            this.fld_lblLabel8.Text = "Loại tiền tệ";
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
            this.fld_lblLabel9.Location = new System.Drawing.Point(431, 67);
            this.fld_lblLabel9.Name = "fld_lblLabel9";
            this.fld_lblLabel9.Screen = null;
            this.fld_lblLabel9.Size = new System.Drawing.Size(29, 13);
            this.fld_lblLabel9.TabIndex = 8;
            this.fld_lblLabel9.Tag = "";
            this.fld_lblLabel9.Text = "Tỷ giá";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = "";
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ACAssetReceipts";
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
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(3, 102);
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
            this.fld_lkeFK_HREmployeeID1.TabIndex = 24;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
            // 
            // fld_txtACAssetReceiptNo1
            // 
            this.fld_txtACAssetReceiptNo1.BOSComment = "";
            this.fld_txtACAssetReceiptNo1.BOSDataMember = "ACAssetReceiptNo";
            this.fld_txtACAssetReceiptNo1.BOSDataSource = "ACAssetReceipts";
            this.fld_txtACAssetReceiptNo1.BOSDescription = null;
            this.fld_txtACAssetReceiptNo1.BOSError = null;
            this.fld_txtACAssetReceiptNo1.BOSFieldGroup = "";
            this.fld_txtACAssetReceiptNo1.BOSFieldRelation = "";
            this.fld_txtACAssetReceiptNo1.BOSPrivilege = "";
            this.fld_txtACAssetReceiptNo1.BOSPropertyName = "Text";
            this.fld_txtACAssetReceiptNo1.EditValue = "";
            this.fld_txtACAssetReceiptNo1.Location = new System.Drawing.Point(221, 13);
            this.fld_txtACAssetReceiptNo1.Name = "fld_txtACAssetReceiptNo1";
            this.fld_txtACAssetReceiptNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACAssetReceiptNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAssetReceiptNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAssetReceiptNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAssetReceiptNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAssetReceiptNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAssetReceiptNo1.Screen = null;
            this.fld_txtACAssetReceiptNo1.Size = new System.Drawing.Size(169, 20);
            this.fld_txtACAssetReceiptNo1.TabIndex = 0;
            this.fld_txtACAssetReceiptNo1.Tag = "DC";
            // 
            // fld_dteACAssetReceiptDate2
            // 
            this.fld_dteACAssetReceiptDate2.BOSComment = "";
            this.fld_dteACAssetReceiptDate2.BOSDataMember = "ACAssetReceiptDate";
            this.fld_dteACAssetReceiptDate2.BOSDataSource = "ACAssetReceipts";
            this.fld_dteACAssetReceiptDate2.BOSDescription = null;
            this.fld_dteACAssetReceiptDate2.BOSError = null;
            this.fld_dteACAssetReceiptDate2.BOSFieldGroup = "";
            this.fld_dteACAssetReceiptDate2.BOSFieldRelation = "";
            this.fld_dteACAssetReceiptDate2.BOSPrivilege = "";
            this.fld_dteACAssetReceiptDate2.BOSPropertyName = "EditValue";
            this.fld_dteACAssetReceiptDate2.EditValue = "";
            this.fld_dteACAssetReceiptDate2.Location = new System.Drawing.Point(521, 13);
            this.fld_dteACAssetReceiptDate2.Name = "fld_dteACAssetReceiptDate2";
            this.fld_dteACAssetReceiptDate2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACAssetReceiptDate2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACAssetReceiptDate2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACAssetReceiptDate2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACAssetReceiptDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACAssetReceiptDate2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACAssetReceiptDate2.Screen = null;
            this.fld_dteACAssetReceiptDate2.Size = new System.Drawing.Size(165, 20);
            this.fld_dteACAssetReceiptDate2.TabIndex = 1;
            this.fld_dteACAssetReceiptDate2.Tag = "DC";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = "";
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ACAssetReceipts";
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
            this.fld_lkeFK_GECurrencyID.EditValue = "";
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(521, 39);
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
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyNo";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(165, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 5;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // fld_txtACAssetReceiptExchangeRate
            // 
            this.fld_txtACAssetReceiptExchangeRate.BOSComment = "";
            this.fld_txtACAssetReceiptExchangeRate.BOSDataMember = "ACAssetReceiptExchangeRate";
            this.fld_txtACAssetReceiptExchangeRate.BOSDataSource = "ACAssetReceipts";
            this.fld_txtACAssetReceiptExchangeRate.BOSDescription = null;
            this.fld_txtACAssetReceiptExchangeRate.BOSError = null;
            this.fld_txtACAssetReceiptExchangeRate.BOSFieldGroup = "";
            this.fld_txtACAssetReceiptExchangeRate.BOSFieldRelation = "";
            this.fld_txtACAssetReceiptExchangeRate.BOSPrivilege = "";
            this.fld_txtACAssetReceiptExchangeRate.BOSPropertyName = "Text";
            this.fld_txtACAssetReceiptExchangeRate.EditValue = "";
            this.fld_txtACAssetReceiptExchangeRate.Location = new System.Drawing.Point(521, 65);
            this.fld_txtACAssetReceiptExchangeRate.Name = "fld_txtACAssetReceiptExchangeRate";
            this.fld_txtACAssetReceiptExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACAssetReceiptExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAssetReceiptExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAssetReceiptExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAssetReceiptExchangeRate.Properties.Mask.EditMask = "n";
            this.fld_txtACAssetReceiptExchangeRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtACAssetReceiptExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAssetReceiptExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAssetReceiptExchangeRate.Screen = null;
            this.fld_txtACAssetReceiptExchangeRate.Size = new System.Drawing.Size(165, 20);
            this.fld_txtACAssetReceiptExchangeRate.TabIndex = 9;
            this.fld_txtACAssetReceiptExchangeRate.Tag = "DC";
            // 
            // fld_medACAssetReceiptDesc
            // 
            this.fld_medACAssetReceiptDesc.BOSComment = "";
            this.fld_medACAssetReceiptDesc.BOSDataMember = "ACAssetReceiptDesc";
            this.fld_medACAssetReceiptDesc.BOSDataSource = "ACAssetReceipts";
            this.fld_medACAssetReceiptDesc.BOSDescription = null;
            this.fld_medACAssetReceiptDesc.BOSError = null;
            this.fld_medACAssetReceiptDesc.BOSFieldGroup = "";
            this.fld_medACAssetReceiptDesc.BOSFieldRelation = "";
            this.fld_medACAssetReceiptDesc.BOSPrivilege = "";
            this.fld_medACAssetReceiptDesc.BOSPropertyName = "Text";
            this.fld_medACAssetReceiptDesc.EditValue = "";
            this.fld_medACAssetReceiptDesc.Location = new System.Drawing.Point(221, 117);
            this.fld_medACAssetReceiptDesc.Name = "fld_medACAssetReceiptDesc";
            this.fld_medACAssetReceiptDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACAssetReceiptDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACAssetReceiptDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACAssetReceiptDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACAssetReceiptDesc.Screen = null;
            this.fld_medACAssetReceiptDesc.Size = new System.Drawing.Size(773, 42);
            this.fld_medACAssetReceiptDesc.TabIndex = 15;
            this.fld_medACAssetReceiptDesc.Tag = "DC";
            // 
            // fld_pteACAssetReceiptEmployeePicture
            // 
            this.fld_pteACAssetReceiptEmployeePicture.BOSComment = null;
            this.fld_pteACAssetReceiptEmployeePicture.BOSDataMember = "ACAssetReceiptEmployeePicture";
            this.fld_pteACAssetReceiptEmployeePicture.BOSDataSource = "ACAssetReceipts";
            this.fld_pteACAssetReceiptEmployeePicture.BOSDescription = null;
            this.fld_pteACAssetReceiptEmployeePicture.BOSError = null;
            this.fld_pteACAssetReceiptEmployeePicture.BOSFieldGroup = null;
            this.fld_pteACAssetReceiptEmployeePicture.BOSFieldRelation = null;
            this.fld_pteACAssetReceiptEmployeePicture.BOSPrivilege = null;
            this.fld_pteACAssetReceiptEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteACAssetReceiptEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteACAssetReceiptEmployeePicture.FileName = null;
            this.fld_pteACAssetReceiptEmployeePicture.FilePath = null;
            this.fld_pteACAssetReceiptEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteACAssetReceiptEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteACAssetReceiptEmployeePicture.Name = "fld_pteACAssetReceiptEmployeePicture";
            this.fld_pteACAssetReceiptEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteACAssetReceiptEmployeePicture.Screen = null;
            this.fld_pteACAssetReceiptEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteACAssetReceiptEmployeePicture.TabIndex = 25;
            this.fld_pteACAssetReceiptEmployeePicture.Tag = "DC";
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
            this.bosTabControl1.Size = new System.Drawing.Size(1353, 345);
            this.bosTabControl1.TabIndex = 14;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_lkeFK_ICProductID);
            this.xtraTabPage1.Controls.Add(this.bosLabel9);
            this.xtraTabPage1.Controls.Add(this.fld_lkeFK_ACAssetID);
            this.xtraTabPage1.Controls.Add(this.fld_dgcAssetReceiptItems);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1351, 320);
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
            this.fld_lkeFK_ICProductID.BOSDataSource = "ACAssetReceiptItems";
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
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(59, 8);
            this.fld_lkeFK_ICProductID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(1288, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 31;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID_KeyUp_1);
            // 
            // bosLabel9
            // 
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(7, 11);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(34, 13);
            this.bosLabel9.TabIndex = 30;
            this.bosLabel9.Text = "Tài sản";
            // 
            // fld_lkeFK_ACAssetID
            // 
            this.fld_lkeFK_ACAssetID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ACAssetID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAssetID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAssetID.BOSComment = null;
            this.fld_lkeFK_ACAssetID.BOSDataMember = "FK_ACAssetID";
            this.fld_lkeFK_ACAssetID.BOSDataSource = "ACAssetReceiptItems";
            this.fld_lkeFK_ACAssetID.BOSDescription = null;
            this.fld_lkeFK_ACAssetID.BOSError = null;
            this.fld_lkeFK_ACAssetID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAssetID.BOSFieldParent = null;
            this.fld_lkeFK_ACAssetID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAssetID.BOSPrivilege = null;
            this.fld_lkeFK_ACAssetID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAssetID.BOSSelectType = "ACAssetStatus";
            this.fld_lkeFK_ACAssetID.BOSSelectTypeValue = "Purchased";
            this.fld_lkeFK_ACAssetID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAssetID.Location = new System.Drawing.Point(59, 8);
            this.fld_lkeFK_ACAssetID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ACAssetID.Name = "fld_lkeFK_ACAssetID";
            this.fld_lkeFK_ACAssetID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAssetID.Properties.ColumnName = null;
            this.fld_lkeFK_ACAssetID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAssetNo", "Mã tài sản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAssetName", "Tên tài sản")});
            this.fld_lkeFK_ACAssetID.Properties.DisplayMember = "ACAssetName";
            this.fld_lkeFK_ACAssetID.Properties.ValueMember = "ACAssetID";
            this.fld_lkeFK_ACAssetID.Screen = null;
            this.fld_lkeFK_ACAssetID.Size = new System.Drawing.Size(1288, 20);
            this.fld_lkeFK_ACAssetID.TabIndex = 0;
            this.fld_lkeFK_ACAssetID.Tag = "DC";
            this.fld_lkeFK_ACAssetID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ACAssetID_KeyUp_1);
            // 
            // fld_dgcAssetReceiptItems
            // 
            this.fld_dgcAssetReceiptItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAssetReceiptItems.BOSComment = null;
            this.fld_dgcAssetReceiptItems.BOSDataMember = null;
            this.fld_dgcAssetReceiptItems.BOSDataSource = "ACAssetReceiptItems";
            this.fld_dgcAssetReceiptItems.BOSDescription = null;
            this.fld_dgcAssetReceiptItems.BOSError = null;
            this.fld_dgcAssetReceiptItems.BOSFieldGroup = null;
            this.fld_dgcAssetReceiptItems.BOSFieldRelation = null;
            this.fld_dgcAssetReceiptItems.BOSGridType = null;
            this.fld_dgcAssetReceiptItems.BOSPrivilege = null;
            this.fld_dgcAssetReceiptItems.BOSPropertyName = null;
            this.fld_dgcAssetReceiptItems.CommodityType = "";
            this.fld_dgcAssetReceiptItems.Location = new System.Drawing.Point(0, 44);
            this.fld_dgcAssetReceiptItems.MenuManager = this.screenToolbar;
            this.fld_dgcAssetReceiptItems.Name = "fld_dgcAssetReceiptItems";
            this.fld_dgcAssetReceiptItems.PrintReport = false;
            this.fld_dgcAssetReceiptItems.Screen = null;
            this.fld_dgcAssetReceiptItems.Size = new System.Drawing.Size(1351, 276);
            this.fld_dgcAssetReceiptItems.TabIndex = 1;
            this.fld_dgcAssetReceiptItems.Tag = "DC";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcDocumentEntrys);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1337, 313);
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
            this.fld_dgcDocumentEntrys.Size = new System.Drawing.Size(1337, 313);
            this.fld_dgcDocumentEntrys.TabIndex = 2;
            this.fld_dgcDocumentEntrys.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_txtACAssetReceiptVATFormNo);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARSaleContractID);
            this.bosPanel1.Controls.Add(this.bosLabel16);
            this.bosPanel1.Controls.Add(this.fld_dteACAssetReceiptPaymentTermDate);
            this.bosPanel1.Controls.Add(this.bosLabel15);
            this.bosPanel1.Controls.Add(this.bosLabel14);
            this.bosPanel1.Controls.Add(this.fld_bkeACAssetReceiptType);
            this.bosPanel1.Controls.Add(this.bosLabel20);
            this.bosPanel1.Controls.Add(this.fld_txtACAssetReceiptSupplierContactAddress);
            this.bosPanel1.Controls.Add(this.fld_txtACAssetReceiptSupplierTaxNumber);
            this.bosPanel1.Controls.Add(this.fld_txtACAssetReceiptSymbol);
            this.bosPanel1.Controls.Add(this.bosLabel13);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_lkeAPInputVATDocumentType);
            this.bosPanel1.Controls.Add(this.fld_medACAssetReceiptDesc);
            this.bosPanel1.Controls.Add(this.fld_txtACAssetReceiptTaxPercent);
            this.bosPanel1.Controls.Add(this.fld_txtACAssetReceiptDiscountPercent);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_APSupplierID);
            this.bosPanel1.Controls.Add(this.fld_txtACAssetReceiptTaxAmount);
            this.bosPanel1.Controls.Add(this.fld_txtACAssetReceiptDiscountAmount);
            this.bosPanel1.Controls.Add(this.fld_txtACAssetReceiptExtraFee);
            this.bosPanel1.Controls.Add(this.fld_txtACAssetReceiptShippingFee);
            this.bosPanel1.Controls.Add(this.fld_txtACAssetReceiptTotalCost);
            this.bosPanel1.Controls.Add(this.fld_txtACAssetReceiptSubTotalCost);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_pteACAssetReceiptEmployeePicture);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.fld_txtACAssetReceiptExchangeRate);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_dteACAssetReceiptInvoiceDate);
            this.bosPanel1.Controls.Add(this.fld_dteACAssetReceiptDate2);
            this.bosPanel1.Controls.Add(this.fld_lblLabel6);
            this.bosPanel1.Controls.Add(this.fld_txtACAssetReceiptInvoiceNo);
            this.bosPanel1.Controls.Add(this.fld_txtACAssetReceiptNo1);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_lblLabel7);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel8);
            this.bosPanel1.Controls.Add(this.fld_lblLabel9);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1359, 690);
            this.bosPanel1.TabIndex = 0;
            this.bosPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bosPanel1_Paint);
            // 
            // fld_lkeFK_ACEInvoiceTypeID
            // 
            this.fld_lkeFK_ACEInvoiceTypeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACEInvoiceTypeID.BOSAllowDummy = false;
            this.fld_lkeFK_ACEInvoiceTypeID.BOSComment = "";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSDataMember = "FK_ACEInvoiceTypeID";
            this.fld_lkeFK_ACEInvoiceTypeID.BOSDataSource = "ACAssetReceipts";
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
            this.fld_lkeFK_ACEInvoiceTypeID.Location = new System.Drawing.Point(1125, 13);
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
            this.fld_lkeFK_ACEInvoiceTypeID.Size = new System.Drawing.Size(161, 20);
            this.fld_lkeFK_ACEInvoiceTypeID.TabIndex = 3;
            this.fld_lkeFK_ACEInvoiceTypeID.Tag = "DC";
            this.fld_lkeFK_ACEInvoiceTypeID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_txtFK_ACEInvoiceTypeID_CloseUp);
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
            this.bosLabel17.Location = new System.Drawing.Point(1034, 16);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(85, 13);
            this.bosLabel17.TabIndex = 647;
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
            this.bosLabel24.Location = new System.Drawing.Point(1034, 42);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(34, 13);
            this.bosLabel24.TabIndex = 645;
            this.bosLabel24.Tag = "";
            this.bosLabel24.Text = "Mẫu số";
            // 
            // fld_txtACAssetReceiptVATFormNo
            // 
            this.fld_txtACAssetReceiptVATFormNo.BOSComment = "";
            this.fld_txtACAssetReceiptVATFormNo.BOSDataMember = "ACAssetReceiptVATFormNo";
            this.fld_txtACAssetReceiptVATFormNo.BOSDataSource = "ACAssetReceipts";
            this.fld_txtACAssetReceiptVATFormNo.BOSDescription = null;
            this.fld_txtACAssetReceiptVATFormNo.BOSError = null;
            this.fld_txtACAssetReceiptVATFormNo.BOSFieldGroup = "";
            this.fld_txtACAssetReceiptVATFormNo.BOSFieldRelation = "";
            this.fld_txtACAssetReceiptVATFormNo.BOSPrivilege = "";
            this.fld_txtACAssetReceiptVATFormNo.BOSPropertyName = "EditValue";
            this.fld_txtACAssetReceiptVATFormNo.EditValue = "";
            this.fld_txtACAssetReceiptVATFormNo.Location = new System.Drawing.Point(1125, 39);
            this.fld_txtACAssetReceiptVATFormNo.Name = "fld_txtACAssetReceiptVATFormNo";
            this.fld_txtACAssetReceiptVATFormNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACAssetReceiptVATFormNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAssetReceiptVATFormNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAssetReceiptVATFormNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAssetReceiptVATFormNo.Properties.Mask.EditMask = "n";
            this.fld_txtACAssetReceiptVATFormNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAssetReceiptVATFormNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAssetReceiptVATFormNo.Screen = null;
            this.fld_txtACAssetReceiptVATFormNo.Size = new System.Drawing.Size(161, 20);
            this.fld_txtACAssetReceiptVATFormNo.TabIndex = 7;
            this.fld_txtACAssetReceiptVATFormNo.Tag = "DC";
            // 
            // fld_lkeFK_ARSaleContractID
            // 
            this.fld_lkeFK_ARSaleContractID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSaleContractID.BOSAllowDummy = false;
            this.fld_lkeFK_ARSaleContractID.BOSComment = "";
            this.fld_lkeFK_ARSaleContractID.BOSDataMember = "FK_APPurchaseContractID";
            this.fld_lkeFK_ARSaleContractID.BOSDataSource = "ACAssetReceipts";
            this.fld_lkeFK_ARSaleContractID.BOSDescription = null;
            this.fld_lkeFK_ARSaleContractID.BOSError = null;
            this.fld_lkeFK_ARSaleContractID.BOSFieldGroup = "";
            this.fld_lkeFK_ARSaleContractID.BOSFieldParent = "";
            this.fld_lkeFK_ARSaleContractID.BOSFieldRelation = "";
            this.fld_lkeFK_ARSaleContractID.BOSPrivilege = "";
            this.fld_lkeFK_ARSaleContractID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARSaleContractID.BOSSelectType = "";
            this.fld_lkeFK_ARSaleContractID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARSaleContractID.CurrentDisplayText = "";
            this.fld_lkeFK_ARSaleContractID.Location = new System.Drawing.Point(833, 39);
            this.fld_lkeFK_ARSaleContractID.Name = "fld_lkeFK_ARSaleContractID";
            this.fld_lkeFK_ARSaleContractID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARSaleContractID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARSaleContractID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARSaleContractID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARSaleContractID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARSaleContractID.Properties.ColumnName = null;
            this.fld_lkeFK_ARSaleContractID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APPurchaseContractNo", "Số hợp đồng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APPurchaseContractName", "Tên hợp đồng")});
            this.fld_lkeFK_ARSaleContractID.Properties.DisplayMember = "APPurchaseContractNo";
            this.fld_lkeFK_ARSaleContractID.Properties.NullText = "";
            this.fld_lkeFK_ARSaleContractID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARSaleContractID.Properties.ValueMember = "APPurchaseContractID";
            this.fld_lkeFK_ARSaleContractID.Screen = null;
            this.fld_lkeFK_ARSaleContractID.Size = new System.Drawing.Size(161, 20);
            this.fld_lkeFK_ARSaleContractID.TabIndex = 6;
            this.fld_lkeFK_ARSaleContractID.Tag = "DC";
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = "";
            this.bosLabel16.BOSDataMember = "";
            this.bosLabel16.BOSDataSource = "";
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = "";
            this.bosLabel16.BOSFieldRelation = "";
            this.bosLabel16.BOSPrivilege = "";
            this.bosLabel16.BOSPropertyName = "";
            this.bosLabel16.Location = new System.Drawing.Point(725, 42);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(60, 13);
            this.bosLabel16.TabIndex = 643;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "Số hợp đồng";
            // 
            // fld_dteACAssetReceiptPaymentTermDate
            // 
            this.fld_dteACAssetReceiptPaymentTermDate.BOSComment = "";
            this.fld_dteACAssetReceiptPaymentTermDate.BOSDataMember = "ACAssetReceiptPaymentTermDate";
            this.fld_dteACAssetReceiptPaymentTermDate.BOSDataSource = "ACAssetReceipts";
            this.fld_dteACAssetReceiptPaymentTermDate.BOSDescription = null;
            this.fld_dteACAssetReceiptPaymentTermDate.BOSError = null;
            this.fld_dteACAssetReceiptPaymentTermDate.BOSFieldGroup = "";
            this.fld_dteACAssetReceiptPaymentTermDate.BOSFieldRelation = "";
            this.fld_dteACAssetReceiptPaymentTermDate.BOSPrivilege = "";
            this.fld_dteACAssetReceiptPaymentTermDate.BOSPropertyName = "EditValue";
            this.fld_dteACAssetReceiptPaymentTermDate.EditValue = "";
            this.fld_dteACAssetReceiptPaymentTermDate.Location = new System.Drawing.Point(833, 64);
            this.fld_dteACAssetReceiptPaymentTermDate.Name = "fld_dteACAssetReceiptPaymentTermDate";
            this.fld_dteACAssetReceiptPaymentTermDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACAssetReceiptPaymentTermDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACAssetReceiptPaymentTermDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACAssetReceiptPaymentTermDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACAssetReceiptPaymentTermDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACAssetReceiptPaymentTermDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACAssetReceiptPaymentTermDate.Screen = null;
            this.fld_dteACAssetReceiptPaymentTermDate.Size = new System.Drawing.Size(161, 20);
            this.fld_dteACAssetReceiptPaymentTermDate.TabIndex = 10;
            this.fld_dteACAssetReceiptPaymentTermDate.Tag = "DC";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = "";
            this.bosLabel15.BOSDataMember = "";
            this.bosLabel15.BOSDataSource = "";
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = "";
            this.bosLabel15.BOSFieldRelation = "";
            this.bosLabel15.BOSPrivilege = "";
            this.bosLabel15.BOSPropertyName = "";
            this.bosLabel15.Location = new System.Drawing.Point(725, 67);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(75, 13);
            this.bosLabel15.TabIndex = 105;
            this.bosLabel15.Tag = "";
            this.bosLabel15.Text = "Hạn thanh toán";
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.BOSComment = "";
            this.bosLabel14.BOSDataMember = "";
            this.bosLabel14.BOSDataSource = "";
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = "";
            this.bosLabel14.BOSFieldRelation = "";
            this.bosLabel14.BOSPrivilege = "";
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(725, 16);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(44, 13);
            this.bosLabel14.TabIndex = 104;
            this.bosLabel14.Tag = "";
            this.bosLabel14.Text = "Loại tăng";
            // 
            // fld_bkeACAssetReceiptType
            // 
            this.fld_bkeACAssetReceiptType.BOSAllowAddNew = false;
            this.fld_bkeACAssetReceiptType.BOSAllowDummy = false;
            this.fld_bkeACAssetReceiptType.BOSComment = "";
            this.fld_bkeACAssetReceiptType.BOSDataMember = "ACAssetReceiptType";
            this.fld_bkeACAssetReceiptType.BOSDataSource = "ACAssetReceipts";
            this.fld_bkeACAssetReceiptType.BOSDescription = null;
            this.fld_bkeACAssetReceiptType.BOSError = null;
            this.fld_bkeACAssetReceiptType.BOSFieldGroup = "";
            this.fld_bkeACAssetReceiptType.BOSFieldParent = "";
            this.fld_bkeACAssetReceiptType.BOSFieldRelation = "";
            this.fld_bkeACAssetReceiptType.BOSPrivilege = "";
            this.fld_bkeACAssetReceiptType.BOSPropertyName = "EditValue";
            this.fld_bkeACAssetReceiptType.BOSSelectType = "";
            this.fld_bkeACAssetReceiptType.BOSSelectTypeValue = "";
            this.fld_bkeACAssetReceiptType.CurrentDisplayText = null;
            this.fld_bkeACAssetReceiptType.EditValue = "";
            this.fld_bkeACAssetReceiptType.Location = new System.Drawing.Point(833, 13);
            this.fld_bkeACAssetReceiptType.Name = "fld_bkeACAssetReceiptType";
            this.fld_bkeACAssetReceiptType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_bkeACAssetReceiptType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_bkeACAssetReceiptType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_bkeACAssetReceiptType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_bkeACAssetReceiptType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_bkeACAssetReceiptType.Properties.ColumnName = null;
            this.fld_bkeACAssetReceiptType.Properties.NullText = "";
            this.fld_bkeACAssetReceiptType.Properties.ReadOnly = true;
            this.fld_bkeACAssetReceiptType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_bkeACAssetReceiptType.Screen = null;
            this.fld_bkeACAssetReceiptType.Size = new System.Drawing.Size(161, 20);
            this.fld_bkeACAssetReceiptType.TabIndex = 2;
            this.fld_bkeACAssetReceiptType.Tag = "DC";
            this.fld_bkeACAssetReceiptType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_bkeACAssetReceiptType_CloseUp);
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseForeColor = true;
            this.bosLabel20.BOSComment = "";
            this.bosLabel20.BOSDataMember = "";
            this.bosLabel20.BOSDataSource = "";
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = "";
            this.bosLabel20.BOSFieldRelation = "";
            this.bosLabel20.BOSPrivilege = "";
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(1034, 68);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(35, 13);
            this.bosLabel20.TabIndex = 100;
            this.bosLabel20.Tag = "";
            this.bosLabel20.Text = "Ký hiệu";
            // 
            // fld_txtACAssetReceiptSupplierContactAddress
            // 
            this.fld_txtACAssetReceiptSupplierContactAddress.BOSComment = "";
            this.fld_txtACAssetReceiptSupplierContactAddress.BOSDataMember = "ACAssetReceiptSupplierContactAddress";
            this.fld_txtACAssetReceiptSupplierContactAddress.BOSDataSource = "ACAssetReceipts";
            this.fld_txtACAssetReceiptSupplierContactAddress.BOSDescription = null;
            this.fld_txtACAssetReceiptSupplierContactAddress.BOSError = null;
            this.fld_txtACAssetReceiptSupplierContactAddress.BOSFieldGroup = "";
            this.fld_txtACAssetReceiptSupplierContactAddress.BOSFieldRelation = "";
            this.fld_txtACAssetReceiptSupplierContactAddress.BOSPrivilege = "";
            this.fld_txtACAssetReceiptSupplierContactAddress.BOSPropertyName = "EditValue";
            this.fld_txtACAssetReceiptSupplierContactAddress.EditValue = "";
            this.fld_txtACAssetReceiptSupplierContactAddress.Location = new System.Drawing.Point(221, 91);
            this.fld_txtACAssetReceiptSupplierContactAddress.Name = "fld_txtACAssetReceiptSupplierContactAddress";
            this.fld_txtACAssetReceiptSupplierContactAddress.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACAssetReceiptSupplierContactAddress.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAssetReceiptSupplierContactAddress.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAssetReceiptSupplierContactAddress.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAssetReceiptSupplierContactAddress.Properties.Mask.EditMask = "n";
            this.fld_txtACAssetReceiptSupplierContactAddress.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAssetReceiptSupplierContactAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAssetReceiptSupplierContactAddress.Screen = null;
            this.fld_txtACAssetReceiptSupplierContactAddress.Size = new System.Drawing.Size(465, 20);
            this.fld_txtACAssetReceiptSupplierContactAddress.TabIndex = 12;
            this.fld_txtACAssetReceiptSupplierContactAddress.Tag = "DC";
            // 
            // fld_txtACAssetReceiptSupplierTaxNumber
            // 
            this.fld_txtACAssetReceiptSupplierTaxNumber.BOSComment = "";
            this.fld_txtACAssetReceiptSupplierTaxNumber.BOSDataMember = "ACAssetReceiptSupplierTaxNumber";
            this.fld_txtACAssetReceiptSupplierTaxNumber.BOSDataSource = "ACAssetReceipts";
            this.fld_txtACAssetReceiptSupplierTaxNumber.BOSDescription = null;
            this.fld_txtACAssetReceiptSupplierTaxNumber.BOSError = null;
            this.fld_txtACAssetReceiptSupplierTaxNumber.BOSFieldGroup = "";
            this.fld_txtACAssetReceiptSupplierTaxNumber.BOSFieldRelation = "";
            this.fld_txtACAssetReceiptSupplierTaxNumber.BOSPrivilege = "";
            this.fld_txtACAssetReceiptSupplierTaxNumber.BOSPropertyName = "EditValue";
            this.fld_txtACAssetReceiptSupplierTaxNumber.EditValue = "";
            this.fld_txtACAssetReceiptSupplierTaxNumber.Location = new System.Drawing.Point(221, 65);
            this.fld_txtACAssetReceiptSupplierTaxNumber.Name = "fld_txtACAssetReceiptSupplierTaxNumber";
            this.fld_txtACAssetReceiptSupplierTaxNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACAssetReceiptSupplierTaxNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAssetReceiptSupplierTaxNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAssetReceiptSupplierTaxNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAssetReceiptSupplierTaxNumber.Properties.Mask.EditMask = "n";
            this.fld_txtACAssetReceiptSupplierTaxNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAssetReceiptSupplierTaxNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAssetReceiptSupplierTaxNumber.Screen = null;
            this.fld_txtACAssetReceiptSupplierTaxNumber.Size = new System.Drawing.Size(169, 20);
            this.fld_txtACAssetReceiptSupplierTaxNumber.TabIndex = 8;
            this.fld_txtACAssetReceiptSupplierTaxNumber.Tag = "DC";
            // 
            // fld_txtACAssetReceiptSymbol
            // 
            this.fld_txtACAssetReceiptSymbol.BOSComment = "";
            this.fld_txtACAssetReceiptSymbol.BOSDataMember = "ACAssetReceiptSymbol";
            this.fld_txtACAssetReceiptSymbol.BOSDataSource = "ACAssetReceipts";
            this.fld_txtACAssetReceiptSymbol.BOSDescription = null;
            this.fld_txtACAssetReceiptSymbol.BOSError = null;
            this.fld_txtACAssetReceiptSymbol.BOSFieldGroup = "";
            this.fld_txtACAssetReceiptSymbol.BOSFieldRelation = "";
            this.fld_txtACAssetReceiptSymbol.BOSPrivilege = "";
            this.fld_txtACAssetReceiptSymbol.BOSPropertyName = "EditValue";
            this.fld_txtACAssetReceiptSymbol.EditValue = "";
            this.fld_txtACAssetReceiptSymbol.Location = new System.Drawing.Point(1125, 65);
            this.fld_txtACAssetReceiptSymbol.Name = "fld_txtACAssetReceiptSymbol";
            this.fld_txtACAssetReceiptSymbol.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACAssetReceiptSymbol.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAssetReceiptSymbol.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAssetReceiptSymbol.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAssetReceiptSymbol.Properties.Mask.EditMask = "n";
            this.fld_txtACAssetReceiptSymbol.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAssetReceiptSymbol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAssetReceiptSymbol.Screen = null;
            this.fld_txtACAssetReceiptSymbol.Size = new System.Drawing.Size(161, 20);
            this.fld_txtACAssetReceiptSymbol.TabIndex = 11;
            this.fld_txtACAssetReceiptSymbol.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(127, 94);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(56, 13);
            this.bosLabel13.TabIndex = 79;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "Địa chỉ NCC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = "";
            this.bosLabel12.BOSDataMember = "";
            this.bosLabel12.BOSDataSource = "";
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = "";
            this.bosLabel12.BOSFieldRelation = "";
            this.bosLabel12.BOSPrivilege = "";
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(127, 68);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(63, 13);
            this.bosLabel12.TabIndex = 79;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "Mã thuế NCC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = "";
            this.bosLabel11.BOSDataMember = "";
            this.bosLabel11.BOSDataSource = "";
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = "";
            this.bosLabel11.BOSFieldRelation = "";
            this.bosLabel11.BOSPrivilege = "";
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(725, 94);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(61, 13);
            this.bosLabel11.TabIndex = 79;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Loại hóa đơn";
            // 
            // fld_lkeAPInputVATDocumentType
            // 
            this.fld_lkeAPInputVATDocumentType.BOSAllowAddNew = false;
            this.fld_lkeAPInputVATDocumentType.BOSAllowDummy = false;
            this.fld_lkeAPInputVATDocumentType.BOSComment = "";
            this.fld_lkeAPInputVATDocumentType.BOSDataMember = "APInputVATDocumentType";
            this.fld_lkeAPInputVATDocumentType.BOSDataSource = "ACAssetReceipts";
            this.fld_lkeAPInputVATDocumentType.BOSDescription = null;
            this.fld_lkeAPInputVATDocumentType.BOSError = null;
            this.fld_lkeAPInputVATDocumentType.BOSFieldGroup = "";
            this.fld_lkeAPInputVATDocumentType.BOSFieldParent = "";
            this.fld_lkeAPInputVATDocumentType.BOSFieldRelation = "";
            this.fld_lkeAPInputVATDocumentType.BOSPrivilege = "";
            this.fld_lkeAPInputVATDocumentType.BOSPropertyName = "EditValue";
            this.fld_lkeAPInputVATDocumentType.BOSSelectType = "";
            this.fld_lkeAPInputVATDocumentType.BOSSelectTypeValue = "";
            this.fld_lkeAPInputVATDocumentType.CurrentDisplayText = null;
            this.fld_lkeAPInputVATDocumentType.EditValue = "";
            this.fld_lkeAPInputVATDocumentType.Location = new System.Drawing.Point(833, 91);
            this.fld_lkeAPInputVATDocumentType.Name = "fld_lkeAPInputVATDocumentType";
            this.fld_lkeAPInputVATDocumentType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPInputVATDocumentType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPInputVATDocumentType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPInputVATDocumentType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPInputVATDocumentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPInputVATDocumentType.Properties.ColumnName = null;
            this.fld_lkeAPInputVATDocumentType.Properties.NullText = "";
            this.fld_lkeAPInputVATDocumentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPInputVATDocumentType.Screen = null;
            this.fld_lkeAPInputVATDocumentType.Size = new System.Drawing.Size(161, 20);
            this.fld_lkeAPInputVATDocumentType.TabIndex = 13;
            this.fld_lkeAPInputVATDocumentType.Tag = "DC";
            // 
            // fld_txtACAssetReceiptTaxPercent
            // 
            this.fld_txtACAssetReceiptTaxPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtACAssetReceiptTaxPercent.BOSComment = null;
            this.fld_txtACAssetReceiptTaxPercent.BOSDataMember = "ACAssetReceiptTaxPercent";
            this.fld_txtACAssetReceiptTaxPercent.BOSDataSource = "ACAssetReceipts";
            this.fld_txtACAssetReceiptTaxPercent.BOSDescription = null;
            this.fld_txtACAssetReceiptTaxPercent.BOSError = null;
            this.fld_txtACAssetReceiptTaxPercent.BOSFieldGroup = null;
            this.fld_txtACAssetReceiptTaxPercent.BOSFieldRelation = null;
            this.fld_txtACAssetReceiptTaxPercent.BOSPrivilege = null;
            this.fld_txtACAssetReceiptTaxPercent.BOSPropertyName = "Text";
            this.fld_txtACAssetReceiptTaxPercent.EditValue = "";
            this.fld_txtACAssetReceiptTaxPercent.Location = new System.Drawing.Point(1169, 630);
            this.fld_txtACAssetReceiptTaxPercent.Name = "fld_txtACAssetReceiptTaxPercent";
            this.fld_txtACAssetReceiptTaxPercent.Screen = null;
            this.fld_txtACAssetReceiptTaxPercent.Size = new System.Drawing.Size(68, 20);
            this.fld_txtACAssetReceiptTaxPercent.TabIndex = 20;
            this.fld_txtACAssetReceiptTaxPercent.Tag = "DC";
            this.fld_txtACAssetReceiptTaxPercent.Validated += new System.EventHandler(this.fld_txtACAssetReceiptTaxPercent_Validated);
            // 
            // fld_txtACAssetReceiptDiscountPercent
            // 
            this.fld_txtACAssetReceiptDiscountPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtACAssetReceiptDiscountPercent.BOSComment = null;
            this.fld_txtACAssetReceiptDiscountPercent.BOSDataMember = "ACAssetReceiptDiscountPercent";
            this.fld_txtACAssetReceiptDiscountPercent.BOSDataSource = "ACAssetReceipts";
            this.fld_txtACAssetReceiptDiscountPercent.BOSDescription = null;
            this.fld_txtACAssetReceiptDiscountPercent.BOSError = null;
            this.fld_txtACAssetReceiptDiscountPercent.BOSFieldGroup = null;
            this.fld_txtACAssetReceiptDiscountPercent.BOSFieldRelation = null;
            this.fld_txtACAssetReceiptDiscountPercent.BOSPrivilege = null;
            this.fld_txtACAssetReceiptDiscountPercent.BOSPropertyName = "Text";
            this.fld_txtACAssetReceiptDiscountPercent.EditValue = "";
            this.fld_txtACAssetReceiptDiscountPercent.Location = new System.Drawing.Point(1169, 552);
            this.fld_txtACAssetReceiptDiscountPercent.MenuManager = this.screenToolbar;
            this.fld_txtACAssetReceiptDiscountPercent.Name = "fld_txtACAssetReceiptDiscountPercent";
            this.fld_txtACAssetReceiptDiscountPercent.Screen = null;
            this.fld_txtACAssetReceiptDiscountPercent.Size = new System.Drawing.Size(68, 20);
            this.fld_txtACAssetReceiptDiscountPercent.TabIndex = 16;
            this.fld_txtACAssetReceiptDiscountPercent.Tag = "DC";
            this.fld_txtACAssetReceiptDiscountPercent.Validated += new System.EventHandler(this.fld_txtACAssetReceiptDiscountPercent_Validated);
            // 
            // fld_lkeFK_APSupplierID
            // 
            this.fld_lkeFK_APSupplierID.BOSAllowAddNew = false;
            this.fld_lkeFK_APSupplierID.BOSAllowDummy = false;
            this.fld_lkeFK_APSupplierID.BOSComment = null;
            this.fld_lkeFK_APSupplierID.BOSDataMember = "FK_APSupplierID";
            this.fld_lkeFK_APSupplierID.BOSDataSource = "ACAssetReceipts";
            this.fld_lkeFK_APSupplierID.BOSDescription = null;
            this.fld_lkeFK_APSupplierID.BOSError = null;
            this.fld_lkeFK_APSupplierID.BOSFieldGroup = null;
            this.fld_lkeFK_APSupplierID.BOSFieldParent = null;
            this.fld_lkeFK_APSupplierID.BOSFieldRelation = null;
            this.fld_lkeFK_APSupplierID.BOSPrivilege = null;
            this.fld_lkeFK_APSupplierID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APSupplierID.BOSSelectType = null;
            this.fld_lkeFK_APSupplierID.BOSSelectTypeValue = null;
            this.fld_lkeFK_APSupplierID.CurrentDisplayText = null;
            this.fld_lkeFK_APSupplierID.EditValue = "";
            this.fld_lkeFK_APSupplierID.Location = new System.Drawing.Point(221, 39);
            this.fld_lkeFK_APSupplierID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_APSupplierID.Name = "fld_lkeFK_APSupplierID";
            this.fld_lkeFK_APSupplierID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APSupplierID.Properties.ColumnName = null;
            this.fld_lkeFK_APSupplierID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierName", "Tên")});
            this.fld_lkeFK_APSupplierID.Properties.DisplayMember = "APSupplierName";
            this.fld_lkeFK_APSupplierID.Properties.ValueMember = "APSupplierID";
            this.fld_lkeFK_APSupplierID.Screen = null;
            this.fld_lkeFK_APSupplierID.Size = new System.Drawing.Size(169, 20);
            this.fld_lkeFK_APSupplierID.TabIndex = 4;
            this.fld_lkeFK_APSupplierID.Tag = "DC";
            this.fld_lkeFK_APSupplierID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_APSupplierID_CloseUp);
            // 
            // fld_txtACAssetReceiptTaxAmount
            // 
            this.fld_txtACAssetReceiptTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtACAssetReceiptTaxAmount.BOSComment = null;
            this.fld_txtACAssetReceiptTaxAmount.BOSDataMember = "ACAssetReceiptTaxAmount";
            this.fld_txtACAssetReceiptTaxAmount.BOSDataSource = "ACAssetReceipts";
            this.fld_txtACAssetReceiptTaxAmount.BOSDescription = null;
            this.fld_txtACAssetReceiptTaxAmount.BOSError = null;
            this.fld_txtACAssetReceiptTaxAmount.BOSFieldGroup = null;
            this.fld_txtACAssetReceiptTaxAmount.BOSFieldRelation = null;
            this.fld_txtACAssetReceiptTaxAmount.BOSPrivilege = null;
            this.fld_txtACAssetReceiptTaxAmount.BOSPropertyName = "Text";
            this.fld_txtACAssetReceiptTaxAmount.EditValue = "";
            this.fld_txtACAssetReceiptTaxAmount.Location = new System.Drawing.Point(1243, 630);
            this.fld_txtACAssetReceiptTaxAmount.Name = "fld_txtACAssetReceiptTaxAmount";
            this.fld_txtACAssetReceiptTaxAmount.Screen = null;
            this.fld_txtACAssetReceiptTaxAmount.Size = new System.Drawing.Size(99, 20);
            this.fld_txtACAssetReceiptTaxAmount.TabIndex = 21;
            this.fld_txtACAssetReceiptTaxAmount.Tag = "DC";
            this.fld_txtACAssetReceiptTaxAmount.Validated += new System.EventHandler(this.fld_txtACAssetReceiptTaxAmount_Validated);
            // 
            // fld_txtACAssetReceiptDiscountAmount
            // 
            this.fld_txtACAssetReceiptDiscountAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtACAssetReceiptDiscountAmount.BOSComment = null;
            this.fld_txtACAssetReceiptDiscountAmount.BOSDataMember = "ACAssetReceiptDiscountAmount";
            this.fld_txtACAssetReceiptDiscountAmount.BOSDataSource = "ACAssetReceipts";
            this.fld_txtACAssetReceiptDiscountAmount.BOSDescription = null;
            this.fld_txtACAssetReceiptDiscountAmount.BOSError = null;
            this.fld_txtACAssetReceiptDiscountAmount.BOSFieldGroup = null;
            this.fld_txtACAssetReceiptDiscountAmount.BOSFieldRelation = null;
            this.fld_txtACAssetReceiptDiscountAmount.BOSPrivilege = null;
            this.fld_txtACAssetReceiptDiscountAmount.BOSPropertyName = "Text";
            this.fld_txtACAssetReceiptDiscountAmount.EditValue = "";
            this.fld_txtACAssetReceiptDiscountAmount.Location = new System.Drawing.Point(1243, 552);
            this.fld_txtACAssetReceiptDiscountAmount.Name = "fld_txtACAssetReceiptDiscountAmount";
            this.fld_txtACAssetReceiptDiscountAmount.Screen = null;
            this.fld_txtACAssetReceiptDiscountAmount.Size = new System.Drawing.Size(99, 20);
            this.fld_txtACAssetReceiptDiscountAmount.TabIndex = 17;
            this.fld_txtACAssetReceiptDiscountAmount.Tag = "DC";
            this.fld_txtACAssetReceiptDiscountAmount.Validated += new System.EventHandler(this.fld_txtACAssetReceiptDiscountAmount_Validated);
            // 
            // fld_txtACAssetReceiptExtraFee
            // 
            this.fld_txtACAssetReceiptExtraFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtACAssetReceiptExtraFee.BOSComment = null;
            this.fld_txtACAssetReceiptExtraFee.BOSDataMember = "ACAssetReceiptExtraFee";
            this.fld_txtACAssetReceiptExtraFee.BOSDataSource = "ACAssetReceipts";
            this.fld_txtACAssetReceiptExtraFee.BOSDescription = null;
            this.fld_txtACAssetReceiptExtraFee.BOSError = null;
            this.fld_txtACAssetReceiptExtraFee.BOSFieldGroup = null;
            this.fld_txtACAssetReceiptExtraFee.BOSFieldRelation = null;
            this.fld_txtACAssetReceiptExtraFee.BOSPrivilege = null;
            this.fld_txtACAssetReceiptExtraFee.BOSPropertyName = "Text";
            this.fld_txtACAssetReceiptExtraFee.EditValue = "";
            this.fld_txtACAssetReceiptExtraFee.Location = new System.Drawing.Point(1169, 604);
            this.fld_txtACAssetReceiptExtraFee.Name = "fld_txtACAssetReceiptExtraFee";
            this.fld_txtACAssetReceiptExtraFee.Screen = null;
            this.fld_txtACAssetReceiptExtraFee.Size = new System.Drawing.Size(173, 20);
            this.fld_txtACAssetReceiptExtraFee.TabIndex = 19;
            this.fld_txtACAssetReceiptExtraFee.Tag = "DC";
            this.fld_txtACAssetReceiptExtraFee.Validated += new System.EventHandler(this.fld_txtACAssetReceiptExtraFee_Validated);
            // 
            // fld_txtACAssetReceiptShippingFee
            // 
            this.fld_txtACAssetReceiptShippingFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtACAssetReceiptShippingFee.BOSComment = null;
            this.fld_txtACAssetReceiptShippingFee.BOSDataMember = "ACAssetReceiptShippingFee";
            this.fld_txtACAssetReceiptShippingFee.BOSDataSource = "ACAssetReceipts";
            this.fld_txtACAssetReceiptShippingFee.BOSDescription = null;
            this.fld_txtACAssetReceiptShippingFee.BOSError = null;
            this.fld_txtACAssetReceiptShippingFee.BOSFieldGroup = null;
            this.fld_txtACAssetReceiptShippingFee.BOSFieldRelation = null;
            this.fld_txtACAssetReceiptShippingFee.BOSPrivilege = null;
            this.fld_txtACAssetReceiptShippingFee.BOSPropertyName = "Text";
            this.fld_txtACAssetReceiptShippingFee.EditValue = "";
            this.fld_txtACAssetReceiptShippingFee.Location = new System.Drawing.Point(1169, 578);
            this.fld_txtACAssetReceiptShippingFee.Name = "fld_txtACAssetReceiptShippingFee";
            this.fld_txtACAssetReceiptShippingFee.Screen = null;
            this.fld_txtACAssetReceiptShippingFee.Size = new System.Drawing.Size(173, 20);
            this.fld_txtACAssetReceiptShippingFee.TabIndex = 18;
            this.fld_txtACAssetReceiptShippingFee.Tag = "DC";
            this.fld_txtACAssetReceiptShippingFee.Validated += new System.EventHandler(this.fld_txtACAssetReceiptShippingFee_Validated);
            // 
            // fld_txtACAssetReceiptTotalCost
            // 
            this.fld_txtACAssetReceiptTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtACAssetReceiptTotalCost.BOSComment = null;
            this.fld_txtACAssetReceiptTotalCost.BOSDataMember = "ACAssetReceiptTotalCost";
            this.fld_txtACAssetReceiptTotalCost.BOSDataSource = "ACAssetReceipts";
            this.fld_txtACAssetReceiptTotalCost.BOSDescription = null;
            this.fld_txtACAssetReceiptTotalCost.BOSError = null;
            this.fld_txtACAssetReceiptTotalCost.BOSFieldGroup = null;
            this.fld_txtACAssetReceiptTotalCost.BOSFieldRelation = null;
            this.fld_txtACAssetReceiptTotalCost.BOSPrivilege = null;
            this.fld_txtACAssetReceiptTotalCost.BOSPropertyName = "Text";
            this.fld_txtACAssetReceiptTotalCost.EditValue = "";
            this.fld_txtACAssetReceiptTotalCost.Location = new System.Drawing.Point(1169, 656);
            this.fld_txtACAssetReceiptTotalCost.Name = "fld_txtACAssetReceiptTotalCost";
            this.fld_txtACAssetReceiptTotalCost.Properties.ReadOnly = true;
            this.fld_txtACAssetReceiptTotalCost.Screen = null;
            this.fld_txtACAssetReceiptTotalCost.Size = new System.Drawing.Size(173, 20);
            this.fld_txtACAssetReceiptTotalCost.TabIndex = 22;
            this.fld_txtACAssetReceiptTotalCost.Tag = "DC";
            // 
            // fld_txtACAssetReceiptSubTotalCost
            // 
            this.fld_txtACAssetReceiptSubTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtACAssetReceiptSubTotalCost.BOSComment = null;
            this.fld_txtACAssetReceiptSubTotalCost.BOSDataMember = "ACAssetReceiptSubTotalCost";
            this.fld_txtACAssetReceiptSubTotalCost.BOSDataSource = "ACAssetReceipts";
            this.fld_txtACAssetReceiptSubTotalCost.BOSDescription = null;
            this.fld_txtACAssetReceiptSubTotalCost.BOSError = null;
            this.fld_txtACAssetReceiptSubTotalCost.BOSFieldGroup = null;
            this.fld_txtACAssetReceiptSubTotalCost.BOSFieldRelation = null;
            this.fld_txtACAssetReceiptSubTotalCost.BOSPrivilege = null;
            this.fld_txtACAssetReceiptSubTotalCost.BOSPropertyName = "Text";
            this.fld_txtACAssetReceiptSubTotalCost.EditValue = "";
            this.fld_txtACAssetReceiptSubTotalCost.Location = new System.Drawing.Point(1169, 526);
            this.fld_txtACAssetReceiptSubTotalCost.MenuManager = this.screenToolbar;
            this.fld_txtACAssetReceiptSubTotalCost.Name = "fld_txtACAssetReceiptSubTotalCost";
            this.fld_txtACAssetReceiptSubTotalCost.Properties.ReadOnly = true;
            this.fld_txtACAssetReceiptSubTotalCost.Screen = null;
            this.fld_txtACAssetReceiptSubTotalCost.Size = new System.Drawing.Size(173, 20);
            this.fld_txtACAssetReceiptSubTotalCost.TabIndex = 15;
            this.fld_txtACAssetReceiptSubTotalCost.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(1077, 659);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(66, 13);
            this.bosLabel6.TabIndex = 17;
            this.bosLabel6.Text = "THÀNH TIỀN";
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
            this.bosLabel5.Location = new System.Drawing.Point(1119, 633);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(24, 13);
            this.bosLabel5.TabIndex = 17;
            this.bosLabel5.Text = "Thuế";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(1105, 607);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(39, 13);
            this.bosLabel4.TabIndex = 17;
            this.bosLabel4.Text = "Phí khác";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(1071, 581);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(73, 13);
            this.bosLabel3.TabIndex = 17;
            this.bosLabel3.Text = "Phí vận chuyển";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(1092, 555);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(51, 13);
            this.bosLabel2.TabIndex = 17;
            this.bosLabel2.Text = "Chiết khấu";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(1093, 529);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(50, 13);
            this.bosLabel1.TabIndex = 17;
            this.bosLabel1.Text = "Tổng cộng";
            // 
            // fld_dteACAssetReceiptInvoiceDate
            // 
            this.fld_dteACAssetReceiptInvoiceDate.BOSComment = "";
            this.fld_dteACAssetReceiptInvoiceDate.BOSDataMember = "ACAssetReceiptInvoiceDate";
            this.fld_dteACAssetReceiptInvoiceDate.BOSDataSource = "ACAssetReceipts";
            this.fld_dteACAssetReceiptInvoiceDate.BOSDescription = null;
            this.fld_dteACAssetReceiptInvoiceDate.BOSError = null;
            this.fld_dteACAssetReceiptInvoiceDate.BOSFieldGroup = "";
            this.fld_dteACAssetReceiptInvoiceDate.BOSFieldRelation = "";
            this.fld_dteACAssetReceiptInvoiceDate.BOSPrivilege = "";
            this.fld_dteACAssetReceiptInvoiceDate.BOSPropertyName = "EditValue";
            this.fld_dteACAssetReceiptInvoiceDate.EditValue = "";
            this.fld_dteACAssetReceiptInvoiceDate.Location = new System.Drawing.Point(1125, 117);
            this.fld_dteACAssetReceiptInvoiceDate.Name = "fld_dteACAssetReceiptInvoiceDate";
            this.fld_dteACAssetReceiptInvoiceDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACAssetReceiptInvoiceDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACAssetReceiptInvoiceDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACAssetReceiptInvoiceDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACAssetReceiptInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACAssetReceiptInvoiceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACAssetReceiptInvoiceDate.Screen = null;
            this.fld_dteACAssetReceiptInvoiceDate.Size = new System.Drawing.Size(161, 20);
            this.fld_dteACAssetReceiptInvoiceDate.TabIndex = 16;
            this.fld_dteACAssetReceiptInvoiceDate.Tag = "DC";
            // 
            // fld_txtACAssetReceiptInvoiceNo
            // 
            this.fld_txtACAssetReceiptInvoiceNo.BOSComment = "";
            this.fld_txtACAssetReceiptInvoiceNo.BOSDataMember = "ACAssetReceiptInvoiceNo";
            this.fld_txtACAssetReceiptInvoiceNo.BOSDataSource = "ACAssetReceipts";
            this.fld_txtACAssetReceiptInvoiceNo.BOSDescription = null;
            this.fld_txtACAssetReceiptInvoiceNo.BOSError = null;
            this.fld_txtACAssetReceiptInvoiceNo.BOSFieldGroup = "";
            this.fld_txtACAssetReceiptInvoiceNo.BOSFieldRelation = "";
            this.fld_txtACAssetReceiptInvoiceNo.BOSPrivilege = "";
            this.fld_txtACAssetReceiptInvoiceNo.BOSPropertyName = "Text";
            this.fld_txtACAssetReceiptInvoiceNo.EditValue = "";
            this.fld_txtACAssetReceiptInvoiceNo.Location = new System.Drawing.Point(1125, 91);
            this.fld_txtACAssetReceiptInvoiceNo.Name = "fld_txtACAssetReceiptInvoiceNo";
            this.fld_txtACAssetReceiptInvoiceNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACAssetReceiptInvoiceNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAssetReceiptInvoiceNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAssetReceiptInvoiceNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAssetReceiptInvoiceNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAssetReceiptInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAssetReceiptInvoiceNo.Screen = null;
            this.fld_txtACAssetReceiptInvoiceNo.Size = new System.Drawing.Size(161, 20);
            this.fld_txtACAssetReceiptInvoiceNo.TabIndex = 14;
            this.fld_txtACAssetReceiptInvoiceNo.Tag = "DC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = "";
            this.bosLabel8.BOSDataMember = "";
            this.bosLabel8.BOSDataSource = "";
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = "";
            this.bosLabel8.BOSFieldRelation = "";
            this.bosLabel8.BOSPrivilege = "";
            this.bosLabel8.BOSPropertyName = "";
            this.bosLabel8.Location = new System.Drawing.Point(1034, 120);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(67, 13);
            this.bosLabel8.TabIndex = 6;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Ngày hóa đơn";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = "";
            this.bosLabel10.BOSDataMember = "";
            this.bosLabel10.BOSDataSource = "";
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = "";
            this.bosLabel10.BOSFieldRelation = "";
            this.bosLabel10.BOSPrivilege = "";
            this.bosLabel10.BOSPropertyName = "";
            this.bosLabel10.Location = new System.Drawing.Point(127, 120);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(40, 13);
            this.bosLabel10.TabIndex = 6;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Diễn giải";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = "";
            this.bosLabel7.BOSDataMember = "";
            this.bosLabel7.BOSDataSource = "";
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = "";
            this.bosLabel7.BOSFieldRelation = "";
            this.bosLabel7.BOSPrivilege = "";
            this.bosLabel7.BOSPropertyName = "";
            this.bosLabel7.Location = new System.Drawing.Point(1034, 94);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(54, 13);
            this.bosLabel7.TabIndex = 6;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Số hóa đơn";
            // 
            // DMAR100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1359, 690);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMAR100.IconOptions.Icon")));
            this.Name = "DMAR100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetReceiptDate2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetReceiptDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACAssetReceiptDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACAssetReceiptEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAssetID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAssetReceiptItems)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACEInvoiceTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptVATFormNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleContractID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetReceiptPaymentTermDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetReceiptPaymentTermDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bkeACAssetReceiptType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptSupplierContactAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptSupplierTaxNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptSymbol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInputVATDocumentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptDiscountPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptDiscountAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptExtraFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptShippingFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptSubTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetReceiptInvoiceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetReceiptInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptInvoiceNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPictureEdit fld_pteACAssetReceiptEmployeePicture;
        private IContainer components;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private AssetReceiptItemGridControl fld_dgcAssetReceiptItems;
        private BaseDocumentEntryGridControl fld_dgcDocumentEntrys;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTextBox fld_txtACAssetReceiptSubTotalCost;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierID;
        private BOSComponent.BOSTextBox fld_txtACAssetReceiptDiscountPercent;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtACAssetReceiptDiscountAmount;
        private BOSComponent.BOSTextBox fld_txtACAssetReceiptShippingFee;
        private BOSComponent.BOSTextBox fld_txtACAssetReceiptTaxPercent;
        private BOSComponent.BOSTextBox fld_txtACAssetReceiptTaxAmount;
        private BOSComponent.BOSTextBox fld_txtACAssetReceiptExtraFee;
        private BOSComponent.BOSTextBox fld_txtACAssetReceiptTotalCost;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSDateEdit fld_dteACAssetReceiptInvoiceDate;
        private BOSComponent.BOSTextBox fld_txtACAssetReceiptInvoiceNo;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeAPInputVATDocumentType;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSTextBox fld_txtACAssetReceiptSymbol;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAssetID;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLookupEdit fld_bkeACAssetReceiptType;
        private BOSComponent.BOSTextBox fld_txtACAssetReceiptSupplierContactAddress;
        private BOSComponent.BOSTextBox fld_txtACAssetReceiptSupplierTaxNumber;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSDateEdit fld_dteACAssetReceiptPaymentTermDate;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACEInvoiceTypeID;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSTextBox fld_txtACAssetReceiptVATFormNo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSaleContractID;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID;
    }
}
