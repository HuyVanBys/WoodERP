using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ElectronicInvoiceBKAV.UI
{
	/// <summary>
	/// Summary description for DMEI100
	/// </summary>
	partial class DMEIBKAV100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMEIBKAV100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLine6 = new BOSComponent.BOSLine(this.components);
            this.fld_dteAdditionalReferenceDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtOriginalInvoiceId = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel28 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAdditionalReferenceDesc = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel29 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel30 = new BOSComponent.BOSLabel(this.components);
            this.bosLine5 = new BOSComponent.BOSLine(this.components);
            this.fld_cmbTaxOfficeCode = new BOSComponent.BOSComboBox(this.components);
            this.fld_txtDiscountAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosMemoEdit1 = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel46 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtSumOfTotalLineAmountWithoutVAT = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtTotalVATAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtTotalAmountWithVAT = new BOSComponent.BOSTextBox(this.components);
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.fld_txtBuyerDisplayName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel37 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_cmbBuyerType = new BOSComponent.BOSComboBox(this.components);
            this.fld_txtBuyerEmail = new BOSComponent.BOSTextBox(this.components);
            this.fld_cmbACEInvoiceGeneralReceiveType = new BOSComponent.BOSComboBox(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtBuyerCode = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtBuyerLegalName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel35 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtBuyerAddressLine = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel34 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel31 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtBuyerBankNumber = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtBuyerPhoneNumber = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtBuyerBankName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel32 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtBuyerTaxCode = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACTaxUnitID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_cmbPaymentStatus = new BOSComponent.BOSComboBox(this.components);
            this.fld_txtPublicKey = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACEInvoiceGeneralStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACEInvoicePaymentMethodName = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_medARAllocationDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtTemplateCode = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtInvoiceSeries = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACEInvoiceGeneralNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel36 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSubmittedDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteInvoiceIssuedDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtContractNumber = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtInvoiceName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel33 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtInvoiceNumber = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACEInvoiceDetails = new BOSERP.Modules.ElectronicInvoiceBKAV.EInvoiceDetailsGridControl();
            this.bosPanel1.SuspendLayout();
            this.bosLine6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAdditionalReferenceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAdditionalReferenceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtOriginalInvoiceId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAdditionalReferenceDesc.Properties)).BeginInit();
            this.bosLine5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbTaxOfficeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDiscountAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSumOfTotalLineAmountWithoutVAT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtTotalVATAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtTotalAmountWithVAT.Properties)).BeginInit();
            this.bosLine3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBuyerDisplayName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbBuyerType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBuyerEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbACEInvoiceGeneralReceiveType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBuyerCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBuyerLegalName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBuyerAddressLine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBuyerBankNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBuyerPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBuyerBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBuyerTaxCode.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACTaxUnitID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbPaymentStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPublicKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACEInvoiceGeneralStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACEInvoicePaymentMethodName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARAllocationDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtTemplateCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtInvoiceSeries.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACEInvoiceGeneralNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSubmittedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSubmittedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteInvoiceIssuedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteInvoiceIssuedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtContractNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtInvoiceName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtInvoiceNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEInvoiceDetails)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosLine6);
            this.bosPanel1.Controls.Add(this.bosLine5);
            this.bosPanel1.Controls.Add(this.bosLine3);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.xtraTabControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1043, 803);
            this.bosPanel1.TabIndex = 6;
            // 
            // bosLine6
            // 
            this.bosLine6.BackColor = System.Drawing.Color.Transparent;
            this.bosLine6.BOSComment = "";
            this.bosLine6.BOSDataMember = "";
            this.bosLine6.BOSDataSource = "";
            this.bosLine6.BOSDescription = null;
            this.bosLine6.BOSError = null;
            this.bosLine6.BOSFieldGroup = "";
            this.bosLine6.BOSFieldRelation = "";
            this.bosLine6.BOSPrivilege = "";
            this.bosLine6.BOSPropertyName = null;
            this.bosLine6.Controls.Add(this.fld_dteAdditionalReferenceDate);
            this.bosLine6.Controls.Add(this.fld_txtOriginalInvoiceId);
            this.bosLine6.Controls.Add(this.bosLabel28);
            this.bosLine6.Controls.Add(this.fld_txtAdditionalReferenceDesc);
            this.bosLine6.Controls.Add(this.bosLabel29);
            this.bosLine6.Controls.Add(this.bosLabel30);
            this.bosLine6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine6.Location = new System.Drawing.Point(3, 279);
            this.bosLine6.Name = "bosLine6";
            this.bosLine6.Screen = null;
            this.bosLine6.Size = new System.Drawing.Size(534, 76);
            this.bosLine6.TabIndex = 3;
            this.bosLine6.TabStop = false;
            this.bosLine6.Tag = "";
            this.bosLine6.Text = "Thông tin hóa đơn Xóa bỏ - Điều chỉnh - Thay thế";
            // 
            // fld_dteAdditionalReferenceDate
            // 
            this.fld_dteAdditionalReferenceDate.BOSComment = null;
            this.fld_dteAdditionalReferenceDate.BOSDataMember = "AdditionalReferenceDate";
            this.fld_dteAdditionalReferenceDate.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_dteAdditionalReferenceDate.BOSDescription = null;
            this.fld_dteAdditionalReferenceDate.BOSError = null;
            this.fld_dteAdditionalReferenceDate.BOSFieldGroup = null;
            this.fld_dteAdditionalReferenceDate.BOSFieldRelation = null;
            this.fld_dteAdditionalReferenceDate.BOSPrivilege = null;
            this.fld_dteAdditionalReferenceDate.BOSPropertyName = "EditValue";
            this.fld_dteAdditionalReferenceDate.EditValue = null;
            this.fld_dteAdditionalReferenceDate.Location = new System.Drawing.Point(373, 20);
            this.fld_dteAdditionalReferenceDate.MenuManager = this.screenToolbar;
            this.fld_dteAdditionalReferenceDate.Name = "fld_dteAdditionalReferenceDate";
            this.fld_dteAdditionalReferenceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAdditionalReferenceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAdditionalReferenceDate.Screen = null;
            this.fld_dteAdditionalReferenceDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteAdditionalReferenceDate.TabIndex = 1;
            this.fld_dteAdditionalReferenceDate.Tag = "DC";
            // 
            // fld_txtOriginalInvoiceId
            // 
            this.fld_txtOriginalInvoiceId.BOSComment = null;
            this.fld_txtOriginalInvoiceId.BOSDataMember = "OriginalInvoiceId";
            this.fld_txtOriginalInvoiceId.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtOriginalInvoiceId.BOSDescription = null;
            this.fld_txtOriginalInvoiceId.BOSError = null;
            this.fld_txtOriginalInvoiceId.BOSFieldGroup = null;
            this.fld_txtOriginalInvoiceId.BOSFieldRelation = null;
            this.fld_txtOriginalInvoiceId.BOSPrivilege = null;
            this.fld_txtOriginalInvoiceId.BOSPropertyName = "EditValue";
            this.fld_txtOriginalInvoiceId.Location = new System.Drawing.Point(102, 20);
            this.fld_txtOriginalInvoiceId.Name = "fld_txtOriginalInvoiceId";
            this.fld_txtOriginalInvoiceId.Screen = null;
            this.fld_txtOriginalInvoiceId.Size = new System.Drawing.Size(150, 20);
            this.fld_txtOriginalInvoiceId.TabIndex = 0;
            this.fld_txtOriginalInvoiceId.Tag = "DC";
            // 
            // bosLabel28
            // 
            this.bosLabel28.BOSComment = null;
            this.bosLabel28.BOSDataMember = null;
            this.bosLabel28.BOSDataSource = null;
            this.bosLabel28.BOSDescription = null;
            this.bosLabel28.BOSError = null;
            this.bosLabel28.BOSFieldGroup = null;
            this.bosLabel28.BOSFieldRelation = null;
            this.bosLabel28.BOSPrivilege = null;
            this.bosLabel28.BOSPropertyName = null;
            this.bosLabel28.Location = new System.Drawing.Point(6, 49);
            this.bosLabel28.Name = "bosLabel28";
            this.bosLabel28.Screen = null;
            this.bosLabel28.Size = new System.Drawing.Size(82, 13);
            this.bosLabel28.TabIndex = 845;
            this.bosLabel28.Text = "Số v.bản t.thuận";
            // 
            // fld_txtAdditionalReferenceDesc
            // 
            this.fld_txtAdditionalReferenceDesc.BOSComment = null;
            this.fld_txtAdditionalReferenceDesc.BOSDataMember = "AdditionalReferenceDesc";
            this.fld_txtAdditionalReferenceDesc.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtAdditionalReferenceDesc.BOSDescription = null;
            this.fld_txtAdditionalReferenceDesc.BOSError = null;
            this.fld_txtAdditionalReferenceDesc.BOSFieldGroup = null;
            this.fld_txtAdditionalReferenceDesc.BOSFieldRelation = null;
            this.fld_txtAdditionalReferenceDesc.BOSPrivilege = null;
            this.fld_txtAdditionalReferenceDesc.BOSPropertyName = "EditValue";
            this.fld_txtAdditionalReferenceDesc.Location = new System.Drawing.Point(102, 46);
            this.fld_txtAdditionalReferenceDesc.Name = "fld_txtAdditionalReferenceDesc";
            this.fld_txtAdditionalReferenceDesc.Screen = null;
            this.fld_txtAdditionalReferenceDesc.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAdditionalReferenceDesc.TabIndex = 2;
            this.fld_txtAdditionalReferenceDesc.Tag = "DC";
            // 
            // bosLabel29
            // 
            this.bosLabel29.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel29.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel29.Appearance.Options.UseBackColor = true;
            this.bosLabel29.Appearance.Options.UseForeColor = true;
            this.bosLabel29.BOSComment = null;
            this.bosLabel29.BOSDataMember = null;
            this.bosLabel29.BOSDataSource = null;
            this.bosLabel29.BOSDescription = null;
            this.bosLabel29.BOSError = null;
            this.bosLabel29.BOSFieldGroup = null;
            this.bosLabel29.BOSFieldRelation = null;
            this.bosLabel29.BOSPrivilege = null;
            this.bosLabel29.BOSPropertyName = null;
            this.bosLabel29.Location = new System.Drawing.Point(6, 23);
            this.bosLabel29.Name = "bosLabel29";
            this.bosLabel29.Screen = null;
            this.bosLabel29.Size = new System.Drawing.Size(50, 13);
            this.bosLabel29.TabIndex = 842;
            this.bosLabel29.Text = "Số HĐ gốc";
            // 
            // bosLabel30
            // 
            this.bosLabel30.BOSComment = null;
            this.bosLabel30.BOSDataMember = null;
            this.bosLabel30.BOSDataSource = null;
            this.bosLabel30.BOSDescription = null;
            this.bosLabel30.BOSError = null;
            this.bosLabel30.BOSFieldGroup = null;
            this.bosLabel30.BOSFieldRelation = null;
            this.bosLabel30.BOSPrivilege = null;
            this.bosLabel30.BOSPropertyName = null;
            this.bosLabel30.Location = new System.Drawing.Point(278, 23);
            this.bosLabel30.Name = "bosLabel30";
            this.bosLabel30.Screen = null;
            this.bosLabel30.Size = new System.Drawing.Size(70, 13);
            this.bosLabel30.TabIndex = 843;
            this.bosLabel30.Text = "Ngày ký v.bản";
            // 
            // bosLine5
            // 
            this.bosLine5.BackColor = System.Drawing.Color.Transparent;
            this.bosLine5.BOSComment = "";
            this.bosLine5.BOSDataMember = "";
            this.bosLine5.BOSDataSource = "";
            this.bosLine5.BOSDescription = null;
            this.bosLine5.BOSError = null;
            this.bosLine5.BOSFieldGroup = "";
            this.bosLine5.BOSFieldRelation = "";
            this.bosLine5.BOSPrivilege = "";
            this.bosLine5.BOSPropertyName = null;
            this.bosLine5.Controls.Add(this.fld_cmbTaxOfficeCode);
            this.bosLine5.Controls.Add(this.fld_txtDiscountAmount);
            this.bosLine5.Controls.Add(this.bosMemoEdit1);
            this.bosLine5.Controls.Add(this.fld_lblLabel46);
            this.bosLine5.Controls.Add(this.bosLabel26);
            this.bosLine5.Controls.Add(this.fld_txtSumOfTotalLineAmountWithoutVAT);
            this.bosLine5.Controls.Add(this.bosLabel12);
            this.bosLine5.Controls.Add(this.bosLabel23);
            this.bosLine5.Controls.Add(this.fld_txtTotalVATAmount);
            this.bosLine5.Controls.Add(this.bosLabel24);
            this.bosLine5.Controls.Add(this.bosLabel25);
            this.bosLine5.Controls.Add(this.fld_txtTotalAmountWithVAT);
            this.bosLine5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine5.Location = new System.Drawing.Point(543, 266);
            this.bosLine5.Name = "bosLine5";
            this.bosLine5.Screen = null;
            this.bosLine5.Size = new System.Drawing.Size(453, 137);
            this.bosLine5.TabIndex = 2;
            this.bosLine5.TabStop = false;
            this.bosLine5.Tag = "";
            this.bosLine5.Text = "Tổng tiền";
            // 
            // fld_cmbTaxOfficeCode
            // 
            this.fld_cmbTaxOfficeCode.BOSComment = null;
            this.fld_cmbTaxOfficeCode.BOSDataMember = "TaxOfficeCode";
            this.fld_cmbTaxOfficeCode.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_cmbTaxOfficeCode.BOSDescription = null;
            this.fld_cmbTaxOfficeCode.BOSError = null;
            this.fld_cmbTaxOfficeCode.BOSFieldGroup = null;
            this.fld_cmbTaxOfficeCode.BOSFieldRelation = null;
            this.fld_cmbTaxOfficeCode.BOSPrivilege = null;
            this.fld_cmbTaxOfficeCode.BOSPropertyName = "EditValue";
            this.fld_cmbTaxOfficeCode.Location = new System.Drawing.Point(95, 45);
            this.fld_cmbTaxOfficeCode.MenuManager = this.screenToolbar;
            this.fld_cmbTaxOfficeCode.Name = "fld_cmbTaxOfficeCode";
            this.fld_cmbTaxOfficeCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cmbTaxOfficeCode.Properties.Items.AddRange(new object[] {
            "0%",
            "5%",
            "10%",
            "Không thuế GTGT"});
            this.fld_cmbTaxOfficeCode.Screen = null;
            this.fld_cmbTaxOfficeCode.Size = new System.Drawing.Size(125, 20);
            this.fld_cmbTaxOfficeCode.TabIndex = 2;
            this.fld_cmbTaxOfficeCode.Tag = "DC";
            this.fld_cmbTaxOfficeCode.Validated += new System.EventHandler(this.fld_cmbTaxOfficeCode_Validated);
            // 
            // fld_txtDiscountAmount
            // 
            this.fld_txtDiscountAmount.BOSComment = "";
            this.fld_txtDiscountAmount.BOSDataMember = "DiscountAmount";
            this.fld_txtDiscountAmount.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtDiscountAmount.BOSDescription = null;
            this.fld_txtDiscountAmount.BOSError = null;
            this.fld_txtDiscountAmount.BOSFieldGroup = "";
            this.fld_txtDiscountAmount.BOSFieldRelation = "";
            this.fld_txtDiscountAmount.BOSPrivilege = "";
            this.fld_txtDiscountAmount.BOSPropertyName = "EditValue";
            this.fld_txtDiscountAmount.EditValue = "0";
            this.fld_txtDiscountAmount.Location = new System.Drawing.Point(317, 20);
            this.fld_txtDiscountAmount.Name = "fld_txtDiscountAmount";
            this.fld_txtDiscountAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtDiscountAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtDiscountAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtDiscountAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtDiscountAmount.Properties.Mask.EditMask = "n0";
            this.fld_txtDiscountAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtDiscountAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtDiscountAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtDiscountAmount.Screen = null;
            this.fld_txtDiscountAmount.Size = new System.Drawing.Size(125, 20);
            this.fld_txtDiscountAmount.TabIndex = 1;
            this.fld_txtDiscountAmount.Tag = "DC";
            this.fld_txtDiscountAmount.Validated += new System.EventHandler(this.fld_txtDiscountAmount_Validated);
            // 
            // bosMemoEdit1
            // 
            this.bosMemoEdit1.BOSComment = null;
            this.bosMemoEdit1.BOSDataMember = "TotalAmountWithVATInWords";
            this.bosMemoEdit1.BOSDataSource = "ACEInvoiceGenerals";
            this.bosMemoEdit1.BOSDescription = null;
            this.bosMemoEdit1.BOSError = null;
            this.bosMemoEdit1.BOSFieldGroup = null;
            this.bosMemoEdit1.BOSFieldRelation = null;
            this.bosMemoEdit1.BOSPrivilege = null;
            this.bosMemoEdit1.BOSPropertyName = "EditValue";
            this.bosMemoEdit1.Location = new System.Drawing.Point(95, 97);
            this.bosMemoEdit1.MenuManager = this.screenToolbar;
            this.bosMemoEdit1.Name = "bosMemoEdit1";
            this.bosMemoEdit1.Screen = null;
            this.bosMemoEdit1.Size = new System.Drawing.Size(347, 34);
            this.bosMemoEdit1.TabIndex = 5;
            this.bosMemoEdit1.Tag = "DC";
            // 
            // fld_lblLabel46
            // 
            this.fld_lblLabel46.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel46.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel46.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel46.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel46.BOSComment = "";
            this.fld_lblLabel46.BOSDataMember = "";
            this.fld_lblLabel46.BOSDataSource = "";
            this.fld_lblLabel46.BOSDescription = null;
            this.fld_lblLabel46.BOSError = null;
            this.fld_lblLabel46.BOSFieldGroup = "";
            this.fld_lblLabel46.BOSFieldRelation = "";
            this.fld_lblLabel46.BOSPrivilege = "";
            this.fld_lblLabel46.BOSPropertyName = null;
            this.fld_lblLabel46.Location = new System.Drawing.Point(249, 25);
            this.fld_lblLabel46.Name = "fld_lblLabel46";
            this.fld_lblLabel46.Screen = null;
            this.fld_lblLabel46.Size = new System.Drawing.Size(51, 13);
            this.fld_lblLabel46.TabIndex = 847;
            this.fld_lblLabel46.Tag = "";
            this.fld_lblLabel46.Text = "Chiết khấu";
            // 
            // bosLabel26
            // 
            this.bosLabel26.BOSComment = null;
            this.bosLabel26.BOSDataMember = null;
            this.bosLabel26.BOSDataSource = null;
            this.bosLabel26.BOSDescription = null;
            this.bosLabel26.BOSError = null;
            this.bosLabel26.BOSFieldGroup = null;
            this.bosLabel26.BOSFieldRelation = null;
            this.bosLabel26.BOSPrivilege = null;
            this.bosLabel26.BOSPropertyName = null;
            this.bosLabel26.Location = new System.Drawing.Point(13, 95);
            this.bosLabel26.Name = "bosLabel26";
            this.bosLabel26.Screen = null;
            this.bosLabel26.Size = new System.Drawing.Size(68, 13);
            this.bosLabel26.TabIndex = 848;
            this.bosLabel26.Text = "Tiền bằng chữ";
            // 
            // fld_txtSumOfTotalLineAmountWithoutVAT
            // 
            this.fld_txtSumOfTotalLineAmountWithoutVAT.BOSComment = null;
            this.fld_txtSumOfTotalLineAmountWithoutVAT.BOSDataMember = "SumOfTotalLineAmountWithoutVAT";
            this.fld_txtSumOfTotalLineAmountWithoutVAT.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtSumOfTotalLineAmountWithoutVAT.BOSDescription = null;
            this.fld_txtSumOfTotalLineAmountWithoutVAT.BOSError = null;
            this.fld_txtSumOfTotalLineAmountWithoutVAT.BOSFieldGroup = null;
            this.fld_txtSumOfTotalLineAmountWithoutVAT.BOSFieldRelation = null;
            this.fld_txtSumOfTotalLineAmountWithoutVAT.BOSPrivilege = null;
            this.fld_txtSumOfTotalLineAmountWithoutVAT.BOSPropertyName = "EditValue";
            this.fld_txtSumOfTotalLineAmountWithoutVAT.Location = new System.Drawing.Point(95, 20);
            this.fld_txtSumOfTotalLineAmountWithoutVAT.Name = "fld_txtSumOfTotalLineAmountWithoutVAT";
            this.fld_txtSumOfTotalLineAmountWithoutVAT.Properties.Mask.EditMask = "n0";
            this.fld_txtSumOfTotalLineAmountWithoutVAT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtSumOfTotalLineAmountWithoutVAT.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtSumOfTotalLineAmountWithoutVAT.Screen = null;
            this.fld_txtSumOfTotalLineAmountWithoutVAT.Size = new System.Drawing.Size(125, 20);
            this.fld_txtSumOfTotalLineAmountWithoutVAT.TabIndex = 0;
            this.fld_txtSumOfTotalLineAmountWithoutVAT.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(249, 48);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(53, 13);
            this.bosLabel12.TabIndex = 845;
            this.bosLabel12.Text = "Thuế GTGT";
            // 
            // bosLabel23
            // 
            this.bosLabel23.BOSComment = null;
            this.bosLabel23.BOSDataMember = null;
            this.bosLabel23.BOSDataSource = null;
            this.bosLabel23.BOSDescription = null;
            this.bosLabel23.BOSError = null;
            this.bosLabel23.BOSFieldGroup = null;
            this.bosLabel23.BOSFieldRelation = null;
            this.bosLabel23.BOSPrivilege = null;
            this.bosLabel23.BOSPropertyName = null;
            this.bosLabel23.Location = new System.Drawing.Point(13, 47);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(40, 13);
            this.bosLabel23.TabIndex = 845;
            this.bosLabel23.Text = "% GTGT";
            // 
            // fld_txtTotalVATAmount
            // 
            this.fld_txtTotalVATAmount.BOSComment = null;
            this.fld_txtTotalVATAmount.BOSDataMember = "TotalVATAmount";
            this.fld_txtTotalVATAmount.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtTotalVATAmount.BOSDescription = null;
            this.fld_txtTotalVATAmount.BOSError = null;
            this.fld_txtTotalVATAmount.BOSFieldGroup = null;
            this.fld_txtTotalVATAmount.BOSFieldRelation = null;
            this.fld_txtTotalVATAmount.BOSPrivilege = null;
            this.fld_txtTotalVATAmount.BOSPropertyName = "EditValue";
            this.fld_txtTotalVATAmount.Location = new System.Drawing.Point(317, 45);
            this.fld_txtTotalVATAmount.Name = "fld_txtTotalVATAmount";
            this.fld_txtTotalVATAmount.Properties.Mask.EditMask = "n0";
            this.fld_txtTotalVATAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtTotalVATAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtTotalVATAmount.Screen = null;
            this.fld_txtTotalVATAmount.Size = new System.Drawing.Size(125, 20);
            this.fld_txtTotalVATAmount.TabIndex = 3;
            this.fld_txtTotalVATAmount.Tag = "DC";
            // 
            // bosLabel24
            // 
            this.bosLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.Options.UseBackColor = true;
            this.bosLabel24.Appearance.Options.UseForeColor = true;
            this.bosLabel24.BOSComment = null;
            this.bosLabel24.BOSDataMember = null;
            this.bosLabel24.BOSDataSource = null;
            this.bosLabel24.BOSDescription = null;
            this.bosLabel24.BOSError = null;
            this.bosLabel24.BOSFieldGroup = null;
            this.bosLabel24.BOSFieldRelation = null;
            this.bosLabel24.BOSPrivilege = null;
            this.bosLabel24.BOSPropertyName = null;
            this.bosLabel24.Location = new System.Drawing.Point(13, 23);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(57, 13);
            this.bosLabel24.TabIndex = 842;
            this.bosLabel24.Text = "Tiền dịch vụ";
            // 
            // bosLabel25
            // 
            this.bosLabel25.BOSComment = null;
            this.bosLabel25.BOSDataMember = null;
            this.bosLabel25.BOSDataSource = null;
            this.bosLabel25.BOSDescription = null;
            this.bosLabel25.BOSError = null;
            this.bosLabel25.BOSFieldGroup = null;
            this.bosLabel25.BOSFieldRelation = null;
            this.bosLabel25.BOSPrivilege = null;
            this.bosLabel25.BOSPropertyName = null;
            this.bosLabel25.Location = new System.Drawing.Point(13, 71);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(45, 13);
            this.bosLabel25.TabIndex = 843;
            this.bosLabel25.Text = "Tổng tiền";
            // 
            // fld_txtTotalAmountWithVAT
            // 
            this.fld_txtTotalAmountWithVAT.BOSComment = null;
            this.fld_txtTotalAmountWithVAT.BOSDataMember = "TotalAmountWithVAT";
            this.fld_txtTotalAmountWithVAT.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtTotalAmountWithVAT.BOSDescription = null;
            this.fld_txtTotalAmountWithVAT.BOSError = null;
            this.fld_txtTotalAmountWithVAT.BOSFieldGroup = null;
            this.fld_txtTotalAmountWithVAT.BOSFieldRelation = null;
            this.fld_txtTotalAmountWithVAT.BOSPrivilege = null;
            this.fld_txtTotalAmountWithVAT.BOSPropertyName = "EditValue";
            this.fld_txtTotalAmountWithVAT.Location = new System.Drawing.Point(95, 71);
            this.fld_txtTotalAmountWithVAT.Name = "fld_txtTotalAmountWithVAT";
            this.fld_txtTotalAmountWithVAT.Properties.Mask.EditMask = "n0";
            this.fld_txtTotalAmountWithVAT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtTotalAmountWithVAT.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtTotalAmountWithVAT.Screen = null;
            this.fld_txtTotalAmountWithVAT.Size = new System.Drawing.Size(125, 20);
            this.fld_txtTotalAmountWithVAT.TabIndex = 4;
            this.fld_txtTotalAmountWithVAT.Tag = "DC";
            // 
            // bosLine3
            // 
            this.bosLine3.BackColor = System.Drawing.Color.Transparent;
            this.bosLine3.BOSComment = "";
            this.bosLine3.BOSDataMember = "";
            this.bosLine3.BOSDataSource = "";
            this.bosLine3.BOSDescription = null;
            this.bosLine3.BOSError = null;
            this.bosLine3.BOSFieldGroup = "";
            this.bosLine3.BOSFieldRelation = "";
            this.bosLine3.BOSPrivilege = "";
            this.bosLine3.BOSPropertyName = null;
            this.bosLine3.Controls.Add(this.fld_txtBuyerDisplayName);
            this.bosLine3.Controls.Add(this.bosLabel37);
            this.bosLine3.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosLine3.Controls.Add(this.bosLabel8);
            this.bosLine3.Controls.Add(this.fld_cmbBuyerType);
            this.bosLine3.Controls.Add(this.fld_txtBuyerEmail);
            this.bosLine3.Controls.Add(this.fld_cmbACEInvoiceGeneralReceiveType);
            this.bosLine3.Controls.Add(this.bosLabel18);
            this.bosLine3.Controls.Add(this.fld_txtBuyerCode);
            this.bosLine3.Controls.Add(this.fld_txtBuyerLegalName);
            this.bosLine3.Controls.Add(this.bosLabel21);
            this.bosLine3.Controls.Add(this.bosLabel35);
            this.bosLine3.Controls.Add(this.fld_txtBuyerAddressLine);
            this.bosLine3.Controls.Add(this.bosLabel34);
            this.bosLine3.Controls.Add(this.bosLabel4);
            this.bosLine3.Controls.Add(this.bosLabel31);
            this.bosLine3.Controls.Add(this.fld_txtBuyerBankNumber);
            this.bosLine3.Controls.Add(this.bosLabel22);
            this.bosLine3.Controls.Add(this.bosLabel16);
            this.bosLine3.Controls.Add(this.fld_txtBuyerPhoneNumber);
            this.bosLine3.Controls.Add(this.fld_txtBuyerBankName);
            this.bosLine3.Controls.Add(this.bosLabel32);
            this.bosLine3.Controls.Add(this.fld_txtBuyerTaxCode);
            this.bosLine3.Controls.Add(this.bosLabel20);
            this.bosLine3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine3.Location = new System.Drawing.Point(543, 3);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(453, 257);
            this.bosLine3.TabIndex = 1;
            this.bosLine3.TabStop = false;
            this.bosLine3.Tag = "";
            this.bosLine3.Text = "Thông tin người mua";
            // 
            // fld_txtBuyerDisplayName
            // 
            this.fld_txtBuyerDisplayName.BOSComment = null;
            this.fld_txtBuyerDisplayName.BOSDataMember = "BuyerDisplayName";
            this.fld_txtBuyerDisplayName.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtBuyerDisplayName.BOSDescription = null;
            this.fld_txtBuyerDisplayName.BOSError = null;
            this.fld_txtBuyerDisplayName.BOSFieldGroup = null;
            this.fld_txtBuyerDisplayName.BOSFieldRelation = null;
            this.fld_txtBuyerDisplayName.BOSPrivilege = null;
            this.fld_txtBuyerDisplayName.BOSPropertyName = "EditValue";
            this.fld_txtBuyerDisplayName.Location = new System.Drawing.Point(108, 71);
            this.fld_txtBuyerDisplayName.Name = "fld_txtBuyerDisplayName";
            this.fld_txtBuyerDisplayName.Screen = null;
            this.fld_txtBuyerDisplayName.Size = new System.Drawing.Size(334, 20);
            this.fld_txtBuyerDisplayName.TabIndex = 862;
            this.fld_txtBuyerDisplayName.Tag = "DC";
            // 
            // bosLabel37
            // 
            this.bosLabel37.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel37.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel37.Appearance.Options.UseBackColor = true;
            this.bosLabel37.Appearance.Options.UseForeColor = true;
            this.bosLabel37.BOSComment = null;
            this.bosLabel37.BOSDataMember = null;
            this.bosLabel37.BOSDataSource = null;
            this.bosLabel37.BOSDescription = null;
            this.bosLabel37.BOSError = null;
            this.bosLabel37.BOSFieldGroup = null;
            this.bosLabel37.BOSFieldRelation = null;
            this.bosLabel37.BOSPrivilege = null;
            this.bosLabel37.BOSPropertyName = null;
            this.bosLabel37.Location = new System.Drawing.Point(13, 74);
            this.bosLabel37.Name = "bosLabel37";
            this.bosLabel37.Screen = null;
            this.bosLabel37.Size = new System.Drawing.Size(78, 13);
            this.bosLabel37.TabIndex = 863;
            this.bosLabel37.Text = "Người mua hàng";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = "";
            this.fld_lkeFK_ACObjectID.BOSFieldParent = "";
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = "";
            this.fld_lkeFK_ACObjectID.BOSModuleType = null;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = "";
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = "";
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(108, 45);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectNo";
            this.fld_lkeFK_ACObjectID.Properties.NullText = "";
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(334, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 861;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_ACObjectID_CloseUp);
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(13, 230);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(91, 13);
            this.bosLabel8.TabIndex = 860;
            this.bosLabel8.Text = "Hình thức nhận HĐ";
            // 
            // fld_cmbBuyerType
            // 
            this.fld_cmbBuyerType.BOSComment = null;
            this.fld_cmbBuyerType.BOSDataMember = "BuyerType";
            this.fld_cmbBuyerType.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_cmbBuyerType.BOSDescription = null;
            this.fld_cmbBuyerType.BOSError = null;
            this.fld_cmbBuyerType.BOSFieldGroup = null;
            this.fld_cmbBuyerType.BOSFieldRelation = null;
            this.fld_cmbBuyerType.BOSPrivilege = null;
            this.fld_cmbBuyerType.BOSPropertyName = "EditValue";
            this.fld_cmbBuyerType.Location = new System.Drawing.Point(317, 20);
            this.fld_cmbBuyerType.MenuManager = this.screenToolbar;
            this.fld_cmbBuyerType.Name = "fld_cmbBuyerType";
            this.fld_cmbBuyerType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cmbBuyerType.Properties.Items.AddRange(new object[] {
            "",
            "Doanh nghiệp",
            "Cá nhân"});
            this.fld_cmbBuyerType.Screen = null;
            this.fld_cmbBuyerType.Size = new System.Drawing.Size(125, 20);
            this.fld_cmbBuyerType.TabIndex = 1;
            this.fld_cmbBuyerType.Tag = "DC";
            // 
            // fld_txtBuyerEmail
            // 
            this.fld_txtBuyerEmail.BOSComment = null;
            this.fld_txtBuyerEmail.BOSDataMember = "BuyerEmail";
            this.fld_txtBuyerEmail.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtBuyerEmail.BOSDescription = null;
            this.fld_txtBuyerEmail.BOSError = null;
            this.fld_txtBuyerEmail.BOSFieldGroup = null;
            this.fld_txtBuyerEmail.BOSFieldRelation = null;
            this.fld_txtBuyerEmail.BOSPrivilege = null;
            this.fld_txtBuyerEmail.BOSPropertyName = "EditValue";
            this.fld_txtBuyerEmail.Location = new System.Drawing.Point(108, 149);
            this.fld_txtBuyerEmail.Name = "fld_txtBuyerEmail";
            this.fld_txtBuyerEmail.Screen = null;
            this.fld_txtBuyerEmail.Size = new System.Drawing.Size(334, 20);
            this.fld_txtBuyerEmail.TabIndex = 10;
            this.fld_txtBuyerEmail.Tag = "DC";
            // 
            // fld_cmbACEInvoiceGeneralReceiveType
            // 
            this.fld_cmbACEInvoiceGeneralReceiveType.BOSComment = null;
            this.fld_cmbACEInvoiceGeneralReceiveType.BOSDataMember = "ACEInvoiceGeneralReceiveType";
            this.fld_cmbACEInvoiceGeneralReceiveType.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_cmbACEInvoiceGeneralReceiveType.BOSDescription = null;
            this.fld_cmbACEInvoiceGeneralReceiveType.BOSError = null;
            this.fld_cmbACEInvoiceGeneralReceiveType.BOSFieldGroup = null;
            this.fld_cmbACEInvoiceGeneralReceiveType.BOSFieldRelation = null;
            this.fld_cmbACEInvoiceGeneralReceiveType.BOSPrivilege = null;
            this.fld_cmbACEInvoiceGeneralReceiveType.BOSPropertyName = "EditValue";
            this.fld_cmbACEInvoiceGeneralReceiveType.Location = new System.Drawing.Point(110, 227);
            this.fld_cmbACEInvoiceGeneralReceiveType.MenuManager = this.screenToolbar;
            this.fld_cmbACEInvoiceGeneralReceiveType.Name = "fld_cmbACEInvoiceGeneralReceiveType";
            this.fld_cmbACEInvoiceGeneralReceiveType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cmbACEInvoiceGeneralReceiveType.Properties.Items.AddRange(new object[] {
            "",
            "Email",
            "Tin nhắn",
            "Email và tin nhắn",
            "Chuyển phát nhanh"});
            this.fld_cmbACEInvoiceGeneralReceiveType.Screen = null;
            this.fld_cmbACEInvoiceGeneralReceiveType.Size = new System.Drawing.Size(125, 20);
            this.fld_cmbACEInvoiceGeneralReceiveType.TabIndex = 9;
            this.fld_cmbACEInvoiceGeneralReceiveType.Tag = "DC";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = null;
            this.bosLabel18.BOSDataMember = null;
            this.bosLabel18.BOSDataSource = null;
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = null;
            this.bosLabel18.BOSFieldRelation = null;
            this.bosLabel18.BOSPrivilege = null;
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(13, 152);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(24, 13);
            this.bosLabel18.TabIndex = 854;
            this.bosLabel18.Text = "Email";
            // 
            // fld_txtBuyerCode
            // 
            this.fld_txtBuyerCode.BOSComment = null;
            this.fld_txtBuyerCode.BOSDataMember = "BuyerCode";
            this.fld_txtBuyerCode.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtBuyerCode.BOSDescription = null;
            this.fld_txtBuyerCode.BOSError = null;
            this.fld_txtBuyerCode.BOSFieldGroup = null;
            this.fld_txtBuyerCode.BOSFieldRelation = null;
            this.fld_txtBuyerCode.BOSPrivilege = null;
            this.fld_txtBuyerCode.BOSPropertyName = "EditValue";
            this.fld_txtBuyerCode.Location = new System.Drawing.Point(108, 20);
            this.fld_txtBuyerCode.Name = "fld_txtBuyerCode";
            this.fld_txtBuyerCode.Screen = null;
            this.fld_txtBuyerCode.Size = new System.Drawing.Size(125, 20);
            this.fld_txtBuyerCode.TabIndex = 0;
            this.fld_txtBuyerCode.Tag = "DC";
            // 
            // fld_txtBuyerLegalName
            // 
            this.fld_txtBuyerLegalName.BOSComment = null;
            this.fld_txtBuyerLegalName.BOSDataMember = "BuyerLegalName";
            this.fld_txtBuyerLegalName.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtBuyerLegalName.BOSDescription = null;
            this.fld_txtBuyerLegalName.BOSError = null;
            this.fld_txtBuyerLegalName.BOSFieldGroup = null;
            this.fld_txtBuyerLegalName.BOSFieldRelation = null;
            this.fld_txtBuyerLegalName.BOSPrivilege = null;
            this.fld_txtBuyerLegalName.BOSPropertyName = "EditValue";
            this.fld_txtBuyerLegalName.Location = new System.Drawing.Point(108, 97);
            this.fld_txtBuyerLegalName.Name = "fld_txtBuyerLegalName";
            this.fld_txtBuyerLegalName.Screen = null;
            this.fld_txtBuyerLegalName.Size = new System.Drawing.Size(334, 20);
            this.fld_txtBuyerLegalName.TabIndex = 3;
            this.fld_txtBuyerLegalName.Tag = "DC";
            // 
            // bosLabel21
            // 
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.Options.UseBackColor = true;
            this.bosLabel21.Appearance.Options.UseForeColor = true;
            this.bosLabel21.BOSComment = null;
            this.bosLabel21.BOSDataMember = null;
            this.bosLabel21.BOSDataSource = null;
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = null;
            this.bosLabel21.BOSFieldRelation = null;
            this.bosLabel21.BOSPrivilege = null;
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(13, 100);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(81, 13);
            this.bosLabel21.TabIndex = 850;
            this.bosLabel21.Text = "Đơn vị mua hàng";
            // 
            // bosLabel35
            // 
            this.bosLabel35.BOSComment = null;
            this.bosLabel35.BOSDataMember = null;
            this.bosLabel35.BOSDataSource = null;
            this.bosLabel35.BOSDescription = null;
            this.bosLabel35.BOSError = null;
            this.bosLabel35.BOSFieldGroup = null;
            this.bosLabel35.BOSFieldRelation = null;
            this.bosLabel35.BOSPrivilege = null;
            this.bosLabel35.BOSPropertyName = null;
            this.bosLabel35.Location = new System.Drawing.Point(252, 230);
            this.bosLabel35.Name = "bosLabel35";
            this.bosLabel35.Screen = null;
            this.bosLabel35.Size = new System.Drawing.Size(59, 13);
            this.bosLabel35.TabIndex = 848;
            this.bosLabel35.Text = "Số tài khoản";
            // 
            // fld_txtBuyerAddressLine
            // 
            this.fld_txtBuyerAddressLine.BOSComment = null;
            this.fld_txtBuyerAddressLine.BOSDataMember = "BuyerAddressLine";
            this.fld_txtBuyerAddressLine.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtBuyerAddressLine.BOSDescription = null;
            this.fld_txtBuyerAddressLine.BOSError = null;
            this.fld_txtBuyerAddressLine.BOSFieldGroup = null;
            this.fld_txtBuyerAddressLine.BOSFieldRelation = null;
            this.fld_txtBuyerAddressLine.BOSPrivilege = null;
            this.fld_txtBuyerAddressLine.BOSPropertyName = "EditValue";
            this.fld_txtBuyerAddressLine.Location = new System.Drawing.Point(108, 123);
            this.fld_txtBuyerAddressLine.Name = "fld_txtBuyerAddressLine";
            this.fld_txtBuyerAddressLine.Screen = null;
            this.fld_txtBuyerAddressLine.Size = new System.Drawing.Size(334, 20);
            this.fld_txtBuyerAddressLine.TabIndex = 4;
            this.fld_txtBuyerAddressLine.Tag = "DC";
            // 
            // bosLabel34
            // 
            this.bosLabel34.BOSComment = null;
            this.bosLabel34.BOSDataMember = null;
            this.bosLabel34.BOSDataSource = null;
            this.bosLabel34.BOSDescription = null;
            this.bosLabel34.BOSError = null;
            this.bosLabel34.BOSFieldGroup = null;
            this.bosLabel34.BOSFieldRelation = null;
            this.bosLabel34.BOSPrivilege = null;
            this.bosLabel34.BOSPropertyName = null;
            this.bosLabel34.Location = new System.Drawing.Point(13, 204);
            this.bosLabel34.Name = "bosLabel34";
            this.bosLabel34.Screen = null;
            this.bosLabel34.Size = new System.Drawing.Size(72, 13);
            this.bosLabel34.TabIndex = 848;
            this.bosLabel34.Text = "Tên ngân hàng";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(252, 23);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(35, 13);
            this.bosLabel4.TabIndex = 858;
            this.bosLabel4.Text = "Loại KH";
            // 
            // bosLabel31
            // 
            this.bosLabel31.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel31.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel31.Appearance.Options.UseBackColor = true;
            this.bosLabel31.Appearance.Options.UseForeColor = true;
            this.bosLabel31.BOSComment = null;
            this.bosLabel31.BOSDataMember = null;
            this.bosLabel31.BOSDataSource = null;
            this.bosLabel31.BOSDescription = null;
            this.bosLabel31.BOSError = null;
            this.bosLabel31.BOSFieldGroup = null;
            this.bosLabel31.BOSFieldRelation = null;
            this.bosLabel31.BOSPrivilege = null;
            this.bosLabel31.BOSPropertyName = null;
            this.bosLabel31.Location = new System.Drawing.Point(13, 23);
            this.bosLabel31.Name = "bosLabel31";
            this.bosLabel31.Screen = null;
            this.bosLabel31.Size = new System.Drawing.Size(72, 13);
            this.bosLabel31.TabIndex = 858;
            this.bosLabel31.Text = "Mã khách hàng";
            // 
            // fld_txtBuyerBankNumber
            // 
            this.fld_txtBuyerBankNumber.BOSComment = null;
            this.fld_txtBuyerBankNumber.BOSDataMember = "BuyerBankNumber";
            this.fld_txtBuyerBankNumber.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtBuyerBankNumber.BOSDescription = null;
            this.fld_txtBuyerBankNumber.BOSError = null;
            this.fld_txtBuyerBankNumber.BOSFieldGroup = null;
            this.fld_txtBuyerBankNumber.BOSFieldRelation = null;
            this.fld_txtBuyerBankNumber.BOSPrivilege = null;
            this.fld_txtBuyerBankNumber.BOSPropertyName = "EditValue";
            this.fld_txtBuyerBankNumber.Location = new System.Drawing.Point(317, 227);
            this.fld_txtBuyerBankNumber.Name = "fld_txtBuyerBankNumber";
            this.fld_txtBuyerBankNumber.Screen = null;
            this.fld_txtBuyerBankNumber.Size = new System.Drawing.Size(125, 20);
            this.fld_txtBuyerBankNumber.TabIndex = 8;
            this.fld_txtBuyerBankNumber.Tag = "DC";
            // 
            // bosLabel22
            // 
            this.bosLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.Options.UseBackColor = true;
            this.bosLabel22.Appearance.Options.UseForeColor = true;
            this.bosLabel22.BOSComment = null;
            this.bosLabel22.BOSDataMember = null;
            this.bosLabel22.BOSDataSource = null;
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = null;
            this.bosLabel22.BOSFieldRelation = null;
            this.bosLabel22.BOSPrivilege = null;
            this.bosLabel22.BOSPropertyName = null;
            this.bosLabel22.Location = new System.Drawing.Point(13, 48);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(48, 13);
            this.bosLabel22.TabIndex = 858;
            this.bosLabel22.Text = "Đối tượng";
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = null;
            this.bosLabel16.BOSDataMember = null;
            this.bosLabel16.BOSDataSource = null;
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = null;
            this.bosLabel16.BOSFieldRelation = null;
            this.bosLabel16.BOSPrivilege = null;
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(13, 126);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(32, 13);
            this.bosLabel16.TabIndex = 856;
            this.bosLabel16.Text = "Địa chỉ";
            // 
            // fld_txtBuyerPhoneNumber
            // 
            this.fld_txtBuyerPhoneNumber.BOSComment = null;
            this.fld_txtBuyerPhoneNumber.BOSDataMember = "BuyerPhoneNumber";
            this.fld_txtBuyerPhoneNumber.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtBuyerPhoneNumber.BOSDescription = null;
            this.fld_txtBuyerPhoneNumber.BOSError = null;
            this.fld_txtBuyerPhoneNumber.BOSFieldGroup = null;
            this.fld_txtBuyerPhoneNumber.BOSFieldRelation = null;
            this.fld_txtBuyerPhoneNumber.BOSPrivilege = null;
            this.fld_txtBuyerPhoneNumber.BOSPropertyName = "EditValue";
            this.fld_txtBuyerPhoneNumber.Location = new System.Drawing.Point(108, 175);
            this.fld_txtBuyerPhoneNumber.Name = "fld_txtBuyerPhoneNumber";
            this.fld_txtBuyerPhoneNumber.Screen = null;
            this.fld_txtBuyerPhoneNumber.Size = new System.Drawing.Size(125, 20);
            this.fld_txtBuyerPhoneNumber.TabIndex = 5;
            this.fld_txtBuyerPhoneNumber.Tag = "DC";
            // 
            // fld_txtBuyerBankName
            // 
            this.fld_txtBuyerBankName.BOSComment = null;
            this.fld_txtBuyerBankName.BOSDataMember = "BuyerBankName";
            this.fld_txtBuyerBankName.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtBuyerBankName.BOSDescription = null;
            this.fld_txtBuyerBankName.BOSError = null;
            this.fld_txtBuyerBankName.BOSFieldGroup = null;
            this.fld_txtBuyerBankName.BOSFieldRelation = null;
            this.fld_txtBuyerBankName.BOSPrivilege = null;
            this.fld_txtBuyerBankName.BOSPropertyName = "EditValue";
            this.fld_txtBuyerBankName.Location = new System.Drawing.Point(108, 201);
            this.fld_txtBuyerBankName.Name = "fld_txtBuyerBankName";
            this.fld_txtBuyerBankName.Screen = null;
            this.fld_txtBuyerBankName.Size = new System.Drawing.Size(334, 20);
            this.fld_txtBuyerBankName.TabIndex = 7;
            this.fld_txtBuyerBankName.Tag = "DC";
            // 
            // bosLabel32
            // 
            this.bosLabel32.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel32.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel32.Appearance.Options.UseBackColor = true;
            this.bosLabel32.Appearance.Options.UseForeColor = true;
            this.bosLabel32.BOSComment = null;
            this.bosLabel32.BOSDataMember = null;
            this.bosLabel32.BOSDataSource = null;
            this.bosLabel32.BOSDescription = null;
            this.bosLabel32.BOSError = null;
            this.bosLabel32.BOSFieldGroup = null;
            this.bosLabel32.BOSFieldRelation = null;
            this.bosLabel32.BOSPrivilege = null;
            this.bosLabel32.BOSPropertyName = null;
            this.bosLabel32.Location = new System.Drawing.Point(13, 178);
            this.bosLabel32.Name = "bosLabel32";
            this.bosLabel32.Screen = null;
            this.bosLabel32.Size = new System.Drawing.Size(49, 13);
            this.bosLabel32.TabIndex = 852;
            this.bosLabel32.Text = "Điện thoại";
            // 
            // fld_txtBuyerTaxCode
            // 
            this.fld_txtBuyerTaxCode.BOSComment = null;
            this.fld_txtBuyerTaxCode.BOSDataMember = "BuyerTaxCode";
            this.fld_txtBuyerTaxCode.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtBuyerTaxCode.BOSDescription = null;
            this.fld_txtBuyerTaxCode.BOSError = null;
            this.fld_txtBuyerTaxCode.BOSFieldGroup = null;
            this.fld_txtBuyerTaxCode.BOSFieldRelation = null;
            this.fld_txtBuyerTaxCode.BOSPrivilege = null;
            this.fld_txtBuyerTaxCode.BOSPropertyName = "EditValue";
            this.fld_txtBuyerTaxCode.Location = new System.Drawing.Point(317, 175);
            this.fld_txtBuyerTaxCode.Name = "fld_txtBuyerTaxCode";
            this.fld_txtBuyerTaxCode.Screen = null;
            this.fld_txtBuyerTaxCode.Size = new System.Drawing.Size(125, 20);
            this.fld_txtBuyerTaxCode.TabIndex = 6;
            this.fld_txtBuyerTaxCode.Tag = "DC";
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseForeColor = true;
            this.bosLabel20.BOSComment = null;
            this.bosLabel20.BOSDataMember = null;
            this.bosLabel20.BOSDataSource = null;
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = null;
            this.bosLabel20.BOSFieldRelation = null;
            this.bosLabel20.BOSPrivilege = null;
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(252, 178);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(53, 13);
            this.bosLabel20.TabIndex = 852;
            this.bosLabel20.Text = "Mã số thuế";
            // 
            // bosLine1
            // 
            this.bosLine1.BackColor = System.Drawing.Color.Transparent;
            this.bosLine1.BOSComment = "";
            this.bosLine1.BOSDataMember = "";
            this.bosLine1.BOSDataSource = "";
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = "";
            this.bosLine1.BOSFieldRelation = "";
            this.bosLine1.BOSPrivilege = "";
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.bosLabel17);
            this.bosLine1.Controls.Add(this.fld_lkeFK_ACTaxUnitID);
            this.bosLine1.Controls.Add(this.bosLookupEdit1);
            this.bosLine1.Controls.Add(this.bosLabel13);
            this.bosLine1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosLine1.Controls.Add(this.fld_cmbPaymentStatus);
            this.bosLine1.Controls.Add(this.fld_txtPublicKey);
            this.bosLine1.Controls.Add(this.bosLabel11);
            this.bosLine1.Controls.Add(this.bosLabel10);
            this.bosLine1.Controls.Add(this.bosLabel7);
            this.bosLine1.Controls.Add(this.fld_lkeACEInvoiceGeneralStatus);
            this.bosLine1.Controls.Add(this.bosLabel3);
            this.bosLine1.Controls.Add(this.fld_lkeACEInvoicePaymentMethodName);
            this.bosLine1.Controls.Add(this.fld_medARAllocationDesc);
            this.bosLine1.Controls.Add(this.bosLabel27);
            this.bosLine1.Controls.Add(this.fld_txtTemplateCode);
            this.bosLine1.Controls.Add(this.fld_txtInvoiceSeries);
            this.bosLine1.Controls.Add(this.bosLabel9);
            this.bosLine1.Controls.Add(this.bosLabel15);
            this.bosLine1.Controls.Add(this.fld_txtExchangeRate);
            this.bosLine1.Controls.Add(this.bosLabel6);
            this.bosLine1.Controls.Add(this.bosLabel5);
            this.bosLine1.Controls.Add(this.fld_txtACEInvoiceGeneralNo);
            this.bosLine1.Controls.Add(this.bosLabel36);
            this.bosLine1.Controls.Add(this.BOSLabel1);
            this.bosLine1.Controls.Add(this.fld_dteSubmittedDate);
            this.bosLine1.Controls.Add(this.fld_dteInvoiceIssuedDate);
            this.bosLine1.Controls.Add(this.fld_txtContractNumber);
            this.bosLine1.Controls.Add(this.bosLabel2);
            this.bosLine1.Controls.Add(this.fld_txtInvoiceName);
            this.bosLine1.Controls.Add(this.bosLabel33);
            this.bosLine1.Controls.Add(this.bosLabel14);
            this.bosLine1.Controls.Add(this.fld_txtInvoiceNumber);
            this.bosLine1.Controls.Add(this.bosLabel19);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine1.Location = new System.Drawing.Point(3, 3);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(534, 272);
            this.bosLine1.TabIndex = 0;
            this.bosLine1.TabStop = false;
            this.bosLine1.Tag = "";
            this.bosLine1.Text = "Thông tin hóa đơn";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = null;
            this.bosLabel17.BOSDataMember = null;
            this.bosLabel17.BOSDataSource = null;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = null;
            this.bosLabel17.BOSFieldRelation = null;
            this.bosLabel17.BOSPrivilege = null;
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(278, 199);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, true);
            this.bosLabel17.Size = new System.Drawing.Size(56, 13);
            this.bosLabel17.TabIndex = 862;
            this.bosLabel17.Text = "Đơn vị thuế";
            // 
            // fld_lkeFK_ACTaxUnitID
            // 
            this.fld_lkeFK_ACTaxUnitID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACTaxUnitID.BOSAllowDummy = true;
            this.fld_lkeFK_ACTaxUnitID.BOSComment = null;
            this.fld_lkeFK_ACTaxUnitID.BOSDataMember = "FK_ACTaxUnitID";
            this.fld_lkeFK_ACTaxUnitID.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_lkeFK_ACTaxUnitID.BOSDescription = null;
            this.fld_lkeFK_ACTaxUnitID.BOSError = null;
            this.fld_lkeFK_ACTaxUnitID.BOSFieldGroup = null;
            this.fld_lkeFK_ACTaxUnitID.BOSFieldParent = null;
            this.fld_lkeFK_ACTaxUnitID.BOSFieldRelation = null;
            this.fld_lkeFK_ACTaxUnitID.BOSPrivilege = null;
            this.fld_lkeFK_ACTaxUnitID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACTaxUnitID.BOSSelectType = "";
            this.fld_lkeFK_ACTaxUnitID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACTaxUnitID.CurrentDisplayText = null;
            this.fld_lkeFK_ACTaxUnitID.Location = new System.Drawing.Point(373, 196);
            this.fld_lkeFK_ACTaxUnitID.Name = "fld_lkeFK_ACTaxUnitID";
            this.fld_lkeFK_ACTaxUnitID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACTaxUnitID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACTaxUnitID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACTaxUnitID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACTaxUnitID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACTaxUnitID.Properties.ColumnName = null;
            this.fld_lkeFK_ACTaxUnitID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACTaxUnitName", "Tên đơn vị thuế")});
            this.fld_lkeFK_ACTaxUnitID.Properties.DisplayMember = "ACTaxUnitName";
            this.fld_lkeFK_ACTaxUnitID.Properties.NullText = "";
            this.fld_lkeFK_ACTaxUnitID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACTaxUnitID.Properties.ValueMember = "ACTaxUnitID";
            this.fld_lkeFK_ACTaxUnitID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ACTaxUnitID, true);
            this.fld_lkeFK_ACTaxUnitID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACTaxUnitID.TabIndex = 861;
            this.fld_lkeFK_ACTaxUnitID.Tag = "DC";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "ACEInvoiceGeneralHDStatus";
            this.bosLookupEdit1.BOSDataSource = "ACEInvoiceGenerals";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = null;
            this.bosLookupEdit1.BOSFieldParent = null;
            this.bosLookupEdit1.BOSFieldRelation = null;
            this.bosLookupEdit1.BOSPrivilege = null;
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = null;
            this.bosLookupEdit1.BOSSelectTypeValue = null;
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(102, 196);
            this.bosLookupEdit1.MenuManager = this.screenToolbar;
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.ReadOnly = true;
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit1.TabIndex = 859;
            this.bosLookupEdit1.Tag = "DC";
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
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(9, 199);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(67, 13);
            this.bosLabel13.TabIndex = 860;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "Trạng thái HĐ";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = null;
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = null;
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = null;
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(102, 70);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 858;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // fld_cmbPaymentStatus
            // 
            this.fld_cmbPaymentStatus.BOSComment = null;
            this.fld_cmbPaymentStatus.BOSDataMember = "PaymentStatus";
            this.fld_cmbPaymentStatus.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_cmbPaymentStatus.BOSDescription = null;
            this.fld_cmbPaymentStatus.BOSError = null;
            this.fld_cmbPaymentStatus.BOSFieldGroup = null;
            this.fld_cmbPaymentStatus.BOSFieldRelation = null;
            this.fld_cmbPaymentStatus.BOSPrivilege = null;
            this.fld_cmbPaymentStatus.BOSPropertyName = "EditValue";
            this.fld_cmbPaymentStatus.Location = new System.Drawing.Point(373, 70);
            this.fld_cmbPaymentStatus.MenuManager = this.screenToolbar;
            this.fld_cmbPaymentStatus.Name = "fld_cmbPaymentStatus";
            this.fld_cmbPaymentStatus.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.fld_cmbPaymentStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cmbPaymentStatus.Properties.Items.AddRange(new object[] {
            "Hóa đơn chưa thanh toán",
            "Hóa đơn đã thanh toán"});
            this.fld_cmbPaymentStatus.Screen = null;
            this.fld_cmbPaymentStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_cmbPaymentStatus.TabIndex = 5;
            this.fld_cmbPaymentStatus.Tag = "DC";
            // 
            // fld_txtPublicKey
            // 
            this.fld_txtPublicKey.BOSComment = null;
            this.fld_txtPublicKey.BOSDataMember = "PublicKey";
            this.fld_txtPublicKey.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtPublicKey.BOSDescription = null;
            this.fld_txtPublicKey.BOSError = null;
            this.fld_txtPublicKey.BOSFieldGroup = null;
            this.fld_txtPublicKey.BOSFieldRelation = null;
            this.fld_txtPublicKey.BOSPrivilege = null;
            this.fld_txtPublicKey.BOSPropertyName = "EditValue";
            this.fld_txtPublicKey.Location = new System.Drawing.Point(102, 171);
            this.fld_txtPublicKey.Name = "fld_txtPublicKey";
            this.fld_txtPublicKey.Properties.ReadOnly = true;
            this.fld_txtPublicKey.Screen = null;
            this.fld_txtPublicKey.Size = new System.Drawing.Size(150, 20);
            this.fld_txtPublicKey.TabIndex = 12;
            this.fld_txtPublicKey.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(278, 73);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(84, 13);
            this.bosLabel11.TabIndex = 857;
            this.bosLabel11.Text = "T.thái thanh toán";
            // 
            // bosLabel10
            // 
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(9, 174);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(18, 13);
            this.bosLabel10.TabIndex = 857;
            this.bosLabel10.Text = "Key";
            // 
            // bosLabel7
            // 
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(9, 225);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(77, 13);
            this.bosLabel7.TabIndex = 855;
            this.bosLabel7.Text = "Ghi chú hóa đơn";
            // 
            // fld_lkeACEInvoiceGeneralStatus
            // 
            this.fld_lkeACEInvoiceGeneralStatus.BOSAllowAddNew = false;
            this.fld_lkeACEInvoiceGeneralStatus.BOSAllowDummy = false;
            this.fld_lkeACEInvoiceGeneralStatus.BOSComment = null;
            this.fld_lkeACEInvoiceGeneralStatus.BOSDataMember = "ACEInvoiceGeneralStatus";
            this.fld_lkeACEInvoiceGeneralStatus.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_lkeACEInvoiceGeneralStatus.BOSDescription = null;
            this.fld_lkeACEInvoiceGeneralStatus.BOSError = null;
            this.fld_lkeACEInvoiceGeneralStatus.BOSFieldGroup = null;
            this.fld_lkeACEInvoiceGeneralStatus.BOSFieldParent = null;
            this.fld_lkeACEInvoiceGeneralStatus.BOSFieldRelation = null;
            this.fld_lkeACEInvoiceGeneralStatus.BOSPrivilege = null;
            this.fld_lkeACEInvoiceGeneralStatus.BOSPropertyName = "EditValue";
            this.fld_lkeACEInvoiceGeneralStatus.BOSSelectType = null;
            this.fld_lkeACEInvoiceGeneralStatus.BOSSelectTypeValue = null;
            this.fld_lkeACEInvoiceGeneralStatus.CurrentDisplayText = null;
            this.fld_lkeACEInvoiceGeneralStatus.Location = new System.Drawing.Point(373, 171);
            this.fld_lkeACEInvoiceGeneralStatus.MenuManager = this.screenToolbar;
            this.fld_lkeACEInvoiceGeneralStatus.Name = "fld_lkeACEInvoiceGeneralStatus";
            this.fld_lkeACEInvoiceGeneralStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACEInvoiceGeneralStatus.Properties.ColumnName = null;
            this.fld_lkeACEInvoiceGeneralStatus.Properties.ReadOnly = true;
            this.fld_lkeACEInvoiceGeneralStatus.Screen = null;
            this.fld_lkeACEInvoiceGeneralStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACEInvoiceGeneralStatus.TabIndex = 13;
            this.fld_lkeACEInvoiceGeneralStatus.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(278, 174);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 844;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Tình trạng";
            // 
            // fld_lkeACEInvoicePaymentMethodName
            // 
            this.fld_lkeACEInvoicePaymentMethodName.BOSAllowAddNew = false;
            this.fld_lkeACEInvoicePaymentMethodName.BOSAllowDummy = true;
            this.fld_lkeACEInvoicePaymentMethodName.BOSComment = "";
            this.fld_lkeACEInvoicePaymentMethodName.BOSDataMember = "ACEInvoicePaymentMethodName";
            this.fld_lkeACEInvoicePaymentMethodName.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_lkeACEInvoicePaymentMethodName.BOSDescription = null;
            this.fld_lkeACEInvoicePaymentMethodName.BOSError = null;
            this.fld_lkeACEInvoicePaymentMethodName.BOSFieldGroup = "";
            this.fld_lkeACEInvoicePaymentMethodName.BOSFieldParent = "";
            this.fld_lkeACEInvoicePaymentMethodName.BOSFieldRelation = "";
            this.fld_lkeACEInvoicePaymentMethodName.BOSPrivilege = "";
            this.fld_lkeACEInvoicePaymentMethodName.BOSPropertyName = "EditValue";
            this.fld_lkeACEInvoicePaymentMethodName.BOSSelectType = "";
            this.fld_lkeACEInvoicePaymentMethodName.BOSSelectTypeValue = "";
            this.fld_lkeACEInvoicePaymentMethodName.CurrentDisplayText = null;
            this.fld_lkeACEInvoicePaymentMethodName.Location = new System.Drawing.Point(373, 45);
            this.fld_lkeACEInvoicePaymentMethodName.Name = "fld_lkeACEInvoicePaymentMethodName";
            this.fld_lkeACEInvoicePaymentMethodName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACEInvoicePaymentMethodName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACEInvoicePaymentMethodName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACEInvoicePaymentMethodName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACEInvoicePaymentMethodName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACEInvoicePaymentMethodName.Properties.ColumnName = null;
            this.fld_lkeACEInvoicePaymentMethodName.Properties.NullText = "";
            this.fld_lkeACEInvoicePaymentMethodName.Properties.PopupWidth = 40;
            this.fld_lkeACEInvoicePaymentMethodName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACEInvoicePaymentMethodName.Screen = null;
            this.fld_lkeACEInvoicePaymentMethodName.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACEInvoicePaymentMethodName.TabIndex = 3;
            this.fld_lkeACEInvoicePaymentMethodName.Tag = "DC";
            // 
            // fld_medARAllocationDesc
            // 
            this.fld_medARAllocationDesc.BOSComment = null;
            this.fld_medARAllocationDesc.BOSDataMember = "InvoiceNote";
            this.fld_medARAllocationDesc.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_medARAllocationDesc.BOSDescription = null;
            this.fld_medARAllocationDesc.BOSError = null;
            this.fld_medARAllocationDesc.BOSFieldGroup = null;
            this.fld_medARAllocationDesc.BOSFieldRelation = null;
            this.fld_medARAllocationDesc.BOSPrivilege = null;
            this.fld_medARAllocationDesc.BOSPropertyName = "EditValue";
            this.fld_medARAllocationDesc.Location = new System.Drawing.Point(102, 222);
            this.fld_medARAllocationDesc.MenuManager = this.screenToolbar;
            this.fld_medARAllocationDesc.Name = "fld_medARAllocationDesc";
            this.fld_medARAllocationDesc.Screen = null;
            this.fld_medARAllocationDesc.Size = new System.Drawing.Size(421, 43);
            this.fld_medARAllocationDesc.TabIndex = 14;
            this.fld_medARAllocationDesc.Tag = "DC";
            // 
            // bosLabel27
            // 
            this.bosLabel27.BOSComment = null;
            this.bosLabel27.BOSDataMember = null;
            this.bosLabel27.BOSDataSource = null;
            this.bosLabel27.BOSDescription = null;
            this.bosLabel27.BOSError = null;
            this.bosLabel27.BOSFieldGroup = null;
            this.bosLabel27.BOSFieldRelation = null;
            this.bosLabel27.BOSPrivilege = null;
            this.bosLabel27.BOSPropertyName = null;
            this.bosLabel27.Location = new System.Drawing.Point(278, 48);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.bosLabel27.Size = new System.Drawing.Size(70, 13);
            this.bosLabel27.TabIndex = 848;
            this.bosLabel27.Text = "PT Thanh toán";
            // 
            // fld_txtTemplateCode
            // 
            this.fld_txtTemplateCode.BOSComment = null;
            this.fld_txtTemplateCode.BOSDataMember = "TemplateCode";
            this.fld_txtTemplateCode.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtTemplateCode.BOSDescription = null;
            this.fld_txtTemplateCode.BOSError = null;
            this.fld_txtTemplateCode.BOSFieldGroup = null;
            this.fld_txtTemplateCode.BOSFieldRelation = null;
            this.fld_txtTemplateCode.BOSPrivilege = null;
            this.fld_txtTemplateCode.BOSPropertyName = "EditValue";
            this.fld_txtTemplateCode.Location = new System.Drawing.Point(373, 120);
            this.fld_txtTemplateCode.Name = "fld_txtTemplateCode";
            this.fld_txtTemplateCode.Screen = null;
            this.fld_txtTemplateCode.Size = new System.Drawing.Size(150, 20);
            this.fld_txtTemplateCode.TabIndex = 9;
            this.fld_txtTemplateCode.Tag = "DC";
            // 
            // fld_txtInvoiceSeries
            // 
            this.fld_txtInvoiceSeries.BOSComment = null;
            this.fld_txtInvoiceSeries.BOSDataMember = "InvoiceSeries";
            this.fld_txtInvoiceSeries.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtInvoiceSeries.BOSDescription = null;
            this.fld_txtInvoiceSeries.BOSError = null;
            this.fld_txtInvoiceSeries.BOSFieldGroup = null;
            this.fld_txtInvoiceSeries.BOSFieldRelation = null;
            this.fld_txtInvoiceSeries.BOSPrivilege = null;
            this.fld_txtInvoiceSeries.BOSPropertyName = "EditValue";
            this.fld_txtInvoiceSeries.Location = new System.Drawing.Point(373, 145);
            this.fld_txtInvoiceSeries.Name = "fld_txtInvoiceSeries";
            this.fld_txtInvoiceSeries.Screen = null;
            this.fld_txtInvoiceSeries.Size = new System.Drawing.Size(150, 20);
            this.fld_txtInvoiceSeries.TabIndex = 11;
            this.fld_txtInvoiceSeries.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(278, 148);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(35, 13);
            this.bosLabel9.TabIndex = 12;
            this.bosLabel9.Text = "Ký hiệu";
            // 
            // bosLabel15
            // 
            this.bosLabel15.BOSComment = null;
            this.bosLabel15.BOSDataMember = null;
            this.bosLabel15.BOSDataSource = null;
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = null;
            this.bosLabel15.BOSFieldRelation = null;
            this.bosLabel15.BOSPrivilege = null;
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(278, 123);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(34, 13);
            this.bosLabel15.TabIndex = 6;
            this.bosLabel15.Text = "Mẫu số";
            // 
            // fld_txtExchangeRate
            // 
            this.fld_txtExchangeRate.BOSComment = null;
            this.fld_txtExchangeRate.BOSDataMember = "ExchangeRate";
            this.fld_txtExchangeRate.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtExchangeRate.BOSDescription = null;
            this.fld_txtExchangeRate.BOSError = null;
            this.fld_txtExchangeRate.BOSFieldGroup = null;
            this.fld_txtExchangeRate.BOSFieldRelation = null;
            this.fld_txtExchangeRate.BOSPrivilege = null;
            this.fld_txtExchangeRate.BOSPropertyName = "EditValue";
            this.fld_txtExchangeRate.Location = new System.Drawing.Point(102, 95);
            this.fld_txtExchangeRate.Name = "fld_txtExchangeRate";
            this.fld_txtExchangeRate.Properties.Mask.EditMask = "n";
            this.fld_txtExchangeRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtExchangeRate.Screen = null;
            this.fld_txtExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtExchangeRate.TabIndex = 6;
            this.fld_txtExchangeRate.Tag = "DC";
            this.fld_txtExchangeRate.Validated += new System.EventHandler(this.fld_txtExchangeRate_Validated);
            // 
            // bosLabel6
            // 
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(9, 98);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(29, 13);
            this.bosLabel6.TabIndex = 852;
            this.bosLabel6.Text = "Tỷ giá";
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
            this.bosLabel5.Location = new System.Drawing.Point(9, 73);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(48, 13);
            this.bosLabel5.TabIndex = 850;
            this.bosLabel5.Text = "Mã tiền tệ";
            // 
            // fld_txtACEInvoiceGeneralNo
            // 
            this.fld_txtACEInvoiceGeneralNo.BOSComment = null;
            this.fld_txtACEInvoiceGeneralNo.BOSDataMember = "ACEInvoiceGeneralNo";
            this.fld_txtACEInvoiceGeneralNo.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtACEInvoiceGeneralNo.BOSDescription = null;
            this.fld_txtACEInvoiceGeneralNo.BOSError = null;
            this.fld_txtACEInvoiceGeneralNo.BOSFieldGroup = null;
            this.fld_txtACEInvoiceGeneralNo.BOSFieldRelation = null;
            this.fld_txtACEInvoiceGeneralNo.BOSPrivilege = null;
            this.fld_txtACEInvoiceGeneralNo.BOSPropertyName = "EditValue";
            this.fld_txtACEInvoiceGeneralNo.Location = new System.Drawing.Point(102, 20);
            this.fld_txtACEInvoiceGeneralNo.Name = "fld_txtACEInvoiceGeneralNo";
            this.fld_txtACEInvoiceGeneralNo.Properties.ReadOnly = true;
            this.fld_txtACEInvoiceGeneralNo.Screen = null;
            this.fld_txtACEInvoiceGeneralNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACEInvoiceGeneralNo.TabIndex = 0;
            this.fld_txtACEInvoiceGeneralNo.Tag = "DC";
            // 
            // bosLabel36
            // 
            this.bosLabel36.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel36.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel36.Appearance.Options.UseBackColor = true;
            this.bosLabel36.Appearance.Options.UseForeColor = true;
            this.bosLabel36.BOSComment = "";
            this.bosLabel36.BOSDataMember = "";
            this.bosLabel36.BOSDataSource = "";
            this.bosLabel36.BOSDescription = null;
            this.bosLabel36.BOSError = null;
            this.bosLabel36.BOSFieldGroup = "";
            this.bosLabel36.BOSFieldRelation = "";
            this.bosLabel36.BOSPrivilege = "";
            this.bosLabel36.BOSPropertyName = null;
            this.bosLabel36.Location = new System.Drawing.Point(278, 98);
            this.bosLabel36.Name = "bosLabel36";
            this.bosLabel36.Screen = null;
            this.bosLabel36.Size = new System.Drawing.Size(77, 13);
            this.bosLabel36.TabIndex = 847;
            this.bosLabel36.Tag = "";
            this.bosLabel36.Text = "Ngày phát hành";
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
            this.BOSLabel1.Location = new System.Drawing.Point(9, 48);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(67, 13);
            this.BOSLabel1.TabIndex = 847;
            this.BOSLabel1.Tag = "";
            this.BOSLabel1.Text = "Ngày hóa đơn";
            // 
            // fld_dteSubmittedDate
            // 
            this.fld_dteSubmittedDate.BOSComment = null;
            this.fld_dteSubmittedDate.BOSDataMember = "SubmittedDate";
            this.fld_dteSubmittedDate.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_dteSubmittedDate.BOSDescription = null;
            this.fld_dteSubmittedDate.BOSError = null;
            this.fld_dteSubmittedDate.BOSFieldGroup = null;
            this.fld_dteSubmittedDate.BOSFieldRelation = null;
            this.fld_dteSubmittedDate.BOSPrivilege = null;
            this.fld_dteSubmittedDate.BOSPropertyName = "EditValue";
            this.fld_dteSubmittedDate.EditValue = null;
            this.fld_dteSubmittedDate.Location = new System.Drawing.Point(373, 95);
            this.fld_dteSubmittedDate.Name = "fld_dteSubmittedDate";
            this.fld_dteSubmittedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSubmittedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSubmittedDate.Screen = null;
            this.fld_dteSubmittedDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSubmittedDate.TabIndex = 7;
            this.fld_dteSubmittedDate.Tag = "DC";
            // 
            // fld_dteInvoiceIssuedDate
            // 
            this.fld_dteInvoiceIssuedDate.BOSComment = null;
            this.fld_dteInvoiceIssuedDate.BOSDataMember = "ContractDate";
            this.fld_dteInvoiceIssuedDate.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_dteInvoiceIssuedDate.BOSDescription = null;
            this.fld_dteInvoiceIssuedDate.BOSError = null;
            this.fld_dteInvoiceIssuedDate.BOSFieldGroup = null;
            this.fld_dteInvoiceIssuedDate.BOSFieldRelation = null;
            this.fld_dteInvoiceIssuedDate.BOSPrivilege = null;
            this.fld_dteInvoiceIssuedDate.BOSPropertyName = "EditValue";
            this.fld_dteInvoiceIssuedDate.EditValue = null;
            this.fld_dteInvoiceIssuedDate.Location = new System.Drawing.Point(102, 45);
            this.fld_dteInvoiceIssuedDate.MenuManager = this.screenToolbar;
            this.fld_dteInvoiceIssuedDate.Name = "fld_dteInvoiceIssuedDate";
            this.fld_dteInvoiceIssuedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteInvoiceIssuedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteInvoiceIssuedDate.Screen = null;
            this.fld_dteInvoiceIssuedDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteInvoiceIssuedDate.TabIndex = 2;
            this.fld_dteInvoiceIssuedDate.Tag = "DC";
            // 
            // fld_txtContractNumber
            // 
            this.fld_txtContractNumber.BOSComment = null;
            this.fld_txtContractNumber.BOSDataMember = "ContractNumber";
            this.fld_txtContractNumber.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtContractNumber.BOSDescription = null;
            this.fld_txtContractNumber.BOSError = null;
            this.fld_txtContractNumber.BOSFieldGroup = null;
            this.fld_txtContractNumber.BOSFieldRelation = null;
            this.fld_txtContractNumber.BOSPrivilege = null;
            this.fld_txtContractNumber.BOSPropertyName = "EditValue";
            this.fld_txtContractNumber.Location = new System.Drawing.Point(102, 145);
            this.fld_txtContractNumber.Name = "fld_txtContractNumber";
            this.fld_txtContractNumber.Screen = null;
            this.fld_txtContractNumber.Size = new System.Drawing.Size(150, 20);
            this.fld_txtContractNumber.TabIndex = 10;
            this.fld_txtContractNumber.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(9, 148);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(60, 13);
            this.bosLabel2.TabIndex = 848;
            this.bosLabel2.Text = "Số hợp đồng";
            // 
            // fld_txtInvoiceName
            // 
            this.fld_txtInvoiceName.BOSComment = null;
            this.fld_txtInvoiceName.BOSDataMember = "ReferModuleName";
            this.fld_txtInvoiceName.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtInvoiceName.BOSDescription = null;
            this.fld_txtInvoiceName.BOSError = null;
            this.fld_txtInvoiceName.BOSFieldGroup = null;
            this.fld_txtInvoiceName.BOSFieldRelation = null;
            this.fld_txtInvoiceName.BOSPrivilege = null;
            this.fld_txtInvoiceName.BOSPropertyName = "EditValue";
            this.fld_txtInvoiceName.Location = new System.Drawing.Point(373, 20);
            this.fld_txtInvoiceName.Name = "fld_txtInvoiceName";
            this.fld_txtInvoiceName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.fld_txtInvoiceName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtInvoiceName.Properties.ReadOnly = true;
            this.fld_txtInvoiceName.Screen = null;
            this.fld_txtInvoiceName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtInvoiceName.TabIndex = 1;
            this.fld_txtInvoiceName.Tag = "DC";
            // 
            // bosLabel33
            // 
            this.bosLabel33.BOSComment = null;
            this.bosLabel33.BOSDataMember = null;
            this.bosLabel33.BOSDataSource = null;
            this.bosLabel33.BOSDescription = null;
            this.bosLabel33.BOSError = null;
            this.bosLabel33.BOSFieldGroup = null;
            this.bosLabel33.BOSFieldRelation = null;
            this.bosLabel33.BOSPrivilege = null;
            this.bosLabel33.BOSPropertyName = null;
            this.bosLabel33.Location = new System.Drawing.Point(9, 23);
            this.bosLabel33.Name = "bosLabel33";
            this.bosLabel33.Screen = null;
            this.bosLabel33.Size = new System.Drawing.Size(69, 13);
            this.bosLabel33.TabIndex = 16;
            this.bosLabel33.Text = "Mã tham chiếu";
            // 
            // bosLabel14
            // 
            this.bosLabel14.BOSComment = null;
            this.bosLabel14.BOSDataMember = null;
            this.bosLabel14.BOSDataSource = null;
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = null;
            this.bosLabel14.BOSFieldRelation = null;
            this.bosLabel14.BOSPrivilege = null;
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(278, 23);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(89, 13);
            this.bosLabel14.TabIndex = 16;
            this.bosLabel14.Text = "Module tham chiếu";
            // 
            // fld_txtInvoiceNumber
            // 
            this.fld_txtInvoiceNumber.BOSComment = null;
            this.fld_txtInvoiceNumber.BOSDataMember = "InvoiceNumber";
            this.fld_txtInvoiceNumber.BOSDataSource = "ACEInvoiceGenerals";
            this.fld_txtInvoiceNumber.BOSDescription = null;
            this.fld_txtInvoiceNumber.BOSError = null;
            this.fld_txtInvoiceNumber.BOSFieldGroup = null;
            this.fld_txtInvoiceNumber.BOSFieldRelation = null;
            this.fld_txtInvoiceNumber.BOSPrivilege = null;
            this.fld_txtInvoiceNumber.BOSPropertyName = "EditValue";
            this.fld_txtInvoiceNumber.Location = new System.Drawing.Point(102, 120);
            this.fld_txtInvoiceNumber.Name = "fld_txtInvoiceNumber";
            this.fld_txtInvoiceNumber.Screen = null;
            this.fld_txtInvoiceNumber.Size = new System.Drawing.Size(150, 20);
            this.fld_txtInvoiceNumber.TabIndex = 8;
            this.fld_txtInvoiceNumber.Tag = "DC";
            // 
            // bosLabel19
            // 
            this.bosLabel19.BOSComment = null;
            this.bosLabel19.BOSDataMember = null;
            this.bosLabel19.BOSDataSource = null;
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = null;
            this.bosLabel19.BOSFieldRelation = null;
            this.bosLabel19.BOSPrivilege = null;
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(9, 123);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(54, 13);
            this.bosLabel19.TabIndex = 839;
            this.bosLabel19.Text = "Số hóa đơn";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 403);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1037, 397);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcACEInvoiceDetails);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1035, 372);
            this.xtraTabPage1.Text = "Danh sách sản phẩm";
            // 
            // fld_dgcACEInvoiceDetails
            // 
            this.fld_dgcACEInvoiceDetails.BOSComment = null;
            this.fld_dgcACEInvoiceDetails.BOSDataMember = null;
            this.fld_dgcACEInvoiceDetails.BOSDataSource = "ACEInvoiceDetails";
            this.fld_dgcACEInvoiceDetails.BOSDescription = null;
            this.fld_dgcACEInvoiceDetails.BOSError = null;
            this.fld_dgcACEInvoiceDetails.BOSFieldGroup = null;
            this.fld_dgcACEInvoiceDetails.BOSFieldRelation = null;
            this.fld_dgcACEInvoiceDetails.BOSGridType = null;
            this.fld_dgcACEInvoiceDetails.BOSPrivilege = null;
            this.fld_dgcACEInvoiceDetails.BOSPropertyName = null;
            this.fld_dgcACEInvoiceDetails.CommodityType = "";
            this.fld_dgcACEInvoiceDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACEInvoiceDetails.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACEInvoiceDetails.MenuManager = this.screenToolbar;
            this.fld_dgcACEInvoiceDetails.Name = "fld_dgcACEInvoiceDetails";
            this.fld_dgcACEInvoiceDetails.PrintReport = false;
            this.fld_dgcACEInvoiceDetails.Screen = null;
            this.fld_dgcACEInvoiceDetails.Size = new System.Drawing.Size(1035, 372);
            this.fld_dgcACEInvoiceDetails.TabIndex = 0;
            // 
            // DMEIBKAV100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1043, 803);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMEIBKAV100.IconOptions.Icon")));
            this.Name = "DMEIBKAV100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosLine6.ResumeLayout(false);
            this.bosLine6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAdditionalReferenceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAdditionalReferenceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtOriginalInvoiceId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAdditionalReferenceDesc.Properties)).EndInit();
            this.bosLine5.ResumeLayout(false);
            this.bosLine5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbTaxOfficeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDiscountAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSumOfTotalLineAmountWithoutVAT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtTotalVATAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtTotalAmountWithVAT.Properties)).EndInit();
            this.bosLine3.ResumeLayout(false);
            this.bosLine3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBuyerDisplayName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbBuyerType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBuyerEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbACEInvoiceGeneralReceiveType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBuyerCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBuyerLegalName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBuyerAddressLine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBuyerBankNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBuyerPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBuyerBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBuyerTaxCode.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            this.bosLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACTaxUnitID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbPaymentStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPublicKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACEInvoiceGeneralStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACEInvoicePaymentMethodName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARAllocationDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtTemplateCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtInvoiceSeries.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACEInvoiceGeneralNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSubmittedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSubmittedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteInvoiceIssuedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteInvoiceIssuedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtContractNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtInvoiceName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtInvoiceNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEInvoiceDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSTextBox fld_txtInvoiceName;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSTextBox fld_txtInvoiceSeries;
        private BOSComponent.BOSTextBox fld_txtTemplateCode;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSTextBox fld_txtInvoiceNumber;
        private BOSComponent.BOSTextBox fld_txtACEInvoiceGeneralNo;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private EInvoiceDetailsGridControl fld_dgcACEInvoiceDetails;
        private BOSComponent.BOSLookupEdit fld_lkeACEInvoiceGeneralStatus;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSDateEdit fld_dteInvoiceIssuedDate;
        private BOSComponent.BOSTextBox fld_txtContractNumber;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtExchangeRate;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSMemoEdit fld_medARAllocationDesc;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSLine bosLine3;
        private BOSComponent.BOSTextBox fld_txtBuyerAddressLine;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSTextBox fld_txtBuyerEmail;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSTextBox fld_txtBuyerTaxCode;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSTextBox fld_txtBuyerLegalName;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSLine bosLine5;
        private BOSComponent.BOSLabel bosLabel26;
        private BOSComponent.BOSTextBox fld_txtSumOfTotalLineAmountWithoutVAT;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSTextBox fld_txtTotalVATAmount;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSTextBox fld_txtTotalAmountWithVAT;
        private BOSComponent.BOSLine bosLine6;
        private BOSComponent.BOSTextBox fld_txtOriginalInvoiceId;
        private BOSComponent.BOSLabel bosLabel28;
        private BOSComponent.BOSTextBox fld_txtAdditionalReferenceDesc;
        private BOSComponent.BOSLabel bosLabel29;
        private BOSComponent.BOSLabel bosLabel30;
        private BOSComponent.BOSDateEdit fld_dteAdditionalReferenceDate;
        private BOSComponent.BOSMemoEdit bosMemoEdit1;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSLookupEdit fld_lkeACEInvoicePaymentMethodName;
        private BOSComponent.BOSLabel bosLabel32;
        private BOSComponent.BOSTextBox fld_txtBuyerCode;
        private BOSComponent.BOSLabel bosLabel31;
        private BOSComponent.BOSLabel bosLabel35;
        private BOSComponent.BOSLabel bosLabel34;
        private BOSComponent.BOSTextBox fld_txtBuyerBankNumber;
        private BOSComponent.BOSTextBox fld_txtBuyerBankName;
        private BOSComponent.BOSTextBox fld_txtBuyerPhoneNumber;
        private BOSComponent.BOSLabel bosLabel36;
        private BOSComponent.BOSDateEdit fld_dteSubmittedDate;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtPublicKey;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox fld_txtDiscountAmount;
        private BOSComponent.BOSLabel fld_lblLabel46;
        private BOSComponent.BOSComboBox fld_cmbBuyerType;
        private BOSComponent.BOSComboBox fld_cmbTaxOfficeCode;
        private BOSComponent.BOSComboBox fld_cmbPaymentStatus;
        private BOSComponent.BOSLabel bosLabel33;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSComboBox fld_cmbACEInvoiceGeneralReceiveType;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACTaxUnitID;
        private BOSComponent.BOSTextBox fld_txtBuyerDisplayName;
        private BOSComponent.BOSLabel bosLabel37;
    }
}
