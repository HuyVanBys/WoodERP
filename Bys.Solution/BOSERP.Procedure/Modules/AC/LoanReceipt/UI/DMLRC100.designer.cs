using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.LoanReceipt.UI
{
	/// <summary>
	/// Summary description for DMLRC100
	/// </summary>
	partial class DMLRC100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMLRC100));
            this.fld_txtACLoanReceiptNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACLoanReceiptDeadline = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACLoanAgreementID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteACLoanReceiptDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACLoanReceiptAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACLoanReceiptRemainAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACLoanReceiptInterestRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACLoanReceiptOverdueInterestRate = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_medACLoanReceiptContent = new BOSComponent.BOSMemoEdit(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnACDocument = new BOSComponent.BOSButton(this.components);
            this.fld_dgcACLoanReceiptItems = new BOSERP.Modules.LoanReceipt.LoanReceiptItemsGridControl();
            this.fld_dgvAPPurchaseOrderItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACLoanReceiptPayDocs = new BOSERP.Modules.LoanReceipt.LoanReceiptPayDocsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnCreatePaymentPlans = new BOSComponent.BOSButton(this.components);
            this.fld_dgcACLoanReceiptPaymentPlans = new BOSERP.Modules.LoanReceipt.LoanReceiptPaymentPlansGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACLoanReceiptInterestRateChanges = new BOSERP.Modules.LoanReceipt.ACLoanReceiptInterestRateChangesGridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtACLoanReceiptExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACLoanReceiptExchangeAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACLoanReceiptProfitMethod = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtACLoanReceiptLimit = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACLoanReceiptTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.loanReceiptPayDocsGridControl1 = new BOSERP.Modules.LoanReceipt.LoanReceiptPaymentPlansGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.panel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_txtACLoanReceiptPaidAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACLoanReceiptOpeningPaidAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACLoanReceiptPaymentForMonth = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACLoanReceiptNoOfBank = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabelNoOfBank = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACLoanReceiptDeadline.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACLoanReceiptDeadline.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACLoanAgreementID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACLoanReceiptDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACLoanReceiptDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptRemainAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptInterestRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptOverdueInterestRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACLoanReceiptContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACLoanReceiptItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrderItems)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACLoanReceiptPayDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACLoanReceiptPaymentPlans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACLoanReceiptInterestRateChanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptExchangeAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACLoanReceiptProfitMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptLimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACLoanReceiptTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanReceiptPayDocsGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptPaidAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptOpeningPaidAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptPaymentForMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptNoOfBank.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtACLoanReceiptNo
            // 
            this.fld_txtACLoanReceiptNo.BOSComment = "";
            this.fld_txtACLoanReceiptNo.BOSDataMember = "ACLoanReceiptNo";
            this.fld_txtACLoanReceiptNo.BOSDataSource = "ACLoanReceipts";
            this.fld_txtACLoanReceiptNo.BOSDescription = null;
            this.fld_txtACLoanReceiptNo.BOSError = null;
            this.fld_txtACLoanReceiptNo.BOSFieldGroup = "";
            this.fld_txtACLoanReceiptNo.BOSFieldRelation = "";
            this.fld_txtACLoanReceiptNo.BOSPrivilege = "";
            this.fld_txtACLoanReceiptNo.BOSPropertyName = "Text";
            this.fld_txtACLoanReceiptNo.EditValue = "";
            this.fld_txtACLoanReceiptNo.Location = new System.Drawing.Point(102, 8);
            this.fld_txtACLoanReceiptNo.Name = "fld_txtACLoanReceiptNo";
            this.fld_txtACLoanReceiptNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACLoanReceiptNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACLoanReceiptNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACLoanReceiptNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACLoanReceiptNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACLoanReceiptNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACLoanReceiptNo.Screen = null;
            this.fld_txtACLoanReceiptNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACLoanReceiptNo.TabIndex = 0;
            this.fld_txtACLoanReceiptNo.Tag = "DC";
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(16, 12);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(55, 13);
            this.fld_lblLabel4.TabIndex = 9;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Mã khế ước";
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(555, 12);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabel5.TabIndex = 11;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Ngày nhận nợ";
            // 
            // fld_dteACLoanReceiptDeadline
            // 
            this.fld_dteACLoanReceiptDeadline.BOSComment = "";
            this.fld_dteACLoanReceiptDeadline.BOSDataMember = "ACLoanReceiptDeadline";
            this.fld_dteACLoanReceiptDeadline.BOSDataSource = "ACLoanReceipts";
            this.fld_dteACLoanReceiptDeadline.BOSDescription = null;
            this.fld_dteACLoanReceiptDeadline.BOSError = null;
            this.fld_dteACLoanReceiptDeadline.BOSFieldGroup = "";
            this.fld_dteACLoanReceiptDeadline.BOSFieldRelation = "";
            this.fld_dteACLoanReceiptDeadline.BOSPrivilege = "";
            this.fld_dteACLoanReceiptDeadline.BOSPropertyName = "EditValue";
            this.fld_dteACLoanReceiptDeadline.EditValue = null;
            this.fld_dteACLoanReceiptDeadline.Location = new System.Drawing.Point(673, 34);
            this.fld_dteACLoanReceiptDeadline.Name = "fld_dteACLoanReceiptDeadline";
            this.fld_dteACLoanReceiptDeadline.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACLoanReceiptDeadline.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACLoanReceiptDeadline.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACLoanReceiptDeadline.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACLoanReceiptDeadline.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACLoanReceiptDeadline.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACLoanReceiptDeadline.Screen = null;
            this.fld_dteACLoanReceiptDeadline.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACLoanReceiptDeadline.TabIndex = 10;
            this.fld_dteACLoanReceiptDeadline.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(555, 38);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(67, 13);
            this.bosLabel1.TabIndex = 13;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Ngày đáo hạn";
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
            this.fld_lblLabel1.Location = new System.Drawing.Point(16, 38);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(60, 13);
            this.fld_lblLabel1.TabIndex = 15;
            this.fld_lblLabel1.Tag = "";
            this.fld_lblLabel1.Text = "Số hợp đồng";
            // 
            // fld_lkeFK_ACLoanAgreementID
            // 
            this.fld_lkeFK_ACLoanAgreementID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACLoanAgreementID.BOSAllowDummy = false;
            this.fld_lkeFK_ACLoanAgreementID.BOSComment = "";
            this.fld_lkeFK_ACLoanAgreementID.BOSDataMember = "FK_ACLoanAgreementID";
            this.fld_lkeFK_ACLoanAgreementID.BOSDataSource = "ACLoanReceipts";
            this.fld_lkeFK_ACLoanAgreementID.BOSDescription = null;
            this.fld_lkeFK_ACLoanAgreementID.BOSError = null;
            this.fld_lkeFK_ACLoanAgreementID.BOSFieldGroup = "";
            this.fld_lkeFK_ACLoanAgreementID.BOSFieldParent = "";
            this.fld_lkeFK_ACLoanAgreementID.BOSFieldRelation = "";
            this.fld_lkeFK_ACLoanAgreementID.BOSPrivilege = "";
            this.fld_lkeFK_ACLoanAgreementID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACLoanAgreementID.BOSSelectType = "";
            this.fld_lkeFK_ACLoanAgreementID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACLoanAgreementID.CurrentDisplayText = null;
            this.fld_lkeFK_ACLoanAgreementID.Location = new System.Drawing.Point(102, 34);
            this.fld_lkeFK_ACLoanAgreementID.Name = "fld_lkeFK_ACLoanAgreementID";
            this.fld_lkeFK_ACLoanAgreementID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACLoanAgreementID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACLoanAgreementID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACLoanAgreementID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACLoanAgreementID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACLoanAgreementID.Properties.ColumnName = null;
            this.fld_lkeFK_ACLoanAgreementID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACLoanAgreementNo", "Mã hợp đồng")});
            this.fld_lkeFK_ACLoanAgreementID.Properties.DisplayMember = "ACLoanAgreementNo";
            this.fld_lkeFK_ACLoanAgreementID.Properties.NullText = "";
            this.fld_lkeFK_ACLoanAgreementID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACLoanAgreementID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACLoanAgreementID.Properties.ValueMember = "ACLoanAgreementID";
            this.fld_lkeFK_ACLoanAgreementID.Screen = null;
            this.fld_lkeFK_ACLoanAgreementID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACLoanAgreementID.TabIndex = 1;
            this.fld_lkeFK_ACLoanAgreementID.Tag = "DC";
            this.fld_lkeFK_ACLoanAgreementID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_ACLoanAgreementID_QueryPopUp);
            this.fld_lkeFK_ACLoanAgreementID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACLoanAgreementID_CloseUp);
            // 
            // fld_dteACLoanReceiptDate
            // 
            this.fld_dteACLoanReceiptDate.BOSComment = "";
            this.fld_dteACLoanReceiptDate.BOSDataMember = "ACLoanReceiptDate";
            this.fld_dteACLoanReceiptDate.BOSDataSource = "ACLoanReceipts";
            this.fld_dteACLoanReceiptDate.BOSDescription = null;
            this.fld_dteACLoanReceiptDate.BOSError = null;
            this.fld_dteACLoanReceiptDate.BOSFieldGroup = "";
            this.fld_dteACLoanReceiptDate.BOSFieldRelation = "";
            this.fld_dteACLoanReceiptDate.BOSPrivilege = "";
            this.fld_dteACLoanReceiptDate.BOSPropertyName = "EditValue";
            this.fld_dteACLoanReceiptDate.EditValue = null;
            this.fld_dteACLoanReceiptDate.Location = new System.Drawing.Point(673, 8);
            this.fld_dteACLoanReceiptDate.Name = "fld_dteACLoanReceiptDate";
            this.fld_dteACLoanReceiptDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACLoanReceiptDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACLoanReceiptDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACLoanReceiptDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACLoanReceiptDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACLoanReceiptDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACLoanReceiptDate.Screen = null;
            this.fld_dteACLoanReceiptDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACLoanReceiptDate.TabIndex = 9;
            this.fld_dteACLoanReceiptDate.Tag = "DC";
            this.fld_dteACLoanReceiptDate.Validated += new System.EventHandler(this.fld_dteACLoanReceiptDate_Validated);
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = "";
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ACLoanReceipts";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(102, 60);
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
            this.fld_lkeFK_GECurrencyID.TabIndex = 2;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
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
            this.bosLabel3.Location = new System.Drawing.Point(16, 64);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(53, 13);
            this.bosLabel3.TabIndex = 18;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Loại tiền tệ";
            // 
            // fld_txtACLoanReceiptAmount
            // 
            this.fld_txtACLoanReceiptAmount.BOSComment = "";
            this.fld_txtACLoanReceiptAmount.BOSDataMember = "ACLoanReceiptAmount";
            this.fld_txtACLoanReceiptAmount.BOSDataSource = "ACLoanReceipts";
            this.fld_txtACLoanReceiptAmount.BOSDescription = null;
            this.fld_txtACLoanReceiptAmount.BOSError = null;
            this.fld_txtACLoanReceiptAmount.BOSFieldGroup = "";
            this.fld_txtACLoanReceiptAmount.BOSFieldRelation = "";
            this.fld_txtACLoanReceiptAmount.BOSPrivilege = "";
            this.fld_txtACLoanReceiptAmount.BOSPropertyName = "Text";
            this.fld_txtACLoanReceiptAmount.EditValue = "0.00";
            this.fld_txtACLoanReceiptAmount.Location = new System.Drawing.Point(955, 8);
            this.fld_txtACLoanReceiptAmount.Name = "fld_txtACLoanReceiptAmount";
            this.fld_txtACLoanReceiptAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACLoanReceiptAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACLoanReceiptAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACLoanReceiptAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACLoanReceiptAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACLoanReceiptAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACLoanReceiptAmount.Screen = null;
            this.fld_txtACLoanReceiptAmount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACLoanReceiptAmount.TabIndex = 14;
            this.fld_txtACLoanReceiptAmount.Tag = "DC";
            this.fld_txtACLoanReceiptAmount.Validated += new System.EventHandler(this.fld_txtACLoanReceiptAmount_Validated);
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
            this.bosLabel4.Location = new System.Drawing.Point(849, 12);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(75, 13);
            this.bosLabel4.TabIndex = 21;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Số tiền nhận nợ";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel5.Location = new System.Drawing.Point(849, 90);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(65, 13);
            this.bosLabel5.TabIndex = 23;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Số tiền đã trả";
            // 
            // fld_txtACLoanReceiptRemainAmount
            // 
            this.fld_txtACLoanReceiptRemainAmount.BOSComment = "";
            this.fld_txtACLoanReceiptRemainAmount.BOSDataMember = "ACLoanReceiptRemainAmount";
            this.fld_txtACLoanReceiptRemainAmount.BOSDataSource = "ACLoanReceipts";
            this.fld_txtACLoanReceiptRemainAmount.BOSDescription = null;
            this.fld_txtACLoanReceiptRemainAmount.BOSError = null;
            this.fld_txtACLoanReceiptRemainAmount.BOSFieldGroup = "";
            this.fld_txtACLoanReceiptRemainAmount.BOSFieldRelation = "";
            this.fld_txtACLoanReceiptRemainAmount.BOSPrivilege = "";
            this.fld_txtACLoanReceiptRemainAmount.BOSPropertyName = "Text";
            this.fld_txtACLoanReceiptRemainAmount.EditValue = "0.00";
            this.fld_txtACLoanReceiptRemainAmount.Location = new System.Drawing.Point(955, 112);
            this.fld_txtACLoanReceiptRemainAmount.Name = "fld_txtACLoanReceiptRemainAmount";
            this.fld_txtACLoanReceiptRemainAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACLoanReceiptRemainAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACLoanReceiptRemainAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACLoanReceiptRemainAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACLoanReceiptRemainAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACLoanReceiptRemainAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACLoanReceiptRemainAmount.Screen = null;
            this.fld_txtACLoanReceiptRemainAmount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACLoanReceiptRemainAmount.TabIndex = 18;
            this.fld_txtACLoanReceiptRemainAmount.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(849, 116);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(66, 13);
            this.bosLabel6.TabIndex = 25;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Số tiền còn lại";
            // 
            // fld_lblLabel19
            // 
            this.fld_lblLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel19.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel19.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel19.BOSComment = "";
            this.fld_lblLabel19.BOSDataMember = "";
            this.fld_lblLabel19.BOSDataSource = "";
            this.fld_lblLabel19.BOSDescription = null;
            this.fld_lblLabel19.BOSError = null;
            this.fld_lblLabel19.BOSFieldGroup = "";
            this.fld_lblLabel19.BOSFieldRelation = "";
            this.fld_lblLabel19.BOSPrivilege = "";
            this.fld_lblLabel19.BOSPropertyName = "";
            this.fld_lblLabel19.Location = new System.Drawing.Point(555, 64);
            this.fld_lblLabel19.Name = "fld_lblLabel19";
            this.fld_lblLabel19.Screen = null;
            this.fld_lblLabel19.Size = new System.Drawing.Size(60, 13);
            this.fld_lblLabel19.TabIndex = 47;
            this.fld_lblLabel19.Tag = "";
            this.fld_lblLabel19.Text = "Lãi suất năm";
            // 
            // fld_txtACLoanReceiptInterestRate
            // 
            this.fld_txtACLoanReceiptInterestRate.BOSComment = "";
            this.fld_txtACLoanReceiptInterestRate.BOSDataMember = "ACLoanReceiptInterestRate";
            this.fld_txtACLoanReceiptInterestRate.BOSDataSource = "ACLoanReceipts";
            this.fld_txtACLoanReceiptInterestRate.BOSDescription = null;
            this.fld_txtACLoanReceiptInterestRate.BOSError = null;
            this.fld_txtACLoanReceiptInterestRate.BOSFieldGroup = "";
            this.fld_txtACLoanReceiptInterestRate.BOSFieldRelation = "";
            this.fld_txtACLoanReceiptInterestRate.BOSPrivilege = "";
            this.fld_txtACLoanReceiptInterestRate.BOSPropertyName = "Text";
            this.fld_txtACLoanReceiptInterestRate.EditValue = "0.00";
            this.fld_txtACLoanReceiptInterestRate.Location = new System.Drawing.Point(673, 60);
            this.fld_txtACLoanReceiptInterestRate.Name = "fld_txtACLoanReceiptInterestRate";
            this.fld_txtACLoanReceiptInterestRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACLoanReceiptInterestRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACLoanReceiptInterestRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACLoanReceiptInterestRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACLoanReceiptInterestRate.Properties.Mask.EditMask = "n";
            this.fld_txtACLoanReceiptInterestRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtACLoanReceiptInterestRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACLoanReceiptInterestRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACLoanReceiptInterestRate.Screen = null;
            this.fld_txtACLoanReceiptInterestRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACLoanReceiptInterestRate.TabIndex = 11;
            this.fld_txtACLoanReceiptInterestRate.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(555, 90);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(79, 13);
            this.bosLabel7.TabIndex = 49;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Lãi suất quá hạn";
            // 
            // fld_txtACLoanReceiptOverdueInterestRate
            // 
            this.fld_txtACLoanReceiptOverdueInterestRate.BOSComment = "";
            this.fld_txtACLoanReceiptOverdueInterestRate.BOSDataMember = "ACLoanReceiptOverdueInterestRate";
            this.fld_txtACLoanReceiptOverdueInterestRate.BOSDataSource = "ACLoanReceipts";
            this.fld_txtACLoanReceiptOverdueInterestRate.BOSDescription = null;
            this.fld_txtACLoanReceiptOverdueInterestRate.BOSError = null;
            this.fld_txtACLoanReceiptOverdueInterestRate.BOSFieldGroup = "";
            this.fld_txtACLoanReceiptOverdueInterestRate.BOSFieldRelation = "";
            this.fld_txtACLoanReceiptOverdueInterestRate.BOSPrivilege = "";
            this.fld_txtACLoanReceiptOverdueInterestRate.BOSPropertyName = "Text";
            this.fld_txtACLoanReceiptOverdueInterestRate.EditValue = "0.00";
            this.fld_txtACLoanReceiptOverdueInterestRate.Location = new System.Drawing.Point(673, 86);
            this.fld_txtACLoanReceiptOverdueInterestRate.Name = "fld_txtACLoanReceiptOverdueInterestRate";
            this.fld_txtACLoanReceiptOverdueInterestRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACLoanReceiptOverdueInterestRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACLoanReceiptOverdueInterestRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACLoanReceiptOverdueInterestRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACLoanReceiptOverdueInterestRate.Properties.Mask.EditMask = "n";
            this.fld_txtACLoanReceiptOverdueInterestRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtACLoanReceiptOverdueInterestRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACLoanReceiptOverdueInterestRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACLoanReceiptOverdueInterestRate.Screen = null;
            this.fld_txtACLoanReceiptOverdueInterestRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACLoanReceiptOverdueInterestRate.TabIndex = 12;
            this.fld_txtACLoanReceiptOverdueInterestRate.Tag = "DC";
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
            this.fld_lblLabel6.Location = new System.Drawing.Point(16, 116);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(42, 13);
            this.fld_lblLabel6.TabIndex = 51;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Nội dung";
            // 
            // fld_medACLoanReceiptContent
            // 
            this.fld_medACLoanReceiptContent.BOSComment = "";
            this.fld_medACLoanReceiptContent.BOSDataMember = "ACLoanReceiptContent";
            this.fld_medACLoanReceiptContent.BOSDataSource = "ACLoanReceipts";
            this.fld_medACLoanReceiptContent.BOSDescription = null;
            this.fld_medACLoanReceiptContent.BOSError = null;
            this.fld_medACLoanReceiptContent.BOSFieldGroup = "";
            this.fld_medACLoanReceiptContent.BOSFieldRelation = "";
            this.fld_medACLoanReceiptContent.BOSPrivilege = "";
            this.fld_medACLoanReceiptContent.BOSPropertyName = "Text";
            this.fld_medACLoanReceiptContent.EditValue = "";
            this.fld_medACLoanReceiptContent.Location = new System.Drawing.Point(102, 112);
            this.fld_medACLoanReceiptContent.Name = "fld_medACLoanReceiptContent";
            this.fld_medACLoanReceiptContent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACLoanReceiptContent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACLoanReceiptContent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACLoanReceiptContent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACLoanReceiptContent.Screen = null;
            this.fld_medACLoanReceiptContent.Size = new System.Drawing.Size(430, 46);
            this.fld_medACLoanReceiptContent.TabIndex = 4;
            this.fld_medACLoanReceiptContent.Tag = "DC";
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
            this.bosTabControl1.Location = new System.Drawing.Point(7, 164);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.ScreenHelper.SetShowHelp(this.bosTabControl1, true);
            this.bosTabControl1.Size = new System.Drawing.Size(1116, 481);
            this.bosTabControl1.TabIndex = 19;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage3,
            this.xtraTabPage2,
            this.xtraTabPage4});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_btnACDocument);
            this.xtraTabPage1.Controls.Add(this.fld_dgcACLoanReceiptItems);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.ScreenHelper.SetShowHelp(this.xtraTabPage1, true);
            this.xtraTabPage1.Size = new System.Drawing.Size(1114, 456);
            this.xtraTabPage1.Text = "Danh sách chứng từ vay";
            // 
            // fld_btnACDocument
            // 
            this.fld_btnACDocument.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnACDocument.Appearance.Options.UseForeColor = true;
            this.fld_btnACDocument.BOSComment = "";
            this.fld_btnACDocument.BOSDataMember = "";
            this.fld_btnACDocument.BOSDataSource = "";
            this.fld_btnACDocument.BOSDescription = null;
            this.fld_btnACDocument.BOSError = null;
            this.fld_btnACDocument.BOSFieldGroup = "";
            this.fld_btnACDocument.BOSFieldRelation = "";
            this.fld_btnACDocument.BOSPrivilege = "";
            this.fld_btnACDocument.BOSPropertyName = "";
            this.fld_btnACDocument.Location = new System.Drawing.Point(16, 3);
            this.fld_btnACDocument.Name = "fld_btnACDocument";
            this.fld_btnACDocument.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnACDocument, true);
            this.fld_btnACDocument.Size = new System.Drawing.Size(142, 20);
            this.fld_btnACDocument.TabIndex = 0;
            this.fld_btnACDocument.Tag = "";
            this.fld_btnACDocument.Text = "Danh sách chứng từ vay";
            this.fld_btnACDocument.Click += new System.EventHandler(this.fld_btnACDocument_Click);
            // 
            // fld_dgcACLoanReceiptItems
            // 
            this.fld_dgcACLoanReceiptItems.AllowDrop = true;
            this.fld_dgcACLoanReceiptItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACLoanReceiptItems.BOSComment = "";
            this.fld_dgcACLoanReceiptItems.BOSDataMember = "";
            this.fld_dgcACLoanReceiptItems.BOSDataSource = "ACLoanReceiptItems";
            this.fld_dgcACLoanReceiptItems.BOSDescription = null;
            this.fld_dgcACLoanReceiptItems.BOSError = null;
            this.fld_dgcACLoanReceiptItems.BOSFieldGroup = "";
            this.fld_dgcACLoanReceiptItems.BOSFieldRelation = "";
            this.fld_dgcACLoanReceiptItems.BOSGridType = null;
            this.fld_dgcACLoanReceiptItems.BOSPrivilege = "";
            this.fld_dgcACLoanReceiptItems.BOSPropertyName = "";
            this.fld_dgcACLoanReceiptItems.CommodityType = "";
            this.fld_dgcACLoanReceiptItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACLoanReceiptItems.Location = new System.Drawing.Point(4, 25);
            this.fld_dgcACLoanReceiptItems.MainView = this.fld_dgvAPPurchaseOrderItems;
            this.fld_dgcACLoanReceiptItems.Name = "fld_dgcACLoanReceiptItems";
            this.fld_dgcACLoanReceiptItems.PrintReport = false;
            this.fld_dgcACLoanReceiptItems.Screen = null;
            this.fld_dgcACLoanReceiptItems.Size = new System.Drawing.Size(1107, 427);
            this.fld_dgcACLoanReceiptItems.TabIndex = 1;
            this.fld_dgcACLoanReceiptItems.Tag = "DC";
            this.fld_dgcACLoanReceiptItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPPurchaseOrderItems});
            // 
            // fld_dgvAPPurchaseOrderItems
            // 
            this.fld_dgvAPPurchaseOrderItems.GridControl = this.fld_dgcACLoanReceiptItems;
            this.fld_dgvAPPurchaseOrderItems.Name = "fld_dgvAPPurchaseOrderItems";
            this.fld_dgvAPPurchaseOrderItems.PaintStyleName = "Office2003";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcACLoanReceiptPayDocs);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.ScreenHelper.SetShowHelp(this.xtraTabPage3, true);
            this.xtraTabPage3.Size = new System.Drawing.Size(900, 423);
            this.xtraTabPage3.Text = "Danh sách chứng từ trả";
            // 
            // fld_dgcACLoanReceiptPayDocs
            // 
            this.fld_dgcACLoanReceiptPayDocs.AllowDrop = true;
            this.fld_dgcACLoanReceiptPayDocs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACLoanReceiptPayDocs.BOSComment = "";
            this.fld_dgcACLoanReceiptPayDocs.BOSDataMember = "";
            this.fld_dgcACLoanReceiptPayDocs.BOSDataSource = "ACLoanReceiptPayDocs";
            this.fld_dgcACLoanReceiptPayDocs.BOSDescription = "";
            this.fld_dgcACLoanReceiptPayDocs.BOSError = null;
            this.fld_dgcACLoanReceiptPayDocs.BOSFieldGroup = "";
            this.fld_dgcACLoanReceiptPayDocs.BOSFieldRelation = "";
            this.fld_dgcACLoanReceiptPayDocs.BOSGridType = null;
            this.fld_dgcACLoanReceiptPayDocs.BOSPrivilege = "";
            this.fld_dgcACLoanReceiptPayDocs.BOSPropertyName = "";
            this.fld_dgcACLoanReceiptPayDocs.CommodityType = "";
            this.fld_dgcACLoanReceiptPayDocs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACLoanReceiptPayDocs.Location = new System.Drawing.Point(6, 3);
            this.fld_dgcACLoanReceiptPayDocs.MainView = this.gridView1;
            this.fld_dgcACLoanReceiptPayDocs.Name = "fld_dgcACLoanReceiptPayDocs";
            this.fld_dgcACLoanReceiptPayDocs.PrintReport = false;
            this.fld_dgcACLoanReceiptPayDocs.Screen = null;
            this.fld_dgcACLoanReceiptPayDocs.Size = new System.Drawing.Size(892, 417);
            this.fld_dgcACLoanReceiptPayDocs.TabIndex = 11;
            this.fld_dgcACLoanReceiptPayDocs.Tag = "DC";
            this.fld_dgcACLoanReceiptPayDocs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcACLoanReceiptPayDocs;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_btnCreatePaymentPlans);
            this.xtraTabPage2.Controls.Add(this.fld_dgcACLoanReceiptPaymentPlans);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(900, 423);
            this.xtraTabPage2.Text = "Kế hoạch trả tiền lãi vay và nợ gốc";
            // 
            // fld_btnCreatePaymentPlans
            // 
            this.fld_btnCreatePaymentPlans.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnCreatePaymentPlans.Appearance.Options.UseForeColor = true;
            this.fld_btnCreatePaymentPlans.BOSComment = "";
            this.fld_btnCreatePaymentPlans.BOSDataMember = "";
            this.fld_btnCreatePaymentPlans.BOSDataSource = "";
            this.fld_btnCreatePaymentPlans.BOSDescription = null;
            this.fld_btnCreatePaymentPlans.BOSError = null;
            this.fld_btnCreatePaymentPlans.BOSFieldGroup = "";
            this.fld_btnCreatePaymentPlans.BOSFieldRelation = "";
            this.fld_btnCreatePaymentPlans.BOSPrivilege = "";
            this.fld_btnCreatePaymentPlans.BOSPropertyName = "";
            this.fld_btnCreatePaymentPlans.Location = new System.Drawing.Point(9, 3);
            this.fld_btnCreatePaymentPlans.Name = "fld_btnCreatePaymentPlans";
            this.fld_btnCreatePaymentPlans.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnCreatePaymentPlans, true);
            this.fld_btnCreatePaymentPlans.Size = new System.Drawing.Size(101, 20);
            this.fld_btnCreatePaymentPlans.TabIndex = 14;
            this.fld_btnCreatePaymentPlans.Tag = "";
            this.fld_btnCreatePaymentPlans.Text = "Tạo kế hoạch trả";
            this.fld_btnCreatePaymentPlans.Click += new System.EventHandler(this.fld_btnCreatePaymentPlans_Click);
            // 
            // fld_dgcACLoanReceiptPaymentPlans
            // 
            this.fld_dgcACLoanReceiptPaymentPlans.AllowDrop = true;
            this.fld_dgcACLoanReceiptPaymentPlans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACLoanReceiptPaymentPlans.BOSComment = "";
            this.fld_dgcACLoanReceiptPaymentPlans.BOSDataMember = "";
            this.fld_dgcACLoanReceiptPaymentPlans.BOSDataSource = "ACLoanReceiptPaymentPlans";
            this.fld_dgcACLoanReceiptPaymentPlans.BOSDescription = "";
            this.fld_dgcACLoanReceiptPaymentPlans.BOSError = null;
            this.fld_dgcACLoanReceiptPaymentPlans.BOSFieldGroup = "";
            this.fld_dgcACLoanReceiptPaymentPlans.BOSFieldRelation = "";
            this.fld_dgcACLoanReceiptPaymentPlans.BOSGridType = null;
            this.fld_dgcACLoanReceiptPaymentPlans.BOSPrivilege = "";
            this.fld_dgcACLoanReceiptPaymentPlans.BOSPropertyName = "";
            this.fld_dgcACLoanReceiptPaymentPlans.CommodityType = "";
            this.fld_dgcACLoanReceiptPaymentPlans.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACLoanReceiptPaymentPlans.Location = new System.Drawing.Point(4, 29);
            this.fld_dgcACLoanReceiptPaymentPlans.MainView = this.gridView3;
            this.fld_dgcACLoanReceiptPaymentPlans.Name = "fld_dgcACLoanReceiptPaymentPlans";
            this.fld_dgcACLoanReceiptPaymentPlans.PrintReport = false;
            this.fld_dgcACLoanReceiptPaymentPlans.Screen = null;
            this.fld_dgcACLoanReceiptPaymentPlans.Size = new System.Drawing.Size(892, 390);
            this.fld_dgcACLoanReceiptPaymentPlans.TabIndex = 13;
            this.fld_dgcACLoanReceiptPaymentPlans.Tag = "DC";
            this.fld_dgcACLoanReceiptPaymentPlans.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcACLoanReceiptPaymentPlans;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.fld_dgcACLoanReceiptInterestRateChanges);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(900, 423);
            this.xtraTabPage4.Text = "Thay đổi lãi suất";
            // 
            // fld_dgcACLoanReceiptInterestRateChanges
            // 
            this.fld_dgcACLoanReceiptInterestRateChanges.AllowDrop = true;
            this.fld_dgcACLoanReceiptInterestRateChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACLoanReceiptInterestRateChanges.BOSComment = "";
            this.fld_dgcACLoanReceiptInterestRateChanges.BOSDataMember = "";
            this.fld_dgcACLoanReceiptInterestRateChanges.BOSDataSource = "ACLoanReceiptInterestRateChanges";
            this.fld_dgcACLoanReceiptInterestRateChanges.BOSDescription = "";
            this.fld_dgcACLoanReceiptInterestRateChanges.BOSError = null;
            this.fld_dgcACLoanReceiptInterestRateChanges.BOSFieldGroup = "";
            this.fld_dgcACLoanReceiptInterestRateChanges.BOSFieldRelation = "";
            this.fld_dgcACLoanReceiptInterestRateChanges.BOSGridType = null;
            this.fld_dgcACLoanReceiptInterestRateChanges.BOSPrivilege = "";
            this.fld_dgcACLoanReceiptInterestRateChanges.BOSPropertyName = "";
            this.fld_dgcACLoanReceiptInterestRateChanges.CommodityType = "";
            this.fld_dgcACLoanReceiptInterestRateChanges.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACLoanReceiptInterestRateChanges.Location = new System.Drawing.Point(4, 3);
            this.fld_dgcACLoanReceiptInterestRateChanges.MainView = this.gridView4;
            this.fld_dgcACLoanReceiptInterestRateChanges.Name = "fld_dgcACLoanReceiptInterestRateChanges";
            this.fld_dgcACLoanReceiptInterestRateChanges.PrintReport = false;
            this.fld_dgcACLoanReceiptInterestRateChanges.Screen = null;
            this.fld_dgcACLoanReceiptInterestRateChanges.Size = new System.Drawing.Size(892, 416);
            this.fld_dgcACLoanReceiptInterestRateChanges.TabIndex = 14;
            this.fld_dgcACLoanReceiptInterestRateChanges.Tag = "DC";
            this.fld_dgcACLoanReceiptInterestRateChanges.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.fld_dgcACLoanReceiptInterestRateChanges;
            this.gridView4.Name = "gridView4";
            this.gridView4.PaintStyleName = "Office2003";
            // 
            // fld_txtACLoanReceiptExchangeRate
            // 
            this.fld_txtACLoanReceiptExchangeRate.BOSComment = null;
            this.fld_txtACLoanReceiptExchangeRate.BOSDataMember = "ACLoanReceiptExchangeRate";
            this.fld_txtACLoanReceiptExchangeRate.BOSDataSource = "ACLoanReceipts";
            this.fld_txtACLoanReceiptExchangeRate.BOSDescription = null;
            this.fld_txtACLoanReceiptExchangeRate.BOSError = null;
            this.fld_txtACLoanReceiptExchangeRate.BOSFieldGroup = null;
            this.fld_txtACLoanReceiptExchangeRate.BOSFieldRelation = null;
            this.fld_txtACLoanReceiptExchangeRate.BOSPrivilege = null;
            this.fld_txtACLoanReceiptExchangeRate.BOSPropertyName = "EditValue";
            this.fld_txtACLoanReceiptExchangeRate.Location = new System.Drawing.Point(382, 60);
            this.fld_txtACLoanReceiptExchangeRate.Name = "fld_txtACLoanReceiptExchangeRate";
            this.fld_txtACLoanReceiptExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtACLoanReceiptExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACLoanReceiptExchangeRate.Screen = null;
            this.fld_txtACLoanReceiptExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACLoanReceiptExchangeRate.TabIndex = 7;
            this.fld_txtACLoanReceiptExchangeRate.Tag = "DC";
            this.fld_txtACLoanReceiptExchangeRate.Validated += new System.EventHandler(this.fld_txtACLoanReceiptExchangeRate_Validated);
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(267, 64);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(29, 13);
            this.bosLabel12.TabIndex = 74;
            this.bosLabel12.Text = "Tỷ giá";
            // 
            // fld_txtACLoanReceiptExchangeAmount
            // 
            this.fld_txtACLoanReceiptExchangeAmount.BOSComment = "";
            this.fld_txtACLoanReceiptExchangeAmount.BOSDataMember = "ACLoanReceiptExchangeAmount";
            this.fld_txtACLoanReceiptExchangeAmount.BOSDataSource = "ACLoanReceipts";
            this.fld_txtACLoanReceiptExchangeAmount.BOSDescription = null;
            this.fld_txtACLoanReceiptExchangeAmount.BOSError = null;
            this.fld_txtACLoanReceiptExchangeAmount.BOSFieldGroup = "";
            this.fld_txtACLoanReceiptExchangeAmount.BOSFieldRelation = "";
            this.fld_txtACLoanReceiptExchangeAmount.BOSPrivilege = "";
            this.fld_txtACLoanReceiptExchangeAmount.BOSPropertyName = "Text";
            this.fld_txtACLoanReceiptExchangeAmount.EditValue = "0.00";
            this.fld_txtACLoanReceiptExchangeAmount.Location = new System.Drawing.Point(955, 34);
            this.fld_txtACLoanReceiptExchangeAmount.Name = "fld_txtACLoanReceiptExchangeAmount";
            this.fld_txtACLoanReceiptExchangeAmount.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtACLoanReceiptExchangeAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACLoanReceiptExchangeAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACLoanReceiptExchangeAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACLoanReceiptExchangeAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACLoanReceiptExchangeAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACLoanReceiptExchangeAmount.Screen = null;
            this.fld_txtACLoanReceiptExchangeAmount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACLoanReceiptExchangeAmount.TabIndex = 15;
            this.fld_txtACLoanReceiptExchangeAmount.Tag = "DC";
            this.fld_txtACLoanReceiptExchangeAmount.Validated += new System.EventHandler(this.fld_txtACLoanReceiptExchangeAmount_Validated);
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
            this.bosLabel2.Location = new System.Drawing.Point(849, 38);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(71, 13);
            this.bosLabel2.TabIndex = 76;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Số tiền quy đổi";
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
            this.bosLabel8.Location = new System.Drawing.Point(267, 12);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(60, 13);
            this.bosLabel8.TabIndex = 78;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Loại khế ước";
            // 
            // bosLabel27
            // 
            this.bosLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.Options.UseBackColor = true;
            this.bosLabel27.Appearance.Options.UseForeColor = true;
            this.bosLabel27.BOSComment = null;
            this.bosLabel27.BOSDataMember = null;
            this.bosLabel27.BOSDataSource = null;
            this.bosLabel27.BOSDescription = null;
            this.bosLabel27.BOSError = null;
            this.bosLabel27.BOSFieldGroup = null;
            this.bosLabel27.BOSFieldRelation = null;
            this.bosLabel27.BOSPrivilege = null;
            this.bosLabel27.BOSPropertyName = null;
            this.bosLabel27.Location = new System.Drawing.Point(267, 38);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel27, true);
            this.bosLabel27.Size = new System.Drawing.Size(83, 13);
            this.bosLabel27.TabIndex = 550;
            this.bosLabel27.Text = "Cách thức tính lãi";
            // 
            // fld_lkeACLoanReceiptProfitMethod
            // 
            this.fld_lkeACLoanReceiptProfitMethod.BOSAllowAddNew = false;
            this.fld_lkeACLoanReceiptProfitMethod.BOSAllowDummy = false;
            this.fld_lkeACLoanReceiptProfitMethod.BOSComment = null;
            this.fld_lkeACLoanReceiptProfitMethod.BOSDataMember = "ACLoanReceiptProfitMethod";
            this.fld_lkeACLoanReceiptProfitMethod.BOSDataSource = "ACLoanReceipts";
            this.fld_lkeACLoanReceiptProfitMethod.BOSDescription = null;
            this.fld_lkeACLoanReceiptProfitMethod.BOSError = null;
            this.fld_lkeACLoanReceiptProfitMethod.BOSFieldGroup = null;
            this.fld_lkeACLoanReceiptProfitMethod.BOSFieldParent = null;
            this.fld_lkeACLoanReceiptProfitMethod.BOSFieldRelation = null;
            this.fld_lkeACLoanReceiptProfitMethod.BOSPrivilege = null;
            this.fld_lkeACLoanReceiptProfitMethod.BOSPropertyName = "EditValue";
            this.fld_lkeACLoanReceiptProfitMethod.BOSSelectType = "";
            this.fld_lkeACLoanReceiptProfitMethod.BOSSelectTypeValue = "";
            this.fld_lkeACLoanReceiptProfitMethod.CurrentDisplayText = null;
            this.fld_lkeACLoanReceiptProfitMethod.Location = new System.Drawing.Point(382, 34);
            this.fld_lkeACLoanReceiptProfitMethod.Name = "fld_lkeACLoanReceiptProfitMethod";
            this.fld_lkeACLoanReceiptProfitMethod.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACLoanReceiptProfitMethod.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACLoanReceiptProfitMethod.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACLoanReceiptProfitMethod.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACLoanReceiptProfitMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACLoanReceiptProfitMethod.Properties.ColumnName = null;
            this.fld_lkeACLoanReceiptProfitMethod.Properties.NullText = "";
            this.fld_lkeACLoanReceiptProfitMethod.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACLoanReceiptProfitMethod.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeACLoanReceiptProfitMethod, true);
            this.fld_lkeACLoanReceiptProfitMethod.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACLoanReceiptProfitMethod.TabIndex = 6;
            this.fld_lkeACLoanReceiptProfitMethod.Tag = "DC";
            this.fld_lkeACLoanReceiptProfitMethod.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeACLoanReceiptProfitMethod_CloseUp);
            // 
            // fld_txtACLoanReceiptLimit
            // 
            this.fld_txtACLoanReceiptLimit.BOSComment = "";
            this.fld_txtACLoanReceiptLimit.BOSDataMember = "ACLoanReceiptLimit";
            this.fld_txtACLoanReceiptLimit.BOSDataSource = "ACLoanReceipts";
            this.fld_txtACLoanReceiptLimit.BOSDescription = null;
            this.fld_txtACLoanReceiptLimit.BOSError = null;
            this.fld_txtACLoanReceiptLimit.BOSFieldGroup = "";
            this.fld_txtACLoanReceiptLimit.BOSFieldRelation = "";
            this.fld_txtACLoanReceiptLimit.BOSPrivilege = "";
            this.fld_txtACLoanReceiptLimit.BOSPropertyName = "Text";
            this.fld_txtACLoanReceiptLimit.EditValue = "0.00";
            this.fld_txtACLoanReceiptLimit.Location = new System.Drawing.Point(102, 86);
            this.fld_txtACLoanReceiptLimit.Name = "fld_txtACLoanReceiptLimit";
            this.fld_txtACLoanReceiptLimit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACLoanReceiptLimit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACLoanReceiptLimit.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACLoanReceiptLimit.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACLoanReceiptLimit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACLoanReceiptLimit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACLoanReceiptLimit.Screen = null;
            this.fld_txtACLoanReceiptLimit.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACLoanReceiptLimit.TabIndex = 3;
            this.fld_txtACLoanReceiptLimit.Tag = "DC";
            this.fld_txtACLoanReceiptLimit.Validated += new System.EventHandler(this.fld_txtACLoanReceiptLimit_Validated);
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
            this.bosLabel9.Location = new System.Drawing.Point(16, 90);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(33, 13);
            this.bosLabel9.TabIndex = 552;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Kỳ hạn";
            // 
            // fld_lkeFK_ACLoanReceiptTypeID
            // 
            this.fld_lkeFK_ACLoanReceiptTypeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACLoanReceiptTypeID.BOSAllowDummy = true;
            this.fld_lkeFK_ACLoanReceiptTypeID.BOSComment = "";
            this.fld_lkeFK_ACLoanReceiptTypeID.BOSDataMember = "FK_ACLoanReceiptTypeID";
            this.fld_lkeFK_ACLoanReceiptTypeID.BOSDataSource = "ACLoanReceipts";
            this.fld_lkeFK_ACLoanReceiptTypeID.BOSDescription = null;
            this.fld_lkeFK_ACLoanReceiptTypeID.BOSError = null;
            this.fld_lkeFK_ACLoanReceiptTypeID.BOSFieldGroup = "";
            this.fld_lkeFK_ACLoanReceiptTypeID.BOSFieldParent = "";
            this.fld_lkeFK_ACLoanReceiptTypeID.BOSFieldRelation = "";
            this.fld_lkeFK_ACLoanReceiptTypeID.BOSPrivilege = "";
            this.fld_lkeFK_ACLoanReceiptTypeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACLoanReceiptTypeID.BOSSelectType = "";
            this.fld_lkeFK_ACLoanReceiptTypeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACLoanReceiptTypeID.CurrentDisplayText = null;
            this.fld_lkeFK_ACLoanReceiptTypeID.Location = new System.Drawing.Point(382, 8);
            this.fld_lkeFK_ACLoanReceiptTypeID.Name = "fld_lkeFK_ACLoanReceiptTypeID";
            this.fld_lkeFK_ACLoanReceiptTypeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACLoanReceiptTypeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACLoanReceiptTypeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACLoanReceiptTypeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACLoanReceiptTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACLoanReceiptTypeID.Properties.ColumnName = null;
            this.fld_lkeFK_ACLoanReceiptTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACLoanReceiptTypeNanme", "Loại khế ước")});
            this.fld_lkeFK_ACLoanReceiptTypeID.Properties.DisplayMember = "ACLoanReceiptTypeNanme";
            this.fld_lkeFK_ACLoanReceiptTypeID.Properties.NullText = "";
            this.fld_lkeFK_ACLoanReceiptTypeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACLoanReceiptTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACLoanReceiptTypeID.Properties.ValueMember = "ACLoanReceiptTypeID";
            this.fld_lkeFK_ACLoanReceiptTypeID.Screen = null;
            this.fld_lkeFK_ACLoanReceiptTypeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACLoanReceiptTypeID.TabIndex = 5;
            this.fld_lkeFK_ACLoanReceiptTypeID.Tag = "DC";
            // 
            // bosButton1
            // 
            this.bosButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosButton1.Appearance.Options.UseForeColor = true;
            this.bosButton1.BOSComment = "";
            this.bosButton1.BOSDataMember = "";
            this.bosButton1.BOSDataSource = "";
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = "";
            this.bosButton1.BOSFieldRelation = "";
            this.bosButton1.BOSPrivilege = "";
            this.bosButton1.BOSPropertyName = "";
            this.bosButton1.Location = new System.Drawing.Point(103, 3);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosButton1, true);
            this.bosButton1.Size = new System.Drawing.Size(101, 20);
            this.bosButton1.TabIndex = 12;
            this.bosButton1.Tag = "";
            this.bosButton1.Text = "Ủy nhiệm chi";
            // 
            // loanReceiptPayDocsGridControl1
            // 
            this.loanReceiptPayDocsGridControl1.AllowDrop = true;
            this.loanReceiptPayDocsGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loanReceiptPayDocsGridControl1.BOSComment = "";
            this.loanReceiptPayDocsGridControl1.BOSDataMember = "";
            this.loanReceiptPayDocsGridControl1.BOSDataSource = "ACLoanReceiptPayDocs";
            this.loanReceiptPayDocsGridControl1.BOSDescription = "";
            this.loanReceiptPayDocsGridControl1.BOSError = null;
            this.loanReceiptPayDocsGridControl1.BOSFieldGroup = "";
            this.loanReceiptPayDocsGridControl1.BOSFieldRelation = "";
            this.loanReceiptPayDocsGridControl1.BOSGridType = null;
            this.loanReceiptPayDocsGridControl1.BOSPrivilege = "";
            this.loanReceiptPayDocsGridControl1.BOSPropertyName = "";
            this.loanReceiptPayDocsGridControl1.CommodityType = "";
            this.loanReceiptPayDocsGridControl1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.loanReceiptPayDocsGridControl1.Location = new System.Drawing.Point(6, 25);
            this.loanReceiptPayDocsGridControl1.MainView = this.gridView2;
            this.loanReceiptPayDocsGridControl1.Name = "loanReceiptPayDocsGridControl1";
            this.loanReceiptPayDocsGridControl1.PrintReport = false;
            this.loanReceiptPayDocsGridControl1.Screen = null;
            this.loanReceiptPayDocsGridControl1.Size = new System.Drawing.Size(840, 324);
            this.loanReceiptPayDocsGridControl1.TabIndex = 11;
            this.loanReceiptPayDocsGridControl1.Tag = "DC";
            this.loanReceiptPayDocsGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.loanReceiptPayDocsGridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // bosButton2
            // 
            this.bosButton2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosButton2.Appearance.Options.UseForeColor = true;
            this.bosButton2.BOSComment = "";
            this.bosButton2.BOSDataMember = "";
            this.bosButton2.BOSDataSource = "";
            this.bosButton2.BOSDescription = null;
            this.bosButton2.BOSError = null;
            this.bosButton2.BOSFieldGroup = "";
            this.bosButton2.BOSFieldRelation = "";
            this.bosButton2.BOSPrivilege = "";
            this.bosButton2.BOSPropertyName = "";
            this.bosButton2.Location = new System.Drawing.Point(9, 3);
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosButton2, true);
            this.bosButton2.Size = new System.Drawing.Size(88, 20);
            this.bosButton2.TabIndex = 2;
            this.bosButton2.Tag = "";
            this.bosButton2.Text = "Phiếu chi";
            // 
            // panel1
            // 
            this.panel1.BOSComment = null;
            this.panel1.BOSDataMember = null;
            this.panel1.BOSDataSource = null;
            this.panel1.BOSDescription = null;
            this.panel1.BOSError = null;
            this.panel1.BOSFieldGroup = null;
            this.panel1.BOSFieldRelation = null;
            this.panel1.BOSPrivilege = null;
            this.panel1.BOSPropertyName = null;
            this.panel1.Controls.Add(this.fld_txtACLoanReceiptNoOfBank);
            this.panel1.Controls.Add(this.fld_lblLabelNoOfBank);
            this.panel1.Controls.Add(this.fld_txtACLoanReceiptPaidAmount);
            this.panel1.Controls.Add(this.bosLabel11);
            this.panel1.Controls.Add(this.fld_txtACLoanReceiptOpeningPaidAmount);
            this.panel1.Controls.Add(this.fld_txtACLoanReceiptPaymentForMonth);
            this.panel1.Controls.Add(this.bosLabel10);
            this.panel1.Controls.Add(this.bosTabControl1);
            this.panel1.Controls.Add(this.bosLabel7);
            this.panel1.Controls.Add(this.fld_lkeFK_ACLoanReceiptTypeID);
            this.panel1.Controls.Add(this.fld_txtACLoanReceiptOverdueInterestRate);
            this.panel1.Controls.Add(this.bosLabel3);
            this.panel1.Controls.Add(this.fld_lblLabel19);
            this.panel1.Controls.Add(this.fld_txtACLoanReceiptLimit);
            this.panel1.Controls.Add(this.fld_txtACLoanReceiptInterestRate);
            this.panel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.panel1.Controls.Add(this.fld_dteACLoanReceiptDate);
            this.panel1.Controls.Add(this.bosLabel9);
            this.panel1.Controls.Add(this.fld_lblLabel1);
            this.panel1.Controls.Add(this.bosLabel4);
            this.panel1.Controls.Add(this.fld_lkeFK_ACLoanAgreementID);
            this.panel1.Controls.Add(this.bosLabel27);
            this.panel1.Controls.Add(this.fld_dteACLoanReceiptDeadline);
            this.panel1.Controls.Add(this.fld_txtACLoanReceiptAmount);
            this.panel1.Controls.Add(this.bosLabel1);
            this.panel1.Controls.Add(this.fld_lkeACLoanReceiptProfitMethod);
            this.panel1.Controls.Add(this.fld_lblLabel5);
            this.panel1.Controls.Add(this.bosLabel5);
            this.panel1.Controls.Add(this.fld_txtACLoanReceiptNo);
            this.panel1.Controls.Add(this.bosLabel8);
            this.panel1.Controls.Add(this.fld_lblLabel4);
            this.panel1.Controls.Add(this.fld_txtACLoanReceiptExchangeAmount);
            this.panel1.Controls.Add(this.bosLabel6);
            this.panel1.Controls.Add(this.bosLabel2);
            this.panel1.Controls.Add(this.fld_txtACLoanReceiptRemainAmount);
            this.panel1.Controls.Add(this.fld_txtACLoanReceiptExchangeRate);
            this.panel1.Controls.Add(this.fld_medACLoanReceiptContent);
            this.panel1.Controls.Add(this.bosLabel12);
            this.panel1.Controls.Add(this.fld_lblLabel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Screen = null;
            this.panel1.Size = new System.Drawing.Size(1126, 648);
            this.panel1.TabIndex = 0;
            // 
            // fld_txtACLoanReceiptPaidAmount
            // 
            this.fld_txtACLoanReceiptPaidAmount.BOSComment = "";
            this.fld_txtACLoanReceiptPaidAmount.BOSDataMember = "ACLoanReceiptPaidAmount";
            this.fld_txtACLoanReceiptPaidAmount.BOSDataSource = "ACLoanReceipts";
            this.fld_txtACLoanReceiptPaidAmount.BOSDescription = null;
            this.fld_txtACLoanReceiptPaidAmount.BOSError = null;
            this.fld_txtACLoanReceiptPaidAmount.BOSFieldGroup = "";
            this.fld_txtACLoanReceiptPaidAmount.BOSFieldRelation = "";
            this.fld_txtACLoanReceiptPaidAmount.BOSPrivilege = "";
            this.fld_txtACLoanReceiptPaidAmount.BOSPropertyName = "Text";
            this.fld_txtACLoanReceiptPaidAmount.EditValue = "0.00";
            this.fld_txtACLoanReceiptPaidAmount.Location = new System.Drawing.Point(955, 86);
            this.fld_txtACLoanReceiptPaidAmount.Name = "fld_txtACLoanReceiptPaidAmount";
            this.fld_txtACLoanReceiptPaidAmount.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtACLoanReceiptPaidAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACLoanReceiptPaidAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACLoanReceiptPaidAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACLoanReceiptPaidAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACLoanReceiptPaidAmount.Properties.ReadOnly = true;
            this.fld_txtACLoanReceiptPaidAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACLoanReceiptPaidAmount.Screen = null;
            this.fld_txtACLoanReceiptPaidAmount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACLoanReceiptPaidAmount.TabIndex = 17;
            this.fld_txtACLoanReceiptPaidAmount.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel11.BOSPropertyName = "";
            this.bosLabel11.Location = new System.Drawing.Point(849, 64);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(100, 13);
            this.bosLabel11.TabIndex = 556;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Số tiền đã trả đầu kỳ";
            // 
            // fld_txtACLoanReceiptOpeningPaidAmount
            // 
            this.fld_txtACLoanReceiptOpeningPaidAmount.BOSComment = "";
            this.fld_txtACLoanReceiptOpeningPaidAmount.BOSDataMember = "ACLoanReceiptOpeningPaidAmount";
            this.fld_txtACLoanReceiptOpeningPaidAmount.BOSDataSource = "ACLoanReceipts";
            this.fld_txtACLoanReceiptOpeningPaidAmount.BOSDescription = null;
            this.fld_txtACLoanReceiptOpeningPaidAmount.BOSError = null;
            this.fld_txtACLoanReceiptOpeningPaidAmount.BOSFieldGroup = "";
            this.fld_txtACLoanReceiptOpeningPaidAmount.BOSFieldRelation = "";
            this.fld_txtACLoanReceiptOpeningPaidAmount.BOSPrivilege = "";
            this.fld_txtACLoanReceiptOpeningPaidAmount.BOSPropertyName = "Text";
            this.fld_txtACLoanReceiptOpeningPaidAmount.EditValue = "0.00";
            this.fld_txtACLoanReceiptOpeningPaidAmount.Location = new System.Drawing.Point(955, 60);
            this.fld_txtACLoanReceiptOpeningPaidAmount.Name = "fld_txtACLoanReceiptOpeningPaidAmount";
            this.fld_txtACLoanReceiptOpeningPaidAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACLoanReceiptOpeningPaidAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACLoanReceiptOpeningPaidAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACLoanReceiptOpeningPaidAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACLoanReceiptOpeningPaidAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACLoanReceiptOpeningPaidAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACLoanReceiptOpeningPaidAmount.Screen = null;
            this.fld_txtACLoanReceiptOpeningPaidAmount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACLoanReceiptOpeningPaidAmount.TabIndex = 16;
            this.fld_txtACLoanReceiptOpeningPaidAmount.Tag = "DC";
            // 
            // fld_txtACLoanReceiptPaymentForMonth
            // 
            this.fld_txtACLoanReceiptPaymentForMonth.BOSComment = "";
            this.fld_txtACLoanReceiptPaymentForMonth.BOSDataMember = "ACLoanReceiptPaymentForMonth";
            this.fld_txtACLoanReceiptPaymentForMonth.BOSDataSource = "ACLoanReceipts";
            this.fld_txtACLoanReceiptPaymentForMonth.BOSDescription = null;
            this.fld_txtACLoanReceiptPaymentForMonth.BOSError = null;
            this.fld_txtACLoanReceiptPaymentForMonth.BOSFieldGroup = "";
            this.fld_txtACLoanReceiptPaymentForMonth.BOSFieldRelation = "";
            this.fld_txtACLoanReceiptPaymentForMonth.BOSPrivilege = "";
            this.fld_txtACLoanReceiptPaymentForMonth.BOSPropertyName = "Text";
            this.fld_txtACLoanReceiptPaymentForMonth.EditValue = "0.00";
            this.fld_txtACLoanReceiptPaymentForMonth.Location = new System.Drawing.Point(673, 112);
            this.fld_txtACLoanReceiptPaymentForMonth.Name = "fld_txtACLoanReceiptPaymentForMonth";
            this.fld_txtACLoanReceiptPaymentForMonth.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACLoanReceiptPaymentForMonth.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACLoanReceiptPaymentForMonth.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACLoanReceiptPaymentForMonth.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACLoanReceiptPaymentForMonth.Properties.Mask.EditMask = "n2";
            this.fld_txtACLoanReceiptPaymentForMonth.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtACLoanReceiptPaymentForMonth.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACLoanReceiptPaymentForMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACLoanReceiptPaymentForMonth.Screen = null;
            this.fld_txtACLoanReceiptPaymentForMonth.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACLoanReceiptPaymentForMonth.TabIndex = 13;
            this.fld_txtACLoanReceiptPaymentForMonth.Tag = "DC";
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
            this.bosLabel10.Location = new System.Drawing.Point(555, 116);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(112, 13);
            this.bosLabel10.TabIndex = 554;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Số tiền nộp hàng tháng";
            // 
            // fld_txtACLoanReceiptNoOfBank
            // 
            this.fld_txtACLoanReceiptNoOfBank.BOSComment = "";
            this.fld_txtACLoanReceiptNoOfBank.BOSDataMember = "ACLoanReceiptNoOfBank";
            this.fld_txtACLoanReceiptNoOfBank.BOSDataSource = "ACLoanReceipts";
            this.fld_txtACLoanReceiptNoOfBank.BOSDescription = null;
            this.fld_txtACLoanReceiptNoOfBank.BOSError = null;
            this.fld_txtACLoanReceiptNoOfBank.BOSFieldGroup = "";
            this.fld_txtACLoanReceiptNoOfBank.BOSFieldRelation = "";
            this.fld_txtACLoanReceiptNoOfBank.BOSPrivilege = "";
            this.fld_txtACLoanReceiptNoOfBank.BOSPropertyName = "Text";
            this.fld_txtACLoanReceiptNoOfBank.EditValue = "";
            this.fld_txtACLoanReceiptNoOfBank.Location = new System.Drawing.Point(382, 86);
            this.fld_txtACLoanReceiptNoOfBank.Name = "fld_txtACLoanReceiptNoOfBank";
            this.fld_txtACLoanReceiptNoOfBank.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACLoanReceiptNoOfBank.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACLoanReceiptNoOfBank.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACLoanReceiptNoOfBank.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACLoanReceiptNoOfBank.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACLoanReceiptNoOfBank.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACLoanReceiptNoOfBank.Screen = null;
            this.fld_txtACLoanReceiptNoOfBank.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACLoanReceiptNoOfBank.TabIndex = 8;
            this.fld_txtACLoanReceiptNoOfBank.Tag = "DC";
            // 
            // fld_lblLabelNoOfBank
            // 
            this.fld_lblLabelNoOfBank.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabelNoOfBank.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabelNoOfBank.Appearance.Options.UseBackColor = true;
            this.fld_lblLabelNoOfBank.Appearance.Options.UseForeColor = true;
            this.fld_lblLabelNoOfBank.BOSComment = "";
            this.fld_lblLabelNoOfBank.BOSDataMember = "";
            this.fld_lblLabelNoOfBank.BOSDataSource = "";
            this.fld_lblLabelNoOfBank.BOSDescription = null;
            this.fld_lblLabelNoOfBank.BOSError = null;
            this.fld_lblLabelNoOfBank.BOSFieldGroup = "";
            this.fld_lblLabelNoOfBank.BOSFieldRelation = "";
            this.fld_lblLabelNoOfBank.BOSPrivilege = "";
            this.fld_lblLabelNoOfBank.BOSPropertyName = "";
            this.fld_lblLabelNoOfBank.Location = new System.Drawing.Point(267, 90);
            this.fld_lblLabelNoOfBank.Name = "fld_lblLabelNoOfBank";
            this.fld_lblLabelNoOfBank.Screen = null;
            this.fld_lblLabelNoOfBank.Size = new System.Drawing.Size(109, 13);
            this.fld_lblLabelNoOfBank.TabIndex = 558;
            this.fld_lblLabelNoOfBank.Tag = "";
            this.fld_lblLabelNoOfBank.Text = "Mã khế ước ngân hàng";
            // 
            // DMLRC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1126, 648);
            this.Controls.Add(this.panel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMLRC100.IconOptions.Icon")));
            this.Name = "DMLRC100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACLoanReceiptDeadline.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACLoanReceiptDeadline.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACLoanAgreementID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACLoanReceiptDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACLoanReceiptDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptRemainAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptInterestRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptOverdueInterestRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACLoanReceiptContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACLoanReceiptItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrderItems)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACLoanReceiptPayDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACLoanReceiptPaymentPlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACLoanReceiptInterestRateChanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptExchangeAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACLoanReceiptProfitMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptLimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACLoanReceiptTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanReceiptPayDocsGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptPaidAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptOpeningPaidAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptPaymentForMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACLoanReceiptNoOfBank.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSTextBox fld_txtACLoanReceiptNo;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSDateEdit fld_dteACLoanReceiptDeadline;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel fld_lblLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACLoanAgreementID;
        private BOSComponent.BOSDateEdit fld_dteACLoanReceiptDate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtACLoanReceiptAmount;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtACLoanReceiptRemainAmount;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel fld_lblLabel19;
        private BOSComponent.BOSTextBox fld_txtACLoanReceiptInterestRate;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtACLoanReceiptOverdueInterestRate;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSMemoEdit fld_medACLoanReceiptContent;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSERP.Modules.LoanReceipt.LoanReceiptItemsGridControl fld_dgcACLoanReceiptItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPPurchaseOrderItems;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private BOSERP.Modules.LoanReceipt.LoanReceiptPayDocsGridControl fld_dgcACLoanReceiptPayDocs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSTextBox fld_txtACLoanReceiptExchangeRate;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSTextBox fld_txtACLoanReceiptExchangeAmount;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSLookupEdit fld_lkeACLoanReceiptProfitMethod;
        private BOSComponent.BOSTextBox fld_txtACLoanReceiptLimit;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACLoanReceiptTypeID;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSButton fld_btnCreatePaymentPlans;
        private LoanReceiptPaymentPlansGridControl fld_dgcACLoanReceiptPaymentPlans;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private BOSComponent.BOSButton bosButton1;
        private LoanReceiptPaymentPlansGridControl loanReceiptPayDocsGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSButton bosButton2;
        private BOSComponent.BOSPanel panel1;
        private BOSComponent.BOSTextBox fld_txtACLoanReceiptPaymentForMonth;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSButton fld_btnACDocument;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private ACLoanReceiptInterestRateChangesGridControl fld_dgcACLoanReceiptInterestRateChanges;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox fld_txtACLoanReceiptOpeningPaidAmount;
        private BOSComponent.BOSTextBox fld_txtACLoanReceiptPaidAmount;
        private BOSComponent.BOSTextBox fld_txtACLoanReceiptNoOfBank;
        private BOSComponent.BOSLabel fld_lblLabelNoOfBank;
    }
}
