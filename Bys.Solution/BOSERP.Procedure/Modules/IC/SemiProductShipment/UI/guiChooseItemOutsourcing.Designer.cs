namespace BOSERP.Modules.SemiProductShipment
{
    partial class guiChooseItemOutsourcing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiChooseItemOutsourcing));
            this.fld_btnSelect = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICReceiptItemsGridControl = new BOSERP.Modules.SemiProductShipment.ICReceiptItemsGridControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnFind = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_ICReceiptID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fld_lkeFK_MMReceiveOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMBatchProductItemID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMBatchProductTargetID = new BOSComponent.BOSLookupEdit(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.fld_dgcICShipmentItemsGridControl = new BOSERP.Modules.SemiProductShipment.ICShipmentItemPreviewGridControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.fld_btnAllocationQty = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptItemsGridControl)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICReceiptID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMReceiveOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductTargetID.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
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
            this.fld_btnSelect.Location = new System.Drawing.Point(910, 580);
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
            this.fld_btnClose.Location = new System.Drawing.Point(1001, 580);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 1;
            this.fld_btnClose.Text = "Hủy";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_dgcICReceiptItemsGridControl
            // 
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
            this.fld_dgcICReceiptItemsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICReceiptItemsGridControl.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcICReceiptItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcICReceiptItemsGridControl.Name = "fld_dgcICReceiptItemsGridControl";
            this.fld_dgcICReceiptItemsGridControl.PrintReport = false;
            this.fld_dgcICReceiptItemsGridControl.Screen = null;
            this.fld_dgcICReceiptItemsGridControl.Size = new System.Drawing.Size(484, 427);
            this.fld_dgcICReceiptItemsGridControl.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bosLabel2);
            this.groupBox1.Controls.Add(this.fld_lkeFK_MMBatchProductID);
            this.groupBox1.Controls.Add(this.fld_btnFind);
            this.groupBox1.Controls.Add(this.fld_lkeFK_ICReceiptID);
            this.groupBox1.Controls.Add(this.bosLabel7);
            this.groupBox1.Controls.Add(this.fld_dteToDate);
            this.groupBox1.Controls.Add(this.bosLabel9);
            this.groupBox1.Controls.Add(this.fld_dteFromDate);
            this.groupBox1.Controls.Add(this.bosLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 105);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm";
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
            this.bosLabel2.Location = new System.Drawing.Point(10, 48);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(68, 13);
            this.bosLabel2.TabIndex = 543;
            this.bosLabel2.Text = "Lệnh sản xuất";
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
            this.fld_lkeFK_MMBatchProductID.Location = new System.Drawing.Point(96, 44);
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
            this.fld_lkeFK_MMBatchProductID.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeFK_MMBatchProductID.TabIndex = 542;
            this.fld_lkeFK_MMBatchProductID.Tag = "DC";
            this.fld_lkeFK_MMBatchProductID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMBatchProductID_CloseUp);
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
            this.fld_btnFind.Location = new System.Drawing.Point(368, 70);
            this.fld_btnFind.Name = "fld_btnFind";
            this.fld_btnFind.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnFind, true);
            this.fld_btnFind.Size = new System.Drawing.Size(83, 25);
            this.fld_btnFind.TabIndex = 6;
            this.fld_btnFind.Text = "Tìm kiếm";
            this.fld_btnFind.Click += new System.EventHandler(this.fld_btnFind_Click);
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
            this.fld_lkeFK_ICReceiptID.Location = new System.Drawing.Point(96, 18);
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
            this.fld_lkeFK_ICReceiptID.Size = new System.Drawing.Size(130, 20);
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
            this.bosLabel7.Location = new System.Drawing.Point(10, 22);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(70, 13);
            this.bosLabel7.TabIndex = 538;
            this.bosLabel7.Text = "Mã phiếu nhập";
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
            this.fld_dteToDate.Location = new System.Drawing.Point(321, 44);
            this.fld_dteToDate.Name = "fld_dteToDate";
            this.fld_dteToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteToDate.Screen = null;
            this.fld_dteToDate.Size = new System.Drawing.Size(130, 20);
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
            this.bosLabel9.Location = new System.Drawing.Point(259, 47);
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
            this.fld_dteFromDate.Location = new System.Drawing.Point(321, 18);
            this.fld_dteFromDate.Name = "fld_dteFromDate";
            this.fld_dteFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteFromDate.Screen = null;
            this.fld_dteFromDate.Size = new System.Drawing.Size(130, 20);
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
            this.bosLabel1.Location = new System.Drawing.Point(259, 22);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(40, 13);
            this.bosLabel1.TabIndex = 535;
            this.bosLabel1.Text = "Từ ngày";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fld_lkeFK_MMReceiveOperationID);
            this.groupBox2.Controls.Add(this.bosLabel5);
            this.groupBox2.Controls.Add(this.fld_lkeFK_MMBatchProductItemID);
            this.groupBox2.Controls.Add(this.bosLabel4);
            this.groupBox2.Controls.Add(this.bosLabel3);
            this.groupBox2.Controls.Add(this.fld_lkeFK_MMBatchProductTargetID);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(52, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 105);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cấp phát";
            // 
            // fld_lkeFK_MMReceiveOperationID
            // 
            this.fld_lkeFK_MMReceiveOperationID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMReceiveOperationID.BOSAllowDummy = true;
            this.fld_lkeFK_MMReceiveOperationID.BOSComment = null;
            this.fld_lkeFK_MMReceiveOperationID.BOSDataMember = "FK_MMOperationID";
            this.fld_lkeFK_MMReceiveOperationID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_MMReceiveOperationID.BOSDescription = null;
            this.fld_lkeFK_MMReceiveOperationID.BOSError = "";
            this.fld_lkeFK_MMReceiveOperationID.BOSFieldGroup = null;
            this.fld_lkeFK_MMReceiveOperationID.BOSFieldParent = null;
            this.fld_lkeFK_MMReceiveOperationID.BOSFieldRelation = null;
            this.fld_lkeFK_MMReceiveOperationID.BOSPrivilege = null;
            this.fld_lkeFK_MMReceiveOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMReceiveOperationID.BOSSelectType = "";
            this.fld_lkeFK_MMReceiveOperationID.BOSSelectTypeValue = "True";
            this.fld_lkeFK_MMReceiveOperationID.CurrentDisplayText = null;
            this.fld_lkeFK_MMReceiveOperationID.Location = new System.Drawing.Point(91, 45);
            this.fld_lkeFK_MMReceiveOperationID.Name = "fld_lkeFK_MMReceiveOperationID";
            this.fld_lkeFK_MMReceiveOperationID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMReceiveOperationID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMReceiveOperationID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMReceiveOperationID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMReceiveOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMReceiveOperationID.Properties.ColumnName = null;
            this.fld_lkeFK_MMReceiveOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Công đoạn")});
            this.fld_lkeFK_MMReceiveOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeFK_MMReceiveOperationID.Properties.NullText = "";
            this.fld_lkeFK_MMReceiveOperationID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMReceiveOperationID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMReceiveOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeFK_MMReceiveOperationID.Screen = null;
            this.fld_lkeFK_MMReceiveOperationID.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeFK_MMReceiveOperationID.TabIndex = 550;
            this.fld_lkeFK_MMReceiveOperationID.Tag = "DC";
            this.fld_lkeFK_MMReceiveOperationID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_MMReceiveOperationID_QueryPopUp);
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(14, 48);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(52, 13);
            this.bosLabel5.TabIndex = 35;
            this.bosLabel5.Text = "Công đoạn";
            // 
            // fld_lkeFK_MMBatchProductItemID
            // 
            this.fld_lkeFK_MMBatchProductItemID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductItemID.BOSAllowDummy = false;
            this.fld_lkeFK_MMBatchProductItemID.BOSComment = null;
            this.fld_lkeFK_MMBatchProductItemID.BOSDataMember = "FK_MMBatchProductItemID";
            this.fld_lkeFK_MMBatchProductItemID.BOSDataSource = "ICReceiptItems";
            this.fld_lkeFK_MMBatchProductItemID.BOSDescription = null;
            this.fld_lkeFK_MMBatchProductItemID.BOSError = "";
            this.fld_lkeFK_MMBatchProductItemID.BOSFieldGroup = null;
            this.fld_lkeFK_MMBatchProductItemID.BOSFieldParent = null;
            this.fld_lkeFK_MMBatchProductItemID.BOSFieldRelation = null;
            this.fld_lkeFK_MMBatchProductItemID.BOSPrivilege = null;
            this.fld_lkeFK_MMBatchProductItemID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMBatchProductItemID.BOSSelectType = "BatchProductType";
            this.fld_lkeFK_MMBatchProductItemID.BOSSelectTypeValue = "LumberProduct";
            this.fld_lkeFK_MMBatchProductItemID.CurrentDisplayText = null;
            this.fld_lkeFK_MMBatchProductItemID.Location = new System.Drawing.Point(91, 71);
            this.fld_lkeFK_MMBatchProductItemID.Name = "fld_lkeFK_MMBatchProductItemID";
            this.fld_lkeFK_MMBatchProductItemID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeFK_MMBatchProductItemID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMBatchProductItemID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMBatchProductItemID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMBatchProductItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMBatchProductItemID.Properties.ColumnName = null;
            this.fld_lkeFK_MMBatchProductItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductItemProductNo", "Mã thành phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductItemProductName", "Tên thành phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductItemProductDesc", "Mô tả"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductItemProductSerial", "Mã lô SX")});
            this.fld_lkeFK_MMBatchProductItemID.Properties.DisplayMember = "MMBatchProductItemProductSerial";
            this.fld_lkeFK_MMBatchProductItemID.Properties.NullText = "";
            this.fld_lkeFK_MMBatchProductItemID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMBatchProductItemID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMBatchProductItemID.Properties.ValueMember = "MMBatchProductItemID";
            this.fld_lkeFK_MMBatchProductItemID.Screen = null;
            this.fld_lkeFK_MMBatchProductItemID.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeFK_MMBatchProductItemID.TabIndex = 547;
            this.fld_lkeFK_MMBatchProductItemID.Tag = "DC";
            this.fld_lkeFK_MMBatchProductItemID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_MMBatchProductItemID_QueryPopUp);
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = "";
            this.bosLabel4.BOSDataSource = "";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(14, 75);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(56, 13);
            this.bosLabel4.TabIndex = 546;
            this.bosLabel4.Text = "Lô sản xuất";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(14, 22);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(68, 13);
            this.bosLabel3.TabIndex = 545;
            this.bosLabel3.Text = "Lệnh sản xuất";
            // 
            // fld_lkeFK_MMBatchProductTargetID
            // 
            this.fld_lkeFK_MMBatchProductTargetID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductTargetID.BOSAllowDummy = false;
            this.fld_lkeFK_MMBatchProductTargetID.BOSComment = null;
            this.fld_lkeFK_MMBatchProductTargetID.BOSDataMember = "FK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductTargetID.BOSDataSource = "ICReceiptItems";
            this.fld_lkeFK_MMBatchProductTargetID.BOSDescription = null;
            this.fld_lkeFK_MMBatchProductTargetID.BOSError = "";
            this.fld_lkeFK_MMBatchProductTargetID.BOSFieldGroup = null;
            this.fld_lkeFK_MMBatchProductTargetID.BOSFieldParent = null;
            this.fld_lkeFK_MMBatchProductTargetID.BOSFieldRelation = null;
            this.fld_lkeFK_MMBatchProductTargetID.BOSPrivilege = null;
            this.fld_lkeFK_MMBatchProductTargetID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMBatchProductTargetID.BOSSelectType = "BatchProductType";
            this.fld_lkeFK_MMBatchProductTargetID.BOSSelectTypeValue = "LumberProduct";
            this.fld_lkeFK_MMBatchProductTargetID.CurrentDisplayText = null;
            this.fld_lkeFK_MMBatchProductTargetID.Location = new System.Drawing.Point(91, 18);
            this.fld_lkeFK_MMBatchProductTargetID.Name = "fld_lkeFK_MMBatchProductTargetID";
            this.fld_lkeFK_MMBatchProductTargetID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeFK_MMBatchProductTargetID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMBatchProductTargetID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMBatchProductTargetID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMBatchProductTargetID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMBatchProductTargetID.Properties.ColumnName = null;
            this.fld_lkeFK_MMBatchProductTargetID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã")});
            this.fld_lkeFK_MMBatchProductTargetID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeFK_MMBatchProductTargetID.Properties.NullText = "";
            this.fld_lkeFK_MMBatchProductTargetID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMBatchProductTargetID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMBatchProductTargetID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeFK_MMBatchProductTargetID.Screen = null;
            this.fld_lkeFK_MMBatchProductTargetID.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeFK_MMBatchProductTargetID.TabIndex = 544;
            this.fld_lkeFK_MMBatchProductTargetID.Tag = "DC";
            this.fld_lkeFK_MMBatchProductTargetID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMBatchProductTargetID_CloseUp);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.fld_dgcICReceiptItemsGridControl);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(5, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 447);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách nhập kho";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.fld_dgcICShipmentItemsGridControl);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(52, 121);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(520, 444);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách lựa chọn";
            // 
            // fld_dgcICShipmentItemsGridControl
            // 
            this.fld_dgcICShipmentItemsGridControl.BOSComment = null;
            this.fld_dgcICShipmentItemsGridControl.BOSDataMember = null;
            this.fld_dgcICShipmentItemsGridControl.BOSDataSource = "ICShipmentItems";
            this.fld_dgcICShipmentItemsGridControl.BOSDescription = null;
            this.fld_dgcICShipmentItemsGridControl.BOSError = null;
            this.fld_dgcICShipmentItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcICShipmentItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcICShipmentItemsGridControl.BOSGridType = null;
            this.fld_dgcICShipmentItemsGridControl.BOSPrivilege = null;
            this.fld_dgcICShipmentItemsGridControl.BOSPropertyName = null;
            this.fld_dgcICShipmentItemsGridControl.CommodityType = "";
            this.fld_dgcICShipmentItemsGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcICShipmentItemsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICShipmentItemsGridControl.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcICShipmentItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcICShipmentItemsGridControl.Name = "fld_dgcICShipmentItemsGridControl";
            this.fld_dgcICShipmentItemsGridControl.PrintReport = false;
            this.fld_dgcICShipmentItemsGridControl.Screen = null;
            this.fld_dgcICShipmentItemsGridControl.Size = new System.Drawing.Size(514, 424);
            this.fld_dgcICShipmentItemsGridControl.TabIndex = 11;
            this.fld_dgcICShipmentItemsGridControl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_dgcICShipmentItemsGridControl_KeyUp);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.Location = new System.Drawing.Point(3, 3);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.fld_btnAllocationQty);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1093, 571);
            this.splitContainerControl1.SplitterPosition = 504;
            this.splitContainerControl1.TabIndex = 15;
            // 
            // fld_btnAllocationQty
            // 
            this.fld_btnAllocationQty.Location = new System.Drawing.Point(2, 138);
            this.fld_btnAllocationQty.Name = "fld_btnAllocationQty";
            this.fld_btnAllocationQty.Size = new System.Drawing.Size(44, 30);
            this.fld_btnAllocationQty.TabIndex = 15;
            this.fld_btnAllocationQty.Text = ">>";
            this.fld_btnAllocationQty.Click += new System.EventHandler(this.fld_btnAllocationQty_Click);
            // 
            // guiChooseItemOutsourcing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 617);
            this.ControlBox = true;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.fld_btnSelect);
            this.Controls.Add(this.fld_btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiChooseItemOutsourcing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiến thông tin";
            this.Load += new System.EventHandler(this.guiChooseReceiptItems_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_btnSelect, 0);
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptItemsGridControl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICReceiptID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMReceiveOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductTargetID.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductTargetID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductItemID;
        private BOSComponent.BOSLabel bosLabel5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton fld_btnAllocationQty;
        private ICShipmentItemPreviewGridControl fld_dgcICShipmentItemsGridControl;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMReceiveOperationID;
    }
}