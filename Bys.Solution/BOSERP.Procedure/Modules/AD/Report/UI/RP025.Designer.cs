namespace BOSERP.Modules.Report
{
    partial class RP025
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_bedEmployees = new BOSComponent.BOSButtonEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeBRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARSellerID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteSearchToARSaleOrderDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromARSaleOrderDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARRP025ARSaleOrders = new BOSERP.Modules.Report.ARRP025SaleOrdersGridControl();
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            this.fld_lblBRBranchName = new BOSComponent.BOSLabel(this.components);
            this.lbl_FromdateTodate = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedEmployees.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSellerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARRP025ARSaleOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.panelControl1.Controls.Add(this.fld_bedEmployees);
            this.panelControl1.Controls.Add(this.bosLabel5);
            this.panelControl1.Controls.Add(this.bosLabel4);
            this.panelControl1.Controls.Add(this.bosLabel3);
            this.panelControl1.Controls.Add(this.fld_lkeBRBranchID);
            this.panelControl1.Controls.Add(this.bosLabel8);
            this.panelControl1.Controls.Add(this.fld_lkeFK_ARSellerID);
            this.panelControl1.Controls.Add(this.fld_dteSearchToARSaleOrderDate);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromARSaleOrderDate);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Controls.Add(this.BOSLabel2);
            this.panelControl1.Controls.Add(this.BOSLabel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(942, 97);
            this.panelControl1.TabIndex = 1;
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ARSaleOrders";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(334, 12);
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
            this.fld_lkeFK_ACObjectID.TabIndex = 91;
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
            this.fld_bedEmployees.Location = new System.Drawing.Point(81, 38);
            this.fld_bedEmployees.MenuManager = this.screenToolbar;
            this.fld_bedEmployees.Name = "fld_bedEmployees";
            this.fld_bedEmployees.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedEmployees.Properties.ReadOnly = true;
            this.fld_bedEmployees.Screen = null;
            this.fld_bedEmployees.Size = new System.Drawing.Size(403, 20);
            this.fld_bedEmployees.TabIndex = 6;
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
            this.bosLabel5.Location = new System.Drawing.Point(13, 41);
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
            this.bosLabel4.Location = new System.Drawing.Point(261, 15);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(56, 13);
            this.bosLabel4.TabIndex = 2;
            this.bosLabel4.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel4.Text = "Khách hàng";
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
            this.bosLabel3.Location = new System.Drawing.Point(13, 15);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 0;
            this.bosLabel3.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.Text = "Chi nhánh";
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
            this.fld_lkeBRBranchID.Location = new System.Drawing.Point(81, 12);
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
            this.bosLabel8.Location = new System.Drawing.Point(511, 15);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(49, 13);
            this.bosLabel8.TabIndex = 4;
            this.bosLabel8.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel8.Text = "Người bán";
            // 
            // fld_lkeFK_ARSellerID
            // 
            this.fld_lkeFK_ARSellerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSellerID.BOSAllowDummy = true;
            this.fld_lkeFK_ARSellerID.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ARSellerID.BOSDataMember = "FK_ARSellerID";
            this.fld_lkeFK_ARSellerID.BOSDataSource = "ARSaleOrders";
            this.fld_lkeFK_ARSellerID.BOSDescription = null;
            this.fld_lkeFK_ARSellerID.BOSError = null;
            this.fld_lkeFK_ARSellerID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ARSellerID.BOSFieldParent = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ARSellerID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ARSellerID.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ARSellerID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARSellerID.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ARSellerID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ARSellerID.CurrentDisplayText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ARSellerID.Location = new System.Drawing.Point(578, 12);
            this.fld_lkeFK_ARSellerID.Name = "fld_lkeFK_ARSellerID";
            this.fld_lkeFK_ARSellerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARSellerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARSellerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARSellerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARSellerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARSellerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã người bán"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên người bán")});
            this.fld_lkeFK_ARSellerID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_ARSellerID.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ARSellerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARSellerID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_ARSellerID.Screen = null;
            this.fld_lkeFK_ARSellerID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARSellerID.TabIndex = 5;
            this.fld_lkeFK_ARSellerID.Tag = "DC";
            // 
            // fld_dteSearchToARSaleOrderDate
            // 
            this.fld_dteSearchToARSaleOrderDate.BOSComment = null;
            this.fld_dteSearchToARSaleOrderDate.BOSDataMember = "ARSaleOrderDate";
            this.fld_dteSearchToARSaleOrderDate.BOSDataSource = "ARSaleOrders";
            this.fld_dteSearchToARSaleOrderDate.BOSDescription = null;
            this.fld_dteSearchToARSaleOrderDate.BOSError = null;
            this.fld_dteSearchToARSaleOrderDate.BOSFieldGroup = null;
            this.fld_dteSearchToARSaleOrderDate.BOSFieldRelation = null;
            this.fld_dteSearchToARSaleOrderDate.BOSPrivilege = null;
            this.fld_dteSearchToARSaleOrderDate.BOSPropertyName = null;
            this.fld_dteSearchToARSaleOrderDate.EditValue = null;
            this.fld_dteSearchToARSaleOrderDate.Location = new System.Drawing.Point(334, 64);
            this.fld_dteSearchToARSaleOrderDate.Name = "fld_dteSearchToARSaleOrderDate";
            this.fld_dteSearchToARSaleOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARSaleOrderDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARSaleOrderDate.Screen = null;
            this.fld_dteSearchToARSaleOrderDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToARSaleOrderDate.TabIndex = 11;
            this.fld_dteSearchToARSaleOrderDate.Tag = "SC";
            // 
            // fld_dteSearchFromARSaleOrderDate
            // 
            this.fld_dteSearchFromARSaleOrderDate.BOSComment = null;
            this.fld_dteSearchFromARSaleOrderDate.BOSDataMember = "ARSaleOrderDate";
            this.fld_dteSearchFromARSaleOrderDate.BOSDataSource = "ARSaleOrders";
            this.fld_dteSearchFromARSaleOrderDate.BOSDescription = null;
            this.fld_dteSearchFromARSaleOrderDate.BOSError = null;
            this.fld_dteSearchFromARSaleOrderDate.BOSFieldGroup = null;
            this.fld_dteSearchFromARSaleOrderDate.BOSFieldRelation = null;
            this.fld_dteSearchFromARSaleOrderDate.BOSPrivilege = null;
            this.fld_dteSearchFromARSaleOrderDate.BOSPropertyName = null;
            this.fld_dteSearchFromARSaleOrderDate.EditValue = null;
            this.fld_dteSearchFromARSaleOrderDate.Location = new System.Drawing.Point(81, 64);
            this.fld_dteSearchFromARSaleOrderDate.Name = "fld_dteSearchFromARSaleOrderDate";
            this.fld_dteSearchFromARSaleOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARSaleOrderDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARSaleOrderDate.Screen = null;
            this.fld_dteSearchFromARSaleOrderDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromARSaleOrderDate.TabIndex = 9;
            this.fld_dteSearchFromARSaleOrderDate.Tag = "SC";
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
            this.fld_btnApply.Location = new System.Drawing.Point(759, 9);
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
            this.BOSLabel2.Location = new System.Drawing.Point(261, 67);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.BOSLabel2.Size = new System.Drawing.Size(20, 13);
            this.BOSLabel2.TabIndex = 10;
            this.BOSLabel2.Text = "Đến";
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
            this.BOSLabel1.Location = new System.Drawing.Point(13, 67);
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
            this.fld_lblTitle.Location = new System.Drawing.Point(351, 112);
            this.fld_lblTitle.Name = "fld_lblTitle";
            this.fld_lblTitle.Screen = null;
            this.fld_lblTitle.Size = new System.Drawing.Size(193, 19);
            this.fld_lblTitle.TabIndex = 1;
            this.fld_lblTitle.Text = "DANH SÁCH ĐƠN HÀNG";
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
            this.fld_btnClose.Location = new System.Drawing.Point(855, 552);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 3;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_dgcARRP025ARSaleOrders
            // 
            this.fld_dgcARRP025ARSaleOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARRP025ARSaleOrders.BOSComment = null;
            this.fld_dgcARRP025ARSaleOrders.BOSDataMember = null;
            this.fld_dgcARRP025ARSaleOrders.BOSDataSource = "ARSaleOrders";
            this.fld_dgcARRP025ARSaleOrders.BOSDescription = null;
            this.fld_dgcARRP025ARSaleOrders.BOSError = null;
            this.fld_dgcARRP025ARSaleOrders.BOSFieldGroup = null;
            this.fld_dgcARRP025ARSaleOrders.BOSFieldRelation = null;
            this.fld_dgcARRP025ARSaleOrders.BOSGridType = null;
            this.fld_dgcARRP025ARSaleOrders.BOSPrivilege = null;
            this.fld_dgcARRP025ARSaleOrders.BOSPropertyName = null;
            this.fld_dgcARRP025ARSaleOrders.Location = new System.Drawing.Point(12, 159);
            this.fld_dgcARRP025ARSaleOrders.Name = "fld_dgcARRP025ARSaleOrders";
            this.fld_dgcARRP025ARSaleOrders.PrintReport = false;
            this.fld_dgcARRP025ARSaleOrders.Screen = null;
            this.fld_dgcARRP025ARSaleOrders.Size = new System.Drawing.Size(918, 376);
            this.fld_dgcARRP025ARSaleOrders.TabIndex = 5;
            this.fld_dgcARRP025ARSaleOrders.Tag = "DC";
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
            this.fld_btnPrint.Location = new System.Drawing.Point(774, 552);
            this.fld_btnPrint.Name = "fld_btnPrint";
            this.fld_btnPrint.Screen = null;
            this.fld_btnPrint.Size = new System.Drawing.Size(75, 27);
            this.fld_btnPrint.TabIndex = 2;
            this.fld_btnPrint.Text = "In";
            this.fld_btnPrint.Click += new System.EventHandler(this.fld_btnPrint_Click);
            // 
            // fld_lblBRBranchName
            // 
            this.fld_lblBRBranchName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.fld_lblBRBranchName.Appearance.Options.UseFont = true;
            this.fld_lblBRBranchName.BOSComment = null;
            this.fld_lblBRBranchName.BOSDataMember = "BRBranchName";
            this.fld_lblBRBranchName.BOSDataSource = "BRBranchs";
            this.fld_lblBRBranchName.BOSDescription = null;
            this.fld_lblBRBranchName.BOSError = null;
            this.fld_lblBRBranchName.BOSFieldGroup = null;
            this.fld_lblBRBranchName.BOSFieldRelation = null;
            this.fld_lblBRBranchName.BOSPrivilege = null;
            this.fld_lblBRBranchName.BOSPropertyName = null;
            this.fld_lblBRBranchName.Location = new System.Drawing.Point(550, 112);
            this.fld_lblBRBranchName.Name = "fld_lblBRBranchName";
            this.fld_lblBRBranchName.Screen = null;
            this.fld_lblBRBranchName.Size = new System.Drawing.Size(38, 19);
            this.fld_lblBRBranchName.TabIndex = 2;
            this.fld_lblBRBranchName.Tag = "HD";
            this.fld_lblBRBranchName.Text = "Text";
            // 
            // lbl_FromdateTodate
            // 
            this.lbl_FromdateTodate.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_FromdateTodate.Appearance.Options.UseFont = true;
            this.lbl_FromdateTodate.BOSComment = null;
            this.lbl_FromdateTodate.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.lbl_FromdateTodate.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.lbl_FromdateTodate.BOSDescription = null;
            this.lbl_FromdateTodate.BOSError = null;
            this.lbl_FromdateTodate.BOSFieldGroup = null;
            this.lbl_FromdateTodate.BOSFieldRelation = null;
            this.lbl_FromdateTodate.BOSPrivilege = null;
            this.lbl_FromdateTodate.BOSPropertyName = null;
            this.lbl_FromdateTodate.Location = new System.Drawing.Point(351, 137);
            this.lbl_FromdateTodate.Name = "lbl_FromdateTodate";
            this.lbl_FromdateTodate.Screen = null;
            this.lbl_FromdateTodate.Size = new System.Drawing.Size(28, 16);
            this.lbl_FromdateTodate.TabIndex = 3;
            this.lbl_FromdateTodate.Tag = "HD";
            this.lbl_FromdateTodate.Text = "Text";
            // 
            // RP025
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 597);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnPrint);
            this.Controls.Add(this.fld_dgcARRP025ARSaleOrders);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.fld_lblTitle);
            this.Controls.Add(this.lbl_FromdateTodate);
            this.Controls.Add(this.fld_lblBRBranchName);
            this.Name = "RP025";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách đơn hàng";
            this.Load += new System.EventHandler(this.RP025_Load);
            this.Controls.SetChildIndex(this.fld_lblBRBranchName, 0);
            this.Controls.SetChildIndex(this.lbl_FromdateTodate, 0);
            this.Controls.SetChildIndex(this.fld_lblTitle, 0);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcARRP025ARSaleOrders, 0);
            this.Controls.SetChildIndex(this.fld_btnPrint, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedEmployees.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSellerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARRP025ARSaleOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSDateEdit fld_dteSearchToARSaleOrderDate;
        private BOSComponent.BOSDateEdit fld_dteSearchFromARSaleOrderDate;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSellerID;
        private BOSComponent.BOSLabel fld_lblTitle;
        private BOSComponent.BOSButton fld_btnClose;
        private ARRP025SaleOrdersGridControl fld_dgcARRP025ARSaleOrders;
        private BOSComponent.BOSButton fld_btnPrint;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchID;
        private BOSComponent.BOSLabel fld_lblBRBranchName;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel lbl_FromdateTodate;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSButtonEdit fld_bedEmployees;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;

    }
}