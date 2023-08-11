namespace BOSERP.Modules.Report
{
    partial class RP001
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP001));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_bedEmployees = new BOSComponent.BOSButtonEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARInvoiceTypeCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeBRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteSearchToARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_lblBRBranchName = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARRP001Invoices = new BOSERP.Modules.Report.ARRP001InvoicesGridControl();
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            this.fld_lblFromdateTodate = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcRP001SaleReceipts = new BOSERP.Modules.Report.RP001SaleReceiptsGridControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lblPaymentDetailSummary = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedEmployees.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARInvoiceTypeCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARRP001Invoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP001SaleReceipts)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.panelControl1.Controls.Add(this.fld_bedEmployees);
            this.panelControl1.Controls.Add(this.bosLabel5);
            this.panelControl1.Controls.Add(this.bosLabel4);
            this.panelControl1.Controls.Add(this.fld_lkeARInvoiceTypeCombo);
            this.panelControl1.Controls.Add(this.bosLabel3);
            this.panelControl1.Controls.Add(this.bosLabel8);
            this.panelControl1.Controls.Add(this.fld_lkeBRBranchID);
            this.panelControl1.Controls.Add(this.fld_dteSearchToARInvoiceDate);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromARInvoiceDate);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Controls.Add(this.BOSLabel2);
            this.panelControl1.Controls.Add(this.BOSLabel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1038, 91);
            this.panelControl1.TabIndex = 0;
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ARInvoices";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(570, 12);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 90;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            // 
            // fld_bedEmployees
            // 
            this.fld_bedEmployees.BOSComment = null;
            this.fld_bedEmployees.BOSDataMember = null;
            this.fld_bedEmployees.BOSDataSource = null;
            this.fld_bedEmployees.BOSDescription = null;
            this.fld_bedEmployees.BOSError = null;
            this.fld_bedEmployees.BOSFieldGroup = null;
            this.fld_bedEmployees.BOSFieldRelation = null;
            this.fld_bedEmployees.BOSPrivilege = null;
            this.fld_bedEmployees.BOSPropertyName = null;
            this.fld_bedEmployees.Location = new System.Drawing.Point(77, 37);
            this.fld_bedEmployees.MenuManager = this.screenToolbar;
            this.fld_bedEmployees.Name = "fld_bedEmployees";
            this.fld_bedEmployees.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedEmployees.Properties.ReadOnly = true;
            this.fld_bedEmployees.Screen = null;
            this.fld_bedEmployees.Size = new System.Drawing.Size(403, 20);
            this.fld_bedEmployees.TabIndex = 6;
            this.fld_bedEmployees.Tag = global::Localization.CommonLocalizedResources.String1;
            this.fld_bedEmployees.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedEmployees_ButtonClick);
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
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(12, 40);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(48, 13);
            this.bosLabel5.TabIndex = 6;
            this.bosLabel5.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel5.Text = "Nhân viên";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel4.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel4.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel4.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel4.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(503, 14);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(56, 13);
            this.bosLabel4.TabIndex = 4;
            this.bosLabel4.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel4.Text = "Khách hàng";
            // 
            // fld_lkeARInvoiceTypeCombo
            // 
            this.fld_lkeARInvoiceTypeCombo.BOSAllowAddNew = false;
            this.fld_lkeARInvoiceTypeCombo.BOSAllowDummy = true;
            this.fld_lkeARInvoiceTypeCombo.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeARInvoiceTypeCombo.BOSDataMember = "ARInvoiceTypeCombo";
            this.fld_lkeARInvoiceTypeCombo.BOSDataSource = "ARInvoices";
            this.fld_lkeARInvoiceTypeCombo.BOSDescription = null;
            this.fld_lkeARInvoiceTypeCombo.BOSError = null;
            this.fld_lkeARInvoiceTypeCombo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeARInvoiceTypeCombo.BOSFieldParent = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeARInvoiceTypeCombo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeARInvoiceTypeCombo.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeARInvoiceTypeCombo.BOSPropertyName = "EditValue";
            this.fld_lkeARInvoiceTypeCombo.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeARInvoiceTypeCombo.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeARInvoiceTypeCombo.CurrentDisplayText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeARInvoiceTypeCombo.Location = new System.Drawing.Point(330, 11);
            this.fld_lkeARInvoiceTypeCombo.Name = "fld_lkeARInvoiceTypeCombo";
            this.fld_lkeARInvoiceTypeCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARInvoiceTypeCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARInvoiceTypeCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARInvoiceTypeCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARInvoiceTypeCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARInvoiceTypeCombo.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeARInvoiceTypeCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARInvoiceTypeCombo.Screen = null;
            this.fld_lkeARInvoiceTypeCombo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARInvoiceTypeCombo.TabIndex = 3;
            this.fld_lkeARInvoiceTypeCombo.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(263, 14);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(61, 13);
            this.bosLabel3.TabIndex = 2;
            this.bosLabel3.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.Text = "Loại hóa đơn";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel8.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel8.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel8.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel8.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(12, 14);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(48, 13);
            this.bosLabel8.TabIndex = 0;
            this.bosLabel8.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel8.Text = "Chi nhánh";
            // 
            // fld_lkeBRBranchID
            // 
            this.fld_lkeBRBranchID.BOSAllowAddNew = false;
            this.fld_lkeBRBranchID.BOSAllowDummy = true;
            this.fld_lkeBRBranchID.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeBRBranchID.BOSDataMember = "BRBranchID";
            this.fld_lkeBRBranchID.BOSDataSource = "BRBranchs";
            this.fld_lkeBRBranchID.BOSDescription = null;
            this.fld_lkeBRBranchID.BOSError = null;
            this.fld_lkeBRBranchID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeBRBranchID.BOSFieldParent = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeBRBranchID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeBRBranchID.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeBRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeBRBranchID.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeBRBranchID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeBRBranchID.CurrentDisplayText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeBRBranchID.Location = new System.Drawing.Point(77, 11);
            this.fld_lkeBRBranchID.Name = "fld_lkeBRBranchID";
            this.fld_lkeBRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeBRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeBRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeBRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeBRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeBRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBRBranchID.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeBRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeBRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchID.Screen = null;
            this.fld_lkeBRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchID.TabIndex = 1;
            this.fld_lkeBRBranchID.Tag = "DC";
            // 
            // fld_dteSearchToARInvoiceDate
            // 
            this.fld_dteSearchToARInvoiceDate.BOSComment = null;
            this.fld_dteSearchToARInvoiceDate.BOSDataMember = "ARInvoiceDate";
            this.fld_dteSearchToARInvoiceDate.BOSDataSource = "ARInvoices";
            this.fld_dteSearchToARInvoiceDate.BOSDescription = null;
            this.fld_dteSearchToARInvoiceDate.BOSError = null;
            this.fld_dteSearchToARInvoiceDate.BOSFieldGroup = null;
            this.fld_dteSearchToARInvoiceDate.BOSFieldRelation = null;
            this.fld_dteSearchToARInvoiceDate.BOSPrivilege = null;
            this.fld_dteSearchToARInvoiceDate.BOSPropertyName = null;
            this.fld_dteSearchToARInvoiceDate.EditValue = null;
            this.fld_dteSearchToARInvoiceDate.Location = new System.Drawing.Point(330, 63);
            this.fld_dteSearchToARInvoiceDate.Name = "fld_dteSearchToARInvoiceDate";
            this.fld_dteSearchToARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARInvoiceDate.Screen = null;
            this.fld_dteSearchToARInvoiceDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToARInvoiceDate.TabIndex = 11;
            this.fld_dteSearchToARInvoiceDate.Tag = "SC";
            // 
            // fld_dteSearchFromARInvoiceDate
            // 
            this.fld_dteSearchFromARInvoiceDate.BOSComment = null;
            this.fld_dteSearchFromARInvoiceDate.BOSDataMember = "ARInvoiceDate";
            this.fld_dteSearchFromARInvoiceDate.BOSDataSource = "ARInvoices";
            this.fld_dteSearchFromARInvoiceDate.BOSDescription = null;
            this.fld_dteSearchFromARInvoiceDate.BOSError = null;
            this.fld_dteSearchFromARInvoiceDate.BOSFieldGroup = null;
            this.fld_dteSearchFromARInvoiceDate.BOSFieldRelation = null;
            this.fld_dteSearchFromARInvoiceDate.BOSPrivilege = null;
            this.fld_dteSearchFromARInvoiceDate.BOSPropertyName = null;
            this.fld_dteSearchFromARInvoiceDate.EditValue = null;
            this.fld_dteSearchFromARInvoiceDate.Location = new System.Drawing.Point(77, 63);
            this.fld_dteSearchFromARInvoiceDate.Name = "fld_dteSearchFromARInvoiceDate";
            this.fld_dteSearchFromARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARInvoiceDate.Screen = null;
            this.fld_dteSearchFromARInvoiceDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromARInvoiceDate.TabIndex = 9;
            this.fld_dteSearchFromARInvoiceDate.Tag = "SC";
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            this.fld_btnApply.Location = new System.Drawing.Point(743, 5);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(75, 27);
            this.fld_btnApply.TabIndex = 12;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // BOSLabel2
            // 
            this.BOSLabel2.BOSComment = null;
            this.BOSLabel2.BOSDataMember = null;
            this.BOSLabel2.BOSDataSource = null;
            this.BOSLabel2.BOSDescription = null;
            this.BOSLabel2.BOSError = null;
            this.BOSLabel2.BOSFieldGroup = null;
            this.BOSLabel2.BOSFieldRelation = null;
            this.BOSLabel2.BOSPrivilege = null;
            this.BOSLabel2.BOSPropertyName = null;
            this.BOSLabel2.Location = new System.Drawing.Point(263, 66);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.BOSLabel2.Size = new System.Drawing.Size(47, 13);
            this.BOSLabel2.TabIndex = 10;
            this.BOSLabel2.Text = "Đến ngày";
            // 
            // BOSLabel1
            // 
            this.BOSLabel1.BOSComment = null;
            this.BOSLabel1.BOSDataMember = null;
            this.BOSLabel1.BOSDataSource = null;
            this.BOSLabel1.BOSDescription = null;
            this.BOSLabel1.BOSError = null;
            this.BOSLabel1.BOSFieldGroup = null;
            this.BOSLabel1.BOSFieldRelation = null;
            this.BOSLabel1.BOSPrivilege = null;
            this.BOSLabel1.BOSPropertyName = null;
            this.BOSLabel1.Location = new System.Drawing.Point(12, 66);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(40, 13);
            this.BOSLabel1.TabIndex = 8;
            this.BOSLabel1.Text = "Từ ngày";
            // 
            // fld_lblTitle
            // 
            this.fld_lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.fld_lblTitle.Appearance.Options.UseFont = true;
            this.fld_lblTitle.BOSComment = null;
            this.fld_lblTitle.BOSDataMember = null;
            this.fld_lblTitle.BOSDataSource = null;
            this.fld_lblTitle.BOSDescription = null;
            this.fld_lblTitle.BOSError = null;
            this.fld_lblTitle.BOSFieldGroup = null;
            this.fld_lblTitle.BOSFieldRelation = null;
            this.fld_lblTitle.BOSPrivilege = null;
            this.fld_lblTitle.BOSPropertyName = null;
            this.fld_lblTitle.Location = new System.Drawing.Point(413, 101);
            this.fld_lblTitle.Name = "fld_lblTitle";
            this.fld_lblTitle.Screen = null;
            this.fld_lblTitle.Size = new System.Drawing.Size(181, 19);
            this.fld_lblTitle.TabIndex = 1;
            this.fld_lblTitle.Tag = "HD";
            this.fld_lblTitle.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // fld_lblBRBranchName
            // 
            this.fld_lblBRBranchName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.fld_lblBRBranchName.Appearance.Options.UseFont = true;
            this.fld_lblBRBranchName.BOSComment = null;
            this.fld_lblBRBranchName.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblBRBranchName.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblBRBranchName.BOSDescription = null;
            this.fld_lblBRBranchName.BOSError = null;
            this.fld_lblBRBranchName.BOSFieldGroup = null;
            this.fld_lblBRBranchName.BOSFieldRelation = null;
            this.fld_lblBRBranchName.BOSPrivilege = null;
            this.fld_lblBRBranchName.BOSPropertyName = null;
            this.fld_lblBRBranchName.Location = new System.Drawing.Point(600, 101);
            this.fld_lblBRBranchName.Name = "fld_lblBRBranchName";
            this.fld_lblBRBranchName.Screen = null;
            this.fld_lblBRBranchName.Size = new System.Drawing.Size(38, 19);
            this.fld_lblBRBranchName.TabIndex = 2;
            this.fld_lblBRBranchName.Tag = "HD";
            this.fld_lblBRBranchName.Text = "Text";
            // 
            // fld_dgcARRP001Invoices
            // 
            this.fld_dgcARRP001Invoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARRP001Invoices.BOSComment = null;
            this.fld_dgcARRP001Invoices.BOSDataMember = null;
            this.fld_dgcARRP001Invoices.BOSDataSource = "ARInvoices";
            this.fld_dgcARRP001Invoices.BOSDescription = null;
            this.fld_dgcARRP001Invoices.BOSError = null;
            this.fld_dgcARRP001Invoices.BOSFieldGroup = null;
            this.fld_dgcARRP001Invoices.BOSFieldRelation = null;
            this.fld_dgcARRP001Invoices.BOSGridType = null;
            this.fld_dgcARRP001Invoices.BOSPrivilege = null;
            this.fld_dgcARRP001Invoices.BOSPropertyName = null;
            this.fld_dgcARRP001Invoices.Location = new System.Drawing.Point(12, 147);
            this.fld_dgcARRP001Invoices.Name = "fld_dgcARRP001Invoices";
            this.fld_dgcARRP001Invoices.PrintReport = false;
            this.fld_dgcARRP001Invoices.Screen = null;
            this.fld_dgcARRP001Invoices.Size = new System.Drawing.Size(1011, 419);
            this.fld_dgcARRP001Invoices.TabIndex = 4;
            this.fld_dgcARRP001Invoices.Tag = "CT";
            // 
            // fld_btnClose
            // 
            this.fld_btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnClose.BOSComment = null;
            this.fld_btnClose.BOSDataMember = null;
            this.fld_btnClose.BOSDataSource = null;
            this.fld_btnClose.BOSDescription = null;
            this.fld_btnClose.BOSError = null;
            this.fld_btnClose.BOSFieldGroup = null;
            this.fld_btnClose.BOSFieldRelation = null;
            this.fld_btnClose.BOSPrivilege = null;
            this.fld_btnClose.BOSPropertyName = null;
            this.fld_btnClose.Location = new System.Drawing.Point(948, 637);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 6;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_btnPrint
            // 
            this.fld_btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnPrint.BOSComment = null;
            this.fld_btnPrint.BOSDataMember = null;
            this.fld_btnPrint.BOSDataSource = null;
            this.fld_btnPrint.BOSDescription = null;
            this.fld_btnPrint.BOSError = null;
            this.fld_btnPrint.BOSFieldGroup = null;
            this.fld_btnPrint.BOSFieldRelation = null;
            this.fld_btnPrint.BOSPrivilege = null;
            this.fld_btnPrint.BOSPropertyName = null;
            this.fld_btnPrint.Location = new System.Drawing.Point(867, 637);
            this.fld_btnPrint.Name = "fld_btnPrint";
            this.fld_btnPrint.Screen = null;
            this.fld_btnPrint.Size = new System.Drawing.Size(75, 27);
            this.fld_btnPrint.TabIndex = 5;
            this.fld_btnPrint.Text = "In";
            this.fld_btnPrint.Click += new System.EventHandler(this.fld_btnPrint_Click);
            // 
            // fld_lblFromdateTodate
            // 
            this.fld_lblFromdateTodate.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.fld_lblFromdateTodate.Appearance.Options.UseFont = true;
            this.fld_lblFromdateTodate.BOSComment = null;
            this.fld_lblFromdateTodate.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblFromdateTodate.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblFromdateTodate.BOSDescription = null;
            this.fld_lblFromdateTodate.BOSError = null;
            this.fld_lblFromdateTodate.BOSFieldGroup = null;
            this.fld_lblFromdateTodate.BOSFieldRelation = null;
            this.fld_lblFromdateTodate.BOSPrivilege = null;
            this.fld_lblFromdateTodate.BOSPropertyName = null;
            this.fld_lblFromdateTodate.Location = new System.Drawing.Point(413, 125);
            this.fld_lblFromdateTodate.Name = "fld_lblFromdateTodate";
            this.fld_lblFromdateTodate.Screen = null;
            this.fld_lblFromdateTodate.Size = new System.Drawing.Size(28, 16);
            this.fld_lblFromdateTodate.TabIndex = 3;
            this.fld_lblFromdateTodate.Tag = "HD";
            this.fld_lblFromdateTodate.Text = "Text";
            // 
            // fld_dgcRP001SaleReceipts
            // 
            this.fld_dgcRP001SaleReceipts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcRP001SaleReceipts.BOSComment = null;
            this.fld_dgcRP001SaleReceipts.BOSDataMember = null;
            this.fld_dgcRP001SaleReceipts.BOSDataSource = "ARInvoices";
            this.fld_dgcRP001SaleReceipts.BOSDescription = null;
            this.fld_dgcRP001SaleReceipts.BOSError = null;
            this.fld_dgcRP001SaleReceipts.BOSFieldGroup = null;
            this.fld_dgcRP001SaleReceipts.BOSFieldRelation = null;
            this.fld_dgcRP001SaleReceipts.BOSGridType = null;
            this.fld_dgcRP001SaleReceipts.BOSPrivilege = null;
            this.fld_dgcRP001SaleReceipts.BOSPropertyName = null;
            this.fld_dgcRP001SaleReceipts.Location = new System.Drawing.Point(12, 147);
            this.fld_dgcRP001SaleReceipts.Name = "fld_dgcRP001SaleReceipts";
            this.fld_dgcRP001SaleReceipts.PrintReport = false;
            this.fld_dgcRP001SaleReceipts.Screen = null;
            this.fld_dgcRP001SaleReceipts.Size = new System.Drawing.Size(1011, 419);
            this.fld_dgcRP001SaleReceipts.TabIndex = 4;
            this.fld_dgcRP001SaleReceipts.Tag = global::Localization.CommonLocalizedResources.String1;
            // 
            // bosPanel1
            // 
            this.bosPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_lblPaymentDetailSummary);
            this.bosPanel1.Location = new System.Drawing.Point(12, 569);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(719, 95);
            this.bosPanel1.TabIndex = 7;
            // 
            // fld_lblPaymentDetailSummary
            // 
            this.fld_lblPaymentDetailSummary.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.fld_lblPaymentDetailSummary.Appearance.Options.UseFont = true;
            this.fld_lblPaymentDetailSummary.BOSComment = null;
            this.fld_lblPaymentDetailSummary.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblPaymentDetailSummary.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblPaymentDetailSummary.BOSDescription = null;
            this.fld_lblPaymentDetailSummary.BOSError = null;
            this.fld_lblPaymentDetailSummary.BOSFieldGroup = null;
            this.fld_lblPaymentDetailSummary.BOSFieldRelation = null;
            this.fld_lblPaymentDetailSummary.BOSPrivilege = null;
            this.fld_lblPaymentDetailSummary.BOSPropertyName = null;
            this.fld_lblPaymentDetailSummary.Location = new System.Drawing.Point(3, 3);
            this.fld_lblPaymentDetailSummary.Name = "fld_lblPaymentDetailSummary";
            this.fld_lblPaymentDetailSummary.Screen = null;
            this.fld_lblPaymentDetailSummary.Size = new System.Drawing.Size(28, 16);
            this.fld_lblPaymentDetailSummary.TabIndex = 3;
            this.fld_lblPaymentDetailSummary.Tag = "HD";
            this.fld_lblPaymentDetailSummary.Text = "Text";
            // 
            // RP001
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 672);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Controls.Add(this.fld_btnPrint);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.fld_dgcRP001SaleReceipts);
            this.Controls.Add(this.fld_dgcARRP001Invoices);
            this.Controls.Add(this.fld_lblFromdateTodate);
            this.Controls.Add(this.fld_lblBRBranchName);
            this.Controls.Add(this.fld_lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RP001";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Danh sách hóa đơn";
            this.Load += new System.EventHandler(this.RP001_Load);
            this.Controls.SetChildIndex(this.fld_lblTitle, 0);
            this.Controls.SetChildIndex(this.fld_lblBRBranchName, 0);
            this.Controls.SetChildIndex(this.fld_lblFromdateTodate, 0);
            this.Controls.SetChildIndex(this.fld_dgcARRP001Invoices, 0);
            this.Controls.SetChildIndex(this.fld_dgcRP001SaleReceipts, 0);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_btnPrint, 0);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedEmployees.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARInvoiceTypeCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARRP001Invoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP001SaleReceipts)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSDateEdit fld_dteSearchToARInvoiceDate;
        private BOSComponent.BOSDateEdit fld_dteSearchFromARInvoiceDate;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel fld_lblTitle;
        private BOSComponent.BOSLabel fld_lblBRBranchName;
        private ARRP001InvoicesGridControl fld_dgcARRP001Invoices;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSButton fld_btnPrint;
        private BOSComponent.BOSLookupEdit fld_lkeARInvoiceTypeCombo;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel fld_lblFromdateTodate;
        private BOSComponent.BOSLabel bosLabel5;
        private RP001SaleReceiptsGridControl fld_dgcRP001SaleReceipts;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel fld_lblPaymentDetailSummary;
        private BOSComponent.BOSButtonEdit fld_bedEmployees;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;

    }
}