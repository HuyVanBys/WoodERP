namespace BOSERP.Modules.Report
{
    partial class RP037
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP037));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_bedEmployees = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_lkeARInvoiceTypeCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_bedGELocationName = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeBRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_lblTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_lblSubTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARRP037ARInvoiceItems = new BOSERP.Modules.Report.ARRP037InvoiceItemsGridControl();
            this.fld_lblFromdateTodate = new BOSComponent.BOSLabel(this.components);
            this.fld_btnExportExcelXls = new BOSComponent.BOSButton(this.components);
            this.fld_lkeARInvoiceStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedEmployees.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARInvoiceTypeCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedGELocationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARRP037ARInvoiceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARInvoiceStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_lkeARInvoiceStatus);
            this.panelControl1.Controls.Add(this.bosLabel4);
            this.panelControl1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.panelControl1.Controls.Add(this.fld_lkeICProductID);
            this.panelControl1.Controls.Add(this.fld_bedEmployees);
            this.panelControl1.Controls.Add(this.fld_lkeARInvoiceTypeCombo);
            this.panelControl1.Controls.Add(this.bosLabel2);
            this.panelControl1.Controls.Add(this.bosLabel3);
            this.panelControl1.Controls.Add(this.bosLabel1);
            this.panelControl1.Controls.Add(this.fld_dteSearchToDate);
            this.panelControl1.Controls.Add(this.bosLabel11);
            this.panelControl1.Controls.Add(this.bosLabel9);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromDate);
            this.panelControl1.Controls.Add(this.bosLabel10);
            this.panelControl1.Controls.Add(this.bosLabel16);
            this.panelControl1.Controls.Add(this.fld_bedGELocationName);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Controls.Add(this.bosLabel8);
            this.panelControl1.Controls.Add(this.fld_lkeBRBranchID);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1001, 90);
            this.panelControl1.TabIndex = 1;
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ARCustomers";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(591, 9);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = "";
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(149, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 95;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            // 
            // fld_lkeICProductID
            // 
            this.fld_lkeICProductID.BOSAllowAddNew = false;
            this.fld_lkeICProductID.BOSAllowDummy = true;
            this.fld_lkeICProductID.BOSComment = null;
            this.fld_lkeICProductID.BOSDataMember = "ICProductID";
            this.fld_lkeICProductID.BOSDataSource = "ICProducts";
            this.fld_lkeICProductID.BOSDescription = null;
            this.fld_lkeICProductID.BOSError = null;
            this.fld_lkeICProductID.BOSFieldGroup = null;
            this.fld_lkeICProductID.BOSFieldParent = null;
            this.fld_lkeICProductID.BOSFieldRelation = null;
            this.fld_lkeICProductID.BOSPrivilege = null;
            this.fld_lkeICProductID.BOSPropertyName = null;
            this.fld_lkeICProductID.BOSSelectType = null;
            this.fld_lkeICProductID.BOSSelectTypeValue = null;
            this.fld_lkeICProductID.CurrentDisplayText = null;
            this.fld_lkeICProductID.Location = new System.Drawing.Point(346, 35);
            this.fld_lkeICProductID.MenuManager = this.screenToolbar;
            this.fld_lkeICProductID.Name = "fld_lkeICProductID";
            this.fld_lkeICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductID.Properties.ColumnName = null;
            this.fld_lkeICProductID.Properties.DisplayMember = "ICProductDesc";
            this.fld_lkeICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductID.Screen = null;
            this.fld_lkeICProductID.Size = new System.Drawing.Size(393, 20);
            this.fld_lkeICProductID.TabIndex = 7;
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
            this.fld_bedEmployees.Location = new System.Drawing.Point(93, 35);
            this.fld_bedEmployees.MenuManager = this.screenToolbar;
            this.fld_bedEmployees.Name = "fld_bedEmployees";
            this.fld_bedEmployees.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedEmployees.Properties.ReadOnly = true;
            this.fld_bedEmployees.Screen = null;
            this.fld_bedEmployees.Size = new System.Drawing.Size(150, 20);
            this.fld_bedEmployees.TabIndex = 6;
            this.fld_bedEmployees.Tag = "";
            this.fld_bedEmployees.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedEmployees_ButtonClick);
            // 
            // fld_lkeARInvoiceTypeCombo
            // 
            this.fld_lkeARInvoiceTypeCombo.BOSAllowAddNew = false;
            this.fld_lkeARInvoiceTypeCombo.BOSAllowDummy = true;
            this.fld_lkeARInvoiceTypeCombo.BOSComment = "";
            this.fld_lkeARInvoiceTypeCombo.BOSDataMember = "ARInvoiceTypeCombo";
            this.fld_lkeARInvoiceTypeCombo.BOSDataSource = "ARInvoices";
            this.fld_lkeARInvoiceTypeCombo.BOSDescription = null;
            this.fld_lkeARInvoiceTypeCombo.BOSError = null;
            this.fld_lkeARInvoiceTypeCombo.BOSFieldGroup = "";
            this.fld_lkeARInvoiceTypeCombo.BOSFieldParent = "";
            this.fld_lkeARInvoiceTypeCombo.BOSFieldRelation = "";
            this.fld_lkeARInvoiceTypeCombo.BOSPrivilege = "";
            this.fld_lkeARInvoiceTypeCombo.BOSPropertyName = "EditValue";
            this.fld_lkeARInvoiceTypeCombo.BOSSelectType = "";
            this.fld_lkeARInvoiceTypeCombo.BOSSelectTypeValue = "";
            this.fld_lkeARInvoiceTypeCombo.CurrentDisplayText = "";
            this.fld_lkeARInvoiceTypeCombo.Location = new System.Drawing.Point(590, 61);
            this.fld_lkeARInvoiceTypeCombo.Name = "fld_lkeARInvoiceTypeCombo";
            this.fld_lkeARInvoiceTypeCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARInvoiceTypeCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARInvoiceTypeCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARInvoiceTypeCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARInvoiceTypeCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARInvoiceTypeCombo.Properties.ColumnName = null;
            this.fld_lkeARInvoiceTypeCombo.Properties.NullText = "";
            this.fld_lkeARInvoiceTypeCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARInvoiceTypeCombo.Screen = null;
            this.fld_lkeARInvoiceTypeCombo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARInvoiceTypeCombo.TabIndex = 10;
            this.fld_lkeARInvoiceTypeCombo.Tag = "DC";
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
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(514, 64);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(61, 13);
            this.bosLabel2.TabIndex = 8;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Loại hóa đơn";
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
            this.bosLabel3.Location = new System.Drawing.Point(262, 38);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(47, 13);
            this.bosLabel3.TabIndex = 6;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Sản phẩm";
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
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(12, 38);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 6;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Nhân viên";
            // 
            // fld_dteSearchToDate
            // 
            this.fld_dteSearchToDate.BOSComment = null;
            this.fld_dteSearchToDate.BOSDataMember = "";
            this.fld_dteSearchToDate.BOSDataSource = "";
            this.fld_dteSearchToDate.BOSDescription = null;
            this.fld_dteSearchToDate.BOSError = null;
            this.fld_dteSearchToDate.BOSFieldGroup = null;
            this.fld_dteSearchToDate.BOSFieldRelation = null;
            this.fld_dteSearchToDate.BOSPrivilege = null;
            this.fld_dteSearchToDate.BOSPropertyName = null;
            this.fld_dteSearchToDate.EditValue = null;
            this.fld_dteSearchToDate.Location = new System.Drawing.Point(346, 61);
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Screen = null;
            this.fld_dteSearchToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToDate.TabIndex = 9;
            this.fld_dteSearchToDate.Tag = "DC";
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
            this.bosLabel11.Location = new System.Drawing.Point(519, 12);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(56, 13);
            this.bosLabel11.TabIndex = 4;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Khách hàng";
            // 
            // bosLabel9
            // 
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(262, 64);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(47, 13);
            this.bosLabel9.TabIndex = 12;
            this.bosLabel9.Text = "Đến ngày";
            // 
            // fld_dteSearchFromDate
            // 
            this.fld_dteSearchFromDate.BOSComment = null;
            this.fld_dteSearchFromDate.BOSDataMember = "";
            this.fld_dteSearchFromDate.BOSDataSource = "";
            this.fld_dteSearchFromDate.BOSDescription = null;
            this.fld_dteSearchFromDate.BOSError = null;
            this.fld_dteSearchFromDate.BOSFieldGroup = null;
            this.fld_dteSearchFromDate.BOSFieldRelation = null;
            this.fld_dteSearchFromDate.BOSPrivilege = null;
            this.fld_dteSearchFromDate.BOSPropertyName = null;
            this.fld_dteSearchFromDate.EditValue = null;
            this.fld_dteSearchFromDate.Location = new System.Drawing.Point(93, 61);
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Screen = null;
            this.fld_dteSearchFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromDate.TabIndex = 8;
            this.fld_dteSearchFromDate.Tag = "DC";
            // 
            // bosLabel10
            // 
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(12, 64);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(40, 13);
            this.bosLabel10.TabIndex = 10;
            this.bosLabel10.Text = "Từ ngày";
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
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(12, 12);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(21, 13);
            this.bosLabel16.TabIndex = 0;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "Vị trí";
            // 
            // fld_bedGELocationName
            // 
            this.fld_bedGELocationName.BOSComment = null;
            this.fld_bedGELocationName.BOSDataMember = "GELocationName";
            this.fld_bedGELocationName.BOSDataSource = "GELocations";
            this.fld_bedGELocationName.BOSDescription = null;
            this.fld_bedGELocationName.BOSError = null;
            this.fld_bedGELocationName.BOSFieldGroup = null;
            this.fld_bedGELocationName.BOSFieldRelation = null;
            this.fld_bedGELocationName.BOSPrivilege = null;
            this.fld_bedGELocationName.BOSPropertyName = "Text";
            this.fld_bedGELocationName.Location = new System.Drawing.Point(93, 9);
            this.fld_bedGELocationName.MenuManager = this.screenToolbar;
            this.fld_bedGELocationName.Name = "fld_bedGELocationName";
            this.fld_bedGELocationName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedGELocationName.Properties.ReadOnly = true;
            this.fld_bedGELocationName.Screen = null;
            this.fld_bedGELocationName.Size = new System.Drawing.Size(150, 20);
            this.fld_bedGELocationName.TabIndex = 1;
            this.fld_bedGELocationName.Tag = "DC";
            this.fld_bedGELocationName.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedGELocationName_ButtonClick);
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
            this.fld_btnApply.Location = new System.Drawing.Point(833, 54);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(84, 27);
            this.fld_btnApply.TabIndex = 11;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
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
            this.bosLabel8.Location = new System.Drawing.Point(262, 12);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(48, 13);
            this.bosLabel8.TabIndex = 2;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Chi nhánh";
            // 
            // fld_lkeBRBranchID
            // 
            this.fld_lkeBRBranchID.BOSAllowAddNew = false;
            this.fld_lkeBRBranchID.BOSAllowDummy = true;
            this.fld_lkeBRBranchID.BOSComment = "";
            this.fld_lkeBRBranchID.BOSDataMember = "BRBranchID";
            this.fld_lkeBRBranchID.BOSDataSource = "BRBranchs";
            this.fld_lkeBRBranchID.BOSDescription = null;
            this.fld_lkeBRBranchID.BOSError = null;
            this.fld_lkeBRBranchID.BOSFieldGroup = "";
            this.fld_lkeBRBranchID.BOSFieldParent = "";
            this.fld_lkeBRBranchID.BOSFieldRelation = "";
            this.fld_lkeBRBranchID.BOSPrivilege = "";
            this.fld_lkeBRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeBRBranchID.BOSSelectType = "";
            this.fld_lkeBRBranchID.BOSSelectTypeValue = "";
            this.fld_lkeBRBranchID.CurrentDisplayText = "";
            this.fld_lkeBRBranchID.Location = new System.Drawing.Point(346, 9);
            this.fld_lkeBRBranchID.Name = "fld_lkeBRBranchID";
            this.fld_lkeBRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeBRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeBRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeBRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeBRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBRBranchID.Properties.ColumnName = null;
            this.fld_lkeBRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeBRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBRBranchID.Properties.NullText = "";
            this.fld_lkeBRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeBRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchID.Screen = null;
            this.fld_lkeBRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchID.TabIndex = 3;
            this.fld_lkeBRBranchID.Tag = "DC";
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
            this.fld_btnPrint.Location = new System.Drawing.Point(833, 639);
            this.fld_btnPrint.Name = "fld_btnPrint";
            this.fld_btnPrint.Screen = null;
            this.fld_btnPrint.Size = new System.Drawing.Size(75, 27);
            this.fld_btnPrint.TabIndex = 2;
            this.fld_btnPrint.Text = "In";
            this.fld_btnPrint.Click += new System.EventHandler(this.fld_btnPrint_Click);
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
            this.fld_btnClose.Location = new System.Drawing.Point(914, 639);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 3;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
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
            this.fld_lblTitle.Location = new System.Drawing.Point(287, 96);
            this.fld_lblTitle.Name = "fld_lblTitle";
            this.fld_lblTitle.Screen = null;
            this.fld_lblTitle.Size = new System.Drawing.Size(199, 19);
            this.fld_lblTitle.TabIndex = 1;
            this.fld_lblTitle.Text = "DANH SÁCH HÀNG GIAO";
            // 
            // fld_lblSubTitle
            // 
            this.fld_lblSubTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_lblSubTitle.Appearance.Options.UseFont = true;
            this.fld_lblSubTitle.BOSComment = null;
            this.fld_lblSubTitle.BOSDataMember = "";
            this.fld_lblSubTitle.BOSDataSource = "";
            this.fld_lblSubTitle.BOSDescription = null;
            this.fld_lblSubTitle.BOSError = null;
            this.fld_lblSubTitle.BOSFieldGroup = null;
            this.fld_lblSubTitle.BOSFieldRelation = null;
            this.fld_lblSubTitle.BOSPrivilege = null;
            this.fld_lblSubTitle.BOSPropertyName = null;
            this.fld_lblSubTitle.Location = new System.Drawing.Point(492, 96);
            this.fld_lblSubTitle.Name = "fld_lblSubTitle";
            this.fld_lblSubTitle.Screen = null;
            this.fld_lblSubTitle.Size = new System.Drawing.Size(38, 19);
            this.fld_lblSubTitle.TabIndex = 2;
            this.fld_lblSubTitle.Tag = "HD";
            this.fld_lblSubTitle.Text = "Text";
            // 
            // fld_dgcARRP037ARInvoiceItems
            // 
            this.fld_dgcARRP037ARInvoiceItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARRP037ARInvoiceItems.BOSComment = null;
            this.fld_dgcARRP037ARInvoiceItems.BOSDataMember = null;
            this.fld_dgcARRP037ARInvoiceItems.BOSDataSource = "ARInvoiceItems";
            this.fld_dgcARRP037ARInvoiceItems.BOSDescription = null;
            this.fld_dgcARRP037ARInvoiceItems.BOSError = null;
            this.fld_dgcARRP037ARInvoiceItems.BOSFieldGroup = null;
            this.fld_dgcARRP037ARInvoiceItems.BOSFieldRelation = null;
            this.fld_dgcARRP037ARInvoiceItems.BOSGridType = null;
            this.fld_dgcARRP037ARInvoiceItems.BOSPrivilege = null;
            this.fld_dgcARRP037ARInvoiceItems.BOSPropertyName = null;
            this.fld_dgcARRP037ARInvoiceItems.CommodityType = "";
            this.fld_dgcARRP037ARInvoiceItems.Location = new System.Drawing.Point(0, 143);
            this.fld_dgcARRP037ARInvoiceItems.Name = "fld_dgcARRP037ARInvoiceItems";
            this.fld_dgcARRP037ARInvoiceItems.PrintReport = false;
            this.fld_dgcARRP037ARInvoiceItems.Screen = null;
            this.fld_dgcARRP037ARInvoiceItems.Size = new System.Drawing.Size(1001, 486);
            this.fld_dgcARRP037ARInvoiceItems.TabIndex = 4;
            this.fld_dgcARRP037ARInvoiceItems.Tag = "DC";
            // 
            // fld_lblFromdateTodate
            // 
            this.fld_lblFromdateTodate.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_lblFromdateTodate.Appearance.Options.UseFont = true;
            this.fld_lblFromdateTodate.BOSComment = null;
            this.fld_lblFromdateTodate.BOSDataMember = "";
            this.fld_lblFromdateTodate.BOSDataSource = "";
            this.fld_lblFromdateTodate.BOSDescription = null;
            this.fld_lblFromdateTodate.BOSError = null;
            this.fld_lblFromdateTodate.BOSFieldGroup = null;
            this.fld_lblFromdateTodate.BOSFieldRelation = null;
            this.fld_lblFromdateTodate.BOSPrivilege = null;
            this.fld_lblFromdateTodate.BOSPropertyName = null;
            this.fld_lblFromdateTodate.Location = new System.Drawing.Point(287, 121);
            this.fld_lblFromdateTodate.Name = "fld_lblFromdateTodate";
            this.fld_lblFromdateTodate.Screen = null;
            this.fld_lblFromdateTodate.Size = new System.Drawing.Size(31, 16);
            this.fld_lblFromdateTodate.TabIndex = 3;
            this.fld_lblFromdateTodate.Tag = "HD";
            this.fld_lblFromdateTodate.Text = "Date";
            // 
            // fld_btnExportExcelXls
            // 
            this.fld_btnExportExcelXls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnExportExcelXls.BOSComment = null;
            this.fld_btnExportExcelXls.BOSDataMember = null;
            this.fld_btnExportExcelXls.BOSDataSource = null;
            this.fld_btnExportExcelXls.BOSDescription = null;
            this.fld_btnExportExcelXls.BOSError = null;
            this.fld_btnExportExcelXls.BOSFieldGroup = null;
            this.fld_btnExportExcelXls.BOSFieldRelation = null;
            this.fld_btnExportExcelXls.BOSPrivilege = null;
            this.fld_btnExportExcelXls.BOSPropertyName = null;
            this.fld_btnExportExcelXls.Location = new System.Drawing.Point(752, 639);
            this.fld_btnExportExcelXls.Name = "fld_btnExportExcelXls";
            this.fld_btnExportExcelXls.Screen = null;
            this.fld_btnExportExcelXls.Size = new System.Drawing.Size(75, 27);
            this.fld_btnExportExcelXls.TabIndex = 2;
            this.fld_btnExportExcelXls.Text = "Xuất excel";
            this.fld_btnExportExcelXls.Click += new System.EventHandler(this.fld_btnExportExcelXls_Click);
            // 
            // fld_lkeARInvoiceStatus
            // 
            this.fld_lkeARInvoiceStatus.BOSAllowAddNew = false;
            this.fld_lkeARInvoiceStatus.BOSAllowDummy = true;
            this.fld_lkeARInvoiceStatus.BOSComment = "";
            this.fld_lkeARInvoiceStatus.BOSDataMember = "ARInvoiceStatus";
            this.fld_lkeARInvoiceStatus.BOSDataSource = "ARInvoices";
            this.fld_lkeARInvoiceStatus.BOSDescription = null;
            this.fld_lkeARInvoiceStatus.BOSError = null;
            this.fld_lkeARInvoiceStatus.BOSFieldGroup = "";
            this.fld_lkeARInvoiceStatus.BOSFieldParent = "";
            this.fld_lkeARInvoiceStatus.BOSFieldRelation = "";
            this.fld_lkeARInvoiceStatus.BOSPrivilege = "";
            this.fld_lkeARInvoiceStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARInvoiceStatus.BOSSelectType = "";
            this.fld_lkeARInvoiceStatus.BOSSelectTypeValue = "";
            this.fld_lkeARInvoiceStatus.CurrentDisplayText = "";
            this.fld_lkeARInvoiceStatus.Location = new System.Drawing.Point(833, 9);
            this.fld_lkeARInvoiceStatus.Name = "fld_lkeARInvoiceStatus";
            this.fld_lkeARInvoiceStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARInvoiceStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARInvoiceStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARInvoiceStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARInvoiceStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARInvoiceStatus.Properties.ColumnName = null;
            this.fld_lkeARInvoiceStatus.Properties.NullText = "";
            this.fld_lkeARInvoiceStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARInvoiceStatus.Screen = null;
            this.fld_lkeARInvoiceStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARInvoiceStatus.TabIndex = 97;
            this.fld_lkeARInvoiceStatus.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(775, 12);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(49, 13);
            this.bosLabel4.TabIndex = 96;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Tình trạng";
            // 
            // RP037
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 674);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lblTitle);
            this.Controls.Add(this.fld_lblFromdateTodate);
            this.Controls.Add(this.fld_lblSubTitle);
            this.Controls.Add(this.fld_dgcARRP037ARInvoiceItems);
            this.Controls.Add(this.fld_btnExportExcelXls);
            this.Controls.Add(this.fld_btnPrint);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("RP037.IconOptions.Icon")));
            this.Name = "RP037";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách hàng giao";
            this.Load += new System.EventHandler(this.RP037_Load);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_btnPrint, 0);
            this.Controls.SetChildIndex(this.fld_btnExportExcelXls, 0);
            this.Controls.SetChildIndex(this.fld_dgcARRP037ARInvoiceItems, 0);
            this.Controls.SetChildIndex(this.fld_lblSubTitle, 0);
            this.Controls.SetChildIndex(this.fld_lblFromdateTodate, 0);
            this.Controls.SetChildIndex(this.fld_lblTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedEmployees.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARInvoiceTypeCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedGELocationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARRP037ARInvoiceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARInvoiceStatus.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSButtonEdit fld_bedGELocationName;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchID;
        private BOSComponent.BOSButton fld_btnPrint;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSLabel fld_lblTitle;
        private BOSComponent.BOSLabel fld_lblSubTitle;
        private ARRP037InvoiceItemsGridControl fld_dgcARRP037ARInvoiceItems;
        private BOSComponent.BOSLabel fld_lblFromdateTodate;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeARInvoiceTypeCombo;
        private BOSComponent.BOSButtonEdit fld_bedEmployees;
        private BOSComponent.BOSLabel bosLabel3;
        private ItemLookupEdit fld_lkeICProductID;
        private BOSComponent.BOSButton fld_btnExportExcelXls;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLookupEdit fld_lkeARInvoiceStatus;
        private BOSComponent.BOSLabel bosLabel4;
    }
}