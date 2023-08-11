using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SupplierPayment.UI
{
    /// <summary>
    /// Summary description for DMAPSP100
    /// </summary>
    partial class DMAPSP100
    {
        private APPaymentProposalPaymentsGridControl fld_dgcAPPaymentProposalPayments;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARInvoiceIns;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMAPSP100));
            this.fld_dgcAPPaymentProposalPayments = new BOSERP.Modules.SupplierPayment.APPaymentProposalPaymentsGridControl();
            this.fld_dgvARInvoiceIns = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel3 = new BOSComponent.BOSPanel(this.components);
            this.bosLine5 = new BOSComponent.BOSLine(this.components);
            this.fld_lkeAPSupplierPaymentBankFeeType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_CSCompanyBankID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteAPSupplierPaymentDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPSupplierPaymentBankFeeAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACLoanReceiptID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPSupplierPaymentNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierPaymentBankAccount = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_txtAPSupplierPaymentExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_CSCashFundID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAssObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_txtAPSupplierPaymentTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPSupplierPaymentStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_medAPSupplierPaymentDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_TabThanhToan = new BOSComponent.BOSTabControl(this.components);
            this.fld_xtrTab1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lkeFK_ACListAccountBankID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPSupplierPaymentReceiverBankName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierPaymentObjectReceiptName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierPaymentReceiverAccount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPSupplierPaymentReceiverBankCode = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_medAPSupplierPaymentReceiptAddress = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_xtrTab2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lkeAPSupplierPaymentAssExchangeWay = new BOSERP.Modules.SupplierPayment.ExchangeWayLookupEdit();
            this.fld_lkeFK_APAssociatedSupplierID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GEAssCurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtAPSupplierPaymentAssTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierPaymentAssExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPSupplierPaymentAssPostingExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel26 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcDocumentEntrys = new BOSERP.Modules.SupplierPayment.DocumentEntryGridControl();
            this.fld_dgvACBankTransactionItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteAPSupplierPaymentEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcAPSupplierPaymentDetails = new BOSERP.APSupplierPaymentDetailsGridControl();
            this.fld_dgvAPDocumentPaymentDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtAPSupplierPaymentProject = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPaymentProposalPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARInvoiceIns)).BeginInit();
            this.bosPanel3.SuspendLayout();
            this.bosLine5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPSupplierPaymentBankFeeType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyBankID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPSupplierPaymentDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPSupplierPaymentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentBankFeeAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACLoanReceiptID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentBankAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCashFundID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAssObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPSupplierPaymentStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPSupplierPaymentDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_TabThanhToan)).BeginInit();
            this.fld_TabThanhToan.SuspendLayout();
            this.fld_xtrTab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACListAccountBankID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentReceiverBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentObjectReceiptName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentReceiverAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentReceiverBankCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPSupplierPaymentReceiptAddress.Properties)).BeginInit();
            this.fld_xtrTab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPSupplierPaymentAssExchangeWay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APAssociatedSupplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEAssCurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentAssTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentAssExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentAssPostingExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACBankTransactionItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPSupplierPaymentEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPSupplierPaymentDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPDocumentPaymentDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentProject.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcAPPaymentProposalPayments
            // 
            this.fld_dgcAPPaymentProposalPayments.AllowDrop = true;
            this.fld_dgcAPPaymentProposalPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPPaymentProposalPayments.BOSComment = "";
            this.fld_dgcAPPaymentProposalPayments.BOSDataMember = "";
            this.fld_dgcAPPaymentProposalPayments.BOSDataSource = "APPaymentProposalPayments";
            this.fld_dgcAPPaymentProposalPayments.BOSDescription = null;
            this.fld_dgcAPPaymentProposalPayments.BOSError = null;
            this.fld_dgcAPPaymentProposalPayments.BOSFieldGroup = "";
            this.fld_dgcAPPaymentProposalPayments.BOSFieldRelation = "";
            this.fld_dgcAPPaymentProposalPayments.BOSGridType = null;
            this.fld_dgcAPPaymentProposalPayments.BOSPrivilege = "";
            this.fld_dgcAPPaymentProposalPayments.BOSPropertyName = "";
            this.fld_dgcAPPaymentProposalPayments.CommodityType = "";
            this.fld_dgcAPPaymentProposalPayments.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPPaymentProposalPayments.Location = new System.Drawing.Point(0, 37);
            this.fld_dgcAPPaymentProposalPayments.MainView = this.fld_dgvARInvoiceIns;
            this.fld_dgcAPPaymentProposalPayments.Name = "fld_dgcAPPaymentProposalPayments";
            this.fld_dgcAPPaymentProposalPayments.PrintReport = false;
            this.fld_dgcAPPaymentProposalPayments.Screen = null;
            this.fld_dgcAPPaymentProposalPayments.Size = new System.Drawing.Size(1254, 355);
            this.fld_dgcAPPaymentProposalPayments.TabIndex = 1;
            this.fld_dgcAPPaymentProposalPayments.Tag = "DC";
            this.fld_dgcAPPaymentProposalPayments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARInvoiceIns});
            // 
            // fld_dgvARInvoiceIns
            // 
            this.fld_dgvARInvoiceIns.GridControl = this.fld_dgcAPPaymentProposalPayments;
            this.fld_dgvARInvoiceIns.Name = "fld_dgvARInvoiceIns";
            this.fld_dgvARInvoiceIns.PaintStyleName = "Office2003";
            // 
            // bosPanel3
            // 
            this.bosPanel3.BOSComment = null;
            this.bosPanel3.BOSDataMember = null;
            this.bosPanel3.BOSDataSource = null;
            this.bosPanel3.BOSDescription = null;
            this.bosPanel3.BOSError = null;
            this.bosPanel3.BOSFieldGroup = null;
            this.bosPanel3.BOSFieldRelation = null;
            this.bosPanel3.BOSPrivilege = null;
            this.bosPanel3.BOSPropertyName = null;
            this.bosPanel3.Controls.Add(this.bosLine5);
            this.bosPanel3.Controls.Add(this.fld_TabThanhToan);
            this.bosPanel3.Controls.Add(this.bosTabControl1);
            this.bosPanel3.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel3.Controls.Add(this.fld_pteAPSupplierPaymentEmployeePicture);
            this.bosPanel3.Controls.Add(this.bosGroupControl1);
            this.bosPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel3.Location = new System.Drawing.Point(0, 0);
            this.bosPanel3.Name = "bosPanel3";
            this.bosPanel3.Screen = null;
            this.bosPanel3.Size = new System.Drawing.Size(1269, 803);
            this.bosPanel3.TabIndex = 0;
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
            this.bosLine5.Controls.Add(this.fld_txtAPSupplierPaymentProject);
            this.bosLine5.Controls.Add(this.fld_lkeAPSupplierPaymentBankFeeType);
            this.bosLine5.Controls.Add(this.fld_lkeFK_CSCompanyBankID);
            this.bosLine5.Controls.Add(this.fld_dteAPSupplierPaymentDate);
            this.bosLine5.Controls.Add(this.bosLabel13);
            this.bosLine5.Controls.Add(this.fld_lblLabel3);
            this.bosLine5.Controls.Add(this.fld_txtAPSupplierPaymentBankFeeAmount);
            this.bosLine5.Controls.Add(this.bosLabel4);
            this.bosLine5.Controls.Add(this.bosLabel11);
            this.bosLine5.Controls.Add(this.bosLabel5);
            this.bosLine5.Controls.Add(this.fld_lkeFK_ACLoanReceiptID);
            this.bosLine5.Controls.Add(this.bosLabel3);
            this.bosLine5.Controls.Add(this.bosLabel23);
            this.bosLine5.Controls.Add(this.fld_lblLabel2);
            this.bosLine5.Controls.Add(this.bosLabel19);
            this.bosLine5.Controls.Add(this.fld_txtAPSupplierPaymentNo);
            this.bosLine5.Controls.Add(this.fld_txtAPSupplierPaymentBankAccount);
            this.bosLine5.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosLine5.Controls.Add(this.fld_txtAPSupplierPaymentExchangeRate);
            this.bosLine5.Controls.Add(this.fld_lkeFK_CSCashFundID);
            this.bosLine5.Controls.Add(this.bosLabel1);
            this.bosLine5.Controls.Add(this.bosLabel16);
            this.bosLine5.Controls.Add(this.bosLabel6);
            this.bosLine5.Controls.Add(this.fld_lkeFK_ACAssObjectID);
            this.bosLine5.Controls.Add(this.fld_txtAPSupplierPaymentTotalAmount);
            this.bosLine5.Controls.Add(this.bosLabel15);
            this.bosLine5.Controls.Add(this.bosLabel7);
            this.bosLine5.Controls.Add(this.fld_lkeAPSupplierPaymentStatus);
            this.bosLine5.Controls.Add(this.bosLabel2);
            this.bosLine5.Controls.Add(this.bosLabel14);
            this.bosLine5.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosLine5.Controls.Add(this.fld_medAPSupplierPaymentDesc);
            this.bosLine5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine5.Location = new System.Drawing.Point(111, 3);
            this.bosLine5.Name = "bosLine5";
            this.bosLine5.Screen = null;
            this.bosLine5.Size = new System.Drawing.Size(759, 211);
            this.bosLine5.TabIndex = 2;
            this.bosLine5.TabStop = false;
            this.bosLine5.Tag = "";
            this.bosLine5.Text = "Thông tin chung";
            // 
            // fld_lkeAPSupplierPaymentBankFeeType
            // 
            this.fld_lkeAPSupplierPaymentBankFeeType.BOSAllowAddNew = false;
            this.fld_lkeAPSupplierPaymentBankFeeType.BOSAllowDummy = false;
            this.fld_lkeAPSupplierPaymentBankFeeType.BOSComment = "";
            this.fld_lkeAPSupplierPaymentBankFeeType.BOSDataMember = "APSupplierPaymentBankFeeType";
            this.fld_lkeAPSupplierPaymentBankFeeType.BOSDataSource = "APSupplierPayments";
            this.fld_lkeAPSupplierPaymentBankFeeType.BOSDescription = null;
            this.fld_lkeAPSupplierPaymentBankFeeType.BOSError = null;
            this.fld_lkeAPSupplierPaymentBankFeeType.BOSFieldGroup = "";
            this.fld_lkeAPSupplierPaymentBankFeeType.BOSFieldParent = "";
            this.fld_lkeAPSupplierPaymentBankFeeType.BOSFieldRelation = "";
            this.fld_lkeAPSupplierPaymentBankFeeType.BOSPrivilege = "";
            this.fld_lkeAPSupplierPaymentBankFeeType.BOSPropertyName = "EditValue";
            this.fld_lkeAPSupplierPaymentBankFeeType.BOSSelectType = "";
            this.fld_lkeAPSupplierPaymentBankFeeType.BOSSelectTypeValue = "";
            this.fld_lkeAPSupplierPaymentBankFeeType.CurrentDisplayText = null;
            this.fld_lkeAPSupplierPaymentBankFeeType.Location = new System.Drawing.Point(611, 126);
            this.fld_lkeAPSupplierPaymentBankFeeType.Name = "fld_lkeAPSupplierPaymentBankFeeType";
            this.fld_lkeAPSupplierPaymentBankFeeType.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeAPSupplierPaymentBankFeeType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPSupplierPaymentBankFeeType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPSupplierPaymentBankFeeType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPSupplierPaymentBankFeeType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPSupplierPaymentBankFeeType.Properties.ColumnName = null;
            this.fld_lkeAPSupplierPaymentBankFeeType.Properties.NullText = "";
            this.fld_lkeAPSupplierPaymentBankFeeType.Properties.PopupWidth = 40;
            this.fld_lkeAPSupplierPaymentBankFeeType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPSupplierPaymentBankFeeType.Screen = null;
            this.fld_lkeAPSupplierPaymentBankFeeType.Size = new System.Drawing.Size(137, 20);
            this.fld_lkeAPSupplierPaymentBankFeeType.TabIndex = 14;
            this.fld_lkeAPSupplierPaymentBankFeeType.Tag = "DC";
            // 
            // fld_lkeFK_CSCompanyBankID
            // 
            this.fld_lkeFK_CSCompanyBankID.BOSAllowAddNew = false;
            this.fld_lkeFK_CSCompanyBankID.BOSAllowDummy = true;
            this.fld_lkeFK_CSCompanyBankID.BOSComment = "";
            this.fld_lkeFK_CSCompanyBankID.BOSDataMember = "FK_CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.BOSDataSource = "APSupplierPayments";
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
            this.fld_lkeFK_CSCompanyBankID.Location = new System.Drawing.Point(101, 100);
            this.fld_lkeFK_CSCompanyBankID.Name = "fld_lkeFK_CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_CSCompanyBankID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_CSCompanyBankID.Properties.ColumnName = null;
            this.fld_lkeFK_CSCompanyBankID.Properties.DisplayMember = "CSCompanyBankName";
            this.fld_lkeFK_CSCompanyBankID.Properties.NullText = "";
            this.fld_lkeFK_CSCompanyBankID.Properties.PopupWidth = 40;
            this.fld_lkeFK_CSCompanyBankID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_CSCompanyBankID.Properties.ValueMember = "CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.Screen = null;
            this.fld_lkeFK_CSCompanyBankID.Size = new System.Drawing.Size(137, 20);
            this.fld_lkeFK_CSCompanyBankID.TabIndex = 9;
            this.fld_lkeFK_CSCompanyBankID.Tag = "DC";
            this.fld_lkeFK_CSCompanyBankID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_CSCompanyBankID_CloseUp);
            // 
            // fld_dteAPSupplierPaymentDate
            // 
            this.fld_dteAPSupplierPaymentDate.BOSComment = "";
            this.fld_dteAPSupplierPaymentDate.BOSDataMember = "APSupplierPaymentDate";
            this.fld_dteAPSupplierPaymentDate.BOSDataSource = "APSupplierPayments";
            this.fld_dteAPSupplierPaymentDate.BOSDescription = null;
            this.fld_dteAPSupplierPaymentDate.BOSError = null;
            this.fld_dteAPSupplierPaymentDate.BOSFieldGroup = "";
            this.fld_dteAPSupplierPaymentDate.BOSFieldRelation = "";
            this.fld_dteAPSupplierPaymentDate.BOSPrivilege = "";
            this.fld_dteAPSupplierPaymentDate.BOSPropertyName = "EditValue";
            this.fld_dteAPSupplierPaymentDate.EditValue = null;
            this.fld_dteAPSupplierPaymentDate.Location = new System.Drawing.Point(347, 22);
            this.fld_dteAPSupplierPaymentDate.Name = "fld_dteAPSupplierPaymentDate";
            this.fld_dteAPSupplierPaymentDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPSupplierPaymentDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPSupplierPaymentDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPSupplierPaymentDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPSupplierPaymentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPSupplierPaymentDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPSupplierPaymentDate.Screen = null;
            this.fld_dteAPSupplierPaymentDate.Size = new System.Drawing.Size(137, 20);
            this.fld_dteAPSupplierPaymentDate.TabIndex = 1;
            this.fld_dteAPSupplierPaymentDate.Tag = "DC";
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
            this.bosLabel13.BOSPropertyName = "";
            this.bosLabel13.Location = new System.Drawing.Point(515, 129);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(90, 13);
            this.bosLabel13.TabIndex = 434;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "Loại phí ngân hàng";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = "";
            this.fld_lblLabel3.BOSDataMember = "";
            this.fld_lblLabel3.BOSDataSource = "";
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = "";
            this.fld_lblLabel3.BOSFieldRelation = "";
            this.fld_lblLabel3.BOSPrivilege = "";
            this.fld_lblLabel3.BOSPropertyName = "";
            this.fld_lblLabel3.Location = new System.Drawing.Point(269, 25);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel3.TabIndex = 7;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Ngày chứng từ";
            // 
            // fld_txtAPSupplierPaymentBankFeeAmount
            // 
            this.fld_txtAPSupplierPaymentBankFeeAmount.BOSComment = null;
            this.fld_txtAPSupplierPaymentBankFeeAmount.BOSDataMember = "APSupplierPaymentBankFeeAmount";
            this.fld_txtAPSupplierPaymentBankFeeAmount.BOSDataSource = "APSupplierPayments";
            this.fld_txtAPSupplierPaymentBankFeeAmount.BOSDescription = null;
            this.fld_txtAPSupplierPaymentBankFeeAmount.BOSError = null;
            this.fld_txtAPSupplierPaymentBankFeeAmount.BOSFieldGroup = null;
            this.fld_txtAPSupplierPaymentBankFeeAmount.BOSFieldRelation = null;
            this.fld_txtAPSupplierPaymentBankFeeAmount.BOSPrivilege = null;
            this.fld_txtAPSupplierPaymentBankFeeAmount.BOSPropertyName = "Text";
            this.fld_txtAPSupplierPaymentBankFeeAmount.Location = new System.Drawing.Point(611, 100);
            this.fld_txtAPSupplierPaymentBankFeeAmount.Name = "fld_txtAPSupplierPaymentBankFeeAmount";
            this.fld_txtAPSupplierPaymentBankFeeAmount.Screen = null;
            this.fld_txtAPSupplierPaymentBankFeeAmount.Size = new System.Drawing.Size(137, 20);
            this.fld_txtAPSupplierPaymentBankFeeAmount.TabIndex = 11;
            this.fld_txtAPSupplierPaymentBankFeeAmount.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(13, 103);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(52, 13);
            this.bosLabel4.TabIndex = 7;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Ngân hàng";
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
            this.bosLabel11.BOSPropertyName = "";
            this.bosLabel11.Location = new System.Drawing.Point(515, 103);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(68, 13);
            this.bosLabel11.TabIndex = 432;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Phí ngân hàng";
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
            this.bosLabel5.Location = new System.Drawing.Point(269, 103);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(46, 13);
            this.bosLabel5.TabIndex = 7;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Tài khoản";
            // 
            // fld_lkeFK_ACLoanReceiptID
            // 
            this.fld_lkeFK_ACLoanReceiptID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACLoanReceiptID.BOSAllowDummy = true;
            this.fld_lkeFK_ACLoanReceiptID.BOSComment = "";
            this.fld_lkeFK_ACLoanReceiptID.BOSDataMember = "FK_ACLoanReceiptID";
            this.fld_lkeFK_ACLoanReceiptID.BOSDataSource = "APSupplierPayments";
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
            this.fld_lkeFK_ACLoanReceiptID.Location = new System.Drawing.Point(347, 126);
            this.fld_lkeFK_ACLoanReceiptID.Name = "fld_lkeFK_ACLoanReceiptID";
            this.fld_lkeFK_ACLoanReceiptID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACLoanReceiptID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACLoanReceiptID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACLoanReceiptID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACLoanReceiptID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACLoanReceiptID.Properties.ColumnName = null;
            this.fld_lkeFK_ACLoanReceiptID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACLoanReceiptNo", "Mã khế ước")});
            this.fld_lkeFK_ACLoanReceiptID.Properties.DisplayMember = "ACLoanReceiptNo";
            this.fld_lkeFK_ACLoanReceiptID.Properties.NullText = "";
            this.fld_lkeFK_ACLoanReceiptID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACLoanReceiptID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACLoanReceiptID.Properties.ValueMember = "ACLoanReceiptID";
            this.fld_lkeFK_ACLoanReceiptID.Screen = null;
            this.fld_lkeFK_ACLoanReceiptID.Size = new System.Drawing.Size(137, 20);
            this.fld_lkeFK_ACLoanReceiptID.TabIndex = 13;
            this.fld_lkeFK_ACLoanReceiptID.Tag = "DC";
            this.fld_lkeFK_ACLoanReceiptID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACLoanReceiptID_CloseUp);
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
            this.bosLabel3.Location = new System.Drawing.Point(269, 77);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(29, 13);
            this.bosLabel3.TabIndex = 7;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Tỷ giá";
            // 
            // bosLabel23
            // 
            this.bosLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.Options.UseBackColor = true;
            this.bosLabel23.Appearance.Options.UseForeColor = true;
            this.bosLabel23.BOSComment = "";
            this.bosLabel23.BOSDataMember = "";
            this.bosLabel23.BOSDataSource = "";
            this.bosLabel23.BOSDescription = null;
            this.bosLabel23.BOSError = null;
            this.bosLabel23.BOSFieldGroup = "";
            this.bosLabel23.BOSFieldRelation = "";
            this.bosLabel23.BOSPrivilege = "";
            this.bosLabel23.BOSPropertyName = "";
            this.bosLabel23.Location = new System.Drawing.Point(269, 129);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(60, 13);
            this.bosLabel23.TabIndex = 430;
            this.bosLabel23.Tag = "";
            this.bosLabel23.Text = "Khế ước vay";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(13, 51);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel2.TabIndex = 6;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Đối tượng";
            // 
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.Options.UseBackColor = true;
            this.bosLabel19.Appearance.Options.UseForeColor = true;
            this.bosLabel19.BOSComment = "";
            this.bosLabel19.BOSDataMember = "";
            this.bosLabel19.BOSDataSource = "";
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = "";
            this.bosLabel19.BOSFieldRelation = "";
            this.bosLabel19.BOSPrivilege = "";
            this.bosLabel19.BOSPropertyName = "";
            this.bosLabel19.Location = new System.Drawing.Point(515, 51);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(45, 13);
            this.bosLabel19.TabIndex = 428;
            this.bosLabel19.Tag = "";
            this.bosLabel19.Text = "Mã dự án";
            // 
            // fld_txtAPSupplierPaymentNo
            // 
            this.fld_txtAPSupplierPaymentNo.BOSComment = null;
            this.fld_txtAPSupplierPaymentNo.BOSDataMember = "APSupplierPaymentNo";
            this.fld_txtAPSupplierPaymentNo.BOSDataSource = "APSupplierPayments";
            this.fld_txtAPSupplierPaymentNo.BOSDescription = null;
            this.fld_txtAPSupplierPaymentNo.BOSError = null;
            this.fld_txtAPSupplierPaymentNo.BOSFieldGroup = null;
            this.fld_txtAPSupplierPaymentNo.BOSFieldRelation = null;
            this.fld_txtAPSupplierPaymentNo.BOSPrivilege = null;
            this.fld_txtAPSupplierPaymentNo.BOSPropertyName = "Text";
            this.fld_txtAPSupplierPaymentNo.Location = new System.Drawing.Point(101, 22);
            this.fld_txtAPSupplierPaymentNo.MenuManager = this.screenToolbar;
            this.fld_txtAPSupplierPaymentNo.Name = "fld_txtAPSupplierPaymentNo";
            this.fld_txtAPSupplierPaymentNo.Screen = null;
            this.fld_txtAPSupplierPaymentNo.Size = new System.Drawing.Size(137, 20);
            this.fld_txtAPSupplierPaymentNo.TabIndex = 0;
            this.fld_txtAPSupplierPaymentNo.Tag = "DC";
            // 
            // fld_txtAPSupplierPaymentBankAccount
            // 
            this.fld_txtAPSupplierPaymentBankAccount.BOSComment = null;
            this.fld_txtAPSupplierPaymentBankAccount.BOSDataMember = "APSupplierPaymentBankAccount";
            this.fld_txtAPSupplierPaymentBankAccount.BOSDataSource = "APSupplierPayments";
            this.fld_txtAPSupplierPaymentBankAccount.BOSDescription = null;
            this.fld_txtAPSupplierPaymentBankAccount.BOSError = null;
            this.fld_txtAPSupplierPaymentBankAccount.BOSFieldGroup = null;
            this.fld_txtAPSupplierPaymentBankAccount.BOSFieldRelation = null;
            this.fld_txtAPSupplierPaymentBankAccount.BOSPrivilege = null;
            this.fld_txtAPSupplierPaymentBankAccount.BOSPropertyName = "Text";
            this.fld_txtAPSupplierPaymentBankAccount.Location = new System.Drawing.Point(347, 100);
            this.fld_txtAPSupplierPaymentBankAccount.Name = "fld_txtAPSupplierPaymentBankAccount";
            this.fld_txtAPSupplierPaymentBankAccount.Screen = null;
            this.fld_txtAPSupplierPaymentBankAccount.Size = new System.Drawing.Size(137, 20);
            this.fld_txtAPSupplierPaymentBankAccount.TabIndex = 10;
            this.fld_txtAPSupplierPaymentBankAccount.Tag = "DC";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "APSupplierPayments";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(101, 48);
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
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(137, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 3;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            // 
            // fld_txtAPSupplierPaymentExchangeRate
            // 
            this.fld_txtAPSupplierPaymentExchangeRate.BOSComment = null;
            this.fld_txtAPSupplierPaymentExchangeRate.BOSDataMember = "APSupplierPaymentExchangeRate";
            this.fld_txtAPSupplierPaymentExchangeRate.BOSDataSource = "APSupplierPayments";
            this.fld_txtAPSupplierPaymentExchangeRate.BOSDescription = null;
            this.fld_txtAPSupplierPaymentExchangeRate.BOSError = null;
            this.fld_txtAPSupplierPaymentExchangeRate.BOSFieldGroup = null;
            this.fld_txtAPSupplierPaymentExchangeRate.BOSFieldRelation = null;
            this.fld_txtAPSupplierPaymentExchangeRate.BOSPrivilege = null;
            this.fld_txtAPSupplierPaymentExchangeRate.BOSPropertyName = "Text";
            this.fld_txtAPSupplierPaymentExchangeRate.Location = new System.Drawing.Point(347, 74);
            this.fld_txtAPSupplierPaymentExchangeRate.Name = "fld_txtAPSupplierPaymentExchangeRate";
            this.fld_txtAPSupplierPaymentExchangeRate.Screen = null;
            this.fld_txtAPSupplierPaymentExchangeRate.Size = new System.Drawing.Size(137, 20);
            this.fld_txtAPSupplierPaymentExchangeRate.TabIndex = 7;
            this.fld_txtAPSupplierPaymentExchangeRate.Tag = "DC";
            this.fld_txtAPSupplierPaymentExchangeRate.Validated += new System.EventHandler(this.fld_txtAPSupplierPaymentExchangeRate_Validated);
            // 
            // fld_lkeFK_CSCashFundID
            // 
            this.fld_lkeFK_CSCashFundID.BOSAllowAddNew = false;
            this.fld_lkeFK_CSCashFundID.BOSAllowDummy = false;
            this.fld_lkeFK_CSCashFundID.BOSComment = "";
            this.fld_lkeFK_CSCashFundID.BOSDataMember = "FK_CSCashFundID";
            this.fld_lkeFK_CSCashFundID.BOSDataSource = "APSupplierPayments";
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
            this.fld_lkeFK_CSCashFundID.Location = new System.Drawing.Point(101, 126);
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
            this.fld_lkeFK_CSCashFundID.Size = new System.Drawing.Size(137, 20);
            this.fld_lkeFK_CSCashFundID.TabIndex = 12;
            this.fld_lkeFK_CSCashFundID.Tag = "DC";
            this.fld_lkeFK_CSCashFundID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_CSCashFundID_CloseUp);
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
            this.bosLabel1.Location = new System.Drawing.Point(13, 25);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "Mã chứng từ";
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
            this.bosLabel16.Location = new System.Drawing.Point(13, 129);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(62, 13);
            this.bosLabel16.TabIndex = 425;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "Quỹ tiền mặt";
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
            this.bosLabel6.Location = new System.Drawing.Point(13, 154);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(40, 13);
            this.bosLabel6.TabIndex = 7;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Diễn giải";
            // 
            // fld_lkeFK_ACAssObjectID
            // 
            this.fld_lkeFK_ACAssObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAssObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACAssObjectID.BOSComment = null;
            this.fld_lkeFK_ACAssObjectID.BOSDataMember = "ACAssObjectAccessKey";
            this.fld_lkeFK_ACAssObjectID.BOSDataSource = "APSupplierPayments";
            this.fld_lkeFK_ACAssObjectID.BOSDescription = null;
            this.fld_lkeFK_ACAssObjectID.BOSError = null;
            this.fld_lkeFK_ACAssObjectID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAssObjectID.BOSFieldParent = null;
            this.fld_lkeFK_ACAssObjectID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAssObjectID.BOSModuleType = null;
            this.fld_lkeFK_ACAssObjectID.BOSPrivilege = null;
            this.fld_lkeFK_ACAssObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAssObjectID.BOSSelectType = null;
            this.fld_lkeFK_ACAssObjectID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACAssObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAssObjectID.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeFK_ACAssObjectID.Location = new System.Drawing.Point(611, 74);
            this.fld_lkeFK_ACAssObjectID.Name = "fld_lkeFK_ACAssObjectID";
            this.fld_lkeFK_ACAssObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAssObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACAssObjectID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ACAssObjectID, true);
            this.fld_lkeFK_ACAssObjectID.Size = new System.Drawing.Size(137, 20);
            this.fld_lkeFK_ACAssObjectID.TabIndex = 8;
            this.fld_lkeFK_ACAssObjectID.Tag = "DC";
            this.fld_lkeFK_ACAssObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACAssObjectID_CloseUp);
            this.fld_lkeFK_ACAssObjectID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_ACAssObjectID_EditValueChanged);
            // 
            // fld_txtAPSupplierPaymentTotalAmount
            // 
            this.fld_txtAPSupplierPaymentTotalAmount.BOSComment = null;
            this.fld_txtAPSupplierPaymentTotalAmount.BOSDataMember = "APSupplierPaymentTotalAmount";
            this.fld_txtAPSupplierPaymentTotalAmount.BOSDataSource = "APSupplierPayments";
            this.fld_txtAPSupplierPaymentTotalAmount.BOSDescription = null;
            this.fld_txtAPSupplierPaymentTotalAmount.BOSError = null;
            this.fld_txtAPSupplierPaymentTotalAmount.BOSFieldGroup = null;
            this.fld_txtAPSupplierPaymentTotalAmount.BOSFieldRelation = null;
            this.fld_txtAPSupplierPaymentTotalAmount.BOSPrivilege = null;
            this.fld_txtAPSupplierPaymentTotalAmount.BOSPropertyName = "Text";
            this.fld_txtAPSupplierPaymentTotalAmount.Location = new System.Drawing.Point(101, 74);
            this.fld_txtAPSupplierPaymentTotalAmount.Name = "fld_txtAPSupplierPaymentTotalAmount";
            this.fld_txtAPSupplierPaymentTotalAmount.Properties.ReadOnly = true;
            this.fld_txtAPSupplierPaymentTotalAmount.Screen = null;
            this.fld_txtAPSupplierPaymentTotalAmount.Size = new System.Drawing.Size(137, 20);
            this.fld_txtAPSupplierPaymentTotalAmount.TabIndex = 6;
            this.fld_txtAPSupplierPaymentTotalAmount.Tag = "DC";
            this.fld_txtAPSupplierPaymentTotalAmount.Validated += new System.EventHandler(this.fld_txtAPPaymentVoucherTotalAmount_Validated);
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
            this.bosLabel15.Location = new System.Drawing.Point(515, 77);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel15, true);
            this.bosLabel15.Size = new System.Drawing.Size(57, 13);
            this.bosLabel15.TabIndex = 424;
            this.bosLabel15.Tag = "";
            this.bosLabel15.Text = "Đối tượng 2";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel7.Location = new System.Drawing.Point(13, 77);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(76, 13);
            this.bosLabel7.TabIndex = 7;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Tiền thanh toán";
            // 
            // fld_lkeAPSupplierPaymentStatus
            // 
            this.fld_lkeAPSupplierPaymentStatus.BOSAllowAddNew = false;
            this.fld_lkeAPSupplierPaymentStatus.BOSAllowDummy = false;
            this.fld_lkeAPSupplierPaymentStatus.BOSComment = "";
            this.fld_lkeAPSupplierPaymentStatus.BOSDataMember = "APSupplierPaymentStatus";
            this.fld_lkeAPSupplierPaymentStatus.BOSDataSource = "APSupplierPayments";
            this.fld_lkeAPSupplierPaymentStatus.BOSDescription = null;
            this.fld_lkeAPSupplierPaymentStatus.BOSError = null;
            this.fld_lkeAPSupplierPaymentStatus.BOSFieldGroup = "";
            this.fld_lkeAPSupplierPaymentStatus.BOSFieldParent = "";
            this.fld_lkeAPSupplierPaymentStatus.BOSFieldRelation = "";
            this.fld_lkeAPSupplierPaymentStatus.BOSPrivilege = "";
            this.fld_lkeAPSupplierPaymentStatus.BOSPropertyName = "EditValue";
            this.fld_lkeAPSupplierPaymentStatus.BOSSelectType = "";
            this.fld_lkeAPSupplierPaymentStatus.BOSSelectTypeValue = "";
            this.fld_lkeAPSupplierPaymentStatus.CurrentDisplayText = null;
            this.fld_lkeAPSupplierPaymentStatus.Location = new System.Drawing.Point(611, 22);
            this.fld_lkeAPSupplierPaymentStatus.Name = "fld_lkeAPSupplierPaymentStatus";
            this.fld_lkeAPSupplierPaymentStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeAPSupplierPaymentStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPSupplierPaymentStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPSupplierPaymentStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPSupplierPaymentStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPSupplierPaymentStatus.Properties.ColumnName = null;
            this.fld_lkeAPSupplierPaymentStatus.Properties.NullText = "";
            this.fld_lkeAPSupplierPaymentStatus.Properties.PopupWidth = 40;
            this.fld_lkeAPSupplierPaymentStatus.Properties.ReadOnly = true;
            this.fld_lkeAPSupplierPaymentStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPSupplierPaymentStatus.Screen = null;
            this.fld_lkeAPSupplierPaymentStatus.Size = new System.Drawing.Size(137, 20);
            this.fld_lkeAPSupplierPaymentStatus.TabIndex = 2;
            this.fld_lkeAPSupplierPaymentStatus.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(269, 51);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(53, 13);
            this.bosLabel2.TabIndex = 7;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Loại tiền tệ";
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
            this.bosLabel14.Location = new System.Drawing.Point(515, 25);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(49, 13);
            this.bosLabel14.TabIndex = 21;
            this.bosLabel14.Tag = "";
            this.bosLabel14.Text = "Tình trạng";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = "";
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "APSupplierPayments";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(347, 48);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECurrencyID.Properties.ReadOnly = true;
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(137, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 4;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            this.fld_lkeFK_GECurrencyID.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.fld_lkeFK_GECurrencyID_Closed);
            // 
            // fld_medAPSupplierPaymentDesc
            // 
            this.fld_medAPSupplierPaymentDesc.BOSComment = null;
            this.fld_medAPSupplierPaymentDesc.BOSDataMember = "APSupplierPaymentDesc";
            this.fld_medAPSupplierPaymentDesc.BOSDataSource = "APSupplierPayments";
            this.fld_medAPSupplierPaymentDesc.BOSDescription = null;
            this.fld_medAPSupplierPaymentDesc.BOSError = null;
            this.fld_medAPSupplierPaymentDesc.BOSFieldGroup = null;
            this.fld_medAPSupplierPaymentDesc.BOSFieldRelation = null;
            this.fld_medAPSupplierPaymentDesc.BOSPrivilege = null;
            this.fld_medAPSupplierPaymentDesc.BOSPropertyName = "EditValue";
            this.fld_medAPSupplierPaymentDesc.Location = new System.Drawing.Point(101, 152);
            this.fld_medAPSupplierPaymentDesc.MenuManager = this.screenToolbar;
            this.fld_medAPSupplierPaymentDesc.Name = "fld_medAPSupplierPaymentDesc";
            this.fld_medAPSupplierPaymentDesc.Screen = null;
            this.fld_medAPSupplierPaymentDesc.Size = new System.Drawing.Size(647, 50);
            this.fld_medAPSupplierPaymentDesc.TabIndex = 15;
            this.fld_medAPSupplierPaymentDesc.Tag = "DC";
            // 
            // fld_TabThanhToan
            // 
            this.fld_TabThanhToan.BOSComment = null;
            this.fld_TabThanhToan.BOSDataMember = null;
            this.fld_TabThanhToan.BOSDataSource = null;
            this.fld_TabThanhToan.BOSDescription = null;
            this.fld_TabThanhToan.BOSError = null;
            this.fld_TabThanhToan.BOSFieldGroup = null;
            this.fld_TabThanhToan.BOSFieldRelation = null;
            this.fld_TabThanhToan.BOSPrivilege = null;
            this.fld_TabThanhToan.BOSPropertyName = null;
            this.fld_TabThanhToan.Location = new System.Drawing.Point(876, 3);
            this.fld_TabThanhToan.Name = "fld_TabThanhToan";
            this.fld_TabThanhToan.Screen = null;
            this.fld_TabThanhToan.SelectedTabPage = this.fld_xtrTab1;
            this.fld_TabThanhToan.Size = new System.Drawing.Size(335, 211);
            this.fld_TabThanhToan.TabIndex = 4;
            this.fld_TabThanhToan.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_xtrTab1,
            this.fld_xtrTab2});
            // 
            // fld_xtrTab1
            // 
            this.fld_xtrTab1.Controls.Add(this.fld_lkeFK_ACListAccountBankID);
            this.fld_xtrTab1.Controls.Add(this.bosLabel24);
            this.fld_xtrTab1.Controls.Add(this.fld_txtAPSupplierPaymentReceiverBankName);
            this.fld_xtrTab1.Controls.Add(this.fld_txtAPSupplierPaymentObjectReceiptName);
            this.fld_xtrTab1.Controls.Add(this.fld_txtAPSupplierPaymentReceiverAccount);
            this.fld_xtrTab1.Controls.Add(this.bosLabel8);
            this.fld_xtrTab1.Controls.Add(this.bosLabel12);
            this.fld_xtrTab1.Controls.Add(this.fld_txtAPSupplierPaymentReceiverBankCode);
            this.fld_xtrTab1.Controls.Add(this.bosLabel9);
            this.fld_xtrTab1.Controls.Add(this.bosLabel21);
            this.fld_xtrTab1.Controls.Add(this.bosLabel10);
            this.fld_xtrTab1.Controls.Add(this.fld_medAPSupplierPaymentReceiptAddress);
            this.fld_xtrTab1.Name = "fld_xtrTab1";
            this.fld_xtrTab1.Size = new System.Drawing.Size(333, 186);
            this.fld_xtrTab1.Text = "Thông tin người nhận";
            // 
            // fld_lkeFK_ACListAccountBankID
            // 
            this.fld_lkeFK_ACListAccountBankID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACListAccountBankID.BOSAllowDummy = false;
            this.fld_lkeFK_ACListAccountBankID.BOSComment = "";
            this.fld_lkeFK_ACListAccountBankID.BOSDataMember = "FK_ACListAccountBankID";
            this.fld_lkeFK_ACListAccountBankID.BOSDataSource = "APSupplierPayments";
            this.fld_lkeFK_ACListAccountBankID.BOSDescription = null;
            this.fld_lkeFK_ACListAccountBankID.BOSError = null;
            this.fld_lkeFK_ACListAccountBankID.BOSFieldGroup = "";
            this.fld_lkeFK_ACListAccountBankID.BOSFieldParent = "";
            this.fld_lkeFK_ACListAccountBankID.BOSFieldRelation = "";
            this.fld_lkeFK_ACListAccountBankID.BOSPrivilege = "";
            this.fld_lkeFK_ACListAccountBankID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACListAccountBankID.BOSSelectType = "";
            this.fld_lkeFK_ACListAccountBankID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACListAccountBankID.CurrentDisplayText = null;
            this.fld_lkeFK_ACListAccountBankID.Location = new System.Drawing.Point(102, 10);
            this.fld_lkeFK_ACListAccountBankID.Name = "fld_lkeFK_ACListAccountBankID";
            this.fld_lkeFK_ACListAccountBankID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACListAccountBankID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACListAccountBankID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACListAccountBankID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACListAccountBankID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACListAccountBankID.Properties.ColumnName = null;
            this.fld_lkeFK_ACListAccountBankID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACListAccountBankNo", "Mã ngân hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACListAccountBankName", "Tên ngân hàng")});
            this.fld_lkeFK_ACListAccountBankID.Properties.DisplayMember = "ACListAccountBankName";
            this.fld_lkeFK_ACListAccountBankID.Properties.NullText = "";
            this.fld_lkeFK_ACListAccountBankID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACListAccountBankID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACListAccountBankID.Properties.ValueMember = "ACListAccountBankID";
            this.fld_lkeFK_ACListAccountBankID.Screen = null;
            this.fld_lkeFK_ACListAccountBankID.Size = new System.Drawing.Size(215, 20);
            this.fld_lkeFK_ACListAccountBankID.TabIndex = 0;
            this.fld_lkeFK_ACListAccountBankID.Tag = "DC";
            this.fld_lkeFK_ACListAccountBankID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_ACListAccountBankID_QueryPopUp);
            this.fld_lkeFK_ACListAccountBankID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACListAccountBankID_CloseUp);
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
            this.bosLabel24.BOSPropertyName = "";
            this.bosLabel24.Location = new System.Drawing.Point(15, 13);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(52, 13);
            this.bosLabel24.TabIndex = 9;
            this.bosLabel24.Tag = "";
            this.bosLabel24.Text = "Ngân hàng";
            // 
            // fld_txtAPSupplierPaymentReceiverBankName
            // 
            this.fld_txtAPSupplierPaymentReceiverBankName.BOSComment = null;
            this.fld_txtAPSupplierPaymentReceiverBankName.BOSDataMember = "APSupplierPaymentReceiverBankName";
            this.fld_txtAPSupplierPaymentReceiverBankName.BOSDataSource = "APSupplierPayments";
            this.fld_txtAPSupplierPaymentReceiverBankName.BOSDescription = null;
            this.fld_txtAPSupplierPaymentReceiverBankName.BOSError = null;
            this.fld_txtAPSupplierPaymentReceiverBankName.BOSFieldGroup = null;
            this.fld_txtAPSupplierPaymentReceiverBankName.BOSFieldRelation = null;
            this.fld_txtAPSupplierPaymentReceiverBankName.BOSPrivilege = null;
            this.fld_txtAPSupplierPaymentReceiverBankName.BOSPropertyName = "Text";
            this.fld_txtAPSupplierPaymentReceiverBankName.Location = new System.Drawing.Point(102, 62);
            this.fld_txtAPSupplierPaymentReceiverBankName.Name = "fld_txtAPSupplierPaymentReceiverBankName";
            this.fld_txtAPSupplierPaymentReceiverBankName.Screen = null;
            this.fld_txtAPSupplierPaymentReceiverBankName.Size = new System.Drawing.Size(215, 20);
            this.fld_txtAPSupplierPaymentReceiverBankName.TabIndex = 1;
            this.fld_txtAPSupplierPaymentReceiverBankName.Tag = "DC";
            // 
            // fld_txtAPSupplierPaymentObjectReceiptName
            // 
            this.fld_txtAPSupplierPaymentObjectReceiptName.BOSComment = null;
            this.fld_txtAPSupplierPaymentObjectReceiptName.BOSDataMember = "APSupplierPaymentObjectReceiptName";
            this.fld_txtAPSupplierPaymentObjectReceiptName.BOSDataSource = "APSupplierPayments";
            this.fld_txtAPSupplierPaymentObjectReceiptName.BOSDescription = null;
            this.fld_txtAPSupplierPaymentObjectReceiptName.BOSError = null;
            this.fld_txtAPSupplierPaymentObjectReceiptName.BOSFieldGroup = null;
            this.fld_txtAPSupplierPaymentObjectReceiptName.BOSFieldRelation = null;
            this.fld_txtAPSupplierPaymentObjectReceiptName.BOSPrivilege = null;
            this.fld_txtAPSupplierPaymentObjectReceiptName.BOSPropertyName = "Text";
            this.fld_txtAPSupplierPaymentObjectReceiptName.Location = new System.Drawing.Point(102, 88);
            this.fld_txtAPSupplierPaymentObjectReceiptName.Name = "fld_txtAPSupplierPaymentObjectReceiptName";
            this.fld_txtAPSupplierPaymentObjectReceiptName.Screen = null;
            this.fld_txtAPSupplierPaymentObjectReceiptName.Size = new System.Drawing.Size(215, 20);
            this.fld_txtAPSupplierPaymentObjectReceiptName.TabIndex = 3;
            this.fld_txtAPSupplierPaymentObjectReceiptName.Tag = "DC";
            // 
            // fld_txtAPSupplierPaymentReceiverAccount
            // 
            this.fld_txtAPSupplierPaymentReceiverAccount.BOSComment = null;
            this.fld_txtAPSupplierPaymentReceiverAccount.BOSDataMember = "APSupplierPaymentReceiverAccount";
            this.fld_txtAPSupplierPaymentReceiverAccount.BOSDataSource = "APSupplierPayments";
            this.fld_txtAPSupplierPaymentReceiverAccount.BOSDescription = null;
            this.fld_txtAPSupplierPaymentReceiverAccount.BOSError = null;
            this.fld_txtAPSupplierPaymentReceiverAccount.BOSFieldGroup = null;
            this.fld_txtAPSupplierPaymentReceiverAccount.BOSFieldRelation = null;
            this.fld_txtAPSupplierPaymentReceiverAccount.BOSPrivilege = null;
            this.fld_txtAPSupplierPaymentReceiverAccount.BOSPropertyName = "Text";
            this.fld_txtAPSupplierPaymentReceiverAccount.Location = new System.Drawing.Point(102, 114);
            this.fld_txtAPSupplierPaymentReceiverAccount.Name = "fld_txtAPSupplierPaymentReceiverAccount";
            this.fld_txtAPSupplierPaymentReceiverAccount.Screen = null;
            this.fld_txtAPSupplierPaymentReceiverAccount.Size = new System.Drawing.Size(215, 20);
            this.fld_txtAPSupplierPaymentReceiverAccount.TabIndex = 4;
            this.fld_txtAPSupplierPaymentReceiverAccount.Tag = "DC";
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
            this.bosLabel8.Location = new System.Drawing.Point(15, 117);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(46, 13);
            this.bosLabel8.TabIndex = 8;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Tài khoản";
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
            this.bosLabel12.BOSPropertyName = "";
            this.bosLabel12.Location = new System.Drawing.Point(15, 142);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(32, 13);
            this.bosLabel12.TabIndex = 6;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "Địa chỉ";
            // 
            // fld_txtAPSupplierPaymentReceiverBankCode
            // 
            this.fld_txtAPSupplierPaymentReceiverBankCode.BOSComment = null;
            this.fld_txtAPSupplierPaymentReceiverBankCode.BOSDataMember = "APSupplierPaymentReceiverBankCode";
            this.fld_txtAPSupplierPaymentReceiverBankCode.BOSDataSource = "APSupplierPayments";
            this.fld_txtAPSupplierPaymentReceiverBankCode.BOSDescription = null;
            this.fld_txtAPSupplierPaymentReceiverBankCode.BOSError = null;
            this.fld_txtAPSupplierPaymentReceiverBankCode.BOSFieldGroup = null;
            this.fld_txtAPSupplierPaymentReceiverBankCode.BOSFieldRelation = null;
            this.fld_txtAPSupplierPaymentReceiverBankCode.BOSPrivilege = null;
            this.fld_txtAPSupplierPaymentReceiverBankCode.BOSPropertyName = "Text";
            this.fld_txtAPSupplierPaymentReceiverBankCode.Location = new System.Drawing.Point(102, 36);
            this.fld_txtAPSupplierPaymentReceiverBankCode.Name = "fld_txtAPSupplierPaymentReceiverBankCode";
            this.fld_txtAPSupplierPaymentReceiverBankCode.Screen = null;
            this.fld_txtAPSupplierPaymentReceiverBankCode.Size = new System.Drawing.Size(215, 20);
            this.fld_txtAPSupplierPaymentReceiverBankCode.TabIndex = 2;
            this.fld_txtAPSupplierPaymentReceiverBankCode.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(15, 65);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(48, 13);
            this.bosLabel9.TabIndex = 6;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Chi nhánh";
            // 
            // bosLabel21
            // 
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.Options.UseBackColor = true;
            this.bosLabel21.Appearance.Options.UseForeColor = true;
            this.bosLabel21.BOSComment = "";
            this.bosLabel21.BOSDataMember = "";
            this.bosLabel21.BOSDataSource = "";
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = "";
            this.bosLabel21.BOSFieldRelation = "";
            this.bosLabel21.BOSPrivilege = "";
            this.bosLabel21.BOSPropertyName = "";
            this.bosLabel21.Location = new System.Drawing.Point(15, 39);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(31, 13);
            this.bosLabel21.TabIndex = 8;
            this.bosLabel21.Tag = "";
            this.bosLabel21.Text = "Mã NH";
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
            this.bosLabel10.Location = new System.Drawing.Point(15, 91);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(75, 13);
            this.bosLabel10.TabIndex = 6;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Tên người nhận";
            // 
            // fld_medAPSupplierPaymentReceiptAddress
            // 
            this.fld_medAPSupplierPaymentReceiptAddress.BOSComment = null;
            this.fld_medAPSupplierPaymentReceiptAddress.BOSDataMember = "APSupplierPaymentReceiptAddress";
            this.fld_medAPSupplierPaymentReceiptAddress.BOSDataSource = "APSupplierPayments";
            this.fld_medAPSupplierPaymentReceiptAddress.BOSDescription = null;
            this.fld_medAPSupplierPaymentReceiptAddress.BOSError = null;
            this.fld_medAPSupplierPaymentReceiptAddress.BOSFieldGroup = null;
            this.fld_medAPSupplierPaymentReceiptAddress.BOSFieldRelation = null;
            this.fld_medAPSupplierPaymentReceiptAddress.BOSPrivilege = null;
            this.fld_medAPSupplierPaymentReceiptAddress.BOSPropertyName = "EditValue";
            this.fld_medAPSupplierPaymentReceiptAddress.Location = new System.Drawing.Point(102, 140);
            this.fld_medAPSupplierPaymentReceiptAddress.Name = "fld_medAPSupplierPaymentReceiptAddress";
            this.fld_medAPSupplierPaymentReceiptAddress.Screen = null;
            this.fld_medAPSupplierPaymentReceiptAddress.Size = new System.Drawing.Size(215, 38);
            this.fld_medAPSupplierPaymentReceiptAddress.TabIndex = 8;
            this.fld_medAPSupplierPaymentReceiptAddress.Tag = "DC";
            // 
            // fld_xtrTab2
            // 
            this.fld_xtrTab2.Controls.Add(this.fld_lkeAPSupplierPaymentAssExchangeWay);
            this.fld_xtrTab2.Controls.Add(this.fld_lkeFK_APAssociatedSupplierID);
            this.fld_xtrTab2.Controls.Add(this.bosLabel18);
            this.fld_xtrTab2.Controls.Add(this.bosLabel20);
            this.fld_xtrTab2.Controls.Add(this.bosLabel22);
            this.fld_xtrTab2.Controls.Add(this.bosLabel25);
            this.fld_xtrTab2.Controls.Add(this.fld_lkeFK_GEAssCurrencyID);
            this.fld_xtrTab2.Controls.Add(this.fld_txtAPSupplierPaymentAssTotalAmount);
            this.fld_xtrTab2.Controls.Add(this.fld_txtAPSupplierPaymentAssExchangeRate);
            this.fld_xtrTab2.Controls.Add(this.fld_txtAPSupplierPaymentAssPostingExchangeRate);
            this.fld_xtrTab2.Controls.Add(this.bosLabel26);
            this.fld_xtrTab2.Controls.Add(this.bosLabel27);
            this.fld_xtrTab2.Name = "fld_xtrTab2";
            this.fld_xtrTab2.Size = new System.Drawing.Size(333, 186);
            this.fld_xtrTab2.Text = "Thanh toán qua trung gian";
            // 
            // fld_lkeAPSupplierPaymentAssExchangeWay
            // 
            this.fld_lkeAPSupplierPaymentAssExchangeWay.BOSAllowAddNew = false;
            this.fld_lkeAPSupplierPaymentAssExchangeWay.BOSAllowDummy = false;
            this.fld_lkeAPSupplierPaymentAssExchangeWay.BOSComment = null;
            this.fld_lkeAPSupplierPaymentAssExchangeWay.BOSDataMember = "APSupplierPaymentAssExchangeWay";
            this.fld_lkeAPSupplierPaymentAssExchangeWay.BOSDataSource = "APSupplierPayments";
            this.fld_lkeAPSupplierPaymentAssExchangeWay.BOSDescription = null;
            this.fld_lkeAPSupplierPaymentAssExchangeWay.BOSError = null;
            this.fld_lkeAPSupplierPaymentAssExchangeWay.BOSFieldGroup = null;
            this.fld_lkeAPSupplierPaymentAssExchangeWay.BOSFieldParent = null;
            this.fld_lkeAPSupplierPaymentAssExchangeWay.BOSFieldRelation = null;
            this.fld_lkeAPSupplierPaymentAssExchangeWay.BOSPrivilege = null;
            this.fld_lkeAPSupplierPaymentAssExchangeWay.BOSPropertyName = "EditValue";
            this.fld_lkeAPSupplierPaymentAssExchangeWay.BOSSelectType = null;
            this.fld_lkeAPSupplierPaymentAssExchangeWay.BOSSelectTypeValue = null;
            this.fld_lkeAPSupplierPaymentAssExchangeWay.CurrentDisplayText = null;
            this.fld_lkeAPSupplierPaymentAssExchangeWay.Location = new System.Drawing.Point(104, 62);
            this.fld_lkeAPSupplierPaymentAssExchangeWay.MenuManager = this.screenToolbar;
            this.fld_lkeAPSupplierPaymentAssExchangeWay.Name = "fld_lkeAPSupplierPaymentAssExchangeWay";
            this.fld_lkeAPSupplierPaymentAssExchangeWay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPSupplierPaymentAssExchangeWay.Properties.ColumnName = null;
            this.fld_lkeAPSupplierPaymentAssExchangeWay.Screen = null;
            this.fld_lkeAPSupplierPaymentAssExchangeWay.Size = new System.Drawing.Size(215, 20);
            this.fld_lkeAPSupplierPaymentAssExchangeWay.TabIndex = 2;
            this.fld_lkeAPSupplierPaymentAssExchangeWay.Tag = "DC";
            this.fld_lkeAPSupplierPaymentAssExchangeWay.Validated += new System.EventHandler(this.fld_lkeAPSupplierPaymentAssExchangeWay_Validated);
            // 
            // fld_lkeFK_APAssociatedSupplierID
            // 
            this.fld_lkeFK_APAssociatedSupplierID.BOSAllowAddNew = false;
            this.fld_lkeFK_APAssociatedSupplierID.BOSAllowDummy = true;
            this.fld_lkeFK_APAssociatedSupplierID.BOSComment = "";
            this.fld_lkeFK_APAssociatedSupplierID.BOSDataMember = "FK_APAssociatedSupplierID";
            this.fld_lkeFK_APAssociatedSupplierID.BOSDataSource = "APSupplierPayments";
            this.fld_lkeFK_APAssociatedSupplierID.BOSDescription = null;
            this.fld_lkeFK_APAssociatedSupplierID.BOSError = null;
            this.fld_lkeFK_APAssociatedSupplierID.BOSFieldGroup = "";
            this.fld_lkeFK_APAssociatedSupplierID.BOSFieldParent = "";
            this.fld_lkeFK_APAssociatedSupplierID.BOSFieldRelation = "";
            this.fld_lkeFK_APAssociatedSupplierID.BOSPrivilege = "";
            this.fld_lkeFK_APAssociatedSupplierID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APAssociatedSupplierID.BOSSelectType = "";
            this.fld_lkeFK_APAssociatedSupplierID.BOSSelectTypeValue = "";
            this.fld_lkeFK_APAssociatedSupplierID.CurrentDisplayText = null;
            this.fld_lkeFK_APAssociatedSupplierID.Location = new System.Drawing.Point(104, 10);
            this.fld_lkeFK_APAssociatedSupplierID.Name = "fld_lkeFK_APAssociatedSupplierID";
            this.fld_lkeFK_APAssociatedSupplierID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_APAssociatedSupplierID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_APAssociatedSupplierID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_APAssociatedSupplierID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_APAssociatedSupplierID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APAssociatedSupplierID.Properties.ColumnName = null;
            this.fld_lkeFK_APAssociatedSupplierID.Properties.DisplayMember = "APSupplierName";
            this.fld_lkeFK_APAssociatedSupplierID.Properties.NullText = "";
            this.fld_lkeFK_APAssociatedSupplierID.Properties.PopupWidth = 40;
            this.fld_lkeFK_APAssociatedSupplierID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APAssociatedSupplierID.Properties.ValueMember = "APSupplierID";
            this.fld_lkeFK_APAssociatedSupplierID.Screen = null;
            this.fld_lkeFK_APAssociatedSupplierID.Size = new System.Drawing.Size(215, 20);
            this.fld_lkeFK_APAssociatedSupplierID.TabIndex = 0;
            this.fld_lkeFK_APAssociatedSupplierID.Tag = "DC";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = "";
            this.bosLabel18.BOSDataMember = "";
            this.bosLabel18.BOSDataSource = "";
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = "";
            this.bosLabel18.BOSFieldRelation = "";
            this.bosLabel18.BOSPrivilege = "";
            this.bosLabel18.BOSPropertyName = "";
            this.bosLabel18.Location = new System.Drawing.Point(14, 143);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(58, 13);
            this.bosLabel18.TabIndex = 23;
            this.bosLabel18.Tag = "";
            this.bosLabel18.Text = "Tiền quy đổi";
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
            this.bosLabel20.BOSPropertyName = "";
            this.bosLabel20.Location = new System.Drawing.Point(14, 65);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(62, 13);
            this.bosLabel20.TabIndex = 19;
            this.bosLabel20.Tag = "";
            this.bosLabel20.Text = "Cách quy đổi";
            // 
            // bosLabel22
            // 
            this.bosLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.Options.UseBackColor = true;
            this.bosLabel22.Appearance.Options.UseForeColor = true;
            this.bosLabel22.BOSComment = "";
            this.bosLabel22.BOSDataMember = "";
            this.bosLabel22.BOSDataSource = "";
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = "";
            this.bosLabel22.BOSFieldRelation = "";
            this.bosLabel22.BOSPrivilege = "";
            this.bosLabel22.BOSPropertyName = "";
            this.bosLabel22.Location = new System.Drawing.Point(14, 39);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(53, 13);
            this.bosLabel22.TabIndex = 21;
            this.bosLabel22.Tag = "";
            this.bosLabel22.Text = "Loại tiền tệ";
            // 
            // bosLabel25
            // 
            this.bosLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.Options.UseBackColor = true;
            this.bosLabel25.Appearance.Options.UseForeColor = true;
            this.bosLabel25.BOSComment = "";
            this.bosLabel25.BOSDataMember = "";
            this.bosLabel25.BOSDataSource = "";
            this.bosLabel25.BOSDescription = null;
            this.bosLabel25.BOSError = null;
            this.bosLabel25.BOSFieldGroup = "";
            this.bosLabel25.BOSFieldRelation = "";
            this.bosLabel25.BOSPrivilege = "";
            this.bosLabel25.BOSPropertyName = "";
            this.bosLabel25.Location = new System.Drawing.Point(14, 13);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(84, 13);
            this.bosLabel25.TabIndex = 18;
            this.bosLabel25.Tag = "";
            this.bosLabel25.Text = "Người thanh toán";
            // 
            // fld_lkeFK_GEAssCurrencyID
            // 
            this.fld_lkeFK_GEAssCurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GEAssCurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GEAssCurrencyID.BOSComment = "";
            this.fld_lkeFK_GEAssCurrencyID.BOSDataMember = "FK_GEAssCurrencyID";
            this.fld_lkeFK_GEAssCurrencyID.BOSDataSource = "APSupplierPayments";
            this.fld_lkeFK_GEAssCurrencyID.BOSDescription = null;
            this.fld_lkeFK_GEAssCurrencyID.BOSError = null;
            this.fld_lkeFK_GEAssCurrencyID.BOSFieldGroup = "";
            this.fld_lkeFK_GEAssCurrencyID.BOSFieldParent = "";
            this.fld_lkeFK_GEAssCurrencyID.BOSFieldRelation = "";
            this.fld_lkeFK_GEAssCurrencyID.BOSPrivilege = "";
            this.fld_lkeFK_GEAssCurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEAssCurrencyID.BOSSelectType = "";
            this.fld_lkeFK_GEAssCurrencyID.BOSSelectTypeValue = "";
            this.fld_lkeFK_GEAssCurrencyID.CurrentDisplayText = null;
            this.fld_lkeFK_GEAssCurrencyID.Location = new System.Drawing.Point(104, 36);
            this.fld_lkeFK_GEAssCurrencyID.Name = "fld_lkeFK_GEAssCurrencyID";
            this.fld_lkeFK_GEAssCurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEAssCurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEAssCurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEAssCurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEAssCurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEAssCurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GEAssCurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GEAssCurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GEAssCurrencyID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GEAssCurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEAssCurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GEAssCurrencyID.Screen = null;
            this.fld_lkeFK_GEAssCurrencyID.Size = new System.Drawing.Size(215, 20);
            this.fld_lkeFK_GEAssCurrencyID.TabIndex = 1;
            this.fld_lkeFK_GEAssCurrencyID.Tag = "DC";
            this.fld_lkeFK_GEAssCurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GEAssCurrencyID_CloseUp);
            // 
            // fld_txtAPSupplierPaymentAssTotalAmount
            // 
            this.fld_txtAPSupplierPaymentAssTotalAmount.BOSComment = null;
            this.fld_txtAPSupplierPaymentAssTotalAmount.BOSDataMember = "APSupplierPaymentAssTotalAmount";
            this.fld_txtAPSupplierPaymentAssTotalAmount.BOSDataSource = "APSupplierPayments";
            this.fld_txtAPSupplierPaymentAssTotalAmount.BOSDescription = null;
            this.fld_txtAPSupplierPaymentAssTotalAmount.BOSError = null;
            this.fld_txtAPSupplierPaymentAssTotalAmount.BOSFieldGroup = null;
            this.fld_txtAPSupplierPaymentAssTotalAmount.BOSFieldRelation = null;
            this.fld_txtAPSupplierPaymentAssTotalAmount.BOSPrivilege = null;
            this.fld_txtAPSupplierPaymentAssTotalAmount.BOSPropertyName = "Text";
            this.fld_txtAPSupplierPaymentAssTotalAmount.Location = new System.Drawing.Point(104, 140);
            this.fld_txtAPSupplierPaymentAssTotalAmount.Name = "fld_txtAPSupplierPaymentAssTotalAmount";
            this.fld_txtAPSupplierPaymentAssTotalAmount.Properties.ReadOnly = true;
            this.fld_txtAPSupplierPaymentAssTotalAmount.Screen = null;
            this.fld_txtAPSupplierPaymentAssTotalAmount.Size = new System.Drawing.Size(215, 20);
            this.fld_txtAPSupplierPaymentAssTotalAmount.TabIndex = 5;
            this.fld_txtAPSupplierPaymentAssTotalAmount.Tag = "DC";
            // 
            // fld_txtAPSupplierPaymentAssExchangeRate
            // 
            this.fld_txtAPSupplierPaymentAssExchangeRate.BOSComment = null;
            this.fld_txtAPSupplierPaymentAssExchangeRate.BOSDataMember = "APSupplierPaymentAssExchangeRate";
            this.fld_txtAPSupplierPaymentAssExchangeRate.BOSDataSource = "APSupplierPayments";
            this.fld_txtAPSupplierPaymentAssExchangeRate.BOSDescription = null;
            this.fld_txtAPSupplierPaymentAssExchangeRate.BOSError = null;
            this.fld_txtAPSupplierPaymentAssExchangeRate.BOSFieldGroup = null;
            this.fld_txtAPSupplierPaymentAssExchangeRate.BOSFieldRelation = null;
            this.fld_txtAPSupplierPaymentAssExchangeRate.BOSPrivilege = null;
            this.fld_txtAPSupplierPaymentAssExchangeRate.BOSPropertyName = "Text";
            this.fld_txtAPSupplierPaymentAssExchangeRate.Location = new System.Drawing.Point(104, 114);
            this.fld_txtAPSupplierPaymentAssExchangeRate.Name = "fld_txtAPSupplierPaymentAssExchangeRate";
            this.fld_txtAPSupplierPaymentAssExchangeRate.Screen = null;
            this.fld_txtAPSupplierPaymentAssExchangeRate.Size = new System.Drawing.Size(215, 20);
            this.fld_txtAPSupplierPaymentAssExchangeRate.TabIndex = 4;
            this.fld_txtAPSupplierPaymentAssExchangeRate.Tag = "DC";
            // 
            // fld_txtAPSupplierPaymentAssPostingExchangeRate
            // 
            this.fld_txtAPSupplierPaymentAssPostingExchangeRate.BOSComment = null;
            this.fld_txtAPSupplierPaymentAssPostingExchangeRate.BOSDataMember = "APSupplierPaymentAssPostingExchangeRate";
            this.fld_txtAPSupplierPaymentAssPostingExchangeRate.BOSDataSource = "APSupplierPayments";
            this.fld_txtAPSupplierPaymentAssPostingExchangeRate.BOSDescription = null;
            this.fld_txtAPSupplierPaymentAssPostingExchangeRate.BOSError = null;
            this.fld_txtAPSupplierPaymentAssPostingExchangeRate.BOSFieldGroup = null;
            this.fld_txtAPSupplierPaymentAssPostingExchangeRate.BOSFieldRelation = null;
            this.fld_txtAPSupplierPaymentAssPostingExchangeRate.BOSPrivilege = null;
            this.fld_txtAPSupplierPaymentAssPostingExchangeRate.BOSPropertyName = "Text";
            this.fld_txtAPSupplierPaymentAssPostingExchangeRate.Location = new System.Drawing.Point(104, 88);
            this.fld_txtAPSupplierPaymentAssPostingExchangeRate.Name = "fld_txtAPSupplierPaymentAssPostingExchangeRate";
            this.fld_txtAPSupplierPaymentAssPostingExchangeRate.Properties.ReadOnly = true;
            this.fld_txtAPSupplierPaymentAssPostingExchangeRate.Screen = null;
            this.fld_txtAPSupplierPaymentAssPostingExchangeRate.Size = new System.Drawing.Size(215, 20);
            this.fld_txtAPSupplierPaymentAssPostingExchangeRate.TabIndex = 3;
            this.fld_txtAPSupplierPaymentAssPostingExchangeRate.Tag = "DC";
            // 
            // bosLabel26
            // 
            this.bosLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel26.Appearance.Options.UseBackColor = true;
            this.bosLabel26.Appearance.Options.UseForeColor = true;
            this.bosLabel26.BOSComment = "";
            this.bosLabel26.BOSDataMember = "";
            this.bosLabel26.BOSDataSource = "";
            this.bosLabel26.BOSDescription = null;
            this.bosLabel26.BOSError = null;
            this.bosLabel26.BOSFieldGroup = "";
            this.bosLabel26.BOSFieldRelation = "";
            this.bosLabel26.BOSPrivilege = "";
            this.bosLabel26.BOSPropertyName = "";
            this.bosLabel26.Location = new System.Drawing.Point(14, 117);
            this.bosLabel26.Name = "bosLabel26";
            this.bosLabel26.Screen = null;
            this.bosLabel26.Size = new System.Drawing.Size(67, 13);
            this.bosLabel26.TabIndex = 22;
            this.bosLabel26.Tag = "";
            this.bosLabel26.Text = "Tỷ giá quy đổi";
            // 
            // bosLabel27
            // 
            this.bosLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.Options.UseBackColor = true;
            this.bosLabel27.Appearance.Options.UseForeColor = true;
            this.bosLabel27.BOSComment = "";
            this.bosLabel27.BOSDataMember = "";
            this.bosLabel27.BOSDataSource = "";
            this.bosLabel27.BOSDescription = null;
            this.bosLabel27.BOSError = null;
            this.bosLabel27.BOSFieldGroup = "";
            this.bosLabel27.BOSFieldRelation = "";
            this.bosLabel27.BOSPrivilege = "";
            this.bosLabel27.BOSPropertyName = "";
            this.bosLabel27.Location = new System.Drawing.Point(14, 91);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.bosLabel27.Size = new System.Drawing.Size(29, 13);
            this.bosLabel27.TabIndex = 20;
            this.bosLabel27.Tag = "";
            this.bosLabel27.Text = "Tỷ giá";
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
            this.bosTabControl1.Location = new System.Drawing.Point(5, 220);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(1256, 417);
            this.bosTabControl1.TabIndex = 5;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.bosButton1);
            this.xtraTabPage1.Controls.Add(this.fld_dgcAPPaymentProposalPayments);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1254, 392);
            this.xtraTabPage1.Text = "Hóa đơn thanh toán";
            // 
            // bosButton1
            // 
            this.bosButton1.BOSComment = null;
            this.bosButton1.BOSDataMember = null;
            this.bosButton1.BOSDataSource = null;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = null;
            this.bosButton1.BOSFieldRelation = null;
            this.bosButton1.BOSPrivilege = null;
            this.bosButton1.BOSPropertyName = null;
            this.bosButton1.Location = new System.Drawing.Point(4, 5);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosButton1, true);
            this.bosButton1.Size = new System.Drawing.Size(122, 28);
            this.bosButton1.TabIndex = 0;
            this.bosButton1.Text = "Chọn đề nghị";
            this.bosButton1.Click += new System.EventHandler(this.bosButton1_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcDocumentEntrys);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1240, 385);
            this.xtraTabPage2.Text = "Hạch toán";
            // 
            // fld_dgcDocumentEntrys
            // 
            this.fld_dgcDocumentEntrys.AllowDrop = true;
            this.fld_dgcDocumentEntrys.BOSComment = "";
            this.fld_dgcDocumentEntrys.BOSDataMember = "";
            this.fld_dgcDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcDocumentEntrys.BOSDescription = null;
            this.fld_dgcDocumentEntrys.BOSError = null;
            this.fld_dgcDocumentEntrys.BOSFieldGroup = "";
            this.fld_dgcDocumentEntrys.BOSFieldRelation = "";
            this.fld_dgcDocumentEntrys.BOSGridType = null;
            this.fld_dgcDocumentEntrys.BOSPrivilege = "";
            this.fld_dgcDocumentEntrys.BOSPropertyName = "";
            this.fld_dgcDocumentEntrys.CommodityType = "";
            this.fld_dgcDocumentEntrys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcDocumentEntrys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcDocumentEntrys.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcDocumentEntrys.MainView = this.fld_dgvACBankTransactionItems;
            this.fld_dgcDocumentEntrys.Name = "fld_dgcDocumentEntrys";
            this.fld_dgcDocumentEntrys.PrintReport = false;
            this.fld_dgcDocumentEntrys.Screen = null;
            this.fld_dgcDocumentEntrys.Size = new System.Drawing.Size(1240, 385);
            this.fld_dgcDocumentEntrys.TabIndex = 2;
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
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = null;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "APSupplierPayments";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(5, 105);
            this.fld_lkeFK_HREmployeeID1.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
            // 
            // fld_pteAPSupplierPaymentEmployeePicture
            // 
            this.fld_pteAPSupplierPaymentEmployeePicture.BOSComment = null;
            this.fld_pteAPSupplierPaymentEmployeePicture.BOSDataMember = "APSupplierPaymentEmployeePicture";
            this.fld_pteAPSupplierPaymentEmployeePicture.BOSDataSource = "APSupplierPayments";
            this.fld_pteAPSupplierPaymentEmployeePicture.BOSDescription = null;
            this.fld_pteAPSupplierPaymentEmployeePicture.BOSError = null;
            this.fld_pteAPSupplierPaymentEmployeePicture.BOSFieldGroup = null;
            this.fld_pteAPSupplierPaymentEmployeePicture.BOSFieldRelation = null;
            this.fld_pteAPSupplierPaymentEmployeePicture.BOSPrivilege = null;
            this.fld_pteAPSupplierPaymentEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteAPSupplierPaymentEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteAPSupplierPaymentEmployeePicture.FileName = null;
            this.fld_pteAPSupplierPaymentEmployeePicture.FilePath = null;
            this.fld_pteAPSupplierPaymentEmployeePicture.Location = new System.Drawing.Point(5, 3);
            this.fld_pteAPSupplierPaymentEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteAPSupplierPaymentEmployeePicture.Name = "fld_pteAPSupplierPaymentEmployeePicture";
            this.fld_pteAPSupplierPaymentEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteAPSupplierPaymentEmployeePicture.Screen = null;
            this.fld_pteAPSupplierPaymentEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteAPSupplierPaymentEmployeePicture.TabIndex = 0;
            this.fld_pteAPSupplierPaymentEmployeePicture.Tag = "DC";
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
            this.bosGroupControl1.Controls.Add(this.fld_dgcAPSupplierPaymentDetails);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 643);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(1254, 157);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Thông tin thanh toán";
            // 
            // fld_dgcAPSupplierPaymentDetails
            // 
            this.fld_dgcAPSupplierPaymentDetails.AllowMultiplePayment = false;
            this.fld_dgcAPSupplierPaymentDetails.BOSComment = null;
            this.fld_dgcAPSupplierPaymentDetails.BOSDataMember = null;
            this.fld_dgcAPSupplierPaymentDetails.BOSDataSource = "APSupplierPaymentDetails";
            this.fld_dgcAPSupplierPaymentDetails.BOSDescription = null;
            this.fld_dgcAPSupplierPaymentDetails.BOSError = null;
            this.fld_dgcAPSupplierPaymentDetails.BOSFieldGroup = null;
            this.fld_dgcAPSupplierPaymentDetails.BOSFieldRelation = null;
            this.fld_dgcAPSupplierPaymentDetails.BOSGridType = null;
            this.fld_dgcAPSupplierPaymentDetails.BOSPrivilege = null;
            this.fld_dgcAPSupplierPaymentDetails.BOSPropertyName = null;
            this.fld_dgcAPSupplierPaymentDetails.CommodityType = "";
            this.fld_dgcAPSupplierPaymentDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcAPSupplierPaymentDetails.Location = new System.Drawing.Point(2, 23);
            this.fld_dgcAPSupplierPaymentDetails.MenuManager = this.screenToolbar;
            this.fld_dgcAPSupplierPaymentDetails.Name = "fld_dgcAPSupplierPaymentDetails";
            this.fld_dgcAPSupplierPaymentDetails.PaymentAmount = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.fld_dgcAPSupplierPaymentDetails.PrintReport = false;
            this.fld_dgcAPSupplierPaymentDetails.RequiredMethod = null;
            this.fld_dgcAPSupplierPaymentDetails.Screen = null;
            this.fld_dgcAPSupplierPaymentDetails.Size = new System.Drawing.Size(1250, 132);
            this.fld_dgcAPSupplierPaymentDetails.SupplierPaymentDetailList = null;
            this.fld_dgcAPSupplierPaymentDetails.TabIndex = 0;
            this.fld_dgcAPSupplierPaymentDetails.Tag = "DC";
            // 
            // fld_dgvAPDocumentPaymentDetails
            // 
            this.fld_dgvAPDocumentPaymentDetails.Name = "fld_dgvAPDocumentPaymentDetails";
            this.fld_dgvAPDocumentPaymentDetails.PaintStyleName = "Office2003";
            // 
            // fld_txtAPSupplierPaymentProject
            // 
            this.fld_txtAPSupplierPaymentProject.BOSComment = "";
            this.fld_txtAPSupplierPaymentProject.BOSDataMember = "APSupplierPaymentProject";
            this.fld_txtAPSupplierPaymentProject.BOSDataSource = "APSupplierPayments";
            this.fld_txtAPSupplierPaymentProject.BOSDescription = null;
            this.fld_txtAPSupplierPaymentProject.BOSError = null;
            this.fld_txtAPSupplierPaymentProject.BOSFieldGroup = "";
            this.fld_txtAPSupplierPaymentProject.BOSFieldRelation = "";
            this.fld_txtAPSupplierPaymentProject.BOSPrivilege = "";
            this.fld_txtAPSupplierPaymentProject.BOSPropertyName = "EditValue";
            this.fld_txtAPSupplierPaymentProject.EditValue = "";
            this.fld_txtAPSupplierPaymentProject.Location = new System.Drawing.Point(611, 48);
            this.fld_txtAPSupplierPaymentProject.Name = "fld_txtAPSupplierPaymentProject";
            this.fld_txtAPSupplierPaymentProject.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierPaymentProject.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierPaymentProject.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierPaymentProject.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierPaymentProject.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierPaymentProject.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtAPSupplierPaymentProject.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierPaymentProject.Screen = null;
            this.fld_txtAPSupplierPaymentProject.Size = new System.Drawing.Size(137, 20);
            this.fld_txtAPSupplierPaymentProject.TabIndex = 435;
            this.fld_txtAPSupplierPaymentProject.Tag = "DC";
            // 
            // DMAPSP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1269, 803);
            this.Controls.Add(this.bosPanel3);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMAPSP100.IconOptions.Icon")));
            this.Name = "DMAPSP100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPaymentProposalPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARInvoiceIns)).EndInit();
            this.bosPanel3.ResumeLayout(false);
            this.bosLine5.ResumeLayout(false);
            this.bosLine5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPSupplierPaymentBankFeeType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyBankID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPSupplierPaymentDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPSupplierPaymentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentBankFeeAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACLoanReceiptID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentBankAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCashFundID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAssObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPSupplierPaymentStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPSupplierPaymentDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_TabThanhToan)).EndInit();
            this.fld_TabThanhToan.ResumeLayout(false);
            this.fld_xtrTab1.ResumeLayout(false);
            this.fld_xtrTab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACListAccountBankID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentReceiverBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentObjectReceiptName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentReceiverAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentReceiverBankCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPSupplierPaymentReceiptAddress.Properties)).EndInit();
            this.fld_xtrTab2.ResumeLayout(false);
            this.fld_xtrTab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPSupplierPaymentAssExchangeWay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APAssociatedSupplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEAssCurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentAssTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentAssExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentAssPostingExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACBankTransactionItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteAPSupplierPaymentEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPSupplierPaymentDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPDocumentPaymentDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentProject.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel3;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPDocumentPaymentDetails;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtAPSupplierPaymentNo;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSDateEdit fld_dteAPSupplierPaymentDate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSPictureEdit fld_pteAPSupplierPaymentEmployeePicture;
        private BOSComponent.BOSTextBox fld_txtAPSupplierPaymentExchangeRate;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSMemoEdit fld_medAPSupplierPaymentDesc;
        private BOSComponent.BOSLookupEdit fld_lkeFK_CSCompanyBankID;
        private BOSComponent.BOSTextBox fld_txtAPSupplierPaymentBankAccount;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtAPSupplierPaymentTotalAmount;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DocumentEntryGridControl fld_dgcDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACBankTransactionItems;
        private APSupplierPaymentDetailsGridControl fld_dgcAPSupplierPaymentDetails;
        private BOSComponent.BOSButton bosButton1;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLookupEdit fld_lkeAPSupplierPaymentStatus;
        private AccObjectLookupEdit fld_lkeFK_ACAssObjectID;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLookupEdit fld_lkeFK_CSCashFundID;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACLoanReceiptID;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACListAccountBankID;
        private BOSComponent.BOSTextBox fld_txtAPSupplierPaymentReceiverBankName;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSMemoEdit fld_medAPSupplierPaymentReceiptAddress;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSTextBox fld_txtAPSupplierPaymentReceiverBankCode;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSTextBox fld_txtAPSupplierPaymentReceiverAccount;
        private BOSComponent.BOSTextBox fld_txtAPSupplierPaymentObjectReceiptName;
        private BOSComponent.BOSTabControl fld_TabThanhToan;
        private DevExpress.XtraTab.XtraTabPage fld_xtrTab1;
        private DevExpress.XtraTab.XtraTabPage fld_xtrTab2;
        private ExchangeWayLookupEdit fld_lkeAPSupplierPaymentAssExchangeWay;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APAssociatedSupplierID;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEAssCurrencyID;
        private BOSComponent.BOSTextBox fld_txtAPSupplierPaymentAssTotalAmount;
        private BOSComponent.BOSTextBox fld_txtAPSupplierPaymentAssExchangeRate;
        private BOSComponent.BOSTextBox fld_txtAPSupplierPaymentAssPostingExchangeRate;
        private BOSComponent.BOSLabel bosLabel26;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSTextBox fld_txtAPSupplierPaymentBankFeeAmount;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLine bosLine5;
        private BOSComponent.BOSLookupEdit fld_lkeAPSupplierPaymentBankFeeType;
        private BOSComponent.BOSTextBox fld_txtAPSupplierPaymentProject;
    }
}
