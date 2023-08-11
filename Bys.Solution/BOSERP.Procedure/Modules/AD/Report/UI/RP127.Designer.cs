namespace BOSERP.Modules.Report
{
    partial class RP127
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
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductAttributeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_APSupplierID = new BOSComponent.BOSLookupEdit(this.components);
            this.BOSLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductSerieID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcRP127GridControls = new BOSERP.Modules.Report.RP127GridControl();
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductAttributeID.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductSerieID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP127GridControls)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // fld_btnPrint
            // 
            this.fld_btnPrint.BOSComment = null;
            this.fld_btnPrint.BOSDataMember = null;
            this.fld_btnPrint.BOSDataSource = null;
            this.fld_btnPrint.BOSDescription = null;
            this.fld_btnPrint.BOSError = null;
            this.fld_btnPrint.BOSFieldGroup = null;
            this.fld_btnPrint.BOSFieldRelation = null;
            this.fld_btnPrint.BOSPrivilege = null;
            this.fld_btnPrint.BOSPropertyName = null;
            this.fld_btnPrint.Location = new System.Drawing.Point(609, 41);
            this.fld_btnPrint.Name = "fld_btnPrint";
            this.fld_btnPrint.Screen = null;
            this.fld_btnPrint.Size = new System.Drawing.Size(150, 27);
            this.fld_btnPrint.TabIndex = 10;
            this.fld_btnPrint.Text = "Xem";
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
            this.fld_btnClose.Location = new System.Drawing.Point(691, 459);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 11;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn1.Name = "gridColumn1";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(538, 15);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(34, 13);
            this.bosLabel2.TabIndex = 92;
            this.bosLabel2.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.Text = "Loại gỗ";
            // 
            // fld_lkeICProductAttributeID
            // 
            this.fld_lkeICProductAttributeID.BOSAllowAddNew = false;
            this.fld_lkeICProductAttributeID.BOSAllowDummy = true;
            this.fld_lkeICProductAttributeID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductAttributeID.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductAttributeID.BOSDataSource = "ICProductAttributes";
            this.fld_lkeICProductAttributeID.BOSDescription = null;
            this.fld_lkeICProductAttributeID.BOSError = null;
            this.fld_lkeICProductAttributeID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductAttributeID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductAttributeID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductAttributeID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductAttributeID.BOSPropertyName = "EditValue";
            this.fld_lkeICProductAttributeID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeICProductAttributeID.BOSSelectTypeValue = "WoodType";
            this.fld_lkeICProductAttributeID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductAttributeID.Location = new System.Drawing.Point(609, 12);
            this.fld_lkeICProductAttributeID.Name = "fld_lkeICProductAttributeID";
            this.fld_lkeICProductAttributeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICProductAttributeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICProductAttributeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductAttributeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICProductAttributeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductAttributeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "Loại")});
            this.fld_lkeICProductAttributeID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeICProductAttributeID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductAttributeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductAttributeID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeICProductAttributeID.Screen = null;
            this.fld_lkeICProductAttributeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICProductAttributeID.TabIndex = 91;
            this.fld_lkeICProductAttributeID.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_APSupplierID);
            this.bosPanel1.Controls.Add(this.BOSLabel4);
            this.bosPanel1.Controls.Add(this.fld_dteSearchFromDate);
            this.bosPanel1.Controls.Add(this.fld_dteSearchToDate);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductSerieID);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_dgcRP127GridControls);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_btnPrint);
            this.bosPanel1.Controls.Add(this.fld_lkeICProductAttributeID);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(777, 493);
            this.bosPanel1.TabIndex = 98;
            // 
            // fld_lkeFK_APSupplierID
            // 
            this.fld_lkeFK_APSupplierID.BOSAllowAddNew = false;
            this.fld_lkeFK_APSupplierID.BOSAllowDummy = true;
            this.fld_lkeFK_APSupplierID.BOSComment = null;
            this.fld_lkeFK_APSupplierID.BOSDataMember = "FK_APSupplierID";
            this.fld_lkeFK_APSupplierID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_APSupplierID.BOSDescription = null;
            this.fld_lkeFK_APSupplierID.BOSError = null;
            this.fld_lkeFK_APSupplierID.BOSFieldGroup = null;
            this.fld_lkeFK_APSupplierID.BOSFieldParent = null;
            this.fld_lkeFK_APSupplierID.BOSFieldRelation = null;
            this.fld_lkeFK_APSupplierID.BOSPrivilege = null;
            this.fld_lkeFK_APSupplierID.BOSPropertyName = null;
            this.fld_lkeFK_APSupplierID.BOSSelectType = null;
            this.fld_lkeFK_APSupplierID.BOSSelectTypeValue = null;
            this.fld_lkeFK_APSupplierID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.Location = new System.Drawing.Point(95, 12);
            this.fld_lkeFK_APSupplierID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_APSupplierID.Name = "fld_lkeFK_APSupplierID";
            this.fld_lkeFK_APSupplierID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APSupplierID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierNo", "Mã NCC"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierName", "Tên NCC")});
            this.fld_lkeFK_APSupplierID.Properties.DisplayMember = "APSupplierName";
            this.fld_lkeFK_APSupplierID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APSupplierID.Properties.ValueMember = "APSupplierID";
            this.fld_lkeFK_APSupplierID.Screen = null;
            this.fld_lkeFK_APSupplierID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_APSupplierID.TabIndex = 113;
            this.fld_lkeFK_APSupplierID.Tag = "SC";
            // 
            // BOSLabel4
            // 
            this.BOSLabel4.BOSComment = null;
            this.BOSLabel4.BOSDataMember = null;
            this.BOSLabel4.BOSDataSource = null;
            this.BOSLabel4.BOSDescription = null;
            this.BOSLabel4.BOSError = null;
            this.BOSLabel4.BOSFieldGroup = null;
            this.BOSLabel4.BOSFieldRelation = null;
            this.BOSLabel4.BOSPrivilege = null;
            this.BOSLabel4.BOSPropertyName = null;
            this.BOSLabel4.Location = new System.Drawing.Point(24, 15);
            this.BOSLabel4.Name = "BOSLabel4";
            this.BOSLabel4.Screen = null;
            this.BOSLabel4.Size = new System.Drawing.Size(65, 13);
            this.BOSLabel4.TabIndex = 114;
            this.BOSLabel4.Text = "Nhà cung cấp";
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
            this.fld_dteSearchFromDate.Location = new System.Drawing.Point(348, 12);
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Screen = null;
            this.fld_dteSearchFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromDate.TabIndex = 109;
            this.fld_dteSearchFromDate.Tag = "DC";
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
            this.fld_dteSearchToDate.Location = new System.Drawing.Point(348, 38);
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Screen = null;
            this.fld_dteSearchToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToDate.TabIndex = 111;
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
            this.bosLabel9.Location = new System.Drawing.Point(277, 41);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(47, 13);
            this.bosLabel9.TabIndex = 112;
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
            this.bosLabel10.Location = new System.Drawing.Point(277, 15);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(40, 13);
            this.bosLabel10.TabIndex = 110;
            this.bosLabel10.Text = "Từ ngày";
            // 
            // fld_lkeFK_ICProductSerieID
            // 
            this.fld_lkeFK_ICProductSerieID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductSerieID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductSerieID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductSerieID.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductSerieID.BOSDataSource = "ICProductSeries";
            this.fld_lkeFK_ICProductSerieID.BOSDescription = null;
            this.fld_lkeFK_ICProductSerieID.BOSError = null;
            this.fld_lkeFK_ICProductSerieID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductSerieID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductSerieID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductSerieID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductSerieID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductSerieID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductSerieID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductSerieID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductSerieID.Location = new System.Drawing.Point(95, 38);
            this.fld_lkeFK_ICProductSerieID.Name = "fld_lkeFK_ICProductSerieID";
            this.fld_lkeFK_ICProductSerieID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductSerieID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductSerieID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductSerieID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductSerieID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductSerieID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductSerieNo", "Mã lô")});
            this.fld_lkeFK_ICProductSerieID.Properties.DisplayMember = "ICProductSerieNo";
            this.fld_lkeFK_ICProductSerieID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductSerieID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductSerieID.Properties.ValueMember = "ICProductSerieID";
            this.fld_lkeFK_ICProductSerieID.Screen = null;
            this.fld_lkeFK_ICProductSerieID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICProductSerieID.TabIndex = 108;
            this.fld_lkeFK_ICProductSerieID.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(24, 41);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(58, 13);
            this.bosLabel5.TabIndex = 104;
            this.bosLabel5.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.Text = "Mã đầu lóng";
            // 
            // fld_dgcRP127GridControls
            // 
            this.fld_dgcRP127GridControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcRP127GridControls.BOSComment = null;
            this.fld_dgcRP127GridControls.BOSDataMember = null;
            this.fld_dgcRP127GridControls.BOSDataSource = null;
            this.fld_dgcRP127GridControls.BOSDescription = null;
            this.fld_dgcRP127GridControls.BOSError = null;
            this.fld_dgcRP127GridControls.BOSFieldGroup = null;
            this.fld_dgcRP127GridControls.BOSFieldRelation = null;
            this.fld_dgcRP127GridControls.BOSGridType = null;
            this.fld_dgcRP127GridControls.BOSPrivilege = null;
            this.fld_dgcRP127GridControls.BOSPropertyName = null;
            this.fld_dgcRP127GridControls.Location = new System.Drawing.Point(3, 112);
            this.fld_dgcRP127GridControls.Name = "fld_dgcRP127GridControls";
            this.fld_dgcRP127GridControls.PrintReport = false;
            this.fld_dgcRP127GridControls.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcRP127GridControls, false);
            this.fld_dgcRP127GridControls.Size = new System.Drawing.Size(758, 378);
            this.fld_dgcRP127GridControls.TabIndex = 115;
            // 
            // bosLabel3
            // 
            this.bosLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(248, 74);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(282, 23);
            this.bosLabel3.TabIndex = 100;
            this.bosLabel3.Text = "BÁO CÁO TỒN KHO GỖ TRÒN";
            // 
            // RP127
            // 
            this.AcceptButton = this.fld_btnPrint;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(777, 493);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Controls.Add(this.fld_btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RP127";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÁO CÁO TỒN KHO GỖ TRÒN";
            this.Load += new System.EventHandler(this.RP126_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductAttributeID.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductSerieID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP127GridControls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnPrint;
        private BOSComponent.BOSButton fld_btnClose;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private RP126ICProductSeries fld_dgcRP126ICProductSeries;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeICProductAttributeID;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel3;
        private RP127GridControl fld_dgcRP127GridControls;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductSerieID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierID;
        private BOSComponent.BOSLabel BOSLabel4;
    }
}