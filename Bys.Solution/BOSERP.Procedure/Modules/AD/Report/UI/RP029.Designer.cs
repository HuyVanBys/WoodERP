namespace BOSERP.Modules.Report
{
    partial class RP029
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
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeBRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToAPInvoiceInDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromAPInvoiceInDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_dgcAPRP029APInvoiceIns = new BOSERP.Modules.Report.RP029InvoiceGridControl();
            this.fld_lblTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_lblSubTitleDate = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPInvoiceInDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPInvoiceInDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPInvoiceInDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPInvoiceInDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPRP029APInvoiceIns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.panelControl1.Controls.Add(this.bosLabel4);
            this.panelControl1.Controls.Add(this.fld_lkeBRBranchID);
            this.panelControl1.Controls.Add(this.bosLabel3);
            this.panelControl1.Controls.Add(this.fld_dteSearchToAPInvoiceInDate);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromAPInvoiceInDate);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Controls.Add(this.BOSLabel2);
            this.panelControl1.Controls.Add(this.BOSLabel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(902, 78);
            this.panelControl1.TabIndex = 1;
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(12, 12);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(48, 13);
            this.bosLabel4.TabIndex = 81;
            this.bosLabel4.Tag = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.Text = "Chi nhánh";
            // 
            // fld_lkeBRBranchID
            // 
            this.fld_lkeBRBranchID.BOSAllowAddNew = false;
            this.fld_lkeBRBranchID.BOSAllowDummy = true;
            this.fld_lkeBRBranchID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeBRBranchID.BOSDataMember = "BRBranchID";
            this.fld_lkeBRBranchID.BOSDataSource = "BRBranchs";
            this.fld_lkeBRBranchID.BOSDescription = null;
            this.fld_lkeBRBranchID.BOSError = null;
            this.fld_lkeBRBranchID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeBRBranchID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeBRBranchID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeBRBranchID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeBRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeBRBranchID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeBRBranchID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeBRBranchID.CurrentDisplayText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeBRBranchID.Location = new System.Drawing.Point(77, 9);
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
            this.fld_lkeBRBranchID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeBRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeBRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchID.Screen = null;
            this.fld_lkeBRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchID.TabIndex = 82;
            this.fld_lkeBRBranchID.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(253, 12);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(65, 13);
            this.bosLabel3.TabIndex = 80;
            this.bosLabel3.Tag = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.Text = "Nhà cung cấp";
            // 
            // fld_dteSearchToAPInvoiceInDate
            // 
            this.fld_dteSearchToAPInvoiceInDate.BOSComment = null;
            this.fld_dteSearchToAPInvoiceInDate.BOSDataMember = "APInvoiceInDate";
            this.fld_dteSearchToAPInvoiceInDate.BOSDataSource = "APInvoiceIns";
            this.fld_dteSearchToAPInvoiceInDate.BOSDescription = null;
            this.fld_dteSearchToAPInvoiceInDate.BOSError = null;
            this.fld_dteSearchToAPInvoiceInDate.BOSFieldGroup = null;
            this.fld_dteSearchToAPInvoiceInDate.BOSFieldRelation = null;
            this.fld_dteSearchToAPInvoiceInDate.BOSPrivilege = null;
            this.fld_dteSearchToAPInvoiceInDate.BOSPropertyName = null;
            this.fld_dteSearchToAPInvoiceInDate.EditValue = null;
            this.fld_dteSearchToAPInvoiceInDate.Location = new System.Drawing.Point(330, 35);
            this.fld_dteSearchToAPInvoiceInDate.Name = "fld_dteSearchToAPInvoiceInDate";
            this.fld_dteSearchToAPInvoiceInDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToAPInvoiceInDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToAPInvoiceInDate.Screen = null;
            this.fld_dteSearchToAPInvoiceInDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToAPInvoiceInDate.TabIndex = 3;
            this.fld_dteSearchToAPInvoiceInDate.Tag = "SC";
            // 
            // fld_dteSearchFromAPInvoiceInDate
            // 
            this.fld_dteSearchFromAPInvoiceInDate.BOSComment = null;
            this.fld_dteSearchFromAPInvoiceInDate.BOSDataMember = "APInvoiceInDate";
            this.fld_dteSearchFromAPInvoiceInDate.BOSDataSource = "APInvoiceIns";
            this.fld_dteSearchFromAPInvoiceInDate.BOSDescription = null;
            this.fld_dteSearchFromAPInvoiceInDate.BOSError = null;
            this.fld_dteSearchFromAPInvoiceInDate.BOSFieldGroup = null;
            this.fld_dteSearchFromAPInvoiceInDate.BOSFieldRelation = null;
            this.fld_dteSearchFromAPInvoiceInDate.BOSPrivilege = null;
            this.fld_dteSearchFromAPInvoiceInDate.BOSPropertyName = null;
            this.fld_dteSearchFromAPInvoiceInDate.EditValue = null;
            this.fld_dteSearchFromAPInvoiceInDate.Location = new System.Drawing.Point(77, 35);
            this.fld_dteSearchFromAPInvoiceInDate.Name = "fld_dteSearchFromAPInvoiceInDate";
            this.fld_dteSearchFromAPInvoiceInDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromAPInvoiceInDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromAPInvoiceInDate.Screen = null;
            this.fld_dteSearchFromAPInvoiceInDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromAPInvoiceInDate.TabIndex = 2;
            this.fld_dteSearchFromAPInvoiceInDate.Tag = "SC";
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
            this.fld_btnApply.Location = new System.Drawing.Point(686, 4);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(75, 27);
            this.fld_btnApply.TabIndex = 4;
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
            this.BOSLabel2.Location = new System.Drawing.Point(254, 38);
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
            this.fld_btnPrint.Location = new System.Drawing.Point(712, 537);
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
            this.fld_btnClose.Location = new System.Drawing.Point(803, 537);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 3;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_dgcAPRP029APInvoiceIns
            // 
            this.fld_dgcAPRP029APInvoiceIns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPRP029APInvoiceIns.BOSComment = null;
            this.fld_dgcAPRP029APInvoiceIns.BOSDataMember = null;
            this.fld_dgcAPRP029APInvoiceIns.BOSDataSource = "APInvoiceIns";
            this.fld_dgcAPRP029APInvoiceIns.BOSDescription = null;
            this.fld_dgcAPRP029APInvoiceIns.BOSError = null;
            this.fld_dgcAPRP029APInvoiceIns.BOSFieldGroup = null;
            this.fld_dgcAPRP029APInvoiceIns.BOSFieldRelation = null;
            this.fld_dgcAPRP029APInvoiceIns.BOSGridType = null;
            this.fld_dgcAPRP029APInvoiceIns.BOSPrivilege = null;
            this.fld_dgcAPRP029APInvoiceIns.BOSPropertyName = null;
            this.fld_dgcAPRP029APInvoiceIns.Location = new System.Drawing.Point(12, 152);
            this.fld_dgcAPRP029APInvoiceIns.MenuManager = this.screenToolbar;
            this.fld_dgcAPRP029APInvoiceIns.Name = "fld_dgcAPRP029APInvoiceIns";
            this.fld_dgcAPRP029APInvoiceIns.PrintReport = false;
            this.fld_dgcAPRP029APInvoiceIns.Screen = null;
            this.fld_dgcAPRP029APInvoiceIns.Size = new System.Drawing.Size(878, 368);
            this.fld_dgcAPRP029APInvoiceIns.TabIndex = 20;
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
            this.fld_lblTitle.Location = new System.Drawing.Point(311, 109);
            this.fld_lblTitle.Name = "fld_lblTitle";
            this.fld_lblTitle.Screen = null;
            this.fld_lblTitle.Size = new System.Drawing.Size(277, 19);
            this.fld_lblTitle.TabIndex = 19;
            this.fld_lblTitle.Text = "DANH SÁCH HÓA ĐƠN MUA HÀNG";
            // 
            // fld_lblSubTitleDate
            // 
            this.fld_lblSubTitleDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_lblSubTitleDate.Appearance.Options.UseFont = true;
            this.fld_lblSubTitleDate.BOSComment = null;
            this.fld_lblSubTitleDate.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblSubTitleDate.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblSubTitleDate.BOSDescription = null;
            this.fld_lblSubTitleDate.BOSError = null;
            this.fld_lblSubTitleDate.BOSFieldGroup = null;
            this.fld_lblSubTitleDate.BOSFieldRelation = null;
            this.fld_lblSubTitleDate.BOSPrivilege = null;
            this.fld_lblSubTitleDate.BOSPropertyName = null;
            this.fld_lblSubTitleDate.Location = new System.Drawing.Point(311, 134);
            this.fld_lblSubTitleDate.Name = "fld_lblSubTitleDate";
            this.fld_lblSubTitleDate.Screen = null;
            this.fld_lblSubTitleDate.Size = new System.Drawing.Size(28, 16);
            this.fld_lblSubTitleDate.TabIndex = 23;
            this.fld_lblSubTitleDate.Tag = "HD";
            this.fld_lblSubTitleDate.Text = "Text";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACAssObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "APInvoiceIns";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(330, 9);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.CommonLocalizedResources.String2, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 83;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            // 
            // RP029
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 576);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lblSubTitleDate);
            this.Controls.Add(this.fld_dgcAPRP029APInvoiceIns);
            this.Controls.Add(this.fld_btnPrint);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_lblTitle);
            this.Controls.Add(this.panelControl1);
            this.Name = "RP029";
            this.Text = "Danh sách hoá đơn mua hàng";
            this.Load += new System.EventHandler(this.RP029_Load);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_lblTitle, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_btnPrint, 0);
            this.Controls.SetChildIndex(this.fld_dgcAPRP029APInvoiceIns, 0);
            this.Controls.SetChildIndex(this.fld_lblSubTitleDate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPInvoiceInDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPInvoiceInDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPInvoiceInDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPInvoiceInDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPRP029APInvoiceIns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSDateEdit fld_dteSearchToAPInvoiceInDate;
        private BOSComponent.BOSDateEdit fld_dteSearchFromAPInvoiceInDate;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSButton fld_btnPrint;
        private BOSComponent.BOSButton fld_btnClose;
        private RP029InvoiceGridControl fld_dgcAPRP029APInvoiceIns;
        private BOSComponent.BOSLabel fld_lblTitle;
        private BOSComponent.BOSLabel fld_lblSubTitleDate;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchID;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
    }
}