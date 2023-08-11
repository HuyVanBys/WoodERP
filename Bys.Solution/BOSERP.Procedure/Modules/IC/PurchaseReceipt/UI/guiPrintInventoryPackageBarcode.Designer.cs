namespace BOSERP.Modules.PurchaseReceipt
{
    partial class guiPrintInventoryPackageBarcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiPrintInventoryPackageBarcode));
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICInventoryItemPackages = new BOSERP.Modules.PurchaseReceipt.ICInventoryItemPackagesGridControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeFK_ICProductSerieID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductID2 = new BOSERP.ItemLookupEdit(this.components);
            this.fld_lkeFK_ICStockID2 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_Lablel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_chkSellectAll = new BOSComponent.BOSCheckEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICInventoryItemPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductSerieID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSellectAll.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.fld_btnClose.Location = new System.Drawing.Point(800, 490);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 5;
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
            this.fld_btnPrint.Location = new System.Drawing.Point(719, 490);
            this.fld_btnPrint.Name = "fld_btnPrint";
            this.fld_btnPrint.Screen = null;
            this.fld_btnPrint.Size = new System.Drawing.Size(75, 27);
            this.fld_btnPrint.TabIndex = 4;
            this.fld_btnPrint.Text = "In";
            this.fld_btnPrint.Click += new System.EventHandler(this.fld_btnPrint_Click);
            // 
            // fld_dgcICInventoryItemPackages
            // 
            this.fld_dgcICInventoryItemPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICInventoryItemPackages.BOSComment = null;
            this.fld_dgcICInventoryItemPackages.BOSDataMember = null;
            this.fld_dgcICInventoryItemPackages.BOSDataSource = "ICInventoryItemPackages";
            this.fld_dgcICInventoryItemPackages.BOSDescription = null;
            this.fld_dgcICInventoryItemPackages.BOSError = null;
            this.fld_dgcICInventoryItemPackages.BOSFieldGroup = null;
            this.fld_dgcICInventoryItemPackages.BOSFieldRelation = null;
            this.fld_dgcICInventoryItemPackages.BOSGridType = null;
            this.fld_dgcICInventoryItemPackages.BOSPrivilege = null;
            this.fld_dgcICInventoryItemPackages.BOSPropertyName = null;
            this.fld_dgcICInventoryItemPackages.Location = new System.Drawing.Point(0, 52);
            this.fld_dgcICInventoryItemPackages.MenuManager = this.screenToolbar;
            this.fld_dgcICInventoryItemPackages.Name = "fld_dgcICInventoryItemPackages";
            this.fld_dgcICInventoryItemPackages.PrintReport = false;
            this.fld_dgcICInventoryItemPackages.Screen = null;
            this.fld_dgcICInventoryItemPackages.Size = new System.Drawing.Size(888, 427);
            this.fld_dgcICInventoryItemPackages.TabIndex = 2;
            this.fld_dgcICInventoryItemPackages.Tag = "DC";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_lkeFK_ICProductSerieID);
            this.panelControl1.Controls.Add(this.bosLabel2);
            this.panelControl1.Controls.Add(this.bosLabel1);
            this.panelControl1.Controls.Add(this.fld_lkeFK_ICProductID2);
            this.panelControl1.Controls.Add(this.fld_lkeFK_ICStockID2);
            this.panelControl1.Controls.Add(this.fld_Lablel3);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(887, 46);
            this.panelControl1.TabIndex = 35;
            // 
            // fld_lkeFK_ICProductSerieID
            // 
            this.fld_lkeFK_ICProductSerieID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductSerieID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductSerieID.BOSComment = null;
            this.fld_lkeFK_ICProductSerieID.BOSDataMember = "FK_ICProductSerieID";
            this.fld_lkeFK_ICProductSerieID.BOSDataSource = "ICInventoryItemPackages";
            this.fld_lkeFK_ICProductSerieID.BOSDescription = null;
            this.fld_lkeFK_ICProductSerieID.BOSError = string.Empty;
            this.fld_lkeFK_ICProductSerieID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductSerieID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductSerieID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductSerieID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductSerieID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductSerieID.BOSSelectType = null;
            this.fld_lkeFK_ICProductSerieID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductSerieID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductSerieID.Location = new System.Drawing.Point(456, 12);
            this.fld_lkeFK_ICProductSerieID.Name = "fld_lkeFK_ICProductSerieID";
            this.fld_lkeFK_ICProductSerieID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductSerieID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductSerieID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductSerieID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductSerieID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductSerieID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductSerieNo", "Mã lô")});
            this.fld_lkeFK_ICProductSerieID.Properties.DisplayMember = "ICProductSerieNo";
            this.fld_lkeFK_ICProductSerieID.Properties.NullText = string.Empty;
            this.fld_lkeFK_ICProductSerieID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductSerieID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductSerieID.Properties.ValueMember = "ICProductSerieID";
            this.fld_lkeFK_ICProductSerieID.Screen = null;
            this.fld_lkeFK_ICProductSerieID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICProductSerieID.TabIndex = 487;
            this.fld_lkeFK_ICProductSerieID.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = string.Empty;
            this.bosLabel2.BOSDataSource = string.Empty;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = string.Empty;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(439, 15);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(11, 13);
            this.bosLabel2.TabIndex = 488;
            this.bosLabel2.Text = "Lô";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = string.Empty;
            this.bosLabel1.BOSDataSource = string.Empty;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = string.Empty;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(196, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(47, 13);
            this.bosLabel1.TabIndex = 486;
            this.bosLabel1.Text = "Sản phẩm";
            // 
            // fld_lkeFK_ICProductID2
            // 
            this.fld_lkeFK_ICProductID2.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID2.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductID2.BOSComment = null;
            this.fld_lkeFK_ICProductID2.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID2.BOSDataSource = "ICInventoryItemPackages";
            this.fld_lkeFK_ICProductID2.BOSDescription = null;
            this.fld_lkeFK_ICProductID2.BOSError = null;
            this.fld_lkeFK_ICProductID2.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductID2.BOSFieldParent = null;
            this.fld_lkeFK_ICProductID2.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductID2.BOSPrivilege = null;
            this.fld_lkeFK_ICProductID2.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID2.BOSSelectType = null;
            this.fld_lkeFK_ICProductID2.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductID2.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID2.Location = new System.Drawing.Point(249, 12);
            this.fld_lkeFK_ICProductID2.Name = "fld_lkeFK_ICProductID2";
            this.fld_lkeFK_ICProductID2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Style No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Own Style No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Desc.")});
            this.fld_lkeFK_ICProductID2.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID2.Properties.NullText = string.Empty;
            this.fld_lkeFK_ICProductID2.Properties.PopupWidth = 60;
            this.fld_lkeFK_ICProductID2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID2.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID2.Screen = null;
            this.fld_lkeFK_ICProductID2.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_ICProductID2.TabIndex = 485;
            this.fld_lkeFK_ICProductID2.Tag = "DC";
            // 
            // fld_lkeFK_ICStockID2
            // 
            this.fld_lkeFK_ICStockID2.BOSAllowAddNew = false;
            this.fld_lkeFK_ICStockID2.BOSAllowDummy = false;
            this.fld_lkeFK_ICStockID2.BOSComment = null;
            this.fld_lkeFK_ICStockID2.BOSDataMember = "FK_ICStockID";
            this.fld_lkeFK_ICStockID2.BOSDataSource = "ICInventoryItemPackages";
            this.fld_lkeFK_ICStockID2.BOSDescription = null;
            this.fld_lkeFK_ICStockID2.BOSError = string.Empty;
            this.fld_lkeFK_ICStockID2.BOSFieldGroup = null;
            this.fld_lkeFK_ICStockID2.BOSFieldParent = null;
            this.fld_lkeFK_ICStockID2.BOSFieldRelation = null;
            this.fld_lkeFK_ICStockID2.BOSPrivilege = null;
            this.fld_lkeFK_ICStockID2.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICStockID2.BOSSelectType = null;
            this.fld_lkeFK_ICStockID2.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICStockID2.CurrentDisplayText = null;
            this.fld_lkeFK_ICStockID2.Location = new System.Drawing.Point(40, 12);
            this.fld_lkeFK_ICStockID2.Name = "fld_lkeFK_ICStockID2";
            this.fld_lkeFK_ICStockID2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICStockID2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICStockID2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICStockID2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICStockID2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICStockID2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "No"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Name")});
            this.fld_lkeFK_ICStockID2.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICStockID2.Properties.NullText = string.Empty;
            this.fld_lkeFK_ICStockID2.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICStockID2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICStockID2.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICStockID2.Screen = null;
            this.fld_lkeFK_ICStockID2.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICStockID2.TabIndex = 483;
            this.fld_lkeFK_ICStockID2.Tag = "DC";
            // 
            // fld_Lablel3
            // 
            this.fld_Lablel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel3.Appearance.Options.UseBackColor = true;
            this.fld_Lablel3.Appearance.Options.UseForeColor = true;
            this.fld_Lablel3.BOSComment = null;
            this.fld_Lablel3.BOSDataMember = string.Empty;
            this.fld_Lablel3.BOSDataSource = string.Empty;
            this.fld_Lablel3.BOSDescription = null;
            this.fld_Lablel3.BOSError = null;
            this.fld_Lablel3.BOSFieldGroup = string.Empty;
            this.fld_Lablel3.BOSFieldRelation = null;
            this.fld_Lablel3.BOSPrivilege = null;
            this.fld_Lablel3.BOSPropertyName = null;
            this.fld_Lablel3.Location = new System.Drawing.Point(16, 15);
            this.fld_Lablel3.Name = "fld_Lablel3";
            this.fld_Lablel3.Screen = null;
            this.fld_Lablel3.Size = new System.Drawing.Size(18, 13);
            this.fld_Lablel3.TabIndex = 484;
            this.fld_Lablel3.Text = "Kho";
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
            this.fld_btnApply.Location = new System.Drawing.Point(621, 6);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(94, 27);
            this.fld_btnApply.TabIndex = 1;
            this.fld_btnApply.Text = "Tìm kiện";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_chkSellectAll
            // 
            this.fld_chkSellectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_chkSellectAll.BOSComment = null;
            this.fld_chkSellectAll.BOSDataMember = null;
            this.fld_chkSellectAll.BOSDataSource = null;
            this.fld_chkSellectAll.BOSDescription = null;
            this.fld_chkSellectAll.BOSError = null;
            this.fld_chkSellectAll.BOSFieldGroup = null;
            this.fld_chkSellectAll.BOSFieldRelation = null;
            this.fld_chkSellectAll.BOSPrivilege = null;
            this.fld_chkSellectAll.BOSPropertyName = null;
            this.fld_chkSellectAll.Location = new System.Drawing.Point(12, 494);
            this.fld_chkSellectAll.MenuManager = this.screenToolbar;
            this.fld_chkSellectAll.Name = "fld_chkSellectAll";
            this.fld_chkSellectAll.Properties.Caption = "Chọn tất cả";
            this.fld_chkSellectAll.Screen = null;
            this.fld_chkSellectAll.Size = new System.Drawing.Size(144, 19);
            this.fld_chkSellectAll.TabIndex = 3;
            this.fld_chkSellectAll.Tag = "DC";
            this.fld_chkSellectAll.CheckedChanged += new System.EventHandler(this.fld_chkSellectAll_CheckedChanged);
            // 
            // guiPrintInventoryPackageBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 525);
            this.ControlBox = true;
            this.Controls.Add(this.fld_chkSellectAll);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.fld_dgcICInventoryItemPackages);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnPrint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiPrintInventoryPackageBarcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In mã vạch kiện theo tồn kho";
            this.Load += new System.EventHandler(this.guiPrintInventoryPackageBarcode_Load);
            this.Controls.SetChildIndex(this.fld_btnPrint, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcICInventoryItemPackages, 0);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_chkSellectAll, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICInventoryItemPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductSerieID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSellectAll.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnPrint;
        private ICInventoryItemPackagesGridControl fld_dgcICInventoryItemPackages;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSCheckEdit fld_chkSellectAll;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID2;
        private BOSComponent.BOSLabel fld_Lablel3;
        private BOSComponent.BOSLabel bosLabel1;
        private ItemLookupEdit fld_lkeFK_ICProductID2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductSerieID;
        private BOSComponent.BOSLabel bosLabel2;
    }
}