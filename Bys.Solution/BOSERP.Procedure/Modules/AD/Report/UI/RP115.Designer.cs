namespace BOSERP.Modules.Report
{
    partial class RP115
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
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_lkeACAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_cmbStocks = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcRP115ICInventoryStocks = new BOSERP.Modules.Report.RP115ICInventoryStocksGridControl();
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_cmbViewType = new BOSComponent.BOSComboBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbStocks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP115ICInventoryStocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbViewType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // fld_btnPrint
            // 
            this.fld_btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.fld_lkeICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeICProductID.BOSSelectType = "ICProductType";
            this.fld_lkeICProductID.BOSSelectTypeValue = "SemiProduct;Product";
            this.fld_lkeICProductID.CurrentDisplayText = null;
            this.fld_lkeICProductID.Location = new System.Drawing.Point(96, 38);
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
            this.fld_lkeACAccountID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACAccountID.Location = new System.Drawing.Point(350, 12);
            this.fld_lkeACAccountID.Name = "fld_lkeACAccountID";
            this.fld_lkeACAccountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACAccountID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeACAccountID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeACAccountID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACAccountID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACAccountID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeACAccountID.Screen = null;
            this.fld_lkeACAccountID.Size = new System.Drawing.Size(152, 20);
            this.fld_lkeACAccountID.TabIndex = 8;
            this.fld_lkeACAccountID.Tag = global::Localization.ReportLocalizedResources.String1;
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
            this.bosLabel11.Location = new System.Drawing.Point(270, 15);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(46, 13);
            this.bosLabel11.TabIndex = 11;
            this.bosLabel11.Text = "Tài khoản";
            // 
            // fld_cmbStocks
            // 
            this.fld_cmbStocks.Location = new System.Drawing.Point(96, 12);
            this.fld_cmbStocks.MenuManager = this.screenToolbar;
            this.fld_cmbStocks.Name = "fld_cmbStocks";
            this.fld_cmbStocks.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cmbStocks.Properties.DisplayMember = "ICStockName";
            this.fld_cmbStocks.Properties.ValueMember = "ICStockID";
            this.fld_cmbStocks.Size = new System.Drawing.Size(149, 20);
            this.fld_cmbStocks.TabIndex = 6;
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(530, 15);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(48, 13);
            this.bosLabel8.TabIndex = 86;
            this.bosLabel8.Tag = global::Localization.ReportLocalizedResources.String1;
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
            this.bosLabel7.Location = new System.Drawing.Point(20, 15);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(18, 13);
            this.bosLabel7.TabIndex = 85;
            this.bosLabel7.Text = "Kho";
            // 
            // fld_dgcRP115ICInventoryStocks
            // 
            this.fld_dgcRP115ICInventoryStocks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcRP115ICInventoryStocks.BOSComment = null;
            this.fld_dgcRP115ICInventoryStocks.BOSDataMember = null;
            this.fld_dgcRP115ICInventoryStocks.BOSDataSource = "ICInventoryStocks";
            this.fld_dgcRP115ICInventoryStocks.BOSDescription = null;
            this.fld_dgcRP115ICInventoryStocks.BOSError = null;
            this.fld_dgcRP115ICInventoryStocks.BOSFieldGroup = null;
            this.fld_dgcRP115ICInventoryStocks.BOSFieldRelation = null;
            this.fld_dgcRP115ICInventoryStocks.BOSGridType = null;
            this.fld_dgcRP115ICInventoryStocks.BOSPrivilege = null;
            this.fld_dgcRP115ICInventoryStocks.BOSPropertyName = null;
            this.fld_dgcRP115ICInventoryStocks.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.fld_dgcRP115ICInventoryStocks.EmbeddedNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fld_dgcRP115ICInventoryStocks.EmbeddedNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fld_dgcRP115ICInventoryStocks.EmbeddedNavigator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fld_dgcRP115ICInventoryStocks.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.None;
            this.fld_dgcRP115ICInventoryStocks.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this.fld_dgcRP115ICInventoryStocks.Location = new System.Drawing.Point(12, 90);
            this.fld_dgcRP115ICInventoryStocks.MenuManager = this.screenToolbar;
            this.fld_dgcRP115ICInventoryStocks.Name = "fld_dgcRP115ICInventoryStocks";
            this.fld_dgcRP115ICInventoryStocks.PrintReport = false;
            this.fld_dgcRP115ICInventoryStocks.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcRP115ICInventoryStocks, false);
            this.fld_dgcRP115ICInventoryStocks.Size = new System.Drawing.Size(877, 492);
            this.fld_dgcRP115ICInventoryStocks.TabIndex = 87;
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
            this.bosLookupEdit1.Location = new System.Drawing.Point(605, 12);
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
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(530, 41);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(68, 13);
            this.bosLabel2.TabIndex = 92;
            this.bosLabel2.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.Text = "Lệnh sản xuất";
            // 
            // fld_lkeFK_MMBatchProductID
            // 
            this.fld_lkeFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductID.BOSAllowDummy = true;
            this.fld_lkeFK_MMBatchProductID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_MMBatchProductID.BOSDataMember = "MMBatchProducctID";
            this.fld_lkeFK_MMBatchProductID.BOSDataSource = "MMBatchProducts";
            this.fld_lkeFK_MMBatchProductID.BOSDescription = null;
            this.fld_lkeFK_MMBatchProductID.BOSError = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_MMBatchProductID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_MMBatchProductID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_MMBatchProductID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_MMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMBatchProductID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_MMBatchProductID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_MMBatchProductID.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_MMBatchProductID.Location = new System.Drawing.Point(605, 38);
            this.fld_lkeFK_MMBatchProductID.Name = "fld_lkeFK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã Lệnh SX")});
            this.fld_lkeFK_MMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeFK_MMBatchProductID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_MMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Screen = null;
            this.fld_lkeFK_MMBatchProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMBatchProductID.TabIndex = 91;
            this.fld_lkeFK_MMBatchProductID.Tag = "DC";
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
            this.fld_cmbViewType.Location = new System.Drawing.Point(605, 64);
            this.fld_cmbViewType.MenuManager = this.screenToolbar;
            this.fld_cmbViewType.Name = "fld_cmbViewType";
            this.fld_cmbViewType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cmbViewType.Properties.Items.AddRange(new object[] {
            "Tất cả",
            "Có tồn"});
            this.fld_cmbViewType.Screen = null;
            this.fld_cmbViewType.Size = new System.Drawing.Size(150, 20);
            this.fld_cmbViewType.TabIndex = 98;
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
            this.bosLabel1.Location = new System.Drawing.Point(530, 67);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(45, 13);
            this.bosLabel1.TabIndex = 94;
            this.bosLabel1.Tag = "DC";
            this.bosLabel1.Text = "Xem theo";
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
            this.bosLabel10.Location = new System.Drawing.Point(20, 67);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(40, 13);
            this.bosLabel10.TabIndex = 95;
            this.bosLabel10.Text = "Từ ngày";
            // 
            // fld_dteSearchToDate
            // 
            this.fld_dteSearchToDate.BOSComment = null;
            this.fld_dteSearchToDate.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToDate.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToDate.BOSDescription = null;
            this.fld_dteSearchToDate.BOSError = null;
            this.fld_dteSearchToDate.BOSFieldGroup = null;
            this.fld_dteSearchToDate.BOSFieldRelation = null;
            this.fld_dteSearchToDate.BOSPrivilege = null;
            this.fld_dteSearchToDate.BOSPropertyName = null;
            this.fld_dteSearchToDate.EditValue = null;
            this.fld_dteSearchToDate.Location = new System.Drawing.Point(350, 64);
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Screen = null;
            this.fld_dteSearchToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToDate.TabIndex = 96;
            this.fld_dteSearchToDate.Tag = "DC";
            // 
            // fld_dteSearchFromDate
            // 
            this.fld_dteSearchFromDate.BOSComment = null;
            this.fld_dteSearchFromDate.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromDate.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromDate.BOSDescription = null;
            this.fld_dteSearchFromDate.BOSError = null;
            this.fld_dteSearchFromDate.BOSFieldGroup = null;
            this.fld_dteSearchFromDate.BOSFieldRelation = null;
            this.fld_dteSearchFromDate.BOSPrivilege = null;
            this.fld_dteSearchFromDate.BOSPropertyName = null;
            this.fld_dteSearchFromDate.EditValue = null;
            this.fld_dteSearchFromDate.Location = new System.Drawing.Point(95, 64);
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Screen = null;
            this.fld_dteSearchFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromDate.TabIndex = 93;
            this.fld_dteSearchFromDate.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(270, 67);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(47, 13);
            this.bosLabel9.TabIndex = 97;
            this.bosLabel9.Text = "Đến ngày";
            // 
            // RP115
            // 
            this.AcceptButton = this.fld_btnPrint;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(900, 622);
            this.ControlBox = true;
            this.Controls.Add(this.fld_cmbViewType);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.bosLabel10);
            this.Controls.Add(this.fld_dteSearchToDate);
            this.Controls.Add(this.fld_dteSearchFromDate);
            this.Controls.Add(this.bosLabel9);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeFK_MMBatchProductID);
            this.Controls.Add(this.bosLookupEdit1);
            this.Controls.Add(this.fld_dgcRP115ICInventoryStocks);
            this.Controls.Add(this.fld_cmbStocks);
            this.Controls.Add(this.bosLabel8);
            this.Controls.Add(this.bosLabel7);
            this.Controls.Add(this.fld_lkeACAccountID);
            this.Controls.Add(this.bosLabel11);
            this.Controls.Add(this.fld_lkeICProductID);
            this.Controls.Add(this.fld_btnPrint);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.bosLabel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RP115";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giá vốn tồn kho";
            this.Load += new System.EventHandler(this.RP115_Load);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_btnPrint, 0);
            this.Controls.SetChildIndex(this.fld_lkeICProductID, 0);
            this.Controls.SetChildIndex(this.bosLabel11, 0);
            this.Controls.SetChildIndex(this.fld_lkeACAccountID, 0);
            this.Controls.SetChildIndex(this.bosLabel7, 0);
            this.Controls.SetChildIndex(this.bosLabel8, 0);
            this.Controls.SetChildIndex(this.fld_cmbStocks, 0);
            this.Controls.SetChildIndex(this.fld_dgcRP115ICInventoryStocks, 0);
            this.Controls.SetChildIndex(this.bosLookupEdit1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_MMBatchProductID, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel9, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToDate, 0);
            this.Controls.SetChildIndex(this.bosLabel10, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_cmbViewType, 0);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbStocks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP115ICInventoryStocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbViewType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnPrint;
        private BOSComponent.BOSButton fld_btnClose;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private BOSComponent.BOSLabel bosLabel3;
        private ItemLookupEdit fld_lkeICProductID;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private BOSComponent.BOSLookupEdit fld_lkeACAccountID;
        private BOSComponent.BOSLabel bosLabel11;
        private DevExpress.XtraEditors.CheckedComboBoxEdit fld_cmbStocks;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel7;
        private RP115ICInventoryStocksGridControl fld_dgcRP115ICInventoryStocks;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductID;
        private BOSComponent.BOSComboBox fld_cmbViewType;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private BOSComponent.BOSLabel bosLabel9;
    }
}