using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PaymentVoucher.UI
{
	/// <summary>
	/// Summary description for DMPMVC100
	/// </summary>
	partial class DMPMVC100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPMVC100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_PMProjectID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPPaymentVoucherStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_CSCashFundID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACLoanReceiptID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPPaymentVoucherType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACSegmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPPaymentVoucherAddress = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteAPPaymentVoucherEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_txtAPPaymentVoucherExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPPaymentVoucherReceiverName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPPaymentVoucherNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteAPPaymentVoucherDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medAPPaymentVoucherDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosPanel4 = new BOSComponent.BOSPanel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcAPPaymentVoucherItems = new BOSERP.Modules.PaymentVoucher.APPaymentVoucherItemsGridControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.Modules.PaymentVoucher.UI.ACDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_CSCompanyBankID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPPaymentVoucherBankAccount = new BOSComponent.BOSTextBox(this.components);
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPaymentVoucherStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCashFundID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACLoanReceiptID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPaymentVoucherType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentVoucherAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPPaymentVoucherEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentVoucherExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentVoucherReceiverName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentVoucherNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPaymentVoucherDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPaymentVoucherDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPPaymentVoucherDesc.Properties)).BeginInit();
            this.bosPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPaymentVoucherItems)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyBankID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentVoucherBankAccount.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_PMProjectID);
            this.bosPanel1.Controls.Add(this.bosLabel16);
            this.bosPanel1.Controls.Add(this.fld_lkeAPPaymentVoucherStatus);
            this.bosPanel1.Controls.Add(this.bosLabel15);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_CSCashFundID);
            this.bosPanel1.Controls.Add(this.bosLabel14);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACLoanReceiptID);
            this.bosPanel1.Controls.Add(this.bosLabel13);
            this.bosPanel1.Controls.Add(this.fld_lkeAPPaymentVoucherType);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACSegmentID);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_txtAPPaymentVoucherAddress);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_pteAPPaymentVoucherEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_txtAPPaymentVoucherExchangeRate);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.fld_lblLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lblLabel4);
            this.bosPanel1.Controls.Add(this.fld_lblLabel6);
            this.bosPanel1.Controls.Add(this.fld_txtAPPaymentVoucherReceiverName);
            this.bosPanel1.Controls.Add(this.fld_txtAPPaymentVoucherNo1);
            this.bosPanel1.Controls.Add(this.fld_dteAPPaymentVoucherDate);
            this.bosPanel1.Controls.Add(this.fld_medAPPaymentVoucherDesc);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1309, 138);
            this.bosPanel1.TabIndex = 7;
            // 
            // fld_lkeFK_PMProjectID
            // 
            this.fld_lkeFK_PMProjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_PMProjectID.BOSAllowDummy = true;
            this.fld_lkeFK_PMProjectID.BOSComment = "";
            this.fld_lkeFK_PMProjectID.BOSDataMember = "FK_PMProjectID";
            this.fld_lkeFK_PMProjectID.BOSDataSource = "APPaymentVouchers";
            this.fld_lkeFK_PMProjectID.BOSDescription = null;
            this.fld_lkeFK_PMProjectID.BOSError = null;
            this.fld_lkeFK_PMProjectID.BOSFieldGroup = "";
            this.fld_lkeFK_PMProjectID.BOSFieldParent = "";
            this.fld_lkeFK_PMProjectID.BOSFieldRelation = "";
            this.fld_lkeFK_PMProjectID.BOSPrivilege = "";
            this.fld_lkeFK_PMProjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_PMProjectID.BOSSelectType = "";
            this.fld_lkeFK_PMProjectID.BOSSelectTypeValue = "";
            this.fld_lkeFK_PMProjectID.CurrentDisplayText = null;
            this.fld_lkeFK_PMProjectID.Location = new System.Drawing.Point(737, 64);
            this.fld_lkeFK_PMProjectID.Name = "fld_lkeFK_PMProjectID";
            this.fld_lkeFK_PMProjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_PMProjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_PMProjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_PMProjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_PMProjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_PMProjectID.Properties.ColumnName = null;
            this.fld_lkeFK_PMProjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectNo", "Mã dự án"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectName", "Tên dự án")});
            this.fld_lkeFK_PMProjectID.Properties.DisplayMember = "PMProjectNo";
            this.fld_lkeFK_PMProjectID.Properties.NullText = "";
            this.fld_lkeFK_PMProjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_PMProjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_PMProjectID.Properties.ValueMember = "PMProjectID";
            this.fld_lkeFK_PMProjectID.Screen = null;
            this.fld_lkeFK_PMProjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_PMProjectID.TabIndex = 9;
            this.fld_lkeFK_PMProjectID.Tag = "DC";
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
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(651, 67);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(45, 13);
            this.bosLabel16.TabIndex = 109;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "Mã dự án";
            // 
            // fld_lkeAPPaymentVoucherStatus
            // 
            this.fld_lkeAPPaymentVoucherStatus.BOSAllowAddNew = false;
            this.fld_lkeAPPaymentVoucherStatus.BOSAllowDummy = false;
            this.fld_lkeAPPaymentVoucherStatus.BOSComment = "";
            this.fld_lkeAPPaymentVoucherStatus.BOSDataMember = "APPaymentVoucherStatus";
            this.fld_lkeAPPaymentVoucherStatus.BOSDataSource = "APPaymentVouchers";
            this.fld_lkeAPPaymentVoucherStatus.BOSDescription = null;
            this.fld_lkeAPPaymentVoucherStatus.BOSError = null;
            this.fld_lkeAPPaymentVoucherStatus.BOSFieldGroup = "";
            this.fld_lkeAPPaymentVoucherStatus.BOSFieldParent = "";
            this.fld_lkeAPPaymentVoucherStatus.BOSFieldRelation = "";
            this.fld_lkeAPPaymentVoucherStatus.BOSPrivilege = "";
            this.fld_lkeAPPaymentVoucherStatus.BOSPropertyName = "EditValue";
            this.fld_lkeAPPaymentVoucherStatus.BOSSelectType = "";
            this.fld_lkeAPPaymentVoucherStatus.BOSSelectTypeValue = "";
            this.fld_lkeAPPaymentVoucherStatus.CurrentDisplayText = null;
            this.fld_lkeAPPaymentVoucherStatus.Location = new System.Drawing.Point(1013, 90);
            this.fld_lkeAPPaymentVoucherStatus.Name = "fld_lkeAPPaymentVoucherStatus";
            this.fld_lkeAPPaymentVoucherStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeAPPaymentVoucherStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPPaymentVoucherStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPPaymentVoucherStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPPaymentVoucherStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPaymentVoucherStatus.Properties.ColumnName = null;
            this.fld_lkeAPPaymentVoucherStatus.Properties.NullText = "";
            this.fld_lkeAPPaymentVoucherStatus.Properties.PopupWidth = 40;
            this.fld_lkeAPPaymentVoucherStatus.Properties.ReadOnly = true;
            this.fld_lkeAPPaymentVoucherStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPPaymentVoucherStatus.Screen = null;
            this.fld_lkeAPPaymentVoucherStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPPaymentVoucherStatus.TabIndex = 13;
            this.fld_lkeAPPaymentVoucherStatus.Tag = "DC";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel15.Location = new System.Drawing.Point(915, 93);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(49, 13);
            this.bosLabel15.TabIndex = 107;
            this.bosLabel15.Tag = "";
            this.bosLabel15.Text = "Tình trạng";
            // 
            // fld_lkeFK_CSCashFundID
            // 
            this.fld_lkeFK_CSCashFundID.BOSAllowAddNew = false;
            this.fld_lkeFK_CSCashFundID.BOSAllowDummy = false;
            this.fld_lkeFK_CSCashFundID.BOSComment = "";
            this.fld_lkeFK_CSCashFundID.BOSDataMember = "FK_CSCashFundID";
            this.fld_lkeFK_CSCashFundID.BOSDataSource = "APPaymentVouchers";
            this.fld_lkeFK_CSCashFundID.BOSDescription = null;
            this.fld_lkeFK_CSCashFundID.BOSError = null;
            this.fld_lkeFK_CSCashFundID.BOSFieldGroup = "";
            this.fld_lkeFK_CSCashFundID.BOSFieldParent = "";
            this.fld_lkeFK_CSCashFundID.BOSFieldRelation = "";
            this.fld_lkeFK_CSCashFundID.BOSPrivilege = "";
            this.fld_lkeFK_CSCashFundID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_CSCashFundID.BOSSelectType = "";
            this.fld_lkeFK_CSCashFundID.BOSSelectTypeValue = "";
            this.fld_lkeFK_CSCashFundID.CurrentDisplayText = null;
            this.fld_lkeFK_CSCashFundID.Location = new System.Drawing.Point(737, 90);
            this.fld_lkeFK_CSCashFundID.Name = "fld_lkeFK_CSCashFundID";
            this.fld_lkeFK_CSCashFundID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_CSCashFundID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_CSCashFundID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_CSCashFundID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_CSCashFundID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_CSCashFundID.Properties.ColumnName = null;
            this.fld_lkeFK_CSCashFundID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCashFundNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCashFundName", "Tên quỹ tiền mặt")});
            this.fld_lkeFK_CSCashFundID.Properties.DisplayMember = "CSCashFundName";
            this.fld_lkeFK_CSCashFundID.Properties.NullText = "";
            this.fld_lkeFK_CSCashFundID.Properties.PopupWidth = 40;
            this.fld_lkeFK_CSCashFundID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_CSCashFundID.Properties.ValueMember = "CSCashFundID";
            this.fld_lkeFK_CSCashFundID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_CSCashFundID, true);
            this.fld_lkeFK_CSCashFundID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_CSCashFundID.TabIndex = 12;
            this.fld_lkeFK_CSCashFundID.Tag = "DC";
            this.fld_lkeFK_CSCashFundID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_CSCashFundID_CloseUp);
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel14.BOSPropertyName = "";
            this.bosLabel14.Location = new System.Drawing.Point(651, 93);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(62, 13);
            this.bosLabel14.TabIndex = 105;
            this.bosLabel14.Tag = "";
            this.bosLabel14.Text = "Quỹ tiền mặt";
            // 
            // fld_lkeFK_ACLoanReceiptID
            // 
            this.fld_lkeFK_ACLoanReceiptID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACLoanReceiptID.BOSAllowDummy = true;
            this.fld_lkeFK_ACLoanReceiptID.BOSComment = "";
            this.fld_lkeFK_ACLoanReceiptID.BOSDataMember = "FK_ACLoanReceiptID";
            this.fld_lkeFK_ACLoanReceiptID.BOSDataSource = "APPaymentVouchers";
            this.fld_lkeFK_ACLoanReceiptID.BOSDescription = null;
            this.fld_lkeFK_ACLoanReceiptID.BOSError = null;
            this.fld_lkeFK_ACLoanReceiptID.BOSFieldGroup = "";
            this.fld_lkeFK_ACLoanReceiptID.BOSFieldParent = "";
            this.fld_lkeFK_ACLoanReceiptID.BOSFieldRelation = "";
            this.fld_lkeFK_ACLoanReceiptID.BOSPrivilege = "";
            this.fld_lkeFK_ACLoanReceiptID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACLoanReceiptID.BOSSelectType = "";
            this.fld_lkeFK_ACLoanReceiptID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACLoanReceiptID.CurrentDisplayText = null;
            this.fld_lkeFK_ACLoanReceiptID.Location = new System.Drawing.Point(1013, 64);
            this.fld_lkeFK_ACLoanReceiptID.Name = "fld_lkeFK_ACLoanReceiptID";
            this.fld_lkeFK_ACLoanReceiptID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACLoanReceiptID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACLoanReceiptID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACLoanReceiptID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACLoanReceiptID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACLoanReceiptID.Properties.ColumnName = null;
            this.fld_lkeFK_ACLoanReceiptID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACLoanReceiptNo", "Mã")});
            this.fld_lkeFK_ACLoanReceiptID.Properties.DisplayMember = "ACLoanReceiptNo";
            this.fld_lkeFK_ACLoanReceiptID.Properties.NullText = "";
            this.fld_lkeFK_ACLoanReceiptID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACLoanReceiptID.Properties.ValueMember = "ACLoanReceiptID";
            this.fld_lkeFK_ACLoanReceiptID.Screen = null;
            this.fld_lkeFK_ACLoanReceiptID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACLoanReceiptID.TabIndex = 10;
            this.fld_lkeFK_ACLoanReceiptID.Tag = "DC";
            this.fld_lkeFK_ACLoanReceiptID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACLoanReceiptID_CloseUp);
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
            this.bosLabel13.Location = new System.Drawing.Point(915, 67);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(60, 13);
            this.bosLabel13.TabIndex = 94;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "Khế ước vay";
            // 
            // fld_lkeAPPaymentVoucherType
            // 
            this.fld_lkeAPPaymentVoucherType.BOSAllowAddNew = false;
            this.fld_lkeAPPaymentVoucherType.BOSAllowDummy = true;
            this.fld_lkeAPPaymentVoucherType.BOSComment = null;
            this.fld_lkeAPPaymentVoucherType.BOSDataMember = "APPaymentVoucherType";
            this.fld_lkeAPPaymentVoucherType.BOSDataSource = "APPaymentVouchers";
            this.fld_lkeAPPaymentVoucherType.BOSDescription = null;
            this.fld_lkeAPPaymentVoucherType.BOSError = null;
            this.fld_lkeAPPaymentVoucherType.BOSFieldGroup = null;
            this.fld_lkeAPPaymentVoucherType.BOSFieldParent = null;
            this.fld_lkeAPPaymentVoucherType.BOSFieldRelation = null;
            this.fld_lkeAPPaymentVoucherType.BOSPrivilege = null;
            this.fld_lkeAPPaymentVoucherType.BOSPropertyName = "EditValue";
            this.fld_lkeAPPaymentVoucherType.BOSSelectType = null;
            this.fld_lkeAPPaymentVoucherType.BOSSelectTypeValue = null;
            this.fld_lkeAPPaymentVoucherType.CurrentDisplayText = null;
            this.fld_lkeAPPaymentVoucherType.Location = new System.Drawing.Point(737, 12);
            this.fld_lkeAPPaymentVoucherType.MenuManager = this.screenToolbar;
            this.fld_lkeAPPaymentVoucherType.Name = "fld_lkeAPPaymentVoucherType";
            this.fld_lkeAPPaymentVoucherType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPaymentVoucherType.Properties.ColumnName = null;
            this.fld_lkeAPPaymentVoucherType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeAPPaymentVoucherType, true);
            this.fld_lkeAPPaymentVoucherType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPPaymentVoucherType.TabIndex = 2;
            this.fld_lkeAPPaymentVoucherType.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = "";
            this.bosLabel9.BOSDataMember = "";
            this.bosLabel9.BOSDataSource = "";
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = "";
            this.bosLabel9.BOSFieldRelation = "";
            this.bosLabel9.BOSPrivilege = "";
            this.bosLabel9.BOSPropertyName = "";
            this.bosLabel9.Location = new System.Drawing.Point(651, 15);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, true);
            this.bosLabel9.Size = new System.Drawing.Size(66, 13);
            this.bosLabel9.TabIndex = 45;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Loại chứng từ";
            // 
            // fld_lkeFK_ACSegmentID
            // 
            this.fld_lkeFK_ACSegmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACSegmentID.BOSAllowDummy = true;
            this.fld_lkeFK_ACSegmentID.BOSComment = "";
            this.fld_lkeFK_ACSegmentID.BOSDataMember = "FK_ACSegmentID";
            this.fld_lkeFK_ACSegmentID.BOSDataSource = "APPaymentVouchers";
            this.fld_lkeFK_ACSegmentID.BOSDescription = null;
            this.fld_lkeFK_ACSegmentID.BOSError = null;
            this.fld_lkeFK_ACSegmentID.BOSFieldGroup = "";
            this.fld_lkeFK_ACSegmentID.BOSFieldParent = "";
            this.fld_lkeFK_ACSegmentID.BOSFieldRelation = "";
            this.fld_lkeFK_ACSegmentID.BOSPrivilege = "";
            this.fld_lkeFK_ACSegmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACSegmentID.BOSSelectType = "";
            this.fld_lkeFK_ACSegmentID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACSegmentID.CurrentDisplayText = null;
            this.fld_lkeFK_ACSegmentID.Location = new System.Drawing.Point(1013, 12);
            this.fld_lkeFK_ACSegmentID.Name = "fld_lkeFK_ACSegmentID";
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACSegmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACSegmentID.Properties.ColumnName = null;
            this.fld_lkeFK_ACSegmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACSegmentName", "Khoản mục chi phí")});
            this.fld_lkeFK_ACSegmentID.Properties.DisplayMember = "ACSegmentName";
            this.fld_lkeFK_ACSegmentID.Properties.NullText = "";
            this.fld_lkeFK_ACSegmentID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACSegmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACSegmentID.Properties.ValueMember = "ACSegmentID";
            this.fld_lkeFK_ACSegmentID.Screen = null;
            this.fld_lkeFK_ACSegmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACSegmentID.TabIndex = 3;
            this.fld_lkeFK_ACSegmentID.Tag = "DC";
            this.fld_lkeFK_ACSegmentID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACSegmentID_CloseUp);
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel1.BOSPropertyName = "";
            this.bosLabel1.Location = new System.Drawing.Point(915, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(85, 13);
            this.bosLabel1.TabIndex = 42;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Khoản mục chi phí";
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
            this.bosLabel7.Location = new System.Drawing.Point(120, 67);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(32, 13);
            this.bosLabel7.TabIndex = 21;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Địa chỉ";
            // 
            // fld_txtAPPaymentVoucherAddress
            // 
            this.fld_txtAPPaymentVoucherAddress.BOSComment = "";
            this.fld_txtAPPaymentVoucherAddress.BOSDataMember = "APPaymentVoucherAddress";
            this.fld_txtAPPaymentVoucherAddress.BOSDataSource = "APPaymentVouchers";
            this.fld_txtAPPaymentVoucherAddress.BOSDescription = null;
            this.fld_txtAPPaymentVoucherAddress.BOSError = null;
            this.fld_txtAPPaymentVoucherAddress.BOSFieldGroup = "";
            this.fld_txtAPPaymentVoucherAddress.BOSFieldRelation = "";
            this.fld_txtAPPaymentVoucherAddress.BOSPrivilege = "";
            this.fld_txtAPPaymentVoucherAddress.BOSPropertyName = "Text";
            this.fld_txtAPPaymentVoucherAddress.EditValue = "";
            this.fld_txtAPPaymentVoucherAddress.Location = new System.Drawing.Point(203, 64);
            this.fld_txtAPPaymentVoucherAddress.Name = "fld_txtAPPaymentVoucherAddress";
            this.fld_txtAPPaymentVoucherAddress.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPaymentVoucherAddress.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPaymentVoucherAddress.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPaymentVoucherAddress.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPaymentVoucherAddress.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPaymentVoucherAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPaymentVoucherAddress.Screen = null;
            this.fld_txtAPPaymentVoucherAddress.Size = new System.Drawing.Size(414, 20);
            this.fld_txtAPPaymentVoucherAddress.TabIndex = 8;
            this.fld_txtAPPaymentVoucherAddress.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "APPaymentVouchers";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 101);
            this.fld_lkeFK_HREmployeeID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 0;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_pteAPPaymentVoucherEmployeePicture
            // 
            this.fld_pteAPPaymentVoucherEmployeePicture.BOSComment = null;
            this.fld_pteAPPaymentVoucherEmployeePicture.BOSDataMember = "APPaymentVoucherEmployeePicture";
            this.fld_pteAPPaymentVoucherEmployeePicture.BOSDataSource = "APPaymentVouchers";
            this.fld_pteAPPaymentVoucherEmployeePicture.BOSDescription = null;
            this.fld_pteAPPaymentVoucherEmployeePicture.BOSError = null;
            this.fld_pteAPPaymentVoucherEmployeePicture.BOSFieldGroup = null;
            this.fld_pteAPPaymentVoucherEmployeePicture.BOSFieldRelation = null;
            this.fld_pteAPPaymentVoucherEmployeePicture.BOSPrivilege = null;
            this.fld_pteAPPaymentVoucherEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteAPPaymentVoucherEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteAPPaymentVoucherEmployeePicture.FileName = null;
            this.fld_pteAPPaymentVoucherEmployeePicture.FilePath = null;
            this.fld_pteAPPaymentVoucherEmployeePicture.Location = new System.Drawing.Point(3, 3);
            this.fld_pteAPPaymentVoucherEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteAPPaymentVoucherEmployeePicture.Name = "fld_pteAPPaymentVoucherEmployeePicture";
            this.fld_pteAPPaymentVoucherEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteAPPaymentVoucherEmployeePicture.Screen = null;
            this.fld_pteAPPaymentVoucherEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteAPPaymentVoucherEmployeePicture.TabIndex = 0;
            this.fld_pteAPPaymentVoucherEmployeePicture.Tag = "DC";
            // 
            // fld_txtAPPaymentVoucherExchangeRate
            // 
            this.fld_txtAPPaymentVoucherExchangeRate.BOSComment = "";
            this.fld_txtAPPaymentVoucherExchangeRate.BOSDataMember = "APPaymentVoucherExchangeRate";
            this.fld_txtAPPaymentVoucherExchangeRate.BOSDataSource = "APPaymentVouchers";
            this.fld_txtAPPaymentVoucherExchangeRate.BOSDescription = null;
            this.fld_txtAPPaymentVoucherExchangeRate.BOSError = null;
            this.fld_txtAPPaymentVoucherExchangeRate.BOSFieldGroup = "";
            this.fld_txtAPPaymentVoucherExchangeRate.BOSFieldRelation = "";
            this.fld_txtAPPaymentVoucherExchangeRate.BOSPrivilege = "";
            this.fld_txtAPPaymentVoucherExchangeRate.BOSPropertyName = "Text";
            this.fld_txtAPPaymentVoucherExchangeRate.EditValue = "";
            this.fld_txtAPPaymentVoucherExchangeRate.Location = new System.Drawing.Point(1013, 38);
            this.fld_txtAPPaymentVoucherExchangeRate.Name = "fld_txtAPPaymentVoucherExchangeRate";
            this.fld_txtAPPaymentVoucherExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPaymentVoucherExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPaymentVoucherExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPaymentVoucherExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPaymentVoucherExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPaymentVoucherExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPaymentVoucherExchangeRate.Screen = null;
            this.fld_txtAPPaymentVoucherExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPPaymentVoucherExchangeRate.TabIndex = 7;
            this.fld_txtAPPaymentVoucherExchangeRate.Tag = "DC";
            this.fld_txtAPPaymentVoucherExchangeRate.Validated += new System.EventHandler(this.fld_txtAPPaymentVoucherExchangeRate_Validated);
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
            this.bosLabel4.BOSPropertyName = "";
            this.bosLabel4.Location = new System.Drawing.Point(915, 41);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(29, 13);
            this.bosLabel4.TabIndex = 10;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Tỷ giá";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(120, 41);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel5.TabIndex = 6;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Đối tượng";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "APPaymentVouchers";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(203, 38);
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
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = "";
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 4;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel2.Location = new System.Drawing.Point(651, 41);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(53, 13);
            this.bosLabel2.TabIndex = 8;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Loại tiền tệ";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = "";
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "APPaymentVouchers";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(737, 38);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
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
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = "";
            this.fld_lblLabel2.BOSDataMember = "";
            this.fld_lblLabel2.BOSDataSource = "";
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = "";
            this.fld_lblLabel2.BOSFieldRelation = "";
            this.fld_lblLabel2.BOSPrivilege = "";
            this.fld_lblLabel2.BOSPropertyName = "";
            this.fld_lblLabel2.Location = new System.Drawing.Point(120, 15);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel2.TabIndex = 0;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Mã chứng từ";
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
            this.bosLabel3.Location = new System.Drawing.Point(379, 41);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(76, 13);
            this.bosLabel3.TabIndex = 2;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Người nhận tiền";
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
            this.fld_lblLabel4.BOSPropertyName = "";
            this.fld_lblLabel4.Location = new System.Drawing.Point(379, 15);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel4.TabIndex = 2;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Ngày chứng từ";
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
            this.fld_lblLabel6.Location = new System.Drawing.Point(120, 93);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel6.TabIndex = 16;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Diễn giải";
            // 
            // fld_txtAPPaymentVoucherReceiverName
            // 
            this.fld_txtAPPaymentVoucherReceiverName.BOSComment = "";
            this.fld_txtAPPaymentVoucherReceiverName.BOSDataMember = "APPaymentVoucherReceiverName";
            this.fld_txtAPPaymentVoucherReceiverName.BOSDataSource = "APPaymentVouchers";
            this.fld_txtAPPaymentVoucherReceiverName.BOSDescription = null;
            this.fld_txtAPPaymentVoucherReceiverName.BOSError = null;
            this.fld_txtAPPaymentVoucherReceiverName.BOSFieldGroup = "";
            this.fld_txtAPPaymentVoucherReceiverName.BOSFieldRelation = "";
            this.fld_txtAPPaymentVoucherReceiverName.BOSPrivilege = "";
            this.fld_txtAPPaymentVoucherReceiverName.BOSPropertyName = "Text";
            this.fld_txtAPPaymentVoucherReceiverName.EditValue = "";
            this.fld_txtAPPaymentVoucherReceiverName.Location = new System.Drawing.Point(467, 38);
            this.fld_txtAPPaymentVoucherReceiverName.Name = "fld_txtAPPaymentVoucherReceiverName";
            this.fld_txtAPPaymentVoucherReceiverName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPaymentVoucherReceiverName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPaymentVoucherReceiverName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPaymentVoucherReceiverName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPaymentVoucherReceiverName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPaymentVoucherReceiverName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPaymentVoucherReceiverName.Screen = null;
            this.fld_txtAPPaymentVoucherReceiverName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPPaymentVoucherReceiverName.TabIndex = 5;
            this.fld_txtAPPaymentVoucherReceiverName.Tag = "DC";
            // 
            // fld_txtAPPaymentVoucherNo1
            // 
            this.fld_txtAPPaymentVoucherNo1.BOSComment = "";
            this.fld_txtAPPaymentVoucherNo1.BOSDataMember = "APPaymentVoucherNo";
            this.fld_txtAPPaymentVoucherNo1.BOSDataSource = "APPaymentVouchers";
            this.fld_txtAPPaymentVoucherNo1.BOSDescription = null;
            this.fld_txtAPPaymentVoucherNo1.BOSError = null;
            this.fld_txtAPPaymentVoucherNo1.BOSFieldGroup = "";
            this.fld_txtAPPaymentVoucherNo1.BOSFieldRelation = "";
            this.fld_txtAPPaymentVoucherNo1.BOSPrivilege = "";
            this.fld_txtAPPaymentVoucherNo1.BOSPropertyName = "Text";
            this.fld_txtAPPaymentVoucherNo1.EditValue = "";
            this.fld_txtAPPaymentVoucherNo1.Location = new System.Drawing.Point(203, 12);
            this.fld_txtAPPaymentVoucherNo1.Name = "fld_txtAPPaymentVoucherNo1";
            this.fld_txtAPPaymentVoucherNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPaymentVoucherNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPaymentVoucherNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPaymentVoucherNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPaymentVoucherNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPaymentVoucherNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPaymentVoucherNo1.Screen = null;
            this.fld_txtAPPaymentVoucherNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPPaymentVoucherNo1.TabIndex = 0;
            this.fld_txtAPPaymentVoucherNo1.Tag = "DC";
            // 
            // fld_dteAPPaymentVoucherDate
            // 
            this.fld_dteAPPaymentVoucherDate.BOSComment = "";
            this.fld_dteAPPaymentVoucherDate.BOSDataMember = "APPaymentVoucherDate";
            this.fld_dteAPPaymentVoucherDate.BOSDataSource = "APPaymentVouchers";
            this.fld_dteAPPaymentVoucherDate.BOSDescription = null;
            this.fld_dteAPPaymentVoucherDate.BOSError = null;
            this.fld_dteAPPaymentVoucherDate.BOSFieldGroup = "";
            this.fld_dteAPPaymentVoucherDate.BOSFieldRelation = "";
            this.fld_dteAPPaymentVoucherDate.BOSPrivilege = "";
            this.fld_dteAPPaymentVoucherDate.BOSPropertyName = "EditValue";
            this.fld_dteAPPaymentVoucherDate.EditValue = null;
            this.fld_dteAPPaymentVoucherDate.Location = new System.Drawing.Point(467, 12);
            this.fld_dteAPPaymentVoucherDate.Name = "fld_dteAPPaymentVoucherDate";
            this.fld_dteAPPaymentVoucherDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPPaymentVoucherDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPPaymentVoucherDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPPaymentVoucherDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPPaymentVoucherDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPPaymentVoucherDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPPaymentVoucherDate.Screen = null;
            this.fld_dteAPPaymentVoucherDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteAPPaymentVoucherDate.TabIndex = 1;
            this.fld_dteAPPaymentVoucherDate.Tag = "DC";
            // 
            // fld_medAPPaymentVoucherDesc
            // 
            this.fld_medAPPaymentVoucherDesc.BOSComment = "";
            this.fld_medAPPaymentVoucherDesc.BOSDataMember = "APPaymentVoucherDesc";
            this.fld_medAPPaymentVoucherDesc.BOSDataSource = "APPaymentVouchers";
            this.fld_medAPPaymentVoucherDesc.BOSDescription = null;
            this.fld_medAPPaymentVoucherDesc.BOSError = null;
            this.fld_medAPPaymentVoucherDesc.BOSFieldGroup = "";
            this.fld_medAPPaymentVoucherDesc.BOSFieldRelation = "";
            this.fld_medAPPaymentVoucherDesc.BOSPrivilege = "";
            this.fld_medAPPaymentVoucherDesc.BOSPropertyName = "Text";
            this.fld_medAPPaymentVoucherDesc.EditValue = "";
            this.fld_medAPPaymentVoucherDesc.Location = new System.Drawing.Point(203, 90);
            this.fld_medAPPaymentVoucherDesc.Name = "fld_medAPPaymentVoucherDesc";
            this.fld_medAPPaymentVoucherDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medAPPaymentVoucherDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medAPPaymentVoucherDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medAPPaymentVoucherDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medAPPaymentVoucherDesc.Screen = null;
            this.fld_medAPPaymentVoucherDesc.Size = new System.Drawing.Size(414, 38);
            this.fld_medAPPaymentVoucherDesc.TabIndex = 11;
            this.fld_medAPPaymentVoucherDesc.Tag = "DC";
            this.fld_medAPPaymentVoucherDesc.Validated += new System.EventHandler(this.fld_medAPPaymentVoucherDesc_Validated);
            // 
            // bosPanel4
            // 
            this.bosPanel4.BOSComment = null;
            this.bosPanel4.BOSDataMember = null;
            this.bosPanel4.BOSDataSource = null;
            this.bosPanel4.BOSDescription = null;
            this.bosPanel4.BOSError = null;
            this.bosPanel4.BOSFieldGroup = null;
            this.bosPanel4.BOSFieldRelation = null;
            this.bosPanel4.BOSPrivilege = null;
            this.bosPanel4.BOSPropertyName = null;
            this.bosPanel4.Controls.Add(this.bosTabControl1);
            this.bosPanel4.Controls.Add(this.bosGroupControl1);
            this.bosPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel4.Location = new System.Drawing.Point(0, 138);
            this.bosPanel4.Name = "bosPanel4";
            this.bosPanel4.Screen = null;
            this.bosPanel4.Size = new System.Drawing.Size(1309, 563);
            this.bosPanel4.TabIndex = 9;
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
            this.bosTabControl1.Location = new System.Drawing.Point(0, 6);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.bosTabControl1.Size = new System.Drawing.Size(1301, 553);
            this.bosTabControl1.TabIndex = 23;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcAPPaymentVoucherItems);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1299, 528);
            this.xtraTabPage2.Text = "Danh sách mục chi";
            // 
            // fld_dgcAPPaymentVoucherItems
            // 
            this.fld_dgcAPPaymentVoucherItems.BOSComment = null;
            this.fld_dgcAPPaymentVoucherItems.BOSDataMember = null;
            this.fld_dgcAPPaymentVoucherItems.BOSDataSource = "APPaymentVoucherItems";
            this.fld_dgcAPPaymentVoucherItems.BOSDescription = null;
            this.fld_dgcAPPaymentVoucherItems.BOSError = null;
            this.fld_dgcAPPaymentVoucherItems.BOSFieldGroup = null;
            this.fld_dgcAPPaymentVoucherItems.BOSFieldRelation = null;
            this.fld_dgcAPPaymentVoucherItems.BOSGridType = null;
            this.fld_dgcAPPaymentVoucherItems.BOSPrivilege = null;
            this.fld_dgcAPPaymentVoucherItems.BOSPropertyName = null;
            this.fld_dgcAPPaymentVoucherItems.CommodityType = "";
            this.fld_dgcAPPaymentVoucherItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcAPPaymentVoucherItems.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcAPPaymentVoucherItems.MenuManager = this.screenToolbar;
            this.fld_dgcAPPaymentVoucherItems.Name = "fld_dgcAPPaymentVoucherItems";
            this.fld_dgcAPPaymentVoucherItems.PrintReport = false;
            this.fld_dgcAPPaymentVoucherItems.Screen = null;
            this.fld_dgcAPPaymentVoucherItems.Size = new System.Drawing.Size(1299, 528);
            this.fld_dgcAPPaymentVoucherItems.TabIndex = 2;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1285, 449);
            this.xtraTabPage3.Text = "Hạch toán";
            // 
            // fld_dgcACDocumentEntrys
            // 
            this.fld_dgcACDocumentEntrys.AllowDrop = true;
            this.fld_dgcACDocumentEntrys.BOSComment = "";
            this.fld_dgcACDocumentEntrys.BOSDataMember = "";
            this.fld_dgcACDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.BOSDescription = null;
            this.fld_dgcACDocumentEntrys.BOSError = null;
            this.fld_dgcACDocumentEntrys.BOSFieldGroup = "";
            this.fld_dgcACDocumentEntrys.BOSFieldRelation = "";
            this.fld_dgcACDocumentEntrys.BOSGridType = null;
            this.fld_dgcACDocumentEntrys.BOSPrivilege = "";
            this.fld_dgcACDocumentEntrys.BOSPropertyName = "";
            this.fld_dgcACDocumentEntrys.CommodityType = "";
            this.fld_dgcACDocumentEntrys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACDocumentEntrys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACDocumentEntrys.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACDocumentEntrys.MainView = this.fld_dgvACDocumentEntrys;
            this.fld_dgcACDocumentEntrys.Name = "fld_dgcACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.PrintReport = false;
            this.fld_dgcACDocumentEntrys.Screen = null;
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(1285, 449);
            this.fld_dgcACDocumentEntrys.TabIndex = 1;
            this.fld_dgcACDocumentEntrys.Tag = "DC";
            this.fld_dgcACDocumentEntrys.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvACDocumentEntrys});
            // 
            // fld_dgvACDocumentEntrys
            // 
            this.fld_dgvACDocumentEntrys.GridControl = this.fld_dgcACDocumentEntrys;
            this.fld_dgvACDocumentEntrys.Name = "fld_dgvACDocumentEntrys";
            this.fld_dgvACDocumentEntrys.PaintStyleName = "Office2003";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_CSCompanyBankID);
            this.bosGroupControl1.Controls.Add(this.bosLabel6);
            this.bosGroupControl1.Controls.Add(this.bosLabel5);
            this.bosGroupControl1.Controls.Add(this.fld_txtAPPaymentVoucherBankAccount);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 6);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(1301, 78);
            this.bosGroupControl1.TabIndex = 22;
            this.bosGroupControl1.Text = "Thông tin ngân hàng";
            this.bosGroupControl1.Visible = false;
            // 
            // fld_lkeFK_CSCompanyBankID
            // 
            this.fld_lkeFK_CSCompanyBankID.BOSAllowAddNew = false;
            this.fld_lkeFK_CSCompanyBankID.BOSAllowDummy = true;
            this.fld_lkeFK_CSCompanyBankID.BOSComment = null;
            this.fld_lkeFK_CSCompanyBankID.BOSDataMember = "FK_CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.BOSDataSource = "APPaymentVouchers";
            this.fld_lkeFK_CSCompanyBankID.BOSDescription = null;
            this.fld_lkeFK_CSCompanyBankID.BOSError = null;
            this.fld_lkeFK_CSCompanyBankID.BOSFieldGroup = null;
            this.fld_lkeFK_CSCompanyBankID.BOSFieldParent = null;
            this.fld_lkeFK_CSCompanyBankID.BOSFieldRelation = null;
            this.fld_lkeFK_CSCompanyBankID.BOSPrivilege = null;
            this.fld_lkeFK_CSCompanyBankID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_CSCompanyBankID.BOSSelectType = null;
            this.fld_lkeFK_CSCompanyBankID.BOSSelectTypeValue = null;
            this.fld_lkeFK_CSCompanyBankID.CurrentDisplayText = null;
            this.fld_lkeFK_CSCompanyBankID.Location = new System.Drawing.Point(93, 32);
            this.fld_lkeFK_CSCompanyBankID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_CSCompanyBankID.Name = "fld_lkeFK_CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_CSCompanyBankID.Properties.ColumnName = null;
            this.fld_lkeFK_CSCompanyBankID.Properties.DisplayMember = "CSCompanyBankName";
            this.fld_lkeFK_CSCompanyBankID.Properties.ValueMember = "CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.Screen = null;
            this.fld_lkeFK_CSCompanyBankID.Size = new System.Drawing.Size(296, 20);
            this.fld_lkeFK_CSCompanyBankID.TabIndex = 0;
            this.fld_lkeFK_CSCompanyBankID.Tag = "DC";
            this.fld_lkeFK_CSCompanyBankID.Visible = false;
            this.fld_lkeFK_CSCompanyBankID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_CSCompanyBankID_CloseUp);
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel6.Location = new System.Drawing.Point(426, 35);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(46, 13);
            this.bosLabel6.TabIndex = 11;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Tài khoản";
            this.bosLabel6.Visible = false;
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = "";
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = "";
            this.bosLabel5.BOSPrivilege = "";
            this.bosLabel5.BOSPropertyName = "";
            this.bosLabel5.Location = new System.Drawing.Point(21, 35);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(52, 13);
            this.bosLabel5.TabIndex = 11;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Ngân hàng";
            this.bosLabel5.Visible = false;
            // 
            // fld_txtAPPaymentVoucherBankAccount
            // 
            this.fld_txtAPPaymentVoucherBankAccount.BOSComment = "";
            this.fld_txtAPPaymentVoucherBankAccount.BOSDataMember = "APPaymentVoucherBankAccount";
            this.fld_txtAPPaymentVoucherBankAccount.BOSDataSource = "APPaymentVouchers";
            this.fld_txtAPPaymentVoucherBankAccount.BOSDescription = null;
            this.fld_txtAPPaymentVoucherBankAccount.BOSError = null;
            this.fld_txtAPPaymentVoucherBankAccount.BOSFieldGroup = "";
            this.fld_txtAPPaymentVoucherBankAccount.BOSFieldRelation = "";
            this.fld_txtAPPaymentVoucherBankAccount.BOSPrivilege = "";
            this.fld_txtAPPaymentVoucherBankAccount.BOSPropertyName = "Text";
            this.fld_txtAPPaymentVoucherBankAccount.EditValue = "";
            this.fld_txtAPPaymentVoucherBankAccount.Location = new System.Drawing.Point(496, 32);
            this.fld_txtAPPaymentVoucherBankAccount.Name = "fld_txtAPPaymentVoucherBankAccount";
            this.fld_txtAPPaymentVoucherBankAccount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPaymentVoucherBankAccount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPaymentVoucherBankAccount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPaymentVoucherBankAccount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPaymentVoucherBankAccount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPaymentVoucherBankAccount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPaymentVoucherBankAccount.Screen = null;
            this.fld_txtAPPaymentVoucherBankAccount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPPaymentVoucherBankAccount.TabIndex = 1;
            this.fld_txtAPPaymentVoucherBankAccount.Tag = "DC";
            this.fld_txtAPPaymentVoucherBankAccount.Visible = false;
            // 
            // bosButton2
            // 
            this.bosButton2.BOSComment = null;
            this.bosButton2.BOSDataMember = null;
            this.bosButton2.BOSDataSource = null;
            this.bosButton2.BOSDescription = null;
            this.bosButton2.BOSError = null;
            this.bosButton2.BOSFieldGroup = null;
            this.bosButton2.BOSFieldRelation = null;
            this.bosButton2.BOSPrivilege = null;
            this.bosButton2.BOSPropertyName = null;
            this.bosButton2.Location = new System.Drawing.Point(4, 5);
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosButton2, true);
            this.bosButton2.Size = new System.Drawing.Size(122, 28);
            this.bosButton2.TabIndex = 0;
            this.bosButton2.Text = "Chọn tạm ứng";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1204, 350);
            // 
            // DMPMVC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1309, 701);
            this.Controls.Add(this.bosPanel4);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMPMVC100.IconOptions.Icon")));
            this.Name = "DMPMVC100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.Controls.SetChildIndex(this.bosPanel4, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPaymentVoucherStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCashFundID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACLoanReceiptID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPaymentVoucherType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentVoucherAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPPaymentVoucherEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentVoucherExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentVoucherReceiverName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentVoucherNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPaymentVoucherDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPaymentVoucherDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPPaymentVoucherDesc.Properties)).EndInit();
            this.bosPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPaymentVoucherItems)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyBankID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentVoucherBankAccount.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPanel bosPanel4;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSTextBox fld_txtAPPaymentVoucherNo1;
        private BOSComponent.BOSDateEdit fld_dteAPPaymentVoucherDate;
        private BOSComponent.BOSMemoEdit fld_medAPPaymentVoucherDesc;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtAPPaymentVoucherExchangeRate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteAPPaymentVoucherEmployeePicture;
        private BOSComponent.BOSTextBox fld_txtAPPaymentVoucherReceiverName;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_CSCompanyBankID;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtAPPaymentVoucherBankAccount;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtAPPaymentVoucherAddress;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACSegmentID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeAPPaymentVoucherType;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACLoanReceiptID;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLookupEdit fld_lkeFK_CSCashFundID;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private APPaymentVoucherItemsGridControl fld_dgcAPPaymentVoucherItems;
        private BOSComponent.BOSButton bosButton2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSLookupEdit fld_lkeAPPaymentVoucherStatus;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectID;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private BOSERP.Modules.PaymentVoucher.UI.ACDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
	}
}
