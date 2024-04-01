using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SaleCost.UI
{
    /// <summary>
    /// Summary description for DMSOC100
    /// </summary>
    partial class DMSOC100
    {
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSTextBox fld_txtACDocumentNo;
        private BOSComponent.BOSDateEdit fld_dteACDocumentDate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSTextBox fld_txtACDocumentExchangeRate;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMSOC100));
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACDocumentNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteACDocumentDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtACDocumentExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.fld_pteACDocumentEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_medACDocumentDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dgcDocumentEntrys = new BOSERP.Modules.SaleCost.UI.ACDocumentEntryGridControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.bosPanel3 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel33 = new BOSComponent.BOSLabel(this.components);
            this.fld_cbbDocumentCreateType = new BOSComponent.BOSComboBox(this.components);
            this.bosDateEdit3 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel32 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox8 = new BOSComponent.BOSTextBox(this.components);
            this.bosLookupEdit5 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox9 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox10 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACVATDocumentTypeFeePayment = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_tcDetail = new BOSComponent.BOSTabControl(this.components);
            this.fld_tpInvoice = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcAPFeePaymentInvoices = new BOSERP.Modules.SaleCost.APFeePaymentInvoicesGridControl();
            this.bosButton6 = new BOSComponent.BOSButton(this.components);
            this.fld_tpPaymentCommissions = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcARFeePaymentCommissions = new BOSERP.Modules.SaleCost.ARFeePaymentCommissionsGridControl();
            this.fld_tpFeeConfig = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcAPFeePaymentFeeConfigs = new BOSERP.Modules.SaleCost.APFeePaymentFeeConfigsGridControl();
            this.fld_tpDocumentEntry = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcDocumentEntry1s = new BOSERP.Modules.SaleCost.UI.ACDocumentEntryGridControl();
            this.bosPictureEdit2 = new BOSComponent.BOSPictureEdit(this.components);
            this.bosTextBox11 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox12 = new BOSComponent.BOSTextBox(this.components);
            this.bosMemoEdit2 = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLookupEdit7 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosTextBox13 = new BOSComponent.BOSTextBox(this.components);
            this.bosLookupEdit8 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosDateEdit2 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel26 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel28 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel29 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel30 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel31 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTabControl2 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.ACDocumentEntryGridControl1 = new BOSERP.BaseDocumentEntryGridControl();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.bosPictureEdit1 = new BOSComponent.BOSPictureEdit(this.components);
            this.bosTextBox5 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox6 = new BOSComponent.BOSTextBox(this.components);
            this.bosMemoEdit1 = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLookupEdit3 = new BOSComponent.BOSLookupEdit(this.components);
            this.accObjectLookupEdit1 = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosTextBox7 = new BOSComponent.BOSTextBox(this.components);
            this.bosLookupEdit4 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACDocumentVATSymbol = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeACVATInvoiceNoCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACDocumentVoucherNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACDocumentVATFormNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACVATDocumentType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnChooseReceipts = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACDocumentEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACDocumentDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.bosPanel2.SuspendLayout();
            this.bosPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cbbDocumentCreateType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit3.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACVATDocumentTypeFeePayment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tcDetail)).BeginInit();
            this.fld_tcDetail.SuspendLayout();
            this.fld_tpInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPFeePaymentInvoices)).BeginInit();
            this.fld_tpPaymentCommissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARFeePaymentCommissions)).BeginInit();
            this.fld_tpFeeConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPFeePaymentFeeConfigs)).BeginInit();
            this.fld_tpDocumentEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntry1s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox12.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox13.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl2)).BeginInit();
            this.bosTabControl2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ACDocumentEntryGridControl1)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosPictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accObjectLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentVATSymbol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACVATInvoiceNoCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentVoucherNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentVATFormNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACVATDocumentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(125, 12);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel4.TabIndex = 4;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Mã chứng từ";
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(390, 12);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel5.TabIndex = 5;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Ngày chứng từ";
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
            this.fld_lblLabel7.Location = new System.Drawing.Point(125, 64);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(53, 13);
            this.fld_lblLabel7.TabIndex = 7;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Loại tiền tệ";
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(125, 90);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(29, 13);
            this.fld_lblLabel2.TabIndex = 8;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Tỷ giá";
            // 
            // fld_txtACDocumentNo
            // 
            this.fld_txtACDocumentNo.BOSComment = "";
            this.fld_txtACDocumentNo.BOSDataMember = "ACDocumentNo";
            this.fld_txtACDocumentNo.BOSDataSource = "ACDocuments";
            this.fld_txtACDocumentNo.BOSDescription = null;
            this.fld_txtACDocumentNo.BOSError = null;
            this.fld_txtACDocumentNo.BOSFieldGroup = "";
            this.fld_txtACDocumentNo.BOSFieldRelation = "";
            this.fld_txtACDocumentNo.BOSPrivilege = "";
            this.fld_txtACDocumentNo.BOSPropertyName = "Text";
            this.fld_txtACDocumentNo.EditValue = "";
            this.fld_txtACDocumentNo.Location = new System.Drawing.Point(222, 9);
            this.fld_txtACDocumentNo.Name = "fld_txtACDocumentNo";
            this.fld_txtACDocumentNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACDocumentNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACDocumentNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACDocumentNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACDocumentNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACDocumentNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACDocumentNo.Screen = null;
            this.fld_txtACDocumentNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACDocumentNo.TabIndex = 0;
            this.fld_txtACDocumentNo.Tag = "DC";
            // 
            // fld_dteACDocumentDate
            // 
            this.fld_dteACDocumentDate.BOSComment = "";
            this.fld_dteACDocumentDate.BOSDataMember = "ACDocumentDate";
            this.fld_dteACDocumentDate.BOSDataSource = "ACDocuments";
            this.fld_dteACDocumentDate.BOSDescription = null;
            this.fld_dteACDocumentDate.BOSError = null;
            this.fld_dteACDocumentDate.BOSFieldGroup = "";
            this.fld_dteACDocumentDate.BOSFieldRelation = "";
            this.fld_dteACDocumentDate.BOSPrivilege = "";
            this.fld_dteACDocumentDate.BOSPropertyName = "EditValue";
            this.fld_dteACDocumentDate.EditValue = null;
            this.fld_dteACDocumentDate.Location = new System.Drawing.Point(491, 9);
            this.fld_dteACDocumentDate.Name = "fld_dteACDocumentDate";
            this.fld_dteACDocumentDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACDocumentDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACDocumentDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACDocumentDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACDocumentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACDocumentDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACDocumentDate.Screen = null;
            this.fld_dteACDocumentDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACDocumentDate.TabIndex = 1;
            this.fld_dteACDocumentDate.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = "";
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ACDocuments";
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
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 7;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = "";
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ACDocuments";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(222, 61);
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
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 4;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            // 
            // fld_txtACDocumentExchangeRate
            // 
            this.fld_txtACDocumentExchangeRate.BOSComment = "";
            this.fld_txtACDocumentExchangeRate.BOSDataMember = "ACDocumentExchangeRate";
            this.fld_txtACDocumentExchangeRate.BOSDataSource = "ACDocuments";
            this.fld_txtACDocumentExchangeRate.BOSDescription = null;
            this.fld_txtACDocumentExchangeRate.BOSError = null;
            this.fld_txtACDocumentExchangeRate.BOSFieldGroup = "";
            this.fld_txtACDocumentExchangeRate.BOSFieldRelation = "";
            this.fld_txtACDocumentExchangeRate.BOSPrivilege = "";
            this.fld_txtACDocumentExchangeRate.BOSPropertyName = "Text";
            this.fld_txtACDocumentExchangeRate.EditValue = "";
            this.fld_txtACDocumentExchangeRate.Location = new System.Drawing.Point(222, 87);
            this.fld_txtACDocumentExchangeRate.Name = "fld_txtACDocumentExchangeRate";
            this.fld_txtACDocumentExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACDocumentExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACDocumentExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACDocumentExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACDocumentExchangeRate.Properties.Mask.EditMask = "n";
            this.fld_txtACDocumentExchangeRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtACDocumentExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACDocumentExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACDocumentExchangeRate.Screen = null;
            this.fld_txtACDocumentExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACDocumentExchangeRate.TabIndex = 5;
            this.fld_txtACDocumentExchangeRate.Tag = "DC";
            this.fld_txtACDocumentExchangeRate.EditValueChanged += new System.EventHandler(this.fld_txtACDocumentExchangeRate_EditValueChanged);
            // 
            // fld_pteACDocumentEmployeePicture
            // 
            this.fld_pteACDocumentEmployeePicture.BOSComment = null;
            this.fld_pteACDocumentEmployeePicture.BOSDataMember = "ACDocumentEmployeePicture";
            this.fld_pteACDocumentEmployeePicture.BOSDataSource = "ACDocuments";
            this.fld_pteACDocumentEmployeePicture.BOSDescription = null;
            this.fld_pteACDocumentEmployeePicture.BOSError = null;
            this.fld_pteACDocumentEmployeePicture.BOSFieldGroup = null;
            this.fld_pteACDocumentEmployeePicture.BOSFieldRelation = null;
            this.fld_pteACDocumentEmployeePicture.BOSPrivilege = null;
            this.fld_pteACDocumentEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteACDocumentEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteACDocumentEmployeePicture.FileName = null;
            this.fld_pteACDocumentEmployeePicture.FilePath = null;
            this.fld_pteACDocumentEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteACDocumentEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteACDocumentEmployeePicture.Name = "fld_pteACDocumentEmployeePicture";
            this.fld_pteACDocumentEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteACDocumentEmployeePicture.Screen = null;
            this.fld_pteACDocumentEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteACDocumentEmployeePicture.TabIndex = 15;
            this.fld_pteACDocumentEmployeePicture.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(125, 116);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(40, 13);
            this.bosLabel1.TabIndex = 6;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Diễn giải";
            // 
            // fld_medACDocumentDesc
            // 
            this.fld_medACDocumentDesc.BOSComment = null;
            this.fld_medACDocumentDesc.BOSDataMember = "ACDocumentDesc";
            this.fld_medACDocumentDesc.BOSDataSource = "ACDocuments";
            this.fld_medACDocumentDesc.BOSDescription = null;
            this.fld_medACDocumentDesc.BOSError = null;
            this.fld_medACDocumentDesc.BOSFieldGroup = null;
            this.fld_medACDocumentDesc.BOSFieldRelation = null;
            this.fld_medACDocumentDesc.BOSPrivilege = null;
            this.fld_medACDocumentDesc.BOSPropertyName = "EditValue";
            this.fld_medACDocumentDesc.Location = new System.Drawing.Point(222, 113);
            this.fld_medACDocumentDesc.MenuManager = this.screenToolbar;
            this.fld_medACDocumentDesc.Name = "fld_medACDocumentDesc";
            this.fld_medACDocumentDesc.Screen = null;
            this.fld_medACDocumentDesc.Size = new System.Drawing.Size(424, 24);
            this.fld_medACDocumentDesc.TabIndex = 6;
            this.fld_medACDocumentDesc.Tag = "DC";
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
            this.fld_dgcDocumentEntrys.Size = new System.Drawing.Size(958, 358);
            this.fld_dgcDocumentEntrys.TabIndex = 0;
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
            this.bosPanel1.Controls.Add(this.bosPanel2);
            this.bosPanel1.Controls.Add(this.bosLabel20);
            this.bosPanel1.Controls.Add(this.fld_txtACDocumentVATSymbol);
            this.bosPanel1.Controls.Add(this.fld_lkeACVATInvoiceNoCombo);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.bosLabel19);
            this.bosPanel1.Controls.Add(this.fld_txtACDocumentVoucherNo);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_txtACDocumentVATFormNo);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_lkeACVATDocumentType);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.fld_pteACDocumentEmployeePicture);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.fld_txtACDocumentExchangeRate);
            this.bosPanel1.Controls.Add(this.fld_medACDocumentDesc);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Controls.Add(this.fld_txtACDocumentNo);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.fld_lblLabel4);
            this.bosPanel1.Controls.Add(this.fld_dteACDocumentDate);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_lblLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel7);
            this.bosPanel1.Controls.Add(this.fld_lblLabel6);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(976, 538);
            this.bosPanel1.TabIndex = 18;
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
            this.bosPanel2.Controls.Add(this.bosPanel3);
            this.bosPanel2.Controls.Add(this.bosLabel3);
            this.bosPanel2.Controls.Add(this.bosTextBox2);
            this.bosPanel2.Controls.Add(this.bosLookupEdit1);
            this.bosPanel2.Controls.Add(this.bosLabel4);
            this.bosPanel2.Controls.Add(this.bosLabel5);
            this.bosPanel2.Controls.Add(this.bosTextBox3);
            this.bosPanel2.Controls.Add(this.bosLabel6);
            this.bosPanel2.Controls.Add(this.bosTextBox4);
            this.bosPanel2.Controls.Add(this.bosLabel7);
            this.bosPanel2.Controls.Add(this.bosLookupEdit2);
            this.bosPanel2.Controls.Add(this.bosTabControl2);
            this.bosPanel2.Controls.Add(this.bosPictureEdit1);
            this.bosPanel2.Controls.Add(this.bosTextBox5);
            this.bosPanel2.Controls.Add(this.bosTextBox6);
            this.bosPanel2.Controls.Add(this.bosMemoEdit1);
            this.bosPanel2.Controls.Add(this.bosLookupEdit3);
            this.bosPanel2.Controls.Add(this.accObjectLookupEdit1);
            this.bosPanel2.Controls.Add(this.bosTextBox7);
            this.bosPanel2.Controls.Add(this.bosLookupEdit4);
            this.bosPanel2.Controls.Add(this.bosLabel9);
            this.bosPanel2.Controls.Add(this.bosDateEdit1);
            this.bosPanel2.Controls.Add(this.bosLabel12);
            this.bosPanel2.Controls.Add(this.bosLabel13);
            this.bosPanel2.Controls.Add(this.bosLabel14);
            this.bosPanel2.Controls.Add(this.bosLabel15);
            this.bosPanel2.Controls.Add(this.bosLabel16);
            this.bosPanel2.Controls.Add(this.bosLabel17);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(976, 538);
            this.bosPanel2.TabIndex = 121;
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
            this.bosPanel3.Controls.Add(this.bosLabel33);
            this.bosPanel3.Controls.Add(this.fld_cbbDocumentCreateType);
            this.bosPanel3.Controls.Add(this.bosDateEdit3);
            this.bosPanel3.Controls.Add(this.bosLabel32);
            this.bosPanel3.Controls.Add(this.bosLabel18);
            this.bosPanel3.Controls.Add(this.bosTextBox8);
            this.bosPanel3.Controls.Add(this.bosLookupEdit5);
            this.bosPanel3.Controls.Add(this.bosLabel21);
            this.bosPanel3.Controls.Add(this.bosLabel22);
            this.bosPanel3.Controls.Add(this.bosTextBox9);
            this.bosPanel3.Controls.Add(this.bosLabel23);
            this.bosPanel3.Controls.Add(this.bosTextBox10);
            this.bosPanel3.Controls.Add(this.bosLabel24);
            this.bosPanel3.Controls.Add(this.fld_lkeACVATDocumentTypeFeePayment);
            this.bosPanel3.Controls.Add(this.fld_tcDetail);
            this.bosPanel3.Controls.Add(this.bosPictureEdit2);
            this.bosPanel3.Controls.Add(this.bosTextBox11);
            this.bosPanel3.Controls.Add(this.bosTextBox12);
            this.bosPanel3.Controls.Add(this.bosMemoEdit2);
            this.bosPanel3.Controls.Add(this.bosLookupEdit7);
            this.bosPanel3.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel3.Controls.Add(this.bosTextBox13);
            this.bosPanel3.Controls.Add(this.bosLookupEdit8);
            this.bosPanel3.Controls.Add(this.bosLabel25);
            this.bosPanel3.Controls.Add(this.bosDateEdit2);
            this.bosPanel3.Controls.Add(this.bosLabel26);
            this.bosPanel3.Controls.Add(this.bosLabel27);
            this.bosPanel3.Controls.Add(this.bosLabel28);
            this.bosPanel3.Controls.Add(this.bosLabel29);
            this.bosPanel3.Controls.Add(this.bosLabel30);
            this.bosPanel3.Controls.Add(this.bosLabel31);
            this.bosPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel3.Location = new System.Drawing.Point(0, 0);
            this.bosPanel3.Name = "bosPanel3";
            this.bosPanel3.Screen = null;
            this.bosPanel3.Size = new System.Drawing.Size(976, 538);
            this.bosPanel3.TabIndex = 0;
            // 
            // bosLabel33
            // 
            this.bosLabel33.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel33.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel33.Appearance.Options.UseBackColor = true;
            this.bosLabel33.Appearance.Options.UseForeColor = true;
            this.bosLabel33.BOSComment = "";
            this.bosLabel33.BOSDataMember = "";
            this.bosLabel33.BOSDataSource = "";
            this.bosLabel33.BOSDescription = null;
            this.bosLabel33.BOSError = null;
            this.bosLabel33.BOSFieldGroup = "";
            this.bosLabel33.BOSFieldRelation = "";
            this.bosLabel33.BOSPrivilege = "";
            this.bosLabel33.BOSPropertyName = null;
            this.bosLabel33.Location = new System.Drawing.Point(390, 65);
            this.bosLabel33.Name = "bosLabel33";
            this.bosLabel33.Screen = null;
            this.bosLabel33.Size = new System.Drawing.Size(66, 13);
            this.bosLabel33.TabIndex = 124;
            this.bosLabel33.Tag = "";
            this.bosLabel33.Text = "Loại chứng từ";
            // 
            // fld_cbbDocumentCreateType
            // 
            this.fld_cbbDocumentCreateType.BOSComment = null;
            this.fld_cbbDocumentCreateType.BOSDataMember = null;
            this.fld_cbbDocumentCreateType.BOSDataSource = null;
            this.fld_cbbDocumentCreateType.BOSDescription = null;
            this.fld_cbbDocumentCreateType.BOSError = null;
            this.fld_cbbDocumentCreateType.BOSFieldGroup = null;
            this.fld_cbbDocumentCreateType.BOSFieldRelation = null;
            this.fld_cbbDocumentCreateType.BOSPrivilege = null;
            this.fld_cbbDocumentCreateType.BOSPropertyName = null;
            this.fld_cbbDocumentCreateType.Location = new System.Drawing.Point(491, 62);
            this.fld_cbbDocumentCreateType.MenuManager = this.screenToolbar;
            this.fld_cbbDocumentCreateType.Name = "fld_cbbDocumentCreateType";
            this.fld_cbbDocumentCreateType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cbbDocumentCreateType.Properties.Items.AddRange(new object[] {
            "Hoa hồng",
            "Chi phí bán hàng"});
            this.fld_cbbDocumentCreateType.Properties.ReadOnly = true;
            this.fld_cbbDocumentCreateType.Screen = null;
            this.fld_cbbDocumentCreateType.Size = new System.Drawing.Size(150, 20);
            this.fld_cbbDocumentCreateType.TabIndex = 7;
            // 
            // bosDateEdit3
            // 
            this.bosDateEdit3.BOSComment = "";
            this.bosDateEdit3.BOSDataMember = "ACDocumentInvoiceDate";
            this.bosDateEdit3.BOSDataSource = "ACDocuments";
            this.bosDateEdit3.BOSDescription = null;
            this.bosDateEdit3.BOSError = null;
            this.bosDateEdit3.BOSFieldGroup = "";
            this.bosDateEdit3.BOSFieldRelation = "";
            this.bosDateEdit3.BOSPrivilege = "";
            this.bosDateEdit3.BOSPropertyName = "EditValue";
            this.bosDateEdit3.EditValue = null;
            this.bosDateEdit3.Location = new System.Drawing.Point(751, 140);
            this.bosDateEdit3.Name = "bosDateEdit3";
            this.bosDateEdit3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit3.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit3.Screen = null;
            this.bosDateEdit3.Size = new System.Drawing.Size(159, 20);
            this.bosDateEdit3.TabIndex = 14;
            this.bosDateEdit3.Tag = "DC";
            this.bosDateEdit3.Visible = false;
            // 
            // bosLabel32
            // 
            this.bosLabel32.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel32.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel32.Appearance.Options.UseBackColor = true;
            this.bosLabel32.Appearance.Options.UseForeColor = true;
            this.bosLabel32.BOSComment = "";
            this.bosLabel32.BOSDataMember = "";
            this.bosLabel32.BOSDataSource = "";
            this.bosLabel32.BOSDescription = null;
            this.bosLabel32.BOSError = null;
            this.bosLabel32.BOSFieldGroup = "";
            this.bosLabel32.BOSFieldRelation = "";
            this.bosLabel32.BOSPrivilege = "";
            this.bosLabel32.BOSPropertyName = "";
            this.bosLabel32.Location = new System.Drawing.Point(670, 143);
            this.bosLabel32.Name = "bosLabel32";
            this.bosLabel32.Screen = null;
            this.bosLabel32.Size = new System.Drawing.Size(67, 13);
            this.bosLabel32.TabIndex = 122;
            this.bosLabel32.Tag = "";
            this.bosLabel32.Text = "Ngày hóa đơn";
            this.bosLabel32.Visible = false;
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
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(671, 90);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(35, 13);
            this.bosLabel18.TabIndex = 120;
            this.bosLabel18.Tag = "";
            this.bosLabel18.Text = "Ký hiệu";
            this.bosLabel18.Visible = false;
            // 
            // bosTextBox8
            // 
            this.bosTextBox8.BOSComment = "";
            this.bosTextBox8.BOSDataMember = "ACDocumentVATSymbol";
            this.bosTextBox8.BOSDataSource = "ACDocuments";
            this.bosTextBox8.BOSDescription = null;
            this.bosTextBox8.BOSError = null;
            this.bosTextBox8.BOSFieldGroup = "";
            this.bosTextBox8.BOSFieldRelation = "";
            this.bosTextBox8.BOSPrivilege = "";
            this.bosTextBox8.BOSPropertyName = "EditValue";
            this.bosTextBox8.EditValue = "";
            this.bosTextBox8.Location = new System.Drawing.Point(751, 87);
            this.bosTextBox8.Name = "bosTextBox8";
            this.bosTextBox8.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox8.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox8.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox8.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox8.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bosTextBox8.Properties.Mask.EditMask = "n";
            this.bosTextBox8.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox8.Screen = null;
            this.bosTextBox8.Size = new System.Drawing.Size(159, 20);
            this.bosTextBox8.TabIndex = 11;
            this.bosTextBox8.Tag = "DC";
            this.bosTextBox8.Visible = false;
            // 
            // bosLookupEdit5
            // 
            this.bosLookupEdit5.BOSAllowAddNew = false;
            this.bosLookupEdit5.BOSAllowDummy = true;
            this.bosLookupEdit5.BOSComment = "";
            this.bosLookupEdit5.BOSDataMember = "ACVATInvoiceNoCombo";
            this.bosLookupEdit5.BOSDataSource = "ACDocuments";
            this.bosLookupEdit5.BOSDescription = null;
            this.bosLookupEdit5.BOSError = null;
            this.bosLookupEdit5.BOSFieldGroup = "";
            this.bosLookupEdit5.BOSFieldParent = "";
            this.bosLookupEdit5.BOSFieldRelation = "";
            this.bosLookupEdit5.BOSPrivilege = "";
            this.bosLookupEdit5.BOSPropertyName = "EditValue";
            this.bosLookupEdit5.BOSSelectType = "";
            this.bosLookupEdit5.BOSSelectTypeValue = "";
            this.bosLookupEdit5.CurrentDisplayText = null;
            this.bosLookupEdit5.Location = new System.Drawing.Point(751, 114);
            this.bosLookupEdit5.Name = "bosLookupEdit5";
            this.bosLookupEdit5.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit5.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit5.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit5.Properties.ColumnName = null;
            this.bosLookupEdit5.Properties.NullText = "";
            this.bosLookupEdit5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit5.Screen = null;
            this.bosLookupEdit5.Size = new System.Drawing.Size(159, 20);
            this.bosLookupEdit5.TabIndex = 13;
            this.bosLookupEdit5.Tag = "DC";
            this.bosLookupEdit5.Visible = false;
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
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(671, 117);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(61, 13);
            this.bosLabel21.TabIndex = 119;
            this.bosLabel21.Tag = "";
            this.bosLabel21.Text = "Mã HĐ GTGT";
            this.bosLabel21.Visible = false;
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
            this.bosLabel22.BOSPropertyName = null;
            this.bosLabel22.Location = new System.Drawing.Point(671, 64);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(54, 13);
            this.bosLabel22.TabIndex = 118;
            this.bosLabel22.Tag = "";
            this.bosLabel22.Text = "Số hóa đơn";
            this.bosLabel22.Visible = false;
            // 
            // bosTextBox9
            // 
            this.bosTextBox9.BOSComment = "";
            this.bosTextBox9.BOSDataMember = "ACDocumentVoucherNo";
            this.bosTextBox9.BOSDataSource = "ACDocuments";
            this.bosTextBox9.BOSDescription = null;
            this.bosTextBox9.BOSError = null;
            this.bosTextBox9.BOSFieldGroup = "";
            this.bosTextBox9.BOSFieldRelation = "";
            this.bosTextBox9.BOSPrivilege = "";
            this.bosTextBox9.BOSPropertyName = "EditValue";
            this.bosTextBox9.EditValue = "";
            this.bosTextBox9.Location = new System.Drawing.Point(751, 62);
            this.bosTextBox9.Name = "bosTextBox9";
            this.bosTextBox9.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox9.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox9.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox9.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox9.Properties.Mask.EditMask = "n";
            this.bosTextBox9.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox9.Screen = null;
            this.bosTextBox9.Size = new System.Drawing.Size(159, 20);
            this.bosTextBox9.TabIndex = 8;
            this.bosTextBox9.Tag = "DC";
            this.bosTextBox9.Visible = false;
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
            this.bosLabel23.BOSPropertyName = null;
            this.bosLabel23.Location = new System.Drawing.Point(671, 39);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(34, 13);
            this.bosLabel23.TabIndex = 117;
            this.bosLabel23.Tag = "";
            this.bosLabel23.Text = "Mẫu số";
            this.bosLabel23.Visible = false;
            // 
            // bosTextBox10
            // 
            this.bosTextBox10.BOSComment = "";
            this.bosTextBox10.BOSDataMember = "ACDocumentVATFormNo";
            this.bosTextBox10.BOSDataSource = "ACDocuments";
            this.bosTextBox10.BOSDescription = null;
            this.bosTextBox10.BOSError = null;
            this.bosTextBox10.BOSFieldGroup = "";
            this.bosTextBox10.BOSFieldRelation = "";
            this.bosTextBox10.BOSPrivilege = "";
            this.bosTextBox10.BOSPropertyName = "EditValue";
            this.bosTextBox10.EditValue = "";
            this.bosTextBox10.Location = new System.Drawing.Point(751, 36);
            this.bosTextBox10.Name = "bosTextBox10";
            this.bosTextBox10.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox10.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox10.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox10.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox10.Properties.Mask.EditMask = "n";
            this.bosTextBox10.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox10.Screen = null;
            this.bosTextBox10.Size = new System.Drawing.Size(159, 20);
            this.bosTextBox10.TabIndex = 5;
            this.bosTextBox10.Tag = "DC";
            this.bosTextBox10.Visible = false;
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
            this.bosLabel24.Location = new System.Drawing.Point(670, 12);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(61, 13);
            this.bosLabel24.TabIndex = 116;
            this.bosLabel24.Tag = "";
            this.bosLabel24.Text = "Loại hóa đơn";
            this.bosLabel24.Visible = false;
            // 
            // fld_lkeACVATDocumentTypeFeePayment
            // 
            this.fld_lkeACVATDocumentTypeFeePayment.BOSAllowAddNew = false;
            this.fld_lkeACVATDocumentTypeFeePayment.BOSAllowDummy = false;
            this.fld_lkeACVATDocumentTypeFeePayment.BOSComment = "";
            this.fld_lkeACVATDocumentTypeFeePayment.BOSDataMember = "ACVATDocumentTypeFeePayment";
            this.fld_lkeACVATDocumentTypeFeePayment.BOSDataSource = "ACDocuments";
            this.fld_lkeACVATDocumentTypeFeePayment.BOSDescription = null;
            this.fld_lkeACVATDocumentTypeFeePayment.BOSError = null;
            this.fld_lkeACVATDocumentTypeFeePayment.BOSFieldGroup = "";
            this.fld_lkeACVATDocumentTypeFeePayment.BOSFieldParent = "";
            this.fld_lkeACVATDocumentTypeFeePayment.BOSFieldRelation = "";
            this.fld_lkeACVATDocumentTypeFeePayment.BOSPrivilege = "";
            this.fld_lkeACVATDocumentTypeFeePayment.BOSPropertyName = "EditValue";
            this.fld_lkeACVATDocumentTypeFeePayment.BOSSelectType = "";
            this.fld_lkeACVATDocumentTypeFeePayment.BOSSelectTypeValue = "";
            this.fld_lkeACVATDocumentTypeFeePayment.CurrentDisplayText = null;
            this.fld_lkeACVATDocumentTypeFeePayment.Location = new System.Drawing.Point(751, 9);
            this.fld_lkeACVATDocumentTypeFeePayment.Name = "fld_lkeACVATDocumentTypeFeePayment";
            this.fld_lkeACVATDocumentTypeFeePayment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACVATDocumentTypeFeePayment.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACVATDocumentTypeFeePayment.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACVATDocumentTypeFeePayment.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACVATDocumentTypeFeePayment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACVATDocumentTypeFeePayment.Properties.ColumnName = null;
            this.fld_lkeACVATDocumentTypeFeePayment.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADConfigText", "Loại hóa đơn")});
            this.fld_lkeACVATDocumentTypeFeePayment.Properties.DisplayMember = "ADConfigText";
            this.fld_lkeACVATDocumentTypeFeePayment.Properties.NullText = "";
            this.fld_lkeACVATDocumentTypeFeePayment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACVATDocumentTypeFeePayment.Properties.ValueMember = "ADConfigKeyValue";
            this.fld_lkeACVATDocumentTypeFeePayment.Screen = null;
            this.fld_lkeACVATDocumentTypeFeePayment.Size = new System.Drawing.Size(159, 20);
            this.fld_lkeACVATDocumentTypeFeePayment.TabIndex = 2;
            this.fld_lkeACVATDocumentTypeFeePayment.Tag = "DC";
            this.fld_lkeACVATDocumentTypeFeePayment.Visible = false;
            // 
            // fld_tcDetail
            // 
            this.fld_tcDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tcDetail.BOSComment = null;
            this.fld_tcDetail.BOSDataMember = null;
            this.fld_tcDetail.BOSDataSource = null;
            this.fld_tcDetail.BOSDescription = null;
            this.fld_tcDetail.BOSError = null;
            this.fld_tcDetail.BOSFieldGroup = null;
            this.fld_tcDetail.BOSFieldRelation = null;
            this.fld_tcDetail.BOSPrivilege = null;
            this.fld_tcDetail.BOSPropertyName = null;
            this.fld_tcDetail.Location = new System.Drawing.Point(3, 167);
            this.fld_tcDetail.Name = "fld_tcDetail";
            this.fld_tcDetail.Screen = null;
            this.fld_tcDetail.SelectedTabPage = this.fld_tpInvoice;
            this.fld_tcDetail.Size = new System.Drawing.Size(960, 359);
            this.fld_tcDetail.TabIndex = 10;
            this.fld_tcDetail.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tpInvoice,
            this.fld_tpPaymentCommissions,
            this.fld_tpFeeConfig,
            this.fld_tpDocumentEntry});
            this.fld_tcDetail.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.fld_tcDetail_SelectedPageChanged);
            // 
            // fld_tpInvoice
            // 
            this.fld_tpInvoice.Controls.Add(this.fld_dgcAPFeePaymentInvoices);
            this.fld_tpInvoice.Controls.Add(this.bosButton6);
            this.fld_tpInvoice.Name = "fld_tpInvoice";
            this.fld_tpInvoice.Size = new System.Drawing.Size(958, 334);
            this.fld_tpInvoice.Text = "Danh sách hóa đơn bán hàng";
            // 
            // fld_dgcAPFeePaymentInvoices
            // 
            this.fld_dgcAPFeePaymentInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPFeePaymentInvoices.BOSComment = null;
            this.fld_dgcAPFeePaymentInvoices.BOSDataMember = null;
            this.fld_dgcAPFeePaymentInvoices.BOSDataSource = "APFeePaymentInvoices";
            this.fld_dgcAPFeePaymentInvoices.BOSDescription = null;
            this.fld_dgcAPFeePaymentInvoices.BOSError = null;
            this.fld_dgcAPFeePaymentInvoices.BOSFieldGroup = null;
            this.fld_dgcAPFeePaymentInvoices.BOSFieldRelation = null;
            this.fld_dgcAPFeePaymentInvoices.BOSGridType = null;
            this.fld_dgcAPFeePaymentInvoices.BOSPrivilege = null;
            this.fld_dgcAPFeePaymentInvoices.BOSPropertyName = null;
            this.fld_dgcAPFeePaymentInvoices.CommodityType = "";
            this.fld_dgcAPFeePaymentInvoices.Location = new System.Drawing.Point(5, 37);
            this.fld_dgcAPFeePaymentInvoices.MenuManager = this.screenToolbar;
            this.fld_dgcAPFeePaymentInvoices.Name = "fld_dgcAPFeePaymentInvoices";
            this.fld_dgcAPFeePaymentInvoices.PrintReport = false;
            this.fld_dgcAPFeePaymentInvoices.Screen = null;
            this.fld_dgcAPFeePaymentInvoices.Size = new System.Drawing.Size(948, 292);
            this.fld_dgcAPFeePaymentInvoices.TabIndex = 5;
            this.fld_dgcAPFeePaymentInvoices.Tag = "DC";
            // 
            // bosButton6
            // 
            this.bosButton6.BOSComment = null;
            this.bosButton6.BOSDataMember = null;
            this.bosButton6.BOSDataSource = null;
            this.bosButton6.BOSDescription = null;
            this.bosButton6.BOSError = null;
            this.bosButton6.BOSFieldGroup = null;
            this.bosButton6.BOSFieldRelation = null;
            this.bosButton6.BOSPrivilege = null;
            this.bosButton6.BOSPropertyName = null;
            this.bosButton6.Location = new System.Drawing.Point(5, 4);
            this.bosButton6.Name = "bosButton6";
            this.bosButton6.Screen = null;
            this.bosButton6.Size = new System.Drawing.Size(134, 27);
            this.bosButton6.TabIndex = 4;
            this.bosButton6.Text = "Chọn hóa đơn bán hàng";
            this.bosButton6.Click += new System.EventHandler(this.bosButton6_Click);
            // 
            // fld_tpPaymentCommissions
            // 
            this.fld_tpPaymentCommissions.Controls.Add(this.fld_dgcARFeePaymentCommissions);
            this.fld_tpPaymentCommissions.Name = "fld_tpPaymentCommissions";
            this.fld_tpPaymentCommissions.Size = new System.Drawing.Size(944, 327);
            this.fld_tpPaymentCommissions.Text = "Hoa hồng người giới thiệu";
            // 
            // fld_dgcARFeePaymentCommissions
            // 
            this.fld_dgcARFeePaymentCommissions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARFeePaymentCommissions.BOSComment = null;
            this.fld_dgcARFeePaymentCommissions.BOSDataMember = null;
            this.fld_dgcARFeePaymentCommissions.BOSDataSource = "ARFeePaymentCommissions";
            this.fld_dgcARFeePaymentCommissions.BOSDescription = null;
            this.fld_dgcARFeePaymentCommissions.BOSError = null;
            this.fld_dgcARFeePaymentCommissions.BOSFieldGroup = null;
            this.fld_dgcARFeePaymentCommissions.BOSFieldRelation = null;
            this.fld_dgcARFeePaymentCommissions.BOSGridType = null;
            this.fld_dgcARFeePaymentCommissions.BOSPrivilege = null;
            this.fld_dgcARFeePaymentCommissions.BOSPropertyName = null;
            this.fld_dgcARFeePaymentCommissions.CommodityType = "";
            this.fld_dgcARFeePaymentCommissions.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcARFeePaymentCommissions.MenuManager = this.screenToolbar;
            this.fld_dgcARFeePaymentCommissions.Name = "fld_dgcARFeePaymentCommissions";
            this.fld_dgcARFeePaymentCommissions.PrintReport = false;
            this.fld_dgcARFeePaymentCommissions.Screen = null;
            this.fld_dgcARFeePaymentCommissions.Size = new System.Drawing.Size(938, 321);
            this.fld_dgcARFeePaymentCommissions.TabIndex = 1;
            this.fld_dgcARFeePaymentCommissions.Tag = "DC";
            // 
            // fld_tpFeeConfig
            // 
            this.fld_tpFeeConfig.Controls.Add(this.fld_dgcAPFeePaymentFeeConfigs);
            this.fld_tpFeeConfig.Name = "fld_tpFeeConfig";
            this.fld_tpFeeConfig.Size = new System.Drawing.Size(958, 334);
            this.fld_tpFeeConfig.Text = "Phí làm hàng";
            // 
            // fld_dgcAPFeePaymentFeeConfigs
            // 
            this.fld_dgcAPFeePaymentFeeConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPFeePaymentFeeConfigs.BOSComment = null;
            this.fld_dgcAPFeePaymentFeeConfigs.BOSDataMember = null;
            this.fld_dgcAPFeePaymentFeeConfigs.BOSDataSource = "APFeePaymentFeeConfigs";
            this.fld_dgcAPFeePaymentFeeConfigs.BOSDescription = null;
            this.fld_dgcAPFeePaymentFeeConfigs.BOSError = null;
            this.fld_dgcAPFeePaymentFeeConfigs.BOSFieldGroup = null;
            this.fld_dgcAPFeePaymentFeeConfigs.BOSFieldRelation = null;
            this.fld_dgcAPFeePaymentFeeConfigs.BOSGridType = null;
            this.fld_dgcAPFeePaymentFeeConfigs.BOSPrivilege = null;
            this.fld_dgcAPFeePaymentFeeConfigs.BOSPropertyName = null;
            this.fld_dgcAPFeePaymentFeeConfigs.CommodityType = "";
            this.fld_dgcAPFeePaymentFeeConfigs.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcAPFeePaymentFeeConfigs.MenuManager = this.screenToolbar;
            this.fld_dgcAPFeePaymentFeeConfigs.Name = "fld_dgcAPFeePaymentFeeConfigs";
            this.fld_dgcAPFeePaymentFeeConfigs.PrintReport = false;
            this.fld_dgcAPFeePaymentFeeConfigs.Screen = null;
            this.fld_dgcAPFeePaymentFeeConfigs.Size = new System.Drawing.Size(952, 328);
            this.fld_dgcAPFeePaymentFeeConfigs.TabIndex = 0;
            this.fld_dgcAPFeePaymentFeeConfigs.Tag = "DC";
            // 
            // fld_tpDocumentEntry
            // 
            this.fld_tpDocumentEntry.Controls.Add(this.fld_dgcDocumentEntry1s);
            this.fld_tpDocumentEntry.Name = "fld_tpDocumentEntry";
            this.fld_tpDocumentEntry.Size = new System.Drawing.Size(944, 327);
            this.fld_tpDocumentEntry.Text = "Hạch toán";
            // 
            // fld_dgcDocumentEntry1s
            // 
            this.fld_dgcDocumentEntry1s.BOSComment = null;
            this.fld_dgcDocumentEntry1s.BOSDataMember = null;
            this.fld_dgcDocumentEntry1s.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcDocumentEntry1s.BOSDescription = null;
            this.fld_dgcDocumentEntry1s.BOSError = null;
            this.fld_dgcDocumentEntry1s.BOSFieldGroup = null;
            this.fld_dgcDocumentEntry1s.BOSFieldRelation = null;
            this.fld_dgcDocumentEntry1s.BOSGridType = null;
            this.fld_dgcDocumentEntry1s.BOSPrivilege = null;
            this.fld_dgcDocumentEntry1s.BOSPropertyName = null;
            this.fld_dgcDocumentEntry1s.CommodityType = "";
            this.fld_dgcDocumentEntry1s.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcDocumentEntry1s.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcDocumentEntry1s.MenuManager = this.screenToolbar;
            this.fld_dgcDocumentEntry1s.Name = "fld_dgcDocumentEntry1s";
            this.fld_dgcDocumentEntry1s.PrintReport = false;
            this.fld_dgcDocumentEntry1s.Screen = null;
            this.fld_dgcDocumentEntry1s.Size = new System.Drawing.Size(944, 327);
            this.fld_dgcDocumentEntry1s.TabIndex = 0;
            // 
            // bosPictureEdit2
            // 
            this.bosPictureEdit2.BOSComment = null;
            this.bosPictureEdit2.BOSDataMember = "ACDocumentEmployeePicture";
            this.bosPictureEdit2.BOSDataSource = "ACDocuments";
            this.bosPictureEdit2.BOSDescription = null;
            this.bosPictureEdit2.BOSError = null;
            this.bosPictureEdit2.BOSFieldGroup = null;
            this.bosPictureEdit2.BOSFieldRelation = null;
            this.bosPictureEdit2.BOSPrivilege = null;
            this.bosPictureEdit2.BOSPropertyName = "EditValue";
            this.bosPictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bosPictureEdit2.FileName = null;
            this.bosPictureEdit2.FilePath = null;
            this.bosPictureEdit2.Location = new System.Drawing.Point(3, 4);
            this.bosPictureEdit2.MenuManager = this.screenToolbar;
            this.bosPictureEdit2.Name = "bosPictureEdit2";
            this.bosPictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.bosPictureEdit2.Screen = null;
            this.bosPictureEdit2.Size = new System.Drawing.Size(100, 96);
            this.bosPictureEdit2.TabIndex = 0;
            this.bosPictureEdit2.Tag = "DC";
            // 
            // bosTextBox11
            // 
            this.bosTextBox11.BOSComment = "";
            this.bosTextBox11.BOSDataMember = "ACDocumentTotalAmount";
            this.bosTextBox11.BOSDataSource = "ACDocuments";
            this.bosTextBox11.BOSDescription = null;
            this.bosTextBox11.BOSError = null;
            this.bosTextBox11.BOSFieldGroup = "";
            this.bosTextBox11.BOSFieldRelation = "";
            this.bosTextBox11.BOSPrivilege = "";
            this.bosTextBox11.BOSPropertyName = "Text";
            this.bosTextBox11.EditValue = "";
            this.bosTextBox11.Location = new System.Drawing.Point(222, 35);
            this.bosTextBox11.Name = "bosTextBox11";
            this.bosTextBox11.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox11.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox11.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox11.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox11.Properties.Mask.EditMask = "n";
            this.bosTextBox11.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.bosTextBox11.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox11.Screen = null;
            this.bosTextBox11.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox11.TabIndex = 3;
            this.bosTextBox11.Tag = "DC";
            // 
            // bosTextBox12
            // 
            this.bosTextBox12.BOSComment = "";
            this.bosTextBox12.BOSDataMember = "ACDocumentExchangeRate";
            this.bosTextBox12.BOSDataSource = "ACDocuments";
            this.bosTextBox12.BOSDescription = null;
            this.bosTextBox12.BOSError = null;
            this.bosTextBox12.BOSFieldGroup = "";
            this.bosTextBox12.BOSFieldRelation = "";
            this.bosTextBox12.BOSPrivilege = "";
            this.bosTextBox12.BOSPropertyName = "Text";
            this.bosTextBox12.EditValue = "";
            this.bosTextBox12.Location = new System.Drawing.Point(222, 87);
            this.bosTextBox12.Name = "bosTextBox12";
            this.bosTextBox12.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox12.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox12.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox12.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox12.Properties.Mask.EditMask = "n";
            this.bosTextBox12.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.bosTextBox12.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox12.Screen = null;
            this.bosTextBox12.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox12.TabIndex = 9;
            this.bosTextBox12.Tag = "DC";
            this.bosTextBox12.EditValueChanged += new System.EventHandler(this.bosTextBox12_EditValueChanged);
            // 
            // bosMemoEdit2
            // 
            this.bosMemoEdit2.BOSComment = null;
            this.bosMemoEdit2.BOSDataMember = "ACDocumentDesc";
            this.bosMemoEdit2.BOSDataSource = "ACDocuments";
            this.bosMemoEdit2.BOSDescription = null;
            this.bosMemoEdit2.BOSError = null;
            this.bosMemoEdit2.BOSFieldGroup = null;
            this.bosMemoEdit2.BOSFieldRelation = null;
            this.bosMemoEdit2.BOSPrivilege = null;
            this.bosMemoEdit2.BOSPropertyName = "EditValue";
            this.bosMemoEdit2.Location = new System.Drawing.Point(222, 113);
            this.bosMemoEdit2.MenuManager = this.screenToolbar;
            this.bosMemoEdit2.Name = "bosMemoEdit2";
            this.bosMemoEdit2.Screen = null;
            this.bosMemoEdit2.Size = new System.Drawing.Size(419, 48);
            this.bosMemoEdit2.TabIndex = 12;
            this.bosMemoEdit2.Tag = "DC";
            // 
            // bosLookupEdit7
            // 
            this.bosLookupEdit7.BOSAllowAddNew = false;
            this.bosLookupEdit7.BOSAllowDummy = false;
            this.bosLookupEdit7.BOSComment = "";
            this.bosLookupEdit7.BOSDataMember = "FK_HREmployeeID";
            this.bosLookupEdit7.BOSDataSource = "ACDocuments";
            this.bosLookupEdit7.BOSDescription = null;
            this.bosLookupEdit7.BOSError = null;
            this.bosLookupEdit7.BOSFieldGroup = "";
            this.bosLookupEdit7.BOSFieldParent = "";
            this.bosLookupEdit7.BOSFieldRelation = "";
            this.bosLookupEdit7.BOSPrivilege = "";
            this.bosLookupEdit7.BOSPropertyName = "EditValue";
            this.bosLookupEdit7.BOSSelectType = "";
            this.bosLookupEdit7.BOSSelectTypeValue = "";
            this.bosLookupEdit7.CurrentDisplayText = null;
            this.bosLookupEdit7.Location = new System.Drawing.Point(3, 102);
            this.bosLookupEdit7.Name = "bosLookupEdit7";
            this.bosLookupEdit7.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit7.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit7.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit7.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit7.Properties.ColumnName = null;
            this.bosLookupEdit7.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.bosLookupEdit7.Properties.DisplayMember = "HREmployeeNo";
            this.bosLookupEdit7.Properties.NullText = "";
            this.bosLookupEdit7.Properties.PopupWidth = 40;
            this.bosLookupEdit7.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit7.Properties.ValueMember = "HREmployeeID";
            this.bosLookupEdit7.Screen = null;
            this.bosLookupEdit7.Size = new System.Drawing.Size(100, 20);
            this.bosLookupEdit7.TabIndex = 1;
            this.bosLookupEdit7.Tag = "DC";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = false;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ACDocuments";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(491, 35);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = "";
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 4;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.fld_lkeFK_ACObjectID_Closed);
            // 
            // bosTextBox13
            // 
            this.bosTextBox13.BOSComment = "";
            this.bosTextBox13.BOSDataMember = "ACDocumentNo";
            this.bosTextBox13.BOSDataSource = "ACDocuments";
            this.bosTextBox13.BOSDescription = null;
            this.bosTextBox13.BOSError = null;
            this.bosTextBox13.BOSFieldGroup = "";
            this.bosTextBox13.BOSFieldRelation = "";
            this.bosTextBox13.BOSPrivilege = "";
            this.bosTextBox13.BOSPropertyName = "Text";
            this.bosTextBox13.EditValue = "";
            this.bosTextBox13.Location = new System.Drawing.Point(222, 9);
            this.bosTextBox13.Name = "bosTextBox13";
            this.bosTextBox13.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox13.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox13.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox13.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox13.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox13.Screen = null;
            this.bosTextBox13.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox13.TabIndex = 0;
            this.bosTextBox13.Tag = "DC";
            // 
            // bosLookupEdit8
            // 
            this.bosLookupEdit8.BOSAllowAddNew = false;
            this.bosLookupEdit8.BOSAllowDummy = true;
            this.bosLookupEdit8.BOSComment = "";
            this.bosLookupEdit8.BOSDataMember = "FK_GECurrencyID";
            this.bosLookupEdit8.BOSDataSource = "ACDocuments";
            this.bosLookupEdit8.BOSDescription = null;
            this.bosLookupEdit8.BOSError = null;
            this.bosLookupEdit8.BOSFieldGroup = "";
            this.bosLookupEdit8.BOSFieldParent = "";
            this.bosLookupEdit8.BOSFieldRelation = "";
            this.bosLookupEdit8.BOSPrivilege = "";
            this.bosLookupEdit8.BOSPropertyName = "EditValue";
            this.bosLookupEdit8.BOSSelectType = "";
            this.bosLookupEdit8.BOSSelectTypeValue = "";
            this.bosLookupEdit8.CurrentDisplayText = null;
            this.bosLookupEdit8.Location = new System.Drawing.Point(222, 61);
            this.bosLookupEdit8.Name = "bosLookupEdit8";
            this.bosLookupEdit8.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit8.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit8.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit8.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit8.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit8.Properties.ColumnName = null;
            this.bosLookupEdit8.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.bosLookupEdit8.Properties.DisplayMember = "GECurrencyNo";
            this.bosLookupEdit8.Properties.NullText = "";
            this.bosLookupEdit8.Properties.PopupWidth = 40;
            this.bosLookupEdit8.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit8.Properties.ValueMember = "GECurrencyID";
            this.bosLookupEdit8.Screen = null;
            this.bosLookupEdit8.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit8.TabIndex = 6;
            this.bosLookupEdit8.Tag = "DC";
            this.bosLookupEdit8.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.bosLookupEdit8_Closed);
            // 
            // bosLabel25
            // 
            this.bosLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel25.Location = new System.Drawing.Point(125, 12);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(61, 13);
            this.bosLabel25.TabIndex = 4;
            this.bosLabel25.Tag = "";
            this.bosLabel25.Text = "Mã chứng từ";
            // 
            // bosDateEdit2
            // 
            this.bosDateEdit2.BOSComment = "";
            this.bosDateEdit2.BOSDataMember = "ACDocumentDate";
            this.bosDateEdit2.BOSDataSource = "ACDocuments";
            this.bosDateEdit2.BOSDescription = null;
            this.bosDateEdit2.BOSError = null;
            this.bosDateEdit2.BOSFieldGroup = "";
            this.bosDateEdit2.BOSFieldRelation = "";
            this.bosDateEdit2.BOSPrivilege = "";
            this.bosDateEdit2.BOSPropertyName = "EditValue";
            this.bosDateEdit2.EditValue = null;
            this.bosDateEdit2.Location = new System.Drawing.Point(491, 9);
            this.bosDateEdit2.Name = "bosDateEdit2";
            this.bosDateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit2.Screen = null;
            this.bosDateEdit2.Size = new System.Drawing.Size(150, 20);
            this.bosDateEdit2.TabIndex = 1;
            this.bosDateEdit2.Tag = "DC";
            // 
            // bosLabel26
            // 
            this.bosLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel26.Location = new System.Drawing.Point(125, 38);
            this.bosLabel26.Name = "bosLabel26";
            this.bosLabel26.Screen = null;
            this.bosLabel26.Size = new System.Drawing.Size(59, 13);
            this.bosLabel26.TabIndex = 8;
            this.bosLabel26.Tag = "";
            this.bosLabel26.Text = "Tổng số tiền";
            // 
            // bosLabel27
            // 
            this.bosLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel27.Location = new System.Drawing.Point(390, 12);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.bosLabel27.Size = new System.Drawing.Size(72, 13);
            this.bosLabel27.TabIndex = 5;
            this.bosLabel27.Tag = "";
            this.bosLabel27.Text = "Ngày chứng từ";
            // 
            // bosLabel28
            // 
            this.bosLabel28.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel28.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel28.Appearance.Options.UseBackColor = true;
            this.bosLabel28.Appearance.Options.UseForeColor = true;
            this.bosLabel28.BOSComment = "";
            this.bosLabel28.BOSDataMember = "";
            this.bosLabel28.BOSDataSource = "";
            this.bosLabel28.BOSDescription = null;
            this.bosLabel28.BOSError = null;
            this.bosLabel28.BOSFieldGroup = "";
            this.bosLabel28.BOSFieldRelation = "";
            this.bosLabel28.BOSPrivilege = "";
            this.bosLabel28.BOSPropertyName = "";
            this.bosLabel28.Location = new System.Drawing.Point(125, 90);
            this.bosLabel28.Name = "bosLabel28";
            this.bosLabel28.Screen = null;
            this.bosLabel28.Size = new System.Drawing.Size(29, 13);
            this.bosLabel28.TabIndex = 8;
            this.bosLabel28.Tag = "";
            this.bosLabel28.Text = "Tỷ giá";
            // 
            // bosLabel29
            // 
            this.bosLabel29.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel29.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel29.Appearance.Options.UseBackColor = true;
            this.bosLabel29.Appearance.Options.UseForeColor = true;
            this.bosLabel29.BOSComment = "";
            this.bosLabel29.BOSDataMember = "";
            this.bosLabel29.BOSDataSource = "";
            this.bosLabel29.BOSDescription = null;
            this.bosLabel29.BOSError = null;
            this.bosLabel29.BOSFieldGroup = "";
            this.bosLabel29.BOSFieldRelation = "";
            this.bosLabel29.BOSPrivilege = "";
            this.bosLabel29.BOSPropertyName = "";
            this.bosLabel29.Location = new System.Drawing.Point(125, 116);
            this.bosLabel29.Name = "bosLabel29";
            this.bosLabel29.Screen = null;
            this.bosLabel29.Size = new System.Drawing.Size(40, 13);
            this.bosLabel29.TabIndex = 6;
            this.bosLabel29.Tag = "";
            this.bosLabel29.Text = "Diễn giải";
            // 
            // bosLabel30
            // 
            this.bosLabel30.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel30.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel30.Appearance.Options.UseBackColor = true;
            this.bosLabel30.Appearance.Options.UseForeColor = true;
            this.bosLabel30.BOSComment = "";
            this.bosLabel30.BOSDataMember = "";
            this.bosLabel30.BOSDataSource = "";
            this.bosLabel30.BOSDescription = null;
            this.bosLabel30.BOSError = null;
            this.bosLabel30.BOSFieldGroup = "";
            this.bosLabel30.BOSFieldRelation = "";
            this.bosLabel30.BOSPrivilege = "";
            this.bosLabel30.BOSPropertyName = "";
            this.bosLabel30.Location = new System.Drawing.Point(125, 64);
            this.bosLabel30.Name = "bosLabel30";
            this.bosLabel30.Screen = null;
            this.bosLabel30.Size = new System.Drawing.Size(53, 13);
            this.bosLabel30.TabIndex = 7;
            this.bosLabel30.Tag = "";
            this.bosLabel30.Text = "Loại tiền tệ";
            // 
            // bosLabel31
            // 
            this.bosLabel31.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel31.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel31.Appearance.Options.UseBackColor = true;
            this.bosLabel31.Appearance.Options.UseForeColor = true;
            this.bosLabel31.BOSComment = "";
            this.bosLabel31.BOSDataMember = "";
            this.bosLabel31.BOSDataSource = "";
            this.bosLabel31.BOSDescription = null;
            this.bosLabel31.BOSError = null;
            this.bosLabel31.BOSFieldGroup = "";
            this.bosLabel31.BOSFieldRelation = "";
            this.bosLabel31.BOSPrivilege = "";
            this.bosLabel31.BOSPropertyName = "";
            this.bosLabel31.Location = new System.Drawing.Point(390, 38);
            this.bosLabel31.Name = "bosLabel31";
            this.bosLabel31.Screen = null;
            this.bosLabel31.Size = new System.Drawing.Size(48, 13);
            this.bosLabel31.TabIndex = 6;
            this.bosLabel31.Tag = "";
            this.bosLabel31.Text = "Đối tượng";
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
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(652, 90);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(35, 13);
            this.bosLabel3.TabIndex = 120;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Ký hiệu";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = "";
            this.bosTextBox2.BOSDataMember = "ACDocumentVATSymbol";
            this.bosTextBox2.BOSDataSource = "ACDocuments";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = "";
            this.bosTextBox2.BOSFieldRelation = "";
            this.bosTextBox2.BOSPrivilege = "";
            this.bosTextBox2.BOSPropertyName = "EditValue";
            this.bosTextBox2.EditValue = "";
            this.bosTextBox2.Location = new System.Drawing.Point(751, 88);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.EditMask = "n";
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(159, 20);
            this.bosTextBox2.TabIndex = 115;
            this.bosTextBox2.Tag = "DC";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = true;
            this.bosLookupEdit1.BOSComment = "";
            this.bosLookupEdit1.BOSDataMember = "ACVATInvoiceNoCombo";
            this.bosLookupEdit1.BOSDataSource = "ACDocuments";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = "";
            this.bosLookupEdit1.BOSFieldParent = "";
            this.bosLookupEdit1.BOSFieldRelation = "";
            this.bosLookupEdit1.BOSPrivilege = "";
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = "";
            this.bosLookupEdit1.BOSSelectTypeValue = "";
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(491, 61);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.NullText = "";
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit1.TabIndex = 114;
            this.bosLookupEdit1.Tag = "DC";
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
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(390, 64);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(85, 13);
            this.bosLabel4.TabIndex = 119;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Mã hóa đơn GTGT";
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
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(651, 65);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(54, 13);
            this.bosLabel5.TabIndex = 118;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Số hóa đơn";
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = "";
            this.bosTextBox3.BOSDataMember = "ACDocumentVoucherNo";
            this.bosTextBox3.BOSDataSource = "ACDocuments";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = null;
            this.bosTextBox3.BOSFieldGroup = "";
            this.bosTextBox3.BOSFieldRelation = "";
            this.bosTextBox3.BOSPrivilege = "";
            this.bosTextBox3.BOSPropertyName = "EditValue";
            this.bosTextBox3.EditValue = "";
            this.bosTextBox3.Location = new System.Drawing.Point(751, 62);
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox3.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox3.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox3.Properties.Mask.EditMask = "n";
            this.bosTextBox3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox3.Screen = null;
            this.bosTextBox3.Size = new System.Drawing.Size(159, 20);
            this.bosTextBox3.TabIndex = 113;
            this.bosTextBox3.Tag = "DC";
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
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(652, 39);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(34, 13);
            this.bosLabel6.TabIndex = 117;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Mẫu số";
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = "";
            this.bosTextBox4.BOSDataMember = "ACDocumentVATFormNo";
            this.bosTextBox4.BOSDataSource = "ACDocuments";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = null;
            this.bosTextBox4.BOSFieldGroup = "";
            this.bosTextBox4.BOSFieldRelation = "";
            this.bosTextBox4.BOSPrivilege = "";
            this.bosTextBox4.BOSPropertyName = "EditValue";
            this.bosTextBox4.EditValue = "";
            this.bosTextBox4.Location = new System.Drawing.Point(751, 36);
            this.bosTextBox4.Name = "bosTextBox4";
            this.bosTextBox4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox4.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox4.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox4.Properties.Mask.EditMask = "n";
            this.bosTextBox4.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox4.Screen = null;
            this.bosTextBox4.Size = new System.Drawing.Size(159, 20);
            this.bosTextBox4.TabIndex = 112;
            this.bosTextBox4.Tag = "DC";
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
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(651, 12);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(61, 13);
            this.bosLabel7.TabIndex = 116;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Loại hóa đơn";
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = false;
            this.bosLookupEdit2.BOSComment = "";
            this.bosLookupEdit2.BOSDataMember = "ACVATDocumentType";
            this.bosLookupEdit2.BOSDataSource = "ACDocuments";
            this.bosLookupEdit2.BOSDescription = null;
            this.bosLookupEdit2.BOSError = null;
            this.bosLookupEdit2.BOSFieldGroup = "";
            this.bosLookupEdit2.BOSFieldParent = "";
            this.bosLookupEdit2.BOSFieldRelation = "";
            this.bosLookupEdit2.BOSPrivilege = "";
            this.bosLookupEdit2.BOSPropertyName = "EditValue";
            this.bosLookupEdit2.BOSSelectType = "";
            this.bosLookupEdit2.BOSSelectTypeValue = "";
            this.bosLookupEdit2.CurrentDisplayText = null;
            this.bosLookupEdit2.Location = new System.Drawing.Point(751, 9);
            this.bosLookupEdit2.Name = "bosLookupEdit2";
            this.bosLookupEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit2.Properties.ColumnName = null;
            this.bosLookupEdit2.Properties.NullText = "";
            this.bosLookupEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit2.Screen = null;
            this.bosLookupEdit2.Size = new System.Drawing.Size(159, 20);
            this.bosLookupEdit2.TabIndex = 111;
            this.bosLookupEdit2.Tag = "DC";
            // 
            // bosTabControl2
            // 
            this.bosTabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosTabControl2.BOSComment = null;
            this.bosTabControl2.BOSDataMember = null;
            this.bosTabControl2.BOSDataSource = null;
            this.bosTabControl2.BOSDescription = null;
            this.bosTabControl2.BOSError = null;
            this.bosTabControl2.BOSFieldGroup = null;
            this.bosTabControl2.BOSFieldRelation = null;
            this.bosTabControl2.BOSPrivilege = null;
            this.bosTabControl2.BOSPropertyName = null;
            this.bosTabControl2.Location = new System.Drawing.Point(3, 143);
            this.bosTabControl2.Name = "bosTabControl2";
            this.bosTabControl2.Screen = null;
            this.bosTabControl2.SelectedTabPage = this.xtraTabPage3;
            this.bosTabControl2.Size = new System.Drawing.Size(960, 383);
            this.bosTabControl2.TabIndex = 18;
            this.bosTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.ACDocumentEntryGridControl1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(958, 358);
            this.xtraTabPage3.Text = "Hạch toán";
            // 
            // ACDocumentEntryGridControl1
            // 
            this.ACDocumentEntryGridControl1.BOSComment = null;
            this.ACDocumentEntryGridControl1.BOSDataMember = null;
            this.ACDocumentEntryGridControl1.BOSDataSource = "ACDocumentEntrys";
            this.ACDocumentEntryGridControl1.BOSDescription = null;
            this.ACDocumentEntryGridControl1.BOSError = null;
            this.ACDocumentEntryGridControl1.BOSFieldGroup = null;
            this.ACDocumentEntryGridControl1.BOSFieldRelation = null;
            this.ACDocumentEntryGridControl1.BOSGridType = null;
            this.ACDocumentEntryGridControl1.BOSPrivilege = null;
            this.ACDocumentEntryGridControl1.BOSPropertyName = null;
            this.ACDocumentEntryGridControl1.CommodityType = "";
            this.ACDocumentEntryGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ACDocumentEntryGridControl1.Location = new System.Drawing.Point(0, 0);
            this.ACDocumentEntryGridControl1.MenuManager = this.screenToolbar;
            this.ACDocumentEntryGridControl1.Name = "ACDocumentEntryGridControl1";
            this.ACDocumentEntryGridControl1.PrintReport = false;
            this.ACDocumentEntryGridControl1.Screen = null;
            this.ACDocumentEntryGridControl1.Size = new System.Drawing.Size(958, 358);
            this.ACDocumentEntryGridControl1.TabIndex = 0;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.bosButton1);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(944, 351);
            this.xtraTabPage4.Text = "Danh sách phiếu nhập";
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
            this.bosButton1.Location = new System.Drawing.Point(7, 6);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(125, 27);
            this.bosButton1.TabIndex = 1;
            this.bosButton1.Text = "Chọn phiếu nhập";
            // 
            // bosPictureEdit1
            // 
            this.bosPictureEdit1.BOSComment = null;
            this.bosPictureEdit1.BOSDataMember = "ACDocumentEmployeePicture";
            this.bosPictureEdit1.BOSDataSource = "ACDocuments";
            this.bosPictureEdit1.BOSDescription = null;
            this.bosPictureEdit1.BOSError = null;
            this.bosPictureEdit1.BOSFieldGroup = null;
            this.bosPictureEdit1.BOSFieldRelation = null;
            this.bosPictureEdit1.BOSPrivilege = null;
            this.bosPictureEdit1.BOSPropertyName = "EditValue";
            this.bosPictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bosPictureEdit1.FileName = null;
            this.bosPictureEdit1.FilePath = null;
            this.bosPictureEdit1.Location = new System.Drawing.Point(3, 4);
            this.bosPictureEdit1.MenuManager = this.screenToolbar;
            this.bosPictureEdit1.Name = "bosPictureEdit1";
            this.bosPictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.bosPictureEdit1.Screen = null;
            this.bosPictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.bosPictureEdit1.TabIndex = 15;
            this.bosPictureEdit1.Tag = "DC";
            // 
            // bosTextBox5
            // 
            this.bosTextBox5.BOSComment = "";
            this.bosTextBox5.BOSDataMember = "ACDocumentTotalAmount";
            this.bosTextBox5.BOSDataSource = "ACDocuments";
            this.bosTextBox5.BOSDescription = null;
            this.bosTextBox5.BOSError = null;
            this.bosTextBox5.BOSFieldGroup = "";
            this.bosTextBox5.BOSFieldRelation = "";
            this.bosTextBox5.BOSPrivilege = "";
            this.bosTextBox5.BOSPropertyName = "Text";
            this.bosTextBox5.EditValue = "";
            this.bosTextBox5.Location = new System.Drawing.Point(222, 35);
            this.bosTextBox5.Name = "bosTextBox5";
            this.bosTextBox5.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox5.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox5.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox5.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox5.Properties.Mask.EditMask = "n";
            this.bosTextBox5.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.bosTextBox5.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox5.Screen = null;
            this.bosTextBox5.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox5.TabIndex = 3;
            this.bosTextBox5.Tag = "DC";
            // 
            // bosTextBox6
            // 
            this.bosTextBox6.BOSComment = "";
            this.bosTextBox6.BOSDataMember = "ACDocumentExchangeRate";
            this.bosTextBox6.BOSDataSource = "ACDocuments";
            this.bosTextBox6.BOSDescription = null;
            this.bosTextBox6.BOSError = null;
            this.bosTextBox6.BOSFieldGroup = "";
            this.bosTextBox6.BOSFieldRelation = "";
            this.bosTextBox6.BOSPrivilege = "";
            this.bosTextBox6.BOSPropertyName = "Text";
            this.bosTextBox6.EditValue = "";
            this.bosTextBox6.Location = new System.Drawing.Point(222, 87);
            this.bosTextBox6.Name = "bosTextBox6";
            this.bosTextBox6.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox6.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox6.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox6.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox6.Properties.Mask.EditMask = "n";
            this.bosTextBox6.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.bosTextBox6.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox6.Screen = null;
            this.bosTextBox6.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox6.TabIndex = 5;
            this.bosTextBox6.Tag = "DC";
            // 
            // bosMemoEdit1
            // 
            this.bosMemoEdit1.BOSComment = null;
            this.bosMemoEdit1.BOSDataMember = "ACDocumentDesc";
            this.bosMemoEdit1.BOSDataSource = "ACDocuments";
            this.bosMemoEdit1.BOSDescription = null;
            this.bosMemoEdit1.BOSError = null;
            this.bosMemoEdit1.BOSFieldGroup = null;
            this.bosMemoEdit1.BOSFieldRelation = null;
            this.bosMemoEdit1.BOSPrivilege = null;
            this.bosMemoEdit1.BOSPropertyName = "EditValue";
            this.bosMemoEdit1.Location = new System.Drawing.Point(222, 113);
            this.bosMemoEdit1.MenuManager = this.screenToolbar;
            this.bosMemoEdit1.Name = "bosMemoEdit1";
            this.bosMemoEdit1.Screen = null;
            this.bosMemoEdit1.Size = new System.Drawing.Size(424, 24);
            this.bosMemoEdit1.TabIndex = 6;
            this.bosMemoEdit1.Tag = "DC";
            // 
            // bosLookupEdit3
            // 
            this.bosLookupEdit3.BOSAllowAddNew = false;
            this.bosLookupEdit3.BOSAllowDummy = false;
            this.bosLookupEdit3.BOSComment = "";
            this.bosLookupEdit3.BOSDataMember = "FK_HREmployeeID";
            this.bosLookupEdit3.BOSDataSource = "ACDocuments";
            this.bosLookupEdit3.BOSDescription = null;
            this.bosLookupEdit3.BOSError = null;
            this.bosLookupEdit3.BOSFieldGroup = "";
            this.bosLookupEdit3.BOSFieldParent = "";
            this.bosLookupEdit3.BOSFieldRelation = "";
            this.bosLookupEdit3.BOSPrivilege = "";
            this.bosLookupEdit3.BOSPropertyName = "EditValue";
            this.bosLookupEdit3.BOSSelectType = "";
            this.bosLookupEdit3.BOSSelectTypeValue = "";
            this.bosLookupEdit3.CurrentDisplayText = null;
            this.bosLookupEdit3.Location = new System.Drawing.Point(3, 102);
            this.bosLookupEdit3.Name = "bosLookupEdit3";
            this.bosLookupEdit3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit3.Properties.ColumnName = null;
            this.bosLookupEdit3.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.bosLookupEdit3.Properties.DisplayMember = "HREmployeeNo";
            this.bosLookupEdit3.Properties.NullText = "";
            this.bosLookupEdit3.Properties.PopupWidth = 40;
            this.bosLookupEdit3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit3.Properties.ValueMember = "HREmployeeID";
            this.bosLookupEdit3.Screen = null;
            this.bosLookupEdit3.Size = new System.Drawing.Size(100, 20);
            this.bosLookupEdit3.TabIndex = 7;
            this.bosLookupEdit3.Tag = "DC";
            // 
            // accObjectLookupEdit1
            // 
            this.accObjectLookupEdit1.BOSAllowAddNew = false;
            this.accObjectLookupEdit1.BOSAllowDummy = false;
            this.accObjectLookupEdit1.BOSComment = "";
            this.accObjectLookupEdit1.BOSDataMember = "ACObjectAccessKey";
            this.accObjectLookupEdit1.BOSDataSource = "ACDocuments";
            this.accObjectLookupEdit1.BOSDescription = null;
            this.accObjectLookupEdit1.BOSError = null;
            this.accObjectLookupEdit1.BOSFieldGroup = "";
            this.accObjectLookupEdit1.BOSFieldParent = "";
            this.accObjectLookupEdit1.BOSFieldRelation = "";
            this.accObjectLookupEdit1.BOSModuleType = null;
            this.accObjectLookupEdit1.BOSPrivilege = "";
            this.accObjectLookupEdit1.BOSPropertyName = "EditValue";
            this.accObjectLookupEdit1.BOSSelectType = "";
            this.accObjectLookupEdit1.BOSSelectTypeValue = "";
            this.accObjectLookupEdit1.CurrentDisplayText = null;
            this.accObjectLookupEdit1.LastedUpdate = new System.DateTime(((long)(0)));
            this.accObjectLookupEdit1.Location = new System.Drawing.Point(491, 35);
            this.accObjectLookupEdit1.Name = "accObjectLookupEdit1";
            this.accObjectLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.accObjectLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.accObjectLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.accObjectLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.accObjectLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.accObjectLookupEdit1.Properties.ColumnName = null;
            this.accObjectLookupEdit1.Properties.DisplayMember = "ACObjectName";
            this.accObjectLookupEdit1.Properties.NullText = "";
            this.accObjectLookupEdit1.Properties.PopupWidth = 40;
            this.accObjectLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.accObjectLookupEdit1.Properties.ValueMember = "ACObjectID";
            this.accObjectLookupEdit1.Screen = null;
            this.accObjectLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.accObjectLookupEdit1.TabIndex = 2;
            this.accObjectLookupEdit1.Tag = "DC";
            // 
            // bosTextBox7
            // 
            this.bosTextBox7.BOSComment = "";
            this.bosTextBox7.BOSDataMember = "ACDocumentNo";
            this.bosTextBox7.BOSDataSource = "ACDocuments";
            this.bosTextBox7.BOSDescription = null;
            this.bosTextBox7.BOSError = null;
            this.bosTextBox7.BOSFieldGroup = "";
            this.bosTextBox7.BOSFieldRelation = "";
            this.bosTextBox7.BOSPrivilege = "";
            this.bosTextBox7.BOSPropertyName = "Text";
            this.bosTextBox7.EditValue = "";
            this.bosTextBox7.Location = new System.Drawing.Point(222, 9);
            this.bosTextBox7.Name = "bosTextBox7";
            this.bosTextBox7.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox7.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox7.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox7.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox7.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox7.Screen = null;
            this.bosTextBox7.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox7.TabIndex = 0;
            this.bosTextBox7.Tag = "DC";
            // 
            // bosLookupEdit4
            // 
            this.bosLookupEdit4.BOSAllowAddNew = false;
            this.bosLookupEdit4.BOSAllowDummy = true;
            this.bosLookupEdit4.BOSComment = "";
            this.bosLookupEdit4.BOSDataMember = "FK_GECurrencyID";
            this.bosLookupEdit4.BOSDataSource = "ACDocuments";
            this.bosLookupEdit4.BOSDescription = null;
            this.bosLookupEdit4.BOSError = null;
            this.bosLookupEdit4.BOSFieldGroup = "";
            this.bosLookupEdit4.BOSFieldParent = "";
            this.bosLookupEdit4.BOSFieldRelation = "";
            this.bosLookupEdit4.BOSPrivilege = "";
            this.bosLookupEdit4.BOSPropertyName = "EditValue";
            this.bosLookupEdit4.BOSSelectType = "";
            this.bosLookupEdit4.BOSSelectTypeValue = "";
            this.bosLookupEdit4.CurrentDisplayText = null;
            this.bosLookupEdit4.Location = new System.Drawing.Point(222, 61);
            this.bosLookupEdit4.Name = "bosLookupEdit4";
            this.bosLookupEdit4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit4.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit4.Properties.ColumnName = null;
            this.bosLookupEdit4.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Name")});
            this.bosLookupEdit4.Properties.DisplayMember = "GECurrencyNo";
            this.bosLookupEdit4.Properties.NullText = "";
            this.bosLookupEdit4.Properties.PopupWidth = 40;
            this.bosLookupEdit4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit4.Properties.ValueMember = "GECurrencyID";
            this.bosLookupEdit4.Screen = null;
            this.bosLookupEdit4.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit4.TabIndex = 4;
            this.bosLookupEdit4.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(125, 12);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(61, 13);
            this.bosLabel9.TabIndex = 4;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Mã chứng từ";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = "";
            this.bosDateEdit1.BOSDataMember = "ACDocumentDate";
            this.bosDateEdit1.BOSDataSource = "ACDocuments";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = "";
            this.bosDateEdit1.BOSFieldRelation = "";
            this.bosDateEdit1.BOSPrivilege = "";
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(491, 9);
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosDateEdit1.TabIndex = 1;
            this.bosDateEdit1.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel12.Location = new System.Drawing.Point(125, 38);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(59, 13);
            this.bosLabel12.TabIndex = 8;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "Tổng số tiền";
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
            this.bosLabel13.BOSPropertyName = "";
            this.bosLabel13.Location = new System.Drawing.Point(390, 12);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(72, 13);
            this.bosLabel13.TabIndex = 5;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "Ngày chứng từ";
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
            this.bosLabel14.Location = new System.Drawing.Point(125, 90);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(29, 13);
            this.bosLabel14.TabIndex = 8;
            this.bosLabel14.Tag = "";
            this.bosLabel14.Text = "Tỷ giá";
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
            this.bosLabel15.Location = new System.Drawing.Point(125, 116);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(40, 13);
            this.bosLabel15.TabIndex = 6;
            this.bosLabel15.Tag = "";
            this.bosLabel15.Text = "Diễn giải";
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel16.Location = new System.Drawing.Point(125, 64);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(53, 13);
            this.bosLabel16.TabIndex = 7;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "Loại tiền tệ";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel17.Location = new System.Drawing.Point(390, 38);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(84, 13);
            this.bosLabel17.TabIndex = 6;
            this.bosLabel17.Tag = "";
            this.bosLabel17.Text = "Người thanh toán";
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
            this.bosLabel20.Location = new System.Drawing.Point(652, 90);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(35, 13);
            this.bosLabel20.TabIndex = 120;
            this.bosLabel20.Tag = "";
            this.bosLabel20.Text = "Ký hiệu";
            // 
            // fld_txtACDocumentVATSymbol
            // 
            this.fld_txtACDocumentVATSymbol.BOSComment = "";
            this.fld_txtACDocumentVATSymbol.BOSDataMember = "ACDocumentVATSymbol";
            this.fld_txtACDocumentVATSymbol.BOSDataSource = "ACDocuments";
            this.fld_txtACDocumentVATSymbol.BOSDescription = null;
            this.fld_txtACDocumentVATSymbol.BOSError = null;
            this.fld_txtACDocumentVATSymbol.BOSFieldGroup = "";
            this.fld_txtACDocumentVATSymbol.BOSFieldRelation = "";
            this.fld_txtACDocumentVATSymbol.BOSPrivilege = "";
            this.fld_txtACDocumentVATSymbol.BOSPropertyName = "EditValue";
            this.fld_txtACDocumentVATSymbol.EditValue = "";
            this.fld_txtACDocumentVATSymbol.Location = new System.Drawing.Point(751, 88);
            this.fld_txtACDocumentVATSymbol.Name = "fld_txtACDocumentVATSymbol";
            this.fld_txtACDocumentVATSymbol.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACDocumentVATSymbol.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACDocumentVATSymbol.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACDocumentVATSymbol.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACDocumentVATSymbol.Properties.Mask.EditMask = "n";
            this.fld_txtACDocumentVATSymbol.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACDocumentVATSymbol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACDocumentVATSymbol.Screen = null;
            this.fld_txtACDocumentVATSymbol.Size = new System.Drawing.Size(159, 20);
            this.fld_txtACDocumentVATSymbol.TabIndex = 115;
            this.fld_txtACDocumentVATSymbol.Tag = "DC";
            // 
            // fld_lkeACVATInvoiceNoCombo
            // 
            this.fld_lkeACVATInvoiceNoCombo.BOSAllowAddNew = false;
            this.fld_lkeACVATInvoiceNoCombo.BOSAllowDummy = true;
            this.fld_lkeACVATInvoiceNoCombo.BOSComment = "";
            this.fld_lkeACVATInvoiceNoCombo.BOSDataMember = "ACVATInvoiceNoCombo";
            this.fld_lkeACVATInvoiceNoCombo.BOSDataSource = "ACDocuments";
            this.fld_lkeACVATInvoiceNoCombo.BOSDescription = null;
            this.fld_lkeACVATInvoiceNoCombo.BOSError = null;
            this.fld_lkeACVATInvoiceNoCombo.BOSFieldGroup = "";
            this.fld_lkeACVATInvoiceNoCombo.BOSFieldParent = "";
            this.fld_lkeACVATInvoiceNoCombo.BOSFieldRelation = "";
            this.fld_lkeACVATInvoiceNoCombo.BOSPrivilege = "";
            this.fld_lkeACVATInvoiceNoCombo.BOSPropertyName = "EditValue";
            this.fld_lkeACVATInvoiceNoCombo.BOSSelectType = "";
            this.fld_lkeACVATInvoiceNoCombo.BOSSelectTypeValue = "";
            this.fld_lkeACVATInvoiceNoCombo.CurrentDisplayText = null;
            this.fld_lkeACVATInvoiceNoCombo.Location = new System.Drawing.Point(491, 61);
            this.fld_lkeACVATInvoiceNoCombo.Name = "fld_lkeACVATInvoiceNoCombo";
            this.fld_lkeACVATInvoiceNoCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACVATInvoiceNoCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACVATInvoiceNoCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACVATInvoiceNoCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACVATInvoiceNoCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACVATInvoiceNoCombo.Properties.ColumnName = null;
            this.fld_lkeACVATInvoiceNoCombo.Properties.NullText = "";
            this.fld_lkeACVATInvoiceNoCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACVATInvoiceNoCombo.Screen = null;
            this.fld_lkeACVATInvoiceNoCombo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACVATInvoiceNoCombo.TabIndex = 114;
            this.fld_lkeACVATInvoiceNoCombo.Tag = "DC";
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
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(390, 64);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(85, 13);
            this.bosLabel10.TabIndex = 119;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Mã hóa đơn GTGT";
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
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(651, 65);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(54, 13);
            this.bosLabel19.TabIndex = 118;
            this.bosLabel19.Tag = "";
            this.bosLabel19.Text = "Số hóa đơn";
            // 
            // fld_txtACDocumentVoucherNo
            // 
            this.fld_txtACDocumentVoucherNo.BOSComment = "";
            this.fld_txtACDocumentVoucherNo.BOSDataMember = "ACDocumentVoucherNo";
            this.fld_txtACDocumentVoucherNo.BOSDataSource = "ACDocuments";
            this.fld_txtACDocumentVoucherNo.BOSDescription = null;
            this.fld_txtACDocumentVoucherNo.BOSError = null;
            this.fld_txtACDocumentVoucherNo.BOSFieldGroup = "";
            this.fld_txtACDocumentVoucherNo.BOSFieldRelation = "";
            this.fld_txtACDocumentVoucherNo.BOSPrivilege = "";
            this.fld_txtACDocumentVoucherNo.BOSPropertyName = "EditValue";
            this.fld_txtACDocumentVoucherNo.EditValue = "";
            this.fld_txtACDocumentVoucherNo.Location = new System.Drawing.Point(751, 62);
            this.fld_txtACDocumentVoucherNo.Name = "fld_txtACDocumentVoucherNo";
            this.fld_txtACDocumentVoucherNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACDocumentVoucherNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACDocumentVoucherNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACDocumentVoucherNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACDocumentVoucherNo.Properties.Mask.EditMask = "n";
            this.fld_txtACDocumentVoucherNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACDocumentVoucherNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACDocumentVoucherNo.Screen = null;
            this.fld_txtACDocumentVoucherNo.Size = new System.Drawing.Size(159, 20);
            this.fld_txtACDocumentVoucherNo.TabIndex = 113;
            this.fld_txtACDocumentVoucherNo.Tag = "DC";
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
            this.bosLabel11.Location = new System.Drawing.Point(652, 39);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(34, 13);
            this.bosLabel11.TabIndex = 117;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Mẫu số";
            // 
            // fld_txtACDocumentVATFormNo
            // 
            this.fld_txtACDocumentVATFormNo.BOSComment = "";
            this.fld_txtACDocumentVATFormNo.BOSDataMember = "ACDocumentVATFormNo";
            this.fld_txtACDocumentVATFormNo.BOSDataSource = "ACDocuments";
            this.fld_txtACDocumentVATFormNo.BOSDescription = null;
            this.fld_txtACDocumentVATFormNo.BOSError = null;
            this.fld_txtACDocumentVATFormNo.BOSFieldGroup = "";
            this.fld_txtACDocumentVATFormNo.BOSFieldRelation = "";
            this.fld_txtACDocumentVATFormNo.BOSPrivilege = "";
            this.fld_txtACDocumentVATFormNo.BOSPropertyName = "EditValue";
            this.fld_txtACDocumentVATFormNo.EditValue = "";
            this.fld_txtACDocumentVATFormNo.Location = new System.Drawing.Point(751, 36);
            this.fld_txtACDocumentVATFormNo.Name = "fld_txtACDocumentVATFormNo";
            this.fld_txtACDocumentVATFormNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACDocumentVATFormNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACDocumentVATFormNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACDocumentVATFormNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACDocumentVATFormNo.Properties.Mask.EditMask = "n";
            this.fld_txtACDocumentVATFormNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACDocumentVATFormNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACDocumentVATFormNo.Screen = null;
            this.fld_txtACDocumentVATFormNo.Size = new System.Drawing.Size(159, 20);
            this.fld_txtACDocumentVATFormNo.TabIndex = 112;
            this.fld_txtACDocumentVATFormNo.Tag = "DC";
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
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(651, 12);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(61, 13);
            this.bosLabel8.TabIndex = 116;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Loại hóa đơn";
            // 
            // fld_lkeACVATDocumentType
            // 
            this.fld_lkeACVATDocumentType.BOSAllowAddNew = false;
            this.fld_lkeACVATDocumentType.BOSAllowDummy = false;
            this.fld_lkeACVATDocumentType.BOSComment = "";
            this.fld_lkeACVATDocumentType.BOSDataMember = "ACVATDocumentType";
            this.fld_lkeACVATDocumentType.BOSDataSource = "ACDocuments";
            this.fld_lkeACVATDocumentType.BOSDescription = null;
            this.fld_lkeACVATDocumentType.BOSError = null;
            this.fld_lkeACVATDocumentType.BOSFieldGroup = "";
            this.fld_lkeACVATDocumentType.BOSFieldParent = "";
            this.fld_lkeACVATDocumentType.BOSFieldRelation = "";
            this.fld_lkeACVATDocumentType.BOSPrivilege = "";
            this.fld_lkeACVATDocumentType.BOSPropertyName = "EditValue";
            this.fld_lkeACVATDocumentType.BOSSelectType = "";
            this.fld_lkeACVATDocumentType.BOSSelectTypeValue = "";
            this.fld_lkeACVATDocumentType.CurrentDisplayText = null;
            this.fld_lkeACVATDocumentType.Location = new System.Drawing.Point(751, 9);
            this.fld_lkeACVATDocumentType.Name = "fld_lkeACVATDocumentType";
            this.fld_lkeACVATDocumentType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACVATDocumentType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACVATDocumentType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACVATDocumentType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACVATDocumentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACVATDocumentType.Properties.ColumnName = null;
            this.fld_lkeACVATDocumentType.Properties.NullText = "";
            this.fld_lkeACVATDocumentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACVATDocumentType.Screen = null;
            this.fld_lkeACVATDocumentType.Size = new System.Drawing.Size(159, 20);
            this.fld_lkeACVATDocumentType.TabIndex = 111;
            this.fld_lkeACVATDocumentType.Tag = "DC";
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
            this.bosTabControl1.Size = new System.Drawing.Size(960, 383);
            this.bosTabControl1.TabIndex = 18;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcDocumentEntrys);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(958, 358);
            this.xtraTabPage1.Text = "Hạch toán";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(944, 351);
            this.xtraTabPage2.Text = "Danh sách phiếu nhập";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "ACDocumentTotalAmount";
            this.bosTextBox1.BOSDataSource = "ACDocuments";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.EditValue = "";
            this.bosTextBox1.Location = new System.Drawing.Point(222, 35);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.EditMask = "n";
            this.bosTextBox1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox1.TabIndex = 3;
            this.bosTextBox1.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(125, 38);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(59, 13);
            this.bosLabel2.TabIndex = 8;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Tổng số tiền";
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
            this.fld_lblLabel6.Location = new System.Drawing.Point(390, 38);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(84, 13);
            this.fld_lblLabel6.TabIndex = 6;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Người thanh toán";
            // 
            // fld_btnChooseReceipts
            // 
            this.fld_btnChooseReceipts.BOSComment = null;
            this.fld_btnChooseReceipts.BOSDataMember = null;
            this.fld_btnChooseReceipts.BOSDataSource = null;
            this.fld_btnChooseReceipts.BOSDescription = null;
            this.fld_btnChooseReceipts.BOSError = null;
            this.fld_btnChooseReceipts.BOSFieldGroup = null;
            this.fld_btnChooseReceipts.BOSFieldRelation = null;
            this.fld_btnChooseReceipts.BOSPrivilege = null;
            this.fld_btnChooseReceipts.BOSPropertyName = null;
            this.fld_btnChooseReceipts.Location = new System.Drawing.Point(0, 0);
            this.fld_btnChooseReceipts.Name = "fld_btnChooseReceipts";
            this.fld_btnChooseReceipts.Screen = null;
            this.fld_btnChooseReceipts.Size = new System.Drawing.Size(75, 27);
            this.fld_btnChooseReceipts.TabIndex = 0;
            // 
            // DMSOC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(976, 538);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMSOC100.IconOptions.Icon")));
            this.Name = "DMSOC100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACDocumentEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACDocumentDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            this.bosPanel3.ResumeLayout(false);
            this.bosPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cbbDocumentCreateType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit3.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACVATDocumentTypeFeePayment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tcDetail)).EndInit();
            this.fld_tcDetail.ResumeLayout(false);
            this.fld_tpInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPFeePaymentInvoices)).EndInit();
            this.fld_tpPaymentCommissions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARFeePaymentCommissions)).EndInit();
            this.fld_tpFeeConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPFeePaymentFeeConfigs)).EndInit();
            this.fld_tpDocumentEntry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntry1s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox12.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox13.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl2)).EndInit();
            this.bosTabControl2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ACDocumentEntryGridControl1)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosPictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accObjectLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentVATSymbol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACVATInvoiceNoCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentVoucherNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentVATFormNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACVATDocumentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSPictureEdit fld_pteACDocumentEmployeePicture;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSMemoEdit fld_medACDocumentDesc;
        private BOSComponent.BOSPanel bosPanel1;
        //private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSButton fld_btnChooseReceipts;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSTextBox fld_txtACDocumentVATSymbol;
        private BOSComponent.BOSLookupEdit fld_lkeACVATInvoiceNoCombo;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSTextBox fld_txtACDocumentVoucherNo;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox fld_txtACDocumentVATFormNo;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeACVATDocumentType;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSPanel bosPanel3;
        private BOSComponent.BOSDateEdit bosDateEdit3;
        private BOSComponent.BOSLabel bosLabel32;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSTextBox bosTextBox8;
        private BOSComponent.BOSLookupEdit bosLookupEdit5;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSTextBox bosTextBox9;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSTextBox bosTextBox10;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSLookupEdit fld_lkeACVATDocumentTypeFeePayment;
        private BOSComponent.BOSTabControl fld_tcDetail;
        private DevExpress.XtraTab.XtraTabPage fld_tpDocumentEntry;
        //private BaseDocumentEntryGridControl fld_dgcDocumentEntry1s;
        private ACDocumentEntryGridControl fld_dgcDocumentEntry1s;
        private BOSComponent.BOSPictureEdit bosPictureEdit2;
        private BOSComponent.BOSTextBox bosTextBox11;
        private BOSComponent.BOSTextBox bosTextBox12;
        private BOSComponent.BOSMemoEdit bosMemoEdit2;
        private BOSComponent.BOSLookupEdit bosLookupEdit7;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSTextBox bosTextBox13;
        private BOSComponent.BOSLookupEdit bosLookupEdit8;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSDateEdit bosDateEdit2;
        private BOSComponent.BOSLabel bosLabel26;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSLabel bosLabel28;
        private BOSComponent.BOSLabel bosLabel29;
        private BOSComponent.BOSLabel bosLabel30;
        private BOSComponent.BOSLabel bosLabel31;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTextBox bosTextBox4;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit bosLookupEdit2;
        private BOSComponent.BOSTabControl bosTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private BaseDocumentEntryGridControl ACDocumentEntryGridControl1;
        //private ACDocumentEntryGridControl ACDocumentEntryGridControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private BOSComponent.BOSButton bosButton1;
        private BOSComponent.BOSPictureEdit bosPictureEdit1;
        private BOSComponent.BOSTextBox bosTextBox5;
        private BOSComponent.BOSTextBox bosTextBox6;
        private BOSComponent.BOSMemoEdit bosMemoEdit1;
        private BOSComponent.BOSLookupEdit bosLookupEdit3;
        private AccObjectLookupEdit accObjectLookupEdit1;
        private BOSComponent.BOSTextBox bosTextBox7;
        private BOSComponent.BOSLookupEdit bosLookupEdit4;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLabel bosLabel17;
        private ACDocumentEntryGridControl fld_dgcDocumentEntrys;
        private BOSComponent.BOSLabel bosLabel33;
        private BOSComponent.BOSComboBox fld_cbbDocumentCreateType;
        private DevExpress.XtraTab.XtraTabPage fld_tpInvoice;
        private APFeePaymentInvoicesGridControl fld_dgcAPFeePaymentInvoices;
        private BOSComponent.BOSButton bosButton6;
        private DevExpress.XtraTab.XtraTabPage fld_tpFeeConfig;
        private APFeePaymentFeeConfigsGridControl fld_dgcAPFeePaymentFeeConfigs;
        private DevExpress.XtraTab.XtraTabPage fld_tpPaymentCommissions;
        private ARFeePaymentCommissionsGridControl fld_dgcARFeePaymentCommissions;
    }
}
