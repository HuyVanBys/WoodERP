namespace BOSERP.Modules.WoodPlan
{
    partial class guiFilterBatchProduct
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
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductIdentifyWoodType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeICCollections = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnSearch = new BOSComponent.BOSButton(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnClosed = new BOSComponent.BOSButton(this.components);
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_chkChecked = new BOSComponent.BOSCheckEdit(this.components);
            this.bosPanel3 = new BOSComponent.BOSPanel(this.components);
            this.fld_dgcICProducts = new BOSComponent.BOSGridControl(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductIdentifyWoodType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICCollections.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerID.Properties)).BeginInit();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkChecked.Properties)).BeginInit();
            this.bosPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBatchProductID.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_lkeBatchProductID);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.fld_lkeICProductIdentifyWoodType);
            this.bosPanel1.Controls.Add(this.fld_lkeICCollections);
            this.bosPanel1.Controls.Add(this.fld_lkeARCustomerID);
            this.bosPanel1.Controls.Add(this.fld_btnSearch);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1004, 124);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseFont = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSDataMember =global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSDataSource =global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSPropertyName =global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.Location = new System.Drawing.Point(37, 67);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(35, 13);
            this.bosLabel12.TabIndex = 16;
            this.bosLabel12.Tag =global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.Text = "Loại gỗ";
            // 
            // fld_lkeICProductIdentifyWoodType
            // 
            this.fld_lkeICProductIdentifyWoodType.BOSAllowAddNew = false;
            this.fld_lkeICProductIdentifyWoodType.BOSAllowDummy = true;
            this.fld_lkeICProductIdentifyWoodType.BOSComment = null;
            this.fld_lkeICProductIdentifyWoodType.BOSDataMember = "FK_ICProductAttributeWoodTypeID";
            this.fld_lkeICProductIdentifyWoodType.BOSDataSource = "ICProducts";
            this.fld_lkeICProductIdentifyWoodType.BOSDescription = null;
            this.fld_lkeICProductIdentifyWoodType.BOSError = null;
            this.fld_lkeICProductIdentifyWoodType.BOSFieldGroup = null;
            this.fld_lkeICProductIdentifyWoodType.BOSFieldParent = null;
            this.fld_lkeICProductIdentifyWoodType.BOSFieldRelation = null;
            this.fld_lkeICProductIdentifyWoodType.BOSPrivilege = null;
            this.fld_lkeICProductIdentifyWoodType.BOSPropertyName =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICProductIdentifyWoodType.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeICProductIdentifyWoodType.BOSSelectTypeValue = "WoodType";
            this.fld_lkeICProductIdentifyWoodType.CurrentDisplayText = null;
            this.fld_lkeICProductIdentifyWoodType.Location = new System.Drawing.Point(114, 64);
            this.fld_lkeICProductIdentifyWoodType.Name = "fld_lkeICProductIdentifyWoodType";
            this.fld_lkeICProductIdentifyWoodType.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.fld_lkeICProductIdentifyWoodType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductIdentifyWoodType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductIdentifyWoodType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeNo", "Mã loại gỗ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "Tên loại gỗ")});
            this.fld_lkeICProductIdentifyWoodType.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeICProductIdentifyWoodType.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICProductIdentifyWoodType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductIdentifyWoodType.Properties.ValueMember = "ICProductAttributeValue";
            this.fld_lkeICProductIdentifyWoodType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductIdentifyWoodType, true);
            this.fld_lkeICProductIdentifyWoodType.Size = new System.Drawing.Size(190, 20);
            this.fld_lkeICProductIdentifyWoodType.TabIndex = 15;
            this.fld_lkeICProductIdentifyWoodType.Tag =global::Localization.MESLocalizedResources.String1;
            // 
            // fld_lkeICCollections
            // 
            this.fld_lkeICCollections.BOSAllowAddNew = false;
            this.fld_lkeICCollections.BOSAllowDummy = true;
            this.fld_lkeICCollections.BOSComment = null;
            this.fld_lkeICCollections.BOSDataMember = null;
            this.fld_lkeICCollections.BOSDataSource = "ICCollections";
            this.fld_lkeICCollections.BOSDescription = null;
            this.fld_lkeICCollections.BOSError = null;
            this.fld_lkeICCollections.BOSFieldGroup = null;
            this.fld_lkeICCollections.BOSFieldParent = null;
            this.fld_lkeICCollections.BOSFieldRelation = null;
            this.fld_lkeICCollections.BOSPrivilege = null;
            this.fld_lkeICCollections.BOSPropertyName =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICCollections.BOSSelectType = null;
            this.fld_lkeICCollections.BOSSelectTypeValue = null;
            this.fld_lkeICCollections.CurrentDisplayText = null;
            this.fld_lkeICCollections.Location = new System.Drawing.Point(114, 38);
            this.fld_lkeICCollections.MenuManager = this.screenToolbar;
            this.fld_lkeICCollections.Name = "fld_lkeICCollections";
            this.fld_lkeICCollections.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICCollections.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICCollectionNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICCollectionName", "Tên")});
            this.fld_lkeICCollections.Properties.DisplayMember = "ICCollectionName";
            this.fld_lkeICCollections.Properties.ValueMember = "ICCollectionID";
            this.fld_lkeICCollections.Screen = null;
            this.fld_lkeICCollections.Size = new System.Drawing.Size(190, 20);
            this.fld_lkeICCollections.TabIndex = 1;
            // 
            // fld_lkeARCustomerID
            // 
            this.fld_lkeARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeARCustomerID.BOSAllowDummy = true;
            this.fld_lkeARCustomerID.BOSComment = null;
            this.fld_lkeARCustomerID.BOSDataMember = null;
            this.fld_lkeARCustomerID.BOSDataSource = "ARCustomers";
            this.fld_lkeARCustomerID.BOSDescription = null;
            this.fld_lkeARCustomerID.BOSError = null;
            this.fld_lkeARCustomerID.BOSFieldGroup = null;
            this.fld_lkeARCustomerID.BOSFieldParent = null;
            this.fld_lkeARCustomerID.BOSFieldRelation = null;
            this.fld_lkeARCustomerID.BOSPrivilege = null;
            this.fld_lkeARCustomerID.BOSPropertyName =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeARCustomerID.BOSSelectType = null;
            this.fld_lkeARCustomerID.BOSSelectTypeValue = null;
            this.fld_lkeARCustomerID.CurrentDisplayText = null;
            this.fld_lkeARCustomerID.Location = new System.Drawing.Point(114, 12);
            this.fld_lkeARCustomerID.MenuManager = this.screenToolbar;
            this.fld_lkeARCustomerID.Name = "fld_lkeARCustomerID";
            this.fld_lkeARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên")});
            this.fld_lkeARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeARCustomerID.Screen = null;
            this.fld_lkeARCustomerID.Size = new System.Drawing.Size(190, 20);
            this.fld_lkeARCustomerID.TabIndex = 0;
            // 
            // fld_btnSearch
            // 
            this.fld_btnSearch.BOSComment = null;
            this.fld_btnSearch.BOSDataMember =global::Localization.MESLocalizedResources.String1;
            this.fld_btnSearch.BOSDataSource =global::Localization.MESLocalizedResources.String1;
            this.fld_btnSearch.BOSDescription = null;
            this.fld_btnSearch.BOSError = null;
            this.fld_btnSearch.BOSFieldGroup = null;
            this.fld_btnSearch.BOSFieldRelation = null;
            this.fld_btnSearch.BOSPrivilege = null;
            this.fld_btnSearch.BOSPropertyName =global::Localization.MESLocalizedResources.String1;
            this.fld_btnSearch.Location = new System.Drawing.Point(324, 81);
            this.fld_btnSearch.Name = "fld_btnSearch";
            this.fld_btnSearch.Screen = null;
            this.fld_btnSearch.Size = new System.Drawing.Size(116, 29);
            this.fld_btnSearch.TabIndex = 2;
            this.fld_btnSearch.Tag =global::Localization.MESLocalizedResources.String1;
            this.fld_btnSearch.Text = "Tìm kiếm";
            this.fld_btnSearch.Click += new System.EventHandler(this.fld_btnSearch_Click_1);
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
            this.bosLabel2.Location = new System.Drawing.Point(37, 41);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(52, 13);
            this.bosLabel2.TabIndex = 3;
            this.bosLabel2.Text = "Dòng hàng";
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
            this.bosLabel1.Location = new System.Drawing.Point(37, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(56, 13);
            this.bosLabel1.TabIndex = 4;
            this.bosLabel1.Text = "Khách hàng";
            // 
            // bosPanel2
            // 
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.fld_btnClosed);
            this.bosPanel2.Controls.Add(this.fld_btnOK);
            this.bosPanel2.Controls.Add(this.fld_chkChecked);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bosPanel2.Location = new System.Drawing.Point(0, 600);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(1004, 44);
            this.bosPanel2.TabIndex = 7;
            // 
            // fld_btnClosed
            // 
            this.fld_btnClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnClosed.BOSComment = null;
            this.fld_btnClosed.BOSDataMember =global::Localization.MESLocalizedResources.String1;
            this.fld_btnClosed.BOSDataSource =global::Localization.MESLocalizedResources.String1;
            this.fld_btnClosed.BOSDescription = null;
            this.fld_btnClosed.BOSError = null;
            this.fld_btnClosed.BOSFieldGroup = null;
            this.fld_btnClosed.BOSFieldRelation = null;
            this.fld_btnClosed.BOSPrivilege = null;
            this.fld_btnClosed.BOSPropertyName =global::Localization.MESLocalizedResources.String1;
            this.fld_btnClosed.Location = new System.Drawing.Point(889, 8);
            this.fld_btnClosed.Name = "fld_btnClosed";
            this.fld_btnClosed.Screen = null;
            this.fld_btnClosed.Size = new System.Drawing.Size(103, 26);
            this.fld_btnClosed.TabIndex = 2;
            this.fld_btnClosed.Tag =global::Localization.MESLocalizedResources.String1;
            this.fld_btnClosed.Text = "Thoát";
            this.fld_btnClosed.Click += new System.EventHandler(this.fld_btnClosed_Click);
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnOK.BOSComment = null;
            this.fld_btnOK.BOSDataMember =global::Localization.MESLocalizedResources.String1;
            this.fld_btnOK.BOSDataSource =global::Localization.MESLocalizedResources.String1;
            this.fld_btnOK.BOSDescription = null;
            this.fld_btnOK.BOSError = null;
            this.fld_btnOK.BOSFieldGroup = null;
            this.fld_btnOK.BOSFieldRelation = null;
            this.fld_btnOK.BOSPrivilege = null;
            this.fld_btnOK.BOSPropertyName =global::Localization.MESLocalizedResources.String1;
            this.fld_btnOK.Location = new System.Drawing.Point(770, 8);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(103, 26);
            this.fld_btnOK.TabIndex = 0;
            this.fld_btnOK.Tag =global::Localization.MESLocalizedResources.String1;
            this.fld_btnOK.Text = "OK";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // fld_chkChecked
            // 
            this.fld_chkChecked.BOSComment = null;
            this.fld_chkChecked.BOSDataMember = null;
            this.fld_chkChecked.BOSDataSource = null;
            this.fld_chkChecked.BOSDescription = null;
            this.fld_chkChecked.BOSError = null;
            this.fld_chkChecked.BOSFieldGroup = null;
            this.fld_chkChecked.BOSFieldRelation = null;
            this.fld_chkChecked.BOSPrivilege = null;
            this.fld_chkChecked.BOSPropertyName = null;
            this.fld_chkChecked.Location = new System.Drawing.Point(12, 13);
            this.fld_chkChecked.MenuManager = this.screenToolbar;
            this.fld_chkChecked.Name = "fld_chkChecked";
            this.fld_chkChecked.Properties.Caption = "Chọn tất cả";
            this.fld_chkChecked.Screen = null;
            this.fld_chkChecked.Size = new System.Drawing.Size(124, 19);
            this.fld_chkChecked.TabIndex = 1;
            this.fld_chkChecked.CheckedChanged += new System.EventHandler(this.fld_chkChecked_CheckedChanged);
            // 
            // bosPanel3
            // 
            this.bosPanel3.BOSComment = null;
            this.bosPanel3.BOSDataMember = null;
            this.bosPanel3.BOSDataSource = null;
            this.bosPanel3.BOSDescription = null;
            this.bosPanel3.BOSError = null;
            this.bosPanel3.BOSFieldGroup = null;
            this.bosPanel3.BOSFieldRelation = null;
            this.bosPanel3.BOSPrivilege = null;
            this.bosPanel3.BOSPropertyName = null;
            this.bosPanel3.Controls.Add(this.fld_dgcICProducts);
            this.bosPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel3.Location = new System.Drawing.Point(0, 124);
            this.bosPanel3.Name = "bosPanel3";
            this.bosPanel3.Screen = null;
            this.bosPanel3.Size = new System.Drawing.Size(1004, 476);
            this.bosPanel3.TabIndex = 8;
            // 
            // fld_dgcICProducts
            // 
            this.fld_dgcICProducts.BOSComment = null;
            this.fld_dgcICProducts.BOSDataMember = null;
            this.fld_dgcICProducts.BOSDataSource = "MMBatchProductProductionNormItems";
            this.fld_dgcICProducts.BOSDescription = null;
            this.fld_dgcICProducts.BOSError = null;
            this.fld_dgcICProducts.BOSFieldGroup = null;
            this.fld_dgcICProducts.BOSFieldRelation = null;
            this.fld_dgcICProducts.BOSGridType = null;
            this.fld_dgcICProducts.BOSPrivilege = null;
            this.fld_dgcICProducts.BOSPropertyName = null;
            this.fld_dgcICProducts.CommodityType =global::Localization.MESLocalizedResources.String1;
            this.fld_dgcICProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICProducts.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcICProducts.MenuManager = this.screenToolbar;
            this.fld_dgcICProducts.Name = "fld_dgcICProducts";
            this.fld_dgcICProducts.PrintReport = false;
            this.fld_dgcICProducts.Screen = null;
            this.fld_dgcICProducts.Size = new System.Drawing.Size(1004, 476);
            this.fld_dgcICProducts.TabIndex = 0;
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSDataMember =global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSDataSource =global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSPropertyName =global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.Location = new System.Drawing.Point(37, 93);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(67, 13);
            this.bosLabel6.TabIndex = 18;
            this.bosLabel6.Tag =global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.Text = "Lệnh sản xuất";
            // 
            // fld_lkeBatchProductID
            // 
            this.fld_lkeBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeBatchProductID.BOSAllowDummy = true;
            this.fld_lkeBatchProductID.BOSComment = null;
            this.fld_lkeBatchProductID.BOSDataMember = "MMBatchProductNo";
            this.fld_lkeBatchProductID.BOSDataSource = "MMBatchProducts";
            this.fld_lkeBatchProductID.BOSDescription = null;
            this.fld_lkeBatchProductID.BOSError = null;
            this.fld_lkeBatchProductID.BOSFieldGroup = null;
            this.fld_lkeBatchProductID.BOSFieldParent = null;
            this.fld_lkeBatchProductID.BOSFieldRelation = null;
            this.fld_lkeBatchProductID.BOSPrivilege = null;
            this.fld_lkeBatchProductID.BOSPropertyName =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeBatchProductID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeBatchProductID.BOSSelectTypeValue = "WoodType";
            this.fld_lkeBatchProductID.CurrentDisplayText = null;
            this.fld_lkeBatchProductID.Location = new System.Drawing.Point(114, 90);
            this.fld_lkeBatchProductID.Name = "fld_lkeBatchProductID";
            this.fld_lkeBatchProductID.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.fld_lkeBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "LSX")});
            this.fld_lkeBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeBatchProductID.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeBatchProductID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeBatchProductID, true);
            this.fld_lkeBatchProductID.Size = new System.Drawing.Size(190, 20);
            this.fld_lkeBatchProductID.TabIndex = 17;
            this.fld_lkeBatchProductID.Tag =global::Localization.MESLocalizedResources.String1;
            // 
            // guiFilterBatchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 644);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel3);
            this.Controls.Add(this.bosPanel2);
            this.Controls.Add(this.bosPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "guiFilterBatchProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.guiFilterBatchProduct_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            this.Controls.SetChildIndex(this.bosPanel3, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductIdentifyWoodType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICCollections.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerID.Properties)).EndInit();
            this.bosPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkChecked.Properties)).EndInit();
            this.bosPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBatchProductID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSPanel bosPanel3;
        private BOSComponent.BOSCheckEdit fld_chkChecked;
        private BOSComponent.BOSGridControl fld_dgcICProducts;
        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSButton fld_btnSearch;
        private BOSComponent.BOSLookupEdit fld_lkeICCollections;
        private BOSComponent.BOSLookupEdit fld_lkeARCustomerID;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeICProductIdentifyWoodType;
        private BOSComponent.BOSButton fld_btnClosed;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeBatchProductID;

    }
}