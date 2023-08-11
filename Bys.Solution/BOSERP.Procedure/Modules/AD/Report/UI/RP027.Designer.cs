namespace BOSERP.Modules.Report
{
    partial class RP027
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
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_APSupplierID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPPurchaseOrderTypeCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteSearchToAPPurchaseOrderDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromAPPurchaseOrderDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_dgcAPRP027APPurchaseOrders = new BOSComponent.BOSGridControl(this.components);
            this.fld_lblSubTitleDate = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeBRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseOrderTypeCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPPurchaseOrderDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPPurchaseOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPPurchaseOrderDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPPurchaseOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPRP027APPurchaseOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.bosLabel4);
            this.panelControl1.Controls.Add(this.fld_lkeBRBranchID);
            this.panelControl1.Controls.Add(this.bosLabel3);
            this.panelControl1.Controls.Add(this.fld_lkeFK_APSupplierID);
            this.panelControl1.Controls.Add(this.bosLabel8);
            this.panelControl1.Controls.Add(this.fld_lkeAPPurchaseOrderTypeCombo);
            this.panelControl1.Controls.Add(this.fld_dteSearchToAPPurchaseOrderDate);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromAPPurchaseOrderDate);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Controls.Add(this.BOSLabel2);
            this.panelControl1.Controls.Add(this.BOSLabel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1003, 62);
            this.panelControl1.TabIndex = 1;
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(266, 12);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(65, 13);
            this.bosLabel3.TabIndex = 80;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.Text = "Nhà cung cấp";
            // 
            // fld_lkeFK_APSupplierID
            // 
            this.fld_lkeFK_APSupplierID.BOSAllowAddNew = false;
            this.fld_lkeFK_APSupplierID.BOSAllowDummy = true;
            this.fld_lkeFK_APSupplierID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.BOSDataMember = "FK_APSupplierID";
            this.fld_lkeFK_APSupplierID.BOSDataSource = "APPurchaseOrders";
            this.fld_lkeFK_APSupplierID.BOSDescription = null;
            this.fld_lkeFK_APSupplierID.BOSError = null;
            this.fld_lkeFK_APSupplierID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APSupplierID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.Location = new System.Drawing.Point(337, 9);
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
            this.fld_lkeFK_APSupplierID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APSupplierID.Properties.ValueMember = "APSupplierID";
            this.fld_lkeFK_APSupplierID.Screen = null;
            this.fld_lkeFK_APSupplierID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_APSupplierID.TabIndex = 1;
            this.fld_lkeFK_APSupplierID.Tag = "DC";
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
            this.bosLabel8.Location = new System.Drawing.Point(519, 12);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(65, 13);
            this.bosLabel8.TabIndex = 74;
            this.bosLabel8.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.Text = "Loại hàng đặt";
            // 
            // fld_lkeAPPurchaseOrderTypeCombo
            // 
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSAllowAddNew = false;
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSAllowDummy = true;
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSDataMember = "APPurchaseOrderTypeCombo";
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSDataSource = "APPurchaseOrders";
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSDescription = null;
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSError = null;
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSPropertyName = "EditValue";
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeAPPurchaseOrderTypeCombo.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeAPPurchaseOrderTypeCombo.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeAPPurchaseOrderTypeCombo.Location = new System.Drawing.Point(592, 9);
            this.fld_lkeAPPurchaseOrderTypeCombo.Name = "fld_lkeAPPurchaseOrderTypeCombo";
            this.fld_lkeAPPurchaseOrderTypeCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPPurchaseOrderTypeCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPPurchaseOrderTypeCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPPurchaseOrderTypeCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPPurchaseOrderTypeCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPurchaseOrderTypeCombo.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeAPPurchaseOrderTypeCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPPurchaseOrderTypeCombo.Screen = null;
            this.fld_lkeAPPurchaseOrderTypeCombo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPPurchaseOrderTypeCombo.TabIndex = 2;
            this.fld_lkeAPPurchaseOrderTypeCombo.Tag = "DC";
            // 
            // fld_dteSearchToAPPurchaseOrderDate
            // 
            this.fld_dteSearchToAPPurchaseOrderDate.BOSComment = null;
            this.fld_dteSearchToAPPurchaseOrderDate.BOSDataMember = "APPurchaseOrderDate";
            this.fld_dteSearchToAPPurchaseOrderDate.BOSDataSource = "APPurchaseOrders";
            this.fld_dteSearchToAPPurchaseOrderDate.BOSDescription = null;
            this.fld_dteSearchToAPPurchaseOrderDate.BOSError = null;
            this.fld_dteSearchToAPPurchaseOrderDate.BOSFieldGroup = null;
            this.fld_dteSearchToAPPurchaseOrderDate.BOSFieldRelation = null;
            this.fld_dteSearchToAPPurchaseOrderDate.BOSPrivilege = null;
            this.fld_dteSearchToAPPurchaseOrderDate.BOSPropertyName = null;
            this.fld_dteSearchToAPPurchaseOrderDate.EditValue = null;
            this.fld_dteSearchToAPPurchaseOrderDate.Location = new System.Drawing.Point(339, 35);
            this.fld_dteSearchToAPPurchaseOrderDate.Name = "fld_dteSearchToAPPurchaseOrderDate";
            this.fld_dteSearchToAPPurchaseOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToAPPurchaseOrderDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToAPPurchaseOrderDate.Screen = null;
            this.fld_dteSearchToAPPurchaseOrderDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToAPPurchaseOrderDate.TabIndex = 4;
            this.fld_dteSearchToAPPurchaseOrderDate.Tag = "SC";
            // 
            // fld_dteSearchFromAPPurchaseOrderDate
            // 
            this.fld_dteSearchFromAPPurchaseOrderDate.BOSComment = null;
            this.fld_dteSearchFromAPPurchaseOrderDate.BOSDataMember = "APPurchaseOrderDate";
            this.fld_dteSearchFromAPPurchaseOrderDate.BOSDataSource = "APPurchaseOrders";
            this.fld_dteSearchFromAPPurchaseOrderDate.BOSDescription = null;
            this.fld_dteSearchFromAPPurchaseOrderDate.BOSError = null;
            this.fld_dteSearchFromAPPurchaseOrderDate.BOSFieldGroup = null;
            this.fld_dteSearchFromAPPurchaseOrderDate.BOSFieldRelation = null;
            this.fld_dteSearchFromAPPurchaseOrderDate.BOSPrivilege = null;
            this.fld_dteSearchFromAPPurchaseOrderDate.BOSPropertyName = null;
            this.fld_dteSearchFromAPPurchaseOrderDate.EditValue = null;
            this.fld_dteSearchFromAPPurchaseOrderDate.Location = new System.Drawing.Point(84, 35);
            this.fld_dteSearchFromAPPurchaseOrderDate.Name = "fld_dteSearchFromAPPurchaseOrderDate";
            this.fld_dteSearchFromAPPurchaseOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromAPPurchaseOrderDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromAPPurchaseOrderDate.Screen = null;
            this.fld_dteSearchFromAPPurchaseOrderDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromAPPurchaseOrderDate.TabIndex = 3;
            this.fld_dteSearchFromAPPurchaseOrderDate.Tag = "SC";
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
            this.fld_btnApply.Location = new System.Drawing.Point(786, 5);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(75, 27);
            this.fld_btnApply.TabIndex = 5;
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
            this.BOSLabel2.Location = new System.Drawing.Point(266, 38);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.BOSLabel2.Size = new System.Drawing.Size(20, 13);
            this.BOSLabel2.TabIndex = 0;
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
            this.BOSLabel1.Location = new System.Drawing.Point(13, 38);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(40, 13);
            this.BOSLabel1.TabIndex = 0;
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
            this.fld_lblTitle.Location = new System.Drawing.Point(339, 77);
            this.fld_lblTitle.Name = "fld_lblTitle";
            this.fld_lblTitle.Screen = null;
            this.fld_lblTitle.Size = new System.Drawing.Size(236, 19);
            this.fld_lblTitle.TabIndex = 8;
            this.fld_lblTitle.Text = "DANH SÁCH ĐƠN MUA HÀNG";
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
            this.fld_btnPrint.Location = new System.Drawing.Point(835, 557);
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
            this.fld_btnClose.Location = new System.Drawing.Point(916, 557);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 3;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_dgcAPRP027APPurchaseOrders
            // 
            this.fld_dgcAPRP027APPurchaseOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPRP027APPurchaseOrders.BOSComment = null;
            this.fld_dgcAPRP027APPurchaseOrders.BOSDataMember = null;
            this.fld_dgcAPRP027APPurchaseOrders.BOSDataSource = "APPurchaseOrders";
            this.fld_dgcAPRP027APPurchaseOrders.BOSDescription = null;
            this.fld_dgcAPRP027APPurchaseOrders.BOSError = null;
            this.fld_dgcAPRP027APPurchaseOrders.BOSFieldGroup = null;
            this.fld_dgcAPRP027APPurchaseOrders.BOSFieldRelation = null;
            this.fld_dgcAPRP027APPurchaseOrders.BOSGridType = null;
            this.fld_dgcAPRP027APPurchaseOrders.BOSPrivilege = null;
            this.fld_dgcAPRP027APPurchaseOrders.BOSPropertyName = null;
            this.fld_dgcAPRP027APPurchaseOrders.Location = new System.Drawing.Point(12, 129);
            this.fld_dgcAPRP027APPurchaseOrders.MenuManager = this.screenToolbar;
            this.fld_dgcAPRP027APPurchaseOrders.Name = "fld_dgcAPRP027APPurchaseOrders";
            this.fld_dgcAPRP027APPurchaseOrders.PrintReport = false;
            this.fld_dgcAPRP027APPurchaseOrders.Screen = null;
            this.fld_dgcAPRP027APPurchaseOrders.Size = new System.Drawing.Size(979, 421);
            this.fld_dgcAPRP027APPurchaseOrders.TabIndex = 16;
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
            this.fld_lblSubTitleDate.Location = new System.Drawing.Point(339, 102);
            this.fld_lblSubTitleDate.Name = "fld_lblSubTitleDate";
            this.fld_lblSubTitleDate.Screen = null;
            this.fld_lblSubTitleDate.Size = new System.Drawing.Size(28, 16);
            this.fld_lblSubTitleDate.TabIndex = 25;
            this.fld_lblSubTitleDate.Tag = "HD";
            this.fld_lblSubTitleDate.Text = "Text";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(13, 12);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(48, 13);
            this.bosLabel4.TabIndex = 81;
            this.bosLabel4.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.Text = "Chi nhánh";
            // 
            // fld_lkeBRBranchID
            // 
            this.fld_lkeBRBranchID.BOSAllowAddNew = false;
            this.fld_lkeBRBranchID.BOSAllowDummy = true;
            this.fld_lkeBRBranchID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeBRBranchID.BOSDataMember = "BRBranchID";
            this.fld_lkeBRBranchID.BOSDataSource = "BRBranchs";
            this.fld_lkeBRBranchID.BOSDescription = null;
            this.fld_lkeBRBranchID.BOSError = null;
            this.fld_lkeBRBranchID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeBRBranchID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeBRBranchID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeBRBranchID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeBRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeBRBranchID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeBRBranchID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeBRBranchID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeBRBranchID.Location = new System.Drawing.Point(84, 9);
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
            this.fld_lkeBRBranchID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeBRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeBRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchID.Screen = null;
            this.fld_lkeBRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchID.TabIndex = 82;
            this.fld_lkeBRBranchID.Tag = "DC";
            // 
            // RP027
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 596);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lblSubTitleDate);
            this.Controls.Add(this.fld_dgcAPRP027APPurchaseOrders);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnPrint);
            this.Controls.Add(this.fld_lblTitle);
            this.Name = "RP027";
            this.Text = "Danh sách đơn mua hàng";
            this.Load += new System.EventHandler(this.RP027_Load);
            this.Controls.SetChildIndex(this.fld_lblTitle, 0);
            this.Controls.SetChildIndex(this.fld_btnPrint, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_dgcAPRP027APPurchaseOrders, 0);
            this.Controls.SetChildIndex(this.fld_lblSubTitleDate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseOrderTypeCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPPurchaseOrderDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPPurchaseOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPPurchaseOrderDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPPurchaseOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPRP027APPurchaseOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeAPPurchaseOrderTypeCombo;
        private BOSComponent.BOSDateEdit fld_dteSearchToAPPurchaseOrderDate;
        private BOSComponent.BOSDateEdit fld_dteSearchFromAPPurchaseOrderDate;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel fld_lblTitle;
        private BOSComponent.BOSButton fld_btnPrint;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSGridControl fld_dgcAPRP027APPurchaseOrders;
        private BOSComponent.BOSLabel fld_lblSubTitleDate;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchID;
    }
}