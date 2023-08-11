using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PaymentCash.UI
{
	/// <summary>
	/// Summary description for DMBPC100
	/// </summary>
	partial class DMBPC100
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
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ToCSCashFundID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_CSCashFundID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ToCSCompanyBankID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeACBankTransactionToType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACBankTransactionFromType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACSegmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcACBankTransactionItems = new BOSERP.Modules.PaymentCash.PaymentCashItemGridControl();
            this.fld_dgvACBankTransactionItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtACBankTransactionNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_txtACBankTransactionReceiverIDPlace = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACBankTransactionReceiverName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACBankTransactionReceiverIDNumber = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteACBankTransactionReceiverIDDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACBankTransactionSenderAccount = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteACBankTransactionDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_pteACBankTransactionEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACBankTransactionExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_CSCompanyBankID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_medACBankTransactionDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ToCSCashFundID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCashFundID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ToCSCompanyBankID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACBankTransactionToType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACBankTransactionFromType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl2)).BeginInit();
            this.fld_grcGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACBankTransactionItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACBankTransactionItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionReceiverIDPlace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionReceiverName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionReceiverIDNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBankTransactionReceiverIDDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBankTransactionReceiverIDDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionSenderAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBankTransactionDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBankTransactionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACBankTransactionEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyBankID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACBankTransactionDesc.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ToCSCashFundID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_CSCashFundID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ToCSCompanyBankID);
            this.bosPanel1.Controls.Add(this.fld_lkeACBankTransactionToType);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.fld_lkeACBankTransactionFromType);
            this.bosPanel1.Controls.Add(this.bosLabel14);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACSegmentID);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl2);
            this.bosPanel1.Controls.Add(this.fld_txtACBankTransactionNo);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.fld_txtACBankTransactionSenderAccount);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_dteACBankTransactionDate);
            this.bosPanel1.Controls.Add(this.fld_pteACBankTransactionEmployeePicture);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lblLabel2);
            this.bosPanel1.Controls.Add(this.fld_lblLabel4);
            this.bosPanel1.Controls.Add(this.fld_txtACBankTransactionExchangeRate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel6);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_CSCompanyBankID);
            this.bosPanel1.Controls.Add(this.fld_medACBankTransactionDesc);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(965, 658);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "ACBankTransactionSenderName";
            this.bosTextBox1.BOSDataSource = "ACBankTransactions";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.EditValue = "";
            this.bosTextBox1.Location = new System.Drawing.Point(202, 64);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox1.TabIndex = 7;
            this.bosTextBox1.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(127, 67);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(73, 13);
            this.bosLabel5.TabIndex = 51;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Người giao dịch";
            // 
            // fld_lkeFK_ToCSCashFundID
            // 
            this.fld_lkeFK_ToCSCashFundID.BOSAllowAddNew = false;
            this.fld_lkeFK_ToCSCashFundID.BOSAllowDummy = false;
            this.fld_lkeFK_ToCSCashFundID.BOSComment = "";
            this.fld_lkeFK_ToCSCashFundID.BOSDataMember = "FK_ToCSCashFundID";
            this.fld_lkeFK_ToCSCashFundID.BOSDataSource = "ACBankTransactions";
            this.fld_lkeFK_ToCSCashFundID.BOSDescription = null;
            this.fld_lkeFK_ToCSCashFundID.BOSError = null;
            this.fld_lkeFK_ToCSCashFundID.BOSFieldGroup = "";
            this.fld_lkeFK_ToCSCashFundID.BOSFieldParent = "";
            this.fld_lkeFK_ToCSCashFundID.BOSFieldRelation = "";
            this.fld_lkeFK_ToCSCashFundID.BOSPrivilege = "";
            this.fld_lkeFK_ToCSCashFundID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ToCSCashFundID.BOSSelectType = "";
            this.fld_lkeFK_ToCSCashFundID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ToCSCashFundID.CurrentDisplayText = null;
            this.fld_lkeFK_ToCSCashFundID.Location = new System.Drawing.Point(486, 116);
            this.fld_lkeFK_ToCSCashFundID.Name = "fld_lkeFK_ToCSCashFundID";
            this.fld_lkeFK_ToCSCashFundID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ToCSCashFundID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ToCSCashFundID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ToCSCashFundID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ToCSCashFundID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ToCSCashFundID.Properties.ColumnName = null;
            this.fld_lkeFK_ToCSCashFundID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCashFundNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCashFundName", "Tên")});
            this.fld_lkeFK_ToCSCashFundID.Properties.DisplayMember = "CSCashFundName";
            this.fld_lkeFK_ToCSCashFundID.Properties.NullText = "";
            this.fld_lkeFK_ToCSCashFundID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ToCSCashFundID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ToCSCashFundID.Properties.ValueMember = "CSCashFundID";
            this.fld_lkeFK_ToCSCashFundID.Screen = null;
            this.fld_lkeFK_ToCSCashFundID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ToCSCashFundID.TabIndex = 13;
            this.fld_lkeFK_ToCSCashFundID.Tag = "DC";
            this.fld_lkeFK_ToCSCashFundID.Visible = false;
            this.fld_lkeFK_ToCSCashFundID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ToCSCashFundID_CloseUp);
            // 
            // fld_lkeFK_CSCashFundID
            // 
            this.fld_lkeFK_CSCashFundID.BOSAllowAddNew = false;
            this.fld_lkeFK_CSCashFundID.BOSAllowDummy = false;
            this.fld_lkeFK_CSCashFundID.BOSComment = "";
            this.fld_lkeFK_CSCashFundID.BOSDataMember = "FK_CSCashFundID";
            this.fld_lkeFK_CSCashFundID.BOSDataSource = "ACBankTransactions";
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
            this.fld_lkeFK_CSCashFundID.Location = new System.Drawing.Point(486, 90);
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCashFundName", "Tên")});
            this.fld_lkeFK_CSCashFundID.Properties.DisplayMember = "CSCashFundName";
            this.fld_lkeFK_CSCashFundID.Properties.NullText = "";
            this.fld_lkeFK_CSCashFundID.Properties.PopupWidth = 40;
            this.fld_lkeFK_CSCashFundID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_CSCashFundID.Properties.ValueMember = "CSCashFundID";
            this.fld_lkeFK_CSCashFundID.Screen = null;
            this.fld_lkeFK_CSCashFundID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_CSCashFundID.TabIndex = 10;
            this.fld_lkeFK_CSCashFundID.Tag = "DC";
            this.fld_lkeFK_CSCashFundID.Visible = false;
            this.fld_lkeFK_CSCashFundID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_CSCashFundID_CloseUp);
            // 
            // fld_lkeFK_ToCSCompanyBankID
            // 
            this.fld_lkeFK_ToCSCompanyBankID.BOSAllowAddNew = false;
            this.fld_lkeFK_ToCSCompanyBankID.BOSAllowDummy = false;
            this.fld_lkeFK_ToCSCompanyBankID.BOSComment = "";
            this.fld_lkeFK_ToCSCompanyBankID.BOSDataMember = "FK_ToCSCompanyBankID";
            this.fld_lkeFK_ToCSCompanyBankID.BOSDataSource = "ACBankTransactions";
            this.fld_lkeFK_ToCSCompanyBankID.BOSDescription = null;
            this.fld_lkeFK_ToCSCompanyBankID.BOSError = null;
            this.fld_lkeFK_ToCSCompanyBankID.BOSFieldGroup = "";
            this.fld_lkeFK_ToCSCompanyBankID.BOSFieldParent = "";
            this.fld_lkeFK_ToCSCompanyBankID.BOSFieldRelation = "";
            this.fld_lkeFK_ToCSCompanyBankID.BOSPrivilege = "";
            this.fld_lkeFK_ToCSCompanyBankID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ToCSCompanyBankID.BOSSelectType = "";
            this.fld_lkeFK_ToCSCompanyBankID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ToCSCompanyBankID.CurrentDisplayText = null;
            this.fld_lkeFK_ToCSCompanyBankID.Location = new System.Drawing.Point(486, 116);
            this.fld_lkeFK_ToCSCompanyBankID.Name = "fld_lkeFK_ToCSCompanyBankID";
            this.fld_lkeFK_ToCSCompanyBankID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ToCSCompanyBankID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ToCSCompanyBankID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ToCSCompanyBankID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ToCSCompanyBankID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ToCSCompanyBankID.Properties.ColumnName = null;
            this.fld_lkeFK_ToCSCompanyBankID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCompanyBankCode", "Mã ngân hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCompanyBankName", "Tên ngân hàng")});
            this.fld_lkeFK_ToCSCompanyBankID.Properties.DisplayMember = "CSCompanyBankName";
            this.fld_lkeFK_ToCSCompanyBankID.Properties.NullText = "";
            this.fld_lkeFK_ToCSCompanyBankID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ToCSCompanyBankID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ToCSCompanyBankID.Properties.ValueMember = "CSCompanyBankID";
            this.fld_lkeFK_ToCSCompanyBankID.Screen = null;
            this.fld_lkeFK_ToCSCompanyBankID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ToCSCompanyBankID.TabIndex = 14;
            this.fld_lkeFK_ToCSCompanyBankID.Tag = "DC";
            this.fld_lkeFK_ToCSCompanyBankID.Visible = false;
            this.fld_lkeFK_ToCSCompanyBankID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ToCSCompanyBankID_CloseUp);
            // 
            // fld_lkeACBankTransactionToType
            // 
            this.fld_lkeACBankTransactionToType.BOSAllowAddNew = false;
            this.fld_lkeACBankTransactionToType.BOSAllowDummy = false;
            this.fld_lkeACBankTransactionToType.BOSComment = "";
            this.fld_lkeACBankTransactionToType.BOSDataMember = "ACBankTransactionToType";
            this.fld_lkeACBankTransactionToType.BOSDataSource = "ACBankTransactions";
            this.fld_lkeACBankTransactionToType.BOSDescription = null;
            this.fld_lkeACBankTransactionToType.BOSError = null;
            this.fld_lkeACBankTransactionToType.BOSFieldGroup = "";
            this.fld_lkeACBankTransactionToType.BOSFieldParent = "";
            this.fld_lkeACBankTransactionToType.BOSFieldRelation = "";
            this.fld_lkeACBankTransactionToType.BOSPrivilege = "";
            this.fld_lkeACBankTransactionToType.BOSPropertyName = "EditValue";
            this.fld_lkeACBankTransactionToType.BOSSelectType = "";
            this.fld_lkeACBankTransactionToType.BOSSelectTypeValue = "";
            this.fld_lkeACBankTransactionToType.CurrentDisplayText = null;
            this.fld_lkeACBankTransactionToType.Location = new System.Drawing.Point(202, 116);
            this.fld_lkeACBankTransactionToType.Name = "fld_lkeACBankTransactionToType";
            this.fld_lkeACBankTransactionToType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lkeACBankTransactionToType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACBankTransactionToType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACBankTransactionToType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACBankTransactionToType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACBankTransactionToType.Properties.ColumnName = null;
            this.fld_lkeACBankTransactionToType.Properties.NullText = "";
            this.fld_lkeACBankTransactionToType.Properties.PopupWidth = 40;
            this.fld_lkeACBankTransactionToType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACBankTransactionToType.Screen = null;
            this.fld_lkeACBankTransactionToType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACBankTransactionToType.TabIndex = 12;
            this.fld_lkeACBankTransactionToType.Tag = "DC";
            this.fld_lkeACBankTransactionToType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeACBankTransactionToType_CloseUp);
            this.fld_lkeACBankTransactionToType.EditValueChanged += new System.EventHandler(this.fld_lkeACBankTransactionToType_EditValueChanged);
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel10.Location = new System.Drawing.Point(127, 119);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(20, 13);
            this.bosLabel10.TabIndex = 50;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Đến";
            // 
            // fld_lkeACBankTransactionFromType
            // 
            this.fld_lkeACBankTransactionFromType.BOSAllowAddNew = false;
            this.fld_lkeACBankTransactionFromType.BOSAllowDummy = false;
            this.fld_lkeACBankTransactionFromType.BOSComment = "";
            this.fld_lkeACBankTransactionFromType.BOSDataMember = "ACBankTransactionFromType";
            this.fld_lkeACBankTransactionFromType.BOSDataSource = "ACBankTransactions";
            this.fld_lkeACBankTransactionFromType.BOSDescription = null;
            this.fld_lkeACBankTransactionFromType.BOSError = null;
            this.fld_lkeACBankTransactionFromType.BOSFieldGroup = "";
            this.fld_lkeACBankTransactionFromType.BOSFieldParent = "";
            this.fld_lkeACBankTransactionFromType.BOSFieldRelation = "";
            this.fld_lkeACBankTransactionFromType.BOSPrivilege = "";
            this.fld_lkeACBankTransactionFromType.BOSPropertyName = "EditValue";
            this.fld_lkeACBankTransactionFromType.BOSSelectType = "";
            this.fld_lkeACBankTransactionFromType.BOSSelectTypeValue = "";
            this.fld_lkeACBankTransactionFromType.CurrentDisplayText = null;
            this.fld_lkeACBankTransactionFromType.Location = new System.Drawing.Point(202, 90);
            this.fld_lkeACBankTransactionFromType.Name = "fld_lkeACBankTransactionFromType";
            this.fld_lkeACBankTransactionFromType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lkeACBankTransactionFromType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACBankTransactionFromType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACBankTransactionFromType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACBankTransactionFromType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACBankTransactionFromType.Properties.ColumnName = null;
            this.fld_lkeACBankTransactionFromType.Properties.NullText = "";
            this.fld_lkeACBankTransactionFromType.Properties.PopupWidth = 40;
            this.fld_lkeACBankTransactionFromType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACBankTransactionFromType.Screen = null;
            this.fld_lkeACBankTransactionFromType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACBankTransactionFromType.TabIndex = 9;
            this.fld_lkeACBankTransactionFromType.Tag = "DC";
            this.fld_lkeACBankTransactionFromType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeACBankTransactionFromType_CloseUp);
            this.fld_lkeACBankTransactionFromType.EditValueChanged += new System.EventHandler(this.fld_lkeACBankTransactionFromType_EditValueChanged);
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
            this.bosLabel14.BOSPropertyName = "";
            this.bosLabel14.Location = new System.Drawing.Point(127, 93);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(13, 13);
            this.bosLabel14.TabIndex = 48;
            this.bosLabel14.Tag = "";
            this.bosLabel14.Text = "Từ";
            // 
            // fld_lkeFK_ACSegmentID
            // 
            this.fld_lkeFK_ACSegmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACSegmentID.BOSAllowDummy = true;
            this.fld_lkeFK_ACSegmentID.BOSComment = "";
            this.fld_lkeFK_ACSegmentID.BOSDataMember = "FK_ACSegmentID";
            this.fld_lkeFK_ACSegmentID.BOSDataSource = "ACBankTransactions";
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
            this.fld_lkeFK_ACSegmentID.Location = new System.Drawing.Point(759, 12);
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
            this.fld_lkeFK_ACSegmentID.Size = new System.Drawing.Size(187, 20);
            this.fld_lkeFK_ACSegmentID.TabIndex = 4;
            this.fld_lkeFK_ACSegmentID.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel9.Location = new System.Drawing.Point(668, 15);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(85, 13);
            this.bosLabel9.TabIndex = 46;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Khoản mục chi phí";
            // 
            // fld_grcGroupControl2
            // 
            this.fld_grcGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl2.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl2.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl2.BOSComment = "";
            this.fld_grcGroupControl2.BOSDataMember = "";
            this.fld_grcGroupControl2.BOSDataSource = "";
            this.fld_grcGroupControl2.BOSDescription = null;
            this.fld_grcGroupControl2.BOSError = null;
            this.fld_grcGroupControl2.BOSFieldGroup = "";
            this.fld_grcGroupControl2.BOSFieldRelation = "";
            this.fld_grcGroupControl2.BOSPrivilege = "";
            this.fld_grcGroupControl2.BOSPropertyName = "";
            this.fld_grcGroupControl2.Controls.Add(this.fld_dgcACBankTransactionItems);
            this.fld_grcGroupControl2.Location = new System.Drawing.Point(5, 276);
            this.fld_grcGroupControl2.Name = "fld_grcGroupControl2";
            this.fld_grcGroupControl2.Screen = null;
            this.fld_grcGroupControl2.Size = new System.Drawing.Size(949, 382);
            this.fld_grcGroupControl2.TabIndex = 17;
            this.fld_grcGroupControl2.Tag = "";
            this.fld_grcGroupControl2.Text = "Thông tin chi tiết";
            // 
            // fld_dgcACBankTransactionItems
            // 
            this.fld_dgcACBankTransactionItems.AllowDrop = true;
            this.fld_dgcACBankTransactionItems.BOSComment = "";
            this.fld_dgcACBankTransactionItems.BOSDataMember = "";
            this.fld_dgcACBankTransactionItems.BOSDataSource = "ACBankTransactionItems";
            this.fld_dgcACBankTransactionItems.BOSDescription = null;
            this.fld_dgcACBankTransactionItems.BOSError = null;
            this.fld_dgcACBankTransactionItems.BOSFieldGroup = "";
            this.fld_dgcACBankTransactionItems.BOSFieldRelation = "";
            this.fld_dgcACBankTransactionItems.BOSGridType = null;
            this.fld_dgcACBankTransactionItems.BOSPrivilege = "";
            this.fld_dgcACBankTransactionItems.BOSPropertyName = "";
            this.fld_dgcACBankTransactionItems.CommodityType = "";
            this.fld_dgcACBankTransactionItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACBankTransactionItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACBankTransactionItems.Location = new System.Drawing.Point(2, 20);
            this.fld_dgcACBankTransactionItems.MainView = this.fld_dgvACBankTransactionItems;
            this.fld_dgcACBankTransactionItems.Name = "fld_dgcACBankTransactionItems";
            this.fld_dgcACBankTransactionItems.PrintReport = false;
            this.fld_dgcACBankTransactionItems.Screen = null;
            this.fld_dgcACBankTransactionItems.Size = new System.Drawing.Size(945, 360);
            this.fld_dgcACBankTransactionItems.TabIndex = 0;
            this.fld_dgcACBankTransactionItems.Tag = "DC";
            this.fld_dgcACBankTransactionItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvACBankTransactionItems});
            // 
            // fld_dgvACBankTransactionItems
            // 
            this.fld_dgvACBankTransactionItems.GridControl = this.fld_dgcACBankTransactionItems;
            this.fld_dgvACBankTransactionItems.Name = "fld_dgvACBankTransactionItems";
            this.fld_dgvACBankTransactionItems.PaintStyleName = "Office2003";
            // 
            // fld_txtACBankTransactionNo
            // 
            this.fld_txtACBankTransactionNo.BOSComment = "";
            this.fld_txtACBankTransactionNo.BOSDataMember = "ACBankTransactionNo";
            this.fld_txtACBankTransactionNo.BOSDataSource = "ACBankTransactions";
            this.fld_txtACBankTransactionNo.BOSDescription = null;
            this.fld_txtACBankTransactionNo.BOSError = null;
            this.fld_txtACBankTransactionNo.BOSFieldGroup = "";
            this.fld_txtACBankTransactionNo.BOSFieldRelation = "";
            this.fld_txtACBankTransactionNo.BOSPrivilege = "";
            this.fld_txtACBankTransactionNo.BOSPropertyName = "Text";
            this.fld_txtACBankTransactionNo.EditValue = "";
            this.fld_txtACBankTransactionNo.Location = new System.Drawing.Point(202, 12);
            this.fld_txtACBankTransactionNo.Name = "fld_txtACBankTransactionNo";
            this.fld_txtACBankTransactionNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACBankTransactionNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACBankTransactionNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACBankTransactionNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACBankTransactionNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACBankTransactionNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACBankTransactionNo.Screen = null;
            this.fld_txtACBankTransactionNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACBankTransactionNo.TabIndex = 2;
            this.fld_txtACBankTransactionNo.Tag = "DC";
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(127, 41);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel5.TabIndex = 0;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Nhân viên";
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
            this.bosGroupControl1.Controls.Add(this.fld_txtACBankTransactionReceiverIDPlace);
            this.bosGroupControl1.Controls.Add(this.bosLabel8);
            this.bosGroupControl1.Controls.Add(this.fld_txtACBankTransactionReceiverName);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.fld_txtACBankTransactionReceiverIDNumber);
            this.bosGroupControl1.Controls.Add(this.fld_dteACBankTransactionReceiverIDDate);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.bosLabel7);
            this.bosGroupControl1.Location = new System.Drawing.Point(5, 187);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(949, 83);
            this.bosGroupControl1.TabIndex = 16;
            this.bosGroupControl1.Text = "Thông tin người nhận";
            // 
            // fld_txtACBankTransactionReceiverIDPlace
            // 
            this.fld_txtACBankTransactionReceiverIDPlace.BOSComment = null;
            this.fld_txtACBankTransactionReceiverIDPlace.BOSDataMember = "ACBankTransactionReceiverIDPlace";
            this.fld_txtACBankTransactionReceiverIDPlace.BOSDataSource = "ACBankTransactions";
            this.fld_txtACBankTransactionReceiverIDPlace.BOSDescription = null;
            this.fld_txtACBankTransactionReceiverIDPlace.BOSError = null;
            this.fld_txtACBankTransactionReceiverIDPlace.BOSFieldGroup = null;
            this.fld_txtACBankTransactionReceiverIDPlace.BOSFieldRelation = null;
            this.fld_txtACBankTransactionReceiverIDPlace.BOSPrivilege = null;
            this.fld_txtACBankTransactionReceiverIDPlace.BOSPropertyName = "Text";
            this.fld_txtACBankTransactionReceiverIDPlace.Location = new System.Drawing.Point(605, 54);
            this.fld_txtACBankTransactionReceiverIDPlace.Name = "fld_txtACBankTransactionReceiverIDPlace";
            this.fld_txtACBankTransactionReceiverIDPlace.Screen = null;
            this.fld_txtACBankTransactionReceiverIDPlace.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACBankTransactionReceiverIDPlace.TabIndex = 3;
            this.fld_txtACBankTransactionReceiverIDPlace.Tag = "DC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel8.Location = new System.Drawing.Point(553, 57);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(35, 13);
            this.bosLabel8.TabIndex = 12;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Nơi cấp";
            // 
            // fld_txtACBankTransactionReceiverName
            // 
            this.fld_txtACBankTransactionReceiverName.BOSComment = null;
            this.fld_txtACBankTransactionReceiverName.BOSDataMember = "ACBankTransactionReceiverName";
            this.fld_txtACBankTransactionReceiverName.BOSDataSource = "ACBankTransactions";
            this.fld_txtACBankTransactionReceiverName.BOSDescription = null;
            this.fld_txtACBankTransactionReceiverName.BOSError = null;
            this.fld_txtACBankTransactionReceiverName.BOSFieldGroup = null;
            this.fld_txtACBankTransactionReceiverName.BOSFieldRelation = null;
            this.fld_txtACBankTransactionReceiverName.BOSPrivilege = null;
            this.fld_txtACBankTransactionReceiverName.BOSPropertyName = "Text";
            this.fld_txtACBankTransactionReceiverName.Location = new System.Drawing.Point(100, 30);
            this.fld_txtACBankTransactionReceiverName.Name = "fld_txtACBankTransactionReceiverName";
            this.fld_txtACBankTransactionReceiverName.Screen = null;
            this.fld_txtACBankTransactionReceiverName.Size = new System.Drawing.Size(655, 20);
            this.fld_txtACBankTransactionReceiverName.TabIndex = 0;
            this.fld_txtACBankTransactionReceiverName.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(14, 57);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(44, 13);
            this.bosLabel1.TabIndex = 8;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Số CMND";
            // 
            // fld_txtACBankTransactionReceiverIDNumber
            // 
            this.fld_txtACBankTransactionReceiverIDNumber.BOSComment = null;
            this.fld_txtACBankTransactionReceiverIDNumber.BOSDataMember = "ACBankTransactionReceiverIDNumber";
            this.fld_txtACBankTransactionReceiverIDNumber.BOSDataSource = "ACBankTransactions";
            this.fld_txtACBankTransactionReceiverIDNumber.BOSDescription = null;
            this.fld_txtACBankTransactionReceiverIDNumber.BOSError = null;
            this.fld_txtACBankTransactionReceiverIDNumber.BOSFieldGroup = null;
            this.fld_txtACBankTransactionReceiverIDNumber.BOSFieldRelation = null;
            this.fld_txtACBankTransactionReceiverIDNumber.BOSPrivilege = null;
            this.fld_txtACBankTransactionReceiverIDNumber.BOSPropertyName = "Text";
            this.fld_txtACBankTransactionReceiverIDNumber.Location = new System.Drawing.Point(100, 54);
            this.fld_txtACBankTransactionReceiverIDNumber.Name = "fld_txtACBankTransactionReceiverIDNumber";
            this.fld_txtACBankTransactionReceiverIDNumber.Screen = null;
            this.fld_txtACBankTransactionReceiverIDNumber.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACBankTransactionReceiverIDNumber.TabIndex = 1;
            this.fld_txtACBankTransactionReceiverIDNumber.Tag = "DC";
            // 
            // fld_dteACBankTransactionReceiverIDDate
            // 
            this.fld_dteACBankTransactionReceiverIDDate.BOSComment = "";
            this.fld_dteACBankTransactionReceiverIDDate.BOSDataMember = "ACBankTransactionReceiverIDDate";
            this.fld_dteACBankTransactionReceiverIDDate.BOSDataSource = "ACBankTransactions";
            this.fld_dteACBankTransactionReceiverIDDate.BOSDescription = null;
            this.fld_dteACBankTransactionReceiverIDDate.BOSError = null;
            this.fld_dteACBankTransactionReceiverIDDate.BOSFieldGroup = "";
            this.fld_dteACBankTransactionReceiverIDDate.BOSFieldRelation = "";
            this.fld_dteACBankTransactionReceiverIDDate.BOSPrivilege = "";
            this.fld_dteACBankTransactionReceiverIDDate.BOSPropertyName = "EditValue";
            this.fld_dteACBankTransactionReceiverIDDate.EditValue = null;
            this.fld_dteACBankTransactionReceiverIDDate.Location = new System.Drawing.Point(373, 54);
            this.fld_dteACBankTransactionReceiverIDDate.Name = "fld_dteACBankTransactionReceiverIDDate";
            this.fld_dteACBankTransactionReceiverIDDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACBankTransactionReceiverIDDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACBankTransactionReceiverIDDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACBankTransactionReceiverIDDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACBankTransactionReceiverIDDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACBankTransactionReceiverIDDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACBankTransactionReceiverIDDate.Screen = null;
            this.fld_dteACBankTransactionReceiverIDDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACBankTransactionReceiverIDDate.TabIndex = 2;
            this.fld_dteACBankTransactionReceiverIDDate.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel3.Location = new System.Drawing.Point(14, 33);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(75, 13);
            this.bosLabel3.TabIndex = 6;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Tên người nhận";
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
            this.bosLabel7.Location = new System.Drawing.Point(285, 57);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(45, 13);
            this.bosLabel7.TabIndex = 10;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Ngày cấp";
            // 
            // fld_txtACBankTransactionSenderAccount
            // 
            this.fld_txtACBankTransactionSenderAccount.BOSComment = null;
            this.fld_txtACBankTransactionSenderAccount.BOSDataMember = "ACBankTransactionSenderAccount";
            this.fld_txtACBankTransactionSenderAccount.BOSDataSource = "ACBankTransactions";
            this.fld_txtACBankTransactionSenderAccount.BOSDescription = null;
            this.fld_txtACBankTransactionSenderAccount.BOSError = null;
            this.fld_txtACBankTransactionSenderAccount.BOSFieldGroup = null;
            this.fld_txtACBankTransactionSenderAccount.BOSFieldRelation = null;
            this.fld_txtACBankTransactionSenderAccount.BOSPrivilege = null;
            this.fld_txtACBankTransactionSenderAccount.BOSPropertyName = "Text";
            this.fld_txtACBankTransactionSenderAccount.Location = new System.Drawing.Point(759, 90);
            this.fld_txtACBankTransactionSenderAccount.Name = "fld_txtACBankTransactionSenderAccount";
            this.fld_txtACBankTransactionSenderAccount.Screen = null;
            this.fld_txtACBankTransactionSenderAccount.Size = new System.Drawing.Size(187, 20);
            this.fld_txtACBankTransactionSenderAccount.TabIndex = 11;
            this.fld_txtACBankTransactionSenderAccount.Tag = "DC";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = "";
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ACBankTransactions";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(486, 38);
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
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ACBankTransactions";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(202, 38);
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
            this.fld_lkeFK_ACObjectID.TabIndex = 5;
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
            this.bosLabel2.Location = new System.Drawing.Point(398, 41);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(53, 13);
            this.bosLabel2.TabIndex = 2;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Loại tiền tệ";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ACBankTransactions";
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 104);
            this.fld_lkeFK_HREmployeeID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_dteACBankTransactionDate
            // 
            this.fld_dteACBankTransactionDate.BOSComment = "";
            this.fld_dteACBankTransactionDate.BOSDataMember = "ACBankTransactionDate";
            this.fld_dteACBankTransactionDate.BOSDataSource = "ACBankTransactions";
            this.fld_dteACBankTransactionDate.BOSDescription = null;
            this.fld_dteACBankTransactionDate.BOSError = null;
            this.fld_dteACBankTransactionDate.BOSFieldGroup = "";
            this.fld_dteACBankTransactionDate.BOSFieldRelation = "";
            this.fld_dteACBankTransactionDate.BOSPrivilege = "";
            this.fld_dteACBankTransactionDate.BOSPropertyName = "EditValue";
            this.fld_dteACBankTransactionDate.EditValue = null;
            this.fld_dteACBankTransactionDate.Location = new System.Drawing.Point(486, 12);
            this.fld_dteACBankTransactionDate.Name = "fld_dteACBankTransactionDate";
            this.fld_dteACBankTransactionDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACBankTransactionDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACBankTransactionDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACBankTransactionDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACBankTransactionDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACBankTransactionDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACBankTransactionDate.Screen = null;
            this.fld_dteACBankTransactionDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACBankTransactionDate.TabIndex = 3;
            this.fld_dteACBankTransactionDate.Tag = "DC";
            // 
            // fld_pteACBankTransactionEmployeePicture
            // 
            this.fld_pteACBankTransactionEmployeePicture.BOSComment = null;
            this.fld_pteACBankTransactionEmployeePicture.BOSDataMember = "ACBankTransactionEmployeePicture";
            this.fld_pteACBankTransactionEmployeePicture.BOSDataSource = "ACBankTransactions";
            this.fld_pteACBankTransactionEmployeePicture.BOSDescription = null;
            this.fld_pteACBankTransactionEmployeePicture.BOSError = null;
            this.fld_pteACBankTransactionEmployeePicture.BOSFieldGroup = null;
            this.fld_pteACBankTransactionEmployeePicture.BOSFieldRelation = null;
            this.fld_pteACBankTransactionEmployeePicture.BOSPrivilege = null;
            this.fld_pteACBankTransactionEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteACBankTransactionEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteACBankTransactionEmployeePicture.FileName = null;
            this.fld_pteACBankTransactionEmployeePicture.FilePath = null;
            this.fld_pteACBankTransactionEmployeePicture.Location = new System.Drawing.Point(3, 6);
            this.fld_pteACBankTransactionEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteACBankTransactionEmployeePicture.Name = "fld_pteACBankTransactionEmployeePicture";
            this.fld_pteACBankTransactionEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteACBankTransactionEmployeePicture.Screen = null;
            this.fld_pteACBankTransactionEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteACBankTransactionEmployeePicture.TabIndex = 0;
            this.fld_pteACBankTransactionEmployeePicture.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(668, 93);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(46, 13);
            this.bosLabel6.TabIndex = 6;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Tài khoản";
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
            this.bosLabel4.Location = new System.Drawing.Point(398, 67);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(25, 13);
            this.bosLabel4.TabIndex = 4;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Tỉ giá";
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(127, 15);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel2.TabIndex = 0;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Mã chứng từ";
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(398, 15);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel4.TabIndex = 2;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Ngày chứng từ";
            // 
            // fld_txtACBankTransactionExchangeRate
            // 
            this.fld_txtACBankTransactionExchangeRate.BOSComment = "";
            this.fld_txtACBankTransactionExchangeRate.BOSDataMember = "ACBankTransactionExchangeRate";
            this.fld_txtACBankTransactionExchangeRate.BOSDataSource = "ACBankTransactions";
            this.fld_txtACBankTransactionExchangeRate.BOSDescription = null;
            this.fld_txtACBankTransactionExchangeRate.BOSError = null;
            this.fld_txtACBankTransactionExchangeRate.BOSFieldGroup = "";
            this.fld_txtACBankTransactionExchangeRate.BOSFieldRelation = "";
            this.fld_txtACBankTransactionExchangeRate.BOSPrivilege = "";
            this.fld_txtACBankTransactionExchangeRate.BOSPropertyName = "Text";
            this.fld_txtACBankTransactionExchangeRate.EditValue = "";
            this.fld_txtACBankTransactionExchangeRate.Location = new System.Drawing.Point(486, 64);
            this.fld_txtACBankTransactionExchangeRate.Name = "fld_txtACBankTransactionExchangeRate";
            this.fld_txtACBankTransactionExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACBankTransactionExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACBankTransactionExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACBankTransactionExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACBankTransactionExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACBankTransactionExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACBankTransactionExchangeRate.Screen = null;
            this.fld_txtACBankTransactionExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACBankTransactionExchangeRate.TabIndex = 8;
            this.fld_txtACBankTransactionExchangeRate.Tag = "DC";
            this.fld_txtACBankTransactionExchangeRate.Validated += new System.EventHandler(this.fld_txtACBankTransactionExchangeRate_Validated);
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
            this.fld_lblLabel6.Location = new System.Drawing.Point(127, 145);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel6.TabIndex = 8;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Diễn giải";
            // 
            // fld_lkeFK_CSCompanyBankID
            // 
            this.fld_lkeFK_CSCompanyBankID.BOSAllowAddNew = false;
            this.fld_lkeFK_CSCompanyBankID.BOSAllowDummy = false;
            this.fld_lkeFK_CSCompanyBankID.BOSComment = "";
            this.fld_lkeFK_CSCompanyBankID.BOSDataMember = "FK_CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.BOSDataSource = "ACBankTransactions";
            this.fld_lkeFK_CSCompanyBankID.BOSDescription = null;
            this.fld_lkeFK_CSCompanyBankID.BOSError = null;
            this.fld_lkeFK_CSCompanyBankID.BOSFieldGroup = "";
            this.fld_lkeFK_CSCompanyBankID.BOSFieldParent = "";
            this.fld_lkeFK_CSCompanyBankID.BOSFieldRelation = "";
            this.fld_lkeFK_CSCompanyBankID.BOSPrivilege = "";
            this.fld_lkeFK_CSCompanyBankID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_CSCompanyBankID.BOSSelectType = "";
            this.fld_lkeFK_CSCompanyBankID.BOSSelectTypeValue = "";
            this.fld_lkeFK_CSCompanyBankID.CurrentDisplayText = null;
            this.fld_lkeFK_CSCompanyBankID.Location = new System.Drawing.Point(486, 90);
            this.fld_lkeFK_CSCompanyBankID.Name = "fld_lkeFK_CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_CSCompanyBankID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_CSCompanyBankID.Properties.ColumnName = null;
            this.fld_lkeFK_CSCompanyBankID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCompanyBankAccount", "Số tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCompanyBankName", "Tên ngân hàng")});
            this.fld_lkeFK_CSCompanyBankID.Properties.DisplayMember = "CSCompanyBankName";
            this.fld_lkeFK_CSCompanyBankID.Properties.NullText = "";
            this.fld_lkeFK_CSCompanyBankID.Properties.PopupWidth = 40;
            this.fld_lkeFK_CSCompanyBankID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_CSCompanyBankID.Properties.ValueMember = "CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.Screen = null;
            this.fld_lkeFK_CSCompanyBankID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_CSCompanyBankID.TabIndex = 10;
            this.fld_lkeFK_CSCompanyBankID.Tag = "DC";
            this.fld_lkeFK_CSCompanyBankID.Visible = false;
            this.fld_lkeFK_CSCompanyBankID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_CSCompanyBankID_CloseUp);
            // 
            // fld_medACBankTransactionDesc
            // 
            this.fld_medACBankTransactionDesc.BOSComment = "";
            this.fld_medACBankTransactionDesc.BOSDataMember = "ACBankTransactionDesc";
            this.fld_medACBankTransactionDesc.BOSDataSource = "ACBankTransactions";
            this.fld_medACBankTransactionDesc.BOSDescription = null;
            this.fld_medACBankTransactionDesc.BOSError = null;
            this.fld_medACBankTransactionDesc.BOSFieldGroup = "";
            this.fld_medACBankTransactionDesc.BOSFieldRelation = "";
            this.fld_medACBankTransactionDesc.BOSPrivilege = "";
            this.fld_medACBankTransactionDesc.BOSPropertyName = "Text";
            this.fld_medACBankTransactionDesc.EditValue = "";
            this.fld_medACBankTransactionDesc.Location = new System.Drawing.Point(202, 142);
            this.fld_medACBankTransactionDesc.Name = "fld_medACBankTransactionDesc";
            this.fld_medACBankTransactionDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACBankTransactionDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACBankTransactionDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACBankTransactionDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACBankTransactionDesc.Screen = null;
            this.fld_medACBankTransactionDesc.Size = new System.Drawing.Size(744, 35);
            this.fld_medACBankTransactionDesc.TabIndex = 15;
            this.fld_medACBankTransactionDesc.Tag = "DC";
            this.fld_medACBankTransactionDesc.Validated += new System.EventHandler(this.fld_medACBankTransactionDesc_Validated);
            // 
            // DMBPC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(965, 658);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMBPC100";
            this.Text = "Thông tin chung";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ToCSCashFundID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCashFundID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ToCSCompanyBankID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACBankTransactionToType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACBankTransactionFromType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl2)).EndInit();
            this.fld_grcGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACBankTransactionItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACBankTransactionItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionReceiverIDPlace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionReceiverName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionReceiverIDNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBankTransactionReceiverIDDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBankTransactionReceiverIDDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionSenderAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBankTransactionDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBankTransactionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACBankTransactionEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBankTransactionExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyBankID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACBankTransactionDesc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSTextBox fld_txtACBankTransactionReceiverName;
        private BOSComponent.BOSTextBox fld_txtACBankTransactionReceiverIDNumber;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtACBankTransactionExchangeRate;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteACBankTransactionEmployeePicture;
        private IContainer components;
        private BOSComponent.BOSGroupControl fld_grcGroupControl2;
        private BOSERP.Modules.PaymentCash.PaymentCashItemGridControl fld_dgcACBankTransactionItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACBankTransactionItems;
        private BOSComponent.BOSDateEdit fld_dteACBankTransactionReceiverIDDate;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtACBankTransactionReceiverIDPlace;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSTextBox fld_txtACBankTransactionNo;
        private BOSComponent.BOSTextBox fld_txtACBankTransactionSenderAccount;
        private BOSComponent.BOSDateEdit fld_dteACBankTransactionDate;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_CSCompanyBankID;
        private BOSComponent.BOSMemoEdit fld_medACBankTransactionDesc;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACSegmentID;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeACBankTransactionFromType;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLookupEdit fld_lkeACBankTransactionToType;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ToCSCompanyBankID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ToCSCashFundID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_CSCashFundID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox bosTextBox1;
	}
}
