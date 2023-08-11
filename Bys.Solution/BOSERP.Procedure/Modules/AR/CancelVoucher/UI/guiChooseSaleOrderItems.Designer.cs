namespace BOSERP.Modules.CancelVoucher
{
    partial class guiChooseSaleOrderItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiChooseSaleOrderItems));
            this.fld_dgcSaleOrderItemsGridControl = new BOSERP.Modules.CancelVoucher.ARSaleOrderItemsGridControl();
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_lkeACObjectAccessKey = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARSaleOrderID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnFind = new BOSComponent.BOSButton(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fld_lkeARSaleOrderProductType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderSaleAgreement = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel34 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSaleOrderItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSaleAgreement.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcSaleOrderItemsGridControl
            // 
            this.fld_dgcSaleOrderItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcSaleOrderItemsGridControl.BOSComment = null;
            this.fld_dgcSaleOrderItemsGridControl.BOSDataMember = null;
            this.fld_dgcSaleOrderItemsGridControl.BOSDataSource = "ARSaleOrderItems";
            this.fld_dgcSaleOrderItemsGridControl.BOSDescription = null;
            this.fld_dgcSaleOrderItemsGridControl.BOSError = null;
            this.fld_dgcSaleOrderItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcSaleOrderItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcSaleOrderItemsGridControl.BOSGridType = null;
            this.fld_dgcSaleOrderItemsGridControl.BOSPrivilege = null;
            this.fld_dgcSaleOrderItemsGridControl.BOSPropertyName = null;
            this.fld_dgcSaleOrderItemsGridControl.CommodityType = "";
            this.fld_dgcSaleOrderItemsGridControl.Location = new System.Drawing.Point(12, 81);
            this.fld_dgcSaleOrderItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcSaleOrderItemsGridControl.Name = "fld_dgcSaleOrderItemsGridControl";
            this.fld_dgcSaleOrderItemsGridControl.PrintReport = false;
            this.fld_dgcSaleOrderItemsGridControl.Screen = null;
            this.fld_dgcSaleOrderItemsGridControl.Size = new System.Drawing.Size(915, 483);
            this.fld_dgcSaleOrderItemsGridControl.TabIndex = 2;
            this.fld_dgcSaleOrderItemsGridControl.Tag = "DC";
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
            this.fld_btnOK.Location = new System.Drawing.Point(736, 570);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(92, 27);
            this.fld_btnOK.TabIndex = 1;
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
            this.fld_btnCancel.Location = new System.Drawing.Point(835, 570);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(92, 27);
            this.fld_btnCancel.TabIndex = 2;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_lkeACObjectAccessKey
            // 
            this.fld_lkeACObjectAccessKey.BOSAllowAddNew = false;
            this.fld_lkeACObjectAccessKey.BOSAllowDummy = true;
            this.fld_lkeACObjectAccessKey.BOSComment = "";
            this.fld_lkeACObjectAccessKey.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.BOSDataSource = "ARSaleOrders";
            this.fld_lkeACObjectAccessKey.BOSDescription = null;
            this.fld_lkeACObjectAccessKey.BOSError = null;
            this.fld_lkeACObjectAccessKey.BOSFieldGroup = "";
            this.fld_lkeACObjectAccessKey.BOSFieldParent = "";
            this.fld_lkeACObjectAccessKey.BOSFieldRelation = "";
            this.fld_lkeACObjectAccessKey.BOSModuleType = null;
            this.fld_lkeACObjectAccessKey.BOSPrivilege = "";
            this.fld_lkeACObjectAccessKey.BOSPropertyName = "EditValue";
            this.fld_lkeACObjectAccessKey.BOSSelectType = "";
            this.fld_lkeACObjectAccessKey.BOSSelectTypeValue = "";
            this.fld_lkeACObjectAccessKey.CurrentDisplayText = null;
            this.fld_lkeACObjectAccessKey.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeACObjectAccessKey.Location = new System.Drawing.Point(73, 43);
            this.fld_lkeACObjectAccessKey.Name = "fld_lkeACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACObjectAccessKey.Properties.ColumnName = null;
            this.fld_lkeACObjectAccessKey.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeACObjectAccessKey.Properties.NullText = "";
            this.fld_lkeACObjectAccessKey.Properties.PopupWidth = 40;
            this.fld_lkeACObjectAccessKey.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACObjectAccessKey.Properties.ValueMember = "ACObjectID";
            this.fld_lkeACObjectAccessKey.Screen = null;
            this.fld_lkeACObjectAccessKey.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACObjectAccessKey.TabIndex = 3;
            this.fld_lkeACObjectAccessKey.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(8, 46);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 569;
            this.bosLabel6.Text = "Đối tượng";
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
            this.bosLabel10.Location = new System.Drawing.Point(247, 20);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, true);
            this.bosLabel10.Size = new System.Drawing.Size(40, 13);
            this.bosLabel10.TabIndex = 571;
            this.bosLabel10.Text = "Từ ngày";
            // 
            // fld_dteSearchToDate
            // 
            this.fld_dteSearchToDate.BOSComment = null;
            this.fld_dteSearchToDate.BOSDataMember = null;
            this.fld_dteSearchToDate.BOSDataSource = null;
            this.fld_dteSearchToDate.BOSDescription = null;
            this.fld_dteSearchToDate.BOSError = null;
            this.fld_dteSearchToDate.BOSFieldGroup = null;
            this.fld_dteSearchToDate.BOSFieldRelation = null;
            this.fld_dteSearchToDate.BOSPrivilege = null;
            this.fld_dteSearchToDate.BOSPropertyName = null;
            this.fld_dteSearchToDate.EditValue = null;
            this.fld_dteSearchToDate.Location = new System.Drawing.Point(578, 17);
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteSearchToDate, true);
            this.fld_dteSearchToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToDate.TabIndex = 2;
            this.fld_dteSearchToDate.Tag = "DC";
            // 
            // fld_dteSearchFromDate
            // 
            this.fld_dteSearchFromDate.BOSComment = null;
            this.fld_dteSearchFromDate.BOSDataMember = null;
            this.fld_dteSearchFromDate.BOSDataSource = null;
            this.fld_dteSearchFromDate.BOSDescription = null;
            this.fld_dteSearchFromDate.BOSError = null;
            this.fld_dteSearchFromDate.BOSFieldGroup = null;
            this.fld_dteSearchFromDate.BOSFieldRelation = null;
            this.fld_dteSearchFromDate.BOSPrivilege = null;
            this.fld_dteSearchFromDate.BOSPropertyName = null;
            this.fld_dteSearchFromDate.EditValue = null;
            this.fld_dteSearchFromDate.Location = new System.Drawing.Point(331, 17);
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteSearchFromDate, true);
            this.fld_dteSearchFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromDate.TabIndex = 1;
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
            this.bosLabel9.Location = new System.Drawing.Point(505, 20);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, true);
            this.bosLabel9.Size = new System.Drawing.Size(47, 13);
            this.bosLabel9.TabIndex = 573;
            this.bosLabel9.Text = "Đến ngày";
            // 
            // fld_lkeFK_ARSaleOrderID
            // 
            this.fld_lkeFK_ARSaleOrderID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSaleOrderID.BOSAllowDummy = true;
            this.fld_lkeFK_ARSaleOrderID.BOSComment = "";
            this.fld_lkeFK_ARSaleOrderID.BOSDataMember = "";
            this.fld_lkeFK_ARSaleOrderID.BOSDataSource = "";
            this.fld_lkeFK_ARSaleOrderID.BOSDescription = null;
            this.fld_lkeFK_ARSaleOrderID.BOSError = null;
            this.fld_lkeFK_ARSaleOrderID.BOSFieldGroup = "";
            this.fld_lkeFK_ARSaleOrderID.BOSFieldParent = "";
            this.fld_lkeFK_ARSaleOrderID.BOSFieldRelation = "";
            this.fld_lkeFK_ARSaleOrderID.BOSPrivilege = "";
            this.fld_lkeFK_ARSaleOrderID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARSaleOrderID.BOSSelectType = "";
            this.fld_lkeFK_ARSaleOrderID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARSaleOrderID.CurrentDisplayText = null;
            this.fld_lkeFK_ARSaleOrderID.Location = new System.Drawing.Point(73, 17);
            this.fld_lkeFK_ARSaleOrderID.Name = "fld_lkeFK_ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARSaleOrderID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARSaleOrderID.Properties.ColumnName = null;
            this.fld_lkeFK_ARSaleOrderID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderNo", "Mã ĐBH"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderDate", "Ngày chứng từ", 20, DevExpress.Utils.FormatType.DateTime, "d", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderDeliveryDate", "Ngày giao hàng", 20, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.fld_lkeFK_ARSaleOrderID.Properties.DisplayMember = "ARSaleOrderNo";
            this.fld_lkeFK_ARSaleOrderID.Properties.NullText = "";
            this.fld_lkeFK_ARSaleOrderID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ARSaleOrderID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARSaleOrderID.Properties.ValueMember = "ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.Screen = null;
            this.fld_lkeFK_ARSaleOrderID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARSaleOrderID.TabIndex = 0;
            this.fld_lkeFK_ARSaleOrderID.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseFont = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = "";
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = "";
            this.bosLabel5.BOSPrivilege = "";
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(247, 46);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(68, 13);
            this.bosLabel5.TabIndex = 578;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Loại hàng hóa";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(8, 20);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(41, 13);
            this.bosLabel2.TabIndex = 577;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Mã ĐBH";
            // 
            // fld_btnFind
            // 
            this.fld_btnFind.BOSComment = null;
            this.fld_btnFind.BOSDataMember = null;
            this.fld_btnFind.BOSDataSource = null;
            this.fld_btnFind.BOSDescription = null;
            this.fld_btnFind.BOSError = null;
            this.fld_btnFind.BOSFieldGroup = null;
            this.fld_btnFind.BOSFieldRelation = null;
            this.fld_btnFind.BOSPrivilege = null;
            this.fld_btnFind.BOSPropertyName = null;
            this.fld_btnFind.Location = new System.Drawing.Point(778, 17);
            this.fld_btnFind.Name = "fld_btnFind";
            this.fld_btnFind.Screen = null;
            this.fld_btnFind.Size = new System.Drawing.Size(107, 27);
            this.fld_btnFind.TabIndex = 0;
            this.fld_btnFind.Text = "Tìm kiếm";
            this.fld_btnFind.Click += new System.EventHandler(this.fld_btnFind_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fld_lkeARSaleOrderProductType);
            this.groupBox1.Controls.Add(this.bosLabel27);
            this.groupBox1.Controls.Add(this.fld_txtARSaleOrderSaleAgreement);
            this.groupBox1.Controls.Add(this.bosLabel34);
            this.groupBox1.Controls.Add(this.bosLabel2);
            this.groupBox1.Controls.Add(this.bosLabel9);
            this.groupBox1.Controls.Add(this.fld_dteSearchFromDate);
            this.groupBox1.Controls.Add(this.fld_lkeFK_ARSaleOrderID);
            this.groupBox1.Controls.Add(this.fld_dteSearchToDate);
            this.groupBox1.Controls.Add(this.bosLabel5);
            this.groupBox1.Controls.Add(this.bosLabel10);
            this.groupBox1.Controls.Add(this.bosLabel6);
            this.groupBox1.Controls.Add(this.fld_lkeACObjectAccessKey);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 72);
            this.groupBox1.TabIndex = 580;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm";
            // 
            // fld_lkeARSaleOrderProductType
            // 
            this.fld_lkeARSaleOrderProductType.BOSAllowAddNew = false;
            this.fld_lkeARSaleOrderProductType.BOSAllowDummy = false;
            this.fld_lkeARSaleOrderProductType.BOSComment = null;
            this.fld_lkeARSaleOrderProductType.BOSDataMember = "SaleOrderProductType";
            this.fld_lkeARSaleOrderProductType.BOSDataSource = "ADConfigValues";
            this.fld_lkeARSaleOrderProductType.BOSDescription = null;
            this.fld_lkeARSaleOrderProductType.BOSError = null;
            this.fld_lkeARSaleOrderProductType.BOSFieldGroup = null;
            this.fld_lkeARSaleOrderProductType.BOSFieldParent = null;
            this.fld_lkeARSaleOrderProductType.BOSFieldRelation = null;
            this.fld_lkeARSaleOrderProductType.BOSPrivilege = null;
            this.fld_lkeARSaleOrderProductType.BOSPropertyName = "EditValue";
            this.fld_lkeARSaleOrderProductType.BOSSelectType = "";
            this.fld_lkeARSaleOrderProductType.BOSSelectTypeValue = "";
            this.fld_lkeARSaleOrderProductType.CurrentDisplayText = null;
            this.fld_lkeARSaleOrderProductType.Location = new System.Drawing.Point(331, 46);
            this.fld_lkeARSaleOrderProductType.Name = "fld_lkeARSaleOrderProductType";
            this.fld_lkeARSaleOrderProductType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARSaleOrderProductType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARSaleOrderProductType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARSaleOrderProductType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARSaleOrderProductType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARSaleOrderProductType.Properties.ColumnName = null;
            this.fld_lkeARSaleOrderProductType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADConfigText", "Loại hàng hóa")});
            this.fld_lkeARSaleOrderProductType.Properties.DisplayMember = "ADConfigText";
            this.fld_lkeARSaleOrderProductType.Properties.NullText = "";
            this.fld_lkeARSaleOrderProductType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARSaleOrderProductType.Properties.ValueMember = "ADConfigKeyValue";
            this.fld_lkeARSaleOrderProductType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeARSaleOrderProductType, true);
            this.fld_lkeARSaleOrderProductType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARSaleOrderProductType.TabIndex = 4;
            this.fld_lkeARSaleOrderProductType.Tag = "DC";
            // 
            // bosLabel27
            // 
            this.bosLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.Options.UseBackColor = true;
            this.bosLabel27.Appearance.Options.UseForeColor = true;
            this.bosLabel27.BOSComment = null;
            this.bosLabel27.BOSDataMember = null;
            this.bosLabel27.BOSDataSource = null;
            this.bosLabel27.BOSDescription = null;
            this.bosLabel27.BOSError = null;
            this.bosLabel27.BOSFieldGroup = null;
            this.bosLabel27.BOSFieldRelation = null;
            this.bosLabel27.BOSPrivilege = null;
            this.bosLabel27.BOSPropertyName = null;
            this.bosLabel27.Location = new System.Drawing.Point(-299, 46);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel27, true);
            this.bosLabel27.Size = new System.Drawing.Size(67, 13);
            this.bosLabel27.TabIndex = 581;
            this.bosLabel27.Text = "Loại hàng hóa";
            // 
            // fld_txtARSaleOrderSaleAgreement
            // 
            this.fld_txtARSaleOrderSaleAgreement.BOSComment = null;
            this.fld_txtARSaleOrderSaleAgreement.BOSDataMember = "";
            this.fld_txtARSaleOrderSaleAgreement.BOSDataSource = "";
            this.fld_txtARSaleOrderSaleAgreement.BOSDescription = null;
            this.fld_txtARSaleOrderSaleAgreement.BOSError = null;
            this.fld_txtARSaleOrderSaleAgreement.BOSFieldGroup = null;
            this.fld_txtARSaleOrderSaleAgreement.BOSFieldRelation = null;
            this.fld_txtARSaleOrderSaleAgreement.BOSPrivilege = null;
            this.fld_txtARSaleOrderSaleAgreement.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderSaleAgreement.Location = new System.Drawing.Point(578, 43);
            this.fld_txtARSaleOrderSaleAgreement.Name = "fld_txtARSaleOrderSaleAgreement";
            this.fld_txtARSaleOrderSaleAgreement.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleOrderSaleAgreement.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderSaleAgreement.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderSaleAgreement.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderSaleAgreement.Properties.Mask.EditMask = "n";
            this.fld_txtARSaleOrderSaleAgreement.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderSaleAgreement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderSaleAgreement.Screen = null;
            this.fld_txtARSaleOrderSaleAgreement.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleOrderSaleAgreement.TabIndex = 5;
            this.fld_txtARSaleOrderSaleAgreement.Tag = "DC";
            // 
            // bosLabel34
            // 
            this.bosLabel34.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel34.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel34.Appearance.Options.UseBackColor = true;
            this.bosLabel34.Appearance.Options.UseForeColor = true;
            this.bosLabel34.BOSComment = null;
            this.bosLabel34.BOSDataMember = null;
            this.bosLabel34.BOSDataSource = null;
            this.bosLabel34.BOSDescription = null;
            this.bosLabel34.BOSError = null;
            this.bosLabel34.BOSFieldGroup = null;
            this.bosLabel34.BOSFieldRelation = null;
            this.bosLabel34.BOSPrivilege = null;
            this.bosLabel34.BOSPropertyName = null;
            this.bosLabel34.Location = new System.Drawing.Point(505, 46);
            this.bosLabel34.Name = "bosLabel34";
            this.bosLabel34.Screen = null;
            this.bosLabel34.Size = new System.Drawing.Size(60, 13);
            this.bosLabel34.TabIndex = 580;
            this.bosLabel34.Text = "Số hợp đồng";
            // 
            // guiChooseSaleOrderItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(939, 604);
            this.ControlBox = true;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fld_btnFind);
            this.Controls.Add(this.fld_dgcSaleOrderItemsGridControl);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiChooseSaleOrderItems.IconOptions.Icon")));
            this.Name = "guiChooseSaleOrderItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.guiChooseSaleOrderItems_Load);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_dgcSaleOrderItemsGridControl, 0);
            this.Controls.SetChildIndex(this.fld_btnFind, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSaleOrderItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSaleAgreement.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ARSaleOrderItemsGridControl fld_dgcSaleOrderItemsGridControl;
        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSButton fld_btnCancel;
        private AccObjectLookupEdit fld_lkeACObjectAccessKey;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSaleOrderID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSButton fld_btnFind;
        private System.Windows.Forms.GroupBox groupBox1;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderSaleAgreement;
        private BOSComponent.BOSLabel bosLabel34;
        private BOSComponent.BOSLookupEdit fld_lkeARSaleOrderProductType;
    }
}