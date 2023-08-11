using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.LoanAgreement.UI
{
	/// <summary>
	/// Summary description for DMLAGM100
	/// </summary>
	partial class DMLAGM100
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
            this.fld_txtACLoanAgreementNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACLoanAgreementDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACLoanAgreementDeadline = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_CSCompanyBankID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtACLoanAgreementAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACLoanAgreementReceiptAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACLoanAgreementRemainAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_medACLoanAgreementDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACLoanAgreementLCLimit = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACLoanAgreementTotalLimit = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanAgreementNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACLoanAgreementDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACLoanAgreementDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACLoanAgreementDeadline.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACLoanAgreementDeadline.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyBankID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanAgreementAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanAgreementReceiptAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanAgreementRemainAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACLoanAgreementDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanAgreementLCLimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanAgreementTotalLimit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtACLoanAgreementNo
            // 
            this.fld_txtACLoanAgreementNo.BOSComment = "";
            this.fld_txtACLoanAgreementNo.BOSDataMember = "ACLoanAgreementNo";
            this.fld_txtACLoanAgreementNo.BOSDataSource = "ACLoanAgreements";
            this.fld_txtACLoanAgreementNo.BOSDescription = null;
            this.fld_txtACLoanAgreementNo.BOSError = null;
            this.fld_txtACLoanAgreementNo.BOSFieldGroup = "";
            this.fld_txtACLoanAgreementNo.BOSFieldRelation = "";
            this.fld_txtACLoanAgreementNo.BOSPrivilege = "";
            this.fld_txtACLoanAgreementNo.BOSPropertyName = "Text";
            this.fld_txtACLoanAgreementNo.EditValue = "";
            this.fld_txtACLoanAgreementNo.Location = new System.Drawing.Point(110, 12);
            this.fld_txtACLoanAgreementNo.Name = "fld_txtACLoanAgreementNo";
            this.fld_txtACLoanAgreementNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACLoanAgreementNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACLoanAgreementNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACLoanAgreementNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACLoanAgreementNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACLoanAgreementNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACLoanAgreementNo.Screen = null;
            this.fld_txtACLoanAgreementNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACLoanAgreementNo.TabIndex = 6;
            this.fld_txtACLoanAgreementNo.Tag = "DC";
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(12, 16);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(60, 13);
            this.fld_lblLabel4.TabIndex = 7;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Số hợp đồng";
            // 
            // fld_dteACLoanAgreementDate
            // 
            this.fld_dteACLoanAgreementDate.BOSComment = "";
            this.fld_dteACLoanAgreementDate.BOSDataMember = "ACLoanAgreementDate";
            this.fld_dteACLoanAgreementDate.BOSDataSource = "ACLoanAgreements";
            this.fld_dteACLoanAgreementDate.BOSDescription = null;
            this.fld_dteACLoanAgreementDate.BOSError = null;
            this.fld_dteACLoanAgreementDate.BOSFieldGroup = "";
            this.fld_dteACLoanAgreementDate.BOSFieldRelation = "";
            this.fld_dteACLoanAgreementDate.BOSPrivilege = "";
            this.fld_dteACLoanAgreementDate.BOSPropertyName = "EditValue";
            this.fld_dteACLoanAgreementDate.EditValue = null;
            this.fld_dteACLoanAgreementDate.Location = new System.Drawing.Point(417, 12);
            this.fld_dteACLoanAgreementDate.Name = "fld_dteACLoanAgreementDate";
            this.fld_dteACLoanAgreementDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACLoanAgreementDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACLoanAgreementDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACLoanAgreementDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACLoanAgreementDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACLoanAgreementDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACLoanAgreementDate.Screen = null;
            this.fld_dteACLoanAgreementDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACLoanAgreementDate.TabIndex = 8;
            this.fld_dteACLoanAgreementDate.Tag = "DC";
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(290, 17);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(73, 13);
            this.fld_lblLabel5.TabIndex = 9;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Ngày hợp đồng";
            // 
            // fld_dteACLoanAgreementDeadline
            // 
            this.fld_dteACLoanAgreementDeadline.BOSComment = "";
            this.fld_dteACLoanAgreementDeadline.BOSDataMember = "ACLoanAgreementDeadline";
            this.fld_dteACLoanAgreementDeadline.BOSDataSource = "ACLoanAgreements";
            this.fld_dteACLoanAgreementDeadline.BOSDescription = null;
            this.fld_dteACLoanAgreementDeadline.BOSError = null;
            this.fld_dteACLoanAgreementDeadline.BOSFieldGroup = "";
            this.fld_dteACLoanAgreementDeadline.BOSFieldRelation = "";
            this.fld_dteACLoanAgreementDeadline.BOSPrivilege = "";
            this.fld_dteACLoanAgreementDeadline.BOSPropertyName = "EditValue";
            this.fld_dteACLoanAgreementDeadline.EditValue = null;
            this.fld_dteACLoanAgreementDeadline.Location = new System.Drawing.Point(417, 38);
            this.fld_dteACLoanAgreementDeadline.Name = "fld_dteACLoanAgreementDeadline";
            this.fld_dteACLoanAgreementDeadline.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACLoanAgreementDeadline.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACLoanAgreementDeadline.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACLoanAgreementDeadline.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACLoanAgreementDeadline.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACLoanAgreementDeadline.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACLoanAgreementDeadline.Screen = null;
            this.fld_dteACLoanAgreementDeadline.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACLoanAgreementDeadline.TabIndex = 10;
            this.fld_dteACLoanAgreementDeadline.Tag = "DC";
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
            this.bosLabel1.BOSPropertyName = "";
            this.bosLabel1.Location = new System.Drawing.Point(290, 41);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(115, 13);
            this.bosLabel1.TabIndex = 11;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Ngày kết thúc hợp đồng";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = "";
            this.fld_lblLabel1.BOSDataMember = "";
            this.fld_lblLabel1.BOSDataSource = "";
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = "";
            this.fld_lblLabel1.BOSFieldRelation = "";
            this.fld_lblLabel1.BOSPrivilege = "";
            this.fld_lblLabel1.BOSPropertyName = "";
            this.fld_lblLabel1.Location = new System.Drawing.Point(12, 41);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(52, 13);
            this.fld_lblLabel1.TabIndex = 13;
            this.fld_lblLabel1.Tag = "";
            this.fld_lblLabel1.Text = "Ngân hàng";
            // 
            // fld_lkeFK_CSCompanyBankID
            // 
            this.fld_lkeFK_CSCompanyBankID.BOSAllowAddNew = false;
            this.fld_lkeFK_CSCompanyBankID.BOSAllowDummy = false;
            this.fld_lkeFK_CSCompanyBankID.BOSComment = "";
            this.fld_lkeFK_CSCompanyBankID.BOSDataMember = "FK_CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.BOSDataSource = "ACLoanAgreements";
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
            this.fld_lkeFK_CSCompanyBankID.Location = new System.Drawing.Point(110, 38);
            this.fld_lkeFK_CSCompanyBankID.Name = "fld_lkeFK_CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_CSCompanyBankID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_CSCompanyBankID.Properties.ColumnName = null;
            this.fld_lkeFK_CSCompanyBankID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCompanyBankCode", "Mã ngân hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCompanyBankAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCompanyBankName", "Tên ngân hàng")});
            this.fld_lkeFK_CSCompanyBankID.Properties.DisplayMember = "CSCompanyBankName";
            this.fld_lkeFK_CSCompanyBankID.Properties.NullText = "";
            this.fld_lkeFK_CSCompanyBankID.Properties.PopupWidth = 40;
            this.fld_lkeFK_CSCompanyBankID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_CSCompanyBankID.Properties.ValueMember = "CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.Screen = null;
            this.fld_lkeFK_CSCompanyBankID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_CSCompanyBankID.TabIndex = 12;
            this.fld_lkeFK_CSCompanyBankID.Tag = "DC";
            // 
            // fld_txtACLoanAgreementAmount
            // 
            this.fld_txtACLoanAgreementAmount.BOSComment = "";
            this.fld_txtACLoanAgreementAmount.BOSDataMember = "ACLoanAgreementAmount";
            this.fld_txtACLoanAgreementAmount.BOSDataSource = "ACLoanAgreements";
            this.fld_txtACLoanAgreementAmount.BOSDescription = null;
            this.fld_txtACLoanAgreementAmount.BOSError = null;
            this.fld_txtACLoanAgreementAmount.BOSFieldGroup = "";
            this.fld_txtACLoanAgreementAmount.BOSFieldRelation = "";
            this.fld_txtACLoanAgreementAmount.BOSPrivilege = "";
            this.fld_txtACLoanAgreementAmount.BOSPropertyName = "Text";
            this.fld_txtACLoanAgreementAmount.EditValue = "0.00";
            this.fld_txtACLoanAgreementAmount.Location = new System.Drawing.Point(110, 90);
            this.fld_txtACLoanAgreementAmount.Name = "fld_txtACLoanAgreementAmount";
            this.fld_txtACLoanAgreementAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACLoanAgreementAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACLoanAgreementAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACLoanAgreementAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACLoanAgreementAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACLoanAgreementAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACLoanAgreementAmount.Screen = null;
            this.fld_txtACLoanAgreementAmount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACLoanAgreementAmount.TabIndex = 14;
            this.fld_txtACLoanAgreementAmount.Tag = "DC";
            this.fld_txtACLoanAgreementAmount.Validated += new System.EventHandler(this.fld_txtACLoanAgreementAmount_Validated);
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
            this.bosLabel2.Location = new System.Drawing.Point(12, 93);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(89, 13);
            this.bosLabel2.TabIndex = 15;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Tổng hạn mức vay";
            // 
            // fld_txtACLoanAgreementReceiptAmount
            // 
            this.fld_txtACLoanAgreementReceiptAmount.BOSComment = "";
            this.fld_txtACLoanAgreementReceiptAmount.BOSDataMember = "ACLoanAgreementReceiptAmount";
            this.fld_txtACLoanAgreementReceiptAmount.BOSDataSource = "ACLoanAgreements";
            this.fld_txtACLoanAgreementReceiptAmount.BOSDescription = null;
            this.fld_txtACLoanAgreementReceiptAmount.BOSError = null;
            this.fld_txtACLoanAgreementReceiptAmount.BOSFieldGroup = "";
            this.fld_txtACLoanAgreementReceiptAmount.BOSFieldRelation = "";
            this.fld_txtACLoanAgreementReceiptAmount.BOSPrivilege = "";
            this.fld_txtACLoanAgreementReceiptAmount.BOSPropertyName = "Text";
            this.fld_txtACLoanAgreementReceiptAmount.EditValue = "0.00";
            this.fld_txtACLoanAgreementReceiptAmount.Location = new System.Drawing.Point(417, 90);
            this.fld_txtACLoanAgreementReceiptAmount.Name = "fld_txtACLoanAgreementReceiptAmount";
            this.fld_txtACLoanAgreementReceiptAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACLoanAgreementReceiptAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACLoanAgreementReceiptAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACLoanAgreementReceiptAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACLoanAgreementReceiptAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACLoanAgreementReceiptAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACLoanAgreementReceiptAmount.Screen = null;
            this.fld_txtACLoanAgreementReceiptAmount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACLoanAgreementReceiptAmount.TabIndex = 16;
            this.fld_txtACLoanAgreementReceiptAmount.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(290, 93);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(57, 13);
            this.bosLabel3.TabIndex = 17;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Số nhận nợ ";
            // 
            // fld_txtACLoanAgreementRemainAmount
            // 
            this.fld_txtACLoanAgreementRemainAmount.BOSComment = "";
            this.fld_txtACLoanAgreementRemainAmount.BOSDataMember = "ACLoanAgreementRemainAmount";
            this.fld_txtACLoanAgreementRemainAmount.BOSDataSource = "ACLoanAgreements";
            this.fld_txtACLoanAgreementRemainAmount.BOSDescription = null;
            this.fld_txtACLoanAgreementRemainAmount.BOSError = null;
            this.fld_txtACLoanAgreementRemainAmount.BOSFieldGroup = "";
            this.fld_txtACLoanAgreementRemainAmount.BOSFieldRelation = "";
            this.fld_txtACLoanAgreementRemainAmount.BOSPrivilege = "";
            this.fld_txtACLoanAgreementRemainAmount.BOSPropertyName = "Text";
            this.fld_txtACLoanAgreementRemainAmount.EditValue = "0.00";
            this.fld_txtACLoanAgreementRemainAmount.Location = new System.Drawing.Point(110, 116);
            this.fld_txtACLoanAgreementRemainAmount.Name = "fld_txtACLoanAgreementRemainAmount";
            this.fld_txtACLoanAgreementRemainAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACLoanAgreementRemainAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACLoanAgreementRemainAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACLoanAgreementRemainAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACLoanAgreementRemainAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACLoanAgreementRemainAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACLoanAgreementRemainAmount.Screen = null;
            this.fld_txtACLoanAgreementRemainAmount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACLoanAgreementRemainAmount.TabIndex = 18;
            this.fld_txtACLoanAgreementRemainAmount.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(12, 119);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(48, 13);
            this.bosLabel4.TabIndex = 19;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Số còn lại ";
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
            this.fld_lblLabel6.Location = new System.Drawing.Point(12, 145);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(27, 13);
            this.fld_lblLabel6.TabIndex = 21;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Mô tả";
            // 
            // fld_medACLoanAgreementDesc
            // 
            this.fld_medACLoanAgreementDesc.BOSComment = "";
            this.fld_medACLoanAgreementDesc.BOSDataMember = "ACLoanAgreementDesc";
            this.fld_medACLoanAgreementDesc.BOSDataSource = "ACLoanAgreements";
            this.fld_medACLoanAgreementDesc.BOSDescription = null;
            this.fld_medACLoanAgreementDesc.BOSError = null;
            this.fld_medACLoanAgreementDesc.BOSFieldGroup = "";
            this.fld_medACLoanAgreementDesc.BOSFieldRelation = "";
            this.fld_medACLoanAgreementDesc.BOSPrivilege = "";
            this.fld_medACLoanAgreementDesc.BOSPropertyName = "Text";
            this.fld_medACLoanAgreementDesc.EditValue = "";
            this.fld_medACLoanAgreementDesc.Location = new System.Drawing.Point(110, 142);
            this.fld_medACLoanAgreementDesc.Name = "fld_medACLoanAgreementDesc";
            this.fld_medACLoanAgreementDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACLoanAgreementDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACLoanAgreementDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACLoanAgreementDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACLoanAgreementDesc.Screen = null;
            this.fld_medACLoanAgreementDesc.Size = new System.Drawing.Size(457, 38);
            this.fld_medACLoanAgreementDesc.TabIndex = 20;
            this.fld_medACLoanAgreementDesc.Tag = "DC";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = false;
            this.fld_lkeFK_GECurrencyID.BOSComment = "";
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ACLoanAgreements";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(417, 116);
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
            this.fld_lkeFK_GECurrencyID.TabIndex = 23;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
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
            this.bosLabel5.Location = new System.Drawing.Point(290, 119);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(53, 13);
            this.bosLabel5.TabIndex = 22;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Loại tiền tệ";
            // 
            // fld_txtACLoanAgreementLCLimit
            // 
            this.fld_txtACLoanAgreementLCLimit.BOSComment = "";
            this.fld_txtACLoanAgreementLCLimit.BOSDataMember = "ACLoanAgreementLCLimit";
            this.fld_txtACLoanAgreementLCLimit.BOSDataSource = "ACLoanAgreements";
            this.fld_txtACLoanAgreementLCLimit.BOSDescription = null;
            this.fld_txtACLoanAgreementLCLimit.BOSError = null;
            this.fld_txtACLoanAgreementLCLimit.BOSFieldGroup = "";
            this.fld_txtACLoanAgreementLCLimit.BOSFieldRelation = "";
            this.fld_txtACLoanAgreementLCLimit.BOSPrivilege = "";
            this.fld_txtACLoanAgreementLCLimit.BOSPropertyName = "Text";
            this.fld_txtACLoanAgreementLCLimit.EditValue = "0.00";
            this.fld_txtACLoanAgreementLCLimit.Location = new System.Drawing.Point(417, 64);
            this.fld_txtACLoanAgreementLCLimit.Name = "fld_txtACLoanAgreementLCLimit";
            this.fld_txtACLoanAgreementLCLimit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACLoanAgreementLCLimit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACLoanAgreementLCLimit.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACLoanAgreementLCLimit.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACLoanAgreementLCLimit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACLoanAgreementLCLimit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACLoanAgreementLCLimit.Screen = null;
            this.fld_txtACLoanAgreementLCLimit.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACLoanAgreementLCLimit.TabIndex = 28;
            this.fld_txtACLoanAgreementLCLimit.Tag = "DC";
            this.fld_txtACLoanAgreementLCLimit.Validated += new System.EventHandler(this.fld_txtACLoanAgreementLCLimit_Validated);
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
            this.bosLabel7.Location = new System.Drawing.Point(290, 67);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(57, 13);
            this.bosLabel7.TabIndex = 30;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Hạn mức LC";
            // 
            // fld_txtACLoanAgreementTotalLimit
            // 
            this.fld_txtACLoanAgreementTotalLimit.BOSComment = "";
            this.fld_txtACLoanAgreementTotalLimit.BOSDataMember = "ACLoanAgreementTotalLimit";
            this.fld_txtACLoanAgreementTotalLimit.BOSDataSource = "ACLoanAgreements";
            this.fld_txtACLoanAgreementTotalLimit.BOSDescription = null;
            this.fld_txtACLoanAgreementTotalLimit.BOSError = null;
            this.fld_txtACLoanAgreementTotalLimit.BOSFieldGroup = "";
            this.fld_txtACLoanAgreementTotalLimit.BOSFieldRelation = "";
            this.fld_txtACLoanAgreementTotalLimit.BOSPrivilege = "";
            this.fld_txtACLoanAgreementTotalLimit.BOSPropertyName = "Text";
            this.fld_txtACLoanAgreementTotalLimit.EditValue = "0.00";
            this.fld_txtACLoanAgreementTotalLimit.Location = new System.Drawing.Point(110, 64);
            this.fld_txtACLoanAgreementTotalLimit.Name = "fld_txtACLoanAgreementTotalLimit";
            this.fld_txtACLoanAgreementTotalLimit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACLoanAgreementTotalLimit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACLoanAgreementTotalLimit.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACLoanAgreementTotalLimit.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACLoanAgreementTotalLimit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACLoanAgreementTotalLimit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACLoanAgreementTotalLimit.Screen = null;
            this.fld_txtACLoanAgreementTotalLimit.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACLoanAgreementTotalLimit.TabIndex = 27;
            this.fld_txtACLoanAgreementTotalLimit.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(12, 67);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(71, 13);
            this.bosLabel6.TabIndex = 29;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Tổng hạn mức ";
            // 
            // DMLAGM100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(634, 403);
            this.Controls.Add(this.fld_txtACLoanAgreementLCLimit);
            this.Controls.Add(this.bosLabel7);
            this.Controls.Add(this.fld_txtACLoanAgreementTotalLimit);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.fld_lblLabel6);
            this.Controls.Add(this.fld_medACLoanAgreementDesc);
            this.Controls.Add(this.fld_txtACLoanAgreementRemainAmount);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_txtACLoanAgreementReceiptAmount);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_txtACLoanAgreementAmount);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lkeFK_CSCompanyBankID);
            this.Controls.Add(this.fld_dteACLoanAgreementDeadline);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_dteACLoanAgreementDate);
            this.Controls.Add(this.fld_lblLabel5);
            this.Controls.Add(this.fld_txtACLoanAgreementNo);
            this.Controls.Add(this.fld_lblLabel4);
            this.Name = "DMLAGM100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.fld_txtACLoanAgreementNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel5, 0);
            this.Controls.SetChildIndex(this.fld_dteACLoanAgreementDate, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dteACLoanAgreementDeadline, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_CSCompanyBankID, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_txtACLoanAgreementAmount, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_txtACLoanAgreementReceiptAmount, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.fld_txtACLoanAgreementRemainAmount, 0);
            this.Controls.SetChildIndex(this.fld_medACLoanAgreementDesc, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel6, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_GECurrencyID, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            this.Controls.SetChildIndex(this.fld_txtACLoanAgreementTotalLimit, 0);
            this.Controls.SetChildIndex(this.bosLabel7, 0);
            this.Controls.SetChildIndex(this.fld_txtACLoanAgreementLCLimit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanAgreementNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACLoanAgreementDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACLoanAgreementDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACLoanAgreementDeadline.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACLoanAgreementDeadline.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyBankID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanAgreementAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanAgreementReceiptAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanAgreementRemainAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACLoanAgreementDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanAgreementLCLimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanAgreementTotalLimit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSTextBox fld_txtACLoanAgreementNo;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private IContainer components;
        private BOSComponent.BOSDateEdit fld_dteACLoanAgreementDate;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSDateEdit fld_dteACLoanAgreementDeadline;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel fld_lblLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_CSCompanyBankID;
        private BOSComponent.BOSTextBox fld_txtACLoanAgreementAmount;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtACLoanAgreementReceiptAmount;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtACLoanAgreementRemainAmount;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSMemoEdit fld_medACLoanAgreementDesc;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtACLoanAgreementLCLimit;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtACLoanAgreementTotalLimit;
        private BOSComponent.BOSLabel bosLabel6;
    }
}
