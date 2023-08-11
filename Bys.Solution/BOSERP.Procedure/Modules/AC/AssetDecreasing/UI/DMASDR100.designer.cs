using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AssetDecreasing.UI
{
	/// <summary>
	/// Summary description for DMNTS100
	/// </summary>
    partial class DMASDR100
	{
		private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel fld_lblLabel6;
		private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSLabel fld_lblLabel9;
		private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
		private BOSComponent.BOSTextBox fld_txtICShipmentNo1;
		private BOSComponent.BOSDateEdit fld_dteICShipmentDate;
		private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
		private BOSComponent.BOSTextBox fld_txtICShipmentExchangeRate;
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
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICShipmentNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteICShipmentDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICShipmentExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.fld_medACAssetReceiptDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_pteICShipmentEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lkeFK_ICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcICShipmentItems = new BOSERP.Modules.AssetDecreasing.ShipmentItemGridControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_ICStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICOutputVATInvoiceNoCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICShipmentSymbol = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICShipmentFormNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICOutputVATDocumentType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICShipmentTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICShipmentDiscountPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICShipmentTaxAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICShipmentDiscountFix = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICShipmentShippingExtraFees = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICShipmentShippingFees = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICShipmentTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICShipmentSubTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACAssetReceiptDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICShipmentEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentItems)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICOutputVATInvoiceNoCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentSymbol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentFormNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICOutputVATDocumentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentDiscountPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentShippingExtraFees.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentShippingFees.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentSubTotalAmount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel5.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel5.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel5.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel5.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel5.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel5.Location = new System.Drawing.Point(127, 16);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel5.TabIndex = 4;
            this.fld_lblLabel5.Tag = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel5.Text = "Mã chứng từ";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel6.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel6.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel6.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel6.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel6.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel6.Location = new System.Drawing.Point(449, 16);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel6.TabIndex = 5;
            this.fld_lblLabel6.Tag = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel6.Text = "Ngày chứng từ";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel8.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel8.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel8.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel8.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel8.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel8.Location = new System.Drawing.Point(449, 42);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(53, 13);
            this.fld_lblLabel8.TabIndex = 7;
            this.fld_lblLabel8.Tag = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel8.Text = "Loại tiền tệ";
            // 
            // fld_lblLabel9
            // 
            this.fld_lblLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel9.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel9.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel9.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel9.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel9.BOSDescription = null;
            this.fld_lblLabel9.BOSError = null;
            this.fld_lblLabel9.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel9.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel9.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel9.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel9.Location = new System.Drawing.Point(754, 16);
            this.fld_lblLabel9.Name = "fld_lblLabel9";
            this.fld_lblLabel9.Screen = null;
            this.fld_lblLabel9.Size = new System.Drawing.Size(29, 13);
            this.fld_lblLabel9.TabIndex = 8;
            this.fld_lblLabel9.Tag = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel9.Text = "Tỷ giá";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ICShipments";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(3, 102);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.CommonLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 10;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
            // 
            // fld_txtICShipmentNo1
            // 
            this.fld_txtICShipmentNo1.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtICShipmentNo1.BOSDataMember = "ICShipmentNo";
            this.fld_txtICShipmentNo1.BOSDataSource = "ICShipments";
            this.fld_txtICShipmentNo1.BOSDescription = null;
            this.fld_txtICShipmentNo1.BOSError = null;
            this.fld_txtICShipmentNo1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtICShipmentNo1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtICShipmentNo1.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtICShipmentNo1.BOSPropertyName = "Text";
            this.fld_txtICShipmentNo1.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtICShipmentNo1.Location = new System.Drawing.Point(221, 13);
            this.fld_txtICShipmentNo1.Name = "fld_txtICShipmentNo1";
            this.fld_txtICShipmentNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICShipmentNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICShipmentNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICShipmentNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICShipmentNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICShipmentNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICShipmentNo1.Screen = null;
            this.fld_txtICShipmentNo1.Size = new System.Drawing.Size(169, 20);
            this.fld_txtICShipmentNo1.TabIndex = 1;
            this.fld_txtICShipmentNo1.Tag = "DC";
            // 
            // fld_dteICShipmentDate
            // 
            this.fld_dteICShipmentDate.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteICShipmentDate.BOSDataMember = "ICShipmentDate";
            this.fld_dteICShipmentDate.BOSDataSource = "ICShipments";
            this.fld_dteICShipmentDate.BOSDescription = null;
            this.fld_dteICShipmentDate.BOSError = null;
            this.fld_dteICShipmentDate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteICShipmentDate.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteICShipmentDate.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteICShipmentDate.BOSPropertyName = "EditValue";
            this.fld_dteICShipmentDate.EditValue = null;
            this.fld_dteICShipmentDate.Location = new System.Drawing.Point(539, 13);
            this.fld_dteICShipmentDate.Name = "fld_dteICShipmentDate";
            this.fld_dteICShipmentDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICShipmentDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICShipmentDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICShipmentDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICShipmentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICShipmentDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICShipmentDate.Screen = null;
            this.fld_dteICShipmentDate.Size = new System.Drawing.Size(165, 20);
            this.fld_dteICShipmentDate.TabIndex = 2;
            this.fld_dteICShipmentDate.Tag = "DC";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(539, 39);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyNo";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(165, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 4;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // fld_txtICShipmentExchangeRate
            // 
            this.fld_txtICShipmentExchangeRate.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtICShipmentExchangeRate.BOSDataMember = "ICShipmentExchangeRate";
            this.fld_txtICShipmentExchangeRate.BOSDataSource = "ICShipments";
            this.fld_txtICShipmentExchangeRate.BOSDescription = null;
            this.fld_txtICShipmentExchangeRate.BOSError = null;
            this.fld_txtICShipmentExchangeRate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtICShipmentExchangeRate.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtICShipmentExchangeRate.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtICShipmentExchangeRate.BOSPropertyName = "Text";
            this.fld_txtICShipmentExchangeRate.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtICShipmentExchangeRate.Location = new System.Drawing.Point(861, 14);
            this.fld_txtICShipmentExchangeRate.Name = "fld_txtICShipmentExchangeRate";
            this.fld_txtICShipmentExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICShipmentExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICShipmentExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICShipmentExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICShipmentExchangeRate.Properties.Mask.EditMask = "n";
            this.fld_txtICShipmentExchangeRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICShipmentExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICShipmentExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICShipmentExchangeRate.Screen = null;
            this.fld_txtICShipmentExchangeRate.Size = new System.Drawing.Size(162, 20);
            this.fld_txtICShipmentExchangeRate.TabIndex = 5;
            this.fld_txtICShipmentExchangeRate.Tag = "DC";
            // 
            // fld_medACAssetReceiptDesc
            // 
            this.fld_medACAssetReceiptDesc.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_medACAssetReceiptDesc.BOSDataMember = "ACAssetReceiptDesc";
            this.fld_medACAssetReceiptDesc.BOSDataSource = "ACAssetReceipts";
            this.fld_medACAssetReceiptDesc.BOSDescription = null;
            this.fld_medACAssetReceiptDesc.BOSError = null;
            this.fld_medACAssetReceiptDesc.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_medACAssetReceiptDesc.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_medACAssetReceiptDesc.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_medACAssetReceiptDesc.BOSPropertyName = "Text";
            this.fld_medACAssetReceiptDesc.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_medACAssetReceiptDesc.Location = new System.Drawing.Point(221, 91);
            this.fld_medACAssetReceiptDesc.Name = "fld_medACAssetReceiptDesc";
            this.fld_medACAssetReceiptDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACAssetReceiptDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACAssetReceiptDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACAssetReceiptDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACAssetReceiptDesc.Screen = null;
            this.fld_medACAssetReceiptDesc.Size = new System.Drawing.Size(483, 46);
            this.fld_medACAssetReceiptDesc.TabIndex = 8;
            this.fld_medACAssetReceiptDesc.Tag = "DC";
            // 
            // fld_pteICShipmentEmployeePicture
            // 
            this.fld_pteICShipmentEmployeePicture.BOSComment = null;
            this.fld_pteICShipmentEmployeePicture.BOSDataMember = "ICShipmentEmployeePicture";
            this.fld_pteICShipmentEmployeePicture.BOSDataSource = "ICShipments";
            this.fld_pteICShipmentEmployeePicture.BOSDescription = null;
            this.fld_pteICShipmentEmployeePicture.BOSError = null;
            this.fld_pteICShipmentEmployeePicture.BOSFieldGroup = null;
            this.fld_pteICShipmentEmployeePicture.BOSFieldRelation = null;
            this.fld_pteICShipmentEmployeePicture.BOSPrivilege = null;
            this.fld_pteICShipmentEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteICShipmentEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteICShipmentEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteICShipmentEmployeePicture.Name = "fld_pteICShipmentEmployeePicture";
            this.fld_pteICShipmentEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICShipmentEmployeePicture.Screen = null;
            this.fld_pteICShipmentEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteICShipmentEmployeePicture.TabIndex = 16;
            this.fld_pteICShipmentEmployeePicture.Tag = "DC";
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
            this.bosTabControl1.Location = new System.Drawing.Point(3, 143);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(1034, 262);
            this.bosTabControl1.TabIndex = 14;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_lkeFK_ICProductID);
            this.xtraTabPage1.Controls.Add(this.bosLabel9);
            this.xtraTabPage1.Controls.Add(this.fld_dgcICShipmentItems);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1027, 233);
            this.xtraTabPage1.Text = "Danh sách tài sản";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = null;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ICShipmentItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(65, 9);
            this.fld_lkeFK_ICProductID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(952, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 29;
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
            this.bosLabel9.Location = new System.Drawing.Point(12, 12);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(34, 13);
            this.bosLabel9.TabIndex = 28;
            this.bosLabel9.Text = "Tài sản";
            // 
            // fld_dgcICShipmentItems
            // 
            this.fld_dgcICShipmentItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICShipmentItems.BOSComment = null;
            this.fld_dgcICShipmentItems.BOSDataMember = null;
            this.fld_dgcICShipmentItems.BOSDataSource = "ICShipmentItems";
            this.fld_dgcICShipmentItems.BOSDescription = null;
            this.fld_dgcICShipmentItems.BOSError = null;
            this.fld_dgcICShipmentItems.BOSFieldGroup = null;
            this.fld_dgcICShipmentItems.BOSFieldRelation = null;
            this.fld_dgcICShipmentItems.BOSGridType = null;
            this.fld_dgcICShipmentItems.BOSPrivilege = null;
            this.fld_dgcICShipmentItems.BOSPropertyName = null;
            this.fld_dgcICShipmentItems.Location = new System.Drawing.Point(0, 44);
            this.fld_dgcICShipmentItems.MenuManager = this.screenToolbar;
            this.fld_dgcICShipmentItems.Name = "fld_dgcICShipmentItems";
            this.fld_dgcICShipmentItems.PrintReport = false;
            this.fld_dgcICShipmentItems.Screen = null;
            this.fld_dgcICShipmentItems.Size = new System.Drawing.Size(1027, 189);
            this.fld_dgcICShipmentItems.TabIndex = 0;
            this.fld_dgcICShipmentItems.Tag = "DC";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcDocumentEntrys);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.PageVisible = false;
            this.xtraTabPage2.Size = new System.Drawing.Size(1027, 233);
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
            this.fld_dgcDocumentEntrys.Size = new System.Drawing.Size(1027, 233);
            this.fld_dgcDocumentEntrys.TabIndex = 0;
            this.fld_dgcDocumentEntrys.Tag = "DC";
            this.fld_dgcDocumentEntrys.Visible = false;
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICStockID);
            this.bosPanel1.Controls.Add(this.bosLabel14);
            this.bosPanel1.Controls.Add(this.fld_lkeICOutputVATInvoiceNoCombo);
            this.bosPanel1.Controls.Add(this.bosLabel13);
            this.bosPanel1.Controls.Add(this.bosLabel20);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentSymbol);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentFormNo);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_lkeICOutputVATDocumentType);
            this.bosPanel1.Controls.Add(this.fld_medACAssetReceiptDesc);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentTaxPercent);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentDiscountPercent);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentTaxAmount);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentDiscountFix);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentShippingExtraFees);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentShippingFees);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentTotalAmount);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentSubTotalAmount);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_pteICShipmentEmployeePicture);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentExchangeRate);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_dteICShipmentDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel6);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentNo1);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel8);
            this.bosPanel1.Controls.Add(this.fld_lblLabel9);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1040, 582);
            this.bosPanel1.TabIndex = 19;
            // 
            // fld_lkeFK_ICStockID
            // 
            this.fld_lkeFK_ICStockID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICStockID.BOSAllowDummy = false;
            this.fld_lkeFK_ICStockID.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ICStockID.BOSDataMember = "FK_ICStockID";
            this.fld_lkeFK_ICStockID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_ICStockID.BOSDescription = null;
            this.fld_lkeFK_ICStockID.BOSError = null;
            this.fld_lkeFK_ICStockID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ICStockID.BOSFieldParent = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ICStockID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ICStockID.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ICStockID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICStockID.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ICStockID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ICStockID.CurrentDisplayText = null;
            this.fld_lkeFK_ICStockID.Location = new System.Drawing.Point(221, 40);
            this.fld_lkeFK_ICStockID.Name = "fld_lkeFK_ICStockID";
            this.fld_lkeFK_ICStockID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICStockID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICStockID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICStockID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICStockID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.CommonLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Name")});
            this.fld_lkeFK_ICStockID.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICStockID.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ICStockID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICStockID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICStockID.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICStockID.Screen = null;
            this.fld_lkeFK_ICStockID.Size = new System.Drawing.Size(169, 20);
            this.fld_lkeFK_ICStockID.TabIndex = 103;
            this.fld_lkeFK_ICStockID.Tag = "DC";
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel14.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel14.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel14.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel14.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel14.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel14.Location = new System.Drawing.Point(127, 42);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(18, 13);
            this.bosLabel14.TabIndex = 104;
            this.bosLabel14.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel14.Text = "Kho";
            // 
            // fld_lkeICOutputVATInvoiceNoCombo
            // 
            this.fld_lkeICOutputVATInvoiceNoCombo.BOSAllowAddNew = false;
            this.fld_lkeICOutputVATInvoiceNoCombo.BOSAllowDummy = true;
            this.fld_lkeICOutputVATInvoiceNoCombo.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeICOutputVATInvoiceNoCombo.BOSDataMember = "ICOutputVATInvoiceNoCombo";
            this.fld_lkeICOutputVATInvoiceNoCombo.BOSDataSource = "ICShipments";
            this.fld_lkeICOutputVATInvoiceNoCombo.BOSDescription = null;
            this.fld_lkeICOutputVATInvoiceNoCombo.BOSError = null;
            this.fld_lkeICOutputVATInvoiceNoCombo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeICOutputVATInvoiceNoCombo.BOSFieldParent = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeICOutputVATInvoiceNoCombo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeICOutputVATInvoiceNoCombo.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeICOutputVATInvoiceNoCombo.BOSPropertyName = "EditValue";
            this.fld_lkeICOutputVATInvoiceNoCombo.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeICOutputVATInvoiceNoCombo.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeICOutputVATInvoiceNoCombo.CurrentDisplayText = null;
            this.fld_lkeICOutputVATInvoiceNoCombo.Location = new System.Drawing.Point(539, 65);
            this.fld_lkeICOutputVATInvoiceNoCombo.Name = "fld_lkeICOutputVATInvoiceNoCombo";
            this.fld_lkeICOutputVATInvoiceNoCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICOutputVATInvoiceNoCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICOutputVATInvoiceNoCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICOutputVATInvoiceNoCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICOutputVATInvoiceNoCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICOutputVATInvoiceNoCombo.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeICOutputVATInvoiceNoCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICOutputVATInvoiceNoCombo.Screen = null;
            this.fld_lkeICOutputVATInvoiceNoCombo.Size = new System.Drawing.Size(165, 20);
            this.fld_lkeICOutputVATInvoiceNoCombo.TabIndex = 101;
            this.fld_lkeICOutputVATInvoiceNoCombo.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel13.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel13.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel13.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel13.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(449, 68);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(85, 13);
            this.bosLabel13.TabIndex = 102;
            this.bosLabel13.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel13.Text = "Mã hóa đơn GTGT";
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseForeColor = true;
            this.bosLabel20.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel20.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel20.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel20.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel20.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(754, 68);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(35, 13);
            this.bosLabel20.TabIndex = 100;
            this.bosLabel20.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel20.Text = "Ký hiệu";
            // 
            // fld_txtICShipmentSymbol
            // 
            this.fld_txtICShipmentSymbol.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtICShipmentSymbol.BOSDataMember = "ICShipmentSymbol";
            this.fld_txtICShipmentSymbol.BOSDataSource = "ICShipments";
            this.fld_txtICShipmentSymbol.BOSDescription = null;
            this.fld_txtICShipmentSymbol.BOSError = null;
            this.fld_txtICShipmentSymbol.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtICShipmentSymbol.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtICShipmentSymbol.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtICShipmentSymbol.BOSPropertyName = "EditValue";
            this.fld_txtICShipmentSymbol.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtICShipmentSymbol.Location = new System.Drawing.Point(861, 66);
            this.fld_txtICShipmentSymbol.Name = "fld_txtICShipmentSymbol";
            this.fld_txtICShipmentSymbol.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICShipmentSymbol.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICShipmentSymbol.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICShipmentSymbol.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICShipmentSymbol.Properties.Mask.EditMask = "n";
            this.fld_txtICShipmentSymbol.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICShipmentSymbol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICShipmentSymbol.Screen = null;
            this.fld_txtICShipmentSymbol.Size = new System.Drawing.Size(161, 20);
            this.fld_txtICShipmentSymbol.TabIndex = 99;
            this.fld_txtICShipmentSymbol.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(754, 43);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(34, 13);
            this.bosLabel12.TabIndex = 98;
            this.bosLabel12.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.Text = "Mẫu số";
            // 
            // fld_txtICShipmentFormNo
            // 
            this.fld_txtICShipmentFormNo.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtICShipmentFormNo.BOSDataMember = "ICShipmentFormNo";
            this.fld_txtICShipmentFormNo.BOSDataSource = "ICShipments";
            this.fld_txtICShipmentFormNo.BOSDescription = null;
            this.fld_txtICShipmentFormNo.BOSError = null;
            this.fld_txtICShipmentFormNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtICShipmentFormNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtICShipmentFormNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtICShipmentFormNo.BOSPropertyName = "EditValue";
            this.fld_txtICShipmentFormNo.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtICShipmentFormNo.Location = new System.Drawing.Point(861, 40);
            this.fld_txtICShipmentFormNo.Name = "fld_txtICShipmentFormNo";
            this.fld_txtICShipmentFormNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICShipmentFormNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICShipmentFormNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICShipmentFormNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICShipmentFormNo.Properties.Mask.EditMask = "n";
            this.fld_txtICShipmentFormNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICShipmentFormNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICShipmentFormNo.Screen = null;
            this.fld_txtICShipmentFormNo.Size = new System.Drawing.Size(161, 20);
            this.fld_txtICShipmentFormNo.TabIndex = 97;
            this.fld_txtICShipmentFormNo.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel11.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel11.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel11.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel11.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(127, 68);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(61, 13);
            this.bosLabel11.TabIndex = 79;
            this.bosLabel11.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel11.Text = "Loại hóa đơn";
            // 
            // fld_lkeICOutputVATDocumentType
            // 
            this.fld_lkeICOutputVATDocumentType.BOSAllowAddNew = false;
            this.fld_lkeICOutputVATDocumentType.BOSAllowDummy = false;
            this.fld_lkeICOutputVATDocumentType.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeICOutputVATDocumentType.BOSDataMember = "ICOutputVATDocumentType";
            this.fld_lkeICOutputVATDocumentType.BOSDataSource = "ICShipments";
            this.fld_lkeICOutputVATDocumentType.BOSDescription = null;
            this.fld_lkeICOutputVATDocumentType.BOSError = null;
            this.fld_lkeICOutputVATDocumentType.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeICOutputVATDocumentType.BOSFieldParent = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeICOutputVATDocumentType.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeICOutputVATDocumentType.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeICOutputVATDocumentType.BOSPropertyName = "EditValue";
            this.fld_lkeICOutputVATDocumentType.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeICOutputVATDocumentType.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeICOutputVATDocumentType.CurrentDisplayText = null;
            this.fld_lkeICOutputVATDocumentType.Location = new System.Drawing.Point(221, 65);
            this.fld_lkeICOutputVATDocumentType.Name = "fld_lkeICOutputVATDocumentType";
            this.fld_lkeICOutputVATDocumentType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICOutputVATDocumentType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICOutputVATDocumentType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICOutputVATDocumentType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICOutputVATDocumentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICOutputVATDocumentType.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeICOutputVATDocumentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICOutputVATDocumentType.Screen = null;
            this.fld_lkeICOutputVATDocumentType.Size = new System.Drawing.Size(169, 20);
            this.fld_lkeICOutputVATDocumentType.TabIndex = 78;
            this.fld_lkeICOutputVATDocumentType.Tag = "DC";
            // 
            // fld_txtICShipmentTaxPercent
            // 
            this.fld_txtICShipmentTaxPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICShipmentTaxPercent.BOSComment = null;
            this.fld_txtICShipmentTaxPercent.BOSDataMember = "ICShipmentTaxPercent";
            this.fld_txtICShipmentTaxPercent.BOSDataSource = "ICShipments";
            this.fld_txtICShipmentTaxPercent.BOSDescription = null;
            this.fld_txtICShipmentTaxPercent.BOSError = null;
            this.fld_txtICShipmentTaxPercent.BOSFieldGroup = null;
            this.fld_txtICShipmentTaxPercent.BOSFieldRelation = null;
            this.fld_txtICShipmentTaxPercent.BOSPrivilege = null;
            this.fld_txtICShipmentTaxPercent.BOSPropertyName = "Text";
            this.fld_txtICShipmentTaxPercent.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.fld_txtICShipmentTaxPercent.Location = new System.Drawing.Point(850, 522);
            this.fld_txtICShipmentTaxPercent.Name = "fld_txtICShipmentTaxPercent";
            this.fld_txtICShipmentTaxPercent.Screen = null;
            this.fld_txtICShipmentTaxPercent.Size = new System.Drawing.Size(68, 20);
            this.fld_txtICShipmentTaxPercent.TabIndex = 24;
            this.fld_txtICShipmentTaxPercent.Tag = "DC";
            this.fld_txtICShipmentTaxPercent.Validated += new System.EventHandler(this.fld_txtACAssetReceiptTaxPercent_Validated);
            // 
            // fld_txtICShipmentDiscountPercent
            // 
            this.fld_txtICShipmentDiscountPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICShipmentDiscountPercent.BOSComment = null;
            this.fld_txtICShipmentDiscountPercent.BOSDataMember = "ICShipmentDiscountPercent";
            this.fld_txtICShipmentDiscountPercent.BOSDataSource = "ICShipments";
            this.fld_txtICShipmentDiscountPercent.BOSDescription = null;
            this.fld_txtICShipmentDiscountPercent.BOSError = null;
            this.fld_txtICShipmentDiscountPercent.BOSFieldGroup = null;
            this.fld_txtICShipmentDiscountPercent.BOSFieldRelation = null;
            this.fld_txtICShipmentDiscountPercent.BOSPrivilege = null;
            this.fld_txtICShipmentDiscountPercent.BOSPropertyName = "Text";
            this.fld_txtICShipmentDiscountPercent.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.fld_txtICShipmentDiscountPercent.Location = new System.Drawing.Point(850, 444);
            this.fld_txtICShipmentDiscountPercent.MenuManager = this.screenToolbar;
            this.fld_txtICShipmentDiscountPercent.Name = "fld_txtICShipmentDiscountPercent";
            this.fld_txtICShipmentDiscountPercent.Screen = null;
            this.fld_txtICShipmentDiscountPercent.Size = new System.Drawing.Size(68, 20);
            this.fld_txtICShipmentDiscountPercent.TabIndex = 20;
            this.fld_txtICShipmentDiscountPercent.Tag = "DC";
            this.fld_txtICShipmentDiscountPercent.Validated += new System.EventHandler(this.fld_txtACAssetReceiptDiscountPercent_Validated);
            // 
            // fld_txtICShipmentTaxAmount
            // 
            this.fld_txtICShipmentTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICShipmentTaxAmount.BOSComment = null;
            this.fld_txtICShipmentTaxAmount.BOSDataMember = "ICShipmentTaxAmount";
            this.fld_txtICShipmentTaxAmount.BOSDataSource = "ICShipments";
            this.fld_txtICShipmentTaxAmount.BOSDescription = null;
            this.fld_txtICShipmentTaxAmount.BOSError = null;
            this.fld_txtICShipmentTaxAmount.BOSFieldGroup = null;
            this.fld_txtICShipmentTaxAmount.BOSFieldRelation = null;
            this.fld_txtICShipmentTaxAmount.BOSPrivilege = null;
            this.fld_txtICShipmentTaxAmount.BOSPropertyName = "Text";
            this.fld_txtICShipmentTaxAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.fld_txtICShipmentTaxAmount.Location = new System.Drawing.Point(924, 522);
            this.fld_txtICShipmentTaxAmount.Name = "fld_txtICShipmentTaxAmount";
            this.fld_txtICShipmentTaxAmount.Screen = null;
            this.fld_txtICShipmentTaxAmount.Size = new System.Drawing.Size(99, 20);
            this.fld_txtICShipmentTaxAmount.TabIndex = 25;
            this.fld_txtICShipmentTaxAmount.Tag = "DC";
            this.fld_txtICShipmentTaxAmount.Validated += new System.EventHandler(this.fld_txtACAssetReceiptTaxAmount_Validated);
            // 
            // fld_txtICShipmentDiscountFix
            // 
            this.fld_txtICShipmentDiscountFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICShipmentDiscountFix.BOSComment = null;
            this.fld_txtICShipmentDiscountFix.BOSDataMember = "ICShipmentDiscountFix";
            this.fld_txtICShipmentDiscountFix.BOSDataSource = "ICShipments";
            this.fld_txtICShipmentDiscountFix.BOSDescription = null;
            this.fld_txtICShipmentDiscountFix.BOSError = null;
            this.fld_txtICShipmentDiscountFix.BOSFieldGroup = null;
            this.fld_txtICShipmentDiscountFix.BOSFieldRelation = null;
            this.fld_txtICShipmentDiscountFix.BOSPrivilege = null;
            this.fld_txtICShipmentDiscountFix.BOSPropertyName = "Text";
            this.fld_txtICShipmentDiscountFix.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.fld_txtICShipmentDiscountFix.Location = new System.Drawing.Point(924, 444);
            this.fld_txtICShipmentDiscountFix.Name = "fld_txtICShipmentDiscountFix";
            this.fld_txtICShipmentDiscountFix.Screen = null;
            this.fld_txtICShipmentDiscountFix.Size = new System.Drawing.Size(99, 20);
            this.fld_txtICShipmentDiscountFix.TabIndex = 21;
            this.fld_txtICShipmentDiscountFix.Tag = "DC";
            this.fld_txtICShipmentDiscountFix.Validated += new System.EventHandler(this.fld_txtACAssetReceiptDiscountAmount_Validated);
            // 
            // fld_txtICShipmentShippingExtraFees
            // 
            this.fld_txtICShipmentShippingExtraFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICShipmentShippingExtraFees.BOSComment = null;
            this.fld_txtICShipmentShippingExtraFees.BOSDataMember = "ICShipmentShippingExtraFees";
            this.fld_txtICShipmentShippingExtraFees.BOSDataSource = "ICShipments";
            this.fld_txtICShipmentShippingExtraFees.BOSDescription = null;
            this.fld_txtICShipmentShippingExtraFees.BOSError = null;
            this.fld_txtICShipmentShippingExtraFees.BOSFieldGroup = null;
            this.fld_txtICShipmentShippingExtraFees.BOSFieldRelation = null;
            this.fld_txtICShipmentShippingExtraFees.BOSPrivilege = null;
            this.fld_txtICShipmentShippingExtraFees.BOSPropertyName = "Text";
            this.fld_txtICShipmentShippingExtraFees.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.fld_txtICShipmentShippingExtraFees.Location = new System.Drawing.Point(850, 496);
            this.fld_txtICShipmentShippingExtraFees.Name = "fld_txtICShipmentShippingExtraFees";
            this.fld_txtICShipmentShippingExtraFees.Screen = null;
            this.fld_txtICShipmentShippingExtraFees.Size = new System.Drawing.Size(173, 20);
            this.fld_txtICShipmentShippingExtraFees.TabIndex = 23;
            this.fld_txtICShipmentShippingExtraFees.Tag = "DC";
            this.fld_txtICShipmentShippingExtraFees.Validated += new System.EventHandler(this.fld_txtACAssetReceiptExtraFee_Validated);
            // 
            // fld_txtICShipmentShippingFees
            // 
            this.fld_txtICShipmentShippingFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICShipmentShippingFees.BOSComment = null;
            this.fld_txtICShipmentShippingFees.BOSDataMember = "ICShipmentShippingFees";
            this.fld_txtICShipmentShippingFees.BOSDataSource = "ICShipments";
            this.fld_txtICShipmentShippingFees.BOSDescription = null;
            this.fld_txtICShipmentShippingFees.BOSError = null;
            this.fld_txtICShipmentShippingFees.BOSFieldGroup = null;
            this.fld_txtICShipmentShippingFees.BOSFieldRelation = null;
            this.fld_txtICShipmentShippingFees.BOSPrivilege = null;
            this.fld_txtICShipmentShippingFees.BOSPropertyName = "Text";
            this.fld_txtICShipmentShippingFees.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.fld_txtICShipmentShippingFees.Location = new System.Drawing.Point(850, 470);
            this.fld_txtICShipmentShippingFees.Name = "fld_txtICShipmentShippingFees";
            this.fld_txtICShipmentShippingFees.Screen = null;
            this.fld_txtICShipmentShippingFees.Size = new System.Drawing.Size(173, 20);
            this.fld_txtICShipmentShippingFees.TabIndex = 22;
            this.fld_txtICShipmentShippingFees.Tag = "DC";
            this.fld_txtICShipmentShippingFees.Validated += new System.EventHandler(this.fld_txtACAssetReceiptShippingFee_Validated);
            // 
            // fld_txtICShipmentTotalAmount
            // 
            this.fld_txtICShipmentTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICShipmentTotalAmount.BOSComment = null;
            this.fld_txtICShipmentTotalAmount.BOSDataMember = "ICShipmentTotalAmount";
            this.fld_txtICShipmentTotalAmount.BOSDataSource = "ICShipments";
            this.fld_txtICShipmentTotalAmount.BOSDescription = null;
            this.fld_txtICShipmentTotalAmount.BOSError = null;
            this.fld_txtICShipmentTotalAmount.BOSFieldGroup = null;
            this.fld_txtICShipmentTotalAmount.BOSFieldRelation = null;
            this.fld_txtICShipmentTotalAmount.BOSPrivilege = null;
            this.fld_txtICShipmentTotalAmount.BOSPropertyName = "Text";
            this.fld_txtICShipmentTotalAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.fld_txtICShipmentTotalAmount.Location = new System.Drawing.Point(850, 548);
            this.fld_txtICShipmentTotalAmount.Name = "fld_txtICShipmentTotalAmount";
            this.fld_txtICShipmentTotalAmount.Properties.ReadOnly = true;
            this.fld_txtICShipmentTotalAmount.Screen = null;
            this.fld_txtICShipmentTotalAmount.Size = new System.Drawing.Size(173, 20);
            this.fld_txtICShipmentTotalAmount.TabIndex = 26;
            this.fld_txtICShipmentTotalAmount.Tag = "DC";
            // 
            // fld_txtICShipmentSubTotalAmount
            // 
            this.fld_txtICShipmentSubTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICShipmentSubTotalAmount.BOSComment = null;
            this.fld_txtICShipmentSubTotalAmount.BOSDataMember = "ICShipmentSubTotalAmount";
            this.fld_txtICShipmentSubTotalAmount.BOSDataSource = "ICShipments";
            this.fld_txtICShipmentSubTotalAmount.BOSDescription = null;
            this.fld_txtICShipmentSubTotalAmount.BOSError = null;
            this.fld_txtICShipmentSubTotalAmount.BOSFieldGroup = null;
            this.fld_txtICShipmentSubTotalAmount.BOSFieldRelation = null;
            this.fld_txtICShipmentSubTotalAmount.BOSPrivilege = null;
            this.fld_txtICShipmentSubTotalAmount.BOSPropertyName = "Text";
            this.fld_txtICShipmentSubTotalAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.fld_txtICShipmentSubTotalAmount.Location = new System.Drawing.Point(850, 418);
            this.fld_txtICShipmentSubTotalAmount.MenuManager = this.screenToolbar;
            this.fld_txtICShipmentSubTotalAmount.Name = "fld_txtICShipmentSubTotalAmount";
            this.fld_txtICShipmentSubTotalAmount.Properties.ReadOnly = true;
            this.fld_txtICShipmentSubTotalAmount.Screen = null;
            this.fld_txtICShipmentSubTotalAmount.Size = new System.Drawing.Size(173, 20);
            this.fld_txtICShipmentSubTotalAmount.TabIndex = 18;
            this.fld_txtICShipmentSubTotalAmount.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(758, 551);
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
            this.bosLabel5.Location = new System.Drawing.Point(800, 525);
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
            this.bosLabel4.Location = new System.Drawing.Point(786, 499);
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
            this.bosLabel3.Location = new System.Drawing.Point(752, 473);
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
            this.bosLabel2.Location = new System.Drawing.Point(773, 447);
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
            this.bosLabel1.Location = new System.Drawing.Point(774, 421);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(50, 13);
            this.bosLabel1.TabIndex = 17;
            this.bosLabel1.Text = "Tổng cộng";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel10.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel10.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel10.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel10.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel10.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel10.Location = new System.Drawing.Point(127, 94);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(40, 13);
            this.bosLabel10.TabIndex = 6;
            this.bosLabel10.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel10.Text = "Diễn giải";
            // 
            // DMASDR100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1040, 582);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMASDR100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACAssetReceiptDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICShipmentEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentItems)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICOutputVATInvoiceNoCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentSymbol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentFormNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICOutputVATDocumentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentDiscountPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentShippingExtraFees.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentShippingFees.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentSubTotalAmount.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPictureEdit fld_pteICShipmentEmployeePicture;
        private IContainer components;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private ShipmentItemGridControl fld_dgcICShipmentItems;
        private BaseDocumentEntryGridControl fld_dgcDocumentEntrys;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTextBox fld_txtICShipmentSubTotalAmount;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtICShipmentDiscountPercent;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtICShipmentDiscountFix;
        private BOSComponent.BOSTextBox fld_txtICShipmentShippingFees;
        private BOSComponent.BOSTextBox fld_txtICShipmentTaxPercent;
        private BOSComponent.BOSTextBox fld_txtICShipmentTaxAmount;
        private BOSComponent.BOSTextBox fld_txtICShipmentShippingExtraFees;
        private BOSComponent.BOSTextBox fld_txtICShipmentTotalAmount;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeICOutputVATDocumentType;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSTextBox fld_txtICShipmentFormNo;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSTextBox fld_txtICShipmentSymbol;
        private BOSComponent.BOSLookupEdit fld_lkeICOutputVATInvoiceNoCombo;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID;
	}
}
