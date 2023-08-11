namespace BOSERP.Modules.SemiProductShipment
{
    partial class guiChooseReceiptItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiChooseReceiptItems));
            this.fld_btnSelect = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICReceiptItemsGridControl = new BOSERP.Modules.SemiProductShipment.ICReceiptItemsGridControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fld_lkeFK_ICReceiptID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnFind = new BOSComponent.BOSButton(this.components);
            this.fld_dteToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtSearchKey = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptItemsGridControl)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICReceiptID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSearchKey.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnSelect
            // 
            this.fld_btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSelect.BOSComment = null;
            this.fld_btnSelect.BOSDataMember = null;
            this.fld_btnSelect.BOSDataSource = null;
            this.fld_btnSelect.BOSDescription = null;
            this.fld_btnSelect.BOSError = null;
            this.fld_btnSelect.BOSFieldGroup = null;
            this.fld_btnSelect.BOSFieldRelation = null;
            this.fld_btnSelect.BOSPrivilege = null;
            this.fld_btnSelect.BOSPropertyName = null;
            this.fld_btnSelect.Location = new System.Drawing.Point(734, 564);
            this.fld_btnSelect.Name = "fld_btnSelect";
            this.fld_btnSelect.Screen = null;
            this.fld_btnSelect.Size = new System.Drawing.Size(83, 27);
            this.fld_btnSelect.TabIndex = 0;
            this.fld_btnSelect.Text = "Chọn";
            this.fld_btnSelect.Click += new System.EventHandler(this.fld_btnOK_Click);
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
            this.fld_btnClose.Location = new System.Drawing.Point(825, 564);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 1;
            this.fld_btnClose.Text = "Hủy";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_dgcICReceiptItemsGridControl
            // 
            this.fld_dgcICReceiptItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICReceiptItemsGridControl.BOSComment = null;
            this.fld_dgcICReceiptItemsGridControl.BOSDataMember = null;
            this.fld_dgcICReceiptItemsGridControl.BOSDataSource = "ICReceiptItems";
            this.fld_dgcICReceiptItemsGridControl.BOSDescription = null;
            this.fld_dgcICReceiptItemsGridControl.BOSError = null;
            this.fld_dgcICReceiptItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcICReceiptItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcICReceiptItemsGridControl.BOSGridType = null;
            this.fld_dgcICReceiptItemsGridControl.BOSPrivilege = null;
            this.fld_dgcICReceiptItemsGridControl.BOSPropertyName = null;
            this.fld_dgcICReceiptItemsGridControl.CommodityType = "";
            this.fld_dgcICReceiptItemsGridControl.Location = new System.Drawing.Point(12, 98);
            this.fld_dgcICReceiptItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcICReceiptItemsGridControl.Name = "fld_dgcICReceiptItemsGridControl";
            this.fld_dgcICReceiptItemsGridControl.PrintReport = false;
            this.fld_dgcICReceiptItemsGridControl.Screen = null;
            this.fld_dgcICReceiptItemsGridControl.Size = new System.Drawing.Size(896, 460);
            this.fld_dgcICReceiptItemsGridControl.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bosLabel3);
            this.groupBox1.Controls.Add(this.fld_txtSearchKey);
            this.groupBox1.Controls.Add(this.bosLabel2);
            this.groupBox1.Controls.Add(this.fld_lkeFK_MMBatchProductID);
            this.groupBox1.Controls.Add(this.fld_lkeFK_ICReceiptID);
            this.groupBox1.Controls.Add(this.bosLabel7);
            this.groupBox1.Controls.Add(this.fld_btnFind);
            this.groupBox1.Controls.Add(this.fld_dteToDate);
            this.groupBox1.Controls.Add(this.bosLabel9);
            this.groupBox1.Controls.Add(this.fld_dteFromDate);
            this.groupBox1.Controls.Add(this.bosLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 79);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm";
            // 
            // fld_lkeFK_ICReceiptID
            // 
            this.fld_lkeFK_ICReceiptID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICReceiptID.BOSAllowDummy = true;
            this.fld_lkeFK_ICReceiptID.BOSComment = null;
            this.fld_lkeFK_ICReceiptID.BOSDataMember = "FK_ICReceiptID";
            this.fld_lkeFK_ICReceiptID.BOSDataSource = "ICReceiptItems";
            this.fld_lkeFK_ICReceiptID.BOSDescription = null;
            this.fld_lkeFK_ICReceiptID.BOSError = "";
            this.fld_lkeFK_ICReceiptID.BOSFieldGroup = null;
            this.fld_lkeFK_ICReceiptID.BOSFieldParent = null;
            this.fld_lkeFK_ICReceiptID.BOSFieldRelation = null;
            this.fld_lkeFK_ICReceiptID.BOSPrivilege = null;
            this.fld_lkeFK_ICReceiptID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICReceiptID.BOSSelectType = "";
            this.fld_lkeFK_ICReceiptID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICReceiptID.CurrentDisplayText = null;
            this.fld_lkeFK_ICReceiptID.Location = new System.Drawing.Point(96, 22);
            this.fld_lkeFK_ICReceiptID.Name = "fld_lkeFK_ICReceiptID";
            this.fld_lkeFK_ICReceiptID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICReceiptID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICReceiptID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICReceiptID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICReceiptID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICReceiptID.Properties.ColumnName = null;
            this.fld_lkeFK_ICReceiptID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICReceiptNo", "Mã chứng từ")});
            this.fld_lkeFK_ICReceiptID.Properties.DisplayMember = "ICReceiptNo";
            this.fld_lkeFK_ICReceiptID.Properties.NullText = "";
            this.fld_lkeFK_ICReceiptID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICReceiptID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICReceiptID.Properties.ValueMember = "ICReceiptID";
            this.fld_lkeFK_ICReceiptID.Screen = null;
            this.fld_lkeFK_ICReceiptID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICReceiptID.TabIndex = 537;
            this.fld_lkeFK_ICReceiptID.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = "";
            this.bosLabel7.BOSDataSource = "";
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = "";
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(10, 26);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(70, 13);
            this.bosLabel7.TabIndex = 538;
            this.bosLabel7.Text = "Mã phiếu nhập";
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
            this.fld_btnFind.Location = new System.Drawing.Point(756, 43);
            this.fld_btnFind.Name = "fld_btnFind";
            this.fld_btnFind.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnFind, true);
            this.fld_btnFind.Size = new System.Drawing.Size(129, 25);
            this.fld_btnFind.TabIndex = 6;
            this.fld_btnFind.Text = "Tìm kiếm";
            this.fld_btnFind.Click += new System.EventHandler(this.fld_btnFind_Click);
            // 
            // fld_dteToDate
            // 
            this.fld_dteToDate.BOSComment = null;
            this.fld_dteToDate.BOSDataMember = "";
            this.fld_dteToDate.BOSDataSource = "";
            this.fld_dteToDate.BOSDescription = null;
            this.fld_dteToDate.BOSError = null;
            this.fld_dteToDate.BOSFieldGroup = null;
            this.fld_dteToDate.BOSFieldRelation = null;
            this.fld_dteToDate.BOSPrivilege = null;
            this.fld_dteToDate.BOSPropertyName = null;
            this.fld_dteToDate.EditValue = null;
            this.fld_dteToDate.Location = new System.Drawing.Point(576, 22);
            this.fld_dteToDate.Name = "fld_dteToDate";
            this.fld_dteToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteToDate.Screen = null;
            this.fld_dteToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteToDate.TabIndex = 5;
            this.fld_dteToDate.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(512, 26);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(47, 13);
            this.bosLabel9.TabIndex = 536;
            this.bosLabel9.Text = "Đến ngày";
            // 
            // fld_dteFromDate
            // 
            this.fld_dteFromDate.BOSComment = null;
            this.fld_dteFromDate.BOSDataMember = "";
            this.fld_dteFromDate.BOSDataSource = "";
            this.fld_dteFromDate.BOSDescription = null;
            this.fld_dteFromDate.BOSError = null;
            this.fld_dteFromDate.BOSFieldGroup = null;
            this.fld_dteFromDate.BOSFieldRelation = null;
            this.fld_dteFromDate.BOSPrivilege = null;
            this.fld_dteFromDate.BOSPropertyName = null;
            this.fld_dteFromDate.EditValue = null;
            this.fld_dteFromDate.Location = new System.Drawing.Point(335, 22);
            this.fld_dteFromDate.Name = "fld_dteFromDate";
            this.fld_dteFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteFromDate.Screen = null;
            this.fld_dteFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteFromDate.TabIndex = 2;
            this.fld_dteFromDate.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(270, 25);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(40, 13);
            this.bosLabel1.TabIndex = 535;
            this.bosLabel1.Text = "Từ ngày";
            // 
            // fld_lkeFK_MMBatchProductID
            // 
            this.fld_lkeFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductID.BOSAllowDummy = false;
            this.fld_lkeFK_MMBatchProductID.BOSComment = null;
            this.fld_lkeFK_MMBatchProductID.BOSDataMember = "FK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.BOSDataSource = "ICReceiptItems";
            this.fld_lkeFK_MMBatchProductID.BOSDescription = null;
            this.fld_lkeFK_MMBatchProductID.BOSError = "";
            this.fld_lkeFK_MMBatchProductID.BOSFieldGroup = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldParent = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldRelation = null;
            this.fld_lkeFK_MMBatchProductID.BOSPrivilege = null;
            this.fld_lkeFK_MMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMBatchProductID.BOSSelectType = "BatchProductType";
            this.fld_lkeFK_MMBatchProductID.BOSSelectTypeValue = "LumberProduct";
            this.fld_lkeFK_MMBatchProductID.CurrentDisplayText = null;
            this.fld_lkeFK_MMBatchProductID.Location = new System.Drawing.Point(96, 48);
            this.fld_lkeFK_MMBatchProductID.Name = "fld_lkeFK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMBatchProductID.Properties.ColumnName = null;
            this.fld_lkeFK_MMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã")});
            this.fld_lkeFK_MMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeFK_MMBatchProductID.Properties.NullText = "";
            this.fld_lkeFK_MMBatchProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Screen = null;
            this.fld_lkeFK_MMBatchProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMBatchProductID.TabIndex = 542;
            this.fld_lkeFK_MMBatchProductID.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(10, 51);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(62, 13);
            this.bosLabel2.TabIndex = 543;
            this.bosLabel2.Text = "Lệnh sản xuất";
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
            this.bosLabel3.Location = new System.Drawing.Point(270, 52);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(39, 13);
            this.bosLabel3.TabIndex = 545;
            this.bosLabel3.Text = "Từ khóa";
            // 
            // fld_txtSearchKey
            // 
            this.fld_txtSearchKey.BOSComment = null;
            this.fld_txtSearchKey.BOSDataMember = null;
            this.fld_txtSearchKey.BOSDataSource = null;
            this.fld_txtSearchKey.BOSDescription = null;
            this.fld_txtSearchKey.BOSError = null;
            this.fld_txtSearchKey.BOSFieldGroup = null;
            this.fld_txtSearchKey.BOSFieldRelation = null;
            this.fld_txtSearchKey.BOSPrivilege = null;
            this.fld_txtSearchKey.BOSPropertyName = null;
            this.fld_txtSearchKey.EditValue = "";
            this.fld_txtSearchKey.Location = new System.Drawing.Point(335, 48);
            this.fld_txtSearchKey.MenuManager = this.screenToolbar;
            this.fld_txtSearchKey.Name = "fld_txtSearchKey";
            this.fld_txtSearchKey.Properties.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.fld_txtSearchKey.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtSearchKey.Properties.NullValuePrompt = "Nhập vào từ khóa";
            this.fld_txtSearchKey.Properties.NullValuePromptShowForEmptyValue = true;
            this.fld_txtSearchKey.Screen = null;
            this.fld_txtSearchKey.Size = new System.Drawing.Size(391, 20);
            this.fld_txtSearchKey.TabIndex = 544;
            // 
            // guiChooseReceiptItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 603);
            this.ControlBox = true;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fld_dgcICReceiptItemsGridControl);
            this.Controls.Add(this.fld_btnSelect);
            this.Controls.Add(this.fld_btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiChooseReceiptItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiếm thông tin";
            this.Load += new System.EventHandler(this.guiChooseReceiptItems_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_btnSelect, 0);
            this.Controls.SetChildIndex(this.fld_dgcICReceiptItemsGridControl, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptItemsGridControl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICReceiptID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSearchKey.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnSelect;
        private BOSComponent.BOSButton fld_btnClose;
        private ICReceiptItemsGridControl fld_dgcICReceiptItemsGridControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private BOSComponent.BOSDateEdit fld_dteToDate;
        private BOSComponent.BOSDateEdit fld_dteFromDate;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSButton fld_btnFind;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICReceiptID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtSearchKey;
    }
}