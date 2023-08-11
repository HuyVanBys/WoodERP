namespace BOSERP.Modules.BatchProduct
{
    partial class guiChooseARSaleOrderItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiChooseARSaleOrderItem));
            this.fld_dgcARSaleOrderItems = new BOSERP.Modules.BatchProduct.ARSaleOrderItemsGridControl();
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_chkSelectAll = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeARSaleOrderID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromARSaleOrderDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToARSaleOrderDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnSearchPI = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcARSaleOrderItems
            // 
            this.fld_dgcARSaleOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleOrderItems.BOSComment = null;
            this.fld_dgcARSaleOrderItems.BOSDataMember = null;
            this.fld_dgcARSaleOrderItems.BOSDataSource = "ARSaleOrderItems";
            this.fld_dgcARSaleOrderItems.BOSDescription = null;
            this.fld_dgcARSaleOrderItems.BOSError = null;
            this.fld_dgcARSaleOrderItems.BOSFieldGroup = null;
            this.fld_dgcARSaleOrderItems.BOSFieldRelation = null;
            this.fld_dgcARSaleOrderItems.BOSGridType = null;
            this.fld_dgcARSaleOrderItems.BOSPrivilege = null;
            this.fld_dgcARSaleOrderItems.BOSPropertyName = null;
            this.fld_dgcARSaleOrderItems.CommodityType = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcARSaleOrderItems.Location = new System.Drawing.Point(2, 65);
            this.fld_dgcARSaleOrderItems.MenuManager = this.screenToolbar;
            this.fld_dgcARSaleOrderItems.Name = "fld_dgcARSaleOrderItems";
            this.fld_dgcARSaleOrderItems.PrintReport = false;
            this.fld_dgcARSaleOrderItems.Screen = null;
            this.fld_dgcARSaleOrderItems.Size = new System.Drawing.Size(891, 467);
            this.fld_dgcARSaleOrderItems.TabIndex = 0;
            this.fld_dgcARSaleOrderItems.Tag = "DC";
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnOK.BOSComment = null;
            this.fld_btnOK.BOSDataMember = null;
            this.fld_btnOK.BOSDataSource = null;
            this.fld_btnOK.BOSDescription = null;
            this.fld_btnOK.BOSError = null;
            this.fld_btnOK.BOSFieldGroup = null;
            this.fld_btnOK.BOSFieldRelation = null;
            this.fld_btnOK.BOSPrivilege = null;
            this.fld_btnOK.BOSPropertyName = null;
            this.fld_btnOK.Location = new System.Drawing.Point(702, 540);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(92, 27);
            this.fld_btnOK.TabIndex = 3;
            this.fld_btnOK.Text = "Đồng ý";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancel.BOSComment = null;
            this.fld_btnCancel.BOSDataMember = null;
            this.fld_btnCancel.BOSDataSource = null;
            this.fld_btnCancel.BOSDescription = null;
            this.fld_btnCancel.BOSError = null;
            this.fld_btnCancel.BOSFieldGroup = null;
            this.fld_btnCancel.BOSFieldRelation = null;
            this.fld_btnCancel.BOSPrivilege = null;
            this.fld_btnCancel.BOSPropertyName = null;
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(801, 540);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(92, 27);
            this.fld_btnCancel.TabIndex = 4;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_chkSelectAll
            // 
            this.fld_chkSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_chkSelectAll.BOSComment = null;
            this.fld_chkSelectAll.BOSDataMember = null;
            this.fld_chkSelectAll.BOSDataSource = null;
            this.fld_chkSelectAll.BOSDescription = null;
            this.fld_chkSelectAll.BOSError = null;
            this.fld_chkSelectAll.BOSFieldGroup = null;
            this.fld_chkSelectAll.BOSFieldRelation = null;
            this.fld_chkSelectAll.BOSPrivilege = null;
            this.fld_chkSelectAll.BOSPropertyName = null;
            this.fld_chkSelectAll.Location = new System.Drawing.Point(12, 543);
            this.fld_chkSelectAll.MenuManager = this.screenToolbar;
            this.fld_chkSelectAll.Name = "fld_chkSelectAll";
            this.fld_chkSelectAll.Properties.Caption = "Chọn/ bỏ chọn";
            this.fld_chkSelectAll.Screen = null;
            this.fld_chkSelectAll.Size = new System.Drawing.Size(99, 19);
            this.fld_chkSelectAll.TabIndex = 14;
            this.fld_chkSelectAll.CheckedChanged += new System.EventHandler(this.fld_chkSelectAll_CheckedChanged);
            // 
            // fld_lkeARSaleOrderID
            // 
            this.fld_lkeARSaleOrderID.BOSAllowAddNew = false;
            this.fld_lkeARSaleOrderID.BOSAllowDummy = true;
            this.fld_lkeARSaleOrderID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeARSaleOrderID.BOSDataMember = "ARSaleOrderID";
            this.fld_lkeARSaleOrderID.BOSDataSource = "ARSaleOrders";
            this.fld_lkeARSaleOrderID.BOSDescription = null;
            this.fld_lkeARSaleOrderID.BOSError = null;
            this.fld_lkeARSaleOrderID.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeARSaleOrderID.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeARSaleOrderID.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeARSaleOrderID.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeARSaleOrderID.BOSPropertyName = "EditValue";
            this.fld_lkeARSaleOrderID.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeARSaleOrderID.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeARSaleOrderID.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeARSaleOrderID.Location = new System.Drawing.Point(397, 13);
            this.fld_lkeARSaleOrderID.Name = "fld_lkeARSaleOrderID";
            this.fld_lkeARSaleOrderID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARSaleOrderID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARSaleOrderID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARSaleOrderID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARSaleOrderID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARSaleOrderID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderDate", "Ngày"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "NV bán hàng")});
            this.fld_lkeARSaleOrderID.Properties.DisplayMember = "ARSaleOrderNo";
            this.fld_lkeARSaleOrderID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeARSaleOrderID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARSaleOrderID.Properties.ValueMember = "ARSaleOrderID";
            this.fld_lkeARSaleOrderID.Screen = null;
            this.fld_lkeARSaleOrderID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARSaleOrderID.TabIndex = 28;
            this.fld_lkeARSaleOrderID.Tag = "DC";
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
            this.bosLabel8.Location = new System.Drawing.Point(298, 16);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(68, 13);
            this.bosLabel8.TabIndex = 29;
            this.bosLabel8.Text = "Đơn bán hàng";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = null;
            this.fld_lblLabel10.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel10.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel10.BOSFieldRelation = null;
            this.fld_lblLabel10.BOSPrivilege = null;
            this.fld_lblLabel10.BOSPropertyName = null;
            this.fld_lblLabel10.Location = new System.Drawing.Point(24, 16);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(56, 13);
            this.fld_lblLabel10.TabIndex = 30;
            this.fld_lblLabel10.Text = "Khách hàng";
            // 
            // fld_lkeARCustomerID
            // 
            this.fld_lkeARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeARCustomerID.BOSAllowDummy = true;
            this.fld_lkeARCustomerID.BOSComment = null;
            this.fld_lkeARCustomerID.BOSDataMember = "ARCustomerID";
            this.fld_lkeARCustomerID.BOSDataSource = "ARCustomers";
            this.fld_lkeARCustomerID.BOSDescription = null;
            this.fld_lkeARCustomerID.BOSError = null;
            this.fld_lkeARCustomerID.BOSFieldGroup = null;
            this.fld_lkeARCustomerID.BOSFieldParent = null;
            this.fld_lkeARCustomerID.BOSFieldRelation = null;
            this.fld_lkeARCustomerID.BOSPrivilege = null;
            this.fld_lkeARCustomerID.BOSPropertyName = "EditValue";
            this.fld_lkeARCustomerID.BOSSelectType = null;
            this.fld_lkeARCustomerID.BOSSelectTypeValue = null;
            this.fld_lkeARCustomerID.CurrentDisplayText = null;
            this.fld_lkeARCustomerID.Location = new System.Drawing.Point(107, 13);
            this.fld_lkeARCustomerID.Name = "fld_lkeARCustomerID";
            this.fld_lkeARCustomerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên")});
            this.fld_lkeARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeARCustomerID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeARCustomerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeARCustomerID.Screen = null;
            this.fld_lkeARCustomerID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARCustomerID.TabIndex = 31;
            this.fld_lkeARCustomerID.Tag = "DC";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel14.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel14.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel14.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel14.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel14.BOSPropertyName = null;
            this.fld_lblLabel14.Location = new System.Drawing.Point(24, 42);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(62, 13);
            this.fld_lblLabel14.TabIndex = 34;
            this.fld_lblLabel14.Tag = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel14.Text = "Ngày giao từ";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel17.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel17.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel17.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel17.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(298, 42);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel17.TabIndex = 35;
            this.fld_lblLabel17.Tag = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel17.Text = "Đến";
            // 
            // fld_dteSearchFromARSaleOrderDate
            // 
            this.fld_dteSearchFromARSaleOrderDate.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchFromARSaleOrderDate.BOSDataMember = "SaleOrderFromDate";
            this.fld_dteSearchFromARSaleOrderDate.BOSDataSource = "ARSaleOrders";
            this.fld_dteSearchFromARSaleOrderDate.BOSDescription = null;
            this.fld_dteSearchFromARSaleOrderDate.BOSError = null;
            this.fld_dteSearchFromARSaleOrderDate.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchFromARSaleOrderDate.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchFromARSaleOrderDate.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchFromARSaleOrderDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromARSaleOrderDate.EditValue = null;
            this.fld_dteSearchFromARSaleOrderDate.Location = new System.Drawing.Point(107, 39);
            this.fld_dteSearchFromARSaleOrderDate.Name = "fld_dteSearchFromARSaleOrderDate";
            this.fld_dteSearchFromARSaleOrderDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromARSaleOrderDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromARSaleOrderDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromARSaleOrderDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromARSaleOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARSaleOrderDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARSaleOrderDate.Screen = null;
            this.fld_dteSearchFromARSaleOrderDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromARSaleOrderDate.TabIndex = 32;
            this.fld_dteSearchFromARSaleOrderDate.Tag = "DC";
            // 
            // fld_dteSearchToARSaleOrderDate
            // 
            this.fld_dteSearchToARSaleOrderDate.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchToARSaleOrderDate.BOSDataMember = "SaleOrderToDate";
            this.fld_dteSearchToARSaleOrderDate.BOSDataSource = "ARSaleOrders";
            this.fld_dteSearchToARSaleOrderDate.BOSDescription = null;
            this.fld_dteSearchToARSaleOrderDate.BOSError = null;
            this.fld_dteSearchToARSaleOrderDate.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchToARSaleOrderDate.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchToARSaleOrderDate.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dteSearchToARSaleOrderDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToARSaleOrderDate.EditValue = null;
            this.fld_dteSearchToARSaleOrderDate.Location = new System.Drawing.Point(397, 39);
            this.fld_dteSearchToARSaleOrderDate.Name = "fld_dteSearchToARSaleOrderDate";
            this.fld_dteSearchToARSaleOrderDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToARSaleOrderDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToARSaleOrderDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToARSaleOrderDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToARSaleOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARSaleOrderDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARSaleOrderDate.Screen = null;
            this.fld_dteSearchToARSaleOrderDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToARSaleOrderDate.TabIndex = 33;
            this.fld_dteSearchToARSaleOrderDate.Tag = "DC";
            // 
            // fld_btnSearchPI
            // 
            this.fld_btnSearchPI.BOSComment = null;
            this.fld_btnSearchPI.BOSDataMember = null;
            this.fld_btnSearchPI.BOSDataSource = null;
            this.fld_btnSearchPI.BOSDescription = null;
            this.fld_btnSearchPI.BOSError = null;
            this.fld_btnSearchPI.BOSFieldGroup = null;
            this.fld_btnSearchPI.BOSFieldRelation = null;
            this.fld_btnSearchPI.BOSPrivilege = null;
            this.fld_btnSearchPI.BOSPropertyName = null;
            this.fld_btnSearchPI.Location = new System.Drawing.Point(571, 32);
            this.fld_btnSearchPI.Name = "fld_btnSearchPI";
            this.fld_btnSearchPI.Screen = null;
            this.fld_btnSearchPI.Size = new System.Drawing.Size(150, 27);
            this.fld_btnSearchPI.TabIndex = 3;
            this.fld_btnSearchPI.Text = "Tìm";
            this.fld_btnSearchPI.Click += new System.EventHandler(this.fld_btnSearchPI_Click);
            // 
            // guiChooseARSaleOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(901, 574);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_dteSearchFromARSaleOrderDate);
            this.Controls.Add(this.fld_dteSearchToARSaleOrderDate);
            this.Controls.Add(this.fld_lblLabel10);
            this.Controls.Add(this.fld_lkeARCustomerID);
            this.Controls.Add(this.fld_lkeARSaleOrderID);
            this.Controls.Add(this.bosLabel8);
            this.Controls.Add(this.fld_chkSelectAll);
            this.Controls.Add(this.fld_dgcARSaleOrderItems);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnSearchPI);
            this.Controls.Add(this.fld_btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiChooseARSaleOrderItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách mặt hàng từ đơn bán hàng";
            this.Load += new System.EventHandler(this.guiChooseProposalItem_Load);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_btnSearchPI, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_dgcARSaleOrderItems, 0);
            this.Controls.SetChildIndex(this.fld_chkSelectAll, 0);
            this.Controls.SetChildIndex(this.bosLabel8, 0);
            this.Controls.SetChildIndex(this.fld_lkeARSaleOrderID, 0);
            this.Controls.SetChildIndex(this.fld_lkeARCustomerID, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel10, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToARSaleOrderDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromARSaleOrderDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ARSaleOrderItemsGridControl fld_dgcARSaleOrderItems;
        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSCheckEdit fld_chkSelectAll;
        private BOSComponent.BOSLookupEdit fld_lkeARSaleOrderID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeARCustomerID;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSDateEdit fld_dteSearchFromARSaleOrderDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToARSaleOrderDate;
        private BOSComponent.BOSButton fld_btnSearchPI;
    }
}