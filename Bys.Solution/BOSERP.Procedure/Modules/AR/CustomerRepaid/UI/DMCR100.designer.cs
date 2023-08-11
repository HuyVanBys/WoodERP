using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CustomerRepaid.UI
{
	/// <summary>
	/// Summary description for DMCR100
	/// </summary>
	partial class DMCR100
	{
		private BOSComponent.BOSTextBox fld_txtARCustomerPaymentNo1;
		private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel fld_lblLabel6;
		private BOSComponent.BOSLabel fld_lblLabel8;
		private BOSComponent.BOSLabel fld_lblLabel9;
		private BOSComponent.BOSLabel fld_lblLabel10;
        private BOSComponent.BOSDateEdit fld_dteARCustomerPaymentDate2;
		private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
		private BOSComponent.BOSTextBox fld_txtARCustomerPaymentExchangeRate;
        private BOSComponent.BOSMemoEdit fld_medARCustomerPaymentDesc;


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
            this.fld_txtARCustomerPaymentNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARCustomerPaymentDate2 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARCustomerPaymentExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.fld_medARCustomerPaymentDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_pteARCustomerPaymentEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnChooseOwingInvoices = new BOSComponent.BOSButton(this.components);
            this.fld_dgcInvoices = new BOSERP.Modules.CustomerRepaid.InvoiceGridControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeFK_CSCashFundID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerPaymentBankAccount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_CSCompanyBankID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcDocumentEntrys = new BOSERP.Modules.CustomerRepaid.DocumentEntryGridControl();
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcCustomerPaymentDetails = new BOSERP.ARCustomerPaymentDetailsGridControl();
            this.fld_txtARCustomerPaymentTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCustomerPaymentDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCustomerPaymentDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARCustomerPaymentDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARCustomerPaymentEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcInvoices)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCashFundID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentBankAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyBankID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCustomerPaymentDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentTotalAmount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtARCustomerPaymentNo1
            // 
            this.fld_txtARCustomerPaymentNo1.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARCustomerPaymentNo1.BOSDataMember = "ARCustomerPaymentNo";
            this.fld_txtARCustomerPaymentNo1.BOSDataSource = "ARCustomerPayments";
            this.fld_txtARCustomerPaymentNo1.BOSDescription = null;
            this.fld_txtARCustomerPaymentNo1.BOSError = null;
            this.fld_txtARCustomerPaymentNo1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARCustomerPaymentNo1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARCustomerPaymentNo1.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARCustomerPaymentNo1.BOSPropertyName = "Text";
            this.fld_txtARCustomerPaymentNo1.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARCustomerPaymentNo1.Location = new System.Drawing.Point(210, 10);
            this.fld_txtARCustomerPaymentNo1.Name = "fld_txtARCustomerPaymentNo1";
            this.fld_txtARCustomerPaymentNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerPaymentNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerPaymentNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerPaymentNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerPaymentNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerPaymentNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerPaymentNo1.Screen = null;
            this.fld_txtARCustomerPaymentNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARCustomerPaymentNo1.TabIndex = 1;
            this.fld_txtARCustomerPaymentNo1.Tag = "DC";
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(121, 13);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel5.TabIndex = 5;
            this.fld_lblLabel5.Tag = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel5.Text = "Mã chứng từ";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel6.Location = new System.Drawing.Point(385, 13);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel6.TabIndex = 6;
            this.fld_lblLabel6.Tag = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel6.Text = "Ngày chứng từ";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel8.Location = new System.Drawing.Point(385, 65);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(53, 13);
            this.fld_lblLabel8.TabIndex = 8;
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
            this.fld_lblLabel9.Location = new System.Drawing.Point(647, 65);
            this.fld_lblLabel9.Name = "fld_lblLabel9";
            this.fld_lblLabel9.Screen = null;
            this.fld_lblLabel9.Size = new System.Drawing.Size(29, 13);
            this.fld_lblLabel9.TabIndex = 9;
            this.fld_lblLabel9.Tag = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel9.Text = "Tỷ giá";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel10.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel10.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel10.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel10.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel10.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel10.Location = new System.Drawing.Point(121, 91);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel10.TabIndex = 10;
            this.fld_lblLabel10.Tag = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel10.Text = "Diễn giải";
            // 
            // fld_dteARCustomerPaymentDate2
            // 
            this.fld_dteARCustomerPaymentDate2.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteARCustomerPaymentDate2.BOSDataMember = "ARCustomerPaymentDate";
            this.fld_dteARCustomerPaymentDate2.BOSDataSource = "ARCustomerPayments";
            this.fld_dteARCustomerPaymentDate2.BOSDescription = null;
            this.fld_dteARCustomerPaymentDate2.BOSError = null;
            this.fld_dteARCustomerPaymentDate2.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteARCustomerPaymentDate2.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteARCustomerPaymentDate2.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteARCustomerPaymentDate2.BOSPropertyName = "EditValue";
            this.fld_dteARCustomerPaymentDate2.EditValue = null;
            this.fld_dteARCustomerPaymentDate2.Location = new System.Drawing.Point(473, 10);
            this.fld_dteARCustomerPaymentDate2.Name = "fld_dteARCustomerPaymentDate2";
            this.fld_dteARCustomerPaymentDate2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARCustomerPaymentDate2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARCustomerPaymentDate2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARCustomerPaymentDate2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARCustomerPaymentDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARCustomerPaymentDate2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARCustomerPaymentDate2.Screen = null;
            this.fld_dteARCustomerPaymentDate2.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARCustomerPaymentDate2.TabIndex = 2;
            this.fld_dteARCustomerPaymentDate2.Tag = "DC";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ARCustomerPayments";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(473, 62);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.CommonLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Name")});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyNo";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 7;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // fld_txtARCustomerPaymentExchangeRate
            // 
            this.fld_txtARCustomerPaymentExchangeRate.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARCustomerPaymentExchangeRate.BOSDataMember = "ARCustomerPaymentExchangeRate";
            this.fld_txtARCustomerPaymentExchangeRate.BOSDataSource = "ARCustomerPayments";
            this.fld_txtARCustomerPaymentExchangeRate.BOSDescription = null;
            this.fld_txtARCustomerPaymentExchangeRate.BOSError = null;
            this.fld_txtARCustomerPaymentExchangeRate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARCustomerPaymentExchangeRate.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARCustomerPaymentExchangeRate.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARCustomerPaymentExchangeRate.BOSPropertyName = "Text";
            this.fld_txtARCustomerPaymentExchangeRate.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARCustomerPaymentExchangeRate.Location = new System.Drawing.Point(737, 62);
            this.fld_txtARCustomerPaymentExchangeRate.Name = "fld_txtARCustomerPaymentExchangeRate";
            this.fld_txtARCustomerPaymentExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerPaymentExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerPaymentExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerPaymentExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerPaymentExchangeRate.Properties.Mask.EditMask = "n";
            this.fld_txtARCustomerPaymentExchangeRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARCustomerPaymentExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerPaymentExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerPaymentExchangeRate.Screen = null;
            this.fld_txtARCustomerPaymentExchangeRate.Size = new System.Drawing.Size(152, 20);
            this.fld_txtARCustomerPaymentExchangeRate.TabIndex = 8;
            this.fld_txtARCustomerPaymentExchangeRate.Tag = "DC";
            // 
            // fld_medARCustomerPaymentDesc
            // 
            this.fld_medARCustomerPaymentDesc.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_medARCustomerPaymentDesc.BOSDataMember = "ARCustomerPaymentDesc";
            this.fld_medARCustomerPaymentDesc.BOSDataSource = "ARCustomerPayments";
            this.fld_medARCustomerPaymentDesc.BOSDescription = null;
            this.fld_medARCustomerPaymentDesc.BOSError = null;
            this.fld_medARCustomerPaymentDesc.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_medARCustomerPaymentDesc.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_medARCustomerPaymentDesc.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_medARCustomerPaymentDesc.BOSPropertyName = "Text";
            this.fld_medARCustomerPaymentDesc.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_medARCustomerPaymentDesc.Location = new System.Drawing.Point(210, 88);
            this.fld_medARCustomerPaymentDesc.Name = "fld_medARCustomerPaymentDesc";
            this.fld_medARCustomerPaymentDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARCustomerPaymentDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARCustomerPaymentDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARCustomerPaymentDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARCustomerPaymentDesc.Screen = null;
            this.fld_medARCustomerPaymentDesc.Size = new System.Drawing.Size(679, 36);
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
            this.fld_pteARCustomerPaymentEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteARCustomerPaymentEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteARCustomerPaymentEmployeePicture.Name = "fld_pteARCustomerPaymentEmployeePicture";
            this.fld_pteARCustomerPaymentEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARCustomerPaymentEmployeePicture.Screen = null;
            this.fld_pteARCustomerPaymentEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteARCustomerPaymentEmployeePicture.TabIndex = 16;
            this.fld_pteARCustomerPaymentEmployeePicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARCustomerPayments";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 104);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.CommonLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 17;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_btnChooseOwingInvoices);
            this.bosGroupControl1.Controls.Add(this.fld_dgcInvoices);
            this.bosGroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosGroupControl1.Location = new System.Drawing.Point(0, 0);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(884, 255);
            this.bosGroupControl1.TabIndex = 18;
            this.bosGroupControl1.Text = "Danh sách hóa đơn thanh toán";
            // 
            // fld_btnChooseOwingInvoices
            // 
            this.fld_btnChooseOwingInvoices.BOSComment = null;
            this.fld_btnChooseOwingInvoices.BOSDataMember = null;
            this.fld_btnChooseOwingInvoices.BOSDataSource = null;
            this.fld_btnChooseOwingInvoices.BOSDescription = null;
            this.fld_btnChooseOwingInvoices.BOSError = null;
            this.fld_btnChooseOwingInvoices.BOSFieldGroup = null;
            this.fld_btnChooseOwingInvoices.BOSFieldRelation = null;
            this.fld_btnChooseOwingInvoices.BOSPrivilege = null;
            this.fld_btnChooseOwingInvoices.BOSPropertyName = null;
            this.fld_btnChooseOwingInvoices.Location = new System.Drawing.Point(5, 6);
            this.fld_btnChooseOwingInvoices.Name = "fld_btnChooseOwingInvoices";
            this.fld_btnChooseOwingInvoices.Screen = null;
            this.fld_btnChooseOwingInvoices.Size = new System.Drawing.Size(135, 27);
            this.fld_btnChooseOwingInvoices.TabIndex = 1;
            this.fld_btnChooseOwingInvoices.Text = "Chọn hóa đơn nợ";
            this.fld_btnChooseOwingInvoices.Click += new System.EventHandler(this.fld_btnChooseOwingInvoices_Click);
            // 
            // fld_dgcInvoices
            // 
            this.fld_dgcInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcInvoices.BOSComment = null;
            this.fld_dgcInvoices.BOSDataMember = null;
            this.fld_dgcInvoices.BOSDataSource = "ARInvoices";
            this.fld_dgcInvoices.BOSDescription = null;
            this.fld_dgcInvoices.BOSError = null;
            this.fld_dgcInvoices.BOSFieldGroup = null;
            this.fld_dgcInvoices.BOSFieldRelation = null;
            this.fld_dgcInvoices.BOSGridType = null;
            this.fld_dgcInvoices.BOSPrivilege = null;
            this.fld_dgcInvoices.BOSPropertyName = null;
            this.fld_dgcInvoices.Location = new System.Drawing.Point(5, 39);
            this.fld_dgcInvoices.MenuManager = this.screenToolbar;
            this.fld_dgcInvoices.Name = "fld_dgcInvoices";
            this.fld_dgcInvoices.PrintReport = false;
            this.fld_dgcInvoices.Screen = null;
            this.fld_dgcInvoices.Size = new System.Drawing.Size(874, 211);
            this.fld_dgcInvoices.TabIndex = 3;
            this.fld_dgcInvoices.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_CSCashFundID);
            this.bosPanel1.Controls.Add(this.bosLabel16);
            this.bosPanel1.Controls.Add(this.fld_txtARCustomerPaymentBankAccount);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.fld_lblLabel8);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_lblLabel9);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_CSCompanyBankID);
            this.bosPanel1.Controls.Add(this.fld_txtARCustomerPaymentExchangeRate);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.bosGroupControl2);
            this.bosPanel1.Controls.Add(this.fld_pteARCustomerPaymentEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_medARCustomerPaymentDesc);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_txtARCustomerPaymentTotalAmount);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_txtARCustomerPaymentNo1);
            this.bosPanel1.Controls.Add(this.fld_dteARCustomerPaymentDate2);
            this.bosPanel1.Controls.Add(this.fld_lblLabel6);
            this.bosPanel1.Controls.Add(this.fld_lblLabel10);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(899, 590);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.Location = new System.Drawing.Point(121, 39);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 429;
            this.bosLabel2.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.Text = "Đối tượng";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ARCustomerPayments";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.BOSFieldParent = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(210, 36);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.CommonLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 428;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            // 
            // fld_lkeFK_CSCashFundID
            // 
            this.fld_lkeFK_CSCashFundID.BOSAllowAddNew = false;
            this.fld_lkeFK_CSCashFundID.BOSAllowDummy = false;
            this.fld_lkeFK_CSCashFundID.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_CSCashFundID.BOSDataMember = "FK_CSCashFundID";
            this.fld_lkeFK_CSCashFundID.BOSDataSource = "ARCustomerPayments";
            this.fld_lkeFK_CSCashFundID.BOSDescription = null;
            this.fld_lkeFK_CSCashFundID.BOSError = null;
            this.fld_lkeFK_CSCashFundID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_CSCashFundID.BOSFieldParent = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_CSCashFundID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_CSCashFundID.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_CSCashFundID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_CSCashFundID.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_CSCashFundID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_CSCashFundID.CurrentDisplayText = null;
            this.fld_lkeFK_CSCashFundID.Location = new System.Drawing.Point(737, 10);
            this.fld_lkeFK_CSCashFundID.Name = "fld_lkeFK_CSCashFundID";
            this.fld_lkeFK_CSCashFundID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_CSCashFundID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_CSCashFundID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_CSCashFundID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_CSCashFundID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_CSCashFundID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCashFundNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCashFundName", "Tên quỹ tiền mặt")});
            this.fld_lkeFK_CSCashFundID.Properties.DisplayMember = "CSCashFundName";
            this.fld_lkeFK_CSCashFundID.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_CSCashFundID.Properties.PopupWidth = 40;
            this.fld_lkeFK_CSCashFundID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_CSCashFundID.Properties.ValueMember = "CSCashFundID";
            this.fld_lkeFK_CSCashFundID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_CSCashFundID, true);
            this.fld_lkeFK_CSCashFundID.Size = new System.Drawing.Size(152, 20);
            this.fld_lkeFK_CSCashFundID.TabIndex = 427;
            this.fld_lkeFK_CSCashFundID.Tag = "DC";
            this.fld_lkeFK_CSCashFundID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_CSCashFundID_CloseUp);
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel16.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel16.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel16.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel16.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel16.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel16.Location = new System.Drawing.Point(647, 13);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(62, 13);
            this.bosLabel16.TabIndex = 426;
            this.bosLabel16.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel16.Text = "Quỹ tiền mặt";
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
            this.fld_txtARCustomerPaymentBankAccount.Location = new System.Drawing.Point(737, 36);
            this.fld_txtARCustomerPaymentBankAccount.Name = "fld_txtARCustomerPaymentBankAccount";
            this.fld_txtARCustomerPaymentBankAccount.Screen = null;
            this.fld_txtARCustomerPaymentBankAccount.Size = new System.Drawing.Size(152, 20);
            this.fld_txtARCustomerPaymentBankAccount.TabIndex = 5;
            this.fld_txtARCustomerPaymentBankAccount.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel5.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel5.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel5.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel5.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel5.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel5.Location = new System.Drawing.Point(385, 39);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(52, 13);
            this.bosLabel5.TabIndex = 22;
            this.bosLabel5.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel5.Text = "Ngân hàng";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel6.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel6.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel6.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel6.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel6.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel6.Location = new System.Drawing.Point(647, 39);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(46, 13);
            this.bosLabel6.TabIndex = 21;
            this.bosLabel6.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel6.Text = "Tài khoản";
            // 
            // fld_lkeFK_CSCompanyBankID
            // 
            this.fld_lkeFK_CSCompanyBankID.BOSAllowAddNew = false;
            this.fld_lkeFK_CSCompanyBankID.BOSAllowDummy = true;
            this.fld_lkeFK_CSCompanyBankID.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_CSCompanyBankID.BOSDataMember = "FK_CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.BOSDataSource = "ARCustomerPayments";
            this.fld_lkeFK_CSCompanyBankID.BOSDescription = null;
            this.fld_lkeFK_CSCompanyBankID.BOSError = null;
            this.fld_lkeFK_CSCompanyBankID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_CSCompanyBankID.BOSFieldParent = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_CSCompanyBankID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_CSCompanyBankID.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_CSCompanyBankID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_CSCompanyBankID.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_CSCompanyBankID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_CSCompanyBankID.CurrentDisplayText = null;
            this.fld_lkeFK_CSCompanyBankID.Location = new System.Drawing.Point(473, 36);
            this.fld_lkeFK_CSCompanyBankID.Name = "fld_lkeFK_CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_CSCompanyBankID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_CSCompanyBankID.Properties.DisplayMember = "CSCompanyBankName";
            this.fld_lkeFK_CSCompanyBankID.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_CSCompanyBankID.Properties.PopupWidth = 40;
            this.fld_lkeFK_CSCompanyBankID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_CSCompanyBankID.Properties.ValueMember = "CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.Screen = null;
            this.fld_lkeFK_CSCompanyBankID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_CSCompanyBankID.TabIndex = 4;
            this.fld_lkeFK_CSCompanyBankID.Tag = "DC";
            this.fld_lkeFK_CSCompanyBankID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_CSCompanyBankID_CloseUp);
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
            this.bosTabControl1.Location = new System.Drawing.Point(3, 130);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(891, 284);
            this.bosTabControl1.TabIndex = 19;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.bosGroupControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(884, 255);
            this.xtraTabPage1.Text = "Hóa đơn thanh toán";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcDocumentEntrys);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(884, 255);
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
            this.fld_dgcDocumentEntrys.Size = new System.Drawing.Size(884, 255);
            this.fld_dgcDocumentEntrys.TabIndex = 0;
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.fld_dgcCustomerPaymentDetails);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 420);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(893, 170);
            this.bosGroupControl2.TabIndex = 20;
            this.bosGroupControl2.Text = "Thông tin thanh toán";
            // 
            // fld_dgcCustomerPaymentDetails
            // 
            this.fld_dgcCustomerPaymentDetails.AllowMultiplePayment = false;
            this.fld_dgcCustomerPaymentDetails.AllowPaymentByCurrency = false;
            this.fld_dgcCustomerPaymentDetails.BOSComment = null;
            this.fld_dgcCustomerPaymentDetails.BOSDataMember = null;
            this.fld_dgcCustomerPaymentDetails.BOSDataSource = "ARCustomerPaymentDetails";
            this.fld_dgcCustomerPaymentDetails.BOSDescription = null;
            this.fld_dgcCustomerPaymentDetails.BOSError = null;
            this.fld_dgcCustomerPaymentDetails.BOSFieldGroup = null;
            this.fld_dgcCustomerPaymentDetails.BOSFieldRelation = null;
            this.fld_dgcCustomerPaymentDetails.BOSGridType = null;
            this.fld_dgcCustomerPaymentDetails.BOSPrivilege = null;
            this.fld_dgcCustomerPaymentDetails.BOSPropertyName = null;
            this.fld_dgcCustomerPaymentDetails.CustomerPaymentDetailList = null;
            this.fld_dgcCustomerPaymentDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcCustomerPaymentDetails.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcCustomerPaymentDetails.MenuManager = this.screenToolbar;
            this.fld_dgcCustomerPaymentDetails.Name = "fld_dgcCustomerPaymentDetails";
            this.fld_dgcCustomerPaymentDetails.PaymentAmount = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.fld_dgcCustomerPaymentDetails.PrintReport = false;
            this.fld_dgcCustomerPaymentDetails.RequiredMethod = null;
            this.fld_dgcCustomerPaymentDetails.Screen = null;
            this.fld_dgcCustomerPaymentDetails.Size = new System.Drawing.Size(889, 146);
            this.fld_dgcCustomerPaymentDetails.TabIndex = 0;
            this.fld_dgcCustomerPaymentDetails.Tag = "DC";
            // 
            // fld_txtARCustomerPaymentTotalAmount
            // 
            this.fld_txtARCustomerPaymentTotalAmount.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARCustomerPaymentTotalAmount.BOSDataMember = "ARCustomerPaymentTotalAmount";
            this.fld_txtARCustomerPaymentTotalAmount.BOSDataSource = "ARCustomerPayments";
            this.fld_txtARCustomerPaymentTotalAmount.BOSDescription = null;
            this.fld_txtARCustomerPaymentTotalAmount.BOSError = null;
            this.fld_txtARCustomerPaymentTotalAmount.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARCustomerPaymentTotalAmount.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARCustomerPaymentTotalAmount.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARCustomerPaymentTotalAmount.BOSPropertyName = "Text";
            this.fld_txtARCustomerPaymentTotalAmount.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARCustomerPaymentTotalAmount.Location = new System.Drawing.Point(210, 62);
            this.fld_txtARCustomerPaymentTotalAmount.Name = "fld_txtARCustomerPaymentTotalAmount";
            this.fld_txtARCustomerPaymentTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARCustomerPaymentTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerPaymentTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerPaymentTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerPaymentTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARCustomerPaymentTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARCustomerPaymentTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerPaymentTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARCustomerPaymentTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerPaymentTotalAmount.Screen = null;
            this.fld_txtARCustomerPaymentTotalAmount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARCustomerPaymentTotalAmount.TabIndex = 6;
            this.fld_txtARCustomerPaymentTotalAmount.Tag = "DC";
            this.fld_txtARCustomerPaymentTotalAmount.Validated += new System.EventHandler(this.fld_txtARCustomerPaymentTotalAmount_Validated);
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.Location = new System.Drawing.Point(121, 65);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(76, 13);
            this.bosLabel1.TabIndex = 7;
            this.bosLabel1.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.Text = "Tiền thanh toán";
            // 
            // DMCR100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(899, 590);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMCR100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCustomerPaymentDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCustomerPaymentDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARCustomerPaymentDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARCustomerPaymentEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcInvoices)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCashFundID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentBankAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyBankID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCustomerPaymentDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentTotalAmount.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPictureEdit fld_pteARCustomerPaymentEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSPanel bosPanel1;
        private InvoiceGridControl fld_dgcInvoices;
        private BOSComponent.BOSButton fld_btnChooseOwingInvoices;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtARCustomerPaymentTotalAmount;
        private BOSComponent.BOSGroupControl bosGroupControl2;        
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DocumentEntryGridControl fld_dgcDocumentEntrys;
        private BOSComponent.BOSTextBox fld_txtARCustomerPaymentBankAccount;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_CSCompanyBankID;
        private ARCustomerPaymentDetailsGridControl fld_dgcCustomerPaymentDetails;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLookupEdit fld_lkeFK_CSCashFundID;
        private BOSComponent.BOSLabel bosLabel2;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
	}
}
