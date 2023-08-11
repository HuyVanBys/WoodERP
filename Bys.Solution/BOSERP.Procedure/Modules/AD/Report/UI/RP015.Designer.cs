namespace BOSERP.Modules.Report
{
    partial class RP015
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP015));
            this.fld_lblTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_dgcAPRP015Suppliers = new BOSERP.Modules.Report.APRP015SuppliersGridControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeBRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_Lablel = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPSupplierTypeCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            this.fld_lblSubTitleDate = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPRP015Suppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPSupplierTypeCombo.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.fld_lblTitle.Location = new System.Drawing.Point(383, 60);
            this.fld_lblTitle.Name = "fld_lblTitle";
            this.fld_lblTitle.Screen = null;
            this.fld_lblTitle.Size = new System.Drawing.Size(230, 19);
            this.fld_lblTitle.TabIndex = 1;
            this.fld_lblTitle.Text = "DANH SÁCH NHÀ CUNG CẤP";
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
            this.fld_btnClose.Location = new System.Drawing.Point(976, 536);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 5;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_dgcAPRP015Suppliers
            // 
            this.fld_dgcAPRP015Suppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPRP015Suppliers.BOSComment = null;
            this.fld_dgcAPRP015Suppliers.BOSDataMember = null;
            this.fld_dgcAPRP015Suppliers.BOSDataSource = "APSuppliers";
            this.fld_dgcAPRP015Suppliers.BOSDescription = null;
            this.fld_dgcAPRP015Suppliers.BOSError = null;
            this.fld_dgcAPRP015Suppliers.BOSFieldGroup = null;
            this.fld_dgcAPRP015Suppliers.BOSFieldRelation = null;
            this.fld_dgcAPRP015Suppliers.BOSGridType = null;
            this.fld_dgcAPRP015Suppliers.BOSPrivilege = null;
            this.fld_dgcAPRP015Suppliers.BOSPropertyName = null;
            this.fld_dgcAPRP015Suppliers.Location = new System.Drawing.Point(12, 111);
            this.fld_dgcAPRP015Suppliers.MenuManager = this.screenToolbar;
            this.fld_dgcAPRP015Suppliers.Name = "fld_dgcAPRP015Suppliers";
            this.fld_dgcAPRP015Suppliers.PrintReport = false;
            this.fld_dgcAPRP015Suppliers.Screen = null;
            this.fld_dgcAPRP015Suppliers.Size = new System.Drawing.Size(1039, 407);
            this.fld_dgcAPRP015Suppliers.TabIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.bosLabel1);
            this.panelControl1.Controls.Add(this.fld_lkeBRBranchID);
            this.panelControl1.Controls.Add(this.fld_Lablel);
            this.panelControl1.Controls.Add(this.fld_lkeFK_ICProductID);
            this.panelControl1.Controls.Add(this.bosLabel8);
            this.panelControl1.Controls.Add(this.fld_lkeAPSupplierTypeCombo);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1063, 45);
            this.panelControl1.TabIndex = 0;
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(13, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 5;
            this.bosLabel1.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.Text = "Chi nhánh";
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
            this.fld_lkeBRBranchID.Location = new System.Drawing.Point(78, 9);
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
            this.fld_lkeBRBranchID.Size = new System.Drawing.Size(185, 20);
            this.fld_lkeBRBranchID.TabIndex = 6;
            this.fld_lkeBRBranchID.Tag = "DC";
            // 
            // fld_Lablel
            // 
            this.fld_Lablel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel.Appearance.Options.UseBackColor = true;
            this.fld_Lablel.Appearance.Options.UseForeColor = true;
            this.fld_Lablel.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_Lablel.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_Lablel.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_Lablel.BOSDescription = null;
            this.fld_Lablel.BOSError = null;
            this.fld_Lablel.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_Lablel.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_Lablel.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_Lablel.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_Lablel.Location = new System.Drawing.Point(842, 12);
            this.fld_Lablel.Name = "fld_Lablel";
            this.fld_Lablel.Screen = null;
            this.fld_Lablel.Size = new System.Drawing.Size(47, 13);
            this.fld_Lablel.TabIndex = 2;
            this.fld_Lablel.Tag = global::Localization.CommonLocalizedResources.String1;
            this.fld_Lablel.Text = "Sản phẩm";
            this.fld_Lablel.Visible = false;
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductID.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "APInvoiceInItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSFieldParent = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.CurrentDisplayText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(906, 9);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mô tả", "Desc.")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.Properties.PopupWidth = 60;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(152, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 3;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.Visible = false;
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
            this.bosLabel8.Location = new System.Drawing.Point(322, 12);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(86, 13);
            this.bosLabel8.TabIndex = 0;
            this.bosLabel8.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel8.Text = "Loại nhà cung cấp";
            // 
            // fld_lkeAPSupplierTypeCombo
            // 
            this.fld_lkeAPSupplierTypeCombo.BOSAllowAddNew = false;
            this.fld_lkeAPSupplierTypeCombo.BOSAllowDummy = true;
            this.fld_lkeAPSupplierTypeCombo.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeAPSupplierTypeCombo.BOSDataMember = "APSupplierTypeCombo";
            this.fld_lkeAPSupplierTypeCombo.BOSDataSource = "APSuppliers";
            this.fld_lkeAPSupplierTypeCombo.BOSDescription = null;
            this.fld_lkeAPSupplierTypeCombo.BOSError = null;
            this.fld_lkeAPSupplierTypeCombo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeAPSupplierTypeCombo.BOSFieldParent = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeAPSupplierTypeCombo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeAPSupplierTypeCombo.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeAPSupplierTypeCombo.BOSPropertyName = "EditValue";
            this.fld_lkeAPSupplierTypeCombo.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeAPSupplierTypeCombo.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeAPSupplierTypeCombo.CurrentDisplayText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeAPSupplierTypeCombo.Location = new System.Drawing.Point(424, 9);
            this.fld_lkeAPSupplierTypeCombo.Name = "fld_lkeAPSupplierTypeCombo";
            this.fld_lkeAPSupplierTypeCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPSupplierTypeCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPSupplierTypeCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPSupplierTypeCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPSupplierTypeCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPSupplierTypeCombo.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeAPSupplierTypeCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPSupplierTypeCombo.Screen = null;
            this.fld_lkeAPSupplierTypeCombo.Size = new System.Drawing.Size(199, 20);
            this.fld_lkeAPSupplierTypeCombo.TabIndex = 1;
            this.fld_lkeAPSupplierTypeCombo.Tag = "DC";
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
            this.fld_btnApply.Location = new System.Drawing.Point(667, 5);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(75, 27);
            this.fld_btnApply.TabIndex = 4;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
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
            this.fld_btnPrint.Location = new System.Drawing.Point(895, 536);
            this.fld_btnPrint.Name = "fld_btnPrint";
            this.fld_btnPrint.Screen = null;
            this.fld_btnPrint.Size = new System.Drawing.Size(75, 27);
            this.fld_btnPrint.TabIndex = 4;
            this.fld_btnPrint.Text = "In";
            this.fld_btnPrint.Click += new System.EventHandler(this.fld_btnPrint_Click);
            // 
            // fld_lblSubTitleDate
            // 
            this.fld_lblSubTitleDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_lblSubTitleDate.Appearance.Options.UseFont = true;
            this.fld_lblSubTitleDate.BOSComment = null;
            this.fld_lblSubTitleDate.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblSubTitleDate.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblSubTitleDate.BOSDescription = null;
            this.fld_lblSubTitleDate.BOSError = null;
            this.fld_lblSubTitleDate.BOSFieldGroup = null;
            this.fld_lblSubTitleDate.BOSFieldRelation = null;
            this.fld_lblSubTitleDate.BOSPrivilege = null;
            this.fld_lblSubTitleDate.BOSPropertyName = null;
            this.fld_lblSubTitleDate.Location = new System.Drawing.Point(420, 86);
            this.fld_lblSubTitleDate.Name = "fld_lblSubTitleDate";
            this.fld_lblSubTitleDate.Screen = null;
            this.fld_lblSubTitleDate.Size = new System.Drawing.Size(28, 16);
            this.fld_lblSubTitleDate.TabIndex = 2;
            this.fld_lblSubTitleDate.Tag = "HD";
            this.fld_lblSubTitleDate.Text = "Text";
            // 
            // RP015
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 575);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lblSubTitleDate);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.fld_dgcAPRP015Suppliers);
            this.Controls.Add(this.fld_lblTitle);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnPrint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RP015";
            this.Tag = "SS";
            this.Text = "Danh sách nhà cung cấp";
            this.Load += new System.EventHandler(this.RP015_Load);
            this.Controls.SetChildIndex(this.fld_btnPrint, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_lblTitle, 0);
            this.Controls.SetChildIndex(this.fld_dgcAPRP015Suppliers, 0);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_lblSubTitleDate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPRP015Suppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPSupplierTypeCombo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSLabel fld_lblTitle;
        private BOSComponent.BOSButton fld_btnClose;
        private APRP015SuppliersGridControl fld_dgcAPRP015Suppliers;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeAPSupplierTypeCombo;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSButton fld_btnPrint;
        private BOSComponent.BOSLabel fld_lblSubTitleDate;
        private BOSComponent.BOSLabel fld_Lablel;
        private ItemLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchID;

    }
}