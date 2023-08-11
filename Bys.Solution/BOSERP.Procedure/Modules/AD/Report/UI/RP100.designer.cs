namespace BOSERP.Modules.Report
{
    partial class RP100
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
            this.bosPanel1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_lkeARCustomerID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabRP100ProductionNorm = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabSemiProduct = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcWoodPlantItemDetail = new BOSERP.Modules.Report.RP100MMWoodPlantItemDetailGridControl();
            this.fld_tabHardware = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcRP100HardwareItems = new BOSERP.Modules.Report.RP100MMHardwareGridControl();
            this.fld_tabPackaging = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lkeRP100PackagingsItem = new BOSERP.Modules.Report.RP100MMPackagingsItemGridControl();
            this.fld_tabPaint = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lkeRP100PaintItems = new BOSERP.Modules.Report.RP100MMPaintItemsGridControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lkeRP100MMEquipmentItemsGridControl1 = new BOSERP.Modules.Report.RP100MMEquipmentItemDetailGridControl();
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnExportExcel = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_ARSaleOrderID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeMMBatchProductNo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabRP100ProductionNorm)).BeginInit();
            this.fld_tabRP100ProductionNorm.SuspendLayout();
            this.fld_tabSemiProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcWoodPlantItemDetail)).BeginInit();
            this.fld_tabHardware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP100HardwareItems)).BeginInit();
            this.fld_tabPackaging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeRP100PackagingsItem)).BeginInit();
            this.fld_tabPaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeRP100PaintItems)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeRP100MMEquipmentItemsGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bosPanel1
            // 
            this.bosPanel1.Controls.Add(this.fld_btnApply);
            this.bosPanel1.Controls.Add(this.fld_lkeARCustomerID1);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_tabRP100ProductionNorm);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.panelControl2);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARSaleOrderID);
            this.bosPanel1.Controls.Add(this.fld_lkeMMBatchProductNo);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.fld_dteSearchToDate);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_dteSearchFromDate);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.ScreenHelper.SetShowHelp(this.bosPanel1, true);
            this.bosPanel1.Size = new System.Drawing.Size(884, 562);
            this.bosPanel1.TabIndex = 9;
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
            this.fld_btnApply.Location = new System.Drawing.Point(779, 12);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnApply, true);
            this.fld_btnApply.Size = new System.Drawing.Size(84, 27);
            this.fld_btnApply.TabIndex = 24;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_lkeARCustomerID1
            // 
            this.fld_lkeARCustomerID1.BOSAllowAddNew = false;
            this.fld_lkeARCustomerID1.BOSAllowDummy = true;
            this.fld_lkeARCustomerID1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerID1.BOSDataMember = "ARCustomerID";
            this.fld_lkeARCustomerID1.BOSDataSource = "ARCustomers";
            this.fld_lkeARCustomerID1.BOSDescription = null;
            this.fld_lkeARCustomerID1.BOSError = null;
            this.fld_lkeARCustomerID1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerID1.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerID1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerID1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerID1.BOSPropertyName = "EditValue";
            this.fld_lkeARCustomerID1.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerID1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerID1.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerID1.Location = new System.Drawing.Point(74, 12);
            this.fld_lkeARCustomerID1.Name = "fld_lkeARCustomerID1";
            this.fld_lkeARCustomerID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARCustomerID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARCustomerID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARCustomerID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARCustomerID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCustomerID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên khách hàng")});
            this.fld_lkeARCustomerID1.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeARCustomerID1.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARCustomerID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARCustomerID1.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeARCustomerID1.Screen = null;
            this.fld_lkeARCustomerID1.Size = new System.Drawing.Size(151, 20);
            this.fld_lkeARCustomerID1.TabIndex = 361;
            this.fld_lkeARCustomerID1.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(505, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(68, 13);
            this.bosLabel1.TabIndex = 27;
            this.bosLabel1.Text = "Lệnh sản xuất";
            // 
            // fld_tabRP100ProductionNorm
            // 
            this.fld_tabRP100ProductionNorm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabRP100ProductionNorm.BOSComment = null;
            this.fld_tabRP100ProductionNorm.BOSDataMember = null;
            this.fld_tabRP100ProductionNorm.BOSDataSource = null;
            this.fld_tabRP100ProductionNorm.BOSDescription = null;
            this.fld_tabRP100ProductionNorm.BOSError = null;
            this.fld_tabRP100ProductionNorm.BOSFieldGroup = null;
            this.fld_tabRP100ProductionNorm.BOSFieldRelation = null;
            this.fld_tabRP100ProductionNorm.BOSPrivilege = null;
            this.fld_tabRP100ProductionNorm.BOSPropertyName = null;
            this.fld_tabRP100ProductionNorm.Location = new System.Drawing.Point(2, 64);
            this.fld_tabRP100ProductionNorm.Name = "fld_tabRP100ProductionNorm";
            this.fld_tabRP100ProductionNorm.Screen = null;
            this.fld_tabRP100ProductionNorm.SelectedTabPage = this.fld_tabSemiProduct;
            this.ScreenHelper.SetShowHelp(this.fld_tabRP100ProductionNorm, true);
            this.fld_tabRP100ProductionNorm.Size = new System.Drawing.Size(880, 447);
            this.fld_tabRP100ProductionNorm.TabIndex = 566;
            this.fld_tabRP100ProductionNorm.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabSemiProduct,
            this.fld_tabHardware,
            this.fld_tabPackaging,
            this.fld_tabPaint,
            this.xtraTabPage1});
            // 
            // fld_tabSemiProduct
            // 
            this.fld_tabSemiProduct.Controls.Add(this.fld_dgcWoodPlantItemDetail);
            this.fld_tabSemiProduct.Name = "fld_tabSemiProduct";
            this.ScreenHelper.SetShowHelp(this.fld_tabSemiProduct, true);
            this.fld_tabSemiProduct.Size = new System.Drawing.Size(873, 418);
            this.fld_tabSemiProduct.Text = "Gổ";
            // 
            // fld_dgcWoodPlantItemDetail
            // 
            this.fld_dgcWoodPlantItemDetail.BOSComment = null;
            this.fld_dgcWoodPlantItemDetail.BOSDataMember = null;
            this.fld_dgcWoodPlantItemDetail.BOSDataSource = "MMWoodPlanItemDetails";
            this.fld_dgcWoodPlantItemDetail.BOSDescription = null;
            this.fld_dgcWoodPlantItemDetail.BOSError = null;
            this.fld_dgcWoodPlantItemDetail.BOSFieldGroup = null;
            this.fld_dgcWoodPlantItemDetail.BOSFieldRelation = null;
            this.fld_dgcWoodPlantItemDetail.BOSGridType = null;
            this.fld_dgcWoodPlantItemDetail.BOSPrivilege = null;
            this.fld_dgcWoodPlantItemDetail.BOSPropertyName = null;
            this.fld_dgcWoodPlantItemDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcWoodPlantItemDetail.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.fld_dgcWoodPlantItemDetail.EmbeddedNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fld_dgcWoodPlantItemDetail.EmbeddedNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fld_dgcWoodPlantItemDetail.EmbeddedNavigator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fld_dgcWoodPlantItemDetail.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.None;
            this.fld_dgcWoodPlantItemDetail.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this.fld_dgcWoodPlantItemDetail.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcWoodPlantItemDetail.MenuManager = this.screenToolbar;
            this.fld_dgcWoodPlantItemDetail.Name = "fld_dgcWoodPlantItemDetail";
            this.fld_dgcWoodPlantItemDetail.PrintReport = false;
            this.fld_dgcWoodPlantItemDetail.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcWoodPlantItemDetail, false);
            this.fld_dgcWoodPlantItemDetail.Size = new System.Drawing.Size(873, 418);
            this.fld_dgcWoodPlantItemDetail.TabIndex = 1;
            // 
            // fld_tabHardware
            // 
            this.fld_tabHardware.Controls.Add(this.fld_dgcRP100HardwareItems);
            this.fld_tabHardware.Name = "fld_tabHardware";
            this.ScreenHelper.SetShowHelp(this.fld_tabHardware, true);
            this.fld_tabHardware.Size = new System.Drawing.Size(873, 418);
            this.fld_tabHardware.Text = "Hardware";
            // 
            // fld_dgcRP100HardwareItems
            // 
            this.fld_dgcRP100HardwareItems.BOSComment = null;
            this.fld_dgcRP100HardwareItems.BOSDataMember = null;
            this.fld_dgcRP100HardwareItems.BOSDataSource = "MMBatchProductProductionNormItems";
            this.fld_dgcRP100HardwareItems.BOSDescription = null;
            this.fld_dgcRP100HardwareItems.BOSError = null;
            this.fld_dgcRP100HardwareItems.BOSFieldGroup = null;
            this.fld_dgcRP100HardwareItems.BOSFieldRelation = null;
            this.fld_dgcRP100HardwareItems.BOSGridType = null;
            this.fld_dgcRP100HardwareItems.BOSPrivilege = null;
            this.fld_dgcRP100HardwareItems.BOSPropertyName = null;
            this.fld_dgcRP100HardwareItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcRP100HardwareItems.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.fld_dgcRP100HardwareItems.EmbeddedNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fld_dgcRP100HardwareItems.EmbeddedNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fld_dgcRP100HardwareItems.EmbeddedNavigator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fld_dgcRP100HardwareItems.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.None;
            this.fld_dgcRP100HardwareItems.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this.fld_dgcRP100HardwareItems.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcRP100HardwareItems.MenuManager = this.screenToolbar;
            this.fld_dgcRP100HardwareItems.Name = "fld_dgcRP100HardwareItems";
            this.fld_dgcRP100HardwareItems.PrintReport = false;
            this.fld_dgcRP100HardwareItems.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcRP100HardwareItems, false);
            this.fld_dgcRP100HardwareItems.Size = new System.Drawing.Size(873, 418);
            this.fld_dgcRP100HardwareItems.TabIndex = 2;
            // 
            // fld_tabPackaging
            // 
            this.fld_tabPackaging.Controls.Add(this.fld_lkeRP100PackagingsItem);
            this.fld_tabPackaging.Name = "fld_tabPackaging";
            this.fld_tabPackaging.Size = new System.Drawing.Size(873, 418);
            this.fld_tabPackaging.Text = "Phụ liệu đóng gói";
            // 
            // fld_lkeRP100PackagingsItem
            // 
            this.fld_lkeRP100PackagingsItem.BOSComment = null;
            this.fld_lkeRP100PackagingsItem.BOSDataMember = null;
            this.fld_lkeRP100PackagingsItem.BOSDataSource = "MMBatchProductProductionNormItems";
            this.fld_lkeRP100PackagingsItem.BOSDescription = null;
            this.fld_lkeRP100PackagingsItem.BOSError = null;
            this.fld_lkeRP100PackagingsItem.BOSFieldGroup = null;
            this.fld_lkeRP100PackagingsItem.BOSFieldRelation = null;
            this.fld_lkeRP100PackagingsItem.BOSGridType = null;
            this.fld_lkeRP100PackagingsItem.BOSPrivilege = null;
            this.fld_lkeRP100PackagingsItem.BOSPropertyName = null;
            this.fld_lkeRP100PackagingsItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_lkeRP100PackagingsItem.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.fld_lkeRP100PackagingsItem.EmbeddedNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fld_lkeRP100PackagingsItem.EmbeddedNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fld_lkeRP100PackagingsItem.EmbeddedNavigator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fld_lkeRP100PackagingsItem.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.None;
            this.fld_lkeRP100PackagingsItem.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this.fld_lkeRP100PackagingsItem.Location = new System.Drawing.Point(0, 0);
            this.fld_lkeRP100PackagingsItem.MenuManager = this.screenToolbar;
            this.fld_lkeRP100PackagingsItem.Name = "fld_lkeRP100PackagingsItem";
            this.fld_lkeRP100PackagingsItem.PrintReport = false;
            this.fld_lkeRP100PackagingsItem.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeRP100PackagingsItem, false);
            this.fld_lkeRP100PackagingsItem.Size = new System.Drawing.Size(873, 418);
            this.fld_lkeRP100PackagingsItem.TabIndex = 2;
            // 
            // fld_tabPaint
            // 
            this.fld_tabPaint.Controls.Add(this.fld_lkeRP100PaintItems);
            this.fld_tabPaint.Name = "fld_tabPaint";
            this.fld_tabPaint.Size = new System.Drawing.Size(873, 418);
            this.fld_tabPaint.Text = "Sơn";
            // 
            // fld_lkeRP100PaintItems
            // 
            this.fld_lkeRP100PaintItems.BOSComment = null;
            this.fld_lkeRP100PaintItems.BOSDataMember = null;
            this.fld_lkeRP100PaintItems.BOSDataSource = "MMBatchProductProductionNormItems";
            this.fld_lkeRP100PaintItems.BOSDescription = null;
            this.fld_lkeRP100PaintItems.BOSError = null;
            this.fld_lkeRP100PaintItems.BOSFieldGroup = null;
            this.fld_lkeRP100PaintItems.BOSFieldRelation = null;
            this.fld_lkeRP100PaintItems.BOSGridType = null;
            this.fld_lkeRP100PaintItems.BOSPrivilege = null;
            this.fld_lkeRP100PaintItems.BOSPropertyName = null;
            this.fld_lkeRP100PaintItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_lkeRP100PaintItems.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.fld_lkeRP100PaintItems.EmbeddedNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fld_lkeRP100PaintItems.EmbeddedNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fld_lkeRP100PaintItems.EmbeddedNavigator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fld_lkeRP100PaintItems.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.None;
            this.fld_lkeRP100PaintItems.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this.fld_lkeRP100PaintItems.Location = new System.Drawing.Point(0, 0);
            this.fld_lkeRP100PaintItems.MenuManager = this.screenToolbar;
            this.fld_lkeRP100PaintItems.Name = "fld_lkeRP100PaintItems";
            this.fld_lkeRP100PaintItems.PrintReport = false;
            this.fld_lkeRP100PaintItems.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeRP100PaintItems, false);
            this.fld_lkeRP100PaintItems.Size = new System.Drawing.Size(873, 418);
            this.fld_lkeRP100PaintItems.TabIndex = 2;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_lkeRP100MMEquipmentItemsGridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(873, 418);
            this.xtraTabPage1.Text = "CCDC";
            // 
            // fld_lkeRP100MMEquipmentItemsGridControl1
            // 
            this.fld_lkeRP100MMEquipmentItemsGridControl1.BOSComment = null;
            this.fld_lkeRP100MMEquipmentItemsGridControl1.BOSDataMember = null;
            this.fld_lkeRP100MMEquipmentItemsGridControl1.BOSDataSource = "MMBatchProductProductionNormItems";
            this.fld_lkeRP100MMEquipmentItemsGridControl1.BOSDescription = null;
            this.fld_lkeRP100MMEquipmentItemsGridControl1.BOSError = null;
            this.fld_lkeRP100MMEquipmentItemsGridControl1.BOSFieldGroup = null;
            this.fld_lkeRP100MMEquipmentItemsGridControl1.BOSFieldRelation = null;
            this.fld_lkeRP100MMEquipmentItemsGridControl1.BOSGridType = null;
            this.fld_lkeRP100MMEquipmentItemsGridControl1.BOSPrivilege = null;
            this.fld_lkeRP100MMEquipmentItemsGridControl1.BOSPropertyName = null;
            this.fld_lkeRP100MMEquipmentItemsGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_lkeRP100MMEquipmentItemsGridControl1.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.fld_lkeRP100MMEquipmentItemsGridControl1.EmbeddedNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fld_lkeRP100MMEquipmentItemsGridControl1.EmbeddedNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fld_lkeRP100MMEquipmentItemsGridControl1.EmbeddedNavigator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fld_lkeRP100MMEquipmentItemsGridControl1.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.None;
            this.fld_lkeRP100MMEquipmentItemsGridControl1.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this.fld_lkeRP100MMEquipmentItemsGridControl1.Location = new System.Drawing.Point(0, 0);
            this.fld_lkeRP100MMEquipmentItemsGridControl1.MenuManager = this.screenToolbar;
            this.fld_lkeRP100MMEquipmentItemsGridControl1.Name = "fld_lkeRP100MMEquipmentItemsGridControl1";
            this.fld_lkeRP100MMEquipmentItemsGridControl1.PrintReport = false;
            this.fld_lkeRP100MMEquipmentItemsGridControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeRP100MMEquipmentItemsGridControl1, false);
            this.fld_lkeRP100MMEquipmentItemsGridControl1.Size = new System.Drawing.Size(873, 418);
            this.fld_lkeRP100MMEquipmentItemsGridControl1.TabIndex = 3;
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(255, 15);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, true);
            this.bosLabel8.Size = new System.Drawing.Size(68, 13);
            this.bosLabel8.TabIndex = 25;
            this.bosLabel8.Text = "Đơn bán hàng";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.fld_btnClose);
            this.panelControl2.Controls.Add(this.fld_btnExportExcel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 514);
            this.panelControl2.Name = "panelControl2";
            this.ScreenHelper.SetShowHelp(this.panelControl2, true);
            this.panelControl2.Size = new System.Drawing.Size(880, 46);
            this.panelControl2.TabIndex = 9;
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
            this.fld_btnClose.Location = new System.Drawing.Point(795, 9);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnClose, true);
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 1;
            this.fld_btnClose.Text = "Close";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
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
            this.fld_btnExportExcel.Location = new System.Drawing.Point(701, 9);
            this.fld_btnExportExcel.Name = "fld_btnExportExcel";
            this.fld_btnExportExcel.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnExportExcel, true);
            this.fld_btnExportExcel.Size = new System.Drawing.Size(88, 27);
            this.fld_btnExportExcel.TabIndex = 0;
            this.fld_btnExportExcel.Text = "Export to excel";
            this.fld_btnExportExcel.Click += new System.EventHandler(this.fld_btnExportExcel_Click);
            // 
            // fld_lkeFK_ARSaleOrderID
            // 
            this.fld_lkeFK_ARSaleOrderID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSaleOrderID.BOSAllowDummy = true;
            this.fld_lkeFK_ARSaleOrderID.BOSComment = null;
            this.fld_lkeFK_ARSaleOrderID.BOSDataMember = "ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.BOSDataSource = "ARSaleOrders";
            this.fld_lkeFK_ARSaleOrderID.BOSDescription = null;
            this.fld_lkeFK_ARSaleOrderID.BOSError = null;
            this.fld_lkeFK_ARSaleOrderID.BOSFieldGroup = null;
            this.fld_lkeFK_ARSaleOrderID.BOSFieldParent = null;
            this.fld_lkeFK_ARSaleOrderID.BOSFieldRelation = null;
            this.fld_lkeFK_ARSaleOrderID.BOSPrivilege = null;
            this.fld_lkeFK_ARSaleOrderID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARSaleOrderID.BOSSelectType = null;
            this.fld_lkeFK_ARSaleOrderID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARSaleOrderID.CurrentDisplayText = null;
            this.fld_lkeFK_ARSaleOrderID.Location = new System.Drawing.Point(330, 12);
            this.fld_lkeFK_ARSaleOrderID.Name = "fld_lkeFK_ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARSaleOrderID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARSaleOrderID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderNo", "Mã")});
            this.fld_lkeFK_ARSaleOrderID.Properties.DisplayMember = "ARSaleOrderNo";
            this.fld_lkeFK_ARSaleOrderID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARSaleOrderID.Properties.ValueMember = "ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ARSaleOrderID, true);
            this.fld_lkeFK_ARSaleOrderID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARSaleOrderID.TabIndex = 26;
            this.fld_lkeFK_ARSaleOrderID.Tag = "DC";
            // 
            // fld_lkeMMBatchProductNo
            // 
            this.fld_lkeMMBatchProductNo.BOSAllowAddNew = false;
            this.fld_lkeMMBatchProductNo.BOSAllowDummy = true;
            this.fld_lkeMMBatchProductNo.BOSComment = null;
            this.fld_lkeMMBatchProductNo.BOSDataMember = "MMBatchProductNo";
            this.fld_lkeMMBatchProductNo.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMBatchProductNo.BOSDescription = null;
            this.fld_lkeMMBatchProductNo.BOSError = null;
            this.fld_lkeMMBatchProductNo.BOSFieldGroup = null;
            this.fld_lkeMMBatchProductNo.BOSFieldParent = null;
            this.fld_lkeMMBatchProductNo.BOSFieldRelation = null;
            this.fld_lkeMMBatchProductNo.BOSPrivilege = null;
            this.fld_lkeMMBatchProductNo.BOSPropertyName = "EditValue";
            this.fld_lkeMMBatchProductNo.BOSSelectType = null;
            this.fld_lkeMMBatchProductNo.BOSSelectTypeValue = null;
            this.fld_lkeMMBatchProductNo.CurrentDisplayText = null;
            this.fld_lkeMMBatchProductNo.Location = new System.Drawing.Point(580, 12);
            this.fld_lkeMMBatchProductNo.Name = "fld_lkeMMBatchProductNo";
            this.fld_lkeMMBatchProductNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMBatchProductNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMBatchProductNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMBatchProductNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMBatchProductNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMBatchProductNo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã")});
            this.fld_lkeMMBatchProductNo.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeMMBatchProductNo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMBatchProductNo.Properties.ValueMember = "MMBatchProductNo";
            this.fld_lkeMMBatchProductNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMBatchProductNo, true);
            this.fld_lkeMMBatchProductNo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMBatchProductNo.TabIndex = 28;
            this.fld_lkeMMBatchProductNo.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(12, 15);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(56, 13);
            this.bosLabel6.TabIndex = 19;
            this.bosLabel6.Text = "Khách hàng";
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
            this.bosLabel10.Location = new System.Drawing.Point(12, 41);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, true);
            this.bosLabel10.Size = new System.Drawing.Size(40, 13);
            this.bosLabel10.TabIndex = 21;
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
            this.fld_dteSearchToDate.Location = new System.Drawing.Point(330, 38);
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteSearchToDate, true);
            this.fld_dteSearchToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToDate.TabIndex = 22;
            this.fld_dteSearchToDate.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(255, 41);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, true);
            this.bosLabel9.Size = new System.Drawing.Size(47, 13);
            this.bosLabel9.TabIndex = 23;
            this.bosLabel9.Text = "Đến ngày";
            // 
            // fld_dteSearchFromDate
            // 
            this.fld_dteSearchFromDate.EditValue = null;
            this.fld_dteSearchFromDate.Location = new System.Drawing.Point(75, 38);
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromDate.TabIndex = 20;
            this.fld_dteSearchFromDate.TabStop = false;
            this.fld_dteSearchFromDate.Tag = "DC";
            // 
            // RP100
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Name = "RP100";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theo dõi cấp phát";
            this.Load += new System.EventHandler(this.RP100_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabRP100ProductionNorm)).EndInit();
            this.fld_tabRP100ProductionNorm.ResumeLayout(false);
            this.fld_tabSemiProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcWoodPlantItemDetail)).EndInit();
            this.fld_tabHardware.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP100HardwareItems)).EndInit();
            this.fld_tabPackaging.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeRP100PackagingsItem)).EndInit();
            this.fld_tabPaint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeRP100PaintItems)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeRP100MMEquipmentItemsGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl bosPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnExportExcel;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSaleOrderID;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeMMBatchProductNo;
        private BOSComponent.BOSTabControl fld_tabRP100ProductionNorm;
        private DevExpress.XtraTab.XtraTabPage fld_tabSemiProduct;
        private DevExpress.XtraTab.XtraTabPage fld_tabHardware;
        private DevExpress.XtraTab.XtraTabPage fld_tabPackaging;
        private DevExpress.XtraTab.XtraTabPage fld_tabPaint;
        private BOSComponent.BOSLookupEdit fld_lkeARCustomerID1;
        private RP100MMWoodPlantItemDetailGridControl fld_dgcWoodPlantItemDetail;
        private RP100MMHardwareGridControl fld_dgcRP100HardwareItems;
        private RP100MMPackagingsItemGridControl fld_lkeRP100PackagingsItem;
        private RP100MMPaintItemsGridControl fld_lkeRP100PaintItems;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private RP100MMEquipmentItemDetailGridControl fld_lkeRP100MMEquipmentItemsGridControl1;
        private DevExpress.XtraEditors.DateEdit fld_dteSearchFromDate;

    }
}