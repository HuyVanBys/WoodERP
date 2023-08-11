namespace BOSERP.Modules.Report
{
    partial class RP125
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP125));
            this.fld_btnExportExcel = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new DevExpress.XtraEditors.PanelControl();
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcRP125ICShipmentItemgo = new BOSERP.Modules.Report.RP125ICShipmentItemsGridControl();
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcRP125ICShipmentItemVan = new BOSERP.Modules.Report.RP125ICShipmentItemvansGridControl();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcRP125ICShipments = new BOSERP.Modules.Report.RP125ICShipmentsGridControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeMMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.bosLine3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP125ICShipmentItemgo)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP125ICShipmentItemVan)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP125ICShipments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerID.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosLine3);
            this.bosPanel1.Controls.Add(this.bosLine2);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.panelControl2);
            this.bosPanel1.Controls.Add(this.panelControl1);
            resources.ApplyResources(this.bosPanel1, "bosPanel1");
            this.bosPanel1.Name = "bosPanel1";
            this.ScreenHelper.SetShowHelp(this.bosPanel1, ((bool)(resources.GetObject("bosPanel1.ShowHelp"))));
            // 
            // bosLine3
            // 
            resources.ApplyResources(this.bosLine3, "bosLine3");
            this.bosLine3.BOSComment = null;
            this.bosLine3.BOSDataMember = null;
            this.bosLine3.BOSDataSource = null;
            this.bosLine3.BOSDescription = null;
            this.bosLine3.BOSError = null;
            this.bosLine3.BOSFieldGroup = null;
            this.bosLine3.BOSFieldRelation = null;
            this.bosLine3.BOSPrivilege = null;
            this.bosLine3.BOSPropertyName = null;
            this.bosLine3.Controls.Add(this.fld_dgcRP125ICShipmentItemgo);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine3, ((bool)(resources.GetObject("bosLine3.ShowHelp"))));
            this.bosLine3.TabStop = false;
            // 
            // fld_dgcRP125ICShipmentItemgo
            // 
            resources.ApplyResources(this.fld_dgcRP125ICShipmentItemgo, "fld_dgcRP125ICShipmentItemgo");
            this.fld_dgcRP125ICShipmentItemgo.BOSComment = null;
            this.fld_dgcRP125ICShipmentItemgo.BOSDataMember = null;
            this.fld_dgcRP125ICShipmentItemgo.BOSDataSource = "ICShipmentItems";
            this.fld_dgcRP125ICShipmentItemgo.BOSDescription = null;
            this.fld_dgcRP125ICShipmentItemgo.BOSError = null;
            this.fld_dgcRP125ICShipmentItemgo.BOSFieldGroup = null;
            this.fld_dgcRP125ICShipmentItemgo.BOSFieldRelation = null;
            this.fld_dgcRP125ICShipmentItemgo.BOSGridType = null;
            this.fld_dgcRP125ICShipmentItemgo.BOSPrivilege = null;
            this.fld_dgcRP125ICShipmentItemgo.BOSPropertyName = null;
            this.fld_dgcRP125ICShipmentItemgo.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("fld_dgcRP125ICShipmentItemgo.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.fld_dgcRP125ICShipmentItemgo.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("fld_dgcRP125ICShipmentItemgo.EmbeddedNavigator.Anchor")));
            this.fld_dgcRP125ICShipmentItemgo.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("fld_dgcRP125ICShipmentItemgo.EmbeddedNavigator.BackgroundImageLayout")));
            this.fld_dgcRP125ICShipmentItemgo.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("fld_dgcRP125ICShipmentItemgo.EmbeddedNavigator.ImeMode")));
            this.fld_dgcRP125ICShipmentItemgo.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("fld_dgcRP125ICShipmentItemgo.EmbeddedNavigator.TextLocation")));
            this.fld_dgcRP125ICShipmentItemgo.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("fld_dgcRP125ICShipmentItemgo.EmbeddedNavigator.ToolTipIconType")));
            this.fld_dgcRP125ICShipmentItemgo.MenuManager = this.screenToolbar;
            this.fld_dgcRP125ICShipmentItemgo.Name = "fld_dgcRP125ICShipmentItemgo";
            this.fld_dgcRP125ICShipmentItemgo.PrintReport = false;
            this.fld_dgcRP125ICShipmentItemgo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcRP125ICShipmentItemgo, ((bool)(resources.GetObject("fld_dgcRP125ICShipmentItemgo.ShowHelp"))));
            // 
            // bosLine2
            // 
            resources.ApplyResources(this.bosLine2, "bosLine2");
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.fld_dgcRP125ICShipmentItemVan);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine2, ((bool)(resources.GetObject("bosLine2.ShowHelp"))));
            this.bosLine2.TabStop = false;
            // 
            // fld_dgcRP125ICShipmentItemVan
            // 
            resources.ApplyResources(this.fld_dgcRP125ICShipmentItemVan, "fld_dgcRP125ICShipmentItemVan");
            this.fld_dgcRP125ICShipmentItemVan.BOSComment = null;
            this.fld_dgcRP125ICShipmentItemVan.BOSDataMember = null;
            this.fld_dgcRP125ICShipmentItemVan.BOSDataSource = "ICShipmentItems";
            this.fld_dgcRP125ICShipmentItemVan.BOSDescription = null;
            this.fld_dgcRP125ICShipmentItemVan.BOSError = null;
            this.fld_dgcRP125ICShipmentItemVan.BOSFieldGroup = null;
            this.fld_dgcRP125ICShipmentItemVan.BOSFieldRelation = null;
            this.fld_dgcRP125ICShipmentItemVan.BOSGridType = null;
            this.fld_dgcRP125ICShipmentItemVan.BOSPrivilege = null;
            this.fld_dgcRP125ICShipmentItemVan.BOSPropertyName = null;
            this.fld_dgcRP125ICShipmentItemVan.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("fld_dgcRP125ICShipmentItemVan.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.fld_dgcRP125ICShipmentItemVan.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("fld_dgcRP125ICShipmentItemVan.EmbeddedNavigator.Anchor")));
            this.fld_dgcRP125ICShipmentItemVan.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("fld_dgcRP125ICShipmentItemVan.EmbeddedNavigator.BackgroundImageLayout")));
            this.fld_dgcRP125ICShipmentItemVan.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("fld_dgcRP125ICShipmentItemVan.EmbeddedNavigator.ImeMode")));
            this.fld_dgcRP125ICShipmentItemVan.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("fld_dgcRP125ICShipmentItemVan.EmbeddedNavigator.TextLocation")));
            this.fld_dgcRP125ICShipmentItemVan.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("fld_dgcRP125ICShipmentItemVan.EmbeddedNavigator.ToolTipIconType")));
            this.fld_dgcRP125ICShipmentItemVan.MenuManager = this.screenToolbar;
            this.fld_dgcRP125ICShipmentItemVan.Name = "fld_dgcRP125ICShipmentItemVan";
            this.fld_dgcRP125ICShipmentItemVan.PrintReport = false;
            this.fld_dgcRP125ICShipmentItemVan.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcRP125ICShipmentItemVan, ((bool)(resources.GetObject("fld_dgcRP125ICShipmentItemVan.ShowHelp"))));
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
            this.bosLine1.Controls.Add(this.fld_dgcRP125ICShipments);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine1, ((bool)(resources.GetObject("bosLine1.ShowHelp"))));
            this.bosLine1.TabStop = false;
            // 
            // fld_dgcRP125ICShipments
            // 
            resources.ApplyResources(this.fld_dgcRP125ICShipments, "fld_dgcRP125ICShipments");
            this.fld_dgcRP125ICShipments.BOSComment = null;
            this.fld_dgcRP125ICShipments.BOSDataMember = null;
            this.fld_dgcRP125ICShipments.BOSDataSource = "ICShipmentItems";
            this.fld_dgcRP125ICShipments.BOSDescription = null;
            this.fld_dgcRP125ICShipments.BOSError = null;
            this.fld_dgcRP125ICShipments.BOSFieldGroup = null;
            this.fld_dgcRP125ICShipments.BOSFieldRelation = null;
            this.fld_dgcRP125ICShipments.BOSGridType = null;
            this.fld_dgcRP125ICShipments.BOSPrivilege = null;
            this.fld_dgcRP125ICShipments.BOSPropertyName = null;
            this.fld_dgcRP125ICShipments.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("fld_dgcRP125ICShipments.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.fld_dgcRP125ICShipments.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("fld_dgcRP125ICShipments.EmbeddedNavigator.Anchor")));
            this.fld_dgcRP125ICShipments.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("fld_dgcRP125ICShipments.EmbeddedNavigator.BackgroundImageLayout")));
            this.fld_dgcRP125ICShipments.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("fld_dgcRP125ICShipments.EmbeddedNavigator.ImeMode")));
            this.fld_dgcRP125ICShipments.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("fld_dgcRP125ICShipments.EmbeddedNavigator.TextLocation")));
            this.fld_dgcRP125ICShipments.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("fld_dgcRP125ICShipments.EmbeddedNavigator.ToolTipIconType")));
            this.fld_dgcRP125ICShipments.MenuManager = this.screenToolbar;
            this.fld_dgcRP125ICShipments.Name = "fld_dgcRP125ICShipments";
            this.fld_dgcRP125ICShipments.PrintReport = false;
            this.fld_dgcRP125ICShipments.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcRP125ICShipments, ((bool)(resources.GetObject("fld_dgcRP125ICShipments.ShowHelp"))));
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
            this.panelControl1.Controls.Add(this.fld_lkeMMBatchProductID);
            this.panelControl1.Controls.Add(this.bosLabel1);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Controls.Add(this.fld_dteSearchToDate);
            this.panelControl1.Controls.Add(this.bosLabel9);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromDate);
            this.panelControl1.Controls.Add(this.bosLabel10);
            this.panelControl1.Controls.Add(this.fld_lkeARCustomerID);
            this.panelControl1.Controls.Add(this.bosLabel6);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            this.ScreenHelper.SetShowHelp(this.panelControl1, ((bool)(resources.GetObject("panelControl1.ShowHelp"))));
            this.panelControl1.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_lkeMMBatchProductID
            // 
            this.fld_lkeMMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeMMBatchProductID.BOSAllowDummy = true;
            this.fld_lkeMMBatchProductID.BOSComment = null;
            this.fld_lkeMMBatchProductID.BOSDataMember = "MMBatchProductID";
            this.fld_lkeMMBatchProductID.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMBatchProductID.BOSDescription = null;
            this.fld_lkeMMBatchProductID.BOSError = null;
            this.fld_lkeMMBatchProductID.BOSFieldGroup = null;
            this.fld_lkeMMBatchProductID.BOSFieldParent = null;
            this.fld_lkeMMBatchProductID.BOSFieldRelation = null;
            this.fld_lkeMMBatchProductID.BOSPrivilege = null;
            this.fld_lkeMMBatchProductID.BOSPropertyName = null;
            this.fld_lkeMMBatchProductID.BOSSelectType = null;
            this.fld_lkeMMBatchProductID.BOSSelectTypeValue = null;
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
            this.fld_lkeMMBatchProductID.Tag = "SC";
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
            this.fld_lkeARCustomerID.BOSPropertyName = null;
            this.fld_lkeARCustomerID.BOSSelectType = null;
            this.fld_lkeARCustomerID.BOSSelectTypeValue = null;
            this.fld_lkeARCustomerID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeARCustomerID, "fld_lkeARCustomerID");
            this.fld_lkeARCustomerID.MenuManager = this.screenToolbar;
            this.fld_lkeARCustomerID.Name = "fld_lkeARCustomerID";
            this.fld_lkeARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeARCustomerID.Properties.Buttons"))))});
            this.fld_lkeARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeARCustomerID.Properties.Columns"), resources.GetString("fld_lkeARCustomerID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeARCustomerID.Properties.Columns2"), resources.GetString("fld_lkeARCustomerID.Properties.Columns3"))});
            this.fld_lkeARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeARCustomerID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeARCustomerID, ((bool)(resources.GetObject("fld_lkeARCustomerID.ShowHelp"))));
            this.fld_lkeARCustomerID.Tag = "SC";
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
            // RP125
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
            this.Name = "RP125";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RP093_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosLine3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP125ICShipmentItemgo)).EndInit();
            this.bosLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP125ICShipmentItemVan)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP125ICShipments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnExportExcel;
        private BOSComponent.BOSButton fld_btnClose;
        private DevExpress.XtraEditors.PanelControl bosPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSLine bosLine1;
        private RP125ICShipmentsGridControl fld_dgcRP125ICShipments;
        private BOSComponent.BOSLookupEdit fld_lkeARCustomerID;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSLookupEdit fld_lkeMMBatchProductID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLine bosLine2;
        private RP125ICShipmentItemvansGridControl fld_dgcRP125ICShipmentItemVan;
        private BOSComponent.BOSLine bosLine3;
        private RP125ICShipmentItemsGridControl fld_dgcRP125ICShipmentItemgo;
    }
}