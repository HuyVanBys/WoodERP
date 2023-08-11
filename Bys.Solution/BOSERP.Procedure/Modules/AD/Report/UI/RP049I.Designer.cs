namespace BOSERP.Modules.Report
{
    partial class RP049I
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
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_lkeACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeGECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosPanel1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeBRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeGELocationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_cmbViewType = new BOSComponent.BOSComboBox(this.components);
            this.fld_lkeObjectType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcACRP049Accounts = new BOSERP.Modules.Report.AccountGridControl();
            this.fld_chkSellectAllAccount = new BOSComponent.BOSCheckEdit(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGELocationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbViewType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeObjectType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACRP049Accounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSellectAllAccount.Properties)).BeginInit();
            this.bosLine2.SuspendLayout();
            this.SuspendLayout();
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
            this.fld_btnPrint.Location = new System.Drawing.Point(576, 412);
            this.fld_btnPrint.Name = "fld_btnPrint";
            this.fld_btnPrint.Screen = null;
            this.fld_btnPrint.Size = new System.Drawing.Size(75, 27);
            this.fld_btnPrint.TabIndex = 4;
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
            this.fld_btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnClose.Location = new System.Drawing.Point(657, 412);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 5;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_lkeACObjectID
            // 
            this.fld_lkeACObjectID.BOSAllowAddNew = false;
            this.fld_lkeACObjectID.BOSAllowDummy = true;
            this.fld_lkeACObjectID.BOSComment = null;
            this.fld_lkeACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeACObjectID.BOSDataSource = "ACObjects";
            this.fld_lkeACObjectID.BOSDescription = null;
            this.fld_lkeACObjectID.BOSError = null;
            this.fld_lkeACObjectID.BOSFieldGroup = null;
            this.fld_lkeACObjectID.BOSFieldParent = null;
            this.fld_lkeACObjectID.BOSFieldRelation = null;
            this.fld_lkeACObjectID.BOSPrivilege = null;
            this.fld_lkeACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeACObjectID.BOSSelectType = null;
            this.fld_lkeACObjectID.BOSSelectTypeValue = null;
            this.fld_lkeACObjectID.CurrentDisplayText = null;
            this.fld_lkeACObjectID.Location = new System.Drawing.Point(341, 38);
            this.fld_lkeACObjectID.MenuManager = this.screenToolbar;
            this.fld_lkeACObjectID.Name = "fld_lkeACObjectID";
            this.fld_lkeACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACObjectID.Screen = null;
            this.fld_lkeACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACObjectID.TabIndex = 6;
            // 
            // fld_lkeGECurrencyID
            // 
            this.fld_lkeGECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeGECurrencyID.BOSAllowDummy = false;
            this.fld_lkeGECurrencyID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGECurrencyID.BOSDataMember = "GECurrencyID";
            this.fld_lkeGECurrencyID.BOSDataSource = "GECurrencies";
            this.fld_lkeGECurrencyID.BOSDescription = null;
            this.fld_lkeGECurrencyID.BOSError = null;
            this.fld_lkeGECurrencyID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGECurrencyID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGECurrencyID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGECurrencyID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeGECurrencyID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGECurrencyID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGECurrencyID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGECurrencyID.Location = new System.Drawing.Point(582, 12);
            this.fld_lkeGECurrencyID.Name = "fld_lkeGECurrencyID";
            this.fld_lkeGECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeGECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeGECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeGECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeGECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeGECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeGECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeGECurrencyID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeGECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeGECurrencyID.Screen = null;
            this.fld_lkeGECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeGECurrencyID.TabIndex = 4;
            this.fld_lkeGECurrencyID.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(273, 41);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "Đối tượng";
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(514, 15);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(53, 13);
            this.bosLabel2.TabIndex = 0;
            this.bosLabel2.Text = "Loại tiền tệ";
            // 
            // fld_dteSearchToDate
            // 
            this.fld_dteSearchToDate.BOSComment = null;
            this.fld_dteSearchToDate.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToDate.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToDate.BOSDescription = null;
            this.fld_dteSearchToDate.BOSError = null;
            this.fld_dteSearchToDate.BOSFieldGroup = null;
            this.fld_dteSearchToDate.BOSFieldRelation = null;
            this.fld_dteSearchToDate.BOSPrivilege = null;
            this.fld_dteSearchToDate.BOSPropertyName = null;
            this.fld_dteSearchToDate.EditValue = null;
            this.fld_dteSearchToDate.Location = new System.Drawing.Point(341, 12);
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Screen = null;
            this.fld_dteSearchToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToDate.TabIndex = 2;
            this.fld_dteSearchToDate.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(273, 15);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(47, 13);
            this.bosLabel9.TabIndex = 2;
            this.bosLabel9.Text = "Đến ngày";
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
            this.bosLabel10.Location = new System.Drawing.Point(21, 15);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(40, 13);
            this.bosLabel10.TabIndex = 0;
            this.bosLabel10.Text = "Từ ngày";
            // 
            // fld_dteSearchFromDate
            // 
            this.fld_dteSearchFromDate.BOSComment = null;
            this.fld_dteSearchFromDate.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromDate.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromDate.BOSDescription = null;
            this.fld_dteSearchFromDate.BOSError = null;
            this.fld_dteSearchFromDate.BOSFieldGroup = null;
            this.fld_dteSearchFromDate.BOSFieldRelation = null;
            this.fld_dteSearchFromDate.BOSPrivilege = null;
            this.fld_dteSearchFromDate.BOSPropertyName = null;
            this.fld_dteSearchFromDate.EditValue = null;
            this.fld_dteSearchFromDate.Location = new System.Drawing.Point(106, 12);
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Screen = null;
            this.fld_dteSearchFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromDate.TabIndex = 1;
            this.fld_dteSearchFromDate.Tag = "DC";
            // 
            // bosPanel1
            // 
            this.bosPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosPanel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosPanel1.Appearance.Options.UseBackColor = true;
            this.bosPanel1.Appearance.Options.UseForeColor = true;
            this.bosPanel1.Controls.Add(this.fld_lkeBRBranchID);
            this.bosPanel1.Controls.Add(this.fld_lkeGELocationID);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_cmbViewType);
            this.bosPanel1.Controls.Add(this.fld_lkeObjectType);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeACObjectID);
            this.bosPanel1.Controls.Add(this.fld_lkeGECurrencyID);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_dteSearchToDate);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.fld_dteSearchFromDate);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Size = new System.Drawing.Size(744, 89);
            this.bosPanel1.TabIndex = 0;
            this.bosPanel1.Tag = global::Localization.ReportLocalizedResources.String1;
            // 
            // fld_lkeBRBranchID
            // 
            this.fld_lkeBRBranchID.BOSAllowAddNew = false;
            this.fld_lkeBRBranchID.BOSAllowDummy = true;
            this.fld_lkeBRBranchID.BOSComment = null;
            this.fld_lkeBRBranchID.BOSDataMember = "BRBranchID";
            this.fld_lkeBRBranchID.BOSDataSource = "BRBranchs";
            this.fld_lkeBRBranchID.BOSDescription = null;
            this.fld_lkeBRBranchID.BOSError = null;
            this.fld_lkeBRBranchID.BOSFieldGroup = null;
            this.fld_lkeBRBranchID.BOSFieldParent = null;
            this.fld_lkeBRBranchID.BOSFieldRelation = null;
            this.fld_lkeBRBranchID.BOSPrivilege = null;
            this.fld_lkeBRBranchID.BOSPropertyName = null;
            this.fld_lkeBRBranchID.BOSSelectType = null;
            this.fld_lkeBRBranchID.BOSSelectTypeValue = null;
            this.fld_lkeBRBranchID.CurrentDisplayText = null;
            this.fld_lkeBRBranchID.Location = new System.Drawing.Point(341, 64);
            this.fld_lkeBRBranchID.Name = "fld_lkeBRBranchID";
            this.fld_lkeBRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeBRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchID.Screen = null;
            this.fld_lkeBRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchID.TabIndex = 10;
            // 
            // fld_lkeGELocationID
            // 
            this.fld_lkeGELocationID.BOSAllowAddNew = false;
            this.fld_lkeGELocationID.BOSAllowDummy = true;
            this.fld_lkeGELocationID.BOSComment = null;
            this.fld_lkeGELocationID.BOSDataMember = "GELocationID";
            this.fld_lkeGELocationID.BOSDataSource = "GELocations";
            this.fld_lkeGELocationID.BOSDescription = null;
            this.fld_lkeGELocationID.BOSError = null;
            this.fld_lkeGELocationID.BOSFieldGroup = null;
            this.fld_lkeGELocationID.BOSFieldParent = null;
            this.fld_lkeGELocationID.BOSFieldRelation = null;
            this.fld_lkeGELocationID.BOSPrivilege = null;
            this.fld_lkeGELocationID.BOSPropertyName = null;
            this.fld_lkeGELocationID.BOSSelectType = null;
            this.fld_lkeGELocationID.BOSSelectTypeValue = null;
            this.fld_lkeGELocationID.CurrentDisplayText = null;
            this.fld_lkeGELocationID.Location = new System.Drawing.Point(106, 64);
            this.fld_lkeGELocationID.MenuManager = this.screenToolbar;
            this.fld_lkeGELocationID.Name = "fld_lkeGELocationID";
            this.fld_lkeGELocationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeGELocationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GELocationName", "Vị trí")});
            this.fld_lkeGELocationID.Properties.DisplayMember = "GELocationName";
            this.fld_lkeGELocationID.Properties.ValueMember = "GELocationID";
            this.fld_lkeGELocationID.Screen = null;
            this.fld_lkeGELocationID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeGELocationID.TabIndex = 9;
            // 
            // bosLabel6
            // 
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(273, 67);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 11;
            this.bosLabel6.Text = "Chi nhánh";
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(21, 67);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(21, 13);
            this.bosLabel5.TabIndex = 12;
            this.bosLabel5.Text = "Vị trí";
            // 
            // fld_cmbViewType
            // 
            this.fld_cmbViewType.BOSComment = null;
            this.fld_cmbViewType.BOSDataMember = null;
            this.fld_cmbViewType.BOSDataSource = null;
            this.fld_cmbViewType.BOSDescription = null;
            this.fld_cmbViewType.BOSError = null;
            this.fld_cmbViewType.BOSFieldGroup = null;
            this.fld_cmbViewType.BOSFieldRelation = null;
            this.fld_cmbViewType.BOSPrivilege = null;
            this.fld_cmbViewType.BOSPropertyName = null;
            this.fld_cmbViewType.EditValue = "Tất cả";
            this.fld_cmbViewType.Location = new System.Drawing.Point(582, 38);
            this.fld_cmbViewType.MenuManager = this.screenToolbar;
            this.fld_cmbViewType.Name = "fld_cmbViewType";
            this.fld_cmbViewType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cmbViewType.Properties.Items.AddRange(new object[] {
            "Tất cả",
            "Có công nợ"});
            this.fld_cmbViewType.Screen = null;
            this.fld_cmbViewType.Size = new System.Drawing.Size(150, 20);
            this.fld_cmbViewType.TabIndex = 7;
            // 
            // fld_lkeObjectType
            // 
            this.fld_lkeObjectType.BOSAllowAddNew = false;
            this.fld_lkeObjectType.BOSAllowDummy = true;
            this.fld_lkeObjectType.BOSComment = null;
            this.fld_lkeObjectType.BOSDataMember = "ObjectType";
            this.fld_lkeObjectType.BOSDataSource = "ADConfigValues";
            this.fld_lkeObjectType.BOSDescription = null;
            this.fld_lkeObjectType.BOSError = null;
            this.fld_lkeObjectType.BOSFieldGroup = null;
            this.fld_lkeObjectType.BOSFieldParent = null;
            this.fld_lkeObjectType.BOSFieldRelation = null;
            this.fld_lkeObjectType.BOSPrivilege = null;
            this.fld_lkeObjectType.BOSPropertyName = "EditValue";
            this.fld_lkeObjectType.BOSSelectType = null;
            this.fld_lkeObjectType.BOSSelectTypeValue = null;
            this.fld_lkeObjectType.CurrentDisplayText = null;
            this.fld_lkeObjectType.Location = new System.Drawing.Point(106, 38);
            this.fld_lkeObjectType.MenuManager = this.screenToolbar;
            this.fld_lkeObjectType.Name = "fld_lkeObjectType";
            this.fld_lkeObjectType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeObjectType.Screen = null;
            this.fld_lkeObjectType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeObjectType.TabIndex = 5;
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(514, 41);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(45, 13);
            this.bosLabel4.TabIndex = 0;
            this.bosLabel4.Text = "Xem theo";
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(21, 41);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(68, 13);
            this.bosLabel3.TabIndex = 0;
            this.bosLabel3.Text = "Loại đối tượng";
            // 
            // fld_dgcACRP049Accounts
            // 
            this.fld_dgcACRP049Accounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACRP049Accounts.BOSComment = null;
            this.fld_dgcACRP049Accounts.BOSDataMember = null;
            this.fld_dgcACRP049Accounts.BOSDataSource = "ACAccounts";
            this.fld_dgcACRP049Accounts.BOSDescription = null;
            this.fld_dgcACRP049Accounts.BOSError = null;
            this.fld_dgcACRP049Accounts.BOSFieldGroup = null;
            this.fld_dgcACRP049Accounts.BOSFieldRelation = null;
            this.fld_dgcACRP049Accounts.BOSGridType = null;
            this.fld_dgcACRP049Accounts.BOSPrivilege = null;
            this.fld_dgcACRP049Accounts.BOSPropertyName = null;
            this.fld_dgcACRP049Accounts.Location = new System.Drawing.Point(3, 20);
            this.fld_dgcACRP049Accounts.Name = "fld_dgcACRP049Accounts";
            this.fld_dgcACRP049Accounts.PrintReport = false;
            this.fld_dgcACRP049Accounts.Screen = null;
            this.fld_dgcACRP049Accounts.Size = new System.Drawing.Size(735, 255);
            this.fld_dgcACRP049Accounts.TabIndex = 0;
            this.fld_dgcACRP049Accounts.Tag = "DC";
            // 
            // fld_chkSellectAllAccount
            // 
            this.fld_chkSellectAllAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_chkSellectAllAccount.BOSComment = null;
            this.fld_chkSellectAllAccount.BOSDataMember = null;
            this.fld_chkSellectAllAccount.BOSDataSource = null;
            this.fld_chkSellectAllAccount.BOSDescription = null;
            this.fld_chkSellectAllAccount.BOSError = null;
            this.fld_chkSellectAllAccount.BOSFieldGroup = null;
            this.fld_chkSellectAllAccount.BOSFieldRelation = null;
            this.fld_chkSellectAllAccount.BOSPrivilege = null;
            this.fld_chkSellectAllAccount.BOSPropertyName = null;
            this.fld_chkSellectAllAccount.Location = new System.Drawing.Point(6, 281);
            this.fld_chkSellectAllAccount.MenuManager = this.screenToolbar;
            this.fld_chkSellectAllAccount.Name = "fld_chkSellectAllAccount";
            this.fld_chkSellectAllAccount.Properties.Caption = "Chọn tất cả";
            this.fld_chkSellectAllAccount.Screen = null;
            this.fld_chkSellectAllAccount.Size = new System.Drawing.Size(137, 19);
            this.fld_chkSellectAllAccount.TabIndex = 6;
            this.fld_chkSellectAllAccount.Tag = "DC";
            this.fld_chkSellectAllAccount.CheckedChanged += new System.EventHandler(this.fld_chkSellectAllAccount_CheckedChanged);
            // 
            // bosLine2
            // 
            this.bosLine2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine2.BackColor = System.Drawing.Color.Transparent;
            this.bosLine2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLine2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLine2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLine2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLine2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.fld_chkSellectAllAccount);
            this.bosLine2.Controls.Add(this.fld_dgcACRP049Accounts);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine2.Location = new System.Drawing.Point(0, 95);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(744, 311);
            this.bosLine2.TabIndex = 2;
            this.bosLine2.TabStop = false;
            this.bosLine2.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLine2.Text = "Danh sách tài khoản";
            // 
            // RP049I
            // 
            this.AcceptButton = this.fld_btnPrint;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(744, 447);
            this.ControlBox = true;
            this.Controls.Add(this.bosLine2);
            this.Controls.Add(this.bosPanel1);
            this.Controls.Add(this.fld_btnPrint);
            this.Controls.Add(this.fld_btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RP049I";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tham số báo cáo";
            this.Load += new System.EventHandler(this.RP049_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_btnPrint, 0);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.Controls.SetChildIndex(this.bosLine2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGELocationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbViewType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeObjectType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACRP049Accounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSellectAllAccount.Properties)).EndInit();
            this.bosLine2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnPrint;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeGECurrencyID;
        private BOSComponent.BOSLabel bosLabel1;
        private AccObjectLookupEdit fld_lkeACObjectID;
        private DevExpress.XtraEditors.PanelControl bosPanel1;
        private AccountGridControl fld_dgcACRP049Accounts;
        private BOSComponent.BOSCheckEdit fld_chkSellectAllAccount;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeObjectType;
        private BOSComponent.BOSComboBox fld_cmbViewType;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchID;
        private BOSComponent.BOSLookupEdit fld_lkeGELocationID;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel5;
    }
}