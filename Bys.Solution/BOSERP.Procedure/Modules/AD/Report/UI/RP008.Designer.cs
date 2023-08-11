namespace BOSERP.Modules.Report
{
    partial class RP008
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP008));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeARCustomerType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkePriceLevel = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARRP008Customer = new BOSERP.Modules.Report.ARRP008CustomersGridControl();
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            this.fld_lkeCustomerLocationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeGELocationID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeBRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePriceLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARRP008Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeCustomerLocationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGELocationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_lkeBRBranchID);
            this.panelControl1.Controls.Add(this.fld_lkeGELocationID);
            this.panelControl1.Controls.Add(this.fld_lkeCustomerLocationID);
            this.panelControl1.Controls.Add(this.fld_lkeARCustomerType);
            this.panelControl1.Controls.Add(this.fld_lkePriceLevel);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Controls.Add(this.bosLabel5);
            this.panelControl1.Controls.Add(this.bosLabel4);
            this.panelControl1.Controls.Add(this.bosLabel3);
            this.panelControl1.Controls.Add(this.bosLabel2);
            this.panelControl1.Controls.Add(this.BOSLabel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1028, 73);
            this.panelControl1.TabIndex = 1;
            // 
            // fld_lkeARCustomerType
            // 
            this.fld_lkeARCustomerType.BOSAllowAddNew = false;
            this.fld_lkeARCustomerType.BOSAllowDummy = true;
            this.fld_lkeARCustomerType.BOSComment = null;
            this.fld_lkeARCustomerType.BOSDataMember = "ARCustomerTypeCombo";
            this.fld_lkeARCustomerType.BOSDataSource = "ARCustomers";
            this.fld_lkeARCustomerType.BOSDescription = null;
            this.fld_lkeARCustomerType.BOSError = null;
            this.fld_lkeARCustomerType.BOSFieldGroup = null;
            this.fld_lkeARCustomerType.BOSFieldParent = null;
            this.fld_lkeARCustomerType.BOSFieldRelation = null;
            this.fld_lkeARCustomerType.BOSPrivilege = null;
            this.fld_lkeARCustomerType.BOSPropertyName = null;
            this.fld_lkeARCustomerType.BOSSelectType = null;
            this.fld_lkeARCustomerType.BOSSelectTypeValue = null;
            this.fld_lkeARCustomerType.CurrentDisplayText = null;
            this.fld_lkeARCustomerType.Location = new System.Drawing.Point(392, 12);
            this.fld_lkeARCustomerType.Name = "fld_lkeARCustomerType";
            this.fld_lkeARCustomerType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCustomerType.Properties.NullText = "";
            this.fld_lkeARCustomerType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARCustomerType.Screen = null;
            this.fld_lkeARCustomerType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARCustomerType.TabIndex = 2;
            this.fld_lkeARCustomerType.Tag = "SC";
            // 
            // fld_lkePriceLevel
            // 
            this.fld_lkePriceLevel.BOSAllowAddNew = false;
            this.fld_lkePriceLevel.BOSAllowDummy = true;
            this.fld_lkePriceLevel.BOSComment = null;
            this.fld_lkePriceLevel.BOSDataMember = "FK_ARPriceLevelID";
            this.fld_lkePriceLevel.BOSDataSource = "ARCustomers";
            this.fld_lkePriceLevel.BOSDescription = null;
            this.fld_lkePriceLevel.BOSError = null;
            this.fld_lkePriceLevel.BOSFieldGroup = null;
            this.fld_lkePriceLevel.BOSFieldParent = null;
            this.fld_lkePriceLevel.BOSFieldRelation = null;
            this.fld_lkePriceLevel.BOSPrivilege = null;
            this.fld_lkePriceLevel.BOSPropertyName = null;
            this.fld_lkePriceLevel.BOSSelectType = null;
            this.fld_lkePriceLevel.BOSSelectTypeValue = null;
            this.fld_lkePriceLevel.CurrentDisplayText = null;
            this.fld_lkePriceLevel.Location = new System.Drawing.Point(622, 12);
            this.fld_lkePriceLevel.MenuManager = this.screenToolbar;
            this.fld_lkePriceLevel.Name = "fld_lkePriceLevel";
            this.fld_lkePriceLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkePriceLevel.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARPriceLevelName", "Tên mức giá")});
            this.fld_lkePriceLevel.Properties.DisplayMember = "ARPriceLevelName";
            this.fld_lkePriceLevel.Properties.NullText = "";
            this.fld_lkePriceLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkePriceLevel.Properties.ValueMember = "ARPriceLevelID";
            this.fld_lkePriceLevel.Screen = null;
            this.fld_lkePriceLevel.Size = new System.Drawing.Size(150, 20);
            this.fld_lkePriceLevel.TabIndex = 3;
            this.fld_lkePriceLevel.Tag = "SC";
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
            this.fld_btnApply.Location = new System.Drawing.Point(806, 7);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(75, 27);
            this.fld_btnApply.TabIndex = 6;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
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
            this.bosLabel3.Location = new System.Drawing.Point(12, 15);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(99, 13);
            this.bosLabel3.TabIndex = 0;
            this.bosLabel3.Text = "Vị trí của khách hàng";
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
            this.bosLabel2.Location = new System.Drawing.Point(295, 15);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(77, 13);
            this.bosLabel2.TabIndex = 0;
            this.bosLabel2.Text = "Loại khách hàng";
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
            this.BOSLabel1.Location = new System.Drawing.Point(560, 15);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(37, 13);
            this.BOSLabel1.TabIndex = 0;
            this.BOSLabel1.Text = "Mức giá";
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
            this.fld_lblTitle.Location = new System.Drawing.Point(395, 91);
            this.fld_lblTitle.Name = "fld_lblTitle";
            this.fld_lblTitle.Screen = null;
            this.fld_lblTitle.Size = new System.Drawing.Size(214, 19);
            this.fld_lblTitle.TabIndex = 0;
            this.fld_lblTitle.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // fld_dgcARRP008Customer
            // 
            this.fld_dgcARRP008Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARRP008Customer.BOSComment = null;
            this.fld_dgcARRP008Customer.BOSDataMember = null;
            this.fld_dgcARRP008Customer.BOSDataSource = "ARCustomers";
            this.fld_dgcARRP008Customer.BOSDescription = null;
            this.fld_dgcARRP008Customer.BOSError = null;
            this.fld_dgcARRP008Customer.BOSFieldGroup = null;
            this.fld_dgcARRP008Customer.BOSFieldRelation = null;
            this.fld_dgcARRP008Customer.BOSGridType = null;
            this.fld_dgcARRP008Customer.BOSPrivilege = null;
            this.fld_dgcARRP008Customer.BOSPropertyName = null;
            this.fld_dgcARRP008Customer.Location = new System.Drawing.Point(17, 129);
            this.fld_dgcARRP008Customer.Name = "fld_dgcARRP008Customer";
            this.fld_dgcARRP008Customer.Screen = null;
            this.fld_dgcARRP008Customer.Size = new System.Drawing.Size(997, 512);
            this.fld_dgcARRP008Customer.TabIndex = 4;
            this.fld_dgcARRP008Customer.Tag = "DC";
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
            this.fld_btnClose.Location = new System.Drawing.Point(939, 660);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 3;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
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
            this.fld_btnPrint.Location = new System.Drawing.Point(849, 660);
            this.fld_btnPrint.Name = "fld_btnPrint";
            this.fld_btnPrint.Screen = null;
            this.fld_btnPrint.Size = new System.Drawing.Size(75, 27);
            this.fld_btnPrint.TabIndex = 2;
            this.fld_btnPrint.Text = "In";
            this.fld_btnPrint.Click += new System.EventHandler(this.fld_btnPrint_Click);
            // 
            // fld_lkeCustomerLocationID
            // 
            this.fld_lkeCustomerLocationID.BOSAllowAddNew = false;
            this.fld_lkeCustomerLocationID.BOSAllowDummy = true;
            this.fld_lkeCustomerLocationID.BOSComment = null;
            this.fld_lkeCustomerLocationID.BOSDataMember = "GELocationID";
            this.fld_lkeCustomerLocationID.BOSDataSource = "GELocations";
            this.fld_lkeCustomerLocationID.BOSDescription = null;
            this.fld_lkeCustomerLocationID.BOSError = null;
            this.fld_lkeCustomerLocationID.BOSFieldGroup = null;
            this.fld_lkeCustomerLocationID.BOSFieldParent = null;
            this.fld_lkeCustomerLocationID.BOSFieldRelation = null;
            this.fld_lkeCustomerLocationID.BOSPrivilege = null;
            this.fld_lkeCustomerLocationID.BOSPropertyName = null;
            this.fld_lkeCustomerLocationID.BOSSelectType = null;
            this.fld_lkeCustomerLocationID.BOSSelectTypeValue = null;
            this.fld_lkeCustomerLocationID.CurrentDisplayText = null;
            this.fld_lkeCustomerLocationID.Location = new System.Drawing.Point(124, 12);
            this.fld_lkeCustomerLocationID.MenuManager = this.screenToolbar;
            this.fld_lkeCustomerLocationID.Name = "fld_lkeCustomerLocationID";
            this.fld_lkeCustomerLocationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeCustomerLocationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GELocationName", "Vị trí")});
            this.fld_lkeCustomerLocationID.Properties.DisplayMember = "GELocationName";
            this.fld_lkeCustomerLocationID.Properties.ValueMember = "GELocationID";
            this.fld_lkeCustomerLocationID.Screen = null;
            this.fld_lkeCustomerLocationID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeCustomerLocationID.TabIndex = 1;
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
            this.bosLabel4.Location = new System.Drawing.Point(12, 41);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(90, 13);
            this.bosLabel4.TabIndex = 0;
            this.bosLabel4.Text = "Vị trí của chi nhánh";
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
            this.fld_lkeGELocationID.Location = new System.Drawing.Point(124, 38);
            this.fld_lkeGELocationID.Name = "fld_lkeGELocationID";
            this.fld_lkeGELocationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeGELocationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GELocationName", "Vị trí")});
            this.fld_lkeGELocationID.Properties.DisplayMember = "GELocationName";
            this.fld_lkeGELocationID.Properties.ValueMember = "GELocationID";
            this.fld_lkeGELocationID.Screen = null;
            this.fld_lkeGELocationID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeGELocationID.TabIndex = 4;
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
            this.fld_lkeBRBranchID.Location = new System.Drawing.Point(392, 38);
            this.fld_lkeBRBranchID.MenuManager = this.screenToolbar;
            this.fld_lkeBRBranchID.Name = "fld_lkeBRBranchID";
            this.fld_lkeBRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeBRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchID.Screen = null;
            this.fld_lkeBRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchID.TabIndex = 5;
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
            this.bosLabel5.Location = new System.Drawing.Point(295, 41);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(48, 13);
            this.bosLabel5.TabIndex = 0;
            this.bosLabel5.Text = "Chi nhánh";
            // 
            // RP008
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 695);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnPrint);
            this.Controls.Add(this.fld_dgcARRP008Customer);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.fld_lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RP008";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Danh sách khách hàng";
            this.Load += new System.EventHandler(this.RP008_Load);
            this.Controls.SetChildIndex(this.fld_lblTitle, 0);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_dgcARRP008Customer, 0);
            this.Controls.SetChildIndex(this.fld_btnPrint, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePriceLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARRP008Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeCustomerLocationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGELocationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel fld_lblTitle;
        private ARRP008CustomersGridControl fld_dgcARRP008Customer;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnPrint;
        private BOSComponent.BOSLookupEdit fld_lkePriceLevel;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeARCustomerType;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeCustomerLocationID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchID;
        private BOSComponent.BOSLookupEdit fld_lkeGELocationID;
        private BOSComponent.BOSLabel bosLabel5;

    }
}