namespace BOSERP.Modules.Report
{
    partial class RP112
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
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_lkeICProductGroupID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeACAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_APSupplierID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_cmbStocks = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcRP112ICInventoryStocks = new BOSERP.Modules.Report.RP112ICInventoryStocksGridControl();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbStocks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP112ICInventoryStocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
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
            this.fld_btnPrint.Location = new System.Drawing.Point(814, 15);
            this.fld_btnPrint.Name = "fld_btnPrint";
            this.fld_btnPrint.Screen = null;
            this.fld_btnPrint.Size = new System.Drawing.Size(75, 27);
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
            this.fld_btnClose.Location = new System.Drawing.Point(814, 588);
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
            this.bosLabel4.Location = new System.Drawing.Point(271, 15);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(54, 13);
            this.bosLabel4.TabIndex = 0;
            this.bosLabel4.Tag = "DC";
            this.bosLabel4.Text = "Nhóm hàng";
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
            this.bosLabel3.Location = new System.Drawing.Point(22, 67);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(47, 13);
            this.bosLabel3.TabIndex = 0;
            this.bosLabel3.Tag = "DC";
            this.bosLabel3.Text = "Sản phẩm";
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
            this.fld_lkeICProductID.Location = new System.Drawing.Point(97, 64);
            this.fld_lkeICProductID.MenuManager = this.screenToolbar;
            this.fld_lkeICProductID.Name = "fld_lkeICProductID";
            this.fld_lkeICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductID.Properties.DisplayMember = "ICProductDesc";
            this.fld_lkeICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductID.Screen = null;
            this.fld_lkeICProductID.Size = new System.Drawing.Size(406, 20);
            this.fld_lkeICProductID.TabIndex = 4;
            // 
            // fld_lkeICProductGroupID
            // 
            this.fld_lkeICProductGroupID.BOSAllowAddNew = false;
            this.fld_lkeICProductGroupID.BOSAllowDummy = true;
            this.fld_lkeICProductGroupID.BOSComment = null;
            this.fld_lkeICProductGroupID.BOSDataMember = "ICProductGroupID";
            this.fld_lkeICProductGroupID.BOSDataSource = "ICProductGroups";
            this.fld_lkeICProductGroupID.BOSDescription = null;
            this.fld_lkeICProductGroupID.BOSError = null;
            this.fld_lkeICProductGroupID.BOSFieldGroup = null;
            this.fld_lkeICProductGroupID.BOSFieldParent = null;
            this.fld_lkeICProductGroupID.BOSFieldRelation = null;
            this.fld_lkeICProductGroupID.BOSPrivilege = null;
            this.fld_lkeICProductGroupID.BOSPropertyName = null;
            this.fld_lkeICProductGroupID.BOSSelectType = null;
            this.fld_lkeICProductGroupID.BOSSelectTypeValue = null;
            this.fld_lkeICProductGroupID.CurrentDisplayText = null;
            this.fld_lkeICProductGroupID.Location = new System.Drawing.Point(351, 12);
            this.fld_lkeICProductGroupID.Name = "fld_lkeICProductGroupID";
            this.fld_lkeICProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductGroupID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductGroupName", "Nhóm hàng")});
            this.fld_lkeICProductGroupID.Properties.DisplayMember = "ICProductGroupName";
            this.fld_lkeICProductGroupID.Properties.ValueMember = "ICProductGroupID";
            this.fld_lkeICProductGroupID.Screen = null;
            this.fld_lkeICProductGroupID.Size = new System.Drawing.Size(151, 20);
            this.fld_lkeICProductGroupID.TabIndex = 3;
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
            this.bosLabel5.Location = new System.Drawing.Point(21, 15);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(58, 13);
            this.bosLabel5.TabIndex = 0;
            this.bosLabel5.Tag = "DC";
            this.bosLabel5.Text = "Ngành hàng";
            // 
            // fld_lkeICDepartmentID
            // 
            this.fld_lkeICDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeICDepartmentID.BOSAllowDummy = true;
            this.fld_lkeICDepartmentID.BOSComment = null;
            this.fld_lkeICDepartmentID.BOSDataMember = "ICDepartmentID";
            this.fld_lkeICDepartmentID.BOSDataSource = "ICDepartments";
            this.fld_lkeICDepartmentID.BOSDescription = null;
            this.fld_lkeICDepartmentID.BOSError = null;
            this.fld_lkeICDepartmentID.BOSFieldGroup = null;
            this.fld_lkeICDepartmentID.BOSFieldParent = null;
            this.fld_lkeICDepartmentID.BOSFieldRelation = null;
            this.fld_lkeICDepartmentID.BOSPrivilege = null;
            this.fld_lkeICDepartmentID.BOSPropertyName = null;
            this.fld_lkeICDepartmentID.BOSSelectType = null;
            this.fld_lkeICDepartmentID.BOSSelectTypeValue = null;
            this.fld_lkeICDepartmentID.CurrentDisplayText = null;
            this.fld_lkeICDepartmentID.Location = new System.Drawing.Point(96, 12);
            this.fld_lkeICDepartmentID.Name = "fld_lkeICDepartmentID";
            this.fld_lkeICDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICDepartmentName", "Ngành hàng")});
            this.fld_lkeICDepartmentID.Properties.DisplayMember = "ICDepartmentName";
            this.fld_lkeICDepartmentID.Properties.ValueMember = "ICDepartmentID";
            this.fld_lkeICDepartmentID.Screen = null;
            this.fld_lkeICDepartmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICDepartmentID.TabIndex = 2;
            // 
            // fld_lkeACAccountID
            // 
            this.fld_lkeACAccountID.BOSAllowAddNew = false;
            this.fld_lkeACAccountID.BOSAllowDummy = true;
            this.fld_lkeACAccountID.BOSComment = null;
            this.fld_lkeACAccountID.BOSDataMember = "FK_ACAccountID";
            this.fld_lkeACAccountID.BOSDataSource = "ICProducts";
            this.fld_lkeACAccountID.BOSDescription = null;
            this.fld_lkeACAccountID.BOSError = null;
            this.fld_lkeACAccountID.BOSFieldGroup = null;
            this.fld_lkeACAccountID.BOSFieldParent = null;
            this.fld_lkeACAccountID.BOSFieldRelation = null;
            this.fld_lkeACAccountID.BOSPrivilege = null;
            this.fld_lkeACAccountID.BOSPropertyName = null;
            this.fld_lkeACAccountID.BOSSelectType = null;
            this.fld_lkeACAccountID.BOSSelectTypeValue = null;
            this.fld_lkeACAccountID.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACAccountID.Location = new System.Drawing.Point(351, 38);
            this.fld_lkeACAccountID.Name = "fld_lkeACAccountID";
            this.fld_lkeACAccountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACAccountID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeACAccountID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeACAccountID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACAccountID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACAccountID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeACAccountID.Screen = null;
            this.fld_lkeACAccountID.Size = new System.Drawing.Size(152, 20);
            this.fld_lkeACAccountID.TabIndex = 8;
            this.fld_lkeACAccountID.Tag = global::Localization.ReportLocalizedResources.tutu;
            // 
            // bosLabel11
            // 
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(271, 41);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(46, 13);
            this.bosLabel11.TabIndex = 11;
            this.bosLabel11.Text = "Tài khoản";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(531, 15);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(65, 13);
            this.bosLabel6.TabIndex = 82;
            this.bosLabel6.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.Text = "Nhà cung cấp";
            // 
            // fld_lkeFK_APSupplierID
            // 
            this.fld_lkeFK_APSupplierID.BOSAllowAddNew = false;
            this.fld_lkeFK_APSupplierID.BOSAllowDummy = true;
            this.fld_lkeFK_APSupplierID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_APSupplierID.BOSDataMember = "APSupplierID";
            this.fld_lkeFK_APSupplierID.BOSDataSource = "APSuppliers";
            this.fld_lkeFK_APSupplierID.BOSDescription = null;
            this.fld_lkeFK_APSupplierID.BOSError = null;
            this.fld_lkeFK_APSupplierID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_APSupplierID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_APSupplierID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_APSupplierID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_APSupplierID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APSupplierID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_APSupplierID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_APSupplierID.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_APSupplierID.Location = new System.Drawing.Point(606, 12);
            this.fld_lkeFK_APSupplierID.Name = "fld_lkeFK_APSupplierID";
            this.fld_lkeFK_APSupplierID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_APSupplierID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_APSupplierID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_APSupplierID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_APSupplierID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APSupplierID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierNo", "Mã nhà cung cấp"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierName", "Tên nhà cung cấp")});
            this.fld_lkeFK_APSupplierID.Properties.DisplayMember = "APSupplierName";
            this.fld_lkeFK_APSupplierID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_APSupplierID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APSupplierID.Properties.ValueMember = "APSupplierID";
            this.fld_lkeFK_APSupplierID.Screen = null;
            this.fld_lkeFK_APSupplierID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_APSupplierID.TabIndex = 7;
            this.fld_lkeFK_APSupplierID.Tag = "DC";
            // 
            // fld_cmbStocks
            // 
            this.fld_cmbStocks.Location = new System.Drawing.Point(97, 38);
            this.fld_cmbStocks.MenuManager = this.screenToolbar;
            this.fld_cmbStocks.Name = "fld_cmbStocks";
            this.fld_cmbStocks.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cmbStocks.Properties.DisplayMember = "ICStockName";
            this.fld_cmbStocks.Properties.ValueMember = "ICStockID";
            this.fld_cmbStocks.Size = new System.Drawing.Size(151, 20);
            this.fld_cmbStocks.TabIndex = 6;
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel8.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel8.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel8.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel8.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(531, 41);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(48, 13);
            this.bosLabel8.TabIndex = 86;
            this.bosLabel8.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel8.Text = "Chi nhánh";
            // 
            // bosLabel7
            // 
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(21, 41);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(18, 13);
            this.bosLabel7.TabIndex = 85;
            this.bosLabel7.Text = "Kho";
            // 
            // fld_dgcRP112ICInventoryStocks
            // 
            this.fld_dgcRP112ICInventoryStocks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcRP112ICInventoryStocks.BOSComment = null;
            this.fld_dgcRP112ICInventoryStocks.BOSDataMember = null;
            this.fld_dgcRP112ICInventoryStocks.BOSDataSource = "ICInventoryStocks";
            this.fld_dgcRP112ICInventoryStocks.BOSDescription = null;
            this.fld_dgcRP112ICInventoryStocks.BOSError = null;
            this.fld_dgcRP112ICInventoryStocks.BOSFieldGroup = null;
            this.fld_dgcRP112ICInventoryStocks.BOSFieldRelation = null;
            this.fld_dgcRP112ICInventoryStocks.BOSGridType = null;
            this.fld_dgcRP112ICInventoryStocks.BOSPrivilege = null;
            this.fld_dgcRP112ICInventoryStocks.BOSPropertyName = null;
            this.fld_dgcRP112ICInventoryStocks.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.fld_dgcRP112ICInventoryStocks.EmbeddedNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fld_dgcRP112ICInventoryStocks.EmbeddedNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fld_dgcRP112ICInventoryStocks.EmbeddedNavigator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fld_dgcRP112ICInventoryStocks.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.None;
            this.fld_dgcRP112ICInventoryStocks.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this.fld_dgcRP112ICInventoryStocks.Location = new System.Drawing.Point(12, 90);
            this.fld_dgcRP112ICInventoryStocks.MenuManager = this.screenToolbar;
            this.fld_dgcRP112ICInventoryStocks.Name = "fld_dgcRP112ICInventoryStocks";
            this.fld_dgcRP112ICInventoryStocks.PrintReport = false;
            this.fld_dgcRP112ICInventoryStocks.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcRP112ICInventoryStocks, false);
            this.fld_dgcRP112ICInventoryStocks.Size = new System.Drawing.Size(877, 492);
            this.fld_dgcRP112ICInventoryStocks.TabIndex = 87;
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(531, 67);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(46, 13);
            this.bosLabel1.TabIndex = 86;
            this.bosLabel1.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.Text = "Loại hàng";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            global::Localization.ReportLocalizedResources.tutu,
            "Gỗ phách",
            "Gỗ tròn",
            "Vật tư",
            "Thành phẩm",
            "Bán thành phẩm"});
            this.comboBox1.Location = new System.Drawing.Point(606, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 89;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = true;
            this.bosLookupEdit1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLookupEdit1.BOSDataMember = "BRBranchID";
            this.bosLookupEdit1.BOSDataSource = "BRBranchs";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLookupEdit1.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.bosLookupEdit1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLookupEdit1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.bosLookupEdit1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.bosLookupEdit1.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.bosLookupEdit1.Location = new System.Drawing.Point(606, 38);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.bosLookupEdit1.Properties.DisplayMember = "BRBranchName";
            this.bosLookupEdit1.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Properties.ValueMember = "BRBranchID";
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit1.TabIndex = 90;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // RP112
            // 
            this.AcceptButton = this.fld_btnPrint;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(900, 622);
            this.ControlBox = true;
            this.Controls.Add(this.bosLookupEdit1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.fld_dgcRP112ICInventoryStocks);
            this.Controls.Add(this.fld_cmbStocks);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.bosLabel8);
            this.Controls.Add(this.bosLabel7);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.fld_lkeFK_APSupplierID);
            this.Controls.Add(this.fld_lkeACAccountID);
            this.Controls.Add(this.bosLabel11);
            this.Controls.Add(this.fld_lkeICDepartmentID);
            this.Controls.Add(this.fld_lkeICProductGroupID);
            this.Controls.Add(this.fld_lkeICProductID);
            this.Controls.Add(this.fld_btnPrint);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.bosLabel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RP112";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giá vốn tồn kho";
            this.Load += new System.EventHandler(this.RP112_Load);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_btnPrint, 0);
            this.Controls.SetChildIndex(this.fld_lkeICProductID, 0);
            this.Controls.SetChildIndex(this.fld_lkeICProductGroupID, 0);
            this.Controls.SetChildIndex(this.fld_lkeICDepartmentID, 0);
            this.Controls.SetChildIndex(this.bosLabel11, 0);
            this.Controls.SetChildIndex(this.fld_lkeACAccountID, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_APSupplierID, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            this.Controls.SetChildIndex(this.bosLabel7, 0);
            this.Controls.SetChildIndex(this.bosLabel8, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_cmbStocks, 0);
            this.Controls.SetChildIndex(this.fld_dgcRP112ICInventoryStocks, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.bosLookupEdit1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbStocks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP112ICInventoryStocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnPrint;
        private BOSComponent.BOSButton fld_btnClose;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private ItemLookupEdit fld_lkeICProductID;
        private BOSComponent.BOSLookupEdit fld_lkeICProductGroupID;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeICDepartmentID;
        private BOSComponent.BOSLookupEdit fld_lkeACAccountID;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierID;
        private DevExpress.XtraEditors.CheckedComboBoxEdit fld_cmbStocks;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel7;
        private RP112ICInventoryStocksGridControl fld_dgcRP112ICInventoryStocks;
        private BOSComponent.BOSLabel bosLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
    }
}