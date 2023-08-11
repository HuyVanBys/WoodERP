namespace BOSERP.Modules.Report
{
    partial class RP154
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP154));
            this.fld_btnExportExcel = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new DevExpress.XtraEditors.PanelControl();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcRP154PurchaseOrderItems = new BOSERP.Modules.Report.RP154PurchaseOrderItemsGridControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeACAssObjectAccessKey = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeACObjectAccessKey = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeMMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPPurchaseOrderID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP154PurchaseOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAssObjectAccessKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseOrderID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnExportExcel
            // 
            resources.ApplyResources(this.fld_btnExportExcel, "fld_btnExportExcel");
            this.fld_btnExportExcel.BOSComment = null;
            this.fld_btnExportExcel.BOSDataMember = null;
            this.fld_btnExportExcel.BOSDataSource = null;
            this.fld_btnExportExcel.BOSDescription = null;
            this.fld_btnExportExcel.BOSError = null;
            this.fld_btnExportExcel.BOSFieldGroup = null;
            this.fld_btnExportExcel.BOSFieldRelation = null;
            this.fld_btnExportExcel.BOSPrivilege = null;
            this.fld_btnExportExcel.BOSPropertyName = null;
            this.fld_btnExportExcel.Name = "fld_btnExportExcel";
            this.fld_btnExportExcel.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnExportExcel, ((bool)(resources.GetObject("fld_btnExportExcel.ShowHelp"))));
            this.fld_btnExportExcel.Click += new System.EventHandler(this.fld_btnExportExcel_Click);
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
            this.bosLine1.Controls.Add(this.fld_dgcRP154PurchaseOrderItems);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine1, ((bool)(resources.GetObject("bosLine1.ShowHelp"))));
            this.bosLine1.TabStop = false;
            // 
            // fld_dgcRP154PurchaseOrderItems
            // 
            resources.ApplyResources(this.fld_dgcRP154PurchaseOrderItems, "fld_dgcRP154PurchaseOrderItems");
            this.fld_dgcRP154PurchaseOrderItems.BOSComment = null;
            this.fld_dgcRP154PurchaseOrderItems.BOSDataMember = null;
            this.fld_dgcRP154PurchaseOrderItems.BOSDataSource = "APPurchaseOrderItems";
            this.fld_dgcRP154PurchaseOrderItems.BOSDescription = null;
            this.fld_dgcRP154PurchaseOrderItems.BOSError = null;
            this.fld_dgcRP154PurchaseOrderItems.BOSFieldGroup = null;
            this.fld_dgcRP154PurchaseOrderItems.BOSFieldRelation = null;
            this.fld_dgcRP154PurchaseOrderItems.BOSGridType = null;
            this.fld_dgcRP154PurchaseOrderItems.BOSPrivilege = null;
            this.fld_dgcRP154PurchaseOrderItems.BOSPropertyName = null;
            this.fld_dgcRP154PurchaseOrderItems.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("fld_dgcRP154PurchaseOrderItems.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.fld_dgcRP154PurchaseOrderItems.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("fld_dgcRP154PurchaseOrderItems.EmbeddedNavigator.Anchor")));
            this.fld_dgcRP154PurchaseOrderItems.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("fld_dgcRP154PurchaseOrderItems.EmbeddedNavigator.BackgroundImageLayout")));
            this.fld_dgcRP154PurchaseOrderItems.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("fld_dgcRP154PurchaseOrderItems.EmbeddedNavigator.ImeMode")));
            this.fld_dgcRP154PurchaseOrderItems.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("fld_dgcRP154PurchaseOrderItems.EmbeddedNavigator.TextLocation")));
            this.fld_dgcRP154PurchaseOrderItems.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("fld_dgcRP154PurchaseOrderItems.EmbeddedNavigator.ToolTipIconType")));
            this.fld_dgcRP154PurchaseOrderItems.MenuManager = this.screenToolbar;
            this.fld_dgcRP154PurchaseOrderItems.Name = "fld_dgcRP154PurchaseOrderItems";
            this.fld_dgcRP154PurchaseOrderItems.PrintReport = false;
            this.fld_dgcRP154PurchaseOrderItems.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcRP154PurchaseOrderItems, ((bool)(resources.GetObject("fld_dgcRP154PurchaseOrderItems.ShowHelp"))));
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.fld_btnClose);
            this.panelControl2.Controls.Add(this.fld_btnExportExcel);
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Name = "panelControl2";
            this.ScreenHelper.SetShowHelp(this.panelControl2, ((bool)(resources.GetObject("panelControl2.ShowHelp"))));
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_lkeACAssObjectAccessKey);
            this.panelControl1.Controls.Add(this.fld_lkeACObjectAccessKey);
            this.panelControl1.Controls.Add(this.fld_lkeMMBatchProductID);
            this.panelControl1.Controls.Add(this.bosLabel3);
            this.panelControl1.Controls.Add(this.bosLabel2);
            this.panelControl1.Controls.Add(this.bosLabel1);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Controls.Add(this.fld_dteSearchToDate);
            this.panelControl1.Controls.Add(this.bosLabel9);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromDate);
            this.panelControl1.Controls.Add(this.bosLabel10);
            this.panelControl1.Controls.Add(this.fld_lkeAPPurchaseOrderID);
            this.panelControl1.Controls.Add(this.bosLabel6);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            this.ScreenHelper.SetShowHelp(this.panelControl1, ((bool)(resources.GetObject("panelControl1.ShowHelp"))));
            this.panelControl1.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_lkeACAssObjectAccessKey
            // 
            this.fld_lkeACAssObjectAccessKey.BOSAllowAddNew = false;
            this.fld_lkeACAssObjectAccessKey.BOSAllowDummy = true;
            this.fld_lkeACAssObjectAccessKey.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACAssObjectAccessKey.BOSDataMember = "ACAssObjectAccessKey";
            this.fld_lkeACAssObjectAccessKey.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACAssObjectAccessKey.BOSDescription = null;
            this.fld_lkeACAssObjectAccessKey.BOSError = null;
            this.fld_lkeACAssObjectAccessKey.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACAssObjectAccessKey.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACAssObjectAccessKey.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACAssObjectAccessKey.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACAssObjectAccessKey.BOSPropertyName = "EditValue";
            this.fld_lkeACAssObjectAccessKey.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACAssObjectAccessKey.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACAssObjectAccessKey.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeACAssObjectAccessKey, "fld_lkeACAssObjectAccessKey");
            this.fld_lkeACAssObjectAccessKey.Name = "fld_lkeACAssObjectAccessKey";
            this.fld_lkeACAssObjectAccessKey.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACAssObjectAccessKey.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACAssObjectAccessKey.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACAssObjectAccessKey.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACAssObjectAccessKey.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeACAssObjectAccessKey.Properties.Buttons"))))});
            this.fld_lkeACAssObjectAccessKey.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeACAssObjectAccessKey.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACAssObjectAccessKey.Properties.PopupWidth = 40;
            this.fld_lkeACAssObjectAccessKey.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACAssObjectAccessKey.Properties.ValueMember = "ACObjectID";
            this.fld_lkeACAssObjectAccessKey.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeACAssObjectAccessKey, ((bool)(resources.GetObject("fld_lkeACAssObjectAccessKey.ShowHelp"))));
            this.fld_lkeACAssObjectAccessKey.Tag = "DC";
            // 
            // fld_lkeACObjectAccessKey
            // 
            this.fld_lkeACObjectAccessKey.BOSAllowAddNew = false;
            this.fld_lkeACObjectAccessKey.BOSAllowDummy = true;
            this.fld_lkeACObjectAccessKey.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.BOSDescription = null;
            this.fld_lkeACObjectAccessKey.BOSError = null;
            this.fld_lkeACObjectAccessKey.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.BOSPropertyName = "EditValue";
            this.fld_lkeACObjectAccessKey.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeACObjectAccessKey, "fld_lkeACObjectAccessKey");
            this.fld_lkeACObjectAccessKey.Name = "fld_lkeACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeACObjectAccessKey.Properties.Buttons"))))});
            this.fld_lkeACObjectAccessKey.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeACObjectAccessKey.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.Properties.PopupWidth = 40;
            this.fld_lkeACObjectAccessKey.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACObjectAccessKey.Properties.ValueMember = "ACObjectID";
            this.fld_lkeACObjectAccessKey.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeACObjectAccessKey, ((bool)(resources.GetObject("fld_lkeACObjectAccessKey.ShowHelp"))));
            this.fld_lkeACObjectAccessKey.Tag = "DC";
            // 
            // fld_lkeMMBatchProductID
            // 
            this.fld_lkeMMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeMMBatchProductID.BOSAllowDummy = true;
            this.fld_lkeMMBatchProductID.BOSComment = null;
            this.fld_lkeMMBatchProductID.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeMMBatchProductID.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMBatchProductID.BOSDescription = null;
            this.fld_lkeMMBatchProductID.BOSError = null;
            this.fld_lkeMMBatchProductID.BOSFieldGroup = null;
            this.fld_lkeMMBatchProductID.BOSFieldParent = null;
            this.fld_lkeMMBatchProductID.BOSFieldRelation = null;
            this.fld_lkeMMBatchProductID.BOSPrivilege = null;
            this.fld_lkeMMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeMMBatchProductID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeMMBatchProductID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeMMBatchProductID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeMMBatchProductID, "fld_lkeMMBatchProductID");
            this.fld_lkeMMBatchProductID.MenuManager = this.screenToolbar;
            this.fld_lkeMMBatchProductID.Name = "fld_lkeMMBatchProductID";
            this.fld_lkeMMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeMMBatchProductID.Properties.Buttons"))))});
            this.fld_lkeMMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeMMBatchProductID.Properties.Columns"), resources.GetString("fld_lkeMMBatchProductID.Properties.Columns1"))});
            this.fld_lkeMMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeMMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeMMBatchProductID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMBatchProductID, ((bool)(resources.GetObject("fld_lkeMMBatchProductID.ShowHelp"))));
            this.fld_lkeMMBatchProductID.Tag = "DC";
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
            resources.ApplyResources(this.bosLabel3, "bosLabel3");
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, ((bool)(resources.GetObject("bosLabel3.ShowHelp"))));
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
            resources.ApplyResources(this.bosLabel2, "bosLabel2");
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, ((bool)(resources.GetObject("bosLabel2.ShowHelp"))));
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
            resources.ApplyResources(this.bosLabel1, "bosLabel1");
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, ((bool)(resources.GetObject("bosLabel1.ShowHelp"))));
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
            // fld_lkeAPPurchaseOrderID
            // 
            this.fld_lkeAPPurchaseOrderID.BOSAllowAddNew = false;
            this.fld_lkeAPPurchaseOrderID.BOSAllowDummy = true;
            this.fld_lkeAPPurchaseOrderID.BOSComment = null;
            this.fld_lkeAPPurchaseOrderID.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeAPPurchaseOrderID.BOSDataSource = "APPurchaseOrders";
            this.fld_lkeAPPurchaseOrderID.BOSDescription = null;
            this.fld_lkeAPPurchaseOrderID.BOSError = null;
            this.fld_lkeAPPurchaseOrderID.BOSFieldGroup = null;
            this.fld_lkeAPPurchaseOrderID.BOSFieldParent = null;
            this.fld_lkeAPPurchaseOrderID.BOSFieldRelation = null;
            this.fld_lkeAPPurchaseOrderID.BOSPrivilege = null;
            this.fld_lkeAPPurchaseOrderID.BOSPropertyName = "EditValue";
            this.fld_lkeAPPurchaseOrderID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeAPPurchaseOrderID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeAPPurchaseOrderID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeAPPurchaseOrderID, "fld_lkeAPPurchaseOrderID");
            this.fld_lkeAPPurchaseOrderID.MenuManager = this.screenToolbar;
            this.fld_lkeAPPurchaseOrderID.Name = "fld_lkeAPPurchaseOrderID";
            this.fld_lkeAPPurchaseOrderID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeAPPurchaseOrderID.Properties.Buttons"))))});
            this.fld_lkeAPPurchaseOrderID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeAPPurchaseOrderID.Properties.Columns"), resources.GetString("fld_lkeAPPurchaseOrderID.Properties.Columns1"))});
            this.fld_lkeAPPurchaseOrderID.Properties.DisplayMember = "APPurchaseOrderNo";
            this.fld_lkeAPPurchaseOrderID.Properties.ValueMember = "APPurchaseOrderID";
            this.fld_lkeAPPurchaseOrderID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeAPPurchaseOrderID, ((bool)(resources.GetObject("fld_lkeAPPurchaseOrderID.ShowHelp"))));
            this.fld_lkeAPPurchaseOrderID.Tag = "DC";
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
            // RP154
            // 
            this.AcceptButton = this.fld_btnExportExcel;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RP154";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RP137_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP154PurchaseOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAssObjectAccessKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseOrderID.Properties)).EndInit();
            this.ResumeLayout(false);

                                                                                                                                                                                                                                                                                  }

        #endregion

        private BOSComponent.BOSButton fld_btnExportExcel;
        private BOSComponent.BOSButton fld_btnClose;
        private DevExpress.XtraEditors.PanelControl bosPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSLine bosLine1;
        private RP154PurchaseOrderItemsGridControl fld_dgcRP154PurchaseOrderItems;
        private BOSComponent.BOSLookupEdit fld_lkeAPPurchaseOrderID;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeMMBatchProductID;
        private BOSComponent.BOSLabel bosLabel3;
        private AccObjectLookupEdit fld_lkeACAssObjectAccessKey;
        private AccObjectLookupEdit fld_lkeACObjectAccessKey;
    }
}