namespace BOSERP.Modules.Report
{
    partial class RP040
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
            this.fld_lkeICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_lkeBRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteSearchToAPInvoiceInDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_bedProductGroup = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_dteSearchFromAPInvoiceInDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPInvoiceInStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeICDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_dgcAPRP040APInvoiceInItems = new BOSERP.Modules.Report.APRP040InvoiceInItemsGridControl();
            this.fld_lblTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_lblSubTitleDate = new BOSComponent.BOSLabel(this.components);
            this.fld_btnExportExcel = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPInvoiceInDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPInvoiceInDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedProductGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPInvoiceInDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPInvoiceInDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInvoiceInStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPRP040APInvoiceInItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.panelControl1.Controls.Add(this.fld_lkeICProductID);
            this.panelControl1.Controls.Add(this.fld_lkeBRBranchID);
            this.panelControl1.Controls.Add(this.fld_dteSearchToAPInvoiceInDate);
            this.panelControl1.Controls.Add(this.fld_bedProductGroup);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromAPInvoiceInDate);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Controls.Add(this.bosLabel5);
            this.panelControl1.Controls.Add(this.BOSLabel2);
            this.panelControl1.Controls.Add(this.bosLabel4);
            this.panelControl1.Controls.Add(this.bosLabel8);
            this.panelControl1.Controls.Add(this.BOSLabel1);
            this.panelControl1.Controls.Add(this.bosLabel6);
            this.panelControl1.Controls.Add(this.bosLabel7);
            this.panelControl1.Controls.Add(this.bosLabel3);
            this.panelControl1.Controls.Add(this.fld_lkeAPInvoiceInStatus);
            this.panelControl1.Controls.Add(this.fld_lkeICDepartmentID);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(902, 101);
            this.panelControl1.TabIndex = 1;
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
            this.fld_lkeICProductID.BOSSelectType = null;
            this.fld_lkeICProductID.BOSSelectTypeValue = null;
            this.fld_lkeICProductID.CurrentDisplayText = null;
            this.fld_lkeICProductID.Location = new System.Drawing.Point(90, 67);
            this.fld_lkeICProductID.MenuManager = this.screenToolbar;
            this.fld_lkeICProductID.Name = "fld_lkeICProductID";
            this.fld_lkeICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductID.Properties.DisplayMember = "ICProductDesc";
            this.fld_lkeICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductID.Screen = null;
            this.fld_lkeICProductID.Size = new System.Drawing.Size(423, 20);
            this.fld_lkeICProductID.TabIndex = 7;
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
            this.fld_lkeBRBranchID.Location = new System.Drawing.Point(90, 15);
            this.fld_lkeBRBranchID.Name = "fld_lkeBRBranchID";
            this.fld_lkeBRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeBRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeBRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeBRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeBRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeBRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBRBranchID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeBRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeBRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchID.Screen = null;
            this.fld_lkeBRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchID.TabIndex = 1;
            this.fld_lkeBRBranchID.Tag = global::Localization.CommonLocalizedResources.String2;
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
            this.fld_dteSearchToAPInvoiceInDate.Location = new System.Drawing.Point(604, 15);
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
            // fld_bedProductGroup
            // 
            this.fld_bedProductGroup.BOSComment = null;
            this.fld_bedProductGroup.BOSDataMember = null;
            this.fld_bedProductGroup.BOSDataSource = null;
            this.fld_bedProductGroup.BOSDescription = null;
            this.fld_bedProductGroup.BOSError = null;
            this.fld_bedProductGroup.BOSFieldGroup = null;
            this.fld_bedProductGroup.BOSFieldRelation = null;
            this.fld_bedProductGroup.BOSPrivilege = null;
            this.fld_bedProductGroup.BOSPropertyName = null;
            this.fld_bedProductGroup.Location = new System.Drawing.Point(363, 41);
            this.fld_bedProductGroup.MenuManager = this.screenToolbar;
            this.fld_bedProductGroup.Name = "fld_bedProductGroup";
            this.fld_bedProductGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedProductGroup.Properties.ReadOnly = true;
            this.fld_bedProductGroup.Screen = null;
            this.fld_bedProductGroup.Size = new System.Drawing.Size(150, 20);
            this.fld_bedProductGroup.TabIndex = 5;
            this.fld_bedProductGroup.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedProductGroup_ButtonClick);
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
            this.fld_dteSearchFromAPInvoiceInDate.Location = new System.Drawing.Point(363, 15);
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
            this.fld_btnApply.Location = new System.Drawing.Point(784, 12);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(75, 27);
            this.fld_btnApply.TabIndex = 9;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(262, 44);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(54, 13);
            this.bosLabel5.TabIndex = 80;
            this.bosLabel5.Tag = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.Text = "Nhóm hàng";
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
            this.BOSLabel2.Location = new System.Drawing.Point(535, 18);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.BOSLabel2.Size = new System.Drawing.Size(20, 13);
            this.BOSLabel2.TabIndex = 0;
            this.BOSLabel2.Text = "Đến";
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
            this.bosLabel4.Location = new System.Drawing.Point(12, 44);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(58, 13);
            this.bosLabel4.TabIndex = 80;
            this.bosLabel4.Tag = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.Text = "Ngành hàng";
            // 
            // bosLabel8
            // 
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(12, 18);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(48, 13);
            this.bosLabel8.TabIndex = 0;
            this.bosLabel8.Text = "Chi nhánh";
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
            this.BOSLabel1.Location = new System.Drawing.Point(262, 18);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(81, 13);
            this.BOSLabel1.TabIndex = 0;
            this.BOSLabel1.Text = "Ngày hóa đơn từ";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(535, 70);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(49, 13);
            this.bosLabel6.TabIndex = 80;
            this.bosLabel6.Tag = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.Text = "Tình trạng";
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
            this.bosLabel7.Location = new System.Drawing.Point(12, 70);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(47, 13);
            this.bosLabel7.TabIndex = 0;
            this.bosLabel7.Text = "Sản phẩm";
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
            this.bosLabel3.Location = new System.Drawing.Point(535, 44);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(21, 13);
            this.bosLabel3.TabIndex = 80;
            this.bosLabel3.Tag = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.Text = "NCC";
            // 
            // fld_lkeAPInvoiceInStatus
            // 
            this.fld_lkeAPInvoiceInStatus.BOSAllowAddNew = false;
            this.fld_lkeAPInvoiceInStatus.BOSAllowDummy = true;
            this.fld_lkeAPInvoiceInStatus.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPInvoiceInStatus.BOSDataMember = "APInvoiceInStatus";
            this.fld_lkeAPInvoiceInStatus.BOSDataSource = "APInvoiceIns";
            this.fld_lkeAPInvoiceInStatus.BOSDescription = null;
            this.fld_lkeAPInvoiceInStatus.BOSError = null;
            this.fld_lkeAPInvoiceInStatus.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPInvoiceInStatus.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPInvoiceInStatus.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPInvoiceInStatus.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPInvoiceInStatus.BOSPropertyName = "EditValue";
            this.fld_lkeAPInvoiceInStatus.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPInvoiceInStatus.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPInvoiceInStatus.CurrentDisplayText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPInvoiceInStatus.Location = new System.Drawing.Point(604, 67);
            this.fld_lkeAPInvoiceInStatus.Name = "fld_lkeAPInvoiceInStatus";
            this.fld_lkeAPInvoiceInStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPInvoiceInStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPInvoiceInStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPInvoiceInStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPInvoiceInStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPInvoiceInStatus.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPInvoiceInStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPInvoiceInStatus.Screen = null;
            this.fld_lkeAPInvoiceInStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPInvoiceInStatus.TabIndex = 8;
            this.fld_lkeAPInvoiceInStatus.Tag = global::Localization.CommonLocalizedResources.String2;
            // 
            // fld_lkeICDepartmentID
            // 
            this.fld_lkeICDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeICDepartmentID.BOSAllowDummy = true;
            this.fld_lkeICDepartmentID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeICDepartmentID.BOSDataMember = "ICDepartmentID";
            this.fld_lkeICDepartmentID.BOSDataSource = "ICDepartments";
            this.fld_lkeICDepartmentID.BOSDescription = null;
            this.fld_lkeICDepartmentID.BOSError = null;
            this.fld_lkeICDepartmentID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeICDepartmentID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeICDepartmentID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeICDepartmentID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeICDepartmentID.BOSPropertyName = "EditValue";
            this.fld_lkeICDepartmentID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeICDepartmentID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeICDepartmentID.CurrentDisplayText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeICDepartmentID.Location = new System.Drawing.Point(90, 41);
            this.fld_lkeICDepartmentID.Name = "fld_lkeICDepartmentID";
            this.fld_lkeICDepartmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICDepartmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICDepartmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICDepartmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICDepartmentName", "Ngành hàng")});
            this.fld_lkeICDepartmentID.Properties.DisplayMember = "ICDepartmentName";
            this.fld_lkeICDepartmentID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeICDepartmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICDepartmentID.Properties.ValueMember = "ICDepartmentID";
            this.fld_lkeICDepartmentID.Screen = null;
            this.fld_lkeICDepartmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICDepartmentID.TabIndex = 4;
            this.fld_lkeICDepartmentID.Tag = global::Localization.CommonLocalizedResources.String2;
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
            this.fld_btnPrint.Location = new System.Drawing.Point(620, 537);
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
            // fld_dgcAPRP040APInvoiceInItems
            // 
            this.fld_dgcAPRP040APInvoiceInItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPRP040APInvoiceInItems.BOSComment = null;
            this.fld_dgcAPRP040APInvoiceInItems.BOSDataMember = null;
            this.fld_dgcAPRP040APInvoiceInItems.BOSDataSource = "APInvoiceInItems";
            this.fld_dgcAPRP040APInvoiceInItems.BOSDescription = null;
            this.fld_dgcAPRP040APInvoiceInItems.BOSError = null;
            this.fld_dgcAPRP040APInvoiceInItems.BOSFieldGroup = null;
            this.fld_dgcAPRP040APInvoiceInItems.BOSFieldRelation = null;
            this.fld_dgcAPRP040APInvoiceInItems.BOSGridType = null;
            this.fld_dgcAPRP040APInvoiceInItems.BOSPrivilege = null;
            this.fld_dgcAPRP040APInvoiceInItems.BOSPropertyName = null;
            this.fld_dgcAPRP040APInvoiceInItems.Location = new System.Drawing.Point(12, 164);
            this.fld_dgcAPRP040APInvoiceInItems.MenuManager = this.screenToolbar;
            this.fld_dgcAPRP040APInvoiceInItems.Name = "fld_dgcAPRP040APInvoiceInItems";
            this.fld_dgcAPRP040APInvoiceInItems.PrintReport = false;
            this.fld_dgcAPRP040APInvoiceInItems.Screen = null;
            this.fld_dgcAPRP040APInvoiceInItems.Size = new System.Drawing.Size(878, 356);
            this.fld_dgcAPRP040APInvoiceInItems.TabIndex = 20;
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
            this.fld_lblTitle.Location = new System.Drawing.Point(303, 113);
            this.fld_lblTitle.Name = "fld_lblTitle";
            this.fld_lblTitle.Screen = null;
            this.fld_lblTitle.Size = new System.Drawing.Size(284, 19);
            this.fld_lblTitle.TabIndex = 19;
            this.fld_lblTitle.Text = "DANH SÁCH HÀNG THEO HÓA ĐƠN";
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
            this.fld_lblSubTitleDate.Location = new System.Drawing.Point(303, 138);
            this.fld_lblSubTitleDate.Name = "fld_lblSubTitleDate";
            this.fld_lblSubTitleDate.Screen = null;
            this.fld_lblSubTitleDate.Size = new System.Drawing.Size(28, 16);
            this.fld_lblSubTitleDate.TabIndex = 23;
            this.fld_lblSubTitleDate.Tag = "HD";
            this.fld_lblSubTitleDate.Text = "Text";
            // 
            // fld_btnExportExcel
            // 
            this.fld_btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnExportExcel.BOSComment = null;
            this.fld_btnExportExcel.BOSDataMember = null;
            this.fld_btnExportExcel.BOSDataSource = null;
            this.fld_btnExportExcel.BOSDescription = null;
            this.fld_btnExportExcel.BOSError = null;
            this.fld_btnExportExcel.BOSFieldGroup = null;
            this.fld_btnExportExcel.BOSFieldRelation = null;
            this.fld_btnExportExcel.BOSPrivilege = null;
            this.fld_btnExportExcel.BOSPropertyName = null;
            this.fld_btnExportExcel.Location = new System.Drawing.Point(701, 537);
            this.fld_btnExportExcel.Name = "fld_btnExportExcel";
            this.fld_btnExportExcel.Screen = null;
            this.fld_btnExportExcel.Size = new System.Drawing.Size(96, 27);
            this.fld_btnExportExcel.TabIndex = 2;
            this.fld_btnExportExcel.Text = "Xuất excel";
            this.fld_btnExportExcel.Click += new System.EventHandler(this.fld_btnExportExcel_Click);
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(604, 41);
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
            this.fld_lkeFK_ACObjectID.TabIndex = 81;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            // 
            // RP040
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 576);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lblSubTitleDate);
            this.Controls.Add(this.fld_dgcAPRP040APInvoiceInItems);
            this.Controls.Add(this.fld_btnExportExcel);
            this.Controls.Add(this.fld_btnPrint);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_lblTitle);
            this.Controls.Add(this.panelControl1);
            this.Name = "RP040";
            this.Text = "Danh sách hàng theo hóa đơn";
            this.Load += new System.EventHandler(this.RP040_Load);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_lblTitle, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_btnPrint, 0);
            this.Controls.SetChildIndex(this.fld_btnExportExcel, 0);
            this.Controls.SetChildIndex(this.fld_dgcAPRP040APInvoiceInItems, 0);
            this.Controls.SetChildIndex(this.fld_lblSubTitleDate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPInvoiceInDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPInvoiceInDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedProductGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPInvoiceInDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPInvoiceInDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInvoiceInStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPRP040APInvoiceInItems)).EndInit();
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
        private APRP040InvoiceInItemsGridControl fld_dgcAPRP040APInvoiceInItems;
        private BOSComponent.BOSLabel fld_lblTitle;
        private BOSComponent.BOSLabel fld_lblSubTitleDate;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeICDepartmentID;
        private BOSComponent.BOSButtonEdit fld_bedProductGroup;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeAPInvoiceInStatus;
        private ItemLookupEdit fld_lkeICProductID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSButton fld_btnExportExcel;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchID;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
    }
}