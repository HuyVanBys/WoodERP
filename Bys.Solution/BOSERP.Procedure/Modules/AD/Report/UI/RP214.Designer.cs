namespace BOSERP.Modules.Report
{
    partial class RP214
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP214));
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new DevExpress.XtraEditors.PanelControl();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcRP101SaleOrders = new BOSERP.Modules.Report.RP214MMBatchProductItemsGridControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeBatchProductStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeBatchProductNo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_ldkARSaleOrderNo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP101SaleOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBatchProductStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBatchProductNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ldkARSaleOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnClose
            // 
            resources.ApplyResources(this.fld_btnClose, "fld_btnClose");
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
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnClose, ((bool)(resources.GetObject("fld_btnClose.ShowHelp"))));
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // bosPanel1
            // 
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.panelControl2);
            this.bosPanel1.Controls.Add(this.panelControl1);
            resources.ApplyResources(this.bosPanel1, "bosPanel1");
            this.bosPanel1.Name = "bosPanel1";
            this.ScreenHelper.SetShowHelp(this.bosPanel1, ((bool)(resources.GetObject("bosPanel1.ShowHelp"))));
            // 
            // bosLine1
            // 
            resources.ApplyResources(this.bosLine1, "bosLine1");
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_dgcRP101SaleOrders);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine1, ((bool)(resources.GetObject("bosLine1.ShowHelp"))));
            this.bosLine1.TabStop = false;
            // 
            // fld_dgcRP101SaleOrders
            // 
            resources.ApplyResources(this.fld_dgcRP101SaleOrders, "fld_dgcRP101SaleOrders");
            this.fld_dgcRP101SaleOrders.BOSComment = null;
            this.fld_dgcRP101SaleOrders.BOSDataMember = null;
            this.fld_dgcRP101SaleOrders.BOSDataSource = "MMBatchProductItems";
            this.fld_dgcRP101SaleOrders.BOSDescription = null;
            this.fld_dgcRP101SaleOrders.BOSError = null;
            this.fld_dgcRP101SaleOrders.BOSFieldGroup = null;
            this.fld_dgcRP101SaleOrders.BOSFieldRelation = null;
            this.fld_dgcRP101SaleOrders.BOSGridType = null;
            this.fld_dgcRP101SaleOrders.BOSPrivilege = null;
            this.fld_dgcRP101SaleOrders.BOSPropertyName = null;
            this.fld_dgcRP101SaleOrders.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("fld_dgcRP101SaleOrders.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.fld_dgcRP101SaleOrders.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("fld_dgcRP101SaleOrders.EmbeddedNavigator.Anchor")));
            this.fld_dgcRP101SaleOrders.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("fld_dgcRP101SaleOrders.EmbeddedNavigator.BackgroundImageLayout")));
            this.fld_dgcRP101SaleOrders.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("fld_dgcRP101SaleOrders.EmbeddedNavigator.ImeMode")));
            this.fld_dgcRP101SaleOrders.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("fld_dgcRP101SaleOrders.EmbeddedNavigator.TextLocation")));
            this.fld_dgcRP101SaleOrders.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("fld_dgcRP101SaleOrders.EmbeddedNavigator.ToolTipIconType")));
            this.fld_dgcRP101SaleOrders.MenuManager = this.screenToolbar;
            this.fld_dgcRP101SaleOrders.Name = "fld_dgcRP101SaleOrders";
            this.fld_dgcRP101SaleOrders.PrintReport = false;
            this.fld_dgcRP101SaleOrders.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcRP101SaleOrders, ((bool)(resources.GetObject("fld_dgcRP101SaleOrders.ShowHelp"))));
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.fld_btnClose);
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Name = "panelControl2";
            this.ScreenHelper.SetShowHelp(this.panelControl2, ((bool)(resources.GetObject("panelControl2.ShowHelp"))));
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_lkeBatchProductStatus);
            this.panelControl1.Controls.Add(this.bosLabel2);
            this.panelControl1.Controls.Add(this.fld_lkeBatchProductNo);
            this.panelControl1.Controls.Add(this.bosLabel1);
            this.panelControl1.Controls.Add(this.fld_ldkARSaleOrderNo);
            this.panelControl1.Controls.Add(this.bosLabel8);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Controls.Add(this.fld_dteSearchToDate);
            this.panelControl1.Controls.Add(this.bosLabel9);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromDate);
            this.panelControl1.Controls.Add(this.bosLabel10);
            this.panelControl1.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.panelControl1.Controls.Add(this.bosLabel6);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            this.ScreenHelper.SetShowHelp(this.panelControl1, ((bool)(resources.GetObject("panelControl1.ShowHelp"))));
            this.panelControl1.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_lkeBatchProductStatus
            // 
            this.fld_lkeBatchProductStatus.BOSAllowAddNew = false;
            this.fld_lkeBatchProductStatus.BOSAllowDummy = true;
            this.fld_lkeBatchProductStatus.BOSComment = null;
            this.fld_lkeBatchProductStatus.BOSDataMember = "MMBatchProductStatus";
            this.fld_lkeBatchProductStatus.BOSDataSource = "MMBatchProducts";
            this.fld_lkeBatchProductStatus.BOSDescription = null;
            this.fld_lkeBatchProductStatus.BOSError = null;
            this.fld_lkeBatchProductStatus.BOSFieldGroup = null;
            this.fld_lkeBatchProductStatus.BOSFieldParent = null;
            this.fld_lkeBatchProductStatus.BOSFieldRelation = null;
            this.fld_lkeBatchProductStatus.BOSPrivilege = null;
            this.fld_lkeBatchProductStatus.BOSPropertyName = null;
            this.fld_lkeBatchProductStatus.BOSSelectType = null;
            this.fld_lkeBatchProductStatus.BOSSelectTypeValue = null;
            this.fld_lkeBatchProductStatus.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeBatchProductStatus, "fld_lkeBatchProductStatus");
            this.fld_lkeBatchProductStatus.MenuManager = this.screenToolbar;
            this.fld_lkeBatchProductStatus.Name = "fld_lkeBatchProductStatus";
            this.fld_lkeBatchProductStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeBatchProductStatus.Properties.Buttons"))))});
            this.fld_lkeBatchProductStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeBatchProductStatus, ((bool)(resources.GetObject("fld_lkeBatchProductStatus.ShowHelp"))));
            this.fld_lkeBatchProductStatus.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel2, "bosLabel2");
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, ((bool)(resources.GetObject("bosLabel2.ShowHelp"))));
            this.bosLabel2.Tag = global::Localization.SaleOrderLocalizedResources.String;
            // 
            // fld_lkeBatchProductNo
            // 
            this.fld_lkeBatchProductNo.BOSAllowAddNew = false;
            this.fld_lkeBatchProductNo.BOSAllowDummy = true;
            this.fld_lkeBatchProductNo.BOSComment = null;
            this.fld_lkeBatchProductNo.BOSDataMember = "MMBatchProductID";
            this.fld_lkeBatchProductNo.BOSDataSource = "MMBatchProducts";
            this.fld_lkeBatchProductNo.BOSDescription = null;
            this.fld_lkeBatchProductNo.BOSError = null;
            this.fld_lkeBatchProductNo.BOSFieldGroup = null;
            this.fld_lkeBatchProductNo.BOSFieldParent = null;
            this.fld_lkeBatchProductNo.BOSFieldRelation = null;
            this.fld_lkeBatchProductNo.BOSPrivilege = null;
            this.fld_lkeBatchProductNo.BOSPropertyName = null;
            this.fld_lkeBatchProductNo.BOSSelectType = null;
            this.fld_lkeBatchProductNo.BOSSelectTypeValue = null;
            this.fld_lkeBatchProductNo.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeBatchProductNo, "fld_lkeBatchProductNo");
            this.fld_lkeBatchProductNo.MenuManager = this.screenToolbar;
            this.fld_lkeBatchProductNo.Name = "fld_lkeBatchProductNo";
            this.fld_lkeBatchProductNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeBatchProductNo.Properties.Buttons"))))});
            this.fld_lkeBatchProductNo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeBatchProductNo.Properties.Columns"), resources.GetString("fld_lkeBatchProductNo.Properties.Columns1"))});
            this.fld_lkeBatchProductNo.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeBatchProductNo.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeBatchProductNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeBatchProductNo, ((bool)(resources.GetObject("fld_lkeBatchProductNo.ShowHelp"))));
            this.fld_lkeBatchProductNo.Tag = "SC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel1, "bosLabel1");
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, ((bool)(resources.GetObject("bosLabel1.ShowHelp"))));
            this.bosLabel1.Tag = global::Localization.SaleOrderLocalizedResources.String;
            // 
            // fld_ldkARSaleOrderNo
            // 
            this.fld_ldkARSaleOrderNo.BOSAllowAddNew = false;
            this.fld_ldkARSaleOrderNo.BOSAllowDummy = true;
            this.fld_ldkARSaleOrderNo.BOSComment = null;
            this.fld_ldkARSaleOrderNo.BOSDataMember = "ARSaleOrderID";
            this.fld_ldkARSaleOrderNo.BOSDataSource = "ARSaleOrders";
            this.fld_ldkARSaleOrderNo.BOSDescription = null;
            this.fld_ldkARSaleOrderNo.BOSError = null;
            this.fld_ldkARSaleOrderNo.BOSFieldGroup = null;
            this.fld_ldkARSaleOrderNo.BOSFieldParent = null;
            this.fld_ldkARSaleOrderNo.BOSFieldRelation = null;
            this.fld_ldkARSaleOrderNo.BOSPrivilege = null;
            this.fld_ldkARSaleOrderNo.BOSPropertyName = null;
            this.fld_ldkARSaleOrderNo.BOSSelectType = null;
            this.fld_ldkARSaleOrderNo.BOSSelectTypeValue = null;
            this.fld_ldkARSaleOrderNo.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_ldkARSaleOrderNo, "fld_ldkARSaleOrderNo");
            this.fld_ldkARSaleOrderNo.MenuManager = this.screenToolbar;
            this.fld_ldkARSaleOrderNo.Name = "fld_ldkARSaleOrderNo";
            this.fld_ldkARSaleOrderNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_ldkARSaleOrderNo.Properties.Buttons"))))});
            this.fld_ldkARSaleOrderNo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_ldkARSaleOrderNo.Properties.Columns"), resources.GetString("fld_ldkARSaleOrderNo.Properties.Columns1"))});
            this.fld_ldkARSaleOrderNo.Properties.DisplayMember = "ARSaleOrderNo";
            this.fld_ldkARSaleOrderNo.Properties.ValueMember = "ARSaleOrderID";
            this.fld_ldkARSaleOrderNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_ldkARSaleOrderNo, ((bool)(resources.GetObject("fld_ldkARSaleOrderNo.ShowHelp"))));
            this.fld_ldkARSaleOrderNo.Tag = "SC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel8.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel8.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel8.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel8.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel8.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel8, "bosLabel8");
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, ((bool)(resources.GetObject("bosLabel8.ShowHelp"))));
            this.bosLabel8.Tag = global::Localization.SaleOrderLocalizedResources.String;
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
            resources.ApplyResources(this.fld_btnApply, "fld_btnApply");
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnApply, ((bool)(resources.GetObject("fld_btnApply.ShowHelp"))));
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
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
            resources.ApplyResources(this.fld_dteSearchToDate, "fld_dteSearchToDate");
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteSearchToDate.Properties.Buttons"))))});
            this.fld_dteSearchToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteSearchToDate, ((bool)(resources.GetObject("fld_dteSearchToDate.ShowHelp"))));
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
            resources.ApplyResources(this.bosLabel9, "bosLabel9");
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, ((bool)(resources.GetObject("bosLabel9.ShowHelp"))));
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
            resources.ApplyResources(this.fld_dteSearchFromDate, "fld_dteSearchFromDate");
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteSearchFromDate.Properties.Buttons"))))});
            this.fld_dteSearchFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteSearchFromDate, ((bool)(resources.GetObject("fld_dteSearchFromDate.ShowHelp"))));
            this.fld_dteSearchFromDate.Tag = "DC";
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
            resources.ApplyResources(this.bosLabel10, "bosLabel10");
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, ((bool)(resources.GetObject("bosLabel10.ShowHelp"))));
            // 
            // fld_lkeFK_ARCustomerID
            // 
            this.fld_lkeFK_ARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID.BOSAllowDummy = true;
            this.fld_lkeFK_ARCustomerID.BOSComment = null;
            this.fld_lkeFK_ARCustomerID.BOSDataMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_ARCustomerID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID.BOSError = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldGroup = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldParent = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldRelation = null;
            this.fld_lkeFK_ARCustomerID.BOSPrivilege = null;
            this.fld_lkeFK_ARCustomerID.BOSPropertyName = null;
            this.fld_lkeFK_ARCustomerID.BOSSelectType = null;
            this.fld_lkeFK_ARCustomerID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARCustomerID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_ARCustomerID, "fld_lkeFK_ARCustomerID");
            this.fld_lkeFK_ARCustomerID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_ARCustomerID.Properties.Buttons"))))});
            this.fld_lkeFK_ARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ARCustomerID.Properties.Columns"), resources.GetString("fld_lkeFK_ARCustomerID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ARCustomerID.Properties.Columns2"), resources.GetString("fld_lkeFK_ARCustomerID.Properties.Columns3"))});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ARCustomerID, ((bool)(resources.GetObject("fld_lkeFK_ARCustomerID.ShowHelp"))));
            this.fld_lkeFK_ARCustomerID.Tag = "SC";
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
            resources.ApplyResources(this.bosLabel6, "bosLabel6");
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, ((bool)(resources.GetObject("bosLabel6.ShowHelp"))));
            // 
            // RP214
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RP214";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Load += new System.EventHandler(this.RP093_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP101SaleOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBatchProductStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBatchProductNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ldkARSaleOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private DevExpress.XtraEditors.PanelControl bosPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSLine bosLine1;
        private RP214MMBatchProductItemsGridControl fld_dgcRP101SaleOrders;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeBatchProductNo;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_ldkARSaleOrderNo;
        private BOSComponent.BOSLookupEdit fld_lkeBatchProductStatus;
        private BOSComponent.BOSLabel bosLabel2;
    }
}