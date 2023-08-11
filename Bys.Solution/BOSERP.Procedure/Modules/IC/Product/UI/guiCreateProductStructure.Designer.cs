namespace BOSERP.Modules.Product.UI
{
    partial class guiCreateProductStructure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiCreateProductStructure));
            this.fld_dgcSemiProduct1 = new BOSERP.Modules.Product.ProductItemsGridControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fld_lkeICProductID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtQty = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnSaveProductionNormItemMeterial = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICProductItemMaterials = new BOSERP.Modules.Product.ICProductItemMaterialsGridControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMProcessID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcICProductItemProcesss = new BOSERP.Modules.Product.ICProductItemProcesssGridControl();
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSemiProduct1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductItemMaterials)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProcessID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductItemProcesss)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcSemiProduct1
            // 
            this.fld_dgcSemiProduct1.BOSComment = null;
            this.fld_dgcSemiProduct1.BOSDataMember = null;
            this.fld_dgcSemiProduct1.BOSDataSource = "ICProducts";
            this.fld_dgcSemiProduct1.BOSDescription = null;
            this.fld_dgcSemiProduct1.BOSError = null;
            this.fld_dgcSemiProduct1.BOSFieldGroup = null;
            this.fld_dgcSemiProduct1.BOSFieldRelation = null;
            this.fld_dgcSemiProduct1.BOSGridType = null;
            this.fld_dgcSemiProduct1.BOSPrivilege = null;
            this.fld_dgcSemiProduct1.BOSPropertyName = null;
            this.fld_dgcSemiProduct1.CommodityType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcSemiProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcSemiProduct1.Location = new System.Drawing.Point(0, 47);
            this.fld_dgcSemiProduct1.MenuManager = this.screenToolbar;
            this.fld_dgcSemiProduct1.Name = "fld_dgcSemiProduct1";
            this.fld_dgcSemiProduct1.PrintReport = false;
            this.fld_dgcSemiProduct1.Screen = null;
            this.fld_dgcSemiProduct1.Size = new System.Drawing.Size(1000, 435);
            this.fld_dgcSemiProduct1.TabIndex = 402;
            this.fld_dgcSemiProduct1.Tag = "DC";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fld_lkeICProductID1);
            this.panel2.Controls.Add(this.fld_txtQty);
            this.panel2.Controls.Add(this.bosLabel1);
            this.panel2.Controls.Add(this.bosLabel4);
            this.panel2.Controls.Add(this.fld_btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 47);
            this.panel2.TabIndex = 403;
            // 
            // fld_lkeICProductID1
            // 
            this.fld_lkeICProductID1.BOSAllowAddNew = false;
            this.fld_lkeICProductID1.BOSAllowDummy = true;
            this.fld_lkeICProductID1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeICProductID1.BOSDataMember = "ICProductID";
            this.fld_lkeICProductID1.BOSDataSource = "ICProducts";
            this.fld_lkeICProductID1.BOSDescription = null;
            this.fld_lkeICProductID1.BOSError = null;
            this.fld_lkeICProductID1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeICProductID1.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeICProductID1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeICProductID1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeICProductID1.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeICProductID1.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeICProductID1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeICProductID1.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeICProductID1.Enabled = false;
            this.fld_lkeICProductID1.Location = new System.Drawing.Point(108, 12);
            this.fld_lkeICProductID1.Name = "fld_lkeICProductID1";
            this.fld_lkeICProductID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICProductID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICProductID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICProductID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên")});
            this.fld_lkeICProductID1.Properties.DisplayMember = "ICProductName";
            this.fld_lkeICProductID1.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeICProductID1.Properties.ReadOnly = true;
            this.fld_lkeICProductID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductID1.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductID1, true);
            this.fld_lkeICProductID1.Size = new System.Drawing.Size(379, 20);
            this.fld_lkeICProductID1.TabIndex = 410;
            this.fld_lkeICProductID1.Tag = "DC";
            // 
            // fld_txtQty
            // 
            this.fld_txtQty.BOSComment = null;
            this.fld_txtQty.BOSDataMember = null;
            this.fld_txtQty.BOSDataSource = null;
            this.fld_txtQty.BOSDescription = null;
            this.fld_txtQty.BOSError = null;
            this.fld_txtQty.BOSFieldGroup = null;
            this.fld_txtQty.BOSFieldRelation = null;
            this.fld_txtQty.BOSPrivilege = null;
            this.fld_txtQty.BOSPropertyName = null;
            this.fld_txtQty.Location = new System.Drawing.Point(541, 12);
            this.fld_txtQty.MenuManager = this.screenToolbar;
            this.fld_txtQty.Name = "fld_txtQty";
            this.fld_txtQty.Properties.DisplayFormat.FormatString = "n0";
            this.fld_txtQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtQty.Properties.EditFormat.FormatString = "n0";
            this.fld_txtQty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtQty.Properties.Mask.BeepOnError = true;
            this.fld_txtQty.Properties.Mask.EditMask = "n0";
            this.fld_txtQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtQty.Screen = null;
            this.fld_txtQty.Size = new System.Drawing.Size(129, 20);
            this.fld_txtQty.TabIndex = 401;
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
            this.bosLabel1.Location = new System.Drawing.Point(493, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(42, 13);
            this.bosLabel1.TabIndex = 400;
            this.bosLabel1.Text = "Số lượng";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(13, 15);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(65, 13);
            this.bosLabel4.TabIndex = 399;
            this.bosLabel4.Text = "Cụm / Chi tiết";
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(700, 9);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(86, 27);
            this.fld_btnSave.TabIndex = 3;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosTabControl1.Location = new System.Drawing.Point(0, 0);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(1007, 511);
            this.bosTabControl1.TabIndex = 405;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcSemiProduct1);
            this.xtraTabPage1.Controls.Add(this.panel2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1000, 482);
            this.xtraTabPage1.Text = "Tạo cây định mức";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_btnSaveProductionNormItemMeterial);
            this.xtraTabPage2.Controls.Add(this.fld_dgcICProductItemMaterials);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.PageVisible = false;
            this.xtraTabPage2.Size = new System.Drawing.Size(1000, 482);
            this.xtraTabPage2.Text = "Nguyên liệu sử dụng";
            // 
            // fld_btnSaveProductionNormItemMeterial
            // 
            this.fld_btnSaveProductionNormItemMeterial.BOSComment = null;
            this.fld_btnSaveProductionNormItemMeterial.BOSDataMember = null;
            this.fld_btnSaveProductionNormItemMeterial.BOSDataSource = null;
            this.fld_btnSaveProductionNormItemMeterial.BOSDescription = null;
            this.fld_btnSaveProductionNormItemMeterial.BOSError = null;
            this.fld_btnSaveProductionNormItemMeterial.BOSFieldGroup = null;
            this.fld_btnSaveProductionNormItemMeterial.BOSFieldRelation = null;
            this.fld_btnSaveProductionNormItemMeterial.BOSPrivilege = null;
            this.fld_btnSaveProductionNormItemMeterial.BOSPropertyName = null;
            this.fld_btnSaveProductionNormItemMeterial.Location = new System.Drawing.Point(3, 5);
            this.fld_btnSaveProductionNormItemMeterial.Name = "fld_btnSaveProductionNormItemMeterial";
            this.fld_btnSaveProductionNormItemMeterial.Screen = null;
            this.fld_btnSaveProductionNormItemMeterial.Size = new System.Drawing.Size(86, 27);
            this.fld_btnSaveProductionNormItemMeterial.TabIndex = 404;
            this.fld_btnSaveProductionNormItemMeterial.Text = "Lưu";
            this.fld_btnSaveProductionNormItemMeterial.Click += new System.EventHandler(this.fld_btnSaveProductionNormItemMeterial_Click);
            // 
            // fld_dgcICProductItemMaterials
            // 
            this.fld_dgcICProductItemMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductItemMaterials.BOSComment = null;
            this.fld_dgcICProductItemMaterials.BOSDataMember = null;
            this.fld_dgcICProductItemMaterials.BOSDataSource = "ICProductItemMaterials";
            this.fld_dgcICProductItemMaterials.BOSDescription = null;
            this.fld_dgcICProductItemMaterials.BOSError = null;
            this.fld_dgcICProductItemMaterials.BOSFieldGroup = null;
            this.fld_dgcICProductItemMaterials.BOSFieldRelation = null;
            this.fld_dgcICProductItemMaterials.BOSGridType = null;
            this.fld_dgcICProductItemMaterials.BOSPrivilege = null;
            this.fld_dgcICProductItemMaterials.BOSPropertyName = null;
            this.fld_dgcICProductItemMaterials.CommodityType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICProductItemMaterials.Location = new System.Drawing.Point(0, 38);
            this.fld_dgcICProductItemMaterials.MenuManager = this.screenToolbar;
            this.fld_dgcICProductItemMaterials.Name = "fld_dgcICProductItemMaterials";
            this.fld_dgcICProductItemMaterials.PrintReport = false;
            this.fld_dgcICProductItemMaterials.Screen = null;
            this.fld_dgcICProductItemMaterials.Size = new System.Drawing.Size(1000, 444);
            this.fld_dgcICProductItemMaterials.TabIndex = 403;
            this.fld_dgcICProductItemMaterials.Tag = "DC";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.bosLabel2);
            this.xtraTabPage3.Controls.Add(this.fld_lkeMMProcessID);
            this.xtraTabPage3.Controls.Add(this.bosLabel3);
            this.xtraTabPage3.Controls.Add(this.fld_lkeMMOperationID);
            this.xtraTabPage3.Controls.Add(this.fld_dgcICProductItemProcesss);
            this.xtraTabPage3.Controls.Add(this.bosButton2);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.PageVisible = false;
            this.xtraTabPage3.Size = new System.Drawing.Size(1000, 482);
            this.xtraTabPage3.Text = "Quy trình sản xuất";
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
            this.bosLabel2.Location = new System.Drawing.Point(7, 15);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(90, 13);
            this.bosLabel2.TabIndex = 408;
            this.bosLabel2.Text = "Quy trình sản xuất";
            // 
            // fld_lkeMMProcessID
            // 
            this.fld_lkeMMProcessID.BOSAllowAddNew = false;
            this.fld_lkeMMProcessID.BOSAllowDummy = true;
            this.fld_lkeMMProcessID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeMMProcessID.BOSDataMember = "MMProcessID";
            this.fld_lkeMMProcessID.BOSDataSource = "MMProcesss";
            this.fld_lkeMMProcessID.BOSDescription = null;
            this.fld_lkeMMProcessID.BOSError = null;
            this.fld_lkeMMProcessID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeMMProcessID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeMMProcessID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeMMProcessID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeMMProcessID.BOSPropertyName = "EditValue";
            this.fld_lkeMMProcessID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeMMProcessID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeMMProcessID.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeMMProcessID.Location = new System.Drawing.Point(103, 12);
            this.fld_lkeMMProcessID.Name = "fld_lkeMMProcessID";
            this.fld_lkeMMProcessID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMProcessID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProcessID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProcessID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProcessID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProcessID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProcessNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProcessName", "Tên")});
            this.fld_lkeMMProcessID.Properties.DisplayMember = "MMProcessName";
            this.fld_lkeMMProcessID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeMMProcessID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProcessID.Properties.ValueMember = "MMProcessID";
            this.fld_lkeMMProcessID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMProcessID, true);
            this.fld_lkeMMProcessID.Size = new System.Drawing.Size(200, 20);
            this.fld_lkeMMProcessID.TabIndex = 409;
            this.fld_lkeMMProcessID.Tag = "DC";
            this.fld_lkeMMProcessID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeMMProcessID_KeyUp);
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
            this.bosLabel3.Location = new System.Drawing.Point(7, 41);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(52, 13);
            this.bosLabel3.TabIndex = 405;
            this.bosLabel3.Text = "Công đoạn";
            // 
            // fld_lkeMMOperationID
            // 
            this.fld_lkeMMOperationID.BOSAllowAddNew = false;
            this.fld_lkeMMOperationID.BOSAllowDummy = false;
            this.fld_lkeMMOperationID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeMMOperationID.BOSDataMember = "MMOperationID";
            this.fld_lkeMMOperationID.BOSDataSource = "MMOperations";
            this.fld_lkeMMOperationID.BOSDescription = null;
            this.fld_lkeMMOperationID.BOSError = null;
            this.fld_lkeMMOperationID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeMMOperationID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeMMOperationID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeMMOperationID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeMMOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeMMOperationID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeMMOperationID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeMMOperationID.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeMMOperationID.Location = new System.Drawing.Point(103, 38);
            this.fld_lkeMMOperationID.Name = "fld_lkeMMOperationID";
            this.fld_lkeMMOperationID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMOperationID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMOperationID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMOperationID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên")});
            this.fld_lkeMMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeMMOperationID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeMMOperationID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeMMOperationID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMOperationID, true);
            this.fld_lkeMMOperationID.Size = new System.Drawing.Size(200, 20);
            this.fld_lkeMMOperationID.TabIndex = 406;
            this.fld_lkeMMOperationID.Tag = "DC";
            this.fld_lkeMMOperationID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeMMOperationID_KeyUp);
            // 
            // fld_dgcICProductItemProcesss
            // 
            this.fld_dgcICProductItemProcesss.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductItemProcesss.BOSComment = null;
            this.fld_dgcICProductItemProcesss.BOSDataMember = null;
            this.fld_dgcICProductItemProcesss.BOSDataSource = "ICProductItemProcesss";
            this.fld_dgcICProductItemProcesss.BOSDescription = null;
            this.fld_dgcICProductItemProcesss.BOSError = null;
            this.fld_dgcICProductItemProcesss.BOSFieldGroup = null;
            this.fld_dgcICProductItemProcesss.BOSFieldRelation = null;
            this.fld_dgcICProductItemProcesss.BOSGridType = null;
            this.fld_dgcICProductItemProcesss.BOSPrivilege = null;
            this.fld_dgcICProductItemProcesss.BOSPropertyName = null;
            this.fld_dgcICProductItemProcesss.CommodityType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICProductItemProcesss.Location = new System.Drawing.Point(0, 66);
            this.fld_dgcICProductItemProcesss.MenuManager = this.screenToolbar;
            this.fld_dgcICProductItemProcesss.Name = "fld_dgcICProductItemProcesss";
            this.fld_dgcICProductItemProcesss.PrintReport = false;
            this.fld_dgcICProductItemProcesss.Screen = null;
            this.fld_dgcICProductItemProcesss.Size = new System.Drawing.Size(1000, 416);
            this.fld_dgcICProductItemProcesss.TabIndex = 404;
            this.fld_dgcICProductItemProcesss.Tag = "DC";
            // 
            // bosButton2
            // 
            this.bosButton2.BOSComment = null;
            this.bosButton2.BOSDataMember = null;
            this.bosButton2.BOSDataSource = null;
            this.bosButton2.BOSDescription = null;
            this.bosButton2.BOSError = null;
            this.bosButton2.BOSFieldGroup = null;
            this.bosButton2.BOSFieldRelation = null;
            this.bosButton2.BOSPrivilege = null;
            this.bosButton2.BOSPropertyName = null;
            this.bosButton2.Location = new System.Drawing.Point(309, 33);
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = null;
            this.bosButton2.Size = new System.Drawing.Size(86, 27);
            this.bosButton2.TabIndex = 4;
            this.bosButton2.Text = "Lưu";
            this.bosButton2.Click += new System.EventHandler(this.bosButton2_Click);
            // 
            // guiCreateProductStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 511);
            this.ControlBox = true;
            this.Controls.Add(this.bosTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiCreateProductStructure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Thêm Cụm / Chi tiết";
            this.Load += new System.EventHandler(this.guiCreateProductStructure_Load);
            this.Controls.SetChildIndex(this.bosTabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSemiProduct1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductItemMaterials)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProcessID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductItemProcesss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProductItemsGridControl fld_dgcSemiProduct1;
        private System.Windows.Forms.Panel panel2;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSButton fld_btnSave;
        private BOSComponent.BOSTextBox fld_txtQty;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private ICProductItemMaterialsGridControl fld_dgcICProductItemMaterials;
        private BOSComponent.BOSButton fld_btnSaveProductionNormItemMeterial;
        private BOSComponent.BOSButton bosButton2;
        private ICProductItemProcesssGridControl fld_dgcICProductItemProcesss;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeMMOperationID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeMMProcessID;
        private BOSComponent.BOSLookupEdit fld_lkeICProductID1;
    }
}