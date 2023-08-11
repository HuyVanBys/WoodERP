using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CustomerPayment.UI
{
	/// <summary>
	/// Summary description for DMARCP100
	/// </summary>
	partial class DMARCP100
    {
		private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSDateEdit fld_dteARCustomerPaymentDate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARInvoices;


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
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerPaymentExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerPaymentNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARCustomerPaymentDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnInvoice = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARInvoices = new BOSERP.Modules.CustomerPayment.ARInvoicesGridControl();
            this.fld_dgvARInvoices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_tabCustomerPayments = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageCustomerPayment = new DevExpress.XtraTab.XtraTabPage();
            this.fld_tabPagePosting = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcDocumentEntrys = new BOSERP.Modules.CustomerPayment.DocumentEntryGridControl();
            this.fld_dgvACBankTransactionItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_medARCustomerPaymentDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_pteARCustomerPaymentEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARCustomerPaymentBankAccount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerPaymentTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerPaymentSenderName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcARCustomerPaymentDetails = new BOSERP.ARCustomerPaymentDetailsGridControl();
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_CSCompanyBankID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCustomerPaymentDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCustomerPaymentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARInvoices)).BeginInit();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCustomerPayments)).BeginInit();
            this.fld_tabCustomerPayments.SuspendLayout();
            this.fld_tabPageCustomerPayment.SuspendLayout();
            this.fld_tabPagePosting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACBankTransactionItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARCustomerPaymentDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARCustomerPaymentEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentBankAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentSenderName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCustomerPaymentDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyBankID.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.bosLabel1.Location = new System.Drawing.Point(134, 13);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 15;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // fld_txtARCustomerPaymentExchangeRate
            // 
            this.fld_txtARCustomerPaymentExchangeRate.BOSComment = null;
            this.fld_txtARCustomerPaymentExchangeRate.BOSDataMember = "ARCustomerPaymentExchangeRate";
            this.fld_txtARCustomerPaymentExchangeRate.BOSDataSource = "ARCustomerPayments";
            this.fld_txtARCustomerPaymentExchangeRate.BOSDescription = null;
            this.fld_txtARCustomerPaymentExchangeRate.BOSError = null;
            this.fld_txtARCustomerPaymentExchangeRate.BOSFieldGroup = null;
            this.fld_txtARCustomerPaymentExchangeRate.BOSFieldRelation = null;
            this.fld_txtARCustomerPaymentExchangeRate.BOSPrivilege = null;
            this.fld_txtARCustomerPaymentExchangeRate.BOSPropertyName = "Text";
            this.fld_txtARCustomerPaymentExchangeRate.Location = new System.Drawing.Point(740, 88);
            this.fld_txtARCustomerPaymentExchangeRate.Name = "fld_txtARCustomerPaymentExchangeRate";
            this.fld_txtARCustomerPaymentExchangeRate.Screen = null;
            this.fld_txtARCustomerPaymentExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARCustomerPaymentExchangeRate.TabIndex = 9;
            this.fld_txtARCustomerPaymentExchangeRate.Tag = "DC";
            // 
            // fld_txtARCustomerPaymentNo
            // 
            this.fld_txtARCustomerPaymentNo.BOSComment = null;
            this.fld_txtARCustomerPaymentNo.BOSDataMember = "ARCustomerPaymentNo";
            this.fld_txtARCustomerPaymentNo.BOSDataSource = "ARCustomerPayments";
            this.fld_txtARCustomerPaymentNo.BOSDescription = null;
            this.fld_txtARCustomerPaymentNo.BOSError = null;
            this.fld_txtARCustomerPaymentNo.BOSFieldGroup = null;
            this.fld_txtARCustomerPaymentNo.BOSFieldRelation = null;
            this.fld_txtARCustomerPaymentNo.BOSPrivilege = null;
            this.fld_txtARCustomerPaymentNo.BOSPropertyName = "Text";
            this.fld_txtARCustomerPaymentNo.Location = new System.Drawing.Point(231, 10);
            this.fld_txtARCustomerPaymentNo.MenuManager = this.screenToolbar;
            this.fld_txtARCustomerPaymentNo.Name = "fld_txtARCustomerPaymentNo";
            this.fld_txtARCustomerPaymentNo.Screen = null;
            this.fld_txtARCustomerPaymentNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARCustomerPaymentNo.TabIndex = 1;
            this.fld_txtARCustomerPaymentNo.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.Location = new System.Drawing.Point(672, 91);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(29, 13);
            this.bosLabel3.TabIndex = 6;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.Text = "Tỷ giá";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.Location = new System.Drawing.Point(406, 91);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(53, 13);
            this.bosLabel2.TabIndex = 6;
            this.bosLabel2.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.Text = "Loại tiền tệ";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel2.Location = new System.Drawing.Point(134, 39);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(56, 13);
            this.fld_lblLabel2.TabIndex = 6;
            this.fld_lblLabel2.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel2.Text = "Khách hàng";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.Location = new System.Drawing.Point(406, 13);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel3.TabIndex = 7;
            this.fld_lblLabel3.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.Text = "Ngày chứng từ";
            // 
            // fld_dteARCustomerPaymentDate
            // 
            this.fld_dteARCustomerPaymentDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteARCustomerPaymentDate.BOSDataMember = "ARCustomerPaymentDate";
            this.fld_dteARCustomerPaymentDate.BOSDataSource = "ARCustomerPayments";
            this.fld_dteARCustomerPaymentDate.BOSDescription = null;
            this.fld_dteARCustomerPaymentDate.BOSError = null;
            this.fld_dteARCustomerPaymentDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteARCustomerPaymentDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteARCustomerPaymentDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteARCustomerPaymentDate.BOSPropertyName = "EditValue";
            this.fld_dteARCustomerPaymentDate.EditValue = null;
            this.fld_dteARCustomerPaymentDate.Location = new System.Drawing.Point(498, 10);
            this.fld_dteARCustomerPaymentDate.Name = "fld_dteARCustomerPaymentDate";
            this.fld_dteARCustomerPaymentDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARCustomerPaymentDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARCustomerPaymentDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARCustomerPaymentDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARCustomerPaymentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARCustomerPaymentDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARCustomerPaymentDate.Screen = null;
            this.fld_dteARCustomerPaymentDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARCustomerPaymentDate.TabIndex = 2;
            this.fld_dteARCustomerPaymentDate.Tag = "DC";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ARCustomerPayments";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(498, 88);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_GECurrencyID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 8;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // fld_lkeFK_ARCustomerID
            // 
            this.fld_lkeFK_ARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID.BOSAllowDummy = false;
            this.fld_lkeFK_ARCustomerID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ARCustomerID.BOSDataMember = "FK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.BOSDataSource = "ARCustomerPayments";
            this.fld_lkeFK_ARCustomerID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID.BOSError = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ARCustomerID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ARCustomerID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ARCustomerID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ARCustomerID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ARCustomerID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ARCustomerID.CurrentDisplayText = null;
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(231, 36);
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ARCustomerID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ARCustomerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Screen = null;
            this.fld_lkeFK_ARCustomerID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARCustomerID.TabIndex = 3;
            this.fld_lkeFK_ARCustomerID.Tag = "DC";
            this.fld_lkeFK_ARCustomerID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ARCustomerID_CloseUp);
            // 
            // fld_btnInvoice
            // 
            this.fld_btnInvoice.BOSComment = null;
            this.fld_btnInvoice.BOSDataMember = null;
            this.fld_btnInvoice.BOSDataSource = null;
            this.fld_btnInvoice.BOSDescription = null;
            this.fld_btnInvoice.BOSError = null;
            this.fld_btnInvoice.BOSFieldGroup = null;
            this.fld_btnInvoice.BOSFieldRelation = null;
            this.fld_btnInvoice.BOSPrivilege = null;
            this.fld_btnInvoice.BOSPropertyName = null;
            this.fld_btnInvoice.Location = new System.Drawing.Point(2, 3);
            this.fld_btnInvoice.Name = "fld_btnInvoice";
            this.fld_btnInvoice.Screen = null;
            this.fld_btnInvoice.Size = new System.Drawing.Size(122, 27);
            this.fld_btnInvoice.TabIndex = 8;
            this.fld_btnInvoice.Text = "Chọn hóa đơn nợ";
            this.fld_btnInvoice.Click += new System.EventHandler(this.fld_btnInvoice_Click);
            // 
            // fld_dgcARInvoices
            // 
            this.fld_dgcARInvoices.AllowDrop = true;
            this.fld_dgcARInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARInvoices.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARInvoices.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARInvoices.BOSDataSource = "ARInvoices";
            this.fld_dgcARInvoices.BOSDescription = null;
            this.fld_dgcARInvoices.BOSError = null;
            this.fld_dgcARInvoices.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARInvoices.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARInvoices.BOSGridType = null;
            this.fld_dgcARInvoices.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARInvoices.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARInvoices.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARInvoices.Location = new System.Drawing.Point(2, 36);
            this.fld_dgcARInvoices.MainView = this.fld_dgvARInvoices;
            this.fld_dgcARInvoices.Name = "fld_dgcARInvoices";
            this.fld_dgcARInvoices.PrintReport = false;
            this.fld_dgcARInvoices.Screen = null;
            this.fld_dgcARInvoices.Size = new System.Drawing.Size(955, 201);
            this.fld_dgcARInvoices.TabIndex = 12;
            this.fld_dgcARInvoices.Tag = "DC";
            this.fld_dgcARInvoices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARInvoices});
            // 
            // fld_dgvARInvoices
            // 
            this.fld_dgvARInvoices.GridControl = this.fld_dgcARInvoices;
            this.fld_dgvARInvoices.Name = "fld_dgvARInvoices";
            this.fld_dgvARInvoices.PaintStyleName = "Office2003";
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
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(903, 136);
            this.bosPanel1.TabIndex = 6;
            // 
            // bosPanel2
            // 
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.fld_tabCustomerPayments);
            this.bosPanel2.Controls.Add(this.fld_medARCustomerPaymentDesc);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel2.Controls.Add(this.bosLabel2);
            this.bosPanel2.Controls.Add(this.fld_pteARCustomerPaymentEmployeePicture);
            this.bosPanel2.Controls.Add(this.bosLabel3);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel2.Controls.Add(this.fld_txtARCustomerPaymentExchangeRate);
            this.bosPanel2.Controls.Add(this.bosLabel1);
            this.bosPanel2.Controls.Add(this.fld_txtARCustomerPaymentBankAccount);
            this.bosPanel2.Controls.Add(this.fld_txtARCustomerPaymentTotalAmount);
            this.bosPanel2.Controls.Add(this.fld_txtARCustomerPaymentSenderName);
            this.bosPanel2.Controls.Add(this.fld_txtARCustomerPaymentNo);
            this.bosPanel2.Controls.Add(this.bosLabel4);
            this.bosPanel2.Controls.Add(this.bosLabel5);
            this.bosPanel2.Controls.Add(this.bosGroupControl1);
            this.bosPanel2.Controls.Add(this.bosLabel6);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_CSCompanyBankID);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.bosPanel2.Controls.Add(this.bosLabel7);
            this.bosPanel2.Controls.Add(this.bosLabel8);
            this.bosPanel2.Controls.Add(this.fld_lblLabel2);
            this.bosPanel2.Controls.Add(this.fld_lblLabel3);
            this.bosPanel2.Controls.Add(this.fld_dteARCustomerPaymentDate);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(964, 589);
            this.bosPanel2.TabIndex = 7;
            // 
            // fld_tabCustomerPayments
            // 
            this.fld_tabCustomerPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabCustomerPayments.BOSComment = null;
            this.fld_tabCustomerPayments.BOSDataMember = null;
            this.fld_tabCustomerPayments.BOSDataSource = null;
            this.fld_tabCustomerPayments.BOSDescription = null;
            this.fld_tabCustomerPayments.BOSError = null;
            this.fld_tabCustomerPayments.BOSFieldGroup = null;
            this.fld_tabCustomerPayments.BOSFieldRelation = null;
            this.fld_tabCustomerPayments.BOSPrivilege = null;
            this.fld_tabCustomerPayments.BOSPropertyName = null;
            this.fld_tabCustomerPayments.Location = new System.Drawing.Point(0, 157);
            this.fld_tabCustomerPayments.Name = "fld_tabCustomerPayments";
            this.fld_tabCustomerPayments.Screen = null;
            this.fld_tabCustomerPayments.SelectedTabPage = this.fld_tabPageCustomerPayment;
            this.fld_tabCustomerPayments.Size = new System.Drawing.Size(964, 266);
            this.fld_tabCustomerPayments.TabIndex = 21;
            this.fld_tabCustomerPayments.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageCustomerPayment,
            this.fld_tabPagePosting});
            // 
            // fld_tabPageCustomerPayment
            // 
            this.fld_tabPageCustomerPayment.Controls.Add(this.fld_dgcARInvoices);
            this.fld_tabPageCustomerPayment.Controls.Add(this.fld_btnInvoice);
            this.fld_tabPageCustomerPayment.Name = "fld_tabPageCustomerPayment";
            this.fld_tabPageCustomerPayment.Size = new System.Drawing.Size(957, 237);
            this.fld_tabPageCustomerPayment.Text = "Hóa đơn thanh toán";
            // 
            // fld_tabPagePosting
            // 
            this.fld_tabPagePosting.Controls.Add(this.fld_dgcDocumentEntrys);
            this.fld_tabPagePosting.Name = "fld_tabPagePosting";
            this.fld_tabPagePosting.Size = new System.Drawing.Size(957, 237);
            this.fld_tabPagePosting.Text = "Hạch toán";
            // 
            // fld_dgcDocumentEntrys
            // 
            this.fld_dgcDocumentEntrys.AllowDrop = true;
            this.fld_dgcDocumentEntrys.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcDocumentEntrys.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcDocumentEntrys.BOSDescription = null;
            this.fld_dgcDocumentEntrys.BOSError = null;
            this.fld_dgcDocumentEntrys.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcDocumentEntrys.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcDocumentEntrys.BOSGridType = null;
            this.fld_dgcDocumentEntrys.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcDocumentEntrys.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcDocumentEntrys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcDocumentEntrys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcDocumentEntrys.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcDocumentEntrys.MainView = this.fld_dgvACBankTransactionItems;
            this.fld_dgcDocumentEntrys.Name = "fld_dgcDocumentEntrys";
            this.fld_dgcDocumentEntrys.PrintReport = false;
            this.fld_dgcDocumentEntrys.Screen = null;
            this.fld_dgcDocumentEntrys.Size = new System.Drawing.Size(957, 237);
            this.fld_dgcDocumentEntrys.TabIndex = 1;
            this.fld_dgcDocumentEntrys.Tag = "DC";
            this.fld_dgcDocumentEntrys.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvACBankTransactionItems});
            // 
            // fld_dgvACBankTransactionItems
            // 
            this.fld_dgvACBankTransactionItems.GridControl = this.fld_dgcDocumentEntrys;
            this.fld_dgvACBankTransactionItems.Name = "fld_dgvACBankTransactionItems";
            this.fld_dgvACBankTransactionItems.PaintStyleName = "Office2003";
            // 
            // fld_medARCustomerPaymentDesc
            // 
            this.fld_medARCustomerPaymentDesc.BOSComment = null;
            this.fld_medARCustomerPaymentDesc.BOSDataMember = "ARCustomerPaymentDesc";
            this.fld_medARCustomerPaymentDesc.BOSDataSource = "ARCustomerPayments";
            this.fld_medARCustomerPaymentDesc.BOSDescription = null;
            this.fld_medARCustomerPaymentDesc.BOSError = null;
            this.fld_medARCustomerPaymentDesc.BOSFieldGroup = null;
            this.fld_medARCustomerPaymentDesc.BOSFieldRelation = null;
            this.fld_medARCustomerPaymentDesc.BOSPrivilege = null;
            this.fld_medARCustomerPaymentDesc.BOSPropertyName = "EditValue";
            this.fld_medARCustomerPaymentDesc.Location = new System.Drawing.Point(231, 114);
            this.fld_medARCustomerPaymentDesc.MenuManager = this.screenToolbar;
            this.fld_medARCustomerPaymentDesc.Name = "fld_medARCustomerPaymentDesc";
            this.fld_medARCustomerPaymentDesc.Screen = null;
            this.fld_medARCustomerPaymentDesc.Size = new System.Drawing.Size(659, 38);
            this.fld_medARCustomerPaymentDesc.TabIndex = 10;
            this.fld_medARCustomerPaymentDesc.Tag = "DC";
            // 
            // fld_pteARCustomerPaymentEmployeePicture
            // 
            this.fld_pteARCustomerPaymentEmployeePicture.BOSComment = null;
            this.fld_pteARCustomerPaymentEmployeePicture.BOSDataMember = "ARCustomerPaymentEmployeePicture";
            this.fld_pteARCustomerPaymentEmployeePicture.BOSDataSource = "ARCustomerPayments";
            this.fld_pteARCustomerPaymentEmployeePicture.BOSDescription = null;
            this.fld_pteARCustomerPaymentEmployeePicture.BOSError = null;
            this.fld_pteARCustomerPaymentEmployeePicture.BOSFieldGroup = null;
            this.fld_pteARCustomerPaymentEmployeePicture.BOSFieldRelation = null;
            this.fld_pteARCustomerPaymentEmployeePicture.BOSPrivilege = null;
            this.fld_pteARCustomerPaymentEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteARCustomerPaymentEmployeePicture.Location = new System.Drawing.Point(4, 4);
            this.fld_pteARCustomerPaymentEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteARCustomerPaymentEmployeePicture.Name = "fld_pteARCustomerPaymentEmployeePicture";
            this.fld_pteARCustomerPaymentEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARCustomerPaymentEmployeePicture.Screen = null;
            this.fld_pteARCustomerPaymentEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteARCustomerPaymentEmployeePicture.TabIndex = 17;
            this.fld_pteARCustomerPaymentEmployeePicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARCustomerPayments";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(5, 106);
            this.fld_lkeFK_HREmployeeID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(99, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 16;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_txtARCustomerPaymentBankAccount
            // 
            this.fld_txtARCustomerPaymentBankAccount.BOSComment = null;
            this.fld_txtARCustomerPaymentBankAccount.BOSDataMember = "ARCustomerPaymentBankAccount";
            this.fld_txtARCustomerPaymentBankAccount.BOSDataSource = "ARCustomerPayments";
            this.fld_txtARCustomerPaymentBankAccount.BOSDescription = null;
            this.fld_txtARCustomerPaymentBankAccount.BOSError = null;
            this.fld_txtARCustomerPaymentBankAccount.BOSFieldGroup = null;
            this.fld_txtARCustomerPaymentBankAccount.BOSFieldRelation = null;
            this.fld_txtARCustomerPaymentBankAccount.BOSPrivilege = null;
            this.fld_txtARCustomerPaymentBankAccount.BOSPropertyName = "Text";
            this.fld_txtARCustomerPaymentBankAccount.Location = new System.Drawing.Point(498, 62);
            this.fld_txtARCustomerPaymentBankAccount.Name = "fld_txtARCustomerPaymentBankAccount";
            this.fld_txtARCustomerPaymentBankAccount.Screen = null;
            this.fld_txtARCustomerPaymentBankAccount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARCustomerPaymentBankAccount.TabIndex = 6;
            this.fld_txtARCustomerPaymentBankAccount.Tag = "DC";
            // 
            // fld_txtARCustomerPaymentTotalAmount
            // 
            this.fld_txtARCustomerPaymentTotalAmount.BOSComment = null;
            this.fld_txtARCustomerPaymentTotalAmount.BOSDataMember = "ARCustomerPaymentTotalAmount";
            this.fld_txtARCustomerPaymentTotalAmount.BOSDataSource = "ARCustomerPayments";
            this.fld_txtARCustomerPaymentTotalAmount.BOSDescription = null;
            this.fld_txtARCustomerPaymentTotalAmount.BOSError = null;
            this.fld_txtARCustomerPaymentTotalAmount.BOSFieldGroup = null;
            this.fld_txtARCustomerPaymentTotalAmount.BOSFieldRelation = null;
            this.fld_txtARCustomerPaymentTotalAmount.BOSPrivilege = null;
            this.fld_txtARCustomerPaymentTotalAmount.BOSPropertyName = "Text";
            this.fld_txtARCustomerPaymentTotalAmount.Location = new System.Drawing.Point(231, 88);
            this.fld_txtARCustomerPaymentTotalAmount.Name = "fld_txtARCustomerPaymentTotalAmount";
            this.fld_txtARCustomerPaymentTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARCustomerPaymentTotalAmount.Screen = null;
            this.fld_txtARCustomerPaymentTotalAmount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARCustomerPaymentTotalAmount.TabIndex = 7;
            this.fld_txtARCustomerPaymentTotalAmount.Tag = "DC";
            // 
            // fld_txtARCustomerPaymentSenderName
            // 
            this.fld_txtARCustomerPaymentSenderName.BOSComment = null;
            this.fld_txtARCustomerPaymentSenderName.BOSDataMember = "ARCustomerPaymentSenderName";
            this.fld_txtARCustomerPaymentSenderName.BOSDataSource = "ARCustomerPayments";
            this.fld_txtARCustomerPaymentSenderName.BOSDescription = null;
            this.fld_txtARCustomerPaymentSenderName.BOSError = null;
            this.fld_txtARCustomerPaymentSenderName.BOSFieldGroup = null;
            this.fld_txtARCustomerPaymentSenderName.BOSFieldRelation = null;
            this.fld_txtARCustomerPaymentSenderName.BOSPrivilege = null;
            this.fld_txtARCustomerPaymentSenderName.BOSPropertyName = "Text";
            this.fld_txtARCustomerPaymentSenderName.Location = new System.Drawing.Point(498, 36);
            this.fld_txtARCustomerPaymentSenderName.Name = "fld_txtARCustomerPaymentSenderName";
            this.fld_txtARCustomerPaymentSenderName.Screen = null;
            this.fld_txtARCustomerPaymentSenderName.Size = new System.Drawing.Size(392, 20);
            this.fld_txtARCustomerPaymentSenderName.TabIndex = 4;
            this.fld_txtARCustomerPaymentSenderName.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.Location = new System.Drawing.Point(134, 117);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(40, 13);
            this.bosLabel4.TabIndex = 6;
            this.bosLabel4.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.Text = "Diễn giải";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.Location = new System.Drawing.Point(134, 65);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(52, 13);
            this.bosLabel5.TabIndex = 6;
            this.bosLabel5.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.Text = "Ngân hàng";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
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
            this.bosGroupControl1.Controls.Add(this.fld_dgcARCustomerPaymentDetails);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 425);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(957, 161);
            this.bosGroupControl1.TabIndex = 22;
            this.bosGroupControl1.Text = "Thông tin thanh toán";
            // 
            // fld_dgcARCustomerPaymentDetails
            // 
            this.fld_dgcARCustomerPaymentDetails.AllowMultiplePayment = false;
            this.fld_dgcARCustomerPaymentDetails.AllowPaymentByCurrency = false;
            this.fld_dgcARCustomerPaymentDetails.BOSComment = null;
            this.fld_dgcARCustomerPaymentDetails.BOSDataMember = null;
            this.fld_dgcARCustomerPaymentDetails.BOSDataSource = "ARCustomerPaymentDetails";
            this.fld_dgcARCustomerPaymentDetails.BOSDescription = null;
            this.fld_dgcARCustomerPaymentDetails.BOSError = null;
            this.fld_dgcARCustomerPaymentDetails.BOSFieldGroup = null;
            this.fld_dgcARCustomerPaymentDetails.BOSFieldRelation = null;
            this.fld_dgcARCustomerPaymentDetails.BOSGridType = null;
            this.fld_dgcARCustomerPaymentDetails.BOSPrivilege = null;
            this.fld_dgcARCustomerPaymentDetails.BOSPropertyName = null;
            this.fld_dgcARCustomerPaymentDetails.CustomerPaymentDetailList = null;
            this.fld_dgcARCustomerPaymentDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARCustomerPaymentDetails.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcARCustomerPaymentDetails.MenuManager = this.screenToolbar;
            this.fld_dgcARCustomerPaymentDetails.Name = "fld_dgcARCustomerPaymentDetails";
            this.fld_dgcARCustomerPaymentDetails.PaymentAmount = 0;
            this.fld_dgcARCustomerPaymentDetails.PrintReport = false;
            this.fld_dgcARCustomerPaymentDetails.RequiredMethod = null;
            this.fld_dgcARCustomerPaymentDetails.Screen = null;
            this.fld_dgcARCustomerPaymentDetails.Size = new System.Drawing.Size(953, 137);
            this.fld_dgcARCustomerPaymentDetails.TabIndex = 8;
            this.fld_dgcARCustomerPaymentDetails.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.Location = new System.Drawing.Point(405, 65);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(46, 13);
            this.bosLabel6.TabIndex = 6;
            this.bosLabel6.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.Text = "Tài khoản";
            // 
            // fld_lkeFK_CSCompanyBankID
            // 
            this.fld_lkeFK_CSCompanyBankID.BOSAllowAddNew = false;
            this.fld_lkeFK_CSCompanyBankID.BOSAllowDummy = true;
            this.fld_lkeFK_CSCompanyBankID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_CSCompanyBankID.BOSDataMember = "FK_CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.BOSDataSource = "ARCustomerPayments";
            this.fld_lkeFK_CSCompanyBankID.BOSDescription = null;
            this.fld_lkeFK_CSCompanyBankID.BOSError = null;
            this.fld_lkeFK_CSCompanyBankID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_CSCompanyBankID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_CSCompanyBankID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_CSCompanyBankID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_CSCompanyBankID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_CSCompanyBankID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_CSCompanyBankID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_CSCompanyBankID.CurrentDisplayText = null;
            this.fld_lkeFK_CSCompanyBankID.Location = new System.Drawing.Point(231, 62);
            this.fld_lkeFK_CSCompanyBankID.Name = "fld_lkeFK_CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_CSCompanyBankID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_CSCompanyBankID.Properties.DisplayMember = "CSCompanyBankName";
            this.fld_lkeFK_CSCompanyBankID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_CSCompanyBankID.Properties.PopupWidth = 40;
            this.fld_lkeFK_CSCompanyBankID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_CSCompanyBankID.Properties.ValueMember = "CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.Screen = null;
            this.fld_lkeFK_CSCompanyBankID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_CSCompanyBankID.TabIndex = 5;
            this.fld_lkeFK_CSCompanyBankID.Tag = "DC";
            this.fld_lkeFK_CSCompanyBankID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_CSCompanyBankID_CloseUp);
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel7.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel7.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel7.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel7.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel7.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel7.Location = new System.Drawing.Point(134, 91);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(76, 13);
            this.bosLabel7.TabIndex = 6;
            this.bosLabel7.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel7.Text = "Tiền thanh toán";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel8.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel8.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel8.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel8.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel8.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel8.Location = new System.Drawing.Point(406, 39);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(70, 13);
            this.bosLabel8.TabIndex = 6;
            this.bosLabel8.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel8.Text = "Người nộp tiền";
            // 
            // DMARCP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(964, 589);
            this.Controls.Add(this.bosPanel2);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMARCP100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCustomerPaymentDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCustomerPaymentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARInvoices)).EndInit();
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCustomerPayments)).EndInit();
            this.fld_tabCustomerPayments.ResumeLayout(false);
            this.fld_tabPageCustomerPayment.ResumeLayout(false);
            this.fld_tabPagePosting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACBankTransactionItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARCustomerPaymentDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARCustomerPaymentEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentBankAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentSenderName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCustomerPaymentDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyBankID.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtARCustomerPaymentNo;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private ARInvoicesGridControl fld_dgcARInvoices;
        private BOSComponent.BOSButton fld_btnInvoice;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSTextBox fld_txtARCustomerPaymentExchangeRate;        
        private BOSComponent.BOSPictureEdit fld_pteARCustomerPaymentEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSMemoEdit fld_medARCustomerPaymentDesc;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtARCustomerPaymentBankAccount;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_CSCompanyBankID;
        private BOSComponent.BOSTabControl fld_tabCustomerPayments;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageCustomerPayment;
        private DevExpress.XtraTab.XtraTabPage fld_tabPagePosting;
        private DocumentEntryGridControl fld_dgcDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACBankTransactionItems;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtARCustomerPaymentTotalAmount;
        private ARCustomerPaymentDetailsGridControl fld_dgcARCustomerPaymentDetails;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtARCustomerPaymentSenderName;
	}
}
