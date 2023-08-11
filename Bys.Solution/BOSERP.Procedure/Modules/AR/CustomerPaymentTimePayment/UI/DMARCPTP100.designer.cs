using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CustomerPaymentTimePayment.UI
{
    /// <summary>
    /// Summary description for DMARCP100
    /// </summary>f
    partial class DMARCPTP100
    {
        private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSDateEdit fld_dteARCustomerPaymentDate;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARCustomerPaymentTimePayments;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMARCPTP100));
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerPaymentExchangeRate21 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerPaymentNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARCustomerPaymentDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnInvoice = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARCustomerPaymentTimePayments = new BOSERP.Modules.CustomerPaymentTimePayment.CustomerPaymentTimePaymentsGridControl();
            this.fld_dgvARCustomerPaymentTimePayments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.bosTextBox6 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox5 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel85 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteAACreatedDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel41 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.pick = new BOSComponent.BOSLabel(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeFK_CSCashFundID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACSegmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_tabCustomerPayments = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageCustomerPayment = new DevExpress.XtraTab.XtraTabPage();
            this.fld_tabPagePosting = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcARCustomerPaymentDocuments = new BOSERP.Modules.CustomerPaymentTimePayment.ARCustomerPaymentDocumentsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgcDocumentEntrys = new BOSERP.Modules.CustomerPaymentTimePayment.DocumentEntryGridControl();
            this.fld_dgvACBankTransactionItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_medARCustomerPaymentDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_pteARCustomerPaymentEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARCustomerPaymentBankAccount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerPaymentTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCustomerPaymentSenderName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_CSCompanyBankID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentExchangeRate21.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCustomerPaymentDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCustomerPaymentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCustomerPaymentTimePayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCustomerPaymentTimePayments)).BeginInit();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAACreatedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAACreatedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCashFundID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCustomerPayments)).BeginInit();
            this.fld_tabCustomerPayments.SuspendLayout();
            this.fld_tabPageCustomerPayment.SuspendLayout();
            this.fld_tabPagePosting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCustomerPaymentDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACBankTransactionItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARCustomerPaymentDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARCustomerPaymentEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentBankAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentSenderName.Properties)).BeginInit();
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
            resources.ApplyResources(this.bosLabel1, "bosLabel1");
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, ((bool)(resources.GetObject("bosLabel1.ShowHelp"))));
            // 
            // fld_txtARCustomerPaymentExchangeRate21
            // 
            this.fld_txtARCustomerPaymentExchangeRate21.BOSComment = null;
            this.fld_txtARCustomerPaymentExchangeRate21.BOSDataMember = "ARCustomerPaymentExchangeRate";
            this.fld_txtARCustomerPaymentExchangeRate21.BOSDataSource = "ARCustomerPayments";
            this.fld_txtARCustomerPaymentExchangeRate21.BOSDescription = null;
            this.fld_txtARCustomerPaymentExchangeRate21.BOSError = null;
            this.fld_txtARCustomerPaymentExchangeRate21.BOSFieldGroup = null;
            this.fld_txtARCustomerPaymentExchangeRate21.BOSFieldRelation = null;
            this.fld_txtARCustomerPaymentExchangeRate21.BOSPrivilege = null;
            this.fld_txtARCustomerPaymentExchangeRate21.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtARCustomerPaymentExchangeRate21, "fld_txtARCustomerPaymentExchangeRate21");
            this.fld_txtARCustomerPaymentExchangeRate21.Name = "fld_txtARCustomerPaymentExchangeRate21";
            this.fld_txtARCustomerPaymentExchangeRate21.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerPaymentExchangeRate21, ((bool)(resources.GetObject("fld_txtARCustomerPaymentExchangeRate21.ShowHelp"))));
            this.fld_txtARCustomerPaymentExchangeRate21.Tag = "DC";
            this.fld_txtARCustomerPaymentExchangeRate21.EditValueChanged += new System.EventHandler(this.fld_txtARCustomerPaymentExchangeRate_EditValueChanged);
            this.fld_txtARCustomerPaymentExchangeRate21.Validated += new System.EventHandler(this.fld_txtARCustomerPaymentExchangeRate_Validated);
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
            resources.ApplyResources(this.fld_txtARCustomerPaymentNo, "fld_txtARCustomerPaymentNo");
            this.fld_txtARCustomerPaymentNo.MenuManager = this.screenToolbar;
            this.fld_txtARCustomerPaymentNo.Name = "fld_txtARCustomerPaymentNo";
            this.fld_txtARCustomerPaymentNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerPaymentNo, ((bool)(resources.GetObject("fld_txtARCustomerPaymentNo.ShowHelp"))));
            this.fld_txtARCustomerPaymentNo.Tag = "DC";
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
            resources.ApplyResources(this.bosLabel3, "bosLabel3");
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, ((bool)(resources.GetObject("bosLabel3.ShowHelp"))));
            this.bosLabel3.Tag = "";
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
            resources.ApplyResources(this.bosLabel2, "bosLabel2");
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, ((bool)(resources.GetObject("bosLabel2.ShowHelp"))));
            this.bosLabel2.Tag = "";
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
            resources.ApplyResources(this.fld_lblLabel3, "fld_lblLabel3");
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel3, ((bool)(resources.GetObject("fld_lblLabel3.ShowHelp"))));
            this.fld_lblLabel3.Tag = "";
            // 
            // fld_dteARCustomerPaymentDate
            // 
            this.fld_dteARCustomerPaymentDate.BOSComment = "";
            this.fld_dteARCustomerPaymentDate.BOSDataMember = "ARCustomerPaymentDate";
            this.fld_dteARCustomerPaymentDate.BOSDataSource = "ARCustomerPayments";
            this.fld_dteARCustomerPaymentDate.BOSDescription = null;
            this.fld_dteARCustomerPaymentDate.BOSError = null;
            this.fld_dteARCustomerPaymentDate.BOSFieldGroup = "";
            this.fld_dteARCustomerPaymentDate.BOSFieldRelation = "";
            this.fld_dteARCustomerPaymentDate.BOSPrivilege = "";
            this.fld_dteARCustomerPaymentDate.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_dteARCustomerPaymentDate, "fld_dteARCustomerPaymentDate");
            this.fld_dteARCustomerPaymentDate.Name = "fld_dteARCustomerPaymentDate";
            this.fld_dteARCustomerPaymentDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARCustomerPaymentDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARCustomerPaymentDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARCustomerPaymentDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARCustomerPaymentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteARCustomerPaymentDate.Properties.Buttons"))))});
            this.fld_dteARCustomerPaymentDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARCustomerPaymentDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteARCustomerPaymentDate, ((bool)(resources.GetObject("fld_dteARCustomerPaymentDate.ShowHelp"))));
            this.fld_dteARCustomerPaymentDate.Tag = "DC";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = false;
            this.fld_lkeFK_GECurrencyID.BOSComment = "";
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ARCustomerPayments";
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
            resources.ApplyResources(this.fld_lkeFK_GECurrencyID, "fld_lkeFK_GECurrencyID");
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_GECurrencyID.Properties.Buttons"))))});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_GECurrencyID.Properties.Columns"), resources.GetString("fld_lkeFK_GECurrencyID.Properties.Columns1"))});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = resources.GetString("fld_lkeFK_GECurrencyID.Properties.NullText");
            this.fld_lkeFK_GECurrencyID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GECurrencyID, ((bool)(resources.GetObject("fld_lkeFK_GECurrencyID.ShowHelp"))));
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
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
            resources.ApplyResources(this.fld_btnInvoice, "fld_btnInvoice");
            this.fld_btnInvoice.Name = "fld_btnInvoice";
            this.fld_btnInvoice.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnInvoice, ((bool)(resources.GetObject("fld_btnInvoice.ShowHelp"))));
            this.fld_btnInvoice.Click += new System.EventHandler(this.fld_btnInvoice_Click);
            // 
            // fld_dgcARCustomerPaymentTimePayments
            // 
            this.fld_dgcARCustomerPaymentTimePayments.AllowDrop = true;
            resources.ApplyResources(this.fld_dgcARCustomerPaymentTimePayments, "fld_dgcARCustomerPaymentTimePayments");
            this.fld_dgcARCustomerPaymentTimePayments.BOSComment = "";
            this.fld_dgcARCustomerPaymentTimePayments.BOSDataMember = "";
            this.fld_dgcARCustomerPaymentTimePayments.BOSDataSource = "ARCustomerPaymentTimePayments";
            this.fld_dgcARCustomerPaymentTimePayments.BOSDescription = null;
            this.fld_dgcARCustomerPaymentTimePayments.BOSError = null;
            this.fld_dgcARCustomerPaymentTimePayments.BOSFieldGroup = "";
            this.fld_dgcARCustomerPaymentTimePayments.BOSFieldRelation = "";
            this.fld_dgcARCustomerPaymentTimePayments.BOSGridType = null;
            this.fld_dgcARCustomerPaymentTimePayments.BOSPrivilege = "";
            this.fld_dgcARCustomerPaymentTimePayments.BOSPropertyName = "";
            this.fld_dgcARCustomerPaymentTimePayments.CommodityType = "";
            this.fld_dgcARCustomerPaymentTimePayments.MainView = this.fld_dgvARCustomerPaymentTimePayments;
            this.fld_dgcARCustomerPaymentTimePayments.Name = "fld_dgcARCustomerPaymentTimePayments";
            this.fld_dgcARCustomerPaymentTimePayments.PrintReport = false;
            this.fld_dgcARCustomerPaymentTimePayments.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcARCustomerPaymentTimePayments, ((bool)(resources.GetObject("fld_dgcARCustomerPaymentTimePayments.ShowHelp"))));
            this.fld_dgcARCustomerPaymentTimePayments.Tag = "DC";
            this.fld_dgcARCustomerPaymentTimePayments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARCustomerPaymentTimePayments});
            // 
            // fld_dgvARCustomerPaymentTimePayments
            // 
            this.fld_dgvARCustomerPaymentTimePayments.GridControl = this.fld_dgcARCustomerPaymentTimePayments;
            this.fld_dgvARCustomerPaymentTimePayments.Name = "fld_dgvARCustomerPaymentTimePayments";
            this.fld_dgvARCustomerPaymentTimePayments.PaintStyleName = "Office2003";
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
            resources.ApplyResources(this.bosPanel1, "bosPanel1");
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosPanel1, ((bool)(resources.GetObject("bosPanel1.ShowHelp"))));
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
            this.bosPanel2.Controls.Add(this.bosTextBox6);
            this.bosPanel2.Controls.Add(this.bosTextBox5);
            this.bosPanel2.Controls.Add(this.bosLabel85);
            this.bosPanel2.Controls.Add(this.fld_dteAACreatedDate);
            this.bosPanel2.Controls.Add(this.bosLabel41);
            this.bosPanel2.Controls.Add(this.bosLabel14);
            this.bosPanel2.Controls.Add(this.pick);
            this.bosPanel2.Controls.Add(this.bosLabel13);
            this.bosPanel2.Controls.Add(this.fld_lblLabel5);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_CSCashFundID);
            this.bosPanel2.Controls.Add(this.bosLabel12);
            this.bosPanel2.Controls.Add(this.bosLabel11);
            this.bosPanel2.Controls.Add(this.bosLabel10);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_ACSegmentID);
            this.bosPanel2.Controls.Add(this.fld_tabCustomerPayments);
            this.bosPanel2.Controls.Add(this.fld_medARCustomerPaymentDesc);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel2.Controls.Add(this.bosLabel2);
            this.bosPanel2.Controls.Add(this.fld_pteARCustomerPaymentEmployeePicture);
            this.bosPanel2.Controls.Add(this.bosLabel3);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel2.Controls.Add(this.fld_txtARCustomerPaymentExchangeRate21);
            this.bosPanel2.Controls.Add(this.bosLabel1);
            this.bosPanel2.Controls.Add(this.fld_txtARCustomerPaymentBankAccount);
            this.bosPanel2.Controls.Add(this.fld_txtARCustomerPaymentTotalAmount);
            this.bosPanel2.Controls.Add(this.fld_txtARCustomerPaymentSenderName);
            this.bosPanel2.Controls.Add(this.fld_txtARCustomerPaymentNo);
            this.bosPanel2.Controls.Add(this.bosLabel4);
            this.bosPanel2.Controls.Add(this.bosLabel5);
            this.bosPanel2.Controls.Add(this.bosLabel6);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_CSCompanyBankID);
            this.bosPanel2.Controls.Add(this.bosLabel7);
            this.bosPanel2.Controls.Add(this.bosLabel8);
            this.bosPanel2.Controls.Add(this.fld_lblLabel3);
            this.bosPanel2.Controls.Add(this.fld_dteARCustomerPaymentDate);
            resources.ApplyResources(this.bosPanel2, "bosPanel2");
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosPanel2, ((bool)(resources.GetObject("bosPanel2.ShowHelp"))));
            // 
            // bosTextBox6
            // 
            this.bosTextBox6.BOSComment = null;
            this.bosTextBox6.BOSDataMember = "ARCustomerPaymentSaleContract";
            this.bosTextBox6.BOSDataSource = "ARCustomerPayments";
            this.bosTextBox6.BOSDescription = null;
            this.bosTextBox6.BOSError = null;
            this.bosTextBox6.BOSFieldGroup = null;
            this.bosTextBox6.BOSFieldRelation = null;
            this.bosTextBox6.BOSPrivilege = null;
            this.bosTextBox6.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.bosTextBox6, "bosTextBox6");
            this.bosTextBox6.Name = "bosTextBox6";
            this.bosTextBox6.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox6.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox6.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox6.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox6.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("bosTextBox6.Properties.Mask.UseMaskAsDisplayFormat")));
            this.bosTextBox6.Properties.MaskSettings.Set("mask", "n");
            this.bosTextBox6.Screen = null;
            this.bosTextBox6.Tag = "DC";
            // 
            // bosTextBox5
            // 
            this.bosTextBox5.BOSComment = null;
            this.bosTextBox5.BOSDataMember = "ARCustomerPaymentProject";
            this.bosTextBox5.BOSDataSource = "ARCustomerPayments";
            this.bosTextBox5.BOSDescription = null;
            this.bosTextBox5.BOSError = null;
            this.bosTextBox5.BOSFieldGroup = null;
            this.bosTextBox5.BOSFieldRelation = null;
            this.bosTextBox5.BOSPrivilege = null;
            this.bosTextBox5.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.bosTextBox5, "bosTextBox5");
            this.bosTextBox5.Name = "bosTextBox5";
            this.bosTextBox5.Screen = null;
            this.bosTextBox5.Tag = "DC";
            // 
            // bosLabel85
            // 
            this.bosLabel85.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel85.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel85.Appearance.Options.UseBackColor = true;
            this.bosLabel85.Appearance.Options.UseForeColor = true;
            this.bosLabel85.BOSComment = null;
            this.bosLabel85.BOSDataMember = null;
            this.bosLabel85.BOSDataSource = null;
            this.bosLabel85.BOSDescription = null;
            this.bosLabel85.BOSError = null;
            this.bosLabel85.BOSFieldGroup = null;
            this.bosLabel85.BOSFieldRelation = null;
            this.bosLabel85.BOSPrivilege = null;
            this.bosLabel85.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel85, "bosLabel85");
            this.bosLabel85.Name = "bosLabel85";
            this.bosLabel85.Screen = null;
            // 
            // fld_dteAACreatedDate
            // 
            this.fld_dteAACreatedDate.BOSComment = null;
            this.fld_dteAACreatedDate.BOSDataMember = "AACreatedDate";
            this.fld_dteAACreatedDate.BOSDataSource = "ARCustomerPayments";
            this.fld_dteAACreatedDate.BOSDescription = null;
            this.fld_dteAACreatedDate.BOSError = null;
            this.fld_dteAACreatedDate.BOSFieldGroup = null;
            this.fld_dteAACreatedDate.BOSFieldRelation = null;
            this.fld_dteAACreatedDate.BOSPrivilege = null;
            this.fld_dteAACreatedDate.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_dteAACreatedDate, "fld_dteAACreatedDate");
            this.fld_dteAACreatedDate.Name = "fld_dteAACreatedDate";
            this.fld_dteAACreatedDate.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_dteAACreatedDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAACreatedDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAACreatedDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAACreatedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteAACreatedDate.Properties.Buttons"))))});
            this.fld_dteAACreatedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAACreatedDate.Properties.DisplayFormat.FormatString = "g";
            this.fld_dteAACreatedDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteAACreatedDate.Properties.EditFormat.FormatString = "g";
            this.fld_dteAACreatedDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteAACreatedDate.Properties.Mask.EditMask = resources.GetString("fld_dteAACreatedDate.Properties.Mask.EditMask");
            this.fld_dteAACreatedDate.Properties.ReadOnly = true;
            this.fld_dteAACreatedDate.Screen = null;
            this.fld_dteAACreatedDate.Tag = "DC";
            // 
            // bosLabel41
            // 
            this.bosLabel41.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel41.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel41.Appearance.Options.UseBackColor = true;
            this.bosLabel41.Appearance.Options.UseForeColor = true;
            this.bosLabel41.BOSComment = null;
            this.bosLabel41.BOSDataMember = null;
            this.bosLabel41.BOSDataSource = null;
            this.bosLabel41.BOSDescription = null;
            this.bosLabel41.BOSError = null;
            this.bosLabel41.BOSFieldGroup = null;
            this.bosLabel41.BOSFieldRelation = null;
            this.bosLabel41.BOSPrivilege = null;
            this.bosLabel41.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel41, "bosLabel41");
            this.bosLabel41.Name = "bosLabel41";
            this.bosLabel41.Screen = null;
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
            resources.ApplyResources(this.bosLabel14, "bosLabel14");
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel14, ((bool)(resources.GetObject("bosLabel14.ShowHelp"))));
            this.bosLabel14.Tag = "";
            // 
            // pick
            // 
            this.pick.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pick.Appearance.ForeColor = System.Drawing.Color.Red;
            this.pick.Appearance.Options.UseBackColor = true;
            this.pick.Appearance.Options.UseForeColor = true;
            this.pick.BOSComment = "";
            this.pick.BOSDataMember = "";
            this.pick.BOSDataSource = "";
            this.pick.BOSDescription = null;
            this.pick.BOSError = null;
            this.pick.BOSFieldGroup = "";
            this.pick.BOSFieldRelation = "";
            this.pick.BOSPrivilege = "";
            this.pick.BOSPropertyName = "";
            resources.ApplyResources(this.pick, "pick");
            this.pick.Name = "pick";
            this.pick.Screen = null;
            this.ScreenHelper.SetShowHelp(this.pick, ((bool)(resources.GetObject("pick.ShowHelp"))));
            this.pick.Tag = "";
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
            resources.ApplyResources(this.bosLabel13, "bosLabel13");
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel13, ((bool)(resources.GetObject("bosLabel13.ShowHelp"))));
            this.bosLabel13.Tag = "";
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
            resources.ApplyResources(this.fld_lblLabel5, "fld_lblLabel5");
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Tag = "";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ARCustomerPayments";
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
            resources.ApplyResources(this.fld_lkeFK_ACObjectID, "fld_lkeFK_ACObjectID");
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_ACObjectID.Properties.Buttons"))))});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ACObjectID.Properties.Columns"), resources.GetString("fld_lkeFK_ACObjectID.Properties.Columns1"), ((int)(resources.GetObject("fld_lkeFK_ACObjectID.Properties.Columns2"))), ((DevExpress.Utils.FormatType)(resources.GetObject("fld_lkeFK_ACObjectID.Properties.Columns3"))), resources.GetString("fld_lkeFK_ACObjectID.Properties.Columns4"), ((bool)(resources.GetObject("fld_lkeFK_ACObjectID.Properties.Columns5"))), ((DevExpress.Utils.HorzAlignment)(resources.GetObject("fld_lkeFK_ACObjectID.Properties.Columns6"))), ((DevExpress.Data.ColumnSortOrder)(resources.GetObject("fld_lkeFK_ACObjectID.Properties.Columns7"))), ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("fld_lkeFK_ACObjectID.Properties.Columns8")))),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ACObjectID.Properties.Columns9"), resources.GetString("fld_lkeFK_ACObjectID.Properties.Columns10"))});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = resources.GetString("fld_lkeFK_ACObjectID.Properties.NullText");
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            // 
            // fld_lkeFK_CSCashFundID
            // 
            this.fld_lkeFK_CSCashFundID.BOSAllowAddNew = false;
            this.fld_lkeFK_CSCashFundID.BOSAllowDummy = false;
            this.fld_lkeFK_CSCashFundID.BOSComment = "";
            this.fld_lkeFK_CSCashFundID.BOSDataMember = "FK_CSCashFundID";
            this.fld_lkeFK_CSCashFundID.BOSDataSource = "ARCustomerPayments";
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
            resources.ApplyResources(this.fld_lkeFK_CSCashFundID, "fld_lkeFK_CSCashFundID");
            this.fld_lkeFK_CSCashFundID.Name = "fld_lkeFK_CSCashFundID";
            this.fld_lkeFK_CSCashFundID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_CSCashFundID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_CSCashFundID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_CSCashFundID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_CSCashFundID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_CSCashFundID.Properties.Buttons"))))});
            this.fld_lkeFK_CSCashFundID.Properties.ColumnName = null;
            this.fld_lkeFK_CSCashFundID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_CSCashFundID.Properties.Columns"), resources.GetString("fld_lkeFK_CSCashFundID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_CSCashFundID.Properties.Columns2"), resources.GetString("fld_lkeFK_CSCashFundID.Properties.Columns3"))});
            this.fld_lkeFK_CSCashFundID.Properties.DisplayMember = "CSCashFundName";
            this.fld_lkeFK_CSCashFundID.Properties.NullText = resources.GetString("fld_lkeFK_CSCashFundID.Properties.NullText");
            this.fld_lkeFK_CSCashFundID.Properties.PopupWidth = 40;
            this.fld_lkeFK_CSCashFundID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_CSCashFundID.Properties.ValueMember = "CSCashFundID";
            this.fld_lkeFK_CSCashFundID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_CSCashFundID, ((bool)(resources.GetObject("fld_lkeFK_CSCashFundID.ShowHelp"))));
            this.fld_lkeFK_CSCashFundID.Tag = "DC";
            this.fld_lkeFK_CSCashFundID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_CSCashFundID_CloseUp);
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
            resources.ApplyResources(this.bosLabel12, "bosLabel12");
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel12, ((bool)(resources.GetObject("bosLabel12.ShowHelp"))));
            this.bosLabel12.Tag = "";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = "";
            this.bosLabel11.BOSDataSource = "";
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = "";
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel11, "bosLabel11");
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
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
            resources.ApplyResources(this.bosLabel10, "bosLabel10");
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, ((bool)(resources.GetObject("bosLabel10.ShowHelp"))));
            this.bosLabel10.Tag = "";
            // 
            // fld_lkeFK_ACSegmentID
            // 
            this.fld_lkeFK_ACSegmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACSegmentID.BOSAllowDummy = true;
            this.fld_lkeFK_ACSegmentID.BOSComment = "";
            this.fld_lkeFK_ACSegmentID.BOSDataMember = "FK_ACSegmentID";
            this.fld_lkeFK_ACSegmentID.BOSDataSource = "ARCustomerPayments";
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
            resources.ApplyResources(this.fld_lkeFK_ACSegmentID, "fld_lkeFK_ACSegmentID");
            this.fld_lkeFK_ACSegmentID.Name = "fld_lkeFK_ACSegmentID";
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACSegmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_ACSegmentID.Properties.Buttons"))))});
            this.fld_lkeFK_ACSegmentID.Properties.ColumnName = null;
            this.fld_lkeFK_ACSegmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ACSegmentID.Properties.Columns"), resources.GetString("fld_lkeFK_ACSegmentID.Properties.Columns1"))});
            this.fld_lkeFK_ACSegmentID.Properties.DisplayMember = "ACSegmentName";
            this.fld_lkeFK_ACSegmentID.Properties.NullText = resources.GetString("fld_lkeFK_ACSegmentID.Properties.NullText");
            this.fld_lkeFK_ACSegmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACSegmentID.Properties.ValueMember = "ACSegmentID";
            this.fld_lkeFK_ACSegmentID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ACSegmentID, ((bool)(resources.GetObject("fld_lkeFK_ACSegmentID.ShowHelp"))));
            this.fld_lkeFK_ACSegmentID.Tag = "DC";
            // 
            // fld_tabCustomerPayments
            // 
            resources.ApplyResources(this.fld_tabCustomerPayments, "fld_tabCustomerPayments");
            this.fld_tabCustomerPayments.BOSComment = null;
            this.fld_tabCustomerPayments.BOSDataMember = null;
            this.fld_tabCustomerPayments.BOSDataSource = null;
            this.fld_tabCustomerPayments.BOSDescription = null;
            this.fld_tabCustomerPayments.BOSError = null;
            this.fld_tabCustomerPayments.BOSFieldGroup = null;
            this.fld_tabCustomerPayments.BOSFieldRelation = null;
            this.fld_tabCustomerPayments.BOSPrivilege = null;
            this.fld_tabCustomerPayments.BOSPropertyName = null;
            this.fld_tabCustomerPayments.Name = "fld_tabCustomerPayments";
            this.fld_tabCustomerPayments.Screen = null;
            this.fld_tabCustomerPayments.SelectedTabPage = this.fld_tabPageCustomerPayment;
            this.ScreenHelper.SetShowHelp(this.fld_tabCustomerPayments, ((bool)(resources.GetObject("fld_tabCustomerPayments.ShowHelp"))));
            this.fld_tabCustomerPayments.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageCustomerPayment,
            this.fld_tabPagePosting});
            // 
            // fld_tabPageCustomerPayment
            // 
            this.fld_tabPageCustomerPayment.Controls.Add(this.fld_dgcARCustomerPaymentTimePayments);
            this.fld_tabPageCustomerPayment.Controls.Add(this.fld_btnInvoice);
            this.fld_tabPageCustomerPayment.Name = "fld_tabPageCustomerPayment";
            this.ScreenHelper.SetShowHelp(this.fld_tabPageCustomerPayment, ((bool)(resources.GetObject("fld_tabPageCustomerPayment.ShowHelp"))));
            resources.ApplyResources(this.fld_tabPageCustomerPayment, "fld_tabPageCustomerPayment");
            // 
            // fld_tabPagePosting
            // 
            this.fld_tabPagePosting.Controls.Add(this.fld_dgcARCustomerPaymentDocuments);
            this.fld_tabPagePosting.Controls.Add(this.fld_dgcDocumentEntrys);
            this.fld_tabPagePosting.Name = "fld_tabPagePosting";
            this.ScreenHelper.SetShowHelp(this.fld_tabPagePosting, ((bool)(resources.GetObject("fld_tabPagePosting.ShowHelp"))));
            resources.ApplyResources(this.fld_tabPagePosting, "fld_tabPagePosting");
            // 
            // fld_dgcARCustomerPaymentDocuments
            // 
            this.fld_dgcARCustomerPaymentDocuments.AllowDrop = true;
            this.fld_dgcARCustomerPaymentDocuments.BOSComment = "";
            this.fld_dgcARCustomerPaymentDocuments.BOSDataMember = "";
            this.fld_dgcARCustomerPaymentDocuments.BOSDataSource = "ARCustomerPaymentDocuments";
            this.fld_dgcARCustomerPaymentDocuments.BOSDescription = null;
            this.fld_dgcARCustomerPaymentDocuments.BOSError = null;
            this.fld_dgcARCustomerPaymentDocuments.BOSFieldGroup = "";
            this.fld_dgcARCustomerPaymentDocuments.BOSFieldRelation = "";
            this.fld_dgcARCustomerPaymentDocuments.BOSGridType = null;
            this.fld_dgcARCustomerPaymentDocuments.BOSPrivilege = "";
            this.fld_dgcARCustomerPaymentDocuments.BOSPropertyName = "";
            this.fld_dgcARCustomerPaymentDocuments.CommodityType = "";
            resources.ApplyResources(this.fld_dgcARCustomerPaymentDocuments, "fld_dgcARCustomerPaymentDocuments");
            this.fld_dgcARCustomerPaymentDocuments.MainView = this.gridView1;
            this.fld_dgcARCustomerPaymentDocuments.Name = "fld_dgcARCustomerPaymentDocuments";
            this.fld_dgcARCustomerPaymentDocuments.PrintReport = false;
            this.fld_dgcARCustomerPaymentDocuments.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcARCustomerPaymentDocuments, ((bool)(resources.GetObject("fld_dgcARCustomerPaymentDocuments.ShowHelp"))));
            this.fld_dgcARCustomerPaymentDocuments.Tag = "DC";
            this.fld_dgcARCustomerPaymentDocuments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcARCustomerPaymentDocuments;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
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
            resources.ApplyResources(this.fld_dgcDocumentEntrys, "fld_dgcDocumentEntrys");
            this.fld_dgcDocumentEntrys.MainView = this.fld_dgvACBankTransactionItems;
            this.fld_dgcDocumentEntrys.Name = "fld_dgcDocumentEntrys";
            this.fld_dgcDocumentEntrys.PrintReport = false;
            this.fld_dgcDocumentEntrys.Screen = null;
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
            resources.ApplyResources(this.fld_medARCustomerPaymentDesc, "fld_medARCustomerPaymentDesc");
            this.fld_medARCustomerPaymentDesc.MenuManager = this.screenToolbar;
            this.fld_medARCustomerPaymentDesc.Name = "fld_medARCustomerPaymentDesc";
            this.fld_medARCustomerPaymentDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medARCustomerPaymentDesc, ((bool)(resources.GetObject("fld_medARCustomerPaymentDesc.ShowHelp"))));
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
            this.fld_pteARCustomerPaymentEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARCustomerPaymentEmployeePicture.FileName = null;
            this.fld_pteARCustomerPaymentEmployeePicture.FilePath = null;
            resources.ApplyResources(this.fld_pteARCustomerPaymentEmployeePicture, "fld_pteARCustomerPaymentEmployeePicture");
            this.fld_pteARCustomerPaymentEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteARCustomerPaymentEmployeePicture.Name = "fld_pteARCustomerPaymentEmployeePicture";
            this.fld_pteARCustomerPaymentEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARCustomerPaymentEmployeePicture.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_pteARCustomerPaymentEmployeePicture, ((bool)(resources.GetObject("fld_pteARCustomerPaymentEmployeePicture.ShowHelp"))));
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
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_HREmployeeID, "fld_lkeFK_HREmployeeID");
            this.fld_lkeFK_HREmployeeID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_HREmployeeID.Properties.Buttons"))))});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = resources.GetString("fld_lkeFK_HREmployeeID.Properties.NullText");
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID, ((bool)(resources.GetObject("fld_lkeFK_HREmployeeID.ShowHelp"))));
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
            resources.ApplyResources(this.fld_txtARCustomerPaymentBankAccount, "fld_txtARCustomerPaymentBankAccount");
            this.fld_txtARCustomerPaymentBankAccount.Name = "fld_txtARCustomerPaymentBankAccount";
            this.fld_txtARCustomerPaymentBankAccount.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerPaymentBankAccount, ((bool)(resources.GetObject("fld_txtARCustomerPaymentBankAccount.ShowHelp"))));
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
            resources.ApplyResources(this.fld_txtARCustomerPaymentTotalAmount, "fld_txtARCustomerPaymentTotalAmount");
            this.fld_txtARCustomerPaymentTotalAmount.Name = "fld_txtARCustomerPaymentTotalAmount";
            this.fld_txtARCustomerPaymentTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARCustomerPaymentTotalAmount.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerPaymentTotalAmount, ((bool)(resources.GetObject("fld_txtARCustomerPaymentTotalAmount.ShowHelp"))));
            this.fld_txtARCustomerPaymentTotalAmount.Tag = "DC";
            this.fld_txtARCustomerPaymentTotalAmount.Validated += new System.EventHandler(this.fld_txtARCustomerPaymentTotalAmount_Validated);
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
            resources.ApplyResources(this.fld_txtARCustomerPaymentSenderName, "fld_txtARCustomerPaymentSenderName");
            this.fld_txtARCustomerPaymentSenderName.Name = "fld_txtARCustomerPaymentSenderName";
            this.fld_txtARCustomerPaymentSenderName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARCustomerPaymentSenderName, ((bool)(resources.GetObject("fld_txtARCustomerPaymentSenderName.ShowHelp"))));
            this.fld_txtARCustomerPaymentSenderName.Tag = "DC";
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
            resources.ApplyResources(this.bosLabel4, "bosLabel4");
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, ((bool)(resources.GetObject("bosLabel4.ShowHelp"))));
            this.bosLabel4.Tag = "";
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
            resources.ApplyResources(this.bosLabel5, "bosLabel5");
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, ((bool)(resources.GetObject("bosLabel5.ShowHelp"))));
            this.bosLabel5.Tag = "";
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
            resources.ApplyResources(this.bosLabel6, "bosLabel6");
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, ((bool)(resources.GetObject("bosLabel6.ShowHelp"))));
            this.bosLabel6.Tag = "";
            // 
            // fld_lkeFK_CSCompanyBankID
            // 
            this.fld_lkeFK_CSCompanyBankID.BOSAllowAddNew = false;
            this.fld_lkeFK_CSCompanyBankID.BOSAllowDummy = true;
            this.fld_lkeFK_CSCompanyBankID.BOSComment = "";
            this.fld_lkeFK_CSCompanyBankID.BOSDataMember = "FK_CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.BOSDataSource = "ARCustomerPayments";
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
            resources.ApplyResources(this.fld_lkeFK_CSCompanyBankID, "fld_lkeFK_CSCompanyBankID");
            this.fld_lkeFK_CSCompanyBankID.Name = "fld_lkeFK_CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_CSCompanyBankID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_CSCompanyBankID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_CSCompanyBankID.Properties.Buttons"))))});
            this.fld_lkeFK_CSCompanyBankID.Properties.ColumnName = null;
            this.fld_lkeFK_CSCompanyBankID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_CSCompanyBankID.Properties.Columns"), resources.GetString("fld_lkeFK_CSCompanyBankID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_CSCompanyBankID.Properties.Columns2"), resources.GetString("fld_lkeFK_CSCompanyBankID.Properties.Columns3")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_CSCompanyBankID.Properties.Columns4"), resources.GetString("fld_lkeFK_CSCompanyBankID.Properties.Columns5"))});
            this.fld_lkeFK_CSCompanyBankID.Properties.DisplayMember = "CSCompanyBankName";
            this.fld_lkeFK_CSCompanyBankID.Properties.NullText = resources.GetString("fld_lkeFK_CSCompanyBankID.Properties.NullText");
            this.fld_lkeFK_CSCompanyBankID.Properties.PopupWidth = 40;
            this.fld_lkeFK_CSCompanyBankID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_CSCompanyBankID.Properties.ValueMember = "CSCompanyBankID";
            this.fld_lkeFK_CSCompanyBankID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_CSCompanyBankID, ((bool)(resources.GetObject("fld_lkeFK_CSCompanyBankID.ShowHelp"))));
            this.fld_lkeFK_CSCompanyBankID.Tag = "DC";
            this.fld_lkeFK_CSCompanyBankID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_CSCompanyBankID_CloseUp);
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
            resources.ApplyResources(this.bosLabel7, "bosLabel7");
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, ((bool)(resources.GetObject("bosLabel7.ShowHelp"))));
            this.bosLabel7.Tag = "";
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
            resources.ApplyResources(this.bosLabel8, "bosLabel8");
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, ((bool)(resources.GetObject("bosLabel8.ShowHelp"))));
            this.bosLabel8.Tag = "";
            // 
            // DMARCPTP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.bosPanel2);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMARCPTP100.IconOptions.Icon")));
            this.Name = "DMARCPTP100";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentExchangeRate21.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCustomerPaymentDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCustomerPaymentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCustomerPaymentTimePayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCustomerPaymentTimePayments)).EndInit();
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAACreatedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAACreatedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCashFundID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCustomerPayments)).EndInit();
            this.fld_tabCustomerPayments.ResumeLayout(false);
            this.fld_tabPageCustomerPayment.ResumeLayout(false);
            this.fld_tabPagePosting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCustomerPaymentDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACBankTransactionItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARCustomerPaymentDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARCustomerPaymentEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentBankAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentSenderName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyBankID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtARCustomerPaymentNo;
        private CustomerPaymentTimePaymentsGridControl fld_dgcARCustomerPaymentTimePayments;
        private BOSComponent.BOSButton fld_btnInvoice;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSTextBox fld_txtARCustomerPaymentExchangeRate21;
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
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtARCustomerPaymentTotalAmount;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtARCustomerPaymentSenderName;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACSegmentID;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeFK_CSCashFundID;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel pick;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel bosLabel41;
        private BOSComponent.BOSDateEdit fld_dteAACreatedDate;
        private BOSERP.Modules.CustomerPaymentTimePayment.DocumentEntryGridControl fld_dgcDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACBankTransactionItems;
        private ARCustomerPaymentDocumentsGridControl fld_dgcARCustomerPaymentDocuments;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSLabel bosLabel85;
        private BOSComponent.BOSTextBox bosTextBox5;
        private BOSComponent.BOSTextBox bosTextBox6;
    }
}
